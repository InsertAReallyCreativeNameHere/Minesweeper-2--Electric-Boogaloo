<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameSelection))
        Me.trbDifficulty = New System.Windows.Forms.TrackBar()
        Me.lblDifficullty = New System.Windows.Forms.Label()
        Me.lblEasy = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblHard = New System.Windows.Forms.Label()
        Me.lblInsane = New System.Windows.Forms.Label()
        Me.lblSelectSkin = New System.Windows.Forms.Label()
        Me.lblFlagSelect = New System.Windows.Forms.Label()
        Me.lblMineSelect = New System.Windows.Forms.Label()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnBackToTitleScreen = New System.Windows.Forms.Button()
        Me.picMine1 = New System.Windows.Forms.PictureBox()
        Me.pnlFlags = New System.Windows.Forms.Panel()
        Me.picFlag5 = New System.Windows.Forms.PictureBox()
        Me.picFlag6 = New System.Windows.Forms.PictureBox()
        Me.picFlag7 = New System.Windows.Forms.PictureBox()
        Me.picFlag1 = New System.Windows.Forms.PictureBox()
        Me.picFlag4 = New System.Windows.Forms.PictureBox()
        Me.picFlag2 = New System.Windows.Forms.PictureBox()
        Me.picFlag3 = New System.Windows.Forms.PictureBox()
        Me.pnlMines = New System.Windows.Forms.Panel()
        Me.picMine2 = New System.Windows.Forms.PictureBox()
        Me.picMine3 = New System.Windows.Forms.PictureBox()
        Me.picMine4 = New System.Windows.Forms.PictureBox()
        Me.picQ1 = New System.Windows.Forms.PictureBox()
        Me.picQ2 = New System.Windows.Forms.PictureBox()
        Me.picQ4 = New System.Windows.Forms.PictureBox()
        Me.picQ3 = New System.Windows.Forms.PictureBox()
        Me.picQ6 = New System.Windows.Forms.PictureBox()
        Me.picQ5 = New System.Windows.Forms.PictureBox()
        Me.picQ9 = New System.Windows.Forms.PictureBox()
        Me.picQ8 = New System.Windows.Forms.PictureBox()
        Me.picQ7 = New System.Windows.Forms.PictureBox()
        CType(Me.trbDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFlags.SuspendLayout()
        CType(Me.picFlag5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMines.SuspendLayout()
        CType(Me.picMine2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQ7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbDifficulty
        '
        Me.trbDifficulty.LargeChange = 3
        Me.trbDifficulty.Location = New System.Drawing.Point(153, 52)
        Me.trbDifficulty.Maximum = 3
        Me.trbDifficulty.Name = "trbDifficulty"
        Me.trbDifficulty.Size = New System.Drawing.Size(183, 45)
        Me.trbDifficulty.TabIndex = 1
        '
        'lblDifficullty
        '
        Me.lblDifficullty.AutoSize = True
        Me.lblDifficullty.Location = New System.Drawing.Point(201, 22)
        Me.lblDifficullty.Name = "lblDifficullty"
        Me.lblDifficullty.Size = New System.Drawing.Size(80, 13)
        Me.lblDifficullty.TabIndex = 2
        Me.lblDifficullty.Text = "Select Difficulty"
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Location = New System.Drawing.Point(148, 79)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(30, 13)
        Me.lblEasy.TabIndex = 3
        Me.lblEasy.Text = "Easy"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Location = New System.Drawing.Point(201, 79)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(44, 13)
        Me.lblMedium.TabIndex = 4
        Me.lblMedium.Text = "Medium"
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.Location = New System.Drawing.Point(256, 79)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(30, 13)
        Me.lblHard.TabIndex = 5
        Me.lblHard.Text = "Hard"
        '
        'lblInsane
        '
        Me.lblInsane.AutoSize = True
        Me.lblInsane.Location = New System.Drawing.Point(306, 79)
        Me.lblInsane.Name = "lblInsane"
        Me.lblInsane.Size = New System.Drawing.Size(39, 13)
        Me.lblInsane.TabIndex = 6
        Me.lblInsane.Text = "Insane"
        '
        'lblSelectSkin
        '
        Me.lblSelectSkin.AutoSize = True
        Me.lblSelectSkin.Location = New System.Drawing.Point(201, 126)
        Me.lblSelectSkin.Name = "lblSelectSkin"
        Me.lblSelectSkin.Size = New System.Drawing.Size(66, 13)
        Me.lblSelectSkin.TabIndex = 7
        Me.lblSelectSkin.Text = "Select Skins"
        '
        'lblFlagSelect
        '
        Me.lblFlagSelect.AutoSize = True
        Me.lblFlagSelect.Location = New System.Drawing.Point(5, 187)
        Me.lblFlagSelect.Name = "lblFlagSelect"
        Me.lblFlagSelect.Size = New System.Drawing.Size(27, 13)
        Me.lblFlagSelect.TabIndex = 16
        Me.lblFlagSelect.Text = "Flag"
        '
        'lblMineSelect
        '
        Me.lblMineSelect.AutoSize = True
        Me.lblMineSelect.Location = New System.Drawing.Point(5, 244)
        Me.lblMineSelect.Name = "lblMineSelect"
        Me.lblMineSelect.Size = New System.Drawing.Size(30, 13)
        Me.lblMineSelect.TabIndex = 17
        Me.lblMineSelect.Text = "Mine"
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnStartGame.Location = New System.Drawing.Point(247, 279)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(124, 70)
        Me.btnStartGame.TabIndex = 18
        Me.btnStartGame.Text = "Start"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnBackToTitleScreen
        '
        Me.btnBackToTitleScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBackToTitleScreen.Location = New System.Drawing.Point(117, 279)
        Me.btnBackToTitleScreen.Name = "btnBackToTitleScreen"
        Me.btnBackToTitleScreen.Size = New System.Drawing.Size(124, 70)
        Me.btnBackToTitleScreen.TabIndex = 19
        Me.btnBackToTitleScreen.Text = "Back"
        Me.btnBackToTitleScreen.UseVisualStyleBackColor = True
        '
        'picMine1
        '
        Me.picMine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMine1.Image = CType(resources.GetObject("picMine1.Image"), System.Drawing.Image)
        Me.picMine1.Location = New System.Drawing.Point(3, 0)
        Me.picMine1.Name = "picMine1"
        Me.picMine1.Size = New System.Drawing.Size(50, 50)
        Me.picMine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine1.TabIndex = 14
        Me.picMine1.TabStop = False
        '
        'pnlFlags
        '
        Me.pnlFlags.Controls.Add(Me.picQ6)
        Me.pnlFlags.Controls.Add(Me.picQ5)
        Me.pnlFlags.Controls.Add(Me.picQ4)
        Me.pnlFlags.Controls.Add(Me.picQ3)
        Me.pnlFlags.Controls.Add(Me.picQ2)
        Me.pnlFlags.Controls.Add(Me.picQ1)
        Me.pnlFlags.Controls.Add(Me.picFlag5)
        Me.pnlFlags.Controls.Add(Me.picFlag6)
        Me.pnlFlags.Controls.Add(Me.picFlag7)
        Me.pnlFlags.Controls.Add(Me.picFlag1)
        Me.pnlFlags.Controls.Add(Me.picFlag4)
        Me.pnlFlags.Controls.Add(Me.picFlag2)
        Me.pnlFlags.Controls.Add(Me.picFlag3)
        Me.pnlFlags.Location = New System.Drawing.Point(38, 167)
        Me.pnlFlags.Name = "pnlFlags"
        Me.pnlFlags.Size = New System.Drawing.Size(441, 51)
        Me.pnlFlags.TabIndex = 21
        '
        'picFlag5
        '
        Me.picFlag5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlag5.Image = CType(resources.GetObject("picFlag5.Image"), System.Drawing.Image)
        Me.picFlag5.Location = New System.Drawing.Point(227, 0)
        Me.picFlag5.Name = "picFlag5"
        Me.picFlag5.Size = New System.Drawing.Size(50, 50)
        Me.picFlag5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag5.TabIndex = 25
        Me.picFlag5.TabStop = False
        '
        'picFlag6
        '
        Me.picFlag6.Image = CType(resources.GetObject("picFlag6.Image"), System.Drawing.Image)
        Me.picFlag6.Location = New System.Drawing.Point(283, 0)
        Me.picFlag6.Name = "picFlag6"
        Me.picFlag6.Size = New System.Drawing.Size(50, 50)
        Me.picFlag6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag6.TabIndex = 26
        Me.picFlag6.TabStop = False
        '
        'picFlag7
        '
        Me.picFlag7.Image = CType(resources.GetObject("picFlag7.Image"), System.Drawing.Image)
        Me.picFlag7.Location = New System.Drawing.Point(339, 1)
        Me.picFlag7.Name = "picFlag7"
        Me.picFlag7.Size = New System.Drawing.Size(50, 50)
        Me.picFlag7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag7.TabIndex = 27
        Me.picFlag7.TabStop = False
        '
        'picFlag1
        '
        Me.picFlag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlag1.Image = Global.MinesweeperAdvance.My.Resources.Resources.Flag_Red
        Me.picFlag1.Location = New System.Drawing.Point(3, 1)
        Me.picFlag1.Name = "picFlag1"
        Me.picFlag1.Size = New System.Drawing.Size(50, 50)
        Me.picFlag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag1.TabIndex = 21
        Me.picFlag1.TabStop = False
        '
        'picFlag4
        '
        Me.picFlag4.Image = CType(resources.GetObject("picFlag4.Image"), System.Drawing.Image)
        Me.picFlag4.Location = New System.Drawing.Point(171, 1)
        Me.picFlag4.Name = "picFlag4"
        Me.picFlag4.Size = New System.Drawing.Size(50, 50)
        Me.picFlag4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag4.TabIndex = 24
        Me.picFlag4.TabStop = False
        '
        'picFlag2
        '
        Me.picFlag2.Image = CType(resources.GetObject("picFlag2.Image"), System.Drawing.Image)
        Me.picFlag2.Location = New System.Drawing.Point(59, 1)
        Me.picFlag2.Name = "picFlag2"
        Me.picFlag2.Size = New System.Drawing.Size(50, 50)
        Me.picFlag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag2.TabIndex = 22
        Me.picFlag2.TabStop = False
        '
        'picFlag3
        '
        Me.picFlag3.Image = CType(resources.GetObject("picFlag3.Image"), System.Drawing.Image)
        Me.picFlag3.Location = New System.Drawing.Point(115, 1)
        Me.picFlag3.Name = "picFlag3"
        Me.picFlag3.Size = New System.Drawing.Size(50, 50)
        Me.picFlag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag3.TabIndex = 23
        Me.picFlag3.TabStop = False
        '
        'pnlMines
        '
        Me.pnlMines.Controls.Add(Me.picQ9)
        Me.pnlMines.Controls.Add(Me.picMine2)
        Me.pnlMines.Controls.Add(Me.picMine3)
        Me.pnlMines.Controls.Add(Me.picMine4)
        Me.pnlMines.Controls.Add(Me.picQ8)
        Me.pnlMines.Controls.Add(Me.picMine1)
        Me.pnlMines.Controls.Add(Me.picQ7)
        Me.pnlMines.Location = New System.Drawing.Point(38, 224)
        Me.pnlMines.Name = "pnlMines"
        Me.pnlMines.Size = New System.Drawing.Size(441, 51)
        Me.pnlMines.TabIndex = 28
        '
        'picMine2
        '
        Me.picMine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMine2.Image = CType(resources.GetObject("picMine2.Image"), System.Drawing.Image)
        Me.picMine2.Location = New System.Drawing.Point(59, 0)
        Me.picMine2.Name = "picMine2"
        Me.picMine2.Size = New System.Drawing.Size(50, 50)
        Me.picMine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine2.TabIndex = 24
        Me.picMine2.TabStop = False
        '
        'picMine3
        '
        Me.picMine3.Image = CType(resources.GetObject("picMine3.Image"), System.Drawing.Image)
        Me.picMine3.Location = New System.Drawing.Point(115, 1)
        Me.picMine3.Name = "picMine3"
        Me.picMine3.Size = New System.Drawing.Size(50, 50)
        Me.picMine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine3.TabIndex = 22
        Me.picMine3.TabStop = False
        '
        'picMine4
        '
        Me.picMine4.Image = CType(resources.GetObject("picMine4.Image"), System.Drawing.Image)
        Me.picMine4.Location = New System.Drawing.Point(167, 0)
        Me.picMine4.Name = "picMine4"
        Me.picMine4.Size = New System.Drawing.Size(50, 50)
        Me.picMine4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine4.TabIndex = 23
        Me.picMine4.TabStop = False
        '
        'picQ1
        '
        Me.picQ1.Image = CType(resources.GetObject("picQ1.Image"), System.Drawing.Image)
        Me.picQ1.InitialImage = Nothing
        Me.picQ1.Location = New System.Drawing.Point(59, 1)
        Me.picQ1.Name = "picQ1"
        Me.picQ1.Size = New System.Drawing.Size(50, 50)
        Me.picQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ1.TabIndex = 29
        Me.picQ1.TabStop = False
        '
        'picQ2
        '
        Me.picQ2.Image = CType(resources.GetObject("picQ2.Image"), System.Drawing.Image)
        Me.picQ2.InitialImage = Nothing
        Me.picQ2.Location = New System.Drawing.Point(115, 1)
        Me.picQ2.Name = "picQ2"
        Me.picQ2.Size = New System.Drawing.Size(50, 50)
        Me.picQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ2.TabIndex = 30
        Me.picQ2.TabStop = False
        '
        'picQ4
        '
        Me.picQ4.Image = CType(resources.GetObject("picQ4.Image"), System.Drawing.Image)
        Me.picQ4.InitialImage = Nothing
        Me.picQ4.Location = New System.Drawing.Point(227, 1)
        Me.picQ4.Name = "picQ4"
        Me.picQ4.Size = New System.Drawing.Size(50, 50)
        Me.picQ4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ4.TabIndex = 32
        Me.picQ4.TabStop = False
        '
        'picQ3
        '
        Me.picQ3.Image = CType(resources.GetObject("picQ3.Image"), System.Drawing.Image)
        Me.picQ3.InitialImage = Nothing
        Me.picQ3.Location = New System.Drawing.Point(171, 0)
        Me.picQ3.Name = "picQ3"
        Me.picQ3.Size = New System.Drawing.Size(50, 50)
        Me.picQ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ3.TabIndex = 31
        Me.picQ3.TabStop = False
        '
        'picQ6
        '
        Me.picQ6.Image = CType(resources.GetObject("picQ6.Image"), System.Drawing.Image)
        Me.picQ6.InitialImage = Nothing
        Me.picQ6.Location = New System.Drawing.Point(339, 0)
        Me.picQ6.Name = "picQ6"
        Me.picQ6.Size = New System.Drawing.Size(50, 50)
        Me.picQ6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ6.TabIndex = 34
        Me.picQ6.TabStop = False
        '
        'picQ5
        '
        Me.picQ5.Image = CType(resources.GetObject("picQ5.Image"), System.Drawing.Image)
        Me.picQ5.InitialImage = Nothing
        Me.picQ5.Location = New System.Drawing.Point(283, 0)
        Me.picQ5.Name = "picQ5"
        Me.picQ5.Size = New System.Drawing.Size(50, 50)
        Me.picQ5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ5.TabIndex = 33
        Me.picQ5.TabStop = False
        '
        'picQ9
        '
        Me.picQ9.Image = CType(resources.GetObject("picQ9.Image"), System.Drawing.Image)
        Me.picQ9.InitialImage = Nothing
        Me.picQ9.Location = New System.Drawing.Point(166, 1)
        Me.picQ9.Name = "picQ9"
        Me.picQ9.Size = New System.Drawing.Size(50, 50)
        Me.picQ9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ9.TabIndex = 37
        Me.picQ9.TabStop = False
        '
        'picQ8
        '
        Me.picQ8.Image = CType(resources.GetObject("picQ8.Image"), System.Drawing.Image)
        Me.picQ8.InitialImage = Nothing
        Me.picQ8.Location = New System.Drawing.Point(115, 0)
        Me.picQ8.Name = "picQ8"
        Me.picQ8.Size = New System.Drawing.Size(50, 50)
        Me.picQ8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ8.TabIndex = 36
        Me.picQ8.TabStop = False
        '
        'picQ7
        '
        Me.picQ7.Image = CType(resources.GetObject("picQ7.Image"), System.Drawing.Image)
        Me.picQ7.InitialImage = Nothing
        Me.picQ7.Location = New System.Drawing.Point(59, -1)
        Me.picQ7.Name = "picQ7"
        Me.picQ7.Size = New System.Drawing.Size(50, 50)
        Me.picQ7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQ7.TabIndex = 35
        Me.picQ7.TabStop = False
        '
        'frmGameSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.pnlMines)
        Me.Controls.Add(Me.pnlFlags)
        Me.Controls.Add(Me.btnBackToTitleScreen)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.lblMineSelect)
        Me.Controls.Add(Me.lblFlagSelect)
        Me.Controls.Add(Me.lblSelectSkin)
        Me.Controls.Add(Me.lblInsane)
        Me.Controls.Add(Me.lblHard)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblEasy)
        Me.Controls.Add(Me.lblDifficullty)
        Me.Controls.Add(Me.trbDifficulty)
        Me.Name = "frmGameSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameSelection"
        CType(Me.trbDifficulty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFlags.ResumeLayout(False)
        CType(Me.picFlag5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMines.ResumeLayout(False)
        CType(Me.picMine2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQ7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trbDifficulty As TrackBar
    Friend WithEvents lblDifficullty As Label
    Friend WithEvents lblEasy As Label
    Friend WithEvents lblMedium As Label
    Friend WithEvents lblHard As Label
    Friend WithEvents lblInsane As Label
    Friend WithEvents lblSelectSkin As Label
    Friend WithEvents picMine1 As PictureBox
    Friend WithEvents lblFlagSelect As Label
    Friend WithEvents lblMineSelect As Label
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnBackToTitleScreen As Button
    Friend WithEvents pnlFlags As Panel
    Friend WithEvents picFlag1 As PictureBox
    Friend WithEvents picFlag4 As PictureBox
    Friend WithEvents picFlag2 As PictureBox
    Friend WithEvents picFlag3 As PictureBox
    Friend WithEvents picFlag5 As PictureBox
    Friend WithEvents picFlag6 As PictureBox
    Friend WithEvents picFlag7 As PictureBox
    Friend WithEvents pnlMines As Panel
    Friend WithEvents picMine2 As PictureBox
    Friend WithEvents picMine3 As PictureBox
    Friend WithEvents picMine4 As PictureBox
    Friend WithEvents picQ1 As PictureBox
    Friend WithEvents picQ6 As PictureBox
    Friend WithEvents picQ5 As PictureBox
    Friend WithEvents picQ4 As PictureBox
    Friend WithEvents picQ3 As PictureBox
    Friend WithEvents picQ2 As PictureBox
    Friend WithEvents picQ9 As PictureBox
    Friend WithEvents picQ8 As PictureBox
    Friend WithEvents picQ7 As PictureBox
End Class
