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
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomerDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTour = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBonusCard = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAirOperator = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAdministrativ = New DevExpress.XtraEditors.SimpleButton()
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
        Me.btnDirection.Location = New System.Drawing.Point(32, 27)
        Me.btnDirection.Name = "btnDirection"
        Me.btnDirection.Size = New System.Drawing.Size(303, 42)
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
        Me.btnTourOperator.Location = New System.Drawing.Point(32, 75)
        Me.btnTourOperator.Name = "btnTourOperator"
        Me.btnTourOperator.Size = New System.Drawing.Size(303, 42)
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
        Me.btnDirOpCombination.Location = New System.Drawing.Point(32, 122)
        Me.btnDirOpCombination.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDirOpCombination.Name = "btnDirOpCombination"
        Me.btnDirOpCombination.Size = New System.Drawing.Size(303, 42)
        Me.btnDirOpCombination.TabIndex = 3
        Me.btnDirOpCombination.Text = "Ողղություն - Օպերատոր"
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Appearance.Options.UseTextOptions = True
        Me.btnCustomer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(32, 243)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(303, 42)
        Me.btnCustomer.TabIndex = 5
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
        Me.btnCustomerDetails.Location = New System.Drawing.Point(32, 289)
        Me.btnCustomerDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomerDetails.Name = "btnCustomerDetails"
        Me.btnCustomerDetails.Size = New System.Drawing.Size(303, 42)
        Me.btnCustomerDetails.TabIndex = 6
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
        Me.btnTour.Location = New System.Drawing.Point(32, 405)
        Me.btnTour.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTour.Name = "btnTour"
        Me.btnTour.Size = New System.Drawing.Size(303, 42)
        Me.btnTour.TabIndex = 8
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
        Me.btnBonusCard.Location = New System.Drawing.Point(32, 336)
        Me.btnBonusCard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBonusCard.Name = "btnBonusCard"
        Me.btnBonusCard.Size = New System.Drawing.Size(303, 42)
        Me.btnBonusCard.TabIndex = 7
        Me.btnBonusCard.Text = "Բոնուսային Քարտ"
        '
        'btnAirOperator
        '
        Me.btnAirOperator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnAirOperator.Appearance.Options.UseFont = True
        Me.btnAirOperator.Appearance.Options.UseTextOptions = True
        Me.btnAirOperator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnAirOperator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAirOperator.Image = CType(resources.GetObject("btnAirOperator.Image"), System.Drawing.Image)
        Me.btnAirOperator.Location = New System.Drawing.Point(32, 168)
        Me.btnAirOperator.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAirOperator.Name = "btnAirOperator"
        Me.btnAirOperator.Size = New System.Drawing.Size(303, 42)
        Me.btnAirOperator.TabIndex = 4
        Me.btnAirOperator.Text = "Ավիափոխադրող"
        '
        'txtAdministrativ
        '
        Me.txtAdministrativ.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtAdministrativ.Appearance.Options.UseFont = True
        Me.txtAdministrativ.Appearance.Options.UseTextOptions = True
        Me.txtAdministrativ.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtAdministrativ.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAdministrativ.Image = CType(resources.GetObject("txtAdministrativ.Image"), System.Drawing.Image)
        Me.txtAdministrativ.Location = New System.Drawing.Point(32, 470)
        Me.txtAdministrativ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdministrativ.Name = "txtAdministrativ"
        Me.txtAdministrativ.Size = New System.Drawing.Size(303, 42)
        Me.txtAdministrativ.TabIndex = 9
        Me.txtAdministrativ.Text = "Ադմինիստրատիվ"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(375, 537)
        Me.Controls.Add(Me.txtAdministrativ)
        Me.Controls.Add(Me.btnAirOperator)
        Me.Controls.Add(Me.btnBonusCard)
        Me.Controls.Add(Me.btnTour)
        Me.Controls.Add(Me.btnCustomerDetails)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnDirOpCombination)
        Me.Controls.Add(Me.btnTourOperator)
        Me.Controls.Add(Me.btnDirection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Գլխավոր Մենյու - Great Tours LLC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnDirection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTourOperator As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDirOpCombination As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomerDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTour As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBonusCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAirOperator As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAdministrativ As DevExpress.XtraEditors.SimpleButton
End Class
