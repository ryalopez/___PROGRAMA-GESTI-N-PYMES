Imports System.Xml
Imports System.Text
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized
'Imports Microsoft.Office.Interop
Imports System.Runtime.Serialization
'Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class CMódulo


    Public Shared Sub Main()

    End Sub


    Public Shared Function NombreMes(ByVal m As Integer) As String

        Select Case m

            Case 1 : Return "Enero"
            Case 2 : Return "Febrero"
            Case 3 : Return "Marzo"
            Case 4 : Return "Abril"
            Case 5 : Return "Mayo"
            Case 6 : Return "Junio"
            Case 7 : Return "Julio"
            Case 8 : Return "Agosto"
            Case 9 : Return "Septiembre"
            Case 10 : Return "Octubre"
            Case 11 : Return "Noviembre"
            Case 12 : Return "Diciembre"
            Case Else : Return "Número de mes erroneo. Debe estar entre 1 y 12"

        End Select

    End Function

    Public Shared Function NombreDía(ByVal d As DayOfWeek) As String

        Select Case d

            Case DayOfWeek.Monday : Return "Lunes"
            Case DayOfWeek.Tuesday : Return "Martes"
            Case DayOfWeek.Wednesday : Return "Miércoles"
            Case DayOfWeek.Thursday : Return "Jueves"
            Case DayOfWeek.Friday : Return "Viernes"
            Case DayOfWeek.Saturday : Return "Sábado"
            Case DayOfWeek.Sunday : Return "Domingo"
            Case Else : Return "Número de día erroneo. Debe estar entre 1 y 7"

        End Select

    End Function

    Public Shared Sub MsgInformativo(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Shared Sub MsgErrorCrítico(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Shared Function MsgPregunta(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

    Public Shared Function MsgAdvertencia(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

    Public Shared Sub MsgDatosGuardadosOK()

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "Los datos se han grabado correctamente."
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Shared Sub MsgErrorBorrarFila(ByVal Tabla As String, ByVal TablaRelacionada As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "ERROR. No se puede borrar el registro de " &
        Tabla & " porque existen registros relacionados en  " & TablaRelacionada
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Shared Function ActualizadaFechaÚltimaEmisiónFacturas(ByVal FechaNueva As DateTime) As Boolean
        ' obtiene la fecha de la última vez que se emitieron facturas
        ' leyendo de un fichero de texto

        Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory
        Dim NombreFichero As String = Carpeta & "\Datos\FechaÚltimaEmisiónFacturas.txt"

        Dim NúmeroFactura As DateTime
        Dim texto As New StringBuilder

        ' si existe el fichero, obtiene la fecha de la última emisión y la actualiza
        If My.Computer.FileSystem.FileExists(NombreFichero) Then
            '
            texto.AppendLine(My.Computer.FileSystem.ReadAllText(NombreFichero))
            Dim ini As Integer = "Fecha última emisión facturas: ".Length
            NúmeroFactura = CDate(texto.ToString.Substring(ini))
            If NúmeroFactura.Date = FechaNueva.Date Then

                Return True

            Else

                NúmeroFactura = FechaNueva

                texto.Remove(0, texto.Length)
                texto.AppendFormat("{0}{1:d}", "Fecha última emisión facturas: ", NúmeroFactura)
                My.Computer.FileSystem.WriteAllText(NombreFichero, texto.ToString, False)

                Return False

            End If

        Else

            NúmeroFactura = FechaNueva

            texto.Remove(0, texto.Length)
            texto.AppendFormat("{0}{1:d}", "Fecha última emisión facturas: ", NúmeroFactura)
            My.Computer.FileSystem.WriteAllText(NombreFichero, texto.ToString, False)

            Return False

        End If

    End Function

    Public Shared Function ExisteCuenta(ByVal prmConnectionString As String, Cta As Integer) As Boolean

        ExisteCuenta = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ExisteCuenta", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@CTA"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = Cta
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@EXISTE"
            prm2.DbType = SqlDbType.Bit
            prm2.Direction = ParameterDirection.Output

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ExisteCuenta = MiSqlCMD.Parameters("@EXISTE").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("ExisteCuenta " + ex.Message)

        End Try

        Return ExisteCuenta


    End Function

    Public Shared Function ExisteAsientoConJustificante(ByVal prmConnectionString As String, Justificante As String) As Boolean

        ExisteAsientoConJustificante = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("ExisteAsientoConJustificante", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@JUSTIFICANTE"
            prm1.DbType = SqlDbType.VarChar
            prm1.Direction = ParameterDirection.Input
            prm1.Value = Justificante
            prm1.Size = Justificante.Trim.Length

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@EXISTE"
            prm2.DbType = SqlDbType.Bit
            prm2.Direction = ParameterDirection.Output

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            ExisteAsientoConJustificante = MiSqlCMD.Parameters("@EXISTE").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("ExisteAsientoConJustificante " + Justificante.ToString + " " + ex.Message)

        End Try

        Return ExisteAsientoConJustificante


    End Function

    Public Shared Function NúmeroNuevaFactura(ByVal prmConnectionString As String, año As Integer) As String

        NúmeroNuevaFactura = "111/1111"

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevaFactura", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm As New SqlParameter()

            prm.ParameterName = "@NUM_FAC"
            prm.DbType = SqlDbType.VarChar
            prm.Direction = ParameterDirection.Output
            prm.Size = 8

            MiSqlCMD.Parameters.Add(prm)

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@ANNO"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = año
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            NúmeroNuevaFactura = MiSqlCMD.Parameters("@NUM_FAC").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("NúmeroNuevaFactura " + ex.Message)

        End Try

        Return NúmeroNuevaFactura

    End Function

    Public Shared Function NúmeroNuevoAsiento(ByVal prmConnectionString As String) As Integer

        Dim NúmeroAsiento As Integer = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevoAsiento", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm As New SqlParameter()

            prm.ParameterName = "@NUM_ASIENTO"
            prm.DbType = SqlDbType.Int
            prm.Direction = ParameterDirection.ReturnValue
            prm.Value = 0

            MiSqlCMD.Parameters.Add(prm)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            NúmeroAsiento = CInt(MiSqlCMD.Parameters("@NUM_ASIENTO").Value)

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("NúmeroNuevoAsiento " + ex.Message)

        End Try

        Return NúmeroAsiento

    End Function

    Public Shared Function IdAsientoConJustificante(ByVal prmConnectionString As String, Justificante As String) As Integer

        IdAsientoConJustificante = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("idAsientoConJustificante", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@JUSTIFICANTE"
            prm1.DbType = SqlDbType.VarChar
            prm1.Direction = ParameterDirection.Input
            prm1.Value = Justificante
            prm1.Size = Justificante.Trim.Length

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@ID"
            prm2.DbType = SqlDbType.Int
            prm2.Direction = ParameterDirection.Output

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            IdAsientoConJustificante = MiSqlCMD.Parameters("@ID").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("IdAsientoConJustificante " + ex.Message)

        End Try

        Return IdAsientoConJustificante

    End Function

    Public Shared Function IdFacturaConNúmero(ByVal prmConnectionString As String, Número As String) As Integer

        IdFacturaConNúmero = -1

        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("idFacturaConNúmero", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@NÚMERO"
            prm1.DbType = SqlDbType.VarChar
            prm1.Direction = ParameterDirection.Input
            prm1.Value = Número
            prm1.Size = Número.Trim.Length

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@ID"
            prm2.DbType = SqlDbType.Int
            prm2.Direction = ParameterDirection.Output

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            IdFacturaConNúmero = MiSqlCMD.Parameters("@ID").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("IdFacturaConNúmero " + ex.Message)

        End Try

        Return IdFacturaConNúmero

    End Function

    Public Shared Function NúmeroNuevoApunte(ByVal prmConnectionString As String, NúmeroAsiento As Integer, TipoApunte As String) As Integer

        Dim NúmeroApunte As Integer = -1
        Try

            Dim myConn As New SqlConnection(prmConnectionString)

            Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevoApunte", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

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

            CMódulo.MsgErrorCrítico("NúmeroNuevoApunte " + ex.Message)

        End Try

        Return NúmeroApunte

    End Function

    Public Shared Function BorrarFacturaEmitida(ByVal prmConnectionString As String, id As Integer) As Boolean

        BorrarFacturaEmitida = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("BorrarFacturaEmitida", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@id"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = id
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@Ok"
            prm2.DbType = SqlDbType.Bit
            prm2.Direction = ParameterDirection.Output
            'prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            BorrarFacturaEmitida = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("BorrarFacturaEmitida " + ex.Message)

        End Try

        Return BorrarFacturaEmitida


    End Function

    Public Shared Function MarcarContabilizado(ByVal prmConnectionString As String, id As Integer, Tipo As String) As Boolean

        MarcarContabilizado = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("ActualizarContabilidad", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@id"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = id
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@Tipo"
            prm2.DbType = SqlDbType.VarChar
            prm2.Direction = ParameterDirection.Input
            prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            Dim prm3 As New SqlParameter()

            prm3.ParameterName = "@Ok"
            prm3.DbType = SqlDbType.Bit
            prm3.Direction = ParameterDirection.Output
            'prm3.Value = Tipo

            MiSqlCMD.Parameters.Add(prm3)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            MarcarContabilizado = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("MarcarContabilizado " + ex.Message)

        End Try

        Return MarcarContabilizado

    End Function

    Public Shared Function MarcarPagado(ByVal prmConnectionString As String, id As Integer, Tipo As String) As Boolean

        MarcarPagado = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("ActualizarPagos", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@id"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = id
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@Tipo"
            prm2.DbType = SqlDbType.VarChar
            prm2.Direction = ParameterDirection.Input
            prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            Dim prm3 As New SqlParameter()

            prm3.ParameterName = "@Ok"
            prm3.DbType = SqlDbType.Bit
            prm3.Direction = ParameterDirection.Output
            'prm3.Value = Tipo

            MiSqlCMD.Parameters.Add(prm3)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            MarcarPagado = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("MarcarPagado " + ex.Message)

        End Try

        Return MarcarPagado

    End Function
    Public Shared Function BorrarAsiento(ByVal prmConnectionString As String, id As Integer) As Boolean

        BorrarAsiento = False

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("BorrarAsientos", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@id"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = id
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            Dim prm2 As New SqlParameter()

            prm2.ParameterName = "@Ok"
            prm2.DbType = SqlDbType.Bit
            prm2.Direction = ParameterDirection.Output
            'prm2.Value = Tipo

            MiSqlCMD.Parameters.Add(prm2)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()

            BorrarAsiento = MiSqlCMD.Parameters("@Ok").Value

        Catch ex As Exception

            CMódulo.MsgErrorCrítico("BorrarAsiento " + ex.Message)

        End Try

        Return BorrarAsiento


    End Function
    Public Shared Sub ActualizarDatosCuenta(ByVal prmConnectionString As String, cuenta As Integer)

        Try

            Dim myConn As New SqlConnection(prmConnectionString)
            Dim MiSqlCMD As SqlCommand = New SqlCommand("PrepararLibroMayor", myConn)

            MiSqlCMD.CommandType = CommandType.StoredProcedure

            Dim prm1 As New SqlParameter()

            prm1.ParameterName = "@Cuenta"
            prm1.DbType = SqlDbType.Int
            prm1.Direction = ParameterDirection.Input
            prm1.Value = cuenta
            prm1.Size = 8

            MiSqlCMD.Parameters.Add(prm1)

            myConn.Open()
            MiSqlCMD.ExecuteNonQuery()
            myConn.Close()



        Catch ex As Exception

            CMódulo.MsgErrorCrítico("BorrarAsiento " + ex.Message)

        End Try

    End Sub

    Friend Sub MsgInformativo(ByVal msg As String, ByRef NombreEmpresa As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, NombreEmpresa)

    End Sub

    Friend Sub MsgErrorCrítico(ByVal msg As String, ByRef NombreEmpresa As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, NombreEmpresa)

    End Sub

    Friend Function MsgPregunta(ByVal msg As String, ByRef NombreEmpresa As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
        Return MsgBox(msg, iconos, NombreEmpresa)

    End Function

    Friend Function MsgAdvertencia(ByVal msg As String, ByRef NombreEmpresa As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Return MsgBox(msg, iconos, NombreEmpresa)

    End Function

    Friend Sub MsgDatosGuardadosOK(ByRef NombreEmpresa As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "Los datos se han grabado correctamente."
        MsgBox(msg, iconos, NombreEmpresa)

    End Sub

    Friend Sub MsgErrorBorrarFila(ByVal Tabla As String, ByVal TablaRelacionada As String, ByRef NombreEmpresa As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "ERROR. No se puede borrar el registro de " &
            Tabla & " porque existen registros relacionados en  " & TablaRelacionada
        MsgBox(msg, iconos, NombreEmpresa)

    End Sub

    Public Shared Function Clave(ByVal input As String) As String

        Dim md5Hash As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash

End Class
