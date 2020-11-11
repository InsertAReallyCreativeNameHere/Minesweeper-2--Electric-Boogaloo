Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms
Imports System.Threading.Tasks

Partial Public Class Minesweeper
    Inherits Form

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game.mainForm = Me
        Game.Start()
        Game.ready = True
    End Sub
    Private Sub Minesweeper_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Game.GraphicsUpdate(e)
    End Sub
    Private Sub Minesweeper_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Game.HandleMouseEvent(e)
    End Sub
    Private Sub Minesweeper_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
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