Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'Custom Control to create messages in the Message Control 
Public Class UserMsgControl
    Public Sub New(sender As String, message As String)
        InitializeComponent()
        SenderLabel.Text = sender
        UserTxt.Text = message
        ResizeText(message)

    End Sub

    Private Sub ResizeText(message As String)
        Dim textSize As Size = TextRenderer.MeasureText(message, UserTxt.Font, New Size(UserTxt.Width, Integer.MaxValue), TextFormatFlags.WordBreak)
        UserTxt.Height = textSize.Height + 10
        Me.Height = UserTxt.Height + 25
    End Sub


End Class
