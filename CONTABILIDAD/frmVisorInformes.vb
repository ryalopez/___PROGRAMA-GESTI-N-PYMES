Imports System
Imports System.Collections
Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class FrmVisorInformes

    Public Shared TítulosInformes As New Hashtable()
    Sub New(prmClaveDefinición As String, prmDatos As ReportDataSource, prmParámetros As ReportParameterCollection)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Add some elements to the hash table. There are no 
        ' duplicate keys, but some of the values are duplicates.
        TítulosInformes.Clear()
        TítulosInformes.Add("BSS", "K:\Grupo MELO\___PROGRAMA GESTIÓN PYMES\CONTABILIDAD\Informes\Balance de Sumas y Saldos.rdlc")
        TítulosInformes.Add("DIA", "K:\Grupo MELO\___PROGRAMA GESTIÓN PYMES\CONTABILIDAD\informes\Diario.rdlc")
        TítulosInformes.Add("LM", "K:\Grupo MELO\___PROGRAMA GESTIÓN PYMES\CONTABILIDAD\informes\Libro Mayor.rdlc")


        With Listado

            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = TítulosInformes(prmClaveDefinición).ToString
            ''
            '' Asigno los datos
            ''
            .LocalReport.DataSources.Add(prmDatos)
            ''
            '' Asigno colección de paramametros
            ''
            .LocalReport.SetParameters(prmParámetros)

        End With

    End Sub
    Private Sub FrmVisorInformes_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Listado.RefreshReport()

        Catch Ex As Exception

            ' Let the user know what went wrong.
            CBiblioteca.MsgErrorCrítico("No se puede leer el fichero K:\Grupo MELO\___PROGRAMA GESTIÓN PYMES\CONTABILIDAD\informes\Balance Sumas y Saldos.rdlc. " + Ex.Message)

        End Try


    End Sub

End Class