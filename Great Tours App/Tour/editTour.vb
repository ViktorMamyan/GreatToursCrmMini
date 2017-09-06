Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editTour

    Friend RefForm As New Tour

    Dim TourID As Int32 = 0

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtTour.Text = String.Empty Then Throw New Exception("Տուրի անունը գրված չէ")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկզբի ամսաթիվը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտի ամսաթիվը նշված չէ")
            If txtDirection.Text.Trim = String.Empty Then Throw New Exception("Ուղղությունը գրված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորը նշված չէ")
            If txtTotalPrice.Text = String.Empty OrElse txtTotalPrice.Text < 0 Then txtTotalPrice.Text = 0
            If txtApproximateIncome.Text = String.Empty OrElse txtApproximateIncome.Text < 0 Then txtTotalPrice.Text = 0

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
                .Add(New SqlParameter("@TotalPrice", txtTotalPrice.Text.Trim))
                .Add(New SqlParameter("@ApproximateIncome", txtApproximateIncome.Text.Trim))

                .Add(New SqlParameter("@UseBonusCard", IIf(ckUseBonusCard.Checked = True, True, False)))
                .Add(New SqlParameter("@AddBouns", IIf(rPlus.Checked = True, True, False)))
                .Add(New SqlParameter("@Card", IIf(ckUseBonusCard.Checked = True, txtCard.Text.Trim, DBNull.Value)))
                .Add(New SqlParameter("@Points", IIf(ckUseBonusCard.Checked = True, txtPoint.Text, DBNull.Value)))
                .Add(New SqlParameter("@ByAnotherCustomer", IIf(ckUseBonusCard.Checked = True AndAlso rMinus.Checked = True, ckMinusByOtherCustomer.Checked, DBNull.Value)))
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
            txtTotalPrice.Text = 0
            txtApproximateIncome.Text = 0

            txtCard.Text = String.Empty
            txtPoint.Text = 0
            ckMinusByOtherCustomer.Checked = False
            rPlus.Checked = True
            ckUseBonusCard.Checked = False

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