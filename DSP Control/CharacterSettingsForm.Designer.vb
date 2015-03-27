<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterSettingsForm
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
        Me.FoVButton = New System.Windows.Forms.Button()
        Me.speed_modLabel = New System.Windows.Forms.Label()
        Me.CraftandSkillButton = New System.Windows.Forms.Button()
        Me.MAX_LEVELLabel = New System.Windows.Forms.Label()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.ExperienceRatesButton = New System.Windows.Forms.Button()
        Me.PlayerMultipliersButton = New System.Windows.Forms.Button()
        Me.StartingPlayerSettingButton = New System.Windows.Forms.Button()
        Me.MAX_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.max_merit_pointsLabel = New System.Windows.Forms.Label()
        Me.yell_cooldownNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.yell_cooldownLabel = New System.Windows.Forms.Label()
        Me.max_merit_pointsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.speed_modNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.all_jobs_widescanCheckBox = New System.Windows.Forms.CheckBox()
        Me.level_sync_enableCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.MAX_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yell_cooldownNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.max_merit_pointsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speed_modNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FoVButton
        '
        Me.FoVButton.Location = New System.Drawing.Point(3, 171)
        Me.FoVButton.Name = "FoVButton"
        Me.FoVButton.Size = New System.Drawing.Size(149, 23)
        Me.FoVButton.TabIndex = 6
        Me.FoVButton.Text = "Fields of Valor settings"
        Me.FoVButton.UseVisualStyleBackColor = True
        '
        'speed_modLabel
        '
        Me.speed_modLabel.AutoSize = True
        Me.speed_modLabel.Location = New System.Drawing.Point(118, 41)
        Me.speed_modLabel.Name = "speed_modLabel"
        Me.speed_modLabel.Size = New System.Drawing.Size(127, 13)
        Me.speed_modLabel.TabIndex = 14
        Me.speed_modLabel.Text = "Player speed modification"
        '
        'CraftandSkillButton
        '
        Me.CraftandSkillButton.Location = New System.Drawing.Point(157, 171)
        Me.CraftandSkillButton.Name = "CraftandSkillButton"
        Me.CraftandSkillButton.Size = New System.Drawing.Size(127, 23)
        Me.CraftandSkillButton.TabIndex = 15
        Me.CraftandSkillButton.Text = "Crafting/Skillup settings"
        Me.CraftandSkillButton.UseVisualStyleBackColor = True
        '
        'MAX_LEVELLabel
        '
        Me.MAX_LEVELLabel.AutoSize = True
        Me.MAX_LEVELLabel.Location = New System.Drawing.Point(118, 18)
        Me.MAX_LEVELLabel.Name = "MAX_LEVELLabel"
        Me.MAX_LEVELLabel.Size = New System.Drawing.Size(124, 13)
        Me.MAX_LEVELLabel.TabIndex = 30
        Me.MAX_LEVELLabel.Text = "Maximum character level"
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(157, 200)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(127, 23)
        Me.ApplySettingsButton.TabIndex = 43
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'ExperienceRatesButton
        '
        Me.ExperienceRatesButton.Location = New System.Drawing.Point(3, 200)
        Me.ExperienceRatesButton.Name = "ExperienceRatesButton"
        Me.ExperienceRatesButton.Size = New System.Drawing.Size(149, 23)
        Me.ExperienceRatesButton.TabIndex = 44
        Me.ExperienceRatesButton.Text = "Experience Rates"
        Me.ExperienceRatesButton.UseVisualStyleBackColor = True
        '
        'PlayerMultipliersButton
        '
        Me.PlayerMultipliersButton.Location = New System.Drawing.Point(158, 142)
        Me.PlayerMultipliersButton.Name = "PlayerMultipliersButton"
        Me.PlayerMultipliersButton.Size = New System.Drawing.Size(126, 23)
        Me.PlayerMultipliersButton.TabIndex = 64
        Me.PlayerMultipliersButton.Text = "Player Multipliers"
        Me.PlayerMultipliersButton.UseVisualStyleBackColor = True
        '
        'StartingPlayerSettingButton
        '
        Me.StartingPlayerSettingButton.Location = New System.Drawing.Point(3, 142)
        Me.StartingPlayerSettingButton.Name = "StartingPlayerSettingButton"
        Me.StartingPlayerSettingButton.Size = New System.Drawing.Size(149, 23)
        Me.StartingPlayerSettingButton.TabIndex = 65
        Me.StartingPlayerSettingButton.Text = "Starting Players Settings"
        Me.StartingPlayerSettingButton.UseVisualStyleBackColor = True
        '
        'MAX_LEVELNumericUpDown
        '
        Me.MAX_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "MAX_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MAX_LEVELNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.MAX_LEVELNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.MAX_LEVELNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MAX_LEVELNumericUpDown.Name = "MAX_LEVELNumericUpDown"
        Me.MAX_LEVELNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.MAX_LEVELNumericUpDown.TabIndex = 66
        Me.MAX_LEVELNumericUpDown.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'max_merit_pointsLabel
        '
        Me.max_merit_pointsLabel.AutoSize = True
        Me.max_merit_pointsLabel.Location = New System.Drawing.Point(118, 68)
        Me.max_merit_pointsLabel.Name = "max_merit_pointsLabel"
        Me.max_merit_pointsLabel.Size = New System.Drawing.Size(107, 13)
        Me.max_merit_pointsLabel.TabIndex = 70
        Me.max_merit_pointsLabel.Text = "Maximum merit points"
        '
        'yell_cooldownNumericUpDown
        '
        Me.yell_cooldownNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "yell_cooldown", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.yell_cooldownNumericUpDown.Location = New System.Drawing.Point(13, 93)
        Me.yell_cooldownNumericUpDown.Name = "yell_cooldownNumericUpDown"
        Me.yell_cooldownNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.yell_cooldownNumericUpDown.TabIndex = 71
        Me.yell_cooldownNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.yell_cooldown
        '
        'yell_cooldownLabel
        '
        Me.yell_cooldownLabel.AutoSize = True
        Me.yell_cooldownLabel.Location = New System.Drawing.Point(118, 95)
        Me.yell_cooldownLabel.Name = "yell_cooldownLabel"
        Me.yell_cooldownLabel.Size = New System.Drawing.Size(73, 13)
        Me.yell_cooldownLabel.TabIndex = 72
        Me.yell_cooldownLabel.Text = "Yell cooldown"
        '
        'max_merit_pointsNumericUpDown
        '
        Me.max_merit_pointsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "max_merit_points", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.max_merit_pointsNumericUpDown.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.max_merit_pointsNumericUpDown.Location = New System.Drawing.Point(13, 66)
        Me.max_merit_pointsNumericUpDown.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.max_merit_pointsNumericUpDown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.max_merit_pointsNumericUpDown.Name = "max_merit_pointsNumericUpDown"
        Me.max_merit_pointsNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.max_merit_pointsNumericUpDown.TabIndex = 69
        Me.max_merit_pointsNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.max_merit_points
        '
        'speed_modNumericUpDown
        '
        Me.speed_modNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "speed_mod", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.speed_modNumericUpDown.Location = New System.Drawing.Point(13, 39)
        Me.speed_modNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.speed_modNumericUpDown.Name = "speed_modNumericUpDown"
        Me.speed_modNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.speed_modNumericUpDown.TabIndex = 67
        Me.speed_modNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.speed_mod
        '
        'all_jobs_widescanCheckBox
        '
        Me.all_jobs_widescanCheckBox.AutoSize = True
        Me.all_jobs_widescanCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.all_jobs_widescan
        Me.all_jobs_widescanCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.all_jobs_widescanCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "all_jobs_widescan", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.all_jobs_widescanCheckBox.Location = New System.Drawing.Point(119, 119)
        Me.all_jobs_widescanCheckBox.Name = "all_jobs_widescanCheckBox"
        Me.all_jobs_widescanCheckBox.Size = New System.Drawing.Size(157, 17)
        Me.all_jobs_widescanCheckBox.TabIndex = 12
        Me.all_jobs_widescanCheckBox.Text = "Enable widescan for all jobs"
        Me.all_jobs_widescanCheckBox.UseVisualStyleBackColor = True
        '
        'level_sync_enableCheckBox
        '
        Me.level_sync_enableCheckBox.AutoSize = True
        Me.level_sync_enableCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.level_sync_enable
        Me.level_sync_enableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "level_sync_enable", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.level_sync_enableCheckBox.Location = New System.Drawing.Point(4, 119)
        Me.level_sync_enableCheckBox.Name = "level_sync_enableCheckBox"
        Me.level_sync_enableCheckBox.Size = New System.Drawing.Size(109, 17)
        Me.level_sync_enableCheckBox.TabIndex = 11
        Me.level_sync_enableCheckBox.Text = "Enable level sync"
        Me.level_sync_enableCheckBox.UseVisualStyleBackColor = True
        '
        'CharacterSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 231)
        Me.Controls.Add(Me.yell_cooldownLabel)
        Me.Controls.Add(Me.yell_cooldownNumericUpDown)
        Me.Controls.Add(Me.max_merit_pointsLabel)
        Me.Controls.Add(Me.max_merit_pointsNumericUpDown)
        Me.Controls.Add(Me.speed_modNumericUpDown)
        Me.Controls.Add(Me.MAX_LEVELNumericUpDown)
        Me.Controls.Add(Me.StartingPlayerSettingButton)
        Me.Controls.Add(Me.PlayerMultipliersButton)
        Me.Controls.Add(Me.ExperienceRatesButton)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.MAX_LEVELLabel)
        Me.Controls.Add(Me.CraftandSkillButton)
        Me.Controls.Add(Me.speed_modLabel)
        Me.Controls.Add(Me.all_jobs_widescanCheckBox)
        Me.Controls.Add(Me.level_sync_enableCheckBox)
        Me.Controls.Add(Me.FoVButton)
        Me.Name = "CharacterSettingsForm"
        Me.Text = "Character Settings"
        CType(Me.MAX_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yell_cooldownNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.max_merit_pointsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speed_modNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FoVButton As System.Windows.Forms.Button
    Friend WithEvents level_sync_enableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents all_jobs_widescanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents speed_modLabel As System.Windows.Forms.Label
    Friend WithEvents CraftandSkillButton As System.Windows.Forms.Button
    Friend WithEvents MAX_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents ExperienceRatesButton As System.Windows.Forms.Button
    Friend WithEvents PlayerMultipliersButton As System.Windows.Forms.Button
    Friend WithEvents StartingPlayerSettingButton As System.Windows.Forms.Button
    Friend WithEvents MAX_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents speed_modNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents max_merit_pointsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents max_merit_pointsLabel As System.Windows.Forms.Label
    Friend WithEvents yell_cooldownNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents yell_cooldownLabel As System.Windows.Forms.Label
End Class
