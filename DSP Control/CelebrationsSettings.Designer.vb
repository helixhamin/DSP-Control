<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelebrationsSettings
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
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.EXPLORER_MOOGLE_LEVELCAPLabel = New System.Windows.Forms.Label()
        Me.EXPLORER_MOOGLECheckBox = New System.Windows.Forms.CheckBox()
        Me.SUMMERFEST_2004CheckBox = New System.Windows.Forms.CheckBox()
        Me.JINX_MODE_2012CheckBox = New System.Windows.Forms.CheckBox()
        Me.HALLOWEENCheckBox = New System.Windows.Forms.CheckBox()
        Me.SUNBREEZE_2011CheckBox = New System.Windows.Forms.CheckBox()
        Me.SUNBREEZE_2009CheckBox = New System.Windows.Forms.CheckBox()
        Me.HALLOWEEN_2005CheckBox = New System.Windows.Forms.CheckBox()
        Me.CHRISTMASCheckBox = New System.Windows.Forms.CheckBox()
        Me.HALLOWEEN_YEAR_ROUNDCheckBox = New System.Windows.Forms.CheckBox()
        Me.JINX_MODE_2008CheckBox = New System.Windows.Forms.CheckBox()
        Me.JINX_MODE_2005CheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplySettingsButton
        '
        Me.ApplySettingsButton.Location = New System.Drawing.Point(87, 293)
        Me.ApplySettingsButton.Name = "ApplySettingsButton"
        Me.ApplySettingsButton.Size = New System.Drawing.Size(136, 23)
        Me.ApplySettingsButton.TabIndex = 56
        Me.ApplySettingsButton.Text = "Apply Settings"
        Me.ApplySettingsButton.UseVisualStyleBackColor = True
        '
        'EXPLORER_MOOGLE_LEVELCAPNumericUpDown
        '
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DSP_Control.My.MySettings.Default, "EXPLORER_MOOGLE_LEVELCAP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Location = New System.Drawing.Point(13, 13)
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Name = "EXPLORER_MOOGLE_LEVELCAPNumericUpDown"
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.TabIndex = 57
        Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown.Value = Global.DSP_Control.My.MySettings.Default.EXPLORER_MOOGLE_LEVELCAP
        '
        'EXPLORER_MOOGLE_LEVELCAPLabel
        '
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.AutoSize = True
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.Location = New System.Drawing.Point(119, 15)
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.Name = "EXPLORER_MOOGLE_LEVELCAPLabel"
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.Size = New System.Drawing.Size(183, 13)
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.TabIndex = 58
        Me.EXPLORER_MOOGLE_LEVELCAPLabel.Text = "Level required to use explorer moogle"
        '
        'EXPLORER_MOOGLECheckBox
        '
        Me.EXPLORER_MOOGLECheckBox.AutoSize = True
        Me.EXPLORER_MOOGLECheckBox.Checked = Global.DSP_Control.My.MySettings.Default.EXPLORER_MOOGLE
        Me.EXPLORER_MOOGLECheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EXPLORER_MOOGLECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "EXPLORER_MOOGLE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXPLORER_MOOGLECheckBox.Location = New System.Drawing.Point(13, 40)
        Me.EXPLORER_MOOGLECheckBox.Name = "EXPLORER_MOOGLECheckBox"
        Me.EXPLORER_MOOGLECheckBox.Size = New System.Drawing.Size(184, 17)
        Me.EXPLORER_MOOGLECheckBox.TabIndex = 59
        Me.EXPLORER_MOOGLECheckBox.Text = "Enables explorer moogle teleports"
        Me.EXPLORER_MOOGLECheckBox.UseVisualStyleBackColor = True
        '
        'SUMMERFEST_2004CheckBox
        '
        Me.SUMMERFEST_2004CheckBox.AutoSize = True
        Me.SUMMERFEST_2004CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.SUMMERFEST_2004
        Me.SUMMERFEST_2004CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "SUMMERFEST_2004", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SUMMERFEST_2004CheckBox.Location = New System.Drawing.Point(13, 132)
        Me.SUMMERFEST_2004CheckBox.Name = "SUMMERFEST_2004CheckBox"
        Me.SUMMERFEST_2004CheckBox.Size = New System.Drawing.Size(219, 17)
        Me.SUMMERFEST_2004CheckBox.TabIndex = 60
        Me.SUMMERFEST_2004CheckBox.Text = "Gives starting players 2004 far east dress"
        Me.SUMMERFEST_2004CheckBox.UseVisualStyleBackColor = True
        '
        'JINX_MODE_2012CheckBox
        '
        Me.JINX_MODE_2012CheckBox.AutoSize = True
        Me.JINX_MODE_2012CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.JINX_MODE_2012
        Me.JINX_MODE_2012CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "JINX_MODE_2012", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.JINX_MODE_2012CheckBox.Location = New System.Drawing.Point(13, 109)
        Me.JINX_MODE_2012CheckBox.Name = "JINX_MODE_2012CheckBox"
        Me.JINX_MODE_2012CheckBox.Size = New System.Drawing.Size(200, 17)
        Me.JINX_MODE_2012CheckBox.TabIndex = 61
        Me.JINX_MODE_2012CheckBox.Text = "Gives starting players 2012 swimsuits"
        Me.JINX_MODE_2012CheckBox.UseVisualStyleBackColor = True
        '
        'HALLOWEENCheckBox
        '
        Me.HALLOWEENCheckBox.AutoSize = True
        Me.HALLOWEENCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.HALLOWEEN
        Me.HALLOWEENCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "HALLOWEEN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HALLOWEENCheckBox.Location = New System.Drawing.Point(13, 224)
        Me.HALLOWEENCheckBox.Name = "HALLOWEENCheckBox"
        Me.HALLOWEENCheckBox.Size = New System.Drawing.Size(206, 17)
        Me.HALLOWEENCheckBox.TabIndex = 62
        Me.HALLOWEENCheckBox.Text = "Gives starting players Halloween items"
        Me.HALLOWEENCheckBox.UseVisualStyleBackColor = True
        '
        'SUNBREEZE_2011CheckBox
        '
        Me.SUNBREEZE_2011CheckBox.AutoSize = True
        Me.SUNBREEZE_2011CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.SUNBREEZE_2011
        Me.SUNBREEZE_2011CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "SUNBREEZE_2011", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SUNBREEZE_2011CheckBox.Location = New System.Drawing.Point(13, 178)
        Me.SUNBREEZE_2011CheckBox.Name = "SUNBREEZE_2011CheckBox"
        Me.SUNBREEZE_2011CheckBox.Size = New System.Drawing.Size(219, 17)
        Me.SUNBREEZE_2011CheckBox.TabIndex = 63
        Me.SUNBREEZE_2011CheckBox.Text = "Gives starting players 2011 far east dress"
        Me.SUNBREEZE_2011CheckBox.UseVisualStyleBackColor = True
        '
        'SUNBREEZE_2009CheckBox
        '
        Me.SUNBREEZE_2009CheckBox.AutoSize = True
        Me.SUNBREEZE_2009CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.SUNBREEZE_2009
        Me.SUNBREEZE_2009CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "SUNBREEZE_2009", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SUNBREEZE_2009CheckBox.Location = New System.Drawing.Point(13, 155)
        Me.SUNBREEZE_2009CheckBox.Name = "SUNBREEZE_2009CheckBox"
        Me.SUNBREEZE_2009CheckBox.Size = New System.Drawing.Size(219, 17)
        Me.SUNBREEZE_2009CheckBox.TabIndex = 64
        Me.SUNBREEZE_2009CheckBox.Text = "Gives starting players 2009 far east dress"
        Me.SUNBREEZE_2009CheckBox.UseVisualStyleBackColor = True
        '
        'HALLOWEEN_2005CheckBox
        '
        Me.HALLOWEEN_2005CheckBox.AutoSize = True
        Me.HALLOWEEN_2005CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.HALLOWEEN_2005
        Me.HALLOWEEN_2005CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "HALLOWEEN_2005", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HALLOWEEN_2005CheckBox.Location = New System.Drawing.Point(13, 247)
        Me.HALLOWEEN_2005CheckBox.Name = "HALLOWEEN_2005CheckBox"
        Me.HALLOWEEN_2005CheckBox.Size = New System.Drawing.Size(178, 17)
        Me.HALLOWEEN_2005CheckBox.TabIndex = 65
        Me.HALLOWEEN_2005CheckBox.Text = "Enable the 2005 harvest festival"
        Me.HALLOWEEN_2005CheckBox.UseVisualStyleBackColor = True
        '
        'CHRISTMASCheckBox
        '
        Me.CHRISTMASCheckBox.AutoSize = True
        Me.CHRISTMASCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.CHRISTMAS
        Me.CHRISTMASCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "CHRISTMAS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHRISTMASCheckBox.Location = New System.Drawing.Point(13, 201)
        Me.CHRISTMASCheckBox.Name = "CHRISTMASCheckBox"
        Me.CHRISTMASCheckBox.Size = New System.Drawing.Size(205, 17)
        Me.CHRISTMASCheckBox.TabIndex = 66
        Me.CHRISTMASCheckBox.Text = "Gives starting players  Christmas dress"
        Me.CHRISTMASCheckBox.UseVisualStyleBackColor = True
        '
        'HALLOWEEN_YEAR_ROUNDCheckBox
        '
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.AutoSize = True
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.Checked = Global.DSP_Control.My.MySettings.Default.HALLOWEEN_YEAR_ROUND
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "HALLOWEEN_YEAR_ROUND", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.Location = New System.Drawing.Point(13, 270)
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.Name = "HALLOWEEN_YEAR_ROUNDCheckBox"
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.Size = New System.Drawing.Size(232, 17)
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.TabIndex = 67
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.Text = "Allows harvest festival to run all year around"
        Me.HALLOWEEN_YEAR_ROUNDCheckBox.UseVisualStyleBackColor = True
        '
        'JINX_MODE_2008CheckBox
        '
        Me.JINX_MODE_2008CheckBox.AutoSize = True
        Me.JINX_MODE_2008CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.JINX_MODE_2008
        Me.JINX_MODE_2008CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "JINX_MODE_2008", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.JINX_MODE_2008CheckBox.Location = New System.Drawing.Point(13, 86)
        Me.JINX_MODE_2008CheckBox.Name = "JINX_MODE_2008CheckBox"
        Me.JINX_MODE_2008CheckBox.Size = New System.Drawing.Size(200, 17)
        Me.JINX_MODE_2008CheckBox.TabIndex = 68
        Me.JINX_MODE_2008CheckBox.Text = "Gives starting players 2008 swimsuits"
        Me.JINX_MODE_2008CheckBox.UseVisualStyleBackColor = True
        '
        'JINX_MODE_2005CheckBox
        '
        Me.JINX_MODE_2005CheckBox.AutoSize = True
        Me.JINX_MODE_2005CheckBox.Checked = Global.DSP_Control.My.MySettings.Default.JINX_MODE_2005
        Me.JINX_MODE_2005CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DSP_Control.My.MySettings.Default, "JINX_MODE_2005", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.JINX_MODE_2005CheckBox.Location = New System.Drawing.Point(13, 63)
        Me.JINX_MODE_2005CheckBox.Name = "JINX_MODE_2005CheckBox"
        Me.JINX_MODE_2005CheckBox.Size = New System.Drawing.Size(200, 17)
        Me.JINX_MODE_2005CheckBox.TabIndex = 69
        Me.JINX_MODE_2005CheckBox.Text = "Gives starting players 2005 swimsuits"
        Me.JINX_MODE_2005CheckBox.UseVisualStyleBackColor = True
        '
        'CelebrationsSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 325)
        Me.Controls.Add(Me.JINX_MODE_2005CheckBox)
        Me.Controls.Add(Me.JINX_MODE_2008CheckBox)
        Me.Controls.Add(Me.HALLOWEEN_YEAR_ROUNDCheckBox)
        Me.Controls.Add(Me.CHRISTMASCheckBox)
        Me.Controls.Add(Me.HALLOWEEN_2005CheckBox)
        Me.Controls.Add(Me.SUNBREEZE_2009CheckBox)
        Me.Controls.Add(Me.SUNBREEZE_2011CheckBox)
        Me.Controls.Add(Me.HALLOWEENCheckBox)
        Me.Controls.Add(Me.JINX_MODE_2012CheckBox)
        Me.Controls.Add(Me.SUMMERFEST_2004CheckBox)
        Me.Controls.Add(Me.EXPLORER_MOOGLECheckBox)
        Me.Controls.Add(Me.EXPLORER_MOOGLE_LEVELCAPLabel)
        Me.Controls.Add(Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown)
        Me.Controls.Add(Me.ApplySettingsButton)
        Me.Name = "CelebrationsSettings"
        Me.Text = "Celebrations Settings"
        CType(Me.EXPLORER_MOOGLE_LEVELCAPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplySettingsButton As System.Windows.Forms.Button
    Friend WithEvents EXPLORER_MOOGLE_LEVELCAPNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents EXPLORER_MOOGLE_LEVELCAPLabel As System.Windows.Forms.Label
    Friend WithEvents EXPLORER_MOOGLECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SUMMERFEST_2004CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents JINX_MODE_2012CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HALLOWEENCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SUNBREEZE_2011CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SUNBREEZE_2009CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HALLOWEEN_2005CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CHRISTMASCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HALLOWEEN_YEAR_ROUNDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents JINX_MODE_2008CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents JINX_MODE_2005CheckBox As System.Windows.Forms.CheckBox
End Class
