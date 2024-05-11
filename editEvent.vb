Public Class editEvent
    Dim textLine As Integer
    Private Sub editEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the record that was clicked to load this page is loaded into the various text boxes
        'the global variabel ERowInfo is used to find the record to be loaded
        Dim decFile, temp As New List(Of String)
        decFile = decrypt("Events.txt")
        For i As Integer = 0 To decFile.Count - 1
            temp.Clear()
            temp = decFile(i).Split(",").ToList
            If ERowInfo.Equals(temp(4)) Then
                TBOeName.Text = temp(0)
                DTPeDate.Value = temp(1)
                TBOpID.Text = temp(2)
                TBOoID.Text = temp(3)
                TBOoName.Text = temp(5)
                TBOre.Text = temp(6)
                TBOadd.Text = temp(7)
                'This is used later to replace the correct record when saved
                textLine = i
                Exit For
            End If
        Next
    End Sub
    Private Sub editEvent_Close() Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub BTTtoEventsView_Click(sender As Object, e As EventArgs) Handles BTTtoEventsView.Click
        'takes the user to the view events page
        view_events.Show()
        Me.Dispose()
    End Sub

    Private Sub BUTsave_Click(sender As Object, e As EventArgs) Handles BTTsave.Click
        'saves the changes to the record in events.txt, the validation is the same as when adding events
        Dim message As New List(Of String)
        Dim valid(2) As Boolean
        Dim encRecord As New List(Of String)
        encRecord = {TBOeName.Text, DTPeDate.Value.ToString, TBOpID.Text, TBOoID.Text, ERowInfo, TBOoName.Text, TBOre.Text, TBOadd.Text}.ToList
        valid(0) = isIntAlph(encRecord(2))
        If valid(0) = True Then
            valid(0) = encRecord(2).Length = 8
        End If
        valid(1) = isIntAlph(encRecord(3))
        If valid(1) = True Then
            valid(1) = encRecord(3).Length = 8
        End If
        valid(2) = isAlph(encRecord(5))
        Dim errorMsg As String = ""
        For i As Integer = 0 To 2
            If valid(i) = False Then
                If i = 0 Then
                    errorMsg = errorMsg & ("The Patient ID is invalid; ")
                ElseIf i = 1 Then
                    errorMsg = errorMsg & ("The other personell's ID is invalid; ")
                ElseIf i = 2 Then
                    errorMsg = errorMsg & ("The other personell's name is invalid;")
                End If
            End If
        Next
        If valid.Contains(False) Then
            For Each item As String In message
                errorMsg = errorMsg & ", " & item
            Next
            TBOerrorMsg.Text = errorMsg
        Else
            'the record is encrypted, replaced in a list of records from events.txt, then saved back over the text file.
            encRecord = encrypt(encRecord)
            Dim synthRecord As String = ""
            For Each field As String In encRecord
                synthRecord += field & ","
            Next
            Dim lines As New List(Of String)
            Dim temp As String
            Dim evFileRead As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\Events.txt")
            Do Until evFileRead.EndOfStream
                temp = evFileRead.ReadLine
                If Not (temp = "") Then
                    lines.Add(temp)
                End If
            Loop
            evFileRead.Close()
            lines(textLine) = synthRecord
            System.IO.File.WriteAllLines(path & "\Events.txt", lines)
            TBOerrorMsg.Text = "Saved"
        End If

    End Sub

    Private Sub BTTEdit_Click(sender As Object, e As EventArgs) Handles BTTEdit.Click
        'this allows the user to edit the text boxes, going from 'viewing' to 'editing', unfortunately not all input boxes have a read only option
        BTTEdit.Visible = False
        BTTsave.Visible = True
        TBOeName.ReadOnly = False
        TBOadd.ReadOnly = False
        TBOoID.ReadOnly = False
        TBOoName.ReadOnly = False
        TBOpID.ReadOnly = False
        TBOre.ReadOnly = False
    End Sub
    Private Sub BTTDel_Click(sender As Object, e As EventArgs) Handles BTTDel.Click
        'this opens up the 'are you sure' options for deleting the record
        TBOsure.Visible = True
        BTTYes.Visible = True
        BTTNo.Visible = True
    End Sub
    Private Sub BTTNo_Click(sender As Object, e As EventArgs) Handles BTTNo.Click
        'This hides the 'are you sure' options having selected 'No'
        BTTNo.Visible = False
        BTTYes.Visible = False
        TBOsure.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTTYes.Click
        'having selected yes the events.txt file is read to a list, has the apropriate record removed and the remaining records written back to the file
        Dim temp As New List(Of String)
        Dim evfile As List(Of String) = decrypt("Events.txt")
        For Each record As String In evfile
            temp.Clear()
            temp = record.Split(",").ToList
            If ERowInfo = temp(4) Then
                evfile.Remove(record)
                System.IO.File.WriteAllLines(path & "\Events.txt", encrypt(evfile))
                Exit For
            End If
        Next
        'afterwards the user is taken back the the view events page 
        Me.Dispose()
        view_events.Show()
    End Sub

End Class