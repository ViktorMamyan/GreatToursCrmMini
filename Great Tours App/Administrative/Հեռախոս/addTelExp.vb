Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTelExp

    Friend RefForm As New TelephonePay

    Dim TelExpID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")
            If txtTelephone.Text = String.Empty Then Throw New Exception("Հեռախոսահամարը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@PhoneNumber", txtTelephone.Text.Trim))
            End With
            ExecToSql("TelephoneExpenseAdd", CommandType.StoredProcedure, Parameters.ToArray)

            TelExpID = Query_Scalar("SELECT dbo.GetTelExpID()")

            txtFee.Text = String.Empty
            txtTelephone.Text = String.Empty
            RegDate.DateTime = Now

            RefForm.LoadData()
            If TelExpID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TelExpID", TelExpID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            TelExpID = 0
            txtFee.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
    End Sub

End Class