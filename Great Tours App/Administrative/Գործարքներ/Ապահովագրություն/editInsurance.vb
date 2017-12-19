Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editInsurance

    Friend RefForm As New InsuranceW

    Friend InsuranceID As Int32 = 0
    Friend ClientID As Integer = 0
    Friend StartDate As Date
    Friend EndDate As Date
    Friend Price As Decimal
    Friend Cost As Nullable(Of Decimal)
    Friend ReturnableDate As Nullable(Of Date)

    Private Sub LoadList()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT ClientID,ClientFullName FROM GetClient()", CommandType.Text)

            With cbClient
                .DataSource = dt
                .DisplayMember = "ClientFullName"
                .ValueMember = "ClientID"
                .SelectedValue = ClientID
            End With

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txPrice.EditValue = String.Empty OrElse txPrice.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկիզբը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտը նշված չէ")
            If cRet.Checked = True AndAlso rDate.Text.Trim = String.Empty Then Throw New Exception("Վերադարձի ամսաթիվը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@InsuranceID", InsuranceID))
                .Add(New SqlParameter("@StartDate", sDate.DateTime))
                .Add(New SqlParameter("@EndDate", eDate.DateTime))
                .Add(New SqlParameter("@ClientID", cbClient.SelectedValue))
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

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If InsuranceID > 0 Then
            txPrice.Text = Price
            sDate.DateTime = StartDate
            eDate.DateTime = EndDate

            If Cost.HasValue Then txtCost.Text = Cost
            If ReturnableDate.HasValue Then cRet.Checked = True : rDate.DateTime = ReturnableDate

            Call LoadList()
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newClient
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Dim f As New changeClient With {.ClientID = cbClient.SelectedValue}
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

    Private Sub cRet_CheckedChanged(sender As Object, e As EventArgs) Handles cRet.CheckedChanged
        If cRet.Checked = True Then
            rDate.Enabled = True
        Else
            rDate.Enabled = False
        End If
    End Sub

End Class