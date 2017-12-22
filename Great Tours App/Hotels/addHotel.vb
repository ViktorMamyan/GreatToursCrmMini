Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addHotel

    Friend RefForm As New HotelsList

    Dim HotelID As Int32 = 0

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

    Private Sub txtType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtType.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectHotelType

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtType.Left, txtType.Top + txtType.Height))

                    f.ShowDialog()
                    If f.HotelTypeID <> -1 Then
                        If txtType.Text <> f.HotelType Then
                            txtType.Tag = f.HotelTypeID
                            txtType.Text = f.HotelType
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addHotelType

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtType.Left, txtType.Top + txtType.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtHotel.Text.Trim = String.Empty Then Throw New Exception("Հյուրանոցի անվանումը գրված չէ")
            If txtCountry.Text = String.Empty Then Throw New Exception("Երկիրը նշված չէ")
            If txtType.Text = String.Empty Then Throw New Exception("Տեսակը նշված չէ")
            If txtRegion.Text = String.Empty Then Throw New Exception("Տարածաշրջանը նշված չէ")

            If txtStar.Text = String.Empty OrElse txtStar.EditValue < 0 OrElse txtStar.EditValue > 255 Then txtStar.EditValue = 0

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@HotelName", txtHotel.Text.Trim))
                .Add(New SqlParameter("@CountryID", txtCountry.Tag))
                .Add(New SqlParameter("@Region", txtRegion.Text.Trim))
                .Add(New SqlParameter("@Stars", IIf(txtStar.EditValue = 0, DBNull.Value, txtStar.EditValue)))
                .Add(New SqlParameter("@HotelTypeID", txtType.Tag))
            End With

            ExecToSql("HotelsAdd", CommandType.StoredProcedure, Parameters.ToArray)

            HotelID = Query_Scalar("SELECT dbo.GetHotelID()")

            txtHotel.Text = String.Empty
            txtStar.Text = 0
            txtCountry.Text = String.Empty
            txtCountry.Tag = String.Empty
            txtRegion.Text = String.Empty
            txtType.Text = String.Empty
            txtType.Tag = String.Empty

            RefForm.LoadData()
            If HotelID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("HotelID", HotelID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            HotelID = 0
            txtHotel.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class