<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addTourCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addTourCustomer))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustomer = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTour = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(236, 112)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Ավելացնել"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 26)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Տուր"
        '
        'txtCustomer
        '
        Me.txtCustomer.EditValue = ""
        Me.txtCustomer.Location = New System.Drawing.Point(88, 52)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Size = New System.Drawing.Size(246, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 54)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Հաճախորդ"
        '
        'txtTour
        '
        Me.txtTour.Enabled = False
        Me.txtTour.Location = New System.Drawing.Point(88, 23)
        Me.txtTour.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTour.Name = "txtTour"
        Me.txtTour.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTour.Properties.Appearance.Options.UseBackColor = True
        Me.txtTour.Properties.ReadOnly = True
        Me.txtTour.Size = New System.Drawing.Size(246, 20)
        Me.txtTour.TabIndex = 0
        '
        'addTourCustomer
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 178)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addTourCustomer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Նոր) Ուղևոր"
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTour As DevExpress.XtraEditors.TextEdit
End Class
