Imports Biblioteca

Public Class frmEmpleados

    Private VoyACerrar As Boolean = False

    Private Sub frmEmpleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.EmpleadosBindingSource.EndEdit()
                Me.EmpleadosTableAdapter.Update(Me.BDContabilidadGMELO.Empleados)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True
    End Sub

    Private Sub frmCliProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EmpleadosTableAdapter.Fill(Me.BDContabilidadGMELO.Empleados)

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDContabilidadGMELO.TiposDocumentoIdentidad)

        Me.Text = My.Resources.Título + " - Gestión de EMPLEADOS"

        Me.ClientesTableAdapter.Fill(Me.BDContabilidadGMELO.Clientes)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub ClientesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles EmpleadosDataGridView.DataError

        MsgBox(e.Exception.Message, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
        e.Cancel = True

    End Sub

    Private Sub EmpleadosDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles EmpleadosDataGridView.RowValidating

        Dim row As DataGridViewRow = Me.EmpleadosDataGridView.Rows(e.RowIndex)
        Dim celdaNombre As DataGridViewCell = row.Cells(1)
        Dim celdaTipoDocumento As DataGridViewCell = row.Cells(2)
        Dim celdaDocumento As DataGridViewCell = row.Cells(3)

        If celdaNombre.FormattedValue.ToString.Length = 0 Then

            MsgBox("ERROR en la columna NOMBRE: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaTipoDocumento.Value.ToString.Length = 0 Then

            MsgBox("ERROR en la columna TIPO DOCUMENTO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        If celdaDocumento.FormattedValue.ToString.Length = 0 Then

            MsgBox("ERROR en la columna DOCUMENTO: no puede estar vacía.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If
        Dim msg As String = ""
        If Not EsCorrectoDocumento(msg, celdaTipoDocumento, celdaDocumento) Then

            MsgBox("ERROR en la columna Tipo Documento: " + msg, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), My.Resources.Título)
            e.Cancel = True
            Exit Sub

        End If

    End Sub

    Private Function EsCorrectoDocumento(ByRef msg As String, TipoDocumento As DataGridViewCell, Documento As DataGridViewCell) As Boolean

        If CType(TipoDocumento.Value, eTipoDocumento) = eTipoDocumento.Ninguno Or
                CType(TipoDocumento.Value, eTipoDocumento) = eTipoDocumento.NIF_DNI Or
                CType(TipoDocumento.Value, eTipoDocumento) = eTipoDocumento.CIF Or
                CType(TipoDocumento.Value, eTipoDocumento) = eTipoDocumento.NIE Or
                CType(TipoDocumento.Value, eTipoDocumento) = eTipoDocumento.Pasaporte Then

            Return True

        End If

    End Function

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click

        If Me.Validate() Then

            Me.EmpleadosBindingSource.EndEdit()
            Me.EmpleadosTableAdapter.Update(Me.BDContabilidadGMELO.Empleados)

            'Me.TableAdapterManager.UpdateAll(Me.BDContabilidad)

            If Me.BDContabilidadGMELO.HasChanges = False Then

                MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

            End If

        Else

            MsgBox("No se pueden grabar los cambios pendientes porque hay errores pendientes de subsanar", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub btnListarEmpleados_Click(sender As Object, e As EventArgs) Handles btnListarEmpleados.Click

        Dim Listado As New frmVisorInformes

        Listado.NombreEmpresa = My.Resources.NombreEmpresa

        With Listado

            .NombreInforme = "rptClientes.rpt"
            .TipoOrigenDatos = eTipoOrigenDatos.ADO
            .ADODataSet = Me.BDContabilidadGMELO
            .Filtro = ""

            Listado.ShowDialog()

        End With

    End Sub

End Class