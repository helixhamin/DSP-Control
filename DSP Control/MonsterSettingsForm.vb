Imports System.Text.RegularExpressions
Imports System.Text

Public Class MonsterSettingsForm

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub MonsterSettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub MonsterSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        all_mobs_gil_bonusNumericUpDown.Text = My.Settings.all_mobs_gil_bonus
        max_gil_bonusNumericUpDown.Text = My.Settings.max_gil_bonus
        Battle_cap_tweakNumericUpDown.Text = My.Settings.Battle_cap_tweak
        mob_speed_modNumericUpDown.Text = My.Settings.mob_speed_mod
        NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text = My.Settings.NORMAL_MOB_MAX_LEVEL_RANGE_MIN
        NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text = My.Settings.NORMAL_MOB_MAX_LEVEL_RANGE_MAX
        LandKingSystem_NQNumericUpDown.Text = My.Settings.LandKingSystem_NQ
        LandKingSystem_HQNumericUpDown.Text = My.Settings.LandKingSystem_HQ
    End Sub

    Private Sub MonsterMultipliersButton_Click(sender As Object, e As EventArgs) Handles MonsterMultipliersButton.Click
        MonsterMultipliers.Activate()
        MonsterMultipliers.Show()
    End Sub

    Private Sub all_mobs_gil_bonusNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles all_mobs_gil_bonusNumericUpDown.ValueChanged
        If all_mobs_gil_bonusNumericUpDown.Value > max_gil_bonusNumericUpDown.Value Then
            all_mobs_gil_bonusNumericUpDown.Value = max_gil_bonusNumericUpDown.Value
        End If
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim all_mobs_gil_bonusOutputLines As New List(Of String)()
        Dim max_gil_bonusOutputLines As New List(Of String)()
        Dim Battle_cap_tweakOutputLines As New List(Of String)()
        Dim mob_speed_modOutputLines As New List(Of String)()
        Dim NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines As New List(Of String)()
        Dim NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines As New List(Of String)()
        Dim LandKingSystem_NQOutputLines As New List(Of String)()
        Dim LandKingSystem_HQOutputLines As New List(Of String)()

        If all_mobs_gil_bonusNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim all_mobs_gil_bonusMatch As Boolean
                all_mobs_gil_bonusMatch = line.Contains("all_mobs_gil_bonus:")
                If all_mobs_gil_bonusMatch Then
                    all_mobs_gil_bonusOutputLines.Add("all_mobs_gil_bonus: " + all_mobs_gil_bonusNumericUpDown.Text)
                Else
                    all_mobs_gil_bonusOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, all_mobs_gil_bonusOutputLines.ToArray(), Encoding.UTF8)
        End If

        If max_gil_bonusNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim max_gil_bonusMatch As Boolean
                max_gil_bonusMatch = line.Contains("max_gil_bonus:")
                If max_gil_bonusMatch Then
                    max_gil_bonusOutputLines.Add("max_gil_bonus: " + max_gil_bonusNumericUpDown.Text)
                Else
                    max_gil_bonusOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, max_gil_bonusOutputLines.ToArray(), Encoding.UTF8)
        End If

        If Battle_cap_tweakNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim Battle_cap_tweakMatch As Boolean
                Battle_cap_tweakMatch = line.Contains("Battle_cap_tweak:")
                If Battle_cap_tweakMatch Then
                    Battle_cap_tweakOutputLines.Add("Battle_cap_tweak: " + Battle_cap_tweakNumericUpDown.Text)
                Else
                    Battle_cap_tweakOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, Battle_cap_tweakOutputLines.ToArray(), Encoding.UTF8)
        End If

        If mob_speed_modNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_speed_modMatch As Boolean
                mob_speed_modMatch = line.Contains("mob_speed_mod")
                If mob_speed_modMatch Then
                    mob_speed_modOutputLines.Add("mob_speed_mod: " + mob_speed_modNumericUpDown.Text)
                Else
                    mob_speed_modOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_speed_modOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch As Boolean
                NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch = line.Contains("NORMAL_MOB_MAX_LEVEL_RANGE_MIN")
                If NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch Then
                    NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.Add("NORMAL_MOB_MAX_LEVEL_RANGE_MIN = " + NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text + "; -- Lower Bound of Max Level Range for Normal Mobs (0 = Uncapped)")
                Else
                    NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch As Boolean
                NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch = line.Contains("NORMAL_MOB_MAX_LEVEL_RANGE_MAX")
                If NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch Then
                    NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.Add("NORMAL_MOB_MAX_LEVEL_RANGE_MAX = " + NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text + "; -- Upper Bound of Max Level Range for Normal Mobs (0 = Uncapped)")
                Else
                    NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LandKingSystem_NQNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LandKingSystem_NQMatch As Boolean
                LandKingSystem_NQMatch = line.Contains("LandKingSystem_NQ")
                If LandKingSystem_NQMatch Then
                    LandKingSystem_NQOutputLines.Add("LandKingSystem_NQ = " + LandKingSystem_NQNumericUpDown.Text + ";")
                Else
                    LandKingSystem_NQOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LandKingSystem_NQOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LandKingSystem_HQNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LandKingSystem_HQMatch As Boolean
                LandKingSystem_HQMatch = line.Contains("LandKingSystem_HQ")
                If LandKingSystem_HQMatch Then
                    LandKingSystem_HQOutputLines.Add("LandKingSystem_HQ = " + LandKingSystem_HQNumericUpDown.Text + ";")
                Else
                    LandKingSystem_HQOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LandKingSystem_HQOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub
End Class