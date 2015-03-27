<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quest_MissionSettings
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
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.WSNM_LEVELLabel = New System.Windows.Forms.Label()
        Me.WSNM_SKILL_LEVELLabel = New System.Windows.Forms.Label()
        Me.AF1_QUEST_LEVELLabel = New System.Windows.Forms.Label()
        Me.AF1_QUEST_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AF2_QUEST_LEVELLabel = New System.Windows.Forms.Label()
        Me.AF2_QUEST_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AF3_QUEST_LEVELLabel = New System.Windows.Forms.Label()
        Me.AF3_QUEST_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AF1_FAMELabel = New System.Windows.Forms.Label()
        Me.AF1_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AF2_FAMELabel = New System.Windows.Forms.Label()
        Me.AF2_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AF3_FAMELabel = New System.Windows.Forms.Label()
        Me.AF3_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.QM_RESET_TIMELabel = New System.Windows.Forms.Label()
        Me.QM_RESET_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FrigiciteDurationLabel = New System.Windows.Forms.Label()
        Me.FrigiciteDurationNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DEBUG_MODECheckBox = New System.Windows.Forms.CheckBox()
        Me.OldSchoolG1CheckBox = New System.Windows.Forms.CheckBox()
        Me.OldSchoolG2CheckBox = New System.Windows.Forms.CheckBox()
        Me.WSNM_SKILL_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WSNM_LEVELNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.AF1_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AF2_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AF3_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AF1_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AF2_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AF3_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QM_RESET_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrigiciteDurationNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSNM_SKILL_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSNM_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(116, 343)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'WSNM_LEVELLabel
        '
        Me.WSNM_LEVELLabel.AutoSize = True
        Me.WSNM_LEVELLabel.Location = New System.Drawing.Point(139, 15)
        Me.WSNM_LEVELLabel.Name = "WSNM_LEVELLabel"
        Me.WSNM_LEVELLabel.Size = New System.Drawing.Size(153, 13)
        Me.WSNM_LEVELLabel.TabIndex = 58
        Me.WSNM_LEVELLabel.Text = "Min level to get WSNM Quests"
        '
        'WSNM_SKILL_LEVELLabel
        '
        Me.WSNM_SKILL_LEVELLabel.AutoSize = True
        Me.WSNM_SKILL_LEVELLabel.Location = New System.Drawing.Point(138, 41)
        Me.WSNM_SKILL_LEVELLabel.Name = "WSNM_SKILL_LEVELLabel"
        Me.WSNM_SKILL_LEVELLabel.Size = New System.Drawing.Size(148, 13)
        Me.WSNM_SKILL_LEVELLabel.TabIndex = 60
        Me.WSNM_SKILL_LEVELLabel.Text = "Min skill to get WSNM Quests"
        '
        'AF1_QUEST_LEVELLabel
        '
        Me.AF1_QUEST_LEVELLabel.AutoSize = True
        Me.AF1_QUEST_LEVELLabel.Location = New System.Drawing.Point(138, 67)
        Me.AF1_QUEST_LEVELLabel.Name = "AF1_QUEST_LEVELLabel"
        Me.AF1_QUEST_LEVELLabel.Size = New System.Drawing.Size(135, 13)
        Me.AF1_QUEST_LEVELLabel.TabIndex = 62
        Me.AF1_QUEST_LEVELLabel.Text = "Min level to start AF1 quest"
        '
        'AF1_QUEST_LEVELNumericUpDown
        '
        Me.AF1_QUEST_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF1_QUEST_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF1_QUEST_LEVELNumericUpDown.Location = New System.Drawing.Point(12, 65)
        Me.AF1_QUEST_LEVELNumericUpDown.Name = "AF1_QUEST_LEVELNumericUpDown"
        Me.AF1_QUEST_LEVELNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF1_QUEST_LEVELNumericUpDown.TabIndex = 61
        Me.AF1_QUEST_LEVELNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF1_QUEST_LEVEL
        '
        'AF2_QUEST_LEVELLabel
        '
        Me.AF2_QUEST_LEVELLabel.AutoSize = True
        Me.AF2_QUEST_LEVELLabel.Location = New System.Drawing.Point(139, 93)
        Me.AF2_QUEST_LEVELLabel.Name = "AF2_QUEST_LEVELLabel"
        Me.AF2_QUEST_LEVELLabel.Size = New System.Drawing.Size(135, 13)
        Me.AF2_QUEST_LEVELLabel.TabIndex = 64
        Me.AF2_QUEST_LEVELLabel.Text = "Min level to start AF2 quest"
        '
        'AF2_QUEST_LEVELNumericUpDown
        '
        Me.AF2_QUEST_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF2_QUEST_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF2_QUEST_LEVELNumericUpDown.Location = New System.Drawing.Point(13, 91)
        Me.AF2_QUEST_LEVELNumericUpDown.Name = "AF2_QUEST_LEVELNumericUpDown"
        Me.AF2_QUEST_LEVELNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF2_QUEST_LEVELNumericUpDown.TabIndex = 63
        Me.AF2_QUEST_LEVELNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF2_QUEST_LEVEL
        '
        'AF3_QUEST_LEVELLabel
        '
        Me.AF3_QUEST_LEVELLabel.AutoSize = True
        Me.AF3_QUEST_LEVELLabel.Location = New System.Drawing.Point(139, 119)
        Me.AF3_QUEST_LEVELLabel.Name = "AF3_QUEST_LEVELLabel"
        Me.AF3_QUEST_LEVELLabel.Size = New System.Drawing.Size(135, 13)
        Me.AF3_QUEST_LEVELLabel.TabIndex = 66
        Me.AF3_QUEST_LEVELLabel.Text = "Min level to start AF3 quest"
        '
        'AF3_QUEST_LEVELNumericUpDown
        '
        Me.AF3_QUEST_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF3_QUEST_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF3_QUEST_LEVELNumericUpDown.Location = New System.Drawing.Point(13, 117)
        Me.AF3_QUEST_LEVELNumericUpDown.Name = "AF3_QUEST_LEVELNumericUpDown"
        Me.AF3_QUEST_LEVELNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF3_QUEST_LEVELNumericUpDown.TabIndex = 65
        Me.AF3_QUEST_LEVELNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF3_QUEST_LEVEL
        '
        'AF1_FAMELabel
        '
        Me.AF1_FAMELabel.AutoSize = True
        Me.AF1_FAMELabel.Location = New System.Drawing.Point(138, 145)
        Me.AF1_FAMELabel.Name = "AF1_FAMELabel"
        Me.AF1_FAMELabel.Size = New System.Drawing.Size(136, 13)
        Me.AF1_FAMELabel.TabIndex = 68
        Me.AF1_FAMELabel.Text = "Min fame to start AF1 quest"
        '
        'AF1_FAMENumericUpDown
        '
        Me.AF1_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF1_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF1_FAMENumericUpDown.Location = New System.Drawing.Point(12, 143)
        Me.AF1_FAMENumericUpDown.Name = "AF1_FAMENumericUpDown"
        Me.AF1_FAMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF1_FAMENumericUpDown.TabIndex = 67
        Me.AF1_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF1_FAME
        '
        'AF2_FAMELabel
        '
        Me.AF2_FAMELabel.AutoSize = True
        Me.AF2_FAMELabel.Location = New System.Drawing.Point(139, 171)
        Me.AF2_FAMELabel.Name = "AF2_FAMELabel"
        Me.AF2_FAMELabel.Size = New System.Drawing.Size(136, 13)
        Me.AF2_FAMELabel.TabIndex = 70
        Me.AF2_FAMELabel.Text = "Min fame to start AF2 quest"
        '
        'AF2_FAMENumericUpDown
        '
        Me.AF2_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF2_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF2_FAMENumericUpDown.Location = New System.Drawing.Point(13, 169)
        Me.AF2_FAMENumericUpDown.Name = "AF2_FAMENumericUpDown"
        Me.AF2_FAMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF2_FAMENumericUpDown.TabIndex = 69
        Me.AF2_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF2_FAME
        '
        'AF3_FAMELabel
        '
        Me.AF3_FAMELabel.AutoSize = True
        Me.AF3_FAMELabel.Location = New System.Drawing.Point(139, 197)
        Me.AF3_FAMELabel.Name = "AF3_FAMELabel"
        Me.AF3_FAMELabel.Size = New System.Drawing.Size(136, 13)
        Me.AF3_FAMELabel.TabIndex = 72
        Me.AF3_FAMELabel.Text = "Min fame to start AF2 quest"
        '
        'AF3_FAMENumericUpDown
        '
        Me.AF3_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "AF3_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AF3_FAMENumericUpDown.Location = New System.Drawing.Point(13, 195)
        Me.AF3_FAMENumericUpDown.Name = "AF3_FAMENumericUpDown"
        Me.AF3_FAMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AF3_FAMENumericUpDown.TabIndex = 71
        Me.AF3_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.AF3_FAME
        '
        'QM_RESET_TIMELabel
        '
        Me.QM_RESET_TIMELabel.AutoSize = True
        Me.QM_RESET_TIMELabel.Location = New System.Drawing.Point(139, 223)
        Me.QM_RESET_TIMELabel.Name = "QM_RESET_TIMELabel"
        Me.QM_RESET_TIMELabel.Size = New System.Drawing.Size(165, 13)
        Me.QM_RESET_TIMELabel.TabIndex = 74
        Me.QM_RESET_TIMELabel.Text = "Time until ??? resets for pop NMs"
        '
        'QM_RESET_TIMENumericUpDown
        '
        Me.QM_RESET_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "QM_RESET_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.QM_RESET_TIMENumericUpDown.Location = New System.Drawing.Point(13, 221)
        Me.QM_RESET_TIMENumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.QM_RESET_TIMENumericUpDown.Name = "QM_RESET_TIMENumericUpDown"
        Me.QM_RESET_TIMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.QM_RESET_TIMENumericUpDown.TabIndex = 73
        Me.QM_RESET_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.QM_RESET_TIME
        '
        'FrigiciteDurationLabel
        '
        Me.FrigiciteDurationLabel.AutoSize = True
        Me.FrigiciteDurationLabel.Location = New System.Drawing.Point(139, 249)
        Me.FrigiciteDurationLabel.Name = "FrigiciteDurationLabel"
        Me.FrigiciteDurationLabel.Size = New System.Drawing.Size(226, 13)
        Me.FrigiciteDurationLabel.TabIndex = 76
        Me.FrigiciteDurationLabel.Text = "Time from killing Boreal NMs to click the ""???"""
        '
        'FrigiciteDurationNumericUpDown
        '
        Me.FrigiciteDurationNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "FrigiciteDuration", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FrigiciteDurationNumericUpDown.Location = New System.Drawing.Point(13, 247)
        Me.FrigiciteDurationNumericUpDown.Name = "FrigiciteDurationNumericUpDown"
        Me.FrigiciteDurationNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.FrigiciteDurationNumericUpDown.TabIndex = 75
        Me.FrigiciteDurationNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.FrigiciteDuration
        '
        'DEBUG_MODECheckBox
        '
        Me.DEBUG_MODECheckBox.AutoSize = True
        Me.DEBUG_MODECheckBox.Checked = Global.DSP_Control.My.MySettings.Default.DEBUG_MODE
        Me.DEBUG_MODECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "DEBUG_MODE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DEBUG_MODECheckBox.Location = New System.Drawing.Point(13, 274)
        Me.DEBUG_MODECheckBox.Name = "DEBUG_MODECheckBox"
        Me.DEBUG_MODECheckBox.Size = New System.Drawing.Size(233, 17)
        Me.DEBUG_MODECheckBox.TabIndex = 77
        Me.DEBUG_MODECheckBox.Text = "Activate auto warping to next quest location"
        Me.DEBUG_MODECheckBox.UseVisualStyleBackColor = True
        '
        'OldSchoolG1CheckBox
        '
        Me.OldSchoolG1CheckBox.AutoSize = True
        Me.OldSchoolG1CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.OldSchoolG1
        Me.OldSchoolG1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "OldSchoolG1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OldSchoolG1CheckBox.Location = New System.Drawing.Point(13, 297)
        Me.OldSchoolG1CheckBox.Name = "OldSchoolG1CheckBox"
        Me.OldSchoolG1CheckBox.Size = New System.Drawing.Size(255, 17)
        Me.OldSchoolG1CheckBox.TabIndex = 78
        Me.OldSchoolG1CheckBox.Text = "Disallow key items for In Defiant Challenge quest"
        Me.OldSchoolG1CheckBox.UseVisualStyleBackColor = True
        '
        'OldSchoolG2CheckBox
        '
        Me.OldSchoolG2CheckBox.AutoSize = True
        Me.OldSchoolG2CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.OldSchoolG2
        Me.OldSchoolG2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "OldSchoolG2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OldSchoolG2CheckBox.Location = New System.Drawing.Point(12, 320)
        Me.OldSchoolG2CheckBox.Name = "OldSchoolG2CheckBox"
        Me.OldSchoolG2CheckBox.Size = New System.Drawing.Size(257, 17)
        Me.OldSchoolG2CheckBox.TabIndex = 79
        Me.OldSchoolG2CheckBox.Text = "Require NM kill for ""Atop the Highest Mountains"""
        Me.OldSchoolG2CheckBox.UseVisualStyleBackColor = True
        '
        'WSNM_SKILL_LEVELNumericUpDown
        '
        Me.WSNM_SKILL_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WSNM_SKILL_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WSNM_SKILL_LEVELNumericUpDown.Location = New System.Drawing.Point(12, 39)
        Me.WSNM_SKILL_LEVELNumericUpDown.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.WSNM_SKILL_LEVELNumericUpDown.Name = "WSNM_SKILL_LEVELNumericUpDown"
        Me.WSNM_SKILL_LEVELNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.WSNM_SKILL_LEVELNumericUpDown.TabIndex = 59
        Me.WSNM_SKILL_LEVELNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WSNM_SKILL_LEVEL
        '
        'WSNM_LEVELNumericUpDown
        '
        Me.WSNM_LEVELNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WSNM_LEVEL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WSNM_LEVELNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.WSNM_LEVELNumericUpDown.Name = "WSNM_LEVELNumericUpDown"
        Me.WSNM_LEVELNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.WSNM_LEVELNumericUpDown.TabIndex = 57
        Me.WSNM_LEVELNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WSNM_LEVEL
        '
        'Quest_MissionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 373)
        Me.Controls.Add(Me.OldSchoolG2CheckBox)
        Me.Controls.Add(Me.OldSchoolG1CheckBox)
        Me.Controls.Add(Me.DEBUG_MODECheckBox)
        Me.Controls.Add(Me.FrigiciteDurationLabel)
        Me.Controls.Add(Me.FrigiciteDurationNumericUpDown)
        Me.Controls.Add(Me.QM_RESET_TIMELabel)
        Me.Controls.Add(Me.QM_RESET_TIMENumericUpDown)
        Me.Controls.Add(Me.AF3_FAMELabel)
        Me.Controls.Add(Me.AF3_FAMENumericUpDown)
        Me.Controls.Add(Me.AF2_FAMELabel)
        Me.Controls.Add(Me.AF2_FAMENumericUpDown)
        Me.Controls.Add(Me.AF1_FAMELabel)
        Me.Controls.Add(Me.AF1_FAMENumericUpDown)
        Me.Controls.Add(Me.AF3_QUEST_LEVELLabel)
        Me.Controls.Add(Me.AF3_QUEST_LEVELNumericUpDown)
        Me.Controls.Add(Me.AF2_QUEST_LEVELLabel)
        Me.Controls.Add(Me.AF2_QUEST_LEVELNumericUpDown)
        Me.Controls.Add(Me.AF1_QUEST_LEVELLabel)
        Me.Controls.Add(Me.AF1_QUEST_LEVELNumericUpDown)
        Me.Controls.Add(Me.WSNM_SKILL_LEVELLabel)
        Me.Controls.Add(Me.WSNM_SKILL_LEVELNumericUpDown)
        Me.Controls.Add(Me.WSNM_LEVELLabel)
        Me.Controls.Add(Me.WSNM_LEVELNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "Quest_MissionSettings"
        Me.Text = "Quest/Mission Settings"
        CType(Me.AF1_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AF2_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AF3_QUEST_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AF1_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AF2_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AF3_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QM_RESET_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrigiciteDurationNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSNM_SKILL_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSNM_LEVELNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents WSNM_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WSNM_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents WSNM_SKILL_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents WSNM_SKILL_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF1_QUEST_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents AF1_QUEST_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF2_QUEST_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents AF2_QUEST_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF3_QUEST_LEVELLabel As System.Windows.Forms.Label
    Friend WithEvents AF3_QUEST_LEVELNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF1_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents AF1_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF2_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents AF2_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AF3_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents AF3_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QM_RESET_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents QM_RESET_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents FrigiciteDurationLabel As System.Windows.Forms.Label
    Friend WithEvents FrigiciteDurationNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DEBUG_MODECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OldSchoolG1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OldSchoolG2CheckBox As System.Windows.Forms.CheckBox
End Class
