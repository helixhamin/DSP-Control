<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FameGainMultipliers
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
        Me.SAN_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SAN_FAMELabel = New System.Windows.Forms.Label()
        Me.JEUNO_FAMELabel = New System.Windows.Forms.Label()
        Me.JEUNO_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NORG_FAMELabel = New System.Windows.Forms.Label()
        Me.NORG_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WIN_FAMELabel = New System.Windows.Forms.Label()
        Me.WIN_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BAS_FAMELabel = New System.Windows.Forms.Label()
        Me.BAS_FAMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.SAN_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JEUNO_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NORG_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAS_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(128, 147)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'SAN_FAMENumericUpDown
        '
        Me.SAN_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "SAN_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SAN_FAMENumericUpDown.DecimalPlaces = 3
        Me.SAN_FAMENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.SAN_FAMENumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.SAN_FAMENumericUpDown.Name = "SAN_FAMENumericUpDown"
        Me.SAN_FAMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.SAN_FAMENumericUpDown.TabIndex = 57
        Me.SAN_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.SAN_FAME
        '
        'SAN_FAMELabel
        '
        Me.SAN_FAMELabel.AutoSize = True
        Me.SAN_FAMELabel.Location = New System.Drawing.Point(119, 15)
        Me.SAN_FAMELabel.Name = "SAN_FAMELabel"
        Me.SAN_FAMELabel.Size = New System.Drawing.Size(221, 13)
        Me.SAN_FAMELabel.TabIndex = 58
        Me.SAN_FAMELabel.Text = "Multiplies fame earned from San d'Oria quests"
        '
        'JEUNO_FAMELabel
        '
        Me.JEUNO_FAMELabel.AutoSize = True
        Me.JEUNO_FAMELabel.Location = New System.Drawing.Point(119, 123)
        Me.JEUNO_FAMELabel.Name = "JEUNO_FAMELabel"
        Me.JEUNO_FAMELabel.Size = New System.Drawing.Size(201, 13)
        Me.JEUNO_FAMELabel.TabIndex = 60
        Me.JEUNO_FAMELabel.Text = "Multiplies fame earned from Jeuno quests"
        '
        'JEUNO_FAMENumericUpDown
        '
        Me.JEUNO_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "JEUNO_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.JEUNO_FAMENumericUpDown.DecimalPlaces = 3
        Me.JEUNO_FAMENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.JEUNO_FAMENumericUpDown.Location = New System.Drawing.Point(13, 121)
        Me.JEUNO_FAMENumericUpDown.Name = "JEUNO_FAMENumericUpDown"
        Me.JEUNO_FAMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.JEUNO_FAMENumericUpDown.TabIndex = 59
        Me.JEUNO_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.JEUNO_FAME
        '
        'NORG_FAMELabel
        '
        Me.NORG_FAMELabel.AutoSize = True
        Me.NORG_FAMELabel.Location = New System.Drawing.Point(119, 96)
        Me.NORG_FAMELabel.Name = "NORG_FAMELabel"
        Me.NORG_FAMELabel.Size = New System.Drawing.Size(267, 13)
        Me.NORG_FAMELabel.TabIndex = 62
        Me.NORG_FAMELabel.Text = "Multiplies fame earned from Norg and Tenshodo quests"
        '
        'NORG_FAMENumericUpDown
        '
        Me.NORG_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "NORG_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NORG_FAMENumericUpDown.DecimalPlaces = 3
        Me.NORG_FAMENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.NORG_FAMENumericUpDown.Location = New System.Drawing.Point(13, 94)
        Me.NORG_FAMENumericUpDown.Name = "NORG_FAMENumericUpDown"
        Me.NORG_FAMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.NORG_FAMENumericUpDown.TabIndex = 61
        Me.NORG_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.NORG_FAME
        '
        'WIN_FAMELabel
        '
        Me.WIN_FAMELabel.AutoSize = True
        Me.WIN_FAMELabel.Location = New System.Drawing.Point(119, 69)
        Me.WIN_FAMELabel.Name = "WIN_FAMELabel"
        Me.WIN_FAMELabel.Size = New System.Drawing.Size(214, 13)
        Me.WIN_FAMELabel.TabIndex = 64
        Me.WIN_FAMELabel.Text = "Multiplies fame earned from Windurst quests"
        '
        'WIN_FAMENumericUpDown
        '
        Me.WIN_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WIN_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WIN_FAMENumericUpDown.DecimalPlaces = 3
        Me.WIN_FAMENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.WIN_FAMENumericUpDown.Location = New System.Drawing.Point(13, 67)
        Me.WIN_FAMENumericUpDown.Name = "WIN_FAMENumericUpDown"
        Me.WIN_FAMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.WIN_FAMENumericUpDown.TabIndex = 63
        Me.WIN_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WIN_FAME
        '
        'BAS_FAMELabel
        '
        Me.BAS_FAMELabel.AutoSize = True
        Me.BAS_FAMELabel.Location = New System.Drawing.Point(119, 42)
        Me.BAS_FAMELabel.Name = "BAS_FAMELabel"
        Me.BAS_FAMELabel.Size = New System.Drawing.Size(205, 13)
        Me.BAS_FAMELabel.TabIndex = 66
        Me.BAS_FAMELabel.Text = "Multiplies fame earned from Bastok quests"
        '
        'BAS_FAMENumericUpDown
        '
        Me.BAS_FAMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "BAS_FAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BAS_FAMENumericUpDown.DecimalPlaces = 3
        Me.BAS_FAMENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.BAS_FAMENumericUpDown.Location = New System.Drawing.Point(13, 40)
        Me.BAS_FAMENumericUpDown.Name = "BAS_FAMENumericUpDown"
        Me.BAS_FAMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.BAS_FAMENumericUpDown.TabIndex = 65
        Me.BAS_FAMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.BAS_FAME
        '
        'FameGainMultipliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 186)
        Me.Controls.Add(Me.BAS_FAMELabel)
        Me.Controls.Add(Me.BAS_FAMENumericUpDown)
        Me.Controls.Add(Me.WIN_FAMELabel)
        Me.Controls.Add(Me.WIN_FAMENumericUpDown)
        Me.Controls.Add(Me.NORG_FAMELabel)
        Me.Controls.Add(Me.NORG_FAMENumericUpDown)
        Me.Controls.Add(Me.JEUNO_FAMELabel)
        Me.Controls.Add(Me.JEUNO_FAMENumericUpDown)
        Me.Controls.Add(Me.SAN_FAMELabel)
        Me.Controls.Add(Me.SAN_FAMENumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "FameGainMultipliers"
        Me.Text = "Fame Gain Multipliers"
        CType(Me.SAN_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JEUNO_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NORG_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAS_FAMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents SAN_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SAN_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents JEUNO_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents JEUNO_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NORG_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents NORG_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WIN_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents WIN_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BAS_FAMELabel As System.Windows.Forms.Label
    Friend WithEvents BAS_FAMENumericUpDown As System.Windows.Forms.NumericUpDown
End Class
