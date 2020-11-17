Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms
Imports System.Threading.Tasks

Partial Public Class Minesweeper
    Inherits Form
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
        Game.mainForm = Me
        Game.Start()
        RunTimer()
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
End Class