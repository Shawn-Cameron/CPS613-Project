Public Class AddLocationForm
    Protected searchBar As SearchBar
    Private nextXCoor As Integer = 0
    Private nextYCoor As Integer = 0

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        AddToLocationPanel()

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

        AddHandler FilterMenu.ComboBoxIndexChanged, AddressOf FilterSelectionsChanged
        AddHandler searchBar.TextChanged, AddressOf FilterSelectionsChanged
    End Sub

    'Dyamically adds all content cards to the Add Location Panel
    Public Sub AddToLocationPanel()
        Dim items As List(Of Dictionary(Of String, String)) = GetContentCardsData()
        LocationPanels.Controls.Clear()
        nextXCoor = 0
        nextYCoor = 0

        For Each item As Dictionary(Of String, String) In items
            If filterContentCards(item) Then
                Dim ContentCard As LocationContentCard = New LocationContentCard(item("file"), item("description"), item("location"), item("year"), item("ratings"))
                LocationPanels.Controls.Add(ContentCard)
                ContentCard.Location = New Point(nextXCoor, nextYCoor)
                SetNextCCLocation()
            End If

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

    Private Function filterContentCards(cardData As Dictionary(Of String, String))
        Dim results As List(Of List(Of String)) = FilterMenu.GetFilterOptions()
        Dim options As List(Of String) = results(0)
        Dim continents As List(Of String) = results(1)

        Dim optionsIsTrue As Boolean = False
        Dim continentsIsTrue As Boolean = False
        Dim searchIsTrue As Boolean = False

        If options.Count = 0 Then
            optionsIsTrue = True
        Else
            Dim value As Integer = CInt(cardData("year"))
            optionsIsTrue = (value >= 2372 And options.Contains("Future")) Or (value < 2372 And options.Contains("Past")) Or (CSng(cardData("ratings")) > 4.0 And options.Contains("Most Popular"))

        End If

        If continents.Count = 0 Then
            continentsIsTrue = True
        Else
            continentsIsTrue = continents.Contains(cardData("continent"))
        End If

        If String.IsNullOrWhiteSpace(searchBar.Text) Then
            searchIsTrue = True
        Else
            searchIsTrue = cardData("continent").StartsWith(searchBar.Text)
        End If

        Return optionsIsTrue And continentsIsTrue And searchIsTrue
    End Function

    Private Sub FilterSelectionsChanged(sender As Object, e As EventArgs)
        AddToLocationPanel()
    End Sub

    'Returns the list of all the data for the content cards
    Private Function GetContentCardsData()
        Dim items As New List(Of Dictionary(Of String, String)) From {
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "This is Square One the places of the places with the places of the places with the places of the places "},
                {"location", "North America"},
                {"year", "2015"},
                {"ratings", "4.5"},
                {"continent", "North America"}
            },
            New Dictionary(Of String, String) From {
                {"file", "eiffelTower.jpg"},
                {"description", "Square One"},
                {"location", "Asia"},
                {"year", "1990"},
                {"ratings", "1.2"},
                {"continent", "Asia"}
            },
            New Dictionary(Of String, String) From {
                {"file", "SquareOne.jpg"},
                {"description", "Square One"},
                {"location", "South America"},
                {"year", "3000"},
                {"ratings", "5.0"},
                {"continent", "South America"}
            }
        }

        Return items

    End Function
End Class
