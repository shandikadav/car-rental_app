Imports System.Data.SqlClient
Public Class FrmAddRental

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub
    Private Sub FrmAddRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 1
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmRental.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox2.Focus()
        Else
            pesan = MsgBox("Apakah Anda yakin ingin menyimpan data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "INSERT INTO Rental(DateOfTransaction,PoliceNumber,IDDriver,NumberDays,TotalCost)VALUES('" & DateTimePicker1.Value & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
            jalankansql(sql)
            MsgBox("Data berhasil disimpan!", vbInformation)
            bersihkandata()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Vehicle WHERE PoliceNumber = '" + TextBox2.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox3.Text = rd.Item(1)
        Else
            MsgBox("Data tidak ditemukan!", vbExclamation)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Driver WHERE IDDriver = '" + TextBox4.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox5.Text = rd.Item(1)
        Else
            MsgBox("Data tidak ditemukan!", vbExclamation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox2.Focus()
        Else
            pesan = MsgBox("Apakah Anda yakin ingin mengubah data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "UPDATE Rental SET DateOfTransaction = '" + DateTimePicker1.Value + "',PoliceNumber = '" + TextBox2.Text + "', IDDriver = '" + TextBox4.Text + "' NumberDays = '" + TextBox6.Text + "', TotalCost= '" + TextBox7.Text + "'"
            jalankansql(sql)
            MsgBox("Data berhasil ubah!", vbInformation)
            bersihkandata()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox2.Focus()
        Else
            pesan = MsgBox("Apakah Anda yakin ingin menghapus data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "DELETE From Rental WHERE IDTransaction LIKE '" + TextBox1.Text + "'"
            jalankansql(sql)
            MsgBox("Data berhasil hapus!", vbInformation)
            bersihkandata()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Rental WHERE IDTransaction = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox1.Text = rd.Item(0)
            DateTimePicker1.Value = rd.Item(1)
            TextBox2.Text = rd.Item(2)
            TextBox4.Text = rd.Item(3)
            TextBox6.Text = rd.Item(4)
            TextBox7.Text = rd.Item(5)
        Else
            MsgBox("Data tidak ditemukan!", vbExclamation)
        End If
    End Sub
End Class