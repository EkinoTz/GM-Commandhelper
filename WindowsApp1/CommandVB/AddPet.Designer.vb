<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPet
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MephButton1 = New WindowsApp1.MephButton()
        Me.MephTextBox3 = New WindowsApp1.MephTextBox()
        Me.MephButton57 = New WindowsApp1.MephButton()
        Me.MephTextBox2 = New WindowsApp1.MephTextBox()
        Me.MephTextBox1 = New WindowsApp1.MephTextBox()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Controls.Add(Me.MephTextBox3)
        Me.MephTheme1.Controls.Add(Me.MephButton57)
        Me.MephTheme1.Controls.Add(Me.MephTextBox2)
        Me.MephTheme1.Controls.Add(Me.MephTextBox1)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(284, 231)
        Me.MephTheme1.SubHeader = "$AddPet MONSTERVNUM LEVEL"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "AddPet"
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
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 198)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 49
        Me.MephButton1.Text = "Back"
        '
        'MephTextBox3
        '
        Me.MephTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox3.Enabled = False
        Me.MephTextBox3.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox3.Location = New System.Drawing.Point(12, 168)
        Me.MephTextBox3.MaxLength = 32767
        Me.MephTextBox3.MultiLine = True
        Me.MephTextBox3.Name = "MephTextBox3"
        Me.MephTextBox3.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox3.TabIndex = 48
        Me.MephTextBox3.Text = "LEVEL = Pet Level"
        Me.MephTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox3.UseSystemPasswordChar = False
        Me.MephTextBox3.WordWrap = False
        '
        'MephButton57
        '
        Me.MephButton57.BackColor = System.Drawing.Color.Transparent
        Me.MephButton57.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton57.Location = New System.Drawing.Point(12, 139)
        Me.MephButton57.Name = "MephButton57"
        Me.MephButton57.Size = New System.Drawing.Size(260, 23)
        Me.MephButton57.TabIndex = 47
        Me.MephButton57.Text = "$SearchMonster"
        '
        'MephTextBox2
        '
        Me.MephTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox2.Enabled = False
        Me.MephTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox2.Location = New System.Drawing.Point(12, 109)
        Me.MephTextBox2.MaxLength = 32767
        Me.MephTextBox2.MultiLine = True
        Me.MephTextBox2.Name = "MephTextBox2"
        Me.MephTextBox2.Size = New System.Drawing.Size(260, 24)
        Me.MephTextBox2.TabIndex = 46
        Me.MephTextBox2.Text = "VNUM you can get over $SearchMonster."
        Me.MephTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox2.UseSystemPasswordChar = False
        Me.MephTextBox2.WordWrap = False
        '
        'MephTextBox1
        '
        Me.MephTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox1.Enabled = False
        Me.MephTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox1.Location = New System.Drawing.Point(12, 64)
        Me.MephTextBox1.MaxLength = 32767
        Me.MephTextBox1.MultiLine = True
        Me.MephTextBox1.Name = "MephTextBox1"
        Me.MephTextBox1.Size = New System.Drawing.Size(260, 39)
        Me.MephTextBox1.TabIndex = 45
        Me.MephTextBox1.Text = "This command adds you a Pet. (Need to be in Miniland)"
        Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox1.UseSystemPasswordChar = False
        Me.MephTextBox1.WordWrap = False
        '
        'AddPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 231)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPet"
        Me.Text = "AddPet"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephTextBox3 As MephTextBox
    Friend WithEvents MephButton57 As MephButton
    Friend WithEvents MephTextBox2 As MephTextBox
    Friend WithEvents MephTextBox1 As MephTextBox
End Class
