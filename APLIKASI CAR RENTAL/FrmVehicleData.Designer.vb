﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehicleData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PoliceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransmissionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CAR_RENTALDataSet1 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet1()
        Me.VehicleTableAdapter = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet1TableAdapters.VehicleTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.Control
        Me.Button7.Location = New System.Drawing.Point(498, 9)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 26)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Back"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Vehicle Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(581, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "_________________________________________________________________________________" &
    "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Car Rental ""The Blues"""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(75, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Status :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(21, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Year Of Purchase :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(81, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Color :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(44, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Transmission :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(62, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Car Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(36, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Police Number :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 36
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(454, 20)
        Me.TextBox2.TabIndex = 37
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.Location = New System.Drawing.Point(140, 130)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Automatic"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.Location = New System.Drawing.Point(240, 130)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Manual"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(140, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 40
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(140, 176)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 41
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(140, 199)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(12, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(581, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "_________________________________________________________________________________" &
    "_"
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Location = New System.Drawing.Point(516, 248)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(369, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 23)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Insert New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(176, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(95, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(14, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PoliceNumberDataGridViewTextBoxColumn, Me.CarTypeDataGridViewTextBoxColumn, Me.TransmissionDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.YearOfPurchaseDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(581, 150)
        Me.DataGridView1.TabIndex = 49
        '
        'PoliceNumberDataGridViewTextBoxColumn
        '
        Me.PoliceNumberDataGridViewTextBoxColumn.DataPropertyName = "PoliceNumber"
        Me.PoliceNumberDataGridViewTextBoxColumn.HeaderText = "PoliceNumber"
        Me.PoliceNumberDataGridViewTextBoxColumn.Name = "PoliceNumberDataGridViewTextBoxColumn"
        Me.PoliceNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarTypeDataGridViewTextBoxColumn
        '
        Me.CarTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.HeaderText = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.Name = "CarTypeDataGridViewTextBoxColumn"
        Me.CarTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransmissionDataGridViewTextBoxColumn
        '
        Me.TransmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission"
        Me.TransmissionDataGridViewTextBoxColumn.HeaderText = "Transmission"
        Me.TransmissionDataGridViewTextBoxColumn.Name = "TransmissionDataGridViewTextBoxColumn"
        Me.TransmissionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearOfPurchaseDataGridViewTextBoxColumn
        '
        Me.YearOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "YearOfPurchase"
        Me.YearOfPurchaseDataGridViewTextBoxColumn.HeaderText = "YearOfPurchase"
        Me.YearOfPurchaseDataGridViewTextBoxColumn.Name = "YearOfPurchaseDataGridViewTextBoxColumn"
        Me.YearOfPurchaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.APP_CAR_RENTALDataSet1
        '
        'APP_CAR_RENTALDataSet1
        '
        Me.APP_CAR_RENTALDataSet1.DataSetName = "APP_CAR_RENTALDataSet1"
        Me.APP_CAR_RENTALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'FrmVehicleData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(606, 453)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVehicleData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Data"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents APP_CAR_RENTALDataSet1 As APP_CAR_RENTALDataSet1
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As APP_CAR_RENTALDataSet1TableAdapters.VehicleTableAdapter
    Friend WithEvents PoliceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransmissionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearOfPurchaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
