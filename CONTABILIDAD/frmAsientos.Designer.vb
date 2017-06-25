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
        Dim Label3 As System.Windows.Forms.Label
        Dim BaseIVALabel As System.Windows.Forms.Label
        Dim CuotaIVALabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim JustificanteLabel As System.Windows.Forms.Label
        Dim TipoIVALabel As System.Windows.Forms.Label
        Dim OperaciónLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NúmeroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoAsientoGroupBox = New System.Windows.Forms.GroupBox()
        Me.DevolPrestamoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CuotaTarjetaRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbAdeudoTelePeajeRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbReintegroRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbVentasRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbComprasRadioButton = New System.Windows.Forms.RadioButton()
        Me.FrmAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDisposiciónGroupBox = New System.Windows.Forms.GroupBox()
        Me.BancosDispComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.TotalDispuestoTextBox = New System.Windows.Forms.TextBox()
        Me.NúmeroOficinaTextBox = New System.Windows.Forms.TextBox()
        Me.rbCajeroRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbChequeRadioButton = New System.Windows.Forms.RadioButton()
        Me.rbVentanillaRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdeudoTelepeajeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Bancos2ComboBox = New System.Windows.Forms.ComboBox()
        Me.rbBanco2RadioButton = New System.Windows.Forms.RadioButton()
        Me.rbCaja2RadioButton = New System.Windows.Forms.RadioButton()
        Me.TotalTelepeajeTextBox = New System.Windows.Forms.TextBox()
        Me.DatosCompraGroupBox = New System.Windows.Forms.GroupBox()
        Me.BaseIVATextBox = New System.Windows.Forms.TextBox()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuotaIVATextBox = New System.Windows.Forms.TextBox()
        Me.BancosGroupBox = New System.Windows.Forms.GroupBox()
        Me.BancosComboBox = New System.Windows.Forms.ComboBox()
        Me.rbPagoBanco = New System.Windows.Forms.RadioButton()
        Me.rbPagoCaja = New System.Windows.Forms.RadioButton()
        Me.IVAGroupBox = New System.Windows.Forms.GroupBox()
        Me.rbIVASuperReducido = New System.Windows.Forms.RadioButton()
        Me.rbIVAReducido = New System.Windows.Forms.RadioButton()
        Me.rbIVANormal = New System.Windows.Forms.RadioButton()
        Me.rbIVANo = New System.Windows.Forms.RadioButton()
        Me.ProveedoresComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasGastoComboBox = New System.Windows.Forms.ComboBox()
        Me.CuentasGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoIVATextBox = New System.Windows.Forms.TextBox()
        Me.JustificanteTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.OperaciónTextBox = New System.Windows.Forms.TextBox()
        Me.CuotaTarjetaGroupBox = New System.Windows.Forms.GroupBox()
        Me.TarjetaTextBox = New System.Windows.Forms.TextBox()
        Me.BancoCuentaTjtaComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalCuotaTarjeaTextBox = New System.Windows.Forms.TextBox()
        Me.DevolPrestamoGroupBox = New System.Windows.Forms.GroupBox()
        Me.InteresesMoraTextBox = New System.Windows.Forms.TextBox()
        Me.CapitalDevueltoTextBox = New System.Windows.Forms.TextBox()
        Me.InteresesTextBox = New System.Windows.Forms.TextBox()
        Me.PréstamosLargoPlazoComboBox = New System.Windows.Forms.ComboBox()
        Me.PréstamosLargoPlazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.CuentasGastoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter()
        Me.CuentasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter()
        Me.ProveedoresTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter()
        Me.CuentasBancariasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter()
        Me.AbonosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AbonosTableAdapter()
        Me.CargosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CargosTableAdapter()
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        Me.PréstamosLargoPlazoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.PréstamosLargoPlazoTableAdapter()
        Me.PréstamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PréstamosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.PréstamosTableAdapter()
        NúmeroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        BaseIVALabel = New System.Windows.Forms.Label()
        CuotaIVALabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        JustificanteLabel = New System.Windows.Forms.Label()
        TipoIVALabel = New System.Windows.Forms.Label()
        OperaciónLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TipoAsientoGroupBox.SuspendLayout()
        CType(Me.FrmAsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoDisposiciónGroupBox.SuspendLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdeudoTelepeajeGroupBox.SuspendLayout()
        Me.DatosCompraGroupBox.SuspendLayout()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BancosGroupBox.SuspendLayout()
        Me.IVAGroupBox.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuotaTarjetaGroupBox.SuspendLayout()
        Me.DevolPrestamoGroupBox.SuspendLayout()
        CType(Me.PréstamosLargoPlazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PréstamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NúmeroLabel
        '
        NúmeroLabel.AutoSize = True
        NúmeroLabel.Location = New System.Drawing.Point(31, 84)
        NúmeroLabel.Name = "NúmeroLabel"
        NúmeroLabel.Size = New System.Drawing.Size(62, 17)
        NúmeroLabel.TabIndex = 1
        NúmeroLabel.Text = "Número:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(269, 84)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(357, 28)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(168, 17)
        Label3.TabIndex = 3
        Label3.Text = "Ventanilla/Cajero/Cheque"
        '
        'BaseIVALabel
        '
        BaseIVALabel.AutoSize = True
        BaseIVALabel.Location = New System.Drawing.Point(152, 206)
        BaseIVALabel.Name = "BaseIVALabel"
        BaseIVALabel.Size = New System.Drawing.Size(40, 17)
        BaseIVALabel.TabIndex = 53
        BaseIVALabel.Text = "Base"
        '
        'CuotaIVALabel
        '
        CuotaIVALabel.AutoSize = True
        CuotaIVALabel.Enabled = False
        CuotaIVALabel.Location = New System.Drawing.Point(152, 246)
        CuotaIVALabel.Name = "CuotaIVALabel"
        CuotaIVALabel.Size = New System.Drawing.Size(74, 17)
        CuotaIVALabel.TabIndex = 57
        CuotaIVALabel.Text = "Cuota IVA:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(577, 30)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 17)
        Label2.TabIndex = 43
        Label2.Text = "Gasto:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 30)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 17)
        Label1.TabIndex = 41
        Label1.Text = "Proveedor:"
        '
        'JustificanteLabel
        '
        JustificanteLabel.AutoSize = True
        JustificanteLabel.Location = New System.Drawing.Point(787, 74)
        JustificanteLabel.Name = "JustificanteLabel"
        JustificanteLabel.Size = New System.Drawing.Size(83, 17)
        JustificanteLabel.TabIndex = 47
        JustificanteLabel.Text = "Justificante:"
        '
        'TipoIVALabel
        '
        TipoIVALabel.AutoSize = True
        TipoIVALabel.Location = New System.Drawing.Point(9, 246)
        TipoIVALabel.Name = "TipoIVALabel"
        TipoIVALabel.Size = New System.Drawing.Size(65, 17)
        TipoIVALabel.TabIndex = 55
        TipoIVALabel.Text = "Tipo IVA:"
        '
        'OperaciónLabel
        '
        OperaciónLabel.AutoSize = True
        OperaciónLabel.Location = New System.Drawing.Point(9, 74)
        OperaciónLabel.Name = "OperaciónLabel"
        OperaciónLabel.Size = New System.Drawing.Size(78, 17)
        OperaciónLabel.TabIndex = 45
        OperaciónLabel.Text = "Operación:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(152, 282)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(44, 17)
        TotalLabel.TabIndex = 51
        TotalLabel.Text = "Total:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(673, 25)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(44, 17)
        Label4.TabIndex = 53
        Label4.Text = "Total:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(27, 25)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 17)
        Label5.TabIndex = 53
        Label5.Text = "Total:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(132, 32)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(44, 17)
        Label6.TabIndex = 53
        Label6.Text = "Total:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(203, 87)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(70, 17)
        Label7.TabIndex = 55
        Label7.Text = "Intereses:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(9, 87)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(55, 17)
        Label8.TabIndex = 57
        Label8.Text = "Capital:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(423, 87)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(128, 17)
        Label9.TabIndex = 59
        Label9.Text = "Penalización mora:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(955, 733)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NúmeroTextBox
        '
        Me.NúmeroTextBox.Enabled = False
        Me.NúmeroTextBox.Location = New System.Drawing.Point(119, 79)
        Me.NúmeroTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NúmeroTextBox.Name = "NúmeroTextBox"
        Me.NúmeroTextBox.Size = New System.Drawing.Size(119, 22)
        Me.NúmeroTextBox.TabIndex = 2
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(331, 79)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'TipoAsientoGroupBox
        '
        Me.TipoAsientoGroupBox.Controls.Add(Me.DevolPrestamoRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.CuotaTarjetaRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbAdeudoTelePeajeRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbReintegroRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbVentasRadioButton)
        Me.TipoAsientoGroupBox.Controls.Add(Me.rbComprasRadioButton)
        Me.TipoAsientoGroupBox.Location = New System.Drawing.Point(27, 11)
        Me.TipoAsientoGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoAsientoGroupBox.Name = "TipoAsientoGroupBox"
        Me.TipoAsientoGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoAsientoGroupBox.Size = New System.Drawing.Size(1076, 53)
        Me.TipoAsientoGroupBox.TabIndex = 0
        Me.TipoAsientoGroupBox.TabStop = False
        Me.TipoAsientoGroupBox.Text = "Tipo de Asiento"
        '
        'DevolPrestamoRadioButton
        '
        Me.DevolPrestamoRadioButton.AutoSize = True
        Me.DevolPrestamoRadioButton.Location = New System.Drawing.Point(608, 26)
        Me.DevolPrestamoRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DevolPrestamoRadioButton.Name = "DevolPrestamoRadioButton"
        Me.DevolPrestamoRadioButton.Size = New System.Drawing.Size(163, 21)
        Me.DevolPrestamoRadioButton.TabIndex = 5
        Me.DevolPrestamoRadioButton.Text = "Devolución Préstamo"
        Me.DevolPrestamoRadioButton.UseVisualStyleBackColor = True
        '
        'CuotaTarjetaRadioButton
        '
        Me.CuotaTarjetaRadioButton.AutoSize = True
        Me.CuotaTarjetaRadioButton.Location = New System.Drawing.Point(484, 26)
        Me.CuotaTarjetaRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuotaTarjetaRadioButton.Name = "CuotaTarjetaRadioButton"
        Me.CuotaTarjetaRadioButton.Size = New System.Drawing.Size(115, 21)
        Me.CuotaTarjetaRadioButton.TabIndex = 4
        Me.CuotaTarjetaRadioButton.Text = "Cuota Tarjeta"
        Me.CuotaTarjetaRadioButton.UseVisualStyleBackColor = True
        '
        'rbAdeudoTelePeajeRadioButton
        '
        Me.rbAdeudoTelePeajeRadioButton.AutoSize = True
        Me.rbAdeudoTelePeajeRadioButton.Location = New System.Drawing.Point(329, 26)
        Me.rbAdeudoTelePeajeRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAdeudoTelePeajeRadioButton.Name = "rbAdeudoTelePeajeRadioButton"
        Me.rbAdeudoTelePeajeRadioButton.Size = New System.Drawing.Size(145, 21)
        Me.rbAdeudoTelePeajeRadioButton.TabIndex = 3
        Me.rbAdeudoTelePeajeRadioButton.Text = "Adeudo Telepeaje"
        Me.rbAdeudoTelePeajeRadioButton.UseVisualStyleBackColor = True
        '
        'rbReintegroRadioButton
        '
        Me.rbReintegroRadioButton.AutoSize = True
        Me.rbReintegroRadioButton.Location = New System.Drawing.Point(157, 26)
        Me.rbReintegroRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbReintegroRadioButton.Name = "rbReintegroRadioButton"
        Me.rbReintegroRadioButton.Size = New System.Drawing.Size(155, 21)
        Me.rbReintegroRadioButton.TabIndex = 2
        Me.rbReintegroRadioButton.Text = "Disposición Efectivo"
        Me.rbReintegroRadioButton.UseVisualStyleBackColor = True
        '
        'rbVentasRadioButton
        '
        Me.rbVentasRadioButton.AutoSize = True
        Me.rbVentasRadioButton.Location = New System.Drawing.Point(976, 21)
        Me.rbVentasRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbVentasRadioButton.Name = "rbVentasRadioButton"
        Me.rbVentasRadioButton.Size = New System.Drawing.Size(73, 21)
        Me.rbVentasRadioButton.TabIndex = 1
        Me.rbVentasRadioButton.Text = "Ventas"
        Me.rbVentasRadioButton.UseVisualStyleBackColor = True
        '
        'rbComprasRadioButton
        '
        Me.rbComprasRadioButton.AutoSize = True
        Me.rbComprasRadioButton.Location = New System.Drawing.Point(41, 26)
        Me.rbComprasRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbComprasRadioButton.Name = "rbComprasRadioButton"
        Me.rbComprasRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.rbComprasRadioButton.TabIndex = 1
        Me.rbComprasRadioButton.Text = "Pagos"
        Me.rbComprasRadioButton.UseVisualStyleBackColor = True
        '
        'TipoDisposiciónGroupBox
        '
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.BancosDispComboBox)
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.TotalDispuestoTextBox)
        Me.TipoDisposiciónGroupBox.Controls.Add(Label4)
        Me.TipoDisposiciónGroupBox.Controls.Add(Label3)
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.NúmeroOficinaTextBox)
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.rbCajeroRadioButton)
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.rbChequeRadioButton)
        Me.TipoDisposiciónGroupBox.Controls.Add(Me.rbVentanillaRadioButton)
        Me.TipoDisposiciónGroupBox.Location = New System.Drawing.Point(27, 449)
        Me.TipoDisposiciónGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoDisposiciónGroupBox.Name = "TipoDisposiciónGroupBox"
        Me.TipoDisposiciónGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoDisposiciónGroupBox.Size = New System.Drawing.Size(1095, 53)
        Me.TipoDisposiciónGroupBox.TabIndex = 23
        Me.TipoDisposiciónGroupBox.TabStop = False
        Me.TipoDisposiciónGroupBox.Text = "Tipo de Disposición"
        Me.TipoDisposiciónGroupBox.Visible = False
        '
        'BancosDispComboBox
        '
        Me.BancosDispComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "Banco", True))
        Me.BancosDispComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CuentasBancariasBindingSource, "id", True))
        Me.BancosDispComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.BancosDispComboBox.DisplayMember = "Banco"
        Me.BancosDispComboBox.FormattingEnabled = True
        Me.BancosDispComboBox.Location = New System.Drawing.Point(893, 20)
        Me.BancosDispComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BancosDispComboBox.Name = "BancosDispComboBox"
        Me.BancosDispComboBox.Size = New System.Drawing.Size(159, 24)
        Me.BancosDispComboBox.TabIndex = 55
        Me.BancosDispComboBox.ValueMember = "id"
        '
        'CuentasBancariasBindingSource
        '
        Me.CuentasBancariasBindingSource.DataMember = "CuentasBancarias"
        Me.CuentasBancariasBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasBancariasBindingSource.Filter = "id<3"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalDispuestoTextBox
        '
        Me.TotalDispuestoTextBox.Location = New System.Drawing.Point(755, 21)
        Me.TotalDispuestoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalDispuestoTextBox.Name = "TotalDispuestoTextBox"
        Me.TotalDispuestoTextBox.Size = New System.Drawing.Size(115, 22)
        Me.TotalDispuestoTextBox.TabIndex = 54
        '
        'NúmeroOficinaTextBox
        '
        Me.NúmeroOficinaTextBox.Location = New System.Drawing.Point(541, 21)
        Me.NúmeroOficinaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NúmeroOficinaTextBox.Name = "NúmeroOficinaTextBox"
        Me.NúmeroOficinaTextBox.Size = New System.Drawing.Size(116, 22)
        Me.NúmeroOficinaTextBox.TabIndex = 4
        '
        'rbCajeroRadioButton
        '
        Me.rbCajeroRadioButton.AutoSize = True
        Me.rbCajeroRadioButton.Location = New System.Drawing.Point(157, 26)
        Me.rbCajeroRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbCajeroRadioButton.Name = "rbCajeroRadioButton"
        Me.rbCajeroRadioButton.Size = New System.Drawing.Size(70, 21)
        Me.rbCajeroRadioButton.TabIndex = 2
        Me.rbCajeroRadioButton.Text = "Cajero"
        Me.rbCajeroRadioButton.UseVisualStyleBackColor = True
        '
        'rbChequeRadioButton
        '
        Me.rbChequeRadioButton.AutoSize = True
        Me.rbChequeRadioButton.Location = New System.Drawing.Point(264, 26)
        Me.rbChequeRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbChequeRadioButton.Name = "rbChequeRadioButton"
        Me.rbChequeRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.rbChequeRadioButton.TabIndex = 1
        Me.rbChequeRadioButton.Text = "Cheque"
        Me.rbChequeRadioButton.UseVisualStyleBackColor = True
        '
        'rbVentanillaRadioButton
        '
        Me.rbVentanillaRadioButton.AutoSize = True
        Me.rbVentanillaRadioButton.Checked = True
        Me.rbVentanillaRadioButton.Location = New System.Drawing.Point(41, 26)
        Me.rbVentanillaRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbVentanillaRadioButton.Name = "rbVentanillaRadioButton"
        Me.rbVentanillaRadioButton.Size = New System.Drawing.Size(91, 21)
        Me.rbVentanillaRadioButton.TabIndex = 1
        Me.rbVentanillaRadioButton.TabStop = True
        Me.rbVentanillaRadioButton.Text = "Ventanilla"
        Me.rbVentanillaRadioButton.UseVisualStyleBackColor = True
        '
        'AdeudoTelepeajeGroupBox
        '
        Me.AdeudoTelepeajeGroupBox.Controls.Add(Me.Bancos2ComboBox)
        Me.AdeudoTelepeajeGroupBox.Controls.Add(Me.rbBanco2RadioButton)
        Me.AdeudoTelepeajeGroupBox.Controls.Add(Me.rbCaja2RadioButton)
        Me.AdeudoTelepeajeGroupBox.Controls.Add(Me.TotalTelepeajeTextBox)
        Me.AdeudoTelepeajeGroupBox.Controls.Add(Label5)
        Me.AdeudoTelepeajeGroupBox.Location = New System.Drawing.Point(27, 523)
        Me.AdeudoTelepeajeGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdeudoTelepeajeGroupBox.Name = "AdeudoTelepeajeGroupBox"
        Me.AdeudoTelepeajeGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdeudoTelepeajeGroupBox.Size = New System.Drawing.Size(564, 55)
        Me.AdeudoTelepeajeGroupBox.TabIndex = 25
        Me.AdeudoTelepeajeGroupBox.TabStop = False
        Me.AdeudoTelepeajeGroupBox.Text = "Adeudo Telepeaje"
        Me.AdeudoTelepeajeGroupBox.Visible = False
        '
        'Bancos2ComboBox
        '
        Me.Bancos2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CuentasBancariasBindingSource, "id", True))
        Me.Bancos2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "Banco", True))
        Me.Bancos2ComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.Bancos2ComboBox.DisplayMember = "Banco"
        Me.Bancos2ComboBox.FormattingEnabled = True
        Me.Bancos2ComboBox.Location = New System.Drawing.Point(329, 25)
        Me.Bancos2ComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bancos2ComboBox.Name = "Bancos2ComboBox"
        Me.Bancos2ComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Bancos2ComboBox.TabIndex = 58
        Me.Bancos2ComboBox.ValueMember = "id"
        '
        'rbBanco2RadioButton
        '
        Me.rbBanco2RadioButton.AutoSize = True
        Me.rbBanco2RadioButton.Checked = True
        Me.rbBanco2RadioButton.Location = New System.Drawing.Point(247, 25)
        Me.rbBanco2RadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbBanco2RadioButton.Name = "rbBanco2RadioButton"
        Me.rbBanco2RadioButton.Size = New System.Drawing.Size(69, 21)
        Me.rbBanco2RadioButton.TabIndex = 57
        Me.rbBanco2RadioButton.TabStop = True
        Me.rbBanco2RadioButton.Text = "Banco"
        Me.rbBanco2RadioButton.UseVisualStyleBackColor = True
        '
        'rbCaja2RadioButton
        '
        Me.rbCaja2RadioButton.AutoSize = True
        Me.rbCaja2RadioButton.Location = New System.Drawing.Point(167, 27)
        Me.rbCaja2RadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbCaja2RadioButton.Name = "rbCaja2RadioButton"
        Me.rbCaja2RadioButton.Size = New System.Drawing.Size(57, 21)
        Me.rbCaja2RadioButton.TabIndex = 56
        Me.rbCaja2RadioButton.Text = "Caja"
        Me.rbCaja2RadioButton.UseVisualStyleBackColor = True
        '
        'TotalTelepeajeTextBox
        '
        Me.TotalTelepeajeTextBox.Location = New System.Drawing.Point(77, 23)
        Me.TotalTelepeajeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalTelepeajeTextBox.Name = "TotalTelepeajeTextBox"
        Me.TotalTelepeajeTextBox.Size = New System.Drawing.Size(75, 22)
        Me.TotalTelepeajeTextBox.TabIndex = 54
        '
        'DatosCompraGroupBox
        '
        Me.DatosCompraGroupBox.Controls.Add(BaseIVALabel)
        Me.DatosCompraGroupBox.Controls.Add(Me.BaseIVATextBox)
        Me.DatosCompraGroupBox.Controls.Add(CuotaIVALabel)
        Me.DatosCompraGroupBox.Controls.Add(Me.CuotaIVATextBox)
        Me.DatosCompraGroupBox.Controls.Add(Me.BancosGroupBox)
        Me.DatosCompraGroupBox.Controls.Add(Me.IVAGroupBox)
        Me.DatosCompraGroupBox.Controls.Add(Label2)
        Me.DatosCompraGroupBox.Controls.Add(Label1)
        Me.DatosCompraGroupBox.Controls.Add(Me.ProveedoresComboBox)
        Me.DatosCompraGroupBox.Controls.Add(Me.CuentasGastoComboBox)
        Me.DatosCompraGroupBox.Controls.Add(Me.TipoIVATextBox)
        Me.DatosCompraGroupBox.Controls.Add(JustificanteLabel)
        Me.DatosCompraGroupBox.Controls.Add(TipoIVALabel)
        Me.DatosCompraGroupBox.Controls.Add(Me.JustificanteTextBox)
        Me.DatosCompraGroupBox.Controls.Add(Me.TotalTextBox)
        Me.DatosCompraGroupBox.Controls.Add(OperaciónLabel)
        Me.DatosCompraGroupBox.Controls.Add(TotalLabel)
        Me.DatosCompraGroupBox.Controls.Add(Me.OperaciónTextBox)
        Me.DatosCompraGroupBox.Location = New System.Drawing.Point(27, 121)
        Me.DatosCompraGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosCompraGroupBox.Name = "DatosCompraGroupBox"
        Me.DatosCompraGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.DatosCompraGroupBox.Size = New System.Drawing.Size(1169, 322)
        Me.DatosCompraGroupBox.TabIndex = 24
        Me.DatosCompraGroupBox.TabStop = False
        Me.DatosCompraGroupBox.Text = "Datos Compra"
        Me.DatosCompraGroupBox.Visible = False
        '
        'BaseIVATextBox
        '
        Me.BaseIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.BaseIVATextBox.Enabled = False
        Me.BaseIVATextBox.Location = New System.Drawing.Point(235, 197)
        Me.BaseIVATextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BaseIVATextBox.Name = "BaseIVATextBox"
        Me.BaseIVATextBox.Size = New System.Drawing.Size(200, 22)
        Me.BaseIVATextBox.TabIndex = 54
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuotaIVATextBox
        '
        Me.CuotaIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.CuotaIVATextBox.Enabled = False
        Me.CuotaIVATextBox.Location = New System.Drawing.Point(235, 238)
        Me.CuotaIVATextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuotaIVATextBox.Name = "CuotaIVATextBox"
        Me.CuotaIVATextBox.Size = New System.Drawing.Size(200, 22)
        Me.CuotaIVATextBox.TabIndex = 58
        '
        'BancosGroupBox
        '
        Me.BancosGroupBox.Controls.Add(Me.BancosComboBox)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoBanco)
        Me.BancosGroupBox.Controls.Add(Me.rbPagoCaja)
        Me.BancosGroupBox.Location = New System.Drawing.Point(487, 116)
        Me.BancosGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BancosGroupBox.Name = "BancosGroupBox"
        Me.BancosGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BancosGroupBox.Size = New System.Drawing.Size(468, 73)
        Me.BancosGroupBox.TabIndex = 50
        Me.BancosGroupBox.TabStop = False
        Me.BancosGroupBox.Text = "Datos Pago"
        '
        'BancosComboBox
        '
        Me.BancosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "Banco", True))
        Me.BancosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CuentasBancariasBindingSource, "id", True))
        Me.BancosComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.BancosComboBox.DisplayMember = "Banco"
        Me.BancosComboBox.FormattingEnabled = True
        Me.BancosComboBox.Location = New System.Drawing.Point(213, 18)
        Me.BancosComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BancosComboBox.Name = "BancosComboBox"
        Me.BancosComboBox.Size = New System.Drawing.Size(200, 24)
        Me.BancosComboBox.TabIndex = 3
        Me.BancosComboBox.ValueMember = "id"
        '
        'rbPagoBanco
        '
        Me.rbPagoBanco.AutoSize = True
        Me.rbPagoBanco.Checked = True
        Me.rbPagoBanco.Location = New System.Drawing.Point(139, 22)
        Me.rbPagoBanco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.rbPagoCaja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPagoCaja.Name = "rbPagoCaja"
        Me.rbPagoCaja.Size = New System.Drawing.Size(57, 21)
        Me.rbPagoCaja.TabIndex = 0
        Me.rbPagoCaja.Text = "Caja"
        Me.rbPagoCaja.UseVisualStyleBackColor = True
        '
        'IVAGroupBox
        '
        Me.IVAGroupBox.Controls.Add(Me.rbIVASuperReducido)
        Me.IVAGroupBox.Controls.Add(Me.rbIVAReducido)
        Me.IVAGroupBox.Controls.Add(Me.rbIVANormal)
        Me.IVAGroupBox.Controls.Add(Me.rbIVANo)
        Me.IVAGroupBox.Location = New System.Drawing.Point(9, 116)
        Me.IVAGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IVAGroupBox.Name = "IVAGroupBox"
        Me.IVAGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IVAGroupBox.Size = New System.Drawing.Size(468, 62)
        Me.IVAGroupBox.TabIndex = 49
        Me.IVAGroupBox.TabStop = False
        Me.IVAGroupBox.Text = "IVA"
        '
        'rbIVASuperReducido
        '
        Me.rbIVASuperReducido.AutoSize = True
        Me.rbIVASuperReducido.Location = New System.Drawing.Point(373, 22)
        Me.rbIVASuperReducido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.rbIVAReducido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.rbIVANormal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.rbIVANo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbIVANo.Name = "rbIVANo"
        Me.rbIVANo.Size = New System.Drawing.Size(50, 21)
        Me.rbIVANo.TabIndex = 0
        Me.rbIVANo.Text = "NO"
        Me.rbIVANo.UseVisualStyleBackColor = True
        '
        'ProveedoresComboBox
        '
        Me.ProveedoresComboBox.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresComboBox.DisplayMember = "Nombre"
        Me.ProveedoresComboBox.FormattingEnabled = True
        Me.ProveedoresComboBox.Location = New System.Drawing.Point(97, 22)
        Me.ProveedoresComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProveedoresComboBox.Name = "ProveedoresComboBox"
        Me.ProveedoresComboBox.Size = New System.Drawing.Size(411, 24)
        Me.ProveedoresComboBox.TabIndex = 42
        Me.ProveedoresComboBox.ValueMember = "DocumentoIdentidad"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.ProveedoresBindingSource.Sort = "Nombre"
        '
        'CuentasGastoComboBox
        '
        Me.CuentasGastoComboBox.DataSource = Me.CuentasGastoBindingSource
        Me.CuentasGastoComboBox.DisplayMember = "Nombre"
        Me.CuentasGastoComboBox.FormattingEnabled = True
        Me.CuentasGastoComboBox.Location = New System.Drawing.Point(665, 22)
        Me.CuentasGastoComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuentasGastoComboBox.Name = "CuentasGastoComboBox"
        Me.CuentasGastoComboBox.Size = New System.Drawing.Size(411, 24)
        Me.CuentasGastoComboBox.TabIndex = 44
        Me.CuentasGastoComboBox.ValueMember = "Código"
        '
        'CuentasGastoBindingSource
        '
        Me.CuentasGastoBindingSource.DataMember = "CuentasGasto"
        Me.CuentasGastoBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.CuentasGastoBindingSource.Sort = "Nombre"
        '
        'TipoIVATextBox
        '
        Me.TipoIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Haber", True))
        Me.TipoIVATextBox.Enabled = False
        Me.TipoIVATextBox.Location = New System.Drawing.Point(97, 238)
        Me.TipoIVATextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoIVATextBox.Name = "TipoIVATextBox"
        Me.TipoIVATextBox.Size = New System.Drawing.Size(32, 22)
        Me.TipoIVATextBox.TabIndex = 56
        '
        'JustificanteTextBox
        '
        Me.JustificanteTextBox.Location = New System.Drawing.Point(876, 69)
        Me.JustificanteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JustificanteTextBox.Name = "JustificanteTextBox"
        Me.JustificanteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.JustificanteTextBox.TabIndex = 48
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(233, 278)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TotalTextBox.TabIndex = 52
        '
        'OperaciónTextBox
        '
        Me.OperaciónTextBox.Location = New System.Drawing.Point(97, 69)
        Me.OperaciónTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OperaciónTextBox.Name = "OperaciónTextBox"
        Me.OperaciónTextBox.Size = New System.Drawing.Size(660, 22)
        Me.OperaciónTextBox.TabIndex = 46
        '
        'CuotaTarjetaGroupBox
        '
        Me.CuotaTarjetaGroupBox.Controls.Add(Me.TarjetaTextBox)
        Me.CuotaTarjetaGroupBox.Controls.Add(Me.BancoCuentaTjtaComboBox)
        Me.CuotaTarjetaGroupBox.Controls.Add(Me.TotalCuotaTarjeaTextBox)
        Me.CuotaTarjetaGroupBox.Controls.Add(Label6)
        Me.CuotaTarjetaGroupBox.Location = New System.Drawing.Point(608, 523)
        Me.CuotaTarjetaGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuotaTarjetaGroupBox.Name = "CuotaTarjetaGroupBox"
        Me.CuotaTarjetaGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuotaTarjetaGroupBox.Size = New System.Drawing.Size(515, 55)
        Me.CuotaTarjetaGroupBox.TabIndex = 26
        Me.CuotaTarjetaGroupBox.TabStop = False
        Me.CuotaTarjetaGroupBox.Text = "Cuota Tarjeta"
        Me.CuotaTarjetaGroupBox.Visible = False
        '
        'TarjetaTextBox
        '
        Me.TarjetaTextBox.Location = New System.Drawing.Point(5, 23)
        Me.TarjetaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TarjetaTextBox.Name = "TarjetaTextBox"
        Me.TarjetaTextBox.Size = New System.Drawing.Size(120, 22)
        Me.TarjetaTextBox.TabIndex = 59
        '
        'BancoCuentaTjtaComboBox
        '
        Me.BancoCuentaTjtaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CuentasBancariasBindingSource, "id", True))
        Me.BancoCuentaTjtaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBancariasBindingSource, "Banco", True))
        Me.BancoCuentaTjtaComboBox.DataSource = Me.CuentasBancariasBindingSource
        Me.BancoCuentaTjtaComboBox.DisplayMember = "Banco"
        Me.BancoCuentaTjtaComboBox.FormattingEnabled = True
        Me.BancoCuentaTjtaComboBox.Location = New System.Drawing.Point(264, 25)
        Me.BancoCuentaTjtaComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BancoCuentaTjtaComboBox.Name = "BancoCuentaTjtaComboBox"
        Me.BancoCuentaTjtaComboBox.Size = New System.Drawing.Size(200, 24)
        Me.BancoCuentaTjtaComboBox.TabIndex = 58
        Me.BancoCuentaTjtaComboBox.ValueMember = "id"
        '
        'TotalCuotaTarjeaTextBox
        '
        Me.TotalCuotaTarjeaTextBox.Location = New System.Drawing.Point(183, 25)
        Me.TotalCuotaTarjeaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalCuotaTarjeaTextBox.Name = "TotalCuotaTarjeaTextBox"
        Me.TotalCuotaTarjeaTextBox.Size = New System.Drawing.Size(75, 22)
        Me.TotalCuotaTarjeaTextBox.TabIndex = 54
        '
        'DevolPrestamoGroupBox
        '
        Me.DevolPrestamoGroupBox.Controls.Add(Me.InteresesMoraTextBox)
        Me.DevolPrestamoGroupBox.Controls.Add(Label9)
        Me.DevolPrestamoGroupBox.Controls.Add(Me.CapitalDevueltoTextBox)
        Me.DevolPrestamoGroupBox.Controls.Add(Label8)
        Me.DevolPrestamoGroupBox.Controls.Add(Me.InteresesTextBox)
        Me.DevolPrestamoGroupBox.Controls.Add(Label7)
        Me.DevolPrestamoGroupBox.Controls.Add(Me.PréstamosLargoPlazoComboBox)
        Me.DevolPrestamoGroupBox.Location = New System.Drawing.Point(27, 586)
        Me.DevolPrestamoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DevolPrestamoGroupBox.Name = "DevolPrestamoGroupBox"
        Me.DevolPrestamoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.DevolPrestamoGroupBox.Size = New System.Drawing.Size(1096, 123)
        Me.DevolPrestamoGroupBox.TabIndex = 27
        Me.DevolPrestamoGroupBox.TabStop = False
        Me.DevolPrestamoGroupBox.Text = "Devolución préstamo"
        Me.DevolPrestamoGroupBox.Visible = False
        '
        'InteresesMoraTextBox
        '
        Me.InteresesMoraTextBox.Location = New System.Drawing.Point(556, 79)
        Me.InteresesMoraTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InteresesMoraTextBox.Name = "InteresesMoraTextBox"
        Me.InteresesMoraTextBox.Size = New System.Drawing.Size(75, 22)
        Me.InteresesMoraTextBox.TabIndex = 2
        '
        'CapitalDevueltoTextBox
        '
        Me.CapitalDevueltoTextBox.Location = New System.Drawing.Point(77, 79)
        Me.CapitalDevueltoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CapitalDevueltoTextBox.Name = "CapitalDevueltoTextBox"
        Me.CapitalDevueltoTextBox.Size = New System.Drawing.Size(97, 22)
        Me.CapitalDevueltoTextBox.TabIndex = 0
        '
        'InteresesTextBox
        '
        Me.InteresesTextBox.Location = New System.Drawing.Point(304, 79)
        Me.InteresesTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InteresesTextBox.Name = "InteresesTextBox"
        Me.InteresesTextBox.Size = New System.Drawing.Size(75, 22)
        Me.InteresesTextBox.TabIndex = 1
        '
        'PréstamosLargoPlazoComboBox
        '
        Me.PréstamosLargoPlazoComboBox.DataSource = Me.PréstamosLargoPlazoBindingSource
        Me.PréstamosLargoPlazoComboBox.DisplayMember = "Nombre"
        Me.PréstamosLargoPlazoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PréstamosLargoPlazoComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PréstamosLargoPlazoComboBox.FormattingEnabled = True
        Me.PréstamosLargoPlazoComboBox.Location = New System.Drawing.Point(9, 23)
        Me.PréstamosLargoPlazoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PréstamosLargoPlazoComboBox.Name = "PréstamosLargoPlazoComboBox"
        Me.PréstamosLargoPlazoComboBox.Size = New System.Drawing.Size(963, 33)
        Me.PréstamosLargoPlazoComboBox.TabIndex = 3
        Me.PréstamosLargoPlazoComboBox.ValueMember = "Código"
        '
        'PréstamosLargoPlazoBindingSource
        '
        Me.PréstamosLargoPlazoBindingSource.DataMember = "PréstamosLargoPlazo"
        Me.PréstamosLargoPlazoBindingSource.DataSource = Me.BDContabilidadGMELO
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
        'CuentasGastoTableAdapter
        '
        Me.CuentasGastoTableAdapter.ClearBeforeFill = True
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
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CuentasBancariasTableAdapter
        '
        Me.CuentasBancariasTableAdapter.ClearBeforeFill = True
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
        'PréstamosLargoPlazoTableAdapter
        '
        Me.PréstamosLargoPlazoTableAdapter.ClearBeforeFill = True
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
        'frmAsientos
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1196, 928)
        Me.Controls.Add(Me.DevolPrestamoGroupBox)
        Me.Controls.Add(Me.CuotaTarjetaGroupBox)
        Me.Controls.Add(Me.AdeudoTelepeajeGroupBox)
        Me.Controls.Add(Me.DatosCompraGroupBox)
        Me.Controls.Add(Me.TipoAsientoGroupBox)
        Me.Controls.Add(NúmeroLabel)
        Me.Controls.Add(Me.NúmeroTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TipoDisposiciónGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsientos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAsientos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TipoAsientoGroupBox.ResumeLayout(False)
        Me.TipoAsientoGroupBox.PerformLayout()
        CType(Me.FrmAsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoDisposiciónGroupBox.ResumeLayout(False)
        Me.TipoDisposiciónGroupBox.PerformLayout()
        CType(Me.CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdeudoTelepeajeGroupBox.ResumeLayout(False)
        Me.AdeudoTelepeajeGroupBox.PerformLayout()
        Me.DatosCompraGroupBox.ResumeLayout(False)
        Me.DatosCompraGroupBox.PerformLayout()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BancosGroupBox.ResumeLayout(False)
        Me.BancosGroupBox.PerformLayout()
        Me.IVAGroupBox.ResumeLayout(False)
        Me.IVAGroupBox.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuotaTarjetaGroupBox.ResumeLayout(False)
        Me.CuotaTarjetaGroupBox.PerformLayout()
        Me.DevolPrestamoGroupBox.ResumeLayout(False)
        Me.DevolPrestamoGroupBox.PerformLayout()
        CType(Me.PréstamosLargoPlazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PréstamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FrmAsientosBindingSource As BindingSource
    Friend WithEvents CuentasGastoBindingSource As BindingSource
    Friend WithEvents CuentasGastoTableAdapter As BDContabilidadGMELOTableAdapters.CuentasGastoTableAdapter
    Friend WithEvents CuentasProveedoresBindingSource As BindingSource
    Friend WithEvents CuentasProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.CuentasProveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As BDContabilidadGMELOTableAdapters.ProveedoresTableAdapter
    Friend WithEvents CuentasBancariasBindingSource As BindingSource
    Friend WithEvents CuentasBancariasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasBancariasTableAdapter
    Friend WithEvents TipoAsientoGroupBox As GroupBox
    Friend WithEvents rbVentasRadioButton As RadioButton
    Friend WithEvents rbComprasRadioButton As RadioButton
    Friend WithEvents AbonosTableAdapter As BDContabilidadGMELOTableAdapters.AbonosTableAdapter
    Friend WithEvents CargosTableAdapter As BDContabilidadGMELOTableAdapters.CargosTableAdapter
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
    Friend WithEvents rbReintegroRadioButton As RadioButton
    Friend WithEvents TipoDisposiciónGroupBox As GroupBox
    Friend WithEvents rbCajeroRadioButton As RadioButton
    Friend WithEvents rbChequeRadioButton As RadioButton
    Friend WithEvents rbVentanillaRadioButton As RadioButton
    Friend WithEvents NúmeroOficinaTextBox As TextBox
    Friend WithEvents DatosCompraGroupBox As GroupBox
    Friend WithEvents BaseIVATextBox As TextBox
    Friend WithEvents CuotaIVATextBox As TextBox
    Friend WithEvents BancosGroupBox As GroupBox
    Friend WithEvents BancosComboBox As ComboBox
    Friend WithEvents rbPagoBanco As RadioButton
    Friend WithEvents rbPagoCaja As RadioButton
    Friend WithEvents IVAGroupBox As GroupBox
    Friend WithEvents rbIVASuperReducido As RadioButton
    Friend WithEvents rbIVAReducido As RadioButton
    Friend WithEvents rbIVANormal As RadioButton
    Friend WithEvents rbIVANo As RadioButton
    Friend WithEvents ProveedoresComboBox As ComboBox
    Friend WithEvents CuentasGastoComboBox As ComboBox
    Friend WithEvents TipoIVATextBox As TextBox
    Friend WithEvents JustificanteTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents OperaciónTextBox As TextBox
    Friend WithEvents TotalDispuestoTextBox As TextBox
    Friend WithEvents BancosDispComboBox As ComboBox
    Friend WithEvents rbAdeudoTelePeajeRadioButton As RadioButton
    Friend WithEvents AdeudoTelepeajeGroupBox As GroupBox
    Friend WithEvents Bancos2ComboBox As ComboBox
    Friend WithEvents rbBanco2RadioButton As RadioButton
    Friend WithEvents rbCaja2RadioButton As RadioButton
    Friend WithEvents TotalTelepeajeTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CuotaTarjetaRadioButton As RadioButton
    Friend WithEvents CuotaTarjetaGroupBox As GroupBox
    Friend WithEvents TarjetaTextBox As TextBox
    Friend WithEvents BancoCuentaTjtaComboBox As ComboBox
    Friend WithEvents TotalCuotaTarjeaTextBox As TextBox
    Friend WithEvents DevolPrestamoRadioButton As RadioButton
    Friend WithEvents DevolPrestamoGroupBox As GroupBox
    Friend WithEvents PréstamosLargoPlazoComboBox As ComboBox
    Friend WithEvents PréstamosLargoPlazoTableAdapter As BDContabilidadGMELOTableAdapters.PréstamosLargoPlazoTableAdapter
    Friend WithEvents PréstamosLargoPlazoBindingSource As BindingSource
    Friend WithEvents InteresesMoraTextBox As TextBox
    Friend WithEvents CapitalDevueltoTextBox As TextBox
    Friend WithEvents InteresesTextBox As TextBox
    Friend WithEvents PréstamosBindingSource As BindingSource
    Friend WithEvents PréstamosTableAdapter As BDContabilidadGMELOTableAdapters.PréstamosTableAdapter
End Class
