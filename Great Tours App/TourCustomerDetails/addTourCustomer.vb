Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTourCustomer

    Friend RefForm As New TourCustomer

    Friend TourID As Integer = 0
    Friend TourName As String = String.Empty

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim CustomerIDs = From item In txtCustomer.Properties.Items Where item.CheckState = CheckState.Checked
                         Select CInt(item.Value)

            If CustomerIDs.Count = 0 Then Throw New Exception("Հաճախորդ նշված չէ")

            Dim dtID As New DataTable With {.TableName = "CustomerIDs"}
            dtID.Columns.Add(New DataColumn("ID", GetType(Integer)))

            For i As Integer = 0 To CustomerIDs.Count - 1
                Dim R As DataRow = dtID.NewRow
                R("ID") = CustomerIDs(i)
                dtID.Rows.Add(R)
            Next

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TourID", TourID))
                Dim P As New SqlParameter("@CustomerDetailsID", dtID) With {.TypeName = "dbo.ID_List"}
                .Add(P)
            End With

            ExecToSql("TourCustomerAdd", CommandType.StoredProcedure, Parameters.ToArray)

            RefForm.LoadData()

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addTourCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTour.Text = TourName
        Call LoadCustomers()
    End Sub

    Sub LoadCustomers()
        Try
            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@TourID", TourID))
            End With

            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetCustomerDetailsByTourID(@TourID)", CommandType.Text, Parameters.ToArray)

            txtCustomer.Properties.Items.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                txtCustomer.Properties.Items.Add(dt.Rows(i)("CustomerDetailsID"), dt.Rows(i)("Customer"), CheckState.Unchecked, True)
            Next

            txtCustomer.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List

        Catch ex As Exception
            btnAdd.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class