Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class EditStudentForm
    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    'Dim conn As New OleDbConnection(ConnectionString)
    Dim ConnectionString As String = "server=localhost;port=3307;user id=root;password=;database=formreg"
    Dim conn As New MySqlConnection(ConnectionString)
    Private studentID As String
    Private AllowSpecialChars As Boolean = False

    ' Constructor to receive the selected student ID
    Public Sub New(selectedID As String)
        InitializeComponent()
        studentID = selectedID
    End Sub

    ' Function to check if a string contains only letters
    Private Function IsAlphabetic(input As String) As Boolean
        For Each ch As Char In input
            If Not Char.IsLetter(ch) Then
                Return False
            End If
        Next
        Return True
    End Function


    Private Sub EditStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM CSD WHERE StudentID = @StudentID"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = studentID

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Fill textboxes
                        txtLastName.Text = reader("LastName").ToString()
                        txtFirstName.Text = reader("FirstName").ToString()
                        txtMiddleName.Text = reader("MiddleName").ToString()

                        ' Fill comboboxes
                        cmbSuffix.Text = reader("Suffix").ToString()
                        cmbProgram.Text = reader("Program").ToString()
                        cmbYear.Text = reader("YearLevel").ToString()
                        cmbSection.Text = reader("Section").ToString()
                        cmbCategory.Text = reader("Category").ToString()

                        ' Fill masked textbox
                        mtbStudentID.Text = reader("StudentID").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function IsValidName(input As String) As Boolean
        ' Require at least 2 characters after trimming spaces
        If input.Trim().Length < 2 Then
            Return False
        End If

        If AllowSpecialChars Then
            ' If checkbox is checked, allow any characters (except empty/too short)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic empty field validation
        If txtFirstName.Text.Trim = "" OrElse txtLastName.Text.Trim = "" OrElse
       mtbStudentID.Text.Trim = "" OrElse cmbProgram.Text.Trim = "" OrElse
       cmbYear.Text.Trim = "" OrElse cmbSection.Text.Trim = "" Then

            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure MaskedTextBox is completely filled
        If Not mtbStudentID.MaskCompleted Then
            MessageBox.Show("Please complete the Student ID in the required format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbStudentID.Focus()
            Return
        End If

        ' Validate name fields
        If Not IsValidName(txtFirstName.Text) Then
            MessageBox.Show("Invalid First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return
        End If

        If Not IsValidName(txtLastName.Text) Then
            MessageBox.Show("Invalid Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return
        End If


        ' Middle Name validation (optional, but must be at least 2 characters if provided)
        If txtMiddleName.Text.Trim <> "" Then
            If txtMiddleName.Text.Trim.Length < 2 OrElse Not IsValidName(txtMiddleName.Text) Then
                MessageBox.Show("Invalid Middle Name. Must be at least 2 characters if provided.")
                txtMiddleName.Focus()
                Return
            End If
        End If

        Try
            conn.Open()
            Dim sql As String = "UPDATE CSD SET " &
                    "LastName=@LastName, " &
                    "FirstName=@FirstName, " &
                    "MiddleName=@MiddleName, " &
                    "Suffix=@Suffix, " &
                    "Program=@Program, " &
                    "YearLevel=@YearLevel, " &
                    "Section=@Section, " &
                    "Category=@Category, " &
                    "StudentID=@NewStudentID " &
                    "WHERE StudentID=@OldStudentID"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = txtLastName.Text.Trim()
                cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = txtFirstName.Text.Trim()
                cmd.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim()
                cmd.Parameters.Add("@Suffix", MySqlDbType.VarChar).Value = cmbSuffix.Text
                cmd.Parameters.Add("@Program", MySqlDbType.VarChar).Value = cmbProgram.Text
                cmd.Parameters.Add("@YearLevel", MySqlDbType.Int32).Value = Convert.ToInt32(cmbYear.Text)
                cmd.Parameters.Add("@Section", MySqlDbType.VarChar).Value = cmbSection.Text
                cmd.Parameters.Add("@Category", MySqlDbType.VarChar).Value = cmbCategory.Text
                cmd.Parameters.Add("@NewStudentID", MySqlDbType.VarChar).Value = mtbStudentID.Text  ' updated value
                cmd.Parameters.Add("@OldStudentID", MySqlDbType.VarChar).Value = studentID          ' original value

                cmd.ExecuteNonQuery()
            End Using

            Label2.Text = "Saved!"
            Label2.ForeColor = Color.LimeGreen
            Me.Close() ' Close form after saving
        Catch ex As Exception
            MessageBox.Show("Error saving student data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AllowSpecialChars = CheckBox1.Checked
    End Sub
End Class