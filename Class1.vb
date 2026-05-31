Public Class Timesheet
    Public name As String
    Public dateValue As String
    Public TimeIn As String
    Public TimeOut As String

    ' Shared array for Timesheet instances
    Public Shared log(98) As Timesheet

    ' Default constructor
    Public Sub New()
        name = ""
        dateValue = ""
        TimeIn = ""
        TimeOut = ""
    End Sub

    ' Parameterized constructor of Timesheet 
    Public Sub New(Name As String, DateVal As String, InTime As String, OutTime As String)
        Me.name = Name
        dateValue = DateVal
        TimeIn = InTime
        TimeOut = OutTime
    End Sub

    ' Add timesheet (to array)
    Public Shared Sub addTimesheet(t As Timesheet)
        For i As Integer = 0 To 98
            If Timesheet.log(i) Is Nothing OrElse Timesheet.log(i).name = "" Then
                Timesheet.log(i) = t
                Exit For
            End If
        Next
    End Sub

    ' Remove timesheet (from array)
    Public Shared Sub removeTimesheet(t As Timesheet)
        Dim found As Boolean = False

        For i As Integer = 0 To 98
            If Timesheet.log(i) IsNot Nothing AndAlso
               Timesheet.log(i).name = t.name AndAlso
               Timesheet.log(i).dateValue = t.dateValue AndAlso
               Timesheet.log(i).TimeIn = t.TimeIn AndAlso
               Timesheet.log(i).TimeOut = t.TimeOut Then

                found = True

                ' Shift current timesheet in array to left
                For j As Integer = i To 97
                    Timesheet.log(j) = Timesheet.log(j + 1)
                Next

                ' Clear last array slot
                Timesheet.log(98) = New Timesheet()

                Exit For
            End If
        Next

        If Not found Then
            Console.WriteLine("invalid timesheet, please retry search")
        End If
    End Sub

    ' View all timesheets in Timesheet array log
    Public Shared Sub viewTimesheet()
        For i As Integer = 0 To 98
            If Timesheet.log(i) IsNot Nothing AndAlso Timesheet.log(i).name <> "" Then
                Console.WriteLine(Timesheet.log(i).name & vbCrLf &
                                  Timesheet.log(i).dateValue & vbCrLf &
                                  Timesheet.log(i).TimeIn & vbCrLf &
                                  Timesheet.log(i).TimeOut)
            End If
        Next
    End Sub
End Class
