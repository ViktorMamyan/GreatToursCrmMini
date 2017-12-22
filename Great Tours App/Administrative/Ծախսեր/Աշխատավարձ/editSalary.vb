Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editSalary

    Friend RefForm As New Salary

    Friend SalaryID As Int32 = 0
    Friend Fee As Decimal = 0
    Friend ForYear As Short = 0
    Friend ForMonth As Byte = 0
    Friend EmployeeID As Integer = 0
    Friend Employee As String = String.Empty
    Friend IsBonus As Boolean
    Friend Comment As String = String.Empty

    Private Sub LoadEmployee()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT EmployeeID,Employee FROM GetEmployee()", CommandType.Text)

            With cEmployee
                .DataSource = dt
                .DisplayMember = "Employee"
                .ValueMember = "EmployeeID"
                .SelectedValue = EmployeeID
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
                .Add(New SqlParameter("@SalaryID", SalaryID))
                .Add(New SqlParameter("@Fee", txtFee.EditValue))
                .Add(New SqlParameter("@ForYear", RegDate.DateTime.Year))
                .Add(New SqlParameter("@ForMonth", RegDate.DateTime.Month))
                .Add(New SqlParameter("@EmployeeID", cEmployee.SelectedValue))
                .Add(New SqlParameter("@IsBonus", ckIsBonus.Checked))
                .Add(New SqlParameter("@Comment", IIf(txtComment.Text.Trim = String.Empty, DBNull.Value, txtComment.Text.Trim)))
            End With
            ExecToSql("SalaryUpdate", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If SalaryID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("SalaryID", SalaryID)
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
        If SalaryID > 0 Then
            txtFee.Text = Fee
            ckIsBonus.Checked = IsBonus
            txtComment.Text = Comment

            Dim d As Date = New Date(ForYear, ForMonth, 1)
            RegDate.DateTime = d

            Call LoadEmployee()
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnNewTaxType_Click(sender As Object, e As EventArgs) Handles btnNewTaxType.Click
        Dim f As New newEmployee
        f.ShowDialog()
        f.Dispose()

        Call LoadEmployee()
    End Sub

    Private Sub btnEditTaxType_Click(sender As Object, e As EventArgs) Handles btnEditTaxType.Click
        Try
            Dim sName() As String = Split(cEmployee.Text, " ")

            Dim fName As String = sName(0)
            Dim lName As String = sName(1)

            Dim f As New changeEmployee With {.EmployeeID = cEmployee.SelectedValue, .FirstName = fName, .LastName = lName}
            f.ShowDialog()
            f.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try

        Call LoadEmployee()
    End Sub

End Class