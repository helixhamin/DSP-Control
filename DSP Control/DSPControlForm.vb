Imports System.IO

Public Class DSPControlForm

    Dim LobbyLogsLocation = My.Settings.DSPPath + "\log\login-server.log"
    Dim GameLogsLocation = My.Settings.DSPPath + "\log\map-server.log"

    Private Sub DSPControlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim FormClosing As Integer = MessageBox.Show("Are you sure you want to close me? The servers will also close", "Server status in peril!", MessageBoxButtons.YesNo)
        If FormClosing = DialogResult.Yes Then
            Dim myDSPConnectProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSConnect-server")
            Dim myDSPGameProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSGame-server")
            Dim myDSPSearchProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSSearch-server")
            For Each myKill As Process In myDSPConnectProcess
                myKill.Kill()
            Next
            For Each myKill As Process In myDSPGameProcess
                myKill.Kill()
            Next
            For Each myKill As Process In myDSPSearchProcess
                myKill.Kill()
            Next
        ElseIf FormClosing = DialogResult.No Then
            e.Cancel = True
        End If
        
    End Sub

    Private Sub ViewDirectoryPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDirectoryPathToolStripMenuItem.Click
        'Note 9
            PathLocationsListBox.Activate()
            PathLocationsListBox.Show()
    End Sub

    Private Sub ViewLobbyLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLobbyLogsToolStripMenuItem.Click
        If File.Exists(LobbyLogsLocation) Then
            LobbyLogs.Activate()
            LobbyLogs.Show()
        Else
        End If
    End Sub

    Private Sub ViewGameLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewGameLogsToolStripMenuItem.Click
        If File.Exists(LobbyLogsLocation) Then
            GameLogs.Activate()
            GameLogs.Show()
        Else
        End If
    End Sub

    Private Sub ServerSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerSetupToolStripMenuItem.Click
        If My.Settings.DSPPath.Length < 2 Then
            MsgBox("Please set your DSP Path first.")
            PathLocationsListBox.Activate()
            PathLocationsListBox.Show()
        End If
    End Sub

    Private Sub FieldsOfValorSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldsOfValorSettingsToolStripMenuItem.Click
        FOVSettings.Activate()
        FOVSettings.Show()
    End Sub

    Private Sub FieldsOfValorSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FieldsOfValorSettingsToolStripMenuItem1.Click
        FieldsOfValorSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub DatabaseEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseEditorToolStripMenuItem.Click
        ConfigFormdatabase.Activate()
        ConfigFormdatabase.Show()
    End Sub

    Private Sub ExpansionSelectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpansionSelectorToolStripMenuItem.Click
        ConfigFormExpansions.Activate()
        ConfigFormExpansions.Show()
    End Sub

    Private Sub LaunchAshitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchAshitaToolStripMenuItem.Click
        Dim proc As New ProcessStartInfo()
        Dim AshitaRunningVerification() As Process
        If My.Settings.AshitaPath.Length < 2 Then
            MsgBox("You need to declare Ashita's path", vbExclamation)
            PathLocationsListBox.Activate()
            PathLocationsListBox.Show()
        Else
            AshitaRunningVerification = Process.GetProcessesByName("Ashita")
            If AshitaRunningVerification.Count > 0 Then
                MsgBox("Ashita is already running", vbExclamation)
            Else
                proc.WorkingDirectory = My.Settings.AshitaPath
                proc.FileName = "Ashita.exe"
                Process.Start(proc)
            End If
        End If
    End Sub

    Private Sub StartServer_Click(sender As Object, e As EventArgs) Handles StartServer.Click
        Dim proc As New ProcessStartInfo()
        'Note 2
        'Note 3
        Dim prochide As New ProcessStartInfo()
        prochide.WindowStyle = ProcessWindowStyle.Hidden
        Dim ServerRunningVerification() As Process
        'Note 4
        If My.Settings.DSPPath.Length < 2 Then
            MsgBox("You need to declare the DSP path")
            PathLocationsListBox.Activate()
            PathLocationsListBox.Show()
        Else
            'Note 5
            ServerRunningVerification = Process.GetProcessesByName("DSConnect-server")
            If ServerRunningVerification.Count > 0 Then
                MsgBox("The server is already running", vbExclamation)
            Else
                If File.Exists(My.Settings.DSPPath + "\DSGame-server.exe") Then
                    If ViewServerConsolesToolStripMenuItem.CheckState = 1 Then
                        proc.WorkingDirectory = My.Settings.DSPPath
                        proc.FileName = "DSConnect-server.exe"
                        Process.Start(proc)
                        proc.FileName = "DSGame-server.exe"
                        Process.Start(proc)
                        proc.FileName = "DSSearch-server.exe"
                        Process.Start(proc)
                    Else
                        prochide.WorkingDirectory = My.Settings.DSPPath
                        prochide.FileName = "DSConnect-server.exe"
                        Process.Start(prochide)
                        prochide.FileName = "DSGame-server.exe"
                        Process.Start(prochide)
                        prochide.FileName = "DSSearch-server.exe"
                        Process.Start(prochide)
                    End If
                Else
                    MsgBox("You need to build the servers")
                End If
            End If
        End If
    End Sub

    Private Sub StopServer_Click(sender As Object, e As EventArgs) Handles StopServer.Click
        'Note 7
        Dim myDSPConnectProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSConnect-server")
        Dim myDSPGameProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSGame-server")
        Dim myDSPSearchProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSSearch-server")
        For Each myKill As Process In myDSPConnectProcess
            myKill.Kill()
        Next
        For Each myKill As Process In myDSPGameProcess
            myKill.Kill()
        Next
        For Each myKill As Process In myDSPSearchProcess
            myKill.Kill()
        Next
    End Sub

    Private Sub RestartServer_Click(sender As Object, e As EventArgs) Handles RestartServer.Click
        'Note 8
        StopServer_Click(sender, e)
        System.Threading.Thread.Sleep(1000)
        StartServer_Click(sender, e)
    End Sub

    Private Sub LoginConfigEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginConfigEditorToolStripMenuItem.Click
        ConfigFormLogin.Activate()
        ConfigFormLogin.Show()
    End Sub

    Private Sub MapConfigEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapConfigEditorToolStripMenuItem.Click
        ConfigFormMap.Activate()
        ConfigFormMap.Show()
    End Sub

    Private Sub CharacterSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterSettingsToolStripMenuItem.Click
        CharacterSettingsForm.Activate()
        CharacterSettingsForm.Show()
    End Sub

    Private Sub MonsterSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonsterSettingsToolStripMenuItem.Click
        MonsterSettingsForm.Activate()
        MonsterSettingsForm.Show()
    End Sub

    Private Sub AuditSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditSettingsToolStripMenuItem.Click
        AuditSettings.Activate()
        AuditSettings.Show()
    End Sub

    Private Sub CraftingSkillupSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CraftingSkillupSettingsToolStripMenuItem.Click
        CraftingandSkillupsettings.Activate()
        CraftingandSkillupsettings.Show()
    End Sub

    Private Sub ExperienceRatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExperienceRatesToolStripMenuItem.Click
        ExperienceRates.Activate()
        ExperienceRates.Show()
    End Sub

    Private Sub PlayerMultipliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerMultipliersToolStripMenuItem.Click
        PlayerMultipliers.Activate()
        PlayerMultipliers.Show()
    End Sub

    Private Sub StartingPlayerSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartingPlayerSettingsToolStripMenuItem.Click
        StartingPlayerSettings.Activate()
        StartingPlayerSettings.Show()
    End Sub

    Private Sub MonsterMultipliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonsterMultipliersToolStripMenuItem.Click
        MonsterMultipliers.Activate()
        MonsterMultipliers.Show()
    End Sub

    Private Sub SettingsConfigEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsConfigEditorToolStripMenuItem.Click
        ConfigFormSettings.Activate()
        ConfigFormSettings.Show()
    End Sub

    Private Sub SearchConfigEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchConfigEditorToolStripMenuItem.Click
        ConfigFormSearch.Activate()
        ConfigFormSearch.Show()
    End Sub

    Private Sub CharacterSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CharacterSettingsToolStripMenuItem1.Click
        CharacterSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub CraftingSkillupSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CraftingSkillupSettingsToolStripMenuItem1.Click
        CraftingSkillupSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ExperienceRatesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExperienceRatesToolStripMenuItem1.Click
        ExperienceRatesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PlayerMultipliersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayerMultipliersToolStripMenuItem1.Click
        PlayerMultipliersToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub StartingPlayerSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartingPlayerSettingsToolStripMenuItem1.Click
        StartingPlayerSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Activate()
        AboutBox.Show()
    End Sub

    Private Sub GuildPointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuildPointsToolStripMenuItem.Click
        GuildPointssetting.Activate()
        GuildPointssetting.Show()
    End Sub

    Private Sub MaterialCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialCollectionToolStripMenuItem.Click
        MaterialCollectingsettings.Activate()
        MaterialCollectingsettings.Show()
    End Sub

    Private Sub GuildPointsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuildPointsToolStripMenuItem1.Click
        GuildPointsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub MaterialCollectionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaterialCollectionToolStripMenuItem1.Click
        MaterialCollectionToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub MonsterSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MonsterSettingsToolStripMenuItem1.Click
        MonsterSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub FameGainMultipliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FameGainMultipliersToolStripMenuItem.Click
        FameGainMultipliers.Activate()
        FameGainMultipliers.Show()
    End Sub

    Private Sub SpellWeaponPowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpellWeaponPowerToolStripMenuItem.Click
        Spell_WeaponPower.Activate()
        Spell_WeaponPower.Show()
    End Sub

    Private Sub AbysseaSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbysseaSettingsToolStripMenuItem.Click
        AbysseaSettings.Activate()
        AbysseaSettings.Show()
    End Sub

    Private Sub CofferChestSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CofferChestSettingsToolStripMenuItem.Click
        Coffer_ChestSettings.Activate()
        Coffer_ChestSettings.Show()
    End Sub

    Private Sub DynamisSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DynamisSettingsToolStripMenuItem.Click
        DynamisSettings.Activate()
        DynamisSettings.Show()
    End Sub

    Private Sub QuestMissionSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestMissionSettingsToolStripMenuItem.Click
        Quest_MissionSettings.Activate()
        Quest_MissionSettings.Show()
    End Sub

    Private Sub LimbusSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimbusSettingsToolStripMenuItem.Click
        LimbusSettings.Activate()
        LimbusSettings.Show()
    End Sub

    Private Sub JobAbilityTraitSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobAbilityTraitSettingsToolStripMenuItem.Click
        Ability_TraitSettings.Activate()
        Ability_TraitSettings.Show()
    End Sub

    Private Sub SpellSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpellSettingsToolStripMenuItem.Click
        SpellSettings.Activate()
        SpellSettings.Show()
    End Sub

    Private Sub CelebrationSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelebrationSettingsToolStripMenuItem.Click
        CelebrationsSettings.Activate()
        CelebrationsSettings.Show()
    End Sub

    Private Sub ConfigurationEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationEditorToolStripMenuItem.Click
        ConfigForm.Activate()
        ConfigForm.Show()
    End Sub
End Class
