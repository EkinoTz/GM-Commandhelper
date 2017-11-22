Public Class ChangeClass
    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Close()
        GMCommands.Show()
    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Classes.Show()
    End Sub
End Class