Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class Tour

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetTour()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("TourID").Visible = False
                .Columns("DirectionID").Visible = False
                .Columns("OperatorID").Visible = False
                .Columns("CustomerID").Visible = False

                .Columns("TourName").Caption = "Տուր"
                .Columns("TourStartDate").Caption = "Սկիզբ"
                .Columns("TourEndDate").Caption = "Ավարտ"
                .Columns("DirectionName").Caption = "Ուղղություն"
                .Columns("CustomerName").Caption = "Հաճախորդ"
                .Columns("OperatorName").Caption = "Օպերատոր"
                .Columns("TotalPrice").Caption = "Ընդհանուր Գումար"
                .Columns("ApproximateIncome").Caption = "Մոտավոր Եկամուտ"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("TourName").Summary.ActiveCount = 0 Then
                    Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TourName", "{0}")
                    GridView1.Columns("TourName").Summary.Add(item)
                End If
            End If

            GridView1.ClearSelection()
            GridControl1.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub
    Private Sub Direction_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadData()
    End Sub
    Sub NewItem()
        Dim f As New addTour With {.RefForm = DirectCast(Me, Tour)}
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

            Dim TourID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourID")
            Dim TourName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourName")
            Dim TourStartDate As Date = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourStartDate")
            Dim TourEndDate As Date = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourEndDate")
            Dim DirectionID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("DirectionID")
            Dim DirectionName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("DirectionName")
            Dim OperatorID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorID")
            Dim OperatorName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorName")
            Dim CustomerID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerID")
            Dim CustomerName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerName")
            Dim TotalPrice As Decimal = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TotalPrice")
            Dim ApproximateIncome As Decimal = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ApproximateIncome")

            Dim EE As New editTour With {.RefForm = DirectCast(Me, Tour), .TourID = TourID,
                            .TourName = TourName, .TourStartDate = TourStartDate, .TourEndDate = TourEndDate,
                            .DirectionID = DirectionID, .DirectionName = DirectionName, .OperatorID = OperatorID,
                            .OperatorName = OperatorName, .CustomerID = CustomerID, .Customer = CustomerName,
                            .TotalPrice = TotalPrice, .ApproximateIncome = ApproximateIncome}

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
                    .Add(New SqlParameter("@TourID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("TourID")))
                End With
                ExecToSql("TourDelete", CommandType.StoredProcedure, Parameters.ToArray)

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
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "TourID")) OrElse view.GetRowCellValue(info.RowHandle, "TourID") <= 0 Then Exit Sub

                    GridView1.ClearSelection()
                    GridView1.SelectRows(info.RowHandle, info.RowHandle)
                    Call EditItem()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub Direction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub Direction_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        Call GetTourCustomers()
    End Sub

    Sub GetTourCustomers()
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
            If GridView1.SelectedRowsCount > 1 Then Throw New Exception("Հարկավոր է նշել միայն մեկ տող")

            Dim TourID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourID")
            Dim TourName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourName")

            Dim f As New TourCustomer
            With f
                .TourID = TourID
                .TourName = TourName
                .ShowDialog()
                .Dispose()
            End With

        Catch ex As Exception
            btnEdit.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class