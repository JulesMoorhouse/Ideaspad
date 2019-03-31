Class DoubleBufferedPanel
    Inherits System.Windows.Forms.Panel

    Private backBuffer As Bitmap 'For double buffering
    Private rend As Renderer


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Public Property Renderer() As Renderer
        Get
            Return rend
        End Get
        Set(ByVal Value As Renderer)
            rend = Value
        End Set
    End Property

    Protected Overrides Sub onpaintbackground(ByVal e As PaintEventArgs)
        'MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Me.backBuffer Is Nothing Then
            If Width <> 0 And Height <> 0 Then
                Me.backBuffer = New Bitmap(Width, Height)
            End If
        End If

        If Not rend Is Nothing And Not Me.backBuffer Is Nothing Then
            ' Draw to the back buffer
            Dim g As Graphics = Graphics.FromImage(backBuffer)
            g.Clear(BackColor)
            rend.RenderTo(Me, g)

            ' Copy the back buffer to the screen
            e.Graphics.DrawImageUnscaled(Me.backBuffer, 0, 0)
            g.Dispose()
        Else
            e.Graphics.Clear(BackColor)
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        If Not backBuffer Is Nothing Then
            backBuffer.Dispose()
            backBuffer = Nothing
        End If
        Refresh()
    End Sub



End Class
