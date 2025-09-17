<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudentForm
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
        btnClear = New Button()
        cmbCategory = New ComboBox()
        category = New Label()
        cmbSection = New ComboBox()
        cmbYear = New ComboBox()
        cmbProgram = New ComboBox()
        section = New Label()
        year = New Label()
        program = New Label()
        studentNo = New Label()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        suffix = New Label()
        middleName = New Label()
        firstName = New Label()
        lastName = New Label()
        Label1 = New Label()
        txtLastName = New TextBox()
        cmbSuffix = New ComboBox()
        Label2 = New Label()
        mtbStudentID = New MaskedTextBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btnSave, 2, 7)
        TableLayoutPanel1.Controls.Add(btnClear, 3, 7)
        TableLayoutPanel1.Controls.Add(cmbCategory, 0, 6)
        TableLayoutPanel1.Controls.Add(category, 0, 5)
        TableLayoutPanel1.Controls.Add(cmbSection, 3, 4)
        TableLayoutPanel1.Controls.Add(cmbYear, 2, 4)
        TableLayoutPanel1.Controls.Add(cmbProgram, 1, 4)
        TableLayoutPanel1.Controls.Add(section, 3, 3)
        TableLayoutPanel1.Controls.Add(year, 2, 3)
        TableLayoutPanel1.Controls.Add(program, 1, 3)
        TableLayoutPanel1.Controls.Add(studentNo, 0, 3)
        TableLayoutPanel1.Controls.Add(txtMiddleName, 2, 2)
        TableLayoutPanel1.Controls.Add(txtFirstName, 1, 2)
        TableLayoutPanel1.Controls.Add(suffix, 3, 1)
        TableLayoutPanel1.Controls.Add(middleName, 2, 1)
        TableLayoutPanel1.Controls.Add(firstName, 1, 1)
        TableLayoutPanel1.Controls.Add(lastName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(txtLastName, 0, 2)
        TableLayoutPanel1.Controls.Add(cmbSuffix, 3, 2)
        TableLayoutPanel1.Controls.Add(Label2, 0, 7)
        TableLayoutPanel1.Controls.Add(mtbStudentID, 0, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 18.9814816F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740757F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740719F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DarkSeaGreen
        btnSave.Dock = DockStyle.Fill
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.ForeColor = SystemColors.ActiveCaptionText
        btnSave.Location = New Point(403, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(194, 47)
        btnSave.TabIndex = 22
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(603, 400)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(194, 47)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        TableLayoutPanel1.SetColumnSpan(cmbCategory, 4)
        cmbCategory.Dock = DockStyle.Fill
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Interskills", "Esports", "Sports", "Others"})
        cmbCategory.Location = New Point(3, 348)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(794, 23)
        cmbCategory.TabIndex = 19
        ' 
        ' category
        ' 
        category.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        category.AutoSize = True
        category.Font = New Font("Segoe UI", 9.75F)
        category.Location = New Point(3, 328)
        category.Name = "category"
        category.Size = New Size(66, 17)
        category.TabIndex = 18
        category.Text = "*Category"
        category.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbSection
        ' 
        cmbSection.Dock = DockStyle.Fill
        cmbSection.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSection.FormattingEnabled = True
        cmbSection.Items.AddRange(New Object() {"A", "B", "C"})
        cmbSection.Location = New Point(603, 244)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(194, 23)
        cmbSection.TabIndex = 16
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbYear.Location = New Point(403, 244)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(194, 23)
        cmbYear.TabIndex = 15
        ' 
        ' cmbProgram
        ' 
        cmbProgram.Dock = DockStyle.Fill
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"BSCS", "BSIS", "BSEMC", "BSIT"})
        cmbProgram.Location = New Point(203, 244)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(194, 23)
        cmbProgram.TabIndex = 14
        ' 
        ' section
        ' 
        section.AutoSize = True
        section.Dock = DockStyle.Left
        section.Font = New Font("Segoe UI", 9.75F)
        section.Location = New Point(603, 189)
        section.Name = "section"
        section.Size = New Size(55, 52)
        section.TabIndex = 12
        section.Text = "*Section"
        section.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' year
        ' 
        year.AutoSize = True
        year.Dock = DockStyle.Left
        year.Font = New Font("Segoe UI", 9.75F)
        year.Location = New Point(403, 189)
        year.Name = "year"
        year.Size = New Size(38, 52)
        year.TabIndex = 11
        year.Text = "*Year"
        year.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' program
        ' 
        program.AutoSize = True
        program.Dock = DockStyle.Left
        program.Font = New Font("Segoe UI", 9.75F)
        program.Location = New Point(203, 189)
        program.Name = "program"
        program.Size = New Size(64, 52)
        program.TabIndex = 10
        program.Text = "*Program"
        program.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' studentNo
        ' 
        studentNo.AutoSize = True
        studentNo.Dock = DockStyle.Left
        studentNo.Font = New Font("Segoe UI", 9.75F)
        studentNo.Location = New Point(3, 189)
        studentNo.Name = "studentNo"
        studentNo.Size = New Size(82, 52)
        studentNo.TabIndex = 9
        studentNo.Text = "*Student No."
        studentNo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Location = New Point(403, 140)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(194, 23)
        txtMiddleName.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Location = New Point(203, 140)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(194, 23)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Left
        suffix.Font = New Font("Segoe UI", 9.75F)
        suffix.Location = New Point(603, 85)
        suffix.Name = "suffix"
        suffix.Size = New Size(39, 52)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Left
        middleName.Font = New Font("Segoe UI", 9.75F)
        middleName.Location = New Point(403, 85)
        middleName.Name = "middleName"
        middleName.Size = New Size(88, 52)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' firstName
        ' 
        firstName.AutoSize = True
        firstName.Dock = DockStyle.Left
        firstName.Font = New Font("Segoe UI", 9.75F)
        firstName.Location = New Point(203, 85)
        firstName.Name = "firstName"
        firstName.Size = New Size(76, 52)
        firstName.TabIndex = 2
        firstName.Text = "*First Name"
        firstName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lastName
        ' 
        lastName.AutoSize = True
        lastName.Dock = DockStyle.Left
        lastName.Font = New Font("Segoe UI", 9.75F)
        lastName.Location = New Point(3, 85)
        lastName.Name = "lastName"
        lastName.Size = New Size(75, 52)
        lastName.TabIndex = 1
        lastName.Text = "*Last Name"
        lastName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(794, 85)
        Label1.TabIndex = 0
        Label1.Text = "EDIT FORM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Location = New Point(3, 140)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(194, 23)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "III.", "IV.", "V."})
        cmbSuffix.Location = New Point(603, 140)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(194, 23)
        cmbSuffix.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label2, 2)
        Label2.Location = New Point(3, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(394, 53)
        Label2.TabIndex = 20
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mtbStudentID
        ' 
        mtbStudentID.Location = New Point(3, 243)
        mtbStudentID.Margin = New Padding(3, 2, 3, 2)
        mtbStudentID.Mask = "00000000-L"
        mtbStudentID.Name = "mtbStudentID"
        mtbStudentID.Size = New Size(78, 23)
        mtbStudentID.TabIndex = 21
        ' 
        ' EditStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "EditStudentForm"
        Text = "EditStudentForm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents category As Label
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents section As Label
    Friend WithEvents year As Label
    Friend WithEvents program As Label
    Friend WithEvents studentNo As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents suffix As Label
    Friend WithEvents middleName As Label
    Friend WithEvents firstName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbStudentID As MaskedTextBox
End Class
