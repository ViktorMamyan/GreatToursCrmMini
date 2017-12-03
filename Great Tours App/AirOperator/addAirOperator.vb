Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addAirOperator

    Friend RefForm As New AirOperator
    Dim AirOperatorID As Int32 = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորի անունը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@AirOperator", txtOperator.Text.Trim))
                .Add(New SqlParameter("@Country", IIf(txtCountry.Text.Trim = String.Empty, DBNull.Value, txtCountry.Text.Trim)))
                .Add(New SqlParameter("@URL", IIf(txtURL.Text.Trim = String.Empty, DBNull.Value, txtURL.Text.Trim)))
                .Add(New SqlParameter("@Login", IIf(txtLogin.Text.Trim = String.Empty, DBNull.Value, txtLogin.Text.Trim)))
                .Add(New SqlParameter("@Password", IIf(txtPassword.Text.Trim = String.Empty, DBNull.Value, txtPassword.Text.Trim)))
                .Add(New SqlParameter("@Contract", ckContract.Checked))
                .Add(New SqlParameter("@website", IIf(txtWebsite.Text.Trim = String.Empty, DBNull.Value, txtWebsite.Text.Trim)))
                .Add(New SqlParameter("@Tel", IIf(txtTel.Text.Trim = String.Empty, DBNull.Value, txtTel.Text.Trim)))
                .Add(New SqlParameter("@skype", IIf(txtSkype.Text.Trim = String.Empty, DBNull.Value, txtSkype.Text.Trim)))
                .Add(New SqlParameter("@FB", IIf(txtFacebook.Text.Trim = String.Empty, DBNull.Value, txtFacebook.Text.Trim)))
                .Add(New SqlParameter("@Email", IIf(txtEmail.Text.Trim = String.Empty, DBNull.Value, txtEmail.Text.Trim)))
                .Add(New SqlParameter("@OtherContacts", IIf(txtOtherContact.Text.Trim = String.Empty, DBNull.Value, txtOtherContact.Text.Trim)))
            End With
            ExecToSql("AirOperatorAdd", CommandType.StoredProcedure, Parameters.ToArray)

            AirOperatorID = Query_Scalar("SELECT dbo.GetAirOperatorID()")

            txtOperator.Text = String.Empty
            txtCountry.Text = String.Empty
            ckContract.Checked = False
            txtURL.Text = String.Empty
            txtWebsite.Text = String.Empty
            txtTel.Text = String.Empty
            txtSkype.Text = String.Empty
            txtFacebook.Text = String.Empty
            txtEmail.Text = String.Empty
            txtOtherContact.Text = String.Empty
            txtPassword.Text = String.Empty
            txtLogin.Text = String.Empty

            RefForm.LoadData()
            If AirOperatorID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("AirOperatorID", AirOperatorID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            AirOperatorID = 0
            txtOperator.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class