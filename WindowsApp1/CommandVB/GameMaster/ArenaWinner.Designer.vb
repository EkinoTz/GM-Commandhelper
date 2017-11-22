<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArenaWinner
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
        Dim PictureBox2 As System.Windows.Forms.PictureBox
        Me.MephTheme1 = New WindowsApp1.MephTheme()
        Me.MephTextBox1 = New WindowsApp1.MephTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MephTextBox2 = New WindowsApp1.MephTextBox()
        Me.MephTextBox3 = New WindowsApp1.MephTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MephButton1 = New WindowsApp1.MephButton()
        PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Controls.Add(Me.PictureBox3)
        Me.MephTheme1.Controls.Add(Me.MephTextBox3)
        Me.MephTheme1.Controls.Add(Me.MephTextBox2)
        Me.MephTheme1.Controls.Add(PictureBox2)
        Me.MephTheme1.Controls.Add(Me.MephTextBox1)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(730, 376)
        Me.MephTheme1.SubHeader = "$ArenaWinner"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "ArenaWinner"
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
        Me.MephTextBox1.Size = New System.Drawing.Size(706, 24)
        Me.MephTextBox1.TabIndex = 1
        Me.MephTextBox1.Text = "Activates the Arenawings"
        Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox1.UseSystemPasswordChar = False
        Me.MephTextBox1.WordWrap = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.ArenaWinnerOn
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        PictureBox2.BackColor = System.Drawing.Color.Transparent
        PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.ArenaWinnerOff
        PictureBox2.Location = New System.Drawing.Point(368, 94)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(350, 214)
        PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        '
        'MephTextBox2
        '
        Me.MephTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox2.Enabled = False
        Me.MephTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox2.Location = New System.Drawing.Point(12, 314)
        Me.MephTextBox2.MaxLength = 32767
        Me.MephTextBox2.MultiLine = True
        Me.MephTextBox2.Name = "MephTextBox2"
        Me.MephTextBox2.Size = New System.Drawing.Size(350, 24)
        Me.MephTextBox2.TabIndex = 3
        Me.MephTextBox2.Text = "Arenawings On"
        Me.MephTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox2.UseSystemPasswordChar = False
        Me.MephTextBox2.WordWrap = False
        '
        'MephTextBox3
        '
        Me.MephTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox3.Enabled = False
        Me.MephTextBox3.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox3.Location = New System.Drawing.Point(368, 314)
        Me.MephTextBox3.MaxLength = 32767
        Me.MephTextBox3.MultiLine = True
        Me.MephTextBox3.Name = "MephTextBox3"
        Me.MephTextBox3.Size = New System.Drawing.Size(350, 24)
        Me.MephTextBox3.TabIndex = 4
        Me.MephTextBox3.Text = "Arenawings Off"
        Me.MephTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MephTextBox3.UseSystemPasswordChar = False
        Me.MephTextBox3.WordWrap = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.InitialImage = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox3.Location = New System.Drawing.Point(677, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 344)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(706, 23)
        Me.MephButton1.TabIndex = 54
        Me.MephButton1.Text = "Back"
        '
        'ArenaWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 376)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArenaWinner"
        Me.Text = "ArenaWinner"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephTextBox1 As MephTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MephTextBox3 As MephTextBox
    Friend WithEvents MephTextBox2 As MephTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MephButton1 As MephButton
End Class
