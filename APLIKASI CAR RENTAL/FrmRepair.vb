Imports System.Data.SqlClient
Public Class FrmRepair

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT RepairNumber,DateOfRepair,PoliceNumber,Cartype,IDDamage,Damage,Cost FROM Repair,Vehicle,Damage WHERE Vehicle.PoliceNumber = Repair.PoliceNumber AND Repair.IDDamage = Damage.IDDamage", konek)
        ds.Clear()
        da.Fill(ds, "Repair,Vehicle,Damage")
        DataGridView1.DataSource = (ds.Tables("Repair,Vehicle,Damage"))
    End Sub
    Private Sub FrmRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet7.Repair' table. You can move, or remove it, as needed.
        Me.RepairTableAdapter1.Fill(Me.APP_CAR_RENTALDataSet7.Repair)
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet6.Repair' table. You can move, or remove it, as needed.
        Me.RepairTableAdapter.Fill(Me.APP_CAR_RENTALDataSet6.Repair)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmTransactionData.Show()
        Me.Hide()
    End Sub
End Class