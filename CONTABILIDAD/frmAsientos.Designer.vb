<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsientos
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
        Dim NúmeroLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim JustificanteLabel As System.Windows.Forms.Label
        Dim OperaciónLabel As System.Windows.Forms.Label
        Dim DebeLabel As System.Windows.Forms.Label
        Dim HaberLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.NúmeroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.JustificanteTextBox = New System.Windows.Forms.TextBox()
        Me.OperaciónTextBox = New System.Windows.Forms.TextBox()
        Me.DebeTextBox = New System.Windows.Forms.TextBox()
        Me.HaberTextBox = New System.Windows.Forms.TextBox()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasGastoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter()
        Me.CuentasGastoComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter()
        Me.CuentasProveedoresComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter()
        Me.IVAGroupBox = New System.Windows.Forms.GroupBox()
        Me.rbIVASuperReducido = New System.Windows.Forms.RadioButton()
        Me.rbIVAReducido = New System.Windows.Forms.RadioButton()
        Me.rbIVANormal = New System.Windows.Forms.RadioButton()
        Me.rbIVANo = New System.Windows.Forms.RadioButton()
        Me.BancosGroupBox = New System.Windows.Forms.GroupBox()
        Me.BancosComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbPagoBanco = New System.Windows.Forms.RadioButton()
        Me.rbPagoCaja = New System.Windows.Forms.RadioButton()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.TipoAsientoGroupBox = New System.Windows.Forms.GroupBox()
        Me.rbVentasRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbComprasRadioButton = New System.Windows.Forms.RadioButton()
        Me.FrmAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        NúmeroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        JustificanteLabel = New System.Windows.Forms.Label()
        OperaciónLabel = New System.Windows.Forms.Label()
        DebeLabel = New System.Windows.Forms.Label()
        HaberLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IVAGroupBox.SuspendLayout()
        Me.BancosGroupBox.SuspendLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoAsientoGroupBox.SuspendLayout()
        CType(Me.FrmAsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NúmeroLabel
        '
        NúmeroLabel.AutoSize = True
        NúmeroLabel.Location = New System.Drawing.Point(589, 68)
        NúmeroLabel.Name = "NúmeroLabel"
        NúmeroLabel.Size = New System.Drawing.Size(62, 17)
        NúmeroLabel.TabIndex = 2
        NúmeroLabel.Text = "Número:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(827, 68)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'JustificanteLabel
        '
        JustificanteLabel.AutoSize = True
        JustificanteLabel.Location = New System.Drawing.Point(804, 169)
        JustificanteLabel.Name = "JustificanteLabel"
        JustificanteLabel.Size = New System.Drawing.Size(83, 17)
        JustificanteLabel.TabIndex = 6
        JustificanteLabel.Text = "Justificante:"
        '
        'OperaciónLabel
        '
        OperaciónLabel.AutoSize = True
        OperaciónLabel.Location = New System.Drawing.Point(26, 169)
        OperaciónLabel.Name = "OperaciónLabel"
        OperaciónLabel.Size = New System.Drawing.Size(78, 17)
        OperaciónLabel.TabIndex = 8
        OperaciónLabel.Text = "Operación:"
        '
        'DebeLabel
        '
        DebeLabel.AutoSize = True
        DebeLabel.Location = New System.Drawing.Point(24, 429)
        DebeLabel.Name = "DebeLabel"
        DebeLabel.Size = New System.Drawing.Size(46, 17)
        DebeLabel.TabIndex = 10
        DebeLabel.Text = "Debe:"
        '
        'HaberLabel
        '
        HaberLabel.AutoSize = True
        HaberLabel.Location = New System.Drawing.Point(329, 429)
        HaberLabel.Name = "HaberLabel"
        HaberLabel.Size = New System.Drawing.Size(51, 17)
        HaberLabel.TabIndex = 12
        HaberLabel.Text = "Haber:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(26, 124)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 17)
        Label1.TabIndex = 15
        Label1.Text = "Proveedor:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(594, 124)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 17)
        Label2.TabIndex = 16
        Label2.Text = "Gasto:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(903, 433)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'NúmeroTextBox
        '
        Me.NúmeroTextBox.Enabled = False
        Me.NúmeroTextBox.Location = New System.Drawing.Point(678, 63)
        Me.NúmeroTextBox.Name = "NúmeroTextBox"
        Me.NúmeroTextBox.Size = New System.Drawing.Size(118, 22)
        Me.NúmeroTextBox.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsientosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(889, 63)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JustificanteTextBox
        '
        Me.JustificanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Justificante", True))
        Me.JustificanteTextBox.Location = New System.Drawing.Point(893, 164)
        Me.JustificanteTextBox.Name = "JustificanteTextBox"
        Me.JustificanteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.JustificanteTextBox.TabIndex = 7
        '
        'OperaciónTextBox
        '
        Me.OperaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Operación", True))
        Me.OperaciónTextBox.Location = New System.Drawing.Point(115, 164)
        Me.OperaciónTextBox.Name = "OperaciónTextBox"
        Me.OperaciónTextBox.Size = New System.Drawing.Size(660, 22)
        Me.OperaciónTextBox.TabIndex = 9
        '
        'DebeTextBox
        '
        Me.DebeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.DebeTextBox.Enabled = False
        Me.DebeTextBox.Location = New System.Drawing.Point(113, 424)
        Me.DebeTextBox.Name = "DebeTextBox"
        Me.DebeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DebeTextBox.TabIndex = 11
        '
        'HaberTextBox
        '
        Me.HaberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Haber", True))
        Me.HaberTextBox.Enabled = False
        Me.HaberTextBox.Location = New System.Drawing.Point(418, 424)
        Me.HaberTextBox.Name = "HaberTextBox"
        Me.HaberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.HaberTextBox.TabIndex = 13
        '
        'AsientosTableAdapter
        '
        Me.AsientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Me.AsientosTableAdapter
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
        'CuentasGastoBindingSource
        '
        Me.CuentasGastoBindingSource.DataMember = "CuentasGasto"
        Me.CuentasGastoBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasGastoBindingSource.Sort = "Nombre"
        '
        'CuentasGastoTableAdapter
        '
        Me.CuentasGastoTableAdapter.ClearBeforeFill = True
        '
        'CuentasGastoComboBox
        '
        Me.CuentasGastoComboBox.DataSource = Me.CuentasGastoBindingSource
        Me.CuentasGastoComboBox.DisplayMember = "Nombre"
        Me.CuentasGastoComboBox.FormattingEnabled = True
        Me.CuentasGastoComboBox.Location = New System.Drawing.Point(682, 117)
        Me.CuentasGastoComboBox.Name = "CuentasGastoComboBox"
        Me.CuentasGastoComboBox.Size = New System.Drawing.Size(411, 24)
        Me.CuentasGastoComboBox.TabIndex = 13
        Me.CuentasGastoComboBox.ValueMember = "Código"
        '
        'CuentasProveedoresBindingSource
        '
        Me.CuentasProveedoresBindingSource.DataMember = "CuentasProveedores"
        Me.CuentasProveedoresBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasProveedoresTableAdapter
        '
        Me.CuentasProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CuentasProveedoresComboBox
        '
        Me.CuentasProveedoresComboBox.DataSource = Me.ProveedoresBindingSource
        Me.CuentasProveedoresComboBox.DisplayMember = "Nombre"
        Me.CuentasProveedoresComboBox.FormattingEnabled = True
        Me.CuentasProveedoresComboBox.Location = New System.Drawing.Point(115, 117)
        Me.CuentasProveedoresComboBox.Name = "CuentasProveedoresComboBox"
        Me.CuentasProveedoresComboBox.Size = New System.Drawing.Size(411, 24)
        Me.CuentasProveedoresComboBox.TabIndex = 14
        Me.CuentasProveedoresComboBox.ValueMember = "Código"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.ProveedoresBindingSource.Sort = "Nombre"
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'IVAGroupBox
        '
        Me.IVAGroupBox.Controls.Add(Me.rbIVASuperReducido)
        Me.IVAGroupBox.Controls.Add(Me.rbIVAReducido)
        Me.IVAGroupBox.Controls.Add(Me.rbIVANormal)
        Me.IVAGroupBox.Controls.Add(Me.rbIVANo)
        Me.IVAGroupBox.Location = New System.Drawing.Point(26, 211)
        Me.IVAGroupBox.Name = "IVAGroupBox"
        Me.IVAGroupBox.Size = New System.Drawing.Size(468, 61)
        Me.IVAGroupBox.TabIndex = 17
        Me.IVAGroupBox.TabStop = False
        Me.IVAGroupBox.Text = "IVA"
        '
        'rbIVASuperReducido
        '
        Me.rbIVASuperReducido.AutoSize = True
        Me.rbIVASuperReducido.Location = New System.Drawing.Point(373, 22)
        Me.rbIVASuperReducido.Name = "rbIVASuperReducido"
        Me.rbIVASuperReducido.Size = New System.Drawing.Size(49, 21)
        Me.rbIVASuperReducido.TabIndex = 3
        Me.rbIVASuperReducido.Text = "4%"
        Me.rbIVASuperReducido.UseVisualStyleBackColor = True
        '
        'rbIVAReducido
        '
        Me.rbIVAReducido.AutoSize = True
        Me.rbIVAReducido.Location = New System.Drawing.Point(260, 22)
        Me.rbIVAReducido.Name = "rbIVAReducido"
        Me.rbIVAReducido.Size = New System.Drawing.Size(57, 21)
        Me.rbIVAReducido.TabIndex = 2
        Me.rbIVAReducido.Text = "10%"
        Me.rbIVAReducido.UseVisualStyleBackColor = True
        '
        'rbIVANormal
        '
        Me.rbIVANormal.AutoSize = True
        Me.rbIVANormal.Checked = True
        Me.rbIVANormal.Location = New System.Drawing.Point(147, 22)
        Me.rbIVANormal.Name = "rbIVANormal"
        Me.rbIVANormal.Size = New System.Drawing.Size(57, 21)
        Me.rbIVANormal.TabIndex = 1
        Me.rbIVANormal.TabStop = True
        Me.rbIVANormal.Text = "21%"
        Me.rbIVANormal.UseVisualStyleBackColor = True
        '
        'rbIVANo
        '
        Me.rbIVANo.AutoSize = True
        Me.rbIVANo.Location = New System.Drawing.Point(41, 22)
        Me.rbIVANo.Name = "rbIVANo"
        Me.rbIVANo.Size = New System.Drawing.Size(50, 21)
        Me.rbIVANo.TabIndex = 0
        Me.rbIVANo.Text = "NO"
        Me.rbIVANo.UseVisualStyleBackColor = True
        '
        'BancosGroupBox
        '
        Me.BancosGroupBox.Controls.Add(Me.BancosComboBox)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoBanco)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoCaja)
        Me.BancosGroupBox.Location = New System.Drawing.Point(504, 211)
        Me.BancosGroupBox.Name = "BancosGroupBox"
        Me.BancosGroupBox.Size = New System.Drawing.Size(468, 73)
        Me.BancosGroupBox.TabIndex = 18
        Me.BancosGroupBox.TabStop = False
        Me.BancosGroupBox.Text = "Datos Pago"
        '
        'BancosComboBox
        '
        Me.BancosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "id", True))
        Me.BancosComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.BancosComboBox.DisplayMember = "Banco"
        Me.BancosComboBox.FormattingEnabled = True
        Me.BancosComboBox.Location = New System.Drawing.Point(214, 19)
        Me.BancosComboBox.Name = "BancosComboBox"
        Me.BancosComboBox.Size = New System.Drawing.Size(200, 24)
        Me.BancosComboBox.TabIndex = 3
        Me.BancosComboBox.ValueMember = "id"
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasBancariasBindingSource.Filter = "id<3"
        '
        'rbPagoBanco
        '
        Me.rbPagoBanco.AutoSize = True
        Me.rbPagoBanco.Checked = True
        Me.rbPagoBanco.Location = New System.Drawing.Point(139, 22)
        Me.rbPagoBanco.Name = "rbPagoBanco"
        Me.rbPagoBanco.Size = New System.Drawing.Size(69, 21)
        Me.rbPagoBanco.TabIndex = 1
        Me.rbPagoBanco.TabStop = True
        Me.rbPagoBanco.Text = "Banco"
        Me.rbPagoBanco.UseVisualStyleBackColor = True
        '
        'rbPagoCaja
        '
        Me.rbPagoCaja.AutoSize = True
        Me.rbPagoCaja.Location = New System.Drawing.Point(35, 22)
        Me.rbPagoCaja.Name = "rbPagoCaja"
        Me.rbPagoCaja.Size = New System.Drawing.Size(57, 21)
        Me.rbPagoCaja.TabIndex = 0
        Me.rbPagoCaja.Text = "Caja"
        Me.rbPagoCaja.UseVisualStyleBackColor = True
        '
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'TipoAsientoGroupBox
        '
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbVentasRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbComprasRadioButton)
        Me.TipoAsientoGroupBox.Location = New System.Drawing.Point(26, 45)
        Me.TipoAsientoGroupBox.Name = "TipoAsientoGroupBox"
        Me.TipoAsientoGroupBox.Size = New System.Drawing.Size(531, 53)
        Me.TipoAsientoGroupBox.TabIndex = 19
        Me.TipoAsientoGroupBox.TabStop = False
        Me.TipoAsientoGroupBox.Text = "Tipo de Asiento"
        '
        'rbVentasRadioButton
        '
        Me.rbVentasRadioButton.AutoSize = True
        Me.rbVentasRadioButton.Location = New System.Drawing.Point(179, 26)
        Me.rbVentasRadioButton.Name = "rbVentasRadioButton"
        Me.rbVentasRadioButton.Size = New System.Drawing.Size(73, 21)
        Me.rbVentasRadioButton.TabIndex = 1
        Me.rbVentasRadioButton.Text = "Ventas"
        Me.rbVentasRadioButton.UseVisualStyleBackColor = True
        '
        'rbComprasRadioButton
        '
        Me.rbComprasRadioButton.AutoSize = True
        Me.rbComprasRadioButton.Checked = True
        Me.rbComprasRadioButton.Location = New System.Drawing.Point(41, 26)
        Me.rbComprasRadioButton.Name = "rbComprasRadioButton"
        Me.rbComprasRadioButton.Size = New System.Drawing.Size(85, 21)
        Me.rbComprasRadioButton.TabIndex = 0
        Me.rbComprasRadioButton.TabStop = True
        Me.rbComprasRadioButton.Text = "Compras"
        Me.rbComprasRadioButton.UseVisualStyleBackColor = True
        '
        'FrmAsientosBindingSource
        '
        Me.FrmAsientosBindingSource.DataSource = GetType(Contabilidad.frmAsientos)
        '
        'frmAsientos
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1118, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.TipoAsientoGroupBox)
        Me.Controls.Add(Me.BancosGroupBox)
        Me.Controls.Add(Me.IVAGroupBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CuentasProveedoresComboBox)
        Me.Controls.Add(Me.CuentasGastoComboBox)
        Me.Controls.Add(NúmeroLabel)
        Me.Controls.Add(Me.NúmeroTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(JustificanteLabel)
        Me.Controls.Add(Me.JustificanteTextBox)
        Me.Controls.Add(OperaciónLabel)
        Me.Controls.Add(Me.OperaciónTextBox)
        Me.Controls.Add(DebeLabel)
        Me.Controls.Add(Me.DebeTextBox)
        Me.Controls.Add(HaberLabel)
        Me.Controls.Add(Me.HaberTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsientos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAsientos"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IVAGroupBox.ResumeLayout(False)
        Me.IVAGroupBox.PerformLayout()
        Me.BancosGroupBox.ResumeLayout(False)
        Me.BancosGroupBox.PerformLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoAsientoGroupBox.ResumeLayout(False)
        Me.TipoAsientoGroupBox.PerformLayout()
        CType(Me.FrmAsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents AsientosBindingSource As BindingSource
    Friend WithEvents AsientosTableAdapter As BDContabilidadGMELOTableAdapters.AsientosTableAdapter
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents NúmeroTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents JustificanteTextBox As TextBox
    Friend WithEvents OperaciónTextBox As TextBox
    Friend WithEvents DebeTextBox As TextBox
    Friend WithEvents HaberTextBox As TextBox
    Friend WithEvents FrmAsientosBindingSource As BindingSource
    Friend WithEvents CuentasGastoBindingSource As BindingSource
    Friend WithEvents CuentasGastoTableAdapter As BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter
    Friend WithEvents CuentasGastoComboBox As ComboBox
    Friend WithEvents CuentasProveedoresBindingSource As BindingSource
    Friend WithEvents CuentasProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter
    Friend WithEvents CuentasProveedoresComboBox As ComboBox
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter
    Friend WithEvents IVAGroupBox As GroupBox
    Friend WithEvents rbIVASuperReducido As RadioButton
    Friend WithEvents rbIVAReducido As RadioButton
    Friend WithEvents rbIVANormal As RadioButton
    Friend WithEvents rbIVANo As RadioButton
    Friend WithEvents BancosGroupBox As GroupBox
    Friend WithEvents rbPagoBanco As RadioButton
    Friend WithEvents rbPagoCaja As RadioButton
    Friend WithEvents CuentasBancariasBindingSource As BindingSource
    Friend WithEvents CuentasBancariasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter
    Friend WithEvents BancosComboBox As ComboBox
    Friend WithEvents TipoAsientoGroupBox As GroupBox
    Friend WithEvents rbVentasRadioButton As RadioButton
    Friend WithEvents rbComprasRadioButton As RadioButton
End Class
