Namespace IPIconsPack
    Public Class Resource
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
        Friend WithEvents picMCLLogo As System.Windows.Forms.PictureBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Resource))
            Me.picMCLLogo = New System.Windows.Forms.PictureBox
            Me.SuspendLayout()
            '
            'picMCLLogo
            '
            Me.picMCLLogo.Image = CType(resources.GetObject("picMCLLogo.Image"), System.Drawing.Bitmap)
            Me.picMCLLogo.Location = New System.Drawing.Point(32, 16)
            Me.picMCLLogo.Name = "picMCLLogo"
            Me.picMCLLogo.Size = New System.Drawing.Size(64, 64)
            Me.picMCLLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picMCLLogo.TabIndex = 0
            Me.picMCLLogo.TabStop = False
            '
            'MCLLogo
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(120, 117)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.picMCLLogo})
            Me.Name = "MCLLogo"
            Me.Text = "MCLLogo"
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub MCLLogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace