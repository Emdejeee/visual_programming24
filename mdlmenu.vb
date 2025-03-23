Imports MySql.Data.MySqlClient
Module mdlmenu
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public str As String = "server=localhost;user id=root;password=;database=tugas_besar;"
    Public db As New MySqlConnection(str)
    Public Sub bukaDBmn()
        Try
            tutupDBmn()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDBmn()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    Public Function gettblmenu() As DataTable
        Dim myDataTable As DataTable
        Try
            bukaDBmn()
            myCommand = New MySqlCommand("SELECT * FROM menu ORDER BY ID_Menu", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "ID_Menu")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBmn()
        End Try
    End Function

    Public Sub tambah_menu(ByVal ID_Menu As String, ByVal Nama As String, ByVal Jenis As String, ByVal Harga As Integer)


        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO menu (ID_Menu, Nama, Jenis, Harga) VALUES (@ID_Menu, @Nama, @Jenis, @Harga)"
        myCommand.Parameters.AddWithValue("@ID_Menu", ID_Menu)
        myCommand.Parameters.AddWithValue("@Nama", Nama)
        myCommand.Parameters.AddWithValue("@Jenis", Jenis)
        myCommand.Parameters.AddWithValue("@Harga", Harga)


        Try
            bukaDBmn()
            myCommand.ExecuteNonQuery()
            tutupDBmn()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDBmn()

        End Try
    End Sub

    Public Sub ubah_menu(ByVal ID_Menu As String, ByVal Nama As String, ByVal Jenis As String, ByVal Harga As Integer)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE menu SET Nama = @Nama, Jenis = @Jenis, Harga  = @Harga WHERE ID_Menu = @ID_Menu"
        myCommand.Parameters.AddWithValue("@ID_Menu", ID_Menu)
        myCommand.Parameters.AddWithValue("@Nama", Nama)
        myCommand.Parameters.AddWithValue("@Jenis", Jenis)
        myCommand.Parameters.AddWithValue("@Harga", Harga)


        Try
            bukaDBmn()
            myCommand.ExecuteNonQuery()
            tutupDBmn()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDBmn()
        End Try
    End Sub

    Public Function getViewmenu(ByVal ID_Menu As String) As DataTable
        Dim myViewTable As DataTable
        Try
            bukaDBmn()
            myCommand = New MySqlCommand("SELECT * FROM menu WHERE ID_Menu = @ID_Menu", db)
            myCommand.Parameters.AddWithValue("@ID_Menu", ID_Menu)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "menu")
            myViewTable = myDataset.Tables(0)
            Return myViewTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBmn()
        End Try
    End Function

    Public Sub hapus_menu(ByVal ID_Menu As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM menu WHERE ID_Menu = @ID_Menu"
        myCommand.Parameters.AddWithValue("@ID_Menu", ID_Menu)
        Try
            bukaDBmn()
            myCommand.ExecuteNonQuery()
            tutupDBmn()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")
        Finally
            tutupDBmn()
        End Try
    End Sub

    Public Sub bersih_menu()
        With menufnb
            .tbidmenu.Text = ""
            .tbnmmenu.Text = ""
            .cbjenis.Text = ""
            .tbharga.Text = ""
        End With
    End Sub


End Module
