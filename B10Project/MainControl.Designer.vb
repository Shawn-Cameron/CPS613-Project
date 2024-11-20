<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainControl
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
        Button1 = New Button()
        TripPanel = New Panel()

        LocPanel = New Panel()
        'TravelingArrow1 = New TravelingArrow(2)
        TimeRemainingLabel = New Label()
        Label4 = New Label()
        NumPplLabel = New Label()
        Label3 = New Label()
        Label2 = New Label()
        EditTripBtn = New Button()
        Label1 = New Label()
        AddLocBtn = New Button()
        TripPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(610, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 48)
        Button1.TabIndex = 9
        Button1.Text = "Confirm Tour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TripPanel
        ' 
        TripPanel.Controls.Add(LocPanel)
        TripPanel.Controls.Add(TimeRemainingLabel)
        TripPanel.Controls.Add(Label4)
        TripPanel.Controls.Add(NumPplLabel)
        TripPanel.Controls.Add(Label3)
        TripPanel.Controls.Add(Label2)
        TripPanel.Location = New Point(13, 189)
        TripPanel.Name = "TripPanel"
        TripPanel.Size = New Size(906, 381)
        TripPanel.TabIndex = 8
        ' 
        ' LocPanel
        ' 
        LocPanel.AutoScroll = True
        LocPanel.Location = New Point(3, 75)
        LocPanel.Name = "LocPanel"
        LocPanel.Size = New Size(900, 303)
        LocPanel.TabIndex = 5

        ' TravelingArrow1
        ' 
        ' TravelingArrow1.Location = New Point(3, 147)
        'TravelingArrow1.Name = "TravelingArrow1"
        'TravelingArrow1.Size = New Size(143, 83)
        'TravelingArrow1.TabIndex = 5

        ' 
        ' TimeRemainingLabel
        ' 
        TimeRemainingLabel.AutoSize = True
        TimeRemainingLabel.Location = New Point(860, 11)
        TimeRemainingLabel.Name = "TimeRemainingLabel"
        TimeRemainingLabel.Size = New Size(29, 15)
        TimeRemainingLabel.TabIndex = 4
        TimeRemainingLabel.Text = "4 Hr"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(764, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 15)
        Label4.TabIndex = 3
        Label4.Text = "Time Remaining: "
        ' 
        ' NumPplLabel
        ' 
        NumPplLabel.AutoSize = True
        NumPplLabel.Location = New Point(121, 40)
        NumPplLabel.Name = "NumPplLabel"
        NumPplLabel.Size = New Size(13, 15)
        NumPplLabel.TabIndex = 2
        NumPplLabel.Text = "1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 1
        Label3.Text = "Number of People:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(13, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 17)
        Label2.TabIndex = 0
        Label2.Text = "Current Tour"
        ' 
        ' EditTripBtn
        ' 
        EditTripBtn.Location = New Point(372, 117)
        EditTripBtn.Name = "EditTripBtn"
        EditTripBtn.Size = New Size(182, 48)
        EditTripBtn.TabIndex = 7
        EditTripBtn.TabStop = False
        EditTripBtn.Text = "Edit Tour"
        EditTripBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(353, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 50)
        Label1.TabIndex = 6
        Label1.Text = "Tour Planning"
        ' 
        ' AddLocBtn
        ' 
        AddLocBtn.Location = New Point(132, 117)
        AddLocBtn.Name = "AddLocBtn"
        AddLocBtn.Size = New Size(182, 48)
        AddLocBtn.TabIndex = 5
        AddLocBtn.Text = "Add Location"
        AddLocBtn.UseVisualStyleBackColor = True
        ' 
        ' MainControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(Button1)
        Controls.Add(TripPanel)
        Controls.Add(EditTripBtn)
        Controls.Add(Label1)
        Controls.Add(AddLocBtn)
        Name = "MainControl"
        Size = New Size(933, 590)
        TripPanel.ResumeLayout(False)
        TripPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TripPanel As Panel
    Friend WithEvents EditTripBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddLocBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumPplLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeRemainingLabel As Label
    Friend WithEvents LocPanel As Panel

End Class
