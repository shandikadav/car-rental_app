Imports System.Data.SqlClient
Public Class FrmRental

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT IDTransaction,DateOfTransaction,Rental.PoliceNumber,Cartype,Rental.IDDriver,DriverName,NumberDays,TotalCost FROM Rental,Vehicle,Driver WHERE Vehicle.PoliceNumber = Rental.PoliceNumber AND Driver.IDDriver = Rental.IDDriver", konek)
        ds.Clear()
        da.Fill(ds, "Rental")
        DataGridView1.DataSource = (ds.Tables("Rental"))
    End Sub
    Private Sub FrmRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet3.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.APP_CAR_RENTALDataSet3.Rental)
        tampilkandata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmTransactionData.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAddRental.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmReportRental.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT IDTransaction,DateOfTransaction,Rental.PoliceNumber,Cartype,Rental.IDDriver,DriverName,NumberDays,TotalCost FROM Rental,Vehicle,Driver"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class