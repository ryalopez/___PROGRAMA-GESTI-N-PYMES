Imports System.ComponentModel


' Errores
''' <summary>
''' Enumeración de los errores en el Control Domicilio
''' </summary>
''' <remarks></remarks>
Public Enum DomicilioNúmerorError
    Correcto = 0
    FaltaCalle = 1
    FaltaMunicipio = 2
    FaltaCodPostal = 3
    FaltaOtrosDatos = 4
    FaltaProvincia = 5
    FaltaPais = 6
    MalLongitudCodPostal = 7

End Enum

''' <summary>
''' Argumentos para el evento que se produce al validar el Control Domicilio
''' </summary>
''' <remarks></remarks>
Public Class CDomicilioErrorEventArgs
    Inherits System.ComponentModel.CancelEventArgs

    Private mstrMessage As String
    Private mintError As DomicilioNúmerorError

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
    Property NúmeroError() As DomicilioNúmerorError
        Get
            Return mintError
        End Get
        Set(ByVal Value As DomicilioNúmerorError)
            mintError = Value
        End Set
    End Property

End Class
