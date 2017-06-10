Imports System.Data.SqlClient
Imports Biblioteca


Public Class frmDiario

    Private VoyACerrar As Boolean = False
    'Private Modificado As Boolean = False

    Private Sub AsientosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsientosBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.CargosBindingSource.EndEdit()
        Me.AbonosBindingSource.EndEdit()
        Me.AsientosBindingSource.EndEdit()
        Try

            Me.TableAdapterManager.UpdateAll(Me.BDContabilidadMelo)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        If Me.BDContabilidadMelo.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmAsientos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadMelo.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Try

                    Me.Validate()


                    Me.AsientosBindingSource.EndEdit()
                    Me.CargosBindingSource.EndEdit()
                    Me.AbonosBindingSource.EndEdit()

                    Me.TableAdapterManager.UpdateAll(Me.BDContabilidadMelo)


                    If Me.BDContabilidadMelo.HasChanges = False Then

                        MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                    End If

                Catch ex As Exception

                    CMódulo.MsgAdvertencia(ex.Message + " " +
                                   ex.HelpLink)

                End Try

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmAsientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'TODO: esta línea de código carga datos en la tabla 'DsGrupos.CuentasMaestras' Puede moverla o quitarla según sea necesario.
        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadMelo.CuentasMaestras)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadMelo.Cuentas)
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
        Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
        Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)

        Me.Text = My.Resources.Título + " - LIBRO DIARIO"

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub AsientosDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles AsientosDataGridView.DataError

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

        Exit Sub

        MessageBox.Show("Error en AsientosDataGridView " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
            'MsgBox("Núm. Asiento " + Me.AbonosDataGridView(e.ColumnIndex, e.RowIndex).Value.ToString)
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts _
            .CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) _
            Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context = _
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            CType(sender, DataGridView).Rows(e.RowIndex).ErrorText = "an error"
            CType(sender, DataGridView)(e.ColumnIndex, e.RowIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If

    End Sub

    Private Sub btnRenum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenum.Click

        Me.AsientosBindingSource.MoveFirst()

        Me.Cursor = Cursors.WaitCursor

        Dim ds As DataSet = Me.ObtenerAsientosOrdenados()

        '
        ' Limpiar base de datos
        ' Se borran los asientos y sus cargos y abonos
        '
        '
        For Each ast As Contabilidad.BDContabilidadGMELO.AsientosRow In Me.BDContabilidadMelo.Asientos

            For Each apunte As DataRow In ast.GetAbonosRows()

                Me.AbonosTableAdapter.Delete(CInt(apunte("NúmeroAsiento")), CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

            Next

            For Each apunte As DataRow In ast.GetCargosRows

                Me.CargosTableAdapter.Delete(CInt(apunte("NúmeroAsiento")), CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

            Next

            ast.AcceptChanges()
            Me.AsientosTableAdapter.BorrarAsiento(ast.Número, ast.Fecha)

        Next
        Me.AsientosTableAdapter.Update(Me.BDContabilidadMelo.Asientos)

        For Each Asiento As DataRow In ds.Tables("NuevosAsientos").Rows

            With Asiento

                Me.AsientosTableAdapter.Insert(CInt(Asiento("Número")), CDate(Asiento("Fecha")), CStr(Asiento("Justificante")), CStr(Asiento("Operación")))

                For Each apunte As DataRow In Asiento.GetChildRows("AbonosDeUnAsiento")

                    Me.AbonosTableAdapter.Insert(CInt(apunte("NúmeroAsiento")), CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

                Next

                For Each apunte As DataRow In Asiento.GetChildRows("CargosDeUnAsiento")

                    Me.CargosTableAdapter.Insert(CInt(apunte("NúmeroAsiento")), CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

                Next

            End With

        Next
        '
        Me.Cursor = Cursors.Arrow
        '
        MsgBox("Asientos renumerados correctamente", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        '
        ' Refrescar pantalla
        '
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
        Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
        Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)

        Me.AsientosBindingSource.MoveLast()

    End Sub

    Private Function ObtenerAsientosOrdenados() As DataSet
        '
        ' crea tablas de trabajo en la Base de Datos
        '
        Dim ds As New DataSet("dsTrab")

        Dim NuevosAsientos As DataTable = ds.Tables.Add("NuevosAsientos")
        For Each c As DataColumn In BDContabilidadMelo.Asientos.Columns

            Dim cNew As New DataColumn
            cNew.DataType = c.DataType
            cNew.ColumnName = c.ColumnName
            cNew.Unique = c.Unique
            cNew.ReadOnly = c.ReadOnly

            NuevosAsientos.Columns.Add(cNew)

        Next
        ' Make the ID column the primary key column.
        Dim PrimaryKeyColumns(0) As DataColumn
        PrimaryKeyColumns(0) = NuevosAsientos.Columns("Número")
        NuevosAsientos.PrimaryKey = PrimaryKeyColumns

        Dim NuevosCargos As DataTable = ds.Tables.Add("NuevosCargos")
        For Each c As DataColumn In BDContabilidadMelo.Cargos.Columns

            Dim cNew As New DataColumn
            cNew.DataType = c.DataType
            cNew.ColumnName = c.ColumnName
            cNew.Unique = c.Unique
            cNew.ReadOnly = c.ReadOnly

            NuevosCargos.Columns.Add(cNew)

        Next
        Dim PrimaryKeyColumnsCargos(2) As DataColumn
        PrimaryKeyColumnsCargos(0) = NuevosCargos.Columns("NúmeroAsiento")
        PrimaryKeyColumnsCargos(1) = NuevosCargos.Columns("CódigoCuenta")
        PrimaryKeyColumnsCargos(2) = NuevosCargos.Columns("NúmeroApunte")
        NuevosCargos.PrimaryKey = PrimaryKeyColumnsCargos

        Dim NuevosAbonos As DataTable = ds.Tables.Add("NuevosAbonos")
        For Each c As DataColumn In BDContabilidadMelo.Abonos.Columns

            Dim cNew As New DataColumn
            cNew.DataType = c.DataType
            cNew.ColumnName = c.ColumnName
            cNew.Unique = c.Unique
            cNew.ReadOnly = c.ReadOnly

            NuevosAbonos.Columns.Add(cNew)

        Next
        Dim PrimaryKeyColumnsAbonos(2) As DataColumn
        PrimaryKeyColumnsAbonos(0) = NuevosAbonos.Columns("NúmeroAsiento")
        PrimaryKeyColumnsAbonos(1) = NuevosAbonos.Columns("CódigoCuenta")
        PrimaryKeyColumnsAbonos(2) = NuevosAbonos.Columns("NúmeroApunte")
        NuevosAbonos.PrimaryKey = PrimaryKeyColumnsAbonos
        '
        ' crea relaciones entre NuevosAsientos y NuevosCargos y NuevosAbonos
        '
        ds.Relations.Add("CargosDeUnAsiento", ds.Tables("NuevosAsientos").Columns("Número"), ds.Tables("NuevosCargos").Columns("NúmeroAsiento"))
        ds.Relations.Add("AbonosDeUnAsiento", ds.Tables("NuevosAsientos").Columns("Número"), ds.Tables("NuevosAbonos").Columns("NúmeroAsiento"))


        Dim NuevoNúmeroAsiento As Integer = 0

        For Each ViejoAsiento As Contabilidad.BDContabilidadGMELO.AsientosRow In Me.BDContabilidadMelo.Asientos.Select("", "Fecha, Número")

            Dim NuevoAsiento As DataRow = NuevosAsientos.NewRow

            NuevoNúmeroAsiento += 1

            NuevoAsiento("Número") = NuevoNúmeroAsiento
            NuevoAsiento("Fecha") = ViejoAsiento.Fecha
            NuevoAsiento("Justificante") = ViejoAsiento.Justificante
            NuevoAsiento("Operación") = ViejoAsiento.Operación

            NuevosAsientos.Rows.Add(NuevoAsiento)

            Dim NuevoNúmeroApunte As Integer = 0

            For Each ViejoCargo As Contabilidad.BDContabilidadGMELO.CargosRow In ViejoAsiento.GetCargosRows

                Dim NuevoCargo As DataRow = NuevosCargos.NewRow

                NuevoCargo("NúmeroAsiento") = NuevoAsiento("Número")

                NuevoNúmeroApunte += 1

                NuevoCargo("NúmeroApunte") = NuevoNúmeroApunte
                NuevoCargo("CódigoCuenta") = ViejoCargo.CódigoCuenta
                NuevoCargo("Importe") = ViejoCargo.Importe

                NuevosCargos.Rows.Add(NuevoCargo)

                ' Set the parent row of a DataRelation.
                NuevoCargo.SetParentRow(NuevoAsiento, ds.Relations("CargosDeUnAsiento"))

            Next

            NuevoNúmeroApunte = 0

            For Each ViejoAbono As Contabilidad.BDContabilidadGMELO.AbonosRow In ViejoAsiento.GetAbonosRows

                Dim NuevoAbono As DataRow = NuevosAbonos.NewRow

                NuevoAbono("NúmeroAsiento") = NuevoAsiento("Número")

                NuevoNúmeroApunte += 1

                NuevoAbono("NúmeroApunte") = NuevoNúmeroApunte
                NuevoAbono("CódigoCuenta") = ViejoAbono.CódigoCuenta
                NuevoAbono("Importe") = ViejoAbono.Importe

                NuevosAbonos.Rows.Add(NuevoAbono)

                ' Set the parent row of a DataRelation.
                NuevoAbono.SetParentRow(NuevoAsiento, ds.Relations("AbonosDeUnAsiento"))

            Next

        Next

        Return ds

    End Function

    Private Sub btnCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierre.Click

        MsgBox("El cierre está desactivado")

        Exit Sub

        CMódulo.MsgErrorCrítico("ANTES DE OBTENER LA CUENTA DE RESULTADOS Y CERRAR LA CONTABILIDAD DEBE SACAR LOS BALANCES Y HACER UNA COPIA DE SEGURIDAD")

        Dim selecEjercicio As frmSelecFechas = New frmSelecFechas
        selecEjercicio.Text = "ASIENTO DE CIERRE - Selección de Ejercicio"
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro del ejercicio."

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.Cursor = Cursors.WaitCursor

            Dim ejercicio As Date = selecEjercicio.DateTimePicker1.Value

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = ejercicio.Year.ToString

            Dim Cod_Cta_PérdidasGanacias As Integer = 129001

            If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, Cod_Cta_PérdidasGanacias) Then

                Dim CuentaPérdidasGanacias As Contabilidad.BDContabilidadGMELO.CuentasRow = _
                    Me.BDContabilidadMelo.Cuentas.NewCuentasRow
                CuentaPérdidasGanacias.Código = Cod_Cta_PérdidasGanacias
                CuentaPérdidasGanacias.CódigoCuentaMaestra = 129
                CuentaPérdidasGanacias.Nombre = "PÉRDIDAS Y GANANCIAS EJERCICIO " + txtEjercicio

                Me.BDContabilidadMelo.Cuentas.AddCuentasRow(CuentaPérdidasGanacias)

            End If


            '
            ' Cuentas GRUPO 6
            '
            Dim AsientoCierreGastos As Contabilidad.BDContabilidadGMELO.AsientosRow = Me.BDContabilidadMelo.Asientos.NewAsientosRow
            AsientoCierreGastos.Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
            AsientoCierreGastos.Fecha = CDate("31/12/" + txtEjercicio)
            AsientoCierreGastos.Operación = "CIERRE DEL EJERCICIO " + txtEjercicio + ". GASTOS"
            AsientoCierreGastos.Justificante = "CUENTA RESULTADOS"

            Me.BDContabilidadMelo.Asientos.AddAsientosRow(AsientoCierreGastos)

            Dim AbonoCierre As Contabilidad.BDContabilidadGMELO.AbonosRow
            Dim CargoCierre As Contabilidad.BDContabilidadGMELO.CargosRow
            CargoCierre = Me.BDContabilidadMelo.Cargos.NewCargosRow
            CargoCierre.NúmeroAsiento = AsientoCierreGastos.Número
            CargoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreGastos.Número, "C")
            CargoCierre.CódigoCuenta = Cod_Cta_PérdidasGanacias
            CargoCierre.Importe = 0

            For Each Cuenta As Contabilidad.BDContabilidadGMELO.CuentasRow In Me.CuentasTableAdapter.CuentasGasto

                Console.WriteLine(Cuenta.Nombre + " DEBE " + Cuenta.SaldoDebe.ToString + " HABER " + Cuenta.SaldoHaber.ToString)
                AbonoCierre = Me.BDContabilidadMelo.Abonos.NewAbonosRow
                AbonoCierre.NúmeroAsiento = AsientoCierreGastos.Número
                'NúmeroApunte =
                AbonoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreGastos.Número, "A")
                AbonoCierre.CódigoCuenta = Cuenta.Código
                AbonoCierre.Importe = Cuenta.SaldoDebe

                Me.BDContabilidadMelo.Abonos.AddAbonosRow(AbonoCierre)

                CargoCierre.Importe += AbonoCierre.Importe

            Next

            Me.BDContabilidadMelo.Cargos.AddCargosRow(CargoCierre)
            '
            ' ACTUALIZAR BASE DE DATOS
            '
            Me.CuentasTableAdapter.Update(Me.BDContabilidadMelo.Cuentas)
            Me.CuentasBindingSource.ResetBindings(False)

            Me.AsientosTableAdapter.Update(Me.BDContabilidadMelo.Asientos)
            Me.AsientosBindingSource.ResetBindings(False)

            Me.CargosTableAdapter.Update(Me.BDContabilidadMelo.Cargos)
            Me.CargosBindingSource.ResetBindings(False)

            Me.AbonosTableAdapter.Update(Me.BDContabilidadMelo.Abonos)
            Me.AbonosBindingSource.ResetBindings(False)

            Me.BDContabilidadMelo.Abonos.Clear()
            Me.BDContabilidadMelo.Cargos.Clear()
            Me.BDContabilidadMelo.Asientos.Clear()
            Me.BDContabilidadMelo.Cuentas.Clear()
            '
            ' RECARGAR LA BASE DE DATOS
            '
            Me.CuentasTableAdapter.Fill(Me.BDContabilidadMelo.Cuentas)
            Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
            Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
            Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)

            '
            ' Cuentas GRUPO 7
            '
            Dim AsientoCierreIngresos As Contabilidad.BDContabilidadGMELO.AsientosRow = Me.BDContabilidadMelo.Asientos.NewAsientosRow
            AsientoCierreIngresos.Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
            AsientoCierreIngresos.Fecha = CDate("31/12/" + txtEjercicio)
            AsientoCierreIngresos.Operación = "CIERRE DEL EJERCICIO " + txtEjercicio + ". INGRESOS"
            AsientoCierreIngresos.Justificante = "CUENTA RESULTADOS"

            Me.BDContabilidadMelo.Asientos.AddAsientosRow(AsientoCierreIngresos)

            AbonoCierre = Me.BDContabilidadMelo.Abonos.NewAbonosRow
            AbonoCierre.NúmeroAsiento = AsientoCierreIngresos.Número
            AbonoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreIngresos.Número, "A")
            AbonoCierre.CódigoCuenta = Cod_Cta_PérdidasGanacias
            AbonoCierre.Importe = 0

            For Each Cuenta As Contabilidad.BDContabilidadGMELO.CuentasRow In Me.CuentasTableAdapter.CuentasIngreso

                Console.WriteLine(Cuenta.Nombre + " DEBE " + Cuenta.SaldoDebe.ToString + " HABER " + Cuenta.SaldoHaber.ToString)
                CargoCierre = Me.BDContabilidadMelo.Cargos.NewCargosRow
                CargoCierre.NúmeroAsiento = AsientoCierreIngresos.Número
                CargoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreIngresos.Número, "C")
                CargoCierre.CódigoCuenta = Cuenta.Código
                CargoCierre.Importe = Cuenta.SaldoHaber

                Me.BDContabilidadMelo.Cargos.AddCargosRow(CargoCierre)

                AbonoCierre.Importe += CargoCierre.Importe

            Next

            Me.BDContabilidadMelo.Abonos.AddAbonosRow(AbonoCierre)
            '
            ' ACTUALIZAR BASE DE DATOS
            '
            Me.CuentasTableAdapter.Update(Me.BDContabilidadMelo.Cuentas)
            Me.CuentasBindingSource.ResetBindings(False)

            Me.AsientosTableAdapter.Update(Me.BDContabilidadMelo.Asientos)
            Me.AsientosBindingSource.ResetBindings(False)

            Me.CargosTableAdapter.Update(Me.BDContabilidadMelo.Cargos)
            Me.CargosBindingSource.ResetBindings(False)

            Me.AbonosTableAdapter.Update(Me.BDContabilidadMelo.Abonos)
            Me.AbonosBindingSource.ResetBindings(False)

            ''
            '' Cierre de la Contabilidad
            ''
            AsientoCierreIngresos = Me.BDContabilidadMelo.Asientos.NewAsientosRow
            AsientoCierreIngresos.Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
            AsientoCierreIngresos.Fecha = CDate("31/12/" + txtEjercicio)
            AsientoCierreIngresos.Operación = "CIERRE DE LA CONTABILIDAD " + txtEjercicio
            AsientoCierreIngresos.Justificante = "CIERRE DE LA CONTABILIDAD"

            Me.BDContabilidadMelo.Asientos.AddAsientosRow(AsientoCierreIngresos)

            AbonoCierre = Me.BDContabilidadMelo.Abonos.NewAbonosRow
            AbonoCierre.NúmeroAsiento = AsientoCierreIngresos.Número
            AbonoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreIngresos.Número, "A")
            AbonoCierre.CódigoCuenta = Cod_Cta_PérdidasGanacias
            AbonoCierre.Importe = 0

            For Each Cuenta As Contabilidad.BDContabilidadGMELO.CuentasRow In Me.CuentasTableAdapter.CuentasBalance '.CuentasGestión

                If Cuenta.SaldoDebe > 0 And Cuenta.SaldoHaber = 0 Then

                    'Console.WriteLine(Cuenta.Nombre + " DEBE " + Cuenta.SaldoDebe.ToString + " HABER " + Cuenta.SaldoHaber.ToString)
                    AbonoCierre = Me.BDContabilidadMelo.Abonos.NewAbonosRow
                    AbonoCierre.NúmeroAsiento = AsientoCierreIngresos.Número
                    AbonoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreIngresos.Número, "A")
                    AbonoCierre.CódigoCuenta = Cuenta.Código
                    AbonoCierre.Importe = Cuenta.SaldoDebe

                    Me.BDContabilidadMelo.Abonos.AddAbonosRow(AbonoCierre)

                Else

                    'Console.WriteLine(Cuenta.Nombre + " DEBE " + Cuenta.SaldoDebe.ToString + " HABER " + Cuenta.SaldoHaber.ToString)
                    CargoCierre = Me.BDContabilidadMelo.Cargos.NewCargosRow
                    CargoCierre.NúmeroAsiento = AsientoCierreIngresos.Número
                    CargoCierre.NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, AsientoCierreIngresos.Número, "C")
                    CargoCierre.CódigoCuenta = Cuenta.Código
                    CargoCierre.Importe = Cuenta.SaldoHaber

                    Me.BDContabilidadMelo.Cargos.AddCargosRow(CargoCierre)

                End If

            Next

            '
            ' ACTUALIZAR BASE DE DATOS
            '
            Me.CuentasTableAdapter.Update(Me.BDContabilidadMelo.Cuentas)
            Me.CuentasBindingSource.ResetBindings(False)

            Me.AsientosTableAdapter.Update(Me.BDContabilidadMelo.Asientos)
            Me.AsientosBindingSource.ResetBindings(False)

            Me.CargosTableAdapter.Update(Me.BDContabilidadMelo.Cargos)
            Me.CargosBindingSource.ResetBindings(False)

            Me.AbonosTableAdapter.Update(Me.BDContabilidadMelo.Abonos)
            Me.AbonosBindingSource.ResetBindings(False)

            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub ContextMenuOPERACIONES_Click(sender As Object, e As EventArgs) Handles ContextMenuOPERACIONES.Click

        With CType(sender, ContextMenuStrip)

            For i As Integer = 0 To .Items.Count - 1

                If .Items(i).Selected Then

                    Me.AsientosDataGridView.CurrentCell.Value = .Items(i).Text
                    Exit Sub

                End If

            Next

        End With

    End Sub

    Private Sub btnListarDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarDiario.Click

        Me.Cursor = Cursors.WaitCursor

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Me.BDContabilidadMelo

            .LíneasDiario.Clear()
            For Each asiento As Contabilidad.BDContabilidadGMELO.AsientosRow In Me.BDContabilidadMelo.Asientos

                For Each cargo As Contabilidad.BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                    Dim Línea As Contabilidad.BDContabilidadGMELO.LíneasDiarioRow = Me.BDContabilidadMelo.LíneasDiario.NewLíneasDiarioRow

                    Línea.Número = asiento.Número
                    Línea.Fecha = asiento.Fecha
                    Línea.Justificante = asiento.Justificante
                    Línea.Operación = asiento.Operación

                    Línea.ApunteCargo = cargo.NúmeroApunte
                    Línea.CuentaCargo = cargo.CódigoCuenta
                    ' Línea.CódigoCuentaMaestraCargo = Me.CuentasTableAdapter.CódigoCuentaMaestra(cargo.CódigoCuenta)
                    ' Línea.NombreCuentaMaestraCargo = Me.CuentasMaestrasTableAdapter.NombreCuentaMaestra(Línea.CódigoCuentaMaestraCargo)
                    Línea.NombreCuentaCargo = Me.CuentasTableAdapter.NombreCuenta(cargo.CódigoCuenta)
                    Línea.ImporteCargo = cargo.Importe

                    Me.BDContabilidadMelo.LíneasDiario.AddLíneasDiarioRow(Línea)

                Next

                For Each abono As Contabilidad.BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                    Dim Línea As Contabilidad.BDContabilidadGMELO.LíneasDiarioRow = Me.BDContabilidadMelo.LíneasDiario.NewLíneasDiarioRow

                    Línea.Número = asiento.Número
                    Línea.Fecha = asiento.Fecha
                    Línea.Justificante = asiento.Justificante
                    Línea.Operación = asiento.Operación

                    Línea.ApunteAbono = abono.NúmeroApunte
                    Línea.CuentaAbono = abono.CódigoCuenta
                    Línea.NombreCuentaAbono = CuentasTableAdapter.NombreCuenta(abono.CódigoCuenta)
                    Línea.ImporteAbono = abono.Importe

                    Me.BDContabilidadMelo.LíneasDiario.AddLíneasDiarioRow(Línea)

                Next

            Next

        End With

        With Listado

            .NombreInforme = "Diario.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadMelo
            .Filtro = ""

            Listado.ShowDialog()

        End With

        Me.BDContabilidadMelo.LíneasDiario.RejectChanges()

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AsientosDescuadradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsientosDescuadradosToolStripMenuItem.Click

        Me.Cursor = Cursors.WaitCursor

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Me.BDContabilidadMelo

            .LíneasDiario.Clear()
            For Each asiento As Contabilidad.BDContabilidadGMELO.AsientosRow In BDContabilidadMelo.Asientos

                If asiento.Debe <> asiento.Haber Then

                    For Each cargo As Contabilidad.BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                        Dim Línea As Contabilidad.BDContabilidadGMELO.LíneasDiarioRow = Me.BDContabilidadMelo.LíneasDiario.NewLíneasDiarioRow

                        Línea.Número = asiento.Número
                        Línea.Fecha = asiento.Fecha
                        Línea.Justificante = asiento.Justificante
                        Línea.Operación = asiento.Operación

                        Línea.ApunteCargo = cargo.NúmeroApunte
                        Línea.CuentaCargo = cargo.CódigoCuenta
                        Línea.NombreCuentaCargo = Me.CuentasTableAdapter.NombreCuenta(cargo.CódigoCuenta)
                        Línea.ImporteCargo = cargo.Importe

                        Me.BDContabilidadMelo.LíneasDiario.AddLíneasDiarioRow(Línea)

                    Next

                    For Each abono As Contabilidad.BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                        Dim Línea As Contabilidad.BDContabilidadGMELO.LíneasDiarioRow = Me.BDContabilidadMelo.LíneasDiario.NewLíneasDiarioRow

                        Línea.Número = asiento.Número
                        Línea.Fecha = asiento.Fecha
                        Línea.Justificante = asiento.Justificante
                        Línea.Operación = asiento.Operación

                        Línea.ApunteAbono = abono.NúmeroApunte
                        Línea.CuentaAbono = abono.CódigoCuenta
                        Línea.NombreCuentaAbono = CuentasTableAdapter.NombreCuenta(abono.CódigoCuenta)
                        Línea.ImporteAbono = abono.Importe

                        Me.BDContabilidadMelo.LíneasDiario.AddLíneasDiarioRow(Línea)

                    Next

                End If

            Next

        End With

        With Listado

            .NombreInforme = "Diario.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadMelo
            .Filtro = ""

            Listado.ShowDialog()

        End With

        Me.BDContabilidadMelo.LíneasDiario.RejectChanges()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub AsientosDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles AsientosDateTimePicker.ValueChanged

        Dim pos As Integer = Me.AsientosBindingSource.Find("Fecha", CType(sender, DateTimePicker).Value.ToShortDateString)
        Me.AsientosBindingSource.Position = pos

    End Sub

    Dim nonNumberEntered As Boolean

    ' Handle the KeyDown event to determine the type of character entered into the control.
    Private Sub BuscarNúmeroAsientoTextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles BuscarNúmeroAsientoTextBox.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode = Keys.Enter Then

            Dim pos As Integer = Me.AsientosBindingSource.Find("Número", CType(sender, ToolStripTextBox).Text)
            Me.AsientosBindingSource.Position = pos

        ElseIf e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
        'If shift key was pressed, it's not a number.
        If Control.ModifierKeys = Keys.Shift Then
            nonNumberEntered = True
        End If
    End Sub


    ' This event occurs after the KeyDown event and can be used 
    ' to prevent characters from entering the control.
    Private Sub BuscarNúmeroAsientoTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles BuscarNúmeroAsientoTextBox.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If

    End Sub

    ' Handle the KeyDown event to determine the type of character entered into the control.
    Dim Números As Integer() = {0}
    Dim índiceCorriente As Integer = 0
    Dim númeroIndices As Integer = 0
    Private Sub BuscarTextoTextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles BuscarTextoTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim criterio As String = "Operación Like '*" + CType(sender, ToolStripTextBox).Text + _
                "*' OR Justificante LIKE '*" + CType(sender, ToolStripTextBox).Text + "*'"

            Dim Válidos As BDContabilidadGMELO.AsientosRow() = CType(Me.BDContabilidadMelo.Asientos.Select(criterio, "Fecha"), BDContabilidadGMELO.AsientosRow())

            ReDim Números(1)
            Números(0) = 0
            índiceCorriente = 0
            For Each asto As BDContabilidadGMELO.AsientosRow In Válidos

                Números(índiceCorriente) = asto.Número
                índiceCorriente += 1
                ReDim Preserve Números(índiceCorriente)

            Next
            ReDim Preserve Números(índiceCorriente - 1)
            índiceCorriente = 0
            númeroIndices = Números.Length

            If númeroIndices > 0 Then

                Dim pos As Integer = Me.AsientosBindingSource.Find("Número", Números(índiceCorriente).ToString)
                Me.AsientosBindingSource.Position = pos

            End If

        End If

    End Sub

    Private Sub AnteriorToolStripButton_Click(sender As Object, e As EventArgs) Handles _
        AnteriorToolStripButton.Click, AnteriorImporteToolStripButton.Click

        If índiceCorriente > 0 Then

            índiceCorriente -= 1

        ElseIf índiceCorriente = 0 Then

            índiceCorriente = númeroIndices - 1

        End If
        Dim pos As Integer = Me.AsientosBindingSource.Find("Número", Números(índiceCorriente).ToString)
        Me.AsientosBindingSource.Position = pos

    End Sub

    Private Sub SiguienteToolStripButton_Click(sender As Object, e As EventArgs) Handles _
        SiguienteToolStripButton.Click, SiguienteImporteToolStripButton.Click

        If índiceCorriente < númeroIndices - 1 Then

            índiceCorriente += 1

        ElseIf índiceCorriente = númeroIndices - 1 Then

            índiceCorriente = 0

        End If
        Dim pos As Integer = Me.AsientosBindingSource.Find("Número", Números(índiceCorriente).ToString)
        Me.AsientosBindingSource.Position = pos

    End Sub

    ' Handle the KeyDown event to determine the type of character entered into the control.
    Private Sub BuscarImporteAsientoTextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles BuscarImporteAsientoTextBox.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode = Keys.Enter Then

            Dim criterio As String = "Debe = " + CType(sender, ToolStripTextBox).Text + _
                " OR Haber = " + CType(sender, ToolStripTextBox).Text
            criterio = Replace(criterio, ",", ".")

            Dim Válidos As BDContabilidadGMELO.AsientosRow() = CType(Me.BDContabilidadMelo.Asientos.Select(criterio, "Fecha"), BDContabilidadGMELO.AsientosRow())

            ReDim Números(1)
            Números(0) = 0
            índiceCorriente = 0
            For Each asto As BDContabilidadGMELO.AsientosRow In Válidos

                Números(índiceCorriente) = asto.Número
                índiceCorriente += 1
                ReDim Preserve Números(índiceCorriente)

            Next
            ReDim Preserve Números(índiceCorriente - 1)
            índiceCorriente = 0
            númeroIndices = Números.Length

            If númeroIndices > 0 Then

                Dim pos As Integer = Me.AsientosBindingSource.Find("Número", Números(índiceCorriente).ToString)
                Me.AsientosBindingSource.Position = pos

            End If

        ElseIf (e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9) AndAlso e.KeyCode <> Keys.Oemcomma Then
            ' Determine whether the keystroke is a number from the keypad.
            If (e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9) AndAlso e.KeyCode <> Keys.Oemcomma Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
        'If shift key was pressed, it's not a number.
        If Control.ModifierKeys = Keys.Shift Then
            nonNumberEntered = True
        End If

    End Sub
    ' This event occurs after the KeyDown event and can be used 
    ' to prevent characters from entering the control.
    Private Sub BuscarImporteAsientoTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles BuscarImporteAsientoTextBox.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If

    End Sub

    Private Sub AsientosDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles AsientosDataGridView.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            Me.OpcionesAsientosContextMenuStrip.Show(Me.AsientosDataGridView, Control.MousePosition)

        End If

    End Sub

    Private Sub AgregarAsiento_Click(sender As Object, e As EventArgs) Handles AgregarAsiento.Click
        '
        ' Elegir tipo de asiento
        '

        frmElegirTipoAsiento.ShowDialog(Me)
        If frmElegirTipoAsiento.DialogResult = DialogResult.OK Then

            Dim a As New frmAsientos(frmElegirTipoAsiento.TipoSeleccionado)
            a.ShowDialog(Me)
            If a.DialogResult = DialogResult.OK Then

                Exit Sub

            End If

        End If


        '
        ' Se trabaja en la Base de Datos con métodos directos. Se "desenganchan los binding"
        '
        CargosBindingSource.SuspendBinding()
        AbonosBindingSource.SuspendBinding()
        AsientosBindingSource.SuspendBinding()
        '
        ' Agregar asiento
        '
        Dim NúmeroAsiento As Integer = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
        Me.AsientosTableAdapter.Insert(NúmeroAsiento, Today, "*", "*")

        Dim CódigoCuenta As String = "570"
        '
        ' Agregar cargo
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, NúmeroAsiento, "C")
        Me.CargosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
        '
        ' Agregar abono
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, NúmeroAsiento, "A")
        Me.AbonosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
        '
        ' Vuelve a enganchar y recargar los binding
        '
        AsientosBindingSource.ResumeBinding()
        CargosBindingSource.ResumeBinding()
        AbonosBindingSource.ResumeBinding()
        '
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
        Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)
        Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
        '
        ' Se posiciona en el nuevo asiento
        '
        Dim p As Integer = Me.AsientosBindingSource.Find("Número", NúmeroAsiento)
        Me.AsientosBindingSource.Position = p

    End Sub

    Private Sub btnBorrarAsiento_Click(sender As Object, e As EventArgs) Handles btnBorrarAsiento.Click

        Dim p As Integer = CInt(CType(Me.AsientosBindingSource.Current, System.Data.DataRowView).Item("Número"))
        If p > -1 Then
            '
            ' Se trabaja en la Base de Datos con métodos directos. Se "desenganchan los binding"
            '
            CargosBindingSource.SuspendBinding()
            AbonosBindingSource.SuspendBinding()
            AsientosBindingSource.SuspendBinding()
            '
            ' Buscar el asiento
            '
            Dim ast As BDContabilidadGMELO.AsientosRow = Me.BDContabilidadMelo.Asientos.FindByNúmero(p)
            '
            ' Borrar los cargos del asiento
            '
            '
            ast.Delete()

            Me.AsientosTableAdapter.Update(Me.BDContabilidadMelo.Asientos)

            ' Vuelve a enganchar y recargar los binding
            AsientosBindingSource.ResumeBinding()
            CargosBindingSource.ResumeBinding()
            AbonosBindingSource.ResumeBinding()
            '
            Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
            Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)
            Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
            '
            ' Se posiciona en el asiento anterior
            '
            p = p - 1
            If p > 0 Then

                Me.AsientosBindingSource.Position = p

            End If

        Else

            CMódulo.MsgErrorCrítico("No se ha podido borrar el asiento correspondiente al Current del BindingSource.")

        End If

    End Sub

    Private Sub btnBorrarCargo_Click(sender As Object, e As EventArgs) Handles btnBorrarCargo.Click

        Dim pAsto As Integer = CInt(CType(Me.CargosBindingSource.Current, System.Data.DataRowView).Item("NúmeroAsiento"))
        Dim pApte As Integer = CInt(CType(Me.CargosBindingSource.Current, System.Data.DataRowView).Item("NúmeroApunte"))

        Dim r As BDContabilidadGMELO.CargosDataTable = New BDContabilidadGMELO.CargosDataTable
        Me.CargosTableAdapter.FindByNúmerosAsientoYApunte(r, pAsto, pApte)
        Try

            r.Rows(0).Delete()
            Me.CargosTableAdapter.Update(Me.BDContabilidadMelo)

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("No se ha podido borrar el cargo número " + pApte.ToString + " del asiento " + pAsto.ToString + " debido a " + ex.Message)

        End Try

    End Sub

    Private Sub btnBorrarAbono_Click(sender As Object, e As EventArgs) Handles btnBorrarAbono.Click

        Dim pAsto As Integer = CInt(CType(Me.AbonosBindingSource.Current, System.Data.DataRowView).Item("NúmeroAsiento"))
        Dim pApte As Integer = CInt(CType(Me.AbonosBindingSource.Current, System.Data.DataRowView).Item("NúmeroApunte"))

        Dim r As BDContabilidadGMELO.AbonosDataTable = New BDContabilidadGMELO.AbonosDataTable
        Me.AbonosTableAdapter.FindByNúmerosAsientoYApunte(r, pAsto, pApte)
        Try

            r.Rows(0).Delete()
            Me.AbonosTableAdapter.Update(Me.BDContabilidadMelo)

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("No se ha podido borrar el Abono número " + pApte.ToString + " del asiento " + pAsto.ToString + " debido a " + ex.Message)

        End Try

    End Sub


    Private Sub AgregarApunte_Click(sender As Object, e As EventArgs) Handles AgregarCargo.Click, AgregarAbono.Click

        Dim NúmeroAsiento As Integer = CInt(CType(Me.AsientosBindingSource.Current, System.Data.DataRowView).Item("Número"))
        Dim TipoApunte As String = "*"

        If CType(sender, System.Windows.Forms.ToolStripButton).Name = "AgregarCargo" Then
            TipoApunte = "C"
        ElseIf CType(sender, System.Windows.Forms.ToolStripButton).Name = "AgregarAbono" Then
            TipoApunte = "A"
        End If

        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, NúmeroAsiento, TipoApunte)

        Dim CódigoCuenta As String = "570"

        If CType(sender, System.Windows.Forms.ToolStripButton).Name = "AgregarCargo" Then

            Me.CargosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
            Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)

        ElseIf CType(sender, System.Windows.Forms.ToolStripButton).Name = "AgregarAbono" Then

            Me.AbonosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
            Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)

        End If

    End Sub

    Private Sub DuplicarAsientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarAsientoToolStripMenuItem.Click

        Dim p As Integer = CInt(CType(Me.AsientosBindingSource.Current, System.Data.DataRowView).Item("Número"))


        ' Se trabaja en la Base de Datos con métodos directos. Se "desenganchan los binding"
        CargosBindingSource.SuspendBinding()
        AbonosBindingSource.SuspendBinding()
        AsientosBindingSource.SuspendBinding()
        

        ' Buscar el asiento
        Dim Asiento As BDContabilidadGMELO.AsientosRow = Me.BDContabilidadMelo.Asientos.FindByNúmero(p)
        With Asiento

            Dim NúmeroAsiento As Integer = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)

            Me.AsientosTableAdapter.Insert(NúmeroAsiento, CDate(CDate(Today).ToShortDateString), Asiento.Justificante, Asiento.Operación)

            ' Recupera el asiento que se va a duplicar
            Asiento = Me.BDContabilidadMelo.Asientos.FindByNúmero(p)

            For Each apunte As DataRow In Asiento.GetAbonosRows

                Me.AbonosTableAdapter.Insert(NúmeroAsiento, CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

            Next

            For Each apunte As DataRow In Asiento.GetCargosRows

                Me.CargosTableAdapter.Insert(NúmeroAsiento, CInt(apunte("CódigoCuenta")), CInt(apunte("NúmeroApunte")), CDbl(apunte("Importe")))

            Next
            ' Vuelve a enganchar y recargar los binding
            AsientosBindingSource.ResumeBinding()
            CargosBindingSource.ResumeBinding()
            AbonosBindingSource.ResumeBinding()
            '
            Me.AsientosTableAdapter.Fill(Me.BDContabilidadMelo.Asientos)
            Me.CargosTableAdapter.Fill(Me.BDContabilidadMelo.Cargos)
            Me.AbonosTableAdapter.Fill(Me.BDContabilidadMelo.Abonos)
            '
            ' Se posiciona en el nuevo asiento
            '
            p = Me.AsientosBindingSource.Find("Número", NúmeroAsiento)
            Me.AsientosBindingSource.Position = p

        End With

    End Sub

End Class