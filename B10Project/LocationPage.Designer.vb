<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocationPage))
        PictureBox1 = New PictureBox()
        DescripLabel = New Label()
        Panel1 = New Panel()
        GroupBox5 = New GroupBox()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        RoundButton1 = New RoundButton()
        RoundButton2 = New RoundButton()
        Label8 = New Label()
        Label9 = New Label()
        BackBtn = New Button()
        AddLocBtn = New Button()
        timeLabel = New Label()
        Label11 = New Label()
        RmTimeBtn = New RoundButton()
        AddTimeBtn = New RoundButton()
        Label12 = New Label()
        TimeToReachLabel = New Label()
        Label1 = New Label()
        MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(MediaPlayer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(613, 277)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DescripLabel
        ' 
        DescripLabel.BorderStyle = BorderStyle.FixedSingle
        DescripLabel.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DescripLabel.Location = New Point(12, 289)
        DescripLabel.Name = "DescripLabel"
        DescripLabel.Size = New Size(613, 131)
        DescripLabel.TabIndex = 1
        DescripLabel.Text = resources.GetString("DescripLabel.Text")
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox5)
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(631, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(274, 378)
        Panel1.TabIndex = 2
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label7)
        GroupBox5.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox5.Location = New Point(10, 427)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(237, 100)
        GroupBox5.TabIndex = 2
        GroupBox5.TabStop = False
        GroupBox5.Text = "Sophie"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(6, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 78)
        Label7.TabIndex = 4
        Label7.Text = "Amazing place!!!"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.Location = New Point(10, 321)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(237, 100)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "Aathushan"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(225, 78)
        Label6.TabIndex = 3
        Label6.Text = "Amazing place!!!"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(10, 215)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(237, 100)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Nathan"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(6, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(225, 78)
        Label5.TabIndex = 2
        Label5.Text = "Amazing place!!!"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(10, 109)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(237, 100)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shawn"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(225, 78)
        Label4.TabIndex = 1
        Label4.Text = "Amazing place!!!"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(10, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(237, 100)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Samin"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 78)
        Label3.TabIndex = 0
        Label3.Text = "Amazing place!!!"
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(631, 12)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5, 5, 0, 0)
        Label2.Size = New Size(274, 30)
        Label2.TabIndex = 0
        Label2.Text = "Reviews"
        ' 
        ' RoundButton1
        ' 
        RoundButton1.BackColor = SystemColors.ActiveBorder
        RoundButton1.FlatAppearance.BorderSize = 0
        RoundButton1.FlatStyle = FlatStyle.Flat
        RoundButton1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RoundButton1.Location = New Point(18, 136)
        RoundButton1.Name = "RoundButton1"
        RoundButton1.Size = New Size(30, 30)
        RoundButton1.TabIndex = 4
        RoundButton1.Text = "<"
        RoundButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundButton2
        ' 
        RoundButton2.BackColor = SystemColors.ActiveBorder
        RoundButton2.FlatAppearance.BorderSize = 0
        RoundButton2.FlatStyle = FlatStyle.Flat
        RoundButton2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RoundButton2.Location = New Point(589, 136)
        RoundButton2.Name = "RoundButton2"
        RoundButton2.Size = New Size(30, 30)
        RoundButton2.TabIndex = 5
        RoundButton2.Text = ">"
        RoundButton2.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(12, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(209, 18)
        Label8.TabIndex = 6
        Label8.Text = "Time to reach destination: "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(12, 457)
        Label9.Name = "Label9"
        Label9.Size = New Size(255, 18)
        Label9.TabIndex = 7
        Label9.Text = "How long do you want to spend: "
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BackBtn.Location = New Point(12, 536)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(117, 40)
        BackBtn.TabIndex = 8
        BackBtn.Text = "BACK"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' AddLocBtn
        ' 
        AddLocBtn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AddLocBtn.Location = New Point(721, 536)
        AddLocBtn.Name = "AddLocBtn"
        AddLocBtn.Size = New Size(184, 40)
        AddLocBtn.TabIndex = 9
        AddLocBtn.Text = "ADD LOCATION"
        AddLocBtn.UseVisualStyleBackColor = True
        ' 
        ' timeLabel
        ' 
        timeLabel.AutoSize = True
        timeLabel.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        timeLabel.Location = New Point(260, 457)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(26, 18)
        timeLabel.TabIndex = 10
        timeLabel.Text = "60"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(291, 457)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 18)
        Label11.TabIndex = 11
        Label11.Text = "minutes"
        ' 
        ' RmTimeBtn
        ' 
        RmTimeBtn.BackColor = SystemColors.ActiveBorder
        RmTimeBtn.FlatAppearance.BorderSize = 0
        RmTimeBtn.FlatStyle = FlatStyle.Flat
        RmTimeBtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RmTimeBtn.Location = New Point(227, 477)
        RmTimeBtn.Margin = New Padding(0)
        RmTimeBtn.Name = "RmTimeBtn"
        RmTimeBtn.Size = New Size(25, 25)
        RmTimeBtn.TabIndex = 12
        RmTimeBtn.Text = "-"
        RmTimeBtn.UseCompatibleTextRendering = True
        RmTimeBtn.UseVisualStyleBackColor = False
        ' 
        ' AddTimeBtn
        ' 
        AddTimeBtn.BackColor = SystemColors.ActiveBorder
        AddTimeBtn.FlatAppearance.BorderSize = 0
        AddTimeBtn.FlatStyle = FlatStyle.Flat
        AddTimeBtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AddTimeBtn.Location = New Point(305, 477)
        AddTimeBtn.Margin = New Padding(0)
        AddTimeBtn.Name = "AddTimeBtn"
        AddTimeBtn.Size = New Size(25, 25)
        AddTimeBtn.TabIndex = 13
        AddTimeBtn.Text = "+"
        AddTimeBtn.UseCompatibleTextRendering = True
        AddTimeBtn.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(255, 480)
        Label12.Name = "Label12"
        Label12.Size = New Size(47, 18)
        Label12.TabIndex = 14
        Label12.Text = "TIME"
        ' 
        ' TimeToReachLabel
        ' 
        TimeToReachLabel.AutoSize = True
        TimeToReachLabel.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TimeToReachLabel.Location = New Point(214, 430)
        TimeToReachLabel.Name = "TimeToReachLabel"
        TimeToReachLabel.Size = New Size(26, 18)
        TimeToReachLabel.TabIndex = 15
        TimeToReachLabel.Text = "10"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(235, 430)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 18)
        Label1.TabIndex = 16
        Label1.Text = "minutes"
        ' 
        ' MediaPlayer
        ' 
        MediaPlayer.Enabled = True
        MediaPlayer.Location = New Point(12, 12)
        MediaPlayer.Name = "MediaPlayer"
        MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), AxHost.State)
        MediaPlayer.Size = New Size(613, 277)
        MediaPlayer.TabIndex = 17
        ' 
        ' LocationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 588)
        Controls.Add(Label1)
        Controls.Add(TimeToReachLabel)
        Controls.Add(Label12)
        Controls.Add(AddTimeBtn)
        Controls.Add(RmTimeBtn)
        Controls.Add(Label11)
        Controls.Add(timeLabel)
        Controls.Add(AddLocBtn)
        Controls.Add(BackBtn)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(RoundButton2)
        Controls.Add(RoundButton1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(DescripLabel)
        Controls.Add(MediaPlayer)
        Controls.Add(PictureBox1)
        Name = "LocationPage"
        Text = "LocationPage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(MediaPlayer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DescripLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents RoundButton2 As RoundButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents AddLocBtn As Button
    Friend WithEvents timeLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RmTimeBtn As RoundButton
    Friend WithEvents AddTimeBtn As RoundButton
    Friend WithEvents Label12 As Label
    Friend WithEvents TimeToReachLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
