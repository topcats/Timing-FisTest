Imports System.Xml.Serialization
Namespace Models
    <XmlRoot("meteo")>
    Public Class MeteoInfo

        ''' <summary>
        ''' Weather Code, suggest using <see cref="SetWeather"/>
        ''' </summary>
        <XmlElement(ElementName:="weather")>
        Public Property WeatherCode As String = String.Empty

        ''' <summary>
        ''' Air Temperature
        ''' </summary>
        <XmlElement(ElementName:="temperature")>
        Public Property Temperature As String = String.Empty

        ''' <summary>
        ''' Wind code, suggest using <see cref="SetWind"/>
        ''' </summary>
        <XmlElement(ElementName:="wind")>
        Public Property WindCode As String = String.Empty

        ''' <summary>
        ''' Snow Temperature
        ''' </summary>
        <XmlElement(ElementName:="snowtemperature")>
        Public Property SnowTemperature As String = String.Empty

        <XmlElement(ElementName:="snowcondition")>
        Public Property SnowConditionCode As String = String.Empty

        ''' <summary>
        ''' Humidity (percentage)
        ''' </summary>
        <XmlElement(ElementName:="humidity")>
        Public Property Humidity As String = String.Empty


        ''' <summary>
        ''' Set Wind Code
        ''' </summary>
        ''' <param name="value">Wind</param>
        Public Sub SetWind(ByVal value As Enums.WeatherWind)
            Select Case value
                Case Enums.WeatherWind.None
                    Me.WindCode = "no"

                Case Enums.WeatherWind.Low
                    Me.WindCode = "lo"

                Case Enums.WeatherWind.Medium
                    Me.WindCode = "me"

                Case Enums.WeatherWind.Strong
                    Me.WindCode = "hi"

                Case Else
                    Me.WindCode = String.Empty

            End Select

        End Sub


        ''' <summary>
        ''' Set Weather Code
        ''' </summary>
        ''' <param name="value">Weather</param>
        Public Sub SetWeather(ByVal value As Enums.WeatherCodes)
            Select Case value
                Case Enums.WeatherCodes.Sunny
                    Me.WeatherCode = "sun"

                Case Enums.WeatherCodes.PartiallyCloudy
                    Me.WeatherCode = "pcl"

                Case Enums.WeatherCodes.Cloudy
                    Me.WeatherCode = "clo"

                Case Enums.WeatherCodes.Snowing
                    Me.WeatherCode = "sno"

                Case Enums.WeatherCodes.Raining
                    Me.WeatherCode = "rai"

                Case Enums.WeatherCodes.Foggy
                    Me.WeatherCode = "fog"

                Case Enums.WeatherCodes.ClearNight
                    Me.WeatherCode = "clr"

                Case Else
                    Me.WeatherCode = String.Empty

            End Select
        End Sub


        Public Sub SetSnow(ByVal value As Enums.WeatherSnow)
            Select Case value
                Case Enums.WeatherSnow.Soft
                    Me.SnowConditionCode = "sft"

                Case Enums.WeatherSnow.WetPowder
                    Me.SnowConditionCode = "wt-pwd"

                Case Enums.WeatherSnow.Wet
                    Me.SnowConditionCode = "wt"

                Case Enums.WeatherSnow.Compact
                    Me.SnowConditionCode = "cmp"

                Case Enums.WeatherSnow.FineGrained
                    Me.SnowConditionCode = "f_g"

                Case Enums.WeatherSnow.Granular
                    Me.SnowConditionCode = "grn"

                Case Enums.WeatherSnow.Hard
                    Me.SnowConditionCode = "hrd"

                Case Enums.WeatherSnow.HardPacked
                    Me.SnowConditionCode = "hrd_p"

                Case Enums.WeatherSnow.HardPackedVariable
                    Me.SnowConditionCode = "hrd_p_v"

                Case Enums.WeatherSnow.Icy
                    Me.SnowConditionCode = "icy"

                Case Enums.WeatherSnow.Packed
                    Me.SnowConditionCode = "p"

                Case Enums.WeatherSnow.PackedPowder
                    Me.SnowConditionCode = "ppwd"

                Case Enums.WeatherSnow.Powder
                    Me.SnowConditionCode = "pwd"

                Case Enums.WeatherSnow.SpringConditions
                    Me.SnowConditionCode = "sp_c"

                Case Enums.WeatherSnow.Salted
                    Me.SnowConditionCode = "salt"

                Case Else
                    Me.SnowConditionCode = String.Empty
            End Select
        End Sub
    End Class
End Namespace