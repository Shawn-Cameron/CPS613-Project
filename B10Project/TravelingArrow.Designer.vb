<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelingArrow
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
        ImgBox = New PictureBox()
        TimeLabel = New Label()
        Label1 = New Label()
        CType(ImgBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImgBox
        ' 
        ImgBox.Location = New Point(3, 18)
        ImgBox.Name = "ImgBox"
        ImgBox.Size = New Size(96, 24)
        ImgBox.TabIndex = 0
        ImgBox.TabStop = False
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Location = New Point(24, 0)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(19, 15)
        TimeLabel.TabIndex = 1
        TimeLabel.Text = "10"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 2
        Label1.Text = "Min"
        ' 
        ' TravelingArrow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(TimeLabel)
        Controls.Add(ImgBox)
        Name = "TravelingArrow"
        Size = New Size(104, 49)
        CType(ImgBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImgBox As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label1 As Label

End Class
