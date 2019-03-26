Imports System.Xml
Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports RTFStand
Friend Class Import
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
    Friend WithEvents grpStart As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpBranchInsert As System.Windows.Forms.GroupBox
    Friend WithEvents grpEnd As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents chkGeneralSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkTemplateBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents chkBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents chkColourSchemes As System.Windows.Forms.CheckBox
    Friend WithEvents chkTemplates As System.Windows.Forms.CheckBox
    Friend WithEvents chkTopics As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblImportFile As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSelectedBranch As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdoRootBranch As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSubBranch As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblCanvas As System.Windows.Forms.Label
    Friend WithEvents lblImportInfo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Import))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.grpStart = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImportFile = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkGeneralSettings = New System.Windows.Forms.CheckBox()
        Me.chkTemplateBookmarks = New System.Windows.Forms.CheckBox()
        Me.chkBookmarks = New System.Windows.Forms.CheckBox()
        Me.chkColourSchemes = New System.Windows.Forms.CheckBox()
        Me.chkTemplates = New System.Windows.Forms.CheckBox()
        Me.chkTopics = New System.Windows.Forms.CheckBox()
        Me.grpBranchInsert = New System.Windows.Forms.GroupBox()
        Me.rdoRootBranch = New System.Windows.Forms.RadioButton()
        Me.rdoSubBranch = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelectedBranch = New System.Windows.Forms.Label()
        Me.grpEnd = New System.Windows.Forms.GroupBox()
        Me.lblImportInfo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpStart.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpBranchInsert.SuspendLayout()
        Me.grpEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.AccessibleDescription = CType(resources.GetObject("TreeView1.AccessibleDescription"), String)
        Me.TreeView1.AccessibleName = CType(resources.GetObject("TreeView1.AccessibleName"), String)
        Me.TreeView1.Anchor = CType(resources.GetObject("TreeView1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackgroundImage = CType(resources.GetObject("TreeView1.BackgroundImage"), System.Drawing.Image)
        Me.TreeView1.Dock = CType(resources.GetObject("TreeView1.Dock"), System.Windows.Forms.DockStyle)
        Me.TreeView1.Enabled = CType(resources.GetObject("TreeView1.Enabled"), Boolean)
        Me.TreeView1.Font = CType(resources.GetObject("TreeView1.Font"), System.Drawing.Font)
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
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'grpStart
        '
        Me.grpStart.AccessibleDescription = CType(resources.GetObject("grpStart.AccessibleDescription"), String)
        Me.grpStart.AccessibleName = CType(resources.GetObject("grpStart.AccessibleName"), String)
        Me.grpStart.Anchor = CType(resources.GetObject("grpStart.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpStart.BackgroundImage = CType(resources.GetObject("grpStart.BackgroundImage"), System.Drawing.Image)
        Me.grpStart.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.lblImportFile, Me.btnBrowse, Me.Label5})
        Me.grpStart.Dock = CType(resources.GetObject("grpStart.Dock"), System.Windows.Forms.DockStyle)
        Me.grpStart.Enabled = CType(resources.GetObject("grpStart.Enabled"), Boolean)
        Me.grpStart.Font = CType(resources.GetObject("grpStart.Font"), System.Drawing.Font)
        Me.grpStart.ImeMode = CType(resources.GetObject("grpStart.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpStart.Location = CType(resources.GetObject("grpStart.Location"), System.Drawing.Point)
        Me.grpStart.Name = "grpStart"
        Me.grpStart.RightToLeft = CType(resources.GetObject("grpStart.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpStart.Size = CType(resources.GetObject("grpStart.Size"), System.Drawing.Size)
        Me.grpStart.TabIndex = CType(resources.GetObject("grpStart.TabIndex"), Integer)
        Me.grpStart.TabStop = False
        Me.grpStart.Text = resources.GetString("grpStart.Text")
        Me.grpStart.Visible = CType(resources.GetObject("grpStart.Visible"), Boolean)
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
        'lblImportFile
        '
        Me.lblImportFile.AccessibleDescription = CType(resources.GetObject("lblImportFile.AccessibleDescription"), String)
        Me.lblImportFile.AccessibleName = CType(resources.GetObject("lblImportFile.AccessibleName"), String)
        Me.lblImportFile.Anchor = CType(resources.GetObject("lblImportFile.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblImportFile.AutoSize = CType(resources.GetObject("lblImportFile.AutoSize"), Boolean)
        Me.lblImportFile.Dock = CType(resources.GetObject("lblImportFile.Dock"), System.Windows.Forms.DockStyle)
        Me.lblImportFile.Enabled = CType(resources.GetObject("lblImportFile.Enabled"), Boolean)
        Me.lblImportFile.Font = CType(resources.GetObject("lblImportFile.Font"), System.Drawing.Font)
        Me.lblImportFile.Image = CType(resources.GetObject("lblImportFile.Image"), System.Drawing.Image)
        Me.lblImportFile.ImageAlign = CType(resources.GetObject("lblImportFile.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblImportFile.ImageIndex = CType(resources.GetObject("lblImportFile.ImageIndex"), Integer)
        Me.lblImportFile.ImeMode = CType(resources.GetObject("lblImportFile.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblImportFile.Location = CType(resources.GetObject("lblImportFile.Location"), System.Drawing.Point)
        Me.lblImportFile.Name = "lblImportFile"
        Me.lblImportFile.RightToLeft = CType(resources.GetObject("lblImportFile.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblImportFile.Size = CType(resources.GetObject("lblImportFile.Size"), System.Drawing.Size)
        Me.lblImportFile.TabIndex = CType(resources.GetObject("lblImportFile.TabIndex"), Integer)
        Me.lblImportFile.Text = resources.GetString("lblImportFile.Text")
        Me.lblImportFile.TextAlign = CType(resources.GetObject("lblImportFile.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblImportFile.Visible = CType(resources.GetObject("lblImportFile.Visible"), Boolean)
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleDescription = CType(resources.GetObject("btnBrowse.AccessibleDescription"), String)
        Me.btnBrowse.AccessibleName = CType(resources.GetObject("btnBrowse.AccessibleName"), String)
        Me.btnBrowse.Anchor = CType(resources.GetObject("btnBrowse.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.Dock = CType(resources.GetObject("btnBrowse.Dock"), System.Windows.Forms.DockStyle)
        Me.btnBrowse.Enabled = CType(resources.GetObject("btnBrowse.Enabled"), Boolean)
        Me.btnBrowse.FlatStyle = CType(resources.GetObject("btnBrowse.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnBrowse.Font = CType(resources.GetObject("btnBrowse.Font"), System.Drawing.Font)
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageAlign = CType(resources.GetObject("btnBrowse.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnBrowse.ImageIndex = CType(resources.GetObject("btnBrowse.ImageIndex"), Integer)
        Me.btnBrowse.ImeMode = CType(resources.GetObject("btnBrowse.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnBrowse.Location = CType(resources.GetObject("btnBrowse.Location"), System.Drawing.Point)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.RightToLeft = CType(resources.GetObject("btnBrowse.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnBrowse.Size = CType(resources.GetObject("btnBrowse.Size"), System.Drawing.Size)
        Me.btnBrowse.TabIndex = CType(resources.GetObject("btnBrowse.TabIndex"), Integer)
        Me.btnBrowse.Text = resources.GetString("btnBrowse.Text")
        Me.btnBrowse.TextAlign = CType(resources.GetObject("btnBrowse.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnBrowse.Visible = CType(resources.GetObject("btnBrowse.Visible"), Boolean)
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = CType(resources.GetObject("Label5.AccessibleDescription"), String)
        Me.Label5.AccessibleName = CType(resources.GetObject("Label5.AccessibleName"), String)
        Me.Label5.Anchor = CType(resources.GetObject("Label5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = CType(resources.GetObject("Label5.AutoSize"), Boolean)
        Me.Label5.Dock = CType(resources.GetObject("Label5.Dock"), System.Windows.Forms.DockStyle)
        Me.Label5.Enabled = CType(resources.GetObject("Label5.Enabled"), Boolean)
        Me.Label5.Font = CType(resources.GetObject("Label5.Font"), System.Drawing.Font)
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = CType(resources.GetObject("Label5.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label5.ImageIndex = CType(resources.GetObject("Label5.ImageIndex"), Integer)
        Me.Label5.ImeMode = CType(resources.GetObject("Label5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label5.Location = CType(resources.GetObject("Label5.Location"), System.Drawing.Point)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = CType(resources.GetObject("Label5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label5.Size = CType(resources.GetObject("Label5.Size"), System.Drawing.Size)
        Me.Label5.TabIndex = CType(resources.GetObject("Label5.TabIndex"), Integer)
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = CType(resources.GetObject("Label5.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label5.Visible = CType(resources.GetObject("Label5.Visible"), Boolean)
        '
        'grpOptions
        '
        Me.grpOptions.AccessibleDescription = CType(resources.GetObject("grpOptions.AccessibleDescription"), String)
        Me.grpOptions.AccessibleName = CType(resources.GetObject("grpOptions.AccessibleName"), String)
        Me.grpOptions.Anchor = CType(resources.GetObject("grpOptions.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpOptions.BackgroundImage = CType(resources.GetObject("grpOptions.BackgroundImage"), System.Drawing.Image)
        Me.grpOptions.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label2, Me.chkGeneralSettings, Me.chkTemplateBookmarks, Me.chkBookmarks, Me.chkColourSchemes, Me.chkTemplates, Me.chkTopics})
        Me.grpOptions.Dock = CType(resources.GetObject("grpOptions.Dock"), System.Windows.Forms.DockStyle)
        Me.grpOptions.Enabled = CType(resources.GetObject("grpOptions.Enabled"), Boolean)
        Me.grpOptions.Font = CType(resources.GetObject("grpOptions.Font"), System.Drawing.Font)
        Me.grpOptions.ImeMode = CType(resources.GetObject("grpOptions.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpOptions.Location = CType(resources.GetObject("grpOptions.Location"), System.Drawing.Point)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.RightToLeft = CType(resources.GetObject("grpOptions.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpOptions.Size = CType(resources.GetObject("grpOptions.Size"), System.Drawing.Size)
        Me.grpOptions.TabIndex = CType(resources.GetObject("grpOptions.TabIndex"), Integer)
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = resources.GetString("grpOptions.Text")
        Me.grpOptions.Visible = CType(resources.GetObject("grpOptions.Visible"), Boolean)
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
        'Label2
        '
        Me.Label2.AccessibleDescription = CType(resources.GetObject("Label2.AccessibleDescription"), String)
        Me.Label2.AccessibleName = CType(resources.GetObject("Label2.AccessibleName"), String)
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
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
        'chkGeneralSettings
        '
        Me.chkGeneralSettings.AccessibleDescription = CType(resources.GetObject("chkGeneralSettings.AccessibleDescription"), String)
        Me.chkGeneralSettings.AccessibleName = CType(resources.GetObject("chkGeneralSettings.AccessibleName"), String)
        Me.chkGeneralSettings.Anchor = CType(resources.GetObject("chkGeneralSettings.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkGeneralSettings.Appearance = CType(resources.GetObject("chkGeneralSettings.Appearance"), System.Windows.Forms.Appearance)
        Me.chkGeneralSettings.BackgroundImage = CType(resources.GetObject("chkGeneralSettings.BackgroundImage"), System.Drawing.Image)
        Me.chkGeneralSettings.CheckAlign = CType(resources.GetObject("chkGeneralSettings.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkGeneralSettings.Dock = CType(resources.GetObject("chkGeneralSettings.Dock"), System.Windows.Forms.DockStyle)
        Me.chkGeneralSettings.Enabled = CType(resources.GetObject("chkGeneralSettings.Enabled"), Boolean)
        Me.chkGeneralSettings.FlatStyle = CType(resources.GetObject("chkGeneralSettings.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkGeneralSettings.Font = CType(resources.GetObject("chkGeneralSettings.Font"), System.Drawing.Font)
        Me.chkGeneralSettings.Image = CType(resources.GetObject("chkGeneralSettings.Image"), System.Drawing.Image)
        Me.chkGeneralSettings.ImageAlign = CType(resources.GetObject("chkGeneralSettings.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkGeneralSettings.ImageIndex = CType(resources.GetObject("chkGeneralSettings.ImageIndex"), Integer)
        Me.chkGeneralSettings.ImeMode = CType(resources.GetObject("chkGeneralSettings.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkGeneralSettings.Location = CType(resources.GetObject("chkGeneralSettings.Location"), System.Drawing.Point)
        Me.chkGeneralSettings.Name = "chkGeneralSettings"
        Me.chkGeneralSettings.RightToLeft = CType(resources.GetObject("chkGeneralSettings.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkGeneralSettings.Size = CType(resources.GetObject("chkGeneralSettings.Size"), System.Drawing.Size)
        Me.chkGeneralSettings.TabIndex = CType(resources.GetObject("chkGeneralSettings.TabIndex"), Integer)
        Me.chkGeneralSettings.Text = resources.GetString("chkGeneralSettings.Text")
        Me.chkGeneralSettings.TextAlign = CType(resources.GetObject("chkGeneralSettings.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkGeneralSettings.Visible = CType(resources.GetObject("chkGeneralSettings.Visible"), Boolean)
        '
        'chkTemplateBookmarks
        '
        Me.chkTemplateBookmarks.AccessibleDescription = CType(resources.GetObject("chkTemplateBookmarks.AccessibleDescription"), String)
        Me.chkTemplateBookmarks.AccessibleName = CType(resources.GetObject("chkTemplateBookmarks.AccessibleName"), String)
        Me.chkTemplateBookmarks.Anchor = CType(resources.GetObject("chkTemplateBookmarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkTemplateBookmarks.Appearance = CType(resources.GetObject("chkTemplateBookmarks.Appearance"), System.Windows.Forms.Appearance)
        Me.chkTemplateBookmarks.BackgroundImage = CType(resources.GetObject("chkTemplateBookmarks.BackgroundImage"), System.Drawing.Image)
        Me.chkTemplateBookmarks.CheckAlign = CType(resources.GetObject("chkTemplateBookmarks.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplateBookmarks.Dock = CType(resources.GetObject("chkTemplateBookmarks.Dock"), System.Windows.Forms.DockStyle)
        Me.chkTemplateBookmarks.Enabled = CType(resources.GetObject("chkTemplateBookmarks.Enabled"), Boolean)
        Me.chkTemplateBookmarks.FlatStyle = CType(resources.GetObject("chkTemplateBookmarks.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkTemplateBookmarks.Font = CType(resources.GetObject("chkTemplateBookmarks.Font"), System.Drawing.Font)
        Me.chkTemplateBookmarks.Image = CType(resources.GetObject("chkTemplateBookmarks.Image"), System.Drawing.Image)
        Me.chkTemplateBookmarks.ImageAlign = CType(resources.GetObject("chkTemplateBookmarks.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplateBookmarks.ImageIndex = CType(resources.GetObject("chkTemplateBookmarks.ImageIndex"), Integer)
        Me.chkTemplateBookmarks.ImeMode = CType(resources.GetObject("chkTemplateBookmarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkTemplateBookmarks.Location = CType(resources.GetObject("chkTemplateBookmarks.Location"), System.Drawing.Point)
        Me.chkTemplateBookmarks.Name = "chkTemplateBookmarks"
        Me.chkTemplateBookmarks.RightToLeft = CType(resources.GetObject("chkTemplateBookmarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkTemplateBookmarks.Size = CType(resources.GetObject("chkTemplateBookmarks.Size"), System.Drawing.Size)
        Me.chkTemplateBookmarks.TabIndex = CType(resources.GetObject("chkTemplateBookmarks.TabIndex"), Integer)
        Me.chkTemplateBookmarks.Text = resources.GetString("chkTemplateBookmarks.Text")
        Me.chkTemplateBookmarks.TextAlign = CType(resources.GetObject("chkTemplateBookmarks.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplateBookmarks.Visible = CType(resources.GetObject("chkTemplateBookmarks.Visible"), Boolean)
        '
        'chkBookmarks
        '
        Me.chkBookmarks.AccessibleDescription = CType(resources.GetObject("chkBookmarks.AccessibleDescription"), String)
        Me.chkBookmarks.AccessibleName = CType(resources.GetObject("chkBookmarks.AccessibleName"), String)
        Me.chkBookmarks.Anchor = CType(resources.GetObject("chkBookmarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkBookmarks.Appearance = CType(resources.GetObject("chkBookmarks.Appearance"), System.Windows.Forms.Appearance)
        Me.chkBookmarks.BackgroundImage = CType(resources.GetObject("chkBookmarks.BackgroundImage"), System.Drawing.Image)
        Me.chkBookmarks.CheckAlign = CType(resources.GetObject("chkBookmarks.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkBookmarks.Dock = CType(resources.GetObject("chkBookmarks.Dock"), System.Windows.Forms.DockStyle)
        Me.chkBookmarks.Enabled = CType(resources.GetObject("chkBookmarks.Enabled"), Boolean)
        Me.chkBookmarks.FlatStyle = CType(resources.GetObject("chkBookmarks.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkBookmarks.Font = CType(resources.GetObject("chkBookmarks.Font"), System.Drawing.Font)
        Me.chkBookmarks.Image = CType(resources.GetObject("chkBookmarks.Image"), System.Drawing.Image)
        Me.chkBookmarks.ImageAlign = CType(resources.GetObject("chkBookmarks.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkBookmarks.ImageIndex = CType(resources.GetObject("chkBookmarks.ImageIndex"), Integer)
        Me.chkBookmarks.ImeMode = CType(resources.GetObject("chkBookmarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkBookmarks.Location = CType(resources.GetObject("chkBookmarks.Location"), System.Drawing.Point)
        Me.chkBookmarks.Name = "chkBookmarks"
        Me.chkBookmarks.RightToLeft = CType(resources.GetObject("chkBookmarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkBookmarks.Size = CType(resources.GetObject("chkBookmarks.Size"), System.Drawing.Size)
        Me.chkBookmarks.TabIndex = CType(resources.GetObject("chkBookmarks.TabIndex"), Integer)
        Me.chkBookmarks.Text = resources.GetString("chkBookmarks.Text")
        Me.chkBookmarks.TextAlign = CType(resources.GetObject("chkBookmarks.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkBookmarks.Visible = CType(resources.GetObject("chkBookmarks.Visible"), Boolean)
        '
        'chkColourSchemes
        '
        Me.chkColourSchemes.AccessibleDescription = CType(resources.GetObject("chkColourSchemes.AccessibleDescription"), String)
        Me.chkColourSchemes.AccessibleName = CType(resources.GetObject("chkColourSchemes.AccessibleName"), String)
        Me.chkColourSchemes.Anchor = CType(resources.GetObject("chkColourSchemes.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkColourSchemes.Appearance = CType(resources.GetObject("chkColourSchemes.Appearance"), System.Windows.Forms.Appearance)
        Me.chkColourSchemes.BackgroundImage = CType(resources.GetObject("chkColourSchemes.BackgroundImage"), System.Drawing.Image)
        Me.chkColourSchemes.CheckAlign = CType(resources.GetObject("chkColourSchemes.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkColourSchemes.Dock = CType(resources.GetObject("chkColourSchemes.Dock"), System.Windows.Forms.DockStyle)
        Me.chkColourSchemes.Enabled = CType(resources.GetObject("chkColourSchemes.Enabled"), Boolean)
        Me.chkColourSchemes.FlatStyle = CType(resources.GetObject("chkColourSchemes.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkColourSchemes.Font = CType(resources.GetObject("chkColourSchemes.Font"), System.Drawing.Font)
        Me.chkColourSchemes.Image = CType(resources.GetObject("chkColourSchemes.Image"), System.Drawing.Image)
        Me.chkColourSchemes.ImageAlign = CType(resources.GetObject("chkColourSchemes.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkColourSchemes.ImageIndex = CType(resources.GetObject("chkColourSchemes.ImageIndex"), Integer)
        Me.chkColourSchemes.ImeMode = CType(resources.GetObject("chkColourSchemes.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkColourSchemes.Location = CType(resources.GetObject("chkColourSchemes.Location"), System.Drawing.Point)
        Me.chkColourSchemes.Name = "chkColourSchemes"
        Me.chkColourSchemes.RightToLeft = CType(resources.GetObject("chkColourSchemes.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkColourSchemes.Size = CType(resources.GetObject("chkColourSchemes.Size"), System.Drawing.Size)
        Me.chkColourSchemes.TabIndex = CType(resources.GetObject("chkColourSchemes.TabIndex"), Integer)
        Me.chkColourSchemes.Text = resources.GetString("chkColourSchemes.Text")
        Me.chkColourSchemes.TextAlign = CType(resources.GetObject("chkColourSchemes.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkColourSchemes.Visible = CType(resources.GetObject("chkColourSchemes.Visible"), Boolean)
        '
        'chkTemplates
        '
        Me.chkTemplates.AccessibleDescription = CType(resources.GetObject("chkTemplates.AccessibleDescription"), String)
        Me.chkTemplates.AccessibleName = CType(resources.GetObject("chkTemplates.AccessibleName"), String)
        Me.chkTemplates.Anchor = CType(resources.GetObject("chkTemplates.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkTemplates.Appearance = CType(resources.GetObject("chkTemplates.Appearance"), System.Windows.Forms.Appearance)
        Me.chkTemplates.BackgroundImage = CType(resources.GetObject("chkTemplates.BackgroundImage"), System.Drawing.Image)
        Me.chkTemplates.CheckAlign = CType(resources.GetObject("chkTemplates.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplates.Dock = CType(resources.GetObject("chkTemplates.Dock"), System.Windows.Forms.DockStyle)
        Me.chkTemplates.Enabled = CType(resources.GetObject("chkTemplates.Enabled"), Boolean)
        Me.chkTemplates.FlatStyle = CType(resources.GetObject("chkTemplates.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkTemplates.Font = CType(resources.GetObject("chkTemplates.Font"), System.Drawing.Font)
        Me.chkTemplates.Image = CType(resources.GetObject("chkTemplates.Image"), System.Drawing.Image)
        Me.chkTemplates.ImageAlign = CType(resources.GetObject("chkTemplates.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplates.ImageIndex = CType(resources.GetObject("chkTemplates.ImageIndex"), Integer)
        Me.chkTemplates.ImeMode = CType(resources.GetObject("chkTemplates.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkTemplates.Location = CType(resources.GetObject("chkTemplates.Location"), System.Drawing.Point)
        Me.chkTemplates.Name = "chkTemplates"
        Me.chkTemplates.RightToLeft = CType(resources.GetObject("chkTemplates.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkTemplates.Size = CType(resources.GetObject("chkTemplates.Size"), System.Drawing.Size)
        Me.chkTemplates.TabIndex = CType(resources.GetObject("chkTemplates.TabIndex"), Integer)
        Me.chkTemplates.Text = resources.GetString("chkTemplates.Text")
        Me.chkTemplates.TextAlign = CType(resources.GetObject("chkTemplates.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkTemplates.Visible = CType(resources.GetObject("chkTemplates.Visible"), Boolean)
        '
        'chkTopics
        '
        Me.chkTopics.AccessibleDescription = CType(resources.GetObject("chkTopics.AccessibleDescription"), String)
        Me.chkTopics.AccessibleName = CType(resources.GetObject("chkTopics.AccessibleName"), String)
        Me.chkTopics.Anchor = CType(resources.GetObject("chkTopics.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkTopics.Appearance = CType(resources.GetObject("chkTopics.Appearance"), System.Windows.Forms.Appearance)
        Me.chkTopics.BackgroundImage = CType(resources.GetObject("chkTopics.BackgroundImage"), System.Drawing.Image)
        Me.chkTopics.CheckAlign = CType(resources.GetObject("chkTopics.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkTopics.Dock = CType(resources.GetObject("chkTopics.Dock"), System.Windows.Forms.DockStyle)
        Me.chkTopics.Enabled = CType(resources.GetObject("chkTopics.Enabled"), Boolean)
        Me.chkTopics.FlatStyle = CType(resources.GetObject("chkTopics.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkTopics.Font = CType(resources.GetObject("chkTopics.Font"), System.Drawing.Font)
        Me.chkTopics.Image = CType(resources.GetObject("chkTopics.Image"), System.Drawing.Image)
        Me.chkTopics.ImageAlign = CType(resources.GetObject("chkTopics.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkTopics.ImageIndex = CType(resources.GetObject("chkTopics.ImageIndex"), Integer)
        Me.chkTopics.ImeMode = CType(resources.GetObject("chkTopics.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkTopics.Location = CType(resources.GetObject("chkTopics.Location"), System.Drawing.Point)
        Me.chkTopics.Name = "chkTopics"
        Me.chkTopics.RightToLeft = CType(resources.GetObject("chkTopics.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkTopics.Size = CType(resources.GetObject("chkTopics.Size"), System.Drawing.Size)
        Me.chkTopics.TabIndex = CType(resources.GetObject("chkTopics.TabIndex"), Integer)
        Me.chkTopics.Text = resources.GetString("chkTopics.Text")
        Me.chkTopics.TextAlign = CType(resources.GetObject("chkTopics.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkTopics.Visible = CType(resources.GetObject("chkTopics.Visible"), Boolean)
        '
        'grpBranchInsert
        '
        Me.grpBranchInsert.AccessibleDescription = CType(resources.GetObject("grpBranchInsert.AccessibleDescription"), String)
        Me.grpBranchInsert.AccessibleName = CType(resources.GetObject("grpBranchInsert.AccessibleName"), String)
        Me.grpBranchInsert.Anchor = CType(resources.GetObject("grpBranchInsert.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpBranchInsert.BackgroundImage = CType(resources.GetObject("grpBranchInsert.BackgroundImage"), System.Drawing.Image)
        Me.grpBranchInsert.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdoRootBranch, Me.rdoSubBranch, Me.Label3, Me.TreeView1, Me.lblSelectedBranch})
        Me.grpBranchInsert.Dock = CType(resources.GetObject("grpBranchInsert.Dock"), System.Windows.Forms.DockStyle)
        Me.grpBranchInsert.Enabled = CType(resources.GetObject("grpBranchInsert.Enabled"), Boolean)
        Me.grpBranchInsert.Font = CType(resources.GetObject("grpBranchInsert.Font"), System.Drawing.Font)
        Me.grpBranchInsert.ImeMode = CType(resources.GetObject("grpBranchInsert.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpBranchInsert.Location = CType(resources.GetObject("grpBranchInsert.Location"), System.Drawing.Point)
        Me.grpBranchInsert.Name = "grpBranchInsert"
        Me.grpBranchInsert.RightToLeft = CType(resources.GetObject("grpBranchInsert.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpBranchInsert.Size = CType(resources.GetObject("grpBranchInsert.Size"), System.Drawing.Size)
        Me.grpBranchInsert.TabIndex = CType(resources.GetObject("grpBranchInsert.TabIndex"), Integer)
        Me.grpBranchInsert.TabStop = False
        Me.grpBranchInsert.Text = resources.GetString("grpBranchInsert.Text")
        Me.grpBranchInsert.Visible = CType(resources.GetObject("grpBranchInsert.Visible"), Boolean)
        '
        'rdoRootBranch
        '
        Me.rdoRootBranch.AccessibleDescription = CType(resources.GetObject("rdoRootBranch.AccessibleDescription"), String)
        Me.rdoRootBranch.AccessibleName = CType(resources.GetObject("rdoRootBranch.AccessibleName"), String)
        Me.rdoRootBranch.Anchor = CType(resources.GetObject("rdoRootBranch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoRootBranch.Appearance = CType(resources.GetObject("rdoRootBranch.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoRootBranch.BackgroundImage = CType(resources.GetObject("rdoRootBranch.BackgroundImage"), System.Drawing.Image)
        Me.rdoRootBranch.CheckAlign = CType(resources.GetObject("rdoRootBranch.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoRootBranch.Dock = CType(resources.GetObject("rdoRootBranch.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoRootBranch.Enabled = CType(resources.GetObject("rdoRootBranch.Enabled"), Boolean)
        Me.rdoRootBranch.FlatStyle = CType(resources.GetObject("rdoRootBranch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoRootBranch.Font = CType(resources.GetObject("rdoRootBranch.Font"), System.Drawing.Font)
        Me.rdoRootBranch.Image = CType(resources.GetObject("rdoRootBranch.Image"), System.Drawing.Image)
        Me.rdoRootBranch.ImageAlign = CType(resources.GetObject("rdoRootBranch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoRootBranch.ImageIndex = CType(resources.GetObject("rdoRootBranch.ImageIndex"), Integer)
        Me.rdoRootBranch.ImeMode = CType(resources.GetObject("rdoRootBranch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoRootBranch.Location = CType(resources.GetObject("rdoRootBranch.Location"), System.Drawing.Point)
        Me.rdoRootBranch.Name = "rdoRootBranch"
        Me.rdoRootBranch.RightToLeft = CType(resources.GetObject("rdoRootBranch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoRootBranch.Size = CType(resources.GetObject("rdoRootBranch.Size"), System.Drawing.Size)
        Me.rdoRootBranch.TabIndex = CType(resources.GetObject("rdoRootBranch.TabIndex"), Integer)
        Me.rdoRootBranch.Text = resources.GetString("rdoRootBranch.Text")
        Me.rdoRootBranch.TextAlign = CType(resources.GetObject("rdoRootBranch.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoRootBranch.Visible = CType(resources.GetObject("rdoRootBranch.Visible"), Boolean)
        '
        'rdoSubBranch
        '
        Me.rdoSubBranch.AccessibleDescription = CType(resources.GetObject("rdoSubBranch.AccessibleDescription"), String)
        Me.rdoSubBranch.AccessibleName = CType(resources.GetObject("rdoSubBranch.AccessibleName"), String)
        Me.rdoSubBranch.Anchor = CType(resources.GetObject("rdoSubBranch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoSubBranch.Appearance = CType(resources.GetObject("rdoSubBranch.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoSubBranch.BackgroundImage = CType(resources.GetObject("rdoSubBranch.BackgroundImage"), System.Drawing.Image)
        Me.rdoSubBranch.CheckAlign = CType(resources.GetObject("rdoSubBranch.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoSubBranch.Checked = True
        Me.rdoSubBranch.Dock = CType(resources.GetObject("rdoSubBranch.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoSubBranch.Enabled = CType(resources.GetObject("rdoSubBranch.Enabled"), Boolean)
        Me.rdoSubBranch.FlatStyle = CType(resources.GetObject("rdoSubBranch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoSubBranch.Font = CType(resources.GetObject("rdoSubBranch.Font"), System.Drawing.Font)
        Me.rdoSubBranch.Image = CType(resources.GetObject("rdoSubBranch.Image"), System.Drawing.Image)
        Me.rdoSubBranch.ImageAlign = CType(resources.GetObject("rdoSubBranch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoSubBranch.ImageIndex = CType(resources.GetObject("rdoSubBranch.ImageIndex"), Integer)
        Me.rdoSubBranch.ImeMode = CType(resources.GetObject("rdoSubBranch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoSubBranch.Location = CType(resources.GetObject("rdoSubBranch.Location"), System.Drawing.Point)
        Me.rdoSubBranch.Name = "rdoSubBranch"
        Me.rdoSubBranch.RightToLeft = CType(resources.GetObject("rdoSubBranch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoSubBranch.Size = CType(resources.GetObject("rdoSubBranch.Size"), System.Drawing.Size)
        Me.rdoSubBranch.TabIndex = CType(resources.GetObject("rdoSubBranch.TabIndex"), Integer)
        Me.rdoSubBranch.TabStop = True
        Me.rdoSubBranch.Text = resources.GetString("rdoSubBranch.Text")
        Me.rdoSubBranch.TextAlign = CType(resources.GetObject("rdoSubBranch.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoSubBranch.Visible = CType(resources.GetObject("rdoSubBranch.Visible"), Boolean)
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
        'lblSelectedBranch
        '
        Me.lblSelectedBranch.AccessibleDescription = CType(resources.GetObject("lblSelectedBranch.AccessibleDescription"), String)
        Me.lblSelectedBranch.AccessibleName = CType(resources.GetObject("lblSelectedBranch.AccessibleName"), String)
        Me.lblSelectedBranch.Anchor = CType(resources.GetObject("lblSelectedBranch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedBranch.AutoSize = CType(resources.GetObject("lblSelectedBranch.AutoSize"), Boolean)
        Me.lblSelectedBranch.Dock = CType(resources.GetObject("lblSelectedBranch.Dock"), System.Windows.Forms.DockStyle)
        Me.lblSelectedBranch.Enabled = CType(resources.GetObject("lblSelectedBranch.Enabled"), Boolean)
        Me.lblSelectedBranch.Font = CType(resources.GetObject("lblSelectedBranch.Font"), System.Drawing.Font)
        Me.lblSelectedBranch.Image = CType(resources.GetObject("lblSelectedBranch.Image"), System.Drawing.Image)
        Me.lblSelectedBranch.ImageAlign = CType(resources.GetObject("lblSelectedBranch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblSelectedBranch.ImageIndex = CType(resources.GetObject("lblSelectedBranch.ImageIndex"), Integer)
        Me.lblSelectedBranch.ImeMode = CType(resources.GetObject("lblSelectedBranch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblSelectedBranch.Location = CType(resources.GetObject("lblSelectedBranch.Location"), System.Drawing.Point)
        Me.lblSelectedBranch.Name = "lblSelectedBranch"
        Me.lblSelectedBranch.RightToLeft = CType(resources.GetObject("lblSelectedBranch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblSelectedBranch.Size = CType(resources.GetObject("lblSelectedBranch.Size"), System.Drawing.Size)
        Me.lblSelectedBranch.TabIndex = CType(resources.GetObject("lblSelectedBranch.TabIndex"), Integer)
        Me.lblSelectedBranch.Text = resources.GetString("lblSelectedBranch.Text")
        Me.lblSelectedBranch.TextAlign = CType(resources.GetObject("lblSelectedBranch.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblSelectedBranch.Visible = CType(resources.GetObject("lblSelectedBranch.Visible"), Boolean)
        '
        'grpEnd
        '
        Me.grpEnd.AccessibleDescription = CType(resources.GetObject("grpEnd.AccessibleDescription"), String)
        Me.grpEnd.AccessibleName = CType(resources.GetObject("grpEnd.AccessibleName"), String)
        Me.grpEnd.Anchor = CType(resources.GetObject("grpEnd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpEnd.BackgroundImage = CType(resources.GetObject("grpEnd.BackgroundImage"), System.Drawing.Image)
        Me.grpEnd.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblImportInfo, Me.Label6, Me.ProgressBar1})
        Me.grpEnd.Dock = CType(resources.GetObject("grpEnd.Dock"), System.Windows.Forms.DockStyle)
        Me.grpEnd.Enabled = CType(resources.GetObject("grpEnd.Enabled"), Boolean)
        Me.grpEnd.Font = CType(resources.GetObject("grpEnd.Font"), System.Drawing.Font)
        Me.grpEnd.ImeMode = CType(resources.GetObject("grpEnd.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpEnd.Location = CType(resources.GetObject("grpEnd.Location"), System.Drawing.Point)
        Me.grpEnd.Name = "grpEnd"
        Me.grpEnd.RightToLeft = CType(resources.GetObject("grpEnd.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpEnd.Size = CType(resources.GetObject("grpEnd.Size"), System.Drawing.Size)
        Me.grpEnd.TabIndex = CType(resources.GetObject("grpEnd.TabIndex"), Integer)
        Me.grpEnd.TabStop = False
        Me.grpEnd.Text = resources.GetString("grpEnd.Text")
        Me.grpEnd.Visible = CType(resources.GetObject("grpEnd.Visible"), Boolean)
        '
        'lblImportInfo
        '
        Me.lblImportInfo.AccessibleDescription = CType(resources.GetObject("lblImportInfo.AccessibleDescription"), String)
        Me.lblImportInfo.AccessibleName = CType(resources.GetObject("lblImportInfo.AccessibleName"), String)
        Me.lblImportInfo.Anchor = CType(resources.GetObject("lblImportInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblImportInfo.AutoSize = CType(resources.GetObject("lblImportInfo.AutoSize"), Boolean)
        Me.lblImportInfo.Dock = CType(resources.GetObject("lblImportInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.lblImportInfo.Enabled = CType(resources.GetObject("lblImportInfo.Enabled"), Boolean)
        Me.lblImportInfo.Font = CType(resources.GetObject("lblImportInfo.Font"), System.Drawing.Font)
        Me.lblImportInfo.Image = CType(resources.GetObject("lblImportInfo.Image"), System.Drawing.Image)
        Me.lblImportInfo.ImageAlign = CType(resources.GetObject("lblImportInfo.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblImportInfo.ImageIndex = CType(resources.GetObject("lblImportInfo.ImageIndex"), Integer)
        Me.lblImportInfo.ImeMode = CType(resources.GetObject("lblImportInfo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblImportInfo.Location = CType(resources.GetObject("lblImportInfo.Location"), System.Drawing.Point)
        Me.lblImportInfo.Name = "lblImportInfo"
        Me.lblImportInfo.RightToLeft = CType(resources.GetObject("lblImportInfo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblImportInfo.Size = CType(resources.GetObject("lblImportInfo.Size"), System.Drawing.Size)
        Me.lblImportInfo.TabIndex = CType(resources.GetObject("lblImportInfo.TabIndex"), Integer)
        Me.lblImportInfo.Text = resources.GetString("lblImportInfo.Text")
        Me.lblImportInfo.TextAlign = CType(resources.GetObject("lblImportInfo.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblImportInfo.Visible = CType(resources.GetObject("lblImportInfo.Visible"), Boolean)
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = CType(resources.GetObject("Label6.AccessibleDescription"), String)
        Me.Label6.AccessibleName = CType(resources.GetObject("Label6.AccessibleName"), String)
        Me.Label6.Anchor = CType(resources.GetObject("Label6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = CType(resources.GetObject("Label6.AutoSize"), Boolean)
        Me.Label6.Dock = CType(resources.GetObject("Label6.Dock"), System.Windows.Forms.DockStyle)
        Me.Label6.Enabled = CType(resources.GetObject("Label6.Enabled"), Boolean)
        Me.Label6.Font = CType(resources.GetObject("Label6.Font"), System.Drawing.Font)
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = CType(resources.GetObject("Label6.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label6.ImageIndex = CType(resources.GetObject("Label6.ImageIndex"), Integer)
        Me.Label6.ImeMode = CType(resources.GetObject("Label6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label6.Location = CType(resources.GetObject("Label6.Location"), System.Drawing.Point)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = CType(resources.GetObject("Label6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label6.Size = CType(resources.GetObject("Label6.Size"), System.Drawing.Size)
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label6.Visible = CType(resources.GetObject("Label6.Visible"), Boolean)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AccessibleDescription = CType(resources.GetObject("ProgressBar1.AccessibleDescription"), String)
        Me.ProgressBar1.AccessibleName = CType(resources.GetObject("ProgressBar1.AccessibleName"), String)
        Me.ProgressBar1.Anchor = CType(resources.GetObject("ProgressBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackgroundImage = CType(resources.GetObject("ProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBar1.Dock = CType(resources.GetObject("ProgressBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.ProgressBar1.Enabled = CType(resources.GetObject("ProgressBar1.Enabled"), Boolean)
        Me.ProgressBar1.Font = CType(resources.GetObject("ProgressBar1.Font"), System.Drawing.Font)
        Me.ProgressBar1.ImeMode = CType(resources.GetObject("ProgressBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ProgressBar1.Location = CType(resources.GetObject("ProgressBar1.Location"), System.Drawing.Point)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = CType(resources.GetObject("ProgressBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProgressBar1.Size = CType(resources.GetObject("ProgressBar1.Size"), System.Drawing.Size)
        Me.ProgressBar1.TabIndex = CType(resources.GetObject("ProgressBar1.TabIndex"), Integer)
        Me.ProgressBar1.Text = resources.GetString("ProgressBar1.Text")
        Me.ProgressBar1.Visible = CType(resources.GetObject("ProgressBar1.Visible"), Boolean)
        '
        'btnPrevious
        '
        Me.btnPrevious.AccessibleDescription = CType(resources.GetObject("btnPrevious.AccessibleDescription"), String)
        Me.btnPrevious.AccessibleName = CType(resources.GetObject("btnPrevious.AccessibleName"), String)
        Me.btnPrevious.Anchor = CType(resources.GetObject("btnPrevious.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.BackgroundImage = CType(resources.GetObject("btnPrevious.BackgroundImage"), System.Drawing.Image)
        Me.btnPrevious.Dock = CType(resources.GetObject("btnPrevious.Dock"), System.Windows.Forms.DockStyle)
        Me.btnPrevious.Enabled = CType(resources.GetObject("btnPrevious.Enabled"), Boolean)
        Me.btnPrevious.FlatStyle = CType(resources.GetObject("btnPrevious.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnPrevious.Font = CType(resources.GetObject("btnPrevious.Font"), System.Drawing.Font)
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageAlign = CType(resources.GetObject("btnPrevious.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnPrevious.ImageIndex = CType(resources.GetObject("btnPrevious.ImageIndex"), Integer)
        Me.btnPrevious.ImeMode = CType(resources.GetObject("btnPrevious.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnPrevious.Location = CType(resources.GetObject("btnPrevious.Location"), System.Drawing.Point)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.RightToLeft = CType(resources.GetObject("btnPrevious.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnPrevious.Size = CType(resources.GetObject("btnPrevious.Size"), System.Drawing.Size)
        Me.btnPrevious.TabIndex = CType(resources.GetObject("btnPrevious.TabIndex"), Integer)
        Me.btnPrevious.Text = resources.GetString("btnPrevious.Text")
        Me.btnPrevious.TextAlign = CType(resources.GetObject("btnPrevious.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnPrevious.Visible = CType(resources.GetObject("btnPrevious.Visible"), Boolean)
        '
        'btnNext
        '
        Me.btnNext.AccessibleDescription = CType(resources.GetObject("btnNext.AccessibleDescription"), String)
        Me.btnNext.AccessibleName = CType(resources.GetObject("btnNext.AccessibleName"), String)
        Me.btnNext.Anchor = CType(resources.GetObject("btnNext.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.Dock = CType(resources.GetObject("btnNext.Dock"), System.Windows.Forms.DockStyle)
        Me.btnNext.Enabled = CType(resources.GetObject("btnNext.Enabled"), Boolean)
        Me.btnNext.FlatStyle = CType(resources.GetObject("btnNext.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnNext.Font = CType(resources.GetObject("btnNext.Font"), System.Drawing.Font)
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = CType(resources.GetObject("btnNext.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnNext.ImageIndex = CType(resources.GetObject("btnNext.ImageIndex"), Integer)
        Me.btnNext.ImeMode = CType(resources.GetObject("btnNext.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnNext.Location = CType(resources.GetObject("btnNext.Location"), System.Drawing.Point)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.RightToLeft = CType(resources.GetObject("btnNext.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnNext.Size = CType(resources.GetObject("btnNext.Size"), System.Drawing.Size)
        Me.btnNext.TabIndex = CType(resources.GetObject("btnNext.TabIndex"), Integer)
        Me.btnNext.Text = resources.GetString("btnNext.Text")
        Me.btnNext.TextAlign = CType(resources.GetObject("btnNext.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnNext.Visible = CType(resources.GetObject("btnNext.Visible"), Boolean)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = resources.GetString("OpenFileDialog1.Filter")
        Me.OpenFileDialog1.Title = resources.GetString("OpenFileDialog1.Title")
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
        'Import
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnHelp, Me.btnPrevious, Me.btnNext, Me.grpEnd, Me.grpBranchInsert, Me.grpOptions, Me.grpStart})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Import"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.grpStart.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpBranchInsert.ResumeLayout(False)
        Me.grpEnd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim lstrlblImportFileText As String 'to cater for german text
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    'Dim lstrImportDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
    '"\Import\"
    Dim lstrImportDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Temp-" & _
            Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

    Dim lstrLayoutsDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
    "\Layouts\"
    Dim mstrExportDBID As String
    Dim mstrCallingForm As Form
    Dim ImportedStartupTopicCode As String
    Dim lstrbtnNextText As String = "" 
    Friend Property CallingForm() As Form
        Get
            Return mstrCallingForm
        End Get
        Set(ByVal Value As Form)
            mstrCallingForm = Value
        End Set
    End Property
    Friend ReadOnly Property ImptdGenSets() As Boolean
        Get
            Return chkGeneralSettings.Checked
        End Get
    End Property
    Friend ReadOnly Property ImptdTemplBooks() As Boolean
        Get
            Return chkTemplateBookmarks.Checked
        End Get
    End Property
    Friend ReadOnly Property ImptdBookmarks() As Boolean
        Get
            Return chkBookmarks.Checked
        End Get
    End Property
    Friend ReadOnly Property ImptdClrSchemes() As Boolean
        Get
            Return chkColourSchemes.Checked
        End Get
    End Property
    Friend ReadOnly Property ImptdTemplates() As Boolean
        Get
            Return chkTemplates.Checked
        End Get
    End Property
    Friend ReadOnly Property ImptdTopics() As Boolean
        Get
            Return chkTopics.Checked
        End Get
    End Property
    Dim mstrTopics() As Export.Topics
    Dim mstrIndexArray() As TreeTopics
    Dim mstrTopicDetails() As Export.TopicDetail
    Private Sub Import()
        AddDebugComment("Import.Import - Pos 1") 
        Dim lintArrInc As Integer

        Busy(Me, True) 
        BusyButtons(True) 

        ProgressBar1.Maximum = 8 
        ProgressBar1.Value = 1 
        System.Windows.Forms.Application.DoEvents() 

        If chkTopics.Checked = True Then
            ImportTopics()
        End If

        AddDebugComment("Import.Import - Pos 2") 

        If chkTemplates.Checked = True Then
            WildcardCopy(lstrImportDir & "\", lstrLayoutsDir, "HTM")
            WildcardCopy(lstrImportDir & "\", lstrLayoutsDir, "HTML")
            System.Windows.Forms.Application.DoEvents() 
            'need to generate template setting in config file
            RebuildUserTemplateSettings()
        End If
        ProgressBar1.Value = 2 
        System.Windows.Forms.Application.DoEvents() 

        AddDebugComment("Import.Import - Pos 3") 

        If chkColourSchemes.Checked = True Then
            WildcardCopy(lstrImportDir & "\", lstrLayoutsDir, "CSS")
        End If

        ProgressBar1.Value = 3 
        System.Windows.Forms.Application.DoEvents() 

        AddDebugComment("Import.Import - Pos 4") 

        
        Dim llngCurrentSystemBookmarkCount As Long
        Dim llngCurrentSystemBookmarkTemplateCount As Long

        'shuffle Boomarks
        If chkBookmarks.Checked = True Then
            Dim ShuffleBookmarks As New SuffleGenericBookmarks()
            With ShuffleBookmarks
                .DBID = lstrDBID
                .BookmarkType = SuffleGenericBookmarks.BookmarkTypes.Boomarks
                .Shuffle()
            End With
            llngCurrentSystemBookmarkCount = GetSetting("ItemCount", -1, InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID) + 1
        End If

        AddDebugComment("Import.Import - Pos 5") 

        ProgressBar1.Value = 4 
        System.Windows.Forms.Application.DoEvents() 

        'shuffle template Boomarks
        If chkTemplateBookmarks.Checked = True Then
            Dim ShuffleTemplateBookmarks As New SuffleGenericBookmarks()
            With ShuffleTemplateBookmarks
                .DBID = lstrDBID
                .BookmarkType = SuffleGenericBookmarks.BookmarkTypes.TemplateBookMarks
                .Shuffle()
            End With
            'llngCurrentSystemBookmarkTemplateCount = GetSetting("ItemCount", -1, InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID) + 1
            
            llngCurrentSystemBookmarkTemplateCount = GetSetting("ItemCount", 0, InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
            
            If llngCurrentSystemBookmarkTemplateCount = 0 And GetSetting("Name0", 0, InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID) <> "" Then
                llngCurrentSystemBookmarkTemplateCount = 1
            Else
                If llngCurrentSystemBookmarkTemplateCount > 0 Then
                    llngCurrentSystemBookmarkTemplateCount += 1
                End If
            End If
            
        End If
        

        AddDebugComment("Import.Import - Pos 6") 

        ProgressBar1.Value = 5 
        System.Windows.Forms.Application.DoEvents() 

        Dim xDoc As New XmlDocument()
        Dim ConfigFile As String = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString() & ".dat"
        xDoc.Load(ConfigFile)

        If chkBookmarks.Checked = True Then
            Dim ExportedBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, mstrExportDBID, lstrImportDir & "\Export.dat")
            With ExportedBookmarks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                For lintArrInc = 0 To llngItemCount '19
                    Dim lstrBookmarkName As String = .GetValue("BookmarkName-" & lintArrInc, "")
                    Dim lstrBookmarks As String = .GetValue("Bookmarks-" & lintArrInc, "")
                    lstrBookmarks = CorrectTopicCode(lstrBookmarks) 
                    Dim lstrBookmarkImgIdx As String = .GetValue("BookmarkImgIdx-" & lintArrInc, "") 
                    If lstrBookmarkName <> "" Or lstrBookmarks <> "" Then
                        'this will add to the bottom of the list
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "Bookmarks-" & llngCurrentSystemBookmarkCount, lstrBookmarks)
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkName-" & llngCurrentSystemBookmarkCount, lstrBookmarkName)
                        'BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkNameImgIdx-" & llngCurrentSystemBookmarkCount, lstrBookmarkImgIdx) 
                        
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkImgIdx-" & llngCurrentSystemBookmarkCount, lstrBookmarkImgIdx) 
                        llngCurrentSystemBookmarkCount += 1 
                    End If
                Next lintArrInc
            End With
            If llngCurrentSystemBookmarkCount <> 0 Then 
                llngCurrentSystemBookmarkCount -= 1 
            End If
            BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "ItemCount", llngCurrentSystemBookmarkCount) 
        End If

        AddDebugComment("Import.Import - Pos 7") 

        ProgressBar1.Value = 6 
        System.Windows.Forms.Application.DoEvents() 

        If chkTemplateBookmarks.Checked = True Then
            Dim ExportedTemplateBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, mstrExportDBID, lstrImportDir & "\Export.dat")
            With ExportedTemplateBookmarks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 

                For lintArrInc = 0 To llngItemCount
                    Dim lstrTemplateName As String = .GetValue("Name" & lintArrInc, "")
                    Dim lstrTemplateFileName As String = .GetValue("FileName" & lintArrInc, "")
                    Dim lstrTemplateID As String = .GetValue("ID" & lintArrInc, "")
                    Dim lstrTemplateImgIdx As String = .GetValue("ImgIdx" & lintArrInc, "") 

                    If lstrTemplateName <> "" Or lstrTemplateFileName <> "" Then
                        'this will add to the bottom of the list
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "Name" & llngCurrentSystemBookmarkTemplateCount, lstrTemplateName)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "FileName" & llngCurrentSystemBookmarkTemplateCount, lstrTemplateFileName)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ID" & llngCurrentSystemBookmarkTemplateCount, lstrTemplateID)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ImgIdx" & llngCurrentSystemBookmarkTemplateCount, lstrTemplateImgIdx) 
                        llngCurrentSystemBookmarkTemplateCount += 1
                    End If
                Next lintArrInc
            End With

            'If llngCurrentSystemBookmarkTemplateCount <> 0 Then 
            '    llngCurrentSystemBookmarkTemplateCount -= 1 
            'End If

            BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ItemCount", llngCurrentSystemBookmarkTemplateCount) 
        End If

        AddDebugComment("Import.Import - Pos 8") 

        ProgressBar1.Value = 7 
        System.Windows.Forms.Application.DoEvents() 

        If chkGeneralSettings.Checked = True Then
            Dim GeneralSettings As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", lstrImportDir & "\Export.dat")
            With GeneralSettings
                Dim lstrItems() As String = {"Document Font Name", "Document Font Size", "Document Font Colour", "Document Font Bold", _
                    "Document Font Underlined", "Document Font Italic", "Document Font Strikeout", "Tree Font Name", "Tree Font Size", _
                    "Tree Font Colour", "Tree Font Bold", "Tree Font Underlined", "Tree Font Italic", "Tree Font Strikeout", _
                    "Tree Sort Order", "Show Startup Page", "Use Template By Default", "Default Template Name", "Default Template File Name", _
                    "Default Template ID", "Template Scheme", "Browser Font Size", "Tree Width", "RTF Highlight Colour", _
                    "Show Font Toolbar", "Move Branch IncrDecr"}

                For lintArrInc = 0 To lstrItems.GetUpperBound(0)
                    BatchXMLItemWrite(xDoc, "appSettings", lstrItems(lintArrInc), .GetValue(lstrItems(lintArrInc), ""))
                Next lintArrInc

                BatchXMLItemWrite(xDoc, "appSettings", "Startup Topic", ImportedStartupTopicCode) 
            End With
        End If

        AddDebugComment("Import.Import - Pos 9") 

        ProgressBar1.Value = 8 

        xDoc.Save(ConfigFile)
        xDoc = Nothing

        System.Windows.Forms.Application.DoEvents() 
        Busy(Me, False) 
        BusyButtons(False) 

        If gbooAlwaysOnTop = True Then Me.Activate() 
        MessageBox.Show(LangText.GetString("Import_ProcessComplete"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 

        Me.Close()
    End Sub
    Private Sub ImportTopics()
        Dim lstrSQL As String
        Dim LevelAdj As Integer

        'Console.WriteLine("Before")
        'DebugTopicArray(mstrTopics)
        AddDebugComment("Import.ImportTopics - Pos 1")   

        Dim GeneralSettings As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", lstrImportDir & "\Export.dat") 
        ImportedStartupTopicCode = GeneralSettings.GetValue("Startup Topic", "") 


        'Find the destination branch code
        Dim lstrDestTopicCode As String
        Dim FirstDestLevel As Integer
        If TreeView1.SelectedNode Is Nothing Then
            lstrDestTopicCode = ""
            FirstDestLevel = -1
        Else
            lstrDestTopicCode = TreeView1.SelectedNode.Tag  '"2T0000002" ' got from tree       
            FirstDestLevel = NodateLevel(TreeView1.SelectedNode) + 1  '2 ' 1 + 1 down ' got from tre Plus 1
        End If

        AddDebugComment("Import.ImportTopics - Pos 2")   

        mstrTopics(0).Parent = lstrDestTopicCode

        'Alter level number to reflect new destination level
        'e.g. if first new branch was to be level 5 and the imported topic was 2, set a variable to +3
        'and changed all level bys it.
        Dim FirstImportLevel As Integer = mstrTopics(0).Level
        If FirstDestLevel <> -1 Then
            If FirstDestLevel > FirstImportLevel Then
                LevelAdj = FirstDestLevel - FirstImportLevel '= 3
            ElseIf FirstImportLevel > FirstDestLevel Then
                LevelAdj = FirstImportLevel - FirstDestLevel
            End If
        Else
            
            If FirstImportLevel > 1 Then
                LevelAdj = (FirstImportLevel - (FirstImportLevel * 2)) + 1
            Else
                LevelAdj = 0
            End If
            'LevelAdj = 0
            
        End If

        AddDebugComment("Import.ImportTopics - Pos 3")   

        Dim lbooLinkRebuildRequired As Boolean = False 

        Dim lbooImportedStartupUpdated As Boolean = False
        Dim lintArrInc, lintArrInc2 As Integer
        For lintArrInc2 = 0 To mstrTopics.GetUpperBound(0)
            Dim lstrSearchTopic As String = mstrTopics(lintArrInc2).Code

            'Assign new topic codes for the old ones
            Dim lstrNewTopicCode As String
            'glngLastTopicNum = glngLastTopicNum + 1 ' will be set in populate tree            
            glngLastTopicNum = GetLastTopicRealNumber() + 1 
            lstrNewTopicCode = "T" & FormatNumberGet(glngLastTopicNum, "0000000")
            lstrNewTopicCode = (glngLastTopicNum + 1) & "T" & FormatNumberGet(glngLastTopicNum, "0000000")



            'Dim lintArrInc As Integer
            For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
                With mstrTopics(lintArrInc)



                    'Assign new topic code
                    If .Code = lstrSearchTopic And .booTopicUpdated = False Then
                        .TrueTopicCode = .Code 
                        .Code = lstrNewTopicCode
                        'Adjust level too
                        .Level = mstrTopics(lintArrInc).Level + LevelAdj
                        .booTopicUpdated = True
                        If ImportedStartupTopicCode = lstrSearchTopic And lbooImportedStartupUpdated = False Then 
                            ImportedStartupTopicCode = lstrNewTopicCode 
                            lbooImportedStartupUpdated = True 
                        End If
                    End If

                    'Assign new parent topic code
                    If .Parent = lstrSearchTopic And .booParentUpdated = False Then
                        .Parent = lstrNewTopicCode
                        .booParentUpdated = True
                    End If
                End With
            Next lintArrInc

            AddDebugComment("Import.ImportTopics - Pos 4")   

            '--- 'fix to cater for linked topics ---
            'produce an array of matching imported true code
            For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
                With mstrTopics(lintArrInc)
                    Dim TrueTopic As String = .TrueTopicCode
                    If Not TrueTopic Is Nothing Then
                        If ReturnTrueTopicStr(lstrSearchTopic) = ReturnTrueTopicStr(TrueTopic) Then
                            .booLinkTopic = True
                            lbooLinkRebuildRequired = True
                        End If
                    End If
                End With
            Next lintArrInc


            AddDebugComment("Import.ImportTopics - Pos 5")   
            'Dim lstrDebug2 As String = ""

            'For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
            '    With mstrTopics(lintArrInc)
            '        lstrDebug2 &= .Code & " " & .TrueTopicCode & " " & .Sequence & " " & .Title & CR()
            '    End With
            'Next lintArrInc
            'MessageBox.Show(lstrDebug2)
            '--- 'fix to cater for linked topics ---

            'Do the same for topicdetails
            For lintArrInc = 0 To mstrTopicDetails.GetUpperBound(0)
                With mstrTopicDetails(lintArrInc)
                    If lstrSearchTopic <> "" Then 
                        If .Code = ReturnTrueTopicStr(lstrSearchTopic) And .booTopicUpdated = False Then
                            .Code = ReturnTrueTopicStr(lstrNewTopicCode)
                            .booTopicUpdated = True
                        End If
                    End If 
                End With
            Next
        Next lintArrInc2

        'DebugTopicArray(mstrTopics)
        AddDebugComment("Import.ImportTopics - Pos 6")   

        '--- 'fix to cater for linked topics ---
        Dim lstrNewCodes(0) As String
        Dim lstrOldCodes(0) As String
        Dim lintArrCtr As Integer = 0

        If lbooLinkRebuildRequired = True Then
            For lintArrInc2 = 0 To mstrTopics.GetUpperBound(0)
                For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
                    With mstrTopics(lintArrInc)
                        If mstrTopics(lintArrInc2).booLinkTopic = True And .booTopicUpdated = True Then
                            If ReturnTrueTopicStr(mstrTopics(lintArrInc2).TrueTopicCode) = ReturnTrueTopicStr(.TrueTopicCode) Then
                                lstrOldCodes(lintArrCtr) = .Code
                                .Code = .Code.Replace(ReturnTrueTopicStr(.Code), ReturnTrueTopicStr(mstrTopics(lintArrInc2).Code))
                                lstrNewCodes(lintArrCtr) = .Code
                                .booLinkTopic = False
                                lintArrCtr += 1
                                ReDim Preserve lstrOldCodes(lintArrCtr)
                                ReDim Preserve lstrNewCodes(lintArrCtr)
                            End If
                        End If
                    End With
                Next lintArrInc
            Next lintArrInc2

            AddDebugComment("Import.ImportTopics - Pos 7")   

            For lintArrInc2 = 0 To mstrTopics.GetUpperBound(0)
                For lintArrInc = 0 To lstrOldCodes.GetUpperBound(0)
                    If mstrTopics(lintArrInc2).Parent = lstrOldCodes(lintArrInc) Then
                        mstrTopics(lintArrInc2).Parent = lstrNewCodes(lintArrInc)
                    End If
                Next lintArrInc
            Next lintArrInc2


            For lintArrInc2 = 0 To mstrTopicDetails.GetUpperBound(0)
                For lintArrInc = 0 To lstrOldCodes.GetUpperBound(0) - 1
                    If mstrTopicDetails(lintArrInc2).Code = ReturnTrueTopicStr(lstrOldCodes(lintArrInc)) Then
                        mstrTopicDetails(lintArrInc2).Code = ReturnTrueTopicStr(lstrNewCodes(lintArrInc))
                    End If
                Next lintArrInc
            Next lintArrInc2

            'Dim lstrDebug As String = ""
            'For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
            '    With mstrTopics(lintArrInc)
            '        lstrDebug &= .Code & " " & .TrueTopicCode & " " & .Sequence & " " & .Title & CR()
            '    End With
            'Next lintArrInc
            '    MessageBox.Show(lstrDebug)
        End If
        '--- 'fix to cater for linked topics ---

        'Console.WriteLine("After")
        'DebugTopicArray(mstrTopics)

        AddDebugComment("Import.ImportTopics - Pos 8")   

        ''commit to topics table
        Dim lcnn1 As New ADODB.Connection()
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
            With mstrTopics(lintArrInc)

                'If lintArrInc > 0 And .Parent = "" Then 
                '    'Console.WriteLine(.Code & " " & .Title)
                '    .Parent = lstrDestTopicCode 
                'End If

                'If .Level = (FirstDestLevel) And .Parent = "" Then 
                If .Level = (FirstDestLevel) Then  
                    .Parent = lstrDestTopicCode 
                    'Console.WriteLine(.Code & " " & .Title)
                End If
                'lcnn1.Execute("INSERT INTO Topics ( TopicCode, [Level], ParentTopicCode, Title, SeqNum, InUse ) values( '" & _
                '    .Code & "', " & .Level & ", '" & .Parent & "', '" & .Title & "', " & .Sequence & ", True);")
                
                'lcnn1.Execute("INSERT INTO Topics ( TopicCode, [Level], ParentTopicCode, Title, SeqNum, InUse, ImgIdx ) values( '" & _
                '    .Code & "', " & .Level & ", '" & .Parent & "', '" & .Title & "', " & .Sequence & ", True, " & .ImgIdx & ");")

                
                lstrSQL = "INSERT INTO Topics ( TopicCode, [Level], ParentTopicCode, Title, SeqNum, InUse, ImgIdx ) values( '" & _
                   .Code & "', " & .Level & ", '" & .Parent & "', '" & JetSQLFixup(.Title) & "', " & .Sequence & ", True, " & .ImgIdx & ");"

                gstrLastSQL = lstrSQL 

                lcnn1.Execute(lstrSQL)
                ''Run import detail function.
                '.Code

            End With
        Next lintArrInc
        lcnn1.Close()

        AddDebugComment("Import.ImportTopics - Pos 9")   

        TopicDetailAddNew(mstrTopicDetails, lstrImportDir & "\")

        AddDebugComment("Import.ImportTopics - Pos 10")   

    End Sub
    Private Sub Import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Text = NameMe("Import Wizard")
        
        Me.Text = NameMe(LangText.GetString("Import_Title"))

        Label5.Text = Label5.Text.Replace("[Program]", gProgName) 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnNext.FlatStyle = FlatStyle.System
            btnPrevious.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnBrowse.FlatStyle = FlatStyle.System
            
            rdoRootBranch.FlatStyle = FlatStyle.System
            rdoSubBranch.FlatStyle = FlatStyle.System
            
        End If 
        ''If IsAboveOrEqualWinXp() = False Then 
        ''    chkTopics.FlatStyle = FlatStyle.System
        ''    chkTemplates.FlatStyle = FlatStyle.System
        ''    chkBookmarks.FlatStyle = FlatStyle.System
        ''    chkGeneralSettings.FlatStyle = FlatStyle.System
        ''    chkColourSchemes.FlatStyle = FlatStyle.System
        ''    chkTemplateBookmarks.FlatStyle = FlatStyle.System
        ''End If 
        'grpStart.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpOptions.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpBranchInsert.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpEnd.FlatStyle = FlatStyle.System 'Commented for transparency 
        'rdoRootBranch.FlatStyle = FlatStyle.System
        'rdoSubBranch.FlatStyle = FlatStyle.System

        SetBackcolors() 

        lblCanvas = New System.Windows.Forms.Label()
        grpStart.Controls.AddRange(New System.Windows.Forms.Control() {lblCanvas})
        lblCanvas.Top = 15
        lblCanvas.Left = 15
        lblCanvas.Height = 200
        lblCanvas.Width = 200
        lblCanvas.Text = ""
        

        lstrlblImportFileText = lblImportFile.Text 

        lstrbtnNextText = btnNext.Text

        btnNext.Tag = "NEXT" 
        lblSelectedBranch.Tag = "NONE" 

        'Me.Size = New Size(374, 299)
        grpStart.Location = New System.Drawing.Point(8, 8)
        grpOptions.Location = New System.Drawing.Point(8, 8)
        grpBranchInsert.Location = New System.Drawing.Point(8, 8)
        grpEnd.Location = New System.Drawing.Point(8, 8)

        'gstrConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        '    "Data Source=D:\Visual Studio Projects\HTMLTemplatesDev\bin\DB\HTMLDEV.ibf;Persist Security Info=False;User ID=IPUser;" & _
        '    "Password=CEF01FE3D66AC;Jet OLEDB:Database Password=32khdssa976;Jet OLEDB:System database=D:\Visual Studio Projects\HTMLTemplatesDev\bin\DB\HTMLDEV.ibw;"

        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)

        btnPrevious.Enabled = False 

    End Sub
    Private Sub DebugTopicArray(ByVal pstrTopics() As Export.Topics)
        Dim lintArrInc As Integer

        Console.WriteLine("Level" & Tab() & "SeqNum" & Tab() & "TopicCode" & Tab() & "Parent" & Tab() & "Title")
        For lintArrInc = 0 To pstrTopics.GetUpperBound(0)
            With pstrTopics(lintArrInc)
                Console.WriteLine(.Level & Tab() & Tab() & .Sequence & Tab() & Tab() & .Code & Tab() & Tab() & .Parent & Tab() & Tab() & .Title)
            End With
        Next lintArrInc

        MessageBox.Show("Pause!")

    End Sub
    Private Sub TopicDetailAddNew(ByVal pstrTopicDetails() As Export.TopicDetail, ByVal pstrImportPath As String)
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lintArrinc As Integer

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        With lsnaLists
            .CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
            .Open("SELECT * FROM TopicDetail;", lcnn1)

            Dim cnt As Integer
            cnt = pstrTopicDetails.GetUpperBound(0) 

            lblImportInfo.Text = 0 & " / " & cnt 
            Application.DoEvents() 

            For lintArrinc = 0 To cnt
                If pstrTopicDetails(lintArrinc).Code <> "" Then
                    Dim FileName As String = pstrImportPath & pstrTopicDetails(lintArrinc).OldCode & ".top"
                    Dim OpenFile As FileStream = New FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                    
                    Dim StreamReader As StreamReader = New StreamReader(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))

                    Dim Detail As String
                    Detail = StreamReader.ReadToEnd
                    StreamReader.Close()
                    OpenFile.Close()

                    Dim ByteLength As Integer = -1
                    If pstrTopicDetails(lintArrinc).TemplateID = "" Then

                        AddDebugComment("Deflate")
                        Dim InfDef As New InflateDeflate()
                        Detail = InfDef.Deflate(Detail, ByteLength)
                    End If

                    .AddNew()
                    .Fields("TopicCode").Value = pstrTopicDetails(lintArrinc).Code
                    .Fields("Detail").Value = Detail
                    .Fields("TemplateID").Value = pstrTopicDetails(lintArrinc).TemplateID
                    .Fields("LockingFlag").Value = CreateLockingFlag("") 
                    .Fields("ByteLen").Value = ByteLength ' 
                    .Fields("Options").Value = pstrTopicDetails(lintArrinc).Options 

                    .Update()
                End If

                If lintArrinc Mod 10 Then
                    Application.DoEvents()
                    lblImportInfo.Text = lintArrinc & " / " & cnt
                End If
            Next lintArrinc

            lsnaLists.Close()
            lcnn1.Close()
        End With
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If grpStart.Visible = True Then
            If lblImportFile.Text = lstrlblImportFileText Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("Import_FirstSelFile"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                Exit Sub
            End If
            grpStart.Visible = False
            grpOptions.Visible = True
            btnPrevious.Enabled = True 
            AnalyseImportFile()
            Exit Sub
        End If

        If grpOptions.Visible = True Then
            grpOptions.Visible = False
            If mstrIndexArray.GetUpperBound(0) & "" & mstrIndexArray(0).strTopicCode & "" <> "0" Then
                If chkTopics.Checked = True Then
                    grpBranchInsert.Visible = True
                    LoadArraysExportFile()
                    System.Windows.Forms.Application.DoEvents()
                    Exit Sub
                End If
            End If
            LoadArraysExportFile()
            System.Windows.Forms.Application.DoEvents()
            'btnNext.Text = "&Import"
            btnNext.Text = LangText.GetString("Import_ButtonImport") 
            btnNext.Tag = "IMPORT" 

            grpEnd.Visible = True
            Exit Sub
        End If

        If grpBranchInsert.Visible = True Then
            'If lblSelectedBranch.Text = "None Selected" And rdoSubBranch.Checked = True Then

            'If lblSelectedBranch.Text = LangText.GetString("Import_NoneSelected") And rdoSubBranch.Checked = True Then 
            If lblSelectedBranch.Tag <> "BRANCH" And rdoSubBranch.Checked = True Then 
                If gbooAlwaysOnTop = True Then Me.Activate() 
                'mxessagebox.show("Please select a branch!", NameMe(""))
                MessageBox.Show(LangText.GetString("Import_PleaseSelectBranch"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                Exit Sub
            End If
            grpBranchInsert.Visible = False
            'btnNext.Text = "&Import"
            btnNext.Text = LangText.GetString("Import_ButtonImport") 
            btnNext.Tag = "IMPORT" 

            grpEnd.Visible = True
            Exit Sub
        End If

        'If btnNext.Text = "&Import" And grpEnd.Visible = True Then

        'If btnNext.Text = LangText.GetString("Import_ButtonImport") And grpEnd.Visible = True Then 
        If btnNext.Tag = "IMPORT" And grpEnd.Visible = True Then  

            Import()

        End If
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        If grpEnd.Visible = True Then
            grpEnd.Visible = False
            'btnNext.Text = "&Next"

            'btnNext.Text = LangText.GetString("Import_ButtonNext") 
            btnNext.Text = lstrbtnNextText

            btnNext.Tag = "NEXT" 
            If mstrIndexArray.GetUpperBound(0) & "" & mstrIndexArray(0).strTopicCode & "" <> "0" Then
                If chkTopics.Checked = True Then
                    grpBranchInsert.Visible = True
                    Exit Sub
                End If
            End If
            grpOptions.Visible = True
            Exit Sub
        End If

        If grpBranchInsert.Visible = True Then
            grpBranchInsert.Visible = False
            grpOptions.Visible = True
            Exit Sub
        End If

        If grpOptions.Visible = True Then
            grpOptions.Visible = False
            grpStart.Visible = True
            btnPrevious.Enabled = False 
        End If
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim openFile As New OpenFileDialog() 

        With openFile 
            .Filter = LangText.GetString("Export_FileFilter").Replace("[Program]", gProgName) 
            .RestoreDirectory = True 
            If .ShowDialog = DialogResult.OK Then
                lblImportFile.Text = .FileName
                btnNext.Select() 
            End If
        End With
    End Sub
    Private Sub AnalyseImportFile()

        Dim x As New StatusDialog(Me)
        x.TopMostIn = gbooAlwaysOnTop 

        'x.Owner = Me
        x.Show()
        'x.Status = "Analysing the import file ...."
        x.Status = LangText.GetString("Import_AnalysingFile") 


        Try 
            Directory.CreateDirectory(lstrImportDir) 
        Catch 
        End Try

        Unzip(lblImportFile.Text, lstrImportDir & "\")

        ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 
        lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrImportDir & "\" 

        'x.Status = "Finished analysing the import file ...."
        x.Status = LangText.GetString("Import_FinishedAnalysing") 


        Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", lstrImportDir & "\Export.dat")
        With InitialConfig
            chkTopics.Checked = CBool(.GetValue("ExportTopics", ""))
            chkTemplates.Checked = CBool(.GetValue("ExportTemplate", ""))
            chkColourSchemes.Checked = CBool(.GetValue("ExportCSS", ""))
            chkBookmarks.Checked = CBool(.GetValue("ExportBookmarks", ""))
            chkTemplateBookmarks.Checked = CBool(.GetValue("ExportTempBookmarks", ""))
            chkGeneralSettings.Checked = CBool(.GetValue("ExportGeneralSettings", ""))

            If chkTopics.Checked = False Then
                chkTopics.Enabled = False
            Else
                Dim llngTopicCount As Long = CLng(.GetValue("ExportTopicsCount", ""))
                Dim llngTopicDetailCount As Long = CLng(.GetValue("ExportTopicDetailsCount", ""))
                ReDim mstrTopics(llngTopicCount)
                ReDim mstrTopicDetails(llngTopicCount)
            End If

            If chkTemplates.Checked = False Then chkTemplates.Enabled = False
            If chkColourSchemes.Checked = False Then chkColourSchemes.Enabled = False
            If chkBookmarks.Checked = False Then chkBookmarks.Enabled = False
            If chkTemplateBookmarks.Checked = False Then chkTemplateBookmarks.Enabled = False
            If chkGeneralSettings.Checked = False Then chkGeneralSettings.Enabled = False

            mstrExportDBID = .GetValue("ExportDBID", "")


            'Need some sort of warning if T&Bookmarks will be overwritten
            x.Close()
            System.Windows.Forms.Application.DoEvents()

            'If .GetValue("ExportVersion", "") <> "1.0.0" And .GetValue("ExportVersion", "") <> "1.0.1" Then 'added 1.0.1 
            If .GetValue("ExportVersion", "") <> "1.0.0" And .GetValue("ExportVersion", "") <> "1.0.1" And .GetValue("ExportVersion", "") <> "1.0.2" Then  'added 1.0.2 
                'mxessagebox.show("WARNING: This import file was exported form a newer version of Ideaspad!" & Environment.NewLine & _
                '    "Please use the 'Check for Updates' feature to download the latest version of the program and retry!")
                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                MessageBox.Show(LangText.GetString("Import_WarnNewerVerion").Replace("[Program]", gProgName).Replace("[CR]", _
                    Environment.NewLine), _
                    NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 

                Me.Close()
            End If

        End With
    End Sub
    Private Sub Unzip(ByVal pstrZipFile As String, ByVal strDestinationPath As String)
        Dim stmzipArchive As ZipInputStream = New ZipInputStream(File.OpenRead(pstrZipFile))
        Dim theEntry As ZipEntry

        theEntry = stmzipArchive.GetNextEntry()

        'While IsNothing(theEntry) = False
        While Not (theEntry Is Nothing)
            'Conxsole.WriteLine(theEntry.Name)
            Dim directoryName As String = Path.GetDirectoryName(theEntry.Name)
            Dim filename As String = Path.GetFileName(theEntry.Name)

            Directory.CreateDirectory(strDestinationPath & directoryName)

            Dim streamWriter As FileStream = File.Create(strDestinationPath & theEntry.Name)

            ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 
            lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = strDestinationPath & theEntry.Name 

            Dim size As Integer = 2048
            Dim data(2048) As Byte

            While (True)
                size = stmzipArchive.Read(data, 0, data.Length)
                If size > 0 Then
                    streamWriter.Write(data, 0, size)
                Else
                    Exit While
                End If
            End While
            streamWriter.Close()
            theEntry = stmzipArchive.GetNextEntry()
        End While
        stmzipArchive.Close()
    End Sub
    Private Sub LoadArraysExportFile()
        If Not mstrTopics Is Nothing Then 

            Dim lintArrInc As Integer
            Dim TopicConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Topics, "", lstrImportDir & "\Export.dat")

            With TopicConfig
                For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
                    mstrTopics(lintArrInc).Code = .GetValue("Code-" & lintArrInc, "")
                    mstrTopics(lintArrInc).Title = .GetValue("Title-" & lintArrInc, "")
                    mstrTopics(lintArrInc).Parent = .GetValue("Parent-" & lintArrInc, "")
                    mstrTopics(lintArrInc).Level = .GetValue("Level-" & lintArrInc, "")
                    mstrTopics(lintArrInc).ImgIdx = .GetValue("ImgIdx-" & lintArrInc, "")
                    mstrTopics(lintArrInc).Sequence = .GetValue("Sequence-" & lintArrInc, "")
                Next lintArrInc
            End With

            Dim TopicDetailConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TopicDetails, "", lstrImportDir & "\Export.dat")
            With TopicDetailConfig
                For lintArrInc = 0 To mstrTopicDetails.GetUpperBound(0)
                    mstrTopicDetails(lintArrInc).Code = .GetValue("Code-" & lintArrInc, "")
                    mstrTopicDetails(lintArrInc).OldCode = .GetValue("OldCode-" & lintArrInc, "")
                    mstrTopicDetails(lintArrInc).TemplateID = .GetValue("TemplateID-" & lintArrInc, "")
                    Try 
                        mstrTopicDetails(lintArrInc).TemplateID = mstrTopicDetails(lintArrInc).TemplateID.ToUpper 
                    Catch
                        '
                    End Try
                    mstrTopicDetails(lintArrInc).Options = .GetValue("Options-" & lintArrInc, "") 
                Next lintArrInc
            End With

        End If 

    End Sub
    Private Sub RebuildUserTemplateSettings()
        Dim source As DirectoryInfo = New DirectoryInfo(lstrLayoutsDir)
        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo
        For Each pfile In files
            If RightGet(pfile.ToString, 5).ToUpper = ".HTML" Or RightGet(pfile.ToString, 4).ToUpper = ".HTM" Then
                Dim OpenFile As FileStream = New FileStream(lstrLayoutsDir & pfile.ToString, FileMode.Open, FileAccess.Read, FileShare.Read)
                'Dim StreamReader As StreamReader = New StreamReader(OpenFile)
                
                Dim StreamReader As StreamReader = New StreamReader(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))
                Dim lstrFileStr As String = StreamReader.ReadToEnd  '.Read 'Line()
                '<input type="hidden" name="TemplateID" value="Crapper33">
                Dim x = "<input type=""hidden"" name=""TemplateID"" value="""
                Dim lstrTemplateID As String = GetData(lstrFileStr.ToUpper, "<INPUT TYPE=""HIDDEN"" NAME=""TEMPLATEID"" VALUE=""", _
                     ChrGet(34))
                If lstrTemplateID = "" Then
                    lstrTemplateID = GetData(lstrFileStr.ToUpper, "<INPUT TYPE='HIDDEN' NAME='TEMPLATEID' VALUE='", "'")
                End If
                If lstrTemplateID = "" Then
                    lstrTemplateID = GetData(lstrFileStr.ToUpper, "<INPUT TYPE=HIDDEN NAME=TEMPLATEID VALUE=", ">")
                End If
                Dim lstrTemplateName As String = pfile.ToString
                lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".html", "")
                lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".htm", "")
                'SaveSetting("Name", lstrTemplateName, InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)
                'SaveSetting("FileName", pfile.ToString, InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)
                
                If lstrTemplateID <> "" Then
                    lstrTemplateID = lstrTemplateID.ToUpper
                End If
                SaveSetting("Name", lstrTemplateName, InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)
                SaveSetting("FileName", pfile.ToString, InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)

                AllUserTemplatesList(True, pfile.ToString, lstrTemplateID)
                StreamReader.Close()
                OpenFile.Close()
            End If
        Next pfile
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        lblSelectedBranch.Text = TreeView1.SelectedNode.FullPath
        lblSelectedBranch.Tag = "BRANCH" 
    End Sub

    Private Sub grpStart_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grpStart.Paint

        'commented 
        'Paper(e, 15, 15) '40)

    End Sub

    Private Sub Import_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        'Me.Top = (CallingForm.Height / 2) - (Me.Height / 2) + CallingForm.Top
        'Me.Left = (CallingForm.Width / 2) - (Me.Width / 2) + CallingForm.Left

    End Sub

    Private Sub rdoSubBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSubBranch.CheckedChanged
        TreeView1.Enabled = True
        grpBranchInsert_VisibleChanged(Nothing, Nothing)

    End Sub

    Private Sub rdoRootBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRootBranch.CheckedChanged

        TreeView1.SelectedNode = Nothing
        lblSelectedBranch.Text = "None Selected"
        lblSelectedBranch.Tag = "NONE" 
        TreeView1.Enabled = False
        grpBranchInsert_VisibleChanged(Nothing, Nothing)

    End Sub

    Private Sub grpBranchInsert_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpBranchInsert.VisibleChanged

        If TreeView1.Enabled = True Then
            TreeView1.BackColor = SystemColors.Window
        Else
            TreeView1.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub Import_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.importwizard)) 
    End Sub

    Private Sub Import_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Owner.Focus() 
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnNext.Enabled = pbool 
        btnCancel.Enabled = pbool 
        btnPrevious.Enabled = pbool 
        btnHelp.Enabled = pbool 
    End Sub
    Private Function CorrectTopicCode(ByVal pstrImportedCode As String) As String
        'created
        Dim lintArrInc As Integer

        If mstrTopics.GetUpperBound(0) = 0 And mstrTopics(0).Code = "" Then
            CorrectTopicCode = pstrImportedCode
            Exit Function
        End If

        For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
            If pstrImportedCode = mstrTopics(lintArrInc).TrueTopicCode Then
                CorrectTopicCode = mstrTopics(lintArrInc).Code
                Exit Function
            End If
        Next lintArrInc

        'Jyst in case it isn't found
        CorrectTopicCode = pstrImportedCode

    End Function
    Private Sub lblCanvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblCanvas.Paint
        
        UIStyle.Paper(e, 0, 0) '15, 15)
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnNext.BackColor = Color.FromArgb(0, btnNext.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnPrevious.BackColor = Color.FromArgb(0, btnPrevious.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        btnBrowse.BackColor = Color.FromArgb(0, btnBrowse.BackColor)
        chkTopics.BackColor = Color.FromArgb(0, chkTopics.BackColor)
        chkTemplates.BackColor = Color.FromArgb(0, chkTemplates.BackColor)
        chkBookmarks.BackColor = Color.FromArgb(0, chkBookmarks.BackColor)
        chkGeneralSettings.BackColor = Color.FromArgb(0, chkGeneralSettings.BackColor)
        chkColourSchemes.BackColor = Color.FromArgb(0, chkColourSchemes.BackColor)
        chkTemplateBookmarks.BackColor = Color.FromArgb(0, chkTemplateBookmarks.BackColor)
        grpStart.BackColor = Color.FromArgb(0, grpStart.BackColor)
        grpOptions.BackColor = Color.FromArgb(0, grpOptions.BackColor)
        grpBranchInsert.BackColor = Color.FromArgb(0, grpBranchInsert.BackColor)
        grpEnd.BackColor = Color.FromArgb(0, grpEnd.BackColor)
        rdoRootBranch.BackColor = Color.FromArgb(0, rdoRootBranch.BackColor)
        rdoSubBranch.BackColor = Color.FromArgb(0, rdoSubBranch.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        Label5.BackColor = Color.FromArgb(0, Label5.BackColor)
        Label6.BackColor = Color.FromArgb(0, Label6.BackColor)
        'lblCanvas.BackColor = Color.FromArgb(0, lblCanvas.BackColor) ' Error
        lblImportFile.BackColor = Color.FromArgb(0, lblImportFile.BackColor)
        lblSelectedBranch.BackColor = Color.FromArgb(0, lblSelectedBranch.BackColor)
        lblImportFile.BackColor = Color.FromArgb(0, lblImportFile.BackColor)
        lblImportFile.BackColor = Color.FromArgb(0, lblImportFile.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        'Added 
        If IsAboveOrEqualWinXp() = True Then
            'rdoRootBranch.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoRootBranch.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoRootBranch.Top, rdoRootBranch.Left, rdoRootBranch.Width, rdoRootBranch.Height)
            'rdoSubBranch.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoSubBranch.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoSubBranch.Top, rdoSubBranch.Left, rdoSubBranch.Width, rdoSubBranch.Height)
        Else
            
            chkTopics.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTopics.Top, chkTopics.Left, chkTopics.Width, chkTopics.Height)
            chkTemplates.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTemplates.Top, chkTemplates.Left, chkTemplates.Width, chkTemplates.Height)
            chkBookmarks.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkBookmarks.Top, chkBookmarks.Left, chkBookmarks.Width, chkBookmarks.Height)
            chkGeneralSettings.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkGeneralSettings.Top, chkGeneralSettings.Left, chkGeneralSettings.Width, chkGeneralSettings.Height)
            chkColourSchemes.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkColourSchemes.Top, chkColourSchemes.Left, chkColourSchemes.Width, chkColourSchemes.Height)
            chkTemplateBookmarks.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTemplateBookmarks.Top, chkTemplateBookmarks.Left, chkTemplateBookmarks.Width, chkTemplateBookmarks.Height)
            
        End If

    End Sub

    Private Sub Import_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class