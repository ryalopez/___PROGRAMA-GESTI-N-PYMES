<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaCuenta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.Cta1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cta1TableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.Cta1TableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.Cta1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cta1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cta1ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cta2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cta2TableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.Cta2TableAdapter()
        Me.Cta2ComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasMaestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasMaestrasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter()
        Me.CuentasMaestrasComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cta1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cta1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cta1BindingNavigator.SuspendLayout()
        CType(Me.Cta2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(309, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cta1BindingSource
        '
        Me.Cta1BindingSource.DataMember = "Cta1"
        Me.Cta1BindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'Cta1TableAdapter
        '
        Me.Cta1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Cta1TableAdapter = Me.Cta1TableAdapter
        Me.TableAdapterManager.Cta2TableAdapter = Nothing
        Me.TableAdapterManager.CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasMaestrasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturasEmitidasTableAdapter = Nothing
        Me.TableAdapterManager.FormasPagoTableAdapter = Nothing
        Me.TableAdapterManager.LíneasDiarioTableAdapter = Nothing
        Me.TableAdapterManager.LíneasMayorTableAdapter = Nothing
        Me.TableAdapterManager.NóminasTableAdapter = Nothing
        Me.TableAdapterManager.PerdidasyGananciasSeccionesTableAdapter = Nothing
        Me.TableAdapterManager.PérdidasyGananciasTableAdapter = Nothing
        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cta1BindingNavigator
        '
        Me.Cta1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cta1BindingNavigator.BindingSource = Me.Cta1BindingSource
        Me.Cta1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cta1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cta1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cta1BindingNavigatorSaveItem})
        Me.Cta1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cta1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cta1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cta1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cta1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cta1BindingNavigator.Name = "Cta1BindingNavigator"
        Me.Cta1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cta1BindingNavigator.Size = New System.Drawing.Size(467, 25)
        Me.Cta1BindingNavigator.TabIndex = 1
        Me.Cta1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Cta1BindingNavigatorSaveItem
        '
        Me.Cta1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cta1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Cta1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cta1BindingNavigatorSaveItem.Name = "Cta1BindingNavigatorSaveItem"
        Me.Cta1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Cta1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cta1ComboBox
        '
        Me.Cta1ComboBox.DataSource = Me.Cta1BindingSource
        Me.Cta1ComboBox.DisplayMember = "Nombre"
        Me.Cta1ComboBox.FormattingEnabled = True
        Me.Cta1ComboBox.Location = New System.Drawing.Point(36, 52)
        Me.Cta1ComboBox.Name = "Cta1ComboBox"
        Me.Cta1ComboBox.Size = New System.Drawing.Size(376, 21)
        Me.Cta1ComboBox.TabIndex = 2
        Me.Cta1ComboBox.ValueMember = "Código"
        '
        'Cta2BindingSource
        '
        Me.Cta2BindingSource.DataMember = "FK_Cta2_Cta1"
        Me.Cta2BindingSource.DataSource = Me.Cta1BindingSource
        '
        'Cta2TableAdapter
        '
        Me.Cta2TableAdapter.ClearBeforeFill = True
        '
        'Cta2ComboBox
        '
        Me.Cta2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cta1BindingSource, "Código", True))
        Me.Cta2ComboBox.DataSource = Me.Cta2BindingSource
        Me.Cta2ComboBox.DisplayMember = "Nombre"
        Me.Cta2ComboBox.FormattingEnabled = True
        Me.Cta2ComboBox.Location = New System.Drawing.Point(36, 90)
        Me.Cta2ComboBox.Name = "Cta2ComboBox"
        Me.Cta2ComboBox.Size = New System.Drawing.Size(376, 21)
        Me.Cta2ComboBox.TabIndex = 3
        Me.Cta2ComboBox.ValueMember = "idSubSubGrupo"
        '
        'CuentasMaestrasBindingSource
        '
        Me.CuentasMaestrasBindingSource.DataMember = "Cta2_CuentasMaestras"
        Me.CuentasMaestrasBindingSource.DataSource = Me.Cta2BindingSource
        '
        'CuentasMaestrasTableAdapter
        '
        Me.CuentasMaestrasTableAdapter.ClearBeforeFill = True
        '
        'CuentasMaestrasComboBox
        '
        Me.CuentasMaestrasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cta2BindingSource, "Código", True))
        Me.CuentasMaestrasComboBox.DataSource = Me.CuentasMaestrasBindingSource
        Me.CuentasMaestrasComboBox.DisplayMember = "Nombre"
        Me.CuentasMaestrasComboBox.FormattingEnabled = True
        Me.CuentasMaestrasComboBox.Location = New System.Drawing.Point(36, 125)
        Me.CuentasMaestrasComboBox.Name = "CuentasMaestrasComboBox"
        Me.CuentasMaestrasComboBox.Size = New System.Drawing.Size(376, 21)
        Me.CuentasMaestrasComboBox.TabIndex = 4
        Me.CuentasMaestrasComboBox.ValueMember = "idSubGrupo"
        '
        'frmAltaCuenta
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(467, 347)
        Me.Controls.Add(Me.CuentasMaestrasComboBox)
        Me.Controls.Add(Me.Cta2ComboBox)
        Me.Controls.Add(Me.Cta1ComboBox)
        Me.Controls.Add(Me.Cta1BindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAltaCuenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAltaCuenta"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cta1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cta1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cta1BindingNavigator.ResumeLayout(False)
        Me.Cta1BindingNavigator.PerformLayout()
        CType(Me.Cta2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasMaestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents Cta1BindingSource As BindingSource
    Friend WithEvents Cta1TableAdapter As BDContabilidadGMELOTableAdapters.Cta1TableAdapter
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents Cta1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Cta1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cta1ComboBox As ComboBox
    Friend WithEvents Cta2BindingSource As BindingSource
    Friend WithEvents Cta2TableAdapter As BDContabilidadGMELOTableAdapters.Cta2TableAdapter
    Friend WithEvents Cta2ComboBox As ComboBox
    Friend WithEvents CuentasMaestrasBindingSource As BindingSource
    Friend WithEvents CuentasMaestrasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasMaestrasTableAdapter
    Friend WithEvents CuentasMaestrasComboBox As ComboBox
End Class
