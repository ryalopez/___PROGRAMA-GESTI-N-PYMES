<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AsientosPanel = New System.Windows.Forms.Panel()
        Me.AsientosDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AsientosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadMelo = New Contabilidad.BDContabilidadGMELO()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarAsiento = New System.Windows.Forms.ToolStripLabel()
        Me.btnBorrarAsiento = New System.Windows.Forms.ToolStripButton()
        Me.AsientosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Listados = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarDiario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsientosDescuadradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRenum = New System.Windows.Forms.ToolStripButton()
        Me.btnCierre = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.BuscarNúmeroAsientoTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.AnteriorImporteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BuscarImporteAsientoTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SiguienteImporteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.AnteriorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BuscarTextoTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SiguienteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.AsientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuOPERACIONES = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargosPanel = New System.Windows.Forms.Panel()
        Me.CargosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnBorrarCargo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarCargo = New System.Windows.Forms.ToolStripButton()
        Me.CargosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKCargosAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosPanel = New System.Windows.Forms.Panel()
        Me.AbonosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AbonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnBorrarAbono = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarAbono = New System.Windows.Forms.ToolStripButton()
        Me.AbonosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKAbonosAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpcionesAsientosContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuplicarAsientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.FacturasRecibidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        Me.AsientosPanel.SuspendLayout()
        CType(Me.AsientosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AsientosBindingNavigator.SuspendLayout()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadMelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuOPERACIONES.SuspendLayout()
        Me.CargosPanel.SuspendLayout()
        CType(Me.CargosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CargosBindingNavigator.SuspendLayout()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCargosAsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbonosPanel.SuspendLayout()
        CType(Me.AbonosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbonosBindingNavigator.SuspendLayout()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKAbonosAsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpcionesAsientosContextMenuStrip.SuspendLayout()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsientosPanel
        '
        Me.AsientosPanel.Controls.Add(Me.AsientosDateTimePicker)
        Me.AsientosPanel.Controls.Add(Me.AsientosBindingNavigator)
        Me.AsientosPanel.Controls.Add(Me.AsientosDataGridView)
        Me.AsientosPanel.Location = New System.Drawing.Point(0, 0)
        Me.AsientosPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AsientosPanel.Name = "AsientosPanel"
        Me.AsientosPanel.Size = New System.Drawing.Size(1321, 445)
        Me.AsientosPanel.TabIndex = 0
        '
        'AsientosDateTimePicker
        '
        Me.AsientosDateTimePicker.AccessibleName = ""
        Me.AsientosDateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightGray
        Me.AsientosDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AsientosDateTimePicker.Location = New System.Drawing.Point(877, 3)
        Me.AsientosDateTimePicker.Name = "AsientosDateTimePicker"
        Me.AsientosDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.AsientosDateTimePicker.TabIndex = 2
        '
        'AsientosBindingNavigator
        '
        Me.AsientosBindingNavigator.AddNewItem = Nothing
        Me.AsientosBindingNavigator.BindingSource = Me.AsientosBindingSource
        Me.AsientosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AsientosBindingNavigator.DeleteItem = Nothing
        Me.AsientosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AsientosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AsientosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AgregarAsiento, Me.btnBorrarAsiento, Me.AsientosBindingNavigatorSaveItem, Me.Listados, Me.btnRenum, Me.btnCierre, Me.ToolStripSeparator8, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.BuscarNúmeroAsientoTextBox, Me.ToolStripSeparator11, Me.ToolStripLabel7, Me.AnteriorImporteToolStripButton, Me.BuscarImporteAsientoTextBox, Me.SiguienteImporteToolStripButton, Me.ToolStripSeparator9, Me.ToolStripLabel5, Me.AnteriorToolStripButton, Me.BuscarTextoTextBox, Me.SiguienteToolStripButton, Me.ToolStripSeparator10, Me.ToolStripLabel6})
        Me.AsientosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AsientosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AsientosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AsientosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AsientosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AsientosBindingNavigator.Name = "AsientosBindingNavigator"
        Me.AsientosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AsientosBindingNavigator.Size = New System.Drawing.Size(939, 27)
        Me.AsientosBindingNavigator.TabIndex = 1
        Me.AsientosBindingNavigator.Text = "BindingNavigator1"
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.AllowNew = True
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadMelo
        Me.AsientosBindingSource.Sort = "Fecha"
        '
        'BDContabilidadMelo
        '
        Me.BDContabilidadMelo.DataSetName = "dsGrupos"
        Me.BDContabilidadMelo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'btnCerrar
        '
        Me.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCerrar.Image = Global.Contabilidad.My.Resources.Resources.HomeHS
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btnCerrar.Text = "ToolStripButton1"
        Me.btnCerrar.ToolTipText = "Salir de la pantalla de entrada de asientos"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
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
        'AgregarAsiento
        '
        Me.AgregarAsiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AgregarAsiento.Image = CType(resources.GetObject("AgregarAsiento.Image"), System.Drawing.Image)
        Me.AgregarAsiento.Name = "AgregarAsiento"
        Me.AgregarAsiento.Size = New System.Drawing.Size(20, 24)
        '
        'btnBorrarAsiento
        '
        Me.btnBorrarAsiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBorrarAsiento.Image = CType(resources.GetObject("btnBorrarAsiento.Image"), System.Drawing.Image)
        Me.btnBorrarAsiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrarAsiento.Name = "btnBorrarAsiento"
        Me.btnBorrarAsiento.Size = New System.Drawing.Size(24, 24)
        Me.btnBorrarAsiento.Text = "ToolStripButton8"
        '
        'AsientosBindingNavigatorSaveItem
        '
        Me.AsientosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AsientosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AsientosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AsientosBindingNavigatorSaveItem.Name = "AsientosBindingNavigatorSaveItem"
        Me.AsientosBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.AsientosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Listados
        '
        Me.Listados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Listados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListarDiario, Me.AsientosDescuadradosToolStripMenuItem})
        Me.Listados.Image = Global.Contabilidad.My.Resources.Resources.Listar
        Me.Listados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Listados.Name = "Listados"
        Me.Listados.Size = New System.Drawing.Size(33, 24)
        Me.Listados.Text = "ToolStripButton8"
        Me.Listados.ToolTipText = "Listados disponibles"
        '
        'btnListarDiario
        '
        Me.btnListarDiario.Name = "btnListarDiario"
        Me.btnListarDiario.Size = New System.Drawing.Size(196, 22)
        Me.btnListarDiario.Text = "Libro Diario"
        '
        'AsientosDescuadradosToolStripMenuItem
        '
        Me.AsientosDescuadradosToolStripMenuItem.Name = "AsientosDescuadradosToolStripMenuItem"
        Me.AsientosDescuadradosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AsientosDescuadradosToolStripMenuItem.Text = "Asientos Descuadrados"
        '
        'btnRenum
        '
        Me.btnRenum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRenum.Image = CType(resources.GetObject("btnRenum.Image"), System.Drawing.Image)
        Me.btnRenum.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRenum.Name = "btnRenum"
        Me.btnRenum.Size = New System.Drawing.Size(24, 24)
        Me.btnRenum.ToolTipText = "Renumerar los asientos."
        '
        'btnCierre
        '
        Me.btnCierre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCierre.Image = CType(resources.GetObject("btnCierre.Image"), System.Drawing.Image)
        Me.btnCierre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCierre.Name = "btnCierre"
        Me.btnCierre.Size = New System.Drawing.Size(24, 24)
        Me.btnCierre.ToolTipText = "Cierre del Ejercicio. Es recomendable hacer antes una copia."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Image = CType(resources.GetObject("ToolStripLabel3.Image"), System.Drawing.Image)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(20, 24)
        Me.ToolStripLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.ToolStripLabel3.ToolTipText = "Buscar asientos. Seleccione una fecha, un número de asiento o un texto"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel4.Image = CType(resources.GetObject("ToolStripLabel4.Image"), System.Drawing.Image)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(20, 24)
        Me.ToolStripLabel4.Text = "#"
        Me.ToolStripLabel4.ToolTipText = "Búsca por número de asiento"
        '
        'BuscarNúmeroAsientoTextBox
        '
        Me.BuscarNúmeroAsientoTextBox.BackColor = System.Drawing.Color.LightGray
        Me.BuscarNúmeroAsientoTextBox.Name = "BuscarNúmeroAsientoTextBox"
        Me.BuscarNúmeroAsientoTextBox.Size = New System.Drawing.Size(50, 27)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel7.Image = CType(resources.GetObject("ToolStripLabel7.Image"), System.Drawing.Image)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(20, 24)
        Me.ToolStripLabel7.Text = "€"
        Me.ToolStripLabel7.ToolTipText = "Busca asientos que tengan el debe o el haber igual a la cantidad que escriba." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si" &
    " encuentra más de uno puede navegar con las flechas."
        '
        'AnteriorImporteToolStripButton
        '
        Me.AnteriorImporteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnteriorImporteToolStripButton.ForeColor = System.Drawing.Color.Red
        Me.AnteriorImporteToolStripButton.Image = CType(resources.GetObject("AnteriorImporteToolStripButton.Image"), System.Drawing.Image)
        Me.AnteriorImporteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AnteriorImporteToolStripButton.Name = "AnteriorImporteToolStripButton"
        Me.AnteriorImporteToolStripButton.Size = New System.Drawing.Size(24, 24)
        '
        'BuscarImporteAsientoTextBox
        '
        Me.BuscarImporteAsientoTextBox.BackColor = System.Drawing.Color.LightGray
        Me.BuscarImporteAsientoTextBox.Name = "BuscarImporteAsientoTextBox"
        Me.BuscarImporteAsientoTextBox.Size = New System.Drawing.Size(50, 27)
        '
        'SiguienteImporteToolStripButton
        '
        Me.SiguienteImporteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SiguienteImporteToolStripButton.ForeColor = System.Drawing.Color.Red
        Me.SiguienteImporteToolStripButton.Image = CType(resources.GetObject("SiguienteImporteToolStripButton.Image"), System.Drawing.Image)
        Me.SiguienteImporteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SiguienteImporteToolStripButton.Name = "SiguienteImporteToolStripButton"
        Me.SiguienteImporteToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.SiguienteImporteToolStripButton.Text = "S"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Image = CType(resources.GetObject("ToolStripLabel5.Image"), System.Drawing.Image)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(20, 24)
        Me.ToolStripLabel5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.ToolStripLabel5.ToolTipText = "Busca asientos que contengan en el justificante o la operación el texto que escri" &
    "ba." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si encuentra más de uno puede navegar con las flechas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AnteriorToolStripButton
        '
        Me.AnteriorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnteriorToolStripButton.ForeColor = System.Drawing.Color.Red
        Me.AnteriorToolStripButton.Image = CType(resources.GetObject("AnteriorToolStripButton.Image"), System.Drawing.Image)
        Me.AnteriorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AnteriorToolStripButton.Name = "AnteriorToolStripButton"
        Me.AnteriorToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.AnteriorToolStripButton.Text = "A"
        '
        'BuscarTextoTextBox
        '
        Me.BuscarTextoTextBox.BackColor = System.Drawing.Color.LightGray
        Me.BuscarTextoTextBox.Name = "BuscarTextoTextBox"
        Me.BuscarTextoTextBox.Size = New System.Drawing.Size(200, 27)
        '
        'SiguienteToolStripButton
        '
        Me.SiguienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SiguienteToolStripButton.ForeColor = System.Drawing.Color.Red
        Me.SiguienteToolStripButton.Image = CType(resources.GetObject("SiguienteToolStripButton.Image"), System.Drawing.Image)
        Me.SiguienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SiguienteToolStripButton.Name = "SiguienteToolStripButton"
        Me.SiguienteToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.SiguienteToolStripButton.Text = "S"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Image = CType(resources.GetObject("ToolStripLabel6.Image"), System.Drawing.Image)
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(20, 24)
        Me.ToolStripLabel6.ToolTipText = "Busca asientos de la fecha que seleccione en el calendario." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AsientosDataGridView
        '
        Me.AsientosDataGridView.AllowUserToAddRows = False
        Me.AsientosDataGridView.AutoGenerateColumns = False
        Me.AsientosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AsientosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AsientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AsientosDataGridView.DataSource = Me.AsientosBindingSource
        Me.AsientosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AsientosDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.AsientosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AsientosDataGridView.Name = "AsientosDataGridView"
        Me.AsientosDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AsientosDataGridView.RowTemplate.Height = 24
        Me.AsientosDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AsientosDataGridView.Size = New System.Drawing.Size(1321, 418)
        Me.AsientosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Fecha del asiento"
        Me.DataGridViewTextBoxColumn2.Width = 133
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Número"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Garamond", 12.0!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Número de asiento"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Justificante"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Garamond", 12.0!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Justificante"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Documento justificativo de la operación"
        Me.DataGridViewTextBoxColumn3.Width = 350
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.ContextMenuStrip = Me.ContextMenuOPERACIONES
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Operación"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Garamond", 12.0!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Operación que refleja el acto contable"
        Me.DataGridViewTextBoxColumn4.Width = 523
        '
        'ContextMenuOPERACIONES
        '
        Me.ContextMenuOPERACIONES.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuOPERACIONES.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.ToolStripMenuItem10, Me.ToolStripMenuItem8, Me.ToolStripMenuItem11, Me.ToolStripMenuItem1, Me.ToolStripMenuItem7, Me.ToolStripMenuItem9, Me.ToolStripMenuItem6, Me.ToolStripMenuItem5})
        Me.ContextMenuOPERACIONES.Name = "ContextMenuOPERACIONES"
        Me.ContextMenuOPERACIONES.Size = New System.Drawing.Size(188, 246)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.CheckOnClick = True
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem4.Text = "Atención clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.CheckOnClick = True
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem3.Text = "Compra"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.CheckOnClick = True
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem2.Text = "Envío Postal"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem10.Text = "Gastos Aparcamiento"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem8.Text = "Gastos Bancarios"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem11.Text = "Gastos Combustible"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.CheckOnClick = True
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem1.Text = "Disposición Tarjeta"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem7.Text = "Mantenimiento"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem9.Text = "Pago talón"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem6.Text = "Préstamo ICO"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.CheckOnClick = True
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem5.Text = "Reparaciones"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Debe"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Garamond", 12.0!)
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Debe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Haber"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Garamond", 12.0!)
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Haber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'CargosPanel
        '
        Me.CargosPanel.Controls.Add(Me.CargosBindingNavigator)
        Me.CargosPanel.Controls.Add(Me.CargosDataGridView)
        Me.CargosPanel.Location = New System.Drawing.Point(0, 450)
        Me.CargosPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CargosPanel.Name = "CargosPanel"
        Me.CargosPanel.Size = New System.Drawing.Size(650, 179)
        Me.CargosPanel.TabIndex = 1
        '
        'CargosBindingNavigator
        '
        Me.CargosBindingNavigator.AddNewItem = Nothing
        Me.CargosBindingNavigator.BindingSource = Me.CargosBindingSource
        Me.CargosBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.CargosBindingNavigator.DeleteItem = Me.btnBorrarCargo
        Me.CargosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CargosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator5, Me.AgregarCargo, Me.btnBorrarCargo})
        Me.CargosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CargosBindingNavigator.MoveFirstItem = Me.ToolStripButton4
        Me.CargosBindingNavigator.MoveLastItem = Me.ToolStripButton7
        Me.CargosBindingNavigator.MoveNextItem = Me.ToolStripButton6
        Me.CargosBindingNavigator.MovePreviousItem = Me.ToolStripButton5
        Me.CargosBindingNavigator.Name = "CargosBindingNavigator"
        Me.CargosBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.CargosBindingNavigator.Size = New System.Drawing.Size(650, 27)
        Me.CargosBindingNavigator.TabIndex = 3
        Me.CargosBindingNavigator.Text = "BindingNavigator1"
        '
        'CargosBindingSource
        '
        Me.CargosBindingSource.DataMember = "FK_Cargos_Asientos"
        Me.CargosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 24)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'btnBorrarCargo
        '
        Me.btnBorrarCargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBorrarCargo.Image = CType(resources.GetObject("btnBorrarCargo.Image"), System.Drawing.Image)
        Me.btnBorrarCargo.Name = "btnBorrarCargo"
        Me.btnBorrarCargo.RightToLeftAutoMirrorImage = True
        Me.btnBorrarCargo.Size = New System.Drawing.Size(24, 24)
        Me.btnBorrarCargo.Text = "Eliminar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton4.Text = "Mover primero"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton5.Text = "Mover anterior"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(38, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton6.Text = "Mover siguiente"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton7.Text = "Mover último"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'AgregarCargo
        '
        Me.AgregarCargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AgregarCargo.Image = CType(resources.GetObject("AgregarCargo.Image"), System.Drawing.Image)
        Me.AgregarCargo.Name = "AgregarCargo"
        Me.AgregarCargo.RightToLeftAutoMirrorImage = True
        Me.AgregarCargo.Size = New System.Drawing.Size(24, 24)
        Me.AgregarCargo.Text = "Agregar nuevo"
        '
        'CargosDataGridView
        '
        Me.CargosDataGridView.AllowUserToAddRows = False
        Me.CargosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CargosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.CargosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.CargosDataGridView.DataSource = Me.FKCargosAsientosBindingSource
        Me.CargosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CargosDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CargosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CargosDataGridView.Name = "CargosDataGridView"
        Me.CargosDataGridView.RowHeadersVisible = False
        Me.CargosDataGridView.RowTemplate.Height = 24
        Me.CargosDataGridView.Size = New System.Drawing.Size(650, 154)
        Me.CargosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NúmeroAsiento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NúmeroAsiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NúmeroApunte"
        Me.DataGridViewTextBoxColumn9.HeaderText = "#Apunte"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 57
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CódigoCuenta"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.CuentasBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cuenta Cargo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "Codigo"
        Me.DataGridViewTextBoxColumn8.Width = 377
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.BDContabilidadMelo
        Me.CuentasBindingSource.Sort = "Nombre"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Importe"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0,00"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'FKCargosAsientosBindingSource
        '
        Me.FKCargosAsientosBindingSource.DataMember = "FK_Cargos_Asientos"
        Me.FKCargosAsientosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'AbonosPanel
        '
        Me.AbonosPanel.Controls.Add(Me.AbonosBindingNavigator)
        Me.AbonosPanel.Controls.Add(Me.AbonosDataGridView)
        Me.AbonosPanel.Location = New System.Drawing.Point(654, 450)
        Me.AbonosPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AbonosPanel.Name = "AbonosPanel"
        Me.AbonosPanel.Size = New System.Drawing.Size(650, 179)
        Me.AbonosPanel.TabIndex = 2
        '
        'AbonosBindingNavigator
        '
        Me.AbonosBindingNavigator.AddNewItem = Nothing
        Me.AbonosBindingNavigator.BindingSource = Me.AbonosBindingSource
        Me.AbonosBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.AbonosBindingNavigator.DeleteItem = Me.btnBorrarAbono
        Me.AbonosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AbonosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator6, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripSeparator7, Me.AgregarAbono, Me.btnBorrarAbono})
        Me.AbonosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AbonosBindingNavigator.MoveFirstItem = Me.ToolStripButton10
        Me.AbonosBindingNavigator.MoveLastItem = Me.ToolStripButton13
        Me.AbonosBindingNavigator.MoveNextItem = Me.ToolStripButton12
        Me.AbonosBindingNavigator.MovePreviousItem = Me.ToolStripButton11
        Me.AbonosBindingNavigator.Name = "AbonosBindingNavigator"
        Me.AbonosBindingNavigator.PositionItem = Me.ToolStripTextBox2
        Me.AbonosBindingNavigator.Size = New System.Drawing.Size(650, 27)
        Me.AbonosBindingNavigator.TabIndex = 4
        Me.AbonosBindingNavigator.Text = "BindingNavigator1"
        '
        'AbonosBindingSource
        '
        Me.AbonosBindingSource.DataMember = "FK_Abonos_Asientos"
        Me.AbonosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(37, 24)
        Me.ToolStripLabel2.Text = "de {0}"
        Me.ToolStripLabel2.ToolTipText = "Número total de elementos"
        '
        'btnBorrarAbono
        '
        Me.btnBorrarAbono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBorrarAbono.Image = CType(resources.GetObject("btnBorrarAbono.Image"), System.Drawing.Image)
        Me.btnBorrarAbono.Name = "btnBorrarAbono"
        Me.btnBorrarAbono.RightToLeftAutoMirrorImage = True
        Me.btnBorrarAbono.Size = New System.Drawing.Size(24, 24)
        Me.btnBorrarAbono.Text = "Eliminar"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton10.Text = "Mover primero"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton11.Text = "Mover anterior"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Posición"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(38, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton12.Text = "Mover siguiente"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton13.Text = "Mover último"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'AgregarAbono
        '
        Me.AgregarAbono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AgregarAbono.Image = CType(resources.GetObject("AgregarAbono.Image"), System.Drawing.Image)
        Me.AgregarAbono.Name = "AgregarAbono"
        Me.AgregarAbono.RightToLeftAutoMirrorImage = True
        Me.AgregarAbono.Size = New System.Drawing.Size(24, 24)
        Me.AgregarAbono.Text = "Agregar nuevo"
        '
        'AbonosDataGridView
        '
        Me.AbonosDataGridView.AllowUserToAddRows = False
        Me.AbonosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AbonosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.AbonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbonosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14})
        Me.AbonosDataGridView.DataSource = Me.FKAbonosAsientosBindingSource
        Me.AbonosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AbonosDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.AbonosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AbonosDataGridView.Name = "AbonosDataGridView"
        Me.AbonosDataGridView.RowHeadersVisible = False
        Me.AbonosDataGridView.RowTemplate.Height = 24
        Me.AbonosDataGridView.Size = New System.Drawing.Size(650, 154)
        Me.AbonosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NúmeroAsiento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NúmeroAsiento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NúmeroApunte"
        Me.DataGridViewTextBoxColumn13.HeaderText = "#Apunte"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 57
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CódigoCuenta"
        Me.DataGridViewTextBoxColumn12.DataSource = Me.CuentasBindingSource
        Me.DataGridViewTextBoxColumn12.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cuenta Abono"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn12.ValueMember = "Codigo"
        Me.DataGridViewTextBoxColumn12.Width = 477
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Importe"
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0,00"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn14.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FKAbonosAsientosBindingSource
        '
        Me.FKAbonosAsientosBindingSource.DataMember = "FK_Abonos_Asientos"
        Me.FKAbonosAsientosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'OpcionesAsientosContextMenuStrip
        '
        Me.OpcionesAsientosContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OpcionesAsientosContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicarAsientoToolStripMenuItem})
        Me.OpcionesAsientosContextMenuStrip.Name = "OpcionesAsientosContextMenuStrip"
        Me.OpcionesAsientosContextMenuStrip.Size = New System.Drawing.Size(232, 26)
        '
        'DuplicarAsientoToolStripMenuItem
        '
        Me.DuplicarAsientoToolStripMenuItem.Name = "DuplicarAsientoToolStripMenuItem"
        Me.DuplicarAsientoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.DuplicarAsientoToolStripMenuItem.Text = "Duplicar asiento seleccionado"
        '
        'AsientosTableAdapter
        '
        Me.AsientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Me.AbonosTableAdapter
        Me.TableAdapterManager.AsientosTableAdapter = Me.AsientosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Me.CargosTableAdapter
        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.CNO11TableAdapter = Nothing
        Me.TableAdapterManager.CNO94TableAdapter = Nothing
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
        'AbonosTableAdapter
        '
        Me.AbonosTableAdapter.ClearBeforeFill = True
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'CuentasMaestrasTableAdapter
        '
        Me.CuentasMaestrasTableAdapter.ClearBeforeFill = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'FacturasRecibidasBindingSource
        '
        Me.FacturasRecibidasBindingSource.DataMember = "FacturasRecibidas"
        Me.FacturasRecibidasBindingSource.DataSource = Me.BDContabilidadMelo
        '
        'FacturasRecibidasTableAdapter
        '
        Me.FacturasRecibidasTableAdapter.ClearBeforeFill = True
        '
        'FrmDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1341, 849)
        Me.Controls.Add(Me.AsientosPanel)
        Me.Controls.Add(Me.CargosPanel)
        Me.Controls.Add(Me.AbonosPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmDiario"
        Me.Text = "frmDiario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AsientosPanel.ResumeLayout(False)
        Me.AsientosPanel.PerformLayout()
        CType(Me.AsientosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AsientosBindingNavigator.ResumeLayout(False)
        Me.AsientosBindingNavigator.PerformLayout()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadMelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuOPERACIONES.ResumeLayout(False)
        Me.CargosPanel.ResumeLayout(False)
        Me.CargosPanel.PerformLayout()
        CType(Me.CargosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CargosBindingNavigator.ResumeLayout(False)
        Me.CargosBindingNavigator.PerformLayout()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCargosAsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbonosPanel.ResumeLayout(False)
        Me.AbonosPanel.PerformLayout()
        CType(Me.AbonosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbonosBindingNavigator.ResumeLayout(False)
        Me.AbonosBindingNavigator.PerformLayout()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKAbonosAsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpcionesAsientosContextMenuStrip.ResumeLayout(False)
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AsientosPanel As System.Windows.Forms.Panel
    Friend WithEvents DsGrupos As Contabilidad.BDContabilidadGMELO
    Friend WithEvents BDContabilidadMelo As Contabilidad.BDContabilidadGMELO
    Friend WithEvents AsientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsientosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter
    Friend WithEvents TableAdapterManager As Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents AsientosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AsientosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AsientosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CargosPanel As System.Windows.Forms.Panel
    Friend WithEvents AbonosPanel As System.Windows.Forms.Panel
    Friend WithEvents CargosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter
    Friend WithEvents CargosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CargosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents AgregarCargo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBorrarCargo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbonosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbonosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter
    Friend WithEvents AbonosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents AgregarAbono As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBorrarAbono As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AbonosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnRenum As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCierre As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuentasMaestrasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter
    Friend WithEvents ContextMenuOPERACIONES As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Listados As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnListarDiario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsientosDescuadradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsientosDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BuscarNúmeroAsientoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BuscarTextoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BuscarImporteAsientoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AnteriorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SiguienteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AnteriorImporteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SiguienteImporteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpcionesAsientosContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DuplicarAsientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FKAbonosAsientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKCargosAsientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgregarAsiento As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBorrarAsiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CuentasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter
    Friend WithEvents FacturasRecibidasBindingSource As BindingSource
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
