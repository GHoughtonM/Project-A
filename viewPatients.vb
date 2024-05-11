Public Class viewPatients
    Dim dateEnabled() As Boolean = {False, False}
    Private Sub seePatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The patients.txt file is decrypted and loaded into the data grid view
        Dim temp(), temp2(7) As String
        Dim decFile As List(Of String) = decrypt("Patients.txt")
        Dim evDates(decFile.Count) As Date
        Dim counter As Integer
        For counter = 0 To decFile.Count - 1
            'the dates have to be separated from the records to be 
            temp = decFile(counter).Split(",")
            evDates(counter) = temp(7)
        Next
        sortDates(evDates, decFile)
        For i As Integer = 0 To decFile.Count - 1
            temp = decFile(i).Split(",")
            For j As Integer = 0 To 7
                temp2(j) = temp(j)
            Next
            DGVPat.Rows.Add(temp2)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTTBack.Click
        'Takes the user to the options screen
        Options.Show()
        Me.Dispose()
    End Sub

    Private Sub BTTAdd_Click(sender As Object, e As EventArgs) Handles BTTAdd.Click
        'take sthe user to the adding screen
        patientsScreen.Show()
        Me.Dispose()
    End Sub
    Private Sub myBase_Closed(Sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub BTTSearch_Click(sender As Object, e As EventArgs) Handles BTTSearch.Click
        'this is effectively a linear search but with multiple search fields.
        'It takes the inputed search parameters and compares them to those of each record in patients.txt, matches are made when the fields match or the inputed field is blank
        DGVPat.Rows.Clear()
        Dim sortlist, inpList, temp, parameters As New List(Of String)
        Dim tempDate As New List(Of Date)
        Dim row() As String
        inpList = decrypt("Patients.txt")
        Dim isBlank, match As New List(Of Boolean)
        parameters = {TBOName.Text, TBOID.Text, DTPDoB.Value.ToShortDateString, TBOPoB.Text, CBOSex.Text, TBODNI.Text, TBOEmail.Text, DTPDoA.Value.ToShortDateString}.ToList
        For Each item As String In parameters
            If item.Equals("") Then
                isBlank.Add(True)
            Else
                isBlank.Add(False)
            End If
        Next
        For Each record As String In inpList
            'here all fields need to be blank or matching to add the record to the sortList, due to some technicalities with visual basic simply writing a long text of and's and or's doesn't work as such the following method using a list is used
            tempDate.Clear()
            match.Clear()
            temp = record.Split(",").ToList
            tempDate.Add(temp(2))
            tempDate.Add(temp(7))
            match.Add(temp(0) = parameters(0) Or isBlank(0))
            match.Add(temp(1) = parameters(1) Or isBlank(1))
            match.Add(tempDate(0).ToShortDateString = parameters(2) Or dateEnabled(0) = False)
            match.Add(temp(3) = parameters(3) Or isBlank(3))
            match.Add(temp(4) = parameters(4) Or isBlank(4))
            match.Add(temp(5) = parameters(5) Or isBlank(5))
            match.Add(temp(6) = parameters(6) Or isBlank(6))
            match.Add(tempDate(1).ToShortDateString = parameters(7) Or dateEnabled(1) = False)
            If match.Contains(False) = False Then
                sortlist.Add(record)
            End If
        Next
        For Each Srecord As String In sortlist
            temp = Srecord.Split(",").ToList
            row = temp.ToArray
            DGVPat.Rows.Add(row)
        Next
    End Sub

    Private Sub BTTDoB_Click(sender As Object, e As EventArgs) Handles BTTDoB.Click
        'this enables one of the date time pickers as they cannot be left blank and as such require other methods (in this case the dateEnables array) to be disabled
        If DTPDoB.Visible Then
            DTPDoB.Visible = False
        Else
            DTPDoB.Visible = True
        End If
        If dateEnabled(0) Then
            dateEnabled(0) = False
        Else
            dateEnabled(0) = True
        End If
    End Sub

    Private Sub BTTDoA_Click(sender As Object, e As EventArgs) Handles BTTDoA.Click
        'This enables the other date time picker
        If DTPDoA.Visible Then
            DTPDoA.Visible = False
        Else
            DTPDoA.Visible = True
        End If
        If dateEnabled(1) Then
            dateEnabled(1) = False
        Else
            dateEnabled(1) = True
        End If
    End Sub

    Private Sub DGVPat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPat.CellContentDoubleClick
        'when a cell is double clicked this sends the user to the edit patient screen, PRowInfo is used to pass over the location of the record to be loaded.
        DGVPat.CurrentCell = DGVPat.Rows(e.RowIndex).Cells(1)
        PRowInfo = DGVPat.CurrentCell.Value
        editPatient.Show()
        Me.Dispose()
    End Sub
End Class