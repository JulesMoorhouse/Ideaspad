Class SplitCell
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
    Friend WithEvents labRow As System.Windows.Forms.Label
    Friend WithEvents nudRows As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCols As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents labCols As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.labRow = New System.Windows.Forms.Label
        Me.labCols = New System.Windows.Forms.Label
        Me.nudRows = New System.Windows.Forms.NumericUpDown
        Me.nudCols = New System.Windows.Forms.NumericUpDown
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labRow
        '
        Me.labRow.Location = New System.Drawing.Point(69, 10)
        Me.labRow.Name = "labRow"
        Me.labRow.Size = New System.Drawing.Size(40, 16)
        Me.labRow.TabIndex = 0
        Me.labRow.Text = "Rows:"
        '
        'labCols
        '
        Me.labCols.Location = New System.Drawing.Point(56, 42)
        Me.labCols.Name = "labCols"
        Me.labCols.Size = New System.Drawing.Size(56, 16)
        Me.labCols.TabIndex = 1
        Me.labCols.Text = "Columns:"
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(120, 8)
        Me.nudRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(64, 20)
        Me.nudRows.TabIndex = 2
        Me.nudRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudCols
        '
        Me.nudCols.Location = New System.Drawing.Point(120, 40)
        Me.nudCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCols.Name = "nudCols"
        Me.nudCols.Size = New System.Drawing.Size(64, 20)
        Me.nudCols.TabIndex = 3
        Me.nudCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(32, 88)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(152, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        '
        'SplitCell
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(258, 128)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.nudCols)
        Me.Controls.Add(Me.nudRows)
        Me.Controls.Add(Me.labCols)
        Me.Controls.Add(Me.labRow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SplitCell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Split cell"
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ReadOnly Property Rows() As Integer
        Get
            Return nudRows.Value
        End Get
    End Property

    Public ReadOnly Property Columns() As Integer
        Get
            Return nudCols.Value()
        End Get
    End Property


    Private Sub SetStyles()
        labRow.BackColor = Color.FromArgb(0, labRow.BackColor)
        labCols.BackColor = Color.FromArgb(0, labCols.BackColor)
        btnOk.BackColor = Color.FromArgb(0, btnOk.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
    End Sub

    Private Sub TableConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStyles()
        labRow.Text = TranslationTable.GetTranslation("rownumber")
        labCols.Text = TranslationTable.GetTranslation("columnnumber")
        btnOk.Text = TranslationTable.GetTranslation("buttonok")
        btnCancel.Text = TranslationTable.GetTranslation("buttoncancel")
        Me.Text = TranslationTable.GetTranslation("formsplit")
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting
        PaintBack.PaintBackground(pevent, Me)

    End Sub
End Class
