<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TiposDocumentoIdentidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnListarEmpleados = New System.Windows.Forms.ToolStripButton()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.TiposDocumentoIdentidadTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.TiposDocumentoIdentidadTableAdapter()
        Me.EmpleadosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomyApe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Baja = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToOrderColumns = True
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomyApe, Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn, Me.DocumentoIdentidadDataGridViewTextBoxColumn, Me.HorasSemanales, Me.Baja})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(1388, 579)
        Me.EmpleadosDataGridView.TabIndex = 5
        '
        'TiposDocumentoIdentidadBindingSource
        '
        Me.TiposDocumentoIdentidadBindingSource.DataMember = "TiposDocumentoIdentidad"
        Me.TiposDocumentoIdentidadBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem, Me.btnListarEmpleados})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(1388, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 6
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
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
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        '    Me.btnSalir.Image = Global.contabilidad.Resources.Resources.HomeHS
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(23, 22)
        Me.btnSalir.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btnListarEmpleados
        '
        Me.btnListarEmpleados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        '      Me.btnListarEmpleados.Image = Global.contabilidad.Resources.Resources.Listar
        Me.btnListarEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnListarEmpleados.Name = "btnListarEmpleados"
        Me.btnListarEmpleados.Size = New System.Drawing.Size(23, 22)
        Me.btnListarEmpleados.Text = "ToolStripButton8"
        Me.btnListarEmpleados.ToolTipText = "Listado alfabético de clientes"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.Cta1TableAdapter = Nothing
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
        'TiposDocumentoIdentidadTableAdapter
        '
        Me.TiposDocumentoIdentidadTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'NomyApe
        '
        Me.NomyApe.DataPropertyName = "NomyApe"
        Me.NomyApe.HeaderText = "Nombre y Apellidos"
        Me.NomyApe.Name = "NomyApe"
        Me.NomyApe.Width = 300
        '
        'TipoDocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumentoIdentidad"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.DataSource = Me.TiposDocumentoIdentidadBindingSource
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.DisplayMember = "Tipo"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "Tipo Documento Identidad"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.Name = "TipoDocumentoIdentidadDataGridViewTextBoxColumn"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'DocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "DocumentoIdentidad"
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "Documento Identidad"
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.Name = "DocumentoIdentidadDataGridViewTextBoxColumn"
        '
        'HorasSemanales
        '
        Me.HorasSemanales.DataPropertyName = "HorasSemanales"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.HorasSemanales.DefaultCellStyle = DataGridViewCellStyle1
        Me.HorasSemanales.HeaderText = "Horas Semanales"
        Me.HorasSemanales.Name = "HorasSemanales"
        '
        'Baja
        '
        Me.Baja.DataPropertyName = "Baja"
        Me.Baja.HeaderText = "Baja"
        Me.Baja.Name = "Baja"
        Me.Baja.Width = 33
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1071, 607)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Name = "frmEmpleados"
        Me.Text = "frmClientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TiposDocumentoIdentidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocumentoIdentidadTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.TiposDocumentoIdentidadTableAdapter
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnListarEmpleados As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter
    Friend WithEvents NombreRazónSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomyApe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumentoIdentidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DocumentoIdentidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasSemanales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Baja As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
