Public Class frmAchievements
    Dim Ach1 As Integer = DB.Achievements1

    Private Sub btnBackAchievements_Click(sender As Object, e As EventArgs) Handles btnBackAchievements.Click
        Me.Hide()
        frmTitleScreen.Show()

    End Sub

    Private Sub frmAchievements_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAchievements1.Text = Ach1 / 1
    End Sub
End Class

