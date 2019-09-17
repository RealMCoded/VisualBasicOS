Public Class WallChange
    Private Sub WP1_SLT_CheckedChanged(sender As Object, e As EventArgs) Handles WP1_SLT.CheckedChanged
        If WP1_SLT.Checked = True Then
            OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\white-flowers.jpg")
            OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
            OS.Panel2.BackColor = Color.DodgerBlue
            OS.Label2.Text = "FLW"
        End If
    End Sub

    Private Sub WP2_SLT_CheckedChanged(sender As Object, e As EventArgs) Handles WP2_SLT.CheckedChanged
        If WP2_SLT.Checked = True Then
            OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\Sand-Dune.jpg")
            OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
            OS.Panel2.BackColor = Color.Tan
            OS.Label2.Text = "SND"
        End If
    End Sub

    Private Sub WallChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WP1_IMG.BackgroundImage = Image.FromFile(".\assets\wallpapers\white-flowers.jpg")
        WP2_IMG.BackgroundImage = Image.FromFile(".\assets\wallpapers\Sand-Dune.jpg")
        PictureBox3.BackgroundImage = Image.FromFile(".\assets\wallpapers\leaves.jpg")
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

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\leaves.jpg")
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
            OS.Label5.Text = "D-YES"
        Else
            OS.Label2.Hide()
            OS.Label5.Hide()
            OS.Label7.Hide()
            OS.Label5.Text = "D-NO"
        End If
    End Sub

    Private Sub WP4_SLC_CheckedChanged(sender As Object, e As EventArgs) Handles WP4_SLC.CheckedChanged
        OS.Panel2.BackgroundImage = Image.FromFile(".\assets\wallpapers\default.jpg")
        OS.Panel2.BackgroundImageLayout = ImageLayout.Stretch
        OS.Panel2.BackColor = Color.DodgerBlue
        OS.Label2.Text = "DEF"
    End Sub
End Class