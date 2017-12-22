Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editUtility

    Friend RefForm As New Utility

    Friend UtilExpID As Int32 = 0
    Friend Fee As Decimal = 0
    Friend ForYear As Short = 0
    Friend ForMonth As Byte = 0
    Friend UtilityTypeID As Integer = 0
    Friend Utility As String = String.Empty
    Friend Comment As String = String.Empty

    Private Sub LoadList()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT UtilityTypeID,Utility FROM GetUtilityType()", CommandType.Text)

            With cTypes
                .DataSource = dt
                .DisplayMember = "Utility"
                .ValueMember = "UtilityTypeID"
                .SelectedValue = UtilityTypeID
            End With

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@UtilExpID", UtilExpID))
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@UtilityTypeID", cTypes.SelectedValue))
                .Add(New SqlParameter("@Comment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
            End With
            ExecToSql("UtilityExpenseUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If UtilExpID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("UtilExpID", UtilExpID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If UtilExpID > 0 Then
            txtFee.Text = Fee
            txtComment.Text = Comment

            Dim d As Date = New Date(ForYear, ForMonth, 1)
            RegDate.DateTime = d

            Call LoadList()
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newUtilityType
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Dim f As New changeUtilityType With {.UtilityTypeID = cTypes.SelectedValue, .Utility = cTypes.Text}
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

End Class