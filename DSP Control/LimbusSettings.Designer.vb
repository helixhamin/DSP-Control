<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LimbusSettings
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
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel = New System.Windows.Forms.Label()
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(117, 63)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown
        '
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "BETWEEN_2COSMOCLEANSE_WAIT_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Name = "BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown"
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.TabIndex = 57
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.BETWEEN_2COSMOCLEANSE_WAIT_TIME
        '
        'BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel
        '
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.AutoSize = True
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.Location = New System.Drawing.Point(119, 15)
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.Name = "BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel"
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.Size = New System.Drawing.Size(163, 13)
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.TabIndex = 58
        Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel.Text = "Days between 2 limbus key items"
        '
        'DIMENSIONAL_PORTAL_UNLOCKCheckBox
        '
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.AutoSize = True
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.DIMENSIONAL_PORTAL_UNLOCK
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "DIMENSIONAL_PORTAL_UNLOCK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.Location = New System.Drawing.Point(13, 40)
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.Name = "DIMENSIONAL_PORTAL_UNLOCKCheckBox"
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.Size = New System.Drawing.Size(357, 17)
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.TabIndex = 59
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.Text = "Bypass requirements for dimensional portal use for sea travel to Limbus"
        Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox.UseVisualStyleBackColor = True
        '
        'LimbusSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 103)
        Me.Controls.Add(Me.DIMENSIONAL_PORTAL_UNLOCKCheckBox)
        Me.Controls.Add(Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel)
        Me.Controls.Add(Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "LimbusSettings"
        Me.Text = "Limbus Settings"
        CType(Me.BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents BETWEEN_2COSMOCLEANSE_WAIT_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BETWEEN_2COSMOCLEANSE_WAIT_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents DIMENSIONAL_PORTAL_UNLOCKCheckBox As System.Windows.Forms.CheckBox
End Class
