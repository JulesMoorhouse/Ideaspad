Imports System.Xml
Public Class GenBookMarkMaint
    Inherits System.Windows.Forms.Form
    Dim mstrDBID As String
    Dim mstrImageListObj As ImageList
    Dim mstrBookMarkNameTag As String
    Dim mstrBookMarkRefTag As String
    Dim mstrBookMarkImgIdxTag As String
    Dim mstrBookMarkFileTag As String 
    'Dim mstrSection As String
    Dim mXMLConfigType As InitalXMLConfig.XmlConfigType
    Dim mInitialBookmarks As InitalXMLConfig
    Dim mstrHelpFile As String 
    Dim mstrHelpTopic As String 
    Dim lstrLoadedTextValue As String 
    Dim llngNewFormHeight As Long 
    Dim LangText As System.Resources.ResourceManager = New _
           System.Resources.ResourceManager("RTFStand.RTFStand", _
           System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim mstrCaption As String 
    Public Property Caption() As String
        Get

            Return mstrCaption
        End Get
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property
    Public Property HelpTopic() As String 
        Get

            Return mstrHelpTopic
        End Get
        Set(ByVal Value As String)
            mstrHelpTopic = Value
        End Set
    End Property
    Public Property HelpFile() As String 
        Get

            Return mstrHelpFile
        End Get
        Set(ByVal Value As String)
            mstrHelpFile = Value
        End Set
    End Property
    Enum BookmarkTypes
        Boomarks
        TemplateBookMarks
    End Enum
    Dim mBookmarkType As BookmarkTypes
    Public Property BookmarkType() As BookmarkTypes
        Get

            Return mBookmarkType
        End Get
        Set(ByVal Value As BookmarkTypes)
            mBookmarkType = Value
            Select Case mBookmarkType
                Case BookmarkTypes.Boomarks
                    mstrBookMarkNameTag = "BookmarkName-"
                    mstrBookMarkRefTag = "Bookmarks-"
                    mstrBookMarkImgIdxTag = "BookmarkImgIdx-"
                    mXMLConfigType = InitalXMLConfig.XmlConfigType.Bookmarks
                    mstrBookMarkFileTag = "" 
                    'mstrSection = "Bookmarks-"
                    'Me.Text = Me.Text & " (Topic Bookmarks)"
                    Me.Text = Me.Text & " (" & LangText.GetString("BookMaint_TitleTopicBooks") & ")"
                Case BookmarkTypes.TemplateBookMarks
                    mstrBookMarkNameTag = "Name"
                    mstrBookMarkRefTag = "ID"
                    mstrBookMarkImgIdxTag = "ImgIdx"
                    mstrBookMarkFileTag = "FileName" 
                    mXMLConfigType = InitalXMLConfig.XmlConfigType.TemplatesMenu
                    'mstrSection = "TemplatesMenu-"
                    'Me.Text = Me.Text & " (Templates)"
                    Me.Text = Me.Text & " (" & LangText.GetString("BookMaint_TitleTemplates") & ")"
            End Select

        End Set
    End Property
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pImageList As ImageList, ByVal pstrDBID As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        mstrImageListObj = pImageList
        mstrDBID = pstrDBID
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstBookMarks As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBookmarkName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents lblIconSelect As System.Windows.Forms.Label
    Friend WithEvents btnChangeIcon As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblExtraIcons As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GenBookMarkMaint))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBookMarks = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangeIcon = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookmarkName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIconSelect = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblExtraIcons = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = CType(resources.GetObject("btnCancel.AccessibleDescription"), String)
        Me.btnCancel.AccessibleName = CType(resources.GetObject("btnCancel.AccessibleName"), String)
        Me.btnCancel.Anchor = CType(resources.GetObject("btnCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        'btnRemove
        '
        Me.btnRemove.AccessibleDescription = CType(resources.GetObject("btnRemove.AccessibleDescription"), String)
        Me.btnRemove.AccessibleName = CType(resources.GetObject("btnRemove.AccessibleName"), String)
        Me.btnRemove.Anchor = CType(resources.GetObject("btnRemove.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.Dock = CType(resources.GetObject("btnRemove.Dock"), System.Windows.Forms.DockStyle)
        Me.btnRemove.Enabled = CType(resources.GetObject("btnRemove.Enabled"), Boolean)
        Me.btnRemove.FlatStyle = CType(resources.GetObject("btnRemove.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnRemove.Font = CType(resources.GetObject("btnRemove.Font"), System.Drawing.Font)
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = CType(resources.GetObject("btnRemove.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnRemove.ImageIndex = CType(resources.GetObject("btnRemove.ImageIndex"), Integer)
        Me.btnRemove.ImeMode = CType(resources.GetObject("btnRemove.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnRemove.Location = CType(resources.GetObject("btnRemove.Location"), System.Drawing.Point)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.RightToLeft = CType(resources.GetObject("btnRemove.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnRemove.Size = CType(resources.GetObject("btnRemove.Size"), System.Drawing.Size)
        Me.btnRemove.TabIndex = CType(resources.GetObject("btnRemove.TabIndex"), Integer)
        Me.btnRemove.Text = resources.GetString("btnRemove.Text")
        Me.btnRemove.TextAlign = CType(resources.GetObject("btnRemove.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnRemove.Visible = CType(resources.GetObject("btnRemove.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = CType(resources.GetObject("Label1.AccessibleDescription"), String)
        Me.Label1.AccessibleName = CType(resources.GetObject("Label1.AccessibleName"), String)
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'lstBookMarks
        '
        Me.lstBookMarks.AccessibleDescription = CType(resources.GetObject("lstBookMarks.AccessibleDescription"), String)
        Me.lstBookMarks.AccessibleName = CType(resources.GetObject("lstBookMarks.AccessibleName"), String)
        Me.lstBookMarks.Anchor = CType(resources.GetObject("lstBookMarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstBookMarks.BackgroundImage = CType(resources.GetObject("lstBookMarks.BackgroundImage"), System.Drawing.Image)
        Me.lstBookMarks.ColumnWidth = CType(resources.GetObject("lstBookMarks.ColumnWidth"), Integer)
        Me.lstBookMarks.Dock = CType(resources.GetObject("lstBookMarks.Dock"), System.Windows.Forms.DockStyle)
        Me.lstBookMarks.Enabled = CType(resources.GetObject("lstBookMarks.Enabled"), Boolean)
        Me.lstBookMarks.Font = CType(resources.GetObject("lstBookMarks.Font"), System.Drawing.Font)
        Me.lstBookMarks.HorizontalExtent = CType(resources.GetObject("lstBookMarks.HorizontalExtent"), Integer)
        Me.lstBookMarks.HorizontalScrollbar = CType(resources.GetObject("lstBookMarks.HorizontalScrollbar"), Boolean)
        Me.lstBookMarks.ImeMode = CType(resources.GetObject("lstBookMarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstBookMarks.IntegralHeight = CType(resources.GetObject("lstBookMarks.IntegralHeight"), Boolean)
        Me.lstBookMarks.ItemHeight = CType(resources.GetObject("lstBookMarks.ItemHeight"), Integer)
        Me.lstBookMarks.Location = CType(resources.GetObject("lstBookMarks.Location"), System.Drawing.Point)
        Me.lstBookMarks.Name = "lstBookMarks"
        Me.lstBookMarks.RightToLeft = CType(resources.GetObject("lstBookMarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstBookMarks.ScrollAlwaysVisible = CType(resources.GetObject("lstBookMarks.ScrollAlwaysVisible"), Boolean)
        Me.lstBookMarks.Size = CType(resources.GetObject("lstBookMarks.Size"), System.Drawing.Size)
        Me.lstBookMarks.TabIndex = CType(resources.GetObject("lstBookMarks.TabIndex"), Integer)
        Me.lstBookMarks.Visible = CType(resources.GetObject("lstBookMarks.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = CType(resources.GetObject("GroupBox1.AccessibleDescription"), String)
        Me.GroupBox1.AccessibleName = CType(resources.GetObject("GroupBox1.AccessibleName"), String)
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnChangeIcon, Me.Label4, Me.txtBookmarkName, Me.Label2, Me.lblIconSelect})
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'btnChangeIcon
        '
        Me.btnChangeIcon.AccessibleDescription = CType(resources.GetObject("btnChangeIcon.AccessibleDescription"), String)
        Me.btnChangeIcon.AccessibleName = CType(resources.GetObject("btnChangeIcon.AccessibleName"), String)
        Me.btnChangeIcon.Anchor = CType(resources.GetObject("btnChangeIcon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnChangeIcon.BackgroundImage = CType(resources.GetObject("btnChangeIcon.BackgroundImage"), System.Drawing.Image)
        Me.btnChangeIcon.Dock = CType(resources.GetObject("btnChangeIcon.Dock"), System.Windows.Forms.DockStyle)
        Me.btnChangeIcon.Enabled = CType(resources.GetObject("btnChangeIcon.Enabled"), Boolean)
        Me.btnChangeIcon.FlatStyle = CType(resources.GetObject("btnChangeIcon.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnChangeIcon.Font = CType(resources.GetObject("btnChangeIcon.Font"), System.Drawing.Font)
        Me.btnChangeIcon.Image = CType(resources.GetObject("btnChangeIcon.Image"), System.Drawing.Image)
        Me.btnChangeIcon.ImageAlign = CType(resources.GetObject("btnChangeIcon.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnChangeIcon.ImageIndex = CType(resources.GetObject("btnChangeIcon.ImageIndex"), Integer)
        Me.btnChangeIcon.ImeMode = CType(resources.GetObject("btnChangeIcon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnChangeIcon.Location = CType(resources.GetObject("btnChangeIcon.Location"), System.Drawing.Point)
        Me.btnChangeIcon.Name = "btnChangeIcon"
        Me.btnChangeIcon.RightToLeft = CType(resources.GetObject("btnChangeIcon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnChangeIcon.Size = CType(resources.GetObject("btnChangeIcon.Size"), System.Drawing.Size)
        Me.btnChangeIcon.TabIndex = CType(resources.GetObject("btnChangeIcon.TabIndex"), Integer)
        Me.btnChangeIcon.Text = resources.GetString("btnChangeIcon.Text")
        Me.btnChangeIcon.TextAlign = CType(resources.GetObject("btnChangeIcon.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnChangeIcon.Visible = CType(resources.GetObject("btnChangeIcon.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = CType(resources.GetObject("Label4.AccessibleDescription"), String)
        Me.Label4.AccessibleName = CType(resources.GetObject("Label4.AccessibleName"), String)
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'txtBookmarkName
        '
        Me.txtBookmarkName.AccessibleDescription = CType(resources.GetObject("txtBookmarkName.AccessibleDescription"), String)
        Me.txtBookmarkName.AccessibleName = CType(resources.GetObject("txtBookmarkName.AccessibleName"), String)
        Me.txtBookmarkName.Anchor = CType(resources.GetObject("txtBookmarkName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtBookmarkName.AutoSize = CType(resources.GetObject("txtBookmarkName.AutoSize"), Boolean)
        Me.txtBookmarkName.BackgroundImage = CType(resources.GetObject("txtBookmarkName.BackgroundImage"), System.Drawing.Image)
        Me.txtBookmarkName.Dock = CType(resources.GetObject("txtBookmarkName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtBookmarkName.Enabled = CType(resources.GetObject("txtBookmarkName.Enabled"), Boolean)
        Me.txtBookmarkName.Font = CType(resources.GetObject("txtBookmarkName.Font"), System.Drawing.Font)
        Me.txtBookmarkName.ImeMode = CType(resources.GetObject("txtBookmarkName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtBookmarkName.Location = CType(resources.GetObject("txtBookmarkName.Location"), System.Drawing.Point)
        Me.txtBookmarkName.MaxLength = CType(resources.GetObject("txtBookmarkName.MaxLength"), Integer)
        Me.txtBookmarkName.Multiline = CType(resources.GetObject("txtBookmarkName.Multiline"), Boolean)
        Me.txtBookmarkName.Name = "txtBookmarkName"
        Me.txtBookmarkName.PasswordChar = CType(resources.GetObject("txtBookmarkName.PasswordChar"), Char)
        Me.txtBookmarkName.RightToLeft = CType(resources.GetObject("txtBookmarkName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtBookmarkName.ScrollBars = CType(resources.GetObject("txtBookmarkName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtBookmarkName.Size = CType(resources.GetObject("txtBookmarkName.Size"), System.Drawing.Size)
        Me.txtBookmarkName.TabIndex = CType(resources.GetObject("txtBookmarkName.TabIndex"), Integer)
        Me.txtBookmarkName.Text = resources.GetString("txtBookmarkName.Text")
        Me.txtBookmarkName.TextAlign = CType(resources.GetObject("txtBookmarkName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtBookmarkName.Visible = CType(resources.GetObject("txtBookmarkName.Visible"), Boolean)
        Me.txtBookmarkName.WordWrap = CType(resources.GetObject("txtBookmarkName.WordWrap"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = CType(resources.GetObject("Label2.AccessibleDescription"), String)
        Me.Label2.AccessibleName = CType(resources.GetObject("Label2.AccessibleName"), String)
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'lblIconSelect
        '
        Me.lblIconSelect.AccessibleDescription = CType(resources.GetObject("lblIconSelect.AccessibleDescription"), String)
        Me.lblIconSelect.AccessibleName = CType(resources.GetObject("lblIconSelect.AccessibleName"), String)
        Me.lblIconSelect.Anchor = CType(resources.GetObject("lblIconSelect.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblIconSelect.AutoSize = CType(resources.GetObject("lblIconSelect.AutoSize"), Boolean)
        Me.lblIconSelect.BackColor = System.Drawing.Color.White
        Me.lblIconSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIconSelect.Dock = CType(resources.GetObject("lblIconSelect.Dock"), System.Windows.Forms.DockStyle)
        Me.lblIconSelect.Enabled = CType(resources.GetObject("lblIconSelect.Enabled"), Boolean)
        Me.lblIconSelect.Font = CType(resources.GetObject("lblIconSelect.Font"), System.Drawing.Font)
        Me.lblIconSelect.Image = CType(resources.GetObject("lblIconSelect.Image"), System.Drawing.Image)
        Me.lblIconSelect.ImageAlign = CType(resources.GetObject("lblIconSelect.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblIconSelect.ImageIndex = CType(resources.GetObject("lblIconSelect.ImageIndex"), Integer)
        Me.lblIconSelect.ImeMode = CType(resources.GetObject("lblIconSelect.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblIconSelect.Location = CType(resources.GetObject("lblIconSelect.Location"), System.Drawing.Point)
        Me.lblIconSelect.Name = "lblIconSelect"
        Me.lblIconSelect.RightToLeft = CType(resources.GetObject("lblIconSelect.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblIconSelect.Size = CType(resources.GetObject("lblIconSelect.Size"), System.Drawing.Size)
        Me.lblIconSelect.TabIndex = CType(resources.GetObject("lblIconSelect.TabIndex"), Integer)
        Me.lblIconSelect.Text = resources.GetString("lblIconSelect.Text")
        Me.lblIconSelect.TextAlign = CType(resources.GetObject("lblIconSelect.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblIconSelect.Visible = CType(resources.GetObject("lblIconSelect.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = CType(resources.GetObject("Panel1.AccessibleDescription"), String)
        Me.Panel1.AccessibleName = CType(resources.GetObject("Panel1.AccessibleName"), String)
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ToolBar1})
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
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'ToolBar1
        '
        Me.ToolBar1.AccessibleDescription = CType(resources.GetObject("ToolBar1.AccessibleDescription"), String)
        Me.ToolBar1.AccessibleName = CType(resources.GetObject("ToolBar1.AccessibleName"), String)
        Me.ToolBar1.Anchor = CType(resources.GetObject("ToolBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Appearance = CType(resources.GetObject("ToolBar1.Appearance"), System.Windows.Forms.ToolBarAppearance)
        Me.ToolBar1.AutoSize = CType(resources.GetObject("ToolBar1.AutoSize"), Boolean)
        Me.ToolBar1.BackgroundImage = CType(resources.GetObject("ToolBar1.BackgroundImage"), System.Drawing.Image)
        Me.ToolBar1.ButtonSize = CType(resources.GetObject("ToolBar1.ButtonSize"), System.Drawing.Size)
        Me.ToolBar1.Divider = False
        Me.ToolBar1.Dock = CType(resources.GetObject("ToolBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.ToolBar1.DropDownArrows = CType(resources.GetObject("ToolBar1.DropDownArrows"), Boolean)
        Me.ToolBar1.Enabled = CType(resources.GetObject("ToolBar1.Enabled"), Boolean)
        Me.ToolBar1.Font = CType(resources.GetObject("ToolBar1.Font"), System.Drawing.Font)
        Me.ToolBar1.ImeMode = CType(resources.GetObject("ToolBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ToolBar1.Location = CType(resources.GetObject("ToolBar1.Location"), System.Drawing.Point)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.RightToLeft = CType(resources.GetObject("ToolBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ToolBar1.ShowToolTips = CType(resources.GetObject("ToolBar1.ShowToolTips"), Boolean)
        Me.ToolBar1.Size = CType(resources.GetObject("ToolBar1.Size"), System.Drawing.Size)
        Me.ToolBar1.TabIndex = CType(resources.GetObject("ToolBar1.TabIndex"), Integer)
        Me.ToolBar1.TextAlign = CType(resources.GetObject("ToolBar1.TextAlign"), System.Windows.Forms.ToolBarTextAlign)
        Me.ToolBar1.Visible = CType(resources.GetObject("ToolBar1.Visible"), Boolean)
        Me.ToolBar1.Wrappable = CType(resources.GetObject("ToolBar1.Wrappable"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = CType(resources.GetObject("Label3.AccessibleDescription"), String)
        Me.Label3.AccessibleName = CType(resources.GetObject("Label3.AccessibleName"), String)
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'btnHide
        '
        Me.btnHide.AccessibleDescription = CType(resources.GetObject("btnHide.AccessibleDescription"), String)
        Me.btnHide.AccessibleName = CType(resources.GetObject("btnHide.AccessibleName"), String)
        Me.btnHide.Anchor = CType(resources.GetObject("btnHide.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackgroundImage = CType(resources.GetObject("btnHide.BackgroundImage"), System.Drawing.Image)
        Me.btnHide.Dock = CType(resources.GetObject("btnHide.Dock"), System.Windows.Forms.DockStyle)
        Me.btnHide.Enabled = CType(resources.GetObject("btnHide.Enabled"), Boolean)
        Me.btnHide.FlatStyle = CType(resources.GetObject("btnHide.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnHide.Font = CType(resources.GetObject("btnHide.Font"), System.Drawing.Font)
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.ImageAlign = CType(resources.GetObject("btnHide.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnHide.ImageIndex = CType(resources.GetObject("btnHide.ImageIndex"), Integer)
        Me.btnHide.ImeMode = CType(resources.GetObject("btnHide.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnHide.Location = CType(resources.GetObject("btnHide.Location"), System.Drawing.Point)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.RightToLeft = CType(resources.GetObject("btnHide.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnHide.Size = CType(resources.GetObject("btnHide.Size"), System.Drawing.Size)
        Me.btnHide.TabIndex = CType(resources.GetObject("btnHide.TabIndex"), Integer)
        Me.btnHide.Text = resources.GetString("btnHide.Text")
        Me.btnHide.TextAlign = CType(resources.GetObject("btnHide.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnHide.Visible = CType(resources.GetObject("btnHide.Visible"), Boolean)
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleDescription = CType(resources.GetObject("btnHelp.AccessibleDescription"), String)
        Me.btnHelp.AccessibleName = CType(resources.GetObject("btnHelp.AccessibleName"), String)
        Me.btnHelp.Anchor = CType(resources.GetObject("btnHelp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.Dock = CType(resources.GetObject("btnHelp.Dock"), System.Windows.Forms.DockStyle)
        Me.btnHelp.Enabled = CType(resources.GetObject("btnHelp.Enabled"), Boolean)
        Me.btnHelp.FlatStyle = CType(resources.GetObject("btnHelp.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnHelp.Font = CType(resources.GetObject("btnHelp.Font"), System.Drawing.Font)
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = CType(resources.GetObject("btnHelp.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnHelp.ImageIndex = CType(resources.GetObject("btnHelp.ImageIndex"), Integer)
        Me.btnHelp.ImeMode = CType(resources.GetObject("btnHelp.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnHelp.Location = CType(resources.GetObject("btnHelp.Location"), System.Drawing.Point)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.RightToLeft = CType(resources.GetObject("btnHelp.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnHelp.Size = CType(resources.GetObject("btnHelp.Size"), System.Drawing.Size)
        Me.btnHelp.TabIndex = CType(resources.GetObject("btnHelp.TabIndex"), Integer)
        Me.btnHelp.Text = resources.GetString("btnHelp.Text")
        Me.btnHelp.TextAlign = CType(resources.GetObject("btnHelp.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnHelp.Visible = CType(resources.GetObject("btnHelp.Visible"), Boolean)
        '
        'lblExtraIcons
        '
        Me.lblExtraIcons.AccessibleDescription = CType(resources.GetObject("lblExtraIcons.AccessibleDescription"), String)
        Me.lblExtraIcons.AccessibleName = CType(resources.GetObject("lblExtraIcons.AccessibleName"), String)
        Me.lblExtraIcons.Anchor = CType(resources.GetObject("lblExtraIcons.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblExtraIcons.AutoSize = CType(resources.GetObject("lblExtraIcons.AutoSize"), Boolean)
        Me.lblExtraIcons.BackColor = System.Drawing.Color.Yellow
        Me.lblExtraIcons.Dock = CType(resources.GetObject("lblExtraIcons.Dock"), System.Windows.Forms.DockStyle)
        Me.lblExtraIcons.Enabled = CType(resources.GetObject("lblExtraIcons.Enabled"), Boolean)
        Me.lblExtraIcons.Font = CType(resources.GetObject("lblExtraIcons.Font"), System.Drawing.Font)
        Me.lblExtraIcons.ForeColor = System.Drawing.Color.Red
        Me.lblExtraIcons.Image = CType(resources.GetObject("lblExtraIcons.Image"), System.Drawing.Image)
        Me.lblExtraIcons.ImageAlign = CType(resources.GetObject("lblExtraIcons.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblExtraIcons.ImageIndex = CType(resources.GetObject("lblExtraIcons.ImageIndex"), Integer)
        Me.lblExtraIcons.ImeMode = CType(resources.GetObject("lblExtraIcons.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblExtraIcons.Location = CType(resources.GetObject("lblExtraIcons.Location"), System.Drawing.Point)
        Me.lblExtraIcons.Name = "lblExtraIcons"
        Me.lblExtraIcons.RightToLeft = CType(resources.GetObject("lblExtraIcons.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblExtraIcons.Size = CType(resources.GetObject("lblExtraIcons.Size"), System.Drawing.Size)
        Me.lblExtraIcons.TabIndex = CType(resources.GetObject("lblExtraIcons.TabIndex"), Integer)
        Me.lblExtraIcons.Text = resources.GetString("lblExtraIcons.Text")
        Me.lblExtraIcons.TextAlign = CType(resources.GetObject("lblExtraIcons.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblExtraIcons.Visible = CType(resources.GetObject("lblExtraIcons.Visible"), Boolean)
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = CType(resources.GetObject("btnClose.AccessibleDescription"), String)
        Me.btnClose.AccessibleName = CType(resources.GetObject("btnClose.AccessibleName"), String)
        Me.btnClose.Anchor = CType(resources.GetObject("btnClose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = CType(resources.GetObject("btnClose.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClose.Enabled = CType(resources.GetObject("btnClose.Enabled"), Boolean)
        Me.btnClose.FlatStyle = CType(resources.GetObject("btnClose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnClose.Font = CType(resources.GetObject("btnClose.Font"), System.Drawing.Font)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = CType(resources.GetObject("btnClose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.ImageIndex = CType(resources.GetObject("btnClose.ImageIndex"), Integer)
        Me.btnClose.ImeMode = CType(resources.GetObject("btnClose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClose.Location = CType(resources.GetObject("btnClose.Location"), System.Drawing.Point)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = CType(resources.GetObject("btnClose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnClose.Size = CType(resources.GetObject("btnClose.Size"), System.Drawing.Size)
        Me.btnClose.TabIndex = CType(resources.GetObject("btnClose.TabIndex"), Integer)
        Me.btnClose.Text = resources.GetString("btnClose.Text")
        Me.btnClose.TextAlign = CType(resources.GetObject("btnClose.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.Visible = CType(resources.GetObject("btnClose.Visible"), Boolean)
        '
        'GenBookMarkMaint
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.lblExtraIcons, Me.btnHelp, Me.btnHide, Me.Label3, Me.Panel1, Me.GroupBox1, Me.lstBookMarks, Me.Label1, Me.btnCancel, Me.btnRemove})
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
        Me.Name = "GenBookMarkMaint"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub GenBookMarkMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'commented out due to tom problem 
        ''Me.ShowInTaskbar = False 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnRemove.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnChangeIcon.FlatStyle = FlatStyle.System
            btnHide.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnClose.FlatStyle = FlatStyle.System
        End If
        'GroupBox1.FlatStyle = FlatStyle.System 'Commented for transparency 
        

        SetBackcolors() 

        lblIconSelect.ImageList = mstrImageListObj
        ToolBar1.ImageList = mstrImageListObj

         
        Dim lintArrInc2 As Integer
        For lintArrInc2 = 0 To ToolBar1.ImageList.Images.Count
            Dim ToolBarButtonDyn As System.Windows.Forms.ToolBarButton
            ToolBarButtonDyn = New System.Windows.Forms.ToolBarButton()
            ToolBarButtonDyn.ImageIndex = lintArrInc2
            ToolBar1.Buttons.Add(ToolBarButtonDyn)
        Next lintArrInc2

        Const lintButtonsPerRow As Integer = 12
        Const lintButtonHeight As Integer = 22
        Dim lintToolbarHeight As Integer = (RoundUP(ToolBar1.ImageList.Images.Count / lintButtonsPerRow) * lintButtonHeight) - 89

        If lintToolbarHeight > 0 Then
            Me.Height = Me.Height + lintToolbarHeight
            'llngNewFormHeight = Me.Height
        End If
         
        llngNewFormHeight = Me.Height 


        
        If InStrGet(mstrCaption.ToUpper, "TRIAL") > 0 Then 
            Dim lintArrInc As Integer
            For lintArrInc = 16 To ToolBar1.ImageList.Images.Count '38
                ToolBar1.Buttons.Item(lintArrInc).Enabled = False
            Next lintArrInc
            'lblExtraIcons.Visible = True
            lblExtraIcons.Tag = "VISIBLE" 
        End If
        

        RefreshBookmarkList()

        'If lstBookMarks.Items.Count <> -1 Then
        If lstBookMarks.Items.Count <> 0 Then 
            lstBookMarks.SelectedIndex = 0
        End If


        
        If lstBookMarks.Items.Count < 1 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If
        

        'Me.Height = 232 ' 224
        Me.Height = 240 

    End Sub
    Sub RefreshBookmarkList()
        Dim lintArrInc As Integer

        mInitialBookmarks = New InitalXMLConfig(mXMLConfigType, mstrDBID)

        lstBookMarks.SuspendLayout()

        lstBookMarks.Items.Clear()
        With mInitialBookmarks
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            For lintArrInc = 0 To llngItemCount '19
                Dim lstrItem As String = .GetValue(mstrBookMarkNameTag & lintArrInc, "")
                If lstrItem <> "" Then
                    lstBookMarks.Items.Add(lstrItem)
                    'lintXMLItemNums(lintArrInc)
                End If
            Next lintArrInc
        End With

        lstBookMarks.ResumeLayout()

    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If lstBookMarks.Items.Count < 1 Then
            Exit Sub
        End If

        'Console.WriteLine("lstBookMarks.Items.Count=" & lstBookMarks.Items.Count)

        Me.Enabled = False


        RemoveBookMarks(mstrBookMarkNameTag, mstrDBID, mXMLConfigType, mstrBookMarkRefTag, mstrBookMarkImgIdxTag, mstrBookMarkFileTag)

        'Console.WriteLine("lstBookMarks.Items.Count=" & lstBookMarks.Items.Count)

        If lstBookMarks.Items.Count > 0 Then
            lstBookMarks.SelectedIndex = 0
        Else
            txtBookmarkName.Text = "" 
            lblIconSelect.ImageIndex = 0 
        End If

        
        If lstBookMarks.Items.Count < 1 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If
        
        Me.Enabled = True

        'Me.Close()
    End Sub
    Public Function RemoveBookMarks(ByVal m_mstrBookMarkNameTag As String, ByVal m_mstrDBID As String, ByVal m_mXMLConfigType As InitalXMLConfig.XmlConfigType, ByVal m_mstrBookMarkRefTag As String, ByVal m_mstrBookMarkImgIdxTag As String, ByVal m_mstrBookMarkFileTag As String, Optional ByVal NodeName As String = "")
        'new function created from remove button code
        Dim Shuffle As New SuffleGenericBookmarks()
        With Shuffle
            .DBID = m_mstrDBID
            .BookmarkType = m_mXMLConfigType
            .Shuffle()
        End With

        If NodeName = "" Then
            'if nodename is empty then we r accessing this from the bookmark form
            Dim li(0) As Object
            Dim Obj As Object
            For Each Obj In lstBookMarks.SelectedItems
                li((li).GetUpperBound(0)) = Obj
                ReDim Preserve li(li.Length)
            Next


            For Each Obj In li
                Dim lintArrInc As Integer

                With mInitialBookmarks
                    Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                    For lintArrInc = 0 To llngItemCount '19
                        If mInitialBookmarks.GetValue(m_mstrBookMarkNameTag & lintArrInc, "") Is Obj And Not Obj Is Nothing Then

                            SaveSetting(m_mstrBookMarkNameTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)
                            SaveSetting(m_mstrBookMarkRefTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)
                            SaveSetting(m_mstrBookMarkImgIdxTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)

                            If m_mstrBookMarkFileTag <> "" Then 
                                SaveSetting(m_mstrBookMarkFileTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID) 
                            End If
                            'Console.WriteLine(lintArrInc)
                            Exit For
                        End If
                    Next lintArrInc

                    SaveSetting("ItemCount", "", m_mXMLConfigType, m_mstrDBID)  
                    SaveSetting("ItemCount", llngItemCount - 1, m_mXMLConfigType, m_mstrDBID) 
                End With

                Try
                    lstBookMarks.Items.Remove(Obj)
                Catch ex As Exception
                    'not in the bookmark screen really
                End Try

            Next

        Else

            Dim lintArrInc As Integer
            mInitialBookmarks = New InitalXMLConfig(m_mXMLConfigType, m_mstrDBID)

            With mInitialBookmarks

                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", "")))  
                For lintArrInc = 0 To llngItemCount '19

                    If mInitialBookmarks.GetValue(m_mstrBookMarkRefTag & lintArrInc, "") = m_mstrBookMarkNameTag Then

                        SaveSetting(m_mstrBookMarkNameTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)
                        SaveSetting(m_mstrBookMarkRefTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)
                        SaveSetting(m_mstrBookMarkImgIdxTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID)

                        If m_mstrBookMarkFileTag <> "" Then 
                            SaveSetting(m_mstrBookMarkFileTag & lintArrInc, "", m_mXMLConfigType, m_mstrDBID) 
                        End If
                        'Console.WriteLine(lintArrInc)

                        Exit For

                    End If
                Next lintArrInc

                SaveSetting("ItemCount", "", m_mXMLConfigType, m_mstrDBID)  
                SaveSetting("ItemCount", llngItemCount - 1, m_mXMLConfigType, m_mstrDBID)  

            End With

        End If

        
        Dim Shuffle2 As New SuffleGenericBookmarks()
        With Shuffle2
            .DBID = m_mstrDBID
            .BookmarkType = m_mXMLConfigType
            .Shuffle()
        End With
        

    End Function

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub RemoveBookmark_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing) 
        End If

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, mstrHelpFile, HelpNavigator.Topic, mstrHelpTopic) 
    End Sub
    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        'Me.Height = 224
        'Me.Height = 232 
        Me.Height = 240 

        btnHide.Visible = False
        btnChangeIcon.Enabled = True 

        If lblExtraIcons.Tag = "VISIBLE" Then 
            lblExtraIcons.Visible = False 
        End If

    End Sub
    Private Sub btnChangeIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeIcon.Click
        'Me.Height = 408 ' 392
        Me.Height = llngNewFormHeight '440 

        btnHide.Visible = True 
        btnChangeIcon.Enabled = False 

        If lblExtraIcons.Tag = "VISIBLE" Then 
            lblExtraIcons.Visible = True 
        End If
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        lblIconSelect.ImageIndex = e.Button.ImageIndex
        'lstrBookMarkImgIdx = e.Button.ImageIndex
        Save()
    End Sub
    Private Sub lstBookMarks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBookMarks.SelectedIndexChanged
        If lstBookMarks.Items.Count = -1 Then
            Exit Sub
        End If

        Dim li(0) As Object
        Dim Obj As Object

        For Each Obj In lstBookMarks.SelectedItems
            li((li).GetUpperBound(0)) = Obj
            ReDim Preserve li(li.Length)
        Next

        For Each Obj In li
            Dim lintArrInc As Integer

            With mInitialBookmarks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", "")))  
                For lintArrInc = 0 To llngItemCount '19
                    If mInitialBookmarks.GetValue(mstrBookMarkNameTag & lintArrInc, "") Is Obj And Not Obj Is Nothing Then

                        txtBookmarkName.Text = mInitialBookmarks.GetValue(mstrBookMarkNameTag & lintArrInc, "")
                        txtBookmarkName.Tag = mInitialBookmarks.GetValue(mstrBookMarkRefTag & lintArrInc, "")
                        lstrLoadedTextValue = txtBookmarkName.Text 
                        Dim llngIconIdx As Long
                        Try
                            llngIconIdx = CLng(mInitialBookmarks.GetValue(mstrBookMarkImgIdxTag & lintArrInc, ""))
                        Catch
                            llngIconIdx = 0
                        End Try
                        
                        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                        llngIconIdx = IPIconsPack.GetImgIdx(llngIconIdx)
                        
                        lblIconSelect.ImageIndex = llngIconIdx

                        'Console.WriteLine(lintArrInc)
                        Exit For
                    End If
                Next lintArrInc
            End With
        Next Obj

    End Sub
    Private Sub Save()
        Dim KeptListPos As Long

        KeptListPos = lstBookMarks.SelectedIndex

        If lstBookMarks.Items.Count = -1 Then
            Exit Sub
        End If

        Me.SuspendLayout()
        'Me.Enabled = False

        Dim li(0) As Object
        Dim Obj As Object

        For Each Obj In lstBookMarks.SelectedItems
            li((li).GetUpperBound(0)) = Obj
            ReDim Preserve li(li.Length)
        Next

        For Each Obj In li
            Dim lintArrInc As Integer

            With mInitialBookmarks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                For lintArrInc = 0 To llngItemCount '19
                    If mInitialBookmarks.GetValue(mstrBookMarkNameTag & lintArrInc, "") Is Obj And Not Obj Is Nothing Then

                        'SaveSetting(mstrBookMarkNameTag & lintArrInc, txtBookmarkName.Text, mXMLConfigType, mstrDBID)
                        'SaveSetting(mstrBookMarkRefTag & lintArrInc, txtBookmarkName.Tag, mXMLConfigType, mstrDBID)
                        'SaveSetting(mstrBookMarkImgIdxTag & lintArrInc, lblIconSelect.ImageIndex, mXMLConfigType, mstrDBID)

                        
                        Dim xDoc As New XmlDocument()
                        Dim ConfigFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
                        xDoc.Load(ConfigFile)

                        BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, mstrDBID), mstrBookMarkNameTag & lintArrInc, txtBookmarkName.Text)
                        BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, mstrDBID), mstrBookMarkRefTag & lintArrInc, txtBookmarkName.Tag)
                        'BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, mstrDBID), mstrBookMarkImgIdxTag & lintArrInc, lblIconSelect.ImageIndex)
                        
                        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                        Dim lintImgTag As Integer = IPIconsPack.GetImgTag(lblIconSelect.ImageIndex)
                        BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, mstrDBID), mstrBookMarkImgIdxTag & lintArrInc, lintImgTag)
                        


                        xDoc.Save(ConfigFile)
                        xDoc = Nothing
                        

                        'Console.WriteLine(lintArrInc)
                        Exit For
                    End If
                Next lintArrInc
            End With
        Next Obj

        RefreshBookmarkList()

        
        'fix for denise, when she found an error after deleting an item
        If KeptListPos >= lstBookMarks.Items.Count Then
            KeptListPos = lstBookMarks.Items.Count - 1
        End If
        

        lstBookMarks.SelectedIndex = KeptListPos
        'Me.Enabled = True
        Me.ResumeLayout()

    End Sub
    Private Sub txtBookmarkName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBookmarkName.Leave

        If txtBookmarkName.Text <> lstrLoadedTextValue Then 
            Save() 
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close() 
    End Sub
    Sub SetBackcolors()

        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        GroupBox1.BackColor = Color.FromArgb(0, GroupBox1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        btnRemove.BackColor = Color.FromArgb(0, btnRemove.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnHide.BackColor = Color.FromArgb(0, btnHide.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub GenBookMarkMaint_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class