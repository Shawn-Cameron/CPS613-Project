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
        EditTripBtn = New Button()
        Label1 = New Label()
        AddLocBtn = New Button()
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
        TripPanel.Location = New Point(13, 189)
        TripPanel.Name = "TripPanel"
        TripPanel.Size = New Size(906, 297)
        TripPanel.TabIndex = 8
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
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Size = New Size(933, 520)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TripPanel As Panel
    Friend WithEvents EditTripBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddLocBtn As Button

End Class
