Imports System.Data.SqlClient
Public Class FrmDamageData
    Dim databaru As Boolean

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        da = New SqlDataAdapter("SELECT * FROM Damage", konek)
        ds.Clear()
        da.Fill(ds, "Damage")
        DataGridView1.DataSource = (ds.Tables("Damage"))
    End Sub

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
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
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub FrmDamageData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet2.Damage' table. You can move, or remove it, as needed.
        Me.DamageTableAdapter.Fill(Me.APP_CAR_RENTALDataSet2.Damage)
        databaru = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmMasterData.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin menyimpan data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                End If
                sql = "INSERT INTO Damage(Damage) VALUES('" & TextBox2.Text & "')"
                jalankansql(sql)
                MsgBox("Data berhasil disimpan!", vbInformation)
                tampilkandata()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin mengubah data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                End If
                sql = "UPDATE Damage SET Damage = '" + TextBox2.Text + "' WHERE IDDamage = '" + TextBox1.Text + "'"
                jalankansql(sql)
                MsgBox("Data berhasil diubah!", vbInformation)
                tampilkandata()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin menghapus data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                End If
                sql = "DELETE FROM Damage WHERE IDDamage LIKE '" + TextBox1.Text + "'"
                jalankansql(sql)
                MsgBox("Data berhasil dihapus!", vbInformation)
                tampilkandata()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bersihkandata()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class