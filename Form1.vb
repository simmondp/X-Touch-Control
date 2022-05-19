Option Explicit On
Option Strict On

Imports System.Text

Public Class Form1

    Private WithEvents MIO As New Midi_IO 'Midi_IO.Midi_IO

#Region "Common"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '**** MIGRATED ****

        PopulatePorts()

        'Now start looking for X-Touch
        ReconnectTimer.Enabled = True

    End Sub


    Private Sub PopulatePorts()
        '**** MIGRATED ****
        CmbMidiOutPorts.Items.Clear()
        For i = 1 To MIO.MidiOutPorts.Count
            If MIO.MidiOutPorts(i - 1).invalidPort = False Then          'list only valid ports
                CmbMidiOutPorts.Items.Add(MIO.MidiOutPorts(i - 1).portName)
            End If
        Next

        CmbMidiInPorts.Items.Clear()
        For i = 1 To MIO.MidiInPorts.Count
            If MIO.MidiInPorts(i - 1).invalidPort = False Then          'list only valid ports
                CmbMidiInPorts.Items.Add(MIO.MidiInPorts(i - 1).portName)
            End If
        Next

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '--- after using Midi_IO and a MidiIn Port is still open, .ProgEnd should be used to stop Midi-In,
        '--- else application exit code is 0xc0020001
        '**** MIGRATED ****

        ReconnectTimer.Enabled = False
        MIO.ProgEnd()


    End Sub

    Private Sub CmbMidiOutPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMidiOutPorts.SelectedIndexChanged
        '**** MIGRATED ****
        If Not hMidiOut = 0 Then
            MIO.CloseMidiOutPort(hMidiOut)
            hMidiOut = 0
        End If

        If CmbMidiOutPorts.SelectedItem IsNot Nothing Then
            Dim devName As String
            devName = CmbMidiOutPorts.SelectedItem.ToString

            MIO.OpenMidiOutPort(devName, hMidiOut, CmbMidiOutPorts.SelectedIndex)

        End If

    End Sub

    Private Sub CmbMidiInPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMidiInPorts.SelectedIndexChanged
        '**** MIGRATED ****
        If Not hMidiIn = 0 Then
            MIO.CloseMidiInPort(hMidiIn)
            hMidiIn = 0
        End If

        If CmbMidiInPorts.SelectedItem IsNot Nothing Then
            Dim devName As String
            devName = CmbMidiInPorts.SelectedItem.ToString

            MIO.OpenMidiInPort(devName, hMidiIn, CmbMidiInPorts.SelectedIndex)
        End If
    End Sub

    Private Sub BtnCloseOutput_Click(sender As Object, e As EventArgs) Handles btnCloseOutput.Click
        CloseOutput()
    End Sub

    Private Sub CloseOutput()
        '**** MIGRATED ****
        If Not hMidiOut = 0 Then
            MIO.CloseMidiOutPort(hMidiOut)
            hMidiOut = 0
        End If
        CmbMidiOutPorts.SelectedIndex = -1
    End Sub

    Private Sub BtnCloseInput_Click(sender As Object, e As EventArgs) Handles BtnCloseInput.Click
        CloseInput()
    End Sub

    Private Sub CloseInput()
        '**** MIGRATED ****
        If Not hMidiIn = 0 Then
            MIO.CloseMidiInPort(hMidiIn)
            hMidiIn = 0
        End If
        CmbMidiInPorts.SelectedIndex = -1
    End Sub

#End Region

#Region "SystemExclusive"

    ' "(?=[Ff][0])([\da-fA-F]{2}[ ]{1})+?([Ff][7])"     ' old: no restriction for data bytes to 7 bit
    Private ReadOnly sysxRegexPattern As String = "[Ff][0][ ]([0-7][\da-fA-F]{1}[ ]{1})+?[Ff][7]"


    Private Sub BtnSendSysx_Click(sender As Object, e As EventArgs) Handles BtnSendSysx.Click

        SendSysx(CbSysxInput.SelectedItem.ToString())

    End Sub

    Private Sub SendSysx(str As String)

        Dim sysxRegex As Text.RegularExpressions.Regex
        sysxRegex = New Text.RegularExpressions.Regex(sysxRegexPattern)

        Dim arr As String() = str.Split(CChar(" "))
        Dim sysxMsg As Byte() = New Byte(arr.Length - 1) {}

        For i = 1 To arr.Length
            sysxMsg(i - 1) = Convert.ToByte(arr(i - 1), 16)
        Next

        Try
            '---
            Dim ret As Integer
            ret = MIO.OutLongMsg(hMidiOut, sysxMsg)
            ShowHexBytes_Output(sysxMsg, ret)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Send Sysx error")
        End Try

    End Sub

#End Region

    Private Sub BtnRefreshPortList_Click(sender As Object, e As EventArgs) Handles BtnRefreshPortList.Click

        RefreshMidiPortList()

    End Sub

    Private Sub RefreshMidiPortList()
        '************** MIGRATED *****************

        '--- get the selected port names
        Dim output As String = CStr(CmbMidiOutPorts.SelectedItem)
        Dim input As String = CStr(CmbMidiInPorts.SelectedItem)

        MIO.RefreshPortList()                           ' closes all ports
        hMidiOut = 0
        hMidiIn = 0

        'Now try to populate the ports
        PopulatePorts()

        '--- try to re-select the ports, if available

        If output IsNot Nothing Then
            If CmbMidiOutPorts.Items.Contains(output) Then
                CmbMidiOutPorts.SelectedItem = output
            End If
        End If

        If input IsNot Nothing Then
            If CmbMidiInPorts.Items.Contains(input) Then
                CmbMidiInPorts.SelectedItem = input
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendButtonLamp(0, True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SendButtonLamp(0, False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendButtonLamp(1, True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SendButtonLamp(1, False)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SendButtonLamp(2, True)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SendButtonLamp(2, False)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SendButtonLamp(3, True)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SendButtonLamp(3, False)
    End Sub

    Private Sub SendButtonLamp(Button As Integer, Illuminate As Boolean)
        '************************MIGRATED~*************************
        Dim ChSelected As Integer = ChanelSelectComboBox.SelectedIndex
        If ChSelected >= 0 Then
            ChSelected = Button * 8 + ChSelected
            If Illuminate Then
                MidiOutShortMsg(hMidiOut, &H90, ChSelected, &H7F)
            Else
                MidiOutShortMsg(hMidiOut, &H90, ChSelected, &H0)
            End If
        End If
    End Sub

    Private Sub ChanelSelectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChanelSelectComboBox.SelectedIndexChanged

    End Sub

    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll

        Dim ChSelected As Integer = ChanelSelectComboBox.SelectedIndex

        'This relies on the faders being set to Min = 0 and Max = 2047

        If ChSelected >= 0 Then
            ChSelected = &HE0 Or ChSelected
            Dim upperByte As Integer = Volume.Value >> 4
            Dim lowerByte As Integer = (Volume.Value And &HF) << 2
            MidiOutShortMsg(hMidiOut, ChSelected, lowerByte, upperByte)

            VolPercent.Text = CInt(Volume.Value / 20.47).ToString() & " %"

        End If

    End Sub

    Private Sub CbSysxInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSysxInput.SelectedIndexChanged
        BtnSendSysx.Enabled = True
    End Sub

    Private Sub SendTopStrip_Click(sender As Object, e As EventArgs) Handles SendTopStrip.Click

        If ChanelSelectComboBox.SelectedIndex >= 0 Then
            SendScribbleStrip(ChanelSelectComboBox.SelectedIndex, True, ScribbleBoxTop.Text)
        End If

    End Sub

    Private Sub SendBottomStrip_Click(sender As Object, e As EventArgs) Handles SendBottomStrip.Click

        If ChanelSelectComboBox.SelectedIndex >= 0 Then
            SendScribbleStrip(ChanelSelectComboBox.SelectedIndex, False, ScribbleBoxBottom.Text)
        End If

    End Sub

    Private Sub SendScribbleStrip(ch As Integer, top As Boolean, msg As String)
        'First centre the message as best we can into 7 chars
        Select Case msg.Length
            Case 1
                msg = "   " & msg & "   "
            Case 2
                msg = "  " & msg & "   "
            Case 3
                msg = "  " & msg & "  "
            Case 4
                msg = " " & msg & "  "
            Case 5
                msg = " " & msg & " "
            Case 6
                msg &= " "
        End Select

        'Now add the SysEx header
        Dim hexString As String = "F0 00 00 66 15 12 "

        'add the channel
        If top Then
            hexString &= Hex(ch * 7)
        Else
            hexString &= Hex(ch * 7 + 56)
        End If

        'Now convert the message to hex string
        Dim stringBytes As Byte() = Encoding.ASCII.GetBytes(msg)
        For Each b As Byte In stringBytes
            hexString = hexString & " " & Strings.Right("00" & Hex(b), 2)
        Next

        'Finally add the end and send it
        SendSysx(hexString & " F7")

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles JogWheelLed.Scroll
        If ChanelSelectComboBox.SelectedIndex >= 0 Then
            SendJogWheel(ChanelSelectComboBox.SelectedIndex, JogWheelLed.Value, True)
        End If
    End Sub

    Private Sub SendJogWheel(ch As Integer, val As Integer, show As Boolean)
        'val = dB -12 to +12 step 0.1
        If show Then
            MidiOutShortMsg(hMidiOut, &HB0, &H30 Or ch, &H40 Or CInt((val * 0.41) + 22))
        Else
            MidiOutShortMsg(hMidiOut, &HB0, &H30 Or ch, &H0) 'value = 0 >> all LED's off
        End If
    End Sub


    Private Sub DisableLeds_Click(sender As Object, e As EventArgs) Handles DisableLeds.Click
        If ChanelSelectComboBox.SelectedIndex >= 0 Then
            SendJogWheel(ChanelSelectComboBox.SelectedIndex, 0, False)
        End If
    End Sub

    Private Sub ReconnectTimer_Tick(sender As Object, e As EventArgs) Handles ReconnectTimer.Tick
        'So an arrival we are going to check for ports - no matter that the state, as the watchdog is running
        'CloseOutput()
        'CloseInput()

        'Now try to close all reasouces
        'MIO.ProgEnd()

        'Now re should try to start up again
        RefreshMidiPortList()

        'First check if we have either midiIn or midiOur connected
        If hMidiOut = 0 Or hMidiIn = 0 Then

            'Now if we have X-Touch as a selection option, auto select it
            CmbMidiInPorts.SelectedIndex = CmbMidiInPorts.FindString("X-Touch-Ext")
            CmbMidiOutPorts.SelectedIndex = CmbMidiOutPorts.FindString("X-Touch-Ext")

            If hMidiOut > 0 And hMidiIn > 0 Then
                'We appear to be working so switch off the watchdog
                ReconnectTimer.Enabled = False
            End If

            'Finally push any setup
            'XXXXXX PUSH SET UP XXXXXXXX

        End If

    End Sub

    Private Sub SendVUMeters(pValue As Single)
        Dim ChSelected As Integer = ChanelSelectComboBox.SelectedIndex
        'Now we need to write the value to the meters
        If pValue > 1 Then
            MidiOutShortMsg(hMidiOut, &HD0, (ChSelected << 4) Or &HE, 0)
        ElseIf pValue > 0.001 Then
            MidiOutShortMsg(hMidiOut, &HD0, (ChSelected << 4) Or CInt(Math.Round(4 * Math.Log10(pValue) + 12)), 0)
        End If
    End Sub

    Private Sub VuButton01_Click(sender As Object, e As EventArgs) Handles VuButton01.Click
        SendVUMeters(CSng(0.1))
    End Sub

    Private Sub VuButton02_Click(sender As Object, e As EventArgs) Handles VuButton02.Click
        SendVUMeters(CSng(0.4))
    End Sub

    Private Sub VuButton03_Click(sender As Object, e As EventArgs) Handles VuButton03.Click
        SendVUMeters(CSng(0.7))
    End Sub

    Private Sub VuButton04_Click(sender As Object, e As EventArgs) Handles VuButton04.Click
        SendVUMeters(CSng(0.9))
    End Sub

    Private Sub VuButton05_Click(sender As Object, e As EventArgs) Handles VuButton05.Click
        SendVUMeters(CSng(1.1))
    End Sub
End Class
