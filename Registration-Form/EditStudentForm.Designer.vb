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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStudentForm))
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
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
        CheckBox1 = New CheckBox()
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
        TableLayoutPanel1.Controls.Add(btnSave, 3, 7)
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
        TableLayoutPanel1.Controls.Add(Label2, 2, 7)
        TableLayoutPanel1.Controls.Add(mtbStudentID, 0, 4)
        TableLayoutPanel1.Controls.Add(CheckBox1, 0, 7)
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
        TableLayoutPanel1.Size = New Size(444, 291)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DarkSeaGreen
        btnSave.Dock = DockStyle.Fill
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Poppins", 9F)
        btnSave.ForeColor = SystemColors.ActiveCaptionText
        btnSave.Location = New Point(336, 256)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 32)
        btnSave.TabIndex = 22
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        TableLayoutPanel1.SetColumnSpan(cmbCategory, 4)
        cmbCategory.Dock = DockStyle.Fill
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Poppins", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Interskills", "Esports", "Sports", "Others"})
        cmbCategory.Location = New Point(3, 223)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(438, 30)
        cmbCategory.TabIndex = 19
        ' 
        ' category
        ' 
        category.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        category.AutoSize = True
        category.Font = New Font("Poppins", 9F)
        category.Location = New Point(3, 198)
        category.Name = "category"
        category.Size = New Size(71, 22)
        category.TabIndex = 18
        category.Text = "*Category"
        category.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbSection
        ' 
        cmbSection.Dock = DockStyle.Fill
        cmbSection.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSection.Font = New Font("Poppins", 9F)
        cmbSection.FormattingEnabled = True
        cmbSection.Items.AddRange(New Object() {"A", "B", "C"})
        cmbSection.Location = New Point(336, 157)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(105, 30)
        cmbSection.TabIndex = 16
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.Font = New Font("Poppins", 9F)
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbYear.Location = New Point(225, 157)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(105, 30)
        cmbYear.TabIndex = 15
        ' 
        ' cmbProgram
        ' 
        cmbProgram.Dock = DockStyle.Fill
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProgram.Font = New Font("Poppins", 9F)
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"BSCS", "BSIS", "BSEMC", "BSIT"})
        cmbProgram.Location = New Point(114, 157)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(105, 30)
        cmbProgram.TabIndex = 14
        ' 
        ' section
        ' 
        section.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        section.AutoSize = True
        section.Font = New Font("Poppins", 9F)
        section.Location = New Point(336, 132)
        section.Name = "section"
        section.Size = New Size(60, 22)
        section.TabIndex = 12
        section.Text = "*Section"
        section.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' year
        ' 
        year.AutoSize = True
        year.Dock = DockStyle.Left
        year.Font = New Font("Poppins", 9F)
        year.Location = New Point(225, 121)
        year.Name = "year"
        year.Size = New Size(42, 33)
        year.TabIndex = 11
        year.Text = "*Year"
        year.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' program
        ' 
        program.AutoSize = True
        program.Dock = DockStyle.Left
        program.Font = New Font("Poppins", 9F)
        program.Location = New Point(114, 121)
        program.Name = "program"
        program.Size = New Size(67, 33)
        program.TabIndex = 10
        program.Text = "*Program"
        program.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' studentNo
        ' 
        studentNo.AutoSize = True
        studentNo.Dock = DockStyle.Left
        studentNo.Font = New Font("Poppins", 9F)
        studentNo.Location = New Point(3, 121)
        studentNo.Name = "studentNo"
        studentNo.Size = New Size(84, 33)
        studentNo.TabIndex = 9
        studentNo.Text = "*Student No."
        studentNo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Font = New Font("Poppins", 9.75F)
        txtMiddleName.Location = New Point(225, 91)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(105, 27)
        txtMiddleName.TabIndex = 7
        txtMiddleName.TabStop = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Font = New Font("Poppins", 9.75F)
        txtFirstName.Location = New Point(114, 91)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(105, 27)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Left
        suffix.Font = New Font("Poppins", 9F)
        suffix.Location = New Point(336, 55)
        suffix.Name = "suffix"
        suffix.Size = New Size(42, 33)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Left
        middleName.Font = New Font("Poppins", 9F)
        middleName.Location = New Point(225, 55)
        middleName.Name = "middleName"
        middleName.Size = New Size(87, 33)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' firstName
        ' 
        firstName.AutoSize = True
        firstName.Dock = DockStyle.Left
        firstName.Font = New Font("Poppins", 9F)
        firstName.Location = New Point(114, 55)
        firstName.Name = "firstName"
        firstName.Size = New Size(77, 33)
        firstName.TabIndex = 2
        firstName.Text = "*First Name"
        firstName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lastName
        ' 
        lastName.AutoSize = True
        lastName.Dock = DockStyle.Left
        lastName.Font = New Font("Poppins", 9F)
        lastName.Location = New Point(3, 55)
        lastName.Name = "lastName"
        lastName.Size = New Size(77, 33)
        lastName.TabIndex = 1
        lastName.Text = "*Last Name"
        lastName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Pixelify Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(438, 55)
        Label1.TabIndex = 0
        Label1.Text = "EDIT FORM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Font = New Font("Poppins", 9.75F)
        txtLastName.Location = New Point(3, 91)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(105, 27)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.Font = New Font("Poppins", 9.75F)
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "III.", "IV.", "V."})
        cmbSuffix.Location = New Point(336, 91)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(105, 31)
        cmbSuffix.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(225, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 38)
        Label2.TabIndex = 20
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mtbStudentID
        ' 
        mtbStudentID.Font = New Font("Poppins", 9.75F)
        mtbStudentID.Location = New Point(3, 156)
        mtbStudentID.Margin = New Padding(3, 2, 3, 2)
        mtbStudentID.Mask = "00000000-L"
        mtbStudentID.Name = "mtbStudentID"
        mtbStudentID.Size = New Size(105, 27)
        mtbStudentID.TabIndex = 21
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        CheckBox1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(CheckBox1, 2)
        CheckBox1.Font = New Font("Poppins", 9F)
        CheckBox1.Location = New Point(32, 256)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(187, 32)
        CheckBox1.TabIndex = 25
        CheckBox1.Text = "Include Special Characters"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' EditStudentForm
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(444, 291)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        Name = "EditStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSave As Button
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
    Friend WithEvents CheckBox1 As CheckBox
End Class
