Imports System.Text.RegularExpressions
Imports System.Text

Public Class ConfigFormExpansions

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim LoginConfFile = My.Settings.DSPPath + "\conf\login_darkstar.conf"
    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub ConfigFormExpansions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.ENABLE_COP = COPCheckBox.Checked
        My.Settings.ENABLE_TOAU = TOAUCheckBox.Checked
        My.Settings.ENABLE_WOTG = WOTGCheckBox.Checked
        My.Settings.ENABLE_ACP = ACPCheckBox.Checked
        My.Settings.ENABLE_AMK = AMKCheckBox.Checked
        My.Settings.ENABLE_ASA = ASACheckBox.Checked
        My.Settings.ENABLE_ABYSSEA = ABYSSEACheckBox.Checked
        My.Settings.ENABLE_SOA = SOACheckBox.Checked
        My.Settings.RESTRICT_BY_EXPANSION = RESTRICT_BY_EXPANSIONCheckBox.Checked
        My.Settings.USE_ADOULIN_WEAPON_SKILL_CHANGES = USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked
    End Sub

    Private Sub ConfigFormExpansions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ExpansionSettingsApply_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ExpansionSettingsApply_Click(sender As Object, e As EventArgs) Handles ExpansionSettingsApply.Click
        Dim COPB As String
        Dim TOAUB As String
        Dim WOTGB As String
        Dim ACPB As String
        Dim AMKB As String
        Dim ASAB As String
        Dim ABYSSEAB As String
        Dim SOAB As String

        If COPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP     = 0;", "ENABLE_COP     = 1;"), False)
            COPB = 1
        ElseIf COPCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP     = 1;", "ENABLE_COP     = 0;"), False)
            COPB = 0
        End If

        If TOAUCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_TOAU    = 0;", "ENABLE_TOAU    = 1;"), False)
            TOAUB = 1
        ElseIf COPCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_TOAU    = 1;", "ENABLE_TOAU    = 0;"), False)
            TOAUB = 0
        End If

        If WOTGCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_WOTG    = 0;", "ENABLE_WOTG    = 1;"), False)
            WOTGB = 1
        ElseIf WOTGCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_WOTG    = 1;", "ENABLE_WOTG    = 0;"), False)
            WOTGB = 0
        End If

        If ACPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ACP     = 0;", "ENABLE_ACP     = 1;"), False)
            ACPB = 1
        ElseIf ACPCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ACP     = 1;", "ENABLE_ACP     = 0;"), False)
            ACPB = 0
        End If

        If AMKCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_AMK     = 0;", "ENABLE_AMK     = 1;"), False)
            AMKB = 1
        ElseIf AMKCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_AMK     = 1;", "ENABLE_AMK     = 0;"), False)
            AMKB = 0
        End If

        If ASACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ASA     = 0;", "ENABLE_ASA     = 1;"), False)
            ASAB = 1
        ElseIf ASACheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ASA     = 1;", "ENABLE_ASA     = 0;"), False)
            ASAB = 0
        End If

        If ABYSSEACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ABYSSEA = 0;", "ENABLE_ABYSSEA = 1;"), False)
            ABYSSEAB = 1
        ElseIf ABYSSEACheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ABYSSEA = 1;", "ENABLE_ABYSSEA = 0;"), False)
            ABYSSEAB = 0
        End If

        If SOACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_SOA     = 0;", "ENABLE_SOA     = 1;"), False)
            SOAB = 1
        ElseIf SOACheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_SOA     = 1;", "ENABLE_SOA     = 0;"), False)
            SOAB = 0
        End If

        If COPCheckBox.Checked = True And TOAUCheckBox.Checked = True And WOTGCheckBox.Checked = True And ACPCheckBox.Checked = True And AMKCheckBox.Checked = True And ASACheckBox.Checked = True And ABYSSEACheckBox.Checked = True And SOACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 1;", "RESTRICT_BY_EXPANSION = 0;"), False)
            RESTRICT_BY_EXPANSIONCheckBox.Checked = False
        Else
            If RESTRICT_BY_EXPANSIONCheckBox.Checked = True Then
                My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 0;", "RESTRICT_BY_EXPANSION = 1;"), False)
            ElseIf RESTRICT_BY_EXPANSIONCheckBox.Checked = False Then
                My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 1;", "RESTRICT_BY_EXPANSION = 0;"), False)
            End If
        End If

        Dim LoginExpansionControl As String
        LoginExpansionControl = 2 + (COPB * 4) + (TOAUB * 8) + (WOTGB * 16) + (ACPB * 32) + (AMKB * 64) + (ASAB * 128) + (ABYSSEAB * 256) + (ABYSSEAB * 512) + (ABYSSEAB * 1024) + (SOAB * 2048)

        Dim expansionsLoginOutputLines As New List(Of String)()
        'Handles Login conf expansion
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim expansionsLoginMatch As Boolean
                expansionsLoginMatch = line.Contains("expansions:")
                If expansionsLoginMatch Then
                    ' Replace line with string
                    expansionsLoginOutputLines.Add("expansions: " + LoginExpansionControl)
                Else
                    expansionsLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, expansionsLoginOutputLines.ToArray(), Encoding.UTF8)

        If CoP_Battle_capCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 0", "CoP_Battle_cap: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 1", "CoP_Battle_cap: 0"), False)
        End If

        If ENABLE_COP_ZONE_CAPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap"), False)
        End If

        If USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        End If

    End Sub

    Private Sub COPCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles COPCheckBox.CheckedChanged
        If COPCheckBox.Checked = True Then
            CoP_Battle_capCheckBox.Enabled = True
            ENABLE_COP_ZONE_CAPCheckBox.Enabled = True
        Else
            CoP_Battle_capCheckBox.Enabled = False
            ENABLE_COP_ZONE_CAPCheckBox.Enabled = False
        End If
    End Sub
End Class
