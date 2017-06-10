<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalítica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalítica))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.NóminasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.NóminasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturasEmitidasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarNóminas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGenerarResumenExcel = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.CuentasMaestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.AbonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.NóminasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.NóminasTableAdapter()
        Me.EmpleadosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter()
        Me.BDContabilidadGMELO_2016DataSet = New Contabilidad.BDContabilidadGMELO_2016DataSet()
        Me.ResumenGastosTableAdapter = New Contabilidad.BDContabilidadGMELO_2016DataSetTableAdapters.ResumenGastosTableAdapter()
        Me.TableAdapterManager1 = New Contabilidad.BDContabilidadGMELO_2016DataSetTableAdapters.TableAdapterManager()
        Me.ResumenCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenCuentaTableAdapter = New Contabilidad.BDContabilidadGMELO_2016DataSetTableAdapters.ResumenCuentaTableAdapter()
        Me.ResumenGastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.NóminasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NóminasBindingNavigator.SuspendLayout()
        CType(Me.NóminasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO_2016DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenGastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NóminasBindingNavigator
        '
        Me.NóminasBindingNavigator.AddNewItem = Nothing
        Me.NóminasBindingNavigator.BindingSource = Me.NóminasBindingSource
        Me.NóminasBindingNavigator.CountItem = Nothing
        Me.NóminasBindingNavigator.DeleteItem = Nothing
        Me.NóminasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NóminasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.FacturasEmitidasBindingNavigatorSaveItem, Me.ToolStripDropDownButton1, Me.btnGenerarResumenExcel})
        Me.NóminasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NóminasBindingNavigator.MoveFirstItem = Nothing
        Me.NóminasBindingNavigator.MoveLastItem = Nothing
        Me.NóminasBindingNavigator.MoveNextItem = Nothing
        Me.NóminasBindingNavigator.MovePreviousItem = Nothing
        Me.NóminasBindingNavigator.Name = "NóminasBindingNavigator"
        Me.NóminasBindingNavigator.PositionItem = Nothing
        Me.NóminasBindingNavigator.Size = New System.Drawing.Size(1218, 27)
        Me.NóminasBindingNavigator.TabIndex = 6
        Me.NóminasBindingNavigator.Text = "FacturasEmitidasBindingNavigator"
        '
        'NóminasBindingSource
        '
        Me.NóminasBindingSource.DataMember = "Nóminas"
        Me.NóminasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.Contabilidad.My.Resources.Resources.HomeHS
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(24, 24)
        Me.btnSalir.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'FacturasEmitidasBindingNavigatorSaveItem
        '
        Me.FacturasEmitidasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturasEmitidasBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturasEmitidasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturasEmitidasBindingNavigatorSaveItem.Name = "FacturasEmitidasBindingNavigatorSaveItem"
        Me.FacturasEmitidasBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.FacturasEmitidasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListarNóminas})
        Me.ToolStripDropDownButton1.Image = Global.Contabilidad.My.Resources.Resources.Listar
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(33, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'btnListarNóminas
        '
        Me.btnListarNóminas.Name = "btnListarNóminas"
        Me.btnListarNóminas.Size = New System.Drawing.Size(179, 22)
        Me.btnListarNóminas.Text = "Listado de Nóminas"
        Me.btnListarNóminas.ToolTipText = "Lista las nóminas"
        '
        'btnGenerarResumenExcel
        '
        Me.btnGenerarResumenExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGenerarResumenExcel.Image = CType(resources.GetObject("btnGenerarResumenExcel.Image"), System.Drawing.Image)
        Me.btnGenerarResumenExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarResumenExcel.Name = "btnGenerarResumenExcel"
        Me.btnGenerarResumenExcel.Size = New System.Drawing.Size(24, 24)
        Me.btnGenerarResumenExcel.Text = "Generar Hoja de Excel con resumen de Nóminas entre las fechas que elija"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.CNO11TableAdapter = Nothing
        Me.TableAdapterManager.CNO94TableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ConvenioCategoríasConceptosTableAdapter = Nothing
        Me.TableAdapterManager.ConvenioCategoríasTableAdapter = Nothing
        Me.TableAdapterManager.ConvenioGruposTableAdapter = Nothing
        Me.TableAdapterManager.Convenios_ColectivosJulio2014TableAdapter = Nothing
        Me.TableAdapterManager.ConveniosEmpresasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.Cta1TableAdapter = Nothing
        Me.TableAdapterManager.Cta2TableAdapter = Nothing
        Me.TableAdapterManager.CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasMaestrasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.FacturasEmitidasTableAdapter = Nothing
        Me.TableAdapterManager.FormasPagoTableAdapter = Nothing
        Me.TableAdapterManager.LíneasDiarioTableAdapter = Nothing
        Me.TableAdapterManager.LíneasFacturaEmitidaTableAdapter = Nothing
        Me.TableAdapterManager.LíneasMayorTableAdapter = Nothing
        Me.TableAdapterManager.NóminaConceptosTableAdapter = Nothing
        Me.TableAdapterManager.NóminasDeEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.NominasDeEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.NóminasTableAdapter = Nothing
        Me.TableAdapterManager.PaisesTableAdapter = Nothing
        Me.TableAdapterManager.PerdidasyGananciasSeccionesTableAdapter = Nothing
        Me.TableAdapterManager.PérdidasyGananciasTableAdapter = Nothing
        Me.TableAdapterManager.PoblacionesTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciasTableAdapter = Nothing
        Me.TableAdapterManager.PuestosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.SexosTableAdapter = Nothing
        Me.TableAdapterManager.TiposComplementoSalarialTableAdapter = Nothing
        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Nothing
        Me.TableAdapterManager.TiposNóminaTableAdapter = Nothing
        Me.TableAdapterManager.TiposVíaTableAdapter = Nothing
        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'CuentasMaestrasBindingSource
        '
        Me.CuentasMaestrasBindingSource.DataMember = "CuentasMaestras"
        Me.CuentasMaestrasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasMaestrasTableAdapter
        '
        Me.CuentasMaestrasTableAdapter.ClearBeforeFill = True
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'AsientosTableAdapter
        '
        Me.AsientosTableAdapter.ClearBeforeFill = True
        '
        'CargosBindingSource
        '
        Me.CargosBindingSource.DataMember = "FK_Cargos_Asientos"
        Me.CargosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'AbonosBindingSource
        '
        Me.AbonosBindingSource.DataMember = "FK_Abonos_Asientos"
        Me.AbonosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'AbonosTableAdapter
        '
        Me.AbonosTableAdapter.ClearBeforeFill = True
        '
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'NóminasTableAdapter
        '
        Me.NóminasTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'BDContabilidadGMELO_2016DataSet
        '
        Me.BDContabilidadGMELO_2016DataSet.DataSetName = "BDContabilidadGMELO_2016DataSet"
        Me.BDContabilidadGMELO_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResumenGastosTableAdapter
        '
        Me.ResumenGastosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ResumenCuentaTableAdapter = Nothing
        Me.TableAdapterManager1.ResumenGastosTableAdapter = Me.ResumenGastosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Contabilidad.BDContabilidadGMELO_2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ResumenCuentaBindingSource
        '
        Me.ResumenCuentaBindingSource.DataMember = "ResumenCuenta"
        Me.ResumenCuentaBindingSource.DataSource = Me.BDContabilidadGMELO_2016DataSet
        '
        'ResumenCuentaTableAdapter
        '
        Me.ResumenCuentaTableAdapter.ClearBeforeFill = True
        '
        'ResumenGastosBindingSource
        '
        Me.ResumenGastosBindingSource.DataMember = "ResumenGastos"
        Me.ResumenGastosBindingSource.DataSource = Me.BDContabilidadGMELO_2016DataSet
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(0, 27)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(1218, 559)
        Me.Chart2.TabIndex = 7
        Me.Chart2.Text = "Chart1"
        '
        'frmAnalítica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1218, 586)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.NóminasBindingNavigator)
        Me.Name = "frmAnalítica"
        Me.Text = "frmFacturasEmitidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NóminasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NóminasBindingNavigator.ResumeLayout(False)
        Me.NóminasBindingNavigator.PerformLayout()
        CType(Me.NóminasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO_2016DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenGastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents NóminasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BDContabilidadGMELO As Contabilidad.BDContabilidadGMELO
    Friend WithEvents FacturasEmitidasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter
    Friend WithEvents CuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter
    Friend WithEvents CuentasMaestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasMaestrasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter
    Friend WithEvents AsientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsientosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter
    Friend WithEvents CargosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter
    Friend WithEvents AbonosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbonosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnListarNóminas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasBancariasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasBancariasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter
    Friend WithEvents NóminasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NóminasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.NóminasTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter
    Friend WithEvents btnGenerarResumenExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResumenCuentaBindingSource As BindingSource
    Friend WithEvents ResumenGastosBindingSource As BindingSource
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
End Class
