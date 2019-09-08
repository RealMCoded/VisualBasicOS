Public Class ImgView
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            PictureBox1.Image = Image.FromFile(".\assets\misc\please1.png")
            Label1.Text = "1/4"
        ElseIf TrackBar1.Value = 1 Then
            PictureBox1.Image = Image.FromFile(".\assets\wallpapers\leaves.jpg")
            Label1.Text = "2/4"
        ElseIf TrackBar1.Value = 2 Then
            PictureBox1.Image = Image.FromFile(".\assets\wallpapers\white-flowers.jpg")
            Label1.Text = "3/4"
        ElseIf TrackBar1.Value = 3 Then
            PictureBox1.Image = Image.FromFile(".\assets\wallpapers\Sand-Dune.jpg")
            Label1.Text = "4/4"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ImgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(".\assets\misc\please1.png")
    End Sub
End Class