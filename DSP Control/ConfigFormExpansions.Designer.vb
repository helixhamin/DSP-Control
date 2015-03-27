<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFormExpansions
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
        Me.ExpansionSettingsApply = New System.Windows.Forms.Button()
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox = New System.Windows.Forms.CheckBox()
        Me.ENABLE_COP_ZONE_CAPCheckBox = New System.Windows.Forms.CheckBox()
        Me.CoP_Battle_capCheckBox = New System.Windows.Forms.CheckBox()
        Me.RESTRICT_BY_EXPANSIONCheckBox = New System.Windows.Forms.CheckBox()
        Me.SOACheckBox = New System.Windows.Forms.CheckBox()
        Me.ABYSSEACheckBox = New System.Windows.Forms.CheckBox()
        Me.ASACheckBox = New System.Windows.Forms.CheckBox()
        Me.AMKCheckBox = New System.Windows.Forms.CheckBox()
        Me.ACPCheckBox = New System.Windows.Forms.CheckBox()
        Me.WOTGCheckBox = New System.Windows.Forms.CheckBox()
        Me.TOAUCheckBox = New System.Windows.Forms.CheckBox()
        Me.COPCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ExpansionSettingsApply
        '
        Me.ExpansionSettingsApply.Location = New System.Drawing.Point(15, 279)
        Me.ExpansionSettingsApply.Name = "ExpansionSettingsApply"
        Me.ExpansionSettingsApply.Size = New System.Drawing.Size(148, 23)
        Me.ExpansionSettingsApply.TabIndex = 8
        Me.ExpansionSettingsApply.Text = "Apply Expansion settings"
        Me.ExpansionSettingsApply.UseVisualStyleBackColor = True
        '
        'USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox
        '
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.AutoSize = True
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.USE_ADOULIN_WEAPON_SKILL_CHANGES
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "USE_ADOULIN_WEAPON_SKILL_CHANGES", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Location = New System.Drawing.Point(12, 234)
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Name = "USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox"
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Size = New System.Drawing.Size(173, 17)
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.TabIndex = 12
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.Text = "Use Adoulin WS Damage rates"
        Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox.UseVisualStyleBackColor = True
        '
        'ENABLE_COP_ZONE_CAPCheckBox
        '
        Me.ENABLE_COP_ZONE_CAPCheckBox.AutoSize = True
        Me.ENABLE_COP_ZONE_CAPCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_COP_ZONE_CAP
        Me.ENABLE_COP_ZONE_CAPCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ENABLE_COP_ZONE_CAPCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_COP_ZONE_CAP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ENABLE_COP_ZONE_CAPCheckBox.Location = New System.Drawing.Point(12, 56)
        Me.ENABLE_COP_ZONE_CAPCheckBox.Name = "ENABLE_COP_ZONE_CAPCheckBox"
        Me.ENABLE_COP_ZONE_CAPCheckBox.Size = New System.Drawing.Size(132, 17)
        Me.ENABLE_COP_ZONE_CAPCheckBox.TabIndex = 11
        Me.ENABLE_COP_ZONE_CAPCheckBox.Text = "Enable CoP Zone Cap"
        Me.ENABLE_COP_ZONE_CAPCheckBox.UseVisualStyleBackColor = True
        '
        'CoP_Battle_capCheckBox
        '
        Me.CoP_Battle_capCheckBox.AutoSize = True
        Me.CoP_Battle_capCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.CoP_Battle_cap
        Me.CoP_Battle_capCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CoP_Battle_capCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "CoP_Battle_cap", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CoP_Battle_capCheckBox.Location = New System.Drawing.Point(12, 34)
        Me.CoP_Battle_capCheckBox.Name = "CoP_Battle_capCheckBox"
        Me.CoP_Battle_capCheckBox.Size = New System.Drawing.Size(134, 17)
        Me.CoP_Battle_capCheckBox.TabIndex = 10
        Me.CoP_Battle_capCheckBox.Text = "Enable CoP Battle Cap"
        Me.CoP_Battle_capCheckBox.UseVisualStyleBackColor = True
        '
        'RESTRICT_BY_EXPANSIONCheckBox
        '
        Me.RESTRICT_BY_EXPANSIONCheckBox.AutoSize = True
        Me.RESTRICT_BY_EXPANSIONCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.RESTRICT_BY_EXPANSION
        Me.RESTRICT_BY_EXPANSIONCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RESTRICT_BY_EXPANSIONCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "RESTRICT_BY_EXPANSION", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RESTRICT_BY_EXPANSIONCheckBox.Location = New System.Drawing.Point(12, 257)
        Me.RESTRICT_BY_EXPANSIONCheckBox.Name = "RESTRICT_BY_EXPANSIONCheckBox"
        Me.RESTRICT_BY_EXPANSIONCheckBox.Size = New System.Drawing.Size(128, 17)
        Me.RESTRICT_BY_EXPANSIONCheckBox.TabIndex = 9
        Me.RESTRICT_BY_EXPANSIONCheckBox.Text = "Restrict by Expansion"
        Me.RESTRICT_BY_EXPANSIONCheckBox.UseVisualStyleBackColor = True
        '
        'SOACheckBox
        '
        Me.SOACheckBox.AutoSize = True
        Me.SOACheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_SOA
        Me.SOACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_SOA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SOACheckBox.Location = New System.Drawing.Point(12, 210)
        Me.SOACheckBox.Name = "SOACheckBox"
        Me.SOACheckBox.Size = New System.Drawing.Size(151, 17)
        Me.SOACheckBox.TabIndex = 7
        Me.SOACheckBox.Text = "Enable Seekers of Adoulin"
        Me.SOACheckBox.UseVisualStyleBackColor = True
        '
        'ABYSSEACheckBox
        '
        Me.ABYSSEACheckBox.AutoSize = True
        Me.ABYSSEACheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_ABYSSEA
        Me.ABYSSEACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_ABYSSEA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ABYSSEACheckBox.Location = New System.Drawing.Point(12, 188)
        Me.ABYSSEACheckBox.Name = "ABYSSEACheckBox"
        Me.ABYSSEACheckBox.Size = New System.Drawing.Size(102, 17)
        Me.ABYSSEACheckBox.TabIndex = 6
        Me.ABYSSEACheckBox.Text = "Enable Abyssea"
        Me.ABYSSEACheckBox.UseVisualStyleBackColor = True
        '
        'ASACheckBox
        '
        Me.ASACheckBox.AutoSize = True
        Me.ASACheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_ASA
        Me.ASACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_ASA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ASACheckBox.Location = New System.Drawing.Point(12, 166)
        Me.ASACheckBox.Name = "ASACheckBox"
        Me.ASACheckBox.Size = New System.Drawing.Size(170, 17)
        Me.ASACheckBox.TabIndex = 5
        Me.ASACheckBox.Text = "Enable A Shantotto Ascension"
        Me.ASACheckBox.UseVisualStyleBackColor = True
        '
        'AMKCheckBox
        '
        Me.AMKCheckBox.AutoSize = True
        Me.AMKCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_AMK
        Me.AMKCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_AMK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AMKCheckBox.Location = New System.Drawing.Point(12, 144)
        Me.AMKCheckBox.Name = "AMKCheckBox"
        Me.AMKCheckBox.Size = New System.Drawing.Size(165, 17)
        Me.AMKCheckBox.TabIndex = 4
        Me.AMKCheckBox.Text = "Enable A Moogle Kupo d'Etat"
        Me.AMKCheckBox.UseVisualStyleBackColor = True
        '
        'ACPCheckBox
        '
        Me.ACPCheckBox.AutoSize = True
        Me.ACPCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_ACP
        Me.ACPCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_ACP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ACPCheckBox.Location = New System.Drawing.Point(12, 122)
        Me.ACPCheckBox.Name = "ACPCheckBox"
        Me.ACPCheckBox.Size = New System.Drawing.Size(167, 17)
        Me.ACPCheckBox.TabIndex = 3
        Me.ACPCheckBox.Text = "Enable A Crystalline Prophecy"
        Me.ACPCheckBox.UseVisualStyleBackColor = True
        '
        'WOTGCheckBox
        '
        Me.WOTGCheckBox.AutoSize = True
        Me.WOTGCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_WOTG
        Me.WOTGCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_WOTG", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WOTGCheckBox.Location = New System.Drawing.Point(12, 100)
        Me.WOTGCheckBox.Name = "WOTGCheckBox"
        Me.WOTGCheckBox.Size = New System.Drawing.Size(167, 17)
        Me.WOTGCheckBox.TabIndex = 2
        Me.WOTGCheckBox.Text = "Enable Wings of the Goddess"
        Me.WOTGCheckBox.UseVisualStyleBackColor = True
        '
        'TOAUCheckBox
        '
        Me.TOAUCheckBox.AutoSize = True
        Me.TOAUCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_TOAU
        Me.TOAUCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_TOAU", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TOAUCheckBox.Location = New System.Drawing.Point(12, 78)
        Me.TOAUCheckBox.Name = "TOAUCheckBox"
        Me.TOAUCheckBox.Size = New System.Drawing.Size(178, 17)
        Me.TOAUCheckBox.TabIndex = 1
        Me.TOAUCheckBox.Text = "Enable Treasures of Aht Urhgan"
        Me.TOAUCheckBox.UseVisualStyleBackColor = True
        '
        'COPCheckBox
        '
        Me.COPCheckBox.AutoSize = True
        Me.COPCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.ENABLE_COP
        Me.COPCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "ENABLE_COP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.COPCheckBox.Location = New System.Drawing.Point(12, 12)
        Me.COPCheckBox.Name = "COPCheckBox"
        Me.COPCheckBox.Size = New System.Drawing.Size(156, 17)
        Me.COPCheckBox.TabIndex = 0
        Me.COPCheckBox.Text = "Enable Chains of Promathia"
        Me.COPCheckBox.UseVisualStyleBackColor = True
        '
        'ConfigFormExpansions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 310)
        Me.Controls.Add(Me.USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox)
        Me.Controls.Add(Me.ENABLE_COP_ZONE_CAPCheckBox)
        Me.Controls.Add(Me.CoP_Battle_capCheckBox)
        Me.Controls.Add(Me.RESTRICT_BY_EXPANSIONCheckBox)
        Me.Controls.Add(Me.ExpansionSettingsApply)
        Me.Controls.Add(Me.SOACheckBox)
        Me.Controls.Add(Me.ABYSSEACheckBox)
        Me.Controls.Add(Me.ASACheckBox)
        Me.Controls.Add(Me.AMKCheckBox)
        Me.Controls.Add(Me.ACPCheckBox)
        Me.Controls.Add(Me.WOTGCheckBox)
        Me.Controls.Add(Me.TOAUCheckBox)
        Me.Controls.Add(Me.COPCheckBox)
        Me.Name = "ConfigFormExpansions"
        Me.Text = "Expansions Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TOAUCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WOTGCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ACPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AMKCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ASACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ABYSSEACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SOACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExpansionSettingsApply As System.Windows.Forms.Button
    Friend WithEvents RESTRICT_BY_EXPANSIONCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CoP_Battle_capCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ENABLE_COP_ZONE_CAPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents USE_ADOULIN_WEAPON_SKILL_CHANGESCheckBox As System.Windows.Forms.CheckBox
End Class
