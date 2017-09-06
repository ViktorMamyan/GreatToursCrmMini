Imports DevExpress.XtraGrid

Public Class selectDirection

    Public Property DirectionID As Integer = -1
    Public Property DirectionName As String = String.Empty

    Private Sub LoadData()
        Try
            Dim dt As DataTable = QueryToSqlServer("SELECT DirectionID,DirectionName FROM GetDirection()", CommandType.Text)

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

                For i As Integer = 0 To GridView1.Columns.Count - 1
                    .Columns(i).OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
                Next

            End With

            GridView1.ClearSelection()
            GridControl1.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub
    Private Sub WinProdType_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1_DoubleClick(GridView1, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub WinProdType_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadData()
    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            If IsNothing(GridView1.GetFocusedDataRow) Then Exit Sub
            If GridView1.SelectedRowsCount = 0 Then Exit Sub
            If GridView1.FocusedRowHandle < 0 Then Exit Sub

            DirectionID = GridView1.GetFocusedDataRow.Item("DirectionID")
            DirectionName = GridView1.GetFocusedDataRow.Item("DirectionName")

            Me.Close()
        Catch ex As Exception

        End Try
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

End Class