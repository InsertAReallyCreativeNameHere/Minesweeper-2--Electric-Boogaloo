Public Class frmAchievements
    Dim Ach1 As Integer = AA.Achievements1
    Dim Cons1 As Integer = BA.Constant1

    Dim Ach2 As Integer = AB.Achievements2
    Dim Cons2 As Integer = BB.Constant2

    Dim Ach3 As Integer = AC.Achievements3
    Dim Cons3 As Integer = BC.Constant3

    Dim Ach4 As Integer = AD.Achievements4
    Dim Cons4 As Integer = BD.Constant4

    Dim Ach5 As Integer = AE.Achievements5
    Dim Cons5 As Integer = BE.Constant5

    Dim Ach6 As Integer = AF.Achievements6
    Dim Cons6 As Integer = BF.Constant6

    Dim Ach7 As Integer = AG.Achievements7
    Dim Cons7 As Integer = BG.Constant7

    Dim Ach8 As Integer = AH.Achievements8
    Dim Cons8 As Integer = BH.Constant8

    Dim Ach9 As Integer = AI.Achievements9
    Dim Cons9 As Integer = BI.Constant9

    Private Sub btnBackAchievements_Click(sender As Object, e As EventArgs) Handles btnBackAchievements.Click
        Me.Hide()
        frmTitleScreen.Show()

    End Sub

    Private Sub frmAchievements_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblAchievements1.Text = Ach1 & " / " & Cons1

        lblAchievements2.Text = Ach1 & " / " & Cons1

        lblAchievements3.Text = Ach1 & " / " & Cons1

        lblAchievements4.Text = Ach1 & " / " & Cons1

        lblAchievements5.Text = Ach1 & " / " & Cons1

        lblAchievements6.Text = Ach1 & " / " & Cons1

        lblAchievements7.Text = Ach1 & " / " & Cons1

        lblAchievements8.Text = Ach1 & " / " & Cons1

        lblAchievements9.Text = Ach1 & " / " & Cons1
    End Sub
End Class

