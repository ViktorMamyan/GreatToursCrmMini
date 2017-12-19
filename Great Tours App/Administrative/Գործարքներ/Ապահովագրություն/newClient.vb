Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class newClient

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtClient.Text.Trim = String.Empty Then Throw New Exception("Անվանումը գրված չէ")
            If txtContact.Text.Trim = String.Empty Then Throw New Exception("Կոնտակտները գրված չեն")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@ClientFullName", txtClient.Text.Trim))
                .Add(New SqlParameter("@ClientContacts", txtContact.Text.Trim))
            End With
            ExecToSql("ClientAdd", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class