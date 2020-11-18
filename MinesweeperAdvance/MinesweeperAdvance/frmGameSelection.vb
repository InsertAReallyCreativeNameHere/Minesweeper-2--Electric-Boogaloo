Imports MinesweeperAdvance.Behaviours

Public Class frmGameSelection
    Private Sub SelectFlagSkin(currentFlag As PictureBox)
        GameData.FlagSkin = currentFlag.Image
        For Each flag As PictureBox In pnlFlags.Controls
            If currentFlag.Equals(flag) Then
                currentFlag.BorderStyle = BorderStyle.FixedSingle
            Else
                flag.BorderStyle = BorderStyle.None
            End If
        Next
    End Sub
    Private Sub SelectMineSkin(currentMine As PictureBox)
        GameData.MineSkin = currentMine.Image
        For Each mine As PictureBox In pnlMines.Controls
            If currentMine.Equals(mine) Then
                currentMine.BorderStyle = BorderStyle.FixedSingle
            Else
                mine.BorderStyle = BorderStyle.None
            End If
        Next
    End Sub
    Private Sub trbDifficulty_Scroll(sender As Object, e As EventArgs) Handles trbDifficulty.Scroll
        GameData.Difficulty = trbDifficulty.Value
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
        SelectFlagSkin(picFlag1)
        SelectMineSkin(picMine1)
        GameData.Difficulty = 0
        DetectAchievements()

    End Sub

    Private Sub picFlag1_Click(sender As Object, e As EventArgs) Handles picFlag1.Click
        SelectFlagSkin(sender)
    End Sub

    Private Sub picFlag2_Click(sender As Object, e As EventArgs) Handles picFlag2.Click
        SelectFlagSkin(sender)
    End Sub

    Private Sub picFlag3_Click(sender As Object, e As EventArgs) Handles picFlag3.Click
        SelectFlagSkin(sender)
    End Sub
    Private Sub picFlag4_Click(sender As Object, e As EventArgs) Handles picFlag4.Click
        SelectFlagSkin(sender)
    End Sub



    Private Sub picMine1_Click(sender As Object, e As EventArgs) Handles picMine1.Click
        SelectMineSkin(sender)
    End Sub


    Private Sub picMine2_Click(sender As Object, e As EventArgs) Handles picMine2.Click
        SelectMineSkin(sender)
    End Sub

    Private Sub picMine3_Click(sender As Object, e As EventArgs) Handles picMine3.Click
        SelectMineSkin(sender)
    End Sub

    Private Sub picMine4_Click(sender As Object, e As EventArgs) Handles picMine4.Click
        SelectMineSkin(sender)
    End Sub

    Private Sub picFlag5_Click(sender As Object, e As EventArgs) Handles picFlag5.Click
        SelectFlagSkin(sender)
    End Sub

    Private Sub picFlag6_Click(sender As Object, e As EventArgs) Handles picFlag6.Click
        SelectFlagSkin(sender)
    End Sub

    Private Sub picFlag7_Click(sender As Object, e As EventArgs) Handles picFlag7.Click
        SelectFlagSkin(sender)
    End Sub


End Class