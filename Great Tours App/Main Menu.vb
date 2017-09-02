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

End Class