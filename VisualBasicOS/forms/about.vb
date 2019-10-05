Public Class about
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Image.FromFile(".\assets\misc\Splash.png")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        secret.Show()
    End Sub
End Class