Imports System.Text.RegularExpressions
Imports System.Text

Public Class SpellSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim BlueutilsCPP = My.Settings.DSPPath + "\src\map\utils\blueutils.cpp"

    Private Sub SpellSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub SpellSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.MILK_OVERWRITE = MILK_OVERWRITECheckBox.Checked
        My.Settings.JUICE_OVERWRITE = JUICE_OVERWRITECheckBox.Checked
        My.Settings.DIA_OVERWRITE = DIA_OVERWRITECheckBox.Checked
        My.Settings.BIO_OVERWRITE = BIO_OVERWRITECheckBox.Checked
        My.Settings.BARELEMENT_OVERWRITE = BARELEMENT_OVERWRITECheckBox.Checked
        My.Settings.BARSTATUS_OVERWRITE = BARSTATUS_OVERWRITECheckBox.Checked
        My.Settings.USE_OLD_CURE_FORMULA = USE_OLD_CURE_FORMULACheckBox.Checked

        My.Settings.BARD_SONG_LIMIT = BARD_SONG_LIMITNumericUpDown.Text
        My.Settings.BARD_INSTRUMENT_LIMIT = BARD_INSTRUMENT_LIMITNumericUpDown.Text
        My.Settings.ENHANCING_SONG_DURATION = ENHANCING_SONG_DURATIONNumericUpDown.Text
        My.Settings.STONESKIN_CAP = STONESKIN_CAPNumericUpDown.Text
        My.Settings.BLINK_SHADOWS = BLINK_SHADOWSNumericUpDown.Text
        My.Settings.ENSPELL_DURATION = ENSPELL_DURATIONNumericUpDown.Text
        My.Settings.SPIKE_EFFECT_DURATION = SPIKE_EFFECT_DURATIONNumericUpDown.Text
        My.Settings.ELEMENTAL_DEBUFF_DURATION = ELEMENTAL_DEBUFF_DURATIONNumericUpDown.Text
        My.Settings.STORM_DURATION = STORM_DURATIONNumericUpDown.Text
        My.Settings.KLIMAFORM_MACC = KLIMAFORM_MACCNumericUpDown.Text
        My.Settings.AQUAVEIL_INTERR_RATE = AQUAVEIL_INTERR_RATENumericUpDown.Text
        My.Settings.ABSORB_SPELL_AMOUNT = ABSORB_SPELL_AMOUNTNumericUpDown.Text
        My.Settings.ABSORB_SPELL_TICK = ABSORB_SPELL_TICKNumericUpDown.Text
        My.Settings.SNEAK_INVIS_DURATION_MULTIPLIER = SNEAK_INVIS_DURATION_MULTIPLIERNumericUpDown.Text
        My.Settings.BlueSpellGaplevelLearn = BlueSpellGaplevelLearnNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim BARD_SONG_LIMITOutputLines As New List(Of String)()
        Dim BARD_INSTRUMENT_LIMITOutputLines As New List(Of String)()
        Dim ENHANCING_SONG_DURATIONOutputLines As New List(Of String)()
        Dim STONESKIN_CAPOutputLines As New List(Of String)()
        Dim BLINK_SHADOWSOutputLines As New List(Of String)()
        Dim ENSPELL_DURATIONOutputLines As New List(Of String)()
        Dim SPIKE_EFFECT_DURATIONOutputLines As New List(Of String)()
        Dim ELEMENTAL_DEBUFF_DURATIONOutputLines As New List(Of String)()
        Dim STORM_DURATIONOutputLines As New List(Of String)()
        Dim KLIMAFORM_MACCOutputLines As New List(Of String)()
        Dim AQUAVEIL_INTERR_RATEOutputLines As New List(Of String)()
        Dim ABSORB_SPELL_AMOUNTOutputLines As New List(Of String)()
        Dim ABSORB_SPELL_TICKOutputLines As New List(Of String)()
        Dim SNEAK_INVIS_DURATION_MULTIPLIEROutputLines As New List(Of String)()
        Dim BlueSpellGaplevelLearnOutputLines As New List(Of String)()

        If MILK_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("MILK_OVERWRITE = 0; --Set to 1 to allow Milk and Regen to overwrite each other.  Default is 1.", "MILK_OVERWRITE = 1; --Set to 1 to allow Milk and Regen to overwrite each other.  Default is 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("MILK_OVERWRITE = 1; --Set to 1 to allow Milk and Regen to overwrite each other.  Default is 1.", "MILK_OVERWRITE = 0; --Set to 1 to allow Milk and Regen to overwrite each other.  Default is 1."), False)
        End If

        If JUICE_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JUICE_OVERWRITE = 0; --Set to 1 to allow Juice and Refresh to overwrite each other.  Default is 1.", "JUICE_OVERWRITE = 1; --Set to 1 to allow Juice and Refresh to overwrite each other.  Default is 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JUICE_OVERWRITE = 1; --Set to 1 to allow Juice and Refresh to overwrite each other.  Default is 1.", "JUICE_OVERWRITE = 0; --Set to 1 to allow Juice and Refresh to overwrite each other.  Default is 1."), False)
        End If

        If DIA_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIA_OVERWRITE = 0; --Set to 1 to allow Bio to overwrite same tier Dia.  Default is 1.", "DIA_OVERWRITE = 1; --Set to 1 to allow Bio to overwrite same tier Dia.  Default is 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIA_OVERWRITE = 1; --Set to 1 to allow Bio to overwrite same tier Dia.  Default is 1.", "DIA_OVERWRITE = 0; --Set to 1 to allow Bio to overwrite same tier Dia.  Default is 1."), False)
        End If

        If BIO_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BIO_OVERWRITE = 0; --Set to 1 to allow Dia to overwrite same tier Bio.  Default is 0.", "BIO_OVERWRITE = 1; --Set to 1 to allow Dia to overwrite same tier Bio.  Default is 0."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BIO_OVERWRITE = 1; --Set to 1 to allow Dia to overwrite same tier Bio.  Default is 0.", "BIO_OVERWRITE = 0; --Set to 1 to allow Dia to overwrite same tier Bio.  Default is 0."), False)
        End If

        If BARELEMENT_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BARELEMENT_OVERWRITE = 0; --Set to 1 to allow Barelement spells to overwrite each other (prevent stacking).  Default is 1.", "BARELEMENT_OVERWRITE = 1; --Set to 1 to allow Barelement spells to overwrite each other (prevent stacking).  Default is 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BARELEMENT_OVERWRITE = 1; --Set to 1 to allow Barelement spells to overwrite each other (prevent stacking).  Default is 1.", "BARELEMENT_OVERWRITE = 0; --Set to 1 to allow Barelement spells to overwrite each other (prevent stacking).  Default is 1."), False)
        End If

        If BARSTATUS_OVERWRITECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BARSTATUS_OVERWRITE = 0; --Set to 1 to allow Barstatus spells to overwrite each other (prevent stacking).  Default is 1.", "BARSTATUS_OVERWRITE = 1; --Set to 1 to allow Barstatus spells to overwrite each other (prevent stacking).  Default is 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("BARSTATUS_OVERWRITE = 1; --Set to 1 to allow Barstatus spells to overwrite each other (prevent stacking).  Default is 1.", "BARSTATUS_OVERWRITE = 0; --Set to 1 to allow Barstatus spells to overwrite each other (prevent stacking).  Default is 1."), False)
        End If

        If USE_OLD_CURE_FORMULACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_OLD_CURE_FORMULA = false; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula", "USE_OLD_CURE_FORMULA = true; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_OLD_CURE_FORMULA = true; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula", "USE_OLD_CURE_FORMULA = false; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula"), False)
        End If

        If BARD_SONG_LIMITNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BARD_SONG_LIMITMatch As Boolean
                BARD_SONG_LIMITMatch = line.Contains("BARD_SONG_LIMIT")
                If BARD_SONG_LIMITMatch Then
                    BARD_SONG_LIMITOutputLines.Add("BARD_SONG_LIMIT = " + BARD_SONG_LIMITNumericUpDown.Text + "; --Maximum amount of songs from a single Bard that can be granted to a single target at once.  Set between 1 and 31.")
                Else
                    BARD_SONG_LIMITOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BARD_SONG_LIMITOutputLines.ToArray(), Encoding.UTF8)
        End If

        If BARD_INSTRUMENT_LIMITNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BARD_INSTRUMENT_LIMITMatch As Boolean
                BARD_INSTRUMENT_LIMITMatch = line.Contains("BARD_INSTRUMENT_LIMIT")
                If BARD_INSTRUMENT_LIMITMatch Then
                    BARD_INSTRUMENT_LIMITOutputLines.Add("BARD_INSTRUMENT_LIMIT = " + BARD_INSTRUMENT_LIMITNumericUpDown.Text + "; --Maximum amount of songs from a single Bard with an instrument that can be granted to a single target at once.  Set between 2 and 32.")
                Else
                    BARD_INSTRUMENT_LIMITOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BARD_INSTRUMENT_LIMITOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ENHANCING_SONG_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ENHANCING_SONG_DURATIONMatch As Boolean
                ENHANCING_SONG_DURATIONMatch = line.Contains("ENHANCING_SONG_DURATION")
                If ENHANCING_SONG_DURATIONMatch Then
                    ENHANCING_SONG_DURATIONOutputLines.Add("ENHANCING_SONG_DURATION = " + ENHANCING_SONG_DURATIONNumericUpDown.Text + "; -- duration of enhancing bard songs such as Minuets, Ballads, etc.")
                Else
                    ENHANCING_SONG_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ENHANCING_SONG_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If STONESKIN_CAPNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim STONESKIN_CAPMatch As Boolean
                STONESKIN_CAPMatch = line.Contains("STONESKIN_CAP")
                If STONESKIN_CAPMatch Then
                    STONESKIN_CAPOutputLines.Add("STONESKIN_CAP = " + STONESKIN_CAPNumericUpDown.Text + "; -- soft cap for hp absorbed by stoneskin")
                Else
                    STONESKIN_CAPOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, STONESKIN_CAPOutputLines.ToArray(), Encoding.UTF8)
        End If

        If BLINK_SHADOWSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BLINK_SHADOWSMatch As Boolean
                BLINK_SHADOWSMatch = line.Contains("BLINK_SHADOWS")
                If BLINK_SHADOWSMatch Then
                    BLINK_SHADOWSOutputLines.Add("BLINK_SHADOWS = " + BLINK_SHADOWSNumericUpDown.Text + ";   -- number of shadows supplied by Blink spell")
                Else
                    BLINK_SHADOWSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BLINK_SHADOWSOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ENSPELL_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ENSPELL_DURATIONMatch As Boolean
                ENSPELL_DURATIONMatch = line.Contains("ENSPELL_DURATION")
                If ENSPELL_DURATIONMatch Then
                    ENSPELL_DURATIONOutputLines.Add("ENSPELL_DURATION = " + ENSPELL_DURATIONNumericUpDown.Text + "; -- duration of RDM en-spells")
                Else
                    ENSPELL_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ENSPELL_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If SPIKE_EFFECT_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SPIKE_EFFECT_DURATIONMatch As Boolean
                SPIKE_EFFECT_DURATIONMatch = line.Contains("SPIKE_EFFECT_DURATION")
                If SPIKE_EFFECT_DURATIONMatch Then
                    SPIKE_EFFECT_DURATIONOutputLines.Add("SPIKE_EFFECT_DURATION = " + SPIKE_EFFECT_DURATIONNumericUpDown.Text + "; -- the duration of RDM, BLM spikes effects (not Reprisal)")
                Else
                    SPIKE_EFFECT_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SPIKE_EFFECT_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ELEMENTAL_DEBUFF_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ELEMENTAL_DEBUFF_DURATIONMatch As Boolean
                ELEMENTAL_DEBUFF_DURATIONMatch = line.Contains("ELEMENTAL_DEBUFF_DURATION")
                If ELEMENTAL_DEBUFF_DURATIONMatch Then
                    ELEMENTAL_DEBUFF_DURATIONOutputLines.Add("ELEMENTAL_DEBUFF_DURATION = " + ELEMENTAL_DEBUFF_DURATIONNumericUpDown.Text + "; -- base duration of elemental debuffs")
                Else
                    ELEMENTAL_DEBUFF_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ELEMENTAL_DEBUFF_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If STORM_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim STORM_DURATIONMatch As Boolean
                STORM_DURATIONMatch = line.Contains("STORM_DURATION")
                If STORM_DURATIONMatch Then
                    STORM_DURATIONOutputLines.Add("STORM_DURATION = " + STORM_DURATIONNumericUpDown.Text + "; -- duration of Scholar storm spells")
                Else
                    STORM_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, STORM_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If KLIMAFORM_MACCNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim KLIMAFORM_MACCMatch As Boolean
                KLIMAFORM_MACCMatch = line.Contains("KLIMAFORM_MACC")
                If KLIMAFORM_MACCMatch Then
                    KLIMAFORM_MACCOutputLines.Add("KLIMAFORM_MACC = " + KLIMAFORM_MACCNumericUpDown.Text + ";  -- magic accuracy added by Klimaform. 30 is just a guess.")
                Else
                    KLIMAFORM_MACCOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, KLIMAFORM_MACCOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AQUAVEIL_INTERR_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AQUAVEIL_INTERR_RATEMatch As Boolean
                AQUAVEIL_INTERR_RATEMatch = line.Contains("AQUAVEIL_INTERR_RATE")
                If AQUAVEIL_INTERR_RATEMatch Then
                    AQUAVEIL_INTERR_RATEOutputLines.Add("AQUAVEIL_INTERR_RATE = " + AQUAVEIL_INTERR_RATENumericUpDown.Text + ";  -- percent spell interruption rate reduction from Aquaveil (see http://www.bluegartrls.com/forum/82143-spell-interruption-down-cap-aquaveil-tests.html)")
                Else
                    AQUAVEIL_INTERR_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AQUAVEIL_INTERR_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ABSORB_SPELL_AMOUNTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ABSORB_SPELL_AMOUNTMatch As Boolean
                ABSORB_SPELL_AMOUNTMatch = line.Contains("ABSORB_SPELL_AMOUNT")
                If ABSORB_SPELL_AMOUNTMatch Then
                    ABSORB_SPELL_AMOUNTOutputLines.Add("ABSORB_SPELL_AMOUNT = " + ABSORB_SPELL_AMOUNTNumericUpDown.Text + "; -- how much of a stat gets absorbed by DRK absorb spells - expected to be a multiple of 8.")
                Else
                    ABSORB_SPELL_AMOUNTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ABSORB_SPELL_AMOUNTOutputLines.ToArray(), Encoding.UTF8)
        End If

        If ABSORB_SPELL_TICKNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim ABSORB_SPELL_TICKMatch As Boolean
                ABSORB_SPELL_TICKMatch = line.Contains("ABSORB_SPELL_TICK")
                If ABSORB_SPELL_TICKMatch Then
                    ABSORB_SPELL_TICKOutputLines.Add("ABSORB_SPELL_TICK = " + ABSORB_SPELL_TICKNumericUpDown.Text + "; -- duration of 1 absorb spell tick")
                Else
                    ABSORB_SPELL_TICKOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, ABSORB_SPELL_TICKOutputLines.ToArray(), Encoding.UTF8)
        End If

        If SNEAK_INVIS_DURATION_MULTIPLIERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SNEAK_INVIS_DURATION_MULTIPLIERMatch As Boolean
                SNEAK_INVIS_DURATION_MULTIPLIERMatch = line.Contains("SNEAK_INVIS_DURATION_MULTIPLIER")
                If SNEAK_INVIS_DURATION_MULTIPLIERMatch Then
                    SNEAK_INVIS_DURATION_MULTIPLIEROutputLines.Add("SNEAK_INVIS_DURATION_MULTIPLIER = " + SNEAK_INVIS_DURATION_MULTIPLIERNumericUpDown.Text + "; -- multiplies duration of sneak,invis,deodorize to reduce player torture. 1 = retail behavior. MUST BE INTEGER.")
                Else
                    SNEAK_INVIS_DURATION_MULTIPLIEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SNEAK_INVIS_DURATION_MULTIPLIEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If BlueSpellGaplevelLearnNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(BlueutilsCPP)
                Dim BlueSpellGaplevelLearnMatch As Boolean
                BlueSpellGaplevelLearnMatch = line.Contains("if (learnableLevel > 0 && learnableLevel < PBlueMage->GetMLevel()+")
                If BlueSpellGaplevelLearnMatch Then
                    BlueSpellGaplevelLearnOutputLines.Add("			if (learnableLevel > 0 && learnableLevel < PBlueMage->GetMLevel()+" + BlueSpellGaplevelLearnNumericUpDown.Text + ") { // TODO: Use blue magic skill check rather than level")
                Else
                    BlueSpellGaplevelLearnOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(BlueutilsCPP, BlueSpellGaplevelLearnOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub BlueSpellGaplevelLearnNumericUpDown_MouseClick(sender As Object, e As MouseEventArgs) Handles BlueSpellGaplevelLearnNumericUpDown.MouseClick
        MessageBox.Show("You must recompile the server for this to take effect!", "Important Message")
    End Sub

End Class