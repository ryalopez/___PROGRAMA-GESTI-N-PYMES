<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNóminas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNóminas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NóminasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturasEmitidasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarNóminas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PagarStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnGenerarResumenExcel = New System.Windows.Forms.ToolStripButton()
        Me.NóminasDataGridView = New System.Windows.Forms.DataGridView()
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NóminasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.CuentasMaestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.NóminasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.NóminasTableAdapter()
        Me.EmpleadosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Bruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIRPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaIRPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSocEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSocialEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCtaBancaria = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ContabilizadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Pagada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bloqueada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.NóminasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NóminasBindingNavigator.SuspendLayout()
        CType(Me.NóminasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NóminasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NóminasBindingNavigator
        '
        Me.NóminasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NóminasBindingNavigator.BindingSource = Me.NóminasBindingSource
        Me.NóminasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NóminasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NóminasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NóminasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturasEmitidasBindingNavigatorSaveItem, Me.ToolStripDropDownButton1, Me.ContabilizarStripButton, Me.PagarStripButton, Me.btnGenerarResumenExcel})
        Me.NóminasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NóminasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NóminasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NóminasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NóminasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NóminasBindingNavigator.Name = "NóminasBindingNavigator"
        Me.NóminasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NóminasBindingNavigator.Size = New System.Drawing.Size(1071, 27)
        Me.NóminasBindingNavigator.TabIndex = 6
        Me.NóminasBindingNavigator.Text = "FacturasEmitidasBindingNavigator"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
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
        '       Me.btnSalir.Image = Global.contabilidad.Resources.Resources.HomeHS
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
        '     Me.ToolStripDropDownButton1.Image = Global.contabilidad.Resources.Resources.Listar
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
        'ContabilizarStripButton
        '
        Me.ContabilizarStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContabilizarStripButton.Image = CType(resources.GetObject("ContabilizarStripButton.Image"), System.Drawing.Image)
        Me.ContabilizarStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContabilizarStripButton.Name = "ContabilizarStripButton"
        Me.ContabilizarStripButton.Size = New System.Drawing.Size(24, 24)
        Me.ContabilizarStripButton.Text = "Contabilizar"
        Me.ContabilizarStripButton.ToolTipText = "Contabilizar nóminas emitidas que no lo están"
        '
        'PagarStripButton
        '
        Me.PagarStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagarStripButton.Image = CType(resources.GetObject("PagarStripButton.Image"), System.Drawing.Image)
        Me.PagarStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PagarStripButton.Name = "PagarStripButton"
        Me.PagarStripButton.Size = New System.Drawing.Size(24, 24)
        Me.PagarStripButton.Text = "Contabilizar el pago de nóminas"
        Me.PagarStripButton.ToolTipText = "Contabilizar el pago de nóminas"
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
        'NóminasDataGridView
        '
        Me.NóminasDataGridView.AllowUserToAddRows = False
        Me.NóminasDataGridView.AllowUserToOrderColumns = True
        Me.NóminasDataGridView.AutoGenerateColumns = False
        Me.NóminasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NóminasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FechaPago, Me.idEmpleado, Me.Bruto, Me.TipoIRPF, Me.CuotaIRPF, Me.SegSocEmpleado, Me.SegSocialEmpresa, Me.Neto, Me.idCtaBancaria, Me.ContabilizadaDataGridViewCheckBoxColumn, Me.Pagada, Me.DataGridViewTextBoxColumn1, Me.Bloqueada})
        Me.NóminasDataGridView.DataSource = Me.NóminasBindingSource
        Me.NóminasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NóminasDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.NóminasDataGridView.Name = "NóminasDataGridView"
        Me.NóminasDataGridView.Size = New System.Drawing.Size(1071, 661)
        Me.NóminasDataGridView.TabIndex = 6
        '
        'CargosBindingSource
        '
        Me.CargosBindingSource.DataMember = "FK_Cargos_Asientos"
        Me.CargosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'AbonosBindingSource
        '
        Me.AbonosBindingSource.DataMember = "FK_Abonos_Asientos"
        Me.AbonosBindingSource.DataSource = Me.AsientosBindingSource
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BDContabilidadGMELO
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
        'NóminasBindingSource
        '
        Me.NóminasBindingSource.DataMember = "Nóminas"
        Me.NóminasBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.NóminasBindingSource.Sort = "FechaNómina"
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
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
        'NóminasTableAdapter
        '
        Me.NóminasTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 33
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaNómina"
        Me.FechaPago.HeaderText = "Fecha Nómina"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Width = 77
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idEmpleado"
        Me.idEmpleado.DataSource = Me.EmpleadosBindingSource
        Me.idEmpleado.DisplayMember = "NomyApe"
        Me.idEmpleado.HeaderText = "Lista Empleados"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.idEmpleado.ValueMember = "idEmpleado"
        Me.idEmpleado.Width = 300
        '
        'Bruto
        '
        Me.Bruto.DataPropertyName = "Bruto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.Bruto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Bruto.HeaderText = "Bruto"
        Me.Bruto.Name = "Bruto"
        Me.Bruto.Width = 77
        '
        'TipoIRPF
        '
        Me.TipoIRPF.DataPropertyName = "TipoIRPF"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.TipoIRPF.DefaultCellStyle = DataGridViewCellStyle2
        Me.TipoIRPF.HeaderText = "Tipo IRPF"
        Me.TipoIRPF.Name = "TipoIRPF"
        Me.TipoIRPF.Width = 77
        '
        'CuotaIRPF
        '
        Me.CuotaIRPF.DataPropertyName = "CuotaIRPF"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.CuotaIRPF.DefaultCellStyle = DataGridViewCellStyle3
        Me.CuotaIRPF.HeaderText = "Cuota IRPF"
        Me.CuotaIRPF.Name = "CuotaIRPF"
        Me.CuotaIRPF.Width = 77
        '
        'SegSocEmpleado
        '
        Me.SegSocEmpleado.DataPropertyName = "SegSocEmpleado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.SegSocEmpleado.DefaultCellStyle = DataGridViewCellStyle4
        Me.SegSocEmpleado.HeaderText = "Seg Soc Empleado"
        Me.SegSocEmpleado.Name = "SegSocEmpleado"
        Me.SegSocEmpleado.Width = 77
        '
        'SegSocialEmpresa
        '
        Me.SegSocialEmpresa.DataPropertyName = "SegSocialEmpresa"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.SegSocialEmpresa.DefaultCellStyle = DataGridViewCellStyle5
        Me.SegSocialEmpresa.HeaderText = "Seg Social Empresa"
        Me.SegSocialEmpresa.Name = "SegSocialEmpresa"
        Me.SegSocialEmpresa.Width = 77
        '
        'Neto
        '
        Me.Neto.DataPropertyName = "Neto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.Neto.DefaultCellStyle = DataGridViewCellStyle6
        Me.Neto.HeaderText = "Neto"
        Me.Neto.Name = "Neto"
        Me.Neto.Width = 77
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
        'ContabilizadaDataGridViewCheckBoxColumn
        '
        Me.ContabilizadaDataGridViewCheckBoxColumn.DataPropertyName = "Contabilizada"
        Me.ContabilizadaDataGridViewCheckBoxColumn.HeaderText = "Contabilizada"
        Me.ContabilizadaDataGridViewCheckBoxColumn.Name = "ContabilizadaDataGridViewCheckBoxColumn"
        Me.ContabilizadaDataGridViewCheckBoxColumn.Width = 77
        '
        'Pagada
        '
        Me.Pagada.DataPropertyName = "Pagada"
        Me.Pagada.HeaderText = "Pagada"
        Me.Pagada.Name = "Pagada"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FechaPago"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Pago"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Bloqueada
        '
        Me.Bloqueada.DataPropertyName = "Bloqueada"
        Me.Bloqueada.HeaderText = "Bloqueada"
        Me.Bloqueada.Name = "Bloqueada"
        '
        'frmNóminas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1071, 688)
        Me.Controls.Add(Me.NóminasDataGridView)
        Me.Controls.Add(Me.NóminasBindingNavigator)
        Me.Name = "frmNóminas"
        Me.Text = "frmFacturasEmitidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NóminasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NóminasBindingNavigator.ResumeLayout(False)
        Me.NóminasBindingNavigator.PerformLayout()
        CType(Me.NóminasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NóminasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents NóminasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BDContabilidadGMELO As Contabilidad.BDContabilidadGMELO
    Friend WithEvents FacturasEmitidasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NóminasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter
    Friend WithEvents ContabilizarStripButton As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents PagarStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Bruto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoIRPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotaIRPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegSocEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegSocialEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Neto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCtaBancaria As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ContabilizadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Pagada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bloqueada As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
