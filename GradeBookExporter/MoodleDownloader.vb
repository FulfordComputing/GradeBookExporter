Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class MoodleDownloader
    Public Connected As Boolean = False
    Public Username As String = ""
    Public Site As String
    Protected cookies As New CookieContainer

    Public Function Connect(site As String, username As String, password As String) As Boolean
        Me.Username = username
        Me.Site = site
        Dim url As String = site & "/login/index.php"
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.Method = "POST"
        request.CookieContainer = cookies
        Dim postData As String = "username=" & username & "&password=" & password
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()

        Dim m As Match = Regex.Match(responseFromServer, """logininfo"">(.*?)(<.*?""View profile"">(.*?)<.*?)?<")
        If m.Success Then
            Me.Username = m.Groups(3).Value
            Return True
        End If
        Return False
    End Function


    Public Sub DownloadGrades(course As CourseDetails)
        Dim url As String = Site & "/grade/export/xls/index.php?id=" & course.id
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.CookieContainer = cookies
        Dim response As WebResponse = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8)
        Dim html As String = sr.ReadToEnd()
        'MsgBox(html)
        sr.Close()
        response.Close()


    End Sub
End Class
