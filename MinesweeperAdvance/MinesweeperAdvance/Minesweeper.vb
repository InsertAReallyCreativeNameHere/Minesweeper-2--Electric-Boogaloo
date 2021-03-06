﻿Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms
Imports System.Threading.Tasks

Partial Public Class Minesweeper
    Inherits Form

    Dim _DecayRate As Integer = 0
    Async Sub DecayScanBar()
        Await System.Threading.Tasks.Task.Yield()
        While Game.gameFinished = False
            If pgbScanBar.Value > 0 Then
            pgbScanBar.Value -= 1
        End If
            Await Task.Delay(_DecayRate)
        End While
    End Sub
    Async Function RunTimer() As Task
        Await System.Threading.Tasks.Task.Yield()
        tmrGameTime.Enabled = True
        Dim i As Single = 0
        While Game.gameFinished = False
            i += 1
            lblTimeElapsed.Text = Math.Round(i)
            Await Task.Delay(1000)
        End While
        tmrGameTime.Enabled = False
        GameData.TimeElapsed = tmrGameTime.Interval
        Me.Hide()
        frmEndScreen.Show()
    End Function
    Private Async Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimeElapsed.BackColor = Color.FromArgb(40, 40, 40)
        lblTimeElapsedHeading.BackColor = Color.FromArgb(40, 40, 40)
        lblDisplayCurrentDifficulty.BackColor = Color.FromArgb(40, 40, 40)
        lblDifficultyTiltle.BackColor = Color.FromArgb(40, 40, 40)
        lblFlagsLeft.BackColor = Color.FromArgb(40, 40, 40)
        lblTilesFlagged.BackColor = Color.FromArgb(40, 40, 40)
        picFlagsLeft.BackColor = Color.FromArgb(40, 40, 40)
        lblScanBar.BackColor = Color.FromArgb(40, 40, 40)
        picFlagsLeft.Image = GameData.FlagSkin
        Select Case GameData.Difficulty
            Case 0
                lblDisplayCurrentDifficulty.Text = "Easy"
                GameData.TotalFlagsNeeded = 10
                _DecayRate = 500
            Case 1
                lblDisplayCurrentDifficulty.Text = "Medium"
                GameData.TotalFlagsNeeded = 15
                _DecayRate = 250
            Case 2
                lblDisplayCurrentDifficulty.Text = "Hard"
                GameData.TotalFlagsNeeded = 20
                _DecayRate = 167
            Case 3
                lblDisplayCurrentDifficulty.Text = "Insane"
                GameData.TotalFlagsNeeded = 25
                _DecayRate = 125
        End Select
        lblFlagsLeft.Text = GameData.TotalFlagsNeeded - GameData.FlagsPlaced
        RunTimer()
        DecayScanBar()
    End Sub

    Private Sub Minesweeper_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Game.mainForm = Me
        Game.Start()
    End Sub
    Private Sub Minesweeper_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Game.GraphicsUpdate(e)
    End Sub
    Private Sub Minesweeper_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Game.HandleMouseEvent(e)
    End Sub
    Private Sub Minesweeper_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Game.gameFinished = True
    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        weed.HandleExit()
        End
    End Sub

    Private Sub Minesweeper_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Click
        If GameData.ScanBar > 89 Then
            pgbScanBar.Value = 100
            GameData.ScanBarsFilled += 1
            pgbScanBar.Value = 0
            GameData.ScanBar = 0
        Else pgbScanBar.Value = GameData.ScanBar
        End If
        If GameData.FlagsCorrectlyPlaced >= GameData.TotalFlagsNeeded Then
            Game.gameWon = True
            GameData.TimeElapsed = tmrGameTime.Interval
            Me.Hide()
            frmEndScreen.Show()
        End If
        lblFlagsLeft.Text = GameData.TotalFlagsNeeded - GameData.FlagsPlaced
    End Sub
End Class