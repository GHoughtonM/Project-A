Imports System.IO
Public Class patientsScreen
    Private Sub patientsScreen_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub toOptions_Click(sender As Object, e As EventArgs) Handles toOptions.Click
        'takes the user to the options screen
        Me.Hide()
        Options.Show()
    End Sub

    Private Sub BttSave_Click(sender As Object, e As EventArgs) Handles BttSave.Click
        'saves the users inputs as a new record in the patients.txt file after validation
        Dim inpRecords, temp, errors As New List(Of String)
        Dim savestring, message As String
        message = ""
        savestring = ""
        Dim validate(6) As Boolean
        errors = {"The patient name is invalid. ", "The patient ID is invalid. ", "The Place of birth is invalid. ", "The sex is invalid. ", "The DNI is invalid. ", "The E-mail is invalid. ", "The medication is invalid. "}.ToList
        inpRecords = {TBOName.Text, TBOID.Text, DTPoB.Value.ToString, TBOPoB.Text, CBOSex.Text, TBODNI.Text, TBOEMail.Text, DTPoA.Value.ToString, TBORfC.Text, TBOMed.Text, TBOAdd.Text}.ToList
        validate(0) = isAlph(inpRecords(0))
        validate(1) = isIntAlph(inpRecords(1))
        If validate(1) = True Then
            'If statements here essentially act as and statements when using multiple validations on one field
            validate(1) = inpRecords(1).Length = 8
        End If
        validate(2) = (inpRecords(3).Length > 0)
        validate(3) = inpRecords(4).Equals("Male") OrElse inpRecords(4).Equals("Female") OrElse inpRecords(4).Equals("Prefer not to say")
        validate(4) = IsNumeric(inpRecords(5))
        If validate(4) = True Then
            validate(4) = inpRecords(5).Length = 12
        End If
        validate(5) = inpRecords(6).Split("@").Length = 2
        validate(6) = isIntAlph(inpRecords(9))
        For i As Integer = 0 To 6
            If validate(i) = False Then
                message += errors(i)
            End If
        Next
        If validate.Contains(False) Then
            TBOerrorMsg.Text = message
        Else
            'here a comma is left between every field as it is saved to the text file as the commas denote where each field atarts and ends when reading from the file
            inpRecords = encrypt(inpRecords)
            Dim patFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path & "\Patients.txt", True)
            For i As Integer = 0 To inpRecords.Count - 1
                savestring += inpRecords(i) + ","
            Next
            patFile.WriteLine(savestring)
            patFile.Close()
            'after saving the text boxes are cleard for further use
            TBOerrorMsg.Text = "Saved"
            TBOAdd.Clear()
            TBODNI.Clear()
            TBOEMail.Clear()
            TBOID.Clear()
            TBOMed.Clear()
            TBOName.Clear()
            TBOPoB.Clear()
            TBORfC.Clear()
            CBOSex.Text = ""
        End If
    End Sub
End Class