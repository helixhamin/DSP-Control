<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuildPointssetting
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
        Me.FISHING_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.COOKING_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ALCHEMY_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BONECRAFT_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SMITHING_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WOODWORKING_GUILD_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DISABLE_GUILD_CONTRACTSCheckBox = New System.Windows.Forms.CheckBox()
        Me.FISHING_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.WOODWORKING_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.SMITHING_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.GOLDSMITHING_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.CLOTHCRAFT_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.LEATHERCRAFT_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.BONECRAFT_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.COOKING_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        Me.ALCHEMY_GUILD_POINTSLabel = New System.Windows.Forms.Label()
        CType(Me.FISHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COOKING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALCHEMY_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BONECRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GOLDSMITHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMITHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WOODWORKING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(64, 269)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(127, 23)
        Me.ApplySettingsButton.TabIndex = 45
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'FISHING_GUILD_POINTSNumericUpDown
        '
        Me.FISHING_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "FISHING_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FISHING_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.FISHING_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.FISHING_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 12)
        Me.FISHING_GUILD_POINTSNumericUpDown.Name = "FISHING_GUILD_POINTSNumericUpDown"
        Me.FISHING_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.FISHING_GUILD_POINTSNumericUpDown.TabIndex = 46
        Me.FISHING_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.FISHING_GUILD_POINTS
        '
        'COOKING_GUILD_POINTSNumericUpDown
        '
        Me.COOKING_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "COOKING_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.COOKING_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.COOKING_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.COOKING_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 220)
        Me.COOKING_GUILD_POINTSNumericUpDown.Name = "COOKING_GUILD_POINTSNumericUpDown"
        Me.COOKING_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.COOKING_GUILD_POINTSNumericUpDown.TabIndex = 47
        Me.COOKING_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.COOKING_GUILD_POINTS
        '
        'ALCHEMY_GUILD_POINTSNumericUpDown
        '
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "ALCHEMY_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 194)
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.Name = "ALCHEMY_GUILD_POINTSNumericUpDown"
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.TabIndex = 48
        Me.ALCHEMY_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.ALCHEMY_GUILD_POINTS
        '
        'BONECRAFT_GUILD_POINTSNumericUpDown
        '
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "BONECRAFT_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 168)
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.Name = "BONECRAFT_GUILD_POINTSNumericUpDown"
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.TabIndex = 49
        Me.BONECRAFT_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.BONECRAFT_GUILD_POINTS
        '
        'LEATHERCRAFT_GUILD_POINTSNumericUpDown
        '
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "LEATHERCRAFT_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 142)
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.Name = "LEATHERCRAFT_GUILD_POINTSNumericUpDown"
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.TabIndex = 50
        Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.LEATHERCRAFT_GUILD_POINTS
        '
        'CLOTHCRAFT_GUILD_POINTSNumericUpDown
        '
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CLOTHCRAFT_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 116)
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.Name = "CLOTHCRAFT_GUILD_POINTSNumericUpDown"
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.TabIndex = 51
        Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CLOTHCRAFT_GUILD_POINTS
        '
        'GOLDSMITHING_GUILD_POINTSNumericUpDown
        '
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "GOLDSMITHING_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 90)
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.Name = "GOLDSMITHING_GUILD_POINTSNumericUpDown"
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.TabIndex = 52
        Me.GOLDSMITHING_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.GOLDSMITHING_GUILD_POINTS
        '
        'SMITHING_GUILD_POINTSNumericUpDown
        '
        Me.SMITHING_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "SMITHING_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SMITHING_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.SMITHING_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.SMITHING_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 64)
        Me.SMITHING_GUILD_POINTSNumericUpDown.Name = "SMITHING_GUILD_POINTSNumericUpDown"
        Me.SMITHING_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.SMITHING_GUILD_POINTSNumericUpDown.TabIndex = 53
        Me.SMITHING_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.SMITHING_GUILD_POINTS
        '
        'WOODWORKING_GUILD_POINTSNumericUpDown
        '
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WOODWORKING_GUILD_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.DecimalPlaces = 3
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.Location = New System.Drawing.Point(13, 38)
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.Name = "WOODWORKING_GUILD_POINTSNumericUpDown"
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.TabIndex = 54
        Me.WOODWORKING_GUILD_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WOODWORKING_GUILD_POINTS
        '
        'DISABLE_GUILD_CONTRACTSCheckBox
        '
        Me.DISABLE_GUILD_CONTRACTSCheckBox.AutoSize = True
        Me.DISABLE_GUILD_CONTRACTSCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.DISABLE_GUILD_CONTRACTS
        Me.DISABLE_GUILD_CONTRACTSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "DISABLE_GUILD_CONTRACTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DISABLE_GUILD_CONTRACTSCheckBox.Location = New System.Drawing.Point(13, 246)
        Me.DISABLE_GUILD_CONTRACTSCheckBox.Name = "DISABLE_GUILD_CONTRACTSCheckBox"
        Me.DISABLE_GUILD_CONTRACTSCheckBox.Size = New System.Drawing.Size(136, 17)
        Me.DISABLE_GUILD_CONTRACTSCheckBox.TabIndex = 55
        Me.DISABLE_GUILD_CONTRACTSCheckBox.Text = "Disable Guild Contracts"
        Me.DISABLE_GUILD_CONTRACTSCheckBox.UseVisualStyleBackColor = True
        '
        'FISHING_GUILD_POINTSLabel
        '
        Me.FISHING_GUILD_POINTSLabel.AutoSize = True
        Me.FISHING_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 14)
        Me.FISHING_GUILD_POINTSLabel.Name = "FISHING_GUILD_POINTSLabel"
        Me.FISHING_GUILD_POINTSLabel.Size = New System.Drawing.Size(139, 13)
        Me.FISHING_GUILD_POINTSLabel.TabIndex = 56
        Me.FISHING_GUILD_POINTSLabel.Text = "Fishing guild points multiplier"
        '
        'WOODWORKING_GUILD_POINTSLabel
        '
        Me.WOODWORKING_GUILD_POINTSLabel.AutoSize = True
        Me.WOODWORKING_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 40)
        Me.WOODWORKING_GUILD_POINTSLabel.Name = "WOODWORKING_GUILD_POINTSLabel"
        Me.WOODWORKING_GUILD_POINTSLabel.Size = New System.Drawing.Size(172, 13)
        Me.WOODWORKING_GUILD_POINTSLabel.TabIndex = 57
        Me.WOODWORKING_GUILD_POINTSLabel.Text = "Woodworking guild points multiplier"
        '
        'SMITHING_GUILD_POINTSLabel
        '
        Me.SMITHING_GUILD_POINTSLabel.AutoSize = True
        Me.SMITHING_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 66)
        Me.SMITHING_GUILD_POINTSLabel.Name = "SMITHING_GUILD_POINTSLabel"
        Me.SMITHING_GUILD_POINTSLabel.Size = New System.Drawing.Size(146, 13)
        Me.SMITHING_GUILD_POINTSLabel.TabIndex = 58
        Me.SMITHING_GUILD_POINTSLabel.Text = "Smithing guild points multiplier"
        '
        'GOLDSMITHING_GUILD_POINTSLabel
        '
        Me.GOLDSMITHING_GUILD_POINTSLabel.AutoSize = True
        Me.GOLDSMITHING_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 92)
        Me.GOLDSMITHING_GUILD_POINTSLabel.Name = "GOLDSMITHING_GUILD_POINTSLabel"
        Me.GOLDSMITHING_GUILD_POINTSLabel.Size = New System.Drawing.Size(166, 13)
        Me.GOLDSMITHING_GUILD_POINTSLabel.TabIndex = 59
        Me.GOLDSMITHING_GUILD_POINTSLabel.Text = "Goldsmithing guild points multiplier"
        '
        'CLOTHCRAFT_GUILD_POINTSLabel
        '
        Me.CLOTHCRAFT_GUILD_POINTSLabel.AutoSize = True
        Me.CLOTHCRAFT_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 118)
        Me.CLOTHCRAFT_GUILD_POINTSLabel.Name = "CLOTHCRAFT_GUILD_POINTSLabel"
        Me.CLOTHCRAFT_GUILD_POINTSLabel.Size = New System.Drawing.Size(151, 13)
        Me.CLOTHCRAFT_GUILD_POINTSLabel.TabIndex = 60
        Me.CLOTHCRAFT_GUILD_POINTSLabel.Text = "Clothcraft guild points multiplier"
        '
        'LEATHERCRAFT_GUILD_POINTSLabel
        '
        Me.LEATHERCRAFT_GUILD_POINTSLabel.AutoSize = True
        Me.LEATHERCRAFT_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 144)
        Me.LEATHERCRAFT_GUILD_POINTSLabel.Name = "LEATHERCRAFT_GUILD_POINTSLabel"
        Me.LEATHERCRAFT_GUILD_POINTSLabel.Size = New System.Drawing.Size(163, 13)
        Me.LEATHERCRAFT_GUILD_POINTSLabel.TabIndex = 61
        Me.LEATHERCRAFT_GUILD_POINTSLabel.Text = "Leathercraft guild points multiplier"
        '
        'BONECRAFT_GUILD_POINTSLabel
        '
        Me.BONECRAFT_GUILD_POINTSLabel.AutoSize = True
        Me.BONECRAFT_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 170)
        Me.BONECRAFT_GUILD_POINTSLabel.Name = "BONECRAFT_GUILD_POINTSLabel"
        Me.BONECRAFT_GUILD_POINTSLabel.Size = New System.Drawing.Size(152, 13)
        Me.BONECRAFT_GUILD_POINTSLabel.TabIndex = 62
        Me.BONECRAFT_GUILD_POINTSLabel.Text = "Bonecraft guild points multiplier"
        '
        'COOKING_GUILD_POINTSLabel
        '
        Me.COOKING_GUILD_POINTSLabel.AutoSize = True
        Me.COOKING_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 222)
        Me.COOKING_GUILD_POINTSLabel.Name = "COOKING_GUILD_POINTSLabel"
        Me.COOKING_GUILD_POINTSLabel.Size = New System.Drawing.Size(145, 13)
        Me.COOKING_GUILD_POINTSLabel.TabIndex = 63
        Me.COOKING_GUILD_POINTSLabel.Text = "Cooking guild points multiplier"
        '
        'ALCHEMY_GUILD_POINTSLabel
        '
        Me.ALCHEMY_GUILD_POINTSLabel.AutoSize = True
        Me.ALCHEMY_GUILD_POINTSLabel.Location = New System.Drawing.Point(118, 196)
        Me.ALCHEMY_GUILD_POINTSLabel.Name = "ALCHEMY_GUILD_POINTSLabel"
        Me.ALCHEMY_GUILD_POINTSLabel.Size = New System.Drawing.Size(146, 13)
        Me.ALCHEMY_GUILD_POINTSLabel.TabIndex = 64
        Me.ALCHEMY_GUILD_POINTSLabel.Text = "Alchemy guild points multiplier"
        '
        'GuildPointssetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 303)
        Me.Controls.Add(Me.ALCHEMY_GUILD_POINTSLabel)
        Me.Controls.Add(Me.COOKING_GUILD_POINTSLabel)
        Me.Controls.Add(Me.BONECRAFT_GUILD_POINTSLabel)
        Me.Controls.Add(Me.LEATHERCRAFT_GUILD_POINTSLabel)
        Me.Controls.Add(Me.CLOTHCRAFT_GUILD_POINTSLabel)
        Me.Controls.Add(Me.GOLDSMITHING_GUILD_POINTSLabel)
        Me.Controls.Add(Me.SMITHING_GUILD_POINTSLabel)
        Me.Controls.Add(Me.WOODWORKING_GUILD_POINTSLabel)
        Me.Controls.Add(Me.FISHING_GUILD_POINTSLabel)
        Me.Controls.Add(Me.DISABLE_GUILD_CONTRACTSCheckBox)
        Me.Controls.Add(Me.WOODWORKING_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.SMITHING_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.GOLDSMITHING_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.BONECRAFT_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.ALCHEMY_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.COOKING_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.FISHING_GUILD_POINTSNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "GuildPointssetting"
        Me.Text = "Guild Points"
        CType(Me.FISHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COOKING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALCHEMY_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BONECRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEATHERCRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLOTHCRAFT_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GOLDSMITHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMITHING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WOODWORKING_GUILD_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents FISHING_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents COOKING_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ALCHEMY_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BONECRAFT_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LEATHERCRAFT_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CLOTHCRAFT_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GOLDSMITHING_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SMITHING_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WOODWORKING_GUILD_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DISABLE_GUILD_CONTRACTSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FISHING_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents WOODWORKING_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents SMITHING_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents GOLDSMITHING_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents CLOTHCRAFT_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents LEATHERCRAFT_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents BONECRAFT_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents COOKING_GUILD_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents ALCHEMY_GUILD_POINTSLabel As System.Windows.Forms.Label
End Class
