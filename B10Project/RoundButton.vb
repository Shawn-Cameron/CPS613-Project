Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class RoundButton
    Inherits Button
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim grpath As GraphicsPath = New GraphicsPath()
        grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grpath)
    End Sub
End Class
