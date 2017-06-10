<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilidad))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAsientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnalítica = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.mnuAsientos, Me.mnuCuentas, Me.mnuAnalítica, Me.mnuAcercaDe})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(1077, 28)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'mnuSalir
        '
        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuSalir.Image = Global.Contabilidad.My.Resources.Resources.HomeHS
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(32, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'mnuAsientos
        '
        Me.mnuAsientos.Name = "mnuAsientos"
        Me.mnuAsientos.Size = New System.Drawing.Size(123, 24)
        Me.mnuAsientos.Text = "Entrada de Asientos"
        '
        'mnuCuentas
        '
        Me.mnuCuentas.Name = "mnuCuentas"
        Me.mnuCuentas.Size = New System.Drawing.Size(62, 24)
        Me.mnuCuentas.Text = "Cuentas"
        '
        'mnuAnalítica
        '
        Me.mnuAnalítica.Name = "mnuAnalítica"
        Me.mnuAnalítica.Size = New System.Drawing.Size(65, 24)
        Me.mnuAnalítica.Text = "Analítica"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(71, 24)
        Me.mnuAcercaDe.Text = "&Acerca de"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 709)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmContabilidad"
        Me.Text = "Inversiones Madrileñas en Bienes Inmuebles Urbanos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAsientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAnalítica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
