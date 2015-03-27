Imports System.Text.RegularExpressions
Imports System.Text

Public Class ConfigFormSearch

    Dim SearchConfFile = My.Settings.DSPPath + "\conf\search_server.conf"
    Dim AHCPP = My.Settings.DSPPath + "\src\map\packets\auction_house.cpp"

    Private Sub ConfigFormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.expire_auctions = expire_auctionsCheckBox.Checked
        My.Settings.no_auction_limits = no_auction_limitsCheckBox.Checked
        My.Settings.expire_days = expire_daysNumericUpDown.Text
        My.Settings.expire_interval = expire_intervalNumericUpDown.Text
    End Sub

    Private Sub ConfigFormSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplySettingsButton_Click(sender, e)
        My.Settings.Save()
    End Sub

    Private Sub ApplySettingsButton_Click(sender As Object, e As EventArgs) Handles ApplySettingsButton.Click

        Dim expire_daysOutputLines As New List(Of String)()
        Dim expire_intervalOutputLines As New List(Of String)()

        'Handles activating/deactivating auction house expiration
        If expire_auctionsCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(SearchConfFile, My.Computer.FileSystem.ReadAllText(SearchConfFile).Replace("expire_auctions: 0", "expire_auctions: 1"), False)
        ElseIf expire_auctionsCheckBox.Checked = False Then
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

        'Handles removing AH submission limits
        If no_auction_limitsCheckBox.Checked = True Then
            My.Computer.FileSystem.WriteAllText(AHCPP, My.Computer.FileSystem.ReadAllText(AHCPP).Replace("< 7", "< 9"), False)
        ElseIf no_auction_limitsCheckBox.Checked = False Then
            My.Computer.FileSystem.WriteAllText(AHCPP, My.Computer.FileSystem.ReadAllText(AHCPP).Replace("< 9", "< 7"), False)
        End If

    End Sub

    Private Sub no_auction_limitsCheckBox_CheckStateChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub no_auction_limitsCheckBox_MouseClick(sender As Object, e As MouseEventArgs) Handles no_auction_limitsCheckBox.MouseClick
        If no_auction_limitsCheckBox.Checked = False Then
        Else
            MessageBox.Show("You must recompile the server for this to take effect!", "Important Message")
        End If
    End Sub
End Class