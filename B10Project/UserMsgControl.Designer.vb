<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMsgControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMsgControl))
        UserTxt = New Label()
        SenderLabel = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' UserTxt
        ' 
        UserTxt.Location = New Point(4, 25)
        UserTxt.Name = "UserTxt"
        UserTxt.Size = New Size(297, 89)
        UserTxt.TabIndex = 2
        UserTxt.Text = resources.GetString("UserTxt.Text")
        ' 
        ' SenderLabel
        ' 
        SenderLabel.AutoSize = True
        SenderLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenderLabel.Location = New Point(4, 2)
        SenderLabel.Name = "SenderLabel"
        SenderLabel.Size = New Size(47, 15)
        SenderLabel.TabIndex = 1
        SenderLabel.Text = "Sender"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(-4, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 2)
        Panel1.TabIndex = 0
        ' 
        ' UserMsgControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(Panel1)
        Controls.Add(UserTxt)
        Controls.Add(SenderLabel)
        Name = "UserMsgControl"
        Size = New Size(299, 113)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserTxt As Label
    Friend WithEvents SenderLabel As Label
    Friend WithEvents Panel1 As Panel

End Class
