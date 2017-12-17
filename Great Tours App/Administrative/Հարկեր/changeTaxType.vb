Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class changeTaxType

    Friend TaxTypeId As Integer = 0
    Friend TaxType As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtTax.Text.Trim = String.Empty Then Throw New Exception("Անվանումը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TaxTypeId", TaxTypeId))
                .Add(New SqlParameter("@TaxType", txtTax.Text.Trim))
            End With
            ExecToSql("TaxTypeUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub changeTaxType_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TaxTypeId <= 0 Then btnEdit.Enabled = False
        txtTax.Text = TaxType
    End Sub

End Class