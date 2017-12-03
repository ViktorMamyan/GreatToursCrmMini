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

    Private Sub btnTour_Click(sender As Object, e As EventArgs) Handles btnTour.Click
        Dim f As New Tour
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnBonusCard_Click(sender As Object, e As EventArgs) Handles btnBonusCard.Click
        Dim f As New Card
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnAirOperator_Click(sender As Object, e As EventArgs) Handles btnAirOperator.Click
        Dim f As New AirOperator
        f.Show()
        Me.Hide()
    End Sub

End Class