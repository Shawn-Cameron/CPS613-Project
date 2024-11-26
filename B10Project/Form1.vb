Public Class Form1
    Public Shared locations As New List(Of String)
    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub SwitchForms()
        If MainControl1.Visible Then
            MainControl1.Visible = False
            AddLocationForm1.Visible = True
        Else
            MainControl1.Visible = True
            AddLocationForm1.Visible = False
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub MainControl1_Load(sender As Object, e As EventArgs) Handles MainControl1.Load
        Pilot.Show()
    End Sub
End Class
