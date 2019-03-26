Public Class Resource
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
    Public WithEvents ilToolButtons As System.Windows.Forms.ImageList
    Public WithEvents ilTreeIcons As System.Windows.Forms.ImageList
    Public WithEvents picMCLLogo As System.Windows.Forms.PictureBox
    Public WithEvents picBand1 As System.Windows.Forms.PictureBox
    Public WithEvents picBand2 As System.Windows.Forms.PictureBox
    Public WithEvents picBand3 As System.Windows.Forms.PictureBox
    Public WithEvents ilSearch As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Resource))
        Me.ilToolButtons = New System.Windows.Forms.ImageList(Me.components)
        Me.ilTreeIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.picMCLLogo = New System.Windows.Forms.PictureBox()
        Me.picBand1 = New System.Windows.Forms.PictureBox()
        Me.picBand2 = New System.Windows.Forms.PictureBox()
        Me.picBand3 = New System.Windows.Forms.PictureBox()
        Me.ilSearch = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ilToolButtons
        '
        Me.ilToolButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilToolButtons.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilToolButtons.ImageStream = CType(resources.GetObject("ilToolButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolButtons.TransparentColor = System.Drawing.Color.Transparent
        '
        'ilTreeIcons
        '
        Me.ilTreeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ilTreeIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilTreeIcons.ImageStream = CType(resources.GetObject("ilTreeIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTreeIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'picMCLLogo
        '
        Me.picMCLLogo.Image = CType(resources.GetObject("picMCLLogo.Image"), System.Drawing.Bitmap)
        Me.picMCLLogo.Location = New System.Drawing.Point(24, 8)
        Me.picMCLLogo.Name = "picMCLLogo"
        Me.picMCLLogo.Size = New System.Drawing.Size(56, 56)
        Me.picMCLLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMCLLogo.TabIndex = 0
        Me.picMCLLogo.TabStop = False
        '
        'picBand1
        '
        Me.picBand1.Image = CType(resources.GetObject("picBand1.Image"), System.Drawing.Bitmap)
        Me.picBand1.Location = New System.Drawing.Point(144, 8)
        Me.picBand1.Name = "picBand1"
        Me.picBand1.Size = New System.Drawing.Size(16, 24)
        Me.picBand1.TabIndex = 1
        Me.picBand1.TabStop = False
        '
        'picBand2
        '
        Me.picBand2.Image = CType(resources.GetObject("picBand2.Image"), System.Drawing.Bitmap)
        Me.picBand2.Location = New System.Drawing.Point(88, 56)
        Me.picBand2.Name = "picBand2"
        Me.picBand2.Size = New System.Drawing.Size(24, 56)
        Me.picBand2.TabIndex = 2
        Me.picBand2.TabStop = False
        '
        'picBand3
        '
        Me.picBand3.Image = CType(resources.GetObject("picBand3.Image"), System.Drawing.Bitmap)
        Me.picBand3.Location = New System.Drawing.Point(152, 48)
        Me.picBand3.Name = "picBand3"
        Me.picBand3.Size = New System.Drawing.Size(24, 88)
        Me.picBand3.TabIndex = 3
        Me.picBand3.TabStop = False
        '
        'ilSearch
        '
        Me.ilSearch.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilSearch.ImageSize = New System.Drawing.Size(36, 16)
        Me.ilSearch.ImageStream = CType(resources.GetObject("ilSearch.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSearch.TransparentColor = System.Drawing.Color.Transparent
        '
        'Resource
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 134)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.picBand3, Me.picBand2, Me.picBand1, Me.picMCLLogo})
        Me.Name = "Resource"
        Me.Text = "Resources"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Resources_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
