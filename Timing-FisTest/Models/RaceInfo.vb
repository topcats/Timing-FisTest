Imports System.Xml.Serialization

Namespace Models
    <XmlRoot("raceinfo")>
    Public Class RaceInfo

        ''' <summary>
        ''' Event name displayed as title in the live animation 1st line title
        ''' </summary>
        <XmlElement(ElementName:="event")>
        Public Property EventTitle As String = String.Empty

        ''' <summary>
        ''' Future use
        ''' </summary>
        <XmlElement(ElementName:="name")>
        Public Property Name As String = String.Empty

        ''' <summary>
        ''' Slope name, Hill name (2nd line of title)
        ''' </summary>
        <XmlElement(ElementName:="slope")>
        Public Property Slope As String = String.Empty

        ''' <summary>
        ''' SL, GS, SG, DH, SC
        ''' </summary>
        ''' <returns></returns>
        <XmlElement(ElementName:="discipline")>
        Public Property DisciplineCode As String = String.Empty

        ''' <summary>
        ''' M,L or T
        ''' </summary>
        <XmlElement(ElementName:="gender")>
        Public Property GenderCode As String = String.Empty

        ''' <summary>
        ''' See FIS categories table
        ''' </summary>
        <XmlElement(ElementName:="category")>
        Public Property CategoryCode As String = String.Empty

        ''' <summary>
        ''' Location
        ''' </summary>
        <XmlElement(ElementName:="place")>
        Public Property Place As String = String.Empty

        ''' <summary>
        ''' The unit of the Temperature
        ''' </summary>
        ''' <returns>C fixed</returns>
        <XmlElement(ElementName:="tempunit")>
        Public Property TempUnit As String
            Get
                Return "C"
            End Get
            Set(value As String)

            End Set
        End Property

        ''' <summary>
        ''' Unit of length
        ''' </summary>
        ''' <returns>m fixed</returns>
        <XmlElement(ElementName:="longunit")>
        Public Property LongUnit As String
            Get
                Return "m"
            End Get
            Set(value As String)

            End Set
        End Property

        ''' <summary>
        ''' Unit of speed
        ''' </summary>
        ''' <returns>kmh fixed</returns>
        <XmlElement(ElementName:="speedunit")>
        Public Property SpeedUnit As String
            Get
                Return "kmh"
            End Get
            Set(value As String)

            End Set
        End Property

        <XmlElement(ElementName:="run")>
        Public Property RunInfos As List(Of RaceRunInfo)

    End Class
End Namespace
