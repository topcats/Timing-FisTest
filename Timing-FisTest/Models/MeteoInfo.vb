Imports System.Xml.Serialization
Namespace Models
    <XmlRoot("meteo")>
    Public Class MeteoInfo

        <XmlElement(ElementName:="weather")>
        Public Property WeatherCode As String = String.Empty

        <XmlElement(ElementName:="temperature")>
        Public Property Temperature As String = String.Empty

        <XmlElement(ElementName:="wind")>
        Public Property WindCode As String = String.Empty

        <XmlElement(ElementName:="snowcondition")>
        Public Property SnowConditionCode As String = String.Empty

    End Class
End Namespace