Public Class frmEndScreen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Hide()
        frmTitleScreen.Show()
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Me.Hide()
        frmGameSelection.Show()
    End Sub
End Class