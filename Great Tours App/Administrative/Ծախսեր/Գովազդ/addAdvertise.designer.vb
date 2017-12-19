<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAdvertise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAdvertise))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.RegDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cTypes = New System.Windows.Forms.ComboBox()
        Me.btnNewTaxType = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditTaxType = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtFee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(253, 136)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Ավելացնել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Վարձավճար"
        '
        'txtFee
        '
        Me.txtFee.EditValue = "0"
        Me.txtFee.Location = New System.Drawing.Point(142, 29)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFee.Properties.Appearance.Options.UseBackColor = True
        Me.txtFee.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFee.Properties.Mask.EditMask = "n0"
        Me.txtFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFee.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFee.Size = New System.Drawing.Size(281, 20)
        Me.txtFee.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 58)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Ամսաթիվ"
        '
        'RegDate
        '
        Me.RegDate.EditValue = Nothing
        Me.RegDate.Location = New System.Drawing.Point(142, 55)
        Me.RegDate.Margin = New System.Windows.Forms.Padding(2)
        Me.RegDate.Name = "RegDate"
        Me.RegDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RegDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RegDate.Properties.Appearance.Options.UseBackColor = True
        Me.RegDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RegDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RegDate.Properties.Mask.EditMask = "MM.yyyy"
        Me.RegDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RegDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.RegDate.Size = New System.Drawing.Size(281, 20)
        Me.RegDate.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 83)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Ծախսի Տեսակ"
        '
        'cTypes
        '
        Me.cTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTypes.FormattingEnabled = True
        Me.cTypes.Location = New System.Drawing.Point(142, 83)
        Me.cTypes.Name = "cTypes"
        Me.cTypes.Size = New System.Drawing.Size(227, 21)
        Me.cTypes.TabIndex = 2
        '
        'btnNewTaxType
        '
        Me.btnNewTaxType.Location = New System.Drawing.Point(402, 81)
        Me.btnNewTaxType.Name = "btnNewTaxType"
        Me.btnNewTaxType.Size = New System.Drawing.Size(21, 23)
        Me.btnNewTaxType.TabIndex = 28
        Me.btnNewTaxType.TabStop = False
        Me.btnNewTaxType.Text = "+"
        '
        'btnEditTaxType
        '
        Me.btnEditTaxType.Location = New System.Drawing.Point(375, 81)
        Me.btnEditTaxType.Name = "btnEditTaxType"
        Me.btnEditTaxType.Size = New System.Drawing.Size(21, 23)
        Me.btnEditTaxType.TabIndex = 29
        Me.btnEditTaxType.TabStop = False
        Me.btnEditTaxType.Text = "..."
        '
        'addAdvertise
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 190)
        Me.Controls.Add(Me.btnEditTaxType)
        Me.Controls.Add(Me.btnNewTaxType)
        Me.Controls.Add(Me.cTypes)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RegDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAdvertise"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Նոր Գովազդային Ծախս"
        CType(Me.txtFee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cTypes As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewTaxType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTaxType As DevExpress.XtraEditors.SimpleButton
End Class
