Public Class DropDownMenu
    Public filterBtnToggle As Boolean = False
    Public continentsBtnToggle As Boolean = False

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
            Me.Size = New Size(123, 30)
            OptionsListBox.Visible = False
            ContinentsBtn.Visible = False
            filterBtn.Text = filterBtn.Text.Substring(0, filterBtn.Text.Length - 1) & ">"
            If continentsBtnToggle Then
                continentsBtnToggle = Not continentsBtnToggle
            End If
        End If

    End Sub

    Private Sub ListBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim selectionBoxes = DirectCast(sender, ListBox)

        If e.Index < 0 Then Return

        Dim itemText As String = selectionBoxes.Items(e.Index).ToString()
        e.DrawBackground()

        Dim textBrush As Brush = Brushes.Black
        Dim textFromat As New StringFormat() With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }

        e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds, textFromat)

        If (e.State And DrawItemState.Focus) = DrawItemState.Focus Then
            Dim focusRect As New Rectangle(e.Bounds.Right - 20, e.Bounds.Top + 2, 16, e.Bounds.Height - 4)
            ControlPaint.DrawFocusRectangle(e.Graphics, focusRect)
        End If

        e.DrawFocusRectangle()

    End Sub
End Class
