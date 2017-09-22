'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'Partial Class frmEligeCliente
'    Inherits System.Windows.Forms.Form

'    'Form reemplaza a Dispose para limpiar la lista de componentes.
'    <System.Diagnostics.DebuggerNonUserCode()> _
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Requerido por el Diseñador de Windows Forms
'    Private components As System.ComponentModel.IContainer

'    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
'    'Se puede modificar usando el Diseñador de Windows Forms.  
'    'No lo modifique con el editor de código.
'    <System.Diagnostics.DebuggerStepThrough()> _
'    Private Sub InitializeComponent()
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEligeCliente))
'        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
'        Me.OK_Button = New System.Windows.Forms.Button()
'        Me.Cancel_Button = New System.Windows.Forms.Button()
'        Me.ClientesComboBox = New System.Windows.Forms.ComboBox()
'        Me.BDEmpresaDataSet = New CBiblioteca.BDEmpresaDataSet()
'        Me.ClientesTableAdapter = New CBiblioteca.BDEmpresaDataSetTableAdapters.ClientesTableAdapter()
'        Me.TableLayoutPanel1.SuspendLayout()
'        CType(Me.BDEmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'TableLayoutPanel1
'        '
'        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.TableLayoutPanel1.ColumnCount = 2
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
'        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
'        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
'        Me.TableLayoutPanel1.Location = New System.Drawing.Point(227, 274)
'        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
'        Me.TableLayoutPanel1.RowCount = 1
'        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
'        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
'        Me.TableLayoutPanel1.TabIndex = 0
'        '
'        'OK_Button
'        '
'        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
'        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
'        Me.OK_Button.Name = "OK_Button"
'        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
'        Me.OK_Button.TabIndex = 0
'        Me.OK_Button.Text = "Aceptar"
'        '
'        'Cancel_Button
'        '
'        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
'        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
'        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
'        Me.Cancel_Button.Name = "Cancel_Button"
'        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
'        Me.Cancel_Button.TabIndex = 1
'        Me.Cancel_Button.Text = "Cancelar"
'        '
'        'ClientesComboBox
'        '
'        Me.ClientesComboBox.DataSource = Me.BDEmpresaDataSet
'        Me.ClientesComboBox.DisplayMember = "Clientes.NOMBRE/RAZÓN_SOCIAL"
'        Me.ClientesComboBox.FormattingEnabled = True
'        Me.ClientesComboBox.Location = New System.Drawing.Point(30, 54)
'        Me.ClientesComboBox.Margin = New System.Windows.Forms.Padding(2)
'        Me.ClientesComboBox.Name = "ClientesComboBox"
'        Me.ClientesComboBox.Size = New System.Drawing.Size(343, 21)
'        Me.ClientesComboBox.TabIndex = 1
'        Me.ClientesComboBox.ValueMember = "Clientes.id"
'        '
'        'BDEmpresaDataSet
'        '
'        Me.BDEmpresaDataSet.DataSetName = "BDEmpresaDataSet"
'        Me.BDEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'ClientesTableAdapter
'        '
'        Me.ClientesTableAdapter.ClearBeforeFill = True
'        '
'        'frmEligeCliente
'        '
'        Me.AcceptButton = Me.OK_Button
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.CancelButton = Me.Cancel_Button
'        Me.ClientSize = New System.Drawing.Size(401, 315)
'        Me.Controls.Add(Me.ClientesComboBox)
'        Me.Controls.Add(Me.TableLayoutPanel1)
'        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
'        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
'        Me.MaximizeBox = False
'        Me.MinimizeBox = False
'        Me.Name = "frmEligeCliente"
'        Me.ShowInTaskbar = False
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "Elegir Cliente y Programa"
'        Me.TableLayoutPanel1.ResumeLayout(False)
'        CType(Me.BDEmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)

'    End Sub
'    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
'    Friend WithEvents OK_Button As System.Windows.Forms.Button
'    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
'    Friend WithEvents ClientesComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents BDEmpresaDataSet As CBiblioteca.BDEmpresaDataSet
'    Friend WithEvents ClientesTableAdapter As CBiblioteca.BDEmpresaDataSetTableAdapters.ClientesTableAdapter

'End Class
