Imports System.Diagnostics.FileVersionInfo
Imports System.IO
Friend Class frmAbout
    Inherits System.Windows.Forms.Form
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly())

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
    Friend WithEvents lblProdVer As System.Windows.Forms.Label
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents lblCompName As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblIssuedDate As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLicense As System.Windows.Forms.Label
    Friend WithEvents lblOrderInfo As System.Windows.Forms.Label
    Friend WithEvents lblProgRegCaption As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
        Me.lblProdVer = New System.Windows.Forms.Label
        Me.lblProdName = New System.Windows.Forms.Label
        Me.lblCompName = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblOrderInfo = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblIssuedDate = New System.Windows.Forms.Label
        Me.lblProgRegCaption = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblLicense = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblProdVer
        '
        Me.lblProdVer.AccessibleDescription = CType(resources.GetObject("lblProdVer.AccessibleDescription"), String)
        Me.lblProdVer.AccessibleName = CType(resources.GetObject("lblProdVer.AccessibleName"), String)
        Me.lblProdVer.Anchor = CType(resources.GetObject("lblProdVer.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblProdVer.AutoSize = CType(resources.GetObject("lblProdVer.AutoSize"), Boolean)
        Me.lblProdVer.Dock = CType(resources.GetObject("lblProdVer.Dock"), System.Windows.Forms.DockStyle)
        Me.lblProdVer.Enabled = CType(resources.GetObject("lblProdVer.Enabled"), Boolean)
        Me.lblProdVer.Font = CType(resources.GetObject("lblProdVer.Font"), System.Drawing.Font)
        Me.lblProdVer.Image = CType(resources.GetObject("lblProdVer.Image"), System.Drawing.Image)
        Me.lblProdVer.ImageAlign = CType(resources.GetObject("lblProdVer.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblProdVer.ImageIndex = CType(resources.GetObject("lblProdVer.ImageIndex"), Integer)
        Me.lblProdVer.ImeMode = CType(resources.GetObject("lblProdVer.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblProdVer.Location = CType(resources.GetObject("lblProdVer.Location"), System.Drawing.Point)
        Me.lblProdVer.Name = "lblProdVer"
        Me.lblProdVer.RightToLeft = CType(resources.GetObject("lblProdVer.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblProdVer.Size = CType(resources.GetObject("lblProdVer.Size"), System.Drawing.Size)
        Me.lblProdVer.TabIndex = CType(resources.GetObject("lblProdVer.TabIndex"), Integer)
        Me.lblProdVer.Text = resources.GetString("lblProdVer.Text")
        Me.lblProdVer.TextAlign = CType(resources.GetObject("lblProdVer.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblProdVer.Visible = CType(resources.GetObject("lblProdVer.Visible"), Boolean)
        '
        'lblProdName
        '
        Me.lblProdName.AccessibleDescription = CType(resources.GetObject("lblProdName.AccessibleDescription"), String)
        Me.lblProdName.AccessibleName = CType(resources.GetObject("lblProdName.AccessibleName"), String)
        Me.lblProdName.Anchor = CType(resources.GetObject("lblProdName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblProdName.AutoSize = CType(resources.GetObject("lblProdName.AutoSize"), Boolean)
        Me.lblProdName.Dock = CType(resources.GetObject("lblProdName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblProdName.Enabled = CType(resources.GetObject("lblProdName.Enabled"), Boolean)
        Me.lblProdName.Font = CType(resources.GetObject("lblProdName.Font"), System.Drawing.Font)
        Me.lblProdName.Image = CType(resources.GetObject("lblProdName.Image"), System.Drawing.Image)
        Me.lblProdName.ImageAlign = CType(resources.GetObject("lblProdName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblProdName.ImageIndex = CType(resources.GetObject("lblProdName.ImageIndex"), Integer)
        Me.lblProdName.ImeMode = CType(resources.GetObject("lblProdName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblProdName.Location = CType(resources.GetObject("lblProdName.Location"), System.Drawing.Point)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.RightToLeft = CType(resources.GetObject("lblProdName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblProdName.Size = CType(resources.GetObject("lblProdName.Size"), System.Drawing.Size)
        Me.lblProdName.TabIndex = CType(resources.GetObject("lblProdName.TabIndex"), Integer)
        Me.lblProdName.Text = resources.GetString("lblProdName.Text")
        Me.lblProdName.TextAlign = CType(resources.GetObject("lblProdName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblProdName.Visible = CType(resources.GetObject("lblProdName.Visible"), Boolean)
        '
        'lblCompName
        '
        Me.lblCompName.AccessibleDescription = CType(resources.GetObject("lblCompName.AccessibleDescription"), String)
        Me.lblCompName.AccessibleName = CType(resources.GetObject("lblCompName.AccessibleName"), String)
        Me.lblCompName.Anchor = CType(resources.GetObject("lblCompName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCompName.AutoSize = CType(resources.GetObject("lblCompName.AutoSize"), Boolean)
        Me.lblCompName.Dock = CType(resources.GetObject("lblCompName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCompName.Enabled = CType(resources.GetObject("lblCompName.Enabled"), Boolean)
        Me.lblCompName.Font = CType(resources.GetObject("lblCompName.Font"), System.Drawing.Font)
        Me.lblCompName.Image = CType(resources.GetObject("lblCompName.Image"), System.Drawing.Image)
        Me.lblCompName.ImageAlign = CType(resources.GetObject("lblCompName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCompName.ImageIndex = CType(resources.GetObject("lblCompName.ImageIndex"), Integer)
        Me.lblCompName.ImeMode = CType(resources.GetObject("lblCompName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCompName.Location = CType(resources.GetObject("lblCompName.Location"), System.Drawing.Point)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.RightToLeft = CType(resources.GetObject("lblCompName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblCompName.Size = CType(resources.GetObject("lblCompName.Size"), System.Drawing.Size)
        Me.lblCompName.TabIndex = CType(resources.GetObject("lblCompName.TabIndex"), Integer)
        Me.lblCompName.Text = resources.GetString("lblCompName.Text")
        Me.lblCompName.TextAlign = CType(resources.GetObject("lblCompName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCompName.Visible = CType(resources.GetObject("lblCompName.Visible"), Boolean)
        '
        'lblCopyright
        '
        Me.lblCopyright.AccessibleDescription = CType(resources.GetObject("lblCopyright.AccessibleDescription"), String)
        Me.lblCopyright.AccessibleName = CType(resources.GetObject("lblCopyright.AccessibleName"), String)
        Me.lblCopyright.Anchor = CType(resources.GetObject("lblCopyright.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.AutoSize = CType(resources.GetObject("lblCopyright.AutoSize"), Boolean)
        Me.lblCopyright.Dock = CType(resources.GetObject("lblCopyright.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCopyright.Enabled = CType(resources.GetObject("lblCopyright.Enabled"), Boolean)
        Me.lblCopyright.Font = CType(resources.GetObject("lblCopyright.Font"), System.Drawing.Font)
        Me.lblCopyright.Image = CType(resources.GetObject("lblCopyright.Image"), System.Drawing.Image)
        Me.lblCopyright.ImageAlign = CType(resources.GetObject("lblCopyright.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCopyright.ImageIndex = CType(resources.GetObject("lblCopyright.ImageIndex"), Integer)
        Me.lblCopyright.ImeMode = CType(resources.GetObject("lblCopyright.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCopyright.Location = CType(resources.GetObject("lblCopyright.Location"), System.Drawing.Point)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.RightToLeft = CType(resources.GetObject("lblCopyright.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblCopyright.Size = CType(resources.GetObject("lblCopyright.Size"), System.Drawing.Size)
        Me.lblCopyright.TabIndex = CType(resources.GetObject("lblCopyright.TabIndex"), Integer)
        Me.lblCopyright.Text = resources.GetString("lblCopyright.Text")
        Me.lblCopyright.TextAlign = CType(resources.GetObject("lblCopyright.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCopyright.Visible = CType(resources.GetObject("lblCopyright.Visible"), Boolean)
        '
        'btnOK
        '
        Me.btnOK.AccessibleDescription = CType(resources.GetObject("btnOK.AccessibleDescription"), String)
        Me.btnOK.AccessibleName = CType(resources.GetObject("btnOK.AccessibleName"), String)
        Me.btnOK.Anchor = CType(resources.GetObject("btnOK.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
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
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = CType(resources.GetObject("PictureBox1.AccessibleDescription"), String)
        Me.PictureBox1.AccessibleName = CType(resources.GetObject("PictureBox1.AccessibleName"), String)
        Me.PictureBox1.Anchor = CType(resources.GetObject("PictureBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = CType(resources.GetObject("PictureBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox1.Enabled = CType(resources.GetObject("PictureBox1.Enabled"), Boolean)
        Me.PictureBox1.Font = CType(resources.GetObject("PictureBox1.Font"), System.Drawing.Font)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = CType(resources.GetObject("PictureBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox1.Location = CType(resources.GetObject("PictureBox1.Location"), System.Drawing.Point)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.RightToLeft = CType(resources.GetObject("PictureBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox1.Size = CType(resources.GetObject("PictureBox1.Size"), System.Drawing.Size)
        Me.PictureBox1.SizeMode = CType(resources.GetObject("PictureBox1.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox1.TabIndex = CType(resources.GetObject("PictureBox1.TabIndex"), Integer)
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Text = resources.GetString("PictureBox1.Text")
        Me.PictureBox1.Visible = CType(resources.GetObject("PictureBox1.Visible"), Boolean)
        '
        'lblAddress
        '
        Me.lblAddress.AccessibleDescription = CType(resources.GetObject("lblAddress.AccessibleDescription"), String)
        Me.lblAddress.AccessibleName = CType(resources.GetObject("lblAddress.AccessibleName"), String)
        Me.lblAddress.Anchor = CType(resources.GetObject("lblAddress.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = CType(resources.GetObject("lblAddress.AutoSize"), Boolean)
        Me.lblAddress.Dock = CType(resources.GetObject("lblAddress.Dock"), System.Windows.Forms.DockStyle)
        Me.lblAddress.Enabled = CType(resources.GetObject("lblAddress.Enabled"), Boolean)
        Me.lblAddress.Font = CType(resources.GetObject("lblAddress.Font"), System.Drawing.Font)
        Me.lblAddress.Image = CType(resources.GetObject("lblAddress.Image"), System.Drawing.Image)
        Me.lblAddress.ImageAlign = CType(resources.GetObject("lblAddress.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblAddress.ImageIndex = CType(resources.GetObject("lblAddress.ImageIndex"), Integer)
        Me.lblAddress.ImeMode = CType(resources.GetObject("lblAddress.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblAddress.Location = CType(resources.GetObject("lblAddress.Location"), System.Drawing.Point)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.RightToLeft = CType(resources.GetObject("lblAddress.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblAddress.Size = CType(resources.GetObject("lblAddress.Size"), System.Drawing.Size)
        Me.lblAddress.TabIndex = CType(resources.GetObject("lblAddress.TabIndex"), Integer)
        Me.lblAddress.Text = resources.GetString("lblAddress.Text")
        Me.lblAddress.TextAlign = CType(resources.GetObject("lblAddress.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblAddress.Visible = CType(resources.GetObject("lblAddress.Visible"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = CType(resources.GetObject("Label3.AccessibleDescription"), String)
        Me.Label3.AccessibleName = CType(resources.GetObject("Label3.AccessibleName"), String)
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        'lblOrderInfo
        '
        Me.lblOrderInfo.AccessibleDescription = CType(resources.GetObject("lblOrderInfo.AccessibleDescription"), String)
        Me.lblOrderInfo.AccessibleName = CType(resources.GetObject("lblOrderInfo.AccessibleName"), String)
        Me.lblOrderInfo.Anchor = CType(resources.GetObject("lblOrderInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblOrderInfo.AutoSize = CType(resources.GetObject("lblOrderInfo.AutoSize"), Boolean)
        Me.lblOrderInfo.Dock = CType(resources.GetObject("lblOrderInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.lblOrderInfo.Enabled = CType(resources.GetObject("lblOrderInfo.Enabled"), Boolean)
        Me.lblOrderInfo.Font = CType(resources.GetObject("lblOrderInfo.Font"), System.Drawing.Font)
        Me.lblOrderInfo.Image = CType(resources.GetObject("lblOrderInfo.Image"), System.Drawing.Image)
        Me.lblOrderInfo.ImageAlign = CType(resources.GetObject("lblOrderInfo.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblOrderInfo.ImageIndex = CType(resources.GetObject("lblOrderInfo.ImageIndex"), Integer)
        Me.lblOrderInfo.ImeMode = CType(resources.GetObject("lblOrderInfo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblOrderInfo.Location = CType(resources.GetObject("lblOrderInfo.Location"), System.Drawing.Point)
        Me.lblOrderInfo.Name = "lblOrderInfo"
        Me.lblOrderInfo.RightToLeft = CType(resources.GetObject("lblOrderInfo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblOrderInfo.Size = CType(resources.GetObject("lblOrderInfo.Size"), System.Drawing.Size)
        Me.lblOrderInfo.TabIndex = CType(resources.GetObject("lblOrderInfo.TabIndex"), Integer)
        Me.lblOrderInfo.Text = resources.GetString("lblOrderInfo.Text")
        Me.lblOrderInfo.TextAlign = CType(resources.GetObject("lblOrderInfo.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblOrderInfo.Visible = CType(resources.GetObject("lblOrderInfo.Visible"), Boolean)
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
        'lblIssuedDate
        '
        Me.lblIssuedDate.AccessibleDescription = CType(resources.GetObject("lblIssuedDate.AccessibleDescription"), String)
        Me.lblIssuedDate.AccessibleName = CType(resources.GetObject("lblIssuedDate.AccessibleName"), String)
        Me.lblIssuedDate.Anchor = CType(resources.GetObject("lblIssuedDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblIssuedDate.AutoSize = CType(resources.GetObject("lblIssuedDate.AutoSize"), Boolean)
        Me.lblIssuedDate.Dock = CType(resources.GetObject("lblIssuedDate.Dock"), System.Windows.Forms.DockStyle)
        Me.lblIssuedDate.Enabled = CType(resources.GetObject("lblIssuedDate.Enabled"), Boolean)
        Me.lblIssuedDate.Font = CType(resources.GetObject("lblIssuedDate.Font"), System.Drawing.Font)
        Me.lblIssuedDate.Image = CType(resources.GetObject("lblIssuedDate.Image"), System.Drawing.Image)
        Me.lblIssuedDate.ImageAlign = CType(resources.GetObject("lblIssuedDate.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblIssuedDate.ImageIndex = CType(resources.GetObject("lblIssuedDate.ImageIndex"), Integer)
        Me.lblIssuedDate.ImeMode = CType(resources.GetObject("lblIssuedDate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblIssuedDate.Location = CType(resources.GetObject("lblIssuedDate.Location"), System.Drawing.Point)
        Me.lblIssuedDate.Name = "lblIssuedDate"
        Me.lblIssuedDate.RightToLeft = CType(resources.GetObject("lblIssuedDate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblIssuedDate.Size = CType(resources.GetObject("lblIssuedDate.Size"), System.Drawing.Size)
        Me.lblIssuedDate.TabIndex = CType(resources.GetObject("lblIssuedDate.TabIndex"), Integer)
        Me.lblIssuedDate.Text = resources.GetString("lblIssuedDate.Text")
        Me.lblIssuedDate.TextAlign = CType(resources.GetObject("lblIssuedDate.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblIssuedDate.Visible = CType(resources.GetObject("lblIssuedDate.Visible"), Boolean)
        '
        'lblProgRegCaption
        '
        Me.lblProgRegCaption.AccessibleDescription = CType(resources.GetObject("lblProgRegCaption.AccessibleDescription"), String)
        Me.lblProgRegCaption.AccessibleName = CType(resources.GetObject("lblProgRegCaption.AccessibleName"), String)
        Me.lblProgRegCaption.Anchor = CType(resources.GetObject("lblProgRegCaption.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblProgRegCaption.AutoSize = CType(resources.GetObject("lblProgRegCaption.AutoSize"), Boolean)
        Me.lblProgRegCaption.Dock = CType(resources.GetObject("lblProgRegCaption.Dock"), System.Windows.Forms.DockStyle)
        Me.lblProgRegCaption.Enabled = CType(resources.GetObject("lblProgRegCaption.Enabled"), Boolean)
        Me.lblProgRegCaption.Font = CType(resources.GetObject("lblProgRegCaption.Font"), System.Drawing.Font)
        Me.lblProgRegCaption.Image = CType(resources.GetObject("lblProgRegCaption.Image"), System.Drawing.Image)
        Me.lblProgRegCaption.ImageAlign = CType(resources.GetObject("lblProgRegCaption.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblProgRegCaption.ImageIndex = CType(resources.GetObject("lblProgRegCaption.ImageIndex"), Integer)
        Me.lblProgRegCaption.ImeMode = CType(resources.GetObject("lblProgRegCaption.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblProgRegCaption.Location = CType(resources.GetObject("lblProgRegCaption.Location"), System.Drawing.Point)
        Me.lblProgRegCaption.Name = "lblProgRegCaption"
        Me.lblProgRegCaption.RightToLeft = CType(resources.GetObject("lblProgRegCaption.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblProgRegCaption.Size = CType(resources.GetObject("lblProgRegCaption.Size"), System.Drawing.Size)
        Me.lblProgRegCaption.TabIndex = CType(resources.GetObject("lblProgRegCaption.TabIndex"), Integer)
        Me.lblProgRegCaption.Text = resources.GetString("lblProgRegCaption.Text")
        Me.lblProgRegCaption.TextAlign = CType(resources.GetObject("lblProgRegCaption.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblProgRegCaption.Visible = CType(resources.GetObject("lblProgRegCaption.Visible"), Boolean)
        '
        'lblName
        '
        Me.lblName.AccessibleDescription = CType(resources.GetObject("lblName.AccessibleDescription"), String)
        Me.lblName.AccessibleName = CType(resources.GetObject("lblName.AccessibleName"), String)
        Me.lblName.Anchor = CType(resources.GetObject("lblName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = CType(resources.GetObject("lblName.AutoSize"), Boolean)
        Me.lblName.Dock = CType(resources.GetObject("lblName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblName.Enabled = CType(resources.GetObject("lblName.Enabled"), Boolean)
        Me.lblName.Font = CType(resources.GetObject("lblName.Font"), System.Drawing.Font)
        Me.lblName.Image = CType(resources.GetObject("lblName.Image"), System.Drawing.Image)
        Me.lblName.ImageAlign = CType(resources.GetObject("lblName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblName.ImageIndex = CType(resources.GetObject("lblName.ImageIndex"), Integer)
        Me.lblName.ImeMode = CType(resources.GetObject("lblName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblName.Location = CType(resources.GetObject("lblName.Location"), System.Drawing.Point)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = CType(resources.GetObject("lblName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblName.Size = CType(resources.GetObject("lblName.Size"), System.Drawing.Size)
        Me.lblName.TabIndex = CType(resources.GetObject("lblName.TabIndex"), Integer)
        Me.lblName.Text = resources.GetString("lblName.Text")
        Me.lblName.TextAlign = CType(resources.GetObject("lblName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblName.Visible = CType(resources.GetObject("lblName.Visible"), Boolean)
        '
        'lblLicense
        '
        Me.lblLicense.AccessibleDescription = CType(resources.GetObject("lblLicense.AccessibleDescription"), String)
        Me.lblLicense.AccessibleName = CType(resources.GetObject("lblLicense.AccessibleName"), String)
        Me.lblLicense.Anchor = CType(resources.GetObject("lblLicense.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblLicense.AutoSize = CType(resources.GetObject("lblLicense.AutoSize"), Boolean)
        Me.lblLicense.BackColor = System.Drawing.SystemColors.Control
        Me.lblLicense.Dock = CType(resources.GetObject("lblLicense.Dock"), System.Windows.Forms.DockStyle)
        Me.lblLicense.Enabled = CType(resources.GetObject("lblLicense.Enabled"), Boolean)
        Me.lblLicense.Font = CType(resources.GetObject("lblLicense.Font"), System.Drawing.Font)
        Me.lblLicense.Image = CType(resources.GetObject("lblLicense.Image"), System.Drawing.Image)
        Me.lblLicense.ImageAlign = CType(resources.GetObject("lblLicense.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblLicense.ImageIndex = CType(resources.GetObject("lblLicense.ImageIndex"), Integer)
        Me.lblLicense.ImeMode = CType(resources.GetObject("lblLicense.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblLicense.Location = CType(resources.GetObject("lblLicense.Location"), System.Drawing.Point)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.RightToLeft = CType(resources.GetObject("lblLicense.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblLicense.Size = CType(resources.GetObject("lblLicense.Size"), System.Drawing.Size)
        Me.lblLicense.TabIndex = CType(resources.GetObject("lblLicense.TabIndex"), Integer)
        Me.lblLicense.Text = resources.GetString("lblLicense.Text")
        Me.lblLicense.TextAlign = CType(resources.GetObject("lblLicense.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblLicense.Visible = CType(resources.GetObject("lblLicense.Visible"), Boolean)
        '
        'frmAbout
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLicense, Me.Label3, Me.PictureBox1, Me.btnOK, Me.lblIssuedDate, Me.lblOrderInfo, Me.lblEmail, Me.lblAddress, Me.lblName, Me.lblProgRegCaption, Me.lblCopyright, Me.lblCompName, Me.lblProdName, Me.lblProdVer})
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
        Me.Name = "frmAbout"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsAboveOrEqualWinXp() = True Then
            btnOK.FlatStyle = FlatStyle.System
        End If

        SetBackcolors()

        'Remember this form needs adding to the AssemblyInfo ObfuscateBlock section
        Try
            Dim Res As New IPIconsPack.Resource
            PictureBox1.Image = Res.picMCLLogo.Image
        Catch
        End Try


        With GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
            Me.Text = NameMe(Me.Text)
            lblProdName.Text = .ProductName
            Try
                lblProdVer.Text = LangText.GetString("IpstdOnly_Version") & " " & .ProductVersion
            Catch
                lblProdVer.Text = "Version " & .ProductVersion
            End Try

            Try
                lblCompName.Text = LangText.GetString("IpSplash_DevelopedBy") & " " & .CompanyName
            Catch
                lblCompName.Text = "Developed by " & .CompanyName
            End Try

            lblCopyright.Text = .LegalCopyright
        End With

        Dim lintResult As Integer = 3
        If File.Exists(System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\keyfile.mcl") = True Then
            lintResult = Details(System.IO.Path.GetDirectoryName( _
                    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\keyfile.mcl")

            If AppBasic.strman.Occurences(lblAddress.Text.ToUpper, "UNAVAILABLE") = 5 Then
                lblAddress.Visible = False
                Me.Height = Me.Height - 88
            End If
        End If

        If lintResult <> 0 Then
            lblLicense.Text = ""

            lblProgRegCaption.Visible = False
            lblName.Visible = False
            lblAddress.Visible = False
            lblEmail.Visible = False
            lblIssuedDate.Visible = False
            lblOrderInfo.Visible = False

            Me.Height = 216
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Me.Close()
    End Sub
    Private Function Details(ByVal pstrFile As String) As Integer

        Dim Dets As strat1.UnlockDetails
        Dim lintResult As Integer

        Try
            lintResult = Unlock(pstrFile, Dets, "", "") 'added ,"" 
        Catch
            lintResult = 3
        End Try

        With Dets
            .str11LicenseName = .str11LicenseName.Replace("2003", "2007")
            .str11LicenseName = .str11LicenseName.Replace("2004", "2007")
            .str11LicenseName = .str11LicenseName.Replace("2005", "2007")
            .str11LicenseName = .str11LicenseName.Replace("2006", "2007")

            lblLicense.Text = ProperCase(LeftGet(.str11LicenseName, .str11LicenseName.Length - 4))
            lblName.Text = ProperCase(.str1Name)
            lblAddress.Text = ProperCase(.str2Street & Environment.NewLine & _
                 .str3City & Environment.NewLine & _
                 .str4State) & Environment.NewLine & _
                 .str5Zip.ToUpper & Environment.NewLine & _
                 ProperCase(.str6Country)
            lblEmail.Text = ProperCase(.str7Email)
            lblIssuedDate.Text = .str8OrderDate & " " & .str9TransNum
        End With

        Select Case lintResult
            Case 0
                Details = 256
            Case 2
                Details = 257
            Case 3
                'MsgxBox("Cracked!")
                Details = 268
        End Select
    End Function

    Private Sub frmAbout_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub SetBackcolors()

        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        lblProdVer.BackColor = Color.FromArgb(0, lblProdVer.BackColor)
        lblProdName.BackColor = Color.FromArgb(0, lblProdName.BackColor)
        lblCompName.BackColor = Color.FromArgb(0, lblCompName.BackColor)
        lblCopyright.BackColor = Color.FromArgb(0, lblCopyright.BackColor)
        PictureBox1.BackColor = Color.FromArgb(0, PictureBox1.BackColor)
        lblAddress.BackColor = Color.FromArgb(0, lblAddress.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)
        lblEmail.BackColor = Color.FromArgb(0, lblEmail.BackColor)
        lblIssuedDate.BackColor = Color.FromArgb(0, lblIssuedDate.BackColor)
        lblName.BackColor = Color.FromArgb(0, lblName.BackColor)
        lblLicense.BackColor = Color.FromArgb(0, lblLicense.BackColor)
        lblOrderInfo.BackColor = Color.FromArgb(0, lblOrderInfo.BackColor)
        lblProgRegCaption.BackColor = Color.FromArgb(0, lblProgRegCaption.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub frmAbout_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate()
    End Sub
End Class