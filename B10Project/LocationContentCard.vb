Public Class LocationContentCard
    Public Sub New(fileName As String, descript As String, loc As String, year As Integer, rating As Single)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", fileName)

        LocImage.Image = Image.FromFile(imgPath)
        LocImage.SizeMode = PictureBoxSizeMode.Zoom

        DesLabel.Text = descript
        LocLabel.Text = loc
        YearLabel.Text = year
        RatingsLabel.Text = rating

    End Sub
End Class
