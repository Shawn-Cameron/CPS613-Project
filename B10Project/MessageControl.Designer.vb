<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageControl
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
        Label1 = New Label()
        MsgText = New TextBox()
        SendBtn = New Button()
        MsgPanelContainer = New Panel()
        MsgPanel = New Panel()
        MsgPanelContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(122, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "Messages"
        ' 
        ' MsgText
        ' 
        MsgText.Location = New Point(3, 537)
        MsgText.Multiline = True
        MsgText.Name = "MsgText"
        MsgText.Size = New Size(269, 40)
        MsgText.TabIndex = 2
        ' 
        ' SendBtn
        ' 
        SendBtn.Location = New Point(284, 538)
        SendBtn.Name = "SendBtn"
        SendBtn.Size = New Size(57, 39)
        SendBtn.TabIndex = 3
        SendBtn.Text = "Send"
        SendBtn.UseVisualStyleBackColor = True
        ' 
        ' MsgPanelContainer
        ' 
        MsgPanelContainer.AutoScroll = True
        MsgPanelContainer.Controls.Add(MsgPanel)
        MsgPanelContainer.Location = New Point(3, 35)
        MsgPanelContainer.Name = "MsgPanelContainer"
        MsgPanelContainer.Size = New Size(344, 496)
        MsgPanelContainer.TabIndex = 4
        ' 
        ' MsgPanel
        ' 
        MsgPanel.BackColor = Color.White
        MsgPanel.BorderStyle = BorderStyle.FixedSingle
        MsgPanel.Location = New Point(7, 7)
        MsgPanel.Name = "MsgPanel"
        MsgPanel.Size = New Size(313, 486)
        MsgPanel.TabIndex = 2
        ' 
        ' MessageControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MsgPanelContainer)
        Controls.Add(SendBtn)
        Controls.Add(MsgText)
        Controls.Add(Label1)
        Name = "MessageControl"
        Size = New Size(350, 586)
        MsgPanelContainer.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MsgText As TextBox
    Friend WithEvents SendBtn As Button
    Friend WithEvents MsgPanelContainer As Panel
    Friend WithEvents MsgPanel As Panel

End Class
