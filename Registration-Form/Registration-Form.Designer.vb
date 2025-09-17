<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnRegister = New Button()
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
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.Controls.Add(btnRegister, 2, 7)
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.5740738F))
        TableLayoutPanel1.Size = New Size(634, 261)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.IndianRed
        btnRegister.Dock = DockStyle.Fill
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(319, 232)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(152, 26)
        btnRegister.TabIndex = 22
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(477, 232)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(154, 26)
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
        cmbCategory.Location = New Point(3, 202)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(628, 23)
        cmbCategory.TabIndex = 19
        ' 
        ' category
        ' 
        category.Anchor = AnchorStyles.Left
        category.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(category, 4)
        category.Location = New Point(3, 176)
        category.Name = "category"
        category.Size = New Size(60, 15)
        category.TabIndex = 18
        category.Text = "*Category"
        category.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbSection
        ' 
        cmbSection.Dock = DockStyle.Fill
        cmbSection.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSection.FormattingEnabled = True
        cmbSection.Items.AddRange(New Object() {"A", "B", "C"})
        cmbSection.Location = New Point(477, 142)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(154, 23)
        cmbSection.TabIndex = 16
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbYear.Location = New Point(319, 142)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(152, 23)
        cmbYear.TabIndex = 15
        ' 
        ' cmbProgram
        ' 
        cmbProgram.Dock = DockStyle.Fill
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"BSCS", "BSIS", "BSEMC", "BSIT"})
        cmbProgram.Location = New Point(161, 142)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(152, 23)
        cmbProgram.TabIndex = 14
        ' 
        ' section
        ' 
        section.AutoSize = True
        section.Dock = DockStyle.Left
        section.Location = New Point(477, 109)
        section.Name = "section"
        section.Size = New Size(51, 30)
        section.TabIndex = 12
        section.Text = "*Section"
        section.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' year
        ' 
        year.AutoSize = True
        year.Dock = DockStyle.Left
        year.Location = New Point(319, 109)
        year.Name = "year"
        year.Size = New Size(34, 30)
        year.TabIndex = 11
        year.Text = "*Year"
        year.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' program
        ' 
        program.AutoSize = True
        program.Dock = DockStyle.Left
        program.Location = New Point(161, 109)
        program.Name = "program"
        program.Size = New Size(58, 30)
        program.TabIndex = 10
        program.Text = "*Program"
        program.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' studentNo
        ' 
        studentNo.AutoSize = True
        studentNo.Dock = DockStyle.Left
        studentNo.Location = New Point(3, 109)
        studentNo.Name = "studentNo"
        studentNo.Size = New Size(75, 30)
        studentNo.TabIndex = 9
        studentNo.Text = "*Student No."
        studentNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Location = New Point(319, 82)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(152, 23)
        txtMiddleName.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Location = New Point(161, 82)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(152, 23)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Left
        suffix.Location = New Point(477, 49)
        suffix.Name = "suffix"
        suffix.Size = New Size(36, 30)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Left
        middleName.Location = New Point(319, 49)
        middleName.Name = "middleName"
        middleName.Size = New Size(79, 30)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' firstName
        ' 
        firstName.AutoSize = True
        firstName.Dock = DockStyle.Left
        firstName.Location = New Point(161, 49)
        firstName.Name = "firstName"
        firstName.Size = New Size(69, 30)
        firstName.TabIndex = 2
        firstName.Text = "*First Name"
        firstName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lastName
        ' 
        lastName.AutoSize = True
        lastName.Dock = DockStyle.Left
        lastName.Location = New Point(3, 49)
        lastName.Name = "lastName"
        lastName.Size = New Size(68, 30)
        lastName.TabIndex = 1
        lastName.Text = "*Last Name"
        lastName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(628, 49)
        Label1.TabIndex = 0
        Label1.Text = "CSD FAIR REGISTRATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Location = New Point(3, 82)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(152, 23)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"Jr.", "Sr.", "III.", "IV.", "V."})
        cmbSuffix.Location = New Point(477, 82)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(154, 23)
        cmbSuffix.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label2, 2)
        Label2.Location = New Point(3, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(310, 32)
        Label2.TabIndex = 20
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mtbStudentID
        ' 
        mtbStudentID.Location = New Point(3, 141)
        mtbStudentID.Margin = New Padding(3, 2, 3, 2)
        mtbStudentID.Mask = "00000000-L"
        mtbStudentID.Name = "mtbStudentID"
        mtbStudentID.Size = New Size(146, 23)
        mtbStudentID.TabIndex = 21
        ' 
        ' Form1
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        CancelButton = btnClear
        ClientSize = New Size(634, 261)
        Controls.Add(TableLayoutPanel1)
        KeyPreview = True
        MinimumSize = New Size(650, 300)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents suffix As Label
    Friend WithEvents middleName As Label
    Friend WithEvents firstName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents studentNo As Label
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents section As Label
    Friend WithEvents year As Label
    Friend WithEvents program As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents category As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbStudentID As MaskedTextBox
    Friend WithEvents btnRegister As Button

End Class
