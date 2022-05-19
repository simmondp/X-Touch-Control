<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbMidiInPorts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbMidiOutPorts = New System.Windows.Forms.ComboBox()
        Me.TbOutput = New System.Windows.Forms.TextBox()
        Me.TbMessage = New System.Windows.Forms.TextBox()
        Me.TbInput = New System.Windows.Forms.TextBox()
        Me.btnCloseOutput = New System.Windows.Forms.Button()
        Me.BtnCloseInput = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSendSysx = New System.Windows.Forms.Button()
        Me.BtnRefreshPortList = New System.Windows.Forms.Button()
        Me.CbSysxInput = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChanelSelectComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.VolPercent = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FaderOutput = New System.Windows.Forms.Label()
        Me.vRingOutput = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.switchStatus = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.faderDown = New System.Windows.Forms.Label()
        Me.vRingDown = New System.Windows.Forms.Label()
        Me.SysExOutput = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ScribbleBoxTop = New System.Windows.Forms.TextBox()
        Me.ScribbleBoxBottom = New System.Windows.Forms.TextBox()
        Me.SendTopStrip = New System.Windows.Forms.Button()
        Me.SendBottomStrip = New System.Windows.Forms.Button()
        Me.JogWheelLed = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DisableLeds = New System.Windows.Forms.Button()
        Me.ReconnectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VuButton04 = New System.Windows.Forms.Button()
        Me.VuButton03 = New System.Windows.Forms.Button()
        Me.VuButton02 = New System.Windows.Forms.Button()
        Me.VuButton01 = New System.Windows.Forms.Button()
        Me.VuButton05 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JogWheelLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Input Port:"
        '
        'CmbMidiInPorts
        '
        Me.CmbMidiInPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMidiInPorts.FormattingEnabled = True
        Me.CmbMidiInPorts.Location = New System.Drawing.Point(538, 31)
        Me.CmbMidiInPorts.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbMidiInPorts.Name = "CmbMidiInPorts"
        Me.CmbMidiInPorts.Size = New System.Drawing.Size(365, 24)
        Me.CmbMidiInPorts.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Output Port:"
        '
        'CmbMidiOutPorts
        '
        Me.CmbMidiOutPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMidiOutPorts.FormattingEnabled = True
        Me.CmbMidiOutPorts.Location = New System.Drawing.Point(24, 33)
        Me.CmbMidiOutPorts.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbMidiOutPorts.Name = "CmbMidiOutPorts"
        Me.CmbMidiOutPorts.Size = New System.Drawing.Size(373, 24)
        Me.CmbMidiOutPorts.TabIndex = 10
        '
        'TbOutput
        '
        Me.TbOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TbOutput.Location = New System.Drawing.Point(24, 447)
        Me.TbOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.TbOutput.Multiline = True
        Me.TbOutput.Name = "TbOutput"
        Me.TbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbOutput.Size = New System.Drawing.Size(485, 102)
        Me.TbOutput.TabIndex = 150
        '
        'TbMessage
        '
        Me.TbMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TbMessage.Location = New System.Drawing.Point(542, 444)
        Me.TbMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMessage.Multiline = True
        Me.TbMessage.Name = "TbMessage"
        Me.TbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbMessage.Size = New System.Drawing.Size(354, 105)
        Me.TbMessage.TabIndex = 220
        '
        'TbInput
        '
        Me.TbInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbInput.Location = New System.Drawing.Point(542, 301)
        Me.TbInput.Margin = New System.Windows.Forms.Padding(4)
        Me.TbInput.Multiline = True
        Me.TbInput.Name = "TbInput"
        Me.TbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbInput.Size = New System.Drawing.Size(446, 90)
        Me.TbInput.TabIndex = 180
        '
        'btnCloseOutput
        '
        Me.btnCloseOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseOutput.Location = New System.Drawing.Point(409, 33)
        Me.btnCloseOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCloseOutput.Name = "btnCloseOutput"
        Me.btnCloseOutput.Size = New System.Drawing.Size(100, 28)
        Me.btnCloseOutput.TabIndex = 20
        Me.btnCloseOutput.Text = "close"
        Me.btnCloseOutput.UseVisualStyleBackColor = True
        '
        'BtnCloseInput
        '
        Me.BtnCloseInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseInput.Location = New System.Drawing.Point(911, 28)
        Me.BtnCloseInput.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCloseInput.Name = "BtnCloseInput"
        Me.BtnCloseInput.Size = New System.Drawing.Size(78, 27)
        Me.BtnCloseInput.TabIndex = 170
        Me.BtnCloseInput.Text = "close"
        Me.BtnCloseInput.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 427)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Output:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(544, 418)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Message:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(544, 281)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Raw HEX Input from X-touch"
        '
        'BtnSendSysx
        '
        Me.BtnSendSysx.Enabled = False
        Me.BtnSendSysx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendSysx.Location = New System.Drawing.Point(409, 396)
        Me.BtnSendSysx.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSendSysx.Name = "BtnSendSysx"
        Me.BtnSendSysx.Size = New System.Drawing.Size(100, 28)
        Me.BtnSendSysx.TabIndex = 140
        Me.BtnSendSysx.Text = "send SyEx"
        Me.BtnSendSysx.UseVisualStyleBackColor = True
        '
        'BtnRefreshPortList
        '
        Me.BtnRefreshPortList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshPortList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshPortList.Location = New System.Drawing.Point(904, 503)
        Me.BtnRefreshPortList.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRefreshPortList.Name = "BtnRefreshPortList"
        Me.BtnRefreshPortList.Size = New System.Drawing.Size(85, 46)
        Me.BtnRefreshPortList.TabIndex = 210
        Me.BtnRefreshPortList.Text = "Refresh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Port List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnRefreshPortList.UseVisualStyleBackColor = True
        '
        'CbSysxInput
        '
        Me.CbSysxInput.FormattingEnabled = True
        Me.CbSysxInput.Items.AddRange(New Object() {"F0 00 00 66 15 00 F7", "F0 00 00 66 15 13 F7", "F0 00 00 66 15 1A 00 F7"})
        Me.CbSysxInput.Location = New System.Drawing.Point(24, 397)
        Me.CbSysxInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbSysxInput.Name = "CbSysxInput"
        Me.CbSysxInput.Size = New System.Drawing.Size(373, 24)
        Me.CbSysxInput.TabIndex = 221
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Select Chanel"
        '
        'ChanelSelectComboBox
        '
        Me.ChanelSelectComboBox.FormattingEnabled = True
        Me.ChanelSelectComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ChanelSelectComboBox.Location = New System.Drawing.Point(159, 76)
        Me.ChanelSelectComboBox.Name = "ChanelSelectComboBox"
        Me.ChanelSelectComboBox.Size = New System.Drawing.Size(150, 24)
        Me.ChanelSelectComboBox.TabIndex = 223
        Me.ChanelSelectComboBox.Text = "Select Channel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 224
        Me.Button1.Text = "Rec ON"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 23)
        Me.Button2.TabIndex = 225
        Me.Button2.Text = "Rec OFF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 23)
        Me.Button3.TabIndex = 226
        Me.Button3.Text = "Solo ON"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(200, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 23)
        Me.Button4.TabIndex = 227
        Me.Button4.Text = "Solo OFF"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 193)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 23)
        Me.Button5.TabIndex = 228
        Me.Button5.Text = "Mute ON"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(200, 193)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 23)
        Me.Button6.TabIndex = 229
        Me.Button6.Text = "Mute OFF"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(24, 233)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 23)
        Me.Button7.TabIndex = 230
        Me.Button7.Text = "Select ON"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(200, 233)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(151, 23)
        Me.Button8.TabIndex = 231
        Me.Button8.Text = "Select OFF"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Volume.Location = New System.Drawing.Point(374, 76)
        Me.Volume.Margin = New System.Windows.Forms.Padding(0)
        Me.Volume.Maximum = 2047
        Me.Volume.Name = "Volume"
        Me.Volume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Volume.Size = New System.Drawing.Size(56, 160)
        Me.Volume.TabIndex = 232
        '
        'VolPercent
        '
        Me.VolPercent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.VolPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolPercent.Location = New System.Drawing.Point(374, 236)
        Me.VolPercent.MinimumSize = New System.Drawing.Size(50, 0)
        Me.VolPercent.Name = "VolPercent"
        Me.VolPercent.Size = New System.Drawing.Size(56, 16)
        Me.VolPercent.TabIndex = 233
        Me.VolPercent.Text = "xx%"
        Me.VolPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(539, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 234
        Me.Label5.Text = "Fader Output"
        '
        'FaderOutput
        '
        Me.FaderOutput.BackColor = System.Drawing.Color.White
        Me.FaderOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaderOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FaderOutput.Location = New System.Drawing.Point(542, 181)
        Me.FaderOutput.Name = "FaderOutput"
        Me.FaderOutput.Size = New System.Drawing.Size(361, 21)
        Me.FaderOutput.TabIndex = 235
        Me.FaderOutput.Text = "Fader Results Appear Here"
        '
        'vRingOutput
        '
        Me.vRingOutput.BackColor = System.Drawing.Color.White
        Me.vRingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vRingOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vRingOutput.Location = New System.Drawing.Point(538, 80)
        Me.vRingOutput.Name = "vRingOutput"
        Me.vRingOutput.Size = New System.Drawing.Size(365, 20)
        Me.vRingOutput.TabIndex = 237
        Me.vRingOutput.Text = "V-Ring Results Appear Here"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(539, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 236
        Me.Label10.Text = "V-Ring Output"
        '
        'switchStatus
        '
        Me.switchStatus.BackColor = System.Drawing.Color.White
        Me.switchStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.switchStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.switchStatus.Location = New System.Drawing.Point(539, 132)
        Me.switchStatus.Name = "switchStatus"
        Me.switchStatus.Size = New System.Drawing.Size(450, 21)
        Me.switchStatus.TabIndex = 239
        Me.switchStatus.Text = "Switch Results Appear Here"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(539, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 238
        Me.Label12.Text = "Switch Output"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'faderDown
        '
        Me.faderDown.BackColor = System.Drawing.Color.White
        Me.faderDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.faderDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.faderDown.Location = New System.Drawing.Point(911, 181)
        Me.faderDown.Name = "faderDown"
        Me.faderDown.Size = New System.Drawing.Size(77, 21)
        Me.faderDown.TabIndex = 240
        Me.faderDown.Text = "Dn/Up"
        '
        'vRingDown
        '
        Me.vRingDown.BackColor = System.Drawing.Color.White
        Me.vRingDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vRingDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vRingDown.Location = New System.Drawing.Point(911, 79)
        Me.vRingDown.Name = "vRingDown"
        Me.vRingDown.Size = New System.Drawing.Size(77, 21)
        Me.vRingDown.TabIndex = 241
        Me.vRingDown.Text = "Dn/Up"
        '
        'SysExOutput
        '
        Me.SysExOutput.BackColor = System.Drawing.Color.White
        Me.SysExOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysExOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SysExOutput.Location = New System.Drawing.Point(542, 236)
        Me.SysExOutput.Name = "SysExOutput"
        Me.SysExOutput.Size = New System.Drawing.Size(446, 21)
        Me.SysExOutput.TabIndex = 242
        Me.SysExOutput.Text = "SysEx Results Appear Here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(539, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "SysEx Output"
        '
        'ScribbleBoxTop
        '
        Me.ScribbleBoxTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScribbleBoxTop.Location = New System.Drawing.Point(24, 303)
        Me.ScribbleBoxTop.MaxLength = 7
        Me.ScribbleBoxTop.Name = "ScribbleBoxTop"
        Me.ScribbleBoxTop.Size = New System.Drawing.Size(100, 27)
        Me.ScribbleBoxTop.TabIndex = 244
        Me.ScribbleBoxTop.Text = "Top Box"
        Me.ScribbleBoxTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ScribbleBoxTop.WordWrap = False
        '
        'ScribbleBoxBottom
        '
        Me.ScribbleBoxBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScribbleBoxBottom.Location = New System.Drawing.Point(24, 341)
        Me.ScribbleBoxBottom.MaxLength = 7
        Me.ScribbleBoxBottom.Name = "ScribbleBoxBottom"
        Me.ScribbleBoxBottom.Size = New System.Drawing.Size(100, 27)
        Me.ScribbleBoxBottom.TabIndex = 245
        Me.ScribbleBoxBottom.Text = "Bottom!"
        Me.ScribbleBoxBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ScribbleBoxBottom.WordWrap = False
        '
        'SendTopStrip
        '
        Me.SendTopStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendTopStrip.Location = New System.Drawing.Point(131, 300)
        Me.SendTopStrip.Margin = New System.Windows.Forms.Padding(4)
        Me.SendTopStrip.Name = "SendTopStrip"
        Me.SendTopStrip.Size = New System.Drawing.Size(71, 30)
        Me.SendTopStrip.TabIndex = 246
        Me.SendTopStrip.Text = "Send"
        Me.SendTopStrip.UseVisualStyleBackColor = True
        '
        'SendBottomStrip
        '
        Me.SendBottomStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendBottomStrip.Location = New System.Drawing.Point(131, 341)
        Me.SendBottomStrip.Margin = New System.Windows.Forms.Padding(4)
        Me.SendBottomStrip.Name = "SendBottomStrip"
        Me.SendBottomStrip.Size = New System.Drawing.Size(71, 27)
        Me.SendBottomStrip.TabIndex = 247
        Me.SendBottomStrip.Text = "Send"
        Me.SendBottomStrip.UseVisualStyleBackColor = True
        '
        'JogWheelLed
        '
        Me.JogWheelLed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.JogWheelLed.LargeChange = 1
        Me.JogWheelLed.Location = New System.Drawing.Point(219, 307)
        Me.JogWheelLed.Maximum = 12
        Me.JogWheelLed.Minimum = -12
        Me.JogWheelLed.Name = "JogWheelLed"
        Me.JogWheelLed.Size = New System.Drawing.Size(290, 56)
        Me.JogWheelLed.TabIndex = 248
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 281)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 249
        Me.Label3.Text = "Send ScribbleStrip"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(216, 281)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 250
        Me.Label11.Text = "Send Jog Wheel LED"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 379)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 16)
        Me.Label13.TabIndex = 251
        Me.Label13.Text = "Select & Send SysEx"
        '
        'DisableLeds
        '
        Me.DisableLeds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableLeds.Location = New System.Drawing.Point(383, 272)
        Me.DisableLeds.Margin = New System.Windows.Forms.Padding(4)
        Me.DisableLeds.Name = "DisableLeds"
        Me.DisableLeds.Size = New System.Drawing.Size(120, 28)
        Me.DisableLeds.TabIndex = 252
        Me.DisableLeds.Text = "Disable LEDs"
        Me.DisableLeds.UseVisualStyleBackColor = True
        '
        'ReconnectTimer
        '
        Me.ReconnectTimer.Interval = 2000
        '
        'VuButton04
        '
        Me.VuButton04.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VuButton04.Location = New System.Drawing.Point(450, 125)
        Me.VuButton04.Margin = New System.Windows.Forms.Padding(0)
        Me.VuButton04.Name = "VuButton04"
        Me.VuButton04.Size = New System.Drawing.Size(59, 30)
        Me.VuButton04.TabIndex = 253
        Me.VuButton04.Text = "0.9"
        Me.VuButton04.UseVisualStyleBackColor = True
        '
        'VuButton03
        '
        Me.VuButton03.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VuButton03.Location = New System.Drawing.Point(450, 158)
        Me.VuButton03.Margin = New System.Windows.Forms.Padding(0)
        Me.VuButton03.Name = "VuButton03"
        Me.VuButton03.Size = New System.Drawing.Size(59, 30)
        Me.VuButton03.TabIndex = 254
        Me.VuButton03.Text = "0.7"
        Me.VuButton03.UseVisualStyleBackColor = True
        '
        'VuButton02
        '
        Me.VuButton02.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VuButton02.Location = New System.Drawing.Point(450, 190)
        Me.VuButton02.Margin = New System.Windows.Forms.Padding(0)
        Me.VuButton02.Name = "VuButton02"
        Me.VuButton02.Size = New System.Drawing.Size(59, 30)
        Me.VuButton02.TabIndex = 255
        Me.VuButton02.Text = "0.4"
        Me.VuButton02.UseVisualStyleBackColor = True
        '
        'VuButton01
        '
        Me.VuButton01.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VuButton01.Location = New System.Drawing.Point(450, 223)
        Me.VuButton01.Margin = New System.Windows.Forms.Padding(0)
        Me.VuButton01.Name = "VuButton01"
        Me.VuButton01.Size = New System.Drawing.Size(59, 30)
        Me.VuButton01.TabIndex = 256
        Me.VuButton01.Text = "0.1"
        Me.VuButton01.UseVisualStyleBackColor = True
        '
        'VuButton05
        '
        Me.VuButton05.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VuButton05.Location = New System.Drawing.Point(450, 91)
        Me.VuButton05.Margin = New System.Windows.Forms.Padding(0)
        Me.VuButton05.Name = "VuButton05"
        Me.VuButton05.Size = New System.Drawing.Size(59, 30)
        Me.VuButton05.TabIndex = 257
        Me.VuButton05.Text = "1.1"
        Me.VuButton05.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(463, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 258
        Me.Label14.Text = "VU"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1001, 577)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.VuButton05)
        Me.Controls.Add(Me.VuButton01)
        Me.Controls.Add(Me.VuButton02)
        Me.Controls.Add(Me.VuButton03)
        Me.Controls.Add(Me.VuButton04)
        Me.Controls.Add(Me.DisableLeds)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.JogWheelLed)
        Me.Controls.Add(Me.SendBottomStrip)
        Me.Controls.Add(Me.SendTopStrip)
        Me.Controls.Add(Me.ScribbleBoxBottom)
        Me.Controls.Add(Me.ScribbleBoxTop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SysExOutput)
        Me.Controls.Add(Me.vRingDown)
        Me.Controls.Add(Me.faderDown)
        Me.Controls.Add(Me.switchStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.vRingOutput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FaderOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VolPercent)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChanelSelectComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbSysxInput)
        Me.Controls.Add(Me.BtnRefreshPortList)
        Me.Controls.Add(Me.BtnSendSysx)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCloseInput)
        Me.Controls.Add(Me.btnCloseOutput)
        Me.Controls.Add(Me.TbMessage)
        Me.Controls.Add(Me.TbInput)
        Me.Controls.Add(Me.TbOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMidiInPorts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbMidiOutPorts)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "X-Touch Control"
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JogWheelLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbMidiInPorts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbMidiOutPorts As ComboBox
    Friend WithEvents TbOutput As TextBox
    Friend WithEvents TbMessage As TextBox
    Friend WithEvents TbInput As TextBox
    Friend WithEvents btnCloseOutput As Button
    Friend WithEvents BtnCloseInput As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSendSysx As Button
    Friend WithEvents BtnRefreshPortList As Button
    Friend WithEvents CbSysxInput As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ChanelSelectComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Volume As TrackBar
    Friend WithEvents VolPercent As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FaderOutput As Label
    Friend WithEvents vRingOutput As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents switchStatus As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents faderDown As Label
    Friend WithEvents vRingDown As Label
    Friend WithEvents SysExOutput As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ScribbleBoxTop As TextBox
    Friend WithEvents ScribbleBoxBottom As TextBox
    Friend WithEvents SendTopStrip As Button
    Friend WithEvents SendBottomStrip As Button
    Friend WithEvents JogWheelLed As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DisableLeds As Button
    Friend WithEvents ReconnectTimer As Timer
    Friend WithEvents VuButton04 As Button
    Friend WithEvents VuButton03 As Button
    Friend WithEvents VuButton02 As Button
    Friend WithEvents VuButton01 As Button
    Friend WithEvents VuButton05 As Button
    Friend WithEvents Label14 As Label
End Class

