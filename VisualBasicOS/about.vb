﻿Public Class about
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Image.FromFile(".\assets\misc\Splash.png")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Label2.Text = "Version " + OS.Label11.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        secret.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Unable to open desired file from desired location! Error: 4", MsgBoxStyle.Critical, "Error")
    End Sub
End Class