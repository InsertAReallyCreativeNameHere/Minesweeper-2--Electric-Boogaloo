Public Class frmAchievements
    Dim Ach1 As Integer = AA.Achievements1
    Dim Cons1 As Integer = BA.Constant1


    Private Sub btnBackAchievements_Click(sender As Object, e As EventArgs) Handles btnBackAchievements.Click
        Me.Hide()
        frmTitleScreen.Show()

    End Sub

    Private Sub frmAchievements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Ach1 As Integer = 10
        Dim Cons1 As Integer = 100
        lblAchievements1.Text = Ach1 & ", " & Cons1






    End Sub
End Class

