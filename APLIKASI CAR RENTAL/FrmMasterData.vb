Public Class FrmMasterData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmDriverData.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmVehicleData.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmDamageData.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmLogin.TextBox1.Text = ""
        FrmLogin.TextBox2.Text = ""
        FrmLogin.CheckBox1.Checked = False
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class