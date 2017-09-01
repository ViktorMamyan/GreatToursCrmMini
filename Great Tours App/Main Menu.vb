Public Class MainMenu
    Private Sub btnDirection_Click(sender As Object, e As EventArgs) Handles btnDirection.Click
        Dim f As New Direction
        f.Show()
        Me.Hide()
    End Sub

End Class