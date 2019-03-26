Public Class AcceptReg
    Inherits System.Windows.Forms.Form
    Dim mstrProductName As String

    Dim mstrCaption As String

    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.GetExecutingAssembly()) 

    Public WriteOnly Property ProdName() As String
        Set(ByVal Value As String)

            mstrProductName = Value
        End Set
    End Property
    Public WriteOnly Property Caption() As String
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property
    Public Property LicenseCode() As String
        Get
            Return txtRegCode.Text
        End Get
        Set(ByVal Value As String)

            'mstrLicenseCode = Value
        End Set
    End Property
#Region " Windows Form Designer generated code "

    Public Sub New()
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
    Friend WithEvents lblRegisterInstructions As System.Windows.Forms.Label
    Friend WithEvents txtRegCode As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AcceptReg))
        Me.lblRegisterInstructions = New System.Windows.Forms.Label()
        Me.txtRegCode = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRegisterInstructions
        '
        Me.lblRegisterInstructions.AccessibleDescription = CType(resources.GetObject("lblRegisterInstructions.AccessibleDescription"), String)
        Me.lblRegisterInstructions.AccessibleName = CType(resources.GetObject("lblRegisterInstructions.AccessibleName"), String)
        Me.lblRegisterInstructions.Anchor = CType(resources.GetObject("lblRegisterInstructions.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblRegisterInstructions.AutoSize = CType(resources.GetObject("lblRegisterInstructions.AutoSize"), Boolean)
        Me.lblRegisterInstructions.Dock = CType(resources.GetObject("lblRegisterInstructions.Dock"), System.Windows.Forms.DockStyle)
        Me.lblRegisterInstructions.Enabled = CType(resources.GetObject("lblRegisterInstructions.Enabled"), Boolean)
        Me.lblRegisterInstructions.Font = CType(resources.GetObject("lblRegisterInstructions.Font"), System.Drawing.Font)
        Me.lblRegisterInstructions.Image = CType(resources.GetObject("lblRegisterInstructions.Image"), System.Drawing.Image)
        Me.lblRegisterInstructions.ImageAlign = CType(resources.GetObject("lblRegisterInstructions.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblRegisterInstructions.ImageIndex = CType(resources.GetObject("lblRegisterInstructions.ImageIndex"), Integer)
        Me.lblRegisterInstructions.ImeMode = CType(resources.GetObject("lblRegisterInstructions.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblRegisterInstructions.Location = CType(resources.GetObject("lblRegisterInstructions.Location"), System.Drawing.Point)
        Me.lblRegisterInstructions.Name = "lblRegisterInstructions"
        Me.lblRegisterInstructions.RightToLeft = CType(resources.GetObject("lblRegisterInstructions.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblRegisterInstructions.Size = CType(resources.GetObject("lblRegisterInstructions.Size"), System.Drawing.Size)
        Me.lblRegisterInstructions.TabIndex = CType(resources.GetObject("lblRegisterInstructions.TabIndex"), Integer)
        Me.lblRegisterInstructions.Text = resources.GetString("lblRegisterInstructions.Text")
        Me.lblRegisterInstructions.TextAlign = CType(resources.GetObject("lblRegisterInstructions.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblRegisterInstructions.Visible = CType(resources.GetObject("lblRegisterInstructions.Visible"), Boolean)
        '
        'txtRegCode
        '
        Me.txtRegCode.AccessibleDescription = CType(resources.GetObject("txtRegCode.AccessibleDescription"), String)
        Me.txtRegCode.AccessibleName = CType(resources.GetObject("txtRegCode.AccessibleName"), String)
        Me.txtRegCode.Anchor = CType(resources.GetObject("txtRegCode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtRegCode.AutoSize = CType(resources.GetObject("txtRegCode.AutoSize"), Boolean)
        Me.txtRegCode.BackgroundImage = CType(resources.GetObject("txtRegCode.BackgroundImage"), System.Drawing.Image)
        Me.txtRegCode.Dock = CType(resources.GetObject("txtRegCode.Dock"), System.Windows.Forms.DockStyle)
        Me.txtRegCode.Enabled = CType(resources.GetObject("txtRegCode.Enabled"), Boolean)
        Me.txtRegCode.Font = CType(resources.GetObject("txtRegCode.Font"), System.Drawing.Font)
        Me.txtRegCode.ImeMode = CType(resources.GetObject("txtRegCode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtRegCode.Location = CType(resources.GetObject("txtRegCode.Location"), System.Drawing.Point)
        Me.txtRegCode.MaxLength = CType(resources.GetObject("txtRegCode.MaxLength"), Integer)
        Me.txtRegCode.Multiline = CType(resources.GetObject("txtRegCode.Multiline"), Boolean)
        Me.txtRegCode.Name = "txtRegCode"
        Me.txtRegCode.PasswordChar = CType(resources.GetObject("txtRegCode.PasswordChar"), Char)
        Me.txtRegCode.RightToLeft = CType(resources.GetObject("txtRegCode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtRegCode.ScrollBars = CType(resources.GetObject("txtRegCode.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtRegCode.Size = CType(resources.GetObject("txtRegCode.Size"), System.Drawing.Size)
        Me.txtRegCode.TabIndex = CType(resources.GetObject("txtRegCode.TabIndex"), Integer)
        Me.txtRegCode.Text = resources.GetString("txtRegCode.Text")
        Me.txtRegCode.TextAlign = CType(resources.GetObject("txtRegCode.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtRegCode.Visible = CType(resources.GetObject("txtRegCode.Visible"), Boolean)
        Me.txtRegCode.WordWrap = CType(resources.GetObject("txtRegCode.WordWrap"), Boolean)
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
        'AcceptReg
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnOK, Me.txtRegCode, Me.lblRegisterInstructions})
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
        Me.Name = "AcceptReg"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub AcceptReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        Me.Text = mstrCaption
        'lblRegisterInstructions.Text = "To unlock " & mstrProductName & _
        '", paste the license section you received, when you purchased the product, into the box below (using Ctrl+V) and then click OK!"

        lblRegisterInstructions.Text = LangText.GetString("AcceptReg_Instructions").Replace("[ProdName]", mstrProductName) 

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        If txtRegCode.Text = "" Then
            Exit Sub
        End If


        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Sub SetBackcolors()

        'Added 
        lblRegisterInstructions.BackColor = Color.FromArgb(0, lblRegisterInstructions.BackColor)
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub AcceptReg_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
