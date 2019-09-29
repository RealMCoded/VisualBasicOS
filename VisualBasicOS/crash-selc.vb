Public Class crash_selc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        My.Computer.Audio.Play("")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OS.Hide()
        uh_oh_screen.Show()
        Me.Hide()
    End Sub
End Class