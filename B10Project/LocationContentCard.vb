Public Class LocationContentCard
    Private origColor As Color = Me.BackColor

    Public Sub New(title As String, fileName As String, descript As String, loc As String, year As String, rating As String)
        InitializeComponent()

        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", fileName)

        LocImage.Image = Image.FromFile(imgPath)
        LocImage.SizeMode = PictureBoxSizeMode.Zoom

        TitleLabel.Text = title
        DesLabel.Text = descript
        LocLabel.Text = loc
        YearLabel.Text = year
        RatingsLabel.Text = rating

        For Each child As Control In Me.Controls
            AddHandler child.MouseEnter, AddressOf LocationContentCard_MouseEnter
            AddHandler child.MouseLeave, AddressOf LocationContentCard_MouseLeave
        Next

    End Sub

    Private Sub LocationContentCard_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub LocationContentCard_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = origColor

    End Sub
End Class
