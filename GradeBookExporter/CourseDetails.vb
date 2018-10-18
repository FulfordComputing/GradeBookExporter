Imports System.Text.RegularExpressions

Public Class CourseDetails
    Public Name As String
    Public URL As String
    Public ExcelFile As String
    Public id As Integer
    Public Groups As New Dictionary(Of Integer, String)
    Public ActivityIDs As New List(Of Integer)

    Sub New(name As String, url As String, file As String)
        Me.Name = name
        Me.URL = url
        Me.ExcelFile = file
        Dim m As Match = Regex.Match(url, "id=(\d+)")
        If m.Success Then
            id = m.Groups(1).Value
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return Name & ": " & ExcelFile
    End Function
End Class

Public Class Courses
    Public Details As New List(Of CourseDetails)


    Public Sub Load(filename As String)
        Dim data = My.Computer.FileSystem.ReadAllText(filename)
        Dim lines As String() = data.Split(vbNewLine)
        For Each line As String In lines
            Dim m As Match = Regex.Match(line, "(.*) (.*) (.*)$")
            If m.Success Then
                Details.Add(New CourseDetails(m.Groups(3).Value, m.Groups(1).Value, m.Groups(2).Value))
            End If
        Next
    End Sub
End Class
