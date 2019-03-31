Public Class AddBookmark
    Inherits System.Windows.Forms.Form
    Dim mstrDBID As String
    Dim mstrCurrentTopic As String
    Dim mstrCaption As String
    Dim mstrImageListObj As ImageList
    Dim mstrHelpFile As String 
    Dim mstrHelpTopic As String 

    Dim LangText As System.Resources.ResourceManager = New _
       System.Resources.ResourceManager("RTFStand.RTFStand", _
       System.Reflection.Assembly.GetExecutingAssembly()) 

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
    Public Property Caption() As String
        Get

            Return mstrCaption
        End Get
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property
    Dim mstrAddText As String = "" 
    Public Property AddText() As String 
        Get
            Return mstrAddText
        End Get
        Set(ByVal Value As String)
            mstrAddText = Value
        End Set
    End Property
    Dim mbooTopMost As Boolean 
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pstrDBID As String, ByVal pstrCurrentTopic As String, ByVal pImageList As ImageList, ByVal pbooTopMost As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        mstrDBID = pstrDBID
        mstrCurrentTopic = pstrCurrentTopic
        mstrImageListObj = pImageList
        mbooTopMost = pbooTopMost 
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBookMarkName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents lblIconSelect As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblExtraIcons As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AddBookmark))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookMarkName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.lblIconSelect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblExtraIcons = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'txtBookMarkName
        '
        Me.txtBookMarkName.AccessibleDescription = CType(resources.GetObject("txtBookMarkName.AccessibleDescription"), String)
        Me.txtBookMarkName.AccessibleName = CType(resources.GetObject("txtBookMarkName.AccessibleName"), String)
        Me.txtBookMarkName.Anchor = CType(resources.GetObject("txtBookMarkName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtBookMarkName.AutoSize = CType(resources.GetObject("txtBookMarkName.AutoSize"), Boolean)
        Me.txtBookMarkName.BackgroundImage = CType(resources.GetObject("txtBookMarkName.BackgroundImage"), System.Drawing.Image)
        Me.txtBookMarkName.Dock = CType(resources.GetObject("txtBookMarkName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtBookMarkName.Enabled = CType(resources.GetObject("txtBookMarkName.Enabled"), Boolean)
        Me.txtBookMarkName.Font = CType(resources.GetObject("txtBookMarkName.Font"), System.Drawing.Font)
        Me.txtBookMarkName.ImeMode = CType(resources.GetObject("txtBookMarkName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtBookMarkName.Location = CType(resources.GetObject("txtBookMarkName.Location"), System.Drawing.Point)
        Me.txtBookMarkName.MaxLength = CType(resources.GetObject("txtBookMarkName.MaxLength"), Integer)
        Me.txtBookMarkName.Multiline = CType(resources.GetObject("txtBookMarkName.Multiline"), Boolean)
        Me.txtBookMarkName.Name = "txtBookMarkName"
        Me.txtBookMarkName.PasswordChar = CType(resources.GetObject("txtBookMarkName.PasswordChar"), Char)
        Me.txtBookMarkName.RightToLeft = CType(resources.GetObject("txtBookMarkName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtBookMarkName.ScrollBars = CType(resources.GetObject("txtBookMarkName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtBookMarkName.Size = CType(resources.GetObject("txtBookMarkName.Size"), System.Drawing.Size)
        Me.txtBookMarkName.TabIndex = CType(resources.GetObject("txtBookMarkName.TabIndex"), Integer)
        Me.txtBookMarkName.Text = resources.GetString("txtBookMarkName.Text")
        Me.txtBookMarkName.TextAlign = CType(resources.GetObject("txtBookMarkName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtBookMarkName.Visible = CType(resources.GetObject("txtBookMarkName.Visible"), Boolean)
        Me.txtBookMarkName.WordWrap = CType(resources.GetObject("txtBookMarkName.WordWrap"), Boolean)
        '
        'btnOK
        '
        Me.btnOK.AccessibleDescription = CType(resources.GetObject("btnOK.AccessibleDescription"), String)
        Me.btnOK.AccessibleName = CType(resources.GetObject("btnOK.AccessibleName"), String)
        Me.btnOK.Anchor = CType(resources.GetObject("btnOK.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Dock = CType(resources.GetObject("btnOK.Dock"), System.Windows.Forms.DockStyle)
        Me.btnOK.Enabled = CType(resources.GetObject("btnOK.Enabled"), Boolean)
        Me.btnOK.FlatStyle = CType(resources.GetObject("btnOK.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnOK.Font = CType(resources.GetObject("btnOK.Font"), System.Drawing.Font)
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = CType(resources.GetObject("btnOK.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnOK.ImageIndex = CType(resources.GetObject("btnOK.ImageIndex"), Integer)
        Me.btnOK.ImeMode = CType(resources.GetObject("btnOK.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnOK.Location = CType(resources.GetObject("btnOK.Location"), System.Drawing.Point)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = CType(resources.GetObject("btnOK.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnOK.Size = CType(resources.GetObject("btnOK.Size"), System.Drawing.Size)
        Me.btnOK.TabIndex = CType(resources.GetObject("btnOK.TabIndex"), Integer)
        Me.btnOK.Text = resources.GetString("btnOK.Text")
        Me.btnOK.TextAlign = CType(resources.GetObject("btnOK.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnOK.Visible = CType(resources.GetObject("btnOK.Visible"), Boolean)
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
        'AddBookmark
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblExtraIcons, Me.btnHelp, Me.Label2, Me.lblIconSelect, Me.Label3, Me.Panel1, Me.btnCancel, Me.btnOK, Me.txtBookMarkName, Me.Label1})
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
        Me.Name = "AddBookmark"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lbooNameAlreadyExists As Boolean = False

        
        Dim Shuffle As New SuffleGenericBookmarks()
        With Shuffle
            .DBID = mstrDBID
            .BookmarkType = SuffleGenericBookmarks.BookmarkTypes.Boomarks
            .Shuffle()
        End With
        Dim llngItemCount As Long
        

        If txtBookMarkName.Text <> "" Then
            Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID)
            llngItemCount = CLng(Val(InitialBookmarks.GetValue("ItemCount", "")))  
            Dim lintArrInc As Integer
            '--- Check to see if bookmarks exists already ---
            For lintArrInc = 0 To llngItemCount '19
                Dim lstrNewMenuItemText As String = InitialBookmarks.GetValue("BookmarkName-" & lintArrInc, "")
                If lstrNewMenuItemText.ToUpper = txtBookMarkName.Text.ToUpper Then
                    lbooNameAlreadyExists = True
                    Exit For
                End If
            Next lintArrInc
            If lbooNameAlreadyExists = True Then
                'MxessageBox.Show("You already have a bookmark with this name!", mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If mbooTopMost = True Then Me.Activate() 
                
                MessageBox.Show(LangText.GetString("AddBmrk_AlreadyHave"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '--- Check to see if bookmarks exists already ---
            '--- Get free items ---
            'Dim lintFreeItem As Integer = -1
            'For lintArrInc = 0 To llngItemCount ' 19
            '    xx()
            '    Dim lstrNewMenuItemText As String = InitialBookmarks.GetValue("BookmarkName-" & lintArrInc, "")
            '    If lstrNewMenuItemText.ToUpper = "" Then
            '        lintFreeItem = lintArrInc
            '        Exit For
            '    End If
            'Next lintArrInc
            ''--- Get free item ---
            'If lintFreeItem = -1 Then
            '    xx()
            '    MxessageBox.Show("You have 20 bookmarks, please remove any you don't use first!", mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            SaveSetting("BookmarkName-" & llngItemCount + 1, txtBookMarkName.Text, InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID)
            SaveSetting("Bookmarks-" & llngItemCount + 1, mstrCurrentTopic, InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID)
            'SaveSetting("BookmarkImgIdx-" & llngItemCount + 1, lblIconSelect.ImageIndex, InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID) 
            
            'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
            'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
            Dim lintImgTag As Integer = IPIconsPack.GetImgTag(lblIconSelect.ImageIndex)
            SaveSetting("BookmarkImgIdx-" & llngItemCount + 1, lintImgTag, InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID)
            

            SaveSetting("ItemCount", llngItemCount + 1, InitalXMLConfig.XmlConfigType.Bookmarks, mstrDBID) 
            Me.DialogResult = DialogResult.OK 
            Me.Close()
        Else
            If mbooTopMost = True Then Me.Activate() 
            'MxessageBox.Show("You must specify a name for your bookmark!", mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            MessageBox.Show(LangText.GetString("AddBmrk_MustSpecifyName"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtBookMarkName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBookMarkName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub AddBookmark_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        lblIconSelect.ImageIndex = e.Button.ImageIndex
    End Sub
    Private Sub AddBookmark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'commented out due to tom problem 
        ''Me.ShowInTaskbar = False 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        lblIconSelect.ImageList = mstrImageListObj
        ToolBar1.ImageList = mstrImageListObj
        lblIconSelect.ImageIndex = 0

        txtBookMarkName.Text = mstrAddText 

         
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
        End If
         

        
        If InStrGet(mstrCaption.ToUpper, "TRIAL") > 0 Then 
            Dim lintArrInc As Integer
            For lintArrInc = 16 To ToolBar1.ImageList.Images.Count '38
                ToolBar1.Buttons.Item(lintArrInc).Enabled = False
            Next lintArrInc
            lblExtraIcons.Visible = True
        End If
        

    End Sub
    Private Sub txtBookMarkName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookMarkName.KeyPress
        
        If e.KeyChar = CR() Then
            e.Handled = True
        End If
    End Sub
    Private Sub SetBackcolors()

        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor) 

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub
    Private Sub AddBookmark_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
    Private Sub ToolBar1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar1.DoubleClick

        
        btnOK_Click(Nothing, Nothing)
        

    End Sub
End Class
