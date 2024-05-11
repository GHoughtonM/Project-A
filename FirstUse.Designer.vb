<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstUse

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Password1 = New TextBox()
        Password2 = New TextBox()
        Finish = New Button()
        ErrorBox = New TextBox()
        confirm = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(537, 47)
        TextBox1.Margin = New Padding(6, 6, 6, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(374, 64)
        TextBox1.TabIndex = 0
        TextBox1.Text = "First time use setup"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(410, 286)
        TextBox2.Margin = New Padding(6, 6, 6, 6)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(156, 32)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Set password:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(368, 348)
        TextBox3.Margin = New Padding(6, 6, 6, 6)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(199, 32)
        TextBox3.TabIndex = 2
        TextBox3.Text = "Confirm password:"
        ' 
        ' Password1
        ' 
        Password1.Location = New Point(578, 286)
        Password1.Margin = New Padding(6, 6, 6, 6)
        Password1.Name = "Password1"
        Password1.PasswordChar = "*"c
        Password1.Size = New Size(333, 39)
        Password1.TabIndex = 3
        ' 
        ' Password2
        ' 
        Password2.Location = New Point(578, 348)
        Password2.Margin = New Padding(6, 6, 6, 6)
        Password2.Name = "Password2"
        Password2.PasswordChar = "*"c
        Password2.Size = New Size(333, 39)
        Password2.TabIndex = 4
        ' 
        ' Finish
        ' 
        Finish.Location = New Point(604, 435)
        Finish.Margin = New Padding(6, 6, 6, 6)
        Finish.Name = "Finish"
        Finish.Size = New Size(139, 49)
        Finish.TabIndex = 5
        Finish.Text = "Finish"
        Finish.UseVisualStyleBackColor = True
        ' 
        ' ErrorBox
        ' 
        ErrorBox.BackColor = Color.White
        ErrorBox.ForeColor = Color.Red
        ErrorBox.Location = New Point(782, 437)
        ErrorBox.Margin = New Padding(6, 6, 6, 6)
        ErrorBox.Name = "ErrorBox"
        ErrorBox.ReadOnly = True
        ErrorBox.Size = New Size(312, 39)
        ErrorBox.TabIndex = 6
        ErrorBox.Text = "Error: passwords do not match"
        ErrorBox.Visible = False
        ' 
        ' confirm
        ' 
        confirm.BackColor = Color.White
        confirm.ForeColor = Color.Red
        confirm.Location = New Point(782, 437)
        confirm.Margin = New Padding(6, 6, 6, 6)
        confirm.Name = "confirm"
        confirm.ReadOnly = True
        confirm.Size = New Size(312, 39)
        confirm.TabIndex = 7
        confirm.Text = "Passwords match"
        confirm.Visible = False
        ' 
        ' FirstUse
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        CausesValidation = False
        ClientSize = New Size(1486, 960)
        Controls.Add(confirm)
        Controls.Add(ErrorBox)
        Controls.Add(Finish)
        Controls.Add(Password2)
        Controls.Add(Password1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Margin = New Padding(6, 6, 6, 6)
        Name = "FirstUse"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Password1 As TextBox
    Friend WithEvents Password2 As TextBox
    Friend WithEvents Finish As Button
    Friend WithEvents ErrorBox As TextBox
    Friend WithEvents confirm As TextBox
End Class
