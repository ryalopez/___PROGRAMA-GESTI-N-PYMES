<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuestrosClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPGC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGeografía = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuINE = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCNAE = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCNO11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCNO94 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnuBancos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.mnuNuestrosClientes, Me.mnuBancos, Me.mnuGeografía, Me.mnuINE, Me.mnuPGC, Me.mnuAcercaDe})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(1685, 28)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'mnuSalir
        '
        Me.mnuSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(28, 24)
        Me.mnuSalir.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.mnuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'mnuNuestrosClientes
        '
        Me.mnuNuestrosClientes.Name = "mnuNuestrosClientes"
        Me.mnuNuestrosClientes.Size = New System.Drawing.Size(161, 24)
        Me.mnuNuestrosClientes.Text = "NUESTROS CLIENTES"
        '
        'mnuPGC
        '
        Me.mnuPGC.Name = "mnuPGC"
        Me.mnuPGC.Size = New System.Drawing.Size(84, 24)
        Me.mnuPGC.Text = "PGC 2008"
        '
        'mnuGeografía
        '
        Me.mnuGeografía.Name = "mnuGeografía"
        Me.mnuGeografía.Size = New System.Drawing.Size(100, 24)
        Me.mnuGeografía.Text = "GEOGRAFÍA"
        '
        'mnuINE
        '
        Me.mnuINE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCNAE, Me.mnuCNO11, Me.mnuCNO94})
        Me.mnuINE.Name = "mnuINE"
        Me.mnuINE.Size = New System.Drawing.Size(44, 24)
        Me.mnuINE.Text = "INE"
        '
        'mnuCNAE
        '
        Me.mnuCNAE.Name = "mnuCNAE"
        Me.mnuCNAE.Size = New System.Drawing.Size(129, 24)
        Me.mnuCNAE.Text = "CNAE"
        '
        'mnuCNO11
        '
        Me.mnuCNO11.Name = "mnuCNO11"
        Me.mnuCNO11.Size = New System.Drawing.Size(129, 24)
        Me.mnuCNO11.Text = "CNO 11"
        '
        'mnuCNO94
        '
        Me.mnuCNO94.Name = "mnuCNO94"
        Me.mnuCNO94.Size = New System.Drawing.Size(129, 24)
        Me.mnuCNO94.Text = "CNO 94"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(87, 24)
        Me.mnuAcercaDe.Text = "Acerca de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1023)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1685, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mnuBancos
        '
        Me.mnuBancos.Name = "mnuBancos"
        Me.mnuBancos.Size = New System.Drawing.Size(79, 24)
        Me.mnuBancos.Text = "BANCOS"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 1045)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuINE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGeografía As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPGC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuCNAE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCNO11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCNO94 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNuestrosClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBancos As System.Windows.Forms.ToolStripMenuItem
End Class
