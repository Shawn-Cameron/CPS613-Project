Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class TravelingArrow
    Public Sub New(setTime As Integer)
        InitializeComponent()
        TimeLabel.Text = setTime.ToString()
    End Sub
    Private Sub TravelingArrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", "arrow.png")
        ImgBox.Image = Image.FromFile(imgPath)
        ImgBox.SizeMode = PictureBoxSizeMode.Zoom

        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

End Class
