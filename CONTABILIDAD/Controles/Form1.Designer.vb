<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BDGeografía = New Controles.BDGeografía()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CallesTableAdapter = New Controles.BDGeografíaTableAdapters.CallesTableAdapter()
        Me.TableAdapterManager = New Controles.BDGeografíaTableAdapters.TableAdapterManager()
        Me.MunicipiosTableAdapter = New Controles.BDGeografíaTableAdapters.MunicipiosTableAdapter()
        Me.PaisesTableAdapter = New Controles.BDGeografíaTableAdapters.PaisesTableAdapter()
        Me.ProvinciasTableAdapter = New Controles.BDGeografíaTableAdapters.ProvinciasTableAdapter()
        Me.CallesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CallesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CtlDatosBancarios1 = New Controles.ctlDatosBancarios()
        CType(Me.BDGeografía, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CallesBindingNavigator.SuspendLayout()
        CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BDGeografía
        '
        Me.BDGeografía.DataSetName = "BDGeografía"
        Me.BDGeografía.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.BDGeografía
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CallesTableAdapter = Me.CallesTableAdapter
        Me.TableAdapterManager.MunicipiosTableAdapter = Me.MunicipiosTableAdapter
        Me.TableAdapterManager.PaisesTableAdapter = Me.PaisesTableAdapter
        Me.TableAdapterManager.ProvinciasTableAdapter = Me.ProvinciasTableAdapter
        Me.TableAdapterManager.UpdateOrder = Controles.BDGeografíaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MunicipiosTableAdapter
        '
        Me.MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'PaisesTableAdapter
        '
        Me.PaisesTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'CallesBindingNavigator
        '
        Me.CallesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CallesBindingNavigator.BindingSource = Me.CallesBindingSource
        Me.CallesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CallesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CallesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CallesBindingNavigatorSaveItem})
        Me.CallesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CallesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CallesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CallesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CallesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CallesBindingNavigator.Name = "CallesBindingNavigator"
        Me.CallesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CallesBindingNavigator.Size = New System.Drawing.Size(1254, 27)
        Me.CallesBindingNavigator.TabIndex = 1
        Me.CallesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CallesBindingNavigatorSaveItem
        '
        Me.CallesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CallesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CallesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CallesBindingNavigatorSaveItem.Name = "CallesBindingNavigatorSaveItem"
        Me.CallesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.CallesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MunicipiosBindingSource
        '
        Me.MunicipiosBindingSource.DataMember = "Municipios"
        Me.MunicipiosBindingSource.DataSource = Me.BDGeografía
        '
        'PaisesBindingSource
        '
        Me.PaisesBindingSource.DataMember = "Paises"
        Me.PaisesBindingSource.DataSource = Me.BDGeografía
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.BDGeografía
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 123)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CtlDatosBancarios1
        '
        Me.CtlDatosBancarios1.Location = New System.Drawing.Point(38, 64)
        Me.CtlDatosBancarios1.Name = "CtlDatosBancarios1"
        Me.CtlDatosBancarios1.Size = New System.Drawing.Size(816, 399)
        Me.CtlDatosBancarios1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 412)
        Me.Controls.Add(Me.CtlDatosBancarios1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CallesBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BDGeografía, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CallesBindingNavigator.ResumeLayout(False)
        Me.CallesBindingNavigator.PerformLayout()
        CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BDGeografía As Controles.BDGeografía
    Friend WithEvents CallesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CallesTableAdapter As Controles.BDGeografíaTableAdapters.CallesTableAdapter
    Friend WithEvents TableAdapterManager As Controles.BDGeografíaTableAdapters.TableAdapterManager
    Friend WithEvents CallesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CallesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MunicipiosTableAdapter As Controles.BDGeografíaTableAdapters.MunicipiosTableAdapter
    Friend WithEvents MunicipiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaisesTableAdapter As Controles.BDGeografíaTableAdapters.PaisesTableAdapter
    Friend WithEvents PaisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Controles.BDGeografíaTableAdapters.ProvinciasTableAdapter
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IndiceBindingSource As System.Windows.Forms.BindingSource    
    Friend WithEvents CtlDatosBancarios1 As Controles.ctlDatosBancarios
End Class
