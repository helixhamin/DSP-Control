Imports System.Text.RegularExpressions
Imports System.Text

Public Class Coffer_ChestSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub Coffer_ChestSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub Coffer_ChestSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.COFFER_MAX_ILLUSION_TIME = COFFER_MAX_ILLUSION_TIMENumericUpDown.Text
        My.Settings.COFFER_MIN_ILLUSION_TIME = COFFER_MIN_ILLUSION_TIMENumericUpDown.Text
        My.Settings.CHEST_MAX_ILLUSION_TIME = CHEST_MAX_ILLUSION_TIMENumericUpDown.Text
        My.Settings.CHEST_MIN_ILLUSION_TIME = CHEST_MIN_ILLUSION_TIMENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim COFFER_MAX_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim COFFER_MIN_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim CHEST_MAX_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim CHEST_MIN_ILLUSION_TIMEOutputLines As New List(Of String)()

        If COFFER_MAX_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim COFFER_MAX_ILLUSION_TIMEMatch As Boolean
                COFFER_MAX_ILLUSION_TIMEMatch = line.Contains("COFFER_MAX_ILLUSION_TIME")
                If COFFER_MAX_ILLUSION_TIMEMatch Then
                    COFFER_MAX_ILLUSION_TIMEOutputLines.Add("COFFER_MAX_ILLUSION_TIME = " + COFFER_MAX_ILLUSION_TIMENumericUpDown.Text + ";  -- 1 hour")
                Else
                    COFFER_MAX_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, COFFER_MAX_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If COFFER_MIN_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim COFFER_MIN_ILLUSION_TIMEMatch As Boolean
                COFFER_MIN_ILLUSION_TIMEMatch = line.Contains("COFFER_MIN_ILLUSION_TIME")
                If COFFER_MIN_ILLUSION_TIMEMatch Then
                    COFFER_MIN_ILLUSION_TIMEOutputLines.Add("COFFER_MIN_ILLUSION_TIME = " + COFFER_MIN_ILLUSION_TIMENumericUpDown.Text + ";  -- 30 minutes")
                Else
                    COFFER_MIN_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, COFFER_MIN_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CHEST_MAX_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CHEST_MAX_ILLUSION_TIMEMatch As Boolean
                CHEST_MAX_ILLUSION_TIMEMatch = line.Contains("CHEST_MAX_ILLUSION_TIME")
                If CHEST_MAX_ILLUSION_TIMEMatch Then
                    CHEST_MAX_ILLUSION_TIMEOutputLines.Add("CHEST_MAX_ILLUSION_TIME  = " + CHEST_MAX_ILLUSION_TIMENumericUpDown.Text + ";  -- 1 hour")
                Else
                    CHEST_MAX_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CHEST_MAX_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CHEST_MIN_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CHEST_MIN_ILLUSION_TIMEMatch As Boolean
                CHEST_MIN_ILLUSION_TIMEMatch = line.Contains("CHEST_MIN_ILLUSION_TIME")
                If CHEST_MIN_ILLUSION_TIMEMatch Then
                    CHEST_MIN_ILLUSION_TIMEOutputLines.Add("CHEST_MIN_ILLUSION_TIME  = " + CHEST_MIN_ILLUSION_TIMENumericUpDown.Text + ";  -- 30 minutes")
                Else
                    CHEST_MIN_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CHEST_MIN_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub
End Class