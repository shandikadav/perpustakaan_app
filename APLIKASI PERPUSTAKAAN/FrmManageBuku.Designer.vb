<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageBuku
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
        Me.DB_APP_PERPUSTAKAANDataSet1 = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet1()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuTableAdapter = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet1TableAdapters.bukuTableAdapter()
        Me.KdbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdkatalogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahuncetakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengarahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SynopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeskripsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoverbukuDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BarcodeDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_APP_PERPUSTAKAANDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(123, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MENU MANAJEMEN BUKU"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(538, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 23)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Kembali"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdbukuDataGridViewTextBoxColumn, Me.KdkatalogDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.TahuncetakDataGridViewTextBoxColumn, Me.IsbnDataGridViewTextBoxColumn, Me.PengarahDataGridViewTextBoxColumn, Me.SynopsisDataGridViewTextBoxColumn, Me.DeskripsiDataGridViewTextBoxColumn, Me.CoverbukuDataGridViewImageColumn, Me.BarcodeDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.BukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 150)
        Me.DataGridView1.TabIndex = 43
        '
        'DB_APP_PERPUSTAKAANDataSet1
        '
        Me.DB_APP_PERPUSTAKAANDataSet1.DataSetName = "DB_APP_PERPUSTAKAANDataSet1"
        Me.DB_APP_PERPUSTAKAANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "buku"
        Me.BukuBindingSource.DataSource = Me.DB_APP_PERPUSTAKAANDataSet1
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'KdbukuDataGridViewTextBoxColumn
        '
        Me.KdbukuDataGridViewTextBoxColumn.DataPropertyName = "Kdbuku"
        Me.KdbukuDataGridViewTextBoxColumn.HeaderText = "Kdbuku"
        Me.KdbukuDataGridViewTextBoxColumn.Name = "KdbukuDataGridViewTextBoxColumn"
        '
        'KdkatalogDataGridViewTextBoxColumn
        '
        Me.KdkatalogDataGridViewTextBoxColumn.DataPropertyName = "Kdkatalog"
        Me.KdkatalogDataGridViewTextBoxColumn.HeaderText = "Kdkatalog"
        Me.KdkatalogDataGridViewTextBoxColumn.Name = "KdkatalogDataGridViewTextBoxColumn"
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        '
        'TahuncetakDataGridViewTextBoxColumn
        '
        Me.TahuncetakDataGridViewTextBoxColumn.DataPropertyName = "Tahun_cetak"
        Me.TahuncetakDataGridViewTextBoxColumn.HeaderText = "Tahun_cetak"
        Me.TahuncetakDataGridViewTextBoxColumn.Name = "TahuncetakDataGridViewTextBoxColumn"
        '
        'IsbnDataGridViewTextBoxColumn
        '
        Me.IsbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn"
        Me.IsbnDataGridViewTextBoxColumn.HeaderText = "Isbn"
        Me.IsbnDataGridViewTextBoxColumn.Name = "IsbnDataGridViewTextBoxColumn"
        '
        'PengarahDataGridViewTextBoxColumn
        '
        Me.PengarahDataGridViewTextBoxColumn.DataPropertyName = "Pengarah"
        Me.PengarahDataGridViewTextBoxColumn.HeaderText = "Pengarah"
        Me.PengarahDataGridViewTextBoxColumn.Name = "PengarahDataGridViewTextBoxColumn"
        '
        'SynopsisDataGridViewTextBoxColumn
        '
        Me.SynopsisDataGridViewTextBoxColumn.DataPropertyName = "Synopsis"
        Me.SynopsisDataGridViewTextBoxColumn.HeaderText = "Synopsis"
        Me.SynopsisDataGridViewTextBoxColumn.Name = "SynopsisDataGridViewTextBoxColumn"
        '
        'DeskripsiDataGridViewTextBoxColumn
        '
        Me.DeskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi"
        Me.DeskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi"
        Me.DeskripsiDataGridViewTextBoxColumn.Name = "DeskripsiDataGridViewTextBoxColumn"
        '
        'CoverbukuDataGridViewImageColumn
        '
        Me.CoverbukuDataGridViewImageColumn.DataPropertyName = "Cover_buku"
        Me.CoverbukuDataGridViewImageColumn.HeaderText = "Cover_buku"
        Me.CoverbukuDataGridViewImageColumn.Name = "CoverbukuDataGridViewImageColumn"
        '
        'BarcodeDataGridViewImageColumn
        '
        Me.BarcodeDataGridViewImageColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewImageColumn.HeaderText = "Barcode"
        Me.BarcodeDataGridViewImageColumn.Name = "BarcodeDataGridViewImageColumn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(89, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Pengarah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(89, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(89, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Tahun Cetak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(89, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(89, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Kode Katalog"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(89, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Kode Buku"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(79, 562)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Cover Buku"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(89, 510)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Deskripsi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(89, 452)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Synopsis"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(195, 291)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 54
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(195, 319)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 20)
        Me.TextBox2.TabIndex = 55
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(195, 346)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 20)
        Me.TextBox3.TabIndex = 56
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(195, 400)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 20)
        Me.TextBox4.TabIndex = 58
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(195, 426)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(213, 20)
        Me.TextBox5.TabIndex = 59
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(195, 452)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(213, 52)
        Me.TextBox6.TabIndex = 60
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(195, 510)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(213, 46)
        Me.TextBox7.TabIndex = 61
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(195, 562)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(176, 20)
        Me.TextBox8.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(377, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 22)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(497, 625)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 30)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "HAPUS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(271, 625)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 30)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "UBAH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(19, 625)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "TAMBAH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(414, 486)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(195, 372)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker1.TabIndex = 68
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(414, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 23)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FrmManageBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(624, 667)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmManageBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageBuku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_APP_PERPUSTAKAANDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_APP_PERPUSTAKAANDataSet1 As DB_APP_PERPUSTAKAANDataSet1
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As DB_APP_PERPUSTAKAANDataSet1TableAdapters.bukuTableAdapter
    Friend WithEvents KdbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KdkatalogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahuncetakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengarahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SynopsisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeskripsiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoverbukuDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents BarcodeDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
End Class
