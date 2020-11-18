Public Class frmAchievements



    Private Sub btnBackAchievements_Click(sender As Object, e As EventArgs) Handles btnBackAchievements.Click
        Me.Hide()
        frmTitleScreen.Show()

    End Sub

    Private Sub frmAchievements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim TilesFlaggedLocal As Integer = My.Settings.Stats.GetOverallStats().FlagsPlaced
        Dim BarsFilledLocal As Integer = My.Settings.Stats.GetOverallStats().BarsFilled
        Dim GamesWonLocal As Integer = My.Settings.Stats.GetOverallStats().GamesWon
        DetectAchievements()
        lblAchievements1.Text = TilesFlaggedLocal & " / " & 10
        lblAchievements2.Text = BarsFilledLocal & " / " & 1
        lblAchievements3.Text = GamesWonLocal & " / " & 1
        lblAchievements4.Text = TilesFlaggedLocal & " / " & 100
        lblAchievements5.Text = BarsFilledLocal & " / " & 10
        lblAchievements6.Text = GamesWonLocal & " / " & 10
        lblAchievements7.Text = TilesFlaggedLocal & " / " & 1000
        lblAchievements8.Text = BarsFilledLocal & " / " & 100
        lblAchievements9.Text = GamesWonLocal & " / " & 100
        If AchievementsUnlocked.A1 = True Then
            picAchievements1.Visible = True
            picQ1.Visible = False
        Else
            picAchievements1.Visible = False
            picQ1.Visible = True
        End If
        If AchievementsUnlocked.A2 = True Then
            picAchievements2.Visible = True
            picQ2.Visible = False
        Else
            picAchievements2.Visible = False
            picQ2.Visible = True
        End If
        If AchievementsUnlocked.A3 = True Then
            picAchievements3.Visible = True
            picQ3.Visible = False
        Else
            picAchievements3.Visible = False
            picQ3.Visible = True
        End If
        If AchievementsUnlocked.A4 = True Then
            picAchievements4.Visible = True
            picQ4.Visible = False
        Else
            picAchievements4.Visible = False
            picQ4.Visible = True
        End If
        If AchievementsUnlocked.A5 = True Then
            picAchievements5.Visible = True
            picQ5.Visible = False
        Else
            picAchievements5.Visible = False
            picQ5.Visible = True
        End If
        If AchievementsUnlocked.A6 = True Then
            picAchievements6.Visible = True
            picQ6.Visible = False
        Else
            picAchievements6.Visible = False
            picQ6.Visible = True
        End If
        If AchievementsUnlocked.A7 = True Then
            picAchievements7.Visible = True
            picQ7.Visible = False
        Else
            picAchievements7.Visible = False
            picQ7.Visible = True
        End If
        If AchievementsUnlocked.A8 = True Then
            picAchievements8.Visible = True
            picQ8.Visible = False
        Else
            picAchievements8.Visible = False
            picQ8.Visible = True
        End If
        If AchievementsUnlocked.A9 = True Then
            picAchievements9.Visible = True
            picQ9.Visible = False
        Else
            picAchievements9.Visible = False
            picQ9.Visible = True
        End If

    End Sub

    Public Shared Sub DetectAchievements()
        Dim TilesFlaggedLocal As Integer = My.Settings.Stats.GetOverallStats().FlagsPlaced
        Dim BarsFilledLocal As Integer = My.Settings.Stats.GetOverallStats().BarsFilled
        Dim GamesWonLocal As Integer = My.Settings.Stats.GetOverallStats().GamesWon
        Dim Ach1 As Integer = TilesFlaggedLocal
        Dim Ach2 As Integer = BarsFilledLocal
        Dim Ach3 As Integer = GamesWonLocal
        Dim Ach4 As Integer = TilesFlaggedLocal
        Dim Ach5 As Integer = BarsFilledLocal
        Dim Ach6 As Integer = GamesWonLocal
        Dim Ach7 As Integer = TilesFlaggedLocal
        Dim Ach8 As Integer = BarsFilledLocal
        Dim Ach9 As Integer = GamesWonLocal

        If (TilesFlaggedLocal >= 10) Then
            AchievementsUnlocked.A1 = True
        End If
        If (BarsFilledLocal >= 1) Then
            AchievementsUnlocked.A2 = True
        End If
        If (GamesWonLocal >= 1) Then
            AchievementsUnlocked.A3 = True
        End If
        If (TilesFlaggedLocal >= 100) Then
            AchievementsUnlocked.A4 = True
        End If
        If (BarsFilledLocal >= 10) Then
            AchievementsUnlocked.A5 = True
        End If
        If (GamesWonLocal >= 10) Then
            AchievementsUnlocked.A6 = True
        End If
        If (TilesFlaggedLocal >= 1000) Then
            AchievementsUnlocked.A7 = True
        End If
        If (BarsFilledLocal >= 100) Then
            AchievementsUnlocked.A8 = True
        End If
        If (GamesWonLocal >= 100) Then
            AchievementsUnlocked.A9 = True
        End If
    End Sub

End Class

Public Class AchievementsUnlocked
    Public Shared Property A1 As Boolean = False
    Public Shared Property A2 As Boolean = False
    Public Shared Property A3 As Boolean = False
    Public Shared Property A4 As Boolean = False
    Public Shared Property A5 As Boolean = False
    Public Shared Property A6 As Boolean = False
    Public Shared Property A7 As Boolean = False
    Public Shared Property A8 As Boolean = False
    Public Shared Property A9 As Boolean = False

End Class