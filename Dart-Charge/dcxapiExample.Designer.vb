<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dcxAPIExample
    Inherits System.Windows.Forms.Form

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
        Me.GetDetailsBtn = New System.Windows.Forms.Button()
        Me.UpdateDetailsBtn = New System.Windows.Forms.Button()
        Me.ListVehiclesBtn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GetOnlyPostcode = New System.Windows.Forms.Button()
        Me.GetOnlyBalance = New System.Windows.Forms.Button()
        Me.AccountCountryTxt = New System.Windows.Forms.TextBox()
        Me.AccountTopUpAmountTxt = New System.Windows.Forms.TextBox()
        Me.AccountOpenDateTxt = New System.Windows.Forms.TextBox()
        Me.AccountLowBalanceTxt = New System.Windows.Forms.TextBox()
        Me.AccountLocalRTxt = New System.Windows.Forms.TextBox()
        Me.AccountAutoTxt = New System.Windows.Forms.TextBox()
        Me.AccountMobilePhoneTxt = New System.Windows.Forms.TextBox()
        Me.AccountPostcodeTxt = New System.Windows.Forms.TextBox()
        Me.AccountCityTxt = New System.Windows.Forms.TextBox()
        Me.AccountAddress3Txt = New System.Windows.Forms.TextBox()
        Me.AccountAddress2Txt = New System.Windows.Forms.TextBox()
        Me.AccountAddress1Txt = New System.Windows.Forms.TextBox()
        Me.AccountEmailTxt = New System.Windows.Forms.TextBox()
        Me.AccountPhoneNumber2 = New System.Windows.Forms.TextBox()
        Me.AccountPhoneNumber1 = New System.Windows.Forms.TextBox()
        Me.AccountFullName = New System.Windows.Forms.TextBox()
        Me.AccountLastNameTxt = New System.Windows.Forms.TextBox()
        Me.AccountFirstNameTxt = New System.Windows.Forms.TextBox()
        Me.AccountCurrentBalanceTxt = New System.Windows.Forms.TextBox()
        Me.AccountCompanyNameTxt = New System.Windows.Forms.TextBox()
        Me.AccountTopUpMethodTxt = New System.Windows.Forms.TextBox()
        Me.AccountTypeTxt = New System.Windows.Forms.TextBox()
        Me.AccountStatusTxt = New System.Windows.Forms.TextBox()
        Me.AccountNumberTxt = New System.Windows.Forms.TextBox()
        Me.SchemeRulesBtn = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GetDetailsBtn
        '
        Me.GetDetailsBtn.Location = New System.Drawing.Point(3, 3)
        Me.GetDetailsBtn.Name = "GetDetailsBtn"
        Me.GetDetailsBtn.Size = New System.Drawing.Size(99, 22)
        Me.GetDetailsBtn.TabIndex = 0
        Me.GetDetailsBtn.Text = "Get Details"
        Me.GetDetailsBtn.UseVisualStyleBackColor = True
        '
        'UpdateDetailsBtn
        '
        Me.UpdateDetailsBtn.Enabled = False
        Me.UpdateDetailsBtn.Location = New System.Drawing.Point(318, 3)
        Me.UpdateDetailsBtn.Name = "UpdateDetailsBtn"
        Me.UpdateDetailsBtn.Size = New System.Drawing.Size(99, 22)
        Me.UpdateDetailsBtn.TabIndex = 1
        Me.UpdateDetailsBtn.Text = "Update Details"
        Me.UpdateDetailsBtn.UseVisualStyleBackColor = True
        '
        'ListVehiclesBtn
        '
        Me.ListVehiclesBtn.Enabled = False
        Me.ListVehiclesBtn.Location = New System.Drawing.Point(3, 134)
        Me.ListVehiclesBtn.Name = "ListVehiclesBtn"
        Me.ListVehiclesBtn.Size = New System.Drawing.Size(99, 22)
        Me.ListVehiclesBtn.TabIndex = 2
        Me.ListVehiclesBtn.Text = "List Vehicles"
        Me.ListVehiclesBtn.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(657, 217)
        Me.dgv.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SchemeRulesBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GetOnlyPostcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GetOnlyBalance)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountCountryTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountTopUpAmountTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountOpenDateTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountLowBalanceTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountLocalRTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountAutoTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountMobilePhoneTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountPostcodeTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountCityTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountAddress3Txt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountAddress2Txt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountAddress1Txt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountEmailTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountPhoneNumber2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountPhoneNumber1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountFullName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountLastNameTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountFirstNameTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountCurrentBalanceTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountCompanyNameTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountTopUpMethodTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountTypeTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountStatusTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccountNumberTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GetDetailsBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListVehiclesBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UpdateDetailsBtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(657, 378)
        Me.SplitContainer1.SplitterDistance = 157
        Me.SplitContainer1.TabIndex = 4
        '
        'GetOnlyPostcode
        '
        Me.GetOnlyPostcode.Enabled = False
        Me.GetOnlyPostcode.Location = New System.Drawing.Point(213, 3)
        Me.GetOnlyPostcode.Name = "GetOnlyPostcode"
        Me.GetOnlyPostcode.Size = New System.Drawing.Size(99, 22)
        Me.GetOnlyPostcode.TabIndex = 29
        Me.GetOnlyPostcode.Text = "Show Postcode"
        Me.GetOnlyPostcode.UseVisualStyleBackColor = True
        '
        'GetOnlyBalance
        '
        Me.GetOnlyBalance.Enabled = False
        Me.GetOnlyBalance.Location = New System.Drawing.Point(108, 3)
        Me.GetOnlyBalance.Name = "GetOnlyBalance"
        Me.GetOnlyBalance.Size = New System.Drawing.Size(99, 22)
        Me.GetOnlyBalance.TabIndex = 28
        Me.GetOnlyBalance.Text = "Show Balance"
        Me.GetOnlyBalance.UseVisualStyleBackColor = True
        '
        'AccountCountryTxt
        '
        Me.AccountCountryTxt.Location = New System.Drawing.Point(528, 83)
        Me.AccountCountryTxt.Name = "AccountCountryTxt"
        Me.AccountCountryTxt.ReadOnly = True
        Me.AccountCountryTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountCountryTxt.TabIndex = 27
        '
        'AccountTopUpAmountTxt
        '
        Me.AccountTopUpAmountTxt.Location = New System.Drawing.Point(528, 109)
        Me.AccountTopUpAmountTxt.Name = "AccountTopUpAmountTxt"
        Me.AccountTopUpAmountTxt.ReadOnly = True
        Me.AccountTopUpAmountTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountTopUpAmountTxt.TabIndex = 26
        '
        'AccountOpenDateTxt
        '
        Me.AccountOpenDateTxt.Location = New System.Drawing.Point(423, 109)
        Me.AccountOpenDateTxt.Name = "AccountOpenDateTxt"
        Me.AccountOpenDateTxt.ReadOnly = True
        Me.AccountOpenDateTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountOpenDateTxt.TabIndex = 25
        '
        'AccountLowBalanceTxt
        '
        Me.AccountLowBalanceTxt.Location = New System.Drawing.Point(318, 109)
        Me.AccountLowBalanceTxt.Name = "AccountLowBalanceTxt"
        Me.AccountLowBalanceTxt.ReadOnly = True
        Me.AccountLowBalanceTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountLowBalanceTxt.TabIndex = 24
        '
        'AccountLocalRTxt
        '
        Me.AccountLocalRTxt.Location = New System.Drawing.Point(213, 109)
        Me.AccountLocalRTxt.Name = "AccountLocalRTxt"
        Me.AccountLocalRTxt.ReadOnly = True
        Me.AccountLocalRTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountLocalRTxt.TabIndex = 23
        '
        'AccountAutoTxt
        '
        Me.AccountAutoTxt.Location = New System.Drawing.Point(108, 109)
        Me.AccountAutoTxt.Name = "AccountAutoTxt"
        Me.AccountAutoTxt.ReadOnly = True
        Me.AccountAutoTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountAutoTxt.TabIndex = 22
        '
        'AccountMobilePhoneTxt
        '
        Me.AccountMobilePhoneTxt.Location = New System.Drawing.Point(3, 109)
        Me.AccountMobilePhoneTxt.Name = "AccountMobilePhoneTxt"
        Me.AccountMobilePhoneTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountMobilePhoneTxt.TabIndex = 21
        '
        'AccountPostcodeTxt
        '
        Me.AccountPostcodeTxt.Location = New System.Drawing.Point(423, 83)
        Me.AccountPostcodeTxt.Name = "AccountPostcodeTxt"
        Me.AccountPostcodeTxt.ReadOnly = True
        Me.AccountPostcodeTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountPostcodeTxt.TabIndex = 20
        '
        'AccountCityTxt
        '
        Me.AccountCityTxt.Location = New System.Drawing.Point(318, 83)
        Me.AccountCityTxt.Name = "AccountCityTxt"
        Me.AccountCityTxt.ReadOnly = True
        Me.AccountCityTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountCityTxt.TabIndex = 19
        '
        'AccountAddress3Txt
        '
        Me.AccountAddress3Txt.Location = New System.Drawing.Point(213, 83)
        Me.AccountAddress3Txt.Name = "AccountAddress3Txt"
        Me.AccountAddress3Txt.ReadOnly = True
        Me.AccountAddress3Txt.Size = New System.Drawing.Size(99, 20)
        Me.AccountAddress3Txt.TabIndex = 18
        '
        'AccountAddress2Txt
        '
        Me.AccountAddress2Txt.Location = New System.Drawing.Point(108, 83)
        Me.AccountAddress2Txt.Name = "AccountAddress2Txt"
        Me.AccountAddress2Txt.ReadOnly = True
        Me.AccountAddress2Txt.Size = New System.Drawing.Size(99, 20)
        Me.AccountAddress2Txt.TabIndex = 17
        '
        'AccountAddress1Txt
        '
        Me.AccountAddress1Txt.Location = New System.Drawing.Point(3, 83)
        Me.AccountAddress1Txt.Name = "AccountAddress1Txt"
        Me.AccountAddress1Txt.ReadOnly = True
        Me.AccountAddress1Txt.Size = New System.Drawing.Size(99, 20)
        Me.AccountAddress1Txt.TabIndex = 16
        '
        'AccountEmailTxt
        '
        Me.AccountEmailTxt.Location = New System.Drawing.Point(528, 57)
        Me.AccountEmailTxt.Name = "AccountEmailTxt"
        Me.AccountEmailTxt.ReadOnly = True
        Me.AccountEmailTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountEmailTxt.TabIndex = 15
        '
        'AccountPhoneNumber2
        '
        Me.AccountPhoneNumber2.Location = New System.Drawing.Point(423, 57)
        Me.AccountPhoneNumber2.Name = "AccountPhoneNumber2"
        Me.AccountPhoneNumber2.ReadOnly = True
        Me.AccountPhoneNumber2.Size = New System.Drawing.Size(99, 20)
        Me.AccountPhoneNumber2.TabIndex = 14
        '
        'AccountPhoneNumber1
        '
        Me.AccountPhoneNumber1.Location = New System.Drawing.Point(318, 57)
        Me.AccountPhoneNumber1.Name = "AccountPhoneNumber1"
        Me.AccountPhoneNumber1.ReadOnly = True
        Me.AccountPhoneNumber1.Size = New System.Drawing.Size(99, 20)
        Me.AccountPhoneNumber1.TabIndex = 13
        '
        'AccountFullName
        '
        Me.AccountFullName.Location = New System.Drawing.Point(213, 57)
        Me.AccountFullName.Name = "AccountFullName"
        Me.AccountFullName.ReadOnly = True
        Me.AccountFullName.Size = New System.Drawing.Size(99, 20)
        Me.AccountFullName.TabIndex = 12
        '
        'AccountLastNameTxt
        '
        Me.AccountLastNameTxt.Location = New System.Drawing.Point(108, 57)
        Me.AccountLastNameTxt.Name = "AccountLastNameTxt"
        Me.AccountLastNameTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountLastNameTxt.TabIndex = 11
        '
        'AccountFirstNameTxt
        '
        Me.AccountFirstNameTxt.Location = New System.Drawing.Point(3, 57)
        Me.AccountFirstNameTxt.Name = "AccountFirstNameTxt"
        Me.AccountFirstNameTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountFirstNameTxt.TabIndex = 10
        '
        'AccountCurrentBalanceTxt
        '
        Me.AccountCurrentBalanceTxt.Location = New System.Drawing.Point(528, 31)
        Me.AccountCurrentBalanceTxt.Name = "AccountCurrentBalanceTxt"
        Me.AccountCurrentBalanceTxt.ReadOnly = True
        Me.AccountCurrentBalanceTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountCurrentBalanceTxt.TabIndex = 8
        '
        'AccountCompanyNameTxt
        '
        Me.AccountCompanyNameTxt.Location = New System.Drawing.Point(423, 31)
        Me.AccountCompanyNameTxt.Name = "AccountCompanyNameTxt"
        Me.AccountCompanyNameTxt.ReadOnly = True
        Me.AccountCompanyNameTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountCompanyNameTxt.TabIndex = 7
        '
        'AccountTopUpMethodTxt
        '
        Me.AccountTopUpMethodTxt.Location = New System.Drawing.Point(318, 31)
        Me.AccountTopUpMethodTxt.Name = "AccountTopUpMethodTxt"
        Me.AccountTopUpMethodTxt.ReadOnly = True
        Me.AccountTopUpMethodTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountTopUpMethodTxt.TabIndex = 6
        '
        'AccountTypeTxt
        '
        Me.AccountTypeTxt.Location = New System.Drawing.Point(213, 31)
        Me.AccountTypeTxt.Name = "AccountTypeTxt"
        Me.AccountTypeTxt.ReadOnly = True
        Me.AccountTypeTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountTypeTxt.TabIndex = 5
        '
        'AccountStatusTxt
        '
        Me.AccountStatusTxt.Location = New System.Drawing.Point(108, 31)
        Me.AccountStatusTxt.Name = "AccountStatusTxt"
        Me.AccountStatusTxt.ReadOnly = True
        Me.AccountStatusTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountStatusTxt.TabIndex = 4
        '
        'AccountNumberTxt
        '
        Me.AccountNumberTxt.Location = New System.Drawing.Point(3, 31)
        Me.AccountNumberTxt.Name = "AccountNumberTxt"
        Me.AccountNumberTxt.ReadOnly = True
        Me.AccountNumberTxt.Size = New System.Drawing.Size(99, 20)
        Me.AccountNumberTxt.TabIndex = 3
        '
        'SchemeRulesBtn
        '
        Me.SchemeRulesBtn.Location = New System.Drawing.Point(423, 3)
        Me.SchemeRulesBtn.Name = "SchemeRulesBtn"
        Me.SchemeRulesBtn.Size = New System.Drawing.Size(99, 22)
        Me.SchemeRulesBtn.TabIndex = 30
        Me.SchemeRulesBtn.Text = "Get Rules"
        Me.SchemeRulesBtn.UseVisualStyleBackColor = True
        '
        'dcxAPIExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 378)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "dcxAPIExample"
        Me.Text = "Main Form"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GetDetailsBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateDetailsBtn As System.Windows.Forms.Button
    Friend WithEvents ListVehiclesBtn As System.Windows.Forms.Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents AccountLastNameTxt As TextBox
    Friend WithEvents AccountFirstNameTxt As TextBox
    Friend WithEvents AccountCurrentBalanceTxt As TextBox
    Friend WithEvents AccountCompanyNameTxt As TextBox
    Friend WithEvents AccountTopUpMethodTxt As TextBox
    Friend WithEvents AccountTypeTxt As TextBox
    Friend WithEvents AccountStatusTxt As TextBox
    Friend WithEvents AccountNumberTxt As TextBox
    Friend WithEvents AccountPhoneNumber2 As TextBox
    Friend WithEvents AccountPhoneNumber1 As TextBox
    Friend WithEvents AccountFullName As TextBox
    Friend WithEvents AccountTopUpAmountTxt As TextBox
    Friend WithEvents AccountOpenDateTxt As TextBox
    Friend WithEvents AccountLowBalanceTxt As TextBox
    Friend WithEvents AccountLocalRTxt As TextBox
    Friend WithEvents AccountAutoTxt As TextBox
    Friend WithEvents AccountMobilePhoneTxt As TextBox
    Friend WithEvents AccountPostcodeTxt As TextBox
    Friend WithEvents AccountCityTxt As TextBox
    Friend WithEvents AccountAddress3Txt As TextBox
    Friend WithEvents AccountAddress2Txt As TextBox
    Friend WithEvents AccountAddress1Txt As TextBox
    Friend WithEvents AccountEmailTxt As TextBox
    Friend WithEvents AccountCountryTxt As TextBox
    Friend WithEvents GetOnlyPostcode As Button
    Friend WithEvents GetOnlyBalance As Button
    Friend WithEvents SchemeRulesBtn As Button
End Class
