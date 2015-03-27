<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialCollectingsettings
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
        Me.HARVESTING_BREAK_CHANCENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HARVESTING_BREAK_CHANCELabel = New System.Windows.Forms.Label()
        Me.EXCAVATION_BREAK_CHANCELabel = New System.Windows.Forms.Label()
        Me.EXCAVATION_BREAK_CHANCENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LOGGING_BREAK_CHANCELabel = New System.Windows.Forms.Label()
        Me.LOGGING_BREAK_CHANCENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MINING_BREAK_CHANCELabel = New System.Windows.Forms.Label()
        Me.MINING_BREAK_CHANCENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HARVESTING_RATELabel = New System.Windows.Forms.Label()
        Me.HARVESTING_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.EXCAVATION_RATELabel = New System.Windows.Forms.Label()
        Me.EXCAVATION_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LOGGING_RATELabel = New System.Windows.Forms.Label()
        Me.MINING_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MINING_RATELabel = New System.Windows.Forms.Label()
        Me.LOGGING_RATENumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.HARVESTING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXCAVATION_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGGING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HARVESTING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXCAVATION_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGGING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(80, 221)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(127, 23)
        Me.ApplySettingsButton.TabIndex = 45
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'HARVESTING_BREAK_CHANCENumericUpDown
        '
        Me.HARVESTING_BREAK_CHANCENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "HARVESTING_BREAK_CHANCE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HARVESTING_BREAK_CHANCENumericUpDown.DecimalPlaces = 2
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Name = "HARVESTING_BREAK_CHANCENumericUpDown"
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.HARVESTING_BREAK_CHANCENumericUpDown.TabIndex = 46
        Me.HARVESTING_BREAK_CHANCENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.HARVESTING_BREAK_CHANCE
        '
        'HARVESTING_BREAK_CHANCELabel
        '
        Me.HARVESTING_BREAK_CHANCELabel.AutoSize = True
        Me.HARVESTING_BREAK_CHANCELabel.Location = New System.Drawing.Point(119, 15)
        Me.HARVESTING_BREAK_CHANCELabel.Name = "HARVESTING_BREAK_CHANCELabel"
        Me.HARVESTING_BREAK_CHANCELabel.Size = New System.Drawing.Size(115, 13)
        Me.HARVESTING_BREAK_CHANCELabel.TabIndex = 47
        Me.HARVESTING_BREAK_CHANCELabel.Text = "Harvest Break Chance"
        '
        'EXCAVATION_BREAK_CHANCELabel
        '
        Me.EXCAVATION_BREAK_CHANCELabel.AutoSize = True
        Me.EXCAVATION_BREAK_CHANCELabel.Location = New System.Drawing.Point(119, 41)
        Me.EXCAVATION_BREAK_CHANCELabel.Name = "EXCAVATION_BREAK_CHANCELabel"
        Me.EXCAVATION_BREAK_CHANCELabel.Size = New System.Drawing.Size(131, 13)
        Me.EXCAVATION_BREAK_CHANCELabel.TabIndex = 49
        Me.EXCAVATION_BREAK_CHANCELabel.Text = "Excavation Break Chance"
        '
        'EXCAVATION_BREAK_CHANCENumericUpDown
        '
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "EXCAVATION_BREAK_CHANCE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.DecimalPlaces = 2
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Location = New System.Drawing.Point(13, 39)
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Name = "EXCAVATION_BREAK_CHANCENumericUpDown"
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.TabIndex = 48
        Me.EXCAVATION_BREAK_CHANCENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.EXCAVATION_BREAK_CHANCE
        '
        'LOGGING_BREAK_CHANCELabel
        '
        Me.LOGGING_BREAK_CHANCELabel.AutoSize = True
        Me.LOGGING_BREAK_CHANCELabel.Location = New System.Drawing.Point(119, 67)
        Me.LOGGING_BREAK_CHANCELabel.Name = "LOGGING_BREAK_CHANCELabel"
        Me.LOGGING_BREAK_CHANCELabel.Size = New System.Drawing.Size(116, 13)
        Me.LOGGING_BREAK_CHANCELabel.TabIndex = 51
        Me.LOGGING_BREAK_CHANCELabel.Text = "Logging Break Chance"
        '
        'LOGGING_BREAK_CHANCENumericUpDown
        '
        Me.LOGGING_BREAK_CHANCENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "LOGGING_BREAK_CHANCE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LOGGING_BREAK_CHANCENumericUpDown.DecimalPlaces = 2
        Me.LOGGING_BREAK_CHANCENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.LOGGING_BREAK_CHANCENumericUpDown.Location = New System.Drawing.Point(13, 65)
        Me.LOGGING_BREAK_CHANCENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LOGGING_BREAK_CHANCENumericUpDown.Name = "LOGGING_BREAK_CHANCENumericUpDown"
        Me.LOGGING_BREAK_CHANCENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.LOGGING_BREAK_CHANCENumericUpDown.TabIndex = 50
        Me.LOGGING_BREAK_CHANCENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.LOGGING_BREAK_CHANCE
        '
        'MINING_BREAK_CHANCELabel
        '
        Me.MINING_BREAK_CHANCELabel.AutoSize = True
        Me.MINING_BREAK_CHANCELabel.Location = New System.Drawing.Point(119, 93)
        Me.MINING_BREAK_CHANCELabel.Name = "MINING_BREAK_CHANCELabel"
        Me.MINING_BREAK_CHANCELabel.Size = New System.Drawing.Size(109, 13)
        Me.MINING_BREAK_CHANCELabel.TabIndex = 53
        Me.MINING_BREAK_CHANCELabel.Text = "Mining Break Chance"
        '
        'MINING_BREAK_CHANCENumericUpDown
        '
        Me.MINING_BREAK_CHANCENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "MINING_BREAK_CHANCE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MINING_BREAK_CHANCENumericUpDown.DecimalPlaces = 2
        Me.MINING_BREAK_CHANCENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.MINING_BREAK_CHANCENumericUpDown.Location = New System.Drawing.Point(13, 91)
        Me.MINING_BREAK_CHANCENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MINING_BREAK_CHANCENumericUpDown.Name = "MINING_BREAK_CHANCENumericUpDown"
        Me.MINING_BREAK_CHANCENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.MINING_BREAK_CHANCENumericUpDown.TabIndex = 52
        Me.MINING_BREAK_CHANCENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.MINING_BREAK_CHANCE
        '
        'HARVESTING_RATELabel
        '
        Me.HARVESTING_RATELabel.AutoSize = True
        Me.HARVESTING_RATELabel.Location = New System.Drawing.Point(119, 119)
        Me.HARVESTING_RATELabel.Name = "HARVESTING_RATELabel"
        Me.HARVESTING_RATELabel.Size = New System.Drawing.Size(79, 13)
        Me.HARVESTING_RATELabel.TabIndex = 55
        Me.HARVESTING_RATELabel.Text = "Harvesting rate"
        '
        'HARVESTING_RATENumericUpDown
        '
        Me.HARVESTING_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "HARVESTING_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HARVESTING_RATENumericUpDown.DecimalPlaces = 2
        Me.HARVESTING_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.HARVESTING_RATENumericUpDown.Location = New System.Drawing.Point(13, 117)
        Me.HARVESTING_RATENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HARVESTING_RATENumericUpDown.Name = "HARVESTING_RATENumericUpDown"
        Me.HARVESTING_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.HARVESTING_RATENumericUpDown.TabIndex = 54
        Me.HARVESTING_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.HARVESTING_RATE
        '
        'EXCAVATION_RATELabel
        '
        Me.EXCAVATION_RATELabel.AutoSize = True
        Me.EXCAVATION_RATELabel.Location = New System.Drawing.Point(119, 145)
        Me.EXCAVATION_RATELabel.Name = "EXCAVATION_RATELabel"
        Me.EXCAVATION_RATELabel.Size = New System.Drawing.Size(81, 13)
        Me.EXCAVATION_RATELabel.TabIndex = 57
        Me.EXCAVATION_RATELabel.Text = "Excavation rate"
        '
        'EXCAVATION_RATENumericUpDown
        '
        Me.EXCAVATION_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "EXCAVATION_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXCAVATION_RATENumericUpDown.DecimalPlaces = 2
        Me.EXCAVATION_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.EXCAVATION_RATENumericUpDown.Location = New System.Drawing.Point(13, 143)
        Me.EXCAVATION_RATENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EXCAVATION_RATENumericUpDown.Name = "EXCAVATION_RATENumericUpDown"
        Me.EXCAVATION_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.EXCAVATION_RATENumericUpDown.TabIndex = 56
        Me.EXCAVATION_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.EXCAVATION_RATE
        '
        'LOGGING_RATELabel
        '
        Me.LOGGING_RATELabel.AutoSize = True
        Me.LOGGING_RATELabel.Location = New System.Drawing.Point(119, 171)
        Me.LOGGING_RATELabel.Name = "LOGGING_RATELabel"
        Me.LOGGING_RATELabel.Size = New System.Drawing.Size(66, 13)
        Me.LOGGING_RATELabel.TabIndex = 59
        Me.LOGGING_RATELabel.Text = "Logging rate"
        '
        'MINING_RATENumericUpDown
        '
        Me.MINING_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "MINING_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MINING_RATENumericUpDown.DecimalPlaces = 2
        Me.MINING_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.MINING_RATENumericUpDown.Location = New System.Drawing.Point(13, 195)
        Me.MINING_RATENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MINING_RATENumericUpDown.Name = "MINING_RATENumericUpDown"
        Me.MINING_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.MINING_RATENumericUpDown.TabIndex = 58
        Me.MINING_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.MINING_RATE
        '
        'MINING_RATELabel
        '
        Me.MINING_RATELabel.AutoSize = True
        Me.MINING_RATELabel.Location = New System.Drawing.Point(119, 197)
        Me.MINING_RATELabel.Name = "MINING_RATELabel"
        Me.MINING_RATELabel.Size = New System.Drawing.Size(59, 13)
        Me.MINING_RATELabel.TabIndex = 61
        Me.MINING_RATELabel.Text = "Mining rate"
        '
        'LOGGING_RATENumericUpDown
        '
        Me.LOGGING_RATENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "LOGGING_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LOGGING_RATENumericUpDown.DecimalPlaces = 2
        Me.LOGGING_RATENumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.LOGGING_RATENumericUpDown.Location = New System.Drawing.Point(13, 169)
        Me.LOGGING_RATENumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LOGGING_RATENumericUpDown.Name = "LOGGING_RATENumericUpDown"
        Me.LOGGING_RATENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.LOGGING_RATENumericUpDown.TabIndex = 60
        Me.LOGGING_RATENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.LOGGING_RATE
        '
        'MaterialCollectingsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MINING_RATELabel)
        Me.Controls.Add(Me.LOGGING_RATENumericUpDown)
        Me.Controls.Add(Me.LOGGING_RATELabel)
        Me.Controls.Add(Me.MINING_RATENumericUpDown)
        Me.Controls.Add(Me.EXCAVATION_RATELabel)
        Me.Controls.Add(Me.EXCAVATION_RATENumericUpDown)
        Me.Controls.Add(Me.HARVESTING_RATELabel)
        Me.Controls.Add(Me.HARVESTING_RATENumericUpDown)
        Me.Controls.Add(Me.MINING_BREAK_CHANCELabel)
        Me.Controls.Add(Me.MINING_BREAK_CHANCENumericUpDown)
        Me.Controls.Add(Me.LOGGING_BREAK_CHANCELabel)
        Me.Controls.Add(Me.LOGGING_BREAK_CHANCENumericUpDown)
        Me.Controls.Add(Me.EXCAVATION_BREAK_CHANCELabel)
        Me.Controls.Add(Me.EXCAVATION_BREAK_CHANCENumericUpDown)
        Me.Controls.Add(Me.HARVESTING_BREAK_CHANCELabel)
        Me.Controls.Add(Me.HARVESTING_BREAK_CHANCENumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "MaterialCollectingsettings"
        Me.Text = "Material Collecting settings"
        CType(Me.HARVESTING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXCAVATION_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGGING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINING_BREAK_CHANCENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HARVESTING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXCAVATION_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGGING_RATENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents HARVESTING_BREAK_CHANCENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HARVESTING_BREAK_CHANCELabel As System.Windows.Forms.Label
    Friend WithEvents EXCAVATION_BREAK_CHANCELabel As System.Windows.Forms.Label
    Friend WithEvents EXCAVATION_BREAK_CHANCENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LOGGING_BREAK_CHANCELabel As System.Windows.Forms.Label
    Friend WithEvents LOGGING_BREAK_CHANCENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MINING_BREAK_CHANCELabel As System.Windows.Forms.Label
    Friend WithEvents MINING_BREAK_CHANCENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HARVESTING_RATELabel As System.Windows.Forms.Label
    Friend WithEvents HARVESTING_RATENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents EXCAVATION_RATELabel As System.Windows.Forms.Label
    Friend WithEvents EXCAVATION_RATENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LOGGING_RATELabel As System.Windows.Forms.Label
    Friend WithEvents MINING_RATENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MINING_RATELabel As System.Windows.Forms.Label
    Friend WithEvents LOGGING_RATENumericUpDown As System.Windows.Forms.NumericUpDown
End Class
