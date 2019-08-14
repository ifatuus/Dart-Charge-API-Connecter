#Region "Imports"
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports dcxapi.DartfordCrossingAPI.dcaTokens
Imports System.IO
#End Region

'Account Details Class
''' <summary>
''' Account Details Object
''' </summary>
''' 

Public Class dcAccountDetails

    Dim dca As DartfordCrossingAPI

#Region "Account Properties"
    Private _APIKEY
    Private _AccountNumber As String
    Private _AccountType As dcAccountType
    Private _AccountStatus As String
    Private _TopUpMethod As String
    Private _CompanyName As String
    Private _CurrentBalance As Decimal
    Private _FirstName As String
    Private _LastName As String
    Private _FullName As String
    Private _Phone1 As String
    Private _Phone2 As String
    Private _Email As String
    Private _Address1 As String
    Private _Address2 As String
    Private _Address3 As String
    Private _City As String
    Private _Country As String
    Private _Postcode As String
    Private _MobilePhone As String
    Private _AutoTopUp As Boolean
    Private _LocalResidencyApprovalStatus As Boolean
    Private _LowBalanceThreshold As Long
    Private _AccountOpenDate As Date
    Private _AutoTopUpAmount As Long
    Private _LastResponseData As String
#End Region

#Region "Read Only Properties Gets and Sets"
    ''' <summary>
    ''' Returns the account number tied to this account.
    ''' </summary>
    Public ReadOnly Property AccountNumber As String
        Get
            Return _AccountNumber
        End Get
    End Property

    ''' <summary>
    ''' Returns the API key of this account.
    ''' </summary>
    Public ReadOnly Property API_KEY As String
        Get
            Return _APIKEY
        End Get
    End Property

    ''' <summary>
    ''' Returns the API key of this account as BASE64.
    ''' </summary>
    Friend ReadOnly Property API_KEY_B64 As String
        Get
            Return Convert.ToBase64String(Encoding.UTF8.GetBytes(_APIKEY))
        End Get
    End Property

    ''' <summary>
    ''' Returns account status.
    ''' </summary>
    Public ReadOnly Property AccountType As dcAccountType
        Get
            Return _AccountType
        End Get
    End Property

    ''' <summary>
    ''' Returns account status.
    ''' </summary>
    Public ReadOnly Property AccountStatus As String
        Get
            Return _AccountStatus
        End Get
    End Property

    ''' <summary>
    ''' Returns the top up method associated with this account.
    ''' </summary>
    Public ReadOnly Property TopUpMethod As String
        Get
            Return _TopUpMethod
        End Get
    End Property

    ''' <summary>
    ''' Returns the company name on this account.
    ''' </summary>
    Public ReadOnly Property CompanyName As String
        Get
            Return _CompanyName
        End Get
    End Property

    ''' <summary>
    ''' Returns the current balance of this account.
    ''' </summary>
    Public ReadOnly Property CurrentBalance As Decimal
        Get
            Return _CurrentBalance
        End Get
    End Property

    ''' <summary>
    ''' Returns the first name of the contact on this account.
    ''' </summary>
    Public ReadOnly Property FirstName As String
        Get
            Return _FirstName
        End Get
    End Property

    ''' <summary>
    ''' Returns the last name of the contact on this account.
    ''' </summary>
    Public ReadOnly Property LastName As String
        Get
            Return _LastName
        End Get
    End Property

    ''' <summary>
    ''' Returns the full name of the contact on this account.
    ''' </summary>
    Public ReadOnly Property FullName As String
        Get
            Return _FullName
        End Get
    End Property

    ''' <summary>
    ''' Returns the primary phone number on this account.
    ''' </summary>
    Public ReadOnly Property Phone1 As String
        Get
            Return _Phone1
        End Get
    End Property

    ''' <summary>
    ''' Returns the secondary phone number on this account.
    ''' </summary>
    Public ReadOnly Property Phone2 As String
        Get
            Return _Phone2
        End Get
    End Property

    ''' <summary>
    ''' Returns the email address for this account.
    ''' </summary>
    Public ReadOnly Property EmailAddress As String
        Get
            Return _Email
        End Get
    End Property

    ''' <summary>
    ''' Returns the first line of the address on this account.
    ''' </summary>
    Public ReadOnly Property Address1 As String
        Get
            Return _Address1
        End Get
    End Property

    ''' <summary>
    ''' Returns the second line of the address on this account.
    ''' </summary>
    Public ReadOnly Property Address2 As String
        Get
            Return _Address2
        End Get
    End Property

    ''' <summary>
    ''' Returns the third line of the address on this account.
    ''' </summary>
    Public ReadOnly Property Address3 As String
        Get
            Return _Address3
        End Get
    End Property

    ''' <summary>
    ''' Returns the first line of the address on this account.
    ''' </summary>
    Public ReadOnly Property City As String
        Get
            Return _City
        End Get
    End Property

    ''' <summary>
    ''' Returns the first line of the address on this account.
    ''' </summary>
    Public ReadOnly Property Country As String
        Get
            Return _Country
        End Get
    End Property

    ''' <summary>
    ''' Returns the postcode on this account.
    ''' </summary>
    Public ReadOnly Property Postcode As String
        Get
            Return _Postcode
        End Get
    End Property

    ''' <summary>
    ''' Returns the mobile phone number associated with this account.
    ''' </summary>
    Public ReadOnly Property MobilePhone As String
        Get
            Return _MobilePhone
        End Get
    End Property

    ''' <summary>
    ''' Returns if the account balance is auto topped up.
    ''' </summary>
    Public ReadOnly Property AutoTopUp As Boolean
        Get
            Return _AutoTopUp
        End Get
    End Property

    ''' <summary>
    ''' Returns if this account has the local resident approval status.
    ''' </summary>
    Public ReadOnly Property LocalResident As Boolean
        Get
            Return _LocalResidencyApprovalStatus
        End Get
    End Property

    ''' <summary>
    ''' Returns the low balance account threshold before the account auto tops up.
    ''' </summary>
    Public ReadOnly Property LowBalanceThreshold As Long
        Get
            Return _LowBalanceThreshold
        End Get
    End Property

    ''' <summary>
    ''' Returns the date the account was initially opened.
    ''' </summary>
    Public ReadOnly Property AccountOpenDate As Date
        Get
            Return _AccountOpenDate
        End Get
    End Property

    ''' <summary>
    ''' Returns the amount the account should top up when reaching the low balance threshold.
    ''' </summary>
    Public ReadOnly Property AutoTopUpAmount As Long
        Get
            Return _AutoTopUpAmount
        End Get
    End Property

    ''' <summary>
    ''' Returns the Json Data from the last account detail refresh.
    ''' </summary>
    Public ReadOnly Property Reponse As String
        Get
            Return _LastResponseData
        End Get
    End Property
#End Region

#Region "Custom Details Types"
    Enum dcAccountType
        BUSINESS
        RESIDENTIAL
    End Enum
#End Region

#Region "Sub Routines & Functions"

    'New Object
    ''' <summary>
    ''' Create a new Account Details Object for use with the DCXAPI
    ''' </summary>
    ''' <param name="dcaBase">Reference to the root object class</param>
    ''' <param name="api_key">API key for the account</param>
    ''' <param name="account_number">account number</param>
    Sub New(ByRef dcaBase As DartfordCrossingAPI, api_key As String, account_number As String)
        dca = dcaBase
        _AccountNumber = account_number
        _APIKEY = api_key
        dca._Status = dcState.Idle
    End Sub

    'Refresh
    ''' <summary>
    ''' Refresh Account Details Data
    ''' </summary>
    Public Sub Refresh()
        Try
            'declare new webclient for use with refresh
            Dim wc As New WebClient()
            Dim AccountDetailRequest As New Uri(dcaURLs.base_url & dcaURLs.api_path & String.Format(dcaURLs.urlDetails, AccountNumber))

            'change the status of the object to refreshing details
            dca._Status = dcState.RefreshingAccountDetails

            'use basic authorization and be kind
            wc.Headers.Set("Authorization", "Basic " & API_KEY_B64)
            wc.Headers.Set("Content-Type", "application/json")

            'declare new string to store json content temporarily
            Dim wcReply As String = wc.DownloadString(AccountDetailRequest)

            'received data into here for pull custom properties
            Dim JsonDeserial As JObject = JsonConvert.DeserializeObject(wcReply)

            'Store our response data in new variable incase we want to use it later
            _LastResponseData = wcReply

            'load default properties
            _AccountStatus = JsonDeserial.SelectToken(DetailToken.AccountStatus)
            If JsonDeserial.SelectToken(DetailToken.AccountType) = "BUSINESS" Then _AccountType = dcAccountType.BUSINESS Else _AccountType = dcAccountType.RESIDENTIAL
            _TopUpMethod = JsonDeserial.SelectToken(DetailToken.TopUpMethod)
            _CompanyName = JsonDeserial.SelectToken(DetailToken.CompanyName)
            _CurrentBalance = JsonDeserial.SelectToken(DetailToken.CurrentBalance)
            _FirstName = JsonDeserial.SelectToken(DetailToken.FirstName)
            _LastName = JsonDeserial.SelectToken(DetailToken.LastName)
            _FullName = JsonDeserial.SelectToken(DetailToken.FullName)
            _Phone1 = JsonDeserial.SelectToken(DetailToken.Phone1)
            _Phone2 = JsonDeserial.SelectToken(DetailToken.Phone2)
            _Email = JsonDeserial.SelectToken(DetailToken.Email)
            _Address1 = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.Address1)
            _Address2 = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.Address2)
            _Address3 = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.Address3)
            _City = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.City)
            _Country = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.Country)
            _Postcode = JsonDeserial.SelectToken(DetailToken.MailingAddress).SelectToken(DetailToken.Postcode)
            _MobilePhone = JsonDeserial.SelectToken(DetailToken.MobilePhone)
            _AutoTopUp = JsonDeserial.SelectToken(DetailToken.AutoTopUp)
            If JsonDeserial.SelectToken(DetailToken.LocalResidentApproval) = "Not local resident" Then _LocalResidencyApprovalStatus = False Else _LocalResidencyApprovalStatus = True
            _LowBalanceThreshold = JsonDeserial.SelectToken(DetailToken.LowBalanceThreshold)
            _AccountOpenDate = JsonDeserial.SelectToken(DetailToken.AccountOpenDate)
            _AutoTopUpAmount = JsonDeserial.SelectToken(DetailToken.AutoTopUpAmount)

            'change the status of the main object back to idle
            If dca._Status = dcState.RefreshingAccountDetails Then dca._Status = dcState.Idle
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Get By Json Token
    ''' <summary>
    ''' Retrieve a custom token from the root Json data returned.
    ''' You can use dcaTokens.DetailToken for a list of known account detail tokens.
    ''' </summary>
    ''' <param name="Token_Name">Token Name of the JSON</param>
    ''' <returns></returns>
    Public Function GetByToken(ByVal Token_Name As String)
        Try
            Dim JsonDeserial As JObject = JsonConvert.DeserializeObject(_LastResponseData)
            Return JsonDeserial.SelectToken(Token_Name)
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    'Update Detail
    ''' <summary>
    ''' Update account details for the given token with a specific value.
    ''' You can use dcaTokens.DetailToken for a list of known account detail tokens.
    ''' </summary>
    ''' <param name="update_detail">Account Detail Json Token.</param>
    ''' <param name="detail_value">The value to set on the account.</param>
    ''' <returns>Returns true if details were updated successfully.</returns>
    Public Function Update(ByVal update_detail, ByVal detail_value) As Boolean
        Try
            dca._Status = dcState.UpdatingAccountDetails
            Dim isAddress As Boolean = False
            'checks
            Select Case update_detail
                Case DetailToken.Phone1
                    If update_detail.ToString = vbNullString Then
                        Throw New ArgumentException("the phone_1 field is mandatory and can not be the value of null")
                    End If
                Case DetailToken.LowBalanceThreshold
                    If CInt(detail_value) < 10 Then
                        Throw New ArgumentException("low balance threshold can be a minimum value of 10")
                    End If
                Case DetailToken.TopUpMethod
                    If CInt(detail_value) < 10 Then
                        Throw New ArgumentException("top up amount can be a minimum value of 10")
                    End If
                Case DetailToken.Address1, DetailToken.Address2, DetailToken.Address3
                    isAddress = True
            End Select

            'start our request
            Dim wc As New WebClient()
            Dim UpdateAccountDetail As New Uri(base_url & api_path & String.Format(urlDetails, AccountNumber))

            wc.Headers.Set("Authorization", "Basic " & API_KEY_B64)
            wc.Headers.Set("Content-Type", "application/json")

            Dim BuiltRequest As New StringBuilder
            Dim WriteRequest As New StringWriter(BuiltRequest)
            Dim JsonWriter As JsonTextWriter = New JsonTextWriter(WriteRequest)


            If isAddress Then JsonWriter.WriteStartConstructor(DetailToken.MailingAddress)
            JsonWriter.WriteStartObject()
            JsonWriter.WritePropertyName(update_detail)
            JsonWriter.WriteValue(detail_value)
            JsonWriter.WriteEndObject()
            If isAddress Then JsonWriter.WriteEndConstructor()


            Dim wcReply As String = wc.UploadString(UpdateAccountDetail, "PUT", BuiltRequest.ToString)

            Debug.Print(BuiltRequest.ToString)
            Debug.Print(wcReply)

            If wcReply = "true" Then Return True Else Return False
            dca._Status = dcState.Idle
        Catch ex As Exception
            MsgBox(ex.Message)
            dca._Status = dcState.Idle
            Return False
        End Try
    End Function

#End Region

End Class
