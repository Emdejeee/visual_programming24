Public Class pilihan
    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Me.Hide()
        Menu_Admin.Show()

    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Me.Hide()
        menufnb.Show()

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        form2.Show()
        Hide()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()

    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        customer.Show()

    End Sub
End Class