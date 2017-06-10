Imports System.Text.RegularExpressions
Imports Microsoft.Reporting.WinForms
Imports Excel = Microsoft.Office.Interop.Excel
Imports Biblioteca


Public Class frmAnalítica

    Private VoyACerrar As Boolean = False

    Private Sub frmAnalítica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO_2016DataSet.ResumenGastos' Puede moverla o quitarla según sea necesario.
        Me.ResumenGastosTableAdapter.Fill(Me.BDContabilidadGMELO_2016DataSet.ResumenGastos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.BDContabilidadGMELO.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Nóminas' Puede moverla o quitarla según sea necesario.
        Me.NóminasTableAdapter.Fill(Me.BDContabilidadGMELO.Nóminas)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasBancarias' Puede moverla o quitarla según sea necesario.
        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Abonos' Puede moverla o quitarla según sea necesario.
        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cargos' Puede moverla o quitarla según sea necesario.
        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Asientos' Puede moverla o quitarla según sea necesario.
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasMaestras' Puede moverla o quitarla según sea necesario.
        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

        Me.Text = My.Resources.Título + " - Contabilidad de Costes"

        Dim cuenta As String = ""
        Dim mes As Integer = 0
        Dim importeMes As Double = 0
        For Each cta As BDContabilidadGMELO.CuentasRow In Me.BDContabilidadGMELO.Cuentas

            Cursor = Cursors.WaitCursor

            CMódulo.ActualizarDatosCuenta(My.Settings.BDContabilidadGMELO_2015ConnectionString, cta.Código)
            'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO_2016DataSet.ResumenCuenta' Puede moverla o quitarla según sea necesario.
            Me.ResumenCuentaTableAdapter.Fill(Me.BDContabilidadGMELO_2016DataSet.ResumenCuenta)

            If cta.EsGasto = 1 Then

                For Each gasto As BDContabilidadGMELO_2016DataSet.ResumenCuentaRow In Me.BDContabilidadGMELO_2016DataSet.ResumenCuenta

                    If gasto.Cuenta.ToString <> cuenta Then

                        cuenta = gasto.Cuenta.ToString
                        Chart2.Series.Add(cuenta)
                        ' Me.Chart1.Titles(0).Text = "Evolución de las cuentas de gasto en 2016"
                        Chart2.Series(cuenta).ChartType = DataVisualization.Charting.SeriesChartType.Line
                        'Chart1.ChartAreas(0).AxisY.Maximum = 2000
                        Chart2.ChartAreas(0).AxisX.Minimum = 1
                        Chart2.ChartAreas(0).AxisX.Maximum = 12

                    End If

                    With Chart2.Series(cuenta)

                        If mes <> gasto.Mes Then

                            If mes <> 0 Then

                                .Points.AddXY(mes, importeMes)

                            End If

                            mes = gasto.Mes
                            importeMes = gasto.Saldo

                        Else

                            importeMes += gasto.Saldo

                        End If

                        'Select Case gasto.Mes
                        '    Case 1
                        '        .Points.AddXY("Enero", gasto.Importe)
                        '        Exit Select
                        '    Case 2
                        '        .Points.AddXY("Febrero", gasto.Importe)
                        '        Exit Select
                        '    Case Else
                        '        .Points.AddXY("Otro", gasto.Importe)

                        'End Select

                    End With

                Next
                Chart2.Series(cuenta).Points.AddXY(mes, importeMes)

            End If

        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

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

    Public Sub btnGenerarResumenExcel_Click(sender As Object, e As EventArgs) Handles btnGenerarResumenExcel.Click
        Dim msg As String = "Se va a generar una hoja de Excel que usa los datos de la contabilidad, " & _
    "para obtener la contabilidad analítica. " & vbCrLf & _
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
        PedirFecha.FechaFinalDateTimePicker.Visible = False
        PedirFecha.Label2.Visible = False

        PedirFecha.ShowDialog()
        If PedirFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel Then

            Exit Sub

        End If

        PedirFecha.Hide()
        PedirFecha.Refresh()

        Dim FechaInicialFactura As DateTime = PedirFecha.FechaDateTimePicker.Value
        '
        ' Generar una Hoja de Cálculo para la fecha
        '
        Dim NomFicheroOriginal As String = Application.StartupPath & "\ANALÍTICA\COSTES_ORIGINAL.xlsm"
        Dim NomFicheroExcel As String = Application.StartupPath & "\ANALÍTICA\Costes" + _
          FechaInicialFactura.Year.ToString + FechaInicialFactura.Month.ToString("D2") + _
          FechaInicialFactura.Day.ToString("D2") + _
          ".xlsm"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")
        Dim sobreEscribir As Boolean = False
        While True

            Try

                My.Computer.FileSystem.CopyFile(NomFicheroOriginal, NomFicheroExcel, sobreEscribir)
                Exit While

            Catch yaExiste As System.IO.IOException

                If CMódulo.MsgPregunta("El fichero " + NomFicheroExcel + " ya existe. ¿Quiere sobreescribirlo?") = MsgBoxResult.Yes Then

                    sobreEscribir = True
                    Exit Try

                Else

                    PedirFecha.FechaFinalDateTimePicker.Visible = False
                    PedirFecha.Label2.Visible = False
                    PedirFecha.ShowDialog()
                    If PedirFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel Then

                        Exit Sub

                    End If

                    PedirFecha.Hide()
                    PedirFecha.Refresh()

                    FechaInicialFactura = PedirFecha.FechaDateTimePicker.Value
                    '
                    ' Generar una Hoja de Cálculo para la fecha
                    '                    
                    NomFicheroExcel = Application.StartupPath & "\ANALÍTICA\Costes" + _
                      FechaInicialFactura.Year.ToString + FechaInicialFactura.Month.ToString("D2") + _
                      FechaInicialFactura.Day.ToString("D2") + _
                      ".xlsm"
                    NomFicheroExcel = NomFicheroExcel.Replace("/", " ")

                    Exit Try

                End If

            Catch ex As Exception

            End Try

        End While

        PedirFecha.Dispose()
        Me.Refresh()
        ' 
        ' Crear Hoja Resumen
        '
        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet

        'Start Excel and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        oExcel.Visible = True
        oLibro = oExcel.Workbooks.Open(NomFicheroExcel)
        oHoja = CType(oLibro.Worksheets.Item("Terceros"), Excel.Worksheet)
        oHoja.Select()
        oHoja.Range("A2").Select()

        For Each r As BDContabilidadGMELO.ClientesRow In Me.BDContabilidadGMELO.Clientes.Select("", "NomyApes")

            Dim ncol As Integer = 0

            oExcel.ActiveCell.Value = r.NomyApes
            ncol += 1
            oExcel.ActiveCell.Offset(0, ncol).Value = "Cliente"
            ncol += 1
            oExcel.ActiveCell.Offset(0, ncol).Value = r.DocumentoIdentidad


            ' Cuando cambia de cliente salta a la primera celda de la fila siguiente
            oExcel.ActiveCell.Offset(1, 0).Select()
        Next

        Exit Sub

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
                               FechaInicialFactura.Month.ToString + "/" + FechaInicialFactura.Day.ToString + "/" + _
                FechaInicialFactura.Year.ToString + "#"

            Dim nominas As BDContabilidadGMELO.NóminasRow() = CType(BDContabilidadGMELO.Nóminas.Select(criterio), BDContabilidadGMELO.NóminasRow())

            For Each f As BDContabilidadGMELO.NóminasRow In nominas

                ' contador de columnas para la nómina
                Dim nCol As Integer = 0

                If f.FechaNómina <= Now And f.FechaNómina >= FechaInicialFactura Then

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


        oExcel.ActiveWorkbook.SaveAs(NomFicheroExcel)
        oExcel.ActiveWorkbook.Close()

        CMódulo.MsgInformativo("Se ha terminado la generación del resumen de nóminas. Puede recogerlas en " +
                              Application.StartupPath + "\FACTURAS CLIENTES\")

    End Sub

End Class