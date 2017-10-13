
Imports System
Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.SqlServer.Types
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports CBiblioteca
Imports System.Drawing

Public Class FrmCuentas

    Friend WithEvents FrmA As FrmAltaCuenta
    Private VoyACerrar As Boolean = False

    Private Sub GruposBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Cuentas2SaveItem.Click
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.CuentasTableAdapter.Update(Me.BDContabilidadGMELO.Cuentas)

        If Me.BDContabilidadGMELO.HasChanges = False Then

            MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

        End If

    End Sub

    Private Sub FrmGrupos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.BDContabilidadGMELO.HasChanges = True Then

            If MsgBox("Hay cambios pendientes. ¿Quiere salvarlos?", MsgBoxStyle.YesNo, My.Resources.Título) = MsgBoxResult.Yes Then

                Me.Validate()
                Me.CuentasBindingSource.EndEdit()
                Me.CuentasTableAdapter.Update(Me.BDContabilidadGMELO.Cuentas)

                If Me.BDContabilidadGMELO.HasChanges = False Then

                    MsgBox("Los cambios pendientes se han guardado correctamente en la Base de Datos", MsgBoxStyle.OkOnly, My.Resources.Título)

                End If

            End If

        End If

        Me.VoyACerrar = True

    End Sub

    Private Sub FrmGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.BalanceSituaciónTableAdapter.Fill(Me.BDContabilidadGMELO.BalanceSituación)

        Me.PerdidasyGananciasSeccionesTableAdapter.Fill(Me.BDContabilidadGMELO.PerdidasyGananciasSecciones)

        Me.PérdidasyGananciasTableAdapter.Fill(Me.BDContabilidadGMELO.PérdidasyGanancias)

        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)

        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)

        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)

        Me.CuentasMaestrasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasMaestras)

        Me.Cta2TableAdapter.Fill(Me.BDContabilidadGMELO.Cta2)

        Me.Cta1TableAdapter.Fill(Me.BDContabilidadGMELO.Cta1)

        Me.CuentasTableAdapter.Fill(Me.BDContabilidadGMELO.Cuentas)

        Me.Text = My.Resources.Título + " - CUENTAS DE LA EMPRESA"

    End Sub

    Private Sub GruposDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

        MessageBox.Show("Error en el DataGridView " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts _
            .CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) _
            Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context =
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If


    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click

        Me.Close()

    End Sub

    Private Sub SumasYSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumasYSaldosToolStripMenuItem.Click

        Dim selecEjercicio As New frmSelecFechas With {
            .Text = "BALANCE SUMAS Y SALDOS - Selección de Fechas"
        }

        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro del trimestre."
        selecEjercicio.tipoListado = CType(ETipoListadoContable.BalanceSumasSaldos, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Dim Datos As New ReportDataSource()
            Datos.Name = "Datos"
            Datos.Value = Me.BDContabilidadGMELO.Tables("cuentas")

            Dim Parámetros As ReportParameterCollection = New ReportParameterCollection
            Dim Cabecera As String = "BALANCE DE SUMAS Y SALDOS DEL " + selecEjercicio.resul
            Parámetros.Add(New ReportParameter("Encabezado", Cabecera))

            Dim Listado As New FrmVisorInformes("BSS", Datos, Parámetros)

            Listado.ShowDialog()

        End If

    End Sub

    Private Sub BtnBalanceSituación_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalanceSituación.Click

        'CARGAR DATOS DE LA CUENTA DE BALANCE de SITUACIÓN
        Me.BalanceSituaciónTableAdapter.Fill(Me.BDContabilidadGMELO.BalanceSituación)

        Dim selecEjercicio As New frmSelecFechas With {
            .Text = "BALANCE SITUACIÓN - Selección de Fechas"
        }
        selecEjercicio.Label1.Text = "Seleccione cualquier fecha dentro ejercicio."
        selecEjercicio.tipoListado = CType(ETipoListadoContable.BalanceSituación, Contabilidad.TipoListado)

        selecEjercicio.ShowDialog(Me)

        If selecEjercicio.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'FILTRAR APUNTES DEL EJERCICIO
            Dim txtEjercicio As String = selecEjercicio.resul



        End If

    End Sub


    Private Sub LibroMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroMayorToolStripMenuItem.Click
        Dim selecCuentas As New frmSelecCuenta With {
            .Text = "LIBRO MAYOR - Selección de Cuenta"
        }
        selecCuentas.Label1.Text = "Seleccione la cuenta cuyos movimientos quiere listar."
        selecCuentas.tipoListado = CType(ETipoListadoContable.Mayor, Contabilidad.TipoListado)

        selecCuentas.ShowDialog(Me)

        If selecCuentas.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.Cursor = Cursors.WaitCursor

            '
            ' Actualiza tabla de la base de datos
            '
            CBiblioteca.MDLProcedimientosAlmacenados.PrepararDatosLibroMayor(My.Settings.BDContabilidadConnectionString, selecCuentas.Cuenta)

            Me.LíneasMayorTableAdapter.Fill(Me.BDContabilidadGMELO.LíneasMayor)

            If Me.LíneasMaestrasBindingSource.Count > 0 Then

                Dim Datos As New ReportDataSource()
                Datos.Name = "Datos"
                Datos.Value = Me.BDContabilidadGMELO.Tables("LíneasMayor")

                Dim Parámetros As ReportParameterCollection = New ReportParameterCollection
                Dim Cabecera As String = "MOVIMIENTOS DE LA CUENTA " + selecCuentas.Cuenta.ToString
                Parámetros.Add(New ReportParameter("Encabezado", Cabecera))

                Dim Listado As New FrmVisorInformes("LM", Datos, Parámetros)

                Listado.ShowDialog()
            Else

                CBiblioteca.MsgAdvertencia("No existen movimientos de la cuenta " + selecCuentas.Cuenta.ToString)

            End If

        End If

        Me.Cursor = DefaultCursor

    End Sub

    Private Sub BtnCtaPerdidasYGanancias_Click(sender As Object, e As EventArgs) Handles btnCtaPerdidasYGanancias.Click

        'CARGAR DATOS DE LA CUENTA DE PÉRDIDAS Y GANANCIAS
        Me.PérdidasyGananciasTableAdapter.Fill(Me.BDContabilidadGMELO.PérdidasyGanancias)
        Me.PerdidasyGananciasSeccionesTableAdapter.Fill(Me.BDContabilidadGMELO.PerdidasyGananciasSecciones)

        'FILTRAR APUNTES DEL EJERCICIO
        Dim txtEjercicio As String = ""

        'Dim Listado As New frmVisorInformes

        'With Listado

        '    .NombreEmpresa = My.Resources.NombreEmpresa
        '    .NombreInforme = "rptPérdidasYGanancias.rpt"
        '    '.NombreInforme = "rptCrystalReport1.rpt"
        '    .TipoOrigenDatos = ETipoOrigenDatos.ADO
        '    .ADODataSet = Me.BDContabilidadGMELO
        '    .Filtro = "Ejercicio Actual"

        '    Listado.ShowDialog()

        'End With

    End Sub

    ''' <summary>
    ''' Crea una cuenta del grupo de la cuenta maestra en la que han hecho doble click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasMaestrasDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CuentasMaestrasDataGridView.RowHeaderMouseDoubleClick
        FrmA = New FrmAltaCuenta With {
            .CódigoCuentaMaestra = CInt(Me.CuentasMaestrasDataGridView.CurrentRow.Cells(0).Value)
        }
        If FrmA.CódigoCuentaMaestra = 4100 Then
            FrmA.Código = MDLProcedimientosAlmacenados.ClaveNuevoProveedor(My.Settings.BDContabilidadConnectionString)
            FrmA.CódigoCuentaTextBox.Enabled = False
            FrmA.CódigoCuentaMaestra = 4100
            FrmA.idCuentaPerdidasyGanancias = 0
            FrmA.PérdidasyGananciasComboBox.Enabled = False
            FrmA.idCuentaBalanceResultados = 52
            FrmA.BalanceSituaciónComboBox.Enabled = False
            FrmA.Nombre = "ESCRIBA AQUI EL NOMBRE DEL PROVEEDOR"
        Else
            FrmA.Código = FrmA.CódigoCuentaMaestra
            FrmA.idCuentaPerdidasyGanancias = 0
            FrmA.idCuentaBalanceResultados = 52
            FrmA.Nombre = "ESCRIBA AQUI EL NOMBRE DE LA CUENTA"
        End If

        If FrmA.ShowDialog(Me) = DialogResult.OK Then

        Else

        End If

    End Sub
    ''' <summary>
    ''' pinta el simbolo de crear una cuenta en las filas de las cuentas maestras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasMaestrasDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles CuentasMaestrasDataGridView.RowPostPaint

        'Convert the image to icon, in order to load it in the row header column
        Dim myBitmap As Bitmap = New Bitmap(My.Resources.add)
        myBitmap.MakeTransparent(Color.Magenta)
        Dim myIcon As Icon = Icon.FromHandle(myBitmap.GetHicon())

        Dim gráfico As Graphics = e.Graphics

        'Set Image dimension - User's choice
        Dim iconHeight As UInteger = 14
        Dim iconWidth As UInteger = 14

        'Set x/y position - As the center of the RowHeaderCell
        Dim xPosition As UInteger = CUInt(e.RowBounds.X + (Me.CuentasMaestrasDataGridView.RowHeadersWidth / 2))
        Dim yPosition As UInteger = CUInt(e.RowBounds.Y +
        ((Me.CuentasMaestrasDataGridView.Rows(e.RowIndex).Height - iconHeight) / 2))

        Dim rectangle As Rectangle = New Rectangle(CInt(xPosition), CInt(yPosition), CInt(iconWidth), CInt(iconHeight))

        gráfico.DrawIcon(myIcon, rectangle)

    End Sub

    ''' <summary>
    ''' borra la cuenta en la que han hecho doble click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CuentasDataGridView.RowHeaderMouseDoubleClick

        Dim resp As MsgBoxResult = MDLMensajes.MsgPregunta("¿Está seguro que quiere borrar la cuenta " +
                                                       CType(Me.CuentasBindingSource.Current, DataRowView).Item("Codigo").ToString + " - " +
                                                       CType(Me.CuentasBindingSource.Current, DataRowView).Item("Nombre").ToString +
                                                       ". ¿Quiere continuar?")

        If resp = MsgBoxResult.Yes Then

            Me.CuentasBindingSource.RemoveCurrent()
            MDLMensajes.MsgInformativo("Cuenta borrada")

        End If

    End Sub

    ''' <summary>
    ''' pinta el simbolo de borrar cuenta en las filas de las cuentas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CuentasDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles CuentasDataGridView.RowPostPaint
        'Convert the image to icon, in order to load it in the row header column
        Dim myBitmap As Bitmap = New Bitmap(My.Resources.cross)
        Dim myIcon As Icon = Icon.FromHandle(myBitmap.GetHicon())

        Dim gráfico As Graphics = e.Graphics

        'Set Image dimension - User's choice
        Dim iconHeight As UInteger = 14
        Dim iconWidth As UInteger = 14

        'Set x/y position - As the center of the RowHeaderCell
        Dim xPosition As UInteger = CUInt(e.RowBounds.X + (Me.CuentasDataGridView.RowHeadersWidth / 2))
        Dim yPosition As UInteger = CUInt(e.RowBounds.Y +
        ((Me.CuentasDataGridView.Rows(e.RowIndex).Height - iconHeight) / 2))

        Dim rectangle As Rectangle = New Rectangle(CInt(xPosition), CInt(yPosition), CInt(iconWidth), CInt(iconHeight))

        gráfico.DrawIcon(myIcon, rectangle)

    End Sub

End Class
