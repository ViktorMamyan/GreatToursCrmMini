Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Newtonsoft.Json

Public Class editTour

    Friend RefForm As New Tour

    Friend TourID As Int32 = 0
    Friend TourName As String = String.Empty
    Friend TourStartDate As Date
    Friend TourEndDate As Date
    Friend DirectionID As Integer = 0
    Friend DirectionName As String = String.Empty
    Friend OperatorID As Integer = 0
    Friend OperatorName As String = String.Empty
    Friend CustomerID As Integer = 0
    Friend Customer As String = String.Empty
    Friend Price As Decimal = 0

    Friend Cost As Decimal?

    Friend AdultCount As Byte = 0
    Friend ChildCount As Byte?
    Friend BabyCount As Byte?

    Friend ChildYearsComment As String = String.Empty

    Friend PaymaetDeathLine As Date?
    Friend PrePayPrice As Decimal?
    Friend NextPayDate As Date?

    Friend IsTotalyPayed As Boolean

    Friend Excursion As String = String.Empty
    Friend VIsa As String = String.Empty
    Friend Transfer As String = String.Empty
    Friend TourType As String = String.Empty

    Friend strHotelList As String = String.Empty
    Friend strTicketList As String = String.Empty
    Friend strInsList As String = String.Empty

    Dim HotelList As New List(Of LHotel)
    Dim TicketList As New List(Of LTicket)
    Dim InsList As New List(Of LIns)

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtTour.Text = String.Empty Then Throw New Exception("Տուրի անունը գրված չէ")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկզբի ամսաթիվը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտի ամսաթիվը նշված չէ")
            If txtDirection.Text.Trim = String.Empty Then Throw New Exception("Ուղղությունը գրված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորը նշված չէ")
            If txtPrice.Text = String.Empty OrElse txtPrice.Text < 0 Then txtPrice.Text = 0
            If txtCost.Text = String.Empty OrElse txtCost.Text < 0 Then txtPrice.Text = 0

            If ckUseBonusCard.Checked = True Then
                If txtCard.Text.Trim = String.Empty Then Throw New Exception("Բոնուսային քարտը նշված չէ")
                If txtPoint.Text.Trim = String.Empty OrElse txtPoint.Text <= 0 Then Throw New Exception("Անորոշ միավոր")
            End If

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TourID", TourID))
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

            ExecToSql("TourEdit", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If TourID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TourID", TourID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

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

    Private Sub editTour_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TourID > 0 Then
            txtTour.Text = TourName
            sDate.DateTime = TourStartDate
            eDate.DateTime = TourEndDate
            txtDirection.Tag = DirectionID
            txtDirection.Text = DirectionName
            txtOperator.Tag = OperatorID
            txtOperator.Text = OperatorName
            txtCustomer.Tag = CustomerID
            txtCustomer.Text = Customer
            txtPrice.Text = Price

            If Cost.HasValue Then txtCost.Text = Cost
            txtAdultCount.Text = AdultCount

            If ChildCount.HasValue Then txtChildCount.Text = ChildCount
            If BabyCount.HasValue Then txtBabyCount.Text = BabyCount

            If Not String.IsNullOrEmpty(ChildYearsComment) Then txtComment.Text = ChildYearsComment

            If PaymaetDeathLine.HasValue Then lDate.DateTime = PaymaetDeathLine
            If PrePayPrice.HasValue Then txtPrePay.Text = PrePayPrice
            If NextPayDate.HasValue Then nDate.DateTime = NextPayDate

            cTotalPayed.Checked = IsTotalyPayed

            txtExcursion.Text = Excursion
            txtVisa.Text = VIsa
            txtTransfer.Text = Transfer
            txtTourType.Text = TourType

            If Not strHotelList = String.Empty Then
                HotelList = JsonConvert.DeserializeObject(Of List(Of LHotel))(strHotelList)
                btnHotel.Text = HotelList.Item(0).Hotel
            End If

            If Not strTicketList = String.Empty Then
                TicketList = JsonConvert.DeserializeObject(Of List(Of LTicket))(strTicketList)
                btnTicket.Text = TicketList.Item(0).Ticket
            End If

            If Not strInsList = String.Empty Then
                InsList = JsonConvert.DeserializeObject(Of List(Of LIns))(strInsList)
                btnInsurance.Text = InsList.Item(0).StartDate.ToShortDateString
            End If

            Call GetBonusByTourID()

        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Sub GetBonusByTourID()
        Try
            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TourID", TourID))
            End With

            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetBonusByTourID(@TourID)", CommandType.Text, Parameters.ToArray)

            If dt.Rows.Count > 0 Then
                ckUseBonusCard.Checked = True
                txtCard.Text = dt.Rows(0)("Card")

                If dt.Rows(0)("Direction") = "IN" Then
                    rPlus.Checked = True
                    txtPoint.Text = dt.Rows(0)("Points")
                Else
                    rMinus.Checked = True
                    txtPoint.Text = dt.Rows(0)("Points") * (-1)

                    If dt.Rows(0)("IsDiffCustomer") = True Then ckMinusByOtherCustomer.Checked = True
                End If

            End If

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class