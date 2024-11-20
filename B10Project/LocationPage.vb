Imports System.IO

Public Class LocationPage
    Private imagePaths As List(Of String) = New List(Of String)()
    Private currentIndex As Integer = 0
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
    End Sub

    Private Sub RoundButton3_Click(sender As Object, e As EventArgs) Handles RoundButton3.Click
        Dim currentValue As Integer = Integer.Parse(Label10.Text)
        If currentValue > 30 Then
            currentValue -= 10
        End If
        Label10.Text = currentValue.ToString()
    End Sub

    Private Sub RoundButton4_Click(sender As Object, e As EventArgs) Handles RoundButton4.Click
        Dim currentValue As Integer = Integer.Parse(Label10.Text)
        If currentValue < 120 Then
            currentValue += 10
        End If
        Label10.Text = currentValue.ToString()
    End Sub
End Class