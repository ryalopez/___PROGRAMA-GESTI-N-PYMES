Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = My.Resources.Título

    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub

    Private Sub mnuConvenios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConvenios.Click

        frmConvenios.Show(Me)

    End Sub

    Private Sub mnuEmpresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmpresas.Click

        frmEmpresas.Show(Me)

    End Sub

    Private Sub mnuEmpleados_Click(sender As Object, e As EventArgs) Handles mnuEmpleados.Click

        frmEmpleados.Show(Me)

    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click

        frmAcercaDe.Show(Me)

    End Sub

End Class