Public Class WallChange
    Private Sub WP1_SLT_CheckedChanged(sender As Object, e As EventArgs) Handles WP1_SLT.CheckedChanged
        If WP1_SLT.Checked = True Then
            OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\white-flowers.png")
            OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
            OS.Panel2.BackColor = Color.DodgerBlue
            OS.Label2.Text = "FLW"
        End If
    End Sub

    Private Sub WP2_SLT_CheckedChanged(sender As Object, e As EventArgs) Handles WP2_SLT.CheckedChanged
        If WP2_SLT.Checked = True Then
            OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\Sand-Dune.png")
            OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
            OS.Panel2.BackColor = Color.Tan
            OS.Label2.Text = "SND"
        End If
    End Sub

    Private Sub WallChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WP2_SLT.Hide()
        WP1_IMG.BackgroundImage = Image.FromFile(".\assets\wallpapers\default.png")
        WP2_IMG.BackgroundImage = Image.FromFile(".\assets\wallpapers\white-flowers.png")
        PictureBox3.BackgroundImage = Image.FromFile(".\assets\wallpapers\leaves.png")
        PictureBox1.BackgroundImage = Image.FromFile(".\assets\wallpapers\Sand-Dune.png")
        OS.Label2.Show()
        If OS.Label2.Text = "FLW" Then
            WP1_SLT.Checked = True
        ElseIf OS.Label2.Text = "SND" Then
            WP2_SLT.Checked = True
        ElseIf OS.Label2.Text = "LVE" Then
            RadioButton3.Checked = True
        ElseIf OS.Label2.Text = "DEF" Then
            WP4_SLC.Checked = True
        End If
        If OS.Label5.Text = "D-YES" Then
            OS.Label2.Show()
            CheckBox2.Checked = True
        Else
            OS.Label2.Hide()
            CheckBox2.Checked = False
        End If
        If OS.Label20.Text = "Full" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\leaves.png")
        OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
        OS.Panel2.BackColor = Color.Green
        OS.Label2.Text = "LVE"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'MsgBox("if you hacked the executable to see the transparency, your out of luck...")

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            OS.Label2.Show()
            OS.Label5.Show()
            OS.Label7.Show()
            OS.Label11.Show()
            OS.Label13.Show()
            OS.Label14.Show()
            OS.Label5.Text = "D-YES"
        Else
            OS.Label2.Hide()
            OS.Label5.Hide()
            OS.Label7.Hide()
            OS.Label11.Hide()
            OS.Label13.Hide()
            OS.Label14.Hide()
            OS.Label5.Text = "D-NO"
        End If
    End Sub

    Private Sub WP4_SLC_CheckedChanged(sender As Object, e As EventArgs) Handles WP4_SLC.CheckedChanged
        OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\default.png")
        OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
        OS.Panel2.BackColor = Color.DeepSkyBlue
        OS.Label2.Text = "DEF"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            OS.Label20.Text = "Full"
            OS.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            OS.WindowState = FormWindowState.Maximized
            Me.TopMost = True
            Me.TopMost = False
        Else
            OS.Label20.Text = "Norm"
            OS.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            OS.WindowState = FormWindowState.Normal
            Me.TopMost = True
            Me.TopMost = False
        End If
    End Sub
End Class