<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coffer_ChestSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Coffer_ChestSettings))
        Me.ApplySettingsButton = New System.Windows.Forms.Button()
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.COFFER_MAX_ILLUSION_TIMELabel = New System.Windows.Forms.Label()
        Me.COFFER_MIN_ILLUSION_TIMELabel = New System.Windows.Forms.Label()
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CHEST_MAX_ILLUSION_TIMELabel = New System.Windows.Forms.Label()
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CHEST_MIN_ILLUSION_TIMELabel = New System.Windows.Forms.Label()
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ILLUSION_TIMEToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.COFFER_MAX_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COFFER_MIN_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHEST_MAX_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHEST_MIN_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(73, 117)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'COFFER_MAX_ILLUSION_TIMENumericUpDown
        '
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "COFFER_MAX_ILLUSION_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.Name = "COFFER_MAX_ILLUSION_TIMENumericUpDown"
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.TabIndex = 57
        Me.ILLUSION_TIMEToolTip.SetToolTip(Me.COFFER_MAX_ILLUSION_TIMENumericUpDown, resources.GetString("COFFER_MAX_ILLUSION_TIMENumericUpDown.ToolTip"))
        Me.COFFER_MAX_ILLUSION_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.COFFER_MAX_ILLUSION_TIME
        '
        'COFFER_MAX_ILLUSION_TIMELabel
        '
        Me.COFFER_MAX_ILLUSION_TIMELabel.AutoSize = True
        Me.COFFER_MAX_ILLUSION_TIMELabel.Location = New System.Drawing.Point(139, 15)
        Me.COFFER_MAX_ILLUSION_TIMELabel.Name = "COFFER_MAX_ILLUSION_TIMELabel"
        Me.COFFER_MAX_ILLUSION_TIMELabel.Size = New System.Drawing.Size(113, 13)
        Me.COFFER_MAX_ILLUSION_TIMELabel.TabIndex = 58
        Me.COFFER_MAX_ILLUSION_TIMELabel.Text = "Max coffer illusion time"
        '
        'COFFER_MIN_ILLUSION_TIMELabel
        '
        Me.COFFER_MIN_ILLUSION_TIMELabel.AutoSize = True
        Me.COFFER_MIN_ILLUSION_TIMELabel.Location = New System.Drawing.Point(139, 41)
        Me.COFFER_MIN_ILLUSION_TIMELabel.Name = "COFFER_MIN_ILLUSION_TIMELabel"
        Me.COFFER_MIN_ILLUSION_TIMELabel.Size = New System.Drawing.Size(110, 13)
        Me.COFFER_MIN_ILLUSION_TIMELabel.TabIndex = 60
        Me.COFFER_MIN_ILLUSION_TIMELabel.Text = "Min coffer illusion time"
        '
        'COFFER_MIN_ILLUSION_TIMENumericUpDown
        '
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "COFFER_MIN_ILLUSION_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.Location = New System.Drawing.Point(13, 39)
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.Name = "COFFER_MIN_ILLUSION_TIMENumericUpDown"
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.TabIndex = 59
        Me.ILLUSION_TIMEToolTip.SetToolTip(Me.COFFER_MIN_ILLUSION_TIMENumericUpDown, "SE implemented coffer/chest illusion time in order to prevent coffer farming. No-" & _
        "one in the same area can open a chest or coffer for loot (gil, gems & items) ")
        Me.COFFER_MIN_ILLUSION_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.COFFER_MIN_ILLUSION_TIME
        '
        'CHEST_MAX_ILLUSION_TIMELabel
        '
        Me.CHEST_MAX_ILLUSION_TIMELabel.AutoSize = True
        Me.CHEST_MAX_ILLUSION_TIMELabel.Location = New System.Drawing.Point(139, 67)
        Me.CHEST_MAX_ILLUSION_TIMELabel.Name = "CHEST_MAX_ILLUSION_TIMELabel"
        Me.CHEST_MAX_ILLUSION_TIMELabel.Size = New System.Drawing.Size(112, 13)
        Me.CHEST_MAX_ILLUSION_TIMELabel.TabIndex = 62
        Me.CHEST_MAX_ILLUSION_TIMELabel.Text = "Max chest illusion time"
        '
        'CHEST_MAX_ILLUSION_TIMENumericUpDown
        '
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CHEST_MAX_ILLUSION_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.Location = New System.Drawing.Point(13, 65)
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.Name = "CHEST_MAX_ILLUSION_TIMENumericUpDown"
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.TabIndex = 61
        Me.ILLUSION_TIMEToolTip.SetToolTip(Me.CHEST_MAX_ILLUSION_TIMENumericUpDown, "SE implemented coffer/chest illusion time in order to prevent coffer farming. No-" & _
        "one in the same area can open a chest or coffer for loot (gil, gems & items) ")
        Me.CHEST_MAX_ILLUSION_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CHEST_MAX_ILLUSION_TIME
        '
        'CHEST_MIN_ILLUSION_TIMELabel
        '
        Me.CHEST_MIN_ILLUSION_TIMELabel.AutoSize = True
        Me.CHEST_MIN_ILLUSION_TIMELabel.Location = New System.Drawing.Point(139, 93)
        Me.CHEST_MIN_ILLUSION_TIMELabel.Name = "CHEST_MIN_ILLUSION_TIMELabel"
        Me.CHEST_MIN_ILLUSION_TIMELabel.Size = New System.Drawing.Size(109, 13)
        Me.CHEST_MIN_ILLUSION_TIMELabel.TabIndex = 64
        Me.CHEST_MIN_ILLUSION_TIMELabel.Text = "Min chest illusion time"
        '
        'CHEST_MIN_ILLUSION_TIMENumericUpDown
        '
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "CHEST_MIN_ILLUSION_TIME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.Location = New System.Drawing.Point(13, 91)
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.Name = "CHEST_MIN_ILLUSION_TIMENumericUpDown"
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.TabIndex = 63
        Me.ILLUSION_TIMEToolTip.SetToolTip(Me.CHEST_MIN_ILLUSION_TIMENumericUpDown, "SE implemented coffer/chest illusion time in order to prevent coffer farming. No-" & _
        "one in the same area can open a chest or coffer for loot (gil, gems & items) ")
        Me.CHEST_MIN_ILLUSION_TIMENumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.CHEST_MIN_ILLUSION_TIME
        '
        'Coffer_ChestSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 148)
        Me.Controls.Add(Me.CHEST_MIN_ILLUSION_TIMELabel)
        Me.Controls.Add(Me.CHEST_MIN_ILLUSION_TIMENumericUpDown)
        Me.Controls.Add(Me.CHEST_MAX_ILLUSION_TIMELabel)
        Me.Controls.Add(Me.CHEST_MAX_ILLUSION_TIMENumericUpDown)
        Me.Controls.Add(Me.COFFER_MIN_ILLUSION_TIMELabel)
        Me.Controls.Add(Me.COFFER_MIN_ILLUSION_TIMENumericUpDown)
        Me.Controls.Add(Me.COFFER_MAX_ILLUSION_TIMELabel)
        Me.Controls.Add(Me.COFFER_MAX_ILLUSION_TIMENumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "Coffer_ChestSettings"
        Me.Text = "Coffer/Chest Settings"
        CType(Me.COFFER_MAX_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COFFER_MIN_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHEST_MAX_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHEST_MIN_ILLUSION_TIMENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents COFFER_MAX_ILLUSION_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents COFFER_MAX_ILLUSION_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents COFFER_MIN_ILLUSION_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents COFFER_MIN_ILLUSION_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CHEST_MAX_ILLUSION_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents CHEST_MAX_ILLUSION_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CHEST_MIN_ILLUSION_TIMELabel As System.Windows.Forms.Label
    Friend WithEvents CHEST_MIN_ILLUSION_TIMENumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ILLUSION_TIMEToolTip As System.Windows.Forms.ToolTip
End Class
