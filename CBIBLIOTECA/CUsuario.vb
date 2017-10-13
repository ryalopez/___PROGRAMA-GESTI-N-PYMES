Imports System

Public Enum Autorizaciones
    ROOT = 1
    ADMIN = 2
    USUARIO = 3
    ANONIMO = 4
End Enum

<Serializable()>
Public Class CUsuario

    Private mConfigurado As Boolean
    Private mNombre As String
    Private mAutoridad As Autorizaciones
    Private mFecha As Date

    Sub New()

    End Sub

    Public Property Configurado As Boolean
        Get
            Return Me.mConfigurado
        End Get
        Set(value As Boolean)
            Me.mConfigurado = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return Me.mNombre
        End Get
        Set(value As String)
            Me.mNombre = value
        End Set
    End Property

    Public Property Autoridad As Autorizaciones
        Get
            Return Me.mAutoridad
        End Get
        Set(value As Autorizaciones)
            Me.mAutoridad = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return Me.mFecha
        End Get
        Set(value As Date)
            Me.mFecha = value
        End Set
    End Property

End Class
