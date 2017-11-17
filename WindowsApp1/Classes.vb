Public Class Classes
    Private Sub MephComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MephComboBox1.SelectedIndexChanged
        If MephComboBox1.SelectedItem = "Class 0" Then
            PictureBox1.Image = My.Resources.Class0
        End If

        If MephComboBox1.SelectedItem = "Class 1" Then
            PictureBox1.Image = My.Resources.Class1
        End If

        If MephComboBox1.SelectedItem = "Class 2" Then
            PictureBox1.Image = My.Resources.Class2
        End If

        If MephComboBox1.SelectedItem = "Class 3" Then
            PictureBox1.Image = My.Resources.Class3
        End If
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Close()
    End Sub
End Class