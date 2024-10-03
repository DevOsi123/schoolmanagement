Imports MySql.Data.MySqlClient
Public Class Admissions_Data
    Public Sub fill_data()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;Persist Security Info=False;"
            Dim conDataBase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDataBase As MySqlCommand = New MySqlCommand("select * from schoolmanagement.registration;", conDataBase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDataBase
            Dim dbDataSet As DataTable = New DataTable()
            sda.Fill(dbDataSet)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            sda.Update(dbDataSet)
            conDataBase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Admissions_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_data()
    End Sub
End Class