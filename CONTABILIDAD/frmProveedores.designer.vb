﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim DocumentoIdentidadLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TipoDocumentoIdentidadLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim CódigoPostalLabel As System.Windows.Forms.Label
        Dim IdFormaPagoLabel As System.Windows.Forms.Label
        Dim IdCtaBancariaLabel As System.Windows.Forms.Label
        Dim DatosBancariosLabel As System.Windows.Forms.Label
        Dim DebeLabel As System.Windows.Forms.Label
        Dim HaberLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim CuentaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
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
        Me.ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnListarClientes = New System.Windows.Forms.ToolStripButton()
        Me.TiposDocumentoIdentidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocumentoIdentidadTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.TiposDocumentoIdentidadTableAdapter()
        Me.DocumentoIdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CódigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.IdFormaPagoTextBox = New System.Windows.Forms.TextBox()
        Me.IdCtaBancariaTextBox = New System.Windows.Forms.TextBox()
        Me.DatosBancariosTextBox = New System.Windows.Forms.TextBox()
        Me.DebeTextBox = New System.Windows.Forms.TextBox()
        Me.HaberTextBox = New System.Windows.Forms.TextBox()
        Me.TiposDocumentoIdentidadComboBox = New System.Windows.Forms.ComboBox()
        Me.BajaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProveedoresComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter()
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter()
        Me.CuentasGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasGastoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter()
        Me.ContabilidadGroupBox = New System.Windows.Forms.GroupBox()
        Me.Código6ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cuenta6TextBox = New System.Windows.Forms.TextBox()
        Me.Código4ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cuenta4TextBox = New System.Windows.Forms.TextBox()
        DocumentoIdentidadLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TipoDocumentoIdentidadLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CódigoPostalLabel = New System.Windows.Forms.Label()
        IdFormaPagoLabel = New System.Windows.Forms.Label()
        IdCtaBancariaLabel = New System.Windows.Forms.Label()
        DatosBancariosLabel = New System.Windows.Forms.Label()
        DebeLabel = New System.Windows.Forms.Label()
        HaberLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CuentaLabel = New System.Windows.Forms.Label()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContabilidadGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DocumentoIdentidadLabel
        '
        DocumentoIdentidadLabel.AutoSize = True
        DocumentoIdentidadLabel.Location = New System.Drawing.Point(273, 156)
        DocumentoIdentidadLabel.Name = "DocumentoIdentidadLabel"
        DocumentoIdentidadLabel.Size = New System.Drawing.Size(146, 17)
        DocumentoIdentidadLabel.TabIndex = 6
        DocumentoIdentidadLabel.Text = "Documento Identidad:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(41, 117)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 10
        NombreLabel.Text = "Nombre:"
        '
        'TipoDocumentoIdentidadLabel
        '
        TipoDocumentoIdentidadLabel.AutoSize = True
        TipoDocumentoIdentidadLabel.Location = New System.Drawing.Point(41, 154)
        TipoDocumentoIdentidadLabel.Name = "TipoDocumentoIdentidadLabel"
        TipoDocumentoIdentidadLabel.Size = New System.Drawing.Size(116, 17)
        TipoDocumentoIdentidadLabel.TabIndex = 12
        TipoDocumentoIdentidadLabel.Text = "Tipo Documento:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(41, 197)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(68, 17)
        DomicilioLabel.TabIndex = 14
        DomicilioLabel.Text = "Domicilio:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(293, 235)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(73, 17)
        LocalidadLabel.TabIndex = 16
        LocalidadLabel.Text = "Localidad:"
        '
        'CódigoPostalLabel
        '
        CódigoPostalLabel.AutoSize = True
        CódigoPostalLabel.Location = New System.Drawing.Point(41, 238)
        CódigoPostalLabel.Name = "CódigoPostalLabel"
        CódigoPostalLabel.Size = New System.Drawing.Size(99, 17)
        CódigoPostalLabel.TabIndex = 18
        CódigoPostalLabel.Text = "Código Postal:"
        '
        'IdFormaPagoLabel
        '
        IdFormaPagoLabel.AutoSize = True
        IdFormaPagoLabel.Location = New System.Drawing.Point(41, 274)
        IdFormaPagoLabel.Name = "IdFormaPagoLabel"
        IdFormaPagoLabel.Size = New System.Drawing.Size(104, 17)
        IdFormaPagoLabel.TabIndex = 20
        IdFormaPagoLabel.Text = "id Forma Pago:"
        '
        'IdCtaBancariaLabel
        '
        IdCtaBancariaLabel.AutoSize = True
        IdCtaBancariaLabel.Location = New System.Drawing.Point(293, 278)
        IdCtaBancariaLabel.Name = "IdCtaBancariaLabel"
        IdCtaBancariaLabel.Size = New System.Drawing.Size(108, 17)
        IdCtaBancariaLabel.TabIndex = 22
        IdCtaBancariaLabel.Text = "id Cta Bancaria:"
        '
        'DatosBancariosLabel
        '
        DatosBancariosLabel.AutoSize = True
        DatosBancariosLabel.Location = New System.Drawing.Point(525, 281)
        DatosBancariosLabel.Name = "DatosBancariosLabel"
        DatosBancariosLabel.Size = New System.Drawing.Size(116, 17)
        DatosBancariosLabel.TabIndex = 24
        DatosBancariosLabel.Text = "Datos Bancarios:"
        '
        'DebeLabel
        '
        DebeLabel.AutoSize = True
        DebeLabel.Location = New System.Drawing.Point(71, 106)
        DebeLabel.Name = "DebeLabel"
        DebeLabel.Size = New System.Drawing.Size(46, 17)
        DebeLabel.TabIndex = 30
        DebeLabel.Text = "Debe:"
        '
        'HaberLabel
        '
        HaberLabel.AutoSize = True
        HaberLabel.Location = New System.Drawing.Point(67, 134)
        HaberLabel.Name = "HaberLabel"
        HaberLabel.Size = New System.Drawing.Size(51, 17)
        HaberLabel.TabIndex = 32
        HaberLabel.Text = "Haber:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(103, 17)
        Label1.TabIndex = 43
        Label1.Text = "Cuenta Gasto.:"
        '
        'CuentaLabel
        '
        CuentaLabel.AutoSize = True
        CuentaLabel.Location = New System.Drawing.Point(9, 39)
        CuentaLabel.Name = "CuentaLabel"
        CuentaLabel.Size = New System.Drawing.Size(108, 17)
        CuentaLabel.TabIndex = 40
        CuentaLabel.Text = "Cuenta Admva.:"
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedoresBindingNavigatorSaveItem, Me.btnListarClientes})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(1686, 27)
        Me.ProveedoresBindingNavigator.TabIndex = 6
        Me.ProveedoresBindingNavigator.Text = "Proveedores"
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
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.ProveedoresBindingSource.Sort = "NOMBRE"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProveedoresBindingNavigatorSaveItem
        '
        Me.ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedoresBindingNavigatorSaveItem.Name = "ProveedoresBindingNavigatorSaveItem"
        Me.ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btnListarClientes
        '
        Me.btnListarClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnListarClientes.Image = Global.Contabilidad.My.Resources.Resources.Listar
        Me.btnListarClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnListarClientes.Name = "btnListarClientes"
        Me.btnListarClientes.Size = New System.Drawing.Size(24, 24)
        Me.btnListarClientes.Text = "ToolStripButton8"
        Me.btnListarClientes.ToolTipText = "Listado alfabético de clientes"
        '
        'TiposDocumentoIdentidadBindingSource
        '
        Me.TiposDocumentoIdentidadBindingSource.DataMember = "TiposDocumentoIdentidad"
        Me.TiposDocumentoIdentidadBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'TiposDocumentoIdentidadTableAdapter
        '
        Me.TiposDocumentoIdentidadTableAdapter.ClearBeforeFill = True
        '
        'DocumentoIdentidadTextBox
        '
        Me.DocumentoIdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "DocumentoIdentidad", True))
        Me.DocumentoIdentidadTextBox.Location = New System.Drawing.Point(425, 153)
        Me.DocumentoIdentidadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DocumentoIdentidadTextBox.Name = "DocumentoIdentidadTextBox"
        Me.DocumentoIdentidadTextBox.Size = New System.Drawing.Size(123, 22)
        Me.DocumentoIdentidadTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(163, 114)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(572, 22)
        Me.NombreTextBox.TabIndex = 0
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(163, 192)
        Me.DomicilioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(820, 22)
        Me.DomicilioTextBox.TabIndex = 4
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(372, 231)
        Me.LocalidadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(611, 22)
        Me.LocalidadTextBox.TabIndex = 6
        '
        'CódigoPostalTextBox
        '
        Me.CódigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CódigoPostal", True))
        Me.CódigoPostalTextBox.Location = New System.Drawing.Point(163, 231)
        Me.CódigoPostalTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CódigoPostalTextBox.Name = "CódigoPostalTextBox"
        Me.CódigoPostalTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CódigoPostalTextBox.TabIndex = 5
        '
        'IdFormaPagoTextBox
        '
        Me.IdFormaPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "idFormaPago", True))
        Me.IdFormaPagoTextBox.Location = New System.Drawing.Point(163, 272)
        Me.IdFormaPagoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdFormaPagoTextBox.Name = "IdFormaPagoTextBox"
        Me.IdFormaPagoTextBox.Size = New System.Drawing.Size(104, 22)
        Me.IdFormaPagoTextBox.TabIndex = 7
        '
        'IdCtaBancariaTextBox
        '
        Me.IdCtaBancariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "idCtaBancaria", True))
        Me.IdCtaBancariaTextBox.Location = New System.Drawing.Point(407, 274)
        Me.IdCtaBancariaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdCtaBancariaTextBox.Name = "IdCtaBancariaTextBox"
        Me.IdCtaBancariaTextBox.Size = New System.Drawing.Size(104, 22)
        Me.IdCtaBancariaTextBox.TabIndex = 8
        '
        'DatosBancariosTextBox
        '
        Me.DatosBancariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "DatosBancarios", True))
        Me.DatosBancariosTextBox.Location = New System.Drawing.Point(661, 278)
        Me.DatosBancariosTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DatosBancariosTextBox.Name = "DatosBancariosTextBox"
        Me.DatosBancariosTextBox.Size = New System.Drawing.Size(321, 22)
        Me.DatosBancariosTextBox.TabIndex = 9
        '
        'DebeTextBox
        '
        Me.DebeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Debe", True))
        Me.DebeTextBox.Location = New System.Drawing.Point(123, 103)
        Me.DebeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DebeTextBox.Name = "DebeTextBox"
        Me.DebeTextBox.Size = New System.Drawing.Size(104, 22)
        Me.DebeTextBox.TabIndex = 31
        '
        'HaberTextBox
        '
        Me.HaberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Haber", True))
        Me.HaberTextBox.Location = New System.Drawing.Point(123, 130)
        Me.HaberTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HaberTextBox.Name = "HaberTextBox"
        Me.HaberTextBox.Size = New System.Drawing.Size(104, 22)
        Me.HaberTextBox.TabIndex = 33
        '
        'TiposDocumentoIdentidadComboBox
        '
        Me.TiposDocumentoIdentidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedoresBindingSource, "TipoDocumentoIdentidad", True))
        Me.TiposDocumentoIdentidadComboBox.DataSource = Me.TiposDocumentoIdentidadBindingSource
        Me.TiposDocumentoIdentidadComboBox.DisplayMember = "Tipo"
        Me.TiposDocumentoIdentidadComboBox.FormattingEnabled = True
        Me.TiposDocumentoIdentidadComboBox.Location = New System.Drawing.Point(163, 151)
        Me.TiposDocumentoIdentidadComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TiposDocumentoIdentidadComboBox.Name = "TiposDocumentoIdentidadComboBox"
        Me.TiposDocumentoIdentidadComboBox.Size = New System.Drawing.Size(111, 24)
        Me.TiposDocumentoIdentidadComboBox.TabIndex = 2
        Me.TiposDocumentoIdentidadComboBox.ValueMember = "id"
        '
        'BajaCheckBox
        '
        Me.BajaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProveedoresBindingSource, "Baja", True))
        Me.BajaCheckBox.Location = New System.Drawing.Point(759, 112)
        Me.BajaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BajaCheckBox.Name = "BajaCheckBox"
        Me.BajaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BajaCheckBox.Size = New System.Drawing.Size(75, 30)
        Me.BajaCheckBox.TabIndex = 1
        Me.BajaCheckBox.Text = ":Baja"
        Me.BajaCheckBox.UseVisualStyleBackColor = True
        '
        'ProveedoresComboBox
        '
        Me.ProveedoresComboBox.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresComboBox.DisplayMember = "Nombre"
        Me.ProveedoresComboBox.FormattingEnabled = True
        Me.ProveedoresComboBox.Location = New System.Drawing.Point(529, 2)
        Me.ProveedoresComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProveedoresComboBox.Name = "ProveedoresComboBox"
        Me.ProveedoresComboBox.Size = New System.Drawing.Size(907, 24)
        Me.ProveedoresComboBox.TabIndex = 34
        Me.ProveedoresComboBox.ValueMember = "DocumentoIdentidad"
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CuentasTableAdapter = Me.CuentasTableAdapter
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
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.ProvinciasTableAdapter = Nothing
        Me.TableAdapterManager.PuestosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.SexosTableAdapter = Nothing
        Me.TableAdapterManager.TiposComplementoSalarialTableAdapter = Nothing
        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Me.TiposDocumentoIdentidadTableAdapter
        Me.TableAdapterManager.TiposNóminaTableAdapter = Nothing
        Me.TableAdapterManager.TiposVíaTableAdapter = Nothing
        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuentasProveedoresBindingSource
        '
        Me.CuentasProveedoresBindingSource.DataMember = "CuentasProveedores"
        Me.CuentasProveedoresBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasProveedoresBindingSource.Sort = "NOMBRE"
        '
        'CuentasProveedoresTableAdapter
        '
        Me.CuentasProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CuentasGastoBindingSource
        '
        Me.CuentasGastoBindingSource.DataMember = "CuentasGasto"
        Me.CuentasGastoBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasGastoBindingSource.Sort = "NOMBRE"
        '
        'CuentasGastoTableAdapter
        '
        Me.CuentasGastoTableAdapter.ClearBeforeFill = True
        '
        'ContabilidadGroupBox
        '
        Me.ContabilidadGroupBox.Controls.Add(Me.Código6ComboBox)
        Me.ContabilidadGroupBox.Controls.Add(Label1)
        Me.ContabilidadGroupBox.Controls.Add(Me.Cuenta6TextBox)
        Me.ContabilidadGroupBox.Controls.Add(Me.Código4ComboBox)
        Me.ContabilidadGroupBox.Controls.Add(CuentaLabel)
        Me.ContabilidadGroupBox.Controls.Add(Me.Cuenta4TextBox)
        Me.ContabilidadGroupBox.Controls.Add(DebeLabel)
        Me.ContabilidadGroupBox.Controls.Add(Me.HaberTextBox)
        Me.ContabilidadGroupBox.Controls.Add(HaberLabel)
        Me.ContabilidadGroupBox.Controls.Add(Me.DebeTextBox)
        Me.ContabilidadGroupBox.Location = New System.Drawing.Point(1007, 156)
        Me.ContabilidadGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ContabilidadGroupBox.Name = "ContabilidadGroupBox"
        Me.ContabilidadGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ContabilidadGroupBox.Size = New System.Drawing.Size(679, 162)
        Me.ContabilidadGroupBox.TabIndex = 40
        Me.ContabilidadGroupBox.TabStop = False
        Me.ContabilidadGroupBox.Text = "Datos Contabilidad"
        '
        'Código6ComboBox
        '
        Me.Código6ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedoresBindingSource, "Cuenta6", True))
        Me.Código6ComboBox.DataSource = Me.CuentasGastoBindingSource
        Me.Código6ComboBox.DisplayMember = "Nombre"
        Me.Código6ComboBox.FormattingEnabled = True
        Me.Código6ComboBox.Location = New System.Drawing.Point(233, 66)
        Me.Código6ComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Código6ComboBox.Name = "Código6ComboBox"
        Me.Código6ComboBox.Size = New System.Drawing.Size(436, 24)
        Me.Código6ComboBox.TabIndex = 2
        Me.Código6ComboBox.ValueMember = "Código"
        '
        'Cuenta6TextBox
        '
        Me.Cuenta6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Cuenta6", True))
        Me.Cuenta6TextBox.Location = New System.Drawing.Point(123, 66)
        Me.Cuenta6TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cuenta6TextBox.Name = "Cuenta6TextBox"
        Me.Cuenta6TextBox.Size = New System.Drawing.Size(104, 22)
        Me.Cuenta6TextBox.TabIndex = 3
        '
        'Código4ComboBox
        '
        Me.Código4ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedoresBindingSource, "Cuenta4", True))
        Me.Código4ComboBox.DataSource = Me.CuentasProveedoresBindingSource
        Me.Código4ComboBox.DisplayMember = "Nombre"
        Me.Código4ComboBox.FormattingEnabled = True
        Me.Código4ComboBox.Location = New System.Drawing.Point(233, 37)
        Me.Código4ComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Código4ComboBox.Name = "Código4ComboBox"
        Me.Código4ComboBox.Size = New System.Drawing.Size(436, 24)
        Me.Código4ComboBox.TabIndex = 0
        Me.Código4ComboBox.ValueMember = "Código"
        '
        'Cuenta4TextBox
        '
        Me.Cuenta4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Cuenta4", True))
        Me.Cuenta4TextBox.Location = New System.Drawing.Point(123, 36)
        Me.Cuenta4TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cuenta4TextBox.Name = "Cuenta4TextBox"
        Me.Cuenta4TextBox.Size = New System.Drawing.Size(104, 22)
        Me.Cuenta4TextBox.TabIndex = 1
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1656, 768)
        Me.Controls.Add(Me.ContabilidadGroupBox)
        Me.Controls.Add(Me.ProveedoresComboBox)
        Me.Controls.Add(Me.BajaCheckBox)
        Me.Controls.Add(Me.TiposDocumentoIdentidadComboBox)
        Me.Controls.Add(DocumentoIdentidadLabel)
        Me.Controls.Add(Me.DocumentoIdentidadTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(TipoDocumentoIdentidadLabel)
        Me.Controls.Add(DomicilioLabel)
        Me.Controls.Add(Me.DomicilioTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(CódigoPostalLabel)
        Me.Controls.Add(Me.CódigoPostalTextBox)
        Me.Controls.Add(IdFormaPagoLabel)
        Me.Controls.Add(Me.IdFormaPagoTextBox)
        Me.Controls.Add(IdCtaBancariaLabel)
        Me.Controls.Add(Me.IdCtaBancariaTextBox)
        Me.Controls.Add(DatosBancariosLabel)
        Me.Controls.Add(Me.DatosBancariosTextBox)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProveedores"
        Me.Text = "frmProveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContabilidadGroupBox.ResumeLayout(False)
        Me.ContabilidadGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomicilioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProveedoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnListarClientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreRazónSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents DocumentoIdentidadTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents CódigoPostalTextBox As TextBox
    Friend WithEvents IdFormaPagoTextBox As TextBox
    Friend WithEvents IdCtaBancariaTextBox As TextBox
    Friend WithEvents DatosBancariosTextBox As TextBox
    Friend WithEvents DebeTextBox As TextBox
    Friend WithEvents HaberTextBox As TextBox
    Friend WithEvents TiposDocumentoIdentidadComboBox As ComboBox
    Friend WithEvents BajaCheckBox As CheckBox
    Friend WithEvents ProveedoresComboBox As ComboBox
    Friend WithEvents ProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter
    Friend WithEvents CuentasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasTableAdapter
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents CuentasProveedoresBindingSource As BindingSource
    Friend WithEvents CuentasProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter
    Friend WithEvents CuentasGastoBindingSource As BindingSource
    Friend WithEvents CuentasGastoTableAdapter As BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter
    Friend WithEvents ContabilidadGroupBox As GroupBox
    Friend WithEvents Código6ComboBox As ComboBox
    Friend WithEvents Cuenta6TextBox As TextBox
    Friend WithEvents Código4ComboBox As ComboBox
    Friend WithEvents Cuenta4TextBox As TextBox
End Class
