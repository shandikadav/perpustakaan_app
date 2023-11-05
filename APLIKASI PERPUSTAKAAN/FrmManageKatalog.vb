Public Class FrmManageKatalog
    Private Sub FrmManageKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_APP_PERPUSTAKAANDataSet2.katalog_buku' table. You can move, or remove it, as needed.
        Me.Katalog_bukuTableAdapter.Fill(Me.DB_APP_PERPUSTAKAANDataSet2.katalog_buku)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If FrmAdmin.Label3.Text = "Administrator" Then
            FrmAdminManajemen.Show()
            Me.Hide()
        ElseIf FrmOperator.label3.Text = "Operator" Then
            FrmManajemenOperator.Show
            Me.Hide()

        End If
    End Sub
End Class