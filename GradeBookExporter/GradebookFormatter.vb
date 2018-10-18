Imports Microsoft.Office.Interop.Excel
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
        Dim xl As New Application
        Dim wb As Workbook = xl.Workbooks.Open(filename)

        For Each sheet As Worksheet In wb.Worksheets
            sheet.Rows("1:1").Select()

            ' rotate title row
            With xl.Selection
                .HorizontalAlignment = Constants.xlGeneral
                .VerticalAlignment = Constants.xlBottom
                .WrapText = False
                .Orientation = 90
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Constants.xlContext
                .MergeCells = False
            End With

            ' setup borders
            xl.Selection.Font.Bold = True
            sheet.Cells.Select()
            sheet.Cells.EntireColumn.AutoFit()
            sheet.Range("A1").Select()
            sheet.Range(xl.Selection, xl.Selection.End(XlDirection.xlToRight)).Select()
            sheet.Range(xl.Selection, xl.Selection.End(XlDirection.xlDown)).Select()
            xl.Selection.Borders(XlBordersIndex.xlDiagonalDown).LineStyle = Constants.xlNone
            xl.Selection.Borders(XlBordersIndex.xlDiagonalUp).LineStyle = Constants.xlNone
            With xl.Selection.Borders(XlBordersIndex.xlEdgeLeft)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With
            With xl.Selection.Borders(XlBordersIndex.xlEdgeTop)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With
            With xl.Selection.Borders(XlBordersIndex.xlEdgeBottom)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With
            With xl.Selection.Borders(XlBordersIndex.xlEdgeRight)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With
            With xl.Selection.Borders(XlBordersIndex.xlInsideVertical)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With
            With xl.Selection.Borders(XlBordersIndex.xlInsideHorizontal)
                .LineStyle = XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = XlBorderWeight.xlThin
            End With

            ' conditional formatting
            xl.Selection.FormatConditions.AddColorScale(3)
            xl.Selection.FormatConditions(xl.Selection.FormatConditions.Count).SetFirstPriority()
            xl.Selection.FormatConditions(1).ColorScaleCriteria(1).Type =
                    XlConditionValueTypes.xlConditionValueLowestValue
            With xl.Selection.FormatConditions(1).ColorScaleCriteria(1).FormatColor
                .Color = 7039480
                .TintAndShade = 0
            End With
            xl.Selection.FormatConditions(1).ColorScaleCriteria(2).Type =
                    XlConditionValueTypes.xlConditionValuePercentile
            xl.Selection.FormatConditions(1).ColorScaleCriteria(2).Value = 50
            With xl.Selection.FormatConditions(1).ColorScaleCriteria(2).FormatColor
                .Color = 8711167
                .TintAndShade = 0
            End With
            xl.Selection.FormatConditions(1).ColorScaleCriteria(3).Type =
                    XlConditionValueTypes.xlConditionValueHighestValue
            With xl.Selection.FormatConditions(1).ColorScaleCriteria(3).FormatColor
                .Color = 8109667
                .TintAndShade = 0
            End With

            ' colour columns
            For Each c As Range In xl.Selection.Columns
                Dim colTitle As String = c.Range("a1").Text

                For Each colColor As ColumnColor In HighlightedColumns
                    If colTitle.ToLower.Contains(colColor.name.ToLower) Then
                        With c.Interior
                            .Pattern = Constants.xlSolid
                            .PatternColorIndex = Constants.xlAutomatic
                            .Color = colColor.color
                            .TintAndShade = 0
                            .PatternTintAndShade = 0
                        End With
                    End If
                Next

                If colTitle = "Last downloaded from this course" Then
                    For Each dateCell As Range In c.Cells
                        Try
                            Dim timestamp As Integer = dateCell.Value
                            dateCell.Value = (timestamp / 86400) + 25569
                            dateCell.NumberFormat = "DD/MM/YYYY"
                            dateCell.FormatConditions.Delete()
                        Catch
                        End Try
                    Next
                End If


            Next


        Next
        wb.Save()
        xl.Quit()
    End Sub

End Class
