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
End Class