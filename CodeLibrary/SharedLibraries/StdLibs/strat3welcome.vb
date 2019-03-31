Imports System.Diagnostics.FileVersionInfo
Friend Class strat3welcome
    Inherits System.Windows.Forms.Form
    Dim mbooExpired As Boolean
    Property Expired() As Boolean
        Get
            Return mbooExpired
        End Get
        Set(ByVal Value As Boolean)
            mbooExpired = Value
        End Set
    End Property
    Dim mstrTitle As String
    Property Title() As String
        Get
            Return mstrTitle
        End Get
        Set(ByVal Value As String)
            mstrTitle = Value
        End Set
    End Property
    Dim mstrBullet1 As String
    Property Bullet1() As String
        Get
            Return mstrBullet1
        End Get
        Set(ByVal Value As String)
            mstrBullet1 = Value
        End Set
    End Property
    Dim mstrBullet2 As String
    Property Bullet2() As String
        Get
            Return mstrBullet2
        End Get
        Set(ByVal Value As String)
            mstrBullet2 = Value
        End Set
    End Property
    Dim mstrBullet3 As String
    Property Bullet3() As String
        Get
            Return mstrBullet3
        End Get
        Set(ByVal Value As String)
            mstrBullet3 = Value
        End Set
    End Property
    Dim mstrBullet4 As String
    Property Bullet4() As String
        Get
            Return mstrBullet4
        End Get
        Set(ByVal Value As String)
            mstrBullet4 = Value
        End Set
    End Property
    Dim mstrBuyNowURL As String
    Property BuyNowURL() As String
        Get
            Return mstrBuyNowURL
        End Get
        Set(ByVal Value As String)
            mstrBuyNowURL = Value
        End Set
    End Property
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
    Friend WithEvents lblSentence1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl10Secs As System.Windows.Forms.Label
    Friend WithEvents picMCLLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuyNow As System.Windows.Forms.Button
    Friend WithEvents btnCode As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBullet4 As System.Windows.Forms.Label
    Friend WithEvents lblBullet1 As System.Windows.Forms.Label
    Friend WithEvents lblBullet2 As System.Windows.Forms.Label
    Friend WithEvents ilTreeIcons As System.Windows.Forms.ImageList
    Friend WithEvents lblBullet5 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(strat3welcome))
        Me.lblSentence1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl10Secs = New System.Windows.Forms.Label
        Me.picMCLLogo = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblBullet5 = New System.Windows.Forms.Label
        Me.btnCode = New System.Windows.Forms.Button
        Me.btnBuyNow = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.lblBullet4 = New System.Windows.Forms.Label
        Me.lblBullet1 = New System.Windows.Forms.Label
        Me.lblBullet2 = New System.Windows.Forms.Label
        Me.ilTreeIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSentence1
        '
        Me.lblSentence1.Location = New System.Drawing.Point(64, 304)
        Me.lblSentence1.Name = "lblSentence1"
        Me.lblSentence1.Size = New System.Drawing.Size(392, 23)
        Me.lblSentence1.TabIndex = 1
        Me.lblSentence1.Text = "Label2"
        Me.lblSentence1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(432, 248)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'lbl10Secs
        '
        Me.lbl10Secs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl10Secs.Location = New System.Drawing.Point(344, 248)
        Me.lbl10Secs.Name = "lbl10Secs"
        Me.lbl10Secs.Size = New System.Drawing.Size(72, 23)
        Me.lbl10Secs.TabIndex = 6
        Me.lbl10Secs.Text = "10 seconds"
        Me.lbl10Secs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picMCLLogo
        '
        Me.picMCLLogo.Location = New System.Drawing.Point(432, 40)
        Me.picMCLLogo.Name = "picMCLLogo"
        Me.picMCLLogo.Size = New System.Drawing.Size(64, 64)
        Me.picMCLLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMCLLogo.TabIndex = 7
        Me.picMCLLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblBullet5, Me.btnCode, Me.picMCLLogo, Me.btnOK, Me.lbl10Secs, Me.btnBuyNow, Me.lblTitle, Me.PictureBox4, Me.PictureBox2, Me.PictureBox1, Me.Label6, Me.PictureBox3, Me.PictureBox7, Me.PictureBox6, Me.PictureBox5, Me.Label3, Me.PictureBox8, Me.lblBullet4, Me.lblBullet1, Me.lblBullet2, Me.lblSentence1})
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 336)
        Me.Panel1.TabIndex = 8
        '
        'lblBullet5
        '
        Me.lblBullet5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBullet5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBullet5.Location = New System.Drawing.Point(136, 112)
        Me.lblBullet5.Name = "lblBullet5"
        Me.lblBullet5.Size = New System.Drawing.Size(246, 23)
        Me.lblBullet5.TabIndex = 33
        Me.lblBullet5.Text = "       Free email support"
        Me.lblBullet5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCode
        '
        Me.btnCode.BackColor = System.Drawing.SystemColors.Control
        Me.btnCode.Location = New System.Drawing.Point(112, 248)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(128, 23)
        Me.btnCode.TabIndex = 11
        Me.btnCode.Text = "&Enter License Code"
        '
        'btnBuyNow
        '
        Me.btnBuyNow.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuyNow.Location = New System.Drawing.Point(24, 248)
        Me.btnBuyNow.Name = "btnBuyNow"
        Me.btnBuyNow.TabIndex = 0
        Me.btnBuyNow.Text = "&Buy Now"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(504, 23)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Take a minute to understand what MDBSecure can do for you!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Bitmap)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(256, 144)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(160, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(112, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "See our order page for today's special price!"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Bitmap)
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(208, 144)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Bitmap)
        Me.PictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox7.Location = New System.Drawing.Point(392, 144)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(39, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 31
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Bitmap)
        Me.PictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox6.Location = New System.Drawing.Point(344, 144)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(39, 26)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Bitmap)
        Me.PictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox5.Location = New System.Drawing.Point(296, 144)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(32, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(448, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Unconditional 30 day money back guarantee !"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Bitmap)
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(24, 56)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(88, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 32
        Me.PictureBox8.TabStop = False
        '
        'lblBullet4
        '
        Me.lblBullet4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBullet4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBullet4.Location = New System.Drawing.Point(136, 88)
        Me.lblBullet4.Name = "lblBullet4"
        Me.lblBullet4.Size = New System.Drawing.Size(246, 23)
        Me.lblBullet4.TabIndex = 21
        Me.lblBullet4.Text = "       Caters for creativity and future change"
        Me.lblBullet4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBullet1
        '
        Me.lblBullet1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBullet1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBullet1.Location = New System.Drawing.Point(136, 40)
        Me.lblBullet1.Name = "lblBullet1"
        Me.lblBullet1.Size = New System.Drawing.Size(288, 23)
        Me.lblBullet1.TabIndex = 18
        Me.lblBullet1.Text = "       Takes the pain out of securing your databases"
        Me.lblBullet1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBullet2
        '
        Me.lblBullet2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBullet2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBullet2.Location = New System.Drawing.Point(136, 64)
        Me.lblBullet2.Name = "lblBullet2"
        Me.lblBullet2.Size = New System.Drawing.Size(232, 23)
        Me.lblBullet2.TabIndex = 19
        Me.lblBullet2.Text = "       Easy to use, step-by-step help included!"
        Me.lblBullet2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ilTreeIcons
        '
        Me.ilTreeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ilTreeIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilTreeIcons.ImageStream = CType(resources.GetObject("ilTreeIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTreeIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'strat3welcome
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(554, 376)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "strat3welcome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "strat3welcome"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub strat3welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddDebugComment("strat3welcome.strat3welcome_Load - start")

        Dim Res As New IPIconsPack.Resource
        picMCLLogo.Image = Res.picMCLLogo.Image

        Me.Text = NameMe("Evaluation Notice")

        If mbooExpired = False Then
            Dim DaysRemain As Integer = 30
            Try : DaysRemain = 30 - CInt(GetSetting("Remain", "0", InitalXMLConfig.XmlConfigType.AppSettings, "")) : Catch : End Try
            If DaysRemain < 0 Then
                DaysRemain = 0
            End If
            lblSentence1.Text = "You may use this version of the program for " & DaysRemain & " days."
        Else
            lblSentence1.Text = "Your evaluation period has expired!"
            lblSentence1.BackColor = Color.Red
            lblSentence1.ForeColor = Color.Yellow
            lblSentence1.Font = New Font(lblSentence1.Font.FontFamily, 12, FontStyle.Bold)
        End If

        lblBullet1.Image = ilTreeIcons.Images.Item(0)
        lblBullet2.Image = ilTreeIcons.Images.Item(0)
        lblBullet4.Image = ilTreeIcons.Images.Item(0)
        lblBullet5.Image = ilTreeIcons.Images.Item(0)

        lblTitle.Text = mstrTitle
        lblBullet1.Text = mstrBullet1
        lblBullet2.Text = mstrBullet2
        lblBullet4.Text = mstrBullet3
        lblBullet5.Text = mstrBullet4

        PictureBox8.Visible = False
        picMCLLogo.Left = 56 - 20
        picMCLLogo.Top = 60
        PictureBox1.Left = PictureBox2.Left
        PictureBox2.Left = PictureBox3.Left
        PictureBox7.Left = PictureBox6.Left
        PictureBox6.Left = PictureBox5.Left
        PictureBox3.Visible = False 'discovery
        PictureBox5.Visible = False ' echeck

        btnOK.FlatStyle = FlatStyle.System
        btnBuyNow.FlatStyle = FlatStyle.System
        btnCode.FlatStyle = FlatStyle.System

        SetBackcolors()

        AddDebugComment("strat3welcome.strat3welcome_Load - End")

    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        AddDebugComment("strat3welcome.btnOK_Click")
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btnOK.Enabled = True
        Timer1.Enabled = False
        lbl10Secs.Visible = False
    End Sub
    Private Sub lnkURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        AddDebugComment("strat3welcome.lnkURL_LinkClicked")
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub btnBuyNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuyNow.Click
        AddDebugComment("strat3welcome.btnBuyNow_Click")
        BrowseToUrl(mstrBuyNowURL, Me)

    End Sub
    Private Sub btnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCode.Click
        AddDebugComment("strat3welcome.btnCode_Click")
        If AcceptLicense(Me) = True Then
            StandardUpgradeTidy()
        End If
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Const WM_SYSCOMMAND As Int32 = &H112
        Const SC_CLOSE As Int32 = &HF060

        If ((m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32 = SC_CLOSE)) Then
            '
        Else
            MyBase.WndProc(m)
        End If

    End Sub
    Private Sub SetBackcolors()

        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCode.BackColor = Color.FromArgb(0, btnCode.BackColor)
        btnBuyNow.BackColor = Color.FromArgb(0, btnBuyNow.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub strat3welcome_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate()
    End Sub
End Class
