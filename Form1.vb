Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim t As New Timesheet(txtName.Text, txtDate.Text, txtTimeIn.Text, txtTimeOut.Text)
        Timesheet.addTimesheet(t)

        RefreshList()
        ClearInputs()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim t As New Timesheet(txtName.Text, txtDate.Text, txtTimeIn.Text, txtTimeOut.Text)
        Timesheet.removeTimesheet(t)

        RefreshList()
        ClearInputs()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        RefreshList()
    End Sub

    Private Sub RefreshList()
        lstDisplay.Items.Clear()

        For i As Integer = 0 To 98
            If Timesheet.log(i) IsNot Nothing AndAlso Timesheet.log(i).name <> "" Then
                lstDisplay.Items.Add("Name:     " & Timesheet.log(i).name)
                lstDisplay.Items.Add("Date:     " & Timesheet.log(i).dateValue)
                lstDisplay.Items.Add("Time In:  " & Timesheet.log(i).TimeIn)
                lstDisplay.Items.Add("Time Out: " & Timesheet.log(i).TimeOut)
                lstDisplay.Items.Add("----------------------------")
            End If
        Next
    End Sub

    Private Sub ClearInputs()
        txtName.Text = ""
        txtDate.Text = ""
        txtTimeIn.Text = ""
        txtTimeOut.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Correct Form Loaded")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

