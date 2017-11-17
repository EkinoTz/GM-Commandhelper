Public Class Portaltypes
    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Close()
    End Sub

    Private Sub MephComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MephComboBox1.SelectedIndexChanged

        If MephComboBox1.SelectedItem = "Portaltype -1" Then
            PictureBox1.Image = My.Resources.Portaltype_1
        End If

        If MephComboBox1.SelectedItem = "Portaltype 0" Then
            PictureBox1.Image = My.Resources.PortalType0
        End If

        If MephComboBox1.SelectedItem = "Portaltype 1" Then
            PictureBox1.Image = My.Resources.PortalType1
        End If

        If MephComboBox1.SelectedItem = "Portaltype 2" Then
            PictureBox1.Image = My.Resources.PortalType2
        End If

        If MephComboBox1.SelectedItem = "Portaltype 3" Then
            PictureBox1.Image = My.Resources.PortalType3
        End If

        If MephComboBox1.SelectedItem = "Portaltype 4" Then
            PictureBox1.Image = My.Resources.PortalType4
        End If

        If MephComboBox1.SelectedItem = "Portaltype 5" Then
            PictureBox1.Image = My.Resources.PortalType5
        End If

        If MephComboBox1.SelectedItem = "Portaltype 6" Then
            PictureBox1.Image = My.Resources.PortalType6
        End If

        If MephComboBox1.SelectedItem = "Portaltype 7" Then
            PictureBox1.Image = My.Resources.PortalType7
        End If

        If MephComboBox1.SelectedItem = "Portaltype 8" Then
            PictureBox1.Image = My.Resources.PortalType8
        End If

        If MephComboBox1.SelectedItem = "Portaltype 10" Then
            PictureBox1.Image = My.Resources.PortalType10
        End If

        If MephComboBox1.SelectedItem = "Portaltype 11" Then
            PictureBox1.Image = My.Resources.PortalType11
        End If

        If MephComboBox1.SelectedItem = "Portaltype 12" Then
            PictureBox1.Image = My.Resources.PortalType12
        End If

        If MephComboBox1.SelectedItem = "Portaltype 20" Then
            PictureBox1.Image = My.Resources.PortalType20
        End If
    End Sub
End Class