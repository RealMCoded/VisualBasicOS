Public Class ImgView

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        imglocation.Text = "./assets/misc/Splash.png"
        ImgShow.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        imglocation.Text = "./assets/wallpapers/default.png"
        ImgShow.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Things are still being worked on. More images will come back soon!", MsgBoxStyle.Information, "Notice.")
    End Sub
End Class