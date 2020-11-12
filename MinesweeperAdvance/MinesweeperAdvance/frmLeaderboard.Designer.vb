<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaderboard
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
        Me.lstLeaderboard = New System.Windows.Forms.ListBox()
        Me.btnReturnFromLeaderboard = New System.Windows.Forms.Button()
        Me.lblLeaderboardTitle = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstLeaderboard
        '
        Me.lstLeaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstLeaderboard.FormattingEnabled = True
        Me.lstLeaderboard.ItemHeight = 16
        Me.lstLeaderboard.Location = New System.Drawing.Point(12, 74)
        Me.lstLeaderboard.Name = "lstLeaderboard"
        Me.lstLeaderboard.Size = New System.Drawing.Size(216, 308)
        Me.lstLeaderboard.Sorted = True
        Me.lstLeaderboard.TabIndex = 0
        '
        'btnReturnFromLeaderboard
        '
        Me.btnReturnFromLeaderboard.Location = New System.Drawing.Point(32, 388)
        Me.btnReturnFromLeaderboard.Name = "btnReturnFromLeaderboard"
        Me.btnReturnFromLeaderboard.Size = New System.Drawing.Size(167, 71)
        Me.btnReturnFromLeaderboard.TabIndex = 1
        Me.btnReturnFromLeaderboard.Text = "Back"
        Me.btnReturnFromLeaderboard.UseVisualStyleBackColor = True
        '
        'lblLeaderboardTitle
        '
        Me.lblLeaderboardTitle.AutoSize = True
        Me.lblLeaderboardTitle.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblLeaderboardTitle.Location = New System.Drawing.Point(5, 9)
        Me.lblLeaderboardTitle.Name = "lblLeaderboardTitle"
        Me.lblLeaderboardTitle.Size = New System.Drawing.Size(230, 38)
        Me.lblLeaderboardTitle.TabIndex = 2
        Me.lblLeaderboardTitle.Text = "Leaderboard"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(11, 61)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(115, 13)
        Me.lblKey.TabIndex = 3
        Me.lblKey.Text = "Score, Difficulty, Name"
        '
        'frmLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 471)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblLeaderboardTitle)
        Me.Controls.Add(Me.btnReturnFromLeaderboard)
        Me.Controls.Add(Me.lstLeaderboard)
        Me.Name = "frmLeaderboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLeaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLeaderboard As ListBox
    Friend WithEvents btnReturnFromLeaderboard As Button
    Friend WithEvents lblLeaderboardTitle As Label
    Friend WithEvents lblKey As Label
End Class
