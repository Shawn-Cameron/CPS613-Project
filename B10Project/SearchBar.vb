Imports System.Drawing.Design

'Custom Control for search bar on Add Location Page
Public Class SearchBar
    Inherits TextBox

    Private _placeholder As String = "Search"

    Public Overrides Property PlaceholderText As String
        Get
            Return _placeholder
        End Get
        Set(value As String)
            Me.Text = _placeholder
            Me.ForeColor = Color.Gray
        End Set
    End Property

    Private Sub SearchBar_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If Me.Text = _placeholder Then
            Me.Text = ""
            Me.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SearchBar_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If String.IsNullOrWhiteSpace(Me.Text) Then
            Me.Text = _placeholder
            Me.ForeColor = Color.Gray
        End If
    End Sub

End Class
