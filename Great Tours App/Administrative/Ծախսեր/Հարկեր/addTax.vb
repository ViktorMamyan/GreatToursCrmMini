Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTax

    Friend RefForm As New Taxes
    Dim TaxID As Int32 = 0

    Private Sub LoadTaxType()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT TaxTypeID,TaxType FROM GetTaxTypes()", CommandType.Text)

            With cTaxType
                .DataSource = dt
                .DisplayMember = "TaxType"
                .ValueMember = "TaxTypeID"
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
                .Add(New SqlParameter("@TaxTypeID", cTaxType.SelectedValue))
            End With
            ExecToSql("TaxAdd", CommandType.StoredProcedure, Parameters.ToArray)

            TaxID = Query_Scalar("SELECT dbo.GetTaxID()")

            txtFee.Text = String.Empty
            RegDate.DateTime = Now

            RefForm.LoadData()
            If TaxID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TaxID", TaxID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            TaxID = 0
            txtFee.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
        Call LoadTaxType()
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newTaxType
        f.ShowDialog()
        f.Dispose()

        Call LoadTaxType()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Dim f As New changeTaxType With {.TaxTypeId = cTaxType.SelectedValue, .TaxType = cTaxType.Text}
        f.ShowDialog()
        f.Dispose()

        Call LoadTaxType()
    End Sub

End Class