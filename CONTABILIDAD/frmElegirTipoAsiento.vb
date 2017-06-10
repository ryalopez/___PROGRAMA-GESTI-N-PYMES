Imports System.ComponentModel
Imports System.Windows.Forms
Imports Biblioteca

Public Class frmElegirTipoAsiento

    Private ClaseAsiento As eTiposAsiento

    Public ReadOnly Property TipoSeleccionado As eTiposAsiento
        Get
            Return Me.ClaseAsiento
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If Me.TiposAsientoComboBox.SelectedIndex > -1 Then
            Me.ClaseAsiento = CType(Me.TiposAsientoComboBox.SelectedIndex, eTiposAsiento)
        Else
            Me.ClaseAsiento = eTiposAsiento.Ninguno
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClaseAsiento = eTiposAsiento.Ninguno
        Me.Close()
    End Sub

    Private Sub frmElegirTipoAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.Título + " - Elija clase de asiento"
        Dim TiposAsiento As Array
        TiposAsiento = System.Enum.GetValues(GetType(eTiposAsiento))
        'Dim Tipo As eTiposAsiento

        For Each Tipo As eTiposAsiento In TiposAsiento
            Me.TiposAsientoComboBox.Items.Add(Tipo)
        Next
        Me.TiposAsientoComboBox.SelectedIndex = 0

    End Sub

    Private Sub frmElegirTipoAsiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.TiposAsientoComboBox.Items.Clear()

    End Sub
End Class
