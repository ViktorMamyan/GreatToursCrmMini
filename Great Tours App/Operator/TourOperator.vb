Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class TourOperator

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetTourOperator()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("TourOperatorID").Visible = False

                .Columns("OperatorName").Caption = "Օպերատոր"
                .Columns("Director").Caption = "Տնօրեն"
                .Columns("OperatorLocation").Caption = "Հասցե"
                .Columns("RequestByURL").Caption = "Հարցումը Հղումով"
                .Columns("RequestURL").Caption = "Հարցման Հղում"
                .Columns("website").Caption = "Կայք"
                .Columns("Tel").Caption = "Հեռախոս"
                .Columns("skype").Caption = "Skype"
                .Columns("facebook").Caption = "Facebook"
                .Columns("email").Caption = "Email"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("OperatorName").Summary.ActiveCount = 0 Then
                    Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OperatorName", "{0}")
                    GridView1.Columns("OperatorName").Summary.Add(item)
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
        Dim f As New addTourOperator With {.RefForm = DirectCast(Me, TourOperator)}
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

            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("TourOperatorID")
            Dim OperatorName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorName")
            Dim Director As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Director")
            Dim OperatorLocation As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("OperatorLocation")
            Dim RequestByURL As Boolean = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("RequestByURL")
            Dim RequestURL As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("RequestURL")
            Dim website As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("website")
            Dim Tel As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Tel")
            Dim skype As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("skype")
            Dim facebook As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("facebook")
            Dim email As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("email")

            Dim Login As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Login")
            Dim Password As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Password")
            Dim AgentID As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("AgentID")

            Dim EE As New editTourOperator With {.RefForm = DirectCast(Me, TourOperator), .ID = ID,
                .OperatorName = OperatorName, .Director = Director, .OperatorLocation = OperatorLocation, .RequestByURL = RequestByURL,
                .RequestURL = RequestURL, .website = website, .Tel = Tel, .skype = skype, .facebook = facebook, .email = email,
                .Login = Login, .Password = Password, .AgentID = AgentID}

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
                    .Add(New SqlParameter("@TourOperatorID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("TourOperatorID")))
                End With
                ExecToSql("TourOperatorDelete", CommandType.StoredProcedure, Parameters.ToArray)

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
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "TourOperatorID")) OrElse view.GetRowCellValue(info.RowHandle, "TourOperatorID") <= 0 Then Exit Sub

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
        MainMenu.Show()
    End Sub

    Private Sub TourOperator_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class