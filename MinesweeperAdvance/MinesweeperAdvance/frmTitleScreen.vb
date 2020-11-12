Imports MinesweeperAdvance.Behaviours

Public Class frmTitleScreen
    Private Sub frmTitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Minesweeper.Show()
        Me.Hide()
    End Sub

    Private Sub picTitle2_Click(sender As Object, e As EventArgs) Handles picTitle2.Click

    End Sub

    Private Sub btnAchievements_Click(sender As Object, e As EventArgs) Handles btnAchievements.Click
        frmAchievements.Show()
        Me.Hide()
    End Sub
End Class
Friend NotInheritable Class AA
    Public Shared Achievements1 As Integer = 0
End Class
Friend NotInheritable Class BA
    Public Shared Constant1 As Integer = 0
End Class