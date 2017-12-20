Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addHotelBooking

    Friend RefForm As New HotelBooking

    Dim HotelBookID As Int32 = 0

    Private Sub txtCustomer_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCustomer.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectCustomer

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCustomer.Left, txtCustomer.Top + txtCustomer.Height))

                    f.ShowDialog()
                    If f.CustomerID <> -1 Then
                        If txtCustomer.Text <> f.CustomerName Then
                            txtCustomer.Tag = f.CustomerID
                            txtCustomer.Text = f.CustomerName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addCustomer

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCustomer.Left, txtCustomer.Top + txtCustomer.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtOperator_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtOperator.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectOperator

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtOperator.Left, txtOperator.Top + txtOperator.Height))

                    f.ShowDialog()
                    If f.TourOperatorID <> -1 Then
                        If txtOperator.Text <> f.OperatorName Then
                            txtOperator.Tag = f.TourOperatorID
                            txtOperator.Text = f.OperatorName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addTourOperator

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtOperator.Left, txtOperator.Top + txtOperator.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtFood_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFood.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectFood

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFood.Left, txtFood.Top + txtFood.Height))

                    f.ShowDialog()
                    If f.FoodTypeID <> -1 Then
                        If txtFood.Text <> f.FoodName Then
                            txtFood.Tag = f.FoodTypeID
                            txtFood.Text = f.FoodName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addFoodType

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFood.Left, txtFood.Top + txtFood.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addHotelBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sDate.DateTime = Now
        eDate.DateTime = Now
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtHotel.Text.Trim = String.Empty Then Throw New Exception("Հյուրանոցի անվանումը գրված չէ")
            If sDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")
            If eDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")

            If txtPrice.EditValue = String.Empty OrElse txtPrice.Text = String.Empty OrElse txtPrice.Text < 0 Then Throw New Exception("Գումարը նշված չէ")
            If txtAdultCount.EditValue = String.Empty OrElse txtAdultCount.Text = String.Empty OrElse txtAdultCount.Text < 0 Then Throw New Exception("Մեծահասակների քանակը նշված չէ")

            If txtCustomer.Text = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@HotelName", txtHotel.Text.Trim))
                .Add(New SqlParameter("@StartDate", sDate.DateTime))
                .Add(New SqlParameter("@EndDate", eDate.DateTime))
                .Add(New SqlParameter("@Price", txtPrice.EditValue))
                .Add(New SqlParameter("@Cost", IIf(txtCost.EditValue > 0, txtCost.EditValue, DBNull.Value)))
                .Add(New SqlParameter("@CustomerID", txtCustomer.Tag))
                .Add(New SqlParameter("@AdultCount", txtAdultCount.EditValue))
                .Add(New SqlParameter("@ChildCount", IIf(txtChildCount.EditValue > 0, txtChildCount.EditValue, DBNull.Value)))
                .Add(New SqlParameter("@BabyCount", IIf(txtBabyCount.EditValue > 0, txtBabyCount.EditValue, DBNull.Value)))
                .Add(New SqlParameter("@ChildYearsComment", IIf(txtComment.Text.Trim <> String.Empty, txtComment.Text.Trim, DBNull.Value)))
                .Add(New SqlParameter("@FoodTypeID", IIf(txtFood.Text <> String.Empty, txtFood.Tag, DBNull.Value)))
                .Add(New SqlParameter("@Transfer", cTransfer.Checked))
                .Add(New SqlParameter("@OperatorID", IIf(txtOperator.Text <> String.Empty, txtOperator.Tag, DBNull.Value)))
                .Add(New SqlParameter("@PaymaetDeathLine", IIf(lDate.Text <> String.Empty, lDate.DateTime, DBNull.Value)))
                .Add(New SqlParameter("@PrePayPrice", IIf(txtPrePay.EditValue > 0, txtPrePay.EditValue, DBNull.Value)))
                .Add(New SqlParameter("@NextPayDate", IIf(nDate.Text <> String.Empty, nDate.DateTime, DBNull.Value)))
                .Add(New SqlParameter("@IsTotalyPayed", cTotalPayed.Checked))
            End With

            ExecToSql("HotelBookingAdd", CommandType.StoredProcedure, Parameters.ToArray)

            HotelBookID = Query_Scalar("SELECT dbo.GetHotelBookID()")

            txtHotel.Text = String.Empty
            sDate.DateTime = Now
            eDate.DateTime = Now
            txtPrice.Text = 0
            txtCost.Text = 0
            txtCustomer.Text = String.Empty
            txtCustomer.Tag = String.Empty
            txtAdultCount.Text = 0
            txtChildCount.Text = 0
            txtBabyCount.Text = 0
            txtComment.Text = String.Empty
            txtFood.Text = String.Empty
            txtFood.Tag = String.Empty
            cTransfer.Checked = False
            txtPrePay.Text = 0
            nDate.Text = String.Empty
            txtOperator.Text = String.Empty
            txtOperator.Tag = String.Empty
            cTotalPayed.Checked = False

            RefForm.LoadData()
            If HotelBookID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("HotelBookID", HotelBookID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            HotelBookID = 0
            txtHotel.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class