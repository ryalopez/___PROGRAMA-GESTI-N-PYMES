Public Class frmEmpleados

    Private VoyACerrar As Boolean = False

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click

        Me.Validate()

        Me.UpdateDataBase()

        If Me.BDMeloDataSet.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub frmEmpleados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDMeloDataSet.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()

                Me.UpdateDataBase()

                If Me.BDMeloDataSet.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If


            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub UpdateDataBase()
        Try

            Me.EmpleadosBindingSource.EndEdit()
            Me.NóminasDeEmpleadoBindingSource.EndEdit()
            Me.NóminaConceptosBindingSource.EndEdit()

            Me.EmpleadosTableAdapter.Update(Me.BDMeloDataSet)
            Me.NóminasDeEmpleadoTableAdapter.Update(Me.BDMeloDataSet)
            Me.NóminaConceptosTableAdapter.Update(Me.BDMeloDataSet)

        Catch dbcx As Data.DBConcurrencyException
            Dim response As Windows.Forms.DialogResult

            response = MessageBox.Show(CreateMessage(CType(dbcx.Row, BDMeloDataSet.EmpleadosRow)),
                "Concurrency Exception", MessageBoxButtons.YesNo)

            ProcessDialogResult(response)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Resources.Título)
            Exit Sub

        End Try
    End Sub
    ' This method takes the DialogResult selected by the user and updates the database  
    ' with the new values or cancels the update and resets the Customers table  
    ' (in the dataset) with the values currently in the database. 

    Private Sub ProcessDialogResult(ByVal response As Windows.Forms.DialogResult)

        Select Case response

            Case Windows.Forms.DialogResult.Yes
                Me.BDMeloDataSet.Empleados.Merge(TempCustomersDataTable, True)
                UpdateDataBase()

            Case Windows.Forms.DialogResult.No
                Me.BDMeloDataSet.Empleados.Merge(TempCustomersDataTable)
                MsgBox("Update cancelado")
        End Select
    End Sub

    Private Function CreateMessage(ByVal cr As BDMeloDataSet.EmpleadosRow) As String
        Return "Valores en BD: " & GetRowData(GetCurrentRowInDB(cr),
                                         Data.DataRowVersion.Default) & vbCrLf &
               "Valores originales: " & GetRowData(cr, Data.DataRowVersion.Original) & vbCrLf &
               "Valores propuestos: " & GetRowData(cr, Data.DataRowVersion.Current) & vbCrLf &
               "¿Quiere modificar la Base de Datos con los valores propuestos?"
    End Function

    '-------------------------------------------------------------------------- 
    ' This method loads a temporary table with current records from the database 
    ' and returns the current values from the row that caused the exception. 
    '-------------------------------------------------------------------------- 
    Private TempCustomersDataTable As New BDMeloDataSet.EmpleadosDataTable

    Private Function GetCurrentRowInDB(
        ByVal RowWithError As BDMeloDataSet.EmpleadosRow
        ) As BDMeloDataSet.EmpleadosRow

        Me.EmpleadosTableAdapter.Fill(TempCustomersDataTable)

        Dim currentRowInDb As BDMeloDataSet.EmpleadosRow =
            TempCustomersDataTable.FindByidEmpleado(RowWithError.idEmpleado)

        Return currentRowInDb
    End Function


    '-------------------------------------------------------------------------- 
    ' This method takes a CustomersRow and RowVersion  
    ' and returns a string of column values to display to the user. 
    '-------------------------------------------------------------------------- 
    Private Function GetRowData(ByVal custRow As BDMeloDataSet.EmpleadosRow,
        ByVal RowVersion As Data.DataRowVersion) As String

        Dim rowData As String = ""

        For i As Integer = 0 To custRow.ItemArray.Length - 1
            rowData &= custRow.Item(i, RowVersion).ToString() & " "
        Next

        Return rowData
    End Function

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CNO11TableAdapter.Fill(Me.BDMeloDataSet.CNO11)

        Me.CNO94TableAdapter.Fill(Me.BDMeloDataSet.CNO94)

        Me.CNAETableAdapter.Fill(Me.BDMeloDataSet.CNAE)

        Me.ConvenioCategoríasConceptosTableAdapter.Fill(Me.BDMeloDataSet.ConvenioCategoríasConceptos)

        Me.ConvenioGruposTableAdapter.Fill(Me.BDMeloDataSet.ConvenioGrupos)

        Me.ConvenioCategoríasTableAdapter.Fill(Me.BDMeloDataSet.ConvenioCategorías)

        Me.ConveniosTableAdapter.Fill(Me.BDMeloDataSet.Convenios)

        Me.NóminaConceptosTableAdapter.Fill(Me.BDMeloDataSet.NóminaConceptos)

        Me.NominasDeEmpresaTableAdapter.Fill(Me.BDMeloDataSet.NominasDeEmpresa)

        Me.NóminasDeEmpleadoTableAdapter.Fill(Me.BDMeloDataSet.NóminasDeEmpleado)

        Me.CentrosTrabajoTableAdapter.Fill(Me.BDMeloDataSet.CentrosTrabajo)

        Me.EmpresasTableAdapter.Fill(Me.BDMeloDataSet.Empresas)

        Me.PaisesTableAdapter.Fill(Me.BDMeloDataSet.Paises)

        Me.ProvinciasTableAdapter.Fill(Me.BDMeloDataSet.Provincias)

        Me.TiposVíaTableAdapter.Fill(Me.BDMeloDataSet.TiposVía)

        Me.SexosTableAdapter.Fill(Me.BDMeloDataSet.Sexos)

        Me.TiposDocumentoIdentidadTableAdapter.Fill(Me.BDMeloDataSet.TiposDocumentoIdentidad)

        Me.EmpleadosTableAdapter.Fill(Me.BDMeloDataSet.Empleados)

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click

        Me.Close()

    End Sub

    Private Sub NóminasDeEmpleadoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles NóminasDeEmpleadoBindingSource.CurrentChanged

        Console.WriteLine("Convenios " + Me.BDMeloDataSet.Convenios.Count.ToString)

        For Each conven As BDMeloDataSet.ConveniosRow In Me.BDMeloDataSet.Convenios

            Console.WriteLine("Grupos " + conven.GetConvenioGruposRows.Count.ToString)

            'For Each grupo As BDMeloDataSet.ConvenioGruposRow In conven.GetConvenioGruposRows

            Console.WriteLine("Categorías " + conven.GetConvenioCategoríasRows.Count.ToString)

            For Each cat As BDMeloDataSet.ConvenioCategoríasRow In conven.GetConvenioCategoríasRows

                Console.WriteLine("Conceptos " + cat.GetConvenioCategoríasConceptosRows.Count.ToString)
            Next

            'Next

        Next


        ' Lee el convenio del empleado
        Dim Convenio As BDMeloDataSet.ConveniosRow =
            Me.BDMeloDataSet.Convenios.FindByCódigo(
                CType(Me.EmpleadosBindingSource.Current,
                        System.Data.DataRowView).Item("LaboConvenio"))
        Console.WriteLine(Convenio.Nombre)

        Dim Categorías As BDMeloDataSet.ConvenioCategoríasRow() = Convenio.GetConvenioCategoríasRows

        Dim Categoría As BDMeloDataSet.ConvenioCategoríasRow = Categorías(0)
        Console.WriteLine(Categoría.Denominación)

        Dim Conceptos As BDMeloDataSet.ConvenioCategoríasConceptosRow() =
                   Categoría.GetConvenioCategoríasConceptosRows()

        With Me.ConceptosDisponiblesListBox

            .Items.Clear()
            '.DataSource = Conceptos
            '.DisplayMember = "Denominación"
            For Each c As BDMeloDataSet.ConvenioCategoríasConceptosRow In Conceptos

                .Items.Add(c.Denominación)

            Next

        End With
    End Sub

    Private Sub ConceptosDisponiblesListBox_DoubleClick(sender As Object, e As EventArgs) Handles ConceptosDisponiblesListBox.DoubleClick

        Me.NóminaConceptosBindingSource.AddNew()

        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("idNóminasEmpleado") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("id")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("idNóminasEmpresa") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("idNóminaEmpresa")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("idEmpleado") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("idEmpleado")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("idEmpresa") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("idEmpresa")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("Denominación") = Me.ConceptosDisponiblesListBox.Items(Me.ConceptosDisponiblesListBox.SelectedIndex)
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("FechaInicial") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("FechaInicial")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("FechaFinal") =
            CType(Me.NóminasDeEmpleadoBindingSource.Current, DataRowView).Item("FechaFinal")
        CType(Me.NóminaConceptosBindingSource.Current, DataRowView).Item("Importe") = 0

        Me.NóminaConceptosBindingSource.EndEdit()

        Me.ConceptosUsadosListBox.Items.Add(Me.ConceptosDisponiblesListBox.Items(Me.ConceptosDisponiblesListBox.SelectedIndex))
        Me.ConceptosDisponiblesListBox.Items.RemoveAt(Me.ConceptosDisponiblesListBox.SelectedIndex)

    End Sub
End Class
