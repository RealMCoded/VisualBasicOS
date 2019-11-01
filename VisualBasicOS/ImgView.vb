Public Class ImgView

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        imglocation.Text = "./assets/misc/Splash.png"
        ImgShow.Show()
    End Sub
End Class