
Partial Class edi_ediver
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox_cookie.Text = Request.Cookies("notaedi").Value
        TextBox_iresul.Text = Request.Cookies("iresul").Value
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        If Request.Cookies("notaedi") Is Nothing Then

        Else
            Response.Cookies("notaedi").Value = 0
            Response.Cookies("iresul").Value = 0
        End If
    End Sub
End Class
