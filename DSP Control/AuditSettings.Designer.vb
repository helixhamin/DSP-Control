<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditSettings
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
        Me.audit_chatCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_sayCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_shoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_tellCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_yellCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_linkshellCheckBox = New System.Windows.Forms.CheckBox()
        Me.audit_partyCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(13, 174)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(109, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'audit_chatCheckBox
        '
        Me.audit_chatCheckBox.AutoSize = True
        Me.audit_chatCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_chat
        Me.audit_chatCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_chat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_chatCheckBox.Location = New System.Drawing.Point(13, 13)
        Me.audit_chatCheckBox.Name = "audit_chatCheckBox"
        Me.audit_chatCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.audit_chatCheckBox.TabIndex = 57
        Me.audit_chatCheckBox.Text = "Audit chat"
        Me.audit_chatCheckBox.UseVisualStyleBackColor = True
        '
        'audit_sayCheckBox
        '
        Me.audit_sayCheckBox.AutoSize = True
        Me.audit_sayCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_say
        Me.audit_sayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_say", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_sayCheckBox.Location = New System.Drawing.Point(13, 36)
        Me.audit_sayCheckBox.Name = "audit_sayCheckBox"
        Me.audit_sayCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.audit_sayCheckBox.TabIndex = 58
        Me.audit_sayCheckBox.Text = "Audit say"
        Me.audit_sayCheckBox.UseVisualStyleBackColor = True
        '
        'audit_shoutCheckBox
        '
        Me.audit_shoutCheckBox.AutoSize = True
        Me.audit_shoutCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_shout
        Me.audit_shoutCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_shout", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_shoutCheckBox.Location = New System.Drawing.Point(13, 59)
        Me.audit_shoutCheckBox.Name = "audit_shoutCheckBox"
        Me.audit_shoutCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.audit_shoutCheckBox.TabIndex = 59
        Me.audit_shoutCheckBox.Text = "Audit shout"
        Me.audit_shoutCheckBox.UseVisualStyleBackColor = True
        '
        'audit_tellCheckBox
        '
        Me.audit_tellCheckBox.AutoSize = True
        Me.audit_tellCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_tell
        Me.audit_tellCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_tell", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_tellCheckBox.Location = New System.Drawing.Point(13, 82)
        Me.audit_tellCheckBox.Name = "audit_tellCheckBox"
        Me.audit_tellCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.audit_tellCheckBox.TabIndex = 60
        Me.audit_tellCheckBox.Text = "Audit tell"
        Me.audit_tellCheckBox.UseVisualStyleBackColor = True
        '
        'audit_yellCheckBox
        '
        Me.audit_yellCheckBox.AutoSize = True
        Me.audit_yellCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_yell
        Me.audit_yellCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_yell", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_yellCheckBox.Location = New System.Drawing.Point(13, 105)
        Me.audit_yellCheckBox.Name = "audit_yellCheckBox"
        Me.audit_yellCheckBox.Size = New System.Drawing.Size(68, 17)
        Me.audit_yellCheckBox.TabIndex = 61
        Me.audit_yellCheckBox.Text = "Audit yell"
        Me.audit_yellCheckBox.UseVisualStyleBackColor = True
        '
        'audit_linkshellCheckBox
        '
        Me.audit_linkshellCheckBox.AutoSize = True
        Me.audit_linkshellCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_linkshell
        Me.audit_linkshellCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_linkshell", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_linkshellCheckBox.Location = New System.Drawing.Point(13, 128)
        Me.audit_linkshellCheckBox.Name = "audit_linkshellCheckBox"
        Me.audit_linkshellCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.audit_linkshellCheckBox.TabIndex = 62
        Me.audit_linkshellCheckBox.Text = "Audit linkshell"
        Me.audit_linkshellCheckBox.UseVisualStyleBackColor = True
        '
        'audit_partyCheckBox
        '
        Me.audit_partyCheckBox.AutoSize = True
        Me.audit_partyCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.audit_party
        Me.audit_partyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "audit_party", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.audit_partyCheckBox.Location = New System.Drawing.Point(13, 151)
        Me.audit_partyCheckBox.Name = "audit_partyCheckBox"
        Me.audit_partyCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.audit_partyCheckBox.TabIndex = 63
        Me.audit_partyCheckBox.Text = "Audit party"
        Me.audit_partyCheckBox.UseVisualStyleBackColor = True
        '
        'AuditSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 204)
        Me.Controls.Add(Me.audit_partyCheckBox)
        Me.Controls.Add(Me.audit_linkshellCheckBox)
        Me.Controls.Add(Me.audit_yellCheckBox)
        Me.Controls.Add(Me.audit_tellCheckBox)
        Me.Controls.Add(Me.audit_shoutCheckBox)
        Me.Controls.Add(Me.audit_sayCheckBox)
        Me.Controls.Add(Me.audit_chatCheckBox)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "AuditSettings"
        Me.Text = "Audit Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents audit_chatCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_sayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_shoutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_tellCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_yellCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_linkshellCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents audit_partyCheckBox As System.Windows.Forms.CheckBox
End Class
