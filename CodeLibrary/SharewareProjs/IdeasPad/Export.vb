Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Checksums
Imports System.Xml

Friend Class Export
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpTemplateSelection As System.Windows.Forms.GroupBox
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents grpTopicSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents chkTopics As System.Windows.Forms.CheckBox
    Friend WithEvents chkTemplates As System.Windows.Forms.CheckBox
    Friend WithEvents chkBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkColourSchemes As System.Windows.Forms.CheckBox
    Friend WithEvents grpEnd As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents rdoExportBranch As System.Windows.Forms.RadioButton
    Friend WithEvents rdoExportAll As System.Windows.Forms.RadioButton
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents chkTemplateBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents tvUserTemplateSelection As System.Windows.Forms.TreeView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lstWarnings As System.Windows.Forms.ListBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents lblCongrats As System.Windows.Forms.Label
    Friend WithEvents tvCSSFiles As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblCanvas As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Export))
        Me.grpTemplateSelection = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tvCSSFiles = New System.Windows.Forms.TreeView()
        Me.tvUserTemplateSelection = New System.Windows.Forms.TreeView()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.chkGeneralSettings = New System.Windows.Forms.CheckBox()
        Me.chkTemplateBookmarks = New System.Windows.Forms.CheckBox()
        Me.chkBookmarks = New System.Windows.Forms.CheckBox()
        Me.chkColourSchemes = New System.Windows.Forms.CheckBox()
        Me.chkTemplates = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTopics = New System.Windows.Forms.CheckBox()
        Me.grpTopicSelection = New System.Windows.Forms.GroupBox()
        Me.rdoExportBranch = New System.Windows.Forms.RadioButton()
        Me.rdoExportAll = New System.Windows.Forms.RadioButton()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpEnd = New System.Windows.Forms.GroupBox()
        Me.lblCongrats = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lstWarnings = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpTemplateSelection.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.grpTopicSelection.SuspendLayout()
        Me.grpEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTemplateSelection
        '
        Me.grpTemplateSelection.AccessibleDescription = CType(resources.GetObject("grpTemplateSelection.AccessibleDescription"), String)
        Me.grpTemplateSelection.AccessibleName = CType(resources.GetObject("grpTemplateSelection.AccessibleName"), String)
        Me.grpTemplateSelection.Anchor = CType(resources.GetObject("grpTemplateSelection.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpTemplateSelection.BackgroundImage = CType(resources.GetObject("grpTemplateSelection.BackgroundImage"), System.Drawing.Image)
        Me.grpTemplateSelection.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.Label2, Me.tvCSSFiles, Me.tvUserTemplateSelection})
        Me.grpTemplateSelection.Dock = CType(resources.GetObject("grpTemplateSelection.Dock"), System.Windows.Forms.DockStyle)
        Me.grpTemplateSelection.Enabled = CType(resources.GetObject("grpTemplateSelection.Enabled"), Boolean)
        Me.grpTemplateSelection.Font = CType(resources.GetObject("grpTemplateSelection.Font"), System.Drawing.Font)
        Me.grpTemplateSelection.ImeMode = CType(resources.GetObject("grpTemplateSelection.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpTemplateSelection.Location = CType(resources.GetObject("grpTemplateSelection.Location"), System.Drawing.Point)
        Me.grpTemplateSelection.Name = "grpTemplateSelection"
        Me.grpTemplateSelection.RightToLeft = CType(resources.GetObject("grpTemplateSelection.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpTemplateSelection.Size = CType(resources.GetObject("grpTemplateSelection.Size"), System.Drawing.Size)
        Me.grpTemplateSelection.TabIndex = CType(resources.GetObject("grpTemplateSelection.TabIndex"), Integer)
        Me.grpTemplateSelection.TabStop = False
        Me.grpTemplateSelection.Text = resources.GetString("grpTemplateSelection.Text")
        Me.grpTemplateSelection.Visible = CType(resources.GetObject("grpTemplateSelection.Visible"), Boolean)
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
        'tvCSSFiles
        '
        Me.tvCSSFiles.AccessibleDescription = CType(resources.GetObject("tvCSSFiles.AccessibleDescription"), String)
        Me.tvCSSFiles.AccessibleName = CType(resources.GetObject("tvCSSFiles.AccessibleName"), String)
        Me.tvCSSFiles.Anchor = CType(resources.GetObject("tvCSSFiles.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.tvCSSFiles.BackgroundImage = CType(resources.GetObject("tvCSSFiles.BackgroundImage"), System.Drawing.Image)
        Me.tvCSSFiles.CheckBoxes = True
        Me.tvCSSFiles.Dock = CType(resources.GetObject("tvCSSFiles.Dock"), System.Windows.Forms.DockStyle)
        Me.tvCSSFiles.Enabled = CType(resources.GetObject("tvCSSFiles.Enabled"), Boolean)
        Me.tvCSSFiles.Font = CType(resources.GetObject("tvCSSFiles.Font"), System.Drawing.Font)
        Me.tvCSSFiles.ImageIndex = CType(resources.GetObject("tvCSSFiles.ImageIndex"), Integer)
        Me.tvCSSFiles.ImeMode = CType(resources.GetObject("tvCSSFiles.ImeMode"), System.Windows.Forms.ImeMode)
        Me.tvCSSFiles.Indent = CType(resources.GetObject("tvCSSFiles.Indent"), Integer)
        Me.tvCSSFiles.ItemHeight = CType(resources.GetObject("tvCSSFiles.ItemHeight"), Integer)
        Me.tvCSSFiles.Location = CType(resources.GetObject("tvCSSFiles.Location"), System.Drawing.Point)
        Me.tvCSSFiles.Name = "tvCSSFiles"
        Me.tvCSSFiles.RightToLeft = CType(resources.GetObject("tvCSSFiles.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.tvCSSFiles.SelectedImageIndex = CType(resources.GetObject("tvCSSFiles.SelectedImageIndex"), Integer)
        Me.tvCSSFiles.ShowLines = False
        Me.tvCSSFiles.ShowPlusMinus = False
        Me.tvCSSFiles.ShowRootLines = False
        Me.tvCSSFiles.Size = CType(resources.GetObject("tvCSSFiles.Size"), System.Drawing.Size)
        Me.tvCSSFiles.TabIndex = CType(resources.GetObject("tvCSSFiles.TabIndex"), Integer)
        Me.tvCSSFiles.Text = resources.GetString("tvCSSFiles.Text")
        Me.tvCSSFiles.Visible = CType(resources.GetObject("tvCSSFiles.Visible"), Boolean)
        '
        'tvUserTemplateSelection
        '
        Me.tvUserTemplateSelection.AccessibleDescription = CType(resources.GetObject("tvUserTemplateSelection.AccessibleDescription"), String)
        Me.tvUserTemplateSelection.AccessibleName = CType(resources.GetObject("tvUserTemplateSelection.AccessibleName"), String)
        Me.tvUserTemplateSelection.Anchor = CType(resources.GetObject("tvUserTemplateSelection.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.tvUserTemplateSelection.BackgroundImage = CType(resources.GetObject("tvUserTemplateSelection.BackgroundImage"), System.Drawing.Image)
        Me.tvUserTemplateSelection.CheckBoxes = True
        Me.tvUserTemplateSelection.Dock = CType(resources.GetObject("tvUserTemplateSelection.Dock"), System.Windows.Forms.DockStyle)
        Me.tvUserTemplateSelection.Enabled = CType(resources.GetObject("tvUserTemplateSelection.Enabled"), Boolean)
        Me.tvUserTemplateSelection.Font = CType(resources.GetObject("tvUserTemplateSelection.Font"), System.Drawing.Font)
        Me.tvUserTemplateSelection.ImageIndex = CType(resources.GetObject("tvUserTemplateSelection.ImageIndex"), Integer)
        Me.tvUserTemplateSelection.ImeMode = CType(resources.GetObject("tvUserTemplateSelection.ImeMode"), System.Windows.Forms.ImeMode)
        Me.tvUserTemplateSelection.Indent = CType(resources.GetObject("tvUserTemplateSelection.Indent"), Integer)
        Me.tvUserTemplateSelection.ItemHeight = CType(resources.GetObject("tvUserTemplateSelection.ItemHeight"), Integer)
        Me.tvUserTemplateSelection.Location = CType(resources.GetObject("tvUserTemplateSelection.Location"), System.Drawing.Point)
        Me.tvUserTemplateSelection.Name = "tvUserTemplateSelection"
        Me.tvUserTemplateSelection.RightToLeft = CType(resources.GetObject("tvUserTemplateSelection.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.tvUserTemplateSelection.SelectedImageIndex = CType(resources.GetObject("tvUserTemplateSelection.SelectedImageIndex"), Integer)
        Me.tvUserTemplateSelection.ShowLines = False
        Me.tvUserTemplateSelection.ShowPlusMinus = False
        Me.tvUserTemplateSelection.ShowRootLines = False
        Me.tvUserTemplateSelection.Size = CType(resources.GetObject("tvUserTemplateSelection.Size"), System.Drawing.Size)
        Me.tvUserTemplateSelection.TabIndex = CType(resources.GetObject("tvUserTemplateSelection.TabIndex"), Integer)
        Me.tvUserTemplateSelection.Text = resources.GetString("tvUserTemplateSelection.Text")
        Me.tvUserTemplateSelection.Visible = CType(resources.GetObject("tvUserTemplateSelection.Visible"), Boolean)
        '
        'grpMain
        '
        Me.grpMain.AccessibleDescription = CType(resources.GetObject("grpMain.AccessibleDescription"), String)
        Me.grpMain.AccessibleName = CType(resources.GetObject("grpMain.AccessibleName"), String)
        Me.grpMain.Anchor = CType(resources.GetObject("grpMain.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpMain.BackgroundImage = CType(resources.GetObject("grpMain.BackgroundImage"), System.Drawing.Image)
        Me.grpMain.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkGeneralSettings, Me.chkTemplateBookmarks, Me.chkBookmarks, Me.chkColourSchemes, Me.chkTemplates, Me.Label1, Me.chkTopics})
        Me.grpMain.Dock = CType(resources.GetObject("grpMain.Dock"), System.Windows.Forms.DockStyle)
        Me.grpMain.Enabled = CType(resources.GetObject("grpMain.Enabled"), Boolean)
        Me.grpMain.Font = CType(resources.GetObject("grpMain.Font"), System.Drawing.Font)
        Me.grpMain.ImeMode = CType(resources.GetObject("grpMain.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpMain.Location = CType(resources.GetObject("grpMain.Location"), System.Drawing.Point)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.RightToLeft = CType(resources.GetObject("grpMain.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpMain.Size = CType(resources.GetObject("grpMain.Size"), System.Drawing.Size)
        Me.grpMain.TabIndex = CType(resources.GetObject("grpMain.TabIndex"), Integer)
        Me.grpMain.TabStop = False
        Me.grpMain.Text = resources.GetString("grpMain.Text")
        Me.grpMain.Visible = CType(resources.GetObject("grpMain.Visible"), Boolean)
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
        'grpTopicSelection
        '
        Me.grpTopicSelection.AccessibleDescription = CType(resources.GetObject("grpTopicSelection.AccessibleDescription"), String)
        Me.grpTopicSelection.AccessibleName = CType(resources.GetObject("grpTopicSelection.AccessibleName"), String)
        Me.grpTopicSelection.Anchor = CType(resources.GetObject("grpTopicSelection.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpTopicSelection.BackgroundImage = CType(resources.GetObject("grpTopicSelection.BackgroundImage"), System.Drawing.Image)
        Me.grpTopicSelection.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdoExportBranch, Me.rdoExportAll, Me.TreeView1})
        Me.grpTopicSelection.Dock = CType(resources.GetObject("grpTopicSelection.Dock"), System.Windows.Forms.DockStyle)
        Me.grpTopicSelection.Enabled = CType(resources.GetObject("grpTopicSelection.Enabled"), Boolean)
        Me.grpTopicSelection.Font = CType(resources.GetObject("grpTopicSelection.Font"), System.Drawing.Font)
        Me.grpTopicSelection.ImeMode = CType(resources.GetObject("grpTopicSelection.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpTopicSelection.Location = CType(resources.GetObject("grpTopicSelection.Location"), System.Drawing.Point)
        Me.grpTopicSelection.Name = "grpTopicSelection"
        Me.grpTopicSelection.RightToLeft = CType(resources.GetObject("grpTopicSelection.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpTopicSelection.Size = CType(resources.GetObject("grpTopicSelection.Size"), System.Drawing.Size)
        Me.grpTopicSelection.TabIndex = CType(resources.GetObject("grpTopicSelection.TabIndex"), Integer)
        Me.grpTopicSelection.TabStop = False
        Me.grpTopicSelection.Text = resources.GetString("grpTopicSelection.Text")
        Me.grpTopicSelection.Visible = CType(resources.GetObject("grpTopicSelection.Visible"), Boolean)
        '
        'rdoExportBranch
        '
        Me.rdoExportBranch.AccessibleDescription = CType(resources.GetObject("rdoExportBranch.AccessibleDescription"), String)
        Me.rdoExportBranch.AccessibleName = CType(resources.GetObject("rdoExportBranch.AccessibleName"), String)
        Me.rdoExportBranch.Anchor = CType(resources.GetObject("rdoExportBranch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoExportBranch.Appearance = CType(resources.GetObject("rdoExportBranch.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoExportBranch.BackgroundImage = CType(resources.GetObject("rdoExportBranch.BackgroundImage"), System.Drawing.Image)
        Me.rdoExportBranch.CheckAlign = CType(resources.GetObject("rdoExportBranch.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportBranch.Dock = CType(resources.GetObject("rdoExportBranch.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoExportBranch.Enabled = CType(resources.GetObject("rdoExportBranch.Enabled"), Boolean)
        Me.rdoExportBranch.FlatStyle = CType(resources.GetObject("rdoExportBranch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoExportBranch.Font = CType(resources.GetObject("rdoExportBranch.Font"), System.Drawing.Font)
        Me.rdoExportBranch.Image = CType(resources.GetObject("rdoExportBranch.Image"), System.Drawing.Image)
        Me.rdoExportBranch.ImageAlign = CType(resources.GetObject("rdoExportBranch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportBranch.ImageIndex = CType(resources.GetObject("rdoExportBranch.ImageIndex"), Integer)
        Me.rdoExportBranch.ImeMode = CType(resources.GetObject("rdoExportBranch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoExportBranch.Location = CType(resources.GetObject("rdoExportBranch.Location"), System.Drawing.Point)
        Me.rdoExportBranch.Name = "rdoExportBranch"
        Me.rdoExportBranch.RightToLeft = CType(resources.GetObject("rdoExportBranch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoExportBranch.Size = CType(resources.GetObject("rdoExportBranch.Size"), System.Drawing.Size)
        Me.rdoExportBranch.TabIndex = CType(resources.GetObject("rdoExportBranch.TabIndex"), Integer)
        Me.rdoExportBranch.Text = resources.GetString("rdoExportBranch.Text")
        Me.rdoExportBranch.TextAlign = CType(resources.GetObject("rdoExportBranch.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportBranch.Visible = CType(resources.GetObject("rdoExportBranch.Visible"), Boolean)
        '
        'rdoExportAll
        '
        Me.rdoExportAll.AccessibleDescription = CType(resources.GetObject("rdoExportAll.AccessibleDescription"), String)
        Me.rdoExportAll.AccessibleName = CType(resources.GetObject("rdoExportAll.AccessibleName"), String)
        Me.rdoExportAll.Anchor = CType(resources.GetObject("rdoExportAll.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoExportAll.Appearance = CType(resources.GetObject("rdoExportAll.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoExportAll.BackgroundImage = CType(resources.GetObject("rdoExportAll.BackgroundImage"), System.Drawing.Image)
        Me.rdoExportAll.CheckAlign = CType(resources.GetObject("rdoExportAll.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportAll.Checked = True
        Me.rdoExportAll.Dock = CType(resources.GetObject("rdoExportAll.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoExportAll.Enabled = CType(resources.GetObject("rdoExportAll.Enabled"), Boolean)
        Me.rdoExportAll.FlatStyle = CType(resources.GetObject("rdoExportAll.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoExportAll.Font = CType(resources.GetObject("rdoExportAll.Font"), System.Drawing.Font)
        Me.rdoExportAll.Image = CType(resources.GetObject("rdoExportAll.Image"), System.Drawing.Image)
        Me.rdoExportAll.ImageAlign = CType(resources.GetObject("rdoExportAll.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportAll.ImageIndex = CType(resources.GetObject("rdoExportAll.ImageIndex"), Integer)
        Me.rdoExportAll.ImeMode = CType(resources.GetObject("rdoExportAll.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoExportAll.Location = CType(resources.GetObject("rdoExportAll.Location"), System.Drawing.Point)
        Me.rdoExportAll.Name = "rdoExportAll"
        Me.rdoExportAll.RightToLeft = CType(resources.GetObject("rdoExportAll.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoExportAll.Size = CType(resources.GetObject("rdoExportAll.Size"), System.Drawing.Size)
        Me.rdoExportAll.TabIndex = CType(resources.GetObject("rdoExportAll.TabIndex"), Integer)
        Me.rdoExportAll.TabStop = True
        Me.rdoExportAll.Text = resources.GetString("rdoExportAll.Text")
        Me.rdoExportAll.TextAlign = CType(resources.GetObject("rdoExportAll.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoExportAll.Visible = CType(resources.GetObject("rdoExportAll.Visible"), Boolean)
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
        'grpEnd
        '
        Me.grpEnd.AccessibleDescription = CType(resources.GetObject("grpEnd.AccessibleDescription"), String)
        Me.grpEnd.AccessibleName = CType(resources.GetObject("grpEnd.AccessibleName"), String)
        Me.grpEnd.Anchor = CType(resources.GetObject("grpEnd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpEnd.BackgroundImage = CType(resources.GetObject("grpEnd.BackgroundImage"), System.Drawing.Image)
        Me.grpEnd.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCongrats, Me.lblWarning, Me.lstWarnings, Me.ProgressBar1})
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
        'lblCongrats
        '
        Me.lblCongrats.AccessibleDescription = CType(resources.GetObject("lblCongrats.AccessibleDescription"), String)
        Me.lblCongrats.AccessibleName = CType(resources.GetObject("lblCongrats.AccessibleName"), String)
        Me.lblCongrats.Anchor = CType(resources.GetObject("lblCongrats.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCongrats.AutoSize = CType(resources.GetObject("lblCongrats.AutoSize"), Boolean)
        Me.lblCongrats.Dock = CType(resources.GetObject("lblCongrats.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCongrats.Enabled = CType(resources.GetObject("lblCongrats.Enabled"), Boolean)
        Me.lblCongrats.Font = CType(resources.GetObject("lblCongrats.Font"), System.Drawing.Font)
        Me.lblCongrats.Image = CType(resources.GetObject("lblCongrats.Image"), System.Drawing.Image)
        Me.lblCongrats.ImageAlign = CType(resources.GetObject("lblCongrats.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCongrats.ImageIndex = CType(resources.GetObject("lblCongrats.ImageIndex"), Integer)
        Me.lblCongrats.ImeMode = CType(resources.GetObject("lblCongrats.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCongrats.Location = CType(resources.GetObject("lblCongrats.Location"), System.Drawing.Point)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.RightToLeft = CType(resources.GetObject("lblCongrats.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblCongrats.Size = CType(resources.GetObject("lblCongrats.Size"), System.Drawing.Size)
        Me.lblCongrats.TabIndex = CType(resources.GetObject("lblCongrats.TabIndex"), Integer)
        Me.lblCongrats.Text = resources.GetString("lblCongrats.Text")
        Me.lblCongrats.TextAlign = CType(resources.GetObject("lblCongrats.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCongrats.Visible = CType(resources.GetObject("lblCongrats.Visible"), Boolean)
        '
        'lblWarning
        '
        Me.lblWarning.AccessibleDescription = CType(resources.GetObject("lblWarning.AccessibleDescription"), String)
        Me.lblWarning.AccessibleName = CType(resources.GetObject("lblWarning.AccessibleName"), String)
        Me.lblWarning.Anchor = CType(resources.GetObject("lblWarning.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.AutoSize = CType(resources.GetObject("lblWarning.AutoSize"), Boolean)
        Me.lblWarning.Dock = CType(resources.GetObject("lblWarning.Dock"), System.Windows.Forms.DockStyle)
        Me.lblWarning.Enabled = CType(resources.GetObject("lblWarning.Enabled"), Boolean)
        Me.lblWarning.Font = CType(resources.GetObject("lblWarning.Font"), System.Drawing.Font)
        Me.lblWarning.Image = CType(resources.GetObject("lblWarning.Image"), System.Drawing.Image)
        Me.lblWarning.ImageAlign = CType(resources.GetObject("lblWarning.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblWarning.ImageIndex = CType(resources.GetObject("lblWarning.ImageIndex"), Integer)
        Me.lblWarning.ImeMode = CType(resources.GetObject("lblWarning.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblWarning.Location = CType(resources.GetObject("lblWarning.Location"), System.Drawing.Point)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.RightToLeft = CType(resources.GetObject("lblWarning.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblWarning.Size = CType(resources.GetObject("lblWarning.Size"), System.Drawing.Size)
        Me.lblWarning.TabIndex = CType(resources.GetObject("lblWarning.TabIndex"), Integer)
        Me.lblWarning.Text = resources.GetString("lblWarning.Text")
        Me.lblWarning.TextAlign = CType(resources.GetObject("lblWarning.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblWarning.Visible = CType(resources.GetObject("lblWarning.Visible"), Boolean)
        '
        'lstWarnings
        '
        Me.lstWarnings.AccessibleDescription = CType(resources.GetObject("lstWarnings.AccessibleDescription"), String)
        Me.lstWarnings.AccessibleName = CType(resources.GetObject("lstWarnings.AccessibleName"), String)
        Me.lstWarnings.Anchor = CType(resources.GetObject("lstWarnings.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstWarnings.BackgroundImage = CType(resources.GetObject("lstWarnings.BackgroundImage"), System.Drawing.Image)
        Me.lstWarnings.ColumnWidth = CType(resources.GetObject("lstWarnings.ColumnWidth"), Integer)
        Me.lstWarnings.Dock = CType(resources.GetObject("lstWarnings.Dock"), System.Windows.Forms.DockStyle)
        Me.lstWarnings.Enabled = CType(resources.GetObject("lstWarnings.Enabled"), Boolean)
        Me.lstWarnings.Font = CType(resources.GetObject("lstWarnings.Font"), System.Drawing.Font)
        Me.lstWarnings.HorizontalExtent = CType(resources.GetObject("lstWarnings.HorizontalExtent"), Integer)
        Me.lstWarnings.HorizontalScrollbar = CType(resources.GetObject("lstWarnings.HorizontalScrollbar"), Boolean)
        Me.lstWarnings.ImeMode = CType(resources.GetObject("lstWarnings.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstWarnings.IntegralHeight = CType(resources.GetObject("lstWarnings.IntegralHeight"), Boolean)
        Me.lstWarnings.ItemHeight = CType(resources.GetObject("lstWarnings.ItemHeight"), Integer)
        Me.lstWarnings.Location = CType(resources.GetObject("lstWarnings.Location"), System.Drawing.Point)
        Me.lstWarnings.Name = "lstWarnings"
        Me.lstWarnings.RightToLeft = CType(resources.GetObject("lstWarnings.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstWarnings.ScrollAlwaysVisible = CType(resources.GetObject("lstWarnings.ScrollAlwaysVisible"), Boolean)
        Me.lstWarnings.Size = CType(resources.GetObject("lstWarnings.Size"), System.Drawing.Size)
        Me.lstWarnings.TabIndex = CType(resources.GetObject("lstWarnings.TabIndex"), Integer)
        Me.lstWarnings.Visible = CType(resources.GetObject("lstWarnings.Visible"), Boolean)
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
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = resources.GetString("SaveFileDialog1.Title")
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
        'Export
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnHelp, Me.grpTemplateSelection, Me.grpEnd, Me.btnPrevious, Me.btnNext, Me.grpTopicSelection, Me.grpMain})
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
        Me.Name = "Export"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.grpTemplateSelection.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpTopicSelection.ResumeLayout(False)
        Me.grpEnd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mstrCallingForm As Form
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 

    Friend Property CallingForm() As Form
        Get
            Return mstrCallingForm
        End Get
        Set(ByVal Value As Form)
            mstrCallingForm = Value
        End Set
    End Property
    Friend Structure Topics
        Dim Code As String
        Dim Level As Long
        Dim ImgIdx As Integer
        Dim Title As String
        Dim Sequence As Integer
        Dim Parent As String
        'Dim HCode As Integer
        Dim TrueTopicCode As String
        Dim booParentUpdated As Boolean
        Dim booTopicUpdated As Boolean
        Dim booLinkTopic As Boolean 
    End Structure
    Friend Structure TopicDetail
        Dim Code As String
        Dim OldCode As String
        Dim TemplateID As String
        Dim booTopicUpdated As Boolean
        'not required as the import files builds a new ByteLen on import
        'Dim ByteLen As Integer 
        Dim Options As String 
    End Structure
    Friend Structure DetailNames
        Dim Title As String
        Dim TemplateID As String
        Dim ByteLen As Integer 
        Dim Options As String 
    End Structure
    'Dim lintCheckedItem As TreeNode
    Dim lstrLastFullPath As String
    Dim mstrIndexArray() As TreeTopics
    Dim lintIndexCounter As Integer
    Dim mstrTopics() As Topics

    Dim mbooAllTopicsSelected As Boolean = False 'True
    Dim lstrCssFiles(0) As String
    Private Sub btnSelectTopics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'gstrConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        '"Data Source=D:\MclDocsLocal\IdeasDBs\MmosNew.mdb;Persist Security Info=False;User ID=IPUser;" & _
        '"Password=CEF01FE3D66AC;Jet OLEDB:Database Password=32khdssa976;Jet OLEDB:System database=D:\MclDocsLocal\IdeasDBs\MmosNew.mdw;"

        ''Dim x As New TopicExportSelect()
        ''Dim lstrTopics() As TopicExportSelect.Topics

        ''Dim ldlgResult As DialogResult = x.ShowDialog()
        ''If ldlgResult = DialogResult.Cancel Then
        ''    Exit Sub
        ''End If


        ''x.SelectedTopics(lstrTopics)

        ''ExportTopics(lstrTopics, x.AllTopicsSelected())

        ''Dim lstrTopicDetails(0) As TopicExportSelect.TopicDetail
        ''ExportTopicsDetails(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
        ''    "\Export\", lstrTopics, x.AllTopicsSelected(), lstrTopicDetails)

        ''mxessagebox.show("test import now, still need to dump and read dat from file.")

        ''Dim y As New Import()
        ''y.SetSelectedTopics(lstrTopics)
        ''y.SetSelectedTopicDetails(lstrTopicDetails)
        ''y.ShowDialog()

        ''Array lstrTopics will now have extra details added
        ''File Orphans, set thier parent code to NEW.
        'Dim lintArrInc, lintArrInc2 As Integer
        'For lintArrInc = 0 To lstrTopics.GetUpperBound(0)
        '    Dim lstrThisParentCode As String = lstrTopics(lintArrInc).Parent
        '    Dim lbooOrphanBranch As Boolean = True
        '    If lstrThisParentCode <> "" Then
        '        For lintArrInc2 = 0 To lstrTopics.GetUpperBound(0)
        '            If lstrTopics(lintArrInc2).Code = lstrThisParentCode Then
        '                'a parent has been found
        '                lbooOrphanBranch = False
        '                lstrTopics(lintArrInc).HCode = 1
        '                Exit For
        '            End If
        '        Next lintArrInc2
        '        If lbooOrphanBranch = True Then
        '            'clear parent code, if no parent found
        '            lstrTopics(lintArrInc).Parent = ""
        '            lstrTopics(lintArrInc).HCode = 1
        '        End If
        '    Else
        '        'lstrTopics(lintArrInc).Parent = "ONE"
        '        lstrTopics(lintArrInc).HCode = 1
        '    End If
        'Next lintArrInc

        'Console.WriteLine("Before")
        'DebugTopicArray(lstrTopics)
        'Console.WriteLine("After")
        ''----
        'Dim HCode As Integer = 1
        'Dim AParentIsFound As Integer = 0
        'Dim ThisParent As String
        'Dim AllDone As Boolean = False

        'Do Until AllDone = True
        '    '---- Get a parent ----
        '    Do Until AParentIsFound > 0
        '        For lintArrInc = 0 To lstrTopics.GetUpperBound(0)
        '            If lstrTopics(lintArrInc).HCode = HCode Then
        '                ThisParent = lstrTopics(lintArrInc).Code
        '                lstrTopics(lintArrInc).Level = HCode
        '                AParentIsFound = 1 'found
        '                Exit For
        '            End If
        '        Next lintArrInc
        '        If AParentIsFound = 0 Then
        '            HCode += 1
        '        End If

        '        '--look for exit time from parent find
        '        Dim FindMore As Boolean = False
        '        For lintArrInc = 0 To lstrTopics.GetUpperBound(0)
        '            If lstrTopics(lintArrInc).HCode = 0 Then
        '                FindMore = True
        '                AParentIsFound = 2 'exit
        '                Exit For
        '            End If
        '            If FindMore = True Then AParentIsFound = 2
        '        Next lintArrInc
        '        '--look for exit time from parent find
        '    Loop 'AParentIsFound = True
        '    If AParentIsFound = 2 Then
        '        Exit Do 'no parents left
        '    End If
        '    '---- Get a parent ----

        '    '---- assign new levels for children ----
        '    For lintArrInc = 0 To lstrTopics.GetUpperBound(0)
        '        If ThisParent = lstrTopics(lintArrInc).Code Then
        '            lstrTopics(lintArrInc).Level = HCode
        '        End If
        '    Next lintArrInc
        '    '---- assign new levels for children ----

        '    For lintArrInc = 0 To lstrTopics.GetUpperBound(0)
        '        AllDone = True
        '        If lstrTopics(lintArrInc).HCode = 0 Then
        '            AllDone = False
        '            Exit For
        '        End If
        '    Next lintArrInc
        'Loop 'AllDone = True
        ''----


        'DebugTopicArray(lstrTopics)

        'for each top level branch
        'Add to an array, topics with it's parent code, and assign new E codes and levels
        'then all of there children
        'Mark a flag to identify all the topics which have been used.
        'Write array to XML file

        'as a test write the arrays to a treeview.

    End Sub
    Private Sub Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Text = NameMe("Export Wizard")

        Me.Text = NameMe(LangText.GetString("Export_FormTitle")) 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnNext.FlatStyle = FlatStyle.System
            btnPrevious.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            
            rdoExportBranch.FlatStyle = FlatStyle.System
            rdoExportAll.FlatStyle = FlatStyle.System
            
        End If 
        ''If IsAboveOrEqualWinXp() = False Then 
        ''    chkTopics.FlatStyle = FlatStyle.System
        ''    chkTemplates.FlatStyle = FlatStyle.System
        ''    chkBookmarks.FlatStyle = FlatStyle.System
        ''    chkGeneralSettings.FlatStyle = FlatStyle.System
        ''    chkColourSchemes.FlatStyle = FlatStyle.System
        ''    chkTemplateBookmarks.FlatStyle = FlatStyle.System
        ''End If 
        'grpMain.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpTemplateSelection.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpTopicSelection.FlatStyle = FlatStyle.System 'Commented for transparency 
        'grpEnd.FlatStyle = FlatStyle.System 'Commented for transparency 
        'rdoExportBranch.FlatStyle = FlatStyle.System
        'rdoExportAll.FlatStyle = FlatStyle.System

        SetBackcolors() 

        lblCanvas = New System.Windows.Forms.Label()
        grpMain.Controls.AddRange(New System.Windows.Forms.Control() {lblCanvas})
        lblCanvas.Top = 15
        lblCanvas.Left = 15
        lblCanvas.Height = 200
        lblCanvas.Width = 200
        lblCanvas.Text = ""
        

        btnNext.Tag = "NEXT" 

        'Me.Size = New Size(374, 299)
        grpMain.Location = New System.Drawing.Point(8, 8)
        grpTemplateSelection.Location = New System.Drawing.Point(8, 8)
        grpTopicSelection.Location = New System.Drawing.Point(8, 8)
        'grpColourSchemeSelection.Location = New System.Drawing.Point(8, 8)
        grpEnd.Location = New System.Drawing.Point(8, 8)

        '    gstrConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        '"Data Source=D:\MclDocsLocal\IdeasDBs\MmosNew.mdb;Persist Security Info=False;User ID=IPUser;" & _
        '"Password=CEF01FE3D66AC;Jet OLEDB:Database Password=32khdssa976;Jet OLEDB:System database=D:\MclDocsLocal\IdeasDBs\MmosNew.mdw;"

        '---- topic select stuff ----
        Busy(Me, True)
        BusyButtons(True) 
        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder)
        TreeView1.Enabled = False
        Busy(Me, False)
        BusyButtons(False) 
        '---- topic select stuff ----

        
        If mstrIndexArray(0).strTopicCode = "" Then
            chkTopics.Enabled = False
        End If
        

        LoadUserTemplatestreeview(tvUserTemplateSelection)
        LoadUserCSStreeview(lstrCssFiles, tvCSSFiles)


        Dim InitialTemplates As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
        If InitialTemplates.GetValue("Name" & 0, "") <> "" Or InitialTemplates.GetValue("Name" & 1, "") <> "" Then 
            chkTemplateBookmarks.Enabled = True 
        Else 
            chkTemplateBookmarks.Enabled = False 
        End If

        Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID)
        If InitialBookmarks.GetValue("BookmarkName-" & 0, "") <> "" Or InitialBookmarks.GetValue("BookmarkName-" & 1, "") <> "" Then 
            chkBookmarks.Enabled = True 
        Else 
            chkBookmarks.Enabled = False 
        End If

        btnPrevious.Enabled = False 

    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If chkTopics.Checked = False And chkTemplates.Checked = False And chkColourSchemes.Checked = False _
            And chkBookmarks.Checked = False And chkGeneralSettings.Checked = False And chkTemplateBookmarks.Checked = False Then
            'mxessagebox.show("You must select something to export!", NameMe(""))
            If gbooAlwaysOnTop = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("Export_MustSelSomething"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

            Exit Sub
        End If

        btnPrevious.Enabled = True 
        If grpMain.Visible = True Then
            grpMain.Visible = False
            If chkTopics.Checked = True Then
                grpTopicSelection.Visible = True
                Exit Sub
            End If

            tvUserTemplateSelection.Enabled = chkTemplates.Checked
            tvCSSFiles.Enabled = chkColourSchemes.Checked

            If chkTemplates.Checked = True Or chkColourSchemes.Checked = True Then
                grpTemplateSelection.Visible = True
                Exit Sub
            End If
            grpEnd.SuspendLayout()
            'btnNext.Text = "&Export"
            btnNext.Text = LangText.GetString("Export_ButtonExport") 
            btnNext.Tag = "EXPORT" 

            DependencyCheck() : System.Windows.Forms.Application.DoEvents()
            grpEnd.Visible = True
            grpEnd.ResumeLayout()
            Exit Sub
        End If

        If grpTopicSelection.Visible = True Then
            Dim Proceed As Boolean = SelectTopics()
            If Proceed = False Then Exit Sub
            grpTopicSelection.Visible = False

            tvUserTemplateSelection.Enabled = chkTemplates.Checked
            tvCSSFiles.Enabled = chkColourSchemes.Checked

            If chkTemplates.Checked = True Or chkColourSchemes.Checked = True Then
                grpTemplateSelection.Visible = True
                Exit Sub
            End If
            grpEnd.SuspendLayout()
            btnNext.Text = LangText.GetString("Export_ButtonExport") 
            btnNext.Tag = "EXPORT" 

            DependencyCheck() : System.Windows.Forms.Application.DoEvents()
            grpEnd.Visible = True
            grpEnd.ResumeLayout()
            Exit Sub
        End If

        If grpTemplateSelection.Visible = True Then
            grpTemplateSelection.Visible = False
            'If chkColourSchemes.Checked = True Then
            '    grpColourSchemeSelection.Visible = True
            '    Exit Sub
            'End If
            grpEnd.SuspendLayout()
            'btnNext.Text = "&Export"
            btnNext.Text = LangText.GetString("Export_ButtonExport") 
            btnNext.Tag = "EXPORT" 

            DependencyCheck() : System.Windows.Forms.Application.DoEvents()
            grpEnd.Visible = True
            grpEnd.ResumeLayout()
            Exit Sub
        End If

        'If grpColourSchemeSelection.Visible = True Then
        '    grpColourSchemeSelection.Visible = False
        '    grpEnd.SuspendLayout()
        '    btnNext.Text = "&Export"
        '    DependencyCheck() : System.Windows.Forms.Application.DoEvents()
        '    grpEnd.Visible = True
        '    grpEnd.ResumeLayout()
        '    Exit Sub
        'End If


        'If btnNext.Text = "&Export" And grpEnd.Visible = True Then

        'If btnNext.Text = LangText.GetString("Export_ButtonExport") And grpEnd.Visible = True Then 
        If btnNext.Tag = "EXPORT" And grpEnd.Visible = True Then 
            Export()
        End If
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        If grpEnd.Visible = True Then
            grpEnd.Visible = False
            'btnNext.Text = "&Next"
            
            btnNext.Text = LangText.GetString("Export_ButtonNext")
            btnNext.Tag = "NEXT" 

            'If chkColourSchemes.Checked = True Then
            '    grpColourSchemeSelection.Visible = True
            '    Exit Sub
            'End If
            If chkTemplates.Checked = True Then
                grpTemplateSelection.Visible = True
                Exit Sub
            End If
            If chkTopics.Checked = True Then
                grpTopicSelection.Visible = True
                Exit Sub
            End If
            grpMain.Visible = True
        End If

        'If grpColourSchemeSelection.Visible = True Then
        '    grpColourSchemeSelection.Visible = False
        '    If chkTemplates.Checked = True Then
        '        grpTemplateSelection.Visible = True
        '        Exit Sub
        '    End If
        '    If chkTopics.Checked = True Then
        '        grpTopicSelection.Visible = True
        '        Exit Sub
        '    End If
        '    grpMain.Visible = True
        'End If

        If grpTemplateSelection.Visible = True Then
            grpTemplateSelection.Visible = False
            If chkTopics.Checked = True Then
                grpTopicSelection.Visible = True
                Exit Sub
            End If
            grpMain.Visible = True
        End If

        If grpTopicSelection.Visible = True Then
            grpTopicSelection.Visible = False
            grpMain.Visible = True
        End If

        If grpMain.Visible = True Then
            btnPrevious.Enabled = False 
            'do nothing
        End If

    End Sub
    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        ClearChecks()
        Exit Sub
        If Not TreeView1.SelectedNode Is Nothing Then
            If lstrLastFullPath <> TreeView1.SelectedNode.FullPath Then
                ClearChecks()
            End If
            lstrLastFullPath = TreeView1.SelectedNode.FullPath

        End If
        TreeView1.SelectedNode = Nothing


        Exit Sub
        If Not TreeView1.SelectedNode Is Nothing Then
            If TreeView1.SelectedNode.Checked = True Then
                ClearChecks()
                'Console.WriteLine("nothing " & Microsoft.VisualBasic.Format(DateTime.Now(), "MMddhhmmssff"))
            Else
                'Console.WriteLine("un checked " & Microsoft.VisualBasic.Format(DateTime.Now(), "MMddhhmmssff"))
            End If
        Else

        End If


    End Sub
    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    '    Me.Close()
    'End Sub
    'Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click

    '    Bxsy(Me, True)
    '    'TreeView1.Nodes.Clear()

    '    If btnSelectAll.Text <> "C&lear All" Then
    '        PopulateTree(TreeView1, mstrIndexArray, True, gstrSortOrder)
    '        btnSelectAll.Text = "C&lear All"
    '    Else
    '        PopulateTree(TreeView1, mstrIndexArray, , gstrSortOrder)
    '        btnSelectAll.Text = "Select &All"
    '    End If
    '    Bxsy(Me, False)
    'End Sub
    Private Function SelectTopics() As Boolean

        SelectTopics = False
        'moved here to cater for next / previous click
        ReDim mstrTopics(mstrIndexArray.GetUpperBound(0))

        If rdoExportAll.Checked = True Then
            Dim lintArrInc2 As Integer
            '            ReDim mstrTopics(mstrIndexArray.GetUpperBound(0))
            For lintArrInc2 = 0 To mstrIndexArray.GetUpperBound(0)
                mstrTopics(lintArrInc2).Code = mstrIndexArray(lintArrInc2).strTopicCode
            Next
            mbooAllTopicsSelected = True
            Busy(Me, False)
            BusyButtons(False)
            'Me.Close()
            SelectTopics = True
            Exit Function
        End If

        'If ValidateNodeSelection() = False Then
        '    Exit Sub
        'End If

        Dim lintArrInc As Integer
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        cNodes = TreeView1.GetNodeCount(True)

        If cNodes = 0 Then
            Busy(Me, False)
            BusyButtons(False) 
            SelectTopics = False
            Exit Function
        End If

        ReDim ndxs(cNodes)
        GetNodes(TreeView1.Nodes(0), ndxs, curNode, True)
        'GetNodes(TreeView1.Nodes(0), ndxs, curNode, False)

        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            If n.Checked = True Then
                ReDim Preserve mstrTopics(lintArrInc)
                mstrTopics(lintArrInc).Code = n.Tag ' ReturnTrueTopicStr(n.Tag)
                lintArrInc += 1
                'Else
                '    mbooAllTopicsSelected = False
            End If
        Next
        Busy(Me, False)
        BusyButtons(False) 

        If lintArrInc = 0 And rdoExportAll.Checked = False Then
            If gbooAlwaysOnTop = True Then Me.Activate() 
            'mxessagebox.show("You haven't selected anything to export!", NameMe(""))
            MessageBox.Show(LangText.GetString("Export_MustSelSomething"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

            SelectTopics = False
            Exit Function
        End If
        'If lintArrInc > 1 Then
        '    MxessageBox.Show("You have selected more than one branch!", NameMe(""))
        '    Exit Sub
        'End If

        'Me.Close()
        SelectTopics = True
    End Function
    Private Sub rdoExportAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoExportAll.CheckedChanged
        TreeView1.Enabled = False
        grpTopicSelection_VisibleChanged(Nothing, Nothing)
    End Sub
    Private Sub rdoExportBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoExportBranch.CheckedChanged
        TreeView1.Enabled = True
        grpTopicSelection_VisibleChanged(Nothing, Nothing)
    End Sub
    Private Function ValidateNodeSelection() As Boolean
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ValidateNodeSelection = True

        cNodes = TreeView1.GetNodeCount(True)

        If cNodes = 0 Then
            Exit Function
        End If

        ReDim ndxs(cNodes)
        GetNodes(TreeView1.Nodes(0), ndxs, curNode, True)

        Dim lstrLastBranchSelection As String

        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            If n.Checked = True Then
                If lstrLastBranchSelection <> "" Then
                    Dim lintThisDividerCount As Integer = Occurences(n.FullPath, "~")
                    Dim lintLastDividerCount As Integer = Occurences(lstrLastBranchSelection, "~")

                    Dim lintSmallerTopic As Integer = n.FullPath.Length
                    If lintSmallerTopic > lstrLastBranchSelection.Length Then lintSmallerTopic = lstrLastBranchSelection.Length
                    If LeftGet(n.FullPath, lintSmallerTopic) <> LeftGet(lstrLastBranchSelection, lintSmallerTopic) Then
                        'different top topics
                        ValidateNodeSelection = False
                        'mxessagebox.show("You may only export branches and their direct child branches!", NameMe(""))
                        If gbooAlwaysOnTop = True Then Me.Activate() 
                        MessageBox.Show(LangText.GetString("Export_OnlyExportDirectChild"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                        Exit Function
                    End If

                    If n.FullPath.Length < lstrLastBranchSelection.Length Or _
                        LeftGet(n.FullPath, lstrLastBranchSelection.Length) <> lstrLastBranchSelection Or _
                        (lintThisDividerCount - 1) <> lintLastDividerCount Then
                        'skipped a parent
                        ValidateNodeSelection = False
                        If gbooAlwaysOnTop = True Then Me.Activate() 
                        'mxessagebox.show("You may only export branches and their direct child branches!", NameMe(""))
                        MessageBox.Show(LangText.GetString("Export_OnlyExportDirectChild"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                        Exit Function
                    End If
                End If
                lstrLastBranchSelection = n.FullPath ' & "~"
            End If
        Next
    End Function
    Private Sub ClearChecks()

        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1


        cNodes = TreeView1.GetNodeCount(True)

        If cNodes = 0 Then
            Exit Sub
        End If

        ReDim ndxs(cNodes)
        GetNodes(TreeView1.Nodes(0), ndxs, curNode, False)

        Dim lintArrInc As Integer
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            n.Checked = False
            lintArrInc += 1
        Next

        Dim x As String
        x = ""
    End Sub
    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        If e.Node.Nodes Is Nothing Then
            Return
        End If


        'lstrTag = Microsoft.VisualBasic.Format(DateTime.Now(), "MMddhhmmssff")
        TreeView1.SuspendLayout()
        Dim node As TreeNode
        For Each node In e.Node.Nodes
            node.Checked = e.Node.Checked
            'node.Tag = lstrTag
        Next node
        TreeView1.ResumeLayout()

        'TreeView1.SelectedNode = e.Node
        'ClearChecks(lstrTag)
        'TreeView1.SelectedNode = Nothing


    End Sub
    Private Sub LoadUserCSStreeview(ByRef pstrCSSArray() As String, ByRef pcboColourScheme As TreeView)
        Dim lintArrInc As Integer

        Dim lbooSomethingAdded As Boolean = False 

        Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")
        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo
        For Each pfile In files
            If RightGet(pfile.ToString, 4).ToUpper = ".CSS" Then
                'cboDTColourScheme.Items.Add(pfile.ToString)
                ReDim Preserve pstrCSSArray(pstrCSSArray.GetUpperBound(0) + 1)
                pstrCSSArray(pstrCSSArray.GetUpperBound(0)) = pfile.ToString
            End If
        Next pfile

        For lintArrInc = 0 To pstrCSSArray.GetUpperBound(0)
            If pstrCSSArray(lintArrInc) <> "" Then
                'pcboColourScheme.Items.Add(pstrCSSArray(lintArrInc))
                pcboColourScheme.Nodes.Add(pstrCSSArray(lintArrInc))
                lbooSomethingAdded = True
            End If
        Next lintArrInc

        chkColourSchemes.Enabled = lbooSomethingAdded 

    End Sub
    Private Sub LoadUserTemplatestreeview(ByRef plstListBox As TreeView)
        Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        Dim lbooSomethingAdded As Boolean = False 
        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo

        For Each pfile In files
            If RightGet(pfile.ToString, 5).ToUpper = ".HTML" Or RightGet(pfile.ToString, 4).ToUpper = ".HTM" Then
                'plstListBox.Items.Add(pfile.ToString)
                plstListBox.Nodes.Add(pfile.ToString)
                lbooSomethingAdded = True 
            End If
        Next pfile

        chkTemplates.Enabled = lbooSomethingAdded 

    End Sub
    Private Sub Export()

        With SaveFileDialog1
            .CheckPathExists = True
            .AddExtension = True
            .FileName = "Project"
            '.Filter = "Ideaspad Import/Export File|*.imp"
            .Filter = LangText.GetString("Export_FileFilter").Replace("[Program]", gProgName) 
            .RestoreDirectory = True 
            '.Title = "Please save your export file"
            .Title = LangText.GetString("Export_SaveTitle") 

            .DefaultExt = "imp"
        End With

        Dim ExportFile As String
        If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel And SaveFileDialog1.FileName <> "" Then

            ExportFile = SaveFileDialog1.FileName
            Try
                System.IO.File.Delete(ExportFile)
            Catch
            End Try
        Else
            If gbooAlwaysOnTop = True Then Me.Activate() 
            'mxessagebox.show("You must specify a filename for your export / import file.", NameMe(""))
            MessageBox.Show(LangText.GetString("Export_MustSpecifyFile"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

            Exit Sub
        End If

        AddDebugComment("Export.Export - Pos 1")   

        Busy(Me, True) 
        BusyButtons(True) 
        Dim lintArrInc As Integer
        'Dim lstrExportDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
        '        "\Export\"

        Dim lstrExportDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Temp-" & _
            Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

        Try
            Directory.CreateDirectory(lstrExportDir)
        Catch
        End Try

        lstrExportDir += "\" 

        ProgressBar1.Maximum = 6
        ProgressBar1.Value = 1
        System.Windows.Forms.Application.DoEvents()

        AddDebugComment("Export.Export - Pos 2")   

        Dim lstrExportFile As String = lstrExportDir & "Export.dat"

        ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 
        lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrExportFile 

        GetSetting("KK", "", InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID, lstrExportFile) 'added to create blank file
        Dim xDoc As New XmlDocument()
        xDoc.Load(lstrExportFile)

        AddDebugComment("Export.Export - Pos 3")   
        '----------- TOPIC SECTION -----------

        Dim mstrTopicDetails(0) As TopicDetail
        If chkTopics.Checked = True Then
            'appSettings
            BatchXMLItemWrite(xDoc, "appSettings", "ExportTopics", "True")
            ExportTopics(mstrTopics, mbooAllTopicsSelected)
            System.Windows.Forms.Application.DoEvents() 
            ExportTopicsDetails(lstrExportDir, mstrTopics, mbooAllTopicsSelected, mstrTopicDetails)

            BatchXMLItemWrite(xDoc, "appSettings", "ExportTopicsCount", mstrTopics.GetUpperBound(0))
            BatchXMLItemWrite(xDoc, "appSettings", "ExportTopicDetailsCount", mstrTopicDetails.GetUpperBound(0))
            '-- produce topic xml data --
            For lintArrInc = 0 To mstrTopics.GetUpperBound(0)
                With mstrTopics(lintArrInc)
                    BatchXMLItemWrite(xDoc, "Topics", "Code-" & lintArrInc, .Code)
                    BatchXMLItemWrite(xDoc, "Topics", "Title-" & lintArrInc, .Title)
                    BatchXMLItemWrite(xDoc, "Topics", "Parent-" & lintArrInc, .Parent)
                    BatchXMLItemWrite(xDoc, "Topics", "Level-" & lintArrInc, .Level)
                    BatchXMLItemWrite(xDoc, "Topics", "ImgIdx-" & lintArrInc, .ImgIdx)
                    BatchXMLItemWrite(xDoc, "Topics", "Sequence-" & lintArrInc, .Sequence)
                End With
            Next lintArrInc
            '-- produce topic xml data --
            '-- produce topic detail xml data --
            For lintArrInc = 0 To mstrTopicDetails.GetUpperBound(0)
                With mstrTopicDetails(lintArrInc)
                    BatchXMLItemWrite(xDoc, "TopicDetails", "Code-" & lintArrInc, .Code)
                    BatchXMLItemWrite(xDoc, "TopicDetails", "OldCode-" & lintArrInc, .OldCode)
                    BatchXMLItemWrite(xDoc, "TopicDetails", "TemplateID-" & lintArrInc, .TemplateID)
                    BatchXMLItemWrite(xDoc, "TopicDetails", "Options-" & lintArrInc, .Options) 
                End With
            Next lintArrInc
            '-- produce topic detail xml data --
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportTopics", "False")
        End If
        ProgressBar1.Value = 2
        System.Windows.Forms.Application.DoEvents()
        '----------- TOPIC SECTION -----------

        AddDebugComment("Export.Export - Pos 4")   

        '----------- TEMPLATE & CSS FILE SECTION -----------
        If chkTemplates.Checked = True Then
            Dim lstrSelectedTmpFiles() As String
            If CopySelectedFileTreeview(tvUserTemplateSelection, lstrExportDir, lstrSelectedTmpFiles) = True Then
                BatchXMLItemWrite(xDoc, "appSettings", "ExportTemplate", "True")
            Else
                BatchXMLItemWrite(xDoc, "appSettings", "ExportTemplate", "False")
            End If
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportTemplate", "False")
        End If

        If chkColourSchemes.Checked = True Then
            Dim crap() As String
            If CopySelectedFileTreeview(tvCSSFiles, lstrExportDir, crap) = True Then
                BatchXMLItemWrite(xDoc, "appSettings", "ExportCSS", "True")
            Else
                BatchXMLItemWrite(xDoc, "appSettings", "ExportCSS", "False")
            End If
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportCSS", "False")
        End If

        ProgressBar1.Value = 3
        System.Windows.Forms.Application.DoEvents()
        '----------- TEMPLATE & CSS FILE SECTION -----------

        AddDebugComment("Export.Export - Pos 5")   

        '----------- BOOKMARKS SECTION -----------
        If chkBookmarks.Checked = True Then
            'msg if don't copy data with these topic then don't copy bookmarks
            'must exist!
            Dim lbooFoundBookMark As Boolean = False
            Dim InitialBookmarks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID)
            Dim llngAddedCtr As Long 
            With InitialBookmarks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 

                For lintArrInc = 0 To llngItemCount '19
                    Dim lstrBookmarkName As String = .GetValue("BookmarkName-" & lintArrInc, "")
                    Dim lstrBookmarks As String = .GetValue("Bookmarks-" & lintArrInc, "")
                    Dim lstrBookmarkImgIdx As String = .GetValue("BookmarkImgIdx-" & lintArrInc, "") 
                    If lstrBookmarkName <> "" Or lstrBookmarks <> "" Then
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "Bookmarks-" & llngAddedCtr, lstrBookmarks)
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkName-" & llngAddedCtr, lstrBookmarkName)
                        'BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkNameImgIdx-" & llngAddedCtr, lstrBookmarkImgIdx) 
                        
                        BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "BookmarkImgIdx-" & llngAddedCtr, lstrBookmarkImgIdx) 
                        llngAddedCtr += 1 
                        lbooFoundBookMark = True
                    End If
                Next lintArrInc
            End With
            If lbooFoundBookMark = True Then
                BatchXMLItemWrite(xDoc, "appSettings", "ExportBookmarks", "True")
                BatchXMLItemWrite(xDoc, "Bookmarks-" & lstrDBID, "ItemCount", llngAddedCtr)  
            Else
                BatchXMLItemWrite(xDoc, "appSettings", "ExportBookmarks", "False")
            End If
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportBookmarks", "False")
        End If

        If chkTemplateBookmarks.Checked = True Then
            'msg if don't copy templates with these bookmarks then don't copy bookmarks
            'must exist!
            Dim lbooFoundTempBookMark As Boolean = False
            Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)
            Dim llngAddedCtr As Long 
            With InitialConfig
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                For lintArrInc = 0 To llngItemCount 'lintMaxTemplates
                    Dim lstrTemplateName As String = .GetValue("Name" & lintArrInc, "")
                    Dim lstrTemplateFileName As String = .GetValue("FileName" & lintArrInc, "")
                    Dim lstrTemplateID As String = .GetValue("ID" & lintArrInc, "")
                    Dim lstrTemplateImgIdx As String = .GetValue("ImgIdx" & lintArrInc, "") 

                    If lstrTemplateName <> "" Or lstrTemplateFileName <> "" Then
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "Name" & llngAddedCtr, lstrTemplateName)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "FileName" & llngAddedCtr, lstrTemplateFileName)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ID" & llngAddedCtr, lstrTemplateID)
                        BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ImgIdx" & llngAddedCtr, lstrTemplateImgIdx) 
                        llngAddedCtr += 1 
                        lbooFoundTempBookMark = True
                    End If
                Next lintArrInc
            End With
            If lbooFoundTempBookMark = True Then
                BatchXMLItemWrite(xDoc, "appSettings", "ExportTempBookmarks", "True")
                BatchXMLItemWrite(xDoc, "TemplatesMenu-" & lstrDBID, "ItemCount", llngAddedCtr)  
            Else
                BatchXMLItemWrite(xDoc, "appSettings", "ExportTempBookmarks", "False")
            End If
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportTempBookmarks", "False")
        End If

        BatchXMLItemWrite(xDoc, "appSettings", "ExportDBID", lstrDBID)

        ProgressBar1.Value = 4
        System.Windows.Forms.Application.DoEvents()
        '----------- BOOKMARKS SECTION -----------

        AddDebugComment("Export.Export - Pos 6")   

        '----------- GENERAL SETTINGS SECTION -----------
        If chkGeneralSettings.Checked = True Then
            BatchXMLItemWrite(xDoc, "appSettings", "ExportGeneralSettings", "True")
            Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
            With InitialConfig

                Dim lstrItems() As String = {"Document Font Name", "Document Font Size", "Document Font Colour", "Document Font Bold", _
                    "Document Font Underlined", "Document Font Italic", "Document Font Strikeout", "Tree Font Name", "Tree Font Size", _
                    "Tree Font Colour", "Tree Font Bold", "Tree Font Underlined", "Tree Font Italic", "Tree Font Strikeout", _
                    "Tree Sort Order", "Show Startup Page", "Use Template By Default", "Default Template Name", "Default Template File Name", _
                    "Default Template ID", "Template Scheme", "Startup Topic", "Browser Font Size", "Tree Width", "RTF Highlight Colour", _
                    "Show Font Toolbar", "Move Branch IncrDecr"}

                For lintArrInc = 0 To lstrItems.GetUpperBound(0)
                    BatchXMLItemWrite(xDoc, "appSettings", lstrItems(lintArrInc), .GetValue(lstrItems(lintArrInc), ""))
                Next lintArrInc
            End With
        Else
            BatchXMLItemWrite(xDoc, "appSettings", "ExportGeneralSettings", "False")
        End If

        BatchXMLItemWrite(xDoc, "appSettings", "ExportVersion", "1.0.2") 

        ProgressBar1.Value = 5
        System.Windows.Forms.Application.DoEvents()
        '----------- GENERAL SETTINGS SECTION -----------

        AddDebugComment("Export.Export - Pos 7")   

        xDoc.Save(lstrExportFile)
        xDoc = Nothing

        CreateExportDistribFile(lstrExportDir, ExportFile)

        ProgressBar1.Value = 6
        System.Windows.Forms.Application.DoEvents()


        ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 'do here, so will be done after file delete 
        lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrExportDir 

        Busy(Me, False) 
        BusyButtons(False) 

        If gbooAlwaysOnTop = True Then Me.Activate() 
        'mxessagebox.show("The export process is complete!", NameMe(""))
        MessageBox.Show(LangText.GetString("Export_ProcessComplete"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 

        Me.Close()
        AddDebugComment("Export.Export - Pos 9")   

    End Sub
    'Private Sub CopyGeneralSettings(ByVal pstrExportfile As String)
    '    Dim lintArrInc As Integer
    '    Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
    '    With InitialConfig

    '        Dim lstrItems() As String = {"Document Font Name", "Document Font Size", "Document Font Colour", "Document Font Bold", _
    '            "Document Font Underlined", "Document Font Italic", "Document Font Strikeout", "Tree Font Name", "Tree Font Size", _
    '            "Tree Font Colour", "Tree Font Bold", "Tree Font Underlined", "Tree Font Italic", "Tree Font Strikeout", _
    '            "Tree Sort Order", "Show Startup Page", "Use Template By Default", "Default Template Name", "Default Template File Name", _
    '            "Default Template ID", "Template Scheme"}
    '        xx()
    '        For lintArrInc = 0 To lstrItems.GetUpperBound(0)
    '            SaveSetting(lstrItems(lintArrInc), .GetValue(lstrItems(lintArrInc), ""), InitalXMLConfig.XmlConfigType.AppSettings, _
    '                "", pstrExportfile)
    '        Next lintArrInc
    '    End With

    'End Sub
    Private Function CopySelectedFileTreeview(ByVal ptv As TreeView, ByVal pstrDestDir As String, ByRef pstrFiles() As String) As Boolean
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ReDim pstrFiles(0)

        CopySelectedFileTreeview = False
        Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        cNodes = ptv.GetNodeCount(False) 'don't need to check sub trees

        If cNodes = 0 Then
            Busy(Me, False)
            BusyButtons(False) 
            Exit Function
        End If

        ReDim ndxs(cNodes)
        GetNodes(ptv.Nodes(0), ndxs, curNode, True)

        Dim lintArrinc As Integer
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            If n.Checked = True Then
                CopySelectedFileTreeview = True
                File.Copy(source.ToString & n.Text, pstrDestDir & n.Text, True)

                ReDim Preserve pstrFiles(lintArrinc)
                pstrFiles(lintArrinc) = n.Text

            End If
        Next

    End Function
    Private Sub CreateExportDistribFile(ByVal BaseDir As String, ByVal DestFileName As String)
        Dim astrFileNames() As String = Directory.GetFiles(BaseDir)
        Dim objCrc32 As New ICSharpCode.SharpZipLib.Checksums.Crc32() ' added ICSharpCode.SharpZipLib.Checksums 
        Dim strmZipOutputStream As ZipOutputStream

        strmZipOutputStream = New ZipOutputStream(File.Create(DestFileName))
        strmZipOutputStream.SetLevel(6)

        Dim strFile As String

        For Each strFile In astrFileNames
            Dim strmFile As FileStream = File.OpenRead(strFile)
            Dim abyBuffer(strmFile.Length - 1) As Byte

            strmFile.Read(abyBuffer, 0, abyBuffer.Length)

            Dim ThisstrFile As String = Path.GetFileName(strFile)
            Dim objZipEntry As ZipEntry = New ZipEntry(ThisstrFile)

            objZipEntry.DateTime = DateTime.Now
            objZipEntry.Size = strmFile.Length
            strmFile.Close()
            objCrc32.Reset()
            objCrc32.Update(abyBuffer)
            objZipEntry.Crc = objCrc32.Value
            strmZipOutputStream.PutNextEntry(objZipEntry)
            strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)

        Next strFile
        strmZipOutputStream.Finish()
        strmZipOutputStream.Close()

    End Sub
    Private Function DependencyCheck() As Boolean
        Dim lintArrInc, lintArrInc2 As Integer

        'lstWarnings.SuspendLayout()
        lstWarnings.Items.Clear()
        Dim DependancyStatus As New StatusDialog(Me)
        DependancyStatus.TopMostIn = gbooAlwaysOnTop 

           DependancyStatus.Show()
        'DependancyStatus.Status = "Performing dependency check...."
        DependancyStatus.Status = LangText.GetString("Export_PerformDependancyCheck") 

        'Array of templates in export, including system ones

        Dim TR As New IPTemplates._main
        Dim lstrExportedTemplates() As IPTemplates._main.resources
        TR.HTMLForms(lstrExportedTemplates)

        ''==== TESTING 
        'Dim ArrMsg As String = "B4" & CR()
        'Dim x As Integer
        'For x = 0 To lstrExportedTemplates.GetUpperBound(0)
        '    ArrMsg &= lstrExportedTemplates(x).ID & CR()
        'Next x
        'ArrMsg &= CR() & "AF" & CR()
        ''==== TESTING 

        If chkTemplates.Checked = True Then 
            GetArrayOfExportedTemplatedIDs(tvUserTemplateSelection, lstrExportedTemplates)
        End If

        ''==== TESTING 
        'For x = 0 To lstrExportedTemplates.GetUpperBound(0)
        '    ArrMsg &= lstrExportedTemplates(x).ID & CR()
        'Next x
        'MessageBox.Show(ArrMsg)
        ''==== TESTING 

        If chkTopics.Checked = True Then 
            'Dim lstrTitlesNTempIDs() As DetailNames
            ''mstrTopics will have codes only at this point
            'GetTitleNTempIDs(mstrTopics, lstrTitlesNTempIDs)

            'If Not lstrTitlesNTempIDs Is Nothing Then ' no templates used in DB
            '    DependancyStatus.Status = "Checking topics...."
            '    'TemplateID tblTopicDetail - check used templates in tblTopicDetail has export template files
            '    For lintArrInc2 = 0 To lstrExportedTemplates.GetUpperBound(0)
            '        Dim lstrExportedTemplateID As String = lstrExportedTemplates(lintArrInc2).ID
            '        For lintArrInc = 0 To lstrTitlesNTempIDs.GetUpperBound(0)
            '            With lstrTitlesNTempIDs(lintArrInc)
            '                If lstrExportedTemplateID <> .TemplateID Then
            '                    AddWarningMsg("Topic: '" & .Title & "' requires a missing user template file")
            '                End If
            '            End With
            '        Next lintArrInc
            '    Next lintArrInc2
            'End If

            Dim lstrTitlesNTempIDs() As DetailNames 'when populated holds all selected templates in database
            'mstrTopics will have codes only at this point
            GetTitleNTempIDs(mstrTopics, lstrTitlesNTempIDs)

            If Not lstrTitlesNTempIDs Is Nothing Then ' no templates used in DB
                'DependancyStatus.Status = "Checking topics...."
                DependancyStatus.Status = LangText.GetString("Export_CheckingTopics") 
                ''Dim TestVar As String  
                'TemplateID tblTopicDetail - check used templates in tblTopicDetail has export template files
                For lintArrInc = 0 To lstrTitlesNTempIDs.GetUpperBound(0)
                    Dim lbooTemplateInUse As Boolean = False
                    With lstrTitlesNTempIDs(lintArrInc)

                        For lintArrInc2 = 0 To lstrExportedTemplates.GetUpperBound(0)
                            ''TestVar &= lintArrInc & " " & lstrExportedTemplates(lintArrInc2).ID & "-" & lstrTitlesNTempIDs(lintArrInc).TemplateID & " " & lbooTemplateInUse & CR() 
                            Dim lstrExportedTemplateID As String = lstrExportedTemplates(lintArrInc2).ID
                            
                            Try
                                lstrExportedTemplateID = lstrExportedTemplateID.ToUpper
                            Catch
                                '
                            End Try
                            Dim ThisTemp As String = lstrTitlesNTempIDs(lintArrInc).TemplateID
                            Try
                                ThisTemp = ThisTemp.ToUpper
                            Catch
                                '
                            End Try
                            
                            'If lstrExportedTemplateID = lstrTitlesNTempIDs(lintArrInc).TemplateID Then
                            If lstrExportedTemplateID = ThisTemp Then 
                                'AddWarningMsg("Topic: '" & .Title & "' requires a missing user template file")
                                lbooTemplateInUse = True
                                Exit For
                                'Else
                                'for testing purposes
                                'Console.WriteLine(lstrExportedTemplateID & " " & lstrTitlesNTempIDs(lintArrInc).TemplateID)
                            End If
                        Next lintArrInc2
                        If lbooTemplateInUse = False Then

                            'AddWarningMsg("Topic: '" & .Title & "' requires a missing user template file")
                            AddWarningMsg(LangText.GetString("Export_WarningTopic").Replace("[Title]", .Title)) 

                        End If
                    End With
                Next lintArrInc
                ''MessageBox.Show("Avail files & exporting - Topic template usage" & CR() & TestVar, " Testing Debug - Missing ")

            End If


        End If

        If chkBookmarks.Checked = True Then
            'DependancyStatus.Status = "Checking bookmarks...."
            DependancyStatus.Status = LangText.GetString("Export_CheckingBookmarks") 

            Dim BookmarksMenu As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.Bookmarks, lstrDBID)

            Dim lstrBookmarkName As String
            Dim lstrBookMarkNotInUseName As String
            'TOPICCODE tblTopics - check bookmarks for topics which don't exist
            With BookmarksMenu
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                For lintArrInc = 0 To llngItemCount '19
                    Dim lbooBookMarkInUseOnMenu As Boolean = False
                    lstrBookmarkName = .GetValue("BookmarkName-" & lintArrInc, "")
                    Dim lstrBookmarks As String = .GetValue("Bookmarks-" & lintArrInc, "")
                    If Not mstrTopics Is Nothing Then 
                        For lintArrInc2 = 0 To mstrTopics.GetUpperBound(0)
                            'mstrTopics will have codes only at this point
                            Dim lstrExportedTopicCode As String = mstrTopics(lintArrInc2).Code

                            If lstrBookmarks = lstrExportedTopicCode And lstrBookmarkName <> "" Then
                                lbooBookMarkInUseOnMenu = True
                                Exit For
                            End If
                        Next lintArrInc2 'mstrTopics
                    End If 
                    If lbooBookMarkInUseOnMenu = False And lstrBookmarkName <> "" Then
                        'AddWarningMsg("Bookmark: '" & lstrBookmarkName & "' refers to a missing topic")
                        AddWarningMsg(LangText.GetString("Export_WarningMisingBook").Replace("[Bookmark]", lstrBookmarkName)) 

                    End If
                Next lintArrInc
            End With
        End If

        If chkTemplateBookmarks.Checked = True Then
            'DependancyStatus.Status = "Checking template bookmarks...."
            DependancyStatus.Status = LangText.GetString("Export_CheckingTemplates") 

            Dim TempBooks As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.TemplatesMenu, lstrDBID)

            Dim lstrTemplateName As String
            'TEMPLATEID - check template bookmarks for templates files which don't exist in export file
            With TempBooks
                Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 
                'Const lintMaxTemplates As Integer = 10
                For lintArrInc = 0 To llngItemCount
                    Dim lbooInUseOnMenu As Boolean = False
                    lstrTemplateName = .GetValue("Name" & lintArrInc, "")
                    Dim lstrTemplateID As String = .GetValue("ID" & lintArrInc, "")
                    For lintArrInc2 = 0 To lstrExportedTemplates.GetUpperBound(0)
                        Dim lstrExportedTemplateID As String = lstrExportedTemplates(lintArrInc2).ID
                        If lstrTemplateID = lstrExportedTemplateID And lstrExportedTemplateID <> "" Then
                            lbooInUseOnMenu = True
                            Exit For
                        End If
                    Next lintArrInc2
                    If lbooInUseOnMenu = False And lstrTemplateName <> "" Then
                        'AddWarningMsg("Template menu item: '" & lstrTemplateName & "' is linked to a missing template file")
                        AddWarningMsg(LangText.GetString("Export_WarningMissingTemplFile").Replace("[TemplateName]", lstrTemplateName)) 

                    End If
                Next lintArrInc
            End With
        End If

        DependancyStatus.Close()
        'lstWarnings.ResumeLayout()
        'System.Windows.Forms.Application.DoEvents()

        If lstWarnings.Items.Count = 0 Then
            lstWarnings.Visible = False
            lblWarning.Visible = False
            lblCongrats.Visible = True
        Else
            lstWarnings.Visible = True
            lblWarning.Visible = True
            lblCongrats.Visible = False
        End If

    End Function
    Private Sub AddWarningMsg(ByVal pstrMsg As String)
        Dim lintArrInc As Integer
        Dim lbooAlreadyAdded As Boolean = False

        If lstWarnings.Items.Count <> -1 Then
            For lintArrInc = 0 To lstWarnings.Items.Count - 1
                If lstWarnings.Items(lintArrInc) = pstrMsg Then
                    lbooAlreadyAdded = True
                End If
            Next lintArrInc
        End If

        If lbooAlreadyAdded = False Then
            lstWarnings.Items.Add(pstrMsg)
        End If
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)



    End Sub
    Private Sub grpMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grpMain.Paint
        'commednted out 
        'Spanner(e, 15, 15) '40

    End Sub
    Private Sub Export_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        'Me.Top = (CallingForm.Height / 2) - (Me.Height / 2) + CallingForm.Top
        'Me.Left = (CallingForm.Width / 2) - (Me.Width / 2) + CallingForm.Left

    End Sub
    Private Sub grpTemplateSelection_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpTemplateSelection.VisibleChanged

        If tvUserTemplateSelection.Enabled = True Then
            tvUserTemplateSelection.BackColor = SystemColors.Window
        Else
            tvUserTemplateSelection.BackColor = SystemColors.InactiveBorder
        End If

        If tvCSSFiles.Enabled = True Then
            tvCSSFiles.BackColor = SystemColors.Window
        Else
            tvCSSFiles.BackColor = SystemColors.InactiveBorder
        End If

    End Sub
    Private Sub grpTopicSelection_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpTopicSelection.VisibleChanged

        If TreeView1.Enabled = True Then
            TreeView1.BackColor = SystemColors.Window
        Else
            TreeView1.BackColor = SystemColors.InactiveBorder
        End If

    End Sub
    Private Sub Export_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.exportwizard)) 
    End Sub
    Private Sub Export_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
    Private Sub lblCanvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblCanvas.Paint
        
        UIStyle.Spanner(e, 0, 0) '15, 15)
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnNext.BackColor = Color.FromArgb(0, btnNext.BackColor)
        btnPrevious.BackColor = Color.FromArgb(0, btnPrevious.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        chkTopics.BackColor = Color.FromArgb(0, chkTopics.BackColor)
        chkTemplates.BackColor = Color.FromArgb(0, chkTemplates.BackColor)
        chkBookmarks.BackColor = Color.FromArgb(0, chkBookmarks.BackColor)
        chkGeneralSettings.BackColor = Color.FromArgb(0, chkGeneralSettings.BackColor)
        chkColourSchemes.BackColor = Color.FromArgb(0, chkColourSchemes.BackColor)
        chkTemplateBookmarks.BackColor = Color.FromArgb(0, chkTemplateBookmarks.BackColor)
        grpMain.BackColor = Color.FromArgb(0, grpMain.BackColor)
        grpTemplateSelection.BackColor = Color.FromArgb(0, grpTemplateSelection.BackColor)
        grpTopicSelection.BackColor = Color.FromArgb(0, grpTopicSelection.BackColor)
        grpEnd.BackColor = Color.FromArgb(0, grpEnd.BackColor)
        rdoExportBranch.BackColor = Color.FromArgb(0, rdoExportBranch.BackColor)
        rdoExportAll.BackColor = Color.FromArgb(0, rdoExportAll.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        lblWarning.BackColor = Color.FromArgb(0, lblWarning.BackColor)
        lblCongrats.BackColor = Color.FromArgb(0, lblCongrats.BackColor)
        'lblCanvas.BackColor = Color.FromArgb(0, lblCanvas.BackColor) ' error ??

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        'Added 
        If IsAboveOrEqualWinXp() = True Then
            'rdoExportBranch.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoExportBranch.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoExportBranch.Top, rdoExportBranch.Left, rdoExportBranch.Width, rdoExportBranch.Height)
            'rdoExportAll.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoExportAll.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoExportAll.Top, rdoExportAll.Left, rdoExportAll.Width, rdoExportAll.Height)
        Else
            
            chkTopics.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTopics.Top, chkTopics.Left, chkTopics.Width, chkTopics.Height)
            chkTemplates.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTemplates.Top, chkTemplates.Left, chkTemplates.Width, chkTemplates.Height)
            chkBookmarks.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkBookmarks.Top, chkBookmarks.Left, chkBookmarks.Width, chkBookmarks.Height)
            chkGeneralSettings.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkGeneralSettings.Top, chkGeneralSettings.Left, chkGeneralSettings.Width, chkGeneralSettings.Height)
            chkColourSchemes.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkColourSchemes.Top, chkColourSchemes.Left, chkColourSchemes.Width, chkColourSchemes.Height)
            chkTemplateBookmarks.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkTemplateBookmarks.Top, chkTemplateBookmarks.Left, chkTemplateBookmarks.Width, chkTemplateBookmarks.Height)
            
        End If

    End Sub
    Private Sub Export_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class