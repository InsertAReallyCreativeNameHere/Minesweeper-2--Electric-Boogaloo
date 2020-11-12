Imports System.IO
Public Class frmLeaderboard
    Private Sub frmLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leaderboardFile As StreamReader = File.OpenText("Leaderboard.txt")
        Do While leaderboardFile.Peek <> -1
            lstLeaderboard.Items.Add(leaderboardFile.ReadLine())
        Loop
        leaderboardFile.Close()
    End Sub

    Private Sub btnReturnFromLeaderboard_Click(sender As Object, e As EventArgs) Handles btnReturnFromLeaderboard.Click
        Dim leaderboardFile2 As StreamWriter = File.CreateText("Leaderboard.txt")
        For Each Name As Object In lstLeaderboard.Items
            leaderboardFile2.WriteLine(Name)
        Next
        leaderboardFile2.Close()
        frmTitleScreen.Show()
        Me.Hide()
    End Sub


End Class