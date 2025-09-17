Imports System.Data.OleDb

Public Class EditStudentForm
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\FormRegistration.accdb"
    Dim conn As New OleDbConnection(ConnectionString)
    Private studentID As String

    ' Constructor to receive the selected student ID
    Public Sub New(selectedID As String)
        InitializeComponent()
        studentID = selectedID
    End Sub

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Or String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("First Name and Last Name cannot be empty.")
            Exit Sub
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
            MessageBox.Show("Record updated successfully.")
            Me.Close() ' Close form after saving
        Catch ex As Exception
            MessageBox.Show("Error saving student data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

End Class