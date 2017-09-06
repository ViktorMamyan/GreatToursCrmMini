Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class addCustomerDetails

    Friend RefForm As New CustomerDetails
    Dim CustomerDetailsID As Int32 = 0

    Private Sub txtCustomer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCustomer.ButtonClick
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtCustomer.Text.Trim = String.Empty Then Throw New Exception("Հաճախորդը գրված չէ")
            If txtFirstName.Text.Trim = String.Empty Then Throw New Exception("Անունը նշված չէ")
            If txtLastName.Text.Trim = String.Empty Then Throw New Exception("Ազգանունը նշված չէ")
            If txtIMG.Text.Trim <> String.Empty Then If IO.File.Exists(txtIMG.Text.Trim) = False Then Throw New Exception("Նկարի ֆայլը գոյություն չունի")

            Dim iImage As Image
            Dim imgByteArray As Byte() = Nothing

            If txtIMG.Text.Trim <> String.Empty Then
                iImage = Image.FromFile(txtIMG.Text.Trim)
                Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
                iImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                imgByteArray = imgMemoryStream.GetBuffer()
            End If

            Dim Parameters As New List(Of SqlParameter)
            With Parameters
                .Add(New SqlParameter("@CustomerID", txtCustomer.Tag.ToString))
                .Add(New SqlParameter("@FirstName", txtFirstName.Text.Trim))
                .Add(New SqlParameter("@LastName", txtLastName.Text.Trim))
                .Add(New SqlParameter("@Passport", IIf(txtPassport.Text.Trim = String.Empty, DBNull.Value, txtPassport.Text.Trim)))
                .Add(New SqlParameter("@BirthDate", IIf(bDate.Text.Trim = String.Empty, DBNull.Value, bDate.DateTime)))
                .Add(New SqlParameter("@Address", IIf(txtAddress.Text.Trim = String.Empty, DBNull.Value, txtAddress.Text.Trim)))
                If iImage Is Nothing Then
                    Dim photoParam As New SqlClient.SqlParameter("@IMG", SqlDbType.VarBinary)
                    photoParam.Value = DBNull.Value
                    .Add(photoParam)
                Else
                    .Add(New SqlParameter("@IMG", imgByteArray))
                End If
                .Add(New SqlParameter("@Tel", IIf(txtTel.Text.Trim = String.Empty, DBNull.Value, txtTel.Text.Trim)))
                .Add(New SqlParameter("@Viber", IIf(txtViber.Text.Trim = String.Empty, DBNull.Value, txtViber.Text.Trim)))
                .Add(New SqlParameter("@Skype", IIf(txtSkype.Text.Trim = String.Empty, DBNull.Value, txtSkype.Text.Trim)))
                .Add(New SqlParameter("@Facebook", IIf(txtFacebook.Text.Trim = String.Empty, DBNull.Value, txtFacebook.Text.Trim)))
            End With
            ExecToSql("CustomerDetailsAdd", CommandType.StoredProcedure, Parameters.ToArray)

            CustomerDetailsID = Query_Scalar("SELECT dbo.GetLasCustomerDetailsID()")

            txtCustomer.Text = String.Empty
            txtFirstName.Text = String.Empty
            txtLastName.Text = String.Empty
            txtPassport.Text = String.Empty
            bDate.Text = String.Empty
            txtAddress.Text = String.Empty
            txtTel.Text = String.Empty
            txtViber.Text = String.Empty
            txtSkype.Text = String.Empty
            txtFacebook.Text = String.Empty
            txtIMG.Text = String.Empty

            RefForm.LoadData()
            If CustomerDetailsID <> 0 Then
                Dim rowHandle As Integer = RefForm.GridView1.LocateByValue("CustomerDetailsID", CustomerDetailsID)
                If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    RefForm.GridView1.FocusedRowHandle = rowHandle
                End If
            End If

            CustomerDetailsID = 0
            txtCustomer.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Private Sub btnSelectIMG_Click(sender As Object, e As EventArgs) Handles btnSelectIMG.Click
        Try
            Dim ofd As New OpenFileDialog
            With ofd
                .Multiselect = False
                .Title = "Ընտրեք Նկարը"
                .Filter = "Նկարներ|*.JPG;*.JPEG;*.BMP;*.PNG;*.GIF"
                .ShowDialog()
                If .FileName <> String.Empty Then txtIMG.Text = .FileName
            End With

        Catch ex As Exception
            txtIMG.Text = String.Empty
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

End Class