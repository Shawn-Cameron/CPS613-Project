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
        Label3 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
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
        Timer1.Interval = 60000
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
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(604, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 41)
        Label3.TabIndex = 3
        Label3.TextAlign = ContentAlignment.TopCenter
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
        ' Pilot
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 577)
        Controls.Add(Label3)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
