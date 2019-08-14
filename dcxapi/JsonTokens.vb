Partial Public Class DartfordCrossingAPI 'yes i know partials, don't kill me

    Public Class dcaTokens

        'Keeping an object with our translated JSON tokens is easier for the user. (arguably not bad practice)
#Region "Account Detail Json Tokens"
        'Json Tokens For Account Details
        ''' <summary>
        ''' The account details json tokens.
        ''' </summary>
        Public Class DetailToken
            Public Const AccountType = "account_type"
            Public Const AccountStatus = "account_status"
            Public Const TopUpMethod = "top_up_method"
            Public Const CompanyName = "company_name"
            Public Const CurrentBalance = "current_balance"
            Public Const FirstName = "first_name"
            Public Const LastName = "last_name"
            Public Const FullName = "full_name"
            Public Const Phone1 = "phone_1"
            Public Const Phone2 = "phone_2"
            Public Const Email = "email"
            Public Const MailingAddress = "mailing_address"
            Public Const Address1 = "address_1"
            Public Const Address2 = "address_2"
            Public Const Address3 = "address_3"
            Public Const City = "city"
            Public Const Country = "country"
            Public Const Postcode = "postcode"
            Public Const MobilePhone = "mobile_phone"
            Public Const AutoTopUp = "auto_top_up"
            Public Const LocalResidentApproval = "local_residency_approval_status"
            Public Const LowBalanceThreshold = "low_balance_threshold"
            Public Const AccountOpenDate = "account_open_date"
            Public Const AutoTopUpAmount = "top_up_amount"
        End Class
#End Region


    End Class

End Class