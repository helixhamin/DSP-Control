<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOVSettings
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
        Me.EXP_RATEFOVNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.EXP_RATEFOVLabel = New System.Windows.Forms.Label()
        Me.TABS_RATELabel = New System.Windows.Forms.Label()
        Me.TABS_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.fov_party_gap_penaltiesCheckBox = New System.Windows.Forms.CheckBox()
        Me.GROUNDS_TOMESCheckBox = New System.Windows.Forms.CheckBox()
        Me.LOW_LEVEL_REGIMECheckBox = New System.Windows.Forms.CheckBox()
        Me.FIELD_MANUALSCheckBox = New System.Windows.Forms.CheckBox()
        Me.REGIME_WAITCheckBox = New System.Windows.Forms.CheckBox()
        Me.fov_allow_allianceCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.EXP_RATEFOVNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABS_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(75, 207)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(100, 23)
        Me.ApplySettingsButton.TabIndex = 47
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'EXP_RATEFOVNumericUpDown
        '
        Me.EXP_RATEFOVNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "EXP_RATEFOV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXP_RATEFOVNumericUpDown.DecimalPlaces = 3
        Me.EXP_RATEFOVNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.EXP_RATEFOVNumericUpDown.Location = New System.Drawing.Point(13, 155)
        Me.EXP_RATEFOVNumericUpDown.Name = "EXP_RATEFOVNumericUpDown"
        Me.EXP_RATEFOVNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.EXP_RATEFOVNumericUpDown.TabIndex = 49
        Me.EXP_RATEFOVNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.EXP_RATEFOV
        '
        'EXP_RATEFOVLabel
        '
        Me.EXP_RATEFOVLabel.AutoSize = True
        Me.EXP_RATEFOVLabel.Location = New System.Drawing.Point(119, 157)
        Me.EXP_RATEFOVLabel.Name = "EXP_RATEFOVLabel"
        Me.EXP_RATEFOVLabel.Size = New System.Drawing.Size(128, 13)
        Me.EXP_RATEFOVLabel.TabIndex = 50
        Me.EXP_RATEFOVLabel.Text = "Multiplies FoV earned exp"
        '
        'TABS_RATELabel
        '
        Me.TABS_RATELabel.AutoSize = True
        Me.TABS_RATELabel.Location = New System.Drawing.Point(118, 183)
        Me.TABS_RATELabel.Name = "TABS_RATELabel"
        Me.TABS_RATELabel.Size = New System.Drawing.Size(131, 13)
        Me.TABS_RATELabel.TabIndex = 52
        Me.TABS_RATELabel.Text = "Multiplies FoV earned tabs"
        '
        'TABS_RATENumericUpDown
        '
        Me.TABS_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "TABS_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TABS_RATENumericUpDown.DecimalPlaces = 3
        Me.TABS_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.TABS_RATENumericUpDown.Location = New System.Drawing.Point(12, 181)
        Me.TABS_RATENumericUpDown.Name = "TABS_RATENumericUpDown"
        Me.TABS_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.TABS_RATENumericUpDown.TabIndex = 51
        Me.TABS_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.TABS_RATE
        '
        'fov_party_gap_penaltiesCheckBox
        '
        Me.fov_party_gap_penaltiesCheckBox.AutoSize = True
        Me.fov_party_gap_penaltiesCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.fov_party_gap_penalties
        Me.fov_party_gap_penaltiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fov_party_gap_penaltiesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "fov_party_gap_penalties", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.fov_party_gap_penaltiesCheckBox.Location = New System.Drawing.Point(13, 13)
        Me.fov_party_gap_penaltiesCheckBox.Name = "fov_party_gap_penaltiesCheckBox"
        Me.fov_party_gap_penaltiesCheckBox.Size = New System.Drawing.Size(184, 17)
        Me.fov_party_gap_penaltiesCheckBox.TabIndex = 48
        Me.fov_party_gap_penaltiesCheckBox.Text = "Fields of Valor party gap penalties"
        Me.fov_party_gap_penaltiesCheckBox.UseVisualStyleBackColor = True
        '
        'GROUNDS_TOMESCheckBox
        '
        Me.GROUNDS_TOMESCheckBox.AutoSize = True
        Me.GROUNDS_TOMESCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.GROUNDS_TOMES
        Me.GROUNDS_TOMESCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GROUNDS_TOMESCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "GROUNDS_TOMES", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GROUNDS_TOMESCheckBox.Location = New System.Drawing.Point(12, 131)
        Me.GROUNDS_TOMESCheckBox.Name = "GROUNDS_TOMESCheckBox"
        Me.GROUNDS_TOMESCheckBox.Size = New System.Drawing.Size(172, 17)
        Me.GROUNDS_TOMESCheckBox.TabIndex = 6
        Me.GROUNDS_TOMESCheckBox.Text = "Enable Grounds of Valor tomes"
        Me.GROUNDS_TOMESCheckBox.UseVisualStyleBackColor = True
        '
        'LOW_LEVEL_REGIMECheckBox
        '
        Me.LOW_LEVEL_REGIMECheckBox.AutoSize = True
        Me.LOW_LEVEL_REGIMECheckBox.Checked = Global.DSP_Control.My.MySettings.Default.LOW_LEVEL_REGIME
        Me.LOW_LEVEL_REGIMECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "LOW_LEVEL_REGIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LOW_LEVEL_REGIMECheckBox.Location = New System.Drawing.Point(12, 108)
        Me.LOW_LEVEL_REGIMECheckBox.Name = "LOW_LEVEL_REGIMECheckBox"
        Me.LOW_LEVEL_REGIMECheckBox.Size = New System.Drawing.Size(226, 17)
        Me.LOW_LEVEL_REGIMECheckBox.TabIndex = 5
        Me.LOW_LEVEL_REGIMECheckBox.Text = "Allow regime use when above regime level"
        Me.LOW_LEVEL_REGIMECheckBox.UseVisualStyleBackColor = True
        '
        'FIELD_MANUALSCheckBox
        '
        Me.FIELD_MANUALSCheckBox.AutoSize = True
        Me.FIELD_MANUALSCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.FIELD_MANUALS
        Me.FIELD_MANUALSCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FIELD_MANUALSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "FIELD_MANUALS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FIELD_MANUALSCheckBox.Location = New System.Drawing.Point(12, 85)
        Me.FIELD_MANUALSCheckBox.Name = "FIELD_MANUALSCheckBox"
        Me.FIELD_MANUALSCheckBox.Size = New System.Drawing.Size(170, 17)
        Me.FIELD_MANUALSCheckBox.TabIndex = 4
        Me.FIELD_MANUALSCheckBox.Text = "Enable Fields of Valor manuals"
        Me.FIELD_MANUALSCheckBox.UseVisualStyleBackColor = True
        '
        'REGIME_WAITCheckBox
        '
        Me.REGIME_WAITCheckBox.AutoSize = True
        Me.REGIME_WAITCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.REGIME_WAIT
        Me.REGIME_WAITCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.REGIME_WAITCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "REGIME_WAIT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.REGIME_WAITCheckBox.Location = New System.Drawing.Point(12, 62)
        Me.REGIME_WAITCheckBox.Name = "REGIME_WAITCheckBox"
        Me.REGIME_WAITCheckBox.Size = New System.Drawing.Size(97, 17)
        Me.REGIME_WAITCheckBox.TabIndex = 3
        Me.REGIME_WAITCheckBox.Text = "Wait for regime"
        Me.REGIME_WAITCheckBox.UseVisualStyleBackColor = True
        '
        'fov_allow_allianceCheckBox
        '
        Me.fov_allow_allianceCheckBox.AutoSize = True
        Me.fov_allow_allianceCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.fov_allow_alliance
        Me.fov_allow_allianceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fov_allow_allianceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "fov_allow_alliance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.fov_allow_allianceCheckBox.Location = New System.Drawing.Point(12, 39)
        Me.fov_allow_allianceCheckBox.Name = "fov_allow_allianceCheckBox"
        Me.fov_allow_allianceCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.fov_allow_allianceCheckBox.TabIndex = 2
        Me.fov_allow_allianceCheckBox.Text = "Allow alliance"
        Me.fov_allow_allianceCheckBox.UseVisualStyleBackColor = True
        '
        'FOVSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 239)
        Me.Controls.Add(Me.TABS_RATELabel)
        Me.Controls.Add(Me.TABS_RATENumericUpDown)
        Me.Controls.Add(Me.EXP_RATEFOVLabel)
        Me.Controls.Add(Me.EXP_RATEFOVNumericUpDown)
        Me.Controls.Add(Me.fov_party_gap_penaltiesCheckBox)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.GROUNDS_TOMESCheckBox)
        Me.Controls.Add(Me.LOW_LEVEL_REGIMECheckBox)
        Me.Controls.Add(Me.FIELD_MANUALSCheckBox)
        Me.Controls.Add(Me.REGIME_WAITCheckBox)
        Me.Controls.Add(Me.fov_allow_allianceCheckBox)
        Me.Name = "FOVSettings"
        Me.Text = "Fields of Valor Settings"
        CType(Me.EXP_RATEFOVNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABS_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fov_allow_allianceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents REGIME_WAITCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FIELD_MANUALSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LOW_LEVEL_REGIMECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GROUNDS_TOMESCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents fov_party_gap_penaltiesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EXP_RATEFOVNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents EXP_RATEFOVLabel As System.Windows.Forms.Label
    Friend WithEvents TABS_RATELabel As System.Windows.Forms.Label
    Friend WithEvents TABS_RATENumericUpDown As System.Windows.Forms.NumericUpDown
End Class
