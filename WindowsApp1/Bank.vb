Public Class Bank
    Private Sub MephButton5_Click(sender As Object, e As EventArgs) Handles MephButton5.Click
        Close()
        GMCommands.Show()
    End Sub

    Private Sub MephButton18_Click(sender As Object, e As EventArgs) Handles MephButton18.Click
        BankHelp.Show()
        Close()
    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        BankBalance.Show()
        Close()
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        BankDeposit.Show()
        Close()
    End Sub

    Private Sub MephButton3_Click(sender As Object, e As EventArgs) Handles MephButton3.Click
        BankWithdraw.Show()
        Close()
    End Sub

    Private Sub MephButton4_Click(sender As Object, e As EventArgs) Handles MephButton4.Click
        BankSend.Show()
        Close()
    End Sub
End Class