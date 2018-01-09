<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addTList
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addTList))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.fDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtReservNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtFromAirport = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtToAirport = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.fDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReservNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromAirport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToAirport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Ամրագրման Համար"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Որտեղից"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 80)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Որտեղ"
        '
        'fDate
        '
        Me.fDate.EditValue = Nothing
        Me.fDate.Location = New System.Drawing.Point(126, 102)
        Me.fDate.Margin = New System.Windows.Forms.Padding(2)
        Me.fDate.Name = "fDate"
        Me.fDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fDate.Properties.Appearance.Options.UseBackColor = True
        Me.fDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDate.Properties.Mask.EditMask = "f"
        Me.fDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.fDate.Size = New System.Drawing.Size(297, 20)
        Me.fDate.TabIndex = 3
        '
        'txtReservNumber
        '
        Me.txtReservNumber.Location = New System.Drawing.Point(126, 29)
        Me.txtReservNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReservNumber.Name = "txtReservNumber"
        Me.txtReservNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReservNumber.Properties.Appearance.Options.UseBackColor = True
        Me.txtReservNumber.Size = New System.Drawing.Size(297, 20)
        Me.txtReservNumber.TabIndex = 0
        '
        'txtFromAirport
        '
        Me.txtFromAirport.Location = New System.Drawing.Point(126, 53)
        Me.txtFromAirport.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFromAirport.Name = "txtFromAirport"
        Me.txtFromAirport.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFromAirport.Properties.Appearance.Options.UseBackColor = True
        Me.txtFromAirport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Նոր", Nothing, Nothing, True)})
        Me.txtFromAirport.Properties.ReadOnly = True
        Me.txtFromAirport.Size = New System.Drawing.Size(297, 20)
        Me.txtFromAirport.TabIndex = 1
        '
        'txtToAirport
        '
        Me.txtToAirport.Location = New System.Drawing.Point(126, 78)
        Me.txtToAirport.Margin = New System.Windows.Forms.Padding(2)
        Me.txtToAirport.Name = "txtToAirport"
        Me.txtToAirport.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtToAirport.Properties.Appearance.Options.UseBackColor = True
        Me.txtToAirport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "Նոր", Nothing, Nothing, True)})
        Me.txtToAirport.Properties.ReadOnly = True
        Me.txtToAirport.Size = New System.Drawing.Size(297, 20)
        Me.txtToAirport.TabIndex = 2
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(12, 104)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl17.TabIndex = 59
        Me.LabelControl17.Text = "Թռիչքի Ժամ"
        '
        'btnDelete
        '
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(191, 139)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDelete.Size = New System.Drawing.Size(170, 42)
        Me.btnDelete.TabIndex = 62
        Me.btnDelete.Text = "Ջնջել"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 196)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(589, 248)
        Me.GridControl1.TabIndex = 61
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(15, 139)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Ավելացնել"
        '
        'addTList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(613, 456)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txtToAirport)
        Me.Controls.Add(Me.txtFromAirport)
        Me.Controls.Add(Me.fDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtReservNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addTList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Նոր) Տոմսի Ամրագրում"
        CType(Me.fDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReservNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromAirport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToAirport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtReservNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromAirport As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtToAirport As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
End Class
