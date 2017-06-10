<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaCuenta
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
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaCuenta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Nombre_Razón_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.DescripciónTextBox = New System.Windows.Forms.TextBox()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.TiposDocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.PrefijosCuentaComboBox = New System.Windows.Forms.ComboBox()
        CódigoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(12, 25)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(81, 13)
        CódigoLabel.TabIndex = 2
        CódigoLabel.Text = "Código Cuenta*"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(15, 127)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 5
        Label1.Text = "Prefijo cuenta**"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Red
        Label2.Location = New System.Drawing.Point(16, 179)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(86, 17)
        Label2.TabIndex = 6
        Label2.Text = "*sólo lectura"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 77)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 13)
        Label3.TabIndex = 8
        Label3.Text = "Nombre o razón social**"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(521, 77)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(92, 13)
        Label4.TabIndex = 10
        Label4.Text = "Tipo documento**"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(124, 25)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(112, 13)
        Label5.TabIndex = 13
        Label5.Text = "Descripción Cuenta***"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(652, 77)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(105, 13)
        Label7.TabIndex = 16
        Label7.Text = "Númerodocumento**"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(611, 167)
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
        'Nombre_Razón_SocialTextBox
        '
        Me.Nombre_Razón_SocialTextBox.Location = New System.Drawing.Point(15, 93)
        Me.Nombre_Razón_SocialTextBox.Name = "Nombre_Razón_SocialTextBox"
        Me.Nombre_Razón_SocialTextBox.Size = New System.Drawing.Size(491, 20)
        Me.Nombre_Razón_SocialTextBox.TabIndex = 11
        '
        'DescripciónTextBox
        '
        Me.DescripciónTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripciónTextBox.Location = New System.Drawing.Point(127, 41)
        Me.DescripciónTextBox.Name = "DescripciónTextBox"
        Me.DescripciónTextBox.Size = New System.Drawing.Size(630, 20)
        Me.DescripciónTextBox.TabIndex = 12
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CódigoTextBox.Location = New System.Drawing.Point(15, 41)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CódigoTextBox.TabIndex = 18
        '
        'ValorDocumentoTextBox
        '
        Me.ValorDocumentoTextBox.Location = New System.Drawing.Point(657, 94)
        Me.ValorDocumentoTextBox.Name = "ValorDocumentoTextBox"
        Me.ValorDocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorDocumentoTextBox.TabIndex = 22
        '
        'TiposDocumentoComboBox
        '
        Me.TiposDocumentoComboBox.DisplayMember = "Índice"
        Me.TiposDocumentoComboBox.FormattingEnabled = True
        Me.TiposDocumentoComboBox.Location = New System.Drawing.Point(528, 93)
        Me.TiposDocumentoComboBox.Name = "TiposDocumentoComboBox"
        Me.TiposDocumentoComboBox.Size = New System.Drawing.Size(104, 21)
        Me.TiposDocumentoComboBox.TabIndex = 22
        Me.TiposDocumentoComboBox.ValueMember = "Índice"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Red
        Label6.Location = New System.Drawing.Point(125, 179)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(71, 17)
        Label6.TabIndex = 14
        Label6.Text = "**opcional"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Red
        Label8.Location = New System.Drawing.Point(234, 179)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(211, 17)
        Label8.TabIndex = 23
        Label8.Text = "***complete como crea oportuno"
        '
        'PrefijosCuentaComboBox
        '
        Me.PrefijosCuentaComboBox.DisplayMember = "Índice"
        Me.PrefijosCuentaComboBox.FormattingEnabled = True
        Me.PrefijosCuentaComboBox.Location = New System.Drawing.Point(18, 143)
        Me.PrefijosCuentaComboBox.Name = "PrefijosCuentaComboBox"
        Me.PrefijosCuentaComboBox.Size = New System.Drawing.Size(187, 21)
        Me.PrefijosCuentaComboBox.TabIndex = 24
        Me.PrefijosCuentaComboBox.ValueMember = "Índice"
        '
        'frmNuevaCuenta
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(792, 207)
        Me.Controls.Add(Me.PrefijosCuentaComboBox)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.TiposDocumentoComboBox)
        Me.Controls.Add(Me.ValorDocumentoTextBox)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.DescripciónTextBox)
        Me.Controls.Add(Me.Nombre_Razón_SocialTextBox)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaCuenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevaCuenta"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Nombre_Razón_SocialTextBox As TextBox
    Friend WithEvents DescripciónTextBox As TextBox
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents ValorDocumentoTextBox As TextBox
    Friend WithEvents TiposDocumentoComboBox As ComboBox
    Friend WithEvents PrefijosCuentaComboBox As ComboBox
End Class
