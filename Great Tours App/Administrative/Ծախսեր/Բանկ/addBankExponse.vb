﻿Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addBankExponse

    Friend RefForm As New BankExpense

    Dim BankExpenseID As Int32 = 0

    Private Sub LoadList()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT TypeID,TypeName FROM GetBankExpType()", CommandType.Text)

            With cTypes
                .DataSource = dt
                .DisplayMember = "TypeName"
                .ValueMember = "TypeID"
            End With

        Catch ex As Exception
            btnAdd.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@TypeID", cTypes.SelectedValue))
                .Add(New SqlParameter("@Comment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
            End With
            ExecToSql("BankExpenseAdd", CommandType.StoredProcedure, Parameters.ToArray)

            BankExpenseID = Query_Scalar("SELECT dbo.GetBankExpenseID()")

            txtFee.Text = String.Empty
            RegDate.DateTime = Now
            txtComment.Text = String.Empty

            RefForm.LoadData()
            If BankExpenseID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("BankExpenseID", BankExpenseID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            BankExpenseID = 0
            txtFee.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
        Call LoadList()
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newBankExpType
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Dim f As New changeBankExp With {.TypeID = cTypes.SelectedValue, .TypeName = cTypes.Text}
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

End Class