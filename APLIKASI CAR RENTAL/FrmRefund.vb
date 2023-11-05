Imports System.Data.SqlClient
Public Class FrmRefund
    Private Sub FrmRefund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet5.Refund' table. You can move, or remove it, as needed.
        Me.RefundTableAdapter1.Fill(Me.APP_CAR_RENTALDataSet5.Refund)
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet4.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.APP_CAR_RENTALDataSet4.Vehicle)
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet4.Refund' table. You can move, or remove it, as needed.
        Me.RefundTableAdapter.Fill(Me.APP_CAR_RENTALDataSet4.Refund)
        'TODO: This line of code loads data into the 'APP_CAR_RENTALDataSet4.Driver' table. You can move, or remove it, as needed.
        Me.DriverTableAdapter.Fill(Me.APP_CAR_RENTALDataSet4.Driver)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmTransactionData.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class