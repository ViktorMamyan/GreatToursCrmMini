Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addAirport

    Private Sub txtCountry_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCountry.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectCountry

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCountry.Left, txtCountry.Top + txtCountry.Height))

                    f.ShowDialog()
                    If f.CountryID <> -1 Then
                        If txtCountry.Text <> f.Country Then
                            txtCountry.Tag = f.CountryID
                            txtCountry.Text = f.Country
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addCountry

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCountry.Left, txtCountry.Top + txtCountry.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtAirport.Text.Trim = String.Empty Then Throw New Exception("Անվանումը գրված չէ")
            If txtCountry.Text = String.Empty Then Throw New Exception("Երկիրը նշված չէ")
            If txtCode.Text = String.Empty Then Throw New Exception("Կոդը նշված չէ")
            If txtCity.Text = String.Empty Then Throw New Exception("Քաղաքը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@AirportName", txtAirport.Text.Trim))
                .Add(New SqlParameter("@CountryID", txtCountry.Tag))
                .Add(New SqlParameter("@City", txtCity.Text.Trim))
                .Add(New SqlParameter("@Code", txtCode.Text.Trim))
            End With

            ExecToSql("AirportAdd", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class