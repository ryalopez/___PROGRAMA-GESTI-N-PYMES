Imports Microsoft.VisualBasic
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Module MDLMensajes

    Public Sub MsgInformativo(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Sub MsgErrorCrítico(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Function MsgPregunta(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

    Public Function MsgAdvertencia(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

    Public Sub MsgDatosGuardadosOK()

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "Los datos se han grabado correctamente."
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Sub MsgErrorBorrarFila(ByVal Tabla As String, ByVal TablaRelacionada As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "ERROR. No se puede borrar el registro de " &
        Tabla & " porque existen registros relacionados en  " & TablaRelacionada
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Public Function ActualizadaFechaÚltimaEmisiónFacturas(ByVal FechaNueva As DateTime) As Boolean
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





    Public Sub Main()



    End Sub


    Public Function NombreMes(ByVal m As Integer) As String

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

    Public Function NombreDía(ByVal d As DayOfWeek) As String

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

    Public Function Clave(ByVal input As String) As String

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

End Module

