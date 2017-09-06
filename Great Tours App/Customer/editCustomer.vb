Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editCustomer

    Friend RefForm As New Customer

    Friend CustomerID As Int32 = 0
    Friend CustomerName As String = String.Empty
    Friend RegisterDate As Date

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդի անունը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@CustomerID", CustomerID))
                .Add(New SqlParameter("@CustomerName", txtCustomer.Text.Trim))
                .Add(New SqlParameter("@RegisterDate", RegDate.DateTime))
            End With
            ExecToSql("CustomerEdit", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If CustomerID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("CustomerID", CustomerID)
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
        If CustomerID > 0 Then
            txtCustomer.Text = CustomerName
            RegDate.DateTime = RegisterDate
        Else
            btnEdit.Enabled = False
        End If

    End Sub

End Class