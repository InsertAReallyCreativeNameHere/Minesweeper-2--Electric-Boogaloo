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

End Class

Namespace MinesweeperAdvance
    Class Entry
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)
            Application.Run(New Minesweeper())
GameLoop:
            While True
                If Game.ready Then
                    Exit While
                End If
            End While

            While True
                Game.Update()
                Threading.Thread.Sleep(17)
                If Game.done Then
                    Game.ready = False
                    Exit While
                End If
            End While

            GoTo GameLoop
        End Sub
    End Class
End Namespace