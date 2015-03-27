Imports System.Text.RegularExpressions
Imports System.Text

Public Class CelebrationsSettings

    Dim SettingsFile = My.Settings.DSPPath + "\scripts\globals\settings.lua"

    Private Sub CelebrationsSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub CelebrationsSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.EXPLORER_MOOGLE = EXPLORER_MOOGLECheckBox.Checked
        My.Settings.JINX_MODE_2005 = JINX_MODE_2005CheckBox.Checked
        My.Settings.JINX_MODE_2008 = JINX_MODE_2008CheckBox.Checked
        My.Settings.JINX_MODE_2012 = JINX_MODE_2012CheckBox.Checked
        My.Settings.SUMMERFEST_2004 = SUMMERFEST_2004CheckBox.Checked
        My.Settings.SUNBREEZE_2009 = SUNBREEZE_2009CheckBox.Checked
        My.Settings.SUNBREEZE_2011 = SUNBREEZE_2011CheckBox.Checked
        My.Settings.CHRISTMAS = CHRISTMASCheckBox.Checked
        My.Settings.HALLOWEEN = HALLOWEENCheckBox.Checked
        My.Settings.HALLOWEEN_2005 = HALLOWEEN_2005CheckBox.Checked
        My.Settings.HALLOWEEN_YEAR_ROUND = HALLOWEEN_YEAR_ROUNDCheckBox.Checked
        My.Settings.EXPLORER_MOOGLE_LEVELCAP = EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Text
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim EXPLORER_MOOGLE_LEVELCAPOutputLines As New List(Of String)()

        If EXPLORER_MOOGLECheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("EXPLORER_MOOGLE = 0; -- Enables Explorer Moogle teleports", "EXPLORER_MOOGLE = 1; -- Enables Explorer Moogle teleports"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SettingsFile, My.Computer.FileSystem.ReadAllText(SettingsFile).Replace("EXPLORER_MOOGLE = 1; -- Enables Explorer Moogle teleports", "EXPLORER_MOOGLE = 0; -- Enables Explorer Moogle teleports"), False)
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

    End Sub
End Class