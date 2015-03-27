Imports System.Text.RegularExpressions
Imports System.Text

Public Class MaterialCollectingsettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub MaterialCollectingsettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub MaterialCollectingsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.HARVESTING_BREAK_CHANCE = HARVESTING_BREAK_CHANCENumericUpDown.Text
        My.Settings.EXCAVATION_BREAK_CHANCE = EXCAVATION_BREAK_CHANCENumericUpDown.Text
        My.Settings.LOGGING_BREAK_CHANCE = LOGGING_BREAK_CHANCENumericUpDown.Text
        My.Settings.MINING_BREAK_CHANCE = MINING_BREAK_CHANCENumericUpDown.Text
        My.Settings.HARVESTING_RATE = HARVESTING_RATENumericUpDown.Text
        My.Settings.EXCAVATION_RATE = EXCAVATION_RATENumericUpDown.Text
        My.Settings.LOGGING_RATE = LOGGING_RATENumericUpDown.Text
        My.Settings.MINING_RATE = MINING_RATENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim HARVESTING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim EXCAVATION_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim LOGGING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim MINING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim HARVESTING_RATEOutputLines As New List(Of String)()
        Dim EXCAVATION_RATEOutputLines As New List(Of String)()
        Dim LOGGING_RATEOutputLines As New List(Of String)()
        Dim MINING_RATEOutputLines As New List(Of String)()

        If HARVESTING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim HARVESTING_BREAK_CHANCEMatch As Boolean
                HARVESTING_BREAK_CHANCEMatch = line.Contains("HARVESTING_BREAK_CHANCE")
                If HARVESTING_BREAK_CHANCEMatch Then
                    HARVESTING_BREAK_CHANCEOutputLines.Add("HARVESTING_BREAK_CHANCE = " + HARVESTING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the sickle to break during harvesting.  Set between 0 and 1.")
                Else
                    HARVESTING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, HARVESTING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If EXCAVATION_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXCAVATION_BREAK_CHANCEMatch As Boolean
                EXCAVATION_BREAK_CHANCEMatch = line.Contains("EXCAVATION_BREAK_CHANCE")
                If EXCAVATION_BREAK_CHANCEMatch Then
                    EXCAVATION_BREAK_CHANCEOutputLines.Add("EXCAVATION_BREAK_CHANCE = " + EXCAVATION_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the pickaxe to break during excavation.  Set between 0 and 1.")
                Else
                    EXCAVATION_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXCAVATION_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LOGGING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LOGGING_BREAK_CHANCEMatch As Boolean
                LOGGING_BREAK_CHANCEMatch = line.Contains("LOGGING_BREAK_CHANCE")
                If LOGGING_BREAK_CHANCEMatch Then
                    LOGGING_BREAK_CHANCEOutputLines.Add("LOGGING_BREAK_CHANCE    = " + LOGGING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the hatchet to break during logging.  Set between 0 and 1.")
                Else
                    LOGGING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LOGGING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If MINING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MINING_BREAK_CHANCEMatch As Boolean
                MINING_BREAK_CHANCEMatch = line.Contains("MINING_BREAK_CHANCE")
                If MINING_BREAK_CHANCEMatch Then
                    MINING_BREAK_CHANCEOutputLines.Add("MINING_BREAK_CHANCE     = " + MINING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the pickaxe to break during mining.  Set between 0 and 1.")
                Else
                    MINING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MINING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If HARVESTING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim HARVESTING_RATEMatch As Boolean
                HARVESTING_RATEMatch = line.Contains("HARVESTING_RATE")
                If HARVESTING_RATEMatch Then
                    HARVESTING_RATEOutputLines.Add("HARVESTING_RATE         = " + HARVESTING_RATENumericUpDown.Text + "; -- % chance to recieve an item from haresting.  Set between 0 and 1.")
                Else
                    HARVESTING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, HARVESTING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If EXCAVATION_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXCAVATION_RATEMatch As Boolean
                EXCAVATION_RATEMatch = line.Contains("EXCAVATION_RATE")
                If EXCAVATION_RATEMatch Then
                    EXCAVATION_RATEOutputLines.Add("EXCAVATION_RATE         = " + EXCAVATION_RATENumericUpDown.Text + "; -- % chance to recieve an item from excavation.  Set between 0 and 1.")
                Else
                    EXCAVATION_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXCAVATION_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LOGGING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LOGGING_RATEMatch As Boolean
                LOGGING_RATEMatch = line.Contains("LOGGING_RATE")
                If LOGGING_RATEMatch Then
                    LOGGING_RATEOutputLines.Add("LOGGING_RATE            = " + LOGGING_RATENumericUpDown.Text + "; -- % chance to recieve an item from logging.  Set between 0 and 1.")
                Else
                    LOGGING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LOGGING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If MINING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MINING_RATEMatch As Boolean
                MINING_RATEMatch = line.Contains("MINING_RATE")
                If MINING_RATEMatch Then
                    MINING_RATEOutputLines.Add("MINING_RATE             = " + MINING_RATENumericUpDown.Text + "; -- % chance to recieve an item from mining.  Set between 0 and 1.")
                Else
                    MINING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MINING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If
    End Sub
End Class