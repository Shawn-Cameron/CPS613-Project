Imports System.Reflection.Emit

Public Class Pilot
    Dim curYear As Integer = 2173
    Dim forward As Boolean = True
    Dim ticks As Integer = 1
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
            Label2.Text = "Current Year " & curYear.ToString()
            Label5.Text = "Flying at        ly/min"
            Label4.Text = ticks
            Label7.Text = "Flying To " & Form1.locations(Form1.ind)
            Button1.Text = "Disengage Autopilot"
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Timer1.Enabled = True
            Form1.MainControl1.Label5.Text = "Flying to " & Form1.locations(Form1.ind)
            Label2.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Button2.Enabled = False
            Button3.Enabled = False
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If forward = True Then
            curYear += 1
            Label2.Text = "Current Year " & curYear.ToString()
        Else
            curYear -= 1
            Label2.Text = "Current Year " & curYear.ToString()
        End If

        If ticks = 1 Then
            Button2.Enabled = False
        ElseIf ticks = 5 Then
            Button3.Enabled = False
        Else
            Button2.Enabled = True
            Button3.Enabled = True
        End If

        If curYear > 2173 Then
            Label3.Text = "In The Future"
        ElseIf curYear < 2173 Then
            Label3.Text = "In The Past"
        ElseIf curYear = 2173 Then
            Label3.Text = "In The Present"
        End If

        If curYear = Integer.Parse(Form1.years(Form1.ind)) Then
            Label1.Text = "Destination Reached!!!"
            Label4.Visible = False
            Label5.Text = "At " & Form1.locations(Form1.ind)
            Label7.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button6.Visible = True
            Button7.Visible = True
            Timer1.Enabled = False
            Form1.MainControl1.Button2.Visible = True
            Form1.MainControl1.Label5.Text = "At " & Form1.locations(Form1.ind)
        End If

        If Label5.Text = "At Home" Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
        End If
        Label6.Text = "Target Year: " & Integer.Parse(Form1.years(Form1.ind))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Stop Engine" Then
            Button4.Text = "Start Engine"
            Timer1.Enabled = False
            Label2.ForeColor = Color.DarkGray
            Label4.ForeColor = Color.DarkGray
            Label5.ForeColor = Color.DarkGray
            Label1.Text = "Engine Stopped"
            Button1.Text = "Disengage Autopilot"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        ElseIf Button4.Text = "Start Engine" Then
            Button4.Text = "Stop Engine"
            Timer1.Enabled = True
            Label2.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label1.Text = "Flying Autopilot"
            Button1.Text = "Disengage Autopilot"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ticks = 5 Then
            Button3.Enabled = False
        Else
            ticks += 1
            Timer1.Interval -= 200
            Label4.Text = ticks
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ticks = 1 Then
            Button2.Enabled = False
        Else
            ticks -= 1
            Timer1.Interval += 200
            Label4.Text = ticks
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ResetForm()
        Form1.MainControl1.Label5.Text = "EMERGENCY!!!"
        Form1.MainControl1.AddLocBtn.Visible = False
        Form1.MainControl1.EditTripBtn.Visible = False
        Form1.MainControl1.Button1.Visible = False
        Form1.MainControl1.TripPanel.Visible = False
        Form1.MainControl1.BackColor = Color.Red
        Form1.MainControl1.Button2.Visible = False
        Label1.Text = "RED ALERT!!!"
        BackColor = Color.Red
        Label2.Text = "Going Home Immediately"
        Label3.Visible = False
        Label6.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button9.Visible = False
        Button10.Visible = False


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Window.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.ind += 1
        If Form1.ind = Form1.locations.Count() Then
            Form1.ind = 0
        End If
        ResetForm()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.ind -= 1
        If Form1.ind = -1 Then
            Form1.ind = (Form1.locations.Count() - 1)
        End If
        ResetForm()
    End Sub

    Public Sub ResetForm()
        Button1.Text = "Start Tour"
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Label4.Visible = False
        ticks = 1
        Label5.Text = ""
        Label7.Text = ""
        Label1.Text = "Setting Course for " & Form1.locations(Form1.ind)
        Timer1.Interval = 1000
        Timer1.Enabled = False
        Window.Close()
        My.Computer.Audio.Stop()
        Form1.MainControl1.Button2.Visible = False
        Form1.MainControl1.Label5.Text = "Flying To " & Form1.locations(Form1.ind)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If forward = True Then
            forward = False
        Else
            forward = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form1.locations.Clear()
        Form1.locations.Add("Home")
        Form1.years.Clear()
        Form1.years.Add("2173")
        ResetForm()
    End Sub
End Class