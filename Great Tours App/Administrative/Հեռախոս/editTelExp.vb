Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editTelExp

    Friend RefForm As New TelephonePay

    Friend TelExpID As Int32 = 0
    Friend Fee As Decimal = 0
    Friend ForYear As Short = 0
    Friend ForMonth As Byte = 0
    Friend PhoneNumber As String = String.Empty

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtFee.EditValue = String.Empty OrElse txtFee.EditValue <= 0 Then Throw New Exception("Գումարը պետք է 0-ից մեծ լինի")
            If txtTelephone.Text = String.Empty Then Throw New Exception("Հեռախոսահամարը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TelExpID", TelExpID))
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@PhoneNumber", txtTelephone.Text.Trim))
            End With
            ExecToSql("TelephoneExpenseUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If TelExpID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("TelExpID", TelExpID)
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
        If TelExpID > 0 Then
            txtFee.Text = Fee
            txtTelephone.Text = PhoneNumber

            Dim d As Date = New Date(ForYear, ForMonth, 1)
            RegDate.DateTime = d
        Else
            btnEdit.Enabled = False
        End If
    End Sub

End Class