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
        Me.SuspendLayout()
        '
        'lblTimeElapsedHeading
        '
        Me.lblTimeElapsedHeading.AutoSize = True
        Me.lblTimeElapsedHeading.BackColor = System.Drawing.Color.DimGray
        Me.lblTimeElapsedHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeElapsedHeading.ForeColor = System.Drawing.Color.White
        Me.lblTimeElapsedHeading.Location = New System.Drawing.Point(386, 9)
        Me.lblTimeElapsedHeading.Name = "lblTimeElapsedHeading"
        Me.lblTimeElapsedHeading.Size = New System.Drawing.Size(52, 20)
        Me.lblTimeElapsedHeading.TabIndex = 0
        Me.lblTimeElapsedHeading.Text = "Time:"
        '
        'tmrGameTime
        '
        Me.tmrGameTime.Interval = 1
        '
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.AutoSize = True
        Me.lblTimeElapsed.BackColor = System.Drawing.Color.Black
        Me.lblTimeElapsed.ForeColor = System.Drawing.Color.White
        Me.lblTimeElapsed.Location = New System.Drawing.Point(393, 36)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(39, 13)
        Me.lblTimeElapsed.TabIndex = 1
        Me.lblTimeElapsed.Text = "Label1"
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Location = New System.Drawing.Point(375, 277)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(75, 50)
        Me.btnQuitGame.TabIndex = 2
        Me.btnQuitGame.Text = "Quit"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 371)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.lblTimeElapsed)
        Me.Controls.Add(Me.lblTimeElapsedHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Minesweeper"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MinesweeperAdvance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeElapsedHeading As Label
    Friend WithEvents tmrGameTime As Timer
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents btnQuitGame As Button
End Class
