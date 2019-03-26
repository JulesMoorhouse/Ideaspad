Friend Class branchprops
    Inherits System.Windows.Forms.Form
    Dim mstrImageListObj As ImageList
#Region " Windows Form Designer generated code "

    Friend Sub New(ByVal pImageList As ImageList)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        mstrImageListObj = pImageList
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
    Friend WithEvents txtSeqNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBranchName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As AppBasic.TabPagePaintEv
    Friend WithEvents lblIconSelect As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton19 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton20 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton21 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton22 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton23 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton24 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton25 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton26 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton27 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton28 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton29 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton30 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton31 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton32 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton33 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton34 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton35 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolBarButton36 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton37 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton38 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton39 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton40 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblExtraIcons As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(branchprops))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New AppBasic.TabPagePaintEv()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBranchName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeqNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New AppBasic.TabPagePaintEv()
        Me.lblExtraIcons = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.lblIconSelect = New System.Windows.Forms.Label()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton19 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton20 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton21 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton22 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton23 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton24 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton25 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton26 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton27 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton28 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton29 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton30 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton31 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton32 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton33 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton34 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton35 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton36 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton37 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton38 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton39 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton40 = New System.Windows.Forms.ToolBarButton()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2})
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
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.lblBranchName, Me.Label3, Me.Label2, Me.txtSeqNum, Me.Label1})
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
        'Label4
        '
        Me.Label4.AccessibleDescription = CType(resources.GetObject("Label4.AccessibleDescription"), String)
        Me.Label4.AccessibleName = CType(resources.GetObject("Label4.AccessibleName"), String)
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
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
        'lblBranchName
        '
        Me.lblBranchName.AccessibleDescription = CType(resources.GetObject("lblBranchName.AccessibleDescription"), String)
        Me.lblBranchName.AccessibleName = CType(resources.GetObject("lblBranchName.AccessibleName"), String)
        Me.lblBranchName.Anchor = CType(resources.GetObject("lblBranchName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBranchName.AutoSize = CType(resources.GetObject("lblBranchName.AutoSize"), Boolean)
        Me.lblBranchName.Dock = CType(resources.GetObject("lblBranchName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBranchName.Enabled = CType(resources.GetObject("lblBranchName.Enabled"), Boolean)
        Me.lblBranchName.Font = CType(resources.GetObject("lblBranchName.Font"), System.Drawing.Font)
        Me.lblBranchName.Image = CType(resources.GetObject("lblBranchName.Image"), System.Drawing.Image)
        Me.lblBranchName.ImageAlign = CType(resources.GetObject("lblBranchName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBranchName.ImageIndex = CType(resources.GetObject("lblBranchName.ImageIndex"), Integer)
        Me.lblBranchName.ImeMode = CType(resources.GetObject("lblBranchName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBranchName.Location = CType(resources.GetObject("lblBranchName.Location"), System.Drawing.Point)
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.RightToLeft = CType(resources.GetObject("lblBranchName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBranchName.Size = CType(resources.GetObject("lblBranchName.Size"), System.Drawing.Size)
        Me.lblBranchName.TabIndex = CType(resources.GetObject("lblBranchName.TabIndex"), Integer)
        Me.lblBranchName.Text = resources.GetString("lblBranchName.Text")
        Me.lblBranchName.TextAlign = CType(resources.GetObject("lblBranchName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBranchName.Visible = CType(resources.GetObject("lblBranchName.Visible"), Boolean)
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
        'txtSeqNum
        '
        Me.txtSeqNum.AccessibleDescription = CType(resources.GetObject("txtSeqNum.AccessibleDescription"), String)
        Me.txtSeqNum.AccessibleName = CType(resources.GetObject("txtSeqNum.AccessibleName"), String)
        Me.txtSeqNum.Anchor = CType(resources.GetObject("txtSeqNum.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtSeqNum.AutoSize = CType(resources.GetObject("txtSeqNum.AutoSize"), Boolean)
        Me.txtSeqNum.BackgroundImage = CType(resources.GetObject("txtSeqNum.BackgroundImage"), System.Drawing.Image)
        Me.txtSeqNum.Dock = CType(resources.GetObject("txtSeqNum.Dock"), System.Windows.Forms.DockStyle)
        Me.txtSeqNum.Enabled = CType(resources.GetObject("txtSeqNum.Enabled"), Boolean)
        Me.txtSeqNum.Font = CType(resources.GetObject("txtSeqNum.Font"), System.Drawing.Font)
        Me.txtSeqNum.ImeMode = CType(resources.GetObject("txtSeqNum.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtSeqNum.Location = CType(resources.GetObject("txtSeqNum.Location"), System.Drawing.Point)
        Me.txtSeqNum.MaxLength = CType(resources.GetObject("txtSeqNum.MaxLength"), Integer)
        Me.txtSeqNum.Multiline = CType(resources.GetObject("txtSeqNum.Multiline"), Boolean)
        Me.txtSeqNum.Name = "txtSeqNum"
        Me.txtSeqNum.PasswordChar = CType(resources.GetObject("txtSeqNum.PasswordChar"), Char)
        Me.txtSeqNum.RightToLeft = CType(resources.GetObject("txtSeqNum.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtSeqNum.ScrollBars = CType(resources.GetObject("txtSeqNum.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtSeqNum.Size = CType(resources.GetObject("txtSeqNum.Size"), System.Drawing.Size)
        Me.txtSeqNum.TabIndex = CType(resources.GetObject("txtSeqNum.TabIndex"), Integer)
        Me.txtSeqNum.Text = resources.GetString("txtSeqNum.Text")
        Me.txtSeqNum.TextAlign = CType(resources.GetObject("txtSeqNum.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtSeqNum.Visible = CType(resources.GetObject("txtSeqNum.Visible"), Boolean)
        Me.txtSeqNum.WordWrap = CType(resources.GetObject("txtSeqNum.WordWrap"), Boolean)
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
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = CType(resources.GetObject("TabPage2.AccessibleDescription"), String)
        Me.TabPage2.AccessibleName = CType(resources.GetObject("TabPage2.AccessibleName"), String)
        Me.TabPage2.Anchor = CType(resources.GetObject("TabPage2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage2.AutoScroll = CType(resources.GetObject("TabPage2.AutoScroll"), Boolean)
        Me.TabPage2.AutoScrollMargin = CType(resources.GetObject("TabPage2.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage2.AutoScrollMinSize = CType(resources.GetObject("TabPage2.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblExtraIcons, Me.Label5, Me.Panel1, Me.lblIconSelect})
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
        'ToolBarButton1
        '
        Me.ToolBarButton1.Enabled = CType(resources.GetObject("ToolBarButton1.Enabled"), Boolean)
        Me.ToolBarButton1.ImageIndex = CType(resources.GetObject("ToolBarButton1.ImageIndex"), Integer)
        Me.ToolBarButton1.Text = resources.GetString("ToolBarButton1.Text")
        Me.ToolBarButton1.ToolTipText = resources.GetString("ToolBarButton1.ToolTipText")
        Me.ToolBarButton1.Visible = CType(resources.GetObject("ToolBarButton1.Visible"), Boolean)
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Enabled = CType(resources.GetObject("ToolBarButton2.Enabled"), Boolean)
        Me.ToolBarButton2.ImageIndex = CType(resources.GetObject("ToolBarButton2.ImageIndex"), Integer)
        Me.ToolBarButton2.Text = resources.GetString("ToolBarButton2.Text")
        Me.ToolBarButton2.ToolTipText = resources.GetString("ToolBarButton2.ToolTipText")
        Me.ToolBarButton2.Visible = CType(resources.GetObject("ToolBarButton2.Visible"), Boolean)
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Enabled = CType(resources.GetObject("ToolBarButton3.Enabled"), Boolean)
        Me.ToolBarButton3.ImageIndex = CType(resources.GetObject("ToolBarButton3.ImageIndex"), Integer)
        Me.ToolBarButton3.Text = resources.GetString("ToolBarButton3.Text")
        Me.ToolBarButton3.ToolTipText = resources.GetString("ToolBarButton3.ToolTipText")
        Me.ToolBarButton3.Visible = CType(resources.GetObject("ToolBarButton3.Visible"), Boolean)
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Enabled = CType(resources.GetObject("ToolBarButton4.Enabled"), Boolean)
        Me.ToolBarButton4.ImageIndex = CType(resources.GetObject("ToolBarButton4.ImageIndex"), Integer)
        Me.ToolBarButton4.Text = resources.GetString("ToolBarButton4.Text")
        Me.ToolBarButton4.ToolTipText = resources.GetString("ToolBarButton4.ToolTipText")
        Me.ToolBarButton4.Visible = CType(resources.GetObject("ToolBarButton4.Visible"), Boolean)
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Enabled = CType(resources.GetObject("ToolBarButton5.Enabled"), Boolean)
        Me.ToolBarButton5.ImageIndex = CType(resources.GetObject("ToolBarButton5.ImageIndex"), Integer)
        Me.ToolBarButton5.Text = resources.GetString("ToolBarButton5.Text")
        Me.ToolBarButton5.ToolTipText = resources.GetString("ToolBarButton5.ToolTipText")
        Me.ToolBarButton5.Visible = CType(resources.GetObject("ToolBarButton5.Visible"), Boolean)
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Enabled = CType(resources.GetObject("ToolBarButton6.Enabled"), Boolean)
        Me.ToolBarButton6.ImageIndex = CType(resources.GetObject("ToolBarButton6.ImageIndex"), Integer)
        Me.ToolBarButton6.Text = resources.GetString("ToolBarButton6.Text")
        Me.ToolBarButton6.ToolTipText = resources.GetString("ToolBarButton6.ToolTipText")
        Me.ToolBarButton6.Visible = CType(resources.GetObject("ToolBarButton6.Visible"), Boolean)
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Enabled = CType(resources.GetObject("ToolBarButton7.Enabled"), Boolean)
        Me.ToolBarButton7.ImageIndex = CType(resources.GetObject("ToolBarButton7.ImageIndex"), Integer)
        Me.ToolBarButton7.Text = resources.GetString("ToolBarButton7.Text")
        Me.ToolBarButton7.ToolTipText = resources.GetString("ToolBarButton7.ToolTipText")
        Me.ToolBarButton7.Visible = CType(resources.GetObject("ToolBarButton7.Visible"), Boolean)
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Enabled = CType(resources.GetObject("ToolBarButton8.Enabled"), Boolean)
        Me.ToolBarButton8.ImageIndex = CType(resources.GetObject("ToolBarButton8.ImageIndex"), Integer)
        Me.ToolBarButton8.Text = resources.GetString("ToolBarButton8.Text")
        Me.ToolBarButton8.ToolTipText = resources.GetString("ToolBarButton8.ToolTipText")
        Me.ToolBarButton8.Visible = CType(resources.GetObject("ToolBarButton8.Visible"), Boolean)
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.Enabled = CType(resources.GetObject("ToolBarButton9.Enabled"), Boolean)
        Me.ToolBarButton9.ImageIndex = CType(resources.GetObject("ToolBarButton9.ImageIndex"), Integer)
        Me.ToolBarButton9.Text = resources.GetString("ToolBarButton9.Text")
        Me.ToolBarButton9.ToolTipText = resources.GetString("ToolBarButton9.ToolTipText")
        Me.ToolBarButton9.Visible = CType(resources.GetObject("ToolBarButton9.Visible"), Boolean)
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Enabled = CType(resources.GetObject("ToolBarButton10.Enabled"), Boolean)
        Me.ToolBarButton10.ImageIndex = CType(resources.GetObject("ToolBarButton10.ImageIndex"), Integer)
        Me.ToolBarButton10.Text = resources.GetString("ToolBarButton10.Text")
        Me.ToolBarButton10.ToolTipText = resources.GetString("ToolBarButton10.ToolTipText")
        Me.ToolBarButton10.Visible = CType(resources.GetObject("ToolBarButton10.Visible"), Boolean)
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.Enabled = CType(resources.GetObject("ToolBarButton11.Enabled"), Boolean)
        Me.ToolBarButton11.ImageIndex = CType(resources.GetObject("ToolBarButton11.ImageIndex"), Integer)
        Me.ToolBarButton11.Text = resources.GetString("ToolBarButton11.Text")
        Me.ToolBarButton11.ToolTipText = resources.GetString("ToolBarButton11.ToolTipText")
        Me.ToolBarButton11.Visible = CType(resources.GetObject("ToolBarButton11.Visible"), Boolean)
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Enabled = CType(resources.GetObject("ToolBarButton12.Enabled"), Boolean)
        Me.ToolBarButton12.ImageIndex = CType(resources.GetObject("ToolBarButton12.ImageIndex"), Integer)
        Me.ToolBarButton12.Text = resources.GetString("ToolBarButton12.Text")
        Me.ToolBarButton12.ToolTipText = resources.GetString("ToolBarButton12.ToolTipText")
        Me.ToolBarButton12.Visible = CType(resources.GetObject("ToolBarButton12.Visible"), Boolean)
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.Enabled = CType(resources.GetObject("ToolBarButton13.Enabled"), Boolean)
        Me.ToolBarButton13.ImageIndex = CType(resources.GetObject("ToolBarButton13.ImageIndex"), Integer)
        Me.ToolBarButton13.Text = resources.GetString("ToolBarButton13.Text")
        Me.ToolBarButton13.ToolTipText = resources.GetString("ToolBarButton13.ToolTipText")
        Me.ToolBarButton13.Visible = CType(resources.GetObject("ToolBarButton13.Visible"), Boolean)
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.Enabled = CType(resources.GetObject("ToolBarButton14.Enabled"), Boolean)
        Me.ToolBarButton14.ImageIndex = CType(resources.GetObject("ToolBarButton14.ImageIndex"), Integer)
        Me.ToolBarButton14.Text = resources.GetString("ToolBarButton14.Text")
        Me.ToolBarButton14.ToolTipText = resources.GetString("ToolBarButton14.ToolTipText")
        Me.ToolBarButton14.Visible = CType(resources.GetObject("ToolBarButton14.Visible"), Boolean)
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.Enabled = CType(resources.GetObject("ToolBarButton15.Enabled"), Boolean)
        Me.ToolBarButton15.ImageIndex = CType(resources.GetObject("ToolBarButton15.ImageIndex"), Integer)
        Me.ToolBarButton15.Text = resources.GetString("ToolBarButton15.Text")
        Me.ToolBarButton15.ToolTipText = resources.GetString("ToolBarButton15.ToolTipText")
        Me.ToolBarButton15.Visible = CType(resources.GetObject("ToolBarButton15.Visible"), Boolean)
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.Enabled = CType(resources.GetObject("ToolBarButton16.Enabled"), Boolean)
        Me.ToolBarButton16.ImageIndex = CType(resources.GetObject("ToolBarButton16.ImageIndex"), Integer)
        Me.ToolBarButton16.Text = resources.GetString("ToolBarButton16.Text")
        Me.ToolBarButton16.ToolTipText = resources.GetString("ToolBarButton16.ToolTipText")
        Me.ToolBarButton16.Visible = CType(resources.GetObject("ToolBarButton16.Visible"), Boolean)
        '
        'ToolBarButton17
        '
        Me.ToolBarButton17.Enabled = CType(resources.GetObject("ToolBarButton17.Enabled"), Boolean)
        Me.ToolBarButton17.ImageIndex = CType(resources.GetObject("ToolBarButton17.ImageIndex"), Integer)
        Me.ToolBarButton17.Text = resources.GetString("ToolBarButton17.Text")
        Me.ToolBarButton17.ToolTipText = resources.GetString("ToolBarButton17.ToolTipText")
        Me.ToolBarButton17.Visible = CType(resources.GetObject("ToolBarButton17.Visible"), Boolean)
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.Enabled = CType(resources.GetObject("ToolBarButton18.Enabled"), Boolean)
        Me.ToolBarButton18.ImageIndex = CType(resources.GetObject("ToolBarButton18.ImageIndex"), Integer)
        Me.ToolBarButton18.Text = resources.GetString("ToolBarButton18.Text")
        Me.ToolBarButton18.ToolTipText = resources.GetString("ToolBarButton18.ToolTipText")
        Me.ToolBarButton18.Visible = CType(resources.GetObject("ToolBarButton18.Visible"), Boolean)
        '
        'ToolBarButton19
        '
        Me.ToolBarButton19.Enabled = CType(resources.GetObject("ToolBarButton19.Enabled"), Boolean)
        Me.ToolBarButton19.ImageIndex = CType(resources.GetObject("ToolBarButton19.ImageIndex"), Integer)
        Me.ToolBarButton19.Text = resources.GetString("ToolBarButton19.Text")
        Me.ToolBarButton19.ToolTipText = resources.GetString("ToolBarButton19.ToolTipText")
        Me.ToolBarButton19.Visible = CType(resources.GetObject("ToolBarButton19.Visible"), Boolean)
        '
        'ToolBarButton20
        '
        Me.ToolBarButton20.Enabled = CType(resources.GetObject("ToolBarButton20.Enabled"), Boolean)
        Me.ToolBarButton20.ImageIndex = CType(resources.GetObject("ToolBarButton20.ImageIndex"), Integer)
        Me.ToolBarButton20.Text = resources.GetString("ToolBarButton20.Text")
        Me.ToolBarButton20.ToolTipText = resources.GetString("ToolBarButton20.ToolTipText")
        Me.ToolBarButton20.Visible = CType(resources.GetObject("ToolBarButton20.Visible"), Boolean)
        '
        'ToolBarButton21
        '
        Me.ToolBarButton21.Enabled = CType(resources.GetObject("ToolBarButton21.Enabled"), Boolean)
        Me.ToolBarButton21.ImageIndex = CType(resources.GetObject("ToolBarButton21.ImageIndex"), Integer)
        Me.ToolBarButton21.Text = resources.GetString("ToolBarButton21.Text")
        Me.ToolBarButton21.ToolTipText = resources.GetString("ToolBarButton21.ToolTipText")
        Me.ToolBarButton21.Visible = CType(resources.GetObject("ToolBarButton21.Visible"), Boolean)
        '
        'ToolBarButton22
        '
        Me.ToolBarButton22.Enabled = CType(resources.GetObject("ToolBarButton22.Enabled"), Boolean)
        Me.ToolBarButton22.ImageIndex = CType(resources.GetObject("ToolBarButton22.ImageIndex"), Integer)
        Me.ToolBarButton22.Text = resources.GetString("ToolBarButton22.Text")
        Me.ToolBarButton22.ToolTipText = resources.GetString("ToolBarButton22.ToolTipText")
        Me.ToolBarButton22.Visible = CType(resources.GetObject("ToolBarButton22.Visible"), Boolean)
        '
        'ToolBarButton23
        '
        Me.ToolBarButton23.Enabled = CType(resources.GetObject("ToolBarButton23.Enabled"), Boolean)
        Me.ToolBarButton23.ImageIndex = CType(resources.GetObject("ToolBarButton23.ImageIndex"), Integer)
        Me.ToolBarButton23.Text = resources.GetString("ToolBarButton23.Text")
        Me.ToolBarButton23.ToolTipText = resources.GetString("ToolBarButton23.ToolTipText")
        Me.ToolBarButton23.Visible = CType(resources.GetObject("ToolBarButton23.Visible"), Boolean)
        '
        'ToolBarButton24
        '
        Me.ToolBarButton24.Enabled = CType(resources.GetObject("ToolBarButton24.Enabled"), Boolean)
        Me.ToolBarButton24.ImageIndex = CType(resources.GetObject("ToolBarButton24.ImageIndex"), Integer)
        Me.ToolBarButton24.Text = resources.GetString("ToolBarButton24.Text")
        Me.ToolBarButton24.ToolTipText = resources.GetString("ToolBarButton24.ToolTipText")
        Me.ToolBarButton24.Visible = CType(resources.GetObject("ToolBarButton24.Visible"), Boolean)
        '
        'ToolBarButton25
        '
        Me.ToolBarButton25.Enabled = CType(resources.GetObject("ToolBarButton25.Enabled"), Boolean)
        Me.ToolBarButton25.ImageIndex = CType(resources.GetObject("ToolBarButton25.ImageIndex"), Integer)
        Me.ToolBarButton25.Text = resources.GetString("ToolBarButton25.Text")
        Me.ToolBarButton25.ToolTipText = resources.GetString("ToolBarButton25.ToolTipText")
        Me.ToolBarButton25.Visible = CType(resources.GetObject("ToolBarButton25.Visible"), Boolean)
        '
        'ToolBarButton26
        '
        Me.ToolBarButton26.Enabled = CType(resources.GetObject("ToolBarButton26.Enabled"), Boolean)
        Me.ToolBarButton26.ImageIndex = CType(resources.GetObject("ToolBarButton26.ImageIndex"), Integer)
        Me.ToolBarButton26.Text = resources.GetString("ToolBarButton26.Text")
        Me.ToolBarButton26.ToolTipText = resources.GetString("ToolBarButton26.ToolTipText")
        Me.ToolBarButton26.Visible = CType(resources.GetObject("ToolBarButton26.Visible"), Boolean)
        '
        'ToolBarButton27
        '
        Me.ToolBarButton27.Enabled = CType(resources.GetObject("ToolBarButton27.Enabled"), Boolean)
        Me.ToolBarButton27.ImageIndex = CType(resources.GetObject("ToolBarButton27.ImageIndex"), Integer)
        Me.ToolBarButton27.Text = resources.GetString("ToolBarButton27.Text")
        Me.ToolBarButton27.ToolTipText = resources.GetString("ToolBarButton27.ToolTipText")
        Me.ToolBarButton27.Visible = CType(resources.GetObject("ToolBarButton27.Visible"), Boolean)
        '
        'ToolBarButton28
        '
        Me.ToolBarButton28.Enabled = CType(resources.GetObject("ToolBarButton28.Enabled"), Boolean)
        Me.ToolBarButton28.ImageIndex = CType(resources.GetObject("ToolBarButton28.ImageIndex"), Integer)
        Me.ToolBarButton28.Text = resources.GetString("ToolBarButton28.Text")
        Me.ToolBarButton28.ToolTipText = resources.GetString("ToolBarButton28.ToolTipText")
        Me.ToolBarButton28.Visible = CType(resources.GetObject("ToolBarButton28.Visible"), Boolean)
        '
        'ToolBarButton29
        '
        Me.ToolBarButton29.Enabled = CType(resources.GetObject("ToolBarButton29.Enabled"), Boolean)
        Me.ToolBarButton29.ImageIndex = CType(resources.GetObject("ToolBarButton29.ImageIndex"), Integer)
        Me.ToolBarButton29.Text = resources.GetString("ToolBarButton29.Text")
        Me.ToolBarButton29.ToolTipText = resources.GetString("ToolBarButton29.ToolTipText")
        Me.ToolBarButton29.Visible = CType(resources.GetObject("ToolBarButton29.Visible"), Boolean)
        '
        'ToolBarButton30
        '
        Me.ToolBarButton30.Enabled = CType(resources.GetObject("ToolBarButton30.Enabled"), Boolean)
        Me.ToolBarButton30.ImageIndex = CType(resources.GetObject("ToolBarButton30.ImageIndex"), Integer)
        Me.ToolBarButton30.Text = resources.GetString("ToolBarButton30.Text")
        Me.ToolBarButton30.ToolTipText = resources.GetString("ToolBarButton30.ToolTipText")
        Me.ToolBarButton30.Visible = CType(resources.GetObject("ToolBarButton30.Visible"), Boolean)
        '
        'ToolBarButton31
        '
        Me.ToolBarButton31.Enabled = CType(resources.GetObject("ToolBarButton31.Enabled"), Boolean)
        Me.ToolBarButton31.ImageIndex = CType(resources.GetObject("ToolBarButton31.ImageIndex"), Integer)
        Me.ToolBarButton31.Text = resources.GetString("ToolBarButton31.Text")
        Me.ToolBarButton31.ToolTipText = resources.GetString("ToolBarButton31.ToolTipText")
        Me.ToolBarButton31.Visible = CType(resources.GetObject("ToolBarButton31.Visible"), Boolean)
        '
        'ToolBarButton32
        '
        Me.ToolBarButton32.Enabled = CType(resources.GetObject("ToolBarButton32.Enabled"), Boolean)
        Me.ToolBarButton32.ImageIndex = CType(resources.GetObject("ToolBarButton32.ImageIndex"), Integer)
        Me.ToolBarButton32.Text = resources.GetString("ToolBarButton32.Text")
        Me.ToolBarButton32.ToolTipText = resources.GetString("ToolBarButton32.ToolTipText")
        Me.ToolBarButton32.Visible = CType(resources.GetObject("ToolBarButton32.Visible"), Boolean)
        '
        'ToolBarButton33
        '
        Me.ToolBarButton33.Enabled = CType(resources.GetObject("ToolBarButton33.Enabled"), Boolean)
        Me.ToolBarButton33.ImageIndex = CType(resources.GetObject("ToolBarButton33.ImageIndex"), Integer)
        Me.ToolBarButton33.Text = resources.GetString("ToolBarButton33.Text")
        Me.ToolBarButton33.ToolTipText = resources.GetString("ToolBarButton33.ToolTipText")
        Me.ToolBarButton33.Visible = CType(resources.GetObject("ToolBarButton33.Visible"), Boolean)
        '
        'ToolBarButton34
        '
        Me.ToolBarButton34.Enabled = CType(resources.GetObject("ToolBarButton34.Enabled"), Boolean)
        Me.ToolBarButton34.ImageIndex = CType(resources.GetObject("ToolBarButton34.ImageIndex"), Integer)
        Me.ToolBarButton34.Text = resources.GetString("ToolBarButton34.Text")
        Me.ToolBarButton34.ToolTipText = resources.GetString("ToolBarButton34.ToolTipText")
        Me.ToolBarButton34.Visible = CType(resources.GetObject("ToolBarButton34.Visible"), Boolean)
        '
        'ToolBarButton35
        '
        Me.ToolBarButton35.Enabled = CType(resources.GetObject("ToolBarButton35.Enabled"), Boolean)
        Me.ToolBarButton35.ImageIndex = CType(resources.GetObject("ToolBarButton35.ImageIndex"), Integer)
        Me.ToolBarButton35.Text = resources.GetString("ToolBarButton35.Text")
        Me.ToolBarButton35.ToolTipText = resources.GetString("ToolBarButton35.ToolTipText")
        Me.ToolBarButton35.Visible = CType(resources.GetObject("ToolBarButton35.Visible"), Boolean)
        '
        'ToolBarButton36
        '
        Me.ToolBarButton36.Enabled = CType(resources.GetObject("ToolBarButton36.Enabled"), Boolean)
        Me.ToolBarButton36.ImageIndex = CType(resources.GetObject("ToolBarButton36.ImageIndex"), Integer)
        Me.ToolBarButton36.Text = resources.GetString("ToolBarButton36.Text")
        Me.ToolBarButton36.ToolTipText = resources.GetString("ToolBarButton36.ToolTipText")
        Me.ToolBarButton36.Visible = CType(resources.GetObject("ToolBarButton36.Visible"), Boolean)
        '
        'ToolBarButton37
        '
        Me.ToolBarButton37.Enabled = CType(resources.GetObject("ToolBarButton37.Enabled"), Boolean)
        Me.ToolBarButton37.ImageIndex = CType(resources.GetObject("ToolBarButton37.ImageIndex"), Integer)
        Me.ToolBarButton37.Text = resources.GetString("ToolBarButton37.Text")
        Me.ToolBarButton37.ToolTipText = resources.GetString("ToolBarButton37.ToolTipText")
        Me.ToolBarButton37.Visible = CType(resources.GetObject("ToolBarButton37.Visible"), Boolean)
        '
        'ToolBarButton38
        '
        Me.ToolBarButton38.Enabled = CType(resources.GetObject("ToolBarButton38.Enabled"), Boolean)
        Me.ToolBarButton38.ImageIndex = CType(resources.GetObject("ToolBarButton38.ImageIndex"), Integer)
        Me.ToolBarButton38.Text = resources.GetString("ToolBarButton38.Text")
        Me.ToolBarButton38.ToolTipText = resources.GetString("ToolBarButton38.ToolTipText")
        Me.ToolBarButton38.Visible = CType(resources.GetObject("ToolBarButton38.Visible"), Boolean)
        '
        'ToolBarButton39
        '
        Me.ToolBarButton39.Enabled = CType(resources.GetObject("ToolBarButton39.Enabled"), Boolean)
        Me.ToolBarButton39.ImageIndex = CType(resources.GetObject("ToolBarButton39.ImageIndex"), Integer)
        Me.ToolBarButton39.Text = resources.GetString("ToolBarButton39.Text")
        Me.ToolBarButton39.ToolTipText = resources.GetString("ToolBarButton39.ToolTipText")
        Me.ToolBarButton39.Visible = CType(resources.GetObject("ToolBarButton39.Visible"), Boolean)
        '
        'ToolBarButton40
        '
        Me.ToolBarButton40.Enabled = CType(resources.GetObject("ToolBarButton40.Enabled"), Boolean)
        Me.ToolBarButton40.ImageIndex = CType(resources.GetObject("ToolBarButton40.ImageIndex"), Integer)
        Me.ToolBarButton40.Text = resources.GetString("ToolBarButton40.Text")
        Me.ToolBarButton40.ToolTipText = resources.GetString("ToolBarButton40.ToolTipText")
        Me.ToolBarButton40.Visible = CType(resources.GetObject("ToolBarButton40.Visible"), Boolean)
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
        'branchprops
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
        Me.Name = "branchprops"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mstrTopicCode As String
    Dim mlngSelectedImgIdx As Long
    Dim lbooAppyUsed As Boolean = False 
    Dim mstrB4BranchSeqNum As String 
    Dim mstrAFBranchSeqNum As String 
    Private Function GetSeqNum(ByVal pstrTopic As String) As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String

        Dim RetVal As String 

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:GetSeqNum")

        lstrSQL = "Select SeqNum from Topics where TopicCode='" & pstrTopic & "';"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists
            If Not .EOF Then
                'GetSeqNum = .Fields("SeqNum").Value & ""
                RetVal = .Fields("SeqNum").Value & ""
            End If
        End With

        If RetVal = "" Then RetVal = 0

        mstrB4BranchSeqNum = RetVal 
        mstrAFBranchSeqNum = RetVal 

        lsnaLists.Close()
        lcnn1.Close()

        Return RetVal

    End Function
    Friend Property TopicCode() As String
        Get
            Return mstrTopicCode
        End Get
        Set(ByVal Value As String)
            mstrTopicCode = Value
        End Set
    End Property
    Friend WriteOnly Property TopicName() As String
        Set(ByVal Value As String)
            lblBranchName.Text = Value
        End Set
    End Property
    Friend Property SelectedImgIdx() As Long
        Get
            Return mlngSelectedImgIdx
        End Get
        Set(ByVal Value As Long)
            mlngSelectedImgIdx = Value
        End Set
    End Property
    
    Friend Property B4BranchSeqNum() As Long
        Get
            Return mstrB4BranchSeqNum
        End Get
        Set(ByVal Value As Long)
            mstrB4BranchSeqNum = Value
        End Set
    End Property
    Friend Property AFBranchSeqNum() As Long
        Get
            Return mstrAFBranchSeqNum
        End Get
        Set(ByVal Value As Long)
            mstrAFBranchSeqNum = Value
        End Set
    End Property
    
    Private Sub UpdatePropertiesNum()

        
        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
        Dim lintImgTag As Integer = IPIconsPack.GetImgTag(mlngSelectedImgIdx)
        
        Dim lcnn1 As New ADODB.Connection()

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:UpdatePropertiesNum")

        'lcnn1.Execute("update Topics set Seqnum=" & txtSeqNum.Text & " where TopicCode='" & mstrTopicCode & "';")
        '
        'lcnn1.Execute("update Topics set Seqnum=" & txtSeqNum.Text & _
        '    ", ImgIdx = " & mlngSelectedImgIdx & " where TopicCode='" & mstrTopicCode & "';")

        If txtSeqNum.Text = "" Then 
            txtSeqNum.Text = "0" 
        End If

        mstrAFBranchSeqNum = txtSeqNum.Text 

        Dim lstrSQL As String = "update Topics set Seqnum=" & txtSeqNum.Text & _
            ", ImgIdx = " & lintImgTag & " where TopicCode='" & mstrTopicCode & "';"
        gstrLastSQL = lstrSQL 

        
        lcnn1.Execute(lstrSQL)
        lcnn1.Close()

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        btnApply_Click(Nothing, Nothing) 
        DialogResult = DialogResult.OK

        Me.Close()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub
    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'If lblIconSelect.ImageIndex = (mstrImageListObj.Images.Count - 1) Then '36
        '    mlngSelectedImgIdx = 0
        'Else
        mlngSelectedImgIdx = lblIconSelect.ImageIndex
        'End If

        UpdatePropertiesNum()

        lbooAppyUsed = True 


    End Sub
    Private Sub branchprops_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnApply.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
        End If 
        

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
        End If
        

        
        If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 'Changed to Trial 
            Dim lintArrInc As Integer
            For lintArrInc = 16 To ToolBar1.ImageList.Images.Count '38
                ToolBar1.Buttons.Item(lintArrInc).Enabled = False
            Next lintArrInc
            lblExtraIcons.Visible = True
        End If
        

        'If mlngSelectedImgIdx = 0 Or mlngSelectedImgIdx = -1 Then
        If mlngSelectedImgIdx = -1 Then
            lblIconSelect.ImageIndex = 0 '(mstrImageListObj.Images.Count - 1) '36
        Else
            lblIconSelect.ImageIndex = mlngSelectedImgIdx
        End If

        txtSeqNum.Multiline = False 

        txtSeqNum.Text = GetSeqNum(mstrTopicCode)

        lblExtraIcons.TextAlign = ContentAlignment.MiddleLeft 

    End Sub
    Private Sub txtSeqNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeqNum.KeyPress

        If e.KeyChar = CR() Then 
            e.Handled = True 
        End If

        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsNumber(e.KeyChar) Then
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtSeqNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeqNum.KeyDown

        If e.KeyCode = Keys.Enter Then 
            If txtSeqNum.Text = "" Then 
                txtSeqNum.Text = "0" 
                txtSeqNum.SelectAll() 
            Else 
                btnOK_Click(Nothing, Nothing) 
            End If 
        End If

    End Sub
    Private Sub branchprops_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.branchprops)) 
    End Sub
    Private Sub branchprops_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtSeqNum.Focus()
        txtSeqNum.SelectAll()

    End Sub

    Private Sub txtSeqNum_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeqNum.MouseEnter
        'txtSeqNum.SelectAll()
    End Sub

    Private Sub txtSeqNum_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeqNum.Enter
        txtSeqNum.SelectAll()
    End Sub

    Private Sub txtSeqNum_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSeqNum.MouseDown
        txtSeqNum.SelectAll()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If ListView1.SelectedItems.Count = 0 Then
    '        Exit Sub

    '    End If

    '    lblIconSelect.ImageIndex = ListView1.SelectedItems(0).ImageIndex

    'End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        lblIconSelect.ImageIndex = e.Button.ImageIndex
    End Sub


    Private Sub branchprops_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If lbooAppyUsed = True Then
            DialogResult = DialogResult.OK 
        End If

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnApply.BackColor = Color.FromArgb(0, btnApply.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        TabControl1.BackColor = Color.FromArgb(0, TabControl1.BackColor)
        TabPage1.BackColor = Color.FromArgb(0, TabPage1.BackColor)
        TabPage2.BackColor = Color.FromArgb(0, TabPage2.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        Label5.BackColor = Color.FromArgb(0, Label5.BackColor)
        lblBranchName.BackColor = Color.FromArgb(0, lblBranchName.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub TabPage1_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage1.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage1.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage1.Width + 12, TabPage1.Height + 28)
        

    End Sub

    Private Sub TabPage2_TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As System.Windows.Forms.TabPage) Handles TabPage2.TabPagePaint

        
        Dim PaintBack As New UIStyle.Painting()
        TabPage1.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, TabControl1.Top + 20, TabControl1.Left + 3, TabPage2.Width + 12, TabPage2.Height + 28)
        

    End Sub

    Private Sub branchprops_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

End Class