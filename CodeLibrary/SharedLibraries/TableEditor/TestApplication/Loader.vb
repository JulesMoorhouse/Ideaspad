Public Class Loader
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnShowEditor As System.Windows.Forms.Button
    Friend WithEvents txtHtml As System.Windows.Forms.TextBox
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnFromArray As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShowEditor = New System.Windows.Forms.Button
        Me.txtHtml = New System.Windows.Forms.TextBox
        Me.pbImage = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtText = New System.Windows.Forms.TextBox
        Me.btnFromArray = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnShowEditor
        '
        Me.btnShowEditor.Location = New System.Drawing.Point(8, 8)
        Me.btnShowEditor.Name = "btnShowEditor"
        Me.btnShowEditor.TabIndex = 0
        Me.btnShowEditor.Text = "Show editor"
        '
        'txtHtml
        '
        Me.txtHtml.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHtml.Location = New System.Drawing.Point(8, 64)
        Me.txtHtml.Multiline = True
        Me.txtHtml.Name = "txtHtml"
        Me.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHtml.Size = New System.Drawing.Size(568, 112)
        Me.txtHtml.TabIndex = 1
        Me.txtHtml.Text = ""
        Me.txtHtml.WordWrap = False
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(8, 352)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(456, 296)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbImage.TabIndex = 2
        Me.pbImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HTML"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Image"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Text"
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.Location = New System.Drawing.Point(8, 200)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtText.Size = New System.Drawing.Size(568, 112)
        Me.txtText.TabIndex = 6
        Me.txtText.Text = ""
        Me.txtText.WordWrap = False
        '
        'btnFromArray
        '
        Me.btnFromArray.Location = New System.Drawing.Point(104, 8)
        Me.btnFromArray.Name = "btnFromArray"
        Me.btnFromArray.Size = New System.Drawing.Size(112, 23)
        Me.btnFromArray.TabIndex = 7
        Me.btnFromArray.Text = "Build from array"
        '
        'Loader
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(592, 670)
        Me.Controls.Add(Me.btnFromArray)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.txtHtml)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.btnShowEditor)
        Me.Name = "Loader"
        Me.Text = "Editor loader"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShowEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowEditor.Click
        ' Translations
        Dim table As New System.Collections.Specialized.StringDictionary

        ' Property grid
        table.Add("fontname", "Font")
        table.Add("fontdescription", "The font used in the text")
        table.Add("textname", "Text")
        table.Add("textdescription", "The text of the cell")
        table.Add("rowspanname", "Row span")
        table.Add("rowspandescription", "The row span")
        table.Add("colspanname", "Col span")
        table.Add("colspandescription", "The col span")
        table.Add("bgcolorname", "Background color")
        table.Add("bgcolordescription", "The color of the background")
        table.Add("bordercolorname", "Border color")
        table.Add("bordercolordescription", "The color of the border")
        table.Add("textcolorname", "Text color")
        table.Add("textcolordescription", "The color of the text")
        table.Add("textalignname", "Text alignment")
        table.Add("textaligndescription", "The alignment of the text")
        table.Add("bgimagename", "Background image")
        table.Add("bgimagedescription", "An image to display as background")
        table.Add("exteriortablebgcolorname", "Exterior Background color")
        table.Add("exteriortablebgcolordescription", "The background color of the exterior of the table")
        table.Add("cellspacingname", "Cell spacing")
        table.Add("cellspacingdescription", "The cell spacing")
        table.Add("cellpaddingname", "Cell padding")
        table.Add("cellpaddingdescription", "The cell padding")
        table.Add("cellpaddingcolorname", "Cell padding color")
        table.Add("cellpaddingcolordescription", "The color used for the space left by the cell padding")
        table.Add("bordersizename", "Border size")
        table.Add("bordersizedescription", "The size of the border")
        table.Add("tabledefaultcellfontname", "Default font")
        table.Add("tabledefaultcellfontdescription", "The default font for the cells of the table")
        table.Add("tabledefaulttextcolorname", "Default text color")
        table.Add("tabledefaulttextcolordescription", "The default text color for the cells of the table")
        table.Add("tabledefaultcellcolorname", "Default background color")
        table.Add("tabledefaultcellcolordescription", "The default background color for the cells of the table")
        table.Add("exteriorbordersizename", "Exterior border size")
        table.Add("exteriorbordersizedescription", "The size of the space left outside the table")

        table.Add("shadowdistancename", "Shadow distance")
        table.Add("shadowdistancedescription", "The distance of the shadow to the the table")
        table.Add("shadowcolorname", "Shadow color")
        table.Add("shadowcolordescription", "The color of the shadow")

        ' Dimensions dialog
        table.Add("rownumber", "Rows:")
        table.Add("columnnumber", "Columns:")

        ' Buttons
        table.Add("buttonok", "OK")
        table.Add("buttoncancel", "Cancel")
        table.Add("buttonadvanced", "Advanced")
        table.Add("buttonbasic", "Basic")
        table.Add("buttonhelp", "Help")

        ' Menu items
        table.Add("menuaddrow", "Add row")
        table.Add("menuaddcolumn", "Add column")
        table.Add("menuremoverow", "Remove row")
        table.Add("menuremovecolumn", "Remove column")
        table.Add("menuedit", "Edit")
        table.Add("menusplit", "Split")
        table.Add("menuproperties", "Properties")

        ' Form titles
        table.Add("formdefinetable", "Define table")
        table.Add("formsplit", "Split")
        table.Add("formeditor", "Table editor")

        ' Other form texts
        table.Add("tabledimensions", "Table dimensions")
        table.Add("invalidcolor", "The value {0} is not valid for a color")
        table.Add("invalidnumber", "The value {0} is not valid for a positive integer")

        table.Add("advancedproperties", "Advanced properties")

        table.Add("mergeinfo", "To merge cells select the first and shift-select the last cell")



        ' End of translations

        Dim tbe As TableEditor.MainTableEditor
        If txtHtml.Text.Trim() = "" Then
            tbe = New TableEditor.MainTableEditor
        Else
            tbe = New TableEditor.MainTableEditor(txtHtml.Text.Trim())
        End If

        With tbe
            .DefaultCellFont = New Font("Arial", 10)
            .DefaultCellTextColor = Color.Black
            .Width = 700
            .SetPropertyGridColumnWidth(130, 130)
            .Height = 400
            .Translations = table
            .AlwaysOnTop = False 

            If (.ShowDialog() = DialogResult.OK) Then
                txtHtml.Text = .GetHTML
                txtHtml.SelectionLength = 0
                txtText.Text = .GetPlainText
                txtText.SelectionLength = 0

                Dim retImage As Image
                Dim rnd As New Random(Environment.TickCount)
                retImage = .GetImage("G" + rnd.Next(1, 1500000).ToString())
                pbImage.Image = retImage
                Label2.Text = "Image d: " + TableEditor.MainTableEditor.GetIdFromImage(retImage).ToString
            End If
        End With
        
    End Sub

    Private Sub btnFromArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromArray.Click
        Dim a As String()() = {New String() {"1", "2"}, New String() {"3", "4"}, New String() {"5", "6"}, New String() {"7", "8"}}
        Dim editor As New TableEditor.MainTableEditor(a, New Font("Arial", 10), Me.ForeColor)

        With editor

            txtHtml.Text = .GetHTML
            txtHtml.SelectionLength = 0
            txtText.Text = .GetPlainText
            txtText.SelectionLength = 0

            Dim retImage As Image
            Dim rnd As New Random(Environment.TickCount)
            retImage = .GetImage(rnd.Next(1, 1500000))
            Label2.Text = "Image d: " + TableEditor.MainTableEditor.GetIdFromImage(retImage).ToString
            pbImage.Image = retImage
            Label2.Text = "Image d: " + TableEditor.MainTableEditor.GetIdFromImage(retImage).ToString
        End With
    End Sub
End Class
