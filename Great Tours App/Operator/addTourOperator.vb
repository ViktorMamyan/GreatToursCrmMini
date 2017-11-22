Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTourOperator

    Friend RefForm As New TourOperator
    Dim TourOperatorID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորի անունը գրված չէ")
            If txtLocation.Text.Trim = String.Empty Then Throw New Exception("Հասցեն նշված չէ")
            If ckByURL.Checked AndAlso txtByURL.Text.Trim = String.Empty Then Throw New Exception("Հարցման URL-ը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@OperatorName", txtOperator.Text.Trim))
                .Add(New SqlParameter("@Director", IIf(txtCeo.Text.Trim = String.Empty, DBNull.Value, txtCeo.Text.Trim)))
                .Add(New SqlParameter("@OperatorLocation", txtLocation.Text.Trim))
                .Add(New SqlParameter("@RequestByURL", ckByURL.Checked))
                .Add(New SqlParameter("@RequestURL", IIf(txtByURL.Text.Trim = String.Empty, DBNull.Value, txtByURL.Text.Trim)))
                .Add(New SqlParameter("@website", IIf(txtWebsite.Text.Trim = String.Empty, DBNull.Value, txtWebsite.Text.Trim)))
                .Add(New SqlParameter("@Tel", IIf(txtTel.Text.Trim = String.Empty, DBNull.Value, txtTel.Text.Trim)))
                .Add(New SqlParameter("@skype", IIf(txtSkype.Text.Trim = String.Empty, DBNull.Value, txtSkype.Text.Trim)))
                .Add(New SqlParameter("@facebook", IIf(txtFacebook.Text.Trim = String.Empty, DBNull.Value, txtFacebook.Text.Trim)))
                .Add(New SqlParameter("@email", IIf(txtEmail.Text.Trim = String.Empty, DBNull.Value, txtEmail.Text.Trim)))
                .Add(New SqlParameter("@Login", IIf(txtLogin.Text.Trim = String.Empty, DBNull.Value, txtLogin.Text.Trim)))
                .Add(New SqlParameter("@Password", IIf(txtPassword.Text.Trim = String.Empty, DBNull.Value, txtPassword.Text.Trim)))
                .Add(New SqlParameter("@AgentID", IIf(txtAgentID.Text.Trim = String.Empty, DBNull.Value, txtAgentID.Text.Trim)))
            End With
            ExecToSql("TourOperatorAdd", CommandType.StoredProcedure, Parameters.ToArray)

            TourOperatorID = Query_Scalar("SELECT dbo.GetTourOperatorID()")

            txtOperator.Text = String.Empty
            txtCeo.Text = String.Empty
            txtLocation.Text = String.Empty
            ckByURL.Checked = False
            txtByURL.Text = String.Empty
            txtWebsite.Text = String.Empty
            txtTel.Text = String.Empty
            txtSkype.Text = String.Empty
            txtFacebook.Text = String.Empty
            txtEmail.Text = String.Empty

            RefForm.LoadData()
            If TourOperatorID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TourOperatorID", TourOperatorID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            TourOperatorID = 0
            txtOperator.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class