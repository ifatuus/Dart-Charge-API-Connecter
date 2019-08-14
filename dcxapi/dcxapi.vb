Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Public Class DartfordCrossingAPI

#Region "Public Objects"
    Public AccountDetails As dcAccountDetails
    Public Vehicles As dcVehicles
#End Region

#Region "Private Objects"

#End Region

#Region "Properties"
    Friend _Status As dcState

    ''' <summary>
    ''' Returns the status of the object e.g obtaining or updating account details.
    ''' </summary>
    Public ReadOnly Property Status As dcState
        Get
            Return _Status
        End Get
    End Property
#End Region

#Region "Main Subroutines and functions"

    'new object
    Public Sub New(api_key As String, account_number As String)
        'create the account details object with me as the root object class, and pass on the apikey and accountnumber for access.
        AccountDetails = New dcAccountDetails(Me, api_key, account_number)
        'create the vehicles object referenced to me
        Vehicles = New dcVehicles(Me)
    End Sub

    Public Sub GetVehiclesDetails()
        Dim wc As New WebClient()
        Dim VehicleDetailRequest As New Uri(base_url & api_path & String.Format(urlVehicles, Me.AccountDetails.AccountNumber))

        wc.Headers.Set("GET", String.Format(urlVehicles, Me.AccountDetails.AccountNumber))
        wc.Headers.Set("Authorization", "Basic " & Me.AccountDetails.API_KEY_B64)
        wc.Headers.Set("Content-Type", "application/json")

        Dim wcReply As String = wc.DownloadString(VehicleDetailRequest)
        Dim JsonReader As JsonTextReader = New JsonTextReader(New StringReader(wcReply))

        While JsonReader.Read
            If JsonReader.Value <> vbNullString Then
                Debug.Print("Token: " & JsonReader.TokenType.ToString & "  Value: " & JsonReader.Value)
            Else
                Debug.Print(JsonReader.TokenType.ToString)
            End If

        End While
    End Sub

    Public Function UpdateAccountDetails(phone_1 As String, low_balance_threshold As Integer, top_up_amount As Integer, mobile_phone As String) As Boolean
        Try
            'checks
            If phone_1 = vbNullString Then
                Throw New ArgumentException("the phone_1 field is mandatory and can not be the value of null")
            End If
            If low_balance_threshold < 10 Then
                Throw New ArgumentException("low balance threshold can be a minimum value of 10")
            End If
            If top_up_amount < 10 Then
                Throw New ArgumentException("top up amount can be a minimum value of 10")
            End If

            Dim wc As New WebClient()
            'base64 our key for auth
            Dim UpdateAccountDetail As New Uri(base_url & api_path & String.Format(urlDetails, Me.AccountDetails.AccountNumber))

            wc.Headers.Set("Authorization", "Basic " & Me.AccountDetails.API_KEY_B64)
            wc.Headers.Set("Content-Type", "application/json")

            Dim BuiltRequest As New StringBuilder
            Dim WriteRequest As New StringWriter(BuiltRequest)
            Dim JsonWriter As JsonTextWriter = New JsonTextWriter(WriteRequest)

            JsonWriter.WriteStartObject()
            JsonWriter.WritePropertyName("phone_1")
            JsonWriter.WriteValue(phone_1)
            JsonWriter.WritePropertyName("low_balance_threshold")
            JsonWriter.WriteValue(low_balance_threshold)
            JsonWriter.WritePropertyName("top_up_amount")
            JsonWriter.WriteValue(top_up_amount)
            JsonWriter.WritePropertyName("mobile_phone")
            JsonWriter.WriteValue(mobile_phone)
            JsonWriter.WriteEndObject()

            Dim wcReply As String = wc.UploadString(UpdateAccountDetail, "PUT", BuiltRequest.ToString)

            Debug.Print(BuiltRequest.ToString)
            Debug.Print(wcReply)

            If wcReply = "true" Then Return True Else Return False

        Catch Err As Exception
            MsgBox(Err.Message)

            Return False
        End Try
    End Function

    'Get rules
    '''Getting Scheme Rules
    '''No API Key Required Here
    '''
    Public Function GetSchemeRules() As String
        Dim wc As New WebClient()

        Dim RequestUrl As New Uri(base_url & api_path & String.Format(urlRules))

        Dim wcReply As String = wc.DownloadString(RequestUrl)

        Dim JsonReader As JsonTextReader = New JsonTextReader(New StringReader(wcReply))
        Dim BuildReply As StringBuilder = New StringBuilder()

        While JsonReader.Read
            If JsonReader.Value <> vbNullString Then
                If JsonReader.TokenType.ToString.Contains("String") Then BuildReply.Append(JsonReader.Value)
                Debug.Print("Token: " & JsonReader.TokenType.ToString & "  Value: " & JsonReader.Value)
                Else
                    BuildReply.Append(JsonReader.TokenType.ToString)
                Debug.Print(JsonReader.TokenType.ToString)
            End If
            BuildReply.AppendLine()
        End While
        GetSchemeRules = BuildReply.ToString
    End Function

#End Region

End Class
