Imports System.Text.RegularExpressions
Imports System.Text

Public Class DynamisSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub DynamisSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub DynamisSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.FREE_COP_DYNAMIS = FREE_COP_DYNAMISCheckBox.Checked
        My.Settings.BETWEEN_2DYNA_WAIT_TIME = BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text
        My.Settings.DYNA_LEVEL_MIN = DYNA_LEVEL_MINNumericUpDown.Text
        My.Settings.TIMELESS_HOURGLASS_COST = TIMELESS_HOURGLASS_COSTNumericUpDown.Text
        My.Settings.CURRENCY_EXCHANGE_RATE = CURRENCY_EXCHANGE_RATENumericUpDown.Text
        My.Settings.RELIC_2ND_UPGRADE_WAIT_TIME = RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text
        My.Settings.RELIC_3RD_UPGRADE_WAIT_TIME = RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim BETWEEN_2DYNA_WAIT_TIMEOutputLines As New List(Of String)()
        Dim DYNA_LEVEL_MINOutputLines As New List(Of String)()
        Dim TIMELESS_HOURGLASS_COSTOutputLines As New List(Of String)()
        Dim CURRENCY_EXCHANGE_RATEOutputLines As New List(Of String)()
        Dim RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines As New List(Of String)()
        Dim RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines As New List(Of String)()

        If FREE_COP_DYNAMISCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FREE_COP_DYNAMIS = 0 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)", "FREE_COP_DYNAMIS = 1 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FREE_COP_DYNAMIS = 1 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)", "FREE_COP_DYNAMIS = 0 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)"), False)
        End If

        If BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BETWEEN_2DYNA_WAIT_TIMEMatch As Boolean
                BETWEEN_2DYNA_WAIT_TIMEMatch = line.Contains("BETWEEN_2DYNA_WAIT_TIME")
                If BETWEEN_2DYNA_WAIT_TIMEMatch Then
                    BETWEEN_2DYNA_WAIT_TIMEOutputLines.Add("BETWEEN_2DYNA_WAIT_TIME = " + BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text + ";        -- wait time between 2 Dynamis (in real day) min: 1 day")
                Else
                    BETWEEN_2DYNA_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BETWEEN_2DYNA_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If DYNA_LEVEL_MINNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim DYNA_LEVEL_MINMatch As Boolean
                DYNA_LEVEL_MINMatch = line.Contains("DYNA_LEVEL_MIN")
                If DYNA_LEVEL_MINMatch Then
                    DYNA_LEVEL_MINOutputLines.Add("DYNA_LEVEL_MIN = " + DYNA_LEVEL_MINNumericUpDown.Text + ";       -- level min for entering in Dynamis")
                Else
                    DYNA_LEVEL_MINOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, DYNA_LEVEL_MINOutputLines.ToArray(), Encoding.UTF8)
        End If

        If TIMELESS_HOURGLASS_COSTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim TIMELESS_HOURGLASS_COSTMatch As Boolean
                TIMELESS_HOURGLASS_COSTMatch = line.Contains("TIMELESS_HOURGLASS_COST")
                If TIMELESS_HOURGLASS_COSTMatch Then
                    TIMELESS_HOURGLASS_COSTOutputLines.Add("TIMELESS_HOURGLASS_COST = " + TIMELESS_HOURGLASS_COSTNumericUpDown.Text + ";   -- cost of the timeless hourglass for Dynamis.")
                Else
                    TIMELESS_HOURGLASS_COSTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, TIMELESS_HOURGLASS_COSTOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CURRENCY_EXCHANGE_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CURRENCY_EXCHANGE_RATEMatch As Boolean
                CURRENCY_EXCHANGE_RATEMatch = line.Contains("CURRENCY_EXCHANGE_RATE")
                If CURRENCY_EXCHANGE_RATEMatch Then
                    CURRENCY_EXCHANGE_RATEOutputLines.Add("CURRENCY_EXCHANGE_RATE = " + CURRENCY_EXCHANGE_RATENumericUpDown.Text + ";      -- X Tier 1 ancient currency -> 1 Tier 2, and so on.  Certain values may conflict with shop items.  Not designed to exceed 198.")
                Else
                    CURRENCY_EXCHANGE_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CURRENCY_EXCHANGE_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim RELIC_2ND_UPGRADE_WAIT_TIMEMatch As Boolean
                RELIC_2ND_UPGRADE_WAIT_TIMEMatch = line.Contains("RELIC_2ND_UPGRADE_WAIT_TIME")
                If RELIC_2ND_UPGRADE_WAIT_TIMEMatch Then
                    RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.Add("RELIC_2ND_UPGRADE_WAIT_TIME = " + RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text + ";      -- wait time for 2nd relic upgrade (stage 2 -> stage 3) in seconds. 604800s = 1 RL week.")
                Else
                    RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim RELIC_3RD_UPGRADE_WAIT_TIMEMatch As Boolean
                RELIC_3RD_UPGRADE_WAIT_TIMEMatch = line.Contains("RELIC_3RD_UPGRADE_WAIT_TIME")
                If RELIC_3RD_UPGRADE_WAIT_TIMEMatch Then
                    RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.Add("RELIC_3RD_UPGRADE_WAIT_TIME = " + RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text + ";      -- wait time for 3rd relic upgrade (stage 3 -> stage 4) in seconds. 295200s = 82 hours.")
                Else
                    RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub DYNA_LEVEL_MINNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles DYNA_LEVEL_MINNumericUpDown.ValueChanged
        If DYNA_LEVEL_MINNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            DYNA_LEVEL_MINNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub
End Class