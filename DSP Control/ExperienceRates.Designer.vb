<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExperienceRates
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
        Me.exp_rateLabel = New System.Windows.Forms.Label()
        Me.exp_loss_rateLabel = New System.Windows.Forms.Label()
        Me.exp_retainLabel = New System.Windows.Forms.Label()
        Me.exp_loss_levelLabel = New System.Windows.Forms.Label()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.exp_party_gap_penaltiesCheckBox = New System.Windows.Forms.CheckBox()
        Me.exp_loss_levelNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.exp_retainNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.exp_loss_rateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.exp_rateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.exp_loss_levelNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exp_retainNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exp_loss_rateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exp_rateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exp_rateLabel
        '
        Me.exp_rateLabel.AutoSize = True
        Me.exp_rateLabel.Location = New System.Drawing.Point(115, 15)
        Me.exp_rateLabel.Name = "exp_rateLabel"
        Me.exp_rateLabel.Size = New System.Drawing.Size(104, 13)
        Me.exp_rateLabel.TabIndex = 12
        Me.exp_rateLabel.Text = "Experience gain rate"
        '
        'exp_loss_rateLabel
        '
        Me.exp_loss_rateLabel.AutoSize = True
        Me.exp_loss_rateLabel.Location = New System.Drawing.Point(115, 45)
        Me.exp_loss_rateLabel.Name = "exp_loss_rateLabel"
        Me.exp_loss_rateLabel.Size = New System.Drawing.Size(102, 13)
        Me.exp_loss_rateLabel.TabIndex = 14
        Me.exp_loss_rateLabel.Text = "Experience loss rate"
        '
        'exp_retainLabel
        '
        Me.exp_retainLabel.AutoSize = True
        Me.exp_retainLabel.Location = New System.Drawing.Point(115, 75)
        Me.exp_retainLabel.Name = "exp_retainLabel"
        Me.exp_retainLabel.Size = New System.Drawing.Size(146, 13)
        Me.exp_retainLabel.TabIndex = 18
        Me.exp_retainLabel.Text = "Experience retained on death"
        '
        'exp_loss_levelLabel
        '
        Me.exp_loss_levelLabel.AutoSize = True
        Me.exp_loss_levelLabel.Location = New System.Drawing.Point(115, 105)
        Me.exp_loss_levelLabel.Name = "exp_loss_levelLabel"
        Me.exp_loss_levelLabel.Size = New System.Drawing.Size(148, 13)
        Me.exp_loss_levelLabel.TabIndex = 20
        Me.exp_loss_levelLabel.Text = "Level which experience is lost"
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(88, 156)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(100, 23)
        Me.ApplySettingsButton.TabIndex = 44
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'exp_party_gap_penaltiesCheckBox
        '
        Me.exp_party_gap_penaltiesCheckBox.AutoSize = True
        Me.exp_party_gap_penaltiesCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.exp_party_gap_penalties
        Me.exp_party_gap_penaltiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.exp_party_gap_penaltiesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "exp_party_gap_penalties", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.exp_party_gap_penaltiesCheckBox.Location = New System.Drawing.Point(12, 133)
        Me.exp_party_gap_penaltiesCheckBox.Name = "exp_party_gap_penaltiesCheckBox"
        Me.exp_party_gap_penaltiesCheckBox.Size = New System.Drawing.Size(136, 17)
        Me.exp_party_gap_penaltiesCheckBox.TabIndex = 50
        Me.exp_party_gap_penaltiesCheckBox.Text = "Party gap exp penalties"
        Me.exp_party_gap_penaltiesCheckBox.UseVisualStyleBackColor = True
        '
        'exp_loss_levelNumericUpDown
        '
        Me.exp_loss_levelNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "exp_loss_level", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.exp_loss_levelNumericUpDown.Location = New System.Drawing.Point(12, 103)
        Me.exp_loss_levelNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.exp_loss_levelNumericUpDown.Name = "exp_loss_levelNumericUpDown"
        Me.exp_loss_levelNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.exp_loss_levelNumericUpDown.TabIndex = 49
        Me.exp_loss_levelNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.exp_loss_level
        '
        'exp_retainNumericUpDown
        '
        Me.exp_retainNumericUpDown.DecimalPlaces = 1
        Me.exp_retainNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.exp_retainNumericUpDown.Location = New System.Drawing.Point(12, 73)
        Me.exp_retainNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.exp_retainNumericUpDown.Name = "exp_retainNumericUpDown"
        Me.exp_retainNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.exp_retainNumericUpDown.TabIndex = 48
        '
        'exp_loss_rateNumericUpDown
        '
        Me.exp_loss_rateNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "exp_loss_rate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.exp_loss_rateNumericUpDown.DecimalPlaces = 1
        Me.exp_loss_rateNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.exp_loss_rateNumericUpDown.Location = New System.Drawing.Point(12, 43)
        Me.exp_loss_rateNumericUpDown.Name = "exp_loss_rateNumericUpDown"
        Me.exp_loss_rateNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.exp_loss_rateNumericUpDown.TabIndex = 46
        Me.exp_loss_rateNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.exp_loss_rate
        '
        'exp_rateNumericUpDown
        '
        Me.exp_rateNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "exp_rate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.exp_rateNumericUpDown.DecimalPlaces = 1
        Me.exp_rateNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.exp_rateNumericUpDown.Location = New System.Drawing.Point(12, 13)
        Me.exp_rateNumericUpDown.Name = "exp_rateNumericUpDown"
        Me.exp_rateNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.exp_rateNumericUpDown.TabIndex = 45
        Me.exp_rateNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.exp_rate
        '
        'ExperienceRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 192)
        Me.Controls.Add(Me.exp_party_gap_penaltiesCheckBox)
        Me.Controls.Add(Me.exp_loss_levelNumericUpDown)
        Me.Controls.Add(Me.exp_retainNumericUpDown)
        Me.Controls.Add(Me.exp_loss_rateNumericUpDown)
        Me.Controls.Add(Me.exp_rateNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.exp_rateLabel)
        Me.Controls.Add(Me.exp_loss_rateLabel)
        Me.Controls.Add(Me.exp_retainLabel)
        Me.Controls.Add(Me.exp_loss_levelLabel)
        Me.Name = "ExperienceRates"
        Me.Text = "Expereience Rates"
        CType(Me.exp_loss_levelNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exp_retainNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exp_loss_rateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exp_rateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exp_rateLabel As System.Windows.Forms.Label
    Friend WithEvents exp_loss_rateLabel As System.Windows.Forms.Label
    Friend WithEvents exp_retainLabel As System.Windows.Forms.Label
    Friend WithEvents exp_loss_levelLabel As System.Windows.Forms.Label
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents exp_rateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents exp_loss_rateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents exp_retainNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents exp_loss_levelNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents exp_party_gap_penaltiesCheckBox As System.Windows.Forms.CheckBox
End Class
