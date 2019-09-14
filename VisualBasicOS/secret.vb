Public Class secret
    Private Sub Secret_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PictureBox1.BackgroundImage = Image.FromFile(".\assets\misc\cp_dance.gif")
        'PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        My.Computer.Audio.Play(".\assets\sounds\pizza.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class