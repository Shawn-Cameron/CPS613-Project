Public Class AddLocationForm
    Protected searchBar As SearchBar

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
    End Sub
End Class
