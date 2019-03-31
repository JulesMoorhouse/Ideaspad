Public Class ls
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
    Friend WithEvents lstLanguages As System.Windows.Forms.ListBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstLanguages = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'lstLanguages
        '
        Me.lstLanguages.Items.AddRange(New Object() {"English", "Deutsch"})
        Me.lstLanguages.Location = New System.Drawing.Point(16, 56)
        Me.lstLanguages.Name = "lstLanguages"
        Me.lstLanguages.Size = New System.Drawing.Size(152, 108)
        Me.lstLanguages.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(248, 144)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please you select your national language :"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bitte wählen Sie Ihre Landessprache aus :"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(272, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ls
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(338, 183)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.Label2, Me.Label1, Me.btnOK, Me.lstLanguages})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ideaspad"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim micoFormIcon As Icon
    Dim mimgMCLLogo As Image 
    'Public Const SC_CLOSE As Integer = 61536 
    'Public Const WM_SYSCOMMAND As Integer = 274 

    Public Property MCLLogo() As Image 
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mimgMCLLogo
        End Get
        Set(ByVal Value As Image)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mimgMCLLogo = Value
        End Set
    End Property
    Public Property FormIcon() As Icon
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return micoFormIcon
        End Get
        Set(ByVal Value As Icon)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            micoFormIcon = Value
        End Set
    End Property
    Public Property Lang2Letters() As String
        Get
            Select Case lstLanguages.SelectedItem
                Case "Deutsch"
                    Return "de"
                Case Else
                    Return "en"
            End Select
        End Get
        Set(ByVal Value As String)
            '
        End Set
    End Property
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Me.Close()

    End Sub

    Private Sub ls_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnOK.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        Me.Icon = micoFormIcon
        PictureBox1.Image = mimgMCLLogo 

        Dim lstr2Chars As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToLower
        Select Case lstr2Chars
            Case "de"
                lstLanguages.SelectedIndex = 1
            Case Else
                lstLanguages.SelectedIndex = 0
        End Select
    End Sub

    'Private CloseButtonClicked As Boolean = False

    'Private Sub ls_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    If Me.CloseButtonClicked = True And lstLanguages.SelectedIndex = -1 Then
    '        Me.CloseButtonClicked = False 'reset close button detector
    '        e.Cancel = True
    '        Return
    '    End If
    'End Sub

    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
    '    If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_CLOSE Then
    '        Me.CloseButtonClicked = True
    '    End If
    '    MyBase.WndProc(m)
    'End Sub
    Sub SetBackcolors()

        'Added 
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label2.BackColor = Color.FromArgb(0, Label2.BackColor)
        btnOK.BackColor = Color.FromArgb(0, btnOK.BackColor)
        PictureBox1.BackColor = Color.FromArgb(0, PictureBox1.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub ls_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
