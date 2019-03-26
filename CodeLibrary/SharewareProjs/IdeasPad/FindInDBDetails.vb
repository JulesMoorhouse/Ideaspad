Imports System.Threading
Friend Class FindInDBDetails
    'form added 
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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 56)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(306, 40)
        Me.lblPleaseWait.TabIndex = 2
        Me.lblPleaseWait.Text = "Please wait ..."
        Me.lblPleaseWait.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FindInDBDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(306, 128)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPleaseWait, Me.btnCancel, Me.ProgressBar1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FindInDBDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProgressDialog"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mresTree As TreeView
    Friend Property ResultTreeview() As TreeView
        Get
            Return mresTree
        End Get
        Set(ByVal Value As TreeView)
            mresTree = Value
        End Set
    End Property
    Dim mstrSearchText As String

    Friend Property SearchText() As String
        Get
            Return mstrSearchText
        End Get
        Set(ByVal Value As String)
            mstrSearchText = Value
        End Set
    End Property

    Dim lbooRunning As Boolean = False
    Private Sub ProgressDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))
        
        If IsAboveOrEqualWinXp() = True Then  
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        lblPleaseWait.Text = StandLangText.GetString("StandText_PleaseWait")
        btnCancel.Text = StandLangText.GetString("StandText_Cancel")

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If gintThreadEnd <> 2 Then gintThreadEnd = 1

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If lbooRunning = False Then
            lbooRunning = True

            gintThreadEnd = -1

            FindMatchingDetailsMain()
        End If

    End Sub
    Friend Sub FindMatchingDetailsMain()


        'If mstrSearchText.Length = 0 Then
        '    Exit Sub
        'End If

        'Dim lcnn1 As New ADODB.Connection()
        'Dim lsnaLists As New ADODB.Recordset()
        'Dim lstrSQL As String
        'Dim strChunk As String = ""
        'Dim Offset As Long
        'Dim Totalsize As Long
        'Dim ChunkSize As Long
        'Dim lintByteLength As Integer

        'Try

        '    mresTree.BeginUpdate()

        '    lcnn1 = New ADODB.Connection()
        '    lcnn1.Open(gstrConnectionString)

        '    lstrSQL = "SELECT Topics.TopicCode AS tc, Title, ImgIdx, ByteLen, Detail FROM Topics, TopicDetail WHERE " & _
        '        "(((TopicDetail.ByteLen)<>-1) AND ((TopicDetail.TemplateID)='') AND " & _
        '        "((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics]" & _
        '        ".[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"

        '    lsnaLists.Open(lstrSQL, _
        '        lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        '    ProgressBar1.Maximum = lsnaLists.RecordCount
        '    Dim lintTimer As Date = Date.Now

        '    With lsnaLists
        '        Do While Not .EOF

        '            If DateDiffGet(strman.DateInterval.Second, lintTimer, Date.Now) > 2 Then
        '                Application.DoEvents()
        '                lintTimer = Date.Now
        '            End If
        '            If gintThreadEnd = 1 Then
        '                Exit Do
        '            End If
        '            ChunkSize = 1000
        '            Offset = 0
        '            Totalsize = lsnaLists("Detail").ActualSize
        '            lintByteLength = lsnaLists("ByteLen").Value

        '            Do While Offset < Totalsize
        '                strChunk = strChunk + lsnaLists("Detail").GetChunk(ChunkSize)
        '                Offset = Offset + ChunkSize
        '            Loop

        '            If strChunk <> " " Then
        '                Try
        '                    If lintByteLength <> -1 And strChunk <> "" Then
        '                        AddDebugComment("Inflate")
        '                        Dim InfDef As New InflateDeflate()
        '                        strChunk = InfDef.Inflate(strChunk, lintByteLength)
        '                        lintByteLength = -1
        '                    End If

        '                    If InStrGet(strChunk.ToUpper, mstrSearchText.ToUpper) > 0 Then
        '                        Dim tnNew As New TreeNode()
        '                        tnNew.Text = .Fields("Title").Value & ""
        '                        tnNew.Tag = .Fields("tc").Value & ""

        '                        Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
        '                        tnNew.ImageIndex = lintImgIdx
        '                        tnNew.SelectedImageIndex = lintImgIdx

        '                        mresTree.Nodes.Add(tnNew)
        '                    End If
        '                    strChunk = ""
        '                Catch

        '                End Try
        '            End If

        '            ProgressBar1.Value += 1
        '            .MoveNext()
        '        Loop
        '    End With

        '    ProgressBar1.Value = 0

        '    lsnaLists.Close()
        '    lcnn1.Close()

        '    mresTree.EndUpdate()

        'Catch ex As Exception
        '    Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
        '    Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        'End Try

        
        Dim tempFind As New Finding()
        tempFind.DetailsSearch(mresTree, ProgressBar1, mstrSearchText)
        

        gintThreadEnd = 2

        Me.Close()

    End Sub
    Private Sub SetBackcolors()

        'Added 
        lblPleaseWait.BackColor = Color.FromArgb(0, lblPleaseWait.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub FindInDBDetails_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub FindInDBDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then 
            btnCancel_Click(Nothing, Nothing) 
        End If

    End Sub
End Class
