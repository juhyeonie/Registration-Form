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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TableLayoutPanel1 = New TableLayoutPanel()
        btnClear = New Button()
        btnRegister = New Button()
        Label3 = New Label()
        cmbCategory = New ComboBox()
        category = New Label()
        cmbSection = New ComboBox()
        cmbYear = New ComboBox()
        cmbProgram = New ComboBox()
        section = New Label()
        year = New Label()
        program = New Label()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        suffix = New Label()
        middleName = New Label()
        firstName = New Label()
        lastName = New Label()
        Label1 = New Label()
        txtLastName = New TextBox()
        cmbSuffix = New ComboBox()
        mtbStudentID = New MaskedTextBox()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        btnRemove = New Button()
        btnEdit = New Button()
        btnReload = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        TableLayoutPanel1.Controls.Add(btnClear, 2, 7)
        TableLayoutPanel1.Controls.Add(btnRegister, 3, 7)
        TableLayoutPanel1.Controls.Add(Label3, 0, 3)
        TableLayoutPanel1.Controls.Add(cmbCategory, 0, 6)
        TableLayoutPanel1.Controls.Add(category, 0, 5)
        TableLayoutPanel1.Controls.Add(cmbSection, 3, 4)
        TableLayoutPanel1.Controls.Add(cmbYear, 2, 4)
        TableLayoutPanel1.Controls.Add(cmbProgram, 1, 4)
        TableLayoutPanel1.Controls.Add(section, 3, 3)
        TableLayoutPanel1.Controls.Add(year, 2, 3)
        TableLayoutPanel1.Controls.Add(program, 1, 3)
        TableLayoutPanel1.Controls.Add(txtMiddleName, 2, 2)
        TableLayoutPanel1.Controls.Add(txtFirstName, 1, 2)
        TableLayoutPanel1.Controls.Add(suffix, 3, 1)
        TableLayoutPanel1.Controls.Add(middleName, 2, 1)
        TableLayoutPanel1.Controls.Add(firstName, 1, 1)
        TableLayoutPanel1.Controls.Add(lastName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(txtLastName, 0, 2)
        TableLayoutPanel1.Controls.Add(cmbSuffix, 3, 2)
        TableLayoutPanel1.Controls.Add(mtbStudentID, 0, 4)
        TableLayoutPanel1.Controls.Add(CheckBox1, 0, 7)
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
        TableLayoutPanel1.Size = New Size(457, 267)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Poppins", 9F)
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(231, 233)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(108, 31)
        btnClear.TabIndex = 30
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.IndianRed
        btnRegister.Dock = DockStyle.Fill
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Poppins", 9F)
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(345, 233)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(109, 31)
        btnRegister.TabIndex = 29
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Left
        Label3.Font = New Font("Poppins", 9.75F)
        Label3.Location = New Point(3, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 30)
        Label3.TabIndex = 23
        Label3.Text = "*Student No."
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbCategory
        ' 
        TableLayoutPanel1.SetColumnSpan(cmbCategory, 4)
        cmbCategory.Dock = DockStyle.Fill
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Poppins", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Interskills", "Esports", "Sports", "Others"})
        cmbCategory.Location = New Point(3, 203)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(451, 30)
        cmbCategory.TabIndex = 19
        ' 
        ' category
        ' 
        category.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        category.AutoSize = True
        category.Font = New Font("Poppins", 9.75F)
        category.Location = New Point(3, 177)
        category.Name = "category"
        category.Size = New Size(77, 23)
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
        cmbSection.Location = New Point(345, 143)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(109, 30)
        cmbSection.TabIndex = 16
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.Font = New Font("Poppins", 9F)
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbYear.Location = New Point(231, 143)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(108, 30)
        cmbYear.TabIndex = 15
        ' 
        ' cmbProgram
        ' 
        cmbProgram.Dock = DockStyle.Fill
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProgram.Font = New Font("Poppins", 9F)
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"BSCS", "BSIS", "BSEMC", "BSIT"})
        cmbProgram.Location = New Point(117, 143)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(108, 30)
        cmbProgram.TabIndex = 14
        ' 
        ' section
        ' 
        section.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        section.AutoSize = True
        section.Font = New Font("Poppins", 9.75F)
        section.Location = New Point(345, 117)
        section.Name = "section"
        section.Size = New Size(64, 23)
        section.TabIndex = 12
        section.Text = "*Section"
        section.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' year
        ' 
        year.AutoSize = True
        year.Dock = DockStyle.Left
        year.Font = New Font("Poppins", 9.75F)
        year.Location = New Point(231, 110)
        year.Name = "year"
        year.Size = New Size(46, 30)
        year.TabIndex = 11
        year.Text = "*Year"
        year.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' program
        ' 
        program.AutoSize = True
        program.Dock = DockStyle.Left
        program.Font = New Font("Poppins", 9.75F)
        program.Location = New Point(117, 110)
        program.Name = "program"
        program.Size = New Size(73, 30)
        program.TabIndex = 10
        program.Text = "*Program"
        program.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Font = New Font("Poppins", 9F)
        txtMiddleName.Location = New Point(231, 83)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(108, 25)
        txtMiddleName.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Font = New Font("Poppins", 9F)
        txtFirstName.Location = New Point(117, 83)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(108, 25)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Fill
        suffix.Font = New Font("Poppins", 9.75F)
        suffix.Location = New Point(345, 50)
        suffix.Name = "suffix"
        suffix.Size = New Size(109, 30)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Fill
        middleName.Font = New Font("Poppins", 9.75F)
        middleName.Location = New Point(231, 50)
        middleName.Name = "middleName"
        middleName.Size = New Size(108, 30)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' firstName
        ' 
        firstName.AutoSize = True
        firstName.Dock = DockStyle.Fill
        firstName.Font = New Font("Poppins", 9.75F)
        firstName.Location = New Point(117, 50)
        firstName.Name = "firstName"
        firstName.Size = New Size(108, 30)
        firstName.TabIndex = 2
        firstName.Text = "*First Name"
        firstName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lastName
        ' 
        lastName.AutoSize = True
        lastName.Dock = DockStyle.Fill
        lastName.Font = New Font("Poppins", 9.75F)
        lastName.Location = New Point(3, 50)
        lastName.Name = "lastName"
        lastName.Size = New Size(108, 30)
        lastName.TabIndex = 1
        lastName.Text = "*Last Name"
        lastName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Pixelify Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 50)
        Label1.TabIndex = 0
        Label1.Text = "CSD FAIR REGISTRATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Font = New Font("Poppins", 9F)
        txtLastName.Location = New Point(3, 83)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(108, 25)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.Font = New Font("Poppins", 9F)
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "III.", "IV.", "V."})
        cmbSuffix.Location = New Point(345, 83)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(109, 30)
        cmbSuffix.TabIndex = 8
        ' 
        ' mtbStudentID
        ' 
        mtbStudentID.Font = New Font("Poppins", 9F)
        mtbStudentID.Location = New Point(3, 142)
        mtbStudentID.Margin = New Padding(3, 2, 3, 2)
        mtbStudentID.Mask = "00000000-L"
        mtbStudentID.Name = "mtbStudentID"
        mtbStudentID.Size = New Size(108, 25)
        mtbStudentID.TabIndex = 21
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        CheckBox1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(CheckBox1, 2)
        CheckBox1.Font = New Font("Poppins", 9.75F)
        CheckBox1.Location = New Point(3, 233)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(204, 31)
        CheckBox1.TabIndex = 24
        CheckBox1.Text = "Include Special Characters"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(670, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 20
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ScrollBar
        DataGridView1.Location = New Point(463, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(618, 229)
        DataGridView1.TabIndex = 1
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Poppins", 9F)
        btnRemove.Location = New Point(840, 236)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(71, 31)
        btnRemove.TabIndex = 2
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Poppins", 9F)
        btnEdit.Location = New Point(917, 236)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 31)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnReload
        ' 
        btnReload.Font = New Font("Poppins", 9F)
        btnReload.Location = New Point(998, 236)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(83, 31)
        btnReload.TabIndex = 4
        btnReload.Text = "Reload"
        btnReload.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(1084, 270)
        Controls.Add(btnReload)
        Controls.Add(btnEdit)
        Controls.Add(btnRemove)
        Controls.Add(DataGridView1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents suffix As Label
    Friend WithEvents middleName As Label
    Friend WithEvents firstName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents section As Label
    Friend WithEvents year As Label
    Friend WithEvents program As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents category As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbStudentID As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lastName As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button

End Class
