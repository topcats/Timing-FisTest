Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Xml.Serialization
Imports Timing_FisTest.Helpers

Public Class Form1
    Private Sub cmdSendIt_Click(sender As Object, e As EventArgs) Handles cmdSendIt.Click
        Dim isAvailable = My.Computer.Network.IsAvailable


        If Not isAvailable Then
            Me.txtInData.Text = "NO NETWORK"
        Else


            Try

                Dim oClient As New TcpClient(Me.txtSetServer.Text, CInt(Me.txtSetPort.Text)) With {
                    .SendTimeout = 5000,
                    .ReceiveTimeout = 10000
                }


                'Set Output Message
                Me.txtOutData.Text = Me.txtOutData.Text.Replace("###CODEX###", Me.txtSetCodex.Text)
                Me.txtOutData.Text = Me.txtOutData.Text.Replace("###PASSWORD###", Me.txtSetPassword.Text)
                Me.txtOutSeq.Text = String.Format("{0:00000}", CInt(Me.txtOutSeq.Text) + 1)
                Me.txtOutData.Text = Me.txtOutData.Text.Replace("###SEQ###", Me.txtOutSeq.Text)
                Me.txtOutData.Text = Me.txtOutData.Text.Replace("###TIME###", Now.ToString("HH:mm:ss"))

                Dim data As [Byte]() = System.Text.Encoding.UTF8.GetBytes(Me.txtOutData.Text)

                ' Get a client stream for reading and writing.
                '  Stream stream = client.GetStream();
                Dim oStream As NetworkStream = oClient.GetStream()

                ' Send the message to the connected TcpServer. 
                oStream.Write(data, 0, data.Length)

                WriteLog(String.Format("Sent: {0}", data.Length))

                ' Receive the TcpServer.response.
                ' Buffer to store the response bytes.
                data = New [Byte](256) {}

                ' String to store the response ASCII representation.
                Dim responseData As String = String.Empty

                ' Read the first batch of the TcpServer response bytes.
                Dim bytes As Int32 = oStream.Read(data, 0, data.Length)
                responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes)
                WriteLog(String.Format("Received: {0}", responseData))

                ' Close everything.
                oStream.Close()
                oClient.Close()

            Catch ex As ArgumentNullException
                WriteLog(String.Format("ArgumentNullException: {0}", ex))
            Catch ex As SocketException
                WriteLog(String.Format("SocketException: {0}", ex))
            Catch ex As Exception
                WriteLog(String.Format("Exception: {0}", ex))

            End Try


        End If

    End Sub



    Protected Sub WriteLog(ByVal intext As String)
        Me.txtInData.Text = intext & vbNewLine & Me.txtInData.Text

    End Sub

    Private Sub txtInData_DoubleClick(sender As Object, e As EventArgs) Handles txtInData.DoubleClick
        Me.txtInData.Text = ""
    End Sub

    Private Sub cmdLoadInitial_Click(sender As Object, e As EventArgs) Handles cmdLoadInitial.Click
        Me.txtOutData.Text = My.Resources.LoadInitial

    End Sub

    Private Sub cmdLoadStartList_Click(sender As Object, e As EventArgs) Handles cmdLoadStartList.Click
        Me.txtOutData.Text = My.Resources.LoadStartList
    End Sub

    Private Sub cmdLoadRaceInfo_Click(sender As Object, e As EventArgs) Handles cmdLoadRaceInfo.Click
        Me.txtOutData.Text = My.Resources.LoadRaceInfo

    End Sub

    Private Sub cmdRaceEventStarted_Click(sender As Object, e As EventArgs) Handles cmdRaceEventStarted.Click
        Me.txtOutData.Text = My.Resources.LoadRaceEventStarted
    End Sub

    Private Sub cmdRaceEventDNS_Click(sender As Object, e As EventArgs) Handles cmdRaceEventDNS.Click
        Me.txtOutData.Text = My.Resources.LoadRaceEventDNS

    End Sub

    Private Sub cmdRaceEventDNF_Click(sender As Object, e As EventArgs) Handles cmdRaceEventDNF.Click
        Me.txtOutData.Text = My.Resources.LoadRaceEventDNF

    End Sub

    Private Sub cmdRaceEventDSQ_Click(sender As Object, e As EventArgs) Handles cmdRaceEventDSQ.Click
        Me.txtOutData.Text = My.Resources.LoadRaceEventDSQ

    End Sub

    Private Sub cmdRaceEventTime_Click(sender As Object, e As EventArgs) Handles cmdRaceEventTime.Click
        Me.txtOutData.Text = My.Resources.LoadRaceEventTime

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim bob = New Models.LiveTiming() With {
            .Codex = "9766",
            .Password = "2wsx5TGB",
            .SequenceNo = 2
        }

        bob.RaceInfoItem = New Models.RaceInfo() With {
            .EventTitle = "TC Test Again XML",
            .DisciplineCode = "DH",
            .GenderCode = "M",
            .CategoryCode = "FIS",
            .Slope = "Tignes, Stade",
            .Place = "Tignes, FRA"
        }

        bob.RaceInfoItem.RunInfos = New List(Of Models.RaceRunInfo) From {
            New Models.RaceRunInfo() With {
                                      .RunNumber = 1,
                                      .StartHeight = 2100,
                                      .FinishHeight = 2001,
                                      .Gates = 40,
                                      .TurningGates = 38},
            New Models.RaceRunInfo() With {
                                      .RunNumber = 2,
                                      .StartHeight = 2100,
                                      .FinishHeight = 2001,
                                      .Gates = 39,
                                      .TurningGates = 37}
        }

        bob.CommandInfoItem = New Models.CommandItem()
        bob.CommandInfoItem.ScheduledItems = New List(Of Models.CommandScheduledItem) From {
            New Models.CommandScheduledItem() With {
                                      .RunNumber = 1,
                                      .RaceDate = New Date(2018, 4, 1),
                                      .CetTime = "18:30",
                                      .LocTime = "10:00",
                                      .RaceInfo = String.Empty},
            New Models.CommandScheduledItem() With {
                                      .RunNumber = 2,
                                      .RaceDate = New Date(2018, 4, 1),
                                      .CetTime = "20:30",
                                      .LocTime = "12:00",
                                      .RaceInfo = String.Empty}
        }

        bob.MeteoInfoItem = New Models.MeteoInfo() With {
            .WeatherCode = "sun",
            .Temperature = "-4.2",
            .WindCode = "lo",
            .SnowConditionCode = "sp-c"
        }

        bob.RaceMessageItem = New Models.RaceMessage() With {
            .Text = "Test message from XML Serialier"
        }




        'OUtput Sting


        Dim serializer As New XmlSerializer(GetType(Models.LiveTiming))
        Using writer As New UTFStringWriter()

            serializer.Serialize(writer, bob)

            Me.txtOutData.Text = writer.ToString()

        End Using

    End Sub

End Class

