<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editDirectionOperatorCombination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editDirectionOperatorCombination))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbOperator = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbDirection = New System.Windows.Forms.ComboBox()
        CType(Me.cbOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(284, 201)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEdit.Size = New System.Drawing.Size(212, 52)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Խմբագրել"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 40)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Ուղղություն"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 84)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Օպերատոր"
        '
        'cbOperator
        '
        Me.cbOperator.EditValue = ""
        Me.cbOperator.Location = New System.Drawing.Point(107, 81)
        Me.cbOperator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbOperator.Name = "cbOperator"
        Me.cbOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperator.Size = New System.Drawing.Size(308, 22)
        Me.cbOperator.TabIndex = 1
        '
        'cbDirection
        '
        Me.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDirection.FormattingEnabled = True
        Me.cbDirection.Location = New System.Drawing.Point(107, 37)
        Me.cbDirection.Name = "cbDirection"
        Me.cbDirection.Size = New System.Drawing.Size(308, 24)
        Me.cbDirection.TabIndex = 0
        '
        'editDirectionOperatorCombination
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(509, 280)
        Me.Controls.Add(Me.cbDirection)
        Me.Controls.Add(Me.cbOperator)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editDirectionOperatorCombination"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Խմբագրել Ուղղություն - Օպերատոր Համակցումը"
        CType(Me.cbOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOperator As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbDirection As System.Windows.Forms.ComboBox
End Class
