Public Class Pilot
    Dim ticks As Integer = 10
    Dim interval As Integer = 60000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Disengage Autopilot" Then
            Label1.Text = "Flying Manual"
            Button1.Text = "Engage Autopilot"
            Button2.Enabled = True
            Button3.Enabled = True
            Button5.Enabled = True
        ElseIf Button1.Text = "Engage Autopilot" Then
            Label1.Text = "Flying Autopilot"
            Button1.Text = "Disengage Autopilot"
            Button2.Enabled = False
            Button3.Enabled = False
            Button5.Enabled = True
        End If

        If Button1.Text = "Start Tour" Then
            Label1.Text = "Flying Autopilot"
            Label2.Text = "Reaching Destination in:       minutes"
            Label3.Text = "10"
            Button1.Text = "Disengage Autopilot"
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Timer1.Enabled = True
            Form1.MainControl1.Label5.Text = "Flying to Destination"
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ticks -= 1
        Dim minutes As Integer = Integer.Parse(Label3.Text)
        Label3.Text = (minutes - 1).ToString()

        If Integer.Parse(Label3.Text) = 0 Then
            Label1.Text = "Destination Reached!!!"
            Label2.Visible = False
            Label3.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Stop Engine" Then
            Button4.Text = "Start Engine"
            Timer1.Enabled = False
            Label2.ForeColor = Color.DarkGray
            Label3.ForeColor = Color.DarkGray
            Label1.Text = "Engine Stopped"
            Button1.Text = "Disengage Autopilot"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        ElseIf Button4.Text = "Start Engine" Then
            Button4.Text = "Stop Engine"
            Timer1.Enabled = True
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label1.Text = "Flying Autopilot"
            Button1.Text = "Disengage Autopilot"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        interval -= 6000
        Button2.Enabled = True
        If ((interval * ticks) / 60000) > 0 Then
            Timer1.Interval = interval
            Label3.Text = ((interval * ticks) / 60000).ToString()
        Else
            interval += 6000
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        interval += 6000
        Button3.Enabled = True
        If ((interval * ticks) / 60000) < 10 Then
            Timer1.Interval = interval
            Label3.Text = ((interval * ticks) / 60000).ToString()
        Else
            interval -= 6000
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.MainControl1.Label5.Text = "EMERGENCY!!!"
        Form1.MainControl1.AddLocBtn.Visible = False
        Form1.MainControl1.EditTripBtn.Visible = False
        Form1.MainControl1.Button1.Visible = False
        Form1.MainControl1.TripPanel.Visible = False
        Form1.MainControl1.BackColor = Color.Red
        Label1.Text = "RED ALERT!!!"
        Me.BackColor = Color.Red
        Label2.Visible = False
        Label3.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
    End Sub
End Class