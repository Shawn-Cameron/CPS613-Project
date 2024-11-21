<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TourPlanningTripsIcon
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        NameLabel = New Label()
        ImgBox = New PictureBox()
        YearLabel = New Label()
        LocLabel = New Label()
        Label3 = New Label()
        durationLabel = New Label()
        Label1 = New Label()
        CType(ImgBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NameLabel
        ' 
        NameLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        NameLabel.Location = New Point(3, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(136, 36)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name"
        NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ImgBox
        ' 
        ImgBox.Location = New Point(15, 39)
        ImgBox.Name = "ImgBox"
        ImgBox.Size = New Size(115, 87)
        ImgBox.TabIndex = 1
        ImgBox.TabStop = False
        ' 
        ' YearLabel
        ' 
        YearLabel.AutoSize = True
        YearLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        YearLabel.Location = New Point(68, 139)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New Size(27, 13)
        YearLabel.TabIndex = 2
        YearLabel.Text = "Year"
        YearLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LocLabel
        ' 
        LocLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LocLabel.Location = New Point(21, 152)
        LocLabel.Name = "LocLabel"
        LocLabel.Size = New Size(95, 23)
        LocLabel.TabIndex = 3
        LocLabel.Text = "Location"
        LocLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(19, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 13)
        Label3.TabIndex = 4
        Label3.Text = "Duration (min): "
        ' 
        ' durationLabel
        ' 
        durationLabel.AutoSize = True
        durationLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        durationLabel.Location = New Point(98, 175)
        durationLabel.Name = "durationLabel"
        durationLabel.Size = New Size(25, 13)
        durationLabel.TabIndex = 5
        durationLabel.Text = "120"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(40, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 13)
        Label1.TabIndex = 6
        Label1.Text = "Year:"
        ' 
        ' TourPlanningTripsIcon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(Label1)
        Controls.Add(durationLabel)
        Controls.Add(Label3)
        Controls.Add(LocLabel)
        Controls.Add(YearLabel)
        Controls.Add(ImgBox)
        Controls.Add(NameLabel)
        Name = "TourPlanningTripsIcon"
        Size = New Size(142, 201)
        CType(ImgBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents ImgBox As PictureBox
    Friend WithEvents YearLabel As Label
    Friend WithEvents LocLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents durationLabel As Label
    Friend WithEvents Label1 As Label

End Class
