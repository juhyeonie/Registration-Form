Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    Dim conn As New OleDbConnection(ConnectionString)
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbStudentID.Select(0, 0)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Basic validation
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or mtbStudentID.Text = "" Or cmbProgram.Text = "" Or cmbYear.Text = "" Or cmbSection.Text = "" Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        ' Check if StudentID already exists
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim queryCheck = "SELECT COUNT(*) FROM CSD WHERE StudentID = @StudentID"
            Using cmd As New OleDbCommand(queryCheck, conn)
                cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
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
                    cmd.Parameters.AddWithValue("@StudentID", mtbStudentID.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@Suffix", cmbSuffix.Text)
                    cmd.Parameters.AddWithValue("@Program", cmbProgram.Text)
                    cmd.Parameters.AddWithValue("@YearLevel", cmbYear.Text)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)

                    Dim debugSql As String = queryInsert
                    For Each p As OleDbParameter In cmd.Parameters
                        debugSql = debugSql.Replace(p.ParameterName, "'" & p.Value.ToString() & "'")
                    Next
                    MessageBox.Show(debugSql)


                    Dim row = cmd.ExecuteNonQuery()
                    MessageBox.Show("ExecuteNonQuery result: " & row)

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
End Class