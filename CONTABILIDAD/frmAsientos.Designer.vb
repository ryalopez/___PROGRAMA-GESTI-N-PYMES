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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.NúmeroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JustificanteTextBox = New System.Windows.Forms.TextBox()
        Me.OperaciónTextBox = New System.Windows.Forms.TextBox()
        Me.DebeTextBox = New System.Windows.Forms.TextBox()
        Me.HaberTextBox = New System.Windows.Forms.TextBox()
        Me.FrmAsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        NúmeroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        JustificanteLabel = New System.Windows.Forms.Label()
        OperaciónLabel = New System.Windows.Forms.Label()
        DebeLabel = New System.Windows.Forms.Label()
        HaberLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmAsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(373, 423)
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
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
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
        'NúmeroLabel
        '
        NúmeroLabel.AutoSize = True
        NúmeroLabel.Location = New System.Drawing.Point(150, 58)
        NúmeroLabel.Name = "NúmeroLabel"
        NúmeroLabel.Size = New System.Drawing.Size(62, 17)
        NúmeroLabel.TabIndex = 2
        NúmeroLabel.Text = "Número:"
        '
        'NúmeroTextBox
        '
        Me.NúmeroTextBox.Enabled = False
        Me.NúmeroTextBox.Location = New System.Drawing.Point(239, 55)
        Me.NúmeroTextBox.Name = "NúmeroTextBox"
        Me.NúmeroTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NúmeroTextBox.TabIndex = 3
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(150, 87)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsientosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(239, 83)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'JustificanteLabel
        '
        JustificanteLabel.AutoSize = True
        JustificanteLabel.Location = New System.Drawing.Point(150, 114)
        JustificanteLabel.Name = "JustificanteLabel"
        JustificanteLabel.Size = New System.Drawing.Size(83, 17)
        JustificanteLabel.TabIndex = 6
        JustificanteLabel.Text = "Justificante:"
        '
        'JustificanteTextBox
        '
        Me.JustificanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Justificante", True))
        Me.JustificanteTextBox.Location = New System.Drawing.Point(239, 111)
        Me.JustificanteTextBox.Name = "JustificanteTextBox"
        Me.JustificanteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.JustificanteTextBox.TabIndex = 7
        '
        'OperaciónLabel
        '
        OperaciónLabel.AutoSize = True
        OperaciónLabel.Location = New System.Drawing.Point(150, 142)
        OperaciónLabel.Name = "OperaciónLabel"
        OperaciónLabel.Size = New System.Drawing.Size(78, 17)
        OperaciónLabel.TabIndex = 8
        OperaciónLabel.Text = "Operación:"
        '
        'OperaciónTextBox
        '
        Me.OperaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Operación", True))
        Me.OperaciónTextBox.Enabled = False
        Me.OperaciónTextBox.Location = New System.Drawing.Point(239, 139)
        Me.OperaciónTextBox.Name = "OperaciónTextBox"
        Me.OperaciónTextBox.Size = New System.Drawing.Size(200, 22)
        Me.OperaciónTextBox.TabIndex = 9
        '
        'DebeLabel
        '
        DebeLabel.AutoSize = True
        DebeLabel.Location = New System.Drawing.Point(150, 170)
        DebeLabel.Name = "DebeLabel"
        DebeLabel.Size = New System.Drawing.Size(46, 17)
        DebeLabel.TabIndex = 10
        DebeLabel.Text = "Debe:"
        '
        'DebeTextBox
        '
        Me.DebeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Debe", True))
        Me.DebeTextBox.Enabled = False
        Me.DebeTextBox.Location = New System.Drawing.Point(239, 167)
        Me.DebeTextBox.Name = "DebeTextBox"
        Me.DebeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DebeTextBox.TabIndex = 11
        '
        'HaberLabel
        '
        HaberLabel.AutoSize = True
        HaberLabel.Location = New System.Drawing.Point(150, 198)
        HaberLabel.Name = "HaberLabel"
        HaberLabel.Size = New System.Drawing.Size(51, 17)
        HaberLabel.TabIndex = 12
        HaberLabel.Text = "Haber:"
        '
        'HaberTextBox
        '
        Me.HaberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsientosBindingSource, "Haber", True))
        Me.HaberTextBox.Enabled = False
        Me.HaberTextBox.Location = New System.Drawing.Point(239, 195)
        Me.HaberTextBox.Name = "HaberTextBox"
        Me.HaberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.HaberTextBox.TabIndex = 13
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
        Me.ClientSize = New System.Drawing.Size(584, 474)
        Me.ControlBox = False
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
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
