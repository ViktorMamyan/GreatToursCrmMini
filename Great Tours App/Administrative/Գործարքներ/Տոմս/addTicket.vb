Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTicket

    Friend RefForm As New Ticket

    Dim TicketID As Int32 = 0

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
                Case 2
                    txtOperator.Text = String.Empty
                    txtOperator.Tag = String.Empty
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

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

    Private Sub cWithReturn_CheckedChanged(sender As Object, e As EventArgs) Handles cWithReturn.CheckedChanged
        If cWithReturn.Checked = True Then
            rDate.Enabled = True
        Else
            rDate.Text = String.Empty
            rDate.Enabled = False
        End If
    End Sub

    Private Sub txtFromAirport_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFromAirport.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectFromAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFromAirport.Left, txtFromAirport.Top + txtFromAirport.Height))

                    f.ShowDialog()
                    If f.AirportID <> -1 Then
                        If txtFromAirport.Text <> f.Airport Then
                            txtFromAirport.Tag = f.AirportID
                            txtFromAirport.Text = f.Airport
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFromAirport.Left, txtFromAirport.Top + txtFromAirport.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtToAirport_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtToAirport.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectFromAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtToAirport.Left, txtToAirport.Top + txtToAirport.Height))

                    f.ShowDialog()
                    If f.AirportID <> -1 Then
                        If txtToAirport.Text <> f.Airport Then
                            txtToAirport.Tag = f.AirportID
                            txtToAirport.Text = f.Airport
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtToAirport.Left, txtToAirport.Top + txtToAirport.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtReservNumber.Text.Trim = String.Empty Then Throw New Exception("Ամրագրման համարը գրված չէ")
            If txtFromAirport.Text.Trim = String.Empty Then Throw New Exception("Աէրոպորտը նշված չէ")
            If txtToAirport.Text.Trim = String.Empty Then Throw New Exception("Աէրոպորտը նշված չէ")
            If fDate.Text = String.Empty Then Throw New Exception("Թռիչքի ժամը նշված չէ")
            If cWithReturn.Checked = True AndAlso rDate.Text = String.Empty Then Throw New Exception("Վերադարձի ժամը նշված չէ")
            If txtPrice.EditValue <= 0 Then Throw New Exception("Գումարը նշված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")
            If txtAdultCount.EditValue <= 0 Then Throw New Exception("Մեծերի քանակը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@ReservNumber", txtReservNumber.Text.Trim))
                .Add(New SqlParameter("@FromAirportID", txtFromAirport.Tag))
                .Add(New SqlParameter("@ToAirportID", txtToAirport.Tag))
                .Add(New SqlParameter("@FlyDayTime", fDate.DateTime))
                .Add(New SqlParameter("@WithReturn", cWithReturn.Checked))
                .Add(New SqlParameter("@ReturnFlyDayTime", IIf(cWithReturn.Checked, rDate.DateTime, DBNull.Value)))
                .Add(New SqlParameter("@Price", txtPrice.EditValue))
                .Add(New SqlParameter("@Cost", IIf(txtCost.EditValue = 0, DBNull.Value, txtCost.EditValue)))
                .Add(New SqlParameter("@CustomerID", txtCustomer.Tag))
                .Add(New SqlParameter("@AdultCount", txtAdultCount.EditValue))
                .Add(New SqlParameter("@ChildCount", IIf(txtChildCount.EditValue = 0, DBNull.Value, txtChildCount.EditValue)))
                .Add(New SqlParameter("@BabyCount", IIf(txtBabyCount.EditValue = 0, DBNull.Value, txtBabyCount.EditValue)))
                .Add(New SqlParameter("@ChildYearsComment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
                .Add(New SqlParameter("@OperatorID", IIf(txtOperator.Text.Trim = String.Empty, DBNull.Value, txtOperator.Tag)))
                .Add(New SqlParameter("@PaymaetDeathLine", IIf(lDate.Text = String.Empty, DBNull.Value, lDate.DateTime)))
                .Add(New SqlParameter("@PrePayPrice", IIf(txtPrePay.EditValue = 0, DBNull.Value, txtPrePay.EditValue)))
                .Add(New SqlParameter("@NextPayDate", IIf(nDate.Text = String.Empty, DBNull.Value, nDate.DateTime)))
                .Add(New SqlParameter("@IsTotalyPayed", cTotalPayed.Checked))
            End With

            ExecToSql("TicketAdd", CommandType.StoredProcedure, Parameters.ToArray)

            TicketID = Query_Scalar("SELECT dbo.GetMaxTicketID()")

            txtReservNumber.Text = String.Empty
            txtFromAirport.Text = String.Empty
            txtFromAirport.Tag = String.Empty
            txtToAirport.Text = String.Empty
            txtToAirport.Tag = String.Empty
            fDate.Text = String.Empty
            cWithReturn.Checked = False
            txtPrice.EditValue = 0
            txtCost.EditValue = 0
            txtCustomer.Text = String.Empty
            txtCustomer.Tag = String.Empty
            txtAdultCount.EditValue = 0
            txtChildCount.EditValue = 0
            txtBabyCount.EditValue = 0
            txtComment.Text = String.Empty
            txtOperator.Text = String.Empty
            txtOperator.Tag = String.Empty
            lDate.Text = String.Empty
            txtPrePay.EditValue = 0
            nDate.Text = String.Empty
            cTotalPayed.Checked = False

            RefForm.LoadData()
            If TicketID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TicketID", TicketID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            TicketID = 0
            txtReservNumber.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class