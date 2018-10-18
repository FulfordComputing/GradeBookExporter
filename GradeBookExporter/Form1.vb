Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Dim downloader As New MoodleDownloader
    Dim courses As New Courses

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If downloader.Connect(txtSite.Text, txtUsername.Text, txtPassword.Text) Then
            lblStatusLogin.Text = "Logged in as " & downloader.Username
        Else
            lblStatusLogin.Text = "Could not login"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If dlg.ShowDialog() = DialogResult.OK Then
            courses.Load(dlg.FileName)
            lstCourses.Items.Clear()
            lstCourses.Items.AddRange(courses.Details.ToArray)
            For i As Integer = 0 To lstCourses.Items.Count - 1
                lstCourses.SetSelected(i, True)
            Next
        End If

    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        For Each i As Integer In lstCourses.SelectedIndices
            Dim course As CourseDetails = courses.Details(i)
            downloader.DownloadGrades(course)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        courses.Load("Courses.txt")
        lstCourses.Items.Clear()
        lstCourses.Items.AddRange(courses.Details.ToArray)
        For i As Integer = 0 To lstCourses.Items.Count - 1
            lstCourses.SetSelected(i, True)
        Next
    End Sub
End Class
