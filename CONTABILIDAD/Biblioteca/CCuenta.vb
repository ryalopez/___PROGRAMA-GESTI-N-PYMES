Imports System.Data.SqlClient
Imports System.ComponentModel


Public Class CCuenta
    Implements System.ComponentModel.INotifyPropertyChanged

    Public Delegate Sub CambioUIEventHandler(sender As Object, e As CCambioUI)

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    Public Const LongitudCuentas As Integer = 6

    Private mCódigo As Integer
    Private mDenominación As String
    Private mNombre_Razón_Social As String
    Private mPrefijo As String
    Private mValorDocumentoIdentidad As String
    Private mDocumentoIdentidad As CDocumentoIdentidad

    Private mListaPrefijos As New List(Of CPrefijoCuenta)
    Private mListaTiposDocumento As New List(Of CTipoDocumento)

    Sub New(ByVal prmStrConexión As String, ByVal prmCuentaMaestra As Integer)

        Try

            Dim AnchoRelleno As Integer = LongitudCuentas - prmCuentaMaestra.ToString.Length

            Dim CódigoNuevaCuenta As String = ""

            Dim num As Integer = 0
            While True

                num += 1
                CódigoNuevaCuenta = prmCuentaMaestra.ToString + num.ToString.PadLeft(AnchoRelleno, "0"c)

                If Not CMódulo.ExisteCuenta(prmStrConexión, CódigoNuevaCuenta) Then

                    Exit While

                End If

            End While

            mCódigo = CInt(CódigoNuevaCuenta)
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("Código"))

            '
            ' Rellena las listas que son variables de clase
            '           
            For Each id As ePrefijosCuenta In System.Enum.GetValues(GetType(ePrefijosCuenta))

                mListaPrefijos.Add(New CPrefijoCuenta(id, System.Enum.GetName(GetType(ePrefijosCuenta), id)))

            Next

            For Each id As eTipoDocumento In System.Enum.GetValues(GetType(eTipoDocumento))

                mListaTiposDocumento.Add(New CTipoDocumento(id, System.Enum.GetName(GetType(eTipoDocumento), id)))

            Next

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("CCuenta " + ex.Message)

        End Try

    End Sub
    Public Property Código As Integer
        Get
            Return Me.mCódigo
        End Get
        Set(value As Integer)
            Me.mCódigo = value
            CalcularDenominación()
            RaiseEvent PropertyChanged(Me,
                New System.ComponentModel.PropertyChangedEventArgs("Código"))
        End Set
    End Property

    Public Property Denominación As String
        Get
            Return Me.mDenominación
        End Get
        Set(value As String)
            Me.mDenominación = value
            RaiseEvent PropertyChanged(Me,
                New System.ComponentModel.PropertyChangedEventArgs("Denominación"))
        End Set
    End Property

    Public Property Nombre_RazónSocial As String
        Get
            Return Me.mNombre_Razón_Social
        End Get
        Set(value As String)
            Me.mNombre_Razón_Social = value
            CalcularDenominación()
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("Denominación"))
        End Set
    End Property
    Public Property Prefijo As String
        Get
            Return Me.mPrefijo
        End Get
        Set(value As String)
            Me.mPrefijo = value
            CalcularDenominación()
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("Prefijo"))
        End Set
    End Property


    Public Property ValorDocumento As String
        Get
            Return Me.mValorDocumentoIdentidad
        End Get
        Set(value As String)
            Me.mValorDocumentoIdentidad = value
            CalcularDenominación()
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("ValorDocumento"))
        End Set
    End Property

    Public ReadOnly Property ListaTiposDocumento As List(Of CTipoDocumento)
        Get
            Return Me.mListaTiposDocumento
        End Get
    End Property
    Public ReadOnly Property ListaPrefijos As List(Of CPrefijoCuenta)
        Get
            Return Me.mListaPrefijos
        End Get
    End Property

    Sub CalcularDenominación()

        Me.mDenominación = ""
        If Me.Prefijo <> "" Then
            Me.mDenominación = Me.Prefijo
        End If
        If Me.mNombre_Razón_Social <> "" Then

            If Me.mDenominación <> "" Then
                Me.Denominación += ". " + Me.mNombre_Razón_Social
            Else
                Me.Denominación = Me.mNombre_Razón_Social
            End If
        End If
        If Me.mValorDocumentoIdentidad <> "" Then

            If Me.mDenominación <> "" Then
                Me.Denominación += ". " + Me.mValorDocumentoIdentidad
            Else
                Me.Denominación = Me.mValorDocumentoIdentidad
            End If
        End If

    End Sub
    'Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged

    'Event CambioDocumentoIdentidad As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    'Event CambioNombre_RazónSocial As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    'Event CambioPrefijoCuenta As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged



End Class

