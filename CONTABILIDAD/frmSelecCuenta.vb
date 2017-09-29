Imports System
Imports System.Windows.Forms

Public Class frmSelecCuenta

    Public Cuenta As Integer = 0
    Public tipoListado As TipoListado

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Me.tipoListado = Contabilidad.TipoListado.Mayor Then

            Cuenta = CInt(Me.CuentasComboBox1.SelectedValue)

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSelecCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

    End Sub

End Class
