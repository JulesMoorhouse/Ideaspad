Imports System.Web.UI
Imports System.IO

Class Row
    Inherits Element

    Private cellList As New ArrayList


    Public Overrides Sub GenerateHTML(ByVal output As HtmlTextWriter)
        ' Open the TR tag
        output.RenderBeginTag(HtmlTextWriterTag.Tr)

        ' Render each column
        Dim rowCell As Cell 
        For Each rowCell In cellList
            rowCell.GenerateHTML(output)
        Next

        ' Close the TR tag
        output.RenderEndTag()
    End Sub

    Public Overrides Sub GeneratePlainText(ByVal output As TextWriter)
        ' Get text of each column
        Dim rowCell As Cell 
        For Each rowCell In cellList
            rowCell.GeneratePlainText(output)
        Next
        output.WriteLine()
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Cells() As IList
        Get
            Return cellList
        End Get
    End Property

End Class
