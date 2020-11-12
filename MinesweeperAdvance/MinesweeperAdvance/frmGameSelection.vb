Public Class frmGameSelection



    Private Sub picFlag1_Click(sender As Object, e As EventArgs) Handles picFlag1.Click
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub picFlag2_Click(sender As Object, e As EventArgs) Handles picFlag2.Click
        picFlag2.BorderStyle = BorderStyle.FixedSingle
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picFlag3_Click(sender As Object, e As EventArgs) Handles picFlag3.Click
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.FixedSingle
        picFlag1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub trbDifficulty_Scroll(sender As Object, e As EventArgs) Handles trbDifficulty.Scroll
        Dim difficulty As Integer = DB.Difficulty
        difficulty = trbDifficulty.Value
        Console.WriteLine(difficulty)
        Console.ReadLine()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Me.Hide()
        Minesweeper.Show()
    End Sub

    Private Sub btnBackToTitleScreen_Click(sender As Object, e As EventArgs) Handles btnBackToTitleScreen.Click
        Me.Hide()
        frmTitleScreen.Show()
    End Sub
End Class