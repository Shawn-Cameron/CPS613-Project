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

        removeCardBtn.Text = "Remove"

        LocPanel.Controls.Add(arrow)
        LocPanel.Controls.Add(card)
        LocPanel.Controls.Add(removeCardBtn)

        locList.Add(New List(Of Object) From {arrow, card, removeCardBtn})
        PopulateLocations()

    End Sub

<<<<<<< HEAD
    Private Sub PopulateLocations()
        Dim xCoor As Integer = 0
        Dim yCoor As Integer = 100

        For Each item In locList

            item(0).Location = New Point(xCoor, yCoor)
            xCoor += 80
            yCoor -= 80

            item(1).Location = New Point(xCoor, yCoor)

            xCoor += 35
            yCoor += 210
            item(2).Location = New Point(xCoor, yCoor)


            yCoor -= 130
            xCoor += 115
        Next


    End Sub

    Private Sub EditTripBtn_Click(sender As Object, e As EventArgs) Handles EditTripBtn.Click
        editing = Not editing

        If editing Then

        End If
    End Sub

=======
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pilot.Button1.Enabled = True
        Pilot.Label1.Text = "The trip has been confirmed"
    End Sub

    Private Sub MainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pilot.Show()
    End Sub
>>>>>>> Pilot
End Class
