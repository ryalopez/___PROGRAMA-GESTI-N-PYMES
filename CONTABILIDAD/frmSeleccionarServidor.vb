Imports System.Windows.Forms
Imports Biblioteca

Public Class frmSeleccionarServidor

    Private cnx As String = ""

    Public ReadOnly Property CadenaConexión As String
        Get
            Return Me.cnx
        End Get
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        CMódulo.MsgInformativo(Me.cnx)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.cnx = ""
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSeleccionarServidor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ejercicioComboBox.Items.Add("2017")
        Me.ejercicioComboBox.Items.Add("2016")
        Me.ejercicioComboBox.Items.Add("2015")

        Me.Text = My.Resources.Título
        Dim Servidores As Array
        Servidores = System.Enum.GetValues(GetType(eServidores))
        Dim idServidor As eServidores
        For Each idServidor In Servidores
            Dim NombreServidor As String = System.Enum.GetName(GetType(eServidores), idServidor)
            Dim Servidor As New CServidor(idServidor, NombreServidor)
            Me.ServidoresComboBox.DisplayMember = "Nombre"
            Me.ServidoresComboBox.ValueMember = "Índice"
            Me.ServidoresComboBox.Items.Add(Servidor)
        Next
        Me.ServidoresComboBox.SelectedIndex = 0
        Me.ejercicioComboBox.SelectedIndex = 0
    End Sub


    Private Sub ejercicioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ejercicioComboBox.SelectedIndexChanged
        If Me.ejercicioComboBox.SelectedIndex < 0 Then
            Me.cnx = "----------------"
            Exit Sub
        End If
        If Me.ServidoresComboBox.SelectedIndex > -1 Then

            Me.cnx = CType(Me.ServidoresComboBox.SelectedItem, CServidor).CadenaConexión
            Me.cnx = Me.cnx.Replace("*", Me.ejercicioComboBox.SelectedItem.ToString)

        End If

    End Sub

End Class
