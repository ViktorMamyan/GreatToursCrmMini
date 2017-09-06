Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addCustomer

    Friend RefForm As New Customer
    Dim CustomerID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդի անունը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@CustomerName", txtCustomer.Text.Trim))
                .Add(New SqlParameter("@RegisterDate", RegDate.DateTime))
            End With
            ExecToSql("CustomerAdd", CommandType.StoredProcedure, Parameters.ToArray)

            CustomerID = Query_Scalar("SELECT dbo.GetLasCustomerID()")

            txtCustomer.Text = String.Empty
            RegDate.DateTime = Now

            RefForm.LoadData()
            If CustomerID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("CustomerID", CustomerID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            CustomerID = 0
            txtCustomer.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
    End Sub

End Class