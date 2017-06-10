Imports System.Windows.Forms

Public Class frmAltaCuenta

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Cta1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cta1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cta1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub

    Private Sub frmAltaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasMaestras' Puede moverla o quitarla según sea necesario.
        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cta2' Puede moverla o quitarla según sea necesario.
        Me.Cta2TableAdapter.Fill(Me.BDContabilidadGMELO.Cta2)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cta1' Puede moverla o quitarla según sea necesario.
        Me.Cta1TableAdapter.Fill(Me.BDContabilidadGMELO.Cta1)

    End Sub

    Private Sub Cta1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cta1ComboBox.SelectedIndexChanged

        Cta2ComboBox.SelectedIndex = 0

    End Sub

    Private Sub Cta2ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cta2ComboBox.SelectedIndexChanged

        CuentasMaestrasComboBox.SelectedIndex = 0

    End Sub

End Class
