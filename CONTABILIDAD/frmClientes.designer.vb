<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Ape1Label As System.Windows.Forms.Label
        Dim Ape2Label As System.Windows.Forms.Label
        Dim TipoDocumentoIdentidadLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim CódigoPostalLabel As System.Windows.Forms.Label
        Dim NomyApesLabel As System.Windows.Forms.Label
        Dim IdFormaPagoLabel As System.Windows.Forms.Label
        Dim DatosBancariosLabel As System.Windows.Forms.Label
        Dim HorasSemanalesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.ClientesTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ClientesTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnListarClientes1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnListarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListarClientesAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListarClientesBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListarClientesActivosFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListarClientesActivosRecibo = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Ape1TextBox = New System.Windows.Forms.TextBox()
        Me.Ape2TextBox = New System.Windows.Forms.TextBox()
        Me.DocumentoIdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CódigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.BajaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NomyApesTextBox = New System.Windows.Forms.TextBox()
        Me.DatosBancariosTextBox = New System.Windows.Forms.TextBox()
        Me.TiposDocumentoIdentidadComboBox = New System.Windows.Forms.ComboBox()
        Me.TiposDocumentoIdentidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormasPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormasPagoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FormasPagoTableAdapter()
        Me.FormasPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.FacturaCheckBox = New System.Windows.Forms.CheckBox()
        Me.HorasSemanalesTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesComboBox = New System.Windows.Forms.ComboBox()
        Me.DatosClienteGroupBox = New System.Windows.Forms.GroupBox()
        Me.CuentasBancariasComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.TiposDocumentoIdentidadTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.TiposDocumentoIdentidadTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        Ape1Label = New System.Windows.Forms.Label()
        Ape2Label = New System.Windows.Forms.Label()
        TipoDocumentoIdentidadLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CódigoPostalLabel = New System.Windows.Forms.Label()
        NomyApesLabel = New System.Windows.Forms.Label()
        IdFormaPagoLabel = New System.Windows.Forms.Label()
        DatosBancariosLabel = New System.Windows.Forms.Label()
        HorasSemanalesLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosClienteGroupBox.SuspendLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(108, 37)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(55, 17)
        IdLabel.TabIndex = 6
        IdLabel.Text = "Cliente:"
        '
        'Ape1Label
        '
        Ape1Label.AutoSize = True
        Ape1Label.Location = New System.Drawing.Point(5, 108)
        Ape1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ape1Label.Name = "Ape1Label"
        Ape1Label.Size = New System.Drawing.Size(220, 17)
        Ape1Label.TabIndex = 10
        Ape1Label.Text = "Apellido 1 (sólo personas físicas):"
        '
        'Ape2Label
        '
        Ape2Label.AutoSize = True
        Ape2Label.Location = New System.Drawing.Point(9, 143)
        Ape2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ape2Label.Name = "Ape2Label"
        Ape2Label.Size = New System.Drawing.Size(216, 17)
        Ape2Label.TabIndex = 12
        Ape2Label.Text = "Apellido 2 (sólo personas físicas)"
        '
        'TipoDocumentoIdentidadLabel
        '
        TipoDocumentoIdentidadLabel.AutoSize = True
        TipoDocumentoIdentidadLabel.Location = New System.Drawing.Point(75, 177)
        TipoDocumentoIdentidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipoDocumentoIdentidadLabel.Name = "TipoDocumentoIdentidadLabel"
        TipoDocumentoIdentidadLabel.Size = New System.Drawing.Size(146, 17)
        TipoDocumentoIdentidadLabel.TabIndex = 14
        TipoDocumentoIdentidadLabel.Text = "Documento Identidad:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(937, 69)
        DomicilioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(68, 17)
        DomicilioLabel.TabIndex = 18
        DomicilioLabel.Text = "Domicilio:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(937, 101)
        LocalidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(73, 17)
        LocalidadLabel.TabIndex = 20
        LocalidadLabel.Text = "Localidad:"
        '
        'CódigoPostalLabel
        '
        CódigoPostalLabel.AutoSize = True
        CódigoPostalLabel.Location = New System.Drawing.Point(1544, 105)
        CódigoPostalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CódigoPostalLabel.Name = "CódigoPostalLabel"
        CódigoPostalLabel.Size = New System.Drawing.Size(99, 17)
        CódigoPostalLabel.TabIndex = 22
        CódigoPostalLabel.Text = "Código Postal:"
        '
        'NomyApesLabel
        '
        NomyApesLabel.AutoSize = True
        NomyApesLabel.Location = New System.Drawing.Point(75, 74)
        NomyApesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomyApesLabel.Name = "NomyApesLabel"
        NomyApesLabel.Size = New System.Drawing.Size(145, 17)
        NomyApesLabel.TabIndex = 26
        NomyApesLabel.Text = "Nombre/Razón Social"
        '
        'IdFormaPagoLabel
        '
        IdFormaPagoLabel.AutoSize = True
        IdFormaPagoLabel.Location = New System.Drawing.Point(135, 212)
        IdFormaPagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdFormaPagoLabel.Name = "IdFormaPagoLabel"
        IdFormaPagoLabel.Size = New System.Drawing.Size(89, 17)
        IdFormaPagoLabel.TabIndex = 28
        IdFormaPagoLabel.Text = "Forma Pago:"
        '
        'DatosBancariosLabel
        '
        DatosBancariosLabel.AutoSize = True
        DatosBancariosLabel.Location = New System.Drawing.Point(565, 212)
        DatosBancariosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DatosBancariosLabel.Name = "DatosBancariosLabel"
        DatosBancariosLabel.Size = New System.Drawing.Size(43, 17)
        DatosBancariosLabel.TabIndex = 30
        DatosBancariosLabel.Text = "IBAN:"
        '
        'HorasSemanalesLabel
        '
        HorasSemanalesLabel.AutoSize = True
        HorasSemanalesLabel.Location = New System.Drawing.Point(1172, 37)
        HorasSemanalesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HorasSemanalesLabel.Name = "HorasSemanalesLabel"
        HorasSemanalesLabel.Size = New System.Drawing.Size(124, 17)
        HorasSemanalesLabel.TabIndex = 32
        HorasSemanalesLabel.Text = "Horas Semanales:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.ClientesBindingSource.Sort = "NomyApes"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CientesBindingNavigatorSaveItem, Me.btnListarClientes1})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(396, 27)
        Me.ClientesBindingNavigator.TabIndex = 6
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        'CientesBindingNavigatorSaveItem
        '
        Me.CientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CientesBindingNavigatorSaveItem.Name = "CientesBindingNavigatorSaveItem"
        Me.CientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btnListarClientes1
        '
        Me.btnListarClientes1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnListarClientes1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListarClientes, Me.btnListarClientesAlta, Me.btnListarClientesBaja, Me.btnListarClientesActivosFactura, Me.btnListarClientesActivosRecibo})
        Me.btnListarClientes1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnListarClientes1.Name = "btnListarClientes1"
        Me.btnListarClientes1.Size = New System.Drawing.Size(14, 24)
        Me.btnListarClientes1.Text = "Listados"
        Me.btnListarClientes1.ToolTipText = "Listados"
        '
        'btnListarClientes
        '
        Me.btnListarClientes.Name = "btnListarClientes"
        Me.btnListarClientes.Size = New System.Drawing.Size(343, 26)
        Me.btnListarClientes.Text = "Listado TODOS los clientes"
        '
        'btnListarClientesAlta
        '
        Me.btnListarClientesAlta.Name = "btnListarClientesAlta"
        Me.btnListarClientesAlta.Size = New System.Drawing.Size(343, 26)
        Me.btnListarClientesAlta.Text = "Listado clientes ACTIVOS"
        '
        'btnListarClientesBaja
        '
        Me.btnListarClientesBaja.Name = "btnListarClientesBaja"
        Me.btnListarClientesBaja.Size = New System.Drawing.Size(343, 26)
        Me.btnListarClientesBaja.Text = "Listado clientes BAJA"
        '
        'btnListarClientesActivosFactura
        '
        Me.btnListarClientesActivosFactura.Name = "btnListarClientesActivosFactura"
        Me.btnListarClientesActivosFactura.Size = New System.Drawing.Size(343, 26)
        Me.btnListarClientesActivosFactura.Text = "Listado clientes ACTIVOS con FACTURA"
        '
        'btnListarClientesActivosRecibo
        '
        Me.btnListarClientesActivosRecibo.Name = "btnListarClientesActivosRecibo"
        Me.btnListarClientesActivosRecibo.Size = New System.Drawing.Size(343, 26)
        Me.btnListarClientesActivosRecibo.Text = "Listado clientes ACTIVOS con RECIBO"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(172, 33)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(51, 22)
        Me.IdTextBox.TabIndex = 16
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre/RazónSocial", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(236, 70)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(675, 22)
        Me.NombreTextBox.TabIndex = 0
        '
        'Ape1TextBox
        '
        Me.Ape1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ape1", True))
        Me.Ape1TextBox.Location = New System.Drawing.Point(236, 103)
        Me.Ape1TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ape1TextBox.Name = "Ape1TextBox"
        Me.Ape1TextBox.Size = New System.Drawing.Size(675, 22)
        Me.Ape1TextBox.TabIndex = 1
        '
        'Ape2TextBox
        '
        Me.Ape2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ape2", True))
        Me.Ape2TextBox.Location = New System.Drawing.Point(236, 137)
        Me.Ape2TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ape2TextBox.Name = "Ape2TextBox"
        Me.Ape2TextBox.Size = New System.Drawing.Size(675, 22)
        Me.Ape2TextBox.TabIndex = 2
        '
        'DocumentoIdentidadTextBox
        '
        Me.DocumentoIdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DocumentoIdentidad", True))
        Me.DocumentoIdentidadTextBox.Location = New System.Drawing.Point(383, 172)
        Me.DocumentoIdentidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DocumentoIdentidadTextBox.Name = "DocumentoIdentidadTextBox"
        Me.DocumentoIdentidadTextBox.Size = New System.Drawing.Size(152, 22)
        Me.DocumentoIdentidadTextBox.TabIndex = 7
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(1015, 65)
        Me.DomicilioTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(728, 22)
        Me.DomicilioTextBox.TabIndex = 3
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(1015, 101)
        Me.LocalidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(520, 22)
        Me.LocalidadTextBox.TabIndex = 4
        '
        'CódigoPostalTextBox
        '
        Me.CódigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CódigoPostal", True))
        Me.CódigoPostalTextBox.Location = New System.Drawing.Point(1652, 105)
        Me.CódigoPostalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CódigoPostalTextBox.Name = "CódigoPostalTextBox"
        Me.CódigoPostalTextBox.Size = New System.Drawing.Size(91, 22)
        Me.CódigoPostalTextBox.TabIndex = 5
        '
        'BajaCheckBox
        '
        Me.BajaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClientesBindingSource, "Baja", True))
        Me.BajaCheckBox.Location = New System.Drawing.Point(941, 33)
        Me.BajaCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BajaCheckBox.Name = "BajaCheckBox"
        Me.BajaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BajaCheckBox.Size = New System.Drawing.Size(92, 30)
        Me.BajaCheckBox.TabIndex = 8
        Me.BajaCheckBox.Text = ":Baja"
        Me.BajaCheckBox.UseVisualStyleBackColor = True
        '
        'NomyApesTextBox
        '
        Me.NomyApesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NomyApes", True))
        Me.NomyApesTextBox.Location = New System.Drawing.Point(236, 33)
        Me.NomyApesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomyApesTextBox.Name = "NomyApesTextBox"
        Me.NomyApesTextBox.ReadOnly = True
        Me.NomyApesTextBox.Size = New System.Drawing.Size(675, 22)
        Me.NomyApesTextBox.TabIndex = 27
        '
        'DatosBancariosTextBox
        '
        Me.DatosBancariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DatosBancarios", True))
        Me.DatosBancariosTextBox.Location = New System.Drawing.Point(635, 203)
        Me.DatosBancariosTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatosBancariosTextBox.Name = "DatosBancariosTextBox"
        Me.DatosBancariosTextBox.Size = New System.Drawing.Size(397, 22)
        Me.DatosBancariosTextBox.TabIndex = 12
        '
        'TiposDocumentoIdentidadComboBox
        '
        Me.TiposDocumentoIdentidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "TipoDocumentoIdentidad", True))
        Me.TiposDocumentoIdentidadComboBox.DataSource = Me.TiposDocumentoIdentidadBindingSource
        Me.TiposDocumentoIdentidadComboBox.DisplayMember = "Tipo"
        Me.TiposDocumentoIdentidadComboBox.FormattingEnabled = True
        Me.TiposDocumentoIdentidadComboBox.Location = New System.Drawing.Point(236, 170)
        Me.TiposDocumentoIdentidadComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TiposDocumentoIdentidadComboBox.Name = "TiposDocumentoIdentidadComboBox"
        Me.TiposDocumentoIdentidadComboBox.Size = New System.Drawing.Size(137, 24)
        Me.TiposDocumentoIdentidadComboBox.TabIndex = 6
        Me.TiposDocumentoIdentidadComboBox.ValueMember = "id"
        '
        'TiposDocumentoIdentidadBindingSource
        '
        Me.TiposDocumentoIdentidadBindingSource.DataMember = "TiposDocumentoIdentidad"
        Me.TiposDocumentoIdentidadBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'FormasPagoBindingSource
        '
        Me.FormasPagoBindingSource.DataMember = "FormasPago"
        Me.FormasPagoBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'FormasPagoTableAdapter
        '
        Me.FormasPagoTableAdapter.ClearBeforeFill = True
        '
        'FormasPagoComboBox
        '
        Me.FormasPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idFormaPago", True))
        Me.FormasPagoComboBox.DataSource = Me.FormasPagoBindingSource
        Me.FormasPagoComboBox.DisplayMember = "FormaPago"
        Me.FormasPagoComboBox.FormattingEnabled = True
        Me.FormasPagoComboBox.Location = New System.Drawing.Point(236, 204)
        Me.FormasPagoComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FormasPagoComboBox.Name = "FormasPagoComboBox"
        Me.FormasPagoComboBox.Size = New System.Drawing.Size(299, 24)
        Me.FormasPagoComboBox.TabIndex = 11
        Me.FormasPagoComboBox.ValueMember = "id"
        '
        'FacturaCheckBox
        '
        Me.FacturaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClientesBindingSource, "Factura", True))
        Me.FacturaCheckBox.Location = New System.Drawing.Point(1056, 31)
        Me.FacturaCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FacturaCheckBox.Name = "FacturaCheckBox"
        Me.FacturaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FacturaCheckBox.Size = New System.Drawing.Size(97, 30)
        Me.FacturaCheckBox.TabIndex = 9
        Me.FacturaCheckBox.Text = ":Factura"
        Me.FacturaCheckBox.UseVisualStyleBackColor = True
        '
        'HorasSemanalesTextBox
        '
        Me.HorasSemanalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "HorasSemanales", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.HorasSemanalesTextBox.Location = New System.Drawing.Point(1304, 37)
        Me.HorasSemanalesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HorasSemanalesTextBox.Name = "HorasSemanalesTextBox"
        Me.HorasSemanalesTextBox.Size = New System.Drawing.Size(132, 22)
        Me.HorasSemanalesTextBox.TabIndex = 10
        '
        'ClientesComboBox
        '
        Me.ClientesComboBox.DataSource = Me.ClientesBindingSource
        Me.ClientesComboBox.DisplayMember = "NomyApes"
        Me.ClientesComboBox.FormattingEnabled = True
        Me.ClientesComboBox.Location = New System.Drawing.Point(509, 0)
        Me.ClientesComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClientesComboBox.Name = "ClientesComboBox"
        Me.ClientesComboBox.Size = New System.Drawing.Size(1332, 24)
        Me.ClientesComboBox.TabIndex = 34
        Me.ClientesComboBox.ValueMember = "id"
        '
        'DatosClienteGroupBox
        '
        Me.DatosClienteGroupBox.Controls.Add(Me.CuentasBancariasComboBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.NombreTextBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.DatosBancariosTextBox)
        Me.DatosClienteGroupBox.Controls.Add(DatosBancariosLabel)
        Me.DatosClienteGroupBox.Controls.Add(Me.HorasSemanalesTextBox)
        Me.DatosClienteGroupBox.Controls.Add(HorasSemanalesLabel)
        Me.DatosClienteGroupBox.Controls.Add(CódigoPostalLabel)
        Me.DatosClienteGroupBox.Controls.Add(IdFormaPagoLabel)
        Me.DatosClienteGroupBox.Controls.Add(Me.CódigoPostalTextBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.NomyApesTextBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.FacturaCheckBox)
        Me.DatosClienteGroupBox.Controls.Add(NomyApesLabel)
        Me.DatosClienteGroupBox.Controls.Add(Me.FormasPagoComboBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.BajaCheckBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.TiposDocumentoIdentidadComboBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.LocalidadTextBox)
        Me.DatosClienteGroupBox.Controls.Add(IdLabel)
        Me.DatosClienteGroupBox.Controls.Add(LocalidadLabel)
        Me.DatosClienteGroupBox.Controls.Add(Me.IdTextBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.DomicilioTextBox)
        Me.DatosClienteGroupBox.Controls.Add(DomicilioLabel)
        Me.DatosClienteGroupBox.Controls.Add(Ape1Label)
        Me.DatosClienteGroupBox.Controls.Add(Me.DocumentoIdentidadTextBox)
        Me.DatosClienteGroupBox.Controls.Add(Me.Ape1TextBox)
        Me.DatosClienteGroupBox.Controls.Add(TipoDocumentoIdentidadLabel)
        Me.DatosClienteGroupBox.Controls.Add(Ape2Label)
        Me.DatosClienteGroupBox.Controls.Add(Me.Ape2TextBox)
        Me.DatosClienteGroupBox.Location = New System.Drawing.Point(16, 34)
        Me.DatosClienteGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatosClienteGroupBox.Name = "DatosClienteGroupBox"
        Me.DatosClienteGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatosClienteGroupBox.Size = New System.Drawing.Size(1791, 257)
        Me.DatosClienteGroupBox.TabIndex = 35
        Me.DatosClienteGroupBox.TabStop = False
        Me.DatosClienteGroupBox.Text = "Filiación del cliente"
        '
        'CuentasBancariasComboBox
        '
        Me.CuentasBancariasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idCtaBancaria", True))
        Me.CuentasBancariasComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.CuentasBancariasComboBox.DisplayMember = "Banco"
        Me.CuentasBancariasComboBox.FormattingEnabled = True
        Me.CuentasBancariasComboBox.Location = New System.Drawing.Point(1229, 202)
        Me.CuentasBancariasComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CuentasBancariasComboBox.Name = "CuentasBancariasComboBox"
        Me.CuentasBancariasComboBox.Size = New System.Drawing.Size(399, 24)
        Me.CuentasBancariasComboBox.TabIndex = 33
        Me.CuentasBancariasComboBox.ValueMember = "id"
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(95, 373)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(487, 359)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
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
        Me.TableAdapterManager.FormasPagoTableAdapter = Me.FormasPagoTableAdapter
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
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'TiposDocumentoIdentidadTableAdapter
        '
        Me.TiposDocumentoIdentidadTableAdapter.ClearBeforeFill = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1851, 875)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DatosClienteGroupBox)
        Me.Controls.Add(Me.ClientesComboBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmClientes"
        Me.Text = "frmClientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosClienteGroupBox.ResumeLayout(False)
        Me.DatosClienteGroupBox.PerformLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesTableAdapter As BDContabilidadGMELOTableAdapters.ClientesTableAdapter
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ape1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ape2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocumentoIdentidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CódigoPostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BajaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NomyApesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatosBancariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TiposDocumentoIdentidadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FormasPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormasPagoTableAdapter As BDContabilidadGMELOTableAdapters.FormasPagoTableAdapter
    Friend WithEvents FormasPagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnListarClientes1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnListarClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListarClientesAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListarClientesBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListarClientesActivosFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListarClientesActivosRecibo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HorasSemanalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatosClienteGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents CuentasBancariasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentasBancariasTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter
    Friend WithEvents CuentasBancariasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TiposDocumentoIdentidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocumentoIdentidadTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.TiposDocumentoIdentidadTableAdapter
End Class
