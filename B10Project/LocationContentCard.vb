﻿Public Class LocationContentCard
    Private origColor As Color = Me.BackColor
    Public myData As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        InitializeComponent()

        Dim imgPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Resources\", data("file"))

        LocImage.Image = Image.FromFile(imgPath)
        LocImage.SizeMode = PictureBoxSizeMode.Zoom

        TitleLabel.Text = data("title")
        DesLabel.Text = data("description")
        LocLabel.Text = data("location")
        YearLabel.Text = data("year")
        RatingsLabel.Text = data("ratings")

        For Each child As Control In Me.Controls
            AddHandler child.MouseEnter, AddressOf LocationContentCard_MouseEnter
            AddHandler child.MouseLeave, AddressOf LocationContentCard_MouseLeave
            AddHandler child.Click, AddressOf LocationContentCard_Click
        Next

        myData = data
    End Sub

    Private Sub LocationContentCard_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub LocationContentCard_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = origColor

    End Sub

    Private Sub LocationContentCard_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim associatedLocationPage As New LocationPage(Me)
        associatedLocationPage.Show()
    End Sub
End Class
