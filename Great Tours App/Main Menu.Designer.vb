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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnAirOperator = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDirOpCombination = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTourOperator = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDirection = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBonusCard = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomerDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnHotel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTour = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtAdministrativ = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnAirOperator)
        Me.GroupControl1.Controls.Add(Me.btnDirOpCombination)
        Me.GroupControl1.Controls.Add(Me.btnTourOperator)
        Me.GroupControl1.Controls.Add(Me.btnDirection)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(332, 227)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Տուր, Օպերատոր, Ուղղություն"
        '
        'btnAirOperator
        '
        Me.btnAirOperator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnAirOperator.Appearance.Options.UseFont = True
        Me.btnAirOperator.Appearance.Options.UseTextOptions = True
        Me.btnAirOperator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnAirOperator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAirOperator.Image = CType(resources.GetObject("btnAirOperator.Image"), System.Drawing.Image)
        Me.btnAirOperator.Location = New System.Drawing.Point(16, 165)
        Me.btnAirOperator.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAirOperator.Name = "btnAirOperator"
        Me.btnAirOperator.Size = New System.Drawing.Size(303, 42)
        Me.btnAirOperator.TabIndex = 3
        Me.btnAirOperator.Text = "Ավիափոխադրող"
        '
        'btnDirOpCombination
        '
        Me.btnDirOpCombination.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnDirOpCombination.Appearance.Options.UseFont = True
        Me.btnDirOpCombination.Appearance.Options.UseTextOptions = True
        Me.btnDirOpCombination.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnDirOpCombination.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDirOpCombination.Image = CType(resources.GetObject("btnDirOpCombination.Image"), System.Drawing.Image)
        Me.btnDirOpCombination.Location = New System.Drawing.Point(16, 119)
        Me.btnDirOpCombination.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDirOpCombination.Name = "btnDirOpCombination"
        Me.btnDirOpCombination.Size = New System.Drawing.Size(303, 42)
        Me.btnDirOpCombination.TabIndex = 2
        Me.btnDirOpCombination.Text = "Ողղություն - Օպերատոր"
        '
        'btnTourOperator
        '
        Me.btnTourOperator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnTourOperator.Appearance.Options.UseFont = True
        Me.btnTourOperator.Appearance.Options.UseTextOptions = True
        Me.btnTourOperator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTourOperator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTourOperator.Image = CType(resources.GetObject("btnTourOperator.Image"), System.Drawing.Image)
        Me.btnTourOperator.Location = New System.Drawing.Point(16, 72)
        Me.btnTourOperator.Name = "btnTourOperator"
        Me.btnTourOperator.Size = New System.Drawing.Size(303, 42)
        Me.btnTourOperator.TabIndex = 1
        Me.btnTourOperator.Text = "Տուր Օպերատոր"
        '
        'btnDirection
        '
        Me.btnDirection.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDirection.Appearance.Options.UseFont = True
        Me.btnDirection.Appearance.Options.UseTextOptions = True
        Me.btnDirection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnDirection.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDirection.Image = CType(resources.GetObject("btnDirection.Image"), System.Drawing.Image)
        Me.btnDirection.Location = New System.Drawing.Point(16, 24)
        Me.btnDirection.Name = "btnDirection"
        Me.btnDirection.Size = New System.Drawing.Size(303, 42)
        Me.btnDirection.TabIndex = 0
        Me.btnDirection.Text = "Ուղղություն"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnBonusCard)
        Me.GroupControl2.Controls.Add(Me.btnCustomerDetails)
        Me.GroupControl2.Controls.Add(Me.btnCustomer)
        Me.GroupControl2.Location = New System.Drawing.Point(350, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(332, 227)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Հաճախորդ"
        '
        'btnBonusCard
        '
        Me.btnBonusCard.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnBonusCard.Appearance.Options.UseFont = True
        Me.btnBonusCard.Appearance.Options.UseTextOptions = True
        Me.btnBonusCard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnBonusCard.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBonusCard.Image = CType(resources.GetObject("btnBonusCard.Image"), System.Drawing.Image)
        Me.btnBonusCard.Location = New System.Drawing.Point(13, 119)
        Me.btnBonusCard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBonusCard.Name = "btnBonusCard"
        Me.btnBonusCard.Size = New System.Drawing.Size(303, 42)
        Me.btnBonusCard.TabIndex = 2
        Me.btnBonusCard.Text = "Բոնուսային Քարտ"
        '
        'btnCustomerDetails
        '
        Me.btnCustomerDetails.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCustomerDetails.Appearance.Options.UseFont = True
        Me.btnCustomerDetails.Appearance.Options.UseTextOptions = True
        Me.btnCustomerDetails.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnCustomerDetails.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCustomerDetails.Image = CType(resources.GetObject("btnCustomerDetails.Image"), System.Drawing.Image)
        Me.btnCustomerDetails.Location = New System.Drawing.Point(13, 72)
        Me.btnCustomerDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomerDetails.Name = "btnCustomerDetails"
        Me.btnCustomerDetails.Size = New System.Drawing.Size(303, 42)
        Me.btnCustomerDetails.TabIndex = 1
        Me.btnCustomerDetails.Text = "Հաճախորդի Պարամետրեր"
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Appearance.Options.UseTextOptions = True
        Me.btnCustomer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(13, 24)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(303, 42)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Հաճախորդ"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnHotel)
        Me.GroupControl3.Controls.Add(Me.btnTour)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 245)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(332, 227)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Տուրեր"
        '
        'btnHotel
        '
        Me.btnHotel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnHotel.Appearance.Options.UseFont = True
        Me.btnHotel.Appearance.Options.UseTextOptions = True
        Me.btnHotel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnHotel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnHotel.Image = CType(resources.GetObject("btnHotel.Image"), System.Drawing.Image)
        Me.btnHotel.Location = New System.Drawing.Point(15, 23)
        Me.btnHotel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHotel.Name = "btnHotel"
        Me.btnHotel.Size = New System.Drawing.Size(303, 42)
        Me.btnHotel.TabIndex = 0
        Me.btnHotel.Text = "Հյուրանոց"
        '
        'btnTour
        '
        Me.btnTour.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnTour.Appearance.Options.UseFont = True
        Me.btnTour.Appearance.Options.UseTextOptions = True
        Me.btnTour.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTour.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTour.Image = CType(resources.GetObject("btnTour.Image"), System.Drawing.Image)
        Me.btnTour.Location = New System.Drawing.Point(15, 69)
        Me.btnTour.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTour.Name = "btnTour"
        Me.btnTour.Size = New System.Drawing.Size(303, 42)
        Me.btnTour.TabIndex = 1
        Me.btnTour.Text = "Տուր"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.txtAdministrativ)
        Me.GroupControl4.Location = New System.Drawing.Point(350, 245)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(332, 227)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Ադմինիստրատիվ"
        '
        'txtAdministrativ
        '
        Me.txtAdministrativ.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtAdministrativ.Appearance.Options.UseFont = True
        Me.txtAdministrativ.Appearance.Options.UseTextOptions = True
        Me.txtAdministrativ.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtAdministrativ.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAdministrativ.Image = CType(resources.GetObject("txtAdministrativ.Image"), System.Drawing.Image)
        Me.txtAdministrativ.Location = New System.Drawing.Point(13, 23)
        Me.txtAdministrativ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdministrativ.Name = "txtAdministrativ"
        Me.txtAdministrativ.Size = New System.Drawing.Size(303, 42)
        Me.txtAdministrativ.TabIndex = 0
        Me.txtAdministrativ.Text = "Ադմինիստրատիվ"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(702, 488)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Գլխավոր Մենյու - Great Tours LLC"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDirection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTourOperator As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDirOpCombination As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAirOperator As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomerDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBonusCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnHotel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTour As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAdministrativ As DevExpress.XtraEditors.SimpleButton
End Class
