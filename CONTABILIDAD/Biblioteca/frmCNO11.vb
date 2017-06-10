Public Class frmCNO11



    Private Sub frmPGC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDINEDataset.CNO11' Puede moverla o quitarla según sea necesario.
        Me.CNO11TableAdapter.Fill(Me.BDINEDataset.CNO11)

        Me.Text = My.Resources.Título + " CLASIFICACIÓN NACIONAL DE OCUPACIONES AÑO 2011"

    End Sub


    Private Sub BindingNavigatorSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub

End Class