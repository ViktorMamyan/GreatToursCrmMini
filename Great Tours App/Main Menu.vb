Public Class MainMenu

    Private Sub btnDirection_Click(sender As Object, e As EventArgs) Handles btnDirection.Click
        Dim f As New Direction
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnTourOperator_Click(sender As Object, e As EventArgs) Handles btnTourOperator.Click
        Dim f As New TourOperator
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnDirOpCombination_Click(sender As Object, e As EventArgs) Handles btnDirOpCombination.Click
        Dim f As New DirectionOperatorCombination
        f.Show()
        Me.Hide()
    End Sub

    Private Sub ckLocalDB_CheckedChanged(sender As Object, e As EventArgs) Handles ckLocalDB.CheckedChanged
        If ckLocalDB.Checked = True Then
            SQLString = "Server=127.0.0.1;Initial Catalog=GT,9999;Integrated Security=True;"
        Else
            SQLString = "Data Source=192.168.1.102\GT,9999;Initial Catalog=GT;User ID=gtUser;Password=abcgtuserpass"
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim f As New Customer
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerDetails_Click(sender As Object, e As EventArgs) Handles btnCustomerDetails.Click
        Dim f As New CustomerDetails
        f.Show()
        Me.Hide()
    End Sub

End Class