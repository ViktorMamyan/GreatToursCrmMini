Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class changeClient

    Friend ClientID As Integer = 0

    Private Sub LoadClient()
        Try
            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@ClientID", ClientID))
            End With
            Dim dt As DataTable = QueryToSqlServer("SELECT ClientID,ClientFullName,ClientContacts FROM GetClient() WHERE ClientID = @ClientID", CommandType.Text, Parameters.ToArray)

            If IsNothing(dt) OrElse dt.Rows.Count = 0 Then Throw New Exception("Տվյալները չեն ստացվել")

            txtClient.Text = dt.Rows(0)("ClientFullName")
            txtContact.Text = dt.Rows(0)("ClientContacts")

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtClient.Text.Trim = String.Empty Then Throw New Exception("Անվանումը գրված չէ")
            If txtContact.Text.Trim = String.Empty Then Throw New Exception("Կոնտակտները գրված չեն")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@ClientID", ClientID))
                .Add(New SqlParameter("@ClientFullName", txtClient.Text.Trim))
                .Add(New SqlParameter("@ClientContacts", txtContact.Text.Trim))
            End With
            ExecToSql("ClientUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub changeTaxType_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ClientID <= 0 Then
            btnEdit.Enabled = False
        Else
            Call LoadClient()
        End If
    End Sub

End Class