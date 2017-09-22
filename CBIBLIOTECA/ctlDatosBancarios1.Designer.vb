<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDatosBancarios1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.IBAN = New System.Windows.Forms.TextBox()
        Me.btnValidarDDBB = New System.Windows.Forms.Button()
        Me.Cuenta = New System.Windows.Forms.TextBox()
        Me.DC = New System.Windows.Forms.TextBox()
        Me.Sucursal = New System.Windows.Forms.TextBox()
        Me.Banco = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'IBAN
        '
        Me.IBAN.Location = New System.Drawing.Point(23, 19)
        Me.IBAN.MaxLength = 4
        Me.IBAN.Name = "IBAN"
        Me.IBAN.ReadOnly = True
        Me.IBAN.Size = New System.Drawing.Size(72, 22)
        Me.IBAN.TabIndex = 12
        '
        'btnValidarDDBB
        '
        Me.btnValidarDDBB.Location = New System.Drawing.Point(561, 19)
        Me.btnValidarDDBB.Name = "btnValidarDDBB"
        Me.btnValidarDDBB.Size = New System.Drawing.Size(75, 23)
        Me.btnValidarDDBB.TabIndex = 3
        Me.btnValidarDDBB.Text = "Validar"
        Me.btnValidarDDBB.UseVisualStyleBackColor = True
        '
        'Cuenta
        '
        Me.Cuenta.Location = New System.Drawing.Point(355, 19)
        Me.Cuenta.MaxLength = 10
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(180, 22)
        Me.Cuenta.TabIndex = 2
        '
        'DC
        '
        Me.DC.Location = New System.Drawing.Point(296, 19)
        Me.DC.MaxLength = 2
        Me.DC.Name = "DC"
        Me.DC.ReadOnly = True
        Me.DC.Size = New System.Drawing.Size(38, 22)
        Me.DC.TabIndex = 9
        '
        'Sucursal
        '
        Me.Sucursal.Location = New System.Drawing.Point(207, 19)
        Me.Sucursal.MaxLength = 4
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.Size = New System.Drawing.Size(72, 22)
        Me.Sucursal.TabIndex = 1
        '
        'Banco
        '
        Me.Banco.Location = New System.Drawing.Point(115, 19)
        Me.Banco.MaxLength = 4
        Me.Banco.Name = "Banco"
        Me.Banco.Size = New System.Drawing.Size(72, 22)
        Me.Banco.TabIndex = 0
        '
        'ctlDatosBancarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IBAN)
        Me.Controls.Add(Me.btnValidarDDBB)
        Me.Controls.Add(Me.Cuenta)
        Me.Controls.Add(Me.DC)
        Me.Controls.Add(Me.Sucursal)
        Me.Controls.Add(Me.Banco)
        Me.Name = "ctlDatosBancarios"
        Me.Size = New System.Drawing.Size(816, 61)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IBAN As System.Windows.Forms.TextBox
    Friend WithEvents btnValidarDDBB As System.Windows.Forms.Button
    Friend WithEvents Cuenta As System.Windows.Forms.TextBox
    Friend WithEvents DC As System.Windows.Forms.TextBox
    Friend WithEvents Sucursal As System.Windows.Forms.TextBox
    Friend WithEvents Banco As System.Windows.Forms.TextBox

End Class
