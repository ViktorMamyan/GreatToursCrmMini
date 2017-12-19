Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class changeEmployee

    Friend EmployeeID As Integer = 0

    Friend FirstName As String = String.Empty
    Friend LastName As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtName.Text.Trim = String.Empty Then Throw New Exception("Աշխատակիցը նշված չէ")
            If txtLastName.Text.Trim = String.Empty Then Throw New Exception("Աշխատակիցը նշված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@EmployeeID", EmployeeID))
                .Add(New SqlParameter("@FirstName", txtName.Text.Trim))
                .Add(New SqlParameter("@LastName", txtLastName.Text.Trim))
            End With
            ExecToSql("EmployeeUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub changeTaxType_Load(sender As Object, e As EventArgs) Handles Me.Load
        If EmployeeID <= 0 Then btnEdit.Enabled = False

        txtName.Text = FirstName
        txtLastName.Text = LastName
    End Sub

End Class