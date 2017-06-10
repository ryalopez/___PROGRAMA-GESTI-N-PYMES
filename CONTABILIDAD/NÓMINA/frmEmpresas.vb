Public Class frmEmpresas
    Private VoyACerrar As Boolean = False

    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresasBindingNavigatorSaveItem.Click

        Me.Validate()

        Me.NominasDeEmpresaBindingSource.EndEdit()
        Me.CentrosTrabajoBindingSource.EndEdit()
        Me.EmpresasBindingSource.EndEdit()

        NominasDeEmpresaTableAdapter.Update(Me.BDMeloDataSet)
        CentrosTrabajoTableAdapter.Update(Me.BDMeloDataSet)
        EmpresasTableAdapter.Update(Me.BDMeloDataSet)

        If Me.BDMeloDataSet.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If


    End Sub

    Private Sub frmEmpresas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDMeloDataSet.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.NominasDeEmpresaBindingSource.EndEdit()
                Me.CentrosTrabajoBindingSource.EndEdit()
                Me.EmpresasBindingSource.EndEdit()

                NominasDeEmpresaTableAdapter.Update(Me.BDMeloDataSet)
                CentrosTrabajoTableAdapter.Update(Me.BDMeloDataSet)
                EmpresasTableAdapter.Update(Me.BDMeloDataSet)

                If Me.BDMeloDataSet.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.BDMeloDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.NóminasDeEmpleado' Puede moverla o quitarla según sea necesario.
        Me.NóminasDeEmpleadoTableAdapter.Fill(Me.BDMeloDataSet.NóminasDeEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.TiposNómina' Puede moverla o quitarla según sea necesario.
        Me.TiposNóminaTableAdapter.Fill(Me.BDMeloDataSet.TiposNómina)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.NominasDeEmpresa' Puede moverla o quitarla según sea necesario.
        Me.NominasDeEmpresaTableAdapter.Fill(Me.BDMeloDataSet.NominasDeEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.Convenios' Puede moverla o quitarla según sea necesario.
        Me.ConveniosTableAdapter.Fill(Me.BDMeloDataSet.Convenios)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.CentrosTrabajo' Puede moverla o quitarla según sea necesario.
        Me.CentrosTrabajoTableAdapter.Fill(Me.BDMeloDataSet.CentrosTrabajo)
        'TODO: esta línea de código carga datos en la tabla 'BDMeloDataSet.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.BDMeloDataSet.Empresas)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub

    Private Sub NominasDeEmpresaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NominasDeEmpresaDataGridView.CellContentClick

    End Sub
End Class