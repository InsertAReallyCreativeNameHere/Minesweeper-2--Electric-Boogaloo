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
        Me.picFlag1 = New System.Windows.Forms.PictureBox()
        Me.picFlag4 = New System.Windows.Forms.PictureBox()
        Me.picFlag2 = New System.Windows.Forms.PictureBox()
        Me.picFlag3 = New System.Windows.Forms.PictureBox()
        CType(Me.trbDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFlags.SuspendLayout()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbDifficulty
        '
        Me.trbDifficulty.LargeChange = 3
        Me.trbDifficulty.Location = New System.Drawing.Point(96, 50)
        Me.trbDifficulty.Maximum = 3
        Me.trbDifficulty.Name = "trbDifficulty"
        Me.trbDifficulty.Size = New System.Drawing.Size(183, 45)
        Me.trbDifficulty.TabIndex = 1
        '
        'lblDifficullty
        '
        Me.lblDifficullty.AutoSize = True
        Me.lblDifficullty.Location = New System.Drawing.Point(144, 20)
        Me.lblDifficullty.Name = "lblDifficullty"
        Me.lblDifficullty.Size = New System.Drawing.Size(80, 13)
        Me.lblDifficullty.TabIndex = 2
        Me.lblDifficullty.Text = "Select Difficulty"
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Location = New System.Drawing.Point(91, 77)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(30, 13)
        Me.lblEasy.TabIndex = 3
        Me.lblEasy.Text = "Easy"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Location = New System.Drawing.Point(144, 77)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(44, 13)
        Me.lblMedium.TabIndex = 4
        Me.lblMedium.Text = "Medium"
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.Location = New System.Drawing.Point(199, 77)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(30, 13)
        Me.lblHard.TabIndex = 5
        Me.lblHard.Text = "Hard"
        '
        'lblInsane
        '
        Me.lblInsane.AutoSize = True
        Me.lblInsane.Location = New System.Drawing.Point(249, 77)
        Me.lblInsane.Name = "lblInsane"
        Me.lblInsane.Size = New System.Drawing.Size(39, 13)
        Me.lblInsane.TabIndex = 6
        Me.lblInsane.Text = "Insane"
        '
        'lblSelectSkin
        '
        Me.lblSelectSkin.AutoSize = True
        Me.lblSelectSkin.Location = New System.Drawing.Point(144, 124)
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
        Me.btnStartGame.Location = New System.Drawing.Point(194, 280)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(124, 70)
        Me.btnStartGame.TabIndex = 18
        Me.btnStartGame.Text = "Start"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnBackToTitleScreen
        '
        Me.btnBackToTitleScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBackToTitleScreen.Location = New System.Drawing.Point(64, 280)
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
        Me.picMine1.Location = New System.Drawing.Point(41, 224)
        Me.picMine1.Name = "picMine1"
        Me.picMine1.Size = New System.Drawing.Size(50, 50)
        Me.picMine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine1.TabIndex = 14
        Me.picMine1.TabStop = False
        '
        'pnlFlags
        '
        Me.pnlFlags.Controls.Add(Me.picFlag1)
        Me.pnlFlags.Controls.Add(Me.picFlag4)
        Me.pnlFlags.Controls.Add(Me.picFlag2)
        Me.pnlFlags.Controls.Add(Me.picFlag3)
        Me.pnlFlags.Location = New System.Drawing.Point(38, 167)
        Me.pnlFlags.Name = "pnlFlags"
        Me.pnlFlags.Size = New System.Drawing.Size(344, 51)
        Me.pnlFlags.TabIndex = 21
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
        'frmGameSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.pnlFlags)
        Me.Controls.Add(Me.btnBackToTitleScreen)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.lblMineSelect)
        Me.Controls.Add(Me.lblFlagSelect)
        Me.Controls.Add(Me.picMine1)
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
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
