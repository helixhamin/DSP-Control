<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonsterSettingsForm
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
        Me.MonsterMultipliersButton = New System.Windows.Forms.Button()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.all_mobs_gil_bonusLabel = New System.Windows.Forms.Label()
        Me.max_gil_bonusLabel = New System.Windows.Forms.Label()
        Me.Battle_cap_tweakLabel = New System.Windows.Forms.Label()
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel = New System.Windows.Forms.Label()
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel = New System.Windows.Forms.Label()
        Me.NORMAL_MOB_MAX_LEVEL_RANGEToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LandKingSystem_HQLabel = New System.Windows.Forms.Label()
        Me.LandKingSystem_NQLabel = New System.Windows.Forms.Label()
        Me.mob_speed_modNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mob_speed_modLabel = New System.Windows.Forms.Label()
        Me.LandKingSystem_HQNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LandKingSystem_NQNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Battle_cap_tweakNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.max_gil_bonusNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.all_mobs_gil_bonusNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.mob_speed_modNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandKingSystem_HQNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandKingSystem_NQNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Battle_cap_tweakNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.max_gil_bonusNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.all_mobs_gil_bonusNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonsterMultipliersButton
        '
        Me.MonsterMultipliersButton.Location = New System.Drawing.Point(27, 224)
        Me.MonsterMultipliersButton.Name = "MonsterMultipliersButton"
        Me.MonsterMultipliersButton.Size = New System.Drawing.Size(127, 23)
        Me.MonsterMultipliersButton.TabIndex = 65
        Me.MonsterMultipliersButton.Text = "Monster Multipliers"
        Me.MonsterMultipliersButton.UseVisualStyleBackColor = True
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(160, 224)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(100, 23)
        Me.ApplySettingsButton.TabIndex = 66
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'all_mobs_gil_bonusLabel
        '
        Me.all_mobs_gil_bonusLabel.AutoSize = True
        Me.all_mobs_gil_bonusLabel.Location = New System.Drawing.Point(139, 15)
        Me.all_mobs_gil_bonusLabel.Name = "all_mobs_gil_bonusLabel"
        Me.all_mobs_gil_bonusLabel.Size = New System.Drawing.Size(155, 13)
        Me.all_mobs_gil_bonusLabel.TabIndex = 69
        Me.all_mobs_gil_bonusLabel.Text = "Bonus gil drop from all monsters"
        '
        'max_gil_bonusLabel
        '
        Me.max_gil_bonusLabel.AutoSize = True
        Me.max_gil_bonusLabel.Location = New System.Drawing.Point(139, 42)
        Me.max_gil_bonusLabel.Name = "max_gil_bonusLabel"
        Me.max_gil_bonusLabel.Size = New System.Drawing.Size(96, 13)
        Me.max_gil_bonusLabel.TabIndex = 70
        Me.max_gil_bonusLabel.Text = "Max gil drop bonus"
        '
        'Battle_cap_tweakLabel
        '
        Me.Battle_cap_tweakLabel.AutoSize = True
        Me.Battle_cap_tweakLabel.Location = New System.Drawing.Point(139, 69)
        Me.Battle_cap_tweakLabel.Name = "Battle_cap_tweakLabel"
        Me.Battle_cap_tweakLabel.Size = New System.Drawing.Size(128, 13)
        Me.Battle_cap_tweakLabel.TabIndex = 72
        Me.Battle_cap_tweakLabel.Text = "Increase battle cap levels"
        '
        'NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel
        '
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.AutoSize = True
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.Location = New System.Drawing.Point(139, 122)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.Name = "NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel"
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.Size = New System.Drawing.Size(183, 13)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.TabIndex = 74
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel.Text = "Normal monsters minimum level range"
        '
        'NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel
        '
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.AutoSize = True
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.Location = New System.Drawing.Point(139, 148)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.Name = "NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel"
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.Size = New System.Drawing.Size(186, 13)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.TabIndex = 76
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel.Text = "Normal monsters maximum level range"
        '
        'LandKingSystem_HQLabel
        '
        Me.LandKingSystem_HQLabel.AutoSize = True
        Me.LandKingSystem_HQLabel.Location = New System.Drawing.Point(139, 200)
        Me.LandKingSystem_HQLabel.Name = "LandKingSystem_HQLabel"
        Me.LandKingSystem_HQLabel.Size = New System.Drawing.Size(174, 13)
        Me.LandKingSystem_HQLabel.TabIndex = 80
        Me.LandKingSystem_HQLabel.Text = "Spawn properties for HQ land kings"
        '
        'LandKingSystem_NQLabel
        '
        Me.LandKingSystem_NQLabel.AutoSize = True
        Me.LandKingSystem_NQLabel.Location = New System.Drawing.Point(139, 174)
        Me.LandKingSystem_NQLabel.Name = "LandKingSystem_NQLabel"
        Me.LandKingSystem_NQLabel.Size = New System.Drawing.Size(174, 13)
        Me.LandKingSystem_NQLabel.TabIndex = 78
        Me.LandKingSystem_NQLabel.Text = "Spawn properties for NQ land kings"
        '
        'mob_speed_modNumericUpDown
        '
        Me.mob_speed_modNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "mob_speed_mod", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mob_speed_modNumericUpDown.Location = New System.Drawing.Point(13, 94)
        Me.mob_speed_modNumericUpDown.Name = "mob_speed_modNumericUpDown"
        Me.mob_speed_modNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.mob_speed_modNumericUpDown.TabIndex = 81
        Me.mob_speed_modNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.mob_speed_mod
        '
        'mob_speed_modLabel
        '
        Me.mob_speed_modLabel.AutoSize = True
        Me.mob_speed_modLabel.Location = New System.Drawing.Point(139, 96)
        Me.mob_speed_modLabel.Name = "mob_speed_modLabel"
        Me.mob_speed_modLabel.Size = New System.Drawing.Size(107, 13)
        Me.mob_speed_modLabel.TabIndex = 82
        Me.mob_speed_modLabel.Text = "Monster's speed mod"
        '
        'LandKingSystem_HQNumericUpDown
        '
        Me.LandKingSystem_HQNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "LandKingSystem_HQ", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LandKingSystem_HQNumericUpDown.Location = New System.Drawing.Point(13, 198)
        Me.LandKingSystem_HQNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.LandKingSystem_HQNumericUpDown.Name = "LandKingSystem_HQNumericUpDown"
        Me.LandKingSystem_HQNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.LandKingSystem_HQNumericUpDown.TabIndex = 79
        Me.NORMAL_MOB_MAX_LEVEL_RANGEToolTip.SetToolTip(Me.LandKingSystem_HQNumericUpDown, "Sets spawn type for: Behemoth, Fafnir, Adamantoise, King Behemoth, Nidhog, Aspido" & _
        "chelone." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use 0 for timed spawns, 1 for force pop only, 2 for both")
        Me.LandKingSystem_HQNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.LandKingSystem_HQ
        '
        'LandKingSystem_NQNumericUpDown
        '
        Me.LandKingSystem_NQNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "LandKingSystem_NQ", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LandKingSystem_NQNumericUpDown.Location = New System.Drawing.Point(13, 172)
        Me.LandKingSystem_NQNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.LandKingSystem_NQNumericUpDown.Name = "LandKingSystem_NQNumericUpDown"
        Me.LandKingSystem_NQNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.LandKingSystem_NQNumericUpDown.TabIndex = 77
        Me.NORMAL_MOB_MAX_LEVEL_RANGEToolTip.SetToolTip(Me.LandKingSystem_NQNumericUpDown, "Sets spawn type for: Behemoth, Fafnir, Adamantoise, King Behemoth, Nidhog, Aspido" & _
        "chelone." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use 0 for timed spawns, 1 for force pop only, 2 for both")
        Me.LandKingSystem_NQNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.LandKingSystem_NQ
        '
        'NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown
        '
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "NORMAL_MOB_MAX_LEVEL_RANGE_MAX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Location = New System.Drawing.Point(13, 146)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Name = "NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown"
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.TabIndex = 75
        Me.NORMAL_MOB_MAX_LEVEL_RANGEToolTip.SetToolTip(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown, "0 = Uncapped")
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.NORMAL_MOB_MAX_LEVEL_RANGE_MAX
        '
        'NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown
        '
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "NORMAL_MOB_MAX_LEVEL_RANGE_MIN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Location = New System.Drawing.Point(13, 120)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Name = "NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown"
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.TabIndex = 73
        Me.NORMAL_MOB_MAX_LEVEL_RANGEToolTip.SetToolTip(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown, "0 = Uncapped")
        Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.NORMAL_MOB_MAX_LEVEL_RANGE_MIN
        '
        'Battle_cap_tweakNumericUpDown
        '
        Me.Battle_cap_tweakNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "Battle_cap_tweak", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Battle_cap_tweakNumericUpDown.Location = New System.Drawing.Point(13, 67)
        Me.Battle_cap_tweakNumericUpDown.Name = "Battle_cap_tweakNumericUpDown"
        Me.Battle_cap_tweakNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.Battle_cap_tweakNumericUpDown.TabIndex = 71
        Me.Battle_cap_tweakNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.Battle_cap_tweak
        '
        'max_gil_bonusNumericUpDown
        '
        Me.max_gil_bonusNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "max_gil_bonus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.max_gil_bonusNumericUpDown.Location = New System.Drawing.Point(13, 40)
        Me.max_gil_bonusNumericUpDown.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.max_gil_bonusNumericUpDown.Name = "max_gil_bonusNumericUpDown"
        Me.max_gil_bonusNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.max_gil_bonusNumericUpDown.TabIndex = 68
        Me.max_gil_bonusNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.max_gil_bonus
        '
        'all_mobs_gil_bonusNumericUpDown
        '
        Me.all_mobs_gil_bonusNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "all_mobs_gil_bonus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.all_mobs_gil_bonusNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.all_mobs_gil_bonusNumericUpDown.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.all_mobs_gil_bonusNumericUpDown.Name = "all_mobs_gil_bonusNumericUpDown"
        Me.all_mobs_gil_bonusNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.all_mobs_gil_bonusNumericUpDown.TabIndex = 67
        Me.all_mobs_gil_bonusNumericUpDown.ThousandsSeparator = True
        Me.all_mobs_gil_bonusNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.all_mobs_gil_bonus
        '
        'MonsterSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 259)
        Me.Controls.Add(Me.mob_speed_modLabel)
        Me.Controls.Add(Me.mob_speed_modNumericUpDown)
        Me.Controls.Add(Me.LandKingSystem_HQLabel)
        Me.Controls.Add(Me.LandKingSystem_HQNumericUpDown)
        Me.Controls.Add(Me.LandKingSystem_NQLabel)
        Me.Controls.Add(Me.LandKingSystem_NQNumericUpDown)
        Me.Controls.Add(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel)
        Me.Controls.Add(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown)
        Me.Controls.Add(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel)
        Me.Controls.Add(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown)
        Me.Controls.Add(Me.Battle_cap_tweakLabel)
        Me.Controls.Add(Me.Battle_cap_tweakNumericUpDown)
        Me.Controls.Add(Me.max_gil_bonusLabel)
        Me.Controls.Add(Me.all_mobs_gil_bonusLabel)
        Me.Controls.Add(Me.max_gil_bonusNumericUpDown)
        Me.Controls.Add(Me.all_mobs_gil_bonusNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.MonsterMultipliersButton)
        Me.Name = "MonsterSettingsForm"
        Me.Text = "Monster Settings Form"
        CType(Me.mob_speed_modNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandKingSystem_HQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandKingSystem_NQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Battle_cap_tweakNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.max_gil_bonusNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.all_mobs_gil_bonusNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonsterMultipliersButton As System.Windows.Forms.Button
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents all_mobs_gil_bonusNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents max_gil_bonusNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents all_mobs_gil_bonusLabel As System.Windows.Forms.Label
    Friend WithEvents max_gil_bonusLabel As System.Windows.Forms.Label
    Friend WithEvents Battle_cap_tweakNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Battle_cap_tweakLabel As System.Windows.Forms.Label
    Friend WithEvents NORMAL_MOB_MAX_LEVEL_RANGE_MINNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NORMAL_MOB_MAX_LEVEL_RANGE_MINLabel As System.Windows.Forms.Label
    Friend WithEvents NORMAL_MOB_MAX_LEVEL_RANGE_MAXLabel As System.Windows.Forms.Label
    Friend WithEvents NORMAL_MOB_MAX_LEVEL_RANGE_MAXNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NORMAL_MOB_MAX_LEVEL_RANGEToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LandKingSystem_HQLabel As System.Windows.Forms.Label
    Friend WithEvents LandKingSystem_HQNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LandKingSystem_NQLabel As System.Windows.Forms.Label
    Friend WithEvents LandKingSystem_NQNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mob_speed_modNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mob_speed_modLabel As System.Windows.Forms.Label
End Class
