Public Class Main

    Public Class UserSession
        Public Shared UserType As String
        Public Shared LoggedInStudentName As String ' Add this line to store the student's name
    End Class


    '   Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Check the user type and set permissions
    'If UserSession.UserType = "ADMIN" Then
    ' Admin has access to everything, so nothing needs to be hidden
    'ElseIf UserSession.UserType = "TEACHER" Then
    ' Teacher access - hide admin features
    '      STUDENTADMISSIONToolStripMenuItem.Visible = False
    '    OLEVELREPORTCARDToolStripMenuItem.Visible = False
    '    ALEVELREPORTCARDToolStripMenuItem.Visible = False
    'ElseIf UserSession.UserType = "STUDENT" Then
    ' Student access - hide everything except their own account
    '   STUDENTADMISSIONToolStripMenuItem.Visible = False
    '  OLEVELREPORTCARDToolStripMenuItem.Visible = False
    '  ALEVELREPORTCARDToolStripMenuItem.Visible = False
    ' STUDENTSACCOUNTToolStripMenuItem.Visible = True
    'Else
    '   MessageBox.Show("Invalid user type.")
    'Me.Close()
    ' End If
    ' End Sub '

    Private Sub STUDENTADMISSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTADMISSIONToolStripMenuItem.Click
        Admission.Show()
    End Sub







    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub CHECKRESULTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKRESULTToolStripMenuItem.Click
        Me.Hide()
        StudentAccount.Show()
    End Sub

    Private Sub SCOREENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCOREENTRYToolStripMenuItem.Click
        Me.Hide()
        ScoreEntry.Show()
    End Sub



    Private Sub FORM1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM1ToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub FORM2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM2ToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub FORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM3ToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
