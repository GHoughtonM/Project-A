Public Class view_events
    Dim DateEnabled As Boolean = False
    Private Sub view_events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The code here is basically the same as on the option screen but without the date filter
        Dim temp(), temp2(4) As String
        Dim decFile As List(Of String) = decrypt("Events.txt")
        Dim evDates(decFile.Count) As Date
        Dim counter As Integer
        'this collects the dates of each record which when split are in position 1 as they are necessary for the sortdates function
        For counter = 0 To decFile.Count - 1
            temp = decFile(counter).Split(",")
            evDates(counter) = temp(1)
        Next
        'sorts the records by date from the earliest onwards
        sortDates(evDates, decFile)
        'displays a limited number of properties from each record where the others can be seen when viewing specific events.
        For i As Integer = 0 To decFile.Count - 1
            temp = decFile(i).Split(",")
            temp2(0) = temp(0)
            temp2(1) = temp(1)
            temp2(2) = temp(2) & " " & temp(3)
            temp2(3) = temp(4)
            DGVEvents.Rows.Add(temp2)
        Next
    End Sub
    Private Sub close_() Handles Me.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub
    Private Sub BTTaddEvent_Click(sender As Object, e As EventArgs) Handles BTTaddEvent.Click
        'Takes the user to the add events screen
        eventsScreen.Show()
        Me.Dispose()
    End Sub

    Private Sub BTTsearch_Click(sender As Object, e As EventArgs) Handles BTTsearch.Click
        'The event records are searched based off of the used search parameters.
        'this is essentially a linear search except that each record has multiple properties that need to be checked for.
        DGVEvents.Rows.Clear()
        Dim searchList, inpList, temp, parameters As New List(Of String)
        Dim tempDate As Date
        Dim row() As String
        inpList = decrypt("Events.txt")
        Dim isBlank, match As New List(Of Boolean)
        parameters = {TBONsearch.Text, DTPSearch.Value.ToShortDateString, TBOPsearch1.Text, TBOPsearch2.Text, TBOIsearch.Text}.ToList
        'a blank search bar is not taken into account when comparing records, a note of which fields have been left blank needs to be taken not of for this purpose
        For Each item As String In parameters
            If item.Equals("") Then
                isBlank.Add(True)
            Else
                isBlank.Add(False)
            End If
        Next
        'Here I use a list to check how each field compares to those in events.txt
        'this method is used as opposed to sticking a load of Or's and and's together for better visual clarity but also because visual basic doesn't handle lots of or's and and's very well logically speaking
        For Each record As String In inpList
            match.Clear()
            temp = record.Split(",").ToList
            tempDate = temp(1)
            match.Add(temp(0) = parameters(0) Or isBlank(0))
            match.Add(parameters(1) = tempDate.ToShortDateString Or DateEnabled = False)
            match.Add(temp(2) = parameters(2) Or temp(2) = parameters(3) Or isBlank(2))
            match.Add(temp(3) = parameters(3) Or temp(3) = parameters(2) Or isBlank(3))
            match.Add(temp(4) = parameters(4) Or isBlank(4))
            'the contains method checks whether any of the fields matched as false, if it doesn't the record is added to the list 'searchList'
            If match.Contains(False) = False Then
                searchList.Add(record)
            End If
        Next
        'the list 'searchList' has its records split about commas and shown on the data grid view
        For Each Srecord As String In searchList
            temp = Srecord.Split(",").ToList
            row = {temp(0), temp(1), temp(2) & " " & temp(3), temp(4)}
            DGVEvents.Rows.Add(row)
        Next
    End Sub

    Private Sub BTTDsearch_Click(sender As Object, e As EventArgs) Handles BTTDsearch.Click
        'date time pickers cannot be blank, as such whilst enabled the user cannot leave it blank hence requiring another method to disable the search for dates
        'this simply shows/hides the date time picker but more importantly sets the 'dateEnabled' variable to be used in the search 
        If DateEnabled = False Then
            DateEnabled = True
        Else
            DateEnabled = False
        End If
        If DTPSearch.Visible = True Then
            DTPSearch.Visible = False
        Else
            DTPSearch.Visible = True
        End If
    End Sub

    Private Sub BTTBack_Click(sender As Object, e As EventArgs) Handles BTTBack.Click
        'takes the user back to the options page
        Options.Show()
        Me.Dispose()
    End Sub
    Private Sub view_events_Close() Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub DGVEvents_CellContentdoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEvents.CellContentDoubleClick
        'when a cell is double clicked the user is taken to a page to view the record in its entirety, a global variable 'ERowInfo' is set to load the correct record into the viewing page.
        DGVEvents.CurrentCell = DGVEvents.Rows(e.RowIndex).Cells(3)
        ERowInfo = DGVEvents.CurrentCell.Value
        editEvent.Show()
        Me.Dispose()
    End Sub
End Class