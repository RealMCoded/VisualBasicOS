Public Class Music
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Song list: pizza, Slot1, Slot2, Slot3.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "pizza" Then
            My.Computer.Audio.Play(".\assets\sounds\music\" + TextBox1.Text + ".wav")
        Else
            MsgBox("Invalid Audio.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
    End Sub
End Class