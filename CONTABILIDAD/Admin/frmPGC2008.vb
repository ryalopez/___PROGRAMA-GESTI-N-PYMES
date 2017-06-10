Public Class frmPGC2008

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BDPGC2008DataSet = New Admin.BDPGC2008DataSet()
        Me.Cta3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cta3TableAdapter = New Admin.BDPGC2008DataSetTableAdapters.Cta3TableAdapter()
        Me.TableAdapterManager = New Admin.BDPGC2008DataSetTableAdapters.TableAdapterManager()
        Me.Cta3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BDPGC2008DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cta3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cta3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cta3DataGridView, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(814, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BDPGC2008DataSet
        '
        Me.BDPGC2008DataSet.DataSetName = "BDPGC2008DataSet"
        Me.BDPGC2008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cta3BindingSource
        '
        Me.Cta3BindingSource.DataMember = "Cta3"
        Me.Cta3BindingSource.DataSource = Me.BDPGC2008DataSet
        '
        'Cta3TableAdapter
        '
        Me.Cta3TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cta1TableAdapter = Nothing
        Me.TableAdapterManager.Cta2TableAdapter = Nothing
        Me.TableAdapterManager.Cta3TableAdapter = Me.Cta3TableAdapter
        Me.TableAdapterManager.Exc1TableAdapter = Nothing
        Me.TableAdapterManager.Exc2TableAdapter = Nothing
        Me.TableAdapterManager.Exc3TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Admin.BDPGC2008DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cta3DataGridView
        '
        Me.Cta3DataGridView.AutoGenerateColumns = False
        Me.Cta3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cta3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Cta3DataGridView.DataSource = Me.Cta3BindingSource
        Me.Cta3DataGridView.Location = New System.Drawing.Point(3, 237)
        Me.Cta3DataGridView.Name = "Cta3DataGridView"
        Me.Cta3DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Cta3DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_cta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_cta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_cta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom_cta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cod_padre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cod_padre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmPGC2008
        '
        Me.ClientSize = New System.Drawing.Size(814, 483)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmPGC2008"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BDPGC2008DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cta3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cta3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

        Friend WithEvents TableAdapterManager As Admin.BDPGC2008DataSetTableAdapters.TableAdapterManager
        Friend WithEvents Cta3TableAdapter As Admin.BDPGC2008DataSetTableAdapters.Cta3TableAdapter
        Friend WithEvents Cta3DataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private components As System.ComponentModel.IContainer
        Friend WithEvents Cta3BindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents BDPGC2008DataSet As Admin.BDPGC2008DataSet
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

    End Sub


    Private Sub frmPGC2008_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDPGC2008DataSet.Cta3' Puede moverla o quitarla según sea necesario.
        Me.Cta3TableAdapter.Fill(Me.BDPGC2008DataSet.Cta3)

        'TODO: esta línea de código carga datos en la tabla 'BDPGC2008.Exc3' Puede moverla o quitarla según sea necesario.
        Me.Exc3.Fill(Me.BDPGC2008DataSet.Exc3)

        'TODO: esta línea de código carga datos en la tabla 'BDPGC2008.Cta1' Puede moverla o quitarla según sea necesario.
        Dim reg As BDPGC2008DataSet.Exc3Row = Me.BDPGC2008DataSet.Exc3.Rows(0)
        Dim patrón As String = reg.cod_cta
        With Me.BDPGC2008DataSet.Cta3

            .AddCta3Row(reg.cod_cta, reg.nom_cta, "P")

        End With
        MsgBox("Nuevo registro " + reg.cod_cta)

        For Each reg In Me.BDPGC2008DataSet.Exc3

            If patrón <> reg.cod_cta Then

                With Me.BDPGC2008DataSet.Cta3

                    .AddCta3Row(reg.cod_cta, reg.nom_cta, "P")

                End With
                'MsgBox("Nuevo registro " + reg.cod_cta)
                patrón = reg.cod_cta


            End If

        Next

        Me.Cta3TableAdapter.Update(Me.BDPGC2008DataSet)

    End Sub



End Class