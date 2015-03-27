Public Class AuditSettings

    Dim MapConfFile = My.Settings.DSPPath + "\conf\map_darkstar.conf"

    Private Sub AuditSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.audit_chat = audit_chatCheckBox.Checked
        My.Settings.audit_say = audit_sayCheckBox.Checked
        My.Settings.audit_shout = audit_shoutCheckBox.Checked
        My.Settings.audit_tell = audit_tellCheckBox.Checked
        My.Settings.audit_yell = audit_yellCheckBox.Checked
        My.Settings.audit_linkshell = audit_linkshellCheckBox.Checked
        My.Settings.audit_party = audit_partyCheckBox.Checked
    End Sub

    Private Sub AuditSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click
        If audit_chatCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_chat: 0", "audit_chat: 1"), False)
        ElseIf audit_chatCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_chat: 1", "audit_chat: 0"), False)
        End If

        If audit_sayCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_say: 0", "audit_say: 1"), False)
        ElseIf audit_sayCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_say: 1", "audit_say: 0"), False)
        End If

        If audit_shoutCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_shout: 0", "audit_shout: 1"), False)
        ElseIf audit_shoutCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_shout: 1", "audit_shout: 0"), False)
        End If

        If audit_tellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_tell: 0", "audit_tell: 1"), False)
        ElseIf audit_tellCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_tell: 1", "audit_tell: 0"), False)
        End If

        If audit_yellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_yell: 0", "audit_yell: 1"), False)
        ElseIf audit_yellCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_yell: 1", "audit_yell: 0"), False)
        End If

        If audit_linkshellCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_linkshell: 0", "audit_linkshell: 1"), False)
        ElseIf audit_linkshellCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_linkshell: 1", "audit_linkshell: 0"), False)
        End If

        If audit_partyCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_party: 0", "audit_party: 1"), False)
        ElseIf audit_partyCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(MapConfFile, My.Computer.FileSystem.ReadAllText(MapConfFile).Replace("audit_party: 1", "audit_party: 0"), False)
        End If
    End Sub
End Class