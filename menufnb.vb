Public Class menufnb
    Private Sub menufnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDBmn()
        DataGridView1.DataSource = gettblmenu()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        tbidmenu.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
        tbnmmenu.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
        cbjenis.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
        tbharga.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If tbidmenu.Text.Trim = "" OrElse tbnmmenu.Text.Trim = "" OrElse cbjenis.Text.Trim = "" OrElse tbharga.Text.Trim = "" Then
            MsgBox("Silakan isi semua data menu.", MsgBoxStyle.Critical, "Data Tidak Lengkap")
            Exit Sub
        End If

        Try
            If Not IsNumeric(tbharga.Text) Then
                MsgBox("Harga harus berupa angka.", MsgBoxStyle.Critical, "Data Tidak Valid")
                Exit Sub
            End If

            ' Parse the harga to Decimal
            Dim harga As Decimal = Decimal.Parse(tbharga.Text)

            tambah_menu(tbidmenu.Text, tbnmmenu.Text, cbjenis.Text, harga) ' Use Decimal directly
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Sukses")

            ' Clear the input fields after saving
            bersih_menu()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Isi data dengan benar", MsgBoxStyle.Critical, "Error")
        End Try

        DataGridView1.DataSource = gettblmenu()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        pilihan.Show()

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If tbidmenu.Text.Trim = "" OrElse tbnmmenu.Text.Trim = "" OrElse cbjenis.Text.Trim = "" OrElse tbharga.Text.Trim = "" Then
            MsgBox("Silakan pilih data menu yang akan diubah.", MsgBoxStyle.Critical, "Data Tidak Lengkap")
            Exit Sub
        End If

        Try
            If Not IsNumeric(tbharga.Text) Then
                MsgBox("Harga harus berupa angka.", MsgBoxStyle.Critical, "Data Tidak Valid")
                Exit Sub
            End If

            ' Parse the harga to Decimal
            Dim harga As Decimal = Decimal.Parse(tbharga.Text)

            ubah_menu(tbidmenu.Text, tbnmmenu.Text, cbjenis.Text, harga) ' Use Decimal directly
            MsgBox("Data berhasil diubah", MsgBoxStyle.Information, "Sukses")

            ' Clear the input fields after editing
            bersih_menu()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Isi data dengan benar", MsgBoxStyle.Critical, "Error")
        End Try

        DataGridView1.DataSource = gettblmenu()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            Dim dataTable As DataTable = getViewmenu(tbcari.Text)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                MessageBox.Show("Data tidak ditemukan untuk input yang diberikan.", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = Nothing
            Else
                DataGridView1.DataSource = dataTable
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        hapus_menu(tbidmenu.Text)
        DataGridView1.DataSource = gettblmenu()
    End Sub

    Private Sub btnbersih_Click(sender As Object, e As EventArgs) Handles btnbersih.Click
        bersih_menu()
        DataGridView1.DataSource = gettblmenu()
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
End Class