Imports System.Security.Cryptography.X509Certificates

Public Class DropDownMenu
    Public filterBtnToggle As Boolean = False
    Public continentsBtnToggle As Boolean = False

    Public Event ComboBoxIndexChanged(sender As Object, e As EventArgs)

    'Makes background color transparent on load
    Private Sub DropDownMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        FilterOptionsUpdate()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent


    End Sub

    'Shows the drop down when filter button is clicked
    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filterBtn.Click
        filterBtnToggle = Not filterBtnToggle
        FilterOptionsUpdate()

    End Sub
    'Shows the drop down when Continents button is clicked
    Private Sub ContinentsBtn_Click(sender As Object, e As EventArgs) Handles ContinentsBtn.Click
        continentsBtnToggle = Not continentsBtnToggle
        FilterOptionsUpdate()
    End Sub

    'Updates size and display based on what filter options are currently showing
    Public Sub FilterOptionsUpdate()
        If filterBtnToggle Then
            Me.Size = New Size(123, 110)
            OptionsListBox.Visible = True
            ContinentsBtn.Visible = True
            filterBtn.Text = filterBtn.Text.Substring(0, filterBtn.Text.Length - 1) & "v"

            If continentsBtnToggle Then
                Me.Size = New Size(156, 234)
                ContinentsListBox.Visible = True
                ContinentsBtn.Text = ContinentsBtn.Text.Substring(0, ContinentsBtn.Text.Length - 1) & "v"
            Else
                ContinentsListBox.Visible = False
                ContinentsBtn.Text = ContinentsBtn.Text.Substring(0, ContinentsBtn.Text.Length - 1) & ">"
            End If


        Else
            Me.Size = New Size(123, 27)
            OptionsListBox.Visible = False
            ContinentsBtn.Visible = False
            filterBtn.Text = filterBtn.Text.Substring(0, filterBtn.Text.Length - 1) & ">"
            If continentsBtnToggle Then
                continentsBtnToggle = Not continentsBtnToggle
            End If
        End If

    End Sub

    'Returns the filter options
    Public Function GetFilterOptions()
        Dim options As List(Of String) = New List(Of String)
        For Each item As Object In OptionsListBox.CheckedItems
            options.Add(item)
        Next


        Dim continents As List(Of String) = New List(Of String)
        For Each item As Object In ContinentsListBox.CheckedItems
            continents.Add(item)
        Next

        Return New List(Of List(Of String)) From {options, continents}

    End Function

    ' Does nothing to create a transparent background
    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)

    End Sub

    'Updates the selection after item is checked
    Private Sub OptionsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OptionsListBox.ItemCheck, ContinentsListBox.ItemCheck
        Me.BeginInvoke(Sub()
                           RaiseEvent ComboBoxIndexChanged(sender, e)
                       End Sub)
    End Sub
End Class
