Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class StudentAccount
    Private Sub StudentAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;password=;"
        Dim con As MySqlConnection = New MySqlConnection(myConnection)
        Dim selectCommand As MySqlCommand
        Dim reader As MySqlDataReader

        Try
            con.Open()

            If Login.UserType = "ADMIN" Or Login.UserType = "TEACHER" Then
                ' Load all students for ADMIN and TEACHER
                selectCommand = New MySqlCommand("SELECT name FROM schoolmanagement.registration", con)
                reader = selectCommand.ExecuteReader()

                While reader.Read()
                    cmbStudents.Items.Add(reader("name").ToString())
                End While
            ElseIf Login.UserType = "STUDENT" Then
                ' Load only the logged-in student for STUDENT
                cmbStudents.Items.Add(Login.LoggedInStudentName)
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudents.SelectedIndexChanged
        If cmbStudents.SelectedIndex <> -1 Then
            LoadStudentScores(cmbStudents.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadStudentScores(studentName As String)
        Dim myconnection As String = "datasource=localhost;port=3306;username=root;password=;"
        Dim con As MySqlConnection = New MySqlConnection(myconnection)
        Dim selectcommand As MySqlCommand = New MySqlCommand("SELECT math_score, science_score, english_score, exam_score FROM schoolmanagement.studentscores WHERE student_name = @name", con)
        selectcommand.Parameters.AddWithValue("@name", studentName)

        Try
            con.Open()
            Dim reader As MySqlDataReader = selectcommand.ExecuteReader()
            If reader.Read() Then
                txtMath.Text = reader("math_score").ToString()
                txtScience.Text = reader("science_score").ToString()
                txtEnglish.Text = reader("english_score").ToString()
                txtExamScore.Text = reader("exam_score").ToString()

                ' Calculate average and grade
                Dim mathScore As Double = Convert.ToDouble(txtMath.Text)
                Dim scienceScore As Double = Convert.ToDouble(txtScience.Text)
                Dim englishScore As Double = Convert.ToDouble(txtEnglish.Text)
                Dim examScore As Double = Convert.ToDouble(txtExamScore.Text)

                Dim totalScore As Double = mathScore + scienceScore + englishScore + examScore
                Dim averageScore As Double = totalScore / 4
                Dim grade As String = CalculateGrade(averageScore)

                'txtAverage.Text = averageScore.ToString("F2")
                txtGrade.Text = grade
            Else
                MessageBox.Show("No scores found for the selected student.")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function CalculateGrade(average As Double) As String
        If average >= 90 Then
            Return "A"
        ElseIf average >= 80 Then
            Return "B"
        ElseIf average >= 70 Then
            Return "C"
        ElseIf average >= 60 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub


End Class
