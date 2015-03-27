Public Class LobbyLogs

    Dim LobbyLogsLocation = My.Settings.DSPPath + "\log\login-server.log"

    Private Sub LobbyLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LobbyLogsRichTextBox.Text = System.IO.File.ReadAllText(LobbyLogsLocation)
    End Sub

    Private Sub LobbyLogsRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LobbyLogsRichTextBox.MouseDoubleClick
        LobbyLogsRichTextBox.Text = System.IO.File.ReadAllText(LobbyLogsLocation)
    End Sub

    Private Sub LobbyLogsRichTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles LobbyLogsRichTextBox.TextChanged
        Dim ln As Integer = LobbyLogsRichTextBox.Text.Length
        LobbyLogsRichTextBox.SelectionStart = ln
        LobbyLogsRichTextBox.ScrollToCaret()
    End Sub
End Class