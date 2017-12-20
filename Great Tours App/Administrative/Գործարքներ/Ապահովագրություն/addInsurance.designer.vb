<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addInsurance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addInsurance))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txPrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.sDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cRet = New DevExpress.XtraEditors.CheckEdit()
        Me.rDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCustomer = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.txPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(253, 198)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Ավելացնել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Գումար"
        '
        'txPrice
        '
        Me.txPrice.EditValue = "0"
        Me.txPrice.Location = New System.Drawing.Point(142, 29)
        Me.txPrice.Name = "txPrice"
        Me.txPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txPrice.Properties.Appearance.Options.UseBackColor = True
        Me.txPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txPrice.Properties.Mask.EditMask = "n0"
        Me.txPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txPrice.Size = New System.Drawing.Size(281, 20)
        Me.txPrice.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 57)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Սկիզբ"
        '
        'sDate
        '
        Me.sDate.EditValue = Nothing
        Me.sDate.Location = New System.Drawing.Point(142, 54)
        Me.sDate.Margin = New System.Windows.Forms.Padding(2)
        Me.sDate.Name = "sDate"
        Me.sDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.sDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sDate.Properties.Appearance.Options.UseBackColor = True
        Me.sDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.sDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.sDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sDate.Size = New System.Drawing.Size(281, 20)
        Me.sDate.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 103)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Հաճախորդ"
        '
        'eDate
        '
        Me.eDate.EditValue = Nothing
        Me.eDate.Location = New System.Drawing.Point(142, 78)
        Me.eDate.Margin = New System.Windows.Forms.Padding(2)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.eDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.eDate.Properties.Appearance.Options.UseBackColor = True
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.eDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.eDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.eDate.Size = New System.Drawing.Size(281, 20)
        Me.eDate.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 81)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "Ավարտ"
        '
        'txtCost
        '
        Me.txtCost.EditValue = "0"
        Me.txtCost.Location = New System.Drawing.Point(142, 130)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCost.Properties.Appearance.Options.UseBackColor = True
        Me.txtCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCost.Properties.Mask.EditMask = "n0"
        Me.txtCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCost.Size = New System.Drawing.Size(281, 20)
        Me.txtCost.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 133)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 33
        Me.LabelControl5.Text = "Ինքնարժեք"
        '
        'cRet
        '
        Me.cRet.Location = New System.Drawing.Point(12, 156)
        Me.cRet.Name = "cRet"
        Me.cRet.Properties.Caption = "Վերադարձվող"
        Me.cRet.Size = New System.Drawing.Size(101, 19)
        Me.cRet.TabIndex = 5
        '
        'rDate
        '
        Me.rDate.EditValue = Nothing
        Me.rDate.Enabled = False
        Me.rDate.Location = New System.Drawing.Point(142, 155)
        Me.rDate.Margin = New System.Windows.Forms.Padding(2)
        Me.rDate.Name = "rDate"
        Me.rDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.rDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rDate.Properties.Appearance.Options.UseBackColor = True
        Me.rDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rDate.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.rDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.rDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.rDate.Size = New System.Drawing.Size(281, 20)
        Me.rDate.TabIndex = 6
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(142, 102)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Նոր", Nothing, Nothing, True)})
        Me.txtCustomer.Properties.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(281, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'addInsurance
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 262)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.rDate)
        Me.Controls.Add(Me.cRet)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.eDate)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txPrice)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addInsurance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Նոր Ապահովագրություն"
        CType(Me.txPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cRet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.ButtonEdit
End Class
