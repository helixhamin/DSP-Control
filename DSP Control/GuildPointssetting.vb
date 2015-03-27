Imports System.Text.RegularExpressions
Imports System.Text

Public Class GuildPointssetting

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub GuildPoints_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub GuildPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.FISHING_GUILD_POINTS = FISHING_GUILD_POINTSNumericUpDown.Text
        My.Settings.WOODWORKING_GUILD_POINTS = WOODWORKING_GUILD_POINTSNumericUpDown.Text
        My.Settings.SMITHING_GUILD_POINTS = SMITHING_GUILD_POINTSNumericUpDown.Text
        My.Settings.GOLDSMITHING_GUILD_POINTS = GOLDSMITHING_GUILD_POINTSNumericUpDown.Text
        My.Settings.CLOTHCRAFT_GUILD_POINTS = CLOTHCRAFT_GUILD_POINTSNumericUpDown.Text
        My.Settings.LEATHERCRAFT_GUILD_POINTS = LEATHERCRAFT_GUILD_POINTSNumericUpDown.Text
        My.Settings.BONECRAFT_GUILD_POINTS = BONECRAFT_GUILD_POINTSNumericUpDown.Text
        My.Settings.ALCHEMY_GUILD_POINTS = ALCHEMY_GUILD_POINTSNumericUpDown.Text
        My.Settings.COOKING_GUILD_POINTS = COOKING_GUILD_POINTSNumericUpDown.Text
        My.Settings.DISABLE_GUILD_CONTRACTS = DISABLE_GUILD_CONTRACTSCheckBox.Checked
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim FISHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim WOODWORKING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim SMITHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim GOLDSMITHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim CLOTHCRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim LEATHERCRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim BONECRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim ALCHEMY_GUILD_POINTSOutputLines As New List(Of String)()
        Dim COOKING_GUILD_POINTSOutputLines As New List(Of String)()

        If FISHING_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim FISHING_GUILD_POINTSMatch As Boolean
                FISHING_GUILD_POINTSMatch = line.Contains("FISHING_GUILD_POINTS")
                If FISHING_GUILD_POINTSMatch Then
                    FISHING_GUILD_POINTSOutputLines.Add("FISHING_GUILD_POINTS      = " + FISHING_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from fishermans' guild trades.")
                Else
                    FISHING_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, FISHING_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WOODWORKING_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WOODWORKING_GUILD_POINTSMatch As Boolean
                WOODWORKING_GUILD_POINTSMatch = line.Contains("WOODWORKING_GUILD_POINTS")
                If WOODWORKING_GUILD_POINTSMatch Then
                    WOODWORKING_GUILD_POINTSOutputLines.Add("WOODWORKING_GUILD_POINTS  = " + WOODWORKING_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from carpenters' guild trades.")
                Else
                    WOODWORKING_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WOODWORKING_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If SMITHING_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SMITHING_GUILD_POINTSMatch As Boolean
                SMITHING_GUILD_POINTSMatch = line.Contains("SMITHING_GUILD_POINTS")
                If SMITHING_GUILD_POINTSMatch Then
                    SMITHING_GUILD_POINTSOutputLines.Add("SMITHING_GUILD_POINTS     = " + SMITHING_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from blacksmiths' guild trades.")
                Else
                    SMITHING_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SMITHING_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If GOLDSMITHING_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim GOLDSMITHING_GUILD_POINTSMatch As Boolean
                GOLDSMITHING_GUILD_POINTSMatch = line.Contains("GOLDSMITHING_GUILD_POINTS")
                If GOLDSMITHING_GUILD_POINTSMatch Then
                    GOLDSMITHING_GUILD_POINTSOutputLines.Add("GOLDSMITHING_GUILD_POINTS = " + GOLDSMITHING_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from goldsmiths' guild trades.")
                Else
                    GOLDSMITHING_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, GOLDSMITHING_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CLOTHCRAFT_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CLOTHCRAFT_GUILD_POINTSMatch As Boolean
                CLOTHCRAFT_GUILD_POINTSMatch = line.Contains("CLOTHCRAFT_GUILD_POINTS")
                If CLOTHCRAFT_GUILD_POINTSMatch Then
                    CLOTHCRAFT_GUILD_POINTSOutputLines.Add("CLOTHCRAFT_GUILD_POINTS   = " + CLOTHCRAFT_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from weavers' guild trades.")
                Else
                    CLOTHCRAFT_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CLOTHCRAFT_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LEATHERCRAFT_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LEATHERCRAFT_GUILD_POINTSMatch As Boolean
                LEATHERCRAFT_GUILD_POINTSMatch = line.Contains("LEATHERCRAFT_GUILD_POINTS")
                If LEATHERCRAFT_GUILD_POINTSMatch Then
                    LEATHERCRAFT_GUILD_POINTSOutputLines.Add("LEATHERCRAFT_GUILD_POINTS = " + LEATHERCRAFT_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from tanners' guild trades.")
                Else
                    LEATHERCRAFT_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LEATHERCRAFT_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If BONECRAFT_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BONECRAFT_GUILD_POINTSMatch As Boolean
                BONECRAFT_GUILD_POINTSMatch = line.Contains("BONECRAFT_GUILD_POINTS")
                If BONECRAFT_GUILD_POINTSMatch Then
                    BONECRAFT_GUILD_POINTSOutputLines.Add("BONECRAFT_GUILD_POINTS    = " + BONECRAFT_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from boneworkers' guild trades.")
                Else
                    BONECRAFT_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BONECRAFT_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ALCHEMY_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ALCHEMY_GUILD_POINTSMatch As Boolean
                ALCHEMY_GUILD_POINTSMatch = line.Contains("ALCHEMY_GUILD_POINTS")
                If ALCHEMY_GUILD_POINTSMatch Then
                    ALCHEMY_GUILD_POINTSOutputLines.Add("ALCHEMY_GUILD_POINTS      = " + ALCHEMY_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from alchemists' guild trades.")
                Else
                    ALCHEMY_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ALCHEMY_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If COOKING_GUILD_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim COOKING_GUILD_POINTSMatch As Boolean
                COOKING_GUILD_POINTSMatch = line.Contains("COOKING_GUILD_POINTS")
                If COOKING_GUILD_POINTSMatch Then
                    COOKING_GUILD_POINTSOutputLines.Add("COOKING_GUILD_POINTS      = " + COOKING_GUILD_POINTSNumericUpDown.Text + "; -- Multiplies guild points earned from culinarians' guild trades.")
                Else
                    COOKING_GUILD_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, COOKING_GUILD_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If DISABLE_GUILD_CONTRACTSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DISABLE_GUILD_CONTRACTS   = 0; -- Set to 1 to disable guild contracts, allowing players to accumulate guild points from all guilds at once.", "DISABLE_GUILD_CONTRACTS   = 1; -- Set to 1 to disable guild contracts, allowing players to accumulate guild points from all guilds at once."), False)
        ElseIf DISABLE_GUILD_CONTRACTSCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DISABLE_GUILD_CONTRACTS   = 1; -- Set to 1 to disable guild contracts, allowing players to accumulate guild points from all guilds at once.", "DISABLE_GUILD_CONTRACTS   = 0; -- Set to 1 to disable guild contracts, allowing players to accumulate guild points from all guilds at once."), False)
        End If
    End Sub
End Class