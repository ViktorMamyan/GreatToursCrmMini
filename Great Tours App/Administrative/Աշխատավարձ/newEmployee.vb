Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class newEmployee

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtName.Text.Trim = String.Empty Then Throw New Exception("Աշխատակիցը նշված չէ")
            If txtLastName.Text.Trim = String.Empty Then Throw New Exception("Աշխատակիցը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@FirstName", txtName.Text.Trim))
                .Add(New SqlParameter("@LastName", txtLastName.Text.Trim))
            End With
            ExecToSql("EmployeeAdd", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class