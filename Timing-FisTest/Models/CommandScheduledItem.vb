Imports System.Xml.Serialization
Namespace Models

    <XmlRoot(ElementName:="scheduled")>
    Public Class CommandScheduledItem

        <XmlAttribute(AttributeName:="runno")>
        Public Property RunNumber As Integer

        <XmlIgnore>
        Public Property RaceDate As Date

        <XmlElement(ElementName:="year")>
        Public Property RaceDateYear As String
            Get
                Return String.Format(RaceDate.Year, "0:0000")
            End Get
            Set(value As String)

            End Set
        End Property

        <XmlElement(ElementName:="month")>
        Public Property RaceDateMonth As String
            Get
                Return String.Format(RaceDate.Month, "0:00")
            End Get
            Set(value As String)

            End Set
        End Property

        <XmlElement(ElementName:="day")>
        Public Property RaceDateDay As String
            Get
                Return String.Format(RaceDate.Day, "0:00")
            End Get
            Set(value As String)

            End Set
        End Property

        <XmlElement(ElementName:="cettime")>
        Public Property CetTime As String = String.Empty

        <XmlElement(ElementName:="loctime")>
        Public Property LocTime As String = String.Empty

        <XmlElement(ElementName:="info")>
        Public Property RaceInfo As String = String.Empty

    End Class
End Namespace
