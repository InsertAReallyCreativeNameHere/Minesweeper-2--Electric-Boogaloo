<Serializable>
Public Class Statistics
    Public Property Easy As GameStatistics = New GameStatistics
    Public Property Medium As GameStatistics = New GameStatistics
    Public Property Hard As GameStatistics = New GameStatistics
    Public Property Insane As GameStatistics = New GameStatistics
    Public Function GetLevelStats(Optional difficulty As GameDifficulty? = Nothing) As GameStatistics
        If (difficulty Is Nothing) Then
            difficulty = GameData.Difficulty
        End If
        Select Case difficulty
            Case GameDifficulty.Easy
                Return Easy
            Case GameDifficulty.Medium
                Return Medium
            Case GameDifficulty.Hard
                Return Hard
            Case GameDifficulty.Insane
                Return Insane
        End Select
        Throw New ArgumentException("Unexpected difficulty:" + GameData.Difficulty)
    End Function
    Public Function GetOverallStats() As GameStatistics
        Dim OverallStats As GameStatistics = New GameStatistics
        Dim DifficultyArray As GameStatistics() = New GameStatistics(3) {Easy, Medium, Hard, Insane}
        For Each stat In DifficultyArray
            If OverallStats.HighScore < stat.HighScore Then
                OverallStats.HighScore = stat.HighScore
            End If
            OverallStats.GamesPlayed += stat.GamesPlayed
            OverallStats.GamesWon += stat.GamesWon
            OverallStats.GamesLost += stat.GamesLost
            OverallStats.TimePlayed += stat.TimePlayed
            OverallStats.FlagsPlaced += stat.FlagsPlaced
            OverallStats.BarsFilled += stat.BarsFilled
        Next
        Return OverallStats
    End Function
    Public Sub AddGameStats(won As Boolean, score As Integer, time As Integer, flags As Integer, bars As Integer)
        Dim stats = GetLevelStats()
        stats.GamesPlayed += 1
        If won Then
            stats.GamesWon += 1
        Else
            stats.GamesLost += 1
        End If
        stats.HighScore = Math.Max(stats.HighScore, score)
        stats.TimePlayed = stats.TimePlayed + time
        stats.FlagsPlaced = stats.FlagsPlaced = flags
        stats.BarsFilled = stats.BarsFilled + bars
        My.Settings.Save()
    End Sub
End Class

Public Class GameStatistics
    Public Property HighScore As Integer = 0
    Public Property GamesPlayed As Integer = 0
    Public Property GamesWon As Integer = 0
    Public Property GamesLost As Integer = 0
    Public Property TimePlayed As Integer = 0
    Public Property FlagsPlaced As Integer = 0
    Public Property BarsFilled As Integer = 0
End Class
