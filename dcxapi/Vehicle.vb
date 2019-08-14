Imports Newtonsoft.Json

Public Class VehicleList
    Public Vehicles() As Vehicle
End Class


Public Class Vehicle

#Region "Vehicle Properties"
    <JsonProperty("country_of_registration")>
    Friend Property country_of_registration As String
    <JsonProperty("licence_plate_number")>
    Friend Property licence_plate_number As String
    <JsonProperty("dart_charge_vehicle_class")>
    Friend Property dart_charge_vehicle_class As String
    <JsonProperty("vehicle_colour")>
    Friend Property vehicle_colour As String
    <JsonProperty("vehicle_make")>
    Friend Property vehicle_make As String
    <JsonProperty("vehicle_model")>
    Friend Property vehicle_model As String
    <JsonProperty("vehicle_year")>
    Friend Property vehicle_year As String
    <JsonProperty("local_residents_scheme")>
    Friend Property local_residents_scheme As Boolean
#End Region

#Region "Vehicle Properties gets and sets"

    ''' <summary>
    ''' Registration number of the vehicle.
    ''' </summary>
    ''' <returns></returns>
    Public Property RegistrationNumber As String
        Get
            Return licence_plate_number
        End Get
        Friend Set(value As String)
            licence_plate_number = value
        End Set
    End Property

    ''' <summary>
    ''' Country of where the vehicle is registered to.
    ''' </summary>
    ''' <returns></returns>
    Public Property CountryOfRegistration As String
        Get
            Return country_of_registration
        End Get
        Friend Set(value As String)
            country_of_registration = value
        End Set
    End Property

    ''' <summary>
    ''' Rated class by dart-charge.
    ''' </summary>
    ''' <returns></returns>
    Public Property DartChargeClass As String
        Get
            Return dart_charge_vehicle_class
        End Get
        Friend Set(value As String)
            dart_charge_vehicle_class = value
        End Set
    End Property

    ''' <summary>
    ''' Colour of the vehicle.
    ''' </summary>
    ''' <returns></returns>
    Public Property VehicleColour As String
        Get
            Return vehicle_colour
        End Get
        Friend Set(value As String)
            vehicle_colour = value
        End Set
    End Property

    ''' <summary>
    ''' Vehicle make.
    ''' </summary>
    ''' <returns></returns>
    Public Property VehicleMake As String
        Get
            Return vehicle_make
        End Get
        Friend Set(value As String)
            vehicle_make = value
        End Set
    End Property

    ''' <summary>
    ''' Vehicle model.
    ''' </summary>
    ''' <returns></returns>
    Public Property VehicleModel As String
        Get
            Return vehicle_model
        End Get
        Friend Set(value As String)
            vehicle_model = value
        End Set
    End Property

    ''' <summary>
    ''' Year vehicle was registered.
    ''' </summary>
    ''' <returns></returns>
    Public Property VehicleYear As String
        Get
            Return vehicle_year
        End Get
        Friend Set(value As String)
            vehicle_year = value
        End Set
    End Property

    ''' <summary>
    ''' Check wether the vehicle is part of the local residence scheme.
    ''' </summary>
    ''' <returns></returns>
    Public Property LocalResidence As Boolean
        Get
            Return local_residents_scheme
        End Get
        Friend Set(value As Boolean)
            local_residents_scheme = value
        End Set
    End Property

#End Region

End Class
