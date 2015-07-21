
Partial Class relim
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox_ver.Text = Request.Form("inota")
        'Esta es la pagina que configuro que va recibir las variables POST en el archivo donde esta la presentacion lim.swf
        'Con las siguientes lineas paso las variables Post almacenarla en Cookies para poder luego llamarla desde mi pagina donde termina el cuestionario edilim
        'la anteriormente forma descrita fue la unica forma que pude capturar las variables edilim para luego enviarla al servidor y guadar la calficicacion en el servidor
        Response.Cookies("notaedi").Value = Request.Form("inota")
        Response.Cookies("iresul").Value = Request.Form("iresul")
    End Sub
End Class
