Public Class TourPlanningTripsIcon
    Public Sub New(cardData As Dictionary(Of String, String), timeToReach As Integer, stayTime As Integer)
        InitializeComponent()
        ImgBox.Image = Image.FromFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", cardData("file")))
        ImgBox.SizeMode = PictureBoxSizeMode.Zoom

        NameLabel.Text = cardData("title")
        YearLabel.Text = cardData("year")
        LocLabel.Text = cardData("location")
        durationLabel.Text = stayTime.ToString()
        CardPanel.Size = New Size(148, 193)
        TravelingArrow1.TimeLabel.Text = timeToReach.ToString()
    End Sub

    Public Sub SetDurationText(value As Integer)
        durationLabel.Text = value.ToString()
    End Sub

    Public Function GetDurationValue()
        Return Integer.Parse(durationLabel.Text)
    End Function


    Public Sub EnableEdit()
        CardPanel.Size = New Size(148, 271)
    End Sub

    Public Sub DisableEdit()
        CardPanel.Size = New Size(148, 193)
    End Sub


    Private Sub TourPlanningTripsIcon_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub rmTimeBtn_Click(sender As Object, e As EventArgs) Handles rmTimeBtn.Click
        Dim val As Integer = Integer.Parse(durationLabel.Text)
        If val > 30 Then
            durationLabel.Text = (val - 10).ToString()
            Form1.MainControl1.TimeRemoved()
        End If

    End Sub

    Private Sub addTimeBtn_Click(sender As Object, e As EventArgs) Handles addTimeBtn.Click
        Dim val As Integer = Integer.Parse(durationLabel.Text)
        If val < 120 Then
            durationLabel.Text = (val + 10).ToString()
            Form1.MainControl1.TimeAdded()
        End If
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Form1.MainControl1.RemoveCard(Me)
    End Sub

    Private Sub moveLeftBtn_Click(sender As Object, e As EventArgs) Handles moveLeftBtn.Click
        Form1.MainControl1.MoveCardLeft(Me)
    End Sub

    Private Sub moveRightBtn_Click(sender As Object, e As EventArgs) Handles moveRightBtn.Click
        Form1.MainControl1.MoveCardRight(Me)
    End Sub


    ' Main Panel size (148, 193)
End Class
