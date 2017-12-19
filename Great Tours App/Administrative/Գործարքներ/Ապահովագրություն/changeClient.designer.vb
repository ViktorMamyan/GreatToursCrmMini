<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changeClient))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtContact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClient = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(253, 92)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEdit.Size = New System.Drawing.Size(170, 42)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Խմբագրել"
        '
        'txtContact
        '
        Me.txtContact.EditValue = ""
        Me.txtContact.Location = New System.Drawing.Point(154, 54)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContact.Properties.Appearance.Options.UseBackColor = True
        Me.txtContact.Size = New System.Drawing.Size(275, 20)
        Me.txtContact.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 57)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "Կոնտակտային Տվյալներ"
        '
        'txtClient
        '
        Me.txtClient.EditValue = ""
        Me.txtClient.Location = New System.Drawing.Point(154, 28)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClient.Properties.Appearance.Options.UseBackColor = True
        Me.txtClient.Size = New System.Drawing.Size(275, 20)
        Me.txtClient.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 31)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Անուն Ազգանուն"
        '
        'changeClient
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(458, 166)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "changeClient"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ծախսի Տեսակի Փոփոխում"
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
