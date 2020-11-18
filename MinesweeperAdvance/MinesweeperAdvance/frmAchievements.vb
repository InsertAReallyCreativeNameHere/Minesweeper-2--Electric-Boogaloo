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