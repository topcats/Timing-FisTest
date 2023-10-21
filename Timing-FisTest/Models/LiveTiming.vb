Imports System.Xml.Serialization
Namespace Models

    <XmlRoot(ElementName:="livetiming")>
    Public Class LiveTiming
        <XmlAttribute(AttributeName:="codex")>
        Public Property Codex As Integer

        <XmlAttribute(AttributeName:="passwd")>
        Public Property Password As String

        <XmlAttribute(AttributeName:="sequence")>
        Public Property Sequence As String
            Get
                Return String.Format("{0:00000}", Me.SequenceNo)
            End Get
            Set(value As String)

            End Set
        End Property

        <XmlIgnore>
        Public Property SequenceNo As Integer

        <XmlAttribute(AttributeName:="timestamp")>
        Public Property Timestamp As String
            Get
                Return Now.ToString("HH:mm:ss")
            End Get
            Set(value As String)

            End Set
        End Property



        <XmlElement("raceinfo")>
        Public Property RaceInfoItem As RaceInfo

        <XmlElement("command")>
        Public Property CommandInfoItem As CommandItem

        <XmlElement("meteo")>
        Public Property MeteoInfoItem As MeteoInfo

        <XmlElement("message")>
        Public Property RaceMessageItem As RaceMessage

    End Class

End Namespace
