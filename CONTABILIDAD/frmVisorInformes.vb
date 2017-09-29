Imports Microsoft.Reporting.WinForms

Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmVisorInformes

    Private Sub FrmVisorInformes_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.Refresh()

    End Sub

    Public Property Informe As String
        Get
            Return Me.ReportViewer1.ReportSource.ToString
        End Get
        Set(value As String)
            Me.ReportViewer1.ReportSource = value
        End Set
    End Property

End Class