﻿Public Class MessageControl
    Private msgXCoor As Integer = 10
    Private msgYCoor As Integer = 5
    Public Event SendBtnClicked(msg As String)

    'Send the messages when text is entered
    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        If Not String.IsNullOrWhiteSpace(MsgText.Text) Then
            RaiseEvent SendBtnClicked(MsgText.Text)
        End If

    End Sub

    'Startup code for Message control
    Private Sub MessageControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgPanel.VerticalScroll.Value = MsgPanel.VerticalScroll.Maximum
        MsgPanel.Controls.Clear()
    End Sub

    'Adds a new message to the message control
    Public Sub AddMsg(sender As String, msg As String)
        Dim sentMsg As UserMsgControl = New UserMsgControl(sender, msg)

        Dim yCoorOfset As Integer = sentMsg.Height + 15
        MsgPanel.Controls.Add(sentMsg)
        MsgPanel.Height = Math.Max(msgYCoor + yCoorOfset, MsgPanel.Height)

        sentMsg.Location = New Point(msgXCoor, msgYCoor)
        msgYCoor += yCoorOfset

        MsgPanelContainer.VerticalScroll.Value = MsgPanelContainer.VerticalScroll.Maximum
    End Sub

End Class
