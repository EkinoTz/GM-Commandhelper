Public Class ReputationIcon
    Private Sub MephComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MephComboBox1.SelectedIndexChanged
        If MephComboBox1.SelectedItem = "Beginner" Then
            PictureBox1.Image = My.Resources.Rep1
            Label1.Text = "Beginner"
            Label3.Text = ""
            Label4.Text = "Reputation : 0 ~ 250"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Trainee" Then
            PictureBox1.Image = My.Resources.Rep2
            Label1.Text = "Trainee"
            Label3.Text = ""
            Label4.Text = "Reputation : 251 ~ 500"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Trainee" Then
            PictureBox1.Image = My.Resources.Rep3
            Label1.Text = "Trainee"
            Label3.Text = ""
            Label4.Text = "Reputation : 501 ~ 750"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Trainee" Then
            PictureBox1.Image = My.Resources.Rep4
            Label1.Text = "Trainee"
            Label3.Text = ""
            Label4.Text = "Reputation : 751 ~ 1.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Experienced" Then
            PictureBox1.Image = My.Resources.Rep5
            Label1.Text = "Experienced"
            Label3.Text = ""
            Label4.Text = "Reputation : 1.001 ~ 2.250"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Experienced" Then
            PictureBox1.Image = My.Resources.Rep6
            Label1.Text = "Experienced"
            Label3.Text = ""
            Label4.Text = "Reputation : 2.251 ~ 3.500"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Experienced" Then
            PictureBox1.Image = My.Resources.Rep7
            Label1.Text = "Experienced"
            Label3.Text = ""
            Label4.Text = "Reputation : 3.501 ~ 5.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Battle Soldier" Then
            PictureBox1.Image = My.Resources.Rep8
            Label1.Text = "Battle Soldier"
            Label3.Text = ""
            Label4.Text = "Reputation : 5.001 ~ 9.500"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Battle Soldier" Then
            PictureBox1.Image = My.Resources.Rep9
            Label1.Text = "Battle Soldier"
            Label3.Text = ""
            Label4.Text = "Reputation : 9.501 ~ 19.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Battle Soldier" Then
            PictureBox1.Image = My.Resources.Rep10
            Label1.Text = "Battle Soldier"
            Label3.Text = ""
            Label4.Text = "Reputation : 19.001 ~ 25.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Expert" Then
            PictureBox1.Image = My.Resources.Rep11
            Label1.Text = "Expert"
            Label3.Text = ""
            Label4.Text = "Reputation : 25.001 ~ 40.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Expert" Then
            PictureBox1.Image = My.Resources.Rep12
            Label1.Text = "Expert"
            Label3.Text = ""
            Label4.Text = "Reputation : 40.001 ~ 60.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Expert" Then
            PictureBox1.Image = My.Resources.Rep13
            Label1.Text = "Expert"
            Label3.Text = ""
            Label4.Text = "Reputation : 60.001 ~ 85.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Leader" Then
            PictureBox1.Image = My.Resources.Rep14
            Label1.Text = "Leader"
            Label3.Text = ""
            Label4.Text = "Reputation : 85.001 ~ 115.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Leader" Then
            PictureBox1.Image = My.Resources.Rep15
            Label1.Text = "Leader"
            Label3.Text = ""
            Label4.Text = "Reputation : 115.001 ~ 150.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Leader" Then
            PictureBox1.Image = My.Resources.Rep16
            Label1.Text = "Leader"
            Label3.Text = ""
            Label4.Text = "Reputation : 150.001 ~ 190.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Master" Then
            PictureBox1.Image = My.Resources.Rep17
            Label1.Text = "Master"
            Label3.Text = ""
            Label4.Text = "Reputation : 190.001 ~ 235.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Master" Then
            PictureBox1.Image = My.Resources.Rep18
            Label1.Text = "Master"
            Label3.Text = ""
            Label4.Text = "Reputation : 235.001 ~ 285.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Master" Then
            PictureBox1.Image = My.Resources.Rep19
            Label1.Text = "Master"
            Label3.Text = ""
            Label4.Text = "Reputation : 285.001 ~ 350.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Nos" Then
            PictureBox1.Image = My.Resources.Rep20
            Label1.Text = "Nos"
            Label3.Text = ""
            Label4.Text = "Reputation : 350.001 ~ 500.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Nos" Then
            PictureBox1.Image = My.Resources.Rep21
            Label1.Text = "Nos"
            Label3.Text = ""
            Label4.Text = "Reputation : 500.001 ~ 1.500.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Nos" Then
            PictureBox1.Image = My.Resources.Rep22
            Label1.Text = "Nos"
            Label3.Text = ""
            Label4.Text = "Reputation : 1.500.001 ~ 2.500.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Elite" Then
            PictureBox1.Image = My.Resources.Rep23
            Label1.Text = "Elite"
            Label3.Text = ""
            Label4.Text = "Reputation : 2.500.001 ~ 3.750.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Blue Elite" Then
            PictureBox1.Image = My.Resources.Rep24
            Label1.Text = "Elite"
            Label3.Text = ""
            Label4.Text = "Reputation : 3.750.001 ~ 5.000.000"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Red Elite" Then
            PictureBox1.Image = My.Resources.Rep25
            Label1.Text = "Elite"
            Label3.Text = ""
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = ""
        End If

        If MephComboBox1.SelectedItem = "Green Legend" Then
            PictureBox1.Image = My.Resources.Rep26
            Label1.Text = "Legend"
            Label3.Text = "43rd to 14th highest reputation"
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = "!!! NOT FOR SUPPORT OR HIGHER !!!"
        End If

        If MephComboBox1.SelectedItem = "Blue Legend" Then
            PictureBox1.Image = My.Resources.Rep27
            Label1.Text = "Legend"
            Label3.Text = "13rd to 4th highest reputation"
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = "!!! NOT FOR SUPPORT OR HIGHER !!!"
        End If

        If MephComboBox1.SelectedItem = "Ancient Hero" Then
            PictureBox1.Image = My.Resources.Rep28
            Label1.Text = "Ancient Hero"
            Label3.Text = "3rd highest reputation [Hero chat]"
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = "!!! NOT FOR SUPPORT OR HIGHER !!!"
        End If

        If MephComboBox1.SelectedItem = "Misteryous Hero" Then
            PictureBox1.Image = My.Resources.Rep29
            Label1.Text = "Misteryous Hero"
            Label3.Text = "2nd highest repuation [Hero chat]"
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = "!!! NOT FOR SUPPORT OR HIGHER !!!"
        End If

        If MephComboBox1.SelectedItem = "Legendary Hero" Then
            PictureBox1.Image = My.Resources.Rep30
            Label1.Text = "Legendary Hero"
            Label3.Text = "1st highest repuation [Hero chat]"
            Label4.Text = "Reputation : 5.000.001+"
            Label5.Text = "!!! NOT FOR SUPPORT OR HIGHER !!!"
        End If

    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Close()
    End Sub
End Class