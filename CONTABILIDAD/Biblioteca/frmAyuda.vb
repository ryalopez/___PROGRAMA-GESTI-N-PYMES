Public Class frmAyuda

    Private Sub frmAyuda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Para que esto funciones. El sitio Web con la Ayuda tiene que colgar de InetPub/wwwroot

        Dim uriBld As New UriBuilder
        uriBld.Path = "/Ayuda"

        Dim siteUri As Uri = uriBld.Uri
        Me.WebBrowser1.Url = siteUri
        Me.WebBrowser1.Visible = True

        Me.btnAnterior.Enabled = WebBrowser1.CanGoBack
        Me.btnPróximo.Enabled = WebBrowser1.CanGoForward

    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        Me.WebBrowser1.GoBack()

    End Sub

    ' Disables the Back button at the beginning of the navigation history.
    Private Sub webBrowser1_CanGoBackChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles WebBrowser1.CanGoBackChanged

        Me.btnAnterior.Enabled = WebBrowser1.CanGoBack

    End Sub

    Private Sub btnPróximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPróximo.Click

        Me.WebBrowser1.GoForward()

    End Sub

    ' Disables the Forward button at the end of navigation history.
    Private Sub webBrowser1_CanGoForwardChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles WebBrowser1.CanGoForwardChanged

        Me.btnPróximo.Enabled = WebBrowser1.CanGoForward

    End Sub

    Private Sub impPágina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.WebBrowser1.Print()

    End Sub

End Class
