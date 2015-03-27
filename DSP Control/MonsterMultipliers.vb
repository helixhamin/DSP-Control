Imports System.Text.RegularExpressions
Imports System.Text

Public Class MonsterMultipliers

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub MonsterMultipliers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub MonsterMultipliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.mob_tp_multiplier = mob_tp_multiplierNumericUpDown.Text
        My.Settings.nm_hp_multiplier = nm_hp_multiplierNumericUpDown.Text
        My.Settings.mob_hp_multiplier = mob_hp_multiplierNumericUpDown.Text
        My.Settings.nm_mp_multiplier = nm_mp_multiplierNumericUpDown.Text
        My.Settings.mob_mp_multiplier = mob_mp_multiplierNumericUpDown.Text
        My.Settings.nm_stat_multiplier = nm_stat_multiplierNumericUpDown.Text
        My.Settings.mob_stat_multiplier = mob_stat_multiplierNumericUpDown.Text
        My.Settings.drop_rate_multiplier = drop_rate_multiplierNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim mob_tp_multiplierOutputLines As New List(Of String)()
        Dim nm_hp_multiplierOutputLines As New List(Of String)()
        Dim mob_hp_multiplierOutputLines As New List(Of String)()
        Dim nm_mp_multiplierOutputLines As New List(Of String)()
        Dim mob_mp_multiplierOutputLines As New List(Of String)()
        Dim nm_stat_multiplierOutputLines As New List(Of String)()
        Dim mob_stat_multiplierOutputLines As New List(Of String)()
        Dim drop_rate_multiplierOutputLines As New List(Of String)()

        'Handles multiplier for mob tp
        If mob_tp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_tp_multiplierMatch As Boolean
                mob_tp_multiplierMatch = line.Contains("mob_tp_multiplier:")
                If mob_tp_multiplierMatch Then

                    mob_tp_multiplierOutputLines.Add("mob_tp_multiplier:    " + mob_tp_multiplierNumericUpDown.Text)
                Else
                    mob_tp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_tp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for nm hp
        If nm_hp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim nm_hp_multiplierMatch As Boolean
                nm_hp_multiplierMatch = line.Contains("nm_hp_multiplier:")
                If nm_hp_multiplierMatch Then
                    nm_hp_multiplierOutputLines.Add("nm_hp_multiplier:     " + nm_hp_multiplierNumericUpDown.Text)
                Else
                    nm_hp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, nm_hp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for mob hp
        If mob_hp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_hp_multiplierMatch As Boolean
                mob_hp_multiplierMatch = line.Contains("mob_hp_multiplier:")
                If mob_hp_multiplierMatch Then
                    mob_hp_multiplierOutputLines.Add("mob_hp_multiplier:    " + mob_hp_multiplierNumericUpDown.Text)
                Else
                    mob_hp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_hp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for nm mp
        If nm_mp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim nm_mp_multiplierMatch As Boolean
                nm_mp_multiplierMatch = line.Contains("nm_mp_multiplier:")
                If nm_mp_multiplierMatch Then

                    nm_mp_multiplierOutputLines.Add("nm_mp_multiplier:     " + nm_mp_multiplierNumericUpDown.Text)
                Else
                    nm_mp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, nm_mp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for mob mp
        If mob_mp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_mp_multiplierMatch As Boolean
                mob_mp_multiplierMatch = line.Contains("mob_mp_multiplier:")
                If mob_mp_multiplierMatch Then

                    mob_mp_multiplierOutputLines.Add("mob_mp_multiplier:    " + mob_mp_multiplierNumericUpDown.Text)
                Else
                    mob_mp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_mp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles nm stat multiplier
        If nm_stat_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim nm_stat_multiplierMatch As Boolean
                nm_stat_multiplierMatch = line.Contains("nm_stat_multiplier:")
                If nm_stat_multiplierMatch Then

                    nm_stat_multiplierOutputLines.Add("nm_stat_multiplier:     " + nm_stat_multiplierNumericUpDown.Text)
                Else
                    nm_stat_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, nm_stat_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles mob stat multiplier
        If mob_stat_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_stat_multiplierMatch As Boolean
                mob_stat_multiplierMatch = line.Contains("mob_stat_multiplier:")
                If mob_stat_multiplierMatch Then

                    mob_stat_multiplierOutputLines.Add("mob_stat_multiplier:    " + mob_stat_multiplierNumericUpDown.Text)
                Else
                    mob_stat_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_stat_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles monster droprate multiplier
        If drop_rate_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim drop_rate_multiplierMatch As Boolean
                drop_rate_multiplierMatch = line.Contains("drop_rate_multiplier:")
                If drop_rate_multiplierMatch Then

                    drop_rate_multiplierOutputLines.Add("drop_rate_multiplier: " + drop_rate_multiplierNumericUpDown.Text)
                Else
                    drop_rate_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, drop_rate_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If
    End Sub
End Class