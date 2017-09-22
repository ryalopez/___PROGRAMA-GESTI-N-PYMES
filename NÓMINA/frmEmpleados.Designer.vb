'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'Partial Class frmEmpleados
'    Inherits System.Windows.Forms.Form

'    'Form reemplaza a Dispose para limpiar la lista de componentes.
'    <System.Diagnostics.DebuggerNonUserCode()> _
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Requerido por el Diseñador de Windows Forms
'    Private components As System.ComponentModel.IContainer

'    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
'    'Se puede modificar usando el Diseñador de Windows Forms.  
'    'No lo modifique con el editor de código.
'    <System.Diagnostics.DebuggerStepThrough()> _
'    Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container()
'        Dim IdEmpleadoLabel As System.Windows.Forms.Label
'        Dim NombreLabel As System.Windows.Forms.Label
'        Dim Apellido1Label As System.Windows.Forms.Label
'        Dim Apellido2Label As System.Windows.Forms.Label
'        Dim SexoLabel As System.Windows.Forms.Label
'        Dim FechaNacimientoLabel As System.Windows.Forms.Label
'        Dim TipoDocumIdentLabel As System.Windows.Forms.Label
'        Dim DocumIdentLabel As System.Windows.Forms.Label
'        Dim DomiTipoVíaLabel As System.Windows.Forms.Label
'        Dim DomiNombreVíaLabel As System.Windows.Forms.Label
'        Dim DomiLocalidadLabel As System.Windows.Forms.Label
'        Dim DomiCodPostalLabel As System.Windows.Forms.Label
'        Dim DomiProvinciaLabel As System.Windows.Forms.Label
'        Dim DomiPaisLabel As System.Windows.Forms.Label
'        Dim DomiNúmeroLabel As System.Windows.Forms.Label
'        Dim DomiBloqueLabel As System.Windows.Forms.Label
'        Dim DomiEscaleraLabel As System.Windows.Forms.Label
'        Dim DomiPisoLabel As System.Windows.Forms.Label
'        Dim DomiPuertaLabel As System.Windows.Forms.Label
'        Dim NumSegSocialLabel As System.Windows.Forms.Label
'        Dim GrupoCotizaciónLabel As System.Windows.Forms.Label
'        Dim OcupaciónCotiAT_EPLabel As System.Windows.Forms.Label
'        Dim IdCentroLabel As System.Windows.Forms.Label
'        Dim IdCategoríaLabel As System.Windows.Forms.Label
'        Dim FechaAltaLabel As System.Windows.Forms.Label
'        Dim FechaBajaLabel As System.Windows.Forms.Label
'        Dim CausaBajaLabel As System.Windows.Forms.Label
'        Dim CNAELabel As System.Windows.Forms.Label
'        Dim CNO94Label As System.Windows.Forms.Label
'        Dim CNO11Label As System.Windows.Forms.Label
'        Dim TipoEmpleadoLabel As System.Windows.Forms.Label
'        Dim TipoRelLaboralLabel As System.Windows.Forms.Label
'        Dim ExcedenteSectorIndustrialLabel As System.Windows.Forms.Label
'        Dim AntigüedadLabel As System.Windows.Forms.Label
'        Dim idEmpresaLabel As System.Windows.Forms.Label
'        Dim idConvenioLabel As System.Windows.Forms.Label
'        Dim BancoSicaLabel As System.Windows.Forms.Label
'        Dim BancoEntidadLabel As System.Windows.Forms.Label
'        Dim BancoSucursalLabel As System.Windows.Forms.Label
'        Dim BancoDCLabel As System.Windows.Forms.Label
'        Dim BancoCtaLabel As System.Windows.Forms.Label
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
'        Dim DataGridViewCellStyle100 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle101 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle102 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle103 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle104 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle105 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle106 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle107 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Dim DataGridViewCellStyle108 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
'        Me.TabControl1 = New System.Windows.Forms.TabControl()
'        Me.DatosPersonales = New System.Windows.Forms.TabPage()
'        Me.TiposDocumentoIdentidadComboBox = New System.Windows.Forms.ComboBox()
'        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.BDMeloDataSet = New Nómina.BDMeloDataSet()
'        Me.TiposDocumentoIdentidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.SexosComboBox = New System.Windows.Forms.ComboBox()
'        Me.SexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
'        Me.NombreTextBox = New System.Windows.Forms.TextBox()
'        Me.Apellido1TextBox = New System.Windows.Forms.TextBox()
'        Me.Apellido2TextBox = New System.Windows.Forms.TextBox()
'        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
'        Me.DocumIdentTextBox = New System.Windows.Forms.TextBox()
'        Me.DatosDomicilio = New System.Windows.Forms.TabPage()
'        Me.PaisesComboBox = New System.Windows.Forms.ComboBox()
'        Me.PaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ProvinciasComboBox = New System.Windows.Forms.ComboBox()
'        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.TiposVíaComboBox = New System.Windows.Forms.ComboBox()
'        Me.TiposVíaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.DomiNombreVíaTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiLocalidadTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiCodPostalTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiNúmeroTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiBloqueTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiEscaleraTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiPisoTextBox = New System.Windows.Forms.TextBox()
'        Me.DomiPuertaTextBox = New System.Windows.Forms.TextBox()
'        Me.DatosLaborales = New System.Windows.Forms.TabPage()
'        Me.CNO11ComboBox = New System.Windows.Forms.ComboBox()
'        Me.CNO11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.CNO94ComboBox = New System.Windows.Forms.ComboBox()
'        Me.CNO94BindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.CNAEComboBox = New System.Windows.Forms.ComboBox()
'        Me.CNAEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioCategoríasComboBox = New System.Windows.Forms.ComboBox()
'        Me.ConvenioCategoríasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.CentrosTrabajoComboBox = New System.Windows.Forms.ComboBox()
'        Me.CentrosTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
'        Me.EmpresasComboBox = New System.Windows.Forms.ComboBox()
'        Me.FechaAltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
'        Me.FechaBajaDateTimePicker = New System.Windows.Forms.DateTimePicker()
'        Me.CausaBajaTextBox = New System.Windows.Forms.TextBox()
'        Me.TipoEmpleadoTextBox = New System.Windows.Forms.TextBox()
'        Me.TipoRelLaboralTextBox = New System.Windows.Forms.TextBox()
'        Me.ExcedenteSectorIndustrialTextBox = New System.Windows.Forms.TextBox()
'        Me.AntigüedadTextBox = New System.Windows.Forms.TextBox()
'        Me.DatosSegSocial = New System.Windows.Forms.TabPage()
'        Me.NumSegSocialTextBox = New System.Windows.Forms.TextBox()
'        Me.GrupoCotizaciónTextBox = New System.Windows.Forms.TextBox()
'        Me.OcupaciónCotiAT_EPTextBox = New System.Windows.Forms.TextBox()
'        Me.DatosBancarios = New System.Windows.Forms.TabPage()
'        Me.BancoCtaTextBox = New System.Windows.Forms.TextBox()
'        Me.BancoDCTextBox = New System.Windows.Forms.TextBox()
'        Me.BancoSucursalTextBox = New System.Windows.Forms.TextBox()
'        Me.BancoEntidadTextBox = New System.Windows.Forms.TextBox()
'        Me.BancoSicaTextBox = New System.Windows.Forms.TextBox()
'        Me.CobraPorBancoCheckBox = New System.Windows.Forms.CheckBox()
'        Me.DatosNóminas = New System.Windows.Forms.TabPage()
'        Me.NóminaConceptosDataGridView = New System.Windows.Forms.DataGridView()
'        Me.NóminaConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.FKNóminasDeEmpleadoNominasDeEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.NominasDeEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConceptosUsadosListBox = New System.Windows.Forms.ListBox()
'        Me.ConceptosDisponiblesListBox = New System.Windows.Forms.ListBox()
'        Me.NóminasEmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
'        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.NóminasDeEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
'        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
'        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
'        Me.NóminasDeEmpleadoDataGridView = New System.Windows.Forms.DataGridView()
'        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
'        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
'        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
'        Me.mnuSalir = New System.Windows.Forms.ToolStripButton()
'        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
'        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
'        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
'        Me.TableAdapterManager = New Nómina.BDMeloDataSetTableAdapters.TableAdapterManager()
'        Me.SexosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.SexosTableAdapter()
'        Me.TiposVíaTableAdapter = New Nómina.BDMeloDataSetTableAdapters.TiposVíaTableAdapter()
'        Me.ProvinciasTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ProvinciasTableAdapter()
'        Me.PaisesTableAdapter = New Nómina.BDMeloDataSetTableAdapters.PaisesTableAdapter()
'        Me.EmpleadosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.EmpleadosTableAdapter()
'        Me.TiposDocumentoIdentidadTableAdapter = New Nómina.BDMeloDataSetTableAdapters.TiposDocumentoIdentidadTableAdapter()
'        Me.EmpresasTableAdapter = New Nómina.BDMeloDataSetTableAdapters.EmpresasTableAdapter()
'        Me.ConveniosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConveniosTableAdapter()
'        Me.CentrosTrabajoTableAdapter = New Nómina.BDMeloDataSetTableAdapters.CentrosTrabajoTableAdapter()
'        Me.ConvenioCategoríasTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasTableAdapter()
'        Me.CNAETableAdapter = New Nómina.BDMeloDataSetTableAdapters.CNAETableAdapter()
'        Me.CNO94TableAdapter = New Nómina.BDMeloDataSetTableAdapters.CNO94TableAdapter()
'        Me.CNO11TableAdapter = New Nómina.BDMeloDataSetTableAdapters.CNO11TableAdapter()
'        Me.NóminasDeEmpleadoTableAdapter = New Nómina.BDMeloDataSetTableAdapters.NóminasDeEmpleadoTableAdapter()
'        Me.NominasDeEmpresaTableAdapter = New Nómina.BDMeloDataSetTableAdapters.NominasDeEmpresaTableAdapter()
'        Me.FKNominasDeEmpresaEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioGruposTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioGruposTableAdapter()
'        Me.ConvenioCategoríasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioCategoríasConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.ConvenioCategoríasConceptosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasConceptosTableAdapter()
'        Me.NóminaConceptosTableAdapter = New Nómina.BDMeloDataSetTableAdapters.NóminaConceptosTableAdapter()
'        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.Denominación = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.FKNóminasDeEmpleadoEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.FKNóminasDeEmpleadoEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.idNóminaEmpresa = New System.Windows.Forms.DataGridViewComboBoxColumn()
'        Me.FechaInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.Bruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.IRPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.CuotaSegSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.BaseCCSegsoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.BaseATyEPSegsoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.CuotaSegSocEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        IdEmpleadoLabel = New System.Windows.Forms.Label()
'        NombreLabel = New System.Windows.Forms.Label()
'        Apellido1Label = New System.Windows.Forms.Label()
'        Apellido2Label = New System.Windows.Forms.Label()
'        SexoLabel = New System.Windows.Forms.Label()
'        FechaNacimientoLabel = New System.Windows.Forms.Label()
'        TipoDocumIdentLabel = New System.Windows.Forms.Label()
'        DocumIdentLabel = New System.Windows.Forms.Label()
'        DomiTipoVíaLabel = New System.Windows.Forms.Label()
'        DomiNombreVíaLabel = New System.Windows.Forms.Label()
'        DomiLocalidadLabel = New System.Windows.Forms.Label()
'        DomiCodPostalLabel = New System.Windows.Forms.Label()
'        DomiProvinciaLabel = New System.Windows.Forms.Label()
'        DomiPaisLabel = New System.Windows.Forms.Label()
'        DomiNúmeroLabel = New System.Windows.Forms.Label()
'        DomiBloqueLabel = New System.Windows.Forms.Label()
'        DomiEscaleraLabel = New System.Windows.Forms.Label()
'        DomiPisoLabel = New System.Windows.Forms.Label()
'        DomiPuertaLabel = New System.Windows.Forms.Label()
'        NumSegSocialLabel = New System.Windows.Forms.Label()
'        GrupoCotizaciónLabel = New System.Windows.Forms.Label()
'        OcupaciónCotiAT_EPLabel = New System.Windows.Forms.Label()
'        IdCentroLabel = New System.Windows.Forms.Label()
'        IdCategoríaLabel = New System.Windows.Forms.Label()
'        FechaAltaLabel = New System.Windows.Forms.Label()
'        FechaBajaLabel = New System.Windows.Forms.Label()
'        CausaBajaLabel = New System.Windows.Forms.Label()
'        CNAELabel = New System.Windows.Forms.Label()
'        CNO94Label = New System.Windows.Forms.Label()
'        CNO11Label = New System.Windows.Forms.Label()
'        TipoEmpleadoLabel = New System.Windows.Forms.Label()
'        TipoRelLaboralLabel = New System.Windows.Forms.Label()
'        ExcedenteSectorIndustrialLabel = New System.Windows.Forms.Label()
'        AntigüedadLabel = New System.Windows.Forms.Label()
'        idEmpresaLabel = New System.Windows.Forms.Label()
'        idConvenioLabel = New System.Windows.Forms.Label()
'        BancoSicaLabel = New System.Windows.Forms.Label()
'        BancoEntidadLabel = New System.Windows.Forms.Label()
'        BancoSucursalLabel = New System.Windows.Forms.Label()
'        BancoDCLabel = New System.Windows.Forms.Label()
'        BancoCtaLabel = New System.Windows.Forms.Label()
'        Me.TabControl1.SuspendLayout()
'        Me.DatosPersonales.SuspendLayout()
'        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.BDMeloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.SexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.DatosDomicilio.SuspendLayout()
'        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.TiposVíaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.DatosLaborales.SuspendLayout()
'        CType(Me.CNO11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CNO94BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CNAEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.DatosSegSocial.SuspendLayout()
'        Me.DatosBancarios.SuspendLayout()
'        Me.DatosNóminas.SuspendLayout()
'        CType(Me.NóminaConceptosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.NóminaConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.FKNóminasDeEmpleadoNominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.NominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.NóminasEmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.NóminasEmpleadoBindingNavigator.SuspendLayout()
'        CType(Me.NóminasDeEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.NóminasDeEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.EmpleadosBindingNavigator.SuspendLayout()
'        CType(Me.FKNominasDeEmpresaEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.ConvenioCategoríasConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.FKNóminasDeEmpleadoEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.FKNóminasDeEmpleadoEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'IdEmpleadoLabel
'        '
'        IdEmpleadoLabel.AutoSize = True
'        IdEmpleadoLabel.Location = New System.Drawing.Point(97, 36)
'        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
'        IdEmpleadoLabel.Size = New System.Drawing.Size(90, 16)
'        IdEmpleadoLabel.TabIndex = 0
'        IdEmpleadoLabel.Text = "id Empleado:"
'        '
'        'NombreLabel
'        '
'        NombreLabel.AutoSize = True
'        NombreLabel.Location = New System.Drawing.Point(97, 65)
'        NombreLabel.Name = "NombreLabel"
'        NombreLabel.Size = New System.Drawing.Size(61, 16)
'        NombreLabel.TabIndex = 2
'        NombreLabel.Text = "Nombre:"
'        '
'        'Apellido1Label
'        '
'        Apellido1Label.AutoSize = True
'        Apellido1Label.Location = New System.Drawing.Point(97, 94)
'        Apellido1Label.Name = "Apellido1Label"
'        Apellido1Label.Size = New System.Drawing.Size(70, 16)
'        Apellido1Label.TabIndex = 4
'        Apellido1Label.Text = "Apellido1:"
'        '
'        'Apellido2Label
'        '
'        Apellido2Label.AutoSize = True
'        Apellido2Label.Location = New System.Drawing.Point(97, 123)
'        Apellido2Label.Name = "Apellido2Label"
'        Apellido2Label.Size = New System.Drawing.Size(70, 16)
'        Apellido2Label.TabIndex = 6
'        Apellido2Label.Text = "Apellido2:"
'        '
'        'SexoLabel
'        '
'        SexoLabel.AutoSize = True
'        SexoLabel.Location = New System.Drawing.Point(97, 152)
'        SexoLabel.Name = "SexoLabel"
'        SexoLabel.Size = New System.Drawing.Size(43, 16)
'        SexoLabel.TabIndex = 8
'        SexoLabel.Text = "Sexo:"
'        '
'        'FechaNacimientoLabel
'        '
'        FechaNacimientoLabel.AutoSize = True
'        FechaNacimientoLabel.Location = New System.Drawing.Point(97, 182)
'        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
'        FechaNacimientoLabel.Size = New System.Drawing.Size(125, 16)
'        FechaNacimientoLabel.TabIndex = 10
'        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
'        '
'        'TipoDocumIdentLabel
'        '
'        TipoDocumIdentLabel.AutoSize = True
'        TipoDocumIdentLabel.Location = New System.Drawing.Point(97, 210)
'        TipoDocumIdentLabel.Name = "TipoDocumIdentLabel"
'        TipoDocumIdentLabel.Size = New System.Drawing.Size(122, 16)
'        TipoDocumIdentLabel.TabIndex = 12
'        TipoDocumIdentLabel.Text = "Tipo Docum Ident:"
'        '
'        'DocumIdentLabel
'        '
'        DocumIdentLabel.AutoSize = True
'        DocumIdentLabel.Location = New System.Drawing.Point(97, 239)
'        DocumIdentLabel.Name = "DocumIdentLabel"
'        DocumIdentLabel.Size = New System.Drawing.Size(91, 16)
'        DocumIdentLabel.TabIndex = 14
'        DocumIdentLabel.Text = "Docum Ident:"
'        '
'        'DomiTipoVíaLabel
'        '
'        DomiTipoVíaLabel.AutoSize = True
'        DomiTipoVíaLabel.Location = New System.Drawing.Point(121, 64)
'        DomiTipoVíaLabel.Name = "DomiTipoVíaLabel"
'        DomiTipoVíaLabel.Size = New System.Drawing.Size(100, 16)
'        DomiTipoVíaLabel.TabIndex = 2
'        DomiTipoVíaLabel.Text = "Domi Tipo Vía:"
'        '
'        'DomiNombreVíaLabel
'        '
'        DomiNombreVíaLabel.AutoSize = True
'        DomiNombreVíaLabel.Location = New System.Drawing.Point(121, 93)
'        DomiNombreVíaLabel.Name = "DomiNombreVíaLabel"
'        DomiNombreVíaLabel.Size = New System.Drawing.Size(122, 16)
'        DomiNombreVíaLabel.TabIndex = 4
'        DomiNombreVíaLabel.Text = "Domi Nombre Vía:"
'        '
'        'DomiLocalidadLabel
'        '
'        DomiLocalidadLabel.AutoSize = True
'        DomiLocalidadLabel.Location = New System.Drawing.Point(121, 122)
'        DomiLocalidadLabel.Name = "DomiLocalidadLabel"
'        DomiLocalidadLabel.Size = New System.Drawing.Size(109, 16)
'        DomiLocalidadLabel.TabIndex = 6
'        DomiLocalidadLabel.Text = "Domi Localidad:"
'        '
'        'DomiCodPostalLabel
'        '
'        DomiCodPostalLabel.AutoSize = True
'        DomiCodPostalLabel.Location = New System.Drawing.Point(121, 151)
'        DomiCodPostalLabel.Name = "DomiCodPostalLabel"
'        DomiCodPostalLabel.Size = New System.Drawing.Size(117, 16)
'        DomiCodPostalLabel.TabIndex = 8
'        DomiCodPostalLabel.Text = "Domi Cod Postal:"
'        '
'        'DomiProvinciaLabel
'        '
'        DomiProvinciaLabel.AutoSize = True
'        DomiProvinciaLabel.Location = New System.Drawing.Point(121, 180)
'        DomiProvinciaLabel.Name = "DomiProvinciaLabel"
'        DomiProvinciaLabel.Size = New System.Drawing.Size(106, 16)
'        DomiProvinciaLabel.TabIndex = 10
'        DomiProvinciaLabel.Text = "Domi Provincia:"
'        '
'        'DomiPaisLabel
'        '
'        DomiPaisLabel.AutoSize = True
'        DomiPaisLabel.Location = New System.Drawing.Point(121, 209)
'        DomiPaisLabel.Name = "DomiPaisLabel"
'        DomiPaisLabel.Size = New System.Drawing.Size(75, 16)
'        DomiPaisLabel.TabIndex = 12
'        DomiPaisLabel.Text = "Domi Pais:"
'        '
'        'DomiNúmeroLabel
'        '
'        DomiNúmeroLabel.AutoSize = True
'        DomiNúmeroLabel.Location = New System.Drawing.Point(121, 238)
'        DomiNúmeroLabel.Name = "DomiNúmeroLabel"
'        DomiNúmeroLabel.Size = New System.Drawing.Size(97, 16)
'        DomiNúmeroLabel.TabIndex = 14
'        DomiNúmeroLabel.Text = "Domi Número:"
'        '
'        'DomiBloqueLabel
'        '
'        DomiBloqueLabel.AutoSize = True
'        DomiBloqueLabel.Location = New System.Drawing.Point(121, 267)
'        DomiBloqueLabel.Name = "DomiBloqueLabel"
'        DomiBloqueLabel.Size = New System.Drawing.Size(92, 16)
'        DomiBloqueLabel.TabIndex = 16
'        DomiBloqueLabel.Text = "Domi Bloque:"
'        '
'        'DomiEscaleraLabel
'        '
'        DomiEscaleraLabel.AutoSize = True
'        DomiEscaleraLabel.Location = New System.Drawing.Point(121, 296)
'        DomiEscaleraLabel.Name = "DomiEscaleraLabel"
'        DomiEscaleraLabel.Size = New System.Drawing.Size(103, 16)
'        DomiEscaleraLabel.TabIndex = 18
'        DomiEscaleraLabel.Text = "Domi Escalera:"
'        '
'        'DomiPisoLabel
'        '
'        DomiPisoLabel.AutoSize = True
'        DomiPisoLabel.Location = New System.Drawing.Point(121, 325)
'        DomiPisoLabel.Name = "DomiPisoLabel"
'        DomiPisoLabel.Size = New System.Drawing.Size(75, 16)
'        DomiPisoLabel.TabIndex = 20
'        DomiPisoLabel.Text = "Domi Piso:"
'        '
'        'DomiPuertaLabel
'        '
'        DomiPuertaLabel.AutoSize = True
'        DomiPuertaLabel.Location = New System.Drawing.Point(121, 354)
'        DomiPuertaLabel.Name = "DomiPuertaLabel"
'        DomiPuertaLabel.Size = New System.Drawing.Size(90, 16)
'        DomiPuertaLabel.TabIndex = 22
'        DomiPuertaLabel.Text = "Domi Puerta:"
'        '
'        'NumSegSocialLabel
'        '
'        NumSegSocialLabel.AutoSize = True
'        NumSegSocialLabel.Location = New System.Drawing.Point(92, 71)
'        NumSegSocialLabel.Name = "NumSegSocialLabel"
'        NumSegSocialLabel.Size = New System.Drawing.Size(111, 16)
'        NumSegSocialLabel.TabIndex = 2
'        NumSegSocialLabel.Text = "Num Seg Social:"
'        '
'        'GrupoCotizaciónLabel
'        '
'        GrupoCotizaciónLabel.AutoSize = True
'        GrupoCotizaciónLabel.Location = New System.Drawing.Point(92, 100)
'        GrupoCotizaciónLabel.Name = "GrupoCotizaciónLabel"
'        GrupoCotizaciónLabel.Size = New System.Drawing.Size(121, 16)
'        GrupoCotizaciónLabel.TabIndex = 4
'        GrupoCotizaciónLabel.Text = "Grupo Cotización:"
'        '
'        'OcupaciónCotiAT_EPLabel
'        '
'        OcupaciónCotiAT_EPLabel.AutoSize = True
'        OcupaciónCotiAT_EPLabel.Location = New System.Drawing.Point(92, 129)
'        OcupaciónCotiAT_EPLabel.Name = "OcupaciónCotiAT_EPLabel"
'        OcupaciónCotiAT_EPLabel.Size = New System.Drawing.Size(151, 16)
'        OcupaciónCotiAT_EPLabel.TabIndex = 6
'        OcupaciónCotiAT_EPLabel.Text = "Ocupación Coti AT EP:"
'        '
'        'IdCentroLabel
'        '
'        IdCentroLabel.AutoSize = True
'        IdCentroLabel.Location = New System.Drawing.Point(99, 120)
'        IdCentroLabel.Name = "IdCentroLabel"
'        IdCentroLabel.Size = New System.Drawing.Size(55, 16)
'        IdCentroLabel.TabIndex = 2
'        IdCentroLabel.Text = "Centro:"
'        '
'        'IdCategoríaLabel
'        '
'        IdCategoríaLabel.AutoSize = True
'        IdCategoríaLabel.Location = New System.Drawing.Point(99, 149)
'        IdCategoríaLabel.Name = "IdCategoríaLabel"
'        IdCategoríaLabel.Size = New System.Drawing.Size(75, 16)
'        IdCategoríaLabel.TabIndex = 4
'        IdCategoríaLabel.Text = "Categoría:"
'        '
'        'FechaAltaLabel
'        '
'        FechaAltaLabel.AutoSize = True
'        FechaAltaLabel.Location = New System.Drawing.Point(99, 179)
'        FechaAltaLabel.Name = "FechaAltaLabel"
'        FechaAltaLabel.Size = New System.Drawing.Size(79, 16)
'        FechaAltaLabel.TabIndex = 6
'        FechaAltaLabel.Text = "Fecha Alta:"
'        '
'        'FechaBajaLabel
'        '
'        FechaBajaLabel.AutoSize = True
'        FechaBajaLabel.Location = New System.Drawing.Point(99, 208)
'        FechaBajaLabel.Name = "FechaBajaLabel"
'        FechaBajaLabel.Size = New System.Drawing.Size(84, 16)
'        FechaBajaLabel.TabIndex = 8
'        FechaBajaLabel.Text = "Fecha Baja:"
'        '
'        'CausaBajaLabel
'        '
'        CausaBajaLabel.AutoSize = True
'        CausaBajaLabel.Location = New System.Drawing.Point(99, 236)
'        CausaBajaLabel.Name = "CausaBajaLabel"
'        CausaBajaLabel.Size = New System.Drawing.Size(85, 16)
'        CausaBajaLabel.TabIndex = 10
'        CausaBajaLabel.Text = "Causa Baja:"
'        '
'        'CNAELabel
'        '
'        CNAELabel.AutoSize = True
'        CNAELabel.Location = New System.Drawing.Point(99, 265)
'        CNAELabel.Name = "CNAELabel"
'        CNAELabel.Size = New System.Drawing.Size(49, 16)
'        CNAELabel.TabIndex = 12
'        CNAELabel.Text = "CNAE:"
'        '
'        'CNO94Label
'        '
'        CNO94Label.AutoSize = True
'        CNO94Label.Location = New System.Drawing.Point(99, 294)
'        CNO94Label.Name = "CNO94Label"
'        CNO94Label.Size = New System.Drawing.Size(58, 16)
'        CNO94Label.TabIndex = 14
'        CNO94Label.Text = "CNO94:"
'        '
'        'CNO11Label
'        '
'        CNO11Label.AutoSize = True
'        CNO11Label.Location = New System.Drawing.Point(99, 323)
'        CNO11Label.Name = "CNO11Label"
'        CNO11Label.Size = New System.Drawing.Size(57, 16)
'        CNO11Label.TabIndex = 16
'        CNO11Label.Text = "CNO11:"
'        '
'        'TipoEmpleadoLabel
'        '
'        TipoEmpleadoLabel.AutoSize = True
'        TipoEmpleadoLabel.Location = New System.Drawing.Point(99, 352)
'        TipoEmpleadoLabel.Name = "TipoEmpleadoLabel"
'        TipoEmpleadoLabel.Size = New System.Drawing.Size(106, 16)
'        TipoEmpleadoLabel.TabIndex = 18
'        TipoEmpleadoLabel.Text = "Tipo Empleado:"
'        '
'        'TipoRelLaboralLabel
'        '
'        TipoRelLaboralLabel.AutoSize = True
'        TipoRelLaboralLabel.Location = New System.Drawing.Point(99, 381)
'        TipoRelLaboralLabel.Name = "TipoRelLaboralLabel"
'        TipoRelLaboralLabel.Size = New System.Drawing.Size(116, 16)
'        TipoRelLaboralLabel.TabIndex = 20
'        TipoRelLaboralLabel.Text = "Tipo Rel Laboral:"
'        '
'        'ExcedenteSectorIndustrialLabel
'        '
'        ExcedenteSectorIndustrialLabel.AutoSize = True
'        ExcedenteSectorIndustrialLabel.Location = New System.Drawing.Point(99, 410)
'        ExcedenteSectorIndustrialLabel.Name = "ExcedenteSectorIndustrialLabel"
'        ExcedenteSectorIndustrialLabel.Size = New System.Drawing.Size(184, 16)
'        ExcedenteSectorIndustrialLabel.TabIndex = 22
'        ExcedenteSectorIndustrialLabel.Text = "Excedente Sector Industrial:"
'        '
'        'AntigüedadLabel
'        '
'        AntigüedadLabel.AutoSize = True
'        AntigüedadLabel.Location = New System.Drawing.Point(99, 439)
'        AntigüedadLabel.Name = "AntigüedadLabel"
'        AntigüedadLabel.Size = New System.Drawing.Size(84, 16)
'        AntigüedadLabel.TabIndex = 24
'        AntigüedadLabel.Text = "Antigüedad:"
'        '
'        'idEmpresaLabel
'        '
'        idEmpresaLabel.AutoSize = True
'        idEmpresaLabel.Location = New System.Drawing.Point(99, 90)
'        idEmpresaLabel.Name = "idEmpresaLabel"
'        idEmpresaLabel.Size = New System.Drawing.Size(68, 16)
'        idEmpresaLabel.TabIndex = 5
'        idEmpresaLabel.Text = "Empresa:"
'        '
'        'idConvenioLabel
'        '
'        idConvenioLabel.AutoSize = True
'        idConvenioLabel.Location = New System.Drawing.Point(99, 61)
'        idConvenioLabel.Name = "idConvenioLabel"
'        idConvenioLabel.Size = New System.Drawing.Size(72, 16)
'        idConvenioLabel.TabIndex = 3
'        idConvenioLabel.Text = "Convenio:"
'        '
'        'BancoSicaLabel
'        '
'        BancoSicaLabel.AutoSize = True
'        BancoSicaLabel.Location = New System.Drawing.Point(155, 116)
'        BancoSicaLabel.Name = "BancoSicaLabel"
'        BancoSicaLabel.Size = New System.Drawing.Size(88, 16)
'        BancoSicaLabel.TabIndex = 3
'        BancoSicaLabel.Text = "Código Sica:"
'        '
'        'BancoEntidadLabel
'        '
'        BancoEntidadLabel.AutoSize = True
'        BancoEntidadLabel.Location = New System.Drawing.Point(183, 155)
'        BancoEntidadLabel.Name = "BancoEntidadLabel"
'        BancoEntidadLabel.Size = New System.Drawing.Size(60, 16)
'        BancoEntidadLabel.TabIndex = 4
'        BancoEntidadLabel.Text = "Entidad:"
'        '
'        'BancoSucursalLabel
'        '
'        BancoSucursalLabel.AutoSize = True
'        BancoSucursalLabel.Location = New System.Drawing.Point(176, 194)
'        BancoSucursalLabel.Name = "BancoSucursalLabel"
'        BancoSucursalLabel.Size = New System.Drawing.Size(67, 16)
'        BancoSucursalLabel.TabIndex = 6
'        BancoSucursalLabel.Text = "Sucursal:"
'        '
'        'BancoDCLabel
'        '
'        BancoDCLabel.AutoSize = True
'        BancoDCLabel.Location = New System.Drawing.Point(211, 233)
'        BancoDCLabel.Name = "BancoDCLabel"
'        BancoDCLabel.Size = New System.Drawing.Size(32, 16)
'        BancoDCLabel.TabIndex = 8
'        BancoDCLabel.Text = "DC:"
'        '
'        'BancoCtaLabel
'        '
'        BancoCtaLabel.AutoSize = True
'        BancoCtaLabel.Location = New System.Drawing.Point(185, 272)
'        BancoCtaLabel.Name = "BancoCtaLabel"
'        BancoCtaLabel.Size = New System.Drawing.Size(58, 16)
'        BancoCtaLabel.TabIndex = 10
'        BancoCtaLabel.Text = "Cuenta:"
'        '
'        'TabControl1
'        '
'        Me.TabControl1.Controls.Add(Me.DatosPersonales)
'        Me.TabControl1.Controls.Add(Me.DatosDomicilio)
'        Me.TabControl1.Controls.Add(Me.DatosLaborales)
'        Me.TabControl1.Controls.Add(Me.DatosSegSocial)
'        Me.TabControl1.Controls.Add(Me.DatosBancarios)
'        Me.TabControl1.Controls.Add(Me.DatosNóminas)
'        Me.TabControl1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.TabControl1.Location = New System.Drawing.Point(0, 30)
'        Me.TabControl1.Name = "TabControl1"
'        Me.TabControl1.SelectedIndex = 0
'        Me.TabControl1.Size = New System.Drawing.Size(1425, 767)
'        Me.TabControl1.TabIndex = 0
'        '
'        'DatosPersonales
'        '
'        Me.DatosPersonales.AutoScroll = True
'        Me.DatosPersonales.Controls.Add(Me.TiposDocumentoIdentidadComboBox)
'        Me.DatosPersonales.Controls.Add(Me.SexosComboBox)
'        Me.DatosPersonales.Controls.Add(IdEmpleadoLabel)
'        Me.DatosPersonales.Controls.Add(Me.IdEmpleadoTextBox)
'        Me.DatosPersonales.Controls.Add(NombreLabel)
'        Me.DatosPersonales.Controls.Add(Me.NombreTextBox)
'        Me.DatosPersonales.Controls.Add(Apellido1Label)
'        Me.DatosPersonales.Controls.Add(Me.Apellido1TextBox)
'        Me.DatosPersonales.Controls.Add(Apellido2Label)
'        Me.DatosPersonales.Controls.Add(Me.Apellido2TextBox)
'        Me.DatosPersonales.Controls.Add(SexoLabel)
'        Me.DatosPersonales.Controls.Add(FechaNacimientoLabel)
'        Me.DatosPersonales.Controls.Add(Me.FechaNacimientoDateTimePicker)
'        Me.DatosPersonales.Controls.Add(TipoDocumIdentLabel)
'        Me.DatosPersonales.Controls.Add(DocumIdentLabel)
'        Me.DatosPersonales.Controls.Add(Me.DocumIdentTextBox)
'        Me.DatosPersonales.Location = New System.Drawing.Point(4, 25)
'        Me.DatosPersonales.Name = "DatosPersonales"
'        Me.DatosPersonales.Padding = New System.Windows.Forms.Padding(3)
'        Me.DatosPersonales.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosPersonales.TabIndex = 0
'        Me.DatosPersonales.Text = "Datos Personales"
'        Me.DatosPersonales.UseVisualStyleBackColor = True
'        '
'        'TiposDocumentoIdentidadComboBox
'        '
'        Me.TiposDocumentoIdentidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "TipoDocumIdent", True))
'        Me.TiposDocumentoIdentidadComboBox.DataSource = Me.TiposDocumentoIdentidadBindingSource
'        Me.TiposDocumentoIdentidadComboBox.DisplayMember = "Tipo"
'        Me.TiposDocumentoIdentidadComboBox.FormattingEnabled = True
'        Me.TiposDocumentoIdentidadComboBox.Location = New System.Drawing.Point(228, 207)
'        Me.TiposDocumentoIdentidadComboBox.Name = "TiposDocumentoIdentidadComboBox"
'        Me.TiposDocumentoIdentidadComboBox.Size = New System.Drawing.Size(200, 24)
'        Me.TiposDocumentoIdentidadComboBox.TabIndex = 13
'        Me.TiposDocumentoIdentidadComboBox.ValueMember = "id"
'        '
'        'EmpleadosBindingSource
'        '
'        Me.EmpleadosBindingSource.DataMember = "Empleados"
'        Me.EmpleadosBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'BDMeloDataSet
'        '
'        Me.BDMeloDataSet.DataSetName = "BDMeloDataSet"
'        Me.BDMeloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'TiposDocumentoIdentidadBindingSource
'        '
'        Me.TiposDocumentoIdentidadBindingSource.DataMember = "TiposDocumentoIdentidad"
'        Me.TiposDocumentoIdentidadBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'SexosComboBox
'        '
'        Me.SexosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "Sexo", True))
'        Me.SexosComboBox.DataSource = Me.SexosBindingSource
'        Me.SexosComboBox.DisplayMember = "Sexo"
'        Me.SexosComboBox.FormattingEnabled = True
'        Me.SexosComboBox.Location = New System.Drawing.Point(228, 149)
'        Me.SexosComboBox.Name = "SexosComboBox"
'        Me.SexosComboBox.Size = New System.Drawing.Size(200, 24)
'        Me.SexosComboBox.TabIndex = 9
'        Me.SexosComboBox.ValueMember = "id"
'        '
'        'SexosBindingSource
'        '
'        Me.SexosBindingSource.DataMember = "Sexos"
'        Me.SexosBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'IdEmpleadoTextBox
'        '
'        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "idEmpleado", True))
'        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(228, 33)
'        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
'        Me.IdEmpleadoTextBox.ReadOnly = True
'        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.IdEmpleadoTextBox.TabIndex = 1
'        '
'        'NombreTextBox
'        '
'        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
'        Me.NombreTextBox.Location = New System.Drawing.Point(228, 62)
'        Me.NombreTextBox.Name = "NombreTextBox"
'        Me.NombreTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.NombreTextBox.TabIndex = 3
'        '
'        'Apellido1TextBox
'        '
'        Me.Apellido1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.Apellido1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido1", True))
'        Me.Apellido1TextBox.Location = New System.Drawing.Point(228, 91)
'        Me.Apellido1TextBox.Name = "Apellido1TextBox"
'        Me.Apellido1TextBox.Size = New System.Drawing.Size(200, 23)
'        Me.Apellido1TextBox.TabIndex = 5
'        '
'        'Apellido2TextBox
'        '
'        Me.Apellido2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.Apellido2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido2", True))
'        Me.Apellido2TextBox.Location = New System.Drawing.Point(228, 120)
'        Me.Apellido2TextBox.Name = "Apellido2TextBox"
'        Me.Apellido2TextBox.Size = New System.Drawing.Size(200, 23)
'        Me.Apellido2TextBox.TabIndex = 7
'        '
'        'FechaNacimientoDateTimePicker
'        '
'        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "FechaNacimiento", True))
'        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(228, 178)
'        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
'        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(200, 23)
'        Me.FechaNacimientoDateTimePicker.TabIndex = 11
'        '
'        'DocumIdentTextBox
'        '
'        Me.DocumIdentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DocumIdentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DocumIdent", True))
'        Me.DocumIdentTextBox.Location = New System.Drawing.Point(228, 236)
'        Me.DocumIdentTextBox.Name = "DocumIdentTextBox"
'        Me.DocumIdentTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.DocumIdentTextBox.TabIndex = 15
'        '
'        'DatosDomicilio
'        '
'        Me.DatosDomicilio.Controls.Add(Me.PaisesComboBox)
'        Me.DatosDomicilio.Controls.Add(Me.ProvinciasComboBox)
'        Me.DatosDomicilio.Controls.Add(Me.TiposVíaComboBox)
'        Me.DatosDomicilio.Controls.Add(DomiTipoVíaLabel)
'        Me.DatosDomicilio.Controls.Add(DomiNombreVíaLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiNombreVíaTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiLocalidadLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiLocalidadTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiCodPostalLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiCodPostalTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiProvinciaLabel)
'        Me.DatosDomicilio.Controls.Add(DomiPaisLabel)
'        Me.DatosDomicilio.Controls.Add(DomiNúmeroLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiNúmeroTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiBloqueLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiBloqueTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiEscaleraLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiEscaleraTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiPisoLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiPisoTextBox)
'        Me.DatosDomicilio.Controls.Add(DomiPuertaLabel)
'        Me.DatosDomicilio.Controls.Add(Me.DomiPuertaTextBox)
'        Me.DatosDomicilio.Location = New System.Drawing.Point(4, 25)
'        Me.DatosDomicilio.Name = "DatosDomicilio"
'        Me.DatosDomicilio.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosDomicilio.TabIndex = 2
'        Me.DatosDomicilio.Text = "Domicilio"
'        Me.DatosDomicilio.UseVisualStyleBackColor = True
'        '
'        'PaisesComboBox
'        '
'        Me.PaisesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "DomiPais", True))
'        Me.PaisesComboBox.DataSource = Me.PaisesBindingSource
'        Me.PaisesComboBox.DisplayMember = "NomPais"
'        Me.PaisesComboBox.FormattingEnabled = True
'        Me.PaisesComboBox.Location = New System.Drawing.Point(249, 206)
'        Me.PaisesComboBox.Name = "PaisesComboBox"
'        Me.PaisesComboBox.Size = New System.Drawing.Size(256, 24)
'        Me.PaisesComboBox.TabIndex = 5
'        Me.PaisesComboBox.ValueMember = "id"
'        '
'        'PaisesBindingSource
'        '
'        Me.PaisesBindingSource.DataMember = "Paises"
'        Me.PaisesBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'ProvinciasComboBox
'        '
'        Me.ProvinciasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "DomiProvincia", True))
'        Me.ProvinciasComboBox.DataSource = Me.ProvinciasBindingSource
'        Me.ProvinciasComboBox.DisplayMember = "NomProvincia"
'        Me.ProvinciasComboBox.FormattingEnabled = True
'        Me.ProvinciasComboBox.Location = New System.Drawing.Point(249, 176)
'        Me.ProvinciasComboBox.Name = "ProvinciasComboBox"
'        Me.ProvinciasComboBox.Size = New System.Drawing.Size(256, 24)
'        Me.ProvinciasComboBox.TabIndex = 4
'        Me.ProvinciasComboBox.ValueMember = "id"
'        '
'        'ProvinciasBindingSource
'        '
'        Me.ProvinciasBindingSource.DataMember = "Provincias"
'        Me.ProvinciasBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'TiposVíaComboBox
'        '
'        Me.TiposVíaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "DomiTipoVía", True))
'        Me.TiposVíaComboBox.DataSource = Me.TiposVíaBindingSource
'        Me.TiposVíaComboBox.DisplayMember = "Tipo"
'        Me.TiposVíaComboBox.FormattingEnabled = True
'        Me.TiposVíaComboBox.Location = New System.Drawing.Point(249, 64)
'        Me.TiposVíaComboBox.Name = "TiposVíaComboBox"
'        Me.TiposVíaComboBox.Size = New System.Drawing.Size(116, 24)
'        Me.TiposVíaComboBox.TabIndex = 0
'        Me.TiposVíaComboBox.ValueMember = "id"
'        '
'        'TiposVíaBindingSource
'        '
'        Me.TiposVíaBindingSource.DataMember = "TiposVía"
'        Me.TiposVíaBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'DomiNombreVíaTextBox
'        '
'        Me.DomiNombreVíaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiNombreVíaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiNombreVía", True))
'        Me.DomiNombreVíaTextBox.Location = New System.Drawing.Point(249, 93)
'        Me.DomiNombreVíaTextBox.Name = "DomiNombreVíaTextBox"
'        Me.DomiNombreVíaTextBox.Size = New System.Drawing.Size(482, 23)
'        Me.DomiNombreVíaTextBox.TabIndex = 1
'        '
'        'DomiLocalidadTextBox
'        '
'        Me.DomiLocalidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiLocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiLocalidad", True))
'        Me.DomiLocalidadTextBox.Location = New System.Drawing.Point(249, 122)
'        Me.DomiLocalidadTextBox.Name = "DomiLocalidadTextBox"
'        Me.DomiLocalidadTextBox.Size = New System.Drawing.Size(482, 23)
'        Me.DomiLocalidadTextBox.TabIndex = 2
'        '
'        'DomiCodPostalTextBox
'        '
'        Me.DomiCodPostalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiCodPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiCodPostal", True))
'        Me.DomiCodPostalTextBox.Location = New System.Drawing.Point(249, 148)
'        Me.DomiCodPostalTextBox.Name = "DomiCodPostalTextBox"
'        Me.DomiCodPostalTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiCodPostalTextBox.TabIndex = 3
'        '
'        'DomiNúmeroTextBox
'        '
'        Me.DomiNúmeroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiNúmeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiNúmero", True))
'        Me.DomiNúmeroTextBox.Location = New System.Drawing.Point(249, 235)
'        Me.DomiNúmeroTextBox.Name = "DomiNúmeroTextBox"
'        Me.DomiNúmeroTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiNúmeroTextBox.TabIndex = 6
'        '
'        'DomiBloqueTextBox
'        '
'        Me.DomiBloqueTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiBloqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiBloque", True))
'        Me.DomiBloqueTextBox.Location = New System.Drawing.Point(249, 264)
'        Me.DomiBloqueTextBox.Name = "DomiBloqueTextBox"
'        Me.DomiBloqueTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiBloqueTextBox.TabIndex = 7
'        '
'        'DomiEscaleraTextBox
'        '
'        Me.DomiEscaleraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiEscaleraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiEscalera", True))
'        Me.DomiEscaleraTextBox.Location = New System.Drawing.Point(249, 293)
'        Me.DomiEscaleraTextBox.Name = "DomiEscaleraTextBox"
'        Me.DomiEscaleraTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiEscaleraTextBox.TabIndex = 8
'        '
'        'DomiPisoTextBox
'        '
'        Me.DomiPisoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiPisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiPiso", True))
'        Me.DomiPisoTextBox.Location = New System.Drawing.Point(249, 322)
'        Me.DomiPisoTextBox.Name = "DomiPisoTextBox"
'        Me.DomiPisoTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiPisoTextBox.TabIndex = 9
'        '
'        'DomiPuertaTextBox
'        '
'        Me.DomiPuertaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
'        Me.DomiPuertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomiPuerta", True))
'        Me.DomiPuertaTextBox.Location = New System.Drawing.Point(249, 351)
'        Me.DomiPuertaTextBox.Name = "DomiPuertaTextBox"
'        Me.DomiPuertaTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.DomiPuertaTextBox.TabIndex = 10
'        '
'        'DatosLaborales
'        '
'        Me.DatosLaborales.Controls.Add(Me.CNO11ComboBox)
'        Me.DatosLaborales.Controls.Add(Me.CNO94ComboBox)
'        Me.DatosLaborales.Controls.Add(Me.CNAEComboBox)
'        Me.DatosLaborales.Controls.Add(Me.ConvenioCategoríasComboBox)
'        Me.DatosLaborales.Controls.Add(Me.CentrosTrabajoComboBox)
'        Me.DatosLaborales.Controls.Add(idConvenioLabel)
'        Me.DatosLaborales.Controls.Add(Me.ComboBox1)
'        Me.DatosLaborales.Controls.Add(idEmpresaLabel)
'        Me.DatosLaborales.Controls.Add(Me.EmpresasComboBox)
'        Me.DatosLaborales.Controls.Add(IdCentroLabel)
'        Me.DatosLaborales.Controls.Add(IdCategoríaLabel)
'        Me.DatosLaborales.Controls.Add(FechaAltaLabel)
'        Me.DatosLaborales.Controls.Add(Me.FechaAltaDateTimePicker)
'        Me.DatosLaborales.Controls.Add(FechaBajaLabel)
'        Me.DatosLaborales.Controls.Add(Me.FechaBajaDateTimePicker)
'        Me.DatosLaborales.Controls.Add(CausaBajaLabel)
'        Me.DatosLaborales.Controls.Add(Me.CausaBajaTextBox)
'        Me.DatosLaborales.Controls.Add(CNAELabel)
'        Me.DatosLaborales.Controls.Add(CNO94Label)
'        Me.DatosLaborales.Controls.Add(CNO11Label)
'        Me.DatosLaborales.Controls.Add(TipoEmpleadoLabel)
'        Me.DatosLaborales.Controls.Add(Me.TipoEmpleadoTextBox)
'        Me.DatosLaborales.Controls.Add(TipoRelLaboralLabel)
'        Me.DatosLaborales.Controls.Add(Me.TipoRelLaboralTextBox)
'        Me.DatosLaborales.Controls.Add(ExcedenteSectorIndustrialLabel)
'        Me.DatosLaborales.Controls.Add(Me.ExcedenteSectorIndustrialTextBox)
'        Me.DatosLaborales.Controls.Add(AntigüedadLabel)
'        Me.DatosLaborales.Controls.Add(Me.AntigüedadTextBox)
'        Me.DatosLaborales.Location = New System.Drawing.Point(4, 25)
'        Me.DatosLaborales.Name = "DatosLaborales"
'        Me.DatosLaborales.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosLaborales.TabIndex = 3
'        Me.DatosLaborales.Text = "Laborales"
'        Me.DatosLaborales.UseVisualStyleBackColor = True
'        '
'        'CNO11ComboBox
'        '
'        Me.CNO11ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboCNO11", True))
'        Me.CNO11ComboBox.DataSource = Me.CNO11BindingSource
'        Me.CNO11ComboBox.DisplayMember = "nombre"
'        Me.CNO11ComboBox.FormattingEnabled = True
'        Me.CNO11ComboBox.Location = New System.Drawing.Point(289, 321)
'        Me.CNO11ComboBox.Margin = New System.Windows.Forms.Padding(2)
'        Me.CNO11ComboBox.Name = "CNO11ComboBox"
'        Me.CNO11ComboBox.Size = New System.Drawing.Size(226, 24)
'        Me.CNO11ComboBox.TabIndex = 9
'        Me.CNO11ComboBox.ValueMember = "id"
'        '
'        'CNO11BindingSource
'        '
'        Me.CNO11BindingSource.DataMember = "CNO11"
'        Me.CNO11BindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'CNO94ComboBox
'        '
'        Me.CNO94ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboCNO94", True))
'        Me.CNO94ComboBox.DataSource = Me.CNO94BindingSource
'        Me.CNO94ComboBox.DisplayMember = "Nombre"
'        Me.CNO94ComboBox.FormattingEnabled = True
'        Me.CNO94ComboBox.Location = New System.Drawing.Point(288, 289)
'        Me.CNO94ComboBox.Margin = New System.Windows.Forms.Padding(2)
'        Me.CNO94ComboBox.Name = "CNO94ComboBox"
'        Me.CNO94ComboBox.Size = New System.Drawing.Size(226, 24)
'        Me.CNO94ComboBox.TabIndex = 8
'        Me.CNO94ComboBox.ValueMember = "id"
'        '
'        'CNO94BindingSource
'        '
'        Me.CNO94BindingSource.DataMember = "CNO94"
'        Me.CNO94BindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'CNAEComboBox
'        '
'        Me.CNAEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboCNAE", True))
'        Me.CNAEComboBox.DataSource = Me.CNAEBindingSource
'        Me.CNAEComboBox.DisplayMember = "TITULO_CNAE2009"
'        Me.CNAEComboBox.FormattingEnabled = True
'        Me.CNAEComboBox.Location = New System.Drawing.Point(289, 261)
'        Me.CNAEComboBox.Margin = New System.Windows.Forms.Padding(2)
'        Me.CNAEComboBox.Name = "CNAEComboBox"
'        Me.CNAEComboBox.Size = New System.Drawing.Size(226, 24)
'        Me.CNAEComboBox.TabIndex = 7
'        Me.CNAEComboBox.ValueMember = "id"
'        '
'        'CNAEBindingSource
'        '
'        Me.CNAEBindingSource.DataMember = "CNAE"
'        Me.CNAEBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'ConvenioCategoríasComboBox
'        '
'        Me.ConvenioCategoríasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboCategoría", True))
'        Me.ConvenioCategoríasComboBox.DataSource = Me.ConvenioCategoríasBindingSource
'        Me.ConvenioCategoríasComboBox.DisplayMember = "Denominación"
'        Me.ConvenioCategoríasComboBox.FormattingEnabled = True
'        Me.ConvenioCategoríasComboBox.Location = New System.Drawing.Point(289, 146)
'        Me.ConvenioCategoríasComboBox.Name = "ConvenioCategoríasComboBox"
'        Me.ConvenioCategoríasComboBox.Size = New System.Drawing.Size(300, 24)
'        Me.ConvenioCategoríasComboBox.TabIndex = 3
'        Me.ConvenioCategoríasComboBox.ValueMember = "id"
'        '
'        'ConvenioCategoríasBindingSource
'        '
'        Me.ConvenioCategoríasBindingSource.DataMember = "FK_ConvenioCategorías_Convenios"
'        Me.ConvenioCategoríasBindingSource.DataSource = Me.ConveniosBindingSource
'        '
'        'ConveniosBindingSource
'        '
'        Me.ConveniosBindingSource.DataMember = "Convenios"
'        Me.ConveniosBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'CentrosTrabajoComboBox
'        '
'        Me.CentrosTrabajoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboCentro", True))
'        Me.CentrosTrabajoComboBox.DataSource = Me.CentrosTrabajoBindingSource
'        Me.CentrosTrabajoComboBox.DisplayMember = "Nombre"
'        Me.CentrosTrabajoComboBox.FormattingEnabled = True
'        Me.CentrosTrabajoComboBox.Location = New System.Drawing.Point(289, 116)
'        Me.CentrosTrabajoComboBox.Name = "CentrosTrabajoComboBox"
'        Me.CentrosTrabajoComboBox.Size = New System.Drawing.Size(300, 24)
'        Me.CentrosTrabajoComboBox.TabIndex = 2
'        Me.CentrosTrabajoComboBox.ValueMember = "Código"
'        '
'        'CentrosTrabajoBindingSource
'        '
'        Me.CentrosTrabajoBindingSource.DataMember = "FK_CentrosTrabajo_Empresas"
'        Me.CentrosTrabajoBindingSource.DataSource = Me.EmpresasBindingSource
'        '
'        'EmpresasBindingSource
'        '
'        Me.EmpresasBindingSource.DataMember = "Empresas"
'        Me.EmpresasBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'ComboBox1
'        '
'        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboConvenio", True))
'        Me.ComboBox1.DataSource = Me.ConveniosBindingSource
'        Me.ComboBox1.DisplayMember = "Nombre"
'        Me.ComboBox1.FormattingEnabled = True
'        Me.ComboBox1.Location = New System.Drawing.Point(289, 58)
'        Me.ComboBox1.Name = "ComboBox1"
'        Me.ComboBox1.Size = New System.Drawing.Size(300, 24)
'        Me.ComboBox1.TabIndex = 0
'        Me.ComboBox1.ValueMember = "Código"
'        '
'        'EmpresasComboBox
'        '
'        Me.EmpresasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "LaboEmpresa", True))
'        Me.EmpresasComboBox.DataSource = Me.EmpresasBindingSource
'        Me.EmpresasComboBox.DisplayMember = "Nombre"
'        Me.EmpresasComboBox.FormattingEnabled = True
'        Me.EmpresasComboBox.Location = New System.Drawing.Point(289, 87)
'        Me.EmpresasComboBox.Name = "EmpresasComboBox"
'        Me.EmpresasComboBox.Size = New System.Drawing.Size(300, 24)
'        Me.EmpresasComboBox.TabIndex = 1
'        Me.EmpresasComboBox.ValueMember = "Código"
'        '
'        'FechaAltaDateTimePicker
'        '
'        Me.FechaAltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "LaboFechaAlta", True))
'        Me.FechaAltaDateTimePicker.Location = New System.Drawing.Point(289, 175)
'        Me.FechaAltaDateTimePicker.Name = "FechaAltaDateTimePicker"
'        Me.FechaAltaDateTimePicker.Size = New System.Drawing.Size(200, 23)
'        Me.FechaAltaDateTimePicker.TabIndex = 4
'        '
'        'FechaBajaDateTimePicker
'        '
'        Me.FechaBajaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "LaboFechaBaja", True))
'        Me.FechaBajaDateTimePicker.Location = New System.Drawing.Point(289, 204)
'        Me.FechaBajaDateTimePicker.Name = "FechaBajaDateTimePicker"
'        Me.FechaBajaDateTimePicker.Size = New System.Drawing.Size(200, 23)
'        Me.FechaBajaDateTimePicker.TabIndex = 5
'        '
'        'CausaBajaTextBox
'        '
'        Me.CausaBajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "LaboCausaBaja", True))
'        Me.CausaBajaTextBox.Location = New System.Drawing.Point(289, 233)
'        Me.CausaBajaTextBox.Name = "CausaBajaTextBox"
'        Me.CausaBajaTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.CausaBajaTextBox.TabIndex = 6
'        '
'        'TipoEmpleadoTextBox
'        '
'        Me.TipoEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "LaboTipoEmpleado", True))
'        Me.TipoEmpleadoTextBox.Location = New System.Drawing.Point(289, 349)
'        Me.TipoEmpleadoTextBox.Name = "TipoEmpleadoTextBox"
'        Me.TipoEmpleadoTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.TipoEmpleadoTextBox.TabIndex = 10
'        '
'        'TipoRelLaboralTextBox
'        '
'        Me.TipoRelLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "LaboRelLaboral", True))
'        Me.TipoRelLaboralTextBox.Location = New System.Drawing.Point(289, 378)
'        Me.TipoRelLaboralTextBox.Name = "TipoRelLaboralTextBox"
'        Me.TipoRelLaboralTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.TipoRelLaboralTextBox.TabIndex = 11
'        '
'        'ExcedenteSectorIndustrialTextBox
'        '
'        Me.ExcedenteSectorIndustrialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "LaboExcedenteSectorIndustrial", True))
'        Me.ExcedenteSectorIndustrialTextBox.Location = New System.Drawing.Point(289, 407)
'        Me.ExcedenteSectorIndustrialTextBox.Name = "ExcedenteSectorIndustrialTextBox"
'        Me.ExcedenteSectorIndustrialTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.ExcedenteSectorIndustrialTextBox.TabIndex = 12
'        '
'        'AntigüedadTextBox
'        '
'        Me.AntigüedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "LaboAntigüedad", True))
'        Me.AntigüedadTextBox.Location = New System.Drawing.Point(289, 436)
'        Me.AntigüedadTextBox.Name = "AntigüedadTextBox"
'        Me.AntigüedadTextBox.Size = New System.Drawing.Size(200, 23)
'        Me.AntigüedadTextBox.TabIndex = 13
'        '
'        'DatosSegSocial
'        '
'        Me.DatosSegSocial.Controls.Add(NumSegSocialLabel)
'        Me.DatosSegSocial.Controls.Add(Me.NumSegSocialTextBox)
'        Me.DatosSegSocial.Controls.Add(GrupoCotizaciónLabel)
'        Me.DatosSegSocial.Controls.Add(Me.GrupoCotizaciónTextBox)
'        Me.DatosSegSocial.Controls.Add(OcupaciónCotiAT_EPLabel)
'        Me.DatosSegSocial.Controls.Add(Me.OcupaciónCotiAT_EPTextBox)
'        Me.DatosSegSocial.Location = New System.Drawing.Point(4, 25)
'        Me.DatosSegSocial.Name = "DatosSegSocial"
'        Me.DatosSegSocial.Padding = New System.Windows.Forms.Padding(3)
'        Me.DatosSegSocial.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosSegSocial.TabIndex = 1
'        Me.DatosSegSocial.Text = "Seg Social"
'        Me.DatosSegSocial.UseVisualStyleBackColor = True
'        '
'        'NumSegSocialTextBox
'        '
'        Me.NumSegSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SegSocNúmero", True))
'        Me.NumSegSocialTextBox.Location = New System.Drawing.Point(249, 68)
'        Me.NumSegSocialTextBox.Name = "NumSegSocialTextBox"
'        Me.NumSegSocialTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.NumSegSocialTextBox.TabIndex = 3
'        '
'        'GrupoCotizaciónTextBox
'        '
'        Me.GrupoCotizaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SegSocGrupoCotización", True))
'        Me.GrupoCotizaciónTextBox.Location = New System.Drawing.Point(249, 97)
'        Me.GrupoCotizaciónTextBox.Name = "GrupoCotizaciónTextBox"
'        Me.GrupoCotizaciónTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.GrupoCotizaciónTextBox.TabIndex = 5
'        '
'        'OcupaciónCotiAT_EPTextBox
'        '
'        Me.OcupaciónCotiAT_EPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SegSocOcupaciónAT_EP", True))
'        Me.OcupaciónCotiAT_EPTextBox.Location = New System.Drawing.Point(249, 126)
'        Me.OcupaciónCotiAT_EPTextBox.Name = "OcupaciónCotiAT_EPTextBox"
'        Me.OcupaciónCotiAT_EPTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.OcupaciónCotiAT_EPTextBox.TabIndex = 7
'        '
'        'DatosBancarios
'        '
'        Me.DatosBancarios.Controls.Add(BancoCtaLabel)
'        Me.DatosBancarios.Controls.Add(Me.BancoCtaTextBox)
'        Me.DatosBancarios.Controls.Add(BancoDCLabel)
'        Me.DatosBancarios.Controls.Add(Me.BancoDCTextBox)
'        Me.DatosBancarios.Controls.Add(BancoSucursalLabel)
'        Me.DatosBancarios.Controls.Add(Me.BancoSucursalTextBox)
'        Me.DatosBancarios.Controls.Add(BancoEntidadLabel)
'        Me.DatosBancarios.Controls.Add(Me.BancoEntidadTextBox)
'        Me.DatosBancarios.Controls.Add(BancoSicaLabel)
'        Me.DatosBancarios.Controls.Add(Me.BancoSicaTextBox)
'        Me.DatosBancarios.Controls.Add(Me.CobraPorBancoCheckBox)
'        Me.DatosBancarios.Location = New System.Drawing.Point(4, 25)
'        Me.DatosBancarios.Name = "DatosBancarios"
'        Me.DatosBancarios.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosBancarios.TabIndex = 5
'        Me.DatosBancarios.Text = "Banco"
'        Me.DatosBancarios.UseVisualStyleBackColor = True
'        '
'        'BancoCtaTextBox
'        '
'        Me.BancoCtaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoCta", True))
'        Me.BancoCtaTextBox.Location = New System.Drawing.Point(249, 273)
'        Me.BancoCtaTextBox.Name = "BancoCtaTextBox"
'        Me.BancoCtaTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.BancoCtaTextBox.TabIndex = 11
'        '
'        'BancoDCTextBox
'        '
'        Me.BancoDCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoDC", True))
'        Me.BancoDCTextBox.Location = New System.Drawing.Point(249, 233)
'        Me.BancoDCTextBox.Name = "BancoDCTextBox"
'        Me.BancoDCTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.BancoDCTextBox.TabIndex = 9
'        '
'        'BancoSucursalTextBox
'        '
'        Me.BancoSucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoSucursal", True))
'        Me.BancoSucursalTextBox.Location = New System.Drawing.Point(249, 193)
'        Me.BancoSucursalTextBox.Name = "BancoSucursalTextBox"
'        Me.BancoSucursalTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.BancoSucursalTextBox.TabIndex = 7
'        '
'        'BancoEntidadTextBox
'        '
'        Me.BancoEntidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoEntidad", True))
'        Me.BancoEntidadTextBox.Location = New System.Drawing.Point(249, 153)
'        Me.BancoEntidadTextBox.Name = "BancoEntidadTextBox"
'        Me.BancoEntidadTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.BancoEntidadTextBox.TabIndex = 5
'        '
'        'BancoSicaTextBox
'        '
'        Me.BancoSicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoSica", True))
'        Me.BancoSicaTextBox.Location = New System.Drawing.Point(249, 113)
'        Me.BancoSicaTextBox.Name = "BancoSicaTextBox"
'        Me.BancoSicaTextBox.Size = New System.Drawing.Size(100, 23)
'        Me.BancoSicaTextBox.TabIndex = 4
'        '
'        'CobraPorBancoCheckBox
'        '
'        Me.CobraPorBancoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpleadosBindingSource, "CobraPorBanco", True))
'        Me.CobraPorBancoCheckBox.Location = New System.Drawing.Point(121, 70)
'        Me.CobraPorBancoCheckBox.Name = "CobraPorBancoCheckBox"
'        Me.CobraPorBancoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
'        Me.CobraPorBancoCheckBox.Size = New System.Drawing.Size(143, 26)
'        Me.CobraPorBancoCheckBox.TabIndex = 3
'        Me.CobraPorBancoCheckBox.Text = "Cobra por Banco"
'        Me.CobraPorBancoCheckBox.UseVisualStyleBackColor = True
'        '
'        'DatosNóminas
'        '
'        Me.DatosNóminas.AutoScroll = True
'        Me.DatosNóminas.Controls.Add(Me.NóminaConceptosDataGridView)
'        Me.DatosNóminas.Controls.Add(Me.ConceptosUsadosListBox)
'        Me.DatosNóminas.Controls.Add(Me.ConceptosDisponiblesListBox)
'        Me.DatosNóminas.Controls.Add(Me.NóminasEmpleadoBindingNavigator)
'        Me.DatosNóminas.Controls.Add(Me.NóminasDeEmpleadoDataGridView)
'        Me.DatosNóminas.Location = New System.Drawing.Point(4, 25)
'        Me.DatosNóminas.Margin = New System.Windows.Forms.Padding(2)
'        Me.DatosNóminas.Name = "DatosNóminas"
'        Me.DatosNóminas.Padding = New System.Windows.Forms.Padding(2)
'        Me.DatosNóminas.Size = New System.Drawing.Size(1417, 738)
'        Me.DatosNóminas.TabIndex = 4
'        Me.DatosNóminas.Text = "Nóminas"
'        Me.DatosNóminas.UseVisualStyleBackColor = True
'        '
'        'NóminaConceptosDataGridView
'        '
'        Me.NóminaConceptosDataGridView.AutoGenerateColumns = False
'        Me.NóminaConceptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.NóminaConceptosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Denominación, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
'        Me.NóminaConceptosDataGridView.DataSource = Me.NóminaConceptosBindingSource
'        Me.NóminaConceptosDataGridView.Location = New System.Drawing.Point(534, 443)
'        Me.NóminaConceptosDataGridView.Name = "NóminaConceptosDataGridView"
'        Me.NóminaConceptosDataGridView.Size = New System.Drawing.Size(677, 196)
'        Me.NóminaConceptosDataGridView.TabIndex = 4
'        '
'        'NóminaConceptosBindingSource
'        '
'        Me.NóminaConceptosBindingSource.DataMember = "FK_NóminaConceptos_NóminasDeEmpleado"
'        Me.NóminaConceptosBindingSource.DataSource = Me.FKNóminasDeEmpleadoEmpleadosBindingSource
'        '
'        'FKNóminasDeEmpleadoNominasDeEmpresaBindingSource
'        '
'        Me.FKNóminasDeEmpleadoNominasDeEmpresaBindingSource.DataMember = "FK_NóminasDeEmpleado_NominasDeEmpresa"
'        Me.FKNóminasDeEmpleadoNominasDeEmpresaBindingSource.DataSource = Me.NominasDeEmpresaBindingSource
'        '
'        'NominasDeEmpresaBindingSource
'        '
'        Me.NominasDeEmpresaBindingSource.DataMember = "NominasDeEmpresa"
'        Me.NominasDeEmpresaBindingSource.DataSource = Me.BDMeloDataSet
'        '
'        'ConceptosUsadosListBox
'        '
'        Me.ConceptosUsadosListBox.FormattingEnabled = True
'        Me.ConceptosUsadosListBox.ItemHeight = 16
'        Me.ConceptosUsadosListBox.Location = New System.Drawing.Point(302, 443)
'        Me.ConceptosUsadosListBox.Name = "ConceptosUsadosListBox"
'        Me.ConceptosUsadosListBox.Size = New System.Drawing.Size(184, 196)
'        Me.ConceptosUsadosListBox.TabIndex = 3
'        '
'        'ConceptosDisponiblesListBox
'        '
'        Me.ConceptosDisponiblesListBox.FormattingEnabled = True
'        Me.ConceptosDisponiblesListBox.ItemHeight = 16
'        Me.ConceptosDisponiblesListBox.Location = New System.Drawing.Point(46, 443)
'        Me.ConceptosDisponiblesListBox.Name = "ConceptosDisponiblesListBox"
'        Me.ConceptosDisponiblesListBox.Size = New System.Drawing.Size(184, 196)
'        Me.ConceptosDisponiblesListBox.TabIndex = 2
'        '
'        'NóminasEmpleadoBindingNavigator
'        '
'        Me.NóminasEmpleadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
'        Me.NóminasEmpleadoBindingNavigator.BindingSource = Me.FKNóminasDeEmpleadoEmpleadosBindingSource
'        Me.NóminasEmpleadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
'        Me.NóminasEmpleadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
'        Me.NóminasEmpleadoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
'        Me.NóminasEmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
'        Me.NóminasEmpleadoBindingNavigator.Location = New System.Drawing.Point(2, 2)
'        Me.NóminasEmpleadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
'        Me.NóminasEmpleadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
'        Me.NóminasEmpleadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
'        Me.NóminasEmpleadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
'        Me.NóminasEmpleadoBindingNavigator.Name = "NóminasEmpleadoBindingNavigator"
'        Me.NóminasEmpleadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
'        Me.NóminasEmpleadoBindingNavigator.Size = New System.Drawing.Size(1418, 27)
'        Me.NóminasEmpleadoBindingNavigator.TabIndex = 1
'        Me.NóminasEmpleadoBindingNavigator.Text = "BindingNavigator1"
'        '
'        'BindingNavigatorAddNewItem1
'        '
'        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
'        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
'        '
'        'NóminasDeEmpleadoBindingSource
'        '
'        Me.NóminasDeEmpleadoBindingSource.DataMember = "FK_NóminasDeEmpleado_Empleados"
'        Me.NóminasDeEmpleadoBindingSource.DataSource = Me.EmpleadosBindingSource
'        '
'        'BindingNavigatorCountItem1
'        '
'        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
'        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 24)
'        Me.BindingNavigatorCountItem1.Text = "de {0}"
'        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
'        '
'        'BindingNavigatorDeleteItem1
'        '
'        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
'        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
'        '
'        'BindingNavigatorMoveFirstItem1
'        '
'        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
'        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
'        '
'        'BindingNavigatorMovePreviousItem1
'        '
'        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
'        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
'        '
'        'BindingNavigatorSeparator3
'        '
'        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
'        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorPositionItem1
'        '
'        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
'        Me.BindingNavigatorPositionItem1.AutoSize = False
'        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
'        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(38, 23)
'        Me.BindingNavigatorPositionItem1.Text = "0"
'        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
'        '
'        'BindingNavigatorSeparator4
'        '
'        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
'        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorMoveNextItem1
'        '
'        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
'        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
'        '
'        'BindingNavigatorMoveLastItem1
'        '
'        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
'        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
'        '
'        'BindingNavigatorSeparator5
'        '
'        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
'        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
'        '
'        'NóminasDeEmpleadoDataGridView
'        '
'        Me.NóminasDeEmpleadoDataGridView.AllowUserToOrderColumns = True
'        Me.NóminasDeEmpleadoDataGridView.AutoGenerateColumns = False
'        Me.NóminasDeEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.NóminasDeEmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.idNóminaEmpresa, Me.FechaInicial, Me.FechaFinal, Me.Bruto, Me.IRPF, Me.CuotaSegSoc, Me.BaseCCSegsoc, Me.BaseATyEPSegsoc, Me.CuotaSegSocEmpresa})
'        Me.NóminasDeEmpleadoDataGridView.DataSource = Me.FKNóminasDeEmpleadoEmpleadosBindingSource
'        Me.NóminasDeEmpleadoDataGridView.Location = New System.Drawing.Point(2, 36)
'        Me.NóminasDeEmpleadoDataGridView.Margin = New System.Windows.Forms.Padding(2)
'        Me.NóminasDeEmpleadoDataGridView.Name = "NóminasDeEmpleadoDataGridView"
'        Me.NóminasDeEmpleadoDataGridView.RowTemplate.Height = 24
'        Me.NóminasDeEmpleadoDataGridView.Size = New System.Drawing.Size(1418, 395)
'        Me.NóminasDeEmpleadoDataGridView.TabIndex = 0
'        '
'        'EmpleadosBindingNavigator
'        '
'        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
'        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
'        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
'        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
'        Me.EmpleadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
'        Me.EmpleadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
'        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
'        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
'        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
'        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
'        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
'        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
'        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
'        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
'        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(317, 27)
'        Me.EmpleadosBindingNavigator.TabIndex = 7
'        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
'        '
'        'BindingNavigatorAddNewItem
'        '
'        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
'        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
'        '
'        'BindingNavigatorCountItem
'        '
'        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
'        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
'        Me.BindingNavigatorCountItem.Text = "de {0}"
'        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
'        '
'        'BindingNavigatorDeleteItem
'        '
'        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
'        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
'        '
'        'mnuSalir
'        '
'        Me.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
'        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
'        Me.mnuSalir.Name = "mnuSalir"
'        Me.mnuSalir.Size = New System.Drawing.Size(24, 24)
'        Me.mnuSalir.Text = "Salir"
'        '
'        'ToolStripSeparator1
'        '
'        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
'        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorMoveFirstItem
'        '
'        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
'        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
'        '
'        'BindingNavigatorMovePreviousItem
'        '
'        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
'        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
'        '
'        'BindingNavigatorSeparator
'        '
'        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorPositionItem
'        '
'        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
'        Me.BindingNavigatorPositionItem.AutoSize = False
'        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
'        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
'        Me.BindingNavigatorPositionItem.Text = "0"
'        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
'        '
'        'BindingNavigatorSeparator1
'        '
'        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
'        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorMoveNextItem
'        '
'        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
'        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
'        '
'        'BindingNavigatorMoveLastItem
'        '
'        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
'        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
'        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
'        '
'        'BindingNavigatorSeparator2
'        '
'        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
'        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
'        '
'        'EmpleadosBindingNavigatorSaveItem
'        '
'        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
'        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
'        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
'        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
'        '
'        'TableAdapterManager
'        '
'        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
'        Me.TableAdapterManager.CallesTableAdapter = Nothing
'        Me.TableAdapterManager.CentrosTrabajoTableAdapter = Nothing
'        Me.TableAdapterManager.CNAETableAdapter = Nothing
'        Me.TableAdapterManager.CNO11TableAdapter = Nothing
'        Me.TableAdapterManager.CNO94TableAdapter = Nothing
'        Me.TableAdapterManager.ConvenioCategoríasConceptosTableAdapter = Nothing
'        Me.TableAdapterManager.ConvenioCategoríasTableAdapter = Nothing
'        Me.TableAdapterManager.ConvenioGruposTableAdapter = Nothing
'        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
'        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
'        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
'        Me.TableAdapterManager.NóminaConceptosTableAdapter = Nothing
'        Me.TableAdapterManager.NóminasDeEmpleadoTableAdapter = Nothing
'        Me.TableAdapterManager.NominasDeEmpresaTableAdapter = Nothing
'        Me.TableAdapterManager.PaisesTableAdapter = Nothing
'        Me.TableAdapterManager.ProvinciasTableAdapter = Nothing
'        Me.TableAdapterManager.SexosTableAdapter = Me.SexosTableAdapter
'        Me.TableAdapterManager.TiposComplementoSalarialTableAdapter = Nothing
'        Me.TableAdapterManager.TiposDocumentoIdentidadTableAdapter = Nothing
'        Me.TableAdapterManager.TiposNóminaTableAdapter = Nothing
'        Me.TableAdapterManager.TiposVíaTableAdapter = Me.TiposVíaTableAdapter
'        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
'        Me.TableAdapterManager.UpdateOrder = Nómina.BDMeloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
'        '
'        'SexosTableAdapter
'        '
'        Me.SexosTableAdapter.ClearBeforeFill = True
'        '
'        'TiposVíaTableAdapter
'        '
'        Me.TiposVíaTableAdapter.ClearBeforeFill = True
'        '
'        'ProvinciasTableAdapter
'        '
'        Me.ProvinciasTableAdapter.ClearBeforeFill = True
'        '
'        'PaisesTableAdapter
'        '
'        Me.PaisesTableAdapter.ClearBeforeFill = True
'        '
'        'EmpleadosTableAdapter
'        '
'        Me.EmpleadosTableAdapter.ClearBeforeFill = True
'        '
'        'TiposDocumentoIdentidadTableAdapter
'        '
'        Me.TiposDocumentoIdentidadTableAdapter.ClearBeforeFill = True
'        '
'        'EmpresasTableAdapter
'        '
'        Me.EmpresasTableAdapter.ClearBeforeFill = True
'        '
'        'ConveniosTableAdapter
'        '
'        Me.ConveniosTableAdapter.ClearBeforeFill = True
'        '
'        'CentrosTrabajoTableAdapter
'        '
'        Me.CentrosTrabajoTableAdapter.ClearBeforeFill = True
'        '
'        'ConvenioCategoríasTableAdapter
'        '
'        Me.ConvenioCategoríasTableAdapter.ClearBeforeFill = True
'        '
'        'CNAETableAdapter
'        '
'        Me.CNAETableAdapter.ClearBeforeFill = True
'        '
'        'CNO94TableAdapter
'        '
'        Me.CNO94TableAdapter.ClearBeforeFill = True
'        '
'        'CNO11TableAdapter
'        '
'        Me.CNO11TableAdapter.ClearBeforeFill = True
'        '
'        'NóminasDeEmpleadoTableAdapter
'        '
'        Me.NóminasDeEmpleadoTableAdapter.ClearBeforeFill = True
'        '
'        'NominasDeEmpresaTableAdapter
'        '
'        Me.NominasDeEmpresaTableAdapter.ClearBeforeFill = True
'        '
'        'FKNominasDeEmpresaEmpresasBindingSource
'        '
'        Me.FKNominasDeEmpresaEmpresasBindingSource.DataMember = "FK_NominasDeEmpresa_Empresas"
'        Me.FKNominasDeEmpresaEmpresasBindingSource.DataSource = Me.EmpresasBindingSource
'        '
'        'ConvenioGruposBindingSource
'        '
'        Me.ConvenioGruposBindingSource.DataMember = "FK_ConvenioGrupos_ConvenioGrupos"
'        Me.ConvenioGruposBindingSource.DataSource = Me.ConveniosBindingSource
'        '
'        'ConvenioGruposTableAdapter
'        '
'        Me.ConvenioGruposTableAdapter.ClearBeforeFill = True
'        '
'        'ConvenioCategoríasBindingSource1
'        '
'        Me.ConvenioCategoríasBindingSource1.DataMember = "FK_ConvenioCategorías_ConvenioGrupos"
'        Me.ConvenioCategoríasBindingSource1.DataSource = Me.ConvenioGruposBindingSource
'        '
'        'ConvenioCategoríasConceptosBindingSource
'        '
'        Me.ConvenioCategoríasConceptosBindingSource.DataMember = "FK_ConvenioCategoríasConceptos_ConvenioCategorías"
'        Me.ConvenioCategoríasConceptosBindingSource.DataSource = Me.ConvenioCategoríasBindingSource1
'        '
'        'ConvenioCategoríasConceptosTableAdapter
'        '
'        Me.ConvenioCategoríasConceptosTableAdapter.ClearBeforeFill = True
'        '
'        'NóminaConceptosTableAdapter
'        '
'        Me.NóminaConceptosTableAdapter.ClearBeforeFill = True
'        '
'        'DataGridViewTextBoxColumn8
'        '
'        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id"
'        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
'        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
'        Me.DataGridViewTextBoxColumn8.ReadOnly = True
'        Me.DataGridViewTextBoxColumn8.Visible = False
'        '
'        'DataGridViewTextBoxColumn9
'        '
'        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idNóminasEmpleado"
'        Me.DataGridViewTextBoxColumn9.HeaderText = "idNóminasEmpleado"
'        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
'        Me.DataGridViewTextBoxColumn9.Visible = False
'        '
'        'DataGridViewTextBoxColumn10
'        '
'        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idNóminasEmpresa"
'        Me.DataGridViewTextBoxColumn10.HeaderText = "idNóminasEmpresa"
'        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
'        Me.DataGridViewTextBoxColumn10.Visible = False
'        '
'        'DataGridViewTextBoxColumn11
'        '
'        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idEmpleado"
'        Me.DataGridViewTextBoxColumn11.HeaderText = "idEmpleado"
'        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
'        Me.DataGridViewTextBoxColumn11.Visible = False
'        '
'        'DataGridViewTextBoxColumn12
'        '
'        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idEmpresa"
'        Me.DataGridViewTextBoxColumn12.HeaderText = "idEmpresa"
'        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
'        Me.DataGridViewTextBoxColumn12.Visible = False
'        '
'        'Denominación
'        '
'        Me.Denominación.DataPropertyName = "Denominación"
'        Me.Denominación.HeaderText = "Denominación"
'        Me.Denominación.Name = "Denominación"
'        Me.Denominación.ReadOnly = True
'        Me.Denominación.Width = 200
'        '
'        'DataGridViewTextBoxColumn13
'        '
'        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FechaInicial"
'        DataGridViewCellStyle100.Format = "d"
'        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle100
'        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Inicial"
'        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
'        '
'        'DataGridViewTextBoxColumn14
'        '
'        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FechaFinal"
'        DataGridViewCellStyle101.Format = "d"
'        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle101
'        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha Final"
'        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
'        '
'        'DataGridViewTextBoxColumn15
'        '
'        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Importe"
'        DataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle102.Format = "N2"
'        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle102
'        Me.DataGridViewTextBoxColumn15.HeaderText = "Importe"
'        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
'        '
'        'FKNóminasDeEmpleadoEmpleadosBindingSource
'        '
'        Me.FKNóminasDeEmpleadoEmpleadosBindingSource.DataMember = "FK_NóminasDeEmpleado_Empleados"
'        Me.FKNóminasDeEmpleadoEmpleadosBindingSource.DataSource = Me.EmpleadosBindingSource
'        '
'        'FKNóminasDeEmpleadoEmpresasBindingSource
'        '
'        Me.FKNóminasDeEmpleadoEmpresasBindingSource.DataMember = "FK_NóminasDeEmpleado_Empresas"
'        Me.FKNóminasDeEmpleadoEmpresasBindingSource.DataSource = Me.EmpresasBindingSource
'        '
'        'DataGridViewTextBoxColumn3
'        '
'        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idEmpleado"
'        Me.DataGridViewTextBoxColumn3.HeaderText = "idEmpleado"
'        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
'        Me.DataGridViewTextBoxColumn3.ReadOnly = True
'        Me.DataGridViewTextBoxColumn3.Visible = False
'        '
'        'idNóminaEmpresa
'        '
'        Me.idNóminaEmpresa.DataPropertyName = "idNóminaEmpresa"
'        Me.idNóminaEmpresa.DataSource = Me.NominasDeEmpresaBindingSource
'        Me.idNóminaEmpresa.DisplayMember = "FechaInicial"
'        Me.idNóminaEmpresa.HeaderText = "Nómina"
'        Me.idNóminaEmpresa.Name = "idNóminaEmpresa"
'        Me.idNóminaEmpresa.ReadOnly = True
'        Me.idNóminaEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
'        Me.idNóminaEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
'        Me.idNóminaEmpresa.ValueMember = "id"
'        '
'        'FechaInicial
'        '
'        Me.FechaInicial.DataPropertyName = "FechaInicial"
'        Me.FechaInicial.HeaderText = "Fecha Inicial"
'        Me.FechaInicial.Name = "FechaInicial"
'        Me.FechaInicial.ReadOnly = True
'        '
'        'FechaFinal
'        '
'        Me.FechaFinal.DataPropertyName = "FechaFinal"
'        Me.FechaFinal.HeaderText = "Fecha Final"
'        Me.FechaFinal.Name = "FechaFinal"
'        Me.FechaFinal.ReadOnly = True
'        '
'        'Bruto
'        '
'        Me.Bruto.DataPropertyName = "Bruto"
'        DataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle103.Format = "N2"
'        Me.Bruto.DefaultCellStyle = DataGridViewCellStyle103
'        Me.Bruto.HeaderText = "Bruto"
'        Me.Bruto.Name = "Bruto"
'        Me.Bruto.ReadOnly = True
'        Me.Bruto.Width = 75
'        '
'        'IRPF
'        '
'        Me.IRPF.DataPropertyName = "IRPF"
'        DataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle104.Format = "N2"
'        Me.IRPF.DefaultCellStyle = DataGridViewCellStyle104
'        Me.IRPF.HeaderText = "IRPF"
'        Me.IRPF.Name = "IRPF"
'        Me.IRPF.ReadOnly = True
'        Me.IRPF.Width = 75
'        '
'        'CuotaSegSoc
'        '
'        Me.CuotaSegSoc.DataPropertyName = "CuotaSegSoc"
'        DataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle105.Format = "N2"
'        Me.CuotaSegSoc.DefaultCellStyle = DataGridViewCellStyle105
'        Me.CuotaSegSoc.HeaderText = "Cuota Seg Soc"
'        Me.CuotaSegSoc.Name = "CuotaSegSoc"
'        Me.CuotaSegSoc.ReadOnly = True
'        Me.CuotaSegSoc.Width = 75
'        '
'        'BaseCCSegsoc
'        '
'        Me.BaseCCSegsoc.DataPropertyName = "BaseCCSegsoc"
'        DataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle106.Format = "N2"
'        Me.BaseCCSegsoc.DefaultCellStyle = DataGridViewCellStyle106
'        Me.BaseCCSegsoc.HeaderText = "Base CC"
'        Me.BaseCCSegsoc.Name = "BaseCCSegsoc"
'        Me.BaseCCSegsoc.ReadOnly = True
'        Me.BaseCCSegsoc.Width = 75
'        '
'        'BaseATyEPSegsoc
'        '
'        Me.BaseATyEPSegsoc.DataPropertyName = "BaseATyEPSegsoc"
'        DataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle107.Format = "N2"
'        Me.BaseATyEPSegsoc.DefaultCellStyle = DataGridViewCellStyle107
'        Me.BaseATyEPSegsoc.HeaderText = "Base AT y EP"
'        Me.BaseATyEPSegsoc.Name = "BaseATyEPSegsoc"
'        Me.BaseATyEPSegsoc.ReadOnly = True
'        Me.BaseATyEPSegsoc.Width = 75
'        '
'        'CuotaSegSocEmpresa
'        '
'        Me.CuotaSegSocEmpresa.DataPropertyName = "CuotaSegSocEmpresa"
'        DataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
'        DataGridViewCellStyle108.Format = "N2"
'        Me.CuotaSegSocEmpresa.DefaultCellStyle = DataGridViewCellStyle108
'        Me.CuotaSegSocEmpresa.HeaderText = "Cuota Seg Soc Empresa"
'        Me.CuotaSegSocEmpresa.Name = "CuotaSegSocEmpresa"
'        Me.CuotaSegSocEmpresa.ReadOnly = True
'        Me.CuotaSegSocEmpresa.Width = 75
'        '
'        'frmEmpleados
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(1445, 825)
'        Me.Controls.Add(Me.EmpleadosBindingNavigator)
'        Me.Controls.Add(Me.TabControl1)
'        Me.Name = "frmEmpleados"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
'        Me.Text = "Empleados"
'        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'        Me.TabControl1.ResumeLayout(False)
'        Me.DatosPersonales.ResumeLayout(False)
'        Me.DatosPersonales.PerformLayout()
'        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.BDMeloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.TiposDocumentoIdentidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.SexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.DatosDomicilio.ResumeLayout(False)
'        Me.DatosDomicilio.PerformLayout()
'        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.TiposVíaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.DatosLaborales.ResumeLayout(False)
'        Me.DatosLaborales.PerformLayout()
'        CType(Me.CNO11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CNO94BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CNAEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.CentrosTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.DatosSegSocial.ResumeLayout(False)
'        Me.DatosSegSocial.PerformLayout()
'        Me.DatosBancarios.ResumeLayout(False)
'        Me.DatosBancarios.PerformLayout()
'        Me.DatosNóminas.ResumeLayout(False)
'        Me.DatosNóminas.PerformLayout()
'        CType(Me.NóminaConceptosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.NóminaConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.FKNóminasDeEmpleadoNominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.NominasDeEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.NóminasEmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.NóminasEmpleadoBindingNavigator.ResumeLayout(False)
'        Me.NóminasEmpleadoBindingNavigator.PerformLayout()
'        CType(Me.NóminasDeEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.NóminasDeEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.EmpleadosBindingNavigator.ResumeLayout(False)
'        Me.EmpleadosBindingNavigator.PerformLayout()
'        CType(Me.FKNominasDeEmpresaEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.ConvenioCategoríasConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.FKNóminasDeEmpleadoEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.FKNóminasDeEmpleadoEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub
'    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
'    Friend WithEvents DatosPersonales As System.Windows.Forms.TabPage
'    Friend WithEvents DatosSegSocial As System.Windows.Forms.TabPage
'    Friend WithEvents DatosDomicilio As System.Windows.Forms.TabPage
'    Friend WithEvents BDMeloDataSet As Nómina.BDMeloDataSet
'    Friend WithEvents TableAdapterManager As Nómina.BDMeloDataSetTableAdapters.TableAdapterManager
'    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
'    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
'    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
'    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents SexosTableAdapter As Nómina.BDMeloDataSetTableAdapters.SexosTableAdapter
'    Friend WithEvents SexosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents TiposVíaTableAdapter As Nómina.BDMeloDataSetTableAdapters.TiposVíaTableAdapter
'    Friend WithEvents TiposVíaBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ProvinciasTableAdapter As Nómina.BDMeloDataSetTableAdapters.ProvinciasTableAdapter
'    Friend WithEvents PaisesBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents PaisesTableAdapter As Nómina.BDMeloDataSetTableAdapters.PaisesTableAdapter
'    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents EmpleadosTableAdapter As Nómina.BDMeloDataSetTableAdapters.EmpleadosTableAdapter
'    Friend WithEvents IdEmpleadoTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents Apellido1TextBox As System.Windows.Forms.TextBox
'    Friend WithEvents Apellido2TextBox As System.Windows.Forms.TextBox
'    Friend WithEvents FechaNacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
'    Friend WithEvents DocumIdentTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiNombreVíaTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiLocalidadTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiCodPostalTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiNúmeroTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiBloqueTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiEscaleraTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiPisoTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DomiPuertaTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DatosLaborales As System.Windows.Forms.TabPage
'    Friend WithEvents NumSegSocialTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents GrupoCotizaciónTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents OcupaciónCotiAT_EPTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents FechaAltaDateTimePicker As System.Windows.Forms.DateTimePicker
'    Friend WithEvents FechaBajaDateTimePicker As System.Windows.Forms.DateTimePicker
'    Friend WithEvents CausaBajaTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents TipoEmpleadoTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents TipoRelLaboralTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents ExcedenteSectorIndustrialTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents AntigüedadTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents SexosComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents TiposDocumentoIdentidadBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents TiposDocumentoIdentidadTableAdapter As Nómina.BDMeloDataSetTableAdapters.TiposDocumentoIdentidadTableAdapter
'    Friend WithEvents TiposDocumentoIdentidadComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents TiposVíaComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents PaisesComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents ProvinciasComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
'    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents EmpresasTableAdapter As Nómina.BDMeloDataSetTableAdapters.EmpresasTableAdapter
'    Friend WithEvents EmpresasComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
'    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConveniosTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConveniosTableAdapter
'    Friend WithEvents CentrosTrabajoBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents CentrosTrabajoTableAdapter As Nómina.BDMeloDataSetTableAdapters.CentrosTrabajoTableAdapter
'    Friend WithEvents CentrosTrabajoComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents ConvenioCategoríasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioCategoríasTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasTableAdapter
'    Friend WithEvents ConvenioCategoríasComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents CNAEBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents CNAETableAdapter As Nómina.BDMeloDataSetTableAdapters.CNAETableAdapter
'    Friend WithEvents CNAEComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents CNO94BindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents CNO94TableAdapter As Nómina.BDMeloDataSetTableAdapters.CNO94TableAdapter
'    Friend WithEvents CNO94ComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents CNO11BindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents CNO11TableAdapter As Nómina.BDMeloDataSetTableAdapters.CNO11TableAdapter
'    Friend WithEvents CNO11ComboBox As System.Windows.Forms.ComboBox
'    Friend WithEvents DatosNóminas As System.Windows.Forms.TabPage
'    Friend WithEvents NóminasDeEmpleadoBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents NóminasDeEmpleadoTableAdapter As Nómina.BDMeloDataSetTableAdapters.NóminasDeEmpleadoTableAdapter
'    Friend WithEvents NóminasDeEmpleadoDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents NominasDeEmpresaBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents NominasDeEmpresaTableAdapter As Nómina.BDMeloDataSetTableAdapters.NominasDeEmpresaTableAdapter
'    Friend WithEvents FKNóminasDeEmpleadoNominasDeEmpresaBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents FKNominasDeEmpresaEmpresasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents NóminasEmpleadoBindingNavigator As System.Windows.Forms.BindingNavigator
'    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
'    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
'    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents DatosBancarios As System.Windows.Forms.TabPage
'    Friend WithEvents BancoCtaTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents BancoDCTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents BancoSucursalTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents BancoEntidadTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents BancoSicaTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents CobraPorBancoCheckBox As System.Windows.Forms.CheckBox
'    Friend WithEvents ConceptosDisponiblesListBox As System.Windows.Forms.ListBox
'    Friend WithEvents ConvenioGruposBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioGruposTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioGruposTableAdapter
'    Friend WithEvents ConvenioCategoríasBindingSource1 As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioCategoríasConceptosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents ConvenioCategoríasConceptosTableAdapter As Nómina.BDMeloDataSetTableAdapters.ConvenioCategoríasConceptosTableAdapter
'    Friend WithEvents ConceptosUsadosListBox As System.Windows.Forms.ListBox
'    Friend WithEvents NóminaConceptosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents NóminaConceptosTableAdapter As Nómina.BDMeloDataSetTableAdapters.NóminaConceptosTableAdapter
'    Friend WithEvents NóminaConceptosDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents Denominación As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents FKNóminasDeEmpleadoEmpleadosBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents FKNóminasDeEmpleadoEmpresasBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents idNóminaEmpresa As System.Windows.Forms.DataGridViewComboBoxColumn
'    Friend WithEvents FechaInicial As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents FechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents Bruto As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents IRPF As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents CuotaSegSoc As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents BaseCCSegsoc As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents BaseATyEPSegsoc As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents CuotaSegSocEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn

'End Class
