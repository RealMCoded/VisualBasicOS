Public Class TTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.TextLength > 99 Then
            MsgBox("")
        Else
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(TextBox1.Text)
    End Sub

    Private Sub TTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TTS_LOADMSG.Show()
        'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(" ")
        TTS_LOADMSG.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TextBox1.TextLength
        If TextBox1.TextLength > 99 Then
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
        Else
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
    End Sub
End Class