Imports System.Text.RegularExpressions
Imports System.Text

Public Class ExperienceRates

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub ExpereienceRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.exp_rate = exp_rateNumericUpDown.Text
        My.Settings.exp_loss_rate = exp_loss_rateNumericUpDown.Text
        My.Settings.exp_party_gap_penalties = exp_party_gap_penaltiesCheckBox.Checked
        'My.Settings.exp_retain = exp_retainNumericUpDown.Text
        My.Settings.exp_loss_level = exp_loss_levelNumericUpDown.Text
    End Sub

    Private Sub CharacterSettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim exp_rateOutputLines As New List(Of String)()
        Dim exp_loss_rateOutputLines As New List(Of String)()
        Dim exp_party_gap_penaltiesOutputLines As New List(Of String)()
        'Dim exp_retainOutputLines As New List(Of String)()
        Dim exp_loss_levelOutputLines As New List(Of String)()

        'Handles exp rate
        If exp_rateNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim exp_rateMatch As Boolean
                exp_rateMatch = line.Contains("exp_rate:")
                If exp_rateMatch Then
                    exp_rateOutputLines.Add("exp_rate: " + exp_rateNumericUpDown.Text)
                Else
                    exp_rateOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, exp_rateOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles rate of exp loss
        If exp_loss_rateNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim exp_loss_rateMatch As Boolean
                exp_loss_rateMatch = line.Contains("exp_loss_rate:")
                If exp_loss_rateMatch Then
                    exp_loss_rateOutputLines.Add("exp_loss_rate: " + exp_loss_rateNumericUpDown.Text)
                Else
                    exp_loss_rateOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, exp_loss_rateOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles penalties for party level gap
        If exp_party_gap_penaltiesCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("exp_party_gap_penalties: 0", "exp_party_gap_penalties: 1"), False)
        ElseIf exp_party_gap_penaltiesCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("exp_party_gap_penalties: 1", "exp_party_gap_penalties: 0"), False)
        End If

        ''Handles exp retained on death
        'If exp_retainNumericUpDown.Text.Length < 1 Then
        'Else
        '    For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
        '        Dim exp_retainMatch As Boolean
        '        exp_retainMatch = line.Contains("exp_retain:")
        '        If exp_retainMatch Then
        '            exp_retainOutputLines.Add("exp_retain: " + exp_retainNumericUpDown.Text)
        '        Else
        '            exp_retainOutputLines.Add(line)
        '        End If
        '    Next
        '    System.IO.File.WriteAllLines(MapConfFile, exp_retainOutputLines.ToArray(), Encoding.UTF8)
        'End If

        'Handles level which exp loss starts occuring on death
        If exp_loss_levelNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim exp_loss_levelMatch As Boolean
                exp_loss_levelMatch = line.Contains("exp_loss_level:")
                If exp_loss_levelMatch Then

                    exp_loss_levelOutputLines.Add("exp_loss_level: " + exp_loss_levelNumericUpDown.Text)
                Else
                    exp_loss_levelOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, exp_loss_levelOutputLines.ToArray(), Encoding.UTF8)
        End If
    End Sub
End Class