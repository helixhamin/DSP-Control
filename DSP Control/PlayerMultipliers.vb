Imports System.Text.RegularExpressions
Imports System.Text

Public Class PlayerMultipliers

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub PlayerMultipliers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub PlayerMultipliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.player_tp_multiplier = player_tp_multiplierNumericUpDown.Text
        My.Settings.player_hp_multiplier = player_hp_multiplierNumericUpDown.Text
        My.Settings.player_mp_multiplier = player_mp_multiplierNumericUpDown.Text
        My.Settings.player_stat_multiplier = player_stat_multiplierNumericUpDown.Text
        My.Settings.sj_mp_divisor = sj_mp_divisorNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim player_tp_multiplierOutputLines As New List(Of String)()
        Dim player_hp_multiplierOutputLines As New List(Of String)()
        Dim player_mp_multiplierOutputLines As New List(Of String)()
        Dim sj_mp_divisorOutputLines As New List(Of String)()
        Dim player_stat_multiplierOutputLines As New List(Of String)()

        'Handles multiplier for player tp
        If player_tp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim player_tp_multiplierMatch As Boolean
                player_tp_multiplierMatch = line.Contains("player_tp_multiplier:")
                If player_tp_multiplierMatch Then

                    player_tp_multiplierOutputLines.Add("player_tp_multiplier: " + player_tp_multiplierNumericUpDown.Text)
                Else
                    player_tp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, player_tp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for player hp
        If player_hp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim player_hp_multiplierMatch As Boolean
                player_hp_multiplierMatch = line.Contains("player_hp_multiplier:")
                If player_hp_multiplierMatch Then
                    player_hp_multiplierOutputLines.Add("player_hp_multiplier: " + player_hp_multiplierNumericUpDown.Text)
                Else
                    player_hp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, player_hp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles multiplier for player mp
        If player_mp_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim player_mp_multiplierMatch As Boolean
                player_mp_multiplierMatch = line.Contains("player_mp_multiplier:")
                If player_mp_multiplierMatch Then

                    player_mp_multiplierOutputLines.Add("player_mp_multiplier: " + player_mp_multiplierNumericUpDown.Text)
                Else
                    player_mp_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, player_mp_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles player stat multiplier
        If player_stat_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim player_stat_multiplierMatch As Boolean
                player_stat_multiplierMatch = line.Contains("player_stat_multiplier:")
                If player_stat_multiplierMatch Then

                    player_stat_multiplierOutputLines.Add("player_stat_multiplier: " + player_stat_multiplierNumericUpDown.Text)
                Else
                    player_stat_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, player_stat_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Sets the fraction of MP a subjob provides to the main job. Retail is half and this acts as a divisor so default is 2
        If sj_mp_divisorNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim sj_mp_divisorMatch As Boolean
                sj_mp_divisorMatch = line.Contains("sj_mp_divisor:")
                If sj_mp_divisorMatch Then

                    sj_mp_divisorOutputLines.Add("sj_mp_divisor: " + sj_mp_divisorNumericUpDown.Text)
                Else
                    sj_mp_divisorOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, sj_mp_divisorOutputLines.ToArray(), Encoding.UTF8)
        End If
    End Sub
End Class