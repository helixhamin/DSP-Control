Imports System.IO

Public Class DSPControlForm

    Dim LobbyLogsLocation = My.Settings.DSPPath + "\log\login-server.log"
    Dim GameLogsLocation = My.Settings.DSPPath + "\log\map-server.log"

    Private Sub DSPControlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim FormClosing As Integer = MessageBox.Show("Are you sure you want to close me? The servers will also close!", "Server status in peril!", MessageBoxButtons.YesNo)
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Activate()
        AboutBox.Show()
    End Sub

    Private Sub ConfigurationEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationEditorToolStripMenuItem.Click
        ConfigForm.Activate()
        ConfigForm.Show()
    End Sub

    Private Sub LaunchPOLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchPOLToolStripMenuItem.Click

        Dim proc As New ProcessStartInfo()
        Dim POLRunningVerification() As Process

        If My.Settings.POLPath.Length < 2 Then
            MsgBox("Please set your POL Path first.")
            PathLocationsListBox.Activate()
            PathLocationsListBox.Show()
        Else
            POLRunningVerification = Process.GetProcessesByName("pol")
            If POLRunningVerification.Count > 0 Then
                MsgBox("pol is already running", vbExclamation)
            Else
                proc.WorkingDirectory = My.Settings.POLPath
                proc.FileName = "pol.exe"
                Process.Start(proc)
            End If
        End If
    End Sub
End Class
