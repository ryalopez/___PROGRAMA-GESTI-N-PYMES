Imports System
Public Class CServidor



    Private Property mÍndice As EServidores
    Private Property mNombre As String
    Private Property mCadenaConexión As String
    Private Property mBDConexión As SqlClient.SqlConnection

    Sub New(prmÍndice As EServidores, prmNombre As String)

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

    Public Function ObtenerCadenaConexión(índice As EServidores) As String

        Dim cnx As String

        Dim cnx1 As String = "Data Source="

        Dim cnx2 As String = ""
        Select Case índice
            Case EServidores.PCPAPA
                cnx2 = "PCPAPA"
            Case EServidores.PCRLM
                cnx2 = "PCRLM"
            Case EServidores.PORTATIL
                cnx2 = "PORTATIL"
        End Select

        Dim cnx3 As String = ";Initial Catalog=BDContabilidadGMELO;Integrated Security=True"

        cnx = cnx1 + cnx2 + cnx3

        Return cnx

    End Function

    Private Function ObtenerConexión(prmCadenaConexión As String)
        Try

            'Dim Conexión As New System.Data.SqlClient.SqlConnection(prmCadenaConexión)
            Return New SqlClient.SqlConnection(prmCadenaConexión)

        Catch ex As SqlClient.SqlException

            Throw New Exception("Clase CSERVIDOR: " + ex.Message + ". La aplicación se cerrará.")

        End Try

        Return Nothing

    End Function

End Class
