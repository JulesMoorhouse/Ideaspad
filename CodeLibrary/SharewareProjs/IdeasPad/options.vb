Imports System.IO
Friend Class options
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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As AppBasic.TabPagePaintEv
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDocFontColour As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDocFontName As System.Windows.Forms.Label
    Friend WithEvents btnDocChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTreeChange As System.Windows.Forms.Button
    Friend WithEvents lblTreeFontName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTreeFontColour As System.Windows.Forms.Label
    Friend WithEvents lblTreeFontSize As System.Windows.Forms.Label
    Friend WithEvents lblDocSample As System.Windows.Forms.Label
    Friend WithEvents lblTreeSample As System.Windows.Forms.Label
    Friend WithEvents lblDocFontSize As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As AppBasic.TabPagePaintEv
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdoSortAlpha As System.Windows.Forms.RadioButton
    Friend WithEvents rdSortSeqNum As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage3 As AppBasic.TabPagePaintEv
    Friend WithEvents btnAddQuickLaunch As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As AppBasic.TabPagePaintEv
    Friend WithEvents cboCurrentDictionary As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpNoDictionaryFound As System.Windows.Forms.GroupBox
    Friend WithEvents lnkURL As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage5 As AppBasic.TabPagePaintEv
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As AppBasic.TabPagePaintEv
    Friend WithEvents TabPage7 As AppBasic.TabPagePaintEv
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdoTempOrNormNorm As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTempOrNormTemp As System.Windows.Forms.RadioButton
    Friend WithEvents cboDTColourScheme As System.Windows.Forms.ComboBox
    Friend WithEvents lblDTTemplate As System.Windows.Forms.Label
    Friend WithEvents btnDTSelect As System.Windows.Forms.Button
    Friend WithEvents btnDTColourSchemeBrowse As System.Windows.Forms.Button
    Friend WithEvents btnDVSelect As System.Windows.Forms.Button
    Friend WithEvents lblDVTemplate As System.Windows.Forms.Label
    Friend WithEvents cboDVField As System.Windows.Forms.ComboBox
    Friend WithEvents cboDVValue As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tabTemplates As System.Windows.Forms.TabControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblDTTemplateID As System.Windows.Forms.Label
    Friend WithEvents lblDTTemplateFileName As System.Windows.Forms.Label
    Friend WithEvents btnDVSave As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents rdoStartupSelPage As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents rdoStartupSelTopic As System.Windows.Forms.RadioButton
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblIncrementAmount As System.Windows.Forms.Label
    Friend WithEvents txtIncrementAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(options))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New AppBasic.TabPagePaintEv()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTreeSample = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTreeChange = New System.Windows.Forms.Button()
        Me.lblTreeFontName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTreeFontColour = New System.Windows.Forms.Label()
        Me.lblTreeFontSize = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDocChange = New System.Windows.Forms.Button()
        Me.lblDocFontName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDocFontColour = New System.Windows.Forms.Label()
        Me.lblDocFontSize = New System.Windows.Forms.Label()
        Me.lblDocSample = New System.Windows.Forms.Label()
        Me.TabPage3 = New AppBasic.TabPagePaintEv()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.rdoStartupSelPage = New System.Windows.Forms.RadioButton()
        Me.rdoStartupSelTopic = New System.Windows.Forms.RadioButton()
        Me.btnAddQuickLaunch = New System.Windows.Forms.Button()
        Me.TabPage2 = New AppBasic.TabPagePaintEv()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIncrementAmount = New System.Windows.Forms.TextBox()
        Me.lblIncrementAmount = New System.Windows.Forms.Label()
        Me.rdSortSeqNum = New System.Windows.Forms.RadioButton()
        Me.rdoSortAlpha = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New AppBasic.TabPagePaintEv()
        Me.grpNoDictionaryFound = New System.Windows.Forms.GroupBox()
        Me.lnkURL = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCurrentDictionary = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New AppBasic.TabPagePaintEv()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdoTempOrNormTemp = New System.Windows.Forms.RadioButton()
        Me.rdoTempOrNormNorm = New System.Windows.Forms.RadioButton()
        Me.tabTemplates = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New AppBasic.TabPagePaintEv()
        Me.lblDTTemplateFileName = New System.Windows.Forms.Label()
        Me.lblDTTemplateID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnDTColourSchemeBrowse = New System.Windows.Forms.Button()
        Me.btnDTSelect = New System.Windows.Forms.Button()
        Me.lblDTTemplate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboDTColourScheme = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage7 = New AppBasic.TabPagePaintEv()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnDVSave = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboDVValue = New System.Windows.Forms.ComboBox()
        Me.cboDVField = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnDVSelect = New System.Windows.Forms.Button()
        Me.lblDVTemplate = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpNoDictionaryFound.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.tabTemplates.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
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
        'btnApply
        '
        Me.btnApply.AccessibleDescription = CType(resources.GetObject("btnApply.AccessibleDescription"), String)
        Me.btnApply.AccessibleName = CType(resources.GetObject("btnApply.AccessibleName"), String)
        Me.btnApply.Anchor = CType(resources.GetObject("btnApply.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnApply.BackgroundImage = CType(resources.GetObject("btnApply.BackgroundImage"), System.Drawing.Image)
        Me.btnApply.Dock = CType(resources.GetObject("btnApply.Dock"), System.Windows.Forms.DockStyle)
        Me.btnApply.Enabled = CType(resources.GetObject("btnApply.Enabled"), Boolean)
        Me.btnApply.FlatStyle = CType(resources.GetObject("btnApply.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnApply.Font = CType(resources.GetObject("btnApply.Font"), System.Drawing.Font)
        Me.btnApply.Image = CType(resources.GetObject("btnApply.Image"), System.Drawing.Image)
        Me.btnApply.ImageAlign = CType(resources.GetObject("btnApply.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnApply.ImageIndex = CType(resources.GetObject("btnApply.ImageIndex"), Integer)
        Me.btnApply.ImeMode = CType(resources.GetObject("btnApply.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnApply.Location = CType(resources.GetObject("btnApply.Location"), System.Drawing.Point)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.RightToLeft = CType(resources.GetObject("btnApply.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnApply.Size = CType(resources.GetObject("btnApply.Size"), System.Drawing.Size)
        Me.btnApply.TabIndex = CType(resources.GetObject("btnApply.TabIndex"), Integer)
        Me.btnApply.Text = resources.GetString("btnApply.Text")
        Me.btnApply.TextAlign = CType(resources.GetObject("btnApply.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnApply.Visible = CType(resources.GetObject("btnApply.Visible"), Boolean)
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleDescription = CType(resources.GetObject("TabControl1.AccessibleDescription"), String)
        Me.TabControl1.AccessibleName = CType(resources.GetObject("TabControl1.AccessibleName"), String)
        Me.TabControl1.Alignment = CType(resources.GetObject("TabControl1.Alignment"), System.Windows.Forms.TabAlignment)
        Me.TabControl1.Anchor = CType(resources.GetObject("TabControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = CType(resources.GetObject("TabControl1.Appearance"), System.Windows.Forms.TabAppearance)
        Me.TabControl1.BackgroundImage = CType(resources.GetObject("TabControl1.BackgroundImage"), System.Drawing.Image)
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage3, Me.TabPage2, Me.TabPage4, Me.TabPage5})
        Me.TabControl1.Dock = CType(resources.GetObject("TabControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabControl1.Enabled = CType(resources.GetObject("TabControl1.Enabled"), Boolean)
        Me.TabControl1.Font = CType(resources.GetObject("TabControl1.Font"), System.Drawing.Font)
        Me.TabControl1.ImeMode = CType(resources.GetObject("TabControl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabControl1.ItemSize = CType(resources.GetObject("TabControl1.ItemSize"), System.Drawing.Size)
        Me.TabControl1.Location = CType(resources.GetObject("TabControl1.Location"), System.Drawing.Point)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = CType(resources.GetObject("TabControl1.Padding"), System.Drawing.Point)
        Me.TabControl1.RightToLeft = CType(resources.GetObject("TabControl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = CType(resources.GetObject("TabControl1.ShowToolTips"), Boolean)
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        Me.TabControl1.TabIndex = CType(resources.GetObject("TabControl1.TabIndex"), Integer)
        Me.TabControl1.Text = resources.GetString("TabControl1.Text")
        Me.TabControl1.Visible = CType(resources.GetObject("TabControl1.Visible"), Boolean)
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleDescription = CType(resources.GetObject("TabPage1.AccessibleDescription"), String)
        Me.TabPage1.AccessibleName = CType(resources.GetObject("TabPage1.AccessibleName"), String)
        Me.TabPage1.Anchor = CType(resources.GetObject("TabPage1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage1.AutoScroll = CType(resources.GetObject("TabPage1.AutoScroll"), Boolean)
        Me.TabPage1.AutoScrollMargin = CType(resources.GetObject("TabPage1.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage1.AutoScrollMinSize = CType(resources.GetObject("TabPage1.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnReset, Me.GroupBox3, Me.GroupBox1})
        Me.TabPage1.Dock = CType(resources.GetObject("TabPage1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage1.Enabled = CType(resources.GetObject("TabPage1.Enabled"), Boolean)
        Me.TabPage1.Font = CType(resources.GetObject("TabPage1.Font"), System.Drawing.Font)
        Me.TabPage1.ImageIndex = CType(resources.GetObject("TabPage1.ImageIndex"), Integer)
        Me.TabPage1.ImeMode = CType(resources.GetObject("TabPage1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage1.Location = CType(resources.GetObject("TabPage1.Location"), System.Drawing.Point)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.RightToLeft = CType(resources.GetObject("TabPage1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage1.Size = CType(resources.GetObject("TabPage1.Size"), System.Drawing.Size)
        Me.TabPage1.TabIndex = CType(resources.GetObject("TabPage1.TabIndex"), Integer)
        Me.TabPage1.Text = resources.GetString("TabPage1.Text")
        Me.TabPage1.ToolTipText = resources.GetString("TabPage1.ToolTipText")
        Me.TabPage1.Visible = CType(resources.GetObject("TabPage1.Visible"), Boolean)
        '
        'btnReset
        '
        Me.btnReset.AccessibleDescription = CType(resources.GetObject("btnReset.AccessibleDescription"), String)
        Me.btnReset.AccessibleName = CType(resources.GetObject("btnReset.AccessibleName"), String)
        Me.btnReset.Anchor = CType(resources.GetObject("btnReset.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.Dock = CType(resources.GetObject("btnReset.Dock"), System.Windows.Forms.DockStyle)
        Me.btnReset.Enabled = CType(resources.GetObject("btnReset.Enabled"), Boolean)
        Me.btnReset.FlatStyle = CType(resources.GetObject("btnReset.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnReset.Font = CType(resources.GetObject("btnReset.Font"), System.Drawing.Font)
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = CType(resources.GetObject("btnReset.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnReset.ImageIndex = CType(resources.GetObject("btnReset.ImageIndex"), Integer)
        Me.btnReset.ImeMode = CType(resources.GetObject("btnReset.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnReset.Location = CType(resources.GetObject("btnReset.Location"), System.Drawing.Point)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.RightToLeft = CType(resources.GetObject("btnReset.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnReset.Size = CType(resources.GetObject("btnReset.Size"), System.Drawing.Size)
        Me.btnReset.TabIndex = CType(resources.GetObject("btnReset.TabIndex"), Integer)
        Me.btnReset.Text = resources.GetString("btnReset.Text")
        Me.btnReset.TextAlign = CType(resources.GetObject("btnReset.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnReset.Visible = CType(resources.GetObject("btnReset.Visible"), Boolean)
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = CType(resources.GetObject("GroupBox3.AccessibleDescription"), String)
        Me.GroupBox3.AccessibleName = CType(resources.GetObject("GroupBox3.AccessibleName"), String)
        Me.GroupBox3.Anchor = CType(resources.GetObject("GroupBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTreeSample, Me.Label5, Me.btnTreeChange, Me.lblTreeFontName, Me.Label7, Me.Label8, Me.Label9, Me.lblTreeFontColour, Me.lblTreeFontSize})
        Me.GroupBox3.Dock = CType(resources.GetObject("GroupBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox3.Enabled = CType(resources.GetObject("GroupBox3.Enabled"), Boolean)
        Me.GroupBox3.Font = CType(resources.GetObject("GroupBox3.Font"), System.Drawing.Font)
        Me.GroupBox3.ImeMode = CType(resources.GetObject("GroupBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox3.Location = CType(resources.GetObject("GroupBox3.Location"), System.Drawing.Point)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = CType(resources.GetObject("GroupBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox3.Size = CType(resources.GetObject("GroupBox3.Size"), System.Drawing.Size)
        Me.GroupBox3.TabIndex = CType(resources.GetObject("GroupBox3.TabIndex"), Integer)
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = resources.GetString("GroupBox3.Text")
        Me.GroupBox3.Visible = CType(resources.GetObject("GroupBox3.Visible"), Boolean)
        '
        'lblTreeSample
        '
        Me.lblTreeSample.AccessibleDescription = CType(resources.GetObject("lblTreeSample.AccessibleDescription"), String)
        Me.lblTreeSample.AccessibleName = CType(resources.GetObject("lblTreeSample.AccessibleName"), String)
        Me.lblTreeSample.Anchor = CType(resources.GetObject("lblTreeSample.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTreeSample.AutoSize = CType(resources.GetObject("lblTreeSample.AutoSize"), Boolean)
        Me.lblTreeSample.BackColor = System.Drawing.SystemColors.Window
        Me.lblTreeSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTreeSample.Dock = CType(resources.GetObject("lblTreeSample.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTreeSample.Enabled = CType(resources.GetObject("lblTreeSample.Enabled"), Boolean)
        Me.lblTreeSample.Font = CType(resources.GetObject("lblTreeSample.Font"), System.Drawing.Font)
        Me.lblTreeSample.Image = CType(resources.GetObject("lblTreeSample.Image"), System.Drawing.Image)
        Me.lblTreeSample.ImageAlign = CType(resources.GetObject("lblTreeSample.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeSample.ImageIndex = CType(resources.GetObject("lblTreeSample.ImageIndex"), Integer)
        Me.lblTreeSample.ImeMode = CType(resources.GetObject("lblTreeSample.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTreeSample.Location = CType(resources.GetObject("lblTreeSample.Location"), System.Drawing.Point)
        Me.lblTreeSample.Name = "lblTreeSample"
        Me.lblTreeSample.RightToLeft = CType(resources.GetObject("lblTreeSample.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTreeSample.Size = CType(resources.GetObject("lblTreeSample.Size"), System.Drawing.Size)
        Me.lblTreeSample.TabIndex = CType(resources.GetObject("lblTreeSample.TabIndex"), Integer)
        Me.lblTreeSample.Text = resources.GetString("lblTreeSample.Text")
        Me.lblTreeSample.TextAlign = CType(resources.GetObject("lblTreeSample.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeSample.Visible = CType(resources.GetObject("lblTreeSample.Visible"), Boolean)
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
        'btnTreeChange
        '
        Me.btnTreeChange.AccessibleDescription = CType(resources.GetObject("btnTreeChange.AccessibleDescription"), String)
        Me.btnTreeChange.AccessibleName = CType(resources.GetObject("btnTreeChange.AccessibleName"), String)
        Me.btnTreeChange.Anchor = CType(resources.GetObject("btnTreeChange.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnTreeChange.BackgroundImage = CType(resources.GetObject("btnTreeChange.BackgroundImage"), System.Drawing.Image)
        Me.btnTreeChange.Dock = CType(resources.GetObject("btnTreeChange.Dock"), System.Windows.Forms.DockStyle)
        Me.btnTreeChange.Enabled = CType(resources.GetObject("btnTreeChange.Enabled"), Boolean)
        Me.btnTreeChange.FlatStyle = CType(resources.GetObject("btnTreeChange.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnTreeChange.Font = CType(resources.GetObject("btnTreeChange.Font"), System.Drawing.Font)
        Me.btnTreeChange.Image = CType(resources.GetObject("btnTreeChange.Image"), System.Drawing.Image)
        Me.btnTreeChange.ImageAlign = CType(resources.GetObject("btnTreeChange.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnTreeChange.ImageIndex = CType(resources.GetObject("btnTreeChange.ImageIndex"), Integer)
        Me.btnTreeChange.ImeMode = CType(resources.GetObject("btnTreeChange.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnTreeChange.Location = CType(resources.GetObject("btnTreeChange.Location"), System.Drawing.Point)
        Me.btnTreeChange.Name = "btnTreeChange"
        Me.btnTreeChange.RightToLeft = CType(resources.GetObject("btnTreeChange.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnTreeChange.Size = CType(resources.GetObject("btnTreeChange.Size"), System.Drawing.Size)
        Me.btnTreeChange.TabIndex = CType(resources.GetObject("btnTreeChange.TabIndex"), Integer)
        Me.btnTreeChange.Text = resources.GetString("btnTreeChange.Text")
        Me.btnTreeChange.TextAlign = CType(resources.GetObject("btnTreeChange.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnTreeChange.Visible = CType(resources.GetObject("btnTreeChange.Visible"), Boolean)
        '
        'lblTreeFontName
        '
        Me.lblTreeFontName.AccessibleDescription = CType(resources.GetObject("lblTreeFontName.AccessibleDescription"), String)
        Me.lblTreeFontName.AccessibleName = CType(resources.GetObject("lblTreeFontName.AccessibleName"), String)
        Me.lblTreeFontName.Anchor = CType(resources.GetObject("lblTreeFontName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTreeFontName.AutoSize = CType(resources.GetObject("lblTreeFontName.AutoSize"), Boolean)
        Me.lblTreeFontName.Dock = CType(resources.GetObject("lblTreeFontName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTreeFontName.Enabled = CType(resources.GetObject("lblTreeFontName.Enabled"), Boolean)
        Me.lblTreeFontName.Font = CType(resources.GetObject("lblTreeFontName.Font"), System.Drawing.Font)
        Me.lblTreeFontName.Image = CType(resources.GetObject("lblTreeFontName.Image"), System.Drawing.Image)
        Me.lblTreeFontName.ImageAlign = CType(resources.GetObject("lblTreeFontName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontName.ImageIndex = CType(resources.GetObject("lblTreeFontName.ImageIndex"), Integer)
        Me.lblTreeFontName.ImeMode = CType(resources.GetObject("lblTreeFontName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTreeFontName.Location = CType(resources.GetObject("lblTreeFontName.Location"), System.Drawing.Point)
        Me.lblTreeFontName.Name = "lblTreeFontName"
        Me.lblTreeFontName.RightToLeft = CType(resources.GetObject("lblTreeFontName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTreeFontName.Size = CType(resources.GetObject("lblTreeFontName.Size"), System.Drawing.Size)
        Me.lblTreeFontName.TabIndex = CType(resources.GetObject("lblTreeFontName.TabIndex"), Integer)
        Me.lblTreeFontName.Text = resources.GetString("lblTreeFontName.Text")
        Me.lblTreeFontName.TextAlign = CType(resources.GetObject("lblTreeFontName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontName.Visible = CType(resources.GetObject("lblTreeFontName.Visible"), Boolean)
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = CType(resources.GetObject("Label7.AccessibleDescription"), String)
        Me.Label7.AccessibleName = CType(resources.GetObject("Label7.AccessibleName"), String)
        Me.Label7.Anchor = CType(resources.GetObject("Label7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = CType(resources.GetObject("Label7.AutoSize"), Boolean)
        Me.Label7.Dock = CType(resources.GetObject("Label7.Dock"), System.Windows.Forms.DockStyle)
        Me.Label7.Enabled = CType(resources.GetObject("Label7.Enabled"), Boolean)
        Me.Label7.Font = CType(resources.GetObject("Label7.Font"), System.Drawing.Font)
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = CType(resources.GetObject("Label7.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label7.ImageIndex = CType(resources.GetObject("Label7.ImageIndex"), Integer)
        Me.Label7.ImeMode = CType(resources.GetObject("Label7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label7.Location = CType(resources.GetObject("Label7.Location"), System.Drawing.Point)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = CType(resources.GetObject("Label7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label7.Size = CType(resources.GetObject("Label7.Size"), System.Drawing.Size)
        Me.Label7.TabIndex = CType(resources.GetObject("Label7.TabIndex"), Integer)
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = CType(resources.GetObject("Label7.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label7.Visible = CType(resources.GetObject("Label7.Visible"), Boolean)
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = CType(resources.GetObject("Label8.AccessibleDescription"), String)
        Me.Label8.AccessibleName = CType(resources.GetObject("Label8.AccessibleName"), String)
        Me.Label8.Anchor = CType(resources.GetObject("Label8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = CType(resources.GetObject("Label8.AutoSize"), Boolean)
        Me.Label8.Dock = CType(resources.GetObject("Label8.Dock"), System.Windows.Forms.DockStyle)
        Me.Label8.Enabled = CType(resources.GetObject("Label8.Enabled"), Boolean)
        Me.Label8.Font = CType(resources.GetObject("Label8.Font"), System.Drawing.Font)
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = CType(resources.GetObject("Label8.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label8.ImageIndex = CType(resources.GetObject("Label8.ImageIndex"), Integer)
        Me.Label8.ImeMode = CType(resources.GetObject("Label8.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label8.Location = CType(resources.GetObject("Label8.Location"), System.Drawing.Point)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = CType(resources.GetObject("Label8.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label8.Size = CType(resources.GetObject("Label8.Size"), System.Drawing.Size)
        Me.Label8.TabIndex = CType(resources.GetObject("Label8.TabIndex"), Integer)
        Me.Label8.Text = resources.GetString("Label8.Text")
        Me.Label8.TextAlign = CType(resources.GetObject("Label8.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label8.Visible = CType(resources.GetObject("Label8.Visible"), Boolean)
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = CType(resources.GetObject("Label9.AccessibleDescription"), String)
        Me.Label9.AccessibleName = CType(resources.GetObject("Label9.AccessibleName"), String)
        Me.Label9.Anchor = CType(resources.GetObject("Label9.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = CType(resources.GetObject("Label9.AutoSize"), Boolean)
        Me.Label9.Dock = CType(resources.GetObject("Label9.Dock"), System.Windows.Forms.DockStyle)
        Me.Label9.Enabled = CType(resources.GetObject("Label9.Enabled"), Boolean)
        Me.Label9.Font = CType(resources.GetObject("Label9.Font"), System.Drawing.Font)
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = CType(resources.GetObject("Label9.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label9.ImageIndex = CType(resources.GetObject("Label9.ImageIndex"), Integer)
        Me.Label9.ImeMode = CType(resources.GetObject("Label9.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label9.Location = CType(resources.GetObject("Label9.Location"), System.Drawing.Point)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = CType(resources.GetObject("Label9.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label9.Size = CType(resources.GetObject("Label9.Size"), System.Drawing.Size)
        Me.Label9.TabIndex = CType(resources.GetObject("Label9.TabIndex"), Integer)
        Me.Label9.Text = resources.GetString("Label9.Text")
        Me.Label9.TextAlign = CType(resources.GetObject("Label9.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label9.Visible = CType(resources.GetObject("Label9.Visible"), Boolean)
        '
        'lblTreeFontColour
        '
        Me.lblTreeFontColour.AccessibleDescription = CType(resources.GetObject("lblTreeFontColour.AccessibleDescription"), String)
        Me.lblTreeFontColour.AccessibleName = CType(resources.GetObject("lblTreeFontColour.AccessibleName"), String)
        Me.lblTreeFontColour.Anchor = CType(resources.GetObject("lblTreeFontColour.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTreeFontColour.AutoSize = CType(resources.GetObject("lblTreeFontColour.AutoSize"), Boolean)
        Me.lblTreeFontColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTreeFontColour.Dock = CType(resources.GetObject("lblTreeFontColour.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTreeFontColour.Enabled = CType(resources.GetObject("lblTreeFontColour.Enabled"), Boolean)
        Me.lblTreeFontColour.Font = CType(resources.GetObject("lblTreeFontColour.Font"), System.Drawing.Font)
        Me.lblTreeFontColour.Image = CType(resources.GetObject("lblTreeFontColour.Image"), System.Drawing.Image)
        Me.lblTreeFontColour.ImageAlign = CType(resources.GetObject("lblTreeFontColour.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontColour.ImageIndex = CType(resources.GetObject("lblTreeFontColour.ImageIndex"), Integer)
        Me.lblTreeFontColour.ImeMode = CType(resources.GetObject("lblTreeFontColour.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTreeFontColour.Location = CType(resources.GetObject("lblTreeFontColour.Location"), System.Drawing.Point)
        Me.lblTreeFontColour.Name = "lblTreeFontColour"
        Me.lblTreeFontColour.RightToLeft = CType(resources.GetObject("lblTreeFontColour.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTreeFontColour.Size = CType(resources.GetObject("lblTreeFontColour.Size"), System.Drawing.Size)
        Me.lblTreeFontColour.TabIndex = CType(resources.GetObject("lblTreeFontColour.TabIndex"), Integer)
        Me.lblTreeFontColour.Text = resources.GetString("lblTreeFontColour.Text")
        Me.lblTreeFontColour.TextAlign = CType(resources.GetObject("lblTreeFontColour.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontColour.Visible = CType(resources.GetObject("lblTreeFontColour.Visible"), Boolean)
        '
        'lblTreeFontSize
        '
        Me.lblTreeFontSize.AccessibleDescription = CType(resources.GetObject("lblTreeFontSize.AccessibleDescription"), String)
        Me.lblTreeFontSize.AccessibleName = CType(resources.GetObject("lblTreeFontSize.AccessibleName"), String)
        Me.lblTreeFontSize.Anchor = CType(resources.GetObject("lblTreeFontSize.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTreeFontSize.AutoSize = CType(resources.GetObject("lblTreeFontSize.AutoSize"), Boolean)
        Me.lblTreeFontSize.Dock = CType(resources.GetObject("lblTreeFontSize.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTreeFontSize.Enabled = CType(resources.GetObject("lblTreeFontSize.Enabled"), Boolean)
        Me.lblTreeFontSize.Font = CType(resources.GetObject("lblTreeFontSize.Font"), System.Drawing.Font)
        Me.lblTreeFontSize.Image = CType(resources.GetObject("lblTreeFontSize.Image"), System.Drawing.Image)
        Me.lblTreeFontSize.ImageAlign = CType(resources.GetObject("lblTreeFontSize.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontSize.ImageIndex = CType(resources.GetObject("lblTreeFontSize.ImageIndex"), Integer)
        Me.lblTreeFontSize.ImeMode = CType(resources.GetObject("lblTreeFontSize.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTreeFontSize.Location = CType(resources.GetObject("lblTreeFontSize.Location"), System.Drawing.Point)
        Me.lblTreeFontSize.Name = "lblTreeFontSize"
        Me.lblTreeFontSize.RightToLeft = CType(resources.GetObject("lblTreeFontSize.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTreeFontSize.Size = CType(resources.GetObject("lblTreeFontSize.Size"), System.Drawing.Size)
        Me.lblTreeFontSize.TabIndex = CType(resources.GetObject("lblTreeFontSize.TabIndex"), Integer)
        Me.lblTreeFontSize.Text = resources.GetString("lblTreeFontSize.Text")
        Me.lblTreeFontSize.TextAlign = CType(resources.GetObject("lblTreeFontSize.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblTreeFontSize.Visible = CType(resources.GetObject("lblTreeFontSize.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = CType(resources.GetObject("GroupBox1.AccessibleDescription"), String)
        Me.GroupBox1.AccessibleName = CType(resources.GetObject("GroupBox1.AccessibleName"), String)
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.btnDocChange, Me.lblDocFontName, Me.Label4, Me.Label3, Me.Label2, Me.lblDocFontColour, Me.lblDocFontSize, Me.lblDocSample})
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
        'btnDocChange
        '
        Me.btnDocChange.AccessibleDescription = CType(resources.GetObject("btnDocChange.AccessibleDescription"), String)
        Me.btnDocChange.AccessibleName = CType(resources.GetObject("btnDocChange.AccessibleName"), String)
        Me.btnDocChange.Anchor = CType(resources.GetObject("btnDocChange.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDocChange.BackgroundImage = CType(resources.GetObject("btnDocChange.BackgroundImage"), System.Drawing.Image)
        Me.btnDocChange.Dock = CType(resources.GetObject("btnDocChange.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDocChange.Enabled = CType(resources.GetObject("btnDocChange.Enabled"), Boolean)
        Me.btnDocChange.FlatStyle = CType(resources.GetObject("btnDocChange.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDocChange.Font = CType(resources.GetObject("btnDocChange.Font"), System.Drawing.Font)
        Me.btnDocChange.Image = CType(resources.GetObject("btnDocChange.Image"), System.Drawing.Image)
        Me.btnDocChange.ImageAlign = CType(resources.GetObject("btnDocChange.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDocChange.ImageIndex = CType(resources.GetObject("btnDocChange.ImageIndex"), Integer)
        Me.btnDocChange.ImeMode = CType(resources.GetObject("btnDocChange.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDocChange.Location = CType(resources.GetObject("btnDocChange.Location"), System.Drawing.Point)
        Me.btnDocChange.Name = "btnDocChange"
        Me.btnDocChange.RightToLeft = CType(resources.GetObject("btnDocChange.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDocChange.Size = CType(resources.GetObject("btnDocChange.Size"), System.Drawing.Size)
        Me.btnDocChange.TabIndex = CType(resources.GetObject("btnDocChange.TabIndex"), Integer)
        Me.btnDocChange.Text = resources.GetString("btnDocChange.Text")
        Me.btnDocChange.TextAlign = CType(resources.GetObject("btnDocChange.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDocChange.Visible = CType(resources.GetObject("btnDocChange.Visible"), Boolean)
        '
        'lblDocFontName
        '
        Me.lblDocFontName.AccessibleDescription = CType(resources.GetObject("lblDocFontName.AccessibleDescription"), String)
        Me.lblDocFontName.AccessibleName = CType(resources.GetObject("lblDocFontName.AccessibleName"), String)
        Me.lblDocFontName.Anchor = CType(resources.GetObject("lblDocFontName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDocFontName.AutoSize = CType(resources.GetObject("lblDocFontName.AutoSize"), Boolean)
        Me.lblDocFontName.Dock = CType(resources.GetObject("lblDocFontName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDocFontName.Enabled = CType(resources.GetObject("lblDocFontName.Enabled"), Boolean)
        Me.lblDocFontName.Font = CType(resources.GetObject("lblDocFontName.Font"), System.Drawing.Font)
        Me.lblDocFontName.Image = CType(resources.GetObject("lblDocFontName.Image"), System.Drawing.Image)
        Me.lblDocFontName.ImageAlign = CType(resources.GetObject("lblDocFontName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontName.ImageIndex = CType(resources.GetObject("lblDocFontName.ImageIndex"), Integer)
        Me.lblDocFontName.ImeMode = CType(resources.GetObject("lblDocFontName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDocFontName.Location = CType(resources.GetObject("lblDocFontName.Location"), System.Drawing.Point)
        Me.lblDocFontName.Name = "lblDocFontName"
        Me.lblDocFontName.RightToLeft = CType(resources.GetObject("lblDocFontName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDocFontName.Size = CType(resources.GetObject("lblDocFontName.Size"), System.Drawing.Size)
        Me.lblDocFontName.TabIndex = CType(resources.GetObject("lblDocFontName.TabIndex"), Integer)
        Me.lblDocFontName.Text = resources.GetString("lblDocFontName.Text")
        Me.lblDocFontName.TextAlign = CType(resources.GetObject("lblDocFontName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontName.Visible = CType(resources.GetObject("lblDocFontName.Visible"), Boolean)
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
        'lblDocFontColour
        '
        Me.lblDocFontColour.AccessibleDescription = CType(resources.GetObject("lblDocFontColour.AccessibleDescription"), String)
        Me.lblDocFontColour.AccessibleName = CType(resources.GetObject("lblDocFontColour.AccessibleName"), String)
        Me.lblDocFontColour.Anchor = CType(resources.GetObject("lblDocFontColour.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDocFontColour.AutoSize = CType(resources.GetObject("lblDocFontColour.AutoSize"), Boolean)
        Me.lblDocFontColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocFontColour.Dock = CType(resources.GetObject("lblDocFontColour.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDocFontColour.Enabled = CType(resources.GetObject("lblDocFontColour.Enabled"), Boolean)
        Me.lblDocFontColour.Font = CType(resources.GetObject("lblDocFontColour.Font"), System.Drawing.Font)
        Me.lblDocFontColour.Image = CType(resources.GetObject("lblDocFontColour.Image"), System.Drawing.Image)
        Me.lblDocFontColour.ImageAlign = CType(resources.GetObject("lblDocFontColour.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontColour.ImageIndex = CType(resources.GetObject("lblDocFontColour.ImageIndex"), Integer)
        Me.lblDocFontColour.ImeMode = CType(resources.GetObject("lblDocFontColour.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDocFontColour.Location = CType(resources.GetObject("lblDocFontColour.Location"), System.Drawing.Point)
        Me.lblDocFontColour.Name = "lblDocFontColour"
        Me.lblDocFontColour.RightToLeft = CType(resources.GetObject("lblDocFontColour.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDocFontColour.Size = CType(resources.GetObject("lblDocFontColour.Size"), System.Drawing.Size)
        Me.lblDocFontColour.TabIndex = CType(resources.GetObject("lblDocFontColour.TabIndex"), Integer)
        Me.lblDocFontColour.Text = resources.GetString("lblDocFontColour.Text")
        Me.lblDocFontColour.TextAlign = CType(resources.GetObject("lblDocFontColour.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontColour.Visible = CType(resources.GetObject("lblDocFontColour.Visible"), Boolean)
        '
        'lblDocFontSize
        '
        Me.lblDocFontSize.AccessibleDescription = CType(resources.GetObject("lblDocFontSize.AccessibleDescription"), String)
        Me.lblDocFontSize.AccessibleName = CType(resources.GetObject("lblDocFontSize.AccessibleName"), String)
        Me.lblDocFontSize.Anchor = CType(resources.GetObject("lblDocFontSize.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDocFontSize.AutoSize = CType(resources.GetObject("lblDocFontSize.AutoSize"), Boolean)
        Me.lblDocFontSize.Dock = CType(resources.GetObject("lblDocFontSize.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDocFontSize.Enabled = CType(resources.GetObject("lblDocFontSize.Enabled"), Boolean)
        Me.lblDocFontSize.Font = CType(resources.GetObject("lblDocFontSize.Font"), System.Drawing.Font)
        Me.lblDocFontSize.Image = CType(resources.GetObject("lblDocFontSize.Image"), System.Drawing.Image)
        Me.lblDocFontSize.ImageAlign = CType(resources.GetObject("lblDocFontSize.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontSize.ImageIndex = CType(resources.GetObject("lblDocFontSize.ImageIndex"), Integer)
        Me.lblDocFontSize.ImeMode = CType(resources.GetObject("lblDocFontSize.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDocFontSize.Location = CType(resources.GetObject("lblDocFontSize.Location"), System.Drawing.Point)
        Me.lblDocFontSize.Name = "lblDocFontSize"
        Me.lblDocFontSize.RightToLeft = CType(resources.GetObject("lblDocFontSize.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDocFontSize.Size = CType(resources.GetObject("lblDocFontSize.Size"), System.Drawing.Size)
        Me.lblDocFontSize.TabIndex = CType(resources.GetObject("lblDocFontSize.TabIndex"), Integer)
        Me.lblDocFontSize.Text = resources.GetString("lblDocFontSize.Text")
        Me.lblDocFontSize.TextAlign = CType(resources.GetObject("lblDocFontSize.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDocFontSize.Visible = CType(resources.GetObject("lblDocFontSize.Visible"), Boolean)
        '
        'lblDocSample
        '
        Me.lblDocSample.AccessibleDescription = CType(resources.GetObject("lblDocSample.AccessibleDescription"), String)
        Me.lblDocSample.AccessibleName = CType(resources.GetObject("lblDocSample.AccessibleName"), String)
        Me.lblDocSample.Anchor = CType(resources.GetObject("lblDocSample.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDocSample.AutoSize = CType(resources.GetObject("lblDocSample.AutoSize"), Boolean)
        Me.lblDocSample.BackColor = System.Drawing.SystemColors.Window
        Me.lblDocSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDocSample.Dock = CType(resources.GetObject("lblDocSample.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDocSample.Enabled = CType(resources.GetObject("lblDocSample.Enabled"), Boolean)
        Me.lblDocSample.Font = CType(resources.GetObject("lblDocSample.Font"), System.Drawing.Font)
        Me.lblDocSample.Image = CType(resources.GetObject("lblDocSample.Image"), System.Drawing.Image)
        Me.lblDocSample.ImageAlign = CType(resources.GetObject("lblDocSample.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDocSample.ImageIndex = CType(resources.GetObject("lblDocSample.ImageIndex"), Integer)
        Me.lblDocSample.ImeMode = CType(resources.GetObject("lblDocSample.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDocSample.Location = CType(resources.GetObject("lblDocSample.Location"), System.Drawing.Point)
        Me.lblDocSample.Name = "lblDocSample"
        Me.lblDocSample.RightToLeft = CType(resources.GetObject("lblDocSample.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDocSample.Size = CType(resources.GetObject("lblDocSample.Size"), System.Drawing.Size)
        Me.lblDocSample.TabIndex = CType(resources.GetObject("lblDocSample.TabIndex"), Integer)
        Me.lblDocSample.Text = resources.GetString("lblDocSample.Text")
        Me.lblDocSample.TextAlign = CType(resources.GetObject("lblDocSample.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDocSample.Visible = CType(resources.GetObject("lblDocSample.Visible"), Boolean)
        '
        'TabPage3
        '
        Me.TabPage3.AccessibleDescription = CType(resources.GetObject("TabPage3.AccessibleDescription"), String)
        Me.TabPage3.AccessibleName = CType(resources.GetObject("TabPage3.AccessibleName"), String)
        Me.TabPage3.Anchor = CType(resources.GetObject("TabPage3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage3.AutoScroll = CType(resources.GetObject("TabPage3.AutoScroll"), Boolean)
        Me.TabPage3.AutoScrollMargin = CType(resources.GetObject("TabPage3.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage3.AutoScrollMinSize = CType(resources.GetObject("TabPage3.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.btnAddQuickLaunch})
        Me.TabPage3.Dock = CType(resources.GetObject("TabPage3.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage3.Enabled = CType(resources.GetObject("TabPage3.Enabled"), Boolean)
        Me.TabPage3.Font = CType(resources.GetObject("TabPage3.Font"), System.Drawing.Font)
        Me.TabPage3.ImageIndex = CType(resources.GetObject("TabPage3.ImageIndex"), Integer)
        Me.TabPage3.ImeMode = CType(resources.GetObject("TabPage3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage3.Location = CType(resources.GetObject("TabPage3.Location"), System.Drawing.Point)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.RightToLeft = CType(resources.GetObject("TabPage3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage3.Size = CType(resources.GetObject("TabPage3.Size"), System.Drawing.Size)
        Me.TabPage3.TabIndex = CType(resources.GetObject("TabPage3.TabIndex"), Integer)
        Me.TabPage3.Text = resources.GetString("TabPage3.Text")
        Me.TabPage3.ToolTipText = resources.GetString("TabPage3.ToolTipText")
        Me.TabPage3.Visible = CType(resources.GetObject("TabPage3.Visible"), Boolean)
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = CType(resources.GetObject("GroupBox2.AccessibleDescription"), String)
        Me.GroupBox2.AccessibleName = CType(resources.GetObject("GroupBox2.AccessibleName"), String)
        Me.GroupBox2.Anchor = CType(resources.GetObject("GroupBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TreeView1, Me.rdoStartupSelPage, Me.rdoStartupSelTopic})
        Me.GroupBox2.Dock = CType(resources.GetObject("GroupBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox2.Enabled = CType(resources.GetObject("GroupBox2.Enabled"), Boolean)
        Me.GroupBox2.Font = CType(resources.GetObject("GroupBox2.Font"), System.Drawing.Font)
        Me.GroupBox2.ImeMode = CType(resources.GetObject("GroupBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox2.Location = CType(resources.GetObject("GroupBox2.Location"), System.Drawing.Point)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = CType(resources.GetObject("GroupBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox2.Size = CType(resources.GetObject("GroupBox2.Size"), System.Drawing.Size)
        Me.GroupBox2.TabIndex = CType(resources.GetObject("GroupBox2.TabIndex"), Integer)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        Me.GroupBox2.Visible = CType(resources.GetObject("GroupBox2.Visible"), Boolean)
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
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'rdoStartupSelPage
        '
        Me.rdoStartupSelPage.AccessibleDescription = CType(resources.GetObject("rdoStartupSelPage.AccessibleDescription"), String)
        Me.rdoStartupSelPage.AccessibleName = CType(resources.GetObject("rdoStartupSelPage.AccessibleName"), String)
        Me.rdoStartupSelPage.Anchor = CType(resources.GetObject("rdoStartupSelPage.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoStartupSelPage.Appearance = CType(resources.GetObject("rdoStartupSelPage.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoStartupSelPage.BackgroundImage = CType(resources.GetObject("rdoStartupSelPage.BackgroundImage"), System.Drawing.Image)
        Me.rdoStartupSelPage.CheckAlign = CType(resources.GetObject("rdoStartupSelPage.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelPage.Checked = True
        Me.rdoStartupSelPage.Dock = CType(resources.GetObject("rdoStartupSelPage.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoStartupSelPage.Enabled = CType(resources.GetObject("rdoStartupSelPage.Enabled"), Boolean)
        Me.rdoStartupSelPage.FlatStyle = CType(resources.GetObject("rdoStartupSelPage.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoStartupSelPage.Font = CType(resources.GetObject("rdoStartupSelPage.Font"), System.Drawing.Font)
        Me.rdoStartupSelPage.Image = CType(resources.GetObject("rdoStartupSelPage.Image"), System.Drawing.Image)
        Me.rdoStartupSelPage.ImageAlign = CType(resources.GetObject("rdoStartupSelPage.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelPage.ImageIndex = CType(resources.GetObject("rdoStartupSelPage.ImageIndex"), Integer)
        Me.rdoStartupSelPage.ImeMode = CType(resources.GetObject("rdoStartupSelPage.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoStartupSelPage.Location = CType(resources.GetObject("rdoStartupSelPage.Location"), System.Drawing.Point)
        Me.rdoStartupSelPage.Name = "rdoStartupSelPage"
        Me.rdoStartupSelPage.RightToLeft = CType(resources.GetObject("rdoStartupSelPage.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoStartupSelPage.Size = CType(resources.GetObject("rdoStartupSelPage.Size"), System.Drawing.Size)
        Me.rdoStartupSelPage.TabIndex = CType(resources.GetObject("rdoStartupSelPage.TabIndex"), Integer)
        Me.rdoStartupSelPage.TabStop = True
        Me.rdoStartupSelPage.Text = resources.GetString("rdoStartupSelPage.Text")
        Me.rdoStartupSelPage.TextAlign = CType(resources.GetObject("rdoStartupSelPage.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelPage.Visible = CType(resources.GetObject("rdoStartupSelPage.Visible"), Boolean)
        '
        'rdoStartupSelTopic
        '
        Me.rdoStartupSelTopic.AccessibleDescription = CType(resources.GetObject("rdoStartupSelTopic.AccessibleDescription"), String)
        Me.rdoStartupSelTopic.AccessibleName = CType(resources.GetObject("rdoStartupSelTopic.AccessibleName"), String)
        Me.rdoStartupSelTopic.Anchor = CType(resources.GetObject("rdoStartupSelTopic.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoStartupSelTopic.Appearance = CType(resources.GetObject("rdoStartupSelTopic.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoStartupSelTopic.BackgroundImage = CType(resources.GetObject("rdoStartupSelTopic.BackgroundImage"), System.Drawing.Image)
        Me.rdoStartupSelTopic.CheckAlign = CType(resources.GetObject("rdoStartupSelTopic.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelTopic.Dock = CType(resources.GetObject("rdoStartupSelTopic.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoStartupSelTopic.Enabled = CType(resources.GetObject("rdoStartupSelTopic.Enabled"), Boolean)
        Me.rdoStartupSelTopic.FlatStyle = CType(resources.GetObject("rdoStartupSelTopic.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoStartupSelTopic.Font = CType(resources.GetObject("rdoStartupSelTopic.Font"), System.Drawing.Font)
        Me.rdoStartupSelTopic.Image = CType(resources.GetObject("rdoStartupSelTopic.Image"), System.Drawing.Image)
        Me.rdoStartupSelTopic.ImageAlign = CType(resources.GetObject("rdoStartupSelTopic.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelTopic.ImageIndex = CType(resources.GetObject("rdoStartupSelTopic.ImageIndex"), Integer)
        Me.rdoStartupSelTopic.ImeMode = CType(resources.GetObject("rdoStartupSelTopic.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoStartupSelTopic.Location = CType(resources.GetObject("rdoStartupSelTopic.Location"), System.Drawing.Point)
        Me.rdoStartupSelTopic.Name = "rdoStartupSelTopic"
        Me.rdoStartupSelTopic.RightToLeft = CType(resources.GetObject("rdoStartupSelTopic.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoStartupSelTopic.Size = CType(resources.GetObject("rdoStartupSelTopic.Size"), System.Drawing.Size)
        Me.rdoStartupSelTopic.TabIndex = CType(resources.GetObject("rdoStartupSelTopic.TabIndex"), Integer)
        Me.rdoStartupSelTopic.Text = resources.GetString("rdoStartupSelTopic.Text")
        Me.rdoStartupSelTopic.TextAlign = CType(resources.GetObject("rdoStartupSelTopic.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoStartupSelTopic.Visible = CType(resources.GetObject("rdoStartupSelTopic.Visible"), Boolean)
        '
        'btnAddQuickLaunch
        '
        Me.btnAddQuickLaunch.AccessibleDescription = CType(resources.GetObject("btnAddQuickLaunch.AccessibleDescription"), String)
        Me.btnAddQuickLaunch.AccessibleName = CType(resources.GetObject("btnAddQuickLaunch.AccessibleName"), String)
        Me.btnAddQuickLaunch.Anchor = CType(resources.GetObject("btnAddQuickLaunch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnAddQuickLaunch.BackgroundImage = CType(resources.GetObject("btnAddQuickLaunch.BackgroundImage"), System.Drawing.Image)
        Me.btnAddQuickLaunch.Dock = CType(resources.GetObject("btnAddQuickLaunch.Dock"), System.Windows.Forms.DockStyle)
        Me.btnAddQuickLaunch.Enabled = CType(resources.GetObject("btnAddQuickLaunch.Enabled"), Boolean)
        Me.btnAddQuickLaunch.FlatStyle = CType(resources.GetObject("btnAddQuickLaunch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnAddQuickLaunch.Font = CType(resources.GetObject("btnAddQuickLaunch.Font"), System.Drawing.Font)
        Me.btnAddQuickLaunch.Image = CType(resources.GetObject("btnAddQuickLaunch.Image"), System.Drawing.Image)
        Me.btnAddQuickLaunch.ImageAlign = CType(resources.GetObject("btnAddQuickLaunch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnAddQuickLaunch.ImageIndex = CType(resources.GetObject("btnAddQuickLaunch.ImageIndex"), Integer)
        Me.btnAddQuickLaunch.ImeMode = CType(resources.GetObject("btnAddQuickLaunch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnAddQuickLaunch.Location = CType(resources.GetObject("btnAddQuickLaunch.Location"), System.Drawing.Point)
        Me.btnAddQuickLaunch.Name = "btnAddQuickLaunch"
        Me.btnAddQuickLaunch.RightToLeft = CType(resources.GetObject("btnAddQuickLaunch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnAddQuickLaunch.Size = CType(resources.GetObject("btnAddQuickLaunch.Size"), System.Drawing.Size)
        Me.btnAddQuickLaunch.TabIndex = CType(resources.GetObject("btnAddQuickLaunch.TabIndex"), Integer)
        Me.btnAddQuickLaunch.Text = resources.GetString("btnAddQuickLaunch.Text")
        Me.btnAddQuickLaunch.TextAlign = CType(resources.GetObject("btnAddQuickLaunch.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnAddQuickLaunch.Visible = CType(resources.GetObject("btnAddQuickLaunch.Visible"), Boolean)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = CType(resources.GetObject("TabPage2.AccessibleDescription"), String)
        Me.TabPage2.AccessibleName = CType(resources.GetObject("TabPage2.AccessibleName"), String)
        Me.TabPage2.Anchor = CType(resources.GetObject("TabPage2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage2.AutoScroll = CType(resources.GetObject("TabPage2.AutoScroll"), Boolean)
        Me.TabPage2.AutoScrollMargin = CType(resources.GetObject("TabPage2.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage2.AutoScrollMinSize = CType(resources.GetObject("TabPage2.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label24, Me.txtIncrementAmount, Me.lblIncrementAmount, Me.rdSortSeqNum, Me.rdoSortAlpha, Me.Label6})
        Me.TabPage2.Dock = CType(resources.GetObject("TabPage2.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage2.Enabled = CType(resources.GetObject("TabPage2.Enabled"), Boolean)
        Me.TabPage2.Font = CType(resources.GetObject("TabPage2.Font"), System.Drawing.Font)
        Me.TabPage2.ImageIndex = CType(resources.GetObject("TabPage2.ImageIndex"), Integer)
        Me.TabPage2.ImeMode = CType(resources.GetObject("TabPage2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage2.Location = CType(resources.GetObject("TabPage2.Location"), System.Drawing.Point)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.RightToLeft = CType(resources.GetObject("TabPage2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage2.Size = CType(resources.GetObject("TabPage2.Size"), System.Drawing.Size)
        Me.TabPage2.TabIndex = CType(resources.GetObject("TabPage2.TabIndex"), Integer)
        Me.TabPage2.Text = resources.GetString("TabPage2.Text")
        Me.TabPage2.ToolTipText = resources.GetString("TabPage2.ToolTipText")
        Me.TabPage2.Visible = CType(resources.GetObject("TabPage2.Visible"), Boolean)
        '
        'Label24
        '
        Me.Label24.AccessibleDescription = CType(resources.GetObject("Label24.AccessibleDescription"), String)
        Me.Label24.AccessibleName = CType(resources.GetObject("Label24.AccessibleName"), String)
        Me.Label24.Anchor = CType(resources.GetObject("Label24.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = CType(resources.GetObject("Label24.AutoSize"), Boolean)
        Me.Label24.Dock = CType(resources.GetObject("Label24.Dock"), System.Windows.Forms.DockStyle)
        Me.Label24.Enabled = CType(resources.GetObject("Label24.Enabled"), Boolean)
        Me.Label24.Font = CType(resources.GetObject("Label24.Font"), System.Drawing.Font)
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.ImageAlign = CType(resources.GetObject("Label24.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label24.ImageIndex = CType(resources.GetObject("Label24.ImageIndex"), Integer)
        Me.Label24.ImeMode = CType(resources.GetObject("Label24.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label24.Location = CType(resources.GetObject("Label24.Location"), System.Drawing.Point)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = CType(resources.GetObject("Label24.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label24.Size = CType(resources.GetObject("Label24.Size"), System.Drawing.Size)
        Me.Label24.TabIndex = CType(resources.GetObject("Label24.TabIndex"), Integer)
        Me.Label24.Text = resources.GetString("Label24.Text")
        Me.Label24.TextAlign = CType(resources.GetObject("Label24.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label24.Visible = CType(resources.GetObject("Label24.Visible"), Boolean)
        '
        'txtIncrementAmount
        '
        Me.txtIncrementAmount.AccessibleDescription = CType(resources.GetObject("txtIncrementAmount.AccessibleDescription"), String)
        Me.txtIncrementAmount.AccessibleName = CType(resources.GetObject("txtIncrementAmount.AccessibleName"), String)
        Me.txtIncrementAmount.Anchor = CType(resources.GetObject("txtIncrementAmount.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtIncrementAmount.AutoSize = CType(resources.GetObject("txtIncrementAmount.AutoSize"), Boolean)
        Me.txtIncrementAmount.BackgroundImage = CType(resources.GetObject("txtIncrementAmount.BackgroundImage"), System.Drawing.Image)
        Me.txtIncrementAmount.Dock = CType(resources.GetObject("txtIncrementAmount.Dock"), System.Windows.Forms.DockStyle)
        Me.txtIncrementAmount.Enabled = CType(resources.GetObject("txtIncrementAmount.Enabled"), Boolean)
        Me.txtIncrementAmount.Font = CType(resources.GetObject("txtIncrementAmount.Font"), System.Drawing.Font)
        Me.txtIncrementAmount.ImeMode = CType(resources.GetObject("txtIncrementAmount.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtIncrementAmount.Location = CType(resources.GetObject("txtIncrementAmount.Location"), System.Drawing.Point)
        Me.txtIncrementAmount.MaxLength = CType(resources.GetObject("txtIncrementAmount.MaxLength"), Integer)
        Me.txtIncrementAmount.Multiline = CType(resources.GetObject("txtIncrementAmount.Multiline"), Boolean)
        Me.txtIncrementAmount.Name = "txtIncrementAmount"
        Me.txtIncrementAmount.PasswordChar = CType(resources.GetObject("txtIncrementAmount.PasswordChar"), Char)
        Me.txtIncrementAmount.RightToLeft = CType(resources.GetObject("txtIncrementAmount.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtIncrementAmount.ScrollBars = CType(resources.GetObject("txtIncrementAmount.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtIncrementAmount.Size = CType(resources.GetObject("txtIncrementAmount.Size"), System.Drawing.Size)
        Me.txtIncrementAmount.TabIndex = CType(resources.GetObject("txtIncrementAmount.TabIndex"), Integer)
        Me.txtIncrementAmount.Text = resources.GetString("txtIncrementAmount.Text")
        Me.txtIncrementAmount.TextAlign = CType(resources.GetObject("txtIncrementAmount.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtIncrementAmount.Visible = CType(resources.GetObject("txtIncrementAmount.Visible"), Boolean)
        Me.txtIncrementAmount.WordWrap = CType(resources.GetObject("txtIncrementAmount.WordWrap"), Boolean)
        '
        'lblIncrementAmount
        '
        Me.lblIncrementAmount.AccessibleDescription = CType(resources.GetObject("lblIncrementAmount.AccessibleDescription"), String)
        Me.lblIncrementAmount.AccessibleName = CType(resources.GetObject("lblIncrementAmount.AccessibleName"), String)
        Me.lblIncrementAmount.Anchor = CType(resources.GetObject("lblIncrementAmount.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblIncrementAmount.AutoSize = CType(resources.GetObject("lblIncrementAmount.AutoSize"), Boolean)
        Me.lblIncrementAmount.Dock = CType(resources.GetObject("lblIncrementAmount.Dock"), System.Windows.Forms.DockStyle)
        Me.lblIncrementAmount.Enabled = CType(resources.GetObject("lblIncrementAmount.Enabled"), Boolean)
        Me.lblIncrementAmount.Font = CType(resources.GetObject("lblIncrementAmount.Font"), System.Drawing.Font)
        Me.lblIncrementAmount.Image = CType(resources.GetObject("lblIncrementAmount.Image"), System.Drawing.Image)
        Me.lblIncrementAmount.ImageAlign = CType(resources.GetObject("lblIncrementAmount.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblIncrementAmount.ImageIndex = CType(resources.GetObject("lblIncrementAmount.ImageIndex"), Integer)
        Me.lblIncrementAmount.ImeMode = CType(resources.GetObject("lblIncrementAmount.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblIncrementAmount.Location = CType(resources.GetObject("lblIncrementAmount.Location"), System.Drawing.Point)
        Me.lblIncrementAmount.Name = "lblIncrementAmount"
        Me.lblIncrementAmount.RightToLeft = CType(resources.GetObject("lblIncrementAmount.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblIncrementAmount.Size = CType(resources.GetObject("lblIncrementAmount.Size"), System.Drawing.Size)
        Me.lblIncrementAmount.TabIndex = CType(resources.GetObject("lblIncrementAmount.TabIndex"), Integer)
        Me.lblIncrementAmount.Text = resources.GetString("lblIncrementAmount.Text")
        Me.lblIncrementAmount.TextAlign = CType(resources.GetObject("lblIncrementAmount.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblIncrementAmount.Visible = CType(resources.GetObject("lblIncrementAmount.Visible"), Boolean)
        '
        'rdSortSeqNum
        '
        Me.rdSortSeqNum.AccessibleDescription = CType(resources.GetObject("rdSortSeqNum.AccessibleDescription"), String)
        Me.rdSortSeqNum.AccessibleName = CType(resources.GetObject("rdSortSeqNum.AccessibleName"), String)
        Me.rdSortSeqNum.Anchor = CType(resources.GetObject("rdSortSeqNum.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdSortSeqNum.Appearance = CType(resources.GetObject("rdSortSeqNum.Appearance"), System.Windows.Forms.Appearance)
        Me.rdSortSeqNum.BackgroundImage = CType(resources.GetObject("rdSortSeqNum.BackgroundImage"), System.Drawing.Image)
        Me.rdSortSeqNum.CheckAlign = CType(resources.GetObject("rdSortSeqNum.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdSortSeqNum.Dock = CType(resources.GetObject("rdSortSeqNum.Dock"), System.Windows.Forms.DockStyle)
        Me.rdSortSeqNum.Enabled = CType(resources.GetObject("rdSortSeqNum.Enabled"), Boolean)
        Me.rdSortSeqNum.FlatStyle = CType(resources.GetObject("rdSortSeqNum.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdSortSeqNum.Font = CType(resources.GetObject("rdSortSeqNum.Font"), System.Drawing.Font)
        Me.rdSortSeqNum.Image = CType(resources.GetObject("rdSortSeqNum.Image"), System.Drawing.Image)
        Me.rdSortSeqNum.ImageAlign = CType(resources.GetObject("rdSortSeqNum.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdSortSeqNum.ImageIndex = CType(resources.GetObject("rdSortSeqNum.ImageIndex"), Integer)
        Me.rdSortSeqNum.ImeMode = CType(resources.GetObject("rdSortSeqNum.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdSortSeqNum.Location = CType(resources.GetObject("rdSortSeqNum.Location"), System.Drawing.Point)
        Me.rdSortSeqNum.Name = "rdSortSeqNum"
        Me.rdSortSeqNum.RightToLeft = CType(resources.GetObject("rdSortSeqNum.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdSortSeqNum.Size = CType(resources.GetObject("rdSortSeqNum.Size"), System.Drawing.Size)
        Me.rdSortSeqNum.TabIndex = CType(resources.GetObject("rdSortSeqNum.TabIndex"), Integer)
        Me.rdSortSeqNum.Text = resources.GetString("rdSortSeqNum.Text")
        Me.rdSortSeqNum.TextAlign = CType(resources.GetObject("rdSortSeqNum.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdSortSeqNum.Visible = CType(resources.GetObject("rdSortSeqNum.Visible"), Boolean)
        '
        'rdoSortAlpha
        '
        Me.rdoSortAlpha.AccessibleDescription = CType(resources.GetObject("rdoSortAlpha.AccessibleDescription"), String)
        Me.rdoSortAlpha.AccessibleName = CType(resources.GetObject("rdoSortAlpha.AccessibleName"), String)
        Me.rdoSortAlpha.Anchor = CType(resources.GetObject("rdoSortAlpha.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoSortAlpha.Appearance = CType(resources.GetObject("rdoSortAlpha.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoSortAlpha.BackgroundImage = CType(resources.GetObject("rdoSortAlpha.BackgroundImage"), System.Drawing.Image)
        Me.rdoSortAlpha.CheckAlign = CType(resources.GetObject("rdoSortAlpha.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoSortAlpha.Checked = True
        Me.rdoSortAlpha.Dock = CType(resources.GetObject("rdoSortAlpha.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoSortAlpha.Enabled = CType(resources.GetObject("rdoSortAlpha.Enabled"), Boolean)
        Me.rdoSortAlpha.FlatStyle = CType(resources.GetObject("rdoSortAlpha.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoSortAlpha.Font = CType(resources.GetObject("rdoSortAlpha.Font"), System.Drawing.Font)
        Me.rdoSortAlpha.Image = CType(resources.GetObject("rdoSortAlpha.Image"), System.Drawing.Image)
        Me.rdoSortAlpha.ImageAlign = CType(resources.GetObject("rdoSortAlpha.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoSortAlpha.ImageIndex = CType(resources.GetObject("rdoSortAlpha.ImageIndex"), Integer)
        Me.rdoSortAlpha.ImeMode = CType(resources.GetObject("rdoSortAlpha.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoSortAlpha.Location = CType(resources.GetObject("rdoSortAlpha.Location"), System.Drawing.Point)
        Me.rdoSortAlpha.Name = "rdoSortAlpha"
        Me.rdoSortAlpha.RightToLeft = CType(resources.GetObject("rdoSortAlpha.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoSortAlpha.Size = CType(resources.GetObject("rdoSortAlpha.Size"), System.Drawing.Size)
        Me.rdoSortAlpha.TabIndex = CType(resources.GetObject("rdoSortAlpha.TabIndex"), Integer)
        Me.rdoSortAlpha.TabStop = True
        Me.rdoSortAlpha.Text = resources.GetString("rdoSortAlpha.Text")
        Me.rdoSortAlpha.TextAlign = CType(resources.GetObject("rdoSortAlpha.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoSortAlpha.Visible = CType(resources.GetObject("rdoSortAlpha.Visible"), Boolean)
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
        'TabPage4
        '
        Me.TabPage4.AccessibleDescription = CType(resources.GetObject("TabPage4.AccessibleDescription"), String)
        Me.TabPage4.AccessibleName = CType(resources.GetObject("TabPage4.AccessibleName"), String)
        Me.TabPage4.Anchor = CType(resources.GetObject("TabPage4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage4.AutoScroll = CType(resources.GetObject("TabPage4.AutoScroll"), Boolean)
        Me.TabPage4.AutoScrollMargin = CType(resources.GetObject("TabPage4.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage4.AutoScrollMinSize = CType(resources.GetObject("TabPage4.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpNoDictionaryFound, Me.Label10, Me.cboCurrentDictionary})
        Me.TabPage4.Dock = CType(resources.GetObject("TabPage4.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage4.Enabled = CType(resources.GetObject("TabPage4.Enabled"), Boolean)
        Me.TabPage4.Font = CType(resources.GetObject("TabPage4.Font"), System.Drawing.Font)
        Me.TabPage4.ImageIndex = CType(resources.GetObject("TabPage4.ImageIndex"), Integer)
        Me.TabPage4.ImeMode = CType(resources.GetObject("TabPage4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage4.Location = CType(resources.GetObject("TabPage4.Location"), System.Drawing.Point)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.RightToLeft = CType(resources.GetObject("TabPage4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage4.Size = CType(resources.GetObject("TabPage4.Size"), System.Drawing.Size)
        Me.TabPage4.TabIndex = CType(resources.GetObject("TabPage4.TabIndex"), Integer)
        Me.TabPage4.Text = resources.GetString("TabPage4.Text")
        Me.TabPage4.ToolTipText = resources.GetString("TabPage4.ToolTipText")
        Me.TabPage4.Visible = CType(resources.GetObject("TabPage4.Visible"), Boolean)
        '
        'grpNoDictionaryFound
        '
        Me.grpNoDictionaryFound.AccessibleDescription = CType(resources.GetObject("grpNoDictionaryFound.AccessibleDescription"), String)
        Me.grpNoDictionaryFound.AccessibleName = CType(resources.GetObject("grpNoDictionaryFound.AccessibleName"), String)
        Me.grpNoDictionaryFound.Anchor = CType(resources.GetObject("grpNoDictionaryFound.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpNoDictionaryFound.BackgroundImage = CType(resources.GetObject("grpNoDictionaryFound.BackgroundImage"), System.Drawing.Image)
        Me.grpNoDictionaryFound.Controls.AddRange(New System.Windows.Forms.Control() {Me.lnkURL, Me.Label12})
        Me.grpNoDictionaryFound.Dock = CType(resources.GetObject("grpNoDictionaryFound.Dock"), System.Windows.Forms.DockStyle)
        Me.grpNoDictionaryFound.Enabled = CType(resources.GetObject("grpNoDictionaryFound.Enabled"), Boolean)
        Me.grpNoDictionaryFound.Font = CType(resources.GetObject("grpNoDictionaryFound.Font"), System.Drawing.Font)
        Me.grpNoDictionaryFound.ForeColor = System.Drawing.Color.Blue
        Me.grpNoDictionaryFound.ImeMode = CType(resources.GetObject("grpNoDictionaryFound.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpNoDictionaryFound.Location = CType(resources.GetObject("grpNoDictionaryFound.Location"), System.Drawing.Point)
        Me.grpNoDictionaryFound.Name = "grpNoDictionaryFound"
        Me.grpNoDictionaryFound.RightToLeft = CType(resources.GetObject("grpNoDictionaryFound.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpNoDictionaryFound.Size = CType(resources.GetObject("grpNoDictionaryFound.Size"), System.Drawing.Size)
        Me.grpNoDictionaryFound.TabIndex = CType(resources.GetObject("grpNoDictionaryFound.TabIndex"), Integer)
        Me.grpNoDictionaryFound.TabStop = False
        Me.grpNoDictionaryFound.Text = resources.GetString("grpNoDictionaryFound.Text")
        Me.grpNoDictionaryFound.Visible = CType(resources.GetObject("grpNoDictionaryFound.Visible"), Boolean)
        '
        'lnkURL
        '
        Me.lnkURL.AccessibleDescription = CType(resources.GetObject("lnkURL.AccessibleDescription"), String)
        Me.lnkURL.AccessibleName = CType(resources.GetObject("lnkURL.AccessibleName"), String)
        Me.lnkURL.Anchor = CType(resources.GetObject("lnkURL.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lnkURL.AutoSize = CType(resources.GetObject("lnkURL.AutoSize"), Boolean)
        Me.lnkURL.Dock = CType(resources.GetObject("lnkURL.Dock"), System.Windows.Forms.DockStyle)
        Me.lnkURL.Enabled = CType(resources.GetObject("lnkURL.Enabled"), Boolean)
        Me.lnkURL.Font = CType(resources.GetObject("lnkURL.Font"), System.Drawing.Font)
        Me.lnkURL.Image = CType(resources.GetObject("lnkURL.Image"), System.Drawing.Image)
        Me.lnkURL.ImageAlign = CType(resources.GetObject("lnkURL.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lnkURL.ImageIndex = CType(resources.GetObject("lnkURL.ImageIndex"), Integer)
        Me.lnkURL.ImeMode = CType(resources.GetObject("lnkURL.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lnkURL.LinkArea = CType(resources.GetObject("lnkURL.LinkArea"), System.Windows.Forms.LinkArea)
        Me.lnkURL.Location = CType(resources.GetObject("lnkURL.Location"), System.Drawing.Point)
        Me.lnkURL.Name = "lnkURL"
        Me.lnkURL.RightToLeft = CType(resources.GetObject("lnkURL.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lnkURL.Size = CType(resources.GetObject("lnkURL.Size"), System.Drawing.Size)
        Me.lnkURL.TabIndex = CType(resources.GetObject("lnkURL.TabIndex"), Integer)
        Me.lnkURL.TabStop = True
        Me.lnkURL.Text = resources.GetString("lnkURL.Text")
        Me.lnkURL.TextAlign = CType(resources.GetObject("lnkURL.TextAlign"), System.Drawing.ContentAlignment)
        Me.lnkURL.Visible = CType(resources.GetObject("lnkURL.Visible"), Boolean)
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = CType(resources.GetObject("Label12.AccessibleDescription"), String)
        Me.Label12.AccessibleName = CType(resources.GetObject("Label12.AccessibleName"), String)
        Me.Label12.Anchor = CType(resources.GetObject("Label12.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = CType(resources.GetObject("Label12.AutoSize"), Boolean)
        Me.Label12.Dock = CType(resources.GetObject("Label12.Dock"), System.Windows.Forms.DockStyle)
        Me.Label12.Enabled = CType(resources.GetObject("Label12.Enabled"), Boolean)
        Me.Label12.Font = CType(resources.GetObject("Label12.Font"), System.Drawing.Font)
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = CType(resources.GetObject("Label12.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label12.ImageIndex = CType(resources.GetObject("Label12.ImageIndex"), Integer)
        Me.Label12.ImeMode = CType(resources.GetObject("Label12.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label12.Location = CType(resources.GetObject("Label12.Location"), System.Drawing.Point)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = CType(resources.GetObject("Label12.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label12.Size = CType(resources.GetObject("Label12.Size"), System.Drawing.Size)
        Me.Label12.TabIndex = CType(resources.GetObject("Label12.TabIndex"), Integer)
        Me.Label12.Text = resources.GetString("Label12.Text")
        Me.Label12.TextAlign = CType(resources.GetObject("Label12.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label12.Visible = CType(resources.GetObject("Label12.Visible"), Boolean)
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = CType(resources.GetObject("Label10.AccessibleDescription"), String)
        Me.Label10.AccessibleName = CType(resources.GetObject("Label10.AccessibleName"), String)
        Me.Label10.Anchor = CType(resources.GetObject("Label10.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = CType(resources.GetObject("Label10.AutoSize"), Boolean)
        Me.Label10.Dock = CType(resources.GetObject("Label10.Dock"), System.Windows.Forms.DockStyle)
        Me.Label10.Enabled = CType(resources.GetObject("Label10.Enabled"), Boolean)
        Me.Label10.Font = CType(resources.GetObject("Label10.Font"), System.Drawing.Font)
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = CType(resources.GetObject("Label10.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label10.ImageIndex = CType(resources.GetObject("Label10.ImageIndex"), Integer)
        Me.Label10.ImeMode = CType(resources.GetObject("Label10.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label10.Location = CType(resources.GetObject("Label10.Location"), System.Drawing.Point)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = CType(resources.GetObject("Label10.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label10.Size = CType(resources.GetObject("Label10.Size"), System.Drawing.Size)
        Me.Label10.TabIndex = CType(resources.GetObject("Label10.TabIndex"), Integer)
        Me.Label10.Text = resources.GetString("Label10.Text")
        Me.Label10.TextAlign = CType(resources.GetObject("Label10.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label10.Visible = CType(resources.GetObject("Label10.Visible"), Boolean)
        '
        'cboCurrentDictionary
        '
        Me.cboCurrentDictionary.AccessibleDescription = CType(resources.GetObject("cboCurrentDictionary.AccessibleDescription"), String)
        Me.cboCurrentDictionary.AccessibleName = CType(resources.GetObject("cboCurrentDictionary.AccessibleName"), String)
        Me.cboCurrentDictionary.Anchor = CType(resources.GetObject("cboCurrentDictionary.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboCurrentDictionary.BackgroundImage = CType(resources.GetObject("cboCurrentDictionary.BackgroundImage"), System.Drawing.Image)
        Me.cboCurrentDictionary.Dock = CType(resources.GetObject("cboCurrentDictionary.Dock"), System.Windows.Forms.DockStyle)
        Me.cboCurrentDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrentDictionary.Enabled = CType(resources.GetObject("cboCurrentDictionary.Enabled"), Boolean)
        Me.cboCurrentDictionary.Font = CType(resources.GetObject("cboCurrentDictionary.Font"), System.Drawing.Font)
        Me.cboCurrentDictionary.ImeMode = CType(resources.GetObject("cboCurrentDictionary.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboCurrentDictionary.IntegralHeight = CType(resources.GetObject("cboCurrentDictionary.IntegralHeight"), Boolean)
        Me.cboCurrentDictionary.ItemHeight = CType(resources.GetObject("cboCurrentDictionary.ItemHeight"), Integer)
        Me.cboCurrentDictionary.Location = CType(resources.GetObject("cboCurrentDictionary.Location"), System.Drawing.Point)
        Me.cboCurrentDictionary.MaxDropDownItems = CType(resources.GetObject("cboCurrentDictionary.MaxDropDownItems"), Integer)
        Me.cboCurrentDictionary.MaxLength = CType(resources.GetObject("cboCurrentDictionary.MaxLength"), Integer)
        Me.cboCurrentDictionary.Name = "cboCurrentDictionary"
        Me.cboCurrentDictionary.RightToLeft = CType(resources.GetObject("cboCurrentDictionary.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboCurrentDictionary.Size = CType(resources.GetObject("cboCurrentDictionary.Size"), System.Drawing.Size)
        Me.cboCurrentDictionary.TabIndex = CType(resources.GetObject("cboCurrentDictionary.TabIndex"), Integer)
        Me.cboCurrentDictionary.Text = resources.GetString("cboCurrentDictionary.Text")
        Me.cboCurrentDictionary.Visible = CType(resources.GetObject("cboCurrentDictionary.Visible"), Boolean)
        '
        'TabPage5
        '
        Me.TabPage5.AccessibleDescription = CType(resources.GetObject("TabPage5.AccessibleDescription"), String)
        Me.TabPage5.AccessibleName = CType(resources.GetObject("TabPage5.AccessibleName"), String)
        Me.TabPage5.Anchor = CType(resources.GetObject("TabPage5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage5.AutoScroll = CType(resources.GetObject("TabPage5.AutoScroll"), Boolean)
        Me.TabPage5.AutoScrollMargin = CType(resources.GetObject("TabPage5.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage5.AutoScrollMinSize = CType(resources.GetObject("TabPage5.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), System.Drawing.Image)
        Me.TabPage5.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.rdoTempOrNormTemp, Me.rdoTempOrNormNorm, Me.tabTemplates})
        Me.TabPage5.Dock = CType(resources.GetObject("TabPage5.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage5.Enabled = CType(resources.GetObject("TabPage5.Enabled"), Boolean)
        Me.TabPage5.Font = CType(resources.GetObject("TabPage5.Font"), System.Drawing.Font)
        Me.TabPage5.ImageIndex = CType(resources.GetObject("TabPage5.ImageIndex"), Integer)
        Me.TabPage5.ImeMode = CType(resources.GetObject("TabPage5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage5.Location = CType(resources.GetObject("TabPage5.Location"), System.Drawing.Point)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.RightToLeft = CType(resources.GetObject("TabPage5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage5.Size = CType(resources.GetObject("TabPage5.Size"), System.Drawing.Size)
        Me.TabPage5.TabIndex = CType(resources.GetObject("TabPage5.TabIndex"), Integer)
        Me.TabPage5.Text = resources.GetString("TabPage5.Text")
        Me.TabPage5.ToolTipText = resources.GetString("TabPage5.ToolTipText")
        Me.TabPage5.Visible = CType(resources.GetObject("TabPage5.Visible"), Boolean)
        '
        'Label14
        '
        Me.Label14.AccessibleDescription = CType(resources.GetObject("Label14.AccessibleDescription"), String)
        Me.Label14.AccessibleName = CType(resources.GetObject("Label14.AccessibleName"), String)
        Me.Label14.Anchor = CType(resources.GetObject("Label14.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = CType(resources.GetObject("Label14.AutoSize"), Boolean)
        Me.Label14.Dock = CType(resources.GetObject("Label14.Dock"), System.Windows.Forms.DockStyle)
        Me.Label14.Enabled = CType(resources.GetObject("Label14.Enabled"), Boolean)
        Me.Label14.Font = CType(resources.GetObject("Label14.Font"), System.Drawing.Font)
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = CType(resources.GetObject("Label14.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label14.ImageIndex = CType(resources.GetObject("Label14.ImageIndex"), Integer)
        Me.Label14.ImeMode = CType(resources.GetObject("Label14.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label14.Location = CType(resources.GetObject("Label14.Location"), System.Drawing.Point)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = CType(resources.GetObject("Label14.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label14.Size = CType(resources.GetObject("Label14.Size"), System.Drawing.Size)
        Me.Label14.TabIndex = CType(resources.GetObject("Label14.TabIndex"), Integer)
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = CType(resources.GetObject("Label14.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label14.Visible = CType(resources.GetObject("Label14.Visible"), Boolean)
        '
        'rdoTempOrNormTemp
        '
        Me.rdoTempOrNormTemp.AccessibleDescription = CType(resources.GetObject("rdoTempOrNormTemp.AccessibleDescription"), String)
        Me.rdoTempOrNormTemp.AccessibleName = CType(resources.GetObject("rdoTempOrNormTemp.AccessibleName"), String)
        Me.rdoTempOrNormTemp.Anchor = CType(resources.GetObject("rdoTempOrNormTemp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoTempOrNormTemp.Appearance = CType(resources.GetObject("rdoTempOrNormTemp.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoTempOrNormTemp.BackgroundImage = CType(resources.GetObject("rdoTempOrNormTemp.BackgroundImage"), System.Drawing.Image)
        Me.rdoTempOrNormTemp.CheckAlign = CType(resources.GetObject("rdoTempOrNormTemp.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormTemp.Dock = CType(resources.GetObject("rdoTempOrNormTemp.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoTempOrNormTemp.Enabled = CType(resources.GetObject("rdoTempOrNormTemp.Enabled"), Boolean)
        Me.rdoTempOrNormTemp.FlatStyle = CType(resources.GetObject("rdoTempOrNormTemp.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoTempOrNormTemp.Font = CType(resources.GetObject("rdoTempOrNormTemp.Font"), System.Drawing.Font)
        Me.rdoTempOrNormTemp.Image = CType(resources.GetObject("rdoTempOrNormTemp.Image"), System.Drawing.Image)
        Me.rdoTempOrNormTemp.ImageAlign = CType(resources.GetObject("rdoTempOrNormTemp.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormTemp.ImageIndex = CType(resources.GetObject("rdoTempOrNormTemp.ImageIndex"), Integer)
        Me.rdoTempOrNormTemp.ImeMode = CType(resources.GetObject("rdoTempOrNormTemp.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoTempOrNormTemp.Location = CType(resources.GetObject("rdoTempOrNormTemp.Location"), System.Drawing.Point)
        Me.rdoTempOrNormTemp.Name = "rdoTempOrNormTemp"
        Me.rdoTempOrNormTemp.RightToLeft = CType(resources.GetObject("rdoTempOrNormTemp.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoTempOrNormTemp.Size = CType(resources.GetObject("rdoTempOrNormTemp.Size"), System.Drawing.Size)
        Me.rdoTempOrNormTemp.TabIndex = CType(resources.GetObject("rdoTempOrNormTemp.TabIndex"), Integer)
        Me.rdoTempOrNormTemp.Text = resources.GetString("rdoTempOrNormTemp.Text")
        Me.rdoTempOrNormTemp.TextAlign = CType(resources.GetObject("rdoTempOrNormTemp.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormTemp.Visible = CType(resources.GetObject("rdoTempOrNormTemp.Visible"), Boolean)
        '
        'rdoTempOrNormNorm
        '
        Me.rdoTempOrNormNorm.AccessibleDescription = CType(resources.GetObject("rdoTempOrNormNorm.AccessibleDescription"), String)
        Me.rdoTempOrNormNorm.AccessibleName = CType(resources.GetObject("rdoTempOrNormNorm.AccessibleName"), String)
        Me.rdoTempOrNormNorm.Anchor = CType(resources.GetObject("rdoTempOrNormNorm.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoTempOrNormNorm.Appearance = CType(resources.GetObject("rdoTempOrNormNorm.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoTempOrNormNorm.BackgroundImage = CType(resources.GetObject("rdoTempOrNormNorm.BackgroundImage"), System.Drawing.Image)
        Me.rdoTempOrNormNorm.CheckAlign = CType(resources.GetObject("rdoTempOrNormNorm.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormNorm.Checked = True
        Me.rdoTempOrNormNorm.Dock = CType(resources.GetObject("rdoTempOrNormNorm.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoTempOrNormNorm.Enabled = CType(resources.GetObject("rdoTempOrNormNorm.Enabled"), Boolean)
        Me.rdoTempOrNormNorm.FlatStyle = CType(resources.GetObject("rdoTempOrNormNorm.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoTempOrNormNorm.Font = CType(resources.GetObject("rdoTempOrNormNorm.Font"), System.Drawing.Font)
        Me.rdoTempOrNormNorm.Image = CType(resources.GetObject("rdoTempOrNormNorm.Image"), System.Drawing.Image)
        Me.rdoTempOrNormNorm.ImageAlign = CType(resources.GetObject("rdoTempOrNormNorm.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormNorm.ImageIndex = CType(resources.GetObject("rdoTempOrNormNorm.ImageIndex"), Integer)
        Me.rdoTempOrNormNorm.ImeMode = CType(resources.GetObject("rdoTempOrNormNorm.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoTempOrNormNorm.Location = CType(resources.GetObject("rdoTempOrNormNorm.Location"), System.Drawing.Point)
        Me.rdoTempOrNormNorm.Name = "rdoTempOrNormNorm"
        Me.rdoTempOrNormNorm.RightToLeft = CType(resources.GetObject("rdoTempOrNormNorm.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoTempOrNormNorm.Size = CType(resources.GetObject("rdoTempOrNormNorm.Size"), System.Drawing.Size)
        Me.rdoTempOrNormNorm.TabIndex = CType(resources.GetObject("rdoTempOrNormNorm.TabIndex"), Integer)
        Me.rdoTempOrNormNorm.TabStop = True
        Me.rdoTempOrNormNorm.Text = resources.GetString("rdoTempOrNormNorm.Text")
        Me.rdoTempOrNormNorm.TextAlign = CType(resources.GetObject("rdoTempOrNormNorm.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoTempOrNormNorm.Visible = CType(resources.GetObject("rdoTempOrNormNorm.Visible"), Boolean)
        '
        'tabTemplates
        '
        Me.tabTemplates.AccessibleDescription = CType(resources.GetObject("tabTemplates.AccessibleDescription"), String)
        Me.tabTemplates.AccessibleName = CType(resources.GetObject("tabTemplates.AccessibleName"), String)
        Me.tabTemplates.Alignment = CType(resources.GetObject("tabTemplates.Alignment"), System.Windows.Forms.TabAlignment)
        Me.tabTemplates.Anchor = CType(resources.GetObject("tabTemplates.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.tabTemplates.Appearance = CType(resources.GetObject("tabTemplates.Appearance"), System.Windows.Forms.TabAppearance)
        Me.tabTemplates.BackgroundImage = CType(resources.GetObject("tabTemplates.BackgroundImage"), System.Drawing.Image)
        Me.tabTemplates.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage6, Me.TabPage7})
        Me.tabTemplates.Dock = CType(resources.GetObject("tabTemplates.Dock"), System.Windows.Forms.DockStyle)
        Me.tabTemplates.Enabled = CType(resources.GetObject("tabTemplates.Enabled"), Boolean)
        Me.tabTemplates.Font = CType(resources.GetObject("tabTemplates.Font"), System.Drawing.Font)
        Me.tabTemplates.ImeMode = CType(resources.GetObject("tabTemplates.ImeMode"), System.Windows.Forms.ImeMode)
        Me.tabTemplates.ItemSize = CType(resources.GetObject("tabTemplates.ItemSize"), System.Drawing.Size)
        Me.tabTemplates.Location = CType(resources.GetObject("tabTemplates.Location"), System.Drawing.Point)
        Me.tabTemplates.Name = "tabTemplates"
        Me.tabTemplates.Padding = CType(resources.GetObject("tabTemplates.Padding"), System.Drawing.Point)
        Me.tabTemplates.RightToLeft = CType(resources.GetObject("tabTemplates.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.tabTemplates.SelectedIndex = 0
        Me.tabTemplates.ShowToolTips = CType(resources.GetObject("tabTemplates.ShowToolTips"), Boolean)
        Me.tabTemplates.Size = CType(resources.GetObject("tabTemplates.Size"), System.Drawing.Size)
        Me.tabTemplates.TabIndex = CType(resources.GetObject("tabTemplates.TabIndex"), Integer)
        Me.tabTemplates.Text = resources.GetString("tabTemplates.Text")
        Me.tabTemplates.Visible = CType(resources.GetObject("tabTemplates.Visible"), Boolean)
        '
        'TabPage6
        '
        Me.TabPage6.AccessibleDescription = CType(resources.GetObject("TabPage6.AccessibleDescription"), String)
        Me.TabPage6.AccessibleName = CType(resources.GetObject("TabPage6.AccessibleName"), String)
        Me.TabPage6.Anchor = CType(resources.GetObject("TabPage6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage6.AutoScroll = CType(resources.GetObject("TabPage6.AutoScroll"), Boolean)
        Me.TabPage6.AutoScrollMargin = CType(resources.GetObject("TabPage6.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage6.AutoScrollMinSize = CType(resources.GetObject("TabPage6.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage6.BackgroundImage = CType(resources.GetObject("TabPage6.BackgroundImage"), System.Drawing.Image)
        Me.TabPage6.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDTTemplateFileName, Me.lblDTTemplateID, Me.Label17, Me.Label16, Me.Label15, Me.btnDTColourSchemeBrowse, Me.btnDTSelect, Me.lblDTTemplate, Me.Label13, Me.cboDTColourScheme, Me.Label11})
        Me.TabPage6.Dock = CType(resources.GetObject("TabPage6.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage6.Enabled = CType(resources.GetObject("TabPage6.Enabled"), Boolean)
        Me.TabPage6.Font = CType(resources.GetObject("TabPage6.Font"), System.Drawing.Font)
        Me.TabPage6.ImageIndex = CType(resources.GetObject("TabPage6.ImageIndex"), Integer)
        Me.TabPage6.ImeMode = CType(resources.GetObject("TabPage6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage6.Location = CType(resources.GetObject("TabPage6.Location"), System.Drawing.Point)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.RightToLeft = CType(resources.GetObject("TabPage6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage6.Size = CType(resources.GetObject("TabPage6.Size"), System.Drawing.Size)
        Me.TabPage6.TabIndex = CType(resources.GetObject("TabPage6.TabIndex"), Integer)
        Me.TabPage6.Text = resources.GetString("TabPage6.Text")
        Me.TabPage6.ToolTipText = resources.GetString("TabPage6.ToolTipText")
        Me.TabPage6.Visible = CType(resources.GetObject("TabPage6.Visible"), Boolean)
        '
        'lblDTTemplateFileName
        '
        Me.lblDTTemplateFileName.AccessibleDescription = CType(resources.GetObject("lblDTTemplateFileName.AccessibleDescription"), String)
        Me.lblDTTemplateFileName.AccessibleName = CType(resources.GetObject("lblDTTemplateFileName.AccessibleName"), String)
        Me.lblDTTemplateFileName.Anchor = CType(resources.GetObject("lblDTTemplateFileName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDTTemplateFileName.AutoSize = CType(resources.GetObject("lblDTTemplateFileName.AutoSize"), Boolean)
        Me.lblDTTemplateFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDTTemplateFileName.Dock = CType(resources.GetObject("lblDTTemplateFileName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDTTemplateFileName.Enabled = CType(resources.GetObject("lblDTTemplateFileName.Enabled"), Boolean)
        Me.lblDTTemplateFileName.Font = CType(resources.GetObject("lblDTTemplateFileName.Font"), System.Drawing.Font)
        Me.lblDTTemplateFileName.Image = CType(resources.GetObject("lblDTTemplateFileName.Image"), System.Drawing.Image)
        Me.lblDTTemplateFileName.ImageAlign = CType(resources.GetObject("lblDTTemplateFileName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplateFileName.ImageIndex = CType(resources.GetObject("lblDTTemplateFileName.ImageIndex"), Integer)
        Me.lblDTTemplateFileName.ImeMode = CType(resources.GetObject("lblDTTemplateFileName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDTTemplateFileName.Location = CType(resources.GetObject("lblDTTemplateFileName.Location"), System.Drawing.Point)
        Me.lblDTTemplateFileName.Name = "lblDTTemplateFileName"
        Me.lblDTTemplateFileName.RightToLeft = CType(resources.GetObject("lblDTTemplateFileName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDTTemplateFileName.Size = CType(resources.GetObject("lblDTTemplateFileName.Size"), System.Drawing.Size)
        Me.lblDTTemplateFileName.TabIndex = CType(resources.GetObject("lblDTTemplateFileName.TabIndex"), Integer)
        Me.lblDTTemplateFileName.Text = resources.GetString("lblDTTemplateFileName.Text")
        Me.lblDTTemplateFileName.TextAlign = CType(resources.GetObject("lblDTTemplateFileName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplateFileName.Visible = CType(resources.GetObject("lblDTTemplateFileName.Visible"), Boolean)
        '
        'lblDTTemplateID
        '
        Me.lblDTTemplateID.AccessibleDescription = CType(resources.GetObject("lblDTTemplateID.AccessibleDescription"), String)
        Me.lblDTTemplateID.AccessibleName = CType(resources.GetObject("lblDTTemplateID.AccessibleName"), String)
        Me.lblDTTemplateID.Anchor = CType(resources.GetObject("lblDTTemplateID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDTTemplateID.AutoSize = CType(resources.GetObject("lblDTTemplateID.AutoSize"), Boolean)
        Me.lblDTTemplateID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDTTemplateID.Dock = CType(resources.GetObject("lblDTTemplateID.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDTTemplateID.Enabled = CType(resources.GetObject("lblDTTemplateID.Enabled"), Boolean)
        Me.lblDTTemplateID.Font = CType(resources.GetObject("lblDTTemplateID.Font"), System.Drawing.Font)
        Me.lblDTTemplateID.Image = CType(resources.GetObject("lblDTTemplateID.Image"), System.Drawing.Image)
        Me.lblDTTemplateID.ImageAlign = CType(resources.GetObject("lblDTTemplateID.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplateID.ImageIndex = CType(resources.GetObject("lblDTTemplateID.ImageIndex"), Integer)
        Me.lblDTTemplateID.ImeMode = CType(resources.GetObject("lblDTTemplateID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDTTemplateID.Location = CType(resources.GetObject("lblDTTemplateID.Location"), System.Drawing.Point)
        Me.lblDTTemplateID.Name = "lblDTTemplateID"
        Me.lblDTTemplateID.RightToLeft = CType(resources.GetObject("lblDTTemplateID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDTTemplateID.Size = CType(resources.GetObject("lblDTTemplateID.Size"), System.Drawing.Size)
        Me.lblDTTemplateID.TabIndex = CType(resources.GetObject("lblDTTemplateID.TabIndex"), Integer)
        Me.lblDTTemplateID.Text = resources.GetString("lblDTTemplateID.Text")
        Me.lblDTTemplateID.TextAlign = CType(resources.GetObject("lblDTTemplateID.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplateID.Visible = CType(resources.GetObject("lblDTTemplateID.Visible"), Boolean)
        '
        'Label17
        '
        Me.Label17.AccessibleDescription = CType(resources.GetObject("Label17.AccessibleDescription"), String)
        Me.Label17.AccessibleName = CType(resources.GetObject("Label17.AccessibleName"), String)
        Me.Label17.Anchor = CType(resources.GetObject("Label17.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = CType(resources.GetObject("Label17.AutoSize"), Boolean)
        Me.Label17.Dock = CType(resources.GetObject("Label17.Dock"), System.Windows.Forms.DockStyle)
        Me.Label17.Enabled = CType(resources.GetObject("Label17.Enabled"), Boolean)
        Me.Label17.Font = CType(resources.GetObject("Label17.Font"), System.Drawing.Font)
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = CType(resources.GetObject("Label17.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label17.ImageIndex = CType(resources.GetObject("Label17.ImageIndex"), Integer)
        Me.Label17.ImeMode = CType(resources.GetObject("Label17.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label17.Location = CType(resources.GetObject("Label17.Location"), System.Drawing.Point)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = CType(resources.GetObject("Label17.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label17.Size = CType(resources.GetObject("Label17.Size"), System.Drawing.Size)
        Me.Label17.TabIndex = CType(resources.GetObject("Label17.TabIndex"), Integer)
        Me.Label17.Text = resources.GetString("Label17.Text")
        Me.Label17.TextAlign = CType(resources.GetObject("Label17.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label17.Visible = CType(resources.GetObject("Label17.Visible"), Boolean)
        '
        'Label16
        '
        Me.Label16.AccessibleDescription = CType(resources.GetObject("Label16.AccessibleDescription"), String)
        Me.Label16.AccessibleName = CType(resources.GetObject("Label16.AccessibleName"), String)
        Me.Label16.Anchor = CType(resources.GetObject("Label16.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = CType(resources.GetObject("Label16.AutoSize"), Boolean)
        Me.Label16.Dock = CType(resources.GetObject("Label16.Dock"), System.Windows.Forms.DockStyle)
        Me.Label16.Enabled = CType(resources.GetObject("Label16.Enabled"), Boolean)
        Me.Label16.Font = CType(resources.GetObject("Label16.Font"), System.Drawing.Font)
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.ImageAlign = CType(resources.GetObject("Label16.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label16.ImageIndex = CType(resources.GetObject("Label16.ImageIndex"), Integer)
        Me.Label16.ImeMode = CType(resources.GetObject("Label16.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label16.Location = CType(resources.GetObject("Label16.Location"), System.Drawing.Point)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = CType(resources.GetObject("Label16.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label16.Size = CType(resources.GetObject("Label16.Size"), System.Drawing.Size)
        Me.Label16.TabIndex = CType(resources.GetObject("Label16.TabIndex"), Integer)
        Me.Label16.Text = resources.GetString("Label16.Text")
        Me.Label16.TextAlign = CType(resources.GetObject("Label16.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label16.Visible = CType(resources.GetObject("Label16.Visible"), Boolean)
        '
        'Label15
        '
        Me.Label15.AccessibleDescription = CType(resources.GetObject("Label15.AccessibleDescription"), String)
        Me.Label15.AccessibleName = CType(resources.GetObject("Label15.AccessibleName"), String)
        Me.Label15.Anchor = CType(resources.GetObject("Label15.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = CType(resources.GetObject("Label15.AutoSize"), Boolean)
        Me.Label15.Dock = CType(resources.GetObject("Label15.Dock"), System.Windows.Forms.DockStyle)
        Me.Label15.Enabled = CType(resources.GetObject("Label15.Enabled"), Boolean)
        Me.Label15.Font = CType(resources.GetObject("Label15.Font"), System.Drawing.Font)
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = CType(resources.GetObject("Label15.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label15.ImageIndex = CType(resources.GetObject("Label15.ImageIndex"), Integer)
        Me.Label15.ImeMode = CType(resources.GetObject("Label15.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label15.Location = CType(resources.GetObject("Label15.Location"), System.Drawing.Point)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = CType(resources.GetObject("Label15.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label15.Size = CType(resources.GetObject("Label15.Size"), System.Drawing.Size)
        Me.Label15.TabIndex = CType(resources.GetObject("Label15.TabIndex"), Integer)
        Me.Label15.Text = resources.GetString("Label15.Text")
        Me.Label15.TextAlign = CType(resources.GetObject("Label15.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label15.Visible = CType(resources.GetObject("Label15.Visible"), Boolean)
        '
        'btnDTColourSchemeBrowse
        '
        Me.btnDTColourSchemeBrowse.AccessibleDescription = CType(resources.GetObject("btnDTColourSchemeBrowse.AccessibleDescription"), String)
        Me.btnDTColourSchemeBrowse.AccessibleName = CType(resources.GetObject("btnDTColourSchemeBrowse.AccessibleName"), String)
        Me.btnDTColourSchemeBrowse.Anchor = CType(resources.GetObject("btnDTColourSchemeBrowse.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDTColourSchemeBrowse.BackgroundImage = CType(resources.GetObject("btnDTColourSchemeBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnDTColourSchemeBrowse.Dock = CType(resources.GetObject("btnDTColourSchemeBrowse.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDTColourSchemeBrowse.Enabled = CType(resources.GetObject("btnDTColourSchemeBrowse.Enabled"), Boolean)
        Me.btnDTColourSchemeBrowse.FlatStyle = CType(resources.GetObject("btnDTColourSchemeBrowse.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDTColourSchemeBrowse.Font = CType(resources.GetObject("btnDTColourSchemeBrowse.Font"), System.Drawing.Font)
        Me.btnDTColourSchemeBrowse.Image = CType(resources.GetObject("btnDTColourSchemeBrowse.Image"), System.Drawing.Image)
        Me.btnDTColourSchemeBrowse.ImageAlign = CType(resources.GetObject("btnDTColourSchemeBrowse.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDTColourSchemeBrowse.ImageIndex = CType(resources.GetObject("btnDTColourSchemeBrowse.ImageIndex"), Integer)
        Me.btnDTColourSchemeBrowse.ImeMode = CType(resources.GetObject("btnDTColourSchemeBrowse.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDTColourSchemeBrowse.Location = CType(resources.GetObject("btnDTColourSchemeBrowse.Location"), System.Drawing.Point)
        Me.btnDTColourSchemeBrowse.Name = "btnDTColourSchemeBrowse"
        Me.btnDTColourSchemeBrowse.RightToLeft = CType(resources.GetObject("btnDTColourSchemeBrowse.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDTColourSchemeBrowse.Size = CType(resources.GetObject("btnDTColourSchemeBrowse.Size"), System.Drawing.Size)
        Me.btnDTColourSchemeBrowse.TabIndex = CType(resources.GetObject("btnDTColourSchemeBrowse.TabIndex"), Integer)
        Me.btnDTColourSchemeBrowse.Text = resources.GetString("btnDTColourSchemeBrowse.Text")
        Me.btnDTColourSchemeBrowse.TextAlign = CType(resources.GetObject("btnDTColourSchemeBrowse.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDTColourSchemeBrowse.Visible = CType(resources.GetObject("btnDTColourSchemeBrowse.Visible"), Boolean)
        '
        'btnDTSelect
        '
        Me.btnDTSelect.AccessibleDescription = CType(resources.GetObject("btnDTSelect.AccessibleDescription"), String)
        Me.btnDTSelect.AccessibleName = CType(resources.GetObject("btnDTSelect.AccessibleName"), String)
        Me.btnDTSelect.Anchor = CType(resources.GetObject("btnDTSelect.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDTSelect.BackgroundImage = CType(resources.GetObject("btnDTSelect.BackgroundImage"), System.Drawing.Image)
        Me.btnDTSelect.Dock = CType(resources.GetObject("btnDTSelect.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDTSelect.Enabled = CType(resources.GetObject("btnDTSelect.Enabled"), Boolean)
        Me.btnDTSelect.FlatStyle = CType(resources.GetObject("btnDTSelect.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDTSelect.Font = CType(resources.GetObject("btnDTSelect.Font"), System.Drawing.Font)
        Me.btnDTSelect.Image = CType(resources.GetObject("btnDTSelect.Image"), System.Drawing.Image)
        Me.btnDTSelect.ImageAlign = CType(resources.GetObject("btnDTSelect.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDTSelect.ImageIndex = CType(resources.GetObject("btnDTSelect.ImageIndex"), Integer)
        Me.btnDTSelect.ImeMode = CType(resources.GetObject("btnDTSelect.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDTSelect.Location = CType(resources.GetObject("btnDTSelect.Location"), System.Drawing.Point)
        Me.btnDTSelect.Name = "btnDTSelect"
        Me.btnDTSelect.RightToLeft = CType(resources.GetObject("btnDTSelect.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDTSelect.Size = CType(resources.GetObject("btnDTSelect.Size"), System.Drawing.Size)
        Me.btnDTSelect.TabIndex = CType(resources.GetObject("btnDTSelect.TabIndex"), Integer)
        Me.btnDTSelect.Text = resources.GetString("btnDTSelect.Text")
        Me.btnDTSelect.TextAlign = CType(resources.GetObject("btnDTSelect.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDTSelect.Visible = CType(resources.GetObject("btnDTSelect.Visible"), Boolean)
        '
        'lblDTTemplate
        '
        Me.lblDTTemplate.AccessibleDescription = CType(resources.GetObject("lblDTTemplate.AccessibleDescription"), String)
        Me.lblDTTemplate.AccessibleName = CType(resources.GetObject("lblDTTemplate.AccessibleName"), String)
        Me.lblDTTemplate.Anchor = CType(resources.GetObject("lblDTTemplate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDTTemplate.AutoSize = CType(resources.GetObject("lblDTTemplate.AutoSize"), Boolean)
        Me.lblDTTemplate.Dock = CType(resources.GetObject("lblDTTemplate.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDTTemplate.Enabled = CType(resources.GetObject("lblDTTemplate.Enabled"), Boolean)
        Me.lblDTTemplate.Font = CType(resources.GetObject("lblDTTemplate.Font"), System.Drawing.Font)
        Me.lblDTTemplate.Image = CType(resources.GetObject("lblDTTemplate.Image"), System.Drawing.Image)
        Me.lblDTTemplate.ImageAlign = CType(resources.GetObject("lblDTTemplate.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplate.ImageIndex = CType(resources.GetObject("lblDTTemplate.ImageIndex"), Integer)
        Me.lblDTTemplate.ImeMode = CType(resources.GetObject("lblDTTemplate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDTTemplate.Location = CType(resources.GetObject("lblDTTemplate.Location"), System.Drawing.Point)
        Me.lblDTTemplate.Name = "lblDTTemplate"
        Me.lblDTTemplate.RightToLeft = CType(resources.GetObject("lblDTTemplate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDTTemplate.Size = CType(resources.GetObject("lblDTTemplate.Size"), System.Drawing.Size)
        Me.lblDTTemplate.TabIndex = CType(resources.GetObject("lblDTTemplate.TabIndex"), Integer)
        Me.lblDTTemplate.Text = resources.GetString("lblDTTemplate.Text")
        Me.lblDTTemplate.TextAlign = CType(resources.GetObject("lblDTTemplate.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDTTemplate.Visible = CType(resources.GetObject("lblDTTemplate.Visible"), Boolean)
        '
        'Label13
        '
        Me.Label13.AccessibleDescription = CType(resources.GetObject("Label13.AccessibleDescription"), String)
        Me.Label13.AccessibleName = CType(resources.GetObject("Label13.AccessibleName"), String)
        Me.Label13.Anchor = CType(resources.GetObject("Label13.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = CType(resources.GetObject("Label13.AutoSize"), Boolean)
        Me.Label13.Dock = CType(resources.GetObject("Label13.Dock"), System.Windows.Forms.DockStyle)
        Me.Label13.Enabled = CType(resources.GetObject("Label13.Enabled"), Boolean)
        Me.Label13.Font = CType(resources.GetObject("Label13.Font"), System.Drawing.Font)
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = CType(resources.GetObject("Label13.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label13.ImageIndex = CType(resources.GetObject("Label13.ImageIndex"), Integer)
        Me.Label13.ImeMode = CType(resources.GetObject("Label13.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label13.Location = CType(resources.GetObject("Label13.Location"), System.Drawing.Point)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = CType(resources.GetObject("Label13.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label13.Size = CType(resources.GetObject("Label13.Size"), System.Drawing.Size)
        Me.Label13.TabIndex = CType(resources.GetObject("Label13.TabIndex"), Integer)
        Me.Label13.Text = resources.GetString("Label13.Text")
        Me.Label13.TextAlign = CType(resources.GetObject("Label13.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label13.Visible = CType(resources.GetObject("Label13.Visible"), Boolean)
        '
        'cboDTColourScheme
        '
        Me.cboDTColourScheme.AccessibleDescription = CType(resources.GetObject("cboDTColourScheme.AccessibleDescription"), String)
        Me.cboDTColourScheme.AccessibleName = CType(resources.GetObject("cboDTColourScheme.AccessibleName"), String)
        Me.cboDTColourScheme.Anchor = CType(resources.GetObject("cboDTColourScheme.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboDTColourScheme.BackgroundImage = CType(resources.GetObject("cboDTColourScheme.BackgroundImage"), System.Drawing.Image)
        Me.cboDTColourScheme.Dock = CType(resources.GetObject("cboDTColourScheme.Dock"), System.Windows.Forms.DockStyle)
        Me.cboDTColourScheme.Enabled = CType(resources.GetObject("cboDTColourScheme.Enabled"), Boolean)
        Me.cboDTColourScheme.Font = CType(resources.GetObject("cboDTColourScheme.Font"), System.Drawing.Font)
        Me.cboDTColourScheme.ImeMode = CType(resources.GetObject("cboDTColourScheme.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboDTColourScheme.IntegralHeight = CType(resources.GetObject("cboDTColourScheme.IntegralHeight"), Boolean)
        Me.cboDTColourScheme.ItemHeight = CType(resources.GetObject("cboDTColourScheme.ItemHeight"), Integer)
        Me.cboDTColourScheme.Location = CType(resources.GetObject("cboDTColourScheme.Location"), System.Drawing.Point)
        Me.cboDTColourScheme.MaxDropDownItems = CType(resources.GetObject("cboDTColourScheme.MaxDropDownItems"), Integer)
        Me.cboDTColourScheme.MaxLength = CType(resources.GetObject("cboDTColourScheme.MaxLength"), Integer)
        Me.cboDTColourScheme.Name = "cboDTColourScheme"
        Me.cboDTColourScheme.RightToLeft = CType(resources.GetObject("cboDTColourScheme.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboDTColourScheme.Size = CType(resources.GetObject("cboDTColourScheme.Size"), System.Drawing.Size)
        Me.cboDTColourScheme.Sorted = True
        Me.cboDTColourScheme.TabIndex = CType(resources.GetObject("cboDTColourScheme.TabIndex"), Integer)
        Me.cboDTColourScheme.Text = resources.GetString("cboDTColourScheme.Text")
        Me.cboDTColourScheme.Visible = CType(resources.GetObject("cboDTColourScheme.Visible"), Boolean)
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = CType(resources.GetObject("Label11.AccessibleDescription"), String)
        Me.Label11.AccessibleName = CType(resources.GetObject("Label11.AccessibleName"), String)
        Me.Label11.Anchor = CType(resources.GetObject("Label11.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = CType(resources.GetObject("Label11.AutoSize"), Boolean)
        Me.Label11.Dock = CType(resources.GetObject("Label11.Dock"), System.Windows.Forms.DockStyle)
        Me.Label11.Enabled = CType(resources.GetObject("Label11.Enabled"), Boolean)
        Me.Label11.Font = CType(resources.GetObject("Label11.Font"), System.Drawing.Font)
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = CType(resources.GetObject("Label11.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label11.ImageIndex = CType(resources.GetObject("Label11.ImageIndex"), Integer)
        Me.Label11.ImeMode = CType(resources.GetObject("Label11.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label11.Location = CType(resources.GetObject("Label11.Location"), System.Drawing.Point)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = CType(resources.GetObject("Label11.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label11.Size = CType(resources.GetObject("Label11.Size"), System.Drawing.Size)
        Me.Label11.TabIndex = CType(resources.GetObject("Label11.TabIndex"), Integer)
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = CType(resources.GetObject("Label11.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label11.Visible = CType(resources.GetObject("Label11.Visible"), Boolean)
        '
        'TabPage7
        '
        Me.TabPage7.AccessibleDescription = CType(resources.GetObject("TabPage7.AccessibleDescription"), String)
        Me.TabPage7.AccessibleName = CType(resources.GetObject("TabPage7.AccessibleName"), String)
        Me.TabPage7.Anchor = CType(resources.GetObject("TabPage7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage7.AutoScroll = CType(resources.GetObject("TabPage7.AutoScroll"), Boolean)
        Me.TabPage7.AutoScrollMargin = CType(resources.GetObject("TabPage7.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage7.AutoScrollMinSize = CType(resources.GetObject("TabPage7.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage7.BackgroundImage = CType(resources.GetObject("TabPage7.BackgroundImage"), System.Drawing.Image)
        Me.TabPage7.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label19, Me.btnDVSave, Me.Label23, Me.Label22, Me.Label21, Me.cboDVValue, Me.cboDVField, Me.Label18, Me.btnDVSelect, Me.lblDVTemplate, Me.Label20})
        Me.TabPage7.Dock = CType(resources.GetObject("TabPage7.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage7.Enabled = CType(resources.GetObject("TabPage7.Enabled"), Boolean)
        Me.TabPage7.Font = CType(resources.GetObject("TabPage7.Font"), System.Drawing.Font)
        Me.TabPage7.ImageIndex = CType(resources.GetObject("TabPage7.ImageIndex"), Integer)
        Me.TabPage7.ImeMode = CType(resources.GetObject("TabPage7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage7.Location = CType(resources.GetObject("TabPage7.Location"), System.Drawing.Point)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.RightToLeft = CType(resources.GetObject("TabPage7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage7.Size = CType(resources.GetObject("TabPage7.Size"), System.Drawing.Size)
        Me.TabPage7.TabIndex = CType(resources.GetObject("TabPage7.TabIndex"), Integer)
        Me.TabPage7.Text = resources.GetString("TabPage7.Text")
        Me.TabPage7.ToolTipText = resources.GetString("TabPage7.ToolTipText")
        Me.TabPage7.Visible = CType(resources.GetObject("TabPage7.Visible"), Boolean)
        '
        'Label19
        '
        Me.Label19.AccessibleDescription = CType(resources.GetObject("Label19.AccessibleDescription"), String)
        Me.Label19.AccessibleName = CType(resources.GetObject("Label19.AccessibleName"), String)
        Me.Label19.Anchor = CType(resources.GetObject("Label19.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = CType(resources.GetObject("Label19.AutoSize"), Boolean)
        Me.Label19.Dock = CType(resources.GetObject("Label19.Dock"), System.Windows.Forms.DockStyle)
        Me.Label19.Enabled = CType(resources.GetObject("Label19.Enabled"), Boolean)
        Me.Label19.Font = CType(resources.GetObject("Label19.Font"), System.Drawing.Font)
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = CType(resources.GetObject("Label19.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label19.ImageIndex = CType(resources.GetObject("Label19.ImageIndex"), Integer)
        Me.Label19.ImeMode = CType(resources.GetObject("Label19.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label19.Location = CType(resources.GetObject("Label19.Location"), System.Drawing.Point)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = CType(resources.GetObject("Label19.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label19.Size = CType(resources.GetObject("Label19.Size"), System.Drawing.Size)
        Me.Label19.TabIndex = CType(resources.GetObject("Label19.TabIndex"), Integer)
        Me.Label19.Text = resources.GetString("Label19.Text")
        Me.Label19.TextAlign = CType(resources.GetObject("Label19.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label19.Visible = CType(resources.GetObject("Label19.Visible"), Boolean)
        '
        'btnDVSave
        '
        Me.btnDVSave.AccessibleDescription = CType(resources.GetObject("btnDVSave.AccessibleDescription"), String)
        Me.btnDVSave.AccessibleName = CType(resources.GetObject("btnDVSave.AccessibleName"), String)
        Me.btnDVSave.Anchor = CType(resources.GetObject("btnDVSave.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDVSave.BackgroundImage = CType(resources.GetObject("btnDVSave.BackgroundImage"), System.Drawing.Image)
        Me.btnDVSave.Dock = CType(resources.GetObject("btnDVSave.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDVSave.Enabled = CType(resources.GetObject("btnDVSave.Enabled"), Boolean)
        Me.btnDVSave.FlatStyle = CType(resources.GetObject("btnDVSave.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDVSave.Font = CType(resources.GetObject("btnDVSave.Font"), System.Drawing.Font)
        Me.btnDVSave.Image = CType(resources.GetObject("btnDVSave.Image"), System.Drawing.Image)
        Me.btnDVSave.ImageAlign = CType(resources.GetObject("btnDVSave.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDVSave.ImageIndex = CType(resources.GetObject("btnDVSave.ImageIndex"), Integer)
        Me.btnDVSave.ImeMode = CType(resources.GetObject("btnDVSave.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDVSave.Location = CType(resources.GetObject("btnDVSave.Location"), System.Drawing.Point)
        Me.btnDVSave.Name = "btnDVSave"
        Me.btnDVSave.RightToLeft = CType(resources.GetObject("btnDVSave.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDVSave.Size = CType(resources.GetObject("btnDVSave.Size"), System.Drawing.Size)
        Me.btnDVSave.TabIndex = CType(resources.GetObject("btnDVSave.TabIndex"), Integer)
        Me.btnDVSave.Text = resources.GetString("btnDVSave.Text")
        Me.btnDVSave.TextAlign = CType(resources.GetObject("btnDVSave.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDVSave.Visible = CType(resources.GetObject("btnDVSave.Visible"), Boolean)
        '
        'Label23
        '
        Me.Label23.AccessibleDescription = CType(resources.GetObject("Label23.AccessibleDescription"), String)
        Me.Label23.AccessibleName = CType(resources.GetObject("Label23.AccessibleName"), String)
        Me.Label23.Anchor = CType(resources.GetObject("Label23.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = CType(resources.GetObject("Label23.AutoSize"), Boolean)
        Me.Label23.Dock = CType(resources.GetObject("Label23.Dock"), System.Windows.Forms.DockStyle)
        Me.Label23.Enabled = CType(resources.GetObject("Label23.Enabled"), Boolean)
        Me.Label23.Font = CType(resources.GetObject("Label23.Font"), System.Drawing.Font)
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = CType(resources.GetObject("Label23.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label23.ImageIndex = CType(resources.GetObject("Label23.ImageIndex"), Integer)
        Me.Label23.ImeMode = CType(resources.GetObject("Label23.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label23.Location = CType(resources.GetObject("Label23.Location"), System.Drawing.Point)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = CType(resources.GetObject("Label23.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label23.Size = CType(resources.GetObject("Label23.Size"), System.Drawing.Size)
        Me.Label23.TabIndex = CType(resources.GetObject("Label23.TabIndex"), Integer)
        Me.Label23.Text = resources.GetString("Label23.Text")
        Me.Label23.TextAlign = CType(resources.GetObject("Label23.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label23.Visible = CType(resources.GetObject("Label23.Visible"), Boolean)
        '
        'Label22
        '
        Me.Label22.AccessibleDescription = CType(resources.GetObject("Label22.AccessibleDescription"), String)
        Me.Label22.AccessibleName = CType(resources.GetObject("Label22.AccessibleName"), String)
        Me.Label22.Anchor = CType(resources.GetObject("Label22.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = CType(resources.GetObject("Label22.AutoSize"), Boolean)
        Me.Label22.Dock = CType(resources.GetObject("Label22.Dock"), System.Windows.Forms.DockStyle)
        Me.Label22.Enabled = CType(resources.GetObject("Label22.Enabled"), Boolean)
        Me.Label22.Font = CType(resources.GetObject("Label22.Font"), System.Drawing.Font)
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = CType(resources.GetObject("Label22.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label22.ImageIndex = CType(resources.GetObject("Label22.ImageIndex"), Integer)
        Me.Label22.ImeMode = CType(resources.GetObject("Label22.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label22.Location = CType(resources.GetObject("Label22.Location"), System.Drawing.Point)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = CType(resources.GetObject("Label22.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label22.Size = CType(resources.GetObject("Label22.Size"), System.Drawing.Size)
        Me.Label22.TabIndex = CType(resources.GetObject("Label22.TabIndex"), Integer)
        Me.Label22.Text = resources.GetString("Label22.Text")
        Me.Label22.TextAlign = CType(resources.GetObject("Label22.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label22.Visible = CType(resources.GetObject("Label22.Visible"), Boolean)
        '
        'Label21
        '
        Me.Label21.AccessibleDescription = CType(resources.GetObject("Label21.AccessibleDescription"), String)
        Me.Label21.AccessibleName = CType(resources.GetObject("Label21.AccessibleName"), String)
        Me.Label21.Anchor = CType(resources.GetObject("Label21.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = CType(resources.GetObject("Label21.AutoSize"), Boolean)
        Me.Label21.Dock = CType(resources.GetObject("Label21.Dock"), System.Windows.Forms.DockStyle)
        Me.Label21.Enabled = CType(resources.GetObject("Label21.Enabled"), Boolean)
        Me.Label21.Font = CType(resources.GetObject("Label21.Font"), System.Drawing.Font)
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.ImageAlign = CType(resources.GetObject("Label21.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label21.ImageIndex = CType(resources.GetObject("Label21.ImageIndex"), Integer)
        Me.Label21.ImeMode = CType(resources.GetObject("Label21.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label21.Location = CType(resources.GetObject("Label21.Location"), System.Drawing.Point)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = CType(resources.GetObject("Label21.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label21.Size = CType(resources.GetObject("Label21.Size"), System.Drawing.Size)
        Me.Label21.TabIndex = CType(resources.GetObject("Label21.TabIndex"), Integer)
        Me.Label21.Text = resources.GetString("Label21.Text")
        Me.Label21.TextAlign = CType(resources.GetObject("Label21.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label21.Visible = CType(resources.GetObject("Label21.Visible"), Boolean)
        '
        'cboDVValue
        '
        Me.cboDVValue.AccessibleDescription = CType(resources.GetObject("cboDVValue.AccessibleDescription"), String)
        Me.cboDVValue.AccessibleName = CType(resources.GetObject("cboDVValue.AccessibleName"), String)
        Me.cboDVValue.Anchor = CType(resources.GetObject("cboDVValue.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboDVValue.BackgroundImage = CType(resources.GetObject("cboDVValue.BackgroundImage"), System.Drawing.Image)
        Me.cboDVValue.Dock = CType(resources.GetObject("cboDVValue.Dock"), System.Windows.Forms.DockStyle)
        Me.cboDVValue.Enabled = CType(resources.GetObject("cboDVValue.Enabled"), Boolean)
        Me.cboDVValue.Font = CType(resources.GetObject("cboDVValue.Font"), System.Drawing.Font)
        Me.cboDVValue.ImeMode = CType(resources.GetObject("cboDVValue.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboDVValue.IntegralHeight = CType(resources.GetObject("cboDVValue.IntegralHeight"), Boolean)
        Me.cboDVValue.ItemHeight = CType(resources.GetObject("cboDVValue.ItemHeight"), Integer)
        Me.cboDVValue.Location = CType(resources.GetObject("cboDVValue.Location"), System.Drawing.Point)
        Me.cboDVValue.MaxDropDownItems = CType(resources.GetObject("cboDVValue.MaxDropDownItems"), Integer)
        Me.cboDVValue.MaxLength = CType(resources.GetObject("cboDVValue.MaxLength"), Integer)
        Me.cboDVValue.Name = "cboDVValue"
        Me.cboDVValue.RightToLeft = CType(resources.GetObject("cboDVValue.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboDVValue.Size = CType(resources.GetObject("cboDVValue.Size"), System.Drawing.Size)
        Me.cboDVValue.TabIndex = CType(resources.GetObject("cboDVValue.TabIndex"), Integer)
        Me.cboDVValue.Text = resources.GetString("cboDVValue.Text")
        Me.cboDVValue.Visible = CType(resources.GetObject("cboDVValue.Visible"), Boolean)
        '
        'cboDVField
        '
        Me.cboDVField.AccessibleDescription = CType(resources.GetObject("cboDVField.AccessibleDescription"), String)
        Me.cboDVField.AccessibleName = CType(resources.GetObject("cboDVField.AccessibleName"), String)
        Me.cboDVField.Anchor = CType(resources.GetObject("cboDVField.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboDVField.BackgroundImage = CType(resources.GetObject("cboDVField.BackgroundImage"), System.Drawing.Image)
        Me.cboDVField.Dock = CType(resources.GetObject("cboDVField.Dock"), System.Windows.Forms.DockStyle)
        Me.cboDVField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDVField.Enabled = CType(resources.GetObject("cboDVField.Enabled"), Boolean)
        Me.cboDVField.Font = CType(resources.GetObject("cboDVField.Font"), System.Drawing.Font)
        Me.cboDVField.ImeMode = CType(resources.GetObject("cboDVField.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboDVField.IntegralHeight = CType(resources.GetObject("cboDVField.IntegralHeight"), Boolean)
        Me.cboDVField.ItemHeight = CType(resources.GetObject("cboDVField.ItemHeight"), Integer)
        Me.cboDVField.Location = CType(resources.GetObject("cboDVField.Location"), System.Drawing.Point)
        Me.cboDVField.MaxDropDownItems = CType(resources.GetObject("cboDVField.MaxDropDownItems"), Integer)
        Me.cboDVField.MaxLength = CType(resources.GetObject("cboDVField.MaxLength"), Integer)
        Me.cboDVField.Name = "cboDVField"
        Me.cboDVField.RightToLeft = CType(resources.GetObject("cboDVField.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboDVField.Size = CType(resources.GetObject("cboDVField.Size"), System.Drawing.Size)
        Me.cboDVField.TabIndex = CType(resources.GetObject("cboDVField.TabIndex"), Integer)
        Me.cboDVField.Text = resources.GetString("cboDVField.Text")
        Me.cboDVField.Visible = CType(resources.GetObject("cboDVField.Visible"), Boolean)
        '
        'Label18
        '
        Me.Label18.AccessibleDescription = CType(resources.GetObject("Label18.AccessibleDescription"), String)
        Me.Label18.AccessibleName = CType(resources.GetObject("Label18.AccessibleName"), String)
        Me.Label18.Anchor = CType(resources.GetObject("Label18.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = CType(resources.GetObject("Label18.AutoSize"), Boolean)
        Me.Label18.Dock = CType(resources.GetObject("Label18.Dock"), System.Windows.Forms.DockStyle)
        Me.Label18.Enabled = CType(resources.GetObject("Label18.Enabled"), Boolean)
        Me.Label18.Font = CType(resources.GetObject("Label18.Font"), System.Drawing.Font)
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImageAlign = CType(resources.GetObject("Label18.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label18.ImageIndex = CType(resources.GetObject("Label18.ImageIndex"), Integer)
        Me.Label18.ImeMode = CType(resources.GetObject("Label18.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label18.Location = CType(resources.GetObject("Label18.Location"), System.Drawing.Point)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = CType(resources.GetObject("Label18.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label18.Size = CType(resources.GetObject("Label18.Size"), System.Drawing.Size)
        Me.Label18.TabIndex = CType(resources.GetObject("Label18.TabIndex"), Integer)
        Me.Label18.Text = resources.GetString("Label18.Text")
        Me.Label18.TextAlign = CType(resources.GetObject("Label18.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label18.Visible = CType(resources.GetObject("Label18.Visible"), Boolean)
        '
        'btnDVSelect
        '
        Me.btnDVSelect.AccessibleDescription = CType(resources.GetObject("btnDVSelect.AccessibleDescription"), String)
        Me.btnDVSelect.AccessibleName = CType(resources.GetObject("btnDVSelect.AccessibleName"), String)
        Me.btnDVSelect.Anchor = CType(resources.GetObject("btnDVSelect.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDVSelect.BackgroundImage = CType(resources.GetObject("btnDVSelect.BackgroundImage"), System.Drawing.Image)
        Me.btnDVSelect.Dock = CType(resources.GetObject("btnDVSelect.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDVSelect.Enabled = CType(resources.GetObject("btnDVSelect.Enabled"), Boolean)
        Me.btnDVSelect.FlatStyle = CType(resources.GetObject("btnDVSelect.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDVSelect.Font = CType(resources.GetObject("btnDVSelect.Font"), System.Drawing.Font)
        Me.btnDVSelect.Image = CType(resources.GetObject("btnDVSelect.Image"), System.Drawing.Image)
        Me.btnDVSelect.ImageAlign = CType(resources.GetObject("btnDVSelect.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDVSelect.ImageIndex = CType(resources.GetObject("btnDVSelect.ImageIndex"), Integer)
        Me.btnDVSelect.ImeMode = CType(resources.GetObject("btnDVSelect.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDVSelect.Location = CType(resources.GetObject("btnDVSelect.Location"), System.Drawing.Point)
        Me.btnDVSelect.Name = "btnDVSelect"
        Me.btnDVSelect.RightToLeft = CType(resources.GetObject("btnDVSelect.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDVSelect.Size = CType(resources.GetObject("btnDVSelect.Size"), System.Drawing.Size)
        Me.btnDVSelect.TabIndex = CType(resources.GetObject("btnDVSelect.TabIndex"), Integer)
        Me.btnDVSelect.Text = resources.GetString("btnDVSelect.Text")
        Me.btnDVSelect.TextAlign = CType(resources.GetObject("btnDVSelect.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDVSelect.Visible = CType(resources.GetObject("btnDVSelect.Visible"), Boolean)
        '
        'lblDVTemplate
        '
        Me.lblDVTemplate.AccessibleDescription = CType(resources.GetObject("lblDVTemplate.AccessibleDescription"), String)
        Me.lblDVTemplate.AccessibleName = CType(resources.GetObject("lblDVTemplate.AccessibleName"), String)
        Me.lblDVTemplate.Anchor = CType(resources.GetObject("lblDVTemplate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDVTemplate.AutoSize = CType(resources.GetObject("lblDVTemplate.AutoSize"), Boolean)
        Me.lblDVTemplate.Dock = CType(resources.GetObject("lblDVTemplate.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDVTemplate.Enabled = CType(resources.GetObject("lblDVTemplate.Enabled"), Boolean)
        Me.lblDVTemplate.Font = CType(resources.GetObject("lblDVTemplate.Font"), System.Drawing.Font)
        Me.lblDVTemplate.Image = CType(resources.GetObject("lblDVTemplate.Image"), System.Drawing.Image)
        Me.lblDVTemplate.ImageAlign = CType(resources.GetObject("lblDVTemplate.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDVTemplate.ImageIndex = CType(resources.GetObject("lblDVTemplate.ImageIndex"), Integer)
        Me.lblDVTemplate.ImeMode = CType(resources.GetObject("lblDVTemplate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDVTemplate.Location = CType(resources.GetObject("lblDVTemplate.Location"), System.Drawing.Point)
        Me.lblDVTemplate.Name = "lblDVTemplate"
        Me.lblDVTemplate.RightToLeft = CType(resources.GetObject("lblDVTemplate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDVTemplate.Size = CType(resources.GetObject("lblDVTemplate.Size"), System.Drawing.Size)
        Me.lblDVTemplate.TabIndex = CType(resources.GetObject("lblDVTemplate.TabIndex"), Integer)
        Me.lblDVTemplate.Text = resources.GetString("lblDVTemplate.Text")
        Me.lblDVTemplate.TextAlign = CType(resources.GetObject("lblDVTemplate.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDVTemplate.Visible = CType(resources.GetObject("lblDVTemplate.Visible"), Boolean)
        '
        'Label20
        '
        Me.Label20.AccessibleDescription = CType(resources.GetObject("Label20.AccessibleDescription"), String)
        Me.Label20.AccessibleName = CType(resources.GetObject("Label20.AccessibleName"), String)
        Me.Label20.Anchor = CType(resources.GetObject("Label20.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = CType(resources.GetObject("Label20.AutoSize"), Boolean)
        Me.Label20.Dock = CType(resources.GetObject("Label20.Dock"), System.Windows.Forms.DockStyle)
        Me.Label20.Enabled = CType(resources.GetObject("Label20.Enabled"), Boolean)
        Me.Label20.Font = CType(resources.GetObject("Label20.Font"), System.Drawing.Font)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.ImageAlign = CType(resources.GetObject("Label20.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label20.ImageIndex = CType(resources.GetObject("Label20.ImageIndex"), Integer)
        Me.Label20.ImeMode = CType(resources.GetObject("Label20.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label20.Location = CType(resources.GetObject("Label20.Location"), System.Drawing.Point)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = CType(resources.GetObject("Label20.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label20.Size = CType(resources.GetObject("Label20.Size"), System.Drawing.Size)
        Me.Label20.TabIndex = CType(resources.GetObject("Label20.TabIndex"), Integer)
        Me.Label20.Text = resources.GetString("Label20.Text")
        Me.Label20.TextAlign = CType(resources.GetObject("Label20.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label20.Visible = CType(resources.GetObject("Label20.Visible"), Boolean)
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
        'options
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHelp, Me.TabControl1, Me.btnApply, Me.btnCancel, Me.btnOK})
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
        Me.Name = "options"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.grpNoDictionaryFound.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.tabTemplates.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("Ideaspad.Ideaspad", _
        System.Reflection.Assembly.GetExecutingAssembly()) 
    Private StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic")) 

    Dim lbooDocFontChanged As Boolean = False
    Dim lbooTreeFontChanged As Boolean = False
    Dim lbooSeqNumChanged As Boolean = False
    Dim lbooStartupChanged As Boolean = False
    Dim lbooBranchIncrChanged As Boolean = False 
    Dim lTreeFontExtra As New OtherFontSettings() 
    Dim lDocFontExtra As New OtherFontSettings() 
    Dim mstrIndexArray() As TreeTopics 
    Dim lstrlblDVTemplateText As String 

    Private Sub options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddDebugComment("Options.options_Load - Start") 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnApply.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnDocChange.FlatStyle = FlatStyle.System
            btnTreeChange.FlatStyle = FlatStyle.System
            btnReset.FlatStyle = FlatStyle.System
            btnAddQuickLaunch.FlatStyle = FlatStyle.System
            btnDTSelect.FlatStyle = FlatStyle.System
            btnDTColourSchemeBrowse.FlatStyle = FlatStyle.System
            btnDVSelect.FlatStyle = FlatStyle.System
            btnDVSave.FlatStyle = FlatStyle.System

            
            rdoSortAlpha.FlatStyle = FlatStyle.System
            rdSortSeqNum.FlatStyle = FlatStyle.System
            rdoTempOrNormNorm.FlatStyle = FlatStyle.System
            rdoTempOrNormTemp.FlatStyle = FlatStyle.System
            rdoStartupSelPage.FlatStyle = FlatStyle.System
            rdoStartupSelTopic.FlatStyle = FlatStyle.System
            
        End If 
        'GroupBox1.FlatStyle = FlatStyle.System 'Commented for transparency 
        'GroupBox2.FlatStyle = FlatStyle.System 'Commented for transparency 
        'GroupBox3.FlatStyle = FlatStyle.System 'Commented for transparency 
        'rdoSortAlpha.FlatStyle = FlatStyle.System
        'rdSortSeqNum.FlatStyle = FlatStyle.System
        ''grpNoDictionaryFound.FlatStyle = FlatStyle.System 'Commented for transparency 
        'rdoTempOrNormNorm.FlatStyle = FlatStyle.System
        'rdoTempOrNormTemp.FlatStyle = FlatStyle.System
        'rdoStartupSelPage.FlatStyle = FlatStyle.System
        'rdoStartupSelTopic.FlatStyle = FlatStyle.System
        

        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 
            AddUserIconControls() 
        End If 

        SetBackcolors() 

        tabTemplates.TabPages.Remove(TabPage7) 

        lstrlblDVTemplateText = lblDVTemplate.Text 'to cater for german text

        Dim SpellURL As String = LangText.GetString("Options_SpellingURL") 
        lnkURL.Links.Clear() 
        lnkURL.Text = SpellURL
        lnkURL.Links.Add(0, SpellURL.Length, SpellURL) 

        PopulateTree(TreeView1, mstrIndexArray, Me, , gstrSortOrder) 
        LoadValues()

        'cboDTColourScheme.Items.Add("") 
        cboDTColourScheme.Items.Add(" ") 'Added a space so that Slick.css can be default and turned off later on 
        cboDTColourScheme.DropDownStyle = ComboBoxStyle.DropDownList 

        
        'remeber you will need the german text for these if you put them back in!
        txtIncrementAmount.Visible = False
        lblIncrementAmount.Visible = False
        Label24.Visible = False
        

        AddDebugComment("Options.options_Load - End") 

    End Sub
    Private Sub LoadValues()

        'transfered to AppSettings

        Dim AppSettings As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings) 

        SetDocItems(AppSettings)
        SetTreeItems(AppSettings)
        'AppSettings.GetValue("Default Information Base File", "")

        If AppSettings.GetValue("Tree Sort Order", "ALPHA") = "ALPHA" Then
            rdoSortAlpha.Checked = True
        Else
            rdSortSeqNum.Checked = True
        End If

        txtIncrementAmount.Text = CInt(AppSettings.GetValue("Move Branch IncrDecr", "10")) 

        rdoStartupSelPage.Checked = CBool(AppSettings.GetValue("Show Startup Page", "TRUE"))

        rdoStartupSelTopic.Checked = Not rdoStartupSelPage.Checked 

        
        Dim lstrStartupTopic As String = AppSettings.GetValue("Startup Topic", "")
        If lstrStartupTopic <> "" Then
            SelectNodeByTag(lstrStartupTopic, TreeView1)
            rdoStartupSelTopic.Checked = True ' False 
        Else
            rdoStartupSelPage.Checked = True ' False 
        End If
        

        GetDictionary()

        If CBool(AppSettings.GetValue("Use Template By Default", "FALSE")) = False Then 
            rdoTempOrNormNorm.Checked = True
            rdoTempOrNormTemp.Checked = False
            tabTemplates.Enabled = False 
        Else
            rdoTempOrNormNorm.Checked = False
            rdoTempOrNormTemp.Checked = True
            tabTemplates.Enabled = True 
        End If



        Dim lstrCSSArray() As String
        Dim lintArrInc As Integer
        Dim lstrCSSResources As New IPTemplates._main()
        lstrCSSResources.CSSSheets(lstrCSSArray)

        For lintArrInc = 0 To lstrCSSArray.GetUpperBound(0)
            If lstrCSSArray(lintArrInc) <> "" Then
                lstrCSSArray(lintArrInc) = lstrCSSArray(lintArrInc) & " (System)"
            End If
        Next

        'Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
        '    System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")
        'Dim files() As FileInfo = source.GetFiles
        'Dim pfile As FileInfo
        'For Each pfile In files
        '    If RightGet(pfile.ToString, 4).ToUpper = ".CSS" Then
        '        'cboDTColourScheme.Items.Add(pfile.ToString)
        '        ReDim Preserve lstrCSSArray(lstrCSSArray.GetUpperBound(0) + 1)
        '        lstrCSSArray(lstrCSSArray.GetUpperBound(0)) = pfile.ToString
        '    End If
        'Next pfile

        'For lintArrInc = 0 To lstrCSSArray.GetUpperBound(0)
        '    If lstrCSSArray(lintArrInc) <> "" Then
        '        cboDTColourScheme.Items.Add(lstrCSSArray(lintArrInc))
        '    End If
        'Next lintArrInc

        LoadUserCSSListbox(lstrCSSArray, cboDTColourScheme)

        lblDTTemplate.Text = AppSettings.GetValue("Default Template Name", "None Specified")
        lblDTTemplateFileName.Text = AppSettings.GetValue("Default Template File Name", "")
        lblDTTemplateID.Text = AppSettings.GetValue("Default Template ID", "")

        Dim lstrSchemeName As String = AppSettings.GetValue("Template Scheme", "")

        If lstrSchemeName <> "" Then
            If InStrGet(lstrSchemeName, "SYSTEM:") > 0 Then
                lstrSchemeName = Microsoft.VisualBasic.Replace(lstrSchemeName, "SYSTEM:", "")
                lstrSchemeName = lstrSchemeName & " (System)"
            End If
        End If
        cboDTColourScheme.Text = lstrSchemeName

        
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 
            txtUserIconDir.Text = GetSettingsValue("UsrIconDir")
        End If
        

    End Sub
    Private Sub SetDocItems(ByVal pAppSettings As InitalXMLConfig)

        'transfered to pAppSettings

        lblDocFontName.Text = pAppSettings.GetValue("Document Font Name", "Microsoft Sans Serif")
        'lblDocFontSize.Text = GetSetting("Document Font Size", "8.25")
        lblDocFontSize.Text = pAppSettings.GetValue("Document Font Size", "8") 
        'lblDocFontColour.BackColor = System.Drawing.Color.FromName(pAppSettings.GetValue("Document Font Colour", "Black")) 'Window
        
        lblDocFontColour.BackColor = AppBasic.StringToColor(pAppSettings.GetValue("Document Font Colour", "Black")) 'Window

        
        Dim lDocSampleFontStyle As New FontStyle()
        With lDocFontExtra
            .Bold = CBool(pAppSettings.GetValue("Document Font Bold", "False"))
            .Underlined = CBool(pAppSettings.GetValue("Document Font Underlined", "False"))
            .Italic = CBool(pAppSettings.GetValue("Document Font Italic", "False"))
            .StrikeOut = CBool(pAppSettings.GetValue("Document Font Strikeout", "False"))
            If .Bold = True Then lDocSampleFontStyle = FontStyle.Bold
            If .Underlined = True Then lDocSampleFontStyle = lDocSampleFontStyle + FontStyle.Underline
            If .Italic = True Then lDocSampleFontStyle = lDocSampleFontStyle + FontStyle.Italic
            If .StrikeOut = True Then lDocSampleFontStyle = lDocSampleFontStyle + FontStyle.Strikeout
        End With
        

        With lblDocSample
            '.Font = New Font(lblDocFontName.Text, CSng(lblDocFontSize.Text))
            .Font = New Font(lblDocFontName.Text, CSng(lblDocFontSize.Text), lDocSampleFontStyle) 
            .ForeColor = lblDocFontColour.BackColor
        End With

    End Sub
    Private Sub SetTreeItems(ByVal pAppSettings As InitalXMLConfig)

        'transfered to pAppSettings

        lblTreeFontName.Text = pAppSettings.GetValue("Tree Font Name", "Microsoft Sans Serif")
        'lblTreeFontSize.Text = GetSetting("Tree Font Size", "8.25")
        lblTreeFontSize.Text = pAppSettings.GetValue("Tree Font Size", "8") 
        lblTreeFontColour.BackColor = System.Drawing.Color.FromName(pAppSettings.GetValue("Tree Font Colour", "Black")) 'Window

        
        Dim lTreeSampleFontStyle As New FontStyle()
        With lTreeFontExtra
            .Bold = CBool(pAppSettings.GetValue("Tree Font Bold", "False"))
            .Underlined = CBool(pAppSettings.GetValue("Tree Font Underlined", "False"))
            .Italic = CBool(pAppSettings.GetValue("Tree Font Italic", "False"))
            .StrikeOut = CBool(pAppSettings.GetValue("Tree Font Strikeout", "False"))
            If .Bold = True Then lTreeSampleFontStyle = FontStyle.Bold
            If .Underlined = True Then lTreeSampleFontStyle = lTreeSampleFontStyle + FontStyle.Underline
            If .Italic = True Then lTreeSampleFontStyle = lTreeSampleFontStyle + FontStyle.Italic
            If .StrikeOut = True Then lTreeSampleFontStyle = lTreeSampleFontStyle + FontStyle.Strikeout
        End With
        

        With lblTreeSample
            .Font = New Font(lblTreeFontName.Text, CSng(lblTreeFontSize.Text), lTreeSampleFontStyle) 
            .ForeColor = lblTreeFontColour.BackColor
        End With

    End Sub
    Private Sub btnDocChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocChange.Click

        Dim DocFonts As New FontDialog()
        With DocFonts
            .Font = lblDocSample.Font 

            .Color = lblDocFontColour.BackColor
            .FontMustExist = True
            .ShowApply = False
            .ShowEffects = True
            .ShowColor = True
            If .ShowDialog = DialogResult.OK Then
                lblDocFontName.Text = .Font.Name
                lblDocFontSize.Text = CInt(.Font.Size)
                lblDocSample.Font = .Font
                lblDocSample.ForeColor = .Color
                lblDocFontColour.BackColor = .Color

                lDocFontExtra.StrikeOut = .Font.Strikeout 
                lDocFontExtra.Underlined = .Font.Underline 
                lDocFontExtra.Bold = .Font.Bold 
                lDocFontExtra.Italic = .Font.Italic 

            End If
        End With

        lbooDocFontChanged = True

    End Sub
    Private Sub btnTreeChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTreeChange.Click

        Dim TreeFonts As New FontDialog()
        With TreeFonts
            '.Font = New Font(lblTreeFontName.Text, CSng(lblTreeFontSize.Text))
            .Font = lblTreeSample.Font 

            .Color = lblTreeFontColour.BackColor
            .FontMustExist = True
            .ShowApply = False
            .ShowEffects = True
            .ShowColor = True
            If .ShowDialog = DialogResult.OK Then
                lblTreeFontName.Text = .Font.Name
                lblTreeFontSize.Text = CInt(.Font.Size)
                lblTreeSample.Font = .Font
                lblTreeSample.ForeColor = .Color
                lblTreeFontColour.BackColor = .Color

                lTreeFontExtra.StrikeOut = .Font.Strikeout 
                lTreeFontExtra.Underlined = .Font.Underline 
                lTreeFontExtra.Bold = .Font.Bold 
                lTreeFontExtra.Italic = .Font.Italic 

            End If
        End With
        lbooTreeFontChanged = True

    End Sub
    Private Sub SaveChanges()

        If lbooDocFontChanged = True Then
            SaveSetting("Document Font Name", lblDocFontName.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Document Font Size", lblDocFontSize.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Document Font Colour", ColorToString(lblDocFontColour.BackColor), InitalXMLConfig.XmlConfigType.AppSettings, "")

            
            With lDocFontExtra
                SaveSetting("Document Font Bold", .Bold, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Document Font Underlined", .Underlined, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Document Font Italic", .Italic, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Document Font Strikeout", .StrikeOut, InitalXMLConfig.XmlConfigType.AppSettings, "")
            End With
            

            lbooDocFontChanged = False
        End If

        If lbooTreeFontChanged = True Then
            SaveSetting("Tree Font Name", lblTreeFontName.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Tree Font Size", lblTreeFontSize.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Tree Font Colour", ColorToString(lblTreeFontColour.BackColor), InitalXMLConfig.XmlConfigType.AppSettings, "")

            
            With lTreeFontExtra
                SaveSetting("Tree Font Bold", .Bold, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Tree Font Underlined", .Underlined, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Tree Font Italic", .Italic, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Tree Font Strikeout", .StrikeOut, InitalXMLConfig.XmlConfigType.AppSettings, "")
            End With
            

            lbooTreeFontChanged = False
        End If
        If lbooSeqNumChanged = True Then
            If rdoSortAlpha.Checked = True Then
                SaveSetting("Tree Sort Order", "ALPHA", InitalXMLConfig.XmlConfigType.AppSettings, "")
                gstrSortOrder = "ALPHA"
            Else
                SaveSetting("Tree Sort Order", "SEQNUM", InitalXMLConfig.XmlConfigType.AppSettings, "")
                gstrSortOrder = "SEQNUM"
            End If
            lbooSeqNumChanged = False
        End If

        
        If lbooBranchIncrChanged = True Then
            gintMoveBranchIncr = CInt(txtIncrementAmount.Text)
            If gintMoveBranchIncr = 0 Then gintMoveBranchIncr = 10 
            txtIncrementAmount.Text = gintMoveBranchIncr
            SaveSetting("Move Branch IncrDecr", gintMoveBranchIncr, InitalXMLConfig.XmlConfigType.AppSettings, "")
        End If
        

        If lbooStartupChanged = True Then
            If rdoStartupSelPage.Checked = True Then
                SaveSetting("Show Startup Page", "TRUE", InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("Startup Topic", "", InitalXMLConfig.XmlConfigType.AppSettings, "") 
            Else
                SaveSetting("Show Startup Page", "FALSE", InitalXMLConfig.XmlConfigType.AppSettings, "") 
                SaveSetting("Startup Topic", TreeView1.SelectedNode.Tag, InitalXMLConfig.XmlConfigType.AppSettings, "") 
            End If
        End If

        If rdoTempOrNormNorm.Checked = True Then
            SaveSetting("Use Template By Default", "FALSE", InitalXMLConfig.XmlConfigType.AppSettings, "")
        Else
            SaveSetting("Use Template By Default", "TRUE", InitalXMLConfig.XmlConfigType.AppSettings, "")

            SaveSetting("Default Template Name", lblDTTemplate.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Default Template File Name", lblDTTemplateFileName.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("Default Template ID", lblDTTemplateID.Text, InitalXMLConfig.XmlConfigType.AppSettings, "")
            Dim lstrSchemeName As String = cboDTColourScheme.Text
            If lstrSchemeName <> "" Then
                If InStrGet(lstrSchemeName, " (System)") > 0 Then
                    lstrSchemeName = Microsoft.VisualBasic.Replace(lstrSchemeName, " (System)", "")
                    lstrSchemeName = "SYSTEM:" & lstrSchemeName
                End If
            End If
            SaveSetting("Template Scheme", lstrSchemeName, InitalXMLConfig.XmlConfigType.AppSettings, "")

        End If

        
        If txtUserIconDir.Visible = True Then
            SaveSettingsValue("UsrIconDir", txtUserIconDir.Text)
        End If
        

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If CheckSettings() = False Then
            Exit Sub
        End If
        SaveChanges()
        Me.Close()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        AddDebugComment("Options.btnCancel_Click") 

        Me.Close()

    End Sub
    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApply.Click

        AddDebugComment("Options.btnApply_Click - 1") 

        If CheckSettings() = False Then
            Exit Sub
        End If

        AddDebugComment("Options.btnApply_Click - 2") 

        SaveChanges()

    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        SaveSetting("Document Font Name", "Microsoft Sans Serif", InitalXMLConfig.XmlConfigType.AppSettings, "")
        'SaveSetting("Document Font Size", "8.25", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Document Font Size", "8", InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("Document Font Colour", "Black", InitalXMLConfig.XmlConfigType.AppSettings, "")

        
        SaveSetting("Document Font Bold", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Document Font Underlined", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Document Font Italic", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Document Font Strikeout", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        

        'SetDocItems()

        SaveSetting("Tree Font Name", "Microsoft Sans Serif", InitalXMLConfig.XmlConfigType.AppSettings, "")
        'SaveSetting("Tree Font Size", "8.25", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Tree Font Size", "8", InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveSetting("Tree Font Colour", "Black", InitalXMLConfig.XmlConfigType.AppSettings, "")

        
        SaveSetting("Tree Font Bold", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Tree Font Underlined", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Tree Font Italic", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        SaveSetting("Tree Font Strikeout", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
        

        Dim AppSettings As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings) 
        SetDocItems(AppSettings) 
        SetTreeItems(AppSettings) 

    End Sub
    Private Sub options_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

        If e.KeyCode = System.Windows.Forms.Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.toolsoptions)) 
    End Sub
    Private Sub rdoSortAlpha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoSortAlpha.Click
        lbooSeqNumChanged = True
    End Sub
    Private Sub rdSortSeqNum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSortSeqNum.Click
        lbooSeqNumChanged = True
    End Sub
    Private Sub btnAddQuickLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQuickLaunch.Click
        AddQuickLaunchEtc(DialogResult.Yes)
    End Sub
    Private Sub GetDictionary()
        Dim lbooDictionaryNotFound As Boolean = True

        Dim lstrSpellDir As String = Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Spelling\"

        If Directory.Exists(lstrSpellDir) = True Then

            Dim lintArrInc As Integer, listDir() As String = System.IO.Directory.GetFiles(lstrSpellDir)
            For lintArrInc = 0 To listDir.Length - 1
                Dim lstrFileName As String = System.IO.Path.GetFileName(listDir(lintArrInc))
                cboCurrentDictionary.Items.Add(lstrFileName)
                lbooDictionaryNotFound = False
            Next lintArrInc

            Dim lstrDefaultDictionary As String = GetSetting( _
                "DictionaryFile", "", InitalXMLConfig.XmlConfigType.AppSettings, "")

            If lstrDefaultDictionary <> "" Then
                cboCurrentDictionary.SelectedItem = lstrDefaultDictionary
            End If

        Else
            ' MsgBox("Spell dir not found!")
            lbooDictionaryNotFound = True

        End If

        If lbooDictionaryNotFound = True Then
            grpNoDictionaryFound.Visible = True
            ''lnkURL.Links.Add(0, lnkURL.Text.Length, lnkURL.Text)
        Else
            grpNoDictionaryFound.Visible = False
        End If

    End Sub
    Private Sub cboCurrentDictionary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurrentDictionary.SelectedIndexChanged
        SaveSetting("DictionaryFile", cboCurrentDictionary.SelectedItem, InitalXMLConfig.XmlConfigType.AppSettings, "")
    End Sub
    Private Sub lnkURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkURL.LinkClicked
        'Try 
        '    'Process.Start(e.Link.LinkData.ToString)
        '    
        '    Bxsy(Me, True)

        '    Try 
        '        Dim psInfo As New System.Diagnostics.ProcessStartInfo("IEXPLORE", LangText.GetString("Options_SpellingURL"))
        '        psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        '        psInfo.CreateNoWindow = True
        '        Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        '    Catch 
        '        Dim psInfo As New System.Diagnostics.ProcessStartInfo(LangText.GetString("Options_SpellingURL"))
        '        psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        '        psInfo.CreateNoWindow = True
        '        Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        '    End Try 
        '    Bxsy(Me, False)
        'Catch
        'End Try
        BrowseToUrl(LangText.GetString("Options_SpellingURL"), Me) 

        btnOK_Click(Nothing, Nothing) 
    End Sub
    Private Sub btnDTSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDTSelect.Click

        Dim frmTempSelect As New TemplateSelection()
        With frmTempSelect
            .AllowMenuAddChk = False
            .Owner = Me 
            .TopMost = gbooAlwaysOnTop 

            .ShowDialog()
            Application.DoEvents() 
            lblDTTemplateID.Text = .TemplateID
            lblDTTemplateFileName.Text = .TemplateFileName
            lblDTTemplate.Text = .TemplateName
            
            If lblDTTemplate.Text = "" Then
                lblDTTemplate.Text = lstrlblDVTemplateText
            End If
            
        End With

    End Sub
    Private Sub btnDTColourSchemeBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDTColourSchemeBrowse.Click
        Dim CssFileOpen As New OpenFileDialog()
        With CssFileOpen
            '.Title = "Select a Colour Scheme file / Cascading Style Sheet"
            .Title = LangText.GetString("Options_SelectCSS") 

            .CheckPathExists = True
            .DefaultExt = "css"

            '.Filter = "Colour Scheme file (*.css)|*.css"
            
            .Filter = LangText.GetString("Options_CSSFilter")

            .ShowDialog()
            cboDTColourScheme.Text = .FileName
        End With
    End Sub
    Private Sub cboDTColourScheme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDTColourScheme.SelectedIndexChanged

    End Sub
    Private Sub rdoTempOrNormNorm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoTempOrNormNorm.CheckedChanged
        tabTemplates.Enabled = False
    End Sub
    Private Sub rdoTempOrNormTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoTempOrNormTemp.CheckedChanged
        tabTemplates.Enabled = True
    End Sub
    Private Sub btnDVSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDVSelect.Click

        If lblDVTemplate.Text <> lstrlblDVTemplateText Then 
            cboDVField.Enabled = True
            cboDVValue.Enabled = True
            btnDVSave.Enabled = True
        End If

    End Sub
    Private Sub cboDVField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDVField.SelectedIndexChanged

    End Sub
    Private Sub cboDVValue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDVValue.SelectedIndexChanged

    End Sub
    Private Function CheckSettings() As Boolean

        CheckSettings = True
        If rdoTempOrNormTemp.Checked = True Then
            If lblDTTemplateID.Text = "" Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                'mxessagebox.show("If you select to use Templates by default, you must specify a template!", NameMe(""))
                
                MessageBox.Show(LangText.GetString("Options_MustTemplate"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                CheckSettings = False
                Exit Function
            End If
        End If

        
        If rdoStartupSelTopic.Checked = True Then
            If TreeView1.SelectedNode Is Nothing Then 'If TreeView1.SelectedNode.Tag Is Nothing Then
                rdoStartupSelPage.Checked = True 
                ''mxessagebox.show("You must select a topic is you want to have a topic displayed at startup!", NameMe(""))
                'MessageBox.Show(LangText.GetString("Options_MustTopic"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                'CheckSettings = False
                'Exit Function
            End If
        End If
        

    End Function
    Private Sub rdoStartupSelPage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStartupSelPage.CheckedChanged

        TreeView1.Enabled = False
        TreeView1.BackColor = SystemColors.InactiveBorder
        lbooStartupChanged = True

    End Sub
    Private Sub rdoStartupSelTopic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStartupSelTopic.CheckedChanged

        TreeView1.Enabled = True
        TreeView1.BackColor = SystemColors.Window
        lbooStartupChanged = True

    End Sub
    Private Sub txtIncrementAmount_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIncrementAmount.Enter
        'added 
        txtIncrementAmount.SelectAll()
        lbooBranchIncrChanged = True
    End Sub
    Private Sub txtIncrementAmount_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIncrementAmount.MouseDown
        'added 
        txtIncrementAmount.SelectAll()
    End Sub
    Private Sub txtIncrementAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIncrementAmount.KeyPress
        'added 
        If e.KeyChar = CR() Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsNumber(e.KeyChar) Then
        Else
            e.Handled = True
        End If
        lbooBranchIncrChanged = True
    End Sub
    Private Sub txtIncrementAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIncrementAmount.KeyDown
        'added 
        lbooBranchIncrChanged = True
        If e.KeyCode = Keys.Enter Then
            If txtIncrementAmount.Text = "" Then
                txtIncrementAmount.Text = "10"
                txtIncrementAmount.SelectAll()
            Else
                btnOK_Click(Nothing, Nothing)
            End If
        End If

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnApply.BackColor = Color.FromArgb(0, btnApply.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        GroupBox1.BackColor = Color.FromArgb(0, GroupBox1.BackColor)
        GroupBox2.BackColor = Color.FromArgb(0, GroupBox2.BackColor)
        GroupBox3.BackColor = Color.FromArgb(0, GroupBox3.BackColor)
        btnDocChange.BackColor = Color.FromArgb(0, btnDocChange.BackColor)
        btnTreeChange.BackColor = Color.FromArgb(0, btnTreeChange.BackColor)
        btnReset.BackColor = Color.FromArgb(0, btnReset.BackColor)
        rdoSortAlpha.BackColor = Color.FromArgb(0, rdoSortAlpha.BackColor)
        rdSortSeqNum.BackColor = Color.FromArgb(0, rdSortSeqNum.BackColor)
        btnAddQuickLaunch.BackColor = Color.FromArgb(0, btnAddQuickLaunch.BackColor)
        grpNoDictionaryFound.BackColor = Color.FromArgb(0, grpNoDictionaryFound.BackColor)
        rdoTempOrNormNorm.BackColor = Color.FromArgb(0, rdoTempOrNormNorm.BackColor)
        rdoTempOrNormTemp.BackColor = Color.FromArgb(0, rdoTempOrNormTemp.BackColor)
        btnDTSelect.BackColor = Color.FromArgb(0, btnDTSelect.BackColor)
        btnDTColourSchemeBrowse.BackColor = Color.FromArgb(0, btnDTColourSchemeBrowse.BackColor)
        btnDVSelect.BackColor = Color.FromArgb(0, btnDVSelect.BackColor)
        btnDVSave.BackColor = Color.FromArgb(0, btnDVSave.BackColor)
        rdoStartupSelPage.BackColor = Color.FromArgb(0, rdoStartupSelPage.BackColor)
        rdoStartupSelTopic.BackColor = Color.FromArgb(0, rdoStartupSelTopic.BackColor)

        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        Label5.BackColor = Color.FromArgb(0, Label5.BackColor)
        Label6.BackColor = Color.FromArgb(0, Label6.BackColor)
        Label7.BackColor = Color.FromArgb(0, Label7.BackColor)
        Label8.BackColor = Color.FromArgb(0, Label8.BackColor)
        Label9.BackColor = Color.FromArgb(0, Label9.BackColor)
        Label10.BackColor = Color.FromArgb(0, Label10.BackColor)
        Label11.BackColor = Color.FromArgb(0, Label11.BackColor)
        Label12.BackColor = Color.FromArgb(0, Label12.BackColor)
        Label13.BackColor = Color.FromArgb(0, Label13.BackColor)
        Label14.BackColor = Color.FromArgb(0, Label14.BackColor)
        Label15.BackColor = Color.FromArgb(0, Label15.BackColor)
        Label16.BackColor = Color.FromArgb(0, Label16.BackColor)
        Label17.BackColor = Color.FromArgb(0, Label17.BackColor)
        Label18.BackColor = Color.FromArgb(0, Label18.BackColor)
        Label19.BackColor = Color.FromArgb(0, Label19.BackColor)
        Label20.BackColor = Color.FromArgb(0, Label20.BackColor)
        Label21.BackColor = Color.FromArgb(0, Label21.BackColor)
        Label22.BackColor = Color.FromArgb(0, Label22.BackColor)
        Label23.BackColor = Color.FromArgb(0, Label23.BackColor)
        Label24.BackColor = Color.FromArgb(0, Label24.BackColor)

        TabControl1.BackColor = Color.FromArgb(0, TabControl1.BackColor)
        TabPage1.BackColor = Color.FromArgb(0, TabPage1.BackColor)
        TabPage2.BackColor = Color.FromArgb(0, TabPage2.BackColor)
        TabPage3.BackColor = Color.FromArgb(0, TabPage3.BackColor)
        TabPage4.BackColor = Color.FromArgb(0, TabPage4.BackColor)
        TabPage5.BackColor = Color.FromArgb(0, TabPage5.BackColor)
        TabPage6.BackColor = Color.FromArgb(0, TabPage6.BackColor)
        TabPage7.BackColor = Color.FromArgb(0, TabPage7.BackColor)
        tabTemplates.BackColor = Color.FromArgb(0, tabTemplates.BackColor)
        lblDocFontColour.BackColor = Color.FromArgb(0, lblDocFontColour.BackColor)
        lblDocFontName.BackColor = Color.FromArgb(0, lblDocFontName.BackColor)
        lblTreeFontName.BackColor = Color.FromArgb(0, lblTreeFontName.BackColor)
        lblTreeFontColour.BackColor = Color.FromArgb(0, lblTreeFontColour.BackColor)
        lblTreeFontSize.BackColor = Color.FromArgb(0, lblTreeFontSize.BackColor)
        lblDocSample.BackColor = Color.FromArgb(0, lblDocSample.BackColor)
        lblTreeSample.BackColor = Color.FromArgb(0, lblTreeSample.BackColor)
        lblDocFontSize.BackColor = Color.FromArgb(0, lblDocFontSize.BackColor)
        lnkURL.BackColor = Color.FromArgb(0, lnkURL.BackColor)
        lblDTTemplate.BackColor = Color.FromArgb(0, lblDTTemplate.BackColor)
        lblDTTemplateID.BackColor = Color.FromArgb(0, lblDTTemplateID.BackColor)
        lblDTTemplateFileName.BackColor = Color.FromArgb(0, lblDTTemplateFileName.BackColor)
        lblIncrementAmount.BackColor = Color.FromArgb(0, lblIncrementAmount.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        'Added 
        'If IsWin98orME() = True Then
        'rdoSortAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Standard '4
        'rdoSortAlpha.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoSortAlpha.Top, rdoSortAlpha.Left, rdoSortAlpha.Width, rdoSortAlpha.Height) '4
        'rdSortSeqNum.FlatStyle = System.Windows.Forms.FlatStyle.Standard '4
        'rdSortSeqNum.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdSortSeqNum.Top, rdSortSeqNum.Left, rdSortSeqNum.Width, rdSortSeqNum.Height) '4
        'rdoTempOrNormNorm.FlatStyle = System.Windows.Forms.FlatStyle.Standard '5
        'rdoTempOrNormNorm.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoTempOrNormNorm.Top, rdoTempOrNormNorm.Left, rdoTempOrNormNorm.Width, rdoTempOrNormNorm.Height) '5
        'rdoTempOrNormTemp.FlatStyle = System.Windows.Forms.FlatStyle.Standard '5
        'rdoTempOrNormTemp.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoTempOrNormTemp.Top, rdoTempOrNormTemp.Left, rdoTempOrNormTemp.Width, rdoTempOrNormTemp.Height) '5
        'rdoStartupSelPage.FlatStyle = System.Windows.Forms.FlatStyle.Standard '3
        'rdoStartupSelPage.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoStartupSelPage.Top, rdoStartupSelPage.Left, rdoStartupSelPage.Width, rdoStartupSelPage.Height) '3
        'rdoStartupSelTopic.FlatStyle = System.Windows.Forms.FlatStyle.Standard '3
        'rdoStartupSelTopic.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoStartupSelTopic.Top, rdoStartupSelTopic.Left, rdoStartupSelTopic.Width, rdoStartupSelTopic.Height) '3
        'End If


    End Sub
    Private Sub TabPage1_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage1.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage1.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage1.Width + 12, TabPage1.Height + 28)
        

    End Sub
    Private Sub TabPage2_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage2.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage2.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage2.Width + 12, TabPage2.Height + 28)
        

    End Sub
    Private Sub TabPage3_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage3.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage3.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage3.Width + 12, TabPage3.Height + 28)
        

        ''--- moved 
        ''TODO: Test Options screen on W98 etc
        'If IsAboveOrEqualWinXp() = True Then
        '    rdoStartupSelPage.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoStartupSelPage.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoStartupSelPage.Top, rdoStartupSelPage.Left, rdoStartupSelPage.Width, rdoStartupSelPage.Height)
        '    rdoStartupSelTopic.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoStartupSelTopic.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoStartupSelTopic.Top, rdoStartupSelTopic.Left, rdoStartupSelTopic.Width, rdoStartupSelTopic.Height)
        'End If
        ''--- moved 

    End Sub
    Private Sub TabPage4_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage4.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage4.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage4.Width + 12, TabPage4.Height + 28)
        

        ''--- moved 
        'If IsAboveOrEqualWinXp() = True Then
        '    rdoSortAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoSortAlpha.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoSortAlpha.Top, rdoSortAlpha.Left, rdoSortAlpha.Width, rdoSortAlpha.Height)
        '    rdSortSeqNum.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdSortSeqNum.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdSortSeqNum.Top, rdSortSeqNum.Left, rdSortSeqNum.Width, rdSortSeqNum.Height)
        'End If
        ''--- moved 

    End Sub
    Private Sub TabPage5_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage5.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage5.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage5.Width + 12, TabPage5.Height + 28)
        

        ''--- moved 
        'If IsAboveOrEqualWinXp() = True Then
        '    rdoTempOrNormNorm.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoTempOrNormNorm.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoTempOrNormNorm.Top, rdoTempOrNormNorm.Left, rdoTempOrNormNorm.Width, rdoTempOrNormNorm.Height)
        '    rdoTempOrNormTemp.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoTempOrNormTemp.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoTempOrNormTemp.Top, rdoTempOrNormTemp.Left, rdoTempOrNormTemp.Width, rdoTempOrNormTemp.Height)
        'End If
        ''--- moved 

    End Sub
    Private Sub TabPage6_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage6.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage6.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage6.Width + 12, TabPage6.Height + 28)
        

    End Sub
    Private Sub TabPage7_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage7.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage7.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage7.Width + 12, TabPage7.Height + 28)
        

    End Sub
    Private Sub options_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
    WithEvents btnUserIconDir As New Button() 
    Dim txtUserIconDir As New TextBox()
    Private Sub AddUserIconControls()

        'added 

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim grpIcons As New GroupBox()
        With grpIcons
            .Text = LangText.GetString("Options_IBFIcons") '"Information Base Icons"            
            .Top = GroupBox2.Top + GroupBox2.Height + 10
            .Width = GroupBox2.Width
            .Left = GroupBox2.Left
            .Height = (TabPage3.Height - (.Top + 10))
        End With

        TabPage3.Controls.Add(grpIcons)

        With btnUserIconDir
            .Top = 20
            .Left = (grpIcons.Width) - (.Width + 20)
            .Text = StandLangText.GetString("StandText_Browse")
            If IsAboveOrEqualWinXp() = True Then
                .FlatStyle = FlatStyle.System
            End If
        End With

        Dim lab As New Label()
        With lab
            .Top = btnUserIconDir.Top + 10
            .Left = 20
            .Width = grpIcons.Width - 20
            .Text = LangText.GetString("Options_CurrentIconDir") '"Current icon directory"
        End With


        With txtUserIconDir
            .Top = btnUserIconDir.Top + 10 + btnUserIconDir.Height
            .Left = 20
            .Width = (grpIcons.Width - GroupBox2.Left) - 30
            .Text = ""
            .ReadOnly = True
        End With

        grpIcons.Controls.AddRange(New System.Windows.Forms.Control() {btnUserIconDir, lab, txtUserIconDir})

    End Sub

    Private Sub btnUserIconDir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUserIconDir.Click
        'added 

        Dim db As New DirBrowser()
        db.Description = StandLangText.GetString("StandText_ChooseAFolder") 
        db.StartLocation = 0
        db.Style = 1
        If db.ShowDialog = DialogResult.OK Then
            If db.ReturnPath.Length > 255 Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("Options_IconDirTooLong"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                txtUserIconDir.Text = db.ReturnPath
            End If
        End If

    End Sub
End Class