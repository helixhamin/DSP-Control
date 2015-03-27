Imports System.Text.RegularExpressions
Imports System.Text

Public Class Quest_MissionSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub Quest_MissionSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub Quest_MissionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.DEBUG_MODE = DEBUG_MODECheckBox.Checked
        My.Settings.OldSchoolG1 = OldSchoolG1CheckBox.Checked
        My.Settings.OldSchoolG2 = OldSchoolG2CheckBox.Checked
        My.Settings.WSNM_LEVEL = WSNM_LEVELNumericUpDown.Text
        My.Settings.WSNM_SKILL_LEVEL = WSNM_SKILL_LEVELNumericUpDown.Text
        My.Settings.AF1_QUEST_LEVEL = AF1_QUEST_LEVELNumericUpDown.Text
        My.Settings.AF2_QUEST_LEVEL = AF2_QUEST_LEVELNumericUpDown.Text
        My.Settings.AF3_QUEST_LEVEL = AF3_QUEST_LEVELNumericUpDown.Text
        My.Settings.AF1_FAME = AF1_FAMENumericUpDown.Text
        My.Settings.AF2_FAME = AF2_FAMENumericUpDown.Text
        My.Settings.AF3_FAME = AF3_FAMENumericUpDown.Text
        My.Settings.QM_RESET_TIME = QM_RESET_TIMENumericUpDown.Text
        My.Settings.FrigiciteDuration = FrigiciteDurationNumericUpDown.Text

        If OldSchoolG2CheckBox.Checked = True Then
            FrigiciteDurationNumericUpDown.Enabled = True
        Else
            FrigiciteDurationNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim WSNM_LEVELOutputLines As New List(Of String)()
        Dim WSNM_SKILL_LEVELOutputLines As New List(Of String)()
        Dim AF1_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF2_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF3_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF1_FAMEOutputLines As New List(Of String)()
        Dim AF2_FAMEOutputLines As New List(Of String)()
        Dim AF3_FAMEOutputLines As New List(Of String)()
        Dim QM_RESET_TIMEOutputLines As New List(Of String)()
        Dim FrigiciteDurationOutputLines As New List(Of String)()

        If DEBUG_MODECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DEBUG_MODE = 0; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests).", "DEBUG_MODE = 1; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests)."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DEBUG_MODE = 1; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests).", "DEBUG_MODE = 0; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests)."), False)
        End If

        If OldSchoolG1CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG1 = false; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method.", "OldSchoolG1 = true; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG1 = true; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method.", "OldSchoolG1 = false; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method."), False)
        End If

        If OldSchoolG2CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG2 = false; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it.", "OldSchoolG2 = true; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG2 = true; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it.", "OldSchoolG2 = false; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it."), False)
        End If

        If WSNM_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WSNM_LEVELMatch As Boolean
                WSNM_LEVELMatch = line.Contains("WSNM_LEVEL")
                If WSNM_LEVELMatch Then
                    WSNM_LEVELOutputLines.Add("WSNM_LEVEL = " + WSNM_LEVELNumericUpDown.Text + "; -- Min Level to get WSNM Quests")
                Else
                    WSNM_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WSNM_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WSNM_SKILL_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WSNM_SKILL_LEVELMatch As Boolean
                WSNM_SKILL_LEVELMatch = line.Contains("WSNM_SKILL_LEVEL")
                If WSNM_SKILL_LEVELMatch Then
                    WSNM_SKILL_LEVELOutputLines.Add("WSNM_SKILL_LEVEL = " + WSNM_SKILL_LEVELNumericUpDown.Text + ";")
                Else
                    WSNM_SKILL_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WSNM_SKILL_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF1_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF1_QUEST_LEVELMatch As Boolean
                AF1_QUEST_LEVELMatch = line.Contains("AF1_QUEST_LEVEL")
                If AF1_QUEST_LEVELMatch Then
                    AF1_QUEST_LEVELOutputLines.Add("AF1_QUEST_LEVEL = " + AF1_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF1 quest")
                Else
                    AF1_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF1_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF2_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF2_QUEST_LEVELMatch As Boolean
                AF2_QUEST_LEVELMatch = line.Contains("AF2_QUEST_LEVEL")
                If AF2_QUEST_LEVELMatch Then
                    AF2_QUEST_LEVELOutputLines.Add("AF2_QUEST_LEVEL = " + AF2_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF2 quest")
                Else
                    AF2_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF2_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF3_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF3_QUEST_LEVELMatch As Boolean
                AF3_QUEST_LEVELMatch = line.Contains("AF3_QUEST_LEVEL")
                If AF3_QUEST_LEVELMatch Then
                    AF3_QUEST_LEVELOutputLines.Add("AF3_QUEST_LEVEL = " + AF3_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF3 quest")
                Else
                    AF3_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF3_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF1_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF1_FAMEMatch As Boolean
                AF1_FAMEMatch = line.Contains("AF1_FAME")
                If AF1_FAMEMatch Then
                    AF1_FAMEOutputLines.Add("AF1_FAME = " + AF1_FAMENumericUpDown.Text + "; -- base fame for completing an AF1 quest")
                Else
                    AF1_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF1_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF2_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF2_FAMEMatch As Boolean
                AF2_FAMEMatch = line.Contains("AF2_FAME")
                If AF2_FAMEMatch Then
                    AF2_FAMEOutputLines.Add("AF2_FAME = " + AF2_FAMENumericUpDown.Text + "; -- base fame for completing an AF2 quest")
                Else
                    AF2_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF2_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF3_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF3_FAMEMatch As Boolean
                AF3_FAMEMatch = line.Contains("AF3_FAME")
                If AF3_FAMEMatch Then
                    AF3_FAMEOutputLines.Add("AF3_FAME = " + AF3_FAMENumericUpDown.Text + "; -- base fame for completing an AF3 quest")
                Else
                    AF3_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF3_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If QM_RESET_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim QM_RESET_TIMEMatch As Boolean
                QM_RESET_TIMEMatch = line.Contains("QM_RESET_TIME")
                If QM_RESET_TIMEMatch Then
                    QM_RESET_TIMEOutputLines.Add("QM_RESET_TIME = " + QM_RESET_TIMENumericUpDown.Text + "; -- Default time (in seconds) you have from killing ???-pop mission NMs to click again and get key item, until ??? resets.")
                Else
                    QM_RESET_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, QM_RESET_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If FrigiciteDurationNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim FrigiciteDurationMatch As Boolean
                FrigiciteDurationMatch = line.Contains("FrigiciteDuration")
                If FrigiciteDurationMatch Then
                    FrigiciteDurationOutputLines.Add("FrigiciteDuration = " + FrigiciteDurationNumericUpDown.Text + "; -- When OldSChoolG2 is enabled, this is the time (in seconds) you have from killing Boreal NMs to click the ""???"" target.")
                Else
                    FrigiciteDurationOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, FrigiciteDurationOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub WSNM_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles WSNM_LEVELNumericUpDown.ValueChanged
        If WSNM_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            WSNM_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF1_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles AF1_QUEST_LEVELNumericUpDown.ValueChanged
        If AF1_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF1_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF2_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles AF2_QUEST_LEVELNumericUpDown.ValueChanged
        If AF2_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF2_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF3_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles AF3_QUEST_LEVELNumericUpDown.ValueChanged
        If AF3_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF3_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub OldSchoolG2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles OldSchoolG2CheckBox.CheckedChanged
        If OldSchoolG2CheckBox.Checked = True Then
            FrigiciteDurationNumericUpDown.Enabled = True
        Else
            FrigiciteDurationNumericUpDown.Enabled = False
        End If
    End Sub
End Class