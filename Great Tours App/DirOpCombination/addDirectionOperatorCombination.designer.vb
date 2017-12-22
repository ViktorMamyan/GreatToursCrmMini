<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDirectionOperatorCombination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addDirectionOperatorCombination))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbOperator = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbDirection = New System.Windows.Forms.ComboBox()
        CType(Me.cbOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(227, 161)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAdd.Size = New System.Drawing.Size(170, 42)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Ավելացնել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Ուղղություն"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Օպերատոր"
        '
        'cbOperator
        '
        Me.cbOperator.EditValue = ""
        Me.cbOperator.Location = New System.Drawing.Point(86, 65)
        Me.cbOperator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbOperator.Name = "cbOperator"
        Me.cbOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperator.Size = New System.Drawing.Size(246, 20)
        Me.cbOperator.TabIndex = 1
        '
        'cbDirection
        '
        Me.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDirection.FormattingEnabled = True
        Me.cbDirection.Location = New System.Drawing.Point(86, 30)
        Me.cbDirection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbDirection.Name = "cbDirection"
        Me.cbDirection.Size = New System.Drawing.Size(247, 21)
        Me.cbDirection.TabIndex = 0
        '
        'addDirectionOperatorCombination
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(407, 224)
        Me.Controls.Add(Me.cbDirection)
        Me.Controls.Add(Me.cbOperator)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addDirectionOperatorCombination"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(Նոր) Ուղղություն - Օպերատոր Համակցում"
        CType(Me.cbOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOperator As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbDirection As System.Windows.Forms.ComboBox
End Class
