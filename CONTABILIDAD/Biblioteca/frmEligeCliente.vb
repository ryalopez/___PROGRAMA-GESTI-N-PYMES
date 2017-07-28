Imports System.Windows.Forms

Public Class frmEligeCliente

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
        '
        'frmPrincipal.ShowDialog()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = My.Resources.Título + " - Selección de CLIENTE"


        Me.ClientesTableAdapter.Fill(Me.BDEmpresaDataSet.Clientes)
        Me.ClientesComboBox.SelectedIndex = -1
        Me.ClientesComboBox.SelectedIndex = 0

    End Sub

    Private Sub ClientesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClientesComboBox.SelectedIndexChanged

        'Módulo.Usuario.Cliente = Me.ClientesComboBox.Text

    End Sub

End Class
