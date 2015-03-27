Imports System.Text.RegularExpressions
Imports System.Text

Public Class ConfigFormMap

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub ConfigFormMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.timestamp_formatMap = timestamp_formatMapTextBox.Text
        My.Settings.stdout_with_ansisequenceMap = stdout_with_ansisequenceMapTextBox.Text
        My.Settings.console_silentMap = console_silentMapNumericUpDown.Text
        My.Settings.buff_maxsize = buff_maxsizeNumericUpDown.Text
        My.Settings.max_time_lastupdate = max_time_lastupdateNumericUpDown.Text
        My.Settings.lightluggage_block = lightluggage_blockNumericUpDown.Text
        My.Settings.vanadiel_time_offset = vanadiel_time_offsetNumericUpDown.Text
        My.Settings.map_port = map_portNumericUpDown.Text
    End Sub

    Private Sub ConfigFormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim timestamp_formatMapOutputLines As New List(Of String)()
        Dim stdout_with_ansisequenceMapOutputLines As New List(Of String)()
        Dim console_silentMapOutputLines As New List(Of String)()
        Dim buff_maxsizeOutputLines As New List(Of String)()
        Dim max_time_lastupdateOutputLines As New List(Of String)()
        Dim lightluggage_blockOutputLines As New List(Of String)()
        Dim vanadiel_time_offsetOutputLines As New List(Of String)()
        Dim map_portOutputLines As New List(Of String)()

        'Handles Time Stamp
        If timestamp_formatMapTextBox.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim timestamp_formatMapMatch As Boolean
                timestamp_formatMapMatch = line.Contains("timestamp_format:")
                If timestamp_formatMapMatch Then
                    ' Replace line with string
                    timestamp_formatMapOutputLines.Add("timestamp_format: " + timestamp_formatMapTextBox.Text)
                Else
                    timestamp_formatMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, timestamp_formatMapOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles stout
        If stdout_with_ansisequenceMapTextBox.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim stdout_with_ansisequenceMapMatch As Boolean
                stdout_with_ansisequenceMapMatch = line.Contains("stdout_with_ansisequence:")
                If stdout_with_ansisequenceMapMatch Then
                    ' Replace line with string
                    stdout_with_ansisequenceMapOutputLines.Add("stdout_with_ansisequence: " + stdout_with_ansisequenceMapTextBox.Text)
                Else
                    stdout_with_ansisequenceMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, stdout_with_ansisequenceMapOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles server messages (silent server)
        If console_silentMapNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim console_silentMapMatch As Boolean
                Dim console_silentMapNotMatch As Boolean
                console_silentMapMatch = line.Contains("console_silent:")
                console_silentMapNotMatch = line.Contains("#Example:")
                If console_silentMapMatch And Not console_silentMapNotMatch Then
                    ' Replace line with string
                    console_silentMapOutputLines.Add("console_silent: " + console_silentMapNumericUpDown.Text)
                Else
                    console_silentMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, console_silentMapOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Max Buffer size
        If buff_maxsizeNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim buff_maxsizeMatch As Boolean
                buff_maxsizeMatch = line.Contains("buff_maxsize:")
                If buff_maxsizeMatch Then
                    ' Replace line with string
                    buff_maxsizeOutputLines.Add("buff_maxsize: " + buff_maxsizeNumericUpDown.Text)
                Else
                    buff_maxsizeOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, buff_maxsizeOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Buffer update speed
        If max_time_lastupdateNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim max_time_lastupdateMatch As Boolean
                max_time_lastupdateMatch = line.Contains("max_time_lastupdate:")
                If max_time_lastupdateMatch Then
                    ' Replace line with string
                    max_time_lastupdateOutputLines.Add("max_time_lastupdate: " + max_time_lastupdateNumericUpDown.Text)
                Else
                    max_time_lastupdateOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, max_time_lastupdateOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Light Luggage block
        If lightluggage_blockNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim lightluggage_blockMatch As Boolean
                lightluggage_blockMatch = line.Contains("lightluggage_block:")
                If lightluggage_blockMatch Then
                    ' Replace line with string
                    lightluggage_blockOutputLines.Add("lightluggage_block:   " + lightluggage_blockNumericUpDown.Text)
                Else
                    lightluggage_blockOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, lightluggage_blockOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Vanadiel time offset
        If vanadiel_time_offsetNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim vanadiel_time_offsetMatch As Boolean
                vanadiel_time_offsetMatch = line.Contains("vanadiel_time_offset:")
                If vanadiel_time_offsetMatch Then
                    ' Replace line with string
                    vanadiel_time_offsetOutputLines.Add("vanadiel_time_offset: " + vanadiel_time_offsetNumericUpDown.Text)
                Else
                    vanadiel_time_offsetOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, vanadiel_time_offsetOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles map server port
        If map_portNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim map_portMatch As Boolean
                map_portMatch = line.Contains("map_port:")
                If map_portMatch Then
                    ' Replace line with string
                    map_portOutputLines.Add("map_port: " + map_portNumericUpDown.Text)
                Else
                    map_portOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, map_portOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub CharacterSettingsButton_Click(sender As Object, e As EventArgs) Handles CharacterSettingsButton.Click
        CharacterSettingsForm.Activate()
        CharacterSettingsForm.Show()
    End Sub

    Private Sub AuditButton_Click(sender As Object, e As EventArgs) Handles AuditButton.Click
        AuditSettings.Activate()
        AuditSettings.Show()
    End Sub

    Private Sub MonsterSettingsButton_Click(sender As Object, e As EventArgs) Handles MonsterSettingsButton.Click
        MonsterSettingsForm.Activate()
        MonsterSettingsForm.Show()
    End Sub

End Class