Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(".\assets\misc\Splash.png")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        'PictureBox1.Hide()
    End Sub
End Class