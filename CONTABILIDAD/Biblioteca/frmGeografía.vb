Public Class frmGeografía


    Private Sub frmGeografía_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = My.Resources.Título + " PAISES, PROVINCIAS, MUNICIPIOS, Y CÓDIGOS POSTALES"

    End Sub

   
    Private Sub mnuSalir_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    'Private Sub CtlDomicilio1_DirecciónIncorrecta(Sender As Object, e As Controles.ctlDomicilio.DirecciónNumEventArgs) Handles CtlDomicilio1.DirecciónIncorrecta

    '    If e.NúmeroError <> Controles.ctlDomicilio.DirNumErrores.Correcto Then

    '        MsgErrorCrítico(e.Mensaje)

    '    End If

    'End Sub

End Class