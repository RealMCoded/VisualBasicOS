Public Class ImgShow
    Private Sub ImgShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(ImgView.imglocation.Text)
        Me.Text = "Image Viewer | " + ImgView.imglocation.Text
    End Sub
End Class