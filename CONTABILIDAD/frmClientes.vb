Imports System.ComponentModel
Imports Biblioteca

Public Class frmClientes
    Private VoyACerrar As Boolean = False
    Private Const DOMICILIADO As Integer = 5
    Friend WithEvents f As frmAltaCuenta
    Private TipoDocumentoBindingSource As BindingSource
    ''' <summary>
    '''  Carga el formulario.
    '''  Se enlaza un control de usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormasPagoTableAdapter.Fill(Me.BDContabilidadGMELO.FormasPago)

        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)
        '
        ' Enlazar el Control de usuario
        '
        With Me.CtlDocumentoIdentidad1

            .TiposDocumentoBindingSource = Me.TiposDocumentoIdentidadBindingSource
            .DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "TipoDocumentoIdentidad", True))
            .DataBindings.Add(New System.Windows.Forms.Binding("NúmeroDocumento", Me.ClientesBindingSource, "DocumentoIdentidad", True))

        End With

        Me.Text = My.Resources.Título + " - Gestión de CLIENTES"

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub CientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CientesBindingNavigatorSaveItem.Click

        If Me.ValidateChildren Then

            Try

                Me.ClientesBindingSource.EndEdit()
                Me.ClientesTableAdapter.Update(Me.BDContabilidadGMELO.Clientes)

            Catch ex As Exception

                CMódulo.MsgErrorCrítico(ex.Message)
                Exit Sub

            End Try

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)
                Exit Sub

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub
    Private Sub frmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                If Me.ValidateChildren Then

                    Try

                        Me.ClientesBindingSource.EndEdit()
                        Me.ClientesTableAdapter.Update(Me.BDContabilidadGMELO.Clientes)

                    Catch ex As Exception

                        CMódulo.MsgErrorCrítico(ex.Message)
                        Exit Sub

                    End Try

                    If Me.BDContabilidadGMELO.HasChanges = False Then

                        MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)
                        Exit Sub

                    End If

                Else

                    MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

        e.Cancel = False

    End Sub

    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""
            .Tipo = CType(eTipoListadoClientes.Todos, eTipoListadoContable)

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnListarClientesAlta_Click(sender As Object, e As EventArgs) Handles btnListarClientesAlta.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""
            .Tipo = CType(eTipoListadoClientes.Activos, eTipoListadoContable)

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnListarClientesBaja_Click(sender As Object, e As EventArgs) Handles btnListarClientesBaja.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""
            .Tipo = CType(eTipoListadoClientes.Baja, eTipoListadoContable)

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnListarClientesActivosFactura_Click(sender As Object, e As EventArgs) Handles btnListarClientesActivosFactura.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""
            .Tipo = CType(eTipoListadoClientes.ActivosFactura, eTipoListadoContable)

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub btnListarClientesActivosRecibo_Click(sender As Object, e As EventArgs) Handles btnListarClientesActivosRecibo.Click
        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""
            .Tipo = CType(eTipoListadoClientes.ActivosRecibo, eTipoListadoContable)

            Listado.ShowDialog()

        End With

    End Sub

    Private Sub NombreTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NombreTextBox.Validating
        If Me.NombreTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.NombreTextBox.Select(0, Me.NombreTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.NombreTextBox, "El NOMBRE no puede estar vacío")

        End If
    End Sub

    Private Sub NombreTextBox_Validated(sender As Object, e As EventArgs) Handles NombreTextBox.Validated
        Me.ErrorProvider1.SetError(Me.NombreTextBox, "")
    End Sub

    Private Sub Ape1TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ape1TextBox.Validating

        'If EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape1TextBox.Text) = 0 Then

        '    CMódulo.MsgErrorCrítico("Para las personas físicas es obligatorio cumplimentar los apellidos")
        '    e.Cancel = True

        'Else

        '    e.Cancel = False

        'End If
        'If Not EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape1TextBox.Text) <> 0 Then

        '    CMódulo.MsgErrorCrítico("Para las personas físicas no se deben cumplimentar los apellidos")
        '    Me.Ape1TextBox.Text = ""
        '    e.Cancel = False

        'Else

        '    e.Cancel = False

        'End If

    End Sub

    Private Sub Ape2TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ape2TextBox.Validating

        'If EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape2TextBox.Text) = 0 Then

        '    CMódulo.MsgErrorCrítico("Para las personas físicas es obligatorio cumplimentar los apellidos")
        '    e.Cancel = True

        'Else

        '    e.Cancel = False

        'End If
        'If Not EsPersonaFísica(CType(CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, CTipoDocumento).Índice, eTipoDocumento)) And Len(Me.Ape2TextBox.Text) <> 0 Then

        '    CMódulo.MsgErrorCrítico("Para las personas físicas no se deben cumplimentar los apellidos")
        '    Me.Ape2TextBox.Text = ""
        '    e.Cancel = False

        'Else

        '    e.Cancel = False

        'End If

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
    Private Sub BajaCheckBox_Validating(sender As Object, e As CancelEventArgs) Handles BajaCheckBox.Validating
        If Me.BajaCheckBox.CheckState <> CheckState.Checked And Me.BajaCheckBox.CheckState <> CheckState.Unchecked Then

            e.Cancel = True
            Me.BajaCheckBox.Select()
            Me.ErrorProvider1.SetError(Me.BajaCheckBox, "el campo Baja debe ser SI o NO")

        End If
    End Sub

    Private Sub BajaCheckBox_Validated(sender As Object, e As EventArgs) Handles BajaCheckBox.Validated
        Me.ErrorProvider1.SetError(Me.BajaCheckBox, "")
    End Sub

    Private Sub DomicilioTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DomicilioTextBox.Validating
        If Me.DomicilioTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.DomicilioTextBox.Text = "SIN DOMICILIO"
            Me.DomicilioTextBox.Select(0, Me.DomicilioTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.DomicilioTextBox, "El DOMICILIO no puede estar vacío")

        End If
    End Sub

    Private Sub DomicilioTextBox_Validated(sender As Object, e As EventArgs) Handles DomicilioTextBox.Validated
        Me.ErrorProvider1.SetError(Me.DomicilioTextBox, "")
    End Sub


    Private Sub CódigoPostalTextBox_Validating(sender As Object, e As CancelEventArgs) Handles CódigoPostalTextBox.Validating
        If Me.CódigoPostalTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.CódigoPostalTextBox.Text = "12345"
            Me.CódigoPostalTextBox.Select(0, Me.CódigoPostalTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.CódigoPostalTextBox, "El CÓDIGO POSTAL no puede estar vacío")

        End If
    End Sub

    Private Sub CódigoPostalTextBox_Validated(sender As Object, e As EventArgs) Handles CódigoPostalTextBox.Validated
        Me.ErrorProvider1.SetError(Me.CódigoPostalTextBox, "")
    End Sub

    Private Sub LocalidadTextBox_Validating(sender As Object, e As CancelEventArgs) Handles LocalidadTextBox.Validating
        If Me.LocalidadTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.LocalidadTextBox.Text = "SIN LOCALIDAD"
            Me.LocalidadTextBox.Select(0, Me.LocalidadTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.LocalidadTextBox, "La LOCALIDAD no puede estar vacía")

        End If
    End Sub

    Private Sub LocalidadTextBox_Validated(sender As Object, e As EventArgs) Handles LocalidadTextBox.Validated
        Me.ErrorProvider1.SetError(Me.LocalidadTextBox, "")
    End Sub

    Private Sub FormasPagoComboBox_Validating(sender As Object, e As CancelEventArgs) Handles FormasPagoComboBox.Validating
        If IsNothing(Me.FormasPagoComboBox.SelectedValue) Then
            e.Cancel = True
            Me.FormasPagoComboBox.SelectedIndex = 0
            Me.FormasPagoComboBox.Select(0, Me.FormasPagoComboBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.FormasPagoComboBox, "La FORMA DE PAGO no puede estar vacía")
        End If
    End Sub

    Private Sub FormasPagoComboBox_Validated(sender As Object, e As EventArgs) Handles FormasPagoComboBox.Validated
        Me.ErrorProvider1.SetError(Me.FormasPagoComboBox, "")
    End Sub

    Private Sub CuentasBancariasComboBox_Validating(sender As Object, e As CancelEventArgs) Handles CuentasBancariasComboBox.Validating
        If Not IsNothing(Me.FormasPagoComboBox.SelectedValue) AndAlso
            CInt(Me.FormasPagoComboBox.SelectedValue) = DOMICILIADO AndAlso
            IsNothing(Me.CuentasBancariasComboBox.SelectedValue) Then
            e.Cancel = True
            Me.CuentasBancariasComboBox.SelectedIndex = 0
            Me.CuentasBancariasComboBox.Select(0, Me.CuentasBancariasComboBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.CuentasBancariasComboBox, "La CUENTA BANCARIA no puede estar vacía")
        End If
    End Sub

    Private Sub CuentasBancariasComboBox_Validated(sender As Object, e As EventArgs) Handles CuentasBancariasComboBox.Validated
        Me.ErrorProvider1.SetError(Me.CuentasBancariasComboBox, "")
    End Sub

    Private Sub DatosBancariosTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DatosBancariosTextBox.Validating
        If Not IsNothing(Me.FormasPagoComboBox.SelectedValue) AndAlso
            CInt(Me.FormasPagoComboBox.SelectedValue) = DOMICILIADO AndAlso
           Me.DatosBancariosTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.DatosBancariosTextBox.Text = "ES12777788889999"
            Me.DatosBancariosTextBox.Select(0, Me.DatosBancariosTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.DatosBancariosTextBox, "El código IBAN no puede estar vacío")

        End If
    End Sub

    Private Sub DatosBancariosTextBox_Validated(sender As Object, e As EventArgs) Handles DatosBancariosTextBox.Validated
        Me.ErrorProvider1.SetError(Me.DatosBancariosTextBox, "")
    End Sub
    ''' <summary>
    ''' Crea un nuevo Cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClientesBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles ClientesBindingSource.AddingNew

        f = New frmAltaCuenta
        f.Código = CMódulo.ClaveNuevoCliente(My.Settings.BDContabilidadConnectionString)
        f.CódigoCuentaTextBox.Enabled = False
        f.CódigoCuentaMaestra = 430
        f.idCuentaPerdidasyGanancias = 0
        f.PérdidasyGananciasComboBox.Enabled = False
        f.idCuentaBalanceResultados = 13
        f.BalanceSituaciónComboBox.Enabled = False
        f.Nombre = Me.NombreTextBox.Text

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click,
BindingNavigatorMovePreviousItem.Click, BindingNavigatorMoveLastItem.Click, BindingNavigatorMoveFirstItem.Click

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                If Me.ValidateChildren Then

                    Try

                        Me.ClientesBindingSource.EndEdit()
                        Me.ClientesTableAdapter.Update(Me.BDContabilidadGMELO.Clientes)

                    Catch ex As Exception

                        CMódulo.MsgErrorCrítico(ex.Message)
                        Exit Sub

                    End Try

                    If Me.BDContabilidadGMELO.HasChanges = False Then

                        MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)
                        Exit Sub

                    End If

                Else

                    MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)
                    Exit Sub
                    '''''kike Buscar forma de cancelar movimiento

                End If

            End If

        End If

        'Me.VoyACerrar = True

    End Sub

    Private Sub ClientesBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles ClientesBindingSource.CurrentItemChanged

        'Se Cancela el alta del proveedor si se ha abandonado la creación de cuenta
        If Not IsNothing(Me.f) AndAlso Me.f.CanceladaAltaCuenta Then

            Me.f.CanceladaAltaCuenta = False

            With Me.ClientesBindingSource

                .CancelEdit()
                .ResetBindings(False)

            End With

        End If

    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click


        If CMódulo.MsgPregunta("¿Seguro que quiere borrar el cliente " + Me.NombreTextBox.Text.Trim + ". Se borrará también la cuenta en contabilidad.") = MsgBoxResult.Yes Then

            Me.ClientesBindingSource.RemoveCurrent()

        End If

    End Sub

    Public Function EsPersonaFísica(prmTipo As eTipoDocumento) As Boolean

        If prmTipo = eTipoDocumento.Ninguno OrElse prmTipo = eTipoDocumento.NIF OrElse prmTipo = eTipoDocumento.NIE OrElse
            prmTipo = eTipoDocumento.Pasaporte Then

            Return True

        End If

        Return False

    End Function

End Class