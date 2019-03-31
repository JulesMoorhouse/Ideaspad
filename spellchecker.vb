Imports System.IO
Imports System.Text.RegularExpressions
Imports AppBasic.strman
Public Class spellchecker
    Inherits System.Windows.Forms.Form
    Dim lintWordPos As Long = 1
    Dim mTextBox As Object
    'Dim lbooSearchStarted As Boolean = False
    Dim llngSelStart As Long
    Dim llngSelLen As Long
    Dim lstrDictionaryFileStr As String
    Dim lstrCustomDictionaryFileStr As String
    Dim mstrDictionaryFile As String
    Dim mstrCustomDictionaryFile As String
    Dim lstrIgnoreWords(0) As String
    Dim mstrCaption As String
    Dim mbooDoingCheck As Boolean = False
    Dim mbooWaitForMore As Boolean = False
    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("RTFStand.RTFStand", _
        System.Reflection.Assembly.GetExecutingAssembly()) 

    Public Property WaitForMore() As Boolean
        Get

            Return mbooWaitForMore
        End Get
        Set(ByVal Value As Boolean)
            mbooWaitForMore = Value

            'spellchecker_Activated(Nothing, Nothing)
        End Set
    End Property
    Public Property DoingCheck() As Boolean
        Get

            Return mbooDoingCheck
        End Get
        Set(ByVal Value As Boolean)
            mbooDoingCheck = Value

            'spellchecker_Activated(Nothing, Nothing)
            If mbooDoingCheck = True Then
                System.Windows.Forms.Application.DoEvents()
                Search()
            End If
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
    Dim mbooTopMost As Boolean 
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pbooTopMost As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        mbooTopMost = pbooTopMost 
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
    Friend WithEvents lblChecking As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnIgnore As System.Windows.Forms.Button
    Friend WithEvents btnLearn As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChangeTo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(spellchecker))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblChecking = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIgnore = New System.Windows.Forms.Button()
        Me.btnLearn = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChangeTo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AccessibleDescription = CType(resources.GetObject("lblStatus.AccessibleDescription"), String)
        Me.lblStatus.AccessibleName = CType(resources.GetObject("lblStatus.AccessibleName"), String)
        Me.lblStatus.Anchor = CType(resources.GetObject("lblStatus.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = CType(resources.GetObject("lblStatus.AutoSize"), Boolean)
        Me.lblStatus.Dock = CType(resources.GetObject("lblStatus.Dock"), System.Windows.Forms.DockStyle)
        Me.lblStatus.Enabled = CType(resources.GetObject("lblStatus.Enabled"), Boolean)
        Me.lblStatus.Font = CType(resources.GetObject("lblStatus.Font"), System.Drawing.Font)
        Me.lblStatus.Image = CType(resources.GetObject("lblStatus.Image"), System.Drawing.Image)
        Me.lblStatus.ImageAlign = CType(resources.GetObject("lblStatus.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblStatus.ImageIndex = CType(resources.GetObject("lblStatus.ImageIndex"), Integer)
        Me.lblStatus.ImeMode = CType(resources.GetObject("lblStatus.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblStatus.Location = CType(resources.GetObject("lblStatus.Location"), System.Drawing.Point)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = CType(resources.GetObject("lblStatus.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblStatus.Size = CType(resources.GetObject("lblStatus.Size"), System.Drawing.Size)
        Me.lblStatus.TabIndex = CType(resources.GetObject("lblStatus.TabIndex"), Integer)
        Me.lblStatus.Text = resources.GetString("lblStatus.Text")
        Me.lblStatus.TextAlign = CType(resources.GetObject("lblStatus.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblStatus.Visible = CType(resources.GetObject("lblStatus.Visible"), Boolean)
        '
        'lblChecking
        '
        Me.lblChecking.AccessibleDescription = CType(resources.GetObject("lblChecking.AccessibleDescription"), String)
        Me.lblChecking.AccessibleName = CType(resources.GetObject("lblChecking.AccessibleName"), String)
        Me.lblChecking.Anchor = CType(resources.GetObject("lblChecking.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblChecking.AutoSize = CType(resources.GetObject("lblChecking.AutoSize"), Boolean)
        Me.lblChecking.Dock = CType(resources.GetObject("lblChecking.Dock"), System.Windows.Forms.DockStyle)
        Me.lblChecking.Enabled = CType(resources.GetObject("lblChecking.Enabled"), Boolean)
        Me.lblChecking.Font = CType(resources.GetObject("lblChecking.Font"), System.Drawing.Font)
        Me.lblChecking.ForeColor = System.Drawing.Color.Blue
        Me.lblChecking.Image = CType(resources.GetObject("lblChecking.Image"), System.Drawing.Image)
        Me.lblChecking.ImageAlign = CType(resources.GetObject("lblChecking.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblChecking.ImageIndex = CType(resources.GetObject("lblChecking.ImageIndex"), Integer)
        Me.lblChecking.ImeMode = CType(resources.GetObject("lblChecking.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblChecking.Location = CType(resources.GetObject("lblChecking.Location"), System.Drawing.Point)
        Me.lblChecking.Name = "lblChecking"
        Me.lblChecking.RightToLeft = CType(resources.GetObject("lblChecking.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblChecking.Size = CType(resources.GetObject("lblChecking.Size"), System.Drawing.Size)
        Me.lblChecking.TabIndex = CType(resources.GetObject("lblChecking.TabIndex"), Integer)
        Me.lblChecking.Text = resources.GetString("lblChecking.Text")
        Me.lblChecking.TextAlign = CType(resources.GetObject("lblChecking.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblChecking.Visible = CType(resources.GetObject("lblChecking.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = CType(resources.GetObject("Panel1.AccessibleDescription"), String)
        Me.Panel1.AccessibleName = CType(resources.GetObject("Panel1.AccessibleName"), String)
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnIgnore, Me.btnLearn, Me.btnReplaceAll, Me.btnCancel, Me.btnChange, Me.Label1, Me.txtChangeTo})
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
        'btnIgnore
        '
        Me.btnIgnore.AccessibleDescription = CType(resources.GetObject("btnIgnore.AccessibleDescription"), String)
        Me.btnIgnore.AccessibleName = CType(resources.GetObject("btnIgnore.AccessibleName"), String)
        Me.btnIgnore.Anchor = CType(resources.GetObject("btnIgnore.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnIgnore.BackgroundImage = CType(resources.GetObject("btnIgnore.BackgroundImage"), System.Drawing.Image)
        Me.btnIgnore.Dock = CType(resources.GetObject("btnIgnore.Dock"), System.Windows.Forms.DockStyle)
        Me.btnIgnore.Enabled = CType(resources.GetObject("btnIgnore.Enabled"), Boolean)
        Me.btnIgnore.FlatStyle = CType(resources.GetObject("btnIgnore.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnIgnore.Font = CType(resources.GetObject("btnIgnore.Font"), System.Drawing.Font)
        Me.btnIgnore.Image = CType(resources.GetObject("btnIgnore.Image"), System.Drawing.Image)
        Me.btnIgnore.ImageAlign = CType(resources.GetObject("btnIgnore.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnIgnore.ImageIndex = CType(resources.GetObject("btnIgnore.ImageIndex"), Integer)
        Me.btnIgnore.ImeMode = CType(resources.GetObject("btnIgnore.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnIgnore.Location = CType(resources.GetObject("btnIgnore.Location"), System.Drawing.Point)
        Me.btnIgnore.Name = "btnIgnore"
        Me.btnIgnore.RightToLeft = CType(resources.GetObject("btnIgnore.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnIgnore.Size = CType(resources.GetObject("btnIgnore.Size"), System.Drawing.Size)
        Me.btnIgnore.TabIndex = CType(resources.GetObject("btnIgnore.TabIndex"), Integer)
        Me.btnIgnore.Text = resources.GetString("btnIgnore.Text")
        Me.btnIgnore.TextAlign = CType(resources.GetObject("btnIgnore.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnIgnore.Visible = CType(resources.GetObject("btnIgnore.Visible"), Boolean)
        '
        'btnLearn
        '
        Me.btnLearn.AccessibleDescription = CType(resources.GetObject("btnLearn.AccessibleDescription"), String)
        Me.btnLearn.AccessibleName = CType(resources.GetObject("btnLearn.AccessibleName"), String)
        Me.btnLearn.Anchor = CType(resources.GetObject("btnLearn.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnLearn.BackgroundImage = CType(resources.GetObject("btnLearn.BackgroundImage"), System.Drawing.Image)
        Me.btnLearn.Dock = CType(resources.GetObject("btnLearn.Dock"), System.Windows.Forms.DockStyle)
        Me.btnLearn.Enabled = CType(resources.GetObject("btnLearn.Enabled"), Boolean)
        Me.btnLearn.FlatStyle = CType(resources.GetObject("btnLearn.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnLearn.Font = CType(resources.GetObject("btnLearn.Font"), System.Drawing.Font)
        Me.btnLearn.Image = CType(resources.GetObject("btnLearn.Image"), System.Drawing.Image)
        Me.btnLearn.ImageAlign = CType(resources.GetObject("btnLearn.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnLearn.ImageIndex = CType(resources.GetObject("btnLearn.ImageIndex"), Integer)
        Me.btnLearn.ImeMode = CType(resources.GetObject("btnLearn.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnLearn.Location = CType(resources.GetObject("btnLearn.Location"), System.Drawing.Point)
        Me.btnLearn.Name = "btnLearn"
        Me.btnLearn.RightToLeft = CType(resources.GetObject("btnLearn.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnLearn.Size = CType(resources.GetObject("btnLearn.Size"), System.Drawing.Size)
        Me.btnLearn.TabIndex = CType(resources.GetObject("btnLearn.TabIndex"), Integer)
        Me.btnLearn.Text = resources.GetString("btnLearn.Text")
        Me.btnLearn.TextAlign = CType(resources.GetObject("btnLearn.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnLearn.Visible = CType(resources.GetObject("btnLearn.Visible"), Boolean)
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.AccessibleDescription = CType(resources.GetObject("btnReplaceAll.AccessibleDescription"), String)
        Me.btnReplaceAll.AccessibleName = CType(resources.GetObject("btnReplaceAll.AccessibleName"), String)
        Me.btnReplaceAll.Anchor = CType(resources.GetObject("btnReplaceAll.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnReplaceAll.BackgroundImage = CType(resources.GetObject("btnReplaceAll.BackgroundImage"), System.Drawing.Image)
        Me.btnReplaceAll.Dock = CType(resources.GetObject("btnReplaceAll.Dock"), System.Windows.Forms.DockStyle)
        Me.btnReplaceAll.Enabled = CType(resources.GetObject("btnReplaceAll.Enabled"), Boolean)
        Me.btnReplaceAll.FlatStyle = CType(resources.GetObject("btnReplaceAll.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnReplaceAll.Font = CType(resources.GetObject("btnReplaceAll.Font"), System.Drawing.Font)
        Me.btnReplaceAll.Image = CType(resources.GetObject("btnReplaceAll.Image"), System.Drawing.Image)
        Me.btnReplaceAll.ImageAlign = CType(resources.GetObject("btnReplaceAll.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnReplaceAll.ImageIndex = CType(resources.GetObject("btnReplaceAll.ImageIndex"), Integer)
        Me.btnReplaceAll.ImeMode = CType(resources.GetObject("btnReplaceAll.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnReplaceAll.Location = CType(resources.GetObject("btnReplaceAll.Location"), System.Drawing.Point)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.RightToLeft = CType(resources.GetObject("btnReplaceAll.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnReplaceAll.Size = CType(resources.GetObject("btnReplaceAll.Size"), System.Drawing.Size)
        Me.btnReplaceAll.TabIndex = CType(resources.GetObject("btnReplaceAll.TabIndex"), Integer)
        Me.btnReplaceAll.Text = resources.GetString("btnReplaceAll.Text")
        Me.btnReplaceAll.TextAlign = CType(resources.GetObject("btnReplaceAll.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnReplaceAll.Visible = CType(resources.GetObject("btnReplaceAll.Visible"), Boolean)
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
        'btnChange
        '
        Me.btnChange.AccessibleDescription = CType(resources.GetObject("btnChange.AccessibleDescription"), String)
        Me.btnChange.AccessibleName = CType(resources.GetObject("btnChange.AccessibleName"), String)
        Me.btnChange.Anchor = CType(resources.GetObject("btnChange.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnChange.BackgroundImage = CType(resources.GetObject("btnChange.BackgroundImage"), System.Drawing.Image)
        Me.btnChange.Dock = CType(resources.GetObject("btnChange.Dock"), System.Windows.Forms.DockStyle)
        Me.btnChange.Enabled = CType(resources.GetObject("btnChange.Enabled"), Boolean)
        Me.btnChange.FlatStyle = CType(resources.GetObject("btnChange.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnChange.Font = CType(resources.GetObject("btnChange.Font"), System.Drawing.Font)
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.ImageAlign = CType(resources.GetObject("btnChange.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnChange.ImageIndex = CType(resources.GetObject("btnChange.ImageIndex"), Integer)
        Me.btnChange.ImeMode = CType(resources.GetObject("btnChange.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnChange.Location = CType(resources.GetObject("btnChange.Location"), System.Drawing.Point)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.RightToLeft = CType(resources.GetObject("btnChange.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnChange.Size = CType(resources.GetObject("btnChange.Size"), System.Drawing.Size)
        Me.btnChange.TabIndex = CType(resources.GetObject("btnChange.TabIndex"), Integer)
        Me.btnChange.Text = resources.GetString("btnChange.Text")
        Me.btnChange.TextAlign = CType(resources.GetObject("btnChange.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnChange.Visible = CType(resources.GetObject("btnChange.Visible"), Boolean)
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
        'txtChangeTo
        '
        Me.txtChangeTo.AccessibleDescription = CType(resources.GetObject("txtChangeTo.AccessibleDescription"), String)
        Me.txtChangeTo.AccessibleName = CType(resources.GetObject("txtChangeTo.AccessibleName"), String)
        Me.txtChangeTo.Anchor = CType(resources.GetObject("txtChangeTo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtChangeTo.AutoSize = CType(resources.GetObject("txtChangeTo.AutoSize"), Boolean)
        Me.txtChangeTo.BackgroundImage = CType(resources.GetObject("txtChangeTo.BackgroundImage"), System.Drawing.Image)
        Me.txtChangeTo.Dock = CType(resources.GetObject("txtChangeTo.Dock"), System.Windows.Forms.DockStyle)
        Me.txtChangeTo.Enabled = CType(resources.GetObject("txtChangeTo.Enabled"), Boolean)
        Me.txtChangeTo.Font = CType(resources.GetObject("txtChangeTo.Font"), System.Drawing.Font)
        Me.txtChangeTo.ImeMode = CType(resources.GetObject("txtChangeTo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtChangeTo.Location = CType(resources.GetObject("txtChangeTo.Location"), System.Drawing.Point)
        Me.txtChangeTo.MaxLength = CType(resources.GetObject("txtChangeTo.MaxLength"), Integer)
        Me.txtChangeTo.Multiline = CType(resources.GetObject("txtChangeTo.Multiline"), Boolean)
        Me.txtChangeTo.Name = "txtChangeTo"
        Me.txtChangeTo.PasswordChar = CType(resources.GetObject("txtChangeTo.PasswordChar"), Char)
        Me.txtChangeTo.RightToLeft = CType(resources.GetObject("txtChangeTo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtChangeTo.ScrollBars = CType(resources.GetObject("txtChangeTo.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtChangeTo.Size = CType(resources.GetObject("txtChangeTo.Size"), System.Drawing.Size)
        Me.txtChangeTo.TabIndex = CType(resources.GetObject("txtChangeTo.TabIndex"), Integer)
        Me.txtChangeTo.Text = resources.GetString("txtChangeTo.Text")
        Me.txtChangeTo.TextAlign = CType(resources.GetObject("txtChangeTo.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtChangeTo.Visible = CType(resources.GetObject("txtChangeTo.Visible"), Boolean)
        Me.txtChangeTo.WordWrap = CType(resources.GetObject("txtChangeTo.WordWrap"), Boolean)
        '
        'spellchecker
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.lblChecking, Me.lblStatus})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "spellchecker"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Property TextBox() As Object
        Get
            Return mTextBox
        End Get
        Set(ByVal Value As Object)
            mTextBox = Value
        End Set
    End Property
    Public Property DictionaryFile() As String
        Get
            Return mstrDictionaryFile
        End Get
        Set(ByVal Value As String)
            mstrDictionaryFile = Value
        End Set
    End Property
    Public Property CustomDictionaryFile() As String
        Get
            Return mstrCustomDictionaryFile
        End Get
        Set(ByVal Value As String)
            mstrCustomDictionaryFile = Value
        End Set
    End Property
    Private Sub spellchecker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnIgnore.FlatStyle = FlatStyle.System
            btnLearn.FlatStyle = FlatStyle.System
            btnReplaceAll.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnChange.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        Me.Height = 64
        KeyPreview = True 

    End Sub
    Private Function LoadDictionary() As String
        'lblStatus.Text = "Loading dictionary..."
        lblStatus.Text = LangText.GetString("Spell_LoadingDict") 

        System.Windows.Forms.Application.DoEvents()
        Dim OpenFile As FileStream = New FileStream(mstrDictionaryFile, FileMode.Open, FileAccess.Read, FileShare.Read)

        'Dim StreamReader As StreamReader = New StreamReader(OpenFile)
        
        Dim StreamReader As StreamReader = New StreamReader(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))

        LoadDictionary = StreamReader.ReadToEnd '.Read 'Line()
        StreamReader.Close()
        OpenFile.Close()
    End Function
    Private Function LoadCustomDictionary() As String

        If File.Exists(mstrCustomDictionaryFile) = False Then
            LoadCustomDictionary = ""
            Exit Function
        End If
        Dim OpenFile As FileStream = New FileStream(mstrCustomDictionaryFile, FileMode.Open, FileAccess.Read, FileShare.Read)

        'Dim StreamReader As StreamReader = New StreamReader(OpenFile)
        
        Dim StreamReader As StreamReader = New StreamReader(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))

        LoadCustomDictionary = StreamReader.ReadToEnd '.Read 'Line()
        StreamReader.Close()
        OpenFile.Close()
    End Function
    Private Sub Search()
        Me.Height = 64
        Panel1.Visible = False
        lblChecking.Text = ""
        lblChecking.ForeColor = System.Drawing.Color.Blue

        System.Windows.Forms.Application.DoEvents() 

        If lstrDictionaryFileStr = "" Then
            lstrDictionaryFileStr = LoadDictionary().ToUpper
            lstrCustomDictionaryFileStr = LoadCustomDictionary()
        End If

        'lblStatus.Text = "Checking words ..."
        lblStatus.Text = LangText.GetString("Spell_Checking") 

        System.Windows.Forms.Application.DoEvents()

        Dim lstrCurrentWord As String = " "
        Do Until lstrCurrentWord = "" Or lstrCurrentWord Is Nothing

            lstrCurrentWord = GextNextWord(mTextBox.Text & " ") 'added " " 

            If lstrCurrentWord = "" Or lstrCurrentWord Is Nothing Then Exit Do 

            lstrCurrentWord = lstrCurrentWord.TrimStart 

            lstrCurrentWord = WordFixes(lstrCurrentWord) 
            lstrCurrentWord = WordFixes(lstrCurrentWord) 'added again to cater for (s), etc

            lblChecking.Text = lstrCurrentWord
            lblChecking.ForeColor = System.Drawing.Color.Blue
            'System.Windows.Forms.Application.DoEvents()

            Dim lintArrInc As Integer
            Dim lbooIgnoreWord As Boolean = False
            For lintArrInc = 0 To lstrIgnoreWords.GetUpperBound(0) 
                If lstrIgnoreWords(lintArrInc) = lstrCurrentWord Then
                    lbooIgnoreWord = True
                    Exit For
                End If
            Next lintArrInc

            If ContainsDigits(lstrCurrentWord) = False Then 
                If lbooIgnoreWord = False Then 
                    If InStrGet(lstrDictionaryFileStr, lstrCurrentWord.ToUpper & CR()) = 0 And _
                        InStrGet(lstrCustomDictionaryFileStr, lstrCurrentWord & CR()) = 0 Then
                        lblChecking.ForeColor = Color.Red
                        'lblStatus.Text = "Word not found : "
                        lblStatus.Text = LangText.GetString("Spell_WordNotFound") & " " 
                        'Conxsole.WriteLine("Not Found : " & lstrCurrentWord)
                        Me.Height = 128
                        Panel1.Visible = True
                        txtChangeTo.Focus()
                        Exit Sub
                    End If
                End If 'lbooIgnoreWord
            End If 'ContainsDigits
        Loop

        If mbooWaitForMore = False Then
            'MxessageBox.Show("Spell check completed OK!", mstrCaption)  
            If mbooTopMost = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("Spell_CheckCompletedOK"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 

            'Me.Focus()
            System.Windows.Forms.Application.DoEvents()
            Me.Owner.Focus() 
            'Me.Owner.BringToFront() 

            Me.Close()
        Else
            mbooDoingCheck = False 'this will allow outsite process to continue
            lintWordPos = 1
            llngSelStart = 0
            llngSelLen = 0
            System.Windows.Forms.Application.DoEvents()
        End If

    End Sub
    Private Sub AdjustCurPos(ByVal pstrReplacementWord As String)

        If pstrReplacementWord.Length > llngSelLen Then
            lintWordPos += (pstrReplacementWord.Length - llngSelLen)
        ElseIf pstrReplacementWord.Length < llngSelLen Then
            lintWordPos -= (llngSelLen - pstrReplacementWord.Length)
        End If

    End Sub
    Private Function GextNextWord(ByVal pstrWords As String) As String
        Dim llngCurPos As Long = lintWordPos
        Dim lstrCurChar As String
        Dim lbooGotRealChar As Boolean = False
        Dim lbooSearchForWord As Boolean = False

        llngCurPos = lintWordPos

        Do While llngCurPos <> 0
            lstrCurChar = MidGet(pstrWords, llngCurPos, 1)
            If lstrCurChar = "" Then Exit Function
            'If IsValidChar(lstrCurChar) = True Then 
            If IsRealChar(lstrCurChar) = True Then 
                lbooSearchForWord = True
            End If

            'Console.WriteLine("@" & lstrCurChar & "@" & MidGet(pstrWords, llngCurPos + 1, 1) & "@")
            If lbooSearchForWord = True Then 
                If lstrCurChar = Tab() Or lstrCurChar = " " Or lstrCurChar = ChrGet(12) Or lstrCurChar = ChrGet(10) Then
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 1
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "." And MidGet(pstrWords, llngCurPos + 1, 1) = " " Then '   ". "
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "." And MidGet(pstrWords, llngCurPos + 1, 1) = ChrGet(10) Then '   "." & cr
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "?" And MidGet(pstrWords, llngCurPos + 1, 1) = ChrGet(10) Then '   "." & cr
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "?" And MidGet(pstrWords, llngCurPos + 1, 1) = " " Then '   ". "
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "!" And MidGet(pstrWords, llngCurPos + 1, 1) = ChrGet(10) Then '   "." & cr
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function
                ElseIf lstrCurChar = "!" And MidGet(pstrWords, llngCurPos + 1, 1) = " " Then '   ". "
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    'If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                    lbooSearchForWord = False 'reset var
                    If GextNextWord.Trim <> "" Then Exit Function
                    'Exit Function

                    
                ElseIf lstrCurChar = "-" And InStrGet("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Microsoft.VisualBasic.UCase(MidGet(pstrWords, llngCurPos + 1, 1))) > 0 Then '  Caters for hyphenated words
                    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    llngSelStart = lintWordPos - 1
                    llngSelLen = (llngCurPos - lintWordPos)
                    lintWordPos = llngCurPos + 2
                    lbooSearchForWord = False
                    If GextNextWord.Trim <> "" Then Exit Function
                    

                    'if you cater for forwards slashed words, you'llhave to cater for urls... nightmare 
                    ''    
                    ''ElseIf lstrCurChar = "/" And InStrGet("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Microsoft.VisualBasic.UCase(MidGet(pstrWords, llngCurPos + 1, 1))) > 0 Then '  Caters for forward slash words

                    ''    GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                    ''    If RightGet(GextNextWord, 1) = "/" Then 'cater for urls
                    ''        GextNextWord = Nothing
                    ''        llngCurPos += 1
                    ''    Else
                    ''        llngSelStart = lintWordPos - 1
                    ''        llngSelLen = (llngCurPos - lintWordPos)
                    ''        lintWordPos = llngCurPos + 2
                    ''        lbooSearchForWord = False
                    ''        If GextNextWord.Trim <> "" Then Exit Function
                    ''    End If
                    ''    

                ElseIf lstrCurChar = "-" And MidGet(pstrWords, llngCurPos + 1, 1) = " " Then  '   "-" & cr
                        'Console.WriteLine("found : $" & GextNextWord & "$")
                        llngCurPos += 1
                        'lintWordPos += 1
                        lbooSearchForWord = False
                        'GextNextWord = (MidGet(pstrWords, lintWordPos, (llngCurPos - lintWordPos)))
                        'llngSelStart = lintWordPos - 1
                        'llngSelLen = (llngCurPos - lintWordPos)
                        'lintWordPos = llngCurPos + 2
                        ''If el = True Then : Console.WriteLine("found : #" & GextNextWord & "#") : End If
                        'lbooSearchForWord = False 'reset var
                        'If GextNextWord.Trim <> "" Then Exit Function
                Else
                        llngCurPos += 1
                End If
            Else
                llngCurPos += 1
                lintWordPos += 1
            End If 'GotRealChar 
        Loop

    End Function
    Private Function IsRealChar(ByVal pstrChar As String) As Boolean

        'IsRealChar = True
        IsRealChar = False 

        Select Case pstrChar
            Case ChrGet(10), Tab(), ChrGet(12), " " ', ",", "?", "!", "$", "#", "%", "^"
                IsRealChar = False
                '        'Case Else
                '        'Conxsole.WriteLine("VC? : #" & pstrChar & "#" & AscGet(pstrChar))
        End Select

        If InStrGet("esia�nrtolcdugmphbyfvkw-'zqjxSNRTLCGDMPHBEAUYOFIVKW����ZQJX����������", pstrChar) > 0 Then
            IsRealChar = True
        End If

    End Function
    Private Sub spellchecker_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        '------------------ crc check -------------------------
        Dim IRes As Integer
        'IRes = SetTopicTree()
        IRes = GetWrittenCRC(AppExe) 
        IRes = 1 'for testing purposes
        Dim lstrDetails(2) As String
        Dim lstrRetVal3 As String

        'lstrDetails(0) = "33BlmanKSHXtepRhVs"
        'lstrDetails(1) = "b?\jaiTqB;Tx_@fhh;VpdrcEgr<;s<QdrZ_atk[?rDGvOuHbOa?R\P]rjS]iAV?<W?Do?D"
        'lstrDetails(2) = "Kq@bj;jnkNhfMc?sFqxxL<XLAogPOJL;eCzfLWaf=_`ENz`Fg`JPrglqVV"

        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "kLU;ZKTKZFRKUZv?nnZ<TQN;UGZ<EGU;VZX?AZF?RUZ<JHK;SHY;MZR?YGZ<XUW;KMU;ZW"
        lstrDetails(2) = "KKHHE;JFU;VNZ@JNU;YGU;ZHUKMQLKGFY;NNZ<FRU;ZJHKKSH;YMY<mpmP"
        

        lstrRetVal3 = Decrypt(lstrDetails)

        'IRes = 1 'for testing purposes

        If IRes = 1 Then
            '
        ElseIf IRes = -1 Then
            If mbooTopMost = True Then Me.Activate() 
            MessageBox.Show(lstrRetVal3, "RTF Stand   ", MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
            Me.Close()
        Else
            If mbooTopMost = True Then Me.Activate() 
            MessageBox.Show(lstrRetVal3, "RTF Stand     ", MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
            Me.Close()
        End If
        '------------------ crc check -------------------------

        'If mbooDoingCheck = True Then 'If lbooSearchStarted = False Then
        '    'lbooSearchStarted = True
        '    System.Windows.Forms.Application.DoEvents()
        '    Search()
        'End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnore.Click
        ReDim Preserve lstrIgnoreWords(lstrIgnoreWords.GetUpperBound(0) + 1)
        lstrIgnoreWords(lstrIgnoreWords.GetUpperBound(0)) = lblChecking.Text
        Search()
    End Sub
    Private Sub btnLearn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLearn.Click

        'add to dictionary
        Dim OpenFile As FileStream

        If File.Exists(mstrCustomDictionaryFile) = True Then
            OpenFile = New FileStream(mstrCustomDictionaryFile, FileMode.Append, FileAccess.Write, FileShare.Write)
        Else
            OpenFile = New FileStream(mstrCustomDictionaryFile, FileMode.CreateNew, FileAccess.Write, FileShare.Write)
        End If

        Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
        StreamWriter.WriteLine(lblChecking.Text & CR())
        StreamWriter.Close()

        lstrCustomDictionaryFileStr = LoadCustomDictionary()

        Search()
    End Sub
    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click

        mTextBox.SelectedText = mTextBox.SelectedText.Replace(lblChecking.Text, txtChangeTo.Text)

        AdjustCurPos(txtChangeTo.Text)
        Search()
        txtChangeTo.Text = "" 

    End Sub
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        With mTextBox
            .SelectionStart = llngSelStart
            .SelectionLength = llngSelLen
            .SelectedText = txtChangeTo.Text

        End With

        AdjustCurPos(txtChangeTo.Text)
        Search()

        txtChangeTo.Text = "" 
    End Sub
    Private Sub spellchecker_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        MyBase.Dispose()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Function Replacements(ByVal pstrWord As String, ByVal pstrFind As String, ByVal pstrReplace As String) As String

        Dim lRegEx As New System.Text.RegularExpressions.Regex("")
        Replacements = lRegEx.Replace(pstrWord, pstrFind, pstrReplace, _
            RegexOptions.IgnoreCase Or RegexOptions.Multiline)
    End Function
    Private Function WordFixes(ByVal pstrWord As String) As String


        WordFixes = pstrWord
        WordFixes = Replacements(WordFixes, "�", "'") 
        WordFixes = Replacements(WordFixes, "`", "'") 
        WordFixes = Replacements(WordFixes, ChrGet(145), "'") 

        If LeftGet(WordFixes, 1) = "'" Then : WordFixes = RightGet(WordFixes, WordFixes.Length - 1) : End If
        If LeftGet(WordFixes, 1) = ChrGet(34) Then : WordFixes = RightGet(WordFixes, WordFixes.Length - 1) : End If
        If LeftGet(WordFixes, 1) = ChrGet(147) Then : WordFixes = RightGet(WordFixes, WordFixes.Length - 1) : End If

        
        If Microsoft.VisualBasic.IsNumeric(RightGet(WordFixes, 1)) = True Then

            Dim NumEnd As Integer
            Dim i As Integer
            For i = 1 To WordFixes.Length
                If Microsoft.VisualBasic.IsNumeric(RightGet(WordFixes, i)) = False Then

                    'not a number anymore
                    NumEnd = i
                    Exit For
                End If
            Next

            'If there is a number on the end, then it will remove the number so the spelling is correct like all the other stuff :)
            WordFixes = LeftGet(WordFixes, WordFixes.Length - NumEnd)

        End If
        

        If RightGet(WordFixes, 1) = "," Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = ";" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "'" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = ":" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If

        If RightGet(WordFixes, 1) = ChrGet(34) Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = ChrGet(148) Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        

        If RightGet(WordFixes, 1) = ChrGet(34) Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If

        If RightGet(WordFixes, 1) = "(" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "@" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "#" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "�" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "/" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "|" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "\" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "�" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "�" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "$" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "%" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "^" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "&" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "*" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "-" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "_" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "=" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "+" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "[" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "{" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "]" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "}" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "~" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "<" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = ">" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "?" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        
        If RightGet(WordFixes, 1) = "!" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "." Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If
        If RightGet(WordFixes, 1) = "." Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If

        If RightGet(WordFixes, 1) = ChrGet(133) Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If

        If WordFixes.Length > 3 Then 
            If RightGet(Microsoft.VisualBasic.LCase(WordFixes), 3) = "(r)" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 3) : End If 
            If RightGet(Microsoft.VisualBasic.LCase(WordFixes), 3) = "(c)" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 3) : End If 
            If RightGet(Microsoft.VisualBasic.LCase(WordFixes), 3) = "(s)" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 3) : End If 
        End If

        If RightGet(WordFixes, 1) = ")" Then : WordFixes = LeftGet(WordFixes, WordFixes.Length - 1) : End If

        If LeftGet(WordFixes, 1) = "(" Then : WordFixes = RightGet(WordFixes, WordFixes.Length - 1) : End If

    End Function

    Private Sub spellchecker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Sub SetBackcolors()

        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        lblChecking.BackColor = Color.FromArgb(0, lblChecking.BackColor)
        btnReplaceAll.BackColor = Color.FromArgb(0, btnReplaceAll.BackColor)
        lblStatus.BackColor = Color.FromArgb(0, lblStatus.BackColor)
        Panel1.BackColor = Color.FromArgb(0, Panel1.BackColor)
        btnIgnore.BackColor = Color.FromArgb(0, btnIgnore.BackColor)
        btnLearn.BackColor = Color.FromArgb(0, btnLearn.BackColor)
        btnChange.BackColor = Color.FromArgb(0, btnChange.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub spellchecker_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
