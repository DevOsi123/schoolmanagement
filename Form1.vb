Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell content click events if needed
    End Sub

    ' This method will be called when the menu item is clicked
    Private Sub FORM1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DisplayForm1Students()
    End Sub

    Private Sub DisplayForm1Students()
        Try
            Dim myconnection As String = "datasource=localhost;port=3306;username=root;" ' Add your password here if needed
            Using con As MySqlConnection = New MySqlConnection(myconnection)
                Dim query As String = "SELECT name, parent, telephone FROM schoolmanagement.registration WHERE class = 'FORM 1'"
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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayForm1Students()
    End Sub
End Class
