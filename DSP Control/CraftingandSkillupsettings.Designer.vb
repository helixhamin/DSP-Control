<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CraftingandSkillupsettings
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
        Me.skillup_chance_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.craft_chance_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.skillup_amount_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.craft_amount_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.newstyle_skillupsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.craft_day_mattersCheckBox = New System.Windows.Forms.CheckBox()
        Me.craft_moonphase_mattersCheckBox = New System.Windows.Forms.CheckBox()
        Me.craft_direction_mattersCheckBox = New System.Windows.Forms.CheckBox()
        Me.skillup_chance_multiplierLabel = New System.Windows.Forms.Label()
        Me.craft_chance_multiplierLabel = New System.Windows.Forms.Label()
        Me.skillup_amount_multiplierLabel = New System.Windows.Forms.Label()
        Me.craft_amount_multiplierLabel = New System.Windows.Forms.Label()
        Me.newstyle_skillupsLabel = New System.Windows.Forms.Label()
        Me.GuildPointssettingButton = New System.Windows.Forms.Button()
        Me.MaterialCollectingButton = New System.Windows.Forms.Button()
        Me.newstyle_skillupsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.skillup_chance_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.craft_chance_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillup_amount_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.craft_amount_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newstyle_skillupsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(73, 250)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(127, 23)
        Me.ApplySettingsButton.TabIndex = 44
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'skillup_chance_multiplierNumericUpDown
        '
        Me.skillup_chance_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "skillup_chance_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skillup_chance_multiplierNumericUpDown.DecimalPlaces = 1
        Me.skillup_chance_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.skillup_chance_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.skillup_chance_multiplierNumericUpDown.Name = "skillup_chance_multiplierNumericUpDown"
        Me.skillup_chance_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.skillup_chance_multiplierNumericUpDown.TabIndex = 45
        Me.skillup_chance_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.skillup_chance_multiplier
        '
        'craft_chance_multiplierNumericUpDown
        '
        Me.craft_chance_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "craft_chance_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.craft_chance_multiplierNumericUpDown.DecimalPlaces = 1
        Me.craft_chance_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.craft_chance_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 40)
        Me.craft_chance_multiplierNumericUpDown.Name = "craft_chance_multiplierNumericUpDown"
        Me.craft_chance_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.craft_chance_multiplierNumericUpDown.TabIndex = 46
        Me.craft_chance_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.craft_chance_multiplier
        '
        'skillup_amount_multiplierNumericUpDown
        '
        Me.skillup_amount_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "skillup_amount_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skillup_amount_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 67)
        Me.skillup_amount_multiplierNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.skillup_amount_multiplierNumericUpDown.Name = "skillup_amount_multiplierNumericUpDown"
        Me.skillup_amount_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.skillup_amount_multiplierNumericUpDown.TabIndex = 47
        Me.skillup_amount_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.skillup_amount_multiplier
        '
        'craft_amount_multiplierNumericUpDown
        '
        Me.craft_amount_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "craft_amount_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.craft_amount_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 94)
        Me.craft_amount_multiplierNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.craft_amount_multiplierNumericUpDown.Name = "craft_amount_multiplierNumericUpDown"
        Me.craft_amount_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.craft_amount_multiplierNumericUpDown.TabIndex = 48
        Me.craft_amount_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.craft_amount_multiplier
        '
        'newstyle_skillupsNumericUpDown
        '
        Me.newstyle_skillupsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "newstyle_skillups", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.newstyle_skillupsNumericUpDown.Location = New System.Drawing.Point(13, 121)
        Me.newstyle_skillupsNumericUpDown.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.newstyle_skillupsNumericUpDown.Name = "newstyle_skillupsNumericUpDown"
        Me.newstyle_skillupsNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.newstyle_skillupsNumericUpDown.TabIndex = 49
        Me.newstyle_skillupsToolTip.SetToolTip(Me.newstyle_skillupsNumericUpDown, "Allows parry, block, and guard to skill up regardless of the action occuring." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bi" & _
        "n  Dec Note" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0000 0   Classic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0001 1   Parry" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0010 2   Block" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0100 4   Guard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & _
        "111 7   Parry, Block, & Guard")
        Me.newstyle_skillupsNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.newstyle_skillups
        '
        'craft_day_mattersCheckBox
        '
        Me.craft_day_mattersCheckBox.AutoSize = True
        Me.craft_day_mattersCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.craft_day_matters
        Me.craft_day_mattersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.craft_day_mattersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "craft_day_matters", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.craft_day_mattersCheckBox.Location = New System.Drawing.Point(13, 148)
        Me.craft_day_mattersCheckBox.Name = "craft_day_mattersCheckBox"
        Me.craft_day_mattersCheckBox.Size = New System.Drawing.Size(105, 17)
        Me.craft_day_mattersCheckBox.TabIndex = 50
        Me.craft_day_mattersCheckBox.Text = "Craft day matters"
        Me.craft_day_mattersCheckBox.UseVisualStyleBackColor = True
        '
        'craft_moonphase_mattersCheckBox
        '
        Me.craft_moonphase_mattersCheckBox.AutoSize = True
        Me.craft_moonphase_mattersCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.craft_moonphase_matters
        Me.craft_moonphase_mattersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "craft_moonphase_matters", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.craft_moonphase_mattersCheckBox.Location = New System.Drawing.Point(13, 172)
        Me.craft_moonphase_mattersCheckBox.Name = "craft_moonphase_mattersCheckBox"
        Me.craft_moonphase_mattersCheckBox.Size = New System.Drawing.Size(143, 17)
        Me.craft_moonphase_mattersCheckBox.TabIndex = 51
        Me.craft_moonphase_mattersCheckBox.Text = "Craft moonphase matters"
        Me.craft_moonphase_mattersCheckBox.UseVisualStyleBackColor = True
        '
        'craft_direction_mattersCheckBox
        '
        Me.craft_direction_mattersCheckBox.AutoSize = True
        Me.craft_direction_mattersCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.craft_direction_matters
        Me.craft_direction_mattersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "craft_direction_matters", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.craft_direction_mattersCheckBox.Location = New System.Drawing.Point(13, 196)
        Me.craft_direction_mattersCheckBox.Name = "craft_direction_mattersCheckBox"
        Me.craft_direction_mattersCheckBox.Size = New System.Drawing.Size(128, 17)
        Me.craft_direction_mattersCheckBox.TabIndex = 52
        Me.craft_direction_mattersCheckBox.Text = "Craft direction matters"
        Me.craft_direction_mattersCheckBox.UseVisualStyleBackColor = True
        '
        'skillup_chance_multiplierLabel
        '
        Me.skillup_chance_multiplierLabel.AutoSize = True
        Me.skillup_chance_multiplierLabel.Location = New System.Drawing.Point(119, 15)
        Me.skillup_chance_multiplierLabel.Name = "skillup_chance_multiplierLabel"
        Me.skillup_chance_multiplierLabel.Size = New System.Drawing.Size(120, 13)
        Me.skillup_chance_multiplierLabel.TabIndex = 53
        Me.skillup_chance_multiplierLabel.Text = "Skillup chance multiplier"
        '
        'craft_chance_multiplierLabel
        '
        Me.craft_chance_multiplierLabel.AutoSize = True
        Me.craft_chance_multiplierLabel.Location = New System.Drawing.Point(119, 42)
        Me.craft_chance_multiplierLabel.Name = "craft_chance_multiplierLabel"
        Me.craft_chance_multiplierLabel.Size = New System.Drawing.Size(111, 13)
        Me.craft_chance_multiplierLabel.TabIndex = 54
        Me.craft_chance_multiplierLabel.Text = "Craft chance multiplier"
        '
        'skillup_amount_multiplierLabel
        '
        Me.skillup_amount_multiplierLabel.AutoSize = True
        Me.skillup_amount_multiplierLabel.Location = New System.Drawing.Point(119, 69)
        Me.skillup_amount_multiplierLabel.Name = "skillup_amount_multiplierLabel"
        Me.skillup_amount_multiplierLabel.Size = New System.Drawing.Size(119, 13)
        Me.skillup_amount_multiplierLabel.TabIndex = 55
        Me.skillup_amount_multiplierLabel.Text = "Skillup amount multiplier"
        '
        'craft_amount_multiplierLabel
        '
        Me.craft_amount_multiplierLabel.AutoSize = True
        Me.craft_amount_multiplierLabel.Location = New System.Drawing.Point(119, 96)
        Me.craft_amount_multiplierLabel.Name = "craft_amount_multiplierLabel"
        Me.craft_amount_multiplierLabel.Size = New System.Drawing.Size(110, 13)
        Me.craft_amount_multiplierLabel.TabIndex = 56
        Me.craft_amount_multiplierLabel.Text = "Craft amount multiplier"
        '
        'newstyle_skillupsLabel
        '
        Me.newstyle_skillupsLabel.AutoSize = True
        Me.newstyle_skillupsLabel.Location = New System.Drawing.Point(119, 123)
        Me.newstyle_skillupsLabel.Name = "newstyle_skillupsLabel"
        Me.newstyle_skillupsLabel.Size = New System.Drawing.Size(69, 13)
        Me.newstyle_skillupsLabel.TabIndex = 57
        Me.newstyle_skillupsLabel.Text = "Skillup Styles"
        '
        'GuildPointssettingButton
        '
        Me.GuildPointssettingButton.Location = New System.Drawing.Point(13, 220)
        Me.GuildPointssettingButton.Name = "GuildPointssettingButton"
        Me.GuildPointssettingButton.Size = New System.Drawing.Size(104, 23)
        Me.GuildPointssettingButton.TabIndex = 58
        Me.GuildPointssettingButton.Text = "Guild Points"
        Me.GuildPointssettingButton.UseVisualStyleBackColor = True
        '
        'MaterialCollectingButton
        '
        Me.MaterialCollectingButton.Location = New System.Drawing.Point(140, 220)
        Me.MaterialCollectingButton.Name = "MaterialCollectingButton"
        Me.MaterialCollectingButton.Size = New System.Drawing.Size(104, 23)
        Me.MaterialCollectingButton.TabIndex = 59
        Me.MaterialCollectingButton.Text = "Material Collecting"
        Me.MaterialCollectingButton.UseVisualStyleBackColor = True
        '
        'CraftingandSkillupsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 285)
        Me.Controls.Add(Me.MaterialCollectingButton)
        Me.Controls.Add(Me.GuildPointssettingButton)
        Me.Controls.Add(Me.newstyle_skillupsLabel)
        Me.Controls.Add(Me.craft_amount_multiplierLabel)
        Me.Controls.Add(Me.skillup_amount_multiplierLabel)
        Me.Controls.Add(Me.craft_chance_multiplierLabel)
        Me.Controls.Add(Me.skillup_chance_multiplierLabel)
        Me.Controls.Add(Me.craft_direction_mattersCheckBox)
        Me.Controls.Add(Me.craft_moonphase_mattersCheckBox)
        Me.Controls.Add(Me.craft_day_mattersCheckBox)
        Me.Controls.Add(Me.newstyle_skillupsNumericUpDown)
        Me.Controls.Add(Me.craft_amount_multiplierNumericUpDown)
        Me.Controls.Add(Me.skillup_amount_multiplierNumericUpDown)
        Me.Controls.Add(Me.craft_chance_multiplierNumericUpDown)
        Me.Controls.Add(Me.skillup_chance_multiplierNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "CraftingandSkillupsettings"
        Me.Text = "Crafting/Skillup settings"
        CType(Me.skillup_chance_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.craft_chance_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillup_amount_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.craft_amount_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newstyle_skillupsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents skillup_chance_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents craft_chance_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents skillup_amount_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents craft_amount_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents newstyle_skillupsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents craft_day_mattersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents craft_moonphase_mattersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents craft_direction_mattersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents skillup_chance_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents craft_chance_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents skillup_amount_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents craft_amount_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents newstyle_skillupsLabel As System.Windows.Forms.Label
    Friend WithEvents GuildPointssettingButton As System.Windows.Forms.Button
    Friend WithEvents MaterialCollectingButton As System.Windows.Forms.Button
    Friend WithEvents newstyle_skillupsToolTip As System.Windows.Forms.ToolTip
End Class
