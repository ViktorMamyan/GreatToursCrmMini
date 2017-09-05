Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editDirectionOperatorCombination

    Friend RefForm As New DirectionOperatorCombination

    Friend ID As Int32 = 0
    Friend DirectionID As Integer = 0
    Friend OperatorIDList As List(Of Integer)

    Private Sub LoadDirection()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT DirectionID,DirectionName FROM GetDirection() ORDER BY DirectionName", CommandType.Text)

            If dt.Rows.Count = 0 Then Throw New Exception("Ուղղության տվյալները բացակայում են")

            With cbDirection
                .DataSource = dt
                .DisplayMember = "DirectionName"
                .ValueMember = "DirectionID"
                .SelectedValue = DirectionID
            End With
        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub LoadOperators()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT TourOperatorID,OperatorName FROM GetTourOperator()", CommandType.Text)

            cbOperator.Properties.Items.Clear()

            If dt.Rows.Count = 0 Then Throw New Exception("Օպերատորի տվյալները բացակայում են")

            Dim list As New ArrayList()

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim b As Boolean = OperatorIDList.Exists(Function(x) x = dt.Rows(i)("TourOperatorID"))

                Dim cs As New CheckState

                If b = True Then
                    cs = CheckState.Checked
                Else
                    cs = CheckState.Unchecked
                End If

                list.Add(New CheckedListBoxItem(dt.Rows(i)("TourOperatorID"), dt.Rows(i)("OperatorName").ToString, cs))
            Next

            Dim items As CheckedListBoxItem() = DirectCast(list.ToArray(GetType(CheckedListBoxItem)), CheckedListBoxItem())

            cbOperator.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List
            cbOperator.Properties.Items.AddRange(items)

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim OperatorIDs = From item In cbOperator.Properties.Items Where item.CheckState = CheckState.Checked
                 Select CInt(item.Value)

            If OperatorIDs.Count = 0 Then Throw New Exception("Օպերատոր նշված չէ")

            Dim dtID As New DataTable With {.TableName = "OperatorIDs"}
            dtID.Columns.Add(New DataColumn("ID", GetType(Integer)))

            For i As Integer = 0 To OperatorIDs.Count - 1
                Dim R As DataRow = dtID.NewRow
                R("ID") = OperatorIDs(i)
                dtID.Rows.Add(R)
            Next

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@DirectionID", cbDirection.SelectedValue))
                Dim P As New SqlParameter("@OperatorID", dtID) With {.TypeName = "dbo.ID_List"}
                .Add(P)
            End With

            ExecToSql("DirectionOperatorCombinationEdit", CommandType.StoredProcedure, Parameters.ToArray)

            RefForm.LoadData()
            If ID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("ID", ID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addDirectionOperatorCombination_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadDirection()
        Call LoadOperators()
    End Sub

End Class