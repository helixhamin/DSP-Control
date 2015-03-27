<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ability_TraitSettings
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
        Me.SCAVENGE_RATELabel = New System.Windows.Forms.Label()
        Me.STATUS_RESIST_MULTIPLIERLabel = New System.Windows.Forms.Label()
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CIRCLE_DURATIONLabel = New System.Windows.Forms.Label()
        Me.CIRCLE_DURATIONNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CIRCLE_KILLER_EFFECTLabel = New System.Windows.Forms.Label()
        Me.CIRCLE_KILLER_EFFECTNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.KILLER_EFFECTLabel = New System.Windows.Forms.Label()
        Me.KILLER_EFFECTNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SCAVENGE_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.STATUS_RESIST_MULTIPLIERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIRCLE_DURATIONNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIRCLE_KILLER_EFFECTNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KILLER_EFFECTNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCAVENGE_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(112, 143)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'SCAVENGE_RATELabel
        '
        Me.SCAVENGE_RATELabel.AutoSize = True
        Me.SCAVENGE_RATELabel.Location = New System.Drawing.Point(119, 15)
        Me.SCAVENGE_RATELabel.Name = "SCAVENGE_RATELabel"
        Me.SCAVENGE_RATELabel.Size = New System.Drawing.Size(76, 13)
        Me.SCAVENGE_RATELabel.TabIndex = 58
        Me.SCAVENGE_RATELabel.Text = "Scavage Rate"
        '
        'STATUS_RESIST_MULTIPLIERLabel
        '
        Me.STATUS_RESIST_MULTIPLIERLabel.AutoSize = True
        Me.STATUS_RESIST_MULTIPLIERLabel.Location = New System.Drawing.Point(118, 41)
        Me.STATUS_RESIST_MULTIPLIERLabel.Name = "STATUS_RESIST_MULTIPLIERLabel"
        Me.STATUS_RESIST_MULTIPLIERLabel.Size = New System.Drawing.Size(142, 13)
        Me.STATUS_RESIST_MULTIPLIERLabel.TabIndex = 60
        Me.STATUS_RESIST_MULTIPLIERLabel.Text = "Strength of status resist traits"
        '
        'STATUS_RESIST_MULTIPLIERNumericUpDown
        '
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "STATUS_RESIST_MULTIPLIER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.Location = New System.Drawing.Point(12, 39)
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.Name = "STATUS_RESIST_MULTIPLIERNumericUpDown"
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.TabIndex = 59
        Me.STATUS_RESIST_MULTIPLIERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.STATUS_RESIST_MULTIPLIER
        '
        'CIRCLE_DURATIONLabel
        '
        Me.CIRCLE_DURATIONLabel.AutoSize = True
        Me.CIRCLE_DURATIONLabel.Location = New System.Drawing.Point(119, 67)
        Me.CIRCLE_DURATIONLabel.Name = "CIRCLE_DURATIONLabel"
        Me.CIRCLE_DURATIONLabel.Size = New System.Drawing.Size(122, 13)
        Me.CIRCLE_DURATIONLabel.TabIndex = 62
        Me.CIRCLE_DURATIONLabel.Text = "Duration of circle effects"
        '
        'CIRCLE_DURATIONNumericUpDown
        '
        Me.CIRCLE_DURATIONNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CIRCLE_DURATION", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CIRCLE_DURATIONNumericUpDown.Location = New System.Drawing.Point(13, 65)
        Me.CIRCLE_DURATIONNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CIRCLE_DURATIONNumericUpDown.Name = "CIRCLE_DURATIONNumericUpDown"
        Me.CIRCLE_DURATIONNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.CIRCLE_DURATIONNumericUpDown.TabIndex = 61
        Me.CIRCLE_DURATIONNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CIRCLE_DURATION
        '
        'CIRCLE_KILLER_EFFECTLabel
        '
        Me.CIRCLE_KILLER_EFFECTLabel.AutoSize = True
        Me.CIRCLE_KILLER_EFFECTLabel.Location = New System.Drawing.Point(118, 93)
        Me.CIRCLE_KILLER_EFFECTLabel.Name = "CIRCLE_KILLER_EFFECTLabel"
        Me.CIRCLE_KILLER_EFFECTLabel.Size = New System.Drawing.Size(233, 13)
        Me.CIRCLE_KILLER_EFFECTLabel.TabIndex = 64
        Me.CIRCLE_KILLER_EFFECTLabel.Text = "Intimidation percentage granted by circle effects"
        '
        'CIRCLE_KILLER_EFFECTNumericUpDown
        '
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CIRCLE_KILLER_EFFECT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.Location = New System.Drawing.Point(12, 91)
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.Name = "CIRCLE_KILLER_EFFECTNumericUpDown"
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.TabIndex = 63
        Me.CIRCLE_KILLER_EFFECTNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CIRCLE_KILLER_EFFECT
        '
        'KILLER_EFFECTLabel
        '
        Me.KILLER_EFFECTLabel.AutoSize = True
        Me.KILLER_EFFECTLabel.Location = New System.Drawing.Point(118, 119)
        Me.KILLER_EFFECTLabel.Name = "KILLER_EFFECTLabel"
        Me.KILLER_EFFECTLabel.Size = New System.Drawing.Size(206, 13)
        Me.KILLER_EFFECTLabel.TabIndex = 66
        Me.KILLER_EFFECTLabel.Text = "Intimidation percentage from killer job traits"
        '
        'KILLER_EFFECTNumericUpDown
        '
        Me.KILLER_EFFECTNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "KILLER_EFFECT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.KILLER_EFFECTNumericUpDown.Location = New System.Drawing.Point(12, 117)
        Me.KILLER_EFFECTNumericUpDown.Name = "KILLER_EFFECTNumericUpDown"
        Me.KILLER_EFFECTNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.KILLER_EFFECTNumericUpDown.TabIndex = 65
        Me.KILLER_EFFECTNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.KILLER_EFFECT
        '
        'SCAVENGE_RATENumericUpDown
        '
        Me.SCAVENGE_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "SCAVENGE_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SCAVENGE_RATENumericUpDown.DecimalPlaces = 1
        Me.SCAVENGE_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.SCAVENGE_RATENumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.SCAVENGE_RATENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SCAVENGE_RATENumericUpDown.Name = "SCAVENGE_RATENumericUpDown"
        Me.SCAVENGE_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.SCAVENGE_RATENumericUpDown.TabIndex = 57
        Me.SCAVENGE_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.SCAVENGE_RATE
        '
        'Ability_TraitSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 173)
        Me.Controls.Add(Me.KILLER_EFFECTLabel)
        Me.Controls.Add(Me.KILLER_EFFECTNumericUpDown)
        Me.Controls.Add(Me.CIRCLE_KILLER_EFFECTLabel)
        Me.Controls.Add(Me.CIRCLE_KILLER_EFFECTNumericUpDown)
        Me.Controls.Add(Me.CIRCLE_DURATIONLabel)
        Me.Controls.Add(Me.CIRCLE_DURATIONNumericUpDown)
        Me.Controls.Add(Me.STATUS_RESIST_MULTIPLIERLabel)
        Me.Controls.Add(Me.STATUS_RESIST_MULTIPLIERNumericUpDown)
        Me.Controls.Add(Me.SCAVENGE_RATELabel)
        Me.Controls.Add(Me.SCAVENGE_RATENumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "Ability_TraitSettings"
        Me.Text = "Ability/Trait Settings"
        CType(Me.STATUS_RESIST_MULTIPLIERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIRCLE_DURATIONNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIRCLE_KILLER_EFFECTNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KILLER_EFFECTNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCAVENGE_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents SCAVENGE_RATENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SCAVENGE_RATELabel As System.Windows.Forms.Label
    Friend WithEvents STATUS_RESIST_MULTIPLIERLabel As System.Windows.Forms.Label
    Friend WithEvents STATUS_RESIST_MULTIPLIERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CIRCLE_DURATIONLabel As System.Windows.Forms.Label
    Friend WithEvents CIRCLE_DURATIONNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CIRCLE_KILLER_EFFECTLabel As System.Windows.Forms.Label
    Friend WithEvents CIRCLE_KILLER_EFFECTNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents KILLER_EFFECTLabel As System.Windows.Forms.Label
    Friend WithEvents KILLER_EFFECTNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
