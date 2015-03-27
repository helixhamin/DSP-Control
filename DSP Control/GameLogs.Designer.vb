<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameLogs
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
        Me.GameLogsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'GameLogsRichTextBox
        '
        Me.GameLogsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameLogsRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.GameLogsRichTextBox.Name = "GameLogsRichTextBox"
        Me.GameLogsRichTextBox.ReadOnly = True
        Me.GameLogsRichTextBox.Size = New System.Drawing.Size(470, 262)
        Me.GameLogsRichTextBox.TabIndex = 0
        Me.GameLogsRichTextBox.Text = ""
        '
        'GameLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 262)
        Me.Controls.Add(Me.GameLogsRichTextBox)
        Me.Name = "GameLogs"
        Me.Text = "GameLogs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameLogsRichTextBox As System.Windows.Forms.RichTextBox
End Class
