Public Class TourPlanningTripsIcon
    Public Sub New(cardData As Dictionary(Of String, String), stayTime As Integer)
        InitializeComponent()
        ImgBox.Image = Image.FromFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", cardData("file")))
        ImgBox.SizeMode = PictureBoxSizeMode.Zoom

        NameLabel.Text = cardData("title")
        YearLabel.Text = cardData("year")
        LocLabel.Text = cardData("location")
        durationLabel.Text = stayTime.ToString()
    End Sub

    Public Sub SetDurationText(value As Integer)
        durationLabel.Text = value.ToString()
    End Sub

    Public Function GetDurationValue()
        Return Integer.Parse(durationLabel.Text)
    End Function
End Class
