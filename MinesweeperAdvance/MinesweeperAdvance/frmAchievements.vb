Public Class frmAchievements
    Dim Ach1 As Integer = 0
    Dim Cons1 As Integer = 1

    Dim Ach2 As Integer = 0
    Dim Cons2 As Integer = 1

    Dim Ach3 As Integer = 0
    Dim Cons3 As Integer = 1

    Dim Ach4 As Integer = 0
    Dim Cons4 As Integer = 1

    Dim Ach5 As Integer = 0
    Dim Cons5 As Integer = 1

    Dim Ach6 As Integer = 0
    Dim Cons6 As Integer = 1

    Dim Ach7 As Integer = 0
    Dim Cons7 As Integer = 1

    Dim Ach8 As Integer = 0
    Dim Cons8 As Integer = 1

    Dim Ach9 As Integer = 0
    Dim Cons9 As Integer = 1

    Private Sub btnBackAchievements_Click(sender As Object, e As EventArgs) Handles btnBackAchievements.Click
        Me.Hide()
        frmTitleScreen.Show()

    End Sub

    Private Sub frmAchievements_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblAchievements1.Text = Ach1 & " / " & Cons1

        lblAchievements2.Text = Ach2 & " / " & Cons2

        lblAchievements3.Text = Ach3 & " / " & Cons3

        lblAchievements4.Text = Ach4 & " / " & Cons4

        lblAchievements5.Text = Ach5 & " / " & Cons5

        lblAchievements6.Text = Ach6 & " / " & Cons6

        lblAchievements7.Text = Ach7 & " / " & Cons7

        lblAchievements8.Text = Ach8 & " / " & Cons8

        lblAchievements9.Text = Ach9 & " / " & Cons9
    End Sub
End Class

