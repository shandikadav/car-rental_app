<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRefund
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APP_CAR_RENTALDataSet4 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet4()
        Me.APPCARRENTALDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverTableAdapter = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet4TableAdapters.DriverTableAdapter()
        Me.RefundBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefundTableAdapter = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet4TableAdapters.RefundTableAdapter()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet4TableAdapters.VehicleTableAdapter()
        Me.RefundBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CAR_RENTALDataSet5 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet5()
        Me.RefundBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefundTableAdapter1 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet5TableAdapters.RefundTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPCARRENTALDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefundBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefundBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefundBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(667, 333)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(13, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(667, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(589, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(502, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(729, 259)
        Me.DataGridView1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search :"
        '
        'APP_CAR_RENTALDataSet4
        '
        Me.APP_CAR_RENTALDataSet4.DataSetName = "APP_CAR_RENTALDataSet4"
        Me.APP_CAR_RENTALDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APPCARRENTALDataSet4BindingSource
        '
        Me.APPCARRENTALDataSet4BindingSource.DataSource = Me.APP_CAR_RENTALDataSet4
        Me.APPCARRENTALDataSet4BindingSource.Position = 0
        '
        'DriverBindingSource
        '
        Me.DriverBindingSource.DataMember = "Driver"
        Me.DriverBindingSource.DataSource = Me.APPCARRENTALDataSet4BindingSource
        '
        'DriverTableAdapter
        '
        Me.DriverTableAdapter.ClearBeforeFill = True
        '
        'RefundBindingSource
        '
        Me.RefundBindingSource.DataMember = "Refund"
        Me.RefundBindingSource.DataSource = Me.APPCARRENTALDataSet4BindingSource
        '
        'RefundTableAdapter
        '
        Me.RefundTableAdapter.ClearBeforeFill = True
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.APPCARRENTALDataSet4BindingSource
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'RefundBindingSource1
        '
        Me.RefundBindingSource1.DataMember = "Refund"
        Me.RefundBindingSource1.DataSource = Me.APPCARRENTALDataSet4BindingSource
        '
        'APP_CAR_RENTALDataSet5
        '
        Me.APP_CAR_RENTALDataSet5.DataSetName = "APP_CAR_RENTALDataSet5"
        Me.APP_CAR_RENTALDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RefundBindingSource2
        '
        Me.RefundBindingSource2.DataMember = "Refund"
        Me.RefundBindingSource2.DataSource = Me.APP_CAR_RENTALDataSet5
        '
        'RefundTableAdapter1
        '
        Me.RefundTableAdapter1.ClearBeforeFill = True
        '
        'FrmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(754, 368)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRefund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Refund Transaction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPCARRENTALDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefundBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefundBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefundBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents APPCARRENTALDataSet4BindingSource As BindingSource
    Friend WithEvents APP_CAR_RENTALDataSet4 As APP_CAR_RENTALDataSet4
    Friend WithEvents DriverBindingSource As BindingSource
    Friend WithEvents DriverTableAdapter As APP_CAR_RENTALDataSet4TableAdapters.DriverTableAdapter
    Friend WithEvents RefundBindingSource As BindingSource
    Friend WithEvents RefundTableAdapter As APP_CAR_RENTALDataSet4TableAdapters.RefundTableAdapter
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As APP_CAR_RENTALDataSet4TableAdapters.VehicleTableAdapter
    Friend WithEvents RefundBindingSource1 As BindingSource
    Friend WithEvents APP_CAR_RENTALDataSet5 As APP_CAR_RENTALDataSet5
    Friend WithEvents RefundBindingSource2 As BindingSource
    Friend WithEvents RefundTableAdapter1 As APP_CAR_RENTALDataSet5TableAdapters.RefundTableAdapter
End Class
