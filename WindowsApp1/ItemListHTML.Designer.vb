﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemListHTML
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
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(1106, 606)
        Me.MephTheme1.SubHeader = ""
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Item List"
        '
        'ItemListHTML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 606)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemListHTML"
        Me.Text = "Item List"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
End Class