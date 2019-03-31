
Public Class TemplateOption
    Inherits System.Windows.Forms.Form
    Dim mstrChoice As String
    Dim mbooAlways As Boolean
    Dim mstrCaption As String
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
    Public Property Always() As Boolean
        Get

            Return mbooAlways
        End Get
        Set(ByVal Value As Boolean)
            mbooAlways = Value
        End Set
    End Property
    Public Property Choice() As String
        Get

            Return mstrChoice
        End Get
        Set(ByVal Value As String)
            mstrChoice = Value
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents chkAlways As System.Windows.Forms.CheckBox
    Friend WithEvents rdoOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents rdoOptionRapidEntry As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateOption))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoOption1 = New System.Windows.Forms.RadioButton()
        Me.rdoOption2 = New System.Windows.Forms.RadioButton()
        Me.rdoOption3 = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkAlways = New System.Windows.Forms.CheckBox()
        Me.rdoOption4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.rdoOptionRapidEntry = New System.Windows.Forms.RadioButton()
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
        'rdoOption1
        '
        Me.rdoOption1.AccessibleDescription = CType(resources.GetObject("rdoOption1.AccessibleDescription"), String)
        Me.rdoOption1.AccessibleName = CType(resources.GetObject("rdoOption1.AccessibleName"), String)
        Me.rdoOption1.Anchor = CType(resources.GetObject("rdoOption1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoOption1.Appearance = CType(resources.GetObject("rdoOption1.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoOption1.BackgroundImage = CType(resources.GetObject("rdoOption1.BackgroundImage"), System.Drawing.Image)
        Me.rdoOption1.CheckAlign = CType(resources.GetObject("rdoOption1.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption1.Checked = True
        Me.rdoOption1.Dock = CType(resources.GetObject("rdoOption1.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoOption1.Enabled = CType(resources.GetObject("rdoOption1.Enabled"), Boolean)
        Me.rdoOption1.FlatStyle = CType(resources.GetObject("rdoOption1.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoOption1.Font = CType(resources.GetObject("rdoOption1.Font"), System.Drawing.Font)
        Me.rdoOption1.Image = CType(resources.GetObject("rdoOption1.Image"), System.Drawing.Image)
        Me.rdoOption1.ImageAlign = CType(resources.GetObject("rdoOption1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption1.ImageIndex = CType(resources.GetObject("rdoOption1.ImageIndex"), Integer)
        Me.rdoOption1.ImeMode = CType(resources.GetObject("rdoOption1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoOption1.Location = CType(resources.GetObject("rdoOption1.Location"), System.Drawing.Point)
        Me.rdoOption1.Name = "rdoOption1"
        Me.rdoOption1.RightToLeft = CType(resources.GetObject("rdoOption1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoOption1.Size = CType(resources.GetObject("rdoOption1.Size"), System.Drawing.Size)
        Me.rdoOption1.TabIndex = CType(resources.GetObject("rdoOption1.TabIndex"), Integer)
        Me.rdoOption1.TabStop = True
        Me.rdoOption1.Text = resources.GetString("rdoOption1.Text")
        Me.rdoOption1.TextAlign = CType(resources.GetObject("rdoOption1.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption1.Visible = CType(resources.GetObject("rdoOption1.Visible"), Boolean)
        '
        'rdoOption2
        '
        Me.rdoOption2.AccessibleDescription = CType(resources.GetObject("rdoOption2.AccessibleDescription"), String)
        Me.rdoOption2.AccessibleName = CType(resources.GetObject("rdoOption2.AccessibleName"), String)
        Me.rdoOption2.Anchor = CType(resources.GetObject("rdoOption2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoOption2.Appearance = CType(resources.GetObject("rdoOption2.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoOption2.BackgroundImage = CType(resources.GetObject("rdoOption2.BackgroundImage"), System.Drawing.Image)
        Me.rdoOption2.CheckAlign = CType(resources.GetObject("rdoOption2.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption2.Dock = CType(resources.GetObject("rdoOption2.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoOption2.Enabled = CType(resources.GetObject("rdoOption2.Enabled"), Boolean)
        Me.rdoOption2.FlatStyle = CType(resources.GetObject("rdoOption2.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoOption2.Font = CType(resources.GetObject("rdoOption2.Font"), System.Drawing.Font)
        Me.rdoOption2.Image = CType(resources.GetObject("rdoOption2.Image"), System.Drawing.Image)
        Me.rdoOption2.ImageAlign = CType(resources.GetObject("rdoOption2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption2.ImageIndex = CType(resources.GetObject("rdoOption2.ImageIndex"), Integer)
        Me.rdoOption2.ImeMode = CType(resources.GetObject("rdoOption2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoOption2.Location = CType(resources.GetObject("rdoOption2.Location"), System.Drawing.Point)
        Me.rdoOption2.Name = "rdoOption2"
        Me.rdoOption2.RightToLeft = CType(resources.GetObject("rdoOption2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoOption2.Size = CType(resources.GetObject("rdoOption2.Size"), System.Drawing.Size)
        Me.rdoOption2.TabIndex = CType(resources.GetObject("rdoOption2.TabIndex"), Integer)
        Me.rdoOption2.Text = resources.GetString("rdoOption2.Text")
        Me.rdoOption2.TextAlign = CType(resources.GetObject("rdoOption2.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption2.Visible = CType(resources.GetObject("rdoOption2.Visible"), Boolean)
        '
        'rdoOption3
        '
        Me.rdoOption3.AccessibleDescription = CType(resources.GetObject("rdoOption3.AccessibleDescription"), String)
        Me.rdoOption3.AccessibleName = CType(resources.GetObject("rdoOption3.AccessibleName"), String)
        Me.rdoOption3.Anchor = CType(resources.GetObject("rdoOption3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoOption3.Appearance = CType(resources.GetObject("rdoOption3.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoOption3.BackgroundImage = CType(resources.GetObject("rdoOption3.BackgroundImage"), System.Drawing.Image)
        Me.rdoOption3.CheckAlign = CType(resources.GetObject("rdoOption3.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption3.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoOption3.Dock = CType(resources.GetObject("rdoOption3.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoOption3.Enabled = CType(resources.GetObject("rdoOption3.Enabled"), Boolean)
        Me.rdoOption3.FlatStyle = CType(resources.GetObject("rdoOption3.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoOption3.Font = CType(resources.GetObject("rdoOption3.Font"), System.Drawing.Font)
        Me.rdoOption3.Image = CType(resources.GetObject("rdoOption3.Image"), System.Drawing.Image)
        Me.rdoOption3.ImageAlign = CType(resources.GetObject("rdoOption3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption3.ImageIndex = CType(resources.GetObject("rdoOption3.ImageIndex"), Integer)
        Me.rdoOption3.ImeMode = CType(resources.GetObject("rdoOption3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoOption3.Location = CType(resources.GetObject("rdoOption3.Location"), System.Drawing.Point)
        Me.rdoOption3.Name = "rdoOption3"
        Me.rdoOption3.RightToLeft = CType(resources.GetObject("rdoOption3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoOption3.Size = CType(resources.GetObject("rdoOption3.Size"), System.Drawing.Size)
        Me.rdoOption3.TabIndex = CType(resources.GetObject("rdoOption3.TabIndex"), Integer)
        Me.rdoOption3.Text = resources.GetString("rdoOption3.Text")
        Me.rdoOption3.TextAlign = CType(resources.GetObject("rdoOption3.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption3.Visible = CType(resources.GetObject("rdoOption3.Visible"), Boolean)
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
        'chkAlways
        '
        Me.chkAlways.AccessibleDescription = CType(resources.GetObject("chkAlways.AccessibleDescription"), String)
        Me.chkAlways.AccessibleName = CType(resources.GetObject("chkAlways.AccessibleName"), String)
        Me.chkAlways.Anchor = CType(resources.GetObject("chkAlways.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkAlways.Appearance = CType(resources.GetObject("chkAlways.Appearance"), System.Windows.Forms.Appearance)
        Me.chkAlways.BackgroundImage = CType(resources.GetObject("chkAlways.BackgroundImage"), System.Drawing.Image)
        Me.chkAlways.CheckAlign = CType(resources.GetObject("chkAlways.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkAlways.Dock = CType(resources.GetObject("chkAlways.Dock"), System.Windows.Forms.DockStyle)
        Me.chkAlways.Enabled = CType(resources.GetObject("chkAlways.Enabled"), Boolean)
        Me.chkAlways.FlatStyle = CType(resources.GetObject("chkAlways.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkAlways.Font = CType(resources.GetObject("chkAlways.Font"), System.Drawing.Font)
        Me.chkAlways.Image = CType(resources.GetObject("chkAlways.Image"), System.Drawing.Image)
        Me.chkAlways.ImageAlign = CType(resources.GetObject("chkAlways.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkAlways.ImageIndex = CType(resources.GetObject("chkAlways.ImageIndex"), Integer)
        Me.chkAlways.ImeMode = CType(resources.GetObject("chkAlways.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkAlways.Location = CType(resources.GetObject("chkAlways.Location"), System.Drawing.Point)
        Me.chkAlways.Name = "chkAlways"
        Me.chkAlways.RightToLeft = CType(resources.GetObject("chkAlways.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkAlways.Size = CType(resources.GetObject("chkAlways.Size"), System.Drawing.Size)
        Me.chkAlways.TabIndex = CType(resources.GetObject("chkAlways.TabIndex"), Integer)
        Me.chkAlways.Text = resources.GetString("chkAlways.Text")
        Me.chkAlways.TextAlign = CType(resources.GetObject("chkAlways.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkAlways.Visible = CType(resources.GetObject("chkAlways.Visible"), Boolean)
        '
        'rdoOption4
        '
        Me.rdoOption4.AccessibleDescription = CType(resources.GetObject("rdoOption4.AccessibleDescription"), String)
        Me.rdoOption4.AccessibleName = CType(resources.GetObject("rdoOption4.AccessibleName"), String)
        Me.rdoOption4.Anchor = CType(resources.GetObject("rdoOption4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoOption4.Appearance = CType(resources.GetObject("rdoOption4.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoOption4.BackgroundImage = CType(resources.GetObject("rdoOption4.BackgroundImage"), System.Drawing.Image)
        Me.rdoOption4.CheckAlign = CType(resources.GetObject("rdoOption4.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption4.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoOption4.Dock = CType(resources.GetObject("rdoOption4.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoOption4.Enabled = CType(resources.GetObject("rdoOption4.Enabled"), Boolean)
        Me.rdoOption4.FlatStyle = CType(resources.GetObject("rdoOption4.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoOption4.Font = CType(resources.GetObject("rdoOption4.Font"), System.Drawing.Font)
        Me.rdoOption4.Image = CType(resources.GetObject("rdoOption4.Image"), System.Drawing.Image)
        Me.rdoOption4.ImageAlign = CType(resources.GetObject("rdoOption4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption4.ImageIndex = CType(resources.GetObject("rdoOption4.ImageIndex"), Integer)
        Me.rdoOption4.ImeMode = CType(resources.GetObject("rdoOption4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoOption4.Location = CType(resources.GetObject("rdoOption4.Location"), System.Drawing.Point)
        Me.rdoOption4.Name = "rdoOption4"
        Me.rdoOption4.RightToLeft = CType(resources.GetObject("rdoOption4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoOption4.Size = CType(resources.GetObject("rdoOption4.Size"), System.Drawing.Size)
        Me.rdoOption4.TabIndex = CType(resources.GetObject("rdoOption4.TabIndex"), Integer)
        Me.rdoOption4.Text = resources.GetString("rdoOption4.Text")
        Me.rdoOption4.TextAlign = CType(resources.GetObject("rdoOption4.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoOption4.Visible = CType(resources.GetObject("rdoOption4.Visible"), Boolean)
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
        'rdoOptionRapidEntry
        '
        Me.rdoOptionRapidEntry.AccessibleDescription = CType(resources.GetObject("rdoOptionRapidEntry.AccessibleDescription"), String)
        Me.rdoOptionRapidEntry.AccessibleName = CType(resources.GetObject("rdoOptionRapidEntry.AccessibleName"), String)
        Me.rdoOptionRapidEntry.Anchor = CType(resources.GetObject("rdoOptionRapidEntry.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.rdoOptionRapidEntry.Appearance = CType(resources.GetObject("rdoOptionRapidEntry.Appearance"), System.Windows.Forms.Appearance)
        Me.rdoOptionRapidEntry.BackgroundImage = CType(resources.GetObject("rdoOptionRapidEntry.BackgroundImage"), System.Drawing.Image)
        Me.rdoOptionRapidEntry.CheckAlign = CType(resources.GetObject("rdoOptionRapidEntry.CheckAlign"), System.Drawing.ContentAlignment)
        Me.rdoOptionRapidEntry.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoOptionRapidEntry.Dock = CType(resources.GetObject("rdoOptionRapidEntry.Dock"), System.Windows.Forms.DockStyle)
        Me.rdoOptionRapidEntry.Enabled = CType(resources.GetObject("rdoOptionRapidEntry.Enabled"), Boolean)
        Me.rdoOptionRapidEntry.FlatStyle = CType(resources.GetObject("rdoOptionRapidEntry.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.rdoOptionRapidEntry.Font = CType(resources.GetObject("rdoOptionRapidEntry.Font"), System.Drawing.Font)
        Me.rdoOptionRapidEntry.Image = CType(resources.GetObject("rdoOptionRapidEntry.Image"), System.Drawing.Image)
        Me.rdoOptionRapidEntry.ImageAlign = CType(resources.GetObject("rdoOptionRapidEntry.ImageAlign"), System.Drawing.ContentAlignment)
        Me.rdoOptionRapidEntry.ImageIndex = CType(resources.GetObject("rdoOptionRapidEntry.ImageIndex"), Integer)
        Me.rdoOptionRapidEntry.ImeMode = CType(resources.GetObject("rdoOptionRapidEntry.ImeMode"), System.Windows.Forms.ImeMode)
        Me.rdoOptionRapidEntry.Location = CType(resources.GetObject("rdoOptionRapidEntry.Location"), System.Drawing.Point)
        Me.rdoOptionRapidEntry.Name = "rdoOptionRapidEntry"
        Me.rdoOptionRapidEntry.RightToLeft = CType(resources.GetObject("rdoOptionRapidEntry.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.rdoOptionRapidEntry.Size = CType(resources.GetObject("rdoOptionRapidEntry.Size"), System.Drawing.Size)
        Me.rdoOptionRapidEntry.TabIndex = CType(resources.GetObject("rdoOptionRapidEntry.TabIndex"), Integer)
        Me.rdoOptionRapidEntry.Text = resources.GetString("rdoOptionRapidEntry.Text")
        Me.rdoOptionRapidEntry.TextAlign = CType(resources.GetObject("rdoOptionRapidEntry.TextAlign"), System.Drawing.ContentAlignment)
        Me.rdoOptionRapidEntry.Visible = CType(resources.GetObject("rdoOptionRapidEntry.Visible"), Boolean)
        '
        'TemplateOption
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdoOptionRapidEntry, Me.btnHelp, Me.Label2, Me.rdoOption4, Me.chkAlways, Me.btnOK, Me.btnCancel, Me.rdoOption3, Me.rdoOption2, Me.rdoOption1, Me.Label1})
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
        Me.Name = "TemplateOption"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        DialogResult = DialogResult.OK 

        If rdoOption1.Checked = True Then
            mstrChoice = "ROOT"
        ElseIf rdoOption2.Checked = True Then
            mstrChoice = "SUB"
        ElseIf rdoOption3.Checked = True Then
            
            Dim dlgResult As DialogResult
            If mbooTopMost = True Then Me.Activate() 
            dlgResult = MessageBox.Show(LangText.GetString("TempOp_WARNTempDataLoose"), mstrCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResult <> DialogResult.Yes Then
                DialogResult = DialogResult.None
                Exit Sub
            End If
            
            mstrChoice = "OVERWRITE"
        ElseIf rdoOption4.Checked = True Then
            mstrChoice = "MERGE"
        ElseIf rdoOptionRapidEntry.Checked = True Then 
            mstrChoice = "RAPID" 
        End If

        If chkAlways.Checked = True Then
            mbooAlways = True
        Else
            mbooAlways = False
        End If

    End Sub
    Private Sub TemplateOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkAlways.Visible = False 'don't seem to be used

        
        If IsAboveOrEqualWinXp() = True Then  
            btnCancel.FlatStyle = FlatStyle.System
            btnOK.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            
            rdoOption1.FlatStyle = FlatStyle.System
            rdoOption2.FlatStyle = FlatStyle.System
            rdoOption3.FlatStyle = FlatStyle.System
            rdoOption4.FlatStyle = FlatStyle.System
            rdoOptionRapidEntry.FlatStyle = FlatStyle.System
            
        End If
        'rdoOption1.FlatStyle = FlatStyle.System
        'rdoOption2.FlatStyle = FlatStyle.System
        'rdoOption3.FlatStyle = FlatStyle.System
        'rdoOption4.FlatStyle = FlatStyle.System
        'rdoOptionRapidEntry.FlatStyle = FlatStyle.System
        'chkAlways.FlatStyle = FlatStyle.System
        

        SetBackcolors() 

        Me.Text = mstrCaption
    End Sub
    Private Sub TemplateOption_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing) 
        End If

        
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

        
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, mstrHelpFile, HelpNavigator.Topic, mstrHelpTopic) 
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 
    End Sub
    Private Sub SetBackcolors()

        'Added 
        rdoOption1.BackColor = Color.FromArgb(0, rdoOption1.BackColor)
        rdoOption2.BackColor = Color.FromArgb(0, rdoOption2.BackColor)
        rdoOption3.BackColor = Color.FromArgb(0, rdoOption3.BackColor)
        rdoOption4.BackColor = Color.FromArgb(0, rdoOption4.BackColor)
        rdoOptionRapidEntry.BackColor = Color.FromArgb(0, rdoOptionRapidEntry.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        chkAlways.BackColor = Color.FromArgb(0, chkAlways.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

        ''Added 
        'If IsAboveOrEqualWinXp() = True Then
        '    rdoOption1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoOption1.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoOption1.Top, rdoOption1.Left, rdoOption1.Width, rdoOption1.Height)
        '    rdoOption2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoOption2.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoOption2.Top, rdoOption2.Left, rdoOption2.Width, rdoOption2.Height)
        '    rdoOption3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoOption3.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoOption3.Top, rdoOption3.Left, rdoOption3.Width, rdoOption3.Height)
        '    rdoOption4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoOption4.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoOption4.Top, rdoOption4.Left, rdoOption4.Width, rdoOption4.Height)
        '    rdoOptionRapidEntry.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        '    rdoOptionRapidEntry.BackgroundImage = PaintBack.PaintBackgroundToFit(pevent, Me.Height, Me.Width, rdoOptionRapidEntry.Top, rdoOptionRapidEntry.Left, rdoOptionRapidEntry.Width, rdoOptionRapidEntry.Height)
        'End If
    End Sub
    Private Sub TemplateOption_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
