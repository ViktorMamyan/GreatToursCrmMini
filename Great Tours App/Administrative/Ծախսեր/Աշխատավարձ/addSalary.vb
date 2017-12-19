Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addSalary

    Friend RefForm As New Salary

    Dim SalaryID As Int32 = 0

    Private Sub LoadEmployee()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT EmployeeID,Employee FROM GetEmployee()", CommandType.Text)

            With cEmployee
                .DataSource = dt
                .DisplayMember = "Employee"
                .ValueMember = "EmployeeID"
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
                .Add(New SqlParameter("@EmployeeID", cEmployee.SelectedValue))
                .Add(New SqlParameter("@IsBonus", ckIsBonus.Checked))
            End With
            ExecToSql("SalaryAdd", CommandType.StoredProcedure, Parameters.ToArray)

            SalaryID = Query_Scalar("SELECT dbo.GetSalaryID()")

            txtFee.Text = String.Empty
            ckIsBonus.Checked = False
            RegDate.DateTime = Now

            RefForm.LoadData()
            If SalaryID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("SalaryID", SalaryID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            SalaryID = 0
            txtFee.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegDate.DateTime = Now
        Call LoadEmployee()
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