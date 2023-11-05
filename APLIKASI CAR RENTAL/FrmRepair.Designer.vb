<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRepair
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
        Me.APP_CAR_RENTALDataSet6 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet6()
        Me.RepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairTableAdapter = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet6TableAdapters.RepairTableAdapter()
        Me.APP_CAR_RENTALDataSet5 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet5()
        Me.APPCARRENTALDataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CAR_RENTALDataSet7 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet7()
        Me.RepairBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairTableAdapter1 = New APLIKASI_CAR_RENTAL.APP_CAR_RENTALDataSet7TableAdapters.RepairTableAdapter()
        Me.RepairNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfRepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoliceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPCARRENTALDataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CAR_RENTALDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(667, 333)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(13, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(667, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(589, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(502, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairNumberDataGridViewTextBoxColumn, Me.DateOfRepairDataGridViewTextBoxColumn, Me.PoliceNumberDataGridViewTextBoxColumn, Me.IDDamageDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RepairBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(13, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(729, 259)
        Me.DataGridView1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search :"
        '
        'APP_CAR_RENTALDataSet6
        '
        Me.APP_CAR_RENTALDataSet6.DataSetName = "APP_CAR_RENTALDataSet6"
        Me.APP_CAR_RENTALDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepairBindingSource
        '
        Me.RepairBindingSource.DataMember = "Repair"
        Me.RepairBindingSource.DataSource = Me.APP_CAR_RENTALDataSet6
        '
        'RepairTableAdapter
        '
        Me.RepairTableAdapter.ClearBeforeFill = True
        '
        'APP_CAR_RENTALDataSet5
        '
        Me.APP_CAR_RENTALDataSet5.DataSetName = "APP_CAR_RENTALDataSet5"
        Me.APP_CAR_RENTALDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APPCARRENTALDataSet5BindingSource
        '
        Me.APPCARRENTALDataSet5BindingSource.DataSource = Me.APP_CAR_RENTALDataSet5
        Me.APPCARRENTALDataSet5BindingSource.Position = 0
        '
        'APP_CAR_RENTALDataSet7
        '
        Me.APP_CAR_RENTALDataSet7.DataSetName = "APP_CAR_RENTALDataSet7"
        Me.APP_CAR_RENTALDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepairBindingSource1
        '
        Me.RepairBindingSource1.DataMember = "Repair"
        Me.RepairBindingSource1.DataSource = Me.APP_CAR_RENTALDataSet7
        '
        'RepairTableAdapter1
        '
        Me.RepairTableAdapter1.ClearBeforeFill = True
        '
        'RepairNumberDataGridViewTextBoxColumn
        '
        Me.RepairNumberDataGridViewTextBoxColumn.DataPropertyName = "RepairNumber"
        Me.RepairNumberDataGridViewTextBoxColumn.HeaderText = "RepairNumber"
        Me.RepairNumberDataGridViewTextBoxColumn.Name = "RepairNumberDataGridViewTextBoxColumn"
        Me.RepairNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfRepairDataGridViewTextBoxColumn
        '
        Me.DateOfRepairDataGridViewTextBoxColumn.DataPropertyName = "DateOfRepair"
        Me.DateOfRepairDataGridViewTextBoxColumn.HeaderText = "DateOfRepair"
        Me.DateOfRepairDataGridViewTextBoxColumn.Name = "DateOfRepairDataGridViewTextBoxColumn"
        Me.DateOfRepairDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoliceNumberDataGridViewTextBoxColumn
        '
        Me.PoliceNumberDataGridViewTextBoxColumn.DataPropertyName = "PoliceNumber"
        Me.PoliceNumberDataGridViewTextBoxColumn.HeaderText = "PoliceNumber"
        Me.PoliceNumberDataGridViewTextBoxColumn.Name = "PoliceNumberDataGridViewTextBoxColumn"
        Me.PoliceNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDamageDataGridViewTextBoxColumn
        '
        Me.IDDamageDataGridViewTextBoxColumn.DataPropertyName = "IDDamage"
        Me.IDDamageDataGridViewTextBoxColumn.HeaderText = "IDDamage"
        Me.IDDamageDataGridViewTextBoxColumn.Name = "IDDamageDataGridViewTextBoxColumn"
        Me.IDDamageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmRepair
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
        Me.Name = "FrmRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Vehicle Repair"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPCARRENTALDataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CAR_RENTALDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents APP_CAR_RENTALDataSet6 As APP_CAR_RENTALDataSet6
    Friend WithEvents RepairBindingSource As BindingSource
    Friend WithEvents RepairTableAdapter As APP_CAR_RENTALDataSet6TableAdapters.RepairTableAdapter
    Friend WithEvents APPCARRENTALDataSet5BindingSource As BindingSource
    Friend WithEvents APP_CAR_RENTALDataSet5 As APP_CAR_RENTALDataSet5
    Friend WithEvents APP_CAR_RENTALDataSet7 As APP_CAR_RENTALDataSet7
    Friend WithEvents RepairBindingSource1 As BindingSource
    Friend WithEvents RepairTableAdapter1 As APP_CAR_RENTALDataSet7TableAdapters.RepairTableAdapter
    Friend WithEvents RepairNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfRepairDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PoliceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDamageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
