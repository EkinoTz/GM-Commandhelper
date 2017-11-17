Public Class ItemVnums
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Label1.Text = "Name: Woodenstick" + vbCrLf + "Level: 1" + vbCrLf + "Class: Adventure"
    End Sub

    Private Sub PictureBox2__MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Label1.Text = "Name: WoodenIDK?" + vbCrLf + "Level: 4" + vbCrLf + "Class: Adventure"
    End Sub

    Private Sub PictureBox3__MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Label1.Text = "Name: Woodensword" + vbCrLf + "Level: 7" + vbCrLf + "Class: Adventure"
    End Sub
    Private Sub PictureBox4__MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        Label1.Text = "Name: Mallet" + vbCrLf + "Level: 10" + vbCrLf + "Class: Adventure"
    End Sub
    Private Sub PictureBox5__MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        Label1.Text = "Name: Heavy mallet" + vbCrLf + "Level: 13" + vbCrLf + "Class: Adventure"
    End Sub
    Private Sub PictureBox6__MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        Label1.Text = "Name: Wooden sword of apprentice " + vbCrLf + "Level: 15" + vbCrLf + "Class: Adventure"
    End Sub
    Private Sub PictureBox7__MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        Label1.Text = "Name: Sword of the Adventurer" + vbCrLf + "Level: 18" + vbCrLf + "Class: Adventure"
    End Sub
    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Close()
    End Sub
End Class