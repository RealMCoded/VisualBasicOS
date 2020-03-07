﻿Public Class OS
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles AMB.Click
        'MsgBox("This Feature is still in development. Please check back later. Error: 001", MsgBoxStyle.Critical, "Error")
        If Label14.Text = "M-Close" Then
            Panel3.Show()
            Label14.Text = "M-Open"
        ElseIf Label14.Text = "M-Open" Then
            Panel3.Hide()
            Label14.Text = "M-Close"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.WindowState = FormWindowState.Maximized
        Label2.Hide()
        Label5.Hide()
        Label7.Hide()
        Label11.Hide()
        Label13.Hide()
        Label14.Hide()
        Panel3.Hide()
        'Panel2.BackgroundImage = Image.FromFile(".\assets\misc\missing.png")
        Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\default.png")
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        'AMB.BackgroundImage = Image.FromFile(".\assets\misc\missing.png")
        AMB.BackgroundImage = Image.FromFile(".\assets\misc\AppMenuButton.png")
        AMB.BackgroundImageLayout = ImageLayout.Stretch
        Sidebar.BackgroundImage = Image.FromFile(".\assets\misc\Sidebar.png")
        Sidebar.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BackColor = Color.DeepSkyBlue
        My.Computer.Audio.Play(".\assets\sounds\startup.wav")
        TimeUpdater.Start()
        'MsgBox("Welcome! You may notice some things aren't finished/Non Existant/Buggy. This is normal. Become a Early Tester to get more Builds before anyone else does!", MsgBoxStyle.Information, "Welcome To Visual Basic OS!")
    End Sub

    Private Sub TimeUpdater_Tick(sender As Object, e As EventArgs) Handles TimeUpdater.Tick
        WinClock.Text = My.Computer.Clock.LocalTime
    End Sub
    'Discord! App code starts
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://discord.gg/sXwFzJj")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("https://discord.gg/sXwFzJj")
    End Sub
    'Discord! App Code Ends
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Fact_TXT.Click
        Dim rn As Random
        Dim Troll As Integer
        rn = New Random
        Troll = rn.Next(1, 4)
        If Troll = 1 Then
            MsgBox("The Background Changer worked on the first try when i coded it (probably because most of the code is the same as the old switcher :P)", MsgBoxStyle.Information, "VBOS Fact")
        ElseIf Troll = 2 Then
            MsgBox("The Version Of VBOS you are running is " + Label11.Text, MsgBoxStyle.Information, "VBOS Fact")
        ElseIf Troll = 3 Then
            MsgBox("You Can Modify The Sounds, Wallpapers, and Other Assets! Insert A Random Sound And Rename the new file to one of the sound names! (You Can Do The Same For The Wallpapers and Other Assets!)", MsgBoxStyle.Information, "VBOS Fact")
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles Fact_ICO.Click
        Dim rn As Random
        Dim Troll As Integer
        rn = New Random
        Troll = rn.Next(1, 4)
        If Troll = 1 Then
            MsgBox("The Background Changer worked on the first try when i coded it (probably because most of the code is the same as the old switcher :P)", MsgBoxStyle.Information, "VBOS Fact")
        ElseIf Troll = 2 Then
            MsgBox("The Version Of VBOS you are running is " + Label11.Text, MsgBoxStyle.Information, "VBOS Fact")
        ElseIf Troll = 3 Then
            MsgBox("You Can Modify The Sounds, Wallpapers, and Other Assets! Insert A Random Sound And Rename the new file to one of the sound names! (You Can Do The Same For The Wallpapers and Other Assets!)", MsgBoxStyle.Information, "VBOS Fact")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        about.Show()

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SettingsShortcuts.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        SettingsShortcuts.Show()
    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        'uh_oh_screen.Show()
        NewCrash.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        uh_oh_screen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ImgView_ICO_Click(sender As Object, e As EventArgs) Handles ImgView_ICO.Click
        ImgView.Show()
    End Sub

    Private Sub ImgView_LAB_Click(sender As Object, e As EventArgs) Handles ImgView_LAB.Click
        ImgView.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Trashcan.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Trashcan.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TTS.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TTS.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Music.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sidebar_Click(sender As Object, e As EventArgs) Handles Sidebar.Click
        If Label13.Text = "S-Open" Then
            Sidebar.BackgroundImage = Image.FromFile(".\assets\misc\SidebarClosed.png")
            Label12.Hide()
            Button2.Hide()
            Label17.Hide()
            Label18.Hide()
            Label13.Text = "S-Close"
        ElseIf Label13.Text = "S-Close" Then
            Sidebar.BackgroundImage = Image.FromFile(".\assets\misc\Sidebar.png")
            Label12.Show()
            Button2.Show()
            Label17.Show()
            Label13.Text = "S-Open"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("This Feature is still in development. Please check back later. Error: 001", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If My.Computer.Network.IsAvailable Then
            'MsgBox("You need a valid internet connection to view the news feed! Error 3.", MsgBoxStyle.Critical, "Couldn't connect!")
            News.Show()
        Else
            MsgBox("You need a valid internet connection to view the news feed! Error 3.", MsgBoxStyle.Critical, "Couldn't connect!")
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        If My.Computer.Network.IsAvailable Then
            News.Show()
        Else
            MsgBox("You need a valid internet connection to view the news feed! Error 3.", MsgBoxStyle.Critical, "Couldn't connect!")
        End If
    End Sub
End Class
