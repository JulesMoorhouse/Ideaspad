Public Class StatusDialog
    Inherits System.Windows.Forms.Form
    Friend lblStatus As System.Windows.Forms.Label
    'Friend WithEvents timTimer As System.Windows.Forms.Timer
    Dim mstrStatus As String
    Dim CallingForm As Form
    Public Property Status() As String
        Get
            Return mstrStatus
        End Get
        Set(ByVal Value As String)
            mstrStatus = Value
            lblStatus.Text = Value
            System.Windows.Forms.Application.DoEvents()

        End Set
    End Property
    Dim mbooTopMost As Boolean 
    Public Property TopMostIn() As Boolean 
        Get
            Return mbooTopMost
        End Get
        Set(ByVal Value As Boolean)
            mbooTopMost = Value
        End Set
    End Property
    Sub New(ByVal pme As Form)
        MyBase.New()
        CallingForm = pme
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.Owner = pme
        Me.TopMost = mbooTopMost
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 32)
        Me.StartPosition = FormStartPosition.CenterScreen 

        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(336, 23)
        Me.lblStatus.Top = 8 
        Me.lblStatus.Left = 16 
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = ""


        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblStatus})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmValidateStatus"
        Me.ShowInTaskbar = False

        Me.Text = ""
        Me.ControlBox = False
        Me.ResumeLayout(False)

    End Sub
    'Private Sub StatusDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    '    Me.Top = (CallingForm.Height / 2) - (Me.Height / 2) + CallingForm.Top
    '    Me.Left = (CallingForm.Width / 2) - (Me.Width / 2) + CallingForm.Left

    'End Sub

    'Private Sub StatusDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub

    ''Private Sub InitializeComponent()
    ''    '
    ''    'StatusDialog
    ''    '
    ''    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    ''    Me.ClientSize = New System.Drawing.Size(292, 273)
    ''    Me.Name = "StatusDialog"

    ''End Sub

    Private Sub StatusDialog_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub

    Private Sub StatusDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If mbooTopMost = True Then
            Me.TopMost = True
        End If

    End Sub
End Class
