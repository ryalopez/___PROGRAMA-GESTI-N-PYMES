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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.OperacionesFacturaContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuplicarFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarLaFacturaSeleccionadaEnDocumentoWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nLínea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasRecibidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.FacturasRecibidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERACIÓN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FacturasRecibidasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasRecibidasBindingNavigator.SuspendLayout()
        Me.OperacionesFacturaContextMenuStrip.SuspendLayout()
        CType(Me.FacturasRecibidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FacturasRecibidasBindingNavigator.Size = New System.Drawing.Size(1388, 27)
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
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'btnListarFacturasRecibidas
        '
        Me.btnListarFacturasRecibidas.Name = "btnListarFacturasRecibidas"
        Me.btnListarFacturasRecibidas.Size = New System.Drawing.Size(210, 26)
        Me.btnListarFacturasRecibidas.Text = "Listado de Facturas"
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
        'FacturasRecibidasDataGridView
        '
        Me.FacturasRecibidasDataGridView.AllowUserToAddRows = False
        Me.FacturasRecibidasDataGridView.AllowUserToDeleteRows = False
        Me.FacturasRecibidasDataGridView.AutoGenerateColumns = False
        Me.FacturasRecibidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturasRecibidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.OPERACIÓN, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn20})
        Me.FacturasRecibidasDataGridView.DataSource = Me.FacturasRecibidasBindingSource
        Me.FacturasRecibidasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturasRecibidasDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.FacturasRecibidasDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FacturasRecibidasDataGridView.Name = "FacturasRecibidasDataGridView"
        Me.FacturasRecibidasDataGridView.ReadOnly = True
        Me.FacturasRecibidasDataGridView.Size = New System.Drawing.Size(1388, 855)
        Me.FacturasRecibidasDataGridView.TabIndex = 6
        '
        'FacturasRecibidasBindingSource
        '
        Me.FacturasRecibidasBindingSource.DataMember = "FacturasRecibidas"
        Me.FacturasRecibidasBindingSource.DataSource = Me.BDContabilidadGMELO
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
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'FacturasRecibidasTableAdapter
        '
        Me.FacturasRecibidasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 33
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FechaEmisión"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FechaEmisión"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 77
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FechaOperación"
        Me.DataGridViewTextBoxColumn17.HeaderText = "FechaOperación"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 77
        '
        'OPERACIÓN
        '
        Me.OPERACIÓN.DataPropertyName = "OPERACIÓN"
        Me.OPERACIÓN.HeaderText = "OPERACIÓN"
        Me.OPERACIÓN.Name = "OPERACIÓN"
        Me.OPERACIÓN.ReadOnly = True
        Me.OPERACIÓN.Width = 333
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CIF"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CIF"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 77
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NombreProveedor"
        Me.DataGridViewTextBoxColumn19.HeaderText = "NombreProveedor"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 300
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Número"
        Me.DataGridViewTextBoxColumn11.HeaderText = "S/Refer"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "BaseImponible"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn21.HeaderText = "Base Imponible"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.ToolTipText = " "
        Me.DataGridViewTextBoxColumn21.Width = 77
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TipoIVA"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn22.HeaderText = "Tipo IVA"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 33
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Cuota"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cuota"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 77
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn24.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 77
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Clave"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 233
        '
        'frmFacturasRecibidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1388, 882)
        Me.Controls.Add(Me.FacturasRecibidasDataGridView)
        Me.Controls.Add(Me.FacturasRecibidasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmFacturasRecibidas"
        Me.Text = "frmFacturasRecibidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FacturasRecibidasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasRecibidasBindingNavigator.ResumeLayout(False)
        Me.FacturasRecibidasBindingNavigator.PerformLayout()
        Me.OperacionesFacturaContextMenuStrip.ResumeLayout(False)
        CType(Me.FacturasRecibidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents FacturasRecibidasBindingSource As BindingSource
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
    Friend WithEvents FacturasRecibidasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents OPERACIÓN As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
End Class
