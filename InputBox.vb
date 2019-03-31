Public Class InputBox

    Inherits System.Windows.Forms.Form
    Friend WithEvents lblPrompt As New Label()
    'Private txtAnswer As New TextBox()
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Dim RetVal As String
    Dim mbooTopMost As Boolean 
    Dim mbooFormJustLoaded As Boolean 
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(InputBox))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.AccessibleDescription = CType(resources.GetObject("btnOk.AccessibleDescription"), String)
        Me.btnOk.AccessibleName = CType(resources.GetObject("btnOk.AccessibleName"), String)
        Me.btnOk.Anchor = CType(resources.GetObject("btnOk.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackgroundImage = CType(resources.GetObject("btnOk.BackgroundImage"), System.Drawing.Image)
        Me.btnOk.Dock = CType(resources.GetObject("btnOk.Dock"), System.Windows.Forms.DockStyle)
        Me.btnOk.Enabled = CType(resources.GetObject("btnOk.Enabled"), Boolean)
        Me.btnOk.FlatStyle = CType(resources.GetObject("btnOk.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnOk.Font = CType(resources.GetObject("btnOk.Font"), System.Drawing.Font)
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = CType(resources.GetObject("btnOk.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnOk.ImageIndex = CType(resources.GetObject("btnOk.ImageIndex"), Integer)
        Me.btnOk.ImeMode = CType(resources.GetObject("btnOk.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnOk.Location = CType(resources.GetObject("btnOk.Location"), System.Drawing.Point)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = CType(resources.GetObject("btnOk.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnOk.Size = CType(resources.GetObject("btnOk.Size"), System.Drawing.Size)
        Me.btnOk.TabIndex = CType(resources.GetObject("btnOk.TabIndex"), Integer)
        Me.btnOk.Text = resources.GetString("btnOk.Text")
        Me.btnOk.TextAlign = CType(resources.GetObject("btnOk.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnOk.Visible = CType(resources.GetObject("btnOk.Visible"), Boolean)
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = CType(resources.GetObject("btnCancel.AccessibleDescription"), String)
        Me.btnCancel.AccessibleName = CType(resources.GetObject("btnCancel.AccessibleName"), String)
        Me.btnCancel.Anchor = CType(resources.GetObject("btnCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        'txtAnswer
        '
        Me.txtAnswer.AccessibleDescription = CType(resources.GetObject("txtAnswer.AccessibleDescription"), String)
        Me.txtAnswer.AccessibleName = CType(resources.GetObject("txtAnswer.AccessibleName"), String)
        Me.txtAnswer.Anchor = CType(resources.GetObject("txtAnswer.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtAnswer.AutoSize = CType(resources.GetObject("txtAnswer.AutoSize"), Boolean)
        Me.txtAnswer.BackgroundImage = CType(resources.GetObject("txtAnswer.BackgroundImage"), System.Drawing.Image)
        Me.txtAnswer.Dock = CType(resources.GetObject("txtAnswer.Dock"), System.Windows.Forms.DockStyle)
        Me.txtAnswer.Enabled = CType(resources.GetObject("txtAnswer.Enabled"), Boolean)
        Me.txtAnswer.Font = CType(resources.GetObject("txtAnswer.Font"), System.Drawing.Font)
        Me.txtAnswer.ImeMode = CType(resources.GetObject("txtAnswer.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtAnswer.Location = CType(resources.GetObject("txtAnswer.Location"), System.Drawing.Point)
        Me.txtAnswer.MaxLength = CType(resources.GetObject("txtAnswer.MaxLength"), Integer)
        Me.txtAnswer.Multiline = CType(resources.GetObject("txtAnswer.Multiline"), Boolean)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.PasswordChar = CType(resources.GetObject("txtAnswer.PasswordChar"), Char)
        Me.txtAnswer.RightToLeft = CType(resources.GetObject("txtAnswer.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtAnswer.ScrollBars = CType(resources.GetObject("txtAnswer.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtAnswer.Size = CType(resources.GetObject("txtAnswer.Size"), System.Drawing.Size)
        Me.txtAnswer.TabIndex = CType(resources.GetObject("txtAnswer.TabIndex"), Integer)
        Me.txtAnswer.Text = resources.GetString("txtAnswer.Text")
        Me.txtAnswer.TextAlign = CType(resources.GetObject("txtAnswer.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtAnswer.Visible = CType(resources.GetObject("txtAnswer.Visible"), Boolean)
        Me.txtAnswer.WordWrap = CType(resources.GetObject("txtAnswer.WordWrap"), Boolean)
        '
        'lblPrompt
        '
        Me.lblPrompt.AccessibleDescription = CType(resources.GetObject("lblPrompt.AccessibleDescription"), String)
        Me.lblPrompt.AccessibleName = CType(resources.GetObject("lblPrompt.AccessibleName"), String)
        Me.lblPrompt.Anchor = CType(resources.GetObject("lblPrompt.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.AutoSize = CType(resources.GetObject("lblPrompt.AutoSize"), Boolean)
        Me.lblPrompt.Dock = CType(resources.GetObject("lblPrompt.Dock"), System.Windows.Forms.DockStyle)
        Me.lblPrompt.Enabled = CType(resources.GetObject("lblPrompt.Enabled"), Boolean)
        Me.lblPrompt.Font = CType(resources.GetObject("lblPrompt.Font"), System.Drawing.Font)
        Me.lblPrompt.Image = CType(resources.GetObject("lblPrompt.Image"), System.Drawing.Image)
        Me.lblPrompt.ImageAlign = CType(resources.GetObject("lblPrompt.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblPrompt.ImageIndex = CType(resources.GetObject("lblPrompt.ImageIndex"), Integer)
        Me.lblPrompt.ImeMode = CType(resources.GetObject("lblPrompt.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblPrompt.Location = CType(resources.GetObject("lblPrompt.Location"), System.Drawing.Point)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.RightToLeft = CType(resources.GetObject("lblPrompt.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblPrompt.Size = CType(resources.GetObject("lblPrompt.Size"), System.Drawing.Size)
        Me.lblPrompt.TabIndex = CType(resources.GetObject("lblPrompt.TabIndex"), Integer)
        Me.lblPrompt.Text = resources.GetString("lblPrompt.Text")
        Me.lblPrompt.TextAlign = CType(resources.GetObject("lblPrompt.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblPrompt.Visible = CType(resources.GetObject("lblPrompt.Visible"), Boolean)
        '
        'InputBox
        '
        Me.AcceptButton = Me.btnOk
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPrompt, Me.txtAnswer, Me.btnOk, Me.btnCancel})
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
        Me.Name = "InputBox"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Function Display(ByVal Prompt As String, ByVal Title As String, Optional ByVal DefaultResponse As String = "") As String

        With lblPrompt
            .Text = Prompt
        End With
        With txtAnswer
            .Text = DefaultResponse
        End With

        Me.Text = Title

        txtAnswer.Multiline = False 
        txtAnswer.HideSelection = False 
        txtAnswer.TabStop = True 
        txtAnswer.TabIndex = 0 
        txtAnswer.Focus() 
        txtAnswer.SelectAll() 

        Me.ShowDialog()

        Display = RetVal
    End Function
    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        RetVal = txtAnswer.Text
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub InputBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOk.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        Me.TopMost = mbooTopMost 

        SetBackcolors() 

        txtAnswer.Multiline = False 

        txtAnswer.HideSelection = False 

        mbooFormJustLoaded = True 
    End Sub

    Private Sub txtAnswer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAnswer.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnOk_Click(Nothing, Nothing)
        End If

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub InputBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnOk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnCancel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtAnswer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer.KeyPress
        
        If e.KeyChar = CR() Then
            e.Handled = True
        End If

    End Sub
    Sub SetBackcolors()

        'Added 
        lblPrompt.BackColor = Color.FromArgb(0, lblPrompt.BackColor)
        btnOk.BackColor = Color.FromArgb(0, btnOk.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub InputBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub InputBox_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If mbooFormJustLoaded = True Then
            mbooFormJustLoaded = False
            txtAnswer.TabStop = True 
            txtAnswer.TabIndex = 0 
            txtAnswer.Focus() 
            txtAnswer.SelectAll() 
        End If
    End Sub
End Class


