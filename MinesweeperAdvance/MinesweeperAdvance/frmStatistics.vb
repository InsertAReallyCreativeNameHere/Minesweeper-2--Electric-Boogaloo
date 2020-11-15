
Public Class frmStatistics
    Private Sub frmLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDifficultyStats.Text = "Overall Stats"
        GenerateStats(True)

    End Sub

    Private Sub btnReturnFromLeaderboard_Click(sender As Object, e As EventArgs) Handles btnReturnFromLeaderboard.Click
        frmTitleScreen.Show()
        Me.Hide()
    End Sub

    Private Sub OverallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverallToolStripMenuItem.Click
        lblDifficultyStats.Text = "Overall Stats"
        GenerateStats(True)
    End Sub
    Public Sub GenerateStats(overall As Boolean, Optional type As GameDifficulty? = Nothing)
        Dim stats = Nothing
        If overall = True Then
            stats = My.Settings.Stats.GetOverallStats()
        Else stats = My.Settings.Stats.GetLevelStats(type)
        End If
        lstStatistics.Items.Clear()
        lstStatistics.Items.Add("High Score: " + stats.HighScore.ToString())
        lstStatistics.Items.Add("Time Played: " + (stats.TimePlayed / 1000).ToString() + " seconds")
        lstStatistics.Items.Add("Flags Placed: " + stats.FlagsPlaced.ToString())
        lstStatistics.Items.Add("Bars Filled: " + stats.BarsFilled.ToString())
        lstStatistics.Items.Add("Games Played: " + stats.GamesPlayed.ToString())
        lstStatistics.Items.Add("Games Won: " + stats.GamesWon.ToString())
        lstStatistics.Items.Add("Games Lost: " + stats.GamesLost.ToString())
    End Sub

    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        lblDifficultyStats.Text = "Easy Stats"
        GenerateStats(False, GameDifficulty.Easy)
    End Sub

    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click
        lblDifficultyStats.Text = "Medium Stats"
        GenerateStats(False, GameDifficulty.Medium)
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        lblDifficultyStats.Text = "Hard Stats"
        GenerateStats(False, GameDifficulty.Hard)
    End Sub

    Private Sub InsaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsaneToolStripMenuItem.Click
        lblDifficultyStats.Text = "Insane Stats"
        GenerateStats(False, GameDifficulty.Insane)
    End Sub
End Class