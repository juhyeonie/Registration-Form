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
        cmbCategory = New ComboBox()
        category = New Label()
        txtStudentNumber = New TextBox()
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
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.6195278F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.4410763F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.915823F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.0235672F))
        TableLayoutPanel1.Controls.Add(btnRegister, 3, 7)
        TableLayoutPanel1.Controls.Add(cmbCategory, 0, 6)
        TableLayoutPanel1.Controls.Add(category, 0, 5)
        TableLayoutPanel1.Controls.Add(txtStudentNumber, 0, 4)
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
        TableLayoutPanel1.Location = New Point(12, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(648, 195)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.IndianRed
        btnRegister.Dock = DockStyle.Fill
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(526, 164)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(119, 28)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        TableLayoutPanel1.SetColumnSpan(cmbCategory, 4)
        cmbCategory.Dock = DockStyle.Fill
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(3, 135)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(642, 23)
        cmbCategory.TabIndex = 19
        ' 
        ' category
        ' 
        category.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(category, 4)
        category.Dock = DockStyle.Top
        category.Location = New Point(3, 117)
        category.Name = "category"
        category.Size = New Size(642, 15)
        category.TabIndex = 18
        category.Text = "*Category"
        category.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtStudentNumber
        ' 
        txtStudentNumber.Dock = DockStyle.Fill
        txtStudentNumber.Location = New Point(3, 91)
        txtStudentNumber.Name = "txtStudentNumber"
        txtStudentNumber.Size = New Size(179, 23)
        txtStudentNumber.TabIndex = 17
        ' 
        ' cmbSection
        ' 
        cmbSection.Dock = DockStyle.Fill
        cmbSection.FormattingEnabled = True
        cmbSection.Location = New Point(526, 91)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(119, 23)
        cmbSection.TabIndex = 16
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.FormattingEnabled = True
        cmbYear.Location = New Point(365, 91)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(155, 23)
        cmbYear.TabIndex = 15
        ' 
        ' cmbProgram
        ' 
        cmbProgram.Dock = DockStyle.Fill
        cmbProgram.FormattingEnabled = True
        cmbProgram.Location = New Point(188, 91)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(171, 23)
        cmbProgram.TabIndex = 14
        ' 
        ' section
        ' 
        section.AutoSize = True
        section.Dock = DockStyle.Left
        section.Location = New Point(526, 73)
        section.Name = "section"
        section.Size = New Size(51, 15)
        section.TabIndex = 12
        section.Text = "*Section"
        section.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' year
        ' 
        year.AutoSize = True
        year.Dock = DockStyle.Left
        year.Location = New Point(365, 73)
        year.Name = "year"
        year.Size = New Size(34, 15)
        year.TabIndex = 11
        year.Text = "*Year"
        year.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' program
        ' 
        program.AutoSize = True
        program.Dock = DockStyle.Left
        program.Location = New Point(188, 73)
        program.Name = "program"
        program.Size = New Size(58, 15)
        program.TabIndex = 10
        program.Text = "*Program"
        program.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' studentNo
        ' 
        studentNo.AutoSize = True
        studentNo.Dock = DockStyle.Left
        studentNo.Location = New Point(3, 73)
        studentNo.Name = "studentNo"
        studentNo.Size = New Size(75, 15)
        studentNo.TabIndex = 9
        studentNo.Text = "*Student No."
        studentNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Location = New Point(365, 47)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(155, 23)
        txtMiddleName.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Location = New Point(188, 47)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(171, 23)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Left
        suffix.Location = New Point(526, 29)
        suffix.Name = "suffix"
        suffix.Size = New Size(37, 15)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Left
        middleName.Location = New Point(365, 29)
        middleName.Name = "middleName"
        middleName.Size = New Size(79, 15)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' firstName
        ' 
        firstName.AutoSize = True
        firstName.Dock = DockStyle.Left
        firstName.Location = New Point(188, 29)
        firstName.Name = "firstName"
        firstName.Size = New Size(69, 15)
        firstName.TabIndex = 2
        firstName.Text = "*First Name"
        firstName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lastName
        ' 
        lastName.AutoSize = True
        lastName.Dock = DockStyle.Left
        lastName.Location = New Point(3, 29)
        lastName.Name = "lastName"
        lastName.Size = New Size(68, 15)
        lastName.TabIndex = 1
        lastName.Text = "*Last Name"
        lastName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Pixelify Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(642, 29)
        Label1.TabIndex = 0
        Label1.Text = "CSD FAIR REGISTRATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Location = New Point(3, 47)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(179, 23)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Location = New Point(526, 47)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(119, 23)
        cmbSuffix.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 216)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents section As Label
    Friend WithEvents year As Label
    Friend WithEvents program As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents category As Label
    Friend WithEvents btnRegister As Button

End Class
