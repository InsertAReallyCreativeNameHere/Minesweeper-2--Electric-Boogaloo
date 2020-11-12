<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameSelection
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
        Me.picFlag3 = New System.Windows.Forms.PictureBox()
        Me.picFlag2 = New System.Windows.Forms.PictureBox()
        Me.picFlag1 = New System.Windows.Forms.PictureBox()
        CType(Me.trbDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbDifficulty
        '
        Me.trbDifficulty.LargeChange = 3
        Me.trbDifficulty.Location = New System.Drawing.Point(144, 77)
        Me.trbDifficulty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trbDifficulty.Maximum = 3
        Me.trbDifficulty.Name = "trbDifficulty"
        Me.trbDifficulty.Size = New System.Drawing.Size(274, 69)
        Me.trbDifficulty.TabIndex = 1
        '
        'lblDifficullty
        '
        Me.lblDifficullty.AutoSize = True
        Me.lblDifficullty.Location = New System.Drawing.Point(216, 31)
        Me.lblDifficullty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDifficullty.Name = "lblDifficullty"
        Me.lblDifficullty.Size = New System.Drawing.Size(118, 20)
        Me.lblDifficullty.TabIndex = 2
        Me.lblDifficullty.Text = "Select Difficulty"
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Location = New System.Drawing.Point(136, 118)
        Me.lblEasy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(44, 20)
        Me.lblEasy.TabIndex = 3
        Me.lblEasy.Text = "Easy"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Location = New System.Drawing.Point(216, 118)
        Me.lblMedium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(65, 20)
        Me.lblMedium.TabIndex = 4
        Me.lblMedium.Text = "Medium"
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.Location = New System.Drawing.Point(298, 118)
        Me.lblHard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(44, 20)
        Me.lblHard.TabIndex = 5
        Me.lblHard.Text = "Hard"
        '
        'lblInsane
        '
        Me.lblInsane.AutoSize = True
        Me.lblInsane.Location = New System.Drawing.Point(374, 118)
        Me.lblInsane.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsane.Name = "lblInsane"
        Me.lblInsane.Size = New System.Drawing.Size(58, 20)
        Me.lblInsane.TabIndex = 6
        Me.lblInsane.Text = "Insane"
        '
        'lblSelectSkin
        '
        Me.lblSelectSkin.AutoSize = True
        Me.lblSelectSkin.Location = New System.Drawing.Point(216, 191)
        Me.lblSelectSkin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectSkin.Name = "lblSelectSkin"
        Me.lblSelectSkin.Size = New System.Drawing.Size(97, 20)
        Me.lblSelectSkin.TabIndex = 7
        Me.lblSelectSkin.Text = "Select Skins"
        '
        'lblFlagSelect
        '
        Me.lblFlagSelect.AutoSize = True
        Me.lblFlagSelect.Location = New System.Drawing.Point(8, 288)
        Me.lblFlagSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFlagSelect.Name = "lblFlagSelect"
        Me.lblFlagSelect.Size = New System.Drawing.Size(40, 20)
        Me.lblFlagSelect.TabIndex = 16
        Me.lblFlagSelect.Text = "Flag"
        '
        'lblMineSelect
        '
        Me.lblMineSelect.AutoSize = True
        Me.lblMineSelect.Location = New System.Drawing.Point(8, 375)
        Me.lblMineSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMineSelect.Name = "lblMineSelect"
        Me.lblMineSelect.Size = New System.Drawing.Size(43, 20)
        Me.lblMineSelect.TabIndex = 17
        Me.lblMineSelect.Text = "Mine"
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnStartGame.Location = New System.Drawing.Point(291, 431)
        Me.btnStartGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(186, 108)
        Me.btnStartGame.TabIndex = 18
        Me.btnStartGame.Text = "Start"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnBackToTitleScreen
        '
        Me.btnBackToTitleScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBackToTitleScreen.Location = New System.Drawing.Point(96, 431)
        Me.btnBackToTitleScreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBackToTitleScreen.Name = "btnBackToTitleScreen"
        Me.btnBackToTitleScreen.Size = New System.Drawing.Size(186, 108)
        Me.btnBackToTitleScreen.TabIndex = 19
        Me.btnBackToTitleScreen.Text = "Back"
        Me.btnBackToTitleScreen.UseVisualStyleBackColor = True
        '
        'picMine1
        '
        Me.picMine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMine1.Image = CType(resources.GetObject("picMine1.Image"), System.Drawing.Image)
        Me.picMine1.Location = New System.Drawing.Point(57, 345)
        Me.picMine1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picMine1.Name = "picMine1"
        Me.picMine1.Size = New System.Drawing.Size(74, 76)
        Me.picMine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine1.TabIndex = 14
        Me.picMine1.TabStop = False
        '
        'picFlag3
        '
        Me.picFlag3.Image = CType(resources.GetObject("picFlag3.Image"), System.Drawing.Image)
        Me.picFlag3.Location = New System.Drawing.Point(225, 258)
        Me.picFlag3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picFlag3.Name = "picFlag3"
        Me.picFlag3.Size = New System.Drawing.Size(75, 77)
        Me.picFlag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag3.TabIndex = 10
        Me.picFlag3.TabStop = False
        '
        'picFlag2
        '
        Me.picFlag2.Image = CType(resources.GetObject("picFlag2.Image"), System.Drawing.Image)
        Me.picFlag2.Location = New System.Drawing.Point(141, 258)
        Me.picFlag2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picFlag2.Name = "picFlag2"
        Me.picFlag2.Size = New System.Drawing.Size(75, 77)
        Me.picFlag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag2.TabIndex = 9
        Me.picFlag2.TabStop = False
        '
        'picFlag1
        '
        Me.picFlag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlag1.Image = Global.MinesweeperAdvance.My.Resources.Resources.Flag_Red
        Me.picFlag1.Location = New System.Drawing.Point(57, 258)
        Me.picFlag1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picFlag1.Name = "picFlag1"
        Me.picFlag1.Size = New System.Drawing.Size(74, 76)
        Me.picFlag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag1.TabIndex = 8
        Me.picFlag1.TabStop = False
        '
        'frmGameSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 555)
        Me.Controls.Add(Me.btnBackToTitleScreen)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.lblMineSelect)
        Me.Controls.Add(Me.lblFlagSelect)
        Me.Controls.Add(Me.picMine1)
        Me.Controls.Add(Me.picFlag3)
        Me.Controls.Add(Me.picFlag2)
        Me.Controls.Add(Me.picFlag1)
        Me.Controls.Add(Me.lblSelectSkin)
        Me.Controls.Add(Me.lblInsane)
        Me.Controls.Add(Me.lblHard)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblEasy)
        Me.Controls.Add(Me.lblDifficullty)
        Me.Controls.Add(Me.trbDifficulty)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmGameSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameSelection"
        CType(Me.trbDifficulty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents picFlag1 As PictureBox
    Friend WithEvents picFlag2 As PictureBox
    Friend WithEvents picFlag3 As PictureBox
    Friend WithEvents picMine1 As PictureBox
    Friend WithEvents lblFlagSelect As Label
    Friend WithEvents lblMineSelect As Label
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnBackToTitleScreen As Button
End Class
