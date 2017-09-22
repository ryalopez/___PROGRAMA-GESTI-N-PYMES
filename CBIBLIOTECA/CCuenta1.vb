<Serializable()>
Public Class CCuenta1

    Dim mCódigo As Integer

    Sub New(ByVal prmCódigo As Integer)

        Me.mCódigo = prmCódigo
        MsgBox("Creada la cuenta")
    End Sub

    Public ReadOnly Property Código As Integer
        Get
            Return Me.mCódigo
        End Get
    End Property

End Class
