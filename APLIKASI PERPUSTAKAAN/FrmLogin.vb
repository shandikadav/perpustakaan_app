Imports System.Data.SqlClient
Public Class FrmLogin
    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM admin WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "' AND level = '" + ComboBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If ComboBox1.Text = "Admin" Then
            If rd.HasRows = True Then
                MsgBox("Login Admin berhasil!", vbInformation)
                FrmAdmin.Label3.Text = rd.Item(3)
                FrmAdmin.Show()
                Me.Hide()
                bersihkandata()
            End If
        ElseIf ComboBox1.Text = "Operator" Then
            If rd.HasRows = True Then
                MsgBox("Login Operator berhasil!", vbInformation)
                FrmOperator.Label3.Text = rd.Item(3)
                FrmOperator.Show()
                Me.Hide()
                bersihkandata()
            End If
        Else
            MessageBox.Show("Login gagal, silahkan cek Username atau Password!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bersihkandata()
        End If
    End Sub
End Class
