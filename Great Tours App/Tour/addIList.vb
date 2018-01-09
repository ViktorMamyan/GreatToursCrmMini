Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addIList

    Friend InsList As New List(Of LIns)

    Private Sub LoadData()
        GridControl1.BeginUpdate()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim dt As DataTable = ToDataTable(InsList)

        GridControl1.DataSource = dt

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("MultiCount") = 0 Then dt.Rows(i)("MultiCount") = DBNull.Value
            If dt.Rows(i)("ReturnDate") = Date.MinValue Then dt.Rows(i)("ReturnDate") = DBNull.Value
        Next

        With GridView1
            .OptionsCustomization.AllowColumnMoving = False
            .OptionsCustomization.AllowGroup = False
            .OptionsSelection.EnableAppearanceFocusedCell = False
            .OptionsSelection.EnableAppearanceFocusedRow = False

            .Columns("ID").Visible = False

            .Columns("StartDate").Caption = "Սկիզբ"
            .Columns("EndDate").Caption = "Ավարտ"

            .Columns("IsReturnable").Caption = "Վերադարձվող"
            .Columns("ReturnDate").Caption = "Վերադարձի Ամսաթիվ"
            .Columns("IsMulti").Caption = "Մուլտի"
            .Columns("MultiCount").Caption = "Օրեր"

        End With

        GridView1.ClearSelection()
        GridControl1.EndUpdate()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If sDate.Text.Trim = String.Empty Then Throw New Exception("Սկիզբը նշված չէ")
            If eDate.Text.Trim = String.Empty Then Throw New Exception("Ավարտը նշված չէ")
            If cRet.Checked = True AndAlso rDate.Text.Trim = String.Empty Then Throw New Exception("Վերադարձի ամսաթիվը նշված չէ")

            InsList.Add(New LIns With {.ID = Guid.NewGuid(), .StartDate = sDate.DateTime, .EndDate = eDate.DateTime, .IsReturnable = cRet.Checked,
                                       .ReturnDate = IIf(cRet.Checked = True, rDate.DateTime, Date.MinValue), .IsMulti = ckMulti.Checked,
                                       .MultiCount = IIf(ckMulti.Checked = True, txtMulti.Text, 0)})

            Call LoadData()

            sDate.Text = String.Empty
            eDate.Text = String.Empty
            rDate.Text = String.Empty
            cRet.Checked = False
            txtMulti.Text = 0
            ckMulti.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub cRet_CheckedChanged(sender As Object, e As EventArgs) Handles cRet.CheckedChanged
        If cRet.Checked = True Then
            rDate.Enabled = True
        Else
            rDate.Enabled = False
        End If
    End Sub

    Private Sub ckMulti_CheckedChanged(sender As Object, e As EventArgs) Handles ckMulti.CheckedChanged
        If ckMulti.Checked = True Then
            txtMulti.Enabled = True
        Else
            txtMulti.Text = 0
            txtMulti.Enabled = False
        End If
    End Sub

    Private Sub addIList_Load(sender As Object, e As EventArgs) Handles Me.Load
        sDate.DateTime = Now
        eDate.DateTime = Now

        If InsList.Count > 0 Then
            Call LoadData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")

            For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                InsList.RemoveAll(Function(j) j.ID = GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("ID"))
            Next

            Call LoadData()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class