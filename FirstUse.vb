
Public Class FirstUse
    'in all instances of the line me.dispose(False), the false statement is used to not dispose of the form's data from RAM, otherwise since this is the 'main form' the application will close
    Private Sub FirstUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Here I need to see if this is the first use of the program, initially setup.txt will contain "False" allowing this screen to be shown setting the password.
        'if it reads "True" the normal login screen will show
        Dim read As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\Setup.txt")
        Dim start As String = read.ReadLine
        If start.Equals("True") Then
            Login.Show()
            Me.Dispose(False)
        End If
        read.Close()
    End Sub
    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        'The two inputted passwords are compared to each other to assure they're the same
        If Password1.Text.Equals(Password2.Text) Then
            'if they're the same the password is encrypted and saved to the file password.txt
            confirm.Visible = True
            Dim file As System.IO.StreamWriter
            Dim inPassword As List(Of String) = {Password1.Text}.ToList
            file = My.Computer.FileSystem.OpenTextFileWriter(path & "\Password.txt", False)
            Dim temp As List(Of String) = encrypt(inPassword)
            Dim encpass As String = temp(0).ToString
            file.WriteLine(encpass)
            file.Close()
            file = My.Computer.FileSystem.OpenTextFileWriter(path & "\Setup.txt", False)
            file.WriteLine(True)
            file.Close()
            Options.Show()
            Me.Dispose(False)
        ElseIf Password1.Text.Equals(Password2.Text) = False Then
            'If they're not the same the error box os desplayed containing the appropriate message
            ErrorBox.Visible = True
        End If
    End Sub
End Class
