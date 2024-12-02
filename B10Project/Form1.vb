Public Class Form1
    Public Shared locations As New List(Of String)
    Public Shared years As New List(Of Integer)
    Public Shared ind As Integer = 0
    Private showMsg As Boolean = False

    'Switches the display
    Public Sub SwitchForms()
        If MainControl1.Visible Then
            MainControl1.Visible = False
            AddLocationForm1.Visible = True
        Else
            MainControl1.Visible = True
            AddLocationForm1.Visible = False
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    'Opens the pilot page and added event handler to message control
    Private Sub MainControl1_Load(sender As Object, e As EventArgs) Handles MainControl1.Load
        Pilot.Show()
        AddHandler MessageControl1.SendBtnClicked, AddressOf MsgSent
    End Sub

    'Resizes the form on load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(984, 647)
    End Sub


    'Resizes the form when user click toggles the messages button
    Private Sub MsgToggle_Click(sender As Object, e As EventArgs) Handles MsgToggle.Click
        showMsg = Not showMsg
        If showMsg Then
            Me.Size = New Size(1364, 647)
        Else
            Me.Size = New Size(984, 647)
        End If
    End Sub

    'Sends addeds message to message control in main form and pilot form
    Private Sub MsgSent()
        MessageControl1.AddMsg("Visitor 1", MessageControl1.MsgText.Text)
        Pilot.MessageControl1.AddMsg("Visitor 1", MessageControl1.MsgText.Text)
    End Sub
End Class
