Imports CrystalDecisions.CrystalReports.Engine
Imports Biblioteca

Public Class frmVisorInformes

    Public Informe As ReportDocument
    Public NombreInforme As String
    Public TipoOrigenDatos As eTipoOrigenDatos = eTipoOrigenDatos.ODBC
    Public ADODataSet As DataSet = Nothing
    Public Filtro As String
    Public Tipo As eTipoListadoContable
    Public NombreEmpresa As String
    Public Formulario As eForms = eForms.BLANCO

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmVisorInformes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim PathInformes As String = Application.StartupPath & "\Informes\"
        Dim ODBCInformes As String = Application.StartupPath & "\Datos\DatosChurrería.dsn"

        Me.NombreInforme = PathInformes & Me.NombreInforme

        Informe = New ReportDocument

        Try

            Informe.Load(NombreInforme, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            If TipoOrigenDatos = eTipoOrigenDatos.ODBC Then
                Informe.SetDataSource(ODBCInformes)
            Else
                Informe.SetDataSource(ADODataSet)
            End If

            Informe.SetParameterValue("prmNombreEmpresa", Me.NombreEmpresa)

            If Me.Filtro.Length > 0 Then

                Informe.SetParameterValue("prmEjercicio", Me.Filtro)

            End If
            If Me.Tipo = Nothing Then

                Me.Tipo = CType(eTipoListadoClientes.Todos, eTipoListadoContable)

            End If
            Select Case Me.Tipo

                Case CType(eTipoListadoClientes.Todos, eTipoListadoContable)

                    Informe.RecordSelectionFormula = ""
                    'Informe.SetParameterValue("prmTipoListado", "TODOS")
                    Exit Select

                Case eTipoListadoContable.Balance

                    'Informe.RecordSelectionFormula = ""
                    'Informe.SetParameterValue("prmTipoListado", "TODOS")
                    Exit Select

                Case CType(eTipoListadoClientes.Activos, eTipoListadoContable)

                    Informe.RecordSelectionFormula = "{@Baja} = 'ACTIVO'"
                    Informe.SetParameterValue("prmTipoListado", "ACTIVOS")
                    Exit Select

                Case CType(eTipoListadoClientes.Baja, eTipoListadoContable)

                    Informe.RecordSelectionFormula = "{@Baja} = 'BAJA'"
                    Informe.SetParameterValue("prmTipoListado", "BAJA")
                    Exit Select

                Case CType(eTipoListadoClientes.ActivosFactura, eTipoListadoContable)

                    Informe.RecordSelectionFormula = "{@Baja} = 'ACTIVO' and " +
                        "{@Factura} = 'FACTURA'"
                    Informe.SetParameterValue("prmTipoListado", "ACTIVOS - FACTURA")
                    Exit Select

                Case CType(eTipoListadoClientes.ActivosRecibo, eTipoListadoContable)

                    Informe.RecordSelectionFormula = "{@Baja} = 'ACTIVO' and " +
                        "{@Factura} = 'RECIBO'"
                    Informe.SetParameterValue("prmTipoListado", "ACTIVOS - RECIBO")
                    Exit Select

                Case Else


            End Select
            Dim msg As String = ""

            If Me.Formulario = eForms.ALBARÁN Then
                msg = "Este informe se imprime en formulario Recibos y Albaranes"
            ElseIf Me.Formulario = eForms.FACTURA Then
                msg = "Este informe se imprime en formulario Facturas"
            ElseIf Me.Formulario = eForms.RECIBO Then
                msg = "Este informe se imprime en formulario Recibos y Albaranes"
            ElseIf Me.Formulario = eForms.BLANCO Then

                If Me.Informe.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4 Then
                    ' A4
                    msg = "Este informe se imprime en papel A4 (grande)"
                ElseIf Me.Informe.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5 Then
                    ' A5
                    msg = "Este informe se imprime en papel A5 (pequeño)"
                Else
                    ' No controlado
                    'msg = "No se conoce el tamaño de papel en el que se imprime este informe"
                End If

            Else
                msg = "Este informe se imprime en formulario DESCONOCIDO"
            End If

            If msg <> "" Then MsgInformativo(msg)

            Me.Visor.ReportSource = Me.Informe
            Me.Visor.Show()

        Catch ex As Exception

            MsgBox(ex.InnerException.Message)

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles Visor.

        Me.Close()

    End Sub

    Friend Sub MsgInformativo(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Friend Sub MsgErrorCrítico(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.Título)

    End Sub

    Friend Function MsgPregunta(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

    Friend Function MsgAdvertencia(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.Título)

    End Function

End Class