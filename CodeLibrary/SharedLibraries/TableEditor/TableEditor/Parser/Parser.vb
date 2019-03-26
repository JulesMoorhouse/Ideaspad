Imports System.IO
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Text

Class Parser
    Private input As String
    Private imgFolder As String
    Private pos As Integer = 0
    Public Sub New(ByVal input As String, Optional ByVal imagesFolder As String = "")
        Me.input = input
        imgFolder = imagesFolder
    End Sub

    Private Sub Match(ByVal text As String, Optional ByVal matchCase As Boolean = False)
        If input.Substring(pos, text.Length) = text Then
            pos += text.Length
        Else
            Throw New Exception("Parse error: Expecting '" + text + "', found '" + input.Substring(pos, text.Length) + "'")
        End If
    End Sub

    Private Function IsLookAhead(ByVal text As String, Optional ByVal matchCase As Boolean = False) As Boolean
        Return input.Substring(pos, text.Length) = text
    End Function

    Private Function GetLookAhead(Optional ByVal count As Integer = 1) As String
        Dim res As String = input.Substring(pos, count)
        pos += count

        Return res
    End Function

    Private Sub WhiteSpace()
        While IsLookAhead(" ") Or IsLookAhead(vbCr) Or IsLookAhead(vbLf) Or IsLookAhead(vbTab)
            GetLookAhead()
        End While
    End Sub

    Private Function OpenTable() As StringDictionary
        Dim res As New StringDictionary

        Match("<table")
        WhiteSpace()

        While Not IsLookAhead(">")
            WhiteSpace()
            Dim de As DictionaryEntry = Attribute()
            res.Add(de.Key, de.Value)
        End While

        Match(">")
        Return res
    End Function

    Private Function Attribute() As DictionaryEntry
        Dim name As String = AttributeName()
        Match("=")
        Dim value As String = AttributeValue()

        Return New DictionaryEntry(name, value)
    End Function

    Private Function AttributeName() As String
        Dim res As String = ""

        While Not IsLookAhead("=")
            res += GetLookAhead()
        End While

        Return res
    End Function

    Private Function AttributeValue() As String
        Dim res As String = ""

        Match("""")
        While Not IsLookAhead("""")
            res += GetLookAhead()
        End While
        Match("""")

        Return res
    End Function

    Private Function Row() As Row
        Dim myRow As New Row

        Match("<tr>")
        While Not IsLookAhead("</tr>")
            WhiteSpace()
            myRow.Cells.Add(Cell())
            WhiteSpace()
        End While
        Match("</tr>")

        Return myRow
    End Function

    Protected Function GetColor(ByVal colorStr As String) As Color
        Dim red = Convert.ToInt32(colorStr.Substring(1, 2), 16)
        Dim green = Convert.ToInt32(colorStr.Substring(3, 2), 16)
        Dim blue = Convert.ToInt32(colorStr.Substring(5, 2), 16)

        Return Color.FromArgb(red, green, blue)
    End Function

    Private Function Cell() As Cell
        Dim myCell As New Cell()
        Dim sb As New StringBuilder()

        Dim text As String = ""

        Dim cellAttr As StringDictionary = OpenCell()
        While Not IsLookAhead("</td>")
            sb.Append(GetLookAhead())
        End While
        Match("</td>")
        text = sb.ToString

        If cellAttr.ContainsKey("style") Then
            Dim styles As New StringDictionary()
            Dim st As String 
            For Each st In cellAttr("style").TrimEnd(";").Split(";")
                Dim stData As String() = st.Split(":")
                styles.Add(stData(0), stData(1))
            Next

            If styles.ContainsKey("border-color") Then
                myCell.BorderColor = GetColor(styles("border-color"))
            End If

            If styles.ContainsKey("background-color") Then
                myCell.BackgroundColor = GetColor(styles("background-color"))
            End If

            If styles.ContainsKey("cellpaddingcolor") Then
                myCell.CellPaddingColor = GetColor(styles("cellpaddingcolor"))
            End If
        End If

        If cellAttr.ContainsKey("colspan") Then
            myCell.ColSpan = cellAttr("colspan")
        End If

        If cellAttr.ContainsKey("rowspan") Then
            myCell.RowSpan = cellAttr("rowspan")
        End If

        myCell.RtfText = System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(text))


        Return myCell
    End Function

    Private Function OpenCell() As StringDictionary
        Dim res As New StringDictionary

        Match("<td")
        WhiteSpace()

        While Not IsLookAhead(">")
            WhiteSpace()
            Dim de As DictionaryEntry = Attribute()
            res.Add(de.Key, de.Value)
        End While

        Match(">")
        Return res
    End Function

    Public Function Table() As Table
        Dim tab As New Table
        Dim tabAttr As StringDictionary = OpenTable()
        While Not IsLookAhead("</table>")
            WhiteSpace()
            tab.Rows.Add(Row())
            WhiteSpace()
        End While
        Match("</table>")

        If tabAttr.ContainsKey("cellspacing") Then
            tab.CellSpacing = tabAttr("cellspacing")
        End If

        If tabAttr.ContainsKey("cellpadding") Then
            tab.CellPadding = tabAttr("cellpadding")
        End If

        If tabAttr.ContainsKey("border") Then
            tab.BorderSize = tabAttr("border")
        End If

        If tabAttr.ContainsKey("bordercolor") Then
            tab.BorderColor = GetColor(tabAttr("bordercolor"))
        End If

        If tabAttr.ContainsKey("bgcolor") Then
            tab.BackgroundColor = GetColor(tabAttr("bgcolor"))
        End If

        If tabAttr.ContainsKey("shadowcolor") Then
            tab.ShadowColor = GetColor(tabAttr("shadowcolor"))
        End If

        If tabAttr.ContainsKey("shadowdistance") Then
            tab.ShadowDistance = tabAttr("shadowdistance")
        End If

        If tabAttr.ContainsKey("exteriorborder") Then
            tab.ExteriorBorderSize = tabAttr("exteriorborder")
        End If

        Dim st As String 

        If tabAttr.ContainsKey("widths") Then
            For Each st In tabAttr("widths").TrimEnd(";").Split(";")
                tab.Widths.Add(Integer.Parse(st))
            Next
        End If

        If tabAttr.ContainsKey("heights") Then
            For Each st In tabAttr("heights").TrimEnd(";").Split(";")
                tab.Heights.Add(Integer.Parse(st))
            Next
        End If

        Return tab
    End Function
End Class
