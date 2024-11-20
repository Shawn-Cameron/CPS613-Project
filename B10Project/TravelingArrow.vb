Public Class TravelingArrow
    Private Sub TravelingArrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", "arrow.png")
        ImgBox.Image = Image.FromFile(imgPath)
        ImgBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

End Class
