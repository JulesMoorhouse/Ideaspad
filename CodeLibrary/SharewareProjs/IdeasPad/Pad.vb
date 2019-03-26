Imports System.Drawing.Printing
Imports mshtml
Imports System.IO
Imports IPIconsPack
Imports AppBasic
<Obfuscate()> Public Class frmPad 'changed to public, added Obfuscate
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
    Friend WithEvents RichTextBox1 As WinOnly.ExRichTextBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ContextMenuAddGroup As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuItemAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemRename As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSelectivePrint As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditCut As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditCopy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditPaste As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditRedo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditUndo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents mnuItemDelete As System.Windows.Forms.MenuItem
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ContextMenuRTFRightClick As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRTFUndo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFCut As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFCopy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFPaste As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpBuy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileNewRoot As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpGettingStarted As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpStartup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpLicense As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSupport As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mnuHelpCFU As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpTipDay As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTools As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsOptions As System.Windows.Forms.MenuItem
    Friend WithEvents RichTextBox2 As WinOnly.ExRichTextBox
    Friend WithEvents mnuFileNewBranch As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFFont As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFilePrint As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNodeDrag As System.Windows.Forms.ContextMenu
    Friend WithEvents ctmNDCopyHere As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDMoveHere As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDLinkHere As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDCancel As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemProperties As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsRefresh As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDCopyBranchHere As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDLinkBranchHere As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemDeleteBranches As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFilePageSetup As System.Windows.Forms.MenuItem
    Friend WithEvents ctmNDMoveBranchHere As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsExpandAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsCollapseAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindReplace As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBookmarks As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBookmarksAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBookmarksRemove As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileImportRTF As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuItemAddBookmark As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFImportRTF As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As AppBasic.ProgressStatusBar
    Friend WithEvents ProgresPanel As AppBasic.ProgressPanel
    Friend WithEvents SystemStatusPanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents RightMostPanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnNewBranch As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnRedo As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuEditFindTopic As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsSpelling As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents AxWebBrowser1 As WinOnly.WebOCHostCtrl
    Friend WithEvents mnuTemplates As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplatesSelect As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplatesSep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplateToRTF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindTemplateTopic As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileImport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileImportWizard As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportTempData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportWizard As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenuHTML As System.Windows.Forms.ContextMenu
    Friend WithEvents ContextMenuHTMLView As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenuHTMLPrint As System.Windows.Forms.MenuItem
    Friend WithEvents txtFieldLine As System.Windows.Forms.TextBox
    Friend WithEvents mnuTemplatesOrganise As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemTemplate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemSetAsStartup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpTopics As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportRTF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplatesRapidEntry As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSubscribe As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpEnterCode As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplateTextSize As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplateTextSizeLarger As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTemplateTextSizeSmaller As System.Windows.Forms.MenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents mnuRTFInsertGrpahics As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFBullets As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpInstallPack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemMoveToRoot As System.Windows.Forms.MenuItem
    Friend WithEvents ctmHighlight As System.Windows.Forms.ContextMenu

    Friend WithEvents mnuItemMoveBranchDown As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemMoveBranchUp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemMoveBranchTop As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemMoveBranchBottom As System.Windows.Forms.MenuItem
    Friend WithEvents menuEnhancer As WinOnly.EnhancedMenu
    Friend WithEvents tbCoolbar As AppBasic.Coolbar
    Friend WithEvents cboFontName As System.Windows.Forms.ComboBox
    Friend WithEvents cboFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents mnuView As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbars As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbarReset As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents cboSearchTool As System.Windows.Forms.ComboBox
    Friend WithEvents mnuInsert As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormat As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewWordWrap As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewAlwaysOnTop As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertDateTime As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertSymbol As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertBullets As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertGraphics As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertLinkToFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertHyperlink As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertQuickLink As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatFont As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatChangeCase As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatBackground As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatChangeCaseUpper As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatChangeCaseLower As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatChangeCaseProper As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatChangeCaseToggle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportTXT As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileImportTXT As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportTempDataXML As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExportTempNRtfData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpReportProblem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemExpandAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemCollapseAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTFRedo As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel 
    Friend WithEvents mnuRTFEditTable As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInsertTable As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPad))
        Me.RichTextBox1 = New WinOnly.ExRichTextBox()
        Me.ContextMenuRTFRightClick = New System.Windows.Forms.ContextMenu()
        Me.mnuRTFUndo = New System.Windows.Forms.MenuItem()
        Me.mnuRTFRedo = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuRTFCut = New System.Windows.Forms.MenuItem()
        Me.mnuRTFCopy = New System.Windows.Forms.MenuItem()
        Me.mnuRTFPaste = New System.Windows.Forms.MenuItem()
        Me.mnuRTFDelete = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.mnuRTFFont = New System.Windows.Forms.MenuItem()
        Me.mnuRTFBullets = New System.Windows.Forms.MenuItem()
        Me.mnuRTFImportRTF = New System.Windows.Forms.MenuItem()
        Me.mnuRTFEditTable = New System.Windows.Forms.MenuItem()
        Me.mnuRTFInsertGrpahics = New System.Windows.Forms.MenuItem()
        Me.mnuRTFSelectAll = New System.Windows.Forms.MenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuAddGroup = New System.Windows.Forms.ContextMenu()
        Me.mnuItemAdd = New System.Windows.Forms.MenuItem()
        Me.mnuItemTemplate = New System.Windows.Forms.MenuItem()
        Me.mnuItemRename = New System.Windows.Forms.MenuItem()
        Me.mnuItemDelete = New System.Windows.Forms.MenuItem()
        Me.mnuItemDeleteBranches = New System.Windows.Forms.MenuItem()
        Me.mnuItemMoveToRoot = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.mnuItemMoveBranchTop = New System.Windows.Forms.MenuItem()
        Me.mnuItemMoveBranchUp = New System.Windows.Forms.MenuItem()
        Me.mnuItemMoveBranchDown = New System.Windows.Forms.MenuItem()
        Me.mnuItemMoveBranchBottom = New System.Windows.Forms.MenuItem()
        Me.mnuItemExpandAll = New System.Windows.Forms.MenuItem()
        Me.mnuItemCollapseAll = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.mnuItemAddBookmark = New System.Windows.Forms.MenuItem()
        Me.mnuItemSetAsStartup = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.mnuItemProperties = New System.Windows.Forms.MenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileNewRoot = New System.Windows.Forms.MenuItem()
        Me.mnuFileNewBranch = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuFileImport = New System.Windows.Forms.MenuItem()
        Me.mnuFileImportRTF = New System.Windows.Forms.MenuItem()
        Me.mnuFileImportTXT = New System.Windows.Forms.MenuItem()
        Me.mnuFileImportWizard = New System.Windows.Forms.MenuItem()
        Me.mnuFileExport = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportTempData = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportTempDataXML = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportRTF = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportTXT = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportWizard = New System.Windows.Forms.MenuItem()
        Me.mnuFileExportTempNRtfData = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.mnuFilePageSetup = New System.Windows.Forms.MenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.MenuItem()
        Me.mnuFileSelectivePrint = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditUndo = New System.Windows.Forms.MenuItem()
        Me.mnuEditRedo = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuEditCut = New System.Windows.Forms.MenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.MenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.MenuItem()
        Me.mnuEditDelete = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.mnuEditSelectAll = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindReplace = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindTopic = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindTemplateTopic = New System.Windows.Forms.MenuItem()
        Me.mnuView = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbars = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbar1 = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbar2 = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbar3 = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbar4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.mnuViewToolbarReset = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.mnuViewWordWrap = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.mnuViewAlwaysOnTop = New System.Windows.Forms.MenuItem()
        Me.mnuInsert = New System.Windows.Forms.MenuItem()
        Me.mnuInsertDateTime = New System.Windows.Forms.MenuItem()
        Me.mnuInsertSymbol = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.mnuInsertBullets = New System.Windows.Forms.MenuItem()
        Me.mnuInsertGraphics = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.mnuInsertLinkToFile = New System.Windows.Forms.MenuItem()
        Me.mnuInsertQuickLink = New System.Windows.Forms.MenuItem()
        Me.mnuInsertHyperlink = New System.Windows.Forms.MenuItem()
        Me.mnuFormat = New System.Windows.Forms.MenuItem()
        Me.mnuFormatFont = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.mnuFormatChangeCase = New System.Windows.Forms.MenuItem()
        Me.mnuFormatChangeCaseUpper = New System.Windows.Forms.MenuItem()
        Me.mnuFormatChangeCaseLower = New System.Windows.Forms.MenuItem()
        Me.mnuFormatChangeCaseProper = New System.Windows.Forms.MenuItem()
        Me.mnuFormatChangeCaseToggle = New System.Windows.Forms.MenuItem()
        Me.mnuFormatBackground = New System.Windows.Forms.MenuItem()
        Me.mnuBookmarks = New System.Windows.Forms.MenuItem()
        Me.mnuTemplates = New System.Windows.Forms.MenuItem()
        Me.mnuTemplatesSelect = New System.Windows.Forms.MenuItem()
        Me.mnuTemplatesOrganise = New System.Windows.Forms.MenuItem()
        Me.mnuTemplatesRapidEntry = New System.Windows.Forms.MenuItem()
        Me.mnuTemplateToRTF = New System.Windows.Forms.MenuItem()
        Me.mnuTemplateTextSize = New System.Windows.Forms.MenuItem()
        Me.mnuTemplateTextSizeLarger = New System.Windows.Forms.MenuItem()
        Me.mnuTemplateTextSizeSmaller = New System.Windows.Forms.MenuItem()
        Me.mnuTemplatesSep = New System.Windows.Forms.MenuItem()
        Me.mnuTools = New System.Windows.Forms.MenuItem()
        Me.mnuToolsSpelling = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnuToolsRefresh = New System.Windows.Forms.MenuItem()
        Me.mnuToolsExpandAll = New System.Windows.Forms.MenuItem()
        Me.mnuToolsCollapseAll = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.mnuToolsOptions = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpTopics = New System.Windows.Forms.MenuItem()
        Me.mnuHelpGettingStarted = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpStartup = New System.Windows.Forms.MenuItem()
        Me.mnuHelpCFU = New System.Windows.Forms.MenuItem()
        Me.mnuHelpInstallPack = New System.Windows.Forms.MenuItem()
        Me.mnuHelpSupport = New System.Windows.Forms.MenuItem()
        Me.mnuHelpReportProblem = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBuy = New System.Windows.Forms.MenuItem()
        Me.mnuHelpTipDay = New System.Windows.Forms.MenuItem()
        Me.mnuHelpSubscribe = New System.Windows.Forms.MenuItem()
        Me.mnuHelpEnterCode = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpLicense = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.mnuBookmarksAdd = New System.Windows.Forms.MenuItem()
        Me.mnuBookmarksRemove = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox2 = New WinOnly.ExRichTextBox()
        Me.StatusBar1 = New AppBasic.ProgressStatusBar()
        Me.SystemStatusPanel = New System.Windows.Forms.StatusBarPanel()
        Me.AxWebBrowser1 = New WinOnly.WebOCHostCtrl()
        Me.txtFieldLine = New System.Windows.Forms.TextBox()
        Me.cboFontName = New System.Windows.Forms.ComboBox()
        Me.cboFontSize = New System.Windows.Forms.ComboBox()
        Me.tbCoolbar = New AppBasic.Coolbar()
        Me.cboSearchTool = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ctmNodeDrag = New System.Windows.Forms.ContextMenu()
        Me.ctmNDCopyHere = New System.Windows.Forms.MenuItem()
        Me.ctmNDMoveHere = New System.Windows.Forms.MenuItem()
        Me.ctmNDLinkHere = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.ctmNDCopyBranchHere = New System.Windows.Forms.MenuItem()
        Me.ctmNDMoveBranchHere = New System.Windows.Forms.MenuItem()
        Me.ctmNDLinkBranchHere = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.ctmNDCancel = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnNewBranch = New System.Windows.Forms.ToolBarButton()
        Me.btnRedo = New System.Windows.Forms.ToolBarButton()
        Me.ContextMenuHTML = New System.Windows.Forms.ContextMenu()
        Me.ContextMenuHTMLView = New System.Windows.Forms.MenuItem()
        Me.ContextMenuHTMLPrint = New System.Windows.Forms.MenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ctmHighlight = New System.Windows.Forms.ContextMenu()
        Me.menuEnhancer = New WinOnly.EnhancedMenu(Me.components)
        Me.mnuInsertTable = New System.Windows.Forms.MenuItem()
        CType(Me.SystemStatusPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.AccessibleDescription = CType(resources.GetObject("RichTextBox1.AccessibleDescription"), String)
        Me.RichTextBox1.AccessibleName = CType(resources.GetObject("RichTextBox1.AccessibleName"), String)
        Me.RichTextBox1.AllowDrop = True
        Me.RichTextBox1.Anchor = CType(resources.GetObject("RichTextBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.AutoSize = CType(resources.GetObject("RichTextBox1.AutoSize"), Boolean)
        Me.RichTextBox1.AutoWordSelection = True
        Me.RichTextBox1.BackgroundImage = CType(resources.GetObject("RichTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.RichTextBox1.BulletIndent = CType(resources.GetObject("RichTextBox1.BulletIndent"), Integer)
        Me.RichTextBox1.ContextMenu = Me.ContextMenuRTFRightClick
        Me.RichTextBox1.Dock = CType(resources.GetObject("RichTextBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.RichTextBox1.Enabled = CType(resources.GetObject("RichTextBox1.Enabled"), Boolean)
        Me.RichTextBox1.Font = CType(resources.GetObject("RichTextBox1.Font"), System.Drawing.Font)
        Me.RichTextBox1.ImeMode = CType(resources.GetObject("RichTextBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.RichTextBox1.Location = CType(resources.GetObject("RichTextBox1.Location"), System.Drawing.Point)
        Me.RichTextBox1.MaxLength = CType(resources.GetObject("RichTextBox1.MaxLength"), Integer)
        Me.RichTextBox1.Multiline = CType(resources.GetObject("RichTextBox1.Multiline"), Boolean)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightMargin = CType(resources.GetObject("RichTextBox1.RightMargin"), Integer)
        Me.RichTextBox1.RightToLeft = CType(resources.GetObject("RichTextBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.RichTextBox1.ScrollBars = CType(resources.GetObject("RichTextBox1.ScrollBars"), System.Windows.Forms.RichTextBoxScrollBars)
        Me.RichTextBox1.Size = CType(resources.GetObject("RichTextBox1.Size"), System.Drawing.Size)
        Me.RichTextBox1.TabIndex = CType(resources.GetObject("RichTextBox1.TabIndex"), Integer)
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.ToolTip1.SetToolTip(Me.RichTextBox1, resources.GetString("RichTextBox1.ToolTip"))
        Me.RichTextBox1.Visible = CType(resources.GetObject("RichTextBox1.Visible"), Boolean)
        Me.RichTextBox1.WordWrap = CType(resources.GetObject("RichTextBox1.WordWrap"), Boolean)
        Me.RichTextBox1.ZoomFactor = CType(resources.GetObject("RichTextBox1.ZoomFactor"), Single)
        '
        'ContextMenuRTFRightClick
        '
        Me.ContextMenuRTFRightClick.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRTFUndo, Me.mnuRTFRedo, Me.MenuItem2, Me.mnuRTFCut, Me.mnuRTFCopy, Me.mnuRTFPaste, Me.mnuRTFDelete, Me.MenuItem12, Me.mnuRTFFont, Me.mnuRTFBullets, Me.mnuRTFImportRTF, Me.mnuRTFEditTable, Me.mnuRTFInsertGrpahics, Me.mnuRTFSelectAll})
        Me.ContextMenuRTFRightClick.RightToLeft = CType(resources.GetObject("ContextMenuRTFRightClick.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuRTFUndo
        '
        Me.mnuRTFUndo.Enabled = CType(resources.GetObject("mnuRTFUndo.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFUndo, -1)
        Me.mnuRTFUndo.Index = 0
        Me.mnuRTFUndo.OwnerDraw = True
        Me.mnuRTFUndo.Shortcut = CType(resources.GetObject("mnuRTFUndo.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFUndo.ShowShortcut = CType(resources.GetObject("mnuRTFUndo.ShowShortcut"), Boolean)
        Me.mnuRTFUndo.Text = resources.GetString("mnuRTFUndo.Text")
        Me.mnuRTFUndo.Visible = CType(resources.GetObject("mnuRTFUndo.Visible"), Boolean)
        '
        'mnuRTFRedo
        '
        Me.mnuRTFRedo.Enabled = CType(resources.GetObject("mnuRTFRedo.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFRedo, -1)
        Me.mnuRTFRedo.Index = 1
        Me.mnuRTFRedo.OwnerDraw = True
        Me.mnuRTFRedo.Shortcut = CType(resources.GetObject("mnuRTFRedo.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFRedo.ShowShortcut = CType(resources.GetObject("mnuRTFRedo.ShowShortcut"), Boolean)
        Me.mnuRTFRedo.Text = resources.GetString("mnuRTFRedo.Text")
        Me.mnuRTFRedo.Visible = CType(resources.GetObject("mnuRTFRedo.Visible"), Boolean)
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = CType(resources.GetObject("MenuItem2.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem2, -1)
        Me.MenuItem2.Index = 2
        Me.MenuItem2.OwnerDraw = True
        Me.MenuItem2.Shortcut = CType(resources.GetObject("MenuItem2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem2.ShowShortcut = CType(resources.GetObject("MenuItem2.ShowShortcut"), Boolean)
        Me.MenuItem2.Text = resources.GetString("MenuItem2.Text")
        Me.MenuItem2.Visible = CType(resources.GetObject("MenuItem2.Visible"), Boolean)
        '
        'mnuRTFCut
        '
        Me.mnuRTFCut.Enabled = CType(resources.GetObject("mnuRTFCut.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFCut, -1)
        Me.mnuRTFCut.Index = 3
        Me.mnuRTFCut.OwnerDraw = True
        Me.mnuRTFCut.Shortcut = CType(resources.GetObject("mnuRTFCut.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFCut.ShowShortcut = CType(resources.GetObject("mnuRTFCut.ShowShortcut"), Boolean)
        Me.mnuRTFCut.Text = resources.GetString("mnuRTFCut.Text")
        Me.mnuRTFCut.Visible = CType(resources.GetObject("mnuRTFCut.Visible"), Boolean)
        '
        'mnuRTFCopy
        '
        Me.mnuRTFCopy.Enabled = CType(resources.GetObject("mnuRTFCopy.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFCopy, -1)
        Me.mnuRTFCopy.Index = 4
        Me.mnuRTFCopy.OwnerDraw = True
        Me.mnuRTFCopy.Shortcut = CType(resources.GetObject("mnuRTFCopy.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFCopy.ShowShortcut = CType(resources.GetObject("mnuRTFCopy.ShowShortcut"), Boolean)
        Me.mnuRTFCopy.Text = resources.GetString("mnuRTFCopy.Text")
        Me.mnuRTFCopy.Visible = CType(resources.GetObject("mnuRTFCopy.Visible"), Boolean)
        '
        'mnuRTFPaste
        '
        Me.mnuRTFPaste.Enabled = CType(resources.GetObject("mnuRTFPaste.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFPaste, -1)
        Me.mnuRTFPaste.Index = 5
        Me.mnuRTFPaste.OwnerDraw = True
        Me.mnuRTFPaste.Shortcut = CType(resources.GetObject("mnuRTFPaste.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFPaste.ShowShortcut = CType(resources.GetObject("mnuRTFPaste.ShowShortcut"), Boolean)
        Me.mnuRTFPaste.Text = resources.GetString("mnuRTFPaste.Text")
        Me.mnuRTFPaste.Visible = CType(resources.GetObject("mnuRTFPaste.Visible"), Boolean)
        '
        'mnuRTFDelete
        '
        Me.mnuRTFDelete.Enabled = CType(resources.GetObject("mnuRTFDelete.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFDelete, -1)
        Me.mnuRTFDelete.Index = 6
        Me.mnuRTFDelete.OwnerDraw = True
        Me.mnuRTFDelete.Shortcut = CType(resources.GetObject("mnuRTFDelete.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFDelete.ShowShortcut = CType(resources.GetObject("mnuRTFDelete.ShowShortcut"), Boolean)
        Me.mnuRTFDelete.Text = resources.GetString("mnuRTFDelete.Text")
        Me.mnuRTFDelete.Visible = CType(resources.GetObject("mnuRTFDelete.Visible"), Boolean)
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = CType(resources.GetObject("MenuItem12.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem12, -1)
        Me.MenuItem12.Index = 7
        Me.MenuItem12.OwnerDraw = True
        Me.MenuItem12.Shortcut = CType(resources.GetObject("MenuItem12.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem12.ShowShortcut = CType(resources.GetObject("MenuItem12.ShowShortcut"), Boolean)
        Me.MenuItem12.Text = resources.GetString("MenuItem12.Text")
        Me.MenuItem12.Visible = CType(resources.GetObject("MenuItem12.Visible"), Boolean)
        '
        'mnuRTFFont
        '
        Me.mnuRTFFont.Enabled = CType(resources.GetObject("mnuRTFFont.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFFont, -1)
        Me.mnuRTFFont.Index = 8
        Me.mnuRTFFont.OwnerDraw = True
        Me.mnuRTFFont.Shortcut = CType(resources.GetObject("mnuRTFFont.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFFont.ShowShortcut = CType(resources.GetObject("mnuRTFFont.ShowShortcut"), Boolean)
        Me.mnuRTFFont.Text = resources.GetString("mnuRTFFont.Text")
        Me.mnuRTFFont.Visible = CType(resources.GetObject("mnuRTFFont.Visible"), Boolean)
        '
        'mnuRTFBullets
        '
        Me.mnuRTFBullets.Enabled = CType(resources.GetObject("mnuRTFBullets.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFBullets, -1)
        Me.mnuRTFBullets.Index = 9
        Me.mnuRTFBullets.OwnerDraw = True
        Me.mnuRTFBullets.Shortcut = CType(resources.GetObject("mnuRTFBullets.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFBullets.ShowShortcut = CType(resources.GetObject("mnuRTFBullets.ShowShortcut"), Boolean)
        Me.mnuRTFBullets.Text = resources.GetString("mnuRTFBullets.Text")
        Me.mnuRTFBullets.Visible = CType(resources.GetObject("mnuRTFBullets.Visible"), Boolean)
        '
        'mnuRTFImportRTF
        '
        Me.mnuRTFImportRTF.Enabled = CType(resources.GetObject("mnuRTFImportRTF.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFImportRTF, -1)
        Me.mnuRTFImportRTF.Index = 10
        Me.mnuRTFImportRTF.OwnerDraw = True
        Me.mnuRTFImportRTF.Shortcut = CType(resources.GetObject("mnuRTFImportRTF.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFImportRTF.ShowShortcut = CType(resources.GetObject("mnuRTFImportRTF.ShowShortcut"), Boolean)
        Me.mnuRTFImportRTF.Text = resources.GetString("mnuRTFImportRTF.Text")
        Me.mnuRTFImportRTF.Visible = CType(resources.GetObject("mnuRTFImportRTF.Visible"), Boolean)
        '
        'mnuRTFEditTable
        '
        Me.mnuRTFEditTable.Enabled = CType(resources.GetObject("mnuRTFEditTable.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFEditTable, -1)
        Me.mnuRTFEditTable.Index = 11
        Me.mnuRTFEditTable.OwnerDraw = True
        Me.mnuRTFEditTable.Shortcut = CType(resources.GetObject("mnuRTFEditTable.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFEditTable.ShowShortcut = CType(resources.GetObject("mnuRTFEditTable.ShowShortcut"), Boolean)
        Me.mnuRTFEditTable.Text = resources.GetString("mnuRTFEditTable.Text")
        Me.mnuRTFEditTable.Visible = CType(resources.GetObject("mnuRTFEditTable.Visible"), Boolean)
        '
        'mnuRTFInsertGrpahics
        '
        Me.mnuRTFInsertGrpahics.Enabled = CType(resources.GetObject("mnuRTFInsertGrpahics.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFInsertGrpahics, -1)
        Me.mnuRTFInsertGrpahics.Index = 12
        Me.mnuRTFInsertGrpahics.OwnerDraw = True
        Me.mnuRTFInsertGrpahics.Shortcut = CType(resources.GetObject("mnuRTFInsertGrpahics.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFInsertGrpahics.ShowShortcut = CType(resources.GetObject("mnuRTFInsertGrpahics.ShowShortcut"), Boolean)
        Me.mnuRTFInsertGrpahics.Text = resources.GetString("mnuRTFInsertGrpahics.Text")
        Me.mnuRTFInsertGrpahics.Visible = CType(resources.GetObject("mnuRTFInsertGrpahics.Visible"), Boolean)
        '
        'mnuRTFSelectAll
        '
        Me.mnuRTFSelectAll.Enabled = CType(resources.GetObject("mnuRTFSelectAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFSelectAll, -1)
        Me.mnuRTFSelectAll.Index = 13
        Me.mnuRTFSelectAll.OwnerDraw = True
        Me.mnuRTFSelectAll.Shortcut = CType(resources.GetObject("mnuRTFSelectAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTFSelectAll.ShowShortcut = CType(resources.GetObject("mnuRTFSelectAll.ShowShortcut"), Boolean)
        Me.mnuRTFSelectAll.Text = resources.GetString("mnuRTFSelectAll.Text")
        Me.mnuRTFSelectAll.Visible = CType(resources.GetObject("mnuRTFSelectAll.Visible"), Boolean)
        '
        'TreeView1
        '
        Me.TreeView1.AccessibleDescription = CType(resources.GetObject("TreeView1.AccessibleDescription"), String)
        Me.TreeView1.AccessibleName = CType(resources.GetObject("TreeView1.AccessibleName"), String)
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Anchor = CType(resources.GetObject("TreeView1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackgroundImage = CType(resources.GetObject("TreeView1.BackgroundImage"), System.Drawing.Image)
        Me.TreeView1.ContextMenu = Me.ContextMenuAddGroup
        Me.TreeView1.Dock = CType(resources.GetObject("TreeView1.Dock"), System.Windows.Forms.DockStyle)
        Me.TreeView1.Enabled = CType(resources.GetObject("TreeView1.Enabled"), Boolean)
        Me.TreeView1.Font = CType(resources.GetObject("TreeView1.Font"), System.Drawing.Font)
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = CType(resources.GetObject("TreeView1.ImageIndex"), Integer)
        Me.TreeView1.ImeMode = CType(resources.GetObject("TreeView1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TreeView1.Indent = CType(resources.GetObject("TreeView1.Indent"), Integer)
        Me.TreeView1.ItemHeight = CType(resources.GetObject("TreeView1.ItemHeight"), Integer)
        Me.TreeView1.Location = CType(resources.GetObject("TreeView1.Location"), System.Drawing.Point)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.RightToLeft = CType(resources.GetObject("TreeView1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TreeView1.SelectedImageIndex = CType(resources.GetObject("TreeView1.SelectedImageIndex"), Integer)
        Me.TreeView1.Size = CType(resources.GetObject("TreeView1.Size"), System.Drawing.Size)
        Me.TreeView1.TabIndex = CType(resources.GetObject("TreeView1.TabIndex"), Integer)
        Me.TreeView1.Text = resources.GetString("TreeView1.Text")
        Me.ToolTip1.SetToolTip(Me.TreeView1, resources.GetString("TreeView1.ToolTip"))
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'ContextMenuAddGroup
        '
        Me.ContextMenuAddGroup.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemAdd, Me.mnuItemTemplate, Me.mnuItemRename, Me.mnuItemDelete, Me.mnuItemDeleteBranches, Me.mnuItemMoveToRoot, Me.MenuItem10, Me.mnuItemMoveBranchTop, Me.mnuItemMoveBranchUp, Me.mnuItemMoveBranchDown, Me.mnuItemMoveBranchBottom, Me.mnuItemExpandAll, Me.mnuItemCollapseAll, Me.MenuItem22, Me.mnuItemAddBookmark, Me.mnuItemSetAsStartup, Me.MenuItem18, Me.mnuItemProperties})
        Me.ContextMenuAddGroup.RightToLeft = CType(resources.GetObject("ContextMenuAddGroup.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuItemAdd
        '
        Me.mnuItemAdd.Enabled = CType(resources.GetObject("mnuItemAdd.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemAdd, -1)
        Me.mnuItemAdd.Index = 0
        Me.mnuItemAdd.OwnerDraw = True
        Me.mnuItemAdd.Shortcut = CType(resources.GetObject("mnuItemAdd.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemAdd.ShowShortcut = CType(resources.GetObject("mnuItemAdd.ShowShortcut"), Boolean)
        Me.mnuItemAdd.Text = resources.GetString("mnuItemAdd.Text")
        Me.mnuItemAdd.Visible = CType(resources.GetObject("mnuItemAdd.Visible"), Boolean)
        '
        'mnuItemTemplate
        '
        Me.mnuItemTemplate.Enabled = CType(resources.GetObject("mnuItemTemplate.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemTemplate, -1)
        Me.mnuItemTemplate.Index = 1
        Me.mnuItemTemplate.OwnerDraw = True
        Me.mnuItemTemplate.Shortcut = CType(resources.GetObject("mnuItemTemplate.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemTemplate.ShowShortcut = CType(resources.GetObject("mnuItemTemplate.ShowShortcut"), Boolean)
        Me.mnuItemTemplate.Text = resources.GetString("mnuItemTemplate.Text")
        Me.mnuItemTemplate.Visible = CType(resources.GetObject("mnuItemTemplate.Visible"), Boolean)
        '
        'mnuItemRename
        '
        Me.mnuItemRename.Enabled = CType(resources.GetObject("mnuItemRename.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemRename, -1)
        Me.mnuItemRename.Index = 2
        Me.mnuItemRename.OwnerDraw = True
        Me.mnuItemRename.Shortcut = CType(resources.GetObject("mnuItemRename.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemRename.ShowShortcut = CType(resources.GetObject("mnuItemRename.ShowShortcut"), Boolean)
        Me.mnuItemRename.Text = resources.GetString("mnuItemRename.Text")
        Me.mnuItemRename.Visible = CType(resources.GetObject("mnuItemRename.Visible"), Boolean)
        '
        'mnuItemDelete
        '
        Me.mnuItemDelete.Enabled = CType(resources.GetObject("mnuItemDelete.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemDelete, -1)
        Me.mnuItemDelete.Index = 3
        Me.mnuItemDelete.OwnerDraw = True
        Me.mnuItemDelete.Shortcut = CType(resources.GetObject("mnuItemDelete.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemDelete.ShowShortcut = CType(resources.GetObject("mnuItemDelete.ShowShortcut"), Boolean)
        Me.mnuItemDelete.Text = resources.GetString("mnuItemDelete.Text")
        Me.mnuItemDelete.Visible = CType(resources.GetObject("mnuItemDelete.Visible"), Boolean)
        '
        'mnuItemDeleteBranches
        '
        Me.mnuItemDeleteBranches.Enabled = CType(resources.GetObject("mnuItemDeleteBranches.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemDeleteBranches, -1)
        Me.mnuItemDeleteBranches.Index = 4
        Me.mnuItemDeleteBranches.OwnerDraw = True
        Me.mnuItemDeleteBranches.Shortcut = CType(resources.GetObject("mnuItemDeleteBranches.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemDeleteBranches.ShowShortcut = CType(resources.GetObject("mnuItemDeleteBranches.ShowShortcut"), Boolean)
        Me.mnuItemDeleteBranches.Text = resources.GetString("mnuItemDeleteBranches.Text")
        Me.mnuItemDeleteBranches.Visible = CType(resources.GetObject("mnuItemDeleteBranches.Visible"), Boolean)
        '
        'mnuItemMoveToRoot
        '
        Me.mnuItemMoveToRoot.Enabled = CType(resources.GetObject("mnuItemMoveToRoot.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveToRoot, -1)
        Me.mnuItemMoveToRoot.Index = 5
        Me.mnuItemMoveToRoot.OwnerDraw = True
        Me.mnuItemMoveToRoot.Shortcut = CType(resources.GetObject("mnuItemMoveToRoot.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemMoveToRoot.ShowShortcut = CType(resources.GetObject("mnuItemMoveToRoot.ShowShortcut"), Boolean)
        Me.mnuItemMoveToRoot.Text = resources.GetString("mnuItemMoveToRoot.Text")
        Me.mnuItemMoveToRoot.Visible = CType(resources.GetObject("mnuItemMoveToRoot.Visible"), Boolean)
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = CType(resources.GetObject("MenuItem10.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem10, -1)
        Me.MenuItem10.Index = 6
        Me.MenuItem10.OwnerDraw = True
        Me.MenuItem10.Shortcut = CType(resources.GetObject("MenuItem10.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem10.ShowShortcut = CType(resources.GetObject("MenuItem10.ShowShortcut"), Boolean)
        Me.MenuItem10.Text = resources.GetString("MenuItem10.Text")
        Me.MenuItem10.Visible = CType(resources.GetObject("MenuItem10.Visible"), Boolean)
        '
        'mnuItemMoveBranchTop
        '
        Me.mnuItemMoveBranchTop.Enabled = CType(resources.GetObject("mnuItemMoveBranchTop.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchTop, -1)
        Me.mnuItemMoveBranchTop.Index = 7
        Me.mnuItemMoveBranchTop.OwnerDraw = True
        Me.mnuItemMoveBranchTop.Shortcut = CType(resources.GetObject("mnuItemMoveBranchTop.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemMoveBranchTop.ShowShortcut = CType(resources.GetObject("mnuItemMoveBranchTop.ShowShortcut"), Boolean)
        Me.mnuItemMoveBranchTop.Text = resources.GetString("mnuItemMoveBranchTop.Text")
        Me.mnuItemMoveBranchTop.Visible = CType(resources.GetObject("mnuItemMoveBranchTop.Visible"), Boolean)
        '
        'mnuItemMoveBranchUp
        '
        Me.mnuItemMoveBranchUp.Enabled = CType(resources.GetObject("mnuItemMoveBranchUp.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchUp, -1)
        Me.mnuItemMoveBranchUp.Index = 8
        Me.mnuItemMoveBranchUp.OwnerDraw = True
        Me.mnuItemMoveBranchUp.Shortcut = CType(resources.GetObject("mnuItemMoveBranchUp.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemMoveBranchUp.ShowShortcut = CType(resources.GetObject("mnuItemMoveBranchUp.ShowShortcut"), Boolean)
        Me.mnuItemMoveBranchUp.Text = resources.GetString("mnuItemMoveBranchUp.Text")
        Me.mnuItemMoveBranchUp.Visible = CType(resources.GetObject("mnuItemMoveBranchUp.Visible"), Boolean)
        '
        'mnuItemMoveBranchDown
        '
        Me.mnuItemMoveBranchDown.Enabled = CType(resources.GetObject("mnuItemMoveBranchDown.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchDown, -1)
        Me.mnuItemMoveBranchDown.Index = 9
        Me.mnuItemMoveBranchDown.OwnerDraw = True
        Me.mnuItemMoveBranchDown.Shortcut = CType(resources.GetObject("mnuItemMoveBranchDown.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemMoveBranchDown.ShowShortcut = CType(resources.GetObject("mnuItemMoveBranchDown.ShowShortcut"), Boolean)
        Me.mnuItemMoveBranchDown.Text = resources.GetString("mnuItemMoveBranchDown.Text")
        Me.mnuItemMoveBranchDown.Visible = CType(resources.GetObject("mnuItemMoveBranchDown.Visible"), Boolean)
        '
        'mnuItemMoveBranchBottom
        '
        Me.mnuItemMoveBranchBottom.Enabled = CType(resources.GetObject("mnuItemMoveBranchBottom.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchBottom, -1)
        Me.mnuItemMoveBranchBottom.Index = 10
        Me.mnuItemMoveBranchBottom.OwnerDraw = True
        Me.mnuItemMoveBranchBottom.Shortcut = CType(resources.GetObject("mnuItemMoveBranchBottom.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemMoveBranchBottom.ShowShortcut = CType(resources.GetObject("mnuItemMoveBranchBottom.ShowShortcut"), Boolean)
        Me.mnuItemMoveBranchBottom.Text = resources.GetString("mnuItemMoveBranchBottom.Text")
        Me.mnuItemMoveBranchBottom.Visible = CType(resources.GetObject("mnuItemMoveBranchBottom.Visible"), Boolean)
        '
        'mnuItemExpandAll
        '
        Me.mnuItemExpandAll.Enabled = CType(resources.GetObject("mnuItemExpandAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemExpandAll, -1)
        Me.mnuItemExpandAll.Index = 11
        Me.mnuItemExpandAll.OwnerDraw = True
        Me.mnuItemExpandAll.Shortcut = CType(resources.GetObject("mnuItemExpandAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemExpandAll.ShowShortcut = CType(resources.GetObject("mnuItemExpandAll.ShowShortcut"), Boolean)
        Me.mnuItemExpandAll.Text = resources.GetString("mnuItemExpandAll.Text")
        Me.mnuItemExpandAll.Visible = CType(resources.GetObject("mnuItemExpandAll.Visible"), Boolean)
        '
        'mnuItemCollapseAll
        '
        Me.mnuItemCollapseAll.Enabled = CType(resources.GetObject("mnuItemCollapseAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemCollapseAll, -1)
        Me.mnuItemCollapseAll.Index = 12
        Me.mnuItemCollapseAll.OwnerDraw = True
        Me.mnuItemCollapseAll.Shortcut = CType(resources.GetObject("mnuItemCollapseAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemCollapseAll.ShowShortcut = CType(resources.GetObject("mnuItemCollapseAll.ShowShortcut"), Boolean)
        Me.mnuItemCollapseAll.Text = resources.GetString("mnuItemCollapseAll.Text")
        Me.mnuItemCollapseAll.Visible = CType(resources.GetObject("mnuItemCollapseAll.Visible"), Boolean)
        '
        'MenuItem22
        '
        Me.MenuItem22.Enabled = CType(resources.GetObject("MenuItem22.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem22, -1)
        Me.MenuItem22.Index = 13
        Me.MenuItem22.OwnerDraw = True
        Me.MenuItem22.Shortcut = CType(resources.GetObject("MenuItem22.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem22.ShowShortcut = CType(resources.GetObject("MenuItem22.ShowShortcut"), Boolean)
        Me.MenuItem22.Text = resources.GetString("MenuItem22.Text")
        Me.MenuItem22.Visible = CType(resources.GetObject("MenuItem22.Visible"), Boolean)
        '
        'mnuItemAddBookmark
        '
        Me.mnuItemAddBookmark.Enabled = CType(resources.GetObject("mnuItemAddBookmark.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemAddBookmark, -1)
        Me.mnuItemAddBookmark.Index = 14
        Me.mnuItemAddBookmark.OwnerDraw = True
        Me.mnuItemAddBookmark.Shortcut = CType(resources.GetObject("mnuItemAddBookmark.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemAddBookmark.ShowShortcut = CType(resources.GetObject("mnuItemAddBookmark.ShowShortcut"), Boolean)
        Me.mnuItemAddBookmark.Text = resources.GetString("mnuItemAddBookmark.Text")
        Me.mnuItemAddBookmark.Visible = CType(resources.GetObject("mnuItemAddBookmark.Visible"), Boolean)
        '
        'mnuItemSetAsStartup
        '
        Me.mnuItemSetAsStartup.Enabled = CType(resources.GetObject("mnuItemSetAsStartup.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemSetAsStartup, -1)
        Me.mnuItemSetAsStartup.Index = 15
        Me.mnuItemSetAsStartup.OwnerDraw = True
        Me.mnuItemSetAsStartup.Shortcut = CType(resources.GetObject("mnuItemSetAsStartup.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemSetAsStartup.ShowShortcut = CType(resources.GetObject("mnuItemSetAsStartup.ShowShortcut"), Boolean)
        Me.mnuItemSetAsStartup.Text = resources.GetString("mnuItemSetAsStartup.Text")
        Me.mnuItemSetAsStartup.Visible = CType(resources.GetObject("mnuItemSetAsStartup.Visible"), Boolean)
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = CType(resources.GetObject("MenuItem18.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem18, -1)
        Me.MenuItem18.Index = 16
        Me.MenuItem18.OwnerDraw = True
        Me.MenuItem18.Shortcut = CType(resources.GetObject("MenuItem18.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem18.ShowShortcut = CType(resources.GetObject("MenuItem18.ShowShortcut"), Boolean)
        Me.MenuItem18.Text = resources.GetString("MenuItem18.Text")
        Me.MenuItem18.Visible = CType(resources.GetObject("MenuItem18.Visible"), Boolean)
        '
        'mnuItemProperties
        '
        Me.mnuItemProperties.Enabled = CType(resources.GetObject("mnuItemProperties.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuItemProperties, -1)
        Me.mnuItemProperties.Index = 17
        Me.mnuItemProperties.OwnerDraw = True
        Me.mnuItemProperties.Shortcut = CType(resources.GetObject("mnuItemProperties.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuItemProperties.ShowShortcut = CType(resources.GetObject("mnuItemProperties.ShowShortcut"), Boolean)
        Me.mnuItemProperties.Text = resources.GetString("mnuItemProperties.Text")
        Me.mnuItemProperties.Visible = CType(resources.GetObject("mnuItemProperties.Visible"), Boolean)
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuInsert, Me.mnuFormat, Me.mnuBookmarks, Me.mnuTemplates, Me.mnuTools, Me.mnuHelp})
        Me.MainMenu1.RightToLeft = CType(resources.GetObject("MainMenu1.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuFile
        '
        Me.mnuFile.Enabled = CType(resources.GetObject("mnuFile.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFile, -1)
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNewRoot, Me.mnuFileNewBranch, Me.MenuItem5, Me.mnuFileImport, Me.mnuFileExport, Me.MenuItem16, Me.mnuFilePageSetup, Me.mnuFilePrint, Me.mnuFileSelectivePrint, Me.MenuItem3, Me.mnuFileExit})
        Me.mnuFile.OwnerDraw = True
        Me.mnuFile.Shortcut = CType(resources.GetObject("mnuFile.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFile.ShowShortcut = CType(resources.GetObject("mnuFile.ShowShortcut"), Boolean)
        Me.mnuFile.Text = resources.GetString("mnuFile.Text")
        Me.mnuFile.Visible = CType(resources.GetObject("mnuFile.Visible"), Boolean)
        '
        'mnuFileNewRoot
        '
        Me.mnuFileNewRoot.Enabled = CType(resources.GetObject("mnuFileNewRoot.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileNewRoot, -1)
        Me.mnuFileNewRoot.Index = 0
        Me.mnuFileNewRoot.OwnerDraw = True
        Me.mnuFileNewRoot.Shortcut = CType(resources.GetObject("mnuFileNewRoot.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileNewRoot.ShowShortcut = CType(resources.GetObject("mnuFileNewRoot.ShowShortcut"), Boolean)
        Me.mnuFileNewRoot.Text = resources.GetString("mnuFileNewRoot.Text")
        Me.mnuFileNewRoot.Visible = CType(resources.GetObject("mnuFileNewRoot.Visible"), Boolean)
        '
        'mnuFileNewBranch
        '
        Me.mnuFileNewBranch.Enabled = CType(resources.GetObject("mnuFileNewBranch.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileNewBranch, -1)
        Me.mnuFileNewBranch.Index = 1
        Me.mnuFileNewBranch.OwnerDraw = True
        Me.mnuFileNewBranch.Shortcut = CType(resources.GetObject("mnuFileNewBranch.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileNewBranch.ShowShortcut = CType(resources.GetObject("mnuFileNewBranch.ShowShortcut"), Boolean)
        Me.mnuFileNewBranch.Text = resources.GetString("mnuFileNewBranch.Text")
        Me.mnuFileNewBranch.Visible = CType(resources.GetObject("mnuFileNewBranch.Visible"), Boolean)
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = CType(resources.GetObject("MenuItem5.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem5, -1)
        Me.MenuItem5.Index = 2
        Me.MenuItem5.OwnerDraw = True
        Me.MenuItem5.Shortcut = CType(resources.GetObject("MenuItem5.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem5.ShowShortcut = CType(resources.GetObject("MenuItem5.ShowShortcut"), Boolean)
        Me.MenuItem5.Text = resources.GetString("MenuItem5.Text")
        Me.MenuItem5.Visible = CType(resources.GetObject("MenuItem5.Visible"), Boolean)
        '
        'mnuFileImport
        '
        Me.mnuFileImport.Enabled = CType(resources.GetObject("mnuFileImport.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileImport, -1)
        Me.mnuFileImport.Index = 3
        Me.mnuFileImport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileImportRTF, Me.mnuFileImportTXT, Me.mnuFileImportWizard})
        Me.mnuFileImport.OwnerDraw = True
        Me.mnuFileImport.Shortcut = CType(resources.GetObject("mnuFileImport.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileImport.ShowShortcut = CType(resources.GetObject("mnuFileImport.ShowShortcut"), Boolean)
        Me.mnuFileImport.Text = resources.GetString("mnuFileImport.Text")
        Me.mnuFileImport.Visible = CType(resources.GetObject("mnuFileImport.Visible"), Boolean)
        '
        'mnuFileImportRTF
        '
        Me.mnuFileImportRTF.Enabled = CType(resources.GetObject("mnuFileImportRTF.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileImportRTF, -1)
        Me.mnuFileImportRTF.Index = 0
        Me.mnuFileImportRTF.OwnerDraw = True
        Me.mnuFileImportRTF.Shortcut = CType(resources.GetObject("mnuFileImportRTF.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileImportRTF.ShowShortcut = CType(resources.GetObject("mnuFileImportRTF.ShowShortcut"), Boolean)
        Me.mnuFileImportRTF.Text = resources.GetString("mnuFileImportRTF.Text")
        Me.mnuFileImportRTF.Visible = CType(resources.GetObject("mnuFileImportRTF.Visible"), Boolean)
        '
        'mnuFileImportTXT
        '
        Me.mnuFileImportTXT.Enabled = CType(resources.GetObject("mnuFileImportTXT.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileImportTXT, -1)
        Me.mnuFileImportTXT.Index = 1
        Me.mnuFileImportTXT.OwnerDraw = True
        Me.mnuFileImportTXT.Shortcut = CType(resources.GetObject("mnuFileImportTXT.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileImportTXT.ShowShortcut = CType(resources.GetObject("mnuFileImportTXT.ShowShortcut"), Boolean)
        Me.mnuFileImportTXT.Text = resources.GetString("mnuFileImportTXT.Text")
        Me.mnuFileImportTXT.Visible = CType(resources.GetObject("mnuFileImportTXT.Visible"), Boolean)
        '
        'mnuFileImportWizard
        '
        Me.mnuFileImportWizard.Enabled = CType(resources.GetObject("mnuFileImportWizard.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileImportWizard, -1)
        Me.mnuFileImportWizard.Index = 2
        Me.mnuFileImportWizard.OwnerDraw = True
        Me.mnuFileImportWizard.Shortcut = CType(resources.GetObject("mnuFileImportWizard.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileImportWizard.ShowShortcut = CType(resources.GetObject("mnuFileImportWizard.ShowShortcut"), Boolean)
        Me.mnuFileImportWizard.Text = resources.GetString("mnuFileImportWizard.Text")
        Me.mnuFileImportWizard.Visible = CType(resources.GetObject("mnuFileImportWizard.Visible"), Boolean)
        '
        'mnuFileExport
        '
        Me.mnuFileExport.Enabled = CType(resources.GetObject("mnuFileExport.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExport, -1)
        Me.mnuFileExport.Index = 4
        Me.mnuFileExport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileExportTempData, Me.mnuFileExportTempDataXML, Me.mnuFileExportRTF, Me.mnuFileExportTXT, Me.mnuFileExportWizard, Me.mnuFileExportTempNRtfData})
        Me.mnuFileExport.OwnerDraw = True
        Me.mnuFileExport.Shortcut = CType(resources.GetObject("mnuFileExport.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExport.ShowShortcut = CType(resources.GetObject("mnuFileExport.ShowShortcut"), Boolean)
        Me.mnuFileExport.Text = resources.GetString("mnuFileExport.Text")
        Me.mnuFileExport.Visible = CType(resources.GetObject("mnuFileExport.Visible"), Boolean)
        '
        'mnuFileExportTempData
        '
        Me.mnuFileExportTempData.Enabled = CType(resources.GetObject("mnuFileExportTempData.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportTempData, -1)
        Me.mnuFileExportTempData.Index = 0
        Me.mnuFileExportTempData.OwnerDraw = True
        Me.mnuFileExportTempData.Shortcut = CType(resources.GetObject("mnuFileExportTempData.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportTempData.ShowShortcut = CType(resources.GetObject("mnuFileExportTempData.ShowShortcut"), Boolean)
        Me.mnuFileExportTempData.Text = resources.GetString("mnuFileExportTempData.Text")
        Me.mnuFileExportTempData.Visible = CType(resources.GetObject("mnuFileExportTempData.Visible"), Boolean)
        '
        'mnuFileExportTempDataXML
        '
        Me.mnuFileExportTempDataXML.Enabled = CType(resources.GetObject("mnuFileExportTempDataXML.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportTempDataXML, -1)
        Me.mnuFileExportTempDataXML.Index = 1
        Me.mnuFileExportTempDataXML.OwnerDraw = True
        Me.mnuFileExportTempDataXML.Shortcut = CType(resources.GetObject("mnuFileExportTempDataXML.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportTempDataXML.ShowShortcut = CType(resources.GetObject("mnuFileExportTempDataXML.ShowShortcut"), Boolean)
        Me.mnuFileExportTempDataXML.Text = resources.GetString("mnuFileExportTempDataXML.Text")
        Me.mnuFileExportTempDataXML.Visible = CType(resources.GetObject("mnuFileExportTempDataXML.Visible"), Boolean)
        '
        'mnuFileExportRTF
        '
        Me.mnuFileExportRTF.Enabled = CType(resources.GetObject("mnuFileExportRTF.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportRTF, -1)
        Me.mnuFileExportRTF.Index = 2
        Me.mnuFileExportRTF.OwnerDraw = True
        Me.mnuFileExportRTF.Shortcut = CType(resources.GetObject("mnuFileExportRTF.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportRTF.ShowShortcut = CType(resources.GetObject("mnuFileExportRTF.ShowShortcut"), Boolean)
        Me.mnuFileExportRTF.Text = resources.GetString("mnuFileExportRTF.Text")
        Me.mnuFileExportRTF.Visible = CType(resources.GetObject("mnuFileExportRTF.Visible"), Boolean)
        '
        'mnuFileExportTXT
        '
        Me.mnuFileExportTXT.Enabled = CType(resources.GetObject("mnuFileExportTXT.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportTXT, -1)
        Me.mnuFileExportTXT.Index = 3
        Me.mnuFileExportTXT.OwnerDraw = True
        Me.mnuFileExportTXT.Shortcut = CType(resources.GetObject("mnuFileExportTXT.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportTXT.ShowShortcut = CType(resources.GetObject("mnuFileExportTXT.ShowShortcut"), Boolean)
        Me.mnuFileExportTXT.Text = resources.GetString("mnuFileExportTXT.Text")
        Me.mnuFileExportTXT.Visible = CType(resources.GetObject("mnuFileExportTXT.Visible"), Boolean)
        '
        'mnuFileExportWizard
        '
        Me.mnuFileExportWizard.Enabled = CType(resources.GetObject("mnuFileExportWizard.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportWizard, -1)
        Me.mnuFileExportWizard.Index = 4
        Me.mnuFileExportWizard.OwnerDraw = True
        Me.mnuFileExportWizard.Shortcut = CType(resources.GetObject("mnuFileExportWizard.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportWizard.ShowShortcut = CType(resources.GetObject("mnuFileExportWizard.ShowShortcut"), Boolean)
        Me.mnuFileExportWizard.Text = resources.GetString("mnuFileExportWizard.Text")
        Me.mnuFileExportWizard.Visible = CType(resources.GetObject("mnuFileExportWizard.Visible"), Boolean)
        '
        'mnuFileExportTempNRtfData
        '
        Me.mnuFileExportTempNRtfData.Enabled = CType(resources.GetObject("mnuFileExportTempNRtfData.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExportTempNRtfData, -1)
        Me.mnuFileExportTempNRtfData.Index = 5
        Me.mnuFileExportTempNRtfData.OwnerDraw = True
        Me.mnuFileExportTempNRtfData.Shortcut = CType(resources.GetObject("mnuFileExportTempNRtfData.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExportTempNRtfData.ShowShortcut = CType(resources.GetObject("mnuFileExportTempNRtfData.ShowShortcut"), Boolean)
        Me.mnuFileExportTempNRtfData.Text = resources.GetString("mnuFileExportTempNRtfData.Text")
        Me.mnuFileExportTempNRtfData.Visible = CType(resources.GetObject("mnuFileExportTempNRtfData.Visible"), Boolean)
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = CType(resources.GetObject("MenuItem16.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem16, -1)
        Me.MenuItem16.Index = 5
        Me.MenuItem16.OwnerDraw = True
        Me.MenuItem16.Shortcut = CType(resources.GetObject("MenuItem16.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem16.ShowShortcut = CType(resources.GetObject("MenuItem16.ShowShortcut"), Boolean)
        Me.MenuItem16.Text = resources.GetString("MenuItem16.Text")
        Me.MenuItem16.Visible = CType(resources.GetObject("MenuItem16.Visible"), Boolean)
        '
        'mnuFilePageSetup
        '
        Me.mnuFilePageSetup.Enabled = CType(resources.GetObject("mnuFilePageSetup.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFilePageSetup, -1)
        Me.mnuFilePageSetup.Index = 6
        Me.mnuFilePageSetup.OwnerDraw = True
        Me.mnuFilePageSetup.Shortcut = CType(resources.GetObject("mnuFilePageSetup.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFilePageSetup.ShowShortcut = CType(resources.GetObject("mnuFilePageSetup.ShowShortcut"), Boolean)
        Me.mnuFilePageSetup.Text = resources.GetString("mnuFilePageSetup.Text")
        Me.mnuFilePageSetup.Visible = CType(resources.GetObject("mnuFilePageSetup.Visible"), Boolean)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Enabled = CType(resources.GetObject("mnuFilePrint.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFilePrint, -1)
        Me.mnuFilePrint.Index = 7
        Me.mnuFilePrint.OwnerDraw = True
        Me.mnuFilePrint.Shortcut = CType(resources.GetObject("mnuFilePrint.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFilePrint.ShowShortcut = CType(resources.GetObject("mnuFilePrint.ShowShortcut"), Boolean)
        Me.mnuFilePrint.Text = resources.GetString("mnuFilePrint.Text")
        Me.mnuFilePrint.Visible = CType(resources.GetObject("mnuFilePrint.Visible"), Boolean)
        '
        'mnuFileSelectivePrint
        '
        Me.mnuFileSelectivePrint.Enabled = CType(resources.GetObject("mnuFileSelectivePrint.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileSelectivePrint, -1)
        Me.mnuFileSelectivePrint.Index = 8
        Me.mnuFileSelectivePrint.OwnerDraw = True
        Me.mnuFileSelectivePrint.Shortcut = CType(resources.GetObject("mnuFileSelectivePrint.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileSelectivePrint.ShowShortcut = CType(resources.GetObject("mnuFileSelectivePrint.ShowShortcut"), Boolean)
        Me.mnuFileSelectivePrint.Text = resources.GetString("mnuFileSelectivePrint.Text")
        Me.mnuFileSelectivePrint.Visible = CType(resources.GetObject("mnuFileSelectivePrint.Visible"), Boolean)
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = CType(resources.GetObject("MenuItem3.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem3, -1)
        Me.MenuItem3.Index = 9
        Me.MenuItem3.OwnerDraw = True
        Me.MenuItem3.Shortcut = CType(resources.GetObject("MenuItem3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem3.ShowShortcut = CType(resources.GetObject("MenuItem3.ShowShortcut"), Boolean)
        Me.MenuItem3.Text = resources.GetString("MenuItem3.Text")
        Me.MenuItem3.Visible = CType(resources.GetObject("MenuItem3.Visible"), Boolean)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Enabled = CType(resources.GetObject("mnuFileExit.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFileExit, -1)
        Me.mnuFileExit.Index = 10
        Me.mnuFileExit.OwnerDraw = True
        Me.mnuFileExit.Shortcut = CType(resources.GetObject("mnuFileExit.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFileExit.ShowShortcut = CType(resources.GetObject("mnuFileExit.ShowShortcut"), Boolean)
        Me.mnuFileExit.Text = resources.GetString("mnuFileExit.Text")
        Me.mnuFileExit.Visible = CType(resources.GetObject("mnuFileExit.Visible"), Boolean)
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = CType(resources.GetObject("mnuEdit.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEdit, -1)
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditUndo, Me.mnuEditRedo, Me.MenuItem4, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.mnuEditDelete, Me.MenuItem8, Me.mnuEditSelectAll, Me.MenuItem15, Me.mnuEditFindReplace, Me.mnuEditFindTopic, Me.mnuEditFindTemplateTopic})
        Me.mnuEdit.OwnerDraw = True
        Me.mnuEdit.Shortcut = CType(resources.GetObject("mnuEdit.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEdit.ShowShortcut = CType(resources.GetObject("mnuEdit.ShowShortcut"), Boolean)
        Me.mnuEdit.Text = resources.GetString("mnuEdit.Text")
        Me.mnuEdit.Visible = CType(resources.GetObject("mnuEdit.Visible"), Boolean)
        '
        'mnuEditUndo
        '
        Me.mnuEditUndo.Enabled = CType(resources.GetObject("mnuEditUndo.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditUndo, -1)
        Me.mnuEditUndo.Index = 0
        Me.mnuEditUndo.OwnerDraw = True
        Me.mnuEditUndo.Shortcut = CType(resources.GetObject("mnuEditUndo.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditUndo.ShowShortcut = CType(resources.GetObject("mnuEditUndo.ShowShortcut"), Boolean)
        Me.mnuEditUndo.Text = resources.GetString("mnuEditUndo.Text")
        Me.mnuEditUndo.Visible = CType(resources.GetObject("mnuEditUndo.Visible"), Boolean)
        '
        'mnuEditRedo
        '
        Me.mnuEditRedo.Enabled = CType(resources.GetObject("mnuEditRedo.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditRedo, -1)
        Me.mnuEditRedo.Index = 1
        Me.mnuEditRedo.OwnerDraw = True
        Me.mnuEditRedo.Shortcut = CType(resources.GetObject("mnuEditRedo.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditRedo.ShowShortcut = CType(resources.GetObject("mnuEditRedo.ShowShortcut"), Boolean)
        Me.mnuEditRedo.Text = resources.GetString("mnuEditRedo.Text")
        Me.mnuEditRedo.Visible = CType(resources.GetObject("mnuEditRedo.Visible"), Boolean)
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = CType(resources.GetObject("MenuItem4.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem4, -1)
        Me.MenuItem4.Index = 2
        Me.MenuItem4.OwnerDraw = True
        Me.MenuItem4.Shortcut = CType(resources.GetObject("MenuItem4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem4.ShowShortcut = CType(resources.GetObject("MenuItem4.ShowShortcut"), Boolean)
        Me.MenuItem4.Text = resources.GetString("MenuItem4.Text")
        Me.MenuItem4.Visible = CType(resources.GetObject("MenuItem4.Visible"), Boolean)
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Enabled = CType(resources.GetObject("mnuEditCut.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditCut, -1)
        Me.mnuEditCut.Index = 3
        Me.mnuEditCut.OwnerDraw = True
        Me.mnuEditCut.Shortcut = CType(resources.GetObject("mnuEditCut.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditCut.ShowShortcut = CType(resources.GetObject("mnuEditCut.ShowShortcut"), Boolean)
        Me.mnuEditCut.Text = resources.GetString("mnuEditCut.Text")
        Me.mnuEditCut.Visible = CType(resources.GetObject("mnuEditCut.Visible"), Boolean)
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Enabled = CType(resources.GetObject("mnuEditCopy.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditCopy, -1)
        Me.mnuEditCopy.Index = 4
        Me.mnuEditCopy.OwnerDraw = True
        Me.mnuEditCopy.Shortcut = CType(resources.GetObject("mnuEditCopy.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditCopy.ShowShortcut = CType(resources.GetObject("mnuEditCopy.ShowShortcut"), Boolean)
        Me.mnuEditCopy.Text = resources.GetString("mnuEditCopy.Text")
        Me.mnuEditCopy.Visible = CType(resources.GetObject("mnuEditCopy.Visible"), Boolean)
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Enabled = CType(resources.GetObject("mnuEditPaste.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditPaste, -1)
        Me.mnuEditPaste.Index = 5
        Me.mnuEditPaste.OwnerDraw = True
        Me.mnuEditPaste.Shortcut = CType(resources.GetObject("mnuEditPaste.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditPaste.ShowShortcut = CType(resources.GetObject("mnuEditPaste.ShowShortcut"), Boolean)
        Me.mnuEditPaste.Text = resources.GetString("mnuEditPaste.Text")
        Me.mnuEditPaste.Visible = CType(resources.GetObject("mnuEditPaste.Visible"), Boolean)
        '
        'mnuEditDelete
        '
        Me.mnuEditDelete.Enabled = CType(resources.GetObject("mnuEditDelete.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditDelete, -1)
        Me.mnuEditDelete.Index = 6
        Me.mnuEditDelete.OwnerDraw = True
        Me.mnuEditDelete.Shortcut = CType(resources.GetObject("mnuEditDelete.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditDelete.ShowShortcut = CType(resources.GetObject("mnuEditDelete.ShowShortcut"), Boolean)
        Me.mnuEditDelete.Text = resources.GetString("mnuEditDelete.Text")
        Me.mnuEditDelete.Visible = CType(resources.GetObject("mnuEditDelete.Visible"), Boolean)
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = CType(resources.GetObject("MenuItem8.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem8, -1)
        Me.MenuItem8.Index = 7
        Me.MenuItem8.OwnerDraw = True
        Me.MenuItem8.Shortcut = CType(resources.GetObject("MenuItem8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem8.ShowShortcut = CType(resources.GetObject("MenuItem8.ShowShortcut"), Boolean)
        Me.MenuItem8.Text = resources.GetString("MenuItem8.Text")
        Me.MenuItem8.Visible = CType(resources.GetObject("MenuItem8.Visible"), Boolean)
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Enabled = CType(resources.GetObject("mnuEditSelectAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditSelectAll, -1)
        Me.mnuEditSelectAll.Index = 8
        Me.mnuEditSelectAll.OwnerDraw = True
        Me.mnuEditSelectAll.Shortcut = CType(resources.GetObject("mnuEditSelectAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditSelectAll.ShowShortcut = CType(resources.GetObject("mnuEditSelectAll.ShowShortcut"), Boolean)
        Me.mnuEditSelectAll.Text = resources.GetString("mnuEditSelectAll.Text")
        Me.mnuEditSelectAll.Visible = CType(resources.GetObject("mnuEditSelectAll.Visible"), Boolean)
        '
        'MenuItem15
        '
        Me.MenuItem15.Enabled = CType(resources.GetObject("MenuItem15.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem15, -1)
        Me.MenuItem15.Index = 9
        Me.MenuItem15.OwnerDraw = True
        Me.MenuItem15.Shortcut = CType(resources.GetObject("MenuItem15.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem15.ShowShortcut = CType(resources.GetObject("MenuItem15.ShowShortcut"), Boolean)
        Me.MenuItem15.Text = resources.GetString("MenuItem15.Text")
        Me.MenuItem15.Visible = CType(resources.GetObject("MenuItem15.Visible"), Boolean)
        '
        'mnuEditFindReplace
        '
        Me.mnuEditFindReplace.Enabled = CType(resources.GetObject("mnuEditFindReplace.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditFindReplace, -1)
        Me.mnuEditFindReplace.Index = 10
        Me.mnuEditFindReplace.OwnerDraw = True
        Me.mnuEditFindReplace.Shortcut = CType(resources.GetObject("mnuEditFindReplace.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditFindReplace.ShowShortcut = CType(resources.GetObject("mnuEditFindReplace.ShowShortcut"), Boolean)
        Me.mnuEditFindReplace.Text = resources.GetString("mnuEditFindReplace.Text")
        Me.mnuEditFindReplace.Visible = CType(resources.GetObject("mnuEditFindReplace.Visible"), Boolean)
        '
        'mnuEditFindTopic
        '
        Me.mnuEditFindTopic.Enabled = CType(resources.GetObject("mnuEditFindTopic.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditFindTopic, -1)
        Me.mnuEditFindTopic.Index = 11
        Me.mnuEditFindTopic.OwnerDraw = True
        Me.mnuEditFindTopic.Shortcut = CType(resources.GetObject("mnuEditFindTopic.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditFindTopic.ShowShortcut = CType(resources.GetObject("mnuEditFindTopic.ShowShortcut"), Boolean)
        Me.mnuEditFindTopic.Text = resources.GetString("mnuEditFindTopic.Text")
        Me.mnuEditFindTopic.Visible = CType(resources.GetObject("mnuEditFindTopic.Visible"), Boolean)
        '
        'mnuEditFindTemplateTopic
        '
        Me.mnuEditFindTemplateTopic.Enabled = CType(resources.GetObject("mnuEditFindTemplateTopic.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuEditFindTemplateTopic, -1)
        Me.mnuEditFindTemplateTopic.Index = 12
        Me.mnuEditFindTemplateTopic.OwnerDraw = True
        Me.mnuEditFindTemplateTopic.Shortcut = CType(resources.GetObject("mnuEditFindTemplateTopic.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEditFindTemplateTopic.ShowShortcut = CType(resources.GetObject("mnuEditFindTemplateTopic.ShowShortcut"), Boolean)
        Me.mnuEditFindTemplateTopic.Text = resources.GetString("mnuEditFindTemplateTopic.Text")
        Me.mnuEditFindTemplateTopic.Visible = CType(resources.GetObject("mnuEditFindTemplateTopic.Visible"), Boolean)
        '
        'mnuView
        '
        Me.mnuView.Enabled = CType(resources.GetObject("mnuView.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuView, -1)
        Me.mnuView.Index = 2
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewToolbars, Me.MenuItem21, Me.mnuViewWordWrap, Me.MenuItem25, Me.mnuViewAlwaysOnTop})
        Me.mnuView.OwnerDraw = True
        Me.mnuView.Shortcut = CType(resources.GetObject("mnuView.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuView.ShowShortcut = CType(resources.GetObject("mnuView.ShowShortcut"), Boolean)
        Me.mnuView.Text = resources.GetString("mnuView.Text")
        Me.mnuView.Visible = CType(resources.GetObject("mnuView.Visible"), Boolean)
        '
        'mnuViewToolbars
        '
        Me.mnuViewToolbars.Enabled = CType(resources.GetObject("mnuViewToolbars.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbars, -1)
        Me.mnuViewToolbars.Index = 0
        Me.mnuViewToolbars.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewToolbar1, Me.mnuViewToolbar2, Me.mnuViewToolbar3, Me.mnuViewToolbar4, Me.MenuItem14, Me.mnuViewToolbarReset})
        Me.mnuViewToolbars.OwnerDraw = True
        Me.mnuViewToolbars.Shortcut = CType(resources.GetObject("mnuViewToolbars.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbars.ShowShortcut = CType(resources.GetObject("mnuViewToolbars.ShowShortcut"), Boolean)
        Me.mnuViewToolbars.Text = resources.GetString("mnuViewToolbars.Text")
        Me.mnuViewToolbars.Visible = CType(resources.GetObject("mnuViewToolbars.Visible"), Boolean)
        '
        'mnuViewToolbar1
        '
        Me.mnuViewToolbar1.Enabled = CType(resources.GetObject("mnuViewToolbar1.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbar1, -1)
        Me.mnuViewToolbar1.Index = 0
        Me.mnuViewToolbar1.OwnerDraw = True
        Me.mnuViewToolbar1.Shortcut = CType(resources.GetObject("mnuViewToolbar1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbar1.ShowShortcut = CType(resources.GetObject("mnuViewToolbar1.ShowShortcut"), Boolean)
        Me.mnuViewToolbar1.Text = resources.GetString("mnuViewToolbar1.Text")
        Me.mnuViewToolbar1.Visible = CType(resources.GetObject("mnuViewToolbar1.Visible"), Boolean)
        '
        'mnuViewToolbar2
        '
        Me.mnuViewToolbar2.Enabled = CType(resources.GetObject("mnuViewToolbar2.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbar2, -1)
        Me.mnuViewToolbar2.Index = 1
        Me.mnuViewToolbar2.OwnerDraw = True
        Me.mnuViewToolbar2.Shortcut = CType(resources.GetObject("mnuViewToolbar2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbar2.ShowShortcut = CType(resources.GetObject("mnuViewToolbar2.ShowShortcut"), Boolean)
        Me.mnuViewToolbar2.Text = resources.GetString("mnuViewToolbar2.Text")
        Me.mnuViewToolbar2.Visible = CType(resources.GetObject("mnuViewToolbar2.Visible"), Boolean)
        '
        'mnuViewToolbar3
        '
        Me.mnuViewToolbar3.Enabled = CType(resources.GetObject("mnuViewToolbar3.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbar3, -1)
        Me.mnuViewToolbar3.Index = 2
        Me.mnuViewToolbar3.OwnerDraw = True
        Me.mnuViewToolbar3.Shortcut = CType(resources.GetObject("mnuViewToolbar3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbar3.ShowShortcut = CType(resources.GetObject("mnuViewToolbar3.ShowShortcut"), Boolean)
        Me.mnuViewToolbar3.Text = resources.GetString("mnuViewToolbar3.Text")
        Me.mnuViewToolbar3.Visible = CType(resources.GetObject("mnuViewToolbar3.Visible"), Boolean)
        '
        'mnuViewToolbar4
        '
        Me.mnuViewToolbar4.Enabled = CType(resources.GetObject("mnuViewToolbar4.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbar4, -1)
        Me.mnuViewToolbar4.Index = 3
        Me.mnuViewToolbar4.OwnerDraw = True
        Me.mnuViewToolbar4.Shortcut = CType(resources.GetObject("mnuViewToolbar4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbar4.ShowShortcut = CType(resources.GetObject("mnuViewToolbar4.ShowShortcut"), Boolean)
        Me.mnuViewToolbar4.Text = resources.GetString("mnuViewToolbar4.Text")
        Me.mnuViewToolbar4.Visible = CType(resources.GetObject("mnuViewToolbar4.Visible"), Boolean)
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = CType(resources.GetObject("MenuItem14.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem14, -1)
        Me.MenuItem14.Index = 4
        Me.MenuItem14.OwnerDraw = True
        Me.MenuItem14.Shortcut = CType(resources.GetObject("MenuItem14.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem14.ShowShortcut = CType(resources.GetObject("MenuItem14.ShowShortcut"), Boolean)
        Me.MenuItem14.Text = resources.GetString("MenuItem14.Text")
        Me.MenuItem14.Visible = CType(resources.GetObject("MenuItem14.Visible"), Boolean)
        '
        'mnuViewToolbarReset
        '
        Me.mnuViewToolbarReset.Enabled = CType(resources.GetObject("mnuViewToolbarReset.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewToolbarReset, -1)
        Me.mnuViewToolbarReset.Index = 5
        Me.mnuViewToolbarReset.OwnerDraw = True
        Me.mnuViewToolbarReset.Shortcut = CType(resources.GetObject("mnuViewToolbarReset.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewToolbarReset.ShowShortcut = CType(resources.GetObject("mnuViewToolbarReset.ShowShortcut"), Boolean)
        Me.mnuViewToolbarReset.Text = resources.GetString("mnuViewToolbarReset.Text")
        Me.mnuViewToolbarReset.Visible = CType(resources.GetObject("mnuViewToolbarReset.Visible"), Boolean)
        '
        'MenuItem21
        '
        Me.MenuItem21.Enabled = CType(resources.GetObject("MenuItem21.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem21, -1)
        Me.MenuItem21.Index = 1
        Me.MenuItem21.OwnerDraw = True
        Me.MenuItem21.Shortcut = CType(resources.GetObject("MenuItem21.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem21.ShowShortcut = CType(resources.GetObject("MenuItem21.ShowShortcut"), Boolean)
        Me.MenuItem21.Text = resources.GetString("MenuItem21.Text")
        Me.MenuItem21.Visible = CType(resources.GetObject("MenuItem21.Visible"), Boolean)
        '
        'mnuViewWordWrap
        '
        Me.mnuViewWordWrap.Enabled = CType(resources.GetObject("mnuViewWordWrap.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewWordWrap, -1)
        Me.mnuViewWordWrap.Index = 2
        Me.mnuViewWordWrap.OwnerDraw = True
        Me.mnuViewWordWrap.Shortcut = CType(resources.GetObject("mnuViewWordWrap.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewWordWrap.ShowShortcut = CType(resources.GetObject("mnuViewWordWrap.ShowShortcut"), Boolean)
        Me.mnuViewWordWrap.Text = resources.GetString("mnuViewWordWrap.Text")
        Me.mnuViewWordWrap.Visible = CType(resources.GetObject("mnuViewWordWrap.Visible"), Boolean)
        '
        'MenuItem25
        '
        Me.MenuItem25.Enabled = CType(resources.GetObject("MenuItem25.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem25, -1)
        Me.MenuItem25.Index = 3
        Me.MenuItem25.OwnerDraw = True
        Me.MenuItem25.Shortcut = CType(resources.GetObject("MenuItem25.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem25.ShowShortcut = CType(resources.GetObject("MenuItem25.ShowShortcut"), Boolean)
        Me.MenuItem25.Text = resources.GetString("MenuItem25.Text")
        Me.MenuItem25.Visible = CType(resources.GetObject("MenuItem25.Visible"), Boolean)
        '
        'mnuViewAlwaysOnTop
        '
        Me.mnuViewAlwaysOnTop.Enabled = CType(resources.GetObject("mnuViewAlwaysOnTop.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuViewAlwaysOnTop, -1)
        Me.mnuViewAlwaysOnTop.Index = 4
        Me.mnuViewAlwaysOnTop.OwnerDraw = True
        Me.mnuViewAlwaysOnTop.Shortcut = CType(resources.GetObject("mnuViewAlwaysOnTop.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuViewAlwaysOnTop.ShowShortcut = CType(resources.GetObject("mnuViewAlwaysOnTop.ShowShortcut"), Boolean)
        Me.mnuViewAlwaysOnTop.Text = resources.GetString("mnuViewAlwaysOnTop.Text")
        Me.mnuViewAlwaysOnTop.Visible = CType(resources.GetObject("mnuViewAlwaysOnTop.Visible"), Boolean)
        '
        'mnuInsert
        '
        Me.mnuInsert.Enabled = CType(resources.GetObject("mnuInsert.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsert, -1)
        Me.mnuInsert.Index = 3
        Me.mnuInsert.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuInsertDateTime, Me.mnuInsertSymbol, Me.MenuItem28, Me.mnuInsertBullets, Me.mnuInsertGraphics, Me.mnuInsertTable, Me.MenuItem20, Me.mnuInsertLinkToFile, Me.mnuInsertQuickLink, Me.mnuInsertHyperlink})
        Me.mnuInsert.OwnerDraw = True
        Me.mnuInsert.Shortcut = CType(resources.GetObject("mnuInsert.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsert.ShowShortcut = CType(resources.GetObject("mnuInsert.ShowShortcut"), Boolean)
        Me.mnuInsert.Text = resources.GetString("mnuInsert.Text")
        Me.mnuInsert.Visible = CType(resources.GetObject("mnuInsert.Visible"), Boolean)
        '
        'mnuInsertDateTime
        '
        Me.mnuInsertDateTime.Enabled = CType(resources.GetObject("mnuInsertDateTime.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertDateTime, -1)
        Me.mnuInsertDateTime.Index = 0
        Me.mnuInsertDateTime.OwnerDraw = True
        Me.mnuInsertDateTime.Shortcut = CType(resources.GetObject("mnuInsertDateTime.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertDateTime.ShowShortcut = CType(resources.GetObject("mnuInsertDateTime.ShowShortcut"), Boolean)
        Me.mnuInsertDateTime.Text = resources.GetString("mnuInsertDateTime.Text")
        Me.mnuInsertDateTime.Visible = CType(resources.GetObject("mnuInsertDateTime.Visible"), Boolean)
        '
        'mnuInsertSymbol
        '
        Me.mnuInsertSymbol.Enabled = CType(resources.GetObject("mnuInsertSymbol.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertSymbol, -1)
        Me.mnuInsertSymbol.Index = 1
        Me.mnuInsertSymbol.OwnerDraw = True
        Me.mnuInsertSymbol.Shortcut = CType(resources.GetObject("mnuInsertSymbol.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertSymbol.ShowShortcut = CType(resources.GetObject("mnuInsertSymbol.ShowShortcut"), Boolean)
        Me.mnuInsertSymbol.Text = resources.GetString("mnuInsertSymbol.Text")
        Me.mnuInsertSymbol.Visible = CType(resources.GetObject("mnuInsertSymbol.Visible"), Boolean)
        '
        'MenuItem28
        '
        Me.MenuItem28.Enabled = CType(resources.GetObject("MenuItem28.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem28, -1)
        Me.MenuItem28.Index = 2
        Me.MenuItem28.OwnerDraw = True
        Me.MenuItem28.Shortcut = CType(resources.GetObject("MenuItem28.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem28.ShowShortcut = CType(resources.GetObject("MenuItem28.ShowShortcut"), Boolean)
        Me.MenuItem28.Text = resources.GetString("MenuItem28.Text")
        Me.MenuItem28.Visible = CType(resources.GetObject("MenuItem28.Visible"), Boolean)
        '
        'mnuInsertBullets
        '
        Me.mnuInsertBullets.Enabled = CType(resources.GetObject("mnuInsertBullets.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertBullets, -1)
        Me.mnuInsertBullets.Index = 3
        Me.mnuInsertBullets.OwnerDraw = True
        Me.mnuInsertBullets.Shortcut = CType(resources.GetObject("mnuInsertBullets.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertBullets.ShowShortcut = CType(resources.GetObject("mnuInsertBullets.ShowShortcut"), Boolean)
        Me.mnuInsertBullets.Text = resources.GetString("mnuInsertBullets.Text")
        Me.mnuInsertBullets.Visible = CType(resources.GetObject("mnuInsertBullets.Visible"), Boolean)
        '
        'mnuInsertGraphics
        '
        Me.mnuInsertGraphics.Enabled = CType(resources.GetObject("mnuInsertGraphics.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertGraphics, -1)
        Me.mnuInsertGraphics.Index = 4
        Me.mnuInsertGraphics.OwnerDraw = True
        Me.mnuInsertGraphics.Shortcut = CType(resources.GetObject("mnuInsertGraphics.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertGraphics.ShowShortcut = CType(resources.GetObject("mnuInsertGraphics.ShowShortcut"), Boolean)
        Me.mnuInsertGraphics.Text = resources.GetString("mnuInsertGraphics.Text")
        Me.mnuInsertGraphics.Visible = CType(resources.GetObject("mnuInsertGraphics.Visible"), Boolean)
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = CType(resources.GetObject("MenuItem20.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem20, -1)
        Me.MenuItem20.Index = 6
        Me.MenuItem20.OwnerDraw = True
        Me.MenuItem20.Shortcut = CType(resources.GetObject("MenuItem20.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem20.ShowShortcut = CType(resources.GetObject("MenuItem20.ShowShortcut"), Boolean)
        Me.MenuItem20.Text = resources.GetString("MenuItem20.Text")
        Me.MenuItem20.Visible = CType(resources.GetObject("MenuItem20.Visible"), Boolean)
        '
        'mnuInsertLinkToFile
        '
        Me.mnuInsertLinkToFile.Enabled = CType(resources.GetObject("mnuInsertLinkToFile.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertLinkToFile, -1)
        Me.mnuInsertLinkToFile.Index = 7
        Me.mnuInsertLinkToFile.OwnerDraw = True
        Me.mnuInsertLinkToFile.Shortcut = CType(resources.GetObject("mnuInsertLinkToFile.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertLinkToFile.ShowShortcut = CType(resources.GetObject("mnuInsertLinkToFile.ShowShortcut"), Boolean)
        Me.mnuInsertLinkToFile.Text = resources.GetString("mnuInsertLinkToFile.Text")
        Me.mnuInsertLinkToFile.Visible = CType(resources.GetObject("mnuInsertLinkToFile.Visible"), Boolean)
        '
        'mnuInsertQuickLink
        '
        Me.mnuInsertQuickLink.Enabled = CType(resources.GetObject("mnuInsertQuickLink.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertQuickLink, -1)
        Me.mnuInsertQuickLink.Index = 8
        Me.mnuInsertQuickLink.OwnerDraw = True
        Me.mnuInsertQuickLink.Shortcut = CType(resources.GetObject("mnuInsertQuickLink.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertQuickLink.ShowShortcut = CType(resources.GetObject("mnuInsertQuickLink.ShowShortcut"), Boolean)
        Me.mnuInsertQuickLink.Text = resources.GetString("mnuInsertQuickLink.Text")
        Me.mnuInsertQuickLink.Visible = CType(resources.GetObject("mnuInsertQuickLink.Visible"), Boolean)
        '
        'mnuInsertHyperlink
        '
        Me.mnuInsertHyperlink.Enabled = CType(resources.GetObject("mnuInsertHyperlink.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertHyperlink, -1)
        Me.mnuInsertHyperlink.Index = 9
        Me.mnuInsertHyperlink.OwnerDraw = True
        Me.mnuInsertHyperlink.Shortcut = CType(resources.GetObject("mnuInsertHyperlink.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertHyperlink.ShowShortcut = CType(resources.GetObject("mnuInsertHyperlink.ShowShortcut"), Boolean)
        Me.mnuInsertHyperlink.Text = resources.GetString("mnuInsertHyperlink.Text")
        Me.mnuInsertHyperlink.Visible = CType(resources.GetObject("mnuInsertHyperlink.Visible"), Boolean)
        '
        'mnuFormat
        '
        Me.mnuFormat.Enabled = CType(resources.GetObject("mnuFormat.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormat, -1)
        Me.mnuFormat.Index = 4
        Me.mnuFormat.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFormatFont, Me.MenuItem36, Me.mnuFormatChangeCase, Me.mnuFormatBackground})
        Me.mnuFormat.OwnerDraw = True
        Me.mnuFormat.Shortcut = CType(resources.GetObject("mnuFormat.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormat.ShowShortcut = CType(resources.GetObject("mnuFormat.ShowShortcut"), Boolean)
        Me.mnuFormat.Text = resources.GetString("mnuFormat.Text")
        Me.mnuFormat.Visible = CType(resources.GetObject("mnuFormat.Visible"), Boolean)
        '
        'mnuFormatFont
        '
        Me.mnuFormatFont.Enabled = CType(resources.GetObject("mnuFormatFont.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatFont, -1)
        Me.mnuFormatFont.Index = 0
        Me.mnuFormatFont.OwnerDraw = True
        Me.mnuFormatFont.Shortcut = CType(resources.GetObject("mnuFormatFont.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatFont.ShowShortcut = CType(resources.GetObject("mnuFormatFont.ShowShortcut"), Boolean)
        Me.mnuFormatFont.Text = resources.GetString("mnuFormatFont.Text")
        Me.mnuFormatFont.Visible = CType(resources.GetObject("mnuFormatFont.Visible"), Boolean)
        '
        'MenuItem36
        '
        Me.MenuItem36.Enabled = CType(resources.GetObject("MenuItem36.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem36, -1)
        Me.MenuItem36.Index = 1
        Me.MenuItem36.OwnerDraw = True
        Me.MenuItem36.Shortcut = CType(resources.GetObject("MenuItem36.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem36.ShowShortcut = CType(resources.GetObject("MenuItem36.ShowShortcut"), Boolean)
        Me.MenuItem36.Text = resources.GetString("MenuItem36.Text")
        Me.MenuItem36.Visible = CType(resources.GetObject("MenuItem36.Visible"), Boolean)
        '
        'mnuFormatChangeCase
        '
        Me.mnuFormatChangeCase.Enabled = CType(resources.GetObject("mnuFormatChangeCase.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatChangeCase, -1)
        Me.mnuFormatChangeCase.Index = 2
        Me.mnuFormatChangeCase.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFormatChangeCaseUpper, Me.mnuFormatChangeCaseLower, Me.mnuFormatChangeCaseProper, Me.mnuFormatChangeCaseToggle})
        Me.mnuFormatChangeCase.OwnerDraw = True
        Me.mnuFormatChangeCase.Shortcut = CType(resources.GetObject("mnuFormatChangeCase.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatChangeCase.ShowShortcut = CType(resources.GetObject("mnuFormatChangeCase.ShowShortcut"), Boolean)
        Me.mnuFormatChangeCase.Text = resources.GetString("mnuFormatChangeCase.Text")
        Me.mnuFormatChangeCase.Visible = CType(resources.GetObject("mnuFormatChangeCase.Visible"), Boolean)
        '
        'mnuFormatChangeCaseUpper
        '
        Me.mnuFormatChangeCaseUpper.Enabled = CType(resources.GetObject("mnuFormatChangeCaseUpper.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatChangeCaseUpper, -1)
        Me.mnuFormatChangeCaseUpper.Index = 0
        Me.mnuFormatChangeCaseUpper.OwnerDraw = True
        Me.mnuFormatChangeCaseUpper.Shortcut = CType(resources.GetObject("mnuFormatChangeCaseUpper.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatChangeCaseUpper.ShowShortcut = CType(resources.GetObject("mnuFormatChangeCaseUpper.ShowShortcut"), Boolean)
        Me.mnuFormatChangeCaseUpper.Text = resources.GetString("mnuFormatChangeCaseUpper.Text")
        Me.mnuFormatChangeCaseUpper.Visible = CType(resources.GetObject("mnuFormatChangeCaseUpper.Visible"), Boolean)
        '
        'mnuFormatChangeCaseLower
        '
        Me.mnuFormatChangeCaseLower.Enabled = CType(resources.GetObject("mnuFormatChangeCaseLower.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatChangeCaseLower, -1)
        Me.mnuFormatChangeCaseLower.Index = 1
        Me.mnuFormatChangeCaseLower.OwnerDraw = True
        Me.mnuFormatChangeCaseLower.Shortcut = CType(resources.GetObject("mnuFormatChangeCaseLower.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatChangeCaseLower.ShowShortcut = CType(resources.GetObject("mnuFormatChangeCaseLower.ShowShortcut"), Boolean)
        Me.mnuFormatChangeCaseLower.Text = resources.GetString("mnuFormatChangeCaseLower.Text")
        Me.mnuFormatChangeCaseLower.Visible = CType(resources.GetObject("mnuFormatChangeCaseLower.Visible"), Boolean)
        '
        'mnuFormatChangeCaseProper
        '
        Me.mnuFormatChangeCaseProper.Enabled = CType(resources.GetObject("mnuFormatChangeCaseProper.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatChangeCaseProper, -1)
        Me.mnuFormatChangeCaseProper.Index = 2
        Me.mnuFormatChangeCaseProper.OwnerDraw = True
        Me.mnuFormatChangeCaseProper.Shortcut = CType(resources.GetObject("mnuFormatChangeCaseProper.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatChangeCaseProper.ShowShortcut = CType(resources.GetObject("mnuFormatChangeCaseProper.ShowShortcut"), Boolean)
        Me.mnuFormatChangeCaseProper.Text = resources.GetString("mnuFormatChangeCaseProper.Text")
        Me.mnuFormatChangeCaseProper.Visible = CType(resources.GetObject("mnuFormatChangeCaseProper.Visible"), Boolean)
        '
        'mnuFormatChangeCaseToggle
        '
        Me.mnuFormatChangeCaseToggle.Enabled = CType(resources.GetObject("mnuFormatChangeCaseToggle.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatChangeCaseToggle, -1)
        Me.mnuFormatChangeCaseToggle.Index = 3
        Me.mnuFormatChangeCaseToggle.OwnerDraw = True
        Me.mnuFormatChangeCaseToggle.Shortcut = CType(resources.GetObject("mnuFormatChangeCaseToggle.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatChangeCaseToggle.ShowShortcut = CType(resources.GetObject("mnuFormatChangeCaseToggle.ShowShortcut"), Boolean)
        Me.mnuFormatChangeCaseToggle.Text = resources.GetString("mnuFormatChangeCaseToggle.Text")
        Me.mnuFormatChangeCaseToggle.Visible = CType(resources.GetObject("mnuFormatChangeCaseToggle.Visible"), Boolean)
        '
        'mnuFormatBackground
        '
        Me.mnuFormatBackground.Enabled = CType(resources.GetObject("mnuFormatBackground.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatBackground, -1)
        Me.mnuFormatBackground.Index = 3
        Me.mnuFormatBackground.OwnerDraw = True
        Me.mnuFormatBackground.Shortcut = CType(resources.GetObject("mnuFormatBackground.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFormatBackground.ShowShortcut = CType(resources.GetObject("mnuFormatBackground.ShowShortcut"), Boolean)
        Me.mnuFormatBackground.Text = resources.GetString("mnuFormatBackground.Text")
        Me.mnuFormatBackground.Visible = CType(resources.GetObject("mnuFormatBackground.Visible"), Boolean)
        '
        'mnuBookmarks
        '
        Me.mnuBookmarks.Enabled = CType(resources.GetObject("mnuBookmarks.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuBookmarks, -1)
        Me.mnuBookmarks.Index = 5
        Me.mnuBookmarks.OwnerDraw = True
        Me.mnuBookmarks.Shortcut = CType(resources.GetObject("mnuBookmarks.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuBookmarks.ShowShortcut = CType(resources.GetObject("mnuBookmarks.ShowShortcut"), Boolean)
        Me.mnuBookmarks.Text = resources.GetString("mnuBookmarks.Text")
        Me.mnuBookmarks.Visible = CType(resources.GetObject("mnuBookmarks.Visible"), Boolean)
        '
        'mnuTemplates
        '
        Me.mnuTemplates.Enabled = CType(resources.GetObject("mnuTemplates.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplates, -1)
        Me.mnuTemplates.Index = 6
        Me.mnuTemplates.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTemplatesSelect, Me.mnuTemplatesOrganise, Me.mnuTemplatesRapidEntry, Me.mnuTemplateToRTF, Me.mnuTemplateTextSize, Me.mnuTemplatesSep})
        Me.mnuTemplates.OwnerDraw = True
        Me.mnuTemplates.Shortcut = CType(resources.GetObject("mnuTemplates.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplates.ShowShortcut = CType(resources.GetObject("mnuTemplates.ShowShortcut"), Boolean)
        Me.mnuTemplates.Text = resources.GetString("mnuTemplates.Text")
        Me.mnuTemplates.Visible = CType(resources.GetObject("mnuTemplates.Visible"), Boolean)
        '
        'mnuTemplatesSelect
        '
        Me.mnuTemplatesSelect.Enabled = CType(resources.GetObject("mnuTemplatesSelect.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplatesSelect, -1)
        Me.mnuTemplatesSelect.Index = 0
        Me.mnuTemplatesSelect.OwnerDraw = True
        Me.mnuTemplatesSelect.Shortcut = CType(resources.GetObject("mnuTemplatesSelect.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplatesSelect.ShowShortcut = CType(resources.GetObject("mnuTemplatesSelect.ShowShortcut"), Boolean)
        Me.mnuTemplatesSelect.Text = resources.GetString("mnuTemplatesSelect.Text")
        Me.mnuTemplatesSelect.Visible = CType(resources.GetObject("mnuTemplatesSelect.Visible"), Boolean)
        '
        'mnuTemplatesOrganise
        '
        Me.mnuTemplatesOrganise.Enabled = CType(resources.GetObject("mnuTemplatesOrganise.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplatesOrganise, -1)
        Me.mnuTemplatesOrganise.Index = 1
        Me.mnuTemplatesOrganise.OwnerDraw = True
        Me.mnuTemplatesOrganise.Shortcut = CType(resources.GetObject("mnuTemplatesOrganise.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplatesOrganise.ShowShortcut = CType(resources.GetObject("mnuTemplatesOrganise.ShowShortcut"), Boolean)
        Me.mnuTemplatesOrganise.Text = resources.GetString("mnuTemplatesOrganise.Text")
        Me.mnuTemplatesOrganise.Visible = CType(resources.GetObject("mnuTemplatesOrganise.Visible"), Boolean)
        '
        'mnuTemplatesRapidEntry
        '
        Me.mnuTemplatesRapidEntry.Enabled = CType(resources.GetObject("mnuTemplatesRapidEntry.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplatesRapidEntry, -1)
        Me.mnuTemplatesRapidEntry.Index = 2
        Me.mnuTemplatesRapidEntry.OwnerDraw = True
        Me.mnuTemplatesRapidEntry.Shortcut = CType(resources.GetObject("mnuTemplatesRapidEntry.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplatesRapidEntry.ShowShortcut = CType(resources.GetObject("mnuTemplatesRapidEntry.ShowShortcut"), Boolean)
        Me.mnuTemplatesRapidEntry.Text = resources.GetString("mnuTemplatesRapidEntry.Text")
        Me.mnuTemplatesRapidEntry.Visible = CType(resources.GetObject("mnuTemplatesRapidEntry.Visible"), Boolean)
        '
        'mnuTemplateToRTF
        '
        Me.mnuTemplateToRTF.Enabled = CType(resources.GetObject("mnuTemplateToRTF.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplateToRTF, -1)
        Me.mnuTemplateToRTF.Index = 3
        Me.mnuTemplateToRTF.OwnerDraw = True
        Me.mnuTemplateToRTF.Shortcut = CType(resources.GetObject("mnuTemplateToRTF.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplateToRTF.ShowShortcut = CType(resources.GetObject("mnuTemplateToRTF.ShowShortcut"), Boolean)
        Me.mnuTemplateToRTF.Text = resources.GetString("mnuTemplateToRTF.Text")
        Me.mnuTemplateToRTF.Visible = CType(resources.GetObject("mnuTemplateToRTF.Visible"), Boolean)
        '
        'mnuTemplateTextSize
        '
        Me.mnuTemplateTextSize.Enabled = CType(resources.GetObject("mnuTemplateTextSize.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplateTextSize, -1)
        Me.mnuTemplateTextSize.Index = 4
        Me.mnuTemplateTextSize.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTemplateTextSizeLarger, Me.mnuTemplateTextSizeSmaller})
        Me.mnuTemplateTextSize.OwnerDraw = True
        Me.mnuTemplateTextSize.Shortcut = CType(resources.GetObject("mnuTemplateTextSize.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplateTextSize.ShowShortcut = CType(resources.GetObject("mnuTemplateTextSize.ShowShortcut"), Boolean)
        Me.mnuTemplateTextSize.Text = resources.GetString("mnuTemplateTextSize.Text")
        Me.mnuTemplateTextSize.Visible = CType(resources.GetObject("mnuTemplateTextSize.Visible"), Boolean)
        '
        'mnuTemplateTextSizeLarger
        '
        Me.mnuTemplateTextSizeLarger.Enabled = CType(resources.GetObject("mnuTemplateTextSizeLarger.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplateTextSizeLarger, -1)
        Me.mnuTemplateTextSizeLarger.Index = 0
        Me.mnuTemplateTextSizeLarger.OwnerDraw = True
        Me.mnuTemplateTextSizeLarger.Shortcut = CType(resources.GetObject("mnuTemplateTextSizeLarger.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplateTextSizeLarger.ShowShortcut = CType(resources.GetObject("mnuTemplateTextSizeLarger.ShowShortcut"), Boolean)
        Me.mnuTemplateTextSizeLarger.Text = resources.GetString("mnuTemplateTextSizeLarger.Text")
        Me.mnuTemplateTextSizeLarger.Visible = CType(resources.GetObject("mnuTemplateTextSizeLarger.Visible"), Boolean)
        '
        'mnuTemplateTextSizeSmaller
        '
        Me.mnuTemplateTextSizeSmaller.Enabled = CType(resources.GetObject("mnuTemplateTextSizeSmaller.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplateTextSizeSmaller, -1)
        Me.mnuTemplateTextSizeSmaller.Index = 1
        Me.mnuTemplateTextSizeSmaller.OwnerDraw = True
        Me.mnuTemplateTextSizeSmaller.Shortcut = CType(resources.GetObject("mnuTemplateTextSizeSmaller.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplateTextSizeSmaller.ShowShortcut = CType(resources.GetObject("mnuTemplateTextSizeSmaller.ShowShortcut"), Boolean)
        Me.mnuTemplateTextSizeSmaller.Text = resources.GetString("mnuTemplateTextSizeSmaller.Text")
        Me.mnuTemplateTextSizeSmaller.Visible = CType(resources.GetObject("mnuTemplateTextSizeSmaller.Visible"), Boolean)
        '
        'mnuTemplatesSep
        '
        Me.mnuTemplatesSep.Enabled = CType(resources.GetObject("mnuTemplatesSep.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplatesSep, -1)
        Me.mnuTemplatesSep.Index = 5
        Me.mnuTemplatesSep.OwnerDraw = True
        Me.mnuTemplatesSep.Shortcut = CType(resources.GetObject("mnuTemplatesSep.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTemplatesSep.ShowShortcut = CType(resources.GetObject("mnuTemplatesSep.ShowShortcut"), Boolean)
        Me.mnuTemplatesSep.Text = resources.GetString("mnuTemplatesSep.Text")
        Me.mnuTemplatesSep.Visible = CType(resources.GetObject("mnuTemplatesSep.Visible"), Boolean)
        '
        'mnuTools
        '
        Me.mnuTools.Enabled = CType(resources.GetObject("mnuTools.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuTools, -1)
        Me.mnuTools.Index = 7
        Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolsSpelling, Me.MenuItem17, Me.mnuToolsRefresh, Me.mnuToolsExpandAll, Me.mnuToolsCollapseAll, Me.MenuItem13, Me.mnuToolsOptions})
        Me.mnuTools.OwnerDraw = True
        Me.mnuTools.Shortcut = CType(resources.GetObject("mnuTools.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTools.ShowShortcut = CType(resources.GetObject("mnuTools.ShowShortcut"), Boolean)
        Me.mnuTools.Text = resources.GetString("mnuTools.Text")
        Me.mnuTools.Visible = CType(resources.GetObject("mnuTools.Visible"), Boolean)
        '
        'mnuToolsSpelling
        '
        Me.mnuToolsSpelling.Enabled = CType(resources.GetObject("mnuToolsSpelling.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsSpelling, -1)
        Me.mnuToolsSpelling.Index = 0
        Me.mnuToolsSpelling.OwnerDraw = True
        Me.mnuToolsSpelling.Shortcut = CType(resources.GetObject("mnuToolsSpelling.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuToolsSpelling.ShowShortcut = CType(resources.GetObject("mnuToolsSpelling.ShowShortcut"), Boolean)
        Me.mnuToolsSpelling.Text = resources.GetString("mnuToolsSpelling.Text")
        Me.mnuToolsSpelling.Visible = CType(resources.GetObject("mnuToolsSpelling.Visible"), Boolean)
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = CType(resources.GetObject("MenuItem17.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem17, -1)
        Me.MenuItem17.Index = 1
        Me.MenuItem17.OwnerDraw = True
        Me.MenuItem17.Shortcut = CType(resources.GetObject("MenuItem17.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem17.ShowShortcut = CType(resources.GetObject("MenuItem17.ShowShortcut"), Boolean)
        Me.MenuItem17.Text = resources.GetString("MenuItem17.Text")
        Me.MenuItem17.Visible = CType(resources.GetObject("MenuItem17.Visible"), Boolean)
        '
        'mnuToolsRefresh
        '
        Me.mnuToolsRefresh.Enabled = CType(resources.GetObject("mnuToolsRefresh.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsRefresh, -1)
        Me.mnuToolsRefresh.Index = 2
        Me.mnuToolsRefresh.OwnerDraw = True
        Me.mnuToolsRefresh.Shortcut = CType(resources.GetObject("mnuToolsRefresh.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuToolsRefresh.ShowShortcut = CType(resources.GetObject("mnuToolsRefresh.ShowShortcut"), Boolean)
        Me.mnuToolsRefresh.Text = resources.GetString("mnuToolsRefresh.Text")
        Me.mnuToolsRefresh.Visible = CType(resources.GetObject("mnuToolsRefresh.Visible"), Boolean)
        '
        'mnuToolsExpandAll
        '
        Me.mnuToolsExpandAll.Enabled = CType(resources.GetObject("mnuToolsExpandAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsExpandAll, -1)
        Me.mnuToolsExpandAll.Index = 3
        Me.mnuToolsExpandAll.OwnerDraw = True
        Me.mnuToolsExpandAll.Shortcut = CType(resources.GetObject("mnuToolsExpandAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuToolsExpandAll.ShowShortcut = CType(resources.GetObject("mnuToolsExpandAll.ShowShortcut"), Boolean)
        Me.mnuToolsExpandAll.Text = resources.GetString("mnuToolsExpandAll.Text")
        Me.mnuToolsExpandAll.Visible = CType(resources.GetObject("mnuToolsExpandAll.Visible"), Boolean)
        '
        'mnuToolsCollapseAll
        '
        Me.mnuToolsCollapseAll.Enabled = CType(resources.GetObject("mnuToolsCollapseAll.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsCollapseAll, -1)
        Me.mnuToolsCollapseAll.Index = 4
        Me.mnuToolsCollapseAll.OwnerDraw = True
        Me.mnuToolsCollapseAll.Shortcut = CType(resources.GetObject("mnuToolsCollapseAll.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuToolsCollapseAll.ShowShortcut = CType(resources.GetObject("mnuToolsCollapseAll.ShowShortcut"), Boolean)
        Me.mnuToolsCollapseAll.Text = resources.GetString("mnuToolsCollapseAll.Text")
        Me.mnuToolsCollapseAll.Visible = CType(resources.GetObject("mnuToolsCollapseAll.Visible"), Boolean)
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = CType(resources.GetObject("MenuItem13.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem13, -1)
        Me.MenuItem13.Index = 5
        Me.MenuItem13.OwnerDraw = True
        Me.MenuItem13.Shortcut = CType(resources.GetObject("MenuItem13.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem13.ShowShortcut = CType(resources.GetObject("MenuItem13.ShowShortcut"), Boolean)
        Me.MenuItem13.Text = resources.GetString("MenuItem13.Text")
        Me.MenuItem13.Visible = CType(resources.GetObject("MenuItem13.Visible"), Boolean)
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Enabled = CType(resources.GetObject("mnuToolsOptions.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsOptions, -1)
        Me.mnuToolsOptions.Index = 6
        Me.mnuToolsOptions.OwnerDraw = True
        Me.mnuToolsOptions.Shortcut = CType(resources.GetObject("mnuToolsOptions.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuToolsOptions.ShowShortcut = CType(resources.GetObject("mnuToolsOptions.ShowShortcut"), Boolean)
        Me.mnuToolsOptions.Text = resources.GetString("mnuToolsOptions.Text")
        Me.mnuToolsOptions.Visible = CType(resources.GetObject("mnuToolsOptions.Visible"), Boolean)
        '
        'mnuHelp
        '
        Me.mnuHelp.Enabled = CType(resources.GetObject("mnuHelp.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelp, -1)
        Me.mnuHelp.Index = 8
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpTopics, Me.mnuHelpGettingStarted, Me.MenuItem1, Me.mnuHelpStartup, Me.mnuHelpCFU, Me.mnuHelpInstallPack, Me.mnuHelpSupport, Me.mnuHelpReportProblem, Me.MenuItem9, Me.mnuHelpBuy, Me.mnuHelpTipDay, Me.mnuHelpSubscribe, Me.mnuHelpEnterCode, Me.MenuItem6, Me.mnuHelpLicense, Me.mnuHelpAbout})
        Me.mnuHelp.OwnerDraw = True
        Me.mnuHelp.Shortcut = CType(resources.GetObject("mnuHelp.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelp.ShowShortcut = CType(resources.GetObject("mnuHelp.ShowShortcut"), Boolean)
        Me.mnuHelp.Text = resources.GetString("mnuHelp.Text")
        Me.mnuHelp.Visible = CType(resources.GetObject("mnuHelp.Visible"), Boolean)
        '
        'mnuHelpTopics
        '
        Me.mnuHelpTopics.Enabled = CType(resources.GetObject("mnuHelpTopics.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpTopics, -1)
        Me.mnuHelpTopics.Index = 0
        Me.mnuHelpTopics.OwnerDraw = True
        Me.mnuHelpTopics.Shortcut = CType(resources.GetObject("mnuHelpTopics.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpTopics.ShowShortcut = CType(resources.GetObject("mnuHelpTopics.ShowShortcut"), Boolean)
        Me.mnuHelpTopics.Text = resources.GetString("mnuHelpTopics.Text")
        Me.mnuHelpTopics.Visible = CType(resources.GetObject("mnuHelpTopics.Visible"), Boolean)
        '
        'mnuHelpGettingStarted
        '
        Me.mnuHelpGettingStarted.Enabled = CType(resources.GetObject("mnuHelpGettingStarted.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpGettingStarted, -1)
        Me.mnuHelpGettingStarted.Index = 1
        Me.mnuHelpGettingStarted.OwnerDraw = True
        Me.mnuHelpGettingStarted.Shortcut = CType(resources.GetObject("mnuHelpGettingStarted.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpGettingStarted.ShowShortcut = CType(resources.GetObject("mnuHelpGettingStarted.ShowShortcut"), Boolean)
        Me.mnuHelpGettingStarted.Text = resources.GetString("mnuHelpGettingStarted.Text")
        Me.mnuHelpGettingStarted.Visible = CType(resources.GetObject("mnuHelpGettingStarted.Visible"), Boolean)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem1, -1)
        Me.MenuItem1.Index = 2
        Me.MenuItem1.OwnerDraw = True
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'mnuHelpStartup
        '
        Me.mnuHelpStartup.Enabled = CType(resources.GetObject("mnuHelpStartup.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpStartup, -1)
        Me.mnuHelpStartup.Index = 3
        Me.mnuHelpStartup.OwnerDraw = True
        Me.mnuHelpStartup.Shortcut = CType(resources.GetObject("mnuHelpStartup.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpStartup.ShowShortcut = CType(resources.GetObject("mnuHelpStartup.ShowShortcut"), Boolean)
        Me.mnuHelpStartup.Text = resources.GetString("mnuHelpStartup.Text")
        Me.mnuHelpStartup.Visible = CType(resources.GetObject("mnuHelpStartup.Visible"), Boolean)
        '
        'mnuHelpCFU
        '
        Me.mnuHelpCFU.Enabled = CType(resources.GetObject("mnuHelpCFU.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpCFU, -1)
        Me.mnuHelpCFU.Index = 4
        Me.mnuHelpCFU.OwnerDraw = True
        Me.mnuHelpCFU.Shortcut = CType(resources.GetObject("mnuHelpCFU.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpCFU.ShowShortcut = CType(resources.GetObject("mnuHelpCFU.ShowShortcut"), Boolean)
        Me.mnuHelpCFU.Text = resources.GetString("mnuHelpCFU.Text")
        Me.mnuHelpCFU.Visible = CType(resources.GetObject("mnuHelpCFU.Visible"), Boolean)
        '
        'mnuHelpInstallPack
        '
        Me.mnuHelpInstallPack.Enabled = CType(resources.GetObject("mnuHelpInstallPack.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpInstallPack, -1)
        Me.mnuHelpInstallPack.Index = 5
        Me.mnuHelpInstallPack.OwnerDraw = True
        Me.mnuHelpInstallPack.Shortcut = CType(resources.GetObject("mnuHelpInstallPack.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpInstallPack.ShowShortcut = CType(resources.GetObject("mnuHelpInstallPack.ShowShortcut"), Boolean)
        Me.mnuHelpInstallPack.Text = resources.GetString("mnuHelpInstallPack.Text")
        Me.mnuHelpInstallPack.Visible = CType(resources.GetObject("mnuHelpInstallPack.Visible"), Boolean)
        '
        'mnuHelpSupport
        '
        Me.mnuHelpSupport.Enabled = CType(resources.GetObject("mnuHelpSupport.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpSupport, -1)
        Me.mnuHelpSupport.Index = 6
        Me.mnuHelpSupport.OwnerDraw = True
        Me.mnuHelpSupport.Shortcut = CType(resources.GetObject("mnuHelpSupport.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpSupport.ShowShortcut = CType(resources.GetObject("mnuHelpSupport.ShowShortcut"), Boolean)
        Me.mnuHelpSupport.Text = resources.GetString("mnuHelpSupport.Text")
        Me.mnuHelpSupport.Visible = CType(resources.GetObject("mnuHelpSupport.Visible"), Boolean)
        '
        'mnuHelpReportProblem
        '
        Me.mnuHelpReportProblem.Enabled = CType(resources.GetObject("mnuHelpReportProblem.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpReportProblem, -1)
        Me.mnuHelpReportProblem.Index = 7
        Me.mnuHelpReportProblem.OwnerDraw = True
        Me.mnuHelpReportProblem.Shortcut = CType(resources.GetObject("mnuHelpReportProblem.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpReportProblem.ShowShortcut = CType(resources.GetObject("mnuHelpReportProblem.ShowShortcut"), Boolean)
        Me.mnuHelpReportProblem.Text = resources.GetString("mnuHelpReportProblem.Text")
        Me.mnuHelpReportProblem.Visible = CType(resources.GetObject("mnuHelpReportProblem.Visible"), Boolean)
        '
        'MenuItem9
        '
        Me.MenuItem9.Enabled = CType(resources.GetObject("MenuItem9.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem9, -1)
        Me.MenuItem9.Index = 8
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.Shortcut = CType(resources.GetObject("MenuItem9.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem9.ShowShortcut = CType(resources.GetObject("MenuItem9.ShowShortcut"), Boolean)
        Me.MenuItem9.Text = resources.GetString("MenuItem9.Text")
        Me.MenuItem9.Visible = CType(resources.GetObject("MenuItem9.Visible"), Boolean)
        '
        'mnuHelpBuy
        '
        Me.mnuHelpBuy.Enabled = CType(resources.GetObject("mnuHelpBuy.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpBuy, -1)
        Me.mnuHelpBuy.Index = 9
        Me.mnuHelpBuy.OwnerDraw = True
        Me.mnuHelpBuy.Shortcut = CType(resources.GetObject("mnuHelpBuy.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpBuy.ShowShortcut = CType(resources.GetObject("mnuHelpBuy.ShowShortcut"), Boolean)
        Me.mnuHelpBuy.Text = resources.GetString("mnuHelpBuy.Text")
        Me.mnuHelpBuy.Visible = CType(resources.GetObject("mnuHelpBuy.Visible"), Boolean)
        '
        'mnuHelpTipDay
        '
        Me.mnuHelpTipDay.Enabled = CType(resources.GetObject("mnuHelpTipDay.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpTipDay, -1)
        Me.mnuHelpTipDay.Index = 10
        Me.mnuHelpTipDay.OwnerDraw = True
        Me.mnuHelpTipDay.Shortcut = CType(resources.GetObject("mnuHelpTipDay.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpTipDay.ShowShortcut = CType(resources.GetObject("mnuHelpTipDay.ShowShortcut"), Boolean)
        Me.mnuHelpTipDay.Text = resources.GetString("mnuHelpTipDay.Text")
        Me.mnuHelpTipDay.Visible = CType(resources.GetObject("mnuHelpTipDay.Visible"), Boolean)
        '
        'mnuHelpSubscribe
        '
        Me.mnuHelpSubscribe.Enabled = CType(resources.GetObject("mnuHelpSubscribe.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpSubscribe, -1)
        Me.mnuHelpSubscribe.Index = 11
        Me.mnuHelpSubscribe.OwnerDraw = True
        Me.mnuHelpSubscribe.Shortcut = CType(resources.GetObject("mnuHelpSubscribe.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpSubscribe.ShowShortcut = CType(resources.GetObject("mnuHelpSubscribe.ShowShortcut"), Boolean)
        Me.mnuHelpSubscribe.Text = resources.GetString("mnuHelpSubscribe.Text")
        Me.mnuHelpSubscribe.Visible = CType(resources.GetObject("mnuHelpSubscribe.Visible"), Boolean)
        '
        'mnuHelpEnterCode
        '
        Me.mnuHelpEnterCode.Enabled = CType(resources.GetObject("mnuHelpEnterCode.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpEnterCode, -1)
        Me.mnuHelpEnterCode.Index = 12
        Me.mnuHelpEnterCode.OwnerDraw = True
        Me.mnuHelpEnterCode.Shortcut = CType(resources.GetObject("mnuHelpEnterCode.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpEnterCode.ShowShortcut = CType(resources.GetObject("mnuHelpEnterCode.ShowShortcut"), Boolean)
        Me.mnuHelpEnterCode.Text = resources.GetString("mnuHelpEnterCode.Text")
        Me.mnuHelpEnterCode.Visible = CType(resources.GetObject("mnuHelpEnterCode.Visible"), Boolean)
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = CType(resources.GetObject("MenuItem6.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem6, -1)
        Me.MenuItem6.Index = 13
        Me.MenuItem6.OwnerDraw = True
        Me.MenuItem6.Shortcut = CType(resources.GetObject("MenuItem6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem6.ShowShortcut = CType(resources.GetObject("MenuItem6.ShowShortcut"), Boolean)
        Me.MenuItem6.Text = resources.GetString("MenuItem6.Text")
        Me.MenuItem6.Visible = CType(resources.GetObject("MenuItem6.Visible"), Boolean)
        '
        'mnuHelpLicense
        '
        Me.mnuHelpLicense.Enabled = CType(resources.GetObject("mnuHelpLicense.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpLicense, -1)
        Me.mnuHelpLicense.Index = 14
        Me.mnuHelpLicense.OwnerDraw = True
        Me.mnuHelpLicense.Shortcut = CType(resources.GetObject("mnuHelpLicense.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpLicense.ShowShortcut = CType(resources.GetObject("mnuHelpLicense.ShowShortcut"), Boolean)
        Me.mnuHelpLicense.Text = resources.GetString("mnuHelpLicense.Text")
        Me.mnuHelpLicense.Visible = CType(resources.GetObject("mnuHelpLicense.Visible"), Boolean)
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Enabled = CType(resources.GetObject("mnuHelpAbout.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuHelpAbout, -1)
        Me.mnuHelpAbout.Index = 15
        Me.mnuHelpAbout.OwnerDraw = True
        Me.mnuHelpAbout.Shortcut = CType(resources.GetObject("mnuHelpAbout.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelpAbout.ShowShortcut = CType(resources.GetObject("mnuHelpAbout.ShowShortcut"), Boolean)
        Me.mnuHelpAbout.Text = resources.GetString("mnuHelpAbout.Text")
        Me.mnuHelpAbout.Visible = CType(resources.GetObject("mnuHelpAbout.Visible"), Boolean)
        '
        'mnuBookmarksAdd
        '
        Me.mnuBookmarksAdd.Enabled = CType(resources.GetObject("mnuBookmarksAdd.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuBookmarksAdd, -1)
        Me.mnuBookmarksAdd.Index = -1
        Me.mnuBookmarksAdd.OwnerDraw = True
        Me.mnuBookmarksAdd.Shortcut = CType(resources.GetObject("mnuBookmarksAdd.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuBookmarksAdd.ShowShortcut = CType(resources.GetObject("mnuBookmarksAdd.ShowShortcut"), Boolean)
        Me.mnuBookmarksAdd.Text = resources.GetString("mnuBookmarksAdd.Text")
        Me.mnuBookmarksAdd.Visible = CType(resources.GetObject("mnuBookmarksAdd.Visible"), Boolean)
        '
        'mnuBookmarksRemove
        '
        Me.mnuBookmarksRemove.Enabled = CType(resources.GetObject("mnuBookmarksRemove.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuBookmarksRemove, -1)
        Me.mnuBookmarksRemove.Index = -1
        Me.mnuBookmarksRemove.OwnerDraw = True
        Me.mnuBookmarksRemove.Shortcut = CType(resources.GetObject("mnuBookmarksRemove.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuBookmarksRemove.ShowShortcut = CType(resources.GetObject("mnuBookmarksRemove.ShowShortcut"), Boolean)
        Me.mnuBookmarksRemove.Text = resources.GetString("mnuBookmarksRemove.Text")
        Me.mnuBookmarksRemove.Visible = CType(resources.GetObject("mnuBookmarksRemove.Visible"), Boolean)
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = CType(resources.GetObject("MenuItem19.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem19, -1)
        Me.MenuItem19.Index = -1
        Me.MenuItem19.OwnerDraw = True
        Me.MenuItem19.Shortcut = CType(resources.GetObject("MenuItem19.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem19.ShowShortcut = CType(resources.GetObject("MenuItem19.ShowShortcut"), Boolean)
        Me.MenuItem19.Text = resources.GetString("MenuItem19.Text")
        Me.MenuItem19.Visible = CType(resources.GetObject("MenuItem19.Visible"), Boolean)
        '
        'Splitter1
        '
        Me.Splitter1.AccessibleDescription = CType(resources.GetObject("Splitter1.AccessibleDescription"), String)
        Me.Splitter1.AccessibleName = CType(resources.GetObject("Splitter1.AccessibleName"), String)
        Me.Splitter1.Anchor = CType(resources.GetObject("Splitter1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Splitter1.BackgroundImage = CType(resources.GetObject("Splitter1.BackgroundImage"), System.Drawing.Image)
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = CType(resources.GetObject("Splitter1.Dock"), System.Windows.Forms.DockStyle)
        Me.Splitter1.Enabled = CType(resources.GetObject("Splitter1.Enabled"), Boolean)
        Me.Splitter1.Font = CType(resources.GetObject("Splitter1.Font"), System.Drawing.Font)
        Me.Splitter1.ImeMode = CType(resources.GetObject("Splitter1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Splitter1.Location = CType(resources.GetObject("Splitter1.Location"), System.Drawing.Point)
        Me.Splitter1.MinExtra = CType(resources.GetObject("Splitter1.MinExtra"), Integer)
        Me.Splitter1.MinSize = CType(resources.GetObject("Splitter1.MinSize"), Integer)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.RightToLeft = CType(resources.GetObject("Splitter1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Splitter1.Size = CType(resources.GetObject("Splitter1.Size"), System.Drawing.Size)
        Me.Splitter1.TabIndex = CType(resources.GetObject("Splitter1.TabIndex"), Integer)
        Me.Splitter1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Splitter1, resources.GetString("Splitter1.ToolTip"))
        Me.Splitter1.Visible = CType(resources.GetObject("Splitter1.Visible"), Boolean)
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'RichTextBox2
        '
        Me.RichTextBox2.AccessibleDescription = CType(resources.GetObject("RichTextBox2.AccessibleDescription"), String)
        Me.RichTextBox2.AccessibleName = CType(resources.GetObject("RichTextBox2.AccessibleName"), String)
        Me.RichTextBox2.Anchor = CType(resources.GetObject("RichTextBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.AutoSize = CType(resources.GetObject("RichTextBox2.AutoSize"), Boolean)
        Me.RichTextBox2.BackgroundImage = CType(resources.GetObject("RichTextBox2.BackgroundImage"), System.Drawing.Image)
        Me.RichTextBox2.BulletIndent = CType(resources.GetObject("RichTextBox2.BulletIndent"), Integer)
        Me.RichTextBox2.Dock = CType(resources.GetObject("RichTextBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.RichTextBox2.Enabled = CType(resources.GetObject("RichTextBox2.Enabled"), Boolean)
        Me.RichTextBox2.Font = CType(resources.GetObject("RichTextBox2.Font"), System.Drawing.Font)
        Me.RichTextBox2.ImeMode = CType(resources.GetObject("RichTextBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.RichTextBox2.Location = CType(resources.GetObject("RichTextBox2.Location"), System.Drawing.Point)
        Me.RichTextBox2.MaxLength = CType(resources.GetObject("RichTextBox2.MaxLength"), Integer)
        Me.RichTextBox2.Multiline = CType(resources.GetObject("RichTextBox2.Multiline"), Boolean)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.RightMargin = CType(resources.GetObject("RichTextBox2.RightMargin"), Integer)
        Me.RichTextBox2.RightToLeft = CType(resources.GetObject("RichTextBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.RichTextBox2.ScrollBars = CType(resources.GetObject("RichTextBox2.ScrollBars"), System.Windows.Forms.RichTextBoxScrollBars)
        Me.RichTextBox2.Size = CType(resources.GetObject("RichTextBox2.Size"), System.Drawing.Size)
        Me.RichTextBox2.TabIndex = CType(resources.GetObject("RichTextBox2.TabIndex"), Integer)
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        Me.ToolTip1.SetToolTip(Me.RichTextBox2, resources.GetString("RichTextBox2.ToolTip"))
        Me.RichTextBox2.Visible = CType(resources.GetObject("RichTextBox2.Visible"), Boolean)
        Me.RichTextBox2.WordWrap = CType(resources.GetObject("RichTextBox2.WordWrap"), Boolean)
        Me.RichTextBox2.ZoomFactor = CType(resources.GetObject("RichTextBox2.ZoomFactor"), Single)
        '
        'StatusBar1
        '
        Me.StatusBar1.AccessibleDescription = CType(resources.GetObject("StatusBar1.AccessibleDescription"), String)
        Me.StatusBar1.AccessibleName = CType(resources.GetObject("StatusBar1.AccessibleName"), String)
        Me.StatusBar1.Anchor = CType(resources.GetObject("StatusBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.BackgroundImage = CType(resources.GetObject("StatusBar1.BackgroundImage"), System.Drawing.Image)
        Me.StatusBar1.Dock = CType(resources.GetObject("StatusBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.StatusBar1.Enabled = CType(resources.GetObject("StatusBar1.Enabled"), Boolean)
        Me.StatusBar1.Font = CType(resources.GetObject("StatusBar1.Font"), System.Drawing.Font)
        Me.StatusBar1.ImeMode = CType(resources.GetObject("StatusBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.SystemStatusPanel})
        Me.StatusBar1.RightToLeft = CType(resources.GetObject("StatusBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        Me.StatusBar1.TabIndex = CType(resources.GetObject("StatusBar1.TabIndex"), Integer)
        Me.StatusBar1.Text = resources.GetString("StatusBar1.Text")
        Me.ToolTip1.SetToolTip(Me.StatusBar1, resources.GetString("StatusBar1.ToolTip"))
        Me.StatusBar1.Visible = CType(resources.GetObject("StatusBar1.Visible"), Boolean)
        '
        'SystemStatusPanel
        '
        Me.SystemStatusPanel.Alignment = CType(resources.GetObject("SystemStatusPanel.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.SystemStatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.SystemStatusPanel.Icon = CType(resources.GetObject("SystemStatusPanel.Icon"), System.Drawing.Icon)
        Me.SystemStatusPanel.MinWidth = CType(resources.GetObject("SystemStatusPanel.MinWidth"), Integer)
        Me.SystemStatusPanel.Text = resources.GetString("SystemStatusPanel.Text")
        Me.SystemStatusPanel.ToolTipText = resources.GetString("SystemStatusPanel.ToolTipText")
        Me.SystemStatusPanel.Width = CType(resources.GetObject("SystemStatusPanel.Width"), Integer)
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.AccessibleDescription = CType(resources.GetObject("AxWebBrowser1.AccessibleDescription"), String)
        Me.AxWebBrowser1.AccessibleName = CType(resources.GetObject("AxWebBrowser1.AccessibleName"), String)
        Me.AxWebBrowser1.Anchor = CType(resources.GetObject("AxWebBrowser1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AxWebBrowser1.AutoScroll = CType(resources.GetObject("AxWebBrowser1.AutoScroll"), Boolean)
        Me.AxWebBrowser1.AutoScrollMargin = CType(resources.GetObject("AxWebBrowser1.AutoScrollMargin"), System.Drawing.Size)
        Me.AxWebBrowser1.AutoScrollMinSize = CType(resources.GetObject("AxWebBrowser1.AutoScrollMinSize"), System.Drawing.Size)
        Me.AxWebBrowser1.BackgroundImage = CType(resources.GetObject("AxWebBrowser1.BackgroundImage"), System.Drawing.Image)
        Me.AxWebBrowser1.BrowserContextMenu = False
        Me.AxWebBrowser1.Dock = CType(resources.GetObject("AxWebBrowser1.Dock"), System.Windows.Forms.DockStyle)
        Me.AxWebBrowser1.Enabled = CType(resources.GetObject("AxWebBrowser1.Enabled"), Boolean)
        Me.AxWebBrowser1.Font = CType(resources.GetObject("AxWebBrowser1.Font"), System.Drawing.Font)
        Me.AxWebBrowser1.ImeMode = CType(resources.GetObject("AxWebBrowser1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.AxWebBrowser1.Location = CType(resources.GetObject("AxWebBrowser1.Location"), System.Drawing.Point)
        Me.AxWebBrowser1.Name = "AxWebBrowser1"
        Me.AxWebBrowser1.RightToLeft = CType(resources.GetObject("AxWebBrowser1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.AxWebBrowser1.Size = CType(resources.GetObject("AxWebBrowser1.Size"), System.Drawing.Size)
        Me.AxWebBrowser1.TabIndex = CType(resources.GetObject("AxWebBrowser1.TabIndex"), Integer)
        Me.ToolTip1.SetToolTip(Me.AxWebBrowser1, resources.GetString("AxWebBrowser1.ToolTip"))
        Me.AxWebBrowser1.Visible = CType(resources.GetObject("AxWebBrowser1.Visible"), Boolean)
        '
        'txtFieldLine
        '
        Me.txtFieldLine.AccessibleDescription = CType(resources.GetObject("txtFieldLine.AccessibleDescription"), String)
        Me.txtFieldLine.AccessibleName = CType(resources.GetObject("txtFieldLine.AccessibleName"), String)
        Me.txtFieldLine.Anchor = CType(resources.GetObject("txtFieldLine.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFieldLine.AutoSize = CType(resources.GetObject("txtFieldLine.AutoSize"), Boolean)
        Me.txtFieldLine.BackgroundImage = CType(resources.GetObject("txtFieldLine.BackgroundImage"), System.Drawing.Image)
        Me.txtFieldLine.Dock = CType(resources.GetObject("txtFieldLine.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFieldLine.Enabled = CType(resources.GetObject("txtFieldLine.Enabled"), Boolean)
        Me.txtFieldLine.Font = CType(resources.GetObject("txtFieldLine.Font"), System.Drawing.Font)
        Me.txtFieldLine.ImeMode = CType(resources.GetObject("txtFieldLine.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtFieldLine.Location = CType(resources.GetObject("txtFieldLine.Location"), System.Drawing.Point)
        Me.txtFieldLine.MaxLength = CType(resources.GetObject("txtFieldLine.MaxLength"), Integer)
        Me.txtFieldLine.Multiline = CType(resources.GetObject("txtFieldLine.Multiline"), Boolean)
        Me.txtFieldLine.Name = "txtFieldLine"
        Me.txtFieldLine.PasswordChar = CType(resources.GetObject("txtFieldLine.PasswordChar"), Char)
        Me.txtFieldLine.RightToLeft = CType(resources.GetObject("txtFieldLine.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtFieldLine.ScrollBars = CType(resources.GetObject("txtFieldLine.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtFieldLine.Size = CType(resources.GetObject("txtFieldLine.Size"), System.Drawing.Size)
        Me.txtFieldLine.TabIndex = CType(resources.GetObject("txtFieldLine.TabIndex"), Integer)
        Me.txtFieldLine.Text = resources.GetString("txtFieldLine.Text")
        Me.txtFieldLine.TextAlign = CType(resources.GetObject("txtFieldLine.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip1.SetToolTip(Me.txtFieldLine, resources.GetString("txtFieldLine.ToolTip"))
        Me.txtFieldLine.Visible = CType(resources.GetObject("txtFieldLine.Visible"), Boolean)
        Me.txtFieldLine.WordWrap = CType(resources.GetObject("txtFieldLine.WordWrap"), Boolean)
        '
        'cboFontName
        '
        Me.cboFontName.AccessibleDescription = CType(resources.GetObject("cboFontName.AccessibleDescription"), String)
        Me.cboFontName.AccessibleName = CType(resources.GetObject("cboFontName.AccessibleName"), String)
        Me.cboFontName.Anchor = CType(resources.GetObject("cboFontName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboFontName.BackgroundImage = CType(resources.GetObject("cboFontName.BackgroundImage"), System.Drawing.Image)
        Me.cboFontName.Dock = CType(resources.GetObject("cboFontName.Dock"), System.Windows.Forms.DockStyle)
        Me.cboFontName.Enabled = CType(resources.GetObject("cboFontName.Enabled"), Boolean)
        Me.cboFontName.Font = CType(resources.GetObject("cboFontName.Font"), System.Drawing.Font)
        Me.cboFontName.ImeMode = CType(resources.GetObject("cboFontName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboFontName.IntegralHeight = CType(resources.GetObject("cboFontName.IntegralHeight"), Boolean)
        Me.cboFontName.ItemHeight = CType(resources.GetObject("cboFontName.ItemHeight"), Integer)
        Me.cboFontName.Location = CType(resources.GetObject("cboFontName.Location"), System.Drawing.Point)
        Me.cboFontName.MaxDropDownItems = CType(resources.GetObject("cboFontName.MaxDropDownItems"), Integer)
        Me.cboFontName.MaxLength = CType(resources.GetObject("cboFontName.MaxLength"), Integer)
        Me.cboFontName.Name = "cboFontName"
        Me.cboFontName.RightToLeft = CType(resources.GetObject("cboFontName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboFontName.Size = CType(resources.GetObject("cboFontName.Size"), System.Drawing.Size)
        Me.cboFontName.TabIndex = CType(resources.GetObject("cboFontName.TabIndex"), Integer)
        Me.cboFontName.Text = resources.GetString("cboFontName.Text")
        Me.ToolTip1.SetToolTip(Me.cboFontName, resources.GetString("cboFontName.ToolTip"))
        Me.cboFontName.Visible = CType(resources.GetObject("cboFontName.Visible"), Boolean)
        '
        'cboFontSize
        '
        Me.cboFontSize.AccessibleDescription = CType(resources.GetObject("cboFontSize.AccessibleDescription"), String)
        Me.cboFontSize.AccessibleName = CType(resources.GetObject("cboFontSize.AccessibleName"), String)
        Me.cboFontSize.Anchor = CType(resources.GetObject("cboFontSize.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboFontSize.BackgroundImage = CType(resources.GetObject("cboFontSize.BackgroundImage"), System.Drawing.Image)
        Me.cboFontSize.Dock = CType(resources.GetObject("cboFontSize.Dock"), System.Windows.Forms.DockStyle)
        Me.cboFontSize.Enabled = CType(resources.GetObject("cboFontSize.Enabled"), Boolean)
        Me.cboFontSize.Font = CType(resources.GetObject("cboFontSize.Font"), System.Drawing.Font)
        Me.cboFontSize.ImeMode = CType(resources.GetObject("cboFontSize.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboFontSize.IntegralHeight = CType(resources.GetObject("cboFontSize.IntegralHeight"), Boolean)
        Me.cboFontSize.ItemHeight = CType(resources.GetObject("cboFontSize.ItemHeight"), Integer)
        Me.cboFontSize.Location = CType(resources.GetObject("cboFontSize.Location"), System.Drawing.Point)
        Me.cboFontSize.MaxDropDownItems = CType(resources.GetObject("cboFontSize.MaxDropDownItems"), Integer)
        Me.cboFontSize.MaxLength = CType(resources.GetObject("cboFontSize.MaxLength"), Integer)
        Me.cboFontSize.Name = "cboFontSize"
        Me.cboFontSize.RightToLeft = CType(resources.GetObject("cboFontSize.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboFontSize.Size = CType(resources.GetObject("cboFontSize.Size"), System.Drawing.Size)
        Me.cboFontSize.TabIndex = CType(resources.GetObject("cboFontSize.TabIndex"), Integer)
        Me.cboFontSize.Text = resources.GetString("cboFontSize.Text")
        Me.ToolTip1.SetToolTip(Me.cboFontSize, resources.GetString("cboFontSize.ToolTip"))
        Me.cboFontSize.Visible = CType(resources.GetObject("cboFontSize.Visible"), Boolean)
        '
        'tbCoolbar
        '
        Me.tbCoolbar.AccessibleDescription = CType(resources.GetObject("tbCoolbar.AccessibleDescription"), String)
        Me.tbCoolbar.AccessibleName = CType(resources.GetObject("tbCoolbar.AccessibleName"), String)
        Me.tbCoolbar.Anchor = CType(resources.GetObject("tbCoolbar.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.tbCoolbar.AutoScroll = CType(resources.GetObject("tbCoolbar.AutoScroll"), Boolean)
        Me.tbCoolbar.AutoScrollMargin = CType(resources.GetObject("tbCoolbar.AutoScrollMargin"), System.Drawing.Size)
        Me.tbCoolbar.AutoScrollMinSize = CType(resources.GetObject("tbCoolbar.AutoScrollMinSize"), System.Drawing.Size)
        Me.tbCoolbar.BackgroundImage = CType(resources.GetObject("tbCoolbar.BackgroundImage"), System.Drawing.Image)
        Me.tbCoolbar.Band1Image = Nothing
        Me.tbCoolbar.Band2Image = Nothing
        Me.tbCoolbar.Band3Image = Nothing
        Me.tbCoolbar.BandHeight = 0
        Me.tbCoolbar.Dock = CType(resources.GetObject("tbCoolbar.Dock"), System.Windows.Forms.DockStyle)
        Me.tbCoolbar.DontDrawShadow = False
        Me.tbCoolbar.Enabled = CType(resources.GetObject("tbCoolbar.Enabled"), Boolean)
        Me.tbCoolbar.Font = CType(resources.GetObject("tbCoolbar.Font"), System.Drawing.Font)
        Me.tbCoolbar.ImeMode = CType(resources.GetObject("tbCoolbar.ImeMode"), System.Windows.Forms.ImeMode)
        Me.tbCoolbar.Location = CType(resources.GetObject("tbCoolbar.Location"), System.Drawing.Point)
        Me.tbCoolbar.MaxVerticalBands = 1
        Me.tbCoolbar.Name = "tbCoolbar"
        Me.tbCoolbar.RightToLeft = CType(resources.GetObject("tbCoolbar.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.tbCoolbar.Size = CType(resources.GetObject("tbCoolbar.Size"), System.Drawing.Size)
        Me.tbCoolbar.TabIndex = CType(resources.GetObject("tbCoolbar.TabIndex"), Integer)
        Me.ToolTip1.SetToolTip(Me.tbCoolbar, resources.GetString("tbCoolbar.ToolTip"))
        Me.tbCoolbar.Visible = CType(resources.GetObject("tbCoolbar.Visible"), Boolean)
        '
        'cboSearchTool
        '
        Me.cboSearchTool.AccessibleDescription = CType(resources.GetObject("cboSearchTool.AccessibleDescription"), String)
        Me.cboSearchTool.AccessibleName = CType(resources.GetObject("cboSearchTool.AccessibleName"), String)
        Me.cboSearchTool.Anchor = CType(resources.GetObject("cboSearchTool.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboSearchTool.BackgroundImage = CType(resources.GetObject("cboSearchTool.BackgroundImage"), System.Drawing.Image)
        Me.cboSearchTool.Dock = CType(resources.GetObject("cboSearchTool.Dock"), System.Windows.Forms.DockStyle)
        Me.cboSearchTool.Enabled = CType(resources.GetObject("cboSearchTool.Enabled"), Boolean)
        Me.cboSearchTool.Font = CType(resources.GetObject("cboSearchTool.Font"), System.Drawing.Font)
        Me.cboSearchTool.ImeMode = CType(resources.GetObject("cboSearchTool.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboSearchTool.IntegralHeight = CType(resources.GetObject("cboSearchTool.IntegralHeight"), Boolean)
        Me.cboSearchTool.ItemHeight = CType(resources.GetObject("cboSearchTool.ItemHeight"), Integer)
        Me.cboSearchTool.Location = CType(resources.GetObject("cboSearchTool.Location"), System.Drawing.Point)
        Me.cboSearchTool.MaxDropDownItems = CType(resources.GetObject("cboSearchTool.MaxDropDownItems"), Integer)
        Me.cboSearchTool.MaxLength = CType(resources.GetObject("cboSearchTool.MaxLength"), Integer)
        Me.cboSearchTool.Name = "cboSearchTool"
        Me.cboSearchTool.RightToLeft = CType(resources.GetObject("cboSearchTool.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboSearchTool.Size = CType(resources.GetObject("cboSearchTool.Size"), System.Drawing.Size)
        Me.cboSearchTool.TabIndex = CType(resources.GetObject("cboSearchTool.TabIndex"), Integer)
        Me.cboSearchTool.Text = resources.GetString("cboSearchTool.Text")
        Me.ToolTip1.SetToolTip(Me.cboSearchTool, resources.GetString("cboSearchTool.ToolTip"))
        Me.cboSearchTool.Visible = CType(resources.GetObject("cboSearchTool.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = CType(resources.GetObject("Panel1.AccessibleDescription"), String)
        Me.Panel1.AccessibleName = CType(resources.GetObject("Panel1.AccessibleName"), String)
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.AxWebBrowser1, Me.RichTextBox1})
        Me.Panel1.Dock = CType(resources.GetObject("Panel1.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel1.Enabled = CType(resources.GetObject("Panel1.Enabled"), Boolean)
        Me.Panel1.Font = CType(resources.GetObject("Panel1.Font"), System.Drawing.Font)
        Me.Panel1.ImeMode = CType(resources.GetObject("Panel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = CType(resources.GetObject("Panel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.Panel1.TabIndex = CType(resources.GetObject("Panel1.TabIndex"), Integer)
        Me.Panel1.Text = resources.GetString("Panel1.Text")
        Me.ToolTip1.SetToolTip(Me.Panel1, resources.GetString("Panel1.ToolTip"))
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'ctmNodeDrag
        '
        Me.ctmNodeDrag.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ctmNDCopyHere, Me.ctmNDMoveHere, Me.ctmNDLinkHere, Me.MenuItem11, Me.ctmNDCopyBranchHere, Me.ctmNDMoveBranchHere, Me.ctmNDLinkBranchHere, Me.MenuItem7, Me.ctmNDCancel})
        Me.ctmNodeDrag.RightToLeft = CType(resources.GetObject("ctmNodeDrag.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'ctmNDCopyHere
        '
        Me.ctmNDCopyHere.Enabled = CType(resources.GetObject("ctmNDCopyHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDCopyHere, -1)
        Me.ctmNDCopyHere.Index = 0
        Me.ctmNDCopyHere.OwnerDraw = True
        Me.ctmNDCopyHere.Shortcut = CType(resources.GetObject("ctmNDCopyHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDCopyHere.ShowShortcut = CType(resources.GetObject("ctmNDCopyHere.ShowShortcut"), Boolean)
        Me.ctmNDCopyHere.Text = resources.GetString("ctmNDCopyHere.Text")
        Me.ctmNDCopyHere.Visible = CType(resources.GetObject("ctmNDCopyHere.Visible"), Boolean)
        '
        'ctmNDMoveHere
        '
        Me.ctmNDMoveHere.Enabled = CType(resources.GetObject("ctmNDMoveHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDMoveHere, -1)
        Me.ctmNDMoveHere.Index = 1
        Me.ctmNDMoveHere.OwnerDraw = True
        Me.ctmNDMoveHere.Shortcut = CType(resources.GetObject("ctmNDMoveHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDMoveHere.ShowShortcut = CType(resources.GetObject("ctmNDMoveHere.ShowShortcut"), Boolean)
        Me.ctmNDMoveHere.Text = resources.GetString("ctmNDMoveHere.Text")
        Me.ctmNDMoveHere.Visible = CType(resources.GetObject("ctmNDMoveHere.Visible"), Boolean)
        '
        'ctmNDLinkHere
        '
        Me.ctmNDLinkHere.Enabled = CType(resources.GetObject("ctmNDLinkHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDLinkHere, -1)
        Me.ctmNDLinkHere.Index = 2
        Me.ctmNDLinkHere.OwnerDraw = True
        Me.ctmNDLinkHere.Shortcut = CType(resources.GetObject("ctmNDLinkHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDLinkHere.ShowShortcut = CType(resources.GetObject("ctmNDLinkHere.ShowShortcut"), Boolean)
        Me.ctmNDLinkHere.Text = resources.GetString("ctmNDLinkHere.Text")
        Me.ctmNDLinkHere.Visible = CType(resources.GetObject("ctmNDLinkHere.Visible"), Boolean)
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = CType(resources.GetObject("MenuItem11.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem11, -1)
        Me.MenuItem11.Index = 3
        Me.MenuItem11.OwnerDraw = True
        Me.MenuItem11.Shortcut = CType(resources.GetObject("MenuItem11.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem11.ShowShortcut = CType(resources.GetObject("MenuItem11.ShowShortcut"), Boolean)
        Me.MenuItem11.Text = resources.GetString("MenuItem11.Text")
        Me.MenuItem11.Visible = CType(resources.GetObject("MenuItem11.Visible"), Boolean)
        '
        'ctmNDCopyBranchHere
        '
        Me.ctmNDCopyBranchHere.Enabled = CType(resources.GetObject("ctmNDCopyBranchHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDCopyBranchHere, -1)
        Me.ctmNDCopyBranchHere.Index = 4
        Me.ctmNDCopyBranchHere.OwnerDraw = True
        Me.ctmNDCopyBranchHere.Shortcut = CType(resources.GetObject("ctmNDCopyBranchHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDCopyBranchHere.ShowShortcut = CType(resources.GetObject("ctmNDCopyBranchHere.ShowShortcut"), Boolean)
        Me.ctmNDCopyBranchHere.Text = resources.GetString("ctmNDCopyBranchHere.Text")
        Me.ctmNDCopyBranchHere.Visible = CType(resources.GetObject("ctmNDCopyBranchHere.Visible"), Boolean)
        '
        'ctmNDMoveBranchHere
        '
        Me.ctmNDMoveBranchHere.Enabled = CType(resources.GetObject("ctmNDMoveBranchHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDMoveBranchHere, -1)
        Me.ctmNDMoveBranchHere.Index = 5
        Me.ctmNDMoveBranchHere.OwnerDraw = True
        Me.ctmNDMoveBranchHere.Shortcut = CType(resources.GetObject("ctmNDMoveBranchHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDMoveBranchHere.ShowShortcut = CType(resources.GetObject("ctmNDMoveBranchHere.ShowShortcut"), Boolean)
        Me.ctmNDMoveBranchHere.Text = resources.GetString("ctmNDMoveBranchHere.Text")
        Me.ctmNDMoveBranchHere.Visible = CType(resources.GetObject("ctmNDMoveBranchHere.Visible"), Boolean)
        '
        'ctmNDLinkBranchHere
        '
        Me.ctmNDLinkBranchHere.Enabled = CType(resources.GetObject("ctmNDLinkBranchHere.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDLinkBranchHere, -1)
        Me.ctmNDLinkBranchHere.Index = 6
        Me.ctmNDLinkBranchHere.OwnerDraw = True
        Me.ctmNDLinkBranchHere.Shortcut = CType(resources.GetObject("ctmNDLinkBranchHere.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDLinkBranchHere.ShowShortcut = CType(resources.GetObject("ctmNDLinkBranchHere.ShowShortcut"), Boolean)
        Me.ctmNDLinkBranchHere.Text = resources.GetString("ctmNDLinkBranchHere.Text")
        Me.ctmNDLinkBranchHere.Visible = CType(resources.GetObject("ctmNDLinkBranchHere.Visible"), Boolean)
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = CType(resources.GetObject("MenuItem7.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.MenuItem7, -1)
        Me.MenuItem7.Index = 7
        Me.MenuItem7.OwnerDraw = True
        Me.MenuItem7.Shortcut = CType(resources.GetObject("MenuItem7.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem7.ShowShortcut = CType(resources.GetObject("MenuItem7.ShowShortcut"), Boolean)
        Me.MenuItem7.Text = resources.GetString("MenuItem7.Text")
        Me.MenuItem7.Visible = CType(resources.GetObject("MenuItem7.Visible"), Boolean)
        '
        'ctmNDCancel
        '
        Me.ctmNDCancel.Enabled = CType(resources.GetObject("ctmNDCancel.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ctmNDCancel, -1)
        Me.ctmNDCancel.Index = 8
        Me.ctmNDCancel.OwnerDraw = True
        Me.ctmNDCancel.Shortcut = CType(resources.GetObject("ctmNDCancel.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ctmNDCancel.ShowShortcut = CType(resources.GetObject("ctmNDCancel.ShowShortcut"), Boolean)
        Me.ctmNDCancel.Text = resources.GetString("ctmNDCancel.Text")
        Me.ctmNDCancel.Visible = CType(resources.GetObject("ctmNDCancel.Visible"), Boolean)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = resources.GetString("OpenFileDialog1.Filter")
        Me.OpenFileDialog1.Title = resources.GetString("OpenFileDialog1.Title")
        '
        'btnNewBranch
        '
        Me.btnNewBranch.Enabled = CType(resources.GetObject("btnNewBranch.Enabled"), Boolean)
        Me.btnNewBranch.ImageIndex = CType(resources.GetObject("btnNewBranch.ImageIndex"), Integer)
        Me.btnNewBranch.Text = resources.GetString("btnNewBranch.Text")
        Me.btnNewBranch.ToolTipText = resources.GetString("btnNewBranch.ToolTipText")
        Me.btnNewBranch.Visible = CType(resources.GetObject("btnNewBranch.Visible"), Boolean)
        '
        'btnRedo
        '
        Me.btnRedo.Enabled = CType(resources.GetObject("btnRedo.Enabled"), Boolean)
        Me.btnRedo.ImageIndex = CType(resources.GetObject("btnRedo.ImageIndex"), Integer)
        Me.btnRedo.Text = resources.GetString("btnRedo.Text")
        Me.btnRedo.ToolTipText = resources.GetString("btnRedo.ToolTipText")
        Me.btnRedo.Visible = CType(resources.GetObject("btnRedo.Visible"), Boolean)
        '
        'ContextMenuHTML
        '
        Me.ContextMenuHTML.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ContextMenuHTMLView, Me.ContextMenuHTMLPrint})
        Me.ContextMenuHTML.RightToLeft = CType(resources.GetObject("ContextMenuHTML.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'ContextMenuHTMLView
        '
        Me.ContextMenuHTMLView.Enabled = CType(resources.GetObject("ContextMenuHTMLView.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ContextMenuHTMLView, -1)
        Me.ContextMenuHTMLView.Index = 0
        Me.ContextMenuHTMLView.OwnerDraw = True
        Me.ContextMenuHTMLView.Shortcut = CType(resources.GetObject("ContextMenuHTMLView.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ContextMenuHTMLView.ShowShortcut = CType(resources.GetObject("ContextMenuHTMLView.ShowShortcut"), Boolean)
        Me.ContextMenuHTMLView.Text = resources.GetString("ContextMenuHTMLView.Text")
        Me.ContextMenuHTMLView.Visible = CType(resources.GetObject("ContextMenuHTMLView.Visible"), Boolean)
        '
        'ContextMenuHTMLPrint
        '
        Me.ContextMenuHTMLPrint.Enabled = CType(resources.GetObject("ContextMenuHTMLPrint.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.ContextMenuHTMLPrint, -1)
        Me.ContextMenuHTMLPrint.Index = 1
        Me.ContextMenuHTMLPrint.OwnerDraw = True
        Me.ContextMenuHTMLPrint.Shortcut = CType(resources.GetObject("ContextMenuHTMLPrint.Shortcut"), System.Windows.Forms.Shortcut)
        Me.ContextMenuHTMLPrint.ShowShortcut = CType(resources.GetObject("ContextMenuHTMLPrint.ShowShortcut"), Boolean)
        Me.ContextMenuHTMLPrint.Text = resources.GetString("ContextMenuHTMLPrint.Text")
        Me.ContextMenuHTMLPrint.Visible = CType(resources.GetObject("ContextMenuHTMLPrint.Visible"), Boolean)
        '
        'ctmHighlight
        '
        Me.ctmHighlight.RightToLeft = CType(resources.GetObject("ctmHighlight.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'menuEnhancer
        '
        Me.menuEnhancer.ColorsControl = System.Drawing.SystemColors.Control
        Me.menuEnhancer.ColorsHighlight = System.Drawing.SystemColors.Highlight
        Me.menuEnhancer.ColorsWindow = System.Drawing.SystemColors.Window
        Me.menuEnhancer.ImageListMarks = Nothing
        '
        'mnuInsertTable
        '
        Me.mnuInsertTable.Enabled = CType(resources.GetObject("mnuInsertTable.Enabled"), Boolean)
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertTable, -1)
        Me.mnuInsertTable.Index = 5
        Me.mnuInsertTable.Shortcut = CType(resources.GetObject("mnuInsertTable.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuInsertTable.ShowShortcut = CType(resources.GetObject("mnuInsertTable.ShowShortcut"), Boolean)
        Me.mnuInsertTable.Text = resources.GetString("mnuInsertTable.Text")
        Me.mnuInsertTable.Visible = CType(resources.GetObject("mnuInsertTable.Visible"), Boolean)
        '
        'frmPad
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.cboSearchTool, Me.cboFontSize, Me.cboFontName, Me.Splitter1, Me.TreeView1, Me.txtFieldLine, Me.RichTextBox2, Me.StatusBar1, Me.tbCoolbar})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.DockPadding.Left = 2
        Me.DockPadding.Right = 2
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmPad"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        CType(Me.SystemStatusPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 

    Private StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic")) 

    Private frmResources As New IPIconsPack.Resource() 
    Dim lbooRTFWordWrap As Boolean 
    Dim WithEvents mnuTemplateViewSource As MenuItem
    Dim lbooHTMLMouseDownAdded As Boolean 
    Dim lstrHTMLFormData As String = "" 
    Dim WithEvents m_PrintRichTextDocument As RichTextPrintDocument
    Dim lstrAddQuickLaunchEtc As String ' Boolean = False
    Dim lbooScrollButtonClicked As Boolean
    Dim lstrTopicCode As String
    Dim lstrParentTopicCode As String
    Dim mstrIndexArray() As TreeTopics
    Dim lstrSymbolicLinkCode As String
    Dim lbooLoadDataNow As Boolean = True
    'Dim lbooViewingMCLDoc As Boolean = True
    Dim TipShown As Boolean = False
    Dim NewNode As TreeNode
    Dim DestinationNode As TreeNode
    Dim lbooShowStartupPage As Boolean = True
    Dim mstrStartupTopic As String 
    Dim lbooDBAccOrUIAcc As Boolean = False 
    Dim lstrCurTopicCode As String = "" 
    Dim lstrCurLockFlag As String = "" 
    Dim lbooRTFContentsChanged As Boolean = False 
    Dim lbooDontAllowRTBLeaveToUpdateTemplateTopic As Boolean = False 
    Dim lstrOldFormData As String 
    Private miBookMark As MenuItem 
    Private miTemplate As MenuItem 
    Dim lstrCFUCode As String 
    Dim CurrentRTFHighlightColour As Color 
    Dim lbooFx11FixDontLeaveNow As Boolean = False 
    'Dim YPosExtra As Integer 
    Dim lstrQuickLinkTag As String 

    Friend Enum DocumentViews 
        NormalTopic
        MCLGettingStarted
        MCLStartup
        MCLLicense
    End Enum
    Friend lcurDocumentView As DocumentViews = DocumentViews.MCLStartup 
    'Private Const WM_SHOWWINDOW = &H18
    Private m_loaded As Boolean

    
    Dim mintRTFDragAfterSelStart As Integer
    Dim mintRTFDragAfterSelLength As Integer
    Dim mintRTFDragCurSelStart As Integer
    Dim mintRTFDragCurSelLength As Integer
    Dim mstrRTFDragCurrentSelection As String = ""
    

    Dim lbooDisableDragNDrop As Boolean = False 
    Dim lbooJusthadRTBDoubleClick As Boolean = False 
    Dim ThisDragSelctionIdx As Integer 
    'Dim TreeMouseDown As Boolean = False 

    Dim SearchHistroy As SearchWithHistory 
    Friend Enum tbBand 
        Standard = 0
        Branch = 1
        Font = 2
        Search = 3
    End Enum
    Dim lbooSixMonthVersionCFUDone As Boolean   

    Dim RootNode As Boolean = False '
    Dim FirstNode As Boolean = False '
    Dim LastNode As Boolean = False '
    Dim NoNode As Boolean = False '
    Dim SwapFlag As Boolean = False '
    Dim SelectAll As Boolean = False '
    Dim p As Point '
    Dim Y As Integer '
    Dim keyEnter As Boolean = False '
    Dim keyTab As Boolean = False

    Dim RTFConMenuSelStart As Integer 
    Dim RTFConMenuSelLength As Integer 

    Private Sub frmPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddCrashComment("#PLD1") 
        gstrMRPs = "0471"

        If m_loaded = True Then 
            Exit Sub 
        End If

        m_loaded = True 
        gstrMRPs = "0473"

        AddDebugComment("frmPad_Load - Start") 

        Me.Icon = GetIcon(Me, "mcl32.ico") 
        gstrMRPs = "0474"
        RichTextBox1.HideSelection = False 

        
        AddHandler RichTextBox1.DragEnter, AddressOf richTextBox1_DragEnter
        AddHandler RichTextBox1.DragDrop, AddressOf richTextBox1_DragDrop

        SetBackcolors() 

        Timer1.Interval = 1000
        Timer1.Enabled = True
        '
        AddCrashComment("#PLD2") 
        Dim lbooImgIdxNotFound As Boolean = False 
        Dim lbooTemplateIDNotFound As Boolean = False 
        Dim lbooDetailByteLenNotFound As Boolean = False 
        Dim lbooDetailOptionsNotFound As Boolean = False 
        Dim lbooSettingsTableNotFound As Boolean = False 
        Dim lbooTableDetsTableNotFound As Boolean = False 

        'Me.Text = NameMe("") 'Me.Text)
        Me.Text = NameMe(GetIBShortName(gstrDataFileName)) 
        gstrMRPs = "0490"
        AddProgressPanel()

        tbCoolbar.AddBandEvents(3) '2) 
        tbCoolbar.MaxVerticalBands = 3 

        AddToolbarButtons() 
        ResizeFontToolbarForXPStyle() 

        'PoxpulateTree(TreeView1, mstrIndexArray)
        'Moved to form activated
        'StatusBar1.Panels(0).Text = "Welcome to " & NameMe("") 'IdeasPad"

        'moved further down , so people without Sets table don't get an error 
        '''Dim frmResource As New IPIconsPack.Resource() 
        ''''TreeView1.ImageList = frmResource.ilTreeIcons 
        '''TreeView1.ImageList = AddUserIcons(frmResource.ilTreeIcons) 

        ''''menuEnhancer.ImageList = frmResource.ilToolButtons 
        ''''menuEnhancer.ImageList = frmResource.ilMenuIcons 
        '''menuEnhancer.ImageList = frmResource.ilMenuIcons256 
        '''menuEnhancer.ImageListMarks = frmResource.ilTreeIcons 

        Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
        gstrMRPs = "0520"
        SetFonts(InitialConfig) 
        AddCrashComment("#PLD3") 
        With InitialConfig

            tbCoolbar.LoadToolbarPositions(InitialConfig, GetToolbarIndentity) 
            mnuViewToolbar1.Checked = tbCoolbar.Bands(tbBand.Standard).Visible 
            mnuViewToolbar2.Checked = tbCoolbar.Bands(tbBand.Branch).Visible 
            mnuViewToolbar3.Checked = tbCoolbar.Bands(tbBand.Font).Visible 
            mnuViewToolbar4.Checked = tbCoolbar.Bands(tbBand.Search).Visible 

            'settings
            gstrSortOrder = .GetValue("Tree Sort Order", "ALPHA")
            lbooShowStartupPage = CBool(.GetValue("Show Startup Page", "TRUE"))

            gintMoveBranchIncr = CInt(.GetValue("Move Branch IncrDecr", "10")) 

            If lbooShowStartupPage = False Then 
                mstrStartupTopic = .GetValue("Startup Topic", "") 
            Else 
                ShowBrowser() 
            End If

            Dim llngTreeWidth As Long = CLng(.GetValue("Tree Width", "112"))
            TreeView1.Width = llngTreeWidth
            gstrMRPs = "0550"
            
            If .GetValue("RTF Highlight Colour", "") = "" Then
                CurrentRTFHighlightColour = Color.Yellow
            Else
                CurrentRTFHighlightColour = Color.FromArgb(CInt(.GetValue("RTF Highlight Colour", Color.Yellow.ToArgb.ToString)))
            End If
            UpdateHighLightButton()
            
            lstrAddQuickLaunchEtc = .GetValue("Added Quick Launch", "FALSE").ToString.ToUpper

            lbooRTFWordWrap = CBool(.GetValue("Document Word Wrap", "FALSE")) 

            'not sure why the code above was taken out, think it was to do with use of screen ?
            Dim LastTop As Integer = CInt(.GetValue("LastTop", "-1"))
            Dim LastLeft As Integer = CInt(.GetValue("LastLeft", "-1"))
            If LastTop <> -1 Then
                Dim LastWidth As Integer = CInt(.GetValue("LastWidth", "800"))
                Dim LastHeight As Integer = CInt(.GetValue("LastHeight", "600"))
                Me.Top = LastTop
                Me.Left = LastLeft
                Me.Width = LastWidth
                Me.Height = LastHeight
            End If
            

            AddCrashComment("#PLD4") 
            gstrMRPs = "0560"
            Try 
                AxWebBrowser1.SetFontSize(CInt(.GetValue("Browser Font Size", 0)))   
            Catch 
            End Try

            lstrCFUCode = .GetValue("CFU Code", "10") 

            
            If .GetValue("DictionaryFile", "") = "" Then
                SetDefDictionaryWhenBlank()
            End If
            

            gbooAlwaysOnTop = CBool(.GetValue("AlwaysOnTop", "False")) 

            SearchHistroy = New SearchWithHistory(cboSearchTool, InitialConfig)
            lbooSixMonthVersionCFUDone = CBool(.GetValue("SixMonthVersionCFUDone", False)) 
        End With
        InitialConfig = Nothing
        gstrMRPs = "0574"
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            mnuHelpBuy.Visible = False
        End If
        AddCrashComment("#PLD5") 
        '--- Check to see what modifications are required! ---
        lstrDBID = GetFieldValuesX("DBID")

        
        'if Database ID is available
        If lstrDBID <> "" Then 
            Dim lcnn0 As New ADODB.Connection() 
            lcnn0 = New ADODB.Connection()
            lcnn0.Open(gstrConnectionString)

            Try
                lcnn0.Execute("select count(ImgIdx) as ctr From Topics ;")
                'Catch ex As Exception

            Catch ex As System.Runtime.InteropServices.COMException 

                'If ex.Message = "No value given for one or more required parameters." Then
                If ex.ErrorCode = -2147217904 Then 'added for German language compatibility
                    'ImgIdx field has not been found in database table topics
                    lbooImgIdxNotFound = True
                End If
            End Try
            lcnn0.Close()
        Else 
            'This database will not have ImgIdx as it doesn't have a database ID which is an older update
            lbooImgIdxNotFound = True 
        End If 

        gstrMRPs = "0595"
        AddCrashComment("#PLD6") 
        
        'if version 1.0.3, which introduced ImgIdx
        If lbooImgIdxNotFound = False Then
            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()
            lcnn2.Open(gstrConnectionString)
            Try
                'lcnn2.Execute("select count(TemplateID) as ctr From TopicDetails ;")
                
                lcnn2.Execute("select count(TemplateID) as ctr From TopicDetail;")
                'Catch ex As Exception

            Catch ex As System.Runtime.InteropServices.COMException 

                'If ex.Message = "No value given for one or more required parameters." Then
                If ex.ErrorCode = -2147217904 Then 'added for German language compatibility
                    'TemplateID field has not been found in database table TopicDetail
                    lbooTemplateIDNotFound = True
                End If
            End Try

            lcnn2.Close()
        Else
            'This database will not have TemplateID as it doesn't have a ImgIdx which is an older update
            lbooTemplateIDNotFound = True
        End If
        
        AddCrashComment("#PLD7") 
        gstrMRPs = "0615"
        
        If lbooTemplateIDNotFound = False Then
            AddDebugComment("frmPad.Load ByteLen Field Check") 
            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()
            lcnn2.Open(gstrConnectionString)
            Try
                lcnn2.Execute("select count(ByteLen) as ctr From TopicDetail;")
            Catch ex As System.Runtime.InteropServices.COMException
                If ex.ErrorCode = -2147217904 Then
                    lbooDetailByteLenNotFound = True
                End If
            End Try

            lcnn2.Close()
        Else
            'This database will not have ByteLen as it doesn't have a TemplateID which is an older update
            lbooDetailByteLenNotFound = True
        End If
        
        gstrMRPs = "0634"
        
        If lbooDetailByteLenNotFound = False Then
            AddDebugComment("frmPad.Load Options Field Check") 
            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()
            lcnn2.Open(gstrConnectionString)
            Try
                lcnn2.Execute("select count(Options) as ctr From TopicDetail;")
            Catch ex As System.Runtime.InteropServices.COMException
                If ex.ErrorCode = -2147217904 Then
                    lbooDetailOptionsNotFound = True
                End If
            End Try

            lcnn2.Close()
        Else
            'This database will not have Options as it doesn't have a ByteLen which is an older update
            lbooDetailOptionsNotFound = True
        End If
        
        gstrMRPs = "0650"
        AddCrashComment("#PLD8") 
        
        If lbooDetailOptionsNotFound = False Then
            AddDebugComment("frmPad.Load Settings Table Check")
            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()
            lcnn2.Open(gstrConnectionString)
            Try
                lcnn2.Execute("select count(ident) as idents From Sets;")
            Catch ex As System.Runtime.InteropServices.COMException
                If ex.ErrorCode = -2147217865 Then
                    lbooSettingsTableNotFound = True
                End If
            End Try

            lcnn2.Close()
        Else
            'This database will not have a settings table as it doesn't have a Options field which is an older update
            lbooSettingsTableNotFound = True
        End If
        

        
        If lbooSettingsTableNotFound = False Then
            AddDebugComment("frmPad.Load table Dets Table Check")
            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()
            lcnn2.Open(gstrConnectionString)
            Try
                lcnn2.Execute("select count(ident) as idents From TableDetails;")
            Catch ex As System.Runtime.InteropServices.COMException
                If ex.ErrorCode = -2147217865 Then
                    lbooTableDetsTableNotFound = True
                End If
            End Try

            lcnn2.Close()
        End If
        

        '----
        'At this point we know from evaluating certain variables lstrDBID, lbooImgIdxNotFound, lbooTemplateIDNotFound
        'what fields the database has and what is needed
        '----
        AddCrashComment("#PLD9") 
        '--- Check to see what modifications are required! ---
        gstrMRPs = "0680"
        '--- perform modifactions ---
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)
        

        

        If lstrDBID = "" Then 'if the DB ID is blank, then the database is old and hasn't got the necessary fields
            AddDebugComment("frmPad.Load - lstrDBID=blank") 
            'basically V1.0.2 updates, I think
            
            Try : lcnn1.Execute("ALTER TABLE TopicMatches ADD COLUMN DBID text(50);") : Catch ex As Exception : End Try
            '--- 
            Try : lcnn1.Execute("ALTER TABLE Topics ALTER COLUMN TopicCode text(13);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("ALTER TABLE Topics ALTER COLUMN ParentTopicCode text(13);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ALTER COLUMN TopicCode text(13);") : Catch ex1 As Exception : End Try
            '--- 
            Try : lcnn1.Execute("create unique index TopicCode on Topics (TopicCode);") : Catch ex1 As Exception : End Try 

            Dim NewDBID As New Guid()
            NewDBID = NewDBID.NewGuid()
            lcnn1.Execute("Update TopicMatches set DBID = '" & NewDBID.ToString() & "';")
            lstrDBID = NewDBID.ToString()
        End If
        
        gstrMRPs = "0695"
        
        If lbooImgIdxNotFound = True Then
            AddDebugComment("frmPad.Load - lbooImgIdxNotFound = True") 
            'basically V1.0.3 updates
            Try : lcnn1.Execute("ALTER TABLE Topics ADD COLUMN ImgIdx INT;") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE Topics SET ImgIdx = 0;") : Catch ex1 As Exception : End Try
        End If
        
        AddCrashComment("#PLD10") 
        
        If lbooTemplateIDNotFound = True Then
            AddDebugComment("frmPad.Load - lbooTemplateIDNotFound = True") 
            'basically V1.0.4 updates
            'Try : lcnn1.Execute("ALTER TABLE TopicDetails ALTER COLUMN TemplateID text(13);") : Catch ex1 As Exception : End Try
            
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ADD COLUMN TemplateID text(13);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ALTER COLUMN TemplateID text(13);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ADD COLUMN LockingFlag text(50);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicDetail SET LockingFlag = '" & CreateLockingFlag("") & "';") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("ALTER TABLE TopicMatches ADD COLUMN DBver text(10);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicMatches SET DBver = '" & _
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).ProductVersion & "';") : Catch ex1 As Exception : End Try 
            
            
            Try : lcnn1.Execute("CREATE TABLE LICENSES (1 text(50), 2 text(50), 3 text(50), 4 text(50), 5 Text(1));") : Catch ex As Exception : End Try
        End If

        'Removed 
        '''--- 
        ''Try : lcnn1.Execute("ALTER TABLE TopicDetail ADD COLUMN LockingFlag text(50);") : Catch ex1 As Exception : End Try
        ''Try : lcnn1.Execute("UPDATE TopicDetail SET LockingFlag = '" & CreateLockingFlag("") & "' where LockingFLag is null;") : Catch ex1 As Exception : End Try
        ''Try : lcnn1.Execute("ALTER TABLE TopicMatches ADD COLUMN DBver text(10);") : Catch ex1 As Exception : End Try
        ''Try : lcnn1.Execute("UPDATE TopicMatches SET DBver = '" & _
        ''    System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).ProductVersion & "';") : Catch ex1 As Exception : End Try 
        ''Try : lcnn1.Execute("CREATE TABLE LICENSES (1 text(50), 2 text(50), 3 text(50), 4 text(50), 5 Text(1));") : Catch ex As Exception : End Try
        '''--- 
        gstrMRPs = "0705"
        

        
        If lbooDetailByteLenNotFound = True Then
            AddDebugComment("frmPad.Load ByteLen DB updates")
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ADD COLUMN ByteLen INT;") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicDetail SET ByteLen = -1;") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicMatches SET DBver = '" & _
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).ProductVersion & "';") : Catch ex1 As Exception : End Try 
        End If
        

        
        If lbooDetailOptionsNotFound = True Then
            AddDebugComment("frmPad.Load Options DB updates")
            Try : lcnn1.Execute("ALTER TABLE TopicDetail ADD COLUMN Options text(15);") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicDetail SET Options = 'Default';") : Catch ex1 As Exception : End Try
            Try : lcnn1.Execute("UPDATE TopicMatches SET DBver = '" & _
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).ProductVersion & "';") : Catch ex1 As Exception : End Try 

        End If
        

        
        If lbooSettingsTableNotFound = True Then
            Try : lcnn1.Execute("CREATE TABLE Sets (ident text(10), data text(255));") : Catch ex As Exception : End Try
        End If
        
        AddCrashComment("#PLD11") 


        
        If lbooTableDetsTableNotFound = True Then
            'Try : lcnn1.Execute("CREATE TABLE TableDetails (TID text(10), TopicCode text(13), Instructs memo, HumanRText memo, LockingFlag text(50));") : Catch ex As Exception : End Try
            Try : lcnn1.Execute("CREATE TABLE TableDetails (TID text(10), TopicCode text(13), Instructs memo, HumanRText memo);") : Catch ex As Exception : End Try

            'Try : lcnn1.Execute("DELETE * From TableDetails;") : Catch ex As Exception : End Try

            
            Try
                CleanUpAfterDupeBug(System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat")
            Catch ex As Exception
                AddCrashComment("#PLD11CLE")
            End Try
            
        End If
        

        lcnn1.Close() 

        gstrMRPs = "0715"
        '--- 
        Dim frmResource As New IPIconsPack.Resource() 
        'TreeView1.ImageList = frmResource.ilTreeIcons 
        TreeView1.ImageList = AddUserIcons(frmResource.ilTreeIcons) 
        menuEnhancer.ImageList = frmResource.ilMenuIcons256 
        menuEnhancer.ImageListMarks = frmResource.ilTreeIcons 
        '--- 


        
        Try
            Dim lstrLayoutsDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
                "\Layouts\"
            System.IO.Directory.CreateDirectory(lstrLayoutsDir)
        Catch
        End Try
        

        
        Try
            Dim lstrLayoutsDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
                "\Spelling\"
            System.IO.Directory.CreateDirectory(lstrLayoutsDir)
        Catch
        End Try
        

        'LoadResouces() 
        gstrMRPs = "0728"
        SetMenusText() 

        tbCoolbar.PopulateContextMenu() 

        CheckNode() 

        RichTextBox1.AutoWordSelection = False 

        lstrQuickLinkTag = LangText.GetString("InternalLink_Tag") 
        ClearCrashReport() 

        AddDebugComment("frmPad_Load - End") 
        gstrMRPs = "0740"
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        'If elEvts = True Then : Console.WriteLine("TreeView1_AfterSelect " & TreeView1.SelectedNode.Text & " TreeMouseDown=" & TreeMouseDown) : End If
        ''If elEvts = True Then : Console.WriteLine("TreeView1_AfterSelect " & TreeView1.SelectedNode.Text) : End If
        
        Dim tag As String
        Try
            tag = TreeView1.SelectedNode.Tag
        Catch
        End Try
        AddDebugComment("frmPad.TreeView1_AfterSelect " & tag) 
        

        'If lbooViewingMCLDoc = False And lbooDBAccOrUIAcc = False Then 
        If lcurDocumentView = DocumentViews.NormalTopic And lbooDBAccOrUIAcc = False Then 

            'If TreeMouseDown = False Then
            '    Exit Sub
            'End If
            'If elEvts = True Then : Console.WriteLine("TreeView1_AfterSelect - Showing topic") : End If

            BusyPad(Me, True)

            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
            'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "TreeView1_AfterSelect")
            'lstrHTMLFormData = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me)

            '
            ''Dim lstrTemplateFileName, lstrFormData As String
            ''Dim lbooSysTemplate As Boolean

            '''GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
            '''    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
            ''
            ''lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
            ''    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
            ''lbooRTFContentsChanged = False 'reset 

            ''If lstrTemplateFileName <> "" Then
            ''    If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
            ''    ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
            ''    lcurDocumentView = DocumentViews.NormalTopic 
            ''End If
            '

            ''With RichTextBox1
            ''    .ReadOnly = False
            ''    '.WordWrap = True 
            ''    .WordWrap = lbooRTFWordWrap 
            ''    '.ShowSelectionMargin = True 
            ''    .ScrollBars = RichTextBoxScrollBars.Both
            ''End With
            '''StatusBar1.Panels(0).Text = "Viewing - " & TreeView1.SelectedNode.FullPath ' & " DEBUG Tag=" & TreeView1.SelectedNode.Tag
            ''
            ''StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath ' & " DEBUG Tag=" & TreeView1.SelectedNode.Tag

            GetSelectedTreeTopic() 

            BusyPad(Me, False)
        End If

    End Sub
    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown

        'TreeMouseDown = True 

        'If elEvts = True Then : Console.WriteLine("TreeView1_MouseDown") : End If
        AddDebugComment("frmPad.TreeView1_MouseDown") 

        UpdateRTFToDB()


        '---------------

        TreeView1.SelectedNode = TreeView1.GetNodeAt(selectPoint)
        '
        ''TreeView1.SelectedNode = TreeView1.GetNodeAt(selectPoint)
        'Dim XPos As Integer
        'Dim YPos As Integer
        'XPos = selectPoint.X - (Me.Location.X + 6)
        'YPos = selectPoint.Y - (Me.Location.Y + 86) '76
        'TreeView1.SelectedNode = TreeView1.GetNodeAt(XPos, YPos)
        ''--- 

        If Not (TreeView1.SelectedNode Is Nothing) Then 
            'If lbooViewingMCLDoc = True Then
            If lcurDocumentView <> DocumentViews.NormalTopic Then

                'If elEvts = True Then : Console.WriteLine("TreeView1_MouseDown - Showing topic") : End If
                AddDebugComment("frmPad.TreeView1_MouseDown - Showing topic") 
                BusyPad(Me, True)

                lstrCurTopicCode = TreeView1.SelectedNode.Tag 
                'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "TreeView1_MouseDown")
                'lstrHTMLFormData = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me)

                '
                ''Dim lstrTemplateFileName, lstrFormData As String
                ''Dim lbooSysTemplate As Boolean
                '''GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                '''    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                ''
                ''lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                ''    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                ''lbooRTFContentsChanged = False 'reset 

                ''If lstrTemplateFileName <> "" Then
                ''    If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
                ''    ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
                ''    lcurDocumentView = DocumentViews.NormalTopic 
                ''End If
                '

                ''With RichTextBox1
                ''    .ReadOnly = False
                ''    '.WordWrap = True 
                ''    .WordWrap = lbooRTFWordWrap 
                ''    '.ShowSelectionMargin = True 
                ''    .ScrollBars = RichTextBoxScrollBars.Both
                ''End With
                ''Try 
                ''    StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath

                ''Catch ex As Exception 
                ''End Try 

                GetSelectedTreeTopic() 

                BusyPad(Me, False)
            End If
        Else

            'If elEvts = True Then : Console.WriteLine("TreeView1_MouseDown - Normal topic") : End If
            AddDebugComment("frmPad.TreeView1_MouseDown - Normal topic") 
            'lstrCurTopicCode = "" 
        End If


        Dim mouseEvents As MouseEventArgs
        mouseEvents = e
        selectPoint.Y = mouseEvents.Y
        selectPoint.X = mouseEvents.X

        'Code to disable Contextmenu items when the node is first, last, both or root
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Show menu only if the right mouse button is clicked.
            p = New Point(e.X, e.Y)
            ' Get the node that the user has clicked.
            Dim Node As TreeNode = TreeView1.GetNodeAt(p)
            If Not (Node Is Nothing) Then
                TreeView1.SelectedNode = Node
                CheckNodePosition()
                NoNode = False 'Sets NoNode (no node selected) to false
            Else
                NoNode = True
            End If
        End If
    End Sub
    Private Sub CheckNodePosition()
        If TreeView1.SelectedNode.Parent Is Nothing Then RootNode = True
        If TreeView1.SelectedNode.PrevNode Is Nothing Then FirstNode = True
        If TreeView1.SelectedNode.NextNode Is Nothing Then LastNode = True
    End Sub

    Private selectPoint As New System.Drawing.Point()
    Private Sub TreeView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseUp


        'TreeMouseDown = False 

        'We use this to pop up our context menus at the right places
        'Try
        lbooDBAccOrUIAcc = False 
        'If elEvts = True Then : Console.WriteLine("TreeView1_MouseUp") : End If
        AddDebugComment("frmPad.TreeView1_MouseUp") 

        'removed to stop topic change twice, see how you go with this
        'TreeView1.SelectedNode = TreeView1.GetNodeAt(selectPoint)

        '
        'Dim XPos As Integer
        'Dim YPos As Integer
        'XPos = selectPoint.X - (Me.Location.X + 6)
        'YPos = selectPoint.Y - (Me.Location.Y + 86) '76
        'TreeView1.SelectedNode = TreeView1.GetNodeAt(XPos, YPos)
        ''--- 

        If TreeView1.SelectedNode Is Nothing Then
            'lstrCurTopicCode = "" 
            Exit Sub
        End If


        If e.Button = MouseButtons.Right Then
            'Select Case TreeView1.SelectedNode.Tag
            '    Case "root"
            '''   ContextMenuAddGroup.Show(TreeView1, TreeView1.SelectedNode.Bounds.Location)
            '    Case Else
            'End Select

        ElseIf e.Button.Left Then

        End If
        'Catch

        'Finally

        'End Try
    End Sub
    Private Sub mnuItemAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemAdd.Click

        AddNewSubBranch("") 
    End Sub
    Private Function AddNewSubBranch(ByVal pstrTemplateID As String) As Boolean
        gstrMRPs = "0900"
        AddDebugComment("frmPad.AddNewSubBranch " & pstrTemplateID & " Start") 
        AddCrashComment("#PANSB1") 
        'LOCKING
        AddNewSubBranch = False 
        UpdateRTFToDB() 

        Dim lintRetval As DialogResult
        'Dim lstrSQL As String
        Dim lstrName As String
        'Dim lcnn1 As New ADODB.Connection()
        'Dim lsnaLists As New ADODB.Recordset()
        Dim llnglevel As Long = NodateLevel(TreeView1.SelectedNode) + 1

        'On Error GoTo ErrHandler
        Try
            If TreeView1.SelectedNode Is Nothing Then
                
                MessageBox.Show(LangText.GetString("Pad_MustSelectParent").Replace("[CR]", _
                    Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
                AddCrashComment("#PANSB2") 
                Exit Function
            End If
            With TreeView1.SelectedNode
                lstrParentTopicCode = .Tag '.Key

                BusyPad(Me, False)
                Dim BranchInput As New InputBox(gbooAlwaysOnTop)
                
                lstrName = BranchInput.Display(LangText.GetString("Pad_EnterBranch"), NameMe(LangText.GetString("Pad_NewSubBranch")))

                If lstrName = "" Then
                    Exit Function
                End If

                lstrName = JetSQLFixup(lstrName) 

                BranchInput.Dispose()
                If InStrGet(lstrName, "~") > 0 Then
                    
                    MessageBox.Show(LangText.GetString("Pad_BranchCharWarn"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props
                    AddCrashComment("#PANSB3") 
                    Exit Function
                End If

                BusyPad(Me, True)
                'glngLastTopicNum = glngLastTopicNum + 1
                glngLastTopicNum = GetLastTopicRealNumber() + 1 
                lstrTopicCode = "T" & FormatNumberGet(glngLastTopicNum, "0000000") 
                lstrTopicCode = GetNextTopicID() & "T" & FormatNumberGet(glngLastTopicNum, "0000000") 

                '--- commented out, doesn't hold true with sort order now! 
                TreeView1.BeginUpdate() 
                Dim tnNew As TreeNode

                tnNew = TreeView1.SelectedNode.Nodes.Add(lstrName)
                With tnNew
                    .Tag = lstrTopicCode
                End With
                TreeView1.SelectedNode.ExpandAll()
                ''lstrTopicCode = GetNxextTopicID() & "T" & Format(glngLastTopicNum, "0000")
                '--- commented out, doesn't hold true with sort order now! 
                AddCrashComment("#PANSB4") 
                
                'AddNewTopicCopyDetails(llnglevel, lstrName, lstrTopicCode, lstrParentTopicCode, "")
                
                
                'AddNewTopicCopyDetails(llnglevel, lstrName, lstrTopicCode, lstrParentTopicCode, "", 0, pstrTemplateID)
                
                'lstrCurLockFlag = CreateLockingFlag()'no this is set inside function
                'AddNewTopicCopyDetails(llnglevel, lstrName, lstrTopicCode, lstrParentTopicCode, "", 0, pstrTemplateID, lstrCurLockFlag)

                
                Dim SeqNum As Integer = (gintMoveBranchIncr * CountSiblings(TreeView1.SelectedNode))
                AddNewTopicCopyDetails(llnglevel, lstrName, lstrTopicCode, lstrParentTopicCode, "", 0, pstrTemplateID, lstrCurLockFlag, SeqNum, "Default")
                

                BusyPad(Me, False)
                
                TreeView1.SelectedNode = tnNew 'Commented out 
                'lbooViewingMCLDoc = False
                lcurDocumentView = DocumentViews.NormalTopic 
                TreeView1_AfterSelect(Nothing, Nothing) 'commented out 
                
                ''TreeView1.Nodes.Clear()
                ''FillTreeTopics(TreeView1) ', mstrRealTopicCodes())
                'Else
                '    Exit Sub
                'End If
                '''TreeView1_AfterSelect(Nothing, Nothing) 
                lbooDBAccOrUIAcc = True 
                PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder) 
                lstrCurTopicCode = lstrTopicCode 
                'SelectNodeByTag(lstrCurTopicCode) 
                SelectNodeByTag(lstrCurTopicCode, TreeView1, lcurDocumentView) 
                lbooDBAccOrUIAcc = False 
                TreeView1.EndUpdate() 
            End With

        Finally
            BusyPad(Me, False)
        End Try

        AddNewSubBranch = True
        CheckNode() 
        ClearCrashReport() 
        AddDebugComment("frmPad.AddNewSubBranch " & pstrTemplateID & " end") 

        Exit Function
        'ErrHandler:
        'bxsy(Me, False)
        'GlobalErrorHandler(Err.Number, "Pad.mnuItemAdd_Click")

    End Function
    Private Sub mnuItemRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemRename.Click
        AddDebugComment("frmPad.mnuItemRename_Click") 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        Dim lstrName As String

        Try
            If TreeView1.SelectedNode Is Nothing Then
                
                MessageBox.Show(LangText.GetString("Pad_MustSelectABranch"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                Exit Sub
            End If

            With TreeView1.SelectedNode
                BusyPad(Me, True)
                Dim BranchInput As New InputBox(gbooAlwaysOnTop)
                
                lstrName = BranchInput.Display(LangText.GetString("Pad_EnterBranchName"), NameMe(LangText.GetString("Pad_NewBranch")), TreeView1.SelectedNode.Text)

                BranchInput.Dispose()
                If lstrName = "" Then
                    Exit Sub
                End If

                lstrName = JetSQLFixup(lstrName) 

                lcnn1 = New ADODB.Connection()
                lcnn1.Open(gstrConnectionString)

                lstrSQL = "UPDATE Topics SET Topics.Title = '" & lstrName & _
                    "' WHERE (((Topics.TopicCode)='" & TreeView1.SelectedNode.Tag & "'));"
                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
                lcnn1.Close()
                
                TreeView1.SelectedNode.Text = UnJetSQLFixup(lstrName) 
                BusyPad(Me, False)
                'End If
            End With
        Finally
            BusyPad(Me, False)
        End Try

        'Exit Sub
        'ErrHandler:
        'bxsy(Me, False)
        'GlobalErrorHandler(Err.Number, "Pad.mnuItemRename_Click")

    End Sub
    Private Sub mnuFileSelectivePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSelectivePrint.Click
        gstrMRPs = "0903"
        AddDebugComment("frmPad.mnuFileSelectivePrint_Click") 

        UpdateRTFToDB() 

        Application.DoEvents() 

        Dim SelectivePrint As New SelectivePrint()
        SelectivePrint.OutputType = SelectivePrint.OutputTypes.Print 
        SelectivePrint.Disables = main.PopulateTreeDisables.DisableTemplateTopics 
        SelectivePrint.Owner = Me 
        SelectivePrint.TopMost = gbooAlwaysOnTop 
        SelectivePrint.ShowDialog()

    End Sub
    Private Sub mnuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click

        If RichTextBox1.Visible = True Then
            With RichTextBox1
                .Cut()
                .Focus()
            End With
        Else
            'AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_CUT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER) 
            AxWebBrowser1.Cut() 
        End If

    End Sub
    Private Sub mnuEditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCopy.Click

        AddDebugComment("frmPad.mnuEditCopy_Click") 

        If RichTextBox1.Visible = True Then
            With RichTextBox1
                .Copy()
                .Focus()
            End With
        Else
            'AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_COPY, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, 0, 0) 
            AxWebBrowser1.Copy() 
        End If

    End Sub
    Private Sub mnuEditPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click
        'AddDebugComment("frmPad.mnuEditPaste_Click - start") 
        gstrProbComtStack = "frmPad.mnuEditPaste_Click - start" 
        Dim data As IDataObject = Clipboard.GetDataObject

        'AddDebugComment("frmPad.mnuEditPaste_Click - 1") 
        gstrProbComtStack &= " #EPC1" 

        If RichTextBox1.Visible = True Then
            With RichTextBox1
                'If Clipboard.GetDataObject().GetDataPresent(DataFormats.CommaSeparatedValue) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.Dif) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.Html) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.Locale) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.OemText) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.PenData) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.StringFormat) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.SymbolicLink) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True _
                '    Or Clipboard.GetDataObject().GetDataPresent(DataFormats.UnicodeText) = True Then
                '    .Paste()
                '    .Focus()
                'ElseIf Clipboard.GetDataObject().GetDataPresent(DataFormats.Html) = True Then
                '    Dim MyFormat As DataFormats.Format = DataFormats.GetFormat(DataFormats.Rtf) 
                '    .Paste(MyFormat) 
                '    .Focus() 
                'End If 

                
                ' Check if there is any data in RTF format, 
                ' WITHOUT attempting a conversion.
                'If data.GetDataPresent(DataFormats.Html, False) Then
                '    .SelectedText = data.GetData(DataFormats.Text, True) '- work! just text though
                'If data.GetDataPresent(DataFormats.Rtf, False) Then
                '    ' If available, paste into the RTF selection.
                '    .SelectedRtf = data.GetData(DataFormats.Rtf).ToString
                'ElseIf data.GetDataPresent(DataFormats.Html, False) Then
                '    .SelectedText = data.GetData(DataFormats.Text, True) '- work! just text though
                'ElseIf data.GetDataPresent(DataFormats.Text, True) Then
                '    ' Else, attempt to get data in plain text format.
                '    .SelectedText = data.GetData(DataFormats.Text, True).ToString
                'Else
                '    .Paste()
                '    xx()
                'End If
                
                Select Case RTorHTML()
                    Case "BITMAP" 
                        Dim img As System.Drawing.Bitmap = CType(Windows.Forms.Clipboard.GetDataObject.GetData("Bitmap"), System.Drawing.Bitmap)
                        'RichTextBox1.InsertImage(img)
                        'AddDebugComment("frmPad.mnuEditPaste_Click - InsertImage") 
                        gstrProbComtStack &= " #IEPC2" 
                        
                        RichTextBox1.InsertImage(img, ProgresPanel)
                        
                    Case "HTML"
                        'AddDebugComment("frmPad.mnuEditPaste_Click - HTML") 
                        gstrProbComtStack &= " #EPC3" 
                        .SelectedText = data.GetData(DataFormats.Text, True)

                    Case "RTF"
                        'AddDebugComment("frmPad.mnuEditPaste_Click - RTF") 
                        gstrProbComtStack &= " #EPC4" 
                        .SelectedRtf = data.GetData(DataFormats.Rtf).ToString

                    Case Else
                        'AddDebugComment("frmPad.mnuEditPaste_Click - Paste 1") 
                        gstrProbComtStack &= " #EPC5" 
                        .Paste()
                End Select
                
                .Focus()
                
            End With
        Else
            'AddDebugComment("frmPad.mnuEditPaste_Click - Paste 2") 
            gstrProbComtStack &= " #EPC6" 
            'AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PASTE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER) 
            AxWebBrowser1.Paste() 
        End If

        RefreshCutCopyPaste(False) 

        'AddDebugComment("frmPad.mnuEditPaste_Click - end") 

        gstrProbComtStack &= " #EPC-End" 
        AddDebugComment(gstrProbComtStack) 
        gstrProbComtStack = "" 

    End Sub
    Private Sub mnuEditSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditSelectAll.Click

        If RichTextBox1.Visible = True Then 
            With RichTextBox1
                .SelectAll()
                .Focus()
            End With
        Else
            AxWebBrowser1.SelectAll() 
        End If

    End Sub
    Private Sub mnuEditRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditRedo.Click

        If RichTextBox1.Visible = True Then 
            With RichTextBox1
                .Redo()
                .Focus()
            End With
        Else 
            AxWebBrowser1.Redo() 
        End If

        RefreshCutCopyPaste(False) 
    End Sub
    Private Sub mnuEditUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditUndo.Click

        If RichTextBox1.Visible = True Then 
            With RichTextBox1
                .Undo()
                .Focus()
            End With
        Else 
            AxWebBrowser1.Undo() 
        End If

        RefreshCutCopyPaste(False) 
    End Sub
    Private Sub frmPad_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Dim lbooShowingStartupHTML As Boolean = False 

        'MessageBox.Show(Me.Top & " " & Me.Left & " " & Me.Width & " " & Me.Height)

        'On Error GoTo ErrHandler
        Try
            If lbooLoadDataNow = True Then
                gstrMRPs = "0750"
                BusyPad(Me, True)
                tbCoolbar.Enabled = False 
                AddDebugComment("frmPad.Activated - Start") 

                
                If gbooAlwaysOnTop = True Then
                    AlwaysOnTop(Me, True)
                End If
                

                
                Dim Status As New StatusDialog(Me)
                Status.TopMostIn = gbooAlwaysOnTop 
                Status.Show()
                'Status.Status = "Loading your settings ...."
                Status.Status = LangText.GetString("Pad_LoadingSettings") 

                

                'Setfonts()
                'setSettings()

                PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)

                RefreshBookMarksMenu() 

                
                RefreshTemplatesMenu()

                'AxWebBrowser1.Navigate("about:blank")
                ''PrefetchWebBrowser()
                
                gstrMRPs = "0765"
                If lbooShowStartupPage = True Then
                    mnuHelpStartup_Click(Nothing, Nothing)
                    'StatusBar1.Panels(0).Text = "Welcome to " & NameMe("") 
                    
                    StatusBar1.Panels(0).Text = LangText.GetString("Pad_WelcomeTo") & " " & NameMe("")
                Else
                    'Dim lintNodeCount As Integer = mstrIndexArray.GetUpperBound(0)
                    If mstrIndexArray(0).strTopicCode <> "" Then
                        If mstrStartupTopic = "" Then 
                            TreeView1.SelectedNode = TreeView1.Nodes(0) '.Nodes(0)
                            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
                        Else
                            lstrCurTopicCode = mstrStartupTopic 
                            If SelectNodeByTag(lstrCurTopicCode, TreeView1) = False Then 
                                TreeView1.SelectedNode = TreeView1.Nodes(0) 
                                lstrCurTopicCode = TreeView1.SelectedNode.Tag 
                            End If
                        End If
                        gstrMRPs = "0780"
                        
                        Dim lstrTemplateFileName, lstrFormData As String
                        Dim lbooSysTemplate As Boolean
                        'GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                        '    lstrTemplateFileName, lbooSysTemplate, lstrFormData)

                        '---- 
                        With RichTextBox1
                            .ReadOnly = False
                            '.WordWrap = True 
                            .WordWrap = lbooRTFWordWrap 

                            'SetWordWrap(RichTextBox1, lbooRTFWordWrap) 
                            '.ShowSelectionMargin = True 
                            ' .ScrollBars = RichTextBoxScrollBars.Both 'commented out
                        End With
                        '---- 

                        'Dim RtfLength As Integer = -1 'USED TO DEBUG ONLY 

                        
                        lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                            lstrTemplateFileName, lbooSysTemplate, lstrFormData) ',RtfLength


                        ''--- USED TO DEBUG ONLY 
                        'If RtfLength <> -1 Then
                        '    If RtfLength <> RichTextBox1.Rtf.Length Then
                        '        MessageBox.Show("Not correct rtf")
                        '    End If
                        'End If
                        ''--- USED TO DEBUG ONLY 
                        gstrMRPs = "0800"
                        lbooRTFContentsChanged = False 'reset 

                        If lstrTemplateFileName <> "" Then
                            If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
                            ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
                        End If
                        
                        'With RichTextBox1
                        '    .ReadOnly = False
                        '    '.WordWrap = True 
                        '    .WordWrap = lbooRTFWordWrap 
                        '    '.ShowSelectionMargin = True 
                        '    .ScrollBars = RichTextBoxScrollBars.Both
                        'End With
                        StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath
                        '----
                        'lbooViewingMCLDoc = False 
                        lcurDocumentView = DocumentViews.NormalTopic 
                        gstrMRPs = "0820"
                    Else
                        lbooShowingStartupHTML = True 
                        mnuHelpStartup_Click(Nothing, Nothing)
                        lstrCurTopicCode = "" 
                        'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "frmPad_Activated-NO")
                    End If

                End If
                tbCoolbar.Enabled = True 
                BusyPad(Me, False)
                lbooLoadDataNow = False
                Status.Close()

                Dim lstrQuitStr As String = StandardCheck(Me, gbooAlwaysOnTop)
                If lstrQuitStr <> "" Then
                    MessageBox.Show(lstrQuitStr.Replace("[CR]", Environment.NewLine).Replace("[CR2]", Environment.NewLine & Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
                    Application.DoEvents() 
                    frmPad_Closing(Nothing, Nothing)
                    gstrMRPs = "0840"
                    SaveMaxReachedPoint() 
                    End
                End If

                
                If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 
                    If lstrCFUCode = "30" Then
                        lstrCFUCode = ""
                        SaveSetting("CFU Code", "", InitalXMLConfig.XmlConfigType.AppSettings, "")
                        MessageBox.Show(LangText.GetString("Pad_90To30Message"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If 
                

                AddDebugComment("frmPad.Activated - 6M") 
                
                If lbooSixMonthVersionCFUDone = False Then
                    Dim BuildDate As Date = IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly.Location.ToString())
                    Dim Now As Date = Date.Now '.AddMonths(7) 'Add 7 months for testing purposes
                    If BuildDate.AddMonths(6) < Now Then
                        Dim DlgRes As DialogResult = MessageBox.Show(LangText.GetString("Pad_SixMonthCheck").Replace("[CR]", Environment.NewLine).Replace("[CR2]", Environment.NewLine & Environment.NewLine), _
                        NameMe(LangText.GetString("Pad_SixMonthTitle")), MessageBoxButtons.YesNo) 

                        'Dim DlgRes As DialogResult = MessageBox.Show("This program is at least six months old, there may now be a newer version." & Environment.NewLine & Environment.NewLine & _
                        '"Would you like to check for updates?", NameMe("Six Month Update Check"), MessageBoxButtons.YesNo)
                        If DlgRes = DialogResult.Yes Then
                            mnuHelpCFU_Click(Nothing, Nothing)
                        End If
                    End If
                    SaveSetting("SixMonthVersionCFUDone", True, InitalXMLConfig.XmlConfigType.AppSettings, "")
                    gstrMRPs = "0860"
                End If
                

                AddDebugComment("frmPad.Activated - Complete") 
                gstrMRPs = "0863"
            End If
        Catch
            gstrMRPs = "0865"
            AddDebugComment("frmPad.Activated - Catch") 
        Finally
            tbCoolbar.Enabled = True 
            BusyPad(Me, False)
            'AddDebugComment("frmPad.Activated - Finally!!") 
        End Try
        'ErrHandler:
        'bxsy(Me, False)
        'GlobalErrorHandler(Err.Number, "Pad.frmPad_Activated")

        System.Windows.Forms.Application.DoEvents()

        If TipShown = False Then
            TipShown = True
            ShowTipOfTheDay()
        End If

        If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 And gbooSevenDayWarning = True Then 
            gbooSevenDayWarning = False
            'mxessagebox.show("This trial will expire in seven days or less!" & Environment.NewLine & Environment.NewLine & _
            '                "If you like this product and wish to continue using it after the trial " & Environment.NewLine & _
            '                "expires you must buy it.  Please see out latest purchasing information " & Environment.NewLine & _
            '                "on our web site.  This can be accessed via the 'Help > Purchasing' " & Environment.NewLine & _
            '                "option on the menu.", NameMe("Expiration reminder"))

            
            'MessageBox.Show(LangText.GetString("Pad_SevenDaysleft"), NameMe(LangText.GetString("Pad_SevenDayCaption")), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props
            
            MessageBox.Show(LangText.GetString("Pad_SevenDaysleft").Replace("[Program]", gProgName).Replace("[CR]", Environment.NewLine).Replace("[CR2]", _
                Environment.NewLine & Environment.NewLine), NameMe(LangText.GetString("Pad_SevenDayCaption")), _
                MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props

            Me.Focus() 
        End If



        '
        ''Try
        ''    If lstrAddQuickLaunchEtc.ToUpper = "FALSE" Then
        ''        'lbooAddQuickLaunchEtc = True
        ''        lstrAddQuickLaunchEtc = True 
        ''        Dim lintDialogResult As DialogResult
        ''        'lintDialogResult = MxessageBox.Show("Would you like to add a shortcut to this program to your Quick Launch bar?", NameMe(""), MessageBoxButtons.YesNo)
        ''        
        ''        lintDialogResult = MxessageBox.Show(LangText.GetString("Pad_AskQuickLaunch").Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.YesNo)


        ''        AddQuickLaunchEtc(lintDialogResult)
        ''        'If lintDialogResult = DialogResult.Yes Then
        ''        SaveSetting("Added Quick Launch", "TRUE", InitalXMLConfig.XmlConfigType.AppSettings, "")
        ''        'Else
        ''        '    SaveSetting("Added Quick Launch", "FALSE", InitalXMLConfig.XmlConfigType.AppSettings, "")
        ''        'End If
        ''        Me.Focus() 'always needs focus
        ''        'End If
        ''    End If
        ''Catch ex As Exception
        ''End Try

        If lbooShowingStartupHTML = True Then 
            'try and make images shows, weirdness
            System.Windows.Forms.Application.DoEvents() 
            AxWebBrowser1.Refresh() 
        End If


        RefreshCutCopyPaste(True) 

    End Sub
    Private Sub mnuEdit_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.Select

        'If RichTextBox1.SelectionLength > 0 Then
        '    mnuEditCopy.Enabled = True
        '    mnuEditCut.Enabled = True
        'Else
        '    mnuEditCopy.Enabled = False
        '    mnuEditCut.Enabled = False
        'End If

        'mnuEditRedo.Enabled = RichTextBox1.CanRedo
        'mnuEditUndo.Enabled = RichTextBox1.CanUndo
        RefreshCutCopyPaste(False)

        'mnuEditWordWrap.Checked = lbooRTFWordWrap 
    End Sub
    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown

        'If elEvtsRTB = True Then : Console.WriteLine("RichTextBox1_KeyDown") : End If
        AddDebugComment("frmPad.RichTextBox1_KeyDown") 

        'If RichTextBox1.SelectionLength > 0 Then
        '    'btnCopy.Enabled = True
        '    'btnCut.Enabled = True
        '    'ToolBar1.Buttons.Item(6).Enabled = True 'Cut 
        '    'ToolBar1.Buttons.Item(7).Enabled = True 'copy 
        '    ToolBar1.Buttons.Item(GetBtnIdx("Cut")).Enabled = True 'Cut 
        '    ToolBar1.Buttons.Item(GetBtnIdx("Copy")).Enabled = True 'copy 
        'Else
        '    'btnCopy.Enabled = False
        '    'btnCut.Enabled = False
        '    'ToolBar1.Buttons.Item(6).Enabled = False 'Cut 
        '    'ToolBar1.Buttons.Item(7).Enabled = False 'copy 
        '    ToolBar1.Buttons.Item(GetBtnIdx("Cut")).Enabled = False 'Cut 
        '    ToolBar1.Buttons.Item(GetBtnIdx("Copy")).Enabled = False 'copy 
        'End If
        ''btnUndo.Enabled = RichTextBox1.CanUndo
        ''ToolBar1.Buttons.Item(10).Enabled = RichTextBox1.CanUndo 'Undo 
        'ToolBar1.Buttons.Item(GetBtnIdx("Undo")).Enabled = RichTextBox1.CanUndo 'Undo 

        'If e.Shift And e.KeyCode = Keys.Tab Then
        '    If elEvts = True Then : Console.WriteLine("e.shift and tab") : End If
        'End If

        
        If e.Shift And e.KeyCode = Keys.Insert Then
            mnuEditPaste_Click(Nothing, Nothing)
            e.Handled = True
        End If

        If e.Shift And e.KeyCode = Keys.Delete Then
            mnuEditCut_Click(Nothing, Nothing)
            e.Handled = True
        End If
        
        RefreshCutCopyPaste(False)
        If e.KeyCode = Keys.Back Then
            If SelectAll Then
                RichTextBox1.Text = ""
                RichTextBox1.SelectionBullet = False
                SelectAll = False
            Else
                Dim Flag As Boolean = False
                Dim ColPos As Integer
                ColPos = GetCharPos()
                If ColPos = 1 And e.KeyCode = Keys.Back Then
                    Flag = RichTextBox1.SelectionBullet
                    RichTextBox1.SelectionBullet = False
                    If Flag Then
                        e.Handled = True
                        Flag = False
                    End If
                End If
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            keyEnter = True
        ElseIf Not e.Alt And Not e.Shift And Not e.Control And Not e.KeyCode = Keys.CapsLock And Not e.KeyCode = Keys.Escape And _
            Not e.KeyCode = Keys.RWin And Not e.KeyCode = Keys.LWin And Not e.KeyCode = Keys.F1 And Not e.KeyCode = Keys.F2 _
            And Not e.KeyCode = Keys.F3 And Not e.KeyCode = Keys.F4 And Not e.KeyCode = Keys.F5 And Not e.KeyCode = Keys.F6 _
            And Not e.KeyCode = Keys.F7 And Not e.KeyCode = Keys.F8 And Not e.KeyCode = Keys.F9 And Not e.KeyCode = Keys.F10 _
            And Not e.KeyCode = Keys.F11 And Not e.KeyCode = Keys.F12 And Not e.KeyCode = Keys.Apps _
            And Not e.KeyCode = Keys.Pause And Not e.KeyCode = Keys.NumLock And Not e.KeyCode = Keys.Scroll Then
            keyEnter = False
            If e.KeyCode = Keys.Tab Then
                keyTab = True
            Else
                keyTab = False
            End If
        End If


        ' ''''END OF CODE----------------------------
    End Sub
    Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click

        AddDebugComment("frmPad.mnuFileExit_Click") 
        Me.Close()

    End Sub
    Private Sub RichTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.Leave

        'If elEvtsRTB = True Then : Console.WriteLine("RichTextBox1_Leave") : End If
        AddDebugComment("frmPad.RichTextBox1_Leave") 

        If lbooDontAllowRTBLeaveToUpdateTemplateTopic = False Then 
            'Console.WriteLine("RTBLeave AxWebBrowser1.Visible= " & AxWebBrowser1.Visible)
            'Console.WriteLine("RTBLeave RichTextBox1.Visible= " & RichTextBox1.Visible)
            'If lbooDBAccOrUIAcc = False Or AxWebBrowser1.Visible = False Then 
            'Console.WriteLine("RichTextBox1_Leave")
            UpdateRTFToDB()
        End If

        'End If
        'If lbooViewingMCLDoc = False Then
        '    If Not (TreeView1.SelectedNode Is Nothing) Then
        'bxsy(Me, True)
        'UpdateTopicDetailRTF(ReturnTrueTopicStr(TreeView1.SelectedNode.Tag), RichTextBox1)
        'bxsy(Me, False)
        '    End If
        'End If

    End Sub
    Private Sub mnuItemDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemDelete.Click
        AddDebugComment("frmPad.mnuItemDelete_Click") 
        Dim lintTopicCount As String
        Dim lstrDeleteMessage As String
        Dim lintRetVal As DialogResult
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection

        If TreeView1.SelectedNode Is Nothing Then
            'mxessagebox.show("You must select a branch first!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_MustSelectABranch"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Exit Sub
        End If

        Dim lstrSelectedTag As String = TreeView1.SelectedNode.Tag
        'Check to see whether this topic is used as a parent anywhere
        BusyPad(Me, True)
        If GetTopicCountAsParent(lstrSelectedTag) > 0 Then
            BusyPad(Me, False)
            'mxessagebox.show("This topic has child branches, you would have to delete them first before deleting this branch!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_MustDeleteChilds"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Exit Sub
        End If

        'inform the user that the topic will no long be accessable
        'lintTopicCount = GetTopicCount(lstrSelectedTag)
        lintTopicCount = CheckToMakeOrphan(lstrSelectedTag) 

        If lintTopicCount = 1 Then
            'lstrDeleteMessage = "WARNING: This branch is not linked anywhere else, by deleting " & Environment.NewLine() & _
            '    "it you will not be able to view it." & Environment.NewLine() & Environment.NewLine()
            
            'lstrDeleteMessage = "WARNING: This branch is not linked anywhere else, by deleting " & _
            '    "it you will not be able to view it." & Environment.NewLine() & Environment.NewLine()
            
            lstrDeleteMessage = LangText.GetString("Pad_WarnNotLinked") & Environment.NewLine() & Environment.NewLine()

        End If

        'inform any way
        BusyPad(Me, False)
        'lintRetVal = MxessageBox.Show(lstrDeleteMessage & "Do you wish to delete this topic?", NameMe(""), MessageBoxButtons.YesNo)
        
        lintRetVal = MessageBox.Show(lstrDeleteMessage & LangText.GetString("Pad_DoDelete"), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

        If lintRetVal = DialogResult.Yes Then
            'delete topic
            BusyPad(Me, True)
            lcnn1 = New ADODB.Connection
            'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
            lcnn1.Open(gstrConnectionString)
            'Conxsole.WriteLine("DB:mnuItemdelete_Click")
            'MsgxBox("deleting " & TreeView1.SelectedNode.FullPath & " " & lstrSelectedTag)

            lstrSQL = "Delete * from Topics where TopicCode = '" & lstrSelectedTag & "';"
            gstrLastSQL = lstrSQL 

            lcnn1.Execute(lstrSQL)

            'delete topic detail
            If lintTopicCount = 1 Then
                lstrSQL = "Delete * from TopicDetail where TopicCode = '" & ReturnTrueTopicStr(lstrSelectedTag) & "';"
                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
            End If
            lcnn1.Close()
			
            Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(TreeView1.ImageList, lstrDBID)
            lMaintBookMark.RemoveBookMarks(lstrSelectedTag, lstrDBID, InitalXMLConfig.XmlConfigType.Bookmarks, "Bookmarks-", "BookmarkImgIdx-", "", TreeView1.SelectedNode.Text)
            RefreshBookMarksMenu()

            TreeView1.SelectedNode.Remove() 

            If TreeView1.GetNodeCount(True) = 0 Then
                mnuHelpStartup_Click(Nothing, Nothing)
            End If
            BusyPad(Me, False)
            CheckNode()
        End If
    End Sub
    Private Sub mnuRTFCut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFCut.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditCut_Click(Nothing, Nothing)

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuRTFUndo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFUndo.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditUndo_Click(Nothing, Nothing)

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuRTFCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFCopy.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditCopy_Click(Nothing, Nothing)

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuRTFPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFPaste.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditPaste_Click(Nothing, Nothing)

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuRTFSelectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFSelectAll.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditSelectAll_Click(Nothing, Nothing)

        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuRTFDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFDelete.Click

        AddDebugComment("frmPad.mnuRTFDelete_Click - start") 

        Dim KeptSelStart As Integer = RichTextBox1.SelectionStart 

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        If RichTextBox1.Visible = True Then 
            With RichTextBox1
                .SelectedText = ""
                .Focus()
            End With
        End If

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        
        If RTFConMenuSelStart = 0 And KeptSelStart <> 0 Then
            RichTextBox1.SelectionStart = KeptSelStart
        End If
        
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

        AddDebugComment("frmPad.mnuRTFDelete_Click - End") 

    End Sub
    Private Sub mnuHelpBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpBuy.Click
        gstrMRPs = "0906"

        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.buy)) 
    End Sub
    Private Sub mnuHelpAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click

        AddDebugComment("frmPad.mnuHelpAbout_Click") 

        Application.DoEvents() 

        Dim NewAbout As New frmAbout()
        With NewAbout
            .Owner = Me 
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With

    End Sub
    Private Sub mnuFileNewRoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileNewRoot.Click

        AddNewRootBranch("") 
    End Sub
    Private Function AddNewRootBranch(ByVal pstrTemplateID As String) As Boolean

        gstrMRPs = "0909"
        AddCrashComment("#PANRB1") 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrUserInput As String
        Dim lstrTopicCode As String
        Dim lstrSQL As String
        Dim lstrTTopicStr As String

        AddDebugComment("frmPad.AddNewRootBranch " & pstrTemplateID & " Start") 

        
        Try
            pstrTemplateID = pstrTemplateID.ToUpper
        Catch
            '
        End Try
        

        AddNewRootBranch = True 

        UpdateRTFToDB() 

        AddDebugComment("frmPad.AddNewRootBranch 1") 
        AddCrashComment("#PANRB2") 
        'On Error GoTo ErrHandler
        Try

            Dim KeyInput As New InputBox(gbooAlwaysOnTop)
            
            lstrUserInput = KeyInput.Display(LangText.GetString("Pad_EnterRootName"), NameMe(""))

            AddDebugComment("frmPad.AddNewRootBranch 2") 

            KeyInput.Dispose()
            If lstrUserInput Is Nothing Then
                AddNewRootBranch = False 
                Exit Function ' was on one line before and
            End If 

            If lstrUserInput.Trim = "" Then
                AddNewRootBranch = False
                Exit Function
            End If
            If InStrGet(lstrUserInput, "~") > 0 Then
                
                MessageBox.Show(LangText.GetString("Pad_BranchCharWarn"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
                AddNewRootBranch = False
                Exit Function
            End If

            AddDebugComment("frmPad.AddNewRootBranch 3") 
            AddCrashComment("#PANRB3") 

            lstrUserInput = JetSQLFixup(lstrUserInput) 

            If lstrUserInput.Trim <> "" Then
                BusyPad(Me, True)
                lbooDBAccOrUIAcc = True 
                glngLastTopicNum = GetLastTopicRealNumber() + 1 
                lstrTopicCode = GetNextTopicID() & "T" & FormatNumberGet(glngLastTopicNum, "0000000") 

                lcnn1 = New ADODB.Connection()
                lcnn1.Open(gstrConnectionString)
                
                Dim SeqNum As Integer
                Try
                    SeqNum = (gintMoveBranchIncr * CountSiblings(TreeView1)) + gintMoveBranchIncr
                Catch
                    '
                End Try
                lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                    "Values(1, '" & lstrUserInput & "', '" & lstrTopicCode & "', '', " & SeqNum & ", True,0);"

                AddDebugComment("frmPad.AddNewRootBranch 4") 
                gstrLastSQL = lstrSQL 
                AddCrashComment("#PANRB4") 

                lcnn1.Execute(lstrSQL)

                If pstrTemplateID.Trim = "" Then 
                    pstrTemplateID = GetDefaultTemplateID() 'if blank use the default template if selected
                End If

                lstrTTopicStr = ReturnTrueTopicStr(lstrTopicCode)
                
                lstrCurLockFlag = CreateLockingFlag(lstrTTopicStr)
                
                Dim lstrDetail As String
                Try
                    If pstrTemplateID.Trim <> "" Then
                        lstrDetail = "<emaNtcatnoC></emaNtcatnoC>"
                    End If
                Catch

                End Try
                
                lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen, Options ) Values('" & _
                    lstrTTopicStr & "','" & lstrDetail & "','" & pstrTemplateID & "', '" & lstrCurLockFlag & "', -1, 'Default');"

                AddDebugComment("frmPad.AddNewRootBranch 5") 
                gstrLastSQL = lstrSQL 
                AddCrashComment("#PANRB5") 

                lcnn1.Execute(lstrSQL)
                lcnn1.Close()

                'TreeView1.Nodes.Clear()
                PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
                'If elEvts = True Then : Console.WriteLine("After Pop Tree, btnNewRoot_Click") : End If
                AddDebugComment("frmPad.AddNewRootBranch - After Pop Tree, btnNewRoot_Click") 
                lbooDBAccOrUIAcc = False
                BusyPad(Me, False)
                AddCrashComment("#PANRB6") 
                If pstrTemplateID = "" Then 
                    
                    If mstrIndexArray(0).strTopicCode <> "" Then
                        TreeView1.SelectedNode = TreeView1.Nodes(0)
                        'lbooViewingMCLDoc = False
                        lcurDocumentView = DocumentViews.NormalTopic 
                        TreeView1_AfterSelect(Nothing, Nothing)
                    End If
                    
                    'SelectNodeByTag(lstrTopicCode) 
                    SelectNodeByTag(lstrTopicCode, TreeView1, lcurDocumentView) 
                Else 
                    'SelectNodeByTag(lstrTopicCode) 
                    SelectNodeByTag(lstrTopicCode, TreeView1, lcurDocumentView) 
                    lcurDocumentView = DocumentViews.NormalTopic 
                    TreeView1_AfterSelect(Nothing, Nothing)
                End If 
            End If
        Finally
            BusyPad(Me, False)
        End Try
        'Exit Sub
        'ErrHandler:
        'bxsy(Me, False)
        'GlobalErrorHandler(Err.Number, "pad.btnNew_Click")
        CheckNode() 

        ClearCrashReport() 
        AddDebugComment("frmPad.AddNewRootBranch " & pstrTemplateID & " end") 

    End Function
    Private Sub mnuHelpGettingStarted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpGettingStarted.Click
        gstrMRPs = "0913"
        'bxsy(Me, True)

        'UpdateRTFToDB() 
        'TreeView1.SelectedNode = Nothing 
        'lstrCurTopicCode = "" 
        ''Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "mnuHelpGettingStarted_Click")
        'Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream("IdeasPad.getstart.rtf")

        'ShowRTF()

        'With RichTextBox1
        '    .ReadOnly = True
        '    .WordWrap = False 
        '    .ScrollBars = RichTextBoxScrollBars.ForcedBoth
        '    '.ShowSelectionMargin = False 
        '    If Not (stream Is Nothing) Then
        '        Dim sr As New System.IO.StreamReader(stream)
        '        .LoadFile(stream, RichTextBoxStreamType.RichText)
        '        sr.Close()
        '    End If
        'End With
        'stream.Close()
        ''lbooViewingMCLDoc = True
        'lcurDocumentView = DocumentViews.MCLGettingStarted 
        'StatusBar1.Panels(0).Text = "Viewing - Getting Started Document" 
        'bxsy(Me, False)

        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.quickstart)) 

    End Sub
    Private Sub mnuHelpStartup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpStartup.Click

        AddDebugComment("frmPad.mnuHelpStartup_Click") 

        BusyPad(Me, True)

        UpdateRTFToDB() 
        TreeView1.SelectedNode = Nothing 
        lstrCurTopicCode = "" 
        lstrCurLockFlag = "" 
        'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "mnuHelpStartup_Click")

        '--- commented out 
        'Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream("IdeasPad.IdeasPad.rtf")

        'ShowRTF()

        'With RichTextBox1
        '    .ReadOnly = True
        '    .WordWrap = False 
        '    .ScrollBars = RichTextBoxScrollBars.ForcedBoth
        '    '.ShowSelectionMargin = False 
        '    If Not (stream Is Nothing) Then
        '        Dim sr As New System.IO.StreamReader(stream)
        '        .LoadFile(stream, RichTextBoxStreamType.RichText)
        '        sr.Close()
        '    End If
        'End With
        'stream.Close()
        
        Dim TR As New IPTemplates._main() 
        Dim ass As System.Reflection.Assembly = System.Reflection.Assembly.Load("IPTemplates")

        '--- 
        'Dim TR As New IPTemplates._main() moved further up
        Dim lintArrInc As Integer
        Dim StartupFiles() As String

        TR.StartupFiles(StartupFiles)

        For lintArrInc = 0 To StartupFiles.GetUpperBound(0)

            'If File.Exists(Application.StartupPath & "\smallyellowball.bmp") = False Then 
            '    Dim streamYellowball As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates.smallyellowball.bmp")
            '    Dim lstrTempFileYB As String = Application.StartupPath & "\smallyellowball.bmp"
            '    Dim png As System.Drawing.Bitmap = New System.Drawing.Bitmap(streamYellowball)
            '    png.Save(lstrTempFileYB, System.Drawing.Imaging.ImageFormat.Bmp)
            'End If

            If File.Exists(Application.StartupPath & "\" & StartupFiles(lintArrInc)) = False Then 
                If StartupFiles(lintArrInc) <> "" Then 
                    Dim streamFile As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates." & StartupFiles(lintArrInc))
                    Dim lstrTempFile As String = Application.StartupPath & "\" & StartupFiles(lintArrInc)
                    Select Case RightGet(StartupFiles(lintArrInc), 4).ToUpper
                        Case ".BMP"
                            Dim png As System.Drawing.Bitmap = New System.Drawing.Bitmap(streamFile)
                            png.Save(lstrTempFile, System.Drawing.Imaging.ImageFormat.Bmp)
                        Case Else
                            'Dim StreamReaderStartup As New System.IO.StreamReader(streamFile)
                            
                            Dim StreamReaderStartup As New System.IO.StreamReader(streamFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))
                            Dim StreamWriter As StreamWriter = New StreamWriter(lstrTempFile)
                            Dim lstrFileData As String = StreamReaderStartup.ReadToEnd
                            StreamWriter.WriteLine(lstrFileData)
                            StreamReaderStartup.Close()
                            StreamWriter.Close()
                    End Select
                End If 
            End If 
            'End If
        Next lintArrInc
        '--- 

        '--- 
        Dim lstrStartupHTML As String = TR.GetStartupHTMLName 
        'If File.Exists(Application.StartupPath & "\startup.html") = False Then
        'If File.Exists(Application.StartupPath & "\" & lstrStartupHTML) = False Then 

        '--- startup page ---

        'Dim streamStartup As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates.startup.html")
        Dim streamStartup As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates." & lstrStartupHTML) 

        'Dim StreamReaderStartup As New System.IO.StreamReader(streamStartup)
        
        Dim StreamReaderStartup2 As New System.IO.StreamReader(streamStartup, System.Text.Encoding.GetEncoding("ISO-8859-1"))
        If NewFileRequired(Application.StartupPath & "\" & lstrStartupHTML, StreamReaderStartup2.BaseStream.Length) = True Then 
            'Dim lstrTempFile As String = Application.StartupPath & "\startup.html"
            Dim lstrTempFile As String = Application.StartupPath & "\" & lstrStartupHTML 
            Dim StreamWriter As StreamWriter = New StreamWriter(lstrTempFile)

            'ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1)
            'lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrTempFile

            'Replace CSS occurence in template with CSS variable
            Dim lstrHTMLFileData As String = StreamReaderStartup2.ReadToEnd
            StreamWriter.WriteLine(lstrHTMLFileData)

            StreamReaderStartup2.Close()
            StreamWriter.Close()
            '--- startup page ---
        End If
        '--- 

        'AxWebBrowser1.Navigate(Application.StartupPath & "\startup.html")
        AxWebBrowser1.Navigate(Application.StartupPath & "\" & lstrStartupHTML) 
        ShowBrowser()
        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Spelling", tbBand.Standard)).Enabled = False 
        

        'lbooViewingMCLDoc = True
        lcurDocumentView = DocumentViews.MCLStartup 
        StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - Startup Document"

        BusyPad(Me, False)
    End Sub
    Private Sub mnuHelpLicense_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpLicense.Click
        AddDebugComment("frmPad.mnuHelpLicense_Click") 
        'bxsy(Me, True)

        'UpdateRTFToDB() 
        'TreeView1.SelectedNode = Nothing 
        'lstrCurTopicCode = "" 
        ''Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "mnuHelpLicense_Click")

        'Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream("IdeasPad.agree.rtf")

        'ShowRTF()

        'With RichTextBox1
        '    .ReadOnly = True
        '    .ScrollBars = RichTextBoxScrollBars.ForcedBoth
        '    '.ShowSelectionMargin = False 
        '    If Not (stream Is Nothing) Then
        '        Dim sr As New System.IO.StreamReader(stream)
        '        .LoadFile(stream, RichTextBoxStreamType.RichText)
        '        sr.Close()
        '    End If
        'End With
        'stream.Close()

        ''lbooViewingMCLDoc = True
        'lcurDocumentView = DocumentViews.MCLLicense 
        'StatusBar1.Panels(0).Text = "Viewing - License Agreement Document" 
        'bxsy(Me, False)

        
        Dim LicenseBox As New LicenceBox()
        With LicenseBox
            .FormIcon = Me.Icon
            If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
                
                Dim lstrLang2Char As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
                Select Case lstrLang2Char
                    Case "de"
                        .LicenseSectionSkip = ", auszuleihen"
                    Case Else
                        .LicenseSectionSkip = "loan, copy, "
                End Select
                

                'LOCALISATION DIFFERENCE HERE
            End If
            .ProdName = NameMe("").ToUpper
            .SetPageSettings = m_PageSettings
            .Owner = Me 

            Application.DoEvents() 
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
            m_PageSettings = .SetPageSettings
        End With

    End Sub
    Private Sub mnuHelpSupport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpSupport.Click
        'bxsy(Me, True)
        'Dim psInfo As New System.Diagnostics.ProcessStartInfo("http://www.example.com/support.html")
        'psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'psInfo.CreateNoWindow = True
        'Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        'bxsy(Me, False)

        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.support)) 
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Never enabled, in previous version !
        'So don't want to cause any hassle now!
        'If flamenow() Then

        '    Dim lstrDetails(2) As String
        '    Dim lstrDetails1(1) As String
        '    lstrDetails(0) = "33eN[?OpJFXfUSLhGo"
        '    lstrDetails(1) = ">kijpjWSmJh_lc>wcpI=ivinbfj^]SbrtxjWAFh=QRnxLRKnZK\@hj]PmayXQGJEDppa`m"
        '    lstrDetails(2) = "=WyAOA_hec_;"

        '    lstrDetails1(0) = "33ywY_AYgr<XgHHPGC"
        '    lstrDetails1(1) = "eKTHtg<TWNwO;rv`NFw<TIBMKatVKtK@KxdP@VpYCEnDYdH\eHcOYhmPiHm<greOAIfC[;"

        '    'MsgxBox("IdeasPad hasn't got enough system resources to run properly." & vbCxrLf & vbCrxLf & _
        '    '"Please close some of your other programs and retry!")
        '    MessageBox.Show(Decrypt("", "", flame.Encops.EncryptString, lstrDetails) & Environment.NewLine() & Environment.NewLine() & _
        '    Decrypt("", "", flame.Encops.EncryptString, lstrDetails1), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
        '    End
        '    End
        'End If

        
        If lcurDocumentView = DocumentViews.NormalTopic And AxWebBrowser1.Visible = True Then
            RefreshCutCopyPaste(False)
        End If
        

    End Sub
    Private Sub mnuHelpCFU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpCFU.Click

        AddDebugComment("frmPad.mnuHelpCFU_Click") 
        Application.DoEvents() 
        

        'If hasMultipleInstances(gProgName, NameMe("")) = True Then
        If hasMultipleInstances(gProgName, NameMe(""), Me.Handle, StandLangText) = True Then 
            Exit Sub
        End If
        

        Application.DoEvents() 

        Dim NewCFU As New frmCFU(gbooAlwaysOnTop)
        With NewCFU
            .Caption = NameMe("")
            .FormIcon = Me.Icon
            .strManifestSite(gstrManifestSite)
            .Owner = Me 
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With

        If gbooNeedToRestartProgAfterCFU = True Then
            Me.Close()
        End If
    End Sub
    Private Sub TreeView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.Click
        'lbooViewingMCLDoc = False
        lcurDocumentView = DocumentViews.NormalTopic 

    End Sub
    Private Sub UpdateRTFToDB()

        AddDebugComment("frmPad.UpdateRTFToDB - Start") 

        'If lbooViewingMCLDoc = False Then
        If lcurDocumentView = DocumentViews.NormalTopic Then 
            If Not lstrCurTopicCode = "" Then 
                'If Not (TreeView1.SelectedNode Is Nothing) Then
                BusyPad(Me, True)
                If Not (TreeView1.SelectedNode Is Nothing) Then 
                    lstrCurTopicCode = TreeView1.SelectedNode.Tag() 
                End If

                'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "UpdateRTFToDB-DO")

                'UpdateTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1)
                AddDebugComment("frmPad.UpdateRTFToDB - " & lstrCurTopicCode) 
                If RichTextBox1.Visible = True And lbooRTFContentsChanged = False Then 
                    'do nothing, no changes made!                    
                Else 
                    
                    Dim res As Boolean 
                    res = UpdateTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, lstrCurLockFlag, lstrOldFormData, Me)
                    
                    If res = False Then
                        BusyPad(Me, True)
                        AddDebugComment("frmPad.UpdateRTFToDB - PopulateTree") 
                        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)

                        lbooDBAccOrUIAcc = False
                        If mstrIndexArray(0).strTopicCode = "" Then
                            mnuHelpStartup_Click(Nothing, Nothing)
                        Else
                            TreeView1.SelectedNode = TreeView1.Nodes(0)
                        End If
                        ProgresPanel.Value = 0
                        BusyPad(Me, False)
                        CheckNode()

                    End If
                    
                End If

                BusyPad(Me, False)
            Else
                lstrCurTopicCode = "" 
                lstrCurLockFlag = "" 
                'Conxsole.WriteLine("T#" & lstrCurTopicCode & Tab() & "UpdateRTFToDB-NO")
            End If
        End If
        AddDebugComment("frmPad.UpdateRTFToDB - END") 

    End Sub
    Private Sub RichTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseUp

        AddDebugComment("frmPad.RichTextBox1_MouseUp") 

        
        If e.Button = MouseButtons.Left Then
            If RichTextBox1.SelectionType = RichTextBoxSelectionTypes.Object Then
                RichTextBox1.SelectionLength = 0
            End If
        End If
        

        RefreshCutCopyPaste(False)

    End Sub
    Private Sub mnuHelpTipDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpTipDay.Click

        AddDebugComment("frmPad.mnuHelpTipDay_Click") 
        Application.DoEvents() 
        ShowTipOfTheDay(True)

    End Sub
    Private Sub mnuToolsOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsOptions.Click
        'AddDebugComment("frmPad.mnuToolsOptions_Click - Start") 
        gstrProbComtStack = "frmPad.mnuToolsOptions_Click - Start" 

        If lcurDocumentView = DocumentViews.NormalTopic Then 
            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
        End If

        'AddDebugComment("frmPad.mnuToolsOptions_Click - 1") 
        gstrProbComtStack &= " #TOC1" 

        lbooDBAccOrUIAcc = True 

        UpdateRTFToDB() 

        'AddDebugComment("frmPad.mnuToolsOptions_Click - 2") 
        gstrProbComtStack &= " #TOC2" 
        Application.DoEvents() 

        'AddDebugComment("frmPad.mnuToolsOptions_Click - 3") 
        gstrProbComtStack &= " #TOC3" 

        Dim ToolsOptions As New options()

        ToolsOptions.Owner = Me 

        ToolsOptions.TopMost = gbooAlwaysOnTop 
        ToolsOptions.ShowDialog()

        'AddDebugComment("frmPad.mnuToolsOptions_Click - 4") 
        gstrProbComtStack &= " #TOC4" 

        Application.DoEvents() 

        RefreshGeneralSettings()

        lbooDBAccOrUIAcc = False

        'AddDebugComment("frmPad.mnuToolsOptions_Click - End") 

        gstrProbComtStack &= " #TOC-End" 
        AddDebugComment(gstrProbComtStack) 
        gstrProbComtStack = "" 
    End Sub
    Private Sub RefreshGeneralSettings()
        AddDebugComment("frmPad.RefreshGeneralSettings") 
        AddCrashComment("#PRBS1") 
        Dim UpdatedConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings) 
        SetFonts(UpdatedConfig) 

        
        'added to cater for change in icon directory
        Dim frmResource As New IPIconsPack.Resource()
        TreeView1.ImageList = AddUserIcons(frmResource.ilTreeIcons)
        menuEnhancer.ImageListMarks = frmResource.ilTreeIcons
        

        'mnuToolsRefresh_Click(Nothing, Nothing)' commented out 
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder) 
        AddCrashComment("#PRBS2") 

        
        're-load / redisplay current rtf contents
        'Added to if default form font is chnaged, it won't chnage the font of whats on screen
        'Need to cater for MCL docs on the screen too
        Select Case lcurDocumentView
            Case DocumentViews.NormalTopic
                'SelectNodeByTag(lstrCurTopicCode)
                SelectNodeByTag(lstrCurTopicCode, TreeView1, lcurDocumentView) 
                
                Dim lstrTemplateFileName, lstrFormData As String
                Dim lbooSysTemplate As Boolean
                'GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                '    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                
                lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                lbooRTFContentsChanged = False 'reset 

                If lstrTemplateFileName <> "" Then
                    If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
                    ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
                    lcurDocumentView = DocumentViews.NormalTopic 
                End If
                
            Case DocumentViews.MCLGettingStarted
                mnuHelpGettingStarted_Click(Nothing, Nothing)
            Case DocumentViews.MCLLicense
                mnuHelpLicense_Click(Nothing, Nothing)
            Case DocumentViews.MCLStartup
                mnuHelpStartup_Click(Nothing, Nothing)
        End Select
        ClearCrashReport() 
    End Sub
    Private Sub SetFonts(ByVal pInitialConfig As Object) 

        AddDebugComment("frmPad.SetFonts") 
        Dim lstrDocFontName As String 
        Dim lstrDocFontSize As String 
        With pInitialConfig
            'fonts
            '--- rtf box ---
            lstrDocFontName = .GetValue("Document Font Name", "Microsoft Sans Serif")
            'Dim lstrDocFontSize As String = .GetValue("Document Font Size", "8.25")
            lstrDocFontSize = .GetValue("Document Font Size", "8") 

            Dim lstrRTFFontColour As String = .GetValue("Document Font Colour", "Black")
            RichTextBox1.ForeColor = System.Drawing.Color.FromName(lstrRTFFontColour) 'GetSetting("Document Font Colour", "Black"))

            
            Dim lDocFontExtra As New OtherFontSettings()
            Dim lDocFontStyle As New FontStyle()

            lDocFontExtra.Bold = CBool(.GetValue("Document Font Bold", "False"))
            lDocFontExtra.Underlined = CBool(.GetValue("Document Font Underlined", "False"))
            lDocFontExtra.Italic = CBool(.GetValue("Document Font Italic", "False"))
            lDocFontExtra.StrikeOut = CBool(.GetValue("Document Font Strikeout", "False"))
            If lDocFontExtra.Bold = True Then lDocFontStyle = FontStyle.Bold
            If lDocFontExtra.Underlined = True Then lDocFontStyle = lDocFontStyle + FontStyle.Underline
            If lDocFontExtra.Italic = True Then lDocFontStyle = lDocFontStyle + FontStyle.Italic
            If lDocFontExtra.StrikeOut = True Then lDocFontStyle = lDocFontStyle + FontStyle.Strikeout

            

            'RichTextBox1.Font = New Font(lstrDocFontName, CSng(lstrDocFontSize))
            RichTextBox1.Font = New Font(lstrDocFontName, CSng(lstrDocFontSize), lDocFontStyle) 
            '--- rtf box ---

            '--- tree ---
            Dim lstrTreeFontName As String = .GetValue("Tree Font Name", "Microsoft Sans Serif")
            'Dim lstrTreeFontSize As String = .GetValue("Tree Font Size", "8.25")
            Dim lstrTreeFontSize As String = .GetValue("Tree Font Size", "8") 

            Dim lstrTreeFontColour As String = .GetValue("Tree Font Colour", "Black")
            TreeView1.ForeColor = System.Drawing.Color.FromName(lstrTreeFontColour) 'GetSetting("Tree Font Colour", "Black"))

            
            Dim lTreeFontExtra As New OtherFontSettings()
            Dim lTreeFontStyle As New FontStyle()

            lTreeFontExtra.Bold = CBool(.GetValue("Tree Font Bold", "False"))
            lTreeFontExtra.Underlined = CBool(.GetValue("Tree Font Underlined", "False"))
            lTreeFontExtra.Italic = CBool(.GetValue("Tree Font Italic", "False"))
            lTreeFontExtra.StrikeOut = CBool(.GetValue("Tree Font Strikeout", "False"))
            If lTreeFontExtra.Bold = True Then lTreeFontStyle = FontStyle.Bold
            If lTreeFontExtra.Underlined = True Then lTreeFontStyle = lTreeFontStyle + FontStyle.Underline
            If lTreeFontExtra.Italic = True Then lTreeFontStyle = lTreeFontStyle + FontStyle.Italic
            If lTreeFontExtra.StrikeOut = True Then lTreeFontStyle = lTreeFontStyle + FontStyle.Strikeout

            'TreeView1.Font = New Font(lstrTreeFontName, CSng(lstrTreeFontSize))
            TreeView1.Font = New Font(lstrTreeFontName, CSng(lstrTreeFontSize), lTreeFontStyle) 
            '--- 
            '--- tree ---
        End With

        
        Dim CurrentSizeNameIdx As Integer = -2
        With cboFontSize
            Dim lintArrInc As Integer
            For lintArrInc = 8 To 29 Step 2
                .Items.Add(lintArrInc)
                If CInt(lstrDocFontSize) = lintArrInc Then
                    CurrentSizeNameIdx = .Items.Count - 1
                End If
            Next lintArrInc
            If CurrentSizeNameIdx <> -2 Then
                .SelectedIndex = CurrentSizeNameIdx '2
            Else
                .SelectedIndex = 0
            End If
        End With

        Dim CurrentFontNameIdx As Integer = -2
        With cboFontName
            Dim ff As FontFamily
            For Each ff In System.Drawing.FontFamily.Families
                .Items.Add(ff.Name)
                If lstrDocFontName = ff.Name Then
                    CurrentFontNameIdx = .Items.Count - 1
                End If
            Next ff
            If CurrentFontNameIdx <> -2 Then
                .SelectedIndex = CurrentFontNameIdx '0
            Else
                .SelectedIndex = 0
            End If
        End With
        

    End Sub
    Private Sub xsetSettings(ByVal pInitialConfig)
        gstrSortOrder = GetSetting("Tree Sort Order", "ALPHA", InitalXMLConfig.XmlConfigType.AppSettings, "")
    End Sub
    Private Sub mnuFileNewBranch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileNewBranch.Click
        'mnuItemAdd_Click(Nothing, Nothing)
        AddNewSubBranch("") 
    End Sub
    Private Sub mnuRTFFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFFont.Click

        AddDebugComment("frmPad.mnuRTFFont_Click") 

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        FontDialog1.ShowColor = True
        On Error Resume Next

        FontDialog1.Font = RichTextBox1.SelectionFont 

        FontDialog1.Color = RichTextBox1.SelectionColor 

        If FontDialog1.ShowDialog() <> DialogResult.Cancel Then

            SetFontStyle(FontDialog1.Font.Style, FontDialog1.Font.FontFamily.Name.ToString, FontDialog1.Font.Size)
            RichTextBox1.SelectionColor = FontDialog1.Color
            
        End If

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub mnuFilePrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click

        AddDebugComment("frmPad.mnuFilePrint_Click") 
        gstrMRPs = "0916"
        BusyPad(Me, True)

        UpdateRTFToDB() 

        'Removed as this will increment hours used, more than it should 
        'Dim lflaDBResult As String = CheckDates(gstrDBFlamer, 0) 'added zero for ideadpad 

        If AxWebBrowser1.Visible = True Then
            'AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)

            Dim tmplPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & "\printtemplate.html"
            If System.IO.File.Exists(tmplPath) = False Then
                'mxessagebox.show("A required file to enable template printing was not found!", NameMe(""))
                
                MessageBox.Show(LangText.GetString("Pad_PrintTmpMissing"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props
                BusyPad(Me, False) 
                Exit Sub
            End If
            Dim o As New Object()
            'AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER, CType(tmplPath, Object), o)
            AxWebBrowser1.PrintFormatted(tmplPath) 
        Else
            Dim PrintResult As DialogResult

            RichTextBox2.SelectedRtf = ""
            RichTextBox2.Rtf = ""
            RichTextBox2.SelectedRtf = RichTextBox1.Rtf

            AddRTFFooter(RichTextBox2, True) 

            m_PrintRichTextDocument = New RichTextPrintDocument(RichTextBox2) 'RichTextBox1

            m_PrintRichTextDocument.DefaultPageSettings = m_PageSettings

            With PrintDialog1
                .Document = m_PrintRichTextDocument

                If RichTextBox2.SelectionLength > 0 Then
                    .AllowSelection = True
                End If
                .Document.DefaultPageSettings = m_PageSettings 

                Application.DoEvents() 

                PrintResult = .ShowDialog

                If PrintResult = DialogResult.OK Then

                    If .PrinterSettings.PrintRange.Selection = PrintRange.Selection Then
                        m_PrintRichTextDocument.PrintSelectedTextOnly = True
                    End If

                    m_PrintRichTextDocument.Print()
                    BusyPad(Me, False)
                End If
            End With

        End If
    End Sub
    Private Sub TreeView1_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView1.ItemDrag
        'If elEvts = True Then : Console.WriteLine("TreeView1_ItemDrag") : End If
        AddDebugComment("frmPad.TreeView1_ItemDrag") 
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub
    Private Sub TreeView1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragEnter

        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then 
            'If elEvts = True Then : Console.WriteLine("TreeView1_DragEnter") : End If
            AddDebugComment("frmPad.TreeView1_DragEnter") 
            e.Effect = DragDropEffects.Move
        End If

    End Sub
    Private Sub TreeView1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop

        'If elEvts = True Then : Console.WriteLine("TreeView1_DragDrop") : End If
        AddDebugComment("frmPad.TreeView1_DragDrop") 
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
            Dim pt As Point

            
            'pt = TreeView1.PointToClient(New Point(e.X, e.Y))
            Dim XPos As Integer
            Dim YPos As Integer
            XPos = e.X - (Me.Location.X + 6)


            'YPos = e.Y - (Me.Location.Y + 86) '76
            ''YPos = e.Y - (TreeView1.Top + 207) 
            YPos = pt.Y - TreeView1.Location.Y 



            pt = TreeView1.PointToClient(New Point(XPos, YPos))
            

            ' Get a handle to the node the source node was dragged onto
            DestinationNode = TreeView1.GetNodeAt(pt)

            If DestinationNode Is Nothing Then 
                DestinationNode = TreeView1.SelectedNode 
            End If

            ' Create a new node based on the data contained in the dragged node
            NewNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

            Dim pt2 As Point
            pt2 = TreeView1.PointToClient(New Point(e.X, e.Y))

            ctmNodeDrag.Show(TreeView1, pt2)

        End If

    End Sub
    Private Sub TreeView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragOver

        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then 
            'If elEvts = True Then : Console.WriteLine("TreeView1_DragOver") : End If
            AddDebugComment("frmPad.TreeView1_DragOver") 
            'Conxsole.Write(" T_DO ")
            lbooDBAccOrUIAcc = True 
            '------


            Dim EnterNode As TreeNode
            Dim XPos As Integer
            Dim YPos As Integer

            ' Calculate the position of  the node relative to the position of the form.
            'XPos = e.X - (Me.Location.X + 6)
            'YPos = e.Y - (Me.Location.Y + 46)


            'Console.WriteLine("Me.Location.Y=" & Me.Location.Y)
            'Console.WriteLine("treeview1.Top=" & TreeView1.Top)
            'Console.WriteLine("e.Y=" & e.Y)
            'Console.WriteLine(" ")

            XPos = e.X - (Me.Location.X + 6)
            'YPos = e.Y - (Me.Location.Y + 86) '76

            Dim pt As Point = PointToClient(New Point(e.X, e.Y)) 
            YPos = pt.Y - TreeView1.Location.Y 


            ' Add a buffer of 5 pixels
            If YPos <= 5 Then
                'If XPos < 0 Or YPos <= 5 Then
                TreeView1.SelectedNode = TreeView1.SelectedNode.PrevVisibleNode
                EnterNode = TreeView1.SelectedNode
            Else
                ' Get the TreeNode that was dragged over.
                '''EnterNode = TreeView1.GetNodeAt(XPos, YPos)

                pt.Y -= TreeView1.Location.Y  
                EnterNode = TreeView1.GetNodeAt(pt) 
            End If

            If Not EnterNode Is Nothing Then
                TreeView1.SelectedNode = EnterNode
                'e.Effect = DragDropEffects.All
            End If
            '------
            '------
            'Dim tv As TreeView = CType(sender, TreeView)
            'Dim position As New Point(e.X, e.Y)
            'position = tv.PointToClient(position)
            'Dim node As TreeNode = CType(tv.GetNodeAt(position), TreeNode)
            'If Not (node Is Nothing) Then
            'tv.SelectedNode = node
            'End If
            '------

        End If

    End Sub
    Private Sub ctmNDMoveHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDMoveHere.Click
        AddDebugComment("frmPad.ctmNDMoveHere_Click") 
        AddCrashComment("#PCNMHC1") 
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()
        Dim llnglevel As Long

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 

        If SearchParentsNodeForSelf(DestinationNode, TreeView1.SelectedNode.Tag) = True Then 
            Exit Sub 
        End If

        
        'TODO: Test NodeS Move aka move branches
        If SearchParentsNodeForSelf(DestinationNode, NewNode.Tag) = True Then
            Exit Sub
        End If
        
        AddCrashComment("#PCNMHC2") 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)
            TreeView1.BeginUpdate() 

            ' Add a clone
            DestinationNode.Nodes.Add(CType(NewNode.Clone, TreeNode))

            ' Expand the new node
            DestinationNode.Expand()

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            llnglevel = NodateLevel(DestinationNode) + 1 

            lstrSQL = "UPDATE Topics SET ParentTopicCode = '" & DestinationNode.Tag & _
                "', [Level] = " & llnglevel & " WHERE TopicCode='" & NewNode.Tag & "';"

            gstrLastSQL = lstrSQL 
            AddCrashComment("#PCNMHC3") 

            lcnn1.Execute(lstrSQL)
            AddDebugComment("frmPad.ctmNDMoveHere_Click - " & llnglevel & " " & _
                DestinationNode.Tag & " " & NewNode.Tag)  

            Dim n As TreeNode
            Dim cNodes As Integer
            Dim ndxs() As TreeNode
            Dim curNode As Integer = -1

            cNodes = DestinationNode.GetNodeCount(True)

            ProgresPanel.Maximum = cNodes 
            ProgresPanel.Minimum = 0 
            ProgresPanel.Value = 0 

            ReDim ndxs(cNodes)
            GetNodes(DestinationNode.Nodes(0), ndxs, curNode, False)

            AddCrashComment("#PCNMHC4") 
            ' Shrink the array to just the # of selected nodes.
            Dim llngCounter As Integer 
            ReDim Preserve ndxs(curNode)
            For Each n In ndxs
                llnglevel = NodateLevel(n) '+ 1 as upating db after not before
                lstrSQL = "Update Topics set [Level] = " & llnglevel & " WHERE TopicCode='" & n.Tag & "';"
                AddDebugComment("frmPad.ctmNDMoveHere_Click - " & llnglevel & " " & n.Tag)   
                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
                'need to update sub branch levels too!!
                ProgresPanel.Increment(1) 
                llngCounter += 1 
                If llngCounter > 10 Then 
                    System.Windows.Forms.Application.DoEvents() 
                    llngCounter = 0
                End If
            Next n
            ' Remove the original node
            AddCrashComment("#PCNMHC5") 
            lcnn1.Close()
            NewNode.Remove()
            TreeView1.EndUpdate() 
            ProgresPanel.Value = 0 
            BusyPad(Me, False)

        End If
        ClearCrashReport() 
    End Sub
    Private Sub ctmNDCopyHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDCopyHere.Click
        AddDebugComment("frmPad.ctmNDCopyHere_Click") 
        AddCrashComment("#PCNCHC1") 
        Dim llnglevel As Long
        Dim llngNextTopicID As Long 

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)
            TreeView1.BeginUpdate() 
            DestinationNode.Nodes.Add(CType(NewNode.Clone, TreeNode))
            DestinationNode.Expand()

            Dim n As TreeNode
            Dim cNodes As Integer
            Dim ndxs() As TreeNode
            Dim curNode As Integer = -1
            AddCrashComment("#PCNCHC2") 

            '---- removed 
            'gxlngLastTopicNum = gxlngLastTopicNum + 1
            ''lstrTopicCode = "T" & FormatNumberGet(gxlngLastTopicNum, "0000")
            'llngNextTopicID = GetNxextTopicID() 
            ''lstrTopicCode = GetNxextTopicID() & "T" & FormatNumberGet(gxlngLastTopicNum, "0000000") 
            'lstrTopicCode = llngNextTopicID & "T" & FormatNumberGet(gxlngLastTopicNum, "0000000") 
            'lstrParentTopicCode = DestinationNode.Tag
            ''llnglevel = NodateLevel(TreeView1.SelectedNode) + 1
            '
            'llnglevel = NodateLevel(DestinationNode) + 1

            ''AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag)
            '
            'AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag, NewNode.ImageIndex)

            'DestinationNode.Tag = lstrTopicCode
            '' Allocate enough space to indicate that ALL nodes are checked.
            '''cNodes = NewNode.GetNodeCount(True)
            '---- removed 

            'cNodes = DestinationNode.GetNodeCount(True)'commented out 
            cNodes = DestinationNode.Nodes(0).GetNodeCount(True) + 1 'chnaged 

            ProgresPanel.Maximum = cNodes 
            ProgresPanel.Minimum = 0 
            ProgresPanel.Value = 0 

            ReDim ndxs(cNodes)

            'If el = True Then : Console.WriteLine("ReDim ndxs(" & cNodes & ")") : End If
            AddDebugComment("frmPad.ctmNDCopyHere_Click - " & cNodes) 
            AddCrashComment("#PCNCHC3") 

            ''GetNodes(NewNode.Nodes(0), ndxs, curNode, False)
            'GetNodes(DestinationNode.Nodes(0), ndxs, curNode, False)'commented out 
            GetNodes(DestinationNode.Nodes(1), ndxs, curNode, False) 'chnaged 

            ' Shrink the array to just the # of selected nodes.
            Dim llngCounter As Integer 
            ReDim Preserve ndxs(curNode)

            'If el = True Then : Console.WriteLine("ReDim Preserve ndx(" & curNode & ")") : End If
            AddDebugComment("frmPad.ctmNDCopyHere_Click - " & cNodes) 
            Dim lDupeTopic(0) As String 
            Dim lDuinc As Integer 
            Dim lbooAddTopicToDupe As Boolean 
            For Each n In ndxs
                lbooAddTopicToDupe = True
                For lDuinc = 0 To lDupeTopic.GetUpperBound(0)
                    If lDupeTopic(lDuinc) = n.Tag Then : lbooAddTopicToDupe = False : End If
                Next lDuinc
                If lbooAddTopicToDupe = True Then 'lbooAddTopicToDupe
                    ReDim Preserve lDupeTopic(lDupeTopic.GetUpperBound(0) + 1)
                    lDupeTopic(lDupeTopic.GetUpperBound(0)) = n.Tag

                    'glngLastTopicNum = glngLastTopicNum + 1
                    glngLastTopicNum = GetLastTopicRealNumber() + 1 
                    lstrTopicCode = "T" & FormatNumberGet(glngLastTopicNum, "0000000") 

                    Dim llngProposedNextID As Long 
                    llngProposedNextID = GetNextTopicID() 
                    If llngProposedNextID = llngNextTopicID Then 
                        llngNextTopicID += 1 
                    Else 
                        llngNextTopicID = llngProposedNextID 
                    End If

                    'lstrTopicCode = GetNextTopicID() & "T" & FormatNumberGet(gxlngLastTopicNum, "0000000") 
                    lstrTopicCode = llngNextTopicID & "T" & FormatNumberGet(glngLastTopicNum, "0000000") 
                    lstrParentTopicCode = n.Parent.Tag
                    'llnglevel = NodateLevel(n) + 1
                    llnglevel = NodateLevel(n) 

                    'AddNewTopicCopyDetails(llnglevel, n.Text, lstrTopicCode, lstrParentTopicCode, n.Tag)
                    
                    'If el = True Then : Console.WriteLine("CTMCBh clk " & llnglevel & " " & n.Text & " " & _
                    '    lstrTopicCode & " " & lstrParentTopicCode & " " & n.Tag & " " & n.ImageIndex) : End If

                    AddDebugComment("frmPad.ctmNDCopyHere_Click - " & llnglevel & " " & _
                        lstrTopicCode & " " & lstrParentTopicCode & " " & n.Tag & " " & n.ImageIndex) 
                    
                    'AddNewTopicCopyDetails(llnglevel, n.Text, lstrTopicCode, lstrParentTopicCode, n.Tag, n.ImageIndex, "")
                    
                    'lstrCurLockFlag = CreateLockingFlag()'no this is set inside function
                    AddNewTopicCopyDetails(llnglevel, n.Text, lstrTopicCode, lstrParentTopicCode, n.Tag, n.ImageIndex, "", lstrCurLockFlag, 0, "Default") 'added seqnum 0 

                    n.Tag = lstrTopicCode

                    ProgresPanel.Increment(1) 
                    llngCounter += 1 
                    If llngCounter > 10 Then 
                        System.Windows.Forms.Application.DoEvents() 
                        llngCounter = 0
                    End If
                End If 'lbooAddTopicToDupe
            Next
            AddCrashComment("#PCNCHC4") 

            TreeView1.EndUpdate() 
            ProgresPanel.Value = 0 
            BusyPad(Me, False)
            System.Windows.Forms.Application.DoEvents()
        End If
        ClearCrashReport() 
    End Sub
    Private Sub ctmNDLinkHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDLinkHere.Click
        AddDebugComment("frmPad.ctmNDLinkHere_Click") 
        AddCrashComment("#PCNLHC1") 
        Dim llnglevel As Long
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()
        Dim llngNextTopicID As Long 

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 
        AddCrashComment("#PCNLHC2") 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)
            TreeView1.BeginUpdate() 
            lbooDBAccOrUIAcc = True 
            ' Add a clone
            DestinationNode.Nodes.Add(CType(NewNode.Clone, TreeNode))

            ' Expand the new node
            DestinationNode.Expand()


            Dim n As TreeNode
            Dim cNodes As Integer
            Dim ndxs() As TreeNode
            Dim curNode As Integer = -1

            lcnn1 = New ADODB.Connection()
            'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
            lcnn1.Open(gstrConnectionString)
            'Conxsole.WriteLine("DB:ctmNDLinkHere_Click")

            'glngLastTopicNum = glngLastTopicNum + 1
            glngLastTopicNum = GetLastTopicRealNumber() + 1 
            lstrParentTopicCode = DestinationNode.Tag
            'llnglevel = NodateLevel(TreeView1.SelectedNode) + 1
            
            llnglevel = NodateLevel(DestinationNode) + 1
            '---

            lstrSymbolicLinkCode = ReturnTrueTopicStr(NewNode.Tag)
            llngNextTopicID = GetNextTopicID() 
            lstrTopicCode = llngNextTopicID & lstrSymbolicLinkCode
            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
            '     "Values(" & llnglevel & ", '" & NewNode.Text & "', '" & lstrTopicCode & "', '" & lstrParentTopicCode & "', 0, True);"

            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
            '    "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
            '    "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse FROM Topics WHERE TopicCode='" & _
            '    NewNode.Tag & "';"
            'ImgIdx
            lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
                "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse, ImgIdx FROM Topics WHERE TopicCode='" & _
                NewNode.Tag & "';"

            'If elEvts = True Then : Console.WriteLine("CTMLhCLK " & lstrSQL) : End If
            AddDebugComment("frmPad.ctmNDLinkHere_Click - " & lstrTopicCode & " " & lstrParentTopicCode) 
            gstrLastSQL = lstrSQL 
            AddCrashComment("#PCNLHC3") 

            lcnn1.Execute(lstrSQL)
            '---

            ''NewNode.Tag = lstrTopicCode ' wrong should be destination not source you change
            DestinationNode.Tag = lstrTopicCode
            'Conxsole.WriteLine("New Link topic " & lstrTopicCode)
            ' Allocate enough space to indicate that ALL nodes are checked.

            ''cNodes = NewNode.GetNodeCount(True)
            cNodes = DestinationNode.GetNodeCount(True)



            ProgresPanel.Maximum = cNodes 
            ProgresPanel.Minimum = 0 
            ProgresPanel.Value = 0 

            ReDim ndxs(cNodes)
            ''GetNodes(NewNode.Nodes(0), ndxs, curNode, False)
            GetNodes(DestinationNode.Nodes(0), ndxs, curNode, False)

            AddCrashComment("#PCNLHC4") 
            ' Shrink the array to just the # of selected nodes.
            Dim llngCounter As Integer 
            ReDim Preserve ndxs(curNode)
            For Each n In ndxs
                'glngLastTopicNum = glngLastTopicNum + 1
                glngLastTopicNum = GetLastTopicRealNumber() + 1 
                lstrParentTopicCode = n.Parent.Tag
                llnglevel = NodateLevel(n) + 1
                '---

                lstrSymbolicLinkCode = ReturnTrueTopicStr(n.Tag)

                'lstrTopicCode = GetNxextTopicID() & lstrSymbolicLinkCode
                Dim llngProposedNextID As Long 
                llngProposedNextID = GetNextTopicID() 
                If llngProposedNextID = llngNextTopicID Then 
                    llngNextTopicID += 1 
                End If
                lstrTopicCode = llngNextTopicID & lstrSymbolicLinkCode 

                'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
                '     "Values(" & llnglevel & ", '" & NewNode.Text & "', '" & lstrTopicCode & "', '" & lstrParentTopicCode & "', 0, True);"

                'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
                '    "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
                '    "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse FROM Topics WHERE TopicCode='" & _
                '    n.Tag & "';"

                'ImgIdx
                lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                    "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
                    "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse, ImgIdx FROM Topics WHERE TopicCode='" & _
                    n.Tag & "';"

                'If elEvts = True Then : Console.WriteLine("CTMLhClk 2" & lstrSQL) : End If
                AddDebugComment("frmPad.ctmNDLinkHere_Click - " & llnglevel & " " & lstrTopicCode & " " & lstrParentTopicCode) 
                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
                '---              

                n.Tag = lstrTopicCode ' wrong should be destination not source you change
                'Conxsole.WriteLine("New Link topic " & lstrTopicCode)

                ProgresPanel.Increment(1) 
                llngCounter += 1 
                If llngCounter > 10 Then 
                    System.Windows.Forms.Application.DoEvents() 
                    llngCounter = 0
                End If
            Next n
            '--------
            lcnn1.Close()
            AddCrashComment("#PCNLHC5") 
            lbooDBAccOrUIAcc = False 
            TreeView1.EndUpdate() 
            ProgresPanel.Value = 0 
            BusyPad(Me, False)
        End If
        ClearCrashReport() 
    End Sub
    Private Sub mnuItemProperties_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemProperties.Click
        AddDebugComment("frmPad.mnuItemProperties_Click") 
        Dim lstrSelectedTopicCode As String 

        Try 
            lstrSelectedTopicCode = TreeView1.SelectedNode.Tag 
        Catch 
            Exit Sub 
        End Try

        
        Dim lintB4SelNodeImgIdx As Integer
        lintB4SelNodeImgIdx = TreeView1.SelectedNode.SelectedImageIndex
        

        'Dim BranchOptions As New branchprops(frmResources.ilTreeIcons) 
        Dim BranchOptions As New branchprops(TreeView1.ImageList) 

        BranchOptions.TopicCode = TreeView1.SelectedNode.Tag
        BranchOptions.TopicName = TreeView1.SelectedNode.Text
        BranchOptions.SelectedImgIdx = TreeView1.SelectedNode.ImageIndex 
        BranchOptions.Owner = Me 

        Application.DoEvents() 

        BranchOptions.TopMost = gbooAlwaysOnTop 
        BranchOptions.ShowDialog()

        Application.DoEvents() 

        BusyPad(Me, True)

        If gstrSortOrder = "SEQNUM" And BranchOptions.B4BranchSeqNum <> BranchOptions.AFBranchSeqNum Then 

            lbooDBAccOrUIAcc = True 
            PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
            lbooDBAccOrUIAcc = False 
            BusyPad(Me, False)
            SelectNodeByTag(lstrSelectedTopicCode, TreeView1, lcurDocumentView) 
            TreeView1.SelectedNode.Expand()
        Else
            
            If lintB4SelNodeImgIdx <> BranchOptions.SelectedImgIdx Then
                TreeView1.SelectedNode.SelectedImageIndex = BranchOptions.SelectedImgIdx
                TreeView1.SelectedNode.ImageIndex = BranchOptions.SelectedImgIdx

            End If
            

        End If

        BusyPad(Me, False) 

    End Sub
    Private Sub mnuToolsRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsRefresh.Click
        AddDebugComment("frmPad.mnuToolsRefresh_Click") 
        BusyPad(Me, True)
        UpdateRTFToDB() 

        TreeView1.SelectedNode = Nothing 

        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)

        If mstrIndexArray(0).strTopicCode <> "" Then
            TreeView1.SelectedNode = TreeView1.Nodes(0)
            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
        Else
            lstrCurTopicCode = ""
            lstrCurLockFlag = "" 
        End If

        BusyPad(Me, False)
    End Sub
    Private Sub ctmNDCopyBranchHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDCopyBranchHere.Click
        AddDebugComment("frmPad.ctmNDCopyBranchHere_Click") 
        AddCrashComment("#PCNCBHC1") 
        Dim llnglevel As Long

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)
            'glngLastTopicNum = glngLastTopicNum + 1
            glngLastTopicNum = GetLastTopicRealNumber() + 1 
            lstrTopicCode = GetNextTopicID() & "T" & FormatNumberGet(glngLastTopicNum, "0000000") 
            lstrParentTopicCode = DestinationNode.Tag

            Dim NodeToAdd As New TreeNode()
            NodeToAdd.Text = NewNode.Text
            NodeToAdd.Tag = lstrTopicCode
            NodeToAdd.ImageIndex = NewNode.ImageIndex 
            NodeToAdd.SelectedImageIndex = NewNode.SelectedImageIndex 
            DestinationNode.Nodes.Add(NodeToAdd)
            DestinationNode.Expand()
            AddCrashComment("#PCNCBHC2") 
            'llnglevel = NodateLevel(TreeView1.SelectedNode) + 1
            
            llnglevel = NodateLevel(DestinationNode) + 1

            'AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag)
            
            'AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag, NewNode.ImageIndex, "")
            
            'lstrCurLockFlag = CreateLockingFlag()'no this is set inside function
            AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag, NewNode.ImageIndex, "", lstrCurLockFlag, 0, "Default") 'added 0 

            BusyPad(Me, False)

        End If
        ClearCrashReport() 
    End Sub
    Private Sub ctmNDLinkBranchHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDLinkBranchHere.Click
        AddDebugComment("frmPad.ctmNDLinkBranchHere_Click") 
        AddCrashComment("#PCNLBHC1") 
        Dim llnglevel As Long
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)
            lbooDBAccOrUIAcc = True 
            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            'glngLastTopicNum = glngLastTopicNum + 1
            glngLastTopicNum = GetLastTopicRealNumber() + 1 
            lstrParentTopicCode = DestinationNode.Tag
            'llnglevel = NodateLevel(TreeView1.SelectedNode) + 1
            
            llnglevel = NodateLevel(DestinationNode) + 1
            lstrSymbolicLinkCode = ReturnTrueTopicStr(NewNode.Tag)
            lstrTopicCode = GetNextTopicID() & lstrSymbolicLinkCode

            Dim NodeToAdd As New TreeNode()
            NodeToAdd.Text = NewNode.Text
            NodeToAdd.Tag = lstrTopicCode
            DestinationNode.Nodes.Add(NodeToAdd)
            DestinationNode.Expand()

            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
            '    "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
            '    "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse FROM Topics WHERE TopicCode='" & _
            '    NewNode.Tag & "';"

            'ImgIdx
            lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                "SELECT " & llnglevel & " AS Expr1, Title, '" & lstrTopicCode & _
                "' AS Expr3, '" & lstrParentTopicCode & "' AS Expr4, SeqNum, InUse, ImgIdx FROM Topics WHERE TopicCode='" & _
                NewNode.Tag & "';"

            gstrLastSQL = lstrSQL 
            AddCrashComment("#PCNLBHC2") 
            lcnn1.Execute(lstrSQL)
            lcnn1.Close()
            lbooDBAccOrUIAcc = False 
            BusyPad(Me, False)
        End If
        ClearCrashReport() 
    End Sub
    Private Sub mnuItemDeleteBranches_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemDeleteBranches.Click
        AddDebugComment("frmPad.mnuItemDeleteBranches_Click") 
        Dim lintRetVal As DialogResult
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lintTopicCount As Integer

        If TreeView1.SelectedNode Is Nothing Then
            'mxessagebox.show("You must select a branch first!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_MustSelectABranch"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Exit Sub
        End If

        If TreeView1.SelectedNode.GetNodeCount(True) = 0 Then
            'mxessagebox.show("You must use 'Delete branch' to delete a branch with not sub branches!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_MustUseDelBranch"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Exit Sub
        End If

        'lintRetVal = MxessageBox.Show("Do you wish to delete this branch and all its sub branches?", NameMe(""), MessageBoxButtons.YesNo)
        
        lintRetVal = MessageBox.Show(LangText.GetString("Pad_ConfirmDelBranches"), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

        If lintRetVal <> DialogResult.Yes Then
            Exit Sub
        End If

        BusyPad(Me, True)
        lbooDBAccOrUIAcc = True 
        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:mnuItemDeleteBranches_Click")

        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ' Allocate enough space to indicate that ALL nodes are checked.
        cNodes = TreeView1.SelectedNode.GetNodeCount(True)

        ProgresPanel.Maximum = cNodes 
        ProgresPanel.Minimum = 0 
        ProgresPanel.Value = 0 

        ReDim ndxs(cNodes)
        GetNodes(TreeView1.SelectedNode.Nodes(0), ndxs, curNode, False)

        'Conxsole.WriteLine("Delete " & TreeView1.SelectedNode.Text & " " & TreeView1.SelectedNode.Tag)
        lstrSQL = "Delete * from Topics where TopicCode = '" & TreeView1.SelectedNode.Tag & "';"
        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)

        'On Error Resume Next
        'lintTopicCount = GetTopicCount(TreeView1.SelectedNode.Tag)
        lintTopicCount = CheckToMakeOrphan(TreeView1.SelectedNode.Tag) 

        If lintTopicCount = 1 Then
            lstrSQL = "Delete * from TopicDetail where TopicCode = '" & ReturnTrueTopicStr(TreeView1.SelectedNode.Tag) & "';"
            gstrLastSQL = lstrSQL 

            lcnn1.Execute(lstrSQL)

            
            Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(TreeView1.ImageList, lstrDBID)
            lMaintBookMark.RemoveBookMarks(TreeView1.SelectedNode.Tag, lstrDBID, InitalXMLConfig.XmlConfigType.Bookmarks, "Bookmarks-", "BookmarkImgIdx-", "", TreeView1.SelectedNode.Text)
            

        End If
        'On Error GoTo 0
        ' Shrink the array to just the # of selected nodes.
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            'Diagnostics.Debug.WriteLine("Node: " & n.Text & " is Checked")
            'Conxsole.WriteLine("Delete " & n.Text & " " & n.Tag)
            lstrSQL = "Delete * from Topics where TopicCode = '" & n.Tag & "';"
            gstrLastSQL = lstrSQL 

            lcnn1.Execute(lstrSQL)
            'On Error Resume Next

            'lintTopicCount = GetTopicCount(TreeView1.SelectedNode.Tag)
            lintTopicCount = CheckToMakeOrphan(n.Tag) 
            If lintTopicCount = 1 Then
                lstrSQL = "Delete * from TopicDetail where TopicCode = '" & ReturnTrueTopicStr(n.Tag) & "';"
                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
            End If
            'On Error GoTo 0

            ' ---'Delete Bookmarks  | DN 11/07/2007
            Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(TreeView1.ImageList, lstrDBID)
            lMaintBookMark.RemoveBookMarks(n.Tag, lstrDBID, InitalXMLConfig.XmlConfigType.Bookmarks, "Bookmarks-", "BookmarkImgIdx-", "", n.Text)
            ' -------------

            ProgresPanel.Increment(1) 
        Next n

        lcnn1.Close()
        'TreeView1.Nodes.Clear()

        RefreshBookMarksMenu() ' DN 11/07/2007

        Sleep(1) 
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)

        lbooDBAccOrUIAcc = False  

        If mstrIndexArray(0).strTopicCode = "" Then
            mnuHelpStartup_Click(Nothing, Nothing)

        Else
            TreeView1.SelectedNode = TreeView1.Nodes(0) 
        End If
        ProgresPanel.Value = 0 
        BusyPad(Me, False)
        CheckNode()

    End Sub
    Private Sub RichTextBox1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked

        'If elEvtsRTB = True Then : Console.WriteLine("RichTextBox1_LinkClicked") : End If
        AddDebugComment("frmPad.RichTextBox1_LinkClicked") 

        If LeftGet(e.LinkText.ToUpper, 7) = "HTTP://" Then 
            Dim lstrQuickTagUpper As String = ("http://" & lstrQuickLinkTag & ":").ToUpper

            If InStrGet(e.LinkText.ToUpper, lstrQuickTagUpper) > 0 Then 
                lstrTopicCode = e.LinkText.ToUpper.Replace(lstrQuickTagUpper, "") 

                UpdateRTFToDB() 

                SelectNodeByTag(lstrTopicCode, TreeView1, lcurDocumentView) 
            Else
                'System.Diagnostics.Process.Start(e.LinkText)
                'System.Diagnostics.Process.Start(Web.HttpUtility.UrlDecode(e.LinkText)) 
                
                BrowseToUrl(Web.HttpUtility.UrlDecode(e.LinkText), Me) 

            End If
        Else 
            
            Try
                'System.Diagnostics.Process.Start(Web.HttpUtility.UrlDecode(e.LinkText)) 
                
                Dim ThisLink As String
                ThisLink = Web.HttpUtility.UrlDecode(e.LinkText)
                If InStrGet(ThisLink.ToUpper, "FILE://") Then
                    Dim ActualFile As String
                    ActualFile = RightGet(ThisLink, ThisLink.Length - 7)
                    If File.Exists(ActualFile) = True Then
                        System.Diagnostics.Process.Start(ThisLink)
                    Else
                        MessageBox.Show(LangText.GetString("Pad_ProblemWithFile"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                
            Catch
                MessageBox.Show(LangText.GetString("Pad_ProblemWithFile"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 
            End Try
            
        End If

    End Sub
    Private Sub ShowTipOfTheDay(Optional ByVal pbooOveride As Boolean = False)

        Dim TipOfDay As New TipOfTheDay()
        With TipOfDay
            .Owner = Me 
            .FormIcon = Me.Icon
            TipOfDay.LastTipNum = CInt(GetSetting("Last Tip of the Day", "0", InitalXMLConfig.XmlConfigType.AppSettings, ""))
            .OverideStartup = pbooOveride
            .TopMost = gbooAlwaysOnTop 
            .Display()
            SaveSetting("Last Tip of the Day", TipOfDay.LastTipNum, InitalXMLConfig.XmlConfigType.AppSettings, "")
        End With
        TipOfDay = Nothing

        Me.Focus() 

    End Sub
    Private Sub ContextMenuAddGroup_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuAddGroup.Popup
        Dim lintarrinc As Integer
        Dim lbooHasChildbranches As Boolean = False

        If TreeView1.SelectedNode Is Nothing Or NoNode Then
            For lintarrinc = 0 To ContextMenuAddGroup.MenuItems.Count - 1
                ContextMenuAddGroup.MenuItems(lintarrinc).Enabled = False
            Next lintarrinc
        Else
            If TreeView1.SelectedNode.GetNodeCount(True) > 0 Then
                lbooHasChildbranches = True
            End If
            For lintarrinc = 0 To ContextMenuAddGroup.MenuItems.Count - 1
                With ContextMenuAddGroup.MenuItems(lintarrinc)
                    If .Text = mnuItemDelete.Text And lbooHasChildbranches = True Then
                        .Enabled = False
                    ElseIf .Text = mnuItemDeleteBranches.Text And lbooHasChildbranches = True Then
                        .Enabled = True
                    ElseIf .Text = mnuItemDelete.Text And lbooHasChildbranches = False Then
                        .Enabled = True
                    ElseIf .Text = mnuItemDeleteBranches.Text And lbooHasChildbranches = False Then
                        .Enabled = False
                    Else
                        .Enabled = True
                    End If

                    If .Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchUp") And FirstNode Then
                        .Enabled = False
                    End If


                    If .Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchDown") And LastNode Then
                        .Enabled = False
                    End If

                    If .Text = LangText.GetString("Pad_mnuItemMoveToRoot") And RootNode Then
                        .Enabled = False
                    End If
                    
                    If .Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchTop") And FirstNode Then
                        .Enabled = False
                    End If

                    If .Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchBottom") And LastNode Then
                        .Enabled = False
                    End If
                    

                End With
            Next lintarrinc
        End If
        RootNode = False
        FirstNode = False
        LastNode = False
        
        If Not TreeView1.SelectedNode Is Nothing Then 
            If TreeView1.SelectedNode Is TreeView1.Nodes(0) Then
                mnuItemMoveToRoot.Enabled = False
            End If
        End If 
        
    End Sub

    Private Sub ctmNodeDrag_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNodeDrag.Popup
        AddDebugComment("frmPad.ctmNodeDrag_Popup") 
        Dim lintArrInc As Integer

        If NewNode.GetNodeCount(True) > 0 Then
            'lbooHasChildbranches = True
            ctmNDCopyBranchHere.Enabled = True 'False
            ctmNDLinkBranchHere.Enabled = True 'False
            ctmNDCopyHere.Enabled = True


            ctmNDMoveHere.Enabled = True
            If Not DestinationNode Is Nothing Then
                If SearchParentsNodeForSelf(DestinationNode, TreeView1.SelectedNode.Tag) = True Then
                    ctmNDMoveHere.Enabled = False
                Else
                    If SearchParentsNodeForSelf(DestinationNode, NewNode.Tag) = True Then
                        ctmNDMoveHere.Enabled = False
                    End If
                End If
            End If
            

            ctmNDLinkHere.Enabled = True
            'Shouldn't allow move BRANCH here
            ctmNDMoveBranchHere.Enabled = False
        Else
            ctmNDCopyBranchHere.Enabled = True
            ctmNDLinkBranchHere.Enabled = True
            ctmNDCopyHere.Enabled = False
            ctmNDMoveHere.Enabled = False
            ctmNDLinkHere.Enabled = False

            'so shouldn't enable move BRANCHES
            'but could have a move BRANCH
            ctmNDMoveBranchHere.Enabled = True
        End If

    End Sub
    Private Sub mnuFilePageSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFilePageSetup.Click

        Application.DoEvents() 

        Try 
            Dim PgSetupDlg As New PageSetupDialog()
            PgSetupDlg.PageSettings = m_PageSettings

            PgSetupDlg.ShowDialog()
        Catch ex As Exception 
            MessageBox.Show(ex.Message, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 
        End Try 

    End Sub
    Private Sub TreeView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseMove
        'If elEvts = True Then Console.WriteLine("TreeView1_MouseMove")

        Dim mouseEvents As MouseEventArgs 
        mouseEvents = e
        selectPoint.Y = mouseEvents.Y
        selectPoint.X = mouseEvents.X
    End Sub
    Private Sub ctmNDMoveBranchHere_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmNDMoveBranchHere.Click
        AddDebugComment("frmPad.ctmNDMoveBranchHere_Click") 
        AddCrashComment("#PCNMBHC1") 
        Dim llnglevel As Long
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()

        If DestinationNode Is Nothing Then 
            Exit Sub 
        End If 

        If Not DestinationNode.Equals(NewNode) Then
            BusyPad(Me, True)

            'Dim NodeToAdd As New TreeNode()
            'NodeToAdd.Text = NewNode.Text
            'NodeToAdd.Tag = lstrTopicCode
            'DestinationNode.Nodes.Add(NewNode) 'NodeToAdd)
            DestinationNode.Nodes.Add(CType(NewNode.Clone, TreeNode))
            DestinationNode.Expand()

            'llnglevel = NodateLevel(TreeView1.SelectedNode) + 1
            

            'llnglevel = NodateLevel(DestinationNode) + 1


            'MessageBox.Show("Source Node: " & Environment.NewLine & _
            '                TreeView1.SelectedNode.Text & Environment.NewLine & "Tag=" & TreeView1.SelectedNode.Tag & _
            '                "Dest Node: " & Environment.NewLine & _
            '                DestinationNode.Text & Environment.NewLine & "Tag=" & DestinationNode.Tag)
            'Exit Sub

            lcnn1 = New ADODB.Connection()
            'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
            lcnn1.Open(gstrConnectionString)
            'Conxsole.WriteLine("DB:ctmNDMoveBranchHere_Click")

            'llnglevel = NodateLevel(NewNode) '+ 1

            llnglevel = NodateLevel(DestinationNode) + 1 

            'Testing the following line seems to work.
            'llnglevel = NodateLevel(DestinationNode)
            'also destination tag should be destination.parent ???


            lstrSQL = "UPDATE Topics SET ParentTopicCode = '" & DestinationNode.Tag & _
                "', [Level] = " & llnglevel & " WHERE TopicCode='" & NewNode.Tag & "';"
            gstrLastSQL = lstrSQL 
            AddCrashComment("#PCNMBHC2") 
            lcnn1.Execute(lstrSQL)

            lcnn1.Close()
            'AddNewTopicCopyDetails(llnglevel, NewNode.Text, lstrTopicCode, lstrParentTopicCode, NewNode.Tag)
            NewNode.Remove()
            BusyPad(Me, False)

        End If
        ClearCrashReport() 
    End Sub
    Private Sub frmPad_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        AddCrashComment("#PC1") 
        UpdateRTFToDB() 
        AddCrashComment("#PC1a") 
        DeleteTempFiles()
        AddCrashComment("#PC1b") 
        SaveSetting("Tree Width", TreeView1.Width, InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Document Word Wrap", lbooRTFWordWrap, InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("Browser Font Size", AxWebBrowser1.GetFontSize, InitalXMLConfig.XmlConfigType.AppSettings, "") 

        SaveSetting("LastTop", Me.Top, InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("LastLeft", Me.Left, InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("LastWidth", Me.Width, InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("LastHeight", Me.Height, InitalXMLConfig.XmlConfigType.AppSettings, "") 

        SaveSetting("RTF Highlight Colour", CurrentRTFHighlightColour.ToArgb.ToString, InitalXMLConfig.XmlConfigType.AppSettings, "") 

        'SaveSetting("Show Font Toolbar", mnuEditFontToolbar.Checked, InitalXMLConfig.XmlConfigType.AppSettings, "") 

        SaveSetting("AlwaysOnTop", gbooAlwaysOnTop, InitalXMLConfig.XmlConfigType.AppSettings, "") 

        SearchHistroy.SaveSearchHistory() 
        AddCrashComment("#PC2") 

        Application.DoEvents() 

        
        If gbooNeedToRestartProgAfterCFU = False Then
            If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 'Changed to Trial 
                Dim Remind As New frmRemind()
                Remind.ShowRTFHelp = False
                Remind.Owner = Me
                Remind.TopMost = gbooAlwaysOnTop 
                Remind.ShowDialog()
                Application.DoEvents() 
            End If
        End If
        
        ClearCrashReport() 

    End Sub
    Private Sub mnuToolsExpandAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsExpandAll.Click
        AddDebugComment("frmPad.mnuToolsExpandAll_Click") 
        'Dim ltreeKeptTreeNode As New TreeNode() 

        BusyPad(Me, True) 
        UpdateRTFToDB() 
        'ltreeKeptTreeNode = TreeView1.SelectedNode 
        TreeView1.SelectedNode = Nothing  

        TreeView1.BeginUpdate() 
        TreeView1.ExpandAll() 
        'TreeView1.SelectedNode = ltreeKeptTreeNode 
        mnuHelpStartup_Click(Nothing, Nothing) 
        TreeView1.EndUpdate() 
        BusyPad(Me, False) 

    End Sub
    Private Sub mnuToolsCollapseAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsCollapseAll.Click
        AddDebugComment("frmPad.mnuToolsCollapseAll_Click") 
        'Dim ltreeKeptTreeNode As New TreeNode() 

        BusyPad(Me, True)  
        UpdateRTFToDB() 
        'ltreeKeptTreeNode = TreeView1.SelectedNode 
        TreeView1.SelectedNode = Nothing  

        TreeView1.BeginUpdate() 
        TreeView1.CollapseAll() 
        'TreeView1.SelectedNode = ltreeKeptTreeNode 
        TreeView1.EndUpdate() 
        mnuHelpStartup_Click(Nothing, Nothing) 
        BusyPad(Me, False) 

    End Sub
    Private Sub TreeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand

        If TreeView1.SelectedNode Is Nothing Then 
            TreeView1.SelectedNode = e.Node 
        End If

    End Sub
    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse

        If TreeView1.SelectedNode Is Nothing Then 
            TreeView1.SelectedNode = e.Node 
        End If

    End Sub
    Private Sub mnuEditFindReplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditFindReplace.Click

        AddDebugComment("frmPad.mnuEditFindReplace_Click") 

        Dim frmFindAndReplace As New ReplaceDialog(RichTextBox1, LangText.GetString("Pad_mnuEditFindReplace").Replace("&", ""), gbooAlwaysOnTop) '"Find and Replace")
        With frmFindAndReplace
            .Owner = Me
            .TopMost = gbooAlwaysOnTop 
            .Show()
            'If RichTextBox1.SelectionLength = RichTextBox1.TextLength Then
            '    RichTextBox1.SelectionLength = 0
            'End If
            'RichTextBox1.Focus()
            '.Activate()
        End With

    End Sub
    Private Sub RefreshBookMarksMenu()
        AddDebugComment("frmPad.RefreshBookMarksMenu") 
        Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID)
        Dim lintArrInc As Integer
        Dim lintArrIncMstr As Integer
        Dim lintMenuItemCounter As Integer
        Dim lbooItemsAdded As Boolean = False
        Dim lintMenuItemsCtr As Integer

        With InitialBookmarks
            Dim evOnClick As New EventHandler(AddressOf BookMarksOnClick)
            'Dim evOnMeasure As New MeasureItemEventHandler(AddressOf MenuFaceNameOnMeasureItem)
            'Dim evDrawItem As New DrawItemEventHandler(AddressOf MenuFaceNameOnDrawItem)
            Dim mnuBookMarkItems() As MenuItem
            mnuBookmarks.MenuItems.Clear()

            Me.mnuBookmarks.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBookmarksAdd, Me.mnuBookmarksRemove, Me.MenuItem19})
            Me.menuEnhancer.SetImageIndex(mnuBookmarksAdd, -1) 
            Me.menuEnhancer.SetImageIndex(mnuBookmarksRemove, -1) 
            Me.menuEnhancer.SetImageIndex(MenuItem19, -1) 

            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            For lintArrInc = 0 To llngItemCount '19
                Dim lstrNewMenuItemText As String = .GetValue("BookmarkName-" & lintArrInc, "")
                Dim lstrNewMenuImgIdx As String = .GetValue("BookmarkImgIdx-" & lintArrInc, "")
                If lstrNewMenuItemText <> "" Then
                    lbooItemsAdded = True
                    ReDim Preserve mnuBookMarkItems(lintMenuItemsCtr)
                    mnuBookMarkItems(lintMenuItemsCtr) = New MenuItem()

                    AddHandler mnuBookMarkItems(lintMenuItemsCtr).Click, evOnClick
                    'AddHandler menuItems(i).MeasureItem, evOnMeasure
                    'AddHandler menuItems(i).DrawItem, evDrawItem

                    
                    'mnuBookMarkItems(lintMenuItemsCtr).Text = lstrNewMenuItemText
                    Dim llngIconIdx As Long
                    Try
                        llngIconIdx = CLng(lstrNewMenuImgIdx)
                    Catch
                        llngIconIdx = 0
                    End Try

                    'Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(llngIconIdx), Bitmap).GetHicon())
                    
                    'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                    'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                    Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(llngIconIdx)
                    ''Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(lintImgIdx), Bitmap).GetHicon())
                    ''

                    ''mnuBookMarkItems(lintMenuItemsCtr) = New IconMenuItem(lstrNewMenuItemText, Ico, evOnClick, Nothing)
                    mnuBookMarkItems(lintMenuItemsCtr) = New MenuItem(lstrNewMenuItemText, evOnClick, Nothing) 
                    Me.menuEnhancer.SetImageIndex(mnuBookMarkItems(lintMenuItemsCtr), lintImgIdx + 1000) 

                    
                    lintMenuItemsCtr += 1
                    ' mnuBookMarkItems(lintArrInc).ta = .GetValue("Bookmarks-" & lintArrInc, ""


                    'miFile.MenuItems.Add(New IconMenuItem("&Open", Ico, handlerFile, Shortcut.CtrlO, MainMenu1))
                End If
            Next lintArrInc
            'mnuBookmarks.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {mnuBookMarkItems(0), mnuBookMarkItems(1), mnuBookMarkItems(2), _
            '    mnuBookMarkItems(3), mnuBookMarkItems(4)})
            If lbooItemsAdded = True Then
                mnuBookmarks.MenuItems.AddRange(mnuBookMarkItems)
            End If
        End With
        'TreeView1.SelectedNode = TreeView1.Nodes(5) 'mstrIndexArray
    End Sub
    Private Sub BookMarksOnClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim lintArrInc As Integer
        Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID)
        Dim lstrTopicCode As String

        With InitialBookmarks
            miBookMark = CType(sender, MenuItem)
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            For lintArrInc = 0 To llngItemCount '19
                Dim lstrNewMenuItemText As String = .GetValue("BookmarkName-" & lintArrInc, "")
                If lstrNewMenuItemText <> "" Then
                    Dim ThisMenuText As String = miBookMark.Text '.Substring(1)
                    If ThisMenuText = lstrNewMenuItemText Then
                        lstrTopicCode = .GetValue("Bookmarks-" & lintArrInc, "")
                        Exit For
                    End If
                End If
            Next lintArrInc
        End With

        'SelectNodeByTag(lstrTopicCode)
        SelectNodeByTag(lstrTopicCode, TreeView1, lcurDocumentView) 

    End Sub
    Private Sub mnuBookmarksAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBookmarksAdd.Click
        AddDebugComment("frmPad.mnuBookmarksAdd_Click") 
        If TreeView1.SelectedNode Is Nothing Then
            'mxessagebox.show("You must select a branch to make a bookmark!", NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            MessageBox.Show(LangText.GetString("Pad_MustSelBranchBook"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
            Dim lAddBookMark As New AddBookmark(lstrDBID, lstrCurTopicCode, TreeView1.ImageList, gbooAlwaysOnTop) 

            With lAddBookMark

                .Owner = Me
                .Caption = NameMe("")
                .AddText = TreeView1.SelectedNode.Text 
                .HelpFile = GetHelpFile() 
                .HelpTopic = GetHelpTopic(main.HelpTopic.bookmarks) 

                Application.DoEvents() 

                .TopMost = gbooAlwaysOnTop 
                .ShowDialog()
            End With
            RefreshBookMarksMenu()
        End If
    End Sub
    Private Sub mnuBookmarksRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBookmarksRemove.Click
        AddDebugComment("frmPad.mnuBookmarksRemove_Click") 

        'Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(frmResources.ilTreeIcons, lstrDBID)
        Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(TreeView1.ImageList, lstrDBID) 

        With lMaintBookMark
            .Owner = Me
            .Caption = NameMe("") 
            .BookmarkType = GenBookMarkMaint.BookmarkTypes.Boomarks
            .HelpFile = GetHelpFile() 
            .HelpTopic = GetHelpTopic(HelpTopic.bookmark_organise) 

            Application.DoEvents() 

            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        RefreshBookMarksMenu()

        'Exit Sub

        'Dim lRemoveBookMark As New RemoveBookmark(lstrDBID)
        'lRemoveBookMark.Owner = Me
        'lRemoveBookMark.ShowDialog()
        'RefreshBookMarksMenu()

    End Sub
    Private Sub mnuFileImportRTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileImportRTF.Click 
        AddDebugComment("frmPad.mnuFileImportRTF_Click") 
        AddCrashComment("#PMFIRTC1") 

        
        BusyPad(Me, True)
        LoadFileToRtb(RichTextBoxStreamType.RichText, RichTextBox1, NameMe(""), StatusBar1, TreeView1.SelectedNode.FullPath, gbooAlwaysOnTop, Me)
        BusyPad(Me, False)

        'Dim lResult As DialogResult

        'Dim OpenFile As New OpenFileDialog() 
        'With OpenFile 
        '    '.Title = "Rich Text File Import"
        '    
        '    .Title = LangText.GetString("Pad_ImpRTFCaption")

        '    .CheckPathExists = True
        '    .DefaultExt = "rtf"
        '    '.Filter = "Rich text file (*.rtf)|*.rtf"
        '    
        '    .Filter = LangText.GetString("Pad_ImpRTFFilter")

        '    If .ShowDialog = DialogResult.Cancel Then 
        '        Exit Sub 
        '    End If

        '    
        '    Dim FileStr As New System.IO.FileInfo(.FileName)
        '    Dim lintFileLengthKB = (FileStr.Length / 1000)
        '    If lintFileLengthKB > 1024 Then '1mb
        '        'mxessagebox.show("big file")
        '        'lResult = MxessageBox.Show("WARNING: Your file is quite large, using it may slow down the program, do you still wish to use it?", NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '        
        '        lResult = MessageBox.Show(LangText.GetString("Pad_ImpRTFLarge"), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '        If lResult <> DialogResult.Yes Then
        '            Exit Sub
        '        End If
        '    End If
        '    

        '    'lResult = MxessageBox.Show("WARNING: Do you want to overwrite the currently selected topic?", NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    
        '    lResult = MessageBox.Show(LangText.GetString("Pad_ImpRTFOverwrite"), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        '    If lResult = DialogResult.Yes Then
        '        'StatusBar1.Panels(0).Text = "Please wait while the file is loading ..."
        '        
        '        StatusBar1.Panels(0).Text = LangText.GetString("Pad_ImpRTFPleaseWait")

        '        Try
        '            BusyPad(Me, True)
        '            RichTextBox1.LoadFile(.FileName, RichTextBoxStreamType.RichText)
        '            BusyPad(Me, False)
        '            'StatusBar1.Panels(0).Text = "File loaded ..."
        '            
        '            'StatusBar1.Panels(0).Text = LangText.GetString("Pad_ImpRTFFileLoaded")

        '            
        '            StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath

        '        Catch ex As Exception
        '            BusyPad(Me, False)
        '            MessageBox.Show(ex.Message, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            StatusBar1.Panels(0).Text = ""
        '        End Try
        '    End If
        'End With
        ClearCrashReport() 
    End Sub
    Private Sub mnuItemAddBookmark_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemAddBookmark.Click
        mnuBookmarksAdd_Click(Nothing, Nothing)
    End Sub
    Private Sub mnuRTFImportRTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFImportRTF.Click
        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuFileImportRTF_Click(Nothing, Nothing)
    End Sub
    Private Sub AddProgressPanel()

        ProgresPanel = New ProgressPanel()
        RightMostPanel = New System.Windows.Forms.StatusBarPanel()

        StatusBar1.Panels.AddRange(New ProgressPanel() {ProgresPanel})
        StatusBar1.Panels.AddRange(New StatusBarPanel() {RightMostPanel})

        With ProgresPanel
            .ForeColor = System.Drawing.SystemColors.Desktop
            .Maximum = 100
            .Minimum = 1
            .MinWidth = 100
            .Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw
            .Text = "" 
            .Value = 0
        End With

        RightMostPanel.MinWidth = 100

        'This is now handled in sub class 
        StatusBar1.SizingGrip = True 

    End Sub
    'Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)

    '    AddDebugComment("frmPad.ToolBar1_ButtonClick " & ToolBar1.Buttons.IndexOf(e.Button)) 
    '    'changed to GetBtnIdx
    '    '--- Added to use new menu 
    '    Select Case ToolBar1.Buttons.IndexOf(e.Button)
    '        Case GetBtnIdx("Print", tbBand.Standard) '1 'btnPrint
    '            mnuFilePrint_Click(Nothing, Nothing)
    '        Case GetBtnIdx("New Root", tbBand.Standard) '3 'btnNewRoot
    '            'mnuFileNewRoot_Click(Nothing, Nothing)
    '            AddNewRootBranch("") 
    '        Case GetBtnIdx("New Sub Branch", tbBand.Standard) '4 'btnNewBranch - sub
    '            'mnuFileNewBranch_Click(Nothing, Nothing)
    '            AddNewSubBranch("") 
    '        Case GetBtnIdx("Cut", tbBand.Standard) '6 'btnCut
    '            mnuEditCut_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Copy", tbBand.Standard) '7 'btnCopy
    '            mnuEditCopy_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Paste", tbBand.Standard) '8 'btnPaste
    '            mnuEditPaste_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Undo", tbBand.Standard) '10 'btnUndo
    '            mnuEditUndo_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Redo", tbBand.Standard) '11 'btnRedo
    '            mnuEditRedo_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Align Left", tbBand.Font) '13 'btnAlignLeft
    '            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    '            RichTextBox1.Focus() 
    '        Case GetBtnIdx("Align Centre", tbBand.Font) '14 'btnAlignCnt
    '            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    '            RichTextBox1.Focus() 
    '        Case GetBtnIdx("Align Right", tbBand.Font) '15 'btnAlignRight
    '            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    '            RichTextBox1.Focus() 
    '        Case GetBtnIdx("Font Style", tbBand.Font) '17 'btnFontChange
    '            mnuRTFFont_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Spelling", tbBand.Standard) 
    '            mnuToolsSpelling_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Word Wrap", tbBand.Font) 
    '            mnuEditWordWrap_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Branch Properties", tbBand.Branch) 
    '            mnuItemProperties_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Rapid Entry", tbBand.Standard) 
    '            DoRapidEntry("") 
    '        Case GetBtnIdx("Font Bold", tbBand.Font) 
    '            'YPosExtra += 1 
    '            'Console.WriteLine(YPosExtra & " tb1-h=" & ToolBar1.Height & " tb2-h=" & pnlFontToolbar.Height) 
    '            SetFontStyle(FontStyle.Bold)
    '        Case GetBtnIdx("Font Italics", tbBand.Font) 
    '            SetFontStyle(FontStyle.Italic)
    '        Case GetBtnIdx("Font Underlined", tbBand.Font) 
    '            SetFontStyle(FontStyle.Underline)
    '        Case GetBtnIdx("Font Colour", tbBand.Font) 
    '            With ColorDialog1
    '                .Color = RichTextBox1.SelectionColor
    '                .ShowDialog()
    '                RichTextBox1.SelectionColor = .Color
    '            End With
    '        Case GetBtnIdx("Insert Graphic", tbBand.Standard) 
    '            mnuEditGraphics_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Bullets", tbBand.Font) 
    '            mnuEditBullets_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Highlight", tbBand.Font) 
    '            'Console.WriteLine("B4 " & RichTextBox1.CanUndo)
    '            'RichTextBox2.SelectionBackColor(CurrentRTFHighlightColour, WinOnly.ExRichTextBox.CHARFORMATRANGE.FormatSelection, RichTextBox1) 
    '            
    '            SelectionBackColor(RichTextBox2, CurrentRTFHighlightColour, CHARFORMATRANGE.FormatSelection, RichTextBox1) 
    '            'Console.WriteLine("AF " & RichTextBox1.CanUndo)
    '    End Select

    '    '--- Added to use new menu 

    '    RefreshCutCopyPaste() 

    'End Sub
    Private Sub SetFontStyleXX(ByVal pfontStyle As FontStyle, Optional ByVal ChangeFont As String = Nothing, Optional ByVal ChangeFontSize As Single = 0)
        lbooDisableDragNDrop = True 
        
        'Adjust main RTB selection to remove last character from selection, IF its a space.
        'otherwise this adds or removes, extra carraige return characters
        If RichTextBox1.SelectedText <> "" Then

            ''Console.WriteLine("#" & RichTextBox1.SelectedRtf & "#")

            ''Console.WriteLine("#" & RightGet(RichTextBox1.SelectedText, 1) & "#" & AscGet(RightGet(RichTextBox1.SelectedText, 1)))
            'Dim AfterSelectionPointChar As Integer = -1
            'Try
            '    RichTextBox1.SelectionLength += 1
            '    'Console.WriteLine("#" & RightGet(RichTextBox1.SelectedText, 1) & "#" & AscGet(RightGet(RichTextBox1.SelectedText, 1)))
            '    AfterSelectionPointChar = AscGet(RightGet(RichTextBox1.SelectedText, 1))
            '    RichTextBox1.SelectionLength -= 1
            'Catch
            'End Try
            ''############# BEST SO FAR ###########
            'If RightGet(RichTextBox1.SelectedText, 2) = ChrGet(10) & ChrGet(10) Then

            'ElseIf RightGet(RichTextBox1.SelectedText, 1) = ChrGet(10) Then
            '    Console.WriteLine("Chopped")
            '    RichTextBox1.SelectionLength -= 1
            'End If
            ''############# BEST SO FAR ###########
            ''If RightGet(RichTextBox1.SelectedText, 1) = ChrGet(10) And AfterSelectionPointChar = 10 Then
            ''    '
            ''ElseIf RightGet(RichTextBox1.SelectedText, 1) = ChrGet(10) Then
            ''    Console.WriteLine("Chopped")
            ''    RichTextBox1.SelectionLength -= 1
            ''End If
            'Dim LastBit As String = RightGet(RichTextBox1.SelectedRtf.ToString, 5)
            'Console.Write("#" & LastBit & "#")


            'If RightGet(RichTextBox1.SelectedRtf, 5) <> ChrGet(10) & "}" And AfterSelectionPointChar = 10 Then
            '    LastBit = RightGet(RichTextBox1.SelectedRtf.ToString, 2)
            '    Console.Write("2#" & AscGet(LeftGet(LastBit, 1)) & "#" & AscGet(RightGet(LastBit, 1)) & "#")

            'If LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 2), 1) = ChrGet(10) And RightGet(RightGet(RichTextBox1.SelectedRtf.ToString, 2), 1) = ChrGet(0) Then
            'If RightGet(RichTextBox1.SelectedRtf, 2) = ChrGet(10) & "}" Then
            '    Console.WriteLine("@")
            '    RichTextBox1.SelectionLength += 1
            'Else
            '    'RichTextBox1.SelectionLength += 1
            'End If

            'ElseIf RightGet(RichTextBox1.SelectedText, 1) = ChrGet(10) Then
            '    RichTextBox1.SelectionLength -= 1
            'End If


            Dim xLastChar As Integer = AscGet(RightGet(RichTextBox1.SelectedRtf.ToString, 1))
            Dim x2ndLastChar As Integer = AscGet(LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 2), 1))
            Dim x3rdLastChar As Integer = AscGet(LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 3), 1))
            Dim x4thLastChar As Integer = AscGet(LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 4), 1))
            Dim x5thLastChar As Integer = AscGet(LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 5), 1))
            Dim x6thLastChar As Integer = AscGet(LeftGet(RightGet(RichTextBox1.SelectedRtf.ToString, 6), 1))
            'Console.WriteLine(xLastChar & "#" & x2ndLastChar & "#" & x3rdLastChar & "#" & x4thLastChar & "#" & x5thLastChar & "#" & x6thLastChar)
            If xLastChar = 0 And x2ndLastChar = 10 And x3rdLastChar = 13 And x4thLastChar = 125 And x5thLastChar = 10 And x6thLastChar = 13 Then
                'do ntothing
                ''Console.WriteLine("one")
            ElseIf xLastChar = 0 And x2ndLastChar = 10 And x3rdLastChar = 13 And x4thLastChar = 125 Then
                'do ntothing
                If InStrGet(RichTextBox1.SelectedRtf, ChrGet(0) & ChrGet(10) & ChrGet(13) & ChrGet(125) & ChrGet(10)) > 0 Then
                    'RichTextBox1.SelectionStart -= 1
                    RichTextBox1.SelectionLength += 1
                Else
                    'RichTextBox1.SelectionLength += 1
                    If RichTextBox1.SelectionStart > 0 Then
                        RichTextBox1.SelectionStart -= 1
                        RichTextBox1.SelectionLength += 2
                    Else
                        'RichTextBox1.SelectionLength += 1
                    End If

                End If
                'RichTextBox1.SelectionLength += 1
                ''Console.WriteLine("two")
            Else
                'RichTextBox1.SelectionLength += 1
                ''Console.WriteLine("three")
            End If
        End If
        '

        
        Dim Route As Integer = 0
        If Not ChangeFont Is Nothing Then
            Route = 1
        End If
        If ChangeFontSize > 0 Then
            Route = 2
        End If
        

        RichTextBox2.Rtf = RichTextBox1.SelectedRtf

        Dim lengt As Integer = RichTextBox2.Text.Length

        
        ProgresPanel.Maximum = lengt
        ProgresPanel.Minimum = 0
        ProgresPanel.Value = 0
        

        Dim SelLength As Integer = RichTextBox1.SelectionLength
        Dim SelStart As Integer = RichTextBox1.SelectionStart
        Dim i As Integer

        Dim lbooDontUpdateCombo As Boolean = False 
        If lengt = 0 Then 
            
            'Dim cfont As Font = RichTextBox1.SelectionFont
            
            Dim cfont As Font
            Select Case Route
                Case 0
                    cfont = RichTextBox1.SelectionFont
                Case 1
                    Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
                    Try
                        cfont = New Font(ChangeFont, currentFont.Size, currentFont.Style)
                    Catch
                    End Try
                    lbooDontUpdateCombo = True 
                Case 2
                    Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
                    cfont = New Font(currentFont.FontFamily.Name, ChangeFontSize, currentFont.Style)
            End Select
            ''If ChangeFont Is Nothing Then
            ''    cfont = RichTextBox1.SelectionFont
            ''Else
            ''    Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
            ''    cfont = New Font(ChangeFont, currentFont.Size, currentFont.Style)
            ''End If
            
            Dim fs As FontStyle = cfont.Style

            If pfontStyle = FontStyle.Bold Then
                If RichTextBox1.SelectionFont.Bold = True Then
                    fs = fs And Not FontStyle.Bold
                Else
                    fs = fs Or FontStyle.Bold
                End If
            ElseIf pfontStyle = FontStyle.Italic Then
                If RichTextBox1.SelectionFont.Italic = True Then
                    fs = fs And Not FontStyle.Italic
                Else
                    fs = fs Or FontStyle.Italic
                End If
            ElseIf pfontStyle = FontStyle.Strikeout Then
                If RichTextBox1.SelectionFont.Strikeout = True Then
                    fs = fs And Not FontStyle.Strikeout
                Else
                    fs = fs Or FontStyle.Strikeout
                End If
            ElseIf pfontStyle = FontStyle.Underline Then
                If RichTextBox1.SelectionFont.Underline = True Then
                    fs = fs And Not FontStyle.Underline
                Else
                    fs = fs Or FontStyle.Underline
                End If
            End If

            RichTextBox1.SelectionFont = New Font(cfont.FontFamily, cfont.Size, fs)
            
        Else 

            Dim StartTime As Date = Date.Now 

            For i = 0 To lengt - 1
                '   RichTextBox2.Select(i, 1)
                'For lintArrInc = 0 To RichTextBox1.Rtf.Length
                
                SelectRange(RichTextBox2, i, 1)

                
                'Dim cfont As Font = RichTextBox2.SelectionFont
                Dim cfont As Font

                Select Case Route
                    Case 0
                        cfont = RichTextBox2.SelectionFont
                    Case 1
                        Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont
                        Try
                            cfont = New Font(ChangeFont, currentFont.Size, currentFont.Style)
                        Catch
                            Console.WriteLine("Error")
                        End Try
                        lbooDontUpdateCombo = True
                    Case 2
                        Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont
                        cfont = New Font(currentFont.FontFamily.Name, ChangeFontSize, currentFont.Style)
                End Select
                ''If ChangeFont Is Nothing Then
                ''    cfont = RichTextBox2.SelectionFont
                ''Else
                ''    Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont
                ''    cfont = New Font(ChangeFont, currentFont.Size, currentFont.Style)
                ''End If
                

                Dim fs As FontStyle = cfont.Style

                If pfontStyle = FontStyle.Bold Then
                    If RichTextBox2.SelectionFont.Bold = True Then
                        fs = fs And Not FontStyle.Bold
                    Else
                        fs = fs Or FontStyle.Bold
                    End If
                ElseIf pfontStyle = FontStyle.Italic Then
                    If RichTextBox2.SelectionFont.Italic = True Then
                        fs = fs And Not FontStyle.Italic
                    Else
                        fs = fs Or FontStyle.Italic
                    End If
                ElseIf pfontStyle = FontStyle.Strikeout Then
                    If RichTextBox2.SelectionFont.Strikeout = True Then
                        fs = fs And Not FontStyle.Strikeout
                    Else
                        fs = fs Or FontStyle.Strikeout
                    End If
                ElseIf pfontStyle = FontStyle.Underline Then
                    If RichTextBox2.SelectionFont.Underline = True Then
                        fs = fs And Not FontStyle.Underline
                    Else
                        fs = fs Or FontStyle.Underline
                    End If
                End If

                'If fs <> style Then 'If add Then
                '    fs = fs Or style
                'Else
                '    fs = fs And Not style
                'End If
                RichTextBox2.SelectionFont = New Font(cfont.FontFamily, cfont.Size, fs)

                
                If DateDiffGet(strman.DateInterval.Second, StartTime, Date.Now) > 5 Then
                    System.Windows.Forms.Application.DoEvents()
                    ProgresPanel.Value = i
                    StartTime = Date.Now
                End If
                
            Next i


            ''RichTextBox2.Select(0, WinOnly.GetTextLen(RichTextBox2)) 

            
            RichTextBox2.Select(0, WinOnly.GetTextLen(RichTextBox2))
            RichTextBox1.SelectedRtf = RichTextBox2.SelectedRtf

            '
            ''RichTextBox1.SelectedRtf = RichTextBox2.Rtf

            'RichTextBox1.Select(SelStart, SelLength)
            SelectRange(RichTextBox1, SelStart, SelLength) 
        End If 
        Me.RichTextBox1.Focus()

        RichTextBox2.Rtf = ""


        ProgresPanel.Value = 0 

        lbooDisableDragNDrop = False 
        'Console.WriteLine("SetFontStyle - UpdateFontStyleSelections")

        UpdateFontStyleSelections(, lbooDontUpdateCombo) 

    End Sub
    Private Sub mnuEditFindTopic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditFindTopic.Click
        gstrMRPs = "0919"
        AddDebugComment("frmPad.mnuEditFindTopic_Click") 

        Application.DoEvents() 

        Dim frmFindTopic As New findindb()
        With frmFindTopic
            .Owner = Me
            .Caption = NameMe("") 
            '.ViewSetting(lcurDocumentView)
            .TreeviewSelect = TreeView1
            '.Show
            
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
            Application.DoEvents() 
            If .TopicCode <> "" Then
                lcurDocumentView = DocumentViews.NormalTopic
                SelectNodeByTag(.TopicCode, TreeView1)
                lstrCurTopicCode = TreeView1.SelectedNode.Tag

                Dim lstrTemplateFileName, lstrFormData As String
                Dim lbooSysTemplate As Boolean

                lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                    lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                lbooRTFContentsChanged = False

                If lstrTemplateFileName <> "" Then
                    If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
                    ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
                    lcurDocumentView = DocumentViews.NormalTopic 
                End If
            End If
            
        End With

    End Sub
    Private Sub mnuToolsSpelling_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsSpelling.Click
        gstrMRPs = "0923"
        AddDebugComment("frmPad.mnuToolsSpelling_Click") 
        If RichTextBox1.Visible = True Then 
            
            Dim lstrSpellDir As String = System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Spelling\"

            Dim lstrDefaultDictionary As String = GetSetting( _
                "DictionaryFile", "", InitalXMLConfig.XmlConfigType.AppSettings, "")

            If System.IO.File.Exists(lstrSpellDir & lstrDefaultDictionary) = False Then
                'mxessagebox.show("No dictionary has been installed!, please goto the" & _
                '                "'Tools' menu and select 'Options', then 'Spelling'.", NameMe(""))
                
                MessageBox.Show(LangText.GetString("Pad_SpellingSetError"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                Exit Sub
            End If

            If GetTextLen(RichTextBox1) = 0 Then 
                Exit Sub
            End If

            Dim sp As New spellchecker(gbooAlwaysOnTop)
            With sp
                .Owner = Me
                .TextBox = RichTextBox1
                .Caption = NameMe("")
                .DictionaryFile = lstrSpellDir & lstrDefaultDictionary
                If System.IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "") = False Then
                    System.IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName)
                End If
                .CustomDictionaryFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "\customdictionary.dic"

                .WaitForMore = False
                .TopMost = gbooAlwaysOnTop 
                .Show()
                .DoingCheck = True

                '.ShowDialog() 'show 
            End With
        Else
            CheckBrowserSpelling(AxWebBrowser1)
        End If
    End Sub
    Private Function GetBtnIdx(ByVal pstrTag As String, ByVal BandIdx As tbBand) As Integer
        Dim lintArrInc As Integer


        For lintArrInc = 0 To tbCoolbar.Bands(BandIdx).Buttons.Count
            If Not tbCoolbar.Bands(BandIdx).Buttons.Item(lintArrInc).Tag Is Nothing Then
                If CStr(tbCoolbar.Bands(BandIdx).Buttons.Item(lintArrInc).Tag).ToUpper = pstrTag.ToUpper Then
                    GetBtnIdx = lintArrInc
                    Exit Function
                End If
            End If
        Next

        'Console.WriteLine("ERROR!!! ToolbarButton Idx not found!")

    End Function
    Private Sub RefreshTemplatesMenu()
        AddDebugComment("frmPad.RefreshTemplatesMenu") 
        Dim InitialTemplates As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
        Dim lintArrInc As Integer
        Dim lintArrIncMstr As Integer
        Dim lintMenuItemCounter As Integer
        Dim lbooItemsAdded As Boolean = False
        Dim lintMenuItemsCtr As Integer

        Dim evOnClick As New EventHandler(AddressOf TemplatesOnClick)
        Dim mnuTemplateItems() As MenuItem
        mnuTemplates.MenuItems.Clear()

        'mnuTemplatesSelect.Index = -1
        'mnuTemplatesSelect.Text = "&Select Template"
        'mnuTemplatesRemove.Index = -1
        'mnuTemplatesRemove.Text = "&Remove Bookmarks"

        'mnuTemplates.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTemplatesSelect, Me.mnuTemplatesOrganise, Me.mnuTemplateToRTF, Me.mnuTemplatesSep})
        
        mnuTemplates.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTemplatesSelect, Me.mnuTemplatesOrganise, Me.mnuTemplatesRapidEntry, Me.mnuTemplateToRTF, Me.mnuTemplateTextSize, Me.mnuTemplatesSep})

        With InitialTemplates
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            For lintArrInc = 0 To llngItemCount '10
                Dim lstrNewMenuItemText As String = .GetValue("Name" & lintArrInc, "")
                Dim lstrNewMenuImgIdx As String = .GetValue("ImgIdx" & lintArrInc, "")
                If lstrNewMenuItemText <> "" Then
                    lbooItemsAdded = True
                    ReDim Preserve mnuTemplateItems(lintMenuItemsCtr)
                    mnuTemplateItems(lintMenuItemsCtr) = New MenuItem()

                    AddHandler mnuTemplateItems(lintMenuItemsCtr).Click, evOnClick

                    '----- 
                    'mnuTemplateItems(lintMenuItemsCtr).Text = "&" & lintArrInc + 1 & " " & lstrNewMenuItemText
                    Dim llngIconIdx As Long
                    Try
                        llngIconIdx = CLng(lstrNewMenuImgIdx)
                    Catch
                        llngIconIdx = 0
                    End Try

                    'Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(llngIconIdx), Bitmap).GetHicon())
                    
                    'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                    'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                    Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(llngIconIdx)
                    ''Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(lintImgIdx), Bitmap).GetHicon())
                    ''
                    ''mnuTemplateItems(lintMenuItemsCtr) = New IconMenuItem("&" & lintMenuItemsCtr + 1 & " " & lstrNewMenuItemText, Ico, evOnClick, Nothing)

                    mnuTemplateItems(lintMenuItemsCtr) = New MenuItem("&" & lintMenuItemsCtr + 1 & " " & lstrNewMenuItemText, evOnClick, Nothing) 
                    Me.menuEnhancer.SetImageIndex(mnuTemplateItems(lintMenuItemsCtr), lintImgIdx + 1000) 
                    
                    lintMenuItemsCtr += 1
                End If
            Next lintArrInc
            If lbooItemsAdded = True Then
                mnuTemplates.MenuItems.AddRange(mnuTemplateItems)
            End If
        End With

        Dim mnuTemplateSep2 As MenuItem
        mnuTemplateSep2 = New MenuItem()
        mnuTemplateSep2.Text = "-"

        mnuTemplateViewSource = New MenuItem()
        'mnuTemplateViewSource.Text = "&View Source"
        mnuTemplateViewSource.Text = LangText.GetString("Pad_mnuTemplateViewSource") 
        Me.menuEnhancer.SetImageIndex(mnuTemplateViewSource, -1) 

        'AddHandler mnuTemplateViewSource.Click, AddressOf mnuTemplateViewSource_Click
        If lbooItemsAdded = True Then 
            Me.menuEnhancer.SetImageIndex(mnuTemplateSep2, -1) 
            mnuTemplates.MenuItems.Add(mnuTemplateSep2)
        End If
        mnuTemplates.MenuItems.Add(mnuTemplateViewSource)
    End Sub
    Private Sub TemplatesOnClick(ByVal sender As Object, ByVal e As EventArgs)
        miTemplate = CType(sender, MenuItem) 
        ProcessTemplateSelection(miTemplate.Text) 

    End Sub
    Private Sub ProcessTemplateSelection(ByVal pstrTemplateSelected As String, Optional ByVal pstrTemplateID As String = "", _
        Optional ByVal pstrFileName As String = "", Optional ByVal pbooDLL As Boolean = False)
        gstrMRPs = "0926"
        AddCrashComment("#PPTS1") 

        Dim TemOp As New TemplateOption(gbooAlwaysOnTop)
        Dim lDlgResult As New DialogResult()
        With TemOp
            .Caption = NameMe("")
            .HelpFile = GetHelpFile() 
            .HelpTopic = GetHelpTopic(HelpTopic.Template_options_create) 
            .TopMost = gbooAlwaysOnTop 
            .Owner = Me 
            lDlgResult = .ShowDialog 
        End With
        'TemOp.Always
        AddCrashComment("#PPTS2") 
        If lDlgResult <> DialogResult.OK Then
            Exit Sub
        End If

        '---- Get Template File name / ID ----
        'Dim lstrTemplateID As String 
        Dim lintArrInc As Integer
        'Dim lstrFileName As String
        'Dim lbooDLL As Boolean = False
        If pstrTemplateID = "" Then 
            GetSelectedTemplateFromMenu(pstrTemplateSelected, pstrTemplateID, pstrFileName, pbooDLL)
        End If

        Dim lbooActionPerformed As Boolean = True 

        lstrHTMLFormData = "" 

        AddDebugComment("frmPad.ProcessTemplateSelection" & TemOp.Choice) 
        AddCrashComment("#PPTS3") 
        Select Case TemOp.Choice
            Case "ROOT"
                If AddNewRootBranch(pstrTemplateID) = False Then 
                    lbooActionPerformed = False 
                End If
            Case "SUB"
                If AddNewSubBranch(pstrTemplateID) = False Then 
                    lbooActionPerformed = False 
                End If
            Case "OVERWRITE", "MERGE"
                If lstrCurTopicCode <> "" Then 
                    'just udate TopicDetail with templateid
                    Dim lcnn1 As New ADODB.Connection()
                    Dim lsnaLists As New ADODB.Recordset()
                    lcnn1 = New ADODB.Connection()
                    'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                    lcnn1.Open(gstrConnectionString)

                    If TemOp.Choice = "MERGE" Then 

                        UpdateRTFToDB() 

                        
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & "' where TopicCode = '" & _
                        '    ReturnTrueTopicStr(lstrCurTopicCode) & "';")

                        
                        lstrCurLockFlag = CreateLockingFlag(ReturnTrueTopicStr(lstrCurTopicCode))
                        'should be too much of a problem as they can change the template back.
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & "', LockingFlag='" & lstrCurLockFlag & _
                        '    "' where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';")
                        
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & "', LockingFlag='" & lstrCurLockFlag & _
                        '    "', ByteLen = -1 where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';")
                        
                        Dim lstrSQL As String = "Update TopicDetail set TemplateID='" & pstrTemplateID & "', LockingFlag='" & lstrCurLockFlag & _
                            "', ByteLen = -1, Options = 'Default' where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';"
                        AddCrashComment("#PPTS4") 
                        gstrLastSQL = lstrSQL 
                        lcnn1.Execute(lstrSQL) 

                        lcnn1.Close()

                        Dim lbooSysTemplate As Boolean
                        'GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                        '    pstrFileName, lbooSysTemplate, lstrHTMLFormData)
                        
                        lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                            pstrFileName, lbooSysTemplate, lstrHTMLFormData)
                        lbooRTFContentsChanged = False 'reset 
                    Else
                        
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & "', Detail = ' ' where TopicCode = '" & _
                        '    ReturnTrueTopicStr(lstrCurTopicCode) & "';")
                        
                        lstrCurLockFlag = CreateLockingFlag(ReturnTrueTopicStr(lstrCurTopicCode))
                        'can do any lock checking, just hope and pray!
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & "', Detail = ' ', LockingFlag ='" & _
                        '    lstrCurLockFlag & "' where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';")

                        'to stop find template error
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & _
                        '    "', Detail = '<emaNtcatnoC></emaNtcatnoC>', LockingFlag ='" & _
                        '    lstrCurLockFlag & "' where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';")
                        
                        'lcnn1.Execute("Update TopicDetail set TemplateID='" & pstrTemplateID & _
                        '    "', Detail = '<emaNtcatnoC></emaNtcatnoC>', LockingFlag ='" & _
                        '    lstrCurLockFlag & "', ByteLen = -1 where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';")
                        
                        Dim lstrSQL As String = "Update TopicDetail set TemplateID='" & pstrTemplateID & _
                            "', Detail = '<emaNtcatnoC></emaNtcatnoC>', LockingFlag ='" & _
                            lstrCurLockFlag & "', ByteLen = -1, Options = 'Default' where TopicCode = '" & ReturnTrueTopicStr(lstrCurTopicCode) & "';"
                        AddCrashComment("#PPTS5") 
                        gstrLastSQL = lstrSQL 
                        lcnn1.Execute(lstrSQL) 

                        lcnn1.Close()
                    End If
                Else
                    lbooActionPerformed = False 
                End If
            Case "RAPID" 
                DoRapidEntry(pstrTemplateID) 
                lbooActionPerformed = False 
            Case Else
                lbooActionPerformed = False 
        End Select
        AddCrashComment("#PPTS6") 
        If lbooActionPerformed = True Then 
            ShowBrowser()
            ShowForm(pstrFileName, AxWebBrowser1, pbooDLL)
            lcurDocumentView = DocumentViews.NormalTopic 
        End If
        ClearCrashReport() 
    End Sub
    Private Sub mnuTemplatesSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplatesSelect.Click
        AddDebugComment("frmPad.mnuTemplatesSelect_Click") 

        Dim TS As New TemplateSelection()
        TS.Owner = Me 
        TS.TopMost = gbooAlwaysOnTop 
        TS.ShowDialog()
        Application.DoEvents() 

        'mxessagebox.show(TS.TemplateID)

        

        With TS
            If .DialogResult = DialogResult.OK Then
                RefreshTemplatesMenu()
                Dim lbooSystem As Boolean = False
                Dim lstrFileName As String = .TemplateFileName
                If InStrGet(TS.TemplateFileName, "SYSTEM:") > 0 Then
                    lstrFileName = Microsoft.VisualBasic.Replace(lstrFileName, "SYSTEM:", "")
                    lbooSystem = True
                End If

                ProcessTemplateSelection(.TemplateName, .TemplateID, lstrFileName, lbooSystem)
            End If
        End With
        
    End Sub
    Private Sub xxPrefetchWebBrowser()
        'Console.WriteLine("A " & Date.Now)

        Me.SuspendLayout()


        'AxWebBrowser.Navigate("about:blank")

        Dim TR As New IPTemplates._main()
        Dim lstrTemplateResources() As IPTemplates._main.resources
        TR.HTMLForms(lstrTemplateResources)

        'RichTextBox1.Visible = False
        'AxWebBrowser1.BringToFront()
        AxWebBrowser1.Visible = True
        StatusBar1.SendToBack()
        'Me.ResumeLayout()


        'Me.SuspendLayout()
        ShowForm("contact.html", AxWebBrowser1, True)

        Dim lstrFormData As String = "<emaNtcatnoC>Test</emaNtcatnoC><1sserddAtcatnoC>Test</1sserddAtcatnoC><2sserddAtcatnoC>Test" & _
            "</2sserddAtcatnoC><3sserddAtcatnoC>Test</3sserddAtcatnoC><4sserddAtcatnoC>Test</4sserddAtcatnoC><5sserddAtcatnoC>Test" & _
            "</5sserddAtcatnoC><edoCtsoPtcatnoC>Test</edoCtsoPtcatnoC><enohpeleTyaDtcatnoC>Test</enohpeleTyaDtcatnoC>" & _
            "<enohpeleTevEtcatnoC>Test</enohpeleTevEtcatnoC><raeYyadhtriBtcatnoC>Test</raeYyadhtriBtcatnoC><htnoMyadhtriBtcatnoC>" & _
            "January</htnoMyadhtriBtcatnoC><yaDyadhtriBtcatnoC>01</yaDyadhtriBtcatnoC><setoNtcatnoC>Test</setoNtcatnoC>"

        'If AxWebBrowser1.ReadyState = SHDocVw.tagREADYSTATE.READYSTATE_LOADING Then
        '    Do Until AxWebBrowser1.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
        '        System.Windows.Forms.Application.DoEvents()
        '    Loop
        'End If

        WaitForBrowser(AxWebBrowser1) 

        PopulateHTMLFields(lstrFormData, AxWebBrowser1)

        RichTextBox1.BringToFront() 
        Me.ResumeLayout()

        'Dim doc As IHTMLDocument2 = CType(AxWebBrowser1.Document, IHTMLDocument2)
        'Dim htmlEvents As HTMLDocumentEvents2_Event = CType(doc, HTMLDocumentEvents2_Event)
        'AddHandler htmlEvents.onmousedown, AddressOf Webbrowser_OnMouseDown
        'Console.WriteLine("G " & Date.Now)
    End Sub
    'Private Sub AxWebBrowser1_DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles AxWebBrowser1.DocumentComplete
    
    Private Sub AxWebBrowser1_DocumentComplete(ByVal sender As Object, ByVal e As Object) Handles AxWebBrowser1.DocumentComplete



        'Console.WriteLine("AxWebBrowser1_DocumentComplete Start")
        If lstrHTMLFormData <> "" Then
            PopulateHTMLFields(lstrHTMLFormData, AxWebBrowser1)
            lstrOldFormData = lstrHTMLFormData 
            lstrHTMLFormData = ""
            'Console.WriteLine("AxWebBrowser1_DocumentComplete Populated")
        End If

        'Dim DocHandle As IHTMLDocument2 = CType(AxWebBrowser1.Document, IHTMLDocument2) 
        'Dim htmlEvents As HTMLDocumentEvents2_Event = CType(DocHandle, HTMLDocumentEvents2_Event)  
        'AddHandler htmlEvents.onmousedown, AddressOf Webbrowser_OnMouseDown

    End Sub
    Private Sub mnuTemplateToRTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplateToRTF.Click
        AddDebugComment("frmPad.mnuTemplateToRTF_Click") 

        Dim ldlgResult As DialogResult
        'ldlgResult = MxessageBox.Show("Do you want to use rich text instead a template?" & Environment.NewLine & Environment.NewLine & _
        '    "WARNING: You will loose any data you have used in the template!", NameMe(""), MessageBoxButtons.YesNo)
        
        ldlgResult = MessageBox.Show(LangText.GetString("Pad_TempToRTFWarn").Replace("[CR2]", _
            Environment.NewLine & Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props


        If ldlgResult <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
        lcnn1.Open(gstrConnectionString)

        
        'lcnn1.Execute("Update TopicDetail set TemplateID=' ', Detail = ' ' where TopicCode = '" & _
        '    ReturnTrueTopicStr(TreeView1.SelectedNode.Tag) & "';")

        
        lstrCurLockFlag = CreateLockingFlag(ReturnTrueTopicStr(TreeView1.SelectedNode.Tag))
        'as long as you have a message in UpdateTopicDetailRTF to say the record has changed and cannot be saved
        'lcnn1.Execute("Update TopicDetail set TemplateID=' ', Detail = ' ', LockingFlag='" & lstrCurLockFlag & "' where TopicCode = '" & _
        '    ReturnTrueTopicStr(TreeView1.SelectedNode.Tag) & "';")
        
        'lcnn1.Execute("Update TopicDetail set TemplateID=' ', Detail = ' ', LockingFlag='" & lstrCurLockFlag & _
        '    "', ByteLen = -1 where TopicCode = '" & ReturnTrueTopicStr(TreeView1.SelectedNode.Tag) & "';")
        
        Dim lstrSQL As String = "Update TopicDetail set TemplateID=' ', Detail = ' ', LockingFlag='" & lstrCurLockFlag & _
            "', ByteLen = -1, Options='Default' where TopicCode = '" & ReturnTrueTopicStr(TreeView1.SelectedNode.Tag) & "';"

        gstrLastSQL = lstrSQL 
        lcnn1.Execute(lstrSQL) 

        lcnn1.Close()

        RichTextBox1.Rtf = ""

        ShowRTF()

    End Sub
    Private Sub mnuTemplates_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplates.Popup
        If RichTextBox1.Visible = True Then
            mnuTemplateToRTF.Enabled = False
            mnuTemplateViewSource.Enabled = False
            mnuTemplateTextSize.Enabled = False 
            mnuTemplateTextSizeLarger.Enabled = False 
            mnuTemplateTextSizeSmaller.Enabled = False 
        Else
            mnuTemplateToRTF.Enabled = True
            If mstrIndexArray(0).strTopicCode = "" Then 
                mnuTemplateToRTF.Enabled = False 
            End If
            mnuTemplateViewSource.Enabled = True
            mnuTemplateTextSize.Enabled = True 
            mnuTemplateTextSizeLarger.Enabled = True 
            mnuTemplateTextSizeSmaller.Enabled = True 
            
            If lcurDocumentView = DocumentViews.MCLStartup Then 'stop view source on startup
                mnuTemplateViewSource.Enabled = False
            End If
            
        End If


    End Sub
    Friend Sub ShowBrowser()

        AddDebugComment("frmPad.ShowBrowser") 
        'Console.WriteLine("ShowBrowser Start")
        Me.SuspendLayout()

        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Spelling", tbBand.Standard)).Enabled = True 

        'RichTextBox1.SelectionLength = 0 
        'RichTextBox1_MouseUp(Nothing, Nothing) 
        EnableDisableButsNMenu(False) 
        ''lbooDBAccOrUIAcc = True 
        'Console.WriteLine("ShowBrowser Pos 1")
        lbooDontAllowRTBLeaveToUpdateTemplateTopic = True 
        RichTextBox1.Visible = False
        'Console.WriteLine("ShowBrowser Pos 2")
        lbooDontAllowRTBLeaveToUpdateTemplateTopic = False 
        AxWebBrowser1.BringToFront()
        AxWebBrowser1.Visible = True
        AxWebBrowser1.Location = AxWebBrowser1.Location 
        'Console.WriteLine("ShowBrowser Pos 3")
        StatusBar1.SendToBack()
        'lbooDBAccOrUIAcc = False 
        Me.ResumeLayout()
        'Console.WriteLine("ShowBrowser End")

    End Sub
    Friend Sub ShowRTF()

        'Console.WriteLine("ShowRTF")
        'AddDebugComment("frmPad.ShowRTF - Start") 
        gstrProbComtStack = "frmPad.ShowRTF - Start" 
        Me.SuspendLayout()
        'AddDebugComment("frmPad.ShowRTF - 1") 
        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Spelling", tbBand.Standard)).Enabled = True 
        'AddDebugComment("frmPad.ShowRTF - 2") 
        gstrProbComtStack &= " #SR2" 

        EnableDisableButsNMenu(True) 
        'AddDebugComment("frmPad.ShowRTF - 3") 
        gstrProbComtStack &= " #SR3" 
        lbooFx11FixDontLeaveNow = True 
        'AddDebugComment("frmPad.ShowRTF - 4") 
        gstrProbComtStack &= " #SR4" 
        AxWebBrowser1.Visible = False
        lbooFx11FixDontLeaveNow = False 
        'AddDebugComment("frmPad.ShowRTF - 5") 
        gstrProbComtStack &= " #SR5" 
        RichTextBox1.BringToFront()
        RichTextBox1.Visible = True
        'AddDebugComment("frmPad.ShowRTF - 6") 
        gstrProbComtStack &= " #SR6" 
        StatusBar1.SendToBack()
        Me.ResumeLayout()

        'AddDebugComment("frmPad.ShowRTF - End") 

        gstrProbComtStack &= " #SR-End" 
        AddDebugComment(gstrProbComtStack) 
        gstrProbComtStack = "" 

    End Sub
    Private Sub EnableDisableButsNMenu(ByVal pbool As Boolean)

        AddDebugComment("frmPad.EnableDisableButsNMenu " & pbool) 

        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Style", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Align Right", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Align Centre", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Align Left", tbBand.Font)).Enabled = pbool
        
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Bold", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Italics", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Underlined", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Colour", tbBand.Font)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Insert Graphic", tbBand.Standard)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Insert Table", tbBand.Standard)).Enabled = pbool 

        tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Page Colour", tbBand.Standard)).Enabled = pbool 

        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Bullets", tbBand.Font)).Enabled = pbool

        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Highlight", tbBand.Font)).Enabled = pbool 
        tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Enabled = pbool 

        cboFontName.Enabled = pbool 
        cboFontSize.Enabled = pbool 
        

        'Console.WriteLine("EnableDisableButsNMenu - UpdateFontStyleSelections")
        UpdateFontStyleSelections(pbool)  

    End Sub
    Private Sub mnuEditFindTemplateTopic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditFindTemplateTopic.Click

        AddDebugComment("frmPad.mnuEditFindTemplateTopic_Click") 

        Dim TempSearch As New TemplateSearch()
        With TempSearch
            .Owner = Me
            .ViewSetting(lcurDocumentView)
            .CallingForm = Me
            .TreeviewSelect = TreeView1
            '.Show() 'Dialog()
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog() 
        End With

    End Sub
    Private Sub mnuFileImportWizard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileImportWizard.Click
        gstrMRPs = "0929"
        AddDebugComment("frmPad.mnuFileImportWizard_Click") 
        AddCrashComment("#PMFIWC1") 

        UpdateRTFToDB() 
        AddCrashComment("#PMFIWC1a") 

        Application.DoEvents() 

        Dim ImpWiz As New Import()
        With ImpWiz
            .Owner = Me
            .CallingForm = Me
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
            Application.DoEvents() 
            BusyPad(Me, True) 
            AddCrashComment("#PMFIWC2") 
            If .ImptdBookmarks = True Then
                RefreshBookMarksMenu()
            End If
            If .ImptdClrSchemes = True Then

            End If
            AddCrashComment("#PMFIWC2a") 
            If .ImptdGenSets = True Then
                lbooDBAccOrUIAcc = True
                RefreshGeneralSettings()
                lbooDBAccOrUIAcc = False
            End If
            If .ImptdTemplates = True Then

            End If
            AddCrashComment("#PMFIWC2b") 
            If .ImptdTemplBooks = True Then
                RefreshTemplatesMenu()
            End If
            AddCrashComment("#PMFIWC3") 
            If .ImptdTopics = True Then
                If .ImptdGenSets = False Then 'already done a refresh
                    mnuToolsRefresh_Click(Nothing, Nothing)
                End If
            End If
        End With

        AddCrashComment("#PMFIWC4") 

        AddDebugComment("frmPad.mnuFileImportWizard_Click End") 

        ClearCrashReport() 
        BusyPad(Me, False) 

    End Sub
    Private Sub mnuFileExportTempData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExportTempData.Click

        AddDebugComment("frmPad.mnuFileExportTempData_Click") 
        AddCrashComment("#PMFETDC1") 
        UpdateRTFToDB() 

        Application.DoEvents() 

        Dim TempEx As New TemplateExport()
        With TempEx
            .OutputType = TemplateDataTypes.TemplateOutput.TabbedDelim 
            .Owner = Me
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        ClearCrashReport() 
    End Sub
    Private Sub mnuFileExportTempDataXML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExportTempDataXML.Click

        'added 

        AddDebugComment("frmPad.mnuFileExportTempDataXML_Click")
        AddCrashComment("#PMFETDXC1") 
        UpdateRTFToDB()

        Application.DoEvents()

        Dim TempEx As New TemplateExport()
        With TempEx
            .OutputType = TemplateDataTypes.TemplateOutput.XML
            .Owner = Me
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        ClearCrashReport() 
    End Sub
    Private Sub mnuFileExportWizard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExportWizard.Click
        gstrMRPs = "0933"
        AddDebugComment("frmPad.mnuFileExportWizard_Click") 
        AddCrashComment("#PMFEWC1") 
        UpdateRTFToDB() 

        Application.DoEvents() 

        Dim ExpWiz As New Export()
        With ExpWiz
            .Owner = Me
            .CallingForm = Me
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        AddDebugComment("frmPad.mnuFileExportWizard_Click End") 

        ClearCrashReport() 
    End Sub
    Private Sub ContextMenuHTMLView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuHTMLView.Click

        'ViewSource(AxWebBrowser1)
        AxWebBrowser1.ViewSource() 

    End Sub
    Private Sub ContextMenuHTMLPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuHTMLPrint.Click
        mnuFilePrint_Click(Nothing, Nothing)
    End Sub
    Private Sub mnuTemplateViewSource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplateViewSource.Click
        'Dim cmdGUID As New Guid(&HED016940, -17061, &H11CF, &HBA, &H4E, &H0, &HC0, &H4F, &HD7, &H8, &H16)
        'Dim cmdt As IOleCommandTarget
        'Dim o As Object
        'cmdt = CType(AxWebBrowser1.HtmlDocument, IOleCommandTarget)
        'cmdt.Exec(cmdGUID, 2, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, o, o)

        AxWebBrowser1.ViewSource() 

    End Sub
    Private Sub RefreshCutCopyPaste(ByVal pbooDontUpdateFonts As Boolean)

        
        If tbCoolbar.Bands(tbBand.Standard).Visible = False Then
            Exit Sub
        End If
        

        If Not TreeView1.SelectedNode Is Nothing Then 
            tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Branch Properties", tbBand.Branch)).Enabled = True 
        Else
            tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Branch Properties", tbBand.Branch)).Enabled = False 
        End If
        CheckNode() 

        'Console.WriteLine("A " & RichTextBox1.CanUndo) 
        If RichTextBox1.Visible = True Then
            If RichTextBox1.SelectionLength > 0 Then
                'Console.WriteLine("B " & RichTextBox1.CanUndo) 
                tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Cut", tbBand.Standard)).Enabled = True
                tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Copy", tbBand.Standard)).Enabled = True
                mnuEditCopy.Enabled = True
                mnuEditCut.Enabled = True
                mnuEditDelete.Enabled = mnuEditCut.Enabled 
            Else

            End If
            
            'tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Paste", tbBand.Standard)).Enabled = RichTextBox1.CanPaste(Clipboard.GetDataObject)
            'mnuEditPaste.Enabled = RichTextBox1.CanPaste(Clipboard.GetDataObject)
            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Paste", tbBand.Standard)).Enabled = True
            mnuEditPaste.Enabled = True

            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Undo", tbBand.Standard)).Enabled = RichTextBox1.CanUndo
            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Redo", tbBand.Standard)).Enabled = RichTextBox1.CanRedo 

            mnuEditRedo.Enabled = RichTextBox1.CanRedo
            mnuEditUndo.Enabled = RichTextBox1.CanUndo

            mnuEditFindReplace.Enabled = True 
            mnuFormatFont.Enabled = True 

            tbCoolbar.Bands(tbBand.Font).Enabled = True 

            UpdateFontStyleSelections(, pbooDontUpdateFonts) 
        ElseIf AxWebBrowser1.Visible = True Then
            mnuEditRedo.Enabled = AxWebBrowser1.IsRedoEnabled
            mnuEditUndo.Enabled = AxWebBrowser1.IsUndoEnabled
            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Undo", tbBand.Standard)).Enabled = AxWebBrowser1.IsUndoEnabled
            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Redo", tbBand.Standard)).Enabled = AxWebBrowser1.IsRedoEnabled

            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Cut", tbBand.Standard)).Enabled = AxWebBrowser1.IsCutEnabled
            mnuEditCut.Enabled = AxWebBrowser1.IsCopyEnabled

            mnuEditDelete.Enabled = mnuEditCut.Enabled 

            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Copy", tbBand.Standard)).Enabled = AxWebBrowser1.IsCopyEnabled
            mnuEditCopy.Enabled = AxWebBrowser1.IsCopyEnabled
            
            tbCoolbar.Bands(tbBand.Standard).Buttons.Item(GetBtnIdx("Paste", tbBand.Standard)).Enabled = AxWebBrowser1.IsPasteEnabled
            mnuEditPaste.Enabled = AxWebBrowser1.IsPasteEnabled
            
            mnuEditFindReplace.Enabled = False 
            mnuFormatFont.Enabled = False 

            tbCoolbar.Bands(tbBand.Font).Enabled = False 
        End If
    End Sub
    Private Sub CheckBrowserSpelling(ByRef BrowserControl As WinOnly.WebOCHostCtrl)
        gstrMRPs = "0936"
        AddCrashComment("#PCBS1") 
        '---- spellchecker startup ----
        Dim lstrSpellDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Spelling\"

        Dim lstrDefaultDictionary As String = GetSetting( _
            "DictionaryFile", "", InitalXMLConfig.XmlConfigType.AppSettings, "")

        If System.IO.File.Exists(lstrSpellDir & lstrDefaultDictionary) = False Then
            'mxessagebox.show("No dictionary has been installed!, please goto the" & _
            '                "'Tools' menu and select 'Options', then 'Spelling'.", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_SpellingSetError"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
            AddCrashComment("#PCBS2") 

            Exit Sub
        End If
        Dim sp As New spellchecker(gbooAlwaysOnTop)
        With sp
            .Owner = Me
            '''.TextBox = RichTextBox1
            .Caption = NameMe("")
            .DictionaryFile = lstrSpellDir & lstrDefaultDictionary
            If System.IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "") = False Then
                System.IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "")
            End If
            .CustomDictionaryFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "\customdictionary.dic"
            '''.ShowDialog() 'show 
            .WaitForMore = True
            .TopMost = gbooAlwaysOnTop 
            .Show()
        End With
        '---- spellchecker startup ----
        AddCrashComment("#PCBS3") 

        Dim allDone As Boolean
        Do Until allDone = True
            Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
            Dim FormCol As IHTMLElementCollection = HtmlDoc.forms


            Dim iForms As Integer = FormCol.length
            Dim i As Integer
            Dim x As Integer
            For i = 0 To iForms - 1
                Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)

                For x = 0 To oForm.length - 1
                    Dim lstrThisFormField As String = Reverse(oForm.elements(x).name)
                    Select Case oForm.elements(x).type
                        Case "text", "textarea"
                            Dim OriginalValue As String = oForm.elements(x).value
                            If OriginalValue <> "" Then
                                'mxessagebox.show(OriginalValue, lstrThisFormField) '= lstrThisValue
                                Dim lbooWait As Boolean = False
                                txtFieldLine.Text = OriginalValue

                                sp.TextBox = txtFieldLine
                                sp.DoingCheck = True
                                Dim llngMaxOutTimer As Long = 99999 '99999
                                Do
                                    ' do nothing
                                    System.Windows.Forms.Application.DoEvents()
                                    lbooWait = sp.DoingCheck
                                    If llngMaxOutTimer <= 0 Then 
                                        Exit Do 
                                    End If
                                    llngMaxOutTimer -= 1 
                                Loop While lbooWait = False ' Or sp.DoingCheck = True
                                Do
                                    ' do nothing
                                    System.Windows.Forms.Application.DoEvents()
                                Loop Until sp.DoingCheck = False

                                lbooWait = False
                                oForm.elements(x).value = txtFieldLine.Text
                                'pass spellchecker this line
                                'issue re-start command
                                'OVERALL : need to build up corrected string before you commit back to the html field
                                'How can you hold the loop here?
                                'If you use showdialog, then the spell check issues close, won't it dissapear?
                            End If
                        Case Else
                    End Select
                    'End If
                    allDone = True
                Next
            Next i

            'unload spell checker
            AddCrashComment("#PCBS4") 
            System.Windows.Forms.Application.DoEvents()
            sp.WaitForMore = False ' end check
            'mxessagebox.show("Spell check completed OK!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_BrowserSpellOK"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

            sp.Close()
            Me.Focus() 
        Loop
        ClearCrashReport() 
    End Sub
    Private Sub mnuFile_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile.Popup

        If RichTextBox1.Visible = True Then
            mnuFileImportRTF.Enabled = True
            mnuFileImportTXT.Enabled = True 
        Else
            mnuFileImportRTF.Enabled = False
            mnuFileImportTXT.Enabled = False 
        End If

    End Sub
    Private Sub mnuTemplatesOrganise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplatesOrganise.Click
        AddDebugComment("frmPad.mnuTemplatesOrganise_Click") 
        'Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(frmResources.ilTreeIcons, lstrDBID)
        Dim lMaintBookMark As New RTFStand.GenBookMarkMaint(TreeView1.ImageList, lstrDBID) 

        With lMaintBookMark
            .Owner = Me
            .Caption = NameMe("") 
            .BookmarkType = GenBookMarkMaint.BookmarkTypes.TemplateBookMarks
            .HelpFile = GetHelpFile() 
            .HelpTopic = GetHelpTopic(HelpTopic.templatemenu) 
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        RefreshTemplatesMenu()
    End Sub
    Private Sub AxWebBrowser1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxWebBrowser1.Leave

        If lbooFx11FixDontLeaveNow = False Then 
            'If elEvts = True Then : Console.WriteLine("AxWebBrowser1_Leave") : End If 
            AddDebugComment("frmPad.AxWebBrowser1_Leave") 
            UpdateRTFToDB() 
        End If

    End Sub
    Private Sub RefreshItemTemplateMenu()
        AddDebugComment("frmPad.RefreshItemTemplateMenu") 

        Dim InitialTemplates As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
        Dim lintArrInc As Integer
        Dim lintArrIncMstr As Integer
        Dim lintMenuItemCounter As Integer
        Dim lbooItemsAdded As Boolean = False
        Dim lintMenuItemsCtr As Integer

        Dim evOnClick As New EventHandler(AddressOf TemplatesItemOnClick)
        Dim mnuItemTemplateAvails() As MenuItem
        mnuItemTemplate.MenuItems.Clear()


        'mnuTemplates.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTemplatesSelect, Me.mnuTemplatesOrganise, Me.mnuTemplateToRTF, Me.mnuTemplatesSep})

        With InitialTemplates
            'Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", 0))) 
            For lintArrInc = 0 To llngItemCount '10
                Dim lstrNewMenuItemText As String = .GetValue("Name" & lintArrInc, "")
                Dim lstrNewMenuImgIdx As String = .GetValue("ImgIdx" & lintArrInc, "")
                If lstrNewMenuItemText <> "" Then
                    lbooItemsAdded = True
                    ReDim Preserve mnuItemTemplateAvails(lintMenuItemsCtr)
                    mnuItemTemplateAvails(lintMenuItemsCtr) = New MenuItem()

                    AddHandler mnuItemTemplateAvails(lintMenuItemsCtr).Click, evOnClick

                    '----- 
                    'mnuItemTemplateAvails(lintMenuItemsCtr).Text = "&" & lintArrInc + 1 & " " & lstrNewMenuItemText
                    Dim llngIconIdx As Long
                    Try
                        llngIconIdx = CLng(lstrNewMenuImgIdx)
                    Catch
                        llngIconIdx = 0
                    End Try

                    'Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(llngIconIdx), Bitmap).GetHicon())
                    
                    'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                    'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                    Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(llngIconIdx)
                    ''Dim Ico As Icon = Icon.FromHandle(CType(frmResources.ilTreeIcons.Images.Item(lintImgIdx), Bitmap).GetHicon())
                    ''
                    '''mnuItemTemplateAvails(lintMenuItemsCtr) = New IconMenuItem("&" & lintArrInc + 1 & " " & lstrNewMenuItemText, Ico, evOnClick, Nothing)
                    ''
                    ''mnuItemTemplateAvails(lintMenuItemsCtr) = New IconMenuItem("&" & lintMenuItemsCtr + 1 & " " & lstrNewMenuItemText, Ico, evOnClick, Nothing)

                    mnuItemTemplateAvails(lintMenuItemsCtr) = New MenuItem("&" & lintMenuItemsCtr + 1 & " " & lstrNewMenuItemText, evOnClick, Nothing) 
                    Me.menuEnhancer.SetImageIndex(mnuItemTemplateAvails(lintMenuItemsCtr), lintImgIdx + 1000) 
                    
                    lintMenuItemsCtr += 1
                End If
            Next lintArrInc
            If lbooItemsAdded = True Then
                mnuItemTemplate.MenuItems.AddRange(mnuItemTemplateAvails)
                'mnuItemTemplate.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemTemplateAvail})
            Else
                Dim NoneMenuItem As New MenuItem() 
                'NoneMenuItem.Text = "none" 
                NoneMenuItem.Text = LangText.GetString("Pad_TemplateItemNone") 
                'None in german is "kein Eintrag"
                NoneMenuItem.Enabled = False 
                mnuItemTemplate.MenuItems.Add(NoneMenuItem) 
                Me.menuEnhancer.SetImageIndex(NoneMenuItem, -1) 
            End If
        End With

    End Sub
    Private Sub mnuItemTemplate_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemTemplate.Select
        RefreshItemTemplateMenu()
        'Console.WriteLine("RefreshItemTemplateMenu")
    End Sub
    Private Sub TemplatesItemOnClick(ByVal sender As Object, ByVal e As EventArgs)
        gstrMRPs = "0939"
        AddDebugComment("frmPad.TemplatesItemOnClick") 
        '---- Get Template File name / ID ----
        Dim lstrTemplateID As String 
        Dim lstrFileName As String
        Dim lbooDLL As Boolean = False
        miTemplate = CType(sender, MenuItem)

        GetSelectedTemplateFromMenu(miTemplate.Text, lstrTemplateID, lstrFileName, lbooDLL)

        If AddNewSubBranch(lstrTemplateID) = False Then
            Exit Sub 
        End If

        ShowBrowser()
        ShowForm(lstrFileName, AxWebBrowser1, lbooDLL)
        lcurDocumentView = DocumentViews.NormalTopic 

    End Sub
    Private Sub GetSelectedTemplateFromMenu(ByVal MenuText As String, ByRef TemplateID As String, ByRef TemplateFileName As String, ByRef booDll As Boolean)

        AddDebugComment("frmPad.GetSelectedTemplateFromMenu") 
        Dim lintArrInc As Integer
        Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
        'Dim lstrTopicCode As String
        With InitialBookmarks
            'Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", "0"))) 

            For lintArrInc = 0 To llngItemCount '10
                Dim lstrNewMenuItemText As String = .GetValue("Name" & lintArrInc, "")
                If lstrNewMenuItemText <> "" Then
                    Dim ThisMenuText As String = RightGet(MenuText, MenuText.Length - 3) '.Substring(1)
                    If ThisMenuText = lstrNewMenuItemText Then
                        'lstrTopicCode = .GetValue("Bookmarks-" & lintArrInc, "")
                        TemplateFileName = .GetValue("FileName" & lintArrInc, "")
                        TemplateID = .GetValue("ID" & lintArrInc, "") 
                        If InStrGet(TemplateFileName, "SYSTEM:") > 0 Then
                            TemplateFileName = Microsoft.VisualBasic.Replace(TemplateFileName, "SYSTEM:", "")
                            booDll = True
                            'ShowForm(lstrFileName, AxWebBrowser1, True)
                            'Else
                            '    lbooDLL = True
                            '    ShowForm(lstrFileName, AxWebBrowser1, False)
                            Exit For
                        End If
                    End If
                End If
            Next lintArrInc
        End With
        '---- Get Template File name / ID ----
    End Sub
    Private Sub AddToolbarButtons()


        '####################### NEW COOLBAR ### ABOVE WILL SOON BE DELETED ################

        
        tbCoolbar.DontDrawShadow = False
        tbCoolbar.DrawBottomLine = False 

        Dim BlankButton As New ToolBarButton()
        BlankButton.Enabled = False

        'tbCoolbar.BackgroundImage = New Bitmap("c:\windows\Greenstone.bmp")
        'tbCoolbar.BackgroundImage = New Bitmap("Greenstone.bmp")

        Dim Res As New IPIconsPack.Resource()
        'Dim Res256 As New IPIconsPack.Resources256() 
        
        'Dim cd As New GetColorDepth()
        'Select Case cd.ScreenColors
        '    Case 8 '256
        'If IsWin98orME() = True Then
        'tbCoolbar.SetImageListForBand(tbBand.Standard, Res256.ilToolButtons256)
        'tbCoolbar.SetImageListForBand(tbBand.Branch, Res256.ilToolButtons256)
        'tbCoolbar.SetImageListForBand(tbBand.Font, Res256.ilToolButtons256)
        'tbCoolbar.SetImageListForBand(tbBand.Search, Res256.ilToolButtons256)
        tbCoolbar.SetImageListForBand(tbBand.Standard, Res.ilToolButtons256)
        tbCoolbar.SetImageListForBand(tbBand.Branch, Res.ilToolButtons256)
        tbCoolbar.SetImageListForBand(tbBand.Font, Res.ilToolButtons256)
        tbCoolbar.SetImageListForBand(tbBand.Search, Res.ilToolButtons256)
        'Else
        '    '       Case Else
        '    
        '    tbCoolbar.SetImageListForBand(tbBand.Standard, Res.ilToolButtons)
        '    tbCoolbar.SetImageListForBand(tbBand.Branch, Res.ilToolButtons)
        '    tbCoolbar.SetImageListForBand(tbBand.Font, Res.ilToolButtons)
        '    'tbCoolbar.SetImageListForBand(tbBand.Search, Res.ilSearch)
        '    tbCoolbar.SetImageListForBand(tbBand.Search, Res.ilToolButtons)
        'End If
        'End Select

        ''tbCoolbar.Band1Image = Res.picBand1.Image
        ''tbCoolbar.Band2Image = Res.picBand2.Image
        ''tbCoolbar.Band3Image = Res.picBand3.Image

        tbCoolbar.Bands(tbBand.Standard).Name = "Standard"
        tbCoolbar.Bands(tbBand.Standard).Tag = LangText.GetString("Pad_mnuViewToolbar1").Replace("&", "") 

        'tbCoolbar.Bands(tbBand.Standard).Width = 315 '580
        'tbCoolbar.Bands(tbBand.Standard).Width = 315 + (8 * 12) 
        tbCoolbar.Bands(tbBand.Standard).Width = GetToolbarWidth(tbBand.Standard) 

        mnuViewToolbar1.Text = tbCoolbar.Bands(tbBand.Standard).Tag 

        tbCoolbar.Bands(tbBand.Standard).InitialLocation = GetToolbarIntialLocation(tbBand.Standard) 
        tbCoolbar.Bands(tbBand.Branch).InitialLocation = GetToolbarIntialLocation(tbBand.Branch) 
        tbCoolbar.Bands(tbBand.Font).InitialLocation = GetToolbarIntialLocation(tbBand.Font) 
        tbCoolbar.Bands(tbBand.Search).InitialLocation = GetToolbarIntialLocation(tbBand.Search) 

        tbCoolbar.Bands(tbBand.Branch).Visible = False

        With tbCoolbar.Bands(tbBand.Standard).Buttons
            .AddRange(New ToolBarButton() { _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipPrintPage"), IconIdent.Print, "Print"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipNewRoot"), IconIdent.NewRoot, "New Root"), _
            CreateButton(LangText.GetString("Pad_TlbrTipNewSub"), IconIdent.NewSubBranch, "New Sub Branch"), _
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
            CreateButton(LangText.GetString("Pad_TlbrTipInsertTable"), IconIdent.InsertTable, "Insert Table"), _
            CreateButton(LangText.GetString("Pad_TlbrTipPageColor"), IconIdent.PageColour, "Page Colour"), _
            CreateButton(LangText.GetString("Pad_TlbrTipRapidEntry"), IconIdent.RapidEntry, "Rapid Entry") _
            })
            'added Pad_TlbrTipPageColor 
            'added Pad_TlbrTipInsertTable 
        End With

        'tbCoolbar.Bands(tbBand.Branch).Width = 185 '100
        'tbCoolbar.Bands(tbBand.Branch).Width = 185 + (8 * 7)  
        tbCoolbar.Bands(tbBand.Branch).Width = GetToolbarWidth(tbBand.Branch) 

        tbCoolbar.Bands(tbBand.Branch).Name = "Tree"
        tbCoolbar.Bands(tbBand.Branch).Tag = LangText.GetString("Pad_mnuViewToolbar2").Replace("&", "") 

        mnuViewToolbar2.Text = tbCoolbar.Bands(tbBand.Branch).Tag 

        With tbCoolbar.Bands(tbBand.Branch).Buttons
            .AddRange(New ToolBarButton() { _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrTipBranchProps"), IconIdent.BranchProps, "Branch Properties"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_TlbrExtraTipMoveBranchUp").Replace("&", ""), IconIdent.MoveBranchUp, "Move Up"), _
            CreateButton(LangText.GetString("Pad_TlbrExtraTipMoveBranchDown").Replace("&", ""), IconIdent.MoveBranchDown, "Move Down"), _
            CreateButton(LangText.GetString("Pad_TlbrExtraTipMoveBranchTop").Replace("&", ""), IconIdent.MoveBranchTop, "Move Top"), _
            CreateButton(LangText.GetString("Pad_TlbrExtraTipMoveBranchBottom").Replace("&", ""), IconIdent.MoveBranchBottom, "Move Bottom"), _
            CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
            CreateButton(LangText.GetString("Pad_mnuToolsExpandAll"), IconIdent.TreeExpand, "Expand"), _
            CreateButton(LangText.GetString("Pad_mnuToolsCollapseAll"), IconIdent.TreeCollapse, "Collapse") _
            })
            'added Pad_mnuToolsExpandAll & Pad_mnuToolsCollapseAll 
        End With

        tbCoolbar.Bands(tbBand.Font).Name = "Fonts"
        tbCoolbar.Bands(tbBand.Font).Tag = LangText.GetString("Pad_mnuViewToolbar3").Replace("&", "") 

        mnuViewToolbar3.Text = tbCoolbar.Bands(tbBand.Font).Tag 

        With tbCoolbar.Bands(tbBand.Font)

            'Create space for combo boxes
            .Buttons.AddRange(New ToolBarButton() {CreateButton("", -1, "", ToolBarButtonStyle.Separator)})

            Dim lintArrInc As Integer
            For lintArrInc = 0 To GetToolbarNumOfFontComboSpacers() - 1
                .Buttons.AddRange(New ToolBarButton() {BlankButton})
            Next lintArrInc

            .Buttons.AddRange(New ToolBarButton() {CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
                CreateButton(LangText.GetString("Pad_TlbrTipFontBold"), IconIdent.FontBold, "Font Bold"), _
                CreateButton(LangText.GetString("Pad_TlbrTipFontItalics"), IconIdent.FontItalics, "Font Italics"), _
                CreateButton(LangText.GetString("Pad_TlbrTipFontUnderlined"), IconIdent.FontUnderline, "Font Underlined"), _
                CreateButton(LangText.GetString("Pad_TlbrTipFontColour"), IconIdent.FontColour, "Font Colour"), _
                CreateButton(LangText.GetString("Pad_TlbrTipHighlight"), Res.ilToolButtons256.Images.Count - 1, "Highlight", ToolBarButtonStyle.DropDownButton, ctmHighlight), _
                CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
                CreateButton(LangText.GetString("Pad_TlbrTipAlignLeft"), IconIdent.AlignLeft, "Align Left"), _
                CreateButton(LangText.GetString("Pad_TlbrTipAlignCentre"), IconIdent.AlignCentre, "Align Centre"), _
                CreateButton(LangText.GetString("Pad_TlbrTipAlignRight"), IconIdent.AlignRight, "Align Right"), _
                CreateButton("", -1, "", ToolBarButtonStyle.Separator), _
                CreateButton(LangText.GetString("Pad_TlbrTipFontStyle"), IconIdent.FontSytle, "Font style"), _
                CreateButton(LangText.GetString("Pad_TlbrTipBullets"), IconIdent.Bullets, "Bullets"), _
                CreateButton(LangText.GetString("Pad_TlbrTipWordWrap"), IconIdent.WordWrap, "Word Wrap")})


            ''cboFontName = New ComboBox()
            .Controls.Add(cboFontName)
            ''cboFontSize = New ComboBox()
            .Controls.Add(cboFontSize)

            cboFontName.Top = GetToolbarComboTop() '1
            cboFontName.Left = 10
            cboFontName.Width = GetToolbarFontStyleComboWidth() '195 '200
            cboFontName.DropDownStyle = ComboBoxStyle.DropDownList

            cboFontSize.Top = GetToolbarComboTop() ' 1
            'cboFontSize.Left = 215 '220
            cboFontSize.Left = cboFontName.Left + cboFontName.Width + 10 
            cboFontSize.Width = GetToolbarFontSizeComboWidth() '50
            cboFontSize.DropDownStyle = ComboBoxStyle.DropDownList

        End With

        'tbCoolbar.Bands(tbBand.Font).Width = 540 ' 273
        'tbCoolbar.Bands(tbBand.Font).Width = 540 + (8 * 21) 
        tbCoolbar.Bands(tbBand.Font).Width = GetToolbarWidth(tbBand.Font) 

        '----
        tbCoolbar.Bands(tbBand.Search).Name = "Search"
        tbCoolbar.Bands(tbBand.Search).Tag = LangText.GetString("Pad_mnuViewToolbar4").Replace("&", "") 

        mnuViewToolbar4.Text = tbCoolbar.Bands(tbBand.Search).Tag 

        With tbCoolbar.Bands(tbBand.Search)
            'Dim BlankButton As New ToolBarButton()
            'BlankButton.Enabled = False
            'Create space for combo boxes
            '.Buttons.AddRange(New ToolBarButton() { _
            '    CreateButton("", -1, "", ToolBarButtonStyle.Separator), BlankButton, BlankButton, BlankButton, BlankButton, _
            '    CreateButton("Search", 0, "Search")})

            .Buttons.AddRange(New ToolBarButton() {CreateButton("", -1, "", ToolBarButtonStyle.Separator)})

            Dim lintArrInc As Integer
            For lintArrInc = 0 To GetToolbarNumOfSearchComboSpacers() - 1
                .Buttons.AddRange(New ToolBarButton() {BlankButton})
            Next lintArrInc

            'Dim ButtonSearch As New ToolBarButton()
            'ButtonSearch.Tag = "Search"
            'ButtonSearch.ImageIndex = IconIdent.Search
            'ButtonSearch.ToolTipText = "Search"
            'ButtonSearch.Text = "&Search"

            '.Buttons.AddRange(New ToolBarButton() {CreateButton("Search", IconIdent.Search, "Search")})
            
            .Buttons.AddRange(New ToolBarButton() {CreateButton(LangText.GetString("Pad_mnuViewToolbar4").Replace("&", ""), IconIdent.Search, "Search")})

            'Dim cboSearchTool As New ComboBox()
            .Controls.Add(cboSearchTool)

            cboSearchTool.Top = GetToolbarComboTop() '1
            cboSearchTool.Left = 10 '60 '70
            cboSearchTool.Width = GetToolbarSearchTextComboWidth() '160

        End With

        'tbCoolbar.Bands(tbBand.Search).Width = 230 '350
        'tbCoolbar.Bands(tbBand.Search).Width = 230 + (8 * 5) 
        tbCoolbar.Bands(tbBand.Search).Width = GetToolbarWidth(tbBand.Search) 

        'mnuViewToolbarReset.Text = "&Reset Positions"

        '----
        tbCoolbar.BandHeight = tbCoolbar.Bands(tbBand.Standard).Height + 3

    End Sub
    Private Sub mnuItemSetAsStartup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemSetAsStartup.Click
        SaveSetting("Show Startup Page", "FALSE", InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("Startup Topic", TreeView1.SelectedNode.Tag, InitalXMLConfig.XmlConfigType.AppSettings, "") 
        'mxessagebox.show("The default startup topic has been changed!", NameMe("")) 
        MessageBox.Show(LangText.GetString("Pad_DefaultTopicChanged"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 

    End Sub
    Private Sub SendPageAsEmail()
        Try
            'AxWebBrowser1.HtmlDocument.write("fff")
            Dim doc As mshtml.HTMLDocument = CType(AxWebBrowser1.HtmlDocument, mshtml.HTMLDocument)
            'Dim file As System.IO.StreamWriter = System.IO.File.CreateText(dlg.FileName)
            'file.Write(doc.body.innerHTML)
            'file.Close()
            MessageBox.Show(doc.body.innerHTML)


        Catch
        End Try

    End Sub
    Private Sub mnuHelpTopics_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpTopics.Click
        Help.ShowHelp(Me, GetHelpFile, HelpNavigator.TableOfContents) 
        'Dim x As Integer
        'x = 1
        'x = x / 0

    End Sub
    'Private Sub mnuEditFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    mnuRTFFont_Click(Nothing, Nothing) 
    '    deleteme()
    'End Sub
    Private Sub mnuFileExportRTF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExportRTF.Click

        AddDebugComment("frmPad.mnuFileExportRTF_Click") 
        AddCrashComment("#PMFERTC1") 
        UpdateRTFToDB() 

        Application.DoEvents() 

        Dim SelectiveExport As New SelectivePrint() 
        SelectiveExport.FileTypeStreamType = SelectivePrint.SelectiveOutputType.RichText 
        SelectiveExport.OutputType = SelectivePrint.OutputTypes.Export 
        SelectiveExport.Disables = main.PopulateTreeDisables.DisableTemplateTopics 
        SelectiveExport.Owner = Me 
        SelectiveExport.TopMost = gbooAlwaysOnTop 
        SelectiveExport.ShowDialog() 
        ClearCrashReport() 
    End Sub
    Private Sub mnuFileExportTempNRtfData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExportTempNRtfData.Click
        'added 
        AddDebugComment("frmPad.mnuFileExportTempNRtfData_Clickk")

        UpdateRTFToDB()

        Application.DoEvents()

        Dim SelectiveExport As New SelectivePrint()
        SelectiveExport.FileTypeStreamType = SelectivePrint.SelectiveOutputType.XML 
        SelectiveExport.OutputType = SelectivePrint.OutputTypes.Export
        SelectiveExport.Owner = Me
        SelectiveExport.TopMost = gbooAlwaysOnTop 
        SelectiveExport.ShowDialog()
        ClearCrashReport() 
    End Sub
    Private Sub mnuTemplatesRapidEntry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplatesRapidEntry.Click

        DoRapidEntry("") 

    End Sub
    Private Sub DoRapidEntry(ByVal pstrTemplateID As String) 

        gstrMRPs = "0943"
        AddDebugComment("frmPad.DoRapidEntry - " & pstrTemplateID) 
        AddCrashComment("#PDRE1") 
        Dim lstrParentCode As String = ""
        Dim lstrInsertLevel As Integer = 1
        Dim KeptCurrentNode As String 

        If Not TreeView1.SelectedNode Is Nothing Then 'sub branches
            lstrInsertLevel = NodateLevel(TreeView1.SelectedNode) + 1
            'lstrParentCode = ReturnTrueTopicStr(TreeView1.SelectedNode.Tag)
            lstrParentCode = TreeView1.SelectedNode.Tag 
            lstrCurTopicCode = TreeView1.SelectedNode.Tag 
            KeptCurrentNode = lstrCurTopicCode
        End If

        If pstrTemplateID = "" Then 'use default
            pstrTemplateID = GetDefaultTemplateID()
        End If
        AddCrashComment("#PDRE2") 
        
        If pstrTemplateID = "" Then
            'mxessagebox.show("Rapid Entry must have a Default template, please specify one, goto the" & _
            '    "'Tools' menu and select 'Options', then 'Templates'." & Environment.NewLine & Environment.NewLine & _
            '    "Alternatively select a template from the 'Template' menu, then select 'Rapid Entry'.", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Pad_RapidEntySetWarn").Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
            AddCrashComment("#PDRE3") 
            Exit Sub
        End If
        

        Application.DoEvents() 
        AddCrashComment("#PDRE4") 
        Dim RE As New RapidEntry()
        With RE
            .ParentCode = lstrParentCode
            .InsertLevel = lstrInsertLevel
            .TemplateID = pstrTemplateID
            .Owner = Me 
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()
        End With
        AddCrashComment("#PDRE5") 

        mnuToolsRefresh_Click(Nothing, Nothing)

        If lstrCurTopicCode = "" Then
            SelectNodeByTag(lstrCurTopicCode, TreeView1, lcurDocumentView)
        Else
            SelectNodeByTag(KeptCurrentNode, TreeView1, lcurDocumentView)
        End If

        ClearCrashReport() 

    End Sub
    Private Sub mnuHelpSubscribe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpSubscribe.Click

        AddDebugComment("frmPad.mnuHelpSubscribe_Click") 

        Dim nl As New Newsletter()
        nl.FromMenu = True
        nl.TopMost = gbooAlwaysOnTop 
        nl.ShowDialog()
        

    End Sub
    Private Sub mnuHelpEnterCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpEnterCode.Click

        Application.DoEvents() 

        AddDebugComment("frmPad.mnuHelpEnterCode_Click") 
        'AcceptLicense(Me) 
        'Me.Text = NameMe("") 

        If AcceptLicense(Me) = True Then 
            Me.Text = NameMe("") 
            StandardUpgradeTidy() 
        End If

    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

        'If elEvtsRTB = True Then : Console.WriteLine("RichTextBox1_TextChanged") : End If
        AddDebugComment("frmPad.RichTextBox1_TextChanged") 

        lbooRTFContentsChanged = True 

    End Sub
    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

    '    If m.Msg = WM_SHOWWINDOW Then
    '        If Not m_loaded Then
    '            MyBase.OnLoad(New System.EventArgs())
    '        End If
    '    ElseIf m.Msg = SC_MAXIMIZE Then
    '        Console.WriteLine("WndProc Max")
    '        xx()
    '    End If
    '    MyBase.WndProc(m)
    'End Sub
    Private Sub frmPad_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        Me.Invalidate() 

        If Me.WindowState = FormWindowState.Maximized And m_loaded = False Then
            Me.WindowState = FormWindowState.Normal
            MyBase.OnLoad(New System.EventArgs())
        End If

    End Sub
    Private Sub mnuTemplateTextSizeLarger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplateTextSizeLarger.Click
        AxWebBrowser1.IncreaseFontSize() 
    End Sub
    Private Sub mnuTemplateTextSizeSmaller_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTemplateTextSizeSmaller.Click
        AxWebBrowser1.DecreaseFontSize() 
    End Sub
    Private Sub mnuRTFInsertGrpahics_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFInsertGrpahics.Click
        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        
        mnuInsertGraphics_Click(Nothing, Nothing)

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub

    Private Sub mnuRTFBullets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFBullets.Click
        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuInsertBullets_Click(Nothing, Nothing) 

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub SetMenusText() 

        AddDebugComment("frmPad.SetMenusText") 


        Me.mnuRTFUndo.Text = LangText.GetString("Pad_mnuRTFUndo")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFUndo, IconIdent.Undo) 

        Me.mnuRTFRedo.Text = LangText.GetString("Pad_mnuEditRedo") 
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFRedo, IconIdent.Redo) 

        Me.MenuItem2.Text = "-"
        Me.mnuRTFCut.Text = LangText.GetString("Pad_mnuRTFCut")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFCut, IconIdent.Cut) 
        Me.mnuRTFCopy.Text = LangText.GetString("Pad_mnuRTFCopy")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFCopy, IconIdent.Copy) 
        Me.mnuRTFPaste.Text = LangText.GetString("Pad_mnuRTFPaste")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFPaste, IconIdent.Paste) 
        Me.mnuRTFDelete.Text = LangText.GetString("Pad_mnuRTFDelete")
        Me.MenuItem12.Text = "-"
        Me.mnuRTFFont.Text = LangText.GetString("Pad_mnuRTFFont")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFFont, IconIdent.FontSytle) 
        Me.mnuRTFBullets.Text = LangText.GetString("Pad_mnuRTFBullets")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFBullets, IconIdent.Bullets) 

        Me.mnuRTFImportRTF.Text = LangText.GetString("Pad_mnuRTFImportRTF")
        Me.mnuRTFInsertGrpahics.Text = LangText.GetString("Pad_mnuRTFInsertGrpahics")
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFInsertGrpahics, IconIdent.InsertGraphics) 

        
        Me.mnuRTFEditTable.Text = "" 'this is populated in popup event 
        Me.menuEnhancer.SetImageIndex(Me.mnuRTFEditTable, IconIdent.InsertTable)
        

        Me.mnuRTFSelectAll.Text = LangText.GetString("Pad_mnuRTFSelectAll")

        Me.mnuItemAdd.Text = LangText.GetString("Pad_mnuItemAdd")
        Me.menuEnhancer.SetImageIndex(Me.mnuItemAdd, IconIdent.NewSubBranch) 

        Me.mnuItemTemplate.Text = LangText.GetString("Pad_mnuItemTemplate")
        Me.mnuItemRename.Text = LangText.GetString("Pad_mnuItemRename")
        Me.mnuItemDelete.Text = LangText.GetString("Pad_mnuItemDelete")
        Me.mnuItemDeleteBranches.Text = LangText.GetString("Pad_mnuItemDeleteBranches")

        Me.mnuItemMoveToRoot.Text = LangText.GetString("Pad_mnuItemMoveToRoot") 

        Me.mnuItemMoveBranchUp.Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchUp") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchUp, IconIdent.MoveBranchUp) 
        Me.mnuItemMoveBranchDown.Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchDown") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchDown, IconIdent.MoveBranchDown) 

        Me.mnuItemMoveBranchTop.Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchTop") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchTop, IconIdent.MoveBranchTop) 
        Me.mnuItemMoveBranchBottom.Text = LangText.GetString("Pad_TlbrExtraTipMoveBranchBottom") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemMoveBranchBottom, IconIdent.MoveBranchBottom) 


        Me.mnuItemExpandAll.Text = LangText.GetString("Pad_mnuToolsExpandAll") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemExpandAll, IconIdent.TreeExpand) 
        Me.mnuItemCollapseAll.Text = LangText.GetString("Pad_mnuToolsCollapseAll") 
        Me.menuEnhancer.SetImageIndex(Me.mnuItemCollapseAll, IconIdent.TreeCollapse) 

        Me.MenuItem10.Text = "-"
        Me.mnuItemAddBookmark.Text = LangText.GetString("Pad_mnuItemAddBookmark")
        Me.mnuItemSetAsStartup.Text = LangText.GetString("Pad_mnuItemSetAsStartup")
        Me.MenuItem18.Text = "-"
        Me.mnuItemProperties.Text = LangText.GetString("Pad_mnuItemProperties")
        Me.menuEnhancer.SetImageIndex(Me.mnuItemProperties, IconIdent.BranchProps) 

        Me.mnuFile.Text = LangText.GetString("Pad_mnuFile")
        Me.mnuFileNewRoot.Text = LangText.GetString("Pad_mnuFileNewRoot")
        Me.menuEnhancer.SetImageIndex(Me.mnuFileNewRoot, IconIdent.NewRoot) 
        Me.mnuFileNewBranch.Text = LangText.GetString("Pad_mnuFileNewBranch")
        Me.menuEnhancer.SetImageIndex(Me.mnuFileNewBranch, IconIdent.NewSubBranch) 
        Me.MenuItem5.Text = "-"

        Me.mnuFileImport.Text = LangText.GetString("Pad_mnuFileImport")

        Me.mnuFileImportRTF.Text = StandLangText.GetString("StandText_RTFCaption") 
        Me.mnuFileImportTXT.Text = StandLangText.GetString("StandText_TXTCaption") 
        Me.mnuFileImportWizard.Text = LangText.GetString("Pad_mnuFileImportWizard")

        Me.mnuFileExport.Text = LangText.GetString("Pad_mnuFileExport")

        Me.mnuFileExportTempData.Text = LangText.GetString("Pad_mnuFileExportTempData")
        Me.mnuFileExportTempDataXML.Text = LangText.GetString("Pad_mnuFileExportTempData").Replace("&", "").Replace("*.txt", "*.x&ml") 

        'Me.mnuFileExportTempNRtfData.Text = LangText.GetString("Pad_mnuFileExportTempData").Replace("&", "").Replace(" (*.txt)", " / RTF (*.x&ml)") 
        Me.mnuFileExportTempNRtfData.Text = "&Outliner (*.xml)" 

        Me.mnuFileExportRTF.Text = StandLangText.GetString("StandText_RTFCaption") 
        Me.mnuFileExportTXT.Text = StandLangText.GetString("StandText_TXTCaption") 
        Me.mnuFileExportWizard.Text = LangText.GetString("Pad_mnuFileExportWizard")

        Me.MenuItem16.Text = "-"
        Me.mnuFilePageSetup.Text = LangText.GetString("Pad_mnuFilePageSetup")
        Me.mnuFilePrint.Text = LangText.GetString("Pad_mnuFilePrint")
        Me.menuEnhancer.SetImageIndex(Me.mnuFilePrint, IconIdent.Print) 
        Me.mnuFileSelectivePrint.Text = LangText.GetString("Pad_mnuFileSelectivePrint")
        Me.MenuItem3.Text = "-"
        Me.mnuFileExit.Text = LangText.GetString("Pad_mnuFileExit")

        Me.mnuEdit.Text = LangText.GetString("Pad_mnuEdit")
        Me.mnuEditUndo.Text = LangText.GetString("Pad_mnuEditUndo")
        Me.menuEnhancer.SetImageIndex(Me.mnuEditUndo, IconIdent.Undo) 
        Me.mnuEditRedo.Text = LangText.GetString("Pad_mnuEditRedo")
        Me.menuEnhancer.SetImageIndex(Me.mnuEditRedo, IconIdent.Redo) 
        Me.MenuItem4.Text = "-"
        Me.mnuEditCut.Text = LangText.GetString("Pad_mnuEditCut")
        Me.menuEnhancer.SetImageIndex(Me.mnuEditCut, IconIdent.Cut) 
        Me.mnuEditCopy.Text = LangText.GetString("Pad_mnuEditCopy")
        Me.menuEnhancer.SetImageIndex(Me.mnuEditCopy, IconIdent.Copy) 
        Me.mnuEditPaste.Text = LangText.GetString("Pad_mnuEditPaste")
        Me.menuEnhancer.SetImageIndex(Me.mnuEditPaste, IconIdent.Paste) 
        Me.MenuItem8.Text = "-"
        Me.mnuEditSelectAll.Text = LangText.GetString("Pad_mnuEditSelectAll")
        Me.MenuItem15.Text = "-"
        Me.mnuEditFindReplace.Text = LangText.GetString("Pad_mnuEditFindReplace")
        Me.mnuEditFindTopic.Text = LangText.GetString("Pad_mnuEditFindTopic")
        Me.mnuEditFindTemplateTopic.Text = LangText.GetString("Pad_mnuEditFindTemplateTopic")
        'Me.MenuItem20.Text = "-"
        'Me.mnuEditFont.Text = LangText.GetString("Pad_mnuEditFont")
        'Me.mnuEditBullets.Text = LangText.GetString("Pad_mnuEditBullets")
        'Me.mnuEditGraphics.Text = LangText.GetString("Pad_mnuEditGraphics")
        'Me.mnuEditWordWrap.Text = "&" & LangText.GetString("Pad_TlbrTipWordWrap") 
        Me.mnuEditDelete.Text = LangText.GetString("Pad_mnuRTFDelete") 
        'Me.mnuEditFontToolbar.Text = LangText.GetString("Pad_mnuEditExtraToolbar") 

        'view menu
        Me.mnuView.Text = LangText.GetString("Pad_mnuView")
        Me.mnuViewToolbars.Text = LangText.GetString("Pad_mnuViewToolbars")
        Me.mnuViewToolbar1.Text = LangText.GetString("Pad_mnuViewToolbar1")
        Me.mnuViewToolbar2.Text = LangText.GetString("Pad_mnuViewToolbar2")
        Me.mnuViewToolbar3.Text = LangText.GetString("Pad_mnuViewToolbar3")
        Me.mnuViewToolbar4.Text = LangText.GetString("Pad_mnuViewToolbar4")
        Me.mnuViewToolbarReset.Text = LangText.GetString("mnuViewToolbarReset")
        Me.mnuViewWordWrap.Text = LangText.GetString("Pad_mnuViewWordWrap")
        Me.menuEnhancer.SetImageIndex(Me.mnuViewWordWrap, IconIdent.WordWrap) 
        Me.mnuViewAlwaysOnTop.Text = LangText.GetString("Pad_mnuViewAlwaysOnTop")

        'insert menu
        Me.mnuInsert.Text = LangText.GetString("Pad_mnuInsert")
        Me.mnuInsertDateTime.Text = LangText.GetString("Pad_mnuInsertDateTime")
        Me.mnuInsertSymbol.Text = LangText.GetString("Pad_mnuInsertSymbol")
        Me.mnuInsertBullets.Text = LangText.GetString("Pad_mnuInsertBullets")
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertBullets, IconIdent.Bullets) 
        Me.mnuInsertGraphics.Text = LangText.GetString("Pad_mnuInsertGraphics")
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertGraphics, IconIdent.InsertGraphics) 

        
        Me.mnuInsertTable.Text = LangText.GetString("Pad_mnuInsertTable")
        Me.menuEnhancer.SetImageIndex(Me.mnuInsertTable, IconIdent.InsertTable)
        

        Me.mnuInsertLinkToFile.Text = LangText.GetString("Pad_mnuInsertLinkToFile")
        Me.mnuInsertHyperlink.Text = LangText.GetString("Pad_mnuInsertHyperlink")
        Me.mnuInsertQuickLink.Text = LangText.GetString("Pad_mnuInsertQuickLink")

        'format menu
        Me.mnuFormat.Text = LangText.GetString("Pad_mnuFormat")
        Me.mnuFormatFont.Text = LangText.GetString("Pad_mnuFormatFont")
        Me.mnuFormatBackground.Text = LangText.GetString("Pad_mnuFormatBackground")
        Me.menuEnhancer.SetImageIndex(Me.mnuFormatBackground, IconIdent.PageColour) 
        Me.mnuFormatChangeCase.Text = LangText.GetString("Pad_mnuFormatChangeCase")
        Me.mnuFormatChangeCaseUpper.Text = LangText.GetString("Pad_mnuFormatChangeCaseUpper")
        Me.mnuFormatChangeCaseLower.Text = LangText.GetString("Pad_mnuFormatChangeCaseLower")
        Me.mnuFormatChangeCaseProper.Text = LangText.GetString("Pad_mnuFormatChangeCaseProper")
        Me.mnuFormatChangeCaseToggle.Text = LangText.GetString("Pad_mnuFormatChangeCaseToggle")

        Me.mnuBookmarks.Text = LangText.GetString("Pad_mnuBookmarks")

        Me.mnuTemplates.Text = LangText.GetString("Pad_mnuTemplates")
        Me.mnuTemplatesSelect.Text = LangText.GetString("Pad_mnuTemplatesSelect")
        Me.mnuTemplatesOrganise.Text = LangText.GetString("Pad_mnuTemplatesOrganise")
        Me.mnuTemplatesRapidEntry.Text = LangText.GetString("Pad_mnuTemplatesRapidEntry")
        Me.menuEnhancer.SetImageIndex(Me.mnuTemplatesRapidEntry, IconIdent.RapidEntry) 
        Me.mnuTemplateToRTF.Text = LangText.GetString("Pad_mnuTemplateToRTF")
        Me.mnuTemplateTextSize.Text = LangText.GetString("Pad_mnuTemplateTextSize")
        Me.mnuTemplateTextSizeLarger.Text = LangText.GetString("Pad_mnuTemplateTextSizeLarger")
        Me.mnuTemplateTextSizeSmaller.Text = LangText.GetString("Pad_mnuTemplateTextSizeSmaller")
        Me.mnuTemplatesSep.Text = "-"

        Me.mnuTools.Text = LangText.GetString("Pad_mnuTools")
        Me.mnuToolsSpelling.Text = LangText.GetString("Pad_mnuToolsSpelling")
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsSpelling, IconIdent.Spelling) 
        Me.MenuItem17.Text = "-"
        Me.mnuToolsRefresh.Text = LangText.GetString("Pad_mnuToolsRefresh")
        Me.mnuToolsExpandAll.Text = LangText.GetString("Pad_mnuToolsExpandAll")
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsExpandAll, IconIdent.TreeExpand) 
        Me.mnuToolsCollapseAll.Text = LangText.GetString("Pad_mnuToolsCollapseAll")
        Me.menuEnhancer.SetImageIndex(Me.mnuToolsCollapseAll, IconIdent.TreeCollapse) 
        Me.MenuItem13.Text = "-"
        Me.mnuToolsOptions.Text = LangText.GetString("Pad_mnuToolsOptions")

        Me.mnuHelp.Text = LangText.GetString("Pad_mnuHelp")
        Me.mnuHelpTopics.Text = LangText.GetString("Pad_mnuHelpTopics")
        Me.mnuHelpGettingStarted.Text = LangText.GetString("Pad_mnuHelpGettingStarted")
        Me.MenuItem1.Text = "-"
        Me.mnuHelpStartup.Text = LangText.GetString("Pad_mnuHelpStartup")
        Me.mnuHelpCFU.Text = LangText.GetString("Pad_mnuHelpCFU")
        Me.mnuHelpSupport.Text = LangText.GetString("Pad_mnuHelpSupport")

        
        Dim PLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("ProbHand.ProbHand", _
            System.Reflection.Assembly.Load("ProbHand"))
        Me.mnuHelpReportProblem.Text = PLangText.GetString("BugRep_ReportProblem")
        

        Me.MenuItem9.Text = "-"
        Me.mnuHelpBuy.Text = LangText.GetString("Pad_mnuHelpBuy").Replace("[Program]", gProgName)
        Me.mnuHelpTipDay.Text = LangText.GetString("Pad_mnuHelpTipDay")
        Me.mnuHelpSubscribe.Text = LangText.GetString("Pad_mnuHelpSubscribe")
        Me.mnuHelpEnterCode.Text = LangText.GetString("Pad_mnuHelpEnterCode")
        Me.MenuItem6.Text = "-"
        Me.mnuHelpLicense.Text = LangText.GetString("Pad_mnuHelpLicense")
        Me.mnuHelpAbout.Text = LangText.GetString("Pad_mnuHelpAbout")

        Me.mnuBookmarksAdd.Text = LangText.GetString("Pad_mnuBookmarksAdd")
        Me.mnuBookmarksRemove.Text = LangText.GetString("Pad_mnuBookmarksRemove")
        Me.MenuItem19.Text = "-"

        Me.ctmNDCopyHere.Text = LangText.GetString("Pad_ctmNDCopyHere") 'not is use
        Me.ctmNDMoveHere.Text = LangText.GetString("Pad_ctmNDMoveHere")
        Me.ctmNDLinkHere.Text = LangText.GetString("Pad_ctmNDLinkHere") 'not is use
        Me.MenuItem11.Text = "-"
        Me.ctmNDCopyBranchHere.Text = LangText.GetString("Pad_ctmNDCopyBranchHere")
        Me.ctmNDMoveBranchHere.Text = LangText.GetString("Pad_ctmNDMoveBranchHere")
        Me.ctmNDLinkBranchHere.Text = LangText.GetString("Pad_ctmNDLinkBranchHere")
        Me.MenuItem7.Text = "-"
        Me.ctmNDCancel.Text = LangText.GetString("Pad_ctmNDCancel")

        Me.ContextMenuHTMLView.Text = LangText.GetString("Pad_ContextMenuHTMLView")
        Me.ContextMenuHTMLPrint.Text = LangText.GetString("Pad_ContextMenuHTMLPrint")

        Me.mnuHelpInstallPack.Text = LangText.GetString("Pad_mnuHelpInstallPack").Replace("[Program]", gProgName) 

    End Sub
    Private Sub mnuHelpInstallPack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpInstallPack.Click
        AddDebugComment("frmPad.mnuHelpInstallPack_Click") 

        Dim lstrAddOnFile As String

        Application.DoEvents() 
        
        If hasMultipleInstances(gProgName, NameMe(""), Me.Handle, StandLangText) = True Then 
            Exit Sub
        End If


        Application.DoEvents() 

        Dim OpenAddon As New OpenFileDialog()
        With OpenAddon
            .CheckFileExists = True
            .CheckPathExists = True

            '.Filter = "Mindwarp Consultancy Ltd AddOn (*.mcla)|*.mcla" 
            .Filter = "Mindwarp Consultancy Ltd AddOn (*.mcla;*.zip)|*.mcla;*.zip" 
            If .ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If
            lstrAddOnFile = .FileName

        End With

        Busy(Me, True) 
        Dim lstrDat As Date = Date.Now

        gstrCFUTempDir = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Temp-" & _
            lstrDat.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")
        Dim LangText2 As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Try
            System.IO.Directory.CreateDirectory(gstrCFUTempDir & "\unzip")
            AppBasic.UpdateFuncs.Unzip(lstrAddOnFile, gstrCFUTempDir & "\unzip\")

            Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", gstrCFUTempDir & "\unzip\addon.dat")
            With InitialConfig

                If AppBasic.IsCompatible(.GetValue("AppVersion", "")) = False Then 
                    'If AppBasic.IsThisVersion(.GetValue("AppVersion", "")) <> True Then                    
                    Directory.Delete(gstrCFUTempDir, True)
                    Throw New Exception(" ")
                End If

            End With

            'MessageBox.Show(LangText2.GetString("CFU_ProgRestart"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props
            gbooNeedToRestartProgAfterCFU = True
            'Application.DoEvents() 
            Try : File.Delete(gstrCFUTempDir & "\unzip\addon.dat") : Catch : End Try 
            Busy(Me, False) 
            Application.DoEvents() 
            'moved further down 
            MessageBox.Show(LangText2.GetString("CFU_ProgRestart"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props
            Me.Close()
            Try : Me.Close() : Catch : End Try 
        Catch
            Busy(Me, False) 
            MessageBox.Show(LangText2.GetString("CFU_DownloadIncompatible"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
            Try : File.Delete(gstrCFUTempDir & "\unzip\addon.dat") : Catch : End Try 
        End Try

    End Sub
    Private Function GetIBShortName(ByVal IBFile As String) As String 
        Dim lintArrInc As Integer

        Dim lintMaxHist As Integer = 3
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
            lintMaxHist = 19
        End If

        Dim Databases As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
        With Databases
            For lintArrInc = 0 To lintMaxHist
                If .GetValue("FileName" & lintArrInc, "") = IBFile Then
                    Return .GetValue("ShortName" & lintArrInc, "")
                    Exit Function
                End If
            Next lintArrInc
        End With
    End Function
    Private Sub richTextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        AddDebugComment("frmPad.richTextBox1_DragEnter - Start") 
        

        RichTextBox1.WordWrap = lbooRTFWordWrap ' fix for drap and drop not working propely, weird!!!

        If lbooRTFWordWrap = True Then
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = True 
        Else
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = False 
        End If

        AddDebugComment("frmPad.RichTextBox1_DragEnter") 

        If lbooDisableDragNDrop = False Then 
            
            If CType(e, DragEventArgs).Data.GetDataPresent(DataFormats.Text) Or CType(e, DragEventArgs).Data.GetDataPresent(DataFormats.Rtf) Then
                CType(e, DragEventArgs).Effect = DragDropEffects.Move
            Else
                CType(e, DragEventArgs).Effect = DragDropEffects.None
            End If
        End If

        AddDebugComment("frmPad.richTextBox1_DragEnter - End") 
    End Sub
    Private Sub richTextBox1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        

        'If elEvtsRTB = True Then : Console.WriteLine("richTextBox1_DragDrop") : End If
        AddDebugComment("frmPad.RichTextBox1_DragDrop") 

        Busy(Me, True) 
        Dim BeforeDropDestStart As Integer = RichTextBox1.SelectionStart 'Part of Final Fix, hopefully :)


        'Dim DropPos As Integer = RichTextBox1.GetCharIndexFromPosition(New Point(e.X, e.Y)) 
        'If elEvtsRTBDragDrog = True Then : Console.WriteLine( _
        '    " RichTextBox1.SelectedText=" & RichTextBox1.SelectedText & CR() & _
        '    " RichTextBox1.SelectionStart=" & RichTextBox1.SelectionStart & CR() & _
        '    " RichTextBox1.SelectionLength=" & RichTextBox1.SelectionLength & CR() & _
        '    " DropPos=" & DropPos) : End If
        'If DropPos > RichTextBox1.SelectionStart AndAlso DropPos < RichTextBox1.SelectionStart + RichTextBox1.SelectionLength Then
        '    Exit Sub
        'End If
        If lbooDisableDragNDrop = False Then 
            If mstrRTFDragCurrentSelection <> "" Then

                'TEST'Dim KeptData As New DataObject() 
                'TEST'KeptData = Clipboard.GetDataObject() 

                'If elEvtsRTBDragDrog = True Then : Console.WriteLine(CR() & " Before RichTextBox1.Selected=" & RichTextBox1.SelectedText) : End If
                'If elEvtsRTBDragDrog = True Then : Console.WriteLine( _
                '    " RichTextBox1.SelectedText=" & RichTextBox1.SelectedText & CR() & _
                '    " RichTextBox1.SelectionStart=" & RichTextBox1.SelectionStart & CR() & _
                '    " RichTextBox1.SelectionLength=" & RichTextBox1.SelectionLength) : End If


                
                If ThisDragSelctionIdx >= RichTextBox1.SelectionStart And ThisDragSelctionIdx <= (RichTextBox1.SelectionStart + RichTextBox1.SelectionLength) Then
                    ThisDragSelctionIdx = 0
                    RichTextBox1.SelectionLength = 0
                    mstrRTFDragCurrentSelection = ""
                    mintRTFDragCurSelStart = 0
                    mintRTFDragCurSelLength = 0
                    Busy(Me, False) 
                    Exit Sub
                End If
                

                
                RichTextBox1.SelectedRtf = mstrRTFDragCurrentSelection
                'TEST'Dim SelectionData As DataObject = New DataObject(DataFormats.Rtf, mstrRTFDragCurrentSelection)
                'TEST'Clipboard.SetDataObject(SelectionData, False)
                'TEST'RichTextBox1.Paste()
                

                'If RichTextBox1.SelectedText = "" Then
                '    mstrRTFDragCurrentSelection = ""
                '    mintRTFDragCurSelStart = 0
                '    mintRTFDragCurSelLength = 0
                '    Exit Sub
                'End If
                mintRTFDragAfterSelStart = RichTextBox1.SelectionStart
                mintRTFDragAfterSelLength = RichTextBox1.SelectionLength


                '---- 
                'RichTextBox1.SelectionStart = mintRTFDragCurSelStart
                If BeforeDropDestStart <= mintRTFDragCurSelStart Then
                    RichTextBox1.SelectionStart = (mintRTFDragCurSelStart + mintRTFDragCurSelLength)
                Else
                    RichTextBox1.SelectionStart = mintRTFDragCurSelStart
                End If
                '---- 

                RichTextBox1.SelectionLength = mintRTFDragCurSelLength
                RichTextBox1.SelectedText = ""
                'TEST' RichTextBox1.Cut() 
                RichTextBox1.SelectionStart = mintRTFDragAfterSelStart
                RichTextBox1.SelectionLength = mintRTFDragAfterSelLength

                'If elEvtsRTBDragDrog = True Then : Console.WriteLine("After" & CR() & _
                '    " RichTextBox1.SelectedText=" & RichTextBox1.SelectedText & CR() & _
                '    " RichTextBox1.SelectionStart=" & RichTextBox1.SelectionStart & CR() & _
                '    " RichTextBox1.SelectionLength=" & RichTextBox1.SelectionLength) : End If

                mstrRTFDragCurrentSelection = ""
                mintRTFDragCurSelStart = 0
                mintRTFDragCurSelLength = 0

                'TEST'Clipboard.SetDataObject(KeptData) 
            Else
                
                If RichTextBox1.SelectionLength = 0 Then
                    Select Case RTorHTMLDragData(e.Data)
                        Case "BITMAP"
                            Dim img As System.Drawing.Bitmap = CType(Windows.Forms.Clipboard.GetDataObject.GetData("Bitmap"), System.Drawing.Bitmap)
                            RichTextBox1.InsertImage(img, ProgresPanel)
                        Case "HTML"
                            RichTextBox1.SelectedText = e.Data.GetData(DataFormats.Text, True)
                        Case "RTF"
                            RichTextBox1.SelectedRtf = e.Data.GetData(DataFormats.Rtf).ToString
                        Case Else
                            'RichTextBox1.AppendText(e.Data.GetData("Text"))
                            RichTextBox1.SelectedText = e.Data.GetData(DataFormats.Text, True)
                    End Select

                    RichTextBox1.Focus()
                End If
                
            End If
        End If

        Busy(Me, False) 

    End Sub
    Private Function RTorHTMLDragData(ByVal ed As IDataObject) As String

        'Dim myFormatsArray As [String]() = Clipboard.GetDataObject.GetFormats(False)
        Dim myFormatsArray As [String]() = ed.GetFormats(False)

        Dim lintArrInc As Integer
        For lintArrInc = 0 To myFormatsArray.Length - 1
            
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "BITMAP") Then
                RTorHTMLDragData = "BITMAP"
                Exit Function
            End If
            
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "HTML") Then
                RTorHTMLDragData = "HTML"
                Exit Function
            End If
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "RICH TEXT") Then
                RTorHTMLDragData = "RTF"
                Exit Function
            End If
        Next lintArrInc


    End Function
    Private Sub RichTextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseDown
        

        'If elEvtsRTB = True Then : Console.WriteLine("RichTextBox1_MouseDown, Clicks=" & e.Clicks) : End If
        AddDebugComment("frmPad.RichTextBox1_MouseDown - Clicks=" & e.Clicks) 

        If e.Clicks = 2 Then
            lbooJusthadRTBDoubleClick = True
            
            Dim tbe As TableEditor.MainTableEditor
            Dim imagID As String

            imagID = GetImageIDForCurrentRTFSelection(RichTextBox1)
            'MessageBox.Show(imagID, "A") 

            If imagID <> -1 Then

                Dim Instructs As String = GetTabeDetailRec(imagID)

                If Instructs <> "" Then
                    tbe = New TableEditor.MainTableEditor(Instructs)
                End If

                With tbe
                    SetBasicTableEditorProperties(tbe, RichTextBox1)
                    .Owner = Me

                    If (.ShowDialog() = DialogResult.OK) Then
                        'update tableDetail Record
                        UpdateTableDetailsRec(imagID, ReturnTrueTopicStr(lstrCurTopicCode), .GetHTML, .GetPlainText)

                        'set image ID
                        Dim retImage As Image
                        'MessageBox.Show(imagID, "B") 
                        retImage = .GetImage(imagID)
                        RichTextBox1.InsertImage(retImage, ProgresPanel)
                    End If
                End With
            Else
                ' could add other image edit in here
            End If

            
            Exit Sub
        End If

        
        If e.Clicks = 1 And lbooJusthadRTBDoubleClick = True Then
            lbooJusthadRTBDoubleClick = False
            Exit Sub
        End If
        

        If e.Button = MouseButtons.Left AndAlso RichTextBox1.SelectionLength = 0 Then
            RichTextBox1.AutoWordSelection = False
        End If

        If lbooDisableDragNDrop = False Then 
            'Console.WriteLine("D " & RichTextBox1.CanUndo) 

            'Dim index As Integer = RichTextBox1.GetCharIndexFromPosition(New Point(e.X, e.Y))

            'Console.WriteLine("E " & RichTextBox1.CanUndo) 
            If e.Button = MouseButtons.Left AndAlso RichTextBox1.SelectionLength <> 0 Then
                'Console.WriteLine("F " & RichTextBox1.CanUndo) 
                
                Dim index As Integer = GetTextPositionFromPoint(RichTextBox1, New Point(e.X, e.Y))
                'If RichTextBox1.SelectionStart < index AndAlso index < RichTextBox1.SelectionStart + RichTextBox1.SelectionLength Then
                'added <= 
                If RichTextBox1.SelectionStart < index AndAlso index <= RichTextBox1.SelectionStart + RichTextBox1.SelectionLength Then
                    'Console.WriteLine("G " & RichTextBox1.CanUndo) 
                    mstrRTFDragCurrentSelection = RichTextBox1.SelectedRtf 'RichTextBox1.SelectedText
                    If mintRTFDragCurSelLength = 0 Then
                        ThisDragSelctionIdx = index 
                        'If elEvtsRTBDragDrog = True Then : Console.WriteLine("index=" & index & CR() & _
                        '    " RichTextBox1.SelectedText=" & RichTextBox1.SelectedText & CR() & _
                        '    " RichTextBox1.SelectionStart=" & RichTextBox1.SelectionStart & CR() & _
                        '    " RichTextBox1.SelectionLength=" & RichTextBox1.SelectionLength) : End If

                        mintRTFDragCurSelStart = RichTextBox1.SelectionStart
                        mintRTFDragCurSelLength = RichTextBox1.SelectionLength
                    End If
                    'Console.WriteLine("H " & RichTextBox1.CanUndo) 
                    'RichTextBox1.DoDragDrop(mstrRTFDragCurrentSelection, DragDropEffects.Move Or DragDropEffects.Copy) 'copy works
                    
                    Dim DragData As DataObject = New DataObject(DataFormats.Rtf, mstrRTFDragCurrentSelection)
                    RichTextBox1.DoDragDrop(DragData, DragDropEffects.Move Or DragDropEffects.Copy) 'copy works
                End If
            End If
        End If

        
        If e.Button = MouseButtons.Left Then
            If RichTextBox1.SelectionType = RichTextBoxSelectionTypes.Object Then
                RichTextBox1.SelectionLength = 0
            End If
        End If
        

        Dim tmp As Integer = GetCharPos()
        If tmp = 1 Then keyEnter = True
        RefreshCutCopyPaste(False) 
    End Sub
    Private Sub mnuEditDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditDelete.Click
        If RichTextBox1.Visible = True Then 
            mnuRTFDelete_Click(Nothing, Nothing) 
        Else 
            AxWebBrowser1.Delete()
        End If 
        RefreshCutCopyPaste(False) 

    End Sub
    Private Function NewFileRequired(ByVal pstrLocalFile As String, ByVal plngNewFileBytes As Long) As Boolean
        'created

        NewFileRequired = False

        If File.Exists(pstrLocalFile) = False Then
            NewFileRequired = True
            Exit Function
        End If

        Dim LocalFile2 As New System.IO.StreamReader(pstrLocalFile)


        If LocalFile2.BaseStream.Length <> plngNewFileBytes + 2 Then
            NewFileRequired = True
        End If

        LocalFile2.Close()

    End Function
    Private Sub RichTextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.Enter


        
        RichTextBox1.WordWrap = lbooRTFWordWrap ' fix for drap and drop not working propely, weird!!!

        If lbooRTFWordWrap = True Then
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = True 
        Else
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = False 
        End If

        'SetWordWrap(RichTextBox1, lbooRTFWordWrap) 
        'Unfortunetly this doesn't do the same thing as the line at the top.
        'This is at the expense of clearing the clipboard.

    End Sub
    Private Sub BusyPad(ByVal pojForm As Form, ByVal pbooFlags As Boolean)
        'Created

        Dim lCursor As Cursor

        If pbooFlags = True Then
            lCursor = Cursors.WaitCursor
        Else
            lCursor = Cursors.Default
        End If

        pojForm.Cursor = lCursor

        Try
            If AxWebBrowser1.Visible = True Then
                AxWebBrowser1.Cursor = lCursor
            End If
        Catch
            '
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'Created

        If keyData = Keys.Delete Then
            'Console.WriteLine("key delete")
            If RichTextBox1.Visible = True Then

                If RichTextBox1.SelectionLength = 0 Then
                    RichTextBox1.SelectionLength = 1
                    RichTextBox1.SelectedText = ""
                Else
                    RichTextBox1.SelectedRtf = ""
                End If
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function
    Private Function RTorHTML() As String
        'Created
        Dim myFormatsArray As [String]() = Clipboard.GetDataObject.GetFormats(False)

        Dim lintArrInc As Integer
        For lintArrInc = 0 To myFormatsArray.Length - 1
            
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "BITMAP") Then
                RTorHTML = "BITMAP"
                Exit Function
            End If
            
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "HTML") Then
                RTorHTML = "HTML"
                Exit Function
            End If
            If InStrGet(myFormatsArray(lintArrInc).ToUpper, "RICH TEXT") Then
                RTorHTML = "RTF"
                Exit Function
            End If
        Next lintArrInc


    End Function
    Private Sub mnuItemMoveToRoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemMoveToRoot.Click

        
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show(LangText.GetString("Pad_mnuItemMoveToRoot").Replace("&", "") & ": '" & _
            TreeView1.SelectedNode.Text & "'", NameMe(""), MessageBoxButtons.YesNo)

        If dlgResult <> DialogResult.Yes Then
            Exit Sub
        End If
        AddDebugComment("frmPad.mnuItemMoveToRoot_Click")
        

        'function created
        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()
        Dim llnglevel As Long

        BusyPad(Me, True)

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        llnglevel = 1
        lstrSQL = "UPDATE Topics SET ParentTopicCode = '', [Level] = " & llnglevel & " WHERE TopicCode='" & TreeView1.SelectedNode.Tag & "';"

        lstrCurTopicCode = TreeView1.SelectedNode.Tag
        AddDebugComment("frmPad.mnuItemMoveToRoot_Click - " & llnglevel & " " & NodateLevel(TreeView1.SelectedNode) & " " & lstrCurTopicCode) 

        'If el = True Then : Console.WriteLine("CTMMBsClk 1 " & lstrSQL) : End If
        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)

        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        cNodes = TreeView1.SelectedNode.GetNodeCount(True)

        If cNodes = 0 Then
            lcnn1.Close()
            PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
            SelectNodeByTag(lstrCurTopicCode, TreeView1, lcurDocumentView)
            Try
                StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath
            Catch
            End Try
            BusyPad(Me, False)
            Exit Sub
        End If

        AddDebugComment("frmPad.mnuItemMoveToRoot_Click - cNodes=" & cNodes) 

        ProgresPanel.Maximum = cNodes
        ProgresPanel.Minimum = 0
        ProgresPanel.Value = 0

        ReDim ndxs(cNodes)

        GetNodes(TreeView1.SelectedNode.Nodes(0), ndxs, curNode, False)

        Dim llngCounter As Integer
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            llnglevel = NodateLevel(n)
            lstrSQL = "Update Topics set [Level] = " & llnglevel & " WHERE TopicCode='" & n.Tag & "';"
            'If el = True Then : Console.WriteLine("CTMMBsClk 2 " & lstrSQL) : End If
            AddDebugComment("frmPad.mnuItemMoveToRoot_Click - " & llnglevel & " " & lstrCurTopicCode) 
            gstrLastSQL = lstrSQL 

            lcnn1.Execute(lstrSQL)

            ProgresPanel.Increment(1)
            llngCounter += 1
            If llngCounter > 10 Then
                System.Windows.Forms.Application.DoEvents()
                llngCounter = 0
            End If
        Next n

        lcnn1.Close()

        AddDebugComment("frmPad.mnuItemMoveToRoot_Click - B4 populate") 
        ProgresPanel.Value = 0
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
        AddDebugComment("frmPad.mnuItemMoveToRoot_Click - AF populate") 
        SelectNodeByTag(lstrCurTopicCode, TreeView1, lcurDocumentView)
        Try
            StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath
        Catch
        End Try

        BusyPad(Me, False)

        AddDebugComment("frmPad.mnuItemMoveToRoot_Click - Done") 
    End Sub
    Private Sub StatusBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StatusBar1.MouseUp
        'created

        'If e.Button = MouseButtons.Right And Not mbooStatusPanelClickHandled Then
        '    Select Case True
        '        Case mStatusPanelClickLastPanel Is Me.ProgresPanel
        '            'MessageBox.Show("ProgresPanel")
        '        Case mStatusPanelClickLastPanel Is Me.SystemStatusPanel
        '            'MessageBox.Show("SystemStatusPanel")
        '        Case mStatusPanelClickLastPanel Is Me.RightMostPanel
        '            'MessageBox.Show("RightMostPanel")
        '            Dim DebugPassword As String
        '            Dim DebugPassInput As New InputBox()
        '            DebugPassInput.Owner = Me 
        '            'lstrName = BranchInput.Display("Please enter a branch name!", NameMe("New sub branch"))

        '            'AddDebugComment("<Font color=Blue>Manual Problem Report</font>") 

        '            '
        '            'DebugDBComment() 


        '    End Select
        'End If
        'mbooStatusPanelClickHandled = True

    End Sub
    Private Sub ctmHighlight_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctmHighlight.Popup
        'added 
        AddDebugComment("frmPad.ctmHighlight_Popup") 
        Dim dlgResult As DialogResult
        With ColorDialog1
            .Color = CurrentRTFHighlightColour
            dlgResult = .ShowDialog()
            If dlgResult = DialogResult.OK Then
                CurrentRTFHighlightColour = .Color
                UpdateHighLightButton()

                LockWindowUpdate(Me.Handle) 

                'RichTextBox2.SelectionBackColor(CurrentRTFHighlightColour, WinOnly.ExRichTextBox.CHARFORMATRANGE.FormatSelection, RichTextBox1)
                Try 
                    
                    SelectionBackColor(RichTextBox2, CurrentRTFHighlightColour, CHARFORMATRANGE.FormatSelection, RichTextBox1)
                Catch
                    'Console.WriteLine("Highlight error")
                End Try
                LockWindowUpdate(IntPtr.Zero) 
            End If
        End With

    End Sub
    Private Function UpdateHighLightButton()
        'added 

        AddDebugComment("frmPad.UpdateHighLightButton") 
        LockWindowUpdate(Me.Handle)
        Try 
            Dim Res As New IPIconsPack.Resource()
            'Dim SelectionbackImgList As New ImageList()
            'SelectionbackImgList.Images.Clear()
            'Dim Res256 As New IPIconsPack.Resources256() 

            'If IsWin98orME() = True Then 
            tbCoolbar.Bands(tbBand.Font).ImageList = Res.ilToolButtons256 
            Res.ilToolButtons256.Images.Add(RTFStand.GeneralRTFUI.CreateGraphic(CurrentRTFHighlightColour, 24)) 
            tbCoolbar.Bands(tbBand.Font).Buttons(15).ImageIndex = Res.ilToolButtons256.Images.Count - 1 
            'Else
            '    tbCoolbar.Bands(tbBand.Font).ImageList = Res.ilToolButtons
            '    Res.ilToolButtons.Images.Add(RTFStand.GeneralRTFUI.CreateGraphic(CurrentRTFHighlightColour, 24))
            '    'ToolBarButton29.ImageIndex = Res.ilToolButtons.Images.Count - 1
            '    'tbCoolbar.Bands(tbBand.Font).Buttons(17).ImageIndex = Res.ilToolButtons.Images.Count - 1
            '    
            '    tbCoolbar.Bands(tbBand.Font).Buttons(15).ImageIndex = Res.ilToolButtons.Images.Count - 1
            'End If



        Catch 
            'Console.WriteLine("Update Highlbutton error")
        End Try 

        RefreshCutCopyPaste(False) 

        LockWindowUpdate(IntPtr.Zero)

    End Function
    'Private Sub mnuEditFontToolbar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditFontToolbar.Click

    '    'added 
    '    If RichTextBox1.Visible = True Then 'And lcurDocumentView = DocumentViews.NormalTopic Then
    '        If pnlFontToolbar.Visible = True Then
    '            pnlFontToolbar.Visible = False
    '            ToolBar1.SendToBack()
    '        Else
    '            pnlFontToolbar.Visible = True
    '            ToolBar1.SendToBack()
    '        End If
    '    End If
    '    mnuEditFontToolbar.Checked = pnlFontToolbar.Visible

    'End Sub
    Private Sub cboFontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFontName.SelectedIndexChanged

        If IsFormOpen(Me, LangText.GetString("Pad_mnuEditFindReplace").Replace("&", "")) = False Then 

            AddDebugComment("frmPad.cboFontName_SelectedIndexChanged") 

            Try
                Dim fontFamilyString As String
                fontFamilyString = cboFontName.SelectedItem

                If Not RichTextBox1.SelectionFont Is Nothing Then 
                    'added 
                    '  system.Drawing.FontFamily.Families from cbofontname comobox
                    Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont

                    ''''RichTextBox1.SelectionFont = New Font(fontFamilyString, currentFont.Size, currentFont.Style)

                    SetFontStyle(currentFont.Style, fontFamilyString, ) 

                Else 
                    SetFontStyle(Nothing, fontFamilyString, ) 
                End If 
            Catch ex As Exception 
                AddDebugComment("frmPad.cboFontName_SelectedIndexChanged - Error " & ex.ToString)
            End Try 


            RichTextBox1.Focus()
        End If

    End Sub
    Private Sub cboFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFontSize.SelectedIndexChanged

        If IsFormOpen(Me, LangText.GetString("Pad_mnuEditFindReplace").Replace("&", "")) = False Then 

            AddDebugComment("frmPad.cboFontSize_SelectedIndexChanged") 

            Try 
                Dim inewFontSize As Integer
                inewFontSize = CInt(cboFontSize.SelectedItem)
                If Not RichTextBox1.SelectionFont Is Nothing Then 
                    'added 

                    Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont

                    ''RichTextBox1.SelectionFont = New Font(currentFont.FontFamily, inewFontSize, currentFont.Style)
                    SetFontStyle(currentFont.Style, currentFont.FontFamily.Name.ToString, inewFontSize)

                Else 
                    SetFontStyle(Nothing, , inewFontSize) 
                End If 
            Catch ex As Exception 
                AddDebugComment("frmPad.cboFontSize_SelectedIndexChanged - Error " & ex.ToString)
            End Try 


            RichTextBox1.Focus()

            RefreshCutCopyPaste(False) 
        End If

    End Sub
    Private Sub cboFontName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFontName.MouseLeave
        RichTextBox1.Focus() 
    End Sub
    Private Sub cboFontSize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFontSize.MouseLeave
        RichTextBox1.Focus() 
    End Sub
    'Private Sub tbExtra_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)

    '    AddDebugComment("frmPad.tbExtra_ButtonClick " & tbExtra.Buttons.IndexOf(e.Button)) 
    '    'added 
    '    Select Case tbExtra.Buttons.IndexOf(e.Button)
    '        Case GetBtnIdx("Move Up", False)
    '            mnuItemMoveBranchUp_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Move Down", False)
    '            mnuItemMoveBranchDown_Click(Nothing, Nothing)
    '        Case GetBtnIdx("Move Top", False) 
    '            mnuItemMoveBranchTop_Click(Nothing, Nothing) 
    '        Case GetBtnIdx("Move Bottom", False) 
    '            mnuItemMoveBranchBottom_Click(Nothing, Nothing) 
    '    End Select

    'End Sub
    Private Sub mnuItemMoveBranchUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemMoveBranchUp.Click

        If CheckChangeSort() = False Then Exit Sub 

        'added 
        ChangeTopicSeqNum(TreeView1.SelectedNode.Tag, gintMoveBranchIncr, True)

    End Sub
    Private Sub mnuItemMoveBranchDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemMoveBranchDown.Click

        If CheckChangeSort() = False Then Exit Sub 

        'added 
        ChangeTopicSeqNum(TreeView1.SelectedNode.Tag, gintMoveBranchIncr, False)

    End Sub
    Private Sub ChangeTopicSeqNum(ByVal pstrTopicCode As String, ByVal pintAmount As Integer, ByVal pbooNeg As Boolean)

        AddDebugComment("frmPad.ChangeTopicSeqNum " & pintAmount & " " & pbooNeg) 
        'added 
        Dim lcnn1 As New ADODB.Connection()
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        'get all topics with the the parent code of the current topic code and the seqnums
        Dim lstrSQLGet As String
        lstrSQLGet = "SELECT TopicCode, Trim(ParentTopicCode & '') AS Expr1, SeqNum, Title FROM Topics WHERE" & _
            "(((Trim(ParentTopicCode & ''))=Trim((SELECT  ParentTopicCode  FROM Topics WHERE TopicCode='" & _
            pstrTopicCode & "';) & ''))) ORDER BY SeqNum"

        If pbooNeg = True Then
            lstrSQLGet &= " DESC;"
        Else
            lstrSQLGet &= ";"
        End If

        Dim lsnaLists As New ADODB.Recordset()

        Dim MovingTopicSeqNum As String = ""
        Dim PushedTopicCode As String = ""
        Dim PushedTopicSeqNum As String = ""
        gstrLastSQL = lstrSQLGet 

        lsnaLists.Open(lstrSQLGet, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists
            Do While Not .EOF

                'Console.WriteLine(.Fields("TopicCode").Value & " " & .Fields("SeqNum").Value & " " & .Fields("Title").Value)
                'get the seqnum of the current topic code
                If pstrTopicCode = .Fields("TopicCode").Value Then
                    MovingTopicSeqNum = .Fields("SeqNum").Value
                End If

                'get the seqnum of the next highest seqnum, topic code
                If MovingTopicSeqNum <> "" Then
                    If pbooNeg = True Then
                        If CInt(.Fields("SeqNum").Value) < CInt(MovingTopicSeqNum) Then
                            PushedTopicCode = .Fields("TopicCode").Value
                            PushedTopicSeqNum = .Fields("SeqNum").Value
                            Exit Do
                        End If
                    Else
                        If CInt(.Fields("SeqNum").Value) > CInt(MovingTopicSeqNum) Then
                            PushedTopicCode = .Fields("TopicCode").Value
                            PushedTopicSeqNum = .Fields("SeqNum").Value
                            Exit Do
                        End If
                    End If
                End If

                .MoveNext()
            Loop
        End With


        lsnaLists.Close()


        'update and swap the seqnum of these two topic codes.
        If PushedTopicSeqNum <> "" And PushedTopicCode <> "" Then 'will be blank if at top or bottom and can't move any further.
            Dim lstrSQL As String = "update Topics set Seqnum=" & PushedTopicSeqNum & " where TopicCode='" & pstrTopicCode & "';"
            gstrLastSQL = lstrSQL 
            lcnn1.Execute(lstrSQL)

            lstrSQL = "update Topics set Seqnum=" & MovingTopicSeqNum & " where TopicCode='" & PushedTopicCode & "';"
            gstrLastSQL = lstrSQL 
            lcnn1.Execute(lstrSQL)
        End If

        'If pbooNeg = True Then
        '    lcnn1.Execute("update Topics set Seqnum=(Seqnum - " & pintAmount & ") where TopicCode='" & pstrTopicCode & "';")
        'Else
        '    lcnn1.Execute("update Topics set Seqnum=(Seqnum + " & pintAmount & ") where TopicCode='" & pstrTopicCode & "';")
        'End If

        lcnn1.Close()

        BusyPad(Me, True)
        lbooDBAccOrUIAcc = True
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
        lbooDBAccOrUIAcc = False
        BusyPad(Me, False)
        SelectNodeByTag(pstrTopicCode, TreeView1, lcurDocumentView)

    End Sub
    Private Sub mnuItemMoveBranchTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemMoveBranchTop.Click
        
        If CheckChangeSort() = False Then Exit Sub 
        UpdateSeqTopOrBottom(TreeView1.SelectedNode.Tag, True)

    End Sub
    Private Sub mnuItemMoveBranchBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemMoveBranchBottom.Click
        
        If CheckChangeSort() = False Then Exit Sub 
        UpdateSeqTopOrBottom(TreeView1.SelectedNode.Tag, False)

    End Sub
    Private Sub UpdateSeqTopOrBottom(ByVal pstrTopicCode As String, ByVal pbooNeg As Boolean)
        'added 

        AddDebugComment("frmPad.UpdateSeqTopOrBottom " & pbooNeg)

        Dim lcnn1 As New ADODB.Connection()
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim MinOrMax As String = "Min"
        If pbooNeg = False Then
            MinOrMax = "Max"
        End If

        Dim lstrSQLGetLowestSeq As String = "SELECT " & MinOrMax & "(SeqNum) AS MinMaxOfSeqNum FROM Topics WHERE " & _
            "(((Trim([ParentTopicCode] & ''))=Trim((SELECT  ParentTopicCode  FROM Topics WHERE TopicCode='" & pstrTopicCode & "';) & '')))"

        Dim lsnaLists As New ADODB.Recordset()
        gstrLastSQL = lstrSQLGetLowestSeq 

        lsnaLists.Open(lstrSQLGetLowestSeq, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Dim LowestHighestSeq As Integer

        With lsnaLists
            If Not .EOF Then
                LowestHighestSeq = CInt(.Fields("MinMaxOfSeqNum").Value) ' - 10
                If pbooNeg = True Then
                    LowestHighestSeq -= 10
                Else
                    LowestHighestSeq += 10
                End If
            End If
        End With


        lsnaLists.Close()

        Dim lstrSQL As String = "update Topics set Seqnum=" & LowestHighestSeq & " where TopicCode='" & pstrTopicCode & "';"

        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)

        lcnn1.Close()

        BusyPad(Me, True)
        lbooDBAccOrUIAcc = True
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
        lbooDBAccOrUIAcc = False

        '--- this code could be used here instead  ---
        'up
        'Dim Node As TreeNode = TreeView1.GetNodeAt(p)
        'SwapNodes(Node, Node.PrevNode)
        'Down
        'Dim Node As TreeNode = TreeView1.GetNodeAt(p)
        'SwapNodes(Node, Node.NextNode, False)
        '--- this code could be used here instead ---


        BusyPad(Me, False)
        SelectNodeByTag(pstrTopicCode, TreeView1, lcurDocumentView)

    End Sub
    Private Function CheckChangeSort() As Boolean
        'made into function 
        CheckChangeSort = True

        If gstrSortOrder = "ALPHA" Then 
            Dim dlgRes As DialogResult = MessageBox.Show(LangText.GetString("Pad_SortAlphaToSeqMsg").Replace("[Program]", gProgName).Replace("[CR2]", _
                Environment.NewLine & Environment.NewLine).Replace("[CR]", Environment.NewLine), _
                NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 

            If dlgRes = DialogResult.Yes Then
                SaveSetting("Tree Sort Order", "SEQNUM", InitalXMLConfig.XmlConfigType.AppSettings, "") 
                gstrSortOrder = "SEQNUM"

            Else
                CheckChangeSort = False
            End If

        End If

    End Function
    Private Sub SetDefDictionaryWhenBlank()
        AddDebugComment("frmPad.SetDefDictionaryWhenBlank") 
        'added 
        Dim lstrSpellDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Spelling\"

        If Directory.Exists(lstrSpellDir) = True Then

            Dim listDir() As String = System.IO.Directory.GetFiles(lstrSpellDir)
            If listDir.Length = 1 Then

                Dim lstrFileName As String = System.IO.Path.GetFileName(listDir(0))
                SaveSetting("DictionaryFile", lstrFileName, InitalXMLConfig.XmlConfigType.AppSettings, "")
            End If
        End If


    End Sub
    Private Sub ResizeFontToolbarForXPStyle()
        ''added 
        'Dim NewHeight As Integer
        'Dim NewTop As Integer
        'Dim Label2Left As Integer
        'Dim TbExtraWidth As Integer

        'If ToolBar1.Height > pnlFontToolbar.Height Then
        '    'cboFontName.top = 3
        '    'NewHeight = ToolBar1.Height '- 5
        '    NewHeight = 200
        '    NewTop = ((NewHeight - pnlFontToolbar.Height) / 2) + 3
        '    Label2Left = 3
        '    TbExtraWidth = 180
        'ElseIf ToolBar1.Height < pnlFontToolbar.Height Then
        '    NewTop = 3
        '    NewHeight = 25
        '    Label2Left = 0
        '    TbExtraWidth = 100
        'Else
        '    'do nothing
        '    Exit Sub
        'End If

        'ToolBar1.AutoSize = False
        'tbExtra.AutoSize = False

        'cboFontSize.Top = NewTop
        'cboFontName.Top = NewTop

        'Label2.Height = NewHeight - 6
        'Label2.Left = Label2Left

        'pnlFontToolbar.Height = NewHeight
        'tbExtra.Width = TbExtraWidth
        'tbExtra.Height = NewHeight
        'tbExtra.BorderStyle = BorderStyle.FixedSingle
        ''tbExtra.ButtonSize = ToolBar1.ButtonSize

        'Console.WriteLine(Environment.NewLine & "ResizeFontToolbarForXPStyle")
        'Console.WriteLine("pnlFontToolbar.Height=" & pnlFontToolbar.Height)
        'Console.WriteLine("tbExtra.Height=" & tbExtra.Height)
        'Console.WriteLine("ToolBar1.Height=" & ToolBar1.Height)
        'Console.WriteLine("tbExtra.ButtonSize.Height=" & tbExtra.ButtonSize.Height)
        'Console.WriteLine("ToolBar1.ButtonSize.Height=" & ToolBar1.ButtonSize.Height)
        'ToolBar1.AutoSize = True
        'tbExtra.AutoSize = True
        ''ToolBar1.ButtonSize = tbExtra.ButtonSize
        ''ToolBar1.Height = tbExtra.Height

    End Sub
    Private Function GetSafeStyleForFontFamily(ByVal fontFam As FontFamily, ByVal style As FontStyle) As Boolean
        'Added 
        GetSafeStyleForFontFamily = True
        ' remove the styles not supported
        If (style And FontStyle.Regular) = FontStyle.Regular Then
            ' if the regular style is currently present, but not supported 
            ' by the new font family, remove it
            If Not fontFam.IsStyleAvailable(FontStyle.Regular) Then
                GetSafeStyleForFontFamily = False
            End If
        End If
        ' do the same for bold, italic and underline
        If (style And FontStyle.Bold) = FontStyle.Bold Then
            If Not fontFam.IsStyleAvailable(FontStyle.Bold) Then
                GetSafeStyleForFontFamily = False
            End If
        End If
        If (style And FontStyle.Italic) = FontStyle.Italic Then
            If Not fontFam.IsStyleAvailable(FontStyle.Italic) Then
                GetSafeStyleForFontFamily = False
            End If
        End If
        If (style And FontStyle.Underline) = FontStyle.Underline Then
            If Not fontFam.IsStyleAvailable(FontStyle.Underline) Then
                GetSafeStyleForFontFamily = False
            End If
        End If
        If (style And FontStyle.Strikeout) = FontStyle.Strikeout Then
            If Not fontFam.IsStyleAvailable(FontStyle.Strikeout) Then
                GetSafeStyleForFontFamily = False
            End If
        End If

    End Function
    Private Sub UpdateFontStyleSelections(Optional ByVal Unpushed As Boolean = False, Optional ByVal DontUpdateFonts As Boolean = False)
        'added 

        If Not RichTextBox1.SelectionFont Is Nothing Then 
            'AddDebugComment("frmPad.UpdateFontStyleSelections - start") 
            gstrProbComtStack = "frmPad.UpdateFontStyleSelections - start" 
            Dim bold As Boolean = False
            Dim Italic As Boolean = False
            Dim Underline As Boolean = False

            If Unpushed = False Then
                bold = RichTextBox1.SelectionFont.Bold
                Italic = RichTextBox1.SelectionFont.Italic
                'RichTextBox1.SelectionFont.Strikeout
                Underline = RichTextBox1.SelectionFont.Underline
            End If

            

            'Dim lbooBoldEnabled As Boolean = True
            'If RichTextBox1.SelectionFont.FontFamily.IsStyleAvailable(FontStyle.Bold) = True Then
            '    lbooBoldEnabled = False
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Bold", tbBand.Font)).Pushed = bold
            '    'Else
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Bold", tbBand.Font)).Pushed = False
            'End If

            'Dim lbooItalicsEnabled As Boolean = True
            'If RichTextBox1.SelectionFont.FontFamily.IsStyleAvailable(FontStyle.Italic) = True Then
            '    lbooItalicsEnabled = False
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Italics", tbBand.Font)).Pushed = Italic
            '    'Else
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Italics", tbBand.Font)).Pushed = False
            'End If

            'Dim lbooUnderlinedEnabled As Boolean = True
            'If RichTextBox1.SelectionFont.FontFamily.IsStyleAvailable(FontStyle.Underline) = True Then
            '    lbooUnderlinedEnabled = False
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Underlined", tbBand.Font)).Pushed = Underline
            '    'Else
            '    '    tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Underlined", tbBand.Font)).Pushed = False
            'End If

            'AddDebugComment("frmPad.UpdateFontStyleSelections - 2") 
            gstrProbComtStack &= " #UFSS1" 

            Dim lbooBoldEnabled As Boolean = GetSafeStyleForFontFamily(RichTextBox1.SelectionFont.FontFamily, FontStyle.Bold)
            Dim lbooItalicsEnabled As Boolean = GetSafeStyleForFontFamily(RichTextBox1.SelectionFont.FontFamily, FontStyle.Italic)
            Dim lbooUnderlinedEnabled As Boolean = GetSafeStyleForFontFamily(RichTextBox1.SelectionFont.FontFamily, FontStyle.Underline)

            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Bold", tbBand.Font)).Enabled = lbooBoldEnabled
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Italics", tbBand.Font)).Enabled = lbooItalicsEnabled
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Underlined", tbBand.Font)).Enabled = lbooUnderlinedEnabled
            

            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Bold", tbBand.Font)).Pushed = bold
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Italics", tbBand.Font)).Pushed = Italic
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Font Underlined", tbBand.Font)).Pushed = Underline

            'AddDebugComment("frmPad.UpdateFontStyleSelections - 3") 
            gstrProbComtStack &= " #UFSS2" 

            
            If DontUpdateFonts = False Then
                'AddDebugComment("frmPad.UpdateFontStyleSelections - 4") 
                gstrProbComtStack &= " #UFSS3" 
                Dim FontSize As Single = CInt(RichTextBox1.SelectionFont.Size)
                Dim FontName As String = RichTextBox1.SelectionFont.FontFamily.Name
                'cboFontName.SelectedItem = FontName
                'cboFontSize.SelectedItem = FontSize

                'cboFontName.SelectedValue = FontName
                'cboFontSize.SelectedValue = FontSize

                cboFontName.Text = FontName
                cboFontSize.Text = FontSize
            End If
            
        End If 

        'AddDebugComment("frmPad.UpdateFontStyleSelections - end") 

        gstrProbComtStack &= " #UFSS-End" : AddDebugComment(gstrProbComtStack) : gstrProbComtStack = "" 
    End Sub
    Private Sub SetBackcolors()

        'Added 
        'Splitter1.BackColor = Color.FromArgb(0, Splitter1.BackColor) ' not allowed


    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'AddDebugComment("frmPad.OnPaintBackground - Start") 
        gstrProbComtStack = "frmPad.OnPaintBackground - Start" 
        'Added 
        Dim PaintBack As New UIStyle.Painting()
        'AddDebugComment("frmPad.OnPaintBackground - 1") 
        gstrProbComtStack &= " #OBP1" 
        PaintBack.PaintBackground(pevent, Me)

        'AddDebugComment("frmPad.OnPaintBackground - End") 

        gstrProbComtStack &= " #OBP-End" : AddDebugComment(gstrProbComtStack) : gstrProbComtStack = "" 
    End Sub
    Private Sub tbCoolbar_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByVal BandIdx As Integer) Handles tbCoolbar.ButtonClick

        
        AddDebugComment("frmPad.ToolBar1_ButtonClick " & e.Button.Tag)

        Select Case CType(BandIdx, tbBand)
            Case tbBand.Standard
                Select Case e.Button.Tag
                    Case "Print"
                        mnuFilePrint_Click(Nothing, Nothing)
                    Case "New Root"
                        AddNewRootBranch("")
                    Case "New Sub Branch"
                        AddNewSubBranch("")
                    Case "Cut"
                        mnuEditCut_Click(Nothing, Nothing)
                    Case "Copy"
                        mnuEditCopy_Click(Nothing, Nothing)
                    Case "Paste"
                        mnuEditPaste_Click(Nothing, Nothing)
                    Case "Undo"
                        mnuEditUndo_Click(Nothing, Nothing)
                    Case "Redo"
                        mnuEditRedo_Click(Nothing, Nothing)
                    Case "Spelling"
                        mnuToolsSpelling_Click(Nothing, Nothing)
                    Case "Insert Graphic"
                        mnuInsertGraphics_Click(Nothing, Nothing)
                    Case "Insert Table" 
                        mnuInsertTable_Click(Nothing, Nothing) 
                    Case "Page Colour"
                        mnuFormatBackground_Click(Nothing, Nothing) 
                    Case "Rapid Entry"
                        DoRapidEntry("")
                End Select

            Case tbBand.Branch
                Select Case e.Button.Tag
                    Case "Branch Properties"
                        mnuItemProperties_Click(Nothing, Nothing)
                    Case "Move Up"
                        mnuItemMoveBranchUp_Click(Nothing, Nothing)
                    Case "Move Down"
                        mnuItemMoveBranchDown_Click(Nothing, Nothing)
                    Case "Move Top"
                        mnuItemMoveBranchTop_Click(Nothing, Nothing)
                    Case "Move Bottom"
                        mnuItemMoveBranchBottom_Click(Nothing, Nothing)
                    Case "Expand"
                        mnuToolsExpandAll_Click(Nothing, Nothing)
                    Case "Collapse"
                        mnuToolsCollapseAll_Click(Nothing, Nothing)
                End Select

            Case tbBand.Font
                Select Case e.Button.Tag
                    Case "Font Bold"
                        SetFontStyle(FontStyle.Bold)
                    Case "Font Italics"
                        SetFontStyle(FontStyle.Italic)
                    Case "Font Underlined"
                        SetFontStyle(FontStyle.Underline)
                    Case "Font Colour"
                        With ColorDialog1
                            .Color = RichTextBox1.SelectionColor
                            .ShowDialog()
                            RichTextBox1.SelectionColor = .Color
                        End With
                    Case "Highlight"
                        SelectionBackColor(RichTextBox2, CurrentRTFHighlightColour, CHARFORMATRANGE.FormatSelection, RichTextBox1)
                    Case "Align Left"
                        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
                        RichTextBox1.Focus()
                    Case "Align Centre"
                        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
                        RichTextBox1.Focus()
                    Case "Align Right"
                        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
                        RichTextBox1.Focus()
                    Case "Font style"
                        mnuRTFFont_Click(Nothing, Nothing)
                    Case "Bullets"
                        mnuInsertBullets_Click(Nothing, Nothing)
                    Case "Word Wrap"
                        mnuViewWordWrap_Click(Nothing, Nothing)
                End Select

            Case tbBand.Search
                Select Case e.Button.Tag
                    Case "CancelSearch" 
                        tbCoolbar.Bands(tbBand.Search).Buttons(5).Tag = "Search" 
                        gintThreadEnd = 1 
                        cboSearchTool.Enabled = True
                    Case "Search"
                        SearchTool() 
                End Select

        End Select

        RefreshCutCopyPaste(False)
        
    End Sub
    Private Sub SearchTool()
        gstrMRPs = "0946"
        If SearchHistroy.ButtonClick(cboSearchTool) = False Then 
            Exit Sub
        End If

        
        Dim SearchCaption As String = tbCoolbar.Bands(tbBand.Search).Buttons(5).Text

        tbCoolbar.Bands(tbBand.Search).Buttons(5).Tag = "CancelSearch"
        cboSearchTool.Enabled = False
        Busy(Me, True)

        Dim find As New Finding()
        Dim Results As New FindResults()

        With Results
            find.TitleSearch(.TreeView1, cboSearchTool.Text)
            find.DetailsSearch(.TreeView1, ProgresPanel, cboSearchTool.Text)
            find.TableHumanStringSearch(.TreeView1, ProgresPanel, cboSearchTool.Text) 

            gintThreadEnd = 2
            Busy(Me, False)
            .Owner = Me
            .TreeviewSelect = TreeView1

            Application.DoEvents() 
            If .TreeView1.Nodes.Count <> 0 Then 
                .TopMost = gbooAlwaysOnTop 
                .ShowDialog()
                If .TopicCode <> "" Then
                    lcurDocumentView = DocumentViews.NormalTopic
                    SelectNodeByTag(.TopicCode, TreeView1)
                    lstrCurTopicCode = TreeView1.SelectedNode.Tag

                    Dim lstrTemplateFileName, lstrFormData As String
                    Dim lbooSysTemplate As Boolean

                    lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
                        lstrTemplateFileName, lbooSysTemplate, lstrFormData)
                    lbooRTFContentsChanged = False

                    If lstrTemplateFileName <> "" Then
                        If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
                        ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
                        lcurDocumentView = DocumentViews.NormalTopic
                    End If
                End If
            Else 
                MessageBox.Show(LangText.GetString("Pad_NoResults"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 
            End If 

        End With
        tbCoolbar.Bands(tbBand.Search).Buttons(5).Text = SearchCaption
        cboSearchTool.Enabled = True 

    End Sub
    Private Sub mnuViewToolbar1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbar1.Click

        If tbCoolbar.Size.Height = 0 Then tbCoolbar.Height = 34
        mnuViewToolbar1.Checked = Not mnuViewToolbar1.Checked
        tbCoolbar.Bands(tbBand.Standard).Visible = mnuViewToolbar1.Checked
        tbCoolbar.Invalidate()
        tbCoolbar.StandardReset()
    End Sub
    Private Sub mnuViewToolbar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbar2.Click

        If tbCoolbar.Size.Height = 0 Then tbCoolbar.Height = 34
        mnuViewToolbar2.Checked = Not mnuViewToolbar2.Checked
        tbCoolbar.Bands(tbBand.Branch).Visible = mnuViewToolbar2.Checked
        tbCoolbar.Invalidate()
        tbCoolbar.StandardReset()


    End Sub
    Private Sub mnuViewToolbar3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbar3.Click

        If tbCoolbar.Size.Height = 0 Then tbCoolbar.Height = 34
        mnuViewToolbar3.Checked = Not mnuViewToolbar3.Checked
        tbCoolbar.Bands(tbBand.Font).Visible = mnuViewToolbar3.Checked
        tbCoolbar.Invalidate()
        tbCoolbar.StandardReset()

    End Sub
    Private Sub mnuViewToolbar4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbar4.Click

        If tbCoolbar.Size.Height = 0 Then tbCoolbar.Height = 34
        mnuViewToolbar4.Checked = Not mnuViewToolbar4.Checked
        tbCoolbar.Bands(tbBand.Search).Visible = mnuViewToolbar4.Checked
        tbCoolbar.Invalidate()
        tbCoolbar.StandardReset()

    End Sub
    Private Sub mnuViewToolbarReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbarReset.Click
        'added 
        tbCoolbar.ResetBandPositions()

        If tbCoolbar.Height = 0 Then tbCoolbar.Height = 34
        Dim i As Integer
        For i = 0 To 3
            If tbCoolbar.Bands(i).Visible = False Then tbCoolbar.Bands(i).Visible = True
        Next

        mnuViewToolbar1.Checked = True
        mnuViewToolbar2.Checked = True
        mnuViewToolbar3.Checked = True
        mnuViewToolbar4.Checked = True

        tbCoolbar.cntVisibility.MenuItems(0).Checked = True
        tbCoolbar.cntVisibility.MenuItems(1).Checked = True
        tbCoolbar.cntVisibility.MenuItems(2).Checked = True
        tbCoolbar.cntVisibility.MenuItems(3).Checked = True

        tbCoolbar.StandardReset()
        '''''

    End Sub

    Private Sub mnuFormat_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormat.Popup

        Dim lbooEnabled As Boolean

        If RichTextBox1.Visible = True And lcurDocumentView = DocumentViews.NormalTopic Then
            lbooEnabled = True
        Else
            'is this correct?
            'TODO: Test mnuFormat_Popup
            lbooEnabled = False
        End If

        mnuFormatFont.Enabled = lbooEnabled
        mnuFormatBackground.Enabled = lbooEnabled
        mnuFormatChangeCase.Enabled = lbooEnabled
        mnuFormatChangeCaseUpper.Enabled = lbooEnabled
        mnuFormatChangeCaseLower.Enabled = lbooEnabled
        mnuFormatChangeCaseProper.Enabled = lbooEnabled

    End Sub
    Private Sub mnuInsert_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsert.Popup
        Dim lbooEnabled As Boolean

        If RichTextBox1.Visible = True And lcurDocumentView = DocumentViews.NormalTopic Then
            lbooEnabled = True
        Else
            'is this correct?
            'TODO: Test mnuInsert_Popup
            lbooEnabled = False
        End If

        mnuInsertDateTime.Enabled = lbooEnabled
        mnuInsertSymbol.Enabled = lbooEnabled
        mnuInsertBullets.Enabled = lbooEnabled

        mnuInsertGraphics.Enabled = lbooEnabled
        mnuInsertTable.Enabled = lbooEnabled 
        mnuInsertLinkToFile.Enabled = lbooEnabled
        mnuInsertHyperlink.Enabled = lbooEnabled
        mnuInsertQuickLink.Enabled = lbooEnabled

    End Sub
    Private Sub mnuView_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuView.Popup
        Dim lbooEnabled As Boolean

        mnuViewWordWrap.Checked = lbooRTFWordWrap
        mnuViewAlwaysOnTop.Checked = gbooAlwaysOnTop

        'Console.WriteLine("mnuView_Popup RichTextBox1.Visible=" & RichTextBox1.Visible & "lcurDocumentView=" & lcurDocumentView.ToString)
        If RichTextBox1.Visible = True And lcurDocumentView = DocumentViews.NormalTopic Then
            lbooEnabled = True
        Else
            'is this correct?
            'TODO: Test mnuView_Popup
            lbooEnabled = False
        End If

        mnuViewToolbar1.Checked = tbCoolbar.Bands(tbBand.Standard).Visible 
        mnuViewToolbar2.Checked = tbCoolbar.Bands(tbBand.Branch).Visible 
        mnuViewToolbar3.Checked = tbCoolbar.Bands(tbBand.Font).Visible 
        mnuViewToolbar4.Checked = tbCoolbar.Bands(tbBand.Search).Visible 

        mnuViewWordWrap.Enabled = lbooEnabled

    End Sub
    Private Sub mnuViewWordWrap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewWordWrap.Click
        

        If RichTextBox1.Visible = True And lcurDocumentView = DocumentViews.NormalTopic Then
            If lbooRTFWordWrap = True Then
                lbooRTFWordWrap = False
                'tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = False 
                tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = True 
            Else
                lbooRTFWordWrap = True
                'tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = True 
                tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = False 
            End If

            RichTextBox1.WordWrap = lbooRTFWordWrap 'put back in
            ' SetWordWrap(RichTextBox1, lbooRTFWordWrap) 
        End If

    End Sub
    Private Sub mnuViewAlwaysOnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewAlwaysOnTop.Click

        gbooAlwaysOnTop = Not gbooAlwaysOnTop
        AlwaysOnTop(Me, gbooAlwaysOnTop)

    End Sub
    Private Sub mnuInsertDateTime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertDateTime.Click

        AddDebugComment("frmPad.mnuInsertDateTime_Click") 

        
        Application.DoEvents()
        Dim dt As New DateAndTime()
        dt.Owner = Me 
        dt.TopMost = gbooAlwaysOnTop 
        dt.ShowDialog()
        If dt.ReturnDate <> "" Then
            'RichTextBox1.SelectedText = dt.ReturnDate
            LineChecker(dt.ReturnDate, RichTextBox1) 
        End If

    End Sub
    Private Sub mnuInsertSymbol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertSymbol.Click

        AddDebugComment("frmPad.mnuInsertSymbol_Click") 

        
        Application.DoEvents()
        Dim sy As New Symbol(gbooAlwaysOnTop)
        sy.Owner = Me 
        sy.TopMost = gbooAlwaysOnTop 
        sy.ShowDialog()
        If sy.ReturnChar <> "" Then
            'RichTextBox1.SelectionFont = New Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, FontStyle.Regular)

            Try 
                RichTextBox1.SelectionFont = New System.Drawing.Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, _
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Catch
                Try
                    RichTextBox1.SelectionFont = New System.Drawing.Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, _
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                Catch
                    Try
                        RichTextBox1.SelectionFont = New System.Drawing.Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, _
                                       System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                    Catch
                        Try
                            RichTextBox1.SelectionFont = New System.Drawing.Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, _
                                           System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                        Catch
                            Try
                                RichTextBox1.SelectionFont = New System.Drawing.Font(sy.ReturnFont, RichTextBox1.SelectionFont.Size, _
                                               System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                            Catch

                                MessageBox.Show(LangText.GetString("Pad_UnexpectedErrorOccured")) 
                                'MessageBox.Show("There was an unexpected Error!")
                            End Try
                        End Try
                    End Try
                End Try
            End Try






            RichTextBox1.SelectedText = sy.ReturnChar
        End If

    End Sub
    Private Sub mnuInsertBullets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertBullets.Click
        
        If RichTextBox1.SelectionBullet = True Then
            RichTextBox1.SelectionBullet = False
        Else
            RichTextBox1.SelectionBullet = True
        End If

    End Sub
    Private Sub mnuInsertGraphics_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertGraphics.Click
        
        AddDebugComment("frmPad.mnuInsertGraphics_Click")

        Application.DoEvents() 

        Dim OpenFileDialog1 As New OpenFileDialog()

        Dim lstrFileName As String
        With OpenFileDialog1
            .Filter = LangText.GetString("Pad_GraphicFilter")
            .RestoreDirectory = True 
            .ShowDialog()
            lstrFileName = .FileName
        End With

        If lstrFileName = "" Then Exit Sub

        Try
            BusyPad(Me, True) 
            Dim fs As FileStream = New FileStream(lstrFileName, FileMode.Open, FileAccess.Read)
            Dim img As System.Drawing.Bitmap = New System.Drawing.Bitmap(fs)
            fs.Close()

            'RichTextBox1.InsertImage(img)
            
            RichTextBox1.InsertImage(img, ProgresPanel)
            BusyPad(Me, False) 
        Catch
            BusyPad(Me, False) 
            MessageBox.Show(LangText.GetString("Pad_ImageError").Replace("[CR2]", Environment.NewLine & Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
        End Try

        RefreshCutCopyPaste(False) 
    End Sub
    Private Sub mnuInsertLinkToFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertLinkToFile.Click

        AddDebugComment("frmPad.mnuInsertLinkToFile_Click") 

        
        Application.DoEvents()
        Dim ltf As New LinkToFile()
        ltf.Owner = Me 
        ltf.TopMost = gbooAlwaysOnTop 
        ltf.ShowDialog()
        If ltf.ReturnFile <> "" Then
            LineChecker(ltf.ReturnFile, RichTextBox1) 

        End If
    End Sub

    Private Sub mnuInsertHyperlink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertHyperlink.Click

        AddDebugComment("frmPad.mnuInsertHyperlink_Click") 

        
        Application.DoEvents()
        Dim iu As New InsertUrl()
        iu.Owner = Me 
        iu.TopMost = gbooAlwaysOnTop 
        iu.ShowDialog()
        If iu.ReturnURL <> "" Then
            'RichTextBox1.SelectedText = iu.ReturnURL
            LineChecker(iu.ReturnURL, RichTextBox1) 
        End If

    End Sub
    Private Sub mnuInsertQuickLink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInsertQuickLink.Click

        AddDebugComment("frmPad.mnuInsertQuickLink_Click") 

        
        Application.DoEvents()
        Dim il As New InternalLink()
        il.Owner = Me 
        il.TreeviewSelect = TreeView1 
        Dim Res As New IPIconsPack.Resource() 
        il.ImageListSelect = Res.ilTreeIcons 
        il.TopMost = gbooAlwaysOnTop 
        il.ShowDialog()
        If il.InternalLink <> "" Then
            'RichTextBox1.SelectedText = il.InternalLink
            LineChecker(il.InternalLink, RichTextBox1) 
        End If

    End Sub
    Private Sub mnuFormatFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatFont.Click
        mnuRTFFont_Click(Nothing, Nothing) 
    End Sub
    Private Sub mnuFormatBackground_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatBackground.Click

        AddDebugComment("frmPad.mnuFormatBackground_Click") 

        
        Application.DoEvents()
        With ColorDialog1
            Dim StartColor As Color
            StartColor = RichTextBox1.BackColor
            .Color = RichTextBox1.BackColor

            Application.DoEvents()

            .ShowDialog()
            RichTextBox1.BackColor = .Color
            If Color.op_Inequality(.Color, StartColor) Then
                lbooRTFContentsChanged = True
            End If
        End With

    End Sub
    Private Sub mnuFormatChangeCaseUpper_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatChangeCaseUpper.Click
        
        Application.DoEvents()
        CaseChange(RichTextBox1, GeneralRTFUI.CaseType.Upper, RichTextBox2)
    End Sub
    Private Sub mnuFormatChangeCaseLower_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatChangeCaseLower.Click
        
        Application.DoEvents()
        CaseChange(RichTextBox1, GeneralRTFUI.CaseType.Lower, RichTextBox2)
    End Sub
    Private Sub mnuFormatChangeCaseProper_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatChangeCaseProper.Click
        
        Application.DoEvents()
        CaseChange(RichTextBox1, GeneralRTFUI.CaseType.Proper, RichTextBox2)
    End Sub
    Private Sub mnuFormatChangeCaseToggle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFormatChangeCaseToggle.Click
        
        Application.DoEvents()
        CaseChange(RichTextBox1, GeneralRTFUI.CaseType.Toggle, RichTextBox2)
    End Sub
    Private Sub mnuFileExportTXT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExportTXT.Click
        
        AddDebugComment("frmPad.mnuFileExportTXT_Click")
        AddCrashComment("#PMFETX1") 
        UpdateRTFToDB()

        Application.DoEvents()

        Dim SelectiveExport As New SelectivePrint()
        'SelectiveExport.FileTypeStreamType = RichTextBoxStreamType.PlainText

        SelectiveExport.FileTypeStreamType = SelectivePrint.SelectiveOutputType.PlainText 
        SelectiveExport.OutputType = SelectivePrint.OutputTypes.Export
        SelectiveExport.Disables = main.PopulateTreeDisables.DisableTemplateTopics 
        SelectiveExport.Owner = Me
        SelectiveExport.TopMost = gbooAlwaysOnTop 
        SelectiveExport.ShowDialog()
        ClearCrashReport() 

    End Sub
    Private Sub mnuFileImportTXT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileImportTXT.Click
        
        AddDebugComment("frmPad.mnuFileImportTXT_Click")
        AddCrashComment("#PMFITXC1") 
        BusyPad(Me, True)
        LoadFileToRtb(RichTextBoxStreamType.PlainText, RichTextBox1, NameMe(""), StatusBar1, TreeView1.SelectedNode.FullPath, gbooAlwaysOnTop, Me)
        BusyPad(Me, False)
        ClearCrashReport() 
    End Sub
    Private Sub cboSearchTool_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSearchTool.KeyDown

        If cboSearchTool.Text = SearchHistroy.DefaultText Then
            cboSearchTool.Text = ""
        End If

        If e.KeyCode = Keys.Enter Then
            SearchTool()
        End If

    End Sub
    Private Sub frmPad_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 

        
        If lbooLoadDataNow = False Then
            tbCoolbar.Invalidate()
            tbCoolbar.Bands(0).Invalidate()
            tbCoolbar.Bands(1).Invalidate()
            tbCoolbar.Bands(2).Invalidate()
            tbCoolbar.Bands(3).Invalidate()
        End If
        

    End Sub
    Private Sub TreeView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView1.KeyDown

        
        If e.KeyCode = Keys.Enter Then
            If lcurDocumentView = DocumentViews.MCLStartup And lbooDBAccOrUIAcc = False Then
                BusyPad(Me, True)
                Try
                    lstrCurTopicCode = TreeView1.SelectedNode.Tag
                    e.Handled = True
                    GetSelectedTreeTopic()
                Catch
                    '
                End Try
                BusyPad(Me, False)
            End If
        End If
        

    End Sub
    Private Sub GetSelectedTreeTopic()
        'added 
        Dim lstrTemplateFileName, lstrFormData As String
        Dim lbooSysTemplate As Boolean

        lstrCurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(lstrCurTopicCode), RichTextBox1, AxWebBrowser1, Me, _
            lstrTemplateFileName, lbooSysTemplate, lstrFormData)
        lbooRTFContentsChanged = False

        If lstrTemplateFileName <> "" Then
            If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
            ShowForm(lstrTemplateFileName, AxWebBrowser1, lbooSysTemplate)
        End If

        With RichTextBox1
            .ReadOnly = False
            .WordWrap = lbooRTFWordWrap
        End With

        If lbooRTFWordWrap = True Then
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = True 
        Else
            tbCoolbar.Bands(tbBand.Font).Buttons.Item(GetBtnIdx("Word Wrap", tbBand.Font)).Pushed = False 
        End If

        Try
            StatusBar1.Panels(0).Text = LangText.GetString("Pad_Viewing") & " - " & TreeView1.SelectedNode.FullPath
        Catch
            '
        End Try

        lcurDocumentView = DocumentViews.NormalTopic

    End Sub
    Function AddUserIcons(ByVal img As ImageList) As ImageList
        Dim UserDir As String = GetSettingsValue("UsrIconDir")

        If Directory.Exists(UserDir) = True Then
            Dim source As DirectoryInfo = New DirectoryInfo(UserDir)
            Dim files() As FileInfo = source.GetFiles
            Dim GraphicsFiles As New ArrayList()

            Dim pfile As FileInfo
            For Each pfile In files
                Select Case pfile.Extension.ToUpper
                    Case ".BMP", ".GIF", ".JPG", ".JPEG", ".PNG", ".ICO", ".EMF", ".WMF"
                        GraphicsFiles.Add(pfile.Name)
                End Select
            Next pfile

            GraphicsFiles.Sort()

            Dim item As String
            For Each item In GraphicsFiles
                Try
                    Dim ifile As Image = Image.FromFile(UserDir & "\" & item)
                    img.Images.Add(ifile)
                    'Console.WriteLine(item)
                Catch ex As Exception
                    MessageBox.Show(LangText.GetString("Pad_ProbWithUserIcons") & Environment.NewLine & _
                        Environment.NewLine & UserDir & "\" & item & _
                        Environment.NewLine & Environment.NewLine & ex.Message, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next item
        End If

        Return img

    End Function
    Private Sub mnuHelpReportProblem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpReportProblem.Click
        

        Application.DoEvents()

        Dim ErrRep As New ProbHand.BugReport(gbooAlwaysOnTop)
        With ErrRep

            AddDebugComment("<Font color=Blue>Manual Problem Report</font>")
            DebugDBComment()
            Application.DoEvents()
            .Caption = NameMe("")
            .SysStartTime = gdatSystemStart

            .FormIcon = New System.Drawing.Icon( _
                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
            .TopMost = gbooAlwaysOnTop 
            .ShowDialog()

        End With

    End Sub

    Private Sub mnuItemExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemExpandAll.Click
        mnuToolsExpandAll_Click(Nothing, Nothing) 
    End Sub

    Private Sub mnuItemCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemCollapseAll.Click
        mnuToolsCollapseAll_Click(Nothing, Nothing) 
    End Sub

    Private Sub mnuRTFRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTFRedo.Click

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        mnuEditRedo_Click(Nothing, Nothing) 

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub
    Private Sub SetFontStyle(Optional ByVal ChangeStyle As Integer = 0, Optional ByVal ChangeFont As String = Nothing, Optional ByVal ChangeFontSize As Single = 0)
        lbooDisableDragNDrop = True 

        RichTextBox1.Invalidate() 

        RichTextBox2.Rtf = ""
        RichTextBox2.Rtf = RichTextBox1.Rtf
        RichTextBox2.SelectionStart = RichTextBox1.SelectionStart
        RichTextBox2.SelectionLength = RichTextBox1.SelectionLength
        
        Dim Route As Integer = 0
        If Not ChangeFont Is Nothing Then
            Route = 1
        End If
        If ChangeFontSize > 0 Then
            If Route = 1 Then 
                Route = 3 
            Else 
                Route = 2
            End If 
        End If

        
        ProgresPanel.Maximum = RichTextBox2.SelectionLength
        ProgresPanel.Minimum = 0
        ProgresPanel.Value = 0
        Busy(Me, True) 
        

        Dim SelLength As Integer = RichTextBox2.SelectionLength
        Dim iSellength As Integer = RichTextBox2.SelectionLength ' required

        
        If RichTextBox2.SelectionBullet = True Then
            'then find the end of the line
            Dim NewLine As Integer = RichTextBox2.Text.IndexOf(Microsoft.VisualBasic.vbCrLf, SelLength)

            If NewLine > -1 Then
                'add to the line
                SelLength += NewLine
            End If

            If RichTextBox2.Text.Length > SelLength Then

                SelLength += (RichTextBox2.Text.Length - SelLength)

            End If

        End If

        

        Dim SelStart As Integer = RichTextBox2.SelectionStart
        Dim i As Integer
        Dim bBold, bItalic, bStrikeOut, bUnderline As Boolean
        Dim lbooDontUpdateCombo As Boolean = False 

        If RichTextBox2.SelectionLength = 0 Then 

            Dim cfont As Font = RichTextBox2.SelectionFont
            Select Case ChangeStyle
                Case 1 ' BOLD
                    If cfont.Bold = True Then
                        bBold = False
                    Else
                        bBold = True
                    End If
                Case 2 ' Italics
                    If cfont.Italic = True Then
                        bItalic = False
                    Else
                        bItalic = True
                    End If
                Case 3 'Strikeout
                    If cfont.Strikeout = True Then
                        bStrikeOut = False
                    Else
                        bStrikeOut = True
                    End If
                Case 4 'underline
                    If cfont.Underline = True Then
                        bUnderline = False
                    Else
                        bUnderline = True
                    End If
            End Select


            Select Case Route
                Case 1
                    Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont
                    Try
                        cfont = New Font(ChangeFont, currentFont.Size, currentFont.Style)
                    Catch
                    End Try
                    lbooDontUpdateCombo = True 
                Case 2
                    Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont
                    cfont = New Font(currentFont.FontFamily.Name, ChangeFontSize, currentFont.Style)
                Case 3 
                    Dim currentFont As System.Drawing.Font = RichTextBox2.SelectionFont 
                    cfont = New Font(ChangeFont, ChangeFontSize, currentFont.Style) 
            End Select

            Dim fs As FontStyle = cfont.Style
            Select Case ChangeStyle
                Case 1
                    If bBold = True Then
                        fs = fs Or FontStyle.Bold
                    Else
                        fs = fs And Not FontStyle.Bold
                    End If
                Case 2
                    If bItalic = True Then
                        fs = fs Or FontStyle.Italic
                    Else
                        fs = fs And Not FontStyle.Italic
                    End If
                Case 3
                    If bStrikeOut = True Then
                        fs = fs Or FontStyle.Strikeout
                    Else
                        fs = fs And Not FontStyle.Strikeout
                    End If
                Case 4
                    If bUnderline = True Then
                        fs = fs Or FontStyle.Underline
                    Else
                        fs = fs And Not FontStyle.Underline
                    End If
            End Select

            RichTextBox2.SelectionFont = New Font(cfont.FontFamily, cfont.Size, fs)

        Else


            Dim StartTime As Date = Date.Now 

            Dim iFirstLoop As Integer = 0
            Dim SelLenght As Integer = RichTextBox2.SelectionStart + RichTextBox2.SelectionLength

            'BULLETS BUG FIXED ! -------------------------------------------------------
            Dim Col As Integer = GetCharPos(SelLenght)
            If Col = 1 Then
                'If This is a new line, then we need to remove 1 from the lenght as we don't want to
                'be on this line really.

                SelLenght -= 1
            End If
            ' -----------------------------------------------------------------------------------

            For i = RichTextBox2.SelectionStart To SelLenght ' - 1 dont need this DN 11/07/2007

                SelectRange(RichTextBox2, i, 1)

                Dim cfont As Font = RichTextBox2.SelectionFont

                If iFirstLoop = 0 Then

                    Select Case ChangeStyle
                        Case 1 ' BOLD
                            If cfont.Bold = True Then
                                bBold = False
                            Else
                                bBold = True
                            End If
                        Case 2 ' Italics
                            If cfont.Italic = True Then
                                bItalic = False
                            Else
                                bItalic = True
                            End If
                        Case 3 'Strikeout
                            If cfont.Strikeout = True Then
                                bStrikeOut = False
                            Else
                                bStrikeOut = True
                            End If
                        Case 4 'underline
                            If cfont.Underline = True Then
                                bUnderline = False
                            Else
                                bUnderline = True
                            End If
                    End Select

                    'if changestyle = 0 then we ignore this as we are not changing the style
                    iFirstLoop = 1
                End If

                'Stops the program from crashing if cfont has nothing on it
                If Not cfont Is Nothing Then

                    Select Case Route
                        Case 1
                            Try
                                cfont = New Font(ChangeFont, cfont.Size, cfont.Style)
                            Catch
                                Console.WriteLine("Error")
                            End Try
                            lbooDontUpdateCombo = True
                        Case 2
                            cfont = New Font(cfont.FontFamily.Name, ChangeFontSize, cfont.Style)
                        Case 3 
                            
                            Try
                                cfont = New Font(ChangeFont, ChangeFontSize, cfont.Style)
                            Catch
                                Console.WriteLine("Error")
                            End Try
                            lbooDontUpdateCombo = True
                            
                    End Select

                    Dim fs As FontStyle = cfont.Style
                    Select Case ChangeStyle
                        Case 1
                            If bBold = True Then
                                fs = fs Or FontStyle.Bold
                            Else
                                fs = fs And Not FontStyle.Bold
                            End If
                        Case 2
                            If bItalic = True Then
                                fs = fs Or FontStyle.Italic
                            Else
                                fs = fs And Not FontStyle.Italic
                            End If
                        Case 3
                            If bStrikeOut = True Then
                                fs = fs Or FontStyle.Strikeout
                            Else
                                fs = fs And Not FontStyle.Strikeout
                            End If
                        Case 4
                            If bUnderline = True Then
                                fs = fs Or FontStyle.Underline
                            Else
                                fs = fs And Not FontStyle.Underline
                            End If
                    End Select

                    RichTextBox2.SelectionFont = New Font(cfont.FontFamily.Name, cfont.Size, fs)

                    
                    If DateDiffGet(strman.DateInterval.Second, StartTime, Date.Now) > 5 Then
                        System.Windows.Forms.Application.DoEvents()

                        StartTime = Date.Now
                    End If

                    ProgresPanel.Value = i - SelStart
                End If

            Next i

            RichTextBox2.Select(SelStart, iSellength) 'changed from SelLength


        End If 

        
        RichTextBox1.SelectedRtf = RichTextBox2.SelectedRtf
        RichTextBox1.SelectionFont = RichTextBox2.SelectionFont 
        RichTextBox2.Rtf = ""

        Me.RichTextBox1.Focus()

        ProgresPanel.Value = 0 
        Busy(Me, False) 

        RichTextBox1.Update() 
        RichTextBox1.ResumeLayout() 
        lbooDisableDragNDrop = False 

    End Sub
    Private Sub CheckNode()
        
        Dim pbool As Boolean
        If TreeView1.Nodes.Count > 0 Then
            pbool = True
        Else
            pbool = False
        End If

        'If Not TreeView1.SelectedNode Is Nothing Then
        '    pbool = True
        'Else
        '    pbool = False
        'End If

        tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Branch Properties", tbBand.Branch)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Move Up", tbBand.Branch)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Move Down", tbBand.Branch)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Move Top", tbBand.Branch)).Enabled = pbool
        tbCoolbar.Bands(tbBand.Branch).Buttons.Item(GetBtnIdx("Move Bottom", tbBand.Branch)).Enabled = pbool


    End Sub

    Private Sub SwapNodes(ByVal SelNode As TreeNode, ByVal OtherNode As TreeNode, Optional ByVal Up As Boolean = True)
        'added 
        'SwapNodes function takes three arguments
        '1. SelNode = Node that is right clicked/selected
        '2. OtherNode = Node that will be swapped (moved up/down) with SelNode
        '3. Up = Optional argument by default True so when function is called for 
        '       move branch down operation than and only than False should be passed.

        Dim SelInd, OtherInd, NewInd As Integer
        SelInd = SelNode.Index
        OtherInd = OtherNode.Index
        If SelNode.Parent Is Nothing Then
            TreeView1.Nodes.Remove(SelNode)
            TreeView1.Nodes.Remove(OtherNode)
            If Up Then 'Moves root node up
                NewInd = OtherInd
                TreeView1.Nodes.Insert(NewInd, OtherNode)
                TreeView1.Nodes.Insert(NewInd, SelNode)
            Else 'Moves root node down
                NewInd = SelInd
                TreeView1.Nodes.Insert(NewInd, SelNode)
                TreeView1.Nodes.Insert(NewInd, OtherNode)
            End If
        Else
            Dim Parent As TreeNode
            Parent = SelNode.Parent
            Parent.Nodes.Remove(SelNode)
            Parent.Nodes.Remove(OtherNode)
            If Up Then 'Moves selected node up
                NewInd = OtherInd
                Parent.Nodes.Insert(NewInd, OtherNode)
                Parent.Nodes.Insert(NewInd, SelNode)
            Else 'Moves selected node down
                NewInd = SelInd
                Parent.Nodes.Insert(NewInd, SelNode)
                Parent.Nodes.Insert(NewInd, OtherNode)
            End If
        End If
    End Sub

    Private Function GetCharPos() As Integer
        'added 

        Dim CharPos As Integer = RichTextBox1.SelectionStart
        Dim LineNo As Integer = RichTextBox1.GetLineFromCharIndex(CharPos)
        Dim Row As Integer = LineNo
        Dim Col As Integer = CharPos
        If Row = 0 Then
            Y = CharPos
            Return (CharPos + 1)
        Else
            While Row = LineNo
                Row = RichTextBox1.GetLineFromCharIndex(Col)
                Col -= 1
            End While
            Y = CharPos
            Return CharPos - Col - 1
        End If

    End Function

    Private Function GetCharPos(ByVal CharPos As Integer) As Integer
        'added 

        Dim LineNo As Integer = RichTextBox1.GetLineFromCharIndex(CharPos)
        Dim Row As Integer = LineNo
        Dim Col As Integer = CharPos
        If Row = 0 Then
            Y = CharPos
            Return (CharPos + 1)
        Else
            While Row = LineNo
                Row = RichTextBox1.GetLineFromCharIndex(Col)
                Col -= 1
            End While
            Y = CharPos
            Return CharPos - Col - 1
        End If

    End Function


    'Private Function ISNextCharNewLine() As Boolean
    '    'added 

    '    Dim NewY As Integer

    '    If Y + 1 < RichTextBox1.TextLength Then
    '        RichTextBox1.Select(Y + 1, 1)
    '        NewY = GetCharPos()
    '        Y -= 1
    '        RichTextBox1.Select(Y - 1, 1)
    '        If NewY = 1 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End If

    'End Function

    'Private Function IsNextCharTab() As Boolean

    '    'added 

    '    Dim NextY As Integer
    '    If Y < RichTextBox1.TextLength Then
    '        If RichTextBox1.Text.Substring(Y, 1) <> "    " Then
    '            Return True
    '        End If
    '    End If
    '    Return False
    'End Function

    Private Sub RichTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyUp
        AddDebugComment("frmPad.RichTextBox1_KeyUp - Start") 

        Dim tmp As Integer = GetCharPos()
        If tmp = 1 Then keyEnter = True ''''Newly Added Line
        AddDebugComment("frmPad.RichTextBox1_KeyUp - End") 

    End Sub

    Public Sub LineChecker(ByVal strLine As String, ByVal rtbField As WinOnly.ExRichTextBox)
        
        Dim ClipBoardObject As IDataObject
        Dim nClipboard As New DataObject()

        ClipBoardObject = Clipboard.GetDataObject()

        Dim i As Integer
        Dim str As String
        For Each str In ClipBoardObject.GetFormats
            nClipboard.SetData(str, ClipBoardObject.GetData(str))
        Next


        'find the point where the user clicks in the rtb
        Dim txtStart As Integer = rtbField.SelectionStart
        Dim txtSelectionEnd As Integer = rtbField.SelectionLength

        '--- 'changed ---
        Dim fcha As Char
        Dim echa As Char
        Try
            'If its not at the begining and not at the end, then its in the middle
            fcha = Convert.ToString(rtbField.GetCharFromPosition(rtbField.GetPositionFromCharIndex(txtStart - 1)))
            echa = Convert.ToString(rtbField.GetCharFromPosition(rtbField.GetPositionFromCharIndex(txtStart)))
            '
            'If not a new line (with nothing before it)
            If txtStart - 1 >= 0 Then
                If fcha.ToString <> Microsoft.VisualBasic.vbLf Then
                    ' if whatever came before is not a space, then make one
                    If fcha.ToString <> " " Then
                        strLine = " " + strLine
                    End If
                End If
            End If

            'do the same, but for the end of the line
            If echa.ToString <> " " Then
                strLine = strLine + " "
            End If

        Catch ex As Exception
            'if it failed then we need to make it work

            strLine = strLine + " "
        End Try
        '--- 'changed ---

        Clipboard.SetDataObject(strLine)
        rtbField.Paste()

        Clipboard.SetDataObject(ClipBoardObject)
    End Sub

    Private Sub mnuTools_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTools.Popup

        
        If lcurDocumentView = DocumentViews.MCLStartup Then
            mnuToolsSpelling.Enabled = False
        Else
            mnuToolsSpelling.Enabled = True
        End If
        

    End Sub

    Private Sub mnuBookmarks_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBookmarks.Popup

        
        If lcurDocumentView = DocumentViews.MCLStartup Then
            mnuBookmarksAdd.Enabled = False
            mnuBookmarksRemove.Enabled = False
        Else
            mnuBookmarksAdd.Enabled = True
            mnuBookmarksRemove.Enabled = True
        End If
        
    End Sub

    Private Sub mnuEdit_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.Popup

        
        If lcurDocumentView = DocumentViews.MCLStartup Then
            mnuEditSelectAll.Enabled = False
        Else
            mnuEditSelectAll.Enabled = True
        End If
        

    End Sub

    Private Sub ContextMenuRTFRightClick_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuRTFRightClick.Popup

        
        If IfRTFImage(RichTextBox1) = True Then
            'MessageBox.Show("Image has been clicked!")
            Dim picWidth As Integer
            Dim picHeight As Integer
            Dim GetImg As New GetRTBImage()
            GetImg.FindMetafiles(RichTextBox1, Nothing, Nothing)

            RTFConMenuSelStart = RichTextBox1.SelectionStart 
            RTFConMenuSelLength = RichTextBox1.SelectionLength 
            RichTextBox1.SelectionLength = 0 

            If GetImg.Pictures Is Nothing Then
                mnuRTFEditTable.Enabled = False
                mnuRTFEditTable.Text = LangText.GetString("Pad_TlbrTipInsertTable")
            Else
                If GetImg.Pictures.Length > 0 Then
                    'Dim ImgID As Integer
                    'ImgID = GetIDFromMetafile(GetImg, picWidth, picHeight)
                    'If ImgID <> -1 Then
                    mnuRTFEditTable.Enabled = True
                    mnuRTFEditTable.Text = LangText.GetString("Pad_mnuRTFEditTable")
                    'Else
                    '    mnuRTFEditTable.Enabled = False
                    '    'you could add edit picture here
                    'End If
                Else
                    mnuRTFEditTable.Enabled = False
                    mnuRTFEditTable.Text = LangText.GetString("Pad_TlbrTipInsertTable")
                End If
            End If
        Else
            mnuRTFEditTable.Enabled = True
            mnuRTFEditTable.Text = LangText.GetString("Pad_TlbrTipInsertTable")
        End If
        

    End Sub

    Private Sub mnuRTFEditTable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRTFEditTable.Click

        AddDebugComment("frmPad.mnuRTFEditTable_Click - start") 
        Dim tbe As TableEditor.MainTableEditor
        Dim imagID As Long

        RichTextBox1.SelectionStart = RTFConMenuSelStart 
        RichTextBox1.SelectionLength = RTFConMenuSelLength 

        If mnuRTFEditTable.Text = LangText.GetString("Pad_mnuRTFEditTable") Then

            imagID = GetImageIDForCurrentRTFSelection(RichTextBox1)

            If imagID <> -1 Then

                Dim Instructs As String = GetTabeDetailRec(imagID)
                If Instructs = "NONE" Then
                    MessageBox.Show("You can't edit this its not a table!")
                    RichTextBox1.SelectionStart = RTFConMenuSelStart
                    RichTextBox1.SelectionLength = 0
                    RTFConMenuSelStart = 0
                    RTFConMenuSelLength = 0
                    Exit Sub
                ElseIf Instructs <> "" Then
                    tbe = New TableEditor.MainTableEditor(Instructs)
                End If
            Else
                MessageBox.Show("You can't edit this its not a table!")
                RichTextBox1.SelectionStart = RTFConMenuSelStart
                RichTextBox1.SelectionLength = 0
                RTFConMenuSelStart = 0
                RTFConMenuSelLength = 0
                Exit Sub
            End If
        Else

            tbe = New TableEditor.MainTableEditor() 'insert new
        End If

        With tbe
            SetBasicTableEditorProperties(tbe, RichTextBox1)
            .Owner = Me

            If (.ShowDialog() = DialogResult.OK) Then
                UpdateTableDetailsRec(imagID, ReturnTrueTopicStr(lstrCurTopicCode), .GetHTML, .GetPlainText)

                Dim retImage As Image

                retImage = .GetImage("T" & imagID) 

                RichTextBox1.InsertImage(retImage, ProgresPanel)
            End If
        End With

        RichTextBox1.SelectionStart = RTFConMenuSelStart
        RichTextBox1.SelectionLength = 0
        RTFConMenuSelStart = 0
        RTFConMenuSelLength = 0

    End Sub

    Private Sub mnuInsertTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertTable.Click

        AddDebugComment("frmPad.mnuInsertTable_Click - start") 

        Dim tbe As TableEditor.MainTableEditor

        tbe = New TableEditor.MainTableEditor() 'insert new

        With tbe
            SetBasicTableEditorProperties(tbe, RichTextBox1)
            .Owner = Me


            If (.ShowDialog() = DialogResult.OK) Then
                'add new tableDetail Record, or will this be an update as you have the TID ?
                Dim lintThisNewTID As Long = GetNextTID()
                AddNewTableDetailsRec(lintThisNewTID, ReturnTrueTopicStr(lstrCurTopicCode), .GetHTML, .GetPlainText)

                'set image ID
                Dim retImage As Image
                'MessageBox.Show("Image ID should be embeded and set to " & lintThisNewTID)
                '
                retImage = .GetImage("T" & lintThisNewTID) 
                'MessageBox.Show(lintThisNewTID, "E") 

                RichTextBox1.InsertImage(retImage, ProgresPanel)
            End If
        End With

    End Sub
End Class


