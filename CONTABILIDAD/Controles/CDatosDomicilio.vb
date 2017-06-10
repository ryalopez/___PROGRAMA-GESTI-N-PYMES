Imports System.ComponentModel

''' <summary>
''' Enumeración de los tipos de propietario para el Control Domicilio
''' </summary>
''' <remarks></remarks>
Public Enum DomicilioTipoPropietario
    Cliente = 0
    Sucursal = 1
    Empleado = 2
End Enum

<Browsable(True), Bindable(True, BindingDirection.TwoWay)> _
Public Class CDatosDomicilio
    Inherits BindingSource    

    Private mTipoPropietario As DomicilioTipoPropietario
    Private mIdPropietario As Integer
    Private mCalle As String = ""
    Private mNúmero As String = ""
    Private mBloque As String = ""
    Private mEscalera As String = ""
    Private mPiso As String = ""
    Private mPuerta As String = ""
    Private mPais As String = ""
    Private mProvincia As Integer = 0
    Private mMunicipio As String = ""
    Private mCodPostal As String = ""

    Public Sub New()
        MyBase.New()

    End Sub

    ''' <summary>
    ''' Tipo de Propietario
    ''' </summary>
    ''' <value>Enum Tipo de Propietario</value>
    ''' <returns>Integer</returns>
    ''' <remarks>No puede ser nulo</remarks>
    <Description("Tipo de propietario del domicilio"), Browsable(True), Category("Domicilio"), Bindable(True)> _
    Public Property TipoPropietario As DomicilioTipoPropietario
        Get
            Return Me.mTipoPropietario
        End Get
        Set(value As DomicilioTipoPropietario)
            Me.mTipoPropietario = value
        End Set
    End Property

    ''' <summary>
    ''' id de la entidad propietaria del domicilio: Cliente, Sucursal, Empleado, etc...
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks>No puede ser nulo</remarks>
    <Description("Id de la entidad propietaria del domicilio: Cliente, Sucursal, Empleado, etc..."), Category("Domicilio"), Bindable(True)> _
    Public Property IdPropietario As Integer
        Get
            Return mIdPropietario
        End Get
        Set(value As Integer)
            mIdPropietario = value
        End Set
    End Property

    ''' <summary>
    ''' Calle del control domicilio
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks>No puede ser nula</remarks>
    <Description("Calle del domicilio"), Category("Domicilio"), Bindable(True)> _
    Public Property Calle As String
        Get
            Return mCalle
        End Get
        Set(value As String)
            mCalle = value
        End Set
    End Property

    <Description("Número de la calle"), Category("Domicilio"), Bindable(True)>
    Public Property Número As String
        Get
            Return mNúmero
        End Get
        Set(value As String)
            mNúmero = value
        End Set
    End Property

    <Description("Bloque del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Bloque As String
        Get
            Return mBloque
        End Get
        Set(value As String)
            mBloque = value
        End Set
    End Property

    <Description("Escalera del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Escalera As String
        Get
            Return mEscalera
        End Get
        Set(value As String)
            mEscalera = value
        End Set
    End Property

    <Description("Piso del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Piso As String
        Get
            Return mPiso
        End Get
        Set(value As String)
            mPiso = value
        End Set
    End Property

    <Description("Puerta del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Puerta As String
        Get
            Return mPuerta
        End Get
        Set(value As String)
            mPuerta = value
        End Set
    End Property

    <Description("Código de pais del domicilio"), Category("Domicilio"), Bindable(True), DefaultValue("ES")> _
    Public Property Pais As String
        Get

            Return mPais

        End Get
        Set(value As String)

            mPais = value

        End Set
    End Property

    <Description("Código de provincia del domicilio"), Category("Domicilio"), Bindable(True), DefaultValue("1")>
    Public Property Provincia As String
        Get
            Return mProvincia
        End Get
        Set(value As String)
            If Not IsNothing(value) AndAlso value <> "" Then
                mProvincia = value
            End If
        End Set
    End Property

    <Description("Municipio del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Municipio As String
        Get
            Return mMunicipio
        End Get
        Set(value As String)
            mMunicipio = value
        End Set
    End Property

    <Description("Código postal del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property CodPostal As String
        Get
            Return mCodPostal
        End Get
        Set(value As String)
            mCodPostal = value
        End Set
    End Property

End Class
