Imports Biblioteca

Public Class frmCuentas

    Private VoyACerrar As Boolean = False

    Private Sub GruposBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Cuentas2SaveItem.Click
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.CuentasTableAdapter.Update(Me.BDContabilidadGMELO.Cuentas)

        If Me.BDContabilidadGMELO.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmGrupos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.CuentasBindingSource.EndEdit()
                Me.CuentasTableAdapter.Update(Me.BDContabilidadGMELO.Cuentas)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.BalanceSituaciónTableAdapter.Fill(Me.BDContabilidadGMELO.BalanceSituación)

        Me.PerdidasyGananciasSeccionesTableAdapter.Fill(Me.BDContabilidadGMELO.PerdidasyGananciasSecciones)

        Me.PérdidasyGananciasTableAdapter.Fill(Me.BDContabilidadGMELO.PérdidasyGanancias)

        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)

        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)

        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)

        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)

        Me.Cta2TableAdapter.Fill(Me.BDContabilidadGMELO.Cta2)

        Me.Cta1TableAdapter.Fill(Me.BDContabilidadGMELO.Cta1)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)

        Me.Text = My.Resources.Título + " - CUENTAS DE LA EMPRESA"

    End Sub

    Private Sub GruposDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

        MessageBox.Show("Error en el DataGridView " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
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
        If (e.Context =
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If


    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click

        Me.Close()

    End Sub

    Private Sub SumasYSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumasYSaldosToolStripMenuItem.Click

        Dim selecEjercicio As New frmSelecFechas
        selecEjercicio.Text = "BALANCE SUMAS Y SALDOS - Selección de Fechas"
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro del trimestre."
        selecEjercicio.tipoListado = CType(eTipoListadoContable.BalanceSumasSaldos, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = selecEjercicio.resul

            Dim Listado As New frmVisorInformes

            With Listado

                .NombreEmpresa = My.Resources.NombreEmpresa
                .NombreInforme = "Balance.rpt"
                .TipoOrigenDatos = eTipoOrigenDatos.ADO
                .ADODataSet = Me.BDContabilidadGMELO
                .Filtro = txtEjercicio
                .Tipo = eTipoListadoContable.Balance

                Listado.ShowDialog()

            End With

        End If

    End Sub

    Private Sub btnBalanceSituación_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalanceSituación.Click

        'CARGAR DATOS DE LA CUENTA DE BALANCE de SITUACIÓN
        Me.BalanceSituaciónTableAdapter.Fill(Me.BDContabilidadGMELO.BalanceSituación)

        Dim selecEjercicio As New frmSelecFechas
        selecEjercicio.Text = "BALANCE SITUACIÓN - Selección de Fechas"
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro ejercicio."
        selecEjercicio.tipoListado = CType(eTipoListadoContable.BalanceSituación, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = selecEjercicio.resul

            Dim Listado As New frmVisorInformes

            With Listado

                .NombreEmpresa = My.Resources.NombreEmpresa
                .NombreInforme = "rptBalanceSituación.rpt"
                .TipoOrigenDatos = eTipoOrigenDatos.ADO
                .ADODataSet = Me.BDContabilidadGMELO
                .Filtro = txtEjercicio

                Listado.ShowDialog()

            End With

        End If

    End Sub

    Private Sub SumasYSaldos3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumasYSaldos3ToolStripMenuItem.Click
        Dim selecEjercicio As New frmSelecFechas
        selecEjercicio.Text = "BALANCE SUMAS Y SALDOS - Selección de Fechas"
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro del trimestre."
        selecEjercicio.tipoListado = CType(eTipoListadoContable.BalanceSumasSaldos, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = selecEjercicio.resul

            Dim Listado As New frmVisorInformes

            With Listado

                .NombreEmpresa = My.Resources.NombreEmpresa
                .NombreInforme = "Balance3d.rpt"
                .TipoOrigenDatos = eTipoOrigenDatos.ADO
                .ADODataSet = Me.BDContabilidadGMELO
                .Filtro = txtEjercicio

                Listado.ShowDialog()

            End With

        End If

    End Sub

    Private Sub SumasYSaldos2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumasYSaldos2ToolStripMenuItem.Click

        Dim selecEjercicio As New frmSelecFechas
        selecEjercicio.Text = "BALANCE SUMAS Y SALDOS - Selección de Fechas"
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro del trimestre."
        selecEjercicio.tipoListado = CType(eTipoListadoContable.BalanceSumasSaldos, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = selecEjercicio.resul

            Dim Listado As New frmVisorInformes

            With Listado

                .NombreEmpresa = My.Resources.NombreEmpresa
                .NombreInforme = "Balance2d.rpt"
                .TipoOrigenDatos = eTipoOrigenDatos.ADO
                .ADODataSet = Me.BDContabilidadGMELO
                .Filtro = txtEjercicio

                Listado.ShowDialog()

            End With

        End If

    End Sub

    Private Sub LibroMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroMayorToolStripMenuItem.Click

        Dim selecCuentas As New frmSelecCuenta
        selecCuentas.Text = "LIBRO MAYOR - Selección de Cuenta"
        selecCuentas.Label1.Text = "Seleccione la cuenta cuyos movimientos quiere listar."
        selecCuentas.tipoListado = CType(eTipoListadoContable.Mayor, Contabilidad.TipoListado)

        selecCuentas.ShowDialog(Me)

        If selecCuentas.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim CodCta As Integer = selecCuentas.Cuenta
            Dim filtro As String = "CódigoCuenta = " + CodCta.ToString


            With Me.BDContabilidadGMELO

                Dim cargosCta As BDContabilidadGMELO.CargosRow() =
                    CType(Me.BDContabilidadGMELO.Cargos.Select(filtro, "NúmeroAsiento"), BDContabilidadGMELO.CargosRow())

                .LíneasMayor.Clear()

                For Each cargo As BDContabilidadGMELO.CargosRow In cargosCta

                    Dim asiento As BDContabilidadGMELO.AsientosRow = Me.BDContabilidadGMELO.Asientos.FindByNúmero(cargo.NúmeroAsiento)
                    Dim Línea As BDContabilidadGMELO.LíneasMayorRow = Me.BDContabilidadGMELO.LíneasMayor.NewLíneasMayorRow

                    Línea.CodCta = CodCta
                    Línea.NúmeroAsiento = cargo.NúmeroAsiento
                    Línea.Fecha = asiento.Fecha
                    Línea.NúmeroApunte = cargo.NúmeroApunte
                    Línea.Literal = asiento.Operación.TrimEnd + ". " + asiento.Justificante
                    Línea.ImpDebe = cargo.Importe
                    Línea.ImpHaber = 0

                    Me.BDContabilidadGMELO.LíneasMayor.AddLíneasMayorRow(Línea)
                    Me.BDContabilidadGMELO.LíneasMayor.AcceptChanges()

                Next

                Dim abonosCta As BDContabilidadGMELO.AbonosRow() =
                  CType(Me.BDContabilidadGMELO.Abonos.Select(filtro, "NúmeroAsiento"), BDContabilidadGMELO.AbonosRow())

                For Each abono As BDContabilidadGMELO.AbonosRow In abonosCta

                    Dim asiento As BDContabilidadGMELO.AsientosRow = Me.BDContabilidadGMELO.Asientos.FindByNúmero(abono.NúmeroAsiento)
                    Dim Línea As BDContabilidadGMELO.LíneasMayorRow = Me.BDContabilidadGMELO.LíneasMayor.NewLíneasMayorRow

                    Línea.CodCta = CodCta
                    Línea.NúmeroAsiento = abono.NúmeroAsiento
                    Línea.Fecha = asiento.Fecha
                    Línea.NúmeroApunte = abono.NúmeroApunte
                    Línea.Literal = asiento.Operación.TrimEnd + ". " + asiento.Justificante
                    Línea.ImpDebe = 0
                    Línea.ImpHaber = abono.Importe

                    Me.BDContabilidadGMELO.LíneasMayor.AddLíneasMayorRow(Línea)
                    Me.BDContabilidadGMELO.LíneasMayor.AcceptChanges()

                Next

                .LíneasMayor.Select("", "CodCta, NúmeroAsiento, NúmeroApunte")
                .LíneasMayor.AcceptChanges()

            End With


            Dim listado As New frmVisorInformes

            With listado

                .NombreEmpresa = My.Resources.NombreEmpresa
                .NombreInforme = "rptLibroMayor.rpt"
                .TipoOrigenDatos = eTipoOrigenDatos.ADO
                .ADODataSet = Me.BDContabilidadGMELO
                .Filtro = ""
                '.Tipo = eTipoListado.Todos

                listado.ShowDialog()

            End With

        End If

    End Sub

    Private Sub btnCtaPerdidasYGanancias_Click(sender As Object, e As EventArgs) Handles btnCtaPerdidasYGanancias.Click

        'CARGAR DATOS DE LA CUENTA DE PÉRDIDAS Y GANANCIAS
        Me.PérdidasyGananciasTableAdapter.Fill(Me.BDContabilidadGMELO.PérdidasyGanancias)
        Me.PerdidasyGananciasSeccionesTableAdapter.Fill(Me.BDContabilidadGMELO.PerdidasyGananciasSecciones)

        'FILTRAR APUNTES DEL EJERCICIO
        Dim txtEjercicio As String = ""

        Dim Listado As New frmVisorInformes

        With Listado

            .NombreEmpresa = My.Resources.NombreEmpresa
            .NombreInforme = "rptPérdidasYGanancias.rpt"
            '.NombreInforme = "rptCrystalReport1.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = "Ejercicio Actual"

            Listado.ShowDialog()

        End With

    End Sub

    ''' <summary>
    ''' Crea una cuenta del grupo de la cuenta maestra en la que han hecho doble click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasMaestrasDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CuentasMaestrasDataGridView.RowHeaderMouseDoubleClick

        Dim filtro As String = "CódigoCuentaMaestra = " +
           Me.CuentasMaestrasDataGridView.CurrentRow.Cells(0).Value.ToString
        Dim FamiliaCuentas() As BDContabilidadGMELO.CuentasRow =
            CType(Me.BDContabilidadGMELO.Cuentas.Select(filtro, "Código"), BDContabilidadGMELO.CuentasRow())
        Dim Nueva As New frmNuevaCuenta(My.Settings.BDContabilidadConnectionString, CType(Me.CuentasMaestrasDataGridView.CurrentRow.Cells(0).Value, Integer))
        Nueva.Show(Me)

    End Sub
    ''' <summary>
    ''' pinta el simbolo de crear una cuenta en las filas de las cuentas maestras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasMaestrasDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles CuentasMaestrasDataGridView.RowPostPaint
        'Convert the image to icon, in order to load it in the row header column
        Dim myBitmap As Bitmap = New Bitmap(My.Resources.add)
        myBitmap.MakeTransparent(Color.Magenta)
        Dim myIcon As Icon = Icon.FromHandle(myBitmap.GetHicon())

        Dim gráfico As Graphics = e.Graphics

        'Set Image dimension - User's choice
        Dim iconHeight As UInteger = 14
        Dim iconWidth As UInteger = 14

        'Set x/y position - As the center of the RowHeaderCell
        Dim xPosition As UInteger = CUInt(e.RowBounds.X + (Me.CuentasMaestrasDataGridView.RowHeadersWidth / 2))
        Dim yPosition As UInteger = CUInt(e.RowBounds.Y +
        ((Me.CuentasMaestrasDataGridView.Rows(e.RowIndex).Height - iconHeight) / 2))

        Dim rectangle As Rectangle = New Rectangle(CInt(xPosition), CInt(yPosition), CInt(iconWidth), CInt(iconHeight))

        gráfico.DrawIcon(myIcon, rectangle)

    End Sub

    ''' <summary>
    ''' borra la cuenta en la que han hecho doble click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CuentasDataGridView.RowHeaderMouseDoubleClick

        Dim resp As MsgBoxResult = CMódulo.MsgPregunta("Necesitará facilitar su código de autorización para borrar cuentas. ¿Quiere continuar?")

        If resp = MsgBoxResult.Yes Then

            CMódulo.MsgInformativo("Se pide el código, se comprueba y se borra o no")

        End If

    End Sub

    ''' <summary>
    ''' pinta el simbolo de borrar cuenta en las filas de las cuentas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles CuentasDataGridView.RowPostPaint
        'Convert the image to icon, in order to load it in the row header column
        Dim myBitmap As Bitmap = New Bitmap(My.Resources.cross)
        Dim myIcon As Icon = Icon.FromHandle(myBitmap.GetHicon())

        Dim gráfico As Graphics = e.Graphics

        'Set Image dimension - User's choice
        Dim iconHeight As UInteger = 14
        Dim iconWidth As UInteger = 14

        'Set x/y position - As the center of the RowHeaderCell
        Dim xPosition As UInteger = CUInt(e.RowBounds.X + (Me.CuentasDataGridView.RowHeadersWidth / 2))
        Dim yPosition As UInteger = CUInt(e.RowBounds.Y +
        ((Me.CuentasDataGridView.Rows(e.RowIndex).Height - iconHeight) / 2))

        Dim rectangle As Rectangle = New Rectangle(CInt(xPosition), CInt(yPosition), CInt(iconWidth), CInt(iconHeight))

        gráfico.DrawIcon(myIcon, rectangle)

    End Sub

End Class
