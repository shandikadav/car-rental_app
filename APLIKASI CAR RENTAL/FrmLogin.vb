Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Account WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            If rd.Item(1).ToString = "Admin" Then
                MsgBox("Login Admin berhasil!", vbInformation)
                FrmMasterData.Label2.Text = rd.Item(1)
                FrmMasterData.Show()
                Me.Hide()
            ElseIf rd.Item(1).ToString = "Operator" Then
                MsgBox("Login Operator berhasil!", vbInformation)
                FrmTransactionData.Label2.Text = rd.Item(1)
                FrmTransactionData.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Username dan Password salah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        konekdb()
    End Sub
End Class
