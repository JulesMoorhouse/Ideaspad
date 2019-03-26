Imports mshtml
Imports System.IO
Friend Class frmRemind
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picMCLLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBullet4 As System.Windows.Forms.Label
    Friend WithEvents lblBullet3 As System.Windows.Forms.Label
    Friend WithEvents lblBullet2 As System.Windows.Forms.Label
    Friend WithEvents lblBullet1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRemindLater As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCode As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRemind))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRemindLater = New System.Windows.Forms.Button()
        Me.picMCLLogo = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBullet4 = New System.Windows.Forms.Label()
        Me.lblBullet3 = New System.Windows.Forms.Label()
        Me.lblBullet2 = New System.Windows.Forms.Label()
        Me.lblBullet1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnCode = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox8, Me.PictureBox7, Me.PictureBox6, Me.PictureBox5, Me.PictureBox4, Me.PictureBox3, Me.PictureBox2, Me.PictureBox1, Me.btnRemindLater, Me.picMCLLogo, Me.btnHelp, Me.Label8, Me.LinkLabel1, Me.Label6, Me.lblBullet4, Me.lblBullet3, Me.lblBullet2, Me.lblBullet1, Me.Label1, Me.Label2, Me.TreeView1, Me.RichTextBox1, Me.btnCode})
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
        'PictureBox8
        '
        Me.PictureBox8.AccessibleDescription = CType(resources.GetObject("PictureBox8.AccessibleDescription"), String)
        Me.PictureBox8.AccessibleName = CType(resources.GetObject("PictureBox8.AccessibleName"), String)
        Me.PictureBox8.Anchor = CType(resources.GetObject("PictureBox8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Dock = CType(resources.GetObject("PictureBox8.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox8.Enabled = CType(resources.GetObject("PictureBox8.Enabled"), Boolean)
        Me.PictureBox8.Font = CType(resources.GetObject("PictureBox8.Font"), System.Drawing.Font)
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Bitmap)
        Me.PictureBox8.ImeMode = CType(resources.GetObject("PictureBox8.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox8.Location = CType(resources.GetObject("PictureBox8.Location"), System.Drawing.Point)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.RightToLeft = CType(resources.GetObject("PictureBox8.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox8.Size = CType(resources.GetObject("PictureBox8.Size"), System.Drawing.Size)
        Me.PictureBox8.SizeMode = CType(resources.GetObject("PictureBox8.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox8.TabIndex = CType(resources.GetObject("PictureBox8.TabIndex"), Integer)
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Text = resources.GetString("PictureBox8.Text")
        Me.PictureBox8.Visible = CType(resources.GetObject("PictureBox8.Visible"), Boolean)
        '
        'PictureBox7
        '
        Me.PictureBox7.AccessibleDescription = CType(resources.GetObject("PictureBox7.AccessibleDescription"), String)
        Me.PictureBox7.AccessibleName = CType(resources.GetObject("PictureBox7.AccessibleName"), String)
        Me.PictureBox7.Anchor = CType(resources.GetObject("PictureBox7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.Dock = CType(resources.GetObject("PictureBox7.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox7.Enabled = CType(resources.GetObject("PictureBox7.Enabled"), Boolean)
        Me.PictureBox7.Font = CType(resources.GetObject("PictureBox7.Font"), System.Drawing.Font)
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Bitmap)
        Me.PictureBox7.ImeMode = CType(resources.GetObject("PictureBox7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox7.Location = CType(resources.GetObject("PictureBox7.Location"), System.Drawing.Point)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.RightToLeft = CType(resources.GetObject("PictureBox7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox7.Size = CType(resources.GetObject("PictureBox7.Size"), System.Drawing.Size)
        Me.PictureBox7.SizeMode = CType(resources.GetObject("PictureBox7.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox7.TabIndex = CType(resources.GetObject("PictureBox7.TabIndex"), Integer)
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Text = resources.GetString("PictureBox7.Text")
        Me.PictureBox7.Visible = CType(resources.GetObject("PictureBox7.Visible"), Boolean)
        '
        'PictureBox6
        '
        Me.PictureBox6.AccessibleDescription = CType(resources.GetObject("PictureBox6.AccessibleDescription"), String)
        Me.PictureBox6.AccessibleName = CType(resources.GetObject("PictureBox6.AccessibleName"), String)
        Me.PictureBox6.Anchor = CType(resources.GetObject("PictureBox6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Dock = CType(resources.GetObject("PictureBox6.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox6.Enabled = CType(resources.GetObject("PictureBox6.Enabled"), Boolean)
        Me.PictureBox6.Font = CType(resources.GetObject("PictureBox6.Font"), System.Drawing.Font)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Bitmap)
        Me.PictureBox6.ImeMode = CType(resources.GetObject("PictureBox6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox6.Location = CType(resources.GetObject("PictureBox6.Location"), System.Drawing.Point)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.RightToLeft = CType(resources.GetObject("PictureBox6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox6.Size = CType(resources.GetObject("PictureBox6.Size"), System.Drawing.Size)
        Me.PictureBox6.SizeMode = CType(resources.GetObject("PictureBox6.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox6.TabIndex = CType(resources.GetObject("PictureBox6.TabIndex"), Integer)
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Text = resources.GetString("PictureBox6.Text")
        Me.PictureBox6.Visible = CType(resources.GetObject("PictureBox6.Visible"), Boolean)
        '
        'PictureBox5
        '
        Me.PictureBox5.AccessibleDescription = CType(resources.GetObject("PictureBox5.AccessibleDescription"), String)
        Me.PictureBox5.AccessibleName = CType(resources.GetObject("PictureBox5.AccessibleName"), String)
        Me.PictureBox5.Anchor = CType(resources.GetObject("PictureBox5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Dock = CType(resources.GetObject("PictureBox5.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox5.Enabled = CType(resources.GetObject("PictureBox5.Enabled"), Boolean)
        Me.PictureBox5.Font = CType(resources.GetObject("PictureBox5.Font"), System.Drawing.Font)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Bitmap)
        Me.PictureBox5.ImeMode = CType(resources.GetObject("PictureBox5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox5.Location = CType(resources.GetObject("PictureBox5.Location"), System.Drawing.Point)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.RightToLeft = CType(resources.GetObject("PictureBox5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox5.Size = CType(resources.GetObject("PictureBox5.Size"), System.Drawing.Size)
        Me.PictureBox5.SizeMode = CType(resources.GetObject("PictureBox5.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox5.TabIndex = CType(resources.GetObject("PictureBox5.TabIndex"), Integer)
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Text = resources.GetString("PictureBox5.Text")
        Me.PictureBox5.Visible = CType(resources.GetObject("PictureBox5.Visible"), Boolean)
        '
        'PictureBox4
        '
        Me.PictureBox4.AccessibleDescription = CType(resources.GetObject("PictureBox4.AccessibleDescription"), String)
        Me.PictureBox4.AccessibleName = CType(resources.GetObject("PictureBox4.AccessibleName"), String)
        Me.PictureBox4.Anchor = CType(resources.GetObject("PictureBox4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Dock = CType(resources.GetObject("PictureBox4.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox4.Enabled = CType(resources.GetObject("PictureBox4.Enabled"), Boolean)
        Me.PictureBox4.Font = CType(resources.GetObject("PictureBox4.Font"), System.Drawing.Font)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Bitmap)
        Me.PictureBox4.ImeMode = CType(resources.GetObject("PictureBox4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox4.Location = CType(resources.GetObject("PictureBox4.Location"), System.Drawing.Point)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.RightToLeft = CType(resources.GetObject("PictureBox4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox4.Size = CType(resources.GetObject("PictureBox4.Size"), System.Drawing.Size)
        Me.PictureBox4.SizeMode = CType(resources.GetObject("PictureBox4.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox4.TabIndex = CType(resources.GetObject("PictureBox4.TabIndex"), Integer)
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Text = resources.GetString("PictureBox4.Text")
        Me.PictureBox4.Visible = CType(resources.GetObject("PictureBox4.Visible"), Boolean)
        '
        'PictureBox3
        '
        Me.PictureBox3.AccessibleDescription = CType(resources.GetObject("PictureBox3.AccessibleDescription"), String)
        Me.PictureBox3.AccessibleName = CType(resources.GetObject("PictureBox3.AccessibleName"), String)
        Me.PictureBox3.Anchor = CType(resources.GetObject("PictureBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Dock = CType(resources.GetObject("PictureBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox3.Enabled = CType(resources.GetObject("PictureBox3.Enabled"), Boolean)
        Me.PictureBox3.Font = CType(resources.GetObject("PictureBox3.Font"), System.Drawing.Font)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Bitmap)
        Me.PictureBox3.ImeMode = CType(resources.GetObject("PictureBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox3.Location = CType(resources.GetObject("PictureBox3.Location"), System.Drawing.Point)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.RightToLeft = CType(resources.GetObject("PictureBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox3.Size = CType(resources.GetObject("PictureBox3.Size"), System.Drawing.Size)
        Me.PictureBox3.SizeMode = CType(resources.GetObject("PictureBox3.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox3.TabIndex = CType(resources.GetObject("PictureBox3.TabIndex"), Integer)
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Text = resources.GetString("PictureBox3.Text")
        Me.PictureBox3.Visible = CType(resources.GetObject("PictureBox3.Visible"), Boolean)
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleDescription = CType(resources.GetObject("PictureBox2.AccessibleDescription"), String)
        Me.PictureBox2.AccessibleName = CType(resources.GetObject("PictureBox2.AccessibleName"), String)
        Me.PictureBox2.Anchor = CType(resources.GetObject("PictureBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Dock = CType(resources.GetObject("PictureBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox2.Enabled = CType(resources.GetObject("PictureBox2.Enabled"), Boolean)
        Me.PictureBox2.Font = CType(resources.GetObject("PictureBox2.Font"), System.Drawing.Font)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.ImeMode = CType(resources.GetObject("PictureBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox2.Location = CType(resources.GetObject("PictureBox2.Location"), System.Drawing.Point)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.RightToLeft = CType(resources.GetObject("PictureBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox2.Size = CType(resources.GetObject("PictureBox2.Size"), System.Drawing.Size)
        Me.PictureBox2.SizeMode = CType(resources.GetObject("PictureBox2.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox2.TabIndex = CType(resources.GetObject("PictureBox2.TabIndex"), Integer)
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Text = resources.GetString("PictureBox2.Text")
        Me.PictureBox2.Visible = CType(resources.GetObject("PictureBox2.Visible"), Boolean)
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
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
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
        'btnRemindLater
        '
        Me.btnRemindLater.AccessibleDescription = CType(resources.GetObject("btnRemindLater.AccessibleDescription"), String)
        Me.btnRemindLater.AccessibleName = CType(resources.GetObject("btnRemindLater.AccessibleName"), String)
        Me.btnRemindLater.Anchor = CType(resources.GetObject("btnRemindLater.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnRemindLater.BackColor = System.Drawing.SystemColors.Control
        Me.btnRemindLater.BackgroundImage = CType(resources.GetObject("btnRemindLater.BackgroundImage"), System.Drawing.Image)
        Me.btnRemindLater.Dock = CType(resources.GetObject("btnRemindLater.Dock"), System.Windows.Forms.DockStyle)
        Me.btnRemindLater.Enabled = CType(resources.GetObject("btnRemindLater.Enabled"), Boolean)
        Me.btnRemindLater.FlatStyle = CType(resources.GetObject("btnRemindLater.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnRemindLater.Font = CType(resources.GetObject("btnRemindLater.Font"), System.Drawing.Font)
        Me.btnRemindLater.Image = CType(resources.GetObject("btnRemindLater.Image"), System.Drawing.Image)
        Me.btnRemindLater.ImageAlign = CType(resources.GetObject("btnRemindLater.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnRemindLater.ImageIndex = CType(resources.GetObject("btnRemindLater.ImageIndex"), Integer)
        Me.btnRemindLater.ImeMode = CType(resources.GetObject("btnRemindLater.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnRemindLater.Location = CType(resources.GetObject("btnRemindLater.Location"), System.Drawing.Point)
        Me.btnRemindLater.Name = "btnRemindLater"
        Me.btnRemindLater.RightToLeft = CType(resources.GetObject("btnRemindLater.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnRemindLater.Size = CType(resources.GetObject("btnRemindLater.Size"), System.Drawing.Size)
        Me.btnRemindLater.TabIndex = CType(resources.GetObject("btnRemindLater.TabIndex"), Integer)
        Me.btnRemindLater.Text = resources.GetString("btnRemindLater.Text")
        Me.btnRemindLater.TextAlign = CType(resources.GetObject("btnRemindLater.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnRemindLater.Visible = CType(resources.GetObject("btnRemindLater.Visible"), Boolean)
        '
        'picMCLLogo
        '
        Me.picMCLLogo.AccessibleDescription = CType(resources.GetObject("picMCLLogo.AccessibleDescription"), String)
        Me.picMCLLogo.AccessibleName = CType(resources.GetObject("picMCLLogo.AccessibleName"), String)
        Me.picMCLLogo.Anchor = CType(resources.GetObject("picMCLLogo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.picMCLLogo.BackgroundImage = CType(resources.GetObject("picMCLLogo.BackgroundImage"), System.Drawing.Image)
        Me.picMCLLogo.Dock = CType(resources.GetObject("picMCLLogo.Dock"), System.Windows.Forms.DockStyle)
        Me.picMCLLogo.Enabled = CType(resources.GetObject("picMCLLogo.Enabled"), Boolean)
        Me.picMCLLogo.Font = CType(resources.GetObject("picMCLLogo.Font"), System.Drawing.Font)
        Me.picMCLLogo.Image = CType(resources.GetObject("picMCLLogo.Image"), System.Drawing.Image)
        Me.picMCLLogo.ImeMode = CType(resources.GetObject("picMCLLogo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.picMCLLogo.Location = CType(resources.GetObject("picMCLLogo.Location"), System.Drawing.Point)
        Me.picMCLLogo.Name = "picMCLLogo"
        Me.picMCLLogo.RightToLeft = CType(resources.GetObject("picMCLLogo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.picMCLLogo.Size = CType(resources.GetObject("picMCLLogo.Size"), System.Drawing.Size)
        Me.picMCLLogo.SizeMode = CType(resources.GetObject("picMCLLogo.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.picMCLLogo.TabIndex = CType(resources.GetObject("picMCLLogo.TabIndex"), Integer)
        Me.picMCLLogo.TabStop = False
        Me.picMCLLogo.Text = resources.GetString("picMCLLogo.Text")
        Me.picMCLLogo.Visible = CType(resources.GetObject("picMCLLogo.Visible"), Boolean)
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleDescription = CType(resources.GetObject("btnHelp.AccessibleDescription"), String)
        Me.btnHelp.AccessibleName = CType(resources.GetObject("btnHelp.AccessibleName"), String)
        Me.btnHelp.Anchor = CType(resources.GetObject("btnHelp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackColor = System.Drawing.SystemColors.Control
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
        'Label8
        '
        Me.Label8.AccessibleDescription = CType(resources.GetObject("Label8.AccessibleDescription"), String)
        Me.Label8.AccessibleName = CType(resources.GetObject("Label8.AccessibleName"), String)
        Me.Label8.Anchor = CType(resources.GetObject("Label8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = CType(resources.GetObject("Label8.AutoSize"), Boolean)
        Me.Label8.Dock = CType(resources.GetObject("Label8.Dock"), System.Windows.Forms.DockStyle)
        Me.Label8.Enabled = CType(resources.GetObject("Label8.Enabled"), Boolean)
        Me.Label8.Font = CType(resources.GetObject("Label8.Font"), System.Drawing.Font)
        Me.Label8.ForeColor = System.Drawing.Color.Red
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
        'LinkLabel1
        '
        Me.LinkLabel1.AccessibleDescription = CType(resources.GetObject("LinkLabel1.AccessibleDescription"), String)
        Me.LinkLabel1.AccessibleName = CType(resources.GetObject("LinkLabel1.AccessibleName"), String)
        Me.LinkLabel1.Anchor = CType(resources.GetObject("LinkLabel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = CType(resources.GetObject("LinkLabel1.AutoSize"), Boolean)
        Me.LinkLabel1.Dock = CType(resources.GetObject("LinkLabel1.Dock"), System.Windows.Forms.DockStyle)
        Me.LinkLabel1.Enabled = CType(resources.GetObject("LinkLabel1.Enabled"), Boolean)
        Me.LinkLabel1.Font = CType(resources.GetObject("LinkLabel1.Font"), System.Drawing.Font)
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), System.Drawing.Image)
        Me.LinkLabel1.ImageAlign = CType(resources.GetObject("LinkLabel1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.LinkLabel1.ImageIndex = CType(resources.GetObject("LinkLabel1.ImageIndex"), Integer)
        Me.LinkLabel1.ImeMode = CType(resources.GetObject("LinkLabel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LinkLabel1.LinkArea = CType(resources.GetObject("LinkLabel1.LinkArea"), System.Windows.Forms.LinkArea)
        Me.LinkLabel1.Location = CType(resources.GetObject("LinkLabel1.Location"), System.Drawing.Point)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.RightToLeft = CType(resources.GetObject("LinkLabel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LinkLabel1.Size = CType(resources.GetObject("LinkLabel1.Size"), System.Drawing.Size)
        Me.LinkLabel1.TabIndex = CType(resources.GetObject("LinkLabel1.TabIndex"), Integer)
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = resources.GetString("LinkLabel1.Text")
        Me.LinkLabel1.TextAlign = CType(resources.GetObject("LinkLabel1.TextAlign"), System.Drawing.ContentAlignment)
        Me.LinkLabel1.Visible = CType(resources.GetObject("LinkLabel1.Visible"), Boolean)
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
        'lblBullet4
        '
        Me.lblBullet4.AccessibleDescription = CType(resources.GetObject("lblBullet4.AccessibleDescription"), String)
        Me.lblBullet4.AccessibleName = CType(resources.GetObject("lblBullet4.AccessibleName"), String)
        Me.lblBullet4.Anchor = CType(resources.GetObject("lblBullet4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBullet4.AutoSize = CType(resources.GetObject("lblBullet4.AutoSize"), Boolean)
        Me.lblBullet4.Dock = CType(resources.GetObject("lblBullet4.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBullet4.Enabled = CType(resources.GetObject("lblBullet4.Enabled"), Boolean)
        Me.lblBullet4.Font = CType(resources.GetObject("lblBullet4.Font"), System.Drawing.Font)
        Me.lblBullet4.Image = CType(resources.GetObject("lblBullet4.Image"), System.Drawing.Image)
        Me.lblBullet4.ImageAlign = CType(resources.GetObject("lblBullet4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet4.ImageIndex = CType(resources.GetObject("lblBullet4.ImageIndex"), Integer)
        Me.lblBullet4.ImeMode = CType(resources.GetObject("lblBullet4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBullet4.Location = CType(resources.GetObject("lblBullet4.Location"), System.Drawing.Point)
        Me.lblBullet4.Name = "lblBullet4"
        Me.lblBullet4.RightToLeft = CType(resources.GetObject("lblBullet4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBullet4.Size = CType(resources.GetObject("lblBullet4.Size"), System.Drawing.Size)
        Me.lblBullet4.TabIndex = CType(resources.GetObject("lblBullet4.TabIndex"), Integer)
        Me.lblBullet4.Text = resources.GetString("lblBullet4.Text")
        Me.lblBullet4.TextAlign = CType(resources.GetObject("lblBullet4.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet4.Visible = CType(resources.GetObject("lblBullet4.Visible"), Boolean)
        '
        'lblBullet3
        '
        Me.lblBullet3.AccessibleDescription = CType(resources.GetObject("lblBullet3.AccessibleDescription"), String)
        Me.lblBullet3.AccessibleName = CType(resources.GetObject("lblBullet3.AccessibleName"), String)
        Me.lblBullet3.Anchor = CType(resources.GetObject("lblBullet3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBullet3.AutoSize = CType(resources.GetObject("lblBullet3.AutoSize"), Boolean)
        Me.lblBullet3.Dock = CType(resources.GetObject("lblBullet3.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBullet3.Enabled = CType(resources.GetObject("lblBullet3.Enabled"), Boolean)
        Me.lblBullet3.Font = CType(resources.GetObject("lblBullet3.Font"), System.Drawing.Font)
        Me.lblBullet3.Image = CType(resources.GetObject("lblBullet3.Image"), System.Drawing.Image)
        Me.lblBullet3.ImageAlign = CType(resources.GetObject("lblBullet3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet3.ImageIndex = CType(resources.GetObject("lblBullet3.ImageIndex"), Integer)
        Me.lblBullet3.ImeMode = CType(resources.GetObject("lblBullet3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBullet3.Location = CType(resources.GetObject("lblBullet3.Location"), System.Drawing.Point)
        Me.lblBullet3.Name = "lblBullet3"
        Me.lblBullet3.RightToLeft = CType(resources.GetObject("lblBullet3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBullet3.Size = CType(resources.GetObject("lblBullet3.Size"), System.Drawing.Size)
        Me.lblBullet3.TabIndex = CType(resources.GetObject("lblBullet3.TabIndex"), Integer)
        Me.lblBullet3.Text = resources.GetString("lblBullet3.Text")
        Me.lblBullet3.TextAlign = CType(resources.GetObject("lblBullet3.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet3.Visible = CType(resources.GetObject("lblBullet3.Visible"), Boolean)
        '
        'lblBullet2
        '
        Me.lblBullet2.AccessibleDescription = CType(resources.GetObject("lblBullet2.AccessibleDescription"), String)
        Me.lblBullet2.AccessibleName = CType(resources.GetObject("lblBullet2.AccessibleName"), String)
        Me.lblBullet2.Anchor = CType(resources.GetObject("lblBullet2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBullet2.AutoSize = CType(resources.GetObject("lblBullet2.AutoSize"), Boolean)
        Me.lblBullet2.Dock = CType(resources.GetObject("lblBullet2.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBullet2.Enabled = CType(resources.GetObject("lblBullet2.Enabled"), Boolean)
        Me.lblBullet2.Font = CType(resources.GetObject("lblBullet2.Font"), System.Drawing.Font)
        Me.lblBullet2.Image = CType(resources.GetObject("lblBullet2.Image"), System.Drawing.Image)
        Me.lblBullet2.ImageAlign = CType(resources.GetObject("lblBullet2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet2.ImageIndex = CType(resources.GetObject("lblBullet2.ImageIndex"), Integer)
        Me.lblBullet2.ImeMode = CType(resources.GetObject("lblBullet2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBullet2.Location = CType(resources.GetObject("lblBullet2.Location"), System.Drawing.Point)
        Me.lblBullet2.Name = "lblBullet2"
        Me.lblBullet2.RightToLeft = CType(resources.GetObject("lblBullet2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBullet2.Size = CType(resources.GetObject("lblBullet2.Size"), System.Drawing.Size)
        Me.lblBullet2.TabIndex = CType(resources.GetObject("lblBullet2.TabIndex"), Integer)
        Me.lblBullet2.Text = resources.GetString("lblBullet2.Text")
        Me.lblBullet2.TextAlign = CType(resources.GetObject("lblBullet2.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet2.Visible = CType(resources.GetObject("lblBullet2.Visible"), Boolean)
        '
        'lblBullet1
        '
        Me.lblBullet1.AccessibleDescription = CType(resources.GetObject("lblBullet1.AccessibleDescription"), String)
        Me.lblBullet1.AccessibleName = CType(resources.GetObject("lblBullet1.AccessibleName"), String)
        Me.lblBullet1.Anchor = CType(resources.GetObject("lblBullet1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBullet1.AutoSize = CType(resources.GetObject("lblBullet1.AutoSize"), Boolean)
        Me.lblBullet1.Dock = CType(resources.GetObject("lblBullet1.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBullet1.Enabled = CType(resources.GetObject("lblBullet1.Enabled"), Boolean)
        Me.lblBullet1.Font = CType(resources.GetObject("lblBullet1.Font"), System.Drawing.Font)
        Me.lblBullet1.Image = CType(resources.GetObject("lblBullet1.Image"), System.Drawing.Image)
        Me.lblBullet1.ImageAlign = CType(resources.GetObject("lblBullet1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet1.ImageIndex = CType(resources.GetObject("lblBullet1.ImageIndex"), Integer)
        Me.lblBullet1.ImeMode = CType(resources.GetObject("lblBullet1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBullet1.Location = CType(resources.GetObject("lblBullet1.Location"), System.Drawing.Point)
        Me.lblBullet1.Name = "lblBullet1"
        Me.lblBullet1.RightToLeft = CType(resources.GetObject("lblBullet1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBullet1.Size = CType(resources.GetObject("lblBullet1.Size"), System.Drawing.Size)
        Me.lblBullet1.TabIndex = CType(resources.GetObject("lblBullet1.TabIndex"), Integer)
        Me.lblBullet1.Text = resources.GetString("lblBullet1.Text")
        Me.lblBullet1.TextAlign = CType(resources.GetObject("lblBullet1.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBullet1.Visible = CType(resources.GetObject("lblBullet1.Visible"), Boolean)
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
        'Label2
        '
        Me.Label2.AccessibleDescription = CType(resources.GetObject("Label2.AccessibleDescription"), String)
        Me.Label2.AccessibleName = CType(resources.GetObject("Label2.AccessibleName"), String)
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.BackColor = System.Drawing.Color.Yellow
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
        'TreeView1
        '
        Me.TreeView1.AccessibleDescription = CType(resources.GetObject("TreeView1.AccessibleDescription"), String)
        Me.TreeView1.AccessibleName = CType(resources.GetObject("TreeView1.AccessibleName"), String)
        Me.TreeView1.Anchor = CType(resources.GetObject("TreeView1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackgroundImage = CType(resources.GetObject("TreeView1.BackgroundImage"), System.Drawing.Image)
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = CType(resources.GetObject("TreeView1.Dock"), System.Windows.Forms.DockStyle)
        Me.TreeView1.Enabled = CType(resources.GetObject("TreeView1.Enabled"), Boolean)
        Me.TreeView1.Font = CType(resources.GetObject("TreeView1.Font"), System.Drawing.Font)
        Me.TreeView1.ImageIndex = CType(resources.GetObject("TreeView1.ImageIndex"), Integer)
        Me.TreeView1.ImeMode = CType(resources.GetObject("TreeView1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TreeView1.Indent = CType(resources.GetObject("TreeView1.Indent"), Integer)
        Me.TreeView1.ItemHeight = CType(resources.GetObject("TreeView1.ItemHeight"), Integer)
        Me.TreeView1.Location = CType(resources.GetObject("TreeView1.Location"), System.Drawing.Point)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.PathSeparator = "~"
        Me.TreeView1.RightToLeft = CType(resources.GetObject("TreeView1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TreeView1.SelectedImageIndex = CType(resources.GetObject("TreeView1.SelectedImageIndex"), Integer)
        Me.TreeView1.Size = CType(resources.GetObject("TreeView1.Size"), System.Drawing.Size)
        Me.TreeView1.TabIndex = CType(resources.GetObject("TreeView1.TabIndex"), Integer)
        Me.TreeView1.Text = resources.GetString("TreeView1.Text")
        Me.TreeView1.Visible = CType(resources.GetObject("TreeView1.Visible"), Boolean)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AccessibleDescription = CType(resources.GetObject("RichTextBox1.AccessibleDescription"), String)
        Me.RichTextBox1.AccessibleName = CType(resources.GetObject("RichTextBox1.AccessibleName"), String)
        Me.RichTextBox1.Anchor = CType(resources.GetObject("RichTextBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.AutoSize = CType(resources.GetObject("RichTextBox1.AutoSize"), Boolean)
        Me.RichTextBox1.BackgroundImage = CType(resources.GetObject("RichTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.RichTextBox1.BulletIndent = CType(resources.GetObject("RichTextBox1.BulletIndent"), Integer)
        Me.RichTextBox1.Dock = CType(resources.GetObject("RichTextBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.RichTextBox1.Enabled = CType(resources.GetObject("RichTextBox1.Enabled"), Boolean)
        Me.RichTextBox1.Font = CType(resources.GetObject("RichTextBox1.Font"), System.Drawing.Font)
        Me.RichTextBox1.ImeMode = CType(resources.GetObject("RichTextBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.RichTextBox1.Location = CType(resources.GetObject("RichTextBox1.Location"), System.Drawing.Point)
        Me.RichTextBox1.MaxLength = CType(resources.GetObject("RichTextBox1.MaxLength"), Integer)
        Me.RichTextBox1.Multiline = CType(resources.GetObject("RichTextBox1.Multiline"), Boolean)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RightMargin = CType(resources.GetObject("RichTextBox1.RightMargin"), Integer)
        Me.RichTextBox1.RightToLeft = CType(resources.GetObject("RichTextBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.RichTextBox1.ScrollBars = CType(resources.GetObject("RichTextBox1.ScrollBars"), System.Windows.Forms.RichTextBoxScrollBars)
        Me.RichTextBox1.Size = CType(resources.GetObject("RichTextBox1.Size"), System.Drawing.Size)
        Me.RichTextBox1.TabIndex = CType(resources.GetObject("RichTextBox1.TabIndex"), Integer)
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.Visible = CType(resources.GetObject("RichTextBox1.Visible"), Boolean)
        Me.RichTextBox1.WordWrap = CType(resources.GetObject("RichTextBox1.WordWrap"), Boolean)
        Me.RichTextBox1.ZoomFactor = CType(resources.GetObject("RichTextBox1.ZoomFactor"), Single)
        '
        'btnCode
        '
        Me.btnCode.AccessibleDescription = CType(resources.GetObject("btnCode.AccessibleDescription"), String)
        Me.btnCode.AccessibleName = CType(resources.GetObject("btnCode.AccessibleName"), String)
        Me.btnCode.Anchor = CType(resources.GetObject("btnCode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCode.BackColor = System.Drawing.SystemColors.Control
        Me.btnCode.BackgroundImage = CType(resources.GetObject("btnCode.BackgroundImage"), System.Drawing.Image)
        Me.btnCode.Dock = CType(resources.GetObject("btnCode.Dock"), System.Windows.Forms.DockStyle)
        Me.btnCode.Enabled = CType(resources.GetObject("btnCode.Enabled"), Boolean)
        Me.btnCode.FlatStyle = CType(resources.GetObject("btnCode.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnCode.Font = CType(resources.GetObject("btnCode.Font"), System.Drawing.Font)
        Me.btnCode.Image = CType(resources.GetObject("btnCode.Image"), System.Drawing.Image)
        Me.btnCode.ImageAlign = CType(resources.GetObject("btnCode.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnCode.ImageIndex = CType(resources.GetObject("btnCode.ImageIndex"), Integer)
        Me.btnCode.ImeMode = CType(resources.GetObject("btnCode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnCode.Location = CType(resources.GetObject("btnCode.Location"), System.Drawing.Point)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.RightToLeft = CType(resources.GetObject("btnCode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnCode.Size = CType(resources.GetObject("btnCode.Size"), System.Drawing.Size)
        Me.btnCode.TabIndex = CType(resources.GetObject("btnCode.TabIndex"), Integer)
        Me.btnCode.Text = resources.GetString("btnCode.Text")
        Me.btnCode.TextAlign = CType(resources.GetObject("btnCode.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnCode.Visible = CType(resources.GetObject("btnCode.Visible"), Boolean)
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = resources.GetString("SaveFileDialog1.Title")
        '
        'Timer1
        '
        Me.Timer1.Interval = 7000
        '
        'frmRemind
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
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmRemind"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim mbooShowRTFHelp As Boolean = True
    Dim mstrIndexArray() As TreeTopics
    Dim LastKeypresses As String 
    Friend Property ShowRTFHelp() As Boolean
        Get

            Return mbooShowRTFHelp
        End Get
        Set(ByVal Value As Boolean)
            mbooShowRTFHelp = Value
        End Set
    End Property

    Private Sub Remind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = Label1.Text.Replace("[Program]", gProgName) 
        lblBullet1.Text = lblBullet1.Text.Replace("[Program]", gProgName) 
        lblBullet2.Text = lblBullet2.Text.Replace("[Program]", gProgName) 
        lblBullet3.Text = lblBullet3.Text.Replace("[Program]", gProgName) 
        lblBullet4.Text = lblBullet4.Text.Replace("[Program]", gProgName) 

        
        ''If IsAboveOrEqualWinXp() = True Then  
        'White buttons on white enabled and unenabled can't be distinguished 
        btnHelp.FlatStyle = FlatStyle.System
        btnRemindLater.FlatStyle = FlatStyle.System
        btnCode.FlatStyle = FlatStyle.System
        ''End If 
        

        SetBackcolors() 

        Me.Text = NameMe("")

        If mbooShowRTFHelp = True Then
            btnHelp.Visible = True
        Else

            btnCode.Left = 128 
            btnRemindLater.Left = 264 
        End If

        Dim Res As New IPIconsPack.Resource()

        lblBullet1.Image = Res.ilTreeIcons.Images.Item(7)
        lblBullet2.Image = Res.ilTreeIcons.Images.Item(7)
        lblBullet3.Image = Res.ilTreeIcons.Images.Item(7)
        lblBullet4.Image = Res.ilTreeIcons.Images.Item(7)

        picMCLLogo.Image = Res.picMCLLogo.Image

        '--- 
        PictureBox8.Visible = False
        picMCLLogo.Left = 56
        picMCLLogo.Top = 80
        PictureBox1.Left = PictureBox2.Left
        PictureBox2.Left = PictureBox3.Left
        PictureBox7.Left = PictureBox6.Left
        PictureBox6.Left = PictureBox5.Left
        PictureBox3.Visible = False 'discovery
        PictureBox5.Visible = False ' echeck
        '--- 

        
        Try
            Dim RemindTime As New Label()
            With RemindTime
                .Top = (btnCode.Top - .Height) - 7
                Dim DaysRemain As Integer = 30 - CInt(GetSetting("Remain", "0", InitalXMLConfig.XmlConfigType.AppSettings, ""))
                
                If DaysRemain < 0 Then
                    DaysRemain = 0
                End If
                
                .Text = LangText.GetString("Remind_RemainLabel").Replace("[DAYS]", DaysRemain)
                .BackColor = Panel1.BackColor
                Panel1.Controls.AddRange(New System.Windows.Forms.Control() {RemindTime})
                .Left = 0
                .Width = Panel1.Width
                .TextAlign = ContentAlignment.MiddleCenter
                .Visible = True
                .BringToFront()
            End With
        Catch

        End Try
        
        btnRemindLater.Enabled = True 

        Try : btnCode.Text = btnCode.Text.Replace("&", "") : Catch : End Try 
        Try : btnHelp.Text = btnHelp.Text.Replace("&", "") : Catch : End Try 
        Try : btnRemindLater.Text = btnRemindLater.Text.Replace("&", "") : Catch : End Try 
        Me.KeyPreview = True 


    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        System.Windows.Forms.Application.DoEvents() 

        Dim lintDialogRes As DialogResult
        'lintDialogRes = MxessageBox.Show( _
        '    "As matter of 'Good Will' to customers who may have vital or important information held within " & Environment.NewLine & _
        '    "the program, you may use the 'Save to File' feature.  This feature will allow you to have your " & Environment.NewLine & _
        '    "information put into an RTF (Rich Text Format) document file.  This can then be open in a " & Environment.NewLine & _
        '    "word processing package. e.g. Wordpad." & Environment.NewLine & Environment.NewLine & _
        '    "If you wish to proceed click YES.", NameMe(""), MessageBoxButtons.YesNo)
        If gbooAlwaysOnTop = True Then Me.Activate() 
        
        lintDialogRes = MessageBox.Show(LangText.GetString("Remind_Goodwill").Replace("[CR]", _
                Environment.NewLine).Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

        System.Windows.Forms.Application.DoEvents() 

        If lintDialogRes = DialogResult.Yes Then

            Busy(Me, True)
            PopulateTree(TreeView1, mstrIndexArray, Me, True)

            Dim lintArrInc As Integer
            Dim lstrNodePath As String

            Busy(Me, True)

            RichTextBox1.SelectedRtf = ""
            RichTextBox1.Rtf = ""

            Dim n As TreeNode
            For Each n In TreeView1.Nodes
                BuildRTFPrint(RichTextBox1, n, True)
                Dim aNode As TreeNode
                For Each aNode In n.Nodes
                    BuildRTFPrint(RichTextBox1, aNode, True)
                Next aNode
            Next n
            Busy(Me, False)

            Dim lstrFileName As String 

            With SaveFileDialog1
                .CheckPathExists = True
                .AddExtension = True
                .DefaultExt = "rtf"
                .RestoreDirectory = True 
                '.FileName = "Project"
                
                .FileName = LangText.GetString("Remind_SaveFile")

                '.Filter = "Rich text file| *.rtf"
                
                .Filter = LangText.GetString("Remind_SaveFilter")

                .ShowDialog()
                If SaveFileDialog1.FileName <> "" Then
                    lstrFileName = .FileName
                    Try
                        If RightGet(lstrFileName.ToUpper, 4) <> ".RTF" Then
                            lstrFileName &= ".rtf"
                        End If
                    Catch
                        '
                    End Try
                    RichTextBox1.SaveFile(lstrFileName)
                End If

                'mxessagebox.show("File Created!", NameMe(""))
                
                '---
                Try
                    Busy(Me, True) 
                    OutputTemplateData(lstrFileName)
                Catch
                    '
                Finally 
                    Busy(Me, False) 
                End Try
                '---
            End With

            If gbooAlwaysOnTop = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("Remind_SaveCreated"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

        End If

    End Sub

    Private Sub btnRemindLater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemindLater.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btnRemindLater.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub btnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCode.Click

        System.Windows.Forms.Application.DoEvents() 

        If AcceptLicense(Me) = True Then 
            Application.DoEvents() 
            DeleteTempFiles() 
            Me.Close() 
        End If
        System.Windows.Forms.Application.DoEvents() 

        DeleteTempFiles() 

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        'Bxsy(Me, True)
        'Try 
        '    Dim psInfo As New System.Diagnostics.ProcessStartInfo("IEXPLORE", LangText.GetString("Remind_BuyURL")) '"http://www.example.com/buy-products.html")
        '    psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        '    psInfo.CreateNoWindow = True
        '    Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        'Catch 
        '    Dim psInfo As New System.Diagnostics.ProcessStartInfo(LangText.GetString("Remind_BuyURL")) '"http://www.example.com/buy-products.html")
        '    psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        '    psInfo.CreateNoWindow = True
        '    Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        'End Try 
        'Bxsy(Me, False)

        BrowseToUrl(LangText.GetString("Remind_BuyURL"), Me) 
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message) 


        Const WM_SYSCOMMAND As Int32 = &H112
        Const SC_CLOSE As Int32 = &HF060

        'controlla se   stato scelto il menu della finestra per chiuderla (X o Alt-F4)
        If ((m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32 = SC_CLOSE)) Then
            's ; minimizza la finestra: il programma puessere chiuso tramite menu
            'Me.WindowState = FormWindowState.Minimized
        Else
            'passa il messaggio alla classe di base
            MyBase.WndProc(m)
        End If

    End Sub
    Private Sub OutputTemplateData(ByVal pstrOutputFile As String)
        'created
        Dim lstrUsedTemplatesIDs() As String
        Dim lstrTemplateFileName() As String
        Dim lstrTemplateResources() As IPTemplates._main.resources

        Dim lstTemplates As New ListBox()

        Me.SuspendLayout() 
        Dim TR As New IPTemplates._main()
        TR.HTMLForms(lstrTemplateResources)
        FillTemplatesUsedList(lstrUsedTemplatesIDs, lstrTemplateFileName, lstrTemplateResources, lstTemplates)

        
        If lstrTemplateFileName Is Nothing Then
            Exit Sub
        End If
        If lstrTemplateFileName.GetUpperBound(0) = 0 And lstrTemplateFileName(0) = "" Then
            Exit Sub
        End If
        

        Me.ResumeLayout() 

        Try
            pstrOutputFile = pstrOutputFile.Replace(".rtf", "")
        Catch
            '
        End Try


        Dim AxWebBrowser As WinOnly.WebOCHostCtrl

        SpawnBrowserObject(AxWebBrowser, Me)

        Dim lintArrInc As Integer
        For lintArrInc = 0 To lstrTemplateFileName.GetUpperBound(0)
            Dim lstrFields() As String
            Dim lbooDLL As Boolean = False
            Dim lstrFileName As String = lstrTemplateFileName(lintArrInc)
            If lstrFileName <> "" Then 
                If InStrGet(lstrFileName, "SYSTEM:") > 0 Then
                    lstrFileName = Microsoft.VisualBasic.Replace(lstrFileName, "SYSTEM:", "")
                    lbooDLL = True
                End If
                ShowForm(lstrFileName, AxWebBrowser, lbooDLL)

                WaitForBrowser(AxWebBrowser)

                Dim HtmlDoc As IHTMLDocument2 = CType(AxWebBrowser.HtmlDocument, IHTMLDocument2)
                Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

                Dim iForms As Integer = FormCol.length
                Dim i As Integer = 0
                Dim x As Integer = 0
                Dim lintFieldCounter As Integer = 0

                For i = 0 To iForms - 1
                    Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
                    For x = 0 To oForm.length - 1
                        If CStr(oForm.elements(x).name).ToUpper <> "TemplateID".ToUpper Then
                            ReDim Preserve lstrFields(lintFieldCounter)
                            lstrFields(lintFieldCounter) = oForm.elements(x).name
                            lintFieldCounter += 1
                        End If
                    Next
                Next i

                Dim lstrOutPutFilename As String = pstrOutputFile & lintArrInc & ".txt"
                Try
                    lstrOutPutFilename = pstrOutputFile & lstrFileName.Replace(".html", "") & lintArrInc & ".txt"
                    lstrOutPutFilename = pstrOutputFile & lstrFileName.Replace(".HTML", "") & lintArrInc & ".txt"
                Catch
                    '
                End Try
                GenerateDataFile(lstrOutPutFilename, lstrUsedTemplatesIDs(lintArrInc), lstrFields, Nothing, TemplateDataTypes.TemplateOutput.TabbedDelim) 'added tabbed 
            End If
        Next lintArrInc

    End Sub

    Private Sub SetBackcolors()

        'Added 
        btnRemindLater.BackColor = Color.FromArgb(0, btnRemindLater.BackColor)
        btnCode.BackColor = Color.FromArgb(0, btnCode.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub


    Private Sub frmRemind_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub


    Private Sub frmRemind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        
        LastKeypresses &= e.KeyChar

        If LastKeypresses.ToUpper = "HELP" Then

            Application.DoEvents()

            Dim ErrRep As New ProbHand.BugReport(gbooAlwaysOnTop)
            With ErrRep

                AddDebugComment("<Font color=Blue>Remind Help</font>")
                DebugDBComment()
                Application.DoEvents()
                .Caption = NameMe("")
                .SysStartTime = gdatSystemStart

                .FormIcon = New System.Drawing.Icon( _
                    System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                .TopMost = gbooAlwaysOnTop 
                .ShowDialog()

            End With

        End If
        If Microsoft.VisualBasic.Len(LastKeypresses) > 3 Then
            LastKeypresses = Microsoft.VisualBasic.Right(LastKeypresses, 3)
        End If
        

    End Sub
End Class