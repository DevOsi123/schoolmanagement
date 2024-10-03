<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admission
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
        SAVEToolStripMenuItem = New ToolStripMenuItem()
        FILEToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        GroupBox1 = New GroupBox()
        txt_reffered_by = New TextBox()
        Label18 = New Label()
        cmb_district = New ComboBox()
        Label17 = New Label()
        cmb_country = New ComboBox()
        Label16 = New Label()
        cmb_religion = New ComboBox()
        Label15 = New Label()
        cmb_house = New ComboBox()
        Label14 = New Label()
        txt_health_problem = New RichTextBox()
        Label13 = New Label()
        txt_admitted = New TextBox()
        Label12 = New Label()
        txt_amount = New TextBox()
        Label11 = New Label()
        cmb_condition = New ComboBox()
        Label10 = New Label()
        cmb_sex = New ComboBox()
        Label9 = New Label()
        cmb_year = New ComboBox()
        cmb_term = New ComboBox()
        cmb_class = New ComboBox()
        txt_phone = New TextBox()
        txt_address = New TextBox()
        txt_parent = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        txt_name = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txt_id = New TextBox()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SAVEToolStripMenuItem
        ' 
        SAVEToolStripMenuItem.Image = My.Resources.Resources.lock
        SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        SAVEToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SAVEToolStripMenuItem.Size = New Size(224, 26)
        SAVEToolStripMenuItem.Text = "SAVE"
        ' 
        ' FILEToolStripMenuItem
        ' 
        FILEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SAVEToolStripMenuItem})
        FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        FILEToolStripMenuItem.Size = New Size(143, 24)
        FILEToolStripMenuItem.Text = "FILE"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FILEToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(156, 708)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_reffered_by)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(cmb_district)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(cmb_country)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(cmb_religion)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(cmb_house)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(txt_health_problem)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txt_admitted)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(txt_amount)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(cmb_condition)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(cmb_sex)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(cmb_year)
        GroupBox1.Controls.Add(cmb_term)
        GroupBox1.Controls.Add(cmb_class)
        GroupBox1.Controls.Add(txt_phone)
        GroupBox1.Controls.Add(txt_address)
        GroupBox1.Controls.Add(txt_parent)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(12, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1203, 621)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "ADMISSION"
        ' 
        ' txt_reffered_by
        ' 
        txt_reffered_by.Location = New Point(181, 531)
        txt_reffered_by.Name = "txt_reffered_by"
        txt_reffered_by.Size = New Size(897, 30)
        txt_reffered_by.TabIndex = 38
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(6, 531)
        Label18.Name = "Label18"
        Label18.Size = New Size(158, 25)
        Label18.TabIndex = 37
        Label18.Text = "REFERRED BY"
        ' 
        ' cmb_district
        ' 
        cmb_district.FormattingEnabled = True
        cmb_district.Items.AddRange(New Object() {"WA", "BOLGATANGA", "NALERIGU", "DAMANGO", "TAMALE", "SUNYANI", "TECHIMAN", "DAMBAI", "GOASO", "KUMASI", "KOFORIDUA", "HO", "SEFWI WIAWSO", "SEKONDI TAKORADI", "CAPE COAST", "ACCRA", "OTHER"})
        cmb_district.Location = New Point(710, 457)
        cmb_district.Name = "cmb_district"
        cmb_district.Size = New Size(368, 33)
        cmb_district.TabIndex = 36
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(488, 463)
        Label17.Name = "Label17"
        Label17.Size = New Size(112, 25)
        Label17.TabIndex = 35
        Label17.Text = "DISTRICT"
        ' 
        ' cmb_country
        ' 
        cmb_country.FormattingEnabled = True
        cmb_country.Items.AddRange(New Object() {"GHANA", "NIGERIA", "KANYE", "ETHIOPA", " NAMIBIA", "SOUTH AFRICA", "MADAGASCA", "CHAD", "NIGER", "ALGERIA", "MOROCCO", "OTHER"})
        cmb_country.Location = New Point(181, 460)
        cmb_country.Name = "cmb_country"
        cmb_country.Size = New Size(283, 33)
        cmb_country.TabIndex = 34
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(6, 460)
        Label16.Name = "Label16"
        Label16.Size = New Size(117, 25)
        Label16.TabIndex = 33
        Label16.Text = "COUNTRY"
        ' 
        ' cmb_religion
        ' 
        cmb_religion.FormattingEnabled = True
        cmb_religion.Items.AddRange(New Object() {"Christian", "Muslim", "Catholic", "Other"})
        cmb_religion.Location = New Point(710, 385)
        cmb_religion.Name = "cmb_religion"
        cmb_religion.Size = New Size(368, 33)
        cmb_religion.TabIndex = 32
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(488, 388)
        Label15.Name = "Label15"
        Label15.Size = New Size(112, 25)
        Label15.TabIndex = 31
        Label15.Text = "RELIGION"
        ' 
        ' cmb_house
        ' 
        cmb_house.FormattingEnabled = True
        cmb_house.Items.AddRange(New Object() {"SESHIE", "AGORTOR", "MILLS", "COLLINS"})
        cmb_house.Location = New Point(181, 385)
        cmb_house.Name = "cmb_house"
        cmb_house.Size = New Size(283, 33)
        cmb_house.TabIndex = 30
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(6, 393)
        Label14.Name = "Label14"
        Label14.Size = New Size(88, 25)
        Label14.TabIndex = 29
        Label14.Text = "HOUSE"
        ' 
        ' txt_health_problem
        ' 
        txt_health_problem.Location = New Point(710, 328)
        txt_health_problem.Name = "txt_health_problem"
        txt_health_problem.Size = New Size(368, 33)
        txt_health_problem.TabIndex = 28
        txt_health_problem.Text = ""
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(488, 334)
        Label13.Name = "Label13"
        Label13.RightToLeft = RightToLeft.No
        Label13.Size = New Size(206, 25)
        Label13.TabIndex = 27
        Label13.Text = "HEALTH PROBLEM"
        ' 
        ' txt_admitted
        ' 
        txt_admitted.Location = New Point(181, 331)
        txt_admitted.Name = "txt_admitted"
        txt_admitted.Size = New Size(283, 30)
        txt_admitted.TabIndex = 26
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 331)
        Label12.Name = "Label12"
        Label12.Size = New Size(157, 25)
        Label12.TabIndex = 25
        Label12.Text = "ADMITTED BY"
        ' 
        ' txt_amount
        ' 
        txt_amount.Location = New Point(822, 262)
        txt_amount.Name = "txt_amount"
        txt_amount.Size = New Size(348, 30)
        txt_amount.TabIndex = 24
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(710, 267)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 25)
        Label11.TabIndex = 23
        Label11.Text = "AMOUNT"
        ' 
        ' cmb_condition
        ' 
        cmb_condition.FormattingEnabled = True
        cmb_condition.Items.AddRange(New Object() {"DAY STUDENT", "BOARDER"})
        cmb_condition.Location = New Point(488, 267)
        cmb_condition.Name = "cmb_condition"
        cmb_condition.Size = New Size(196, 33)
        cmb_condition.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(349, 270)
        Label10.Name = "Label10"
        Label10.Size = New Size(133, 25)
        Label10.TabIndex = 21
        Label10.Text = "CONDITION"
        ' 
        ' cmb_sex
        ' 
        cmb_sex.FormattingEnabled = True
        cmb_sex.Items.AddRange(New Object() {"Female", "Male"})
        cmb_sex.Location = New Point(80, 267)
        cmb_sex.Name = "cmb_sex"
        cmb_sex.Size = New Size(247, 33)
        cmb_sex.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 267)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 25)
        Label9.TabIndex = 19
        Label9.Text = "SEX" & vbCrLf
        ' 
        ' cmb_year
        ' 
        cmb_year.FormattingEnabled = True
        cmb_year.Items.AddRange(New Object() {"2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034"})
        cmb_year.Location = New Point(822, 194)
        cmb_year.Name = "cmb_year"
        cmb_year.Size = New Size(348, 33)
        cmb_year.TabIndex = 18
        ' 
        ' cmb_term
        ' 
        cmb_term.FormattingEnabled = True
        cmb_term.Items.AddRange(New Object() {"ONE", "TWO", "THREE"})
        cmb_term.Location = New Point(822, 147)
        cmb_term.Name = "cmb_term"
        cmb_term.Size = New Size(348, 33)
        cmb_term.TabIndex = 17
        ' 
        ' cmb_class
        ' 
        cmb_class.FormattingEnabled = True
        cmb_class.Items.AddRange(New Object() {"FORM 1", "FORM 2", "FORM 3"})
        cmb_class.Location = New Point(822, 92)
        cmb_class.Name = "cmb_class"
        cmb_class.Size = New Size(348, 33)
        cmb_class.TabIndex = 16
        ' 
        ' txt_phone
        ' 
        txt_phone.Location = New Point(822, 38)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(348, 30)
        txt_phone.TabIndex = 15
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(203, 192)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(348, 30)
        txt_address.TabIndex = 14
        ' 
        ' txt_parent
        ' 
        txt_parent.Location = New Point(203, 145)
        txt_parent.Name = "txt_parent"
        txt_parent.Size = New Size(348, 30)
        txt_parent.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(203, 88)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(348, 30)
        DateTimePicker1.TabIndex = 12
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(203, 34)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(348, 30)
        txt_name.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(719, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 25)
        Label8.TabIndex = 10
        Label8.Text = "TERM"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(719, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 25)
        Label7.TabIndex = 9
        Label7.Text = "YEAR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(719, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 25)
        Label6.TabIndex = 8
        Label6.Text = "CLASS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(719, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 7
        Label5.Text = "PHONE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label4.Location = New Point(79, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 6
        Label4.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(79, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 3
        Label3.Text = "PARENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.Location = New Point(79, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 2
        Label2.Text = "DATE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(79, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 25)
        Label1.TabIndex = 1
        Label1.Text = "NAME"
        ' 
        ' txt_id
        ' 
        txt_id.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txt_id.Enabled = False
        txt_id.Location = New Point(1083, 42)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(112, 27)
        txt_id.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button2.Location = New Point(941, 42)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 29)
        Button2.TabIndex = 8
        Button2.Text = "VIEW DATA(*)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close1
        PictureBox2.Location = New Point(1176, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Admission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 708)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(txt_id)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Admission"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STUDENTS ADMISSION"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ADMISSIONSBYAGIVENPERSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMISSIONSBYYEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMISSIONSBYCLASSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GENERALADMISIONREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMISSIONSBYTERMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_parent As TextBox
    Friend WithEvents cmb_term As ComboBox
    Friend WithEvents cmb_class As ComboBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents cmb_sex As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_year As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_condition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents txt_health_problem As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_admitted As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmb_house As ComboBox
    Friend WithEvents cmb_country As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmb_religion As ComboBox
    Friend WithEvents txt_reffered_by As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmb_district As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
