Friend Class InternalLink
    'added 
    Inherits System.Windows.Forms.Form
    Dim mstrIndexArray() As TreeTopics
    Dim mstrInternalLink As String
    Dim lstrQuickLinkTag As String
    Friend Property InternalLink() As String
        Get
            Return mstrInternalLink
        End Get
        Set(ByVal Value As String)
            mstrInternalLink = Value
        End Set
    End Property
    
    Dim mTreeviewSelect As TreeView
    Friend Property TreeviewSelect() As TreeView
        Get
            Return mTreeviewSelect
        End Get
        Set(ByVal Value As TreeView)
            mTreeviewSelect = Value
        End Set
    End Property
    
    
    Dim mImageListSelect As ImageList
    Friend Property ImageListSelect() As ImageList
        Get
            Return mImageListSelect
        End Get
        Set(ByVal Value As ImageList)
            mImageListSelect = Value
        End Set
    End Property
    
    Friend WithEvents Treeview1 As TreeView
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button

    Friend Sub New()

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
                System.Resources.ResourceManager("Ideaspad.Ideaspad", _
                System.Reflection.Assembly.GetExecutingAssembly())

        
        ''Dim Res As New IPIconsPack.Resource() 

        Treeview1 = New TreeView()
        btnOK = New Button()
        btnCancel = New Button()

        With Treeview1
            .Top = 10
            .Left = 10
            .Width = 300
            .Height = 280 '400
            .TabIndex = 0
            .ImageList = mImageListSelect
        End With

        With btnCancel

            .Left = 10 + (Treeview1.Width) - .Width
            .Top = Treeview1.Top + Treeview1.Height + 10
            .TabIndex = 2
            .Text = StandLangText.GetString("StandText_Cancel")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnOK
            .Left = (btnCancel.Left - .Width) - 10
            .Top = Treeview1.Top + Treeview1.Height + 10
            .TabIndex = 1
            .Text = StandLangText.GetString("StandText_OK")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With
        Me.Text = LangText.GetString("InternalLink_Title").Replace("&", "")
        Me.Width = Treeview1.Left + Treeview1.Width + 20
        Me.Height = btnOK.Top + btnOK.Height + 40
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ShowInTaskbar = False 
        Me.KeyPreview = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Treeview1, Me.btnOK, Me.btnCancel})

        lstrQuickLinkTag = LangText.GetString("InternalLink_Tag")

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        mstrInternalLink = "http://" & lstrQuickLinkTag & ":" & Treeview1.SelectedNode.Tag

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        mstrInternalLink = ""
        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub Treeview1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Treeview1.DoubleClick

        btnOK_Click(Nothing, Nothing)

    End Sub
    Private Sub Treeview1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Treeview1.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub DatePicker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)

        If pbool = True Then pbool = False Else pbool = True

        btnCancel.Enabled = pbool
        btnOK.Enabled = pbool

    End Sub
    Private Sub InternalLink_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Busy(Me, True)
        BusyButtons(True)
        PopulateTree(Treeview1, mstrIndexArray, Me, , gstrSortOrder)
        Busy(Me, False)
        BusyButtons(False)

    End Sub

    Private Sub InternalLink_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
