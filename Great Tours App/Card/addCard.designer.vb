<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addCard))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCard = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.RegDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCustomer = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ckIsActive = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckIsActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(254, 136)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Ավելացնել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Քարտ"
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(142, 29)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCard.Properties.Appearance.Options.UseBackColor = True
        Me.txtCard.Size = New System.Drawing.Size(281, 20)
        Me.txtCard.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 74)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Գրանցման Ամսաթիվ"
        '
        'RegDate
        '
        Me.RegDate.EditValue = Nothing
        Me.RegDate.Location = New System.Drawing.Point(142, 72)
        Me.RegDate.Margin = New System.Windows.Forms.Padding(2)
        Me.RegDate.Name = "RegDate"
        Me.RegDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RegDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RegDate.Properties.Appearance.Options.UseBackColor = True
        Me.RegDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RegDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RegDate.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.RegDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RegDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.RegDate.Size = New System.Drawing.Size(281, 20)
        Me.RegDate.TabIndex = 2
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(142, 50)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Նոր", Nothing, Nothing, True)})
        Me.txtCustomer.Properties.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(281, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 53)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Հաճախորդ"
        '
        'ckIsActive
        '
        Me.ckIsActive.EditValue = True
        Me.ckIsActive.Location = New System.Drawing.Point(142, 101)
        Me.ckIsActive.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ckIsActive.Name = "ckIsActive"
        Me.ckIsActive.Properties.Caption = "Ակտիվ Քարտ"
        Me.ckIsActive.Size = New System.Drawing.Size(126, 19)
        Me.ckIsActive.TabIndex = 3
        '
        'addCard
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 208)
        Me.Controls.Add(Me.ckIsActive)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.RegDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addCard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Նոր) Քարտ"
        CType(Me.txtCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckIsActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckIsActive As DevExpress.XtraEditors.CheckEdit
End Class
