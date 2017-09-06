Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class editCard

    Friend RefForm As New Card

    Friend CardID As Int32 = 0
    Friend Card As String = String.Empty
    Friend CustomerName As String = String.Empty
    Friend CustomerID As Integer = 0
    Friend CreateDate As Date
    Friend IsActive As Boolean

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtCard.Text.Trim = String.Empty Then Throw New Exception("Քարտը գրված չէ")
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդի անունը գրված չէ")

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@CardID", CardID))
                .Add(New SqlParameter("@Card", txtCard.Text.Trim))
                .Add(New SqlParameter("@CustomerID", txtCustomer.Tag))
                .Add(New SqlParameter("@CreateDate", RegDate.DateTime))
                .Add(New SqlParameter("@IsActive", ckIsActive.Checked))
            End With
            ExecToSql("BonuseCardEdit", CommandType.StoredProcedure, Parameters.ToArray)

            btnEdit.Enabled = False

            RefForm.LoadData()
            If CardID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("CardID", CardID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub txtCustomer_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCustomer.ButtonClick
        Try
            Dim Editor As ButtonEdit = CType(sender, ButtonEdit)
            Dim Button As EditorButton = e.Button
            Select Case Editor.Properties.Buttons.IndexOf(e.Button).ToString()
                Case 0
                    Dim f As New selectCustomer

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCustomer.Left, txtCustomer.Top + txtCustomer.Height))

                    f.ShowDialog()
                    If f.CustomerID <> -1 Then
                        If txtCustomer.Text <> f.CustomerName Then
                            txtCustomer.Tag = f.CustomerID
                            txtCustomer.Text = f.CustomerName
                        End If
                    End If
                    f.Dispose()
                Case 1
                    Dim f As New addCustomer

                    f.StartPosition = FormStartPosition.Manual
                    f.Location = Me.PointToScreen(New Point(txtCustomer.Left, txtCustomer.Top + txtCustomer.Height))

                    f.ShowDialog()
                    f.Dispose()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CardID > 0 Then
            txtCard.Text = Card
            txtCustomer.Text = CustomerName
            txtCustomer.Tag = CustomerID
            RegDate.DateTime = CreateDate
            ckIsActive.Checked = IsActive
        Else
            btnEdit.Enabled = False
        End If
    End Sub

End Class