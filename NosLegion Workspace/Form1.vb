Imports CefSharp.WinForms
Imports CefSharp

Public Class Form1

    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browser = New ChromiumWebBrowser("https://docs.google.com/spreadsheets/d/1sChRyXQKywtdlaR-Z9HiU360tN6fEq60Alo31kMkw0s/edit#gid=0") With {
            .Dock = DockStyle.Fill
        }
        Panel1.Controls.Add(browser)

    End Sub

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        Close()
    End Sub

    Private Sub ThirteenButton2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class