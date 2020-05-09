<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Station
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New WindowsApp4.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New WindowsApp4.DataSet2()
        Me.TRAINSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRAINSTableAdapter = New WindowsApp4.DataSet2TableAdapters.TRAINSTableAdapter()
        Me.STNIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRAINSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STNIDDataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TRAINSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(248, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRAINSBindingSource
        '
        Me.TRAINSBindingSource.DataMember = "TRAINS"
        Me.TRAINSBindingSource.DataSource = Me.DataSet2
        '
        'TRAINSTableAdapter
        '
        Me.TRAINSTableAdapter.ClearBeforeFill = True
        '
        'STNIDDataGridViewTextBoxColumn
        '
        Me.STNIDDataGridViewTextBoxColumn.DataPropertyName = "STN_ID"
        Me.STNIDDataGridViewTextBoxColumn.HeaderText = "STN_ID"
        Me.STNIDDataGridViewTextBoxColumn.Name = "STNIDDataGridViewTextBoxColumn"
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        '
        'Station
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Station"
        Me.Text = "Station"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRAINSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents TRAINSBindingSource As BindingSource
    Friend WithEvents TRAINSTableAdapter As DataSet2TableAdapters.TRAINSTableAdapter
    Friend WithEvents STNIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
