Imports System
Imports System.IO
Imports System.Windows.Forms
Public Class frmCFU
    Inherits System.Windows.Forms.Form
    Dim lstrDowloadCompleteString As String
    Dim mstrCaption As String
    Dim mstrManifestSite() As ManifestInfo
    Dim micoFormIcon As Icon
    Dim lbooDoOnce As Boolean = False

    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim OverideVersionFlag As Boolean = False
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
    Sub strManifestSite(ByRef strManifestSite() As ManifestInfo)
        mstrManifestSite = strManifestSite
    End Sub
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
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As ProgressStatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCFU))
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusBar1 = New ProgressStatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.AccessibleDescription = CType(resources.GetObject("btnCheck.AccessibleDescription"), String)
        Me.btnCheck.AccessibleName = CType(resources.GetObject("btnCheck.AccessibleName"), String)
        Me.btnCheck.Anchor = CType(resources.GetObject("btnCheck.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.BackgroundImage = CType(resources.GetObject("btnCheck.BackgroundImage"), System.Drawing.Image)
        Me.btnCheck.Dock = CType(resources.GetObject("btnCheck.Dock"), System.Windows.Forms.DockStyle)
        Me.btnCheck.Enabled = CType(resources.GetObject("btnCheck.Enabled"), Boolean)
        Me.btnCheck.FlatStyle = CType(resources.GetObject("btnCheck.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnCheck.Font = CType(resources.GetObject("btnCheck.Font"), System.Drawing.Font)
        Me.btnCheck.Image = CType(resources.GetObject("btnCheck.Image"), System.Drawing.Image)
        Me.btnCheck.ImageAlign = CType(resources.GetObject("btnCheck.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnCheck.ImageIndex = CType(resources.GetObject("btnCheck.ImageIndex"), Integer)
        Me.btnCheck.ImeMode = CType(resources.GetObject("btnCheck.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnCheck.Location = CType(resources.GetObject("btnCheck.Location"), System.Drawing.Point)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.RightToLeft = CType(resources.GetObject("btnCheck.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnCheck.Size = CType(resources.GetObject("btnCheck.Size"), System.Drawing.Size)
        Me.btnCheck.TabIndex = CType(resources.GetObject("btnCheck.TabIndex"), Integer)
        Me.btnCheck.Text = resources.GetString("btnCheck.Text")
        Me.btnCheck.TextAlign = CType(resources.GetObject("btnCheck.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnCheck.Visible = CType(resources.GetObject("btnCheck.Visible"), Boolean)
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
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
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
        'lblInfo
        '
        Me.lblInfo.AccessibleDescription = CType(resources.GetObject("lblInfo.AccessibleDescription"), String)
        Me.lblInfo.AccessibleName = CType(resources.GetObject("lblInfo.AccessibleName"), String)
        Me.lblInfo.Anchor = CType(resources.GetObject("lblInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.AutoSize = CType(resources.GetObject("lblInfo.AutoSize"), Boolean)
        Me.lblInfo.Dock = CType(resources.GetObject("lblInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.lblInfo.Enabled = CType(resources.GetObject("lblInfo.Enabled"), Boolean)
        Me.lblInfo.Font = CType(resources.GetObject("lblInfo.Font"), System.Drawing.Font)
        Me.lblInfo.ForeColor = System.Drawing.Color.Blue
        Me.lblInfo.Image = CType(resources.GetObject("lblInfo.Image"), System.Drawing.Image)
        Me.lblInfo.ImageAlign = CType(resources.GetObject("lblInfo.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblInfo.ImageIndex = CType(resources.GetObject("lblInfo.ImageIndex"), Integer)
        Me.lblInfo.ImeMode = CType(resources.GetObject("lblInfo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblInfo.Location = CType(resources.GetObject("lblInfo.Location"), System.Drawing.Point)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.RightToLeft = CType(resources.GetObject("lblInfo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblInfo.Size = CType(resources.GetObject("lblInfo.Size"), System.Drawing.Size)
        Me.lblInfo.TabIndex = CType(resources.GetObject("lblInfo.TabIndex"), Integer)
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        Me.lblInfo.TextAlign = CType(resources.GetObject("lblInfo.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblInfo.Visible = CType(resources.GetObject("lblInfo.Visible"), Boolean)
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
        'StatusBar1
        '
        Me.StatusBar1.AccessibleDescription = CType(resources.GetObject("StatusBar1.AccessibleDescription"), String)
        Me.StatusBar1.AccessibleName = CType(resources.GetObject("StatusBar1.AccessibleName"), String)
        Me.StatusBar1.Anchor = CType(resources.GetObject("StatusBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.BackgroundImage = CType(resources.GetObject("StatusBar1.BackgroundImage"), System.Drawing.Image)
        Me.StatusBar1.Dock = CType(resources.GetObject("StatusBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.StatusBar1.Enabled = CType(resources.GetObject("StatusBar1.Enabled"), Boolean)
        Me.StatusBar1.Font = CType(resources.GetObject("StatusBar1.Font"), System.Drawing.Font)
        Me.StatusBar1.ImeMode = CType(resources.GetObject("StatusBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.RightToLeft = CType(resources.GetObject("StatusBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = CType(resources.GetObject("StatusBar1.TabIndex"), Integer)
        Me.StatusBar1.Text = resources.GetString("StatusBar1.Text")
        Me.StatusBar1.Visible = CType(resources.GetObject("StatusBar1.Visible"), Boolean)
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = CType(resources.GetObject("StatusBarPanel1.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.MinWidth = CType(resources.GetObject("StatusBarPanel1.MinWidth"), Integer)
        Me.StatusBarPanel1.Text = resources.GetString("StatusBarPanel1.Text")
        Me.StatusBarPanel1.ToolTipText = resources.GetString("StatusBarPanel1.ToolTipText")
        Me.StatusBarPanel1.Width = CType(resources.GetObject("StatusBarPanel1.Width"), Integer)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AccessibleDescription = CType(resources.GetObject("ProgressBar1.AccessibleDescription"), String)
        Me.ProgressBar1.AccessibleName = CType(resources.GetObject("ProgressBar1.AccessibleName"), String)
        Me.ProgressBar1.Anchor = CType(resources.GetObject("ProgressBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackgroundImage = CType(resources.GetObject("ProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBar1.Dock = CType(resources.GetObject("ProgressBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.ProgressBar1.Enabled = CType(resources.GetObject("ProgressBar1.Enabled"), Boolean)
        Me.ProgressBar1.Font = CType(resources.GetObject("ProgressBar1.Font"), System.Drawing.Font)
        Me.ProgressBar1.ImeMode = CType(resources.GetObject("ProgressBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ProgressBar1.Location = CType(resources.GetObject("ProgressBar1.Location"), System.Drawing.Point)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = CType(resources.GetObject("ProgressBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProgressBar1.Size = CType(resources.GetObject("ProgressBar1.Size"), System.Drawing.Size)
        Me.ProgressBar1.TabIndex = CType(resources.GetObject("ProgressBar1.TabIndex"), Integer)
        Me.ProgressBar1.Text = resources.GetString("ProgressBar1.Text")
        Me.ProgressBar1.Visible = CType(resources.GetObject("ProgressBar1.Visible"), Boolean)
        '
        'frmCFU
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ProgressBar1, Me.StatusBar1, Me.btnCancel, Me.lblInfo, Me.Label1, Me.btnCheck})
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
        Me.Name = "frmCFU"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cfu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnCheck.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        Me.Text = mstrCaption 'NameMe(Me.Text)
        Me.Icon = micoFormIcon
        KeyPreview = True 

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        UIStyle.Spanner(e)
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Sub onProgress(ByVal sender As Object, ByVal e As DownloadEventArgs)
        'Label1.Text = Val(Label1.Text) + 1
        On Error Resume Next
        'StatusBar1.Panels(0).Text = "Downloaded " & e.DownloadedBytes & " bytes... please wait..."
        StatusBar1.Panels(0).Text = LangText.GetString("CFU_DownloadProgress").Replace("[BytesDown]", e.DownloadedBytes)  

        ProgressBar1.Value = e.DownloadedBytes
    End Sub
    Sub onDownloadComplete(ByVal sender As Object, ByVal e As DownloadEventArgs)
        StatusBar1.Panels(0).Text = lstrDowloadCompleteString
        'MsgxBox("complete " & e.DownloadedBytes)
    End Sub
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        BusyCFU(True) 

        If lbooDoOnce = False Then
            lbooDoOnce = True

            '------------------ crc check -------------------------
            Dim IRes As Integer
            'IRes = SetTopicTree()
            IRes = GetWrittenCRC(AppExe) 
            'IRes = 1
            Dim lstrDetails(2) As String
            Dim lstrRetVal3 As String

            'lstrDetails(0) = "33BlmanKSHXtepRhVs"
            'lstrDetails(1) = "b?\jaiTqB;Tx_@fhh;VpdrcEgr<;s<QdrZ_atk[?rDGvOuHbOa?R\P]rjS]iAV?<W?Do?D"
            'lstrDetails(2) = "Kq@bj;jnkNhfMc?sFqxxL<XLAogPOJL;eCzfLWaf=_`ENz`Fg`JPrglqVV"
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "kLU;ZKTKZFRKUZv?nnZ<TQN;UGZ<EGU;VZX?AZF?RUZ<JHK;SHY;MZR?YGZ<XUW;KMU;ZW"
            lstrDetails(2) = "KKHHE;JFU;VNZ@JNU;YGU;ZHUKMQLKGFY;NNZ<FRU;ZJHKKSH;YMY<mpmP"
            

            lstrRetVal3 = Decrypt(lstrDetails)

            If IRes = 1 Then
                '
            ElseIf IRes = -1 Then
                BusyCFU(False) 
                If mbooTopMost = True Then Me.Activate() 
                MessageBox.Show(lstrRetVal3, mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
                Me.Close()
                Exit Sub

            Else
                BusyCFU(False) 
                If mbooTopMost = True Then Me.Activate() 
                MessageBox.Show(lstrRetVal3, mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
                Me.Close()
                Exit Sub
            End If
            '------------------ crc check -------------------------
        End If

        'lstrDowloadCompleteString = "Manifest download complete... please wait..."
        lstrDowloadCompleteString = LangText.GetString("CFU_DownloadComplete")  


        AddHandler HTTPDownload.Progress, AddressOf onProgress
        AddHandler HTTPDownload.DownloadComplete, AddressOf onDownloadComplete

        Dim ht As New HTTPDownload()
        Dim llngFileLength As Long
        Dim lintManifestInc As Integer
        Dim lintProceed As Integer = 0
        Dim lstrDownloadInfo As DownloadInfo

        Dim lstrDat As Date = Date.Now

        'gstrCFUTempDir = System.IO.Path.GetDirectoryName( _
        '    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\Temp-" & _
        '    Format(Date.Now, "dddd-dd-MMM-yyyy-HH-mm-ss")

        
        'gstrCFUTempDir = System.IO.Path.GetDirectoryName( _
        '    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\Temp-" & _
        '    lstrDat.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

        
        gstrCFUTempDir = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Temp-" & _
            lstrDat.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

        For lintManifestInc = 0 To mstrManifestSite.GetUpperBound(0) 'UBound
            Dim lstrTempFile As String = gstrCFUTempDir & "\manifest.dat"
            On Error Resume Next : System.IO.File.Delete(lstrTempFile) : On Error GoTo 0
            'StatusBar1.Panels(0).Text = "Trying to access manifest site no. " & lintManifestInc + 1 & " ... please wait..."
            StatusBar1.Panels(0).Text = LangText.GetString("CFU_TryingManifestSite").Replace("[SiteNum]", lintManifestInc + 1) 

            System.Windows.Forms.Application.DoEvents()

            On Error Resume Next 
            llngFileLength = ht.GetFileLength(mstrManifestSite(lintManifestInc).strSitePath & "/" & mstrManifestSite(lintManifestInc).strManifestDir & mstrManifestSite(lintManifestInc).strManifestFile)
            lintProceed = 10 
            On Error GoTo 0 

            If llngFileLength > 0 Then
                ProgressBar1.Maximum = llngFileLength
                ProgressBar1.Value = 0

                'StatusBar1.Panels(0).Text = "Manifest site found ... Acessing ... please wait..."
                StatusBar1.Panels(0).Text = LangText.GetString("CFU_ManifestSiteFound") 

                lintProceed = 1
                System.Windows.Forms.Application.DoEvents()

                System.IO.Directory.CreateDirectory(gstrCFUTempDir)

                ht.Start(mstrManifestSite(lintManifestInc).strSitePath, mstrManifestSite(lintManifestInc).strManifestDir & _
                    mstrManifestSite(lintManifestInc).strManifestFile, lstrTempFile)

                Dim lstrFileString As String = ReadFileAsString(lstrTempFile)
                'if your search for an error, check you have set the file correctly
                'also that obfuscating has not got rid of an enum string
                'MxessageBox.Show(lstrFileString)
                Dim lstrWebLatestVersion As String = GetParamValue(lstrFileString, ManifestParams.AvailableVersion)
                'MxessageBox.Show(lstrWebLatestVersion)

                System.IO.File.Delete(lstrTempFile)

                Dim lstrThisVerString As String 
                'MxessageBox.Show("Error track stage 1")
                If IsNewer(lstrWebLatestVersion, lstrThisVerString) Then
                    'MxessageBox.Show("Error track stage 2")
                    lintProceed = 2
                    With lstrDownloadInfo
                        .strDownloadSite = GetParamValue(lstrFileString, ManifestParams.DownloadSite)
                        .strDownloadDir = GetParamValue(lstrFileString, ManifestParams.DownloadDir)
                        '.strDownloadFile = GetParamValue(lstrFileString, ManifestParams.DownloadFile)
                        
                        .strDownloadFile = GetParamValue(lstrFileString, "FromVer" & lstrThisVerString) 'usig new string ver of function
                    End With
                End If
                
                'This new feature allows Beta Testers to Use CFU on the same program version.
                'Useful If I make a further change on files they already have with the same version number.
                If OverideVersionFlag = True Then
                    lintProceed = 2
                    With lstrDownloadInfo
                        .strDownloadSite = GetParamValue(lstrFileString, ManifestParams.DownloadSite)
                        .strDownloadDir = GetParamValue(lstrFileString, ManifestParams.DownloadDir)
                        .strDownloadFile = GetParamValue(lstrFileString, "BetaUp")

                    End With
                End If
                
                'MxessageBox.Show("Error track stage 3")
                Exit For
            ElseIf llngFileLength = -1 Then
                'file not found, go round again
                'StatusBar1.Panels(0).Text = "Manifest site not found, trying next site ... please wait..."
                StatusBar1.Panels(0).Text = LangText.GetString("CFU_ManifestSiteNotFound") 

                System.Windows.Forms.Application.DoEvents()
            ElseIf llngFileLength = -2 Then
                'file not found, go round again
                'StatusBar1.Panels(0).Text = "Manifest site busy, trying next site ... please wait..."
                StatusBar1.Panels(0).Text = LangText.GetString("CFU_ManifestSiteBusy")  
                System.Windows.Forms.Application.DoEvents()
            End If
        Next lintManifestInc

        ht = Nothing


        Select Case lintProceed
            Case 10 '0
                BusyCFU(False) 
                StatusBar1.Panels(0).Text = "" 
                If mbooTopMost = True Then Me.Activate() 
                'MxessageBox.Show("Unable to find a newer update, please try again tomorrow", mstrCaption) 'NameMe(""))
                MessageBox.Show(LangText.GetString("CFU_UnableFindUpdate"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props 'NameMe(""))
                Exit Sub
            Case 1
                On Error Resume Next 'moved from arround messagebox , weird!!!
                System.IO.Directory.Delete(gstrCFUTempDir)
                On Error GoTo 0 'moved from arround messagebox , weird!!!
                BusyCFU(False) 
                StatusBar1.Panels(0).Text = "" 
                If mbooTopMost = True Then Me.Activate() 
                'MxessageBox.Show("You currently have the most up-to-date version of this program", mstrCaption) 'NameMe(""))
                MessageBox.Show(LangText.GetString("CFU_YouHaveMostUpToDate"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props 'NameMe(""))
                Me.Close() 
                Exit Sub
            Case 2
                'proceeed
            Case Else
                'MsxgBox("error! lintProceed= " & lintProceed)
                BusyCFU(False) 
                
                StatusBar1.Panels(0).Text = ""
                If mbooTopMost = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("CFU_PleaseCheckCon"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                Exit Sub 
        End Select

        If lintProceed = 2 Then
            Dim lintRetval As DialogResult
            Dim BigFiles As New HTTPDownload()

            'lstrDowloadCompleteString = "Download complete... please wait interpreting update... "
            lstrDowloadCompleteString = LangText.GetString("CFU_DownloadComplete") 

            With lstrDownloadInfo
                llngFileLength = BigFiles.GetFileLength(.strDownloadSite & "/" & .strDownloadDir & .strDownloadFile)
            End With

            BusyCFU(False) 
            StatusBar1.Panels(0).Text = "" 
            'lintRetval = MxessageBox.Show("A newer version of this program is available" & Environment.NewLine & _
            '    "The size of the download is " & CInt((llngFileLength / 1024)) & " Kilobytes." & Environment.NewLine & Environment.NewLine & _
            '    "Do you wish to download this now?", mstrCaption, MessageBoxButtons.YesNo)
            If mbooTopMost = True Then Me.Activate() 
            
            lintRetval = MessageBox.Show(LangText.GetString("CFU_NewerAvailable").Replace("[CR]", _
                Environment.NewLine).Replace("[KB]", CInt((llngFileLength / 1024))).Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine), mstrCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

            System.Windows.Forms.Application.DoEvents()

            If lintRetval <> DialogResult.Yes Then
                Exit Sub
            End If

            BusyCFU(True) 

            ProgressBar1.Maximum = llngFileLength
            ProgressBar1.Value = 0

            Sleep(2)
            System.Windows.Forms.Application.DoEvents()

            With lstrDownloadInfo
                BigFiles.Start(.strDownloadSite, .strDownloadDir & .strDownloadFile, gstrCFUTempDir & "\download.dat")
            End With

            System.IO.Directory.CreateDirectory(gstrCFUTempDir & "\unzip")

            Unzip(gstrCFUTempDir & "\download.dat", gstrCFUTempDir & "\unzip\")

            '----- security check on file keys
            System.IO.File.Copy(gstrCFUTempDir & "\Unzip\MCLKeys.dll", gstrCFUTempDir & "\MCLKeys.dll", True)
            System.IO.File.Delete(gstrCFUTempDir & "\Unzip\MCLKeys.dll") 

            If ValidateNow(gstrCFUTempDir & "\", gstrCFUTempDir & "\unzip\") = False Then
                On Error Resume Next
                System.IO.File.Delete(gstrCFUTempDir & "\download.dat")
                System.IO.File.Delete(gstrCFUTempDir & "\MCLKeys.dll")
                Dim lintArrInc As Integer, listDir() As String = System.IO.Directory.GetFiles(gstrCFUTempDir & "\unzip")
                For lintArrInc = 0 To listDir.Length - 1
                    System.IO.File.Delete(listDir(lintArrInc))
                Next lintArrInc
                System.IO.Directory.Delete(gstrCFUTempDir & "\unzip")
                System.IO.Directory.Delete(gstrCFUTempDir)

                On Error GoTo 0
                'MxessageBox.Show("This download is incompatible with this version of the program!", mstrCaption) 'NameMe(""))
                BusyCFU(False) 
                StatusBar1.Panels(0).Text = "" 
                If mbooTopMost = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("CFU_DownloadIncompatible"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props  'NameMe(""))
                gbooNeedToRestartProgAfterCFU = False 
                Me.Close()
                Exit Sub 
            End If

            '----- security check on file keys

            On Error Resume Next
            System.IO.File.Delete(gstrCFUTempDir & "\download.dat")
            System.IO.File.Delete(gstrCFUTempDir & "\MCLKeys.dll")

            If File.Exists(gstrCFUTempDir & "\Unzip\Beside02.exe") = True Then 
                'System.IO.File.Copy(gstrCFUTempDir & "\Unzip\Beside02.exe", System.IO.Path.GetDirectoryName( _
                '    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\Beside02.exe", True)
                
                System.IO.File.Copy(gstrCFUTempDir & "\Unzip\Beside02.exe", System.IO.Path.GetDirectoryName( _
                    System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Beside02.exe", True)
            End If

            On Error GoTo 0

            'MxessageBox.Show("The program must now restart to update itself!", mstrCaption) 'NameMe(""))
            BusyCFU(False) 
            StatusBar1.Panels(0).Text = "" 
            If mbooTopMost = True Then Me.Activate()
            MessageBox.Show(LangText.GetString("CFU_ProgRestart"), mstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props 'NameMe(""))

            gbooNeedToRestartProgAfterCFU = True

            Me.Close()

        End If
    End Sub

    Private Sub frmCFU_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub frmCFU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub BusyCFU(ByVal pbool As Boolean)

        Busy(Me, pbool)

        If pbool = True Then pbool = False Else pbool = True

        btnCheck.Enabled = pbool
        btnCancel.Enabled = pbool

    End Sub

    Private Sub StatusBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StatusBar1.MouseUp
        'added 
        If e.Button = MouseButtons.Right Then
            Dim DebugPassword As String = ""
            Dim DebugPassInput As New InputBox(mbooTopMost)

            DebugPassword = DebugPassInput.Display("Please enter your overide password", "Please enter your overide password", "")
            If DebugPassword <> "" Then
                If DebugPassword.ToUpper = "Beta Tester".ToUpper Then
                    OverideVersionFlag = True
                    btnCheck_Click(Nothing, Nothing)
                End If
            End If
        End If

    End Sub
    Sub SetBackcolors()
        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        lblInfo.BackColor = Color.FromArgb(0, lblInfo.BackColor)
        btnCheck.BackColor = Color.FromArgb(0, btnCheck.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub frmCFU_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
