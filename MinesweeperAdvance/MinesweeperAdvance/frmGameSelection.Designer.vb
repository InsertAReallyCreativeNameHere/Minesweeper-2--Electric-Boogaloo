﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblDifficullty = New System.Windows.Forms.Label()
        Me.lblEasy = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblHard = New System.Windows.Forms.Label()
        Me.lblInsane = New System.Windows.Forms.Label()
        Me.lblSelectSkin = New System.Windows.Forms.Label()
        Me.picFlag1 = New System.Windows.Forms.PictureBox()
        Me.picFlag2 = New System.Windows.Forms.PictureBox()
        Me.picFlag3 = New System.Windows.Forms.PictureBox()
        Me.picMine1 = New System.Windows.Forms.PictureBox()
        Me.lblFlagSelect = New System.Windows.Forms.Label()
        Me.lblMineSelect = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 3
        Me.TrackBar1.Location = New System.Drawing.Point(96, 50)
        Me.TrackBar1.Maximum = 3
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(183, 45)
        Me.TrackBar1.TabIndex = 1
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
        'picFlag1
        '
        Me.picFlag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlag1.Image = Global.MinesweeperAdvance.My.Resources.Resources.Flag_Red
        Me.picFlag1.Location = New System.Drawing.Point(38, 168)
        Me.picFlag1.Name = "picFlag1"
        Me.picFlag1.Size = New System.Drawing.Size(50, 50)
        Me.picFlag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag1.TabIndex = 8
        Me.picFlag1.TabStop = False
        '
        'picFlag2
        '
        Me.picFlag2.Image = CType(resources.GetObject("picFlag2.Image"), System.Drawing.Image)
        Me.picFlag2.Location = New System.Drawing.Point(94, 168)
        Me.picFlag2.Name = "picFlag2"
        Me.picFlag2.Size = New System.Drawing.Size(50, 50)
        Me.picFlag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag2.TabIndex = 9
        Me.picFlag2.TabStop = False
        '
        'picFlag3
        '
        Me.picFlag3.Image = CType(resources.GetObject("picFlag3.Image"), System.Drawing.Image)
        Me.picFlag3.Location = New System.Drawing.Point(150, 168)
        Me.picFlag3.Name = "picFlag3"
        Me.picFlag3.Size = New System.Drawing.Size(50, 50)
        Me.picFlag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag3.TabIndex = 10
        Me.picFlag3.TabStop = False
        '
        'picMine1
        '
        Me.picMine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMine1.Image = CType(resources.GetObject("picMine1.Image"), System.Drawing.Image)
        Me.picMine1.Location = New System.Drawing.Point(38, 224)
        Me.picMine1.Name = "picMine1"
        Me.picMine1.Size = New System.Drawing.Size(50, 50)
        Me.picMine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMine1.TabIndex = 14
        Me.picMine1.TabStop = False
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
        'frmGameSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
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
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "frmGameSelection"
        Me.Text = "frmGameSelection"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
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
End Class