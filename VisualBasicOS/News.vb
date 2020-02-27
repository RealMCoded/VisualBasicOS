Public Class News
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub News_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class