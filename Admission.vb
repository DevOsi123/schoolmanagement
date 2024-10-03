Imports MySql.Data.MySqlClient
Public Class Admission

    Private Function GenerateSecretCode() As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim random As New Random()
        Dim secretCode As New String(Enumerable.Repeat(chars, 8) _
                                  .Select(Function(s) s(random.Next(s.Length))).ToArray())
        Return secretCode
    End Function
    Public Sub save()

        Dim Aa As String
        Aa = MsgBox("Are you sure you want to save", vbYesNo, "Question")
        If Aa = vbYes Then
            If (txt_address.Text.Length > 0 And txt_admitted.Text.Length > 0 And txt_amount.Text.Length > 0 And txt_health_problem.Text.Length > 0 And txt_name.Text.Length > 0 And txt_parent.Text.Length > 0 And txt_phone.Text.Length > 0 And txt_reffered_by.Text.Length > 0 And cmb_sex.Text.Length > 0 And cmb_class.Text.Length > 0 And cmb_condition.Text.Length > 0 And cmb_country.Text.Length > 0 And cmb_district.Text.Length > 0 And cmb_house.Text.Length > 0 And cmb_religion.Text.Length > 0 And cmb_term.Text.Length > 0 And cmb_year.Text.Length > 0) Then

                ' Check if amount starts with '0'
                If txt_amount.Text.StartsWith("0") Then
                    MessageBox.Show("Amount cannot start with 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' Exit the method if the condition is met
                End If

                Try
                    Dim myconnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim con As MySqlConnection = New MySqlConnection(myconnection)

                    ' Generate the secret code
                    Dim secretCode As String = GenerateSecretCode()

                    Dim selectcommand As MySqlCommand = New MySqlCommand("INSERT INTO schoolmanagement.registration(name, date, parent, telephone, sex, address, class, year, term, cond, amount, admitted_by, health_problem, house, religion, country, home_district, reffered_by, secret_code) VALUES(@name, @date, @parent, @telephone, @sex, @address, @class, @year, @term, @cond, @amount, @admitted_by, @health_problem, @house, @religion, @country, @home_district, @reffered_by, @secret_code)", con)

                    ' Add parameters to prevent SQL injection
                    selectcommand.Parameters.AddWithValue("@name", txt_name.Text)
                    selectcommand.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                    selectcommand.Parameters.AddWithValue("@parent", txt_parent.Text)
                    selectcommand.Parameters.AddWithValue("@telephone", txt_phone.Text)
                    selectcommand.Parameters.AddWithValue("@sex", cmb_sex.Text)
                    selectcommand.Parameters.AddWithValue("@address", txt_address.Text)
                    selectcommand.Parameters.AddWithValue("@class", cmb_class.Text)
                    selectcommand.Parameters.AddWithValue("@year", cmb_year.Text)
                    selectcommand.Parameters.AddWithValue("@term", cmb_term.Text)
                    selectcommand.Parameters.AddWithValue("@cond", cmb_condition.Text)
                    selectcommand.Parameters.AddWithValue("@amount", txt_amount.Text)
                    selectcommand.Parameters.AddWithValue("@admitted_by", txt_admitted.Text)
                    selectcommand.Parameters.AddWithValue("@health_problem", txt_health_problem.Text)
                    selectcommand.Parameters.AddWithValue("@house", cmb_house.Text)
                    selectcommand.Parameters.AddWithValue("@religion", cmb_religion.Text)
                    selectcommand.Parameters.AddWithValue("@country", cmb_country.Text)
                    selectcommand.Parameters.AddWithValue("@home_district", cmb_district.Text)
                    selectcommand.Parameters.AddWithValue("@reffered_by", txt_reffered_by.Text)
                    selectcommand.Parameters.AddWithValue("@secret_code", secretCode)

                    Dim myReader As MySqlDataReader
                    con.Open()
                    myReader = selectcommand.ExecuteReader()
                    MessageBox.Show("Data saved. student login code is: " & secretCode)
                    ClearFields()
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Else
                MessageBox.Show("Please fill in the fields")
            End If
        End If
    End Sub

    Private Sub ClearFields()
        cmb_sex.SelectedIndex = -1
        cmb_class.SelectedIndex = -1
        cmb_condition.SelectedIndex = -1
        cmb_country.SelectedIndex = -1
        cmb_district.SelectedIndex = -1
        cmb_house.SelectedIndex = -1
        cmb_religion.SelectedIndex = -1
        cmb_term.SelectedIndex = -1
        cmb_year.SelectedIndex = -1
        txt_name.Clear()
        txt_parent.Clear()
        txt_phone.Clear()
        txt_address.Clear()
        txt_amount.Clear()
        txt_admitted.Clear()
        txt_health_problem.Clear()
        txt_reffered_by.Clear()


    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_parent.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admissions_Data.Show()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        save()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub
End Class