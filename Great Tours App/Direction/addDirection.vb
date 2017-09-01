Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addDirection

    Friend RefForm As New Direction
    Dim DirectionID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtDirection.Text.Trim = String.Empty Then Throw New Exception("Ուղղությունը գրված չէ")
            If txtViza.Text.Trim = String.Empty Then Throw New Exception("Վիզայի պարամետրերը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@DirectionName", txtDirection.Text.Trim))
                .Add(New SqlParameter("@SinlgeDirection", ckSingle.Checked))
                .Add(New SqlParameter("@VisaDetails", txtViza.Text.Trim))
            End With
            ExecToSql("DirectionAdd", CommandType.StoredProcedure, Parameters.ToArray)

            DirectionID = Query_Scalar("SELECT dbo.GetLasDirectionID()")

            txtDirection.Text = String.Empty
            txtViza.Text = String.Empty
            ckSingle.Checked = True

            RefForm.LoadData()
            If DirectionID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("DirectionID", DirectionID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            DirectionID = 0
            txtDirection.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class