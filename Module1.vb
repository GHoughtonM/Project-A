Imports System.Text.RegularExpressions
Module Module1
    'these are global variables used when editing event/patient records to keep the location of the record between forms
    Public ERowInfo, PRowInfo As String
    'this is a string which contains the path to the location of all my text files, in addition to cleaning up repetetive text it allows for the program to run on other devices.
    Public path As String = My.Computer.FileSystem.CurrentDirectory
    Public Function encrypt(inpData As List(Of String)) As List(Of String)
        'this encrypts data by moving letters 5 spaces in the alphabet and numbers 5 didgets up
        'it will take in a list of strings and output the equivialent encrypted list
        Dim encData(inpData.Count) As String
        Dim tempRecord As String
        Dim i, j, k, alphPosition As Integer
        Dim validAlpha As Boolean
        'this creates the alphabet as a list of characters to be used later
        Dim alphabet() As Char = ("abcdefghijklmnopqrstuvwxyz").ToCharArray
        Dim tempList() As Char
        i = -1
        tempRecord = ""
        For Each record As String In inpData
            'each record is split into its characters
            tempRecord = ""
            i += 1
            tempList = record.ToCharArray
            For j = 0 To record.Length - 1
                'for each of the characters in every record it is identified as a letter, number or otherwise
                'letters and numbers have the appropriate changes made, other characters are unchanged such that comma-separated fields do not have the commas changed
                For k = 0 To alphabet.Length - 1
                    If tempList(j) = alphabet(k) Then
                        alphPosition = k
                        validAlpha = True
                        Exit For
                    ElseIf k = 25 Then
                        validAlpha = False
                    End If
                Next
                If validAlpha Then
                    alphPosition = (alphPosition + 5) Mod 25
                    tempList(j) = alphabet(alphPosition)
                ElseIf IsNumeric(tempList(j)) Then
                    'val() is used to change the data type of the character to integer for maths
                    tempList(j) = ((Val(tempList(j)) + 5) Mod 10).ToString
                End If
            Next
            For Each letter As String In tempList
                tempRecord += letter
            Next
            encData(i) = (tempRecord)
        Next
        Return encData.ToList
    End Function
    Public Function decrypt(encFile As String) As List(Of String)

        'This is used to decrypt an entire text file and return it as a list of strings where each item is a line of the text file.
        Dim j, k, l, m, alphposition As Integer
        Dim counter As Integer = -1
        Dim alphabet As Char() = ("abcdefghijklmnopqrstuvwxyz").ToCharArray
        Dim tempArray As Char()
        Dim validAlpha As Boolean
        Dim temp As String
        'Observe that "filepath" is defined by combinint the text name with the path, so whenever decrypt is called in code it is done so without a path.
        Dim filePath As String = path & "\" & encFile
        Dim inpFile As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(filePath)
        Dim decFile As New List(Of String)
        'In effect this reverses the effects of the encryption function.
        Do Until inpFile.EndOfStream
            temp = inpFile.ReadLine()
            If Not temp = "" Then
                decFile.Add(temp)
            End If
        Loop
        For counter = 0 To decFile.Count - 1
            tempArray = decFile(counter).ToCharArray
            For j = 0 To tempArray.Length - 1
                For k = 0 To alphabet.Length - 1
                    If tempArray(j).Equals(alphabet(k)) Then
                        alphposition = k
                        validAlpha = True
                        Exit For
                    ElseIf k = 25 Then
                        validAlpha = False
                    End If
                Next
                If validAlpha Then
                    If (alphposition - 5) < 0 Then
                        alphposition = 25 + alphposition
                    End If
                    tempArray(j) = alphabet(alphposition - 5)
                ElseIf IsNumeric(tempArray(j)) Then
                    l = Val(tempArray(j))
                    If l > 4 Then
                        l -= 5
                    Else
                        l += 5
                    End If
                    tempArray(j) = l.ToString
                End If
            Next
            Dim tempRecord As String = ""
            For m = 0 To tempArray.Length - 1
                tempRecord += tempArray(m).ToString
            Next
            decFile(counter) = tempRecord
        Next
        inpFile.Close()
        Return decFile
    End Function
    Public Function isIntAlph(inpData As String) As Boolean
        'simply checks whether the inpData is alphabetical or numerical
        Dim tempArray() As Char = inpData.ToCharArray
        For Each item In tempArray
            If Not Char.IsLetterOrDigit(item, 0) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Function isAlph(inpData As String) As Boolean
        'checks whether the inputted data is exclusively alphabetical
        Dim tempArray() As Char = inpData.ToCharArray
        For Each item In tempArray
            If Not Char.IsLetter(item, 0) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Function isEmail(mail As String) As Boolean
        'A format check for e-mails, will take the string, split it about the @ symbol, if the resulting array has a length of 2 that means that there was text before and after the @ suggesting the correct format
        Dim array As String() = Regex.Split(mail, "@")
        If array.Length = 2 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function sortDates(ByRef dates As Date(), ByRef SList As List(Of String)) As Date()
        'this is a recursive bubble sort for dates
        'it takes an array of dates and their corresponding records (position 4 in dates is the date for position 4 in SList) and sorts both
        'since the inputs are ByRef their corresponding array and list is also changed outside of the function
        Dim switched As Boolean = True
        Dim temp As Date
        Dim temp2 As String
        switched = False
        For i As Integer = 0 To SList.Count - 2
            If dates(i) > dates(i + 1) Then
                temp = dates(i)
                temp2 = SList(i)
                dates(i) = dates(i + 1)
                SList(i) = SList(i + 1)
                dates(i + 1) = temp
                SList(i + 1) = temp2
                switched = True
            End If
        Next
        If switched Then
            sortDates(dates, SList)
        Else
            Return dates
        End If
    End Function
End Module
