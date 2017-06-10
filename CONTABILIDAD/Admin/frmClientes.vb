Public Class frmClientes

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEmpresaDataSet.Domicilio' Puede moverla o quitarla según sea necesario.
        Me.DomicilioTableAdapter.Fill(Me.BDEmpresaDataSet.Domicilio)

        Me.Text = My.Resources.EMPRESA + " - Gestión y Selección de NUESTROS CLIENTE"

        'TODO: esta línea de código carga datos en la tabla 'BDEmpresaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDEmpresaDataSet.Clientes)
        Me.ClientesComboBox.SelectedIndex = -1
        Me.ClientesComboBox.SelectedIndex = 0

        Me.DomicilioSocial.DatosDomicilio = Me.DomicilioBindingSource

    End Sub

    Private Sub vbSalir_Click(sender As Object, e As EventArgs) Handles vbSalir.Click

        Me.Close()

    End Sub

    Private Sub DomicilioSocial_DirecciónIncorrecta(Sender As Object, e As Controles.CDomicilioErrorEventArgs) Handles DomicilioSocial.DirecciónIncorrecta

        If e.NúmeroError <> Controles.DomicilioNúmerorError.Correcto Then

            If MsgPregunta(e.Mensaje) = MsgBoxResult.Yes Then

                e.Cancel = True

            End If

        End If

    End Sub

    Private Sub DatosBancariosCliente_DatosBancoIncorrectos(Sender As Object, e As Controles.CDatosBancoNumEventArgs)

        If e.NúmeroError <> Controles.BancosNumErrores.Correcto Then

            MsgErrorCrítico(e.Mensaje)

        End If

    End Sub

    Private Sub DomicilioBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles DomicilioBindingSource.CurrentItemChanged

        If Not IsNothing(sender.current) Then

            Console.WriteLine("stop " + CType(CType(sender.current, System.Data.DataRowView).Row, BDEmpresaDataSet.DomicilioRow).calle)
            'Me.DomicilioSocial.DatosDomicilio.Calle = CType(CType(sender.current, System.Data.DataRowView).Row, BDEmpresaDataSet.DomicilioRow).calle

        Else

            'Me.DomicilioSocial.DatosDomicilio.Calle = ""

        End If

    End Sub

End Class