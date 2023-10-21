Imports System.Xml.Serialization
Namespace Models

    <XmlRoot(ElementName:="activerun")>
    Public Class CommandActiveRun

        <XmlAttribute(AttributeName:="no")>
        Public Property RunNumber As Integer

    End Class
End Namespace
