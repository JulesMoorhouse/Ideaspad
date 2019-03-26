Imports mshtml
Imports System.IO
Friend Class TemplateExport
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
    Friend WithEvents lstTemplates As System.Windows.Forms.ListBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusBar1 As ProgressStatusBar
    Friend WithEvents ProgressPanel1 As ProgressPanel
    Friend WithEvents SystemStatusPanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents RightMostPanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateExport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTemplates = New System.Windows.Forms.ListBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatusBar1 = New AppBasic.ProgressStatusBar()
        Me.SystemStatusPanel = New System.Windows.Forms.StatusBarPanel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.SystemStatusPanel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lstTemplates
        '
        Me.lstTemplates.AccessibleDescription = CType(resources.GetObject("lstTemplates.AccessibleDescription"), String)
        Me.lstTemplates.AccessibleName = CType(resources.GetObject("lstTemplates.AccessibleName"), String)
        Me.lstTemplates.Anchor = CType(resources.GetObject("lstTemplates.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lstTemplates.BackgroundImage = CType(resources.GetObject("lstTemplates.BackgroundImage"), System.Drawing.Image)
        Me.lstTemplates.ColumnWidth = CType(resources.GetObject("lstTemplates.ColumnWidth"), Integer)
        Me.lstTemplates.Dock = CType(resources.GetObject("lstTemplates.Dock"), System.Windows.Forms.DockStyle)
        Me.lstTemplates.Enabled = CType(resources.GetObject("lstTemplates.Enabled"), Boolean)
        Me.lstTemplates.Font = CType(resources.GetObject("lstTemplates.Font"), System.Drawing.Font)
        Me.lstTemplates.HorizontalExtent = CType(resources.GetObject("lstTemplates.HorizontalExtent"), Integer)
        Me.lstTemplates.HorizontalScrollbar = CType(resources.GetObject("lstTemplates.HorizontalScrollbar"), Boolean)
        Me.lstTemplates.ImeMode = CType(resources.GetObject("lstTemplates.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lstTemplates.IntegralHeight = CType(resources.GetObject("lstTemplates.IntegralHeight"), Boolean)
        Me.lstTemplates.ItemHeight = CType(resources.GetObject("lstTemplates.ItemHeight"), Integer)
        Me.lstTemplates.Location = CType(resources.GetObject("lstTemplates.Location"), System.Drawing.Point)
        Me.lstTemplates.Name = "lstTemplates"
        Me.lstTemplates.RightToLeft = CType(resources.GetObject("lstTemplates.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lstTemplates.ScrollAlwaysVisible = CType(resources.GetObject("lstTemplates.ScrollAlwaysVisible"), Boolean)
        Me.lstTemplates.Size = CType(resources.GetObject("lstTemplates.Size"), System.Drawing.Size)
        Me.lstTemplates.TabIndex = CType(resources.GetObject("lstTemplates.TabIndex"), Integer)
        Me.lstTemplates.Visible = CType(resources.GetObject("lstTemplates.Visible"), Boolean)
        '
        'btnExport
        '
        Me.btnExport.AccessibleDescription = CType(resources.GetObject("btnExport.AccessibleDescription"), String)
        Me.btnExport.AccessibleName = CType(resources.GetObject("btnExport.AccessibleName"), String)
        Me.btnExport.Anchor = CType(resources.GetObject("btnExport.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Dock = CType(resources.GetObject("btnExport.Dock"), System.Windows.Forms.DockStyle)
        Me.btnExport.Enabled = CType(resources.GetObject("btnExport.Enabled"), Boolean)
        Me.btnExport.FlatStyle = CType(resources.GetObject("btnExport.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnExport.Font = CType(resources.GetObject("btnExport.Font"), System.Drawing.Font)
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = CType(resources.GetObject("btnExport.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnExport.ImageIndex = CType(resources.GetObject("btnExport.ImageIndex"), Integer)
        Me.btnExport.ImeMode = CType(resources.GetObject("btnExport.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnExport.Location = CType(resources.GetObject("btnExport.Location"), System.Drawing.Point)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.RightToLeft = CType(resources.GetObject("btnExport.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnExport.Size = CType(resources.GetObject("btnExport.Size"), System.Drawing.Size)
        Me.btnExport.TabIndex = CType(resources.GetObject("btnExport.TabIndex"), Integer)
        Me.btnExport.Text = resources.GetString("btnExport.Text")
        Me.btnExport.TextAlign = CType(resources.GetObject("btnExport.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnExport.Visible = CType(resources.GetObject("btnExport.Visible"), Boolean)
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
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.FileName = "Tabbed"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = resources.GetString("SaveFileDialog1.Title")
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
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.SystemStatusPanel})
        Me.StatusBar1.RightToLeft = CType(resources.GetObject("StatusBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = CType(resources.GetObject("StatusBar1.TabIndex"), Integer)
        Me.StatusBar1.Text = resources.GetString("StatusBar1.Text")
        Me.StatusBar1.Visible = CType(resources.GetObject("StatusBar1.Visible"), Boolean)
        '
        'SystemStatusPanel
        '
        Me.SystemStatusPanel.Alignment = CType(resources.GetObject("SystemStatusPanel.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.SystemStatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.SystemStatusPanel.Icon = CType(resources.GetObject("SystemStatusPanel.Icon"), System.Drawing.Icon)
        Me.SystemStatusPanel.MinWidth = CType(resources.GetObject("SystemStatusPanel.MinWidth"), Integer)
        Me.SystemStatusPanel.Text = resources.GetString("SystemStatusPanel.Text")
        Me.SystemStatusPanel.ToolTipText = resources.GetString("SystemStatusPanel.ToolTipText")
        Me.SystemStatusPanel.Width = CType(resources.GetObject("SystemStatusPanel.Width"), Integer)
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
        'TemplateExport
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnHelp, Me.Label2, Me.btnExport, Me.lstTemplates, Me.Label1, Me.StatusBar1})
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
        Me.Name = "TemplateExport"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        CType(Me.SystemStatusPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim lstrUsedTemplatesIDs() As String
    Dim lstrTemplateFileName() As String
    Dim lstrTemplateResources() As IPTemplates._main.resources


    
    Dim mOutputType As TemplateDataTypes.TemplateOutput
    Friend Property OutputType() As TemplateDataTypes.TemplateOutput
        Get
            Return mOutputType
        End Get
        Set(ByVal Value As TemplateDataTypes.TemplateOutput)
            mOutputType = Value
        End Set
    End Property
    

    Private Sub TemplateExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SuspendLayout() 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnExport.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        
        If mOutputType = TemplateDataTypes.TemplateOutput.XML Then
            Label2.Text = ""
        End If
        

        Dim TR As New IPTemplates._main()
        TR.HTMLForms(lstrTemplateResources)
        FillTemplatesUsedList(lstrUsedTemplatesIDs, lstrTemplateFileName, lstrTemplateResources, lstTemplates)
        AddProgressPanel()
        StatusBar1.Panels(0).Text = ""
        Me.ResumeLayout() 

    End Sub
    Private Sub AddProgressPanel()

        ProgressPanel1 = New ProgressPanel()
        RightMostPanel = New System.Windows.Forms.StatusBarPanel()
        StatusBar1.Panels.AddRange(New ProgressPanel() {ProgressPanel1})
        StatusBar1.Panels.AddRange(New StatusBarPanel() {RightMostPanel})

        With ProgressPanel1
            .ForeColor = System.Drawing.SystemColors.Desktop
            .Maximum = 100
            .Minimum = 1
            .MinWidth = 100
            .Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw
            .Text = "" 
            .Value = 0
        End With

        RightMostPanel.MinWidth = 100

    End Sub
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        If lstTemplates.SelectedIndex = -1 Then Exit Sub

        'show save file dialog
        Dim lstrOutPutFile As String
        With SaveFileDialog1
            .FileName = lstTemplates.SelectedItem 

            .RestoreDirectory = True 

            Select Case mOutputType 
                Case TemplateDataTypes.TemplateOutput.TabbedDelim 
                    
                    .Filter = StandLangText.GetString("StandText_TXTFilter")
                Case TemplateDataTypes.TemplateOutput.XML 
                    .Filter = StandLangText.GetString("StandText_TXTFilter").Replace("*.txt", "*.xml").Replace("Text", "XML") 
            End Select

            If .ShowDialog = DialogResult.OK Then
                lstrOutPutFile = .FileName
                Try
                    File.Delete(lstrOutPutFile)
                Catch ex As Exception
                End Try
            Else
                Exit Sub
            End If
        End With

        Busy(Me, True)
        BusyButtons(True) 

        'Put html form fields into array
        Dim lstrFields() As String
        'StatusBar1.Panels(0).Text = "Loading template..."
        
        StatusBar1.Panels(0).Text = LangText.GetString("TempEx_LoadingFile")

        Dim AxWebBrowser As WinOnly.WebOCHostCtrl
        ''Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSelection))
        SpawnBrowserObject(AxWebBrowser, Me)

        Dim lbooDLL As Boolean = False
        Dim lstrFileName As String = lstrTemplateFileName(lstTemplates.SelectedIndex)
        If InStrGet(lstrFileName, "SYSTEM:") > 0 Then
            lstrFileName = Microsoft.VisualBasic.Replace(lstrFileName, "SYSTEM:", "")
            lbooDLL = True
        End If
        ShowForm(lstrFileName, AxWebBrowser, lbooDLL)

        'Do Until AxWebBrowser.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
        '    System.Windows.Forms.Application.DoEvents()
        'Loop

        WaitForBrowser(AxWebBrowser) 

        'StatusBar1.Panels(0).Text = "Analysing template..."
        
        StatusBar1.Panels(0).Text = LangText.GetString("TempEx_AnalysingFile")

        Dim HtmlDoc As IHTMLDocument2 = CType(AxWebBrowser.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        Dim lintFieldCounter As Integer

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

        StatusBar1.Panels(0).Text = LangText.GetString("TempEx_GeneratingFile")

        If GenerateDataFile(lstrOutPutFile, lstrUsedTemplatesIDs(lstTemplates.SelectedIndex), lstrFields, ProgressPanel1, mOutputType, lstTemplates.SelectedItem) = False Then
            If gbooAlwaysOnTop = True Then Me.Activate() 
            MessageBox.Show(LangText.GetString("TempEx_AccessDenied"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 
            Busy(Me, False) 
            BusyButtons(False) 
            StatusBar1.Panels(0).Text = "" 
            Exit Sub 
        End If
        
        StatusBar1.Panels(0).Text = LangText.GetString("TempEx_Done")

        Busy(Me, False)
        BusyButtons(False) 

        If gbooAlwaysOnTop = True Then Me.Activate() 
        
        MessageBox.Show(LangText.GetString("TempEx_CreatedSuccess"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

        Me.Close()

    End Sub


    Private Sub TemplateExport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = System.Windows.Forms.Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.exporttempldata)) 
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnExport.Enabled = pbool 
        btnCancel.Enabled = pbool 
        btnHelp.Enabled = pbool 
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnExport.BackColor = Color.FromArgb(0, btnExport.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub TemplateExport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class