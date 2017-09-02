<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDirection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addDirection))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDirection = New DevExpress.XtraEditors.TextEdit()
        Me.txtViza = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ckSingle = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckSingle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(253, 143)
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
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Ուղղություն"
        '
        'txtDirection
        '
        Me.txtDirection.Location = New System.Drawing.Point(126, 29)
        Me.txtDirection.Name = "txtDirection"
        Me.txtDirection.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDirection.Properties.Appearance.Options.UseBackColor = True
        Me.txtDirection.Size = New System.Drawing.Size(297, 20)
        Me.txtDirection.TabIndex = 0
        '
        'txtViza
        '
        Me.txtViza.Location = New System.Drawing.Point(126, 97)
        Me.txtViza.Name = "txtViza"
        Me.txtViza.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtViza.Properties.Appearance.Options.UseBackColor = True
        Me.txtViza.Size = New System.Drawing.Size(297, 20)
        Me.txtViza.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Վիզայի պարամետրեր"
        '
        'ckSingle
        '
        Me.ckSingle.EditValue = True
        Me.ckSingle.Location = New System.Drawing.Point(126, 63)
        Me.ckSingle.Name = "ckSingle"
        Me.ckSingle.Properties.Caption = "Մեկ Ուղղություն"
        Me.ckSingle.Size = New System.Drawing.Size(133, 19)
        Me.ckSingle.TabIndex = 1
        '
        'addDirection
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 219)
        Me.Controls.Add(Me.ckSingle)
        Me.Controls.Add(Me.txtViza)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDirection)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addDirection"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Նոր Ուղղություն"
        CType(Me.txtDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckSingle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirection As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtViza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckSingle As DevExpress.XtraEditors.CheckEdit
End Class
