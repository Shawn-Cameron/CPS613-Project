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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TimeLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 22)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(15, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 125)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TimeLabel
        ' 
        TimeLabel.Location = New Point(46, 153)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(95, 23)
        TimeLabel.TabIndex = 2
        TimeLabel.Text = "Time"
        TimeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(46, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 23)
        Label2.TabIndex = 3
        Label2.Text = "Location"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 4
        Label3.Text = "Duration: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(113, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 5
        Label4.Text = "1 Hr"
        ' 
        ' TourPlanningTripsIcon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TimeLabel)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "TourPlanningTripsIcon"
        Size = New Size(199, 236)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
