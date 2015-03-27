<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spell_WeaponPower
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
        Me.CURE_POWERLabel = New System.Windows.Forms.Label()
        Me.CURE_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SPELL_POWERLabel = New System.Windows.Forms.Label()
        Me.SPELL_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BLUE_POWERLabel = New System.Windows.Forms.Label()
        Me.BLUE_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DRAIN_POWERLabel = New System.Windows.Forms.Label()
        Me.DRAIN_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ITEM_POWERLabel = New System.Windows.Forms.Label()
        Me.ITEM_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WEAPON_SKILL_POWERLabel = New System.Windows.Forms.Label()
        Me.WEAPON_SKILL_POWERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WEAPON_SKILL_POINTSLabel = New System.Windows.Forms.Label()
        Me.WEAPON_SKILL_POINTSNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.CURE_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPELL_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BLUE_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRAIN_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITEM_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WEAPON_SKILL_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WEAPON_SKILL_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(185, 194)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'CURE_POWERLabel
        '
        Me.CURE_POWERLabel.AutoSize = True
        Me.CURE_POWERLabel.Location = New System.Drawing.Point(118, 14)
        Me.CURE_POWERLabel.Name = "CURE_POWERLabel"
        Me.CURE_POWERLabel.Size = New System.Drawing.Size(380, 13)
        Me.CURE_POWERLabel.TabIndex = 60
        Me.CURE_POWERLabel.Text = "Multiplies amount healed from Healing Magic, including the relevant Blue Magic"
        '
        'CURE_POWERNumericUpDown
        '
        Me.CURE_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CURE_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CURE_POWERNumericUpDown.DecimalPlaces = 3
        Me.CURE_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.CURE_POWERNumericUpDown.Location = New System.Drawing.Point(12, 12)
        Me.CURE_POWERNumericUpDown.Name = "CURE_POWERNumericUpDown"
        Me.CURE_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.CURE_POWERNumericUpDown.TabIndex = 59
        Me.CURE_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CURE_POWER
        '
        'SPELL_POWERLabel
        '
        Me.SPELL_POWERLabel.AutoSize = True
        Me.SPELL_POWERLabel.Location = New System.Drawing.Point(118, 40)
        Me.SPELL_POWERLabel.Name = "SPELL_POWERLabel"
        Me.SPELL_POWERLabel.Size = New System.Drawing.Size(266, 13)
        Me.SPELL_POWERLabel.TabIndex = 62
        Me.SPELL_POWERLabel.Text = "Multiplies damage dealt by Elemental and Divine Magic"
        '
        'SPELL_POWERNumericUpDown
        '
        Me.SPELL_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "SPELL_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SPELL_POWERNumericUpDown.DecimalPlaces = 3
        Me.SPELL_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.SPELL_POWERNumericUpDown.Location = New System.Drawing.Point(12, 38)
        Me.SPELL_POWERNumericUpDown.Name = "SPELL_POWERNumericUpDown"
        Me.SPELL_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.SPELL_POWERNumericUpDown.TabIndex = 61
        Me.SPELL_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.SPELL_POWER
        '
        'BLUE_POWERLabel
        '
        Me.BLUE_POWERLabel.AutoSize = True
        Me.BLUE_POWERLabel.Location = New System.Drawing.Point(118, 66)
        Me.BLUE_POWERLabel.Name = "BLUE_POWERLabel"
        Me.BLUE_POWERLabel.Size = New System.Drawing.Size(212, 13)
        Me.BLUE_POWERLabel.TabIndex = 64
        Me.BLUE_POWERLabel.Text = "Multiplies damage dealt by most Blue Magic"
        '
        'BLUE_POWERNumericUpDown
        '
        Me.BLUE_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "BLUE_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BLUE_POWERNumericUpDown.DecimalPlaces = 3
        Me.BLUE_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.BLUE_POWERNumericUpDown.Location = New System.Drawing.Point(12, 64)
        Me.BLUE_POWERNumericUpDown.Name = "BLUE_POWERNumericUpDown"
        Me.BLUE_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.BLUE_POWERNumericUpDown.TabIndex = 63
        Me.BLUE_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.BLUE_POWER
        '
        'DRAIN_POWERLabel
        '
        Me.DRAIN_POWERLabel.AutoSize = True
        Me.DRAIN_POWERLabel.Location = New System.Drawing.Point(118, 92)
        Me.DRAIN_POWERLabel.Name = "DRAIN_POWERLabel"
        Me.DRAIN_POWERLabel.Size = New System.Drawing.Size(347, 13)
        Me.DRAIN_POWERLabel.TabIndex = 66
        Me.DRAIN_POWERLabel.Text = "Multiplies amount drained by Drain, Aspir, and relevant Blue Magic spells"
        '
        'DRAIN_POWERNumericUpDown
        '
        Me.DRAIN_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "DRAIN_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DRAIN_POWERNumericUpDown.DecimalPlaces = 3
        Me.DRAIN_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.DRAIN_POWERNumericUpDown.Location = New System.Drawing.Point(12, 90)
        Me.DRAIN_POWERNumericUpDown.Name = "DRAIN_POWERNumericUpDown"
        Me.DRAIN_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.DRAIN_POWERNumericUpDown.TabIndex = 65
        Me.DRAIN_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.DRAIN_POWER
        '
        'ITEM_POWERLabel
        '
        Me.ITEM_POWERLabel.AutoSize = True
        Me.ITEM_POWERLabel.Location = New System.Drawing.Point(118, 118)
        Me.ITEM_POWERLabel.Name = "ITEM_POWERLabel"
        Me.ITEM_POWERLabel.Size = New System.Drawing.Size(269, 13)
        Me.ITEM_POWERLabel.TabIndex = 68
        Me.ITEM_POWERLabel.Text = "Multiplies the effect of items such as Potions and Ethers"
        '
        'ITEM_POWERNumericUpDown
        '
        Me.ITEM_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "ITEM_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ITEM_POWERNumericUpDown.DecimalPlaces = 3
        Me.ITEM_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.ITEM_POWERNumericUpDown.Location = New System.Drawing.Point(12, 116)
        Me.ITEM_POWERNumericUpDown.Name = "ITEM_POWERNumericUpDown"
        Me.ITEM_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.ITEM_POWERNumericUpDown.TabIndex = 67
        Me.ITEM_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.ITEM_POWER
        '
        'WEAPON_SKILL_POWERLabel
        '
        Me.WEAPON_SKILL_POWERLabel.AutoSize = True
        Me.WEAPON_SKILL_POWERLabel.Location = New System.Drawing.Point(118, 144)
        Me.WEAPON_SKILL_POWERLabel.Name = "WEAPON_SKILL_POWERLabel"
        Me.WEAPON_SKILL_POWERLabel.Size = New System.Drawing.Size(202, 13)
        Me.WEAPON_SKILL_POWERLabel.TabIndex = 70
        Me.WEAPON_SKILL_POWERLabel.Text = "Multiplies damage dealt by Weapon Skills"
        '
        'WEAPON_SKILL_POWERNumericUpDown
        '
        Me.WEAPON_SKILL_POWERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WEAPON_SKILL_POWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WEAPON_SKILL_POWERNumericUpDown.DecimalPlaces = 3
        Me.WEAPON_SKILL_POWERNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.WEAPON_SKILL_POWERNumericUpDown.Location = New System.Drawing.Point(12, 142)
        Me.WEAPON_SKILL_POWERNumericUpDown.Name = "WEAPON_SKILL_POWERNumericUpDown"
        Me.WEAPON_SKILL_POWERNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.WEAPON_SKILL_POWERNumericUpDown.TabIndex = 69
        Me.WEAPON_SKILL_POWERNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WEAPON_SKILL_POWER
        '
        'WEAPON_SKILL_POINTSLabel
        '
        Me.WEAPON_SKILL_POINTSLabel.AutoSize = True
        Me.WEAPON_SKILL_POINTSLabel.Location = New System.Drawing.Point(118, 170)
        Me.WEAPON_SKILL_POINTSLabel.Name = "WEAPON_SKILL_POINTSLabel"
        Me.WEAPON_SKILL_POINTSLabel.Size = New System.Drawing.Size(239, 13)
        Me.WEAPON_SKILL_POINTSLabel.TabIndex = 72
        Me.WEAPON_SKILL_POINTSLabel.Text = "Multiplies points earned during weapon unlocking"
        '
        'WEAPON_SKILL_POINTSNumericUpDown
        '
        Me.WEAPON_SKILL_POINTSNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "WEAPON_SKILL_POINTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WEAPON_SKILL_POINTSNumericUpDown.DecimalPlaces = 3
        Me.WEAPON_SKILL_POINTSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.WEAPON_SKILL_POINTSNumericUpDown.Location = New System.Drawing.Point(12, 168)
        Me.WEAPON_SKILL_POINTSNumericUpDown.Name = "WEAPON_SKILL_POINTSNumericUpDown"
        Me.WEAPON_SKILL_POINTSNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.WEAPON_SKILL_POINTSNumericUpDown.TabIndex = 71
        Me.WEAPON_SKILL_POINTSNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.WEAPON_SKILL_POINTS
        '
        'Spell_WeaponPower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 225)
        Me.Controls.Add(Me.WEAPON_SKILL_POINTSLabel)
        Me.Controls.Add(Me.WEAPON_SKILL_POINTSNumericUpDown)
        Me.Controls.Add(Me.WEAPON_SKILL_POWERLabel)
        Me.Controls.Add(Me.WEAPON_SKILL_POWERNumericUpDown)
        Me.Controls.Add(Me.ITEM_POWERLabel)
        Me.Controls.Add(Me.ITEM_POWERNumericUpDown)
        Me.Controls.Add(Me.DRAIN_POWERLabel)
        Me.Controls.Add(Me.DRAIN_POWERNumericUpDown)
        Me.Controls.Add(Me.BLUE_POWERLabel)
        Me.Controls.Add(Me.BLUE_POWERNumericUpDown)
        Me.Controls.Add(Me.SPELL_POWERLabel)
        Me.Controls.Add(Me.SPELL_POWERNumericUpDown)
        Me.Controls.Add(Me.CURE_POWERLabel)
        Me.Controls.Add(Me.CURE_POWERNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "Spell_WeaponPower"
        Me.Text = "Spell/Weapon Power"
        CType(Me.CURE_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPELL_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BLUE_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRAIN_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITEM_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WEAPON_SKILL_POWERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WEAPON_SKILL_POINTSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents CURE_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents CURE_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SPELL_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents SPELL_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BLUE_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents BLUE_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DRAIN_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents DRAIN_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ITEM_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents ITEM_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WEAPON_SKILL_POWERLabel As System.Windows.Forms.Label
    Friend WithEvents WEAPON_SKILL_POWERNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WEAPON_SKILL_POINTSLabel As System.Windows.Forms.Label
    Friend WithEvents WEAPON_SKILL_POINTSNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
