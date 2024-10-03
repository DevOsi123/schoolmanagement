Imports System.Diagnostics.Eventing.Reader

Public Class FmMain
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 1

        If ProgressBar1.Value Mod 5 = 0 Then
            If ProgressBar1.Value < 15 Then
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Reading program files......."
            ElseIf ProgressBar1.Value < 30 Then
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Turning on program......."
            ElseIf ProgressBar1.Value < 50 Then
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Turning on programs......."
            ElseIf ProgressBar1.Value < 70 Then
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Starting Database Connection......."
            ElseIf ProgressBar1.Value < 90 Then
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Loading Database Files......."
            Else
                Label1.Text = ProgressBar1.Value.ToString() & "%" & " " & "Done Loading Program Files......."
            End If
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub FmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Timer1.Start()
    End Sub
End Class