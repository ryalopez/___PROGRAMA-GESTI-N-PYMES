Imports System
Imports Microsoft.VisualBasic


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

        Me.ConvenioCategoríasConceptosTableAdapter.Update(Me.BDContabilidadGMELO)
        Me.ConvenioCategoríasTableAdapter.Update(Me.BDContabilidadGMELO)
        Me.ConvenioGruposTableAdapter.Update(Me.BDContabilidadGMELO)

        Me.CentrosTrabajoTableAdapter.Update(Me.BDContabilidadGMELO)
        Me.EmpresasTableAdapter.Update(Me.BDContabilidadGMELO)

        Me.ConveniosTableAdapter.Update(Me.BDContabilidadGMELO)

        If Me.BDContabilidadGMELO.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmConveniosEmpresas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.ConvenioCategoríasConceptosBindingSource.EndEdit()
                Me.ConvenioCategoríasBindingSource.EndEdit()
                Me.ConvenioGruposBindingSource.EndEdit()

                Me.CentrosTrabajoBindingSource.EndEdit()
                Me.EmpresasBindingSource.EndEdit()

                Me.ConveniosBindingSource.EndEdit()

                Me.ConvenioCategoríasConceptosTableAdapter.Update(Me.BDContabilidadGMELO)
                Me.ConvenioCategoríasTableAdapter.Update(Me.BDContabilidadGMELO)
                Me.ConvenioGruposTableAdapter.Update(Me.BDContabilidadGMELO)

                Me.CentrosTrabajoTableAdapter.Update(Me.BDContabilidadGMELO)
                Me.EmpresasTableAdapter.Update(Me.BDContabilidadGMELO)

                Me.ConveniosTableAdapter.Update(Me.BDContabilidadGMELO)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmConveniosEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CentrosTrabajoTableAdapter.Fill(Me.BDContabilidadGMELO.CentrosTrabajo)

        Me.EmpresasTableAdapter.Fill(Me.BDContabilidadGMELO.Empresas)

        Me.UnidadesTableAdapter.Fill(Me.BDContabilidadGMELO.Unidades)

        Me.TiposComplementoSalarialTableAdapter.Fill(Me.BDContabilidadGMELO.TiposComplementoSalarial)

        Me.ConvenioCategoríasConceptosTableAdapter.Fill(Me.BDContabilidadGMELO.ConvenioCategoríasConceptos)

        Me.ConvenioCategoríasTableAdapter.Fill(Me.BDContabilidadGMELO.ConvenioCategorías)

        Me.ConvenioGruposTableAdapter.Fill(Me.BDContabilidadGMELO.ConvenioGrupos)

        Me.ConveniosTableAdapter.Fill(Me.BDContabilidadGMELO.Convenios)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub
End Class