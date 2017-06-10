Imports System.ComponentModel

<Bindable(True)>
Public Class CTipoDocumento



    Private mÍndice As eTipoDocumento
    Private mNombre As String

    Sub New(prmÍndice As eTipoDocumento, prmNombre As String)

        Me.mÍndice = prmÍndice
        Me.mNombre = prmNombre

    End Sub
    <Bindable(True)>
    Public ReadOnly Property Tipo As String
        Get
            Return Me.mNombre
        End Get
    End Property
    <Bindable(True)>
    Public ReadOnly Property Índice As Integer
        Get
            Return Me.mÍndice
        End Get
    End Property

End Class
