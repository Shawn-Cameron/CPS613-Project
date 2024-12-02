Imports System.Net

Public Class MainControl
    Dim cardList As New List(Of TourPlanningTripsIcon)
    Dim editing As Boolean = False

    'Switches the display to show the AddLocationForm User control
    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        Form1.SwitchForms()
    End Sub


    'Adds a new trip to the to the tour planning screen
    Public Sub AddNewLocation(cardData As Dictionary(Of String, String), timeToReach As String, stayDur As String)
        Dim newRemainingTime As Integer = Integer.Parse(TimeRemainingLabel.Text) - Integer.Parse(timeToReach) - Integer.Parse(stayDur)
        If (newRemainingTime < 0) Then
            Return
        End If

        TimeRemainingLabel.Text = newRemainingTime.ToString()

        Dim card As TourPlanningTripsIcon = New TourPlanningTripsIcon(cardData, timeToReach, stayDur)

        cardList.Add(card)
        PopulateLocations()

        EmptyLocLabel.Visible = False

    End Sub

    'Updates the current locations in the tour planning screen. Called each time when changes are made
    Private Sub PopulateLocations()
        LocPanel.Controls.Clear()

        If cardList.Count = 0 Then
            LocPanel.Controls.Add(EmptyLocLabel)
            EmptyLocLabel.Visible = True
            Return
        End If

        Dim xCoor As Integer = 0
        Dim yCoor As Integer = 0

        For index As Integer = 0 To cardList.Count - 1
            LocPanel.Controls.Add(cardList(index))
            cardList(index).Location = New Point(xCoor, yCoor)
            xCoor += 225

            cardList(index).moveLeftBtn.Enabled = True
            cardList(index).moveRightBtn.Enabled = True

            If index = 0 Then
                cardList(index).moveLeftBtn.Enabled = False
            End If

            If index = cardList.Count - 1 Then
                cardList(index).moveRightBtn.Enabled = False
            End If
        Next


    End Sub

    'Toggles editing mode for the trips
    Private Sub EditTripBtn_Click(sender As Object, e As EventArgs) Handles EditTripBtn.Click

        If cardList.Count = 0 And editing Then
            EditLabel.Visible = False
            EditTripBtn.Text = "Edit Tour"
            editing = Not editing
            Return
        End If

        If cardList.Count = 0 Then
            Return
        End If

        editing = Not editing

        If editing Then
            EditLabel.Visible = True
            EditTripBtn.Text = "Finish Editing"
            For Each item In cardList
                item.EnableEdit()

            Next
        Else
            EditLabel.Visible = False
            EditTripBtn.Text = "Edit Tour"
            For Each item In cardList
                item.DisableEdit()
            Next
        End If
    End Sub

    'Allows users to confirm trip and sends the current trip to the pilot 
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        If Integer.Parse(TimeRemainingLabel.Text) >= 10 Then
            response = MsgBox("You have enough time remaining to either extend one of your trips or add another location. Would you still like to confirm?", vbYesNo, "Proceed?")
            If response = vbYes Then
                Pilot.Button1.Enabled = True
                Pilot.Label7.Text = "The trip has been confirmed"
                Pilot.Label1.Text = "Setting Course for " & Form1.locations(Form1.ind)
                AddLocBtn.Enabled = False
                EditTripBtn.Enabled = False
                Button1.Enabled = False
                Label5.Text = "Waiting on Pilot"
                Label5.BringToFront()
            End If
        Else
            Pilot.Button1.Enabled = True
            Pilot.Label7.Text = "The trip has been confirmed"
            Pilot.Label1.Text = "Setting Course for " & Form1.locations(Form1.ind)
            AddLocBtn.Enabled = False
            EditTripBtn.Enabled = False
            Button1.Enabled = False
            Label5.Text = "Waiting on Pilot"
            Label5.BringToFront()
        End If
        Label7.Visible = True
        TimeElapsedLabel.Visible = True
        TimeRemainingLabel.Text = (360 - Integer.Parse(TimeRemainingLabel.Text)).ToString()
    End Sub


    Private Sub MainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditLabel.Visible = False

    End Sub

    'Updates the remaining time for the trip 
    Public Sub TimeRemoved()
        TimeRemainingLabel.Text = (Integer.Parse(TimeRemainingLabel.Text) + 10).ToString()
    End Sub

    'Updates the remaining time for the trip
    Public Sub TimeAdded()
        TimeRemainingLabel.Text = (Integer.Parse(TimeRemainingLabel.Text) - 10).ToString()
    End Sub

    'Removes a card from the list an updates the trips
    Public Sub RemoveCard(card As TourPlanningTripsIcon)
        cardList.Remove(card)
        PopulateLocations()
    End Sub

    'Switches the selected card location with the one on the left
    Public Sub MoveCardLeft(card As TourPlanningTripsIcon)
        Dim index As Integer = cardList.IndexOf(card)
        cardList.Remove(card)
        cardList.Insert(index - 1, card)
        PopulateLocations()
    End Sub

    'Switches the selected card location with the one on the right
    Public Sub MoveCardRight(card As TourPlanningTripsIcon)
        Dim index As Integer = cardList.IndexOf(card)
        cardList.Remove(card)
        cardList.Insert(index + 1, card)
        PopulateLocations()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Window.Show()
    End Sub

    'Used when Trip is confirmed. Updates the time remaining and time elasped to show visitors how much time is left for the trip
    Public Sub TimerTicked()
        TimeRemainingLabel.Text = (Integer.Parse(TimeRemainingLabel.Text) - 1).ToString()
        TimeElapsedLabel.Text = (Integer.Parse(TimeElapsedLabel.Text) + 1).ToString()
    End Sub
End Class
