<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitleScreen
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAchievements = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picTitle2 = New System.Windows.Forms.PictureBox()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnStart.Location = New System.Drawing.Point(120, 255)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(284, 108)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnLeaderboard.Location = New System.Drawing.Point(412, 255)
        Me.btnLeaderboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(284, 108)
        Me.btnLeaderboard.TabIndex = 1
        Me.btnLeaderboard.Text = "Statistics"
        Me.btnLeaderboard.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnQuit.Location = New System.Drawing.Point(120, 368)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(284, 108)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAchievements
        '
        Me.btnAchievements.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAchievements.Location = New System.Drawing.Point(412, 368)
        Me.btnAchievements.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAchievements.Name = "btnAchievements"
        Me.btnAchievements.Size = New System.Drawing.Size(284, 108)
        Me.btnAchievements.TabIndex = 3
        Me.btnAchievements.Text = "Achievements"
        Me.btnAchievements.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(105, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(630, 118)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Minesweeper 2"
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(172, 114)
        Me.lblTitle2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(495, 71)
        Me.lblTitle2.TabIndex = 5
        Me.lblTitle2.Text = "Electric    Boogaloo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinesweeperAdvance.My.Resources.Resources.Mine_Standard
        Me.PictureBox1.Location = New System.Drawing.Point(712, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'picTitle2
        '
        Me.picTitle2.Image = Global.MinesweeperAdvance.My.Resources.Resources.Flag_Red
        Me.picTitle2.Location = New System.Drawing.Point(45, 28)
        Me.picTitle2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picTitle2.Name = "picTitle2"
        Me.picTitle2.Size = New System.Drawing.Size(75, 77)
        Me.picTitle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle2.TabIndex = 7
        Me.picTitle2.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picTitle.Image = Global.MinesweeperAdvance.My.Resources.Resources.PngItem_5620292
        Me.picTitle.Location = New System.Drawing.Point(362, 117)
        Me.picTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(46, 52)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 6
        Me.picTitle.TabStop = False
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(806, 518)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picTitle2)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAchievements)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTitleScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper 2: Electric Boogaloo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnLeaderboard As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnAchievements As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents picTitle2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
