Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms

Partial Public Class Minesweeper
    Inherits Form

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game.graphics = Me.CreateGraphics()
        Game.Test(420)
    End Sub

End Class

Namespace MinesweeperAdvance
    Class Entry
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)
            Application.Run(New Minesweeper())
        End Sub
    End Class
End Namespace