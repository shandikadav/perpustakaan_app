Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class FrmManageBuku
    Dim databaru As Boolean

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Sub tampilkandata()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT * FROM buku", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "buku")
        DataGridView1.DataSource = (ds.Tables("buku"))
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

    Private Sub FrmManageBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_APP_PERPUSTAKAANDataSet1.fbuku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.DB_APP_PERPUSTAKAANDataSet1.buku)
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
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MsgBox("Apakah Anda ingin yakin ingin menambahkan data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            Dim cmd As New SqlCommand("INSERT INTO buku(Kdbuku,Kdkatalog,Judul_buku,Tahun_cetak,Isbn,Pengarah,Synopsis,Deskripsi,Cover_buku) VALUES (@kdbuku,@Kdkatalog,@Judul,@tahun,@Isbn,@pengarah,@Synopsis,@Deskripsi,@cover)", konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.Add("@kdbuku", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@Kdkatalog", SqlDbType.Int).Value = TextBox2.Text
            cmd.Parameters.Add("@Judul", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@Tahun", SqlDbType.Date).Value = DateTimePicker1.Value
            cmd.Parameters.Add("@Isbn", SqlDbType.NChar).Value = TextBox4.Text
            cmd.Parameters.Add("@Pengarah", SqlDbType.VarChar).Value = TextBox5.Text
            cmd.Parameters.Add("@Synopsis", SqlDbType.VarChar).Value = TextBox6.Text
            cmd.Parameters.Add("@Deskripsi", SqlDbType.VarChar).Value = TextBox7.Text
            cmd.Parameters.Add("@cover", SqlDbType.Image).Value = ms.ToArray
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil disimpan!", vbInformation)
                tampilkandata()
                bersihkandata()
            Else
                MsgBox("Data gagal disimpan!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Silahkan cari data yang ingin di Ubah terlebih dahulu!", vbExclamation)
            Exit Sub
        Else
            pesan = MsgBox("Apakah anda ingin melanjutkan mengubah data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
                TextBox1.Focus()
            End If
            Dim ubah As String = "UPDATE buku SET Kdkatalog = '" + TextBox2.Text + "', Judul_buku = '" + TextBox3.Text + "', Tahun_cetak = '" + DateTimePicker1.Value + "', Isbn = '" + TextBox4.Text + "', Pengarah = '" + TextBox5.Text + "', Synopsis = '" + TextBox6.Text + "', Deskripsi = '" + TextBox7.Text + "', Cover_buku=@cover WHERE Kdbuku = '" + TextBox1.Text + "'"
            Dim cmd As New SqlCommand(ubah, konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img As Byte()
            img = ms.ToArray
            cmd.Parameters.Add("@cover", SqlDbType.Image).Value = img
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil diubah!", vbInformation)
                bersihkandata()
                tampilkandata()
            Else
                MsgBox("Data gagal diubah!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, hapus As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Silahkan cari data yang ingin di Hapus terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda yakin ingin menghapus data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                hapus = "DELETE FROM buku WHERE Kdbuku LIKE '" + TextBox1.Text + "'"
                jalankansql(hapus)
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
        sql = "SELECT * FROM anggota Where Kdanggota = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        Dim img As Byte() = DirectCast(rd.Item(8), Byte())
        Dim ms As MemoryStream = New MemoryStream(img)
        If rd.HasRows Then
            TextBox1.Text = rd.Item(0)
            TextBox2.Text = rd.Item(1)
            TextBox3.Text = rd.Item(2)
            DateTimePicker1.Value = Convert.ToDateTime(rd.Item(3))
            TextBox4.Text = rd.Item(4)
            TextBox5.Text = rd.Item(5)
            TextBox6.Text = rd.Item(6)
            TextBox7.Text = rd.Item(7)
            PictureBox1.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Pilih Gambar(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            TextBox6.Text = (opf.FileName)
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub
End Class