﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitleScreen))
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
        Me.btnStart.Location = New System.Drawing.Point(80, 166)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(189, 70)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnLeaderboard.Location = New System.Drawing.Point(275, 166)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(189, 70)
        Me.btnLeaderboard.TabIndex = 1
        Me.btnLeaderboard.Text = "Statistics"
        Me.btnLeaderboard.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnQuit.Location = New System.Drawing.Point(80, 239)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(189, 70)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAchievements
        '
        Me.btnAchievements.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAchievements.Location = New System.Drawing.Point(275, 239)
        Me.btnAchievements.Name = "btnAchievements"
        Me.btnAchievements.Size = New System.Drawing.Size(189, 70)
        Me.btnAchievements.TabIndex = 3
        Me.btnAchievements.Text = "Achievements"
        Me.btnAchievements.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(70, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(420, 77)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Minesweeper 2"
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(115, 74)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(330, 46)
        Me.lblTitle2.TabIndex = 5
        Me.lblTitle2.Text = "Electric    Boogaloo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(475, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'picTitle2
        '
        Me.picTitle2.Image = Global.MinesweeperAdvance.My.Resources.Resources.Flag_Red
        Me.picTitle2.Location = New System.Drawing.Point(30, 18)
        Me.picTitle2.Name = "picTitle2"
        Me.picTitle2.Size = New System.Drawing.Size(50, 50)
        Me.picTitle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle2.TabIndex = 7
        Me.picTitle2.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picTitle.Image = Global.MinesweeperAdvance.My.Resources.Resources.PngItem_5620292
        Me.picTitle.Location = New System.Drawing.Point(241, 76)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(31, 34)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 6
        Me.picTitle.TabStop = False
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(537, 337)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picTitle2)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAchievements)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.btnStart)
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
