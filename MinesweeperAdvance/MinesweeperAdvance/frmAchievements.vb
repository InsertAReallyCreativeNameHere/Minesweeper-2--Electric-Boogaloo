Public Class frmAchievements
    Dim TilesFlaggedLocal As Integer

    Dim Ach1 As Integer = 0 + TilesFlaggedLocal
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
        If (Ach1 >= Cons1) Then
            Cons1 *= 10
        End If
        lblAchievements2.Text = Ach2 & " / " & Cons2
        If (Ach2 >= Cons2) Then
            Cons2 *= 10
        End If
        lblAchievements3.Text = Ach3 & " / " & Cons3
        If (Ach3 >= Cons3) Then
            Cons3 *= 10
        End If
        lblAchievements4.Text = Ach4 & " / " & Cons4
        If (Ach4 >= Cons4) Then
            Cons4 *= 10
        End If
        lblAchievements5.Text = Ach5 & " / " & Cons5
        If (Ach5 >= Cons5) Then
            Cons5 *= 10
        End If
        lblAchievements6.Text = Ach6 & " / " & Cons6
        If (Ach6 >= Cons6) Then
            Cons6 *= 10
        End If
        lblAchievements7.Text = Ach7 & " / " & Cons7
        If (Ach7 >= Cons7) Then
            Cons7 *= 10
        End If
        lblAchievements8.Text = Ach8 & " / " & Cons8
        If (Ach8 >= Cons8) Then
            Cons8 *= 10
        End If
        lblAchievements9.Text = Ach9 & " / " & Cons9
        If (Ach9 >= Cons9) Then
            Cons9 *= 10
        End If
    End Sub
End Class

