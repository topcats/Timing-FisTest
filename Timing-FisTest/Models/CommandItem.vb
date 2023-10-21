Imports System.Xml.Serialization
Namespace Models

    <XmlRoot(ElementName:="command")>
    Public Class CommandItem

        <XmlElement(ElementName:="scheduled")>
        Public Property ScheduledItems As List(Of CommandScheduledItem)

        ''' <summary>
        ''' Clear all live data for current race codex
        ''' </summary>
        <XmlElement(ElementName:="clear")>
        Public Property Clear As String

        ''' <summary>
        ''' Run / round is finished
        ''' </summary>
        <XmlElement(ElementName:="endrun")>
        Public Property Endrun As String

        ''' <summary>
        ''' Status of the schedule for a run, (send approximately 5min before the start)
        ''' </summary>
        <XmlElement(ElementName:="readytostart")>
        Public Property ReadyToStart As String

        <XmlElement(ElementName:="activerun")>
        Public Property ActiveRun As CommandActiveRun

    End Class
End Namespace
