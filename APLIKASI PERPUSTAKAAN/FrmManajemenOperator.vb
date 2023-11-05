Public Class FrmManajemenOperator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmManageAnggota.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmManageBuku.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmManageKatalog.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmOperator.Show()
        Me.Hide()

    End Sub
End Class