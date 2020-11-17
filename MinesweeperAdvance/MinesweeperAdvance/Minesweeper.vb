Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms
Imports System.Threading.Tasks

Partial Public Class Minesweeper
    Inherits Form
    Dim _totalFlagsNeeded As Integer = 0

    Async Sub RunTimer()
        Await System.Threading.Tasks.Task.Yield()
        tmrGameTime.Enabled = True
        Dim i As Single = 0
        While Game.gameFinished = False
            i += 1
            lblTimeElapsed.Text = Math.Round(i)
            Await Task.Delay(1000)
        End While
    End Sub
    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimeElapsed.BackColor = Color.FromArgb(40, 40, 40)
        lblTimeElapsedHeading.BackColor = Color.FromArgb(40, 40, 40)
        lblDisplayCurrentDifficulty.BackColor = Color.FromArgb(40, 40, 40)
        lblDifficultyTiltle.BackColor = Color.FromArgb(40, 40, 40)
        lblFlagsLeft.BackColor = Color.FromArgb(40, 40, 40)
        lblTilesFlagged.BackColor = Color.FromArgb(40, 40, 40)
        picFlagsLeft.BackColor = Color.FromArgb(40, 40, 40)
        lblScanBar.BackColor = Color.FromArgb(40, 40, 40)
        picFlagsLeft.Image = GameData.FlagSkin
        Game.mainForm = Me
        Game.Start()
        RunTimer()
        Select Case GameData.Difficulty
            Case 0
                lblDisplayCurrentDifficulty.Text = "Easy"
                _totalFlagsNeeded = 10
            Case 1
                lblDisplayCurrentDifficulty.Text = "Medium"
                _totalFlagsNeeded = 15
            Case 2
                lblDisplayCurrentDifficulty.Text = "Hard"
                _totalFlagsNeeded = 20
            Case 3
                lblDisplayCurrentDifficulty.Text = "Insane"
                _totalFlagsNeeded = 25
        End Select
        lblFlagsLeft.Text = _totalFlagsNeeded - GameData.FlagsPlaced
    End Sub

    Private Sub Minesweeper_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub
    Private Sub Minesweeper_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Game.GraphicsUpdate(e)
    End Sub
    Private Sub Minesweeper_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Game.HandleMouseEvent(e)
    End Sub
    Private Sub Minesweeper_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        weed.HandleExit()
        End
    End Sub

    Private Sub Minesweeper_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Click
        If e.Button = MouseButtons.Right Then
            lblFlagsLeft.Text = _totalFlagsNeeded - GameData.FlagsPlaced
        End If
    End Sub
End Class