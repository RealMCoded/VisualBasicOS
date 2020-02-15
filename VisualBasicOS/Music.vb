Public Class Music
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'MsgBox("Song list: pizza, Slot1, Slot2, Slot3.")
        MusList.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "pizza" Or TextBox1.Text = "Slot1" Or TextBox1.Text = "Slot2" Or TextBox1.Text = "Slot3" Then
            My.Computer.Audio.Play(".\assets\sounds\music\" + TextBox1.Text + ".wav")
        Else
            MsgBox("Invalid Audio.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "bicycle" Or TextBox1.Text = "Slot1" Or TextBox1.Text = "Slot2" Or TextBox1.Text = "Slot3" Then
            My.Computer.Audio.Play(".\assets\sounds\music\" + TextBox1.Text + ".wav", AudioPlayMode.BackgroundLoop)
        Else
            MsgBox("Invalid Audio.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class