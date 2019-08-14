#Region "Imports"
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
#End Region

Public Class dcVehicles

    Dim dca As DartfordCrossingAPI

#Region "Properties"

    Private Property _Vehicles As VehicleList

    Public ReadOnly Property Vehicle As Vehicle()
        Get
            Return _Vehicles.Vehicles
        End Get
    End Property
#End Region

#Region "Subs and Functions"

    ''' <summary>
    '''  New Vehicles List
    ''' </summary>
    ''' <param name="dcaBase"></param>
    Sub New(ByRef dcaBase As DartfordCrossingAPI)
        dca = dcaBase
        Me.Refresh()
    End Sub

    ''' <summary>
    ''' Get vehicle by registration number.
    ''' </summary>
    ''' <param name="RegistrationNumber"></param>
    ''' <returns></returns>
    Public Function GetByReg(ByVal RegistrationNumber As String) As Vehicle
        Try
            Return _Vehicles.Vehicles.Where(Function(token) token.RegistrationNumber = RegistrationNumber).Single
        Catch ex As Exception

            Debug.Print(ex.Message & " " & ex.HelpLink)
            Return New Vehicle()
        End Try
    End Function

    ''' <summary>
    ''' Refreshes Vehicle Data.
    ''' </summary>
    Public Sub Refresh()
        Try
            dca._Status = dcState.GettingVehicleDetails
            Dim wc As New WebClient()
            Dim VehicleDetailRequest As New Uri(base_url & api_path & String.Format(dcaURLs.urlVehicles, dca.AccountDetails.AccountNumber))

            wc.Headers.Set("Authorization", "Basic " & dca.AccountDetails.API_KEY_B64)
            wc.Headers.Set("Content-Type", "application/json")

            'declare new string to store json content temporarily
            Dim wcReply As String = wc.DownloadString(VehicleDetailRequest)

            'received data into here vehicle object
            Dim jsSettings As JsonSerializerSettings
            jsSettings = New JsonSerializerSettings()
            jsSettings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            _Vehicles = JsonConvert.DeserializeObject(Of VehicleList)(wcReply, jsSettings) ' Deserialize array of vehicles
            dca._Status = dcState.Idle
        Catch ex As Exception
            MsgBox(ex.Message)
            dca._Status = dcState.Idle
        End Try
    End Sub

#End Region

End Class
