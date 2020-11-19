<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndScreen
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
        Me.lblEndTitle = New System.Windows.Forms.Label()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEndTitle
        '
        Me.lblEndTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTitle.Location = New System.Drawing.Point(-16, 9)
        Me.lblEndTitle.Name = "lblEndTitle"
        Me.lblEndTitle.Size = New System.Drawing.Size(367, 52)
        Me.lblEndTitle.TabIndex = 0
        Me.lblEndTitle.Text = "Label1"
        Me.lblEndTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.Location = New System.Drawing.Point(6, 106)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(138, 52)
        Me.lblScoreTitle.TabIndex = 1
        Me.lblScoreTitle.Text = "Score:"
        Me.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRetry
        '
        Me.btnRetry.Location = New System.Drawing.Point(13, 208)
        Me.btnRetry.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(151, 84)
        Me.btnRetry.TabIndex = 3
        Me.btnRetry.Text = "Play Again"
        Me.btnRetry.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(168, 208)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(151, 84)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Back to Title Screen"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(133, 106)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(209, 52)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "000000"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEndScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTitle)
        Me.Controls.Add(Me.lblEndTitle)
        Me.Name = "frmEndScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEndScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEndTitle As Label
    Friend WithEvents lblScoreTitle As Label
    Friend WithEvents btnRetry As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblScore As Label
End Class
