Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class EditStudentForm
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    Dim conn As New OleDbConnection(ConnectionString)
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
            Dim sql As String = "SELECT * FROM CSD WHERE StudentID = ?"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = studentID
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic empty field validation
        If txtFirstName.Text.Trim() = "" OrElse txtLastName.Text.Trim() = "" OrElse mtbStudentID.Text.Trim() = "" OrElse cmbProgram.Text.Trim() = "" OrElse cmbYear.Text.Trim() = "" OrElse cmbSection.Text.Trim() = "" Then
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

        Try
            conn.Open()
            Dim sql As String = "UPDATE CSD SET [LastName]=?, [FirstName]=?, [MiddleName]=?, [Suffix]=?, [Program]=?, [YearLevel]=?, [Section]=?, [Category]=?, [StudentID]=? WHERE StudentID=?"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtLastName.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtFirstName.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtMiddleName.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = cmbSuffix.Text
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = cmbProgram.Text
                cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbYear.Text)
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = cmbSection.Text
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = cmbCategory.Text
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = mtbStudentID.Text
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = studentID
                cmd.ExecuteNonQuery()
            End Using
            Label2.Text = "Saved!"
            Me.Close() ' Close form after saving
        Catch ex As Exception
            MessageBox.Show("Error saving student data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        AllowSpecialChars = CheckBox1.Checked
    End Sub
End Class