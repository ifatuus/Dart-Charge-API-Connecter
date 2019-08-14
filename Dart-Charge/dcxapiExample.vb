Imports dcxapi.DartfordCrossingAPI

Public Class dcxAPIExample

    'declare API object
    Dim dca As DartfordCrossingAPI

    Dim FieldUpdate As Boolean = False ' If user has changed a field

    Private Sub CreateDCAObject()
        'Create api object
        dca = New DartfordCrossingAPI("_your_api_key_", "_your_account_number_")
    End Sub

    Private Sub GetDetailsBtn_Click(sender As Object, e As EventArgs) Handles GetDetailsBtn.Click
        Dim thistime As DateTime = Now


        'create object if it doesn't exist.
        If dca Is Nothing Then
            CreateDCAObject()
        End If

        'refresh account details
        dca.AccountDetails.Refresh()

        'populate text boxes with account details.
        AccountNumberTxt.Text = dca.AccountDetails.AccountNumber
        AccountStatusTxt.Text = dca.AccountDetails.AccountStatus
        AccountTypeTxt.Text = dca.AccountDetails.AccountType
        AccountTopUpMethodTxt.Text = dca.AccountDetails.TopUpMethod
        AccountCompanyNameTxt.Text = dca.AccountDetails.CompanyName
        AccountCurrentBalanceTxt.Text = dca.AccountDetails.CurrentBalance
        AccountFirstNameTxt.Text = dca.AccountDetails.FirstName
        AccountLastNameTxt.Text = dca.AccountDetails.LastName
        AccountFullName.Text = dca.AccountDetails.FullName
        AccountPhoneNumber1.Text = dca.AccountDetails.Phone1
        AccountPhoneNumber2.Text = dca.AccountDetails.Phone2
        AccountEmailTxt.Text = dca.AccountDetails.EmailAddress
        AccountAddress1Txt.Text = dca.AccountDetails.Address1
        AccountAddress2Txt.Text = dca.AccountDetails.Address2
        AccountAddress3Txt.Text = dca.AccountDetails.Address3
        AccountCityTxt.Text = dca.AccountDetails.City
        AccountCountryTxt.Text = dca.AccountDetails.Country
        AccountPostcodeTxt.Text = dca.AccountDetails.Postcode
        AccountMobilePhoneTxt.Text = dca.AccountDetails.MobilePhone
        AccountAutoTxt.Text = dca.AccountDetails.AutoTopUp
        AccountLocalRTxt.Text = dca.AccountDetails.LocalResident
        AccountLowBalanceTxt.Text = dca.AccountDetails.LowBalanceThreshold
        AccountOpenDateTxt.Text = dca.AccountDetails.AccountOpenDate
        AccountTopUpAmountTxt.Text = dca.AccountDetails.AutoTopUpAmount

        Debug.Print(dca.AccountDetails.Reponse)

        'enable other controls
        UpdateDetailsBtn.Enabled = True
        ListVehiclesBtn.Enabled = True
        GetOnlyBalance.Enabled = True
        GetOnlyPostcode.Enabled = True

        Debug.Print(Now.Subtract(thistime).TotalMilliseconds.ToString)

    End Sub

    Private Sub UpdateDetailsBtn_Click(sender As Object, e As EventArgs) Handles UpdateDetailsBtn.Click
        If AccountMobilePhoneTxt.BackColor = Color.Aqua And FieldUpdate = True Then
            'update account detail via token
            If dca.AccountDetails.Update(dcaTokens.DetailToken.MobilePhone, AccountMobilePhoneTxt.Text) Then
                AccountMobilePhoneTxt.BackColor = Color.White
            Else
                MsgBox("Can not update telephone number")
                AccountFirstNameTxt.BackColor = Color.Orange
            End If
            FieldUpdate = False
        End If
    End Sub


    Private Sub ListVehiclesBtn_Click(sender As Object, e As EventArgs) Handles ListVehiclesBtn.Click

        'fill object with latest information
        dca.Vehicles.Refresh()

        'populate our datagrid with vehicle details
        dgv.Columns.Add("Reg", "RegReg")
        dgv.Columns.Add("CountryReg", "Country Reg")
        dgv.Columns.Add("VehClass", "VehClass")
        dgv.Columns.Add("Local", "Local?")
        dgv.Columns.Add("Make", "Make")
        dgv.Columns.Add("VehYear", "VehYear")
        dgv.Columns.Add("Colour", "Colour")
        dgv.Columns.Add("Model", "Model")

        For Each Vehicle As dcxapi.Vehicle In dca.Vehicles.Vehicle
            dgv.Rows.Add(Vehicle.RegistrationNumber,
                        Vehicle.CountryOfRegistration,
                        Vehicle.DartChargeClass, Vehicle.LocalResidence,
                        Vehicle.VehicleMake,
                        Vehicle.VehicleYear,
                        Vehicle.VehicleColour,
            Vehicle.VehicleModel)
        Next Vehicle

    End Sub

    Private Sub GetOnlyBalance_Click(sender As Object, e As EventArgs) Handles GetOnlyBalance.Click
        'picking one json token from the account details
        MsgBox(dca.AccountDetails.GetByToken(dcaTokens.DetailToken.CurrentBalance))
    End Sub

    Private Sub GetOnlyPostcode_Click(sender As Object, e As EventArgs) Handles GetOnlyPostcode.Click
        'picking one json token from account details under mailing address.
        MsgBox(dca.AccountDetails.GetByToken(dcaTokens.DetailToken.MailingAddress & "." & dcaTokens.DetailToken.Postcode))
    End Sub

    Private Sub AccountFirstNameTxt_Validated(sender As Object, e As EventArgs) Handles AccountFirstNameTxt.Validated
        If AccountFirstNameTxt.BackColor = Color.Aqua And FieldUpdate = True Then
            'updating account detail that cannot be changed
            If dca.AccountDetails.Update(dcaTokens.DetailToken.FirstName, AccountFirstNameTxt.Text) Then
                AccountFirstNameTxt.BackColor = Color.White
            Else
                MsgBox("It's not possible to update the first name")
                AccountFirstNameTxt.BackColor = Color.Orange
            End If
            FieldUpdate = False
        End If
    End Sub

    Private Sub AccountLastNameTxt_Validated(sender As Object, e As EventArgs) Handles AccountLastNameTxt.Validated
        If AccountLastNameTxt.BackColor = Color.Aqua And FieldUpdate = True Then
            'updating account detail that cannot be changed
            If dca.AccountDetails.Update(dcaTokens.DetailToken.LastName, AccountLastNameTxt.Text) Then
                AccountLastNameTxt.BackColor = Color.White
            Else
                MsgBox("It's not possible to update the last name")
                AccountFirstNameTxt.BackColor = Color.Orange
            End If
            FieldUpdate = False
        End If
    End Sub

    Private Sub AccountMobilePhoneTxt_Validated(sender As Object, e As EventArgs) Handles AccountMobilePhoneTxt.Validated
        If AccountMobilePhoneTxt.BackColor = Color.Aqua And FieldUpdate = True Then
            'update account detail via token
            If dca.AccountDetails.Update(dcaTokens.DetailToken.MobilePhone, AccountMobilePhoneTxt.Text) Then
                AccountMobilePhoneTxt.BackColor = Color.White
            Else
                MsgBox("Can not update telephone number")
                AccountFirstNameTxt.BackColor = Color.Orange
            End If
            FieldUpdate = False
        End If
    End Sub

    Private Sub AccountMobilePhoneTxt_GotFocus(sender As Object, e As EventArgs) Handles AccountMobilePhoneTxt.GotFocus
        AccountMobilePhoneTxt.BackColor = Color.Aqua
    End Sub

    Private Sub AccountLastNameTxt_GotFocus(sender As Object, e As EventArgs) Handles AccountLastNameTxt.GotFocus
        AccountLastNameTxt.BackColor = Color.Aqua
    End Sub

    Private Sub AccountFirstNameTxt_GotFocus(sender As Object, e As EventArgs) Handles AccountFirstNameTxt.GotFocus
        AccountFirstNameTxt.BackColor = Color.Aqua
    End Sub

    Private Sub SchemeRulesBtn_Click(sender As Object, e As EventArgs) Handles SchemeRulesBtn.Click
        MsgBox(dca.GetSchemeRules)
    End Sub

    Private Sub AccountMobilePhoneTxt_TextChanged(sender As Object, e As EventArgs) Handles AccountMobilePhoneTxt.TextChanged
        FieldUpdate = True
    End Sub

    Private Sub AccountLastNameTxt_TextChanged(sender As Object, e As EventArgs) Handles AccountLastNameTxt.TextChanged
        FieldUpdate = True
    End Sub

    Private Sub AccountFirstNameTxt_TextChanged(sender As Object, e As EventArgs) Handles AccountFirstNameTxt.TextChanged
        FieldUpdate = True
    End Sub
End Class
