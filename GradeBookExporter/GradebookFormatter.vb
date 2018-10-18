Imports ClosedXML.Excel

Public Class GradebookFormatter
    Class ColumnColor
        Public color As Color
        Public name As String
        Sub New(name As String, color As Color)
            Me.name = name
            Me.color = color
        End Sub
    End Class

    Public HighlightedColumns As New List(Of ColumnColor)

    Public Sub New()
        HighlightedColumns.Add(New ColumnColor("Total", Color.LightBlue))
        HighlightedColumns.Add(New ColumnColor("Coverage", Color.LightGreen))
        HighlightedColumns.Add(New ColumnColor("Confidence", Color.LightSalmon))
    End Sub

    Public Sub ConvertFile(filename As String)
        Dim wb As XLWorkbook = New XLWorkbook(filename)
        Dim dateCol As Integer = 0

        For Each sheet In wb.Worksheets
            With sheet.Rows("1:1").Style
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.General)
                .Alignment.SetVertical(XLAlignmentVerticalValues.Bottom)
                .Alignment.WrapText = False
                .Alignment.TextRotation = 90
                .Font.Bold = True
            End With

            ' setup borders
            sheet.Columns.AdjustToContents()
            sheet.CellsUsed.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)


            ' colour columns
            For Each c In sheet.RangeUsed.Columns
                Dim colTitle As String = c.FirstCell.Value

                For Each colColor As ColumnColor In HighlightedColumns
                    If colTitle.ToLower.Contains(colColor.name.ToLower) Then
                        With c.Style.Fill
                            .SetPatternColor(XLColor.FromColor(colColor.color))
                        End With
                    End If
                Next

                If colTitle = "Last downloaded from this course" Then
                    dateCol = c.ColumnNumber
                    For Each dateCell In c.Cells
                        Try
                            Dim timestamp As Integer = dateCell.Value
                            dateCell.Value = (timestamp / 86400) + 25569
                            dateCell.Style.NumberFormat.SetFormat("DD/MM/YYYY")
                        Catch
                        End Try
                    Next
                End If


            Next

            Dim lastRow As Integer = sheet.RowsUsed.Last.RowNumber - 1
            For colNum As Integer = 7 To 7
                sheet.Range(2, colNum, lastRow, colNum).AddConditionalFormat().ColorScale().LowestValue(XLColor.Red).Midpoint(XLCFContentType.Percent, 50, XLColor.Yellow).HighestValue(XLColor.Green)
            Next



        Next
        wb.Save()
    End Sub

End Class
