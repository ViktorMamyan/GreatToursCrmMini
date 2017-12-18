Public Class Administrative

    Private Sub Administrative_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnPlacePayment_Click(sender As Object, e As EventArgs) Handles btnPlacePayment.Click
        Dim f As New PlacePay
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        Dim f As New Taxes
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        Dim f As New Salary
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnTel_Click(sender As Object, e As EventArgs) Handles btnTel.Click
        Dim f As New TelephonePay
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        Dim f As New Utility
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnOffice_Click(sender As Object, e As EventArgs) Handles btnOffice.Click
        Dim f As New OfficeExp
        f.Show()
        Me.Hide()
    End Sub

End Class