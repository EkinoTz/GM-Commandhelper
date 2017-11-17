<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portaltypes
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
        Me.MephComboBox1 = New WindowsApp1.MephComboBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.MephButton1 = New WindowsApp1.MephButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephComboBox1)
        Me.MephTheme1.Controls.Add(Me.PictureBox14)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Controls.Add(Me.Label15)
        Me.MephTheme1.Controls.Add(Me.Label14)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(277, 436)
        Me.MephTheme1.SubHeader = "Picture + Type Number"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "PortalTypes"
        '
        'MephComboBox1
        '
        Me.MephComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.MephComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MephComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MephComboBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.MephComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.MephComboBox1.FormattingEnabled = True
        Me.MephComboBox1.ItemHeight = 16
        Me.MephComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MephComboBox1.Items.AddRange(New Object() {"Portaltype -1", "Portaltype 0", "Portaltype 1", "Portaltype 2", "Portaltype 3", "Portaltype 4", "Portaltype 5", "Portaltype 6", "Portaltype 7", "Portaltype 8", "Portaltype 10", "Portaltype 11", "Portaltype 12", "Portaltype 20"})
        Me.MephComboBox1.Location = New System.Drawing.Point(12, 36)
        Me.MephComboBox1.Name = "MephComboBox1"
        Me.MephComboBox1.Size = New System.Drawing.Size(252, 22)
        Me.MephComboBox1.StartIndex = 0
        Me.MephComboBox1.TabIndex = 71
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox14.InitialImage = Global.WindowsApp1.My.Resources.Resources._971ccffd79b0fce57413eeabc777344e
        Me.PictureBox14.Location = New System.Drawing.Point(224, 3)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(50, 15)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 70
        Me.PictureBox14.TabStop = False
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(11, 404)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(252, 23)
        Me.MephButton1.TabIndex = 69
        Me.MephButton1.Text = "Close"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(172, 388)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "so be aware!"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(25, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Some Portales are closed"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Portaltype_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 321)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Portaltypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 436)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Portaltypes"
        Me.Text = "Portaltypes"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents MephComboBox1 As MephComboBox
End Class
