﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.pbStatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.lblStatusLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.groupCourses = New System.Windows.Forms.GroupBox()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.menuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.s = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.groupCourses.SuspendLayout()
        Me.menuFile.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(70, 55)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(70, 82)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 85)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbStatus, Me.lblStatusLogin})
        Me.statusBar.Location = New System.Drawing.Point(0, 428)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(800, 22)
        Me.statusBar.TabIndex = 1
        Me.statusBar.Text = "StatusStrip1"
        '
        'pbStatus
        '
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(100, 16)
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(176, 55)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(70, 29)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(181, 20)
        Me.txtSite.TabIndex = 5
        Me.txtSite.Text = "https://vle.fulford.york.sch.uk"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Location = New System.Drawing.Point(6, 32)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(28, 13)
        Me.lblSite.TabIndex = 4
        Me.lblSite.Text = "Site:"
        '
        'lblStatusLogin
        '
        Me.lblStatusLogin.Name = "lblStatusLogin"
        Me.lblStatusLogin.Size = New System.Drawing.Size(86, 17)
        Me.lblStatusLogin.Text = "Not connected"
        '
        'groupCourses
        '
        Me.groupCourses.Controls.Add(Me.s)
        Me.groupCourses.Controls.Add(Me.lstCourses)
        Me.groupCourses.Location = New System.Drawing.Point(273, 37)
        Me.groupCourses.Name = "groupCourses"
        Me.groupCourses.Size = New System.Drawing.Size(515, 240)
        Me.groupCourses.TabIndex = 3
        Me.groupCourses.TabStop = False
        Me.groupCourses.Text = "Courses"
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(18, 19)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCourses.Size = New System.Drawing.Size(491, 186)
        Me.lstCourses.TabIndex = 3
        '
        'menuFile
        '
        Me.menuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menuFile.Location = New System.Drawing.Point(0, 0)
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(800, 24)
        Me.menuFile.TabIndex = 4
        Me.menuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(173, 211)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(153, 23)
        Me.s.TabIndex = 4
        Me.s.Text = "Download Grades"
        Me.s.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.groupCourses)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.menuFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "VLE Gradebook Exporter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.groupCourses.ResumeLayout(False)
        Me.menuFile.ResumeLayout(False)
        Me.menuFile.PerformLayout()
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
    Friend WithEvents s As Button
End Class
