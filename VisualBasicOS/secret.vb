﻿Public Class secret
    Private Sub Secret_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PictureBox1.BackgroundImage = Image.FromFile(".\assets\misc\cp_dance.gif")
        'PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Timer1.Start()
        My.Computer.Audio.Play(".\assets\sounds\music\bicycle.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Secret_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        My.Computer.Audio.Stop()
    End Sub
End Class