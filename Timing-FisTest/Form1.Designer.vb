<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSetCodex = New System.Windows.Forms.TextBox()
        Me.txtSetPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSetPort = New System.Windows.Forms.TextBox()
        Me.txtSetServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOutData = New System.Windows.Forms.TextBox()
        Me.cmdSendIt = New System.Windows.Forms.Button()
        Me.txtInData = New System.Windows.Forms.TextBox()
        Me.cmdLoadInitial = New System.Windows.Forms.Button()
        Me.txtOutSeq = New System.Windows.Forms.TextBox()
        Me.cmdLoadRaceInfo = New System.Windows.Forms.Button()
        Me.cmdLoadStartList = New System.Windows.Forms.Button()
        Me.cmdRaceEventStarted = New System.Windows.Forms.Button()
        Me.cmdRaceEventDNS = New System.Windows.Forms.Button()
        Me.cmdRaceEventDNF = New System.Windows.Forms.Button()
        Me.cmdRaceEventDSQ = New System.Windows.Forms.Button()
        Me.cmdRaceEventTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codex"
        '
        'txtSetCodex
        '
        Me.txtSetCodex.Location = New System.Drawing.Point(356, 14)
        Me.txtSetCodex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetCodex.Name = "txtSetCodex"
        Me.txtSetCodex.Size = New System.Drawing.Size(148, 24)
        Me.txtSetCodex.TabIndex = 5
        Me.txtSetCodex.Text = "9882"
        '
        'txtSetPassword
        '
        Me.txtSetPassword.Location = New System.Drawing.Point(356, 53)
        Me.txtSetPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetPassword.Name = "txtSetPassword"
        Me.txtSetPassword.Size = New System.Drawing.Size(148, 24)
        Me.txtSetPassword.TabIndex = 7
        Me.txtSetPassword.Text = "2wsx5TGB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Port"
        '
        'txtSetPort
        '
        Me.txtSetPort.Location = New System.Drawing.Point(98, 53)
        Me.txtSetPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetPort.Name = "txtSetPort"
        Me.txtSetPort.Size = New System.Drawing.Size(148, 24)
        Me.txtSetPort.TabIndex = 3
        Me.txtSetPort.Text = "1550"
        '
        'txtSetServer
        '
        Me.txtSetServer.Location = New System.Drawing.Point(98, 14)
        Me.txtSetServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetServer.Name = "txtSetServer"
        Me.txtSetServer.Size = New System.Drawing.Size(148, 24)
        Me.txtSetServer.TabIndex = 1
        Me.txtSetServer.Text = "live.fisski.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Server"
        '
        'txtOutData
        '
        Me.txtOutData.AcceptsReturn = True
        Me.txtOutData.AcceptsTab = True
        Me.txtOutData.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutData.Location = New System.Drawing.Point(12, 107)
        Me.txtOutData.Multiline = True
        Me.txtOutData.Name = "txtOutData"
        Me.txtOutData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutData.Size = New System.Drawing.Size(545, 324)
        Me.txtOutData.TabIndex = 8
        Me.txtOutData.WordWrap = False
        '
        'cmdSendIt
        '
        Me.cmdSendIt.Location = New System.Drawing.Point(944, 53)
        Me.cmdSendIt.Name = "cmdSendIt"
        Me.cmdSendIt.Size = New System.Drawing.Size(108, 38)
        Me.cmdSendIt.TabIndex = 9
        Me.cmdSendIt.Text = "Send"
        Me.cmdSendIt.UseVisualStyleBackColor = True
        '
        'txtInData
        '
        Me.txtInData.AcceptsReturn = True
        Me.txtInData.AcceptsTab = True
        Me.txtInData.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInData.Location = New System.Drawing.Point(563, 107)
        Me.txtInData.Multiline = True
        Me.txtInData.Name = "txtInData"
        Me.txtInData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInData.Size = New System.Drawing.Size(489, 324)
        Me.txtInData.TabIndex = 10
        Me.txtInData.WordWrap = False
        '
        'cmdLoadInitial
        '
        Me.cmdLoadInitial.Location = New System.Drawing.Point(540, 13)
        Me.cmdLoadInitial.Name = "cmdLoadInitial"
        Me.cmdLoadInitial.Size = New System.Drawing.Size(114, 23)
        Me.cmdLoadInitial.TabIndex = 11
        Me.cmdLoadInitial.Text = "Load Initial"
        Me.cmdLoadInitial.UseVisualStyleBackColor = True
        '
        'txtOutSeq
        '
        Me.txtOutSeq.Location = New System.Drawing.Point(989, 23)
        Me.txtOutSeq.Name = "txtOutSeq"
        Me.txtOutSeq.Size = New System.Drawing.Size(63, 24)
        Me.txtOutSeq.TabIndex = 12
        Me.txtOutSeq.Text = "00000"
        Me.txtOutSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdLoadRaceInfo
        '
        Me.cmdLoadRaceInfo.Location = New System.Drawing.Point(540, 42)
        Me.cmdLoadRaceInfo.Name = "cmdLoadRaceInfo"
        Me.cmdLoadRaceInfo.Size = New System.Drawing.Size(114, 23)
        Me.cmdLoadRaceInfo.TabIndex = 13
        Me.cmdLoadRaceInfo.Text = "Load RaceInfo"
        Me.cmdLoadRaceInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdLoadRaceInfo.UseVisualStyleBackColor = True
        '
        'cmdLoadStartList
        '
        Me.cmdLoadStartList.Location = New System.Drawing.Point(540, 71)
        Me.cmdLoadStartList.Name = "cmdLoadStartList"
        Me.cmdLoadStartList.Size = New System.Drawing.Size(114, 23)
        Me.cmdLoadStartList.TabIndex = 14
        Me.cmdLoadStartList.Text = "Load StartList"
        Me.cmdLoadStartList.UseVisualStyleBackColor = True
        '
        'cmdRaceEventStarted
        '
        Me.cmdRaceEventStarted.Location = New System.Drawing.Point(660, 13)
        Me.cmdRaceEventStarted.Name = "cmdRaceEventStarted"
        Me.cmdRaceEventStarted.Size = New System.Drawing.Size(128, 23)
        Me.cmdRaceEventStarted.TabIndex = 15
        Me.cmdRaceEventStarted.Text = "RaceEvent Started"
        Me.cmdRaceEventStarted.UseVisualStyleBackColor = True
        '
        'cmdRaceEventDNS
        '
        Me.cmdRaceEventDNS.Location = New System.Drawing.Point(660, 41)
        Me.cmdRaceEventDNS.Name = "cmdRaceEventDNS"
        Me.cmdRaceEventDNS.Size = New System.Drawing.Size(128, 23)
        Me.cmdRaceEventDNS.TabIndex = 16
        Me.cmdRaceEventDNS.Text = "RaceEvent DNS"
        Me.cmdRaceEventDNS.UseVisualStyleBackColor = True
        '
        'cmdRaceEventDNF
        '
        Me.cmdRaceEventDNF.Location = New System.Drawing.Point(660, 70)
        Me.cmdRaceEventDNF.Name = "cmdRaceEventDNF"
        Me.cmdRaceEventDNF.Size = New System.Drawing.Size(128, 23)
        Me.cmdRaceEventDNF.TabIndex = 17
        Me.cmdRaceEventDNF.Text = "RaceEvent DNF"
        Me.cmdRaceEventDNF.UseVisualStyleBackColor = True
        '
        'cmdRaceEventDSQ
        '
        Me.cmdRaceEventDSQ.Location = New System.Drawing.Point(794, 14)
        Me.cmdRaceEventDSQ.Name = "cmdRaceEventDSQ"
        Me.cmdRaceEventDSQ.Size = New System.Drawing.Size(128, 23)
        Me.cmdRaceEventDSQ.TabIndex = 18
        Me.cmdRaceEventDSQ.Text = "RaceEvent DSQ"
        Me.cmdRaceEventDSQ.UseVisualStyleBackColor = True
        '
        'cmdRaceEventTime
        '
        Me.cmdRaceEventTime.Location = New System.Drawing.Point(794, 41)
        Me.cmdRaceEventTime.Name = "cmdRaceEventTime"
        Me.cmdRaceEventTime.Size = New System.Drawing.Size(128, 23)
        Me.cmdRaceEventTime.TabIndex = 19
        Me.cmdRaceEventTime.Text = "RaceEvent Time"
        Me.cmdRaceEventTime.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 443)
        Me.Controls.Add(Me.cmdRaceEventTime)
        Me.Controls.Add(Me.cmdRaceEventDSQ)
        Me.Controls.Add(Me.cmdRaceEventDNF)
        Me.Controls.Add(Me.cmdRaceEventDNS)
        Me.Controls.Add(Me.cmdRaceEventStarted)
        Me.Controls.Add(Me.cmdLoadStartList)
        Me.Controls.Add(Me.cmdLoadRaceInfo)
        Me.Controls.Add(Me.txtOutSeq)
        Me.Controls.Add(Me.cmdLoadInitial)
        Me.Controls.Add(Me.txtInData)
        Me.Controls.Add(Me.cmdSendIt)
        Me.Controls.Add(Me.txtOutData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSetPort)
        Me.Controls.Add(Me.txtSetServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSetPassword)
        Me.Controls.Add(Me.txtSetCodex)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSetCodex As TextBox
    Friend WithEvents txtSetPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSetPort As TextBox
    Friend WithEvents txtSetServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOutData As TextBox
    Friend WithEvents cmdSendIt As Button
    Friend WithEvents txtInData As TextBox
    Friend WithEvents cmdLoadInitial As Button
    Friend WithEvents txtOutSeq As TextBox
    Friend WithEvents cmdLoadRaceInfo As Button
    Friend WithEvents cmdLoadStartList As Button
    Friend WithEvents cmdRaceEventStarted As Button
    Friend WithEvents cmdRaceEventDNS As Button
    Friend WithEvents cmdRaceEventDNF As Button
    Friend WithEvents cmdRaceEventDSQ As Button
    Friend WithEvents cmdRaceEventTime As Button
End Class
