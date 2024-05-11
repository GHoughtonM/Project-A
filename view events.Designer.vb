<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_events
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
        DGVEvents = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        BTTaddEvent = New Button()
        TBONsearch = New TextBox()
        TBOIsearch = New TextBox()
        TBOPsearch1 = New TextBox()
        DTPSearch = New DateTimePicker()
        BTTsearch = New Button()
        BTTDsearch = New Button()
        TBOPsearch2 = New TextBox()
        BTTBack = New Button()
        TextBox1 = New TextBox()
        CType(DGVEvents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVEvents
        ' 
        DGVEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVEvents.Columns.AddRange(New DataGridViewColumn() {Column1, Column4, Column3, Column2})
        DGVEvents.Location = New Point(290, 0)
        DGVEvents.Margin = New Padding(6, 6, 6, 6)
        DGVEvents.Name = "DGVEvents"
        DGVEvents.RowHeadersWidth = 82
        DGVEvents.RowTemplate.Height = 25
        DGVEvents.Size = New Size(1008, 602)
        DGVEvents.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Event Name"
        Column1.MinimumWidth = 10
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        Column1.Width = 200
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Date"
        Column4.MinimumWidth = 10
        Column4.Name = "Column4"
        Column4.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Participants"
        Column3.MinimumWidth = 10
        Column3.Name = "Column3"
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        Column3.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Event ID"
        Column2.MinimumWidth = 10
        Column2.Name = "Column2"
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        Column2.Width = 200
        ' 
        ' BTTaddEvent
        ' 
        BTTaddEvent.Location = New Point(0, 0)
        BTTaddEvent.Margin = New Padding(6, 6, 6, 6)
        BTTaddEvent.Name = "BTTaddEvent"
        BTTaddEvent.Size = New Size(139, 49)
        BTTaddEvent.TabIndex = 1
        BTTaddEvent.Text = "Add event"
        BTTaddEvent.UseVisualStyleBackColor = True
        ' 
        ' TBONsearch
        ' 
        TBONsearch.Location = New Point(305, 719)
        TBONsearch.Margin = New Padding(6, 6, 6, 6)
        TBONsearch.Name = "TBONsearch"
        TBONsearch.PlaceholderText = "Event search"
        TBONsearch.Size = New Size(182, 39)
        TBONsearch.TabIndex = 2
        ' 
        ' TBOIsearch
        ' 
        TBOIsearch.Location = New Point(501, 719)
        TBOIsearch.Margin = New Padding(6, 6, 6, 6)
        TBOIsearch.Name = "TBOIsearch"
        TBOIsearch.PlaceholderText = "ID search"
        TBOIsearch.Size = New Size(182, 39)
        TBOIsearch.TabIndex = 3
        ' 
        ' TBOPsearch1
        ' 
        TBOPsearch1.Location = New Point(698, 719)
        TBOPsearch1.Margin = New Padding(6, 6, 6, 6)
        TBOPsearch1.Name = "TBOPsearch1"
        TBOPsearch1.PlaceholderText = "Participant 1"
        TBOPsearch1.Size = New Size(182, 39)
        TBOPsearch1.TabIndex = 4
        ' 
        ' DTPSearch
        ' 
        DTPSearch.Location = New Point(1064, 719)
        DTPSearch.Margin = New Padding(6, 6, 6, 6)
        DTPSearch.Name = "DTPSearch"
        DTPSearch.Size = New Size(368, 39)
        DTPSearch.TabIndex = 5
        DTPSearch.Value = New Date(2021, 4, 6, 0, 0, 0, 0)
        DTPSearch.Visible = False
        ' 
        ' BTTsearch
        ' 
        BTTsearch.Location = New Point(305, 781)
        BTTsearch.Margin = New Padding(6, 6, 6, 6)
        BTTsearch.Name = "BTTsearch"
        BTTsearch.Size = New Size(139, 49)
        BTTsearch.TabIndex = 7
        BTTsearch.Text = "Search"
        BTTsearch.UseVisualStyleBackColor = True
        ' 
        ' BTTDsearch
        ' 
        BTTDsearch.Location = New Point(897, 719)
        BTTDsearch.Margin = New Padding(6, 6, 6, 6)
        BTTDsearch.Name = "BTTDsearch"
        BTTDsearch.Size = New Size(156, 49)
        BTTDsearch.TabIndex = 8
        BTTDsearch.Text = "Search Date"
        BTTDsearch.UseVisualStyleBackColor = True
        ' 
        ' TBOPsearch2
        ' 
        TBOPsearch2.Location = New Point(698, 783)
        TBOPsearch2.Margin = New Padding(6, 6, 6, 6)
        TBOPsearch2.Name = "TBOPsearch2"
        TBOPsearch2.PlaceholderText = "Participant 2"
        TBOPsearch2.Size = New Size(182, 39)
        TBOPsearch2.TabIndex = 9
        ' 
        ' BTTBack
        ' 
        BTTBack.Location = New Point(1350, 0)
        BTTBack.Margin = New Padding(6, 6, 6, 6)
        BTTBack.Name = "BTTBack"
        BTTBack.Size = New Size(139, 49)
        BTTBack.TabIndex = 10
        BTTBack.Text = "Back"
        BTTBack.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(568, 614)
        TextBox1.Margin = New Padding(6, 6, 6, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(433, 32)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Double-click a cell to view the full event"
        ' 
        ' view_events
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(TextBox1)
        Controls.Add(BTTBack)
        Controls.Add(TBOPsearch2)
        Controls.Add(BTTDsearch)
        Controls.Add(BTTsearch)
        Controls.Add(DTPSearch)
        Controls.Add(TBOPsearch1)
        Controls.Add(TBOIsearch)
        Controls.Add(TBONsearch)
        Controls.Add(BTTaddEvent)
        Controls.Add(DGVEvents)
        Margin = New Padding(6, 6, 6, 6)
        Name = "view_events"
        Text = "view_events"
        CType(DGVEvents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DGVEvents As DataGridView
    Friend WithEvents BTTaddEvent As Button
    Friend WithEvents TBONsearch As TextBox
    Friend WithEvents TBOIsearch As TextBox
    Friend WithEvents TBOPsearch1 As TextBox
    Friend WithEvents DTPSearch As DateTimePicker
    Friend WithEvents BTTsearch As Button
    Friend WithEvents BTTDsearch As Button
    Friend WithEvents TBOPsearch2 As TextBox
    Friend WithEvents BTTBack As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
