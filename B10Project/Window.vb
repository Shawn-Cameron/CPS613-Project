Imports System.Drawing.Imaging

Public Class Window
    Dim audioMuted As Boolean = False
    Dim scentEnabled As Boolean = True

    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("background_audio.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnTakePicture_Click(sender As Object, e As EventArgs) Handles btnTakePicture.Click
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.DrawToBitmap(bmp, PictureBox1.ClientRectangle)
        bmp.Save("scenery_picture.jpg", ImageFormat.Jpeg)
        MessageBox.Show("Picture taken and saved as scenery_picture.jpg!")
    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnMuteUnmute_Click(sender As Object, e As EventArgs) Handles btnMuteUnmute.Click
        If audioMuted Then
            My.Computer.Audio.Play("background_audio.wav", AudioPlayMode.BackgroundLoop)
            audioMuted = False
            btnMuteUnmute.Text = "Mute"
        Else
            My.Computer.Audio.Stop()
            audioMuted = True
            btnMuteUnmute.Text = "Unmute"
        End If
    End Sub

    Private Sub btnScentAdjust_Click(sender As Object, e As EventArgs) Handles btnScentAdjust.Click
        scentEnabled = True
        lblScentStatus.Text = "Scent: ON"
        lblScentStatus.ForeColor = Color.Green
    End Sub

    Private Sub btnScentBlock_Click(sender As Object, e As EventArgs) Handles btnScentBlock.Click
        scentEnabled = False
        lblScentStatus.Text = "Scent: OFF"
        lblScentStatus.ForeColor = Color.Red
    End Sub
End Class
