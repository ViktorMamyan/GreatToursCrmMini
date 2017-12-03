Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editAirOperator

    Friend RefForm As New AirOperator

    Friend AirOperatorID As Int32 = 0
    Friend sAirOperator As String = String.Empty
    Friend Country As String = String.Empty
    Friend URL As String = String.Empty
    Friend Login As String = String.Empty
    Friend Password As String = String.Empty
    Friend Contract As Boolean
    Friend Website As String = String.Empty
    Friend Tel As String = String.Empty
    Friend Skype As String = String.Empty
    Friend FB As String = String.Empty
    Friend Email As String = String.Empty
    Friend OtherContact As String = String.Empty

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորի անունը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@AirOperatorID", AirOperatorID))
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
            ExecToSql("AirOperatorEdit", CommandType.StoredProcedure, Parameters.ToArray)

            RefForm.LoadData()
            If AirOperatorID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("AirOperatorID", AirOperatorID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub editAirOperator_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AirOperatorID > 0 Then
            txtOperator.Text = sAirOperator
            txtCountry.Text = Country
            txtURL.Text = URL
            txtLogin.Text = Login
            txtPassword.Text = Password
            ckContract.Checked = Contract
            txtWebsite.Text = Website
            txtTel.Text = Tel
            txtSkype.Text = Skype
            txtFacebook.Text = FB
            txtEmail.Text = Email
            txtOtherContact.Text = OtherContact
        End If
    End Sub

End Class