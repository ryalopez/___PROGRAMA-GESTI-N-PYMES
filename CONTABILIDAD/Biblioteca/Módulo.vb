Imports System.Text
Imports System.IO
Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Soap


Public Module Módulo

    'Public Usuario As CUsuario

    'Public Function GuardarUsuario() As Boolean

    '    Dim serializer As New XmlSerializer(GetType(CUsuario))
    '    If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Usuario") Then
    '        Try
    '            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Usuario")
    '        Catch ex As Exception

    '            MsgErrorCrítico(ex.Message)

    '        End Try
    '    End If

    '    Dim writer As New StreamWriter(My.Application.Info.DirectoryPath & "\Usuario\Config.xml")
    '    serializer.Serialize(writer, Módulo.Usuario)
    '    writer.Close()

    '    Return True

    'End Function

    'Public Function LeerUsuario() As CUsuario

    '    ' Lee los datos del cliente
    '    Dim serializer As New XmlSerializer(GetType(CUsuario))

    '    ' A FileStream is needed to read the XML document.
    '    Dim fs As New FileStream(My.Application.Info.DirectoryPath & "\Usuario\Config.xml", FileMode.Open)
    '    Módulo.Usuario = CType(serializer.Deserialize(fs), CUsuario)
    '    fs.Close()

    '    Return Módulo.Usuario

    'End Function


    'Friend Function NombreMes(ByVal m As Integer) As String

    '    Select Case m

    '        Case 1 : Return "Enero"
    '        Case 2 : Return "Febrero"
    '        Case 3 : Return "Marzo"
    '        Case 4 : Return "Abril"
    '        Case 5 : Return "Mayo"
    '        Case 6 : Return "Junio"
    '        Case 7 : Return "Julio"
    '        Case 8 : Return "Agosto"
    '        Case 9 : Return "Septiembre"
    '        Case 10 : Return "Octubre"
    '        Case 11 : Return "Noviembre"
    '        Case 12 : Return "Diciembre"
    '        Case Else : Return "Número de mes erroneo. Debe estar entre 1 y 12"

    '    End Select

    'End Function

    'Friend Function NombreDía(ByVal d As DayOfWeek) As String

    '    Select Case d

    '        Case DayOfWeek.Monday : Return "Lunes"
    '        Case DayOfWeek.Tuesday : Return "Martes"
    '        Case DayOfWeek.Wednesday : Return "Miércoles"
    '        Case DayOfWeek.Thursday : Return "Jueves"
    '        Case DayOfWeek.Friday : Return "Viernes"
    '        Case DayOfWeek.Saturday : Return "Sábado"
    '        Case DayOfWeek.Sunday : Return "Domingo"
    '        Case Else : Return "Número de día erroneo. Debe estar entre 1 y 7"

    '    End Select

    'End Function

    'Friend Sub MsgInformativo(ByVal msg As String)

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
    '    MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Sub

    'Friend Sub MsgErrorCrítico(ByVal msg As String)

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
    '    MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Sub

    'Friend Function MsgPregunta(ByVal msg As String) As MsgBoxResult

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
    '    Return MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Function

    'Friend Function MsgAdvertencia(ByVal msg As String) As MsgBoxResult

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
    '    Return MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Function

    'Friend Sub MsgDatosGuardadosOK()

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
    '    Dim msg As String = "Los datos se han grabado correctamente."
    '    MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Sub

    'Friend Sub MsgErrorBorrarFila(ByVal Tabla As String, ByVal TablaRelacionada As String)

    '    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
    '    Dim msg As String = "ERROR. No se puede borrar el registro de " & _
    '        Tabla & " porque existen registros relacionados en  " & TablaRelacionada
    '    MsgBox(msg, iconos, My.Resources.EMPRESA)

    'End Sub

    ''Function CambioEjercicio() As Boolean

    ''    If Módulo.Usuario.Ejercicio = Today.Year Then

    ''        Return False

    ''    Else

    ''        Módulo.Usuario.ÚltimaFacturaNúmero = 0
    ''        Módulo.Usuario.ÚltimaFacturaFecha = New Date(Módulo.Usuario.Ejercicio, 12, 31)
    ''        Módulo.Usuario.Ejercicio = Today.Year

    ''        Módulo.GuardarConfiguración()

    ''        Return True

    ''    End If

    ''End Function

    'Function ActualizadaFechaÚltimaEmisiónFacturas(ByVal FechaNueva As DateTime) As Boolean
    '    ' obtiene la fecha de la última vez que se emitieron facturas
    '    ' leyendo de un fichero de texto

    '    Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory
    '    Dim NombreFichero As String = Carpeta & "\Datos\FechaÚltimaEmisiónFacturas.txt"

    '    Dim NúmeroFactura As DateTime
    '    Dim texto As New StringBuilder

    '    ' si existe el fichero, obtiene la fecha de la última emisión y la actualiza
    '    If My.Computer.FileSystem.FileExists(NombreFichero) Then
    '        '
    '        texto.AppendLine(My.Computer.FileSystem.ReadAllText(NombreFichero))
    '        Dim ini As Integer = "Fecha última emisión facturas: ".Length
    '        NúmeroFactura = CDate(texto.ToString.Substring(ini))
    '        If NúmeroFactura.Date = FechaNueva.Date Then

    '            Return True

    '        Else

    '            NúmeroFactura = FechaNueva

    '            texto.Remove(0, texto.Length)
    '            texto.AppendFormat("{0}{1:d}", "Fecha última emisión facturas: ", NúmeroFactura)
    '            My.Computer.FileSystem.WriteAllText(NombreFichero, texto.ToString, False)

    '            Return False

    '        End If

    '    Else

    '        NúmeroFactura = FechaNueva

    '        texto.Remove(0, texto.Length)
    '        texto.AppendFormat("{0}{1:d}", "Fecha última emisión facturas: ", NúmeroFactura)
    '        My.Computer.FileSystem.WriteAllText(NombreFichero, texto.ToString, False)

    '        Return False

    '    End If

    'End Function

    ''Friend Sub MantenimientoBD(ByVal fecha As DateTime)

    ''    ' borrar albaranes huerfanos
    ''    Dim adapLin As New dsFrmAlbaranesTableAdapters.LíneasAlbaránTableAdapter
    ''    Dim adapAlb As New dsFrmAlbaranesTableAdapters.AlbaranesTableAdapter
    ''    Dim adapRec As New dsFrmAlbaranesTableAdapters.RecibosTableAdapter
    ''    Dim adapFac As New dsFrmAlbaranesTableAdapters.FacturasTableAdapter

    ''    Dim Lín As New dsFrmAlbaranes.LíneasAlbaránDataTable
    ''    Dim Alb As New dsFrmAlbaranes.AlbaranesDataTable
    ''    Dim Rec As New dsFrmAlbaranes.RecibosDataTable
    ''    Dim Fac As New dsFrmAlbaranes.FacturasDataTable

    ''    adapFac.Fill(Fac)
    ''    adapRec.Fill(Rec)
    ''    adapAlb.Fill(Alb)
    ''    adapLin.Fill(Lín)

    ''    For Each albarán As dsFrmAlbaranes.AlbaranesRow In Alb

    ''        If Fac.FindByid(albarán.idFactura) Is Nothing And Rec.FindByid(albarán.idRecibo) Is Nothing Then

    ''            For Each Línea As dsFrmAlbaranes.LíneasAlbaránRow In albarán.GetLíneasAlbaránRows

    ''                Línea.Delete()

    ''            Next

    ''            albarán.Delete()

    ''        End If

    ''    Next
    ''    adapLin.Update(Lín)
    ''    adapAlb.Update(Alb)

    ''    If Módulo.Config.ÚltimaCopiaDiaria <> fecha.DayOfWeek Then

    ''        CopiaDiaria(fecha)
    ''        Módulo.Config.ÚltimaCopiaDiaria = fecha.DayOfWeek
    ''        Módulo.GuardarConfiguración()

    ''    End If
    ''    If Módulo.Config.ÚltimaCopiaMensual <> fecha.Month Then

    ''        CopiaMensual(fecha)
    ''        Módulo.Config.ÚltimaCopiaMensual = fecha.Month
    ''        Módulo.GuardarConfiguración()

    ''    End If

    ''End Sub

    ''Friend Sub CopiaDiaria(ByVal f As DateTime)

    ''    ' obtiene el día de la semana
    ''    Dim d As DayOfWeek = f.DayOfWeek

    ''    ' obtiene la cadena de conexión
    ''    Dim cnx As New Odbc.OdbcConnectionStringBuilder(My.Settings.cnxChurreria)

    ''    ' obtiene el directorio de origen
    ''    'Dim pOrigen As String = cnx.Item("dbq").ToString
    ''    Dim pOrigen As String = My.Application.Info.DirectoryPath & "\Datos\" & "Base de Churreria.mdb"

    ''    ' obtiene el nombre de la base de datos
    ''    Dim NombreBaseDatos As String = Path.GetFileName(pOrigen)

    ''    ' obtiene el nombre de la base de datos, incluido el directorio, de destino
    ''    Dim pDestino As String = My.Application.Info.DirectoryPath & _
    ''        "\Copias Base de Datos\Diarias\" & NombreDía(d) & "\" & NombreBaseDatos

    ''    ' si el fichero de copia no existe o, existe pero no es de este día, hace la copia
    ''    If My.Computer.FileSystem.FileExists(pDestino) Then
    ''        ' El fichero existe
    ''        If My.Computer.FileSystem.GetFileInfo(pDestino).CreationTime.Day = f.Day Then
    ''            ' y la copia es de hoy

    ''        Else
    ''            ' y la copia es anterior. Hace una nueva copia
    ''            My.Computer.FileSystem.CopyFile(pOrigen, pDestino, True)

    ''        End If

    ''    Else
    ''        ' El fichero no existe. Hace la copia
    ''        My.Computer.FileSystem.CopyFile(pOrigen, pDestino)

    ''    End If

    ''End Sub

    ''Friend Sub CopiaMensual(ByVal f As DateTime)

    ''    ' obtiene el día de la semana
    ''    Dim d As String = NombreMes(f.Month)

    ''    ' obtiene la cadena de conexión
    ''    Dim cnx As New Odbc.OdbcConnectionStringBuilder(My.Settings.cnxChurreria)

    ''    ' obtiene el directorio de origen
    ''    'Dim pOrigen As String = cnx.Item("dbq").ToString
    ''    Dim pOrigen As String = My.Application.Info.DirectoryPath & "\Datos\" & "Base de Churreria.mdb"

    ''    ' obtiene el nombre de la base de datos
    ''    Dim NombreBaseDatos As String = Path.GetFileName(pOrigen)

    ''    ' path y nombre para la base de datos temporal
    ''    Dim pTmp As String = cnx.Item("DefaultDir").ToString & "\tmp" & NombreBaseDatos
    ''    Dim tmpNombreBaseDatos As String = Path.GetFileName(pTmp)

    ''    ' reindexa la base de datos
    ''    If ReindexarBD(cnx) Then

    ''        ' obtiene el nombre de la base de datos, incluido el directorio, de destino
    ''        Dim pDestino As String = My.Application.Info.DirectoryPath & _
    ''            "\Copias Base de Datos\Mensuales\" & d.ToString & "\" & NombreBaseDatos

    ''        ' si el fichero de copia no existe o, existe pero no es de este día, hace la copia
    ''        If My.Computer.FileSystem.FileExists(pDestino) Then
    ''            ' El fichero existe
    ''            If My.Computer.FileSystem.GetFileInfo(pDestino).CreationTime.Day = f.Day Then
    ''                ' y la copia es de hoy

    ''            Else
    ''                ' y la copia es anterior. Hace una nueva copia
    ''                My.Computer.FileSystem.CopyFile(pOrigen, pDestino, True)

    ''            End If

    ''        Else
    ''            ' El fichero no existe. Hace la copia
    ''            My.Computer.FileSystem.CopyFile(pOrigen, pDestino)

    ''        End If

    ''    End If
    ''    '
    ''End Sub

    ''Friend Function ReindexarBD(ByVal cnx As Odbc.OdbcConnectionStringBuilder) As Boolean

    ''    ' reindexa la base de datos origen y la copia en una temporal

    ''    ' obtiene el nombre de la base de datos
    ''    Dim NombreBaseDatos As String = "Base de Churreria.mdb"

    ''    ' obtiene el directorio de origen
    ''    Dim pOrigen As String = My.Application.Info.DirectoryPath + "\Datos\" + NombreBaseDatos

    ''    ' path y nombre para la base de datos temporal
    ''    Dim pTmp As String = My.Application.Info.DirectoryPath + "\Datos\tmp" + NombreBaseDatos
    ''    Dim tmpNombreBaseDatos As String = Path.GetFileName(pTmp)

    ''    Dim oAccess As New Access.Application
    ''    Try

    ''        If oAccess.CompactRepair(pOrigen, pTmp) Then
    ''            ' si ha podido compactar, borra la base original
    ''            My.Computer.FileSystem.DeleteFile(pOrigen)

    ''            ' cambia el nombre de la base temporal, compactada, al de la base original
    ''            My.Computer.FileSystem.RenameFile(pTmp, NombreBaseDatos)

    ''            Return True

    ''        Else

    ''            Módulo.MsgAdvertencia("No se ha podido reindexar la Base de Datos. Puede que esté bloqueada en este momento. ESTO NO ES UN ERROR. Inténtelo más tarde.")

    ''            Return False

    ''        End If

    ''    Catch ex As Exception

    ''        MsgErrorCrítico("No se ha podido reindexar la Base de Datos. " & ex.Message)

    ''        Return False

    ''    End Try

    ''End Function

    ''Friend Function ExportarBD() As Boolean

    ''    ' obtiene la cadena de conexión
    ''    Dim cnx As New Odbc.OdbcConnectionStringBuilder(My.Settings.cnxChurreria)
    ''    ' obtiene el fichero que se va a copiar
    ''    'Dim pOrigen As String = cnx.Item("dbq").ToString
    ''    Dim pOrigen As String = My.Application.Info.DirectoryPath & "\Datos\" & "Base de Churreria.mdb"
    ''    Dim explorador As New SaveFileDialog

    ''    explorador.AddExtension = True      ' por si no ponen el .mdb
    ''    explorador.ValidateNames = True     ' sólo nombres válidos de Win32
    ''    explorador.OverwritePrompt = True

    ''    ' nombre del fichero particularizado para la hora (hh:mm)
    ''    Dim dirHora As String = Now.ToString("t")
    ''    dirHora = dirHora.Replace(":", "_")
    ''    explorador.FileName = Path.GetFileNameWithoutExtension(pOrigen) + dirHora + Path.GetExtension(pOrigen)
    ''    ' extensión por defecto
    ''    explorador.DefaultExt = Path.GetExtension(pOrigen)
    ''    ' filtro
    ''    explorador.Filter = "Bases de Datos Access (*.mdb)|*.mdb"

    ''    ' obtener el disco al que se va a copiar la BD

    ''    explorador.Title = "Seleccione el fichero al que quiere exportar la Base de Datos"

    ''    ' directorio inicial
    ''    ' Buscar un disco extraible o flash que esté listo (evitar que pida insertar disco A:
    ''    explorador.InitialDirectory = ""
    ''    ' Nombre de un directorio particularizado para la fecha de hoy
    ''    Dim dirFecha As String = Today.Date.ToShortDateString
    ''    dirFecha = dirFecha.Replace("/", "_")
    ''    dirFecha = "Copias" + dirFecha
    ''    For i As Integer = 0 To My.Computer.FileSystem.Drives.Count - 1

    ''        If My.Computer.FileSystem.Drives(i).IsReady Then

    ''            If My.Computer.FileSystem.Drives(i).DriveType = DriveType.Removable OrElse _
    ''                My.Computer.FileSystem.Drives(i).DriveType = DriveType.Ram Then

    ''                explorador.InitialDirectory = My.Computer.FileSystem.Drives(i).RootDirectory.ToString + dirFecha
    ''                ' si no existe el directorio particularizado para fecha en el flash. lo crea
    ''                If Not My.Computer.FileSystem.FileExists(explorador.InitialDirectory) Then

    ''                    My.Computer.FileSystem.CreateDirectory(explorador.InitialDirectory)

    ''                End If

    ''            End If

    ''        End If

    ''    Next
    ''    If String.IsNullOrEmpty(explorador.InitialDirectory) Then

    ''        MsgErrorCrítico("No hay ninguna unidad extraible a la que exportar la Base de Datos")
    ''        Return False

    ''    End If

    ''    Dim resul As DialogResult = explorador.ShowDialog()

    ''    If Not String.IsNullOrEmpty(explorador.FileName) Then

    ''        ' comprueba si existe el fichero en el disco
    ''        If resul = DialogResult.OK Then
    ''            ' copia al disco
    ''            My.Computer.FileSystem.CopyFile(pOrigen, explorador.FileName, True)

    ''            ' obtiene el nombre del fichero de configuración y lo copia
    ''            Dim cfgOrigen As String = My.Application.Info.DirectoryPath & _
    ''                "\Datos\Config.cfg"
    ''            Dim cfgDestino As String = _
    ''                My.Computer.FileSystem.GetFileInfo(explorador.FileName).DirectoryName & _
    ''                "\Config" & dirHora & ".cfg"
    ''            My.Computer.FileSystem.CopyFile(cfgOrigen, cfgDestino, True)

    ''            Módulo.MsgInformativo("La Base de Datos se ha exportado correctamente.")

    ''            Return True

    ''        End If

    ''    End If

    ''    Return False

    ''End Function

    ''Friend Function ImportarBD() As Boolean

    ''    ' obtiene la cadena de conexión
    ''    Dim cnx As New Odbc.OdbcConnectionStringBuilder(My.Settings.cnxChurreria)
    ''    ' obtiene el fichero a donde se va a copiar
    ''    'Dim pDestino As String = cnx.Item("dbq").ToString
    ''    Dim pDestino As String = My.Application.Info.DirectoryPath & "\Datos\" & "Base de Churreria.mdb"
    ''    Dim explorador As New OpenFileDialog

    ''    explorador.AddExtension = True      ' por si no ponen el .mdb
    ''    explorador.ValidateNames = True     ' sólo nombres válidos de Win32

    ''    ' nombre del fichero
    ''    explorador.FileName = Path.GetFileName(pDestino)
    ''    ' extensión por defecto
    ''    explorador.DefaultExt = Path.GetExtension(pDestino)
    ''    ' filtro
    ''    explorador.Filter = "Bases de Datos Access (*.mdb)|*.mdb"

    ''    ' obtener el disco del que se va a copiar la BD
    ''    explorador.Title = "Seleccione el fichero del que quiere importar la Base de Datos"

    ''    ' directorio inicial
    ''    ' Buscar un disco extraible o flash que esté listo (evitar que pida insertar disco A:
    ''    explorador.InitialDirectory = ""
    ''    For i As Integer = 0 To My.Computer.FileSystem.Drives.Count - 1

    ''        If My.Computer.FileSystem.Drives(i).IsReady Then

    ''            If My.Computer.FileSystem.Drives(i).DriveType = DriveType.Removable OrElse _
    ''                My.Computer.FileSystem.Drives(i).DriveType = DriveType.Ram Then

    ''                explorador.InitialDirectory = My.Computer.FileSystem.Drives(i).RootDirectory.ToString

    ''            End If

    ''        End If

    ''    Next
    ''    If String.IsNullOrEmpty(explorador.InitialDirectory) Then

    ''        MsgErrorCrítico("No hay ninguna unidad extraible de la que exportar la Base de Datos")
    ''        Return False

    ''    End If

    ''    Dim resul As DialogResult = explorador.ShowDialog()
    ''    ' nombre del fichero particularizado para la hora (hh:mm)
    ''    ' obtener la hora del nombre de la copia de la base de datos
    ''    Dim dirHora As String = explorador.FileName.Substring(explorador.FileName.IndexOf("Base"))
    ''    dirHora = dirHora.Substring("Base de Churreria".Length)
    ''    dirHora = dirHora.Substring(0, dirHora.IndexOf("."))
    ''    If resul = DialogResult.OK Then

    ''        If Not String.IsNullOrEmpty(explorador.FileName) Then
    ''            ' comprueba que es una versión más moderna que la que hay en el disco duro
    ''            ' comprueba si existe el fichero en el disco

    ''            If My.Computer.FileSystem.FileExists(pDestino) Then

    ''                ' El fichero existe
    ''                ' el fichero en el disco se ha creado en la misma fecha o despues
    ''                ' que el que se quiere copiar
    ''                If My.Computer.FileSystem.GetFileInfo(pDestino).LastWriteTime <= _
    ''                   My.Computer.FileSystem.GetFileInfo(explorador.FileName).LastWriteTime Then
    ''                    ' el fichero en el disco es más antiguo que el que se quiere copiar
    ''                    ' El fichero no existe. Hace la copia
    ''                    My.Computer.FileSystem.CopyFile(explorador.FileName, pDestino, True)

    ''                    ' obtiene el nombre del fichero de configuración y lo copia
    ''                    Dim cfgOrigen As String = _
    ''                        My.Computer.FileSystem.GetFileInfo(explorador.FileName).DirectoryName & _
    ''                        "\Config" & dirHora & ".cfg"
    ''                    Dim cfgDestino As String = My.Application.Info.DirectoryPath & _
    ''                        "\Datos\Config.cfg"
    ''                    My.Computer.FileSystem.CopyFile(cfgOrigen, cfgDestino, True)

    ''                    ' actualizar número factura, etc...
    ''                    Módulo.LeerConfiguración()

    ''                    Módulo.MsgInformativo("La Base de Datos se ha importado correctamente.")

    ''                    Return True

    ''                Else
    ''                    ' el fichero en el disco es más moderno que el que se quiere copiar
    ''                    Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.Critical + MsgBoxStyle.YesNo, MsgBoxStyle)
    ''                    Dim msg As String = "El fichero que quiere importar es más antiguo que la Base de Datos que hay operativa. " & _
    ''                    " Si sigue con la importación puede perder datos. ¿Quiere importar la Base de Datos de todas formas?."
    ''                    Dim resp As MsgBoxResult = MsgBox(msg, iconos, My.Resources.TÍTULO)
    ''                    If resp = MsgBoxResult.Yes Then
    ''                        ' El fichero se copia porque lo pide el usuario
    ''                        My.Computer.FileSystem.CopyFile(explorador.FileName, pDestino, True)

    ''                        ' obtiene el nombre del fichero de configuración y lo copia
    ''                        Dim cfgOrigen As String = _
    ''                            My.Computer.FileSystem.GetFileInfo(explorador.FileName).DirectoryName & _
    ''                            "\Config" & dirHora & ".cfg"
    ''                        Dim cfgDestino As String = My.Application.Info.DirectoryPath & _
    ''                            "\Datos\Config.cfg"
    ''                        My.Computer.FileSystem.CopyFile(cfgOrigen, cfgDestino, True)

    ''                        ' actualizar número factura, etc...
    ''                        Módulo.LeerConfiguración()

    ''                        Módulo.MsgInformativo("La Base de Datos se ha importado correctamente.")

    ''                        Return True

    ''                    Else

    ''                        Return False

    ''                    End If

    ''                End If


    ''            Else
    ''                ' El fichero no existe. Hace la copia
    ''                My.Computer.FileSystem.CopyFile(explorador.FileName, pDestino, True)

    ''                ' obtiene el nombre del fichero de configuración y lo copia
    ''                Dim cfgOrigen As String = _
    ''                    My.Computer.FileSystem.GetFileInfo(explorador.FileName).DirectoryName & _
    ''                    "\Config" & dirHora & ".cfg"
    ''                Dim cfgDestino As String = My.Application.Info.DirectoryPath & _
    ''                    "\Datos\Config.cfg"
    ''                My.Computer.FileSystem.CopyFile(cfgOrigen, cfgDestino, True)

    ''                ' actualizar número factura, etc...
    ''                Módulo.LeerConfiguración()

    ''                Módulo.MsgInformativo("La Base de Datos se ha importado correctamente.")

    ''                Return True

    ''            End If

    ''        End If ' nombre fichero vacío

    ''    End If ' dialog.result <> OK

    ''    Return False

    ''End Function

    ''Public Function CambiarFechaÚltimaFactura(Optional ByVal silencioso As Boolean = False) As Boolean

    ''    Dim Cambio As New frmCambiarDatosÚltimaFactura
    ''    Cambio.Text = "Cambiar datos de la última factura"
    ''    Cambio.FechaDateTimePicker.Value = Módulo.Config.ÚltimaFacturaFecha
    ''    Cambio.NúmeroTextBox.Text = Módulo.Config.ÚltimaFacturaNúmero.ToString

    ''    Cambio.ShowDialog()
    ''    If Cambio.DialogResult = DialogResult.OK Then

    ''        Módulo.Config.ÚltimaFacturaFecha = Cambio.FechaDateTimePicker.Value
    ''        Módulo.Config.ÚltimaFacturaNúmero = CInt(Cambio.NúmeroTextBox.Text)

    ''        If Módulo.GuardarConfiguración AndAlso Not silencioso Then

    ''            Dim msg As String = "La configuración se ha modificado correctamente."
    ''            Módulo.MsgInformativo(msg)

    ''        End If

    ''    End If

    ''    Return True

    ''End Function

    ''Public Function CambiarFechaÚltimoRecibo(Optional ByVal silencioso As Boolean = False) As Boolean

    ''    Dim Cambio As New frmCambiarDatosÚltimaFactura
    ''    Cambio.Text = "Cambiar datos del último recibo"
    ''    Cambio.FechaDateTimePicker.Value = Módulo.Config.ÚltimoReciboFecha
    ''    Cambio.NúmeroTextBox.Text = Módulo.Config.ÚltimoReciboNúmero.ToString

    ''    Cambio.ShowDialog()
    ''    If Cambio.DialogResult = DialogResult.OK Then

    ''        Módulo.Config.ÚltimoReciboFecha = Cambio.FechaDateTimePicker.Value
    ''        Módulo.Config.ÚltimoReciboNúmero = CInt(Cambio.NúmeroTextBox.Text)

    ''        If Módulo.GuardarConfiguración AndAlso Not silencioso Then

    ''            Dim msg As String = "La configuración se ha modificado correctamente."
    ''            Módulo.MsgInformativo(msg)

    ''        End If

    ''    End If

    ''    Return True

    ''End Function

    ''Function HayFacturasParaCerrar(ByVal Fecha As DateTime) As Boolean

    ''    Dim ds As New dsFrmFacturas
    ''    ds.EnforceConstraints = False

    ''    Dim Factura As dsFrmFacturas.FacturasRow = ds.Facturas.NewFacturasRow

    ''    ' Llenar la tabla de facturas
    ''    My.Forms.frmFacturas.FacturasTableAdapter.Fill(ds.Facturas)
    ''    For Each Factura In ds.Facturas

    ''        If Factura.Fecha <= Fecha AndAlso Factura.idEstadoFactura = eEstadoFactura.AbiertaPendienteEmitir Then

    ''            Dim msg As String = "Hay facturas que deben cerrarse e imprimirse. Vaya a la pantalla de facturas y cierrelas"
    ''            Módulo.MsgAdvertencia(msg)

    ''            Return True

    ''        End If

    ''    Next

    ''    Return False

    ''End Function

    ''Function HayRecibosParaCerrar(ByVal Fecha As DateTime) As Boolean

    ''    Dim ds As New dsFrmRecibos
    ''    ds.EnforceConstraints = False

    ''    Dim Recibo As dsFrmRecibos.RecibosRow = ds.Recibos.NewRecibosRow

    ''    ' Llenar la tabla de recibos
    ''    My.Forms.frmRecibos.RecibosTableAdapter.Fill(ds.Recibos)
    ''    For Each Recibo In ds.Recibos

    ''        If Recibo.Fecha <= Fecha AndAlso Recibo.idEstadoRecibo = eEstadoFactura.AbiertaPendienteEmitir Then

    ''            Dim msg As String = "Hay recibos que deben cerrarse e imprimirse. Vaya a la pantalla de recibos y cierrelos"
    ''            Módulo.MsgAdvertencia(msg)

    ''            Return True

    ''        End If

    ''    Next

    ''    Return False

    ''End Function

    ''Friend Function BorrarRecibosFactura(ByVal NúmeroFactura As Integer) As Boolean

    ''    Using connection As New OdbcConnection(My.Settings.cnxChurreria)
    ''        ' The insertSQL string contains a SQL statement that
    ''        ' inserts a new row in the source table.
    ''        Dim sql As String = "DELETE FROM Recibos WHERE idFactura = " & NúmeroFactura.ToString
    ''        Dim command As New OdbcCommand(sql, connection)

    ''        ' Open the connection and execute the insert command.
    ''        Try
    ''            connection.Open()
    ''            command.ExecuteNonQuery()
    ''        Catch ex As Exception
    ''            Módulo.MsgErrorCrítico("EXCEPCIÓN en Módulo. BorrarRecibosFactura: " & ex.Message)
    ''        End Try
    ''        ' The connection is automatically closed when the
    ''        ' code exits the Using block.
    ''    End Using

    ''End Function

    ''Friend Function BorrarAlbaranesFactura(ByVal NúmeroFactura As Integer) As Boolean

    ''    Using connection As New OdbcConnection(My.Settings.cnxChurreria)
    ''        ' The insertSQL string contains a SQL statement that
    ''        ' inserts a new row in the source table.
    ''        Dim sql As String = "DELETE FROM Albaranes WHERE idFactura = " & NúmeroFactura.ToString
    ''        Dim command As New OdbcCommand(sql, connection)

    ''        ' Open the connection and execute the insert command.
    ''        Try
    ''            connection.Open()
    ''            command.ExecuteNonQuery()
    ''        Catch ex As Exception
    ''            Módulo.MsgErrorCrítico("EXCEPCIÓN en Módulo. BorrarAlbaranesFactura: " & ex.Message)
    ''        End Try
    ''        ' The connection is automatically closed when the
    ''        ' code exits the Using block.
    ''    End Using

    ''End Function

    ''Friend Function BorrarAlbaranesRecibo(ByVal NúmeroRecibo As Integer) As Boolean

    ''    Using connection As New OdbcConnection(My.Settings.cnxChurreria)

    ''        ' contar albaranes del recibo
    ''        Dim sql As String = "SELECT COUNT(*) FROM Albaranes WHERE idRecibo = " & NúmeroRecibo.ToString
    ''        Dim n As Integer = 0

    ''        Dim command As New Odbc.OdbcCommand(sql, connection)

    ''        Try

    ''            connection.Open()
    ''            n = CInt(command.ExecuteScalar())

    ''            ' Si hay albaranes, los borra
    ''            If n > 0 Then

    ''                sql = "DELETE FROM Albaranes WHERE idRecibo = " & NúmeroRecibo.ToString
    ''                command = New OdbcCommand(sql, connection)

    ''                ' Open the connection and execute the insert command.
    ''                Try
    ''                    connection.Open()
    ''                    command.ExecuteNonQuery()
    ''                Catch ex As Exception
    ''                    Módulo.MsgErrorCrítico("EXCEPCIÓN en Módulo. BorrarAlbaranesRecibo: " & ex.Message)

    ''                End Try

    ''            End If

    ''        Catch ex As Exception

    ''            Throw New Exception("EXCEPCIÓN en Módulo. BorrarAlbaranesRecibo. " & ex.Message)

    ''        End Try

    ''    End Using

    ''End Function

    ''Public Function ÚltimoDelReparto(ByVal Clientes As ArrayList) As Integer

    ''    Dim ind As Integer = -1
    ''    For Each r As CReparto In Clientes

    ''        If r.Orden > ind Then

    ''            ind = r.Orden

    ''        End If

    ''    Next

    ''    Return ind + 1

    ''End Function
    ''
    '' Cuando se borran los clientes suelen quedar enlaces rotos
    '' Esta función desarrollada será de ayuda,
    '' Ahora mismo NO ESTÁ IMPLEMENTADA
    ''
    ''Public Function RepararBD() As Boolean
    ''    ' Busca enlaces rotos y borra los registros hijos
    ''    '
    ''    Dim ds As New dsFrmAlbaranes
    ''    '
    ''    ' Líneas de albarán cuengan de albaranes
    ''    Dim a As New dsFrmAlbaranesTableAdapters.AlbaranesTableAdapter
    ''    a.Fill(ds.Albaranes)
    ''    Dim la As New dsFrmAlbaranesTableAdapters.LíneasAlbaránTableAdapter
    ''    la.Fill(ds.LíneasAlbarán)
    ''    For Each r As dsFrmAlbaranes.LíneasAlbaránRow In ds.LíneasAlbarán

    ''        Dim alb As dsFrmAlbaranes.AlbaranesRow = ds.Albaranes.FindByid(r.idAlbarán)
    ''        If alb Is Nothing Then
    ''            MsgBox("Borrar línea")
    ''        End If
    ''    Next

    ''End Function
End Module
