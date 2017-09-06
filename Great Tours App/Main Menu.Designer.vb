<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.btnDirection = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTourOperator = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDirOpCombination = New DevExpress.XtraEditors.SimpleButton()
        Me.ckLocalDB = New DevExpress.XtraEditors.CheckEdit()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomerDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTour = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBonusCard = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ckLocalDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'btnDirection
        '
        Me.btnDirection.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDirection.Appearance.Options.UseFont = True
        Me.btnDirection.Appearance.Options.UseTextOptions = True
        Me.btnDirection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnDirection.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDirection.Image = CType(resources.GetObject("btnDirection.Image"), System.Drawing.Image)
        Me.btnDirection.Location = New System.Drawing.Point(40, 34)
        Me.btnDirection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDirection.Name = "btnDirection"
        Me.btnDirection.Size = New System.Drawing.Size(379, 52)
        Me.btnDirection.TabIndex = 1
        Me.btnDirection.Text = "Ուղղություն"
        '
        'btnTourOperator
        '
        Me.btnTourOperator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnTourOperator.Appearance.Options.UseFont = True
        Me.btnTourOperator.Appearance.Options.UseTextOptions = True
        Me.btnTourOperator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTourOperator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTourOperator.Image = CType(resources.GetObject("btnTourOperator.Image"), System.Drawing.Image)
        Me.btnTourOperator.Location = New System.Drawing.Point(40, 94)
        Me.btnTourOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTourOperator.Name = "btnTourOperator"
        Me.btnTourOperator.Size = New System.Drawing.Size(379, 52)
        Me.btnTourOperator.TabIndex = 2
        Me.btnTourOperator.Text = "Տուր Օպերատոր"
        '
        'btnDirOpCombination
        '
        Me.btnDirOpCombination.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnDirOpCombination.Appearance.Options.UseFont = True
        Me.btnDirOpCombination.Appearance.Options.UseTextOptions = True
        Me.btnDirOpCombination.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnDirOpCombination.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDirOpCombination.Image = CType(resources.GetObject("btnDirOpCombination.Image"), System.Drawing.Image)
        Me.btnDirOpCombination.Location = New System.Drawing.Point(40, 153)
        Me.btnDirOpCombination.Name = "btnDirOpCombination"
        Me.btnDirOpCombination.Size = New System.Drawing.Size(379, 52)
        Me.btnDirOpCombination.TabIndex = 3
        Me.btnDirOpCombination.Text = "Ողղություն - Օպերատոր"
        '
        'ckLocalDB
        '
        Me.ckLocalDB.Location = New System.Drawing.Point(12, 579)
        Me.ckLocalDB.Name = "ckLocalDB"
        Me.ckLocalDB.Properties.Caption = "Օգտագործել լոկալ բազա"
        Me.ckLocalDB.Size = New System.Drawing.Size(202, 20)
        Me.ckLocalDB.TabIndex = 0
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Appearance.Options.UseTextOptions = True
        Me.btnCustomer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(40, 246)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(379, 52)
        Me.btnCustomer.TabIndex = 4
        Me.btnCustomer.Text = "Հաճախորդ"
        '
        'btnCustomerDetails
        '
        Me.btnCustomerDetails.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCustomerDetails.Appearance.Options.UseFont = True
        Me.btnCustomerDetails.Appearance.Options.UseTextOptions = True
        Me.btnCustomerDetails.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnCustomerDetails.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCustomerDetails.Image = CType(resources.GetObject("btnCustomerDetails.Image"), System.Drawing.Image)
        Me.btnCustomerDetails.Location = New System.Drawing.Point(40, 304)
        Me.btnCustomerDetails.Name = "btnCustomerDetails"
        Me.btnCustomerDetails.Size = New System.Drawing.Size(379, 52)
        Me.btnCustomerDetails.TabIndex = 5
        Me.btnCustomerDetails.Text = "Հաճախորդի Պարամետրեր"
        '
        'btnTour
        '
        Me.btnTour.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnTour.Appearance.Options.UseFont = True
        Me.btnTour.Appearance.Options.UseTextOptions = True
        Me.btnTour.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTour.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTour.Image = CType(resources.GetObject("btnTour.Image"), System.Drawing.Image)
        Me.btnTour.Location = New System.Drawing.Point(40, 449)
        Me.btnTour.Name = "btnTour"
        Me.btnTour.Size = New System.Drawing.Size(379, 52)
        Me.btnTour.TabIndex = 7
        Me.btnTour.Text = "Տուր"
        '
        'btnBonusCard
        '
        Me.btnBonusCard.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnBonusCard.Appearance.Options.UseFont = True
        Me.btnBonusCard.Appearance.Options.UseTextOptions = True
        Me.btnBonusCard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnBonusCard.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBonusCard.Image = CType(resources.GetObject("btnBonusCard.Image"), System.Drawing.Image)
        Me.btnBonusCard.Location = New System.Drawing.Point(40, 362)
        Me.btnBonusCard.Name = "btnBonusCard"
        Me.btnBonusCard.Size = New System.Drawing.Size(379, 52)
        Me.btnBonusCard.TabIndex = 6
        Me.btnBonusCard.Text = "Բոնուսային Քարտ"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(469, 611)
        Me.Controls.Add(Me.btnBonusCard)
        Me.Controls.Add(Me.btnTour)
        Me.Controls.Add(Me.btnCustomerDetails)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.ckLocalDB)
        Me.Controls.Add(Me.btnDirOpCombination)
        Me.Controls.Add(Me.btnTourOperator)
        Me.Controls.Add(Me.btnDirection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Գլխավոր Մենյու - Great Tours LLC"
        CType(Me.ckLocalDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnDirection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTourOperator As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDirOpCombination As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckLocalDB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomerDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTour As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBonusCard As DevExpress.XtraEditors.SimpleButton
End Class
