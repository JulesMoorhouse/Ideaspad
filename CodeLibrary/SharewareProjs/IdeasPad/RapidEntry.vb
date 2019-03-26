Imports mshtml
Friend Class RapidEntry
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
    Friend WithEvents btnSaveNext As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents AxWebBrowser1 As WinOnly.WebOCHostCtrl
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RapidEntry))
        Me.btnSaveNext = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.AxWebBrowser1 = New WinOnly.WebOCHostCtrl()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveNext
        '
        Me.btnSaveNext.AccessibleDescription = CType(resources.GetObject("btnSaveNext.AccessibleDescription"), String)
        Me.btnSaveNext.AccessibleName = CType(resources.GetObject("btnSaveNext.AccessibleName"), String)
        Me.btnSaveNext.Anchor = CType(resources.GetObject("btnSaveNext.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSaveNext.BackgroundImage = CType(resources.GetObject("btnSaveNext.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveNext.Dock = CType(resources.GetObject("btnSaveNext.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSaveNext.Enabled = CType(resources.GetObject("btnSaveNext.Enabled"), Boolean)
        Me.btnSaveNext.FlatStyle = CType(resources.GetObject("btnSaveNext.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnSaveNext.Font = CType(resources.GetObject("btnSaveNext.Font"), System.Drawing.Font)
        Me.btnSaveNext.Image = CType(resources.GetObject("btnSaveNext.Image"), System.Drawing.Image)
        Me.btnSaveNext.ImageAlign = CType(resources.GetObject("btnSaveNext.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnSaveNext.ImageIndex = CType(resources.GetObject("btnSaveNext.ImageIndex"), Integer)
        Me.btnSaveNext.ImeMode = CType(resources.GetObject("btnSaveNext.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSaveNext.Location = CType(resources.GetObject("btnSaveNext.Location"), System.Drawing.Point)
        Me.btnSaveNext.Name = "btnSaveNext"
        Me.btnSaveNext.RightToLeft = CType(resources.GetObject("btnSaveNext.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSaveNext.Size = CType(resources.GetObject("btnSaveNext.Size"), System.Drawing.Size)
        Me.btnSaveNext.TabIndex = CType(resources.GetObject("btnSaveNext.TabIndex"), Integer)
        Me.btnSaveNext.Text = resources.GetString("btnSaveNext.Text")
        Me.btnSaveNext.TextAlign = CType(resources.GetObject("btnSaveNext.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnSaveNext.Visible = CType(resources.GetObject("btnSaveNext.Visible"), Boolean)
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
        'btnBack
        '
        Me.btnBack.AccessibleDescription = CType(resources.GetObject("btnBack.AccessibleDescription"), String)
        Me.btnBack.AccessibleName = CType(resources.GetObject("btnBack.AccessibleName"), String)
        Me.btnBack.Anchor = CType(resources.GetObject("btnBack.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.Dock = CType(resources.GetObject("btnBack.Dock"), System.Windows.Forms.DockStyle)
        Me.btnBack.Enabled = CType(resources.GetObject("btnBack.Enabled"), Boolean)
        Me.btnBack.FlatStyle = CType(resources.GetObject("btnBack.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnBack.Font = CType(resources.GetObject("btnBack.Font"), System.Drawing.Font)
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = CType(resources.GetObject("btnBack.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnBack.ImageIndex = CType(resources.GetObject("btnBack.ImageIndex"), Integer)
        Me.btnBack.ImeMode = CType(resources.GetObject("btnBack.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnBack.Location = CType(resources.GetObject("btnBack.Location"), System.Drawing.Point)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = CType(resources.GetObject("btnBack.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnBack.Size = CType(resources.GetObject("btnBack.Size"), System.Drawing.Size)
        Me.btnBack.TabIndex = CType(resources.GetObject("btnBack.TabIndex"), Integer)
        Me.btnBack.Text = resources.GetString("btnBack.Text")
        Me.btnBack.TextAlign = CType(resources.GetObject("btnBack.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnBack.Visible = CType(resources.GetObject("btnBack.Visible"), Boolean)
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
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.AccessibleDescription = CType(resources.GetObject("AxWebBrowser1.AccessibleDescription"), String)
        Me.AxWebBrowser1.AccessibleName = CType(resources.GetObject("AxWebBrowser1.AccessibleName"), String)
        Me.AxWebBrowser1.Anchor = CType(resources.GetObject("AxWebBrowser1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AxWebBrowser1.AutoScroll = CType(resources.GetObject("AxWebBrowser1.AutoScroll"), Boolean)
        Me.AxWebBrowser1.AutoScrollMargin = CType(resources.GetObject("AxWebBrowser1.AutoScrollMargin"), System.Drawing.Size)
        Me.AxWebBrowser1.AutoScrollMinSize = CType(resources.GetObject("AxWebBrowser1.AutoScrollMinSize"), System.Drawing.Size)
        Me.AxWebBrowser1.BackgroundImage = CType(resources.GetObject("AxWebBrowser1.BackgroundImage"), System.Drawing.Image)
        Me.AxWebBrowser1.BrowserContextMenu = False
        Me.AxWebBrowser1.Dock = CType(resources.GetObject("AxWebBrowser1.Dock"), System.Windows.Forms.DockStyle)
        Me.AxWebBrowser1.Enabled = CType(resources.GetObject("AxWebBrowser1.Enabled"), Boolean)
        Me.AxWebBrowser1.Font = CType(resources.GetObject("AxWebBrowser1.Font"), System.Drawing.Font)
        Me.AxWebBrowser1.ImeMode = CType(resources.GetObject("AxWebBrowser1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.AxWebBrowser1.Location = CType(resources.GetObject("AxWebBrowser1.Location"), System.Drawing.Point)
        Me.AxWebBrowser1.Name = "AxWebBrowser1"
        Me.AxWebBrowser1.RightToLeft = CType(resources.GetObject("AxWebBrowser1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.AxWebBrowser1.Size = CType(resources.GetObject("AxWebBrowser1.Size"), System.Drawing.Size)
        Me.AxWebBrowser1.TabIndex = CType(resources.GetObject("AxWebBrowser1.TabIndex"), Integer)
        Me.AxWebBrowser1.Visible = CType(resources.GetObject("AxWebBrowser1.Visible"), Boolean)
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
        'RapidEntry
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHelp, Me.AxWebBrowser1, Me.btnCancel, Me.btnBack, Me.btnOK, Me.btnSaveNext})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "RapidEntry"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim lstrHTMLFormData As String = ""
    'Dim lstrDefVals() As String
    Dim lstrTopics(0) As String
    Dim mstrTemplateFilename As String
    Dim mbooDLL As Boolean = False
    Dim mstrCurTopicCode As String
    Dim lintCurrentTopicIndex As Integer = 0
    Dim mintInsertLevel As Integer
    Dim mstrTemplateID As String
    Dim mstrParentCode As String
    Dim lstrRECurLockFlag As String 
    Dim lstrREOldFormData As String 
    Dim lstrDefaultValues As String 
    Dim lstrBranchName As String 
    Friend Property ParentCode() As String
        Get

            Return mstrParentCode
        End Get
        Set(ByVal Value As String)
            mstrParentCode = Value
        End Set
    End Property
    Friend Property TemplateID() As String
        Get

            Return mstrTemplateID
        End Get
        Set(ByVal Value As String)
            mstrTemplateID = Value
        End Set
    End Property
    Friend Property InsertLevel() As Integer
        Get

            Return mintInsertLevel
        End Get
        Set(ByVal Value As Integer)
            mintInsertLevel = Value
        End Set
    End Property
    Dim mbooJustLoading As Boolean = True
    'Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    lstrHTMLFormData = lstrDefaultValues 'GenerateFormDatFromCombo()
    '    'AxWebBrowser1.Refresh()
    '    RefreshBrowser() 

    'End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AddDebugComment("RapidEntry.btnBack_Click")   
        Dim lstrDerivedTopicName As String = GetTopicNameFromHTML(True) 'quiet


        If lstrDerivedTopicName = "" Then
            Dim lstrFormUsage As String = CheckFormForUsage(AxWebBrowser1)
            If lstrFormUsage <> "" Then
                'if topic name not provided and form not used
                Dim dlgResult As DialogResult
                'dlgResult = MxessageBox.Show("You MUST provide a topic name in your chosen field / item!" & Environment.NewLine & _
                '    Environment.NewLine & lstrFormUsage & Environment.NewLine & _
                '    Environment.NewLine & "If you wish to proceed and loose your changes click YES", NameMe(""), MessageBoxButtons.YesNo)
                
                'dlgResult = MessageBox.Show(LangText.GetString("RapEnt_MustFieldTopicname").Replace("[CR2]", Environment.NewLine & _
                '    Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                'Had forgotten to include ForUsage Paramater
                dlgResult = MessageBox.Show(LangText.GetString("RapEnt_MustFieldTopicname").Replace("[CR2]", Environment.NewLine & _
                    Environment.NewLine).Replace("[FormUsage]", lstrFormUsage), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dlgResult <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If
        End If

        If lstrDerivedTopicName <> "" Then 
            SaveThisTopic(False, lstrDerivedTopicName) 
        End If

        GetTopic(False)

        'Console.WriteLine("Back end " & lintCurrentTopicIndex)
        AddDebugComment("RapidEntry.btnBack_Click - Back end " & lintCurrentTopicIndex)   
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        AddDebugComment("RapidEntry.btnOK_Click")   
        Dim lstrDerivedTopicName As String = GetTopicNameFromHTML(True) 'quiet


        If lstrDerivedTopicName = "" Then
            Dim lstrFormUsage As String = CheckFormForUsage(AxWebBrowser1)
            If lstrFormUsage <> "" Then
                'if topic name not provided and form not used
                Dim dlgResult As DialogResult
                'dlgResult = MxessageBox.Show("You MUST provide a topic name in your chosen field / item!" & Environment.NewLine & _
                '    Environment.NewLine & lstrFormUsage & Environment.NewLine & _
                '    Environment.NewLine & "If you wish to proceed and loose your changes click YES", NameMe(""), MessageBoxButtons.YesNo)
                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                dlgResult = MessageBox.Show(LangText.GetString("RapEnt_MustFieldTopicname").Replace( _
                    "[FormUsage]", lstrFormUsage).Replace("[CR2]", Environment.NewLine & _
                    Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

                If dlgResult <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If
        End If

        If lstrDerivedTopicName <> "" Then 
            SaveThisTopic(False, lstrDerivedTopicName) 
        End If
        Me.Close()

    End Sub
    Private Sub btnSaveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNext.Click
        AddDebugComment("RapidEntry.btnSaveNext_Click")   
        Dim lstrDerivedTopicName As String = GetTopicNameFromHTML()
        If lstrDerivedTopicName = "" Then
            Exit Sub
        End If

        'save or update the current topic
        'move to the next record, from the topic array or add a new blank itme
        'this will not assign a topic code, so it can be added not update on save

        If SaveThisTopic(True, lstrDerivedTopicName) = False Then 
            'mxessagebox.show("You must select which field / item will be used to provide a topic / branch name!")
            'Console.WriteLine("Premature exit from btnSaveNext_Click")
            AddDebugComment("RapidEntry.btnSaveNext_Click - Premature exit")   
            Exit Sub
        End If
        lintCurrentTopicIndex += 1 

        'determine whether the next topic is blank or already exists
        If lintCurrentTopicIndex <= lstrTopics.GetUpperBound(0) Then
            ''If GetTopic(True) = False Then 
            ''    Exit Sub
            ''End If
            GetTopic(True)
        Else
            'reset form to blanks if it's a new form
            lstrHTMLFormData = lstrDefaultValues 'GenerateFormDatFromCombo()
            ShowForm(mstrTemplateFilename, AxWebBrowser1, mbooDLL)

            'Do Until AxWebBrowser1.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
            '    System.Windows.Forms.Application.DoEvents()
            'Loop

            WaitForBrowser(AxWebBrowser1) 
        End If

        'Console.WriteLine("sve end " & lintCurrentTopicIndex)
        AddDebugComment("RapidEntry.btnSaveNext_Click - Save End")   
    End Sub
    Function SaveThisTopic(ByVal pbooNext As Boolean, ByVal pstrDerivedTopicName As String) As Boolean

        SaveThisTopic = True
        'save away and add to array        
        If lintCurrentTopicIndex <= lstrTopics.GetUpperBound(0) Then 'if selected topic index is less that the topics we've added
            'ok update it
            'Console.WriteLine("SaveThisTopic:Must be old array item")
            AddDebugComment("RapidEntry.SaveThisTopic - Must be old array item")   
            mstrCurTopicCode = lstrTopics(lintCurrentTopicIndex)
            'UpdateTopicDetailRTF(ReturnTrueTopicStr(mstrCurTopicCode), Nothing, AxWebBrowser1)
            'Else
            '    'add new
            '    lstrHTMLFormData = GenerateFormDatFromCombo()
            '    ReDim Preserve lstrTopics(lstrTopics.GetUpperBound(0) + 1)
            '    lstrTopics(lstrTopics.GetUpperBound(0)) = SaveNewTopic()
        End If

        If mstrCurTopicCode <> "" Then
            'Console.WriteLine("SaveThisTopic:UpdateTopicDetailRTF")
            AddDebugComment("RapidEntry.SaveThisTopic - UpdateTopicDetailRTF")   
            'UpdateTopicDetailRTF(ReturnTrueTopicStr(mstrCurTopicCode), Nothing, AxWebBrowser1)
            
            UpdateTopicDetailRTF(ReturnTrueTopicStr(mstrCurTopicCode), Nothing, AxWebBrowser1, lstrRECurLockFlag, lstrREOldFormData, Me)

        Else
            'add new
            'Console.WriteLine("SaveThisTopic:Addnew array item and insert queries etc")

            '''If pbooNext = False Then
            '''    MxessageBox.Show("error")
            '''    SaveThisTopic = False
            '''    Exit Function
            '''End If
            '''If pbooNext = False Then
            '''    If lintCurrentTopicIndex > lstrTopics.GetUpperBound(0) Then
            '''        ReDim Preserve lstrTopics(lstrTopics.GetUpperBound(0) + 1)
            '''    End If
            '''Else
            If lintCurrentTopicIndex <> 0 Then
                ReDim Preserve lstrTopics(lstrTopics.GetUpperBound(0) + 1)
            End If
            '''End If

            lstrTopics(lstrTopics.GetUpperBound(0)) = SaveNewTopic(pstrDerivedTopicName)
            'Console.WriteLine("add " & pstrDerivedTopicName & " to array at idx=" & lstrTopics.GetUpperBound(0))
            AddDebugComment("RapidEntry.SaveThisTopic - AddNew - array at idx=" & lstrTopics.GetUpperBound(0))   

            If lstrTopics(lstrTopics.GetUpperBound(0)) = "" Then
                SaveThisTopic = False
            End If
        End If

        lstrHTMLFormData = lstrDefaultValues 'GenerateFormDatFromCombo()

        AxWebBrowser1.Refresh()
        'RefreshBrowser() 

        mstrCurTopicCode = ""

    End Function
    Private Function SaveNewTopic(ByVal pstrDerivedTopicName As String) As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrTopicCode As String
        Dim lstrSQL As String
        Dim lstrTTopicStr As String

        'Dim lstrDerivedTopicName As String = GetTopicNameFromHTML()
        'If lstrDerivedTopicName = "" Then
        '    Exit Function
        'End If

        Busy(Me, True)
        AxWebBrowser1.Cursor = Cursors.WaitCursor 

        'glngLastTopicNum = glngLastTopicNum + 1
        glngLastTopicNum = GetLastTopicRealNumber() + 1 
        lstrTopicCode = GetNextTopicID() & "T" & FormatNumberGet(glngLastTopicNum, "0000000")

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)

        
        If pstrDerivedTopicName.Length > 50 Then
            pstrDerivedTopicName = LeftGet(pstrDerivedTopicName, 50)
        End If
        

        lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
            "Values(" & mintInsertLevel & ", '" & pstrDerivedTopicName & "', '" & lstrTopicCode & "', '" & mstrParentCode & "', 0, True,0);"
        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)
        'Console.WriteLine(lstrSQL)

        lstrRECurLockFlag = CreateLockingFlag(lstrTTopicStr) 

        lstrTTopicStr = ReturnTrueTopicStr(lstrTopicCode)
        'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail,TemplateID ) Values('" & lstrTTopicStr & "',' ','" & mstrTemplateID & "');"
        
        'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag ) Values('" & lstrTTopicStr & _
        '    "',' ','" & mstrTemplateID & "','" & lstrRECurLockFlag & "');"
        
        'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen ) Values('" & lstrTTopicStr & _
        '        "',' ','" & mstrTemplateID & "','" & lstrRECurLockFlag & "',-1);"
        
        lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen, Options ) Values('" & lstrTTopicStr & _
            "',' ','" & mstrTemplateID & "','" & lstrRECurLockFlag & "',-1,'Default');"
        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)
        lcnn1.Close()
        'Console.WriteLine(lstrSQL & Environment.NewLine)

        'add detail field

        UpdateTopicDetailRTF(lstrTTopicStr, Nothing, AxWebBrowser1, lstrRECurLockFlag, lstrREOldFormData, Me) 'added CreateLockingFlag

        Busy(Me, False)
        AxWebBrowser1.Cursor = Cursors.Default 

        Return lstrTopicCode

    End Function
    Function GetTopicNameFromHTML(Optional ByVal pbooQuiet As Boolean = False) As String
        Dim lstrBrowserData As String = GenerateFormData(AxWebBrowser1)
        Dim lstrDerivedTopicField As String = Reverse(lstrBranchName) 'cboTopicName.Text)
        Dim lstrDerivedTopicName As String = GetData(lstrBrowserData, "<" & lstrDerivedTopicField & ">", "</" & lstrDerivedTopicField & ">")

        If lstrDerivedTopicName = "" Then
            If pbooQuiet = False Then
                'mxessagebox.show("You must enter a topic / branch name in your chosen field / item!", NameMe(""))
                If gbooAlwaysOnTop = True Then Me.Activate() 
                
                MessageBox.Show(LangText.GetString("RapEnt_EnterTopicName"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            End If
            Exit Function
        End If

        If InStrGet(lstrDerivedTopicName, "~") > 0 Then
            If pbooQuiet = False Then
                If gbooAlwaysOnTop = True Then Me.Activate() 
                'mxessagebox.show("The '~' is used by the system, please try again!", NameMe(""))
                
                MessageBox.Show(LangText.GetString("Pad_BranchCharWarn"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

            End If
            Exit Function
        End If

        Return TrimGet(lstrDerivedTopicName)

    End Function
    Sub GetTopic(ByVal pbooNext As Boolean) 'As Boolean

        ''GetTopic = True

        If lintCurrentTopicIndex = 0 Then
            ''GetTopic = False
            Exit Sub
        End If

        If pbooNext = False Then
            lintCurrentTopicIndex -= 1 ' get previous
        End If

        mstrCurTopicCode = lstrTopics(lintCurrentTopicIndex) & ""
        'Console.WriteLine("Get " & mstrCurTopicCode & " at idx=" & lintCurrentTopicIndex)
        AddDebugComment("RapidEntry.GetTopic - " & mstrCurTopicCode & " at idx=" & lintCurrentTopicIndex)   
        ''If mstrCurTopicCode = "" Then
        ''    MxessageBox.Show("error GetTopic(" & pbooNext & ") 'mstrCurTopicCode = nothing !!")
        ''    GetTopic = False
        ''    Exit Function
        ''End If

        Dim lstrFormData As String

        'GetTopicDetailRTF(ReturnTrueTopicStr(mstrCurTopicCode), Nothing, AxWebBrowser1, Nothing, _
        '    mstrTemplateFilename, mbooDLL, lstrFormData)
        
        lstrRECurLockFlag = GetTopicDetailRTF(ReturnTrueTopicStr(mstrCurTopicCode), Nothing, AxWebBrowser1, Nothing, _
            mstrTemplateFilename, mbooDLL, lstrFormData)

        If mstrTemplateFilename <> "" Then
            If lstrFormData <> "" Then lstrHTMLFormData = lstrFormData
            ShowForm(mstrTemplateFilename, AxWebBrowser1, mbooDLL)
        End If

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
    'Private Sub AxWebBrowser1_DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles AxWebBrowser1.DocumentComplete
    
    Private Sub AxWebBrowser1_DocumentComplete(ByVal sender As Object, ByVal e As Object) Handles AxWebBrowser1.DocumentComplete
        If lstrHTMLFormData <> "" Then
            PopulateHTMLFields(lstrHTMLFormData, AxWebBrowser1)
            lstrREOldFormData = lstrHTMLFormData 
            lstrHTMLFormData = ""
        End If



    End Sub
    Private Sub RapidEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mxessagebox.show("To use this feaure from the toolbar you must set a default template, or use this feature from the templates menu.")

        
        If IsAboveOrEqualWinXp() = True Then  
            btnSaveNext.FlatStyle = FlatStyle.System
            btnOK.FlatStyle = FlatStyle.System
            btnBack.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        mstrTemplateID = mstrTemplateID.ToUpper 

        Busy(Me, True) 
        AxWebBrowser1.Cursor = Cursors.WaitCursor 

        RefreshBrowser() 
        'FillFieldBox()
        'ReDim lstrDefVals(cboDefaultValues.Items.Count)
        Busy(Me, True) 
        AxWebBrowser1.Cursor = Cursors.WaitCursor 

        'mbooJustLoading = False 'moved to form activated
        KeyPreview = True 

    End Sub

    Sub RefreshBrowser()
        Dim TR As New IPTemplates._main()
        Dim lstrTemplateResources() As IPTemplates._main.resources
        TR.HTMLForms(lstrTemplateResources)

        Dim lintArrinc As Integer
        For lintArrinc = 0 To lstrTemplateResources.GetUpperBound(0)
            If mstrTemplateID = lstrTemplateResources(lintArrinc).ID Then
                mstrTemplateFilename = lstrTemplateResources(lintArrinc).file
                mbooDLL = True
                Exit For
            End If
        Next lintArrinc

        If mbooDLL = False Then
            'Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, mstrTemplateID)
            
            If mstrTemplateID <> "" Then
                mstrTemplateID = mstrTemplateID.ToUpper
            End If
            Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, mstrTemplateID)
            mstrTemplateFilename = UserTemplateConfig.GetValue("FileName", "")
        End If

        If InStrGet(mstrTemplateFilename, "SYSTEM:") > 0 Then
            mstrTemplateFilename = Microsoft.VisualBasic.Replace(mstrTemplateFilename, "SYSTEM:", "")
            mbooDLL = True
        End If
        ShowForm(mstrTemplateFilename, AxWebBrowser1, mbooDLL)


        'Do Until AxWebBrowser1.ReadyState <>  1 
        '    System.Windows.Forms.Application.DoEvents()
        'Loop
        WaitForBrowser(AxWebBrowser1) 

    End Sub
    'Private Sub txtDefaultValues_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    lstrDefVals(cboDefaultValues.SelectedIndex) = txtDefaultValues.Text

    'End Sub
    'Function GenerateFormDatFromCombo() As String
    '    Dim lintArrInc As Integer

    '    For lintArrInc = 0 To cboDefaultValues.Items.Count - 1
    '        Dim lstrThisFormField As String = Reverse(cboDefaultValues.Items.Item(lintArrInc))
    '        Dim lstrThisValue As String = lstrDefVals(lintArrInc)

    '        lstrThisValue = JetSQLFixup(lstrThisValue)
    '        GenerateFormDatFromCombo += "<" & lstrThisFormField & ">" & lstrThisValue & "</" & lstrThisFormField & ">"
    '    Next lintArrInc

    'End Function
    'Private Sub cboDefaultValues_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If mbooJustLoading = False Then
    '        txtDefaultValues.Text = lstrDefVals(cboDefaultValues.SelectedIndex)
    '    End If
    'End Sub
    Friend Function CheckFormForUsage(ByVal BrowserControl As WinOnly.WebOCHostCtrl) As String
        Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        CheckFormForUsage = ""

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)

            For x = 0 To oForm.length - 1
                Dim lstrThisFormField As String = Reverse(oForm.elements(x).name)
                Dim lstrThisValue As String

                Select Case oForm.elements(x).type
                    Case "text", "textarea"
                        lstrThisValue = oForm.elements(x).value
                    Case "select-one"
                        Dim y As Integer
                        For y = 0 To oForm.elements(x).length - 1
                            If oForm.elements(x).options(y).selected = True Then
                                lstrThisValue = oForm.elements(x).options(y).text
                                Exit For
                            End If
                        Next y
                End Select
                If TrimGet(lstrThisValue) <> "" Then
                    'CheckFormForUsage = "Item '" & oForm.elements(x).name & "' has a value!"
                    
                    CheckFormForUsage = LangText.GetString("RapEnt_ChkUseItemHas").Replace("[Name]", oForm.elements(x).name)
                    Try 
                        If LeftGet(oForm.elements(x).type, 6) = "select" Then
                            'CheckFormForUsage = "The drop down list '" & oForm.elements(x).name & "' has a value, this may the default value!"
                            
                            CheckFormForUsage = LangText.GetString("RapEnt_ChkUseDropHas").Replace("[Name]", oForm.elements(x).name)
                        End If
                    Catch 
                    End Try 
                    Exit Function
                End If
            Next
        Next i
    End Function

    Private Sub btnDefaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
        'If grpDefaults.Visible = True Then
        '    grpDefaults.Visible = False
        '    AxWebBrowser1.Height = btnOK.Top - 16
        'Else
        '    grpDefaults.Visible = True
        '    AxWebBrowser1.Height = grpDefaults.Top - 8
        'End If

    End Sub

    Private Sub RapidEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

        
        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.Rapid_Entry)) 
    End Sub

    Private Sub RapidEntry_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If mbooJustLoading = True Then 
            'cboDefaultValues.Focus() 
            mbooJustLoading = False 
            Busy(Me, True)
            AxWebBrowser1.Cursor = Cursors.WaitCursor 
            
            System.Windows.Forms.Application.DoEvents()
            Dim DefVals As New RapidEntryDefaults()
            With DefVals
                .Owner = Me 
                .FillFields = AxWebBrowser1
                Busy(Me, False)
                AxWebBrowser1.Cursor = Cursors.Default 
                .ShowDialog()
                Busy(Me, True)
                AxWebBrowser1.Cursor = Cursors.WaitCursor 

                lstrDefaultValues = .GenerateFormDatFromCombo ' so they can be used later
                lstrHTMLFormData = lstrDefaultValues ' so that they are used now
                lstrBranchName = .BranchName
            End With
            RefreshBrowser()
            Busy(Me, False)
            AxWebBrowser1.Cursor = Cursors.Default 
            

        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnSaveNext.BackColor = Color.FromArgb(0, btnSaveNext.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        btnBack.BackColor = Color.FromArgb(0, btnBack.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub RapidEntry_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
