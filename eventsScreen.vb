Imports System.IO

Public Class eventsScreen
    Private Sub eventsScreen_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub BUTsave_Click(sender As Object, e As EventArgs) Handles BUTsave.Click
        'The record defined is validated, encrypted and saved to 'events.txt'
        Dim inpRecord, encRecord As List(Of String)
        Dim EvidR As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\EvID.txt")
        Dim EventID As Integer = EvidR.ReadLine + 1
        EvidR.Close()
        Dim SEventID As String = EventID
        'here the new event ID is made by taking the previous one from evID.txt, adding one then filling out the rest of the digits so that its 4 characters long.
        Do Until SEventID.Length = 4
            SEventID = "0" & SEventID
        Loop
        inpRecord = {TBOeName.Text.ToString, DTPeDate.Value.ToString, TBOpID.Text, TBOoID.Text, SEventID, TBOoName.Text, TBOre.Text, TBOadd.Text}.ToList
        Dim valid(2) As Boolean
        'the validation is done primaraly through functions defined in Module1
        'the date doesn't need validation as the formating is done by the date time picker and I do want events to be set in the past to account for accidental deletion
        valid(0) = isIntAlph(inpRecord(2))
        If valid(0) = True Then
            'these if statements are used to perform multiple checks on one field, it's funtionally the samne as an and statement
            valid(0) = inpRecord(2).Length = 8
        End If
        valid(1) = isIntAlph(inpRecord(3))
        If valid(1) = True Then
            valid(1) = inpRecord(3).Length = 8
        End If
        valid(2) = isAlph(inpRecord(5))
        'due to issues with adding to empty strings the string needs to be defined as "" in order to be added to easily
        Dim errorMsg As String = ""
        'the error message is built from the fields which returned false from the validation checks
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
        'if any of the validations return false the error message is displayed, else the record is saved to events.txt and the id in EvID.txt is updated
        If valid.Contains(False) Then
            TBOerrorMsg.Text = errorMsg
        Else
            Dim EvIDW As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path & "\EvID.txt", False)
            EvIDW.WriteLine(SEventID)
            EvIDW.Close()
            encRecord = encrypt(inpRecord)
            Dim file As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path & "\Events.txt", True)
            Dim saveString As String
            saveString = encRecord(0)
            For i = 1 To encRecord.Count - 1
                saveString += ","
                saveString += encRecord(i)
            Next
            file.WriteLine(saveString)
            file.Close()
            'the fields need to be cleared for another addition of a record.
            TBOerrorMsg.Text = "saved"
            TBOadd.Text = ""
            TBOeName.Text = ""
            TBOoID.Text = ""
            TBOoName.Text = ""
            TBOpID.Text = ""
            TBOadd.Text = ""
            TBOre.Text = ""
        End If

    End Sub

    Private Sub toOptions_Click(sender As Object, e As EventArgs) Handles toOptions.Click
        'takes the user to the options page
        view_events.Show()
        Me.Dispose()
    End Sub
End Class