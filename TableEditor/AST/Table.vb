Imports System.Web.UI
Imports System.IO
Imports System.ComponentModel

Class Table
    Inherits Element

    Private rowList As New ArrayList
    Private spacing As Integer
    Private padding As Integer
    Private bord, extBord As Integer

    Private color, bgColor As color

    Private _widths As ArrayList
    Private _heights As ArrayList

    Private defFont As Font
    Private defColor As color
    Private defCellColor As color = color.White

    Private shdColor As color = color.Gray
    Private shdDistance As Integer

    Public Event RepaintNeeded As EventHandler

    Public Sub New()
        _widths = New ArrayList
        _heights = New ArrayList
    End Sub

    Public Overrides Sub GenerateHTML(ByVal output As HtmlTextWriter)
        ' Open the TABLE tag
        output.AddAttribute(HtmlTextWriterAttribute.Cellspacing, spacing.ToString)
        output.AddAttribute(HtmlTextWriterAttribute.Cellpadding, padding.ToString)
        output.AddAttribute(HtmlTextWriterAttribute.Border, bord.ToString)
        output.AddAttribute(HtmlTextWriterAttribute.Bordercolor, GetHexColor(color))
        output.AddAttribute(HtmlTextWriterAttribute.Bgcolor, GetHexColor(bgColor))
        output.AddAttribute("shadowcolor", GetHexColor(shdColor))
        output.AddAttribute("shadowdistance", shdDistance.ToString)
        output.AddAttribute("exteriorborder", extBord.ToString)

        Dim widthStr As String = ""
        Dim w As Integer 
        For Each w In _widths
            widthStr += w.ToString + ";"
        Next

        Dim heightStr As String = ""
        Dim h As Integer 
        For Each h In _heights
            heightStr += h.ToString + ";"
        Next

        output.AddAttribute("widths", widthStr)
        output.AddAttribute("heights", heightStr)

        output.RenderBeginTag(HtmlTextWriterTag.Table)

        ' Render each row
        Dim tableRow As Row 
        For Each tableRow In rowList
            tableRow.GenerateHTML(output)
        Next

        ' Close the TABLE tag
        output.RenderEndTag()
    End Sub

    Public Overrides Sub GeneratePlainText(ByVal output As TextWriter)
        ' Get text of each row
        Dim tableRow As Row 
        For Each tableRow In rowList
            tableRow.GeneratePlainText(output)
        Next
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Rows() As IList
        Get
            Return rowList
        End Get
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Widths() As ArrayList
        Get
            Return _widths
        End Get
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Heights() As ArrayList
        Get
            Return _heights
        End Get
    End Property

    <TranslatedProperty("cellspacingname", "cellspacingdescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property CellSpacing() As Integer
        Get
            Return spacing
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "CellSpacing", CellSpacing, Value)
            UndoRedo.NewState(pcs)

            spacing = Value
            If spacing < 0 Then
                spacing = 0
            End If
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("cellpaddingname", "cellpaddingdescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property CellPadding() As Integer
        Get
            Return padding
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "CellPadding", CellPadding, Value)
            UndoRedo.NewState(pcs)

            padding = Value
            If padding < 0 Then
                padding = 0
            End If

            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("bordersizename", "bordersizedescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property BorderSize() As Integer
        Get
            Return bord
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "BorderSize", BorderSize, Value)
            UndoRedo.NewState(pcs)

            bord = Value
            If bord < 0 Then
                bord = 0
            End If
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("bordercolorname", "bordercolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property BorderColor() As color
        Get
            Return color
        End Get
        Set(ByVal Value As color)
            Dim pcs As New PropertyChangeState(Me, "BorderColor", BorderColor, Value)
            UndoRedo.NewState(pcs)

            color = Value
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("exteriortablebgcolorname", "exteriortablebgcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property BackgroundColor() As color
        Get
            Return bgColor
        End Get
        Set(ByVal Value As color)
            Dim pcs As New PropertyChangeState(Me, "BackgroundColor", BackgroundColor, Value)
            UndoRedo.NewState(pcs)

            bgColor = Value
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("tabledefaultcellfontname", "tabledefaultcellfontdescription")> _
    Public Property DefaultCellFont() As Font
        Get
            Return defFont
        End Get
        Set(ByVal Value As Font)
            Dim pcs As New PropertyChangeState(Me, "DefaultCellFont", DefaultCellFont, Value)
            UndoRedo.NewState(pcs)

            Dim row As Row
            Dim cell As Cell
            For Each row In Me.Rows

                For Each cell In row.Cells
                    If cell.AssociatedControl.Font.ToString = defFont.ToString AndAlso cell.Text = "" Then
                        cell.AssociatedControl.Font = Value
                    End If
                Next
            Next
            defFont = Value
        End Set
    End Property

    <TranslatedProperty("tabledefaulttextcolorname", "tabledefaulttextcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property DefaultTextColor() As color
        Get
            Return defColor
        End Get
        Set(ByVal Value As color)
            Dim pcs As New PropertyChangeState(Me, "DefaultTextColor", DefaultTextColor, Value)
            UndoRedo.NewState(pcs)

            Dim row As Row
            Dim cell As Cell
            For Each row In Me.Rows

                For Each cell In row.Cells
                    If cell.AssociatedControl.ForeColor.ToArgb = defColor.ToArgb Then
                        cell.AssociatedControl.ForeColor = Value
                    End If
                Next
            Next

            defColor = Value
        End Set
    End Property

    <TranslatedProperty("tabledefaultcellcolorname", "tabledefaultcellcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property DefaultCellColor() As color
        Get
            Return defCellColor
        End Get
        Set(ByVal Value As color)
            Dim pcs As New PropertyChangeState(Me, "DefaultCellColor", DefaultCellColor, Value)
            UndoRedo.NewState(pcs)

            Dim row As Row
            Dim cell As Cell
            For Each row In Me.Rows

                For Each cell In row.Cells
                    If cell.BackgroundColor.ToArgb = defCellColor.ToArgb Then
                        cell.BackgroundColor = Value
                    End If
                Next
            Next

            defCellColor = Value
        End Set
    End Property

    <TranslatedProperty("exteriorbordersizename", "exteriorbordersizedescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property ExteriorBorderSize() As Integer
        Get
            Return extBord
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "ExteriorBorderSize", ExteriorBorderSize, Value)
            UndoRedo.NewState(pcs)

            extBord = Value
            If extBord < 0 Then
                extBord = 0
            End If
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("shadowdistancename", "shadowdistancedescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property ShadowDistance() As Integer
        Get
            Return shdDistance
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "ShadowDistance", ShadowDistance, Value)
            UndoRedo.NewState(pcs)

            shdDistance = Value
            If shdDistance < 0 Then
                shdDistance = 0
            End If
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("shadowcolorname", "shadowcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property ShadowColor() As color
        Get
            Return shdColor
        End Get
        Set(ByVal Value As color)
            Dim pcs As New PropertyChangeState(Me, "ShadowColor", ShadowColor, Value)
            UndoRedo.NewState(pcs)

            shdColor = Value
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property


End Class
