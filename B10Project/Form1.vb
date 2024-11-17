Public Class Form1
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
