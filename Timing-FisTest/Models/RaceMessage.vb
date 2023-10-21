Imports System.Xml.Serialization
Namespace Models

    <XmlRoot(ElementName:="message")>
    Public Class RaceMessage

        <XmlElement(ElementName:="text")>
        Public Property Text As String = String.Empty

    End Class
End Namespace
