<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAirport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAirport))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAirport = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCountry = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtAirport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(253, 150)
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
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Անվանում"
        '
        'txtAirport
        '
        Me.txtAirport.Location = New System.Drawing.Point(126, 30)
        Me.txtAirport.Name = "txtAirport"
        Me.txtAirport.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAirport.Properties.Appearance.Options.UseBackColor = True
        Me.txtAirport.Size = New System.Drawing.Size(297, 20)
        Me.txtAirport.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 57)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Երկիր"
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
        'txtCity
        '
        Me.txtCity.EditValue = ""
        Me.txtCity.Location = New System.Drawing.Point(126, 80)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCity.Properties.Appearance.Options.UseBackColor = True
        Me.txtCity.Size = New System.Drawing.Size(297, 20)
        Me.txtCity.TabIndex = 2
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl11.TabIndex = 42
        Me.LabelControl11.Text = "Քաղաք"
        '
        'txtCode
        '
        Me.txtCode.EditValue = ""
        Me.txtCode.Location = New System.Drawing.Point(126, 106)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Size = New System.Drawing.Size(297, 20)
        Me.txtCode.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 107)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Կոդ"
        '
        'addAirport
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 220)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtAirport)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAirport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Նոր) Աէրոպորտ"
        CType(Me.txtAirport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAirport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCountry As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
