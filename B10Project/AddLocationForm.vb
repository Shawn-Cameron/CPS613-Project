Public Class AddLocationForm
    Protected searchBar As SearchBar
    Private nextXCoor As Integer = 0
    Private nextYCoor As Integer = 0

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.SwitchForms()
        searchBar.Text = ""
        FilterMenu.filterBtnToggle = False
        FilterMenu.continentsBtnToggle = False
        FilterMenu.FilterOptionsUpdate()

    End Sub

    Private Sub AddLocationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim searchBarControl As New SearchBar()
        searchBarControl.Location = SearchTextBoxPlaceholder.Location
        searchBarControl.Size = SearchTextBoxPlaceholder.Size
        Me.Controls.Add(searchBarControl)
        Me.Controls.Remove(SearchTextBoxPlaceholder)

        searchBar = searchBarControl
        AddToLocationPanel()
    End Sub

    'Dyamically adds all content cards to the Add Location Panel
    Private Sub AddToLocationPanel()
        Dim items As List(Of Dictionary(Of String, String)) = GetContentCardsData()

        For Each item As Dictionary(Of String, String) In items
            Dim ContentCard As LocationContentCard = New LocationContentCard(item("file"), item("description"), item("location"), item("year"), item("ratings"))
            LocationPanels.Controls.Add(ContentCard)
            ContentCard.Location = New Point(nextXCoor, nextYCoor)
            SetNextCCLocation()
        Next

        LocationPanels.AutoScrollMinSize = New Size(LocationPanels.Width, nextYCoor + 300)
    End Sub

    'Updates the coordinates to support adding more cards 
    Private Sub SetNextCCLocation()
        nextXCoor += 220
        If nextXCoor >= 750 Then
            nextXCoor = 0
            nextYCoor += 260
        End If

    End Sub


    'Returns the list of all the data for the content cards
    Private Function GetContentCardsData()
        Dim items As New List(Of Dictionary(Of String, String)) From {
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "This is Square One the places of the places with the places of the places with the places of the places "},
                {"location", "Mississauga"},
                {"year", "2015"},
                {"ratings", "4.5"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "here"},
                {"year", "1990"},
                {"ratings", "1.2"}
            }
        }

        Return items

    End Function
End Class
