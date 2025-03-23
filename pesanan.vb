Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class customer

    Private Sub menufnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDBmn()
        DataGridView1.DataSource = gettblpsn()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        tbmeja.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
        CheckedListBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
        TextBox1.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
    End Sub
    Private Sub pesananfb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil data menu langsung dari database
        Dim daftarMenu As DataTable = gettblmenu() ' Panggil fungsi gettblmenu dari modul mdlmenu

        ' Isi CheckedListBox1 dengan nama-nama menu, menghindari duplikat
        Dim uniqueMenuNames As New HashSet(Of String)
        For Each row As DataRow In daftarMenu.Rows
            Dim namaMenu As String = row("Nama").ToString() ' Ganti "Nama" dengan nama kolom sesuai di database
            If uniqueMenuNames.Add(namaMenu) Then
                CheckedListBox1.Items.Add(namaMenu)
            End If
        Next
    End Sub

    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        Dim totalHarga As Decimal = 0

        ' Ambil data menu dari database (gunakan gettblmenu, bukan gettblpsn)
        Dim daftarMenu As DataTable = gettblmenu()

        ' Iterasi melalui semua item yang dicentang di CheckedListBox
        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            Dim namaMenu As String = CheckedListBox1.CheckedItems(i).ToString()

            ' Cari harga menu berdasarkan nama menu
            For Each row As DataRow In daftarMenu.Rows
                If row("Nama").ToString() = namaMenu Then
                    totalHarga += CDec(row("Harga")) ' Pastikan nama kolom "Harga" benar
                    Exit For ' Keluar dari perulangan dalam jika harga ditemukan
                End If
            Next
        Next

        TextBox1.Text = totalHarga.ToString("N0")
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If tbmeja.Text.Trim = "" Then  ' Memeriksa apakah tbmeja kosong
            MsgBox("Silakan isi ID meja.", MsgBoxStyle.Critical, "Data Tidak Lengkap")
            Exit Sub ' Menghentikan proses jika tbmeja kosong
        End If

        Try
            ' Ambil semua item yang dicentang dari CheckedListBox1
            Dim menuTerpilih As String = String.Join(", ", CheckedListBox1.CheckedItems.Cast(Of String))

            ' Simpan pesanan ke database dengan daftar menu yang dipilih
            tambah_pesanan(tbmeja.Text, menuTerpilih, TextBox1.Text)

            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Isi data dengan benar", MsgBoxStyle.Critical, "Error") ' Menampilkan pesan error lebih detail
        End Try

        ' Refresh DataGridView1 untuk menampilkan data terbaru
        DataGridView1.DataSource = gettblpsn()

        ' Mengosongkan field setelah data disimpan
        tbmeja.Clear()
        CheckedListBox1.ClearSelected() ' Hapus centang
        TextBox1.Clear()
    End Sub


    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        pilihan.Show()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim xlaapp As New Microsoft.Office.Interop.Excel.Application
            Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misvalue As Object = System.Reflection.Missing.Value

            Try
                ' Create a new workbook and worksheet
                xlworkbook = xlaapp.Workbooks.Add(misvalue)
                xlworksheet = CType(xlworkbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

                ' Write column headers
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                Next

                ' Write row data
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    For j As Integer = 0 To DataGridView1.ColumnCount - 1
                        xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next

                ' Save the workbook
                xlworkbook.SaveAs(SaveFileDialog1.FileName)
                xlworkbook.Close()
                xlaapp.Quit()

                releaseObject(xlaapp)
                releaseObject(xlworkbook)
                releaseObject(xlworksheet)

                MessageBox.Show("Proses Export Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengekspor data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    ' ... (kode lainnya)
End Class



