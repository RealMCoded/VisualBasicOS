Public Class TTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(TextBox1.Text)
    End Sub

    Private Sub TTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(" ")
    End Sub
End Class