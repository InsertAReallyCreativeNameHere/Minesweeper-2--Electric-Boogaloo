<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minesweeper
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTimeElapsedHeading = New System.Windows.Forms.Label()
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeElapsed = New System.Windows.Forms.Label()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.lblDisplayCurrentDifficulty = New System.Windows.Forms.Label()
        Me.lblDifficultyTiltle = New System.Windows.Forms.Label()
        Me.lblTilesFlagged = New System.Windows.Forms.Label()
        Me.lblScanBar = New System.Windows.Forms.Label()
        Me.lblFlagsLeft = New System.Windows.Forms.Label()
        Me.picFlagsLeft = New System.Windows.Forms.PictureBox()
        CType(Me.picFlagsLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimeElapsedHeading
        '
        Me.lblTimeElapsedHeading.AutoSize = True
        Me.lblTimeElapsedHeading.BackColor = System.Drawing.Color.DimGray
        Me.lblTimeElapsedHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeElapsedHeading.ForeColor = System.Drawing.Color.White
        Me.lblTimeElapsedHeading.Location = New System.Drawing.Point(381, 14)
        Me.lblTimeElapsedHeading.Name = "lblTimeElapsedHeading"
        Me.lblTimeElapsedHeading.Size = New System.Drawing.Size(52, 20)
        Me.lblTimeElapsedHeading.TabIndex = 0
        Me.lblTimeElapsedHeading.Text = "Time:"
        Me.lblTimeElapsedHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrGameTime
        '
        Me.tmrGameTime.Interval = 1
        '
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.BackColor = System.Drawing.Color.Black
        Me.lblTimeElapsed.ForeColor = System.Drawing.Color.White
        Me.lblTimeElapsed.Location = New System.Drawing.Point(388, 47)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(39, 13)
        Me.lblTimeElapsed.TabIndex = 1
        Me.lblTimeElapsed.Text = "0"
        Me.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Location = New System.Drawing.Point(370, 309)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(75, 50)
        Me.btnQuitGame.TabIndex = 2
        Me.btnQuitGame.Text = "Quit"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'lblDisplayCurrentDifficulty
        '
        Me.lblDisplayCurrentDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayCurrentDifficulty.ForeColor = System.Drawing.Color.White
        Me.lblDisplayCurrentDifficulty.Location = New System.Drawing.Point(368, 92)
        Me.lblDisplayCurrentDifficulty.Name = "lblDisplayCurrentDifficulty"
        Me.lblDisplayCurrentDifficulty.Size = New System.Drawing.Size(82, 20)
        Me.lblDisplayCurrentDifficulty.TabIndex = 3
        Me.lblDisplayCurrentDifficulty.Text = "Easy"
        Me.lblDisplayCurrentDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDifficultyTiltle
        '
        Me.lblDifficultyTiltle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyTiltle.ForeColor = System.Drawing.Color.White
        Me.lblDifficultyTiltle.Location = New System.Drawing.Point(368, 72)
        Me.lblDifficultyTiltle.Name = "lblDifficultyTiltle"
        Me.lblDifficultyTiltle.Size = New System.Drawing.Size(82, 20)
        Me.lblDifficultyTiltle.TabIndex = 4
        Me.lblDifficultyTiltle.Text = "Difficulty:"
        Me.lblDifficultyTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTilesFlagged
        '
        Me.lblTilesFlagged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTilesFlagged.ForeColor = System.Drawing.Color.White
        Me.lblTilesFlagged.Location = New System.Drawing.Point(370, 119)
        Me.lblTilesFlagged.Name = "lblTilesFlagged"
        Me.lblTilesFlagged.Size = New System.Drawing.Size(83, 48)
        Me.lblTilesFlagged.TabIndex = 5
        Me.lblTilesFlagged.Text = "Flags Needed:"
        Me.lblTilesFlagged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScanBar
        '
        Me.lblScanBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanBar.ForeColor = System.Drawing.Color.White
        Me.lblScanBar.Location = New System.Drawing.Point(370, 198)
        Me.lblScanBar.Name = "lblScanBar"
        Me.lblScanBar.Size = New System.Drawing.Size(86, 64)
        Me.lblScanBar.TabIndex = 6
        Me.lblScanBar.Text = "Scan Bar Progress"
        Me.lblScanBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFlagsLeft
        '
        Me.lblFlagsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlagsLeft.ForeColor = System.Drawing.Color.White
        Me.lblFlagsLeft.Location = New System.Drawing.Point(385, 173)
        Me.lblFlagsLeft.Name = "lblFlagsLeft"
        Me.lblFlagsLeft.Size = New System.Drawing.Size(31, 20)
        Me.lblFlagsLeft.TabIndex = 7
        Me.lblFlagsLeft.Text = "10"
        Me.lblFlagsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFlagsLeft
        '
        Me.picFlagsLeft.Location = New System.Drawing.Point(413, 175)
        Me.picFlagsLeft.Name = "picFlagsLeft"
        Me.picFlagsLeft.Size = New System.Drawing.Size(20, 20)
        Me.picFlagsLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlagsLeft.TabIndex = 8
        Me.picFlagsLeft.TabStop = False
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 371)
        Me.Controls.Add(Me.picFlagsLeft)
        Me.Controls.Add(Me.lblFlagsLeft)
        Me.Controls.Add(Me.lblScanBar)
        Me.Controls.Add(Me.lblTilesFlagged)
        Me.Controls.Add(Me.lblDifficultyTiltle)
        Me.Controls.Add(Me.lblDisplayCurrentDifficulty)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.lblTimeElapsed)
        Me.Controls.Add(Me.lblTimeElapsedHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Minesweeper"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MinesweeperAdvance"
        CType(Me.picFlagsLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeElapsedHeading As Label
    Friend WithEvents tmrGameTime As Timer
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents btnQuitGame As Button
    Friend WithEvents lblDisplayCurrentDifficulty As Label
    Friend WithEvents lblDifficultyTiltle As Label
    Friend WithEvents lblTilesFlagged As Label
    Friend WithEvents lblScanBar As Label
    Friend WithEvents lblFlagsLeft As Label
    Friend WithEvents picFlagsLeft As PictureBox
End Class
