Imports System.Diagnostics.FileVersionInfo
Friend Class frmAbout
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
    Friend WithEvents lblProdVer As System.Windows.Forms.Label
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents lblCompName As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblProdVer = New System.Windows.Forms.Label()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'lblProdVer
        '
        Me.lblProdVer.Location = New System.Drawing.Point(16, 80)
        Me.lblProdVer.Name = "lblProdVer"
        Me.lblProdVer.Size = New System.Drawing.Size(200, 16)
        Me.lblProdVer.TabIndex = 0
        Me.lblProdVer.Text = "ProdVer"
        '
        'lblProdName
        '
        Me.lblProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProdName.Location = New System.Drawing.Point(11, 8)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(269, 64)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "ProdName"
        '
        'lblCompName
        '
        Me.lblCompName.Location = New System.Drawing.Point(16, 96)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(272, 16)
        Me.lblCompName.TabIndex = 2
        Me.lblCompName.Text = "CompName"
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(16, 112)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(272, 16)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "Copyright"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(288, 136)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(304, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(370, 167)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.btnOK, Me.lblCopyright, Me.lblCompName, Me.lblProdName, Me.lblProdVer})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About IdeasPad"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        Try
            Dim Res As New IPIconsPack.Resource()
            PictureBox1.Image = Res.picMCLLogo.Image
        Catch
        End Try
        

        With GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
            Me.Text = NameMe("About") ' & .ProductName) 
            lblProdName.Text = .ProductName '& "™"
            lblProdVer.Text = "Version " & .ProductVersion
            lblCompName.Text = "Developed by " & .CompanyName
            lblCopyright.Text = .LegalCopyright
        End With

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Me.Close()
    End Sub

    Private Sub frmAbout_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub

    ''Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
    ''    xxx()
    ''End Sub

    ''Private Sub frmAbout_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    ''    Me.Invalidate() 
    ''End Sub
End Class
