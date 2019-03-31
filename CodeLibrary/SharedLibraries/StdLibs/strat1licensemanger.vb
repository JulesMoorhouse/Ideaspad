
Friend Class frmLicenseManager
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnRevoke As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCode As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLicenseManager))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.AccessibleDescription = CType(resources.GetObject("ListBox1.AccessibleDescription"), String)
        Me.ListBox1.AccessibleName = CType(resources.GetObject("ListBox1.AccessibleName"), String)
        Me.ListBox1.Anchor = CType(resources.GetObject("ListBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackgroundImage = CType(resources.GetObject("ListBox1.BackgroundImage"), System.Drawing.Image)
        Me.ListBox1.ColumnWidth = CType(resources.GetObject("ListBox1.ColumnWidth"), Integer)
        Me.ListBox1.Dock = CType(resources.GetObject("ListBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox1.Enabled = CType(resources.GetObject("ListBox1.Enabled"), Boolean)
        Me.ListBox1.Font = CType(resources.GetObject("ListBox1.Font"), System.Drawing.Font)
        Me.ListBox1.HorizontalExtent = CType(resources.GetObject("ListBox1.HorizontalExtent"), Integer)
        Me.ListBox1.HorizontalScrollbar = CType(resources.GetObject("ListBox1.HorizontalScrollbar"), Boolean)
        Me.ListBox1.ImeMode = CType(resources.GetObject("ListBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox1.IntegralHeight = CType(resources.GetObject("ListBox1.IntegralHeight"), Boolean)
        Me.ListBox1.ItemHeight = CType(resources.GetObject("ListBox1.ItemHeight"), Integer)
        Me.ListBox1.Location = CType(resources.GetObject("ListBox1.Location"), System.Drawing.Point)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = CType(resources.GetObject("ListBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox1.ScrollAlwaysVisible = CType(resources.GetObject("ListBox1.ScrollAlwaysVisible"), Boolean)
        Me.ListBox1.Size = CType(resources.GetObject("ListBox1.Size"), System.Drawing.Size)
        Me.ListBox1.TabIndex = CType(resources.GetObject("ListBox1.TabIndex"), Integer)
        Me.ListBox1.Visible = CType(resources.GetObject("ListBox1.Visible"), Boolean)
        '
        'btnRevoke
        '
        Me.btnRevoke.AccessibleDescription = CType(resources.GetObject("btnRevoke.AccessibleDescription"), String)
        Me.btnRevoke.AccessibleName = CType(resources.GetObject("btnRevoke.AccessibleName"), String)
        Me.btnRevoke.Anchor = CType(resources.GetObject("btnRevoke.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnRevoke.BackgroundImage = CType(resources.GetObject("btnRevoke.BackgroundImage"), System.Drawing.Image)
        Me.btnRevoke.Dock = CType(resources.GetObject("btnRevoke.Dock"), System.Windows.Forms.DockStyle)
        Me.btnRevoke.Enabled = CType(resources.GetObject("btnRevoke.Enabled"), Boolean)
        Me.btnRevoke.FlatStyle = CType(resources.GetObject("btnRevoke.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnRevoke.Font = CType(resources.GetObject("btnRevoke.Font"), System.Drawing.Font)
        Me.btnRevoke.Image = CType(resources.GetObject("btnRevoke.Image"), System.Drawing.Image)
        Me.btnRevoke.ImageAlign = CType(resources.GetObject("btnRevoke.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnRevoke.ImageIndex = CType(resources.GetObject("btnRevoke.ImageIndex"), Integer)
        Me.btnRevoke.ImeMode = CType(resources.GetObject("btnRevoke.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnRevoke.Location = CType(resources.GetObject("btnRevoke.Location"), System.Drawing.Point)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.RightToLeft = CType(resources.GetObject("btnRevoke.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnRevoke.Size = CType(resources.GetObject("btnRevoke.Size"), System.Drawing.Size)
        Me.btnRevoke.TabIndex = CType(resources.GetObject("btnRevoke.TabIndex"), Integer)
        Me.btnRevoke.Text = resources.GetString("btnRevoke.Text")
        Me.btnRevoke.TextAlign = CType(resources.GetObject("btnRevoke.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnRevoke.Visible = CType(resources.GetObject("btnRevoke.Visible"), Boolean)
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
        'frmLicenseManager
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCode, Me.Label4, Me.Label3, Me.LinkLabel1, Me.btnCancel, Me.Label2, Me.Label1, Me.btnRevoke, Me.ListBox1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmLicenseManager"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mbooResult As DialogResult = DialogResult.Abort
    Friend Property Result() As DialogResult
        Get

            Return mbooResult
        End Get
        Set(ByVal Value As DialogResult)
            mbooResult = Value
        End Set
    End Property
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim lstrUserIDs(0) As String
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = Label1.Text.Replace("[Program]", gProgName) 
        Label4.Text = Label4.Text.Replace("[Program]", gProgName) 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnRevoke.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnCode.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        KeyPreview = True 
        LinkLabel1.Links.Clear() 
        LinkLabel1.Text = LangText.GetString("Remind_BuyURL") 
        LinkLabel1.Links.Add(0, LinkLabel1.Text.Length, LinkLabel1.Text) 

        PerformCheck()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = LangText.GetString("Strat1LM_btnProceed") Then
            mbooResult = DialogResult.OK
        Else
            mbooResult = DialogResult.Abort
        End If
        Me.Close()

    End Sub
    Private Sub btnRevoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevoke.Click

        If ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim lintDRes As DialogResult
        If gbooAlwaysOnTop = True Then Me.Activate() 
        lintDRes = MessageBox.Show(LangText.GetString("Strat1LM_RevokeWarning").Replace("[Program]", gProgName).Replace("[CR]", Environment.NewLine).Replace("[CR2]", Environment.NewLine & _
            Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props
        Application.DoEvents() 
        If lintDRes = DialogResult.Yes Then
            RevokeUser(lstrUserIDs(ListBox1.SelectedIndex))
            Dim msg As String = PerformCheck()
            If msg <> "" Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                MessageBox.Show(msg, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.None) 'other props
                If btnCancel.Text = LangText.GetString("Strat1LM_btnProceed") Then 
                    mbooResult = DialogResult.OK 
                    Me.Close() 
                End If
            End If

        End If

    End Sub
    Function PerformCheck() As String
        Select Case CheckLicense(ListBox1, lstrUserIDs)
            Case 3 'ok  
                'shouldn't happen if your on this screen
            Case 2 'exceeded
                Return LangText.GetString("Strat1LM_Exceed").Replace("[Program]", gProgName)
            Case 1 'added
                btnCancel.Text = LangText.GetString("Strat1LM_btnProceed")
                Return LangText.GetString("Strat1LM_Added").Replace("[Program]", gProgName)
        End Select
    End Function

    Private Sub btnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCode.Click

        If AcceptLicense(Me) = True Then 
            Me.Text = NameMe("") 
            StandardUpgradeTidy() 
            Me.Close() 
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '
        'Bxsy(Me, True)
        'Dim psInfo As New System.Diagnostics.ProcessStartInfo(LangText.GetString("Remind_BuyURL"))
        'psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        'psInfo.CreateNoWindow = True
        'Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        'Bxsy(Me, False)

        BrowseToUrl(LangText.GetString("Remind_BuyURL"), Me) 
    End Sub

    Private Sub frmLicenseManager_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnRevoke.BackColor = Color.FromArgb(0, btnRevoke.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        LinkLabel1.BackColor = Color.FromArgb(0, LinkLabel1.BackColor)
        btnCode.BackColor = Color.FromArgb(0, btnCode.BackColor)
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

    Private Sub frmLicenseManager_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class