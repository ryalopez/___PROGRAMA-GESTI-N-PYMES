Imports Microsoft.Reporting.WinForms


Public Class FrmVisorInformes

    Private Sub FrmVisorInformes_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
        'Me.ReportViewer1.RefreshReport()

    End Sub

    Private Function ValidarCertificado(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

End Class