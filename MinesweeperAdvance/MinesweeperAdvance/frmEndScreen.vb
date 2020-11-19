Imports MinesweeperAdvance.Behaviours

Public Class frmEndScreen
    Public Function CalculateScore(m As Integer, d As Integer, b As Integer, t As Integer)
        Dim Score As Integer = 0
        Score = Math.Round(1000 / (m + 0.5) * d * (b + 1) ^ 2 * (5 - Math.Log(t ^ 0.5, 5)))
        Return Score
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Hide()
        frmTitleScreen.Show()
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Me.Hide()
        frmGameSelection.Show()

    End Sub

    Private Sub frmEndScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Game.gameWon Then
            lblEndTitle.Text = "You Win!"
        Else lblendTitle.Text = "You Lose"
        End If
        lblScore.Text = CalculateScore(0, GameData.Difficulty + 1, GameData.ScanBarsFilled + GameData.ScanBar / 100, GameData.TimeElapsed)
    End Sub


End Class