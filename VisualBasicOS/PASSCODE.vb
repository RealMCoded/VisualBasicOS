Public Class PASSCODE
    Private Sub EAR_TEST_PASSCODE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "admin" Then
            MsgBox("Correct! Note: Close the login Window To Close the App!", MsgBoxStyle.Information, "Correct")
            Label4.Text = "Status: Running!"
            OS.Show()
            TextBox2.Enabled = False
            Button1.Enabled = False
        Else
            MsgBox("Incorrect passcode.", MsgBoxStyle.Critical, "Incorrect.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class