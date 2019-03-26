Imports System.Web.UI
Imports System.IO
Imports System.ComponentModel


Class Cell
    Inherits Element

    Private node As node

    Private cSpan As Integer = 1
    Private rSpan As Integer = 1
    Private control As RichTextLabel
    Private bordColor, cpColor As Color

    Public Event RebuildNeeded As EventHandler
    Public Event RepaintNeeded As EventHandler
    Public Event SpanningChanged As EventHandler

    Public Sub New()
        control = New RichTextLabel
        control.Tag = Me
        cpColor = Color.White
    End Sub

    Public Overrides Sub GenerateHTML(ByVal output As HtmlTextWriter)
        ' Build the style

        If rSpan <> 1 Then
            output.AddAttribute(HtmlTextWriterAttribute.Rowspan, rSpan.ToString)
        End If
        If cSpan <> 1 Then
            output.AddAttribute(HtmlTextWriterAttribute.Colspan, cSpan.ToString)
        End If

        output.AddStyleAttribute(HtmlTextWriterStyle.BorderColor, GetHexColor(bordColor))
        output.AddStyleAttribute(HtmlTextWriterStyle.BackgroundColor, GetHexColor(control.BackColor))

        output.AddStyleAttribute("cellpaddingcolor", GetHexColor(cpColor))

        ' Open the TD tag
        output.RenderBeginTag(HtmlTextWriterTag.Td)
        output.Write(Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(control.RtfText)))

        ' Close the TD tag
        output.RenderEndTag()
    End Sub

    Public Overrides Sub GeneratePlainText(ByVal output As TextWriter)
        output.Write(control.Text)
        output.Write(" ")
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public Property AssociatedControl() As RichTextLabel
        Get
            Return control
        End Get
        Set(ByVal Value As RichTextLabel)
            control = Value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property AssociatedNode() As node
        Get
            Return node
        End Get
        Set(ByVal Value As node)
            node = Value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property Text() As String
        Get
            Return control.Text
        End Get
        Set(ByVal Value As String)
            control.Text = Value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property RtfText() As String
        Get
            Return control.RtfText
        End Get
        Set(ByVal Value As String)
            control.RtfText = Value
        End Set
    End Property

    <TranslatedProperty("rowspanname", "rowspandescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property RowSpan() As Integer
        Get
            Return rSpan
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "RowSpan", RowSpan, Value)
            UndoRedo.NewState(pcs)

            rSpan = Value
            If rSpan < 1 Then
                rSpan = 1
            End If
            RaiseEvent SpanningChanged(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("colspanname", "colspandescription"), TypeConverter(GetType(TranslatedInt32Converter))> _
    Public Property ColSpan() As Integer
        Get
            Return cSpan
        End Get
        Set(ByVal Value As Integer)
            Dim pcs As New PropertyChangeState(Me, "ColSpan", ColSpan, Value)
            UndoRedo.NewState(pcs)

            cSpan = Value
            If cSpan < 1 Then
                cSpan = 1
            End If
            RaiseEvent SpanningChanged(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("bgcolorname", "bgcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property BackgroundColor() As Color
        Get
            Return control.BackColor
        End Get
        Set(ByVal Value As Color)
            Dim pcs As New PropertyChangeState(Me, "BackgroundColor", BackgroundColor, Value)
            UndoRedo.NewState(pcs)

            control.BackColor = Value
        End Set
    End Property

    <TranslatedProperty("bordercolorname", "bordercolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property BorderColor() As Color
        Get
            Return bordColor
        End Get
        Set(ByVal Value As Color)
            Dim pcs As New PropertyChangeState(Me, "BorderColor", BorderColor, Value)
            UndoRedo.NewState(pcs)

            bordColor = Value
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

    <TranslatedProperty("cellpaddingcolorname", "cellpaddingcolordescription"), TypeConverter(GetType(TranslatedColorConverter))> _
    Public Property CellPaddingColor() As Color
        Get
            Return cpColor
        End Get
        Set(ByVal Value As Color)
            Dim pcs As New PropertyChangeState(Me, "CellPaddingColor", CellPaddingColor, Value)
            UndoRedo.NewState(pcs)

            cpColor = Value
            RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
        End Set
    End Property

End Class