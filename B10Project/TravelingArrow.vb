Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class TravelingArrow
    Public Sub New()
        InitializeComponent()
        TimeLabel.Text = "0"
    End Sub
    Public Sub New(setTime As Integer)
        InitializeComponent()
        TimeLabel.Text = setTime.ToString()
    End Sub
    Private Sub TravelingArrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", "arrow.png")
            ImgBox.Image = Image.FromFile(imgPath)
            ImgBox.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception

        End Try

        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Public Function GetTravelTime()
        Return Integer.Parse(TimeLabel.Text)
    End Function
End Class
