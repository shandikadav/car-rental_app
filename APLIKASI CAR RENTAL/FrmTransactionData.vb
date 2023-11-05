Public Class FrmTransactionData
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmLogin.TextBox1.Text = ""
        FrmLogin.TextBox2.Text = ""
        FrmLogin.CheckBox1.Checked = False
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmRental.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmRefund.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmRepair.Show()
        Me.Hide()
    End Sub
End Class