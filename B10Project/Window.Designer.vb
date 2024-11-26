<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window))
        PictureBox1 = New PictureBox()
        btnTakePicture = New Button()
        btnZoomIn = New Button()
        btnZoomOut = New Button()
        btnMuteUnmute = New Button()
        btnScentAdjust = New Button()
        btnScentBlock = New Button()
        lblScentStatus = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(938, 585)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnTakePicture
        ' 
        btnTakePicture.Location = New Point(421, 543)
        btnTakePicture.Name = "btnTakePicture"
        btnTakePicture.Size = New Size(100, 23)
        btnTakePicture.TabIndex = 1
        btnTakePicture.Text = "Take Picture"
        btnTakePicture.UseVisualStyleBackColor = True
        ' 
        ' btnZoomIn
        ' 
        btnZoomIn.Location = New Point(12, 12)
        btnZoomIn.Name = "btnZoomIn"
        btnZoomIn.Size = New Size(75, 23)
        btnZoomIn.TabIndex = 2
        btnZoomIn.Text = "Zoom In"
        btnZoomIn.UseVisualStyleBackColor = True
        ' 
        ' btnZoomOut
        ' 
        btnZoomOut.Location = New Point(851, 12)
        btnZoomOut.Name = "btnZoomOut"
        btnZoomOut.Size = New Size(75, 23)
        btnZoomOut.TabIndex = 3
        btnZoomOut.Text = "Zoom Out"
        btnZoomOut.UseVisualStyleBackColor = True
        ' 
        ' btnMuteUnmute
        ' 
        btnMuteUnmute.Location = New Point(823, 543)
        btnMuteUnmute.Name = "btnMuteUnmute"
        btnMuteUnmute.Size = New Size(103, 23)
        btnMuteUnmute.TabIndex = 7
        btnMuteUnmute.Text = "Mute / Unmute"
        btnMuteUnmute.UseVisualStyleBackColor = True
        ' 
        ' btnScentAdjust
        ' 
        btnScentAdjust.Location = New Point(12, 513)
        btnScentAdjust.Name = "btnScentAdjust"
        btnScentAdjust.Size = New Size(93, 23)
        btnScentAdjust.TabIndex = 8
        btnScentAdjust.Text = "Scent On"
        btnScentAdjust.UseVisualStyleBackColor = True
        ' 
        ' btnScentBlock
        ' 
        btnScentBlock.Location = New Point(111, 513)
        btnScentBlock.Name = "btnScentBlock"
        btnScentBlock.Size = New Size(93, 23)
        btnScentBlock.TabIndex = 9
        btnScentBlock.Text = "Scent Block"
        btnScentBlock.UseVisualStyleBackColor = True
        ' 
        ' lblScentStatus
        ' 
        lblScentStatus.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblScentStatus.ForeColor = Color.Green
        lblScentStatus.Location = New Point(12, 539)
        lblScentStatus.Name = "lblScentStatus"
        lblScentStatus.Size = New Size(192, 37)
        lblScentStatus.TabIndex = 10
        lblScentStatus.Text = "Scent: ON"
        ' 
        ' Window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(938, 585)
        Controls.Add(lblScentStatus)
        Controls.Add(btnScentBlock)
        Controls.Add(btnScentAdjust)
        Controls.Add(btnMuteUnmute)
        Controls.Add(btnZoomOut)
        Controls.Add(btnZoomIn)
        Controls.Add(btnTakePicture)
        Controls.Add(PictureBox1)
        Name = "Window"
        Text = "Window"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTakePicture As Button
    Friend WithEvents btnZoomIn As Button
    Friend WithEvents btnZoomOut As Button
    Friend WithEvents btnMuteUnmute As Button
    Friend WithEvents btnScentAdjust As Button
    Friend WithEvents btnScentBlock As Button
    Friend WithEvents lblScentStatus As Label
End Class
