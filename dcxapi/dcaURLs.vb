Module dcaURLs

    'Lets define our constant urls and paths for easier access & managment.
#Region "URLS & Paths"
    Friend Const base_url As String = "https://www.dartford-crossing-charge.service.gov.uk"
    Friend Const api_path As String = "/api/v1.0.0"
    Friend Const urlRules As String = "/payment/get_scheme_rules"
    Friend Const urlDetails As String = "/account/{0}"
    Friend Const urlVehicles As String = "/account/{0}/vehicles/"
#End Region

End Module
