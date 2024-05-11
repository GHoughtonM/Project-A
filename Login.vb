Public Class Login

    Private Sub Login_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'since this is not the main form for the application, closing it does not close the whole application. As such the appropriate methods need to be used
        Application.Exit()
    End Sub

    Private Sub contButt_Click(sender As Object, e As EventArgs) Handles contButt.Click
        'The password entered in the text box is compared to that saved in password.txt
        'if it matches the options screen is shown, else a message is shown to inform the user
        Dim inPass As String = passwordInp.Text
        Dim password As List(Of String) = decrypt("Password.txt")
        If inPass.Equals(password(0)) Then
            Options.Show()
            Me.Dispose()
        Else
            MsgBox("password is invalid")
        End If
    End Sub
End Class