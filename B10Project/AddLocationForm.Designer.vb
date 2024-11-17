<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLocationForm
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
        BackBtn = New Button()
        SearchTextBoxPlaceholder = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 47)
        Label1.TabIndex = 0
        Label1.Text = "Add Location"
        ' 
        ' BackBtn
        ' 
        BackBtn.Location = New Point(807, 16)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(109, 27)
        BackBtn.TabIndex = 1
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' SearchTextBoxPlaceholder
        ' 
        SearchTextBoxPlaceholder.Location = New Point(287, 20)
        SearchTextBoxPlaceholder.Name = "SearchTextBoxPlaceholder"
        SearchTextBoxPlaceholder.Size = New Size(312, 23)
        SearchTextBoxPlaceholder.TabIndex = 2
        SearchTextBoxPlaceholder.Text = "Search"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.ForeColor = Color.Gray
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(632, 21)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(137, 23)
        ComboBox1.TabIndex = 4
        ComboBox1.Text = "Filter"
        ' 
        ' AddLocationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ComboBox1)
        Controls.Add(SearchTextBoxPlaceholder)
        Controls.Add(BackBtn)
        Controls.Add(Label1)
        Name = "AddLocationForm"
        Size = New Size(931, 518)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents SearchTextBoxPlaceholder As TextBox
    Friend WithEvents ComboBox1 As ComboBox

End Class
