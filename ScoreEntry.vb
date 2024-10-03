Imports MySql.Data.MySqlClient

Public Class ScoreEntry

    Private Sub ScoreEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Dim myconnection As String = "datasource=localhost;port=3306;username=root;password=;"
        Dim con As MySqlConnection = New MySqlConnection(myconnection)
        Dim selectcommand As MySqlCommand = New MySqlCommand("SELECT name FROM schoolmanagement.registration", con)

        Try
            con.Open()
            Dim reader As MySqlDataReader = selectcommand.ExecuteReader()
            While reader.Read()
                cmbStudents.Items.Add(reader("name").ToString())
            End While
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cmbStudents.SelectedIndex = -1 OrElse txtMath.Text.Length = 0 OrElse txtScience.Text.Length = 0 OrElse txtEnglish.Text.Length = 0 OrElse txtExamScore.Text.Length = 0 Then
            MessageBox.Show("Please select a student and enter all scores.")
            Return
        End If

        Dim studentName As String = cmbStudents.SelectedItem.ToString()
        Dim mathScore As Double = Convert.ToDouble(txtMath.Text)
        Dim scienceScore As Double = Convert.ToDouble(txtScience.Text)
        Dim englishScore As Double = Convert.ToDouble(txtEnglish.Text)
        Dim examScore As Double = Convert.ToDouble(txtExamScore.Text)

        ' Calculate average score
        Dim totalScore As Double = mathScore + scienceScore + englishScore + examScore
        Dim averageScore As Double = totalScore / 4
        Dim grade As String = CalculateGrade(averageScore)

        ' Display the average and grade
        txtAverage.Text = averageScore.ToString("F2")
        txtGrade.Text = grade

        Try
            Dim myconnection As String = "datasource=localhost;port=3306;username=root;password=;"
            Dim con As MySqlConnection = New MySqlConnection(myconnection)
            Dim insertcommand As MySqlCommand = New MySqlCommand("INSERT INTO schoolmanagement.studentscores(student_name, math_score, science_score, english_score, exam_score, total_score, average_score, grade) VALUES(@name, @math, @science, @english, @exam, @total, @average, @grade)", con)

            insertcommand.Parameters.AddWithValue("@name", studentName)
            insertcommand.Parameters.AddWithValue("@math", mathScore)
            insertcommand.Parameters.AddWithValue("@science", scienceScore)
            insertcommand.Parameters.AddWithValue("@english", englishScore)
            insertcommand.Parameters.AddWithValue("@exam", examScore)
            insertcommand.Parameters.AddWithValue("@total", totalScore)
            insertcommand.Parameters.AddWithValue("@average", averageScore)
            insertcommand.Parameters.AddWithValue("@grade", grade)

            con.Open()
            insertcommand.ExecuteNonQuery()
            MessageBox.Show("Scores and grade saved successfully!")
            ' Optionally clear input fields here
            ClearInputFields()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ClearInputFields()
        txtMath.Clear()
        txtScience.Clear()
        txtEnglish.Clear()
        txtExamScore.Clear()
        txtAverage.Clear()
        txtGrade.Clear()
        cmbStudents.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub
End Class
