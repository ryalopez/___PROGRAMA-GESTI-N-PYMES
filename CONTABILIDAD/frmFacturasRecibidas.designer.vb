<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturasRecibidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasRecibidas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FacturasRecibidasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturasRecibidasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarFacturasRecibidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmitirFacturasToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.MorososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PagarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GenerarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnResumenExcel = New System.Windows.Forms.ToolStripButton()
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperacionesFacturaContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuplicarFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.CuentasMaestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nLínea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasRecibidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        Me.FacturasRecibidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.FacturasRecibidasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasRecibidasBindingNavigator.SuspendLayout()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OperacionesFacturaContextMenuStrip.SuspendLayout()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasRecibidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturasRecibidasBindingNavigator
        '
        Me.FacturasRecibidasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturasRecibidasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturasRecibidasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturasRecibidasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FacturasRecibidasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturasRecibidasBindingNavigatorSaveItem, Me.ToolStripDropDownButton1, Me.ContabilizarStripButton, Me.PagarStripButton, Me.GenerarToolStripButton, Me.btnResumenExcel})
        Me.FacturasRecibidasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturasRecibidasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturasRecibidasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturasRecibidasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturasRecibidasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturasRecibidasBindingNavigator.Name = "FacturasRecibidasBindingNavigator"
        Me.FacturasRecibidasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturasRecibidasBindingNavigator.Size = New System.Drawing.Size(1041, 27)
        Me.FacturasRecibidasBindingNavigator.TabIndex = 6
        Me.FacturasRecibidasBindingNavigator.Text = "FacturasRecibidasBindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'FacturasRecibidasBindingNavigatorSaveItem
        '
        Me.FacturasRecibidasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturasRecibidasBindingNavigatorSaveItem.Name = "FacturasRecibidasBindingNavigatorSaveItem"
        Me.FacturasRecibidasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.FacturasRecibidasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListarFacturasRecibidas, Me.btnEmitirFacturasToolStrip, Me.MorososToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Contabilidad.My.Resources.Resources.Listar
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(33, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'btnListarFacturasRecibidas
        '
        Me.btnListarFacturasRecibidas.Name = "btnListarFacturasRecibidas"
        Me.btnListarFacturasRecibidas.Size = New System.Drawing.Size(175, 22)
        Me.btnListarFacturasRecibidas.Text = "Listado de Facturas"
        '
        'btnEmitirFacturasToolStrip
        '
        Me.btnEmitirFacturasToolStrip.Name = "btnEmitirFacturasToolStrip"
        Me.btnEmitirFacturasToolStrip.Size = New System.Drawing.Size(175, 22)
        Me.btnEmitirFacturasToolStrip.Text = "Emitir Facturas"
        Me.btnEmitirFacturasToolStrip.ToolTipText = "Emitir las facturas de un mes"
        '
        'MorososToolStripMenuItem
        '
        Me.MorososToolStripMenuItem.Name = "MorososToolStripMenuItem"
        Me.MorososToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MorososToolStripMenuItem.Text = "Morosos"
        '
        'ContabilizarStripButton
        '
        Me.ContabilizarStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContabilizarStripButton.Image = CType(resources.GetObject("ContabilizarStripButton.Image"), System.Drawing.Image)
        Me.ContabilizarStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContabilizarStripButton.Name = "ContabilizarStripButton"
        Me.ContabilizarStripButton.Size = New System.Drawing.Size(24, 24)
        Me.ContabilizarStripButton.Text = "Contabilizar"
        Me.ContabilizarStripButton.ToolTipText = "Contabilizar facturas emitidas que no lo están"
        '
        'PagarStripButton
        '
        Me.PagarStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagarStripButton.Image = CType(resources.GetObject("PagarStripButton.Image"), System.Drawing.Image)
        Me.PagarStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PagarStripButton.Name = "PagarStripButton"
        Me.PagarStripButton.Size = New System.Drawing.Size(24, 24)
        Me.PagarStripButton.Text = "Contabilizar cobro de facturas"
        '
        'GenerarToolStripButton
        '
        Me.GenerarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GenerarToolStripButton.Image = CType(resources.GetObject("GenerarToolStripButton.Image"), System.Drawing.Image)
        Me.GenerarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerarToolStripButton.Name = "GenerarToolStripButton"
        Me.GenerarToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.GenerarToolStripButton.Text = "Generar"
        Me.GenerarToolStripButton.ToolTipText = "Generar facturas de un mes a partir de otro para los clientes activos"
        '
        'btnResumenExcel
        '
        Me.btnResumenExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnResumenExcel.Image = CType(resources.GetObject("btnResumenExcel.Image"), System.Drawing.Image)
        Me.btnResumenExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnResumenExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnResumenExcel.Name = "btnResumenExcel"
        Me.btnResumenExcel.Size = New System.Drawing.Size(23, 24)
        Me.btnResumenExcel.Text = "ResumenExcel"
        Me.btnResumenExcel.ToolTipText = "Resumen de facturas entre dos fechas elegidas, en formato Excel"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'OperacionesFacturaContextMenuStrip
        '
        Me.OperacionesFacturaContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OperacionesFacturaContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicarFactura, Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem})
        Me.OperacionesFacturaContextMenuStrip.Name = "OperacionesFacturaContextMenuStrip"
        Me.OperacionesFacturaContextMenuStrip.Size = New System.Drawing.Size(428, 48)
        '
        'DuplicarFactura
        '
        Me.DuplicarFactura.Name = "DuplicarFactura"
        Me.DuplicarFactura.Size = New System.Drawing.Size(427, 22)
        Me.DuplicarFactura.Text = "Duplicar con fecha de hoy y nuevo número la Factura seleccionada"
        '
        'GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem
        '
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Name = "GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem"
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Size = New System.Drawing.Size(427, 22)
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Text = "Generar la Factura seleccionada en documento Word"
        '
        'CargosBindingSource
        '
        Me.CargosBindingSource.DataMember = "FK_Cargos_Asientos"
        Me.CargosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'AbonosBindingSource
        '
        Me.AbonosBindingSource.DataMember = "FK_Abonos_Asientos"
        Me.AbonosBindingSource.DataSource = Me.AsientosBindingSource
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
        Me.TableAdapterManager.FacturasRecibidasTableAdapter = Nothing
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
        'AsientosTableAdapter
        '
        Me.AsientosTableAdapter.ClearBeforeFill = True
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'AbonosTableAdapter
        '
        Me.AbonosTableAdapter.ClearBeforeFill = True
        '
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'idFactura
        '
        Me.idFactura.DataPropertyName = "idFactura"
        Me.idFactura.HeaderText = "idFactura"
        Me.idFactura.Name = "idFactura"
        Me.idFactura.ReadOnly = True
        Me.idFactura.Visible = False
        '
        'nLínea
        '
        Me.nLínea.DataPropertyName = "nLínea"
        Me.nLínea.HeaderText = "Línea"
        Me.nLínea.Name = "nLínea"
        Me.nLínea.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.DataPropertyName = "Descripción"
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Width = 500
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'FacturasRecibidasBindingSource
        '
        Me.FacturasRecibidasBindingSource.DataMember = "FacturasRecibidas"
        Me.FacturasRecibidasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'FacturasRecibidasTableAdapter
        '
        Me.FacturasRecibidasTableAdapter.ClearBeforeFill = True
        '
        'FacturasRecibidasDataGridView
        '
        Me.FacturasRecibidasDataGridView.AllowUserToAddRows = False
        Me.FacturasRecibidasDataGridView.AllowUserToDeleteRows = False
        Me.FacturasRecibidasDataGridView.AutoGenerateColumns = False
        Me.FacturasRecibidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturasRecibidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.FacturasRecibidasDataGridView.DataSource = Me.FacturasRecibidasBindingSource
        Me.FacturasRecibidasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturasRecibidasDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.FacturasRecibidasDataGridView.Name = "FacturasRecibidasDataGridView"
        Me.FacturasRecibidasDataGridView.ReadOnly = True
        Me.FacturasRecibidasDataGridView.Size = New System.Drawing.Size(1041, 690)
        Me.FacturasRecibidasDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MiReferencia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MiReferencia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Justificante"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Justificante"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idProveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idProveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Asiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Asiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 33
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Apunte"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Apunte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 33
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CuentaIVA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CuentaIVA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 77
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Base"
        DataGridViewCellStyle1.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn9.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cuota"
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cuota"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total"
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Operación"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 300
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ProveedorCuenta"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ProveedorCuenta"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProveedorNombre"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ProveedorNombre"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ProveedorNIF"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ProveedorNIF"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FacturasRecibidasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Contabilidad.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1041, 690)
        Me.ReportViewer1.TabIndex = 7
        Me.ReportViewer1.Visible = False
        '
        'frmFacturasRecibidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1041, 717)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.FacturasRecibidasDataGridView)
        Me.Controls.Add(Me.FacturasRecibidasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturasRecibidas"
        Me.Text = "frmFacturasRecibidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FacturasRecibidasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasRecibidasBindingNavigator.ResumeLayout(False)
        Me.FacturasRecibidasBindingNavigator.PerformLayout()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OperacionesFacturaContextMenuStrip.ResumeLayout(False)
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasRecibidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents FacturasRecibidasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents FacturasRecibidasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContabilizarStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasTableAdapter
    Friend WithEvents CuentasMaestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasMaestrasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter
    Friend WithEvents AsientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsientosTableAdapter As BDContabilidadGMELOTableAdapters.AsientosTableAdapter
    Friend WithEvents CargosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargosTableAdapter As BDContabilidadGMELOTableAdapters.CargosTableAdapter
    Friend WithEvents AbonosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbonosTableAdapter As BDContabilidadGMELOTableAdapters.AbonosTableAdapter

    Friend WithEvents GenerarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnListarFacturasRecibidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEmitirFacturasToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasBancariasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasBancariasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter
    Friend WithEvents btnResumenExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents PagarStripButton As System.Windows.Forms.ToolStripButton

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

    End Sub
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NúmeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEmisiónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaOperaciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BaseImponibleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoIVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContabilizadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PagadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OperacionesFacturaContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DuplicarFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MorososToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idFactura As DataGridViewTextBoxColumn
    Friend WithEvents nLínea As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents FacturasRecibidasBindingSource As BindingSource
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
    Friend WithEvents FacturasRecibidasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
