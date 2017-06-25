<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPréstamos
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
        Dim SaldoHaberLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPréstamos))
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.PréstamosLargoPlazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PréstamosLargoPlazoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.PréstamosLargoPlazoTableAdapter()
        Me.PréstamosLargoPlazoComboBox = New System.Windows.Forms.ComboBox()
        Me.PréstamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PréstamosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.PréstamosTableAdapter()
        Me.PréstamosDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECIBO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PENDIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.SaldoHaberTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.Cuentas2SaveItem = New System.Windows.Forms.ToolStripButton()
        SaldoHaberLabel = New System.Windows.Forms.Label()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PréstamosLargoPlazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PréstamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PréstamosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaldoHaberLabel
        '
        SaldoHaberLabel.AutoSize = True
        SaldoHaberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SaldoHaberLabel.ForeColor = System.Drawing.Color.Maroon
        SaldoHaberLabel.Location = New System.Drawing.Point(1060, 74)
        SaldoHaberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SaldoHaberLabel.Name = "SaldoHaberLabel"
        SaldoHaberLabel.Size = New System.Drawing.Size(166, 25)
        SaldoHaberLabel.TabIndex = 2
        SaldoHaberLabel.Text = "Saldo A CORTO:"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PréstamosLargoPlazoBindingSource
        '
        Me.PréstamosLargoPlazoBindingSource.DataMember = "PréstamosLargoPlazo"
        Me.PréstamosLargoPlazoBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'PréstamosLargoPlazoTableAdapter
        '
        Me.PréstamosLargoPlazoTableAdapter.ClearBeforeFill = True
        '
        'PréstamosLargoPlazoComboBox
        '
        Me.PréstamosLargoPlazoComboBox.DataSource = Me.PréstamosLargoPlazoBindingSource
        Me.PréstamosLargoPlazoComboBox.DisplayMember = "Nombre"
        Me.PréstamosLargoPlazoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PréstamosLargoPlazoComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PréstamosLargoPlazoComboBox.FormattingEnabled = True
        Me.PréstamosLargoPlazoComboBox.Location = New System.Drawing.Point(24, 74)
        Me.PréstamosLargoPlazoComboBox.Name = "PréstamosLargoPlazoComboBox"
        Me.PréstamosLargoPlazoComboBox.Size = New System.Drawing.Size(1015, 33)
        Me.PréstamosLargoPlazoComboBox.TabIndex = 3
        Me.PréstamosLargoPlazoComboBox.ValueMember = "Código"
        '
        'PréstamosBindingSource
        '
        Me.PréstamosBindingSource.DataMember = "PréstamosLargoPlazo_Préstamos"
        Me.PréstamosBindingSource.DataSource = Me.PréstamosLargoPlazoBindingSource
        '
        'PréstamosTableAdapter
        '
        Me.PréstamosTableAdapter.ClearBeforeFill = True
        '
        'PréstamosDataGridView
        '
        Me.PréstamosDataGridView.AutoGenerateColumns = False
        Me.PréstamosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.PréstamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PréstamosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.RECIBO, Me.PENDIENTE})
        Me.PréstamosDataGridView.DataSource = Me.PréstamosBindingSource
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PréstamosDataGridView.DefaultCellStyle = DataGridViewCellStyle35
        Me.PréstamosDataGridView.Location = New System.Drawing.Point(24, 111)
        Me.PréstamosDataGridView.Name = "PréstamosDataGridView"
        Me.PréstamosDataGridView.RowTemplate.Height = 24
        Me.PréstamosDataGridView.Size = New System.Drawing.Size(1378, 558)
        Me.PréstamosDataGridView.TabIndex = 3
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.PréstamosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cuentas2SaveItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1443, 27)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AÑO"
        DataGridViewCellStyle29.Format = "N0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn1.HeaderText = "AÑO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MES"
        DataGridViewCellStyle30.Format = "N0"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn2.HeaderText = "MES"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRÉSTAMO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRÉSTAMO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CAPITAL_PTE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CAPITAL_PTE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "INTERESES"
        Me.DataGridViewTextBoxColumn5.HeaderText = "INTERESES"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "INTERES"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "n2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn6.HeaderText = "INTERES"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CAPITAL"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn7.HeaderText = "CAPITAL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'RECIBO
        '
        Me.RECIBO.DataPropertyName = "RECIBO"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "n2"
        Me.RECIBO.DefaultCellStyle = DataGridViewCellStyle33
        Me.RECIBO.HeaderText = "RECIBO"
        Me.RECIBO.Name = "RECIBO"
        '
        'PENDIENTE
        '
        Me.PENDIENTE.DataPropertyName = "PENDIENTE"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle34.Format = "n2"
        Me.PENDIENTE.DefaultCellStyle = DataGridViewCellStyle34
        Me.PENDIENTE.HeaderText = "PENDIENTE"
        Me.PENDIENTE.Name = "PENDIENTE"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'SaldoHaberTextBox
        '
        Me.SaldoHaberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "SaldoHaber", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SaldoHaberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoHaberTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaldoHaberTextBox.Location = New System.Drawing.Point(1229, 74)
        Me.SaldoHaberTextBox.Name = "SaldoHaberTextBox"
        Me.SaldoHaberTextBox.Size = New System.Drawing.Size(173, 30)
        Me.SaldoHaberTextBox.TabIndex = 5
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Contabilidad.My.Resources.Resources.HomeHS
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'Cuentas2SaveItem
        '
        Me.Cuentas2SaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cuentas2SaveItem.Image = CType(resources.GetObject("Cuentas2SaveItem.Image"), System.Drawing.Image)
        Me.Cuentas2SaveItem.Name = "Cuentas2SaveItem"
        Me.Cuentas2SaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Cuentas2SaveItem.Text = "Guardar datos"
        '
        'frmPréstamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 698)
        Me.Controls.Add(Me.SaldoHaberTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.PréstamosDataGridView)
        Me.Controls.Add(Me.PréstamosLargoPlazoComboBox)
        Me.Controls.Add(SaldoHaberLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPréstamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPréstamos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PréstamosLargoPlazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PréstamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PréstamosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents PréstamosLargoPlazoBindingSource As BindingSource
    Friend WithEvents PréstamosLargoPlazoTableAdapter As BDContabilidadGMELOTableAdapters.PréstamosLargoPlazoTableAdapter
    Friend WithEvents PréstamosLargoPlazoComboBox As ComboBox
    Friend WithEvents PréstamosBindingSource As BindingSource
    Friend WithEvents PréstamosTableAdapter As BDContabilidadGMELOTableAdapters.PréstamosTableAdapter
    Friend WithEvents PréstamosDataGridView As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents RECIBO As DataGridViewTextBoxColumn
    Friend WithEvents PENDIENTE As DataGridViewTextBoxColumn
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasTableAdapter
    Friend WithEvents SaldoHaberTextBox As TextBox
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents Cuentas2SaveItem As ToolStripButton
End Class
