<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        toEvents = New Button()
        toPatients = New Button()
        DGVUpEvents = New DataGridView()
        TextBox1 = New TextBox()
        eventName = New DataGridViewTextBoxColumn()
        eventDate = New DataGridViewTextBoxColumn()
        participants = New DataGridViewTextBoxColumn()
        eventID = New DataGridViewTextBoxColumn()
        CType(DGVUpEvents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' toEvents
        ' 
        toEvents.Location = New Point(2, -2)
        toEvents.Margin = New Padding(6)
        toEvents.Name = "toEvents"
        toEvents.Size = New Size(186, 75)
        toEvents.TabIndex = 0
        toEvents.Text = "To events"
        toEvents.UseVisualStyleBackColor = True
        ' 
        ' toPatients
        ' 
        toPatients.Location = New Point(1302, -2)
        toPatients.Margin = New Padding(6)
        toPatients.Name = "toPatients"
        toPatients.Size = New Size(186, 75)
        toPatients.TabIndex = 1
        toPatients.Text = "To patients"
        toPatients.UseVisualStyleBackColor = True
        ' 
        ' DGVUpEvents
        ' 
        DGVUpEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVUpEvents.Columns.AddRange(New DataGridViewColumn() {eventName, eventDate, participants, eventID})
        DGVUpEvents.Location = New Point(262, 147)
        DGVUpEvents.Margin = New Padding(6)
        DGVUpEvents.Name = "DGVUpEvents"
        DGVUpEvents.RowHeadersWidth = 82
        DGVUpEvents.RowTemplate.Height = 25
        DGVUpEvents.Size = New Size(865, 478)
        DGVUpEvents.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(579, 85)
        TextBox1.Margin = New Padding(6)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Upcoming events"
        ' 
        ' eventName
        ' 
        eventName.HeaderText = "Event Name"
        eventName.MinimumWidth = 10
        eventName.Name = "eventName"
        eventName.ReadOnly = True
        eventName.Width = 200
        ' 
        ' eventDate
        ' 
        eventDate.HeaderText = "Event Date"
        eventDate.MinimumWidth = 10
        eventDate.Name = "eventDate"
        eventDate.ReadOnly = True
        eventDate.Width = 200
        ' 
        ' participants
        ' 
        participants.HeaderText = "Participants"
        participants.MinimumWidth = 10
        participants.Name = "participants"
        participants.ReadOnly = True
        participants.Width = 200
        ' 
        ' eventID
        ' 
        eventID.HeaderText = "Event ID"
        eventID.MinimumWidth = 10
        eventID.Name = "eventID"
        eventID.ReadOnly = True
        eventID.Width = 200
        ' 
        ' Options
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(TextBox1)
        Controls.Add(DGVUpEvents)
        Controls.Add(toPatients)
        Controls.Add(toEvents)
        Margin = New Padding(6)
        Name = "Options"
        Text = "Form1"
        CType(DGVUpEvents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents toEvents As Button
    Friend WithEvents toPatients As Button
    Friend WithEvents DGVUpEvents As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents eventName As DataGridViewTextBoxColumn
    Friend WithEvents eventDate As DataGridViewTextBoxColumn
    Friend WithEvents participants As DataGridViewTextBoxColumn
    Friend WithEvents eventID As DataGridViewTextBoxColumn
End Class
