Public Class CServidor



    Private Property mÍndice As eServidores
    Private Property mNombre As String
    Private Property mCadenaConexión As String
    Private Property mBDConexión As SqlClient.SqlConnection

    Sub New(prmÍndice As eServidores, prmNombre As String)

        Me.Índice = prmÍndice
        Me.mNombre = prmNombre

    End Sub

    Public Property Índice As Integer
        Get
            Return Me.mÍndice
        End Get
        Set(value As Integer)
            Me.mÍndice = value
            Me.mCadenaConexión = Me.ObtenerCadenaConexión(Me.mÍndice)
            Me.mBDConexión = ObtenerConexión(Me.mCadenaConexión)
        End Set
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return Me.mNombre
        End Get
    End Property

    Public ReadOnly Property CadenaConexión As String
        Get
            Return Me.mCadenaConexión
        End Get
    End Property

    Public ReadOnly Property Conexión As SqlClient.SqlConnection
        Get
            Return Me.mBDConexión
        End Get
    End Property

    Public Function ObtenerCadenaConexión(índice As eServidores) As String

        Dim cnx As String

        If índice = eServidores.NUBE Then

            cnx = "Server=tcp:orvxtk6jfu.database.windows.net,1433;Database=BDContabilidadGMELO;User ID=rafa_lopez1@orvxtk6jfu;Password=9906RlmRlm;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;"

        Else

            Dim cnx1 As String = "Data Source="
            ' Dim cnx3 As String = "\SQLEXPRESS;Initial Catalog=BDContabilidadGMELO *;Integrated Security=True"
            Dim cnx3 As String = ";Initial Catalog=BDContabilidadGMELO *;Integrated Security=True"
            Dim cnx2 As String = ""
            Select Case índice
                Case eServidores.PCPAPA
                    cnx2 = "PCPAPA"
                Case eServidores.PCRLM
                    cnx2 = "PCRLM"
                Case eServidores.PORTATIL
                    cnx2 = "PORTATIL"
            End Select

            cnx = cnx1 + cnx2 + cnx3

        End If

        Return cnx

    End Function

    Private Function ObtenerConexión(prmCadenaConexión As String)
        Try

            Dim Conexión As New System.Data.SqlClient.SqlConnection(prmCadenaConexión)
            Return Conexión

        Catch ex As SqlClient.SqlException

            Throw New Exception("Clase CSERVIDOR: " + ex.Message + ". La aplicación se cerrará.")

        End Try

        Return Nothing

    End Function

End Class
