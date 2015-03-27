Imports System.Text.RegularExpressions
Imports System.Text

Public Class CharacterSettingsForm

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub CharacterSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.MAX_LEVEL = MAX_LEVELNumericUpDown.Text
        My.Settings.speed_mod = speed_modNumericUpDown.Text
        My.Settings.level_sync_enable = level_sync_enableCheckBox.Checked
        My.Settings.all_jobs_widescan = all_jobs_widescanCheckBox.Checked
        My.Settings.max_merit_points = max_merit_pointsNumericUpDown.Text
        My.Settings.yell_cooldown = yell_cooldownNumericUpDown.Text
    End Sub

    Private Sub CharacterSettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim MAX_LEVELOutputLines As New List(Of String)()
        Dim speed_modOutputLines As New List(Of String)()
        Dim yell_cooldownOutputLines As New List(Of String)()

        'Handles Maximum player level
        If MAX_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MAX_LEVELMatch As Boolean
                Dim NORMAL_MOB_MAX_LEVELMatch As Boolean
                MAX_LEVELMatch = line.Contains("MAX_LEVEL")
                NORMAL_MOB_MAX_LEVELMatch = line.Contains("NORMAL_MOB")
                If MAX_LEVELMatch And Not NORMAL_MOB_MAX_LEVELMatch Then
                    MAX_LEVELOutputLines.Add("MAX_LEVEL = " + MAX_LEVELNumericUpDown.Text + "; -- Level max of the server, lowers the attainable cap by disabling Limit Break quests.")
                Else
                    MAX_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MAX_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles player movement speed
        If speed_modNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim speed_modMatch As Boolean
                Dim mob_speed_modMatch As Boolean
                speed_modMatch = line.Contains("speed_mod:")
                mob_speed_modMatch = line.Contains("mob_speed_mod:")
                If speed_modMatch And Not mob_speed_modMatch Then
                    speed_modOutputLines.Add("speed_mod: " + speed_modNumericUpDown.Text)
                Else
                    speed_modOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, speed_modOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles yell timer
        If yell_cooldownNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim yell_cooldownMatch As Boolean
                yell_cooldownMatch = line.Contains("yell_cooldown:")
                If yell_cooldownMatch Then
                    yell_cooldownOutputLines.Add("yell_cooldown: " + yell_cooldownNumericUpDown.Text)
                Else
                    yell_cooldownOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, yell_cooldownOutputLines.ToArray(), Encoding.UTF8)
        End If

        If max_merit_pointsNumericUpDown.Value = 30 Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("max_merit_points: 10", "max_merit_points: 30"), False)
        ElseIf max_merit_pointsNumericUpDown.Value = 10 Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("max_merit_points: 30", "max_merit_points: 10"), False)
        End If

        If level_sync_enableCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("level_sync_enable: 0", "level_sync_enable: 1"), False)
        ElseIf level_sync_enableCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("level_sync_enable: 1", "level_sync_enable: 0"), False)
        End If

        If all_jobs_widescanCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("all_jobs_widescan: 0", "all_jobs_widescan: 1"), False)
        ElseIf all_jobs_widescanCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("all_jobs_widescan: 1", "all_jobs_widescan: 0"), False)
        End If

    End Sub

    Private Sub ExperienceRatesButton_Click(sender As Object, e As EventArgs) Handles ExperienceRatesButton.Click
        ExperienceRates.Activate()
        ExperienceRates.Show()
    End Sub

    Private Sub PlayerMultipliersButton_Click(sender As Object, e As EventArgs) Handles PlayerMultipliersButton.Click
        PlayerMultipliers.Activate()
        PlayerMultipliers.Show()
    End Sub

    Private Sub StartingPlayerSettingButton_Click(sender As Object, e As EventArgs) Handles StartingPlayerSettingButton.Click
        StartingPlayerSettings.Activate()
        StartingPlayerSettings.Show()
    End Sub

    Private Sub FoVButton_Click(sender As Object, e As EventArgs) Handles FoVButton.Click
        FOVSettings.Activate()
        FOVSettings.Show()
    End Sub

    Private Sub CraftandSkillButton_Click(sender As Object, e As EventArgs) Handles CraftandSkillButton.Click
        CraftingandSkillupsettings.Activate()
        CraftingandSkillupsettings.Show()
    End Sub
End Class