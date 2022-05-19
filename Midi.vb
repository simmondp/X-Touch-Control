Option Explicit On
Option Strict On

Imports X_Touch_Control.Midi_IO_Constants
Partial Public Class Form1

    Friend hMidiOut As UInteger
    Private hMidiIn As UInteger

    Private CallbackMsgCounter As Integer = 1
    Private OutputMsgCounter As Integer = 1
    Private InputMsgCounter As Integer = 1

#Region "Output"

    Friend Sub MidiOutShortMsg(hmo As UInteger, status As Integer, data1 As Integer, data2 As Integer)
        Dim ret As Integer
        ret = MIO.OutShortMsg(hmo, status, data1, data2)
        ShowShortMsg_Output(status, data1, data2, ret)
    End Sub

    Private Sub ShowShortMsg_Output(status As Integer, data1 As Integer, data2 As Integer, ret As Integer)
        Dim buffer As Byte()
        ReDim buffer(2)
        buffer(0) = CByte(status)
        buffer(1) = CByte(data1)
        buffer(2) = CByte(data2)
        ShowHexBytes_Output(buffer, ret)
    End Sub

    Private Sub ShowHexBytes_Output(buffer As Byte(), ret As Integer)
        If TbInput.InvokeRequired = False Then
            Threadsafe_ShowHexBytes_Output(buffer, ret)
        Else
            ' from Input2 (different Thread)
            TbInput.Invoke(New ShowHexBytes_Output_Delegate(AddressOf Threadsafe_ShowHexBytes_Output), buffer, ret)
        End If
    End Sub

    Private Delegate Sub ShowHexBytes_Output_Delegate(buffer As Byte(), ret As Integer)
    Private Sub Threadsafe_ShowHexBytes_Output(buffer As Byte(), ret As Integer)
        If TbOutput.Lines.Length > 1000 Then TbOutput.Clear()
        Dim str1 As String = CStr(OutputMsgCounter) & "...."
        Dim str2 As String
        str2 = BitConverter.ToString(buffer)
        str2 = str2.Replace("-", " ")
        If ret = MMSYSERR_NOERROR Then
            TbOutput.AppendText(str1 & str2 & vbCrLf)
        Else
            Dim str3 As String = Decode_Return_Code(ret)
            TbOutput.AppendText(str1 & str2 & " --> ! " & str3 & vbCrLf)
            ReconnectTimer.Enabled = True
        End If
        OutputMsgCounter += 1
    End Sub

    Private Function Decode_Return_Code(ret As Integer) As String
        Select Case ret
            Case MMSYSERR_NOERROR
                Return "MMSYSERR_NOERROR"
            Case MMSYSERR_INVALHANDLE
                ReconnectTimer.Enabled = True
                Return "MMSYSERR_INVALHANDLE" & " - " & Hex(hMidiOut)
            Case MMSYSERR_HANDLEBUSY
                ReconnectTimer.Enabled = True
                Return "MMSYSERR_HANDLEBUSY"
            Case MIDIERR_UNPREPARED
                ReconnectTimer.Enabled = True
                Return "MIDIERR_UNPREPARED"
            Case MMSYSERR_INVALPARAM
                ReconnectTimer.Enabled = True
                Return "MMSYSERR_INVALPARAM"
            Case MIDIERR_BADOPENMODE
                ReconnectTimer.Enabled = True
                Return "MIDIERR_BADOPENMODE"
            Case MIDIERR_NOTREADY
                ReconnectTimer.Enabled = True
                Return "MIDIERR_NOTREADY"
            Case MIO_ERR_NoOutBufferAvailable
                ReconnectTimer.Enabled = True
                Return "MIO_ERR_NoOutBufferAvailable"
            Case Else
                ReconnectTimer.Enabled = True
                Return Hex(ret)
        End Select
    End Function

#End Region

#Region "Input"

    ''' <summary>
    ''' Handles MidiInData
    ''' </summary>
    ''' <param name="hmi">handle of the Input port</param>
    ''' <param name="dwInstance">user defined value (port number)</param>
    ''' <param name="status">first byte of the Midi-message</param>
    ''' <param name="data1">second byte of the Midi message</param>
    ''' <param name="data2">third byte of the Midi-Message</param>
    ''' <param name="dwTimestamp">milliseconds since call to MidiInStart</param>
    Private Sub MidiInData(hmi As UInteger, dwInstance As UInteger, status As Byte, data1 As Byte, data2 As Byte, dwTimestamp As UInteger) Handles MIO.MidiInData
        Dim buffer As Byte()
        ReDim buffer(2)
        buffer(0) = status
        buffer(1) = data1
        buffer(2) = data2

        If hmi = hMidiIn Then
            ShowHexBytes_Input(buffer)
            Debug.Print("[MidiInData] hMidiIn: " & " : " & buffer.GetValue(0).ToString)
        End If
    End Sub

    ''' <summary>
    ''' Handles MidiInLongdata
    ''' </summary>
    ''' <param name="hmi">handle of the Input port</param>
    ''' <param name="dwInstance">user defined value (port number)</param>
    ''' <param name="buffer"></param>
    ''' <param name="dwTimestamp">milliseconds since call to MidiInStart</param>
    Private Sub MidiInLongdata(hmi As UInteger, dwInstance As UInteger, buffer As Byte(), dwTimestamp As UInteger) Handles MIO.MidiInLongdata
        If hmi = hMidiIn Then
            ShowHexBytes_Input(buffer)
            'Debug.Print("[MidiInLongdata] hMidiIn: " & " : " & buffer.ToString)
        End If
    End Sub

    Private Sub ShowHexBytes_Input(buffer As Byte())
        If TbInput.InvokeRequired = False Then
            Threadsafe_ShowHexBytes_Input(buffer)
        Else
            TbInput.Invoke(New ShowHexBytes_Input_Delegate(AddressOf Threadsafe_ShowHexBytes_Input), buffer)
        End If
    End Sub

    Private Delegate Sub ShowHexBytes_Input_Delegate(buffer As Byte())

    Public Sub Threadsafe_ShowHexBytes_Input(buffer As Byte())

        If TbInput.Lines.Length > 1000 Then
            TbInput.Clear()
        End If
        Dim str1 As String = CStr(InputMsgCounter) & "...."
        Dim str2 As String
        Dim strOut As String
        str2 = BitConverter.ToString(buffer)
        str2 = str2.Replace("-", " ")
        strOut = str1 & str2 & vbCrLf

        TbInput.AppendText(strOut)

        InputMsgCounter += 1

        '---
        ' can update other controls on this form - lets work out what was pressed!
        '---
        Dim shortInputArray = Split(BitConverter.ToString(buffer), "-")
        Dim selectedChannel As Integer

        If buffer.Length = 3 Then 'we have a good short message

            '====================================================================================
            If buffer(0) = &HB0 Then 'Hex B0 - It's a V-Pot

                selectedChannel = CInt(buffer(1) And &HF) + 1
                Dim dirTurn As Integer = buffer(2) >> 6
                Dim ringVelocity As Integer = buffer(2) And &H3F
                vRingOutput.Text = "Ring Position: Ch = " & selectedChannel.ToString & " Direction = " & dirTurn.ToString & " Velocity = " & ringVelocity.ToString

                '====================================================================================
            ElseIf buffer(0) = &H90 Then 'Hex 90 - It's a Switch (including V-Pots and Faders)
                selectedChannel = CInt(buffer(1) And &H7)

                Dim pushStatus As String = "Unknown"
                If buffer(2) = &H0 Then
                    pushStatus = "Release"
                ElseIf buffer(2) = &H7F Then
                    pushStatus = "Pushed"
                End If

                Select Case (buffer(1) >> 3)
                    Case 0
                        'buttonType = " Rec"
                        switchStatus.Text = "Button: Ch = " & selectedChannel.ToString & " Rec " & pushStatus
                    Case 1
                        'buttonType = " Solo"
                        switchStatus.Text = "Button: Ch = " & selectedChannel.ToString & " Solo " & pushStatus
                    Case 2
                        'buttonType = " Mute"
                        switchStatus.Text = "Button: Ch = " & selectedChannel.ToString & " Mute " & pushStatus
                    Case 3
                        'buttonType = " Select"
                        switchStatus.Text = "Button: Ch = " & selectedChannel.ToString & " Select " & pushStatus
                    Case 4
                        'buttonType = " V-Ring"
                        vRingDown.Text = pushStatus
                    Case 13
                        'buttonType = " Fader"
                        faderDown.Text = pushStatus
                    Case Else
                        Debug.Print("ERROR - Switch undetermined")
                End Select

                '====================================================================================
            ElseIf buffer(0) >> 3 = &H1C Then ' Hex E0 to E7 - It's a fader input

                '** this relies on the Fader being set from 0 to 2047 and a "small change" of 1

                selectedChannel = buffer(0) And &H7
                Dim faderValue As Integer = buffer(2)
                faderValue = (faderValue << 4) Or (buffer(1) >> 2)
                FaderOutput.Text = "Fader: Ch = " & selectedChannel.ToString & " Raw = " & faderValue.ToString & " Percentage = " & Int((faderValue / 20.47)).ToString()

            Else

                Debug.Print("[Threadsafe_ShowHexBytes_Input] Decode Error = " & BitConverter.ToString(buffer))

            End If

            '====================================================================================
        ElseIf buffer(0) = &HF0 Then

            '** Its a Sysex command **


            Dim sysExCheck As UInt32 = buffer(1) << 8
            sysExCheck = ((((sysExCheck Or buffer(2)) << 8) Or buffer(3)) << 8) Or buffer(4)
            Debug.Print(sysExCheck.ToString)

            If sysExCheck = &H6615 Then

                Debug.Print(buffer(5).ToString)

                '** Looks like it's a legal SysEx command destined for a Behringer X-Touch - so lets try and decode it
                Select Case (buffer(5))
                    Case &H1
                        SysExOutput.Text = "Device Query: " & BitConverter.ToString(buffer)
                    Case &H14
                        SysExOutput.Text = "Firmware Version: " & BitConverter.ToString(buffer)
                    Case &H1B
                        SysExOutput.Text = "Strange Query: " & BitConverter.ToString(buffer)
                    Case Else
                        SysExOutput.Text = "Unknown SysEx = " & BitConverter.ToString(buffer)
                End Select

            Else
                SysExOutput.Text = "It's a SysEx command Jim, but not as we know it: " & BitConverter.ToString(buffer)
            End If

        Else
            Debug.Print("[Threadsafe_ShowHexBytes_Input] Error Integer message Byte length")
        End If

    End Sub

#End Region

#Region "Callback Messages"

    ''' <summary>
    ''' Handles the information messages sent to MidiOutProc
    ''' </summary>
    ''' <param name="hmo">handle of the Output port</param>
    ''' <param name="wMsg">message numbering constant</param>
    ''' <param name="dwInstance">user defined value (port number)</param>
    ''' <param name="dwParam1">not used</param>
    ''' <param name="dwParam2">not used</param>
    Private Sub MidiOutCallbackMsg(hmo As UInteger, wMsg As UInteger, dwInstance As UInteger, dwParam1 As UInteger, dwParam2 As UInteger) Handles MIO.MidiOutCallbackMsg
        Dim msg As String = CStr(CallbackMsgCounter)
        msg &= "    " & Decode_msg(wMsg) & " - " & Hex(hmo) & " - " & Hex(dwInstance) & vbCrLf
        Debug.Print("[MidiOutCallbackMsg] msg = " & Decode_msg(wMsg) & " - " & Hex(hmo) & " - " & Hex(dwInstance))
        ShowCallbackMsg(msg)
    End Sub

    ''' <summary>
    ''' Handles the information messages sent to MidiInProc
    ''' </summary>
    ''' <param name="hmi">handle of the Input port</param>
    ''' <param name="wMsg">message numbering constant</param>
    ''' <param name="dwInstance">user defined value (port number)</param>
    ''' <param name="dwParam1">not used</param>
    ''' <param name="dwParam2">not used</param>
    Private Sub MidiInCallbackMsg(hmi As UInteger, wMsg As UInteger, dwInstance As UInteger, dwParam1 As UInteger, dwParam2 As UInteger) Handles MIO.MidiInCallbackMsg
        Dim msg As String = CStr(CallbackMsgCounter)
        msg &= "    " & Decode_msg(wMsg) & " - " & Hex(hmi) & " - " & Hex(dwInstance) & vbCrLf
        ShowCallbackMsg(msg)
    End Sub

    Private Sub ShowCallbackMsg(msg As String)
        ' make Threadsafe in case: output to device, respond from device, Input2 --> back to output
        If TbMessage.InvokeRequired = False Then
            Threadsafe_ShowCallbackMsg(msg)                         ' normal way, no invoke required
        Else
            TbMessage.Invoke(New ShowCallbackMsg_Delegate(AddressOf Threadsafe_ShowCallbackMsg), msg)
        End If
    End Sub

    Private Delegate Sub ShowCallbackMsg_Delegate(msg As String)

    Private Sub Threadsafe_ShowCallbackMsg(msg As String)
        If TbMessage.Lines.Length > 1000 Then TbMessage.Clear()
        TbMessage.AppendText(msg)
        CallbackMsgCounter += 1
    End Sub

    Private Function Decode_msg(msg As UInteger) As String
        Select Case msg
            Case &H3C1
                Return "MIM_OPEN"
            Case &H3C2
                ReconnectTimer.Enabled = True
                Return "MIM_CLOSE"
            Case &H3C5
                ReconnectTimer.Enabled = True
                Return "MIM_ERROR"
            Case &H3C7
                Return "MOM_OPEN"
            Case &H3C8
                ReconnectTimer.Enabled = True
                Return "MOM_CLOSE"
            Case &H3C9
                Return "MOM_DONE"
            Case Else
                Return Hex(msg)
        End Select
    End Function
#End Region

End Class
