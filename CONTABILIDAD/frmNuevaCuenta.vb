Imports System.Windows.Forms
Imports Biblioteca

Public Class frmNuevaCuenta

    Private miCnx As String
    Private miCtaMaestra As Integer

    Private CCuentaBindingSource As CCuenta
    Private TipoDocumentoBindingSource As BindingSource
    Private PrefijosCuentaBindingSource As BindingSource

    Public Sub New(prmStrConexión As String, prmCuentaMaesta As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.miCnx = prmStrConexión
        Me.miCtaMaestra = prmCuentaMaesta

    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ValidateChildren()
        'Me.DescripciónTextBox.Text = CType(Me.PrefijosCuentaComboBox.SelectedItem, CPrefijoCuenta).Prefijo.TrimEnd + ". " +
        '    Trim(Me.NombreRazónSocialTextBox.Text) + " " + Me.TiposDocumentoComboBox.SelectedText + " - " +
        '    Trim(Me.NúmeroDocumentoTextBox.Text)
        Me.DescripciónTextBox.Text = ". " +
            Trim(Me.Nombre_Razón_SocialTextBox.Text)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmNuevaCuenta_Validated(sender As Object, e As EventArgs)

        Me.DescripciónTextBox.Text = ""
        'If CType(Me.PrefijosCuentaComboBox.SelectedItem, CPrefijoCuenta).Índice <> ePrefijosCuenta.Ninguno Then
        '    Me.DescripciónTextBox.Text = Me.DescripciónTextBox.Text + Me.PrefijosCuentaComboBox.SelectedText.TrimEnd()
        'End If
        If Trim(Me.Nombre_Razón_SocialTextBox.Text).Length <> 0 Then
            Me.DescripciónTextBox.Text = Me.DescripciónTextBox.Text + ". " + Trim(Me.Nombre_Razón_SocialTextBox.Text)
        End If
        'If Me.NuevaCta.Esválido Then
        '+ ". " +
        '    Trim(Me.NombreRazónSocialTextBox.Text) + " " + Me.TiposDocumentoComboBox.SelectedText + " - " +
        '    Trim(Me.NúmeroDocumentoTextBox.Text)
        'End If

    End Sub

    Private Sub frmNuevaCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CCuentaBindingSource = New CCuenta(Me.miCnx, Me.miCtaMaestra)
        ' código cuenta
        Me.CódigoTextBox.DataBindings.Add("Text", Me.CCuentaBindingSource, "Código")
        ' descripción cuenta
        Me.DescripciónTextBox.DataBindings.Add("Text", Me.CCuentaBindingSource, "Denominación")
        ' nombre o razón social
        Me.Nombre_Razón_SocialTextBox.DataBindings.Add("Text", Me.CCuentaBindingSource, "Nombre_RazónSocial")
        ' Tipo de Documento
        Me.TipoDocumentoBindingSource = New BindingSource()
        Me.TipoDocumentoBindingSource.DataSource = CCuentaBindingSource.ListaTiposDocumento
        Me.TiposDocumentoComboBox.DataSource = Me.TipoDocumentoBindingSource
        Me.TiposDocumentoComboBox.DisplayMember = "Tipo"
        ' Número del Documento
        Me.ValorDocumentoTextBox.DataBindings.Add("Text", Me.CCuentaBindingSource, "ValorDocumento")
        ' Prefijo de la denominación de la cuenta
        Me.PrefijosCuentaBindingSource = New BindingSource()
        Me.PrefijosCuentaBindingSource.DataSource = CCuentaBindingSource.ListaPrefijos
        Me.PrefijosCuentaComboBox.DataSource = Me.PrefijosCuentaBindingSource
        Me.PrefijosCuentaComboBox.DisplayMember = "Prefijo"

    End Sub

    Private Sub CódigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CódigoTextBox.TextChanged

        CCuentaBindingSource.Código = CInt(CódigoTextBox.Text)

    End Sub

    Private Sub DenominaciónTextBox_TextChanged(sender As Object, e As EventArgs)

        CCuentaBindingSource.Denominación = DescripciónTextBox.Text

    End Sub

    Private Sub Nombre_RazónSocialTextBox_TextChanged(sender As Object, e As EventArgs)

        CCuentaBindingSource.Nombre_RazónSocial = Nombre_Razón_SocialTextBox.Text

    End Sub

    Private Sub ListaTiposDocumentoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TiposDocumentoComboBox.SelectedIndexChanged

        'MsgBox(CType(CType(sender, ComboBox).SelectedItem, CTipoDocumento).Tipo.ToString + " - " + CType(sender, ComboBox).SelectedValue.ToString)
        ' NIF - 1, etc....
        Me.CCuentaBindingSource.Prefijo = CType(CType(sender, ComboBox).SelectedItem, CTipoDocumento).Tipo.ToString
    End Sub


    'Private Sub NuevaCta_CambioUI(NombrePropiedad As Object, ByRef ValorViejo As Object, ValorNuevo As Object) Handles NuevaCta.CambioUI

    '    CMódulo.MsgInformativo("La propiedad " + NombrePropiedad.ToString + " cambia de " + ValorViejo.ToString + " a " + ValorNuevo.ToString)

    'End Sub
End Class
