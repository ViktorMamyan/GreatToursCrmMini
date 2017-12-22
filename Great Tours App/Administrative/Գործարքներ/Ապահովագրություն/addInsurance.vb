Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addInsurance

    Friend RefForm As New InsuranceW

    Dim InsuranceID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txPrice.EditValue = String.Empty OrElse txPrice.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկիզբը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտը նշված չէ")
            If cRet.Checked = True AndAlso rDate.Text.Trim = String.Empty Then Throw New Exception("Վերադարձի ամսաթիվը նշված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@StartDate", sDate.DateTime))
                .Add(New SqlParameter("@EndDate", eDate.DateTime))
                .Add(New SqlParameter("@ClientID", txtCustomer.Tag.ToString))
                .Add(New SqlParameter("@Price", txPrice.EditValue))

                If txtCost.EditValue = String.Empty OrElse txtCost.EditValue <= 0 Then
                    .Add(New SqlParameter("@Cost", DBNull.Value))
                Else
                    .Add(New SqlParameter("@Cost", txtCost.EditValue))
                End If

                If cRet.Checked = False Then
                    .Add(New SqlParameter("@ReturnableDate", DBNull.Value))
                Else
                    .Add(New SqlParameter("@ReturnableDate", rDate.DateTime))
                End If

                .Add(New SqlParameter("@IsMulti", ckMulti.Checked))

                If txtMulti.Enabled = True AndAlso txtMulti.EditValue > 0 Then
                    .Add(New SqlParameter("@DaysCount", txtMulti.EditValue))
                Else
                    .Add(New SqlParameter("@DaysCount", DBNull.Value))
                End If

            End With
            ExecToSql("InsuranceAdd", CommandType.StoredProcedure, Parameters.ToArray)

            InsuranceID = Query_Scalar("SELECT dbo.GetInsuranceID()")

            txPrice.Text = String.Empty
            sDate.Text = String.Empty
            eDate.Text = String.Empty
            txtCost.Text = String.Empty
            txtCustomer.Text = String.Empty
            txtCustomer.Tag = String.Empty
            rDate.Text = String.Empty
            cRet.Checked = False
            txtMulti.Text = 0
            ckMulti.Checked = False

            RefForm.LoadData()
            If InsuranceID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("InsuranceID", InsuranceID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            InsuranceID = 0
            txPrice.Select()

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

    Private Sub cRet_CheckedChanged(sender As Object, e As EventArgs) Handles cRet.CheckedChanged
        If cRet.Checked = True Then
            rDate.Enabled = True
        Else
            rDate.Enabled = False
        End If
    End Sub

    Private Sub ckMulti_CheckedChanged(sender As Object, e As EventArgs) Handles ckMulti.CheckedChanged
        If ckMulti.Checked = True Then
            txtMulti.Enabled = True
        Else
            txtMulti.Text = 0
            txtMulti.Enabled = False
        End If
    End Sub

End Class