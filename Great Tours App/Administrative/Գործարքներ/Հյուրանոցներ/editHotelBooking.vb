Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editHotelBooking

    Friend RefForm As New HotelBooking

    Friend HotelBookID As Int32 = 0
    Friend CustomerID As Integer = 0
    Friend FoodTypeID As Integer?
    Friend OperatorID As Integer?
    Friend HotelName As String = String.Empty
    Friend StartDate As Date
    Friend EndDate As Date
    Friend Price As Decimal = 0
    Friend Cost As Decimal?
    Friend CustomerName As String = String.Empty
    Friend AdultCount As Byte = 0
    Friend ChildCount As Byte?
    Friend BabyCount As Byte?
    Friend ChildYearsComment As String = String.Empty
    Friend FoodName As String = String.Empty
    Friend Transfer As Boolean
    Friend PrePayPrice As Decimal?
    Friend NextPayDate As Date?
    Friend OperatorName As String = String.Empty
    Friend PaymaetDeathLine As Date?
    Friend IsTotalyPayed As Boolean


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
        If HotelBookID > 0 Then
            txtCustomer.Tag = CustomerID
            txtCustomer.Text = CustomerName

            If FoodTypeID.HasValue Then txtFood.Tag = FoodTypeID
            txtFood.Text = FoodName

            If OperatorID.HasValue Then txtOperator.Tag = OperatorID
            txtOperator.Text = OperatorName

            txtHotel.Text = HotelName

            sDate.DateTime = StartDate
            eDate.DateTime = EndDate

            txtPrice.Text = Price

            If Cost.HasValue Then txtCost.Text = Cost

            txtAdultCount.Text = AdultCount

            If ChildCount.HasValue Then txtChildCount.Text = ChildCount

            If BabyCount.HasValue Then txtBabyCount.Text = BabyCount

            txtComment.Text = ChildYearsComment

            cTransfer.Checked = Transfer

            If PrePayPrice.HasValue Then txtPrePay.Text = PrePayPrice

            If NextPayDate.HasValue Then nDate.DateTime = NextPayDate

            If PaymaetDeathLine.HasValue Then lDate.DateTime = PaymaetDeathLine

            cTotalPayed.Checked = IsTotalyPayed
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtHotel.Text.Trim = String.Empty Then Throw New Exception("Հյուրանոցի անվանումը գրված չէ")
            If sDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")
            If eDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")

            If txtPrice.EditValue = String.Empty OrElse txtPrice.Text = String.Empty OrElse txtPrice.Text < 0 Then Throw New Exception("Գումարը նշված չէ")
            If txtAdultCount.EditValue = String.Empty OrElse txtAdultCount.Text = String.Empty OrElse txtAdultCount.Text < 0 Then Throw New Exception("Մեծահասակների քանակը նշված չէ")

            If txtCustomer.Text = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@HotelBookID", HotelBookID))
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

            ExecToSql("HotelBookingUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If HotelBookID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("HotelBookID", HotelBookID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class