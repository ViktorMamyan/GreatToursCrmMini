Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editDirection

    Friend RefForm As New Direction

    Friend ID As Int32 = 0
    Friend DirectionName As String = String.Empty
    Friend SinlgeDirection As Boolean
    Friend VisaDetails As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If ID = 0 Then Throw New Exception("Օպերատորի իդենտիֆիկատորը անորոշ է")
            If txtDirection.Text.Trim = String.Empty Then Throw New Exception("Ուղղությունը գրված չէ")
            If txtViza.Text.Trim = String.Empty Then Throw New Exception("Վիզայի պարամետրերը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@DirectionID", ID))
                .Add(New SqlParameter("@DirectionName", txtDirection.Text.Trim))
                .Add(New SqlParameter("@SinlgeDirection", ckSingle.Checked))
                .Add(New SqlParameter("@VisaDetails", txtViza.Text.Trim))
            End With
            ExecToSql("DirectionEdit", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If ID > 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("DirectionID", ID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub editDirection_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ID > 0 Then
            txtDirection.Text = DirectionName
            ckSingle.Checked = SinlgeDirection
            txtViza.Text = VisaDetails
        End If
    End Sub

End Class