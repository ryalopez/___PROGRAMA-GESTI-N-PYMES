﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopiarBaseDeDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepararExcelDelBBVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadranteHorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluarAmortizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KkkkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTABILIDADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEntradaAsientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAsientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnalítica = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanciaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PréstamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFacturasClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFacturasProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNóminas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEmpresasYCentros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvenios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BDContabilidadGMELO = New Contabilidad.BDContabilidadGMELO()
        Me.AsientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsientosTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.AsientosTableAdapter()
        Me.TableAdapterManager = New Contabilidad.BDContabilidadGMELOTableAdapters.TableAdapterManager()
        Me.FacturasRecibidasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter()
        Me.FacturasRecibidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New Contabilidad.BDContabilidadGMELOTableAdapters.CuentasTableAdapter()
        Me.mnuPrincipal.SuspendLayout()
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir, Me.mnuCopia, Me.CONTABILIDADToolStripMenuItem, Me.FinanciaciónToolStripMenuItem, Me.mnuClientes1, Me.mnuEmpleados1, Me.mnuAcercaDe})
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
        Me.mnuSalir.Image = Global.Contabilidad.My.Resources.Resources.HomeHS
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(32, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'mnuCopia
        '
        Me.mnuCopia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopiarBaseDeDatos, Me.SepararExcelDelBBVAToolStripMenuItem, Me.CuadranteHorasToolStripMenuItem, Me.EvaluarAmortizacionesToolStripMenuItem, Me.KkkkToolStripMenuItem})
        Me.mnuCopia.Name = "mnuCopia"
        Me.mnuCopia.Size = New System.Drawing.Size(88, 24)
        Me.mnuCopia.Text = "Utilidades"
        '
        'mnuCopiarBaseDeDatos
        '
        Me.mnuCopiarBaseDeDatos.Name = "mnuCopiarBaseDeDatos"
        Me.mnuCopiarBaseDeDatos.Size = New System.Drawing.Size(238, 26)
        Me.mnuCopiarBaseDeDatos.Text = "Copiar Base de Datos"
        '
        'SepararExcelDelBBVAToolStripMenuItem
        '
        Me.SepararExcelDelBBVAToolStripMenuItem.Name = "SepararExcelDelBBVAToolStripMenuItem"
        Me.SepararExcelDelBBVAToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.SepararExcelDelBBVAToolStripMenuItem.Text = "Separar Excel del BBVA"
        '
        'CuadranteHorasToolStripMenuItem
        '
        Me.CuadranteHorasToolStripMenuItem.Name = "CuadranteHorasToolStripMenuItem"
        Me.CuadranteHorasToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.CuadranteHorasToolStripMenuItem.Text = "Cuadrante Horas"
        Me.CuadranteHorasToolStripMenuItem.ToolTipText = "Prepara una hoja Excel con Empreados vs Clientes"
        '
        'EvaluarAmortizacionesToolStripMenuItem
        '
        Me.EvaluarAmortizacionesToolStripMenuItem.Name = "EvaluarAmortizacionesToolStripMenuItem"
        Me.EvaluarAmortizacionesToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.EvaluarAmortizacionesToolStripMenuItem.Text = "Evaluar amortizaciones"
        Me.EvaluarAmortizacionesToolStripMenuItem.ToolTipText = "Realiza el cálculo de los gastos anuales de amortización"
        '
        'KkkkToolStripMenuItem
        '
        Me.KkkkToolStripMenuItem.Name = "KkkkToolStripMenuItem"
        Me.KkkkToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.KkkkToolStripMenuItem.Text = "kkkk"
        '
        'CONTABILIDADToolStripMenuItem
        '
        Me.CONTABILIDADToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEntradaAsientos, Me.mnuAsientos, Me.mnuCuentas, Me.mnuAnalítica})
        Me.CONTABILIDADToolStripMenuItem.Name = "CONTABILIDADToolStripMenuItem"
        Me.CONTABILIDADToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.CONTABILIDADToolStripMenuItem.Text = "CONTABILIDAD"
        '
        'mnuEntradaAsientos
        '
        Me.mnuEntradaAsientos.Name = "mnuEntradaAsientos"
        Me.mnuEntradaAsientos.Size = New System.Drawing.Size(195, 26)
        Me.mnuEntradaAsientos.Text = "Entrada Asientos"
        '
        'mnuAsientos
        '
        Me.mnuAsientos.Name = "mnuAsientos"
        Me.mnuAsientos.Size = New System.Drawing.Size(195, 26)
        Me.mnuAsientos.Text = "Diario"
        '
        'mnuCuentas
        '
        Me.mnuCuentas.Name = "mnuCuentas"
        Me.mnuCuentas.Size = New System.Drawing.Size(195, 26)
        Me.mnuCuentas.Text = "Cuentas"
        '
        'mnuAnalítica
        '
        Me.mnuAnalítica.Name = "mnuAnalítica"
        Me.mnuAnalítica.Size = New System.Drawing.Size(195, 26)
        Me.mnuAnalítica.Text = "Analítica"
        '
        'FinanciaciónToolStripMenuItem
        '
        Me.FinanciaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PréstamosToolStripMenuItem})
        Me.FinanciaciónToolStripMenuItem.Name = "FinanciaciónToolStripMenuItem"
        Me.FinanciaciónToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.FinanciaciónToolStripMenuItem.Text = "FINANCIACIÓN"
        '
        'PréstamosToolStripMenuItem
        '
        Me.PréstamosToolStripMenuItem.Name = "PréstamosToolStripMenuItem"
        Me.PréstamosToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PréstamosToolStripMenuItem.Text = "Préstamos"
        '
        'mnuClientes1
        '
        Me.mnuClientes1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuFacturasClientes, Me.mnuProveedores, Me.mnuFacturasProveedores})
        Me.mnuClientes1.Name = "mnuClientes1"
        Me.mnuClientes1.Size = New System.Drawing.Size(118, 24)
        Me.mnuClientes1.Text = "FACTURACIÓN"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(223, 26)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuFacturasClientes
        '
        Me.mnuFacturasClientes.Name = "mnuFacturasClientes"
        Me.mnuFacturasClientes.Size = New System.Drawing.Size(223, 26)
        Me.mnuFacturasClientes.Text = "Facturas Clientes"
        '
        'mnuProveedores
        '
        Me.mnuProveedores.Name = "mnuProveedores"
        Me.mnuProveedores.Size = New System.Drawing.Size(223, 26)
        Me.mnuProveedores.Text = "Proveedores"
        Me.mnuProveedores.ToolTipText = "Datos de proveedores"
        '
        'mnuFacturasProveedores
        '
        Me.mnuFacturasProveedores.Name = "mnuFacturasProveedores"
        Me.mnuFacturasProveedores.Size = New System.Drawing.Size(223, 26)
        Me.mnuFacturasProveedores.Text = "Facturas Proveedores"
        '
        'mnuEmpleados1
        '
        Me.mnuEmpleados1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEmpleados, Me.mnuNóminas, Me.ToolStripMenuItem1, Me.mnuEmpresasYCentros, Me.ToolStripMenuItem2, Me.mnuConvenios})
        Me.mnuEmpleados1.Name = "mnuEmpleados1"
        Me.mnuEmpleados1.Size = New System.Drawing.Size(148, 24)
        Me.mnuEmpleados1.Text = "RR HH y NÓMINAS"
        Me.mnuEmpleados1.ToolTipText = "Gestión de Empleados de la Empresa"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(212, 26)
        Me.mnuEmpleados.Text = "Empleados"
        '
        'mnuNóminas
        '
        Me.mnuNóminas.Name = "mnuNóminas"
        Me.mnuNóminas.Size = New System.Drawing.Size(212, 26)
        Me.mnuNóminas.Text = "Nóminas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuEmpresasYCentros
        '
        Me.mnuEmpresasYCentros.Name = "mnuEmpresasYCentros"
        Me.mnuEmpresasYCentros.Size = New System.Drawing.Size(212, 26)
        Me.mnuEmpresasYCentros.Text = "Empresas y Centros"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuConvenios
        '
        Me.mnuConvenios.Name = "mnuConvenios"
        Me.mnuConvenios.Size = New System.Drawing.Size(212, 26)
        Me.mnuConvenios.Text = "Convenios"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(87, 24)
        Me.mnuAcercaDe.Text = "&Acerca de"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BDContabilidadGMELO
        '
        Me.BDContabilidadGMELO.DataSetName = "BDContabilidadGMELO"
        Me.BDContabilidadGMELO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsientosBindingSource
        '
        Me.AsientosBindingSource.DataMember = "Asientos"
        Me.AsientosBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'AsientosTableAdapter
        '
        Me.AsientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosTableAdapter = Nothing
        Me.TableAdapterManager.AsientosTableAdapter = Me.AsientosTableAdapter
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
        Me.TableAdapterManager.CuentasProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.FacturasEmitidas1TableAdapter = Nothing
        Me.TableAdapterManager.FacturasEmitidasTableAdapter = Nothing
        Me.TableAdapterManager.FacturasRecibidasTableAdapter = Me.FacturasRecibidasTableAdapter
        Me.TableAdapterManager.FormasPagoTableAdapter = Nothing
        Me.TableAdapterManager.LíneasDiarioTableAdapter = Nothing
        Me.TableAdapterManager.LíneasFacturaEmitidaTableAdapter = Nothing
        Me.TableAdapterManager.LíneasMayorTableAdapter = Nothing
        Me.TableAdapterManager.NóminaConceptosTableAdapter = Nothing
        Me.TableAdapterManager.NóminasDeEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.NominasDeEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.NóminasTableAdapter = Nothing
        Me.TableAdapterManager.PaisesTableAdapter = Nothing
        Me.TableAdapterManager.PerdidasyGananciasSeccionesTableAdapter = Nothing
        Me.TableAdapterManager.PérdidasyGananciasTableAdapter = Nothing
        Me.TableAdapterManager.PoblacionesTableAdapter = Nothing
        Me.TableAdapterManager.PréstamosLargoPlazoTableAdapter = Nothing
        Me.TableAdapterManager.PréstamosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
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
        'FacturasRecibidasTableAdapter
        '
        Me.FacturasRecibidasTableAdapter.ClearBeforeFill = True
        '
        'FacturasRecibidasBindingSource
        '
        Me.FacturasRecibidasBindingSource.DataMember = "FacturasRecibidas"
        Me.FacturasRecibidasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.BDContabilidadGMELO
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
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
        CType(Me.BDContabilidadGMELO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasRecibidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClientes1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpleados1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuCopiarBaseDeDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepararExcelDelBBVAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuadranteHorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluarAmortizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONTABILIDADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAsientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAnalítica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFacturasClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNóminas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEmpresasYCentros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuConvenios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BDContabilidadGMELO As BDContabilidadGMELO
    Friend WithEvents mnuFacturasProveedores As ToolStripMenuItem
    Friend WithEvents mnuProveedores As ToolStripMenuItem
    Friend WithEvents KkkkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsientosBindingSource As BindingSource
    Friend WithEvents AsientosTableAdapter As BDContabilidadGMELOTableAdapters.AsientosTableAdapter
    Friend WithEvents TableAdapterManager As BDContabilidadGMELOTableAdapters.TableAdapterManager
    Friend WithEvents FacturasRecibidasTableAdapter As BDContabilidadGMELOTableAdapters.FacturasRecibidasTableAdapter
    Friend WithEvents FacturasRecibidasBindingSource As BindingSource
    Friend WithEvents mnuEntradaAsientos As ToolStripMenuItem
    Friend WithEvents FinanciaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PréstamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As BDContabilidadGMELOTableAdapters.CuentasTableAdapter
End Class
