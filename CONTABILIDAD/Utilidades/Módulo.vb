Imports System.Xml
Imports System.Text
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized
Imports Microsoft.Office.Interop
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Data.Odbc
Imports System.Data.SqlClient


Namespace Utilidades

    Public Module Módulo


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

        'Public Function NúmeroNuevoAsiento() As Integer

        '    Dim NúmeroAsiento As Integer

        '    Try

        '        Dim adap As New BDContabilidadGMELOTableAdapters.AsientosTableAdapter
        '        Dim myConn As New SqlConnection(My.Settings.BDContabilidadConnectionString)

        '        Dim MiSqlCMD As SqlCommand = New SqlCommand("NúmeroNuevoAsiento", myConn)

        '        MiSqlCMD.CommandType = CommandType.StoredProcedure

        '        Dim prm As New SqlParameter()

        '        prm.ParameterName = "@NUM_ASIENTO"
        '        prm.DbType = SqlDbType.Int
        '        prm.Direction = ParameterDirection.ReturnValue
        '        prm.Value = 0

        '        MiSqlCMD.Parameters.Add(prm)

        '        myConn.Open()
        '        MiSqlCMD.ExecuteNonQuery()
        '        myConn.Close()

        '        Return CInt(MiSqlCMD.Parameters("@NUM_ASIENTO").Value)

        '    Catch ex As Exception

        '        MsgErrorCrítico(ex.Message)
        '        'My.Application.ApplicationContext.

        '    End Try

        '    Return NúmeroAsiento

        'End Function

        'Public Function NúmeroNuevoAbono(NúmeroAsiento As Integer) As Integer

        '    Dim n As Integer = 1
        '    While True

        '        If frmDiario.AbonosTableAdapter.FillBy(NúmeroAsiento, n) = 0 Then

        '            Exit While

        '        Else

        '            n += 1

        '        End If

        '    End While

        '    Return n

        'End Function

        'Public Function NúmeroNuevoCargo(NúmeroAsiento As Integer) As Integer

        '    Dim n As Integer = 1
        '    While True

        '        If frmDiario.CargosTableAdapter.FillBy(NúmeroAsiento, n) = 0 Then

        '            Exit While

        '        Else

        '            n += 1

        '        End If

        '    End While

        '    Return n

        'End Function

        'Public Function NúmeroNuevaFactura(FechaFactura As Date) As String

        '    Dim n As Integer = frmFacturasEmitidas.FacturasEmitidasTableAdapter.NúmeroFacturas()
        '    Dim s As String = n.ToString + "/" + FechaFactura.Year.ToString
        '    While s.Length < 8

        '        s = "0" + s

        '    End While
        '    Dim i As Integer = frmFacturasEmitidas.FacturasEmitidasTableAdapter.FindByNúmero(s)

        '    While i > 0

        '        n += 1
        '        s = n.ToString + "/" + FechaFactura.Year.ToString
        '        While s.Length < 8

        '            s = "0" + s

        '        End While
        '        i = frmFacturasEmitidas.FacturasEmitidasTableAdapter.FindByNúmero(s)

        '    End While

        '    Return s

        'End Function

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

    End Module

End Namespace