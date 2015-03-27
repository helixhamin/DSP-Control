Imports System.Text.RegularExpressions
Imports System.Text

Public Class CraftingandSkillupsettings

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub CraftingandSkillupsettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub CraftingandSkillupsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.skillup_chance_multiplier = skillup_chance_multiplierNumericUpDown.Text
        My.Settings.craft_chance_multiplier = craft_chance_multiplierNumericUpDown.Text
        My.Settings.skillup_amount_multiplier = skillup_amount_multiplierNumericUpDown.Text
        My.Settings.craft_amount_multiplier = craft_amount_multiplierNumericUpDown.Text
        My.Settings.newstyle_skillups = newstyle_skillupsNumericUpDown.Text
        My.Settings.craft_day_matters = craft_day_mattersCheckBox.Checked
        My.Settings.craft_moonphase_matters = craft_moonphase_mattersCheckBox.Checked
        My.Settings.craft_direction_matters = craft_direction_mattersCheckBox.Checked
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim skillup_chance_multiplierOutputLines As New List(Of String)()
        Dim craft_chance_multiplierOutputLines As New List(Of String)()
        Dim skillup_amount_multiplierOutputLines As New List(Of String)()
        Dim craft_amount_multiplierOutputLines As New List(Of String)()
        Dim newstyle_skillupsOutputLines As New List(Of String)()

        If skillup_chance_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim skillup_chance_multiplierMatch As Boolean
                skillup_chance_multiplierMatch = line.Contains("skillup_chance_multiplier")
                If skillup_chance_multiplierMatch Then
                    skillup_chance_multiplierOutputLines.Add("skillup_chance_multiplier: " + skillup_chance_multiplierNumericUpDown.Text)
                Else
                    skillup_chance_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, skillup_chance_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        If craft_chance_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim craft_chance_multiplierMatch As Boolean
                craft_chance_multiplierMatch = line.Contains("craft_chance_multiplier")
                If craft_chance_multiplierMatch Then
                    craft_chance_multiplierOutputLines.Add("craft_chance_multiplier: " + craft_chance_multiplierNumericUpDown.Text)
                Else
                    craft_chance_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, craft_chance_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        If skillup_amount_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim skillup_amount_multiplierMatch As Boolean
                skillup_amount_multiplierMatch = line.Contains("skillup_amount_multiplier")
                If skillup_amount_multiplierMatch Then
                    skillup_amount_multiplierOutputLines.Add("skillup_amount_multiplier: " + skillup_amount_multiplierNumericUpDown.Text)
                Else
                    skillup_amount_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, skillup_amount_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        If craft_amount_multiplierNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim craft_amount_multiplierMatch As Boolean
                craft_amount_multiplierMatch = line.Contains("craft_amount_multiplier")
                If craft_amount_multiplierMatch Then
                    craft_amount_multiplierOutputLines.Add("craft_amount_multiplier: " + craft_amount_multiplierNumericUpDown.Text)
                Else
                    craft_amount_multiplierOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, craft_amount_multiplierOutputLines.ToArray(), Encoding.UTF8)
        End If

        If newstyle_skillupsNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim newstyle_skillupsMatch As Boolean
                newstyle_skillupsMatch = line.Contains("newstyle_skillups")
                If newstyle_skillupsMatch Then
                    newstyle_skillupsOutputLines.Add("newstyle_skillups: " + newstyle_skillupsNumericUpDown.Text)
                Else
                    newstyle_skillupsOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, newstyle_skillupsOutputLines.ToArray(), Encoding.UTF8)
        End If

        If craft_day_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_day_matters: 0", "craft_day_matters: 1"), False)
        ElseIf craft_day_mattersCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_day_matters: 1", "craft_day_matters: 0"), False)
        End If

        If craft_moonphase_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_moonphase_matters: 0", "craft_moonphase_matters: 1"), False)
        ElseIf craft_moonphase_mattersCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_moonphase_matters: 1", "craft_moonphase_matters: 0"), False)
        End If

        If craft_direction_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_direction_matters: 0", "craft_direction_matters: 1"), False)
        ElseIf craft_direction_mattersCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_direction_matters: 1", "craft_direction_matters: 0"), False)
        End If
    End Sub

    Private Sub GuildPointssettingButton_Click(sender As Object, e As EventArgs) Handles GuildPointssettingButton.Click
        GuildPointssetting.Activate()
        GuildPointssetting.Show()
    End Sub

    Private Sub MaterialCollectingButton_Click(sender As Object, e As EventArgs) Handles MaterialCollectingButton.Click
        MaterialCollectingsettings.Activate()
        MaterialCollectingsettings.Show()
    End Sub
End Class