Imports System.Data.SqlClient
Public Class FrmmanageAdmin
    Dim databaru As Boolean

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""

    End Sub

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT * FROM admin", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "admin")
        DataGridView1.DataSource = (ds.Tables("admin"))
    End Sub

    Private Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub
    Private Sub FrmmanageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_APP_PERPUSTAKAANDataSet3.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.DB_APP_PERPUSTAKAANDataSet3.admin)
        databaru = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If FrmAdmin.Label3.Text = "Administrator" Then
            FrmAdminManajemen.Show()
            Me.Hide()
        ElseIf FrmOperator.Label3.Text = "Operator" Then
            FrmManajemenOperator.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin menyimpan data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                sql = "INSERT INTO admin(Kdadmin,Username,Password,Nama,level)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
                jalankansql(sql)
                MsgBox("Data berhasil disimpan!", vbInformation)
                bersihkandata()
                tampilkandata()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan cari data yang ingin diubah terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin mengubah data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                sql = "UPDATE admin SET Username = '" + TextBox2.Text + "', Password = '" + TextBox3.Text + "', Nama = '" + TextBox4.Text + "', Level = '" + ComboBox1.Text + "' WHERE Kdadmin = '" + TextBox1.Text + "'"
                jalankansql(sql)
                MsgBox("Data berhasil diubah!", vbInformation)
                bersihkandata()
                tampilkandata()

            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("silahkan cari data yang ingin di hapus terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah anda yakin ingin menghapus data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                sql = "DELETE FROM admin WHERE Kdadmin LIKE '" + TextBox1.Text + "'"
                jalankansql(sql)
                MsgBox("Data berhasil dihapus!", vbInformation)
                bersihkandata()
                tampilkandata()

            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM admin WHERE Kdadmin = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox1.Text = rd.Item(0)
            TextBox2.Text = rd.Item(1)
            TextBox3.Text = rd.Item(2)
            TextBox4.Text = rd.Item(3)
            ComboBox1.Text = rd.Item(4)
        Else
            MsgBox("Data tidak ditemukan, silahkan masukan Kode Admin dengan benar!", vbInformation)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "*"
        End If
    End Sub
End Class