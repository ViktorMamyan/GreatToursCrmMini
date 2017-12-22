Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class PlacePay

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetRentOfPlace()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("RentID").Visible = False

                .Columns("CreationDate").Caption = "Ավելացման Ամսաթիվ"
                .Columns("Fee").Caption = "Վարձավճար"
                .Columns("ForYear").Caption = "Տարի"
                .Columns("ForMonth").Caption = "Ամիս"
                .Columns("Comment").Caption = "Մեկնաբանություն"

                .Columns("Fee").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Fee").DisplayFormat.FormatString = "n2"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("CreationDate").Summary.ActiveCount = 0 Then
                    GridView1.Columns("CreationDate").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CreationDate", "Քանակ` {0}"))
                    GridView1.Columns("Fee").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Fee", "Վարձավճար` {0:n2}"))
                End If
            End If

            GridView1.ClearSelection()
            GridControl1.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub
    Private Sub TourOperator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadData()
    End Sub
    Sub NewItem()
        Dim f As New addRentOfPlace With {.RefForm = DirectCast(Me, PlacePay)}
        f.ShowDialog()
        f.Dispose()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call NewItem()
        GridView1.Focus()
    End Sub
    Sub EditItem()
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
            If GridView1.SelectedRowsCount > 1 Then Throw New Exception("Հարկավոր է նշել միայն մեկ տող")

            Dim RentID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("RentID")
            Dim Fee As Decimal = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Fee")
            Dim ForYear As Short = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ForYear")
            Dim ForMonth As Byte = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ForMonth")

            Dim Comment As String
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Comment")) Then Comment = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Comment")

            Dim EE As New editRentOfPlace With {.RefForm = DirectCast(Me, PlacePay), .RentID = RentID,
                .Fee = Fee, .ForYear = ForYear, .ForMonth = ForMonth, .Comment = Comment}

            EE.ShowDialog()
            EE.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call EditItem()
        GridView1.Focus()
    End Sub
    Sub DeleteItem()
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
            If MsgBox("Ցանկանու՞մ եք ջնջել գրանցումը", MsgBoxStyle.Question + MsgBoxStyle.YesNo, My.Application.Info.Title) <> DialogResult.Yes Then Exit Sub

            For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                Dim Parameters As New List(Of SqlParameter)
                With Parameters
                    .Add(New SqlParameter("@RentID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("RentID")))
                End With
                ExecToSql("RentOfPlaceDelete", CommandType.StoredProcedure, Parameters.ToArray)

            Next

            Call LoadData()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call DeleteItem()
        GridView1.Focus()
    End Sub
    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        On Error Resume Next
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Dim grid As DevExpress.XtraGrid.GridControl = sender
            Dim view As New DevExpress.XtraGrid.Views.Grid.GridView()
            view = GridControl1.FocusedView
            Clipboard.SetText(view.GetFocusedDisplayText())
            e.Handled = True
        End If
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportTo(GridControl1, Me.Text)
        GridView1.Focus()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub
    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Try
            Dim info As GridHitInfo = view.CalcHitInfo(pt)
            If info.InRow OrElse info.InRowCell Then
                If info.Column Is Nothing Then
                    'N/A
                Else
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "RentID")) OrElse view.GetRowCellValue(info.RowHandle, "RentID") <= 0 Then Exit Sub

                    GridView1.ClearSelection()
                    GridView1.SelectRows(info.RowHandle, info.RowHandle)
                    Call EditItem()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub TourOperator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Administrative.Show()
    End Sub

    Private Sub TourOperator_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class