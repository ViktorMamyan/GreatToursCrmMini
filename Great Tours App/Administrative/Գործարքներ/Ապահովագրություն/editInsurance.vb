Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editInsurance

    Friend RefForm As New InsuranceW

    Friend InsuranceID As Int32 = 0

    Friend ClientID As Integer = 0
    Friend ClientName As String = String.Empty

    Friend StartDate As Date
    Friend EndDate As Date
    Friend Price As Decimal
    Friend Cost As Nullable(Of Decimal)
    Friend ReturnableDate As Nullable(Of Date)

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txPrice.EditValue = String.Empty OrElse txPrice.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկիզբը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտը նշված չէ")
            If cRet.Checked = True AndAlso rDate.Text.Trim = String.Empty Then Throw New Exception("Վերադարձի ամսաթիվը նշված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@InsuranceID", InsuranceID))
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
            End With
            ExecToSql("InsuranceUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If InsuranceID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("InsuranceID", InsuranceID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

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

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If InsuranceID > 0 Then
            txPrice.Text = Price
            sDate.DateTime = StartDate
            eDate.DateTime = EndDate

            txtCustomer.Tag = ClientID
            txtCustomer.Text = ClientName

            If Cost.HasValue Then txtCost.Text = Cost
            If ReturnableDate.HasValue Then cRet.Checked = True : rDate.DateTime = ReturnableDate
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub cRet_CheckedChanged(sender As Object, e As EventArgs) Handles cRet.CheckedChanged
        If cRet.Checked = True Then
            rDate.Enabled = True
        Else
            rDate.Enabled = False
        End If
    End Sub

End Class