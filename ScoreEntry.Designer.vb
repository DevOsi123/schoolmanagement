<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbStudents = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        txtMath = New TextBox()
        btnSubmit = New Button()
        Label4 = New Label()
        btnClose = New Button()
        txtGrade = New TextBox()
        txtScience = New TextBox()
        Label5 = New Label()
        txtEnglish = New TextBox()
        Label6 = New Label()
        txtExamScore = New TextBox()
        Label7 = New Label()
        txtAverage = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbStudents
        ' 
        cmbStudents.FormattingEnabled = True
        cmbStudents.Location = New Point(330, 89)
        cmbStudents.Name = "cmbStudents"
        cmbStudents.Size = New Size(255, 28)
        cmbStudents.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(120, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 1
        Label1.Text = "STUDENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(120, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 25)
        Label2.TabIndex = 2
        Label2.Text = "MATH SCORE "
        ' 
        ' txtMath
        ' 
        txtMath.Location = New Point(330, 164)
        txtMath.Name = "txtMath"
        txtMath.Size = New Size(255, 27)
        txtMath.TabIndex = 4
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Black
        btnSubmit.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(193, 621)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(129, 48)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(120, 502)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 7
        Label4.Text = "GRADE"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Black
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(434, 621)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(129, 48)
        btnClose.TabIndex = 9
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(330, 500)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(255, 27)
        txtGrade.TabIndex = 10
        ' 
        ' txtScience
        ' 
        txtScience.Location = New Point(330, 235)
        txtScience.Name = "txtScience"
        txtScience.Size = New Size(255, 27)
        txtScience.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(117, 234)
        Label5.Name = "Label5"
        Label5.Size = New Size(196, 25)
        Label5.TabIndex = 11
        Label5.Text = "SCIENCE SCORE "
        ' 
        ' txtEnglish
        ' 
        txtEnglish.Location = New Point(330, 307)
        txtEnglish.Name = "txtEnglish"
        txtEnglish.Size = New Size(255, 27)
        txtEnglish.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(120, 306)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 25)
        Label6.TabIndex = 13
        Label6.Text = "ENGLISH SCORE "
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(330, 383)
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(255, 27)
        txtExamScore.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(120, 385)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 25)
        Label7.TabIndex = 15
        Label7.Text = "EXAM SCORE"
        ' 
        ' txtAverage
        ' 
        txtAverage.Location = New Point(330, 441)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(255, 27)
        txtAverage.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(120, 443)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 25)
        Label3.TabIndex = 17
        Label3.Text = "AVERAGE SCORE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(294, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(273, 25)
        Label8.TabIndex = 19
        Label8.Text = "STUDENT SCORE ENTRY"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close1
        PictureBox2.Location = New Point(752, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' ScoreEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(803, 702)
        Controls.Add(PictureBox2)
        Controls.Add(Label8)
        Controls.Add(txtAverage)
        Controls.Add(Label3)
        Controls.Add(txtExamScore)
        Controls.Add(Label7)
        Controls.Add(txtEnglish)
        Controls.Add(Label6)
        Controls.Add(txtScience)
        Controls.Add(Label5)
        Controls.Add(txtGrade)
        Controls.Add(btnClose)
        Controls.Add(Label4)
        Controls.Add(btnSubmit)
        Controls.Add(txtMath)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbStudents)
        FormBorderStyle = FormBorderStyle.None
        Name = "ScoreEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SCORE ENTRY"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbStudents As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMath As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtScience As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
