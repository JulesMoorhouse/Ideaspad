Class DefineTable
    Inherits System.Windows.Forms.Form

    Class MyPanel
        Inherits Panel

        Protected Overrides Sub onpaintbackground(ByVal e As PaintEventArgs)
        End Sub

    End Class

    Private row As Integer
    Private col As Integer

    Private totalRows As Integer
    Private totalCols As Integer

    Private backBuffer As Bitmap 'For double buffering

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
    Friend WithEvents panelTable As TableEditor.DefineTable.MyPanel

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents labTableDim As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panelTable = New TableEditor.DefineTable.MyPanel
        Me.labTableDim = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'panelTable
        '
        Me.panelTable.Location = New System.Drawing.Point(8, 32)
        Me.panelTable.Name = "panelTable"
        Me.panelTable.Size = New System.Drawing.Size(121, 121)
        Me.panelTable.TabIndex = 0
        '
        'labTableDim
        '
        Me.labTableDim.Location = New System.Drawing.Point(5, 8)
        Me.labTableDim.Name = "labTableDim"
        Me.labTableDim.Size = New System.Drawing.Size(296, 23)
        Me.labTableDim.TabIndex = 1
        Me.labTableDim.Text = "Table dimensions:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(32, 168)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Button1"
        '
        'DefineTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(138, 208)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.labTableDim)
        Me.Controls.Add(Me.panelTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DefineTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Define table"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SetStyles()
        labTableDim.BackColor = Color.FromArgb(0, labTableDim.BackColor)
    End Sub

    Public ReadOnly Property Rows() As Integer
        Get
            Return row
        End Get
    End Property

    Public ReadOnly Property Columns() As Integer
        Get
            Return col
        End Get
    End Property

    Private Sub panelTable_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelTable.Paint
        If backBuffer Is Nothing Then
            backBuffer = New Bitmap(Width, Height)
        End If

        ' Draw to the back buffer
        Dim g As Graphics = Graphics.FromImage(backBuffer)

        g.DrawRectangle(Pens.Black, 0, 0, panelTable.Width - 1, panelTable.Height - 1)

        Dim xs As Integer = 20
        Dim ys As Integer = 20
        Dim i As Integer 
        Dim j As Integer 

        For i = 0 To totalCols
            For j = 0 To totalRows
                If i < col And j < row Then
                    g.FillRectangle(Brushes.LightBlue, i * xs, j * ys, xs, ys)
                Else
                    g.FillRectangle(Brushes.White, i * xs, j * ys, xs, ys)
                End If
                g.DrawRectangle(Pens.Black, i * xs, j * ys, xs, ys)
            Next
        Next
        g.Dispose()
        e.Graphics.DrawImageUnscaled(backBuffer, 0, 0)
    End Sub

    Private Sub panelTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelTable.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub panelTable_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTable.MouseMove
        row = e.Y \ 20 + 1
        If row = totalRows Then
            totalRows += 1
            panelTable.Height += 20
            Me.Height += 20

            Refresh()
        End If
        col = e.X \ 20 + 1
        If col = totalCols Then
            totalCols += 1
            panelTable.Width += 20
            Me.Width += 20
            btnCancel.Left = Me.Width / 2 - btnCancel.Width / 2

            Refresh()
        End If
        labTableDim.Text = TranslationTable.GetTranslation("tabledimensions") + ": " + row.ToString + " x " + col.ToString
        panelTable.Invalidate()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        Dim PaintBack As New UIStyle.Painting
        PaintBack.PaintBackground(pevent, Me)
    End Sub

    Private Sub DefineTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStyles()
        totalRows = 6
        totalCols = 6
        Me.Text = TranslationTable.GetTranslation("formdefinetable")
        btnCancel.Text = TranslationTable.GetTranslation("buttoncancel")
    End Sub

    Private Sub panelTable_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelTable.SizeChanged
        If Not backBuffer Is Nothing Then
            backBuffer.Dispose()
            backBuffer = Nothing
        End If
    End Sub
End Class

