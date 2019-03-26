Friend Class findindb
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents pnlText As System.Windows.Forms.Panel
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtSearchString As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents rdoSearchByIcon As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSearchByText As System.Windows.Forms.RadioButton
    Friend WithEvents lblExtraIcons As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlIcon As System.Windows.Forms.Panel
    Friend WithEvents btnFindByIcon As System.Windows.Forms.Button
    Friend WithEvents btnChangeIcon As System.Windows.Forms.Button
    Friend WithEvents lblIconSelect As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(findindb))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.pnlText = New System.Windows.Forms.Panel()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtSearchString = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.rdoSearchByIcon = New System.Windows.Forms.RadioButton()
        Me.rdoSearchByText = New System.Windows.Forms.RadioButton()
        Me.lblExtraIcons = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlIcon = New System.Windows.Forms.Panel()
        Me.btnFindByIcon = New System.Windows.Forms.Button()
        Me.btnChangeIcon = New System.Windows.Forms.Button()
        Me.lblIconSelect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlText.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = CType(resources.GetObject("btnClose.AccessibleDescription"), String)
        Me.btnClose.AccessibleName = CType(resources.GetObject("btnClose.AccessibleName"), String)
        Me.btnClose.Anchor = CType(resources.GetObject("btnClose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
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
        'Label1
        '
        Me.Label1.AccessibleDescription = CType(resources.GetObject("Label1.AccessibleDescription"), String)
        Me.Label1.AccessibleName = CType(resources.GetObject("Label1.AccessibleName"), String)
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
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
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowPlusMinus = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = CType(resources.GetObject("TreeView1.Size"), System.Drawing.Size)
        Me.TreeView1.TabIndex = CType(resources.GetObject("TreeView1.TabIndex"), Integer)
        Me.TreeView1.Text = resources.GetString("TreeView1.Text")
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'pnlText
        '
        Me.pnlText.AccessibleDescription = CType(resources.GetObject("pnlText.AccessibleDescription"), String)
        Me.pnlText.AccessibleName = CType(resources.GetObject("pnlText.AccessibleName"), String)
        Me.pnlText.Anchor = CType(resources.GetObject("pnlText.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.pnlText.AutoScroll = CType(resources.GetObject("pnlText.AutoScroll"), Boolean)
        Me.pnlText.AutoScrollMargin = CType(resources.GetObject("pnlText.AutoScrollMargin"), System.Drawing.Size)
        Me.pnlText.AutoScrollMinSize = CType(resources.GetObject("pnlText.AutoScrollMinSize"), System.Drawing.Size)
        Me.pnlText.BackgroundImage = CType(resources.GetObject("pnlText.BackgroundImage"), System.Drawing.Image)
        Me.pnlText.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnFind, Me.txtSearchString})
        Me.pnlText.Dock = CType(resources.GetObject("pnlText.Dock"), System.Windows.Forms.DockStyle)
        Me.pnlText.Enabled = CType(resources.GetObject("pnlText.Enabled"), Boolean)
        Me.pnlText.Font = CType(resources.GetObject("pnlText.Font"), System.Drawing.Font)
        Me.pnlText.ImeMode = CType(resources.GetObject("pnlText.ImeMode"), System.Windows.Forms.ImeMode)
        Me.pnlText.Location = CType(resources.GetObject("pnlText.Location"), System.Drawing.Point)
        Me.pnlText.Name = "pnlText"
        Me.pnlText.RightToLeft = CType(resources.GetObject("pnlText.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.pnlText.Size = CType(resources.GetObject("pnlText.Size"), System.Drawing.Size)
        Me.pnlText.TabIndex = CType(resources.GetObject("pnlText.TabIndex"), Integer)
        Me.pnlText.Text = resources.GetString("pnlText.Text")
        Me.pnlText.Visible = CType(resources.GetObject("pnlText.Visible"), Boolean)
        '
        'btnFind
        '
        Me.btnFind.AccessibleDescription = CType(resources.GetObject("btnFind.AccessibleDescription"), String)
        Me.btnFind.AccessibleName = CType(resources.GetObject("btnFind.AccessibleName"), String)
        Me.btnFind.Anchor = CType(resources.GetObject("btnFind.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnFind.BackgroundImage = CType(resources.GetObject("btnFind.BackgroundImage"), System.Drawing.Image)
        Me.btnFind.Dock = CType(resources.GetObject("btnFind.Dock"), System.Windows.Forms.DockStyle)
        Me.btnFind.Enabled = CType(resources.GetObject("btnFind.Enabled"), Boolean)
        Me.btnFind.FlatStyle = CType(resources.GetObject("btnFind.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnFind.Font = CType(resources.GetObject("btnFind.Font"), System.Drawing.Font)
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageAlign = CType(resources.GetObject("btnFind.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnFind.ImageIndex = CType(resources.GetObject("btnFind.ImageIndex"), Integer)
        Me.btnFind.ImeMode = CType(resources.GetObject("btnFind.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnFind.Location = CType(resources.GetObject("btnFind.Location"), System.Drawing.Point)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.RightToLeft = CType(resources.GetObject("btnFind.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnFind.Size = CType(resources.GetObject("btnFind.Size"), System.Drawing.Size)
        Me.btnFind.TabIndex = CType(resources.GetObject("btnFind.TabIndex"), Integer)
        Me.btnFind.Text = resources.GetString("btnFind.Text")
        Me.btnFind.TextAlign = CType(resources.GetObject("btnFind.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnFind.Visible = CType(resources.GetObject("btnFind.Visible"), Boolean)
        '
        'txtSearchString
        '
        Me.txtSearchString.AccessibleDescription = CType(resources.GetObject("txtSearchString.AccessibleDescription"), String)
        Me.txtSearchString.AccessibleName = CType(resources.GetObject("txtSearchString.AccessibleName"), String)
        Me.txtSearchString.Anchor = CType(resources.GetObject("txtSearchString.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtSearchString.AutoSize = CType(resources.GetObject("txtSearchString.AutoSize"), Boolean)
        Me.txtSearchString.BackgroundImage = CType(resources.GetObject("txtSearchString.BackgroundImage"), System.Drawing.Image)
        Me.txtSearchString.Dock = CType(resources.GetObject("txtSearchString.Dock"), System.Windows.Forms.DockStyle)
        Me.txtSearchString.Enabled = CType(resources.GetObject("txtSearchString.Enabled"), Boolean)
        Me.txtSearchString.Font = CType(resources.GetObject("txtSearchString.Font"), System.Drawing.Font)
        Me.txtSearchString.ImeMode = CType(resources.GetObject("txtSearchString.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtSearchString.Location = CType(resources.GetObject("txtSearchString.Location"), System.Drawing.Point)
        Me.txtSearchString.MaxLength = CType(resources.GetObject("txtSearchString.MaxLength"), Integer)
        Me.txtSearchString.Multiline = CType(resources.GetObject("txtSearchString.Multiline"), Boolean)
        Me.txtSearchString.Name = "txtSearchString"
        Me.txtSearchString.PasswordChar = CType(resources.GetObject("txtSearchString.PasswordChar"), Char)
        Me.txtSearchString.RightToLeft = CType(resources.GetObject("txtSearchString.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtSearchString.ScrollBars = CType(resources.GetObject("txtSearchString.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtSearchString.Size = CType(resources.GetObject("txtSearchString.Size"), System.Drawing.Size)
        Me.txtSearchString.TabIndex = CType(resources.GetObject("txtSearchString.TabIndex"), Integer)
        Me.txtSearchString.Text = resources.GetString("txtSearchString.Text")
        Me.txtSearchString.TextAlign = CType(resources.GetObject("txtSearchString.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtSearchString.Visible = CType(resources.GetObject("txtSearchString.Visible"), Boolean)
        Me.txtSearchString.WordWrap = CType(resources.GetObject("txtSearchString.WordWrap"), Boolean)
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AccessibleDescription = CType(resources.GetObject("lblSearchBy.AccessibleDescription"), String)
        Me.lblSearchBy.AccessibleName = CType(resources.GetObject("lblSearchBy.AccessibleName"), String)
        Me.lblSearchBy.Anchor = CType(resources.GetObject("lblSearchBy.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblSearchBy.AutoSize = CType(resources.GetObject("lblSearchBy.AutoSize"), Boolean)
        Me.lblSearchBy.Dock = CType(resources.GetObject("lblSearchBy.Dock"), System.Windows.Forms.DockStyle)
        Me.lblSearchBy.Enabled = CType(resources.GetObject("lblSearchBy.Enabled"), Boolean)
        Me.lblSearchBy.Font = CType(resources.GetObject("lblSearchBy.Font"), System.Drawing.Font)
        Me.lblSearchBy.Image = CType(resources.GetObject("lblSearchBy.Image"), System.Drawing.Image)
        Me.lblSearchBy.ImageAlign = CType(resources.GetObject("lblSearchBy.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblSearchBy.ImageIndex = CType(resources.GetObject("lblSearchBy.ImageIndex"), Integer)
        Me.lblSearchBy.ImeMode = CType(resources.GetObject("lblSearchBy.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblSearchBy.Location = CType(resources.GetObject("lblSearchBy.Location"), System.Drawing.Point)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.RightToLeft = CType(resources.GetObject("lblSearchBy.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblSearchBy.Size = CType(resources.GetObject("lblSearchBy.Size"), System.Drawing.Size)
        Me.lblSearchBy.TabIndex = CType(resources.GetObject("lblSearchBy.TabIndex"), Integer)
        Me.lblSearchBy.Text = resources.GetString("lblSearchBy.Text")
        Me.lblSearchBy.TextAlign = CType(resources.GetObject("lblSearchBy.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblSearchBy.Visible = CType(resources.GetObject("lblSearchBy.Visible"), Boolean)
        '
        'rdoSearchByIcon
        '
        Me.rdoSearchByIcon.AccessibleDescription = CType(resources.GetObject("rdoSearchByIcon.AccessibleDescription"), String)
        Me.rdoSearchByIcon.AccessibleName = CType(resources.GetObject("rdoSearchByIcon.AccessibleName"), String)
        Me.rdoSearchByIcon.Anchor = CType(resources.GetObject("rdoSearchByIcon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoSearchByIcon.Appearance = CType(resources.GetObject("rdoSearchByIcon.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoSearchByIcon.BackgroundImage = CType(resources.GetObject("rdoSearchByIcon.BackgroundImage"), System.Drawing.Image)
        Me.rdoSearchByIcon.CheckAlign = CType(resources.GetObject("rdoSearchByIcon.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByIcon.Dock = CType(resources.GetObject("rdoSearchByIcon.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoSearchByIcon.Enabled = CType(resources.GetObject("rdoSearchByIcon.Enabled"), Boolean)
        Me.rdoSearchByIcon.FlatStyle = CType(resources.GetObject("rdoSearchByIcon.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoSearchByIcon.Font = CType(resources.GetObject("rdoSearchByIcon.Font"), System.Drawing.Font)
        Me.rdoSearchByIcon.Image = CType(resources.GetObject("rdoSearchByIcon.Image"), System.Drawing.Image)
        Me.rdoSearchByIcon.ImageAlign = CType(resources.GetObject("rdoSearchByIcon.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByIcon.ImageIndex = CType(resources.GetObject("rdoSearchByIcon.ImageIndex"), Integer)
        Me.rdoSearchByIcon.ImeMode = CType(resources.GetObject("rdoSearchByIcon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoSearchByIcon.Location = CType(resources.GetObject("rdoSearchByIcon.Location"), System.Drawing.Point)
        Me.rdoSearchByIcon.Name = "rdoSearchByIcon"
        Me.rdoSearchByIcon.RightToLeft = CType(resources.GetObject("rdoSearchByIcon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoSearchByIcon.Size = CType(resources.GetObject("rdoSearchByIcon.Size"), System.Drawing.Size)
        Me.rdoSearchByIcon.TabIndex = CType(resources.GetObject("rdoSearchByIcon.TabIndex"), Integer)
        Me.rdoSearchByIcon.Text = resources.GetString("rdoSearchByIcon.Text")
        Me.rdoSearchByIcon.TextAlign = CType(resources.GetObject("rdoSearchByIcon.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByIcon.Visible = CType(resources.GetObject("rdoSearchByIcon.Visible"), Boolean)
        '
        'rdoSearchByText
        '
        Me.rdoSearchByText.AccessibleDescription = CType(resources.GetObject("rdoSearchByText.AccessibleDescription"), String)
        Me.rdoSearchByText.AccessibleName = CType(resources.GetObject("rdoSearchByText.AccessibleName"), String)
        Me.rdoSearchByText.Anchor = CType(resources.GetObject("rdoSearchByText.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoSearchByText.Appearance = CType(resources.GetObject("rdoSearchByText.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoSearchByText.BackgroundImage = CType(resources.GetObject("rdoSearchByText.BackgroundImage"), System.Drawing.Image)
        Me.rdoSearchByText.CheckAlign = CType(resources.GetObject("rdoSearchByText.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByText.Checked = True
        Me.rdoSearchByText.Dock = CType(resources.GetObject("rdoSearchByText.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoSearchByText.Enabled = CType(resources.GetObject("rdoSearchByText.Enabled"), Boolean)
        Me.rdoSearchByText.FlatStyle = CType(resources.GetObject("rdoSearchByText.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoSearchByText.Font = CType(resources.GetObject("rdoSearchByText.Font"), System.Drawing.Font)
        Me.rdoSearchByText.Image = CType(resources.GetObject("rdoSearchByText.Image"), System.Drawing.Image)
        Me.rdoSearchByText.ImageAlign = CType(resources.GetObject("rdoSearchByText.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByText.ImageIndex = CType(resources.GetObject("rdoSearchByText.ImageIndex"), Integer)
        Me.rdoSearchByText.ImeMode = CType(resources.GetObject("rdoSearchByText.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoSearchByText.Location = CType(resources.GetObject("rdoSearchByText.Location"), System.Drawing.Point)
        Me.rdoSearchByText.Name = "rdoSearchByText"
        Me.rdoSearchByText.RightToLeft = CType(resources.GetObject("rdoSearchByText.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoSearchByText.Size = CType(resources.GetObject("rdoSearchByText.Size"), System.Drawing.Size)
        Me.rdoSearchByText.TabIndex = CType(resources.GetObject("rdoSearchByText.TabIndex"), Integer)
        Me.rdoSearchByText.TabStop = True
        Me.rdoSearchByText.Text = resources.GetString("rdoSearchByText.Text")
        Me.rdoSearchByText.TextAlign = CType(resources.GetObject("rdoSearchByText.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoSearchByText.Visible = CType(resources.GetObject("rdoSearchByText.Visible"), Boolean)
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
        'pnlIcon
        '
        Me.pnlIcon.AccessibleDescription = CType(resources.GetObject("pnlIcon.AccessibleDescription"), String)
        Me.pnlIcon.AccessibleName = CType(resources.GetObject("pnlIcon.AccessibleName"), String)
        Me.pnlIcon.Anchor = CType(resources.GetObject("pnlIcon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.pnlIcon.AutoScroll = CType(resources.GetObject("pnlIcon.AutoScroll"), Boolean)
        Me.pnlIcon.AutoScrollMargin = CType(resources.GetObject("pnlIcon.AutoScrollMargin"), System.Drawing.Size)
        Me.pnlIcon.AutoScrollMinSize = CType(resources.GetObject("pnlIcon.AutoScrollMinSize"), System.Drawing.Size)
        Me.pnlIcon.BackgroundImage = CType(resources.GetObject("pnlIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlIcon.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnFindByIcon, Me.btnChangeIcon, Me.lblIconSelect, Me.Label2})
        Me.pnlIcon.Dock = CType(resources.GetObject("pnlIcon.Dock"), System.Windows.Forms.DockStyle)
        Me.pnlIcon.Enabled = CType(resources.GetObject("pnlIcon.Enabled"), Boolean)
        Me.pnlIcon.Font = CType(resources.GetObject("pnlIcon.Font"), System.Drawing.Font)
        Me.pnlIcon.ImeMode = CType(resources.GetObject("pnlIcon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.pnlIcon.Location = CType(resources.GetObject("pnlIcon.Location"), System.Drawing.Point)
        Me.pnlIcon.Name = "pnlIcon"
        Me.pnlIcon.RightToLeft = CType(resources.GetObject("pnlIcon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.pnlIcon.Size = CType(resources.GetObject("pnlIcon.Size"), System.Drawing.Size)
        Me.pnlIcon.TabIndex = CType(resources.GetObject("pnlIcon.TabIndex"), Integer)
        Me.pnlIcon.Text = resources.GetString("pnlIcon.Text")
        Me.pnlIcon.Visible = CType(resources.GetObject("pnlIcon.Visible"), Boolean)
        '
        'btnFindByIcon
        '
        Me.btnFindByIcon.AccessibleDescription = CType(resources.GetObject("btnFindByIcon.AccessibleDescription"), String)
        Me.btnFindByIcon.AccessibleName = CType(resources.GetObject("btnFindByIcon.AccessibleName"), String)
        Me.btnFindByIcon.Anchor = CType(resources.GetObject("btnFindByIcon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnFindByIcon.BackgroundImage = CType(resources.GetObject("btnFindByIcon.BackgroundImage"), System.Drawing.Image)
        Me.btnFindByIcon.Dock = CType(resources.GetObject("btnFindByIcon.Dock"), System.Windows.Forms.DockStyle)
        Me.btnFindByIcon.Enabled = CType(resources.GetObject("btnFindByIcon.Enabled"), Boolean)
        Me.btnFindByIcon.FlatStyle = CType(resources.GetObject("btnFindByIcon.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnFindByIcon.Font = CType(resources.GetObject("btnFindByIcon.Font"), System.Drawing.Font)
        Me.btnFindByIcon.Image = CType(resources.GetObject("btnFindByIcon.Image"), System.Drawing.Image)
        Me.btnFindByIcon.ImageAlign = CType(resources.GetObject("btnFindByIcon.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnFindByIcon.ImageIndex = CType(resources.GetObject("btnFindByIcon.ImageIndex"), Integer)
        Me.btnFindByIcon.ImeMode = CType(resources.GetObject("btnFindByIcon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnFindByIcon.Location = CType(resources.GetObject("btnFindByIcon.Location"), System.Drawing.Point)
        Me.btnFindByIcon.Name = "btnFindByIcon"
        Me.btnFindByIcon.RightToLeft = CType(resources.GetObject("btnFindByIcon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnFindByIcon.Size = CType(resources.GetObject("btnFindByIcon.Size"), System.Drawing.Size)
        Me.btnFindByIcon.TabIndex = CType(resources.GetObject("btnFindByIcon.TabIndex"), Integer)
        Me.btnFindByIcon.Text = resources.GetString("btnFindByIcon.Text")
        Me.btnFindByIcon.TextAlign = CType(resources.GetObject("btnFindByIcon.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnFindByIcon.Visible = CType(resources.GetObject("btnFindByIcon.Visible"), Boolean)
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
        'findindb
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlIcon, Me.Label3, Me.lblExtraIcons, Me.Panel1, Me.rdoSearchByText, Me.rdoSearchByIcon, Me.lblSearchBy, Me.pnlText, Me.TreeView1, Me.Label1, Me.btnSelect, Me.btnClose})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "findindb"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.pnlText.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlIcon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Res As New IPIconsPack.Resource() 
    Dim mTopicCode As String
    Dim llngIconPanelTop As Long 
    Friend Property TopicCode() As String
        Get
            Return mTopicCode
        End Get
        Set(ByVal Value As String)
            'mTopicCode = Value
        End Set
    End Property
    Dim mTreeviewSelect As TreeView

    Friend Property TreeviewSelect() As TreeView
        Get
            Return mTreeviewSelect
        End Get
        Set(ByVal Value As TreeView)
            mTreeviewSelect = Value
        End Set
    End Property
    'Dim mViewSetting As frmPad.DocumentViews
    'Friend Sub ViewSetting(ByRef pViewSetting As frmPad.DocumentViews)
    '    mViewSetting = pViewSetting
    'End Sub
    Dim mstrCaption As String 
    Friend Property Caption() As String
        Get

            Return mstrCaption
        End Get
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property
    Dim llngNewFormHeight As Long
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        'If txtSearchString.Text.Length = 0 Then
        '    'lstResults.Items.Clear() 
        '    TreeView1.Nodes.Clear() 
        '    Exit Sub
        'End If

        BusyButtons(True) 
        Busy(Me, True) 

        ''Dim lcnn1 As New ADODB.Connection()
        ''Dim lsnaLists As New ADODB.Recordset()
        ''Dim llngRecCount As Long
        ''Dim lstrSQL As String

        ''Try


        ''    'lstResults.BeginUpdate()
        ''    'lstResults.Items.Clear()
        ''    
        ''    TreeView1.BeginUpdate()
        ''    TreeView1.Nodes.Clear()

        ''    'lstResultCodes.Items.Clear()

        ''    lcnn1 = New ADODB.Connection()
        ''    lcnn1.Open(gstrConnectionString)

        ''    'lstrSQL = "SELECT Topics.TopicCode as tc, Topics.Title FROM Topics, TopicDetail WHERE " & _
        ''    '    "(((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')" & _
        ''    '    ",Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND " & _
        ''    '    "((TopicDetail.Detail) Like '%" & txtSearchString.Text & "%'));"

        ''    'now searches on titles too
        ''    'lstrSQL = "SELECT Topics.TopicCode AS tc, Topics.Title FROM Topics, TopicDetail " & _
        ''    '    "WHERE (((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-" & _
        ''    '    "InStr(1,[Topics].[TopicCode],'T')+1)) AND ((TopicDetail.Detail) Like '%" & txtSearchString.Text & _
        ''    '    "%')) OR (((Topics.Title) Like '%" & txtSearchString.Text & "%') AND ((TopicDetail.TopicCode)=" & _
        ''    '    "Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"

        ''    
        ''    'lstrSQL = "SELECT Topics.TopicCode AS tc, Topics.Title, ImgIdx FROM Topics, TopicDetail " & _
        ''    '    "WHERE (((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-" & _
        ''    '    "InStr(1,[Topics].[TopicCode],'T')+1)) AND ((TopicDetail.Detail) Like '%" & txtSearchString.Text & _
        ''    '    "%')) OR (((Topics.Title) Like '%" & txtSearchString.Text & "%') AND ((TopicDetail.TopicCode)=" & _
        ''    '    "Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"

        ''    
        ''    lstrSQL = "SELECT TopicCode AS tc, Title, ImgIdx FROM Topics WHERE (((Title) Like '%" & txtSearchString.Text & "%'));"

        ''    lsnaLists.Open(lstrSQL, _
        ''        lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        ''    With lsnaLists
        ''        llngRecCount = 0
        ''        Do While Not .EOF
        ''            'lstResults.Items.Add(.Fields("Title").Value & "")
        ''            'lstResultCodes.Items.Add(.Fields("tc").Value & "")

        ''            
        ''            Dim tnNew As New TreeNode()
        ''            tnNew.Text = .Fields("Title").Value & ""
        ''            tnNew.Tag = .Fields("tc").Value & ""
        ''            'tnNew.ImageIndex = .Fields("ImgIdx").Value
        ''            'tnNew.SelectedImageIndex = .Fields("ImgIdx").Value
        ''            
        ''            'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
        ''            'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
        ''            Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
        ''            tnNew.ImageIndex = lintImgIdx
        ''            tnNew.SelectedImageIndex = lintImgIdx
        ''            

        ''            TreeView1.Nodes.Add(tnNew)

        ''            .MoveNext()
        ''        Loop
        ''    End With

        ''    If llngRecCount = 0 Then
        ''    End If

        ''    lsnaLists.Close()
        ''    lcnn1.Close()

        ''    'lstResults.EndUpdate()
        ''    TreeView1.EndUpdate()

        ''Catch ex As Exception
        ''    Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
        ''    Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        ''End Try

        
        Dim find As New Finding()
        find.TitleSearch(TreeView1, txtSearchString.Text)
        

        
        Dim DetailsSearch As New FindInDBDetails()
        DetailsSearch.SearchText = txtSearchString.Text
        DetailsSearch.ResultTreeview = TreeView1
        DetailsSearch.ShowDialog()
        Application.DoEvents()
        

        BusyButtons(False) 
        Busy(Me, False) 

    End Sub
    Private Sub findindb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnClose.FlatStyle = FlatStyle.System
            btnSelect.FlatStyle = FlatStyle.System
            btnFind.FlatStyle = FlatStyle.System
            btnFindByIcon.FlatStyle = FlatStyle.System
            btnChangeIcon.FlatStyle = FlatStyle.System
            
            rdoSearchByIcon.FlatStyle = FlatStyle.System
            rdoSearchByText.FlatStyle = FlatStyle.System
            
        End If 

        SetBackcolors() 

        Label1.Text = "" 'not correct now, includes titles
        txtSearchString.Multiline = False 

        TreeView1.ImageList = mTreeviewSelect.ImageList
        
        pnlIcon.Top = 32
        pnlIcon.Left = 8
        pnlText.Left = 8

        lblIconSelect.ImageList = Res.ilTreeIcons
        ToolBar1.ImageList = Res.ilTreeIcons
         
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

        llngNewFormHeight = Me.Height

        If InStrGet(mstrCaption.ToUpper, "TRIAL") > 0 Then 
            Dim lintArrInc As Integer
            For lintArrInc = 16 To ToolBar1.ImageList.Images.Count
                ToolBar1.Buttons.Item(lintArrInc).Enabled = False
            Next lintArrInc
            lblExtraIcons.Tag = "VISIBLE"
        End If

        llngIconPanelTop = Panel1.Top

        Me.Panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left))

        lblIconSelect.ImageIndex = 0
        Me.Height = 360 '304        
        Me.MinimumSize = New System.Drawing.Size(360, 360)

        TreeView1.Height = 147
        

        txtSearchString.Select() 

        lblExtraIcons.TextAlign = ContentAlignment.MiddleLeft 

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        'If lstResults.SelectedItems.Count = 0 Then
        '    Exit Sub
        'End If
        
        If TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        'Dim lstrTag As String = lstResultCodes.Items.Item(lstResults.SelectedIndex)
        Dim lstrTag As String = TreeView1.SelectedNode.Tag 
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ' Allocate enough space to indicate that ALL nodes are checked.
        cNodes = mTreeviewSelect.GetNodeCount(True)

        ReDim ndxs(cNodes)
        GetNodes(mTreeviewSelect.Nodes(0), ndxs, curNode, False)

        ' Shrink the array to just the # of selected nodes.
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            If n.Tag = lstrTag Then
                'mViewSetting = frmPad.DocumentViews.NormalTopic 
                'FindInDB, doesn't select branch properly
                ''mTreeviewSelect.SelectedNode = n
                
                'main.SelectNodeByTag(lstrTag, mTreeviewSelect)
                mTopicCode = lstrTag 
                Me.Close() 
                Exit For
            End If
        Next
        TopicCode = "" 
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub lstResults_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        btnSelect_Click(Nothing, Nothing)
    End Sub
    Private Sub txtSearchString_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchString.KeyDown

        If e.KeyCode = Keys.Enter Then 
            btnFind_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        

    End Sub
    Private Sub txtSearchString_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchString.KeyPress
        
        If e.KeyChar = CR() Then
            e.Handled = True
        End If

    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnClose.Enabled = pbool
        btnFind.Enabled = pbool
        btnSelect.Enabled = pbool

    End Sub
    Private Sub btnChangeIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeIcon.Click

        'TreeView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top) _
        '            Or System.Windows.Forms.AnchorStyles.Left) _
        '            Or System.Windows.Forms.AnchorStyles.Right)

        'copied from RTFStand
        Me.Height = llngNewFormHeight

        'TreeView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        '                    Or System.Windows.Forms.AnchorStyles.Left) _
        '                    Or System.Windows.Forms.AnchorStyles.Right)

        ''btnHide.Visible = True
        btnChangeIcon.Enabled = False

        Panel1.Visible = True 
        Label3.Visible = True 

        If lblExtraIcons.Tag = "VISIBLE" Then
            lblExtraIcons.Visible = True
        End If

        'Panel1.Top = (llngNewFormHeight - 304) + llngIconPanelTop
        'TreeView1.Height = Panel1.Top - 29


        Me.MinimumSize = New System.Drawing.Size(360, 360 + (llngNewFormHeight - 360))
        TreeView1.Height = 147
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        'copied from RTFStand
        lblIconSelect.ImageIndex = e.Button.ImageIndex

    End Sub
    Private Sub rdoSearchByText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSearchByText.CheckedChanged
        If rdoSearchByText.Checked = True Then
            Me.MinimumSize = New System.Drawing.Size(360, 360)
            
            pnlText.Visible = True
            pnlIcon.Visible = False

            Panel1.Visible = False
            '--- Hide ---
            'copied from RTFStand
            Me.Height = 360 '304 

            TreeView1.Height = 147

            ''btnHide.Visible = False
            btnChangeIcon.Enabled = True
            Label3.Visible = False 

            If lblExtraIcons.Tag = "VISIBLE" Then
                lblExtraIcons.Visible = False
            End If
            '--- Hide ---

        End If
    End Sub
    Private Sub rdoSearchByIcon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSearchByIcon.CheckedChanged
        If rdoSearchByIcon.Checked = True Then
            
            pnlIcon.Visible = True
            pnlText.Visible = False
        End If

    End Sub
    Private Sub btnFindByIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFindByIcon.Click
        'function copied from main search button

        BusyButtons(True)
        Busy(Me, True)

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim llngRecCount As Long
        Dim lstrSQL As String

        Try

            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            
            Dim lstrOrderBy As String
            If gstrSortOrder = "ALPHA" Then
                lstrOrderBy = " ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
                "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Title;"
            Else
                lstrOrderBy = " ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
                "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), SeqNum, Title;"
            End If

            'lstrSQL = "SELECT TopicCode AS tc, Title, ImgIdx FROM Topics where ImgIdx=" & lblIconSelect.ImageIndex & lstrOrderBy
            

            
            'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
            'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
            Dim lintImgTag As Integer = IPIconsPack.GetImgTag(lblIconSelect.ImageIndex)
            lstrSQL = "SELECT TopicCode AS tc, Title, ImgIdx FROM Topics where ImgIdx=" & lintImgTag & lstrOrderBy
            
            gstrLastSQL = lstrSQL 

            lsnaLists.Open(lstrSQL, _
                lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            With lsnaLists
                llngRecCount = 0
                Do While Not .EOF

                    Dim tnNew As New TreeNode()
                    tnNew.Text = .Fields("Title").Value & ""
                    tnNew.Tag = .Fields("tc").Value & ""
                    'tnNew.ImageIndex = .Fields("ImgIdx").Value
                    'tnNew.SelectedImageIndex = .Fields("ImgIdx").Value
                    
                    'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                    'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                    Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
                    tnNew.ImageIndex = lintImgIdx
                    tnNew.SelectedImageIndex = lintImgIdx
                    
                    TreeView1.Nodes.Add(tnNew)

                    .MoveNext()
                Loop
            End With

            If llngRecCount = 0 Then
            End If

            lsnaLists.Close()
            lcnn1.Close()

            TreeView1.EndUpdate()

        Catch ex As Exception
            Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
            Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        End Try

        BusyButtons(False)
        Busy(Me, False)

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)
        btnSelect.BackColor = Color.FromArgb(0, btnSelect.BackColor)
        pnlText.BackColor = Color.FromArgb(0, pnlText.BackColor)
        pnlIcon.BackColor = Color.FromArgb(0, pnlIcon.BackColor)
        btnFind.BackColor = Color.FromArgb(0, btnFind.BackColor)
        lblSearchBy.BackColor = Color.FromArgb(0, lblSearchBy.BackColor)
        rdoSearchByIcon.BackColor = Color.FromArgb(0, rdoSearchByIcon.BackColor)
        rdoSearchByText.BackColor = Color.FromArgb(0, rdoSearchByText.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        'Added 
        If IsAboveOrEqualWinXp() = True Then
            'rdoSearchByIcon.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoSearchByIcon.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoSearchByIcon.Top, rdoSearchByIcon.Left, rdoSearchByIcon.Width, rdoSearchByIcon.Height)
            'rdoSearchByText.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            'rdoSearchByText.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoSearchByText.Top, rdoSearchByText.Left, rdoSearchByText.Width, rdoSearchByText.Height)
        End If

    End Sub

    Private Sub findindb_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class