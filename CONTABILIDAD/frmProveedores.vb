Public Class frmProveedores

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasGasto' Puede moverla o quitarla según sea necesario.
        Me.CuentasGastoTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasGasto)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasProveedores' Puede moverla o quitarla según sea necesario.
        Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)
        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Clientes' Puede moverla o quitarla según sea necesario.
        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.Text = My.Resources.Título + " - Gestión de PROVEEDORES"

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub ProveedoresDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

        '  MsgBox(e.Exception.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
        e.Cancel = True

    End Sub

    'Private Sub ProveedoresDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs)

    '    Dim row As DataGridViewRow = Me.ProveedoresDataGridView.Rows(e.RowIndex)
    '    Dim celdaNombre As DataGridViewCell = row.Cells(1)
    '    Dim celdaTipoDocumento As DataGridViewCell = row.Cells(2)
    '    Dim celdaDocumento As DataGridViewCell = row.Cells(3)

    '    'If celdaNombre.FormattedValue.ToString.Length = 0 Then

    '    '    MsgBox("ERROR en la columna NOMBRE: no puede estar vacía.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
    '    '    e.Cancel = True
    '    '    Exit Sub

    '    'End If
    '    'If celdaTipoDocumento.Value.ToString.Length = 0 Then

    '    '    MsgBox("ERROR en la columna TIPO DOCUMENTO: no puede estar vacía.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
    '    '    e.Cancel = True
    '    '    Exit Sub

    '    'End If
    '    'If celdaDocumento.FormattedValue.ToString.Length = 0 Then

    '    '    MsgBox("ERROR en la columna DOCUMENTO: no puede estar vacía.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
    '    '    e.Cancel = True
    '    '    Exit Sub

    '    'End If
    '    'Dim msg As String = ""
    '    'If Not EsCorrectoDocumento(msg, celdaTipoDocumento, celdaDocumento) Then

    '    '    MsgBox("ERROR en la columna Tipo Documento: " + msg, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Título)
    '    '    e.Cancel = True
    '    '    Exit Sub

    '    'End If

    'End Sub

    Private Function EsCorrectoDocumento(ByRef msg As String, TipoDocumento As DataGridViewCell, Documento As DataGridViewCell) As Boolean

        'If TipoDocumento.Value = eTipoDocumento.Ninguno Or _
        '        TipoDocumento.Value = eTipoDocumento.NIF Or _
        '        TipoDocumento.Value = eTipoDocumento.CIF Or _
        '        TipoDocumento.Value = eTipoDocumento.NIE Or
        '        TipoDocumento.Value = eTipoDocumento.Pasaporte Then

        '    Return True

        'End If

    End Function

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click

        If Me.Validate() Then

            Me.ProveedoresBindingSource.EndEdit()

            Me.ProveedoresTableAdapter.Adapter.Update(Me.BDContabilidadGMELO)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            'kike .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.CuentasTableAdapter.FillBy1(Me.BDContabilidadGMELO.Cuentas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class