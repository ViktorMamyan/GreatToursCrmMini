Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class CustomerDetails

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetCustomerDetails()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("CustomerDetailsID").Visible = False
                .Columns("CustomerID").Visible = False

                .Columns("CustomerName").Caption = "Հաճախորդ"
                .Columns("FirstName").Caption = "Անուն"
                .Columns("LastName").Caption = "Ազգանուն"
                .Columns("Passport").Caption = "Անձնագիր"
                .Columns("BirthDate").Caption = "Ծննդյան Տարեթիվ"
                .Columns("Address").Caption = "Հասցե"
                .Columns("Tel").Caption = "Հեռախոս"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("CustomerName").Summary.ActiveCount = 0 Then
                    Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerName", "{0}")
                    GridView1.Columns("CustomerName").Summary.Add(item)
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
        Dim f As New addCustomerDetails With {.RefForm = DirectCast(Me, CustomerDetails)}
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
            Dim CustomerDetailsID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerDetailsID")
            Dim CustomerID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerID")
            Dim Customer As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerName")
            Dim FirstName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("FirstName")
            Dim LastName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("LastName")

            Dim Passport As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Passport")) Then
                Passport = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Passport")
            End If

            Dim BirthDate As Date = Date.MinValue
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BirthDate")) Then
                BirthDate = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BirthDate")
            End If

            Dim Address As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Address")) Then
                Address = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Address")
            End If

            Dim Tel As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Tel")) Then
                Tel = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Tel")
            End If

            Dim Viber As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Viber")) Then
                Viber = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Viber")
            End If

            Dim Skype As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Skype")) Then
                Skype = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Skype")
            End If

            Dim Facebook As String = String.Empty
            If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Facebook")) Then
                Facebook = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Facebook")
            End If

            Dim EE As New editCustomerDetails With {.RefForm = DirectCast(Me, CustomerDetails),
                .CustomerDetailsID = CustomerDetailsID, .CustomerID = CustomerID, .Customer = Customer, .FirstName = FirstName,
                .LastName = LastName, .Passport = Passport, .BirthDate = BirthDate, .Address = Address, .Tel = Tel,
                .Viber = Viber, .Skype = Skype, .Facebook = Facebook}

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
                    .Add(New SqlParameter("@CustomerDetailsID", GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("CustomerDetailsID")))
                End With
                ExecToSql("CustomerDetailsDelete", CommandType.StoredProcedure, Parameters.ToArray)

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
                    If IsDBNull(view.GetRowCellValue(info.RowHandle, "CustomerDetailsID")) OrElse view.GetRowCellValue(info.RowHandle, "CustomerDetailsID") <= 0 Then Exit Sub

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

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
            If GridView1.SelectedRowsCount > 1 Then Throw New Exception("Հարկավոր է նշել միայն մեկ տող")
            Dim CustomerDetailsID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CustomerDetailsID")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@CustomerDetailsID", CustomerDetailsID))
            End With

            Dim dt As DataTable = QueryToSqlServer("SELECT IMG FROM GetCustomerDetailsIMG(@CustomerDetailsID)", CommandType.Text, Parameters.ToArray)

            If dt.Rows.Count = 0 Then Throw New Exception("Նկարը բացակայում է")

            If Not IsDBNull(dt.Rows(0)("IMG")) Then
                Dim IMG As Image

                Dim bits As Byte() = CType(dt.Rows(0)("IMG"), Byte())
                Dim memoryBits As New IO.MemoryStream(bits)
                Dim b As New Bitmap(memoryBits)
                IMG = CType(b, Image)

                Dim f As New showIMG
                f.PictureBox1.Image = IMG
                f.ShowDialog()
                f.Dispose()
            Else
                Throw New Exception("Նկարը բացակայում է")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class