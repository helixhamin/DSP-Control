<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFormSearch
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
        Me.expire_daysLabel = New System.Windows.Forms.Label()
        Me.expire_intervalLabel = New System.Windows.Forms.Label()
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.no_auction_limitsCheckBox = New System.Windows.Forms.CheckBox()
        Me.expire_intervalNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.expire_daysNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.expire_auctionsCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.expire_intervalNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expire_daysNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'expire_daysLabel
        '
        Me.expire_daysLabel.AutoSize = True
        Me.expire_daysLabel.Location = New System.Drawing.Point(118, 65)
        Me.expire_daysLabel.Name = "expire_daysLabel"
        Me.expire_daysLabel.Size = New System.Drawing.Size(138, 13)
        Me.expire_daysLabel.TabIndex = 2
        Me.expire_daysLabel.Text = "Days before auctions expire"
        '
        'expire_intervalLabel
        '
        Me.expire_intervalLabel.AutoSize = True
        Me.expire_intervalLabel.Location = New System.Drawing.Point(118, 92)
        Me.expire_intervalLabel.Name = "expire_intervalLabel"
        Me.expire_intervalLabel.Size = New System.Drawing.Size(91, 13)
        Me.expire_intervalLabel.TabIndex = 4
        Me.expire_intervalLabel.Text = "Expiration Interval"
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(86, 112)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(93, 23)
        Me.ApplySettingsButton.TabIndex = 5
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'no_auction_limitsCheckBox
        '
        Me.no_auction_limitsCheckBox.AutoSize = True
        Me.no_auction_limitsCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.no_auction_limits
        Me.no_auction_limitsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "no_auction_limits", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.no_auction_limitsCheckBox.Location = New System.Drawing.Point(12, 37)
        Me.no_auction_limitsCheckBox.Name = "no_auction_limitsCheckBox"
        Me.no_auction_limitsCheckBox.Size = New System.Drawing.Size(146, 17)
        Me.no_auction_limitsCheckBox.TabIndex = 9
        Me.no_auction_limitsCheckBox.Text = "Unlimited AH submissions"
        Me.no_auction_limitsCheckBox.UseVisualStyleBackColor = True
        '
        'expire_intervalNumericUpDown
        '
        Me.expire_intervalNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "expire_interval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.expire_intervalNumericUpDown.Location = New System.Drawing.Point(12, 86)
        Me.expire_intervalNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.expire_intervalNumericUpDown.Name = "expire_intervalNumericUpDown"
        Me.expire_intervalNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.expire_intervalNumericUpDown.TabIndex = 8
        Me.expire_intervalNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.expire_interval
        '
        'expire_daysNumericUpDown
        '
        Me.expire_daysNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "expire_days", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.expire_daysNumericUpDown.Location = New System.Drawing.Point(12, 60)
        Me.expire_daysNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.expire_daysNumericUpDown.Name = "expire_daysNumericUpDown"
        Me.expire_daysNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.expire_daysNumericUpDown.TabIndex = 7
        Me.expire_daysNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.expire_days
        '
        'expire_auctionsCheckBox
        '
        Me.expire_auctionsCheckBox.AutoSize = True
        Me.expire_auctionsCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.expire_auctions
        Me.expire_auctionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.expire_auctionsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "expire_auctions", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.expire_auctionsCheckBox.Location = New System.Drawing.Point(12, 13)
        Me.expire_auctionsCheckBox.Name = "expire_auctionsCheckBox"
        Me.expire_auctionsCheckBox.Size = New System.Drawing.Size(117, 17)
        Me.expire_auctionsCheckBox.TabIndex = 0
        Me.expire_auctionsCheckBox.Text = "Let Auctions Expire"
        Me.expire_auctionsCheckBox.UseVisualStyleBackColor = True
        '
        'ConfigFormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 147)
        Me.Controls.Add(Me.no_auction_limitsCheckBox)
        Me.Controls.Add(Me.expire_intervalNumericUpDown)
        Me.Controls.Add(Me.expire_daysNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Controls.Add(Me.expire_intervalLabel)
        Me.Controls.Add(Me.expire_daysLabel)
        Me.Controls.Add(Me.expire_auctionsCheckBox)
        Me.Name = "ConfigFormSearch"
        Me.Text = "Search Conf editor"
        CType(Me.expire_intervalNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expire_daysNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents expire_auctionsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents expire_daysLabel As System.Windows.Forms.Label
    Friend WithEvents expire_intervalLabel As System.Windows.Forms.Label
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents expire_daysNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents expire_intervalNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents no_auction_limitsCheckBox As System.Windows.Forms.CheckBox
End Class
