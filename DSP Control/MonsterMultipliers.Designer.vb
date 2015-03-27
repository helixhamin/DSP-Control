<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonsterMultipliers
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
        Me.mob_tp_multiplierLabel = New System.Windows.Forms.Label()
        Me.mob_hp_multiplierLabel = New System.Windows.Forms.Label()
        Me.mob_mp_multiplierLabel = New System.Windows.Forms.Label()
        Me.nm_stat_multiplierLabel = New System.Windows.Forms.Label()
        Me.mob_stat_multiplierLabel = New System.Windows.Forms.Label()
        Me.nm_hp_multiplierLabel = New System.Windows.Forms.Label()
        Me.nm_mp_multiplierLabel = New System.Windows.Forms.Label()
        Me.drop_rate_multiplierLabel = New System.Windows.Forms.Label()
        Me.mob_tp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mob_hp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.nm_hp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mob_mp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.nm_mp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mob_stat_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.nm_stat_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.drop_rate_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.mob_tp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mob_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mob_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mob_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drop_rate_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(68, 241)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(100, 23)
        Me.ApplySettingsButton.TabIndex = 57
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'mob_tp_multiplierLabel
        '
        Me.mob_tp_multiplierLabel.AutoSize = True
        Me.mob_tp_multiplierLabel.Location = New System.Drawing.Point(119, 15)
        Me.mob_tp_multiplierLabel.Name = "mob_tp_multiplierLabel"
        Me.mob_tp_multiplierLabel.Size = New System.Drawing.Size(105, 13)
        Me.mob_tp_multiplierLabel.TabIndex = 48
        Me.mob_tp_multiplierLabel.Text = "Monster TP multiplier"
        '
        'mob_hp_multiplierLabel
        '
        Me.mob_hp_multiplierLabel.AutoSize = True
        Me.mob_hp_multiplierLabel.Location = New System.Drawing.Point(119, 44)
        Me.mob_hp_multiplierLabel.Name = "mob_hp_multiplierLabel"
        Me.mob_hp_multiplierLabel.Size = New System.Drawing.Size(106, 13)
        Me.mob_hp_multiplierLabel.TabIndex = 50
        Me.mob_hp_multiplierLabel.Text = "Monster HP multiplier"
        '
        'mob_mp_multiplierLabel
        '
        Me.mob_mp_multiplierLabel.AutoSize = True
        Me.mob_mp_multiplierLabel.Location = New System.Drawing.Point(119, 102)
        Me.mob_mp_multiplierLabel.Name = "mob_mp_multiplierLabel"
        Me.mob_mp_multiplierLabel.Size = New System.Drawing.Size(107, 13)
        Me.mob_mp_multiplierLabel.TabIndex = 52
        Me.mob_mp_multiplierLabel.Text = "Monster MP multiplier"
        '
        'nm_stat_multiplierLabel
        '
        Me.nm_stat_multiplierLabel.AutoSize = True
        Me.nm_stat_multiplierLabel.Location = New System.Drawing.Point(119, 189)
        Me.nm_stat_multiplierLabel.Name = "nm_stat_multiplierLabel"
        Me.nm_stat_multiplierLabel.Size = New System.Drawing.Size(87, 13)
        Me.nm_stat_multiplierLabel.TabIndex = 54
        Me.nm_stat_multiplierLabel.Text = "NM stat multiplier"
        '
        'mob_stat_multiplierLabel
        '
        Me.mob_stat_multiplierLabel.AutoSize = True
        Me.mob_stat_multiplierLabel.Location = New System.Drawing.Point(119, 160)
        Me.mob_stat_multiplierLabel.Name = "mob_stat_multiplierLabel"
        Me.mob_stat_multiplierLabel.Size = New System.Drawing.Size(108, 13)
        Me.mob_stat_multiplierLabel.TabIndex = 56
        Me.mob_stat_multiplierLabel.Text = "Monster stat multiplier"
        '
        'nm_hp_multiplierLabel
        '
        Me.nm_hp_multiplierLabel.AutoSize = True
        Me.nm_hp_multiplierLabel.Location = New System.Drawing.Point(119, 73)
        Me.nm_hp_multiplierLabel.Name = "nm_hp_multiplierLabel"
        Me.nm_hp_multiplierLabel.Size = New System.Drawing.Size(85, 13)
        Me.nm_hp_multiplierLabel.TabIndex = 59
        Me.nm_hp_multiplierLabel.Text = "NM HP multiplier"
        '
        'nm_mp_multiplierLabel
        '
        Me.nm_mp_multiplierLabel.AutoSize = True
        Me.nm_mp_multiplierLabel.Location = New System.Drawing.Point(119, 131)
        Me.nm_mp_multiplierLabel.Name = "nm_mp_multiplierLabel"
        Me.nm_mp_multiplierLabel.Size = New System.Drawing.Size(86, 13)
        Me.nm_mp_multiplierLabel.TabIndex = 61
        Me.nm_mp_multiplierLabel.Text = "NM MP multiplier"
        '
        'drop_rate_multiplierLabel
        '
        Me.drop_rate_multiplierLabel.AutoSize = True
        Me.drop_rate_multiplierLabel.Location = New System.Drawing.Point(119, 218)
        Me.drop_rate_multiplierLabel.Name = "drop_rate_multiplierLabel"
        Me.drop_rate_multiplierLabel.Size = New System.Drawing.Size(94, 13)
        Me.drop_rate_multiplierLabel.TabIndex = 63
        Me.drop_rate_multiplierLabel.Text = "Drop rate multiplier"
        '
        'mob_tp_multiplierNumericUpDown
        '
        Me.mob_tp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "mob_tp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mob_tp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.mob_tp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.mob_tp_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.mob_tp_multiplierNumericUpDown.Name = "mob_tp_multiplierNumericUpDown"
        Me.mob_tp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.mob_tp_multiplierNumericUpDown.TabIndex = 64
        Me.mob_tp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.mob_tp_multiplier
        '
        'mob_hp_multiplierNumericUpDown
        '
        Me.mob_hp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "mob_hp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mob_hp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.mob_hp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.mob_hp_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 42)
        Me.mob_hp_multiplierNumericUpDown.Name = "mob_hp_multiplierNumericUpDown"
        Me.mob_hp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.mob_hp_multiplierNumericUpDown.TabIndex = 65
        Me.mob_hp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.mob_hp_multiplier
        '
        'nm_hp_multiplierNumericUpDown
        '
        Me.nm_hp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "nm_hp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nm_hp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.nm_hp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nm_hp_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 71)
        Me.nm_hp_multiplierNumericUpDown.Name = "nm_hp_multiplierNumericUpDown"
        Me.nm_hp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.nm_hp_multiplierNumericUpDown.TabIndex = 66
        Me.nm_hp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.nm_hp_multiplier
        '
        'mob_mp_multiplierNumericUpDown
        '
        Me.mob_mp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "mob_mp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mob_mp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.mob_mp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.mob_mp_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 100)
        Me.mob_mp_multiplierNumericUpDown.Name = "mob_mp_multiplierNumericUpDown"
        Me.mob_mp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.mob_mp_multiplierNumericUpDown.TabIndex = 67
        Me.mob_mp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.mob_mp_multiplier
        '
        'nm_mp_multiplierNumericUpDown
        '
        Me.nm_mp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "nm_mp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nm_mp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.nm_mp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nm_mp_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 129)
        Me.nm_mp_multiplierNumericUpDown.Name = "nm_mp_multiplierNumericUpDown"
        Me.nm_mp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.nm_mp_multiplierNumericUpDown.TabIndex = 68
        Me.nm_mp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.nm_mp_multiplier
        '
        'mob_stat_multiplierNumericUpDown
        '
        Me.mob_stat_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "mob_stat_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mob_stat_multiplierNumericUpDown.DecimalPlaces = 1
        Me.mob_stat_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.mob_stat_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 158)
        Me.mob_stat_multiplierNumericUpDown.Name = "mob_stat_multiplierNumericUpDown"
        Me.mob_stat_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.mob_stat_multiplierNumericUpDown.TabIndex = 69
        Me.mob_stat_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.mob_stat_multiplier
        '
        'nm_stat_multiplierNumericUpDown
        '
        Me.nm_stat_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "nm_stat_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nm_stat_multiplierNumericUpDown.DecimalPlaces = 1
        Me.nm_stat_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nm_stat_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 187)
        Me.nm_stat_multiplierNumericUpDown.Name = "nm_stat_multiplierNumericUpDown"
        Me.nm_stat_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.nm_stat_multiplierNumericUpDown.TabIndex = 70
        Me.nm_stat_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.nm_stat_multiplier
        '
        'drop_rate_multiplierNumericUpDown
        '
        Me.drop_rate_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "drop_rate_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.drop_rate_multiplierNumericUpDown.DecimalPlaces = 1
        Me.drop_rate_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.drop_rate_multiplierNumericUpDown.Location = New System.Drawing.Point(13, 216)
        Me.drop_rate_multiplierNumericUpDown.Name = "drop_rate_multiplierNumericUpDown"
        Me.drop_rate_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.drop_rate_multiplierNumericUpDown.TabIndex = 71
        Me.drop_rate_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.drop_rate_multiplier
        '
        'MonsterMultipliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 270)
        Me.Controls.Add(Me.drop_rate_multiplierNumericUpDown)
        Me.Controls.Add(Me.nm_stat_multiplierNumericUpDown)
        Me.Controls.Add(Me.mob_stat_multiplierNumericUpDown)
        Me.Controls.Add(Me.nm_mp_multiplierNumericUpDown)
        Me.Controls.Add(Me.mob_mp_multiplierNumericUpDown)
        Me.Controls.Add(Me.nm_hp_multiplierNumericUpDown)
        Me.Controls.Add(Me.mob_hp_multiplierNumericUpDown)
        Me.Controls.Add(Me.mob_tp_multiplierNumericUpDown)
        Me.Controls.Add(Me.drop_rate_multiplierLabel)
        Me.Controls.Add(Me.nm_mp_multiplierLabel)
        Me.Controls.Add(Me.nm_hp_multiplierLabel)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.mob_tp_multiplierLabel)
        Me.Controls.Add(Me.mob_hp_multiplierLabel)
        Me.Controls.Add(Me.mob_mp_multiplierLabel)
        Me.Controls.Add(Me.nm_stat_multiplierLabel)
        Me.Controls.Add(Me.mob_stat_multiplierLabel)
        Me.Name = "MonsterMultipliers"
        Me.Text = "Monster Multipliers"
        CType(Me.mob_tp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mob_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mob_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mob_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drop_rate_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents mob_tp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents mob_hp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents mob_mp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents nm_stat_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents mob_stat_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents nm_hp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents nm_mp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents drop_rate_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents mob_tp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mob_hp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents nm_hp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mob_mp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents nm_mp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mob_stat_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents nm_stat_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents drop_rate_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
