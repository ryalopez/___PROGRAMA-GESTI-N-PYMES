Imports System.ComponentModel
Imports Biblioteca

'System.ComponentModel.LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "LookupMember")>
'<ComplexBindingProperties("TipoDocumento", "NúmeroDocumento", "DataSource", "DataMember")>
'<ComplexBindingProperties("DataSource", "DataMember")>
Public Class ctlDocumentoIdentidad

    <Bindable(True)>
    Public Property NúmeroDocumento As String
        Get
            Return Me.DocumentoIdentidadTextBox.Text
        End Get
        Set(ByVal value As String)
            Me.DocumentoIdentidadTextBox.Text = value
        End Set
    End Property

    <Bindable(True)>
    Public Property TiposDocumentoBindingSource() As BindingSource
        Get
            Return Me.TiposDocumentoIdentidadComboBox.DataSource
        End Get
        Set(ByVal value As BindingSource)
            Me.TiposDocumentoIdentidadComboBox.DataSource = value
        End Set
    End Property

    Public Property SelectedValue() As Object
        Get
            Return TiposDocumentoIdentidadComboBox.SelectedValue
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                TiposDocumentoIdentidadComboBox.SelectedValue = value
            End If
        End Set
    End Property

    Public Property DisplayMember() As String
        Get
            Return TiposDocumentoIdentidadComboBox.DisplayMember
        End Get
        Set(ByVal value As String)
            TiposDocumentoIdentidadComboBox.DisplayMember = value
        End Set
    End Property

    Public Property ValueMember() As String
        Get
            Return TiposDocumentoIdentidadComboBox.ValueMember
        End Get
        Set(ByVal value As String)
            TiposDocumentoIdentidadComboBox.ValueMember = value
        End Set
    End Property

    Private Sub CtlDocumentoIdentidad_Validated(sender As Object, e As EventArgs) Handles Me.Validated

        Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "")

    End Sub

    Private Sub CtlDocumentoIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        If Me.DocumentoIdentidadTextBox.Text.Trim.Length = 0 Then

            e.Cancel = True
            Me.DocumentoIdentidadTextBox.Text = "12345678A"
            Me.DocumentoIdentidadTextBox.Select(0, Me.DocumentoIdentidadTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "")
            Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "El DOCUMENTO DE IDENTIDAD no puede estar vacío")

        ElseIf Not DocumentoVálido() Then

            e.Cancel = True
            Me.DocumentoIdentidadTextBox.Select(0, Me.DocumentoIdentidadTextBox.Text.Length)
            Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "")
            Me.ErrorProvider1.SetError(Me.DocumentoIdentidadTextBox, "El valor del DOCUMENTO DE IDENTIDAD no es válido")

        End If
    End Sub

    Private Function DocumentoVálido() As Boolean

        Select Case CType(Me.TiposDocumentoIdentidadComboBox.SelectedValue, eTipoDocumento)

            Case eTipoDocumento.Ninguno

                Return True

            Case eTipoDocumento.NIF_DNI

                Return CMódulo.Validar_DNI_NIF(Me.NúmeroDocumento)

            Case eTipoDocumento.CIF

                Return False

            Case eTipoDocumento.NIE

                Return CMódulo.Validar_NIE(Me.NúmeroDocumento)

            Case eTipoDocumento.Pasaporte

                Return False

        End Select

        Return False

    End Function

End Class
