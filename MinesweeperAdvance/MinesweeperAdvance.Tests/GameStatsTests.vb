Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GameStatsTests

    <TestMethod()> Public Sub CheckTotals()
        'Arrange
        Dim stats = New Statistics
        stats.Easy.HighScore = 5
        stats.Easy.GamesPlayed = 3

        stats.Medium.HighScore = 2
        stats.Medium.GamesPlayed = 50

        'Act
        Dim overallStats = stats.GetOverallStats()

        'Assert
        Assert.AreEqual(5, overallStats.HighScore)
        Assert.AreEqual(53, overallStats.GamesPlayed)
    End Sub

End Class