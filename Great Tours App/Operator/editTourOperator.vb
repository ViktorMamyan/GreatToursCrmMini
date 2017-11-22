Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editTourOperator

    Friend RefForm As New TourOperator

    Friend ID As Int32 = 0
    Friend OperatorName As String = String.Empty
    Friend Director As String = String.Empty
    Friend OperatorLocation As String = String.Empty
    Friend RequestByURL As Boolean
    Friend RequestURL As String = String.Empty
    Friend website As String = String.Empty
    Friend Tel As String = String.Empty
    Friend skype As String = String.Empty
    Friend facebook As String = String.Empty
    Friend email As String = String.Empty
    Friend Login As String = String.Empty
    Friend Password As String = String.Empty
    Friend AgentID As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If ID = 0 Then Throw New Exception("Օպերատորի իդենտիֆիկատորը անորոշ է")
            If txtOperator.Text.Trim = String.Empty Then Throw New Exception("Օպերատորի անունը գրված չէ")
            If txtLocation.Text.Trim = String.Empty Then Throw New Exception("Հասցեն նշված չէ")
            If ckByURL.Checked AndAlso txtByURL.Text.Trim = String.Empty Then Throw New Exception("Հարցման URL-ը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@ID", ID))
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
            ExecToSql("TourOperatorEdit", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If ID > 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TourOperatorID", ID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub editTourOperator_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ID > 0 Then
            txtOperator.Text = OperatorName
            txtCeo.Text = Director
            txtLocation.Text = OperatorLocation
            ckByURL.Checked = RequestByURL
            txtByURL.Text = RequestURL
            txtWebsite.Text = website
            txtTel.Text = Tel
            txtSkype.Text = skype
            txtFacebook.Text = facebook
            txtEmail.Text = email
            txtLogin.Text = Login
            txtPassword.Text = Password
            txtAgentID.Text = AgentID
        End If
    End Sub

End Class