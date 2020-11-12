Imports MinesweeperAdvance.Behaviours

Public Class frmTitleScreen
    Private Sub frmTitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Minesweeper.Show()
        Me.Hide()
    End Sub

    Private Sub picTitle2_Click(sender As Object, e As EventArgs) Handles picTitle2.Click

    End Sub

    Private Sub btnAchievements_Click(sender As Object, e As EventArgs) Handles btnAchievements.Click
        frmAchievements.Show()
        Me.Hide()
    End Sub
End Class
Friend NotInheritable Class AA
    Public Shared Achievements1 As Integer = 0
End Class
Friend NotInheritable Class BA
    Public Shared Constant1 As Integer = 1
End Class
Friend NotInheritable Class AB
    Public Shared Achievements2 As Integer = 0
End Class
Friend NotInheritable Class BB
    Public Shared Constant2 As Integer = 1
End Class
Friend NotInheritable Class AC
    Public Shared Achievements3 As Integer = 0
End Class
Friend NotInheritable Class BC
    Public Shared Constant3 As Integer = 1
End Class
Friend NotInheritable Class AD
    Public Shared Achievements4 As Integer = 0
End Class
Friend NotInheritable Class BD
    Public Shared Constant4 As Integer = 1
End Class
Friend NotInheritable Class AE
    Public Shared Achievements5 As Integer = 0
End Class
Friend NotInheritable Class BE
    Public Shared Constant5 As Integer = 1
End Class
Friend NotInheritable Class AF
    Public Shared Achievements6 As Integer = 0
End Class
Friend NotInheritable Class BF
    Public Shared Constant6 As Integer = 1
End Class
Friend NotInheritable Class AG
    Public Shared Achievements7 As Integer = 0
End Class
Friend NotInheritable Class BG
    Public Shared Constant7 As Integer = 1
End Class
Friend NotInheritable Class AH
    Public Shared Achievements8 As Integer = 0
End Class
Friend NotInheritable Class BH
    Public Shared Constant8 As Integer = 1
End Class
Friend NotInheritable Class AI
    Public Shared Achievements9 As Integer = 0
End Class
Friend NotInheritable Class BI
    Public Shared Constant9 As Integer = 1
End Class