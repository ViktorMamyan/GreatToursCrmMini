<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrative
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrative))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnOtherPayments = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBankFee = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdds = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOffice = New DevExpress.XtraEditors.SimpleButton()
        Me.btnServices = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalary = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTax = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPlacePayment = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnTours = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrePayment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsurance = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTickets = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHotels = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnOtherPayments)
        Me.GroupControl1.Controls.Add(Me.btnBankFee)
        Me.GroupControl1.Controls.Add(Me.btnAdds)
        Me.GroupControl1.Controls.Add(Me.btnOffice)
        Me.GroupControl1.Controls.Add(Me.btnServices)
        Me.GroupControl1.Controls.Add(Me.btnTel)
        Me.GroupControl1.Controls.Add(Me.btnSalary)
        Me.GroupControl1.Controls.Add(Me.btnTax)
        Me.GroupControl1.Controls.Add(Me.btnPlacePayment)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(351, 471)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Ծախսեր"
        '
        'btnOtherPayments
        '
        Me.btnOtherPayments.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOtherPayments.Appearance.Options.UseFont = True
        Me.btnOtherPayments.Appearance.Options.UseTextOptions = True
        Me.btnOtherPayments.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnOtherPayments.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOtherPayments.Image = CType(resources.GetObject("btnOtherPayments.Image"), System.Drawing.Image)
        Me.btnOtherPayments.Location = New System.Drawing.Point(24, 418)
        Me.btnOtherPayments.Name = "btnOtherPayments"
        Me.btnOtherPayments.Size = New System.Drawing.Size(303, 42)
        Me.btnOtherPayments.TabIndex = 8
        Me.btnOtherPayments.Text = "Այլ Ծախսեր"
        '
        'btnBankFee
        '
        Me.btnBankFee.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBankFee.Appearance.Options.UseFont = True
        Me.btnBankFee.Appearance.Options.UseTextOptions = True
        Me.btnBankFee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnBankFee.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBankFee.Image = CType(resources.GetObject("btnBankFee.Image"), System.Drawing.Image)
        Me.btnBankFee.Location = New System.Drawing.Point(24, 370)
        Me.btnBankFee.Name = "btnBankFee"
        Me.btnBankFee.Size = New System.Drawing.Size(303, 42)
        Me.btnBankFee.TabIndex = 7
        Me.btnBankFee.Text = "Բանկային Միջնորդավճար"
        '
        'btnAdds
        '
        Me.btnAdds.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAdds.Appearance.Options.UseFont = True
        Me.btnAdds.Appearance.Options.UseTextOptions = True
        Me.btnAdds.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnAdds.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdds.Image = CType(resources.GetObject("btnAdds.Image"), System.Drawing.Image)
        Me.btnAdds.Location = New System.Drawing.Point(24, 322)
        Me.btnAdds.Name = "btnAdds"
        Me.btnAdds.Size = New System.Drawing.Size(303, 42)
        Me.btnAdds.TabIndex = 6
        Me.btnAdds.Text = "Գովազդ"
        '
        'btnOffice
        '
        Me.btnOffice.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOffice.Appearance.Options.UseFont = True
        Me.btnOffice.Appearance.Options.UseTextOptions = True
        Me.btnOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnOffice.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOffice.Image = CType(resources.GetObject("btnOffice.Image"), System.Drawing.Image)
        Me.btnOffice.Location = New System.Drawing.Point(24, 274)
        Me.btnOffice.Name = "btnOffice"
        Me.btnOffice.Size = New System.Drawing.Size(303, 42)
        Me.btnOffice.TabIndex = 5
        Me.btnOffice.Text = "Գրասենյակ"
        '
        'btnServices
        '
        Me.btnServices.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnServices.Appearance.Options.UseFont = True
        Me.btnServices.Appearance.Options.UseTextOptions = True
        Me.btnServices.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnServices.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnServices.Image = CType(resources.GetObject("btnServices.Image"), System.Drawing.Image)
        Me.btnServices.Location = New System.Drawing.Point(24, 226)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(303, 42)
        Me.btnServices.TabIndex = 4
        Me.btnServices.Text = "Կոմունալ"
        '
        'btnTel
        '
        Me.btnTel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTel.Appearance.Options.UseFont = True
        Me.btnTel.Appearance.Options.UseTextOptions = True
        Me.btnTel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTel.Image = CType(resources.GetObject("btnTel.Image"), System.Drawing.Image)
        Me.btnTel.Location = New System.Drawing.Point(24, 178)
        Me.btnTel.Name = "btnTel"
        Me.btnTel.Size = New System.Drawing.Size(303, 42)
        Me.btnTel.TabIndex = 3
        Me.btnTel.Text = "Հեռախոս"
        '
        'btnSalary
        '
        Me.btnSalary.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSalary.Appearance.Options.UseFont = True
        Me.btnSalary.Appearance.Options.UseTextOptions = True
        Me.btnSalary.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnSalary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSalary.Image = CType(resources.GetObject("btnSalary.Image"), System.Drawing.Image)
        Me.btnSalary.Location = New System.Drawing.Point(24, 130)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(303, 42)
        Me.btnSalary.TabIndex = 2
        Me.btnSalary.Text = "Աշխատավարձ"
        '
        'btnTax
        '
        Me.btnTax.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTax.Appearance.Options.UseFont = True
        Me.btnTax.Appearance.Options.UseTextOptions = True
        Me.btnTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTax.Image = CType(resources.GetObject("btnTax.Image"), System.Drawing.Image)
        Me.btnTax.Location = New System.Drawing.Point(24, 82)
        Me.btnTax.Name = "btnTax"
        Me.btnTax.Size = New System.Drawing.Size(303, 42)
        Me.btnTax.TabIndex = 1
        Me.btnTax.Text = "Հարկեր"
        '
        'btnPlacePayment
        '
        Me.btnPlacePayment.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPlacePayment.Appearance.Options.UseFont = True
        Me.btnPlacePayment.Appearance.Options.UseTextOptions = True
        Me.btnPlacePayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnPlacePayment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPlacePayment.Image = CType(resources.GetObject("btnPlacePayment.Image"), System.Drawing.Image)
        Me.btnPlacePayment.Location = New System.Drawing.Point(24, 34)
        Me.btnPlacePayment.Name = "btnPlacePayment"
        Me.btnPlacePayment.Size = New System.Drawing.Size(303, 42)
        Me.btnPlacePayment.TabIndex = 0
        Me.btnPlacePayment.Text = "Տարածքի Վարձակալություն"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnTours)
        Me.GroupControl2.Controls.Add(Me.btnPrePayment)
        Me.GroupControl2.Controls.Add(Me.btnInsurance)
        Me.GroupControl2.Controls.Add(Me.btnTickets)
        Me.GroupControl2.Controls.Add(Me.btnHotels)
        Me.GroupControl2.Location = New System.Drawing.Point(369, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(351, 471)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Գործարքներ"
        '
        'btnTours
        '
        Me.btnTours.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTours.Appearance.Options.UseFont = True
        Me.btnTours.Appearance.Options.UseTextOptions = True
        Me.btnTours.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTours.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTours.Enabled = False
        Me.btnTours.Image = CType(resources.GetObject("btnTours.Image"), System.Drawing.Image)
        Me.btnTours.Location = New System.Drawing.Point(19, 226)
        Me.btnTours.Name = "btnTours"
        Me.btnTours.Size = New System.Drawing.Size(303, 42)
        Me.btnTours.TabIndex = 4
        Me.btnTours.Text = "Տուրեր"
        '
        'btnPrePayment
        '
        Me.btnPrePayment.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPrePayment.Appearance.Options.UseFont = True
        Me.btnPrePayment.Appearance.Options.UseTextOptions = True
        Me.btnPrePayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnPrePayment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrePayment.Enabled = False
        Me.btnPrePayment.Image = CType(resources.GetObject("btnPrePayment.Image"), System.Drawing.Image)
        Me.btnPrePayment.Location = New System.Drawing.Point(19, 178)
        Me.btnPrePayment.Name = "btnPrePayment"
        Me.btnPrePayment.Size = New System.Drawing.Size(303, 42)
        Me.btnPrePayment.TabIndex = 3
        Me.btnPrePayment.Text = "Կանխավճար"
        '
        'btnInsurance
        '
        Me.btnInsurance.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnInsurance.Appearance.Options.UseFont = True
        Me.btnInsurance.Appearance.Options.UseTextOptions = True
        Me.btnInsurance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnInsurance.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInsurance.Enabled = False
        Me.btnInsurance.Image = CType(resources.GetObject("btnInsurance.Image"), System.Drawing.Image)
        Me.btnInsurance.Location = New System.Drawing.Point(19, 130)
        Me.btnInsurance.Name = "btnInsurance"
        Me.btnInsurance.Size = New System.Drawing.Size(303, 42)
        Me.btnInsurance.TabIndex = 2
        Me.btnInsurance.Text = "Ապահովագրություն"
        '
        'btnTickets
        '
        Me.btnTickets.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTickets.Appearance.Options.UseFont = True
        Me.btnTickets.Appearance.Options.UseTextOptions = True
        Me.btnTickets.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnTickets.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTickets.Enabled = False
        Me.btnTickets.Image = CType(resources.GetObject("btnTickets.Image"), System.Drawing.Image)
        Me.btnTickets.Location = New System.Drawing.Point(19, 82)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(303, 42)
        Me.btnTickets.TabIndex = 1
        Me.btnTickets.Text = "Տոմսեր"
        '
        'btnHotels
        '
        Me.btnHotels.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnHotels.Appearance.Options.UseFont = True
        Me.btnHotels.Appearance.Options.UseTextOptions = True
        Me.btnHotels.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnHotels.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnHotels.Enabled = False
        Me.btnHotels.Image = CType(resources.GetObject("btnHotels.Image"), System.Drawing.Image)
        Me.btnHotels.Location = New System.Drawing.Point(19, 34)
        Me.btnHotels.Name = "btnHotels"
        Me.btnHotels.Size = New System.Drawing.Size(303, 42)
        Me.btnHotels.TabIndex = 0
        Me.btnHotels.Text = "Հյուրանոցներ"
        '
        'Administrative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(734, 499)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Administrative"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ադմինիստրատիվ Մենյու - Great Tours LLC"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnPlacePayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOtherPayments As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBankFee As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdds As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOffice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnServices As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnTours As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrePayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInsurance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTickets As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHotels As DevExpress.XtraEditors.SimpleButton
End Class
