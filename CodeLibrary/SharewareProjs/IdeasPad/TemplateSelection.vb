Imports System.IO
Imports mshtml
Imports System.Xml
Friend Class TemplateSelection
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkAddToMenu As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSelection))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAddToMenu = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.AccessibleDescription = CType(resources.GetObject("ListBox1.AccessibleDescription"), String)
        Me.ListBox1.AccessibleName = CType(resources.GetObject("ListBox1.AccessibleName"), String)
        Me.ListBox1.Anchor = CType(resources.GetObject("ListBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackgroundImage = CType(resources.GetObject("ListBox1.BackgroundImage"), System.Drawing.Image)
        Me.ListBox1.ColumnWidth = CType(resources.GetObject("ListBox1.ColumnWidth"), Integer)
        Me.ListBox1.Dock = CType(resources.GetObject("ListBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox1.Enabled = CType(resources.GetObject("ListBox1.Enabled"), Boolean)
        Me.ListBox1.Font = CType(resources.GetObject("ListBox1.Font"), System.Drawing.Font)
        Me.ListBox1.HorizontalExtent = CType(resources.GetObject("ListBox1.HorizontalExtent"), Integer)
        Me.ListBox1.HorizontalScrollbar = CType(resources.GetObject("ListBox1.HorizontalScrollbar"), Boolean)
        Me.ListBox1.ImeMode = CType(resources.GetObject("ListBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox1.IntegralHeight = CType(resources.GetObject("ListBox1.IntegralHeight"), Boolean)
        Me.ListBox1.ItemHeight = CType(resources.GetObject("ListBox1.ItemHeight"), Integer)
        Me.ListBox1.Location = CType(resources.GetObject("ListBox1.Location"), System.Drawing.Point)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = CType(resources.GetObject("ListBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox1.ScrollAlwaysVisible = CType(resources.GetObject("ListBox1.ScrollAlwaysVisible"), Boolean)
        Me.ListBox1.Size = CType(resources.GetObject("ListBox1.Size"), System.Drawing.Size)
        Me.ListBox1.TabIndex = CType(resources.GetObject("ListBox1.TabIndex"), Integer)
        Me.ListBox1.Visible = CType(resources.GetObject("ListBox1.Visible"), Boolean)
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
        'btnSelect
        '
        Me.btnSelect.AccessibleDescription = CType(resources.GetObject("btnSelect.AccessibleDescription"), String)
        Me.btnSelect.AccessibleName = CType(resources.GetObject("btnSelect.AccessibleName"), String)
        Me.btnSelect.Anchor = CType(resources.GetObject("btnSelect.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackgroundImage = CType(resources.GetObject("btnSelect.BackgroundImage"), System.Drawing.Image)
        Me.btnSelect.Dock = CType(resources.GetObject("btnSelect.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSelect.Enabled = CType(resources.GetObject("btnSelect.Enabled"), Boolean)
        Me.btnSelect.FlatStyle = CType(resources.GetObject("btnSelect.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnSelect.Font = CType(resources.GetObject("btnSelect.Font"), System.Drawing.Font)
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.ImageAlign = CType(resources.GetObject("btnSelect.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnSelect.ImageIndex = CType(resources.GetObject("btnSelect.ImageIndex"), Integer)
        Me.btnSelect.ImeMode = CType(resources.GetObject("btnSelect.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSelect.Location = CType(resources.GetObject("btnSelect.Location"), System.Drawing.Point)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = CType(resources.GetObject("btnSelect.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSelect.Size = CType(resources.GetObject("btnSelect.Size"), System.Drawing.Size)
        Me.btnSelect.TabIndex = CType(resources.GetObject("btnSelect.TabIndex"), Integer)
        Me.btnSelect.Text = resources.GetString("btnSelect.Text")
        Me.btnSelect.TextAlign = CType(resources.GetObject("btnSelect.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnSelect.Visible = CType(resources.GetObject("btnSelect.Visible"), Boolean)
        '
        'ListBox2
        '
        Me.ListBox2.AccessibleDescription = CType(resources.GetObject("ListBox2.AccessibleDescription"), String)
        Me.ListBox2.AccessibleName = CType(resources.GetObject("ListBox2.AccessibleName"), String)
        Me.ListBox2.Anchor = CType(resources.GetObject("ListBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackgroundImage = CType(resources.GetObject("ListBox2.BackgroundImage"), System.Drawing.Image)
        Me.ListBox2.ColumnWidth = CType(resources.GetObject("ListBox2.ColumnWidth"), Integer)
        Me.ListBox2.Dock = CType(resources.GetObject("ListBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox2.Enabled = CType(resources.GetObject("ListBox2.Enabled"), Boolean)
        Me.ListBox2.Font = CType(resources.GetObject("ListBox2.Font"), System.Drawing.Font)
        Me.ListBox2.HorizontalExtent = CType(resources.GetObject("ListBox2.HorizontalExtent"), Integer)
        Me.ListBox2.HorizontalScrollbar = CType(resources.GetObject("ListBox2.HorizontalScrollbar"), Boolean)
        Me.ListBox2.ImeMode = CType(resources.GetObject("ListBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox2.IntegralHeight = CType(resources.GetObject("ListBox2.IntegralHeight"), Boolean)
        Me.ListBox2.ItemHeight = CType(resources.GetObject("ListBox2.ItemHeight"), Integer)
        Me.ListBox2.Location = CType(resources.GetObject("ListBox2.Location"), System.Drawing.Point)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = CType(resources.GetObject("ListBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox2.ScrollAlwaysVisible = CType(resources.GetObject("ListBox2.ScrollAlwaysVisible"), Boolean)
        Me.ListBox2.Size = CType(resources.GetObject("ListBox2.Size"), System.Drawing.Size)
        Me.ListBox2.TabIndex = CType(resources.GetObject("ListBox2.TabIndex"), Integer)
        Me.ListBox2.Visible = CType(resources.GetObject("ListBox2.Visible"), Boolean)
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
        'chkAddToMenu
        '
        Me.chkAddToMenu.AccessibleDescription = CType(resources.GetObject("chkAddToMenu.AccessibleDescription"), String)
        Me.chkAddToMenu.AccessibleName = CType(resources.GetObject("chkAddToMenu.AccessibleName"), String)
        Me.chkAddToMenu.Anchor = CType(resources.GetObject("chkAddToMenu.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkAddToMenu.Appearance = CType(resources.GetObject("chkAddToMenu.Appearance"), System.Windows.Forms.Appearance)
        Me.chkAddToMenu.BackgroundImage = CType(resources.GetObject("chkAddToMenu.BackgroundImage"), System.Drawing.Image)
        Me.chkAddToMenu.CheckAlign = CType(resources.GetObject("chkAddToMenu.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkAddToMenu.Checked = True
        Me.chkAddToMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAddToMenu.Dock = CType(resources.GetObject("chkAddToMenu.Dock"), System.Windows.Forms.DockStyle)
        Me.chkAddToMenu.Enabled = CType(resources.GetObject("chkAddToMenu.Enabled"), Boolean)
        Me.chkAddToMenu.FlatStyle = CType(resources.GetObject("chkAddToMenu.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkAddToMenu.Font = CType(resources.GetObject("chkAddToMenu.Font"), System.Drawing.Font)
        Me.chkAddToMenu.Image = CType(resources.GetObject("chkAddToMenu.Image"), System.Drawing.Image)
        Me.chkAddToMenu.ImageAlign = CType(resources.GetObject("chkAddToMenu.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkAddToMenu.ImageIndex = CType(resources.GetObject("chkAddToMenu.ImageIndex"), Integer)
        Me.chkAddToMenu.ImeMode = CType(resources.GetObject("chkAddToMenu.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkAddToMenu.Location = CType(resources.GetObject("chkAddToMenu.Location"), System.Drawing.Point)
        Me.chkAddToMenu.Name = "chkAddToMenu"
        Me.chkAddToMenu.RightToLeft = CType(resources.GetObject("chkAddToMenu.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkAddToMenu.Size = CType(resources.GetObject("chkAddToMenu.Size"), System.Drawing.Size)
        Me.chkAddToMenu.TabIndex = CType(resources.GetObject("chkAddToMenu.TabIndex"), Integer)
        Me.chkAddToMenu.Text = resources.GetString("chkAddToMenu.Text")
        Me.chkAddToMenu.TextAlign = CType(resources.GetObject("chkAddToMenu.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkAddToMenu.Visible = CType(resources.GetObject("chkAddToMenu.Visible"), Boolean)
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
        'TemplateSelection
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnHelp, Me.Label3, Me.chkAddToMenu, Me.Label2, Me.ListBox2, Me.btnSelect, Me.ListBox1, Me.Label1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "TemplateSelection"
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
    Dim lstrTemplateResources() As IPTemplates._main.resources
    Dim mstrTemplateID As String
    Dim mstrTemplateName As String
    Dim mstrTemplateFileName As String
    Dim mbooAllowMenuAddChk As Boolean = True
    Friend Property AllowMenuAddChk() As Boolean
        Get

            Return mbooAllowMenuAddChk
        End Get
        Set(ByVal Value As Boolean)
            mbooAllowMenuAddChk = Value
        End Set
    End Property
    Friend Property TemplateID() As String
        Get

            Return mstrTemplateID
        End Get
        Set(ByVal Value As String)
            mstrTemplateID = Value
        End Set
    End Property
    Friend Property TemplateFileName() As String
        Get

            Return mstrTemplateFileName
        End Get
        Set(ByVal Value As String)
            mstrTemplateFileName = Value
        End Set
    End Property
    Friend Property TemplateName() As String
        Get

            Return mstrTemplateName
        End Get
        Set(ByVal Value As String)
            mstrTemplateName = Value
        End Set
    End Property
    Private Sub TemplateSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label3.Text = Label3.Text.Replace("[Program]", gProgName) 

        '--- 
        'chkAddToMenu.FlatStyle = FlatStyle.System
        If IsAboveOrEqualWinXp() = True Then  
            btnSelect.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        If mbooAllowMenuAddChk = True Then
            chkAddToMenu.Visible = True
            chkAddToMenu.Checked = True
        Else
            chkAddToMenu.Visible = False
            chkAddToMenu.Checked = False
        End If

        LoadResouces()

    End Sub
    Private Sub LoadResouces()

        Dim TR As New IPTemplates._main()
        Dim lintArrInc As Integer

        TR.HTMLForms(lstrTemplateResources)

        For lintArrInc = 0 To lstrTemplateResources.GetUpperBound(0)
            'ListBox1.Items.Add(lstrTemplateResources(lintArrInc).ID)
            ListBox1.Items.Add(lstrTemplateResources(lintArrInc).Name)
        Next lintArrInc

        '---
        'Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
        '    System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        'Dim files() As FileInfo = source.GetFiles
        'Dim pfile As FileInfo

        'For Each pfile In files
        '    If RightGet(pfile.ToString, 5).ToUpper = ".HTML" Or RightGet(pfile.ToString, 4).ToUpper = ".HTM" Then
        '        ListBox2.Items.Add(pfile.ToString)
        '    End If
        'Next pfile
        LoadUserTemplatesListbox(ListBox2)

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim lintSelIdx = ListBox1.SelectedIndex
        ListBox2.SelectedIndex = -1
        ListBox1.SelectedIndex = lintSelIdx
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim lintSelIdx = ListBox2.SelectedIndex
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = lintSelIdx
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        'Dim lstrSelectedTemplate As String
        Dim lstrResTemplateID As String
        Dim lstrFileName As String

        
        If ListBox1.SelectedIndex = -1 Then
            If ListBox2.SelectedIndex = -1 Then
                Exit Sub
            End If
        End If
        

        If ListBox2.SelectedIndex <> -1 Then  '= -1 Then
            'if a user template was selected check it!            

            Dim x As New StatusDialog(Me)
            x.TopMostIn = gbooAlwaysOnTop 

            'x.Owner = Me
            
            x.Show()
            'x.Status = "Loading your template file ...."
            
            x.Status = LangText.GetString("TempSel_Loading")

            BusyButtons(True) 

            Dim AxWebBrowser As WinOnly.WebOCHostCtrl
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSelection))

            SpawnBrowserObject(AxWebBrowser, Me)

            lstrFileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
                "\Layouts\" & ListBox2.SelectedItem


            ShowForm(lstrFileName, AxWebBrowser, False)


            WaitForBrowser(AxWebBrowser) 

            lstrResTemplateID = GetTemplateIDFromUserForm(AxWebBrowser)

            
            If lstrResTemplateID = "" Then
                'mxessagebox.show("The Template you have chosen does not have a Template ID, please see help topic on creating templates!", NameMe(""))
                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                MessageBox.Show(LangText.GetString("TempSel_NoID"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                x.Close()
                System.Windows.Forms.Application.DoEvents()
                Me.DialogResult = DialogResult.Abort
                Exit Sub
            End If
            
            'x.Status = "Checking for template usage ...."
            
            x.Status = LangText.GetString("TempSel_CheckUsage")

            lstrResTemplateID = lstrResTemplateID.ToUpper 

            'check template doesn't already exist in Resource DLL
            Dim lintEXArrinc As Integer
            For lintEXArrinc = 0 To lstrTemplateResources.GetUpperBound(0)
                If lstrTemplateResources(lintEXArrinc).ID = lstrResTemplateID Then
                    If gbooAlwaysOnTop = True Then Me.Activate() 
                    'mxessagebox.show("The Template ID is already in use by a system template!")
                    
                    MessageBox.Show(LangText.GetString("TempSel_IDAlready"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                    x.Close()
                    System.Windows.Forms.Application.DoEvents()
                    Me.DialogResult = DialogResult.Abort 
                    Exit Sub
                End If
            Next

            Dim lstrFirstFormUsage As String
            lstrFirstFormUsage = GetFirstUserTmpUse(lstrResTemplateID)

            'x.Status = "Validating your template file ...."
            
            x.Status = LangText.GetString("TempSel_Validating")

            'Dim lstrThisTemplateID As String
            Dim lbooMissingField As Boolean = False
            If Not lstrFirstFormUsage Is Nothing Then
                CheckHTMLFormFields(lstrFirstFormUsage, AxWebBrowser, lbooMissingField)
            End If

            If lbooMissingField = True Then
                Dim ldlgResult As DialogResult
                'ldlgResult = MxessageBox.Show("A template with the same identity with different fields has already been used!" & Environment.NewLine & _
                '    "Please ensure you wish to proceed, information may be lost!", NameMe(""), MessageBoxButtons.YesNo)
                
                'ldlgResult = MessageBox.Show(LangText.GetString("TempSel_SameID"), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                ldlgResult = MessageBox.Show(LangText.GetString("TempSel_SameID").Replace("[CR]", Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props


                If ldlgResult <> DialogResult.Yes Then
                    x.Close()
                    System.Windows.Forms.Application.DoEvents()
                    Me.DialogResult = ldlgResult

                    Exit Sub
                End If
            End If

            System.Windows.Forms.Application.DoEvents()
            x.Close()

        End If

        'If check box update config file
        'if user template id is already in config file then warn user or replace??
        If ListBox1.SelectedIndex <> -1 Then
            If chkAddToMenu.Checked = True Then
                AddTemplateToMenuSettings(lstrTemplateResources(ListBox1.SelectedIndex).ID, ListBox1.SelectedItem, "SYSTEM:" & lstrTemplateResources(ListBox1.SelectedIndex).file)
            End If
            mstrTemplateID = lstrTemplateResources(ListBox1.SelectedIndex).ID 'ListBox1.SelectedItem
            mstrTemplateFileName = "SYSTEM:" & lstrTemplateResources(ListBox1.SelectedIndex).file
            mstrTemplateName = ListBox1.SelectedItem
        Else
            Dim lstrTemplateName As String = ListBox2.SelectedItem
            lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".html", "")
            lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".htm", "")
            If chkAddToMenu.Checked = True Then
                AddTemplateToMenuSettings(lstrResTemplateID, lstrTemplateName, ListBox2.SelectedItem)
                AllUserTemplatesList(True, ListBox2.SelectedItem, lstrResTemplateID)
            End If
            'SaveSetting("Name", lstrTemplateName, InitalXMLConfig.XmlConfigType.UserTemplates, lstrResTemplateID)
            'SaveSetting("FileName", ListBox2.SelectedItem, InitalXMLConfig.XmlConfigType.UserTemplates, lstrResTemplateID)
            
            If lstrResTemplateID <> "" Then
                lstrResTemplateID = lstrResTemplateID.ToUpper
            End If
            SaveSetting("Name", lstrTemplateName, InitalXMLConfig.XmlConfigType.UserTemplates, lstrResTemplateID)
            SaveSetting("FileName", ListBox2.SelectedItem, InitalXMLConfig.XmlConfigType.UserTemplates, lstrResTemplateID)
            mstrTemplateID = lstrResTemplateID 'ListBox2.SelectedItem
            mstrTemplateFileName = lstrFileName
            mstrTemplateName = lstrTemplateName
        End If
        DialogResult = DialogResult.OK 
        Me.Close()
        BusyButtons(False) 

    End Sub
    Private Sub AddTemplateToMenuSettings(ByVal pstrTemplateID As String, ByVal pstrTemplateName As String, Optional ByVal pstrTemplateFileName As String = "")

        
        Dim ShuffleTemplateBookmarks As New SuffleGenericBookmarks()
        With ShuffleTemplateBookmarks
            .DBID = lstrDBID
            .BookmarkType = SuffleGenericBookmarks.BookmarkTypes.TemplateBookMarks
            .Shuffle()
        End With
        Dim llngCurrentSystemBookmarkTemplateCount As Long = GetSetting("ItemCount", 0, InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)

        
        'If llngCurrentSystemBookmarkTemplateCount <> 0 Then
        llngCurrentSystemBookmarkTemplateCount += 1 
        'End If

        Dim xDoc As New XmlDocument()
        Dim ConfigFile As String = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString() & ".dat"
        xDoc.Load(ConfigFile)

        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "Name" & llngCurrentSystemBookmarkTemplateCount, pstrTemplateName)
        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "FileName" & llngCurrentSystemBookmarkTemplateCount, pstrTemplateFileName)
        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ID" & llngCurrentSystemBookmarkTemplateCount, pstrTemplateID)
        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ItemCount", llngCurrentSystemBookmarkTemplateCount)

        xDoc.Save(ConfigFile)
        xDoc = Nothing

        Exit Sub
        
        'Const lintMaxTemplates As Integer = 10

        Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
        With InitialConfig

            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
            Dim lstrTemplateNames(llngItemCount) As String
            Dim lstrTemplateFileNames(llngItemCount) As String
            Dim lstrTemplateIDs(llngItemCount) As String
            Dim lintLastArrayItem As Integer = -1
            Dim lintDupeArrInc As Integer
            Dim lintArrInc As Integer
            Dim lbooAdded As Boolean = False

            'Add everything to array
            For lintArrInc = 0 To llngItemCount

                If .GetValue("ID" & lintArrInc, "") <> pstrTemplateID And .GetValue("ID" & lintArrInc, "") <> "" Then
                    lstrTemplateNames(lintDupeArrInc) = .GetValue("Name" & lintArrInc, "")
                    lstrTemplateFileNames(lintDupeArrInc) = .GetValue("FileName" & lintArrInc, "")
                    lstrTemplateIDs(lintDupeArrInc) = .GetValue("ID" & lintArrInc, "")
                    lintLastArrayItem = lintDupeArrInc
                    lintDupeArrInc += 1
                End If

            Next lintArrInc

            Dim lintMoreThanOne As Integer
            If lintLastArrayItem <> -1 Then
                lintMoreThanOne = 1
            Else
                lintLastArrayItem = 0
            End If
            If lintLastArrayItem < llngItemCount Then
                lbooAdded = True
                lstrTemplateNames(lintLastArrayItem + lintMoreThanOne) = pstrTemplateName
                lstrTemplateFileNames(lintLastArrayItem + lintMoreThanOne) = pstrTemplateFileName
                lstrTemplateIDs(lintLastArrayItem + lintMoreThanOne) = pstrTemplateID
            End If

            '3. write array, add entry
            For lintArrInc = 0 To llngItemCount
                SaveSetting("Name" & lintArrInc, lstrTemplateNames(lintArrInc), InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
                SaveSetting("FileName" & lintArrInc, lstrTemplateFileNames(lintArrInc), InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
                SaveSetting("ID" & lintArrInc, lstrTemplateIDs(lintArrInc), InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
            Next lintArrInc
        End With
    End Sub
    Private Sub CheckHTMLFormFields(ByVal pstrFormData As String, ByVal BrowserControl As WinOnly.WebOCHostCtrl, _
        ByRef booFieldMissing As Boolean)
        Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        booFieldMissing = False

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
            'Console.WriteLine("#" & oForm.name)
            For x = 0 To oForm.length - 1
                'Console.WriteLine(oForm.elements(x).name & " " & oForm.elements(x).value)
                If InStrGet(pstrFormData, oForm.elements(x).name) = 0 Then
                    booFieldMissing = True
                    'If TemplateID <> "" Then
                    Exit Sub
                    'End If
                End If
                'If CStr(oForm.elements(x).name).ToUpper = "TemplateID".ToUpper Then
                '    TemplateID = oForm.elements(x).value
                'End If
            Next
        Next i

    End Sub
    Private Function GetTemplateIDFromUserForm(ByVal BrowserControl As WinOnly.WebOCHostCtrl) As String
        Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
            'Console.WriteLine("#" & oForm.name)
            For x = 0 To oForm.length - 1
                If CStr(oForm.elements(x).name).ToUpper = "TemplateID".ToUpper Then
                    GetTemplateIDFromUserForm = oForm.elements(x).value
                    Exit Function
                End If
            Next
        Next i

    End Function
    Private Function GetFirstUserTmpUse(ByVal pstrTemplateID As String) As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim lstrSQL As String = "SELECT * from TopicDetail where TemplateID = '" & pstrTemplateID & "';"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, _
         ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If Not lsnaLists.EOF Then
            GetFirstUserTmpUse = lsnaLists.Fields("TemplateID").Value & ""
        End If

        lsnaLists.Close()
        lcnn1.Close()

    End Function
    Private Sub chkAddToMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddToMenu.CheckedChanged

    End Sub
    Private Sub TemplateSelection_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = System.Windows.Forms.Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.templatesprovided)) 
    End Sub
    Private Sub TemplateSelection_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        
        Dim llngNewWidth As Long = (Me.Width - (7 + 8 + 17)) / 2

        ListBox1.Width = llngNewWidth
        ListBox2.Left = ListBox1.Width + 8 + 7
        ListBox2.Width = llngNewWidth
        Label2.Left = ListBox2.Left
        
        Me.Invalidate() 
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnSelect.Enabled = pbool 
        btnCancel.Enabled = pbool 
        btnHelp.Enabled = pbool 
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnSelect.BackColor = Color.FromArgb(0, btnSelect.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        chkAddToMenu.BackColor = Color.FromArgb(0, chkAddToMenu.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        If IsAboveOrEqualWinXp() = False Then : chkAddToMenu.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkAddToMenu.Top, chkAddToMenu.Left, chkAddToMenu.Width, chkAddToMenu.Height) : End If 

    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        btnSelect_Click(Nothing, Nothing) 
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        btnSelect_Click(Nothing, Nothing) 
    End Sub
    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            btnSelect_Click(Nothing, Nothing)
        End If
        
    End Sub
    Private Sub ListBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            btnSelect_Click(Nothing, Nothing)
        End If
        
    End Sub
End Class
