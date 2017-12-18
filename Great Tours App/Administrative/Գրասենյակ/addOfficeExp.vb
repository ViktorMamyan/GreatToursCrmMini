Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addOfficeExp

    Friend RefForm As New OfficeExp

    Dim OfficeExponseID As Int32 = 0

    Private Sub LoadList()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT OfficeExponseTypeID,OfficeExpType FROM GetOfficeExponseType()", CommandType.Text)

            With cTypes
                .DataSource = dt
                .DisplayMember = "OfficeExpType"
                .ValueMember = "OfficeExponseTypeID"
            End With

        Catch ex As Exception
            btnAdd.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@OfficeExponseTypeID", cTypes.SelectedValue))
            End With
            ExecToSql("OfficeExponseAdd", CommandType.StoredProcedure, Parameters.ToArray)

            OfficeExponseID = Query_Scalar("SELECT dbo.GetOfficeExponseID()")

            txtFee.Text = String.Empty
            RegDate.DateTime = Now

            RefForm.LoadData()
            If OfficeExponseID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("OfficeExponseID", OfficeExponseID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            OfficeExponseID = 0
            txtFee.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
        Call LoadList()
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newOfficeExpType
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Dim f As New changeOfficeExp With {.OfficeExponseTypeID = cTypes.SelectedValue, .OfficeExpType = cTypes.Text}
        f.ShowDialog()
        f.Dispose()

        Call LoadList()
    End Sub

End Class