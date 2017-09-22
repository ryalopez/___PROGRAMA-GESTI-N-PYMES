'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'Partial Class frmCNO11
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
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCNO11))
'        Me.BDINEDataset = New CBiblioteca.BDINEDataSet()
'        Me.CNO11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.CNO11TableAdapter = New CBiblioteca.BDINEDataSetTableAdapters.CNO11TableAdapter()
'        Me.TableAdapterManager = New CBiblioteca.BDINEDataSetTableAdapters.TableAdapterManager()
'        Me.CNO11BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
'        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
'        Me.CNO11BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
'        Me.CNO11DataGridView = New System.Windows.Forms.DataGridView()
'        Me.mnuSalir = New System.Windows.Forms.ToolStripButton()
'        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        CType(Me.BDINEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CNO11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CNO11BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.CNO11BindingNavigator.SuspendLayout()
'        CType(Me.CNO11DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'BDINEDataset
'        '
'        Me.BDINEDataset.DataSetName = "BDINEDataset"
'        Me.BDINEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'CNO11BindingSource
'        '
'        Me.CNO11BindingSource.DataMember = "CNO11"
'        Me.CNO11BindingSource.DataSource = Me.BDINEDataset
'        '
'        'CNO11TableAdapter
'        '
'        Me.CNO11TableAdapter.ClearBeforeFill = True
'        '
'        'TableAdapterManager
'        '
'        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
'        Me.TableAdapterManager.CNO11TableAdapter = Me.CNO11TableAdapter
'        Me.TableAdapterManager.CNO94TableAdapter = Nothing
'        Me.TableAdapterManager.UpdateOrder = CBiblioteca.BDINEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
'        '
'        'CNO11BindingNavigator
'        '
'        Me.CNO11BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
'        Me.CNO11BindingNavigator.BindingSource = Me.CNO11BindingSource
'        Me.CNO11BindingNavigator.CountItem = Me.BindingNavigatorCountItem
'        Me.CNO11BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
'        Me.CNO11BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CNO11BindingNavigatorSaveItem})
'        Me.CNO11BindingNavigator.Location = New System.Drawing.Point(0, 0)
'        Me.CNO11BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
'        Me.CNO11BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
'        Me.CNO11BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
'        Me.CNO11BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
'        Me.CNO11BindingNavigator.Name = "CNO11BindingNavigator"
'        Me.CNO11BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
'        Me.CNO11BindingNavigator.Size = New System.Drawing.Size(1264, 25)
'        Me.CNO11BindingNavigator.TabIndex = 0
'        Me.CNO11BindingNavigator.Text = "BindingNavigator1"
'        '
'        'BindingNavigatorAddNewItem
'        '
'        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
'        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
'        '
'        'BindingNavigatorCountItem
'        '
'        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
'        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
'        Me.BindingNavigatorCountItem.Text = "de {0}"
'        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
'        '
'        'BindingNavigatorDeleteItem
'        '
'        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
'        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
'        '
'        'BindingNavigatorMoveFirstItem
'        '
'        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
'        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
'        '
'        'BindingNavigatorMovePreviousItem
'        '
'        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
'        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
'        '
'        'BindingNavigatorSeparator
'        '
'        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
'        '
'        'BindingNavigatorPositionItem
'        '
'        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
'        Me.BindingNavigatorPositionItem.AutoSize = False
'        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
'        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
'        Me.BindingNavigatorPositionItem.Text = "0"
'        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
'        '
'        'BindingNavigatorSeparator1
'        '
'        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
'        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
'        '
'        'BindingNavigatorMoveNextItem
'        '
'        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
'        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
'        '
'        'BindingNavigatorMoveLastItem
'        '
'        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
'        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
'        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
'        '
'        'BindingNavigatorSeparator2
'        '
'        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
'        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
'        '
'        'CNO11BindingNavigatorSaveItem
'        '
'        Me.CNO11BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.CNO11BindingNavigatorSaveItem.Image = CType(resources.GetObject("CNO11BindingNavigatorSaveItem.Image"), System.Drawing.Image)
'        Me.CNO11BindingNavigatorSaveItem.Name = "CNO11BindingNavigatorSaveItem"
'        Me.CNO11BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
'        Me.CNO11BindingNavigatorSaveItem.Text = "Guardar datos"
'        '
'        'CNO11DataGridView
'        '
'        Me.CNO11DataGridView.AllowUserToAddRows = False
'        Me.CNO11DataGridView.AllowUserToDeleteRows = False
'        Me.CNO11DataGridView.AutoGenerateColumns = False
'        Me.CNO11DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.CNO11DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
'        Me.CNO11DataGridView.DataSource = Me.CNO11BindingSource
'        Me.CNO11DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.CNO11DataGridView.Location = New System.Drawing.Point(0, 25)
'        Me.CNO11DataGridView.Name = "CNO11DataGridView"
'        Me.CNO11DataGridView.ReadOnly = True
'        Me.CNO11DataGridView.Size = New System.Drawing.Size(1264, 635)
'        Me.CNO11DataGridView.TabIndex = 1
'        '
'        'mnuSalir
'        '
'        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
'        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
'        Me.mnuSalir.Name = "mnuSalir"
'        Me.mnuSalir.Size = New System.Drawing.Size(23, 22)
'        '
'        'ToolStripSeparator1
'        '
'        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
'        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
'        '
'        'IdDataGridViewTextBoxColumn
'        '
'        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
'        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
'        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
'        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
'        '
'        'ClaveDataGridViewTextBoxColumn
'        '
'        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "clave"
'        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "clave"
'        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
'        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
'        '
'        'NombreDataGridViewTextBoxColumn
'        '
'        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
'        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
'        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
'        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
'        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
'        '
'        'frmCNO11
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(1264, 660)
'        Me.Controls.Add(Me.CNO11DataGridView)
'        Me.Controls.Add(Me.CNO11BindingNavigator)
'        Me.Name = "frmCNO11"
'        Me.Text = "frmPGC"
'        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'        CType(Me.BDINEDataset, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CNO11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CNO11BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.CNO11BindingNavigator.ResumeLayout(False)
'        Me.CNO11BindingNavigator.PerformLayout()
'        CType(Me.CNO11DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub
'    Friend WithEvents BDINEDataset As CBiblioteca.BDINEDataSet
'    Friend WithEvents CNO11BindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents CNO11TableAdapter As CBiblioteca.BDINEDataSetTableAdapters.CNO11TableAdapter
'    Friend WithEvents TableAdapterManager As CBiblioteca.BDINEDataSetTableAdapters.TableAdapterManager
'    Friend WithEvents CNO11BindingNavigator As System.Windows.Forms.BindingNavigator
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
'    Friend WithEvents CNO11BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents CNO11DataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
'    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents ClaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
'End Class
