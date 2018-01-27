<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ThirteenForm1 = New NosLegion_Workspace.ThirteenForm()
        Me.ThirteenButton2 = New NosLegion_Workspace.ThirteenButton()
        Me.ThirteenButton1 = New NosLegion_Workspace.ThirteenButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThirteenForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = NosLegion_Workspace.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.Label1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton2)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton1)
        Me.ThirteenForm1.Controls.Add(Me.Panel1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(699, 704)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "Workspace NosLegion"
        '
        'ThirteenButton2
        '
        Me.ThirteenButton2.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton2.ColorScheme = NosLegion_Workspace.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton2.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton2.Location = New System.Drawing.Point(646, 3)
        Me.ThirteenButton2.Name = "ThirteenButton2"
        Me.ThirteenButton2.Size = New System.Drawing.Size(22, 23)
        Me.ThirteenButton2.TabIndex = 2
        Me.ThirteenButton2.Text = "-"
        Me.ThirteenButton2.UseVisualStyleBackColor = False
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton1.ColorScheme = NosLegion_Workspace.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(674, 3)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(22, 23)
        Me.ThirteenButton1.TabIndex = 1
        Me.ThirteenButton1.Text = "x"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 667)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(490, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Made by Loki and Hunter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 704)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThirteenForm1 As ThirteenForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ThirteenButton1 As ThirteenButton
    Friend WithEvents ThirteenButton2 As ThirteenButton
    Friend WithEvents Label1 As Label
End Class
