Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editRentOfPlace

    Friend RefForm As New PlacePay

    Friend RentID As Integer = 0
    Friend Fee As Decimal
    Friend ForYear As Short = 0
    Friend ForMonth As Byte = 0
    Friend Comment As String = String.Empty

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@RentID", RentID))
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@Comment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
            End With
            ExecToSql("RentOfPlaceUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If RentID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("RentID", RentID)
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
        Try
            If RentID > 0 Then
                txtFee.Text = Fee
                txtComment.Text = Comment

                Dim d As Date = New Date(ForYear, ForMonth, 1)
                RegDate.DateTime = d
            End If
        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class