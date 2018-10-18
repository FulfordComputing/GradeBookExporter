<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradebookDownloader
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.pbStatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatusLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.groupCourses = New System.Windows.Forms.GroupBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.menuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.groupCourses.SuspendLayout()
        Me.menuFile.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSite)
        Me.GroupBox1.Controls.Add(Me.lblSite)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(534, 333)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details:"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(140, 56)
        Me.txtSite.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(358, 31)
        Me.txtSite.TabIndex = 5
        Me.txtSite.Text = "https://vle.fulford.york.sch.uk"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Location = New System.Drawing.Point(12, 62)
        Me.lblSite.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(55, 25)
        Me.lblSite.TabIndex = 4
        Me.lblSite.Text = "Site:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(228, 242)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(6)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(150, 44)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(140, 158)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(358, 31)
        Me.txtPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 163)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(112, 25)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(140, 106)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(358, 31)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'statusBar
        '
        Me.statusBar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbStatus, Me.lblStatusLogin})
        Me.statusBar.Location = New System.Drawing.Point(0, 828)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.statusBar.Size = New System.Drawing.Size(1600, 37)
        Me.statusBar.TabIndex = 1
        Me.statusBar.Text = "StatusStrip1"
        '
        'pbStatus
        '
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(200, 31)
        '
        'lblStatusLogin
        '
        Me.lblStatusLogin.Name = "lblStatusLogin"
        Me.lblStatusLogin.Size = New System.Drawing.Size(174, 32)
        Me.lblStatusLogin.Text = "Not connected"
        '
        'groupCourses
        '
        Me.groupCourses.Controls.Add(Me.btnDownload)
        Me.groupCourses.Controls.Add(Me.lstCourses)
        Me.groupCourses.Location = New System.Drawing.Point(546, 71)
        Me.groupCourses.Margin = New System.Windows.Forms.Padding(6)
        Me.groupCourses.Name = "groupCourses"
        Me.groupCourses.Padding = New System.Windows.Forms.Padding(6)
        Me.groupCourses.Size = New System.Drawing.Size(1030, 329)
        Me.groupCourses.TabIndex = 3
        Me.groupCourses.TabStop = False
        Me.groupCourses.Text = "Courses"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(360, 262)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(306, 44)
        Me.btnDownload.TabIndex = 4
        Me.btnDownload.Text = "Download Grades"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.ItemHeight = 25
        Me.lstCourses.Location = New System.Drawing.Point(36, 37)
        Me.lstCourses.Margin = New System.Windows.Forms.Padding(6)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCourses.Size = New System.Drawing.Size(978, 204)
        Me.lstCourses.TabIndex = 3
        '
        'menuFile
        '
        Me.menuFile.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menuFile.Location = New System.Drawing.Point(0, 0)
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.menuFile.Size = New System.Drawing.Size(1600, 44)
        Me.menuFile.TabIndex = 4
        Me.menuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(173, 38)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(173, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOutputFolder)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 409)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1559, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output folder:"
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.Location = New System.Drawing.Point(25, 45)
        Me.txtOutputFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(1507, 31)
        Me.txtOutputFolder.TabIndex = 4
        '
        'GradebookDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupCourses)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.menuFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "GradebookDownloader"
        Me.Text = "VLE Gradebook Exporter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.groupCourses.ResumeLayout(False)
        Me.menuFile.ResumeLayout(False)
        Me.menuFile.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSite As TextBox
    Friend WithEvents lblSite As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents statusBar As StatusStrip
    Friend WithEvents pbStatus As ToolStripProgressBar
    Friend WithEvents lblStatusLogin As ToolStripStatusLabel
    Friend WithEvents groupCourses As GroupBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents menuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDownload As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOutputFolder As TextBox
End Class
