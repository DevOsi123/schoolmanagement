<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        btnLogin = New Button()
        cmboxLoginType = New ComboBox()
        txtPass = New TextBox()
        txtUserID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(cmboxLoginType)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtUserID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(3, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(513, 425)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "LOGIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(432, 25)
        Label4.TabIndex = 7
        Label4.Text = "SCHOOL MANAGEMENT SYSTEM LOGIN"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Red
        btnLogin.Location = New Point(193, 350)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 50)
        btnLogin.TabIndex = 6
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' cmboxLoginType
        ' 
        cmboxLoginType.FormattingEnabled = True
        cmboxLoginType.Items.AddRange(New Object() {"ADMIN", "TEACHER", "STUDENT"})
        cmboxLoginType.Location = New Point(142, 285)
        cmboxLoginType.Name = "cmboxLoginType"
        cmboxLoginType.Size = New Size(273, 33)
        cmboxLoginType.TabIndex = 5
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(142, 191)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(273, 30)
        txtPass.TabIndex = 4
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(142, 104)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(273, 30)
        txtUserID.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 25)
        Label3.TabIndex = 2
        Label3.Text = "USER TYPE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close1
        PictureBox2.Location = New Point(477, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 440)
        ControlBox = False
        Controls.Add(PictureBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SCHOOL MANAGEMENT SYSTEM"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents cmboxLoginType As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
