<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim NOMBRE_RAZÓN_SOCIALLabel As System.Windows.Forms.Label
        Dim APE1Label As System.Windows.Forms.Label
        Dim APE2Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BDEmpresaDataSet = New Admin.BDEmpresaDataSet()
        Me.ClientesTableAdapter = New Admin.BDEmpresaDataSetTableAdapters.ClientesTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.vbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClientesComboBox = New System.Windows.Forms.ComboBox()
        Me.DomicilioSocial = New Controles.ctlDomicilio()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APE1TextBox = New System.Windows.Forms.TextBox()
        Me.APE2TextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_RAZÓN_SOCIALTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DomicilioTableAdapter = New Admin.BDEmpresaDataSetTableAdapters.DomicilioTableAdapter()
        Me.TableAdapterManager = New Admin.BDEmpresaDataSetTableAdapters.TableAdapterManager()
        NOMBRE_RAZÓN_SOCIALLabel = New System.Windows.Forms.Label()
        APE1Label = New System.Windows.Forms.Label()
        APE2Label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BDEmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DomicilioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRE_RAZÓN_SOCIALLabel
        '
        NOMBRE_RAZÓN_SOCIALLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NOMBRE_RAZÓN_SOCIALLabel.AutoSize = True
        NOMBRE_RAZÓN_SOCIALLabel.Location = New System.Drawing.Point(15, 37)
        NOMBRE_RAZÓN_SOCIALLabel.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        NOMBRE_RAZÓN_SOCIALLabel.Name = "NOMBRE_RAZÓN_SOCIALLabel"
        NOMBRE_RAZÓN_SOCIALLabel.Size = New System.Drawing.Size(157, 17)
        NOMBRE_RAZÓN_SOCIALLabel.TabIndex = 9
        NOMBRE_RAZÓN_SOCIALLabel.Text = "Nombre o Razón Social"
        '
        'APE1Label
        '
        APE1Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        APE1Label.AutoSize = True
        APE1Label.Location = New System.Drawing.Point(15, 91)
        APE1Label.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        APE1Label.Name = "APE1Label"
        APE1Label.Size = New System.Drawing.Size(103, 17)
        APE1Label.TabIndex = 10
        APE1Label.Text = "Primer Apellido"
        '
        'APE2Label
        '
        APE2Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        APE2Label.AutoSize = True
        APE2Label.Location = New System.Drawing.Point(388, 91)
        APE2Label.Name = "APE2Label"
        APE2Label.Size = New System.Drawing.Size(119, 17)
        APE2Label.TabIndex = 11
        APE2Label.Text = "Segundo Apellido"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3001, 485)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'BDEmpresaDataSet
        '
        Me.BDEmpresaDataSet.DataSetName = "BDEmpresaDataSet"
        Me.BDEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ClientesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vbSalir, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(385, 27)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDEmpresaDataSet
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'vbSalir
        '
        Me.vbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.vbSalir.Image = CType(resources.GetObject("vbSalir.Image"), System.Drawing.Image)
        Me.vbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.vbSalir.Name = "vbSalir"
        Me.vbSalir.Size = New System.Drawing.Size(23, 24)
        Me.vbSalir.Text = "vbSalir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 595.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1775.0!))
        Me.TableLayoutPanel2.Controls.Add(APE2Label, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ClientesComboBox, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DomicilioSocial, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.BindingNavigator1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1)
        Me.TableLayoutPanel2.Controls.Add(Me.APE1TextBox, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.APE2TextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(NOMBRE_RAZÓN_SOCIALLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NOMBRE_RAZÓN_SOCIALTextBox, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(APE1Label, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1436, 510)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'ClientesComboBox
        '
        Me.ClientesComboBox.DataSource = Me.ClientesBindingSource
        Me.ClientesComboBox.DisplayMember = "NOMBRE/RAZÓN_SOCIAL"
        Me.ClientesComboBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ClientesComboBox.FormattingEnabled = True
        Me.ClientesComboBox.Location = New System.Drawing.Point(983, 2)
        Me.ClientesComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClientesComboBox.Name = "ClientesComboBox"
        Me.ClientesComboBox.Size = New System.Drawing.Size(361, 24)
        Me.ClientesComboBox.TabIndex = 9
        Me.ClientesComboBox.ValueMember = "id"
        '
        'DomicilioSocial
        '
        Me.DomicilioSocial.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.TableLayoutPanel2.SetColumnSpan(Me.DomicilioSocial, 2)
        Me.DomicilioSocial.EstadoDomicilio = Controles.eEstadosDomicilio.Vacío
        Me.DomicilioSocial.IdPropietario = 0
        Me.DomicilioSocial.Location = New System.Drawing.Point(3, 137)
        Me.DomicilioSocial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomicilioSocial.Name = "DomicilioSocial"
        Me.DomicilioSocial.OperaciónActual = Controles.eOperaciónDomicilio.Consultando
        Me.DomicilioSocial.Size = New System.Drawing.Size(974, 196)
        Me.DomicilioSocial.TabIndex = 12
        Me.DomicilioSocial.TipoPropietario = Controles.DomicilioTipoPropietario.Cliente
        Me.DomicilioSocial.TítuloControl = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'APE1TextBox
        '
        Me.APE1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "APE1", True))
        Me.APE1TextBox.Location = New System.Drawing.Point(17, 110)
        Me.APE1TextBox.Margin = New System.Windows.Forms.Padding(17, 2, 3, 2)
        Me.APE1TextBox.Name = "APE1TextBox"
        Me.APE1TextBox.Size = New System.Drawing.Size(364, 22)
        Me.APE1TextBox.TabIndex = 11
        '
        'APE2TextBox
        '
        Me.APE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "APE2", True))
        Me.APE2TextBox.Location = New System.Drawing.Point(388, 110)
        Me.APE2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.APE2TextBox.Name = "APE2TextBox"
        Me.APE2TextBox.Size = New System.Drawing.Size(587, 22)
        Me.APE2TextBox.TabIndex = 12
        '
        'NOMBRE_RAZÓN_SOCIALTextBox
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.NOMBRE_RAZÓN_SOCIALTextBox, 2)
        Me.NOMBRE_RAZÓN_SOCIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NOMBRE/RAZÓN_SOCIAL", True))
        Me.NOMBRE_RAZÓN_SOCIALTextBox.Location = New System.Drawing.Point(17, 56)
        Me.NOMBRE_RAZÓN_SOCIALTextBox.Margin = New System.Windows.Forms.Padding(17, 2, 3, 2)
        Me.NOMBRE_RAZÓN_SOCIALTextBox.Name = "NOMBRE_RAZÓN_SOCIALTextBox"
        Me.NOMBRE_RAZÓN_SOCIALTextBox.Size = New System.Drawing.Size(959, 22)
        Me.NOMBRE_RAZÓN_SOCIALTextBox.TabIndex = 10
        '
        'DomicilioBindingSource
        '
        Me.DomicilioBindingSource.DataMember = "FK_Domicilio_Clientes"
        Me.DomicilioBindingSource.DataSource = Me.ClientesBindingSource
        '
        'DomicilioTableAdapter
        '
        Me.DomicilioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.DomicilioTableAdapter = Me.DomicilioTableAdapter
        Me.TableAdapterManager.UpdateOrder = Admin.BDEmpresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 528)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BDEmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DomicilioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BDEmpresaDataSet As Admin.BDEmpresaDataSet
    Friend WithEvents ClientesTableAdapter As Admin.BDEmpresaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DomicilioTableAdapter As Admin.BDEmpresaDataSetTableAdapters.DomicilioTableAdapter
    Friend WithEvents TableAdapterManager As Admin.BDEmpresaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DomicilioSocial As Controles.ctlDomicilio
    Friend WithEvents APE1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents APE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_RAZÓN_SOCIALTextBox As System.Windows.Forms.TextBox
End Class
