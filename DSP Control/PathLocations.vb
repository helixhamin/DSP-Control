Imports System.IO

Public Class PathLocationsListBox

    Private Sub PathLocationsListBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If File.Exists(DSPPathTextBox.Text + "\conf\map_darkstar.conf") Then
            My.Settings.Save()
        Else
            MsgBox("You need to declare your DSP path.")
            e.Cancel = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub PathLocations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DSPPathTextBox.Text = My.Settings.DSPPath
        AshitaPathTextBox.Text = My.Settings.AshitaPath
        POLPathTextBox.Text = My.Settings.POLPath
    End Sub

    Private Sub DSPPathButton_Click(sender As Object, e As EventArgs) Handles DSPPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            DSPPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub AshitaPathButton_Click(sender As Object, e As EventArgs) Handles AshitaPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            AshitaPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub POLPathButton_Click(sender As Object, e As EventArgs) Handles POLPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            POLPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub
End Class