Imports MySql.Data.MySqlClient

Public Class Login
    ' Add a public variable to hold the logged-in student name
    Public Shared LoggedInStudentName As String
    ' Add a public variable to hold the user type
    Public Shared UserType As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim query As String = ""

            If cmboxLoginType.Text = "STUDENT" Then
                query = "SELECT * FROM schoolmanagement.registration WHERE name = @username AND secret_code = @password"
            Else
                query = "SELECT * FROM schoolmanagement.login WHERE username = @username AND password = @password AND usertype = @usertype"
            End If

            Dim SelectCommand As MySqlCommand = New MySqlCommand(query, mycon)

            ' Add parameters to prevent SQL injection
            SelectCommand.Parameters.AddWithValue("@username", txtUserID.Text)
            If cmboxLoginType.Text = "STUDENT" Then
                SelectCommand.Parameters.AddWithValue("@password", txtPass.Text)
            Else
                SelectCommand.Parameters.AddWithValue("@password", txtPass.Text)
                SelectCommand.Parameters.AddWithValue("@usertype", cmboxLoginType.Text)
            End If

            Dim myReader As MySqlDataReader
            mycon.Open()

            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If

            If cmboxLoginType.Text = "ADMIN" Then
                UserType = "ADMIN"
                If (count = 1) Then
                    MessageBox.Show("ADMIN ACCESS GRANTED")
                    txtPass.Text = ""
                    txtUserID.Text = ""
                    Main.Show()
                    Me.Visible = False
                ElseIf (count > 1) Then
                    MessageBox.Show("DUPLICATE USER IN THE DATABASE. ACCESS DENIED")
                Else
                    MessageBox.Show("USERNAME AND PASSWORD IS INCORRECT. ACCESS DENIED!")
                End If
            ElseIf cmboxLoginType.Text = "TEACHER" Then
                UserType = "TEACHER"
                If (count = 1) Then
                    MessageBox.Show("TEACHER ACCESS GRANTED")
                    txtPass.Text = ""
                    txtUserID.Text = ""
                    Main.Show()
                    Me.Visible = False
                    Main.STUDENTADMISSIONToolStripMenuItem.Enabled = False
                    Main.STUDENTBYCLASSToolStripMenuItem.Enabled = False
                ElseIf (count > 1) Then
                    MessageBox.Show("DUPLICATE USER IN THE DATABASE. ACCESS DENIED")
                Else
                    MessageBox.Show("USERNAME AND PASSWORD IS INCORRECT. ACCESS DENIED")
                End If
            ElseIf cmboxLoginType.Text = "STUDENT" Then
                UserType = "STUDENT"
                If (count = 1) Then
                    MessageBox.Show("STUDENT ACCESS GRANTED")
                    LoggedInStudentName = txtUserID.Text ' Store the student's name
                    txtPass.Text = ""
                    txtUserID.Text = ""
                    Main.Show()
                    Me.Visible = False
                    Main.STUDENTADMISSIONToolStripMenuItem.Enabled = False
                    Main.SCOREENTRYToolStripMenuItem.Enabled = False
                    Main.STUDENTBYCLASSToolStripMenuItem.Enabled = False
                ElseIf (count > 1) Then
                    MessageBox.Show("DUPLICATE USER IN THE DATABASE. ACCESS DENIED")
                Else
                    MessageBox.Show("NAME AND SECRET CODE IS INCORRECT. ACCESS DENIED")
                End If
            End If

            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
