<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageKatalog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DB_APP_PERPUSTAKAANDataSet2 = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet2()
        Me.KatalogbukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Katalog_bukuTableAdapter = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet2TableAdapters.katalog_bukuTableAdapter()
        Me.KdkatalogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KatalogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_APP_PERPUSTAKAANDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KatalogbukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(101, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "MENU MANAJEMEN KATALOG"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(538, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 23)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Kembali"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdkatalogDataGridViewTextBoxColumn, Me.KatalogDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KatalogbukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 150)
        Me.DataGridView1.TabIndex = 44
        '
        'DB_APP_PERPUSTAKAANDataSet2
        '
        Me.DB_APP_PERPUSTAKAANDataSet2.DataSetName = "DB_APP_PERPUSTAKAANDataSet2"
        Me.DB_APP_PERPUSTAKAANDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KatalogbukuBindingSource
        '
        Me.KatalogbukuBindingSource.DataMember = "katalog_buku"
        Me.KatalogbukuBindingSource.DataSource = Me.DB_APP_PERPUSTAKAANDataSet2
        '
        'Katalog_bukuTableAdapter
        '
        Me.Katalog_bukuTableAdapter.ClearBeforeFill = True
        '
        'KdkatalogDataGridViewTextBoxColumn
        '
        Me.KdkatalogDataGridViewTextBoxColumn.DataPropertyName = "Kdkatalog"
        Me.KdkatalogDataGridViewTextBoxColumn.HeaderText = "Kdkatalog"
        Me.KdkatalogDataGridViewTextBoxColumn.Name = "KdkatalogDataGridViewTextBoxColumn"
        '
        'KatalogDataGridViewTextBoxColumn
        '
        Me.KatalogDataGridViewTextBoxColumn.DataPropertyName = "Katalog"
        Me.KatalogDataGridViewTextBoxColumn.HeaderText = "Katalog"
        Me.KatalogDataGridViewTextBoxColumn.Name = "KatalogDataGridViewTextBoxColumn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(138, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Katalog"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(138, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Kode Katalog"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 298)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 48
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(245, 326)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 82)
        Me.TextBox2.TabIndex = 49
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(510, 460)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 30)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "HAPUS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(266, 460)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 30)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "UBAH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(12, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "TAMBAH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmManageKatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(624, 502)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmManageKatalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageKatalog"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_APP_PERPUSTAKAANDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KatalogbukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_APP_PERPUSTAKAANDataSet2 As DB_APP_PERPUSTAKAANDataSet2
    Friend WithEvents KatalogbukuBindingSource As BindingSource
    Friend WithEvents Katalog_bukuTableAdapter As DB_APP_PERPUSTAKAANDataSet2TableAdapters.katalog_bukuTableAdapter
    Friend WithEvents KdkatalogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KatalogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
