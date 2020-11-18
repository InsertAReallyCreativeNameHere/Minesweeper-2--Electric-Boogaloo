Imports MinesweeperAdvance.Behaviours

Public Class frmEndScreen
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
    End Sub
End Class