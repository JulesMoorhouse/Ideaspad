Class CollapsiblePanel
    Inherits System.Windows.Forms.UserControl

    Private inner As Control
    Private mWidth, mHeight As Integer


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelContent As System.Windows.Forms.Panel
    Friend WithEvents labDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.panelContent = New System.Windows.Forms.Panel
        Me.labDescription = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Advanced properties"
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.SystemColors.Control
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 32)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(304, 416)
        Me.panelContent.TabIndex = 1
        '
        'labDescription
        '
        Me.labDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.labDescription.Location = New System.Drawing.Point(0, 16)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(304, 16)
        Me.labDescription.TabIndex = 2
        '
        'CollapsiblePanel
        '
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CollapsiblePanel"
        Me.Size = New System.Drawing.Size(304, 448)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Property InnerControl() As Control
        Get
            Return inner
        End Get
        Set(ByVal Value As Control)
            inner = Value
            panelContent.Controls.Clear()
            If Not inner Is Nothing Then
                panelContent.Controls.Add(inner)
                inner.Dock = DockStyle.Fill
            End If
        End Set
    End Property

    Public Property Description() As String
        Get
            Return labDescription.Text
        End Get
        Set(ByVal Value As String)
            labDescription.Text = Value
        End Set
    End Property

    Public Property MaxWidth() As Integer
        Get
            Return mWidth
        End Get
        Set(ByVal Value As Integer)
            mWidth = Value
        End Set
    End Property

    Public Property MaxHeight() As Integer
        Get
            Return mHeight
        End Get
        Set(ByVal Value As Integer)
            mHeight = Value
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        MyBase.OnSizeChanged(e)

        If mWidth <> 0 AndAlso Me.Width > mWidth Then
            Me.Width = mWidth
        End If

        If mHeight <> 0 AndAlso Me.Height > mHeight Then
            Me.Height = mHeight
        End If
    End Sub
End Class
