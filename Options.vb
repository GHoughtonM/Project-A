Public Class Options
    Private Sub Options_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub toEvents_Click(sender As Object, e As EventArgs) Handles toEvents.Click
        'takes the user to the events screen
        view_events.Show()
        Me.Dispose()
    End Sub

    Private Sub toPatients_Click(sender As Object, e As EventArgs) Handles toPatients.Click
        'takes the user to the patients screen
        viewPatients.Show()
        Me.Hide()
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this shows only events coming up as opposed to on the events page where all events are shown
        Dim temp(), temp2(4) As String
        Dim tempDate As Date
        'the decrypt function returns a list of strings where each record is a comma-separated list of properties
        Dim decFile As List(Of String) = decrypt("Events.txt")
        Dim sortlist As New List(Of String)
        Dim evDates As New List(Of Date)
        Dim counter As Integer
        'here a list of records is made of only events coming after the current time
        For counter = 0 To decFile.Count - 1
            temp = decFile(counter).Split(",")
            tempDate = temp(1)
            If tempDate >= Today Then
                sortlist.Add(decFile(counter))
                evDates.Add(tempDate)
            End If
        Next
        'a limited selection of the propeties of each record is shown in the data grid view in the form, the rest can be viewed in a specific viewing of the record.
        Dim evDateArray() As Date = evDates.ToArray
        sortDates(evDateArray, sortlist)
        For i As Integer = 0 To sortlist.Count - 1
            temp = sortlist(i).Split(",")
            temp2(0) = temp(0)
            temp2(1) = temp(1)
            temp2(2) = temp(2) & " " & temp(3)
            temp2(3) = temp(4)
            DGVUpEvents.Rows.Add(temp2)
        Next
    End Sub

End Class