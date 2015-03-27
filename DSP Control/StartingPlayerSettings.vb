Imports System.Text.RegularExpressions
Imports System.Text

Public Class StartingPlayerSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub StartingPlayerSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub StartingPlayerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.START_GIL = START_GILNumericUpDown.Text
        My.Settings.START_INVENTORY = START_INVENTORYNumericUpDown.Text
        My.Settings.SUBJOB_QUEST_LEVEL = SUBJOB_QUEST_LEVELNumericUpDown.Text
        My.Settings.ADVANCED_JOB_LEVEL = ADVANCED_JOB_LEVELNumericUpDown.Text
        My.Settings.INITIAL_LEVEL_CAP = INITIAL_LEVEL_CAPNumericUpDown.Text
        My.Settings.UNLOCK_OUTPOST_WARPS = UNLOCK_OUTPOST_WARPSNumericUpDown.Text
        My.Settings.ALL_MAPS = ALL_MAPSCheckBox.Checked
        My.Settings.OPENING_CUTSCENE_ENABLE = OPENING_CUTSCENE_ENABLECheckBox.Checked
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        Dim START_GILOutputLines As New List(Of String)()
        Dim START_INVENTORYOutputLines As New List(Of String)()
        Dim INITIAL_LEVEL_CAPOutputLines As New List(Of String)()
        Dim SUBJOB_QUEST_LEVELOutputLines As New List(Of String)()
        Dim ADVANCED_JOB_LEVELOutputLines As New List(Of String)()
        Dim UNLOCK_OUTPOST_WARPSOutputLines As New List(Of String)()

        'Handles Player starting gil
        If START_GILNumericUpDown.Text.Length < 0 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim START_GILMatch As Boolean
                START_GILMatch = line.Contains("START_GIL")
                If START_GILMatch Then
                    START_GILOutputLines.Add("START_GIL = " + START_GILNumericUpDown.Text + "; -- Amount of gil given to newly created characters.")
                Else
                    START_GILOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, START_GILOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Player starting inventory
        If START_INVENTORYNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim START_INVENTORYMatch As Boolean
                START_INVENTORYMatch = line.Contains("START_INVENTORY")
                If START_INVENTORYMatch Then
                    START_INVENTORYOutputLines.Add("START_INVENTORY = " + START_INVENTORYNumericUpDown.Text + "; -- Starting inventory and satchel size.  Ignores values < 30.  Do not set above 80!")
                Else
                    START_INVENTORYOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, START_INVENTORYOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles level a player can get their subjob
        If SUBJOB_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SUBJOB_QUEST_LEVELMatch As Boolean
                SUBJOB_QUEST_LEVELMatch = line.Contains("SUBJOB_QUEST_LEVEL")
                If SUBJOB_QUEST_LEVELMatch Then
                    SUBJOB_QUEST_LEVELOutputLines.Add("SUBJOB_QUEST_LEVEL = " + SUBJOB_QUEST_LEVELNumericUpDown.Text + "; --Minimum level to accept either subjob quest.  Set to 0 to start the game with subjobs unlocked.")
                Else
                    SUBJOB_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SUBJOB_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles level a player can get their advanced jobs
        If ADVANCED_JOB_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ADVANCED_JOB_LEVELMatch As Boolean
                ADVANCED_JOB_LEVELMatch = line.Contains("ADVANCED_JOB_LEVEL")
                If ADVANCED_JOB_LEVELMatch Then
                    ADVANCED_JOB_LEVELOutputLines.Add("ADVANCED_JOB_LEVEL = " + ADVANCED_JOB_LEVELNumericUpDown.Text + "; --Minimum level to accept advanced job quests.  Set to 0 to start the game with advanced jobs.")
                Else
                    ADVANCED_JOB_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ADVANCED_JOB_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles initial level cap of the players
        If INITIAL_LEVEL_CAPNumericUpDown.Text.Length < 0 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim INITIAL_LEVEL_CAPMatch As Boolean
                INITIAL_LEVEL_CAPMatch = line.Contains("INITIAL_LEVEL_CAP")
                If INITIAL_LEVEL_CAPMatch Then
                    INITIAL_LEVEL_CAPOutputLines.Add("INITIAL_LEVEL_CAP = " + INITIAL_LEVEL_CAPNumericUpDown.Text + "; -- The initial level cap for new players.  There seems to be a hardcap of 255.")
                Else
                    INITIAL_LEVEL_CAPOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, INITIAL_LEVEL_CAPOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles unlocking outpost warps
        If UNLOCK_OUTPOST_WARPSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim UNLOCK_OUTPOST_WARPSMatch As Boolean
                UNLOCK_OUTPOST_WARPSMatch = line.Contains("UNLOCK_OUTPOST_WARPS")
                If UNLOCK_OUTPOST_WARPSMatch Then
                    UNLOCK_OUTPOST_WARPSOutputLines.Add("UNLOCK_OUTPOST_WARPS = " + UNLOCK_OUTPOST_WARPSNumericUpDown.Text + "; -- Set to 1 to give starting characters all outpost warps.  2 to add Tu'Lia and Tavnazia.")
                Else
                    UNLOCK_OUTPOST_WARPSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, UNLOCK_OUTPOST_WARPSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ALL_MAPSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALL_MAPS = 0; -- Set to 1 to give starting characters all the maps.", "ALL_MAPS = 1; -- Set to 1 to give starting characters all the maps."), False)
        ElseIf ALL_MAPSCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALL_MAPS = 1; -- Set to 1 to give starting characters all the maps.", "ALL_MAPS = 0; -- Set to 1 to give starting characters all the maps."), False)
        End If

        If OPENING_CUTSCENE_ENABLECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OPENING_CUTSCENE_ENABLE = 0; --Set to 1 to enable opening cutscenes, 0 to disable.", "OPENING_CUTSCENE_ENABLE = 1; --Set to 1 to enable opening cutscenes, 0 to disable."), False)
        ElseIf OPENING_CUTSCENE_ENABLECheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OPENING_CUTSCENE_ENABLE = 1; --Set to 1 to enable opening cutscenes, 0 to disable.", "OPENING_CUTSCENE_ENABLE = 0; --Set to 1 to enable opening cutscenes, 0 to disable."), False)
        End If

    End Sub

End Class