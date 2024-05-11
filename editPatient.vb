Public Class editPatient
    Dim textLine As Integer
    Private Sub toPatients_Click(sender As Object, e As EventArgs) Handles toPatients.Click
        viewPatients.Show()
        Me.Dispose()
    End Sub
    Private Sub editPatient_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub
    Private Sub editPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the record that sent the user to this page is loaded into the approprate text boxes using the global variable PRowInfo to identify said record
        Dim decFile, tempList As New List(Of String)
        decFile = decrypt("Patients.txt")
        For i As Integer = 0 To decFile.Count - 1
            tempList.Clear()
            tempList = decFile(i).Split(",").ToList
            If PRowInfo.Equals(tempList(1)) Then
                TBOName.Text = tempList(0)
                TBOID.Text = tempList(1)
                DTPoB.Value = tempList(2)
                TBOPoB.Text = tempList(3)
                CBOSex.Text = tempList(4)
                TBODNI.Text = tempList(5)
                TBOEMail.Text = tempList(6)
                DTPoA.Value = tempList(7)
                TBORfC.Text = tempList(8)
                TBOMed.Text = tempList(9)
                TBOAdd.Text = tempList(10)
                'textLine is used later for the replacement of the record
                textLine = i
                Exit For
            End If
        Next
    End Sub

    Private Sub BttSave_Click(sender As Object, e As EventArgs) Handles BttSave.Click
        'here the edited record is replaced in a list representation of the patients.txt file then saved over the original data
        Dim encrecord, errors As New List(Of String)
        Dim savestring, message As String
        encrecord = {TBOName.Text, TBOID.Text, DTPoB.Value.ToString, TBOPoB.Text, CBOSex.Text, TBODNI.Text, TBOEMail.Text, DTPoA.Value.ToString, TBORfC.Text, TBOMed.Text, TBOAdd.Text}.ToList
        message = ""
        savestring = ""
        Dim validate(6) As Boolean
        errors = {"The patient name is invalid. ", "The patient ID is invalid. ", "The Place of birth is invalid. ", "The sex is invalid. ", "The DNI is invalid. ", "The E-mail is invalid. ", "The medication is invalid. "}.ToList
        'this is essentially the same validation as adding a patient record
        validate(0) = isAlph(encrecord(0))
        validate(1) = isIntAlph(encrecord(1))
        If validate(1) = True Then
            'the if statements essentailly act as and statements for each of the fields which require multiple validations
            validate(1) = encrecord(1).Length = 8
        End If
        validate(2) = (encrecord(3).Length > 0)
        validate(3) = encrecord(4).Equals("Male") OrElse encrecord(4).Equals("Female") OrElse encrecord(4).Equals("Prefer not to say")
        validate(4) = IsNumeric(encrecord(5))
        If validate(4) = True Then
            validate(4) = encrecord(5).Length = 12
        End If
        validate(5) = encrecord(6).Split("@").Length = 2
        validate(6) = isIntAlph(encrecord(9))
        For i As Integer = 0 To 6
            If validate(i) = False Then
                message += errors(i)
            End If
        Next
        If validate.Contains(False) Then
            'the error message is built during the validation checks, if any of the checks failed the error message is displayed
            TBOerrorMsg.Text = message
        Else
            'The record is synthesised as one string and replaced in a list representation of the patients.txt file which is written over the original text file
            encrecord = encrypt(encrecord)
            Dim synthRecord As String = ""
            For Each field As String In encrecord
                synthRecord += field & ","
            Next
            Dim lines As New List(Of String)
            Dim temp As String
            Dim evFileRead As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\Patients.txt")
            Do Until evFileRead.EndOfStream
                temp = evFileRead.ReadLine
                If Not (temp = "") Then
                    'trying to avoid empty records
                    lines.Add(temp)
                End If
            Loop
            evFileRead.Close()
            lines(textLine) = synthRecord
            System.IO.File.WriteAllLines(path & "\Patients.txt", lines)
            TBOerrorMsg.Text = "Saved"
        End If
    End Sub

    Private Sub BTTEdit_Click(sender As Object, e As EventArgs) Handles BTTEdit.Click
        'enables editing
        BttSave.Visible = True
        TBOAdd.ReadOnly = False
        TBODNI.ReadOnly = False
        TBOEMail.ReadOnly = False
        TBOID.ReadOnly = False
        TBOMed.ReadOnly = False
        TBOName.ReadOnly = False
        TBOPoB.ReadOnly = False
        TBORfC.ReadOnly = False
    End Sub

    Private Sub BTTDel_Click(sender As Object, e As EventArgs) Handles BTTDel.Click
        'checks if the user wants to delete the record
        TBOsure.Visible = True
        BTTyes.Visible = True
        BTTNo.Visible = True
    End Sub

    Private Sub BTTyes_Click(sender As Object, e As EventArgs) Handles BTTyes.Click
        'the record is removed from a list representation of the patients file then is written over the original text document
        Dim temp As New List(Of String)
        Dim evfile As List(Of String) = decrypt("Patients.txt")
        For Each record As String In evfile
            temp.Clear()
            temp = record.Split(",").ToList
            If PRowInfo = temp(1) Then
                evfile.Remove(record)
                System.IO.File.WriteAllLines(path & "\Patients.txt", encrypt(evfile))
                Exit For
            End If
        Next
        Me.Dispose()
        viewPatients.Show()
    End Sub

    Private Sub BTTNo_Click(sender As Object, e As EventArgs) Handles BTTNo.Click
        BTTNo.Visible = False
        BTTyes.Visible = False
        TBOsure.Visible = False
    End Sub

End Class