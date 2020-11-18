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
        frmAchievements.DetectAchievements()
        If AchievementsUnlocked.A1 = True Then
            picFlag4.Visible = True
            picQ3.Visible = False
        Else
            picFlag4.Visible = False
            picQ3.Visible = True
        End If
        If AchievementsUnlocked.A2 = True Then
            picFlag2.Visible = True
            picQ1.Visible = False
        Else
            picFlag2.Visible = False
            picQ1.Visible = True
        End If
        If AchievementsUnlocked.A3 = True Then
            picFlag3.Visible = True
            picQ2.Visible = False
        Else
            picFlag3.Visible = False
            picQ2.Visible = True
        End If
        If AchievementsUnlocked.A4 = True Then
            picFlag6.Visible = True
            picQ5.Visible = False
        Else
            picFlag6.Visible = False
            picQ5.Visible = True
        End If
        If AchievementsUnlocked.A5 = True Then
            picFlag7.Visible = True
            picQ6.Visible = False
        Else
            picFlag7.Visible = False
            picQ6.Visible = True
        End If
        If AchievementsUnlocked.A6 = True Then
            picFlag5.Visible = True
            picQ4.Visible = False
        Else
            picFlag5.Visible = False
            picQ4.Visible = True
        End If
        If AchievementsUnlocked.A7 = True Then
            picMine2.Visible = True
            picQ7.Visible = False
        Else
            picMine2.Visible = False
            picQ7.Visible = True
        End If
        If AchievementsUnlocked.A8 = True Then
            picMine4.Visible = True
            picQ9.Visible = False
        Else
            picMine4.Visible = False
            picQ9.Visible = True
        End If
        If AchievementsUnlocked.A9 = True Then
            picMine3.Visible = True
            picQ8.Visible = False
        Else
            picMine3.Visible = False
            picQ8.Visible = True
        End If
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