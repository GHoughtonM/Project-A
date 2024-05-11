<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPatient
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
        components = New ComponentModel.Container()
        CBOSex = New ComboBox()
        DTPoA = New DateTimePicker()
        DTPoB = New DateTimePicker()
        BttSave = New Button()
        TBOAdd = New TextBox()
        TBOMed = New TextBox()
        TBORfC = New TextBox()
        TBOEMail = New TextBox()
        TBODNI = New TextBox()
        TBOPoB = New TextBox()
        TextBox13 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox10 = New TextBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TBOID = New TextBox()
        TextBox3 = New TextBox()
        TBOName = New TextBox()
        TextBox1 = New TextBox()
        toPatients = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TBOerrorMsg = New TextBox()
        BTTEdit = New Button()
        BTTDel = New Button()
        BTTyes = New Button()
        BTTNo = New Button()
        TBOsure = New TextBox()
        SuspendLayout()
        ' 
        ' CBOSex
        ' 
        CBOSex.FormattingEnabled = True
        CBOSex.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        CBOSex.Location = New Point(351, 378)
        CBOSex.Margin = New Padding(6)
        CBOSex.Name = "CBOSex"
        CBOSex.Size = New Size(288, 40)
        CBOSex.TabIndex = 50
        ' 
        ' DTPoA
        ' 
        DTPoA.Location = New Point(351, 563)
        DTPoA.Margin = New Padding(6)
        DTPoA.Name = "DTPoA"
        DTPoA.Size = New Size(368, 39)
        DTPoA.TabIndex = 49
        ' 
        ' DTPoB
        ' 
        DTPoB.Location = New Point(351, 254)
        DTPoB.Margin = New Padding(6)
        DTPoB.Name = "DTPoB"
        DTPoB.Size = New Size(368, 39)
        DTPoB.TabIndex = 48
        ' 
        ' BttSave
        ' 
        BttSave.Location = New Point(1254, 749)
        BttSave.Margin = New Padding(6)
        BttSave.Name = "BttSave"
        BttSave.Size = New Size(139, 49)
        BttSave.TabIndex = 47
        BttSave.Text = "Save"
        BttSave.UseVisualStyleBackColor = True
        BttSave.Visible = False
        ' 
        ' TBOAdd
        ' 
        TBOAdd.Location = New Point(351, 749)
        TBOAdd.Margin = New Padding(6)
        TBOAdd.Name = "TBOAdd"
        TBOAdd.ReadOnly = True
        TBOAdd.Size = New Size(288, 39)
        TBOAdd.TabIndex = 46
        ' 
        ' TBOMed
        ' 
        TBOMed.Location = New Point(351, 687)
        TBOMed.Margin = New Padding(6)
        TBOMed.Name = "TBOMed"
        TBOMed.ReadOnly = True
        TBOMed.Size = New Size(288, 39)
        TBOMed.TabIndex = 45
        ' 
        ' TBORfC
        ' 
        TBORfC.Location = New Point(351, 625)
        TBORfC.Margin = New Padding(6)
        TBORfC.Name = "TBORfC"
        TBORfC.ReadOnly = True
        TBORfC.Size = New Size(288, 39)
        TBORfC.TabIndex = 44
        ' 
        ' TBOEMail
        ' 
        TBOEMail.Location = New Point(351, 501)
        TBOEMail.Margin = New Padding(6)
        TBOEMail.Name = "TBOEMail"
        TBOEMail.ReadOnly = True
        TBOEMail.Size = New Size(288, 39)
        TBOEMail.TabIndex = 43
        ' 
        ' TBODNI
        ' 
        TBODNI.Location = New Point(351, 439)
        TBODNI.Margin = New Padding(6)
        TBODNI.Name = "TBODNI"
        TBODNI.ReadOnly = True
        TBODNI.Size = New Size(288, 39)
        TBODNI.TabIndex = 42
        ' 
        ' TBOPoB
        ' 
        TBOPoB.Location = New Point(351, 316)
        TBOPoB.Margin = New Padding(6)
        TBOPoB.Name = "TBOPoB"
        TBOPoB.ReadOnly = True
        TBOPoB.Size = New Size(288, 39)
        TBOPoB.TabIndex = 41
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(154, 501)
        TextBox13.Margin = New Padding(6)
        TextBox13.Name = "TextBox13"
        TextBox13.ReadOnly = True
        TextBox13.Size = New Size(182, 39)
        TextBox13.TabIndex = 40
        TextBox13.Text = "E-Mail"
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(154, 563)
        TextBox12.Margin = New Padding(6)
        TextBox12.Name = "TextBox12"
        TextBox12.ReadOnly = True
        TextBox12.Size = New Size(182, 39)
        TextBox12.TabIndex = 39
        TextBox12.Text = "Date of admission"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(91, 625)
        TextBox11.Margin = New Padding(6)
        TextBox11.Name = "TextBox11"
        TextBox11.ReadOnly = True
        TextBox11.Size = New Size(245, 39)
        TextBox11.TabIndex = 38
        TextBox11.Text = "Reason for consultation"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(154, 687)
        TextBox10.Margin = New Padding(6)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(182, 39)
        TextBox10.TabIndex = 37
        TextBox10.Text = "Medication"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(154, 749)
        TextBox9.Margin = New Padding(6)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(182, 39)
        TextBox9.TabIndex = 36
        TextBox9.Text = "Addional info"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(154, 439)
        TextBox8.Margin = New Padding(6)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(182, 39)
        TextBox8.TabIndex = 35
        TextBox8.Text = "DNI"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(154, 378)
        TextBox7.Margin = New Padding(6)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(182, 39)
        TextBox7.TabIndex = 34
        TextBox7.Text = "Sex"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(154, 316)
        TextBox6.Margin = New Padding(6)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(182, 39)
        TextBox6.TabIndex = 33
        TextBox6.Text = "Place of birth"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(154, 254)
        TextBox5.Margin = New Padding(6)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(182, 39)
        TextBox5.TabIndex = 32
        TextBox5.Text = "Date of Birth"
        ' 
        ' TBOID
        ' 
        TBOID.Location = New Point(351, 192)
        TBOID.Margin = New Padding(6)
        TBOID.Name = "TBOID"
        TBOID.ReadOnly = True
        TBOID.Size = New Size(288, 39)
        TBOID.TabIndex = 31
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(154, 192)
        TextBox3.Margin = New Padding(6)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(182, 39)
        TextBox3.TabIndex = 30
        TextBox3.Text = "ID"
        ' 
        ' TBOName
        ' 
        TBOName.Location = New Point(351, 130)
        TBOName.Margin = New Padding(6)
        TBOName.Name = "TBOName"
        TBOName.ReadOnly = True
        TBOName.Size = New Size(288, 39)
        TBOName.TabIndex = 29
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 130)
        TextBox1.Margin = New Padding(6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 28
        TextBox1.Text = "Name"
        ' 
        ' toPatients
        ' 
        toPatients.Location = New Point(1348, -4)
        toPatients.Margin = New Padding(6)
        toPatients.Name = "toPatients"
        toPatients.Size = New Size(139, 49)
        toPatients.TabIndex = 27
        toPatients.Text = "Back"
        toPatients.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TBOerrorMsg
        ' 
        TBOerrorMsg.Location = New Point(91, 855)
        TBOerrorMsg.Margin = New Padding(6)
        TBOerrorMsg.Name = "TBOerrorMsg"
        TBOerrorMsg.ReadOnly = True
        TBOerrorMsg.Size = New Size(1170, 39)
        TBOerrorMsg.TabIndex = 52
        ' 
        ' BTTEdit
        ' 
        BTTEdit.Location = New Point(1348, 58)
        BTTEdit.Margin = New Padding(6)
        BTTEdit.Name = "BTTEdit"
        BTTEdit.Size = New Size(139, 49)
        BTTEdit.TabIndex = 53
        BTTEdit.Text = "Edit"
        BTTEdit.UseVisualStyleBackColor = True
        ' 
        ' BTTDel
        ' 
        BTTDel.Location = New Point(0, 0)
        BTTDel.Margin = New Padding(6)
        BTTDel.Name = "BTTDel"
        BTTDel.Size = New Size(139, 49)
        BTTDel.TabIndex = 54
        BTTDel.Text = "Delete"
        BTTDel.UseVisualStyleBackColor = True
        ' 
        ' BTTyes
        ' 
        BTTyes.Location = New Point(353, 0)
        BTTyes.Margin = New Padding(6)
        BTTyes.Name = "BTTyes"
        BTTyes.Size = New Size(139, 49)
        BTTyes.TabIndex = 55
        BTTyes.Text = "Yes"
        BTTyes.UseVisualStyleBackColor = True
        BTTyes.Visible = False
        ' 
        ' BTTNo
        ' 
        BTTNo.Location = New Point(503, 0)
        BTTNo.Margin = New Padding(6)
        BTTNo.Name = "BTTNo"
        BTTNo.Size = New Size(139, 49)
        BTTNo.TabIndex = 56
        BTTNo.Text = "No"
        BTTNo.UseVisualStyleBackColor = True
        BTTNo.Visible = False
        ' 
        ' TBOsure
        ' 
        TBOsure.BorderStyle = BorderStyle.None
        TBOsure.Location = New Point(160, 4)
        TBOsure.Margin = New Padding(6)
        TBOsure.Name = "TBOsure"
        TBOsure.ReadOnly = True
        TBOsure.Size = New Size(182, 32)
        TBOsure.TabIndex = 57
        TBOsure.Text = "Are you sure?"
        TBOsure.Visible = False
        TBOsure.WordWrap = False
        ' 
        ' editPatient
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(TBOsure)
        Controls.Add(BTTNo)
        Controls.Add(BTTyes)
        Controls.Add(BTTDel)
        Controls.Add(BTTEdit)
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
        Controls.Add(toPatients)
        Margin = New Padding(6)
        Name = "editPatient"
        Text = "editPatient"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents CBOSex As ComboBox
    Friend WithEvents DTPoA As DateTimePicker
    Friend WithEvents DTPoB As DateTimePicker
    Friend WithEvents BttSave As Button
    Friend WithEvents TBOAdd As TextBox
    Friend WithEvents TBOMed As TextBox
    Friend WithEvents TBORfC As TextBox
    Friend WithEvents TBOEMail As TextBox
    Friend WithEvents TBODNI As TextBox
    Friend WithEvents TBOPoB As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TBOID As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TBOName As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents toPatients As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TBOerrorMsg As TextBox
    Friend WithEvents BTTEdit As Button
    Friend WithEvents BTTDel As Button
    Friend WithEvents BTTyes As Button
    Friend WithEvents BTTNo As Button
    Friend WithEvents TBOsure As TextBox
End Class
