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
        lblStudNo = New Label()
        cmbCategory = New ComboBox()
        lblCategory = New Label()
        cmbSection = New ComboBox()
        cmbYear = New ComboBox()
        cmbProgram = New ComboBox()
        lblSection = New Label()
        lblYear = New Label()
        lblProgram = New Label()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        suffix = New Label()
        middleName = New Label()
        lblFirstName = New Label()
        lblLastName = New Label()
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
        Panel1 = New Panel()
        lbResult = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        TableLayoutPanel1.Controls.Add(lblStudNo, 0, 3)
        TableLayoutPanel1.Controls.Add(cmbCategory, 0, 6)
        TableLayoutPanel1.Controls.Add(lblCategory, 0, 5)
        TableLayoutPanel1.Controls.Add(cmbSection, 3, 4)
        TableLayoutPanel1.Controls.Add(cmbYear, 2, 4)
        TableLayoutPanel1.Controls.Add(cmbProgram, 1, 4)
        TableLayoutPanel1.Controls.Add(lblSection, 3, 3)
        TableLayoutPanel1.Controls.Add(lblYear, 2, 3)
        TableLayoutPanel1.Controls.Add(lblProgram, 1, 3)
        TableLayoutPanel1.Controls.Add(txtMiddleName, 2, 2)
        TableLayoutPanel1.Controls.Add(txtFirstName, 1, 2)
        TableLayoutPanel1.Controls.Add(suffix, 3, 1)
        TableLayoutPanel1.Controls.Add(middleName, 2, 1)
        TableLayoutPanel1.Controls.Add(lblFirstName, 1, 1)
        TableLayoutPanel1.Controls.Add(lblLastName, 0, 1)
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
        TableLayoutPanel1.Size = New Size(457, 357)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.BackColor = Color.White
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Poppins", 9F)
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(231, 316)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(108, 38)
        btnClear.TabIndex = 30
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.AutoSize = True
        btnRegister.BackColor = Color.IndianRed
        btnRegister.Dock = DockStyle.Fill
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Poppins", 9F)
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(345, 316)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(109, 38)
        btnRegister.TabIndex = 29
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblStudNo
        ' 
        lblStudNo.AutoSize = True
        lblStudNo.Dock = DockStyle.Left
        lblStudNo.Font = New Font("Poppins", 9.75F)
        lblStudNo.Location = New Point(3, 149)
        lblStudNo.Name = "lblStudNo"
        lblStudNo.Size = New Size(90, 41)
        lblStudNo.TabIndex = 23
        lblStudNo.Text = "*Student No."
        lblStudNo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbCategory
        ' 
        TableLayoutPanel1.SetColumnSpan(cmbCategory, 4)
        cmbCategory.Dock = DockStyle.Fill
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Poppins", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Interskills", "Esports", "Sports", "Others"})
        cmbCategory.Location = New Point(3, 275)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(451, 30)
        cmbCategory.TabIndex = 19
        ' 
        ' lblCategory
        ' 
        lblCategory.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Poppins", 9.75F)
        lblCategory.Location = New Point(3, 249)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(77, 23)
        lblCategory.TabIndex = 18
        lblCategory.Text = "*Category"
        lblCategory.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbSection
        ' 
        cmbSection.Dock = DockStyle.Fill
        cmbSection.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSection.Font = New Font("Poppins", 9F)
        cmbSection.FormattingEnabled = True
        cmbSection.Items.AddRange(New Object() {"A", "B", "C"})
        cmbSection.Location = New Point(345, 193)
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
        cmbYear.Location = New Point(231, 193)
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
        cmbProgram.Location = New Point(117, 193)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(108, 30)
        cmbProgram.TabIndex = 14
        ' 
        ' lblSection
        ' 
        lblSection.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblSection.AutoSize = True
        lblSection.Font = New Font("Poppins", 9.75F)
        lblSection.Location = New Point(345, 167)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(64, 23)
        lblSection.TabIndex = 12
        lblSection.Text = "*Section"
        lblSection.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Dock = DockStyle.Left
        lblYear.Font = New Font("Poppins", 9.75F)
        lblYear.Location = New Point(231, 149)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(46, 41)
        lblYear.TabIndex = 11
        lblYear.Text = "*Year"
        lblYear.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblProgram
        ' 
        lblProgram.AutoSize = True
        lblProgram.Dock = DockStyle.Left
        lblProgram.Font = New Font("Poppins", 9.75F)
        lblProgram.Location = New Point(117, 149)
        lblProgram.Name = "lblProgram"
        lblProgram.Size = New Size(73, 41)
        lblProgram.TabIndex = 10
        lblProgram.Text = "*Program"
        lblProgram.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Dock = DockStyle.Fill
        txtMiddleName.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddleName.Location = New Point(231, 111)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(108, 27)
        txtMiddleName.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Font = New Font("Poppins", 9.75F)
        txtFirstName.Location = New Point(117, 111)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(108, 27)
        txtFirstName.TabIndex = 6
        ' 
        ' suffix
        ' 
        suffix.AutoSize = True
        suffix.Dock = DockStyle.Fill
        suffix.Font = New Font("Poppins", 9.75F)
        suffix.Location = New Point(345, 67)
        suffix.Name = "suffix"
        suffix.Size = New Size(109, 41)
        suffix.TabIndex = 4
        suffix.Text = "Suffix"
        suffix.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' middleName
        ' 
        middleName.AutoSize = True
        middleName.Dock = DockStyle.Fill
        middleName.Font = New Font("Poppins", 9.75F)
        middleName.Location = New Point(231, 67)
        middleName.Name = "middleName"
        middleName.Size = New Size(108, 41)
        middleName.TabIndex = 3
        middleName.Text = "Middle Name"
        middleName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Dock = DockStyle.Fill
        lblFirstName.Font = New Font("Poppins", 9.75F)
        lblFirstName.Location = New Point(117, 67)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(108, 41)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "*First Name"
        lblFirstName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Dock = DockStyle.Fill
        lblLastName.Font = New Font("Poppins", 9.75F)
        lblLastName.Location = New Point(3, 67)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(108, 41)
        lblLastName.TabIndex = 1
        lblLastName.Text = "*Last Name"
        lblLastName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Pixelify Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 67)
        Label1.TabIndex = 0
        Label1.Text = "CSD FAIR REGISTRATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Font = New Font("Poppins", 9.75F)
        txtLastName.Location = New Point(3, 111)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(108, 27)
        txtLastName.TabIndex = 5
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.Dock = DockStyle.Fill
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.Font = New Font("Poppins", 9F)
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "III.", "IV.", "V."})
        cmbSuffix.Location = New Point(345, 111)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(109, 30)
        cmbSuffix.TabIndex = 8
        ' 
        ' mtbStudentID
        ' 
        mtbStudentID.Font = New Font("Poppins", 9.75F)
        mtbStudentID.Location = New Point(3, 192)
        mtbStudentID.Margin = New Padding(3, 2, 3, 2)
        mtbStudentID.Mask = "00000000-L"
        mtbStudentID.Name = "mtbStudentID"
        mtbStudentID.Size = New Size(108, 27)
        mtbStudentID.TabIndex = 21
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        CheckBox1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(CheckBox1, 2)
        CheckBox1.Font = New Font("Poppins", 9.75F)
        CheckBox1.Location = New Point(21, 316)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.RightToLeft = RightToLeft.No
        CheckBox1.Size = New Size(204, 38)
        CheckBox1.TabIndex = 24
        CheckBox1.Text = "Include Special Characters"
        CheckBox1.TextAlign = ContentAlignment.BottomCenter
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
        DataGridView1.Size = New Size(618, 317)
        DataGridView1.TabIndex = 1
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Poppins", 9F)
        btnRemove.Location = New Point(839, 323)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(71, 31)
        btnRemove.TabIndex = 2
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Poppins", 9F)
        btnEdit.Location = New Point(916, 323)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 31)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnReload
        ' 
        btnReload.Font = New Font("Poppins", 9F)
        btnReload.Location = New Point(997, 323)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(83, 31)
        btnReload.TabIndex = 4
        btnReload.Text = "Reload"
        btnReload.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbResult)
        Panel1.Location = New Point(463, 322)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 32)
        Panel1.TabIndex = 21
        ' 
        ' lbResult
        ' 
        lbResult.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lbResult.AutoSize = True
        lbResult.Location = New Point(2, 10)
        lbResult.Name = "lbResult"
        lbResult.Size = New Size(41, 15)
        lbResult.TabIndex = 0
        lbResult.Text = "Label4"
        lbResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(1084, 361)
        Controls.Add(Panel1)
        Controls.Add(btnReload)
        Controls.Add(btnEdit)
        Controls.Add(btnRemove)
        Controls.Add(DataGridView1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MaximizeBox = False
        MaximumSize = New Size(1100, 400)
        MinimumSize = New Size(1100, 400)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents suffix As Label
    Friend WithEvents middleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents lblSection As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbStudentID As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents lblStudNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbResult As Label

End Class
