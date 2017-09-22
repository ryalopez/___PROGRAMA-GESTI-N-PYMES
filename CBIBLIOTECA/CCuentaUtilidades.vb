


<Serializable()>
Public Class CCuentaUtilidades
    Implements System.ComponentModel.INotifyPropertyChanged

    ''' <summary>
    ''' Fichero en el que va a salvar la clase
    ''' </summary>
    Public Const NombreFichero As String = "..\..\MiCuenta.xml"

    Public Property Código As String
    Public Property Denominación As String

    Private mCódigoBS As Integer

    Public Property CódigoBS As Integer
        Get
            Return Me.mCódigoBS
        End Get
        Set(ByVal value As Integer)
            Me.mCódigoBS = value
            RaiseEvent CambioCuentaBS(Me,
          New System.ComponentModel.PropertyChangedEventArgs("CódigoBS"))
        End Set
    End Property

    <NonSerialized>
    Event CambioCuentaBS As System.ComponentModel.PropertyChangedEventHandler _
      Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Public Sub New(ByVal prmCódigo As String,
               ByVal prmDenominación As String,
               ByVal prmCódigoBS As Integer)

        Me.Código = prmCódigo
        Me.Denominación = prmDenominación

        Me.mCódigoBS = prmCódigoBS

    End Sub

End Class
