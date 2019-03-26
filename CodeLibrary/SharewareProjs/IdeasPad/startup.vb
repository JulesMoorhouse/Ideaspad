Friend Class frmStartup
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStartup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        'btnProceed
        '
        Me.btnProceed.AccessibleDescription = CType(resources.GetObject("btnProceed.AccessibleDescription"), String)
        Me.btnProceed.AccessibleName = CType(resources.GetObject("btnProceed.AccessibleName"), String)
        Me.btnProceed.Anchor = CType(resources.GetObject("btnProceed.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackgroundImage = CType(resources.GetObject("btnProceed.BackgroundImage"), System.Drawing.Image)
        Me.btnProceed.Dock = CType(resources.GetObject("btnProceed.Dock"), System.Windows.Forms.DockStyle)
        Me.btnProceed.Enabled = CType(resources.GetObject("btnProceed.Enabled"), Boolean)
        Me.btnProceed.FlatStyle = CType(resources.GetObject("btnProceed.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnProceed.Font = CType(resources.GetObject("btnProceed.Font"), System.Drawing.Font)
        Me.btnProceed.Image = CType(resources.GetObject("btnProceed.Image"), System.Drawing.Image)
        Me.btnProceed.ImageAlign = CType(resources.GetObject("btnProceed.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnProceed.ImageIndex = CType(resources.GetObject("btnProceed.ImageIndex"), Integer)
        Me.btnProceed.ImeMode = CType(resources.GetObject("btnProceed.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnProceed.Location = CType(resources.GetObject("btnProceed.Location"), System.Drawing.Point)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.RightToLeft = CType(resources.GetObject("btnProceed.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnProceed.Size = CType(resources.GetObject("btnProceed.Size"), System.Drawing.Size)
        Me.btnProceed.TabIndex = CType(resources.GetObject("btnProceed.TabIndex"), Integer)
        Me.btnProceed.Text = resources.GetString("btnProceed.Text")
        Me.btnProceed.TextAlign = CType(resources.GetObject("btnProceed.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnProceed.Visible = CType(resources.GetObject("btnProceed.Visible"), Boolean)
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
        Me.Label8.ForeColor = System.Drawing.Color.Blue
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
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = CType(resources.GetObject("GroupBox1.AccessibleDescription"), String)
        Me.GroupBox1.AccessibleName = CType(resources.GetObject("GroupBox1.AccessibleName"), String)
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label9, Me.txtShortName, Me.Label6, Me.Label3})
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
        'Label9
        '
        Me.Label9.AccessibleDescription = CType(resources.GetObject("Label9.AccessibleDescription"), String)
        Me.Label9.AccessibleName = CType(resources.GetObject("Label9.AccessibleName"), String)
        Me.Label9.Anchor = CType(resources.GetObject("Label9.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = CType(resources.GetObject("Label9.AutoSize"), Boolean)
        Me.Label9.Dock = CType(resources.GetObject("Label9.Dock"), System.Windows.Forms.DockStyle)
        Me.Label9.Enabled = CType(resources.GetObject("Label9.Enabled"), Boolean)
        Me.Label9.Font = CType(resources.GetObject("Label9.Font"), System.Drawing.Font)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
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
        'txtShortName
        '
        Me.txtShortName.AccessibleDescription = CType(resources.GetObject("txtShortName.AccessibleDescription"), String)
        Me.txtShortName.AccessibleName = CType(resources.GetObject("txtShortName.AccessibleName"), String)
        Me.txtShortName.Anchor = CType(resources.GetObject("txtShortName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtShortName.AutoSize = CType(resources.GetObject("txtShortName.AutoSize"), Boolean)
        Me.txtShortName.BackgroundImage = CType(resources.GetObject("txtShortName.BackgroundImage"), System.Drawing.Image)
        Me.txtShortName.Dock = CType(resources.GetObject("txtShortName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtShortName.Enabled = CType(resources.GetObject("txtShortName.Enabled"), Boolean)
        Me.txtShortName.Font = CType(resources.GetObject("txtShortName.Font"), System.Drawing.Font)
        Me.txtShortName.ImeMode = CType(resources.GetObject("txtShortName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtShortName.Location = CType(resources.GetObject("txtShortName.Location"), System.Drawing.Point)
        Me.txtShortName.MaxLength = CType(resources.GetObject("txtShortName.MaxLength"), Integer)
        Me.txtShortName.Multiline = CType(resources.GetObject("txtShortName.Multiline"), Boolean)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.PasswordChar = CType(resources.GetObject("txtShortName.PasswordChar"), Char)
        Me.txtShortName.RightToLeft = CType(resources.GetObject("txtShortName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtShortName.ScrollBars = CType(resources.GetObject("txtShortName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtShortName.Size = CType(resources.GetObject("txtShortName.Size"), System.Drawing.Size)
        Me.txtShortName.TabIndex = CType(resources.GetObject("txtShortName.TabIndex"), Integer)
        Me.txtShortName.Text = resources.GetString("txtShortName.Text")
        Me.txtShortName.TextAlign = CType(resources.GetObject("txtShortName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtShortName.Visible = CType(resources.GetObject("txtShortName.Visible"), Boolean)
        Me.txtShortName.WordWrap = CType(resources.GetObject("txtShortName.WordWrap"), Boolean)
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
        Me.Label6.ForeColor = System.Drawing.Color.Blue
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
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = CType(resources.GetObject("GroupBox2.AccessibleDescription"), String)
        Me.GroupBox2.AccessibleName = CType(resources.GetObject("GroupBox2.AccessibleName"), String)
        Me.GroupBox2.Anchor = CType(resources.GetObject("GroupBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.btnEnter, Me.Label2})
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
        'Label7
        '
        Me.Label7.AccessibleDescription = CType(resources.GetObject("Label7.AccessibleDescription"), String)
        Me.Label7.AccessibleName = CType(resources.GetObject("Label7.AccessibleName"), String)
        Me.Label7.Anchor = CType(resources.GetObject("Label7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = CType(resources.GetObject("Label7.AutoSize"), Boolean)
        Me.Label7.Dock = CType(resources.GetObject("Label7.Dock"), System.Windows.Forms.DockStyle)
        Me.Label7.Enabled = CType(resources.GetObject("Label7.Enabled"), Boolean)
        Me.Label7.Font = CType(resources.GetObject("Label7.Font"), System.Drawing.Font)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
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
        'btnEnter
        '
        Me.btnEnter.AccessibleDescription = CType(resources.GetObject("btnEnter.AccessibleDescription"), String)
        Me.btnEnter.AccessibleName = CType(resources.GetObject("btnEnter.AccessibleName"), String)
        Me.btnEnter.Anchor = CType(resources.GetObject("btnEnter.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.Dock = CType(resources.GetObject("btnEnter.Dock"), System.Windows.Forms.DockStyle)
        Me.btnEnter.Enabled = CType(resources.GetObject("btnEnter.Enabled"), Boolean)
        Me.btnEnter.FlatStyle = CType(resources.GetObject("btnEnter.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnEnter.Font = CType(resources.GetObject("btnEnter.Font"), System.Drawing.Font)
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.ImageAlign = CType(resources.GetObject("btnEnter.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnEnter.ImageIndex = CType(resources.GetObject("btnEnter.ImageIndex"), Integer)
        Me.btnEnter.ImeMode = CType(resources.GetObject("btnEnter.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnEnter.Location = CType(resources.GetObject("btnEnter.Location"), System.Drawing.Point)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.RightToLeft = CType(resources.GetObject("btnEnter.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnEnter.Size = CType(resources.GetObject("btnEnter.Size"), System.Drawing.Size)
        Me.btnEnter.TabIndex = CType(resources.GetObject("btnEnter.TabIndex"), Integer)
        Me.btnEnter.Text = resources.GetString("btnEnter.Text")
        Me.btnEnter.TextAlign = CType(resources.GetObject("btnEnter.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnEnter.Visible = CType(resources.GetObject("btnEnter.Visible"), Boolean)
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
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = CType(resources.GetObject("GroupBox3.AccessibleDescription"), String)
        Me.GroupBox3.AccessibleName = CType(resources.GetObject("GroupBox3.AccessibleName"), String)
        Me.GroupBox3.Anchor = CType(resources.GetObject("GroupBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.Label8, Me.btnProceed})
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
        'frmStartup
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.Label4, Me.Label5, Me.Label1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmStartup"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend gbooStartupCancel As Boolean = False
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 

    Private Sub frmStartup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = Label1.Text.Replace("[Program]", gProgName) 
        Label2.Text = Label2.Text.Replace("[Program]", gProgName) 
        Label5.Text = Label5.Text.Replace("[Program]", gProgName) 
        Label4.Text = Label4.Text.Replace("[Program]", gProgName) 
        btnProceed.Text = btnProceed.Text.Replace("[Program]", gProgName) 

        Label4.Text = Label4.Text.Replace("2004", gYear) 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnProceed.FlatStyle = FlatStyle.System
            btnEnter.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        'GroupBox1.FlatStyle = FlatStyle.System 'Commented for transparency 
        'GroupBox2.FlatStyle = FlatStyle.System 'Commented for transparency 
        'GroupBox3.FlatStyle = FlatStyle.System 'Commented for transparency 
        

        SetBackcolors() 

        KeyPreview = True 
        Me.Text = NameMe(Me.Text)

    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If txtShortName.Text = "" Then
            'mxessagebox.show("You must specify a name for your information! Please re-run this program!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Startup_MustSpecifyName").Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Exit Sub
        End If

        Busy(Me, True)
        Me.Enabled = False
        txtShortName.Enabled = False
        btnEnter.Enabled = False

        Dim NewMaint As New frmMaint()
        NewMaint.gbooSilentMode = True
        NewMaint.btnNew_Click(Nothing, Nothing)

        If NewMaint.gbooDBComplete = False Then
            'mxessagebox.show("You must create an 'Information Base' file!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Startup_MustCreate").Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            Busy(Me, False)
            Me.Enabled = True
            txtShortName.Enabled = True
            btnEnter.Enabled = True
            Exit Sub
        End If
        gstrDataFileName = NewMaint.gstrChosenDB
        NewMaint.AddNewDB(NewMaint.gstrChosenDB, txtShortName.Text)

        
        'CreateBlankConfigFile() 

        Busy(Me, False)
        Me.Enabled = True
        btnProceed.Enabled = True

        btnProceed.Select() 

        MessageBox.Show(LangText.GetString("Startup_CreatedSuccess"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 

    End Sub
    Private Sub btnProceed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProceed.Click

        
        ''If InStrGet((NameMe("")).ToUpper, "TRIAL") > 0 Then 'Changed to Trial 
        ''    'mxessagebox.show("Please make a written note of the date you installed" & Environment.NewLine() & _
        ''    '    "this software as your 90 day (approx) trial of Ideaspad will start" & Environment.NewLine() & _
        ''    '    "on that date!" & Environment.NewLine() & Environment.NewLine() & _
        ''    '    "Thank you for choosing to evaluate this software!" & Environment.NewLine() & Environment.NewLine() & _
        ''    '    "Mindwarp Consultancy Ltd. 2003", NameMe(""))
        ''    
        ''    MessageBox.Show(LangText.GetString("Startup_TrialNotice").Replace("[Program]", gProgName).Replace("[CR]", _
        ''        Environment.NewLine).Replace("[CR2]", Environment.NewLine & _
        ''        Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

        ''End If
        Me.Close()
    End Sub
    Private Sub frmStartup_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.ControlBox = False
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gbooStartupCancel = True
        Me.Close()
    End Sub
    Private Sub frmStartup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnProceed.BackColor = Color.FromArgb(0, btnProceed.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        GroupBox1.BackColor = Color.FromArgb(0, GroupBox1.BackColor)
        GroupBox2.BackColor = Color.FromArgb(0, GroupBox2.BackColor)
        GroupBox3.BackColor = Color.FromArgb(0, GroupBox3.BackColor)
        btnEnter.BackColor = Color.FromArgb(0, btnEnter.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)
        Label5.BackColor = Color.FromArgb(0, Label5.BackColor)
        Label6.BackColor = Color.FromArgb(0, Label6.BackColor)
        Label7.BackColor = Color.FromArgb(0, Label7.BackColor)
        Label8.BackColor = Color.FromArgb(0, Label8.BackColor)
        Label9.BackColor = Color.FromArgb(0, Label9.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub frmStartup_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class