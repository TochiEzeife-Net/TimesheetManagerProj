<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtName = New TextBox()
        txtDate = New TextBox()
        txtTimeIn = New TextBox()
        txtTimeOut = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        btnView = New Button()
        lstDisplay = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(99, 134)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(216, 26)
        txtName.TabIndex = 0
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(99, 169)
        txtDate.Margin = New Padding(3, 4, 3, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(216, 26)
        txtDate.TabIndex = 1
        ' 
        ' txtTimeIn
        ' 
        txtTimeIn.Location = New Point(99, 203)
        txtTimeIn.Margin = New Padding(3, 4, 3, 4)
        txtTimeIn.Name = "txtTimeIn"
        txtTimeIn.Size = New Size(216, 26)
        txtTimeIn.TabIndex = 2
        ' 
        ' txtTimeOut
        ' 
        txtTimeOut.Location = New Point(99, 239)
        txtTimeOut.Margin = New Padding(3, 4, 3, 4)
        txtTimeOut.Name = "txtTimeOut"
        txtTimeOut.Size = New Size(216, 26)
        txtTimeOut.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(18, 293)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 28)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add Timesheet"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(18, 329)
        btnRemove.Margin = New Padding(3, 4, 3, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(149, 28)
        btnRemove.TabIndex = 5
        btnRemove.Text = "Remove Timesheet"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(144, 293)
        btnView.Margin = New Padding(3, 4, 3, 4)
        btnView.Name = "btnView"
        btnView.Size = New Size(86, 28)
        btnView.TabIndex = 6
        btnView.Text = "View All"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.Font = New Font("Segoe UI", 12.0F)
        lstDisplay.ForeColor = SystemColors.WindowText
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(350, 134)
        lstDisplay.Margin = New Padding(3, 4, 3, 4)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(223, 298)
        lstDisplay.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Location = New Point(18, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 18)
        Label1.TabIndex = 8
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 18)
        Label2.TabIndex = 9
        Label2.Text = "Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 18)
        Label3.TabIndex = 10
        Label3.Text = "Time In:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 18)
        Label4.TabIndex = 11
        Label4.Text = "Time Out:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 45.0F)
        Label5.Location = New Point(21, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(552, 72)
        Label5.TabIndex = 12
        Label5.Text = "Timesheet Manager"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(585, 485)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstDisplay)
        Controls.Add(btnView)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtTimeOut)
        Controls.Add(txtTimeIn)
        Controls.Add(txtDate)
        Controls.Add(txtName)
        Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        RightToLeft = RightToLeft.No
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtTimeIn As TextBox
    Friend WithEvents txtTimeOut As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnView As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label


End Class
