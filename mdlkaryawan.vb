Imports MySql.Data.MySqlClient
Module mdlkaryawan
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public str As String = "server=localhost;user id=root;password=;database=tugas_besar;"
    Public db As New MySqlConnection(str)
    Public Sub bukaDBkrywn()
        Try
            tutupDBkrywn()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDBkrywn()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    Public Function gettblkaryawan() As DataTable
        Dim myDataTable As DataTable
        Try
            bukaDBkrywn()
            myCommand = New MySqlCommand("SELECT * FROM karyawan ORDER BY ID_Karyawan", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "ID_Karyawan")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBkrywn()
        End Try
    End Function

    Public Sub hapus_karyawan(ByVal ID_Karyawan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM karyawan WHERE ID_Karyawan = @ID_Karyawan"
        myCommand.Parameters.AddWithValue("@ID_Karyawan", ID_Karyawan)
        Try
            bukaDBkrywn()
            myCommand.ExecuteNonQuery()
            tutupDbkrywn()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")
        Finally
            tutupDBkrywn()
        End Try
    End Sub



    Public Sub tambah_karyawan(ByVal ID_Karyawan As String, ByVal Nama As String, ByVal Gender As String, ByVal Department As String, ByVal Nohp As String, ByVal Alamat As String)


        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO karyawan (ID_Karyawan, Nama, Gender, Department, Nohp, Alamat) VALUES (@ID_Karyawan, @Nama, @Gender, @Department, @Nohp, @Alamat)"
        myCommand.Parameters.AddWithValue("@ID_Karyawan", ID_Karyawan)
        myCommand.Parameters.AddWithValue("@Nama", Nama)
        myCommand.Parameters.AddWithValue("@Gender", Gender)
        myCommand.Parameters.AddWithValue("@Department", Department)
        myCommand.Parameters.AddWithValue("@Alamat", Alamat)
        myCommand.Parameters.AddWithValue("@Nohp", Nohp)


        Try
            bukaDBkrywn()
            myCommand.ExecuteNonQuery()
            tutupDBkrywn()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDBkrywn()

        End Try
    End Sub

    Public Sub ubah_karyawan(ByVal ID_Karyawan As String, ByVal Nama As String, ByVal Gender As String, ByVal Department As String, ByVal Nohp As String, ByVal Alamat As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE karyawan SET Nama = @Nama, Gender = @Gender, Department = @Department, Nohp  = @Nohp, Alamat = @Alamat WHERE ID_Karyawan = @ID_Karyawan"
        myCommand.Parameters.AddWithValue("@ID_Karyawan", ID_Karyawan)
        myCommand.Parameters.AddWithValue("@Nama", Nama)
        myCommand.Parameters.AddWithValue("@Gender", Gender)
        myCommand.Parameters.AddWithValue("@Department", Department)
        myCommand.Parameters.AddWithValue("@Nohp", Nohp)
        myCommand.Parameters.AddWithValue("@Alamat", Alamat)

        Try
            bukaDBkrywn()
            myCommand.ExecuteNonQuery()
            tutupDBkrywn()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDBkrywn()
        End Try
    End Sub
    Public Sub bersih_karyawan()
        With Menu_Admin
            .tbid.Text = ""
            .tbnama.Text = ""
            .cbjk.Text = ""
            .cbdept.Text = ""
            .tbnohp.Text = ""
            .tbalamat.Text = ""
        End With
    End Sub

    Public Function getViewkaryawan(ByVal ID_Karyawan As String) As DataTable
        Dim myViewTable As DataTable
        Try
            bukaDBkrywn()
            myCommand = New MySqlCommand("SELECT * FROM karyawan WHERE ID_Karyawan = @ID_Karyawan", db)
            myCommand.Parameters.AddWithValue("@ID_Karyawan", ID_Karyawan)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "karyawan")
            myViewTable = myDataset.Tables(0)
            Return myViewTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBkrywn()
        End Try
    End Function

End Module
