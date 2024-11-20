Public Class MainControl
    Dim locList As New List(Of List(Of Object))
    Dim editing As Boolean = False

    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        Form1.SwitchForms()
    End Sub

    Public Sub AddNewLocation(cardData As Dictionary(Of String, String), timeToReach As String, stayDur As String)
        Dim arrow As TravelingArrow = New TravelingArrow(timeToReach)
        Dim card As TourPlanningTripsIcon = New TourPlanningTripsIcon(cardData, stayDur)
        Dim removeCardBtn As Button = New Button()
        Dim moveCardLeftBtm As Button = New Button()
        Dim moveCardRightBtm As Button = New Button()

        removeCardBtn.Text = "Remove"
        moveCardLeftBtm.Text = "Move Left"
        moveCardRightBtm.Text = "Move Right"

        moveCardLeftBtm.Size = New Size(moveCardLeftBtm.Size.Width + 10, moveCardLeftBtm.Size.Height)
        moveCardRightBtm.Size = New Size(moveCardRightBtm.Size.Width + 10, moveCardRightBtm.Size.Height)

        AddHandler removeCardBtn.Click, AddressOf RemoveButtonClick
        AddHandler moveCardLeftBtm.Click, AddressOf MoveCardLeft
        AddHandler moveCardRightBtm.Click, AddressOf MoveCardRight

        Dim collection As New List(Of Object) From {arrow, card, removeCardBtn, moveCardLeftBtm, moveCardRightBtm}
        removeCardBtn.Tag = collection
        moveCardLeftBtm.Tag = collection
        moveCardRightBtm.Tag = collection

        removeCardBtn.Visible = False
        moveCardLeftBtm.Visible = False
        moveCardRightBtm.Visible = False

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

            xCoor += 85
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
            Next
        Else
            EditLabel.Visible = False
            EditTripBtn.Text = "Edit Tour"
            For Each item In locList
                item(2).Visible = False
                item(3).Visible = False
                item(4).Visible = False
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pilot.Button1.Enabled = True
        Pilot.Label1.Text = "The trip has been confirmed"
    End Sub

    Private Sub MainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pilot.Show()
        EditLabel.Visible = False
    End Sub

    Private Sub RemoveButtonClick(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        locList.Remove(DirectCast(clickedBtn.Tag, List(Of Object)))
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
End Class
