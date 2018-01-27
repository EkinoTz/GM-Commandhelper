Public Class Zoom

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.TabStop = False
        Me.MephButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 201)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 43
        Me.MephButton1.TabStop = False
        Me.MephButton1.Text = "Back"
    End Sub

    Private Sub MephTextBox1_Click(sender As Object, e As EventArgs) Handles MephTextBox1.Click
        Me.MephTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox1.CausesValidation = False
        Me.MephTextBox1.Enabled = False
        Me.MephTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox1.Location = New System.Drawing.Point(12, 68)
        Me.MephTextBox1.MaxLength = 32767
        Me.MephTextBox1.MultiLine = True
        Me.MephTextBox1.Name = "MephTextBox1"
        Me.MephTextBox1.Size = New System.Drawing.Size(260, 38)
        Me.MephTextBox1.TabIndex = 44
        Me.MephTextBox1.TabStop = False
        Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox1.UseSystemPasswordChar = False
        Me.MephTextBox1.WordWrap = True
    End Sub
End Class