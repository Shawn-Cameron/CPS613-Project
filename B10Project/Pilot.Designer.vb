<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pilot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Label3 = New Label()
        Label6 = New Label()
        MsgToggle = New Button()
        MessageControl1 = New MessageControl()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(999, 41)
        Label1.TabIndex = 0
        Label1.Text = "Waiting for visitors to confirm tour"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(352, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(297, 66)
        Button1.TabIndex = 1
        Button1.Text = "Start Tour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(1, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(999, 41)
        Label2.TabIndex = 2
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(12, 342)
        Button2.Name = "Button2"
        Button2.Size = New Size(297, 66)
        Button2.TabIndex = 4
        Button2.Text = "Slow Down"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Enabled = False
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(691, 342)
        Button3.Name = "Button3"
        Button3.Size = New Size(297, 66)
        Button3.TabIndex = 5
        Button3.Text = "Speed Up"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(352, 453)
        Button4.Name = "Button4"
        Button4.Size = New Size(297, 66)
        Button4.TabIndex = 6
        Button4.Text = "Stop Engine"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(352, 24)
        Button5.Name = "Button5"
        Button5.Size = New Size(297, 66)
        Button5.TabIndex = 7
        Button5.Text = "Hit for Emergency!"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(492, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 41)
        Label4.TabIndex = 9
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(1, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(999, 41)
        Label5.TabIndex = 8
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(1, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(999, 41)
        Label7.TabIndex = 10
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(352, 453)
        Button6.Name = "Button6"
        Button6.Size = New Size(297, 66)
        Button6.TabIndex = 11
        Button6.Text = "Look Out The Window"
        Button6.UseVisualStyleBackColor = True
        Button6.Visible = False
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(691, 453)
        Button7.Name = "Button7"
        Button7.Size = New Size(297, 66)
        Button7.TabIndex = 12
        Button7.Text = "Next Destination"
        Button7.UseVisualStyleBackColor = True
        Button7.Visible = False
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(12, 453)
        Button8.Name = "Button8"
        Button8.Size = New Size(297, 66)
        Button8.TabIndex = 13
        Button8.Text = "Previous Destination"
        Button8.UseVisualStyleBackColor = True
        Button8.Visible = False
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.Location = New Point(12, 24)
        Button9.Name = "Button9"
        Button9.Size = New Size(297, 66)
        Button9.TabIndex = 14
        Button9.Text = "Reverse Time"
        Button9.UseVisualStyleBackColor = True
        Button9.Visible = False
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button10.Location = New Point(691, 24)
        Button10.Name = "Button10"
        Button10.Size = New Size(297, 66)
        Button10.TabIndex = 15
        Button10.Text = "Go Home"
        Button10.UseVisualStyleBackColor = True
        Button10.Visible = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(856, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 112)
        Label3.TabIndex = 16
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 169)
        Label6.TabIndex = 17
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MsgToggle
        ' 
        MsgToggle.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        MsgToggle.Location = New Point(880, 525)
        MsgToggle.Name = "MsgToggle"
        MsgToggle.Size = New Size(108, 60)
        MsgToggle.TabIndex = 18
        MsgToggle.Text = "Show Messages"
        MsgToggle.UseVisualStyleBackColor = True
        ' 
        ' MessageControl1
        ' 
        MessageControl1.Location = New Point(1047, -1)
        MessageControl1.Name = "MessageControl1"
        MessageControl1.Size = New Size(350, 586)
        MessageControl1.TabIndex = 19
        ' 
        ' Pilot
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1396, 588)
        Controls.Add(MessageControl1)
        Controls.Add(MsgToggle)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Pilot"
        Text = "Pilot"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MsgToggle As Button
    Friend WithEvents MessageControl1 As MessageControl
End Class
