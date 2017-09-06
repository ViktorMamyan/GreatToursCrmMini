<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCustomerDetails
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editCustomerDetails))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassport = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.bDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtViber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSkype = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFacebook = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIMG = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSelectIMG = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCustomer = New DevExpress.XtraEditors.ButtonEdit()
        Me.ckUpdateIMG = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSkype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacebook.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIMG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckUpdateIMG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(317, 382)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEdit.Size = New System.Drawing.Size(212, 52)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Խմբագրել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 40)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Հաճախորդ"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(158, 66)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.Properties.Appearance.Options.UseBackColor = True
        Me.txtFirstName.Size = New System.Drawing.Size(371, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 70)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Անուն"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(158, 96)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.Properties.Appearance.Options.UseBackColor = True
        Me.txtLastName.Size = New System.Drawing.Size(371, 22)
        Me.txtLastName.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 100)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Ազգանուն"
        '
        'txtPassport
        '
        Me.txtPassport.Location = New System.Drawing.Point(158, 126)
        Me.txtPassport.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPassport.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassport.Size = New System.Drawing.Size(371, 22)
        Me.txtPassport.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(15, 130)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Անձնագիր"
        '
        'bDate
        '
        Me.bDate.EditValue = Nothing
        Me.bDate.Location = New System.Drawing.Point(158, 154)
        Me.bDate.Margin = New System.Windows.Forms.Padding(2)
        Me.bDate.Name = "bDate"
        Me.bDate.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.bDate.Properties.Appearance.Options.UseBackColor = True
        Me.bDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.bDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.bDate.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.bDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.bDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.bDate.Size = New System.Drawing.Size(371, 22)
        Me.bDate.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 157)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Ծ. Տարեթիվ"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(158, 182)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAddress.Properties.Appearance.Options.UseBackColor = True
        Me.txtAddress.Size = New System.Drawing.Size(371, 22)
        Me.txtAddress.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(15, 186)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Հասցե"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(158, 212)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.Appearance.Options.UseBackColor = True
        Me.txtTel.Size = New System.Drawing.Size(371, 22)
        Me.txtTel.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(15, 216)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Հեռախոս"
        '
        'txtViber
        '
        Me.txtViber.Location = New System.Drawing.Point(158, 242)
        Me.txtViber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtViber.Name = "txtViber"
        Me.txtViber.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtViber.Properties.Appearance.Options.UseBackColor = True
        Me.txtViber.Size = New System.Drawing.Size(371, 22)
        Me.txtViber.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 246)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Viber"
        '
        'txtSkype
        '
        Me.txtSkype.Location = New System.Drawing.Point(158, 272)
        Me.txtSkype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSkype.Name = "txtSkype"
        Me.txtSkype.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSkype.Properties.Appearance.Options.UseBackColor = True
        Me.txtSkype.Size = New System.Drawing.Size(371, 22)
        Me.txtSkype.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 276)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl9.TabIndex = 36
        Me.LabelControl9.Text = "Skype"
        '
        'txtFacebook
        '
        Me.txtFacebook.Location = New System.Drawing.Point(158, 302)
        Me.txtFacebook.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFacebook.Properties.Appearance.Options.UseBackColor = True
        Me.txtFacebook.Size = New System.Drawing.Size(371, 22)
        Me.txtFacebook.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(15, 306)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "Facebook"
        '
        'txtIMG
        '
        Me.txtIMG.Location = New System.Drawing.Point(158, 332)
        Me.txtIMG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIMG.Name = "txtIMG"
        Me.txtIMG.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIMG.Properties.Appearance.Options.UseBackColor = True
        Me.txtIMG.Size = New System.Drawing.Size(282, 22)
        Me.txtIMG.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(15, 336)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "Նկար"
        '
        'btnSelectIMG
        '
        Me.btnSelectIMG.Appearance.Options.UseTextOptions = True
        Me.btnSelectIMG.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnSelectIMG.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnSelectIMG.Location = New System.Drawing.Point(454, 332)
        Me.btnSelectIMG.Name = "btnSelectIMG"
        Me.btnSelectIMG.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectIMG.TabIndex = 11
        Me.btnSelectIMG.Text = "..."
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(158, 34)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "Նոր", Nothing, Nothing, True)})
        Me.txtCustomer.Properties.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(371, 22)
        Me.txtCustomer.TabIndex = 0
        '
        'ckUpdateIMG
        '
        Me.ckUpdateIMG.Location = New System.Drawing.Point(158, 361)
        Me.ckUpdateIMG.Name = "ckUpdateIMG"
        Me.ckUpdateIMG.Properties.Caption = "Թարմացնել Նկարը"
        Me.ckUpdateIMG.Size = New System.Drawing.Size(148, 20)
        Me.ckUpdateIMG.TabIndex = 41
        '
        'editCustomerDetails
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(572, 461)
        Me.Controls.Add(Me.ckUpdateIMG)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.btnSelectIMG)
        Me.Controls.Add(Me.txtIMG)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtFacebook)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtSkype)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtViber)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.bDate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPassport)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editCustomerDetails"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Խմբագրել Պարամետրը"
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSkype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacebook.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIMG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckUpdateIMG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtViber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSkype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFacebook As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIMG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSelectIMG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ckUpdateIMG As DevExpress.XtraEditors.CheckEdit
End Class
