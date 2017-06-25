Imports Biblioteca

Public Class frmPréstamos

    'Private Sub PréstamosBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles PréstamosBindingNavigatorSaveItem.Click
    '    Private VoyACerrar As Boolean = False
    '    'Private Modificado As Boolean = False


    '    Me.Validate()
    '    Me.PréstamosCortoPlazoBindingSource.EndEdit()
    '    Try

    '        Me.PréstamosCortoPlazoTableAdapter.UpdateAll(Me.BDContabilidadMelo)

    '    Catch ex As Exception

    '        MsgBox(ex.Message)

    '    End Try

    '    If Me.BDContabilidadMelo.HasChanges = False Then

    '        MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

    '    End If

    'End Sub

    'Private Sub frmAsientos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    '    If Me.BDContabilidadMelo.HasChanges = True Then

    '        If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

    '            Try

    '                Me.Validate()


    '                Me.PrestamosCortoPlazoBindingNavigatr.EndEdit()


    '                Me.TableAdapterManager.UpdateAll(Me.BDContabilidadMelo)


    '                If Me.BDContabilidadMelo.HasChanges = False Then

    '                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

    '                End If

    '            Catch ex As Exception

    '                CMódulo.MsgAdvertencia(ex.Message + " " +
    '                               ex.HelpLink)

    '            End Try

    '        End If

    '    End If

    '    Me.VoyACerrar = True

    'End Sub

    'End Sub
    Private Sub frmPréstamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.PréstamosLargoPlazo' Puede moverla o quitarla según sea necesario.
        Me.PréstamosLargoPlazoTableAdapter.Fill(Me.BDContabilidadGMELO.PréstamosLargoPlazo)

        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Préstamos' Puede moverla o quitarla según sea necesario.
        Me.PréstamosTableAdapter.Fill(Me.BDContabilidadGMELO.Préstamos)

        Me.PréstamosLargoPlazoComboBox.SelectedIndex = 0



        Me.Text = My.Resources.Título + " - Información de Préstamos"

    End Sub

    Private Sub PréstamosLargoPlazoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PréstamosLargoPlazoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub

    Private Sub PréstamosLargoPlazoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

        If Me.PréstamosLargoPlazoComboBox.SelectedIndex > -1 Then
            Me.PréstamosBindingSource.Filter = "PADRE = " + PréstamosLargoPlazoComboBox.SelectedValue.ToString

            Me.PréstamosLargoPlazoBindingSource.MoveFirst()

        Else
            Me.PréstamosBindingSource.Filter = "2 = 3"

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub PréstamosLargoPlazoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PréstamosLargoPlazoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub

    Private Sub PréstamosLargoPlazoComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles PréstamosLargoPlazoComboBox.SelectedIndexChanged

        If Me.PréstamosLargoPlazoComboBox.SelectedIndex > -1 Then

            Me.SaldoHaberTextBox.Text = String.Format("{0:#,###,###,###.##}", CDbl(CType(Me.PréstamosLargoPlazoBindingSource.Current, DataRowView).Item("SaldoHaber")))

        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Private Sub Cuentas2SaveItem_Click(sender As Object, e As EventArgs) Handles Cuentas2SaveItem.Click

        Me.Validate()
        Me.PréstamosBindingSource.EndEdit()
        Me.PréstamosTableAdapter.Update(Me.BDContabilidadGMELO.Préstamos)

        If Me.BDContabilidadGMELO.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If
    End Sub
End Class