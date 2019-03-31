Imports System.IO
Public Class TipOfTheDay
    Inherits System.Windows.Forms.Form

    Dim LangText As System.Resources.ResourceManager = New _
       System.Resources.ResourceManager("AppBasic.AppBasic", _
       System.Reflection.Assembly.GetExecutingAssembly()) 

    Dim mboolOverideStartup As Boolean = False
    Public Property OverideStartup() As Boolean
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mboolOverideStartup
        End Get
        Set(ByVal Value As Boolean)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mboolOverideStartup = Value
        End Set
    End Property
    Dim micoFormIcon As Icon
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
    Dim mintLastTipNum As Integer
    Public Property LastTipNum() As Integer
        Get
            Return mintLastTipNum
        End Get
        Set(ByVal Value As Integer)
            mintLastTipNum = Value
        End Set
    End Property
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnNextTip As System.Windows.Forms.Button
    Friend WithEvents lblTipText As System.Windows.Forms.RichTextBox ' System.Windows.Forms.Label
    Friend WithEvents chkLoadTipsAtStartup As System.Windows.Forms.CheckBox
    Dim lblBackDrop As System.Windows.Forms.Label
    Dim lblDidYouknow As System.Windows.Forms.Label
    Dim Tips As New Microsoft.VisualBasic.Collection()
    Dim CurrentTip As Long
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TipOfTheDay))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnNextTip = New System.Windows.Forms.Button()
        Me.lblTipText = New System.Windows.Forms.RichTextBox()
        Me.chkLoadTipsAtStartup = New System.Windows.Forms.CheckBox()
        Me.lblBackDrop = New System.Windows.Forms.Label()
        Me.lblDidYouknow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'btnNextTip
        '
        Me.btnNextTip.AccessibleDescription = CType(resources.GetObject("btnNextTip.AccessibleDescription"), String)
        Me.btnNextTip.AccessibleName = CType(resources.GetObject("btnNextTip.AccessibleName"), String)
        Me.btnNextTip.Anchor = CType(resources.GetObject("btnNextTip.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnNextTip.BackgroundImage = CType(resources.GetObject("btnNextTip.BackgroundImage"), System.Drawing.Image)
        Me.btnNextTip.Dock = CType(resources.GetObject("btnNextTip.Dock"), System.Windows.Forms.DockStyle)
        Me.btnNextTip.Enabled = CType(resources.GetObject("btnNextTip.Enabled"), Boolean)
        Me.btnNextTip.FlatStyle = CType(resources.GetObject("btnNextTip.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnNextTip.Font = CType(resources.GetObject("btnNextTip.Font"), System.Drawing.Font)
        Me.btnNextTip.Image = CType(resources.GetObject("btnNextTip.Image"), System.Drawing.Image)
        Me.btnNextTip.ImageAlign = CType(resources.GetObject("btnNextTip.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnNextTip.ImageIndex = CType(resources.GetObject("btnNextTip.ImageIndex"), Integer)
        Me.btnNextTip.ImeMode = CType(resources.GetObject("btnNextTip.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnNextTip.Location = CType(resources.GetObject("btnNextTip.Location"), System.Drawing.Point)
        Me.btnNextTip.Name = "btnNextTip"
        Me.btnNextTip.RightToLeft = CType(resources.GetObject("btnNextTip.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnNextTip.Size = CType(resources.GetObject("btnNextTip.Size"), System.Drawing.Size)
        Me.btnNextTip.TabIndex = CType(resources.GetObject("btnNextTip.TabIndex"), Integer)
        Me.btnNextTip.Text = resources.GetString("btnNextTip.Text")
        Me.btnNextTip.TextAlign = CType(resources.GetObject("btnNextTip.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnNextTip.Visible = CType(resources.GetObject("btnNextTip.Visible"), Boolean)
        '
        'lblTipText
        '
        Me.lblTipText.AccessibleDescription = CType(resources.GetObject("lblTipText.AccessibleDescription"), String)
        Me.lblTipText.AccessibleName = CType(resources.GetObject("lblTipText.AccessibleName"), String)
        Me.lblTipText.Anchor = CType(resources.GetObject("lblTipText.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTipText.AutoSize = CType(resources.GetObject("lblTipText.AutoSize"), Boolean)
        Me.lblTipText.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipText.BackgroundImage = CType(resources.GetObject("lblTipText.BackgroundImage"), System.Drawing.Image)
        Me.lblTipText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTipText.BulletIndent = CType(resources.GetObject("lblTipText.BulletIndent"), Integer)
        Me.lblTipText.Dock = CType(resources.GetObject("lblTipText.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTipText.Enabled = CType(resources.GetObject("lblTipText.Enabled"), Boolean)
        Me.lblTipText.Font = CType(resources.GetObject("lblTipText.Font"), System.Drawing.Font)
        Me.lblTipText.ImeMode = CType(resources.GetObject("lblTipText.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTipText.Location = CType(resources.GetObject("lblTipText.Location"), System.Drawing.Point)
        Me.lblTipText.MaxLength = CType(resources.GetObject("lblTipText.MaxLength"), Integer)
        Me.lblTipText.Multiline = CType(resources.GetObject("lblTipText.Multiline"), Boolean)
        Me.lblTipText.Name = "lblTipText"
        Me.lblTipText.ReadOnly = True
        Me.lblTipText.RightMargin = CType(resources.GetObject("lblTipText.RightMargin"), Integer)
        Me.lblTipText.RightToLeft = CType(resources.GetObject("lblTipText.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTipText.ScrollBars = CType(resources.GetObject("lblTipText.ScrollBars"), System.Windows.Forms.RichTextBoxScrollBars)
        Me.lblTipText.Size = CType(resources.GetObject("lblTipText.Size"), System.Drawing.Size)
        Me.lblTipText.TabIndex = CType(resources.GetObject("lblTipText.TabIndex"), Integer)
        Me.lblTipText.TabStop = False
        Me.lblTipText.Text = resources.GetString("lblTipText.Text")
        Me.lblTipText.Visible = CType(resources.GetObject("lblTipText.Visible"), Boolean)
        Me.lblTipText.WordWrap = CType(resources.GetObject("lblTipText.WordWrap"), Boolean)
        Me.lblTipText.ZoomFactor = CType(resources.GetObject("lblTipText.ZoomFactor"), Single)
        '
        'chkLoadTipsAtStartup
        '
        Me.chkLoadTipsAtStartup.AccessibleDescription = CType(resources.GetObject("chkLoadTipsAtStartup.AccessibleDescription"), String)
        Me.chkLoadTipsAtStartup.AccessibleName = CType(resources.GetObject("chkLoadTipsAtStartup.AccessibleName"), String)
        Me.chkLoadTipsAtStartup.Anchor = CType(resources.GetObject("chkLoadTipsAtStartup.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkLoadTipsAtStartup.Appearance = CType(resources.GetObject("chkLoadTipsAtStartup.Appearance"), System.Windows.Forms.Appearance)
        Me.chkLoadTipsAtStartup.BackgroundImage = CType(resources.GetObject("chkLoadTipsAtStartup.BackgroundImage"), System.Drawing.Image)
        Me.chkLoadTipsAtStartup.CheckAlign = CType(resources.GetObject("chkLoadTipsAtStartup.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkLoadTipsAtStartup.Dock = CType(resources.GetObject("chkLoadTipsAtStartup.Dock"), System.Windows.Forms.DockStyle)
        Me.chkLoadTipsAtStartup.Enabled = CType(resources.GetObject("chkLoadTipsAtStartup.Enabled"), Boolean)
        Me.chkLoadTipsAtStartup.FlatStyle = CType(resources.GetObject("chkLoadTipsAtStartup.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkLoadTipsAtStartup.Font = CType(resources.GetObject("chkLoadTipsAtStartup.Font"), System.Drawing.Font)
        Me.chkLoadTipsAtStartup.Image = CType(resources.GetObject("chkLoadTipsAtStartup.Image"), System.Drawing.Image)
        Me.chkLoadTipsAtStartup.ImageAlign = CType(resources.GetObject("chkLoadTipsAtStartup.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkLoadTipsAtStartup.ImageIndex = CType(resources.GetObject("chkLoadTipsAtStartup.ImageIndex"), Integer)
        Me.chkLoadTipsAtStartup.ImeMode = CType(resources.GetObject("chkLoadTipsAtStartup.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkLoadTipsAtStartup.Location = CType(resources.GetObject("chkLoadTipsAtStartup.Location"), System.Drawing.Point)
        Me.chkLoadTipsAtStartup.Name = "chkLoadTipsAtStartup"
        Me.chkLoadTipsAtStartup.RightToLeft = CType(resources.GetObject("chkLoadTipsAtStartup.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkLoadTipsAtStartup.Size = CType(resources.GetObject("chkLoadTipsAtStartup.Size"), System.Drawing.Size)
        Me.chkLoadTipsAtStartup.TabIndex = CType(resources.GetObject("chkLoadTipsAtStartup.TabIndex"), Integer)
        Me.chkLoadTipsAtStartup.Text = resources.GetString("chkLoadTipsAtStartup.Text")
        Me.chkLoadTipsAtStartup.TextAlign = CType(resources.GetObject("chkLoadTipsAtStartup.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkLoadTipsAtStartup.Visible = CType(resources.GetObject("chkLoadTipsAtStartup.Visible"), Boolean)
        '
        'lblBackDrop
        '
        Me.lblBackDrop.AccessibleDescription = CType(resources.GetObject("lblBackDrop.AccessibleDescription"), String)
        Me.lblBackDrop.AccessibleName = CType(resources.GetObject("lblBackDrop.AccessibleName"), String)
        Me.lblBackDrop.Anchor = CType(resources.GetObject("lblBackDrop.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblBackDrop.AutoSize = CType(resources.GetObject("lblBackDrop.AutoSize"), Boolean)
        Me.lblBackDrop.BackColor = System.Drawing.SystemColors.Window
        Me.lblBackDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackDrop.Dock = CType(resources.GetObject("lblBackDrop.Dock"), System.Windows.Forms.DockStyle)
        Me.lblBackDrop.Enabled = CType(resources.GetObject("lblBackDrop.Enabled"), Boolean)
        Me.lblBackDrop.Font = CType(resources.GetObject("lblBackDrop.Font"), System.Drawing.Font)
        Me.lblBackDrop.Image = CType(resources.GetObject("lblBackDrop.Image"), System.Drawing.Image)
        Me.lblBackDrop.ImageAlign = CType(resources.GetObject("lblBackDrop.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblBackDrop.ImageIndex = CType(resources.GetObject("lblBackDrop.ImageIndex"), Integer)
        Me.lblBackDrop.ImeMode = CType(resources.GetObject("lblBackDrop.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblBackDrop.Location = CType(resources.GetObject("lblBackDrop.Location"), System.Drawing.Point)
        Me.lblBackDrop.Name = "lblBackDrop"
        Me.lblBackDrop.RightToLeft = CType(resources.GetObject("lblBackDrop.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblBackDrop.Size = CType(resources.GetObject("lblBackDrop.Size"), System.Drawing.Size)
        Me.lblBackDrop.TabIndex = CType(resources.GetObject("lblBackDrop.TabIndex"), Integer)
        Me.lblBackDrop.Text = resources.GetString("lblBackDrop.Text")
        Me.lblBackDrop.TextAlign = CType(resources.GetObject("lblBackDrop.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblBackDrop.Visible = CType(resources.GetObject("lblBackDrop.Visible"), Boolean)
        '
        'lblDidYouknow
        '
        Me.lblDidYouknow.AccessibleDescription = CType(resources.GetObject("lblDidYouknow.AccessibleDescription"), String)
        Me.lblDidYouknow.AccessibleName = CType(resources.GetObject("lblDidYouknow.AccessibleName"), String)
        Me.lblDidYouknow.Anchor = CType(resources.GetObject("lblDidYouknow.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDidYouknow.AutoSize = CType(resources.GetObject("lblDidYouknow.AutoSize"), Boolean)
        Me.lblDidYouknow.BackColor = System.Drawing.SystemColors.Window
        Me.lblDidYouknow.Dock = CType(resources.GetObject("lblDidYouknow.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDidYouknow.Enabled = CType(resources.GetObject("lblDidYouknow.Enabled"), Boolean)
        Me.lblDidYouknow.Font = CType(resources.GetObject("lblDidYouknow.Font"), System.Drawing.Font)
        Me.lblDidYouknow.Image = CType(resources.GetObject("lblDidYouknow.Image"), System.Drawing.Image)
        Me.lblDidYouknow.ImageAlign = CType(resources.GetObject("lblDidYouknow.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDidYouknow.ImageIndex = CType(resources.GetObject("lblDidYouknow.ImageIndex"), Integer)
        Me.lblDidYouknow.ImeMode = CType(resources.GetObject("lblDidYouknow.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDidYouknow.Location = CType(resources.GetObject("lblDidYouknow.Location"), System.Drawing.Point)
        Me.lblDidYouknow.Name = "lblDidYouknow"
        Me.lblDidYouknow.RightToLeft = CType(resources.GetObject("lblDidYouknow.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDidYouknow.Size = CType(resources.GetObject("lblDidYouknow.Size"), System.Drawing.Size)
        Me.lblDidYouknow.TabIndex = CType(resources.GetObject("lblDidYouknow.TabIndex"), Integer)
        Me.lblDidYouknow.Text = resources.GetString("lblDidYouknow.Text")
        Me.lblDidYouknow.TextAlign = CType(resources.GetObject("lblDidYouknow.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDidYouknow.Visible = CType(resources.GetObject("lblDidYouknow.Visible"), Boolean)
        '
        'TipOfTheDay
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnOK, Me.btnNextTip, Me.lblTipText, Me.chkLoadTipsAtStartup, Me.lblDidYouknow, Me.lblBackDrop})
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
        Me.Name = "TipOfTheDay"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Sub Display()
        Dim ShowAtStartup As Boolean
        ' See if we should be shown at startup

        Me.Icon = micoFormIcon

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
            btnNextTip.FlatStyle = FlatStyle.System
        End If 
        chkLoadTipsAtStartup.FlatStyle = FlatStyle.System
        

        Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream(Me.GetType().Assembly.GetName.Name & ".tipbulb.png")
        Me.lblBackDrop.Image = System.Drawing.Image.FromStream(stream)

        ShowAtStartup = CBool(GetSetting("Show Tips at Startup", True, InitalXMLConfig.XmlConfigType.AppSettings, ""))
        If mboolOverideStartup = False Then
            If ShowAtStartup = False Then
                Me.Close()
                Exit Sub
            End If
        End If

        ' Set the checkbox, this will force the value to be written back out to the registry
        chkLoadTipsAtStartup.Checked = ShowAtStartup 'True

        Microsoft.VisualBasic.Randomize()

        If LoadTips() = False Then
            'lblTipText.Text = "That the tips file was not found! " '& vbCrLf & vbCrLf & _
            lblTipText.Text = LangText.GetString("Tips_FileNotFound") 
        End If

        'System.Windows.Forms.Application.DoEvents()
        Me.ShowDialog()

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        mintLastTipNum = CurrentTip
        Me.Close()
        'Me.Dispose()
    End Sub
    Private Sub btnNextTip_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNextTip.Click
        DoNextTip()
    End Sub
    Private Sub chkLoadTipsAtStartup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLoadTipsAtStartup.Click
        SaveSetting("Show Tips at Startup", chkLoadTipsAtStartup.Checked, InitalXMLConfig.XmlConfigType.AppSettings, "")
    End Sub
    Private Sub DisplayCurrentTip()
        If Tips.Count > 0 Then
            lblTipText.Text = Tips.Item(CurrentTip)
        End If
    End Sub
    Private Sub DoNextTip()
        'Dim LastTip As Long
        'Dim llngTryCount As Long
        'LastTip = CurrentTip
        ' Select a tip at random.
        'SelectRandTip:
        'CurrentTip = CInt((Tips.Count * Microsoft.VisualBasic.Rnd()) + 1)

        'If LastTip = CurrentTip And llngTryCount < 20 Then
        'llngTryCount += 1
        'GoTo SelectRandTip
        'End If
        ' Or, you could cycle through the Tips in order

        CurrentTip = CurrentTip + 1
        If Tips.Count < CurrentTip Then
            CurrentTip = 1
        End If

        ' Show it.
        DisplayCurrentTip()

    End Sub
    Private Function LoadTips() As Boolean
        Dim NextTip As String   ' Each tip read in from file.
        Dim InFile As Integer   ' Descriptor for file.
        'Dim lstrTipsFile As String = _
        '    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\TIPOFDAY.TXT"
        
        'Dim lstrTipsFile As String = _
        '    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\TIPOFDAY.TXT"

        
        Dim lstr2Chars As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToLower
        Dim lstrFileStr As String
        If lstr2Chars.ToUpper <> "EN" Then
            lstrFileStr = "\de\TIPOFDAY.de.TXT" 
        Else
            lstrFileStr = "\TIPOFDAY.TXT"
        End If
        Dim lstrTipsFile As String = _
            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & lstrFileStr
        

        ' Make sure the file exists before trying to open it.
        If File.Exists(lstrTipsFile) = False Then
            LoadTips = False
            Exit Function
        End If

        Dim OpenFile As FileStream = New FileStream(lstrTipsFile, FileMode.Open, FileAccess.Read, FileShare.Read)
        'Dim StreamReader As StreamReader = New StreamReader(OpenFile)
        
        Dim StreamReader As StreamReader = New StreamReader(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))

        Dim ThisTip As String = " "
        Do Until ThisTip = ""
            ThisTip = StreamReader.ReadLine
            If ThisTip <> "" Then
                Tips.Add(ThisTip)
            End If
        Loop
        StreamReader.Close()
        OpenFile.Close()

        ' Display a tip 
        CurrentTip = mintLastTipNum
        DoNextTip()


        LoadTips = True

    End Function
    Private Sub TipOfTheDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnOK_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub lblTipText_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles lblTipText.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub
    Private Sub TipOfTheDay_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mintLastTipNum = CurrentTip
    End Sub
    Sub SetBackcolors()

        'Added 
        btnNextTip.BackColor = Color.FromArgb(0, btnNextTip.BackColor)
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        chkLoadTipsAtStartup.BackColor = Color.FromArgb(0, chkLoadTipsAtStartup.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub TipOfTheDay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkLoadTipsAtStartup.FlatStyle = FlatStyle.Standard 
        SetBackcolors() 

    End Sub

    Private Sub TipOfTheDay_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class