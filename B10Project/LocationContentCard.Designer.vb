<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationContentCard
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
        LocImage = New PictureBox()
        label2 = New Label()
        label3 = New Label()
        label1 = New Label()
        Label5 = New Label()
        DesLabel = New Label()
        LocLabel = New Label()
        YearLabel = New Label()
        RatingsLabel = New Label()
        TitleLabel = New Label()
        CType(LocImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LocImage
        ' 
        LocImage.Location = New Point(11, 33)
        LocImage.Name = "LocImage"
        LocImage.Size = New Size(167, 98)
        LocImage.TabIndex = 0
        LocImage.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(12, 200)
        label2.Name = "label2"
        label2.Size = New Size(55, 13)
        label2.TabIndex = 1
        label2.Text = "Location:"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        label3.Location = New Point(11, 221)
        label3.Name = "label3"
        label3.Size = New Size(32, 13)
        label3.TabIndex = 2
        label3.Text = "Year:"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(11, 134)
        label1.Name = "label1"
        label1.Size = New Size(69, 13)
        label1.TabIndex = 3
        label1.Text = "Description:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(159, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 13)
        Label5.TabIndex = 4
        Label5.Text = "/5"
        ' 
        ' DesLabel
        ' 
        DesLabel.AutoEllipsis = True
        DesLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DesLabel.Location = New Point(12, 147)
        DesLabel.Name = "DesLabel"
        DesLabel.Size = New Size(166, 45)
        DesLabel.TabIndex = 5
        DesLabel.Text = "Label4"
        ' 
        ' LocLabel
        ' 
        LocLabel.AutoEllipsis = True
        LocLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LocLabel.Location = New Point(62, 200)
        LocLabel.Name = "LocLabel"
        LocLabel.Size = New Size(111, 16)
        LocLabel.TabIndex = 6
        LocLabel.Text = "Label5"
        ' 
        ' YearLabel
        ' 
        YearLabel.AutoSize = True
        YearLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        YearLabel.Location = New Point(38, 221)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New Size(40, 13)
        YearLabel.TabIndex = 7
        YearLabel.Text = "Label6"
        ' 
        ' RatingsLabel
        ' 
        RatingsLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        RatingsLabel.Location = New Point(140, 221)
        RatingsLabel.Name = "RatingsLabel"
        RatingsLabel.Size = New Size(22, 15)
        RatingsLabel.TabIndex = 8
        RatingsLabel.Text = "4.7"
        ' 
        ' TitleLabel
        ' 
        TitleLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TitleLabel.Location = New Point(11, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(166, 30)
        TitleLabel.TabIndex = 9
        TitleLabel.Text = "Title"
        TitleLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LocationContentCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(TitleLabel)
        Controls.Add(RatingsLabel)
        Controls.Add(YearLabel)
        Controls.Add(LocLabel)
        Controls.Add(DesLabel)
        Controls.Add(Label5)
        Controls.Add(label1)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(LocImage)
        Name = "LocationContentCard"
        Size = New Size(189, 240)
        CType(LocImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LocImage As PictureBox
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DesLabel As Label
    Friend WithEvents LocLabel As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents RatingsLabel As Label
    Friend WithEvents TitleLabel As Label

End Class
