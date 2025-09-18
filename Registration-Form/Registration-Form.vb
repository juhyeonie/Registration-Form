Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    Dim conn As New OleDbConnection(ConnectionString)
    Private AllowSpecialChars As Boolean = False
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbStudentID.Select(0, 0)
        LoadStudentData()
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Function IsValidName(input As String) As Boolean
        If AllowSpecialChars Then
            ' If checkbox is checked, allow ANY characters (still disallow empty string)
            Return input.Trim() <> ""
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
        ' Basic empty field validation
        If txtFirstName.Text.Trim = "" OrElse txtLastName.Text.Trim = "" OrElse mtbStudentID.Text.Trim = "" OrElse cmbProgram.Text.Trim = "" OrElse cmbYear.Text.Trim = "" OrElse cmbSection.Text.Trim = "" Then
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate name fields
        If Not IsValidName(txtFirstName.Text) Then
            MessageBox.Show("First name is not valid based on current validation rules.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return
        End If

        If Not IsValidName(txtLastName.Text) Then
            MessageBox.Show("Last name is not valid based on current validation rules.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return
        End If

        ' Check if StudentID already exists
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim queryCheck = "SELECT COUNT(*) FROM CSD WHERE StudentID = @StudentID"
            Using cmd As New OleDbCommand(queryCheck, conn)
                cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If count > 0 Then
                    Label2.Text = "Student ID already exists."
                    Return
                End If
            End Using
        End Using

        ' Insert new record
        Try
            Using conn As New OleDbConnection(ConnectionString)
                conn.Open()
                Dim queryInsert = "INSERT INTO CSD ([StudentID], [FirstName], [LastName], [MiddleName], [Suffix], [Program], [YearLevel], [Section], [Category]) VALUES (@StudentID, @FirstName, @LastName, @MiddleName, @Suffix, @Program, @YearLevel, @Section, @Category)"

                Using cmd As New OleDbCommand(queryInsert, conn)
                    ' Add parameters in SAME ORDER as query
                    cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Suffix", cmbSuffix.Text)
                    cmd.Parameters.AddWithValue("@Program", cmbProgram.Text)
                    cmd.Parameters.AddWithValue("@YearLevel", cmbYear.Text)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)

                    ' Dim debugSql = queryInsert
                    'For Each p As OleDbParameter In cmd.Parameters
                    'debugSql = debugSql.Replace(p.ParameterName, "'" & p.Value.ToString & "'")
                    'Next
                    'MessageBox.Show(debugSql)


                    Dim row = cmd.ExecuteNonQuery

                    If row > 0 Then
                        Label2.Text = "Registration Completed!"
                    Else
                        Label2.Text = "Registration Failed"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace)
        End Try
        LoadStudentData()
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
        Label2.Text = ""
    End Sub

    Private Sub LoadStudentData()
        Try
            conn.Open()
            Dim sql As String = "SELECT StudentID, " &
                                "(FirstName & ' ' & MiddleName & ' ' & LastName & ' ' & Suffix) AS FullName, " &
                                "Program, YearLevel AS [Year], Section, Category " &
                                "FROM CSD"

            Dim adapter As New OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt

            ' Make columns auto resize and fill available space
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoResizeColumns()

            ' Adjust column widths (remove old FirstName/MiddleName/LastName since now it’s combined)
            DataGridView1.Columns("StudentID").FillWeight = 100
            DataGridView1.Columns("FullName").FillWeight = 200
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
            Dim studentID As String = DataGridView1.SelectedRows(0).Cells("StudentID").Value.ToString()

            Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM CSD WHERE StudentID = ?"
                    Dim cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = studentID
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
        Dim studentID As String = DataGridView1.SelectedRows(0).Cells("StudentID").Value.ToString()

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

                Dim sql = "UPDATE CSD SET [FirstName]=?, [LastName]=?, [MiddleName]=?, [Suffix]=?, [Program]=?, [YearLevel]=?, [Section]=?, [Category]=? WHERE [StudentID]=?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = firstName
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = lastName
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = middleName
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = suffix
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = program
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = yearLevel
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = section
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = category
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = studentID
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
End Class