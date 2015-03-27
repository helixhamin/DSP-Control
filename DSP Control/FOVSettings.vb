Imports System.Text.RegularExpressions
Imports System.Text

Public Class FOVSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub FOVSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub FOVSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.fov_party_gap_penalties = fov_party_gap_penaltiesCheckBox.Checked
        My.Settings.fov_allow_alliance = fov_allow_allianceCheckBox.Checked
        My.Settings.REGIME_WAIT = REGIME_WAITCheckBox.Checked
        My.Settings.FIELD_MANUALS = FIELD_MANUALSCheckBox.Checked
        My.Settings.LOW_LEVEL_REGIME = LOW_LEVEL_REGIMECheckBox.Checked
        My.Settings.GROUNDS_TOMES = GROUNDS_TOMESCheckBox.Checked
        My.Settings.EXP_RATEFOV = EXP_RATEFOVNumericUpDown.Text
        My.Settings.TABS_RATE = TABS_RATENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim EXP_RATEFOVOutputLines As New List(Of String)()
        Dim TABS_RATEOutputLines As New List(Of String)()

        If fov_party_gap_penaltiesCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_party_gap_penalties: 0", "fov_party_gap_penalties: 1"), False)
        ElseIf fov_party_gap_penaltiesCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_party_gap_penalties: 1", "fov_party_gap_penalties: 0"), False)
        End If

        If fov_allow_allianceCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_allow_alliance: 0", "fov_allow_alliance: 1"), False)
        ElseIf fov_allow_allianceCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_allow_alliance: 1", "fov_allow_alliance: 0"), False)
        End If

        If REGIME_WAITCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("REGIME_WAIT = 0; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time.", "REGIME_WAIT = 1; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time."), False)
        ElseIf REGIME_WAITCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("REGIME_WAIT = 1; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time.", "REGIME_WAIT = 0; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time."), False)
        End If

        If FIELD_MANUALSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FIELD_MANUALS = 0; -- Enables Fields of Valor manuals", "FIELD_MANUALS = 1; -- Enables Fields of Valor manuals"), False)
        ElseIf FIELD_MANUALSCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FIELD_MANUALS = 1; -- Enables Fields of Valor manuals", "FIELD_MANUALS = 0; -- Enables Fields of Valor manuals"), False)
        End If

        If LOW_LEVEL_REGIMECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("LOW_LEVEL_REGIME = 0; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas.", "LOW_LEVEL_REGIME = 1; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas."), False)
        ElseIf LOW_LEVEL_REGIMECheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("LOW_LEVEL_REGIME = 1; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas.", "LOW_LEVEL_REGIME = 0; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas."), False)
        End If

        If GROUNDS_TOMESCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("GROUNDS_TOMES = 0; -- Enables Grounds of Valor tomes", "GROUNDS_TOMES = 1; -- Enables Grounds of Valor tomes"), False)
        ElseIf GROUNDS_TOMESCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("GROUNDS_TOMES = 1; -- Enables Grounds of Valor tomes", "GROUNDS_TOMES = 0; -- Enables Grounds of Valor tomes"), False)
        End If

        If EXP_RATEFOVNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXP_RATEFOVMatch As Boolean
                EXP_RATEFOVMatch = line.Contains("EXP_RATE")
                If EXP_RATEFOVMatch Then
                    EXP_RATEFOVOutputLines.Add("EXP_RATE   = " + EXP_RATEFOVNumericUpDown.Text + "; -- Multiplies exp earned from fov.")
                Else
                    EXP_RATEFOVOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXP_RATEFOVOutputLines.ToArray(), Encoding.UTF8)
        End If

        If TABS_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim TABS_RATEMatch As Boolean
                TABS_RATEMatch = line.Contains("TABS_RATE")
                If TABS_RATEMatch Then
                    TABS_RATEOutputLines.Add("TABS_RATE  = " + TABS_RATENumericUpDown.Text + "; -- Multiplies tabs earned from fov.")
                Else
                    TABS_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, TABS_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If
        
    End Sub
End Class