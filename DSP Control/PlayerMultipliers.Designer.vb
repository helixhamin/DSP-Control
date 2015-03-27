<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerMultipliers
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
        Me.player_tp_multiplierLabel = New System.Windows.Forms.Label()
        Me.player_hp_multiplierLabel = New System.Windows.Forms.Label()
        Me.player_mp_multiplierLabel = New System.Windows.Forms.Label()
        Me.sj_mp_divisorLabel = New System.Windows.Forms.Label()
        Me.player_stat_multiplierLabel = New System.Windows.Forms.Label()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.player_tp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.player_hp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.player_mp_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.player_stat_multiplierNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.sj_mp_divisorNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.player_tp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sj_mp_divisorNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player_tp_multiplierLabel
        '
        Me.player_tp_multiplierLabel.AutoSize = True
        Me.player_tp_multiplierLabel.Location = New System.Drawing.Point(113, 15)
        Me.player_tp_multiplierLabel.Name = "player_tp_multiplierLabel"
        Me.player_tp_multiplierLabel.Size = New System.Drawing.Size(96, 13)
        Me.player_tp_multiplierLabel.TabIndex = 37
        Me.player_tp_multiplierLabel.Text = "Player TP multiplier"
        '
        'player_hp_multiplierLabel
        '
        Me.player_hp_multiplierLabel.AutoSize = True
        Me.player_hp_multiplierLabel.Location = New System.Drawing.Point(113, 50)
        Me.player_hp_multiplierLabel.Name = "player_hp_multiplierLabel"
        Me.player_hp_multiplierLabel.Size = New System.Drawing.Size(97, 13)
        Me.player_hp_multiplierLabel.TabIndex = 39
        Me.player_hp_multiplierLabel.Text = "Player HP multiplier"
        '
        'player_mp_multiplierLabel
        '
        Me.player_mp_multiplierLabel.AutoSize = True
        Me.player_mp_multiplierLabel.Location = New System.Drawing.Point(113, 85)
        Me.player_mp_multiplierLabel.Name = "player_mp_multiplierLabel"
        Me.player_mp_multiplierLabel.Size = New System.Drawing.Size(98, 13)
        Me.player_mp_multiplierLabel.TabIndex = 41
        Me.player_mp_multiplierLabel.Text = "Player MP multiplier"
        '
        'sj_mp_divisorLabel
        '
        Me.sj_mp_divisorLabel.AutoSize = True
        Me.sj_mp_divisorLabel.Location = New System.Drawing.Point(113, 155)
        Me.sj_mp_divisorLabel.Name = "sj_mp_divisorLabel"
        Me.sj_mp_divisorLabel.Size = New System.Drawing.Size(93, 13)
        Me.sj_mp_divisorLabel.TabIndex = 43
        Me.sj_mp_divisorLabel.Text = "Subjob MP divider"
        '
        'player_stat_multiplierLabel
        '
        Me.player_stat_multiplierLabel.AutoSize = True
        Me.player_stat_multiplierLabel.Location = New System.Drawing.Point(113, 120)
        Me.player_stat_multiplierLabel.Name = "player_stat_multiplierLabel"
        Me.player_stat_multiplierLabel.Size = New System.Drawing.Size(99, 13)
        Me.player_stat_multiplierLabel.TabIndex = 45
        Me.player_stat_multiplierLabel.Text = "Player stat multiplier"
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(62, 187)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(100, 23)
        Me.ApplySettingsButton.TabIndex = 46
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'player_tp_multiplierNumericUpDown
        '
        Me.player_tp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "player_tp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.player_tp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.player_tp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.player_tp_multiplierNumericUpDown.Location = New System.Drawing.Point(12, 13)
        Me.player_tp_multiplierNumericUpDown.Name = "player_tp_multiplierNumericUpDown"
        Me.player_tp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.player_tp_multiplierNumericUpDown.TabIndex = 47
        Me.player_tp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.player_tp_multiplier
        '
        'player_hp_multiplierNumericUpDown
        '
        Me.player_hp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "player_hp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.player_hp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.player_hp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.player_hp_multiplierNumericUpDown.Location = New System.Drawing.Point(12, 48)
        Me.player_hp_multiplierNumericUpDown.Name = "player_hp_multiplierNumericUpDown"
        Me.player_hp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.player_hp_multiplierNumericUpDown.TabIndex = 48
        Me.player_hp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.player_hp_multiplier
        '
        'player_mp_multiplierNumericUpDown
        '
        Me.player_mp_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "player_mp_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.player_mp_multiplierNumericUpDown.DecimalPlaces = 1
        Me.player_mp_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.player_mp_multiplierNumericUpDown.Location = New System.Drawing.Point(12, 83)
        Me.player_mp_multiplierNumericUpDown.Name = "player_mp_multiplierNumericUpDown"
        Me.player_mp_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.player_mp_multiplierNumericUpDown.TabIndex = 49
        Me.player_mp_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.player_mp_multiplier
        '
        'player_stat_multiplierNumericUpDown
        '
        Me.player_stat_multiplierNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "player_stat_multiplier", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.player_stat_multiplierNumericUpDown.DecimalPlaces = 1
        Me.player_stat_multiplierNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.player_stat_multiplierNumericUpDown.Location = New System.Drawing.Point(12, 118)
        Me.player_stat_multiplierNumericUpDown.Name = "player_stat_multiplierNumericUpDown"
        Me.player_stat_multiplierNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.player_stat_multiplierNumericUpDown.TabIndex = 50
        Me.player_stat_multiplierNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.player_stat_multiplier
        '
        'sj_mp_divisorNumericUpDown
        '
        Me.sj_mp_divisorNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "sj_mp_divisor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.sj_mp_divisorNumericUpDown.DecimalPlaces = 1
        Me.sj_mp_divisorNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.sj_mp_divisorNumericUpDown.Location = New System.Drawing.Point(12, 153)
        Me.sj_mp_divisorNumericUpDown.Name = "sj_mp_divisorNumericUpDown"
        Me.sj_mp_divisorNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.sj_mp_divisorNumericUpDown.TabIndex = 51
        Me.sj_mp_divisorNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.sj_mp_divisor
        '
        'PlayerMultipliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 219)
        Me.Controls.Add(Me.sj_mp_divisorNumericUpDown)
        Me.Controls.Add(Me.player_stat_multiplierNumericUpDown)
        Me.Controls.Add(Me.player_mp_multiplierNumericUpDown)
        Me.Controls.Add(Me.player_hp_multiplierNumericUpDown)
        Me.Controls.Add(Me.player_tp_multiplierNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.player_tp_multiplierLabel)
        Me.Controls.Add(Me.player_hp_multiplierLabel)
        Me.Controls.Add(Me.player_mp_multiplierLabel)
        Me.Controls.Add(Me.sj_mp_divisorLabel)
        Me.Controls.Add(Me.player_stat_multiplierLabel)
        Me.Name = "PlayerMultipliers"
        Me.Text = "PlayerMultipliers"
        CType(Me.player_tp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_hp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_mp_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_stat_multiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sj_mp_divisorNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents player_tp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents player_hp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents player_mp_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents sj_mp_divisorLabel As System.Windows.Forms.Label
    Friend WithEvents player_stat_multiplierLabel As System.Windows.Forms.Label
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents player_tp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents player_hp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents player_mp_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents player_stat_multiplierNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents sj_mp_divisorNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
