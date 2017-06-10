Imports System.Text.RegularExpressions
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports Biblioteca
Imports Microsoft.VisualBasic.PowerPacks

Public Class frmFacturasEmitidas

    Private VoyACerrar As Boolean = False

    Private Sub frmFacturasEmitidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.FacturasEmitidasBindingSource.EndEdit()
                Me.FacturasEmitidasTableAdapter.Update(Me.BDContabilidadGMELO.FacturasEmitidas)
                Me.LíneasFacturaEmitidaBindingSource.EndEdit()
                Me.LíneasFacturaEmitidaTableAdapter.Update(Me.BDContabilidadGMELO.LíneasFacturaEmitida)

                'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)

        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)

        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)

        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)

        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)

        Me.LíneasFacturaEmitidaTableAdapter.Fill(Me.BDContabilidadGMELO.LíneasFacturaEmitida)

        Me.Text = My.Resources.Título + " - Gestión de FACTURAS de CLIENTES"

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub FacturasEmitidasDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles FacturasEmitidasDataGridView.DataError

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

    End Sub

    Private Sub FacturasEmitidasDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles FacturasEmitidasDataGridView.RowValidating

        Dim row As DataGridViewRow = Me.FacturasEmitidasDataGridView.Rows(e.RowIndex)
        Dim celdaNúmero As DataGridViewCell = row.Cells(1)
        Dim celdaFechaEmisión As DataGridViewCell = row.Cells(2)
        Dim celdaFechaOperación As DataGridViewCell = row.Cells(3)
        Dim celdaCliente As DataGridViewCell = row.Cells(4)
        Dim celdaBaseImponible As DataGridViewCell = row.Cells(5)
        Dim celdaTipoIVA As DataGridViewCell = row.Cells(6)
        Dim celdaCuota As DataGridViewCell = row.Cells(7)
        Dim celdaTotalFactura As DataGridViewCell = row.Cells(8)

        If celdaNúmero.FormattedValue.ToString.Length = 0 Then

            MsgBox("ERROR en la columna NÚMERO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        'If Not Regex.IsMatch(celdaNúmero.FormattedValue.ToString, "^[0-9/]$") Then

        '    MsgBox("ERROR en la columna NÚMERO: debe ser numérica o /.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
        '    e.Cancel = True
        '    Exit Sub

        'End If
        If celdaFechaEmisión.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna FECHA de EMISIÓN: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaFechaOperación.FormattedValue.ToString.Length = 0 Then

            celdaFechaOperación.Value = celdaFechaEmisión.FormattedValue

        End If
        If celdaCliente.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna CLIENTE: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaBaseImponible.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna BASE IMPONIBLE: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        ' por defecto es 21
        'If celdaTipoIVA.Value.ToString.Length = 0 Then

        '    MsgBox("ERROR en la columna TIPO IVA: no puede estar vacía.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
        '    e.Cancel = True
        '    Exit Sub

        'End If
        '{1,} -> una vez por lo menos
        If Regex.IsMatch(celdaNúmero.FormattedValue.ToString, "^[0-9]{1,}$") Then

            Dim s As String = CStr(celdaNúmero.FormattedValue)
            Do While s.Length < 3

                s = "0" + s

            Loop
            s += "/"
            s += CType(celdaFechaEmisión.Value, Date).Year.ToString

            celdaNúmero.Value = s

        End If
        If Not Regex.IsMatch(celdaNúmero.Value.ToString, "^(\d{3})/(\d{4})$") Then

            MsgBox("ERROR en la columna NÚMERO: debe tener un formato NNN/AAAA.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If

    End Sub

    Private Sub FacturasEmitidasDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles FacturasEmitidasDataGridView.DefaultValuesNeeded

        With e.Row

            .Cells(6).Value = "21"

        End With

    End Sub

    Private Sub FacturasEmitidasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasEmitidasBindingNavigatorSaveItem.Click

        If Me.Validate() Then


            Me.FacturasEmitidasBindingSource.EndEdit()
            Me.FacturasEmitidasTableAdapter.Update(Me.BDContabilidadGMELO.FacturasEmitidas)
            Me.LíneasFacturaEmitidaBindingSource.EndEdit()
            Me.LíneasFacturaEmitidaTableAdapter.Update(Me.BDContabilidadGMELO.LíneasFacturaEmitida)

            'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    ''' <summary>
    ''' Contabilizar Facturas emitidas que aún no lo están
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Se genera un asiento
    ''' 470CCC Cuenta Cliente ->  Prestación Servicios     705
    '''                           Hacienda IVA Repercutido 477
    ''' Posteriormente se genera asiento
    ''' 572BBB Cuenta Banco   ->  Cuenta Cliente   470CCC</remarks>
    Private Sub ContabilizarStripButton_Click(sender As Object, e As EventArgs) Handles ContabilizarStripButton.Click

        Me.Cursor = Cursors.WaitCursor

        If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, 477) Then

            If Me.CrearCuenta(477) Then

                MsgBox("Creada la cuenta 477")

            End If

        End If
        If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, 705) Then

            If Me.CrearCuenta(705) Then

                MsgBox("Creada la cuenta 705")

            End If

        End If
        For Each factura As BDContabilidadGMELO.FacturasEmitidasRow In Me.FacturasEmitidasTableAdapter.FacturasSinContabilizarSinBloquear
            'Generar cuenta del cliente si no existe

            Dim s As String = factura.idCliente.ToString
            While s.Length < 3

                s = "0" + s

            End While
            Dim NumCtaCli As Integer = CInt("430" + s)
            If Not CMódulo.ExisteCuenta(My.Settings.BDContabilidadConnectionString, NumCtaCli) Then

                If Me.CrearCuenta(NumCtaCli, factura.idCliente) Then

                    MsgBox("Creada la cuenta " + NumCtaCli.ToString)

                End If

            End If
            'Buscar el asiento con justificante el Número de Factura (VENTA FRA. NNN/AAAA)
            Dim Justificante As String = "FACTURA " + factura.Número
            Dim cliente As BDContabilidadGMELO.ClientesRow =
                    Me.BDContabilidadGMELO.Clientes.FindByid(factura.idCliente)
            Dim asiento As BDContabilidadGMELO.AsientosRow

            If Not CMódulo.ExisteAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante) Then
                ' NO EXISTE EL ASIENTO

                asiento = BDContabilidadGMELO.Asientos.NewAsientosRow
                With asiento

                    .Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
                    .Fecha = factura.FechaEmisión
                    .Justificante = Justificante
                    .Operación = "Pago servicios " + factura.NomCliente

                End With

                Me.BDContabilidadGMELO.Asientos.AddAsientosRow(asiento)

            Else
                ' RECUPERAR EL ASIENTO              
                Dim idAsiento As Integer = CMódulo.IdAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante)
                asiento = BDContabilidadGMELO.Asientos.FindByNúmero(idAsiento)
                ' se comprueba que realmente IdAsientoConJustificante(Justificante) ha funcionado OK
                If asiento IsNot Nothing Then

                    With asiento

                        .Fecha = factura.FechaEmisión
                        .Justificante = Justificante
                        .Operación = "Pago servicios " + factura.NomCliente

                    End With

                Else

                    Throw New Exception("Contabilizando facturas, no se ha podido recuperar el asiento con el número " +
                                        idAsiento.ToString + " proporcionado por el procedimiento almacenado " +
                                        """IdAsientoConJustificante(""" + Justificante.Trim + """) de la Base de Datos." +
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
                .CódigoCuenta = NumCtaCli
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "C")
                .Importe = factura.Total

            End With
            Me.BDContabilidadGMELO.Cargos.AddCargosRow(cargo)
            Me.CargosTableAdapter.Update(Me.BDContabilidadGMELO.Cargos)
            For Each a As BDContabilidadGMELO.AbonosRow In asiento.GetAbonosRows

                a.Delete()

            Next
            Dim abono As BDContabilidadGMELO.AbonosRow = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
            With abono

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = 705
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                .Importe = factura.BaseImponible

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            abono = Me.BDContabilidadGMELO.Abonos.NewAbonosRow
            With abono

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = 477
                .NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asiento.Número, "A")
                .Importe = factura.Cuota

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            Me.AbonosTableAdapter.Update(Me.BDContabilidadGMELO.Abonos)

            CMódulo.MarcarContabilizado(My.Settings.BDContabilidadConnectionString, factura.id, "F")

        Next

        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)

        Me.Cursor = Cursors.Default

        MsgBox("Se han contabilizado las Facturas pendientes de hacerlo.", MsgBoxStyle.OkOnly, My.Resources.Título)

    End Sub

    Function CrearCuenta(cta As Integer, Optional idCliente As Integer = 0) As Boolean

        Dim scta As String = cta.ToString
        Dim cuenta As BDContabilidadGMELO.CuentasRow = BDContabilidadGMELO.Cuentas.NewCuentasRow()
        ' cuenta de 3 dígitos. Copiar una cuenta maestra
        If scta.Length = 3 Then

            Dim maestra As BDContabilidadGMELO.CuentasMaestrasRow =
                Me.BDContabilidadGMELO.CuentasMaestras.FindByCódigo(cta)
            With cuenta

                .Código = cta
                .CódigoCuentaMaestra = maestra.Código
                .Nombre = maestra.Nombre
                .idPerdidasyGanancias = 0
                .idBalanceResultados = 0

            End With

        Else

            Dim ctaM As Integer = CInt(scta.Substring(0, 3))
            Dim maestra As BDContabilidadGMELO.CuentasMaestrasRow =
               Me.BDContabilidadGMELO.CuentasMaestras.FindByCódigo(ctaM)
            Dim cliente As BDContabilidadGMELO.ClientesRow =
                Me.BDContabilidadGMELO.Clientes.FindByid(idCliente)

            With cuenta

                .Código = cta
                .CódigoCuentaMaestra = maestra.Código
                .Nombre = maestra.Nombre + Me.BDContabilidadGMELO.Clientes.FindByid(idCliente).NomyApes 'NombreCliente(cliente)
                .idPerdidasyGanancias = 0
                .idBalanceResultados = 0

            End With

        End If
        Me.BDContabilidadGMELO.Cuentas.AddCuentasRow(cuenta)

        Me.CuentasTableAdapter.Update(BDContabilidadGMELO.Cuentas)
        Me.CuentasBindingSource.ResetBindings(False)

        Return True

    End Function

    Private Sub GenerarToolStripButton_Click(sender As Object, e As EventArgs) Handles GenerarToolStripButton.Click

        Dim msg As String = "Se van a generar facturas, sólo para clientes activos y para la fecha que indique " &
            "copiando las del mes anterior. " &
            "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' leer fechas
        '
        Dim PedirFecha As New frmPedirFecha
        PedirFecha.VariosDíasCheckBox.Visible = False
        PedirFecha.ShowDialog()
        If PedirFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel Then

            Exit Sub

        End If
        Dim FechaFactura As DateTime = PedirFecha.FechaDateTimePicker.Value
        Dim AñoAnterior As Integer = FechaFactura.Year
        Dim MesAnterior As Integer = FechaFactura.Month - 1
        If MesAnterior = 0 Then
            MesAnterior = 12
            AñoAnterior -= 1
        End If

        PedirFecha.Hide()
        PedirFecha.Dispose()

        Me.Refresh()

        Me.Cursor = Cursors.WaitCursor

        If FechaFactura.Month = 2 Then

            FechaFactura = CDate("28/" + FechaFactura.Month.ToString + "/" + FechaFactura.Year.ToString)

        Else

            FechaFactura = CDate("30/" + FechaFactura.Month.ToString + "/" + FechaFactura.Year.ToString)

        End If
        ' 
        ' Crear Hoja Resumen
        '

        Dim oExcel As Excel.Application
        Dim oLibro As Excel.Workbook
        'Dim oHoja As Excel.Worksheet

        'Start Word and open the document template.
        oExcel = CType(CreateObject("Excel.Application"), Excel.Application)
        'oExcel.Visible = True
        oLibro = oExcel.Workbooks.Add()
        oExcel.Range("A1").Value = "NÚMERO"
        oExcel.Range("B1").Value = "FECHA"
        oExcel.Range("C1").Value = "CLIENTE"
        oExcel.Range("D1").Value = "BASE"
        oExcel.Range("E1").Value = "IVA"
        oExcel.Range("F1").Value = "TOTAL"
        oExcel.Range("G1").Value = "FECHA ENVÍO"
        oExcel.Range("H1").Value = "FECHA PAGO"
        oExcel.Range("I1").Value = "BANCO PAGO"
        oExcel.Range("A2").Select()

        ' For Each cliente As BDContabilidadGMELO.ClientesRow In Me.ClientesTableAdapter.ClientesActivosConFactura

        For Each facturaAnterior As BDContabilidadGMELO.FacturasEmitidasRow In Me.FacturasEmitidasTableAdapter.FacturasParaDuplicar(AñoAnterior, MesAnterior)

            Dim factura As BDContabilidadGMELO.FacturasEmitidasRow = CType(Me.BDContabilidadGMELO.FacturasEmitidas.NewRow, Contabilidad.BDContabilidadGMELO.FacturasEmitidasRow)
            Dim cliente As BDContabilidadGMELO.ClientesRow
            With facturaAnterior

                cliente = BDContabilidadGMELO.Clientes.FindByid(.idCliente)

                Dim miNúmero As String = CMódulo.NúmeroNuevaFactura(My.Settings.BDContabilidadConnectionString, FechaFactura.Year)
                Me.FacturasEmitidasTableAdapter.Insert(Número:=miNúmero, FechaEmisión:=FechaFactura, FechaOperación:=FechaFactura, idCliente:=facturaAnterior.idCliente,
                                                           TipoIVA:=facturaAnterior.TipoIVA, Contabilizada:=False, Pagada:=False, FechaPago:=FechaFactura,
                                                           idCtaBancaria:=1, Bloqueada:=False)
                'recupera la factura recien creada
                Dim idFactura As Integer = CMódulo.IdFacturaConNúmero(My.Settings.BDContabilidadConnectionString, miNúmero)
                factura = Me.FacturasEmitidasTableAdapter.FindById(idFactura)(0)

                ' Se copian a la nueva factura las líneas de la antigua
                Dim idFacturaAnterior As Integer = CMódulo.IdFacturaConNúmero(My.Settings.BDContabilidadConnectionString, facturaAnterior.Número)
                Dim Líneas As BDContabilidadGMELO.LíneasFacturaEmitidaRow() =
                        CType(Me.BDContabilidadGMELO.LíneasFacturaEmitida.Select("idFactura = " + idFacturaAnterior.ToString), BDContabilidadGMELO.LíneasFacturaEmitidaRow())
                For Each l As BDContabilidadGMELO.LíneasFacturaEmitidaRow In Líneas

                    Me.LíneasFacturaEmitidaTableAdapter.Insert(idFactura, l.nLínea, l.Descripción, l.Importe)

                Next

                'recupera la factura recien creada para leer las columnas que son calculadas
                factura = Me.FacturasEmitidasTableAdapter.FindById(idFactura)(0)

                'Me.BDContabilidadGMELO.FacturasEmitidas.AcceptChanges()
                ' Escribe celda 1 de la fila n
                oExcel.ActiveCell.Value = factura.Número
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 1).Value = FechaFactura
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 2).Value = factura.NomCliente
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 3).Value = factura.BaseImponible
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 4).Value = factura.Cuota
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 5).Value = factura.Total
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 6).Value = ""   ' fecha envío
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 7).Value = ""   ' fecha pago
                ' Escribe celda siguiente de la fila n
                oExcel.ActiveCell.Offset(0, 8).Value = ""   ' banco pago

                Dim oWord As Word.Application
                Dim oDoc As Word.Document
                Dim oPara1 As Word.Paragraph
                Dim oTable As Word.Table
                Dim oShape As Word.InlineShape

                'Start Word and open the document template.
                oWord = CType(CreateObject("Word.Application"), Word.Application)
                'oWord.Visible = True
                oDoc = oWord.Documents.Add() 'Application.StartupPath & "\PLANTILLAS\Factura.docx")

                'Insert a chart and change the chart.
                oDoc.PageSetup.LeftMargin = oWord.CentimetersToPoints(1.4)
                oDoc.PageSetup.TopMargin = oWord.CentimetersToPoints(1.2)

                'Dim img As Image = My.Resources.logoMelo
                'oShape = oDoc.Bookmarks.Item("\startofdoc").Range.InlineShapes.AddPicture("", LinkToFile:=False)
                oShape = oDoc.Bookmarks.Item("\startofdoc").Range.InlineShapes.AddPicture(
                        "K:\Grupo MELO\CONTABILIDAD\imágenes\logomelo.gif", LinkToFile:=False)
                'oShape.Width = oWord.CentimetersToPoints(4)
                'oShape.Height = oWord.CentimetersToPoints(1.5)

                oDoc.PageSetup.LeftMargin = oWord.CentimetersToPoints(3)
                oDoc.PageSetup.RightMargin = oWord.CentimetersToPoints(2)

                'Insert a paragraph at the beginning of the document.
                oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(2)

                ' Nombre
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(4)
                oPara1.LeftIndent = oWord.CentimetersToPoints(9)
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 9
                oPara1.Range.Font.Name = "Times New Roman"
                oPara1.Range.Font.Size = 12
                oPara1.Range.Bold = CInt(True)
                oPara1.Range.Text = Trim(factura.NomCliente)

                ' Domicilio
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(5)
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(9)
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 7
                oPara1.Range.Font.Size = 12
                oPara1.Range.Bold = CInt(False)
                oPara1.Range.Text = cliente.Domicilio

                ' Código Postal
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(6)
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(9)
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 3
                oPara1.Range.Font.Size = 12
                oPara1.Range.Bold = CInt(False)
                oPara1.Range.Text = cliente.CódigoPostal + " " + cliente.Localidad

                ' Número de Factura
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(7)
                oPara1.Range.ParagraphFormat.TabStops.ClearAll()
                oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(8.75), Word.WdAlignmentTabAlignment.wdLeft, Word.WdTabLeader.wdTabLeaderSpaces)
                oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(9), Word.WdAlignmentTabAlignment.wdLeft, Word.WdTabLeader.wdTabLeaderSpaces)
                oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(14), Word.WdAlignmentTabAlignment.wdRight, Word.WdTabLeader.wdTabLeaderSpaces)
                oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(15.5), Word.WdAlignmentTabAlignment.wdRight, Word.WdTabLeader.wdTabLeaderSpaces)
                Dim Doc As String = ""
                If cliente.TipoDocumentoIdentidad - 1 = eTipoDocumento.CIF Then
                    Doc = "CIF: " + cliente.DocumentoIdentidad
                ElseIf cliente.TipoDocumentoIdentidad - 1 = eTipoDocumento.NIE Then
                    Doc = "NIE: " + cliente.DocumentoIdentidad
                ElseIf cliente.TipoDocumentoIdentidad - 1 = eTipoDocumento.NIF Then
                    Doc = "NIF: " + cliente.DocumentoIdentidad
                End If
                oPara1.Range.Text = "FACTURA: " + factura.Número + vbTab + vbTab + Doc
                oPara1.Format.LeftIndent = 0

                ' Tabla
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(8)
                'Insert a n x 4 table, fill it with data and change the column widths.
                oTable = oDoc.Tables.Add(oPara1.Range, 13, 4)

                ' Formato de filas
                oTable.Rows(1).Height = 10

                ' Formato de columnas
                oTable.Columns(1).Width = oWord.InchesToPoints(0.7)   'Change width of columns 1 & 2.
                oTable.Columns(1).Borders.Enable = 1

                oTable.Columns(2).Width = oWord.InchesToPoints(3.7)
                oTable.Columns(2).Borders.Enable = 1

                oTable.Columns(3).Width = oWord.InchesToPoints(0.8)
                oTable.Columns(3).Borders.Enable = 1

                oTable.Columns(4).Width = oWord.InchesToPoints(1)
                oTable.Columns(4).Borders.Enable = 1
                ' Bordes
                For fila As Integer = 2 To oTable.Rows.Count - 1
                    For col As Integer = 1 To 4
                        oTable.Cell(fila, col).Borders(Word.WdBorderType.wdBorderBottom).LineStyle = Word.WdLineStyle.wdLineStyleNone
                    Next
                Next

                ' Celdas de Cabecera
                With oTable.Cell(1, 1).Range

                    .Text = "CANTIDAD"
                    .Font.Size = 8
                    .Font.Bold = CInt(True)
                    .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

                    .Borders.Enable = 1

                End With
                With oTable.Cell(1, 2).Range

                    .Text = "CONCEPTO"
                    .Font.Size = 8
                    .Font.Bold = CInt(True)
                    .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

                    .Borders.Enable = 1

                End With
                With oTable.Cell(1, 3).Range

                    .Text = "PRECIO"
                    .Font.Size = 8
                    .Font.Bold = CInt(True)
                    .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

                    .Borders.Enable = 1

                End With
                With oTable.Cell(1, 4).Range

                    .Text = "EUROS"
                    .Font.Size = 8
                    .Font.Bold = CInt(True)
                    .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

                    .Borders.Enable = 1

                End With
                ' celdas con datos
                Dim miNum As Integer = 2
                For Each línea As BDContabilidadGMELO.LíneasFacturaEmitidaRow In Líneas

                    miNum += 1
                    With oTable.Cell(miNum, 2).Range

                        .Text = línea.Descripción
                        .Font.Name = "Times New Roman"
                        .Font.Size = 12
                        .Font.Bold = CInt(False)
                        .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    End With
                    With oTable.Cell(miNum, 4).Range

                        .Text = línea.Importe.ToString("N2")
                        .Font.Size = 12
                        .Font.Bold = CInt(False)
                        .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    End With

                Next

                'cristobal factura = Me.FacturasEmitidasTableAdapter.FindById(idFactura)(0)

                'Insert a paragraph at the end of the document.
                '** \endofdoc is a predefined bookmark.
                oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                oPara1.Range.Text = "C.I.F. B-82007386" +
                        vbTab +
                         vbTab +
                         vbTab +
                        "SUMA:" +
                        vbTab +
                        factura.BaseImponible.ToString("N2")
                oPara1.Format.SpaceAfter = 1    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                oPara1.Range.Text = vbTab +
                         vbTab +
                         vbTab +
                        "IVA 21%:" +
                        vbTab +
                        factura.Cuota.ToString("N2")
                oPara1.Format.SpaceAfter = 1    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                oPara1.Range.Text = vbTab +
                         vbTab +
                         vbTab +
                        "TOTAL:" +
                        vbTab +
                        factura.Total.ToString("N2")
                oPara1.Range.Font.Bold = CInt(True)
                oPara1.Format.SpaceAfter = 10    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                ' Fecha de Factura                                      
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(77)
                oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 1
                oPara1.Range.Font.Name = "Times New Roman"
                oPara1.Range.Font.Size = 12
                oPara1.Format.Alignment = CType(Word.WdHorizontalLineAlignment.wdHorizontalLineAlignCenter, Word.WdParagraphAlignment)
                oPara1.Range.Text = "Madrid, " + factura.FechaEmisión.Day.ToString +
                        " de " + MonthName(factura.FechaEmisión.Month) +
                        " de " + factura.FechaEmisión.Year.ToString
                'oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)

                ' Primera línea de pago
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(78)
                oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
                oPara1.Format.SpaceAfter = 7
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 9
                oPara1.Range.Font.Name = "Times New Roman"
                oPara1.Range.Font.Size = 10
                oPara1.Range.Font.Bold = CInt(True)
                oPara1.Range.Text = "ROGAMOS REALICEN TRANSFERENCIA A LA SIGUIENTE CUENTA CORRIENTE BANCO"

                ' Segunda línea de pago
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(79)
                oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
                oPara1.Format.SpaceAfter = 10
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 9
                oPara1.Range.Font.Name = "Times New Roman"
                oPara1.Range.Font.Size = 10
                oPara1.Range.Font.Bold = CInt(True)
                oPara1.Range.Text = "SANTANDER CENTRAL HISPANO ENTIDAD 0049 OFICINA 1814 DC 78 C/C 2710096519"

                ' Tercera línea de pago
                oPara1.Range.InsertParagraphAfter()
                oPara1 = oDoc.Paragraphs(80)
                oPara1.LineUnitBefore = 1
                oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
                oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
                oPara1.LineSpacing = 7
                oPara1.Range.Font.Name = "Times New Roman"
                oPara1.Range.Font.Size = 10
                oPara1.Range.Font.Bold = CInt(True)
                oPara1.Range.Text = "GRACIAS"


                Dim NomFichero As String = Application.StartupPath & "\FACTURAS CLIENTES\Fra" +
                        FechaFactura.Year.ToString + DateAndTime.MonthName(FechaFactura.Month) +
                        Trim(factura.NomCliente) + ".docx"
                NomFichero = NomFichero.Replace("/", " ")
                oWord.ActiveDocument.SaveAs(CStr(NomFichero))
                oWord.ActiveDocument.Close()

                'cerrar aplicaciones office
                oWord.Quit()

                'Me.BDContabilidadGMELO.FacturasEmitidas.AddFacturasEmitidasRow(factura)
                'Me.FacturasEmitidasTableAdapter.Update(Me.BDContabilidadGMELO.FacturasEmitidas)

            End With

            ' salta a la primera celda de la fila siguiente
            oExcel.ActiveCell.Offset(1, 0).Select()

        Next

        ' Next

        Dim NomFicheroExcel As String = Application.StartupPath & "\FACTURAS CLIENTES\ResumenFacturas" +
           FechaFactura.Year.ToString + DateAndTime.MonthName(FechaFactura.Month) +
           ".xls"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")
        oExcel.ActiveWorkbook.SaveAs(NomFicheroExcel)
        oExcel.ActiveWorkbook.Close()

        'cerrar aplicaciones office
        oExcel.Quit()

        Me.Cursor = Cursors.Default

        Me.BDContabilidadGMELO.FacturasEmitidas.AcceptChanges()
        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)

        Me.BDContabilidadGMELO.LíneasFacturaEmitida.AcceptChanges()
        Me.LíneasFacturaEmitidaTableAdapter.Fill(Me.BDContabilidadGMELO.LíneasFacturaEmitida)

        Me.FacturasEmitidasBindingSource.ResetBindings(False)
        Me.LíneasFacturaEmitidaBindingSource.ResetBindings(False)

        CMódulo.MsgInformativo("Se ha terminado la generación de facturas. Puede recogerlas en " +
                              Application.StartupPath + "\FACTURAS CLIENTES\")
    End Sub


    Private Sub btnListarFacturasEmitidas_Click(sender As Object, e As EventArgs) Handles btnListarFacturasEmitidas.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptFacturasEmitidas.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnEmitirFacturasToolStrip_Click(sender As Object, e As EventArgs) Handles btnEmitirFacturasToolStrip.Click

        Dim msg As String = "Se van a emitir las facturas del mes que indique. " &
    "Podrá seleccionar si de todos los clientes o de uno sólo. " &
    "¿Quiere continuar?"

        If CMódulo.MsgPregunta(msg) <> MsgBoxResult.Yes Then

            Exit Sub

        End If
        '
        ' leer fechas
        '
        Dim PedirFecha As New frmPedirFecha
        PedirFecha.VariosDíasCheckBox.Visible = False
        PedirFecha.ShowDialog()
        If PedirFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel Then

            Exit Sub

        End If
        Dim FechaFactura As DateTime = PedirFecha.FechaDateTimePicker.Value
        Dim AñoAnterior As Integer = FechaFactura.Year
        Dim MesAnterior As Integer = FechaFactura.Month - 1
        If MesAnterior = 0 Then
            MesAnterior = 12
            AñoAnterior -= 1
        End If

        PedirFecha.Hide()
        PedirFecha.Dispose()
        Me.Refresh()
        If FechaFactura.Month = 2 Then

            FechaFactura = CDate("28/" + FechaFactura.Month.ToString + "/" + FechaFactura.Year.ToString)

        Else

            FechaFactura = CDate("30/" + FechaFactura.Month.ToString + "/" + FechaFactura.Year.ToString)

        End If
        CMódulo.MsgAdvertencia("Se van a imprimir facturas con fecha " + FechaFactura.ToString)

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptFacturaCliente.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnResumenExcel_Click(sender As Object, e As EventArgs) Handles btnResumenExcel.Click

        Dim msg As String = "Se va a generar una hoja de Excel con un resumen de facturas, " &
            "de todos los clientes, incluidos los no activos, y para las fechas que indique. " & vbCrLf &
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
        oExcel.Range("A1").Value = "CLIENTE"
        oExcel.Range("B1").Value = "NÚMERO"
        oExcel.Range("C1").Value = "FECHA"
        oExcel.Range("D1").Value = "TOTAL"
        oExcel.Range("E1").Value = "FECHA ENVÍO"
        oExcel.Range("F1").Value = "FECHA PAGO"
        oExcel.Range("G1").Value = "BANCO PAGO"
        oExcel.Range("A2").Select()

        ' contador de filas del resumen
        For Each r As BDContabilidadGMELO.ClientesRow In Me.BDContabilidadGMELO.Clientes
            'ClientesTableAdapter.GetDataByActivos()


            For Each f As BDContabilidadGMELO.FacturasEmitidasRow In Me.FacturasEmitidasTableAdapter.FacturasCliente(r.id)

                If f.FechaEmisión <= FechaFinalFactura And f.FechaEmisión >= FechaInicialFactura Then

                    ' contador de columnas para la factura del cliente
                    Dim nCol As Integer = 0

                    With f

                        Dim NomBanco As String
                        Try

                            Dim banco As BDContabilidadGMELO.CuentasBancariasRow = Me.BDContabilidadGMELO.CuentasBancarias.FindByid(.idCtaBancaria)
                            ' la rutina mete por delante " ."
                            NomBanco = banco.Banco

                        Catch ex As Exception

                            NomBanco = ""

                        End Try
                        Dim cliente As BDContabilidadGMELO.ClientesRow = Me.BDContabilidadGMELO.Clientes.FindByid(r.id)
                        ' la rutina mete por delante " ."
                        Dim NomCliente As String = Me.BDContabilidadGMELO.Clientes.FindByid(f.idCliente).NomyApes 'Me.NombreCliente(cliente).Substring(2)
                        ' Escribe el nombre del cliente en la orimera celda de la fila
                        oExcel.ActiveCell.Value = NomCliente

                        ' Escribe celda 1 de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.Número
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.FechaEmisión
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = f.Total
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        Try
                            oExcel.ActiveCell.Offset(0, nCol).Value = f.FechaEmisión

                        Catch ex As Exception

                            oExcel.ActiveCell.Offset(0, nCol).Value = ""

                        End Try
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        Try

                            oExcel.ActiveCell.Offset(0, nCol).Value = f.FechaPago

                        Catch ex As Exception

                            oExcel.ActiveCell.Offset(0, nCol).Value = ""

                        End Try
                        ' Escribe celda siguiente de la fila n
                        nCol += 1
                        oExcel.ActiveCell.Offset(0, nCol).Value = NomBanco


                    End With

                    oExcel.ActiveCell.Offset(1, 0).Select()

                End If

            Next
            ' Cuando cambia de cliente salta a la primera celda de la fila siguiente
            ' si se ha escrito alguna factura
            'If AlgunaFacturaEscrita Then

            ' oExcel.ActiveCell.Offset(1, 0).Select()

            'End If
        Next

        Dim NomFicheroExcel As String = Application.StartupPath & "\FACTURAS CLIENTES\ResumenFacturas" +
           FechaInicialFactura.Year.ToString + DateAndTime.MonthName(FechaInicialFactura.Month) + "_" +
           FechaFinalFactura.Year.ToString + DateAndTime.MonthName(FechaFinalFactura.Month) +
           ".xls"
        NomFicheroExcel = NomFicheroExcel.Replace("/", " ")
        oExcel.ActiveWorkbook.SaveAs(NomFicheroExcel)
        oExcel.ActiveWorkbook.Close()

        CMódulo.MsgInformativo("Se ha terminado la generación del resumen de facturas. Puede recogerlas en " +
                              Application.StartupPath + "\FACTURAS CLIENTES\")

    End Sub

    ''' <summary>
    ''' Contabilizar Facturas emitidas que aún no lo están
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Se genera un asiento
    ''' 572BBB Cuenta Banco   ->  Cuenta Cliente   470CCC</remarks>
    Private Sub PagarStripButton_Click(sender As Object, e As EventArgs) Handles PagarStripButton.Click

        Me.Cursor = Cursors.WaitCursor

        ' Selecciona las facturas que están contabilizadas y tienen fecha de pago no nula
        ' Se genera asiento
        '       
        For Each f As BDContabilidadGMELO.FacturasEmitidasRow In FacturasEmitidasTableAdapter.FacturasContabilizadasSinPagarSinBloquear


            Console.WriteLine(f.FechaPago)

            'Cuenta del cliente
            Dim s As String = f.idCliente.ToString
            While s.Length < 3

                s = "0" + s

            End While
            Dim NumCtaCli As Integer = CInt("430" + s)

            'Cuenta del banco
            s = f.idCtaBancaria.ToString
            While s.Length < 3

                s = "0" + s

            End While
            Dim NumCtaBan As Integer = CInt("572" + s)
            If NumCtaBan = 572003 Then
                ' Caja
                NumCtaBan = 570
            End If

            'Buscar el asiento con justificante el Número de Factura (COBRO FRA. NNN/AAAA)
            Dim Justificante As String = "COBRO FACTURA " + f.Número
            Dim cliente As BDContabilidadGMELO.ClientesRow =
                    Me.BDContabilidadGMELO.Clientes.FindByid(f.idCliente)
            Dim asiento As BDContabilidadGMELO.AsientosRow
            If Not CMódulo.ExisteAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante) Then
                ' NO EXISTE EL ASIENTO

                asiento = BDContabilidadGMELO.Asientos.NewAsientosRow()
                With asiento

                    .Número = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
                    .Fecha = f.FechaPago
                    .Justificante = Justificante
                    .Operación = "Cobro factura del mes " + Me.BDContabilidadGMELO.Clientes.FindByid(f.idCliente).NomyApes ' NombreCliente(cliente)

                End With

                Me.BDContabilidadGMELO.Asientos.AddAsientosRow(asiento)

            Else
                ' RECUPERAR EL ASIENTO
                Dim idAsiento As Integer = CMódulo.IdAsientoConJustificante(My.Settings.BDContabilidadConnectionString, Justificante)
                asiento = BDContabilidadGMELO.Asientos.FindByNúmero(idAsiento)
                ' se comprueba que realmente IdAsientoConJustificante(Justificante) ha funcionado OK
                If asiento IsNot Nothing Then

                    With asiento

                        .Fecha = f.FechaPago
                        .Justificante = Justificante
                        .Operación = "Cobro factura del mes " + Me.BDContabilidadGMELO.Clientes.FindByid(f.idCliente).NomyApes ' NombreCliente(cliente)

                    End With
                Else

                    Throw New Exception("Contabilizando pago de facturas, no se ha podido recuperar el asiento con el número " +
                                        idAsiento.ToString + " proporcionado por el procedimiento almacenado " +
                                        """IdAsientoConJustificante(""" + Justificante.Trim + """) de la Base de Datos." +
                                        "Se cancelará el proceso.")

                    Exit Sub

                End If

            End If

            ' cargos
            Me.AsientosTableAdapter.Update(Me.BDContabilidadGMELO.Asientos)
            For Each c As BDContabilidadGMELO.CargosRow In asiento.GetCargosRows

                c.Delete()

            Next
            Dim cargo As BDContabilidadGMELO.CargosRow = Me.BDContabilidadGMELO.Cargos.NewCargosRow
            With cargo

                .NúmeroAsiento = asiento.Número
                .CódigoCuenta = NumCtaBan
                .NúmeroApunte = 1
                .Importe = f.Total

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
                .CódigoCuenta = NumCtaCli
                .NúmeroApunte = 1
                .Importe = f.Total

            End With
            Me.BDContabilidadGMELO.Abonos.AddAbonosRow(abono)
            Me.AbonosTableAdapter.Update(Me.BDContabilidadGMELO.Abonos)

            CMódulo.MarcarPagado(My.Settings.BDContabilidadConnectionString, f.id, "F")

        Next

        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)

        Me.Cursor = Cursors.Default

        MsgBox("Se han contabilizado los pagos de Facturas pendientes de hacerlo.", MsgBoxStyle.OkOnly, My.Resources.Título)

    End Sub

    Private Sub DuplicarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarFactura.Click

        Dim TipoIVA As Double = CDbl(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("TipoIVA"))
        Dim idCliente As Integer = CInt(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("idCliente"))
        Dim idFacturaActual As Integer = CInt(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("id"))

        ' Se trabaja en la Base de Datos con métodos directos. Se "desenganchan los binding"        
        FacturasEmitidasBindingSource.SuspendBinding()

        Dim NúmeroFactura As String = CMódulo.NúmeroNuevaFactura(My.Settings.BDContabilidadConnectionString, Today.Year)

        Me.FacturasEmitidasTableAdapter.Insert(NúmeroFactura, Today, Today, idCliente, TipoIVA, False, False, Today, 1, False)

        ' Se copian a la nueva factura las líneas de la antigua
        Dim idNuevaFactura As Integer = CMódulo.IdFacturaConNúmero(My.Settings.BDContabilidadConnectionString, NúmeroFactura)

        Dim facturaActual As BDContabilidadGMELO.FacturasEmitidasRow = Me.BDContabilidadGMELO.FacturasEmitidas.FindByid(idFacturaActual)
        For Each l As BDContabilidadGMELO.LíneasFacturaEmitidaRow In facturaActual.GetLíneasFacturaEmitidaRows

            Me.LíneasFacturaEmitidaTableAdapter.Insert(idNuevaFactura, l.nLínea, l.Descripción, l.Importe)

        Next
        ' Vuelve a enganchar y recargar los binding
        FacturasEmitidasBindingSource.ResumeBinding()
        '
        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)
        '
        ' Se posiciona en el nuevo asiento
        '
        Dim p As Integer = Me.FacturasEmitidasBindingSource.Find("Número", NúmeroFactura)
        Me.FacturasEmitidasBindingSource.Position = p

    End Sub


    Private Sub GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Click

        Dim Número As String = CStr(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("Número"))
        Dim FechaEmisión As Date = CDate(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("FechaEmisión"))
        Dim BaseImponible As Double = CDbl(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("BaseImponible"))
        Dim TipoIVA As Double = CDbl(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("TipoIVA"))
        Dim Cuota As Double = CDbl(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("Cuota"))
        Dim Total As Double = CDbl(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("Total"))
        Dim idCliente As Integer = CInt(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("idCliente"))
        'Dim NomCliente As String = CStr(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("NomCliente"))
        Dim Cliente As BDContabilidadGMELO.ClientesRow = Me.BDContabilidadGMELO.Clientes.FindByid(idCliente)

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oPara1 As Word.Paragraph
        Dim oTable As Word.Table
        Dim oShape As Word.InlineShape

        'Start Word and open the document template.
        oWord = CType(CreateObject("Word.Application"), Word.Application)
        'oWord.Visible = True
        oDoc = oWord.Documents.Add() 'Application.StartupPath & "\PLANTILLAS\Factura.docx")

        'Insert a chart and change the chart.
        oDoc.PageSetup.LeftMargin = oWord.CentimetersToPoints(1.4)
        oDoc.PageSetup.TopMargin = oWord.CentimetersToPoints(1.2)

        'Dim img As Image = My.Resources.logoMelo
        oShape = oDoc.Bookmarks.Item("\startofdoc").Range.InlineShapes.AddPicture(
            "K:\Grupo MELO\CONTABILIDAD\imágenes\logomelo.gif", LinkToFile:=False)

        oDoc.PageSetup.LeftMargin = oWord.CentimetersToPoints(3)
        oDoc.PageSetup.RightMargin = oWord.CentimetersToPoints(2)

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(2)

        ' Nombre
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(4)
        oPara1.LeftIndent = oWord.CentimetersToPoints(9)
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 9
        oPara1.Range.Font.Name = "Times New Roman"
        oPara1.Range.Font.Size = 12
        oPara1.Range.Bold = CInt(True)
        oPara1.Range.Text = Trim(Cliente.NomyApes)

        ' Domicilio
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(5)
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(9)
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 7
        oPara1.Range.Font.Size = 12
        oPara1.Range.Bold = CInt(False)
        oPara1.Range.Text = Cliente.Domicilio

        ' Código Postal
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(6)
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(9)
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 3
        oPara1.Range.Font.Size = 12
        oPara1.Range.Bold = CInt(False)
        oPara1.Range.Text = Cliente.CódigoPostal + " " + Cliente.Localidad

        ' Número de Factura
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(7)
        oPara1.Range.ParagraphFormat.TabStops.ClearAll()
        oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(8.75), Word.WdAlignmentTabAlignment.wdLeft, Word.WdTabLeader.wdTabLeaderSpaces)
        oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(9), Word.WdAlignmentTabAlignment.wdLeft, Word.WdTabLeader.wdTabLeaderSpaces)
        oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(14), Word.WdAlignmentTabAlignment.wdRight, Word.WdTabLeader.wdTabLeaderSpaces)
        oPara1.Range.ParagraphFormat.TabStops.Add(oWord.CentimetersToPoints(15.5), Word.WdAlignmentTabAlignment.wdRight, Word.WdTabLeader.wdTabLeaderSpaces)
        Dim Doc As String = ""
        If Cliente.TipoDocumentoIdentidad = eTipoDocumento.CIF Then
            Doc = "CIF: " + Cliente.DocumentoIdentidad
        ElseIf Cliente.TipoDocumentoIdentidad = eTipoDocumento.NIE Then
            Doc = "NIE: " + Cliente.DocumentoIdentidad
        ElseIf Cliente.TipoDocumentoIdentidad = eTipoDocumento.NIF Then
            Doc = "NIF: " + Cliente.DocumentoIdentidad
        End If
        oPara1.Range.Text = "FACTURA: " + Número + vbTab + vbTab + Doc
        oPara1.Format.LeftIndent = 0

        ' Tabla
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(8)
        'Insert a n x 4 table, fill it with data and change the column widths.
        oTable = oDoc.Tables.Add(oPara1.Range, 13, 4)

        ' Formato de filas
        oTable.Rows(1).Height = 10

        ' Formato de columnas
        oTable.Columns(1).Width = oWord.InchesToPoints(0.7)   'Change width of columns 1 & 2.
        oTable.Columns(1).Borders.Enable = 1

        oTable.Columns(2).Width = oWord.InchesToPoints(3.7)
        oTable.Columns(2).Borders.Enable = 1

        oTable.Columns(3).Width = oWord.InchesToPoints(0.8)
        oTable.Columns(3).Borders.Enable = 1

        oTable.Columns(4).Width = oWord.InchesToPoints(1)
        oTable.Columns(4).Borders.Enable = 1
        ' Bordes
        For fila As Integer = 2 To oTable.Rows.Count - 1
            For col As Integer = 1 To 4
                oTable.Cell(fila, col).Borders(Word.WdBorderType.wdBorderBottom).LineStyle = Word.WdLineStyle.wdLineStyleNone
            Next
        Next

        ' Celdas de Cabecera
        With oTable.Cell(1, 1).Range

            .Text = "CANTIDAD"
            .Font.Size = 8
            .Font.Bold = CInt(True)
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

            .Borders.Enable = 1

        End With
        With oTable.Cell(1, 2).Range

            .Text = "CONCEPTO"
            .Font.Size = 8
            .Font.Bold = CInt(True)
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

            .Borders.Enable = 1

        End With
        With oTable.Cell(1, 3).Range

            .Text = "PRECIO"
            .Font.Size = 8
            .Font.Bold = CInt(True)
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

            .Borders.Enable = 1

        End With
        With oTable.Cell(1, 4).Range

            .Text = "EUROS"
            .Font.Size = 8
            .Font.Bold = CInt(True)
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

            .Borders.Enable = 1

        End With
        ' celdas con datos
        Dim idFactura As Integer = CInt(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("id"))
        Dim f As BDContabilidadGMELO.FacturasEmitidasRow = Me.BDContabilidadGMELO.FacturasEmitidas.FindByid(idFactura)
        Dim miNum As Integer = 2
        For Each línea As BDContabilidadGMELO.LíneasFacturaEmitidaRow In f.GetLíneasFacturaEmitidaRows

            miNum += 1
            With oTable.Cell(miNum, 2).Range

                .Text = línea.Descripción
                .Font.Name = "Times New Roman"
                .Font.Size = 12
                .Font.Bold = CInt(False)
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oTable.Cell(miNum, 4).Range

                .Text = línea.Importe.ToString("N2")
                .Font.Size = 12
                .Font.Bold = CInt(False)
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

            End With
        Next
        '** \endofdoc is a predefined bookmark.
        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.Text = "C.I.F. B-82007386" +
            vbTab +
             vbTab +
             vbTab +
            "SUMA:" +
            vbTab +
            BaseImponible.ToString("N2")
        oPara1.Format.SpaceAfter = 1    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.Text = vbTab +
             vbTab +
             vbTab +
            "IVA 21%:" +
            vbTab +
            Cuota.ToString("N2")
        oPara1.Format.SpaceAfter = 1    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.Text = vbTab +
             vbTab +
             vbTab +
            "TOTAL:" +
            vbTab +
            Total.ToString("N2")
        oPara1.Range.Font.Bold = CInt(True)
        oPara1.Format.SpaceAfter = 10    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        ' Fecha de Factura                                      
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(77)
        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 1
        oPara1.Range.Font.Name = "Times New Roman"
        oPara1.Range.Font.Size = 12
        oPara1.Format.Alignment = CType(Word.WdHorizontalLineAlignment.wdHorizontalLineAlignCenter, Word.WdParagraphAlignment)
        oPara1.Range.Text = "Madrid, " + FechaEmisión.Day.ToString +
            " de " + MonthName(FechaEmisión.Month) +
            " de " + FechaEmisión.Year.ToString
        'oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)

        ' Primera línea de pago
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(78)
        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
        oPara1.Format.SpaceAfter = 7
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 9
        oPara1.Range.Font.Name = "Times New Roman"
        oPara1.Range.Font.Size = 10
        oPara1.Range.Font.Bold = CInt(True)
        oPara1.Range.Text = "ROGAMOS REALICEN TRANSFERENCIA A LA SIGUIENTE CUENTA CORRIENTE BANCO"

        ' Segunda línea de pago
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(79)
        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
        oPara1.Format.SpaceAfter = 10
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 9
        oPara1.Range.Font.Name = "Times New Roman"
        oPara1.Range.Font.Size = 10
        oPara1.Range.Font.Bold = CInt(True)
        oPara1.Range.Text = "SANTANDER CENTRAL HISPANO ENTIDAD 0049 OFICINA 1814 DC 78 C/C 2710096519"

        ' Tercera línea de pago
        oPara1.Range.InsertParagraphAfter()
        oPara1 = oDoc.Paragraphs(80)
        oPara1.LineUnitBefore = 1
        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara1.Format.LeftIndent = oWord.CentimetersToPoints(0)
        oPara1.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast
        oPara1.LineSpacing = 7
        oPara1.Range.Font.Name = "Times New Roman"
        oPara1.Range.Font.Size = 10
        oPara1.Range.Font.Bold = CInt(True)
        oPara1.Range.Text = "GRACIAS"


        Dim NomFichero As String = Application.StartupPath & "\FACTURAS CLIENTES\Fra" +
            FechaEmisión.Year.ToString + DateAndTime.MonthName(FechaEmisión.Month) +
            Trim(Cliente.NomyApes) + ".docx"
        NomFichero = NomFichero.Replace("/", " ")
        oWord.ActiveDocument.SaveAs(CStr(NomFichero))
        oWord.ActiveDocument.Close()

        'cerrar aplicaciones office
        oWord.Quit()

        CMódulo.MsgInformativo("Se ha terminado la generación de la factura. Puede recogerla en " +
                       Application.StartupPath + "\FACTURAS CLIENTES\")


    End Sub

    Private Sub MorososToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MorososToolStripMenuItem.Click

        Dim adapter As New BDContabilidadGMELOTableAdapters.ClientesDeudoresTableAdapter
        adapter.ClearBeforeFill = True
        adapter.Fill(BDContabilidadGMELO.ClientesDeudores)
        Me.BDContabilidadGMELO.LíneaDeudaClientes.Clear()

        For Each cli As BDContabilidadGMELO.ClientesDeudoresRow In Me.BDContabilidadGMELO.ClientesDeudores

            Console.WriteLine(cli.NombreCuenta)
            Dim FacturasDebidasCliente As BDContabilidadGMELO.FacturasEmitidasRow()
            Dim filtro As String = "idCliente = " + cli.idCliente.ToString + " and (pagada = false or pagada = null)"
            FacturasDebidasCliente = CType(Me.BDContabilidadGMELO.FacturasEmitidas.Select(filtro),
                BDContabilidadGMELO.FacturasEmitidasRow())

            If FacturasDebidasCliente.Count = 0 Then

                Dim líneaDeuda As BDContabilidadGMELO.LíneaDeudaClientesRow = Me.BDContabilidadGMELO.LíneaDeudaClientes.NewLíneaDeudaClientesRow
                líneaDeuda.idCliente = cli.idCliente
                líneaDeuda.NombreCliente = cli.NombreCuenta
                líneaDeuda.DeudaFactura = cli.DeudaContable
                líneaDeuda.FechaFactura = Today
                líneaDeuda.NúmeroFactura = "VARIAS"

                Me.BDContabilidadGMELO.LíneaDeudaClientes.AddLíneaDeudaClientesRow(líneaDeuda)

            Else

                For Each factura As BDContabilidadGMELO.FacturasEmitidasRow In FacturasDebidasCliente

                    Dim líneaDeuda As BDContabilidadGMELO.LíneaDeudaClientesRow = Me.BDContabilidadGMELO.LíneaDeudaClientes.NewLíneaDeudaClientesRow
                    líneaDeuda.idCliente = cli.idCliente
                    líneaDeuda.NombreCliente = cli.NombreCuenta
                    líneaDeuda.DeudaFactura = factura.BaseImponible
                    líneaDeuda.FechaFactura = factura.FechaEmisión
                    líneaDeuda.NúmeroFactura = factura.Número

                    Me.BDContabilidadGMELO.LíneaDeudaClientes.AddLíneaDeudaClientesRow(líneaDeuda)

                Next

            End If

        Next
        'Me.BDContabilidadGMELO.AcceptChanges()


        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptMorosos.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

        Me.BDContabilidadGMELO.LíneaDeudaClientes.RejectChanges()
        Me.BDContabilidadGMELO.ClientesDeudores.RejectChanges()

    End Sub

    Private Sub LíneasFacturaEmitidaDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles LíneasFacturaEmitidaDataGridView.DataError

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

    End Sub

    Private Sub LíneasFacturaEmitidaDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles LíneasFacturaEmitidaDataGridView.DefaultValuesNeeded

        With e.Row

            .Cells(2).Value = Me.LíneasFacturaEmitidaBindingSource.Count + 1

        End With

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        CMódulo.BorrarFacturaEmitida(My.Settings.BDContabilidadConnectionString,
                                         CType(CType(Me.FacturasEmitidasBindingSource.Current, System.Data.DataRowView).Item("id"), Integer))

        Me.BDContabilidadGMELO.FacturasEmitidas.AcceptChanges()
        Me.FacturasEmitidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasEmitidas)

        Me.FacturasEmitidasBindingSource.ResetBindings(False)
        Me.LíneasFacturaEmitidaBindingSource.ResetBindings(False)

    End Sub
End Class