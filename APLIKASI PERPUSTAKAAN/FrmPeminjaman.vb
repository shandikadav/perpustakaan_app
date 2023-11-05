Public Class FrmPeminjaman
    Private Sub FrmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_APP_PERPUSTAKAANDataSet5.sirkulasi' table. You can move, or remove it, as needed.
        Me.sirkulasiTableAdapter.Fill(Me.DB_APP_PERPUSTAKAANDataSet5.sirkulasi)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmOperator.Show()
        Me.Hide()
    End Sub
End Class