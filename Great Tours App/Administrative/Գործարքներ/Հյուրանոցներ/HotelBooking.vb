Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class HotelBooking

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetHotelBooking()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("HotelBookID").Visible = False
                .Columns("CustomerID").Visible = False
                .Columns("FoodTypeID").Visible = False
                .Columns("OperatorID").Visible = False

                .Columns("CreationDate").Caption = "Ավելացման Ամսաթիվ"
                .Columns("HotelName").Caption = "Հյուրանոց"
                .Columns("StartDate").Caption = "Սկիզբ"
                .Columns("EndDate").Caption = "Ավարտ"
                .Columns("Price").Caption = "Գումար"
                .Columns("Cost").Caption = "Ինքնարժեք"
                .Columns("CustomerName").Caption = "Հաճախորդ"
                .Columns("AdultCount").Caption = "Մեծերի Քանակ"
                .Columns("ChildCount").Caption = "Երեխաների Քանակ"
                .Columns("BabyCount").Caption = "Նորածինների Քանակ"
                .Columns("ChildYearsComment").Caption = "Տարիքր Մեկնաբանություն"
                .Columns("FoodName").Caption = "Սննդի Տեսակ"
                .Columns("Transfer").Caption = "Փոխադրում"
                .Columns("PrePayPrice").Caption = "Կանխավճար"
                .Columns("NextPayDate").Caption = "Հաջորդ Վճարի Ամսաթիվ"
                .Columns("OperatorName").Caption = "Օպերատոր"
                .Columns("PaymaetDeathLine").Caption = "Վերջնավճար"
                .Columns("IsTotalyPayed").Caption = "Ամբողջությամբ Վճարված"

                .Columns("Price").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Price").DisplayFormat.FormatString = "n2"

                .Columns("Cost").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Cost").DisplayFormat.FormatString = "n2"

                .Columns("PrePayPrice").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("PrePayPrice").DisplayFormat.FormatString = "n2"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("CreationDate").Summary.ActiveCount = 0 Then
                    GridView1.Columns("CreationDate").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CreationDate", "Քանակ` {0}"))
                    GridView1.Columns("Price").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "Գումար` {0:n2}"))
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
        Dim f As New addHotelBooking With {.RefForm = DirectCast(Me, HotelBooking)}
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

            Dim HotelBookID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("HotelBookID")
            Dim CustomerID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerID")

            Dim FoodTypeID As Integer?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("FoodTypeID")) Then FoodTypeID = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("FoodTypeID")

            Dim OperatorID As Integer?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorID")) Then OperatorID = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorID")

            Dim HotelName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("HotelName")
            Dim StartDate As Date = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("StartDate")
            Dim EndDate As Date = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("EndDate")
            Dim Price As Decimal = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Price")

            Dim Cost As Decimal?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Cost")) Then Cost = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Cost")

            Dim CustomerName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerName")
            Dim AdultCount As Byte = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("AdultCount")

            Dim ChildCount As Byte?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ChildCount")) Then ChildCount = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ChildCount")

            Dim BabyCount As Byte?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BabyCount")) Then BabyCount = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BabyCount")

            Dim ChildYearsComment As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ChildYearsComment")) Then ChildYearsComment = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ChildYearsComment")

            Dim FoodName As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("FoodName")) Then FoodName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("FoodName")

            Dim Transfer As Boolean = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Transfer")

            Dim PrePayPrice As Decimal?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("PrePayPrice")) Then PrePayPrice = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("PrePayPrice")

            Dim NextPayDate As Date?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("NextPayDate")) Then NextPayDate = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("NextPayDate")

            Dim OperatorName As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorName")) Then OperatorName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorName")

            Dim PaymaetDeathLine As Date?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("PaymaetDeathLine")) Then PaymaetDeathLine = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("PaymaetDeathLine")

            Dim IsTotalyPayed As Boolean = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("IsTotalyPayed")

            Dim EE As New editHotelBooking With {.RefForm = DirectCast(Me, HotelBooking), .HotelBookID = HotelBookID, .CustomerID = CustomerID,
                        .FoodTypeID = FoodTypeID, .OperatorID = OperatorID, .HotelName = HotelName, .StartDate = StartDate, .EndDate = EndDate,
                        .Price = Price, .Cost = Cost, .CustomerName = CustomerName, .AdultCount = AdultCount, .ChildCount = ChildCount,
                        .BabyCount = BabyCount, .ChildYearsComment = ChildYearsComment, .FoodName = FoodName, .Transfer = Transfer, .PrePayPrice = PrePayPrice,
                        .NextPayDate = NextPayDate, .OperatorName = OperatorName, .PaymaetDeathLine = PaymaetDeathLine, .IsTotalyPayed = IsTotalyPayed}

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
                    .Add(New SqlParameter("@HotelBookID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("HotelBookID")))
                End With
                ExecToSql("HotelBookingDelete", CommandType.StoredProcedure, Parameters.ToArray)

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
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "HotelBookID")) OrElse view.GetRowCellValue(info.RowHandle, "HotelBookID") <= 0 Then Exit Sub

                    GridView1.ClearSelection()
                    GridView1.SelectRows(info.RowHandle, info.RowHandle)
                    Call EditItem()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub HotelBooking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Administrative.Show()
    End Sub

    Private Sub HotelBooking_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class