<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresas
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
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CCCLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim CódigoLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.mnuSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpresasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CCCTextBox = New System.Windows.Forms.TextBox()
        Me.CentrosTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CentrosTrabajoTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CentrosTrabajoTableAdapter()
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConveniosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.ConveniosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CentrosEmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.NominasDeEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasDeEmpresaTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.NominasDeEmpresaTableAdapter()
        Me.NominasDeEmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoNóminaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TiposNóminaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NóminasEmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TiposNóminaTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.TiposNóminaTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DatosEmpresaGroupBox = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CentrosTabPage = New System.Windows.Forms.TabPage()
        Me.EmpleadosTabPage = New System.Windows.Forms.TabPage()
        Me.NóminasTabPage = New System.Windows.Forms.TabPage()
        Me.CódigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmpleadosCentroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BajaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HorasSemanalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomyApeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiTipoVíaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiNombreVíaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiLocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiCodPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiNúmeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiBloqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiEscaleraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiPisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomiPuertaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboConvenioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCentroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCategoríaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboFechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboFechaBajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCausaBajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCNAEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCNO94DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboCNO11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboTipoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboRelLaboralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboAntigüedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSocNúmeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSocGrupoCotizaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSocOcupaciónATEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CobraPorBancoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BancoSicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoEntidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKCentrosTrabajoEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CódigoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CCCLabel = New System.Windows.Forms.Label()
        CódigoLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasBindingNavigator.SuspendLayout()
        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CentrosEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CentrosEmpresaBindingNavigator.SuspendLayout()
        CType(Me.NominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDeEmpresaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposNóminaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NóminasEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NóminasEmpresaBindingNavigator.SuspendLayout()
        Me.DatosEmpresaGroupBox.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.CentrosTabPage.SuspendLayout()
        Me.NóminasTabPage.SuspendLayout()
        CType(Me.EmpleadosCentroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCentrosTrabajoEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(19, 21)
        CódigoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(43, 13)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(148, 23)
        NombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'CCCLabel
        '
        CCCLabel.AutoSize = True
        CCCLabel.Location = New System.Drawing.Point(642, 21)
        CCCLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CCCLabel.Name = "CCCLabel"
        CCCLabel.Size = New System.Drawing.Size(31, 13)
        CCCLabel.TabIndex = 7
        CCCLabel.Text = "CCC:"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.BDContabilidadGMELO
        Me.EmpresasBindingSource.Sort = "Nombre"
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalanceSituaciónTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.CNO11TableAdapter = Nothing
        Me.TableAdapterManager.CNO94TableAdapter = Nothing
        Me.TableAdapterManager.ConvenioCategoríasConceptosTableAdapter = Nothing
        Me.TableAdapterManager.ConvenioCategoríasTableAdapter = Nothing
        Me.TableAdapterManager.ConvenioGruposTableAdapter = Nothing
        Me.TableAdapterManager.Convenios_ColectivosJulio2014TableAdapter = Nothing
        Me.TableAdapterManager.ConveniosEmpresasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.Cta1TableAdapter = Nothing
        Me.TableAdapterManager.Cta2TableAdapter = Nothing
        Me.TableAdapterManager.CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasMaestrasTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.FacturasEmitidasTableAdapter = Nothing
        Me.TableAdapterManager.FormasPagoTableAdapter = Nothing
        Me.TableAdapterManager.LíneasDiarioTableAdapter = Nothing
        Me.TableAdapterManager.LíneasMayorTableAdapter = Nothing
        Me.TableAdapterManager.NóminaConceptosTableAdapter = Nothing
        Me.TableAdapterManager.NóminasDeEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.NominasDeEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.NóminasTableAdapter = Nothing
        Me.TableAdapterManager.PaisesTableAdapter = Nothing
        Me.TableAdapterManager.PerdidasyGananciasSeccionesTableAdapter = Nothing
        Me.TableAdapterManager.PérdidasyGananciasTableAdapter = Nothing
        Me.TableAdapterManager.PoblacionesTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciasTableAdapter = Nothing
        Me.TableAdapterManager.PuestosTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.SexosTableAdapter = Nothing
        Me.TableAdapterManager.TiposComplementoSalarialTableAdapter = Nothing
        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Nothing
        Me.TableAdapterManager.TiposNóminaTableAdapter = Nothing
        Me.TableAdapterManager.TiposVíaTableAdapter = Nothing
        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasBindingNavigator
        '
        Me.EmpresasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasBindingNavigator.BindingSource = Me.EmpresasBindingSource
        Me.EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.EmpresasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasBindingNavigatorSaveItem})
        Me.EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasBindingNavigator.Name = "EmpresasBindingNavigator"
        Me.EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(305, 27)
        Me.EmpresasBindingNavigator.TabIndex = 0
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'mnuSalir
        '
        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(24, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'EmpresasBindingNavigatorSaveItem
        '
        Me.EmpresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasBindingNavigatorSaveItem.Name = "EmpresasBindingNavigatorSaveItem"
        Me.EmpresasBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.EmpresasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Código", True))
        Me.CódigoTextBox.Location = New System.Drawing.Point(65, 21)
        Me.CódigoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CódigoTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(196, 21)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(440, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'CCCTextBox
        '
        Me.CCCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CCC", True))
        Me.CCCTextBox.Location = New System.Drawing.Point(675, 18)
        Me.CCCTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CCCTextBox.Name = "CCCTextBox"
        Me.CCCTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CCCTextBox.TabIndex = 8
        '
        'CentrosTrabajoBindingSource
        '
        Me.CentrosTrabajoBindingSource.DataMember = "FK_CentrosTrabajo_Empresas"
        Me.CentrosTrabajoBindingSource.DataSource = Me.EmpresasBindingSource
        '
        'CentrosTrabajoTableAdapter
        '
        Me.CentrosTrabajoTableAdapter.ClearBeforeFill = True
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataMember = "Convenios"
        Me.ConveniosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'ConveniosTableAdapter
        '
        Me.ConveniosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EmpleadosDataGridView)
        Me.GroupBox1.Controls.Add(NombreLabel1)
        Me.GroupBox1.Controls.Add(Me.CentrosEmpresaBindingNavigator)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox1)
        Me.GroupBox1.Controls.Add(CódigoLabel1)
        Me.GroupBox1.Controls.Add(Me.CódigoTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 494)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Centros de trabajo"
        '
        'CentrosEmpresaBindingNavigator
        '
        Me.CentrosEmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.CentrosEmpresaBindingNavigator.BindingSource = Me.CentrosTrabajoBindingSource
        Me.CentrosEmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.CentrosEmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.CentrosEmpresaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CentrosEmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.CentrosEmpresaBindingNavigator.Location = New System.Drawing.Point(2, 15)
        Me.CentrosEmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.CentrosEmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.CentrosEmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.CentrosEmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.CentrosEmpresaBindingNavigator.Name = "CentrosEmpresaBindingNavigator"
        Me.CentrosEmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.CentrosEmpresaBindingNavigator.Size = New System.Drawing.Size(1028, 27)
        Me.CentrosEmpresaBindingNavigator.TabIndex = 10
        Me.CentrosEmpresaBindingNavigator.Text = "EmpresasBindingNavigator"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'NominasDeEmpresaBindingSource
        '
        Me.NominasDeEmpresaBindingSource.DataMember = "FK_NominasDeEmpresa_Empresas"
        Me.NominasDeEmpresaBindingSource.DataSource = Me.EmpresasBindingSource
        '
        'NominasDeEmpresaTableAdapter
        '
        Me.NominasDeEmpresaTableAdapter.ClearBeforeFill = True
        '
        'NominasDeEmpresaDataGridView
        '
        Me.NominasDeEmpresaDataGridView.AutoGenerateColumns = False
        Me.NominasDeEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NominasDeEmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdEmpresaDataGridViewTextBoxColumn, Me.IdTipoNóminaDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn})
        Me.NominasDeEmpresaDataGridView.DataSource = Me.NominasDeEmpresaBindingSource
        Me.NominasDeEmpresaDataGridView.Location = New System.Drawing.Point(-123, 17)
        Me.NominasDeEmpresaDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.NominasDeEmpresaDataGridView.Name = "NominasDeEmpresaDataGridView"
        Me.NominasDeEmpresaDataGridView.RowTemplate.Height = 24
        Me.NominasDeEmpresaDataGridView.Size = New System.Drawing.Size(382, 195)
        Me.NominasDeEmpresaDataGridView.TabIndex = 13
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Visible = False
        '
        'IdTipoNóminaDataGridViewTextBoxColumn
        '
        Me.IdTipoNóminaDataGridViewTextBoxColumn.DataPropertyName = "idTipoNómina"
        Me.IdTipoNóminaDataGridViewTextBoxColumn.DataSource = Me.TiposNóminaBindingSource
        Me.IdTipoNóminaDataGridViewTextBoxColumn.DisplayMember = "Tipo"
        Me.IdTipoNóminaDataGridViewTextBoxColumn.HeaderText = "Tipo Nómina"
        Me.IdTipoNóminaDataGridViewTextBoxColumn.Name = "IdTipoNóminaDataGridViewTextBoxColumn"
        Me.IdTipoNóminaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdTipoNóminaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdTipoNóminaDataGridViewTextBoxColumn.ValueMember = "id"
        Me.IdTipoNóminaDataGridViewTextBoxColumn.Width = 120
        '
        'TiposNóminaBindingSource
        '
        Me.TiposNóminaBindingSource.DataMember = "TiposNómina"
        Me.TiposNóminaBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'FechaInicialDataGridViewTextBoxColumn
        '
        Me.FechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial"
        DataGridViewCellStyle1.Format = "d"
        Me.FechaInicialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaInicialDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial"
        Me.FechaInicialDataGridViewTextBoxColumn.Name = "FechaInicialDataGridViewTextBoxColumn"
        '
        'FechaFinalDataGridViewTextBoxColumn
        '
        Me.FechaFinalDataGridViewTextBoxColumn.DataPropertyName = "FechaFinal"
        DataGridViewCellStyle2.Format = "d"
        Me.FechaFinalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final"
        Me.FechaFinalDataGridViewTextBoxColumn.Name = "FechaFinalDataGridViewTextBoxColumn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NóminasEmpresaBindingNavigator)
        Me.GroupBox2.Controls.Add(Me.NominasDeEmpresaDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 2)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(277, 106)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nóminas"
        '
        'NóminasEmpresaBindingNavigator
        '
        Me.NóminasEmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.NóminasEmpresaBindingNavigator.BindingSource = Me.NominasDeEmpresaBindingSource
        Me.NóminasEmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem2
        Me.NóminasEmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.NóminasEmpresaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NóminasEmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2})
        Me.NóminasEmpresaBindingNavigator.Location = New System.Drawing.Point(2, 15)
        Me.NóminasEmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.NóminasEmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.NóminasEmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.NóminasEmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.NóminasEmpresaBindingNavigator.Name = "NóminasEmpresaBindingNavigator"
        Me.NóminasEmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem2
        Me.NóminasEmpresaBindingNavigator.Size = New System.Drawing.Size(273, 27)
        Me.NóminasEmpresaBindingNavigator.TabIndex = 14
        Me.NóminasEmpresaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem2.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem2.Text = "de {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem2.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem2.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem2.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem2.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem2.Text = "Mover último"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'TiposNóminaTableAdapter
        '
        Me.TiposNóminaTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpresasBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(327, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(404, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "Código"
        '
        'DatosEmpresaGroupBox
        '
        Me.DatosEmpresaGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosEmpresaGroupBox.Controls.Add(Me.CCCTextBox)
        Me.DatosEmpresaGroupBox.Controls.Add(CCCLabel)
        Me.DatosEmpresaGroupBox.Controls.Add(Me.NombreTextBox)
        Me.DatosEmpresaGroupBox.Controls.Add(NombreLabel)
        Me.DatosEmpresaGroupBox.Controls.Add(CódigoLabel)
        Me.DatosEmpresaGroupBox.Controls.Add(Me.CódigoTextBox)
        Me.DatosEmpresaGroupBox.Location = New System.Drawing.Point(0, 30)
        Me.DatosEmpresaGroupBox.Name = "DatosEmpresaGroupBox"
        Me.DatosEmpresaGroupBox.Size = New System.Drawing.Size(1059, 61)
        Me.DatosEmpresaGroupBox.TabIndex = 16
        Me.DatosEmpresaGroupBox.TabStop = False
        Me.DatosEmpresaGroupBox.Text = "Datos de la Empresa"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.CentrosTabPage)
        Me.TabControl1.Controls.Add(Me.EmpleadosTabPage)
        Me.TabControl1.Controls.Add(Me.NóminasTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(0, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1059, 532)
        Me.TabControl1.TabIndex = 17
        '
        'CentrosTabPage
        '
        Me.CentrosTabPage.Controls.Add(Me.GroupBox1)
        Me.CentrosTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CentrosTabPage.Name = "CentrosTabPage"
        Me.CentrosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CentrosTabPage.Size = New System.Drawing.Size(1051, 506)
        Me.CentrosTabPage.TabIndex = 0
        Me.CentrosTabPage.Text = "Centros de la Empresa"
        Me.CentrosTabPage.UseVisualStyleBackColor = True
        '
        'EmpleadosTabPage
        '
        Me.EmpleadosTabPage.Location = New System.Drawing.Point(4, 22)
        Me.EmpleadosTabPage.Name = "EmpleadosTabPage"
        Me.EmpleadosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EmpleadosTabPage.Size = New System.Drawing.Size(1051, 506)
        Me.EmpleadosTabPage.TabIndex = 1
        Me.EmpleadosTabPage.Text = "Empleados de la Empresa"
        Me.EmpleadosTabPage.UseVisualStyleBackColor = True
        '
        'NóminasTabPage
        '
        Me.NóminasTabPage.Controls.Add(Me.GroupBox2)
        Me.NóminasTabPage.Location = New System.Drawing.Point(4, 22)
        Me.NóminasTabPage.Name = "NóminasTabPage"
        Me.NóminasTabPage.Size = New System.Drawing.Size(1051, 506)
        Me.NóminasTabPage.TabIndex = 2
        Me.NóminasTabPage.Text = "Nóminas de la Empresa"
        Me.NóminasTabPage.UseVisualStyleBackColor = True
        '
        'CódigoLabel1
        '
        CódigoLabel1.AutoSize = True
        CódigoLabel1.Location = New System.Drawing.Point(6, 50)
        CódigoLabel1.Name = "CódigoLabel1"
        CódigoLabel1.Size = New System.Drawing.Size(43, 13)
        CódigoLabel1.TabIndex = 13
        CódigoLabel1.Text = "Código:"
        '
        'CódigoTextBox1
        '
        Me.CódigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CentrosTrabajoBindingSource, "Código", True))
        Me.CódigoTextBox1.Location = New System.Drawing.Point(55, 47)
        Me.CódigoTextBox1.Name = "CódigoTextBox1"
        Me.CódigoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CódigoTextBox1.TabIndex = 14
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(179, 48)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 14
        NombreLabel1.Text = "Nombre:"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CentrosTrabajoBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(232, 45)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(780, 20)
        Me.NombreTextBox1.TabIndex = 15
        '
        'EmpleadosCentroBindingSource
        '
        Me.EmpleadosCentroBindingSource.DataMember = "FK_Empleados_CentrosTrabajo"
        Me.EmpleadosCentroBindingSource.DataSource = Me.FKCentrosTrabajoEmpresasBindingSource
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn, Me.DocumentoIdentidadDataGridViewTextBoxColumn, Me.BajaDataGridViewCheckBoxColumn, Me.HorasSemanalesDataGridViewTextBoxColumn, Me.NomyApeDataGridViewTextBoxColumn, Me.IdEmpleadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.DomiTipoVíaDataGridViewTextBoxColumn, Me.DomiNombreVíaDataGridViewTextBoxColumn, Me.DomiLocalidadDataGridViewTextBoxColumn, Me.DomiCodPostalDataGridViewTextBoxColumn, Me.DomiProvinciaDataGridViewTextBoxColumn, Me.DomiPaisDataGridViewTextBoxColumn, Me.DomiNúmeroDataGridViewTextBoxColumn, Me.DomiBloqueDataGridViewTextBoxColumn, Me.DomiEscaleraDataGridViewTextBoxColumn, Me.DomiPisoDataGridViewTextBoxColumn, Me.DomiPuertaDataGridViewTextBoxColumn, Me.LaboConvenioDataGridViewTextBoxColumn, Me.LaboEmpresaDataGridViewTextBoxColumn, Me.LaboCentroDataGridViewTextBoxColumn, Me.LaboCategoríaDataGridViewTextBoxColumn, Me.LaboFechaAltaDataGridViewTextBoxColumn, Me.LaboFechaBajaDataGridViewTextBoxColumn, Me.LaboCausaBajaDataGridViewTextBoxColumn, Me.LaboCNAEDataGridViewTextBoxColumn, Me.LaboCNO94DataGridViewTextBoxColumn, Me.LaboCNO11DataGridViewTextBoxColumn, Me.LaboTipoEmpleadoDataGridViewTextBoxColumn, Me.LaboRelLaboralDataGridViewTextBoxColumn, Me.LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn, Me.LaboAntigüedadDataGridViewTextBoxColumn, Me.SegSocNúmeroDataGridViewTextBoxColumn, Me.SegSocGrupoCotizaciónDataGridViewTextBoxColumn, Me.SegSocOcupaciónATEPDataGridViewTextBoxColumn, Me.CobraPorBancoDataGridViewCheckBoxColumn, Me.BancoSicaDataGridViewTextBoxColumn, Me.BancoEntidadDataGridViewTextBoxColumn, Me.BancoSucursalDataGridViewTextBoxColumn, Me.BancoDCDataGridViewTextBoxColumn, Me.BancoCtaDataGridViewTextBoxColumn, Me.CuentaEmpleadoDataGridViewTextBoxColumn})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosCentroBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(13, 87)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(1014, 402)
        Me.EmpleadosDataGridView.TabIndex = 15
        '
        'TipoDocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumentoIdentidad"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "TipoDocumentoIdentidad"
        Me.TipoDocumentoIdentidadDataGridViewTextBoxColumn.Name = "TipoDocumentoIdentidadDataGridViewTextBoxColumn"
        '
        'DocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "DocumentoIdentidad"
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "DocumentoIdentidad"
        Me.DocumentoIdentidadDataGridViewTextBoxColumn.Name = "DocumentoIdentidadDataGridViewTextBoxColumn"
        '
        'BajaDataGridViewCheckBoxColumn
        '
        Me.BajaDataGridViewCheckBoxColumn.DataPropertyName = "Baja"
        Me.BajaDataGridViewCheckBoxColumn.HeaderText = "Baja"
        Me.BajaDataGridViewCheckBoxColumn.Name = "BajaDataGridViewCheckBoxColumn"
        '
        'HorasSemanalesDataGridViewTextBoxColumn
        '
        Me.HorasSemanalesDataGridViewTextBoxColumn.DataPropertyName = "HorasSemanales"
        Me.HorasSemanalesDataGridViewTextBoxColumn.HeaderText = "HorasSemanales"
        Me.HorasSemanalesDataGridViewTextBoxColumn.Name = "HorasSemanalesDataGridViewTextBoxColumn"
        '
        'NomyApeDataGridViewTextBoxColumn
        '
        Me.NomyApeDataGridViewTextBoxColumn.DataPropertyName = "NomyApe"
        Me.NomyApeDataGridViewTextBoxColumn.HeaderText = "NomyApe"
        Me.NomyApeDataGridViewTextBoxColumn.Name = "NomyApeDataGridViewTextBoxColumn"
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'DomiTipoVíaDataGridViewTextBoxColumn
        '
        Me.DomiTipoVíaDataGridViewTextBoxColumn.DataPropertyName = "DomiTipoVía"
        Me.DomiTipoVíaDataGridViewTextBoxColumn.HeaderText = "DomiTipoVía"
        Me.DomiTipoVíaDataGridViewTextBoxColumn.Name = "DomiTipoVíaDataGridViewTextBoxColumn"
        '
        'DomiNombreVíaDataGridViewTextBoxColumn
        '
        Me.DomiNombreVíaDataGridViewTextBoxColumn.DataPropertyName = "DomiNombreVía"
        Me.DomiNombreVíaDataGridViewTextBoxColumn.HeaderText = "DomiNombreVía"
        Me.DomiNombreVíaDataGridViewTextBoxColumn.Name = "DomiNombreVíaDataGridViewTextBoxColumn"
        '
        'DomiLocalidadDataGridViewTextBoxColumn
        '
        Me.DomiLocalidadDataGridViewTextBoxColumn.DataPropertyName = "DomiLocalidad"
        Me.DomiLocalidadDataGridViewTextBoxColumn.HeaderText = "DomiLocalidad"
        Me.DomiLocalidadDataGridViewTextBoxColumn.Name = "DomiLocalidadDataGridViewTextBoxColumn"
        '
        'DomiCodPostalDataGridViewTextBoxColumn
        '
        Me.DomiCodPostalDataGridViewTextBoxColumn.DataPropertyName = "DomiCodPostal"
        Me.DomiCodPostalDataGridViewTextBoxColumn.HeaderText = "DomiCodPostal"
        Me.DomiCodPostalDataGridViewTextBoxColumn.Name = "DomiCodPostalDataGridViewTextBoxColumn"
        '
        'DomiProvinciaDataGridViewTextBoxColumn
        '
        Me.DomiProvinciaDataGridViewTextBoxColumn.DataPropertyName = "DomiProvincia"
        Me.DomiProvinciaDataGridViewTextBoxColumn.HeaderText = "DomiProvincia"
        Me.DomiProvinciaDataGridViewTextBoxColumn.Name = "DomiProvinciaDataGridViewTextBoxColumn"
        '
        'DomiPaisDataGridViewTextBoxColumn
        '
        Me.DomiPaisDataGridViewTextBoxColumn.DataPropertyName = "DomiPais"
        Me.DomiPaisDataGridViewTextBoxColumn.HeaderText = "DomiPais"
        Me.DomiPaisDataGridViewTextBoxColumn.Name = "DomiPaisDataGridViewTextBoxColumn"
        '
        'DomiNúmeroDataGridViewTextBoxColumn
        '
        Me.DomiNúmeroDataGridViewTextBoxColumn.DataPropertyName = "DomiNúmero"
        Me.DomiNúmeroDataGridViewTextBoxColumn.HeaderText = "DomiNúmero"
        Me.DomiNúmeroDataGridViewTextBoxColumn.Name = "DomiNúmeroDataGridViewTextBoxColumn"
        '
        'DomiBloqueDataGridViewTextBoxColumn
        '
        Me.DomiBloqueDataGridViewTextBoxColumn.DataPropertyName = "DomiBloque"
        Me.DomiBloqueDataGridViewTextBoxColumn.HeaderText = "DomiBloque"
        Me.DomiBloqueDataGridViewTextBoxColumn.Name = "DomiBloqueDataGridViewTextBoxColumn"
        '
        'DomiEscaleraDataGridViewTextBoxColumn
        '
        Me.DomiEscaleraDataGridViewTextBoxColumn.DataPropertyName = "DomiEscalera"
        Me.DomiEscaleraDataGridViewTextBoxColumn.HeaderText = "DomiEscalera"
        Me.DomiEscaleraDataGridViewTextBoxColumn.Name = "DomiEscaleraDataGridViewTextBoxColumn"
        '
        'DomiPisoDataGridViewTextBoxColumn
        '
        Me.DomiPisoDataGridViewTextBoxColumn.DataPropertyName = "DomiPiso"
        Me.DomiPisoDataGridViewTextBoxColumn.HeaderText = "DomiPiso"
        Me.DomiPisoDataGridViewTextBoxColumn.Name = "DomiPisoDataGridViewTextBoxColumn"
        '
        'DomiPuertaDataGridViewTextBoxColumn
        '
        Me.DomiPuertaDataGridViewTextBoxColumn.DataPropertyName = "DomiPuerta"
        Me.DomiPuertaDataGridViewTextBoxColumn.HeaderText = "DomiPuerta"
        Me.DomiPuertaDataGridViewTextBoxColumn.Name = "DomiPuertaDataGridViewTextBoxColumn"
        '
        'LaboConvenioDataGridViewTextBoxColumn
        '
        Me.LaboConvenioDataGridViewTextBoxColumn.DataPropertyName = "LaboConvenio"
        Me.LaboConvenioDataGridViewTextBoxColumn.HeaderText = "LaboConvenio"
        Me.LaboConvenioDataGridViewTextBoxColumn.Name = "LaboConvenioDataGridViewTextBoxColumn"
        '
        'LaboEmpresaDataGridViewTextBoxColumn
        '
        Me.LaboEmpresaDataGridViewTextBoxColumn.DataPropertyName = "LaboEmpresa"
        Me.LaboEmpresaDataGridViewTextBoxColumn.HeaderText = "LaboEmpresa"
        Me.LaboEmpresaDataGridViewTextBoxColumn.Name = "LaboEmpresaDataGridViewTextBoxColumn"
        '
        'LaboCentroDataGridViewTextBoxColumn
        '
        Me.LaboCentroDataGridViewTextBoxColumn.DataPropertyName = "LaboCentro"
        Me.LaboCentroDataGridViewTextBoxColumn.HeaderText = "LaboCentro"
        Me.LaboCentroDataGridViewTextBoxColumn.Name = "LaboCentroDataGridViewTextBoxColumn"
        '
        'LaboCategoríaDataGridViewTextBoxColumn
        '
        Me.LaboCategoríaDataGridViewTextBoxColumn.DataPropertyName = "LaboCategoría"
        Me.LaboCategoríaDataGridViewTextBoxColumn.HeaderText = "LaboCategoría"
        Me.LaboCategoríaDataGridViewTextBoxColumn.Name = "LaboCategoríaDataGridViewTextBoxColumn"
        '
        'LaboFechaAltaDataGridViewTextBoxColumn
        '
        Me.LaboFechaAltaDataGridViewTextBoxColumn.DataPropertyName = "LaboFechaAlta"
        Me.LaboFechaAltaDataGridViewTextBoxColumn.HeaderText = "LaboFechaAlta"
        Me.LaboFechaAltaDataGridViewTextBoxColumn.Name = "LaboFechaAltaDataGridViewTextBoxColumn"
        '
        'LaboFechaBajaDataGridViewTextBoxColumn
        '
        Me.LaboFechaBajaDataGridViewTextBoxColumn.DataPropertyName = "LaboFechaBaja"
        Me.LaboFechaBajaDataGridViewTextBoxColumn.HeaderText = "LaboFechaBaja"
        Me.LaboFechaBajaDataGridViewTextBoxColumn.Name = "LaboFechaBajaDataGridViewTextBoxColumn"
        '
        'LaboCausaBajaDataGridViewTextBoxColumn
        '
        Me.LaboCausaBajaDataGridViewTextBoxColumn.DataPropertyName = "LaboCausaBaja"
        Me.LaboCausaBajaDataGridViewTextBoxColumn.HeaderText = "LaboCausaBaja"
        Me.LaboCausaBajaDataGridViewTextBoxColumn.Name = "LaboCausaBajaDataGridViewTextBoxColumn"
        '
        'LaboCNAEDataGridViewTextBoxColumn
        '
        Me.LaboCNAEDataGridViewTextBoxColumn.DataPropertyName = "LaboCNAE"
        Me.LaboCNAEDataGridViewTextBoxColumn.HeaderText = "LaboCNAE"
        Me.LaboCNAEDataGridViewTextBoxColumn.Name = "LaboCNAEDataGridViewTextBoxColumn"
        '
        'LaboCNO94DataGridViewTextBoxColumn
        '
        Me.LaboCNO94DataGridViewTextBoxColumn.DataPropertyName = "LaboCNO94"
        Me.LaboCNO94DataGridViewTextBoxColumn.HeaderText = "LaboCNO94"
        Me.LaboCNO94DataGridViewTextBoxColumn.Name = "LaboCNO94DataGridViewTextBoxColumn"
        '
        'LaboCNO11DataGridViewTextBoxColumn
        '
        Me.LaboCNO11DataGridViewTextBoxColumn.DataPropertyName = "LaboCNO11"
        Me.LaboCNO11DataGridViewTextBoxColumn.HeaderText = "LaboCNO11"
        Me.LaboCNO11DataGridViewTextBoxColumn.Name = "LaboCNO11DataGridViewTextBoxColumn"
        '
        'LaboTipoEmpleadoDataGridViewTextBoxColumn
        '
        Me.LaboTipoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "LaboTipoEmpleado"
        Me.LaboTipoEmpleadoDataGridViewTextBoxColumn.HeaderText = "LaboTipoEmpleado"
        Me.LaboTipoEmpleadoDataGridViewTextBoxColumn.Name = "LaboTipoEmpleadoDataGridViewTextBoxColumn"
        '
        'LaboRelLaboralDataGridViewTextBoxColumn
        '
        Me.LaboRelLaboralDataGridViewTextBoxColumn.DataPropertyName = "LaboRelLaboral"
        Me.LaboRelLaboralDataGridViewTextBoxColumn.HeaderText = "LaboRelLaboral"
        Me.LaboRelLaboralDataGridViewTextBoxColumn.Name = "LaboRelLaboralDataGridViewTextBoxColumn"
        '
        'LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn
        '
        Me.LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn.DataPropertyName = "LaboExcedenteSectorIndustrial"
        Me.LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn.HeaderText = "LaboExcedenteSectorIndustrial"
        Me.LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn.Name = "LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn"
        '
        'LaboAntigüedadDataGridViewTextBoxColumn
        '
        Me.LaboAntigüedadDataGridViewTextBoxColumn.DataPropertyName = "LaboAntigüedad"
        Me.LaboAntigüedadDataGridViewTextBoxColumn.HeaderText = "LaboAntigüedad"
        Me.LaboAntigüedadDataGridViewTextBoxColumn.Name = "LaboAntigüedadDataGridViewTextBoxColumn"
        '
        'SegSocNúmeroDataGridViewTextBoxColumn
        '
        Me.SegSocNúmeroDataGridViewTextBoxColumn.DataPropertyName = "SegSocNúmero"
        Me.SegSocNúmeroDataGridViewTextBoxColumn.HeaderText = "SegSocNúmero"
        Me.SegSocNúmeroDataGridViewTextBoxColumn.Name = "SegSocNúmeroDataGridViewTextBoxColumn"
        '
        'SegSocGrupoCotizaciónDataGridViewTextBoxColumn
        '
        Me.SegSocGrupoCotizaciónDataGridViewTextBoxColumn.DataPropertyName = "SegSocGrupoCotización"
        Me.SegSocGrupoCotizaciónDataGridViewTextBoxColumn.HeaderText = "SegSocGrupoCotización"
        Me.SegSocGrupoCotizaciónDataGridViewTextBoxColumn.Name = "SegSocGrupoCotizaciónDataGridViewTextBoxColumn"
        '
        'SegSocOcupaciónATEPDataGridViewTextBoxColumn
        '
        Me.SegSocOcupaciónATEPDataGridViewTextBoxColumn.DataPropertyName = "SegSocOcupaciónAT_EP"
        Me.SegSocOcupaciónATEPDataGridViewTextBoxColumn.HeaderText = "SegSocOcupaciónAT_EP"
        Me.SegSocOcupaciónATEPDataGridViewTextBoxColumn.Name = "SegSocOcupaciónATEPDataGridViewTextBoxColumn"
        '
        'CobraPorBancoDataGridViewCheckBoxColumn
        '
        Me.CobraPorBancoDataGridViewCheckBoxColumn.DataPropertyName = "CobraPorBanco"
        Me.CobraPorBancoDataGridViewCheckBoxColumn.HeaderText = "CobraPorBanco"
        Me.CobraPorBancoDataGridViewCheckBoxColumn.Name = "CobraPorBancoDataGridViewCheckBoxColumn"
        '
        'BancoSicaDataGridViewTextBoxColumn
        '
        Me.BancoSicaDataGridViewTextBoxColumn.DataPropertyName = "BancoSica"
        Me.BancoSicaDataGridViewTextBoxColumn.HeaderText = "BancoSica"
        Me.BancoSicaDataGridViewTextBoxColumn.Name = "BancoSicaDataGridViewTextBoxColumn"
        '
        'BancoEntidadDataGridViewTextBoxColumn
        '
        Me.BancoEntidadDataGridViewTextBoxColumn.DataPropertyName = "BancoEntidad"
        Me.BancoEntidadDataGridViewTextBoxColumn.HeaderText = "BancoEntidad"
        Me.BancoEntidadDataGridViewTextBoxColumn.Name = "BancoEntidadDataGridViewTextBoxColumn"
        '
        'BancoSucursalDataGridViewTextBoxColumn
        '
        Me.BancoSucursalDataGridViewTextBoxColumn.DataPropertyName = "BancoSucursal"
        Me.BancoSucursalDataGridViewTextBoxColumn.HeaderText = "BancoSucursal"
        Me.BancoSucursalDataGridViewTextBoxColumn.Name = "BancoSucursalDataGridViewTextBoxColumn"
        '
        'BancoDCDataGridViewTextBoxColumn
        '
        Me.BancoDCDataGridViewTextBoxColumn.DataPropertyName = "BancoDC"
        Me.BancoDCDataGridViewTextBoxColumn.HeaderText = "BancoDC"
        Me.BancoDCDataGridViewTextBoxColumn.Name = "BancoDCDataGridViewTextBoxColumn"
        '
        'BancoCtaDataGridViewTextBoxColumn
        '
        Me.BancoCtaDataGridViewTextBoxColumn.DataPropertyName = "BancoCta"
        Me.BancoCtaDataGridViewTextBoxColumn.HeaderText = "BancoCta"
        Me.BancoCtaDataGridViewTextBoxColumn.Name = "BancoCtaDataGridViewTextBoxColumn"
        '
        'CuentaEmpleadoDataGridViewTextBoxColumn
        '
        Me.CuentaEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CuentaEmpleado"
        Me.CuentaEmpleadoDataGridViewTextBoxColumn.HeaderText = "CuentaEmpleado"
        Me.CuentaEmpleadoDataGridViewTextBoxColumn.Name = "CuentaEmpleadoDataGridViewTextBoxColumn"
        Me.CuentaEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FKCentrosTrabajoEmpresasBindingSource
        '
        Me.FKCentrosTrabajoEmpresasBindingSource.DataMember = "FK_CentrosTrabajo_Empresas"
        Me.FKCentrosTrabajoEmpresasBindingSource.DataSource = Me.EmpresasBindingSource
        '
        'frmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 630)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DatosEmpresaGroupBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.EmpresasBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empresas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasBindingNavigator.ResumeLayout(False)
        Me.EmpresasBindingNavigator.PerformLayout()
        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CentrosEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CentrosEmpresaBindingNavigator.ResumeLayout(False)
        Me.CentrosEmpresaBindingNavigator.PerformLayout()
        CType(Me.NominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDeEmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposNóminaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NóminasEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NóminasEmpresaBindingNavigator.ResumeLayout(False)
        Me.NóminasEmpresaBindingNavigator.PerformLayout()
        Me.DatosEmpresaGroupBox.ResumeLayout(False)
        Me.DatosEmpresaGroupBox.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.CentrosTabPage.ResumeLayout(False)
        Me.NóminasTabPage.ResumeLayout(False)
        CType(Me.EmpleadosCentroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCentrosTrabajoEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As BDContabilidadGMELOTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpresasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CódigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CentrosTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CentrosTrabajoTableAdapter As BDContabilidadGMELOTableAdapters.CentrosTrabajoTableAdapter
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveniosTableAdapter As BDContabilidadGMELOTableAdapters.ConveniosTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CentrosEmpresaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NominasDeEmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasDeEmpresaTableAdapter As BDContabilidadGMELOTableAdapters.NominasDeEmpresaTableAdapter
    Friend WithEvents NominasDeEmpresaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TiposNóminaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposNóminaTableAdapter As BDContabilidadGMELOTableAdapters.TiposNóminaTableAdapter
    Friend WithEvents NóminasEmpresaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoNóminaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DatosEmpresaGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CentrosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents EmpleadosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NóminasTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CódigoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmpleadosCentroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Contabilidad.BDContabilidadGMELOTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TipoDocumentoIdentidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoIdentidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BajaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HorasSemanalesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomyApeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiTipoVíaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiNombreVíaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiLocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiCodPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiPaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiNúmeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiBloqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiEscaleraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiPisoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomiPuertaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboConvenioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCentroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCategoríaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboFechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboFechaBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCausaBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCNAEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCNO94DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboCNO11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboTipoEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboRelLaboralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboExcedenteSectorIndustrialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboAntigüedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegSocNúmeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegSocGrupoCotizaciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegSocOcupaciónATEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CobraPorBancoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BancoSicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoEntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoSucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoDCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKCentrosTrabajoEmpresasBindingSource As System.Windows.Forms.BindingSource
End Class
