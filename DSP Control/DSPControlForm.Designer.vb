<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DSPControlForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DSPControlForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchAshitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDirectoryPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewServerConsolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLobbyLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGameLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RestartServer = New System.Windows.Forms.Button()
        Me.StopServer = New System.Windows.Forms.Button()
        Me.StartServer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ServerSetupToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchAshitaToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'LaunchAshitaToolStripMenuItem
        '
        Me.LaunchAshitaToolStripMenuItem.Name = "LaunchAshitaToolStripMenuItem"
        Me.LaunchAshitaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LaunchAshitaToolStripMenuItem.Text = "Launch Ashita"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDirectoryPathToolStripMenuItem, Me.ViewServerConsolesToolStripMenuItem, Me.ViewLobbyLogsToolStripMenuItem, Me.ViewGameLogsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewDirectoryPathToolStripMenuItem
        '
        Me.ViewDirectoryPathToolStripMenuItem.Name = "ViewDirectoryPathToolStripMenuItem"
        Me.ViewDirectoryPathToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewDirectoryPathToolStripMenuItem.Text = "View Directory Path"
        '
        'ViewServerConsolesToolStripMenuItem
        '
        Me.ViewServerConsolesToolStripMenuItem.CheckOnClick = True
        Me.ViewServerConsolesToolStripMenuItem.Name = "ViewServerConsolesToolStripMenuItem"
        Me.ViewServerConsolesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewServerConsolesToolStripMenuItem.Text = "View Server Consoles"
        '
        'ViewLobbyLogsToolStripMenuItem
        '
        Me.ViewLobbyLogsToolStripMenuItem.Name = "ViewLobbyLogsToolStripMenuItem"
        Me.ViewLobbyLogsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewLobbyLogsToolStripMenuItem.Text = "View Lobby Logs"
        '
        'ViewGameLogsToolStripMenuItem
        '
        Me.ViewGameLogsToolStripMenuItem.Name = "ViewGameLogsToolStripMenuItem"
        Me.ViewGameLogsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewGameLogsToolStripMenuItem.Text = "View Game Logs"
        '
        'ServerSetupToolStripMenuItem
        '
        Me.ServerSetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationEditorToolStripMenuItem})
        Me.ServerSetupToolStripMenuItem.Name = "ServerSetupToolStripMenuItem"
        Me.ServerSetupToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ServerSetupToolStripMenuItem.Text = "Server Setup"
        '
        'ConfigurationEditorToolStripMenuItem
        '
        Me.ConfigurationEditorToolStripMenuItem.Name = "ConfigurationEditorToolStripMenuItem"
        Me.ConfigurationEditorToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ConfigurationEditorToolStripMenuItem.Text = "Configuration Editor"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(180, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(340, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'RestartServer
        '
        Me.RestartServer.Location = New System.Drawing.Point(180, 135)
        Me.RestartServer.Name = "RestartServer"
        Me.RestartServer.Size = New System.Drawing.Size(94, 23)
        Me.RestartServer.TabIndex = 5
        Me.RestartServer.Text = "Restart Servers"
        Me.RestartServer.UseVisualStyleBackColor = True
        '
        'StopServer
        '
        Me.StopServer.Location = New System.Drawing.Point(340, 135)
        Me.StopServer.Name = "StopServer"
        Me.StopServer.Size = New System.Drawing.Size(82, 23)
        Me.StopServer.TabIndex = 6
        Me.StopServer.Text = "Stop Servers"
        Me.StopServer.UseVisualStyleBackColor = True
        '
        'StartServer
        '
        Me.StartServer.Location = New System.Drawing.Point(18, 135)
        Me.StartServer.Name = "StartServer"
        Me.StartServer.Size = New System.Drawing.Size(82, 23)
        Me.StartServer.TabIndex = 1
        Me.StartServer.Text = "Start Servers"
        Me.StartServer.UseVisualStyleBackColor = True
        '
        'DSPControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 172)
        Me.Controls.Add(Me.StopServer)
        Me.Controls.Add(Me.RestartServer)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StartServer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DSPControlForm"
        Me.Text = "DSP Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartServer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RestartServer As System.Windows.Forms.Button
    Friend WithEvents StopServer As System.Windows.Forms.Button
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchAshitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDirectoryPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewServerConsolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLobbyLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGameLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
