Public Class frmAchievements
    Dim TilesFlaggedLocal As Integer = My.Settings.Stats.GetOverallStats().FlagsPlaced
    Dim BarsFilledLocal As Integer = My.Settings.Stats.GetOverallStats().BarsFilled
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

    Dim Ach4 As String = "Incomplete"
    Dim Cons4 As String = "Easy"

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
        If (1 >= DifficultyEasyLocal) Then
            Cons4 = "Medium"
            Ach4 = "Easy"
            If (2 >= DifficultyMediumLocal) Then
                Cons4 = "Hard"
                Ach4 = "Medium"
                If (3 >= DifficultyHardLocal) Then
                    Cons4 = "Insane"
                    Ach4 = "Hard"
                    If (4 >= DifficultyInsaneLocal) Then
                        Cons4 = "How"
                        Ach4 = "Insane"
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


End Class

