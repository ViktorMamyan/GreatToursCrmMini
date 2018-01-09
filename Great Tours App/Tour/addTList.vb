Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addTList

    Friend TicketList As New List(Of LTicket)

    Private Sub LoadData()
        GridControl1.BeginUpdate()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim dt As DataTable = ToDataTable(TicketList)

        GridControl1.DataSource = dt

        With GridView1
            .OptionsCustomization.AllowColumnMoving = False
            .OptionsCustomization.AllowGroup = False
            .OptionsSelection.EnableAppearanceFocusedCell = False
            .OptionsSelection.EnableAppearanceFocusedRow = False

            .Columns("ID").Visible = False
            .Columns("FromID").Visible = False
            .Columns("ToID").Visible = False

            .Columns("Ticket").Caption = "Ամրագրման Համար"
            .Columns("PlaceFrom").Caption = "Որտեղից"
            .Columns("PlaceTo").Caption = "Որտեղ"
            .Columns("FlyTime").Caption = "Թռիչքի Ժամ"

        End With

        GridView1.ClearSelection()
        GridControl1.EndUpdate()
    End Sub

    Private Sub txtFromAirport_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFromAirport.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectFromAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFromAirport.Left, txtFromAirport.Top + txtFromAirport.Height))

                    f.ShowDialog()
                    If f.AirportID <> -1 Then
                        If txtFromAirport.Text <> f.Airport Then
                            txtFromAirport.Tag = f.AirportID
                            txtFromAirport.Text = f.Airport
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtFromAirport.Left, txtFromAirport.Top + txtFromAirport.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtToAirport_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtToAirport.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectFromAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtToAirport.Left, txtToAirport.Top + txtToAirport.Height))

                    f.ShowDialog()
                    If f.AirportID <> -1 Then
                        If txtToAirport.Text <> f.Airport Then
                            txtToAirport.Tag = f.AirportID
                            txtToAirport.Text = f.Airport
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addAirport

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtToAirport.Left, txtToAirport.Top + txtToAirport.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtReservNumber.Text.Trim = String.Empty Then Throw New Exception("Ամրագրման համարը գրված չէ")
            If txtFromAirport.Text.Trim = String.Empty Then Throw New Exception("Աէրոպորտը նշված չէ")
            If txtToAirport.Text.Trim = String.Empty Then Throw New Exception("Աէրոպորտը նշված չէ")
            If fDate.Text = String.Empty Then Throw New Exception("Թռիչքի ժամը նշված չէ")

            TicketList.Add(New LTicket With {.ID = Guid.NewGuid(), .Ticket = txtReservNumber.Text.Trim, .PlaceFrom = txtFromAirport.Text,
                                             .FromID = txtFromAirport.Tag, .PlaceTo = txtToAirport.Text, .ToID = txtToAirport.Tag,
                                             .FlyTime = fDate.DateTime})

            Call LoadData()

            txtReservNumber.Text = String.Empty
            txtFromAirport.Text = String.Empty
            txtFromAirport.Tag = String.Empty
            txtToAirport.Text = String.Empty
            txtToAirport.Tag = String.Empty
            fDate.Text = String.Empty

            txtReservNumber.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addTList_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TicketList.Count > 0 Then
            Call LoadData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")

            For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                TicketList.RemoveAll(Function(j) j.ID = GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("ID"))
            Next

            Call LoadData()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class