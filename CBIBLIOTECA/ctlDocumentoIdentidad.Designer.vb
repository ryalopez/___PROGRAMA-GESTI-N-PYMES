<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctlDocumentoIdentidad
    Inherits System.Windows.Forms.UserControl

    ''UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()>
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
    '<System.Diagnostics.DebuggerStepThrough()>
    'Private Sub InitializeComponent()
    '    Me.components = New System.ComponentModel.Container()
    '    Dim TipoDocumentoIdentidadLabel As System.Windows.Forms.Label
    '    Me.TiposDocumentoIdentidadComboBox = New System.Windows.Forms.ComboBox()
    '    Me.TiposDocumentoIdentidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.BDContabilidadDataSet = New Controles.BDContabilidadDataSet()
    '    Me.TiposDocumentoIdentidadTableAdapter = New Controles.BDContabilidadDataSetTableAdapters.TiposDocumentoIdentidadTableAdapter()
    '    Me.TableAdapterManager = New Controles.BDContabilidadDataSetTableAdapters.TableAdapterManager()
    '    Me.DocumentoIdentidadTextBox = New System.Windows.Forms.TextBox()
    '    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    '    TipoDocumentoIdentidadLabel = New System.Windows.Forms.Label()
    '    CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.BDContabilidadDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.SuspendLayout()
    '    '
    '    'TipoDocumentoIdentidadLabel
    '    '
    '    TipoDocumentoIdentidadLabel.AutoSize = True
    '    TipoDocumentoIdentidadLabel.Location = New System.Drawing.Point(4, 8)
    '    TipoDocumentoIdentidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    '    TipoDocumentoIdentidadLabel.Name = "TipoDocumentoIdentidadLabel"
    '    TipoDocumentoIdentidadLabel.Size = New System.Drawing.Size(146, 17)
    '    TipoDocumentoIdentidadLabel.TabIndex = 15
    '    TipoDocumentoIdentidadLabel.Text = "Documento Identidad:"
    '    '
    '    'TiposDocumentoIdentidadComboBox
    '    '
    '    Me.TiposDocumentoIdentidadComboBox.DataSource = Me.TiposDocumentoIdentidadBindingSource
    '    Me.TiposDocumentoIdentidadComboBox.DisplayMember = "Tipo"
    '    Me.TiposDocumentoIdentidadComboBox.FormattingEnabled = True
    '    Me.TiposDocumentoIdentidadComboBox.Location = New System.Drawing.Point(157, 5)
    '    Me.TiposDocumentoIdentidadComboBox.Name = "TiposDocumentoIdentidadComboBox"
    '    Me.TiposDocumentoIdentidadComboBox.Size = New System.Drawing.Size(122, 24)
    '    Me.TiposDocumentoIdentidadComboBox.TabIndex = 2
    '    Me.TiposDocumentoIdentidadComboBox.ValueMember = "id"
    '    '
    '    'TiposDocumentoIdentidadBindingSource
    '    '
    '    Me.TiposDocumentoIdentidadBindingSource.DataMember = "TiposDocumentoIdentidad"
    '    Me.TiposDocumentoIdentidadBindingSource.DataSource = Me.BDContabilidadDataSet
    '    '
    '    'BDContabilidadDataSet
    '    '
    '    Me.BDContabilidadDataSet.DataSetName = "BDContabilidadDataSet"
    '    Me.BDContabilidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '    '
    '    'TiposDocumentoIdentidadTableAdapter
    '    '
    '    Me.TiposDocumentoIdentidadTableAdapter.ClearBeforeFill = True
    '    '
    '    'TableAdapterManager
    '    '
    '    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    '    Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Me.TiposDocumentoIdentidadTableAdapter
    '    Me.TableAdapterManager.UpdateOrder = BDContabilidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '    '
    '    'DocumentoIdentidadTextBox
    '    '
    '    Me.DocumentoIdentidadTextBox.Location = New System.Drawing.Point(298, 5)
    '    Me.DocumentoIdentidadTextBox.Name = "DocumentoIdentidadTextBox"
    '    Me.DocumentoIdentidadTextBox.Size = New System.Drawing.Size(195, 22)
    '    Me.DocumentoIdentidadTextBox.TabIndex = 3
    '    '
    '    'ErrorProvider1
    '    '
    '    Me.ErrorProvider1.ContainerControl = Me
    '    '
    '    'ctlDocumentoIdentidad
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.Controls.Add(TipoDocumentoIdentidadLabel)
    '    Me.Controls.Add(Me.DocumentoIdentidadTextBox)
    '    Me.Controls.Add(Me.TiposDocumentoIdentidadComboBox)
    '    Me.Name = "ctlDocumentoIdentidad"
    '    Me.Size = New System.Drawing.Size(529, 34)
    '    CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.BDContabilidadDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub
    'Friend WithEvents BDContabilidadDataSet As BDContabilidadDataSet
    'Friend WithEvents TiposDocumentoIdentidadTableAdapter As BDContabilidadDataSetTableAdapters.TiposDocumentoIdentidadTableAdapter
    'Friend WithEvents TableAdapterManager As BDContabilidadDataSetTableAdapters.TableAdapterManager
    'Friend WithEvents TiposDocumentoIdentidadComboBox As ComboBox
    'Friend WithEvents DocumentoIdentidadTextBox As TextBox
    'Friend WithEvents ErrorProvider1 As ErrorProvider
    'Friend WithEvents TiposDocumentoIdentidadBindingSource As BindingSource
End Class
