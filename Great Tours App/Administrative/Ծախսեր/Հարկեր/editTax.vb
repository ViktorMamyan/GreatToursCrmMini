Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editTax

    Friend RefForm As New Taxes

    Friend TaxID As Integer = 0
    Friend Fee As Decimal = 0
    Friend ForYear As Short = 0
    Friend ForMonth As Byte = 0
    Friend TaxTypeID As Integer = 0
    Friend TaxType As String = String.Empty

    Private Sub LoadTaxType()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT TaxTypeID,TaxType FROM GetTaxTypes()", CommandType.Text)

            With cTaxType
                .DataSource = dt
                .DisplayMember = "TaxType"
                .ValueMember = "TaxTypeID"
                .SelectedValue = TaxTypeID
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
                .Add(New SqlParameter("@TaxID", TaxID))
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@TaxTypeID", cTaxType.SelectedValue))
            End With
            ExecToSql("TaxUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If TaxID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TaxID", TaxID)
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
        RegDate.DateTime = Now
        If TaxID > 0 Then
            Call LoadTaxType()

            txtFee.Text = Fee

            Dim d As Date = New Date(ForYear, ForMonth, 1)
            RegDate.DateTime = d
        Else
            btnEdit.Enabled = False
        End If
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