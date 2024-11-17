<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        AddLocBtn = New Button()
        Label1 = New Label()
        EditTripBtn = New Button()
        TripPanel = New Panel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' AddLocBtn
        ' 
        AddLocBtn.Location = New Point(131, 115)
        AddLocBtn.Name = "AddLocBtn"
        AddLocBtn.Size = New Size(182, 48)
        AddLocBtn.TabIndex = 0
        AddLocBtn.Text = "Add Location"
        AddLocBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(352, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 50)
        Label1.TabIndex = 1
        Label1.Text = "Tour Planning"
        ' 
        ' EditTripBtn
        ' 
        EditTripBtn.Location = New Point(371, 115)
        EditTripBtn.Name = "EditTripBtn"
        EditTripBtn.Size = New Size(182, 48)
        EditTripBtn.TabIndex = 2
        EditTripBtn.TabStop = False
        EditTripBtn.Text = "Edit Tour"
        EditTripBtn.UseVisualStyleBackColor = True
        ' 
        ' TripPanel
        ' 
        TripPanel.Location = New Point(12, 187)
        TripPanel.Name = "TripPanel"
        TripPanel.Size = New Size(906, 297)
        TripPanel.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(609, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 48)
        Button1.TabIndex = 4
        Button1.Text = "Confirm Tour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 516)
        Controls.Add(Button1)
        Controls.Add(TripPanel)
        Controls.Add(EditTripBtn)
        Controls.Add(Label1)
        Controls.Add(AddLocBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddLocBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EditTripBtn As Button
    Friend WithEvents TripPanel As Panel
    Friend WithEvents Button1 As Button

End Class
