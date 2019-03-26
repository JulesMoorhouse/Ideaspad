Imports mshtml
Friend Class RapidEntryDefaults
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTopicName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDefaultValues As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDefaultValues As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RapidEntryDefaults))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTopicName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDefaultValues = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDefaultValues = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'cboTopicName
        '
        Me.cboTopicName.AccessibleDescription = CType(resources.GetObject("cboTopicName.AccessibleDescription"), String)
        Me.cboTopicName.AccessibleName = CType(resources.GetObject("cboTopicName.AccessibleName"), String)
        Me.cboTopicName.Anchor = CType(resources.GetObject("cboTopicName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboTopicName.BackgroundImage = CType(resources.GetObject("cboTopicName.BackgroundImage"), System.Drawing.Image)
        Me.cboTopicName.Dock = CType(resources.GetObject("cboTopicName.Dock"), System.Windows.Forms.DockStyle)
        Me.cboTopicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTopicName.Enabled = CType(resources.GetObject("cboTopicName.Enabled"), Boolean)
        Me.cboTopicName.Font = CType(resources.GetObject("cboTopicName.Font"), System.Drawing.Font)
        Me.cboTopicName.ImeMode = CType(resources.GetObject("cboTopicName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboTopicName.IntegralHeight = CType(resources.GetObject("cboTopicName.IntegralHeight"), Boolean)
        Me.cboTopicName.ItemHeight = CType(resources.GetObject("cboTopicName.ItemHeight"), Integer)
        Me.cboTopicName.Location = CType(resources.GetObject("cboTopicName.Location"), System.Drawing.Point)
        Me.cboTopicName.MaxDropDownItems = CType(resources.GetObject("cboTopicName.MaxDropDownItems"), Integer)
        Me.cboTopicName.MaxLength = CType(resources.GetObject("cboTopicName.MaxLength"), Integer)
        Me.cboTopicName.Name = "cboTopicName"
        Me.cboTopicName.RightToLeft = CType(resources.GetObject("cboTopicName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboTopicName.Size = CType(resources.GetObject("cboTopicName.Size"), System.Drawing.Size)
        Me.cboTopicName.TabIndex = CType(resources.GetObject("cboTopicName.TabIndex"), Integer)
        Me.cboTopicName.Text = resources.GetString("cboTopicName.Text")
        Me.cboTopicName.Visible = CType(resources.GetObject("cboTopicName.Visible"), Boolean)
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
        'txtDefaultValues
        '
        Me.txtDefaultValues.AccessibleDescription = CType(resources.GetObject("txtDefaultValues.AccessibleDescription"), String)
        Me.txtDefaultValues.AccessibleName = CType(resources.GetObject("txtDefaultValues.AccessibleName"), String)
        Me.txtDefaultValues.Anchor = CType(resources.GetObject("txtDefaultValues.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDefaultValues.AutoSize = CType(resources.GetObject("txtDefaultValues.AutoSize"), Boolean)
        Me.txtDefaultValues.BackgroundImage = CType(resources.GetObject("txtDefaultValues.BackgroundImage"), System.Drawing.Image)
        Me.txtDefaultValues.Dock = CType(resources.GetObject("txtDefaultValues.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDefaultValues.Enabled = CType(resources.GetObject("txtDefaultValues.Enabled"), Boolean)
        Me.txtDefaultValues.Font = CType(resources.GetObject("txtDefaultValues.Font"), System.Drawing.Font)
        Me.txtDefaultValues.ImeMode = CType(resources.GetObject("txtDefaultValues.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDefaultValues.Location = CType(resources.GetObject("txtDefaultValues.Location"), System.Drawing.Point)
        Me.txtDefaultValues.MaxLength = CType(resources.GetObject("txtDefaultValues.MaxLength"), Integer)
        Me.txtDefaultValues.Multiline = CType(resources.GetObject("txtDefaultValues.Multiline"), Boolean)
        Me.txtDefaultValues.Name = "txtDefaultValues"
        Me.txtDefaultValues.PasswordChar = CType(resources.GetObject("txtDefaultValues.PasswordChar"), Char)
        Me.txtDefaultValues.RightToLeft = CType(resources.GetObject("txtDefaultValues.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtDefaultValues.ScrollBars = CType(resources.GetObject("txtDefaultValues.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtDefaultValues.Size = CType(resources.GetObject("txtDefaultValues.Size"), System.Drawing.Size)
        Me.txtDefaultValues.TabIndex = CType(resources.GetObject("txtDefaultValues.TabIndex"), Integer)
        Me.txtDefaultValues.Text = resources.GetString("txtDefaultValues.Text")
        Me.txtDefaultValues.TextAlign = CType(resources.GetObject("txtDefaultValues.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtDefaultValues.Visible = CType(resources.GetObject("txtDefaultValues.Visible"), Boolean)
        Me.txtDefaultValues.WordWrap = CType(resources.GetObject("txtDefaultValues.WordWrap"), Boolean)
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
        'cboDefaultValues
        '
        Me.cboDefaultValues.AccessibleDescription = CType(resources.GetObject("cboDefaultValues.AccessibleDescription"), String)
        Me.cboDefaultValues.AccessibleName = CType(resources.GetObject("cboDefaultValues.AccessibleName"), String)
        Me.cboDefaultValues.Anchor = CType(resources.GetObject("cboDefaultValues.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboDefaultValues.BackgroundImage = CType(resources.GetObject("cboDefaultValues.BackgroundImage"), System.Drawing.Image)
        Me.cboDefaultValues.Dock = CType(resources.GetObject("cboDefaultValues.Dock"), System.Windows.Forms.DockStyle)
        Me.cboDefaultValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDefaultValues.Enabled = CType(resources.GetObject("cboDefaultValues.Enabled"), Boolean)
        Me.cboDefaultValues.Font = CType(resources.GetObject("cboDefaultValues.Font"), System.Drawing.Font)
        Me.cboDefaultValues.ImeMode = CType(resources.GetObject("cboDefaultValues.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboDefaultValues.IntegralHeight = CType(resources.GetObject("cboDefaultValues.IntegralHeight"), Boolean)
        Me.cboDefaultValues.ItemHeight = CType(resources.GetObject("cboDefaultValues.ItemHeight"), Integer)
        Me.cboDefaultValues.Location = CType(resources.GetObject("cboDefaultValues.Location"), System.Drawing.Point)
        Me.cboDefaultValues.MaxDropDownItems = CType(resources.GetObject("cboDefaultValues.MaxDropDownItems"), Integer)
        Me.cboDefaultValues.MaxLength = CType(resources.GetObject("cboDefaultValues.MaxLength"), Integer)
        Me.cboDefaultValues.Name = "cboDefaultValues"
        Me.cboDefaultValues.RightToLeft = CType(resources.GetObject("cboDefaultValues.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboDefaultValues.Size = CType(resources.GetObject("cboDefaultValues.Size"), System.Drawing.Size)
        Me.cboDefaultValues.TabIndex = CType(resources.GetObject("cboDefaultValues.TabIndex"), Integer)
        Me.cboDefaultValues.Text = resources.GetString("cboDefaultValues.Text")
        Me.cboDefaultValues.Visible = CType(resources.GetObject("cboDefaultValues.Visible"), Boolean)
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = CType(resources.GetObject("btnClose.AccessibleDescription"), String)
        Me.btnClose.AccessibleName = CType(resources.GetObject("btnClose.AccessibleName"), String)
        Me.btnClose.Anchor = CType(resources.GetObject("btnClose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Dock = CType(resources.GetObject("btnClose.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClose.Enabled = CType(resources.GetObject("btnClose.Enabled"), Boolean)
        Me.btnClose.FlatStyle = CType(resources.GetObject("btnClose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnClose.Font = CType(resources.GetObject("btnClose.Font"), System.Drawing.Font)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = CType(resources.GetObject("btnClose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.ImageIndex = CType(resources.GetObject("btnClose.ImageIndex"), Integer)
        Me.btnClose.ImeMode = CType(resources.GetObject("btnClose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClose.Location = CType(resources.GetObject("btnClose.Location"), System.Drawing.Point)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = CType(resources.GetObject("btnClose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnClose.Size = CType(resources.GetObject("btnClose.Size"), System.Drawing.Size)
        Me.btnClose.TabIndex = CType(resources.GetObject("btnClose.TabIndex"), Integer)
        Me.btnClose.Text = resources.GetString("btnClose.Text")
        Me.btnClose.TextAlign = CType(resources.GetObject("btnClose.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.Visible = CType(resources.GetObject("btnClose.Visible"), Boolean)
        '
        'RapidEntryDefaults
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.Label2, Me.cboDefaultValues, Me.Label3, Me.txtDefaultValues, Me.Label1, Me.cboTopicName})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "RapidEntryDefaults"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mstrDefVals() As String
    Dim lbooJustLoading As Boolean = True
    Dim mstrHTMLFormData As String = ""
    Friend Property FillFields() As WinOnly.WebOCHostCtrl
        Get

        End Get
        Set(ByVal Value As WinOnly.WebOCHostCtrl)
            'mstrFillFields = Value
            FillFieldBox(Value)
            ReDim mstrDefVals(cboDefaultValues.Items.Count)
        End Set
    End Property
    Friend Property BranchName() As String
        Get

            Return cboTopicName.Text
        End Get
        Set(ByVal Value As String)
            'mstrBranchName = Value
        End Set
    End Property
    Private Sub cboTopicName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicName.SelectedIndexChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub txtDefaultValues_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDefaultValues.TextChanged
        mstrDefVals(cboDefaultValues.SelectedIndex) = txtDefaultValues.Text

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub cboDefaultValues_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDefaultValues.SelectedIndexChanged
        If lbooJustLoading = False Then
            txtDefaultValues.Text = mstrDefVals(cboDefaultValues.SelectedIndex)
        End If
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mstrHTMLFormData = GenerateFormDatFromCombo()
        Me.Close()
    End Sub
    Friend Function GenerateFormDatFromCombo() As String
        Dim lintArrInc As Integer

        For lintArrInc = 0 To cboDefaultValues.Items.Count - 1
            Dim lstrThisFormField As String = Reverse(cboDefaultValues.Items.Item(lintArrInc))
            Dim lstrThisValue As String = mstrDefVals(lintArrInc)

            lstrThisValue = JetSQLFixup(lstrThisValue)
            GenerateFormDatFromCombo += "<" & lstrThisFormField & ">" & lstrThisValue & "</" & lstrThisFormField & ">"
        Next lintArrInc

    End Function
    Private Sub RapidEntryDefaults_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If lbooJustLoading = True Then
            cboDefaultValues.Focus()
            lbooJustLoading = False
        End If
    End Sub
    Private Sub FillFieldBox(ByVal pAxWebBrowser As WinOnly.WebOCHostCtrl)

        Busy(Me, True)
        pAxWebBrowser.Cursor = Cursors.WaitCursor 

        Me.SuspendLayout()
        'Me.Enabled = False

        cboDefaultValues.Items.Clear()
        cboTopicName.Items.Clear()

        ''RefreshBrowser() 'removed may need to add it to calling form.

        Dim HtmlDoc As IHTMLDocument2 = CType(pAxWebBrowser.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
            For x = 0 To oForm.length - 1
                Select Case oForm.elements(x).type
                    Case "hidden"
                    Case Else
                        cboDefaultValues.Items.Add(oForm.elements(x).name)
                        cboTopicName.Items.Add(oForm.elements(x).name)
                End Select
            Next
        Next i
        cboDefaultValues.SelectedIndex = 0
        cboTopicName.SelectedIndex = 0

        Me.ResumeLayout()

        Busy(Me, False)
        pAxWebBrowser.Cursor = Cursors.Default 

    End Sub
    Private Sub RapidEntryDefaults_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then 
            btnClose.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

    End Sub
    Private Sub SetBackcolors()

        'Added 
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        Label3.BackColor = Color.FromArgb(0, Label3.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub
    Private Sub RapidEntryDefaults_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
    Private Sub RapidEntryDefaults_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        btnClose_Click(Nothing, Nothing) 

    End Sub
End Class
