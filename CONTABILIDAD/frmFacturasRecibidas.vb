Imports System.Text.RegularExpressions
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports CBiblioteca
Imports System
Imports Microsoft.VisualBasic

Public Class FrmFacturasRecibidas

    Private VoyACerrar As Boolean = False

    Private Sub FrmFacturasRecibidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.FacturasRecibidasBindingSource.EndEdit()
                Me.FacturasRecibidasTableAdapter.Update(Me.BDContabilidadGMELO.FacturasRecibidas)

                'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub FrmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FacturasRecibidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasRecibidas)

        Me.Text = My.Resources.Título + " - Gestión de FACTURAS RECIBIDAS"


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub FacturasRecibidasDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

    End Sub


    Private Sub FacturasRecibidasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasRecibidasBindingNavigatorSaveItem.Click

        If Me.Validate() Then


            Me.FacturasRecibidasBindingSource.EndEdit()
            Me.FacturasRecibidasTableAdapter.Update(Me.BDContabilidadGMELO.FacturasRecibidas)

            'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub BtnListarFacturasRecibidas_Click(sender As Object, e As EventArgs) Handles btnListarFacturasRecibidas.Click
        'Dim Listado As New frmVisorInformes With {
        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '}

        'With Listado

        '    Me.FacturasRecibidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasRecibidas)

        '    .NombreInforme = "rptFacturasRecibidas.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = ""

        '    Listado.ShowDialog()

        'End With

    End Sub



End Class