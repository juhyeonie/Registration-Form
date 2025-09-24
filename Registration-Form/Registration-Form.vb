'Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form1
    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    Dim ConnectionString As String = "server=localhost;port=3307;user id=root;password=;database=formreg"
    'Dim conn As New MySQLConnection(ConnectionString)
    Dim conn As New MySqlConnection(ConnectionString)
    Private AllowSpecialChars As Boolean = False
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbStudentID.Select(0, 0)
        LoadStudentData()
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        lbResult.Text = ""
        btnClear.Enabled = False
        Me.ActiveControl = Nothing
    End Sub

    Private Function IsValidName(input As String) As Boolean
        If input.Trim().Length < 2 Then
            Return False
        End If

        If AllowSpecialChars Then
            Return True
        Else
            ' Default: only letters, spaces, hyphens, and apostrophes
            For Each ch As Char In input
                If Not (Char.IsLetter(ch) Or ch = " "c Or ch = "-"c Or ch = "'"c) Then
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lbResult.ForeColor = Color.Gray
        ' Basic empty field validation
        If txtFirstName.Text.Trim = "" OrElse txtLastName.Text.Trim = "" OrElse
       mtbStudentID.Text.Trim = "" OrElse cmbProgram.Text.Trim = "" OrElse
       cmbYear.Text.Trim = "" OrElse cmbSection.Text.Trim = "" Then
            'lbResult.Text = "Please fill in all the required fields."
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblFirstName.ForeColor = If(txtFirstName.Text.Trim = "", Color.Red, Color.Black)
            lblLastName.ForeColor = If(txtLastName.Text.Trim = "", Color.Red, Color.Black)
            If String.IsNullOrWhiteSpace(mtbStudentID.Text.Trim()) OrElse Not mtbStudentID.MaskCompleted Then
                lblStudNo.ForeColor = Color.Red
            Else
                lblStudNo.ForeColor = Color.Black
            End If
            lblProgram.ForeColor = If(cmbProgram.Text.Trim = "", Color.Red, Color.Black)
            lblYear.ForeColor = If(cmbYear.Text.Trim = "", Color.Red, Color.Black)
            lblSection.ForeColor = If(cmbSection.Text.Trim = "", Color.Red, Color.Black)
            lblCategory.ForeColor = If(cmbCategory.Text.Trim = "", Color.Red, Color.Black)
            Return
        End If

        ' Ensure MaskedTextBox is completely filled
        If Not mtbStudentID.MaskCompleted Then
            'lbResult.Text = "Please complete the Student ID in the required format."
            MessageBox.Show("Please complete the Student ID in the required format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbStudentID.Focus()
            Return
        End If

        ' Name field validation
        If Not IsValidName(txtLastName.Text) Then
            'lbResult.Text = "Invalid Last Name."
            MessageBox.Show("Last name must be at least 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return
        End If

        If Not IsValidName(txtFirstName.Text) Then
            'lbResult.Text = "Invalid First Name."
            MessageBox.Show("First name must be at least 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return
        End If

        ' Middle Name validation (optional, but must be at least 2 characters if provided)
        If txtMiddleName.Text.Trim <> "" Then
            If txtMiddleName.Text.Trim.Length < 2 OrElse Not IsValidName(txtMiddleName.Text) Then
                MessageBox.Show("Invalid Middle Name. Must be at least 2 characters if provided.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'lbResult.Text = "Invalid Middle Name. Must be at least 2 characters if provided."
                txtMiddleName.Focus()
                Return
            End If
        End If

        ' Check if StudentID already exists
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim queryCheck = "SELECT COUNT(*) FROM CSD WHERE StudentID = @StudentID"
            Using cmd As New MySqlCommand(queryCheck, conn)
                cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If count > 0 Then
                    MessageBox.Show("Student ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'lbResult.Text = "Student ID already exists."
                    'lbResult.ForeColor = Color.Gray
                    Return
                End If
            End Using
        End Using

        ' New record
        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                Dim queryInsert = "INSERT INTO CSD (StudentID, FirstName, LastName, MiddleName, Suffix, Program, YearLevel, Section, Category) " &
                                  "VALUES (@StudentID, @FirstName, @LastName, @MiddleName, @Suffix, @Program, @YearLevel, @Section, @Category)"

                Using cmd As New MySqlCommand(queryInsert, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.ToUpper())

                    ' Handle optional MiddleName (insert empty string if none)
                    Dim middleNameValue As String = txtMiddleName.Text.Trim()
                    If middleNameValue.Length > 1 Then
                        cmd.Parameters.AddWithValue("@MiddleName", middleNameValue.ToUpper())
                    Else
                        cmd.Parameters.AddWithValue("@MiddleName", "")
                    End If


                    cmd.Parameters.AddWithValue("@Suffix", cmbSuffix.Text)
                    cmd.Parameters.AddWithValue("@Program", cmbProgram.Text)
                    cmd.Parameters.AddWithValue("@YearLevel", cmbYear.Text)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)

                    Dim row = cmd.ExecuteNonQuery()

                    If row > 0 Then
                        MessageBox.Show("Registration Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'lbResult.Text = "Registration Completed!"
                        'lbResult.ForeColor = Color.ForestGreen
                    Else
                        MessageBox.Show("Registration Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'lbResult.Text = "Registration Failed"
                        'lbResult.ForeColor = Color.IndianRed
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace)
        End Try
        LoadStudentData()
        lblStudNo.ForeColor = Color.Black
        lblFirstName.ForeColor = Color.Black
        lblLastName.ForeColor = Color.Black
        lblProgram.ForeColor = Color.Black
        lblYear.ForeColor = Color.Black
        lblSection.ForeColor = Color.Black
        lblCategory.ForeColor = Color.Black

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        mtbStudentID.Text = ""
        cmbProgram.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbSuffix.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        mtbStudentID.Text = ""
        cmbProgram.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbSuffix.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        lbResult.Text = "Cleared"
    End Sub

    Private Sub LoadStudentData()
        Try
            conn.Open()
            Dim sql As String = "SELECT StudentID AS `Student ID`, " &
                    "CONCAT(FirstName, ' ', MiddleName, ' ', LastName, ' ', Suffix) AS `Full Name`, " &
                    "Program, YearLevel AS `Year`, Section, Category " &
                    "FROM CSD"


            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt

            ' Make columns auto resize and fill available space
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoResizeColumns()

            ' Adjust column widths
            DataGridView1.Columns("Student ID").FillWeight = 90
            DataGridView1.Columns("Full Name").FillWeight = 220
            DataGridView1.Columns("Program").FillWeight = 80
            DataGridView1.Columns("Year").FillWeight = 40
            DataGridView1.Columns("Section").FillWeight = 60
            DataGridView1.Columns("Category").FillWeight = 80


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' Reload Button
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        LoadStudentData()
    End Sub

    '  Remove Button
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim studentID As String = DataGridView1.SelectedRows(0).Cells("Student ID").Value.ToString()

            Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM CSD WHERE StudentID = ?"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.Add("?", MySqlDbType.VarChar).Value = studentID
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully.")

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
        LoadStudentData() ' Refresh grid
    End Sub

    ' Edit Button
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Make sure a row is selected
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to edit.")
            Exit Sub
        End If

        ' Get the StudentID of the selected row
        Dim studentID As String = DataGridView1.SelectedRows(0).Cells("Student ID").Value.ToString()

        ' Open EditStudentForm and pass the StudentID
        Dim editForm As New EditStudentForm(studentID)
        editForm.ShowDialog() ' Opens as modal form

        ' Refresh the grid after editing
        LoadStudentData()
    End Sub




    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            conn.Open()

            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Skip the new row placeholder
                If row.IsNewRow Then Continue For

                Dim studentID = row.Cells("StudentID").Value.ToString
                Dim firstName = row.Cells("FirstName").Value.ToString
                Dim lastName = row.Cells("LastName").Value.ToString
                Dim middleName = row.Cells("MiddleName").Value.ToString
                Dim suffix = row.Cells("Suffix").Value.ToString
                Dim program = row.Cells("Program").Value.ToString
                Dim yearLevel = row.Cells("Year").Value.ToString
                Dim section = row.Cells("Section").Value.ToString
                Dim category = row.Cells("Category").Value.ToString

                ' Optional: Skip rows with empty critical fields
                If String.IsNullOrWhiteSpace(firstName) Or String.IsNullOrWhiteSpace(lastName) Then
                    Continue For
                End If

                Dim sql As String = "UPDATE CSD SET " &
                    "FirstName=@FirstName, " &
                    "LastName=@LastName, " &
                    "MiddleName=@MiddleName, " &
                    "Suffix=@Suffix, " &
                    "Program=@Program, " &
                    "YearLevel=@YearLevel, " &
                    "Section=@Section, " &
                    "Category=@Category " &
                    "WHERE StudentID=@StudentID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = firstName
                    cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = lastName
                    cmd.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = middleName
                    cmd.Parameters.Add("@Suffix", MySqlDbType.VarChar).Value = suffix
                    cmd.Parameters.Add("@Program", MySqlDbType.VarChar).Value = program
                    cmd.Parameters.Add("@YearLevel", MySqlDbType.VarChar).Value = yearLevel
                    cmd.Parameters.Add("@Section", MySqlDbType.VarChar).Value = section
                    cmd.Parameters.Add("@Category", MySqlDbType.VarChar).Value = category
                    cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = studentID
                    cmd.ExecuteNonQuery()
                End Using

            Next

            MessageBox.Show("All records updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        ' Exit edit mode
        DataGridView1.ReadOnly = True

        LoadStudentData() ' Refresh grid
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AllowSpecialChars = CheckBox1.Checked
    End Sub

    ' Call this whenever a field changes
    Private Sub CheckIfFieldsHaveInput()
        ' Check if ANY field has input
        If txtFirstName.Text.Trim <> "" OrElse
       txtLastName.Text.Trim <> "" OrElse
       txtMiddleName.Text.Trim <> "" OrElse
       mtbStudentID.Text.Trim <> "" OrElse
       cmbProgram.SelectedIndex <> -1 OrElse
       cmbYear.SelectedIndex <> -1 OrElse
       cmbSection.SelectedIndex <> -1 OrElse
       cmbCategory.SelectedIndex <> -1 OrElse
       cmbSuffix.SelectedIndex <> -1 Then

            btnClear.Enabled = True
        Else
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged,
                                                                              txtLastName.TextChanged,
                                                                              txtMiddleName.TextChanged,
                                                                              mtbStudentID.TextChanged
        CheckIfFieldsHaveInput()
    End Sub

    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged,
                                                                                cmbYear.SelectedIndexChanged,
                                                                                cmbSection.SelectedIndexChanged,
                                                                                cmbCategory.SelectedIndexChanged,
                                                                                cmbSuffix.SelectedIndexChanged
        CheckIfFieldsHaveInput()
    End Sub



End Class