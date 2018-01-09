Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addHList

    Friend HotelList As New List(Of LHotel)

    Private Sub LoadData()
        GridControl1.BeginUpdate()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim dt As DataTable = ToDataTable(HotelList)

        GridControl1.DataSource = dt

        With GridView1
            .OptionsCustomization.AllowColumnMoving = False
            .OptionsCustomization.AllowGroup = False
            .OptionsSelection.EnableAppearanceFocusedCell = False
            .OptionsSelection.EnableAppearanceFocusedRow = False

            .Columns("ID").Visible = False

            .Columns("Hotel").Caption = "Հյուրանոց"
            .Columns("StartDate").Caption = "Սկիզբ"
            .Columns("EndDate").Caption = "Ավարտ"

        End With

        GridView1.ClearSelection()
        GridControl1.EndUpdate()
    End Sub

    Private Sub txtHotels_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtHotels.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectHotel

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtHotels.Left, txtHotels.Top + txtHotels.Height))

                    f.ShowDialog()
                    If f.HotelID <> -1 Then
                        If txtHotels.Text <> f.HotelName Then
                            txtHotels.Tag = f.HotelID
                            txtHotels.Text = f.HotelName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addHotel

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtHotels.Left, txtHotels.Top + txtHotels.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addHotelBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sDate.DateTime = Now
        eDate.DateTime = Now

        If HotelList.Count > 0 Then
            Call LoadData()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtHotels.Text.Trim = String.Empty Then Throw New Exception("Հյուրանոցի անվանումը գրված չէ")
            If sDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")
            If eDate.Text = String.Empty Then Throw New Exception("Ամսաթիվը նշված չէ")

            HotelList.Add(New LHotel With {.ID = Guid.NewGuid(), .Hotel = txtHotels.Text, .StartDate = sDate.DateTime, .EndDate = eDate.DateTime})

            Call LoadData()

            txtHotels.Text = String.Empty
            txtHotels.Tag = String.Empty
            sDate.DateTime = Now
            eDate.DateTime = Now

            txtHotels.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then Throw New Exception("Նշված տողեր չկան")

            For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                HotelList.RemoveAll(Function(j) j.ID = GridView1.GetDataRow(GridView1.GetSelectedRows()(i)).Item("ID"))
            Next

            Call LoadData()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class