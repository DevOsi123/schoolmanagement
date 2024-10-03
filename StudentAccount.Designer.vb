<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAccount
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
        txtExamScore = New TextBox()
        Label7 = New Label()
        txtEnglish = New TextBox()
        Label6 = New Label()
        txtScience = New TextBox()
        Label5 = New Label()
        txtGrade = New TextBox()
        Label4 = New Label()
        btnBack = New Button()
        txtMath = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        cmbStudents = New ComboBox()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Enabled = False
        txtExamScore.Location = New Point(292, 378)
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(255, 27)
        txtExamScore.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(82, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 25)
        Label7.TabIndex = 31
        Label7.Text = "EXAM SCORE"
        ' 
        ' txtEnglish
        ' 
        txtEnglish.Enabled = False
        txtEnglish.Location = New Point(292, 302)
        txtEnglish.Name = "txtEnglish"
        txtEnglish.Size = New Size(255, 27)
        txtEnglish.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(82, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 25)
        Label6.TabIndex = 29
        Label6.Text = "ENGLISH SCORE "
        ' 
        ' txtScience
        ' 
        txtScience.Enabled = False
        txtScience.Location = New Point(292, 230)
        txtScience.Name = "txtScience"
        txtScience.Size = New Size(255, 27)
        txtScience.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(79, 229)
        Label5.Name = "Label5"
        Label5.Size = New Size(196, 25)
        Label5.TabIndex = 27
        Label5.Text = "SCIENCE SCORE "
        ' 
        ' txtGrade
        ' 
        txtGrade.Enabled = False
        txtGrade.Location = New Point(290, 464)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(255, 27)
        txtGrade.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(80, 466)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 24
        Label4.Text = "GRADE"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Black
        btnBack.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(292, 565)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(129, 48)
        btnBack.TabIndex = 23
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' txtMath
        ' 
        txtMath.Enabled = False
        txtMath.Location = New Point(292, 159)
        txtMath.Name = "txtMath"
        txtMath.Size = New Size(255, 27)
        txtMath.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(82, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 25)
        Label2.TabIndex = 21
        Label2.Text = "MATH SCORE "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(82, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 20
        Label1.Text = "STUDENT"
        ' 
        ' cmbStudents
        ' 
        cmbStudents.FormattingEnabled = True
        cmbStudents.Location = New Point(292, 84)
        cmbStudents.Name = "cmbStudents"
        cmbStudents.Size = New Size(255, 28)
        cmbStudents.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(239, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(202, 25)
        Label8.TabIndex = 35
        Label8.Text = "STUDENT SCORE "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close1
        PictureBox2.Location = New Point(669, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' StudentAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(720, 687)
        Controls.Add(PictureBox2)
        Controls.Add(Label8)
        Controls.Add(txtExamScore)
        Controls.Add(Label7)
        Controls.Add(txtEnglish)
        Controls.Add(Label6)
        Controls.Add(txtScience)
        Controls.Add(Label5)
        Controls.Add(txtGrade)
        Controls.Add(Label4)
        Controls.Add(btnBack)
        Controls.Add(txtMath)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbStudents)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STUDENT ACCOUNT"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtScience As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStudents As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
