Public Class Formreporte
    Private Sub Formreporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.tbnombrecomercial.Text
        Label2.Text = Form1.tbnit.Text
        Label3.Text = Form1.tbdireccion.Text
    End Sub
End Class