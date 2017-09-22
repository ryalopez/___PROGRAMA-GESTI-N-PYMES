Imports System.ComponentModel

<Bindable(True)>
Public Class CPrefijoCuenta

    Private mÍndice As EPrefijosCuenta
    Private mNombre As String

    Sub New(prmÍndice As EPrefijosCuenta, prmNombre As String)

        Me.mÍndice = prmÍndice
        Me.mNombre = prmNombre

    End Sub

    <Bindable(True)>
    Public ReadOnly Property Prefijo As String
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
