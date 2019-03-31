Imports System.Collections
Imports System.Text
Imports System.Net
Imports System.Web.HttpUtility
Imports System.IO
Imports System.Xml
Imports System
Imports WinOnly
Imports System.Diagnostics
Public Class BugReport
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents grpOptional As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrivacy As System.Windows.Forms.Button
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSave As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BugReport))
        Me.grpOptional = New System.Windows.Forms.GroupBox()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrivacy = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpOptional.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptional
        '
        Me.grpOptional.AccessibleDescription = CType(resources.GetObject("grpOptional.AccessibleDescription"), String)
        Me.grpOptional.AccessibleName = CType(resources.GetObject("grpOptional.AccessibleName"), String)
        Me.grpOptional.Anchor = CType(resources.GetObject("grpOptional.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpOptional.BackgroundImage = CType(resources.GetObject("grpOptional.BackgroundImage"), System.Drawing.Image)
        Me.grpOptional.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkSave, Me.lblEmail, Me.txtEmail, Me.txtContactName, Me.Label1, Me.lblContactName})
        Me.grpOptional.Dock = CType(resources.GetObject("grpOptional.Dock"), System.Windows.Forms.DockStyle)
        Me.grpOptional.Enabled = CType(resources.GetObject("grpOptional.Enabled"), Boolean)
        Me.grpOptional.Font = CType(resources.GetObject("grpOptional.Font"), System.Drawing.Font)
        Me.grpOptional.ImeMode = CType(resources.GetObject("grpOptional.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpOptional.Location = CType(resources.GetObject("grpOptional.Location"), System.Drawing.Point)
        Me.grpOptional.Name = "grpOptional"
        Me.grpOptional.RightToLeft = CType(resources.GetObject("grpOptional.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpOptional.Size = CType(resources.GetObject("grpOptional.Size"), System.Drawing.Size)
        Me.grpOptional.TabIndex = CType(resources.GetObject("grpOptional.TabIndex"), Integer)
        Me.grpOptional.TabStop = False
        Me.grpOptional.Text = resources.GetString("grpOptional.Text")
        Me.grpOptional.Visible = CType(resources.GetObject("grpOptional.Visible"), Boolean)
        '
        'chkSave
        '
        Me.chkSave.AccessibleDescription = CType(resources.GetObject("chkSave.AccessibleDescription"), String)
        Me.chkSave.AccessibleName = CType(resources.GetObject("chkSave.AccessibleName"), String)
        Me.chkSave.Anchor = CType(resources.GetObject("chkSave.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkSave.Appearance = CType(resources.GetObject("chkSave.Appearance"), System.Windows.Forms.Appearance)
        Me.chkSave.BackgroundImage = CType(resources.GetObject("chkSave.BackgroundImage"), System.Drawing.Image)
        Me.chkSave.CheckAlign = CType(resources.GetObject("chkSave.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkSave.Dock = CType(resources.GetObject("chkSave.Dock"), System.Windows.Forms.DockStyle)
        Me.chkSave.Enabled = CType(resources.GetObject("chkSave.Enabled"), Boolean)
        Me.chkSave.FlatStyle = CType(resources.GetObject("chkSave.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkSave.Font = CType(resources.GetObject("chkSave.Font"), System.Drawing.Font)
        Me.chkSave.Image = CType(resources.GetObject("chkSave.Image"), System.Drawing.Image)
        Me.chkSave.ImageAlign = CType(resources.GetObject("chkSave.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkSave.ImageIndex = CType(resources.GetObject("chkSave.ImageIndex"), Integer)
        Me.chkSave.ImeMode = CType(resources.GetObject("chkSave.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkSave.Location = CType(resources.GetObject("chkSave.Location"), System.Drawing.Point)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.RightToLeft = CType(resources.GetObject("chkSave.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkSave.Size = CType(resources.GetObject("chkSave.Size"), System.Drawing.Size)
        Me.chkSave.TabIndex = CType(resources.GetObject("chkSave.TabIndex"), Integer)
        Me.chkSave.Text = resources.GetString("chkSave.Text")
        Me.chkSave.TextAlign = CType(resources.GetObject("chkSave.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkSave.Visible = CType(resources.GetObject("chkSave.Visible"), Boolean)
        '
        'lblEmail
        '
        Me.lblEmail.AccessibleDescription = CType(resources.GetObject("lblEmail.AccessibleDescription"), String)
        Me.lblEmail.AccessibleName = CType(resources.GetObject("lblEmail.AccessibleName"), String)
        Me.lblEmail.Anchor = CType(resources.GetObject("lblEmail.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = CType(resources.GetObject("lblEmail.AutoSize"), Boolean)
        Me.lblEmail.Dock = CType(resources.GetObject("lblEmail.Dock"), System.Windows.Forms.DockStyle)
        Me.lblEmail.Enabled = CType(resources.GetObject("lblEmail.Enabled"), Boolean)
        Me.lblEmail.Font = CType(resources.GetObject("lblEmail.Font"), System.Drawing.Font)
        Me.lblEmail.Image = CType(resources.GetObject("lblEmail.Image"), System.Drawing.Image)
        Me.lblEmail.ImageAlign = CType(resources.GetObject("lblEmail.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblEmail.ImageIndex = CType(resources.GetObject("lblEmail.ImageIndex"), Integer)
        Me.lblEmail.ImeMode = CType(resources.GetObject("lblEmail.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblEmail.Location = CType(resources.GetObject("lblEmail.Location"), System.Drawing.Point)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = CType(resources.GetObject("lblEmail.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblEmail.Size = CType(resources.GetObject("lblEmail.Size"), System.Drawing.Size)
        Me.lblEmail.TabIndex = CType(resources.GetObject("lblEmail.TabIndex"), Integer)
        Me.lblEmail.Text = resources.GetString("lblEmail.Text")
        Me.lblEmail.TextAlign = CType(resources.GetObject("lblEmail.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblEmail.Visible = CType(resources.GetObject("lblEmail.Visible"), Boolean)
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleDescription = CType(resources.GetObject("txtEmail.AccessibleDescription"), String)
        Me.txtEmail.AccessibleName = CType(resources.GetObject("txtEmail.AccessibleName"), String)
        Me.txtEmail.Anchor = CType(resources.GetObject("txtEmail.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.AutoSize = CType(resources.GetObject("txtEmail.AutoSize"), Boolean)
        Me.txtEmail.BackgroundImage = CType(resources.GetObject("txtEmail.BackgroundImage"), System.Drawing.Image)
        Me.txtEmail.Dock = CType(resources.GetObject("txtEmail.Dock"), System.Windows.Forms.DockStyle)
        Me.txtEmail.Enabled = CType(resources.GetObject("txtEmail.Enabled"), Boolean)
        Me.txtEmail.Font = CType(resources.GetObject("txtEmail.Font"), System.Drawing.Font)
        Me.txtEmail.ImeMode = CType(resources.GetObject("txtEmail.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtEmail.Location = CType(resources.GetObject("txtEmail.Location"), System.Drawing.Point)
        Me.txtEmail.MaxLength = CType(resources.GetObject("txtEmail.MaxLength"), Integer)
        Me.txtEmail.Multiline = CType(resources.GetObject("txtEmail.Multiline"), Boolean)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = CType(resources.GetObject("txtEmail.PasswordChar"), Char)
        Me.txtEmail.RightToLeft = CType(resources.GetObject("txtEmail.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtEmail.ScrollBars = CType(resources.GetObject("txtEmail.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtEmail.Size = CType(resources.GetObject("txtEmail.Size"), System.Drawing.Size)
        Me.txtEmail.TabIndex = CType(resources.GetObject("txtEmail.TabIndex"), Integer)
        Me.txtEmail.Text = resources.GetString("txtEmail.Text")
        Me.txtEmail.TextAlign = CType(resources.GetObject("txtEmail.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtEmail.Visible = CType(resources.GetObject("txtEmail.Visible"), Boolean)
        Me.txtEmail.WordWrap = CType(resources.GetObject("txtEmail.WordWrap"), Boolean)
        '
        'txtContactName
        '
        Me.txtContactName.AccessibleDescription = CType(resources.GetObject("txtContactName.AccessibleDescription"), String)
        Me.txtContactName.AccessibleName = CType(resources.GetObject("txtContactName.AccessibleName"), String)
        Me.txtContactName.Anchor = CType(resources.GetObject("txtContactName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtContactName.AutoSize = CType(resources.GetObject("txtContactName.AutoSize"), Boolean)
        Me.txtContactName.BackgroundImage = CType(resources.GetObject("txtContactName.BackgroundImage"), System.Drawing.Image)
        Me.txtContactName.Dock = CType(resources.GetObject("txtContactName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtContactName.Enabled = CType(resources.GetObject("txtContactName.Enabled"), Boolean)
        Me.txtContactName.Font = CType(resources.GetObject("txtContactName.Font"), System.Drawing.Font)
        Me.txtContactName.ImeMode = CType(resources.GetObject("txtContactName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtContactName.Location = CType(resources.GetObject("txtContactName.Location"), System.Drawing.Point)
        Me.txtContactName.MaxLength = CType(resources.GetObject("txtContactName.MaxLength"), Integer)
        Me.txtContactName.Multiline = CType(resources.GetObject("txtContactName.Multiline"), Boolean)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.PasswordChar = CType(resources.GetObject("txtContactName.PasswordChar"), Char)
        Me.txtContactName.RightToLeft = CType(resources.GetObject("txtContactName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtContactName.ScrollBars = CType(resources.GetObject("txtContactName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtContactName.Size = CType(resources.GetObject("txtContactName.Size"), System.Drawing.Size)
        Me.txtContactName.TabIndex = CType(resources.GetObject("txtContactName.TabIndex"), Integer)
        Me.txtContactName.Text = resources.GetString("txtContactName.Text")
        Me.txtContactName.TextAlign = CType(resources.GetObject("txtContactName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtContactName.Visible = CType(resources.GetObject("txtContactName.Visible"), Boolean)
        Me.txtContactName.WordWrap = CType(resources.GetObject("txtContactName.WordWrap"), Boolean)
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
        'lblContactName
        '
        Me.lblContactName.AccessibleDescription = CType(resources.GetObject("lblContactName.AccessibleDescription"), String)
        Me.lblContactName.AccessibleName = CType(resources.GetObject("lblContactName.AccessibleName"), String)
        Me.lblContactName.Anchor = CType(resources.GetObject("lblContactName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblContactName.AutoSize = CType(resources.GetObject("lblContactName.AutoSize"), Boolean)
        Me.lblContactName.Dock = CType(resources.GetObject("lblContactName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblContactName.Enabled = CType(resources.GetObject("lblContactName.Enabled"), Boolean)
        Me.lblContactName.Font = CType(resources.GetObject("lblContactName.Font"), System.Drawing.Font)
        Me.lblContactName.Image = CType(resources.GetObject("lblContactName.Image"), System.Drawing.Image)
        Me.lblContactName.ImageAlign = CType(resources.GetObject("lblContactName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblContactName.ImageIndex = CType(resources.GetObject("lblContactName.ImageIndex"), Integer)
        Me.lblContactName.ImeMode = CType(resources.GetObject("lblContactName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblContactName.Location = CType(resources.GetObject("lblContactName.Location"), System.Drawing.Point)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.RightToLeft = CType(resources.GetObject("lblContactName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblContactName.Size = CType(resources.GetObject("lblContactName.Size"), System.Drawing.Size)
        Me.lblContactName.TabIndex = CType(resources.GetObject("lblContactName.TabIndex"), Integer)
        Me.lblContactName.Text = resources.GetString("lblContactName.Text")
        Me.lblContactName.TextAlign = CType(resources.GetObject("lblContactName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblContactName.Visible = CType(resources.GetObject("lblContactName.Visible"), Boolean)
        '
        'btnSend
        '
        Me.btnSend.AccessibleDescription = CType(resources.GetObject("btnSend.AccessibleDescription"), String)
        Me.btnSend.AccessibleName = CType(resources.GetObject("btnSend.AccessibleName"), String)
        Me.btnSend.Anchor = CType(resources.GetObject("btnSend.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackgroundImage = CType(resources.GetObject("btnSend.BackgroundImage"), System.Drawing.Image)
        Me.btnSend.Dock = CType(resources.GetObject("btnSend.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSend.Enabled = CType(resources.GetObject("btnSend.Enabled"), Boolean)
        Me.btnSend.FlatStyle = CType(resources.GetObject("btnSend.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnSend.Font = CType(resources.GetObject("btnSend.Font"), System.Drawing.Font)
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageAlign = CType(resources.GetObject("btnSend.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnSend.ImageIndex = CType(resources.GetObject("btnSend.ImageIndex"), Integer)
        Me.btnSend.ImeMode = CType(resources.GetObject("btnSend.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSend.Location = CType(resources.GetObject("btnSend.Location"), System.Drawing.Point)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.RightToLeft = CType(resources.GetObject("btnSend.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSend.Size = CType(resources.GetObject("btnSend.Size"), System.Drawing.Size)
        Me.btnSend.TabIndex = CType(resources.GetObject("btnSend.TabIndex"), Integer)
        Me.btnSend.Text = resources.GetString("btnSend.Text")
        Me.btnSend.TextAlign = CType(resources.GetObject("btnSend.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnSend.Visible = CType(resources.GetObject("btnSend.Visible"), Boolean)
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
        'btnPrivacy
        '
        Me.btnPrivacy.AccessibleDescription = CType(resources.GetObject("btnPrivacy.AccessibleDescription"), String)
        Me.btnPrivacy.AccessibleName = CType(resources.GetObject("btnPrivacy.AccessibleName"), String)
        Me.btnPrivacy.Anchor = CType(resources.GetObject("btnPrivacy.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnPrivacy.BackgroundImage = CType(resources.GetObject("btnPrivacy.BackgroundImage"), System.Drawing.Image)
        Me.btnPrivacy.Dock = CType(resources.GetObject("btnPrivacy.Dock"), System.Windows.Forms.DockStyle)
        Me.btnPrivacy.Enabled = CType(resources.GetObject("btnPrivacy.Enabled"), Boolean)
        Me.btnPrivacy.FlatStyle = CType(resources.GetObject("btnPrivacy.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnPrivacy.Font = CType(resources.GetObject("btnPrivacy.Font"), System.Drawing.Font)
        Me.btnPrivacy.Image = CType(resources.GetObject("btnPrivacy.Image"), System.Drawing.Image)
        Me.btnPrivacy.ImageAlign = CType(resources.GetObject("btnPrivacy.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnPrivacy.ImageIndex = CType(resources.GetObject("btnPrivacy.ImageIndex"), Integer)
        Me.btnPrivacy.ImeMode = CType(resources.GetObject("btnPrivacy.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnPrivacy.Location = CType(resources.GetObject("btnPrivacy.Location"), System.Drawing.Point)
        Me.btnPrivacy.Name = "btnPrivacy"
        Me.btnPrivacy.RightToLeft = CType(resources.GetObject("btnPrivacy.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnPrivacy.Size = CType(resources.GetObject("btnPrivacy.Size"), System.Drawing.Size)
        Me.btnPrivacy.TabIndex = CType(resources.GetObject("btnPrivacy.TabIndex"), Integer)
        Me.btnPrivacy.Text = resources.GetString("btnPrivacy.Text")
        Me.btnPrivacy.TextAlign = CType(resources.GetObject("btnPrivacy.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnPrivacy.Visible = CType(resources.GetObject("btnPrivacy.Visible"), Boolean)
        '
        'txtComments
        '
        Me.txtComments.AccessibleDescription = CType(resources.GetObject("txtComments.AccessibleDescription"), String)
        Me.txtComments.AccessibleName = CType(resources.GetObject("txtComments.AccessibleName"), String)
        Me.txtComments.Anchor = CType(resources.GetObject("txtComments.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtComments.AutoSize = CType(resources.GetObject("txtComments.AutoSize"), Boolean)
        Me.txtComments.BackgroundImage = CType(resources.GetObject("txtComments.BackgroundImage"), System.Drawing.Image)
        Me.txtComments.Dock = CType(resources.GetObject("txtComments.Dock"), System.Windows.Forms.DockStyle)
        Me.txtComments.Enabled = CType(resources.GetObject("txtComments.Enabled"), Boolean)
        Me.txtComments.Font = CType(resources.GetObject("txtComments.Font"), System.Drawing.Font)
        Me.txtComments.ImeMode = CType(resources.GetObject("txtComments.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtComments.Location = CType(resources.GetObject("txtComments.Location"), System.Drawing.Point)
        Me.txtComments.MaxLength = CType(resources.GetObject("txtComments.MaxLength"), Integer)
        Me.txtComments.Multiline = CType(resources.GetObject("txtComments.Multiline"), Boolean)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.PasswordChar = CType(resources.GetObject("txtComments.PasswordChar"), Char)
        Me.txtComments.RightToLeft = CType(resources.GetObject("txtComments.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtComments.ScrollBars = CType(resources.GetObject("txtComments.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtComments.Size = CType(resources.GetObject("txtComments.Size"), System.Drawing.Size)
        Me.txtComments.TabIndex = CType(resources.GetObject("txtComments.TabIndex"), Integer)
        Me.txtComments.Text = resources.GetString("txtComments.Text")
        Me.txtComments.TextAlign = CType(resources.GetObject("txtComments.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtComments.Visible = CType(resources.GetObject("txtComments.Visible"), Boolean)
        Me.txtComments.WordWrap = CType(resources.GetObject("txtComments.WordWrap"), Boolean)
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
        'BugReport
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label3, Me.btnPrivacy, Me.btnCancel, Me.btnSend, Me.grpOptional, Me.Label2, Me.txtComments})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "BugReport"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.grpOptional.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim micoFormIcon As Icon
    'Dim mXMLConfigType As InitalXMLConfig.XmlConfigType
    'Dim mInitialBookmarks As InitalXMLConfig
    Dim mstrAllReports() As String
    Dim mstrCaption As String
    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("ProbHand.ProbHand", _
        System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim mstrReport As String = ""
    Dim mdatSysStartTime As Date 
    Private Enum SubmissionValues 
        Sucess
        Failure
        ThanksButOldVersion
    End Enum
    Public Property Caption() As String
        Get

            Return mstrCaption
        End Get
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property
    Public Property SysStartTime() As Date 
        Get
            Return mdatSysStartTime
        End Get
        Set(ByVal Value As Date)
            mdatSysStartTime = Value
        End Set
    End Property
    Public Property FormIcon() As Icon
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return micoFormIcon
        End Get
        Set(ByVal Value As Icon)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            micoFormIcon = Value
        End Set
    End Property



    Private Function ReadErrLog(ByVal pstrErrLogToRead As String) As String

        Dim ErrDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\ErrorDumps\"

        Dim OpenFile As FileStream = New FileStream(ErrDir & pstrErrLogToRead, FileMode.Open, FileAccess.Read, FileShare.Read)             

        Dim StreamReader As StreamReader = New StreamReader(OpenFile)
        Dim lstrFileStr As String = StreamReader.ReadToEnd
        StreamReader.Close()
        OpenFile.Close()

        Dim clsDec As New MyCrypto()
        Dim decstring As String = clsDec.Decrypt(lstrFileStr, "00F0FF000F")
        clsDec = Nothing

        Return decstring

    End Function


    Private Function ProduceSubmissionData(ByVal pTechInfo As TechInfo, ByVal pstrUserFeedback As String) As String

        AppendBRLog("ProduceSubmissionData 1") 
        Dim lintArrInc As Integer
        Dim lstrSubmisionStr As String = ProduceTechHeader(pTechInfo)

        lstrSubmisionStr &= pstrUserFeedback.Replace("\", "&#92;")

        For lintArrInc = mstrAllReports.GetUpperBound(0) To 0 Step -1
            lstrSubmisionStr &= ReadErrLog(mstrAllReports(lintArrInc)) & "<BR><HR><BR>"
        Next lintArrInc

        AppendBRLog("ProduceSubmissionData 5") 

        Return lstrSubmisionStr & "</body></html>"

    End Function
    Private Function Submit(ByVal pstrEmail As String) As SubmissionValues
        Dim BugSendStatus As New StatusDialog(Me)
        BugSendStatus.TopMostIn = mbooTopMost 

        Try
            Submit = SubmissionValues.Failure
            Dim client As New WebClient()

            With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
                client.Headers.Add("User-Agent", .ProductName & " V" & .ProductVersion)
            End With

            Dim form As New System.Collections.Specialized.NameValueCollection()
            Dim lstrVerifyCode As String = Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")
            AppendBRLog("Submit 1") 

            If mstrReport = "" Then
                ProduceReport() 
            End If

            AppendBRLog("Submit 2") 

            BugSendStatus.Show()
            BugSendStatus.Status = LangText.GetString("BugRep_StatusSendingReport") '"Sending Problem Report ..."
            Application.DoEvents()

            form.Add("verification", lstrVerifyCode)
            'form.Add("data", ProduceSubmissionData(pTechInfo, pstrUserFeedback))
            
            form.Add("data", mstrReport)

            If pstrEmail = "" Then
                'form.Add("from", "NONE")
            Else
                form.Add("from", pstrEmail)
            End If

            Application.DoEvents()

            Dim responseData As [Byte]() = client.UploadValues("http://www.example.com/php/bugreport.php", form)
            'Console.WriteLine("RD: " & Encoding.ASCII.GetString(responseData))
            AppendBRLog("Submit 3") 

            Dim response As String = Encoding.ASCII.GetString(responseData)

            AppendBRLog("Submit 4") 

            If InStrGet(response.ToLower, "<verification>" & lstrVerifyCode.ToLower & "</verification>") > 0 Then
                Submit = SubmissionValues.Sucess 
            ElseIf InStrGet(response.ToLower, "<verification>OLDVERSION</verification>") > 0 Then 
                Submit = SubmissionValues.ThanksButOldVersion 
            End If

        Catch webEx As WebException
            'If webEx.Status = WebExceptionStatus.ConnectFailure Then
            '    Console.WriteLine("Are you behind a firewall?  If so, go through the proxy server.")
            'End If
            'Console.Write(webEx.ToString())
            If mbooTopMost = True Then Me.Activate() 
            MessageBox.Show(webEx.Message, mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error) 
        End Try

        BugSendStatus.Close()
        Application.DoEvents()

        'MessageBox.Show("Done!")
    End Function
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        'grpOptional.FlatStyle = FlatStyle.System 'Commented for transparency 
        If IsAboveOrEqualWinXp() = True Then  
            btnSend.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnPrivacy.FlatStyle = FlatStyle.System
        End If 
        'chkSave.FlatStyle = FlatStyle.System
        

        SetBackcolors() 

        Me.Icon = micoFormIcon
        KeyPreview = True
        Me.Text = mstrCaption & " - " & Me.Text

        If System.IO.File.Exists(System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat") = False Then
            GetSetting("Default Information Base File", "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        End If

        txtContactName.Text = GetSetting("ContactName", "", InitalXMLConfig.XmlConfigType.DebugReports, "")
        txtEmail.Text = GetSetting("Email", "", InitalXMLConfig.XmlConfigType.DebugReports, "")

        If txtContactName.Text <> "" Or txtEmail.Text <> "" Then
            chkSave.Checked = True
        End If

    End Sub
    Private Sub FlushSubmissions()
        AppendBRLog("FlushSubmissions 1") 

        Dim lintArrInc As Integer
        Dim ErrDir As String = System.IO.Path.GetDirectoryName( _
        System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\ErrorDumps\"

        For lintArrInc = mstrAllReports.GetUpperBound(0) To 0 Step -1
            Try
                'MessageBox.Show(ErrDir & mstrAllReports(lintArrInc))

                File.Delete(ErrDir & mstrAllReports(lintArrInc))
            Catch
                AppendBRLog("FlushSubmissions catch") 
            End Try
        Next lintArrInc

        SaveReportNames(True, mstrAllReports)

    End Sub
    Private Function ProduceTechHeader(ByVal pTechInfo As TechInfo) As String

        Dim msg As String

        msg = "<table border=0><tr><td><table border=0>"
        With pTechInfo
            msg &= "<tr><td align=right><b>OS:</b></td><td>" & .OSVersionName & "</td></tr>"
            msg &= "<tr><td align=right><b>OS Ver:</b></td><td>" & .OSBuild & "</td></tr>"
            msg &= "<tr><td align=right><b>OS Lang:</b></td><td>" & .OSLanguage & "</td></tr>"
            msg &= "<tr><td align=right><b>OS SP:</b></td><td>" & .ServicePack & "</td></tr>"
            msg &= "<tr><td align=right><b>Install Date:</b></td><td>" & .InstallDate & "</td></tr>"
            msg &= "<tr><td align=right><b>Sys Dir:</b></td><td>" & .SysDir.Replace("\", "&#92;") & "</td></tr>"
            msg &= "<tr><td align=right><b>Win Dir:</b></td><td>" & .WinDir.Replace("\", "&#92;") & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Type:</b></td><td>" & .CPUTypeName & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Desc:</b></td><td>" & .ProcessorDesc & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Speed:</b></td><td>" & .ProcessorSpeed & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Name:</b></td><td>" & .ProcessorName & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Manu:</b></td><td>" & .ProcessorManufacturer & "</td></tr>"
            msg &= "<tr><td align=right><b>CPU Socket:</b></td><td>" & .ProcessorSocket & "</td></tr></td></tr></table></td>"

            msg &= "<td><table border=0>"

            msg &= "<tr><td align=right><b>Tot Mem:</b></td><td>" & .TotMemory & "</td></tr>"
            msg &= "<tr><td align=right><b>Avail Mem:</b></td><td>" & .AvailMemKB & "</td></tr>"
            msg &= "<tr><td align=right><b>L2 Size:</b></td><td>" & .L2CacheSize & "</td></tr>"
            msg &= "<tr><td align=right><b>L2 Speed:</b></td><td>" & .L2CacheSpeed & "</td></tr>"
            msg &= "<tr><td align=right><b>Scr Res:</b></td><td>" & .ScreenRes & "</td></tr>"
            msg &= "<tr><td align=right><b>Scr Colours:</b></td><td>" & .ScreenColours & "</td></tr>"
            msg &= "<tr><td align=right><b>FX Ver:</b></td><td>" & .DotNetFXVer & "</td></tr>"
            msg &= "<tr><td align=right><b>IE Ver:</b></td><td>" & .IEVersion & "</td></tr>"
            msg &= "<tr><td align=right><b>MDAC Ver:</b></td><td>" & .MDACVer & "</td></tr>"
            msg &= "<tr><td align=right><b>Reg Locale:</b></td><td>" & .RegionLocale & "</td></tr>"
            msg &= "<tr><td align=right><b>Date Format:</b></td><td>" & .DateFormat & "</td></tr>"
            msg &= "<tr><td align=right><b>Default Printer:</b></td><td>" & .DefaultPrinterName & "</td></tr>"
            msg &= "<tr><td align=right><b>FX Language:</b></td><td>" & .DotNetFxLang & "</td></tr>" 
            msg &= "<tr><td align=right><b>Prog Installed Days:</b></td><td>" & .InstalledDays & "</td></tr>" 
            msg &= "</td></tr></table></td></tr>"
            msg &= "<tr><td colspan=2 width=740><b>Current Processes: </b><BR>" & .AllProcesses & "</td></tr></table><BR><HR><BR>"

        End With

        Return msg

    End Function
    Private Sub btnPrivacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrivacy.Click
        'MessageBox.Show(LangText.GetString("BugRep_PrivacyMessage").Replace("[CR2]", _
        '    Environment.NewLine & Environment.NewLine).Replace("[CR]", Environment.NewLine), _
        '    mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '"Your privacy is important to us! [CR2]No personal information is sent to Mindwarp Consultancy Ltd, from[CR]this process.  The whole purpose of this feature is to enable us to fix [CR]any future problems, not to spy on people.[CR2]We haven't produced a feature to let you see what's been sent to us[CR](like similar features from other companies) as the information is highly[CR]technical to the program and not very useful (to anyone except us).[CR2]Mindwarp Consultant Ltd", mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If mstrReport = "" Then
            ProduceReport() 
        End If

        Dim ShowReport As New Privacy()
        With ShowReport
            .Report = mstrReport
            .Statement = LangText.GetString("Privacy_Message")
            .Caption = LangText.GetString("Privacy_Me")
            .ReportLabel = LangText.GetString("Privacy_ProblemReport")
            .CloseText = LangText.GetString("Privacy_Close")
            .ShowDialog()
        End With
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        BusyBug(True)
        AppendBRLog("btnSend_Click 1") 

        Dim lbooSucess As SubmissionValues = SubmissionValues.Failure
        
        lbooSucess = Submit(txtEmail.Text) 'this read current and previous dumps and sends them
        'now you can clear log?
        AppendBRLog("btnSend_Click 2") 

        Dim BugSendStatus As New StatusDialog(Me)

        BugSendStatus.TopMostIn = mbooTopMost 
        BugSendStatus.Show()

        BugSendStatus.Status = LangText.GetString("BugRep_StatusProblemReportSent") '"Problem Report Sent ..."
        Application.DoEvents()
        AppendBRLog("btnSend_Click 3") 

        If lbooSucess = SubmissionValues.Sucess Then
            FlushSubmissions()
        End If

        BugSendStatus.Close()
        Application.DoEvents()

        AppendBRLog("btnSend_Click 4") 

        BusyBug(False)

        If lbooSucess = SubmissionValues.Sucess Then  
            If mbooTopMost = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("BugRep_SubmitOKMessage"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) '"Report Sent OK!"
        ElseIf lbooSucess = SubmissionValues.ThanksButOldVersion Then 
            MessageBox.Show(LangText.GetString("BugRep_ThanksButOldVersion").Replace("[CR]", Environment.NewLine), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 
        Else
            If mbooTopMost = True Then Me.Activate() 

            MessageBox.Show(LangText.GetString("BugRep_ReportFailed"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning) 


        End If 

        Me.Close()

    End Sub
    Sub ProduceReport()

        BusyBug(True)
        Dim BugSendStatus As New StatusDialog(Me)
        BugSendStatus.TopMostIn = mbooTopMost 

        BugSendStatus.Show()
        BugSendStatus.Status = LangText.GetString("BugRep_StatusGeneratingReport") ' "Generating Problem Report ..."
        Application.DoEvents()

        AppendBRLog("ProduceReport 1") 
        'log error first
        LoadReportsNames(mstrAllReports)
        DumpThisErrorLog(mstrCaption, mstrAllReports, mdatSysStartTime)
        Application.DoEvents()

        AppendBRLog("ProduceReport 2") 

        Dim lTechInfo As New TechInfo() 'create Technical details
        Application.DoEvents()

        'When you first get an error use CFU.
        'If CFU says you have the latest version then submit

        Dim lstrUserFeedback As String = "<table border=0>"
        If txtContactName.Text <> "" Then
            lstrUserFeedback &= "<tr><td><b>User Name :</b></td><td>" & txtContactName.Text & "</td></tr>"
        End If
        If txtEmail.Text <> "" Then
            lstrUserFeedback &= "<tr><td><b>User Email :</b></td><td>" & txtEmail.Text & "</td></tr>"
        End If
        If txtComments.Text <> "" Then
            lstrUserFeedback &= "<tr><td colspan=2><b>User Comments :</b><BR><BR>" & txtComments.Text & "</td></tr>"
        End If
        If txtContactName.Text & txtEmail.Text & txtComments.Text = "" Then
            lstrUserFeedback &= "<tr><td colpan=2><b>User Didn&#39;t supply any optional information!</b></td></tr>"
        Else
            If chkSave.Checked = True Then
                SaveSetting("ContactName", txtContactName.Text, InitalXMLConfig.XmlConfigType.DebugReports, "")
                SaveSetting("Email", txtEmail.Text, InitalXMLConfig.XmlConfigType.DebugReports, "")
            Else
                SaveSetting("ContactName", "", InitalXMLConfig.XmlConfigType.DebugReports, "")
                SaveSetting("Email", "", InitalXMLConfig.XmlConfigType.DebugReports, "")
            End If
        End If
        lstrUserFeedback &= "</table><hr>"

        AppendBRLog("ProduceReport 3") 

        mstrReport = StrToHex(ProduceSubmissionData(lTechInfo, lstrUserFeedback))

        AppendBRLog("ProduceReport 4") 

        BugSendStatus.Close()
        BugSendStatus = Nothing
        BusyBug(False)
        Application.DoEvents()

    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        UIStyle.Cross(e)
    End Sub
    Private Sub ErrorReporting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BusyBug(ByVal pbool As Boolean)

        Busy(Me, pbool)

        If pbool = True Then pbool = False Else pbool = True

        btnSend.Enabled = pbool
        btnPrivacy.Enabled = pbool
        btnCancel.Enabled = pbool
        txtEmail.Enabled = pbool
        txtComments.Enabled = pbool
        txtContactName.Enabled = pbool

    End Sub
    Private Sub OtherProcesses()

        Try
            Dim proc As Process
            Dim processes() As Process
            Dim procIndex As Integer
            Dim procCount As Integer


            procCount = processes.Length
            'to check for more than one instance of process
            If procCount > 1 Then
                For Each proc In processes
                    If procIndex > 0 Then
                        'Return True
                    End If
                    procIndex = procIndex + 1
                Next

            End If

        Catch ProcErr As Exception
            '
        End Try
    End Sub
    Sub SetBackcolors()

        'Added 
        grpOptional.BackColor = Color.FromArgb(0, grpOptional.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        lblContactName.BackColor = Color.FromArgb(0, lblContactName.BackColor)
        lblEmail.BackColor = Color.FromArgb(0, lblEmail.BackColor)
        btnSend.BackColor = Color.FromArgb(0, btnSend.BackColor)
        btnPrivacy.BackColor = Color.FromArgb(0, btnPrivacy.BackColor)
        chkSave.BackColor = Color.FromArgb(0, chkSave.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub BugReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
    Private Sub AppendBRLog(ByVal pstrString As String) 

        Dim DateDebug As New IO.FileInfo(System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\DEBUGBUGREPORTING.TXT")

        If DateDebug.Exists = True Then
            Dim lstrLogFile As String = System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\BUGREPORTING.log"

            Dim OpenFile As FileStream = New FileStream(lstrLogFile, FileMode.Append, FileAccess.Write, FileShare.Write)
            Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
            StreamWriter.WriteLine(Microsoft.VisualBasic.Now.ToString & " " & pstrString)
            StreamWriter.Close()
            OpenFile.Close()

        End If

    End Sub
End Class
