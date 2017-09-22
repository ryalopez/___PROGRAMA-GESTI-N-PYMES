<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvenios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpresas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.mnuConvenios, Me.mnuEmpresas, Me.mnuEmpleados, Me.mnuAcercaDe})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(1436, 28)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'mnuSalir
        '
        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(32, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'mnuConvenios
        '
        Me.mnuConvenios.Name = "mnuConvenios"
        Me.mnuConvenios.Size = New System.Drawing.Size(89, 24)
        Me.mnuConvenios.Text = "Convenios"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(95, 24)
        Me.mnuEmpleados.Text = "Empleados"
        Me.mnuEmpleados.ToolTipText = "Gestión de Empleados de la Empresa"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(87, 24)
        Me.mnuAcercaDe.Text = "&Acerca de"
        '
        'mnuEmpresas
        '
        Me.mnuEmpresas.Name = "mnuEmpresas"
        Me.mnuEmpresas.Size = New System.Drawing.Size(84, 24)
        Me.mnuEmpresas.Text = "Empresas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 873)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPrincipal"
        Me.Text = "Inversiones Madrileñas en Bienes Inmuebles Urbanos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuConvenios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpresas As System.Windows.Forms.ToolStripMenuItem
End Class
