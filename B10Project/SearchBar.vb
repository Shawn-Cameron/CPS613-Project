Imports System.Drawing.Design

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

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub


End Class
