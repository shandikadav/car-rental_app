Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class FrmDriverData
    Dim databaru As Boolean
    Dim gender As String

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DateTimePicker1.ResetText()
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox1.Image = Nothing

    End Sub

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT * FROM Driver", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Driver")
        DataGridView1.DataSource = (ds.Tables("Driver"))

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
    Private Sub FrmCarRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet.Driver' table. You can move, or remove it, as needed.
        Me.DriverTableAdapter.Fill(Me.APP_CAR_RENTALDataSet.Driver)
        TextBox1.Enabled = False
        TextBox1.Text = 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmMasterData.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "PILIH GAMBAR(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        konekdb()
        If TextBox2.Text = "" Or RadioButton1.Checked = False Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap!", vbInformation)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MsgBox("Apakah anda yakin ingin menyimpan Data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
                TextBox1.Focus()
            End If
            Dim cmd As New SqlCommand("INSERT INTO Driver (DriverName,Gender,DateOfBirth,Address,Contact,Photo)VALUES(@name,@gender,@date,@address,@contact,@photo)", konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox2.Text
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTimePicker1.Value
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = TextBox4.Text
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil disimpan!", vbInformation)
                tampilkandata()
            Else
                MsgBox("Data gagal disimpan!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Then
            MsgBox("Silahkan isi Kode data driver yang ingin di Ubah terlebih dahulu!", vbExclamation)
            Exit Sub
        Else
            pesan = MsgBox("Apakah anda ingin melanjutkan mengubah data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
                TextBox1.Focus()
            End If
            Dim ubah As String = "UPDATE Driver SET DriverName = '" + TextBox2.Text + "', Gender = '" + gender + "', DateOfBirth = '" + DateTimePicker1.Value + "', Address = '" + TextBox3.Text + "', Contact = '" + TextBox4.Text + "', Photo=@photo WHERE IDDriver = '" + TextBox1.Text + "'"
            Dim cmd As New SqlCommand(ubah, konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img As Byte()
            img = ms.ToArray
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = img
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil diubah!", vbInformation)
                tampilkandata()
            Else
                MsgBox("Data gagal diubah!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Then
            MsgBox("Silahkan isi kode data driver yang ingin dihapus terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MsgBox("Apakah anda yakin ingin melanjutkan menghapus data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "DELETE FROM Driver WHERE IDDriver LIKE '" + TextBox1.Text + "'"
            jalankansql(sql)
            MsgBox("Data berhasil dihapus!", vbInformation)
            tampilkandata()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class