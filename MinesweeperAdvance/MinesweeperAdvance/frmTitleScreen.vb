
Public Class frmTitleScreen

    Private Sub frmTitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmGameSelection.Show()
        Me.Hide()
    End Sub

    Private Sub picTitle2_Click(sender As Object, e As EventArgs) Handles picTitle2.Click

    End Sub

    Private Sub btnAchievements_Click(sender As Object, e As EventArgs) Handles btnAchievements.Click
        frmAchievements.Show()
        Me.Hide()
    End Sub

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        frmLeaderboard.Show()
        Me.Hide()
    End Sub
End Class
Friend NotInheritable Class A
    Public Shared TilesFlagged As Integer = 0
End Class
Friend NotInheritable Class B
    Public Shared BarsFilled As Integer = 0
End Class
Friend NotInheritable Class C
    Public Shared DifficultyEasy As Integer = 0
    Public Shared DifficultyMedium As Integer = 0
    Public Shared DifficultyHard As Integer = 0
    Public Shared DifficultyInsane As Integer = 0
End Class

Friend NotInheritable Class D
    Public Shared Difficulty As Integer = 0
End Class