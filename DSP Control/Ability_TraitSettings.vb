Imports System.Text.RegularExpressions
Imports System.Text

Public Class Ability_TraitSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub Ability_TraitSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub Ability_TraitSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.SCAVENGE_RATE = SCAVENGE_RATENumericUpDown.Text
        My.Settings.STATUS_RESIST_MULTIPLIER = STATUS_RESIST_MULTIPLIERNumericUpDown.Text
        My.Settings.CIRCLE_DURATION = CIRCLE_DURATIONNumericUpDown.Text
        My.Settings.CIRCLE_KILLER_EFFECT = CIRCLE_KILLER_EFFECTNumericUpDown.Text
        My.Settings.KILLER_EFFECT = KILLER_EFFECTNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim SCAVENGE_RATEOutputLines As New List(Of String)()
        Dim STATUS_RESIST_MULTIPLIEROutputLines As New List(Of String)()
        Dim CIRCLE_DURATIONOutputLines As New List(Of String)()
        Dim CIRCLE_KILLER_EFFECTOutputLines As New List(Of String)()
        Dim KILLER_EFFECTOutputLines As New List(Of String)()

        If SCAVENGE_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SCAVENGE_RATEMatch As Boolean
                SCAVENGE_RATEMatch = line.Contains("SCAVENGE_RATE")
                If SCAVENGE_RATEMatch Then
                    SCAVENGE_RATEOutputLines.Add("SCAVENGE_RATE = " + SCAVENGE_RATENumericUpDown.Text + "; --The chance of obtaining an item when you use the Ranger job ability Scavenge.  Do not set above 1!")
                Else
                    SCAVENGE_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SCAVENGE_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If STATUS_RESIST_MULTIPLIERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim STATUS_RESIST_MULTIPLIERMatch As Boolean
                STATUS_RESIST_MULTIPLIERMatch = line.Contains("STATUS_RESIST_MULTIPLIER")
                If STATUS_RESIST_MULTIPLIERMatch Then
                    STATUS_RESIST_MULTIPLIEROutputLines.Add("STATUS_RESIST_MULTIPLIER = " + STATUS_RESIST_MULTIPLIERNumericUpDown.Text + "; -- Sets the strength of status resist traits.")
                Else
                    STATUS_RESIST_MULTIPLIEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, STATUS_RESIST_MULTIPLIEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If CIRCLE_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CIRCLE_DURATIONMatch As Boolean
                CIRCLE_DURATIONMatch = line.Contains("CIRCLE_DURATION")
                If CIRCLE_DURATIONMatch Then
                    CIRCLE_DURATIONOutputLines.Add("CIRCLE_DURATION = " + CIRCLE_DURATIONNumericUpDown.Text + "; -- Sets the duration of circle effects, in seconds. Retail is 5 minutes.")
                Else
                    CIRCLE_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CIRCLE_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CIRCLE_KILLER_EFFECTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CIRCLE_KILLER_EFFECTMatch As Boolean
                CIRCLE_KILLER_EFFECTMatch = line.Contains("CIRCLE_KILLER_EFFECT")
                If CIRCLE_KILLER_EFFECTMatch Then
                    CIRCLE_KILLER_EFFECTOutputLines.Add("CIRCLE_KILLER_EFFECT = " + CIRCLE_KILLER_EFFECTNumericUpDown.Text + "; -- Intimidation percentage granted by circle effects. (made up number)")
                Else
                    CIRCLE_KILLER_EFFECTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CIRCLE_KILLER_EFFECTOutputLines.ToArray(), Encoding.UTF8)
        End If

        If KILLER_EFFECTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim KILLER_EFFECTMatch As Boolean
                Dim CIRCLEMatch As Boolean
                KILLER_EFFECTMatch = line.Contains("KILLER_EFFECT")
                CIRCLEMatch = line.Contains("CIRCLE")
                If KILLER_EFFECTMatch And Not CIRCLEMatch Then
                    KILLER_EFFECTOutputLines.Add("KILLER_EFFECT = " + KILLER_EFFECTNumericUpDown.Text + "; -- Intimidation percentage from killer job traits.")
                Else
                    KILLER_EFFECTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, KILLER_EFFECTOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub
End Class