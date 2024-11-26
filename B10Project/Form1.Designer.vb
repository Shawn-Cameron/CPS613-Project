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
        MainControl1 = New MainControl()
        AddLocationForm1 = New AddLocationForm()
        MsgToggle = New Button()
        MessageControl1 = New MessageControl()
        SuspendLayout()
        ' 
        ' MainControl1
        ' 
        MainControl1.BackColor = SystemColors.Control
        MainControl1.Location = New Point(18, 6)
        MainControl1.Name = "MainControl1"
        MainControl1.Size = New Size(933, 590)
        MainControl1.TabIndex = 2
        ' 
        ' AddLocationForm1
        ' 
        AddLocationForm1.Location = New Point(19, 7)
        AddLocationForm1.Name = "AddLocationForm1"
        AddLocationForm1.Size = New Size(931, 518)
        AddLocationForm1.TabIndex = 3
        ' 
        ' MsgToggle
        ' 
        MsgToggle.Location = New Point(856, 545)
        MsgToggle.Name = "MsgToggle"
        MsgToggle.Size = New Size(75, 51)
        MsgToggle.TabIndex = 1
        MsgToggle.Text = "Show Messages"
        MsgToggle.UseVisualStyleBackColor = True
        ' 
        ' MessageControl1
        ' 
        MessageControl1.Location = New Point(986, 10)
        MessageControl1.Name = "MessageControl1"
        MessageControl1.Size = New Size(350, 586)
        MessageControl1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 608)
        Controls.Add(MessageControl1)
        Controls.Add(MsgToggle)
        Controls.Add(MainControl1)
        Controls.Add(AddLocationForm1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainControl1 As MainControl
    Friend WithEvents AddLocationForm1 As AddLocationForm
    Friend WithEvents MsgToggle As Button
    Friend WithEvents MessageControl1 As MessageControl

End Class
