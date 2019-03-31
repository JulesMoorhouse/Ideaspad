Imports System.Reflection
Imports IPIconsPack

Public Class MainTableEditor
    Inherits System.Windows.Forms.Form

    Private myTable As Table
    Private myFont As Font
    Private myColor As Color
    Private trans As System.Collections.Specialized.StringDictionary
    Private imgFolder As String
    Private bmp As Bitmap
    Dim lbooDoOnce As Boolean = False 
    Private mbooAlwaysOnTop As Boolean = False 

    Private mstrCaption As String = ""
    Private lbooLoadDataNow As Boolean = True 
    'Private LangText As System.Resources.ResourceManager = New _
    '            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
    '            System.Reflection.Assembly.GetExecutingAssembly())
    Private LangText As System.Resources.ResourceManager = New _
                System.Resources.ResourceManager("Ideaspad.Ideaspad", _
                System.Reflection.Assembly.Load("Ideaspad"))

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myFont = Me.Font
        myColor = Me.ForeColor
        Me.propGrid = New System.Windows.Forms.PropertyGrid()
        Me.propGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.propGrid.ToolbarVisible = False
        colPanel.InnerControl = propGrid
    End Sub

    Public Sub New(ByVal table As String)
        MyClass.New()

        Dim parser As New Parser(table)
        myTable = parser.Table()
    End Sub

    Public Sub New(ByVal data As String()(), ByVal defaultFont As Font, ByVal textColor As Color)
        MyClass.New()

        myTable = New Table()
        myTable.BackgroundColor = Color.White
        myTable.BorderSize = 1
        myTable.BorderColor = Color.White
        myTable.CellPadding = 0
        myTable.CellSpacing = 0
        myTable.DefaultCellFont = myFont
        myTable.DefaultCellColor = Color.White

        myTable.DefaultTextColor = myColor
        Dim i, j As Integer
        For i = 0 To data.Length - 1
            Dim row As Row = New Row()
            For j = 0 To data(i).Length - 1
                Dim cell As Cell = New Cell()
                cell.Text = data(i)(j)
                cell.BorderColor = Color.Black
                cell.BackgroundColor = Color.White
                cell.AssociatedControl.ForeColor = textColor
                cell.AssociatedControl.Font = defaultFont
                row.Cells.Add(cell)
            Next
            myTable.Rows.Add(row)
        Next

        Dim render As New Renderer(myTable)
        editor.Renderer = render
        render.Rebuild()
        Dim tempGr As Graphics = Me.CreateGraphics()
        render.RenderTo(Me, tempGr)
        tempGr.Dispose()
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
    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents propGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents propPanel As System.Windows.Forms.Panel
    Friend WithEvents editor As TableEditor.Editor
    Friend WithEvents MenuItem5 As GradientMenu
    Friend WithEvents MenuItem6 As GradientMenu
    Friend WithEvents myMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mmEditor As MenuItem
    Friend WithEvents mmClose As GradientMenu
    Friend WithEvents mmTable As MenuItem
    Friend WithEvents mmAddRow As GradientMenu
    Friend WithEvents mmAddCell As GradientMenu
    Friend WithEvents mmRemoveRow As GradientMenu
    Friend WithEvents mmRemoveCell As GradientMenu
    Friend WithEvents mmProperties As GradientMenu
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents colPanel As TableEditor.CollapsiblePanel
    Friend WithEvents mmViewProp As GradientMenu
    Friend WithEvents btnAdv As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    'Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents panelButtons As UIStyleControl
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents mmRedo As GradientMenu
    Friend WithEvents mmUndo As GradientMenu
    Friend WithEvents tbCoolbar As AppBasic.Coolbar
    Friend WithEvents mmAddRowBefore As System.Windows.Forms.MenuItem
    Friend WithEvents mmAddRowAfter As System.Windows.Forms.MenuItem
    Friend WithEvents mmAddCellBefore As System.Windows.Forms.MenuItem
    Friend WithEvents mmAddCellAfter As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.editor = New TableEditor.Editor()
        Me.panelButtons = New TableEditor.UIStyleControl()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnAdv = New System.Windows.Forms.Button()
        Me.myMenu = New System.Windows.Forms.MainMenu()
        Me.mmEditor = New System.Windows.Forms.MenuItem()
        Me.mmViewProp = New TableEditor.GradientMenu()
        Me.mmClose = New TableEditor.GradientMenu()
        Me.mmTable = New System.Windows.Forms.MenuItem()
        Me.mmUndo = New TableEditor.GradientMenu()
        Me.mmRedo = New TableEditor.GradientMenu()
        Me.mmAddRow = New TableEditor.GradientMenu()
        Me.mmAddRowBefore = New System.Windows.Forms.MenuItem()
        Me.mmAddRowAfter = New System.Windows.Forms.MenuItem()
        Me.mmAddCell = New TableEditor.GradientMenu()
        Me.mmAddCellBefore = New System.Windows.Forms.MenuItem()
        Me.mmAddCellAfter = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New TableEditor.GradientMenu()
        Me.mmRemoveRow = New TableEditor.GradientMenu()
        Me.mmRemoveCell = New TableEditor.GradientMenu()
        Me.MenuItem5 = New TableEditor.GradientMenu()
        Me.mmProperties = New TableEditor.GradientMenu()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.colPanel = New TableEditor.CollapsiblePanel()
        Me.tbCoolbar = New AppBasic.Coolbar()
        Me.mainPanel.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Controls.AddRange(New System.Windows.Forms.Control() {Me.editor, Me.panelButtons})
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 40)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(565, 518)
        Me.mainPanel.TabIndex = 1
        '
        'editor
        '
        Me.editor.AutoScroll = True
        Me.editor.Location = New System.Drawing.Point(32, 16)
        Me.editor.Name = "editor"
        Me.editor.Renderer = Nothing
        Me.editor.Size = New System.Drawing.Size(428, 456)
        Me.editor.TabIndex = 0
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.SystemColors.Control
        Me.panelButtons.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHelp, Me.btnCancel, Me.btnOK, Me.btnAdv})
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 478)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(565, 40)
        Me.panelButtons.TabIndex = 1
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(8, 8)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(469, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(373, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'btnAdv
        '
        Me.btnAdv.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdv.Location = New System.Drawing.Point(104, 8)
        Me.btnAdv.Name = "btnAdv"
        Me.btnAdv.TabIndex = 0
        Me.btnAdv.Text = "Advanced"
        '
        'myMenu
        '
        Me.myMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmEditor, Me.mmTable})
        '
        'mmEditor
        '
        Me.mmEditor.Index = 0
        Me.mmEditor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmViewProp, Me.mmClose})
        Me.mmEditor.Text = "&Editor"
        '
        'mmViewProp
        '
        Me.mmViewProp.Index = 0
        Me.mmViewProp.OwnerDraw = True
        Me.mmViewProp.Text = "View Properties"
        '
        'mmClose
        '
        Me.mmClose.Index = 1
        Me.mmClose.OwnerDraw = True
        Me.mmClose.Text = "&Close"
        '
        'mmTable
        '
        Me.mmTable.Index = 1
        Me.mmTable.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmUndo, Me.mmRedo, Me.mmAddRow, Me.mmAddCell, Me.MenuItem6, Me.mmRemoveRow, Me.mmRemoveCell, Me.MenuItem5, Me.mmProperties})
        Me.mmTable.Text = "&Table"
        '
        'mmUndo
        '
        Me.mmUndo.Index = 0
        Me.mmUndo.OwnerDraw = True
        Me.mmUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.mmUndo.Text = "Undo"
        '
        'mmRedo
        '
        Me.mmRedo.Index = 1
        Me.mmRedo.OwnerDraw = True
        Me.mmRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.mmRedo.Text = "Redo"
        '
        'mmAddRow
        '
        Me.mmAddRow.Index = 2
        Me.mmAddRow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmAddRowBefore, Me.mmAddRowAfter})
        Me.mmAddRow.OwnerDraw = True
        Me.mmAddRow.Text = "Add row"
        '
        'mmAddRowBefore
        '
        Me.mmAddRowBefore.Index = 0
        Me.mmAddRowBefore.Text = "Before"
        '
        'mmAddRowAfter
        '
        Me.mmAddRowAfter.Index = 1
        Me.mmAddRowAfter.Text = "After"
        '
        'mmAddCell
        '
        Me.mmAddCell.Index = 3
        Me.mmAddCell.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmAddCellBefore, Me.mmAddCellAfter})
        Me.mmAddCell.OwnerDraw = True
        Me.mmAddCell.Text = "Add cell"
        '
        'mmAddCellBefore
        '
        Me.mmAddCellBefore.Index = 0
        Me.mmAddCellBefore.Text = "Before"
        '
        'mmAddCellAfter
        '
        Me.mmAddCellAfter.Index = 1
        Me.mmAddCellAfter.Text = "After"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.OwnerDraw = True
        Me.MenuItem6.Text = "-"
        '
        'mmRemoveRow
        '
        Me.mmRemoveRow.Index = 5
        Me.mmRemoveRow.OwnerDraw = True
        Me.mmRemoveRow.Text = "Remove row"
        '
        'mmRemoveCell
        '
        Me.mmRemoveCell.Index = 6
        Me.mmRemoveCell.OwnerDraw = True
        Me.mmRemoveCell.Text = "Remove cell"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 7
        Me.MenuItem5.OwnerDraw = True
        Me.MenuItem5.Text = "-"
        '
        'mmProperties
        '
        Me.mmProperties.Index = 8
        Me.mmProperties.OwnerDraw = True
        Me.mmProperties.Text = "&Properties"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(565, 40)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 518)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'colPanel
        '
        Me.colPanel.Description = ""
        Me.colPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.colPanel.InnerControl = Nothing
        Me.colPanel.Location = New System.Drawing.Point(568, 40)
        Me.colPanel.MaxHeight = 0
        Me.colPanel.MaxWidth = 0
        Me.colPanel.Name = "colPanel"
        Me.colPanel.Size = New System.Drawing.Size(168, 518)
        Me.colPanel.TabIndex = 4
        Me.colPanel.Visible = False
        '
        'tbCoolbar
        '
        Me.tbCoolbar.Band1Image = Nothing
        Me.tbCoolbar.Band2Image = Nothing
        Me.tbCoolbar.Band3Image = Nothing
        Me.tbCoolbar.BandHeight = 0
        Me.tbCoolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbCoolbar.DontDrawShadow = False
        Me.tbCoolbar.DrawBottomLine = False
        Me.tbCoolbar.MaxVerticalBands = 1
        Me.tbCoolbar.Name = "tbCoolbar"
        Me.tbCoolbar.Size = New System.Drawing.Size(736, 40)
        Me.tbCoolbar.TabIndex = 0
        '
        'MainTableEditor
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(736, 558)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.mainPanel, Me.Splitter1, Me.colPanel, Me.tbCoolbar})
        Me.Menu = Me.myMenu
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "MainTableEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Editor"
        Me.mainPanel.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property Translations() As System.Collections.Specialized.StringDictionary
        Get
            Return trans
        End Get
        Set(ByVal Value As System.Collections.Specialized.StringDictionary)
            trans = Value
            TranslationTable.SetTranslationTable(trans)
        End Set
    End Property

    Public Property DefaultCellFont() As Font
        Get
            Return myFont
        End Get
        Set(ByVal Value As Font)
            myFont = Value
        End Set
    End Property

    Public Property DefaultCellTextColor() As Color
        Get
            Return myColor
        End Get
        Set(ByVal Value As Color)
            myColor = Value
        End Set
    End Property

    Public Property AlwaysOnTop() As Boolean 
        Get
            Return mbooAlwaysOnTop
        End Get
        Set(ByVal Value As Boolean)
            mbooAlwaysOnTop = Value
            Me.TopMost = Value
        End Set
    End Property

    Public Function GetHTML() As String
        Dim stringWriter As New System.IO.StringWriter()
        Dim textWriter As New System.Web.UI.HtmlTextWriter(stringWriter)
        editor.Renderer.RenderedTable.GenerateHTML(textWriter)

        Return stringWriter.ToString()
    End Function

    Public Function GetPlainText() As String
        Dim stringWriter As New System.IO.StringWriter()
        editor.Renderer.RenderedTable.GeneratePlainText(stringWriter)

        Return stringWriter.ToString()
    End Function

    Public Function GetImage(ByVal imageId As String) As Bitmap
        ' Prefix T = 0
        '        G = 1
        imageId = imageId.Replace("T", "0")
        imageId = imageId.Replace("t", "0")
        imageId = imageId.Replace("G", "1")
        imageId = imageId.Replace("g", "1")

        ' Create the bitmap
        Dim img As New Bitmap(editor.panelTable.Width, editor.panelTable.Height)
        Dim g As Graphics = Graphics.FromImage(img)
        ' Render the table to the bitmap
        editor.Renderer.RenderTo(editor.panelTable, g, False)
        g.Dispose()

        ' Add the id to the image
        ' Fill the begining with 0s
        Dim data(15) As Integer
        Dim startCount As Integer = 15 - imageId.ToString.Length
        Dim i As Integer 
        For i = 0 To startCount - 1
            data(i) = 0
        Next
        For i = startCount To 14
            data(i) = Integer.Parse(imageId.ToString().Chars(i - startCount))
        Next

        ' Cycle through the 5 pixels that will contain the number (5 pixels x 3 components(rgb) = 15)
        For i = 0 To 4
            Dim orig As Color = img.GetPixel(i, img.Height - 1)

            'Dim red As Integer = (orig.R And (240 << 4)) + data(i * 3)
            'Dim green As Integer = (orig.G And (240 << 4)) + data(i * 3 + 1)
            'Dim blue As Integer = (orig.B And (240 << 4)) + data(i * 3 + 2)

            Dim red As Integer = (orig.R And 240) + data(i * 3)
            Dim green As Integer = (orig.G And 240) + data(i * 3 + 1)
            Dim blue As Integer = (orig.B And 240) + data(i * 3 + 2)
            img.SetPixel(i, img.Height - 1, Color.FromArgb(red, green, blue))

            img.SetPixel(i, img.Height - 1, Color.FromArgb(red, green, blue))

        Next

        Return img

    End Function

    Public Shared Function GetIdFromImage(ByVal img As Bitmap) As String
        Dim id As String = ""
        Try
            ' Cycle through the 5 pixels that will contain the number (5 pixels x 3 components(rgb) = 15)


            Dim i As Integer 

            For i = 0 To 4
                Dim orig As Color = img.GetPixel(i, img.Height - 1)

                Dim red As Integer = orig.R And 15
                Dim green As Integer = orig.G And 15
                Dim blue As Integer = orig.B And 15

                id += red.ToString
                id += green.ToString
                id += blue.ToString
            Next
            If id.Chars(0) = "0" Then
                Return "T" + id.Substring(1)
            ElseIf id.Chars(0) = "1" Then
                Return "G" + id.Substring(1)
            Else
                Return id
            End If
        Catch
            MessageBox.Show("Error trying to parse: " + id)
            Return 0
        End Try
    End Function

#End Region

    Public Shadows Function ShowDialog() As DialogResult
        If lbooDoOnce = False Then
            lbooDoOnce = True

            Dim IRes As Integer

            IRes = GetWrittenCRC(AppExe)

            Dim lstrDetails(2) As String
            Dim lstrRetVal3 As String

            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "kLU;ZKTKZFRKUZv?nnZ<TQN;UGZ<EGU;VZX?AZF?RUZ<JHK;SHY;MZR?YGZ<XUW;KMU;ZW"
            lstrDetails(2) = "KKHHE;JFU;VNZ@JNU;YGU;ZHUKMQLKGFY;NNZ<FRU;ZJHKKSH;YMY<mpmP"


            lstrRetVal3 = Decrypt(lstrDetails)

            If IRes = 1 Then
                '
            ElseIf IRes = -1 Then
                If mbooAlwaysOnTop = True Then Me.Activate()
            Else
                If mbooAlwaysOnTop = True Then Me.Activate()
            End If

        End If

        If myTable Is Nothing Then
            Dim tabDim As New DefineTable()

            If tabDim.ShowDialog(Me) = DialogResult.OK Then
                ' Create the table
                myTable = New Table()

                ' Set table attributes
                myTable.BackgroundColor = Color.White
                myTable.BorderSize = 1
                myTable.BorderColor = Color.White
                myTable.CellPadding = 0
                myTable.CellSpacing = 0
                myTable.DefaultCellFont = myFont
                myTable.DefaultCellColor = Color.White
                myTable.DefaultTextColor = myColor

                ' Add the rows and cells
                Dim i As Integer 
                For i = 1 To tabDim.Rows
                    Dim row As New Row()
                    Dim j As Integer 
                    For j = 1 To tabDim.Columns
                        Dim cell As New Cell()
                        ' Set cell attributes
                        cell.BorderColor = Color.Black
                        cell.BackgroundColor = Color.White
                        cell.AssociatedControl.ForeColor = myColor
                        cell.AssociatedControl.Font = myFont
                        row.Cells.Add(cell)
                    Next
                    myTable.Rows.Add(row)
                Next
            Else
                Me.DialogResult = DialogResult.Cancel
                Return Me.DialogResult
            End If
        End If


        propGrid.SelectedObject = myTable



        Dim render As New Renderer(myTable)
        editor.Renderer = render
        render.Rebuild()
        'Refresh()

        ' Set the translations
        btnOK.Text = TranslationTable.GetTranslation("buttonok")
        btnCancel.Text = TranslationTable.GetTranslation("buttoncancel")
        btnAdv.Text = TranslationTable.GetTranslation("buttonadvanced")
        btnHelp.Text = TranslationTable.GetTranslation("buttonhelp")
        Me.Text = TranslationTable.GetTranslation("formeditor")

        AddCoolbar() 

        UndoRedo.Clear()

        Return MyBase.ShowDialog()
    End Function

    Private Sub TableEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If lbooDoOnce = False Then
        '    lbooDoOnce = True

        '    Dim IRes As Integer

        '    IRes = GetWrittenCRC(AppExe)

        '    Dim lstrDetails(2) As String
        '    Dim lstrRetVal3 As String

        '    lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        '    lstrDetails(1) = "kLU;ZKTKZFRKUZv?nnZ<TQN;UGZ<EGU;VZX?AZF?RUZ<JHK;SHY;MZR?YGZ<XUW;KMU;ZW"
        '    lstrDetails(2) = "KKHHE;JFU;VNZ@JNU;YGU;ZHUKMQLKGFY;NNZ<FRU;ZJHKKSH;YMY<mpmP"


        '    lstrRetVal3 = Decrypt(lstrDetails)

        '    If IRes = 1 Then
        '        '
        '    ElseIf IRes = -1 Then
        '        'Busy(False)
        '        If mbooAlwaysOnTop = True Then Me.Activate()
        '        'NOTE mstrCaption should be being passed in as mentioned in feedback point 22
        '        'MessageBox.Show(lstrRetVal3, mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        'Me.Close()
        '        'Exit Sub

        '    Else
        '        If mbooAlwaysOnTop = True Then Me.Activate()
        '        'MessageBox.Show(lstrRetVal3, mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        'Me.Close()
        '        'Exit Sub
        '    End If

        'End If

        'If myTable Is Nothing Then
        '    Dim tabDim As New DefineTable()

        '    If tabDim.ShowDialog(Me) = DialogResult.OK Then
        '        ' Create the table
        '        myTable = New Table()

        '        ' Set table attributes
        '        myTable.BackgroundColor = Color.White
        '        myTable.BorderSize = 1
        '        myTable.BorderColor = Color.White
        '        myTable.CellPadding = 0
        '        myTable.CellSpacing = 0
        '        myTable.DefaultCellFont = myFont
        '        myTable.DefaultCellColor = Color.White
        '        myTable.DefaultTextColor = myColor

        '        ' Add the rows and cells
        '        Dim i As Integer 
        '        For i = 1 To tabDim.Rows
        '            Dim row As New Row()
        '            Dim j As Integer 
        '            For j = 1 To tabDim.Columns
        '                Dim cell As New Cell()
        '                ' Set cell attributes
        '                cell.BorderColor = Color.Black
        '                cell.BackgroundColor = Color.White
        '                cell.AssociatedControl.ForeColor = myColor
        '                cell.AssociatedControl.Font = myFont
        '                row.Cells.Add(cell)
        '            Next
        '            myTable.Rows.Add(row)
        '        Next
        '    Else
        '        Me.DialogResult = DialogResult.Cancel
        '        Close()
        '        Exit Sub
        '    End If
        'End If


        'propGrid.SelectedObject = myTable



        'Dim render As New Renderer(myTable)
        'editor.Renderer = render
        'render.Rebuild()
        ''Refresh()

        '' Set the translations
        'btnOK.Text = TranslationTable.GetTranslation("buttonok")
        'btnCancel.Text = TranslationTable.GetTranslation("buttoncancel")
        'btnAdv.Text = TranslationTable.GetTranslation("buttonadvanced")
        'btnHelp.Text = TranslationTable.GetTranslation("buttonhelp")
        'Me.Text = TranslationTable.GetTranslation("formeditor")

        'AddCoolbar() 

        'UndoRedo.Clear()
    End Sub

    Function RunInstanceMethod(ByVal t As System.Type, ByVal strMethod As String, ByVal objInstance As Object, ByVal aobjParams As Object()) As Object
        Dim eFlags As BindingFlags = BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic
        Return RunMethod(t, strMethod, objInstance, aobjParams, eFlags)
    End Function

    Function RunMethod(ByVal t As System.Type, ByVal strMethod As String, ByVal objInstance As Object, ByVal aobjParams As Object(), ByVal eFlags As BindingFlags) As Object
        Dim m As MethodInfo
        Try
            m = t.GetMethod(strMethod, eFlags)
            If m Is Nothing Then
                Throw New ArgumentException("There is no method �" + strMethod + "� for type �" + t.ToString() + "�.")
            End If
            Dim objRet As Object = m.Invoke(objInstance, aobjParams)
            Return objRet
        Catch
            Throw
        End Try
    End Function

    Sub SetDescriptionWindowSize(ByVal size As Integer)
        Dim controlsProp As PropertyInfo = propGrid.[GetType]().GetProperty("Controls")
        Dim cc As Control.ControlCollection = DirectCast(controlsProp.GetValue(propGrid, Nothing), Control.ControlCollection)
        Dim c As Control 
        For Each c In cc
            Dim controlType As Type = c.[GetType]()
            If controlType.Name = "DocComment" Then
                Dim linesProperty As PropertyInfo = controlType.GetProperty("Lines")
                linesProperty.SetValue(c, size, Nothing)
                Dim userSizedField As FieldInfo = controlType.BaseType.GetField("userSized", BindingFlags.Instance Or BindingFlags.NonPublic)
                userSizedField.SetValue(c, True)
                Exit For
            End If
        Next
    End Sub

    Public Sub SetPropertyGridColumnWidth(ByVal namesColumn As Integer, ByVal valuesColumns As Integer)
        colPanel.Width = namesColumn + valuesColumns
        Dim propertyGridView As Control = propGrid.Controls(1)
        Dim propertyGridViewType As Type = propertyGridView.[GetType]()
        'RunInstanceMethod(propertyGridViewType, "MoveSplitterTo", propertyGridView, New Object() {valuesColumns})
    End Sub

    Private Sub editor_SelectedCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles editor.SelectedObjectChanged
        propGrid.SelectedObject = sender
        If TypeOf (sender) Is Cell Then
            Dim cell As Cell = CType(sender, Cell)
            colPanel.Description = "Row " + (cell.AssociatedNode.row + 1).ToString + " x Column " + (cell.AssociatedNode.cell + 1).ToString
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Cut")).Enabled = False
            'tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Copy")).Enabled = False
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Paste")).Enabled = True
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Font Style")).Enabled = True
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Font Colour")).Enabled = True
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Insert Graphic")).Enabled = True
        Else
            colPanel.Focus()
            colPanel.Description = "Table"
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Cut")).Enabled = False
            'tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Copy")).Enabled = False
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Paste")).Enabled = False
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Font Style")).Enabled = False
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Font Colour")).Enabled = False
            tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Insert Graphic")).Enabled = False

        End If

    End Sub

    Private Sub mmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmClose.Click
        Close()
    End Sub

    Private Sub mmProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmProperties.Click
        editor_SelectedCellChanged(editor.Renderer.RenderedTable, EventArgs.Empty)
    End Sub

    Private Sub mmViewProp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmViewProp.Click
        If Not colPanel.Visible Then
            Me.Width += colPanel.Width
            Me.MinimumSize = New Size(Me.MinimumSize.Width + colPanel.Width, Me.MinimumSize.Height)
        End If
        colPanel.Visible = Not colPanel.Visible
        mmViewProp.Checked = colPanel.Visible
        editor.cmProperties.Visible = Not colPanel.Visible
        If Not colPanel.Visible Then
            Me.MinimumSize = New Size(Me.MinimumSize.Width - colPanel.Width, Me.MinimumSize.Height)
            Me.Width -= colPanel.Width
        End If
    End Sub

    Private Sub btnAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdv.Click
        mmViewProp.PerformClick()
        If colPanel.Visible Then
            btnAdv.Text = TranslationTable.GetTranslation("buttonbasic")
        Else
            btnAdv.Text = TranslationTable.GetTranslation("buttonadvanced")
        End If
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub editor_SelectionLengthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles editor.SelectionLengthChanged
        If TypeOf (editor.SelectedCell) Is Cell Then
            Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
            If rtl.SelectionLength = 0 Then
                tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Cut")).Enabled = False
            Else
                tbCoolbar.Bands(0).Buttons.Item(GetBtnIdx("Cut")).Enabled = True
            End If

        End If
    End Sub

    Private Sub mmUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmUndo.Click
        If UndoRedo.CanUndo Then
            UndoRedo.PerformUndo()
        End If
    End Sub

    Private Sub mmRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmRedo.Click
        If UndoRedo.CanRedo Then
            UndoRedo.PerformRedo()
        End If
    End Sub

    Private Sub MainTableEditor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        
        If lbooLoadDataNow = True Then
            lbooLoadDataNow = False

        End If
        
    End Sub

    Private Sub MainTableEditor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        colPanel.MaxWidth = Me.Width - 400

        
        If lbooLoadDataNow = False Then
            tbCoolbar.Invalidate()
            tbCoolbar.Bands(0).Invalidate()
            tbCoolbar.Bands(0).Width = getToolbarwidths()
        End If
        



    End Sub

    Private Function getToolbarwidths() As Integer

        Dim ThisWidth As Integer
        Dim noBars As Integer
        For noBars = 0 To tbCoolbar.Bands(0).Buttons.Count - 1

            If noBars = 0 And tbCoolbar.Bands(0).Buttons(noBars).Style = ToolBarButtonStyle.Separator Then
                'do nothing, allow drag
            Else

                ThisWidth += tbCoolbar.Bands(0).Buttons(noBars).Rectangle.Width 'p

            End If
        Next

        Return ThisWidth + 5

    End Function

    Private Function GetBtnIdx(ByVal pstrTag As String) As Integer
        

        Dim lintArrInc As Integer

        For lintArrInc = 0 To tbCoolbar.Bands(0).Buttons.Count
            If Not tbCoolbar.Bands(0).Buttons.Item(lintArrInc).Tag Is Nothing Then
                If CStr(tbCoolbar.Bands(0).Buttons.Item(lintArrInc).Tag).ToUpper = pstrTag.ToUpper Then
                    GetBtnIdx = lintArrInc
                    Exit Function
                End If
            End If
        Next

    End Function
    Private Sub AddCoolbar()
        

        tbCoolbar.AddBandEvents(0)

        tbCoolbar.MaxVerticalBands = 1
        tbCoolbar.PopulateContextMenu()

        tbCoolbar.DontDrawShadow = False


        tbCoolbar.Bands(0).Top = 0
        tbCoolbar.Bands(0).Left = 0
        tbCoolbar.Bands(0).InitialLocation = New Point(0, 0)
        tbCoolbar.Top = 0
        tbCoolbar.Left = 0
        tbCoolbar.DrawBottomLine = True 

        Dim BlankButton As New ToolBarButton()
        BlankButton.Enabled = False

        Dim Res As New IPIconsPack.Resource()
        tbCoolbar.SetImageListForBand(0, Res.ilToolButtons256)
        tbCoolbar.Bands(0).Name = "Standard"
        tbCoolbar.Bands(0).Tag = LangText.GetString("Pad_mnuViewToolbar1").Replace("&", "")

        With tbCoolbar.Bands(0).Buttons
            .AddRange(New ToolBarButton() { _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipCut"), IconIdent.Cut, "Cut"), _
            CreateButton(LangText.GetString("Pad_TlbrTipCopy"), IconIdent.Copy, "Copy"), _
            CreateButton(LangText.GetString("Pad_TlbrTipPaste"), IconIdent.Paste, "Paste"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipUndo"), IconIdent.Undo, "Undo"), _
            CreateButton(LangText.GetString("Pad_TlbrTipRedo"), IconIdent.Redo, "Redo"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipSpelling"), IconIdent.Spelling, "Spelling"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipInsertGraphic"), IconIdent.InsertGraphics, "Insert Graphic"), _
            CreateButton(LangText.GetString("Pad_TlbrTipFontStyle"), IconIdent.FontSytle, "Font style"), _
            CreateButton(LangText.GetString("Pad_TlbrTipFontColour"), IconIdent.FontColour, "Font Colour")})
        End With

        tbCoolbar.Bands(0).Width = getToolbarwidths()

        '   tbCoolbar.Bands(0).AutoSize = True
        tbCoolbar.BandHeight = tbCoolbar.Bands(0).Height + 8

    End Sub

    Private Sub tbCoolbar_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByVal BandIdx As Integer) Handles tbCoolbar.ButtonClick

        '
        Select Case e.Button.Tag
            Case "Cut"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmCut.PerformClick()
                End If

            Case "Copy"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmCopy.PerformClick()
                End If

            Case "Paste"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmPaste.PerformClick()
                End If

            Case "Undo"
                mmUndo.PerformClick()
                Refresh()

            Case "Redo"
                mmRedo.PerformClick()
                Refresh()

            Case "Spelling"
                ' Iterate through each cell
                Dim tableRow As Row 
                For Each tableRow In myTable.Rows
                    Dim rowCell As Cell 
                    For Each rowCell In tableRow.Cells
                        Dim text As String = rowCell.Text

                        ' Do the spell check


                    Next
                Next

            Case "Insert Graphic"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmInsertImage.PerformClick()
                End If

            Case "Font style"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmFont.PerformClick()
                End If

            Case "Font Colour"
                If TypeOf (editor.SelectedCell) Is Cell Then
                    Dim rtl As RichTextLabel = editor.SelectedCell.AssociatedControl
                    rtl.mmColor.PerformClick()
                End If

        End Select
    End Sub

    Private Sub mmAddCellAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmAddCellAfter.Click
        editor.SetSelectedAsContext()
        editor.cmAddCellAfter.PerformClick()
    End Sub

    Private Sub mmAddCellBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmAddCellBefore.Click
        editor.SetSelectedAsContext()
        editor.cmAddCellBefore.PerformClick()
    End Sub

    Private Sub mmAddRowBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmAddRowBefore.Click
        editor.SetSelectedAsContext()
        editor.cmAddRowBefore.PerformClick()
    End Sub

    Private Sub mmAddRowAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmAddRowAfter.Click
        editor.SetSelectedAsContext()
        editor.cmAddRowAfter.PerformClick()
    End Sub

    Private Sub mmRemoveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmRemoveRow.Click
        editor.SetSelectedAsContext()
        editor.cmRemoveRow.PerformClick()
    End Sub

    Private Sub mmRemoveCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmRemoveCell.Click
        editor.SetSelectedAsContext()
        editor.cmRemoveCell.PerformClick()
    End Sub
End Class

