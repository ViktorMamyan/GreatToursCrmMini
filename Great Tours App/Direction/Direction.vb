Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class Direction

    Friend Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT * FROM GetDirection()", CommandType.Text)

            GridControl1.BeginUpdate()
            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            With GridView1
                .OptionsCustomization.AllowColumnMoving = False
                .OptionsCustomization.AllowGroup = False
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsSelection.EnableAppearanceFocusedRow = False

                .Columns("DirectionID").Visible = False

                .Columns("DirectionName").Caption = "Ուղղություն"
                .Columns("SinlgeDirection").Caption = "Մեկ Ուղղությամբ"
                .Columns("VisaDetails").Caption = "Վիզայի Պարամետրեր"

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            If GridView1.RowCount > 0 Then
                If GridView1.Columns("DirectionName").Summary.ActiveCount = 0 Then
                    Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DirectionName", "{0}")
                    GridView1.Columns("DirectionName").Summary.Add(item)
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
        'Dim f As New BuyerAdd With {.RefForm = DirectCast(Me, Direction)}
        'f.ShowDialog()
        'f.Dispose()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call NewItem()
        GridView1.Focus()
    End Sub
    Sub EditItem()
        'Try
        '    If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
        '    If GridView1.SelectedRowsCount > 1 Then Throw New Exception("Հարկավոր է նշել միայն մեկ տող")

        '    Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("ID")
        '    Dim Code As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Code")
        '    Dim DocDate As Date = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("DocDate")
        '    Dim GroupID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("GroupID")
        '    Dim GroupCode As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("GroupCode")
        '    Dim GroupName As String = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("GroupName")
        '    Dim IsLegalPerson As Boolean = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("IsLegalPerson")

        '    Dim hvhh As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("hvhh")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("hvhh") <> String.Empty Then
        '        hvhh = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("hvhh")
        '    End If
        '    Dim CompanyName As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyName")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyName") <> String.Empty Then
        '        CompanyName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyName")
        '    End If
        '    Dim CompanyFullName As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyFullName")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyFullName") <> String.Empty Then
        '        CompanyFullName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyFullName")
        '    End If
        '    Dim LegalAddress As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("LegalAddress")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("LegalAddress") <> String.Empty Then
        '        LegalAddress = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("LegalAddress")
        '    End If
        '    Dim WorkAddress As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("WorkAddress")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("WorkAddress") <> String.Empty Then
        '        WorkAddress = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("WorkAddress")
        '    End If
        '    Dim Director As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Director")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Director") <> String.Empty Then
        '        Director = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("Director")
        '    End If
        '    Dim CompanyTelephone As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyTelephone")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyTelephone") <> String.Empty Then
        '        CompanyTelephone = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyTelephone")
        '    End If
        '    Dim CompanyEmail As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyEmail")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyEmail") <> String.Empty Then
        '        CompanyEmail = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("CompanyEmail")
        '    End If
        '    Dim BuyerName As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerName")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerName") <> String.Empty Then
        '        BuyerName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerName")
        '    End If
        '    Dim BuyerLastName As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerLastName")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerLastName") <> String.Empty Then
        '        BuyerLastName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerLastName")
        '    End If
        '    Dim BuyerMiddleName As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerMiddleName")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerMiddleName") <> String.Empty Then
        '        BuyerMiddleName = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerMiddleName")
        '    End If
        '    Dim BuyerGender As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerGender")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerGender") <> String.Empty Then
        '        BuyerGender = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerGender")
        '    End If
        '    Dim BuyerBirtDate As Date
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerBirtDate")) Then
        '        BuyerBirtDate = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerBirtDate")
        '    End If
        '    Dim strBuyerBirtDate As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("strBuyerBirtDate")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("strBuyerBirtDate") <> String.Empty Then
        '        strBuyerBirtDate = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("strBuyerBirtDate")
        '    End If
        '    Dim BuyerAddress As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerAddress")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerAddress") <> String.Empty Then
        '        BuyerAddress = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerAddress")
        '    End If
        '    Dim BuyerTel As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerTel")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerTel") <> String.Empty Then
        '        BuyerTel = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerTel")
        '    End If
        '    Dim BuyerEmail As String = String.Empty
        '    If Not IsDBNull(GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerEmail")) AndAlso GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerEmail") <> String.Empty Then
        '        BuyerEmail = GridView1.GetDataRow(GridView1.GetSelectedRows()(0)).Item("BuyerEmail")
        '    End If

        '    Dim EE As New BuyerEdit With {.RefForm = DirectCast(Me, Direction), .ID = ID, .Code = Code, .DocDate = DocDate, .GroupID = GroupID, .GroupCode = GroupCode,
        '                                  .GroupName = GroupName, .IsLegalPerson = IsLegalPerson, .hvhh = hvhh, .strCompanyName = CompanyName, .CompanyFullName = CompanyFullName,
        '                                  .LegalAddress = LegalAddress, .WorkAddress = WorkAddress, .Director = Director, .CompanyTelephone = CompanyTelephone,
        '                                  .CompanyEmail = CompanyEmail, .BuyerName = BuyerName, .BuyerLastName = BuyerLastName, .BuyerMiddleName = BuyerMiddleName,
        '                                  .BuyerGender = BuyerGender, .BuyerBirtDate = BuyerBirtDate, .strBuyerBirtDate = strBuyerBirtDate,
        '                                  .BuyerAddress = BuyerAddress, .BuyerTel = BuyerTel, .BuyerEmail = BuyerEmail}
        '    EE.ShowDialog()
        '    EE.Dispose()

        'Catch enf As ServiceModel.EndpointNotFoundException
        '    OKOnly("Սերվիսը անհասանելի է", iMessageImage.IsError, AppTitle)
        'Catch ex As Exception
        '    OKOnly(ex.Message, iMessageImage.IsError, AppTitle)
        'End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call EditItem()
        GridView1.Focus()
    End Sub
    Sub DeleteItem()
        'Dim c As New bsManager.IbsServiceClient
        'Try
        '    If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")
        '    If Question("Ցանկանու՞մ եք ջնջել գրանցումը", iMessageImage.IsQuestion, AppTitle) <> DialogResult.OK Then Exit Sub

        '    c.Open()

        '    Dim errCount As Integer = 0
        '    For i As Integer = 0 To GridView1.SelectedRowsCount - 1
        '        If c.DeleteBuyer(GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("ID")) = False Then errCount += 1
        '    Next

        '    c.Close()

        '    If errCount > 0 Then OKOnly("Գործողության կատարման ժամանակ սխալներ են եղել:" & vbCrLf & vbCrLf & "Հնարավոր է առկա են փոխկապակցված տվյալներ", iMessageImage.IsExclamation, AppTitle)

        '    Call LoadData()

        'Catch enf As ServiceModel.EndpointNotFoundException
        '    OKOnly("Սերվիսը անհասանելի է", iMessageImage.IsError, AppTitle)
        'Catch ex As Exception
        '    OKOnly(ex.Message, iMessageImage.IsError, AppTitle)
        'Finally
        '    If Not IsNothing(c) Then c = Nothing
        'End Try
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
        'Try
        '    Dim info As GridHitInfo = view.CalcHitInfo(pt)
        '    If info.InRow OrElse info.InRowCell Then
        '        If info.Column Is Nothing Then
        '            'N/A
        '        Else
        '            If IsDBNull(view.GetRowCellValue(info.RowHandle, "ID")) OrElse view.GetRowCellValue(info.RowHandle, "ID") <= 0 Then Exit Sub

        '            GridView1.ClearSelection()
        '            GridView1.SelectRows(info.RowHandle, info.RowHandle)
        '            Call EditItem()

        '        End If
        '    End If
        'Catch ex As Exception
        '    OKOnly(ex.Message, iMessageImage.IsError, AppTitle)
        'End Try
    End Sub

    Private Sub Direction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

End Class