﻿Imports System.IO
Imports AxWMPLib

Public Class LocationPage
    Private imagePaths As List(Of String) = New List(Of String)()
    Private currentIndex As Integer = 0
    Private _cardData As LocationContentCard
    Private currentTime As Integer
    Private _timeToReach As Integer

    'Opens a new page when a content card is clicked on add location page
    Public Sub New(cardData As LocationContentCard, timeToReach As Integer)
        InitializeComponent()
        _cardData = cardData
        DescripLabel.Text = cardData.myData("Loc Description")
        TimeToReachLabel.Text = timeToReach.ToString()
        _timeToReach = timeToReach
        Dim filesToUse As String() = cardData.myData("images").Split(" ")

        For Each item In filesToUse
            Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", item)
            imagePaths.Add(imgPath)
        Next

        RoundButton1_Click(Nothing, EventArgs.Empty)
    End Sub

    'Changes the displayed image to the one before it in the list
    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        If imagePaths.Count > 0 Then
            currentIndex -= 1
        End If
        If currentIndex < 0 Then
            currentIndex = imagePaths.Count - 1
        End If
        showImgOrVid()
    End Sub

    'Changes the displayed image to the one after it in the list
    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        If imagePaths.Count > 0 Then
            currentIndex += 1
        End If
        If currentIndex >= imagePaths.Count Then
            currentIndex = 0
        End If
        showImgOrVid()
    End Sub

    'Displays images or video based on the currently displayed file
    Private Sub showImgOrVid()
        If imagePaths(currentIndex).EndsWith(".mp4", StringComparison.OrdinalIgnoreCase) Then
            MediaPlayer.Visible = True
            PlayPauseBtn.Visible = True
            PlaySpeedBtn.Visible = True
            FastFwrdBtn.Visible = True
            RewindBtn.Visible = True
            RestartBtn.Visible = True

            MediaPlayer.URL = imagePaths(currentIndex)
            MediaPlayer.Ctlcontrols.play()
        Else
            MediaPlayer.Ctlcontrols.stop()
            MediaPlayer.Visible = False
            PlayPauseBtn.Visible = False
            PlaySpeedBtn.Visible = False
            FastFwrdBtn.Visible = False
            RewindBtn.Visible = False
            RestartBtn.Visible = False

            PictureBox1.Image = Image.FromFile(imagePaths(currentIndex))
        End If

    End Sub

    'Hides video controls on load
    Private Sub LocationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MediaPlayer.Visible = False
        MediaPlayer.uiMode = "None"
        PlayPauseBtn.Visible = False
        PlaySpeedBtn.Visible = False
        FastFwrdBtn.Visible = False
        RewindBtn.Visible = False
        RestartBtn.Visible = False
        currentTime = Integer.Parse(timeLabel.Text)
    End Sub


    'Reduces the amount of stay time at the location
    Private Sub RmTimeBtn_Click(sender As Object, e As EventArgs) Handles RmTimeBtn.Click
        If currentTime > 30 Then
            currentTime -= 10
        End If
        timeLabel.Text = currentTime.ToString()
    End Sub

    'Increases the amount of stay time at the location
    Private Sub AddTimeBtn_Click(sender As Object, e As EventArgs) Handles AddTimeBtn.Click
        If currentTime < 120 Then
            currentTime += 10
        End If
        timeLabel.Text = currentTime.ToString()

    End Sub

    'Closes form when back button is clicked
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
    End Sub

    'Add the location to the Main Control
    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        Form1.MainControl1.Button1.Enabled = True
        Form1.MainControl1.AddNewLocation(_cardData.myData, _timeToReach, currentTime)
        Form1.SwitchForms()
        Me.Close()
    End Sub

    'Pauses/Continues the video when button is clicked
    Private Sub PlayPauseBtn_Click(sender As Object, e As EventArgs) Handles PlayPauseBtn.Click
        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            MediaPlayer.Ctlcontrols.pause()
            PlayPauseBtn.Text = "►"
        Else
            MediaPlayer.Ctlcontrols.play()
            PlayPauseBtn.Text = "||"
        End If
    End Sub

    'Rewinds the video by 5 seconds
    Private Sub RewindBtn_Click(sender As Object, e As EventArgs) Handles RewindBtn.Click
        If MediaPlayer.Ctlcontrols.currentPosition > 5 Then
            MediaPlayer.Ctlcontrols.currentPosition -= 5
        Else
            MediaPlayer.Ctlcontrols.currentPosition = 0
        End If
    End Sub

    'Fast forwards the button by 5 seconds
    Private Sub FastFwrdBtn_Click(sender As Object, e As EventArgs) Handles FastFwrdBtn.Click
        If MediaPlayer.Ctlcontrols.currentPosition + 5 < MediaPlayer.currentMedia.duration Then
            MediaPlayer.Ctlcontrols.currentPosition += 5
        Else
            MediaPlayer.Ctlcontrols.currentPosition = MediaPlayer.currentMedia.duration
        End If
    End Sub

    'Restarts the video
    Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        MediaPlayer.Ctlcontrols.currentPosition = 0
    End Sub

    'Changes the play speed based on the previous speed. Must click button multiple times
    Private Sub PlaySpeedBtn_Click(sender As Object, e As EventArgs) Handles PlaySpeedBtn.Click
        If MediaPlayer.settings.rate > 1 Then
            MediaPlayer.settings.rate = 0.5
            PlaySpeedBtn.Text = "x0.5"

        ElseIf MediaPlayer.settings.rate = 1 Then
            MediaPlayer.settings.rate = 2
            PlaySpeedBtn.Text = "x2"
        Else
            MediaPlayer.settings.rate = 1
            PlaySpeedBtn.Text = "x1"
        End If
    End Sub
End Class