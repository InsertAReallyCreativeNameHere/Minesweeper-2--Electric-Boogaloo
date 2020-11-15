<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Me.btnReturnFromLeaderboard = New System.Windows.Forms.Button()
        Me.lblSatisticsTitle = New System.Windows.Forms.Label()
        Me.mnuStatisticsNavigation = New System.Windows.Forms.MenuStrip()
        Me.OverallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstStatistics = New System.Windows.Forms.ListBox()
        Me.lblDifficultyStats = New System.Windows.Forms.Label()
        Me.mnuStatisticsNavigation.SuspendLayout()
        Me.SuspendLayout()
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
        'lblSatisticsTitle
        '
        Me.lblSatisticsTitle.AutoSize = True
        Me.lblSatisticsTitle.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblSatisticsTitle.Location = New System.Drawing.Point(19, 9)
        Me.lblSatisticsTitle.Name = "lblSatisticsTitle"
        Me.lblSatisticsTitle.Size = New System.Drawing.Size(209, 46)
        Me.lblSatisticsTitle.TabIndex = 2
        Me.lblSatisticsTitle.Text = "Statistics"
        '
        'mnuStatisticsNavigation
        '
        Me.mnuStatisticsNavigation.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuStatisticsNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverallToolStripMenuItem, Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HardToolStripMenuItem, Me.InsaneToolStripMenuItem})
        Me.mnuStatisticsNavigation.Location = New System.Drawing.Point(-7, 55)
        Me.mnuStatisticsNavigation.Name = "mnuStatisticsNavigation"
        Me.mnuStatisticsNavigation.Size = New System.Drawing.Size(248, 24)
        Me.mnuStatisticsNavigation.TabIndex = 6
        Me.mnuStatisticsNavigation.Text = "MenuStrip1"
        '
        'OverallToolStripMenuItem
        '
        Me.OverallToolStripMenuItem.Name = "OverallToolStripMenuItem"
        Me.OverallToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OverallToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.OverallToolStripMenuItem.Text = "Overall"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'InsaneToolStripMenuItem
        '
        Me.InsaneToolStripMenuItem.Name = "InsaneToolStripMenuItem"
        Me.InsaneToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InsaneToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.InsaneToolStripMenuItem.Text = "Insane"
        '
        'lstStatistics
        '
        Me.lstStatistics.FormattingEnabled = True
        Me.lstStatistics.Location = New System.Drawing.Point(32, 118)
        Me.lstStatistics.Name = "lstStatistics"
        Me.lstStatistics.Size = New System.Drawing.Size(167, 264)
        Me.lstStatistics.TabIndex = 7
        '
        'lblDifficultyStats
        '
        Me.lblDifficultyStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblDifficultyStats.Location = New System.Drawing.Point(32, 83)
        Me.lblDifficultyStats.Name = "lblDifficultyStats"
        Me.lblDifficultyStats.Size = New System.Drawing.Size(167, 30)
        Me.lblDifficultyStats.TabIndex = 8
        Me.lblDifficultyStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 471)
        Me.Controls.Add(Me.lblDifficultyStats)
        Me.Controls.Add(Me.lstStatistics)
        Me.Controls.Add(Me.lblSatisticsTitle)
        Me.Controls.Add(Me.btnReturnFromLeaderboard)
        Me.Controls.Add(Me.mnuStatisticsNavigation)
        Me.MainMenuStrip = Me.mnuStatisticsNavigation
        Me.Name = "frmStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        Me.mnuStatisticsNavigation.ResumeLayout(False)
        Me.mnuStatisticsNavigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturnFromLeaderboard As Button
    Friend WithEvents lblSatisticsTitle As Label
    Friend WithEvents mnuStatisticsNavigation As MenuStrip
    Friend WithEvents OverallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsaneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstStatistics As ListBox
    Friend WithEvents lblDifficultyStats As Label
End Class
