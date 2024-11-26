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
        TravelingArrow1 = New TravelingArrow()
        rmTimeBtn = New Button()
        CardPanel = New Panel()
        removeBtn = New Button()
        moveRightBtn = New Button()
        moveLeftBtn = New Button()
        addTimeBtn = New Button()
        CType(ImgBox, ComponentModel.ISupportInitialize).BeginInit()
        CardPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' NameLabel
        ' 
        NameLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        NameLabel.Location = New Point(3, 1)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(139, 36)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name"
        NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ImgBox
        ' 
        ImgBox.Location = New Point(18, 39)
        ImgBox.Name = "ImgBox"
        ImgBox.Size = New Size(115, 87)
        ImgBox.TabIndex = 1
        ImgBox.TabStop = False
        ' 
        ' YearLabel
        ' 
        YearLabel.AutoSize = True
        YearLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        YearLabel.Location = New Point(71, 139)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New Size(27, 13)
        YearLabel.TabIndex = 2
        YearLabel.Text = "Year"
        YearLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LocLabel
        ' 
        LocLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LocLabel.Location = New Point(24, 152)
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
        Label3.Location = New Point(22, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 13)
        Label3.TabIndex = 4
        Label3.Text = "Duration (min): "
        ' 
        ' durationLabel
        ' 
        durationLabel.AutoSize = True
        durationLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        durationLabel.Location = New Point(108, 175)
        durationLabel.Name = "durationLabel"
        durationLabel.Size = New Size(25, 13)
        durationLabel.TabIndex = 5
        durationLabel.Text = "120"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(43, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 13)
        Label1.TabIndex = 6
        Label1.Text = "Year:"
        ' 
        ' TravelingArrow1
        ' 
        TravelingArrow1.BackColor = Color.Transparent
        TravelingArrow1.Location = New Point(0, 81)
        TravelingArrow1.Name = "TravelingArrow1"
        TravelingArrow1.Size = New Size(76, 49)
        TravelingArrow1.TabIndex = 7
        ' 
        ' rmTimeBtn
        ' 
        rmTimeBtn.Location = New Point(3, 191)
        rmTimeBtn.Name = "rmTimeBtn"
        rmTimeBtn.Size = New Size(68, 23)
        rmTimeBtn.TabIndex = 8
        rmTimeBtn.Text = "-10 min"
        rmTimeBtn.UseVisualStyleBackColor = True
        ' 
        ' CardPanel
        ' 
        CardPanel.BorderStyle = BorderStyle.FixedSingle
        CardPanel.Controls.Add(removeBtn)
        CardPanel.Controls.Add(moveRightBtn)
        CardPanel.Controls.Add(moveLeftBtn)
        CardPanel.Controls.Add(addTimeBtn)
        CardPanel.Controls.Add(ImgBox)
        CardPanel.Controls.Add(NameLabel)
        CardPanel.Controls.Add(rmTimeBtn)
        CardPanel.Controls.Add(YearLabel)
        CardPanel.Controls.Add(LocLabel)
        CardPanel.Controls.Add(Label1)
        CardPanel.Controls.Add(Label3)
        CardPanel.Controls.Add(durationLabel)
        CardPanel.Location = New Point(69, 3)
        CardPanel.Name = "CardPanel"
        CardPanel.Size = New Size(148, 271)
        CardPanel.TabIndex = 10
        ' 
        ' removeBtn
        ' 
        removeBtn.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        removeBtn.Location = New Point(35, 240)
        removeBtn.Name = "removeBtn"
        removeBtn.Size = New Size(74, 23)
        removeBtn.TabIndex = 13
        removeBtn.Text = "Remove"
        removeBtn.UseVisualStyleBackColor = True
        ' 
        ' moveRightBtn
        ' 
        moveRightBtn.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        moveRightBtn.Location = New Point(71, 215)
        moveRightBtn.Name = "moveRightBtn"
        moveRightBtn.Size = New Size(76, 23)
        moveRightBtn.TabIndex = 12
        moveRightBtn.Text = "Move Right"
        moveRightBtn.UseVisualStyleBackColor = True
        ' 
        ' moveLeftBtn
        ' 
        moveLeftBtn.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        moveLeftBtn.Location = New Point(-1, 215)
        moveLeftBtn.Name = "moveLeftBtn"
        moveLeftBtn.Size = New Size(74, 23)
        moveLeftBtn.TabIndex = 11
        moveLeftBtn.Text = "Move Left"
        moveLeftBtn.UseVisualStyleBackColor = True
        ' 
        ' addTimeBtn
        ' 
        addTimeBtn.Location = New Point(74, 191)
        addTimeBtn.Name = "addTimeBtn"
        addTimeBtn.Size = New Size(68, 23)
        addTimeBtn.TabIndex = 10
        addTimeBtn.Text = "+10 min"
        addTimeBtn.UseVisualStyleBackColor = True
        ' 
        ' TourPlanningTripsIcon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CardPanel)
        Controls.Add(TravelingArrow1)
        Name = "TourPlanningTripsIcon"
        Size = New Size(225, 277)
        CType(ImgBox, ComponentModel.ISupportInitialize).EndInit()
        CardPanel.ResumeLayout(False)
        CardPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents ImgBox As PictureBox
    Friend WithEvents YearLabel As Label
    Friend WithEvents LocLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents durationLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TravelingArrow1 As TravelingArrow
    Friend WithEvents rmTimeBtn As Button
    Friend WithEvents CardPanel As Panel
    Friend WithEvents removeBtn As Button
    Friend WithEvents moveRightBtn As Button
    Friend WithEvents moveLeftBtn As Button
    Friend WithEvents addTimeBtn As Button

End Class
