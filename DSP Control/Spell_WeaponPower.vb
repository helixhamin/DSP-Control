Imports System.Text.RegularExpressions
Imports System.Text

Public Class Spell_WeaponPower

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub Spell_WeaponPower_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub Spell_WeaponPower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.CURE_POWER = CURE_POWERNumericUpDown.Text
        My.Settings.SPELL_POWER = SPELL_POWERNumericUpDown.Text
        My.Settings.BLUE_POWER = BLUE_POWERNumericUpDown.Text
        My.Settings.DRAIN_POWER = DRAIN_POWERNumericUpDown.Text
        My.Settings.ITEM_POWER = ITEM_POWERNumericUpDown.Text
        My.Settings.WEAPON_SKILL_POWER = WEAPON_SKILL_POWERNumericUpDown.Text
        My.Settings.WEAPON_SKILL_POINTS = WEAPON_SKILL_POINTSNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim CURE_POWEROutputLines As New List(Of String)()
        Dim SPELL_POWEROutputLines As New List(Of String)()
        Dim BLUE_POWEROutputLines As New List(Of String)()
        Dim DRAIN_POWEROutputLines As New List(Of String)()
        Dim ITEM_POWEROutputLines As New List(Of String)()
        Dim WEAPON_SKILL_POWEROutputLines As New List(Of String)()
        Dim WEAPON_SKILL_POINTSOutputLines As New List(Of String)()

        If CURE_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CURE_POWERMatch As Boolean
                CURE_POWERMatch = line.Contains("CURE_POWER")
                If CURE_POWERMatch Then
                    CURE_POWEROutputLines.Add("CURE_POWER  = " + CURE_POWERNumericUpDown.Text + "; -- Multiplies amount healed from Healing Magic, including the relevant Blue Magic.")
                Else
                    CURE_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CURE_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If SPELL_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SPELL_POWERMatch As Boolean
                SPELL_POWERMatch = line.Contains("SPELL_POWER")
                If SPELL_POWERMatch Then
                    SPELL_POWEROutputLines.Add("SPELL_POWER = " + SPELL_POWERNumericUpDown.Text + "; -- Multiplies damage dealt by Elemental and Divine Magic.")
                Else
                    SPELL_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SPELL_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If BLUE_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BLUE_POWERMatch As Boolean
                BLUE_POWERMatch = line.Contains("BLUE_POWER")
                If BLUE_POWERMatch Then
                    BLUE_POWEROutputLines.Add("BLUE_POWER  = " + BLUE_POWERNumericUpDown.Text + "; -- Multiplies damage dealt by most Blue Magic.")
                Else
                    BLUE_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BLUE_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If DRAIN_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim DRAIN_POWERMatch As Boolean
                DRAIN_POWERMatch = line.Contains("DRAIN_POWER")
                If DRAIN_POWERMatch Then
                    DRAIN_POWEROutputLines.Add("DRAIN_POWER = " + DRAIN_POWERNumericUpDown.Text + "; -- Multiplies amount drained by Drain, Aspir, and relevant Blue Magic spells.")
                Else
                    DRAIN_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, DRAIN_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If ITEM_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ITEM_POWERMatch As Boolean
                ITEM_POWERMatch = line.Contains("ITEM_POWER")
                If ITEM_POWERMatch Then
                    ITEM_POWEROutputLines.Add("ITEM_POWER  = " + ITEM_POWERNumericUpDown.Text + "; -- Multiplies the effect of items such as Potions and Ethers.")
                Else
                    ITEM_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ITEM_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If WEAPON_SKILL_POWERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WEAPON_SKILL_POWERMatch As Boolean
                WEAPON_SKILL_POWERMatch = line.Contains("WEAPON_SKILL_POWER")
                If WEAPON_SKILL_POWERMatch Then
                    WEAPON_SKILL_POWEROutputLines.Add("WEAPON_SKILL_POWER  = " + WEAPON_SKILL_POWERNumericUpDown.Text + "; --  Multiplies damage dealt by Weapon Skills.")
                Else
                    WEAPON_SKILL_POWEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WEAPON_SKILL_POWEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If WEAPON_SKILL_POINTSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WEAPON_SKILL_POINTSMatch As Boolean
                WEAPON_SKILL_POINTSMatch = line.Contains("WEAPON_SKILL_POINTS")
                If WEAPON_SKILL_POINTSMatch Then
                    WEAPON_SKILL_POINTSOutputLines.Add("WEAPON_SKILL_POINTS = " + WEAPON_SKILL_POINTSNumericUpDown.Text + "; -- Multiplies points earned during weapon unlocking.")
                Else
                    WEAPON_SKILL_POINTSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WEAPON_SKILL_POINTSOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

End Class