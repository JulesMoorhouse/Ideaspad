Imports System.IO
Imports System.Drawing.Printing
Public Class LicenceBox
    Inherits Form
    Dim micoFormIcon As Icon
    Dim mPageSettings As PageSettings
    Dim mstrProductName As String = ""
    Dim mstrLicenseSectionSkip As String = ""
    Public WriteOnly Property LicenseSectionSkip() As String
        Set(ByVal Value As String)
            mstrLicenseSectionSkip = Value
        End Set
    End Property
    Public WriteOnly Property ProdName() As String
        Set(ByVal Value As String)
            mstrProductName = Value
        End Set
    End Property
    Public Property SetPageSettings() As PageSettings
        Get
            Return mPageSettings
        End Get
        Set(ByVal Value As PageSettings)
            mPageSettings = Value
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtLicenseBox As System.Windows.Forms.TextBox
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
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LicenceBox))
        Me.txtLicenseBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'txtLicenseBox
        '
        Me.txtLicenseBox.AccessibleDescription = CType(resources.GetObject("txtLicenseBox.AccessibleDescription"), String)
        Me.txtLicenseBox.AccessibleName = CType(resources.GetObject("txtLicenseBox.AccessibleName"), String)
        Me.txtLicenseBox.Anchor = CType(resources.GetObject("txtLicenseBox.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtLicenseBox.AutoSize = CType(resources.GetObject("txtLicenseBox.AutoSize"), Boolean)
        Me.txtLicenseBox.BackgroundImage = CType(resources.GetObject("txtLicenseBox.BackgroundImage"), System.Drawing.Image)
        Me.txtLicenseBox.Dock = CType(resources.GetObject("txtLicenseBox.Dock"), System.Windows.Forms.DockStyle)
        Me.txtLicenseBox.Enabled = CType(resources.GetObject("txtLicenseBox.Enabled"), Boolean)
        Me.txtLicenseBox.Font = CType(resources.GetObject("txtLicenseBox.Font"), System.Drawing.Font)
        Me.txtLicenseBox.ImeMode = CType(resources.GetObject("txtLicenseBox.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtLicenseBox.Location = CType(resources.GetObject("txtLicenseBox.Location"), System.Drawing.Point)
        Me.txtLicenseBox.MaxLength = CType(resources.GetObject("txtLicenseBox.MaxLength"), Integer)
        Me.txtLicenseBox.Multiline = CType(resources.GetObject("txtLicenseBox.Multiline"), Boolean)
        Me.txtLicenseBox.Name = "txtLicenseBox"
        Me.txtLicenseBox.PasswordChar = CType(resources.GetObject("txtLicenseBox.PasswordChar"), Char)
        Me.txtLicenseBox.ReadOnly = True
        Me.txtLicenseBox.RightToLeft = CType(resources.GetObject("txtLicenseBox.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtLicenseBox.ScrollBars = CType(resources.GetObject("txtLicenseBox.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtLicenseBox.Size = CType(resources.GetObject("txtLicenseBox.Size"), System.Drawing.Size)
        Me.txtLicenseBox.TabIndex = CType(resources.GetObject("txtLicenseBox.TabIndex"), Integer)
        Me.txtLicenseBox.Text = resources.GetString("txtLicenseBox.Text")
        Me.txtLicenseBox.TextAlign = CType(resources.GetObject("txtLicenseBox.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtLicenseBox.Visible = CType(resources.GetObject("txtLicenseBox.Visible"), Boolean)
        Me.txtLicenseBox.WordWrap = CType(resources.GetObject("txtLicenseBox.WordWrap"), Boolean)
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = CType(resources.GetObject("btnClose.AccessibleDescription"), String)
        Me.btnClose.AccessibleName = CType(resources.GetObject("btnClose.AccessibleName"), String)
        Me.btnClose.Anchor = CType(resources.GetObject("btnClose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Dock = CType(resources.GetObject("btnClose.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClose.Enabled = CType(resources.GetObject("btnClose.Enabled"), Boolean)
        Me.btnClose.FlatStyle = CType(resources.GetObject("btnClose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnClose.Font = CType(resources.GetObject("btnClose.Font"), System.Drawing.Font)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = CType(resources.GetObject("btnClose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.ImageIndex = CType(resources.GetObject("btnClose.ImageIndex"), Integer)
        Me.btnClose.ImeMode = CType(resources.GetObject("btnClose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClose.Location = CType(resources.GetObject("btnClose.Location"), System.Drawing.Point)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = CType(resources.GetObject("btnClose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnClose.Size = CType(resources.GetObject("btnClose.Size"), System.Drawing.Size)
        Me.btnClose.TabIndex = CType(resources.GetObject("btnClose.TabIndex"), Integer)
        Me.btnClose.Text = resources.GetString("btnClose.Text")
        Me.btnClose.TextAlign = CType(resources.GetObject("btnClose.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.Visible = CType(resources.GetObject("btnClose.Visible"), Boolean)
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleDescription = CType(resources.GetObject("btnPrint.AccessibleDescription"), String)
        Me.btnPrint.AccessibleName = CType(resources.GetObject("btnPrint.AccessibleName"), String)
        Me.btnPrint.Anchor = CType(resources.GetObject("btnPrint.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.Dock = CType(resources.GetObject("btnPrint.Dock"), System.Windows.Forms.DockStyle)
        Me.btnPrint.Enabled = CType(resources.GetObject("btnPrint.Enabled"), Boolean)
        Me.btnPrint.FlatStyle = CType(resources.GetObject("btnPrint.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnPrint.Font = CType(resources.GetObject("btnPrint.Font"), System.Drawing.Font)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = CType(resources.GetObject("btnPrint.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnPrint.ImageIndex = CType(resources.GetObject("btnPrint.ImageIndex"), Integer)
        Me.btnPrint.ImeMode = CType(resources.GetObject("btnPrint.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnPrint.Location = CType(resources.GetObject("btnPrint.Location"), System.Drawing.Point)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = CType(resources.GetObject("btnPrint.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnPrint.Size = CType(resources.GetObject("btnPrint.Size"), System.Drawing.Size)
        Me.btnPrint.TabIndex = CType(resources.GetObject("btnPrint.TabIndex"), Integer)
        Me.btnPrint.Text = resources.GetString("btnPrint.Text")
        Me.btnPrint.TextAlign = CType(resources.GetObject("btnPrint.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnPrint.Visible = CType(resources.GetObject("btnPrint.Visible"), Boolean)
        '
        'PrintDocument1
        '
        '
        'LicenceBox
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.btnClose, Me.txtLicenseBox})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "LicenceBox"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Sub display()

    '    Me.Icon = micoFormIcon
    '    'Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream(Me.GetType().Assembly.GetName.Name & ".license.txt")
    '    
    '    'commented out 
    '    ''Dim stream As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream( _
    '    ''    Me.GetType().Assembly.GetEntryAssembly.GetName.Name & ".license.txt")

    '    '''Dim OpenFile As FileStream = New FileStream("D:\temp\mdsecurelicense.txt", FileMode.Open, FileAccess.Read, FileShare.Read)
    '    ''Dim StreamReader As StreamReader = New StreamReader(stream)
    '    ''txtLicenseBox.Text = StreamReader.ReadToEnd
    '    ''StreamReader.Close()
    '    '''OpenFile.Close()
    '    ''stream.Close()
    '    txtLicenseBox.SelectionLength = 0

    '    Me.ShowDialog()

    'End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LicenceBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnClose_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Declare a variable to hold the position of the last printed char. Declare
        ' as static so that subsequent PrintPage events can reference it.
        Static intCurrentChar As Int32
        ' Initialize the font to be used for printing.
        Dim font As New Font("Arial", 11)

        Dim intPrintAreaHeight, intPrintAreaWidth, marginLeft, marginTop As Int32
        With PrintDocument1.DefaultPageSettings
            ' Initialize local variables that contain the bounds of the printing 
            ' area rectangle.
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right

            ' Initialize local variables to hold margin values that will serve
            ' as the X and Y coordinates for the upper left corner of the printing 
            ' area rectangle.
            marginLeft = .Margins.Left ' X coordinate
            marginTop = .Margins.Top ' Y coordinate
        End With

        ' If the user selected Landscape mode, swap the printing area height 
        ' and width.
        If PrintDocument1.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If

        ' Calculate the total number of lines in the document based on the height of
        ' the printing area and the height of the font.
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / font.Height)
        ' Initialize the rectangle structure that defines the printing area.
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight)

        ' Instantiate the StringFormat class, which encapsulates text layout 
        ' information (such as alignment and line spacing), display manipulations 
        ' (such as ellipsis insertion and national digit substitution) and OpenType 
        ' features. Use of StringFormat causes MeasureString and DrawString to use
        ' only an integer number of lines when printing each page, ignoring partial
        ' lines that would otherwise likely be printed if the number of lines per 
        ' page do not divide up cleanly for each page (which is usually the case).
        ' See further discussion in the SDK documentation about StringFormatFlags.
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        ' Call MeasureString to determine the number of characters that will fit in
        ' the printing area rectangle. The CharFitted Int32 is passed ByRef and used
        ' later when calculating intCurrentChar and thus HasMorePages. LinesFilled 
        ' is not needed for this sample but must be passed when passing CharsFitted.
        ' Mid is used to pass the segment of remaining text left off from the 
        ' previous page of printing (recall that intCurrentChar was declared as 
        ' static.
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Microsoft.VisualBasic.Mid(txtLicenseBox.Text, intCurrentChar + 1), font, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, _
                    intCharsFitted, intLinesFilled)

        ' Print the text to the page.
        e.Graphics.DrawString(Microsoft.VisualBasic.Mid(txtLicenseBox.Text, intCurrentChar + 1), font, _
            Brushes.Black, rectPrintingArea, fmt)

        ' Advance the current char to the last char printed on this page. As 
        ' intCurrentChar is a static variable, its value can be used for the next
        ' page to be printed. It is advanced by 1 and passed to Mid() to print the
        ' next page (see above in MeasureString()).
        intCurrentChar += intCharsFitted

        ' HasMorePages tells the printing module whether another PrintPage event
        ' should be fired.
        If intCurrentChar < txtLicenseBox.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            ' You must explicitly reset intCurrentChar as it is static.
            intCurrentChar = 0
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim PrintResult As DialogResult
        PrintDocument1.DefaultPageSettings = mPageSettings

        With PrintDialog1
            .Document = PrintDocument1
            Busy(Me, False)
            PrintResult = .ShowDialog
            If PrintResult = DialogResult.OK Then
                Busy(Me, True)
                PrintDocument1.Print()
            End If
        End With
        Busy(Me, False)
    End Sub

    Private Sub LicenceBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If IsAboveOrEqualWinXp() = True Then  
            btnPrint.FlatStyle = FlatStyle.System
            btnClose.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        If mstrLicenseSectionSkip <> "" And Not mstrLicenseSectionSkip Is Nothing Then 
            txtLicenseBox.Text = txtLicenseBox.Text.Replace(mstrLicenseSectionSkip, "")
        End If

        If mstrProductName <> "" And Not mstrProductName Is Nothing Then 
            txtLicenseBox.Text = txtLicenseBox.Text.Replace("###PRODUCT###", mstrProductName)
        End If

    End Sub
    Sub SetBackcolors()

        'Added 
        btnPrint.BackColor = Color.FromArgb(0, btnPrint.BackColor)
        btnClose.BackColor = Color.FromArgb(0, btnClose.BackColor)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub LicenceBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
