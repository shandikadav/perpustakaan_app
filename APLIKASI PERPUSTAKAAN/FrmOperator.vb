Public Class FrmOperator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmManajemenOperator.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmPeminjaman.Show()
        Me.Hide()
    End Sub
End Class