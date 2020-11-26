Imports MinesweeperAdvance.Behaviours

Public Class frmEndScreen
    Public Function CalculateScore(m As Integer, d As Integer, b As Integer, t As Integer)
        Dim Score As Integer = Math.Round(1000 / (m + 0.5) * d * (b + 1) ^ 2 * (5 - Math.Log(t ^ 0.5, 5)))
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
        Dim GameWon As Boolean = Nothing
        If Game.gameWon Then
            lblEndTitle.Text = "You Win!"
        Else lblEndTitle.Text = "You Lose"
        End If
        Dim Score As Integer = CalculateScore(GameData.TotalFlagsNeeded - GameData.FlagsCorrectlyPlaced, GameData.Difficulty + 1, GameData.ScanBarsFilled + GameData.ScanBar / 100, GameData.TimeElapsed)
        lblScore.Text = Score
        If GameData.TotalFlagsNeeded = GameData.FlagsCorrectlyPlaced Then
            GameWon = True
        Else GameWon = False
        End If
        'I commented the below line since it will permentaley start changing stats, so until the game if fully functional, it shouldn't run
        'My.Settings.Stats.AddGameStats(GameWon, Score, GameData.TimeElapsed, GameData.FlagsPlaced, GameData.ScanBarsFilled)
        'My.Settings.Save()
    End Sub



End Class