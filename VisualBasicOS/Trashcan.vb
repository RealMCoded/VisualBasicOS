﻿Public Class Trashcan
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox1.Text = "/"
        Label1.Hide()
        PictureBox2.Hide()
        MsgBox("Directory '/' Not found! Error 2.", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "/trashcan/" Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
            Label1.Show()
            PictureBox2.Show()
        Else
            Label1.Hide()
            PictureBox2.Hide()
            MsgBox("Directory '" + TextBox1.Text + "' Not found! Error 2.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(".\assets\sounds\trash.wav")
    End Sub

    Private Sub Trashcan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class