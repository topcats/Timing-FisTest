Imports System.Xml.Serialization
Namespace Models

    '<XmlRoot(ElementName:="run")>
    Public Class RaceRunInfo

        ''' <summary>
        ''' Run Number.
        ''' SG: not used, DH: used for run 1,2 in a 2 run race (not for training)
        ''' </summary>
        ''' <returns></returns>
        <XmlAttribute(AttributeName:="no")>
        Public Property RunNumber As Integer

        ''' <summary>
        ''' SL, GS, SG = Not Used.
        ''' DH: T1,T2,T3,T4 for training.
        ''' SC: SG, DH, SL
        ''' </summary>
        <XmlElement(ElementName:="discipline")>
        Public Property DisciplineCode As String = String.Empty

        ''' <summary>
        ''' Start altitude
        ''' </summary>
        <XmlElement(ElementName:="start")>
        Public Property StartHeight As Integer?

        ''' <summary>
        ''' Finish altitude
        ''' </summary>
        <XmlElement(ElementName:="finish")>
        Public Property FinishHeight As Integer?

        ''' <summary>
        ''' Vertical drop 
        ''' </summary>
        ''' <returns>Calculated automatically</returns>
        <XmlElement(ElementName:="height")>
        Public Property Height As Integer?
            Get
                Return StartHeight - FinishHeight
            End Get
            Set(value As Integer?)

            End Set
        End Property

        ''' <summary>
        ''' Slope length
        ''' </summary>
        <XmlElement(ElementName:="length", IsNullable:=True)>
        Public Property Length As Integer?

        ''' <summary>
        ''' Number of gates
        ''' </summary>
        <XmlElement(ElementName:="gates")>
        Public Property Gates As Integer?

        ''' <summary>
        ''' Number of turns (tech discipline)
        ''' </summary>
        <XmlElement(ElementName:="turninggates")>
        Public Property TurningGates As Integer?

        <XmlElement(ElementName:="racedef")>
        Public Property RaceDef As String = String.Empty

    End Class
End Namespace