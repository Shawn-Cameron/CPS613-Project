Public Class LocationContentCard
    Public Sub New(fileName As String, descript As String, loc As String, year As String, rating As String)
        InitializeComponent()

        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", fileName)

        LocImage.Image = Image.FromFile(imgPath)
        LocImage.SizeMode = PictureBoxSizeMode.Zoom

        DesLabel.Text = descript
        LocLabel.Text = loc
        YearLabel.Text = year
        RatingsLabel.Text = rating

    End Sub

    Private Sub LocationContentCard_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

    End Sub
End Class
