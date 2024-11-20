Public Class MainControl

    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        Form1.SwitchForms()
    End Sub

    Public Sub AddNewLocation(cardData As Dictionary(Of String, String), timeToReach As String, stayDur As String)
        MessageBox.Show("recieved")
    End Sub
End Class
