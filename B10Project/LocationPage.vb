Imports System.IO

Public Class LocationPage
    Private imagePaths As List(Of String) = New List(Of String)()
    Private currentIndex As Integer = 0
    Private _cardData As LocationContentCard
    Private currentTime As Integer
    Private _timeToReach As Integer

    Public Sub New(cardData As LocationContentCard, timeToReach As Integer)
        InitializeComponent()
        _cardData = cardData
        DescripLabel.Text = cardData.myData("Loc Description")
        TimeToReachLabel.Text = timeToReach.ToString()
        _timeToReach = timeToReach
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        If imagePaths.Count > 0 Then
            currentIndex -= 1
        End If
        If currentIndex < 0 Then
            currentIndex = imagePaths.Count - 1
        End If
        PictureBox1.Image = Image.FromFile(imagePaths(currentIndex))
    End Sub

    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        If imagePaths.Count > 0 Then
            currentIndex += 1
        End If
        If currentIndex >= imagePaths.Count Then
            currentIndex = 0
        End If
        PictureBox1.Image = Image.FromFile(imagePaths(currentIndex))
    End Sub

    Private Sub LocationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim folderPath As String = Path.Combine(Application.StartupPath, "Resources") ' Change the path as needed

        If Directory.Exists(folderPath) Then
            imagePaths = Directory.GetFiles(folderPath, "*.jpg").ToList() ' Change "*.jpg" to the appropriate format, e.g., "*.png"
            imagePaths.AddRange(Directory.GetFiles(folderPath, "*.png"))

            If imagePaths.Count > 0 Then
                PictureBox1.Image = Image.FromFile(imagePaths(currentIndex))
            Else
                MessageBox.Show("No images found in the folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Image folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        currentTime = Integer.Parse(timeLabel.Text)
    End Sub

    Private Sub RmTimeBtn_Click(sender As Object, e As EventArgs) Handles RmTimeBtn.Click
        If currentTime > 30 Then
            currentTime -= 10
        End If
        timeLabel.Text = currentTime.ToString()
    End Sub

    Private Sub AddTimeBtn_Click(sender As Object, e As EventArgs) Handles AddTimeBtn.Click
        If currentTime < 120 Then
            currentTime += 10
        End If
        timeLabel.Text = currentTime.ToString()

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
    End Sub

    Private Sub AddLocBtn_Click(sender As Object, e As EventArgs) Handles AddLocBtn.Click
        Form1.MainControl1.AddNewLocation(_cardData.myData, _timeToReach, currentTime)
    End Sub
End Class