<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFormMap
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
        Me.components = New System.ComponentModel.Container()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.CharacterSettingsButton = New System.Windows.Forms.Button()
        Me.MonsterSettingsButton = New System.Windows.Forms.Button()
        Me.timestamp_formatMapLabel = New System.Windows.Forms.Label()
        Me.stdout_with_ansisequenceMapLabel = New System.Windows.Forms.Label()
        Me.console_silentMapLabel = New System.Windows.Forms.Label()
        Me.buff_maxsizeLabel = New System.Windows.Forms.Label()
        Me.max_time_lastupdateLabel = New System.Windows.Forms.Label()
        Me.lightluggage_blockLabel = New System.Windows.Forms.Label()
        Me.vanadiel_time_offsetLabel = New System.Windows.Forms.Label()
        Me.AuditButton = New System.Windows.Forms.Button()
        Me.console_silentMapToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.map_portNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.map_portLabel = New System.Windows.Forms.Label()
        Me.vanadiel_time_offsetNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lightluggage_blockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.max_time_lastupdateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.buff_maxsizeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.console_silentMapNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.stdout_with_ansisequenceMapTextBox = New System.Windows.Forms.TextBox()
        Me.timestamp_formatMapTextBox = New System.Windows.Forms.TextBox()
        CType(Me.map_portNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vanadiel_time_offsetNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightluggage_blockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.max_time_lastupdateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buff_maxsizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.console_silentMapNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(357, 229)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(109, 23)
        Me.ApplySettingsButton.TabIndex = 52
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'CharacterSettingsButton
        '
        Me.CharacterSettingsButton.Location = New System.Drawing.Point(12, 229)
        Me.CharacterSettingsButton.Name = "CharacterSettingsButton"
        Me.CharacterSettingsButton.Size = New System.Drawing.Size(109, 23)
        Me.CharacterSettingsButton.TabIndex = 53
        Me.CharacterSettingsButton.Text = "Character Settings"
        Me.CharacterSettingsButton.UseVisualStyleBackColor = True
        '
        'MonsterSettingsButton
        '
        Me.MonsterSettingsButton.Location = New System.Drawing.Point(127, 229)
        Me.MonsterSettingsButton.Name = "MonsterSettingsButton"
        Me.MonsterSettingsButton.Size = New System.Drawing.Size(109, 23)
        Me.MonsterSettingsButton.TabIndex = 54
        Me.MonsterSettingsButton.Text = "Monster Settings"
        Me.MonsterSettingsButton.UseVisualStyleBackColor = True
        '
        'timestamp_formatMapLabel
        '
        Me.timestamp_formatMapLabel.AutoSize = True
        Me.timestamp_formatMapLabel.Location = New System.Drawing.Point(131, 46)
        Me.timestamp_formatMapLabel.Name = "timestamp_formatMapLabel"
        Me.timestamp_formatMapLabel.Size = New System.Drawing.Size(287, 13)
        Me.timestamp_formatMapLabel.TabIndex = 55
        Me.timestamp_formatMapLabel.Text = "Time-stamp format which will be printed before all messages"
        '
        'stdout_with_ansisequenceMapLabel
        '
        Me.stdout_with_ansisequenceMapLabel.AutoSize = True
        Me.stdout_with_ansisequenceMapLabel.Location = New System.Drawing.Point(131, 73)
        Me.stdout_with_ansisequenceMapLabel.Name = "stdout_with_ansisequenceMapLabel"
        Me.stdout_with_ansisequenceMapLabel.Size = New System.Drawing.Size(296, 13)
        Me.stdout_with_ansisequenceMapLabel.TabIndex = 56
        Me.stdout_with_ansisequenceMapLabel.Text = "If redirected output contains escape sequences (color codes)"
        '
        'console_silentMapLabel
        '
        Me.console_silentMapLabel.AutoSize = True
        Me.console_silentMapLabel.Location = New System.Drawing.Point(131, 100)
        Me.console_silentMapLabel.Name = "console_silentMapLabel"
        Me.console_silentMapLabel.Size = New System.Drawing.Size(343, 13)
        Me.console_silentMapLabel.TabIndex = 57
        Me.console_silentMapLabel.Text = "Makes server output more silent by ommitting certain types of messages"
        '
        'buff_maxsizeLabel
        '
        Me.buff_maxsizeLabel.AutoSize = True
        Me.buff_maxsizeLabel.Location = New System.Drawing.Point(131, 127)
        Me.buff_maxsizeLabel.Name = "buff_maxsizeLabel"
        Me.buff_maxsizeLabel.Size = New System.Drawing.Size(114, 13)
        Me.buff_maxsizeLabel.TabIndex = 58
        Me.buff_maxsizeLabel.Text = "Max buffer packet size"
        '
        'max_time_lastupdateLabel
        '
        Me.max_time_lastupdateLabel.AutoSize = True
        Me.max_time_lastupdateLabel.Location = New System.Drawing.Point(131, 154)
        Me.max_time_lastupdateLabel.Name = "max_time_lastupdateLabel"
        Me.max_time_lastupdateLabel.Size = New System.Drawing.Size(183, 13)
        Me.max_time_lastupdateLabel.TabIndex = 59
        Me.max_time_lastupdateLabel.Text = "Maximum time before packets update"
        '
        'lightluggage_blockLabel
        '
        Me.lightluggage_blockLabel.AutoSize = True
        Me.lightluggage_blockLabel.Location = New System.Drawing.Point(131, 181)
        Me.lightluggage_blockLabel.Name = "lightluggage_blockLabel"
        Me.lightluggage_blockLabel.Size = New System.Drawing.Size(105, 13)
        Me.lightluggage_blockLabel.TabIndex = 60
        Me.lightluggage_blockLabel.Text = "Light Luggage Block"
        '
        'vanadiel_time_offsetLabel
        '
        Me.vanadiel_time_offsetLabel.AutoSize = True
        Me.vanadiel_time_offsetLabel.Location = New System.Drawing.Point(131, 208)
        Me.vanadiel_time_offsetLabel.Name = "vanadiel_time_offsetLabel"
        Me.vanadiel_time_offsetLabel.Size = New System.Drawing.Size(99, 13)
        Me.vanadiel_time_offsetLabel.TabIndex = 61
        Me.vanadiel_time_offsetLabel.Text = "Vanadiel time offset"
        '
        'AuditButton
        '
        Me.AuditButton.Location = New System.Drawing.Point(242, 229)
        Me.AuditButton.Name = "AuditButton"
        Me.AuditButton.Size = New System.Drawing.Size(109, 23)
        Me.AuditButton.TabIndex = 62
        Me.AuditButton.Text = "Audit settings"
        Me.AuditButton.UseVisualStyleBackColor = True
        '
        'map_portNumericUpDown
        '
        Me.map_portNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "map_port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.map_portNumericUpDown.Location = New System.Drawing.Point(12, 13)
        Me.map_portNumericUpDown.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.map_portNumericUpDown.Name = "map_portNumericUpDown"
        Me.map_portNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.map_portNumericUpDown.TabIndex = 68
        Me.map_portNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.map_port
        '
        'map_portLabel
        '
        Me.map_portLabel.AutoSize = True
        Me.map_portLabel.Location = New System.Drawing.Point(131, 15)
        Me.map_portLabel.Name = "map_portLabel"
        Me.map_portLabel.Size = New System.Drawing.Size(81, 13)
        Me.map_portLabel.TabIndex = 69
        Me.map_portLabel.Text = "Map server port"
        '
        'vanadiel_time_offsetNumericUpDown
        '
        Me.vanadiel_time_offsetNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "vanadiel_time_offset", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.vanadiel_time_offsetNumericUpDown.Location = New System.Drawing.Point(12, 203)
        Me.vanadiel_time_offsetNumericUpDown.Name = "vanadiel_time_offsetNumericUpDown"
        Me.vanadiel_time_offsetNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.vanadiel_time_offsetNumericUpDown.TabIndex = 67
        Me.vanadiel_time_offsetNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.vanadiel_time_offset
        '
        'lightluggage_blockNumericUpDown
        '
        Me.lightluggage_blockNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "lightluggage_block", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lightluggage_blockNumericUpDown.Location = New System.Drawing.Point(12, 176)
        Me.lightluggage_blockNumericUpDown.Name = "lightluggage_blockNumericUpDown"
        Me.lightluggage_blockNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.lightluggage_blockNumericUpDown.TabIndex = 66
        Me.lightluggage_blockNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.lightluggage_block
        '
        'max_time_lastupdateNumericUpDown
        '
        Me.max_time_lastupdateNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "max_time_lastupdate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.max_time_lastupdateNumericUpDown.Location = New System.Drawing.Point(12, 149)
        Me.max_time_lastupdateNumericUpDown.Name = "max_time_lastupdateNumericUpDown"
        Me.max_time_lastupdateNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.max_time_lastupdateNumericUpDown.TabIndex = 65
        Me.max_time_lastupdateNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.max_time_lastupdate
        '
        'buff_maxsizeNumericUpDown
        '
        Me.buff_maxsizeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "buff_maxsize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.buff_maxsizeNumericUpDown.Location = New System.Drawing.Point(12, 121)
        Me.buff_maxsizeNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.buff_maxsizeNumericUpDown.Name = "buff_maxsizeNumericUpDown"
        Me.buff_maxsizeNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.buff_maxsizeNumericUpDown.TabIndex = 64
        Me.buff_maxsizeNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.buff_maxsize
        '
        'console_silentMapNumericUpDown
        '
        Me.console_silentMapNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "console_silentMap", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.console_silentMapNumericUpDown.Location = New System.Drawing.Point(12, 95)
        Me.console_silentMapNumericUpDown.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.console_silentMapNumericUpDown.Name = "console_silentMapNumericUpDown"
        Me.console_silentMapNumericUpDown.Size = New System.Drawing.Size(109, 20)
        Me.console_silentMapNumericUpDown.TabIndex = 63
        Me.console_silentMapNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.console_silentMap
        '
        'stdout_with_ansisequenceMapTextBox
        '
        Me.stdout_with_ansisequenceMapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DSP_Control.My.MySettings.Default, "stdout_with_ansisequenceMap", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.stdout_with_ansisequenceMapTextBox.Location = New System.Drawing.Point(12, 67)
        Me.stdout_with_ansisequenceMapTextBox.Name = "stdout_with_ansisequenceMapTextBox"
        Me.stdout_with_ansisequenceMapTextBox.Size = New System.Drawing.Size(109, 20)
        Me.stdout_with_ansisequenceMapTextBox.TabIndex = 1
        Me.stdout_with_ansisequenceMapTextBox.Text = Global.DSP_Control.My.MySettings.Default.stdout_with_ansisequenceMap
        '
        'timestamp_formatMapTextBox
        '
        Me.timestamp_formatMapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DSP_Control.My.MySettings.Default, "timestamp_formatMap", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timestamp_formatMapTextBox.Location = New System.Drawing.Point(12, 40)
        Me.timestamp_formatMapTextBox.Name = "timestamp_formatMapTextBox"
        Me.timestamp_formatMapTextBox.Size = New System.Drawing.Size(109, 20)
        Me.timestamp_formatMapTextBox.TabIndex = 0
        Me.timestamp_formatMapTextBox.Text = Global.DSP_Control.My.MySettings.Default.timestamp_formatMap
        '
        'ConfigFormMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 257)
        Me.Controls.Add(Me.map_portLabel)
        Me.Controls.Add(Me.map_portNumericUpDown)
        Me.Controls.Add(Me.vanadiel_time_offsetNumericUpDown)
        Me.Controls.Add(Me.lightluggage_blockNumericUpDown)
        Me.Controls.Add(Me.max_time_lastupdateNumericUpDown)
        Me.Controls.Add(Me.buff_maxsizeNumericUpDown)
        Me.Controls.Add(Me.console_silentMapNumericUpDown)
        Me.Controls.Add(Me.AuditButton)
        Me.Controls.Add(Me.vanadiel_time_offsetLabel)
        Me.Controls.Add(Me.lightluggage_blockLabel)
        Me.Controls.Add(Me.max_time_lastupdateLabel)
        Me.Controls.Add(Me.buff_maxsizeLabel)
        Me.Controls.Add(Me.console_silentMapLabel)
        Me.Controls.Add(Me.stdout_with_ansisequenceMapLabel)
        Me.Controls.Add(Me.timestamp_formatMapLabel)
        Me.Controls.Add(Me.MonsterSettingsButton)
        Me.Controls.Add(Me.CharacterSettingsButton)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.stdout_with_ansisequenceMapTextBox)
        Me.Controls.Add(Me.timestamp_formatMapTextBox)
        Me.Name = "ConfigFormMap"
        Me.Text = "Map Conf editor"
        CType(Me.map_portNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vanadiel_time_offsetNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightluggage_blockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.max_time_lastupdateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buff_maxsizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.console_silentMapNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timestamp_formatMapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stdout_with_ansisequenceMapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents CharacterSettingsButton As System.Windows.Forms.Button
    Friend WithEvents MonsterSettingsButton As System.Windows.Forms.Button
    Friend WithEvents timestamp_formatMapLabel As System.Windows.Forms.Label
    Friend WithEvents stdout_with_ansisequenceMapLabel As System.Windows.Forms.Label
    Friend WithEvents console_silentMapLabel As System.Windows.Forms.Label
    Friend WithEvents buff_maxsizeLabel As System.Windows.Forms.Label
    Friend WithEvents max_time_lastupdateLabel As System.Windows.Forms.Label
    Friend WithEvents lightluggage_blockLabel As System.Windows.Forms.Label
    Friend WithEvents vanadiel_time_offsetLabel As System.Windows.Forms.Label
    Friend WithEvents AuditButton As System.Windows.Forms.Button
    Friend WithEvents console_silentMapToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents console_silentMapNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents buff_maxsizeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents max_time_lastupdateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lightluggage_blockNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vanadiel_time_offsetNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents map_portNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents map_portLabel As System.Windows.Forms.Label
End Class
