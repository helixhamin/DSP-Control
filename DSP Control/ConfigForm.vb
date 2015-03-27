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

        timestamp_formatLoginTextBox.Text = My.Settings.timestamp_formatLogin
        stdout_with_ansisequenceLoginTextBox.Text = My.Settings.stdout_with_ansisequenceLogin
        console_silentLoginNumericUpDown.Text = My.Settings.console_silentLogin
        search_server_portNumericUpDown.Text = My.Settings.search_server_port

        servernameTextBox.Text = My.Settings.servername

        map_portNumericUpDown.Text = My.Settings.map_port
        timestamp_formatMapTextBox.Text = My.Settings.timestamp_formatMap
        stdout_with_ansisequenceMapTextBox.Text = My.Settings.stdout_with_ansisequenceMap
        console_silentMapNumericUpDown.Text = My.Settings.console_silentMap

        buff_maxsizeNumericUpDown.Text = My.Settings.buff_maxsize
        max_time_lastupdateNumericUpDown.Text = My.Settings.max_time_lastupdate
        lightluggage_blockNumericUpDown.Text = My.Settings.lightluggage_block
        exp_rateNumericUpDown.Text = My.Settings.exp_rate
        exp_loss_rateNumericUpDown.Text = My.Settings.exp_loss_rate
        exp_party_gap_penaltiesCheckBox.Checked = My.Settings.exp_party_gap_penalties
        fov_party_gap_penaltiesCheckBox.Checked = My.Settings.fov_party_gap_penalties
        fov_allow_allianceCheckBox.Checked = My.Settings.fov_allow_alliance
        vanadiel_time_offsetNumericUpDown.Text = My.Settings.vanadiel_time_offset
        exp_retainCheckBox.Checked = My.Settings.exp_retain
        exp_loss_levelNumericUpDown.Text = My.Settings.exp_loss_level

        level_sync_enableCheckBox.Checked = My.Settings.level_sync_enable
        all_jobs_widescanCheckBox.Checked = My.Settings.all_jobs_widescan
        speed_modNumericUpDown.Text = My.Settings.speed_mod
        mob_speed_modNumericUpDown.Text = My.Settings.mob_speed_mod
        skillup_chance_multiplierNumericUpDown.Text = My.Settings.skillup_chance_multiplier
        craft_chance_multiplierNumericUpDown.Text = My.Settings.craft_chance_multiplier
        skillup_amount_multiplierNumericUpDown.Text = My.Settings.skillup_amount_multiplier
        craft_amount_multiplierNumericUpDown.Text = My.Settings.craft_amount_multiplier

        craft_day_mattersCheckBox.Checked = My.Settings.craft_day_matters
        craft_moonphase_mattersCheckBox.Checked = My.Settings.craft_moonphase_matters
        craft_direction_mattersCheckBox.Checked = My.Settings.craft_direction_matters
        mob_tp_multiplierNumericUpDown.Text = My.Settings.mob_tp_multiplier
        player_tp_multiplierNumericUpDown.Text = My.Settings.player_tp_multiplier
        nm_hp_multiplierNumericUpDown.Text = My.Settings.nm_hp_multiplier
        mob_hp_multiplierNumericUpDown.Text = My.Settings.mob_hp_multiplier
        player_hp_multiplierNumericUpDown.Text = My.Settings.player_hp_multiplier
        nm_mp_multiplierNumericUpDown.Text = My.Settings.nm_mp_multiplier
        mob_mp_multiplierNumericUpDown.Text = My.Settings.mob_mp_multiplier
        player_mp_multiplierNumericUpDown.Text = My.Settings.player_mp_multiplier
        sj_mp_divisorNumericUpDown.Text = My.Settings.sj_mp_divisor

        nm_stat_multiplierNumericUpDown.Text = My.Settings.nm_stat_multiplier
        mob_stat_multiplierNumericUpDown.Text = My.Settings.mob_stat_multiplier
        player_stat_multiplierNumericUpDown.Text = My.Settings.player_stat_multiplier
        drop_rate_multiplierNumericUpDown.Text = My.Settings.drop_rate_multiplier
        all_mobs_gil_bonusNumericUpDown.Text = My.Settings.all_mobs_gil_bonus
        max_gil_bonusNumericUpDown.Text = My.Settings.max_gil_bonus
        newstyle_skillupsNumericUpDown.Text = My.Settings.newstyle_skillups
        Battle_cap_tweakNumericUpDown.Text = My.Settings.Battle_cap_tweak

        CoP_Battle_capCheckBox.Checked = My.Settings.CoP_Battle_cap
        max_merit_pointsNumericUpDown.Text = My.Settings.max_merit_points
        yell_cooldownNumericUpDown.Text = My.Settings.yell_cooldown
        audit_chatCheckBox.Checked = My.Settings.audit_chat
        audit_sayCheckBox.Checked = My.Settings.audit_say
        audit_shoutCheckBox.Checked = My.Settings.audit_shout
        audit_tellCheckBox.Checked = My.Settings.audit_tell
        audit_yellCheckBox.Checked = My.Settings.audit_yell
        audit_linkshellCheckBox.Checked = My.Settings.audit_linkshell
        audit_partyCheckBox.Checked = My.Settings.audit_party

        expire_auctionsCheckBox.Checked = My.Settings.expire_auctions
        expire_daysNumericUpDown.Text = My.Settings.expire_days
        expire_intervalNumericUpDown.Text = My.Settings.expire_interval

        COPCheckBox.Checked = My.Settings.ENABLE_COP
        TOAUCheckBox.Checked = My.Settings.ENABLE_TOAU
        WOTGCheckBox.Checked = My.Settings.ENABLE_WOTG
        ACPCheckBox.Checked = My.Settings.ENABLE_ACP
        AMKCheckBox.Checked = My.Settings.ENABLE_AMK
        ASACheckBox.Checked = My.Settings.ENABLE_ASA
        ABYSSEACheckBox.Checked = My.Settings.ENABLE_ABYSSEA
        SOACheckBox.Checked = My.Settings.ENABLE_SOA
        RESTRICT_BY_EXPANSIONCheckBox.Checked = My.Settings.RESTRICT_BY_EXPANSION

        INITIAL_LEVEL_CAPNumericUpDown.Text = My.Settings.INITIAL_LEVEL_CAP
        MAX_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text = My.Settings.NORMAL_MOB_MAX_LEVEL_RANGE_MIN
        NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text = My.Settings.NORMAL_MOB_MAX_LEVEL_RANGE_MAX
        START_GILNumericUpDown.Text = My.Settings.START_GIL
        START_INVENTORYNumericUpDown.Text = My.Settings.START_INVENTORY
        OPENING_CUTSCENE_ENABLECheckBox.Checked = My.Settings.OPENING_CUTSCENE_ENABLE
        SUBJOB_QUEST_LEVELNumericUpDown.Text = My.Settings.SUBJOB_QUEST_LEVEL
        ADVANCED_JOB_LEVELNumericUpDown.Text = My.Settings.ADVANCED_JOB_LEVEL
        ALL_MAPSCheckBox.Checked = My.Settings.ALL_MAPS
        UNLOCK_OUTPOST_WARPSNumericUpDown.Text = My.Settings.UNLOCK_OUTPOST_WARPS
        SHOP_PRICENumericUpDown.Text = My.Settings.SHOP_PRICE
        GIL_RATENumericUpDown.Text = My.Settings.GIL_RATE
        EXP_RATEFOVNumericUpDown.Text = My.Settings.EXP_RATEFOV
        TABS_RATENumericUpDown.Text = My.Settings.TABS_RATE
        SAN_FAMENumericUpDown.Text = My.Settings.SAN_FAME
        BAS_FAMENumericUpDown.Text = My.Settings.BAS_FAME
        WIN_FAMENumericUpDown.Text = My.Settings.WIN_FAME
        NORG_FAMENumericUpDown.Text = My.Settings.NORG_FAME
        JEUNO_FAMENumericUpDown.Text = My.Settings.JEUNO_FAME

        FISHING_GUILD_POINTSNumericUpDown.Text = My.Settings.FISHING_GUILD_POINTS
        WOODWORKING_GUILD_POINTSNumericUpDown.Text = My.Settings.WOODWORKING_GUILD_POINTS
        SMITHING_GUILD_POINTSNumericUpDown.Text = My.Settings.SMITHING_GUILD_POINTS
        GOLDSMITHING_GUILD_POINTSNumericUpDown.Text = My.Settings.GOLDSMITHING_GUILD_POINTS
        CLOTHCRAFT_GUILD_POINTSNumericUpDown.Text = My.Settings.CLOTHCRAFT_GUILD_POINTS
        LEATHERCRAFT_GUILD_POINTSNumericUpDown.Text = My.Settings.LEATHERCRAFT_GUILD_POINTS
        BONECRAFT_GUILD_POINTSNumericUpDown.Text = My.Settings.BONECRAFT_GUILD_POINTS
        ALCHEMY_GUILD_POINTSNumericUpDown.Text = My.Settings.ALCHEMY_GUILD_POINTS
        COOKING_GUILD_POINTSNumericUpDown.Text = My.Settings.COOKING_GUILD_POINTS
        DISABLE_GUILD_CONTRACTSCheckBox.Checked = My.Settings.DISABLE_GUILD_CONTRACTS
        CURE_POWERNumericUpDown.Text = My.Settings.CURE_POWER
        SPELL_POWERNumericUpDown.Text = My.Settings.SPELL_POWER
        BLUE_POWERNumericUpDown.Text = My.Settings.BLUE_POWER
        DRAIN_POWERNumericUpDown.Text = My.Settings.DRAIN_POWER
        ITEM_POWERNumericUpDown.Text = My.Settings.ITEM_POWER
        WEAPON_SKILL_POWERNumericUpDown.Text = My.Settings.WEAPON_SKILL_POWER
        WEAPON_SKILL_POINTSNumericUpDown.Text = My.Settings.WEAPON_SKILL_POINTS
        USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = My.Settings.USE_ADOULIN_WEAPON_SKILL_CHANGES

        HARVESTING_BREAK_CHANCENumericUpDown.Text = My.Settings.HARVESTING_BREAK_CHANCE
        EXCAVATION_BREAK_CHANCENumericUpDown.Text = My.Settings.EXCAVATION_BREAK_CHANCE
        LOGGING_BREAK_CHANCENumericUpDown.Text = My.Settings.LOGGING_BREAK_CHANCE
        MINING_BREAK_CHANCENumericUpDown.Text = My.Settings.MINING_BREAK_CHANCE
        HARVESTING_RATENumericUpDown.Text = My.Settings.HARVESTING_RATE
        EXCAVATION_RATENumericUpDown.Text = My.Settings.EXCAVATION_RATE
        LOGGING_RATENumericUpDown.Text = My.Settings.LOGGING_RATE
        MINING_RATENumericUpDown.Text = My.Settings.MINING_RATE
        COFFER_MAX_ILLUSION_TIMENumericUpDown.Text = My.Settings.COFFER_MAX_ILLUSION_TIME
        COFFER_MIN_ILLUSION_TIMENumericUpDown.Text = My.Settings.COFFER_MIN_ILLUSION_TIME
        CHEST_MAX_ILLUSION_TIMENumericUpDown.Text = My.Settings.CHEST_MAX_ILLUSION_TIME
        CHEST_MIN_ILLUSION_TIMENumericUpDown.Text = My.Settings.CHEST_MIN_ILLUSION_TIME
        LandKingSystem_NQNumericUpDown.Text = My.Settings.LandKingSystem_NQ
        LandKingSystem_HQNumericUpDown.Text = My.Settings.LandKingSystem_HQ

        BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text = My.Settings.BETWEEN_2DYNA_WAIT_TIME
        DYNA_LEVEL_MINNumericUpDown.Text = My.Settings.DYNA_LEVEL_MIN
        TIMELESS_HOURGLASS_COSTNumericUpDown.Text = My.Settings.TIMELESS_HOURGLASS_COST
        CURRENCY_EXCHANGE_RATENumericUpDown.Text = My.Settings.CURRENCY_EXCHANGE_RATE
        RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text = My.Settings.RELIC_2ND_UPGRADE_WAIT_TIME
        RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text = My.Settings.RELIC_3RD_UPGRADE_WAIT_TIME
        FREE_COP_DYNAMISCheckBox.Checked = My.Settings.FREE_COP_DYNAMIS
        WSNM_LEVELNumericUpDown.Text = My.Settings.WSNM_LEVEL
        WSNM_SKILL_LEVELNumericUpDown.Text = My.Settings.WSNM_SKILL_LEVEL
        AF1_QUEST_LEVELNumericUpDown.Text = My.Settings.AF1_QUEST_LEVEL
        AF2_QUEST_LEVELNumericUpDown.Text = My.Settings.AF2_QUEST_LEVEL
        AF3_QUEST_LEVELNumericUpDown.Text = My.Settings.AF3_QUEST_LEVEL
        AF1_FAMENumericUpDown.Text = My.Settings.AF1_FAME
        AF2_FAMENumericUpDown.Text = My.Settings.AF2_FAME
        AF3_FAMENumericUpDown.Text = My.Settings.AF3_FAME
        DEBUG_MODECheckBox.Checked = My.Settings.DEBUG_MODE
        QM_RESET_TIMENumericUpDown.Text = My.Settings.QM_RESET_TIME
        OldSchoolG1CheckBox.Checked = My.Settings.OldSchoolG1
        OldSchoolG2CheckBox.Checked = My.Settings.OldSchoolG2
        FrigiciteDurationNumericUpDown.Text = My.Settings.FrigiciteDuration

        REGIME_WAITCheckBox.Checked = My.Settings.REGIME_WAIT
        FIELD_MANUALSCheckBox.Checked = My.Settings.FIELD_MANUALS
        LOW_LEVEL_REGIMECheckBox.Checked = My.Settings.LOW_LEVEL_REGIME
        GROUNDS_TOMESCheckBox.Checked = My.Settings.GROUNDS_TOMES
        SCAVENGE_RATENumericUpDown.Text = My.Settings.SCAVENGE_RATE
        STATUS_RESIST_MULTIPLIERNumericUpDown.Text = My.Settings.STATUS_RESIST_MULTIPLIER
        CIRCLE_DURATIONNumericUpDown.Text = My.Settings.CIRCLE_DURATION
        CIRCLE_KILLER_EFFECTNumericUpDown.Text = My.Settings.CIRCLE_KILLER_EFFECT
        KILLER_EFFECTNumericUpDown.Text = My.Settings.KILLER_EFFECT

        MILK_OVERWRITECheckBox.Checked = My.Settings.MILK_OVERWRITE
        JUICE_OVERWRITECheckBox.Checked = My.Settings.JUICE_OVERWRITE
        DIA_OVERWRITECheckBox.Checked = My.Settings.DIA_OVERWRITE
        BIO_OVERWRITECheckBox.Checked = My.Settings.BIO_OVERWRITE
        BARELEMENT_OVERWRITECheckBox.Checked = My.Settings.BARELEMENT_OVERWRITE
        BARSTATUS_OVERWRITECheckBox.Checked = My.Settings.BARSTATUS_OVERWRITE
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
        USE_OLD_CURE_FORMULACheckBox.Checked = My.Settings.USE_OLD_CURE_FORMULA

        EXPLORER_MOOGLECheckBox.Checked = My.Settings.EXPLORER_MOOGLE
        EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Text = My.Settings.EXPLORER_MOOGLE_LEVELCAP
        JINX_MODE_2005CheckBox.Checked = My.Settings.JINX_MODE_2005
        JINX_MODE_2008CheckBox.Checked = My.Settings.JINX_MODE_2008
        JINX_MODE_2012CheckBox.Checked = My.Settings.JINX_MODE_2012
        SUMMERFEST_2004CheckBox.Checked = My.Settings.SUMMERFEST_2004
        SUNBREEZE_2009CheckBox.Checked = My.Settings.SUNBREEZE_2009
        SUNBREEZE_2011CheckBox.Checked = My.Settings.SUNBREEZE_2011
        CHRISTMASCheckBox.Checked = My.Settings.CHRISTMAS
        HALLOWEENCheckBox.Checked = My.Settings.HALLOWEEN
        HALLOWEEN_2005CheckBox.Checked = My.Settings.HALLOWEEN_2005
        HALLOWEEN_YEAR_ROUNDCheckBox.Checked = My.Settings.HALLOWEEN_YEAR_ROUND
        HOMEPOINT_HEALCheckBox.Checked = My.Settings.HOMEPOINT_HEAL
        RIVERNE_PORTERSNumericUpDown.Text = My.Settings.RIVERNE_PORTERS
        LANTERNS_STAY_LITNumericUpDown.Text = My.Settings.LANTERNS_STAY_LIT
        ENABLE_COP_ZONE_CAPCheckBox.Checked = My.Settings.ENABLE_COP_ZONE_CAP
        TIMEZONE_OFFSETNumericUpDown.Text = My.Settings.TIMEZONE_OFFSET
        ALLOW_MULTIPLE_EXP_RINGSCheckBox.Checked = My.Settings.ALLOW_MULTIPLE_EXP_RINGS
        BYPASS_EXP_RING_ONE_PER_WEEKCheckBox.Checked = My.Settings.BYPASS_EXP_RING_ONE_PER_WEEK
        NUMBER_OF_DM_EARRINGSNumericUpDown.Text = My.Settings.NUMBER_OF_DM_EARRINGS
        HOMEPOINT_TELEPORTCheckBox.Checked = My.Settings.HOMEPOINT_TELEPORT

        BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text = My.Settings.BETWEEN_2COSMOCLEANSE_WAIT_TIME
        DIMENSIONAL_PORTAL_UNLOCKCheckBox.Checked = My.Settings.DIMENSIONAL_PORTAL_UNLOCK
        VISITANT_BONUSNumericUpDown.Text = My.Settings.VISITANT_BONUS

        mysql_hostTextBox.Text = My.Settings.mysql_host
        mysql_hostLoginTextBox.Text = My.Settings.mysql_host
        mysql_portNumericUpDown.Text = My.Settings.mysql_port
        mysql_loginTextBox.Text = My.Settings.mysql_login
        mysql_passwordTextBox.Text = My.Settings.mysql_password
        mysql_databaseTextBox.Text = My.Settings.mysql_database
        msg_server_portNumericUpDown.Text = My.Settings.msg_server_port

        no_auction_limitsCheckBox.Checked = My.Settings.no_auction_limits
        BlueSpellGaplevelLearnNumericUpDown.Text = My.Settings.BlueSpellGaplevelLearn

        LoginExpansionControlTextBox.Text = My.Settings.LoginExpansionControl

        If OldSchoolG2CheckBox.Checked = True Then
            FrigiciteDurationNumericUpDown.Enabled = True
        Else
            FrigiciteDurationNumericUpDown.Enabled = False
        End If
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

        Dim INITIAL_LEVEL_CAPOutputLines As New List(Of String)()
        Dim MAX_LEVELOutputLines As New List(Of String)()
        Dim NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines As New List(Of String)()
        Dim NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines As New List(Of String)()
        Dim START_GILOutputLines As New List(Of String)()
        Dim START_INVENTORYOutputLines As New List(Of String)()
        Dim SUBJOB_QUEST_LEVELOutputLines As New List(Of String)()
        Dim ADVANCED_JOB_LEVELOutputLines As New List(Of String)()
        Dim UNLOCK_OUTPOST_WARPSOutputLines As New List(Of String)()
        Dim SHOP_PRICEOutputLines As New List(Of String)()
        Dim GIL_RATEOutputLines As New List(Of String)()
        Dim TABS_RATEOutputLines As New List(Of String)()
        Dim EXP_RATEFOVOutputLines As New List(Of String)()
        Dim SAN_FAMEOutputLines As New List(Of String)()
        Dim BAS_FAMEOutputLines As New List(Of String)()
        Dim WIN_FAMEOutputLines As New List(Of String)()
        Dim NORG_FAMEOutputLines As New List(Of String)()
        Dim JEUNO_FAMEOutputLines As New List(Of String)()

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

        'Handles Maximum player level
        If MAX_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MAX_LEVELMatch As Boolean
                Dim NORMAL_MOB_MAX_LEVELMatch As Boolean
                MAX_LEVELMatch = line.Contains("MAX_LEVEL")
                NORMAL_MOB_MAX_LEVELMatch = line.Contains("NORMAL_MOB")
                If MAX_LEVELMatch And Not NORMAL_MOB_MAX_LEVELMatch Then
                    MAX_LEVELOutputLines.Add("MAX_LEVEL = " + MAX_LEVELNumericUpDown.Text + "; -- Level max of the server, lowers the attainable cap by disabling Limit Break quests.")
                Else
                    MAX_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MAX_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch As Boolean
                NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch = line.Contains("NORMAL_MOB_MAX_LEVEL_RANGE_MIN")
                If NORMAL_MOB_MAX_LEVEL_RANGE_MINMatch Then
                    NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.Add("NORMAL_MOB_MAX_LEVEL_RANGE_MIN = " + NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Text + "; -- Lower Bound of Max Level Range for Normal Mobs (0 = Uncapped)")
                Else
                    NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORMAL_MOB_MAX_LEVEL_RANGE_MINOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch As Boolean
                NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch = line.Contains("NORMAL_MOB_MAX_LEVEL_RANGE_MAX")
                If NORMAL_MOB_MAX_LEVEL_RANGE_MAXMatch Then
                    NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.Add("NORMAL_MOB_MAX_LEVEL_RANGE_MAX = " + NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Text + "; -- Upper Bound of Max Level Range for Normal Mobs (0 = Uncapped)")
                Else
                    NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORMAL_MOB_MAX_LEVEL_RANGE_MAXOutputLines.ToArray(), Encoding.UTF8)
        End If

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

        If OPENING_CUTSCENE_ENABLECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OPENING_CUTSCENE_ENABLE = 0; --Set to 1 to enable opening cutscenes, 0 to disable.", "OPENING_CUTSCENE_ENABLE = 1; --Set to 1 to enable opening cutscenes, 0 to disable."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OPENING_CUTSCENE_ENABLE = 1; --Set to 1 to enable opening cutscenes, 0 to disable.", "OPENING_CUTSCENE_ENABLE = 0; --Set to 1 to enable opening cutscenes, 0 to disable."), False)
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

        If ALL_MAPSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALL_MAPS = 0; -- Set to 1 to give starting characters all the maps.", "ALL_MAPS = 1; -- Set to 1 to give starting characters all the maps."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ALL_MAPS = 1; -- Set to 1 to give starting characters all the maps.", "ALL_MAPS = 0; -- Set to 1 to give starting characters all the maps."), False)
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

        If EXP_RATEFOVNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXP_RATEFOVMatch As Boolean
                EXP_RATEFOVMatch = line.Contains("EXP_RATE")
                If EXP_RATEFOVMatch Then
                    EXP_RATEFOVOutputLines.Add("EXP_RATE   = " + EXP_RATEFOVNumericUpDown.Text + "; -- Multiplies exp earned from fov.")
                Else
                    EXP_RATEFOVOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXP_RATEFOVOutputLines.ToArray(), Encoding.UTF8)
        End If

        If TABS_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim TABS_RATEMatch As Boolean
                TABS_RATEMatch = line.Contains("TABS_RATE")
                If TABS_RATEMatch Then
                    TABS_RATEOutputLines.Add("TABS_RATE  = " + TABS_RATENumericUpDown.Text + "; -- Multiplies tabs earned from fov.")
                Else
                    TABS_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, TABS_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If SAN_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SAN_FAMEMatch As Boolean
                SAN_FAMEMatch = line.Contains("SAN_FAME")
                If SAN_FAMEMatch Then
                    SAN_FAMEOutputLines.Add("SAN_FAME   = " + SAN_FAMENumericUpDown.Text + "; -- Multiplies fame earned from San d'Oria quests.")
                Else
                    SAN_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SAN_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If BAS_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BAS_FAMEMatch As Boolean
                BAS_FAMEMatch = line.Contains("BAS_FAME")
                If BAS_FAMEMatch Then
                    BAS_FAMEOutputLines.Add("BAS_FAME   = " + BAS_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Bastok quests.")
                Else
                    BAS_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BAS_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WIN_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WIN_FAMEMatch As Boolean
                WIN_FAMEMatch = line.Contains("WIN_FAME")
                If WIN_FAMEMatch Then
                    WIN_FAMEOutputLines.Add("WIN_FAME   = " + WIN_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Windurst quests.")
                Else
                    WIN_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WIN_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If NORG_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim NORG_FAMEMatch As Boolean
                NORG_FAMEMatch = line.Contains("NORG_FAME")
                If NORG_FAMEMatch Then
                    NORG_FAMEOutputLines.Add("NORG_FAME  = " + NORG_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Norg and Tenshodo quests.")
                Else
                    NORG_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, NORG_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If JEUNO_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim JEUNO_FAMEMatch As Boolean
                JEUNO_FAMEMatch = line.Contains("JEUNO_FAME")
                If JEUNO_FAMEMatch Then
                    JEUNO_FAMEOutputLines.Add("JEUNO_FAME = " + JEUNO_FAMENumericUpDown.Text + "; -- Multiplies fame earned from Jeuno quests.")
                Else
                    JEUNO_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, JEUNO_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingPage3Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage3Button.Click

        Dim FISHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim WOODWORKING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim SMITHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim GOLDSMITHING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim CLOTHCRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim LEATHERCRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim BONECRAFT_GUILD_POINTSOutputLines As New List(Of String)()
        Dim ALCHEMY_GUILD_POINTSOutputLines As New List(Of String)()
        Dim COOKING_GUILD_POINTSOutputLines As New List(Of String)()
        Dim CURE_POWEROutputLines As New List(Of String)()
        Dim SPELL_POWEROutputLines As New List(Of String)()
        Dim BLUE_POWEROutputLines As New List(Of String)()
        Dim DRAIN_POWEROutputLines As New List(Of String)()
        Dim ITEM_POWEROutputLines As New List(Of String)()
        Dim WEAPON_SKILL_POWEROutputLines As New List(Of String)()
        Dim WEAPON_SKILL_POINTSOutputLines As New List(Of String)()

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
                Dim GOLDSMITHING_GUILD_POINTSMatch As Boolean
                SMITHING_GUILD_POINTSMatch = line.Contains("SMITHING_GUILD_POINTS")
                GOLDSMITHING_GUILD_POINTSMatch = line.Contains("GOLDSMITHING_GUILD_POINTS")
                If SMITHING_GUILD_POINTSMatch And Not GOLDSMITHING_GUILD_POINTSMatch Then
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

        If USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("USE_ADOULIN_WEAPON_SKILL_CHANGES = true; -- true/false. Change to toggle new Adoulin weapon skill damage calculations", "USE_ADOULIN_WEAPON_SKILL_CHANGES = false; -- true/false. Change to toggle new Adoulin weapon skill damage calculations"), False)
        End If

    End Sub

    Private Sub ApplySettingPage4Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage4Button.Click

        Dim HARVESTING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim EXCAVATION_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim LOGGING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim MINING_BREAK_CHANCEOutputLines As New List(Of String)()
        Dim HARVESTING_RATEOutputLines As New List(Of String)()
        Dim EXCAVATION_RATEOutputLines As New List(Of String)()
        Dim LOGGING_RATEOutputLines As New List(Of String)()
        Dim MINING_RATEOutputLines As New List(Of String)()
        Dim COFFER_MAX_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim COFFER_MIN_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim CHEST_MAX_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim CHEST_MIN_ILLUSION_TIMEOutputLines As New List(Of String)()
        Dim LandKingSystem_NQOutputLines As New List(Of String)()
        Dim LandKingSystem_HQOutputLines As New List(Of String)()

        If HARVESTING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim HARVESTING_BREAK_CHANCEMatch As Boolean
                HARVESTING_BREAK_CHANCEMatch = line.Contains("HARVESTING_BREAK_CHANCE")
                If HARVESTING_BREAK_CHANCEMatch Then
                    HARVESTING_BREAK_CHANCEOutputLines.Add("HARVESTING_BREAK_CHANCE = " + HARVESTING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the sickle to break during harvesting.  Set between 0 and 1.")
                Else
                    HARVESTING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, HARVESTING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If EXCAVATION_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXCAVATION_BREAK_CHANCEMatch As Boolean
                EXCAVATION_BREAK_CHANCEMatch = line.Contains("EXCAVATION_BREAK_CHANCE")
                If EXCAVATION_BREAK_CHANCEMatch Then
                    EXCAVATION_BREAK_CHANCEOutputLines.Add("EXCAVATION_BREAK_CHANCE = " + EXCAVATION_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the pickaxe to break during excavation.  Set between 0 and 1.")
                Else
                    EXCAVATION_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXCAVATION_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LOGGING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LOGGING_BREAK_CHANCEMatch As Boolean
                LOGGING_BREAK_CHANCEMatch = line.Contains("LOGGING_BREAK_CHANCE")
                If LOGGING_BREAK_CHANCEMatch Then
                    LOGGING_BREAK_CHANCEOutputLines.Add("LOGGING_BREAK_CHANCE    = " + LOGGING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the hatchet to break during logging.  Set between 0 and 1.")
                Else
                    LOGGING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LOGGING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If MINING_BREAK_CHANCENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MINING_BREAK_CHANCEMatch As Boolean
                MINING_BREAK_CHANCEMatch = line.Contains("MINING_BREAK_CHANCE")
                If MINING_BREAK_CHANCEMatch Then
                    MINING_BREAK_CHANCEOutputLines.Add("MINING_BREAK_CHANCE     = " + MINING_BREAK_CHANCENumericUpDown.Text + "; -- % chance for the pickaxe to break during mining.  Set between 0 and 1.")
                Else
                    MINING_BREAK_CHANCEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MINING_BREAK_CHANCEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If HARVESTING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim HARVESTING_RATEMatch As Boolean
                HARVESTING_RATEMatch = line.Contains("HARVESTING_RATE")
                If HARVESTING_RATEMatch Then
                    HARVESTING_RATEOutputLines.Add("HARVESTING_RATE         = " + HARVESTING_RATENumericUpDown.Text + "; -- % chance to recieve an item from haresting.  Set between 0 and 1.")
                Else
                    HARVESTING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, HARVESTING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If EXCAVATION_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXCAVATION_RATEMatch As Boolean
                EXCAVATION_RATEMatch = line.Contains("EXCAVATION_RATE")
                If EXCAVATION_RATEMatch Then
                    EXCAVATION_RATEOutputLines.Add("EXCAVATION_RATE         = " + EXCAVATION_RATENumericUpDown.Text + "; -- % chance to recieve an item from excavation.  Set between 0 and 1.")
                Else
                    EXCAVATION_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXCAVATION_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LOGGING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LOGGING_RATEMatch As Boolean
                LOGGING_RATEMatch = line.Contains("LOGGING_RATE")
                If LOGGING_RATEMatch Then
                    LOGGING_RATEOutputLines.Add("LOGGING_RATE            = " + LOGGING_RATENumericUpDown.Text + "; -- % chance to recieve an item from logging.  Set between 0 and 1.")
                Else
                    LOGGING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LOGGING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If MINING_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim MINING_RATEMatch As Boolean
                MINING_RATEMatch = line.Contains("MINING_RATE")
                If MINING_RATEMatch Then
                    MINING_RATEOutputLines.Add("MINING_RATE             = " + MINING_RATENumericUpDown.Text + "; -- % chance to recieve an item from mining.  Set between 0 and 1.")
                Else
                    MINING_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, MINING_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If COFFER_MAX_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim COFFER_MAX_ILLUSION_TIMEMatch As Boolean
                COFFER_MAX_ILLUSION_TIMEMatch = line.Contains("COFFER_MAX_ILLUSION_TIME")
                If COFFER_MAX_ILLUSION_TIMEMatch Then
                    COFFER_MAX_ILLUSION_TIMEOutputLines.Add("COFFER_MAX_ILLUSION_TIME = " + COFFER_MAX_ILLUSION_TIMENumericUpDown.Text + ";  -- 1 hour")
                Else
                    COFFER_MAX_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, COFFER_MAX_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If COFFER_MIN_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim COFFER_MIN_ILLUSION_TIMEMatch As Boolean
                COFFER_MIN_ILLUSION_TIMEMatch = line.Contains("COFFER_MIN_ILLUSION_TIME")
                If COFFER_MIN_ILLUSION_TIMEMatch Then
                    COFFER_MIN_ILLUSION_TIMEOutputLines.Add("COFFER_MIN_ILLUSION_TIME = " + COFFER_MIN_ILLUSION_TIMENumericUpDown.Text + ";  -- 30 minutes")
                Else
                    COFFER_MIN_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, COFFER_MIN_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CHEST_MAX_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CHEST_MAX_ILLUSION_TIMEMatch As Boolean
                CHEST_MAX_ILLUSION_TIMEMatch = line.Contains("CHEST_MAX_ILLUSION_TIME")
                If CHEST_MAX_ILLUSION_TIMEMatch Then
                    CHEST_MAX_ILLUSION_TIMEOutputLines.Add("CHEST_MAX_ILLUSION_TIME  = " + CHEST_MAX_ILLUSION_TIMENumericUpDown.Text + ";  -- 1 hour")
                Else
                    CHEST_MAX_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CHEST_MAX_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CHEST_MIN_ILLUSION_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CHEST_MIN_ILLUSION_TIMEMatch As Boolean
                CHEST_MIN_ILLUSION_TIMEMatch = line.Contains("CHEST_MIN_ILLUSION_TIME")
                If CHEST_MIN_ILLUSION_TIMEMatch Then
                    CHEST_MIN_ILLUSION_TIMEOutputLines.Add("CHEST_MIN_ILLUSION_TIME  = " + CHEST_MIN_ILLUSION_TIMENumericUpDown.Text + ";  -- 30 minutes")
                Else
                    CHEST_MIN_ILLUSION_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CHEST_MIN_ILLUSION_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LandKingSystem_NQNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LandKingSystem_NQMatch As Boolean
                LandKingSystem_NQMatch = line.Contains("LandKingSystem_NQ")
                If LandKingSystem_NQMatch Then
                    LandKingSystem_NQOutputLines.Add("LandKingSystem_NQ = " + LandKingSystem_NQNumericUpDown.Text + ";")
                Else
                    LandKingSystem_NQOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LandKingSystem_NQOutputLines.ToArray(), Encoding.UTF8)
        End If

        If LandKingSystem_HQNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim LandKingSystem_HQMatch As Boolean
                LandKingSystem_HQMatch = line.Contains("LandKingSystem_HQ")
                If LandKingSystem_HQMatch Then
                    LandKingSystem_HQOutputLines.Add("LandKingSystem_HQ = " + LandKingSystem_HQNumericUpDown.Text + ";")
                Else
                    LandKingSystem_HQOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, LandKingSystem_HQOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingPage5Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage5Button.Click

        Dim BETWEEN_2DYNA_WAIT_TIMEOutputLines As New List(Of String)()
        Dim DYNA_LEVEL_MINOutputLines As New List(Of String)()
        Dim TIMELESS_HOURGLASS_COSTOutputLines As New List(Of String)()
        Dim CURRENCY_EXCHANGE_RATEOutputLines As New List(Of String)()
        Dim RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines As New List(Of String)()
        Dim RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines As New List(Of String)()
        Dim WSNM_LEVELOutputLines As New List(Of String)()
        Dim WSNM_SKILL_LEVELOutputLines As New List(Of String)()
        Dim AF1_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF2_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF3_QUEST_LEVELOutputLines As New List(Of String)()
        Dim AF1_FAMEOutputLines As New List(Of String)()
        Dim AF2_FAMEOutputLines As New List(Of String)()
        Dim AF3_FAMEOutputLines As New List(Of String)()
        Dim QM_RESET_TIMEOutputLines As New List(Of String)()
        Dim FrigiciteDurationOutputLines As New List(Of String)()

        If FREE_COP_DYNAMISCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FREE_COP_DYNAMIS = 0 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)", "FREE_COP_DYNAMIS = 1 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FREE_COP_DYNAMIS = 1 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)", "FREE_COP_DYNAMIS = 0 ; -- Authorize player to entering inside COP Dynamis without completing COP mission ( 1 = enable 0= disable)"), False)
        End If

        If BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BETWEEN_2DYNA_WAIT_TIMEMatch As Boolean
                BETWEEN_2DYNA_WAIT_TIMEMatch = line.Contains("BETWEEN_2DYNA_WAIT_TIME")
                If BETWEEN_2DYNA_WAIT_TIMEMatch Then
                    BETWEEN_2DYNA_WAIT_TIMEOutputLines.Add("BETWEEN_2DYNA_WAIT_TIME = " + BETWEEN_2DYNA_WAIT_TIMENumericUpDown.Text + ";        -- wait time between 2 Dynamis (in real day) min: 1 day")
                Else
                    BETWEEN_2DYNA_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BETWEEN_2DYNA_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If DYNA_LEVEL_MINNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim DYNA_LEVEL_MINMatch As Boolean
                DYNA_LEVEL_MINMatch = line.Contains("DYNA_LEVEL_MIN")
                If DYNA_LEVEL_MINMatch Then
                    DYNA_LEVEL_MINOutputLines.Add("DYNA_LEVEL_MIN = " + DYNA_LEVEL_MINNumericUpDown.Text + ";       -- level min for entering in Dynamis")
                Else
                    DYNA_LEVEL_MINOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, DYNA_LEVEL_MINOutputLines.ToArray(), Encoding.UTF8)
        End If

        If TIMELESS_HOURGLASS_COSTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim TIMELESS_HOURGLASS_COSTMatch As Boolean
                TIMELESS_HOURGLASS_COSTMatch = line.Contains("TIMELESS_HOURGLASS_COST")
                If TIMELESS_HOURGLASS_COSTMatch Then
                    TIMELESS_HOURGLASS_COSTOutputLines.Add("TIMELESS_HOURGLASS_COST = " + TIMELESS_HOURGLASS_COSTNumericUpDown.Text + ";   -- cost of the timeless hourglass for Dynamis.")
                Else
                    TIMELESS_HOURGLASS_COSTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, TIMELESS_HOURGLASS_COSTOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CURRENCY_EXCHANGE_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CURRENCY_EXCHANGE_RATEMatch As Boolean
                CURRENCY_EXCHANGE_RATEMatch = line.Contains("CURRENCY_EXCHANGE_RATE")
                If CURRENCY_EXCHANGE_RATEMatch Then
                    CURRENCY_EXCHANGE_RATEOutputLines.Add("CURRENCY_EXCHANGE_RATE = " + CURRENCY_EXCHANGE_RATENumericUpDown.Text + ";      -- X Tier 1 ancient currency -> 1 Tier 2, and so on.  Certain values may conflict with shop items.  Not designed to exceed 198.")
                Else
                    CURRENCY_EXCHANGE_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CURRENCY_EXCHANGE_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim RELIC_2ND_UPGRADE_WAIT_TIMEMatch As Boolean
                RELIC_2ND_UPGRADE_WAIT_TIMEMatch = line.Contains("RELIC_2ND_UPGRADE_WAIT_TIME")
                If RELIC_2ND_UPGRADE_WAIT_TIMEMatch Then
                    RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.Add("RELIC_2ND_UPGRADE_WAIT_TIME = " + RELIC_2ND_UPGRADE_WAIT_TIMENumericUpDown.Text + ";      -- wait time for 2nd relic upgrade (stage 2 -> stage 3) in seconds. 604800s = 1 RL week.")
                Else
                    RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, RELIC_2ND_UPGRADE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim RELIC_3RD_UPGRADE_WAIT_TIMEMatch As Boolean
                RELIC_3RD_UPGRADE_WAIT_TIMEMatch = line.Contains("RELIC_3RD_UPGRADE_WAIT_TIME")
                If RELIC_3RD_UPGRADE_WAIT_TIMEMatch Then
                    RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.Add("RELIC_3RD_UPGRADE_WAIT_TIME = " + RELIC_3RD_UPGRADE_WAIT_TIMENumericUpDown.Text + ";      -- wait time for 3rd relic upgrade (stage 3 -> stage 4) in seconds. 295200s = 82 hours.")
                Else
                    RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, RELIC_3RD_UPGRADE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WSNM_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WSNM_LEVELMatch As Boolean
                WSNM_LEVELMatch = line.Contains("WSNM_LEVEL")
                If WSNM_LEVELMatch Then
                    WSNM_LEVELOutputLines.Add("WSNM_LEVEL = " + WSNM_LEVELNumericUpDown.Text + "; -- Min Level to get WSNM Quests")
                Else
                    WSNM_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WSNM_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If WSNM_SKILL_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim WSNM_SKILL_LEVELMatch As Boolean
                WSNM_SKILL_LEVELMatch = line.Contains("WSNM_SKILL_LEVEL")
                If WSNM_SKILL_LEVELMatch Then
                    WSNM_SKILL_LEVELOutputLines.Add("WSNM_SKILL_LEVEL = " + WSNM_SKILL_LEVELNumericUpDown.Text + ";")
                Else
                    WSNM_SKILL_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, WSNM_SKILL_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF1_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF1_QUEST_LEVELMatch As Boolean
                AF1_QUEST_LEVELMatch = line.Contains("AF1_QUEST_LEVEL")
                If AF1_QUEST_LEVELMatch Then
                    AF1_QUEST_LEVELOutputLines.Add("AF1_QUEST_LEVEL = " + AF1_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF1 quest")
                Else
                    AF1_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF1_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF2_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF2_QUEST_LEVELMatch As Boolean
                AF2_QUEST_LEVELMatch = line.Contains("AF2_QUEST_LEVEL")
                If AF2_QUEST_LEVELMatch Then
                    AF2_QUEST_LEVELOutputLines.Add("AF2_QUEST_LEVEL = " + AF2_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF2 quest")
                Else
                    AF2_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF2_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF3_QUEST_LEVELNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF3_QUEST_LEVELMatch As Boolean
                AF3_QUEST_LEVELMatch = line.Contains("AF3_QUEST_LEVEL")
                If AF3_QUEST_LEVELMatch Then
                    AF3_QUEST_LEVELOutputLines.Add("AF3_QUEST_LEVEL = " + AF3_QUEST_LEVELNumericUpDown.Text + "; -- Minimum level to start AF3 quest")
                Else
                    AF3_QUEST_LEVELOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF3_QUEST_LEVELOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF1_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF1_FAMEMatch As Boolean
                AF1_FAMEMatch = line.Contains("AF1_FAME")
                If AF1_FAMEMatch Then
                    AF1_FAMEOutputLines.Add("AF1_FAME = " + AF1_FAMENumericUpDown.Text + "; -- base fame for completing an AF1 quest")
                Else
                    AF1_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF1_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF2_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF2_FAMEMatch As Boolean
                AF2_FAMEMatch = line.Contains("AF2_FAME")
                If AF2_FAMEMatch Then
                    AF2_FAMEOutputLines.Add("AF2_FAME = " + AF2_FAMENumericUpDown.Text + "; -- base fame for completing an AF2 quest")
                Else
                    AF2_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF2_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If AF3_FAMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim AF3_FAMEMatch As Boolean
                AF3_FAMEMatch = line.Contains("AF3_FAME")
                If AF3_FAMEMatch Then
                    AF3_FAMEOutputLines.Add("AF3_FAME = " + AF3_FAMENumericUpDown.Text + "; -- base fame for completing an AF3 quest")
                Else
                    AF3_FAMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, AF3_FAMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If DEBUG_MODECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DEBUG_MODE = 0; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests).", "DEBUG_MODE = 1; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests)."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DEBUG_MODE = 1; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests).", "DEBUG_MODE = 0; -- Set to 1 to activate auto-warping to the next location (only supported by certain missions / quests)."), False)
        End If

        If QM_RESET_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim QM_RESET_TIMEMatch As Boolean
                QM_RESET_TIMEMatch = line.Contains("QM_RESET_TIME")
                If QM_RESET_TIMEMatch Then
                    QM_RESET_TIMEOutputLines.Add("QM_RESET_TIME = " + QM_RESET_TIMENumericUpDown.Text + "; -- Default time (in seconds) you have from killing ???-pop mission NMs to click again and get key item, until ??? resets.")
                Else
                    QM_RESET_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, QM_RESET_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If OldSchoolG1CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG1 = false; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method.", "OldSchoolG1 = true; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG1 = true; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method.", "OldSchoolG1 = false; -- Set to true to require farming Exoray Mold, Bombd Coal, and Ancient Papyrus drops instead of allowing key item method."), False)
        End If

        If OldSchoolG2CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG2 = false; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it.", "OldSchoolG2 = true; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("OldSchoolG2 = true; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it.", "OldSchoolG2 = false; -- Set true to require the NMs for ""Atop the Highest Mountains"" be dead to get KI like before SE changed it."), False)
        End If

        If FrigiciteDurationNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim FrigiciteDurationMatch As Boolean
                FrigiciteDurationMatch = line.Contains("FrigiciteDuration")
                If FrigiciteDurationMatch Then
                    FrigiciteDurationOutputLines.Add("FrigiciteDuration = " + FrigiciteDurationNumericUpDown.Text + "; -- When OldSChoolG2 is enabled, this is the time (in seconds) you have from killing Boreal NMs to click the ""???"" target.")
                Else
                    FrigiciteDurationOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, FrigiciteDurationOutputLines.ToArray(), Encoding.UTF8)
        End If

    End Sub

    Private Sub ApplySettingPage6Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage6Button.Click

        Dim SCAVENGE_RATEOutputLines As New List(Of String)()
        Dim STATUS_RESIST_MULTIPLIEROutputLines As New List(Of String)()
        Dim CIRCLE_DURATIONOutputLines As New List(Of String)()
        Dim CIRCLE_KILLER_EFFECTOutputLines As New List(Of String)()
        Dim KILLER_EFFECTOutputLines As New List(Of String)()

        If REGIME_WAITCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("REGIME_WAIT = 0; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time.", "REGIME_WAIT = 1; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("REGIME_WAIT = 1; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time.", "REGIME_WAIT = 0; --Make people wait till 00:00 game time as in retail. If it's 0, there is no wait time."), False)
        End If

        If FIELD_MANUALSCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FIELD_MANUALS = 0; -- Enables Fields of Valor manuals", "FIELD_MANUALS = 1; -- Enables Fields of Valor manuals"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("FIELD_MANUALS = 1; -- Enables Fields of Valor manuals", "FIELD_MANUALS = 0; -- Enables Fields of Valor manuals"), False)
        End If

        If LOW_LEVEL_REGIMECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("LOW_LEVEL_REGIME = 0; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas.", "LOW_LEVEL_REGIME = 1; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("LOW_LEVEL_REGIME = 1; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas.", "LOW_LEVEL_REGIME = 0; --Allow people to kill regime targets even if they give no exp, allowing people to farm regime targets at 75 in low level areas."), False)
        End If

        If GROUNDS_TOMESCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("GROUNDS_TOMES = 0; -- Enables Grounds of Valor tomes", "GROUNDS_TOMES = 1; -- Enables Grounds of Valor tomes"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("GROUNDS_TOMES = 1; -- Enables Grounds of Valor tomes", "GROUNDS_TOMES = 0; -- Enables Grounds of Valor tomes"), False)
        End If

        If SCAVENGE_RATENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim SCAVENGE_RATEMatch As Boolean
                SCAVENGE_RATEMatch = line.Contains("SCAVENGE_RATE")
                If SCAVENGE_RATEMatch Then
                    SCAVENGE_RATEOutputLines.Add("SCAVENGE_RATE = " + SCAVENGE_RATENumericUpDown.Text + "; --The chance of obtaining an item when you use the Ranger job ability Scavenge.  Do not set above 1!")
                Else
                    SCAVENGE_RATEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, SCAVENGE_RATEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If STATUS_RESIST_MULTIPLIERNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim STATUS_RESIST_MULTIPLIERMatch As Boolean
                STATUS_RESIST_MULTIPLIERMatch = line.Contains("STATUS_RESIST_MULTIPLIER")
                If STATUS_RESIST_MULTIPLIERMatch Then
                    STATUS_RESIST_MULTIPLIEROutputLines.Add("STATUS_RESIST_MULTIPLIER = " + STATUS_RESIST_MULTIPLIERNumericUpDown.Text + "; -- Sets the strength of status resist traits.")
                Else
                    STATUS_RESIST_MULTIPLIEROutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, STATUS_RESIST_MULTIPLIEROutputLines.ToArray(), Encoding.UTF8)
        End If

        If CIRCLE_DURATIONNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CIRCLE_DURATIONMatch As Boolean
                CIRCLE_DURATIONMatch = line.Contains("CIRCLE_DURATION")
                If CIRCLE_DURATIONMatch Then
                    CIRCLE_DURATIONOutputLines.Add("CIRCLE_DURATION = " + CIRCLE_DURATIONNumericUpDown.Text + "; -- Sets the duration of circle effects, in seconds. Retail is 5 minutes.")
                Else
                    CIRCLE_DURATIONOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CIRCLE_DURATIONOutputLines.ToArray(), Encoding.UTF8)
        End If

        If CIRCLE_KILLER_EFFECTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim CIRCLE_KILLER_EFFECTMatch As Boolean
                CIRCLE_KILLER_EFFECTMatch = line.Contains("CIRCLE_KILLER_EFFECT")
                If CIRCLE_KILLER_EFFECTMatch Then
                    CIRCLE_KILLER_EFFECTOutputLines.Add("CIRCLE_KILLER_EFFECT = " + CIRCLE_KILLER_EFFECTNumericUpDown.Text + "; -- Intimidation percentage granted by circle effects. (made up number)")
                Else
                    CIRCLE_KILLER_EFFECTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, CIRCLE_KILLER_EFFECTOutputLines.ToArray(), Encoding.UTF8)
        End If

        If KILLER_EFFECTNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim KILLER_EFFECTMatch As Boolean
                Dim CIRCLEMatch As Boolean
                KILLER_EFFECTMatch = line.Contains("KILLER_EFFECT")
                CIRCLEMatch = line.Contains("CIRCLE")
                If KILLER_EFFECTMatch And Not CIRCLEMatch Then
                    KILLER_EFFECTOutputLines.Add("KILLER_EFFECT = " + KILLER_EFFECTNumericUpDown.Text + "; -- Intimidation percentage from killer job traits.")
                Else
                    KILLER_EFFECTOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, KILLER_EFFECTOutputLines.ToArray(), Encoding.UTF8)
        End If

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

        Dim EXPLORER_MOOGLE_LEVELCAPOutputLines As New List(Of String)()
        Dim RIVERNE_PORTERSOutputLines As New List(Of String)()
        Dim LANTERNS_STAY_LITOutputLines As New List(Of String)()
        Dim TIMEZONE_OFFSETOutputLines As New List(Of String)()
        Dim NUMBER_OF_DM_EARRINGSOutputLines As New List(Of String)()

        If EXPLORER_MOOGLECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("EXPLORER_MOOGLE = 0; -- Enables Explorer Moogle teleports", "EXPLORER_MOOGLE = 1; -- Enables Explorer Moogle teleports"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("EXPLORER_MOOGLE = 1; -- Enables Explorer Moogle teleports", "EXPLORER_MOOGLE = 0; -- Enables Explorer Moogle teleports"), False)
        End If

        If EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim EXPLORER_MOOGLE_LEVELCAPMatch As Boolean
                EXPLORER_MOOGLE_LEVELCAPMatch = line.Contains("EXPLORER_MOOGLE_LEVELCAP")
                If EXPLORER_MOOGLE_LEVELCAPMatch Then
                    EXPLORER_MOOGLE_LEVELCAPOutputLines.Add("EXPLORER_MOOGLE_LEVELCAP = " + EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Text + ";")
                Else
                    EXPLORER_MOOGLE_LEVELCAPOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, EXPLORER_MOOGLE_LEVELCAPOutputLines.ToArray(), Encoding.UTF8)
        End If

        If JINX_MODE_2005CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2005 = 0; -- Set to 1 to give starting characters swimsuits from 2005.  Ex: Hume Top", "JINX_MODE_2005 = 1; -- Set to 1 to give starting characters swimsuits from 2005.  Ex: Hume Top"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2005 = 1; -- Set to 1 to give starting characters swimsuits from 2005.  Ex: Hume Top", "JINX_MODE_2005 = 0; -- Set to 1 to give starting characters swimsuits from 2005.  Ex: Hume Top"), False)
        End If

        If JINX_MODE_2008CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2008 = 0; -- Set to 1 to give starting characters swimsuits from 2008.  Ex: Custom Top", "JINX_MODE_2008 = 1; -- Set to 1 to give starting characters swimsuits from 2008.  Ex: Custom Top"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2008 = 1; -- Set to 1 to give starting characters swimsuits from 2008.  Ex: Custom Top", "JINX_MODE_2008 = 0; -- Set to 1 to give starting characters swimsuits from 2008.  Ex: Custom Top"), False)
        End If

        If JINX_MODE_2012CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2012 = 0; -- Set to 1 to give starting characters swimsuits from 2012.  Ex: Marine Top", "JINX_MODE_2012 = 1; -- Set to 1 to give starting characters swimsuits from 2012.  Ex: Marine Top"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("JINX_MODE_2012 = 1; -- Set to 1 to give starting characters swimsuits from 2012.  Ex: Marine Top", "JINX_MODE_2012 = 0; -- Set to 1 to give starting characters swimsuits from 2012.  Ex: Marine Top"), False)
        End If

        If SUMMERFEST_2004CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUMMERFEST_2004 = 0; -- Set to 1 to give starting characters Far East dress from 2004.  Ex: Onoko Yukata", "SUMMERFEST_2004 = 1; -- Set to 1 to give starting characters Far East dress from 2004.  Ex: Onoko Yukata"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUMMERFEST_2004 = 1; -- Set to 1 to give starting characters Far East dress from 2004.  Ex: Onoko Yukata", "SUMMERFEST_2004 = 0; -- Set to 1 to give starting characters Far East dress from 2004.  Ex: Onoko Yukata"), False)
        End If

        If SUNBREEZE_2009CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUNBREEZE_2009 = 0; -- Set to 1 to give starting characters Far East dress from 2009.  Ex: Otokogusa Yukata", "SUNBREEZE_2009 = 1; -- Set to 1 to give starting characters Far East dress from 2009.  Ex: Otokogusa Yukata"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUNBREEZE_2009 = 1; -- Set to 1 to give starting characters Far East dress from 2009.  Ex: Otokogusa Yukata", "SUNBREEZE_2009 = 0; -- Set to 1 to give starting characters Far East dress from 2009.  Ex: Otokogusa Yukata"), False)
        End If

        If SUNBREEZE_2011CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUNBREEZE_2011 = 0; -- Set to 1 to give starting characters Far East dress from 2011.  Ex: Hikogami Yukata", "SUNBREEZE_2011 = 1; -- Set to 1 to give starting characters Far East dress from 2011.  Ex: Hikogami Yukata"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("SUNBREEZE_2011 = 1; -- Set to 1 to give starting characters Far East dress from 2011.  Ex: Hikogami Yukata", "SUNBREEZE_2011 = 0; -- Set to 1 to give starting characters Far East dress from 2011.  Ex: Hikogami Yukata"), False)
        End If

        If CHRISTMASCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("CHRISTMAS = 0; -- Set to 1 to give starting characters Christmas dress.", "CHRISTMAS = 1; -- Set to 1 to give starting characters Christmas dress."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("CHRISTMAS = 1; -- Set to 1 to give starting characters Christmas dress.", "CHRISTMAS = 0; -- Set to 1 to give starting characters Christmas dress."), False)
        End If

        If HALLOWEENCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN = 0; -- Set to 1 to give starting characters Halloween items (Does not start event).", "HALLOWEEN = 1; -- Set to 1 to give starting characters Halloween items (Does not start event)."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN = 1; -- Set to 1 to give starting characters Halloween items (Does not start event).", "HALLOWEEN = 0; -- Set to 1 to give starting characters Halloween items (Does not start event)."), False)
        End If

        If HALLOWEEN_2005CheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN_2005 = 0; -- Set to 1 to Enable the 2005 version of Harvest Festival, will start on Oct. 20 and end Nov. 1.", "HALLOWEEN_2005 = 1; -- Set to 1 to Enable the 2005 version of Harvest Festival, will start on Oct. 20 and end Nov. 1."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN_2005 = 1; -- Set to 1 to Enable the 2005 version of Harvest Festival, will start on Oct. 20 and end Nov. 1.", "HALLOWEEN_2005 = 0; -- Set to 1 to Enable the 2005 version of Harvest Festival, will start on Oct. 20 and end Nov. 1."), False)
        End If

        If HALLOWEEN_YEAR_ROUNDCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN_YEAR_ROUND = 0; -- Set to 1 to have Harvest Festival initialize outside of normal times.", "HALLOWEEN_YEAR_ROUND = 1; -- Set to 1 to have Harvest Festival initialize outside of normal times."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HALLOWEEN_YEAR_ROUND = 1; -- Set to 1 to have Harvest Festival initialize outside of normal times.", "HALLOWEEN_YEAR_ROUND = 0; -- Set to 1 to have Harvest Festival initialize outside of normal times."), False)
        End If

        If HOMEPOINT_HEALCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_HEAL = 0; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games.", "HOMEPOINT_HEAL = 1; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games."), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_HEAL = 1; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games.", "HOMEPOINT_HEAL = 0; --Set to 1 if you want Home Points to heal you like in single-player Final Fantasy games."), False)
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

        If ENABLE_COP_ZONE_CAPCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("ENABLE_COP_ZONE_CAP=1; -- enable or disable lvl cap", "ENABLE_COP_ZONE_CAP=0; -- enable or disable lvl cap"), False)
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

        If HOMEPOINT_TELEPORTCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_TELEPORT =0; -- Enables the homepoint teleport system", "HOMEPOINT_TELEPORT =1; -- Enables the homepoint teleport system"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("HOMEPOINT_TELEPORT =1; -- Enables the homepoint teleport system", "HOMEPOINT_TELEPORT =0; -- Enables the homepoint teleport system"), False)
        End If

    End Sub

    Private Sub ApplySettingPage9Button_Click(sender As Object, e As EventArgs) Handles ApplySettingPage9Button.Click

        Dim BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines As New List(Of String)()
        Dim VISITANT_BONUSOutputLines As New List(Of String)()

        If BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text.Length < 1 Then
        Else
            For Each line As String In System.IO.File.ReadAllLines(SettingsFile)
                Dim BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch As Boolean
                BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch = line.Contains("BETWEEN_2COSMOCLEANSE_WAIT_TIME")
                If BETWEEN_2COSMOCLEANSE_WAIT_TIMEMatch Then
                    BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.Add("BETWEEN_2COSMOCLEANSE_WAIT_TIME = " + BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Text + "; -- day between 2 limbus keyitem  (default 3 days)")
                Else
                    BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.Add(line)
                End If
            Next
            System.IO.File.WriteAllLines(SettingsFile, BETWEEN_2COSMOCLEANSE_WAIT_TIMEOutputLines.ToArray(), Encoding.UTF8)
        End If

        If DIMENSIONAL_PORTAL_UNLOCKCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIMENSIONAL_PORTAL_UNLOCK = false; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus", "DIMENSIONAL_PORTAL_UNLOCK = true; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("DIMENSIONAL_PORTAL_UNLOCK = true; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus", "DIMENSIONAL_PORTAL_UNLOCK = false; -- Set true to bypass requirements for using dimensional portals to reach sea for Limbus"), False)
        End If

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

    Private Sub JINX_MODE_2012CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles JINX_MODE_2012CheckBox.CheckedChanged

    End Sub

    Private Sub EXPLORER_MOOGLECheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EXPLORER_MOOGLECheckBox.CheckedChanged
        If EXPLORER_MOOGLECheckBox.Checked = True Then
            EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Enabled = True
        Else
            EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub DYNA_LEVEL_MINNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If DYNA_LEVEL_MINNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            DYNA_LEVEL_MINNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub WSNM_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If WSNM_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            WSNM_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF1_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If AF1_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF1_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF2_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If AF2_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF2_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub AF3_QUEST_LEVELNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If AF3_QUEST_LEVELNumericUpDown.Value > My.Settings.MAX_LEVEL Then
            AF3_QUEST_LEVELNumericUpDown.Text = My.Settings.MAX_LEVEL
        End If
    End Sub

    Private Sub OldSchoolG2CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        If OldSchoolG2CheckBox.Checked = True Then
            FrigiciteDurationNumericUpDown.Enabled = True
        Else
            FrigiciteDurationNumericUpDown.Enabled = False
        End If
    End Sub

End Class