Public Class SettingsShortcuts
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WallChange.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WallChange.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("This Feature is still in development. Please check back later. Error: 001", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("This Feature is still in development. Please check back later. Error: 001", MsgBoxStyle.Critical, "Error")
    End Sub
End Class