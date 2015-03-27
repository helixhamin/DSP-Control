Public Class GameLogs

    Dim GameLogsLocation = My.Settings.DSPPath + "\log\map-server.log"

    Private Sub GameLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameLogsRichTextBox.Text = System.IO.File.ReadAllText(GameLogsLocation)
    End Sub

    Private Sub GameLogsRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GameLogsRichTextBox.MouseDoubleClick
        GameLogsRichTextBox.Text = System.IO.File.ReadAllText(GameLogsLocation)
    End Sub

    Private Sub GameLogsRichTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles GameLogsRichTextBox.TextChanged
        Dim ln As Integer = GameLogsRichTextBox.Text.Length
        GameLogsRichTextBox.SelectionStart = ln
        GameLogsRichTextBox.ScrollToCaret()
    End Sub

End Class