Imports System.Text.RegularExpressions
Imports System.Text

Public Class ConfigForm

    Dim LoginConfFile = My.Settings.DSPPath + "\conf\login_darkstar.conf"
    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"
    Dim SearchConfFile = My.Settings.DSPPath + "\conf\search_server.conf"
    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"
    Dim AHCPP = My.Settings.DSPPath + "\src\map\packets\auction_house.cpp"
    Dim BlueutilsCPP = My.Settings.DSPPath + "\src\map\utils\blueutils.cpp"

    Private Sub ConfigForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsSearchButton_Click(sender, e)
        ApplySettingsLoginPage1Button_Click(sender, e)
        ApplySettingsLoginPage2Button_Click(sender, e)
        ApplySettingsDatabaseSettingsButton_Click(sender, e)
        ApplySettingsMiscButton_Click(sender, e)
        ApplySettingsMapPage1Button_Click(sender, e)
        ApplySettingsMapPage2Button_Click(sender, e)
        ApplySettingsMapPage3Button_Click(sender, e)
        ApplySettingsMapPage4Button_Click(sender, e)
        ApplySettingsMapPage5Button_Click(sender, e)
        ApplySettingsMapPage6Button_Click(sender, e)
        ApplySettingPage1Button_Click(sender, e)
        ApplySettingPage2Button_Click(sender, e)
        ApplySettingPage3Button_Click(sender, e)
        ApplySettingPage4Button_Click(sender, e)
        ApplySettingPage5Button_Click(sender, e)
        ApplySettingPage6Button_Click(sender, e)
        ApplySettingPage7Button_Click(sender, e)
        ApplySettingPage8Button_Click(sender, e)
        ApplySettingPage9Button_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql_hostTextBox.Text = My.Settings.mysql_host
        mysql_hostLoginTextBox.Text = My.Settings.mysql_host
        mysql_portNumericUpDown.Text = My.Settings.mysql_port
        mysql_loginTextBox.Text = My.Settings.mysql_login
        mysql_passwordTextBox.Text = My.Settings.mysql_password
        mysql_databaseTextBox.Text = My.Settings.mysql_database
        msg_server_portNumericUpDown.Text = My.Settings.msg_server_port
        expire_auctionsCheckBox.Checked = My.Settings.expire_auctions
        no_auction_limitsCheckBox.Checked = My.Settings.no_auction_limits
        expire_daysNumericUpDown.Text = My.Settings.expire_days
        expire_intervalNumericUpDown.Text = My.Settings.expire_interval
        timestamp_formatLoginTextBox.Text = My.Settings.timestamp_formatLogin
        stdout_with_ansisequenceLoginTextBox.Text = My.Settings.stdout_with_ansisequenceLogin
        console_silentLoginNumericUpDown.Text = My.Settings.console_silentLogin
        search_server_portNumericUpDown.Text = My.Settings.search_server_port
        servernameTextBox.Text = My.Settings.servername
        COPCheckBox.Checked = My.Settings.ENABLE_COP
        TOAUCheckBox.Checked = My.Settings.ENABLE_TOAU
        WOTGCheckBox.Checked = My.Settings.ENABLE_WOTG
        ACPCheckBox.Checked = My.Settings.ENABLE_ACP
        AMKCheckBox.Checked = My.Settings.ENABLE_AMK
        ASACheckBox.Checked = My.Settings.ENABLE_ASA
        ABYSSEACheckBox.Checked = My.Settings.ENABLE_ABYSSEA
        SOACheckBox.Checked = My.Settings.ENABLE_SOA
        RESTRICT_BY_EXPANSIONCheckBox.Checked = My.Settings.RESTRICT_BY_EXPANSION
        USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = My.Settings.USE_ADOULIN_WEAPON_SKILL_CHANGES
        LoginExpansionControlTextBox.Text = My.Settings.LoginExpansionControl
        map_portNumericUpDown.Text = My.Settings.map_port
        timestamp_formatMapTextBox.Text = My.Settings.timestamp_formatMap
        stdout_with_ansisequenceMapTextBox.Text = My.Settings.stdout_with_ansisequenceMap
        console_silentMapNumericUpDown.Text = My.Settings.console_silentMap
        buff_maxsizeNumericUpDown.Text = My.Settings.buff_maxsize
        max_time_lastupdateNumericUpDown.Text = My.Settings.max_time_lastupdate
        lightluggage_blockNumericUpDown.Text = My.Settings.lightluggage_block
        vanadiel_time_offsetNumericUpDown.Text = My.Settings.vanadiel_time_offset
        exp_rateNumericUpDown.Text = My.Settings.exp_rate
        exp_loss_rateNumericUpDown.Text = My.Settings.exp_loss_rate
        exp_party_gap_penaltiesCheckBox.Checked = My.Settings.exp_party_gap_penalties
        exp_retainCheckBox.Checked = My.Settings.exp_retain
        exp_loss_levelNumericUpDown.Text = My.Settings.exp_loss_level
        fov_party_gap_penaltiesCheckBox.Checked = My.Settings.fov_party_gap_penalties
        fov_allow_allianceCheckBox.Checked = My.Settings.fov_allow_alliance
        speed_modNumericUpDown.Text = My.Settings.speed_mod
        level_sync_enableCheckBox.Checked = My.Settings.level_sync_enable
        all_jobs_widescanCheckBox.Checked = My.Settings.all_jobs_widescan
        max_merit_pointsNumericUpDown.Text = My.Settings.max_merit_points
        yell_cooldownNumericUpDown.Text = My.Settings.yell_cooldown
        mob_speed_modNumericUpDown.Text = My.Settings.mob_speed_mod
        all_mobs_gil_bonusNumericUpDown.Text = My.Settings.all_mobs_gil_bonus
        max_gil_bonusNumericUpDown.Text = My.Settings.max_gil_bonus
        Battle_cap_tweakNumericUpDown.Text = My.Settings.Battle_cap_tweak
        skillup_chance_multiplierNumericUpDown.Text = My.Settings.skillup_chance_multiplier
        craft_chance_multiplierNumericUpDown.Text = My.Settings.craft_chance_multiplier
        skillup_amount_multiplierNumericUpDown.Text = My.Settings.skillup_amount_multiplier
        craft_amount_multiplierNumericUpDown.Text = My.Settings.craft_amount_multiplier
        newstyle_skillupsNumericUpDown.Text = My.Settings.newstyle_skillups
        craft_day_mattersCheckBox.Checked = My.Settings.craft_day_matters
        craft_moonphase_mattersCheckBox.Checked = My.Settings.craft_moonphase_matters
        craft_direction_mattersCheckBox.Checked = My.Settings.craft_direction_matters
        mob_tp_multiplierNumericUpDown.Text = My.Settings.mob_tp_multiplier
        nm_hp_multiplierNumericUpDown.Text = My.Settings.nm_hp_multiplier
        mob_hp_multiplierNumericUpDown.Text = My.Settings.mob_hp_multiplier
        nm_mp_multiplierNumericUpDown.Text = My.Settings.nm_mp_multiplier
        mob_mp_multiplierNumericUpDown.Text = My.Settings.mob_mp_multiplier
        nm_stat_multiplierNumericUpDown.Text = My.Settings.nm_stat_multiplier
        mob_stat_multiplierNumericUpDown.Text = My.Settings.mob_stat_multiplier
        drop_rate_multiplierNumericUpDown.Text = My.Settings.drop_rate_multiplier
        player_tp_multiplierNumericUpDown.Text = My.Settings.player_tp_multiplier
        player_hp_multiplierNumericUpDown.Text = My.Settings.player_hp_multiplier
        player_mp_multiplierNumericUpDown.Text = My.Settings.player_mp_multiplier
        player_stat_multiplierNumericUpDown.Text = My.Settings.player_stat_multiplier
        sj_mp_divisorNumericUpDown.Text = My.Settings.sj_mp_divisor
        audit_chatCheckBox.Checked = My.Settings.audit_chat
        audit_sayCheckBox.Checked = My.Settings.audit_say
        audit_shoutCheckBox.Checked = My.Settings.audit_shout
        audit_tellCheckBox.Checked = My.Settings.audit_tell
        audit_yellCheckBox.Checked = My.Settings.audit_yell
        audit_linkshellCheckBox.Checked = My.Settings.audit_linkshell
        audit_partyCheckBox.Checked = My.Settings.audit_party
        VISITANT_BONUSNumericUpDown.Text = My.Settings.VISITANT_BONUS
        CoP_Battle_capCheckBox.Checked = My.Settings.CoP_Battle_cap
        BlueSpellGaplevelLearnNumericUpDown.Text = My.Settings.BlueSpellGaplevelLearn
        MILK_OVERWRITECheckBox.Checked = My.Settings.MILK_OVERWRITE
        JUICE_OVERWRITECheckBox.Checked = My.Settings.JUICE_OVERWRITE
        DIA_OVERWRITECheckBox.Checked = My.Settings.DIA_OVERWRITE
        BIO_OVERWRITECheckBox.Checked = My.Settings.BIO_OVERWRITE
        BARELEMENT_OVERWRITECheckBox.Checked = My.Settings.BARELEMENT_OVERWRITE
        BARSTATUS_OVERWRITECheckBox.Checked = My.Settings.BARSTATUS_OVERWRITE
        USE_OLD_CURE_FORMULACheckBox.Checked = My.Settings.USE_OLD_CURE_FORMULA
        BARD_SONG_LIMITNumericUpDown.Text = My.Settings.BARD_SONG_LIMIT
        BARD_INSTRUMENT_LIMITNumericUpDown.Text = My.Settings.BARD_INSTRUMENT_LIMIT
        ENHANCING_SONG_DURATIONNumericUpDown.Text = My.Settings.ENHANCING_SONG_DURATION
        STONESKIN_CAPNumericUpDown.Text = My.Settings.STONESKIN_CAP
        BLINK_SHADOWSNumericUpDown.Text = My.Settings.BLINK_SHADOWS
        ENSPELL_DURATIONNumericUpDown.Text = My.Settings.ENSPELL_DURATION
        SPIKE_EFFECT_DURATIONNumericUpDown.Text = My.Settings.SPIKE_EFFECT_DURATION
        ELEMENTAL_DEBUFF_DURATIONNumericUpDown.Text = My.Settings.ELEMENTAL_DEBUFF_DURATION
        STORM_DURATIONNumericUpDown.Text = My.Settings.STORM_DURATION
        KLIMAFORM_MACCNumericUpDown.Text = My.Settings.KLIMAFORM_MACC
        AQUAVEIL_INTERR_RATENumericUpDown.Text = My.Settings.AQUAVEIL_INTERR_RATE
        ABSORB_SPELL_AMOUNTNumericUpDown.Text = My.Settings.ABSORB_SPELL_AMOUNT
        ABSORB_SPELL_TICKNumericUpDown.Text = My.Settings.ABSORB_SPELL_TICK
        SNEAK_INVIS_DURATION_MULTIPLIERNumericUpDown.Text = My.Settings.SNEAK_INVIS_DURATION_MULTIPLIER
    End Sub

    Private Sub COPCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles COPCheckBox.CheckedChanged
        If COPCheckBox.Checked = True Then
            CoP_Battle_capCheckBox.Enabled = True
            ENABLE_COP_ZONE_CAPCheckBox.Enabled = True
        Else
            CoP_Battle_capCheckBox.Enabled = False
            ENABLE_COP_ZONE_CAPCheckBox.Enabled = False
        End If

    End Sub

    Private Sub no_auction_limitsCheckBox_MouseClick(sender As Object, e As MouseEventArgs) Handles no_auction_limitsCheckBox.MouseClick
        If no_auction_limitsCheckBox.Checked = False Then
        Else
            MessageBox.Show("You must recompile the server for this to take effect!", "Important Message")
        End If
    End Sub

    Private Sub ApplySettingsLoginPage1Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsLoginPage1Button.Click

        Dim timestamp_formatLoginOutputLines As New List(Of String)()
        Dim stdout_with_ansisequenceLoginOutputLines As New List(Of String)()
        Dim console_silentLoginOutputLines As New List(Of String)()
        Dim search_server_portOutputLines As New List(Of String)()

        'Handles Time Stamp
        If timestamp_formatLoginTextBox.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim timestamp_formatLoginMatch As Boolean
                timestamp_formatLoginMatch = line.Contains("timestamp_format:")
                If timestamp_formatLoginMatch Then
                    ' Replace line with string
                    timestamp_formatLoginOutputLines.Add("timestamp_format: " + timestamp_formatLoginTextBox.Text)
                Else
                    timestamp_formatLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, timestamp_formatLoginOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles stout
        If stdout_with_ansisequenceLoginTextBox.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim stdout_with_ansisequenceLoginMatch As Boolean
                stdout_with_ansisequenceLoginMatch = line.Contains("stdout_with_ansisequence:")
                If stdout_with_ansisequenceLoginMatch Then
                    ' Replace line with string
                    stdout_with_ansisequenceLoginOutputLines.Add("stdout_with_ansisequence: " + stdout_with_ansisequenceLoginTextBox.Text)
                Else
                    stdout_with_ansisequenceLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, stdout_with_ansisequenceLoginOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles server messages (silent server)
        If console_silentLoginNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim console_silentLoginMatch As Boolean
                Dim console_silentLoginNotMatch As Boolean
                console_silentLoginMatch = line.Contains("console_silent:")
                console_silentLoginNotMatch = line.Contains("#Example:")
                If console_silentLoginMatch And Not console_silentLoginNotMatch Then
                    ' Replace line with string
                    console_silentLoginOutputLines.Add("console_silent: " + console_silentLoginNumericUpDown.Text)
                Else
                    console_silentLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, console_silentLoginOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles Search Server Port
        If search_server_portNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim search_server_portMatch As Boolean
                search_server_portMatch = line.Contains("search_server_port:")
                If search_server_portMatch Then
                    ' Replace line with string
                    search_server_portOutputLines.Add("search_server_port: " + search_server_portNumericUpDown.Text)
                Else
                    search_server_portOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, search_server_portOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingsLoginPage2Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsLoginPage2Button.Click

        Dim servernameOutputLines As New List(Of String)()

        LoginExpansionControlTextBox.Text = My.Settings.LoginExpansionControl

        'Handles server name
        If servernameTextBox.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim servernameMatch As Boolean
                servernameMatch = line.Contains("servername:")
                If servernameMatch Then
                    ' Replace line with string
                    servernameOutputLines.Add("servername: " + servernameTextBox.Text)
                Else
                    servernameOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, servernameOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingsMapPage1Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage1Button.Click

        Dim map_portOutputLines As New List(Of String)()
        Dim timestamp_formatMapOutputLines As New List(Of String)()
        Dim stdout_with_ansisequenceMapOutputLines As New List(Of String)()
        Dim console_silentMapOutputLines As New List(Of String)()

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

    End Sub

    Private Sub ApplySettingsMapPage2Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage2Button.Click

        Dim buff_maxsizeOutputLines As New List(Of String)()
        Dim max_time_lastupdateOutputLines As New List(Of String)()
        Dim lightluggage_blockOutputLines As New List(Of String)()
        Dim exp_rateOutputLines As New List(Of String)()
        Dim exp_loss_rateOutputLines As New List(Of String)()
        Dim vanadiel_time_offsetOutputLines As New List(Of String)()
        Dim exp_loss_levelOutputLines As New List(Of String)()

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
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("exp_party_gap_penalties: 1", "exp_party_gap_penalties: 0"), False)
        End If

        If fov_party_gap_penaltiesCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_party_gap_penalties: 0", "fov_party_gap_penalties: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_party_gap_penalties: 1", "fov_party_gap_penalties: 0"), False)
        End If

        If fov_allow_allianceCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_allow_alliance: 0", "fov_allow_alliance: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("fov_allow_alliance: 1", "fov_allow_alliance: 0"), False)
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

        'Handles experience being retained on death
        If exp_retainCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("exp_retain: 0", "exp_retain: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("exp_retain: 1", "exp_retain: 0"), False)
        End If

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

    Private Sub ApplySettingsMapPage3Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage3Button.Click

        Dim speed_modOutputLines As New List(Of String)()
        Dim mob_speed_modOutputLines As New List(Of String)()
        Dim skillup_chance_multiplierOutputLines As New List(Of String)()
        Dim craft_chance_multiplierOutputLines As New List(Of String)()
        Dim skillup_amount_multiplierOutputLines As New List(Of String)()
        Dim craft_amount_multiplierOutputLines As New List(Of String)()

        If level_sync_enableCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("level_sync_enable: 0", "level_sync_enable: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("level_sync_enable: 1", "level_sync_enable: 0"), False)
        End If

        If all_jobs_widescanCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("all_jobs_widescan: 0", "all_jobs_widescan: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("all_jobs_widescan: 1", "all_jobs_widescan: 0"), False)
        End If

        'Handles player movement speed
        If speed_modNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim speed_modMatch As Boolean
                Dim mob_speed_modMatch As Boolean
                speed_modMatch = line.Contains("speed_mod:")
                mob_speed_modMatch = line.Contains("mob_speed_mod")
                If speed_modMatch And Not mob_speed_modMatch Then
                    speed_modOutputLines.Add("speed_mod: " + speed_modNumericUpDown.Text)
                Else
                    speed_modOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, speed_modOutputLines.ToArray(), Encoding.UTF8)
        End If

        If mob_speed_modNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mob_speed_modMatch As Boolean
                mob_speed_modMatch = line.Contains("mob_speed_mod")
                If mob_speed_modMatch Then
                    mob_speed_modOutputLines.Add("mob_speed_mod: " + mob_speed_modNumericUpDown.Text)
                Else
                    mob_speed_modOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mob_speed_modOutputLines.ToArray(), Encoding.UTF8)
        End If

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

    End Sub

    Private Sub ApplySettingsMapPage4Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage4Button.Click

        Dim mob_tp_multiplierOutputLines As New List(Of String)()
        Dim player_tp_multiplierOutputLines As New List(Of String)()
        Dim nm_hp_multiplierOutputLines As New List(Of String)()
        Dim mob_hp_multiplierOutputLines As New List(Of String)()
        Dim player_hp_multiplierOutputLines As New List(Of String)()
        Dim nm_mp_multiplierOutputLines As New List(Of String)()
        Dim mob_mp_multiplierOutputLines As New List(Of String)()
        Dim player_mp_multiplierOutputLines As New List(Of String)()
        Dim sj_mp_divisorOutputLines As New List(Of String)()

        If craft_day_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_day_matters: 0", "craft_day_matters: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_day_matters: 1", "craft_day_matters: 0"), False)
        End If

        If craft_moonphase_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_moonphase_matters: 0", "craft_moonphase_matters: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_moonphase_matters: 1", "craft_moonphase_matters: 0"), False)
        End If

        If craft_direction_mattersCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_direction_matters: 0", "craft_direction_matters: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("craft_direction_matters: 1", "craft_direction_matters: 0"), False)
        End If

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

    Private Sub ApplySettingsMapPage5Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage5Button.Click

        Dim nm_stat_multiplierOutputLines As New List(Of String)()
        Dim mob_stat_multiplierOutputLines As New List(Of String)()
        Dim player_stat_multiplierOutputLines As New List(Of String)()
        Dim drop_rate_multiplierOutputLines As New List(Of String)()
        Dim all_mobs_gil_bonusOutputLines As New List(Of String)()
        Dim max_gil_bonusOutputLines As New List(Of String)()
        Dim newstyle_skillupsOutputLines As New List(Of String)()
        Dim Battle_cap_tweakOutputLines As New List(Of String)()

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

        If all_mobs_gil_bonusNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim all_mobs_gil_bonusMatch As Boolean
                all_mobs_gil_bonusMatch = line.Contains("all_mobs_gil_bonus:")
                If all_mobs_gil_bonusMatch Then
                    all_mobs_gil_bonusOutputLines.Add("all_mobs_gil_bonus: " + all_mobs_gil_bonusNumericUpDown.Text)
                Else
                    all_mobs_gil_bonusOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, all_mobs_gil_bonusOutputLines.ToArray(), Encoding.UTF8)
        End If

        If max_gil_bonusNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim max_gil_bonusMatch As Boolean
                max_gil_bonusMatch = line.Contains("max_gil_bonus:")
                If max_gil_bonusMatch Then
                    max_gil_bonusOutputLines.Add("max_gil_bonus: " + max_gil_bonusNumericUpDown.Text)
                Else
                    max_gil_bonusOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, max_gil_bonusOutputLines.ToArray(), Encoding.UTF8)
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

        If Battle_cap_tweakNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim Battle_cap_tweakMatch As Boolean
                Battle_cap_tweakMatch = line.Contains("Battle_cap_tweak:")
                If Battle_cap_tweakMatch Then
                    Battle_cap_tweakOutputLines.Add("Battle_cap_tweak: " + Battle_cap_tweakNumericUpDown.Text)
                Else
                    Battle_cap_tweakOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, Battle_cap_tweakOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingsMapPage6Button_Click(sender As Object, e As EventArgs) Handles ApplySettingsMapPage6Button.Click

        Dim yell_cooldownOutputLines As New List(Of String)()

        If CoP_Battle_capCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 0", "CoP_Battle_cap: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 1", "CoP_Battle_cap: 0"), False)
        End If

        If max_merit_pointsNumericUpDown.Value = 30 Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("max_merit_points: 10", "max_merit_points: 30"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("max_merit_points: 30", "max_merit_points: 10"), False)
        End If

        'Handles yell timer
        If yell_cooldownNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim yell_cooldownMatch As Boolean
                yell_cooldownMatch = line.Contains("yell_cooldown:")
                If yell_cooldownMatch Then
                    yell_cooldownOutputLines.Add("yell_cooldown: " + yell_cooldownNumericUpDown.Text)
                Else
                    yell_cooldownOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, yell_cooldownOutputLines.ToArray(), Encoding.UTF8)
        End If

        If audit_chatCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_chat: 0", "audit_chat: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_chat: 1", "audit_chat: 0"), False)
        End If

        If audit_sayCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_say: 0", "audit_say: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_say: 1", "audit_say: 0"), False)
        End If

        If audit_shoutCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_shout: 0", "audit_shout: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_shout: 1", "audit_shout: 0"), False)
        End If

        If audit_tellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_tell: 0", "audit_tell: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_tell: 1", "audit_tell: 0"), False)
        End If

        If audit_yellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_yell: 0", "audit_yell: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_yell: 1", "audit_yell: 0"), False)
        End If

        If audit_linkshellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_linkshell: 0", "audit_linkshell: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_linkshell: 1", "audit_linkshell: 0"), False)
        End If

        If audit_partyCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_party: 0", "audit_party: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_party: 1", "audit_party: 0"), False)
        End If

    End Sub

    Private Sub all_mobs_gil_bonusNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If all_mobs_gil_bonusNumericUpDown.Value > max_gil_bonusNumericUpDown.Value Then
            all_mobs_gil_bonusNumericUpDown.Value = max_gil_bonusNumericUpDown.Value
        End If
    End Sub

    Private Sub ApplySettingsSearchButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsSearchButton.Click

        Dim expire_daysOutputLines As New List(Of String)()
        Dim expire_intervalOutputLines As New List(Of String)()

        'Handles activating/deactivating auction house expiration
        If expire_auctionsCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SearchConfFile, My.Computer.FileSystem.ReadAllText(SearchConfFile).Replace("expire_auctions: 0", "expire_auctions: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SearchConfFile, My.Computer.FileSystem.ReadAllText(SearchConfFile).Replace("expire_auctions: 1", "expire_auctions: 0"), False)
        End If

        'Handles number of days before auction house expiration
        If expire_daysNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim expire_daysMatch As Boolean
                expire_daysMatch = line.Contains("expire_days:")
                If expire_daysMatch Then
                    ' Replace line with string
                    expire_daysOutputLines.Add("expire_days: " + expire_daysNumericUpDown.Text)
                Else
                    expire_daysOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, expire_daysOutputLines.ToArray(), Encoding.UTF8)
        End If

        'Handles expiration interval
        If expire_intervalNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim expire_intervalMatch As Boolean
                expire_intervalMatch = line.Contains("expire_interval:")
                If expire_intervalMatch Then
                    ' Replace line with string
                    expire_intervalOutputLines.Add("expire_interval: " + expire_intervalNumericUpDown.Text)
                Else
                    expire_intervalOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, expire_intervalOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingPage1Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage1Button.Click

        Dim COPB As String
        Dim TOAUB As String
        Dim WOTGB As String
        Dim ACPB As String
        Dim AMKB As String
        Dim ASAB As String
        Dim ABYSSEAB As String
        Dim SOAB As String

        If COPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP     = 0;", "ENABLE_COP     = 1;"), False)
            COPB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP     = 1;", "ENABLE_COP     = 0;"), False)
            COPB = 0
        End If

        If TOAUCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_TOAU    = 0;", "ENABLE_TOAU    = 1;"), False)
            TOAUB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_TOAU    = 1;", "ENABLE_TOAU    = 0;"), False)
            TOAUB = 0
        End If

        If WOTGCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_WOTG    = 0;", "ENABLE_WOTG    = 1;"), False)
            WOTGB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_WOTG    = 1;", "ENABLE_WOTG    = 0;"), False)
            WOTGB = 0
        End If

        If ACPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ACP     = 0;", "ENABLE_ACP     = 1;"), False)
            ACPB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ACP     = 1;", "ENABLE_ACP     = 0;"), False)
            ACPB = 0
        End If

        If AMKCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_AMK     = 0;", "ENABLE_AMK     = 1;"), False)
            AMKB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_AMK     = 1;", "ENABLE_AMK     = 0;"), False)
            AMKB = 0
        End If

        If ASACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ASA     = 0;", "ENABLE_ASA     = 1;"), False)
            ASAB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ASA     = 1;", "ENABLE_ASA     = 0;"), False)
            ASAB = 0
        End If

        If ABYSSEACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ABYSSEA = 0;", "ENABLE_ABYSSEA = 1;"), False)
            ABYSSEAB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_ABYSSEA = 1;", "ENABLE_ABYSSEA = 0;"), False)
            ABYSSEAB = 0
        End If

        If SOACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_SOA     = 0;", "ENABLE_SOA     = 1;"), False)
            SOAB = 1
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_SOA     = 1;", "ENABLE_SOA     = 0;"), False)
            SOAB = 0
        End If

        If COPCheckBox.Checked = True And TOAUCheckBox.Checked = True And WOTGCheckBox.Checked = True And ACPCheckBox.Checked = True And AMKCheckBox.Checked = True And ASACheckBox.Checked = True And ABYSSEACheckBox.Checked = True And SOACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 1;", "RESTRICT_BY_EXPANSION = 0;"), False)
            RESTRICT_BY_EXPANSIONCheckBox.Checked = False
        Else
            If RESTRICT_BY_EXPANSIONCheckBox.Checked = True Then
                My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 0;", "RESTRICT_BY_EXPANSION = 1;"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("RESTRICT_BY_EXPANSION = 1;", "RESTRICT_BY_EXPANSION = 0;"), False)
            End If
        End If

        Dim LoginExpansionControl As String
        LoginExpansionControl = 2 + (COPB * 4) + (TOAUB * 8) + (WOTGB * 16) + (ACPB * 32) + (AMKB * 64) + (ASAB * 128) + (ABYSSEAB * 256) + (ABYSSEAB * 512) + (ABYSSEAB * 1024) + (SOAB * 2048)

        Dim expansionsLoginOutputLines As New List(Of String)()

        'Handles Login conf expansion
        For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
            Dim expansionsLoginMatch As Boolean
            expansionsLoginMatch = line.Contains("expansions:")
            If expansionsLoginMatch Then
                ' Replace line with string
                expansionsLoginOutputLines.Add("expansions: " + LoginExpansionControl)
            Else
                expansionsLoginOutputLines.Add(line)
            End If
        Next
        System.IO.File.WriteAllLines(LoginConfFile, expansionsLoginOutputLines.ToArray(), Encoding.UTF8)

        
    End Sub

    Private Sub ApplySettingPage2Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage2Button.Click

        

    End Sub

    Private Sub ApplySettingPage3Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage3Button.Click

        If USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        End If

    End Sub

    Private Sub ApplySettingPage4Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage4Button.Click

        If CoP_Battle_capCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 0", "CoP_Battle_cap: 1"), False)
        Else
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("CoP_Battle_cap: 1", "CoP_Battle_cap: 0"), False)
        End If

        If ENABLE_COP_ZONE_CAPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap"), False)
        End If

    End Sub

    Private Sub ApplySettingPage5Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage5Button.Click

    End Sub

    Private Sub ApplySettingPage6Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage6Button.Click

    End Sub

    Private Sub ApplySettingPage7Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage7Button.Click

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

        If USE_OLD_CURE_FORMULACheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_OLD_CURE_FORMULA = false; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula", "USE_OLD_CURE_FORMULA = true; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_OLD_CURE_FORMULA = true; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula", "USE_OLD_CURE_FORMULA = false; -- true/false. if true, uses older cure formula (3*MND + VIT + 3*(healing skill/5)) // cure 6 will use the newer formula"), False)
        End If
    End Sub

    Private Sub ApplySettingPage8Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage8Button.Click

    End Sub

    Private Sub ApplySettingPage9Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage9Button.Click

        Dim VISITANT_BONUSOutputLines As New List(Of String)()

        If VISITANT_BONUSNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim VISITANT_BONUSMatch As Boolean
                VISITANT_BONUSMatch = line.Contains("VISITANT_BONUS")
                If VISITANT_BONUSMatch Then
                    VISITANT_BONUSOutputLines.Add("VISITANT_BONUS = " + VISITANT_BONUSNumericUpDown.Text + "; -- Default: 1.00 - (retail) - Multiplies the base time value of each Traverser Stone.")
                Else
                    VISITANT_BONUSOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, VISITANT_BONUSOutputLines.ToArray(), Encoding.UTF8)
        End If
    End Sub

    Private Sub ApplySettingsDatabaseSettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsDatabaseSettingsButton.Click

        Dim mysql_hostLoginOutputLines As New List(Of String)()
        Dim mysql_hostMapOutputLines As New List(Of String)()
        Dim mysql_hostSearchOutputLines As New List(Of String)()
        Dim mysql_portLoginOutputLines As New List(Of String)()
        Dim mysql_portMapOutputLines As New List(Of String)()
        Dim mysql_portSearchOutputLines As New List(Of String)()
        Dim mysql_loginLoginOutputLines As New List(Of String)()
        Dim mysql_loginMapOutputLines As New List(Of String)()
        Dim mysql_loginSearchOutputLines As New List(Of String)()
        Dim mysql_passwordLoginOutputLines As New List(Of String)()
        Dim mysql_passwordMapOutputLines As New List(Of String)()
        Dim mysql_passwordSearchOutputLines As New List(Of String)()
        Dim mysql_databaseLoginOutputLines As New List(Of String)()
        Dim mysql_databaseMapOutputLines As New List(Of String)()
        Dim mysql_databaseSearchOutputLines As New List(Of String)()
        Dim msg_server_portLoginOutputLines As New List(Of String)()
        Dim msg_server_portMapOutputLines As New List(Of String)()
        Dim msg_server_ipLoginOutputLines As New List(Of String)()
        Dim msg_server_ipMapOutputLines As New List(Of String)()

        'mysql ip host change
        If mysql_hostTextBox.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim mysql_hostLoginMatch As Boolean
                mysql_hostLoginMatch = line.Contains("mysql_host:")
                If mysql_hostLoginMatch Then
                    ' Replace line with string
                    mysql_hostLoginOutputLines.Add("mysql_host:      " + mysql_hostTextBox.Text)
                Else
                    mysql_hostLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, mysql_hostLoginOutputLines.ToArray(), Encoding.UTF8)

            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim msg_server_ipLoginMatch As Boolean
                msg_server_ipLoginMatch = line.Contains("msg_server_ip:")
                If msg_server_ipLoginMatch Then
                    ' Replace line with string
                    msg_server_ipLoginOutputLines.Add("msg_server_ip: " + mysql_hostTextBox.Text)
                Else
                    msg_server_ipLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, msg_server_ipLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mysql_hostMapMatch As Boolean
                mysql_hostMapMatch = line.Contains("mysql_host:")
                If mysql_hostMapMatch Then
                    ' Replace line with string
                    mysql_hostMapOutputLines.Add("mysql_host:      " + mysql_hostTextBox.Text)
                Else
                    mysql_hostMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mysql_hostMapOutputLines.ToArray(), Encoding.UTF8)

            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim msg_server_ipMapMatch As Boolean
                msg_server_ipMapMatch = line.Contains("msg_server_ip:")
                If msg_server_ipMapMatch Then
                    ' Replace line with string
                    msg_server_ipMapOutputLines.Add("msg_server_ip: " + mysql_hostTextBox.Text)
                Else
                    msg_server_ipMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, msg_server_ipMapOutputLines.ToArray(), Encoding.UTF8)

            'Search
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim mysql_hostSearchMatch As Boolean
                mysql_hostSearchMatch = line.Contains("mysql_host:")
                If mysql_hostSearchMatch Then
                    ' Replace line with string
                    mysql_hostSearchOutputLines.Add("mysql_host:      " + mysql_hostTextBox.Text)
                Else
                    mysql_hostSearchOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, mysql_hostSearchOutputLines.ToArray(), Encoding.UTF8)
        End If

        'mysql port change
        If mysql_portNumericUpDown.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim mysql_portLoginMatch As Boolean
                mysql_portLoginMatch = line.Contains("mysql_port:")
                If mysql_portLoginMatch Then
                    ' Replace line with string
                    mysql_portLoginOutputLines.Add("mysql_port:      " + mysql_portNumericUpDown.Text)
                Else
                    mysql_portLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, mysql_portLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mysql_portMapMatch As Boolean
                mysql_portMapMatch = line.Contains("mysql_port:")
                If mysql_portMapMatch Then
                    ' Replace line with string
                    mysql_portMapOutputLines.Add("mysql_port:      " + mysql_portNumericUpDown.Text)
                Else
                    mysql_portMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mysql_portMapOutputLines.ToArray(), Encoding.UTF8)

            'Search
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim mysql_portSearchMatch As Boolean
                mysql_portSearchMatch = line.Contains("mysql_port:")
                If mysql_portSearchMatch Then
                    ' Replace line with string
                    mysql_portSearchOutputLines.Add("mysql_port:      " + mysql_portNumericUpDown.Text)
                Else
                    mysql_portSearchOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, mysql_portSearchOutputLines.ToArray(), Encoding.UTF8)

        End If

        'mysql login change
        If mysql_loginTextBox.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim mysql_loginLoginMatch As Boolean
                mysql_loginLoginMatch = line.Contains("mysql_login:")
                If mysql_loginLoginMatch Then
                    ' Replace line with string
                    mysql_loginLoginOutputLines.Add("mysql_login:     " + mysql_loginTextBox.Text)
                Else
                    mysql_loginLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, mysql_loginLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mysql_loginMapMatch As Boolean
                mysql_loginMapMatch = line.Contains("mysql_login:")
                If mysql_loginMapMatch Then
                    ' Replace line with string
                    mysql_loginMapOutputLines.Add("mysql_login:     " + mysql_loginTextBox.Text)
                Else
                    mysql_loginMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mysql_loginMapOutputLines.ToArray(), Encoding.UTF8)

            'Search
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim mysql_loginSearchMatch As Boolean
                mysql_loginSearchMatch = line.Contains("mysql_login:")
                If mysql_loginSearchMatch Then
                    ' Replace line with string
                    mysql_loginSearchOutputLines.Add("mysql_login:     " + mysql_loginTextBox.Text)
                Else
                    mysql_loginSearchOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, mysql_loginSearchOutputLines.ToArray(), Encoding.UTF8)
        End If

        'mysql password change
        If mysql_passwordTextBox.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim mysql_passwordLoginMatch As Boolean
                mysql_passwordLoginMatch = line.Contains("mysql_password:")
                If mysql_passwordLoginMatch Then
                    ' Replace line with string
                    mysql_passwordLoginOutputLines.Add("mysql_password:  " + mysql_passwordTextBox.Text)
                Else
                    mysql_passwordLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, mysql_passwordLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mysql_passwordMapMatch As Boolean
                mysql_passwordMapMatch = line.Contains("mysql_password:")
                If mysql_passwordMapMatch Then
                    ' Replace line with string
                    mysql_passwordMapOutputLines.Add("mysql_password:  " + mysql_passwordTextBox.Text)
                Else
                    mysql_passwordMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mysql_passwordMapOutputLines.ToArray(), Encoding.UTF8)

            'Search
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim mysql_passwordSearchMatch As Boolean
                mysql_passwordSearchMatch = line.Contains("mysql_password:")
                If mysql_passwordSearchMatch Then
                    ' Replace line with string
                    mysql_passwordSearchOutputLines.Add("mysql_password:  " + mysql_passwordTextBox.Text)
                Else
                    mysql_passwordSearchOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, mysql_passwordSearchOutputLines.ToArray(), Encoding.UTF8)
        End If

        'mysql database name change
        If mysql_databaseTextBox.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim mysql_databaseLoginMatch As Boolean
                mysql_databaseLoginMatch = line.Contains("mysql_database:")
                If mysql_databaseLoginMatch Then
                    ' Replace line with string
                    mysql_databaseLoginOutputLines.Add("mysql_database:  " + mysql_databaseTextBox.Text)
                Else
                    mysql_databaseLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, mysql_databaseLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim mysql_databaseMapMatch As Boolean
                mysql_databaseMapMatch = line.Contains("mysql_database:")
                If mysql_databaseMapMatch Then
                    ' Replace line with string
                    mysql_databaseMapOutputLines.Add("mysql_database:  " + mysql_databaseTextBox.Text)
                Else
                    mysql_databaseMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, mysql_databaseMapOutputLines.ToArray(), Encoding.UTF8)

            'Search
            For Each line As String In System.IO.File.ReadAllLines(SearchConfFile)
                Dim mysql_databaseSearchMatch As Boolean
                mysql_databaseSearchMatch = line.Contains("mysql_database:")
                If mysql_databaseSearchMatch Then
                    ' Replace line with string
                    mysql_databaseSearchOutputLines.Add("mysql_database:  " + mysql_databaseTextBox.Text)
                Else
                    mysql_databaseSearchOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SearchConfFile, mysql_databaseSearchOutputLines.ToArray(), Encoding.UTF8)
        End If

        'message server port
        If msg_server_portNumericUpDown.Text.Length < 1 Then
        Else
            'Login
            For Each line As String In System.IO.File.ReadAllLines(LoginConfFile)
                Dim msg_server_portLoginMatch As Boolean
                msg_server_portLoginMatch = line.Contains("msg_server_port:")
                If msg_server_portLoginMatch Then
                    ' Replace line with string
                    msg_server_portLoginOutputLines.Add("msg_server_port:  " + msg_server_portNumericUpDown.Text)
                Else
                    msg_server_portLoginOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(LoginConfFile, msg_server_portLoginOutputLines.ToArray(), Encoding.UTF8)

            'Map
            For Each line As String In System.IO.File.ReadAllLines(MapConfFile)
                Dim msg_server_portMapMatch As Boolean
                msg_server_portMapMatch = line.Contains("msg_server_port:")
                If msg_server_portMapMatch Then
                    ' Replace line with string
                    msg_server_portMapOutputLines.Add("msg_server_port:  " + msg_server_portNumericUpDown.Text)
                Else
                    msg_server_portMapOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(MapConfFile, msg_server_portMapOutputLines.ToArray(), Encoding.UTF8)
        End If

        mysql_hostLoginTextBox.Text = mysql_hostTextBox.Text

    End Sub

    Private Sub ApplySettingsMiscButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsMiscButton.Click

        Dim BlueSpellGaplevelLearnOutputLines As New List(Of String)()

        'Handles removing AH submission limits
        If no_auction_limitsCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(AHCPP, My.Computer.FileSystem.ReadAllText(AHCPP).Replace("< 7", "< 9"), False)
        Else
            My.Computer.FileSystem.WriteAllText(AHCPP, My.Computer.FileSystem.ReadAllText(AHCPP).Replace("< 9", "< 7"), False)
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