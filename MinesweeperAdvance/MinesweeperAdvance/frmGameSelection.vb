﻿Public Class frmGameSelection
    Private Sub ChangeBorder(currentFlag As Control)
        For Each flag In pnlFlags.Controls
            If currentFlag = flag Then

            End If
        Next
    End Sub


    Private Sub picFlag1_Click(sender As Object, e As EventArgs) Handles picFlag1.Click
        GameData.FlagSkin = picFlag1.Image
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub picFlag2_Click(sender As Object, e As EventArgs) Handles picFlag2.Click
        GameData.FlagSkin = picFlag2.Image
        picFlag2.BorderStyle = BorderStyle.FixedSingle
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picFlag3_Click(sender As Object, e As EventArgs) Handles picFlag3.Click
        GameData.FlagSkin = picFlag3.Image
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.FixedSingle
        picFlag1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub trbDifficulty_Scroll(sender As Object, e As EventArgs) Handles trbDifficulty.Scroll
        GameData.Difficulty = trbDifficulty.Value
        Console.WriteLine(GameData.Difficulty)
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

    Private Sub frmGameSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picFlag4_Click(sender As Object, e As EventArgs) Handles picFlag4.Click
        picFlag4.Image = GameData.FlagSkin
    End Sub
End Class