Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTour

    Friend RefForm As New Tour

    Dim TourID As Int32 = 0

    Dim HotelList As New List(Of LHotel)
    Dim TicketList As New List(Of LTicket)
    Dim InsList As New List(Of LIns)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtTour.Text = String.Empty Then Throw New Exception("Տուրի անունը գրված չէ")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկզբի ամսաթիվը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտի ամսաթիվը նշված չէ")
            If txtDirection.Text.Trim = String.Empty Then Throw New Exception("Ուղղությունը գրված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորը նշված չէ")
            If txtPrice.Text <= 0 Then Throw New Exception("Գումարը նշված չէ")
            If txtAdultCount.Text <= 0 Then Throw New Exception("Մեծերի քանակը նշված չէ")

            If ckUseBonusCard.Checked = True Then
                If txtCard.Text.Trim = String.Empty Then Throw New Exception("Բոնուսային քարտը նշված չէ")
                If txtPoint.Text.Trim = String.Empty OrElse txtPoint.Text <= 0 Then Throw New Exception("Անորոշ միավոր")
            End If

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TourName", txtTour.Text.Trim))
                .Add(New SqlParameter("@TourStartDate", sDate.DateTime))
                .Add(New SqlParameter("@TourEndDate", eDate.DateTime))
                .Add(New SqlParameter("@DirectionID", txtDirection.Tag.ToString))
                .Add(New SqlParameter("@OperatorID", txtOperator.Tag.ToString))
                .Add(New SqlParameter("@CustomerID", txtCustomer.Tag.ToString))
                .Add(New SqlParameter("@Price", txtPrice.Text.Trim))
                .Add(New SqlParameter("@Cost", txtCost.Text.Trim))

                .Add(New SqlParameter("@UseBonusCard", IIf(ckUseBonusCard.Checked = True, True, False)))
                .Add(New SqlParameter("@AddBouns", IIf(rPlus.Checked = True, True, False)))
                .Add(New SqlParameter("@Card", IIf(ckUseBonusCard.Checked = True, txtCard.Text.Trim, DBNull.Value)))
                .Add(New SqlParameter("@Points", IIf(ckUseBonusCard.Checked = True, txtPoint.Text, DBNull.Value)))
                .Add(New SqlParameter("@ByAnotherCustomer", IIf(ckUseBonusCard.Checked = True AndAlso rMinus.Checked = True, ckMinusByOtherCustomer.Checked, DBNull.Value)))

                .Add(New SqlParameter("@AdultCount", txtAdultCount.Text.Trim))
                .Add(New SqlParameter("@ChildCount", IIf(txtChildCount.Text = 0, DBNull.Value, txtChildCount.Text.Trim)))
                .Add(New SqlParameter("@BabyCount", IIf(txtBabyCount.Text = 0, DBNull.Value, txtBabyCount.Text.Trim)))
                .Add(New SqlParameter("@ChildYearsComment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
                .Add(New SqlParameter("@PaymaetDeathLine", IIf(lDate.Text = String.Empty, DBNull.Value, lDate.DateTime)))
                .Add(New SqlParameter("@PrePayPrice", IIf(txtPrePay.Text = 0, DBNull.Value, txtPrePay.Text.Trim)))
                .Add(New SqlParameter("@NextPayDate", IIf(nDate.Text = String.Empty, DBNull.Value, nDate.DateTime)))
                .Add(New SqlParameter("@IsTotalyPayed", cTotalPayed.Checked))
                .Add(New SqlParameter("@HotelList", IIf(btnHotel.Text = String.Empty, DBNull.Value, ToJson(HotelList))))
                .Add(New SqlParameter("@TicketList", IIf(btnTicket.Text = String.Empty, DBNull.Value, ToJson(TicketList))))
                .Add(New SqlParameter("@InsuranceList", IIf(btnInsurance.Text = String.Empty, DBNull.Value, ToJson(InsList))))
                .Add(New SqlParameter("@Excursion", IIf(txtExcursion.Text = String.Empty, DBNull.Value, txtExcursion.Text.Trim)))
                .Add(New SqlParameter("@VIsa", IIf(txtVisa.Text = String.Empty, DBNull.Value, txtVisa.Text.Trim)))
                .Add(New SqlParameter("@Transfer", IIf(txtTransfer.Text = String.Empty, DBNull.Value, txtTransfer.Text.Trim)))
                .Add(New SqlParameter("@TourType", IIf(txtTourType.Text = String.Empty, DBNull.Value, txtTourType.Text.Trim)))
            End With

            ExecToSql("TourAdd", CommandType.StoredProcedure, Parameters.ToArray)

            TourID = Query_Scalar("SELECT dbo.GetLasTourID()")

            txtTour.Text = String.Empty
            sDate.DateTime = Now
            eDate.DateTime = Now
            txtDirection.Text = String.Empty
            txtDirection.Tag = String.Empty
            txtOperator.Text = String.Empty
            txtOperator.Tag = String.Empty
            txtCustomer.Text = String.Empty
            txtCustomer.Tag = String.Empty
            txtPrice.Text = 0
            txtCost.Text = 0

            txtAdultCount.Text = 0
            txtChildCount.Text = 0
            txtBabyCount.Text = 0
            txtComment.Text = String.Empty
            btnHotel.Text = String.Empty
            btnTicket.Text = String.Empty
            btnInsurance.Text = String.Empty
            txtExcursion.Text = String.Empty
            txtVisa.Text = String.Empty
            txtTransfer.Text = String.Empty
            txtTourType.Text = String.Empty
            txtPrePay.Text = String.Empty
            nDate.Text = String.Empty
            lDate.Text = String.Empty
            cTotalPayed.Checked = False

            txtCard.Text = String.Empty
            txtPoint.Text = 0
            ckMinusByOtherCustomer.Checked = False
            rPlus.Checked = True
            ckUseBonusCard.Checked = False

            HotelList.Clear()
            TicketList.Clear()
            InsList.Clear()

            RefForm.LoadData()
            If TourID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TourID", TourID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            TourID = 0
            txtTour.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnHotel_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnHotel.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New addHList
                    With f

                        If HotelList.Count > 0 Then
                            .HotelList = HotelList
                        End If

                        .StartPosition = FormStartPosition.Manual
                        .Location = Me.PointToScreen(New Point(btnHotel.Left, btnHotel.Top + btnHotel.Height))
                        .ShowDialog()
                        If .HotelList.Count = 0 Then
                            btnHotel.Text = String.Empty
                            HotelList.Clear()
                        Else
                            HotelList = .HotelList
                            btnHotel.Text = .HotelList.Item(0).Hotel
                        End If

                        .Dispose()
                    End With
                Case 1
                    btnHotel.Text = String.Empty
                    HotelList.Clear()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnTicket_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnTicket.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New addTList
                    With f

                        If TicketList.Count > 0 Then
                            .TicketList = TicketList
                        End If

                        .StartPosition = FormStartPosition.Manual
                        .Location = Me.PointToScreen(New Point(btnTicket.Left, btnTicket.Top + btnTicket.Height))
                        .ShowDialog()

                        If .TicketList.Count = 0 Then
                            btnTicket.Text = String.Empty
                            TicketList.Clear()
                        Else
                            TicketList = .TicketList
                            btnTicket.Text = .TicketList.Item(0).Ticket
                        End If

                        .Dispose()
                    End With
                Case 1
                    btnTicket.Text = String.Empty
                    TicketList.Clear()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnInsurance_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnInsurance.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New addIList
                    With f

                        If InsList.Count > 0 Then
                            .InsList = InsList
                        End If

                        .StartPosition = FormStartPosition.Manual
                        .Location = Me.PointToScreen(New Point(btnInsurance.Left, btnInsurance.Top + btnInsurance.Height))
                        .ShowDialog()
                        If .InsList.Count = 0 Then
                            btnInsurance.Text = String.Empty
                            InsList.Clear()
                        Else
                            InsList = .InsList
                            btnInsurance.Text = .InsList.Item(0).StartDate.ToShortDateString
                        End If

                        .Dispose()
                    End With
                Case 1
                    btnInsurance.Text = String.Empty
                    InsList.Clear()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtDirection_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtDirection.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button

            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectDirection
                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtDirection.Left, txtDirection.Top + txtDirection.Height))

                    f.ShowDialog()
                    If f.DirectionID <> -1 Then
                        If txtDirection.Text <> f.DirectionName Then
                            txtDirection.Tag = f.DirectionID
                            txtDirection.Text = f.DirectionName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addDirection

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtDirection.Left, txtDirection.Top + txtDirection.Height))

                    f.ShowDialog()
                    f.Dispose()
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

    Private Sub ckUseBonusCard_CheckedChanged(sender As Object, e As EventArgs) Handles ckUseBonusCard.CheckedChanged
        If ckUseBonusCard.Checked = True Then
            GroupControl1.Enabled = True
        Else
            GroupControl1.Enabled = False
        End If
    End Sub

    Private Sub rMinus_CheckedChanged(sender As Object, e As EventArgs) Handles rMinus.CheckedChanged
        If rMinus.Checked = True Then
            ckMinusByOtherCustomer.Enabled = True
        Else
            ckMinusByOtherCustomer.Checked = False
            ckMinusByOtherCustomer.Enabled = False
        End If
    End Sub

    Private Sub addTour_Load(sender As Object, e As EventArgs) Handles Me.Load
        sDate.DateTime = Now
        eDate.DateTime = Now
    End Sub

End Class