Imports System.Text.RegularExpressions
Imports System.Text

Public Class LimbusSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub LimbusSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub LimbusSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.DIMENSIONAL_PORTAL_UNLOCK = DIMENSIONAL_PORTAL_UNLOCKCheckBox.Checked
        My.Settings.BETWEEN_2COSMOCLEANSE_WAIT_TIME = BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines As New List(Of String)()

        If DIMENSIONAL_PORTAL_UNLOCKCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIMENSIONAL_PORTAL_UNLOCK = false; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus", "DIMENSIONAL_PORTAL_UNLOCK = true; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIMENSIONAL_PORTAL_UNLOCK = true; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus", "DIMENSIONAL_PORTAL_UNLOCK = false; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus"), False)
        End If

        If BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch As Boolean
                BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch = line.Contains("BETWEEN_2COSMOCLEANSE_WAIT_TIME")
                If BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch Then
                    BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.Add("BETWEEN_2COSMOCLEANSE_WAIT_TIME = " + BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text + "; -- day between 2 limbus keyitem  (default 3 days)")
                Else
                    BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub
End Class