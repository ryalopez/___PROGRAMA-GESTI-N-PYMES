<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturasEmitidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturasEmitidas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FacturasEmitidasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturasEmitidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
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
        Me.FacturasEmitidasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarFacturasEmitidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmitirFacturasToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.MorososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PagarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GenerarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnResumenExcel = New System.Windows.Forms.ToolStripButton()
        Me.FacturasEmitidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NúmeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEmisiónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOperaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseImponibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContabilizadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCtaBancaria = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bloqueada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OperacionesFacturaContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuplicarFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesFacturasEmitidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LíneasFacturaEmitidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LíneasFacturaEmitidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nLínea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.FacturasEmitidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasEmitidasTableAdapter()
        Me.ClientesTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.CuentasMaestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.LíneasFacturaEmitidaTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.LíneasFacturaEmitidaTableAdapter()
        Me.FacturasEmitidas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasEmitidas1TableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasEmitidas1TableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.FacturasEmitidasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasEmitidasBindingNavigator.SuspendLayout()
        CType(Me.FacturasEmitidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasEmitidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OperacionesFacturaContextMenuStrip.SuspendLayout()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFacturasEmitidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LíneasFacturaEmitidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LíneasFacturaEmitidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasEmitidas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FacturasEmitidasBindingNavigator
        '
        Me.FacturasEmitidasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturasEmitidasBindingNavigator.BindingSource = Me.FacturasEmitidasBindingSource
        Me.FacturasEmitidasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturasEmitidasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturasEmitidasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FacturasEmitidasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturasEmitidasBindingNavigatorSaveItem, Me.ToolStripDropDownButton1, Me.ContabilizarStripButton, Me.PagarStripButton, Me.GenerarToolStripButton, Me.btnResumenExcel})
        Me.FacturasEmitidasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturasEmitidasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturasEmitidasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturasEmitidasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturasEmitidasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturasEmitidasBindingNavigator.Name = "FacturasEmitidasBindingNavigator"
        Me.FacturasEmitidasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturasEmitidasBindingNavigator.Size = New System.Drawing.Size(1459, 27)
        Me.FacturasEmitidasBindingNavigator.TabIndex = 6
        Me.FacturasEmitidasBindingNavigator.Text = "FacturasEmitidasBindingNavigator"
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
        'FacturasEmitidasBindingSource
        '
        Me.FacturasEmitidasBindingSource.DataMember = "FacturasEmitidas"
        Me.FacturasEmitidasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListarFacturasEmitidas, Me.btnEmitirFacturasToolStrip, Me.MorososToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(14, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'btnListarFacturasEmitidas
        '
        Me.btnListarFacturasEmitidas.Name = "btnListarFacturasEmitidas"
        Me.btnListarFacturasEmitidas.Size = New System.Drawing.Size(210, 26)
        Me.btnListarFacturasEmitidas.Text = "Listado de Facturas"
        '
        'btnEmitirFacturasToolStrip
        '
        Me.btnEmitirFacturasToolStrip.Name = "btnEmitirFacturasToolStrip"
        Me.btnEmitirFacturasToolStrip.Size = New System.Drawing.Size(210, 26)
        Me.btnEmitirFacturasToolStrip.Text = "Emitir Facturas"
        Me.btnEmitirFacturasToolStrip.ToolTipText = "Emitir las facturas de un mes"
        '
        'MorososToolStripMenuItem
        '
        Me.MorososToolStripMenuItem.Name = "MorososToolStripMenuItem"
        Me.MorososToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
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
        'FacturasEmitidasDataGridView
        '
        Me.FacturasEmitidasDataGridView.AllowUserToAddRows = False
        Me.FacturasEmitidasDataGridView.AllowUserToOrderColumns = True
        Me.FacturasEmitidasDataGridView.AutoGenerateColumns = False
        Me.FacturasEmitidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturasEmitidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NúmeroDataGridViewTextBoxColumn, Me.FechaEmisiónDataGridViewTextBoxColumn, Me.FechaOperaciónDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.BaseImponibleDataGridViewTextBoxColumn, Me.TipoIVADataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.TotalFactura, Me.ContabilizadaDataGridViewCheckBoxColumn, Me.PagadaDataGridViewCheckBoxColumn, Me.FechaPago, Me.idCtaBancaria, Me.Bloqueada})
        Me.FacturasEmitidasDataGridView.ContextMenuStrip = Me.OperacionesFacturaContextMenuStrip
        Me.FacturasEmitidasDataGridView.DataSource = Me.FacturasEmitidasBindingSource
        Me.FacturasEmitidasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturasEmitidasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.FacturasEmitidasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.FacturasEmitidasDataGridView.Name = "FacturasEmitidasDataGridView"
        Me.FacturasEmitidasDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FacturasEmitidasDataGridView.Size = New System.Drawing.Size(1459, 746)
        Me.FacturasEmitidasDataGridView.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 33
        '
        'NúmeroDataGridViewTextBoxColumn
        '
        Me.NúmeroDataGridViewTextBoxColumn.DataPropertyName = "Número"
        Me.NúmeroDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.NúmeroDataGridViewTextBoxColumn.Name = "NúmeroDataGridViewTextBoxColumn"
        Me.NúmeroDataGridViewTextBoxColumn.Width = 63
        '
        'FechaEmisiónDataGridViewTextBoxColumn
        '
        Me.FechaEmisiónDataGridViewTextBoxColumn.DataPropertyName = "FechaEmisión"
        Me.FechaEmisiónDataGridViewTextBoxColumn.HeaderText = "Fecha Emisión"
        Me.FechaEmisiónDataGridViewTextBoxColumn.Name = "FechaEmisiónDataGridViewTextBoxColumn"
        Me.FechaEmisiónDataGridViewTextBoxColumn.Width = 87
        '
        'FechaOperaciónDataGridViewTextBoxColumn
        '
        Me.FechaOperaciónDataGridViewTextBoxColumn.DataPropertyName = "FechaOperación"
        Me.FechaOperaciónDataGridViewTextBoxColumn.HeaderText = "Fecha Operación"
        Me.FechaOperaciónDataGridViewTextBoxColumn.Name = "FechaOperaciónDataGridViewTextBoxColumn"
        Me.FechaOperaciónDataGridViewTextBoxColumn.Width = 87
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.DataSource = Me.ClientesBindingSource
        Me.IdClienteDataGridViewTextBoxColumn.DisplayMember = "NomyApes"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdClienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdClienteDataGridViewTextBoxColumn.ValueMember = "id"
        Me.IdClienteDataGridViewTextBoxColumn.Width = 300
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.ClientesBindingSource.Sort = "NomyApes"
        '
        'BaseImponibleDataGridViewTextBoxColumn
        '
        Me.BaseImponibleDataGridViewTextBoxColumn.DataPropertyName = "BaseImponible"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.BaseImponibleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.BaseImponibleDataGridViewTextBoxColumn.HeaderText = "Base Imponible"
        Me.BaseImponibleDataGridViewTextBoxColumn.Name = "BaseImponibleDataGridViewTextBoxColumn"
        '
        'TipoIVADataGridViewTextBoxColumn
        '
        Me.TipoIVADataGridViewTextBoxColumn.DataPropertyName = "TipoIVA"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TipoIVADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TipoIVADataGridViewTextBoxColumn.HeaderText = "Tipo IVA"
        Me.TipoIVADataGridViewTextBoxColumn.Name = "TipoIVADataGridViewTextBoxColumn"
        '
        'CuotaDataGridViewTextBoxColumn
        '
        Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CuotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
        Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFactura
        '
        Me.TotalFactura.DataPropertyName = "Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.TotalFactura.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalFactura.HeaderText = "Total Factura"
        Me.TotalFactura.Name = "TotalFactura"
        Me.TotalFactura.ReadOnly = True
        '
        'ContabilizadaDataGridViewCheckBoxColumn
        '
        Me.ContabilizadaDataGridViewCheckBoxColumn.DataPropertyName = "Contabilizada"
        Me.ContabilizadaDataGridViewCheckBoxColumn.HeaderText = "Contabilizada"
        Me.ContabilizadaDataGridViewCheckBoxColumn.Name = "ContabilizadaDataGridViewCheckBoxColumn"
        Me.ContabilizadaDataGridViewCheckBoxColumn.Width = 77
        '
        'PagadaDataGridViewCheckBoxColumn
        '
        Me.PagadaDataGridViewCheckBoxColumn.DataPropertyName = "Pagada"
        Me.PagadaDataGridViewCheckBoxColumn.HeaderText = "Pagada"
        Me.PagadaDataGridViewCheckBoxColumn.Name = "PagadaDataGridViewCheckBoxColumn"
        Me.PagadaDataGridViewCheckBoxColumn.Width = 77
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaPago"
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Width = 77
        '
        'idCtaBancaria
        '
        Me.idCtaBancaria.DataPropertyName = "idCtaBancaria"
        Me.idCtaBancaria.DataSource = Me.CuentasBancariasBindingSource
        Me.idCtaBancaria.DisplayMember = "Banco"
        Me.idCtaBancaria.HeaderText = "Cuenta Bancaria"
        Me.idCtaBancaria.Name = "idCtaBancaria"
        Me.idCtaBancaria.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCtaBancaria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.idCtaBancaria.ValueMember = "id"
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'Bloqueada
        '
        Me.Bloqueada.DataPropertyName = "Bloqueada"
        Me.Bloqueada.HeaderText = "Bloqueada"
        Me.Bloqueada.Name = "Bloqueada"
        Me.Bloqueada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'OperacionesFacturaContextMenuStrip
        '
        Me.OperacionesFacturaContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OperacionesFacturaContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicarFactura, Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem})
        Me.OperacionesFacturaContextMenuStrip.Name = "OperacionesFacturaContextMenuStrip"
        Me.OperacionesFacturaContextMenuStrip.Size = New System.Drawing.Size(519, 52)
        '
        'DuplicarFactura
        '
        Me.DuplicarFactura.Name = "DuplicarFactura"
        Me.DuplicarFactura.Size = New System.Drawing.Size(518, 24)
        Me.DuplicarFactura.Text = "Duplicar con fecha de hoy y nuevo número la Factura seleccionada"
        '
        'GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem
        '
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Name = "GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem"
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem.Size = New System.Drawing.Size(518, 24)
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
        'ClientesFacturasEmitidasBindingSource
        '
        Me.ClientesFacturasEmitidasBindingSource.DataMember = "Clientes_FacturasEmitidas"
        Me.ClientesFacturasEmitidasBindingSource.DataSource = Me.ClientesBindingSource
        '
        'LíneasFacturaEmitidaBindingSource
        '
        Me.LíneasFacturaEmitidaBindingSource.DataMember = "FK_LíneasFacturaEmitida_FacturasEmitidas"
        Me.LíneasFacturaEmitidaBindingSource.DataSource = Me.FacturasEmitidasBindingSource
        '
        'LíneasFacturaEmitidaDataGridView
        '
        Me.LíneasFacturaEmitidaDataGridView.AutoGenerateColumns = False
        Me.LíneasFacturaEmitidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LíneasFacturaEmitidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.idFactura, Me.nLínea, Me.Descripción, Me.Importe})
        Me.LíneasFacturaEmitidaDataGridView.DataMember = "FK_LíneasFacturaEmitida_FacturasEmitidas"
        Me.LíneasFacturaEmitidaDataGridView.DataSource = Me.FacturasEmitidasBindingSource
        Me.LíneasFacturaEmitidaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LíneasFacturaEmitidaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LíneasFacturaEmitidaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.LíneasFacturaEmitidaDataGridView.Name = "LíneasFacturaEmitidaDataGridView"
        Me.LíneasFacturaEmitidaDataGridView.Size = New System.Drawing.Size(1459, 124)
        Me.LíneasFacturaEmitidaDataGridView.TabIndex = 6
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
        Me.TableAdapterManager.CuentasProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.FacturasEmitidas1TableAdapter = Nothing
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
        Me.TableAdapterManager.PréstamosLargoPlazoTableAdapter = Nothing
        Me.TableAdapterManager.PréstamosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
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
        'FacturasEmitidasTableAdapter
        '
        Me.FacturasEmitidasTableAdapter.ClearBeforeFill = True
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
        'LíneasFacturaEmitidaTableAdapter
        '
        Me.LíneasFacturaEmitidaTableAdapter.ClearBeforeFill = True
        '
        'FacturasEmitidas1BindingSource
        '
        Me.FacturasEmitidas1BindingSource.DataMember = "FacturasEmitidas1"
        Me.FacturasEmitidas1BindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'FacturasEmitidas1TableAdapter
        '
        Me.FacturasEmitidas1TableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FacturasEmitidasDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LíneasFacturaEmitidaDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1459, 875)
        Me.SplitContainer1.SplitterDistance = 746
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 7
        '
        'FrmFacturasEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1459, 902)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FacturasEmitidasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFacturasEmitidas"
        Me.Text = "frmFacturasEmitidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FacturasEmitidasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasEmitidasBindingNavigator.ResumeLayout(False)
        Me.FacturasEmitidasBindingNavigator.PerformLayout()
        CType(Me.FacturasEmitidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasEmitidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OperacionesFacturaContextMenuStrip.ResumeLayout(False)
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFacturasEmitidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LíneasFacturaEmitidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LíneasFacturaEmitidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasEmitidas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents FacturasEmitidasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FacturasEmitidasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FacturasEmitidasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasEmitidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasEmitidasTableAdapter
    Friend WithEvents FacturasEmitidasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As BDContabilidadGMELOTableAdapters.ClientesTableAdapter
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
    Friend WithEvents btnListarFacturasEmitidas As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents CuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContabilizadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PagadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCtaBancaria As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Bloqueada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OperacionesFacturaContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DuplicarFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MorososToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesFacturasEmitidasBindingSource As BindingSource
    Friend WithEvents LíneasFacturaEmitidaBindingSource As BindingSource
    Friend WithEvents LíneasFacturaEmitidaTableAdapter As BDContabilidadGMELOTableAdapters.LíneasFacturaEmitidaTableAdapter
    Friend WithEvents LíneasFacturaEmitidaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idFactura As DataGridViewTextBoxColumn
    Friend WithEvents nLínea As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents FacturasEmitidas1BindingSource As BindingSource
    Friend WithEvents FacturasEmitidas1TableAdapter As BDContabilidadGMELOTableAdapters.FacturasEmitidas1TableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
