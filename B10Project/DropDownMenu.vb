Public Class DropDownMenu
    Private filterBtnToggle As Boolean = False
    Private continentsBtnToggle As Boolean = False

    Private Sub DropDownMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        FilterOptionsUpdate()
    End Sub

    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filterBtn.Click
        filterBtnToggle = Not filterBtnToggle
        FilterOptionsUpdate()

    End Sub

    Private Sub ContinentsBtn_Click(sender As Object, e As EventArgs) Handles ContinentsBtn.Click
        continentsBtnToggle = Not continentsBtnToggle
        FilterOptionsUpdate()
    End Sub

    Private Sub FilterOptionsUpdate()
        If filterBtnToggle Then
            Me.Size = New Size(130, 125)
            OptionsListBox.Visible = True
            ContinentsBtn.Visible = True


            If continentsBtnToggle Then
                Me.Size = New Size(158, 251)
                ContinentsListBox.Visible = True
            Else
                ContinentsListBox.Visible = False
            End If


        Else
            Me.Size = New Size(130, 30)
            OptionsListBox.Visible = False
            ContinentsBtn.Visible = False

            If continentsBtnToggle Then
                continentsBtnToggle = Not continentsBtnToggle
            End If
        End If

    End Sub
End Class
