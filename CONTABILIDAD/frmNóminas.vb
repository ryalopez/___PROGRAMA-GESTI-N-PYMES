Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports Biblioteca

Public Class frmNóminas

    Private VoyACerrar As Boolean = False

    Private Sub frmNóminas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.NóminasBindingSource.EndEdit()
                Me.NóminasTableAdapter.Update(Me.BDContabilidadGMELO.Nóminas)

                'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EmpleadosTableAdapter.Fill(Me.BDContabilidadGMELO.Empleados)

        Me.NóminasTableAdapter.Fill(Me.BDContabilidadGMELO.Nóminas)

        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)

        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)

        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)

        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)

        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

        Me.Text = My.Resources.Título + " - Gestión de Nóminas"


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub NóminasDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles NóminasDataGridView.DataError

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

    End Sub

    Private Sub NóminasDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles NóminasDataGridView.RowValidating

        Dim row As DataGridViewRow = Me.NóminasDataGridView.Rows(e.RowIndex)
        Dim celdaFechaPago As DataGridViewCell = row.Cells(1)
        Dim celdaEmpleado As DataGridViewCell = row.Cells(2)
        Dim celdaBruto As DataGridViewCell = row.Cells(3)
        Dim celdaTipoIRPF As DataGridViewCell = row.Cells(4)
        Dim celdaCuotaIRPF As DataGridViewCell = row.Cells(5)
        Dim celdaSegSocialEmpleado As DataGridViewCell = row.Cells(6)
        Dim celdaSegSocialEmpresa As DataGridViewCell = row.Cells(7)
        Dim celdaNeto As DataGridViewCell = row.Cells(8)

        If celdaFechaPago.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna FECHA de PAGO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaEmpleado.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna EMPLEADO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaBruto.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna BRUTO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaTipoIRPF.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna TIPO IRPF: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaCuotaIRPF.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna CUOTA IRPF: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaSegSocialEmpleado.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna CUOTA SEGURIDAD SOCIAL del EMPLEADO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaSegSocialEmpresa.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna CUOTA SEGURIDAD SOCIAL de la EMPRESA: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaNeto.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna NETO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If

    End Sub

    Private Sub FacturasEmitidasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasEmitidasBindingNavigatorSaveItem.Click

        If Me.Validate() Then

            Me.NóminasBindingSource.EndEdit()
            Me.NóminasTableAdapter.Update(Me.BDContabilidadGMELO.Nóminas)

            'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub


    ''' <summary>
    ''' Contabilizar Los recibos salariales emitidos que aún no lo están
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Se genera un asiento
    ''' 640CCC Sueldos    
    ''' 642 Seguridad Social Cargo Empresa  ->  Seg. Social Acreedora               476 (Cuota Patronal)
    '''                                         Seg. Social Acreedora               476 (Cuota Obrera)
    '''                                         Hacienda Retenciones practicadas    4751
    '''                                         Remuneraciones ptes. pago Empleado  465CCC
    ''' </remarks>
    Private Sub ContabilizarStripButton_Click(sender As Object, e As EventArgs) Handles ContabilizarStripButton.Click

        Me.Cursor = Cursors.WaitCursor

        ' Selecciona las nóminas emitidas que están sin contabilizar
        ' Se genera asiento
        '
        If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, 4751) Then

            If Me.CrearCuenta(4751) Then

                'MsgBox("Creada la cuenta 477")

            End If

        End If
        If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, 476) Then

            If Me.CrearCuenta(476) Then

                'MsgBox("Creada la cuenta 477")

            End If

        End If
        For Each nómina As BDContabilidadGMELO.NóminasRow In Me.NóminasTableAdapter.NóminasSinContabilizarSinBloquear
            'Generar cuentas del cliente si no existen

            Dim emp As BDContabilidadGMELO.EmpleadosRow = Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado)
            Dim NumCtaCli As Integer = CInt(emp.CuentaGastoEmpleado)
            If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                If Me.CrearCuenta(NumCtaCli, nómina.idEmpleado) Then

                    MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                End If

            End If
            NumCtaCli = CInt(emp.CuentaBalanceEmpleado)
            If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                If Me.CrearCuenta(NumCtaCli, nómina.idEmpleado) Then

                    MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                End If

            End If
            NumCtaCli = CInt(emp.CuentaSegSocCargoEmpresaEmpleado)
            If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                If Me.CrearCuenta(NumCtaCli, nómina.idEmpleado) Then

                    MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                End If

            End If
            ''Buscar el asiento con justificante (ABONO HABERES. CLIENTE. MES/AAAA)
            Dim Justificante As String = "ABONO HABERES. de " + nómina.FechaNómina.ToShortDateString + " de " + Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado).NomyApe
            Dim asiento As BDContabilidadGMELO.AsientosRow

            If Not CMódulo.ExisteAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante) Then
                asiento = BDContabilidadGMELO.Asientos.NewAsientosRow
                With asiento

                    .Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
                    .Fecha = nómina.FechaNómina
                    .Justificante = Justificante
                    .Operación = "Abono haberes de " + Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado).NomyApe

                End With

                Me.BDContabilidadGMELO.Asientos.AddAsientosRow(asiento)

            Else
                ' RECUPERAR EL ASIENTO
                Dim idAsiento As Integer = CMódulo.IdAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante)
                asiento = BDContabilidadGMELO.Asientos.FindByNúmero(idAsiento)
                ' se comprueba que realmente IdAsientoConJustificante(Justificante) ha funcionado OK
                If asiento IsNot Nothing Then

                    With asiento

                        .Fecha = nómina.FechaNómina
                        .Justificante = Justificante
                        .Operación = "Abono haberes de " + nómina.NombreEmpleado + ". "

                    End With
                Else

                    Throw New Exception("Contabilizando nóminas, no se ha podido recuperar el asiento con el número " + _
                                        idAsiento.ToString + " proporcionado por el procedimiento almacenado " + _
                                        """IdAsientoConJustificante(""" + Justificante.Trim + """) de la Base de Datos." + _
                                        "Se cancelará el proceso.")

                    Exit Sub

                End If

            End If
            Me.AsientosTableAdapter.Update(Me.BDContabilidadGMELO.Asientos)
            For Each c As BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                c.Delete()

            Next
            Dim cargo As BDContabilidadGMELO.CargosRow = Me.BDContabilidadGMELO.Cargos.NewCargosRow
            With cargo

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = CInt(emp.CuentaGastoEmpleado)
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "C")
                .Importe = nómina.Bruto

            End With
            Me.BDContabilidadGMELO.Cargos.AddCargosRow(cargo)
            cargo = Me.BDContabilidadGMELO.Cargos.NewCargosRow
            With cargo

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = CInt(emp.CuentaSegSocCargoEmpresaEmpleado)
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "C")
                .Importe = nómina.SegSocialEmpresa

            End With
            Me.BDContabilidadGMELO.Cargos.AddCargosRow(cargo)
            Me.CargosTableAdapter.Update(Me.BDContabilidadGMELO.Cargos)

            For Each a As BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                a.Delete()

            Next
            Dim abono As BDContabilidadGMELO.AbonosRow = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
            With abono

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = 476
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                .Importe = nómina.SegSocialEmpresa + nómina.SegSocEmpleado

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            abono = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
            With abono

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = 4751
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                .Importe = nómina.CuotaIRPF

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            abono = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
            With abono

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = CInt(emp.CuentaBalanceEmpleado)
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                .Importe = nómina.Neto

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            Me.AbonosTableAdapter.Update(Me.BDContabilidadGMELO.Abonos)

            CMódulo.MarcarContabilizado(My.Settings.BDContabilidadConnectionString, nómina.id, "N")

        Next

        Me.NóminasTableAdapter.Fill(Me.BDContabilidadGMELO.Nóminas)

        Me.Cursor = Cursors.Default

        MsgBox("Se han contabilizado las Nóminas pendientes de hacerlo.", MsgBoxStyle.OkOnly, My.Resources.Título)

    End Sub

    Function CrearCuenta(cta As Integer, Optional idEmpleado As Integer = 0) As Boolean

        Dim scta As String = cta.ToString
        Dim cuenta As BDContabilidadGMELO.CuentasRow = BDContabilidadGMELO.Cuentas.NewCuentasRow()
        ' cuenta de 3 dígitos. Copiar una cuenta maestra
        If scta.Length = 3 Then

            Dim maestra As BDContabilidadGMELO.CuentasMaestrasRow = _
                Me.BDContabilidadGMELO.CuentasMaestras.FindByCódigo(cta)
            With cuenta

                .Código = cta
                .CódigoCuentaMaestra = maestra.Código
                .Nombre = maestra.Nombre

            End With

        Else

            Dim ctaM As Integer
            ' existe una cuenta maestra de más de 3 dígitos
            If CuentasMaestrasTableAdapter.ExisteCuentaMaestra(CInt(scta)) > 0 Then
                ctaM = CInt(scta)
            Else
                ctaM = CInt(scta.Substring(0, 3))
            End If

            Dim maestra As BDContabilidadGMELO.CuentasMaestrasRow = _
               Me.BDContabilidadGMELO.CuentasMaestras.FindByCódigo(ctaM)
            Dim empleado As BDContabilidadGMELO.EmpleadosRow = _
                Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(idEmpleado)

            With cuenta

                .Código = cta
                .CódigoCuentaMaestra = maestra.Código
                .Nombre = maestra.Nombre
                If Not empleado Is Nothing Then
                    .Nombre = maestra.Nombre + ". " + empleado.NomyApe
                End If
            End With

        End If
        If CType(Me.CuentasTableAdapter.EsCuentaBalance(cuenta.Código), Integer) = 1 Then
            ' LAS CUENTAS 465
            cuenta.idBalanceResultados = 52
            cuenta.idPerdidasyGanancias = 0
        Else
            ' LAS CUENTAS DE PAGO DE NÓMINA DE CADA EMPLEADO 640nnn y de SEGURIDAD SOCIAL a cargo de la Empresa 642nnn
            cuenta.idBalanceResultados = 0
            cuenta.idPerdidasyGanancias = 6
        End If


        Me.BDContabilidadGMELO.Cuentas.AddCuentasRow(cuenta)

        Me.CuentasTableAdapter.Update(BDContabilidadGMELO.Cuentas)
        Me.CuentasBindingSource.ResetBindings(False)

        Return True

    End Function

    Private Sub btnListarFacturasEmitidas_Click(sender As Object, e As EventArgs) Handles btnListarNóminas.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptNóminas.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnGenerarResumenExcel_Click(sender As Object, e As EventArgs) Handles btnGenerarResumenExcel.Click
        Dim msg As String = "Se va a generar una hoja de Excel con un resumen de nóminas, " & _
    "para las fechas que indique. " & vbCrLf & _
    "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' leer fechas
        '
        Dim PedirFecha As New frmPedirFecha
        PedirFecha.VariosDíasCheckBox.Visible = False
        PedirFecha.Label1.Text = "Desde el mes "
        PedirFecha.Label2.Text = "Hasta el mes "
        PedirFecha.Label2.Visible = True
        PedirFecha.FechaFinalDateTimePicker.Visible = True
        PedirFecha.ShowDialog()
        If PedirFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel Then

            Exit Sub

        End If

        PedirFecha.Hide()
        PedirFecha.Dispose()
        Me.Refresh()

        Dim FechaInicialFactura As DateTime = PedirFecha.FechaDateTimePicker.Value
        Dim FechaFinalFactura As DateTime = PedirFecha.FechaFinalDateTimePicker.Value
        If FechaFinalFactura < FechaInicialFactura Then

            FechaFinalFactura = FechaInicialFactura

        End If
        Dim AñoAnterior As Integer = FechaInicialFactura.Year
        Dim MesAnterior As Integer = FechaInicialFactura.Month - 1
        If MesAnterior = 0 Then
            MesAnterior = 12
            AñoAnterior -= 1
        End If
        If FechaInicialFactura.Month = 2 Then

            FechaInicialFactura = CDate("28/" + FechaInicialFactura.Month.ToString + "/" + FechaInicialFactura.Year.ToString)

        Else

            FechaInicialFactura = CDate("30/" + FechaInicialFactura.Month.ToString + "/" + FechaInicialFactura.Year.ToString)

        End If

        AñoAnterior = FechaFinalFactura.Year
        MesAnterior = FechaFinalFactura.Month - 1
        If MesAnterior = 0 Then
            MesAnterior = 12
            AñoAnterior -= 1
        End If
        If FechaFinalFactura.Month = 2 Then

            FechaFinalFactura = CDate("28/" + FechaFinalFactura.Month.ToString + "/" + FechaFinalFactura.Year.ToString)

        Else

            FechaFinalFactura = CDate("30/" + FechaFinalFactura.Month.ToString + "/" + FechaFinalFactura.Year.ToString)

        End If

        MsgBox("desde " + FechaInicialFactura.ToShortDateString + " hasta " + FechaFinalFactura.ToShortDateString)

        ' 
        ' Crear Hoja Resumen
        '

        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        'Dim oHoja As Excel.Worksheet

        'Start Excel and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        oExcel.Visible = True
        oLibro = oExcel.Workbooks.Add()
        oExcel.Range("A1").Value = "EMPLEADO"
        oExcel.Range("B1").Value = "FECHA NÓMINA"
        oExcel.Range("C1").Value = "BRUTO"
        oExcel.Range("D1").Value = "TIPO IRPF"
        oExcel.Range("E1").Value = "CUOTA IRPF"
        oExcel.Range("F1").Value = "SEG.SOC. EMPLEADO"
        oExcel.Range("G1").Value = "SEG.SOC. EMPRESA"
        oExcel.Range("H1").Value = "NETO"
        oExcel.Range("I1").Value = "FECHA PAGO"
        oExcel.Range("J1").Value = "BANCO PAGO"
        oExcel.Range("A2").Select()

        ' contador de filas del resumen
        For Each r As BDContabilidadGMELO.EmpleadosRow In EmpleadosTableAdapter.GetData

            Dim criterio As String = "idEmpleado = " + r.idEmpleado.ToString + " and FechaNómina <= #" + _
                FechaFinalFactura.Month.ToString + "/" + FechaFinalFactura.Day.ToString + "/" + _
                FechaFinalFactura.Year.ToString + "# And FechaNómina >= #" + _
                FechaInicialFactura.Month.ToString + "/" + FechaInicialFactura.Day.ToString + "/" + _
                FechaInicialFactura.Year.ToString + "#"

            Dim nominas As BDContabilidadGMELO.NóminasRow() = CType(BDContabilidadGMELO.Nóminas.Select(criterio), Contabilidad.BDContabilidadGMELO.NóminasRow())

            For Each f As BDContabilidadGMELO.NóminasRow In nominas

                ' contador de columnas para la nómina
                Dim nCol As Integer = 0

                If f.FechaNómina <= FechaFinalFactura And f.FechaNómina >= FechaInicialFactura Then

                    With f

                        Dim empleado As BDContabilidadGMELO.EmpleadosRow = Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(r.idEmpleado)
                        ' la rutina mete por delante " ."
                        Dim NomEmpleado As String = empleado.NomyApe
                        ' Escribe el nombre del cliente en la orimera celda de la fila
                        oExcel.ActiveCell.Value = NomEmpleado
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.FechaNómina
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.Bruto
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.TipoIRPF
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.CuotaIRPF
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.SegSocEmpleado
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.SegSocialEmpresa
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.Neto
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        Try

                            oExcel.ActiveCell.Offset(0, nCol).Value = f.FechaPago

                        Catch ex As Exception

                            oExcel.ActiveCell.Offset(0, nCol).Value = ""

                        End Try
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        Dim NomBanco As String
                        Try

                            Dim banco As BDContabilidadGMELO.CuentasBancariasRow = Me.BDContabilidadGMELO.CuentasBancarias.FindByid(.idCtaBancaria)
                            ' la rutina mete por delante " ."
                            NomBanco = banco.Banco

                        Catch ex As Exception

                            NomBanco = ""

                        End Try
                        oExcel.ActiveCell.Offset(0, nCol).Value = NomBanco

                    End With

                End If
                ' Cuando cambia de nómina salta a la primera celda de la fila siguiente
                oExcel.ActiveCell.Offset(1, 0).Select()

            Next

        Next

        Dim NomFicheroExcel As String = Application.StartupPath & "\FACTURAS CLIENTES\ResumenNóminas" + _
           FechaInicialFactura.Year.ToString + DateAndTime.MonthName(FechaInicialFactura.Month) + "_" + _
           FechaFinalFactura.Year.ToString + DateAndTime.MonthName(FechaFinalFactura.Month) + _
           ".xls"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")
        oExcel.ActiveWorkbook.SaveAs(NomFicheroExcel)
        oExcel.ActiveWorkbook.Close()

        CMódulo.MsgInformativo("Se ha terminado la generación del resumen de nóminas. Puede recogerlas en " +
                              Application.StartupPath + "\FACTURAS CLIENTES\")

    End Sub

    ''' <summary>
    ''' Contabilizar Pago de las nóminas que aún no están contabilizadas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Se genera un asiento
    ''' Cuenta Cliente   465CCC   -> Cuenta Banco  572BBB</remarks>
    Private Sub PagarStripButton_Click(sender As Object, e As EventArgs) Handles PagarStripButton.Click

        Me.Cursor = Cursors.WaitCursor

        ' Selecciona las nóminas que no estén bloqueadas, estén marcadas como pagadas y tengan Banco y Fecha
        ' de pago no nula
        ' Se genera asiento
        '
        For Each nómina As BDContabilidadGMELO.NóminasRow In Me.NóminasTableAdapter.NóminasContabilizadasSinPagarSinBloquear

            If Not IsDBNull(nómina.idCtaBancaria) AndAlso Not IsDBNull(nómina.FechaPago) Then

                'Cuenta del empleado
                Dim emp As BDContabilidadGMELO.EmpleadosRow = Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado)
                Dim NumCtaCli As Integer = CInt(emp.CuentaGastoEmpleado)
                If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                    If Me.CrearCuenta(NumCtaCli, nómina.idEmpleado) Then

                        MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                    End If

                End If
                NumCtaCli = CInt(emp.CuentaBalanceEmpleado)
                If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                    If Me.CrearCuenta(NumCtaCli, nómina.idEmpleado) Then

                        MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                    End If

                End If


                'Cuenta del banco
                Dim s As String
                s = nómina.idCtaBancaria.ToString
                While s.Length < 3

                    s = "0" + s

                End While
                Dim NumCtaBan As Integer
                If nómina.idCtaBancaria.ToString.Length < 3 Then
                    NumCtaBan = CInt("572" + s)
                Else
                    'Caja
                    NumCtaBan = CInt("570000")
                End If


                ''Buscar el asiento con justificante (PAGO NÓMINA. EMPLEADO. MES/AAAA)
                Dim Justificante As String = "PAGO NÓMINA de " + nómina.FechaNómina.ToShortDateString + " de " + _
                    Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado).NomyApe

                Dim asiento As BDContabilidadGMELO.AsientosRow
                If Not CMódulo.ExisteAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante) Then
                    '    ' NO EXISTE EL ASIENTO

                    asiento = BDContabilidadGMELO.Asientos.NewAsientosRow
                    With asiento

                        .Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
                        .Fecha = nómina.FechaPago
                        .Justificante = Justificante
                        .Operación = "Pago Nómina de " + Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado).NomyApe + ". "

                    End With

                    Me.BDContabilidadGMELO.Asientos.AddAsientosRow(asiento)

                Else
                    ' RECUPERAR EL ASIENTO
                    Dim idAsiento As Integer = CMódulo.IdAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante)
                    asiento = BDContabilidadGMELO.Asientos.FindByNúmero(idAsiento)
                    ' se comprueba que realmente IdAsientoConJustificante(Justificante) ha funcionado OK
                    If asiento IsNot Nothing Then

                        With asiento

                            .Fecha = nómina.FechaPago
                            .Justificante = Justificante
                            .Operación = "Abono haberes " + Me.BDContabilidadGMELO.Empleados.FindByidEmpleado(nómina.idEmpleado).NomyApe + ". "

                        End With

                    Else

                        Throw New Exception("Contabilizando pago de nóminas, no se ha podido recuperar el asiento con el número " + _
                                            idAsiento.ToString + " proporcionado por el procedimiento almacenado " + _
                                            """IdAsientoConJustificante(""" + Justificante.Trim + """) de la Base de Datos." + _
                                            "Se cancelará el proceso.")

                        Exit Sub

                    End If

                End If
                Me.AsientosTableAdapter.Update(Me.BDContabilidadGMELO.Asientos)
                If nómina.idCtaBancaria <> 3 Then

                    ' cargos
                    For Each c As BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                        c.Delete()

                    Next
                    Dim cargo As BDContabilidadGMELO.CargosRow = Me.BDContabilidadGMELO.Cargos.NewCargosRow
                    With cargo

                        .NúmeroAsiento = asiento.Número
                        .CódigoCuenta = CInt(emp.CuentaBalanceEmpleado)
                        .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "C")
                        .Importe = nómina.Neto

                    End With
                    Me.BDContabilidadGMELO.Cargos.AddCargosRow(cargo)
                    Me.CargosTableAdapter.Update(Me.BDContabilidadGMELO.Cargos)

                    'abonos
                    For Each a As BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                        a.Delete()

                    Next
                    Dim abono As BDContabilidadGMELO.AbonosRow = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
                    With abono

                        .NúmeroAsiento = asiento.Número
                        .CódigoCuenta = NumCtaBan
                        .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                        .Importe = nómina.Neto

                    End With
                    Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
                    Me.AbonosTableAdapter.Update(Me.BDContabilidadGMELO.Abonos)

                Else
                    ' CAJA
                    ' cargos
                    For Each c As BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                        c.Delete()

                    Next
                    Dim cargo As BDContabilidadGMELO.CargosRow = Me.BDContabilidadGMELO.Cargos.NewCargosRow
                    With cargo

                        .NúmeroAsiento = asiento.Número
                        .CódigoCuenta = CInt(emp.CuentaBalanceEmpleado)
                        .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "C")
                        .Importe = nómina.Neto

                    End With
                    Me.BDContabilidadGMELO.Cargos.AddCargosRow(cargo)
                    Me.CargosTableAdapter.Update(Me.BDContabilidadGMELO.Cargos)

                    'abonos
                    For Each a As BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                        a.Delete()

                    Next
                    Dim abono As BDContabilidadGMELO.AbonosRow = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
                    With abono

                        .NúmeroAsiento = asiento.Número
                        .CódigoCuenta = 570
                        .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                        .Importe = nómina.Neto

                    End With
                    Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
                    Me.AbonosTableAdapter.Update(Me.BDContabilidadGMELO.Abonos)


                End If

                CMódulo.MarcarPagado(My.Settings.BDContabilidadConnectionString, nómina.id, "N")

            End If

        Next

        Me.NóminasTableAdapter.Fill(Me.BDContabilidadGMELO.Nóminas)

        Me.Cursor = Cursors.Default

        MsgBox("Se han pagado las Nóminas pendientes de hacerlo.", MsgBoxStyle.OkOnly, My.Resources.Título)

    End Sub
End Class