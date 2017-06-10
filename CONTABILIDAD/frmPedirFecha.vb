Imports System.Windows.Forms
Imports Biblioteca


Public Class frmPedirFecha

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Cristobal
        Me.VariosDíasCheckBox.Checked = True
        If Me.VariosDíasCheckBox.Checked = False Then

            Me.FechaFinalDateTimePicker.Value = Me.FechaDateTimePicker.Value

        End If
        If Me.FechaFinalDateTimePicker.Value < Me.FechaDateTimePicker.Value Then

            Dim msg As String = "La fecha final tiene que ser mayor que la fecha inicial"
            CMódulo.MsgErrorCrítico(msg)
            Exit Sub

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmPedirFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.FechaDateTimePicker.Value = Now
        Me.FechaFinalDateTimePicker.Value = Now

    End Sub

    Private Sub VariosDíasCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariosDíasCheckBox.CheckedChanged

        If Me.VariosDíasCheckBox.Checked Then

            Me.Label2.Visible = True
            Me.FechaFinalDateTimePicker.Visible = True

        Else

            Me.Label2.Visible = False
            Me.FechaFinalDateTimePicker.Visible = False

        End If

    End Sub

End Class
