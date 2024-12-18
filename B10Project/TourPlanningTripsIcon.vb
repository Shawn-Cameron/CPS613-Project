﻿Public Class TourPlanningTripsIcon

    'Creates a new Card for MainControl page
    Public Sub New(cardData As Dictionary(Of String, String), timeToReach As Integer, stayTime As Integer)
        InitializeComponent()
        ImgBox.Image = Image.FromFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", cardData("file")))
        ImgBox.SizeMode = PictureBoxSizeMode.Zoom

        NameLabel.Text = cardData("title")
        Form1.locations.Add(cardData("title"))
        YearLabel.Text = cardData("year")
        Form1.years.Add(cardData("year"))
        LocLabel.Text = cardData("location")
        durationLabel.Text = stayTime.ToString()
        CardPanel.Size = New Size(148, 193)
        TravelingArrow1.TimeLabel.Text = timeToReach.ToString()
    End Sub

    'Changes Control Height to show edit buttons
    Public Sub EnableEdit()
        CardPanel.Size = New Size(148, 271)
    End Sub

    'Changes Control Height to hide buttons
    Public Sub DisableEdit()
        CardPanel.Size = New Size(148, 193)
    End Sub

    'Adds a transparent background
    Private Sub TourPlanningTripsIcon_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    'Reduces the current stay time of the location
    Private Sub rmTimeBtn_Click(sender As Object, e As EventArgs) Handles rmTimeBtn.Click
        Dim val As Integer = Integer.Parse(durationLabel.Text)
        If val > 30 Then
            durationLabel.Text = (val - 10).ToString()
            Form1.MainControl1.TimeRemoved()
        End If

    End Sub

    'Increase the current stay time of the location
    Private Sub addTimeBtn_Click(sender As Object, e As EventArgs) Handles addTimeBtn.Click
        Dim val As Integer = Integer.Parse(durationLabel.Text)
        If val < 120 Then
            durationLabel.Text = (val + 10).ToString()
            Form1.MainControl1.TimeAdded()
        End If
    End Sub

    'Removes the current location from Main Control
    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Form1.MainControl1.RemoveCard(Me)
        Form1.locations.Remove(Me.NameLabel.Text)
        Form1.years.Remove(Me.YearLabel.Text)
    End Sub

    'Moves the current location to the left in Main Control
    Private Sub moveLeftBtn_Click(sender As Object, e As EventArgs) Handles moveLeftBtn.Click
        Form1.MainControl1.MoveCardLeft(Me)
    End Sub

    'Moves the current location to the Right in Main Control
    Private Sub moveRightBtn_Click(sender As Object, e As EventArgs) Handles moveRightBtn.Click
        Form1.MainControl1.MoveCardRight(Me)
    End Sub


    ' Main Panel size (148, 193)
End Class
