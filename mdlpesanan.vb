Imports MySql.Data.MySqlClient
Module mdlpesanan
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public str As String = "server=localhost;user id=root;password=;database=tugas_besar;"
    Public db As New MySqlConnection(str)
    Public Sub bukaDBpsn()
        Try
            tutupDBpsn()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDBpsn()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    Public Sub tambah_pesanan(ByVal ID_Meja As String, ByVal Pesanan As String, ByVal Total As Integer)


        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO pesanan (ID_Meja, Pesanan, Total) VALUES (@ID_Meja, @Pesanan, @Total)"
        myCommand.Parameters.AddWithValue("@ID_Meja", ID_Meja)
        myCommand.Parameters.AddWithValue("@Pesanan", Pesanan)
        myCommand.Parameters.AddWithValue("@Total", Total)


        Try
            bukaDBpsn()
            myCommand.ExecuteNonQuery()
            tutupDBpsn()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDBpsn()

        End Try
    End Sub

    Public Function gettblpsn() As DataTable
        Dim myDataTable As DataTable
        Try
            bukaDBpsn()
            myCommand = New MySqlCommand("SELECT * FROM pesanan ORDER BY ID_Meja", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "ID_Meja")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBpsn()
        End Try
    End Function

    Public Function getViewpesanan(ByVal ID_Meja As String) As DataTable
        Dim myViewTable As DataTable
        Try
            bukaDBpsn()
            myCommand = New MySqlCommand("SELECT * FROM pesanan WHERE ID_Meja = @ID_Meja", db)
            myCommand.Parameters.AddWithValue("@ID_Menu", ID_Meja)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "pesanan")
            myViewTable = myDataset.Tables(0)
            Return myViewTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDBpsn()
        End Try
    End Function
End Module