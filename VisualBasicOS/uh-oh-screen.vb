Public Class uh_oh_screen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OS.Show()
        MsgBox("Session Restored", MsgBoxStyle.Information, "Info")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Session abandoned :(", MsgBoxStyle.Information, "Info")
        OS.Close()
    End Sub

    Private Sub Uh_oh_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Stop()
        My.Computer.Audio.Play(".\assets\sounds\error.wav")
    End Sub
End Class