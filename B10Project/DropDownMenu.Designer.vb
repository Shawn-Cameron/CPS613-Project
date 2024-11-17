<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DropDownMenu
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
        OptionsListBox = New CheckedListBox()
        filterBtn = New Button()
        ContinentsBtn = New Button()
        ContinentsListBox = New CheckedListBox()
        SuspendLayout()
        ' 
        ' OptionsListBox
        ' 
        OptionsListBox.BorderStyle = BorderStyle.None
        OptionsListBox.FormattingEnabled = True
        OptionsListBox.Items.AddRange(New Object() {"Future", "Past", "Most Popular"})
        OptionsListBox.Location = New Point(3, 32)
        OptionsListBox.Name = "OptionsListBox"
        OptionsListBox.Size = New Size(120, 54)
        OptionsListBox.TabIndex = 1
        OptionsListBox.Visible = False
        ' 
        ' filterBtn
        ' 
        filterBtn.BackColor = SystemColors.Control
        filterBtn.FlatStyle = FlatStyle.Flat
        filterBtn.Location = New Point(3, 3)
        filterBtn.Name = "filterBtn"
        filterBtn.Size = New Size(122, 23)
        filterBtn.TabIndex = 2
        filterBtn.Text = "Filter"
        filterBtn.UseVisualStyleBackColor = False
        ' 
        ' ContinentsBtn
        ' 
        ContinentsBtn.BackColor = SystemColors.Control
        ContinentsBtn.FlatStyle = FlatStyle.Flat
        ContinentsBtn.Location = New Point(3, 92)
        ContinentsBtn.Name = "ContinentsBtn"
        ContinentsBtn.Size = New Size(122, 23)
        ContinentsBtn.TabIndex = 3
        ContinentsBtn.Text = "Continents"
        ContinentsBtn.UseVisualStyleBackColor = False
        ContinentsBtn.Visible = False
        ' 
        ' ContinentsListBox
        ' 
        ContinentsListBox.BorderStyle = BorderStyle.None
        ContinentsListBox.FormattingEnabled = True
        ContinentsListBox.Items.AddRange(New Object() {"North America", "South America", "Africa", "Asia", "Europe", "Australia/Oceania", "Antarctia"})
        ContinentsListBox.Location = New Point(35, 121)
        ContinentsListBox.Name = "ContinentsListBox"
        ContinentsListBox.Size = New Size(120, 126)
        ContinentsListBox.TabIndex = 4
        ContinentsListBox.Visible = False
        ' 
        ' DropDownMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(ContinentsListBox)
        Controls.Add(ContinentsBtn)
        Controls.Add(filterBtn)
        Controls.Add(OptionsListBox)
        Name = "DropDownMenu"
        Size = New Size(158, 251)
        ResumeLayout(False)
    End Sub
    Friend WithEvents OptionsListBox As CheckedListBox
    Friend WithEvents filterBtn As Button
    Friend WithEvents ContinentsBtn As Button
    Friend WithEvents ContinentsListBox As CheckedListBox


End Class
