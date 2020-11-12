Public Class frmGameSelection
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDifficullty.Click

    End Sub

    Private Sub picFlag1_Click(sender As Object, e As EventArgs) Handles picFlag1.Click
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub picFlag2_Click(sender As Object, e As EventArgs) Handles picFlag2.Click
        picFlag2.BorderStyle = BorderStyle.FixedSingle
        picFlag3.BorderStyle = BorderStyle.None
        picFlag1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picFlag3_Click(sender As Object, e As EventArgs) Handles picFlag3.Click
        picFlag2.BorderStyle = BorderStyle.None
        picFlag3.BorderStyle = BorderStyle.FixedSingle
        picFlag1.BorderStyle = BorderStyle.None
    End Sub
End Class