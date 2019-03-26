Friend Class FindResults
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDoubleClick As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDoubleClick = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Indent = 19
        Me.TreeView1.ItemHeight = 16
        Me.TreeView1.Location = New System.Drawing.Point(7, 7)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(386, 112)
        Me.TreeView1.TabIndex = 9
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSelect.Location = New System.Drawing.Point(408, 8)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.TabIndex = 10
        Me.btnSelect.Text = "Button1"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCancel.Location = New System.Drawing.Point(408, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Button2"
        '
        'lblDoubleClick
        '
        Me.lblDoubleClick.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblDoubleClick.ForeColor = System.Drawing.Color.Blue
        Me.lblDoubleClick.Location = New System.Drawing.Point(8, 120)
        Me.lblDoubleClick.Name = "lblDoubleClick"
        Me.lblDoubleClick.Size = New System.Drawing.Size(384, 16)
        Me.lblDoubleClick.TabIndex = 12
        Me.lblDoubleClick.Text = "Label1"
        '
        'FindResults
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 142)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDoubleClick, Me.btnCancel, Me.btnSelect, Me.TreeView1})
        Me.DockPadding.All = 7
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "FindResults"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Res As New IPIconsPack.Resource() 
    Dim mTreeviewSelect As TreeView
    Dim mTopicCode As String
    Friend Property TopicCode() As String
        Get
            Return mTopicCode
        End Get
        Set(ByVal Value As String)
            'mTopicCode = Value
        End Set
    End Property
    Friend Property TreeviewSelect() As TreeView
        Get
            Return mTreeviewSelect
        End Get
        Set(ByVal Value As TreeView)
            mTreeviewSelect = Value
        End Set
    End Property
    Private Sub lstResults_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick

        SelectIt() 

    End Sub

    Private Sub FindResults_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        TreeView1.ImageList = mTreeviewSelect.ImageList

        lblDoubleClick.Text = StandLangText.GetString("StandText_DblClkSelect")
        btnSelect.Text = StandLangText.GetString("StandText_Select")
        btnCancel.Text = StandLangText.GetString("StandText_Cancel")

        
        If IsAboveOrEqualWinXp() = True Then
            btnSelect.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If
        

        SetBackcolors()

    End Sub
    Private Sub SetBackcolors()

        lblDoubleClick.BackColor = Color.FromArgb(0, lblDoubleClick.BackColor)
        btnSelect.BackColor = Color.FromArgb(0, btnSelect.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        SelectIt()
        Me.Close()

    End Sub
    Private Sub SelectIt()

        If TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        Dim lstrTag As String = TreeView1.SelectedNode.Tag
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        ' Allocate enough space to indicate that ALL nodes are checked.
        cNodes = mTreeviewSelect.GetNodeCount(True)

        ReDim ndxs(cNodes)
        GetNodes(mTreeviewSelect.Nodes(0), ndxs, curNode, False)

        ' Shrink the array to just the # of selected nodes.
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            If n.Tag = lstrTag Then
                mTopicCode = lstrTag
                Me.Close()
                Exit For
            End If
        Next
        TopicCode = ""

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub FindResults_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
