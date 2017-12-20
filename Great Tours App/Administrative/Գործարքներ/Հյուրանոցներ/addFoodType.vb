Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addFoodType

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtFoodType.Text = String.Empty Then Throw New Exception("Սննդի տեսակը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@FoodName", txtFoodType.Text.Trim))
            End With
            ExecToSql("FoodTypeAdd", CommandType.StoredProcedure, Parameters.ToArray)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class