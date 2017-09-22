Public Class CCambioUI
    Inherits EventArgs

    Private mNombrePropiedad As String
    Private mValorViejo As String
    Private mValorNuevo As String

    Sub New(ByVal prmNombrePropiedad, prmValorViejo, prmValorNuevo)
        MyBase.New()

        Me.mNombrePropiedad = prmNombrePropiedad
        Me.mValorViejo = prmValorViejo
        Me.mValorNuevo = prmValorNuevo

    End Sub

    Public Property NombrePropiedad As String
        Get
            Return Me.mNombrePropiedad
        End Get
        Set(value As String)
            Me.mNombrePropiedad = value
        End Set
    End Property

    Public ReadOnly Property ValorViejo As String
        Get
            Return Me.mvalorviejo
        End Get
    End Property

    Public Property ValorNuevo As String
        Get
            Return Me.mValorNuevo
        End Get
        Set(value As String)
            Me.mValorNuevo = value
        End Set
    End Property
End Class
