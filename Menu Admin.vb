Imports excel = Microsoft.Office.Interop.Excel
Public Class Menu_Admin
    Private Sub Menu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDBkrywn()
        DataGridView1.DataSource = gettblkaryawan()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        tbid.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
        tbnama.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
        cbjk.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
        cbdept.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString()
        tbnohp.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString()
        tbalamat.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString()

    End Sub

    Private Sub cbjk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjk.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If tbid.Text.Trim = "" OrElse tbnama.Text.Trim = "" OrElse cbjk.Text.Trim = "" OrElse cbdept.Text.Trim = "" OrElse tbnohp.Text.Trim = "" OrElse tbalamat.Text.Trim = "" Then
            MsgBox("Silakan isi semua data karyawan.", MsgBoxStyle.Critical, "Data Tidak Lengkap")
            Exit Sub
        End If

        Try
            ' Additional input validation: Check if tbnohp is numeric
            If Not IsNumeric(tbnohp.Text) Then
                MsgBox("Nomor HP harus berupa angka.", MsgBoxStyle.Critical, "Data Tidak Valid")
                Exit Sub
            End If

            tambah_karyawan(tbid.Text, tbnama.Text, cbjk.Text, cbdept.Text, tbnohp.Text, tbalamat.Text)
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Sukses")

            ' Clear input fields after saving
            bersih_karyawan()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Isi data dengan benar", MsgBoxStyle.Critical, "Error")
        End Try

        DataGridView1.DataSource = gettblkaryawan()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If tbid.Text.Trim = "" OrElse tbnama.Text.Trim = "" OrElse cbjk.Text.Trim = "" OrElse cbdept.Text.Trim = "" OrElse tbnohp.Text.Trim = "" OrElse tbalamat.Text.Trim = "" Then
            MsgBox("Silakan pilih data karyawan yang akan diubah.", MsgBoxStyle.Critical, "Data Tidak Lengkap")
            Exit Sub
        End If

        Try
            ' Additional input validation: Check if tbnohp is numeric
            If Not IsNumeric(tbnohp.Text) Then
                MsgBox("Nomor HP harus berupa angka.", MsgBoxStyle.Critical, "Data Tidak Valid")
                Exit Sub
            End If

            ubah_karyawan(tbid.Text, tbnama.Text, cbjk.Text, cbdept.Text, tbnohp.Text, tbalamat.Text)
            MsgBox("Data berhasil diubah", MsgBoxStyle.Information, "Sukses")

            ' Clear input fields after editing
            bersih_karyawan()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Isi data dengan benar", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            Dim dataTable As DataTable = getViewkaryawan(tbcari.Text)

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
        hapus_karyawan(tbid.Text)
        DataGridView1.DataSource = gettblkaryawan()
    End Sub

    Private Sub btnbersih_Click(sender As Object, e As EventArgs) Handles btnbersih.Click
        bersih_karyawan()
        DataGridView1.DataSource = gettblkaryawan()
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
End Class