Imports MinesweeperAdvance.Behaviours
Imports System.Windows.Forms
Imports System.Threading.Tasks

Partial Public Class Minesweeper
    Inherits Form

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game.mainForm = Me
        Game.Start()
        Game.canUpdate = True
    End Sub
    Private Sub Minesweeper_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Game.canUpdate Then
            Game.GraphicsUpdate(e)
        End If
    End Sub

End Class

Namespace MinesweeperAdvance
    Class Entry
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)
            Application.Run(New Minesweeper())

            While True
                If Game.canUpdate Then
                    Exit While
                End If
            End While

            While True
                Game.Update()
                Threading.Thread.Sleep(17)
            End While
        End Sub
    End Class
End Namespace