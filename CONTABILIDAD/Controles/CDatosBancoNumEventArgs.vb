Imports System.ComponentModel

' Errores
''' <summary>
''' Enumeración de los errores en el Control de Datos Bancarios
''' </summary>
''' <remarks></remarks>
Public Enum BancosNumErrores
    Correcto = 0
    FaltaBanco = 1
    FaltaSucursal = 2
    FaltaDC = 3
    FaltaCCC = 4
    MalLongitudCCC = 5
End Enum

Public Class CDatosBancoNumEventArgs
    Inherits System.EventArgs

    Private mstrMessage As String
    Private mintError As BancosNumErrores

    <Description("Mensaje para mostrar el error")> _
    Property Mensaje() As String
        Get
            Return mstrMessage
        End Get
        Set(ByVal Value As String)
            mstrMessage = Value
        End Set
    End Property

    <Description("NúmeroError")> _
    Property NúmeroError() As BancosNumErrores
        Get
            Return mintError
        End Get
        Set(ByVal Value As BancosNumErrores)
            mintError = Value
        End Set
    End Property
End Class
