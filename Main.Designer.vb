<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FILEToolStripMenuItem = New ToolStripMenuItem()
        STUDENTBYCLASSToolStripMenuItem = New ToolStripMenuItem()
        FORM1ToolStripMenuItem = New ToolStripMenuItem()
        FORM2ToolStripMenuItem = New ToolStripMenuItem()
        FORM3ToolStripMenuItem = New ToolStripMenuItem()
        CHECKRESULTToolStripMenuItem = New ToolStripMenuItem()
        SCOREENTRYToolStripMenuItem = New ToolStripMenuItem()
        STUDENTADMISSIONToolStripMenuItem = New ToolStripMenuItem()
        LOGOUTToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(12, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(647, 441)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "MAIN MENU"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.school
        PictureBox1.Location = New Point(6, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(635, 373)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close1
        PictureBox2.Location = New Point(630, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FILEToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(156, 497)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FILEToolStripMenuItem
        ' 
        FILEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {STUDENTBYCLASSToolStripMenuItem, CHECKRESULTToolStripMenuItem, SCOREENTRYToolStripMenuItem, STUDENTADMISSIONToolStripMenuItem, LOGOUTToolStripMenuItem})
        FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        FILEToolStripMenuItem.Size = New Size(143, 24)
        FILEToolStripMenuItem.Text = "FILE"
        ' 
        ' STUDENTBYCLASSToolStripMenuItem
        ' 
        STUDENTBYCLASSToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FORM1ToolStripMenuItem, FORM2ToolStripMenuItem, FORM3ToolStripMenuItem})
        STUDENTBYCLASSToolStripMenuItem.ForeColor = Color.Blue
        STUDENTBYCLASSToolStripMenuItem.Name = "STUDENTBYCLASSToolStripMenuItem"
        STUDENTBYCLASSToolStripMenuItem.Size = New Size(292, 26)
        STUDENTBYCLASSToolStripMenuItem.Text = "STUDENT BY CLASS"
        ' 
        ' FORM1ToolStripMenuItem
        ' 
        FORM1ToolStripMenuItem.ForeColor = Color.Blue
        FORM1ToolStripMenuItem.Name = "FORM1ToolStripMenuItem"
        FORM1ToolStripMenuItem.Size = New Size(224, 26)
        FORM1ToolStripMenuItem.Text = "FORM 1"
        ' 
        ' FORM2ToolStripMenuItem
        ' 
        FORM2ToolStripMenuItem.ForeColor = Color.Blue
        FORM2ToolStripMenuItem.Name = "FORM2ToolStripMenuItem"
        FORM2ToolStripMenuItem.Size = New Size(224, 26)
        FORM2ToolStripMenuItem.Text = "FORM 2"
        ' 
        ' FORM3ToolStripMenuItem
        ' 
        FORM3ToolStripMenuItem.ForeColor = Color.Blue
        FORM3ToolStripMenuItem.Name = "FORM3ToolStripMenuItem"
        FORM3ToolStripMenuItem.Size = New Size(224, 26)
        FORM3ToolStripMenuItem.Text = "FORM 3"
        ' 
        ' CHECKRESULTToolStripMenuItem
        ' 
        CHECKRESULTToolStripMenuItem.ForeColor = Color.Blue
        CHECKRESULTToolStripMenuItem.Name = "CHECKRESULTToolStripMenuItem"
        CHECKRESULTToolStripMenuItem.Size = New Size(292, 26)
        CHECKRESULTToolStripMenuItem.Text = "CHECK RESULT"
        ' 
        ' SCOREENTRYToolStripMenuItem
        ' 
        SCOREENTRYToolStripMenuItem.ForeColor = Color.Blue
        SCOREENTRYToolStripMenuItem.Name = "SCOREENTRYToolStripMenuItem"
        SCOREENTRYToolStripMenuItem.Size = New Size(292, 26)
        SCOREENTRYToolStripMenuItem.Text = "SCORE ENTRY"
        ' 
        ' STUDENTADMISSIONToolStripMenuItem
        ' 
        STUDENTADMISSIONToolStripMenuItem.ForeColor = Color.Blue
        STUDENTADMISSIONToolStripMenuItem.Image = My.Resources.Resources.graduation
        STUDENTADMISSIONToolStripMenuItem.Name = "STUDENTADMISSIONToolStripMenuItem"
        STUDENTADMISSIONToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        STUDENTADMISSIONToolStripMenuItem.Size = New Size(292, 26)
        STUDENTADMISSIONToolStripMenuItem.Text = "STUDENT ADMISSION"
        ' 
        ' LOGOUTToolStripMenuItem
        ' 
        LOGOUTToolStripMenuItem.ForeColor = Color.Red
        LOGOUTToolStripMenuItem.Image = My.Resources.Resources.power
        LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        LOGOUTToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.L
        LOGOUTToolStripMenuItem.Size = New Size(292, 26)
        LOGOUTToolStripMenuItem.Text = "LOGOUT"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(670, 497)
        ControlBox = False
        Controls.Add(PictureBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STUDENTADMISSIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CHECKRESULTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SCOREENTRYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STUDENTBYCLASSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORM1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORM2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORM3ToolStripMenuItem As ToolStripMenuItem
End Class
