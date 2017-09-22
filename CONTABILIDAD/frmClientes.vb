Imports System
Imports Microsoft.VisualBasic

Imports CBiblioteca


Public Class FrmClientes

    Private VoyACerrar As Boolean = False
    'Private ListaTiposDocumento As New List(Of CTipoDocumento)
    Private TipoDocumentoBindingSource As BindingSource
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        For Each id As ETipoDocumento In System.Enum.GetValues(GetType(ETipoDocumento))

            'ListaTiposDocumento.Add(New CTipoDocumento(CType(id, eTipoDocumento), System.Enum.GetName(GetType(eTipoDocumento), id)))

        Next
    End Sub

    Private Sub FrmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.ValidateChildren()
                Me.ClientesBindingSource.EndEdit()
                Me.ClientesTableAdapter.Update(Me.BDContabilidadGMELO.Clientes)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True


    End Sub

    Private Sub FrmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

        Me.Text = My.Resources.Título + " - Gestión de CLIENTES"

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Function EsCorrectoDocumento(ByRef msg As String, TipoDocumento As DataGridViewCell, Documento As DataGridViewCell) As Boolean

        If CType(TipoDocumento.Value, ETipoDocumento) = ETipoDocumento.Ninguno Or
                CType(TipoDocumento.Value, ETipoDocumento) = ETipoDocumento.NIF_DNI Or
                CType(TipoDocumento.Value, ETipoDocumento) = ETipoDocumento.CIF Or
                CType(TipoDocumento.Value, ETipoDocumento) = ETipoDocumento.NIE Or
                CType(TipoDocumento.Value, ETipoDocumento) = ETipoDocumento.Pasaporte Then

            Return True

        End If

        Return False

    End Function

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CientesBindingNavigatorSaveItem.Click

        If Me.Validate Then

            Me.ClientesBindingSource.EndEdit()
            Me.ClientesTableAdapter.Update(Me.BDContabilidadGMELO.Clientes)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)
                Exit Sub

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub BtnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptClientes.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""
        '    .Tipo = CType(ETipoListadoClientes.Todos, ETipoListadoContable)

        '    Listado.ShowDialog()

        'End With

    End Sub

    Private Sub BtnListarClientesAlta_Click(sender As Object, e As EventArgs) Handles btnListarClientesAlta.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptClientes.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""
        '    .Tipo = CType(ETipoListadoClientes.Activos, ETipoListadoContable)

        '    Listado.ShowDialog()

        'End With

    End Sub

    Private Sub BtnListarClientesBaja_Click(sender As Object, e As EventArgs) Handles btnListarClientesBaja.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptClientes.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""
        '    .Tipo = CType(ETipoListadoClientes.Baja, ETipoListadoContable)

        '    Listado.ShowDialog()

        'End With

    End Sub

    Private Sub BtnListarClientesActivosFactura_Click(sender As Object, e As EventArgs) Handles btnListarClientesActivosFactura.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptClientes.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""
        '    .Tipo = CType(ETipoListadoClientes.ActivosFactura, ETipoListadoContable)

        '    Listado.ShowDialog()

        'End With

    End Sub

    Private Sub BtnListarClientesActivosRecibo_Click(sender As Object, e As EventArgs) Handles btnListarClientesActivosRecibo.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptClientes.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""
        '    .Tipo = CType(ETipoListadoClientes.ActivosRecibo, ETipoListadoContable)

        '    Listado.ShowDialog()

        'End With

    End Sub

    Private Sub BajaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BajaCheckBox.CheckedChanged

        If Me.BajaCheckBox.Checked Then

            Me.FacturaCheckBox.Checked = False
            Me.FacturaCheckBox.Enabled = False
            Me.HorasSemanalesTextBox.Text = "0"
            Me.HorasSemanalesTextBox.Enabled = False

        Else

            Me.FacturaCheckBox.Enabled = True
            Me.HorasSemanalesTextBox.Enabled = True

        End If

    End Sub

    Private Sub NombreTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NombreTextBox.Validating

        If Len(Me.NombreTextBox.Text) = 0 Then

            MDLMensajes.MsgErrorCrítico("Es obligatorio cumplimentar el nombre")
            e.Cancel = True

        End If

    End Sub

    Private Sub Ape1TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ape1TextBox.Validating

        'If EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape1TextBox.Text) = 0 Then

        '    MDLMENSAJES.MsgErrorCrítico("Para las personas físicas es obligatorio cumplimentar los apellidos")
        '    e.Cancel = True

        'Else

        '    e.Cancel = False

        'End If
        'If Not EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape1TextBox.Text) <> 0 Then

        '    MDLMENSAJES.MsgErrorCrítico("Para las personas físicas no se deben cumplimentar los apellidos")
        '    Me.Ape1TextBox.Text = ""
        '    e.Cancel = False

        'Else

        '    e.Cancel = False

        'End If

    End Sub

    Private Sub Ape2TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ape2TextBox.Validating

        'If EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape2TextBox.Text) = 0 Then

        '    MDLMENSAJES.MsgErrorCrítico("Para las personas físicas es obligatorio cumplimentar los apellidos")
        '    e.Cancel = True

        'Else

        '    e.Cancel = False

        'End If
        'If Not EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape2TextBox.Text) <> 0 Then

        '    MDLMENSAJES.MsgErrorCrítico("Para las personas físicas no se deben cumplimentar los apellidos")
        '    Me.Ape2TextBox.Text = ""
        '    e.Cancel = False

        'Else

        '    e.Cancel = False

        'End If

    End Sub

    Public Function EsPersonaFísica(prmTipo As ETipoDocumento) As Boolean

        'If prmTipo = eTipoDocumento.Ninguno OrElse prmTipo = eTipoDocumento.NIF OrElse prmTipo = eTipoDocumento.NIE OrElse
        '    prmTipo = eTipoDocumento.Pasaporte Then

        '    Return True

        'End If

        Return False

    End Function

End Class