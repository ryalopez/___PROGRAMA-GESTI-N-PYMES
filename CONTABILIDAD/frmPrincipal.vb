Imports Excel = Microsoft.Office.Interop.Excel
Imports Biblioteca


Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '
        Me.Text = My.Resources.Título
        '
        ' Solicitar servidor
        '
        frmSeleccionarServidor.ShowDialog(Me)
        If frmSeleccionarServidor.DialogResult = System.Windows.Forms.DialogResult.OK Then

            My.Settings.Item("BDContabilidadConnectionString") = frmSeleccionarServidor.CadenaConexión
            Dim p As Integer = My.Settings.BDContabilidadConnectionString.IndexOf("BDContabilidadGMELO")
            My.Settings.Item("NombreBaseDatos") = My.Settings.BDContabilidadConnectionString.Substring(p, 24)
            '' MsgBox(My.Settings.NombreBaseDatos)
            ''KIKE
            'My.Settings.Item("BDContabilidadConnectionString") =
            '    "Data Source=PORTATIL\SQLEXPRESS;Initial Catalog=BDContabilidadGMELO 2015 ;Integrated Security=True"
        End If
        Try

            Dim myConn As New System.Data.SqlClient.SqlConnection(My.Settings.BDContabilidadConnectionString)
            myConn.Open()
            myConn.Close()

        Catch ex As Exception

            CMódulo.MsgErrorCrítico(ex.Message)
            Me.Close()

        End Try

        Me.mnuPrincipal.Cursor = Cursors.Hand

    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub
    '
    ' Contabilidad
    '

    Private Sub mnuEntradaAsientos_Click(sender As Object, e As EventArgs) Handles mnuEntradaAsientos.Click

        Dim a As New frmAsientos()
        a.ShowDialog(Me)

    End Sub
    Private Sub mnuAsientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAsientos.Click

        frmDiario.Show(Me)

    End Sub

    Private Sub mnuCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCuentas.Click

        frmCuentas.Show(Me)

    End Sub

    Private Sub mnuAnalítica_Click(sender As Object, e As EventArgs) Handles mnuAnalítica.Click

        'frmAnalítica.Show(Me)

    End Sub
    Private Sub PréstamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PréstamosToolStripMenuItem.Click

        frmPréstamos.Show(Me)

    End Sub
    '
    ' Facturación
    '
    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click

        frmClientes.Show(Me)

    End Sub

    Private Sub mnuFacturasClientes_Click(sender As Object, e As EventArgs) Handles mnuFacturasClientes.Click

        frmFacturasEmitidas.Show(Me)

    End Sub
    Private Sub mnuProveedores_Click(sender As Object, e As EventArgs) Handles mnuProveedores.Click

        frmProveedores.Show(Me)

    End Sub

    Private Sub mnuFacturasProveedores_Click(sender As Object, e As EventArgs) Handles mnuFacturasProveedores.Click

        frmFacturasRecibidas.Show(Me)

    End Sub
    '
    ' Nóminas
    '
    Private Sub mnuEmpleados_Click(sender As Object, e As EventArgs) Handles mnuEmpleados.Click

        frmEmpleados.Show(Me)

    End Sub

    Private Sub mnuNóminas_Click(sender As Object, e As EventArgs) Handles mnuNóminas.Click

        frmNóminas.Show(Me)

    End Sub

    Private Sub ConveniosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConvenios.Click

        frmConvenios.Show(Me)

    End Sub

    Private Sub mnuEmpresasYCentros_Click(sender As Object, e As EventArgs) Handles mnuEmpresasYCentros.Click

        frmEmpresas.Show(Me)

    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click

        frmAcercaDe.Show(Me)

    End Sub
    '
    ' Utilidades
    '
    Private Sub mnuCopiarBaseDeDatos_Click(sender As Object, e As EventArgs) Handles mnuCopiarBaseDeDatos.Click

        Dim FicheroCopia As String = Application.StartupPath & "\BKs\Copia_" + My.Settings.NombreBaseDatos + "_" +
                DateTime.Now.Day.ToString + "_" +
                DateTime.Now.Month.ToString + "_" +
                DateTime.Now.Year.ToString + "_" +
                DateTime.Now.Hour.ToString + "_" +
                DateTime.Now.Minute.ToString + ".bak"

        Dim Descripción As String = "Copia de la Base de Contabilidad de fecha " +
            DateTime.Now.ToShortDateString + " a las " + DateTime.Now.ToShortTimeString
        Dim Nombre As String = My.Settings.NombreBaseDatos

        Dim s As String = "BACKUP DATABASE """ + My.Settings.NombreBaseDatos +
            """ TO DISK = @FicheroCopia " +
            "WITH NAME = @Nombre, DESCRIPTION = @Descripción;"

        Dim cnx As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.BDContabilidadConnectionString)
        Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand(s, cnx)
        com.Parameters.Add("@FicheroCopia", SqlDbType.VarChar)
        com.Parameters("@FicheroCopia").Value = FicheroCopia
        com.Parameters.Add("@Descripción", SqlDbType.VarChar)
        com.Parameters("@Descripción").Value = Descripción
        com.Parameters.Add("@Nombre", SqlDbType.VarChar)
        com.Parameters("@Nombre").Value = My.Settings.NombreBaseDatos ' Nombre

        Try

            com.Connection.Open()
            If com.ExecuteNonQuery() = -1 Then

                CMódulo.MsgInformativo("Se ha terminado la copia de la Base de Datos. Puede recogerla en " + FicheroCopia)

            End If

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("Se ha producido la excepción " + ex.Message + vbCrLf + "No se ha podido Copiar la Base de Datos.")

        End Try

    End Sub

    Private Sub SepararExcelDelBBVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SepararExcelDelBBVAToolStripMenuItem.Click

        Dim msg As String = "Se va a partir una hoja de Excel con todos los movimientos del BBVA, " &
    "para obtener por separado en dos hojas los cargos y los abonos. " & vbCrLf &
    "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' Generar una Hoja de Cálculo copiando la que se ha descargado de INTERNET
        '
        Dim NomFicheroExcel As String = Application.StartupPath & "\BBVA\BBVA_CARGOS_Y_ABONOS" +
          ".xlsx"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")

        Dim NomFicheroOriginal As String = "" 'Application.StartupPath & "\BBVA\BBVA_MOVIMIENTOS.xlsm"
        Me.OpenFileDialog1.InitialDirectory = Application.StartupPath & "\BBVA\"
        Me.OpenFileDialog1.Filter = "Ficherox BBVA | *.xlsx"
        Me.OpenFileDialog1.FileName = "BBVA_MOVIMIENTOS.xlsx"
        If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            NomFicheroOriginal = Me.OpenFileDialog1.FileName
            While True

                Try

                    My.Computer.FileSystem.CopyFile(NomFicheroOriginal, NomFicheroExcel, True)
                    Exit While

                Catch ficheroEnUso As System.IO.IOException

                    CMódulo.MsgErrorCrítico(ficheroEnUso.Message + ". Por favor cierre el fichero.")

                Catch ex As Exception

                End Try

            End While
        Else

            Exit Sub

        End If

        Me.Cursor = Cursors.WaitCursor
        ' 
        ' Crear Hoja Resumen
        '
        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja, oHojaCargos, oHojaAbonos As Excel.Worksheet

        'Start Excel and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        'oExcel.Visible = True
        oLibro = oExcel.Workbooks.Open(NomFicheroExcel)

        oHoja = CType(oLibro.Worksheets.Item("Movimientos"), Excel.Worksheet)

        oHojaCargos = CType(oLibro.Worksheets.Add(, oHoja), Excel.Worksheet)
        oHojaCargos.Name = "Cargos"

        oHojaAbonos = CType(oLibro.Worksheets.Add(, oHojaCargos), Excel.Worksheet)
        oHojaAbonos.Name = "Abonos"

        oHoja.Select()
        oHoja.Range("A1").Select()

        ' prepara fila de títulos completa (están en la primera fila)
        ' disminuye ancho de algunas cabeceras para poder hacer autofit
        oHojaCargos.Range("A1").Value = "FECHA"
        oHojaCargos.Range("B1").Value = "CONCEPTO"
        oHojaCargos.Range("C1").Value = "EUROS"

        oHojaAbonos.Range("A1").Value = "FECHA"
        oHojaAbonos.Range("B1").Value = "CONCEPTO"
        oHojaAbonos.Range("C1").Value = "EUROS"

        Dim iCargos, iAbonos As Integer
        iCargos = 2
        iAbonos = 2
        For i As Integer = 2 To oHoja.UsedRange.Rows.Count

            If oHoja.Cells(i, 1) IsNot Nothing Then

                Dim título As String = CType(oHoja.Cells(i, 2), Excel.Range).Value.ToString.TrimEnd + " " +
                    CType(oHoja.Cells(i, 3), Excel.Range).Value.ToString

                If CDbl(CType(oHoja.Cells(i, 4), Excel.Range).Value) > 0 Then

                    iAbonos += 1
                    CType(oHojaAbonos.Cells(iAbonos, 1), Excel.Range).Value = CType(oHoja.Cells(i, 1), Excel.Range).Value
                    CType(oHojaAbonos.Cells(iAbonos, 2), Excel.Range).Value = título
                    CType(oHojaAbonos.Cells(iAbonos, 3), Excel.Range).Value = CType(oHoja.Cells(i, 4), Excel.Range).Value

                Else

                    iCargos += 1
                    CType(oHojaCargos.Cells(iCargos, 1), Excel.Range).Value = CType(oHoja.Cells(i, 1), Excel.Range).Value
                    CType(oHojaCargos.Cells(iCargos, 2), Excel.Range).Value = título
                    CType(oHojaCargos.Cells(iCargos, 3), Excel.Range).Value = CType(oHoja.Cells(i, 4), Excel.Range).Value

                End If

            End If

        Next
        oHojaCargos.UsedRange.Columns.AutoFit()
        oHojaAbonos.UsedRange.Columns.AutoFit()

        oExcel.ActiveWorkbook.Save()
        oExcel.ActiveWorkbook.Close()

        oExcel.Quit()

        Me.Cursor = Cursors.Default

        CMódulo.MsgInformativo("Se ha terminado la separación de movimientos del BBVA. " +
                              "Puede ver las Hojas de Cálculo en " +
                              Application.StartupPath + "\BBVA\")

    End Sub

    Private Sub CuadranteHorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadranteHorasToolStripMenuItem.Click

        Dim msg As String = "Se va a generar una hoja de Excel con un cudrante de horas, " &
    "empleados vs. clientes. " & vbCrLf &
    "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' Generar una Hoja de Cálculo copiando la que se ha descargado de INTERNET
        '
        Dim NomFicheroExcel As String = Application.StartupPath & "\CUADRANTE_HORAS\CUADRANTE" +
          ".xlsm"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")

        Me.Cursor = Cursors.WaitCursor
        ' 
        ' Crear Hoja Resumen
        '
        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet

        'Start Excel and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        oExcel.Visible = True
        oLibro = oExcel.Workbooks.Add()
        oHoja = CType(oLibro.Worksheets.Add(), Excel.Worksheet)

        oHoja.Name = "CUADRANTE"
        oHoja.Select()
        oHoja.Range("B1").Value = "CUADRANTE HORAS DE SERVICIO"


        Dim BD As BDContabilidadGMELO = New BDContabilidadGMELO

        Dim iEmpleados As Integer = 2
        Dim EmpleadosAdapter As BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter = New BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter
        EmpleadosAdapter.Fill(BD.Empleados)

        For Each EMP As BDContabilidadGMELO.EmpleadosRow In BD.Empleados.Select("Baja IS NULL")

            oHoja.Cells(2, iEmpleados) = EMP.NomyApe
            iEmpleados += 1

        Next

        Dim iClientes As Integer = 3
        Dim ClientesAdapter As BDContabilidadGMELOTableAdapters.ClientesTableAdapter = New BDContabilidadGMELOTableAdapters.ClientesTableAdapter
        ClientesAdapter.Fill(BD.Clientes)
        For Each CLI As BDContabilidadGMELO.ClientesRow In BD.Clientes.Select("Baja IS NULL OR Baja = 0", "Nomyapes")

            oHoja.Cells(iClientes, 1) = CLI.NomyApes
            iClientes += 1

        Next
        oHoja.UsedRange.Columns.AutoFit()

        oExcel.ActiveWorkbook.SaveAs(NomFicheroExcel, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled)
        oExcel.ActiveWorkbook.Close()

        oExcel.Quit()

        Me.Cursor = Cursors.Default

        CMódulo.MsgInformativo("Se ha terminado la generación del cuadrante de servicios. " +
                              "Puede ver la Hoja de Cálculo en " +
                              Application.StartupPath + "\CUADRANTE_HORAS\")

    End Sub

    Private Sub EvaluarAmortizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluarAmortizacionesToolStripMenuItem.Click

        Dim msg As String = "Se va a partir una hoja de Excel con todos los movimientos del BBVA, " &
    "para obtener por separado en dos hojas los cargos y los abonos. " & vbCrLf &
    "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' Generar una Hoja de Cálculo copiando la que se ha descargado de INTERNET
        '
        Dim NomFicheroExcel As String = Application.StartupPath & "\BBVA\BBVA_CARGOS_Y_ABONOS" +
          ".xlsm"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")

        Dim NomFicheroOriginal As String = "" 'Application.StartupPath & "\BBVA\BBVA_MOVIMIENTOS.xlsm"
        Me.OpenFileDialog1.InitialDirectory = Application.StartupPath & "\BBVA\"
        Me.OpenFileDialog1.Filter = "Ficherox BBVA | *.xlsm"
        Me.OpenFileDialog1.FileName = "BBVA_MOVIMIENTOS.xlsm"
        If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            NomFicheroOriginal = Me.OpenFileDialog1.FileName
            While True

                Try

                    My.Computer.FileSystem.CopyFile(NomFicheroOriginal, NomFicheroExcel, True)
                    Exit While

                Catch ficheroEnUso As System.IO.IOException

                    CMódulo.MsgErrorCrítico(ficheroEnUso.Message + ". Por favor cierre el fichero.")

                Catch ex As Exception

                End Try

            End While
        Else

            Exit Sub

        End If

        Me.Cursor = Cursors.WaitCursor
        ' 
        ' Crear Hoja Resumen
        '
        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja, oHojaCargos, oHojaAbonos As Excel.Worksheet

        'Start Excel and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        'oExcel.Visible = True
        oLibro = oExcel.Workbooks.Open(NomFicheroExcel)

        oHoja = CType(oLibro.Worksheets.Item("Movimientos"), Excel.Worksheet)
        oHojaCargos = CType(oLibro.Worksheets.Add(, oHoja), Excel.Worksheet)
        oHojaCargos.Name = "Cargos"
        oHojaAbonos = CType(oLibro.Worksheets.Add(, oHojaCargos), Excel.Worksheet)
        oHojaAbonos.Name = "Abonos"

        oHoja.Select()
        oHoja.Range("A1").Select()

        Dim título As String = CStr(oHoja.Range("A1").Value) + " " + CStr(oHoja.Range("B3").Value)
        oHojaCargos.Range("C1").Value = título
        oHojaAbonos.Range("C1").Value = título
        ' prepara fila de títulos completa
        ' disminuye ancho de algunas cabeceras para poder hacer autofit
        oHojaCargos.Range("A3").Value = "OPER."
        oHojaCargos.Range("B3").Value = "VALOR"
        oHojaCargos.Range("C3").Value = "CONCEPTO"
        oHojaCargos.Range("D3").Value = "EUROS"
        oHojaCargos.Range("E3").Value = "SALDO"

        oHojaAbonos.Range("A3").Value = "OPER."
        oHojaAbonos.Range("B3").Value = "VALOR"
        oHojaAbonos.Range("C3").Value = "CONCEPTO"
        oHojaAbonos.Range("D3").Value = "EUROS"
        oHojaAbonos.Range("E3").Value = "SALDO"
        Dim iCargos, iAbonos As Integer
        iCargos = 4
        iAbonos = 4
        For i As Integer = 7 To oHoja.UsedRange.Rows.Count

            If oHoja.Cells(i, 1) IsNot Nothing Then

                título = CStr(oHoja.Cells(i, 3)) + " " + CStr(oHoja.Cells(i + 1, 3))

                If CDbl(oHoja.Cells(i, 4)) > 0 Then

                    iAbonos += 1
                    oHoja.Range(oHoja.Cells(i, 1), oHoja.Cells(i, 5)).Copy(oHojaAbonos.Range(oHojaAbonos.Cells(iAbonos, 1), oHojaAbonos.Cells(iAbonos, 5)))
                    oHojaAbonos.Cells(iAbonos, 3) = título

                Else

                    iCargos += 1
                    oHoja.Range(oHoja.Cells(i, 1), oHoja.Cells(i, 5)).Copy(oHojaCargos.Range(oHojaCargos.Cells(iCargos, 1), oHojaCargos.Cells(iCargos, 5)))
                    oHojaCargos.Cells(iCargos, 3) = título

                End If

            End If

        Next
        oHojaCargos.UsedRange.Columns.AutoFit()
        oHojaAbonos.UsedRange.Columns.AutoFit()

        oExcel.ActiveWorkbook.Save()
        oExcel.ActiveWorkbook.Close()

        oExcel.Quit()

        Me.Cursor = Cursors.Default

        CMódulo.MsgInformativo("Se ha terminado la separación de movimientos del BBVA. " +
                              "Puede ver las Hojas de Cálculo en " +
                              Application.StartupPath + "\BBVA\")

    End Sub

    Private Sub AsientosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AsientosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub


End Class