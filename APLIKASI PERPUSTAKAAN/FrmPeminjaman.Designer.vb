<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeminjaman
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DB_APP_PERPUSTAKAANDataSet5 = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet5()
        Me.sirkulasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sirkulasiTableAdapter = New APLIKASI_PERPUSTAKAAN.DB_APP_PERPUSTAKAANDataSet5TableAdapters.sirkulasiTableAdapter()
        CType(Me.DB_APP_PERPUSTAKAANDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sirkulasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sirkulasiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "APLIKASI_PERPUSTAKAAN.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(451, 249)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(361, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 30)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Kembali"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DB_APP_PERPUSTAKAANDataSet5
        '
        Me.DB_APP_PERPUSTAKAANDataSet5.DataSetName = "DB_APP_PERPUSTAKAANDataSet5"
        Me.DB_APP_PERPUSTAKAANDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sirkulasiBindingSource
        '
        Me.sirkulasiBindingSource.DataMember = "sirkulasi"
        Me.sirkulasiBindingSource.DataSource = Me.DB_APP_PERPUSTAKAANDataSet5
        '
        'sirkulasiTableAdapter
        '
        Me.sirkulasiTableAdapter.ClearBeforeFill = True
        '
        'FrmPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(475, 340)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPeminjaman"
        CType(Me.DB_APP_PERPUSTAKAANDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sirkulasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button5 As Button
    Friend WithEvents sirkulasiBindingSource As BindingSource
    Friend WithEvents DB_APP_PERPUSTAKAANDataSet5 As DB_APP_PERPUSTAKAANDataSet5
    Friend WithEvents sirkulasiTableAdapter As DB_APP_PERPUSTAKAANDataSet5TableAdapters.sirkulasiTableAdapter
End Class
