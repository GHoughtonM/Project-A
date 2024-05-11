<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patientsScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        toOptions = New Button()
        TextBox1 = New TextBox()
        TBOName = New TextBox()
        TextBox3 = New TextBox()
        TBOID = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TBOPoB = New TextBox()
        TBODNI = New TextBox()
        TBOEMail = New TextBox()
        TBORfC = New TextBox()
        TBOMed = New TextBox()
        TBOAdd = New TextBox()
        BttSave = New Button()
        DTPoB = New DateTimePicker()
        DTPoA = New DateTimePicker()
        CBOSex = New ComboBox()
        TBOerrorMsg = New TextBox()
        SuspendLayout()
        ' 
        ' toOptions
        ' 
        toOptions.Location = New Point(1345, -2)
        toOptions.Margin = New Padding(6, 6, 6, 6)
        toOptions.Name = "toOptions"
        toOptions.Size = New Size(139, 49)
        toOptions.TabIndex = 0
        toOptions.Text = "Back"
        toOptions.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(150, 132)
        TextBox1.Margin = New Padding(6, 6, 6, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Name"
        ' 
        ' TBOName
        ' 
        TBOName.Location = New Point(347, 132)
        TBOName.Margin = New Padding(6, 6, 6, 6)
        TBOName.Name = "TBOName"
        TBOName.Size = New Size(288, 39)
        TBOName.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(150, 194)
        TextBox3.Margin = New Padding(6, 6, 6, 6)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(182, 39)
        TextBox3.TabIndex = 3
        TextBox3.Text = "ID"
        ' 
        ' TBOID
        ' 
        TBOID.Location = New Point(347, 194)
        TBOID.Margin = New Padding(6, 6, 6, 6)
        TBOID.Name = "TBOID"
        TBOID.Size = New Size(288, 39)
        TBOID.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(150, 256)
        TextBox5.Margin = New Padding(6, 6, 6, 6)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(182, 39)
        TextBox5.TabIndex = 5
        TextBox5.Text = "Date of Birth"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(150, 318)
        TextBox6.Margin = New Padding(6, 6, 6, 6)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(182, 39)
        TextBox6.TabIndex = 6
        TextBox6.Text = "Place of birth"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(150, 380)
        TextBox7.Margin = New Padding(6, 6, 6, 6)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(182, 39)
        TextBox7.TabIndex = 7
        TextBox7.Text = "Sex"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(150, 442)
        TextBox8.Margin = New Padding(6, 6, 6, 6)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(182, 39)
        TextBox8.TabIndex = 8
        TextBox8.Text = "DNI"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(150, 751)
        TextBox9.Margin = New Padding(6, 6, 6, 6)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(182, 39)
        TextBox9.TabIndex = 9
        TextBox9.Text = "Addional info"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(150, 689)
        TextBox10.Margin = New Padding(6, 6, 6, 6)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(182, 39)
        TextBox10.TabIndex = 10
        TextBox10.Text = "Medication"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(87, 627)
        TextBox11.Margin = New Padding(6, 6, 6, 6)
        TextBox11.Name = "TextBox11"
        TextBox11.ReadOnly = True
        TextBox11.Size = New Size(245, 39)
        TextBox11.TabIndex = 11
        TextBox11.Text = "Reason for consultation"
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(150, 565)
        TextBox12.Margin = New Padding(6, 6, 6, 6)
        TextBox12.Name = "TextBox12"
        TextBox12.ReadOnly = True
        TextBox12.Size = New Size(182, 39)
        TextBox12.TabIndex = 12
        TextBox12.Text = "Date of admission"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(150, 503)
        TextBox13.Margin = New Padding(6, 6, 6, 6)
        TextBox13.Name = "TextBox13"
        TextBox13.ReadOnly = True
        TextBox13.Size = New Size(182, 39)
        TextBox13.TabIndex = 13
        TextBox13.Text = "E-Mail"
        ' 
        ' TBOPoB
        ' 
        TBOPoB.Location = New Point(347, 318)
        TBOPoB.Margin = New Padding(6, 6, 6, 6)
        TBOPoB.Name = "TBOPoB"
        TBOPoB.Size = New Size(288, 39)
        TBOPoB.TabIndex = 15
        ' 
        ' TBODNI
        ' 
        TBODNI.Location = New Point(347, 442)
        TBODNI.Margin = New Padding(6, 6, 6, 6)
        TBODNI.Name = "TBODNI"
        TBODNI.Size = New Size(288, 39)
        TBODNI.TabIndex = 17
        ' 
        ' TBOEMail
        ' 
        TBOEMail.Location = New Point(347, 503)
        TBOEMail.Margin = New Padding(6, 6, 6, 6)
        TBOEMail.Name = "TBOEMail"
        TBOEMail.Size = New Size(288, 39)
        TBOEMail.TabIndex = 18
        ' 
        ' TBORfC
        ' 
        TBORfC.Location = New Point(347, 627)
        TBORfC.Margin = New Padding(6, 6, 6, 6)
        TBORfC.Name = "TBORfC"
        TBORfC.Size = New Size(288, 39)
        TBORfC.TabIndex = 20
        ' 
        ' TBOMed
        ' 
        TBOMed.Location = New Point(347, 689)
        TBOMed.Margin = New Padding(6, 6, 6, 6)
        TBOMed.Name = "TBOMed"
        TBOMed.Size = New Size(288, 39)
        TBOMed.TabIndex = 21
        ' 
        ' TBOAdd
        ' 
        TBOAdd.Location = New Point(347, 751)
        TBOAdd.Margin = New Padding(6, 6, 6, 6)
        TBOAdd.Name = "TBOAdd"
        TBOAdd.Size = New Size(288, 39)
        TBOAdd.TabIndex = 22
        ' 
        ' BttSave
        ' 
        BttSave.Location = New Point(1250, 751)
        BttSave.Margin = New Padding(6, 6, 6, 6)
        BttSave.Name = "BttSave"
        BttSave.Size = New Size(139, 49)
        BttSave.TabIndex = 23
        BttSave.Text = "Save"
        BttSave.UseVisualStyleBackColor = True
        ' 
        ' DTPoB
        ' 
        DTPoB.Location = New Point(347, 256)
        DTPoB.Margin = New Padding(6, 6, 6, 6)
        DTPoB.Name = "DTPoB"
        DTPoB.Size = New Size(368, 39)
        DTPoB.TabIndex = 24
        ' 
        ' DTPoA
        ' 
        DTPoA.Location = New Point(347, 565)
        DTPoA.Margin = New Padding(6, 6, 6, 6)
        DTPoA.Name = "DTPoA"
        DTPoA.Size = New Size(368, 39)
        DTPoA.TabIndex = 25
        ' 
        ' CBOSex
        ' 
        CBOSex.FormattingEnabled = True
        CBOSex.Items.AddRange(New Object() {"Male", "Female", "Prefere not to say"})
        CBOSex.Location = New Point(347, 380)
        CBOSex.Margin = New Padding(6, 6, 6, 6)
        CBOSex.Name = "CBOSex"
        CBOSex.Size = New Size(288, 40)
        CBOSex.TabIndex = 26
        ' 
        ' TBOerrorMsg
        ' 
        TBOerrorMsg.Location = New Point(150, 885)
        TBOerrorMsg.Margin = New Padding(6, 6, 6, 6)
        TBOerrorMsg.Name = "TBOerrorMsg"
        TBOerrorMsg.ReadOnly = True
        TBOerrorMsg.Size = New Size(1016, 39)
        TBOerrorMsg.TabIndex = 27
        ' 
        ' patientsScreen
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(TBOerrorMsg)
        Controls.Add(CBOSex)
        Controls.Add(DTPoA)
        Controls.Add(DTPoB)
        Controls.Add(BttSave)
        Controls.Add(TBOAdd)
        Controls.Add(TBOMed)
        Controls.Add(TBORfC)
        Controls.Add(TBOEMail)
        Controls.Add(TBODNI)
        Controls.Add(TBOPoB)
        Controls.Add(TextBox13)
        Controls.Add(TextBox12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TBOID)
        Controls.Add(TextBox3)
        Controls.Add(TBOName)
        Controls.Add(TextBox1)
        Controls.Add(toOptions)
        Margin = New Padding(6, 6, 6, 6)
        Name = "patientsScreen"
        Text = "patientsScreen"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents toOptions As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TBOName As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TBOID As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TBOPoB As TextBox
    Friend WithEvents TBODNI As TextBox
    Friend WithEvents TBOEMail As TextBox
    Friend WithEvents TBORfC As TextBox
    Friend WithEvents TBOMed As TextBox
    Friend WithEvents TBOAdd As TextBox
    Friend WithEvents BttSave As Button
    Friend WithEvents DTPoB As DateTimePicker
    Friend WithEvents DTPoA As DateTimePicker
    Friend WithEvents CBOSex As ComboBox
    Friend WithEvents TBOerrorMsg As TextBox
End Class
