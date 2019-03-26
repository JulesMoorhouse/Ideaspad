Imports mshtml
Friend Class TemplateSearch
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstTemplates As System.Windows.Forms.ListBox
    Friend WithEvents cboSearchField As System.Windows.Forms.ComboBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lstResultCodes As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCriteria As System.Windows.Forms.TextBox
    Friend WithEvents cboOperator As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSearch))
        Me.lstTemplates = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSearchField = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstResultCodes = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTemplates
        '
        Me.lstTemplates.AccessibleDescription = CType(resources.GetObject("lstTemplates.AccessibleDescription"), String)
        Me.lstTemplates.AccessibleName = CType(resources.GetObject("lstTemplates.AccessibleName"), String)
        Me.lstTemplates.Anchor = CType(resources.GetObject("lstTemplates.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstTemplates.BackgroundImage = CType(resources.GetObject("lstTemplates.BackgroundImage"), System.Drawing.Image)
        Me.lstTemplates.ColumnWidth = CType(resources.GetObject("lstTemplates.ColumnWidth"), Integer)
        Me.lstTemplates.Dock = CType(resources.GetObject("lstTemplates.Dock"), System.Windows.Forms.DockStyle)
        Me.lstTemplates.Enabled = CType(resources.GetObject("lstTemplates.Enabled"), Boolean)
        Me.lstTemplates.Font = CType(resources.GetObject("lstTemplates.Font"), System.Drawing.Font)
        Me.lstTemplates.HorizontalExtent = CType(resources.GetObject("lstTemplates.HorizontalExtent"), Integer)
        Me.lstTemplates.HorizontalScrollbar = CType(resources.GetObject("lstTemplates.HorizontalScrollbar"), Boolean)
        Me.lstTemplates.ImeMode = CType(resources.GetObject("lstTemplates.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstTemplates.IntegralHeight = CType(resources.GetObject("lstTemplates.IntegralHeight"), Boolean)
        Me.lstTemplates.ItemHeight = CType(resources.GetObject("lstTemplates.ItemHeight"), Integer)
        Me.lstTemplates.Location = CType(resources.GetObject("lstTemplates.Location"), System.Drawing.Point)
        Me.lstTemplates.Name = "lstTemplates"
        Me.lstTemplates.RightToLeft = CType(resources.GetObject("lstTemplates.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstTemplates.ScrollAlwaysVisible = CType(resources.GetObject("lstTemplates.ScrollAlwaysVisible"), Boolean)
        Me.lstTemplates.Size = CType(resources.GetObject("lstTemplates.Size"), System.Drawing.Size)
        Me.lstTemplates.TabIndex = CType(resources.GetObject("lstTemplates.TabIndex"), Integer)
        Me.lstTemplates.Visible = CType(resources.GetObject("lstTemplates.Visible"), Boolean)
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
        'cboSearchField
        '
        Me.cboSearchField.AccessibleDescription = CType(resources.GetObject("cboSearchField.AccessibleDescription"), String)
        Me.cboSearchField.AccessibleName = CType(resources.GetObject("cboSearchField.AccessibleName"), String)
        Me.cboSearchField.Anchor = CType(resources.GetObject("cboSearchField.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboSearchField.BackgroundImage = CType(resources.GetObject("cboSearchField.BackgroundImage"), System.Drawing.Image)
        Me.cboSearchField.Dock = CType(resources.GetObject("cboSearchField.Dock"), System.Windows.Forms.DockStyle)
        Me.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchField.Enabled = CType(resources.GetObject("cboSearchField.Enabled"), Boolean)
        Me.cboSearchField.Font = CType(resources.GetObject("cboSearchField.Font"), System.Drawing.Font)
        Me.cboSearchField.ImeMode = CType(resources.GetObject("cboSearchField.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboSearchField.IntegralHeight = CType(resources.GetObject("cboSearchField.IntegralHeight"), Boolean)
        Me.cboSearchField.ItemHeight = CType(resources.GetObject("cboSearchField.ItemHeight"), Integer)
        Me.cboSearchField.Location = CType(resources.GetObject("cboSearchField.Location"), System.Drawing.Point)
        Me.cboSearchField.MaxDropDownItems = CType(resources.GetObject("cboSearchField.MaxDropDownItems"), Integer)
        Me.cboSearchField.MaxLength = CType(resources.GetObject("cboSearchField.MaxLength"), Integer)
        Me.cboSearchField.Name = "cboSearchField"
        Me.cboSearchField.RightToLeft = CType(resources.GetObject("cboSearchField.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboSearchField.Size = CType(resources.GetObject("cboSearchField.Size"), System.Drawing.Size)
        Me.cboSearchField.TabIndex = CType(resources.GetObject("cboSearchField.TabIndex"), Integer)
        Me.cboSearchField.Text = resources.GetString("cboSearchField.Text")
        Me.cboSearchField.Visible = CType(resources.GetObject("cboSearchField.Visible"), Boolean)
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
        'lstResults
        '
        Me.lstResults.AccessibleDescription = CType(resources.GetObject("lstResults.AccessibleDescription"), String)
        Me.lstResults.AccessibleName = CType(resources.GetObject("lstResults.AccessibleName"), String)
        Me.lstResults.Anchor = CType(resources.GetObject("lstResults.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstResults.BackgroundImage = CType(resources.GetObject("lstResults.BackgroundImage"), System.Drawing.Image)
        Me.lstResults.ColumnWidth = CType(resources.GetObject("lstResults.ColumnWidth"), Integer)
        Me.lstResults.Dock = CType(resources.GetObject("lstResults.Dock"), System.Windows.Forms.DockStyle)
        Me.lstResults.Enabled = CType(resources.GetObject("lstResults.Enabled"), Boolean)
        Me.lstResults.Font = CType(resources.GetObject("lstResults.Font"), System.Drawing.Font)
        Me.lstResults.HorizontalExtent = CType(resources.GetObject("lstResults.HorizontalExtent"), Integer)
        Me.lstResults.HorizontalScrollbar = CType(resources.GetObject("lstResults.HorizontalScrollbar"), Boolean)
        Me.lstResults.ImeMode = CType(resources.GetObject("lstResults.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstResults.IntegralHeight = CType(resources.GetObject("lstResults.IntegralHeight"), Boolean)
        Me.lstResults.ItemHeight = CType(resources.GetObject("lstResults.ItemHeight"), Integer)
        Me.lstResults.Location = CType(resources.GetObject("lstResults.Location"), System.Drawing.Point)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.RightToLeft = CType(resources.GetObject("lstResults.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstResults.ScrollAlwaysVisible = CType(resources.GetObject("lstResults.ScrollAlwaysVisible"), Boolean)
        Me.lstResults.Size = CType(resources.GetObject("lstResults.Size"), System.Drawing.Size)
        Me.lstResults.TabIndex = CType(resources.GetObject("lstResults.TabIndex"), Integer)
        Me.lstResults.Visible = CType(resources.GetObject("lstResults.Visible"), Boolean)
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
        'Label5
        '
        Me.Label5.AccessibleDescription = CType(resources.GetObject("Label5.AccessibleDescription"), String)
        Me.Label5.AccessibleName = CType(resources.GetObject("Label5.AccessibleName"), String)
        Me.Label5.Anchor = CType(resources.GetObject("Label5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = CType(resources.GetObject("Label5.AutoSize"), Boolean)
        Me.Label5.Dock = CType(resources.GetObject("Label5.Dock"), System.Windows.Forms.DockStyle)
        Me.Label5.Enabled = CType(resources.GetObject("Label5.Enabled"), Boolean)
        Me.Label5.Font = CType(resources.GetObject("Label5.Font"), System.Drawing.Font)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
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
        'lstResultCodes
        '
        Me.lstResultCodes.AccessibleDescription = CType(resources.GetObject("lstResultCodes.AccessibleDescription"), String)
        Me.lstResultCodes.AccessibleName = CType(resources.GetObject("lstResultCodes.AccessibleName"), String)
        Me.lstResultCodes.Anchor = CType(resources.GetObject("lstResultCodes.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstResultCodes.BackgroundImage = CType(resources.GetObject("lstResultCodes.BackgroundImage"), System.Drawing.Image)
        Me.lstResultCodes.ColumnWidth = CType(resources.GetObject("lstResultCodes.ColumnWidth"), Integer)
        Me.lstResultCodes.Dock = CType(resources.GetObject("lstResultCodes.Dock"), System.Windows.Forms.DockStyle)
        Me.lstResultCodes.Enabled = CType(resources.GetObject("lstResultCodes.Enabled"), Boolean)
        Me.lstResultCodes.Font = CType(resources.GetObject("lstResultCodes.Font"), System.Drawing.Font)
        Me.lstResultCodes.HorizontalExtent = CType(resources.GetObject("lstResultCodes.HorizontalExtent"), Integer)
        Me.lstResultCodes.HorizontalScrollbar = CType(resources.GetObject("lstResultCodes.HorizontalScrollbar"), Boolean)
        Me.lstResultCodes.ImeMode = CType(resources.GetObject("lstResultCodes.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstResultCodes.IntegralHeight = CType(resources.GetObject("lstResultCodes.IntegralHeight"), Boolean)
        Me.lstResultCodes.ItemHeight = CType(resources.GetObject("lstResultCodes.ItemHeight"), Integer)
        Me.lstResultCodes.Location = CType(resources.GetObject("lstResultCodes.Location"), System.Drawing.Point)
        Me.lstResultCodes.Name = "lstResultCodes"
        Me.lstResultCodes.RightToLeft = CType(resources.GetObject("lstResultCodes.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstResultCodes.ScrollAlwaysVisible = CType(resources.GetObject("lstResultCodes.ScrollAlwaysVisible"), Boolean)
        Me.lstResultCodes.Size = CType(resources.GetObject("lstResultCodes.Size"), System.Drawing.Size)
        Me.lstResultCodes.TabIndex = CType(resources.GetObject("lstResultCodes.TabIndex"), Integer)
        Me.lstResultCodes.Visible = CType(resources.GetObject("lstResultCodes.Visible"), Boolean)
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
        'cboOperator
        '
        Me.cboOperator.AccessibleDescription = CType(resources.GetObject("cboOperator.AccessibleDescription"), String)
        Me.cboOperator.AccessibleName = CType(resources.GetObject("cboOperator.AccessibleName"), String)
        Me.cboOperator.Anchor = CType(resources.GetObject("cboOperator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboOperator.BackgroundImage = CType(resources.GetObject("cboOperator.BackgroundImage"), System.Drawing.Image)
        Me.cboOperator.Dock = CType(resources.GetObject("cboOperator.Dock"), System.Windows.Forms.DockStyle)
        Me.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperator.Enabled = CType(resources.GetObject("cboOperator.Enabled"), Boolean)
        Me.cboOperator.Font = CType(resources.GetObject("cboOperator.Font"), System.Drawing.Font)
        Me.cboOperator.ImeMode = CType(resources.GetObject("cboOperator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboOperator.IntegralHeight = CType(resources.GetObject("cboOperator.IntegralHeight"), Boolean)
        Me.cboOperator.ItemHeight = CType(resources.GetObject("cboOperator.ItemHeight"), Integer)
        Me.cboOperator.Location = CType(resources.GetObject("cboOperator.Location"), System.Drawing.Point)
        Me.cboOperator.MaxDropDownItems = CType(resources.GetObject("cboOperator.MaxDropDownItems"), Integer)
        Me.cboOperator.MaxLength = CType(resources.GetObject("cboOperator.MaxLength"), Integer)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.RightToLeft = CType(resources.GetObject("cboOperator.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboOperator.Size = CType(resources.GetObject("cboOperator.Size"), System.Drawing.Size)
        Me.cboOperator.TabIndex = CType(resources.GetObject("cboOperator.TabIndex"), Integer)
        Me.cboOperator.Text = resources.GetString("cboOperator.Text")
        Me.cboOperator.Visible = CType(resources.GetObject("cboOperator.Visible"), Boolean)
        '
        'txtCriteria
        '
        Me.txtCriteria.AccessibleDescription = CType(resources.GetObject("txtCriteria.AccessibleDescription"), String)
        Me.txtCriteria.AccessibleName = CType(resources.GetObject("txtCriteria.AccessibleName"), String)
        Me.txtCriteria.Anchor = CType(resources.GetObject("txtCriteria.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtCriteria.AutoSize = CType(resources.GetObject("txtCriteria.AutoSize"), Boolean)
        Me.txtCriteria.BackgroundImage = CType(resources.GetObject("txtCriteria.BackgroundImage"), System.Drawing.Image)
        Me.txtCriteria.Dock = CType(resources.GetObject("txtCriteria.Dock"), System.Windows.Forms.DockStyle)
        Me.txtCriteria.Enabled = CType(resources.GetObject("txtCriteria.Enabled"), Boolean)
        Me.txtCriteria.Font = CType(resources.GetObject("txtCriteria.Font"), System.Drawing.Font)
        Me.txtCriteria.ImeMode = CType(resources.GetObject("txtCriteria.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtCriteria.Location = CType(resources.GetObject("txtCriteria.Location"), System.Drawing.Point)
        Me.txtCriteria.MaxLength = CType(resources.GetObject("txtCriteria.MaxLength"), Integer)
        Me.txtCriteria.Multiline = CType(resources.GetObject("txtCriteria.Multiline"), Boolean)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.PasswordChar = CType(resources.GetObject("txtCriteria.PasswordChar"), Char)
        Me.txtCriteria.RightToLeft = CType(resources.GetObject("txtCriteria.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtCriteria.ScrollBars = CType(resources.GetObject("txtCriteria.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtCriteria.Size = CType(resources.GetObject("txtCriteria.Size"), System.Drawing.Size)
        Me.txtCriteria.TabIndex = CType(resources.GetObject("txtCriteria.TabIndex"), Integer)
        Me.txtCriteria.Text = resources.GetString("txtCriteria.Text")
        Me.txtCriteria.TextAlign = CType(resources.GetObject("txtCriteria.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtCriteria.Visible = CType(resources.GetObject("txtCriteria.Visible"), Boolean)
        Me.txtCriteria.WordWrap = CType(resources.GetObject("txtCriteria.WordWrap"), Boolean)
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
        'TemplateSearch
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHelp, Me.txtCriteria, Me.Label6, Me.cboOperator, Me.lstResultCodes, Me.btnSelect, Me.Label5, Me.Label4, Me.lstResults, Me.btnClose, Me.btnFind, Me.Label3, Me.Label2, Me.cboSearchField, Me.Label1, Me.lstTemplates})
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
        Me.Name = "TemplateSearch"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim lstrUsedTemplatesIDs() As String
    Dim lstrTemplateFileName() As String
    Dim lstrTemplateResources() As IPTemplates._main.resources
    Dim mTreeviewSelect As TreeView
    Dim mstrCallingForm As Form
    Dim mViewSetting As frmPad.DocumentViews
    Dim lbooCenterOnce As Boolean = False 
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Friend Sub ViewSetting(ByRef pViewSetting As frmPad.DocumentViews)
        mViewSetting = pViewSetting
    End Sub
    Friend Property CallingForm() As Form
        Get
            Return mstrCallingForm
        End Get
        Set(ByVal Value As Form)
            mstrCallingForm = Value
        End Set
    End Property
    Friend Property TreeviewSelect() As TreeView
        Get
            Return mTreeviewSelect
        End Get
        Set(ByVal Value As TreeView)
            mTreeviewSelect = Value
        End Set
    End Property
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        FindResults()
    End Sub
    Private Sub lstResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub
    Private Sub cboSearchField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchField.SelectedIndexChanged

    End Sub
    Private Sub lstTemplates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTemplates.SelectedIndexChanged

        If Not lstTemplates.SelectedItem Is Nothing Then 
            FillFieldBox()
            cboSearchField.Enabled = True
            txtCriteria.Enabled = True
            btnFind.Enabled = True
        End If 

    End Sub
    Private Sub TemplateSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnFind.FlatStyle = FlatStyle.System
            btnClose.FlatStyle = FlatStyle.System
            btnSelect.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        Dim TR As New IPTemplates._main()
        TR.HTMLForms(lstrTemplateResources)

        FillTemplatesUsedList(lstrUsedTemplatesIDs, lstrTemplateFileName, lstrTemplateResources, lstTemplates)
        'lstTemplates.SelectedIndex = 0
        'FillFieldBox()
        
        cboOperator.Items.Add(LangText.GetString("TempSearch_OperatorEqualTo")) '"Equal to")
        cboOperator.Items.Add(LangText.GetString("TempSearch_OperatorNotEqualTo")) '"Not Equal to")
        cboOperator.Items.Add(LangText.GetString("TempSearch_OperatorLike")) '"Like")
        

        'cboOperator.SelectedIndex = 0 
        cboOperator.SelectedIndex = 2 

    End Sub
    Private Sub FillFieldBox()

        Busy(Me, True)
        BusyButtons(True) 

        Me.SuspendLayout()
        'Me.Enabled = False
        If lstTemplates.Items.Count = -1 Then Exit Sub

        cboSearchField.Items.Clear()

        Dim AxWebBrowser As WinOnly.WebOCHostCtrl
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSelection))
        SpawnBrowserObject(AxWebBrowser, Me)

        Dim lbooDLL As Boolean = False
        Dim lstrFileName As String = lstrTemplateFileName(lstTemplates.SelectedIndex)
        If InStrGet(lstrFileName, "SYSTEM:") > 0 Then
            lstrFileName = Microsoft.VisualBasic.Replace(lstrFileName, "SYSTEM:", "")
            lbooDLL = True
        End If
        ShowForm(lstrFileName, AxWebBrowser, lbooDLL)

        'Do Until AxWebBrowser.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
        '    System.Windows.Forms.Application.DoEvents()
        'Loop

        WaitForBrowser(AxWebBrowser) 
        Dim HtmlDoc As IHTMLDocument2 = CType(AxWebBrowser.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
            For x = 0 To oForm.length - 1
                Select Case oForm.elements(x).type
                    Case "hidden"
                    Case Else
                        cboSearchField.Items.Add(oForm.elements(x).name)
                End Select
            Next
        Next i
        cboSearchField.SelectedIndex = 0

        'Me.Enabled = True
        Me.ResumeLayout()

        Busy(Me, False)
        BusyButtons(False) 

    End Sub
    Private Function FindResults() As String
        'Dim lcnn1 As New ADODB.Connection()
        'Dim lsnaLists As New ADODB.Recordset()

        lstResults.Items.Clear()
        lstResultCodes.Items.Clear() 

        'lcnn1 = New ADODB.Connection()
        'lcnn1.Open(gstrConnectionString)

        Dim lstrField As String = Reverse(cboSearchField.Text)
        'Dim lstrValue As String = "<" & lstrField & ">" & txtCriteria.Text & "</" & lstrField & ">"
        

        Dim lstrValue As String = "<" & lstrField & ">" & JetSQLFixup(txtCriteria.Text) & "</" & lstrField & ">"
        Dim lstrSQL As String
        Dim lstrMatchSQL As String

        Select Case cboOperator.Text
            Case LangText.GetString("TempSearch_OperatorEqualTo") 
                'lstrMatchSQL = "= '" & lstrValue.ToUpper & "');"
                lstrMatchSQL = "like '%" & lstrValue.ToUpper & "%');" 
                lstrSQL = "SELECT Title, Topics.TopicCode as tc, TemplateID FROM Topics, TopicDetail WHERE " & _
                "((TopicDetail.TopicCode=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')" & _
                ",Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND " & _
                "TemplateID = '" & _
                lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "' and ucase(Detail) " & lstrMatchSQL 'like '%" & lstrValue & "%');"
            Case LangText.GetString("TempSearch_OperatorNotEqualTo") 
                'lstrMatchSQL = "<> '" & lstrValue.ToUpper & "');"
                'lstrSQL = "SELECT Title, Topics.TopicCode as tc, TemplateID FROM Topics, TopicDetail WHERE " & _
                '"((TopicDetail.TopicCode=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')" & _
                '",Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND " & _
                '"TemplateID = '" & _
                'lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "' and ucase(Detail) " & lstrMatchSQL 'like '%" & lstrValue & "%');"

                
                lstrField = lstrField.ToUpper
                
                Dim lstrLike As String
                If txtCriteria.Text = "" Then
                    lstrLike = ""
                Else
                    lstrLike = "%" & JetSQLFixup(txtCriteria.Text.ToUpper) & "%"
                End If
                
                'lstrSQL = "SELECT Title, Topics.TopicCode AS tc, TemplateID FROM Topics, TopicDetail WHERE (((TemplateID)='" & _
                ' lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & _
                ' "') AND ((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')," & _
                ' "Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & ">')-InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')-Len('</" & lstrField & ">')+1))) not Like '%" & JetSQLFixup(txtCriteria.Text.ToUpper) & "%'));" 'JetSQLFixup

                
                'lstrSQL = "SELECT Title, Topics.TopicCode AS tc, TemplateID FROM Topics, TopicDetail WHERE (((TemplateID)='" & _
                ' lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & _
                ' "') AND ((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')," & _
                ' "Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & ">')-InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')-Len('</" & lstrField & ">')+1))) not Like '" & lstrLike & "'));" 'JetSQLFixup

                
                lstrSQL = "SELECT Topics.Title, Topics.TopicCode AS tc, TopicDetail.TemplateID, InStr(UCase([Detail]),'<" & _
                    lstrField & ">') AS Expr2 FROM Topics, TopicDetail WHERE (((TopicDetail.TemplateID)='" & _
                    lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "') AND ((InStr(UCase([Detail]),'<" & _
                    lstrField & ">'))>0) AND ((TopicDetail.TopicCode)=" & _
                    "Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(" & _
                    "1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                    lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & _
                    ">')-InStr(UCase([Detail]),'<" & lstrField & ">')-Len('</" & lstrField & _
                    ">')+1))) NOT Like '%" & lstrLike & "%'));"

                
            Case LangText.GetString("TempSearch_OperatorLike") 
                
                lstrField = lstrField.ToUpper
                
                Dim lstrLike As String
                If txtCriteria.Text = "" Then
                    lstrLike = ""
                Else
                    lstrLike = "%" & JetSQLFixup(txtCriteria.Text.ToUpper) & "%"
                End If
                

                'lstrSQL = "SELECT Title, Topics.TopicCode AS tc, TemplateID FROM Topics, TopicDetail WHERE (((TemplateID)='" & _
                ' lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & _
                ' "') AND ((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')," & _
                ' "Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & ">')-InStr(UCase([Detail]),'<" & _
                ' lstrField & ">')-Len('</" & lstrField & ">')+1))) Like '%" & JetSQLFixup(txtCriteria.Text.ToUpper) & "%'));" 'JetSQLFixup

                
                'lstrSQL = "SELECT Title, Topics.TopicCode AS tc, TemplateID FROM Topics, TopicDetail WHERE (((TemplateID)='" & _
                '    lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & _
                '    "') AND ((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')," & _
                '    "Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                '    lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & ">')-InStr(UCase([Detail]),'<" & _
                '    lstrField & ">')-Len('</" & lstrField & ">')+1))) Like '" & lstrLike & "'));"

                
                lstrSQL = "SELECT Topics.Title, Topics.TopicCode AS tc, TopicDetail.TemplateID, InStr(UCase([Detail]),'<" & _
                    lstrField & ">') AS Expr2 FROM Topics, TopicDetail WHERE (((TopicDetail.TemplateID)='" & _
                    lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "') AND ((InStr(UCase([Detail]),'<" & _
                    lstrField & ">'))>0) AND ((TopicDetail.TopicCode)=" & _
                    "Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(" & _
                    "1,[Topics].[TopicCode],'T')+1)) AND ((UCase(Mid([Detail],InStr(UCase([Detail]),'<" & _
                    lstrField & ">')+Len('<" & lstrField & ">'),InStr(UCase([Detail]),'</" & lstrField & _
                    ">')-InStr(UCase([Detail]),'<" & lstrField & ">')-Len('</" & lstrField & _
                    ">')+1))) Like '%" & lstrLike & "%'));"
                
        End Select

        'lstrSQL = "SELECT Title, Topics.TopicCode as tc, TemplateID FROM Topics, TopicDetail WHERE " & _
        '        "(((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')" & _
        '        ",Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND " & _
        '        "TemplateID = '" & _
        '        lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "' and Detail " & lstrMatchSQL 'like '%" & lstrValue & "%');"

        '
        'lstrSQL = "SELECT Title, Topics.TopicCode as tc, TemplateID FROM Topics, TopicDetail WHERE " & _
        '"((TopicDetail.TopicCode=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T')" & _
        '",Len([Topics].[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)) AND " & _
        '"TemplateID = '" & _
        'lstrUsedTemplatesIDs(lstTemplates.SelectedIndex) & "' and ucase(Detail) " & lstrMatchSQL 'like '%" & lstrValue & "%');"

        '--- Moved from further up 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)
        '--- Moved from further up 

        'Try ' testing only
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, _
         ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'Catch ex As System.Runtime.InteropServices.COMException ' testing only
        '    MessageBox.Show(ex.ToString) ' testing only
        'End Try ' testing only

        Try 
            With lsnaLists
                Do While Not .EOF
                    lstResults.Items.Add(.Fields("Title").Value & "")
                    lstResultCodes.Items.Add(.Fields("tc").Value & "")
                    .MoveNext()
                Loop
            End With
        Catch 
            '
        Finally 
            lsnaLists.Close()
            lcnn1.Close()
        End Try 

    End Function

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lstResults.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim lstrTag As String = lstResultCodes.Items.Item(lstResults.SelectedIndex)
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
                mViewSetting = frmPad.DocumentViews.NormalTopic 
                mTreeviewSelect.SelectedNode = n
                Exit For
            End If
        Next

        Me.Close() 
    End Sub

    Private Sub TemplateSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        'If lbooCenterOnce = False Then 
        '    lbooCenterOnce = True
        '    Me.Top = (CallingForm.Height / 2) - (Me.Height / 2) + CallingForm.Top
        '    Me.Left = (CallingForm.Width / 2) - (Me.Width / 2) + CallingForm.Left
        'End If

    End Sub

    Private Sub lstResults_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResults.DoubleClick
        btnSelect_Click(Nothing, Nothing)
    End Sub

    Private Sub TemplateSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = System.Windows.Forms.Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnClose_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.templatesearch)) 
    End Sub

    Private Sub TemplateSearch_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Me.Owner.Focus() 
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        
        If pbool = True Then pbool = False Else pbool = True

        btnClose.Enabled = pbool
        btnFind.Enabled = pbool
        btnSelect.Enabled = pbool
        btnHelp.Enabled = pbool

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnFind.BackColor = Color.FromArgb(0, btnFind.BackColor)
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)
        btnSelect.BackColor = Color.FromArgb(0, btnSelect.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        Label5.BackColor = Color.FromArgb(0, Label5.BackColor)
        Label6.BackColor = Color.FromArgb(0, Label6.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub TemplateSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class