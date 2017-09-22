Imports System.Data.SqlClient
Imports CBiblioteca.MDLMensajes

Public Module MDLProcedimientosAlmacenados

    Public Function ExisteCuenta(ByVal prmConnectionString As String, Cta As Integer) As Boolean

        ExisteCuenta = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ExisteCuenta", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@CTA",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = Cta,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@EXISTE",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ExisteCuenta = MiSqlCMD.Parameters("@EXISTE").Value

        Catch ex As Exception

            MsgErrorCrítico("ExisteCuenta " + ex.Message)

        End Try

        Return ExisteCuenta


    End Function

    Public Function ExisteAsientoConJustificante(ByVal prmConnectionString As String, Justificante As String) As Boolean

        ExisteAsientoConJustificante = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ExisteAsientoConJustificante", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@JUSTIFICANTE",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Input,
                .Value = Justificante,
                .Size = Justificante.Trim.Length
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@EXISTE",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ExisteAsientoConJustificante = MiSqlCMD.Parameters("@EXISTE").Value

        Catch ex As Exception

            MsgErrorCrítico("ExisteAsientoConJustificante " + Justificante.ToString + " " + ex.Message)

        End Try

        Return ExisteAsientoConJustificante


    End Function

    Public Function NúmeroNuevaFactura(ByVal prmConnectionString As String, año As Integer) As String

        NúmeroNuevaFactura = "111/1111"

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevaFactura", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm As New SqlParameter With {
                .ParameterName = "@NUM_FAC",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Output,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm)

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@ANNO",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = año,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            NúmeroNuevaFactura = MiSqlCMD.Parameters("@NUM_FAC").Value

        Catch ex As Exception

            MsgErrorCrítico("NúmeroNuevaFactura " + ex.Message)

        End Try

        Return NúmeroNuevaFactura

    End Function

    Public Function NúmeroNuevoAsiento(ByVal prmConnectionString As String) As Integer

        Dim NúmeroAsiento As Integer = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevoAsiento", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm As New SqlParameter With {
                .ParameterName = "@NUM_ASIENTO",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.ReturnValue,
                .Value = 0
            }

            MiSqlCMD.Parameters.Add(prm)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            NúmeroAsiento = CInt(MiSqlCMD.Parameters("@NUM_ASIENTO").Value)

        Catch ex As Exception

            MsgErrorCrítico("NúmeroNuevoAsiento " + ex.Message)

        End Try

        Return NúmeroAsiento

    End Function
    Public Function ClaveNuevoProveedor(ByVal prmConnectionString As String, Optional ClaveCuenta As Integer = 0) As Integer

        Dim ClaveProveedor As Integer = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ClaveNuevoProveedor", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm As New SqlParameter With {
                .ParameterName = "@Código",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.ReturnValue,
                .Value = 0
            }

            MiSqlCMD.Parameters.Add(prm)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ClaveProveedor = CInt(MiSqlCMD.Parameters("@Código").Value)

        Catch ex As Exception

            MsgErrorCrítico("ClaveNuevoProveedor " + ex.Message)

        End Try

        Return ClaveProveedor

    End Function

    Public Function ClaveNuevoCliente(ByVal prmConnectionString As String, Optional ClaveCuenta As Integer = 0) As Integer

        Dim ClaveCliente As Integer = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ClaveNuevoCliente", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm As New SqlParameter With {
                .ParameterName = "@Código",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.ReturnValue,
                .Value = 0
            }

            MiSqlCMD.Parameters.Add(prm)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ClaveCliente = CInt(MiSqlCMD.Parameters("@Código").Value)

        Catch ex As Exception

            MsgErrorCrítico("ClaveNuevoCliente " + ex.Message)

        End Try

        Return ClaveCliente

    End Function

    Public Function IdAsientoConJustificante(ByVal prmConnectionString As String, Justificante As String) As Integer

        IdAsientoConJustificante = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("idAsientoConJustificante", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@JUSTIFICANTE",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Input,
                .Value = Justificante,
                .Size = Justificante.Trim.Length
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@ID",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Output
            }

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            IdAsientoConJustificante = MiSqlCMD.Parameters("@ID").Value

        Catch ex As Exception

            MsgErrorCrítico("IdAsientoConJustificante " + ex.Message)

        End Try

        Return IdAsientoConJustificante

    End Function

    Public Function IdFacturaConNúmero(ByVal prmConnectionString As String, Número As String) As Integer

        IdFacturaConNúmero = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("idFacturaConNúmero", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@NÚMERO",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Input,
                .Value = Número,
                .Size = Número.Trim.Length
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@ID",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Output
            }

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            IdFacturaConNúmero = MiSqlCMD.Parameters("@ID").Value

        Catch ex As Exception

            MsgErrorCrítico("IdFacturaConNúmero " + ex.Message)

        End Try

        Return IdFacturaConNúmero

    End Function

    Public Function NúmeroNuevoApunte(ByVal prmConnectionString As String, NúmeroAsiento As Integer, TipoApunte As String) As Integer

        Dim NúmeroApunte As Integer = -1
        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevoApunte", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm As New SqlParameter()

            With prm

                .ParameterName = "@Tipo"
                .DbType = SqlDbType.VarChar
                .Direction = ParameterDirection.Input
                .Value = TipoApunte

            End With

            MiSqlCMD.Parameters.Add(prm)

            Dim prm1 As New SqlParameter()

            With prm1

                .ParameterName = "@NumAsiento"
                .DbType = SqlDbType.Int
                .Direction = ParameterDirection.Input
                .Value = NúmeroAsiento

            End With

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            With prm2

                .ParameterName = "@NumApunte"
                .DbType = SqlDbType.Int
                .Direction = ParameterDirection.Output
                .Value = 0

            End With

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteScalar()
            myConn.Close()
            NúmeroApunte = CInt(MiSqlCMD.Parameters("@NumApunte").Value)

        Catch ex As Exception

            MsgErrorCrítico("NúmeroNuevoApunte " + ex.Message)

        End Try

        Return NúmeroApunte

    End Function

    Public Function BorrarFacturaEmitida(ByVal prmConnectionString As String, id As Integer) As Boolean

        BorrarFacturaEmitida = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("BorrarFacturaEmitida", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@id",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = id,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@Ok",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }
            'prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            BorrarFacturaEmitida = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            MsgErrorCrítico("BorrarFacturaEmitida " + ex.Message)

        End Try

        Return BorrarFacturaEmitida


    End Function

    Public Function MarcarContabilizado(ByVal prmConnectionString As String, id As Integer, Tipo As String) As Boolean

        MarcarContabilizado = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("ActualizarContabilidad", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@id",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = id,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@Tipo",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Input,
                .Value = Tipo
            }

            MiSqlCMD.Parameters.Add(prm2)

            Dim prm3 As New SqlParameter With {
                .ParameterName = "@Ok",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }
            'prm3.Value = Tipo

            MiSqlCMD.Parameters.Add(prm3)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            MarcarContabilizado = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            MsgErrorCrítico("MarcarContabilizado " + ex.Message)

        End Try

        Return MarcarContabilizado

    End Function

    Public Function MarcarPagado(ByVal prmConnectionString As String, id As Integer, Tipo As String) As Boolean

        MarcarPagado = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("ActualizarPagos", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@id",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = id,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@Tipo",
                .DbType = SqlDbType.VarChar,
                .Direction = ParameterDirection.Input,
                .Value = Tipo
            }

            MiSqlCMD.Parameters.Add(prm2)

            Dim prm3 As New SqlParameter With {
                .ParameterName = "@Ok",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }
            'prm3.Value = Tipo

            MiSqlCMD.Parameters.Add(prm3)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            MarcarPagado = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            MsgErrorCrítico("MarcarPagado " + ex.Message)

        End Try

        Return MarcarPagado

    End Function
    Public Function BorrarAsiento(ByVal prmConnectionString As String, id As Integer) As Boolean

        BorrarAsiento = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("BorrarAsientos", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@id",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = id,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter With {
                .ParameterName = "@Ok",
                .DbType = SqlDbType.Bit,
                .Direction = ParameterDirection.Output
            }
            'prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            BorrarAsiento = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            MsgErrorCrítico("BorrarAsiento " + ex.Message)

        End Try

        Return BorrarAsiento


    End Function
    Public Sub ActualizarDatosCuenta(ByVal prmConnectionString As String, cuenta As Integer)

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("PrepararLibroMayor", myConn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim prm1 As New SqlParameter With {
                .ParameterName = "@Cuenta",
                .DbType = SqlDbType.Int,
                .Direction = ParameterDirection.Input,
                .Value = cuenta,
                .Size = 8
            }

            MiSqlCMD.Parameters.Add(prm1)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()



        Catch ex As Exception

            MsgErrorCrítico("BorrarAsiento " + ex.Message)

        End Try

    End Sub

End Module
