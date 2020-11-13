Public Class frmAchievements
    Dim TilesFlaggedLocal As Integer
    Dim BarsFilledLocal As Integer
    Dim DifficultyEasyLocal As Integer
    Dim DifficultyMediumLocal As Integer
    Dim DifficultyHardLocal As Integer
    Dim DifficultyInsaneLocal As Integer

    Dim Ach1 As Integer = 0 + TilesFlaggedLocal
    Dim Cons1 As Integer = 10

    Dim Ach2 As Integer = 0 + BarsFilledLocal
    Dim Cons2 As Integer = 1

    Dim Ach3 As Integer = 0
    Dim Cons3 As Integer = 1

    Dim Ach4 As Integer = 0
    Dim Cons4 As String = "Difficulty Easy"

    Dim Ach5 As Integer = 0
    Dim Cons5 As Integer = 50000




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
        If (Ach4 >= DifficultyEasyLocal) Then
            Cons4 = "Difficulty Medium"
            If (Ach4 >= DifficultyMediumLocal) Then
                Cons4 = "Difficulty Hard"
                If (Ach4 >= DifficultyHardLocal) Then
                    Cons4 = "Difficulty Insane"
                    If (Ach4 >= DifficultyInsaneLocal) Then
                        Cons4 = "How"
                    End If
                End If
            End If
        End If
        lblAchievements5.Text = Ach5 & " / " & Cons5
        If (Ach5 >= Cons5) Then
            Cons5 = 100000
            If (Ach5 >= Cons5) Then
                Cons5 = 200000
                If (Ach5 >= Cons5) Then
                    Cons5 = 300000
                End If
            End If
        End If

    End Sub

    Private Sub lblAchievements1_Click(sender As Object, e As EventArgs) Handles lblAchievements1.Click

    End Sub

    Private Sub picAchievements1_Click(sender As Object, e As EventArgs) Handles picAchievements1.Click

    End Sub

    Private Sub lblAchievements2_Click(sender As Object, e As EventArgs) Handles lblAchievements2.Click

    End Sub

    Private Sub picAchievements2_Click(sender As Object, e As EventArgs) Handles picAchievements2.Click

    End Sub

    Private Sub lblAchievements3_Click(sender As Object, e As EventArgs) Handles lblAchievements3.Click

    End Sub

    Private Sub picAchievements3_Click(sender As Object, e As EventArgs) Handles picAchievements3.Click

    End Sub
End Class

