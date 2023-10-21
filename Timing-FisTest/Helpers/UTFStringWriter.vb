Imports System.IO
Imports System.Text

Namespace Helpers
    Public Class UTFStringWriter
        Inherits StringWriter

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Encoding.UTF8
            End Get
        End Property

    End Class

End Namespace