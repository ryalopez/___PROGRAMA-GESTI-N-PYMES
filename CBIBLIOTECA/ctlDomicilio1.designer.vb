<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDomicilio1
    'Inherits Control

    ''UserControl reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    ''Requerido por el Diseñador de Windows Forms
    'Private components As System.ComponentModel.IContainer

    ''NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    ''Se puede modificar usando el Diseñador de Windows Forms.  
    ''No lo modifique con el editor de código.
    '<System.Diagnostics.DebuggerStepThrough()> _
    'Private Sub InitializeComponent()
    '    Me.components = New System.ComponentModel.Container()
    '    Dim Cod_postalLabel As System.Windows.Forms.Label
    '    Dim PisoLabel1 As System.Windows.Forms.Label
    '    Me.BDGeografía = New Controles.BDGeografía()
    '    Me.TiposDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.TiposClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    '    Me.MunicipioTextBox = New System.Windows.Forms.TextBox()
    '    Me.Label9 = New System.Windows.Forms.Label()
    '    Me.Label8 = New System.Windows.Forms.Label()
    '    Me.Label7 = New System.Windows.Forms.Label()
    '    Me.Label6 = New System.Windows.Forms.Label()
    '    Me.ProvinciasComboBox = New System.Windows.Forms.ComboBox()
    '    Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.PaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.PaisesComboBox = New System.Windows.Forms.ComboBox()
    '    Me.NúmeroTextBox = New System.Windows.Forms.TextBox()
    '    Me.CodPostalTextBox = New System.Windows.Forms.TextBox()
    '    Me.PuertaTextBox = New System.Windows.Forms.TextBox()
    '    Me.Label4 = New System.Windows.Forms.Label()
    '    Me.Label5 = New System.Windows.Forms.Label()
    '    Me.Label3 = New System.Windows.Forms.Label()
    '    Me.Label2 = New System.Windows.Forms.Label()
    '    Me.Label1 = New System.Windows.Forms.Label()
    '    Me.BloqueTextBox = New System.Windows.Forms.TextBox()
    '    Me.EscaleraTextBox = New System.Windows.Forms.TextBox()
    '    Me.PisoTextBox = New System.Windows.Forms.TextBox()
    '    Me.CalleTextBox = New System.Windows.Forms.TextBox()
    '    Me.CallesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.MunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.CallesTableAdapter = New Controles.BDGeografíaTableAdapters.CallesTableAdapter()
    '    Me.TableAdapterManager = New Controles.BDGeografíaTableAdapters.TableAdapterManager()
    '    Me.MunicipiosTableAdapter = New Controles.BDGeografíaTableAdapters.MunicipiosTableAdapter()
    '    Me.PaisesTableAdapter = New Controles.BDGeografíaTableAdapters.PaisesTableAdapter()
    '    Me.ProvinciasTableAdapter = New Controles.BDGeografíaTableAdapters.ProvinciasTableAdapter()
    '    Cod_postalLabel = New System.Windows.Forms.Label()
    '    PisoLabel1 = New System.Windows.Forms.Label()
    '    CType(Me.BDGeografía, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.TiposDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.TiposClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.GroupBox1.SuspendLayout()
    '    CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.CallesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.SuspendLayout()
    '    '
    '    'Cod_postalLabel
    '    '
    '    Cod_postalLabel.AutoSize = True
    '    Cod_postalLabel.Location = New System.Drawing.Point(840, 81)
    '    Cod_postalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    '    Cod_postalLabel.Name = "Cod_postalLabel"
    '    Cod_postalLabel.Size = New System.Drawing.Size(77, 17)
    '    Cod_postalLabel.TabIndex = 38
    '    Cod_postalLabel.Text = "cod postal:"
    '    '
    '    'PisoLabel1
    '    '
    '    PisoLabel1.AutoSize = True
    '    PisoLabel1.Location = New System.Drawing.Point(815, 20)
    '    PisoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    '    PisoLabel1.Name = "PisoLabel1"
    '    PisoLabel1.Size = New System.Drawing.Size(35, 17)
    '    PisoLabel1.TabIndex = 39
    '    PisoLabel1.Text = "Piso"
    '    '
    '    'BDGeografía
    '    '
    '    Me.BDGeografía.DataSetName = "BDGeografía"
    '    Me.BDGeografía.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '    '
    '    'GroupBox1
    '    '
    '    Me.GroupBox1.Controls.Add(Me.MunicipioTextBox)
    '    Me.GroupBox1.Controls.Add(Me.Label9)
    '    Me.GroupBox1.Controls.Add(Me.Label8)
    '    Me.GroupBox1.Controls.Add(Me.Label7)
    '    Me.GroupBox1.Controls.Add(Me.Label6)
    '    Me.GroupBox1.Controls.Add(Me.ProvinciasComboBox)
    '    Me.GroupBox1.Controls.Add(Me.PaisesComboBox)
    '    Me.GroupBox1.Controls.Add(PisoLabel1)
    '    Me.GroupBox1.Controls.Add(Me.NúmeroTextBox)
    '    Me.GroupBox1.Controls.Add(Cod_postalLabel)
    '    Me.GroupBox1.Controls.Add(Me.CodPostalTextBox)
    '    Me.GroupBox1.Controls.Add(Me.PuertaTextBox)
    '    Me.GroupBox1.Controls.Add(Me.Label4)
    '    Me.GroupBox1.Controls.Add(Me.Label5)
    '    Me.GroupBox1.Controls.Add(Me.Label3)
    '    Me.GroupBox1.Controls.Add(Me.Label2)
    '    Me.GroupBox1.Controls.Add(Me.Label1)
    '    Me.GroupBox1.Controls.Add(Me.BloqueTextBox)
    '    Me.GroupBox1.Controls.Add(Me.EscaleraTextBox)
    '    Me.GroupBox1.Controls.Add(Me.PisoTextBox)
    '    Me.GroupBox1.Controls.Add(Me.CalleTextBox)
    '    Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
    '    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.GroupBox1.Name = "GroupBox1"
    '    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.GroupBox1.Size = New System.Drawing.Size(997, 155)
    '    Me.GroupBox1.TabIndex = 0
    '    Me.GroupBox1.TabStop = False
    '    Me.GroupBox1.Text = "Domicilio"
    '    '
    '    'MunicipioTextBox
    '    '
    '    Me.MunicipioTextBox.Location = New System.Drawing.Point(366, 100)
    '    Me.MunicipioTextBox.Margin = New System.Windows.Forms.Padding(4)
    '    Me.MunicipioTextBox.Name = "MunicipioTextBox"
    '    Me.MunicipioTextBox.Size = New System.Drawing.Size(464, 22)
    '    Me.MunicipioTextBox.TabIndex = 9
    '    '
    '    'Label9
    '    '
    '    Me.Label9.AutoSize = True
    '    Me.Label9.Location = New System.Drawing.Point(14, 20)
    '    Me.Label9.Name = "Label9"
    '    Me.Label9.Size = New System.Drawing.Size(39, 17)
    '    Me.Label9.TabIndex = 44
    '    Me.Label9.Text = "Calle"
    '    '
    '    'Label8
    '    '
    '    Me.Label8.AutoSize = True
    '    Me.Label8.Location = New System.Drawing.Point(179, 81)
    '    Me.Label8.Name = "Label8"
    '    Me.Label8.Size = New System.Drawing.Size(66, 17)
    '    Me.Label8.TabIndex = 43
    '    Me.Label8.Text = "Provincia"
    '    '
    '    'Label7
    '    '
    '    Me.Label7.AutoSize = True
    '    Me.Label7.Location = New System.Drawing.Point(363, 81)
    '    Me.Label7.Name = "Label7"
    '    Me.Label7.Size = New System.Drawing.Size(67, 17)
    '    Me.Label7.TabIndex = 42
    '    Me.Label7.Text = "Municipio"
    '    '
    '    'Label6
    '    '
    '    Me.Label6.AutoSize = True
    '    Me.Label6.Location = New System.Drawing.Point(13, 81)
    '    Me.Label6.Name = "Label6"
    '    Me.Label6.Size = New System.Drawing.Size(35, 17)
    '    Me.Label6.TabIndex = 41
    '    Me.Label6.Text = "Pais"
    '    '
    '    'ProvinciasComboBox
    '    '
    '    Me.ProvinciasComboBox.DataSource = Me.ProvinciasBindingSource
    '    Me.ProvinciasComboBox.DisplayMember = "nombre"
    '    Me.ProvinciasComboBox.FormattingEnabled = True
    '    Me.ProvinciasComboBox.Location = New System.Drawing.Point(182, 98)
    '    Me.ProvinciasComboBox.Name = "ProvinciasComboBox"
    '    Me.ProvinciasComboBox.Size = New System.Drawing.Size(171, 24)
    '    Me.ProvinciasComboBox.TabIndex = 8
    '    Me.ProvinciasComboBox.ValueMember = "id"
    '    '
    '    'ProvinciasBindingSource
    '    '
    '    Me.ProvinciasBindingSource.DataMember = "FK_Provincias_Paises"
    '    Me.ProvinciasBindingSource.DataSource = Me.PaisesBindingSource
    '    '
    '    'PaisesBindingSource
    '    '
    '    Me.PaisesBindingSource.DataMember = "Paises"
    '    Me.PaisesBindingSource.DataSource = Me.BDGeografía
    '    '
    '    'PaisesComboBox
    '    '
    '    Me.PaisesComboBox.DataSource = Me.PaisesBindingSource
    '    Me.PaisesComboBox.DisplayMember = "nombre"
    '    Me.PaisesComboBox.FormattingEnabled = True
    '    Me.PaisesComboBox.Location = New System.Drawing.Point(13, 98)
    '    Me.PaisesComboBox.Name = "PaisesComboBox"
    '    Me.PaisesComboBox.Size = New System.Drawing.Size(160, 24)
    '    Me.PaisesComboBox.TabIndex = 7
    '    Me.PaisesComboBox.ValueMember = "cod"
    '    '
    '    'NúmeroTextBox
    '    '
    '    Me.NúmeroTextBox.Location = New System.Drawing.Point(532, 39)
    '    Me.NúmeroTextBox.Margin = New System.Windows.Forms.Padding(4)
    '    Me.NúmeroTextBox.Name = "NúmeroTextBox"
    '    Me.NúmeroTextBox.Size = New System.Drawing.Size(91, 22)
    '    Me.NúmeroTextBox.TabIndex = 2
    '    '
    '    'CodPostalTextBox
    '    '
    '    Me.CodPostalTextBox.Location = New System.Drawing.Point(838, 100)
    '    Me.CodPostalTextBox.Margin = New System.Windows.Forms.Padding(4)
    '    Me.CodPostalTextBox.Name = "CodPostalTextBox"
    '    Me.CodPostalTextBox.Size = New System.Drawing.Size(132, 22)
    '    Me.CodPostalTextBox.TabIndex = 10
    '    '
    '    'PuertaTextBox
    '    '
    '    Me.PuertaTextBox.Location = New System.Drawing.Point(896, 39)
    '    Me.PuertaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.PuertaTextBox.Name = "PuertaTextBox"
    '    Me.PuertaTextBox.Size = New System.Drawing.Size(72, 22)
    '    Me.PuertaTextBox.TabIndex = 6
    '    '
    '    'Label4
    '    '
    '    Me.Label4.AutoSize = True
    '    Me.Label4.Location = New System.Drawing.Point(733, 20)
    '    Me.Label4.Name = "Label4"
    '    Me.Label4.Size = New System.Drawing.Size(63, 17)
    '    Me.Label4.TabIndex = 32
    '    Me.Label4.Text = "Escalera"
    '    '
    '    'Label5
    '    '
    '    Me.Label5.AutoSize = True
    '    Me.Label5.Location = New System.Drawing.Point(893, 20)
    '    Me.Label5.Name = "Label5"
    '    Me.Label5.Size = New System.Drawing.Size(50, 17)
    '    Me.Label5.TabIndex = 31
    '    Me.Label5.Text = "Puerta"
    '    '
    '    'Label3
    '    '
    '    Me.Label3.AutoSize = True
    '    Me.Label3.Location = New System.Drawing.Point(1089, 102)
    '    Me.Label3.Name = "Label3"
    '    Me.Label3.Size = New System.Drawing.Size(35, 17)
    '    Me.Label3.TabIndex = 30
    '    Me.Label3.Text = "Piso"
    '    '
    '    'Label2
    '    '
    '    Me.Label2.AutoSize = True
    '    Me.Label2.Location = New System.Drawing.Point(532, 20)
    '    Me.Label2.Name = "Label2"
    '    Me.Label2.Size = New System.Drawing.Size(58, 17)
    '    Me.Label2.TabIndex = 29
    '    Me.Label2.Text = "Número"
    '    '
    '    'Label1
    '    '
    '    Me.Label1.AutoSize = True
    '    Me.Label1.Location = New System.Drawing.Point(627, 20)
    '    Me.Label1.Name = "Label1"
    '    Me.Label1.Size = New System.Drawing.Size(52, 17)
    '    Me.Label1.TabIndex = 28
    '    Me.Label1.Text = "Bloque"
    '    '
    '    'BloqueTextBox
    '    '
    '    Me.BloqueTextBox.Location = New System.Drawing.Point(630, 39)
    '    Me.BloqueTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.BloqueTextBox.Name = "BloqueTextBox"
    '    Me.BloqueTextBox.Size = New System.Drawing.Size(100, 22)
    '    Me.BloqueTextBox.TabIndex = 3
    '    '
    '    'EscaleraTextBox
    '    '
    '    Me.EscaleraTextBox.Location = New System.Drawing.Point(736, 39)
    '    Me.EscaleraTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.EscaleraTextBox.Name = "EscaleraTextBox"
    '    Me.EscaleraTextBox.Size = New System.Drawing.Size(76, 22)
    '    Me.EscaleraTextBox.TabIndex = 4
    '    '
    '    'PisoTextBox
    '    '
    '    Me.PisoTextBox.Location = New System.Drawing.Point(818, 39)
    '    Me.PisoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.PisoTextBox.Name = "PisoTextBox"
    '    Me.PisoTextBox.Size = New System.Drawing.Size(72, 22)
    '    Me.PisoTextBox.TabIndex = 5
    '    '
    '    'CalleTextBox
    '    '
    '    Me.CalleTextBox.Location = New System.Drawing.Point(11, 39)
    '    Me.CalleTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.CalleTextBox.Name = "CalleTextBox"
    '    Me.CalleTextBox.Size = New System.Drawing.Size(512, 22)
    '    Me.CalleTextBox.TabIndex = 1
    '    '
    '    'CallesBindingSource1
    '    '
    '    Me.CallesBindingSource1.DataMember = "FK_Calles_Municipios"
    '    Me.CallesBindingSource1.DataSource = Me.MunicipiosBindingSource
    '    '
    '    'MunicipiosBindingSource
    '    '
    '    Me.MunicipiosBindingSource.DataMember = "FK_Municipios_Provincias"
    '    Me.MunicipiosBindingSource.DataSource = Me.ProvinciasBindingSource
    '    '
    '    'CallesBindingSource
    '    '
    '    Me.CallesBindingSource.DataMember = "Calles"
    '    Me.CallesBindingSource.DataSource = Me.BDGeografía
    '    '
    '    'CallesTableAdapter
    '    '
    '    Me.CallesTableAdapter.ClearBeforeFill = True
    '    '
    '    'TableAdapterManager
    '    '
    '    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    '    Me.TableAdapterManager.CallesTableAdapter = Me.CallesTableAdapter
    '    Me.TableAdapterManager.MunicipiosTableAdapter = Me.MunicipiosTableAdapter
    '    Me.TableAdapterManager.PaisesTableAdapter = Me.PaisesTableAdapter
    '    Me.TableAdapterManager.ProvinciasTableAdapter = Me.ProvinciasTableAdapter
    '    Me.TableAdapterManager.UpdateOrder = Controles.BDGeografíaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '    '
    '    'MunicipiosTableAdapter
    '    '
    '    Me.MunicipiosTableAdapter.ClearBeforeFill = True
    '    '
    '    'PaisesTableAdapter
    '    '
    '    Me.PaisesTableAdapter.ClearBeforeFill = True
    '    '
    '    'ProvinciasTableAdapter
    '    '
    '    Me.ProvinciasTableAdapter.ClearBeforeFill = True
    '    '
    '    'ctlDomicilio
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.Controls.Add(Me.GroupBox1)
    '    Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    '    Me.Name = "ctlDomicilio"
    '    Me.Size = New System.Drawing.Size(1000, 341)
    '    CType(Me.BDGeografía, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.TiposDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.TiposClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.GroupBox1.ResumeLayout(False)
    '    Me.GroupBox1.PerformLayout()
    '    CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.CallesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)

    'End Sub
    'Friend WithEvents BDGeografía As Controles.BDGeografía
    'Friend WithEvents TiposDocumentoBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents TiposClienteBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    'Friend WithEvents PuertaTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents Label4 As System.Windows.Forms.Label
    'Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents BloqueTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents EscaleraTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents PisoTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents CalleTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents NúmeroTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents CodPostalTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents CallesBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents CallesTableAdapter As Controles.BDGeografíaTableAdapters.CallesTableAdapter
    'Friend WithEvents TableAdapterManager As Controles.BDGeografíaTableAdapters.TableAdapterManager
    'Friend WithEvents CallesBindingSource1 As System.Windows.Forms.BindingSource
    'Friend WithEvents MunicipiosBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents PaisesBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents ProvinciasComboBox As System.Windows.Forms.ComboBox
    'Friend WithEvents PaisesComboBox As System.Windows.Forms.ComboBox
    'Friend WithEvents MunicipiosTableAdapter As Controles.BDGeografíaTableAdapters.MunicipiosTableAdapter
    'Friend WithEvents PaisesTableAdapter As Controles.BDGeografíaTableAdapters.PaisesTableAdapter
    'Friend WithEvents ProvinciasTableAdapter As Controles.BDGeografíaTableAdapters.ProvinciasTableAdapter
    'Friend WithEvents Label6 As System.Windows.Forms.Label
    'Friend WithEvents Label8 As System.Windows.Forms.Label
    'Friend WithEvents Label7 As System.Windows.Forms.Label
    'Friend WithEvents Label9 As System.Windows.Forms.Label
    'Friend WithEvents MunicipioTextBox As System.Windows.Forms.TextBox

End Class
