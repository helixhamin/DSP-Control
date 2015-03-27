Imports System.Text.RegularExpressions
Imports System.Text

Public Class ConfigFormSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub ConfigFormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ConfigFormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.HOMEPOINT_HEAL = HOMEPOINT_HEALCheckBox.Checked
        My.Settings.ALLOW_MULTIPLE_EXP_RINGS = ALLOW_MULTIPLE_EXP_RINGSCheckBox.Checked
        My.Settings.BYPASS_EXP_RING_ONE_PER_WEEK = BYPASS_EXP_RING_ONE_PER_WEEKCheckBox.Checked
        My.Settings.HOMEPOINT_TELEPORT = HOMEPOINT_TELEPORTCheckBox.Checked
        My.Settings.SHOP_PRICE = SHOP_PRICENumericUpDown.Text
        My.Settings.GIL_RATE = GIL_RATENumericUpDown.Text
        My.Settings.RIVERNE_PORTERS = RIVERNE_PORTERSNumericUpDown.Text
        My.Settings.LANTERNS_STAY_LIT = LANTERNS_STAY_LITNumericUpDown.Text
        My.Settings.TIMEZONE_OFFSET = TIMEZONE_OFFSETNumericUpDown.Text
        My.Settings.NUMBER_OF_DM_EARRINGS = NUMBER_OF_DM_EARRINGSNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim SHOP_PRICEOutputLines As New List(Of String)()
        Dim GIL_RATEOutputLines As New List(Of String)()
        Dim RIVERNE_PORTERSOutputLines As New List(Of String)()
        Dim LANTERNS_STAY_LITOutputLines As New List(Of String)()
        Dim TIMEZONE_OFFSETOutputLines As New List(Of String)()
        Dim NUMBER_OF_DM_EARRINGSOutputLines As New List(Of String)()

        If HOMEPOINT_HEALCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_HEAL = 0; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games.", "HOMEPOINT_HEAL = 1; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_HEAL = 1; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games.", "HOMEPOINT_HEAL = 0; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games."), False)
        End If

        If ALLOW_MULTIPLE_EXP_RINGSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALLOW_MULTIPLE_EXP_RINGS = 0; -- Set to 1 to remove ownership restrictions on the Chariot/Empress/Emperor Band trio.", "ALLOW_MULTIPLE_EXP_RINGS = 1; -- Set to 1 to remove ownership restrictions on the Chariot/Empress/Emperor Band trio."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALLOW_MULTIPLE_EXP_RINGS = 1; -- Set to 1 to remove ownership restrictions on the Chariot/Empress/Emperor Band trio.", "ALLOW_MULTIPLE_EXP_RINGS = 0; -- Set to 1 to remove ownership restrictions on the Chariot/Empress/Emperor Band trio."), False)
        End If

        If BYPASS_EXP_RING_ONE_PER_WEEKCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BYPASS_EXP_RING_ONE_PER_WEEK = 0; -- -- Set to 1 to bypass the limit of one ring per Conquest Tally Week.", "BYPASS_EXP_RING_ONE_PER_WEEK = 1; -- -- Set to 1 to bypass the limit of one ring per Conquest Tally Week."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BYPASS_EXP_RING_ONE_PER_WEEK = 1; -- -- Set to 1 to bypass the limit of one ring per Conquest Tally Week.", "BYPASS_EXP_RING_ONE_PER_WEEK = 0; -- -- Set to 1 to bypass the limit of one ring per Conquest Tally Week."), False)
        End If

        If HOMEPOINT_TELEPORTCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_TELEPORT =0; -- Enables the homepoint teleport system", "HOMEPOINT_TELEPORT =1; -- Enables the homepoint teleport system"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_TELEPORT =1; -- Enables the homepoint teleport system", "HOMEPOINT_TELEPORT =0; -- Enables the homepoint teleport system"), False)
        End If

        If SHOP_PRICENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SHOP_PRICEMatch As Boolean
                SHOP_PRICEMatch = line.Contains("SHOP_PRICE")
                If SHOP_PRICEMatch Then
                    SHOP_PRICEOutputLines.Add("SHOP_PRICE = " + SHOP_PRICENumericUpDown.Text + "; -- Multiplies prices in NPC shops.")
                Else
                    SHOP_PRICEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SHOP_PRICEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If GIL_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim GIL_RATEMatch As Boolean
                GIL_RATEMatch = line.Contains("GIL_RATE")
                If GIL_RATEMatch Then
                    GIL_RATEOutputLines.Add("GIL_RATE   = " + GIL_RATENumericUpDown.Text + "; -- Multiplies gil earned from quests.  Won't always display in game.")
                Else
                    GIL_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, GIL_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If RIVERNE_PORTERSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim RIVERNE_PORTERSMatch As Boolean
                RIVERNE_PORTERSMatch = line.Contains("RIVERNE_PORTERS")
                If RIVERNE_PORTERSMatch Then
                    RIVERNE_PORTERSOutputLines.Add("RIVERNE_PORTERS = " + RIVERNE_PORTERSNumericUpDown.Text + "; -- Time in seconds that Unstable Displacements in Cape Riverne stay open after trading a scale.")
                Else
                    RIVERNE_PORTERSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, RIVERNE_PORTERSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LANTERNS_STAY_LITNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LANTERNS_STAY_LITMatch As Boolean
                LANTERNS_STAY_LITMatch = line.Contains("LANTERNS_STAY_LIT")
                If LANTERNS_STAY_LITMatch Then
                    LANTERNS_STAY_LITOutputLines.Add("LANTERNS_STAY_LIT = " + LANTERNS_STAY_LITNumericUpDown.Text + "; -- time in seconds that lanterns in the Den of Rancor stay lit.")
                Else
                    LANTERNS_STAY_LITOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LANTERNS_STAY_LITOutputLines.ToArray(), Encoding.UTF8)
        End If

        If TIMEZONE_OFFSETNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim TIMEZONE_OFFSETMatch As Boolean
                TIMEZONE_OFFSETMatch = line.Contains("TIMEZONE_OFFSET")
                If TIMEZONE_OFFSETMatch Then
                    TIMEZONE_OFFSETOutputLines.Add("TIMEZONE_OFFSET = " + TIMEZONE_OFFSETNumericUpDown.Text + "; -- Offset from UTC used to determine when ""JP Midnight"" is for the server.  Default is JST (+9.0).")
                Else
                    TIMEZONE_OFFSETOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, TIMEZONE_OFFSETOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NUMBER_OF_DM_EARRINGSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NUMBER_OF_DM_EARRINGSMatch As Boolean
                NUMBER_OF_DM_EARRINGSMatch = line.Contains("NUMBER_OF_DM_EARRINGS")
                If NUMBER_OF_DM_EARRINGSMatch Then
                    NUMBER_OF_DM_EARRINGSOutputLines.Add("NUMBER_OF_DM_EARRINGS = " + NUMBER_OF_DM_EARRINGSNumericUpDown.Text + "; -- Number of earrings players can simultaneously own from Divine Might before scripts start blocking them (Default: 1)")
                Else
                    NUMBER_OF_DM_EARRINGSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NUMBER_OF_DM_EARRINGSOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub Spell_WeaponPowerButton_Click(sender As Object, e As EventArgs) Handles Spell_WeaponPowerButton.Click
        Spell_WeaponPower.Activate()
        Spell_WeaponPower.Show()
    End Sub

    Private Sub AbysseaSettingsButton_Click(sender As Object, e As EventArgs) Handles AbysseaSettingsButton.Click
        AbysseaSettings.Activate()
        AbysseaSettings.Show()
    End Sub

    Private Sub Coffer_ChestButton_Click(sender As Object, e As EventArgs) Handles Coffer_ChestButton.Click
        Coffer_ChestSettings.Activate()
        Coffer_ChestSettings.Show()
    End Sub

    Private Sub DynamisSettingsButton_Click(sender As Object, e As EventArgs) Handles DynamisSettingsButton.Click
        DynamisSettings.Activate()
        DynamisSettings.Show()
    End Sub

    Private Sub Quest_MissionSettingsButton_Click(sender As Object, e As EventArgs) Handles Quest_MissionSettingsButton.Click
        Quest_MissionSettings.Activate()
        Quest_MissionSettings.Show()
    End Sub

    Private Sub SpellSettingsButton_Click(sender As Object, e As EventArgs) Handles SpellSettingsButton.Click
        SpellSettings.Activate()
        SpellSettings.Show()
    End Sub

    Private Sub Ability_TraitSettingsButton_Click(sender As Object, e As EventArgs) Handles Ability_TraitSettingsButton.Click
        Ability_TraitSettings.Activate()
        Ability_TraitSettings.Show()
    End Sub

    Private Sub LimbusSettingsButton_Click(sender As Object, e As EventArgs) Handles LimbusSettingsButton.Click
        LimbusSettings.Activate()
        LimbusSettings.Show()
    End Sub

    Private Sub CelebrationsSettingsButton_Click(sender As Object, e As EventArgs) Handles CelebrationsSettingsButton.Click
        CelebrationsSettings.Activate()
        CelebrationsSettings.Show()
    End Sub

    Private Sub FameGainMultipliersButton_Click(sender As Object, e As EventArgs) Handles FameGainMultipliersButton.Click
        FameGainMultipliers.Activate()
        FameGainMultipliers.Show()
    End Sub
End Class