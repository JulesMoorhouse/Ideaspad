Imports System.Text.RegularExpressions
Public Class ReplaceDialog
    Inherits System.Windows.Forms.Form
    Dim lRichTextBox As ExRichTextBox 
    'Dim llngCursorLocRTBEditStart As Long
    'Dim llngStrCursorLocRTBEditLength As Long
    Dim lstrCaption As String
    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("RTFStand.RTFStand", _
        System.Reflection.Assembly.GetExecutingAssembly()) 
    Dim mbooTopMost As Boolean 
#Region " Windows Form Designer generated code "
    Public Sub New(ByRef pstrRichTextBox As RichTextBox, ByVal pstrCaption As String, ByVal pbooTopMost As Boolean)
        MyBase.New()

        lRichTextBox = pstrRichTextBox
        lstrCaption = pstrCaption


        'This call is required by the Windows Form Designer.
        InitializeComponent()
        mbooTopMost = pbooTopMost 
        Me.Text = lstrCaption

        'Add any initialization after the InitializeComponent() call
        'If lRichTextBox.SelectionLength = 0 Then
        '    lRichTextBox.SelectionStart = 0
        '    lRichTextBox.SelectionLength = lRichTextBox.TextLength
        'End If
        'llngCursorLocRTBEditStart = lRichTextBox.SelectionStart
        'llngStrCursorLocRTBEditLength = lRichTextBox.SelectionLength
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFindWhat As System.Windows.Forms.TextBox
    Friend WithEvents txtReplaceWith As System.Windows.Forms.TextBox
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend RTBScrap As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReplaceDialog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFindWhat = New System.Windows.Forms.TextBox()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        'txtFindWhat
        '
        Me.txtFindWhat.AccessibleDescription = CType(resources.GetObject("txtFindWhat.AccessibleDescription"), String)
        Me.txtFindWhat.AccessibleName = CType(resources.GetObject("txtFindWhat.AccessibleName"), String)
        Me.txtFindWhat.Anchor = CType(resources.GetObject("txtFindWhat.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFindWhat.AutoSize = CType(resources.GetObject("txtFindWhat.AutoSize"), Boolean)
        Me.txtFindWhat.BackgroundImage = CType(resources.GetObject("txtFindWhat.BackgroundImage"), System.Drawing.Image)
        Me.txtFindWhat.Dock = CType(resources.GetObject("txtFindWhat.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFindWhat.Enabled = CType(resources.GetObject("txtFindWhat.Enabled"), Boolean)
        Me.txtFindWhat.Font = CType(resources.GetObject("txtFindWhat.Font"), System.Drawing.Font)
        Me.txtFindWhat.ImeMode = CType(resources.GetObject("txtFindWhat.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtFindWhat.Location = CType(resources.GetObject("txtFindWhat.Location"), System.Drawing.Point)
        Me.txtFindWhat.MaxLength = CType(resources.GetObject("txtFindWhat.MaxLength"), Integer)
        Me.txtFindWhat.Multiline = CType(resources.GetObject("txtFindWhat.Multiline"), Boolean)
        Me.txtFindWhat.Name = "txtFindWhat"
        Me.txtFindWhat.PasswordChar = CType(resources.GetObject("txtFindWhat.PasswordChar"), Char)
        Me.txtFindWhat.RightToLeft = CType(resources.GetObject("txtFindWhat.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtFindWhat.ScrollBars = CType(resources.GetObject("txtFindWhat.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtFindWhat.Size = CType(resources.GetObject("txtFindWhat.Size"), System.Drawing.Size)
        Me.txtFindWhat.TabIndex = CType(resources.GetObject("txtFindWhat.TabIndex"), Integer)
        Me.txtFindWhat.Text = resources.GetString("txtFindWhat.Text")
        Me.txtFindWhat.TextAlign = CType(resources.GetObject("txtFindWhat.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtFindWhat.Visible = CType(resources.GetObject("txtFindWhat.Visible"), Boolean)
        Me.txtFindWhat.WordWrap = CType(resources.GetObject("txtFindWhat.WordWrap"), Boolean)
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.AccessibleDescription = CType(resources.GetObject("txtReplaceWith.AccessibleDescription"), String)
        Me.txtReplaceWith.AccessibleName = CType(resources.GetObject("txtReplaceWith.AccessibleName"), String)
        Me.txtReplaceWith.Anchor = CType(resources.GetObject("txtReplaceWith.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtReplaceWith.AutoSize = CType(resources.GetObject("txtReplaceWith.AutoSize"), Boolean)
        Me.txtReplaceWith.BackgroundImage = CType(resources.GetObject("txtReplaceWith.BackgroundImage"), System.Drawing.Image)
        Me.txtReplaceWith.Dock = CType(resources.GetObject("txtReplaceWith.Dock"), System.Windows.Forms.DockStyle)
        Me.txtReplaceWith.Enabled = CType(resources.GetObject("txtReplaceWith.Enabled"), Boolean)
        Me.txtReplaceWith.Font = CType(resources.GetObject("txtReplaceWith.Font"), System.Drawing.Font)
        Me.txtReplaceWith.ImeMode = CType(resources.GetObject("txtReplaceWith.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtReplaceWith.Location = CType(resources.GetObject("txtReplaceWith.Location"), System.Drawing.Point)
        Me.txtReplaceWith.MaxLength = CType(resources.GetObject("txtReplaceWith.MaxLength"), Integer)
        Me.txtReplaceWith.Multiline = CType(resources.GetObject("txtReplaceWith.Multiline"), Boolean)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.PasswordChar = CType(resources.GetObject("txtReplaceWith.PasswordChar"), Char)
        Me.txtReplaceWith.RightToLeft = CType(resources.GetObject("txtReplaceWith.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtReplaceWith.ScrollBars = CType(resources.GetObject("txtReplaceWith.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtReplaceWith.Size = CType(resources.GetObject("txtReplaceWith.Size"), System.Drawing.Size)
        Me.txtReplaceWith.TabIndex = CType(resources.GetObject("txtReplaceWith.TabIndex"), Integer)
        Me.txtReplaceWith.Text = resources.GetString("txtReplaceWith.Text")
        Me.txtReplaceWith.TextAlign = CType(resources.GetObject("txtReplaceWith.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtReplaceWith.Visible = CType(resources.GetObject("txtReplaceWith.Visible"), Boolean)
        Me.txtReplaceWith.WordWrap = CType(resources.GetObject("txtReplaceWith.WordWrap"), Boolean)
        '
        'btnFindNext
        '
        Me.btnFindNext.AccessibleDescription = CType(resources.GetObject("btnFindNext.AccessibleDescription"), String)
        Me.btnFindNext.AccessibleName = CType(resources.GetObject("btnFindNext.AccessibleName"), String)
        Me.btnFindNext.Anchor = CType(resources.GetObject("btnFindNext.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnFindNext.BackgroundImage = CType(resources.GetObject("btnFindNext.BackgroundImage"), System.Drawing.Image)
        Me.btnFindNext.Dock = CType(resources.GetObject("btnFindNext.Dock"), System.Windows.Forms.DockStyle)
        Me.btnFindNext.Enabled = CType(resources.GetObject("btnFindNext.Enabled"), Boolean)
        Me.btnFindNext.FlatStyle = CType(resources.GetObject("btnFindNext.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnFindNext.Font = CType(resources.GetObject("btnFindNext.Font"), System.Drawing.Font)
        Me.btnFindNext.Image = CType(resources.GetObject("btnFindNext.Image"), System.Drawing.Image)
        Me.btnFindNext.ImageAlign = CType(resources.GetObject("btnFindNext.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnFindNext.ImageIndex = CType(resources.GetObject("btnFindNext.ImageIndex"), Integer)
        Me.btnFindNext.ImeMode = CType(resources.GetObject("btnFindNext.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnFindNext.Location = CType(resources.GetObject("btnFindNext.Location"), System.Drawing.Point)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.RightToLeft = CType(resources.GetObject("btnFindNext.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnFindNext.Size = CType(resources.GetObject("btnFindNext.Size"), System.Drawing.Size)
        Me.btnFindNext.TabIndex = CType(resources.GetObject("btnFindNext.TabIndex"), Integer)
        Me.btnFindNext.Text = resources.GetString("btnFindNext.Text")
        Me.btnFindNext.TextAlign = CType(resources.GetObject("btnFindNext.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnFindNext.Visible = CType(resources.GetObject("btnFindNext.Visible"), Boolean)
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AccessibleDescription = CType(resources.GetObject("chkMatchCase.AccessibleDescription"), String)
        Me.chkMatchCase.AccessibleName = CType(resources.GetObject("chkMatchCase.AccessibleName"), String)
        Me.chkMatchCase.Anchor = CType(resources.GetObject("chkMatchCase.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkMatchCase.Appearance = CType(resources.GetObject("chkMatchCase.Appearance"), System.Windows.Forms.Appearance)
        Me.chkMatchCase.BackgroundImage = CType(resources.GetObject("chkMatchCase.BackgroundImage"), System.Drawing.Image)
        Me.chkMatchCase.CheckAlign = CType(resources.GetObject("chkMatchCase.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkMatchCase.Dock = CType(resources.GetObject("chkMatchCase.Dock"), System.Windows.Forms.DockStyle)
        Me.chkMatchCase.Enabled = CType(resources.GetObject("chkMatchCase.Enabled"), Boolean)
        Me.chkMatchCase.FlatStyle = CType(resources.GetObject("chkMatchCase.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkMatchCase.Font = CType(resources.GetObject("chkMatchCase.Font"), System.Drawing.Font)
        Me.chkMatchCase.Image = CType(resources.GetObject("chkMatchCase.Image"), System.Drawing.Image)
        Me.chkMatchCase.ImageAlign = CType(resources.GetObject("chkMatchCase.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkMatchCase.ImageIndex = CType(resources.GetObject("chkMatchCase.ImageIndex"), Integer)
        Me.chkMatchCase.ImeMode = CType(resources.GetObject("chkMatchCase.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkMatchCase.Location = CType(resources.GetObject("chkMatchCase.Location"), System.Drawing.Point)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.RightToLeft = CType(resources.GetObject("chkMatchCase.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkMatchCase.Size = CType(resources.GetObject("chkMatchCase.Size"), System.Drawing.Size)
        Me.chkMatchCase.TabIndex = CType(resources.GetObject("chkMatchCase.TabIndex"), Integer)
        Me.chkMatchCase.Text = resources.GetString("chkMatchCase.Text")
        Me.chkMatchCase.TextAlign = CType(resources.GetObject("chkMatchCase.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkMatchCase.Visible = CType(resources.GetObject("chkMatchCase.Visible"), Boolean)
        '
        'btnReplace
        '
        Me.btnReplace.AccessibleDescription = CType(resources.GetObject("btnReplace.AccessibleDescription"), String)
        Me.btnReplace.AccessibleName = CType(resources.GetObject("btnReplace.AccessibleName"), String)
        Me.btnReplace.Anchor = CType(resources.GetObject("btnReplace.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnReplace.BackgroundImage = CType(resources.GetObject("btnReplace.BackgroundImage"), System.Drawing.Image)
        Me.btnReplace.Dock = CType(resources.GetObject("btnReplace.Dock"), System.Windows.Forms.DockStyle)
        Me.btnReplace.Enabled = CType(resources.GetObject("btnReplace.Enabled"), Boolean)
        Me.btnReplace.FlatStyle = CType(resources.GetObject("btnReplace.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnReplace.Font = CType(resources.GetObject("btnReplace.Font"), System.Drawing.Font)
        Me.btnReplace.Image = CType(resources.GetObject("btnReplace.Image"), System.Drawing.Image)
        Me.btnReplace.ImageAlign = CType(resources.GetObject("btnReplace.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnReplace.ImageIndex = CType(resources.GetObject("btnReplace.ImageIndex"), Integer)
        Me.btnReplace.ImeMode = CType(resources.GetObject("btnReplace.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnReplace.Location = CType(resources.GetObject("btnReplace.Location"), System.Drawing.Point)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.RightToLeft = CType(resources.GetObject("btnReplace.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnReplace.Size = CType(resources.GetObject("btnReplace.Size"), System.Drawing.Size)
        Me.btnReplace.TabIndex = CType(resources.GetObject("btnReplace.TabIndex"), Integer)
        Me.btnReplace.Text = resources.GetString("btnReplace.Text")
        Me.btnReplace.TextAlign = CType(resources.GetObject("btnReplace.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnReplace.Visible = CType(resources.GetObject("btnReplace.Visible"), Boolean)
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.AccessibleDescription = CType(resources.GetObject("btnReplaceAll.AccessibleDescription"), String)
        Me.btnReplaceAll.AccessibleName = CType(resources.GetObject("btnReplaceAll.AccessibleName"), String)
        Me.btnReplaceAll.Anchor = CType(resources.GetObject("btnReplaceAll.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnReplaceAll.BackgroundImage = CType(resources.GetObject("btnReplaceAll.BackgroundImage"), System.Drawing.Image)
        Me.btnReplaceAll.Dock = CType(resources.GetObject("btnReplaceAll.Dock"), System.Windows.Forms.DockStyle)
        Me.btnReplaceAll.Enabled = CType(resources.GetObject("btnReplaceAll.Enabled"), Boolean)
        Me.btnReplaceAll.FlatStyle = CType(resources.GetObject("btnReplaceAll.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnReplaceAll.Font = CType(resources.GetObject("btnReplaceAll.Font"), System.Drawing.Font)
        Me.btnReplaceAll.Image = CType(resources.GetObject("btnReplaceAll.Image"), System.Drawing.Image)
        Me.btnReplaceAll.ImageAlign = CType(resources.GetObject("btnReplaceAll.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnReplaceAll.ImageIndex = CType(resources.GetObject("btnReplaceAll.ImageIndex"), Integer)
        Me.btnReplaceAll.ImeMode = CType(resources.GetObject("btnReplaceAll.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnReplaceAll.Location = CType(resources.GetObject("btnReplaceAll.Location"), System.Drawing.Point)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.RightToLeft = CType(resources.GetObject("btnReplaceAll.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnReplaceAll.Size = CType(resources.GetObject("btnReplaceAll.Size"), System.Drawing.Size)
        Me.btnReplaceAll.TabIndex = CType(resources.GetObject("btnReplaceAll.TabIndex"), Integer)
        Me.btnReplaceAll.Text = resources.GetString("btnReplaceAll.Text")
        Me.btnReplaceAll.TextAlign = CType(resources.GetObject("btnReplaceAll.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnReplaceAll.Visible = CType(resources.GetObject("btnReplaceAll.Visible"), Boolean)
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
        'ReplaceDialog
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnReplaceAll, Me.btnReplace, Me.chkMatchCase, Me.btnFindNext, Me.txtReplaceWith, Me.txtFindWhat, Me.Label2, Me.Label1})
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
        Me.Name = "ReplaceDialog"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gIntCursorLoclRichTextBoxFindNext As Integer
    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        Dim UserFindSelection As String
        Dim UserReplaceSelection As String

        UserFindSelection = txtFindWhat.Text
        UserReplaceSelection = txtReplaceWith.Text

        If UserFindSelection.Length = 0 And UserReplaceSelection.Length = 0 Then 
            Exit Sub 
        End If

        'lRichTextBox.SelectionStart = CInt(llngCursorLocRTBEditStart)
        'lRichTextBox.SelectionLength = CInt(llngStrCursorLocRTBEditLength)

        ''If lRichTextBox.SelectionLength = 0 Then
        ''    'ReplaceALL(lRichTextBox.Text, txtFindWhat.Text, txtReplaceWith.Text)
        ''    'lRichTextBox.Text = lRichTextBox.Text.Replace(txtFindWhat.Text, txtReplaceWith.Text)
        ''    lRichTextBox.SelectionStart = 0
        ''    lRichTextBox.SelectionLength = GetTextLen(lRichTextBox) 

        ''    lRichTextBox.SelectedText = lRichTextBox.SelectedText.Replace(txtFindWhat.Text, txtReplaceWith.Text)
        ''    lRichTextBox.SelectionLength = 0

        ''Else
        ''    'ReplaceALL(lRichTextBox.SelectedText, txtFindWhat.Text, txtReplaceWith.Text)
        ''    
        ''    'lRichTextBox.SelectedText = lRichTextBox.SelectedText.Replace(txtFindWhat.Text, txtReplaceWith.Text)
        ''    'This used to loose ALL font Style!!!
        ReplaceRTF(lRichTextBox, txtFindWhat.Text, txtReplaceWith.Text, ReplaceFind.ReplaceAll)
        ''    
        ''End If

        lRichTextBox.Focus()

    End Sub
    Private Function ReplaceALL(ByRef pstrSource As Object, ByVal pstrFind As String, ByVal pstrReplace As String) As String
        
        'lRichTextBox.SelectedText = lRichTextBox.SelectedText.Replace(txtFindWhat.Text, txtReplaceWith.Text)
        Dim lRegEx As New Regex("")
        If chkMatchCase.Checked = True Then
            pstrSource = lRegEx.Replace(pstrSource, pstrFind, pstrReplace, _
                RegexOptions.Multiline)
        Else
            pstrSource = lRegEx.Replace(pstrSource, pstrFind, pstrReplace, _
                RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        End If
        
    End Function
    Private Enum ReplaceFind
        ReplaceAll
        ReplaceFirst
    End Enum

    Private Sub ReplaceRTF(ByRef pSourceRTB As ExRichTextBox, ByVal pstrFind As String, ByVal pstrReplace As String, ByVal Param As ReplaceFind)

        RTBScrap.Rtf = ""
        Dim Selection As Boolean = False
        If pSourceRTB.SelectedText = "" Then
            RTBScrap.SelectedRtf = pSourceRTB.Rtf
        Else
            RTBScrap.SelectedRtf = pSourceRTB.SelectedRtf
            Selection = True
        End If

        Dim SelStartKept As Integer 
        Dim gOptions As RichTextBoxFinds
        gOptions = RichTextBoxFinds.WholeWord And RichTextBoxFinds.MatchCase

        Do
            If RTBScrap.Find(pstrFind, RTBScrap.SelectionStart + RTBScrap.SelectedText.Length, RTBScrap.TextLength, gOptions) = -1 Then

                If Param = ReplaceFind.ReplaceFirst Or Param Then
                    If mbooTopMost = True Then Me.Activate() 
                    MessageBox.Show(LangText.GetString("ReplaceDlg_CannotFind") & " " & ChrGet(34) & txtFindWhat.Text & ChrGet(34), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Exit Do
            Else

                If Param = ReplaceFind.ReplaceFirst Or Param = ReplaceFind.ReplaceAll Then
                    
                    If Selection = True Then
                        SelStartKept = RTBScrap.SelectionStart
                    End If
                    
                    RTBScrap.SelectedText = pstrReplace
                End If
            End If
            If Param = ReplaceFind.ReplaceFirst Then
                Exit Do
            End If
        Loop

        If Param = ReplaceFind.ReplaceFirst Or Param = ReplaceFind.ReplaceAll Then
            If Selection = True Then
                'pSourceRTB.SelectedRtf = RTBScrap.Rtf
                
                RTBScrap.SelectionStart = SelStartKept
                RTBScrap.SelectionLength = pstrReplace.Length
                'pSourceRTB.SelectedRtf = RTBScrap.SelectedRtf
                pSourceRTB.SelectedText = RTBScrap.Text.Substring(0, RTBScrap.TextLength - 1) '
                
            Else
                pSourceRTB.SelectAll()
                'pSourceRTB.SelectedRtf = RTBScrap.SelectedRtf
                pSourceRTB.SelectedText = RTBScrap.Text.Substring(0, RTBScrap.TextLength - 1) '
            End If
        End If

        RTBScrap.Rtf = ""
    End Sub
    Private Sub FindHighlight(ByRef pSourceRTB As ExRichTextBox, ByVal SearchText As String, ByVal MatchCase As Boolean, ByVal WholeWords As Boolean)

        Dim StartLooking As Integer = pSourceRTB.SelectionStart + 1
        Dim FoundAt As Integer
        Dim SearchLength As Integer
        Dim RTBfinds As RichTextBoxFinds
        If SearchText Is Nothing Then Exit Sub

        SearchLength = SearchText.Length

        
        If StartLooking >= Microsoft.VisualBasic.Len(pSourceRTB.Text) Then
            StartLooking = 0
        End If
        

        pSourceRTB.Focus()

        Select Case True
            Case MatchCase And WholeWords
                RTBfinds = RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord
            Case MatchCase
                RTBfinds = RichTextBoxFinds.MatchCase
            Case WholeWords
                RTBfinds = RichTextBoxFinds.WholeWord
            Case Else
                RTBfinds = RichTextBoxFinds.None
        End Select


        Do
            FoundAt = pSourceRTB.Find(SearchText, StartLooking, RTBfinds)
            'If FoundAt > -1 Then Me.SelectionBackColor = HighlightColor
            If FoundAt > -1 Then
                'pSourceRTB.SelectionStart = FoundAt
                'pSourceRTB.SelectionLength = SearchLength
                Exit Do
            Else 
                
                If mbooTopMost = True Then Me.Activate() 
                MessageBox.Show(LangText.GetString("ReplaceDlg_EODReached"), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                pSourceRTB.SelectionStart = 0
                pSourceRTB.SelectionLength = 0
                Exit Do
                
            End If
            StartLooking = StartLooking + SearchLength
        Loop While FoundAt > -1

        Me.Focus()


    End Sub
    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click

        FindHighlight(lRichTextBox, txtFindWhat.Text, False, False)


        Exit Sub

        If txtFindWhat.Text <> "" Then


            'Overloaded function, User can <F3> to Find Next...
            gIntCursorLoclRichTextBoxFindNext = FindMyText(txtFindWhat.Text, gIntCursorLoclRichTextBoxFindNext + 1)
            If gIntCursorLoclRichTextBoxFindNext = -1 Then
                'MxessageBox.Show("Cannot find " & ChrGet(34) & txtFindWhat.Text & ChrGet(34), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If mbooTopMost = True Then Me.Activate() 
                
                MessageBox.Show(LangText.GetString("ReplaceDlg_CannotFind") & " " & ChrGet(34) & txtFindWhat.Text & ChrGet(34), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lRichTextBox.Focus()
        Else
            lRichTextBox.Focus()
        End If
    End Sub
    Private Function FindMyText(ByVal text As String, ByVal start As Integer) As Integer
        Dim returnValue As Integer = -1

        Dim lOptions As RichTextBoxFinds = RichTextBoxFinds.None
        If chkMatchCase.Checked = True Then
            lOptions = RichTextBoxFinds.MatchCase
        End If

        If text.Length > 0 And start >= 0 Then
            Dim indexToText As Integer = lRichTextBox.Find(text, start, lOptions)
            If indexToText >= 0 Then
                returnValue = indexToText
            End If
        End If

        Return returnValue
    End Function
    Private Sub frmReplace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RTBScrap = New System.Windows.Forms.RichTextBox() 

        ResumeLayout(False)

        
        If IsAboveOrEqualWinXp() = True Then  
            btnFindNext.FlatStyle = FlatStyle.System
            btnReplace.FlatStyle = FlatStyle.System
            btnReplaceAll.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        'chkMatchCase.FlatStyle = FlatStyle.System
        

        SetBackcolors() 

        KeyPreview = True 

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'lRichTextBox.SelectionStart = CInt(llngCursorLocRTBEditStart)
        'lRichTextBox.SelectionLength = CInt(llngStrCursorLocRTBEditLength)

        Me.Close()
    End Sub
    Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReplace.Click

        ReplaceRTF(lRichTextBox, txtFindWhat.Text, txtReplaceWith.Text, ReplaceFind.ReplaceFirst)
        Exit Sub

        Dim UserFindSelection As String
        Dim UserReplaceSelection As String

        UserFindSelection = txtFindWhat.Text
        UserReplaceSelection = txtReplaceWith.Text

        Dim bSTOP As Boolean
        Dim iCOUNTER As Integer ' = 0 'Count the replacements
        Dim iTOTAL As Integer = 0 'Total length of the document
        'How to determine there are no more instances of User-input FIND word
        '
        iTOTAL = GetTextLen(lRichTextBox) 

        'Do Until Loop
        gIntCursorLoclRichTextBoxFindNext = 0
        If lRichTextBox.SelectedText <> "" Then

            ' This is where "gIntCursorLocRTBEditFindNext" is set!!!
            ' returnValue = indexToText
            gIntCursorLoclRichTextBoxFindNext = FindMyText(UserFindSelection, gIntCursorLoclRichTextBoxFindNext)
            'Debug.Write(gIntCursorLocRTBEditFindNext & vbCrLf)
            iCOUNTER = iCOUNTER + 1
            'Debug.Write(lRichTextBox.SelectedText & vbCrLf)
            lRichTextBox.SelectedText = UserReplaceSelection

            lRichTextBox.SelectionStart = 0
            lRichTextBox.SelectionLength = 0

            'gIntCursorLocRTBEditFindNext = 0
        End If

        If gIntCursorLoclRichTextBoxFindNext = -1 Then
            'MxessageBox.Show("Cannot find " & ChrGet(34) & txtFindWhat.Text & ChrGet(34), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If mbooTopMost = True Then Me.Activate() 
            
            MessageBox.Show(LangText.GetString("ReplaceDlg_CannotFind") & " " & ChrGet(34) & txtFindWhat.Text & ChrGet(34), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        lRichTextBox.Focus()

    End Sub
    Private Sub txtFindWhat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFindWhat.TextChanged
        Dim lbooEnabled As Boolean = True

        If txtFindWhat.Text = "" Then
            lbooEnabled = False
        End If

        btnFindNext.Enabled = lbooEnabled
        btnReplace.Enabled = lbooEnabled
        btnReplaceAll.Enabled = lbooEnabled

    End Sub
    Private Sub ReplaceDialog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub ReplaceDialog_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Owner.Focus() 
    End Sub
    Sub SetBackcolors()

        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        btnReplace.BackColor = Color.FromArgb(0, btnReplace.BackColor)
        btnReplaceAll.BackColor = Color.FromArgb(0, btnReplaceAll.BackColor)
        chkMatchCase.BackColor = Color.FromArgb(0, chkMatchCase.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        btnFindNext.BackColor = Color.FromArgb(0, btnFindNext.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub ReplaceDialog_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub txtFindWhat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindWhat.KeyDown
        
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            btnFindNext_Click(Nothing, Nothing)
        End If
        
    End Sub

    Private Sub txtReplaceWith_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReplaceWith.KeyDown
        
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            btnFindNext_Click(Nothing, Nothing)
        End If
        
    End Sub
End Class 'RTB Only
