Public Class Resources
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
    Friend WithEvents ilToolButtons As System.Windows.Forms.ImageList
    Friend WithEvents ilTreeIcons As System.Windows.Forms.ImageList
    Friend WithEvents picMCLLogo As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Resources))
        Me.ilToolButtons = New System.Windows.Forms.ImageList(Me.components)
        Me.ilTreeIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.picMCLLogo = New System.Windows.Forms.PictureBox()
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
        'Resources
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(160, 109)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.picMCLLogo})
        Me.Name = "Resources"
        Me.Text = "Resources"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Resources_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
