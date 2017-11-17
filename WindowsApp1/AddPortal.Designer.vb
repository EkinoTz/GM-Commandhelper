<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPortal
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MephTheme1 = New WindowsApp1.MephTheme()
        Me.MephButton1 = New WindowsApp1.MephButton()
        Me.MephTextBox3 = New WindowsApp1.MephTextBox()
        Me.MephTextBox2 = New WindowsApp1.MephTextBox()
        Me.MephTextBox1 = New WindowsApp1.MephTextBox()
        Me.MephTextBox4 = New WindowsApp1.MephTextBox()
        Me.MephTextBox5 = New WindowsApp1.MephTextBox()
        Me.MephButton2 = New WindowsApp1.MephButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(Me.MephTextBox5)
        Me.MephTheme1.Controls.Add(Me.MephTextBox4)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Controls.Add(Me.MephTextBox3)
        Me.MephTheme1.Controls.Add(Me.MephTextBox2)
        Me.MephTheme1.Controls.Add(Me.MephTextBox1)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(284, 275)
        Me.MephTheme1.SubHeader = "$AddPortal MAPID DESTX DESTY PORTALTYPE"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "AddPortal"
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 243)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 55
        Me.MephButton1.Text = "Back"
        '
        'MephTextBox3
        '
        Me.MephTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox3.Enabled = False
        Me.MephTextBox3.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox3.Location = New System.Drawing.Point(12, 154)
        Me.MephTextBox3.MaxLength = 32767
        Me.MephTextBox3.MultiLine = True
        Me.MephTextBox3.Name = "MephTextBox3"
        Me.MephTextBox3.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox3.TabIndex = 54
        Me.MephTextBox3.Text = "DESTY for Y position on MAP"
        Me.MephTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox3.UseSystemPasswordChar = False
        Me.MephTextBox3.WordWrap = False
        '
        'MephTextBox2
        '
        Me.MephTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox2.Enabled = False
        Me.MephTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox2.Location = New System.Drawing.Point(12, 124)
        Me.MephTextBox2.MaxLength = 32767
        Me.MephTextBox2.MultiLine = True
        Me.MephTextBox2.Name = "MephTextBox2"
        Me.MephTextBox2.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox2.TabIndex = 52
        Me.MephTextBox2.Text = "DESTX for X position on MAP"
        Me.MephTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox2.UseSystemPasswordChar = False
        Me.MephTextBox2.WordWrap = False
        '
        'MephTextBox1
        '
        Me.MephTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox1.Enabled = False
        Me.MephTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox1.Location = New System.Drawing.Point(12, 94)
        Me.MephTextBox1.MaxLength = 32767
        Me.MephTextBox1.MultiLine = True
        Me.MephTextBox1.Name = "MephTextBox1"
        Me.MephTextBox1.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox1.TabIndex = 51
        Me.MephTextBox1.Text = "MAPID = On which Map you want to go."
        Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox1.UseSystemPasswordChar = False
        Me.MephTextBox1.WordWrap = False
        '
        'MephTextBox4
        '
        Me.MephTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox4.Enabled = False
        Me.MephTextBox4.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox4.Location = New System.Drawing.Point(12, 184)
        Me.MephTextBox4.MaxLength = 32767
        Me.MephTextBox4.MultiLine = True
        Me.MephTextBox4.Name = "MephTextBox4"
        Me.MephTextBox4.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox4.TabIndex = 56
        Me.MephTextBox4.Text = "PORTALTYPE = Look of Portal"
        Me.MephTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox4.UseSystemPasswordChar = False
        Me.MephTextBox4.WordWrap = False
        '
        'MephTextBox5
        '
        Me.MephTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox5.Enabled = False
        Me.MephTextBox5.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox5.Location = New System.Drawing.Point(12, 64)
        Me.MephTextBox5.MaxLength = 32767
        Me.MephTextBox5.MultiLine = True
        Me.MephTextBox5.Name = "MephTextBox5"
        Me.MephTextBox5.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox5.TabIndex = 57
        Me.MephTextBox5.Text = "Portal will be Permanent!"
        Me.MephTextBox5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox5.UseSystemPasswordChar = False
        Me.MephTextBox5.WordWrap = False
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(12, 214)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(260, 23)
        Me.MephButton2.TabIndex = 58
        Me.MephButton2.Text = "Portaltypes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.InitialImage = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox1.Location = New System.Drawing.Point(231, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'AddPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 275)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPortal"
        Me.Text = "AddPortal"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephTextBox3 As MephTextBox
    Friend WithEvents MephTextBox2 As MephTextBox
    Friend WithEvents MephTextBox1 As MephTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MephButton2 As MephButton
    Friend WithEvents MephTextBox5 As MephTextBox
    Friend WithEvents MephTextBox4 As MephTextBox
End Class
