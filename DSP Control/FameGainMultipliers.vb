Imports System.Text.RegularExpressions
Imports System.Text

Public Class FameGainMultipliers

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub FameGainMultipliers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub FameGainMultipliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.SAN_FAME = SAN_FAMENumericUpDown.Text
        My.Settings.BAS_FAME = BAS_FAMENumericUpDown.Text
        My.Settings.WIN_FAME = WIN_FAMENumericUpDown.Text
        My.Settings.NORG_FAME = NORG_FAMENumericUpDown.Text
        My.Settings.JEUNO_FAME = JEUNO_FAMENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim SAN_FAMEOutputLines As New List(Of String)()
        Dim BAS_FAMEOutputLines As New List(Of String)()
        Dim WIN_FAMEOutputLines As New List(Of String)()
        Dim NORG_FAMEOutputLines As New List(Of String)()
        Dim JEUNO_FAMEOutputLines As New List(Of String)()

        If SAN_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SAN_FAMEMatch As Boolean
                SAN_FAMEMatch = line.Contains("SAN_FAME")
                If SAN_FAMEMatch Then
                    SAN_FAMEOutputLines.Add("SAN_FAME   = " + SAN_FAMENumericUpDown.Text + "; -- Multiplies fame earned from San d'Oria quests.")
                Else
                    SAN_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SAN_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If BAS_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BAS_FAMEMatch As Boolean
                BAS_FAMEMatch = line.Contains("BAS_FAME")
                If BAS_FAMEMatch Then
                    BAS_FAMEOutputLines.Add("BAS_FAME   = " + BAS_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Bastok quests.")
                Else
                    BAS_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BAS_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WIN_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WIN_FAMEMatch As Boolean
                WIN_FAMEMatch = line.Contains("WIN_FAME")
                If WIN_FAMEMatch Then
                    WIN_FAMEOutputLines.Add("WIN_FAME   = " + WIN_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Windurst quests.")
                Else
                    WIN_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WIN_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORG_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORG_FAMEMatch As Boolean
                NORG_FAMEMatch = line.Contains("NORG_FAME")
                If NORG_FAMEMatch Then
                    NORG_FAMEOutputLines.Add("NORG_FAME  = " + NORG_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Norg and Tenshodo quests.")
                Else
                    NORG_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORG_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If JEUNO_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim JEUNO_FAMEMatch As Boolean
                JEUNO_FAMEMatch = line.Contains("JEUNO_FAME")
                If JEUNO_FAMEMatch Then
                    JEUNO_FAMEOutputLines.Add("JEUNO_FAME = " + JEUNO_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Jeuno quests.")
                Else
                    JEUNO_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, JEUNO_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub
End Class