Public Class Privacy
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
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
    Friend WithEvents txtReport As StopCopyTextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblProblemReport As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtReport = New StopCopyTextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblProblemReport = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(16, 72)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(352, 248)
        Me.txtReport.TabIndex = 0
        Me.txtReport.TabStop = False
        Me.txtReport.Text = ""
        '
        'lblStatement
        '
        Me.lblStatement.ForeColor = System.Drawing.Color.Blue
        Me.lblStatement.Location = New System.Drawing.Point(16, 16)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(352, 32)
        Me.lblStatement.TabIndex = 1
        Me.lblStatement.Text = "Your privacy is important to us! No personal information is sent to Mindwarp Cons" & _
        "ultancy Ltd, from this process."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(296, 328)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        '
        'lblProblemReport
        '
        Me.lblProblemReport.Location = New System.Drawing.Point(16, 56)
        Me.lblProblemReport.Name = "lblProblemReport"
        Me.lblProblemReport.Size = New System.Drawing.Size(136, 16)
        Me.lblProblemReport.TabIndex = 3
        Me.lblProblemReport.Text = "Problem Report :"
        '
        'Privacy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 360)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblProblemReport, Me.btnClose, Me.lblStatement, Me.txtReport})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Privacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Privacy"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Property Report() As String
        Get
            Return txtReport.Text
        End Get
        Set(ByVal Value As String)
            txtReport.Text = Value
        End Set
    End Property
    Public Property Statement() As String
        Get
            Return lblStatement.Text
        End Get
        Set(ByVal Value As String)
            lblStatement.Text = Value
        End Set
    End Property
    Public Property Caption() As String
        Get
            Return Me.Text
        End Get
        Set(ByVal Value As String)
            Me.Text = Value
        End Set
    End Property
    Public Property CloseText() As String
        Get
            Return btnClose.Text
        End Get
        Set(ByVal Value As String)
            btnClose.Text = Value
        End Set
    End Property
    Public Property ReportLabel() As String
        Get
            Return lblProblemReport.Text
        End Get
        Set(ByVal Value As String)
            lblProblemReport.Text = Value
        End Set
    End Property
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Privacy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then 
            btnClose.FlatStyle = FlatStyle.System
        End If 
        

        
        lblStatement.Height += 10
        lblStatement.Top -= 10
        

        SetBackcolors()

        KeyPreview = True 

    End Sub
    Sub SetBackcolors()

        'Added 
        lblStatement.BackColor = Color.FromArgb(0, lblStatement.BackColor)
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)
        lblProblemReport.BackColor = Color.FromArgb(0, lblProblemReport.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub Privacy_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub Privacy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        
        If e.KeyCode = Keys.Escape Then
            btnClose_Click(Nothing, Nothing)
        End If
        

    End Sub
End Class
