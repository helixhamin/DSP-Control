<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathLocationsListBox
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
        Me.AshitaPathButton = New System.Windows.Forms.Button()
        Me.AshitaPathLabel = New System.Windows.Forms.Label()
        Me.DSPPathLabel = New System.Windows.Forms.Label()
        Me.DSPPathButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DSPPathTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AshitaPathTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.POLPathLabel = New System.Windows.Forms.Label()
        Me.POLPathButton = New System.Windows.Forms.Button()
        Me.POLPathTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AshitaPathButton
        '
        Me.AshitaPathButton.Location = New System.Drawing.Point(211, 32)
        Me.AshitaPathButton.Name = "AshitaPathButton"
        Me.AshitaPathButton.Size = New System.Drawing.Size(75, 23)
        Me.AshitaPathButton.TabIndex = 17
        Me.AshitaPathButton.Text = "Browse"
        Me.AshitaPathButton.UseVisualStyleBackColor = True
        '
        'AshitaPathLabel
        '
        Me.AshitaPathLabel.AutoSize = True
        Me.AshitaPathLabel.Location = New System.Drawing.Point(6, 16)
        Me.AshitaPathLabel.Name = "AshitaPathLabel"
        Me.AshitaPathLabel.Size = New System.Drawing.Size(80, 13)
        Me.AshitaPathLabel.TabIndex = 16
        Me.AshitaPathLabel.Text = "Ashita Location"
        '
        'DSPPathLabel
        '
        Me.DSPPathLabel.AutoSize = True
        Me.DSPPathLabel.Location = New System.Drawing.Point(6, 16)
        Me.DSPPathLabel.Name = "DSPPathLabel"
        Me.DSPPathLabel.Size = New System.Drawing.Size(69, 13)
        Me.DSPPathLabel.TabIndex = 15
        Me.DSPPathLabel.Text = "DSP location"
        '
        'DSPPathButton
        '
        Me.DSPPathButton.Location = New System.Drawing.Point(211, 29)
        Me.DSPPathButton.Name = "DSPPathButton"
        Me.DSPPathButton.Size = New System.Drawing.Size(75, 23)
        Me.DSPPathButton.TabIndex = 14
        Me.DSPPathButton.Text = "Browse"
        Me.DSPPathButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DSPPathLabel)
        Me.GroupBox1.Controls.Add(Me.DSPPathTextBox)
        Me.GroupBox1.Controls.Add(Me.DSPPathButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 68)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'DSPPathTextBox
        '
        Me.DSPPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DSP_Control.My.MySettings.Default, "DSPPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DSPPathTextBox.Location = New System.Drawing.Point(9, 32)
        Me.DSPPathTextBox.Name = "DSPPathTextBox"
        Me.DSPPathTextBox.Size = New System.Drawing.Size(196, 20)
        Me.DSPPathTextBox.TabIndex = 13
        Me.DSPPathTextBox.Text = Global.DSP_Control.My.MySettings.Default.DSPPath
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AshitaPathLabel)
        Me.GroupBox2.Controls.Add(Me.AshitaPathButton)
        Me.GroupBox2.Controls.Add(Me.AshitaPathTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 66)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'AshitaPathTextBox
        '
        Me.AshitaPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DSP_Control.My.MySettings.Default, "AshitaPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AshitaPathTextBox.Location = New System.Drawing.Point(9, 32)
        Me.AshitaPathTextBox.Name = "AshitaPathTextBox"
        Me.AshitaPathTextBox.Size = New System.Drawing.Size(196, 20)
        Me.AshitaPathTextBox.TabIndex = 18
        Me.AshitaPathTextBox.Text = Global.DSP_Control.My.MySettings.Default.AshitaPath
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.POLPathLabel)
        Me.GroupBox3.Controls.Add(Me.POLPathButton)
        Me.GroupBox3.Controls.Add(Me.POLPathTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 66)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'POLPathLabel
        '
        Me.POLPathLabel.AutoSize = True
        Me.POLPathLabel.Location = New System.Drawing.Point(6, 16)
        Me.POLPathLabel.Name = "POLPathLabel"
        Me.POLPathLabel.Size = New System.Drawing.Size(72, 13)
        Me.POLPathLabel.TabIndex = 16
        Me.POLPathLabel.Text = "POL Location"
        '
        'POLPathButton
        '
        Me.POLPathButton.Location = New System.Drawing.Point(211, 32)
        Me.POLPathButton.Name = "POLPathButton"
        Me.POLPathButton.Size = New System.Drawing.Size(75, 23)
        Me.POLPathButton.TabIndex = 17
        Me.POLPathButton.Text = "Browse"
        Me.POLPathButton.UseVisualStyleBackColor = True
        '
        'POLPathTextBox
        '
        Me.POLPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DSP_Control.My.MySettings.Default, "POLPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.POLPathTextBox.Location = New System.Drawing.Point(9, 32)
        Me.POLPathTextBox.Name = "POLPathTextBox"
        Me.POLPathTextBox.Size = New System.Drawing.Size(196, 20)
        Me.POLPathTextBox.TabIndex = 18
        Me.POLPathTextBox.Text = Global.DSP_Control.My.MySettings.Default.POLPath
        '
        'PathLocationsListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 238)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PathLocationsListBox"
        Me.Text = "PathLocations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AshitaPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AshitaPathButton As System.Windows.Forms.Button
    Friend WithEvents AshitaPathLabel As System.Windows.Forms.Label
    Friend WithEvents DSPPathLabel As System.Windows.Forms.Label
    Friend WithEvents DSPPathButton As System.Windows.Forms.Button
    Friend WithEvents DSPPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents POLPathLabel As System.Windows.Forms.Label
    Friend WithEvents POLPathButton As System.Windows.Forms.Button
    Friend WithEvents POLPathTextBox As System.Windows.Forms.TextBox
End Class
