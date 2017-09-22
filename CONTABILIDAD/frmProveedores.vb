Imports System
Imports Microsoft.VisualBasic
Imports System.ComponentModel

Imports CBiblioteca

Public Class frmProveedores
    '
    ' Este es el valor que tiene el pago domiciliado en la tabla Formas de Pago de la Base de Datos
    '
    Private VoyACerrar As Boolean = False
    Private Const DOMICILIADO As Integer = 5
    Friend WithEvents F As FrmAltaCuenta

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)

        Me.FormasPagoTableAdapter.Fill(Me.BDContabilidadGMELO.FormasPago)

        Me.CuentasGastoTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasGasto)

        Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)

        Me.Text = My.Resources.Título + " - Gestión de PROVEEDORES"

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click

        If Me.ValidateChildren() Then

            Try

                Me.ProveedoresBindingSource.EndEdit()
                ProveedoresTableAdapter.Update(Me.BDContabilidadGMELO.Proveedores)

            Catch ex As Exception

                MDLMensajes.MsgErrorCrítico(ex.Message)
                Exit Sub

            End Try

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If
        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If
    End Sub

    Private Sub FrmProveedores_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.ValidateChildren()

                Try

                    Me.ProveedoresBindingSource.EndEdit()
                    Me.ProveedoresTableAdapter.Update(Me.BDContabilidadGMELO)

                Catch ex As Exception

                    MDLMensajes.MsgAdvertencia(ex.Message + " " + ex.HelpLink)
                    Exit Sub

                End Try

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

        e.Cancel = False

    End Sub

    Private Sub BtnListarProveedores_Click(sender As Object, e As EventArgs) Handles btnListarProveedores.Click

        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)

        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    .NombreInforme = "rptProveedores.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""

        '    Listado.ShowDialog()

        'End With

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

    Private Sub TiposDocumentoIdentidadComboBox_Validating(sender As Object, e As CancelEventArgs) Handles TiposDocumentoIdentidadComboBox.Validating

        If IsNothing(Me.TiposDocumentoIdentidadComboBox.SelectedValue) Then
            e.Cancel = True
            Me.TiposDocumentoIdentidadComboBox.SelectedIndex = 0
            Me.TiposDocumentoIdentidadComboBox.Select(0, Me.TiposDocumentoIdentidadComboBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.TiposDocumentoIdentidadComboBox, "El TIPO DE DOCUMENTO DE IDENTIDAD no puede estar vacío")
        End If

    End Sub

    Private Sub TiposDocumentoIdentidadComboBox_Validated(sender As Object, e As EventArgs) Handles TiposDocumentoIdentidadComboBox.Validated
        Me.ErrorProvider1.SetError(Me.TiposDocumentoIdentidadComboBox, "")
    End Sub

    Private Sub DocumentoIdentidadTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DocumentoIdentidadTextBox.Validating

        If Me.DocumentoIdentidadTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.DocumentoIdentidadTextBox.Text = "12345678A"
            Me.DocumentoIdentidadTextBox.Select(0, Me.DocumentoIdentidadTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "El DOCUMENTO DE IDENTIDAD no puede estar vacío")

        End If

    End Sub
    Private Sub DocumentoIdentidadTextBox_Validated(sender As Object, e As EventArgs) Handles DocumentoIdentidadTextBox.Validated

        Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "")

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

    Private Sub Código4ComboBox_Validating(sender As Object, e As CancelEventArgs) Handles Código4ComboBox.Validating
        If IsNothing(Me.Código4ComboBox.SelectedValue) Then
            e.Cancel = True
            Me.Código4ComboBox.SelectedIndex = 0
            Me.Código4ComboBox.Select(0, Me.Código4ComboBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.Código4ComboBox, "La CUENTA ADMINISTRATIVA no puede estar vacía")
        End If
    End Sub

    Private Sub Código4ComboBox_Validated(sender As Object, e As EventArgs) Handles Código4ComboBox.Validated
        Me.ErrorProvider1.SetError(Me.Código4ComboBox, "")
    End Sub

    Private Sub Código4ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Código4ComboBox.TextChanged
        If Me.NombreTextBox.Text.Trim.Length = 0 Then

            Me.NombreTextBox.Text = Me.Código4ComboBox.Text

        End If
    End Sub

    Private Sub Código6ComboBox_Validating(sender As Object, e As CancelEventArgs) Handles Código6ComboBox.Validating
        If IsNothing(Me.Código6ComboBox.SelectedValue) Then
            e.Cancel = True
            Me.Código6ComboBox.SelectedIndex = 0
            Me.Código6ComboBox.Select(0, Código6ComboBox.Text.Length)
            ErrorProvider1.SetError(Me.Código6ComboBox, "La CUENTA DE GASTO no puede estar vacía")
        End If
    End Sub

    Private Sub Código6ComboBox_Validated(sender As Object, e As EventArgs) Handles Código6ComboBox.Validated
        Me.ErrorProvider1.SetError(Me.Código6ComboBox, "")
    End Sub

    Private Sub ProveedoresBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles ProveedoresBindingSource.AddingNew
        F = New FrmAltaCuenta With {
            .Código = MDLProcedimientosAlmacenados.ClaveNuevoProveedor(My.Settings.BDContabilidadConnectionString)
        }
        F.CódigoCuentaTextBox.Enabled = False
        F.CódigoCuentaMaestra = 4100
        F.idCuentaPerdidasyGanancias = 0
        F.PérdidasyGananciasComboBox.Enabled = False
        F.idCuentaBalanceResultados = 52
        F.BalanceSituaciónComboBox.Enabled = False
        F.Nombre = "ESCRIBA AQUI EL NOMBRE DEL PROVEEDOR"
        If F.ShowDialog(Me) = DialogResult.OK Then

            Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)
            Me.Código4ComboBox.Select()

        End If

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click,
BindingNavigatorMovePreviousItem.Click, BindingNavigatorMoveLastItem.Click, BindingNavigatorMoveFirstItem.Click

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.ValidateChildren()


                Try

                    Me.ProveedoresBindingSource.EndEdit()
                    Me.ProveedoresTableAdapter.Update(Me.BDContabilidadGMELO)



                Catch ex As Exception

                    MDLMensajes.MsgAdvertencia(ex.Message + " " + ex.HelpLink)
                    Exit Sub

                End Try
                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If
            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub ProveedoresBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles ProveedoresBindingSource.CurrentItemChanged

        'Se Cancela el alta del proveedor si se ha abandonado la creación de cuenta
        If Not IsNothing(Me.F) AndAlso Me.F.CanceladaAltaCuenta Then

            Me.F.CanceladaAltaCuenta = False

            With Me.ProveedoresBindingSource

                .CancelEdit()
                .ResetBindings(False)

            End With

        End If

    End Sub


    Private Sub BtnBorrarProveedor_Click(sender As Object, e As EventArgs) Handles btnBorrarProveedor.Click


        If MDLMensajes.MsgPregunta("¿Seguro que quiere borrar el proveedor " + Me.NombreTextBox.Text.Trim + ". Se borrará también la cuenta en contabilidad.") = MsgBoxResult.Yes Then

            Me.ProveedoresBindingSource.RemoveCurrent()

        End If

    End Sub

End Class