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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codex"
        '
        'txtSetCodex
        '
        Me.txtSetCodex.Location = New System.Drawing.Point(356, 14)
        Me.txtSetCodex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetCodex.Name = "txtSetCodex"
        Me.txtSetCodex.Size = New System.Drawing.Size(148, 28)
        Me.txtSetCodex.TabIndex = 5
        '
        'txtSetPassword
        '
        Me.txtSetPassword.Location = New System.Drawing.Point(356, 53)
        Me.txtSetPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetPassword.Name = "txtSetPassword"
        Me.txtSetPassword.Size = New System.Drawing.Size(148, 28)
        Me.txtSetPassword.TabIndex = 7
        Me.txtSetPassword.Text = "2wsx5TGB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Port"
        '
        'txtSetPort
        '
        Me.txtSetPort.Location = New System.Drawing.Point(98, 53)
        Me.txtSetPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetPort.Name = "txtSetPort"
        Me.txtSetPort.Size = New System.Drawing.Size(148, 28)
        Me.txtSetPort.TabIndex = 3
        Me.txtSetPort.Text = "1550"
        '
        'txtSetServer
        '
        Me.txtSetServer.Location = New System.Drawing.Point(98, 14)
        Me.txtSetServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSetServer.Name = "txtSetServer"
        Me.txtSetServer.Size = New System.Drawing.Size(148, 28)
        Me.txtSetServer.TabIndex = 1
        Me.txtSetServer.Text = "live.fisski.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 21)
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
        Me.txtOutData.Text = "<?xml version=""1.0"" encoding=""UTF-8""?>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<livetiming codex=""1636"" passwd=""mypasswo" &
    "rd"" sequence=""00000"" timesamp=""20:06:41"">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<command>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<clear/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</command> " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</l" &
    "ivetiming>  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtOutData.WordWrap = False
        '
        'cmdSendIt
        '
        Me.cmdSendIt.Location = New System.Drawing.Point(729, 47)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 443)
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
End Class
