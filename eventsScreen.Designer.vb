<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventsScreen
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
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TBOpID = New TextBox()
        TextBox6 = New TextBox()
        TBOoID = New TextBox()
        TBOoName = New TextBox()
        TBOadd = New TextBox()
        TextBox13 = New TextBox()
        TBOre = New TextBox()
        TBOeName = New TextBox()
        DTPeDate = New DateTimePicker()
        BUTsave = New Button()
        TBOerrorMsg = New TextBox()
        SuspendLayout()
        ' 
        ' toOptions
        ' 
        toOptions.Location = New Point(1346, -2)
        toOptions.Margin = New Padding(6, 6, 6, 6)
        toOptions.Name = "toOptions"
        toOptions.Size = New Size(139, 49)
        toOptions.TabIndex = 0
        toOptions.Text = "Back"
        toOptions.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 113)
        TextBox1.Margin = New Padding(6, 6, 6, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Event Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(117, 175)
        TextBox2.Margin = New Padding(6, 6, 6, 6)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(182, 39)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Date of event:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(117, 237)
        TextBox4.Margin = New Padding(6, 6, 6, 6)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(182, 39)
        TextBox4.TabIndex = 4
        TextBox4.Text = "Patient ID:"
        ' 
        ' TBOpID
        ' 
        TBOpID.Location = New Point(344, 237)
        TBOpID.Margin = New Padding(6, 6, 6, 6)
        TBOpID.Name = "TBOpID"
        TBOpID.Size = New Size(182, 39)
        TBOpID.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(117, 299)
        TextBox6.Margin = New Padding(6, 6, 6, 6)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(182, 39)
        TextBox6.TabIndex = 6
        TextBox6.Text = "Other Personnel:"
        ' 
        ' TBOoID
        ' 
        TBOoID.Location = New Point(344, 299)
        TBOoID.Margin = New Padding(6, 6, 6, 6)
        TBOoID.Name = "TBOoID"
        TBOoID.PlaceholderText = "ID"
        TBOoID.Size = New Size(182, 39)
        TBOoID.TabIndex = 7
        ' 
        ' TBOoName
        ' 
        TBOoName.Location = New Point(540, 299)
        TBOoName.Margin = New Padding(6, 6, 6, 6)
        TBOoName.Name = "TBOoName"
        TBOoName.PlaceholderText = "Name"
        TBOoName.Size = New Size(182, 39)
        TBOoName.TabIndex = 8
        ' 
        ' TBOadd
        ' 
        TBOadd.Location = New Point(344, 361)
        TBOadd.Margin = New Padding(6, 6, 6, 6)
        TBOadd.Name = "TBOadd"
        TBOadd.Size = New Size(1066, 39)
        TBOadd.TabIndex = 12
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(117, 361)
        TextBox13.Margin = New Padding(6, 6, 6, 6)
        TextBox13.Name = "TextBox13"
        TextBox13.ReadOnly = True
        TextBox13.Size = New Size(182, 39)
        TextBox13.TabIndex = 13
        TextBox13.Text = "Additional Notes:"
        ' 
        ' TBOre
        ' 
        TBOre.Location = New Point(737, 299)
        TBOre.Margin = New Padding(6, 6, 6, 6)
        TBOre.Name = "TBOre"
        TBOre.PlaceholderText = "Relationship"
        TBOre.Size = New Size(673, 39)
        TBOre.TabIndex = 14
        ' 
        ' TBOeName
        ' 
        TBOeName.Location = New Point(344, 113)
        TBOeName.Margin = New Padding(6, 6, 6, 6)
        TBOeName.Name = "TBOeName"
        TBOeName.Size = New Size(182, 39)
        TBOeName.TabIndex = 15
        ' 
        ' DTPeDate
        ' 
        DTPeDate.Location = New Point(344, 175)
        DTPeDate.Margin = New Padding(6, 6, 6, 6)
        DTPeDate.Name = "DTPeDate"
        DTPeDate.Size = New Size(368, 39)
        DTPeDate.TabIndex = 16
        ' 
        ' BUTsave
        ' 
        BUTsave.Location = New Point(1274, 422)
        BUTsave.Margin = New Padding(6, 6, 6, 6)
        BUTsave.Name = "BUTsave"
        BUTsave.Size = New Size(139, 49)
        BUTsave.TabIndex = 17
        BUTsave.Text = "Save"
        BUTsave.UseVisualStyleBackColor = True
        ' 
        ' TBOerrorMsg
        ' 
        TBOerrorMsg.Location = New Point(117, 717)
        TBOerrorMsg.Margin = New Padding(6, 6, 6, 6)
        TBOerrorMsg.Name = "TBOerrorMsg"
        TBOerrorMsg.ReadOnly = True
        TBOerrorMsg.Size = New Size(1293, 39)
        TBOerrorMsg.TabIndex = 18
        ' 
        ' eventsScreen
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(TBOerrorMsg)
        Controls.Add(BUTsave)
        Controls.Add(DTPeDate)
        Controls.Add(TBOeName)
        Controls.Add(TBOre)
        Controls.Add(TextBox13)
        Controls.Add(TBOadd)
        Controls.Add(TBOoName)
        Controls.Add(TBOoID)
        Controls.Add(TextBox6)
        Controls.Add(TBOpID)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(toOptions)
        Margin = New Padding(6, 6, 6, 6)
        Name = "eventsScreen"
        Text = "eventsScreen"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents toOptions As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TBOpID As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TBOoID As TextBox
    Friend WithEvents TBOoName As TextBox
    Friend WithEvents TBOadd As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TBOre As TextBox
    Friend WithEvents TBOeName As TextBox
    Friend WithEvents DTPeDate As DateTimePicker
    Friend WithEvents BUTsave As Button
    Friend WithEvents TBOerrorMsg As TextBox
End Class
