<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bank
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MephTheme1 = New WindowsApp1.MephTheme()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MephButton5 = New WindowsApp1.MephButton()
        Me.MephButton4 = New WindowsApp1.MephButton()
        Me.MephButton3 = New WindowsApp1.MephButton()
        Me.MephButton2 = New WindowsApp1.MephButton()
        Me.MephButton1 = New WindowsApp1.MephButton()
        Me.MephButton18 = New WindowsApp1.MephButton()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.PictureBox2)
        Me.MephTheme1.Controls.Add(Me.MephButton5)
        Me.MephTheme1.Controls.Add(Me.MephButton4)
        Me.MephTheme1.Controls.Add(Me.MephButton3)
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Controls.Add(Me.MephButton18)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(284, 242)
        Me.MephTheme1.SubHeader = "$Bank"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Bank System"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.InitialImage = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox2.Location = New System.Drawing.Point(231, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'MephButton5
        '
        Me.MephButton5.BackColor = System.Drawing.Color.Transparent
        Me.MephButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton5.Location = New System.Drawing.Point(12, 208)
        Me.MephButton5.Name = "MephButton5"
        Me.MephButton5.Size = New System.Drawing.Size(260, 23)
        Me.MephButton5.TabIndex = 41
        Me.MephButton5.Text = "Close"
        '
        'MephButton4
        '
        Me.MephButton4.BackColor = System.Drawing.Color.Transparent
        Me.MephButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton4.Location = New System.Drawing.Point(12, 179)
        Me.MephButton4.Name = "MephButton4"
        Me.MephButton4.Size = New System.Drawing.Size(260, 23)
        Me.MephButton4.TabIndex = 40
        Me.MephButton4.Text = "$Bank Send"
        '
        'MephButton3
        '
        Me.MephButton3.BackColor = System.Drawing.Color.Transparent
        Me.MephButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton3.Location = New System.Drawing.Point(12, 150)
        Me.MephButton3.Name = "MephButton3"
        Me.MephButton3.Size = New System.Drawing.Size(260, 23)
        Me.MephButton3.TabIndex = 39
        Me.MephButton3.Text = "$Bank Withdraw"
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(12, 121)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(260, 23)
        Me.MephButton2.TabIndex = 38
        Me.MephButton2.Text = "$Bank Deposit"
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 92)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 37
        Me.MephButton1.Text = "$Bank Balance"
        '
        'MephButton18
        '
        Me.MephButton18.BackColor = System.Drawing.Color.Transparent
        Me.MephButton18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MephButton18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton18.Location = New System.Drawing.Point(12, 63)
        Me.MephButton18.Name = "MephButton18"
        Me.MephButton18.Size = New System.Drawing.Size(260, 23)
        Me.MephButton18.TabIndex = 36
        Me.MephButton18.Text = "$Bank Help"
        '
        'Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 242)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bank"
        Me.Text = "Bank"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephButton5 As MephButton
    Friend WithEvents MephButton4 As MephButton
    Friend WithEvents MephButton3 As MephButton
    Friend WithEvents MephButton2 As MephButton
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephButton18 As MephButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
