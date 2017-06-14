<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsientos
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
        Dim NúmeroLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim JustificanteLabel As System.Windows.Forms.Label
        Dim OperaciónLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim TipoIVALabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim CuotaIVALabel As System.Windows.Forms.Label
        Dim BaseIVALabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.NúmeroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.JustificanteTextBox = New System.Windows.Forms.TextBox()
        Me.OperaciónTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TipoIVATextBox = New System.Windows.Forms.TextBox()
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasGastoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter()
        Me.CuentasGastoComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter()
        Me.ProveedoresComboBox = New System.Windows.Forms.ComboBox()
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
        Me.CuotaIVATextBox = New System.Windows.Forms.TextBox()
        Me.BaseIVATextBox = New System.Windows.Forms.TextBox()
        Me.FrmAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        NúmeroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        JustificanteLabel = New System.Windows.Forms.Label()
        OperaciónLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        TipoIVALabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CuotaIVALabel = New System.Windows.Forms.Label()
        BaseIVALabel = New System.Windows.Forms.Label()
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
        NúmeroLabel.Location = New System.Drawing.Point(442, 55)
        NúmeroLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NúmeroLabel.Name = "NúmeroLabel"
        NúmeroLabel.Size = New System.Drawing.Size(47, 13)
        NúmeroLabel.TabIndex = 1
        NúmeroLabel.Text = "Número:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(620, 55)
        FechaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'JustificanteLabel
        '
        JustificanteLabel.AutoSize = True
        JustificanteLabel.Location = New System.Drawing.Point(603, 137)
        JustificanteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        JustificanteLabel.Name = "JustificanteLabel"
        JustificanteLabel.Size = New System.Drawing.Size(63, 13)
        JustificanteLabel.TabIndex = 11
        JustificanteLabel.Text = "Justificante:"
        '
        'OperaciónLabel
        '
        OperaciónLabel.AutoSize = True
        OperaciónLabel.Location = New System.Drawing.Point(20, 137)
        OperaciónLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        OperaciónLabel.Name = "OperaciónLabel"
        OperaciónLabel.Size = New System.Drawing.Size(59, 13)
        OperaciónLabel.TabIndex = 9
        OperaciónLabel.Text = "Operación:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(127, 306)
        TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 15
        TotalLabel.Text = "Total:"
        '
        'TipoIVALabel
        '
        TipoIVALabel.AutoSize = True
        TipoIVALabel.Location = New System.Drawing.Point(20, 277)
        TipoIVALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TipoIVALabel.Name = "TipoIVALabel"
        TipoIVALabel.Size = New System.Drawing.Size(51, 13)
        TipoIVALabel.TabIndex = 19
        TipoIVALabel.Text = "Tipo IVA:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(20, 101)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 5
        Label1.Text = "Proveedor:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(446, 101)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 7
        Label2.Text = "Gasto:"
        '
        'CuotaIVALabel
        '
        CuotaIVALabel.AutoSize = True
        CuotaIVALabel.Enabled = False
        CuotaIVALabel.Location = New System.Drawing.Point(127, 277)
        CuotaIVALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CuotaIVALabel.Name = "CuotaIVALabel"
        CuotaIVALabel.Size = New System.Drawing.Size(58, 13)
        CuotaIVALabel.TabIndex = 21
        CuotaIVALabel.Text = "Cuota IVA:"
        '
        'BaseIVALabel
        '
        BaseIVALabel.AutoSize = True
        BaseIVALabel.Location = New System.Drawing.Point(127, 244)
        BaseIVALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BaseIVALabel.Name = "BaseIVALabel"
        BaseIVALabel.Size = New System.Drawing.Size(31, 13)
        BaseIVALabel.TabIndex = 17
        BaseIVALabel.Text = "Base"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(648, 304)
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
        'NúmeroTextBox
        '
        Me.NúmeroTextBox.Enabled = False
        Me.NúmeroTextBox.Location = New System.Drawing.Point(508, 51)
        Me.NúmeroTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NúmeroTextBox.Name = "NúmeroTextBox"
        Me.NúmeroTextBox.Size = New System.Drawing.Size(90, 20)
        Me.NúmeroTextBox.TabIndex = 2
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(667, 51)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.FechaDateTimePicker.TabIndex = 4
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
        Me.JustificanteTextBox.Location = New System.Drawing.Point(670, 133)
        Me.JustificanteTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.JustificanteTextBox.Name = "JustificanteTextBox"
        Me.JustificanteTextBox.Size = New System.Drawing.Size(151, 20)
        Me.JustificanteTextBox.TabIndex = 12
        '
        'OperaciónTextBox
        '
        Me.OperaciónTextBox.Location = New System.Drawing.Point(86, 133)
        Me.OperaciónTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OperaciónTextBox.Name = "OperaciónTextBox"
        Me.OperaciónTextBox.Size = New System.Drawing.Size(496, 20)
        Me.OperaciónTextBox.TabIndex = 10
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(188, 303)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(151, 20)
        Me.TotalTextBox.TabIndex = 16
        '
        'TipoIVATextBox
        '
        Me.TipoIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Haber", True))
        Me.TipoIVATextBox.Enabled = False
        Me.TipoIVATextBox.Location = New System.Drawing.Point(86, 270)
        Me.TipoIVATextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TipoIVATextBox.Name = "TipoIVATextBox"
        Me.TipoIVATextBox.Size = New System.Drawing.Size(25, 20)
        Me.TipoIVATextBox.TabIndex = 20
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
        Me.CuentasGastoComboBox.Location = New System.Drawing.Point(512, 95)
        Me.CuentasGastoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CuentasGastoComboBox.Name = "CuentasGastoComboBox"
        Me.CuentasGastoComboBox.Size = New System.Drawing.Size(309, 21)
        Me.CuentasGastoComboBox.TabIndex = 8
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
        'ProveedoresComboBox
        '
        Me.ProveedoresComboBox.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresComboBox.DisplayMember = "Nombre"
        Me.ProveedoresComboBox.FormattingEnabled = True
        Me.ProveedoresComboBox.Location = New System.Drawing.Point(86, 95)
        Me.ProveedoresComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProveedoresComboBox.Name = "ProveedoresComboBox"
        Me.ProveedoresComboBox.Size = New System.Drawing.Size(309, 21)
        Me.ProveedoresComboBox.TabIndex = 6
        Me.ProveedoresComboBox.ValueMember = "DocumentoIdentidad"
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
        Me.IVAGroupBox.Location = New System.Drawing.Point(20, 171)
        Me.IVAGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IVAGroupBox.Name = "IVAGroupBox"
        Me.IVAGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.IVAGroupBox.Size = New System.Drawing.Size(351, 50)
        Me.IVAGroupBox.TabIndex = 13
        Me.IVAGroupBox.TabStop = False
        Me.IVAGroupBox.Text = "IVA"
        '
        'rbIVASuperReducido
        '
        Me.rbIVASuperReducido.AutoSize = True
        Me.rbIVASuperReducido.Location = New System.Drawing.Point(280, 18)
        Me.rbIVASuperReducido.Margin = New System.Windows.Forms.Padding(2)
        Me.rbIVASuperReducido.Name = "rbIVASuperReducido"
        Me.rbIVASuperReducido.Size = New System.Drawing.Size(39, 17)
        Me.rbIVASuperReducido.TabIndex = 3
        Me.rbIVASuperReducido.Text = "4%"
        Me.rbIVASuperReducido.UseVisualStyleBackColor = True
        '
        'rbIVAReducido
        '
        Me.rbIVAReducido.AutoSize = True
        Me.rbIVAReducido.Location = New System.Drawing.Point(195, 18)
        Me.rbIVAReducido.Margin = New System.Windows.Forms.Padding(2)
        Me.rbIVAReducido.Name = "rbIVAReducido"
        Me.rbIVAReducido.Size = New System.Drawing.Size(45, 17)
        Me.rbIVAReducido.TabIndex = 2
        Me.rbIVAReducido.Text = "10%"
        Me.rbIVAReducido.UseVisualStyleBackColor = True
        '
        'rbIVANormal
        '
        Me.rbIVANormal.AutoSize = True
        Me.rbIVANormal.Checked = True
        Me.rbIVANormal.Location = New System.Drawing.Point(110, 18)
        Me.rbIVANormal.Margin = New System.Windows.Forms.Padding(2)
        Me.rbIVANormal.Name = "rbIVANormal"
        Me.rbIVANormal.Size = New System.Drawing.Size(45, 17)
        Me.rbIVANormal.TabIndex = 1
        Me.rbIVANormal.TabStop = True
        Me.rbIVANormal.Text = "21%"
        Me.rbIVANormal.UseVisualStyleBackColor = True
        '
        'rbIVANo
        '
        Me.rbIVANo.AutoSize = True
        Me.rbIVANo.Location = New System.Drawing.Point(31, 18)
        Me.rbIVANo.Margin = New System.Windows.Forms.Padding(2)
        Me.rbIVANo.Name = "rbIVANo"
        Me.rbIVANo.Size = New System.Drawing.Size(41, 17)
        Me.rbIVANo.TabIndex = 0
        Me.rbIVANo.Text = "NO"
        Me.rbIVANo.UseVisualStyleBackColor = True
        '
        'BancosGroupBox
        '
        Me.BancosGroupBox.Controls.Add(Me.BancosComboBox)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoBanco)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoCaja)
        Me.BancosGroupBox.Location = New System.Drawing.Point(378, 171)
        Me.BancosGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BancosGroupBox.Name = "BancosGroupBox"
        Me.BancosGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.BancosGroupBox.Size = New System.Drawing.Size(351, 59)
        Me.BancosGroupBox.TabIndex = 14
        Me.BancosGroupBox.TabStop = False
        Me.BancosGroupBox.Text = "Datos Pago"
        '
        'BancosComboBox
        '
        Me.BancosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "id", True))
        Me.BancosComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.BancosComboBox.DisplayMember = "Banco"
        Me.BancosComboBox.FormattingEnabled = True
        Me.BancosComboBox.Location = New System.Drawing.Point(160, 15)
        Me.BancosComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BancosComboBox.Name = "BancosComboBox"
        Me.BancosComboBox.Size = New System.Drawing.Size(151, 21)
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
        Me.rbPagoBanco.Location = New System.Drawing.Point(104, 18)
        Me.rbPagoBanco.Margin = New System.Windows.Forms.Padding(2)
        Me.rbPagoBanco.Name = "rbPagoBanco"
        Me.rbPagoBanco.Size = New System.Drawing.Size(56, 17)
        Me.rbPagoBanco.TabIndex = 1
        Me.rbPagoBanco.TabStop = True
        Me.rbPagoBanco.Text = "Banco"
        Me.rbPagoBanco.UseVisualStyleBackColor = True
        '
        'rbPagoCaja
        '
        Me.rbPagoCaja.AutoSize = True
        Me.rbPagoCaja.Location = New System.Drawing.Point(26, 18)
        Me.rbPagoCaja.Margin = New System.Windows.Forms.Padding(2)
        Me.rbPagoCaja.Name = "rbPagoCaja"
        Me.rbPagoCaja.Size = New System.Drawing.Size(46, 17)
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
        Me.TipoAsientoGroupBox.Location = New System.Drawing.Point(20, 37)
        Me.TipoAsientoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TipoAsientoGroupBox.Name = "TipoAsientoGroupBox"
        Me.TipoAsientoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.TipoAsientoGroupBox.Size = New System.Drawing.Size(398, 43)
        Me.TipoAsientoGroupBox.TabIndex = 0
        Me.TipoAsientoGroupBox.TabStop = False
        Me.TipoAsientoGroupBox.Text = "Tipo de Asiento"
        '
        'rbVentasRadioButton
        '
        Me.rbVentasRadioButton.AutoSize = True
        Me.rbVentasRadioButton.Location = New System.Drawing.Point(134, 21)
        Me.rbVentasRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.rbVentasRadioButton.Name = "rbVentasRadioButton"
        Me.rbVentasRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.rbVentasRadioButton.TabIndex = 1
        Me.rbVentasRadioButton.Text = "Ventas"
        Me.rbVentasRadioButton.UseVisualStyleBackColor = True
        '
        'rbComprasRadioButton
        '
        Me.rbComprasRadioButton.AutoSize = True
        Me.rbComprasRadioButton.Checked = True
        Me.rbComprasRadioButton.Location = New System.Drawing.Point(31, 21)
        Me.rbComprasRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.rbComprasRadioButton.Name = "rbComprasRadioButton"
        Me.rbComprasRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.rbComprasRadioButton.TabIndex = 1
        Me.rbComprasRadioButton.TabStop = True
        Me.rbComprasRadioButton.Text = "Compras"
        Me.rbComprasRadioButton.UseVisualStyleBackColor = True
        '
        'CuotaIVATextBox
        '
        Me.CuotaIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.CuotaIVATextBox.Enabled = False
        Me.CuotaIVATextBox.Location = New System.Drawing.Point(189, 270)
        Me.CuotaIVATextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CuotaIVATextBox.Name = "CuotaIVATextBox"
        Me.CuotaIVATextBox.Size = New System.Drawing.Size(151, 20)
        Me.CuotaIVATextBox.TabIndex = 22
        '
        'BaseIVATextBox
        '
        Me.BaseIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.BaseIVATextBox.Location = New System.Drawing.Point(189, 237)
        Me.BaseIVATextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BaseIVATextBox.Name = "BaseIVATextBox"
        Me.BaseIVATextBox.Size = New System.Drawing.Size(151, 20)
        Me.BaseIVATextBox.TabIndex = 18
        '
        'AbonosTableAdapter
        '
        Me.AbonosTableAdapter.ClearBeforeFill = True
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'FacturasRecibidasTableAdapter
        '
        Me.FacturasRecibidasTableAdapter.ClearBeforeFill = True
        '
        'frmAsientos
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(852, 393)
        Me.ControlBox = False
        Me.Controls.Add(BaseIVALabel)
        Me.Controls.Add(Me.BaseIVATextBox)
        Me.Controls.Add(CuotaIVALabel)
        Me.Controls.Add(Me.CuotaIVATextBox)
        Me.Controls.Add(Me.TipoAsientoGroupBox)
        Me.Controls.Add(Me.BancosGroupBox)
        Me.Controls.Add(Me.IVAGroupBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ProveedoresComboBox)
        Me.Controls.Add(Me.CuentasGastoComboBox)
        Me.Controls.Add(NúmeroLabel)
        Me.Controls.Add(Me.NúmeroTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(JustificanteLabel)
        Me.Controls.Add(Me.JustificanteTextBox)
        Me.Controls.Add(OperaciónLabel)
        Me.Controls.Add(Me.OperaciónTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(TipoIVALabel)
        Me.Controls.Add(Me.TipoIVATextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
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
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents TipoIVATextBox As TextBox
    Friend WithEvents FrmAsientosBindingSource As BindingSource
    Friend WithEvents CuentasGastoBindingSource As BindingSource
    Friend WithEvents CuentasGastoTableAdapter As BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter
    Friend WithEvents CuentasGastoComboBox As ComboBox
    Friend WithEvents CuentasProveedoresBindingSource As BindingSource
    Friend WithEvents CuentasProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter
    Friend WithEvents ProveedoresComboBox As ComboBox
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
    Friend WithEvents CuotaIVATextBox As TextBox
    Friend WithEvents BaseIVATextBox As TextBox
    Friend WithEvents AbonosTableAdapter As BDContabilidadGMELOTableAdapters.AbonosTableAdapter
    Friend WithEvents CargosTableAdapter As BDContabilidadGMELOTableAdapters.CargosTableAdapter
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
End Class
