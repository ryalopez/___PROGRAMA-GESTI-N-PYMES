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
        Me.ConvenioCategoríasTableAdapter.Update(Me.bdcontabilidadgmelo)
        Me.ConvenioGruposTableAdapter.Update(Me.bdcontabilidadgmelo)

        Me.CentrosTrabajoTableAdapter.Update(Me.bdcontabilidadgmelo)
        Me.EmpresasTableAdapter.Update(Me.bdcontabilidadgmelo)

        Me.ConveniosTableAdapter.Update(Me.BDContabilidadGMELO)

        If Me.bdcontabilidadgmelo.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmConveniosEmpresas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.bdcontabilidadgmelo.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.ConvenioCategoríasConceptosBindingSource.EndEdit()
                Me.ConvenioCategoríasBindingSource.EndEdit()
                Me.ConvenioGruposBindingSource.EndEdit()

                Me.CentrosTrabajoBindingSource.EndEdit()
                Me.EmpresasBindingSource.EndEdit()

                Me.ConveniosBindingSource.EndEdit()

                Me.ConvenioCategoríasConceptosTableAdapter.Update(Me.bdcontabilidadgmelo)
                Me.ConvenioCategoríasTableAdapter.Update(Me.bdcontabilidadgmelo)
                Me.ConvenioGruposTableAdapter.Update(Me.bdcontabilidadgmelo)

                Me.CentrosTrabajoTableAdapter.Update(Me.bdcontabilidadgmelo)
                Me.EmpresasTableAdapter.Update(Me.bdcontabilidadgmelo)

                Me.ConveniosTableAdapter.Update(Me.bdcontabilidadgmelo)

                If Me.bdcontabilidadgmelo.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub frmConveniosEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.CentrosTrabajo' Puede moverla o quitarla según sea necesario.
        Me.CentrosTrabajoTableAdapter.Fill(Me.bdcontabilidadgmelo.CentrosTrabajo)
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.bdcontabilidadgmelo.Empresas)

        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.Unidades' Puede moverla o quitarla según sea necesario.
        Me.UnidadesTableAdapter.Fill(Me.bdcontabilidadgmelo.Unidades)
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.TiposComplementoSalarial' Puede moverla o quitarla según sea necesario.
        Me.TiposComplementoSalarialTableAdapter.Fill(Me.bdcontabilidadgmelo.TiposComplementoSalarial)

        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.ConvenioCategoríasConceptos' Puede moverla o quitarla según sea necesario.
        Me.ConvenioCategoríasConceptosTableAdapter.Fill(Me.bdcontabilidadgmelo.ConvenioCategoríasConceptos)
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.ConvenioCategorías' Puede moverla o quitarla según sea necesario.
        Me.ConvenioCategoríasTableAdapter.Fill(Me.bdcontabilidadgmelo.ConvenioCategorías)
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.ConvenioGrupos' Puede moverla o quitarla según sea necesario.
        Me.ConvenioGruposTableAdapter.Fill(Me.bdcontabilidadgmelo.ConvenioGrupos)
        'TODO: esta línea de código carga datos en la tabla 'bdcontabilidadgmelo.Convenios' Puede moverla o quitarla según sea necesario.
        Me.ConveniosTableAdapter.Fill(Me.bdcontabilidadgmelo.Convenios)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub
End Class