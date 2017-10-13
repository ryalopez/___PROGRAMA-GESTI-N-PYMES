<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisorInformes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Listado = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.miDataset = New Contabilidad.BDContabilidadGMELO()
        CType(Me.miDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Listado
        '
        Me.Listado.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cuentas"
        ReportDataSource1.Value = Nothing
        Me.Listado.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Listado.LocalReport.ReportEmbeddedResource = "Contabilidad.Balance de Sumas y Saldos.rdlc"
        Me.Listado.Location = New System.Drawing.Point(0, 0)
        Me.Listado.Name = "Listado"
        Me.Listado.ServerReport.BearerToken = Nothing
        Me.Listado.Size = New System.Drawing.Size(649, 253)
        Me.Listado.TabIndex = 0
        '
        'miDataset
        '
        Me.miDataset.DataSetName = "BDContabilidadGMELO"
        Me.miDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmVisorInformes
        '
        Me.ClientSize = New System.Drawing.Size(649, 253)
        Me.Controls.Add(Me.Listado)
        Me.Name = "FrmVisorInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.miDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Listado As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents miDataset As BDContabilidadGMELO
End Class
