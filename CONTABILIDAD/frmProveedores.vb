﻿Imports Biblioteca
Public Class frmProveedores

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasGasto' Puede moverla o quitarla según sea necesario.
        Me.CuentasGastoTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasGasto)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasProveedores' Puede moverla o quitarla según sea necesario.
        Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Clientes' Puede moverla o quitarla según sea necesario.
        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)

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

            Me.ProveedoresTableAdapter.Insert(Me.DocumentoIdentidadTextBox.Text, Me.NombreTextBox.Text, CInt(Me.TiposDocumentoIdentidadComboBox.SelectedValue),
                                              Me.DomicilioTextBox.Text, Me.LocalidadTextBox.Text, Me.CódigoPostalTextBox.Text, 1, 1, "", False, 0, 0,
                                              CInt(Me.Cuenta4TextBox.Text), CInt(Me.Cuenta6TextBox.Text))

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click

        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptProveedores.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

End Class