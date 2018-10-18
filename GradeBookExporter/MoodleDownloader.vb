Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class MoodleDownloader
    Public Connected As Boolean = False
    Public Username As String = ""
    Public Site As String
    Public OutputFolder As String = ""
    Protected cookies As New CookieContainer
    Dim formatter As New GradebookFormatter

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
            If m.Groups(3).Value = "" Then
                Return False
            End If
            Me.Username = m.Groups(3).Value
            Connected = True
            Return True
        End If
        Return False
    End Function


    Public Sub DownloadGrades(course As CourseDetails)
        If Connected = False Then
            Exit Sub
        End If
        Dim url As String = Site & "/grade/export/xls/index.php?id=" & course.id
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.CookieContainer = cookies
        Dim SessionKey As String = ""

        Dim response As WebResponse = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8)
        Dim html As String = sr.ReadToEnd()

        Dim m As Match = Regex.Match(html, "name=""group"">(.*?)<\/select>", RegexOptions.Singleline)
        If m.Success Then
            Dim selectHtml As String = m.Groups(1).Value
            Dim groups As MatchCollection = Regex.Matches(selectHtml, "value=""(\d+)"".*?>(.*?)<")
            course.Groups.Clear()

            For Each m In groups
                course.Groups.Add(m.Groups(1).Value, m.Groups(2).Value)
            Next
        End If

        m = Regex.Match(html, """sesskey"":""(.*?)""")
        If m.Success Then
            SessionKey = m.Groups(1).Value
        End If

        Dim mActivities As MatchCollection = Regex.Matches(html, "itemids\[(\d+)\]")
        course.ActivityIDs.Clear()
        For Each m In mActivities
            Dim id As Integer = m.Groups(1).Value
            If Not course.ActivityIDs.Contains(id) Then
                course.ActivityIDs.Add(m.Groups(1).Value)
            End If
        Next


        sr.Close()
        response.Close()

        For Each groupID As Integer In course.Groups.Keys
            If groupID = 0 Then
                Continue For
            End If
            url = Site & "/grade/export/xls/export.php?group=" & groupID


            request = HttpWebRequest.Create(url)
            request.CookieContainer = cookies
            request.Method = "POST"
            Dim postData As String = "id=" & course.id & "submitbutton=Download&display[real]=1&decimals=2&export_onlyactive=1&export_feedback=0&mform_isexpanded_id_gradeitems=1&checkbox_controller1=1&_qf__grade_export_form=1&sesskey=" & SessionKey

            For Each activityID As Integer In course.ActivityIDs
                postData &= "&itemids[" & activityID & "]=1"
            Next
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            request.CookieContainer = cookies
            response = request.GetResponse()
            Dim filename As String = course.Groups(groupID) & ".xlsx"
            filename = filename.Replace("/", "-")
            filename = OutputFolder & "\" & filename
            Dim fs As New FileStream(filename, FileMode.Create)

            Dim s = response.GetResponseStream
            Dim br As New BinaryReader(s)
            Dim bytes(1024) As Byte

            Dim count As Integer = 1
            While count > 0
                count = s.Read(bytes, 0, bytes.Length)
                fs.Write(bytes, 0, count)
            End While
            fs.Close()
            s.Close()
            response.Close()
            formatter.ConvertFile(filename)

        Next

    End Sub
End Class
