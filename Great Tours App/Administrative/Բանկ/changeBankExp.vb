Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class changeBankExp

    Friend TypeID As Integer = 0
    Friend TypeName As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtType.Text.Trim = String.Empty Then Throw New Exception("Անվանումը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TypeID", TypeID))
                .Add(New SqlParameter("@TypeName", txtType.Text.Trim))
            End With
            ExecToSql("BankExpTypeUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub changeTaxType_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TypeID <= 0 Then btnEdit.Enabled = False
        txtType.Text = TypeName
    End Sub

End Class