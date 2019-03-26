Imports System.Drawing.Printing
Friend Class SelectivePrint
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Friend Sub New()
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As ExRichTextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents chkHeaders As System.Windows.Forms.CheckBox
    Friend WithEvents btnOutput As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectivePrint))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New WinOnly.ExRichTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkHeaders = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.AccessibleDescription = CType(resources.GetObject("TreeView1.AccessibleDescription"), String)
        Me.TreeView1.AccessibleName = CType(resources.GetObject("TreeView1.AccessibleName"), String)
        Me.TreeView1.Anchor = CType(resources.GetObject("TreeView1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackgroundImage = CType(resources.GetObject("TreeView1.BackgroundImage"), System.Drawing.Image)
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = CType(resources.GetObject("TreeView1.Dock"), System.Windows.Forms.DockStyle)
        Me.TreeView1.Enabled = CType(resources.GetObject("TreeView1.Enabled"), Boolean)
        Me.TreeView1.Font = CType(resources.GetObject("TreeView1.Font"), System.Drawing.Font)
        Me.TreeView1.ImageIndex = CType(resources.GetObject("TreeView1.ImageIndex"), Integer)
        Me.TreeView1.ImeMode = CType(resources.GetObject("TreeView1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TreeView1.Indent = CType(resources.GetObject("TreeView1.Indent"), Integer)
        Me.TreeView1.ItemHeight = CType(resources.GetObject("TreeView1.ItemHeight"), Integer)
        Me.TreeView1.Location = CType(resources.GetObject("TreeView1.Location"), System.Drawing.Point)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.PathSeparator = "~"
        Me.TreeView1.RightToLeft = CType(resources.GetObject("TreeView1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TreeView1.SelectedImageIndex = CType(resources.GetObject("TreeView1.SelectedImageIndex"), Integer)
        Me.TreeView1.Size = CType(resources.GetObject("TreeView1.Size"), System.Drawing.Size)
        Me.TreeView1.TabIndex = CType(resources.GetObject("TreeView1.TabIndex"), Integer)
        Me.TreeView1.Text = resources.GetString("TreeView1.Text")
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'btnOutput
        '
        Me.btnOutput.AccessibleDescription = CType(resources.GetObject("btnOutput.AccessibleDescription"), String)
        Me.btnOutput.AccessibleName = CType(resources.GetObject("btnOutput.AccessibleName"), String)
        Me.btnOutput.Anchor = CType(resources.GetObject("btnOutput.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOutput.BackgroundImage = CType(resources.GetObject("btnOutput.BackgroundImage"), System.Drawing.Image)
        Me.btnOutput.Dock = CType(resources.GetObject("btnOutput.Dock"), System.Windows.Forms.DockStyle)
        Me.btnOutput.Enabled = CType(resources.GetObject("btnOutput.Enabled"), Boolean)
        Me.btnOutput.FlatStyle = CType(resources.GetObject("btnOutput.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnOutput.Font = CType(resources.GetObject("btnOutput.Font"), System.Drawing.Font)
        Me.btnOutput.Image = CType(resources.GetObject("btnOutput.Image"), System.Drawing.Image)
        Me.btnOutput.ImageAlign = CType(resources.GetObject("btnOutput.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnOutput.ImageIndex = CType(resources.GetObject("btnOutput.ImageIndex"), Integer)
        Me.btnOutput.ImeMode = CType(resources.GetObject("btnOutput.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnOutput.Location = CType(resources.GetObject("btnOutput.Location"), System.Drawing.Point)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.RightToLeft = CType(resources.GetObject("btnOutput.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnOutput.Size = CType(resources.GetObject("btnOutput.Size"), System.Drawing.Size)
        Me.btnOutput.TabIndex = CType(resources.GetObject("btnOutput.TabIndex"), Integer)
        Me.btnOutput.Text = resources.GetString("btnOutput.Text")
        Me.btnOutput.TextAlign = CType(resources.GetObject("btnOutput.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnOutput.Visible = CType(resources.GetObject("btnOutput.Visible"), Boolean)
        '
        'btnSelectAll
        '
        Me.btnSelectAll.AccessibleDescription = CType(resources.GetObject("btnSelectAll.AccessibleDescription"), String)
        Me.btnSelectAll.AccessibleName = CType(resources.GetObject("btnSelectAll.AccessibleName"), String)
        Me.btnSelectAll.Anchor = CType(resources.GetObject("btnSelectAll.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackgroundImage = CType(resources.GetObject("btnSelectAll.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectAll.Dock = CType(resources.GetObject("btnSelectAll.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSelectAll.Enabled = CType(resources.GetObject("btnSelectAll.Enabled"), Boolean)
        Me.btnSelectAll.FlatStyle = CType(resources.GetObject("btnSelectAll.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnSelectAll.Font = CType(resources.GetObject("btnSelectAll.Font"), System.Drawing.Font)
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.ImageAlign = CType(resources.GetObject("btnSelectAll.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnSelectAll.ImageIndex = CType(resources.GetObject("btnSelectAll.ImageIndex"), Integer)
        Me.btnSelectAll.ImeMode = CType(resources.GetObject("btnSelectAll.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSelectAll.Location = CType(resources.GetObject("btnSelectAll.Location"), System.Drawing.Point)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = CType(resources.GetObject("btnSelectAll.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSelectAll.Size = CType(resources.GetObject("btnSelectAll.Size"), System.Drawing.Size)
        Me.btnSelectAll.TabIndex = CType(resources.GetObject("btnSelectAll.TabIndex"), Integer)
        Me.btnSelectAll.Text = resources.GetString("btnSelectAll.Text")
        Me.btnSelectAll.TextAlign = CType(resources.GetObject("btnSelectAll.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnSelectAll.Visible = CType(resources.GetObject("btnSelectAll.Visible"), Boolean)
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = CType(resources.GetObject("btnCancel.AccessibleDescription"), String)
        Me.btnCancel.AccessibleName = CType(resources.GetObject("btnCancel.AccessibleName"), String)
        Me.btnCancel.Anchor = CType(resources.GetObject("btnCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Dock = CType(resources.GetObject("btnCancel.Dock"), System.Windows.Forms.DockStyle)
        Me.btnCancel.Enabled = CType(resources.GetObject("btnCancel.Enabled"), Boolean)
        Me.btnCancel.FlatStyle = CType(resources.GetObject("btnCancel.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnCancel.Font = CType(resources.GetObject("btnCancel.Font"), System.Drawing.Font)
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = CType(resources.GetObject("btnCancel.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.ImageIndex = CType(resources.GetObject("btnCancel.ImageIndex"), Integer)
        Me.btnCancel.ImeMode = CType(resources.GetObject("btnCancel.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnCancel.Location = CType(resources.GetObject("btnCancel.Location"), System.Drawing.Point)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = CType(resources.GetObject("btnCancel.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnCancel.Size = CType(resources.GetObject("btnCancel.Size"), System.Drawing.Size)
        Me.btnCancel.TabIndex = CType(resources.GetObject("btnCancel.TabIndex"), Integer)
        Me.btnCancel.Text = resources.GetString("btnCancel.Text")
        Me.btnCancel.TextAlign = CType(resources.GetObject("btnCancel.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.Visible = CType(resources.GetObject("btnCancel.Visible"), Boolean)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AccessibleDescription = CType(resources.GetObject("RichTextBox1.AccessibleDescription"), String)
        Me.RichTextBox1.AccessibleName = CType(resources.GetObject("RichTextBox1.AccessibleName"), String)
        Me.RichTextBox1.Anchor = CType(resources.GetObject("RichTextBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.AutoSize = CType(resources.GetObject("RichTextBox1.AutoSize"), Boolean)
        Me.RichTextBox1.BackgroundImage = CType(resources.GetObject("RichTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.RichTextBox1.BulletIndent = CType(resources.GetObject("RichTextBox1.BulletIndent"), Integer)
        Me.RichTextBox1.Dock = CType(resources.GetObject("RichTextBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.RichTextBox1.Enabled = CType(resources.GetObject("RichTextBox1.Enabled"), Boolean)
        Me.RichTextBox1.Font = CType(resources.GetObject("RichTextBox1.Font"), System.Drawing.Font)
        Me.RichTextBox1.ImeMode = CType(resources.GetObject("RichTextBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.RichTextBox1.Location = CType(resources.GetObject("RichTextBox1.Location"), System.Drawing.Point)
        Me.RichTextBox1.MaxLength = CType(resources.GetObject("RichTextBox1.MaxLength"), Integer)
        Me.RichTextBox1.Multiline = CType(resources.GetObject("RichTextBox1.Multiline"), Boolean)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RightMargin = CType(resources.GetObject("RichTextBox1.RightMargin"), Integer)
        Me.RichTextBox1.RightToLeft = CType(resources.GetObject("RichTextBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.RichTextBox1.ScrollBars = CType(resources.GetObject("RichTextBox1.ScrollBars"), System.Windows.Forms.RichTextBoxScrollBars)
        Me.RichTextBox1.Size = CType(resources.GetObject("RichTextBox1.Size"), System.Drawing.Size)
        Me.RichTextBox1.TabIndex = CType(resources.GetObject("RichTextBox1.TabIndex"), Integer)
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.Visible = CType(resources.GetObject("RichTextBox1.Visible"), Boolean)
        Me.RichTextBox1.WordWrap = CType(resources.GetObject("RichTextBox1.WordWrap"), Boolean)
        Me.RichTextBox1.ZoomFactor = CType(resources.GetObject("RichTextBox1.ZoomFactor"), Single)
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = resources.GetString("SaveFileDialog1.Title")
        '
        'chkHeaders
        '
        Me.chkHeaders.AccessibleDescription = CType(resources.GetObject("chkHeaders.AccessibleDescription"), String)
        Me.chkHeaders.AccessibleName = CType(resources.GetObject("chkHeaders.AccessibleName"), String)
        Me.chkHeaders.Anchor = CType(resources.GetObject("chkHeaders.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkHeaders.Appearance = CType(resources.GetObject("chkHeaders.Appearance"), System.Windows.Forms.Appearance)
        Me.chkHeaders.BackgroundImage = CType(resources.GetObject("chkHeaders.BackgroundImage"), System.Drawing.Image)
        Me.chkHeaders.CheckAlign = CType(resources.GetObject("chkHeaders.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkHeaders.Checked = True
        Me.chkHeaders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeaders.Dock = CType(resources.GetObject("chkHeaders.Dock"), System.Windows.Forms.DockStyle)
        Me.chkHeaders.Enabled = CType(resources.GetObject("chkHeaders.Enabled"), Boolean)
        Me.chkHeaders.FlatStyle = CType(resources.GetObject("chkHeaders.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkHeaders.Font = CType(resources.GetObject("chkHeaders.Font"), System.Drawing.Font)
        Me.chkHeaders.Image = CType(resources.GetObject("chkHeaders.Image"), System.Drawing.Image)
        Me.chkHeaders.ImageAlign = CType(resources.GetObject("chkHeaders.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkHeaders.ImageIndex = CType(resources.GetObject("chkHeaders.ImageIndex"), Integer)
        Me.chkHeaders.ImeMode = CType(resources.GetObject("chkHeaders.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkHeaders.Location = CType(resources.GetObject("chkHeaders.Location"), System.Drawing.Point)
        Me.chkHeaders.Name = "chkHeaders"
        Me.chkHeaders.RightToLeft = CType(resources.GetObject("chkHeaders.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkHeaders.Size = CType(resources.GetObject("chkHeaders.Size"), System.Drawing.Size)
        Me.chkHeaders.TabIndex = CType(resources.GetObject("chkHeaders.TabIndex"), Integer)
        Me.chkHeaders.Text = resources.GetString("chkHeaders.Text")
        Me.chkHeaders.TextAlign = CType(resources.GetObject("chkHeaders.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkHeaders.Visible = CType(resources.GetObject("chkHeaders.Visible"), Boolean)
        '
        'SelectivePrint
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkHeaders, Me.RichTextBox1, Me.btnCancel, Me.btnSelectAll, Me.btnOutput, Me.TreeView1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "SelectivePrint"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 

    Private StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic")) 

    Dim WithEvents m_PrintRichTextDocument As RichTextPrintDocument
    Dim mstrIndexArray() As TreeTopics
    Dim lintIndexCounter As Integer
    Dim mstrOutputType As OutputTypes
    Friend Enum OutputTypes
        Export
        Print
    End Enum
    Friend Property OutputType() As OutputTypes
        Get
            Return mstrOutputType
        End Get
        Set(ByVal Value As OutputTypes)
            mstrOutputType = Value
        End Set
    End Property
    Friend Enum SelectiveOutputType
        PlainText
        RichText
        XML
    End Enum
    'Dim mFileTypeStreamType As RichTextBoxStreamType 
    Dim mFileTypeStreamType As SelectiveOutputType 

    Friend Property FileTypeStreamType() As SelectiveOutputType 'RichTextBoxStreamType 
        Get
            Return mFileTypeStreamType
        End Get
        Set(ByVal Value As SelectiveOutputType) ' RichTextBoxStreamType)
            mFileTypeStreamType = Value
        End Set
    End Property
    Dim mDisables As PopulateTreeDisables = main.PopulateTreeDisables.NoDisables 
    Friend Property Disables() As PopulateTreeDisables 
        Get
            Return mDisables
        End Get
        Set(ByVal Value As PopulateTreeDisables)
            mDisables = Value
        End Set
    End Property
    Private Sub SelectivePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnCancel.FlatStyle = FlatStyle.System
            btnSelectAll.FlatStyle = FlatStyle.System
            btnOutput.FlatStyle = FlatStyle.System
        End If 
        'chkHeaders.FlatStyle = FlatStyle.System
        SetBackcolors() 

        
        Select Case mstrOutputType
            Case OutputTypes.Export
                'Me.Text = NameMe("Selective RTF Export")
                If mFileTypeStreamType = SelectiveOutputType.XML Then 
                    Me.Text = NameMe(LangText.GetString("SelPrint_ExportCaption")).Replace("RTF", "XML Outliner") 
                Else 
                    
                    Me.Text = NameMe(LangText.GetString("SelPrint_ExportCaption"))
                End If 
                'TODO: This could say rtf or text base on option, but it is rtf!
                'btnOutput.Text = "&Export"
                
                btnOutput.Text = LangText.GetString("SelPrint_ButtonExport")

                'chkHeaders.Text = "Show topic / branch names in file"
                
                chkHeaders.Text = LangText.GetString("SelPrint_ChkExport")


            Case OutputTypes.Print
                'Me.Text = NameMe("Selective RTF Print")
                
                Me.Text = NameMe(LangText.GetString("SelPrint_PrintCaption"))

                'btnOutput.Text = "&Print"
                
                btnOutput.Text = LangText.GetString("SelPrint_ButtonPrint")

                'chkHeaders.Text = "Show topic / branch names on print out"
                
                chkHeaders.Text = LangText.GetString("SelPrint_ChkPrint")

        End Select
        

        Busy(Me, True)
        BusyButtons(True) 
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder, mDisables)
        Busy(Me, False)
        BusyButtons(False) 
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click

        Busy(Me, True)
        BusyButtons(True) 
        'TreeView1.Nodes.Clear()

        'If btnSelectAll.Text <> "C&lear All" Then
        
        If btnSelectAll.Text <> LangText.GetString("SelPrint_ButtonClearAll") Then

            PopulateTree(TreeView1, mstrIndexArray, Me, True, gstrSortOrder, mDisables)
            'btnSelectAll.Text = "C&lear All"
            
            btnSelectAll.Text = LangText.GetString("SelPrint_ButtonClearAll")

        Else
            PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder, mDisables)
            'btnSelectAll.Text = "Select &All"
            
            btnSelectAll.Text = LangText.GetString("SelPrint_ButtonSelectAll")

        End If
        Busy(Me, False)
        BusyButtons(False) 
    End Sub
    Private Sub btnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutput.Click

        
        Select Case mstrOutputType
            Case OutputTypes.Export
                Export()
            Case OutputTypes.Print
                Print()
        End Select
        
    End Sub
    Friend Sub Print()
        Dim lintArrInc As Integer
        Dim lstrNodePath As String

        Busy(Me, True)
        BusyButtons(True) 
        RichTextBox1.SelectedRtf = ""
        RichTextBox1.Rtf = ""

        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ' Allocate enough space to indicate that ALL nodes are checked.
        cNodes = TreeView1.GetNodeCount(True)

        If cNodes = 0 Then 
            Busy(Me, False)
            BusyButtons(False) 
            Exit Sub
        End If

        ReDim ndxs(cNodes)
        GetNodes(TreeView1.Nodes(0), ndxs, curNode, True)

        ' Shrink the array to just the # of selected nodes.
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            'Diagnostics.Debug.WriteLine("Node: " & n.Text & " is Checked")
            BuildRTFPrint(RichTextBox1, n, chkHeaders.Checked)
        Next
        '--------

        
        If RichTextBox1.Text.Length = 0 Then
            Busy(Me, False)
            BusyButtons(False)
            If gbooAlwaysOnTop = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("Export_MustSelSomething"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        

        Dim PrintResult As DialogResult

        m_PrintRichTextDocument = New RichTextPrintDocument(RichTextBox1)
        m_PrintRichTextDocument.DefaultPageSettings = m_PageSettings

        With PrintDialog1
            .Document = m_PrintRichTextDocument
            If RichTextBox1.SelectionLength > 0 Then
                .AllowSelection = True
            End If
            Busy(Me, False)
            BusyButtons(False) 
            PrintResult = .ShowDialog

            If PrintResult = DialogResult.OK Then
                Busy(Me, True)
                BusyButtons(True) 
                If .PrinterSettings.PrintRange.Selection = PrintRange.Selection Then
                    m_PrintRichTextDocument.PrintSelectedTextOnly = True
                End If

                m_PrintRichTextDocument.Print()
            End If
        End With
        Busy(Me, False)
        BusyButtons(False) 
        Me.Close() 
    End Sub
    Friend Sub Export()
        Dim lintArrInc As Integer
        Dim lstrNodePath As String

        Busy(Me, True)
        BusyButtons(True) 
        RichTextBox1.SelectedRtf = ""
        RichTextBox1.Rtf = ""

        Select Case mFileTypeStreamType 
            Case SelectiveOutputType.PlainText, SelectiveOutputType.RichText
                Dim n As TreeNode
                Dim cNodes As Integer
                Dim ndxs() As TreeNode
                Dim curNode As Integer = -1

                ' Allocate enough space to indicate that ALL nodes are checked.
                cNodes = TreeView1.GetNodeCount(True)

                If cNodes = 0 Then 
                    Busy(Me, False)
                    BusyButtons(False) 
                    Exit Sub
                End If

                ReDim ndxs(cNodes)
                GetNodes(TreeView1.Nodes(0), ndxs, curNode, True)

                ' Shrink the array to just the # of selected nodes.
                ReDim Preserve ndxs(curNode)
                For Each n In ndxs
                    'Diagnostics.Debug.WriteLine("Node: " & n.Text & " is Checked")
                    BuildRTFPrint(RichTextBox1, n, chkHeaders.Checked)

                Next n

            Case SelectiveOutputType.XML 
                
                Dim lAllTemplateFields() As TemplateFields
                If mFileTypeStreamType = SelectiveOutputType.XML Then
                    ProduceAllTemplateFieldArray(Me, lAllTemplateFields)
                End If
                

                'BuildRTFXMLOutput(RichTextBox1, n, chkHeaders.Checked, lAllTemplateFields, lintEndsTopicRequired) 
                RichTextBox1.SelectedText = WriteTreeView(TreeView1, RichTextBox1, chkHeaders.Checked, lAllTemplateFields) 
        End Select

        '--------
        Busy(Me, False)
        BusyButtons(False) 

        
        If RichTextBox1.Text.Length = 0 Then
            If gbooAlwaysOnTop = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("Export_MustSelSomething"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        

        With SaveFileDialog1
            .CheckPathExists = True
            
            Select Case mFileTypeStreamType
                Case SelectiveOutputType.RichText 
                    .DefaultExt = "rtf"
                Case SelectiveOutputType.PlainText 
                    .DefaultExt = "txt"
                Case SelectiveOutputType.XML 
                    .DefaultExt = "xml" 
            End Select
            

            '.FileName = "Project"
            
            .FileName = LangText.GetString("SelPrint_ExportFileName")

            .AddExtension = True
            '.Filter = "Rich text file| (*.rtf)"
            '.Filter = "Rich text file (*.rtf)|*.rtf"
            

            
            '.Filter = LangText.GetString("SelPrint_ExportFilter")
            Select Case mFileTypeStreamType
                Case SelectiveOutputType.RichText 
                    .Filter = StandLangText.GetString("StandText_RTFFilter")
                Case SelectiveOutputType.PlainText 
                    .Filter = StandLangText.GetString("StandText_TXTFilter")
                Case SelectiveOutputType.XML 
                    .Filter = StandLangText.GetString("StandText_XMLFilter") 
            End Select
            

            '.Title = "Now specify the Information Base file!"
            
            'this is incorrect!!
            ''.Title = LangText.GetString("SelPrint_ExportFileCaption").Replace("[Program]", gProgName)
            .RestoreDirectory = True 

            Dim dlgresult As DialogResult 
            dlgresult = .ShowDialog()

            
            If dlgresult <> DialogResult.OK Then
                Exit Sub
            End If
            

            If SaveFileDialog1.FileName <> "" Then
                
                'RichTextBox1.SaveFile(.FileName)
                Select Case mFileTypeStreamType
                    Case SelectiveOutputType.RichText 
                        RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.RichText)
                    Case SelectiveOutputType.PlainText 
                        RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText)
                    Case SelectiveOutputType.XML 

                        '
                        'RichTextBox1.SelectionStart = 0

                        'RichTextBox1.SelectedText = "<Ideaspad_All_Data>" & CR()
                        'RichTextBox1.SelectionStart = RichTextBox1.TextLength

                        'RichTextBox1.SelectedText = "</Ideaspad_All_Data>" & CR()
                        '

                        RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText) 
                End Select
                
            Else 
                Exit Sub 
            End If
        End With
        Me.Close() 

        If gbooAlwaysOnTop = True Then Me.Activate() 
        
        MessageBox.Show(LangText.GetString("TempEx_CreatedSuccess"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub SelectivePrint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnCancel.Enabled = pbool
        btnOutput.Enabled = pbool
        btnSelectAll.Enabled = pbool
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnSelectAll.BackColor = Color.FromArgb(0, btnSelectAll.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        chkHeaders.BackColor = Color.FromArgb(0, chkHeaders.BackColor)
        btnOutput.BackColor = Color.FromArgb(0, btnOutput.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        If IsAboveOrEqualWinXp() = False Then : chkHeaders.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkHeaders.Top, chkHeaders.Left, chkHeaders.Width, chkHeaders.Height) : End If 

    End Sub

    Private Sub SelectivePrint_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub TreeView1_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeCheck

        If mDisables = main.PopulateTreeDisables.DisableTemplateTopics Then
            If e.Node.ForeColor.Equals(SystemColors.GrayText) Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("Export_CannotSelThisTopic"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If

    End Sub
End Class