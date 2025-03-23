Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class form2
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnlogin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin2.Click
        ' Create the connection string
        Dim conn As New MySqlConnection("Server=localhost;Database=tugas_besar;Uid=root;Pwd='';")

        Try
            ' Open the connection
            conn.Open()

            ' Create the SQL command
            Dim cmd As New MySqlCommand("SELECT * FROM user WHERE username=@username AND password=@password", conn)
            cmd.Parameters.AddWithValue("@username", tbuser.Text.Trim())
            cmd.Parameters.AddWithValue("@password", tbpass.Text.Trim())

            ' Execute the command and read the results
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' If user is found, show the main form and hide the login form
                MsgBox("Login Succesfully")
                pilihan.Show()
                Me.Hide()
            Else
                ' If user is not found, show an error message
                MsgBox("username atau password salah!", MsgBoxStyle.Information, "Peringatan")
            End If

            ' Close the reader
            reader.Close()

        Catch ex As MySqlException
            ' Show any MySQL errors
            MsgBox("Database connection error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
