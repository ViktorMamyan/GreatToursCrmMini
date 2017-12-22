Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class HotelsList

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetHotels()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("HotelID").Visible = False
                .Columns("CountryID").Visible = False
                .Columns("HotelTypeID").Visible = False

                .Columns("HotelName").Caption = "Հյուրանոց"
                .Columns("Country").Caption = "Երկիր"
                .Columns("Region").Caption = "Տարածաշրջան"
                .Columns("Stars").Caption = "Աստղ"
                .Columns("Type").Caption = "Տեսակ"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("HotelName").Summary.ActiveCount = 0 Then
                    GridView1.Columns("HotelName").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "HotelName", "Քանակ` {0}"))
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
        Dim f As New addHotel With {.RefForm = DirectCast(Me, HotelsList)}
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

            Dim HotelID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("HotelID")
            Dim HotelName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("HotelName")
            Dim sRegion As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Region")
            Dim Country As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Country")
            Dim Type As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Type")
            Dim HotelTypeID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("HotelTypeID")
            Dim CountryID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CountryID")

            Dim Stars As Byte?
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Stars")) Then Stars = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Stars")

            Dim EE As New editHotel With {.RefForm = DirectCast(Me, HotelsList), .HotelID = HotelID, .HotelName = HotelName, .sRegion = sRegion,
                                          .Country = Country, .Type = Type, .HotelTypeID = HotelTypeID, .CountryID = CountryID, .Stars = Stars}

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
                    .Add(New SqlParameter("@HotelID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("HotelID")))
                End With
                ExecToSql("HotelsDelete", CommandType.StoredProcedure, Parameters.ToArray)

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
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "HotelID")) OrElse view.GetRowCellValue(info.RowHandle, "HotelID") <= 0 Then Exit Sub

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
        MainMenu.Show()
    End Sub

    Private Sub HotelBooking_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class