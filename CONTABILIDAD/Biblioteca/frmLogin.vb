
Public Class frmLogin
    'Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'BDAdminDataSet.Autoridad' Puede moverla o quitarla según sea necesario.
    '    Me.AutoridadTableAdapter.Fill(Me.BDAdminDataSet.Autoridad)
    '    'TODO: esta línea de código carga datos en la tabla 'BDAdminDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
    '    Me.UsuariosTableAdapter.Fill(Me.BDAdminDataSet.Usuarios)

    '    Me.Text = My.Resources.EMPRESA + " - CONEXIÓN"

    'End Sub

    '' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    '' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    '' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    ''     My.User.CurrentPrincipal = CustomPrincipal
    '' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    '' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    '' como el nombre de usuario, nombre para mostrar, etc.

    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

    '    Dim miError As Boolean = False
    '    Dim autoridad As String = ""
    '    Dim usuario As String = ""
    '    Static intentosLogin As Integer = 0

    '    Dim reg As BDAdminDataSet.UsuariosRow
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''' pruebas
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    Módulo.Usuario = New CUsuario()

    '    Módulo.Usuario.Nombre = "rafa"
    '    Módulo.Usuario.Autoridad = Autorizaciones.ROOT
    '    Módulo.Usuario.Fecha = DateAndTime.Now.ToLocalTime

    '    If Not Módulo.GuardarUsuario() Then

    '        Throw New Exception("No se ha podido crear la configuración del usuario")

    '    End If

    '    Me.DialogResult = Windows.Forms.DialogResult.OK

    '    Exit Sub

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    While intentosLogin < 3

    '        reg = Me.BDAdminDataSet.Usuarios.Rows.Find(Me.UsuariosComboBox.SelectedValue)

    '        If Me.PasswordTextBox.Text.Trim = reg.pwd.Trim Then

    '            usuario = reg.usr.Trim
    '            'crea el usuario
    '            Try

    '                Módulo.Usuario = New CUsuario()

    '                Módulo.Usuario.Nombre = reg.usr.Trim
    '                Módulo.Usuario.Autoridad = reg.Autoridad
    '                Módulo.Usuario.Fecha = DateAndTime.Now.ToLocalTime

    '                If Not Módulo.GuardarUsuario() Then

    '                    Throw New Exception("No se ha podido crear la configuración del usuario")

    '                End If

    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '                Me.Close()

    '            Catch ex As Exception

    '                Módulo.MsgErrorCrítico(ex.Message)
    '                Application.Exit()

    '            End Try

    '            Exit Sub

    '        Else

    '            Módulo.MsgErrorCrítico("Datos erróneos. Inténtelo de nuevo")

    '        End If

    '        intentosLogin += 1

    '        Exit Sub

    '    End While

    '    Módulo.MsgErrorCrítico("El usuario o la palabra de paso no son correctos." + vbCrLf + "Se cerrará la aplicación")

    '    Me.Close()
    '    Application.Exit()

    'End Sub

    'Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

    '    Me.Close()
    '    Application.Exit()

    'End Sub

End Class
