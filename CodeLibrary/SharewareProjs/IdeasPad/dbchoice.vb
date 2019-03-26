Friend Class frmDBChoice
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
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents cmdMaint As System.Windows.Forms.Button
    Friend WithEvents cmdQuit As System.Windows.Forms.Button
    Friend WithEvents lstShortNames As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstDatabaseDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lstDatabase As System.Windows.Forms.ListBox
    Friend WithEvents chkDontAskAgain As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDBChoice))
        Me.lstDatabaseDisplay = New System.Windows.Forms.ListBox()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdMaint = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.lstShortNames = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDatabase = New System.Windows.Forms.ListBox()
        Me.chkDontAskAgain = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lstDatabaseDisplay
        '
        Me.lstDatabaseDisplay.AccessibleDescription = CType(resources.GetObject("lstDatabaseDisplay.AccessibleDescription"), String)
        Me.lstDatabaseDisplay.AccessibleName = CType(resources.GetObject("lstDatabaseDisplay.AccessibleName"), String)
        Me.lstDatabaseDisplay.Anchor = CType(resources.GetObject("lstDatabaseDisplay.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstDatabaseDisplay.BackgroundImage = CType(resources.GetObject("lstDatabaseDisplay.BackgroundImage"), System.Drawing.Image)
        Me.lstDatabaseDisplay.ColumnWidth = CType(resources.GetObject("lstDatabaseDisplay.ColumnWidth"), Integer)
        Me.lstDatabaseDisplay.Dock = CType(resources.GetObject("lstDatabaseDisplay.Dock"), System.Windows.Forms.DockStyle)
        Me.lstDatabaseDisplay.Enabled = CType(resources.GetObject("lstDatabaseDisplay.Enabled"), Boolean)
        Me.lstDatabaseDisplay.Font = CType(resources.GetObject("lstDatabaseDisplay.Font"), System.Drawing.Font)
        Me.lstDatabaseDisplay.HorizontalExtent = CType(resources.GetObject("lstDatabaseDisplay.HorizontalExtent"), Integer)
        Me.lstDatabaseDisplay.HorizontalScrollbar = CType(resources.GetObject("lstDatabaseDisplay.HorizontalScrollbar"), Boolean)
        Me.lstDatabaseDisplay.ImeMode = CType(resources.GetObject("lstDatabaseDisplay.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstDatabaseDisplay.IntegralHeight = CType(resources.GetObject("lstDatabaseDisplay.IntegralHeight"), Boolean)
        Me.lstDatabaseDisplay.ItemHeight = CType(resources.GetObject("lstDatabaseDisplay.ItemHeight"), Integer)
        Me.lstDatabaseDisplay.Location = CType(resources.GetObject("lstDatabaseDisplay.Location"), System.Drawing.Point)
        Me.lstDatabaseDisplay.Name = "lstDatabaseDisplay"
        Me.lstDatabaseDisplay.RightToLeft = CType(resources.GetObject("lstDatabaseDisplay.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstDatabaseDisplay.ScrollAlwaysVisible = CType(resources.GetObject("lstDatabaseDisplay.ScrollAlwaysVisible"), Boolean)
        Me.lstDatabaseDisplay.Size = CType(resources.GetObject("lstDatabaseDisplay.Size"), System.Drawing.Size)
        Me.lstDatabaseDisplay.TabIndex = CType(resources.GetObject("lstDatabaseDisplay.TabIndex"), Integer)
        Me.lstDatabaseDisplay.TabStop = False
        Me.lstDatabaseDisplay.Visible = CType(resources.GetObject("lstDatabaseDisplay.Visible"), Boolean)
        '
        'cmdSelect
        '
        Me.cmdSelect.AccessibleDescription = CType(resources.GetObject("cmdSelect.AccessibleDescription"), String)
        Me.cmdSelect.AccessibleName = CType(resources.GetObject("cmdSelect.AccessibleName"), String)
        Me.cmdSelect.Anchor = CType(resources.GetObject("cmdSelect.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdSelect.BackgroundImage = CType(resources.GetObject("cmdSelect.BackgroundImage"), System.Drawing.Image)
        Me.cmdSelect.Dock = CType(resources.GetObject("cmdSelect.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdSelect.Enabled = CType(resources.GetObject("cmdSelect.Enabled"), Boolean)
        Me.cmdSelect.FlatStyle = CType(resources.GetObject("cmdSelect.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdSelect.Font = CType(resources.GetObject("cmdSelect.Font"), System.Drawing.Font)
        Me.cmdSelect.Image = CType(resources.GetObject("cmdSelect.Image"), System.Drawing.Image)
        Me.cmdSelect.ImageAlign = CType(resources.GetObject("cmdSelect.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdSelect.ImageIndex = CType(resources.GetObject("cmdSelect.ImageIndex"), Integer)
        Me.cmdSelect.ImeMode = CType(resources.GetObject("cmdSelect.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdSelect.Location = CType(resources.GetObject("cmdSelect.Location"), System.Drawing.Point)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.RightToLeft = CType(resources.GetObject("cmdSelect.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdSelect.Size = CType(resources.GetObject("cmdSelect.Size"), System.Drawing.Size)
        Me.cmdSelect.TabIndex = CType(resources.GetObject("cmdSelect.TabIndex"), Integer)
        Me.cmdSelect.Text = resources.GetString("cmdSelect.Text")
        Me.cmdSelect.TextAlign = CType(resources.GetObject("cmdSelect.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdSelect.Visible = CType(resources.GetObject("cmdSelect.Visible"), Boolean)
        '
        'cmdMaint
        '
        Me.cmdMaint.AccessibleDescription = CType(resources.GetObject("cmdMaint.AccessibleDescription"), String)
        Me.cmdMaint.AccessibleName = CType(resources.GetObject("cmdMaint.AccessibleName"), String)
        Me.cmdMaint.Anchor = CType(resources.GetObject("cmdMaint.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdMaint.BackgroundImage = CType(resources.GetObject("cmdMaint.BackgroundImage"), System.Drawing.Image)
        Me.cmdMaint.Dock = CType(resources.GetObject("cmdMaint.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdMaint.Enabled = CType(resources.GetObject("cmdMaint.Enabled"), Boolean)
        Me.cmdMaint.FlatStyle = CType(resources.GetObject("cmdMaint.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdMaint.Font = CType(resources.GetObject("cmdMaint.Font"), System.Drawing.Font)
        Me.cmdMaint.Image = CType(resources.GetObject("cmdMaint.Image"), System.Drawing.Image)
        Me.cmdMaint.ImageAlign = CType(resources.GetObject("cmdMaint.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdMaint.ImageIndex = CType(resources.GetObject("cmdMaint.ImageIndex"), Integer)
        Me.cmdMaint.ImeMode = CType(resources.GetObject("cmdMaint.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdMaint.Location = CType(resources.GetObject("cmdMaint.Location"), System.Drawing.Point)
        Me.cmdMaint.Name = "cmdMaint"
        Me.cmdMaint.RightToLeft = CType(resources.GetObject("cmdMaint.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdMaint.Size = CType(resources.GetObject("cmdMaint.Size"), System.Drawing.Size)
        Me.cmdMaint.TabIndex = CType(resources.GetObject("cmdMaint.TabIndex"), Integer)
        Me.cmdMaint.Text = resources.GetString("cmdMaint.Text")
        Me.cmdMaint.TextAlign = CType(resources.GetObject("cmdMaint.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdMaint.Visible = CType(resources.GetObject("cmdMaint.Visible"), Boolean)
        '
        'cmdQuit
        '
        Me.cmdQuit.AccessibleDescription = CType(resources.GetObject("cmdQuit.AccessibleDescription"), String)
        Me.cmdQuit.AccessibleName = CType(resources.GetObject("cmdQuit.AccessibleName"), String)
        Me.cmdQuit.Anchor = CType(resources.GetObject("cmdQuit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdQuit.BackgroundImage = CType(resources.GetObject("cmdQuit.BackgroundImage"), System.Drawing.Image)
        Me.cmdQuit.Dock = CType(resources.GetObject("cmdQuit.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdQuit.Enabled = CType(resources.GetObject("cmdQuit.Enabled"), Boolean)
        Me.cmdQuit.FlatStyle = CType(resources.GetObject("cmdQuit.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdQuit.Font = CType(resources.GetObject("cmdQuit.Font"), System.Drawing.Font)
        Me.cmdQuit.Image = CType(resources.GetObject("cmdQuit.Image"), System.Drawing.Image)
        Me.cmdQuit.ImageAlign = CType(resources.GetObject("cmdQuit.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdQuit.ImageIndex = CType(resources.GetObject("cmdQuit.ImageIndex"), Integer)
        Me.cmdQuit.ImeMode = CType(resources.GetObject("cmdQuit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdQuit.Location = CType(resources.GetObject("cmdQuit.Location"), System.Drawing.Point)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.RightToLeft = CType(resources.GetObject("cmdQuit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdQuit.Size = CType(resources.GetObject("cmdQuit.Size"), System.Drawing.Size)
        Me.cmdQuit.TabIndex = CType(resources.GetObject("cmdQuit.TabIndex"), Integer)
        Me.cmdQuit.Text = resources.GetString("cmdQuit.Text")
        Me.cmdQuit.TextAlign = CType(resources.GetObject("cmdQuit.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdQuit.Visible = CType(resources.GetObject("cmdQuit.Visible"), Boolean)
        '
        'lstShortNames
        '
        Me.lstShortNames.AccessibleDescription = CType(resources.GetObject("lstShortNames.AccessibleDescription"), String)
        Me.lstShortNames.AccessibleName = CType(resources.GetObject("lstShortNames.AccessibleName"), String)
        Me.lstShortNames.Anchor = CType(resources.GetObject("lstShortNames.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstShortNames.BackgroundImage = CType(resources.GetObject("lstShortNames.BackgroundImage"), System.Drawing.Image)
        Me.lstShortNames.ColumnWidth = CType(resources.GetObject("lstShortNames.ColumnWidth"), Integer)
        Me.lstShortNames.Dock = CType(resources.GetObject("lstShortNames.Dock"), System.Windows.Forms.DockStyle)
        Me.lstShortNames.Enabled = CType(resources.GetObject("lstShortNames.Enabled"), Boolean)
        Me.lstShortNames.Font = CType(resources.GetObject("lstShortNames.Font"), System.Drawing.Font)
        Me.lstShortNames.HorizontalExtent = CType(resources.GetObject("lstShortNames.HorizontalExtent"), Integer)
        Me.lstShortNames.HorizontalScrollbar = CType(resources.GetObject("lstShortNames.HorizontalScrollbar"), Boolean)
        Me.lstShortNames.ImeMode = CType(resources.GetObject("lstShortNames.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstShortNames.IntegralHeight = CType(resources.GetObject("lstShortNames.IntegralHeight"), Boolean)
        Me.lstShortNames.ItemHeight = CType(resources.GetObject("lstShortNames.ItemHeight"), Integer)
        Me.lstShortNames.Location = CType(resources.GetObject("lstShortNames.Location"), System.Drawing.Point)
        Me.lstShortNames.Name = "lstShortNames"
        Me.lstShortNames.RightToLeft = CType(resources.GetObject("lstShortNames.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstShortNames.ScrollAlwaysVisible = CType(resources.GetObject("lstShortNames.ScrollAlwaysVisible"), Boolean)
        Me.lstShortNames.Size = CType(resources.GetObject("lstShortNames.Size"), System.Drawing.Size)
        Me.lstShortNames.TabIndex = CType(resources.GetObject("lstShortNames.TabIndex"), Integer)
        Me.lstShortNames.Visible = CType(resources.GetObject("lstShortNames.Visible"), Boolean)
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
        'lstDatabase
        '
        Me.lstDatabase.AccessibleDescription = CType(resources.GetObject("lstDatabase.AccessibleDescription"), String)
        Me.lstDatabase.AccessibleName = CType(resources.GetObject("lstDatabase.AccessibleName"), String)
        Me.lstDatabase.Anchor = CType(resources.GetObject("lstDatabase.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstDatabase.BackgroundImage = CType(resources.GetObject("lstDatabase.BackgroundImage"), System.Drawing.Image)
        Me.lstDatabase.ColumnWidth = CType(resources.GetObject("lstDatabase.ColumnWidth"), Integer)
        Me.lstDatabase.Dock = CType(resources.GetObject("lstDatabase.Dock"), System.Windows.Forms.DockStyle)
        Me.lstDatabase.Enabled = CType(resources.GetObject("lstDatabase.Enabled"), Boolean)
        Me.lstDatabase.Font = CType(resources.GetObject("lstDatabase.Font"), System.Drawing.Font)
        Me.lstDatabase.HorizontalExtent = CType(resources.GetObject("lstDatabase.HorizontalExtent"), Integer)
        Me.lstDatabase.HorizontalScrollbar = CType(resources.GetObject("lstDatabase.HorizontalScrollbar"), Boolean)
        Me.lstDatabase.ImeMode = CType(resources.GetObject("lstDatabase.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstDatabase.IntegralHeight = CType(resources.GetObject("lstDatabase.IntegralHeight"), Boolean)
        Me.lstDatabase.ItemHeight = CType(resources.GetObject("lstDatabase.ItemHeight"), Integer)
        Me.lstDatabase.Location = CType(resources.GetObject("lstDatabase.Location"), System.Drawing.Point)
        Me.lstDatabase.Name = "lstDatabase"
        Me.lstDatabase.RightToLeft = CType(resources.GetObject("lstDatabase.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstDatabase.ScrollAlwaysVisible = CType(resources.GetObject("lstDatabase.ScrollAlwaysVisible"), Boolean)
        Me.lstDatabase.Size = CType(resources.GetObject("lstDatabase.Size"), System.Drawing.Size)
        Me.lstDatabase.TabIndex = CType(resources.GetObject("lstDatabase.TabIndex"), Integer)
        Me.lstDatabase.Visible = CType(resources.GetObject("lstDatabase.Visible"), Boolean)
        '
        'chkDontAskAgain
        '
        Me.chkDontAskAgain.AccessibleDescription = CType(resources.GetObject("chkDontAskAgain.AccessibleDescription"), String)
        Me.chkDontAskAgain.AccessibleName = CType(resources.GetObject("chkDontAskAgain.AccessibleName"), String)
        Me.chkDontAskAgain.Anchor = CType(resources.GetObject("chkDontAskAgain.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkDontAskAgain.Appearance = CType(resources.GetObject("chkDontAskAgain.Appearance"), System.Windows.Forms.Appearance)
        Me.chkDontAskAgain.BackgroundImage = CType(resources.GetObject("chkDontAskAgain.BackgroundImage"), System.Drawing.Image)
        Me.chkDontAskAgain.CheckAlign = CType(resources.GetObject("chkDontAskAgain.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkDontAskAgain.Dock = CType(resources.GetObject("chkDontAskAgain.Dock"), System.Windows.Forms.DockStyle)
        Me.chkDontAskAgain.Enabled = CType(resources.GetObject("chkDontAskAgain.Enabled"), Boolean)
        Me.chkDontAskAgain.FlatStyle = CType(resources.GetObject("chkDontAskAgain.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkDontAskAgain.Font = CType(resources.GetObject("chkDontAskAgain.Font"), System.Drawing.Font)
        Me.chkDontAskAgain.Image = CType(resources.GetObject("chkDontAskAgain.Image"), System.Drawing.Image)
        Me.chkDontAskAgain.ImageAlign = CType(resources.GetObject("chkDontAskAgain.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkDontAskAgain.ImageIndex = CType(resources.GetObject("chkDontAskAgain.ImageIndex"), Integer)
        Me.chkDontAskAgain.ImeMode = CType(resources.GetObject("chkDontAskAgain.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkDontAskAgain.Location = CType(resources.GetObject("chkDontAskAgain.Location"), System.Drawing.Point)
        Me.chkDontAskAgain.Name = "chkDontAskAgain"
        Me.chkDontAskAgain.RightToLeft = CType(resources.GetObject("chkDontAskAgain.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkDontAskAgain.Size = CType(resources.GetObject("chkDontAskAgain.Size"), System.Drawing.Size)
        Me.chkDontAskAgain.TabIndex = CType(resources.GetObject("chkDontAskAgain.TabIndex"), Integer)
        Me.chkDontAskAgain.Text = resources.GetString("chkDontAskAgain.Text")
        Me.chkDontAskAgain.TextAlign = CType(resources.GetObject("chkDontAskAgain.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkDontAskAgain.Visible = CType(resources.GetObject("chkDontAskAgain.Visible"), Boolean)
        '
        'frmDBChoice
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkDontAskAgain, Me.lstDatabase, Me.Label4, Me.Label1, Me.lstShortNames, Me.cmdQuit, Me.cmdMaint, Me.cmdSelect, Me.lstDatabaseDisplay})
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
        Me.Name = "frmDBChoice"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim lstrDBTag(19)
    Dim lstrDB(19) As updtDatabase
    Friend gbooDBChoiceCancel As Boolean = False
    Private Structure updtDatabase
        Dim strFileName As String
        Dim strShortName As String
        Dim lintFileIndex As Integer
    End Structure
    Dim lintCounter As Integer
    Private gintSelectedListIndex As Integer
    Private gintItemCount As Integer
    Dim llngOriginalHeight As Long 
    'Dim lintNumofItems As Integer 
    Dim llngDefaultItemHeight As Long 
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 


    'Private mfrmMainForm As Form
    '' Define the property.
    'Friend Property MaintForm() As Form
    '    Get
    '        ' The Get property procedure is called when the value
    '        ' of a property is retrieved. 
    '        Return mfrmMainForm
    '    End Get
    '    Set(ByVal Value As Form)
    '        ' The Set property procedure is called when the value 
    '        ' of a property is modified. 
    '        ' The value to be assigned is passed in the argument to Set. 
    '        mfrmMainForm = Value
    '    End Set
    'End Property
    Private Function SelectListItem(ByVal pstrShortName As String) As Integer
        Dim lintArrInc As Integer

        For lintArrInc = 0 To lstrDB.GetUpperBound(0) 'ubound
            If lstrDB(lintArrInc).strShortName = pstrShortName Then
                SelectListItem = lstrDB(lintArrInc).lintFileIndex
                Exit For
            End If
        Next lintArrInc

    End Function
    Private Sub cmdMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMaint.Click

        If lstDatabase.SelectedItem = "" Then
            'mxessagebox.show("You must selecte a file!", NameMe(""))
            MessageBox.Show(LangText.GetString("dbChoice_MustSelect"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 
            Exit Sub
        End If

        Dim Info As New System.IO.FileInfo(lstDatabase.SelectedItem)

        If Not Info.Exists Then
            'mxessagebox.show("Warning, the file you have selected does not exist." & Environment.NewLine & _
            '    "If you wish to create / repair & compact an 'Information Base' file " & Environment.NewLine & _
            '    "you must select an existing file!", NameMe(""))
            MessageBox.Show(LangText.GetString("dbChoice_FileNotExist").Replace("[CR]", _
                Environment.NewLine).Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 

        End If

        gintSelectedListIndex = SelectListItem(lstShortNames.SelectedItem)
        gintItemCount = lstDatabase.Items.Count
        gstrDataFileName = lstDatabase.SelectedItem

        Dim MaintForm As New frmMaint() 
        MaintForm.SelListIdx = gintSelectedListIndex
        MaintForm.ListItemCount = gintItemCount
        MaintForm.Owner = Me 
        MaintForm.ShowDialog() 
        'mfrmMainForm.ShowDialog()

        System.Windows.Forms.Application.DoEvents() 

        Busy(Me, True)

        lstDatabase.BeginUpdate() 
        lstShortNames.BeginUpdate() 
        lstDatabaseDisplay.BeginUpdate()

        lstDatabase.Items.Clear()
        lstShortNames.Items.Clear()
        lstDatabaseDisplay.Items.Clear()

        LoadInfo()

        
        Dim lintArrInc As Integer
        If lstDatabase.Items.Count = 1 Then
            lstDatabase.SelectedIndex = 0
        ElseIf lstDatabase.Items.Count <> -1 Then
            For lintArrInc = 0 To lstDatabase.Items.Count - 1
                If lstDatabase.Items(lintArrInc) = gstrDataFileName Then
                    lstDatabase.SelectedIndex = lintArrInc
                End If
            Next lintArrInc

        End If
        

        AdjustFormSizeForItems() 

        lstDatabase.EndUpdate() 
        lstShortNames.EndUpdate() 
        lstDatabaseDisplay.EndUpdate()

        Busy(Me, False)

    End Sub
    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click

        gbooDBChoiceCancel = True
        Me.Close()

    End Sub
    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        If lstDatabase.Items.Count = 0 Then
            Exit Sub
        End If

        If lstDatabase.SelectedItem = "" Then
            'mxessagebox.show("You must selecte a file!", NameMe(""))
            MessageBox.Show(LangText.GetString("dbChoice_MustSelect"), _
                NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 
            Exit Sub
        End If
        'gstrLocalConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
        '    "D:\Temp\LocalIdeas.mdb" & ";Persist Security Info=False"

        Dim Info As New System.IO.FileInfo(lstDatabase.SelectedItem)

        If Not Info.Exists Then
            'mxessagebox.show("This 'Information Base' file cannot be found!" & Environment.NewLine & Environment.NewLine & _
            '    "You may wish to remove this listing, this can be" & Environment.NewLine & "done through the maintenance screen!", NameMe(""))
            MessageBox.Show(LangText.GetString("dbChoice_FileCannotFind").Replace("[Program]", gProgName).Replace("[CR]", _
                Environment.NewLine).Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 

            Exit Sub
        End If

        ' ---- 
        Dim lstrDefDB As String
        If chkDontAskAgain.Checked = True Then
            lstrDefDB = lstDatabase.SelectedItem
        Else
            lstrDefDB = ""
        End If
        SaveSetting("Default Information Base File", lstrDefDB, InitalXMLConfig.XmlConfigType.AppSettings, "")
        ' ---- 

        gstrDataFileName = lstDatabase.SelectedItem

        'gstrIniAppName = gstrIniAppName '& "-" & lstrDBTag(lstDatabase.SelectedIndex)

        gbooDBChoiceCancel = False
        Me.Close()
    End Sub
    Private Sub LoadInfo()
        Dim lintArrInc As Integer
        Dim lbooDBFound As Boolean

        'Me.WindowState = vbNormal

        lintCounter = 0 

        If lstDatabase.Items.Count > 0 Then
            lstDatabase.Items.Clear()
            lstShortNames.Items.Clear()
            lstDatabaseDisplay.Items.Clear()
        End If


        Dim lintMaxHist As Integer = 3
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
            lintMaxHist = 19
        End If

        
        'For lintArrInc = 0 To lintMaxHist

        '    'lstrDB(lintArrInc).strFileName = GetSetting(gstrIniAppName, "DBChoice", "FileName" & lintArrInc)
        '    'lstrDB(lintArrInc).strShortName = GetSetting(gstrIniAppName, "DBChoice", "ShortName" & lintArrInc)
        '    lstrDB(lintArrInc).strFileName = GetSetting("FileName" & lintArrInc, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        '    lstrDB(lintArrInc).strShortName = GetSetting("ShortName" & lintArrInc, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        '    lstrDB(lintArrInc).lintFileIndex = lintArrInc
        '    If lstrDB(lintArrInc).strFileName <> "" Then
        '        lbooDBFound = True
        '        lstDatabase.Items.Add(lstrDB(lintArrInc).strFileName)
        '        lstShortNames.Items.Add(lstrDB(lintArrInc).strShortName)
        '        lstDatabaseDisplay.Items.Add(ReturnFileHistoryItem(lstrDB(lintArrInc).strFileName, 50))
        '        lstrDBTag(lintCounter) = lstrDB(lintArrInc).strShortName
        '        lintCounter = lintCounter + 1
        '    End If
        'Next lintArrInc

        Dim Databases As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
        With Databases
            For lintArrInc = 0 To lintMaxHist
                lstrDB(lintArrInc).strFileName = .GetValue("FileName" & lintArrInc, "")
                lstrDB(lintArrInc).strShortName = .GetValue("ShortName" & lintArrInc, "")
                lstrDB(lintArrInc).lintFileIndex = lintArrInc
                If lstrDB(lintArrInc).strFileName <> "" Then
                    lbooDBFound = True
                    lstDatabase.Items.Add(lstrDB(lintArrInc).strFileName)
                    lstShortNames.Items.Add(lstrDB(lintArrInc).strShortName)
                    lstDatabaseDisplay.Items.Add(ReturnFileHistoryItem(lstrDB(lintArrInc).strFileName, 50))
                    lstrDBTag(lintCounter) = lstrDB(lintArrInc).strShortName
                    lintCounter = lintCounter + 1
                End If
            Next lintArrInc
        End With
        

    End Sub
    Private Sub dbchoice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Text = NameMe("Information Bases")
        Me.Text = NameMe(LangText.GetString("dbChoice_TitleInformationBases").Replace("[Program]", gProgName)) 

        Label4.Text = Label4.Text.Replace("[Program]", gProgName) 
        Me.Text = Me.Text.Replace("[Program]", gProgName) 
        Label1.Text = Label1.Text.Replace("[Program]", gProgName) 

        Label4.Text = Label4.Text.Replace("2004", gYear) 

        
        If IsAboveOrEqualWinXp() = True Then  
            cmdSelect.FlatStyle = FlatStyle.System
            cmdMaint.FlatStyle = FlatStyle.System
            cmdQuit.FlatStyle = FlatStyle.System
        End If 
        'chkDontAskAgain.FlatStyle = FlatStyle.System
        

        chkDontAskAgain.Top += 1 

        SetBackcolors() 

        llngOriginalHeight = Me.Height 
        llngDefaultItemHeight = lstShortNames.Height / 7 

        PutIntoPanelSplitter() 

        LoadInfo()

        AdjustFormSizeForItems() 

        If lstShortNames.Items.Count <> 0 Then
            lstShortNames.SelectedIndex = 0
        End If
        If lstShortNames.Items.Count = 1 Then
            cmdSelect.Select()
        End If

    End Sub
    Private Sub lstDatabase_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDatabase.MouseDown
        lstShortNames.SelectedIndex = lstDatabase.SelectedIndex
        lstDatabaseDisplay.SelectedIndex = lstDatabase.SelectedIndex
    End Sub
    Private Sub lstShortNames_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstShortNames.MouseDown
        lstDatabase.SelectedIndex = lstShortNames.SelectedIndex
        lstDatabaseDisplay.SelectedIndex = lstShortNames.SelectedIndex
    End Sub
    Private Sub lstDatabase_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstDatabase.KeyUp
        lstShortNames.SelectedIndex = lstDatabase.SelectedIndex
        lstDatabaseDisplay.SelectedIndex = lstDatabase.SelectedIndex
    End Sub
    Private Sub lstShortNames_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShortNames.SelectedIndexChanged
        lstDatabase.SelectedIndex = lstShortNames.SelectedIndex
        lstDatabaseDisplay.SelectedIndex = lstShortNames.SelectedIndex
    End Sub
    Private Sub lstDatabase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDatabase.SelectedIndexChanged
        lstShortNames.SelectedIndex = lstDatabase.SelectedIndex
        lstDatabaseDisplay.SelectedIndex = lstDatabase.SelectedIndex
    End Sub
    Private Sub lstDatabaseDisplay_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDatabaseDisplay.MouseDown
        lstShortNames.SelectedIndex = lstDatabaseDisplay.SelectedIndex
        lstDatabase.SelectedIndex = lstDatabaseDisplay.SelectedIndex
    End Sub
    Private Sub lstDatabaseDisplay_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstDatabaseDisplay.KeyUp
        lstShortNames.SelectedIndex = lstDatabaseDisplay.SelectedIndex
        lstDatabase.SelectedIndex = lstDatabaseDisplay.SelectedIndex
    End Sub
    Private Sub lstDatabaseDisplay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDatabaseDisplay.SelectedIndexChanged
        lstShortNames.SelectedIndex = lstDatabaseDisplay.SelectedIndex
        lstDatabase.SelectedIndex = lstDatabaseDisplay.SelectedIndex
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        UIStyle.Paper(e)

    End Sub
    Private Sub AdjustFormSizeForItems()

        'Console.WriteLine("plngNumOfItems=" & plngNumOfItems)

        lstDatabase.BeginUpdate() 
        lstShortNames.BeginUpdate() 
        lstDatabaseDisplay.BeginUpdate()

        
        'Dim lintDefeultNumOfItems As Integer = plngNumOfItems

        Dim lintActualItemas As Integer = lstShortNames.Items.Count()

        If lintActualItemas > 7 Then
            'Dim llngItemHeight As Long = lstShortNames.Height / lintDefeultNumOfItems
            Dim llngExtraRequiredHeight As Long = (lintActualItemas - 7) * llngDefaultItemHeight

            Me.Height = llngOriginalHeight 
            Me.Height += llngExtraRequiredHeight

        End If
        

        

        lstDatabase.EndUpdate()
        lstShortNames.EndUpdate()
        lstDatabaseDisplay.EndUpdate()

        'Dim X As Short = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        'Dim Y As Short = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        'Me.Location = New Point(X, Y)
        Me.Location = CentreMe(Me) 
        

    End Sub
    Private Sub frmDBChoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmdQuit_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub lstDatabase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstDatabase.KeyDown

        If e.KeyCode = Keys.Enter Then 
            cmdSelect_Click(Nothing, Nothing) 
        End If

    End Sub
    Sub PutIntoPanelSplitter()
        'added 
        Dim Splitter2 As New Splitter()
        Dim GroupPanel As New Panel()
        Me.Controls.Add(GroupPanel)

        Splitter2.Width += 1
        With GroupPanel

            .Left = lstShortNames.Left
            .Top = lstShortNames.Top
            .Width = lstShortNames.Width + Splitter2.Width + lstDatabaseDisplay.Width
            .Height = lstShortNames.Height
            .Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom _
                        Or System.Windows.Forms.AnchorStyles.Left

            .Controls.AddRange(New System.Windows.Forms.Control() {Splitter2, Me.lstShortNames, Me.lstDatabaseDisplay})

            lstShortNames.Left = 0

            lstShortNames.Dock = System.Windows.Forms.DockStyle.Left
            lstDatabaseDisplay.Dock = System.Windows.Forms.DockStyle.Fill
            lstShortNames.SendToBack()

            .Visible = True
        End With

    End Sub
    Private Sub SetBackcolors()

        'Added 
        cmdSelect.BackColor = Color.FromArgb(0, cmdSelect.BackColor)
        cmdMaint.BackColor = Color.FromArgb(0, cmdMaint.BackColor)
        cmdQuit.BackColor = Color.FromArgb(0, cmdQuit.BackColor)
        chkDontAskAgain.BackColor = Color.FromArgb(0, chkDontAskAgain.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        If IsAboveOrEqualWinXp() = False Then : chkDontAskAgain.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, chkDontAskAgain.Top, chkDontAskAgain.Left, chkDontAskAgain.Width, chkDontAskAgain.Height) : End If 

    End Sub

    Private Sub frmDBChoice_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub lstDatabaseDisplay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDatabaseDisplay.DoubleClick
        cmdSelect_Click(Nothing, Nothing) 
    End Sub

    Private Sub lstShortNames_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShortNames.DoubleClick
        cmdSelect_Click(Nothing, Nothing) 
    End Sub
End Class