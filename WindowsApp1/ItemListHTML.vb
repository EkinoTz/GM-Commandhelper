Imports CefSharp.Winforms
Imports CefSharp

Public Class ItemListHTML

    Private WithEvents Browser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        Browser = New ChromiumWebBrowser("file:///C:/Users/Randy/Desktop/ItemWeb/item.html") With
            {
                .Dock = DockStyle.Fill
            }
        Panel1.Controls.Add(Browser)

    End Sub


    Private Sub ItemListHTML_Load(sender As Object, e As EventArgs) Handles Me.Load
        MephButton1.Parent = Panel1.Parent
    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Me.Hide()
    End Sub

    Private Sub MephTheme1_Click(sender As Object, e As EventArgs) Handles MephTheme1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class