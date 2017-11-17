Public Class DignityIcons
    Private Sub MephComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MephComboBox1.SelectedIndexChanged
        If MephComboBox1.SelectedItem = "-1000 bis -800" Then
            PictureBox1.Image = My.Resources._1000bis800
            Label1.Text = "Stupid minded * (Dignity: -801 ~ -1.000)"
            Label2.Text = "- Title change by force"
            Label3.Text = "- 50% increase of prices when purchasing shop items"
            Label4.Text = "- Capture of NosMates impossible"
            Label5.Text = "- You can't bring any NosMate with yourself, current NosMate will return to Mini-Land"
        End If

        If MephComboBox1.SelectedItem = "-799 bis -600" Then
            PictureBox1.Image = My.Resources._799bis600
            Label1.Text = "Useless * (Dignity: -601 ~ -800)"
            Label2.Text = "- Title change by force"
            Label3.Text = "- 50% increase of prices when purchasing shop items"
            Label4.Text = "- Capture of NosMates impossible"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "-599 bis -400" Then
            PictureBox1.Image = My.Resources._599bis400
            Label1.Text = "Not qualified for * (Dignity: -401 ~ -600)"
            Label2.Text = "- Title change by force"
            Label3.Text = "- 20% increase of prices when purchasing shop items"
            Label4.Text = "- Capture of NosMates impossible"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "-399 bis -200" Then
            PictureBox1.Image = My.Resources._399bis200
            Label1.Text = "Bluffed name only * (Dignity: -201 ~ -400)"
            Label2.Text = "- Title change by force"
            Label3.Text = "- 10% increase of prices when purchasing shop items"
            Label4.Text = ""
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "-199 bis -100" Then
            PictureBox1.Image = My.Resources._199bis100
            Label1.Text = "Suspected * (Dignity: -100 ~ -200)"
            Label2.Text = "- Title change by force"
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
        End If
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Close()
    End Sub
End Class