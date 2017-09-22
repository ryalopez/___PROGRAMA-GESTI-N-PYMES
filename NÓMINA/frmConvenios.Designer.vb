'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'Partial Class frmConvenios
'    Inherits System.Windows.Forms.Form

'    'Form reemplaza a Dispose para limpiar la lista de componentes.
'    <System.Diagnostics.DebuggerNonUserCode()> _
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Requerido por el Diseñador de Windows Forms
'    Private components As System.ComponentModel.IContainer

'    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
'    'Se puede modificar usando el Diseñador de Windows Forms.  
'    'No lo modifique con el editor de código.
'    <System.Diagnostics.DebuggerStepThrough()> _
'    Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container()
'        Dim CódigoLabel As System.Windows.Forms.Label
'        Dim NombreLabel As System.Windows.Forms.Label
'        Dim FechaVigenciaLabel As System.Windows.Forms.Label
'        Dim FechaPublicaciónLabel As System.Windows.Forms.Label
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvenios))
'        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Me.ConveniosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
'        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
'        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.BDMeloDataSet = New Nómina.BDMeloDataSet()
'        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
'        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
'        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
'        Me.ConveniosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
'        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
'        Me.NombreTextBox = New System.Windows.Forms.TextBox()
'        Me.FechaVigenciaDateTimePicker = New System.Windows.Forms.DateTimePicker()
'        Me.FechaPublicaciónDateTimePicker = New System.Windows.Forms.DateTimePicker()
'        Me.ConvenioGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioGruposDataGridView = New System.Windows.Forms.DataGridView()
'        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
'        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioCategoríasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioCategoríasDataGridView = New System.Windows.Forms.DataGridView()
'        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.ConveniosComboBox = New System.Windows.Forms.ComboBox()
'        Me.ConvenioCategoríasConceptosDataGridView = New System.Windows.Forms.DataGridView()
'        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
'        Me.TiposComplementoSalarialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.ConvenioCategoríasConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConveniosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConveniosTableAdapter()
'        Me.TableAdapterManager = New Nómina.BDMeloDataSetTableAdapters.TableAdapterManager()
'        Me.ConvenioCategoríasTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasTableAdapter()
'        Me.ConvenioGruposTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioGruposTableAdapter()
'        Me.UnidadesTableAdapter = New Nómina.BDMeloDataSetTableAdapters.UnidadesTableAdapter()
'        Me.TiposComplementoSalarialTableAdapter = New Nómina.BDMeloDataSetTableAdapters.TiposComplementoSalarialTableAdapter()
'        Me.ConvenioCategoríasConceptosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasConceptosTableAdapter()
'        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.EmpresasTableAdapter = New Nómina.BDMeloDataSetTableAdapters.EmpresasTableAdapter()
'        Me.CentrosTrabajoTableAdapter = New Nómina.BDMeloDataSetTableAdapters.CentrosTrabajoTableAdapter()
'        Me.CentrosTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.mnuSalir = New System.Windows.Forms.ToolStripButton()
'        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        CódigoLabel = New System.Windows.Forms.Label()
'        NombreLabel = New System.Windows.Forms.Label()
'        FechaVigenciaLabel = New System.Windows.Forms.Label()
'        FechaPublicaciónLabel = New System.Windows.Forms.Label()
'        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.ConveniosBindingNavigator.SuspendLayout()
'        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.BDMeloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioGruposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasConceptosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.TiposComplementoSalarialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'CódigoLabel
'        '
'        CódigoLabel.AutoSize = True
'        CódigoLabel.Location = New System.Drawing.Point(16, 50)
'        CódigoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
'        CódigoLabel.Name = "CódigoLabel"
'        CódigoLabel.Size = New System.Drawing.Size(56, 17)
'        CódigoLabel.TabIndex = 1
'        CódigoLabel.Text = "Código:"
'        '
'        'NombreLabel
'        '
'        NombreLabel.AutoSize = True
'        NombreLabel.Location = New System.Drawing.Point(16, 82)
'        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
'        NombreLabel.Name = "NombreLabel"
'        NombreLabel.Size = New System.Drawing.Size(62, 17)
'        NombreLabel.TabIndex = 3
'        NombreLabel.Text = "Nombre:"
'        '
'        'FechaVigenciaLabel
'        '
'        FechaVigenciaLabel.AutoSize = True
'        FechaVigenciaLabel.Location = New System.Drawing.Point(16, 116)
'        FechaVigenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
'        FechaVigenciaLabel.Name = "FechaVigenciaLabel"
'        FechaVigenciaLabel.Size = New System.Drawing.Size(109, 17)
'        FechaVigenciaLabel.TabIndex = 5
'        FechaVigenciaLabel.Text = "Fecha Vigencia:"
'        '
'        'FechaPublicaciónLabel
'        '
'        FechaPublicaciónLabel.AutoSize = True
'        FechaPublicaciónLabel.Location = New System.Drawing.Point(16, 148)
'        FechaPublicaciónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
'        FechaPublicaciónLabel.Name = "FechaPublicaciónLabel"
'        FechaPublicaciónLabel.Size = New System.Drawing.Size(127, 17)
'        FechaPublicaciónLabel.TabIndex = 7
'        FechaPublicaciónLabel.Text = "Fecha Publicación:"
'        '
'        'ConveniosBindingNavigator
'        '
'        Me.ConveniosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
'        Me.ConveniosBindingNavigator.BindingSource = Me.ConveniosBindingSource
'        Me.ConveniosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
'        Me.ConveniosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
'        Me.ConveniosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
'        Me.ConveniosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
'        Me.ConveniosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConveniosBindingNavigatorSaveItem})
'        Me.ConveniosBindingNavigator.Location = New System.Drawing.Point(0, 0)
'        Me.ConveniosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
'        Me.ConveniosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
'        Me.ConveniosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
'        Me.ConveniosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
'        Me.ConveniosBindingNavigator.Name = "ConveniosBindingNavigator"
'        Me.ConveniosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
'        Me.ConveniosBindingNavigator.Size = New System.Drawing.Size(382, 27)
'        Me.ConveniosBindingNavigator.TabIndex = 0
'        Me.ConveniosBindingNavigator.Text = "BindingNavigator1"
'        '
'        'BindingNavigatorAddNewItem
'        '
'        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
'        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
'        '
'        'ConveniosBindingSource
'        '
'        Me.ConveniosBindingSource.DataMember = "Convenios"
'        Me.ConveniosBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'BDMeloDataSet
'        '
'        Me.BDMeloDataSet.DataSetName = "BDMeloDataSet"
'        Me.BDMeloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'BindingNavigatorCountItem
'        '
'        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
'        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
'        Me.BindingNavigatorCountItem.Text = "de {0}"
'        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
'        '
'        'BindingNavigatorDeleteItem
'        '
'        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
'        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
'        '
'        'BindingNavigatorMoveFirstItem
'        '
'        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
'        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
'        '
'        'BindingNavigatorMovePreviousItem
'        '
'        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
'        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
'        '
'        'BindingNavigatorSeparator
'        '
'        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorPositionItem
'        '
'        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
'        Me.BindingNavigatorPositionItem.AutoSize = False
'        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
'        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
'        Me.BindingNavigatorPositionItem.Text = "0"
'        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
'        '
'        'BindingNavigatorSeparator1
'        '
'        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
'        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorMoveNextItem
'        '
'        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
'        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
'        '
'        'BindingNavigatorMoveLastItem
'        '
'        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
'        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
'        '
'        'BindingNavigatorSeparator2
'        '
'        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
'        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
'        '
'        'ConveniosBindingNavigatorSaveItem
'        '
'        Me.ConveniosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.ConveniosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConveniosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
'        Me.ConveniosBindingNavigatorSaveItem.Name = "ConveniosBindingNavigatorSaveItem"
'        Me.ConveniosBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
'        Me.ConveniosBindingNavigatorSaveItem.Text = "Guardar datos"
'        '
'        'CódigoTextBox
'        '
'        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Código", True))
'        Me.CódigoTextBox.Location = New System.Drawing.Point(155, 47)
'        Me.CódigoTextBox.Margin = New System.Windows.Forms.Padding(4)
'        Me.CódigoTextBox.Name = "CódigoTextBox"
'        Me.CódigoTextBox.Size = New System.Drawing.Size(265, 22)
'        Me.CódigoTextBox.TabIndex = 2
'        '
'        'NombreTextBox
'        '
'        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Nombre", True))
'        Me.NombreTextBox.Location = New System.Drawing.Point(155, 79)
'        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
'        Me.NombreTextBox.Name = "NombreTextBox"
'        Me.NombreTextBox.Size = New System.Drawing.Size(265, 22)
'        Me.NombreTextBox.TabIndex = 4
'        '
'        'FechaVigenciaDateTimePicker
'        '
'        Me.FechaVigenciaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConveniosBindingSource, "FechaVigencia", True))
'        Me.FechaVigenciaDateTimePicker.Location = New System.Drawing.Point(155, 111)
'        Me.FechaVigenciaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
'        Me.FechaVigenciaDateTimePicker.Name = "FechaVigenciaDateTimePicker"
'        Me.FechaVigenciaDateTimePicker.Size = New System.Drawing.Size(265, 22)
'        Me.FechaVigenciaDateTimePicker.TabIndex = 6
'        '
'        'FechaPublicaciónDateTimePicker
'        '
'        Me.FechaPublicaciónDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConveniosBindingSource, "FechaPublicación", True))
'        Me.FechaPublicaciónDateTimePicker.Location = New System.Drawing.Point(155, 143)
'        Me.FechaPublicaciónDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
'        Me.FechaPublicaciónDateTimePicker.Name = "FechaPublicaciónDateTimePicker"
'        Me.FechaPublicaciónDateTimePicker.Size = New System.Drawing.Size(265, 22)
'        Me.FechaPublicaciónDateTimePicker.TabIndex = 8
'        '
'        'ConvenioGruposBindingSource
'        '
'        Me.ConvenioGruposBindingSource.DataMember = "FK_ConvenioGrupos_ConvenioGrupos"
'        Me.ConvenioGruposBindingSource.DataSource = Me.ConveniosBindingSource
'        '
'        'ConvenioGruposDataGridView
'        '
'        Me.ConvenioGruposDataGridView.AutoGenerateColumns = False
'        Me.ConvenioGruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.ConvenioGruposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
'        Me.ConvenioGruposDataGridView.DataSource = Me.ConvenioGruposBindingSource
'        Me.ConvenioGruposDataGridView.Location = New System.Drawing.Point(15, 186)
'        Me.ConvenioGruposDataGridView.Margin = New System.Windows.Forms.Padding(4)
'        Me.ConvenioGruposDataGridView.Name = "ConvenioGruposDataGridView"
'        Me.ConvenioGruposDataGridView.Size = New System.Drawing.Size(1031, 181)
'        Me.ConvenioGruposDataGridView.TabIndex = 9
'        '
'        'DataGridViewTextBoxColumn1
'        '
'        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
'        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
'        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
'        Me.DataGridViewTextBoxColumn1.Visible = False
'        '
'        'DataGridViewTextBoxColumn2
'        '
'        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idConvenio"
'        Me.DataGridViewTextBoxColumn2.HeaderText = "Convenio"
'        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
'        Me.DataGridViewTextBoxColumn2.Visible = False
'        '
'        'DataGridViewTextBoxColumn3
'        '
'        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Grupo"
'        Me.DataGridViewTextBoxColumn3.HeaderText = "Grupo Profesional"
'        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
'        Me.DataGridViewTextBoxColumn3.Width = 500
'        '
'        'DataGridViewTextBoxColumn4
'        '
'        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PeríodoPrueba"
'        Me.DataGridViewTextBoxColumn4.HeaderText = "Período Prueba"
'        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
'        '
'        'DataGridViewTextBoxColumn5
'        '
'        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Unidades"
'        Me.DataGridViewTextBoxColumn5.DataSource = Me.UnidadesBindingSource
'        Me.DataGridViewTextBoxColumn5.DisplayMember = "Unidad"
'        Me.DataGridViewTextBoxColumn5.HeaderText = "Unidades"
'        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
'        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
'        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
'        Me.DataGridViewTextBoxColumn5.ValueMember = "id"
'        '
'        'UnidadesBindingSource
'        '
'        Me.UnidadesBindingSource.DataMember = "Unidades"
'        Me.UnidadesBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'ConvenioCategoríasBindingSource
'        '
'        Me.ConvenioCategoríasBindingSource.DataMember = "FK_ConvenioCategorías_ConvenioGrupos"
'        Me.ConvenioCategoríasBindingSource.DataSource = Me.ConvenioGruposBindingSource
'        '
'        'ConvenioCategoríasDataGridView
'        '
'        Me.ConvenioCategoríasDataGridView.AutoGenerateColumns = False
'        Me.ConvenioCategoríasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.ConvenioCategoríasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
'        Me.ConvenioCategoríasDataGridView.DataSource = Me.ConvenioCategoríasBindingSource
'        Me.ConvenioCategoríasDataGridView.Location = New System.Drawing.Point(15, 390)
'        Me.ConvenioCategoríasDataGridView.Margin = New System.Windows.Forms.Padding(4)
'        Me.ConvenioCategoríasDataGridView.Name = "ConvenioCategoríasDataGridView"
'        Me.ConvenioCategoríasDataGridView.Size = New System.Drawing.Size(359, 174)
'        Me.ConvenioCategoríasDataGridView.TabIndex = 10
'        '
'        'DataGridViewTextBoxColumn6
'        '
'        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id"
'        Me.DataGridViewTextBoxColumn6.HeaderText = "id"
'        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
'        Me.DataGridViewTextBoxColumn6.ReadOnly = True
'        Me.DataGridViewTextBoxColumn6.Visible = False
'        '
'        'DataGridViewTextBoxColumn7
'        '
'        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idGrupo"
'        Me.DataGridViewTextBoxColumn7.HeaderText = "idGrupo"
'        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
'        Me.DataGridViewTextBoxColumn7.Visible = False
'        '
'        'DataGridViewTextBoxColumn8
'        '
'        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Denominación"
'        Me.DataGridViewTextBoxColumn8.HeaderText = "Categoría"
'        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
'        Me.DataGridViewTextBoxColumn8.Width = 200
'        '
'        'ConveniosComboBox
'        '
'        Me.ConveniosComboBox.DataSource = Me.ConveniosBindingSource
'        Me.ConveniosComboBox.DisplayMember = "Nombre"
'        Me.ConveniosComboBox.FormattingEnabled = True
'        Me.ConveniosComboBox.Location = New System.Drawing.Point(377, 0)
'        Me.ConveniosComboBox.Margin = New System.Windows.Forms.Padding(4)
'        Me.ConveniosComboBox.Name = "ConveniosComboBox"
'        Me.ConveniosComboBox.Size = New System.Drawing.Size(836, 24)
'        Me.ConveniosComboBox.TabIndex = 11
'        Me.ConveniosComboBox.ValueMember = "Código"
'        '
'        'ConvenioCategoríasConceptosDataGridView
'        '
'        Me.ConvenioCategoríasConceptosDataGridView.AutoGenerateColumns = False
'        Me.ConvenioCategoríasConceptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.ConvenioCategoríasConceptosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
'        Me.ConvenioCategoríasConceptosDataGridView.DataSource = Me.ConvenioCategoríasConceptosBindingSource
'        Me.ConvenioCategoríasConceptosDataGridView.Location = New System.Drawing.Point(381, 390)
'        Me.ConvenioCategoríasConceptosDataGridView.Margin = New System.Windows.Forms.Padding(4)
'        Me.ConvenioCategoríasConceptosDataGridView.Name = "ConvenioCategoríasConceptosDataGridView"
'        Me.ConvenioCategoríasConceptosDataGridView.Size = New System.Drawing.Size(664, 174)
'        Me.ConvenioCategoríasConceptosDataGridView.TabIndex = 12
'        '
'        'DataGridViewTextBoxColumn9
'        '
'        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id"
'        Me.DataGridViewTextBoxColumn9.HeaderText = "id"
'        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
'        Me.DataGridViewTextBoxColumn9.ReadOnly = True
'        Me.DataGridViewTextBoxColumn9.Visible = False
'        Me.DataGridViewTextBoxColumn9.Width = 133
'        '
'        'DataGridViewTextBoxColumn10
'        '
'        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idCategoría"
'        Me.DataGridViewTextBoxColumn10.HeaderText = "idCategoría"
'        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
'        Me.DataGridViewTextBoxColumn10.Visible = False
'        '
'        'DataGridViewTextBoxColumn11
'        '
'        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Denominación"
'        Me.DataGridViewTextBoxColumn11.HeaderText = "Denominación"
'        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
'        Me.DataGridViewTextBoxColumn11.Width = 250
'        '
'        'DataGridViewTextBoxColumn12
'        '
'        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idTipoConcepto"
'        Me.DataGridViewTextBoxColumn12.DataSource = Me.TiposComplementoSalarialBindingSource
'        Me.DataGridViewTextBoxColumn12.DisplayMember = "denominación"
'        Me.DataGridViewTextBoxColumn12.HeaderText = "Tipo"
'        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
'        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
'        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
'        Me.DataGridViewTextBoxColumn12.ValueMember = "id"
'        Me.DataGridViewTextBoxColumn12.Width = 130
'        '
'        'TiposComplementoSalarialBindingSource
'        '
'        Me.TiposComplementoSalarialBindingSource.DataMember = "TiposComplementoSalarial"
'        Me.TiposComplementoSalarialBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'DataGridViewTextBoxColumn13
'        '
'        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ImporteFijo"
'        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle1.Format = "N2"
'        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle1
'        Me.DataGridViewTextBoxColumn13.HeaderText = "Importe Fijo"
'        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
'        Me.DataGridViewTextBoxColumn13.Width = 50
'        '
'        'ConvenioCategoríasConceptosBindingSource
'        '
'        Me.ConvenioCategoríasConceptosBindingSource.DataMember = "FK_ConvenioCategoríasConceptos_ConvenioCategorías"
'        Me.ConvenioCategoríasConceptosBindingSource.DataSource = Me.ConvenioCategoríasBindingSource
'        '
'        'ConveniosTableAdapter
'        '
'        Me.ConveniosTableAdapter.ClearBeforeFill = True
'        '
'        'TableAdapterManager
'        '
'        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
'        Me.TableAdapterManager.CallesTableAdapter = Nothing
'        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
'        Me.TableAdapterManager.CNAETableAdapter = Nothing
'        Me.TableAdapterManager.CNO11TableAdapter = Nothing
'        Me.TableAdapterManager.CNO94TableAdapter = Nothing
'        Me.TableAdapterManager.ConvenioCategoríasConceptosTableAdapter = Nothing
'        Me.TableAdapterManager.ConvenioCategoríasTableAdapter = Me.ConvenioCategoríasTableAdapter
'        Me.TableAdapterManager.ConvenioGruposTableAdapter = Me.ConvenioGruposTableAdapter
'        Me.TableAdapterManager.ConveniosTableAdapter = Me.ConveniosTableAdapter
'        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
'        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
'        Me.TableAdapterManager.PaisesTableAdapter = Nothing
'        Me.TableAdapterManager.ProvinciasTableAdapter = Nothing
'        Me.TableAdapterManager.SexosTableAdapter = Nothing
'        Me.TableAdapterManager.TiposComplementoSalarialTableAdapter = Nothing
'        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Nothing
'        Me.TableAdapterManager.TiposVíaTableAdapter = Nothing
'        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
'        Me.TableAdapterManager.UpdateOrder = Nómina.BDMeloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
'        '
'        'ConvenioCategoríasTableAdapter
'        '
'        Me.ConvenioCategoríasTableAdapter.ClearBeforeFill = True
'        '
'        'ConvenioGruposTableAdapter
'        '
'        Me.ConvenioGruposTableAdapter.ClearBeforeFill = True
'        '
'        'UnidadesTableAdapter
'        '
'        Me.UnidadesTableAdapter.ClearBeforeFill = True
'        '
'        'TiposComplementoSalarialTableAdapter
'        '
'        Me.TiposComplementoSalarialTableAdapter.ClearBeforeFill = True
'        '
'        'ConvenioCategoríasConceptosTableAdapter
'        '
'        Me.ConvenioCategoríasConceptosTableAdapter.ClearBeforeFill = True
'        '
'        'EmpresasTableAdapter
'        '
'        Me.EmpresasTableAdapter.ClearBeforeFill = True
'        '
'        'CentrosTrabajoTableAdapter
'        '
'        Me.CentrosTrabajoTableAdapter.ClearBeforeFill = True
'        '
'        'CentrosTrabajoBindingSource
'        '
'        Me.CentrosTrabajoBindingSource.DataMember = "CentrosTrabajo"
'        Me.CentrosTrabajoBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'mnuSalir
'        '
'        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
'        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
'        Me.mnuSalir.Name = "mnuSalir"
'        Me.mnuSalir.Size = New System.Drawing.Size(24, 24)
'        Me.mnuSalir.Text = "Salir"
'        '
'        'ToolStripSeparator1
'        '
'        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
'        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
'        '
'        'frmConvenios
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(1321, 718)
'        Me.Controls.Add(Me.ConvenioCategoríasConceptosDataGridView)
'        Me.Controls.Add(Me.ConveniosComboBox)
'        Me.Controls.Add(Me.ConvenioCategoríasDataGridView)
'        Me.Controls.Add(Me.ConvenioGruposDataGridView)
'        Me.Controls.Add(CódigoLabel)
'        Me.Controls.Add(Me.CódigoTextBox)
'        Me.Controls.Add(NombreLabel)
'        Me.Controls.Add(Me.NombreTextBox)
'        Me.Controls.Add(FechaVigenciaLabel)
'        Me.Controls.Add(Me.FechaVigenciaDateTimePicker)
'        Me.Controls.Add(FechaPublicaciónLabel)
'        Me.Controls.Add(Me.FechaPublicaciónDateTimePicker)
'        Me.Controls.Add(Me.ConveniosBindingNavigator)
'        Me.Margin = New System.Windows.Forms.Padding(4)
'        Me.Name = "frmConvenios"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
'        Me.Text = "Convenios, Grupos y Categorías"
'        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ConveniosBindingNavigator.ResumeLayout(False)
'        Me.ConveniosBindingNavigator.PerformLayout()
'        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.BDMeloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioGruposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasConceptosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.TiposComplementoSalarialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub
'    Friend WithEvents BDMeloDataSet As Nómina.BDMeloDataSet
'    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConveniosTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConveniosTableAdapter
'    Friend WithEvents TableAdapterManager As Nómina.BDMeloDataSetTableAdapters.TableAdapterManager
'    Friend WithEvents ConveniosBindingNavigator As System.Windows.Forms.BindingNavigator
'    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
'    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
'    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents ConveniosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents ConvenioGruposTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioGruposTableAdapter
'    Friend WithEvents CódigoTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents FechaVigenciaDateTimePicker As System.Windows.Forms.DateTimePicker
'    Friend WithEvents FechaPublicaciónDateTimePicker As System.Windows.Forms.DateTimePicker
'    Friend WithEvents ConvenioGruposBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioCategoríasTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasTableAdapter
'    Friend WithEvents ConvenioGruposDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents ConvenioCategoríasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioCategoríasDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents UnidadesBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents UnidadesTableAdapter As Nómina.BDMeloDataSetTableAdapters.UnidadesTableAdapter
'    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
'    Friend WithEvents ConveniosComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents TiposComplementoSalarialBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents TiposComplementoSalarialTableAdapter As Nómina.BDMeloDataSetTableAdapters.TiposComplementoSalarialTableAdapter
'    Friend WithEvents ConvenioCategoríasConceptosTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasConceptosTableAdapter
'    Friend WithEvents ConvenioCategoríasConceptosDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents ConvenioCategoríasConceptosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewComboBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents EmpresasTableAdapter As Nómina.BDMeloDataSetTableAdapters.EmpresasTableAdapter
'    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents CentrosTrabajoTableAdapter As Nómina.BDMeloDataSetTableAdapters.CentrosTrabajoTableAdapter
'    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents CentrosTrabajoBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
'    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
'End Class
