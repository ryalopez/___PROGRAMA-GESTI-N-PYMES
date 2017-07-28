Public Class frmConvenios

    Private VoyACerrar As Boolean = False

    Private Sub ConveniosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click

        Me.Validate()

        Me.ConvenioCategoríasConceptosBindingSource.EndEdit()
        Me.ConvenioCategoríasBindingSource.EndEdit()
        Me.ConvenioGruposBindingSource.EndEdit()

        Me.CentrosTrabajoBindingSource.EndEdit()
        Me.EmpresasBindingSource.EndEdit()

        Me.ConveniosBindingSource.EndEdit()

        Me.ConvenioCategoríasConceptosTableAdapter.Update(Me.BDMeloDataSet)
        Me.ConvenioCategoríasTableAdapter.Update(Me.BDMeloDataSet)
        Me.ConvenioGruposTableAdapter.Update(Me.BDMeloDataSet)

        Me.CentrosTrabajoTableAdapter.Update(Me.BDMeloDataSet)
        Me.EmpresasTableAdapter.Update(Me.BDMeloDataSet)

        Me.ConveniosTableAdapter.Update(Me.BDMeloDataSet)

        If Me.BDMeloDataSet.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmConveniosEmpresas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDMeloDataSet.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.ConvenioCategoríasConceptosBindingSource.EndEdit()
                Me.ConvenioCategoríasBindingSource.EndEdit()
                Me.ConvenioGruposBindingSource.EndEdit()

                Me.CentrosTrabajoBindingSource.EndEdit()
                Me.EmpresasBindingSource.EndEdit()

                Me.ConveniosBindingSource.EndEdit()

                Me.ConvenioCategoríasConceptosTableAdapter.Update(Me.BDMeloDataSet)
                Me.ConvenioCategoríasTableAdapter.Update(Me.BDMeloDataSet)
                Me.ConvenioGruposTableAdapter.Update(Me.BDMeloDataSet)

                Me.CentrosTrabajoTableAdapter.Update(Me.BDMeloDataSet)
                Me.EmpresasTableAdapter.Update(Me.BDMeloDataSet)

                Me.ConveniosTableAdapter.Update(Me.BDMeloDataSet)

                If Me.BDMeloDataSet.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmConveniosEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CentrosTrabajoTableAdapter.Fill(Me.BDMeloDataSet.CentrosTrabajo)

        Me.EmpresasTableAdapter.Fill(Me.BDMeloDataSet.Empresas)

        Me.UnidadesTableAdapter.Fill(Me.BDMeloDataSet.Unidades)

        Me.TiposComplementoSalarialTableAdapter.Fill(Me.BDMeloDataSet.TiposComplementoSalarial)

        Me.ConvenioCategoríasConceptosTableAdapter.Fill(Me.BDMeloDataSet.ConvenioCategoríasConceptos)

        Me.ConvenioCategoríasTableAdapter.Fill(Me.BDMeloDataSet.ConvenioCategorías)

        Me.ConvenioGruposTableAdapter.Fill(Me.BDMeloDataSet.ConvenioGrupos)

        Me.ConveniosTableAdapter.Fill(Me.BDMeloDataSet.Convenios)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub
End Class