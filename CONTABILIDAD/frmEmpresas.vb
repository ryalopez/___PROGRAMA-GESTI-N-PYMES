Public Class frmEmpresas
    Private VoyACerrar As Boolean = False

    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresasBindingNavigatorSaveItem.Click

        Me.Validate()

        Me.NominasDeEmpresaBindingSource.EndEdit()
        Me.CentrosTrabajoBindingSource.EndEdit()
        Me.EmpresasBindingSource.EndEdit()

        NominasDeEmpresaTableAdapter.Update(Me.BDContabilidadGMELO)
        CentrosTrabajoTableAdapter.Update(Me.BDContabilidadGMELO)
        EmpresasTableAdapter.Update(Me.BDContabilidadGMELO)

        If Me.BDContabilidadGMELO.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If


    End Sub

    Private Sub frmEmpresas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.NominasDeEmpresaBindingSource.EndEdit()
                Me.CentrosTrabajoBindingSource.EndEdit()
                Me.EmpresasBindingSource.EndEdit()

                NominasDeEmpresaTableAdapter.Update(Me.BDContabilidadGMELO)
                CentrosTrabajoTableAdapter.Update(Me.BDContabilidadGMELO)
                EmpresasTableAdapter.Update(Me.BDContabilidadGMELO)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EmpleadosTableAdapter.Fill(Me.BDContabilidadGMELO.Empleados)

        Me.TiposNóminaTableAdapter.Fill(Me.BDContabilidadGMELO.TiposNómina)

        Me.NominasDeEmpresaTableAdapter.Fill(Me.BDContabilidadGMELO.NominasDeEmpresa)

        Me.ConveniosTableAdapter.Fill(Me.BDContabilidadGMELO.Convenios)

        Me.CentrosTrabajoTableAdapter.Fill(Me.BDContabilidadGMELO.CentrosTrabajo)

        Me.EmpresasTableAdapter.Fill(Me.BDContabilidadGMELO.Empresas)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub

    Private Sub NominasDeEmpresaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NominasDeEmpresaDataGridView.CellContentClick

    End Sub
End Class