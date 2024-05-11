<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewPatients
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
        ID = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DGVPat = New DataGridView()
        COLName = New DataGridViewTextBoxColumn()
        COLID = New DataGridViewTextBoxColumn()
        COLDOB = New DataGridViewTextBoxColumn()
        COLPOB = New DataGridViewTextBoxColumn()
        COLSex = New DataGridViewTextBoxColumn()
        COLDNI = New DataGridViewTextBoxColumn()
        COLMail = New DataGridViewTextBoxColumn()
        COLDOA = New DataGridViewTextBoxColumn()
        BTTBack = New Button()
        BTTAdd = New Button()
        TBOName = New TextBox()
        TBOID = New TextBox()
        TBOPoB = New TextBox()
        TBODNI = New TextBox()
        TBOEmail = New TextBox()
        DTPDoB = New DateTimePicker()
        DTPDoA = New DateTimePicker()
        BTTDoB = New Button()
        BTTDoA = New Button()
        CBOSex = New ComboBox()
        TextBox1 = New TextBox()
        BTTSearch = New Button()
        TextBox2 = New TextBox()
        CType(DGVPat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 10
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Width = 200
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 10
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 200
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Name"
        DataGridViewTextBoxColumn2.MinimumWidth = 10
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 200
        ' 
        ' DGVPat
        ' 
        DGVPat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVPat.Columns.AddRange(New DataGridViewColumn() {COLName, COLID, COLDOB, COLPOB, COLSex, COLDNI, COLMail, COLDOA})
        DGVPat.Location = New Point(22, 26)
        DGVPat.Margin = New Padding(6, 6, 6, 6)
        DGVPat.Name = "DGVPat"
        DGVPat.RowHeadersWidth = 82
        DGVPat.RowTemplate.Height = 25
        DGVPat.Size = New Size(1657, 841)
        DGVPat.TabIndex = 0
        ' 
        ' COLName
        ' 
        COLName.HeaderText = "Name"
        COLName.MinimumWidth = 10
        COLName.Name = "COLName"
        COLName.ReadOnly = True
        COLName.Width = 200
        ' 
        ' COLID
        ' 
        COLID.HeaderText = "ID"
        COLID.MinimumWidth = 10
        COLID.Name = "COLID"
        COLID.ReadOnly = True
        COLID.Width = 200
        ' 
        ' COLDOB
        ' 
        COLDOB.HeaderText = "Date of birth"
        COLDOB.MinimumWidth = 10
        COLDOB.Name = "COLDOB"
        COLDOB.ReadOnly = True
        COLDOB.Width = 200
        ' 
        ' COLPOB
        ' 
        COLPOB.HeaderText = "Place of birth"
        COLPOB.MinimumWidth = 10
        COLPOB.Name = "COLPOB"
        COLPOB.ReadOnly = True
        COLPOB.Width = 200
        ' 
        ' COLSex
        ' 
        COLSex.HeaderText = "Sex"
        COLSex.MinimumWidth = 10
        COLSex.Name = "COLSex"
        COLSex.ReadOnly = True
        COLSex.Width = 200
        ' 
        ' COLDNI
        ' 
        COLDNI.HeaderText = "DNI"
        COLDNI.MinimumWidth = 10
        COLDNI.Name = "COLDNI"
        COLDNI.ReadOnly = True
        COLDNI.Width = 200
        ' 
        ' COLMail
        ' 
        COLMail.HeaderText = "E-mail"
        COLMail.MinimumWidth = 10
        COLMail.Name = "COLMail"
        COLMail.ReadOnly = True
        COLMail.Width = 150
        ' 
        ' COLDOA
        ' 
        COLDOA.HeaderText = "Date of admission"
        COLDOA.MinimumWidth = 10
        COLDOA.Name = "COLDOA"
        COLDOA.ReadOnly = True
        COLDOA.Width = 200
        ' 
        ' BTTBack
        ' 
        BTTBack.Location = New Point(1972, 26)
        BTTBack.Margin = New Padding(6, 6, 6, 6)
        BTTBack.Name = "BTTBack"
        BTTBack.Size = New Size(176, 49)
        BTTBack.TabIndex = 1
        BTTBack.Text = "Back"
        BTTBack.UseVisualStyleBackColor = True
        ' 
        ' BTTAdd
        ' 
        BTTAdd.Location = New Point(1972, 87)
        BTTAdd.Margin = New Padding(6, 6, 6, 6)
        BTTAdd.Name = "BTTAdd"
        BTTAdd.Size = New Size(176, 49)
        BTTAdd.TabIndex = 2
        BTTAdd.Text = "Add patient"
        BTTAdd.UseVisualStyleBackColor = True
        ' 
        ' TBOName
        ' 
        TBOName.Location = New Point(22, 986)
        TBOName.Margin = New Padding(6, 6, 6, 6)
        TBOName.Name = "TBOName"
        TBOName.PlaceholderText = "Name"
        TBOName.Size = New Size(182, 39)
        TBOName.TabIndex = 3
        ' 
        ' TBOID
        ' 
        TBOID.Location = New Point(219, 986)
        TBOID.Margin = New Padding(6, 6, 6, 6)
        TBOID.Name = "TBOID"
        TBOID.PlaceholderText = "ID"
        TBOID.Size = New Size(182, 39)
        TBOID.TabIndex = 4
        ' 
        ' TBOPoB
        ' 
        TBOPoB.Location = New Point(799, 986)
        TBOPoB.Margin = New Padding(6, 6, 6, 6)
        TBOPoB.Name = "TBOPoB"
        TBOPoB.PlaceholderText = "Place of birth"
        TBOPoB.Size = New Size(283, 39)
        TBOPoB.TabIndex = 5
        ' 
        ' TBODNI
        ' 
        TBODNI.Location = New Point(1343, 986)
        TBODNI.Margin = New Padding(6, 6, 6, 6)
        TBODNI.Name = "TBODNI"
        TBODNI.PlaceholderText = "DNI"
        TBODNI.Size = New Size(182, 39)
        TBODNI.TabIndex = 7
        ' 
        ' TBOEmail
        ' 
        TBOEmail.Location = New Point(1540, 986)
        TBOEmail.Margin = New Padding(6, 6, 6, 6)
        TBOEmail.Name = "TBOEmail"
        TBOEmail.PlaceholderText = "E-mail"
        TBOEmail.Size = New Size(182, 39)
        TBOEmail.TabIndex = 8
        ' 
        ' DTPDoB
        ' 
        DTPDoB.Location = New Point(416, 986)
        DTPDoB.Margin = New Padding(6, 6, 6, 6)
        DTPDoB.Name = "DTPDoB"
        DTPDoB.Size = New Size(368, 39)
        DTPDoB.TabIndex = 9
        DTPDoB.Visible = False
        ' 
        ' DTPDoA
        ' 
        DTPDoA.Checked = False
        DTPDoA.Location = New Point(1736, 986)
        DTPDoA.Margin = New Padding(6, 6, 6, 6)
        DTPDoA.Name = "DTPDoA"
        DTPDoA.Size = New Size(368, 39)
        DTPDoA.TabIndex = 10
        DTPDoA.Visible = False
        ' 
        ' BTTDoB
        ' 
        BTTDoB.Location = New Point(416, 924)
        BTTDoB.Margin = New Padding(6, 6, 6, 6)
        BTTDoB.Name = "BTTDoB"
        BTTDoB.Size = New Size(228, 49)
        BTTDoB.TabIndex = 11
        BTTDoB.Text = "search date of birth"
        BTTDoB.UseVisualStyleBackColor = True
        ' 
        ' BTTDoA
        ' 
        BTTDoA.Location = New Point(1736, 924)
        BTTDoA.Margin = New Padding(6, 6, 6, 6)
        BTTDoA.Name = "BTTDoA"
        BTTDoA.Size = New Size(282, 49)
        BTTDoA.TabIndex = 12
        BTTDoA.Text = "Search date of admission"
        BTTDoA.UseVisualStyleBackColor = True
        ' 
        ' CBOSex
        ' 
        CBOSex.DrawMode = DrawMode.OwnerDrawFixed
        CBOSex.FormattingEnabled = True
        CBOSex.Items.AddRange(New Object() {"Male", "Female", "Prefere not to say"})
        CBOSex.Location = New Point(1096, 986)
        CBOSex.Margin = New Padding(6, 6, 6, 6)
        CBOSex.Name = "CBOSex"
        CBOSex.Size = New Size(232, 40)
        CBOSex.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1096, 926)
        TextBox1.Margin = New Padding(6, 6, 6, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 14
        TextBox1.Text = "Sex"
        ' 
        ' BTTSearch
        ' 
        BTTSearch.Location = New Point(1736, 1071)
        BTTSearch.Margin = New Padding(6, 6, 6, 6)
        BTTSearch.Name = "BTTSearch"
        BTTSearch.Size = New Size(139, 49)
        BTTSearch.TabIndex = 15
        BTTSearch.Text = "Search"
        BTTSearch.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(436, 877)
        TextBox2.Margin = New Padding(6, 6, 6, 6)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(537, 32)
        TextBox2.TabIndex = 16
        TextBox2.Text = "Double-click a cell to view the full patient record"
        ' 
        ' viewPatients
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2171, 1323)
        Controls.Add(TextBox2)
        Controls.Add(BTTSearch)
        Controls.Add(TextBox1)
        Controls.Add(CBOSex)
        Controls.Add(BTTDoA)
        Controls.Add(BTTDoB)
        Controls.Add(DTPDoA)
        Controls.Add(DTPDoB)
        Controls.Add(TBOEmail)
        Controls.Add(TBODNI)
        Controls.Add(TBOPoB)
        Controls.Add(TBOID)
        Controls.Add(TBOName)
        Controls.Add(BTTAdd)
        Controls.Add(BTTBack)
        Controls.Add(DGVPat)
        Margin = New Padding(6, 6, 6, 6)
        Name = "viewPatients"
        Text = "See Patients"
        CType(DGVPat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DGVPat As DataGridView
    Friend WithEvents BTTBack As Button
    Friend WithEvents BTTAdd As Button
    Friend WithEvents TBOName As TextBox
    Friend WithEvents TBOID As TextBox
    Friend WithEvents TBOPoB As TextBox
    Friend WithEvents TBODNI As TextBox
    Friend WithEvents TBOEmail As TextBox
    Friend WithEvents DTPDoB As DateTimePicker
    Friend WithEvents DTPDoA As DateTimePicker
    Friend WithEvents BTTDoB As Button
    Friend WithEvents BTTDoA As Button
    Friend WithEvents CBOSex As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTTSearch As Button
    Friend WithEvents COLName As DataGridViewTextBoxColumn
    Friend WithEvents COLID As DataGridViewTextBoxColumn
    Friend WithEvents COLDOB As DataGridViewTextBoxColumn
    Friend WithEvents COLPOB As DataGridViewTextBoxColumn
    Friend WithEvents COLSex As DataGridViewTextBoxColumn
    Friend WithEvents COLDNI As DataGridViewTextBoxColumn
    Friend WithEvents COLMail As DataGridViewTextBoxColumn
    Friend WithEvents COLDOA As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
End Class
