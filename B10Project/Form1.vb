﻿Public Class Form1
    Public Shared locations As New List(Of String)
    Public Shared years As New List(Of Integer)
    Public Shared ind As Integer = 0
    Private showMsg As Boolean = False
    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub SwitchForms()
        If MainControl1.Visible Then
            MainControl1.Visible = False
            AddLocationForm1.Visible = True
        Else
            MainControl1.Visible = True
            AddLocationForm1.Visible = False
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub MainControl1_Load(sender As Object, e As EventArgs) Handles MainControl1.Load
        Pilot.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(984, 647)
    End Sub

    Private Sub MsgToggle_Click(sender As Object, e As EventArgs) Handles MsgToggle.Click
        showMsg = Not showMsg
        If showMsg Then
            Me.Size = New Size(1364, 647)
        Else
            Me.Size = New Size(984, 647)
        End If
    End Sub
End Class
