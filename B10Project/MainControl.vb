Imports System.Net

Public Class MainControl
    Dim locList As New List(Of List(Of Object))
    Dim editing As Boolean = False

    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        EditTripBtn_Click(Nothing, EventArgs.Empty)
        Form1.SwitchForms()
    End Sub

    Public Sub AddNewLocation(cardData As Dictionary(Of String, String), timeToReach As String, stayDur As String)
        Dim newRemainingTime As Integer = Integer.Parse(TimeRemainingLabel.Text) - Integer.Parse(timeToReach) - Integer.Parse(stayDur)
        If (newRemainingTime < 0) Then
            Return
        End If

        TimeRemainingLabel.Text = newRemainingTime.ToString()

        Dim arrow As TravelingArrow = New TravelingArrow(timeToReach)
        Dim card As TourPlanningTripsIcon = New TourPlanningTripsIcon(cardData, stayDur)
        Dim removeCardBtn As Button = New Button()
        Dim moveCardLeftBtm As Button = New Button()
        Dim moveCardRightBtm As Button = New Button()
        Dim addTimeBtn As Button = New Button()
        Dim removeTimeBtn As Button = New Button()

        'Add buttons to TourPlanningTripsIcon later
        removeCardBtn.Text = "Remove"
        moveCardLeftBtm.Text = "Move Left"
        moveCardRightBtm.Text = "Move Right"
        addTimeBtn.Text = "+10 Min"
        removeTimeBtn.Text = "-10 Min"

        moveCardLeftBtm.Size = New Size(moveCardLeftBtm.Size.Width + 10, moveCardLeftBtm.Size.Height)
        moveCardRightBtm.Size = New Size(moveCardRightBtm.Size.Width + 10, moveCardRightBtm.Size.Height)
        addTimeBtn.Size = New Size(addTimeBtn.Size.Width + 10, addTimeBtn.Size.Height)
        removeTimeBtn.Size = New Size(removeTimeBtn.Size.Width + 10, removeTimeBtn.Size.Height)

        AddHandler removeCardBtn.Click, AddressOf RemoveButtonClick
        AddHandler moveCardLeftBtm.Click, AddressOf MoveCardLeft
        AddHandler moveCardRightBtm.Click, AddressOf MoveCardRight
        AddHandler addTimeBtn.Click, AddressOf AddTimeToLocation
        AddHandler removeTimeBtn.Click, AddressOf RemoveTimeFromLocation

        Dim collection As New List(Of Object) From {arrow, card, removeCardBtn, moveCardLeftBtm, moveCardRightBtm, addTimeBtn, removeTimeBtn}
        removeCardBtn.Tag = collection
        moveCardLeftBtm.Tag = collection
        moveCardRightBtm.Tag = collection
        addTimeBtn.Tag = collection
        removeTimeBtn.Tag = collection

        removeCardBtn.Visible = False
        moveCardLeftBtm.Visible = False
        moveCardRightBtm.Visible = False
        addTimeBtn.Visible = False
        removeTimeBtn.Visible = False

        locList.Add(collection)

        PopulateLocations()

        EmptyLocLabel.Visible = False

    End Sub

    Private Sub PopulateLocations()
        LocPanel.Controls.Clear()
        Dim xCoor As Integer = 0
        Dim yCoor As Integer = 100


        'For Each item In locList
        For index As Integer = 0 To locList.Count - 1

            LocPanel.Controls.Add(locList(index)(0))
            LocPanel.Controls.Add(locList(index)(1))
            LocPanel.Controls.Add(locList(index)(2))
            LocPanel.Controls.Add(locList(index)(3))
            LocPanel.Controls.Add(locList(index)(4))
            LocPanel.Controls.Add(locList(index)(5))
            LocPanel.Controls.Add(locList(index)(6))

            locList(index)(0).Location = New Point(xCoor, yCoor)
            xCoor += 80
            yCoor -= 80

            locList(index)(1).Location = New Point(xCoor, yCoor)

            xCoor += 35
            yCoor += 210
            locList(index)(2).Location = New Point(xCoor, yCoor)

            yCoor += 25
            xCoor -= 50
            locList(index)(3).Location = New Point(xCoor, yCoor)

            yCoor += 25
            locList(index)(6).Location = New Point(xCoor, yCoor)

            xCoor += 85
            locList(index)(5).Location = New Point(xCoor, yCoor)

            yCoor -= 25
            locList(index)(4).Location = New Point(xCoor, yCoor)

            yCoor = 100
            xCoor += 85


            locList(index)(3).Enabled = True
            locList(index)(4).Enabled = True

            If index = 0 Then
                locList(index)(3).Enabled = False
            End If

            If index = locList.Count - 1 Then
                locList(index)(4).Enabled = False
            End If
        Next


    End Sub

    Private Sub EditTripBtn_Click(sender As Object, e As EventArgs) Handles EditTripBtn.Click

        If locList.Count = 0 And editing Then
            EditLabel.Visible = False
            EditTripBtn.Text = "Edit Tour"
            editing = Not editing
            Return
        End If

        If locList.Count = 0 Then
            Return
        End If

        editing = Not editing

        If editing Then
            EditLabel.Visible = True
            EditTripBtn.Text = "Finish Editing"
            For Each item In locList
                item(2).Visible = True
                item(3).Visible = True
                item(4).Visible = True
                item(5).Visible = True
                item(6).Visible = True

            Next
        Else
            EditLabel.Visible = False
            EditTripBtn.Text = "Edit Tour"
            For Each item In locList
                item(2).Visible = False
                item(3).Visible = False
                item(4).Visible = False
                item(5).Visible = False
                item(6).Visible = False
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        If Integer.Parse(TimeRemainingLabel.Text) >= 10 Then
            response = MsgBox("You have enough time remaining to either extend one of your trips or add another location. Would you still like to continue?", vbYesNo, "Proceed?")
            If response = vbYes Then
                Pilot.Button1.Enabled = True
                Pilot.Label1.Text = "The trip has been confirmed"
                AddLocBtn.Enabled = False
                EditTripBtn.Enabled = False
                Button1.Enabled = False
                Label5.Text = "Flying To Destination"
            End If
        End If
    End Sub

    Private Sub MainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditLabel.Visible = False
    End Sub

    Private Sub RemoveButtonClick(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        locList.Remove(DirectCast(clickedBtn.Tag, List(Of Object)))

        Dim stayTime As Integer = Integer.Parse(clickedBtn.Tag(1).GetDurationValue())
        Dim travelTime As Integer = clickedBtn.Tag(0).GetTravelTime()
        Dim curRemainTime As Integer = Integer.Parse(TimeRemainingLabel.Text)
        TimeRemainingLabel.Text = (curRemainTime + stayTime + travelTime).ToString()
        PopulateLocations()

        If locList.Count = 0 Then
            LocPanel.Controls.Add(EmptyLocLabel)
            EmptyLocLabel.Visible = True
            EditTripBtn_Click(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub MoveCardLeft(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        Dim index As Integer = locList.IndexOf(clickedBtn.Tag)

        locList.Remove(DirectCast(clickedBtn.Tag, List(Of Object)))
        locList.Insert(index - 1, clickedBtn.Tag)
        PopulateLocations()
    End Sub

    Private Sub MoveCardRight(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        Dim index As Integer = locList.IndexOf(clickedBtn.Tag)

        locList.Remove(DirectCast(clickedBtn.Tag, List(Of Object)))
        locList.Insert(index + 1, clickedBtn.Tag)
        PopulateLocations()
    End Sub

    Private Sub AddTimeToLocation(sender As Object, e As EventArgs)

        Dim clickedBtn As Button = DirectCast(sender, Button)
        Dim remainingTime As Integer = Integer.Parse(TimeRemainingLabel.Text)
        Dim stayTime As Integer = Integer.Parse(clickedBtn.Tag(1).GetDurationValue())

        If (remainingTime - 10 >= 0 And stayTime < 120) Then
            clickedBtn.Tag(1).SetDurationText((stayTime + 10).ToString())
            TimeRemainingLabel.Text = (remainingTime - 10).ToString()
        End If

    End Sub

    Private Sub RemoveTimeFromLocation(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        Dim remainingTime As Integer = Integer.Parse(TimeRemainingLabel.Text)
        Dim stayTime As Integer = Integer.Parse(clickedBtn.Tag(1).GetDurationValue())

        If (remainingTime + 10 < 360 And stayTime > 30) Then
            clickedBtn.Tag(1).SetDurationText((stayTime - 10).ToString())
            TimeRemainingLabel.Text = (remainingTime + 10).ToString()
        End If
    End Sub
End Class
