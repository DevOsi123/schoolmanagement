Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub
    Private Sub DisplayForm3Students()
        Try
            Dim myconnection As String = "datasource=localhost;port=3306;username=root;" ' Add your password here if needed
            Using con As MySqlConnection = New MySqlConnection(myconnection)
                Dim query As String = "SELECT name, parent, telephone FROM schoolmanagement.registration WHERE class = 'FORM 3'"
                Dim command As MySqlCommand = New MySqlCommand(query, con)
                con.Open()

                Dim dataTable As New DataTable()
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = dataTable

                If dataTable.Rows.Count = 0 Then
                    MessageBox.Show("No students found for Form 1.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving students: " & ex.Message)
        End Try
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayForm3Students()
    End Sub
End Class