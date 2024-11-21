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
                Dim ContentCard As LocationContentCard = New LocationContentCard(item)
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
            optionsIsTrue = (value >= 2172 And options.Contains("Future")) Or (value < 2172 And options.Contains("Past")) Or (CSng(cardData("ratings")) > 4.0 And options.Contains("Most Popular"))

        End If

        If continents.Count = 0 Then
            continentsIsTrue = True
        Else
            continentsIsTrue = continents.Contains(cardData("continent"))
        End If

        If String.IsNullOrWhiteSpace(searchBar.Text) Then
            searchIsTrue = True
        Else
            searchIsTrue = cardData("title").StartsWith(searchBar.Text)
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
                {"title", "The Library of Alexandria"},
                {"file", "AlexLib1.jpg"},
                {"description", "A hub of ancient knowledge and learning"},
                {"location", "Alexandria, Egypt"},
                {"year", "-300"},
                {"ratings", "4.5"},
                {"continent", "Africa"},
                {"Loc Description", "Description: The Library of Alexandria was an unparalleled center of knowledge and learning in the ancient world. Founded in the 3rd century BCE during the reign of Pharaoh Ptolemy II, the library aimed to collect all the world’s knowledge in one place. Situated in the city of Alexandria, Egypt, it was part of a larger research institution known as the Mouseion, dedicated to the study of science, literature, and philosophy."},
                {"images", "AlexLib1.jpg AlexLib2.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "The Hanging Gardens of Babylon"},
                {"file", "babylon.jpg"},
                {"description", "One of the Seven Wonders of the Ancient World"},
                {"location", "Asia"},
                {"year", "-600"},
                {"ratings", "3.2"},
                {"continent", "Asia"},
                {"Loc Description", "Description: The Hanging Gardens of Babylon, one of the Seven Wonders of the Ancient World, is shrouded in legend and mystery. Believed to have been built in 600 BCE by King Nebuchadnezzar II for his queen, Amytis, the gardens were a breathtaking display of architectural and engineering brilliance. According to ancient accounts, the gardens featured tiered terraces covered with lush vegetation, cascading waterfalls, and vibrant flowers, creating the illusion of a green mountain in the heart of the arid Mesopotamian landscape."},
                {"images", "babylon.jpg babylon2.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "The First Olympic Games"},
                {"file", "Olympic1.jpg"},
                {"description", "The original Olympic games held in Olympia"},
                {"location", "Olympia, Greece"},
                {"year", "-776"},
                {"ratings", "4.9"},
                {"continent", "Europe"},
                {"Loc Description", "Description: The First Olympic Games, held in 776 BCE in Olympia, Greece, marked the beginning of one of humanity's longest-standing traditions. Originally conceived as a religious festival to honor Zeus, the king of the Greek gods, the games were held every four years in a sacred grove. Athletes from city-states across ancient Greece competed in events that tested physical prowess and endurance, including foot races, wrestling, chariot racing, and discus throwing."},
                {"images", "Olympic1.jpg Olymic2.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "The Construction of the Great Pyramids of Giza"},
                {"file", "pyramids.jpg"},
                {"description", "The marvel of ancient engineering and human ingenuity"},
                {"location", "Olympia, Greece"},
                {"year", "-776"},
                {"ratings", "4.9"},
                {"continent", "Europe"},
                {"Loc Description", "Description: Witnessing the construction of the Great Pyramid of Giza, a marvel of ancient engineering and human ingenuity, would be a breathtaking experience. Built as a tomb for Pharaoh Khufu, this towering structure—standing at an original height of 146.6 meters—was constructed using massive limestone and granite blocks, some weighing up to 80 tons. Time travelers could observe the intricate logistics of transporting these stones from quarries using sledges and ramps, the labor force of skilled workers and conscripts, and the cultural and religious significance of this enduring monument. The site, bustling with activity, would reveal the advanced techniques and sheer determination that defined ancient Egypt's golden age."},
                {"images", "pyramids.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "Rewilded Amazon Biosphere"},
                {"file", "amazon3.jpg"},
                {"description", "The restored Amazon rainforest preserved thought technology"},
                {"location", "Amazon Basin, South America"},
                {"year", "2550"},
                {"ratings", "3.9"},
                {"continent", "South America"},
                {"Loc Description", "Description: The Rewilded Amazon Biosphere is a visionary ecological restoration project set in the heart of the Amazon rainforest. This vast biodome initiative combines cutting-edge technology with environmental science to restore and preserve one of Earth's most vital ecosystems. The biosphere encompasses expansive protected zones where extinct and endangered species have been reintroduced through advanced genetic engineering and habitat rehabilitation."},
                {"images", "amazon.jpg amazon2.jpg amazon3.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "The Great Nation of Nexia"},
                {"file", "NexiaFlag.jpg"},
                {"description", "The nation home of all robots"},
                {"location", "Colorado"},
                {"year", "2369"},
                {"ratings", "3.9"},
                {"continent", "North America"},
                {"Loc Description", "Description: Nexia, the world's first fully AI-governed nation, is a testament to the unrelenting pursuit of technological utopia. Human leadership has been replaced entirely by a centralized artificial intelligence system known as 'Echelon.' Echelon controls every aspect of governance, from economic policies and environmental management to public safety and legal systems. Laws are optimized in real-time, resources are allocated with unparalleled precision, and societal issues are resolved through data-driven decisions devoid of human bias. Citizens enjoy seamless integration of technology into their daily lives, with personalized AI assistants guiding their education, careers, and healthcare."},
                {"images", "Nexia.jpg NexiaFlag.jpg"}
            },
            New Dictionary(Of String, String) From {
                {"title", "The Great Chronos Museum"},
                {"file", "timeMuseum.jpg"},
                {"description", "A one-of-a-kind institution dedicated to the exploration of time."},
                {"location", "Shanghai, China"},
                {"year", "2201"},
                {"ratings", "3.9"},
                {"continent", "Asia"},
                {"Loc Description", "Description: The Chronos Museum is a one-of-a-kind institution dedicated to the exploration of time. It houses exhibits on time-travel technology, theoretical models of time, historical artifacts, and futuristic projections, offering visitors a journey through the science, philosophy, and cultural impact of time itself."},
                {"images", "timeMuseum.jpg timeMuseum2.jpg"}
            }
        }

        Return items

    End Function
End Class
