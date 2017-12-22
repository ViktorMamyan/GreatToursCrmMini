<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editHotel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editHotel))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHotel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCountry = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtStar = New DevExpress.XtraEditors.TextEdit()
        Me.txtRegion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtType = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(253, 190)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEdit.Size = New System.Drawing.Size(170, 42)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Խմբագրել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Հյուրանոց"
        '
        'txtHotel
        '
        Me.txtHotel.Location = New System.Drawing.Point(126, 30)
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHotel.Properties.Appearance.Options.UseBackColor = True
        Me.txtHotel.Size = New System.Drawing.Size(297, 20)
        Me.txtHotel.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Երկիր"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 109)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Աստղ"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(126, 55)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCountry.Properties.Appearance.Options.UseBackColor = True
        Me.txtCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Նոր", Nothing, Nothing, True)})
        Me.txtCountry.Properties.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(297, 20)
        Me.txtCountry.TabIndex = 1
        '
        'txtStar
        '
        Me.txtStar.EditValue = "0"
        Me.txtStar.Location = New System.Drawing.Point(126, 106)
        Me.txtStar.Name = "txtStar"
        Me.txtStar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtStar.Properties.Appearance.Options.UseBackColor = True
        Me.txtStar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStar.Properties.Mask.EditMask = "n0"
        Me.txtStar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtStar.Size = New System.Drawing.Size(297, 20)
        Me.txtStar.TabIndex = 3
        '
        'txtRegion
        '
        Me.txtRegion.EditValue = ""
        Me.txtRegion.Location = New System.Drawing.Point(126, 80)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRegion.Properties.Appearance.Options.UseBackColor = True
        Me.txtRegion.Size = New System.Drawing.Size(297, 20)
        Me.txtRegion.TabIndex = 2
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 83)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl11.TabIndex = 42
        Me.LabelControl11.Text = "Տարածաշրջան"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(126, 131)
        Me.txtType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtType.Name = "txtType"
        Me.txtType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtType.Properties.Appearance.Options.UseBackColor = True
        Me.txtType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Ընտրել", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "Նոր", Nothing, Nothing, True)})
        Me.txtType.Properties.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(297, 20)
        Me.txtType.TabIndex = 4
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(12, 129)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl12.TabIndex = 44
        Me.LabelControl12.Text = "Տեսակ"
        '
        'editHotel
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 258)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtStar)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtHotel)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editHotel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Խմբագրել) Հյուրանոց"
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHotel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCountry As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtStar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRegion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtType As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
End Class
